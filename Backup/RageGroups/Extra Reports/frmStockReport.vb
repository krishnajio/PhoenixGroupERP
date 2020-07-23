Public Class frmStockReport

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql As String
        sql = "select sum(qty) qty ,itemname,vou_no,billno,acc_head_code,acc_head from " & GMod.INVENTORY & " where vou_type='" & cmbVtype.Text & "'" _
               & " and billdate <='" & dtfrom.Text & "' group by vou_no,itemname,billno,acc_head_code,acc_head order by acc_head,vou_no"
        Dim c As New Crfeedsale

        GMod.DataSetRet(sql, "fds")
        c.SetDataSource(GMod.ds.Tables("fds"))
        c.SetParameterValue("cname", GMod.Cmpname)
        c.SetParameterValue("type", cmbVtype.Text)
        c.SetParameterValue("billdate", dtfrom.Text)
        cv1.ReportSource = c
    End Sub
End Class