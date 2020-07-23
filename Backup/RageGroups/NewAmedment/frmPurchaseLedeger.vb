Public Class frmPurchaseLedeger
    Dim SQL As String
    Private Sub frmPurchaseLedeger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            ' sql = "select itemname from ItemMaster where cmp_id='" & GMod.Cmpid & "'"
            SQL = "SELECT	distinct item_name,item_code FROM purchase_data where session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sql, "itemname")
            cmbProduct.DataSource = ds.Tables("itemname")
            cmbProduct.DisplayMember = "item_name"

            ComboBox1.DataSource = ds.Tables("itemname")
            ComboBox1.DisplayMember = "item_code"



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%PUR%' and vtype not like '%other%'  and vtype not like '%JOURNAL%'", "vou_type")
        voutype.DataSource = GMod.ds.Tables("vou_type")
        voutype.DisplayMember = "vtype"
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        ' SQL = "select pd.*,ach.account_head_name,ach.address,ach.remark2 from Purchase_Data pd"
        'SQL &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type like '%PURCHASE%' and pd.cmp_id ='" & GMod.Cmpid & "' and authr<>'-'"
        SQL = "select * from purchase_data where session ='" & GMod.Session & "' and item_code='" & ComboBox1.Text & "' and  vou_date between '" & d1.Value.ToShortDateString & "' and '" & d2.Value.ToShortDateString & "' order by id"
        GMod.DataSetRet(SQL, "npr")
        Dim r As New CrPurLedger
        r.SetDataSource(GMod.ds.Tables("npr"))
        r.SetParameterValue("p1", cmbProduct.Text)
        r.SetParameterValue("p2", "Date From " & d1.Text & " To " & d2.Text)
        'r.SetParameterValue("p3", p3)
        'r.SetParameterValue("p4", p4)
        'r.SetParameterValue("p5", p5)
        'r.SetParameterValue("p6", voutype.Text.ToUpper & "- REGISTER")
        'r.SetParameterValue("p7", GMod.username)
        r.SetParameterValue("p8", 0)
        CrystalReportViewer1.ReportSource = r
    End Sub
End Class