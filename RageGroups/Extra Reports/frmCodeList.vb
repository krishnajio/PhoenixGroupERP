Public Class frmCodeList

    Private Sub frmCodeList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "'  and session = '" & GMod.Session & "'", "grp")
        cmbgrpname.DataSource = GMod.ds.Tables("grp")
        cmbgrpname.DisplayMember = "group_name"
        cmbgroupsuffix.DataSource = GMod.ds.Tables("grp")
        cmbgroupsuffix.DisplayMember = "Suffix"

        fillgrid("")
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        fillgrid("")
    End Sub
    Sub fillgrid(ByVal a As String)
        Dim i As Integer
        Dim sql As String

        If GMod.Cmpid = "PHOE" Then
            If cmbgrpname.Text = "PARTY" Then
                sql = "select a.account_code,a.account_head_name, a.address,a.city,a.state,a.phone, a.pan_no,"
                sql &= "   p.bankName as remark1, p.accNumber as remark2 , p.ifscCode as remark3 , p.branch as Area_code"
                sql &= " from " & GMod.ACC_HEAD & "  a inner join partyBankDetials p "
                sql &= "on a.Cmp_id=p.Cmp_id and a.account_code = p.partyCode "


            Else
                sql = "select * from " & GMod.ACC_HEAD & "  where group_name='" & cmbgrpname.Text & "' and cmp_id='" & GMod.Cmpid & "' and account_head_name like '%" & a & "%' order by group_name,sub_group_name,account_head_name"

            End If

        Else
            sql = "select * from " & GMod.ACC_HEAD & "  where group_name='" & cmbgrpname.Text & "' and cmp_id='" & GMod.Cmpid & "' and account_head_name like '%" & a & "%' order by group_name,sub_group_name,account_head_name"
        End If



        'If a <> "" Then
        '    sql = "select * from " & GMod.ACC_HEAD & "  where group_name='" & cmbgrpname.Text & "' and cmp_id='" & GMod.Cmpid & "' and account_head_name like '%" & a & "%' order by group_name,sub_group_name,account_head_name"

        '    sql = "select a.account_code,a.account_head_name, a.address,a.city,a.state,a.phone, a.pan_no,"
        '    sql &= "   p.bankName as remark1, p.accNumber as remark2 , p.ifscCode as remark3 , p.branch as Area_code"
        '    sql &= " from ACC_HEAD_PHOE_2425 a inner join partyBankDetials p "
        '    sql &= "on a.Cmp_id=p.Cmp_id and a.account_code = p.partyCode "



        'Else
        '    sql = "select * from " & GMod.ACC_HEAD & "  where group_name='" & cmbgrpname.Text & "' and cmp_id='" & GMod.Cmpid & "' order by group_name,sub_group_name,account_head_name"
        '    sql = "select a.account_code,a.account_head_name, a.address,a.city,a.state,a.phone, a.pan_no,"
        '    sql &= "   p.bankName as remark1, p.accNumber as remark2 , p.ifscCode as remark3 , p.branch as Area_code"
        '    sql &= " from ACC_HEAD_PHOE_2425 a inner join partyBankDetials p "
        '    sql &= "on a.Cmp_id=p.Cmp_id and a.account_code = p.partyCode "

        'End If
        GMod.DataSetRet(sql, "acc")
        'dgaccounthead.Rows.Clear()
        'For i = 0 To GMod.ds.Tables("acc").Rows.Count - 1
        '    dgaccounthead.Rows.Add()
        '    dgaccounthead(0, i).Value = GMod.ds.Tables("acc").Rows(i)("account_code")
        '    dgaccounthead(1, i).Value = GMod.ds.Tables("acc").Rows(i)("account_head_name")
        '    dgaccounthead(2, i).Value = GMod.ds.Tables("acc").Rows(i)("group_name")
        '    dgaccounthead(3, i).Value = GMod.ds.Tables("acc").Rows(i)("sub_group_name")
        '    dgaccounthead(4, i).Value = GMod.ds.Tables("acc").Rows(i)("opening_dr")
        '    dgaccounthead(5, i).Value = GMod.ds.Tables("acc").Rows(i)("opening_cr")
        'Next

        Dim crcodelist As New CrCodeList
        crcodelist.SetDataSource(GMod.ds.Tables("acc"))
        crcodelist.SetParameterValue("p1", cmbgrpname.Text)
        CrystalReportViewer1.ReportSource = crcodelist

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        fillgrid(txtsearch.Text)
    End Sub
End Class