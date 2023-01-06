Public Class frmPartyDueMonthly
    Dim sql As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim Query As String
    Private Sub frmPartyDueBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = " select a.account_code,account_head_name,p.Bill_no,Bill_date, vathead itemname from ACC_HEAD_PHOE_2223 a inner join purchase_data p "
        sql &= " on a.account_code=p.party_code where  p.session ='2223' and paid =0 and vou_type <>'DR NOTE(PUR)' "
        sql &= " and item_name like '%" & cmbVoucherType.Text & "%'  and Bill_date<= '" & dtpdate.Value.ToShortDateString
        sql &= "' order by a.account_code,account_head_name,Bill_date desc"

        GMod.DataSetRet(sql, "monyhlypendlinglist")

        '  DataGridView1.Rows.Clear()

        DataGridView1.DataSource = GMod.ds.Tables("monyhlypendlinglist")
    End Sub
End Class