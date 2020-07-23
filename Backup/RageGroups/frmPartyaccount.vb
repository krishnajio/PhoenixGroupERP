Imports System.IO
Imports System.Data.SqlClient
Public Class frmPartyaccount
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmPartyaccount_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub
    Private Sub frmPartyaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmbAreaName.Focus()
        'Creating Code 
        'If GMod.Cmpid.Substring(0, 2).ToUpper() = "RA" Then
        '    Label1.Text = "Party Account Head"
        '    lblgroupname.Text = "PARTY"
        '    cmbAreaCode.Visible = False
        '    cmbAreaName.Visible = False
        'Else
        '    Label1.Text = "Customer Account Head"
        '    lblgroupname.Text = "CUSTOMER"
        '    cmbAreaCode.Visible = True
        '    cmbAreaName.Visible = True
        'End If
        Try
            GMod.DataSetRet("select sub_group_name from sub_group where group_name='" & lblgroupname.Text & "' and cmp_id='" & GMod.Cmpid & "'", "subg")
            cmbsubgrpname.DataSource = GMod.ds.Tables("subg")
            cmbsubgrpname.DisplayMember = "sub_group_name"
            GMod.DataSetRet("select rule_id,description from interest_rules where cmp_id='" & GMod.Cmpid & "'", "int")
            cmbintrule.DataSource = GMod.ds.Tables("int")
            cmbintrule.DisplayMember = "description"
            cmbintruleid.DataSource = GMod.ds.Tables("int")
            cmbintruleid.DisplayMember = "rule_id"
            fillArea()
            cmbAreaCode.Text = "**"
            nxtid()
            fillgrid("")
            'getsuffix()
        Catch ex As Exception

        End Try

        If tdsflag = True Then
            filltdsparty()
            showdata(tdsdcode)
            btnsave.Enabled = False
            btnmodify.Enabled = False
        End If
        txtacheadname.Focus()
    End Sub
    Private Sub getsuffix()
        Dim sqlsuffix As String
        sqlsuffix = "select  Suffix from dbo.Groups where Group_name='" & lblgroupname.Text & "' and Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlsuffix, "Suffixz")
        lblgroupsuffix.Text = GMod.ds.Tables("Suffixz").Rows(0)(0).ToString()
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area order by Areaname"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
    End Sub

    Dim s, sql As String
    Sub nxtid()
        Try
            ' On Error Resume Next
            GMod.DataSetRet("select isnull(max(right(account_code,4))+1,1) from " & GMod.ACC_HEAD & " where left(account_code,2)='" & cmbAreaCode.Text & "' and group_name='" & lblgroupname.Text & "'", "nxt")
            If GMod.ds.Tables("nxt").Rows.Count > 0 Then lblacheadcode.Text = cmbAreaCode.Text & lblgroupsuffix.Text & Format(GMod.ds.Tables("nxt").Rows(0)(0), "0000")
        Catch ex As Exception
        End Try
    End Sub
    Sub fillgrid(ByVal a As String)
        Dim i As Integer
        If a = "" Then
            sql = "select * from " & GMod.ACC_HEAD & "   where group_name='" & lblgroupname.Text & "' and cmp_id='" & GMod.Cmpid & "' and Area_code='" & cmbAreaCode.Text & "' order by account_head_name,group_name,sub_group_name "
        Else
            sql = "select * from " & GMod.ACC_HEAD & "  where cmp_id='" & GMod.Cmpid & "' and account_head_name like '%" & a & "%' and group_name='" & lblgroupname.Text & "' and Area_code='" & cmbAreaCode.Text & "' order by  account_head_name,group_name,sub_group_name"
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
            dgaccounthead(6, i).Value = GMod.ds.Tables("acc").Rows(i)("credit_limit")
            dgaccounthead(7, i).Value = GMod.ds.Tables("acc").Rows(i)("credit_days")
            dgaccounthead(8, i).Value = GMod.ds.Tables("acc").Rows(i)("interest_rule_id")
            dgaccounthead(9, i).Value = GMod.ds.Tables("acc").Rows(i)("rate_of_interest")
            dgaccounthead(10, i).Value = GMod.ds.Tables("acc").Rows(i)("remark3")
        Next
    End Sub
    Sub filltdsparty()

        Dim i As Integer
        sql = "select * from " & GMod.ACC_HEAD & "   where  cmp_id='" & GMod.Cmpid & "' and  account_code='" & tdsdcode & "'"
     
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
            dgaccounthead(6, i).Value = GMod.ds.Tables("acc").Rows(i)("credit_limit")
            dgaccounthead(7, i).Value = GMod.ds.Tables("acc").Rows(i)("credit_days")
            dgaccounthead(8, i).Value = GMod.ds.Tables("acc").Rows(i)("interest_rule_id")
            dgaccounthead(9, i).Value = GMod.ds.Tables("acc").Rows(i)("rate_of_interest")
            dgaccounthead(10, i).Value = GMod.ds.Tables("acc").Rows(i)("remark3")
        Next
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MessageBox.Show("Are U sure", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If Trim(txtacheadname.Text) = "" Then
                MsgBox("Please enter account head / Ledger Name", MsgBoxStyle.Critical, GMod.Cmpname)
                txtacheadname.Focus()
                Exit Sub
            End If
            If cmbdrcr.Text = "Dr" Then
                sql = "insert into " & GMod.ACC_HEAD & "(cmp_id,account_code,account_head_name,group_name,sub_group_name,"
                sql += "account_type,opening_dr,opening_cr,credit_days,credit_limit,address,city,state,phone,pan_no,rate_of_interest,interest_rule_id,remark1,remark2,Area_code,remark3)"
                sql += " values('" & GMod.Cmpid & "','" & lblacheadcode.Text & "',"
                sql += "'" & txtacheadname.Text.ToUpper.Trim & "','" & lblgroupname.Text & "','" & cmbsubgrpname.Text & "','P',"
                sql += Val(txtamt.Text) & ",0,'" & txtcrdays.Text.ToString & "','" & txtcrlimit.Text.ToString & "','" & txtaddress.Text & "',"
                sql += "'" & txtcity.Text & "','" & txtstate.Text & "','" & txtphno.Text & "','" & txtpanno.Text & "'," & Val(txtintrate.Text) & ",'"
                sql += GMod.username & "','" & txtremark1.Text & "','" & txtremark2.Text & "','" & cmbAreaCode.Text & "','" & txtinttype.Text & "')"
            Else
                sql = "insert into " & GMod.ACC_HEAD & "(cmp_id,account_code,account_head_name,group_name,sub_group_name,"
                sql += "account_type,opening_Cr,opening_Dr,credit_days,credit_limit,address,city,state,phone,pan_no,rate_of_interest,interest_rule_id,remark1,remark2,Area_code,remark3)"
                sql += " values('" & GMod.Cmpid & "','" & lblacheadcode.Text & "',"
                sql += "'" & txtacheadname.Text.ToUpper.Trim & "','" & lblgroupname.Text & "','" & cmbsubgrpname.Text & "','P',"
                sql += Val(txtamt.Text) & ",0,'" & txtcrdays.Text.ToString & "','" & txtcrlimit.Text.ToString & "','" & txtaddress.Text & "',"
                sql += "'" & txtcity.Text & "','" & txtstate.Text & "','" & txtphno.Text & "','" & txtpanno.Text & "'," & Val(txtintrate.Text) & ",'"
                sql += GMod.username & "','" & txtremark1.Text & "','" & txtremark2.Text & "','" & cmbAreaCode.Text & "','" & txtinttype.Text & "')"
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
                    sql += "account_type,opening_dr,opening_cr,credit_days,credit_limit,address,city,state,phone,pan_no,rate_of_interest,interest_rule_id,remark1,remark2,Area_code,remark3) "
                    sql += " values('" & GMod.Cmpid & "','" & lblacheadcode.Text & "',"
                    sql += "'" & txtacheadname.Text.ToUpper & "','" & lblgroupname.Text & "','" & cmbsubgrpname.Text & "','P'," & dr & ","
                    sql += cr & "," & Val(txtcrdays.Text) & "," & Val(txtcrlimit.Text) & ",'" & txtaddress.Text & "',"
                    sql += "'" & txtcity.Text & "','" & txtstate.Text & "','" & txtphno.Text & "','" & txtpanno.Text & "'," & Val(txtintrate.Text) & ","
                    sql += Val(cmbintruleid.Text) & ",'" & txtremark1.Text & "','" & txtremark2.Text & "','" & cmbAreaCode.Text & "','" & txtinttype.Text & "')"
                    GMod.SqlExecuteNonQuery(sql)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtacheadname.Text = "-"
        txtaddress.Text = "-"
        txtcity.Text = "-"
        txtstate.Text = "-"
        txtphno.Text = "-"
        txtpanno.Text = "-"
        txtamt.Text = ""
        txtcrdays.Text = ""
        txtcrlimit.Text = ""
        txtremark1.Text = ""
        txtremark2.Text = ""
        'btnsave.Enabled = True
        btnmodify.Text = "&Modify"
        nxtid()
        fillgrid("")
        cmbAreaCode.Enabled = True
        cmbAreaName.Enabled = True
        lblgroupname.Enabled = True
        lblgroupsuffix.Enabled = True
        txtacheadname.Focus()
    End Sub
    Sub showdata(ByVal ano As String)
        GMod.DataSetRet("select * from " & GMod.ACC_HEAD & " where account_code='" & ano & "'", "ser")
        If GMod.ds.Tables("ser").Rows.Count > 0 Then
            cmbAreaCode.Text = ano.Substring(0, 2)
            lblacheadcode.Text = ano.ToString
            'cmp_id,account_code,account_head_name,group_name,sub_group_name,account_type,opening_dr,opening_cr"
            txtacheadname.Text = GMod.ds.Tables("ser").Rows(0)("account_head_name")
            cmbsubgrpname.Text = GMod.ds.Tables("ser").Rows(0)("sub_group_name")
            If GMod.ds.Tables("ser").Rows(0)("opening_dr") > 0 Then
                cmbdrcr.Text = "Dr"
                txtamt.Text = GMod.ds.Tables("ser").Rows(0)("opening_dr")
            Else
                cmbdrcr.Text = "Cr"
                txtamt.Text = GMod.ds.Tables("ser").Rows(0)("opening_cr")
            End If
            txtcrdays.Text = GMod.ds.Tables("ser").Rows(0)("credit_days")
            txtcrlimit.Text = GMod.ds.Tables("ser").Rows(0)("credit_limit")
            cmbintruleid.Text = GMod.ds.Tables("ser").Rows(0)("interest_rule_id")
            txtintrate.Text = GMod.ds.Tables("ser").Rows(0)("rate_of_interest")
            txtaddress.Text = GMod.ds.Tables("ser").Rows(0)("address")
            txtcity.Text = GMod.ds.Tables("ser").Rows(0)("city")
            txtstate.Text = GMod.ds.Tables("ser").Rows(0)("state")
            txtphno.Text = GMod.ds.Tables("ser").Rows(0)("phone")
            txtpanno.Text = GMod.ds.Tables("ser").Rows(0)("pan_no")
            txtremark1.Text = GMod.ds.Tables("ser").Rows(0)("remark1")
            txtremark2.Text = GMod.ds.Tables("ser").Rows(0)("remark2")
            txtinttype.Text = GMod.ds.Tables("ser").Rows(0)("remark3")
            btnsave.Enabled = False
            btnmodify.Text = "&Update"
        Else
            MsgBox("Invalid Account Code", MsgBoxStyle.Critical, "Error")
            btnsave.Enabled = True
        End If
    End Sub

    Dim code As String
    Private Sub dgaccounthead_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgaccounthead.DoubleClick
        Dim r As Integer
        btnsave.Enabled = False
        r = dgaccounthead.CurrentRow.Index
        code = dgaccounthead(0, r).Value
        showdata(dgaccounthead(0, r).Value)
        If GMod.role = "ADMIN" Then

        Else
            cmbAreaCode.Enabled = False
            cmbAreaName.Enabled = False
            lblgroupname.Enabled = False
            lblgroupsuffix.Enabled = False
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        Dim sqltrans As SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction
        Try
            Dim cr, dr As Double
            Dim accode As String, upPrintdata As String
            If btnsave.Enabled Then
                'accode = InputBox("Please type account head code", GMod.Cmpname)
                'showdata(accode)
                'btnsave.Enabled = False
            End If
            If Trim(txtacheadname.Text) = "" Then
                MsgBox("Please enter account head / Ledger Name", MsgBoxStyle.Critical, GMod.Cmpname)
                txtacheadname.Focus()
                Exit Sub
            End If
            If cmbdrcr.Text = "Dr" Then
                dr = Val(txtamt.Text)
                cr = 0
            Else
                dr = 0
                cr = Val(txtamt.Text)
            End If
            sql = " update " & GMod.ACC_HEAD & " set  group_name='" & lblgroupname.Text & "', sub_group_name='" & cmbsubgrpname.Text & "',opening_dr=" & dr & ","
            sql += " opening_cr=" & cr & ",credit_days='" & txtcrdays.Text.ToString & "',credit_limit='" & txtcrlimit.Text.ToString & "',address='" & txtaddress.Text & "',"
            sql += " city='" & txtcity.Text & "',state='" & txtstate.Text & "',phone='" & txtphno.Text & "',pan_no='" & txtpanno.Text & "',"
            sql += " rate_of_interest='" & txtintrate.Text.ToString & "',interest_rule_id=" & Val(cmbintruleid.Text) & ",remark1='" & txtremark1.Text & "',remark2='" & txtremark2.Text & "', Area_code='" & cmbAreaCode.Text & "',remark3='" & txtinttype.Text & "',"
            sql += "  account_code='" & lblacheadcode.Text & "',"
            sql += " account_head_name='" & txtacheadname.Text.ToUpper & "'  where account_code='" & code & "'"

            Dim sqlres As String, updateventery As String
            'sqlres = GMod.SqlExecuteNonQuery(sql)

            Dim cmd1 As New SqlCommand(sql, GMod.SqlConn, sqltrans)
            cmd1.ExecuteNonQuery()


            'If sqlres = "SUCCESS" Then
            updateventery = " update " & GMod.VENTRY & " "
            ' updateventery &= " set Acc_head_code ='" & lblacheadcode.Text & "',"
            updateventery &= " set Acc_head='" & txtacheadname.Text & "',"
            updateventery &= " Group_name='" & lblgroupname.Text & "',"
            updateventery &= " Sub_group_name='" & cmbsubgrpname.Text & "'"
            updateventery &= " where Acc_head_code ='" & code & "'"
            'sqlres = GMod.SqlExecuteNonQuery(updateventery)

            Dim cmd2 As New SqlCommand(updateventery, GMod.SqlConn, sqltrans)
            cmd2.ExecuteNonQuery()

            'upPrintdata = "update PrintData set AccName='" & txtacheadname.Text & "' , AccCode='" & lblacheadcode.Text & "' where  AccCode='" & code & "' and Cmp_id = '" & GMod.Cmpid & "' and session='" & GMod.Getsession(DateAndTime.Now) & "'"
            'sqlres = GMod.SqlExecuteNonQuery(upPrintdata)

            'Dim UpChi As String
            'UpChi = "update InvPhxChicken set Acc_head='" & txtacheadname.Text & "' , Acc_head_code='" & lblacheadcode.Text & "' where  Acc_head_code='" & code & "' and Cmp_id = '" & GMod.Cmpid & "' and session='" & GMod.Getsession(DateAndTime.Now) & "'"
            'sqlres = GMod.SqlExecuteNonQuery(UpChi)

            'Dim UpInv As String
            'UpInv = "update " & GMod.INVENTORY & ""
            'UpInv &= " set Acc_head_code ='" & lblacheadcode.Text & "',"
            'UpInv &= " Acc_head='" & txtacheadname.Text & "',"
            'UpInv &= " where Acc_head_code ='" & code & "'"
            'sqlres = GMod.SqlExecuteNonQuery(UpInv)

            If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "PHOE" Or GMod.Cmpid = "JAHA" Or GMod.Cmpid = "PHPO" Then
                'Updatin in PrintDataTAbe
                upPrintdata = "update PrintData set AccName='" & txtacheadname.Text & "' where  AccCode='" & code & "' and Cmp_id = '" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                'sqlres = GMod.SqlExecuteNonQuery(upPrintdata)
                'MsgBox(sqlres)
                Dim cmd3 As New SqlCommand(upPrintdata, GMod.SqlConn, sqltrans)
                cmd3.ExecuteNonQuery()

            ElseIf GMod.Cmpid = "PHCH" Then
                Dim UpChi As String
                UpChi = "update InvPhxChicken set Acc_head='" & txtacheadname.Text & "'  where  Acc_head_code='" & code & "' and Cmp_id = '" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                'sqlres = GMod.SqlExecuteNonQuery(UpChi)
                Dim cmd4 As New SqlCommand(UpChi, GMod.SqlConn, sqltrans)
                cmd4.ExecuteNonQuery()
            Else
                Dim UpInv As String
                UpInv = "update " & GMod.INVENTORY & ""
                ' UpInv &= " set Acc_head_code ='" & lblacheadcode.Text & "',"
                UpInv &= " Acc_head='" & txtacheadname.Text & "'"
                UpInv &= " where Acc_head_code ='" & code & "'"
                'sqlres = GMod.SqlExecuteNonQuery(UpInv)
                'Dim cmd4 As New SqlCommand(UpInv, GMod.SqlConn, sqltrans)
                'cmd4.ExecuteNonQuery()
            End If
            sqltrans.Commit()
            Fill_Log_Head(GMod.Cmpid, lblacheadcode.Text, txtacheadname.Text, Now, GMod.Session, "M", GMod.username)
            MsgBox("Party/Customer Information updated", MsgBoxStyle.Information)
            btnreset_Click(sender, e)

            'Else
            'MsgBox("Error:" & sqlres)
            'End If
        Catch ex As Exception
            sqltrans.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        'fillgrid(txtsearch.Text)
        Try
            Dim i As Integer
            sql = "select * from " & GMod.ACC_HEAD & "  where cmp_id='" & GMod.Cmpid & "' and account_head_name like '%" & txtsearch.Text & "%' and group_name='" & lblgroupname.Text & "' order by  account_head_name,group_name,sub_group_name"
            GMod.DataSetRet(sql, "accser")
            dgaccounthead.Rows.Clear()
            For i = 0 To GMod.ds.Tables("accser").Rows.Count - 1
                dgaccounthead.Rows.Add()
                dgaccounthead(0, i).Value = GMod.ds.Tables("accser").Rows(i)("account_code")
                dgaccounthead(1, i).Value = GMod.ds.Tables("accser").Rows(i)("account_head_name")
                dgaccounthead(2, i).Value = GMod.ds.Tables("accser").Rows(i)("group_name")
                dgaccounthead(3, i).Value = GMod.ds.Tables("accser").Rows(i)("sub_group_name")
                dgaccounthead(4, i).Value = GMod.ds.Tables("accser").Rows(i)("opening_dr")
                dgaccounthead(5, i).Value = GMod.ds.Tables("accser").Rows(i)("opening_cr")
                dgaccounthead(6, i).Value = GMod.ds.Tables("accser").Rows(i)("credit_limit")
                dgaccounthead(7, i).Value = GMod.ds.Tables("accser").Rows(i)("credit_days")
                dgaccounthead(8, i).Value = GMod.ds.Tables("accser").Rows(i)("interest_rule_id")
                dgaccounthead(9, i).Value = GMod.ds.Tables("accser").Rows(i)("rate_of_interest")
                dgaccounthead(10, i).Value = GMod.ds.Tables("accser").Rows(i)("remark3")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                    'Filling Log INformation
                    Fill_Log_Head(GMod.Cmpid, lblacheadcode.Text, txtacheadname.Text, Now, GMod.Session, "D", GMod.username)
                    sql = "delete from " & GMod.ACC_HEAD & " where account_code='" & lblacheadcode.Text & "'"
                    GMod.SqlExecuteNonQuery(sql)
                End If
            End If
            btnreset_Click(sender, e)
        End If
    End Sub
    Private Sub cmbAreaCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbAreaCode.Focus()
        End If
    End Sub
    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged

        nxtid()

        fillgrid("")
    End Sub
    Private Sub cmbAreaName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbAreaCode.Focus()
        End If
    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp

    End Sub

    Private Sub cmbAreaCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaCode.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbsubgrpname.Focus()
        End If
    End Sub

    Private Sub cmbsubgrpname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsubgrpname.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtacheadname.Focus()
        End If
    End Sub

    Private Sub txtacheadname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtacheadname.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtamt.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbAreaName.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtamt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamt.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbdrcr.Focus()
        End If
    End Sub

    Private Sub cmbdrcr_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdrcr.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtcrlimit.Focus()
        End If
    End Sub

    Private Sub txtcrlimit_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcrlimit.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtcrdays.Focus()
        End If
    End Sub

    Private Sub txtcrdays_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcrdays.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbintrule.Focus()
        End If
    End Sub

    Private Sub cmbintrule_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbintrule.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtintrate.Focus()
        End If
    End Sub

    Private Sub txtintrate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtintrate.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtaddress_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress.Enter
        txtaddress.SelectAll()
    End Sub

    Private Sub txtaddress_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddress.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtcity.Focus()
        End If
    End Sub

    Private Sub txtcity_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcity.Enter
        txtcity.SelectAll()
    End Sub

    Private Sub txtcity_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcity.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtstate.Focus()
        End If
    End Sub

    Private Sub txtstate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstate.Enter
        txtstate.SelectAll()
    End Sub

    Private Sub txtstate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstate.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtphno.Focus()
        End If
    End Sub

    Private Sub txtphno_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphno.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtpanno.Focus()
        End If
    End Sub

    Private Sub txtpanno_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpanno.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtremark1.Focus()
        End If
    End Sub

    Private Sub txtremark1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtremark2.Focus()
        End If
    End Sub

    Private Sub txtremark2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtremark2.KeyUp
        If e.KeyCode = Keys.Enter Then
            If btnsave.Enabled = True Then
                btnsave.Focus()
            Else
                btnmodify.Focus()
            End If
        End If
    End Sub

    Private Sub cmbAreaName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.Leave
        If cmbAreaName.FindStringExact(cmbAreaName.Text) = -1 Then
            MsgBox("Invalid Area Code", MsgBoxStyle.Critical)
            cmbAreaName.Focus()
        End If
        fillgrid("")
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinttype.TextChanged

    End Sub

    Private Sub cmbintruleid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbintruleid.KeyDown
        If e.KeyCode = Keys.Enter Then cmbAreaCode.Focus()
    End Sub

    Private Sub cmbintruleid_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbintruleid.SelectedIndexChanged
        GMod.DataSetRet("select isnull(rateofint,0),int_type from interest_rules where rule_id=" & Val(cmbintruleid.Text), "rat")
        If GMod.ds.Tables("rat").Rows.Count > 0 Then
            txtintrate.Text = GMod.ds.Tables("rat").Rows(0)(0)
            txtinttype.Text = GMod.ds.Tables("rat").Rows(0)(1)
        End If
    End Sub

    Private Sub txtacheadname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtacheadname.TextChanged
        On Error Resume Next
        'If btnsave.Enabled = True Then
        fillgrid(txtacheadname.Text)
        'End If
    End Sub

    Private Sub lblgroupsuffix_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblgroupsuffix.Leave
        If GMod.role = "ADMIN" Then
            nxtid()
        End If
        fillgrid("")
    End Sub
    'For Dos Printing of Customer List 13,oct,2008
    Dim sw As StreamWriter
    Dim ln, pageno As Integer
    Dim gr As String
    Public Sub heads()
        pageno = pageno + 1
        Dim i As Integer
        sw.WriteLine("")
        Dim s As String
        For i = 0 To 30
            s = s + " "
        Next
        s = s & Convert.ToChar(14).ToString & GMod.Cmpname.ToUpper
        sw.WriteLine(s)
        s = ""
        For i = 0 To 30
            s = s + " "
        Next
        s = s & lblgroupname.Text
        sw.WriteLine(s)
        s = ""

        s = "    GROUP NAME :" & Convert.ToChar(20).ToString & " " & lblgroupname.Text
        'sw.WriteLine(s)
        For i = 0 To 41
            s = s + " "
        Next
        s = s + "Page No: " & pageno
        sw.WriteLine(s)
        s = ""
        'If chkArea.Checked = True Then
        s = "    AREA :" & " " & cmbAreaName.Text
        sw.WriteLine(s)
        'End If
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        s = ""
        sw.WriteLine("    A/c CODE               A/c NAME                                                               ")
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        ln = ln + 8
    End Sub
    'For Dos Printing of Customer List
    Private Sub btnDosprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDosprint.Click
        ln = 1
        sw = File.CreateText("c:\\curlist.txt")
        heads()
        Dim i As Integer
        For i = 0 To dgaccounthead.Rows.Count - 1
            s = "    " & dgaccounthead(0, i).Value.ToString & "               " & dgaccounthead(1, i).Value.ToString
            sw.WriteLine(s)
            sw.WriteLine("")
            s = ""
            ln = ln + 2
            If ln > 68 Then
                sw.WriteLine(Convert.ToChar(12).ToString)
                ln = 1
                'pageno = pageno + 1
                heads()
            End If
        Next
        sw.WriteLine(Convert.ToChar(12).ToString)
        'sw.Close()
        'Dim p As New Process
        'p.StartInfo.FileName = "curlist.bat"
        'p.Start()
        'sw.Close()
        sw.Close()
        Dim p As New Process
        p.StartInfo.FileName = "printfile.bat"
        p.StartInfo.Arguments = "c:\curlist.txt"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.Start()
        p.Close()
    End Sub

    Private Sub lblgroupsuffix_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblgroupsuffix.SelectedIndexChanged

    End Sub
End Class