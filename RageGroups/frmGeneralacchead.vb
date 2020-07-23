Imports System.Data.SqlClient
Public Class frmGeneralacchead

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmGeneralacchead_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub frmGeneralacchead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If GMod.role.ToUpper <> "ADMIN" Then
            txtamt.Enabled = False
            cmbdrcr.Enabled = False
        End If
        If GMod.role.ToUpper = "VIEWER LEVEL-1" Then
            btnsave.Enabled = True
            btnmodify.Enabled = True
            'txtamt.Enabled = True
            'cmbdrcr.Enabled = True
        ElseIf GMod.role.ToUpper = "ADMIN" Then
            btnsave.Enabled = True
            txtamt.Enabled = True
            cmbdrcr.Enabled = True
            btnmodify.Enabled = True
        End If

        Me.Text = Me.Text & "    " & GMod.Cmpname
        txtacheadname.Focus()
        fillArea()
        cmbAreaCode.Text = "**"

        GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "' and group_name<>'PARTY' and group_name<>'CUSTOMER' and session ='" & GMod.Session & "'", "grp")
        cmbgrpname.DataSource = GMod.ds.Tables("grp")
        cmbgrpname.DisplayMember = "group_name"
        cmbgroupsuffix.DataSource = GMod.ds.Tables("grp")
        cmbgroupsuffix.DisplayMember = "Suffix"
        cmbdrcr.SelectedIndex = 0
        fillgrid("")
        nxtid()
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

    Private Sub cmbgrpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrpname.SelectedIndexChanged
        Try
            GMod.DataSetRet("select * from sub_group where group_name='" & cmbgrpname.Text & "' and  cmp_id='" & GMod.Cmpid & "'", "sgrp")
            If GMod.ds.Tables("sgrp").Rows.Count > 0 Then

                cmbsubgrpname.DataSource = GMod.ds.Tables("sgrp")
                cmbsubgrpname.DisplayMember = "sub_group_name"
            Else
                cmbsubgrpname.DataSource = Nothing
                cmbsubgrpname.Items.Add("-")
                cmbsubgrpname.SelectedIndex = 0
            End If
            nxtid()
            If radiogrp.Checked Then fillgrid("")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub nxtid()
        ' On Error Resume Next
        'If GMod.role = "ADMIN" Then
        GMod.DataSetRet("select isnull(max(right(account_code,4))+1,1) from " & GMod.ACC_HEAD & " where left(account_code,2)='" & cmbAreaCode.Text & "' and group_name='" & cmbgrpname.Text & "'", "nxt")
        If GMod.ds.Tables("nxt").Rows.Count > 0 Then lblacheadcode.Text = cmbAreaCode.Text & cmbgroupsuffix.Text & Format(GMod.ds.Tables("nxt").Rows(0)(0), "0000")
        'End If
    End Sub
    Dim s, sql As String

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MessageBox.Show("Are U sure", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim sql As String
            sql = "select account_code from " & GMod.ACC_HEAD & " where account_head_name='CASH'"
            GMod.DataSetRet(sql, "chck")
            If GMod.ds.Tables("chck").Rows.Count > 0 Then
                If txtacheadname.Text.ToUpper = "CASH" Then
                    MsgBox("CASH ACCOUNT ALREADY EXISTS")
                    txtacheadname.Focus()
                    Exit Sub
                Else
                    'Exit Sub
                End If
            End If
            GMod.ds.Tables("chck").Dispose()
            If Trim(txtacheadname.Text) = "" Then
                MsgBox("Please enter Account Head / Ledger Name", MsgBoxStyle.Critical, GMod.Cmpname)
                Exit Sub
            End If
            If cmbdrcr.Text = "Dr" Then
                sql = "insert into " & GMod.ACC_HEAD & "(cmp_id,account_code,account_head_name,group_name,sub_group_name,"
                sql += "account_type,opening_dr,opening_cr,Area_code,interest_rule_id) values('" & GMod.Cmpid & "','" & lblacheadcode.Text & "',"
                sql += "'" & txtacheadname.Text.ToUpper.Trim & "','" & cmbgrpname.Text & "','" & cmbsubgrpname.Text & "','G',"
                sql += Val(txtamt.Text) & ",0,'" & cmbAreaCode.Text & "','" & GMod.username & "')"
            Else
                sql = "insert into " & GMod.ACC_HEAD & "(cmp_id,account_code,account_head_name,group_name,sub_group_name,"
                sql += "account_type,opening_dr,opening_cr,Area_code,interest_rule_id) values('" & GMod.Cmpid & "','" & lblacheadcode.Text & "',"
                sql += "'" & txtacheadname.Text.ToUpper.Trim & "','" & cmbgrpname.Text & "','" & cmbsubgrpname.Text & "','G',0,"
                sql += Val(txtamt.Text) & ",'" & cmbAreaCode.Text & "','" & GMod.username & "')"
                'MsgBox(sql)
            End If
            s = GMod.SqlExecuteNonQuery(sql)
            If s <> "SUCCESS" Then
                MsgBox(s, MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Account Head Created Successfully", MsgBoxStyle.Information, GMod.Cmpname)
                CreateHeadToNextSession()
                btnreset_Click(sender, e)
                fillgrid("")
                nxtid()
            End If
            txtacheadname.Focus()
        End If
    End Sub
    Public Sub CreateHeadToNextSession()
        Try
            'For Creating Head to nextsession
            Dim sess As String, headto As String, sql As String
            sess = GMod.Session.Substring(2, 2)
            sess = sess & (Val(sess) + 1).ToString
            Dim dr As Double, cr As Double
            headto = "ACC_HEAD_" & GMod.Cmpid & "_" & sess.ToString
            GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & headto & "'", "tableaccount")
            If GMod.ds.Tables("tableaccount").Rows.Count <> 0 Then

                'MsgBox(sess)

                sql = "select * from " & headto & " where  account_code= '" & lblacheadcode.Text & "'"
                GMod.DataSetRet(sql, "CHKHEAD")
                If GMod.ds.Tables("CHKHEAD").Rows.Count > 0 Then

                Else
                    If cmbdrcr.Text = "Dr" Then
                        dr = Val(txtamt.Text)
                        cr = 0.0
                    Else
                        cr = Val(txtamt.Text)
                        dr = 0.0
                    End If
                    sql = "insert into " & headto & "(cmp_id,account_code,account_head_name,group_name,sub_group_name,"
                    sql += "account_type,opening_dr,opening_cr,Area_code) values('" & GMod.Cmpid & "','" & lblacheadcode.Text & "',"
                    sql += "'" & txtacheadname.Text.ToUpper & "','" & cmbgrpname.Text & "','" & cmbsubgrpname.Text & "','G'," & dr & ","
                    sql += cr & ",'" & cmbAreaCode.Text & "')"
                    GMod.SqlExecuteNonQuery(sql)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtacheadname.Text = ""
        txtamt.Text = ""
        txtsearch.Text = ""
        txtamt.Text = "0.00"
        cmbgrpname.Enabled = True
        cmbAreaCode.Enabled = True
        cmbgroupsuffix.Enabled = True
        cmbAreaName.Enabled = True
        'btnsave.Enabled = True
        btnmodify.Text = "&Modify"
        nxtid()
        cmbAreaCode.Enabled = True
        cmbAreaName.Enabled = True
        cmbgroupsuffix.Enabled = True
        cmbgrpname.Enabled = True
        fillgrid("")
        txtacheadname.Focus()
    End Sub
    Sub fillgrid(ByVal a As String)
        Dim i As Integer
        'If a = "" Then
        '    If radioall.Checked Then
        '        sql = "select * from " & GMod.ACC_HEAD & "  where (group_name<>'PARTY' and group_name<>'CUSTOMER') and cmp_id='" & GMod.Cmpid & "' order by group_name,sub_group_name,account_head_name"
        '    Else
        '        sql = "select * from " & GMod.ACC_HEAD & "   where (group_name<>'PARTY' and group_name<>'CUSTOMER' and group_name='" & cmbgrpname.Text & "') and cmp_id='" & GMod.Cmpid & "' order by group_name,sub_group_name,account_head_name"
        '    End If
        'Else
        '    If radioall.Checked Then
        '        sql = "select * from " & GMod.ACC_HEAD & "  where (group_name<>'PARTY' and group_name<>'CUSTOMER') and cmp_id='" & GMod.Cmpid & "' and account_head_name like '%" & a & "%' order by group_name,sub_group_name,account_head_name"
        '    Else
        '        sql = "select * from " & GMod.ACC_HEAD & "  where (group_name<>'PARTY' and group_name<>'CUSTOMER' and group_name='" & cmbgrpname.Text & "') and cmp_id='" & GMod.Cmpid & "' and account_head_name like '%" & a & "%' order by group_name,sub_group_name,account_head_name"
        '    End If
        'End If

        If a = "" Then
            If radioall.Checked Then
                sql = "select * from " & GMod.ACC_HEAD & "  where cmp_id='" & GMod.Cmpid & "' and right(left(account_code,4),2)<>'CU'  and right(left(account_code,4),2)<>'PA'  order by group_name,sub_group_name,account_head_name"
            ElseIf radiogrp.Checked = True Then
                sql = "select * from " & GMod.ACC_HEAD & "  where cmp_id='" & GMod.Cmpid & "' and right(left(account_code,4),2)='" & cmbgroupsuffix.Text & "'  order by group_name,sub_group_name,account_head_name"
            Else
                sql = "select * from " & GMod.ACC_HEAD & "  where cmp_id='" & GMod.Cmpid & "' and right(left(account_code,4),2)='" & cmbgroupsuffix.Text & "' and sub_group_name ='" & cmbsubgrpname.Text & "' order by group_name,sub_group_name,account_head_name"
            End If
        Else
            If radioall.Checked Then
                sql = "select * from " & GMod.ACC_HEAD & "  where cmp_id='" & GMod.Cmpid & "' and right(left(account_code,4),2)<>'CU'  and right(left(account_code,4),2)<>'PA'  and account_head_name like '%" & a & "%' order by group_name,sub_group_name,account_head_name"
            ElseIf radiogrp.Checked = True Then
                sql = "select * from " & GMod.ACC_HEAD & "  where cmp_id='" & GMod.Cmpid & "' and right(left(account_code,4),2)='" & cmbgroupsuffix.Text & "'  and account_head_name like '%" & a & "%' order by group_name,sub_group_name,account_head_name"
            Else
                sql = "select * from " & GMod.ACC_HEAD & "  where cmp_id='" & GMod.Cmpid & "' and right(left(account_code,4),2)='" & cmbgroupsuffix.Text & "'  and account_head_name like '%" & a & "%'  and sub_group_name = '" & cmbsubgrpname.Text & "' order by group_name,sub_group_name,account_head_name"
            End If
        End If



        

        GMod.DataSetRet(sql, "acc")
        dgaccounthead.Rows.Clear()
        For i = 0 To GMod.ds.Tables("acc").Rows.Count - 1
            dgaccounthead.Rows.Add()
            dgaccounthead(0, i).Value = GMod.ds.Tables("acc").Rows(i)("account_code")
            dgaccounthead(1, i).Value = GMod.ds.Tables("acc").Rows(i)("account_head_name")
            dgaccounthead(2, i).Value = GMod.ds.Tables("acc").Rows(i)("group_name")
            dgaccounthead(3, i).Value = GMod.ds.Tables("acc").Rows(i)("sub_group_name")
            dgaccounthead(4, i).Value = GMod.ds.Tables("acc").Rows(i)("opening_dr")
            dgaccounthead(5, i).Value = GMod.ds.Tables("acc").Rows(i)("opening_cr")
        Next

    End Sub

    Private Sub radioall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioall.CheckedChanged
        fillgrid("")
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        fillgrid(txtsearch.Text)
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        If txtacheadname.Text = "N.E.C.C FARMER CONTRIBUTION" Or txtacheadname.Text = "DISCOUNT AMOUNT" Then
            Exit Sub
        End If
        txtacheadname.Focus()
        Dim accode As String
        'MsgBox(GMod.SqlConn.State.ToString)
        Dim updateventery, upPrintdata As String
        Dim sqltrans As SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction
        Try

            If btnsave.Enabled Then
                'accode = InputBox("Please type account head code", GMod.Cmpname)
                'showdata(accode)
            Else
                If Trim(txtacheadname.Text) = "" Then
                    MsgBox("Please enter account head / Ledger Name", MsgBoxStyle.Critical, GMod.Cmpname)
                    txtacheadname.Focus()
                    Exit Sub
                End If
                If cmbdrcr.Text = "Dr" Then
                    sql = "update " & GMod.ACC_HEAD & " set account_head_name='" & txtacheadname.Text.ToUpper & "', sub_group_name='" & cmbsubgrpname.Text.ToUpper & "',opening_dr=" & txtamt.Text _
                    & ",opening_cr=0" & ", Area_code='" & cmbAreaCode.Text & "',Group_name ='" & cmbgrpname.Text & "', account_code = '" & lblacheadcode.Text & "' where account_code='" & code & "'"
                Else
                    sql = "update " & GMod.ACC_HEAD & " set account_head_name='" & txtacheadname.Text & "', sub_group_name='" & cmbsubgrpname.Text _
                    & "',opening_dr=0,opening_cr=" & txtamt.Text & ",Group_name = '" & cmbgrpname.Text & "', account_code = '" & lblacheadcode.Text & "'  where account_code='" & code & "'"
                End If
                'GMod.SqlExecuteNonQuery(sql)

                Dim cmd1 As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                cmd1.ExecuteNonQuery()
                'MsgBox(sql)
                updateventery = " update " & GMod.VENTRY & ""
                updateventery &= " set Acc_head_code ='" & lblacheadcode.Text & "',"
                updateventery &= " Acc_head='" & txtacheadname.Text & "',"
                updateventery &= " Group_name='" & cmbgrpname.Text & "',"
                updateventery &= " Sub_group_name='" & cmbsubgrpname.Text & "'"
                updateventery &= " where Acc_head_code ='" & code & "'"

                'GMod.SqlExecuteNonQuery(updateventery)
                Dim cmd2 As New SqlCommand(updateventery, GMod.SqlConn, sqltrans)
                cmd2.ExecuteNonQuery()

                If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "PHOE" Or GMod.Cmpid = "JAHA" Or GMod.Cmpid = "PHPO" Then
                    'Updatin in PrintDataTAbe
                    upPrintdata = "update PrintData set AccName='" & txtacheadname.Text & "' , AccCode='" & lblacheadcode.Text & "' where  AccCode='" & code & "' and Cmp_id = '" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    'GMod.SqlExecuteNonQuery(upPrintdata)
                    Dim cmd3 As New SqlCommand(upPrintdata, GMod.SqlConn, sqltrans)
                    cmd3.ExecuteNonQuery()

                ElseIf GMod.Cmpid = "PHCH" Then
                    Dim UpChi As String
                    UpChi = "update InvPhxChicken set Acc_head='" & txtacheadname.Text & "' , Acc_head_code='" & lblacheadcode.Text & "' where  Acc_head_code='" & code & "' and Cmp_id = '" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    'GMod.SqlExecuteNonQuery(UpChi)
                    Dim cmd4 As New SqlCommand(UpChi, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                Else
                    'Dim UpInv As String
                    'UpInv = "update " & GMod.INVENTORY & ""
                    'UpInv &= " set Acc_head_code ='" & lblacheadcode.Text & "',"
                    'UpInv &= " Acc_head='" & txtacheadname.Text & "'"
                    'UpInv &= " where Acc_head_code ='" & dgaccounthead(0, dgaccounthead.CurrentCell.RowIndex).Value & "'"
                    'GMod.SqlExecuteNonQuery(UpInv)
                    'GMod.SqlExecuteNonQuery(sql)

                    'Dim cmd5 As New SqlCommand(UpInv, GMod.SqlConn, sqltrans)
                    'cmd5.ExecuteNonQuery()
                End If
                sqltrans.Commit()
                Fill_Log_Head(GMod.Cmpid, lblacheadcode.Text, txtacheadname.Text, Now, GMod.Session, "M", GMod.username)
                btnreset_Click(sender, e)
            End If
        Catch ex As Exception
            sqltrans.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub showdata(ByVal ano As String)
        btnsave.Enabled = False
        btnmodify.Text = "&Update"
        GMod.DataSetRet("select * from " & GMod.ACC_HEAD & " where account_code='" & ano & "'", "ser")
        If GMod.ds.Tables("ser").Rows.Count > 0 Then

            'cmp_id,account_code,account_head_name,group_name,sub_group_name,account_type,opening_dr,opening_cr"
            txtacheadname.Text = GMod.ds.Tables("ser").Rows(0)("account_head_name")
            cmbgrpname.Text = GMod.ds.Tables("ser").Rows(0)("group_name")
            cmbsubgrpname.Text = GMod.ds.Tables("ser").Rows(0)("sub_group_name")
            cmbAreaCode.Text = GMod.ds.Tables("ser").Rows(0)("account_code").ToString.Substring(0, 2)

            If GMod.ds.Tables("ser").Rows(0)("opening_dr") > 0 Then
                cmbdrcr.Text = "Dr"
                txtamt.Text = GMod.ds.Tables("ser").Rows(0)("opening_dr")
            Else
                cmbdrcr.Text = "Cr"
                txtamt.Text = GMod.ds.Tables("ser").Rows(0)("opening_cr")
            End If
            lblacheadcode.Text = GMod.ds.Tables("ser").Rows(0)("account_code")

            'cmbgrpname.Enabled = False
            'cmbAreaCode.Enabled = False
            'cmbgroupsuffix.Enabled = False
            'cmbAreaName.Enabled =False 

        Else
            MsgBox("Invalid Account Code", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub dgaccounthead_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgaccounthead.CellContentClick

    End Sub
    Private Sub radiogrp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiogrp.CheckedChanged

    End Sub
    Dim r As Integer, code As String
    Private Sub dgaccounthead_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgaccounthead.DoubleClick


        txtacheadname.Focus()
        r = dgaccounthead.CurrentRow.Index
        code = dgaccounthead(0, r).Value
        showdata(dgaccounthead(0, r).Value)
        If GMod.role = "ADMIN" Then

        Else
            cmbAreaCode.Enabled = False
            cmbAreaName.Enabled = False
            cmbgroupsuffix.Enabled = False
            cmbgrpname.Enabled = False
        End If

    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim accode As String
        If btnsave.Enabled Then
            accode = InputBox("Please type account head code", GMod.Cmpname)
            showdata(accode)
        Else
            If vbYes = MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GMod.Cmpname) Then
                GMod.DataSetRet("select * from " & GMod.VENTRY & " where cmp_id='" & GMod.Cmpid & "' and Acc_head_code='" & lblacheadcode.Text & "'", "ser")
                If GMod.ds.Tables("ser").Rows.Count > 0 Then
                    MsgBox("Account Head can not deleted. Voucher Entries Exists", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    Fill_Log_Head(GMod.Cmpid, lblacheadcode.Text, txtacheadname.Text, Now, GMod.Session, "D", GMod.username)
                    sql = "delete from " & GMod.ACC_HEAD & " where account_code='" & lblacheadcode.Text & "'"
                    GMod.SqlExecuteNonQuery(sql)
                End If
            End If
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub cmbgroupsuffix_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgroupsuffix.SelectedIndexChanged
        nxtid()
    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbAreaCode.Focus()
        End If
    End Sub

    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        nxtid()
    End Sub

    Private Sub cmbAreaCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaCode.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtamt.Focus()
        End If
    End Sub

    Private Sub cmbgroupsuffix_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgroupsuffix.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbsubgrpname.Focus()
        End If
    End Sub

    Private Sub cmbgrpname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgrpname.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbgroupsuffix.Focus()
        End If
    End Sub

    Private Sub cmbsubgrpname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsubgrpname.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbAreaName.Focus()
        End If
    End Sub

    Private Sub txtacheadname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtacheadname.KeyUp
        If e.KeyCode = Keys.Enter Then
            If cmbgrpname.Enabled = True Then
                cmbgrpname.Focus()
            Else
                txtamt.Focus()
            End If
        End If
    End Sub

    Private Sub txtamt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamt.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbdrcr.Focus()
        End If
    End Sub

    Private Sub cmbdrcr_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdrcr.KeyUp
        If e.KeyCode = Keys.Enter Then
            If btnsave.Enabled = True Then
                btnsave.Focus()
            Else
                btnmodify.Focus()
            End If
        End If
    End Sub

    Private Sub cmbAreaName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.SelectedIndexChanged
        If GMod.role = "ADMIN" Then
            nxtid()
        End If
    End Sub

    Private Sub txtacheadname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtacheadname.Leave

    End Sub

    Private Sub txtacheadname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtacheadname.TextChanged
        'If btnsave.Enabled = True Then
        fillgrid(txtacheadname.Text)
        'End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnExpCode_Click(sender As Object, e As EventArgs) Handles btnExpCode.Click
        Dim sql As String
        sql = "update " & GMod.ACC_HEAD & " set remark3 = '" & cmbExpCode.Text & "'  where account_code='" & code & "'"
        MsgBox(GMod.SqlExecuteNonQuery(sql))

    End Sub
End Class