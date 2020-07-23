Public Class frmHeadTransfer

    Private Sub frmHeadTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        fillArea()
        cmbAreaCode.Text = "JB"

        GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "' and group_name<>'PARTY' and group_name<>'CUSTOMER'", "grp")
        cmbgrpname.DataSource = GMod.ds.Tables("grp")
        cmbgrpname.DisplayMember = "group_name"
        cmbgroupsuffix.DataSource = GMod.ds.Tables("grp")
        cmbgroupsuffix.DisplayMember = "Suffix"
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")
        GMod.DataSetRet(sqlarea, "Area1")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAcodeto.DataSource = GMod.ds.Tables("Area1")
        cmbAcodeto.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"

        CmbAreato.DataSource = GMod.ds.Tables("Area1")
        CmbAreato.DisplayMember = "Areaname"
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Dim transfer As String
        transfer = "insert into " & GMod.ACC_HEAD & " (Cmp_id, account_code, account_head_name, group_name, " _
        & "sub_group_name, credit_days, credit_limit, opening_dr, opening_cr, account_type, address, " _
        & "city, state, phone, pan_no, rate_of_interest, interest_rule_id, Area_code, remark1, remark2, remark3) " _
        & "select Cmp_id, '" & cmbAcodeto.Text & "'+ right(account_code,6) , account_head_name, group_name, " _
        & "sub_group_name, credit_days, credit_limit, opening_dr, opening_cr, account_type ," _
        & "address, city, state, phone, pan_no, rate_of_interest, interest_rule_id, '" & cmbAcodeto.Text & "', " _
        & "remark1, remark2, remark3 from " & GMod.ACC_HEAD & " where " _
        & "group_name='" & cmbgrpname.Text & "'  and left(account_code,2)='" & cmbAreaCode.Text & "'"
        'MsgBox(transfer)
        MsgBox(GMod.SqlExecuteNonQuery(transfer))
    End Sub


End Class