Public Class frmPurRepQtyMonth
    Dim sql As String
    Private Sub frmPurRepQtyMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select prdunit from prdunit where cmp_id='" & GMod.Cmpid & "'", "prdunit")
        cmbprdunit.DataSource = GMod.ds.Tables("prdunit")
        cmbprdunit.DisplayMember = "prdunit"
        cmbprdunit.Text = ""

        GMod.DataSetRet("select vtype from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%PUR%'", "vtpm")
        cmbvou_type.DataSource = GMod.ds.Tables("vtpm")
        cmbvou_type.DisplayMember = "vtype"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mon() As String = voutype.Text.Split("-")

        If cmbvou_type.Text = "DR NOTE(PUR)" Then
            sql = " select item_name as item_code, itemname as account_head_name, qty,  month, For_where, amt, rate, unit, session, vou_type from purdrnote p " & _
       "  where month between '" & d1.Value.Month & "' and '" & d2.Value.Month & "' and for_where='" & cmbprdunit.Text & "' and p.session='" & GMod.Session & "' and p.vou_type='" & cmbvou_type.Text & "' order by month,item_name,itemname"

        Else
            sql = " select item_name as item_code, itemname as account_head_name, qty,  month, For_where, amt, rate, unit, session, vou_type from purqty p " & _
            "  where month between '" & d1.Value.Month & "' and '" & d2.Value.Month & "' and for_where='" & cmbprdunit.Text & "' and p.session='" & GMod.Session & "' and p.vou_type='" & cmbvou_type.Text & "' order by month,item_name,itemname"
        End If
        GMod.DataSetRet(sql, "purqtymonthly")

        Dim r As New CrPurQtyMonthly
        r.SetDataSource(GMod.ds.Tables("purqtymonthly"))
        'r.SetParameterValue("p1", GMod.Cmpname)
        r.SetParameterValue("mon", "For The Duration-" & d1.Text & " To " & d2.Text)
        CrystalReportViewer1.ReportSource = r
    End Sub
End Class