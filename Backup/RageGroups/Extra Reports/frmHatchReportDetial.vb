Public Class frmHatchReportDetial

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql As String
        '
        GMod.SqlExecuteNonQuery("delete from datacr")
        GMod.SqlExecuteNonQuery("delete from datainv")

        'Insert CR DATA
        sql = "insert into datacr " _
        & "select sum(cramt) amt ,convert(datetime,right(narration,11),101) hatchdate ,Acc_head_code,Acc_head  from " & GMod.VENTRY _
        & " where vou_type='CR VOUCHER'   " _
        & " and isdate( right(narration,11))=1 and right(narration,4)<>'2000' and vou_date  between '" & dtfrom.Value.ToShortDateString & "' and  '" & DateTimePicker1.Value.ToShortDateString & "'" _
        & " group by right(narration,11),Acc_head_code,Acc_head "
        GMod.SqlExecuteNonQuery(sql)

        sql = "insert into datainv " _
              & " select sum(amount),hatchdate,Acccode,Accname from printdata where productname not in ('N.E.E.C AMOUNT','DISCOUNT AMOUNT')" _
              & " and hatchdate between '" & dtfrom.Value.ToShortDateString & "' and '" & DateTimePicker1.Value.ToShortDateString & "'" _
              & " group by hatchdate,Acccode,Accname "
        GMod.SqlExecuteNonQuery(sql)

        'hdfinal is view
        sql = "select * from hdfinal order by hatchdate"
        GMod.DataSetRet(sql, "hdfinal")

        Dim cr As New CrHatchDetialReport
        cr.SetDataSource(GMod.ds.Tables("hdfinal"))
        cr.SetParameterValue("cname", GMod.Cmpname)
        cr.SetParameterValue("s", "Form Date" & dtfrom.Text)
        cv1.ReportSource = cr
    End Sub
End Class