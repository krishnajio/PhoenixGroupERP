Public Class frmOtherSaleReg
    Dim chkdaybook As Boolean = False
    Dim State As String
    Dim SqlQuery As String
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        'CHECHKING FOR DAY BOOK UN UTHORISED DATA'''''''''''''''''''''''''''***************************************************
        GMod.DataSetRet("select * from " & GMod.VENTRY & " where pay_mode ='-' and cast(vou_no as bigint)  between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & " AND vou_type in ('" & voutype.Text & "')", "UADATACH")
        If GMod.ds.Tables("UADATACH").Rows.Count > 0 Then
            chkdaybook = True
        Else
            chkdaybook = False
        End If
        ''''''''''''''''''''''''''''''*****************************************************
        txtCrNoFrom.Enabled = False
        txtCrNoTo.Enabled = False
        'If CheckBox1.Checked = False Then

        If cmbOS.Text = "WS" Then
            SqlQuery = " select Vou_type, Vou_no, AccCode, AccName, freight as  Station, ProductName, OutQty, Rate, Amount, OutQtyNos, BillNo, BillDate, InQty, "
            SqlQuery &= " InQtyNos, o.Cmp_id  Cmp_id , Session, id, isnull(tcs_amt,0) as tcs_amt, authr, Prdunit, Packing, Insurance, Discount, CrHead, cgstp, cgsta, sgstp, sgsta, "
            SqlQuery &= " igstp, igsta , a.state from OtherSaleData  o"
            SqlQuery &= " inner join Acc_head_phoe_2324 a on o.AccCode= a.account_code "
            SqlQuery &= " where vou_type in ('" & voutype.Text & "') and cast(Vou_no as numeric(20)) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & "  AND session = '" & GMod.Session & "' and o.cmp_id='" & GMod.Cmpid & "'and authr<>'-' "
            SqlQuery &= " and a.state='MADHYA PRADESH' ORDER BY CAST(VOU_NO AS BIGINT),ID "
        ElseIf cmbOS.Text = "OS" Then
            SqlQuery = " select Vou_type, Vou_no, AccCode, AccName, freight as  Station, ProductName, OutQty, Rate, Amount, OutQtyNos, BillNo, BillDate, InQty, "
            SqlQuery &= " InQtyNos, o.Cmp_id  Cmp_id , Session, id, isnull(tcs_amt,0) as tcs_amt, authr, Prdunit, Packing, Insurance, Discount, CrHead, cgstp, cgsta, sgstp, sgsta, "
            SqlQuery &= " igstp, igsta , a.state from OtherSaleData  o"
            SqlQuery &= " inner join Acc_head_phoe_2324 a on o.AccCode= a.account_code "
            SqlQuery &= " where vou_type in ('" & voutype.Text & "') and cast(Vou_no as numeric(20)) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & "  AND session = '" & GMod.Session & "' and o.cmp_id='" & GMod.Cmpid & "'and authr<>'-' "
            SqlQuery &= " and a.state  <> 'MADHYA PRADESH' ORDER BY CAST(VOU_NO AS BIGINT),ID "
        ElseIf cmbOS.Text = "ALL" Then
            SqlQuery = " select Vou_type, Vou_no, AccCode, AccName, freight as  Station, ProductName, OutQty, Rate, Amount, OutQtyNos, BillNo, BillDate, InQty, "
            SqlQuery &= " InQtyNos, o.Cmp_id  Cmp_id , Session, id, isnull(tcs_amt,0) as tcs_amt, authr, Prdunit, Packing, Insurance, Discount, CrHead, cgstp, cgsta, sgstp, sgsta, "
            SqlQuery &= " igstp, igsta , a.state from OtherSaleData  o"
            SqlQuery &= " inner join Acc_head_phoe_2324 a on o.AccCode= a.account_code "
            SqlQuery &= " where vou_type in ('" & voutype.Text & "') and cast(Vou_no as numeric(20)) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & "  AND session = '" & GMod.Session & "' and o.cmp_id='" & GMod.Cmpid & "'and authr<>'-' "
            SqlQuery &= " ORDER BY CAST(VOU_NO AS BIGINT),ID "
        End If
        GMod.DataSetRet(SqlQuery, "SaleReg1")

        'GMod.DataSetRet("select Vou_type, Vou_no, AccCode, AccName, freight as  Station, ProductName, OutQty, Rate, Amount, OutQtyNos, BillNo, BillDate, InQty, InQtyNos, Cmp_id, Session, id, isnull(tcs_amt,0) as tcs_amt, authr, Prdunit, Packing, Insurance, Discount, CrHead, cgstp, cgsta, sgstp, sgsta, igstp, igsta from OtherSaleData  where vou_type in ('" & voutype.Text & "') and cast(Vou_no as numeric(20)) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & "  AND session = '" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and authr<>'-' ORDER BY CAST(VOU_NO AS BIGINT),ID ", "SaleReg1")
        'Else
        'GMod.DataSetRet("select * from OtherSaleData  where vou_type='OTHER SALE RET.' and cast(Vou_no as bigint) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & " ORDER BY ID ", "SaleReg1")

        ' End If
        'If CheckBox2.Checked = True Then
        'GMod.DataSetRet("select * from OtherSaleData  where vou_type='" & voutype.Text & "' and cast(Vou_no as bigint) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & " ORDER BY ID ", "SaleReg1")
        'End If
        Dim crsr As New CryOtherSaleReg
        crsr.SetDataSource(GMod.ds.Tables("SaleReg1"))
        crsr.SetParameterValue("p1", GMod.Cmpname)
        crsr.SetParameterValue("p2", "Invoice No. From " & txtCrNoFrom.Text & " To " & txtCrNoTo.Text)
        crsr.SetParameterValue("p3", "Session " & GMod.Session)
        crsr.SetParameterValue("p4", "User Name " & GMod.username)
        'If CheckBox1.Checked = False Then
        crsr.SetParameterValue("p5", "Sale Register - B ")
        'Else
        'crsr.SetParameterValue("p5", "Sale Return - B ")
        'End If
        'If CheckBox1.Checked = True Then
        crsr.SetParameterValue("p5", voutype.Text)
        'End If
        CrystalReportViewer1.ReportSource = crsr

    End Sub
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If chkdaybook = True Then
            MsgBox("Un cheched voucher exixts for the day, please authorise first", MsgBoxStyle.Critical)
            Exit Sub
        End If
        CrystalReportViewer1.PrintReport()
        btnprint.Enabled = False
    End Sub

    Private Sub cmbOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOS.SelectedIndexChanged
        If cmbOS.Text = "WIN" Then
            State = "MADHYA PRADESH"
        Else

        End If
    End Sub
End Class