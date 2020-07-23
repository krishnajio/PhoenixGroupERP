Public Class frmSale_Purchase_Summary

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim q As String
        q = "select * from InvPhxChicken where session ='" & GMod.Session & "'  and vou_type='" & ComboBox1.Text & "' "
        q &= " and cast(vou_no as bigint) between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & "  and itemname<>'FREIGHT' order by cast(vou_no as bigint)  "
        GMod.DataSetRet(q, "saleregphch")
        Dim cr As New CrSalePurReg
        cr.SetDataSource(GMod.ds.Tables("saleregphch"))
        cr.SetParameterValue("p0", ComboBox1.Text & "  REGISTER")
        cr.SetParameterValue("p2", "Invoice No. From " & txtCrNoFrom.Text & " To " & txtCrNoTo.Text)
        cr.SetParameterValue("p1", GMod.Cmpname)
        CrystalReportViewer1.ReportSource = cr
    End Sub
End Class