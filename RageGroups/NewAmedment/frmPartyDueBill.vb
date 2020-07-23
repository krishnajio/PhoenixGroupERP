Public Class frmPartyDueBill

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String 
       
        sql = "exec pau_ageing '" & GMod.Session & "','" & cmbVoucherType.Text & "','PHOE','ppp'"
        GMod.SqlExecuteNonQuery(sql)
        'Select Case ComboBox1.Text
        '    Case "0-15"
        '        'sql = "select * from pur_ageing where datediff(day,inwdate,getdate()) between 0 and 15 order by itemname"
        '        sql = "select sum(rate*qty) qty ,party_code, datediff(day,inwdate,getdate()) bill_no,item_name from pur_ageing  group by  party_code, DateDiff(Day, inwdate, getdate()), item_name having datediff(day,inwdate,getdate()) between 0 and 15 order by datediff(day,inwdate,getdate())"
        '    Case "16-45"
        '        ' sql = "select * from pur_ageing where datediff(day,inwdate,getdate()) between 16 and 45  order by itemname"
        '        sql = "select sum(rate*qty) qty ,party_code, datediff(day,inwdate,getdate()) bill_no,item_name from pur_ageing  group by  party_code, DateDiff(Day, inwdate, getdate()), item_name having datediff(day,inwdate,getdate()) between 16 and 45 order by datediff(day,inwdate,getdate())"

        '    Case ">45"
        '        ' sql = "select * from pur_ageing where datediff(day,inwdate,getdate()) >45  order by itemname"
        '        sql = "select sum(rate*qty) qty ,party_code, datediff(day,inwdate,getdate()) bill_no,item_name from pur_ageing  group by  party_code, DateDiff(Day, inwdate, getdate()), item_name having datediff(day,inwdate,getdate()) >45 order by datediff(day,inwdate,getdate())"

        '    Case Else
        '        MessageBox.Show("Invalid")
        'End Select
        'sql = "   select p.party_code,v.account_head_name as item_name ,p.itemname,p.Bill_no,p.Bill_date, p.rate,p.qty from Purchase_Data  p inner join " & GMod.ACC_HEAD & " v " & _
        '        " on p.party_code = v.account_code where session = '" & GMod.Session & "' and " & _
        '"  itemname in ('" & cmbProduct.Text & "') and paid = 0 order by Bill_date"

        '' sql = "select * from purchase_data where session ='" & GMod.Session & "' and paid = 0  and itemname ='" & cmbProduct.Text & "' and vou_type ='" & cmbVoucherType.Text & "' and party_code ='" & cmbPartyCode.Text & "' order by bill_date"
        sql = "select * from dbo.pageing where [0To15]>0 or [16to45]>0 or [abv45]>0 order by party_name"

        GMod.DataSetRet(sql, "partyduelist")
        Try
            Dim r As New CrPurAgeing
            r.SetDataSource(GMod.ds.Tables("partyduelist"))
            ''r.SetParameterValue("p", ComboBox1.Text)
            'r.SetParameterValue("vdate", "")
            'r.SetParameterValue("uname", GMod.username)
            CrystalReportViewer1.ReportSource = r
        Catch ex As Exception

        End Try
    End Sub
    Dim Query As String
    Private Sub frmPartyDueBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Query = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where group_name ='PARTY' order by account_head_name"
        GMod.DataSetRet(Query, "PPList")

        cmpbarty.DataSource = GMod.ds.Tables("PPList")
        cmpbarty.DisplayMember = "account_head_name"

        cmbPartyCode.DataSource = GMod.ds.Tables("PPList")
        cmbPartyCode.DisplayMember = "account_code"



        Query = "select vtype from vtype where cmp_id ='phoe' and (vtype like '%PUR%' OR vtype like '%PURCHASE%') and session ='" & GMod.Session & "'"
        GMod.DataSetRet(Query, "PVList")
        cmbVoucherType.DataSource = GMod.ds.Tables("PVList")
        cmbVoucherType.DisplayMember = "vtype"
    End Sub

   
End Class