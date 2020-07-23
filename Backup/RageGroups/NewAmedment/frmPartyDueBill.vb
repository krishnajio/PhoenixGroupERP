Public Class frmPartyDueBill

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String 
        'sql = "exec pb"
        If chkSelectParty.Checked = False Then
            sql = "select * from ("
            sql &= " select * from ( select distinct bill_no,  party_code, bill_date, sum(party_amt) amt ,session , "
            sql &= " cmp_id,vou_type,vou_no  from  purchase_data group by bill_no,bill_date ,party_code,session , "
            sql &= " cmp_id,id,vou_type,vou_no having session ='" & GMod.Session & "' ) p where p.bill_no not in  "
            sql &= " (select bill_no from bank_payment b where  p.party_code =b.party_code "
            sql &= " and p.session=b.session and p.cmp_id=b.cmp_id ) ) p  "
            sql &= " inner join " & GMod.VENTRY & " v on p.vou_no = v.vou_no and p.vou_type = v.vou_type "
            sql &= " where cramt>0  and v.group_name ='PARTY'  and v.vou_date ='" & dtpVoudate.Value.ToShortDateString & "'  and v.vou_type ='" & cmbVoucherType.Text & "'"
            If cmbProduct.Text = "ALL" Then

            Else
                sql &= " and NARRATION LIKE  '%" & cmbProduct.Text & "%'"
            End If
            sql &= " and month(Ch_issue_date) = '" & dtpdate.Value.Month & "' order by  Ch_issue_date,Acc_head "

        Else

            sql = "select * from ("
            sql &= " select * from ( select distinct bill_no,  party_code, bill_date, sum(party_amt) amt ,session , "
            sql &= " cmp_id,vou_type,vou_no  from  purchase_data group by bill_no,bill_date ,party_code,session , "
            sql &= " cmp_id,id,vou_type,vou_no having session ='" & GMod.Session & "' ) p where p.bill_no not in  "
            sql &= " (select bill_no from bank_payment b where  p.party_code =b.party_code "
            sql &= " and p.session=b.session and p.cmp_id=b.cmp_id ) ) p  "
            sql &= " inner join " & GMod.VENTRY & " v on p.vou_no = v.vou_no and p.vou_type = v.vou_type  and v.vou_date ='" & dtpVoudate.Value.ToShortDateString & "' and v.vou_type ='" & cmbVoucherType.Text & "' "
            sql &= " where cramt>0  and v.group_name ='PARTY' "
            If cmbProduct.Text = "ALL" Then

            Else
                sql &= " and NARRATION LIKE  '%" & cmbProduct.Text & "%'"
            End If
            sql &= "  and p.party_code ='" & cmbPartyCode.Text & "'  and month(Ch_issue_date) = '" & dtpdate.Value.Month & "'  order by  Ch_issue_date,Acc_head "
        End If




        GMod.DataSetRet(sql, "partyduelist")
        Try
            Dim r As New CrPartyDueList
            r.SetDataSource(GMod.ds.Tables("partyduelist"))
            'r.SetParameterValue("cmpname", GMod.Cmpname)
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



        Query = "select vtype from vtype where cmp_id ='phoe' and (vtype like '%PUR%' OR vtype like '%PURCHASE%')"
        GMod.DataSetRet(Query, "PVList")
        cmbVoucherType.DataSource = GMod.ds.Tables("PVList")
        cmbVoucherType.DisplayMember = "vtype"


    End Sub
End Class