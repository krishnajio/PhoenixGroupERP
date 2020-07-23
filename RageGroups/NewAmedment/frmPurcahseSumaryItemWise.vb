Public Class frmPurcahseSumaryItemWise
    Dim sql As String
    Private Sub frmPurcahseSumaryItemWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        If cmbacheadname.Text = "W-S" Then
            sql = "select pd.*,ach.account_head_name,ach.address,ach.remark2 from Purchase_Data pd"
            sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type like '%PURCHASE%' and pd.cmp_id ='" & GMod.Cmpid & "' and authr<>'-'"
            sql &= "and (item_name like '%W-S%' or item_name like '%W.S%'  or item_name like '%WS%') and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' order by bill_date"
            GMod.DataSetRet(sql, "npr")
            Dim r As New CrPurchaeItemWiseSummary1
            r.SetDataSource(GMod.ds.Tables("npr"))
            r.SetParameterValue("p1", GMod.Cmpname)
            'r.SetParameterValue("p2", p2)
            'r.SetParameterValue("p3", p3)
            'r.SetParameterValue("p4", p4)
            'r.SetParameterValue("p5", p5)
            'r.SetParameterValue("p6", voutype.Text.ToUpper & "- REGISTER")
            'r.SetParameterValue("p7", GMod.username)
            CrystalReportViewer1.ReportSource = r
        ElseIf cmbacheadname.Text = "O-S" Then
            sql = "select pd.*,ach.account_head_name,ach.address,ach.remark2 from Purchase_Data pd"
            sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type like '%PURCHASE%' and pd.cmp_id ='" & GMod.Cmpid & "' and authr<>'-'"
            sql &= "and (item_name like '%O-S%' or item_name like '%O.S%'  or item_name like '%OS%') and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' order by bill_date"
            GMod.DataSetRet(sql, "npr")
            Dim r As New CrPurchaeItemWiseSummary1
            r.SetDataSource(GMod.ds.Tables("npr"))
            r.SetParameterValue("p1", GMod.Cmpname)
            'r.SetParameterValue("p2", p2)
            'r.SetParameterValue("p3", p3)
            'r.SetParameterValue("p4", p4)
            'r.SetParameterValue("p5", p5)
            'r.SetParameterValue("p6", voutype.Text.ToUpper & "- REGISTER")
            'r.SetParameterValue("p7", GMod.username)
            CrystalReportViewer1.ReportSource = r
        Else
            sql = "select pd.*,ach.account_head_name,ach.address,ach.remark2 from Purchase_Data pd"
            sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type like '%PURCHASE%' and pd.cmp_id ='" & GMod.Cmpid & "' and authr<>'-'"
            sql &= " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' order by bill_date"

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

        End If
        
    End Sub
End Class