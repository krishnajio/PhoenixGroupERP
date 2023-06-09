Public Class frmPoAgsBillReport
    Dim sql As String = ""

    Private Sub frmPoAgsBillReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select distinct Workunit from PURCHASE_ORDER_MASTER", "workunti")
        ComboBox1.DataSource = GMod.ds.Tables("Workunti")
        ComboBox1.DisplayMember = "Workunit"
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'sql = "select * from poreport where cast(pono as numeric(18)) between '" & TextBox1.Text & "' and '" & TextBox2.Text & "' order by for_where,cast(pono as bigint)"


        sql = "SELECT     dbo.Purchase_Data.session, PURCHASE_ORDER_MASTER.Pur_Order_No  AS pono, dbo.Purchase_Data.party_code, dbo.Purchase_Data.item_code," & _
                  "dbo.Purchase_Data.item_name, dbo.PURCHASE_ORDER_DETAIL.Qty*1000 as Qty , dbo.Purchase_Data.qty AS BILLQTY, dbo.Purchase_Data.unit,  dbo.PURCHASE_ORDER_DETAIL.Rate/1000 as Rate ," & _
                  "dbo.PURCHASE_ORDER_MASTER.WorkUnit, dbo.Purchase_Data.For_where, dbo.Purchase_Data.rate AS Expr2,  a.account_head_name, " & _
                  "dbo.PURCHASE_ORDER_MASTER.Pur_Order_Dt, dbo.Purchase_Data.Bill_no,  dbo.Purchase_Data.Bill_date, dbo.Purchase_Data.inwno, dbo.Purchase_Data.inwdate, " & _
                  "a.address,    dbo.PURCHASE_ORDER_MASTER.Delivery_Schedule as city FROM dbo.Purchase_Data " & _
                  " INNER JOIN  dbo.PURCHASE_ORDER_DETAIL ON " & _
                 "  dbo.Purchase_Data.session = dbo.PURCHASE_ORDER_DETAIL.session And dbo.Purchase_Data.pono = dbo.PURCHASE_ORDER_DETAIL.Pur_Order_No " & _
                 " INNER JOIN  dbo.PURCHASE_ORDER_MASTER " & _
                " ON dbo.PURCHASE_ORDER_DETAIL.Pur_Order_No = dbo.PURCHASE_ORDER_MASTER.Pur_Order_No AND " & _
                "  dbo.PURCHASE_ORDER_DETAIL.session = dbo.PURCHASE_ORDER_MASTER.Session And dbo.Purchase_Data.For_where = dbo.PURCHASE_ORDER_MASTER.WorkUnit" & _
                " INNER JOIN  " & ACC_HEAD & " a ON dbo.Purchase_Data.party_code = a.account_code  " & _
                " where PURCHASE_ORDER_MASTER.C_Order_No  between '" & TextBox1.Text & "'and '" & TextBox2.Text & "' " & _
                " and dbo.PURCHASE_ORDER_MASTER.WorkUnit='" & ComboBox1.Text & "' and Purchase_Data.session='" & GMod.Session & "' and PURCHASE_ORDER_MASTER.Session='" & GMod.Session & "' and  dbo.PURCHASE_ORDER_DETAIL.session ='" & GMod.Session & "'order by for_where,CAST(PURCHASE_ORDER_MASTER.C_Order_No AS bigint)"


        GMod.DataSetRet(sql, "poreport")
        Dim crpo As New CrPurOrderReport
        crpo.SetDataSource(GMod.ds.Tables("poreport"))
        CrystalReportViewer1.ReportSource = crpo
    End Sub

    
End Class