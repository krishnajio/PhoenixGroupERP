Public Class Frmpaymentstop

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtchqno.Text = ""
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sql, s As String
        If txtchqno.Text = "" Then
            MsgBox("Please type cheque No.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Rdbtndestroy.Checked = True Then
            sql = "insert into " & GMod.CHQ_ISSUED & "(cmp_id,issue_date,chq_date,cheque_no,bankacc_code,stop_bounce) " _
            & " values('" & GMod.Cmpid & "','" & Today().ToShortDateString & "','" & Today().ToShortDateString & "','" & txtchqno.Text & "','" & cmbacheadcode.Text & "','D');"
        ElseIf Rdbtnbounce.Checked Then
            sql = "update " & GMod.CHQ_ISSUED & " set stop_bounce='B' where cheque_no='" & txtchqno.Text & "' and bankacc_code='" & cmbacheadcode.Text & "'"
        Else
            sql = "update " & GMod.CHQ_ISSUED & " set stop_bounce='S' where cheque_no='" & txtchqno.Text & "' and bankacc_code='" & cmbacheadcode.Text & "'"
        End If
        s = GMod.SqlExecuteNonQuery(sql)
        MsgBox(s)
    End Sub

    Private Sub Frmpaymentstop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        GMod.DataSetRet("select * from " & GMod.ACC_HEAD & " where group_name='BANK'", "xx")
        cmbacheadcode.DataSource = GMod.ds.Tables("xx")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("xx")
        cmbacheadname.DisplayMember = "account_head_name"
    End Sub

    Private Sub txtchqno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchqno.Leave
        Dim sql As String
        sql = "select * from " & GMod.CHQ_ISSUED & " where BankAcc_code='" & cmbacheadcode.Text & "' and Cheque_no ='" & txtchqno.Text & "'"
        GMod.DataSetRet(sql, "findchq")
        If GMod.ds.Tables("findchq").Rows.Count > 0 Then

        Else
            MsgBox("Cheque Number not found", MsgBoxStyle.Critical)
            txtchqno.Focus()
        End If

    End Sub
End Class