Public Class frmOtherSaleReg
    Dim chkdaybook As Boolean = False
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
        GMod.DataSetRet("select * from OtherSaleData  where vou_type in ('" & voutype.Text & "') and cast(Vou_no as numeric(20)) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & "  AND session = '" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and authr<>'-' ORDER BY CAST(VOU_NO AS BIGINT),ID ", "SaleReg1")
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

    Private Sub frmOtherSaleReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If chkdaybook = True Then
            MsgBox("Un cheched voucher exixts for the day, please authorise first", MsgBoxStyle.Critical)
            Exit Sub
        End If
        CrystalReportViewer1.PrintReport()
        btnprint.Enabled = False
    End Sub
End Class