Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frmDailyBalance

    ' ------------------------------------------------------------------
    ' TODO: update this connection string for your environment
    ' ------------------------------------------------------------------
    Private ReadOnly connString As String = GMod.Connstr

    ' ==================================================================
    ' Load distinct account heads for the chosen company/session/date
    ' range into the checklist, from ACC_HEAD_<Company>_<Session>
    ' ==================================================================
    Private Sub btnLoadAccounts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadAccounts.Click
        clbAccountHeads.Items.Clear()
        lblStatus.Text = ""

        Dim companyCode As String = txtCompanyCode.Text.Trim()
        Dim session As String = txtSession.Text.Trim()
        Dim cmpId As String = txtCmpId.Text.Trim()

        If companyCode = "" Or session = "" Or cmpId = "" Then
            lblStatus.Text = "Please fill Company Code, Session and Cmp Id first."
            Exit Sub
        End If

        ' Table name assembled the same way the stored procedure does:
        ' ACC_HEAD_<CompanyCode>_<Session>. Validated against sys.tables
        ' (via OBJECT_ID) before use, since it's going into a query string.
        Dim tableName As String = "ACC_HEAD_" & companyCode & "_" & session

        Dim conn As SqlConnection = New SqlConnection(connString)
        Try
            conn.Open()

            Dim checkCmd As SqlCommand = New SqlCommand("SELECT OBJECT_ID('dbo.' + @t, 'U')", conn)
            checkCmd.Parameters.AddWithValue("@t", tableName)
            Dim objId As Object = checkCmd.ExecuteScalar()
            If objId Is Nothing OrElse objId Is DBNull.Value Then
                lblStatus.Text = "Table dbo." & tableName & " was not found."
                conn.Close()
                Exit Sub
            End If

            Dim sql As String = "SELECT DISTINCT account_code, account_head_name " & _
                                 "FROM dbo.[" & tableName & "] WHERE Cmp_id = @CmpId ORDER BY account_code"

            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@CmpId", cmpId)

            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read()
                Dim code As String = rdr("account_code").ToString()
                Dim acctName As String = rdr("account_head_name").ToString()
                clbAccountHeads.Items.Add(code & " - " & acctName)
            End While
            rdr.Close()

            If clbAccountHeads.Items.Count = 0 Then
                lblStatus.Text = "No account heads found for that company/session/Cmp Id."
            End If
        Catch ex As Exception
            lblStatus.Text = "Error loading accounts: " & ex.Message
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' ==================================================================
    ' Run the stored procedure with whatever the user has picked/typed
    ' ==================================================================
    Private Sub btnGetReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetReport.Click
        lblStatus.Text = ""
        dgvResult.DataSource = Nothing

        Dim companyCode As String = txtCompanyCode.Text.Trim()
        Dim session As String = txtSession.Text.Trim()
        Dim cmpId As String = txtCmpId.Text.Trim()

        If companyCode = "" Or session = "" Or cmpId = "" Then
            lblStatus.Text = "Please fill Company Code, Session and Cmp Id."
            Exit Sub
        End If

        If dtpFromDate.Value.Date > dtpToDate.Value.Date Then
            lblStatus.Text = "From Date cannot be after To Date."
            Exit Sub
        End If

        ' Build the comma-separated account code list from whatever is
        ' checked in the CheckedListBox (extract the code before " - ").
        Dim checkedCodes As New List(Of String)
        Dim i As Integer
        For i = 0 To clbAccountHeads.CheckedItems.Count - 1
            Dim itemText As String = clbAccountHeads.CheckedItems(i).ToString()
            Dim sepPos As Integer = itemText.IndexOf(" - ")
            Dim code As String
            If sepPos >= 0 Then
                code = itemText.Substring(0, sepPos).Trim()
            Else
                code = itemText.Trim()
            End If
            checkedCodes.Add(code)
        Next

        Dim accHeadCodes As Object
        If checkedCodes.Count > 0 Then
            accHeadCodes = String.Join(",", checkedCodes.ToArray())
        Else
            accHeadCodes = DBNull.Value
        End If

        Dim conn As SqlConnection = New SqlConnection(connString)
        Try
            Dim cmd As SqlCommand = New SqlCommand("dbo.usp_DailyBalance", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 120

            cmd.Parameters.AddWithValue("@CompanyCode", companyCode)
            cmd.Parameters.AddWithValue("@Session", session)
            cmd.Parameters.AddWithValue("@Cmp_id", cmpId)
            cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value.Date)
            cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value.Date)

            Dim accParam As SqlParameter = cmd.Parameters.AddWithValue("@AccHeadCodes", accHeadCodes)
            accParam.SqlDbType = SqlDbType.VarChar
            accParam.Size = -1 ' MAX

            Dim dt As DataTable = New DataTable()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(dt)

            dgvResult.DataSource = dt

            If dt.Rows.Count = 0 Then
                lblStatus.Text = "No data found for the selected filters."
            Else
                lblStatus.Text = dt.Rows.Count.ToString() & " row(s) returned."
            End If
        Catch ex As Exception
            lblStatus.Text = "Error running report: " & ex.Message
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' ==================================================================
    ' Simple CSV export of whatever is currently in the grid
    ' ==================================================================
    Private Sub btnExportCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportCsv.Click
        If dgvResult.DataSource Is Nothing OrElse dgvResult.Rows.Count = 0 Then
            lblStatus.Text = "Nothing to export - run the report first."
            Exit Sub
        End If

        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.Filter = "CSV files (*.csv)|*.csv"
        sfd.FileName = "DailyBalance.csv"

        If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

        Try
            Dim sb As StringBuilder = New StringBuilder()

            Dim colIndex As Integer
            Dim headerLine As String = ""
            For colIndex = 0 To dgvResult.Columns.Count - 1
                If colIndex > 0 Then headerLine = headerLine & ","
                headerLine = headerLine & dgvResult.Columns(colIndex).HeaderText
            Next
            sb.AppendLine(headerLine)

            Dim rowIndex As Integer
            For rowIndex = 0 To dgvResult.Rows.Count - 1
                Dim row As DataGridViewRow = dgvResult.Rows(rowIndex)
                If row.IsNewRow Then Continue For

                Dim rowLine As String = ""
                For colIndex = 0 To dgvResult.Columns.Count - 1
                    Dim cellValue As Object = row.Cells(colIndex).Value
                    Dim cellText As String
                    If cellValue Is Nothing OrElse cellValue Is DBNull.Value Then
                        cellText = ""
                    Else
                        cellText = cellValue.ToString().Replace(",", " ")
                    End If
                    If colIndex > 0 Then rowLine = rowLine & ","
                    rowLine = rowLine & cellText
                Next
                sb.AppendLine(rowLine)
            Next

            IO.File.WriteAllText(sfd.FileName, sb.ToString())
            lblStatus.Text = "Exported to " & sfd.FileName
        Catch ex As Exception
            lblStatus.Text = "Error exporting: " & ex.Message
        End Try
    End Sub

End Class
