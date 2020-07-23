Imports System.Data
Public Class frmMultiChequeList

    Private Sub frmMultiChequeList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub
    Sub nxtrecid()
        Try
            GMod.DataSetRet("SELECT isnull(max(Receipt_id),0) + 1 FROM " & GMod.CHQ_ISSUED & " where Rect_type='" & lblrect_type.Text & "' ", "nxtrec")
            GMod.ReciptId = Format(GMod.ds.Tables("nxtrec").Rows(0)(0), "0000000000")
            Dim q As Integer
            For q = 0 To dgMultiple.Rows.Count - 1
                dgMultiple(2, q).Value = Format(Val(GMod.ReciptId) + q, "0000000000")
                dgMultiple(5, q).Value = Format(Val(GMod.VouNo) + q)
            Next
        Catch ex As Exception
            MsgBox("RECEPIT ID NOT GENERATED" & ex.Message)
        End Try
    End Sub
    Private Sub frmMultiChequeList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        'Create the DataTable
        'Dim dt As New DataTable()
        ''Create the columns
        'Dim dcName As New DataColumn("Name", GetType(String))
        ''Add the columns to the DataTable's Columns collection
        'dt.Columns.Add(dcName)
        ''Add some rows
        'Dim dr As DataRow
        'dr = dt.NewRow()
        'dr("Name") = GMod.favourof
        'dt.Rows.Add(dr)

        ''cmbfavourof.DataSource = dt
        ''cmbfavourof.DisplayMember = "Name"
        ''MsgBox(dt.Rows(0)(0))
        '-----------------------------------------------------------------------------------------------------------------
        btnok.Focus()
        'Deleting recordds of tmp multiple table
        GMod.SqlExecuteNonQuery("delete from tmp_multiple_chq where Cmp_id='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")

        GMod.DataSetRet("select * from favof", "fav")
        Me.favourofm.DataSource = GMod.ds.Tables("fav")
        Me.favourofm.DisplayMember = "favourof"


        Dim q, n, i As Integer
        Dim zer As String = ""
        Dim zer1 As String = ""
        n = Val(GMod.no_of_cheque)
        For i = 0 To GMod.Chq_no.Length - 1
            zer = zer & "0"
        Next
        n = Val(GMod.no_of_cheque)

        For i = 0 To GMod.ReciptId.Length - 1
            zer1 = zer1 & "0"
        Next
        If GMod.ramdom = False Then
            dgMultipleM.Visible = False
            dgMultiple.Visible = True
            For q = 0 To n - 1
                dgMultiple.Rows.Add()
                dgMultiple(0, q).Value = Format(Val(GMod.Chq_no) + q, zer)
                dgMultiple(1, q).Value = GMod.favourof
                dgMultiple(2, q).Value = Format(Val(GMod.ReciptId) + q, zer1)
                dgMultiple(3, q).Value = GMod.damount.ToString
                dgMultiple(4, q).Value = CDate(GMod.chq_date.ToShortDateString)
                dgMultiple(5, q).Value = Format(Val(GMod.VouNo) + q)
            Next
        Else
            dgMultipleM.Visible = True
            dgMultiple.Visible = False
            For q = 0 To n - 1
                dgMultipleM.Rows.Add()
                dgMultipleM(0, q).Value = Format(Val(GMod.Chq_no) + q, zer)
                dgMultipleM(1, q).Value = GMod.favourof
                dgMultipleM(2, q).Value = Format(Val(GMod.ReciptId) + q, zer1)
                dgMultipleM(3, q).Value = GMod.damount.ToString
                dgMultipleM(4, q).Value = CDate(GMod.chq_date.ToShortDateString)
                dgMultipleM(5, q).Value = Format(Val(GMod.VouNo) + q)
            Next
        End If
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim sqlsavechq As String, i As Integer = 0
        If GMod.ramdom = False Then
            For i = 0 To dgMultiple.Rows.Count - 1
                sqlsavechq = "insert into tmp_multiple_chq (Cmp_id, Chq_no, favourof, recpitid, amount, Chq_date,Uname,vouno) values ( "
                sqlsavechq &= "'" & GMod.Cmpid & "',"
                sqlsavechq &= "'" & dgMultiple(0, i).Value & "',"
                sqlsavechq &= "'" & dgMultiple(1, i).Value & "',"
                sqlsavechq &= "'" & dgMultiple(2, i).Value & "',"
                sqlsavechq &= "'" & dgMultiple(3, i).Value & "',"
                sqlsavechq &= "'" & CDate(dgMultiple(4, i).Value) & "',"
                sqlsavechq &= "'" & GMod.username & "',"
                sqlsavechq &= "'" & dgMultiple(5, i).Value & "')"
                GMod.SqlExecuteNonQuery(sqlsavechq)
                'MsgBox(sqlsavechq)
            Next
        Else
            For i = 0 To dgMultipleM.Rows.Count - 1
                sqlsavechq = "insert into tmp_multiple_chq (Cmp_id, Chq_no, favourof, recpitid, amount,Chq_date, Uname,vouno) values ( "
                sqlsavechq &= "'" & GMod.Cmpid & "',"
                sqlsavechq &= "'" & dgMultipleM(0, i).Value & "',"
                sqlsavechq &= "'" & dgMultipleM(1, i).Value & "',"
                sqlsavechq &= "'" & dgMultipleM(2, i).Value & "',"
                sqlsavechq &= "'" & dgMultipleM(3, i).Value & "',"
                sqlsavechq &= "'" & CDate(dgMultipleM(4, i).Value) & "',"
                sqlsavechq &= "'" & GMod.username & "',"
                sqlsavechq &= "'" & dgMultipleM(5, i).Value & "')"
                GMod.SqlExecuteNonQuery(sqlsavechq)
            Next
        End If
        MessageBox.Show("Multiple cheque created", "Cheque information aved", MessageBoxButtons.OK)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nxtvnoCHQ()
        nxtrecid()
    End Sub
    Dim lastid As String
    Sub nxtvnoCHQ()
        Try
            Dim sql As String
            sql = "SELECT vou_no FROM " & GMod.VENTRY & " where vou_type='" _
            & GMod.ds.Tables("Chq_conf").Rows(0)(6).ToString & "' and  day(vou_date)=" & frmChequeIssued.dtIssuedate.Value.Day & " and month(vou_date)=" _
            & frmChequeIssued.dtIssuedate.Value.Month & " and year(vou_date)=" & frmChequeIssued.dtIssuedate.Value.Year & " order by cast(right(vou_no,4) as int) desc"

            GMod.DataSetRet(sql, "vno")

            If GMod.ds.Tables("vno").Rows.Count > 0 Then
                lastid = Format(Val(GMod.ds.Tables("vno").Rows(0)(0)) + 1, "000000000000")
            Else
                lastid = frmChequeIssued.dtIssuedate.Value.Year.ToString()
                If frmChequeIssued.dtIssuedate.Value.Month.ToString().Length = 1 Then
                    lastid = lastid & "0" & frmChequeIssued.dtIssuedate.Value.Month.ToString()
                Else
                    lastid = lastid & frmChequeIssued.dtIssuedate.Value.Month.ToString()
                End If
                If frmChequeIssued.dtIssuedate.Value.Day.ToString() = 1 Then
                    lastid = lastid & "0" & frmChequeIssued.dtIssuedate.Value.Day.ToString()
                Else
                    lastid = lastid & frmChequeIssued.dtIssuedate.Value.Day.ToString()
                End If
                lastid = lastid & Format(1, "0000")
            End If
            GMod.VouNo = lastid
            'lblvouno.Text = lastid
        Catch ex As Exception
            MsgBox("Voucher No error Multiple:" & ex.Message)
        End Try
    End Sub

    Private Sub dgMultiple_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMultiple.CellContentClick

    End Sub
End Class