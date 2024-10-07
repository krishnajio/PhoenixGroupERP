Public Class frmCustomerListForTcs
    Dim sql As String
    Private Sub frmCustomerListForTcs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "select distinct session from  SessionMaster"
        GMod.DataSetRet(sql, "tcssession")
        cmbsession.DataSource = GMod.ds.Tables("tcssession")
        cmbsession.DisplayMember = "session"

       
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click


        Dim r As New CrCustomerListForTcs
        ' GMod.DataSetRet("select * from Customelisttcs order by Acc_head", "Customelisttcs")
        sql = "SELECT SUM(dramt) AS dramt, Group_name, Acc_head, Acc_head_code FROM dbo.VENTRY_PHOE_" & cmbsession.Text & ""
        sql &= "  WHERE  Group_name = 'Customer' "
        sql &= " GROUP BY Group_name, Acc_head, Acc_head_code"
        sql &= " HAVING   SUM(dramt) >= 5000000"

        GMod.DataSetRet(sql, "Customelisttcs")
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