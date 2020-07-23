Public Class FrmForm49Rpt

    Private Sub FrmForm49Rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "select account_head_name,f.* from Form_49 f," & GMod.ACC_HEAD & " a"
        sql += " where a.account_code=f.party_code and f.session='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "frm49rpt")
        Dim r As New CrForm49
        r.SetDataSource(GMod.ds.Tables("frm49rpt"))
        CrystalReportViewer1.ReportSource = r
    End Sub
End Class