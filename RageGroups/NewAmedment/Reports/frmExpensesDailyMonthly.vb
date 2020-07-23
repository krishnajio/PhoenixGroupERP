Public Class frmExpensesDailyMonthly

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click

        Dim sql As String
        Sql &= "select sum(dramt) dr ,group_name ,ch_date from " & GMod.VENTRY
        sql &= " where ch_date between '" & dtpfrom.Value.ToShortDateString & "'   and  '" & dtpto.Value.ToShortDateString & "' and dramt>0 and Pay_mode<>'-'"
        sql &= " group by group_name ,ch_date  order by ch_date ,group_name "

        GMod.DataSetRet(Sql, "dvexp")
        Dim cr As New CrDaily_MonthlyExp
        cr.SetDataSource(GMod.ds.Tables("dvexp"))


        cr.SetParameterValue("p1", GMod.Cmpname)
        cr.SetParameterValue("p2", "Expenses Date From " & dtpfrom.Text & " To " & dtpto.Text)
        'cr.SetParameterValue("p3", "Session " & GMod.Session)
        'cr.SetParameterValue("p4", "User Name " & GMod.username)

        CrystalReportViewer1.ReportSource = cr

    End Sub
End Class