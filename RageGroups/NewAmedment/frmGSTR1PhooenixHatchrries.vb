Public Class frmGSTR1PhooenixHatchrries

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "select p.*,q.dramt from (" _
               & " select acc_head , sum(qty) qty ,sum(cramt) amount , count(acc_head) count, min(cast(vou_no as int)) min_v , " _
               & " max(cast(vou_no as int)) max_v " _
               & " from sales_rep" _
               & " where hatchdate between '" & dtvdate.Value.ToShortDateString() & "' and '" & DateTimePicker1.Value.ToShortDateString() & "'  and productname in ('LAYER CHICKS','BROILER CHICKS','COCKREL CHICKS') " _
               & " and group_name ='SALE'" _
               & " group by acc_head)p inner join " _
               & " (select sum(dramt) dramt ,acc_head,group_name from ventry_phha_1920" _
               & " where group_name ='sale' and vou_date between '" & dtvdate.Value.ToShortDateString() & "' and '" & DateTimePicker1.Value.ToShortDateString() & "'" _
               & " group by group_name ,acc_head)q  on q.acc_head=p.acc_head"

        GMod.DataSetRet(sql, "GSTR1ph")


        Dim crsr As New CrGstr1Ph
        crsr.SetDataSource(GMod.ds.Tables("GSTR1ph"))
        crsr.SetParameterValue("p1", "Date From " & dtvdate.Text & " To " & DateTimePicker1.Text)
        CrystalReportViewer1.ReportSource = crsr

    End Sub
End Class