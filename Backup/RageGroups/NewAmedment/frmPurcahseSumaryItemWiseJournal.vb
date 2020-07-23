Public Class frmPurcahseSumaryItemWiseJournal
    Dim sql As String
    Private Sub frmPurcahseSumaryItemWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        'sql = "select pd.*,ach.account_head_name,ach.address,ach.remark2 from Purchase_Data pd"
        'sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type like '%PURCHASE%' and pd.cmp_id ='" & GMod.Cmpid & "' and authr<>'-'"


        sql = "select pd.*,ach.account_head_name,ach.address,ach.remark2 from Purchase_Data pd left join "
        sql &= GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code "
        sql &= " left join " & GMod.ACC_HEAD & " ach1 on pd.item_code= ach1.account_code "
        sql &= " where pd.session='" & GMod.Session & "' "
        sql &= " and vou_type like '%JOURNAL%' and pd.cmp_id ='PHOE' and authr<>'-' and ach1.group_name like '%CAPITAL%'  and vou_date between  '" & d1.Value.ToShortDateString & "' and '" & d2.Value.ToShortDateString & "'"


        GMod.DataSetRet(sql, "npr")
        Dim r As New CrPurchaeItemWiseSummary
        r.SetDataSource(GMod.ds.Tables("npr"))
        r.SetParameterValue("p1", GMod.Cmpname)
        'r.SetParameterValue("p2", p2)
        'r.SetParameterValue("p3", p3)
        'r.SetParameterValue("p4", p4)
        'r.SetParameterValue("p5", p5)
        'r.SetParameterValue("p6", voutype.Text.ToUpper & "- REGISTER")
        'r.SetParameterValue("p7", GMod.username)
        CrystalReportViewer1.ReportSource = r
    End Sub
End Class