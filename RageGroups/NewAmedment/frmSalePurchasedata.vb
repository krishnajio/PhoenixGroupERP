Public Class frmSalePurchasedata
    Dim sql As String
    Private Sub rdPoultrySale_CheckedChanged(sender As Object, e As EventArgs) Handles rdPoultrySale.CheckedChanged
        sql = "select * from PrintData where Session='" & GMod.Session & "' and Cmp_id='PHOE' order by Vou_type, cast(Vou_no as int)"
        GMod.DataSetRet(sql, "ppdata")
        DataGridView1.DataSource = GMod.ds.Tables("ppdata")
    End Sub

    Private Sub frmSalePurchasedata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub rsOtherSale_CheckedChanged(sender As Object, e As EventArgs) Handles rsOtherSale.CheckedChanged
        sql = "select * from OtherSaledata where Session='" & GMod.Session & "' and Cmp_id='PHOE'  order by Vou_type, cast(Vou_no as int)"
        GMod.DataSetRet(sql, "ppdata")
        DataGridView1.DataSource = GMod.ds.Tables("ppdata")
    End Sub

    Private Sub rdPoultryPurchase_CheckedChanged(sender As Object, e As EventArgs) Handles rdPoultryPurchase.CheckedChanged
        sql = "select * from Purchase_data where Session='" & GMod.Session & "' and Cmp_id='PHOE' and vou_type not in('DR NOTE(PUR)') order by Vou_type, cast(Vou_no as int)"
        GMod.DataSetRet(sql, "ppdata")
        DataGridView1.DataSource = GMod.ds.Tables("ppdata")
    End Sub
End Class