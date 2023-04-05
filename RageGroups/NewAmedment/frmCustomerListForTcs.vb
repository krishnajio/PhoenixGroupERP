Public Class frmCustomerListForTcs

    Private Sub frmCustomerListForTcs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New CrCustomerListForTcs

        GMod.DataSetRet("select * from Customelisttcs order by Acc_head", "Customelisttcs")
        Try
            r.SetDataSource(GMod.ds.Tables("Customelisttcs"))
            ''r.SetParameterValue("p", ComboBox1.Text)
            'r.SetParameterValue("vdate", "")
            'r.SetParameterValue("uname", GMod.username)
            CrystalReportViewer1.ReportSource = r
        Catch ex As Exception

        End Try
    End Sub
End Class