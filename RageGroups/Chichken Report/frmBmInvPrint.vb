Public Class frmBmInvPrint

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "select * from dbo.InvPhxChicken where session ='1819' and cast(vou_no as bigint) between 1 and 10  and vou_type ='SALE CH'"
        GMod.DataSetRet(sql, "invbm")
        Dim crobjpp As New CrBmInv

        crobjpp.SetDataSource(GMod.ds.Tables("invbm"))
        ' crobjpp.SetParameterValue("gstno", gstno)
        CrystalReportViewer1.ReportSource = crobjpp
    End Sub
End Class