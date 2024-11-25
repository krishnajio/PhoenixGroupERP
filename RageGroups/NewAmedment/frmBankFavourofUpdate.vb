Public Class frmBankFavourofUpdate
    Dim Sql As String
    Private Sub frmBankFavourofUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql = "select a.account_code,a.account_head_name , p.bankAccName"
        Sql &= " from " & GMod.ACC_HEAD & " a inner join partyBankDetials p "
        Sql &= " on a.Cmp_id=p.Cmp_id and a.account_code = p.partyCode "

        GMod.DataSetRet(Sql, "partbankfof")
        cmbPartyName.DataSource = GMod.ds.Tables("partbankfof")
        cmbPartyName.DisplayMember = "account_head_name"
        cmbPartyCode.DataSource = GMod.ds.Tables("partbankfof")
        cmbPartyCode.DisplayMember = "account_code"
        fillGrid()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sql = "update partyBankDetials set bankAccName = '" & txtNamefavof.Text & "' where partyCode= '" & cmbPartyCode.Text & "' and Cmp_id='" & GMod.Cmpid & "'"
        MsgBox(GMod.SqlExecuteNonQuery(Sql))
        fillGrid()
    End Sub


    Sub fillGrid()
        Sql = "select a.account_code,a.account_head_name , p.bankAccName"
        Sql &= " from " & GMod.ACC_HEAD & " a inner join partyBankDetials p "
        Sql &= " on a.Cmp_id=p.Cmp_id and a.account_code = p.partyCode "

        GMod.DataSetRet(Sql, "partbankfof1")

        dgfaverof.DataSource = GMod.ds.Tables("partbankfof1")
    End Sub

    Private Sub dgfaverof_DoubleClick(sender As Object, e As EventArgs) Handles dgfaverof.DoubleClick
        Dim r As Integer
        r = dgfaverof.CurrentRow.Index
        cmbPartyCode.Text = dgfaverof(0, r).Value
        cmbPartyName.Text = dgfaverof(1, r).Value
        txtNamefavof.Text = dgfaverof(2, r).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sql = "update partyBankDetials set bankAccName = '" & txtNamefavof.Text & "' where partyCode= '" & cmbPartyCode.Text & "' and Cmp_id='" & GMod.Cmpid & "'"
        MsgBox(GMod.SqlExecuteNonQuery(Sql))
        fillGrid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class