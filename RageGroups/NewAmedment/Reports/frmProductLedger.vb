Public Class frmProductLedger
    Dim sql As String

    Private Sub frmProductLedger_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
       
    End Sub
    Private Sub frmProductLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  sql = "select distinct Productname from othersaledata"
        sql = "SELECT	distinct ProductName FROM OTHERSALEDATA where session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"

        GMod.DataSetRet(sql, "Pname")
        cmbProduct.DataSource = GMod.ds.Tables("Pname")
        cmbProduct.DisplayMember = "Productname"


        sql = "Select 'All' Vou_type from   othersaledata Union select distinct Vou_type from othersaledata where Vou_type<>'OTHER SALE RET.'"
        GMod.DataSetRet(sql, "Plvou_type")
        voutype.DataSource = GMod.ds.Tables("Plvou_type")
        voutype.DisplayMember = "vou_type"

    End Sub

    Private Sub cmbProduct_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProduct.Leave
        sql = "select Unit from itemmaster where cmp_id='" & GMod.Cmpid & "' and ItemNAme='" & cmbProduct.Text & "'"
        GMod.DataSetRet(sql, "PlUnit")
        lblUnit.Text = GMod.ds.Tables("PlUnit").Rows(0)(0).ToString
    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProduct.SelectedIndexChanged

    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        cmbProduct.Enabled = False
        voutype.Enabled = False
        d1.Enabled = False
        d2.Enabled = False

        sql = "select * from ProductLedgerNos('" & d1.Value.ToShortDateString & "','" & d2.Value.ToShortDateString & "','" & cmbProduct.Text & "','" & voutype.Text & "') order by billdate"
        GMod.DataSetRet(sql, "prdledger")

        Dim crprd As New CrPrdLedger
        crprd.SetDataSource(GMod.ds.Tables("prdledger"))
        crprd.SetParameterValue("P1", GMod.Cmpname)
        crprd.SetParameterValue("P2", "Product Name:" & cmbProduct.Text)
        crprd.SetParameterValue("P3", "From:" & d1.Text & "To" & d2.Text)
        CrystalReportViewer1.ReportSource = crprd
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmbProduct.Enabled = True
        voutype.Enabled = True
        d1.Enabled = True
        d2.Enabled = True
        CrystalReportViewer1.ReportSource = Nothing
    End Sub
End Class