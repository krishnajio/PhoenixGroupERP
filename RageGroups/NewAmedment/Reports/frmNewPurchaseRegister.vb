Public Class frmNewPurchaseRegister
    Dim sql, p2, p3, p4, p5 As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        voutype.Enabled = False
        p2 = ""
        p3 = ""
        p4 = ""
        p5 = ""
        If chkcform.Checked = False Then
            'sql = "select * from new_pur_reg"
            sql = "select pd.*,ach.account_head_name,ach.address, account_type as remark2 from Purchase_Data pd "
            sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type='" & voutype.Text & "' and pd.cmp_id ='" & GMod.Cmpid & "' and authr<>'-' "

            If txtv1.Text <> "" Then
                sql &= " and  cast(vou_no as numeric(18,0)) between " & txtv1.Text & " and " & txtv2.Text & ""
                p2 = "Voucher No." & txtv1.Text & " To " & txtv2.Text
            End If

            If txtp1.Text <> "" Then
                If txtp1.Text <> "" Then
                    sql &= " and  pono between '" & txtp1.Text & "' and '" & txtp2.Text & "'"
                    p3 = "Po. No." & txtp1.Text & " To " & txtp2.Text

                End If
            End If
            If txti1.Text <> "" Then
                If txti1.Text <> "" Then
                    sql &= " and  inwno between '" & txti1.Text & "' and '" & txti2.Text & "'"
                    p4 = "Inw. No." & txti1.Text & " To " & txti2.Text
                End If
            End If
            If cmbprdunit.Text <> "" Then
                sql &= " and for_where='" & cmbprdunit.Text & "'"
                p4 = " Unit." & cmbprdunit.Text
            End If
            sql &= " ORDER BY cast(vou_no as numeric(18,0)),id"
        Else
            sql = "select pd.*,ach.account_head_name,ach.address, account_type as remark2 from Purchase_Data pd"
            sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type='" & voutype.Text & "' and authr<>'-' and month(bill_date)=" & dtdate.Value.Month & "" '  and for_where='" & cmbprdunit.Text & "'"
            sql &= " ORDER BY bill_date"
        End If
        GMod.DataSetRet(sql, "npr")
        Dim r As New CrNew_Pur_Register
        r.SetDataSource(GMod.ds.Tables("npr"))
        r.SetParameterValue("p1", GMod.Cmpname)
        r.SetParameterValue("p2", p2)
        r.SetParameterValue("p3", p3)
        r.SetParameterValue("p4", p4)
        r.SetParameterValue("p5", p5)
        r.SetParameterValue("p6", voutype.Text.ToUpper & "- REGISTER")
        r.SetParameterValue("p7", GMod.username)
        r.SetParameterValue("p8", OtherCheck)
        CrystalReportViewer1.ReportSource = r
        ' cmbprdunit.Text = ""
    End Sub
    Dim OtherCheck As Double = 0.0
    Private Sub frmNewPurchaseRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'filling production unit 
        GMod.DataSetRet("select prdunit from prdunit where cmp_id='" & GMod.Cmpid & "'", "prdunit")
        cmbprdunit.DataSource = GMod.ds.Tables("prdunit")
        cmbprdunit.DisplayMember = "prdunit"
        cmbprdunit.Text = ""
        GMod.DataSetRet("select vtype from vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq ='" & GMod.Dept & "' and session ='" & GMod.Session & " '", "vt")
        voutype.DataSource = GMod.ds.Tables("vt")
        voutype.DisplayMember = "vtype"

        GMod.DataSetRet("select stock_val from company where cmp_id ='" & GMod.Cmpid & "'", "othercmpCheck")
        If Val(GMod.ds.Tables("othercmpCheck").Rows(0)(0)) = 1.11 Then
            OtherCheck = 1.11
        Else
            OtherCheck = 0.0
        End If
    End Sub
End Class