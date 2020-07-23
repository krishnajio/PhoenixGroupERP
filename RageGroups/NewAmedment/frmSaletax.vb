Public Class frmSaletax
    Dim sql As String
    Private Sub frmSaletax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"

        GMod.DataSetRet(Sql, "s_acchead")
        cmbacheadcode.DataSource = GMod.ds.Tables("s_acchead")
        cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("s_acchead")
        cmbacheadname.DisplayMember = "account_head_name"
    End Sub
End Class