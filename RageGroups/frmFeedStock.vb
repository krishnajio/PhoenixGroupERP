Public Class frmFeedStock

    Private Sub frmFeedStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillArea()
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
        CrystalReportViewer1.Height = Me.Height - 150
    End Sub
    Dim i As Long
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql As String, up As String, i As Integer
        'If rdDetial.Checked = False Then

        '    'Delete 
        '    GMod.SqlExecuteNonQuery("Delete from tmpStockTab")

        '    'Inserting SALE Quantity
        '    sql = "insert into [tmpStockTab](AreaCode, ItemName, SaleQty,Cmp_id) select Areacode,ItemName,sum(qty) qty,Cmp_id from  " & GMod.INVENTORY & " " _
        '       & " where vou_type='SALE' and Billdate " _
        '       & " between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Areacode='" & cmbAreaCode.Text & "' " _
        '       & " group by ItemName,left(AreaCode,2) "
        '    GMod.SqlExecuteNonQuery(sql)

        '    'Updating Transfer Quantity
        '    sql = "select sum(qty) qty ,ItemName,Areacode,Cmp_id from " & GMod.INVENTORY & " " _
        '       & " where vou_type='JOURNAL' and Billdate " _
        '       & " between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Areacode='" & cmbAreaCode.Text & "' " _
        '       & " group by ItemName,left(AreaCode,2) "
        '    GMod.DataSetRet(sql, "Tran")
        '    For i = 0 To GMod.ds.Tables("Tran").Rows.Count - 1
        '        up = "update tmpStockTab set TransferQty ='" & GMod.ds.Tables("Tran").Rows(i)("qty") & "' where ItemName='" & GMod.ds.Tables("Tran").Rows(i)("ItemName") & "' and AreaCode='" & GMod.ds.Tables("Tran").Rows(i)("AreaCode") & "'and Cmp_id='" & GMod.ds.Tables("Tran").Rows(i)("Cmp_id") & "'"
        '        GMod.SqlExecuteNonQuery(up)
        '        sql = " select  max(cast( BillNo as bigint)) vou , max(Billdate) vdate  from " & GMod.INVENTORY & " where ItemNAme='" & GMod.ds.Tables("Tran").Rows(i)("ItemName") & "' and AreaCode='" & cmbAreaCode.Text & "' and vou_type='SALE'"
        '        GMod.DataSetRet(sql, "xx")
        '        up = "update tmpStockTab set LastBill ='" & GMod.ds.Tables("xx").Rows(0)("vou") & "',LastBillDate='" & GMod.ds.Tables("xx").Rows(0)("vdate") & "' where ItemName='" & GMod.ds.Tables("Tran").Rows(i)("ItemName") & "' and AreaCode='" & GMod.ds.Tables("Tran").Rows(i)("AreaCode") & "'and Cmp_id='" & GMod.ds.Tables("Tran").Rows(i)("Cmp_id") & "'"
        '        GMod.SqlExecuteNonQuery(up)

        '    Next

        '    'Updating OPenig Quantity
        '    sql = "select AreaCode ,ItemName,Qty,Cmp_id from dbo.ItemOpening" _
        '          & " where cmp_id='" & GMod.Cmpid & "' and  AreaCode='" & cmbAreaCode.Text & "'"
        '    GMod.DataSetRet(sql, "TT")
        '    For i = 0 To GMod.ds.Tables("TT").Rows.Count - 1
        '        up = "update tmpStockTab set OpenQty ='" & GMod.ds.Tables("TT").Rows(i)("qty") & "' where ItemName='" & GMod.ds.Tables("TT").Rows(i)("ItemName") & "' and AreaCode='" & GMod.ds.Tables("TT").Rows(i)("AreaCode") & "'and Cmp_id='" & GMod.ds.Tables("TT").Rows(i)("Cmp_id") & "'"
        '        GMod.SqlExecuteNonQuery(up)
        '    Next
        '    sql = "select * from tmpStockTab"
        '    GMod.DataSetRet(sql, "rep")
        '    Dim cr As New CrFeedStockRep
        '    cr.SetDataSource(GMod.ds.Tables("rep"))
        '    cr.SetParameterValue("subhead", "Area:" & cmbAreaName.Text)
        '    cr.SetParameterValue("subhead1", "Date From" & dtfrom.Text & " To " & dtto.Text)
        '    CrystalReportViewer1.ReportSource = cr
        'Else

        '    GMod.SqlExecuteNonQuery("Delete from tmpFeedRep")
        '    'For Opening
        '    sql = "insert into dbo.tmpFeedRep" _
        '           & " select 'OPENING',ItemName,'4/1/2008','',Qty,AreaCode from itemopening where AreaCode='" & cmbAreaCode.Text & "'"
        '    GMod.SqlExecuteNonQuery(sql)

        '    'For Transfer 
        '    sql = " insert into tmpFeedRep " _
        '    & " select vou_type,ItemName,BillDAte,BillNO,Qty,AreaCode from " & GMod.INVENTORY & " where AreaCode='" & cmbAreaCode.Text & "' and vou_type<>'SALE'"
        '    GMod.SqlExecuteNonQuery(sql)

        '    'For Sale 
        '    'If GMod.Cmpid = "PHFE" Then
        '    '    sql = "select * from " & GMod.VENTRY & " where left(acc_head_code,2)='" & cmbAreaCode.Text & "' and vou_type='SALE'"
        '    '    GMod.DataSetRet(sql, "vdata")
        '    '    For i = 0 To GMod.ds.Tables("vdata").Rows.Count - 1
        '    '        sql = "select vou_type,ItemName,BillDAte,BillNO,Qty,AreaCode from " & GMod.INVENTORY & " where AreaCode='" & cmbAreaCode.Text & "' and vou_type='SALE'  and vou_no='" & GMod.ds.Tables("vdata").Rows(i)("vou_no").ToString & "'"
        '    '        GMod.DataSetRet(sql, "check")
        '    '        If GMod.ds.Tables("check").Rows.Count > 0 Then
        '    '            sql = " insert into tmpFeedRep " _
        '    '                       & " select vou_type,ItemName,BillDAte,BillNO,Qty,AreaCode from " & GMod.INVENTORY & " where AreaCode='" & cmbAreaCode.Text & "' and vou_type='SALE'  and vou_no='" & GMod.ds.Tables("vdata").Rows(i)("vou_no").ToString & "'"
        '    '            GMod.SqlExecuteNonQuery(sql)
        '    '        End If
        '    '    Next

        '    '    sql = "update tmpFeedRep set qty = -1*qty where  vou_type='SALE'"
        '    '    GMod.SqlExecuteNonQuery(sql)


        '    'Else
        '    sql = " insert into tmpFeedRep " _
        '             & " select vou_type,ItemName,BillDAte,BillNO,Qty,AreaCode from " & GMod.INVENTORY & " where AreaCode='" & cmbAreaCode.Text & "' and vou_type='SALE'"
        '    GMod.SqlExecuteNonQuery(sql)

        '    'End If

        '    sql = "select * from tmpFeedRep " ' where BillDAte between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "'"
        '    GMod.DataSetRet(sql, "rep1")
        '    Dim cr As New CrFeedRep1
        '    cr.SetDataSource(GMod.ds.Tables("rep1"))
        '    cr.SetParameterValue("0", GMod.Cmpname)
        '    cr.SetParameterValue("1", "Date From" & dtfrom.Text & " To " & dtto.Text)
        '    cr.SetParameterValue("2", "Area:" & cmbAreaName.Text)
        '    CrystalReportViewer1.ReportSource = cr
        'End If

        sql = "select DISTINCT * from " & GMod.INVENTORY & " where vou_type='" & ComboBox1.Text & "' and left(Acc_head_code,2)='" & cmbAreaCode.Text & "'  AND BillDAte between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "'"
        GMod.DataSetRet(sql, "rep1")
        Dim cr1 As New CrQtyAmtReport
        cr1.SetDataSource(GMod.ds.Tables("rep1"))
        cr1.SetParameterValue("0", GMod.Cmpname)
        cr1.SetParameterValue("1", "Date From  " & dtfrom.Text & " To " & dtto.Text)
        cr1.SetParameterValue("2", "Area:" & cmbAreaName.Text)
        CrystalReportViewer1.ReportSource = cr1

    End Sub

    Private Sub rdDetial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDetial.CheckedChanged

    End Sub
End Class