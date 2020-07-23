Public Class frmGSTReg

    Dim sql As String
    Private Sub frmPurRepQtyMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        sql = "select  account_type  + '#' + account_head_name act from acc_head_phoe_1718 where group_name ='party' and len(account_type)>=15 union select 'ALL'  act from acc_head_phoe_1718"
        GMod.DataSetRet(sql, "prdunit")
        cmbprdunit.DataSource = GMod.ds.Tables("prdunit")
        cmbprdunit.DisplayMember = "act"
        '  cmbprdunit.Text = ""

        'GMod.DataSetRet("select vtype from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%PUR%'", "vtpm")
        'cmbvou_type.DataSource = GMod.ds.Tables("vtpm")
        'cmbvou_type.DisplayMember = "vtype"


    End Sub
    Dim p2, p3, p4, p5 As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        voutype.Enabled = False
        p2 = ""
        p3 = ""
        p4 = ""
        p5 = ""
        ' If chkcform.Checked = False Then
        'sql = "select * from new_pur_reg"
        'sql = "select pd.*,ach.account_head_name,account_type as remark2, state as address  from Purchase_Data pd"
        'sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type='" & cmbvou_type.Text & "' and pd.cmp_id ='" & GMod.Cmpid & "'" ' and authr<>'-' "
        'sql &= " and  bill_date between '" & d1.Value.ToShortDateString & "' and '" & d2.Value.ToShortDateString & "'"
        'sql &= " ORDER BY cast(vou_no as numeric(18,0)),id"

        Dim gstno(2) As String
        gstno = cmbprdunit.Text.Split("#")


        If cmbprdunit.Text = "ALL" Then
            sql = "select pd.*,ach.account_head_name,account_type as remark2, state as address  from Purchase_Data pd"
            sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and left(account_type,2)='" & cmbvou_type.Text & "' and pd.cmp_id ='" & GMod.Cmpid & "'" ' and authr<>'-' "
            sql &= " and  bill_date between '" & d1.Value.ToShortDateString & "' and '" & d2.Value.ToShortDateString & "'"
            sql &= " ORDER BY cast(vou_no as numeric(18,0)),id"
        Else
            sql = "select pd.*,ach.account_head_name,account_type as remark2, state as address  from Purchase_Data pd"
            sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and account_type='" & gstno(0).Trim & "' and pd.cmp_id ='" & GMod.Cmpid & "'" ' and authr<>'-' "
            sql &= " and  bill_date between '" & d1.Value.ToShortDateString & "' and '" & d2.Value.ToShortDateString & "'"
            sql &= " ORDER BY cast(vou_no as numeric(18,0)),id"
        End If
        'If txtv1.Text <> "" Then
        '    sql &= " and  cast(vou_no as numeric(18,0)) between " & txtv1.Text & " and " & txtv2.Text & ""
        '    p2 = "Voucher No." & txtv1.Text & " To " & txtv2.Text
        'End If

        'If txtp1.Text <> "" Then
        '    If txtp1.Text <> "" Then
        '        sql &= " and  pono between '" & txtp1.Text & "' and '" & txtp2.Text & "'"
        '        p3 = "Po. No." & txtp1.Text & " To " & txtp2.Text

        '    End If
        'End If
        'If txti1.Text <> "" Then
        '    If txti1.Text <> "" Then
        '        sql &= " and  inwno between '" & txti1.Text & "' and '" & txti2.Text & "'"
        '        p4 = "Inw. No." & txti1.Text & " To " & txti2.Text
        '    End If
        'End If
        'If cmbprdunit.Text <> "" Then
        '    sql &= " and for_where='" & cmbprdunit.Text & "'"
        '    p4 = " Unit." & cmbprdunit.Text
        'End If

        'Else
        'sql = "select pd.*,ach.account_head_name,ach.address, account_type as remark2 from Purchase_Data pd"
        'sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type='" & voutype.Text & "' and authr<>'-' and month(bill_date)=" & dtdate.Value.Month & "" '  and for_where='" & cmbprdunit.Text & "'"
        'sql &= " ORDER BY bill_date"
        'End If
        GMod.DataSetRet(sql, "gstpr")
        Dim r As New CrGSTRegister
        r.SetDataSource(GMod.ds.Tables("gstpr"))
        r.SetParameterValue("p7", GMod.username)
        r.SetParameterValue("p8", 0)
        CrystalReportViewer1.ReportSource = r
    End Sub
End Class