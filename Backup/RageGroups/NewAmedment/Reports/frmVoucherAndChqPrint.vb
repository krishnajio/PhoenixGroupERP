Public Class frmVoucherAndChqPrint
    Dim sql As String
    Private Sub frmVoucherAndChqPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select  vou_no  from chq_issue where vou_type='" & cmbvoutype.Text & "' and recpitid<>'P'"
        GMod.DataSetRet(sql, "dvou_no")


    End Sub
End Class