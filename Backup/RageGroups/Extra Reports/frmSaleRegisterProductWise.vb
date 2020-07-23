Public Class frmSaleRegisterProductWise
    Dim sql As String
    Private Sub frmSaleRegisterProductWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Filling ComboBox
        Try

            ' sql = "select itemname from ItemMaster where cmp_id='" & GMod.Cmpid & "'"

            sql = "SELECT	distinct ProductName FROM PrintData where session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "itemname")
            cmbProduct.DataSource = ds.Tables("itemname")
            cmbProduct.DisplayMember = "ProductName"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%SALE%' and vtype not like '%other%'  and vtype not like '%JOURNAL%'", "vou_type")
        voutype.DataSource = GMod.ds.Tables("vou_type")
        voutype.DisplayMember = "vtype"
        Dim i As Integer
        For i = 0 To GMod.ds.Tables("vou_type").Rows.Count - 1
            listgrp.Items.Add(GMod.ds.Tables("vou_type").Rows(i)("vtype"))
            listgrp.SetSelected(i, True)
        Next

        'selecT areaname,prefix from area
        GMod.DataSetRet("select areaname,prefix from area", "s_area_s")
        cmbArea.DataSource = GMod.ds.Tables("s_area_s")
        cmbArea.DisplayMember = "areaname"
        cmbArea.ValueMember = "prefix"


    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
       


        If CheckBox1.Checked <> True Then
            'sql = "select * from PrintData where cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "' and productname='" & cmbProduct.Text & "' and hatchdate between '" & d1.Value.ToShortDateString & "' and  '" & d2.Value.ToShortDateString & "' and vou_type='" & voutype.Text & "' and authr<>'-' order by cast(vou_no as bigint)"
            sql = "select *,isnull(h.rate,0) area_rate from PrintData p left outer join HatchWiseRate h "
            sql += " on(p.hatchdate=h.hatchdate and p.productname=h.product and p.station=h.areaname and p.cmp_id=h.cmp_id) "
            sql += " where p.cmp_id='" & GMod.Cmpid & "' and p.session='" & GMod.Session & "' and p.productname='" & cmbProduct.Text & "' and p.hatchdate between '" & d1.Value.ToShortDateString & "' and  '" & d2.Value.ToShortDateString & "' and p.vou_type='" & voutype.Text & "' and p.authr<>'-' order by cast(p.vou_no as bigint)"

            GMod.DataSetRet(sql, "pwsr")
            Dim cr As New CrSRPW
            cr.SetDataSource(GMod.ds.Tables("pwsr"))
            cr.SetParameterValue("cmpid", GMod.Cmpname)
            cr.SetParameterValue("fromdate", "DATE FROM " & d1.Value.ToShortDateString & " To " & d2.Value.ToShortDateString)
            CrystalReportViewer1.ReportSource = cr
        Else
            sql = "select sum(qty) TotalQty ,sum(freeqty) Freeqty , sum(qty)-sum(freeqty) BilledQty, left(Acccode,2) area ,hatchdate,productname ,sum(Amount) amt  from printdata " _
            & " where session='" & GMod.Session & "' and hatchdate between '" & d1.Value.ToShortDateString & "' and '" & d2.Value.ToShortDateString & "' " _
            & " and productname not in ('N.E.E.C AMOUNT','DISCOUNT AMOUNT') and cmp_id='" & GMod.Cmpid & "' and authr<>'-'" _
            & " group by hatchdate,left(Acccode,2),productname" _
            & " order by left(Acccode,2),productname,hatchdate "

            GMod.DataSetRet(sql, "pwsr")
            Dim cr As New CrHatchSummary
            cr.SetDataSource(GMod.ds.Tables("pwsr"))
            cr.SetParameterValue("cmpid", GMod.Cmpname)
            cr.SetParameterValue("fromdate", "DATE FROM " & d1.Text & " To " & d2.Text)
            CrystalReportViewer1.ReportSource = cr

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cmbProduct.Enabled = False
        Else
            cmbProduct.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vtype As String
        Dim j As Integer

 
        If listgrp.CheckedItems.Count > 0 Then
            For j = 0 To listgrp.CheckedItems.Count - 1
                vtype &= "'" & listgrp.CheckedItems([j].ToString) & "',"
            Next
        End If
        vtype = vtype.Remove(vtype.Length - 1, 1)
        MessageBox.Show(vtype)
        If CheckBox2.Checked = True Then
            'sql = "select * from PrintData where cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "' and productname='" & cmbProduct.Text & "' and hatchdate between '" & d1.Value.ToShortDateString & "' and  '" & d2.Value.ToShortDateString & "' and vou_type='" & voutype.Text & "' and authr<>'-' order by cast(vou_no as bigint)"
            sql = "select *,isnull(h.rate,0) area_rate from PrintData p left outer join HatchWiseRate h "
            sql += " on(p.hatchdate=h.hatchdate and p.productname=h.product and p.station=h.areaname and p.cmp_id=h.cmp_id) "
            sql += " where p.cmp_id='" & GMod.Cmpid & "' and p.session='" & GMod.Session & "' and p.productname='" & cmbProduct.Text & "' and p.hatchdate between '" & d1.Value.ToShortDateString & "' and  '" & d2.Value.ToShortDateString & "' and p.vou_type IN (" & vtype & ") and  left(P.Acccode,2) = '" & cmbArea.SelectedValue.ToString & "' AND p.authr<>'-' order by cast(p.vou_no as bigint)"

            GMod.DataSetRet(sql, "pwsr")
            Dim cr As New CrSRPW
            cr.SetDataSource(GMod.ds.Tables("pwsr"))
            cr.SetParameterValue("cmpid", GMod.Cmpname)
            cr.SetParameterValue("fromdate", "DATE FROM " & d1.Value.ToShortDateString & " To " & d2.Value.ToShortDateString)
            CrystalReportViewer1.ReportSource = cr

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class