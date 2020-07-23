Public Class frmChichkenBatchWiseSalePurchase

    Private Sub frmChichkenBatchWiseSalePurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillArea()
        Dim sqlitem As String
        sqlitem = "select * from ItemMaster where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlitem, "ITEM")
        Me.Particular.DataSource = GMod.ds.Tables("ITEM")
        Me.Particular.DisplayMember = "ItemName"
  
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SplitBatchNo()
        CrystalReportViewer1.Height = Me.Height - 100

        Dim cr As New CrystalReportbw
        Dim sql As String
        sql = "select * from bwrepfun('" & cmbAreaCode.Text & "') where itemname='" & particular.Text & "'  order by  [Pur. BatchNo]"
        GMod.DataSetRet(sql, "bwrep")

        cr.SetDataSource(GMod.ds.Tables("bwrep"))
        cr.SetParameterValue("p1", "BATCH WISE REPORT  [AREA " & cmbAreaName.Text & "]")
        cr.SetParameterValue("uname", GMod.username)
        CrystalReportViewer1.ReportSource = cr
        btnprint.Enabled = True
    End Sub
    Private Sub SplitBatchNo()
        Dim SQL As String, i As Double
        GMod.SqlExecuteNonQuery("delete from tmpInvPhxChicken")
        SQL = "Insert into [tmpInvPhxChicken](Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, ItemName, Qty, QtyNos, Unit, Rate, Amount, Free_Qty, BillType, BillNo, BillDate, AreaCode, Free_Per, Hatch_date, BatchNo) select Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, ItemName, Qty, QtyNos, Unit, Rate, Amount, Free_Qty, BillType, BillNo, BillDate, AreaCode, Free_Per, Hatch_date, BatchNo from InvPhxChicken where areacode='" & cmbAreaCode.Text & "' and  itemname='" & particular.Text & "' and Session='" & GMod.Session & "'"
        GMod.SqlExecuteNonQuery(SQL)
        SQL = "Select * from tmpInvPhxChicken"
        GMod.DataSetRet(SQL, "BatchNo")
        Dim BT() As String
        For i = 0 To GMod.ds.Tables("BatchNo").Rows.Count - 1
            BT = Split(GMod.ds.Tables("BatchNo").Rows(i)("BatchNo"), "/")
            'MsgBox(BT(0))
            SQL = "Update tmpInvPhxChicken set BatchNo1='" & BT(0) & "' where BatchNo='" & GMod.ds.Tables("BatchNo").Rows(i)("BatchNo") & "'"
            GMod.SqlExecuteNonQuery(SQL)
        Next
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        CrystalReportViewer1.PrintReport()
        btnprint.Enabled = False
    End Sub
End Class