Public Class frmPurchasePartyAmt
    Dim sql As String
    Private Sub frmPurchasePartyAmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select vtype from vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq ='" & GMod.Dept & "' and session ='" & GMod.Session & " '", "vt")
        voutype.DataSource = GMod.ds.Tables("vt")
        voutype.DisplayMember = "vtype"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "select  p.vou_type, p.vou_no, p.party_code, a.account_head_name , p.Bill_no, (p.party_amt - p.varcst_amt) as party_amt from Purchase_Data p inner join ACC_HEAD_PHOE_2425 a on "
        sql &= "   p.party_code = a.account_code where p.session = '" & GMod.Session & "' and p.vou_type='" & voutype.Text & "'"
        sql &= " and cast(vou_no as int) between '" & txtv1.Text & "' and '" & txtv2.Text & "'  ORDER BY cast(vou_no as numeric(18,0)),id"

        GMod.DataSetRet(sql, "PurchasePartyAmt")

        dgPartyAmount.DataSource = GMod.ds.Tables("PurchasePartyAmt")


    End Sub
End Class