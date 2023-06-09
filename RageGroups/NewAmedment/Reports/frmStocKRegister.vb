Public Class frmStocKRegister
    Dim sql As String

    Private Sub frmStocKRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select distinct itemname from Purchase_Data where session='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "pur_itemname")
        cmbProduct.DataSource = GMod.ds.Tables("pur_itemname")
        cmbProduct.DisplayMember = "itemname"


        sql = "select distinct For_where from Purchase_Data where session='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "pur_unit")
        cmbUnit.DataSource = GMod.ds.Tables("pur_unit")
        cmbUnit.DisplayMember = "For_where"


    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        sql = "exec [StockProc]  '" & GMod.Session & "','" & cmbUnit.Text & "','" & d2.Value.ToShortDateString & "','" & d1.Value.ToShortDateString & "','" & cmbProduct.Text & "'," & Val(txtClosingStock.Text) & ",'PURCHASE'"
        GMod.DataSetRet(sql, "stock_register")

        dgStockregister.DataSource = GMod.ds.Tables("stock_register")
    End Sub
End Class