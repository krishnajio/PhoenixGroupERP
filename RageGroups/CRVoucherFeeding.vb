Imports System.Data.SqlClient
Public Class CRVoucherFeeding
    Dim ach As New frmacheadlist
    Dim frmnarrationlistobj As New frmNarrationEntrybox

    Private Sub CRVoucherFeeding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        dgCrVoucher.Rows.Add()
        GetLastVouDate()

        Dim sql As String
        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "'  and vtype like '%CR%'"
        GMod.DataSetRet(sql, "CRVT")
        cmbvou_type.DataSource = GMod.ds.Tables("CRVT")
        cmbvou_type.DisplayMember = "vtype"
    End Sub
    Public Sub SetLastVouDate()
        Dim sql As String
        sql = "select * from  LastVouDate"
        GMod.DataSetRet(sql, "LastVouDate")
        If GMod.ds.Tables("LastVouDate").Rows.Count > 0 Then
            sql = "update LastVouDate set last_vou_date='" & dtvdate.Value.ToShortDateString & "' where Uname='" & GMod.username & "'"
            GMod.SqlExecuteNonQuery(sql)
        Else
            sql = "insert into LastVouDate values('" & dtvdate.Value.ToShortDateString & "','" & GMod.username & "')"
            GMod.SqlExecuteNonQuery(sql)
        End If
        GMod.ds.Tables("LastVouDate").Clear()
    End Sub
    Public Sub GetLastVouDate()
        Dim sql As String
        sql = "select last_vou_date from LastVouDate where  Uname='" & GMod.username & "'"
        GMod.DataSetRet(sql, "LastVouDate")
        If GMod.ds.Tables("LastVouDate").Rows.Count > 0 Then
            dtvdate.Value = CDate(GMod.ds.Tables("LastVouDate").Rows(0)(0))
        End If
        GMod.ds.Tables("LastVouDate").Clear()
    End Sub

    Private Sub dgCrVoucher_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCrVoucher.CellEndEdit
        Dim st, h() As String
        If e.ColumnIndex = 1 Then
            If Len(dgCrVoucher(1, e.RowIndex).Value) = 0 Then
                ach.ShowDialog()
                st = ach.cmbacheadlist.Text
                h = st.Split("[")
                dgCrVoucher(2, dgCrVoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
                h = h(1).Split("]")
                dgCrVoucher(1, dgCrVoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
                Exit Sub
            Else
                Dim sqlacc As String
                sqlacc = "select account_code from " & GMod.ACC_HEAD & " where account_code='" & dgCrVoucher(1, e.RowIndex).Value & "'"
                GMod.DataSetRet(sqlacc, "Count")
                If GMod.ds.Tables("Count").Rows.Count > 0 Then

                Else
                    ach.ShowDialog()
                    st = ach.cmbacheadlist.Text
                    h = st.Split("[")
                    dgCrVoucher(2, dgCrVoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
                    h = h(1).Split("]")
                    dgCrVoucher(1, dgCrVoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
                    Exit Sub
                End If
                GMod.ds.Tables("Count").Clear()
            End If
        End If
    End Sub
    Dim t As New frmCRVoucherNarration
    Private Sub dgCrVoucher_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCrVoucher.CellEnter
        If e.ColumnIndex = 3 Then
            t.ShowDialog()
            dgCrVoucher(3, dgCrVoucher.CurrentCell.RowIndex).Value = t.TextBox1.Text
            ' t.Dispose()
        ElseIf e.ColumnIndex = 6 Then
            'cal culate nextvoucher no
            If e.ColumnIndex = 6 And e.RowIndex = 0 Then
                Dim sql As String
                sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvou_type.Text & "'"
                'MsgBox(sql)
                GMod.DataSetRet(sql, "vno8")
                dgCrVoucher(6, dgCrVoucher.CurrentCell.RowIndex).Value = ds.Tables("vno8").Rows(0)(0)
            Else
                dgCrVoucher(6, dgCrVoucher.CurrentCell.RowIndex).Value = Val(dgCrVoucher(6, dgCrVoucher.CurrentCell.RowIndex - 1).Value) + 1
            End If
        End If
    End Sub

    Private Sub dgCrVoucher_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCrVoucher.CellLeave
        Try
            Dim s, drcr, st, h() As String
            s = dgCrVoucher(1, dgCrVoucher.CurrentCell.RowIndex).Value
            drcr = dgCrVoucher(6, dgCrVoucher.CurrentCell.RowIndex).Value
            If e.ColumnIndex = 1 And String.IsNullOrEmpty(s) Then
                ach.ShowDialog()
                st = ach.cmbacheadlist.Text.ToUpper
                h = st.Split("[")
                dgCrVoucher(2, dgCrVoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
                h = h(1).Split("]")
                dgCrVoucher(1, dgCrVoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
            ElseIf e.ColumnIndex = 5 Then
                lblcrsum.Text = Val(lblcrsum.Text) + Val(dgCrVoucher(5, dgCrVoucher.CurrentCell.RowIndex).Value)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgCrVoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCrVoucher.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnsave_Click(sender, e)
        End If
    End Sub

    Private Sub dgCrVoucher_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCrVoucher.KeyUp
        If e.KeyCode = Keys.Enter Then
            If dgCrVoucher.CurrentCell.ColumnIndex < dgCrVoucher.ColumnCount - 1 Then
                SendKeys.Send("{Tab}")
            Else
                dgCrVoucher.Rows.Add()
                dgCrVoucher.CurrentCell = dgCrVoucher(0, dgCrVoucher.CurrentCell.RowIndex + 1)
            End If
        End If
    End Sub

    Private Sub dgCrVoucher_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCrVoucher.RowEnter
        Dim r, pr As Integer
        r = e.RowIndex
        If r = 0 Then
            dgCrVoucher(0, r).Value = 1
        Else
            pr = r - 1
            dgCrVoucher(0, r).Value = dgCrVoucher(0, pr).Value + 1
        End If
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        cmbvou_type.Enabled = True
        Dim sqlt As String
        Try
            Dim x As Integer

            For x = 0 To dgCrVoucher.Rows.Count - 1
                If Val(dgCrVoucher(5, x).Value) = 0 Then
                    MsgBox("Amount can not be zero", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim sqltans As SqlTransaction
        sqltans = GMod.SqlConn.BeginTransaction
        Try
            Dim g, s, sqlsavecr, paymod As String
            Dim i As Integer
            Dim varcr, vardr, eid As Double
            For i = 0 To dgCrVoucher.Rows.Count - 1
                If Len(dgCrVoucher(4, i).Value) > 0 Then 'check for  paymod
                    paymod = "CHEQUE"
                Else
                    paymod = "CASH"
                End If

                sqlt = "select group_name,sub_group_name from  " & GMod.ACC_HEAD & " where account_code = '" & dgCrVoucher(1, i).Value.ToString & "'"
                GMod.DataSetRet(sqlt, "grp_SUBGRP")
                g = GMod.ds.Tables("grp_SUBGRP").Rows(0)(0).ToString
                s = GMod.ds.Tables("grp_SUBGRP").Rows(0)(1).ToString
                If s.Length = 0 Then
                    s = "-"
                End If
                varcr = dgCrVoucher(5, i).Value
                vardr = 0
                eid = 0

                'cr entry
                sqlsavecr = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                sqlsavecr += "acc_head_code,Acc_head, cramt, dramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                sqlsavecr += ") values( "
                sqlsavecr += "'" & GMod.Cmpid & "','" & GMod.username & "'," & eid & ",'" & dgCrVoucher(6, i).Value & "',"
                sqlsavecr += "'" & cmbvou_type.Text & "','" & dtvdate.Value.ToShortDateString & "','" & dgCrVoucher(1, i).Value.ToString.ToUpper & "','" & dgCrVoucher(2, i).Value.ToString.ToUpper & "'," & Val(varcr) & "," & Val(vardr) & ","
                sqlsavecr += "'" & paymod & "','" & dgCrVoucher(4, i).Value & "','" & dgCrVoucher(3, i).Value.ToString.ToUpper & "','" & g & "',"
                sqlsavecr += "'" & s & "')"
                'MsgBox(sqlsavecr)
                Dim cmd As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltans)
                cmd.ExecuteNonQuery()
            Next
            sqltans.Commit()
            MsgBox("CR VOUCHER's SAVED", MsgBoxStyle.Information)
        Catch ex As Exception
            sqltans.Rollback()
            MsgBox(ex.Message)
        End Try
        dtvdate.Value = GMod.setDate
        dgCrVoucher.Rows.Add()
        dgCrVoucher.Focus()
        lblcrsum.Text = "0"
        dgCrVoucher.Rows.Clear()
        dgCrVoucher.Rows.Add()
        GMod.ds.Tables("grp_SUBGRP").Dispose()
    End Sub

    Private Sub dtvdate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtvdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            dgCrVoucher.Focus()
        End If
    End Sub
    Private Sub CheckBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        Try
            Dim t As New frmPartyaccount
            Dim sql As String
            sql = "select Group_name,Suffix from Groups where Group_name like '%PART%' and Cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "Suffix")

            t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupname.DisplayMember = "Group_name"

            t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupsuffix.DisplayMember = "Suffix"
            t.lblgroupsuffix.Text = "PA"
            t.Label1.Text = "Party Account Heads"
            t.ShowDialog()
            CheckBox2.Checked = False
        Catch ez As Exception

        End Try
    End Sub

    Private Sub ChknewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChknewCustomer.Click
        Dim t As New frmPartyaccount
        Dim sql As String
        sql = "select Group_name,Suffix from Groups where Group_name like '%CUSTOMER%' and Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "Suffix")

        t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupname.DisplayMember = "Group_name"

        t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupsuffix.DisplayMember = "Suffix"

        t.Label1.Text = "Customer Account Heads"
        t.ShowDialog()
        ChknewCustomer.Checked = False
    End Sub

    Private Sub dtvdate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.Leave
        GMod.setDate = dtvdate.Value
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Dim t As New frmCRDebit
        t.ShowDialog()
    End Sub
    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.ValueChanged
        'SetLastVouDate()

        'GMod.DataSetRet("select getdate()", "serverdate")

        'dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        'dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(2)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t As New frmCRPrint
        t.ShowDialog()
    End Sub

    Private Sub dgCrVoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCrVoucher.CellContentClick

    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim achead As New frmGeneralacchead
            achead.ShowDialog()
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub ChknewCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChknewCustomer.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub cmbvou_type_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvou_type.Leave
        cmbvou_type.Enabled = False
    End Sub

    Private Sub cmbvou_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvou_type.SelectedIndexChanged

    End Sub
End Class