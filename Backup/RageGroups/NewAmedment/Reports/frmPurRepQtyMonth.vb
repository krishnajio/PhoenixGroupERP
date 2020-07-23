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
        sql = " select p.*,a.account_head_name from purqty p " & _
              " left join " & GMod.ACC_HEAD & "  a " & _
              " on  p.item_code=a.account_code where month='" & mon(0) & "' and for_where='" & cmbprdunit.Text & "' and p.session='" & GMod.Session & "' and p.vou_type='" & cmbvou_type.Text & "'"
        GMod.DataSetRet(sql, "purqtymonthly")

        Dim r As New CrPurQtyMonthly
        r.SetDataSource(GMod.ds.Tables("purqtymonthly"))
        'r.SetParameterValue("p1", GMod.Cmpname)
        r.SetParameterValue("mon", "For The Month-" & mon(1))
        CrystalReportViewer1.ReportSource = r
    End Sub
End Class