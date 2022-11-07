Imports System.Data.SqlClient
Public Class frmVentry
    Dim frmnarrationlistobj As New frmNarrationEntrybox
    Dim flag As Boolean = False
    Private Sub frmVentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Checking for user Entrtry Permission
        If GMod.PerviousSession = True Then
            GMod.DataSetRet("select entry_status from SessionMaster where Uname ='" & GMod.username & "' and session ='" & GMod.Session & "'", "entry_status")
            GMod.EntryStatus = CInt(GMod.ds.Tables("entry_status").Rows(0)(0))
            If GMod.EntryStatus = 1 Then
            Else
                MessageBox.Show("Permission denied", "Permision denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Else
        End If
        'Setting voucher date accrding to session
        dtVdate.Value = GMod.SessionCurrentDate
        dtVdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtVdate.MaxDate = GMod.SessionCurrentDate

        
        ' MsgBox(GMod.Session)
          Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        dgvoucher.Rows.Add()
        Dim sql As String
        If cmbvtype.Text = "PAYMENT" Then ' For voucher type payment
            ' MsgBox(cmbvtype.Text)
            lblDrCr.Text = "Cr"
            Me.drcr.Items.Add("Dr") 'for data grid 
            Label7.Visible = False 'disabling for showing sum
            lblcrsum.Visible = False

            sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and  group_name in (" _
                   & " select Group_name from Groups where effectsin like '%PAYMENT%' " _
                   & " or effectsin like '%All%' and cmp_id='" & GMod.Cmpid & "' ) "
            GMod.DataSetRet(sql, "aclist1")

        ElseIf cmbvtype.Text = "RECEIPT" Then ' For voucher type Recepit
            lblDrCr.Text = "Dr"
            Me.drcr.Items.Add("Cr") 'for data grid 
            Label6.Visible = False 'disabling for showing sum
            lbldrsum.Visible = False
            sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and  group_name in (" _
                              & " select Group_name from Groups where effectsin like '%RECEIPT%' " _
                              & " or effectsin like '%All%' and cmp_id='" & GMod.Cmpid & "' )"
            GMod.DataSetRet(sql, "aclist1")
        Else
            lblDrCr.Text = "-"
            Me.drcr.Items.Add("Dr") 'for data grid 
            Me.drcr.Items.Add("Cr") 'for data grid 
            sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "aclist1")
        End If
        cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadname.DisplayMember = "account_head_name"

        If cmbvtype.Enabled Then
            If cmbvtype.Enabled = False Then
                GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "'  AND SESSION = '" & GMod.Session & "' and vtype<>'OPEN'  order by seqorder", "vty")
            Else
                GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'  and vtype  NOT in ('PAYMENT','OPEN')  order by seqorder", "vty")
            End If
            cmbvtype.DataSource = GMod.ds.Tables("vty")
            cmbvtype.DisplayMember = "vtype"
            cmbacgroup.Enabled = False
            cmbacsubgroup.Enabled = False
            cmbacheadcode.Enabled = False
            cmbacheadname.Enabled = False
        End If
        ' nxtvno() 'Getting VCoucher nO
        If cmbvtype.Enabled = True Then
            cmbvtype.Focus()
        Else
            dtvdate.Focus()
        End If
       
    End Sub
    Public Sub SetLastVouDate()
        Dim sql As String
        sql = "select * from  LastVouDate"
        GMod.DataSetRet(sql, "LastVouDate")
        If GMod.ds.Tables("LastVouDate").Rows.Count > 0 Then
            sql = "update LastVouDate set last_vou_date='" & dtvdate.Value.ToShortDateString & "' where Uname='" & GMod.username & "'"
            GMod.SqlExecuteNonQuery(sql)
        Else
            sql = "insert into LastVouDate values('" & dtvdate.Value.ToShortDateString & "','" & GMod.username & "')"
            GMod.SqlExecuteNonQuery(sql)
        End If
        GMod.ds.Tables("LastVouDate").Clear()
    End Sub
    Public Sub GetLastVouDate()
        Dim sql As String
        sql = "select last_vou_date from LastVouDate where  Uname='" & GMod.username & "'"
        GMod.DataSetRet(sql, "LastVouDate")
        If GMod.ds.Tables("LastVouDate").Rows.Count > 0 Then
            dtvdate.Value = CDate(GMod.ds.Tables("LastVouDate").Rows(0)(0))
        End If
        GMod.ds.Tables("LastVouDate").Clear()
    End Sub
    Sub nxtvno()
        Try
            Dim sql As String
            Dim j As Integer
            Dim lastid As String = ""
            'If lblvouseq.Text = "1" Then
            '    sql = "SELECT vou_no FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "' and  day(vou_date)=" & dtvdate.Value.Day & " and month(vou_date)=" & dtvdate.Value.Month & " and year(vou_date)=" & dtvdate.Value.Year
            '    GMod.DataSetRet(sql, "vno")
            '    If ds.Tables("vno").Rows.Count > 0 Then
            '        For j = 0 To ds.Tables("vno").Rows.Count - 1
            '            lastid = ds.Tables("vno").Rows(j)("vou_no")
            '        Next
            '        lastid = Val(lastid) + 1
            '    Else
            '        lastid = dtvdate.Value.Year.ToString()
            '        If dtvdate.Value.Month.ToString().Length = 1 Then
            '            lastid = lastid & "0" & dtvdate.Value.Month.ToString()
            '        Else
            '            lastid = lastid & dtvdate.Value.Month.ToString()
            '        End If
            '        If dtvdate.Value.Day.ToString() = 1 Then
            '            lastid = lastid & "0" & dtvdate.Value.Day.ToString()
            '        Else
            '            lastid = lastid & dtvdate.Value.Day.ToString()
            '        End If
            '        lastid = lastid & Format(1, "0000")
            '    End If
            '    lblvouno.Text = lastid
            'End If
            'If lblvouseq.Text = "0" Then
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "'"
            GMod.DataSetRet(sql, "vno_seq")
            lblvouno.Text = ds.Tables("vno_seq").Rows(0)(0)
            ' End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Dim ach As New frmacheadlist

    Private Sub dgvoucher_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellDoubleClick

    End Sub
    Private Sub dgvoucher_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellEndEdit
        Try
            Dim st, h() As String
            If e.ColumnIndex = 1 Then
                If Len(dgvoucher(1, e.RowIndex).Value) = 0 Then
                    ach.ShowDialog()
                    st = ach.cmbacheadlist.Text
                    h = st.Split("[")
                    dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim()
                    h = h(1).Split("]")
                    dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim()
                    'ach.Dispose()
                    Exit Sub
                Else
                    Dim sqlacc As String
                    sqlacc = "select account_code from " & GMod.ACC_HEAD & " where account_code='" & dgvoucher(1, e.RowIndex).Value & "'"
                    GMod.DataSetRet(sqlacc, "Count")
                    If GMod.ds.Tables("Count").Rows.Count > 0 Then

                    Else
                        ach.ShowDialog()
                        st = ach.cmbacheadlist.Text
                        h = st.Split("[")
                        dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
                        h = h(1).Split("]")
                        dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
                        Exit Sub
                    End If
                    GMod.ds.Tables("Count").Clear()
                End If
            End If

            If e.ColumnIndex = 5 Then
                sumdrcr()
            End If
        Catch ex As Exception
            MsgBox("CELL END EDIT" & ex.Message)
            Application.Exit()
        End Try
    End Sub

    Dim pp As Integer
    Private Sub dgvoucher_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.RowEnter
        Dim r, pr As Integer
        r = e.RowIndex
        If r = 0 Then
            dgvoucher(0, r).Value = 1
        Else
            pr = r - 1
            dgvoucher(0, r).Value = dgvoucher(0, pr).Value + 1
        End If
        'sumdrcr()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
    Private Sub dgvoucher_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellLeave
        Dim s, drcr, st, h() As String
        Try
            s = dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value
            drcr = dgvoucher(6, dgvoucher.CurrentCell.RowIndex).Value
            If e.ColumnIndex = 1 And String.IsNullOrEmpty(s) Then
                ach.ShowDialog()
                st = ach.cmbacheadlist.Text.ToUpper
                h = st.Split("[")
                dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
                h = h(1).Split("]")
                dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper.Trim
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
        If e.ColumnIndex = 6 Then
            sumdrcr()
        End If

        'getting a/c code from acc head 
        Try
            s = "seelct  "
        Catch ex As Exception

        End Try
    End Sub
    Sub sumdrcr()
        Try
            Dim i As Integer
            Dim dramt, cramt As Double
            For i = 0 To dgvoucher.Rows.Count - 1
                If Len(dgvoucher(5, i).Value) > 0 Then
                    If dgvoucher(6, i).Value = "Dr" Then
                        dramt = dramt + dgvoucher(5, i).Value
                    ElseIf dgvoucher(6, i).Value = "Cr" Then
                        cramt = cramt + dgvoucher(5, i).Value
                    End If
                End If
            Next
            lbldrsum.Text = dramt
            lblcrsum.Text = cramt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function SingleEntry() As Boolean
        If CheckBox3.Checked = True And btnsave.Enabled = True Then
            'nxtvno()
        Else
            GMod.Fill_Log(GMod.Cmpid, lblvouno.Text, cmbvtype.Text, dtvdate.Value, Now, GMod.Session, "M", GMod.username)
        End If
        Dim i As Integer

        Dim sqltrans As SqlClient.SqlTransaction
        Dim sqldel, paymod, Group_name, Sub_group_name, SqlGrpsubgrp As String
        Dim varcr, vardr, eid, c, d As Double
        sqltrans = GMod.SqlConn.BeginTransaction
        d = -1
        c = 0
        'Genetate Voucher No at save time 
        nxtvno()
        Try
            Dim sqlsave As String = ""
            For i = 0 To dgvoucher.Rows.Count - 1
                If Len(dgvoucher(1, i).Value) <> 0 Then
                    If Len(dgvoucher(1, i).Value) > 0 Then 'check for account head code is empaty
                        If Len(dgvoucher(4, i).Value) > 0 Then 'check for  paymod
                            paymod = "-"
                        Else
                            paymod = "-"
                        End If 'for paymode
                        paymod = "-"
                        If dgvoucher(6, i).Value = "Dr" Then 'check amount
                            vardr = dgvoucher(5, i).Value
                            varcr = 0
                            eid = d
                            d = d - 1 ' for entry id 

                        Else
                            vardr = 0
                            varcr = dgvoucher(5, i).Value
                            eid = c
                            c = c + 1 'for entry id 
                        End If
                        'Getting Group and sub gropu from Acc_head table on basis of Acc_code
                        'Code by krishna 
                        SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & dgvoucher(1, i).Value & "'"
                        GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
                        Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
                        Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)

                        If Sub_group_name.Length = 0 Then
                            Sub_group_name = "-"
                        End If

                        sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                        sqlsave += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name,Ch_date"
                        sqlsave += ") values ( "
                        sqlsave += "'" & GMod.Cmpid & "','" & GMod.username & "'," & Val(dgvoucher(0, i).Value) & ",'" & lblvouno.Text & "',"
                        sqlsave += "'" & cmbvtype.Text.Trim & "','" & dtvdate.Value.ToShortDateString & "','" & dgvoucher(1, i).Value & "','" & Trim(dgvoucher(2, i).Value.ToString) & "'," & Val(vardr) & "," & Val(varcr) & ","
                        sqlsave += "'" & paymod & "','" & dgvoucher(4, i).Value & "','" & dgvoucher(3, i).Value & "','" & Group_name & "',"
                        sqlsave += "'" & Sub_group_name & "','" & PaymentDate.ToShortDateString & "')"
                        GMod.ds.Tables("Grp_Sub").Clear()
                    End If
                    Dim cmd2 As New SqlClient.SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd2.ExecuteNonQuery()
                End If
            Next
            Dim cmd3 As New SqlClient.SqlCommand("insert into " & GMod.INVENTORY & " select * from tmpInvinfo where Cmp_id='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'", GMod.SqlConn, sqltrans)
            'cmd3.ExecuteNonQuery()

            'delete existing voucher
            sqldel = "delete from tmpInvinfo where Cmp_id='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'"
            Dim cmd1 As New SqlClient.SqlCommand(sqldel, GMod.SqlConn, sqltrans)
            cmd1.ExecuteNonQuery()

            'Setting Inventry Found to FASLE

            sqltrans.Commit()

            'nxtvno()
            InventoryFound = False
            sqltrans.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, GMod.Cmpname)
            sqltrans.Rollback()
            InventoryFound = False
            sqltrans.Dispose()
            Return False
        End Try
        GMod.ds.Tables.Clear()

    End Function

    Private Function DoubleEntry() As Boolean
        If CheckBox3.Checked = True And btnsave.Enabled = True Then
            'nxtvno()
        End If
        If btnsave.Enabled = False Then
            GMod.Fill_Log(GMod.Cmpid, lblvouno.Text, cmbvtype.Text, dtvdate.Value, Now, GMod.Session, "M", GMod.username)
        End If
        Dim i As Integer
        If cmbacheadname.Text = "" Then
            MsgBox("Please seclect account", MsgBoxStyle.Critical)
            Exit Function
        End If
        Dim sqltrans As SqlClient.SqlTransaction
        Dim sqldel, sqlsavedr, sqlsavecr, paymod, Group_name, Sub_group_name, SqlGrpsubgrp As String
        Dim varcr, vardr
        sqltrans = GMod.SqlConn.BeginTransaction
        'Genetate Voucher No at save time 
        nxtvno()
        Try
            'delete existing voucher
            'sqldel = "delete from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'"
            'Dim cmd1 As New SqlClient.SqlCommand(sqldel, GMod.SqlConn, sqltrans)
            'cmd1.ExecuteNonQuery()
            ''delete from existing inventory

            'save voucher entry
            For i = 0 To dgvoucher.Rows.Count - 1
                If Len(dgvoucher(1, i).Value) <> 0 Then
                    If Len(dgvoucher(1, i).Value) > 0 Then 'check for account head code is empaty
                        If Len(dgvoucher(4, i).Value) > 0 Then 'check for  paymod
                            paymod = "CHEQUE"
                        Else
                            paymod = "CASH"
                        End If
                        paymod = "-"
                        If dgvoucher(6, i).Value = "Dr" Then 'check amount
                            vardr = dgvoucher(5, i).Value
                            varcr = 0
                            'Getting Group and sub gropu from Acc_head table on basis of Acc_code
                            'Code by krishna 
                            SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & dgvoucher(1, i).Value & "'"
                            GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
                            Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
                            Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)

                            'dr entry (data from grid)
                            sqlsavedr = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                            sqlsavedr += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                            sqlsavedr += ") values( "
                            sqlsavedr += "'" & GMod.Cmpid & "','" & GMod.username & "'," & Val(dgvoucher(0, i).Value) - 0.5 & ",'" & lblvouno.Text & "',"
                            sqlsavedr += "'" & cmbvtype.Text & "','" & dtVdate.Value.ToShortDateString & "','" & dgvoucher(1, i).Value & "','" & Trim(dgvoucher(2, i).Value.ToString) & "'," & Val(vardr) & "," & Val(varcr) & ","
                            sqlsavedr += "'" & paymod & "','" & dgvoucher(4, i).Value & "','" & dgvoucher(3, i).Value.ToString.ToUpper & "','" & Group_name & "',"
                            sqlsavedr += "'" & Sub_group_name & "')"

                            'cr entry
                            sqlsavecr = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                            sqlsavecr += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                            sqlsavecr += ") values( "
                            sqlsavecr += "'" & GMod.Cmpid & "','" & GMod.username & "'," & dgvoucher(0, i).Value & ",'" & lblvouno.Text & "',"
                            sqlsavecr += "'" & cmbvtype.Text & "','" & dtVdate.Value.ToShortDateString & "','" & cmbacheadcode.Text & "','" & cmbacheadname.Text & "'," & Val(varcr) & "," & Val(vardr) & ","
                            sqlsavecr += "'" & paymod & "','" & dgvoucher(4, i).Value & "','" & dgvoucher(3, i).Value.ToString.ToUpper & "','" & cmbacgroup.Text & "',"
                            sqlsavecr += "'" & cmbacsubgroup.Text & "')"

                            GMod.ds.Tables("Grp_Sub").Clear() 'Clearng the table

                        Else
                            vardr = 0
                            varcr = dgvoucher(5, i).Value
                            'dr entry
                            sqlsavecr = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                            sqlsavecr += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                            sqlsavecr += ") values( "
                            sqlsavecr += "'" & GMod.Cmpid & "','" & GMod.username & "'," & Val(dgvoucher(0, i).Value) - 0.5 & ",'" & lblvouno.Text & "',"
                            sqlsavecr += "'" & cmbvtype.Text & "','" & dtVdate.Value.ToShortDateString & "','" & cmbacheadcode.Text & "','" & cmbacheadname.Text & "'," & Val(varcr) & "," & Val(vardr) & ","
                            sqlsavecr += "'" & paymod & "','" & dgvoucher(4, i).Value & "','" & dgvoucher(3, i).Value.ToString.ToUpper & "','" & cmbacgroup.Text & "',"
                            sqlsavecr += "'" & cmbacsubgroup.Text & "')"

                            'cr entry(Data of grid)

                            'Getting Group and sub gropu from Acc_head table on basis of Acc_code
                            'Code by krishna 
                            SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & dgvoucher(1, i).Value & "'"
                            GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
                            Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
                            Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)

                            If Sub_group_name.Length = 0 Then
                                Sub_group_name = "-"
                            End If

                            sqlsavedr = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                            sqlsavedr += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                            sqlsavedr += ") values( "
                            sqlsavedr += "'" & GMod.Cmpid & "','" & GMod.username & "'," & Val(dgvoucher(0, i).Value) & ",'" & lblvouno.Text & "',"
                            sqlsavedr += "'" & cmbvtype.Text & "','" & dtVdate.Value.ToShortDateString & "','" & dgvoucher(1, i).Value & "','" & dgvoucher(2, i).Value & "'," & Val(vardr) & "," & Val(varcr) & ","
                            sqlsavedr += "'" & paymod & "','" & dgvoucher(4, i).Value & "','" & dgvoucher(3, i).Value.ToString.ToUpper & "','" & Group_name & "',"
                            sqlsavedr += "'" & Sub_group_name & "')"


                            GMod.ds.Tables("Grp_Sub").Clear() 'Clearng the table
                        End If
                        Dim cmd2 As New SqlClient.SqlCommand(sqlsavedr, GMod.SqlConn, sqltrans)
                        cmd2.ExecuteNonQuery()
                        Dim cmd3 As New SqlClient.SqlCommand(sqlsavecr, GMod.SqlConn, sqltrans)
                        cmd3.ExecuteNonQuery()
                    End If
                End If
            Next
            sqltrans.Commit()
            'nxtvno()
            sqltrans = Nothing
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, GMod.Cmpname)
            sqltrans.Rollback()
            sqltrans = Nothing
            Return False
        End Try

    End Function
    Dim PaymentDate As Date = CDate("1/1/2000")
    Dim x As Integer
    Dim q As String
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        '--------------------------------------------------------------------------------------------
        'Select Case cmbvtype.Text
        '    Case "CR VOUCHER", "CR VOUCHER-TR"
        '        For x = 0 To dgvoucher.RowCount - 1
        '            dgvoucher(6, x).Value = "Cr"
        '        Next
        '    Case "CASH"
        '        For x = 0 To dgvoucher.RowCount - 1
        '            dgvoucher(6, x).Value = "Dr"
        '        Next
        'End Select
        '--------------------------------------------------------------------------------------------
        Try
            For x = 0 To dgvoucher.RowCount - 1
                q = "select account_head_name from " & GMod.ACC_HEAD & " where account_code = '" & dgvoucher(1, x).Value.ToString & "'"
                GMod.DataSetRet(q, "ahd")
                If GMod.ds.Tables("ahd").Rows(0)(0).ToString.Length > 0 Then
                    dgvoucher(2, x).Value = GMod.ds.Tables("ahd").Rows(0)(0).ToString
                Else
                    MsgBox("Invalid Selection of Head", MsgBoxStyle.Critical)
                    dgvoucher.Focus()
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox("Please Remove the Extras rows", MsgBoxStyle.Critical)
            Exit Sub
            'Exit Sub
        End Try
        '----------------------------------------------------------------------------------------------------
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            '-------------------------Checking voucher types for sum of Dr Cr--------------
            Select Case GMod.Cmpid
                Case "SHVI", "SMAN", "MIGU", "GATR"

                Case Else
                    Select Case cmbvtype.Text
                        Case "CR VOUCHER", "CR VOUCHER-TR", "FRECEIPT", "RE-CEIPT", "CASH"

                        Case Else
                            If Val(lblcrsum.Text) <> Val(lbldrsum.Text) Then
                                MsgBox("Dr and Cr Not Tally", MsgBoxStyle.Critical)
                                dgvoucher.Focus()
                                Exit Sub
                            End If
                    End Select
            End Select
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            If GMod.Cmpid = "PHFE" Or GMod.Cmpid = "PHLU" Or GMod.Cmpid = "PHBU" Then
                If cmbvtype.Text = "PURCHASE" Then
                    Dim pd As New frmPaymentDatePopUp
                    pd.ShowDialog()
                    PaymentDate = pd.dtpdate.Value
                End If
            End If
            'check for zero amount
            Try
                Dim x As Integer
                'For x = 0 To dgvoucher.Rows.Count - 1
                '    MsgBox(dgvoucher(6, x).Value.ToString)
                '    If dgvoucher(6, x).Value.ToString <> "Cr" Or dgvoucher(6, x).Value <> "Dr" Then
                '        MsgBox("Select Dr/Cr from transection", MsgBoxStyle.Critical)
                '    End If
                '    Exit Sub
                'Next
                For x = 0 To dgvoucher.Rows.Count - 2
                    If Val(dgvoucher(5, x).Value) = 0 Then
                        MsgBox("Amount can not be zero", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            For x = 0 To dgvoucher.RowCount - 1

            Next
            If Not (cmbvtype.Text = "RECEIPT" Or cmbvtype.Text = "PAYMENT") Then
                If SingleEntry() = True Then
                    btnreset_Click(sender, e)
                End If
            Else
                If DoubleEntry() = True Then
                    btnreset_Click(sender, e)
                End If
            End If
            dtVdate.Focus()
            'ach.Dispose()
            MsgBox(cmbvtype.Text & "/" & lblvouno.Text)
            lblvouno.Text = ""
            lblcrsum.Text = "0"
            lbldrsum.Text = "0"
        Else
            Exit Sub
        End If
    End Sub
    Private Sub cmbvtype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvtype.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbacheadcode.Enabled = True Then
            Else
                dtvdate.Focus()
            End If
        End If
    End Sub

    Private Sub cmbvtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype.SelectedIndexChanged
        Try
            cmbvtype_Leave(sender, e)
            Label1.Text = "Voucher Entry - " & cmbvtype.Text
            '            nxtvno()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dtvdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            dgvoucher.Focus()
        End If
    End Sub

    Private Sub cmbacsubgroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacsubgroup.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacheadcode.Focus()
    End Sub

    Private Sub cmbacheadcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dtvdate.Enabled = False Then
                dgvoucher.Focus()
            Else
                dtvdate.Focus()
            End If
        End If
    End Sub
    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged
        Try
            If cmbacheadcode.Text <> "" Then
                Dim sql As String
                sql = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code='" & cmbacheadcode.Text & "'"
                GMod.DataSetRet(sql, "sub_grp")
                cmbacgroup.Text = GMod.ds.Tables("sub_grp").Rows(0)(0)
                cmbacsubgroup.Text = GMod.ds.Tables("sub_grp").Rows(0)(1)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmbacheadname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then cmbacheadcode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvoucher.KeyDown
        Try
            If e.KeyCode = Keys.F3 And dgvoucher.CurrentCell.ColumnIndex = 3 And dgvoucher.CurrentCell.RowIndex > 0 Then
                dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value = dgvoucher(3, dgvoucher.CurrentCell.RowIndex - 1).Value
            End If
            If e.KeyCode = Keys.F4 And dgvoucher.CurrentCell.ColumnIndex = 3 Then
                Dim nl As New frmNarrationlist
                nl.ShowDialog()
                dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value = nl.ComboBox1.Text
            End If
            'For Inventory
            If e.KeyCode = Keys.F1 Then
                Try
                    MsgBox("inventory")
                    'GMod.InventoryFound = True
                    Dim tInv As New frmInvInfo
                    tInv.txtHeadName.Text = dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value
                    tInv.txtHeadCode.Text = dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value
                    tInv.txtVouno.Text = Me.lblvouno.Text
                    tInv.txtVtype.Text = Me.cmbvtype.Text
                    tInv.dtVoudate.Value = Me.dtvdate.Value
                    If cmbvtype.Text <> "JOURNAL" Then
                        tInv.cmbinttype.Text = cmbvtype.Text
                    End If
                    tInv.ShowDialog()
                    dgvoucher(5, dgvoucher.CurrentCell.RowIndex).Value = tInv.txtTotal.Text
                    dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value = tInv.txtNarration.Text
                Catch e1 As Exception
                    MsgBox(e1.Message)
                End Try
            End If
            If e.KeyCode = Keys.F9 And dgvoucher.CurrentCell.ColumnIndex = 3 Then
                Dim pp As New frmPaymentDatePopUp
                pp.dtpdate.CustomFormat = "MMM/yyyy"
                pp.ShowDialog()

                dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value = dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value & "#" & pp.dtpdate.Text
            End If
        Catch ex As Exception
            dgvoucher.Focus()
        End Try
    End Sub
    Private Sub dgvoucher_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvoucher.KeyUp
        If e.KeyCode = Keys.Enter Then
            If dgvoucher.CurrentCell.ColumnIndex < dgvoucher.ColumnCount - 1 Then
                'SendKeys.Send("{Tab}")
                dgvoucher.CurrentCell = dgvoucher(dgvoucher.CurrentCell.ColumnIndex + 1, dgvoucher.CurrentCell.RowIndex)

            Else
                dgvoucher.Rows.Add()
                dgvoucher.CurrentCell = dgvoucher(0, dgvoucher.CurrentCell.RowIndex + 1)
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            btnsave_Click(sender, e)
        End If
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click

        dgvoucher.Rows.Clear()
        dgvoucher.Rows.Add()
        'nxtvno()
        btnsave.Enabled = True
        btnmodify.Text = "&Modify"
        If (cmbvtype.Text <> "PAYMENT" Or cmbvtype.Text = "RECEIPT" Or cmbvtype.Text = "JOURNAL") Then cmbvtype.Enabled = True
        cmbacgroup.Focus()
        dtvdate.Enabled = True
        CheckBox3.Checked = True
        lblvouno.ReadOnly = True
        Try
            'dtvdate.Value = GMod.setDate
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim achead As New frmGeneralacchead
        achead.ShowDialog()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim achead As New frmGeneralacchead
            achead.ShowDialog()
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Dim t As New frmPartyaccount
            Dim sql As String
            sql = "select Group_name,Suffix from Groups where Group_name like '%PART%' and Cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "Suffix")

            t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupname.DisplayMember = "Group_name"

            t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupsuffix.DisplayMember = "Suffix"
            t.lblgroupsuffix.Text = "PA"
            t.Label1.Text = "Party Account Heads"
            t.ShowDialog()
            CheckBox2.Checked = False
        End If
    End Sub
    Private Sub CheckBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.Click
       
    End Sub
    Private Sub cmbvtype_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype.Leave
        If btnsave.Enabled = True Then
            If cmbvtype.Text.Trim = "" Then
                MsgBox("Voucher Can't be blank", MsgBoxStyle.Critical)
                cmbvtype.Focus()
            End If
            If Me.cmbvtype.FindStringExact(cmbvtype.Text) = -1 Then
                MsgBox("Incorrect voucher type", MsgBoxStyle.Critical)
                cmbvtype.Focus()
            Else
                Dim sqlvouseq As String
                sqlvouseq = "select Vou_no_seq  from dbo.Vtype where vtype='" & cmbvtype.Text & "' AND cmp_id='" & GMod.Cmpid & "'"
                GMod.DataSetRet(sqlvouseq, "Vou_Seq")
                If GMod.ds.Tables("vou_seq").Rows.Count > 0 Then lblvouseq.Text = GMod.ds.Tables("Vou_Seq").Rows(0)(0)
                'nxtvno()
            End If
        End If
    End Sub
    Private Sub frmVentry_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        GMod.ds.Tables.Clear()
        frmacheadlist.Close()
        ach.Dispose()
    End Sub
    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        Try
            If btnsave.Enabled Then
                Dim i As Integer
                Dim r As New frmvoucherlist
                If Me.cmbvtype.Enabled = False Then
                    r.cmbvtype.Enabled = False
                    r.lblvtype.Text = cmbvtype.Text
                End If
                r.ShowDialog()
                If LockDataCheck(r.txtvouno.Text, GMod.Session, r.cmbvtype.Text) = False Then
                    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Exit Sub
                End If
                Dim F As Integer
                Dim sql As String
                If Not (cmbvtype.Text = "PAYMENT" Or cmbvtype.Text = "RECEIPT") Then
                    sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                    sql += " and vou_type='" & r.cmbvtype.Text & "' order by entry_id"
                    GMod.DataSetRet(sql, "ser")
                    If GMod.ds.Tables("ser").Rows.Count > 0 Then
                        If dgvoucher.Rows.Count > 0 Then dgvoucher.Rows.Clear()
                        cmbvtype.Text = GMod.ds.Tables("ser").Rows(0)("vou_type")
                        dtVdate.MinDate = CDate(GMod.ds.Tables("ser").Rows(0)("vou_date")).AddDays(-Val(GMod.nofd))
                        dtVdate.Value = CDate(GMod.ds.Tables("ser").Rows(0)("vou_date"))
                        lblvouno.Text = GMod.ds.Tables("ser").Rows(0)("vou_no")
                        For i = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                            dgvoucher.Rows.Add()
                            dgvoucher(0, i).Value = i + 1
                            dgvoucher(1, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head_code")
                            dgvoucher(2, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head")
                            dgvoucher(3, i).Value = GMod.ds.Tables("ser").Rows(i)("narration")
                            dgvoucher(4, i).Value = GMod.ds.Tables("ser").Rows(i)("cheque_no")
                            If GMod.ds.Tables("ser").Rows(i)("dramt") > 0 Then
                                dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("dramt")
                                dgvoucher(6, i).Value = "Dr"
                            Else
                                dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("cramt")
                                dgvoucher(6, i).Value = "Cr"
                            End If
                        Next
                        F = 1
                    End If
                    Try

                   
                        '--For Inventory---------------------
                        Dim sqlinv As String, sqlsave As String
                        If GMod.Cmpid = "VIBU" Then
                            sqlinv = "select * from " & GMod.INVENTORY & " where Vou_no=" & lblvouno.Text & " and Vou_type='" & cmbvtype.Text & "'"
                            GMod.DataSetRet(sqlinv, "Invtab")
                            If GMod.ds.Tables("Invtab").Rows.Count > 0 Then
                                GMod.SqlExecuteNonQuery("delete from tmpInvinfo where uname='" & GMod.username & "'")
                                InventoryFound = True
                                MsgBox("Inventry in the voucher,please PRESS F1 and then edit", MsgBoxStyle.Information)
                                sqlsave = "  insert into tmpInvinfo(Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, " _
                                             & "Acc_head, ItemName, Qty, QtyNos, Unit, Rate, Amount, Free_Qty, BillType, " _
                                            & "BillNo, BillDate, AreaCode,Hatch_date)  " _
                               & " select Cmp_id,'" & GMod.username & "', Vou_no, Vou_type, Vou_date, " _
                               & " Acc_head_code, Acc_head, ItemName, Qty, QtyNos, Unit, " _
                               & " Rate, Amount, Free_Qty, BillType, BillNo, BillDate,  " _
                               & " AreaCode,Hatch_date from " & GMod.INVENTORY & " where Vou_no=" & lblvouno.Text & " and Vou_type='" & cmbvtype.Text & "'"
                                GMod.SqlExecuteNonQuery(sqlsave)
                                'Dim t As New frmInvInfo
                                't.ShowDialog()
                                'dgvoucher(5, dgvoucher.CurrentCell.RowIndex).Value = t.txtTotal.Text
                                'dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value = t.txtNarration.Text
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                ElseIf cmbvtype.Text = "PAYMENT" Then
                    sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                    sql += " and vou_type='" & r.cmbvtype.Text & "' order by cramt desc"
                    GMod.DataSetRet(sql, "ser")
                    If GMod.ds.Tables("ser").Rows.Count > 0 Then
                        cmbacgroup.Text = GMod.ds.Tables("ser").Rows(0)("group_name")
                        cmbacsubgroup.Text = GMod.ds.Tables("ser").Rows(0)("sub_group_name")
                        cmbacheadcode.Text = GMod.ds.Tables("ser").Rows(0)("acc_head_code")
                        cmbacheadname.Text = GMod.ds.Tables("ser").Rows(0)("acc_head")
                        sql = " select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                        sql += " and vou_type='" & r.cmbvtype.Text & "' and dramt>0 order by entry_id"
                        GMod.DataSetRet(sql, "ser")

                        If dgvoucher.Rows.Count > 0 Then dgvoucher.Rows.Clear()
                        cmbvtype.Text = GMod.ds.Tables("ser").Rows(0)("vou_type")
                        dtVdate.Value = GMod.ds.Tables("ser").Rows(0)("vou_date")
                        lblvouno.Text = GMod.ds.Tables("ser").Rows(0)("vou_no")

                        For i = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                            dgvoucher.Rows.Add()
                            dgvoucher(0, i).Value = i + 1
                            dgvoucher(1, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head_code")
                            dgvoucher(2, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head")
                            dgvoucher(3, i).Value = GMod.ds.Tables("ser").Rows(i)("narration")
                            dgvoucher(4, i).Value = GMod.ds.Tables("ser").Rows(i)("cheque_no")
                            If GMod.ds.Tables("ser").Rows(i)("dramt") > 0 Then
                                dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("dramt")
                                dgvoucher(6, i).Value = "Dr"
                            Else
                                dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("cramt")
                                dgvoucher(6, i).Value = "Dr"
                            End If
                        Next
                        F = 1
                    End If
                ElseIf cmbvtype.Text = "RECEIPT" Then
                    sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                    sql += " and vou_type='" & r.cmbvtype.Text & "' order by dramt desc"
                    GMod.DataSetRet(sql, "ser")
                    If GMod.ds.Tables("ser").Rows.Count > 0 Then
                        cmbacgroup.Text = GMod.ds.Tables("ser").Rows(0)("group_name")
                        cmbacsubgroup.Text = GMod.ds.Tables("ser").Rows(0)("sub_group_name")
                        cmbacheadcode.Text = GMod.ds.Tables("ser").Rows(0)("acc_head_code")
                        cmbacheadname.Text = GMod.ds.Tables("ser").Rows(0)("acc_head")
                        sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                        sql += " and vou_type='" & r.cmbvtype.Text & "' and cramt>0 order by entry_id"
                        GMod.DataSetRet(sql, "ser")

                        If dgvoucher.Rows.Count > 0 Then dgvoucher.Rows.Clear()
                        cmbvtype.Text = GMod.ds.Tables("ser").Rows(0)("vou_type")
                        dtVdate.MinDate = CDate(GMod.ds.Tables("ser").Rows(0)("vou_date")).AddDays(-GMod.nofd)
                        lblvouno.Text = GMod.ds.Tables("ser").Rows(0)("vou_no")
                        For i = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                            dgvoucher.Rows.Add()
                            dgvoucher(0, i).Value = i + 1
                            dgvoucher(1, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head_code")
                            dgvoucher(2, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head")
                            dgvoucher(3, i).Value = GMod.ds.Tables("ser").Rows(i)("narration")
                            dgvoucher(4, i).Value = GMod.ds.Tables("ser").Rows(i)("cheque_no")
                            If GMod.ds.Tables("ser").Rows(i)("dramt") > 0 Then
                                dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("dramt")
                                dgvoucher(6, i).Value = "Cr"
                            Else
                                dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("cramt")
                                dgvoucher(6, i).Value = "Cr"
                            End If
                        Next
                        F = 1
                    End If
                End If
                If F = 1 Then
                    btnsave.Enabled = False
                    ' dtvdate.Enabled = False
                    btnmodify.Text = "&Update"
                    Me.cmbvtype.Enabled = False
                    dgvoucher.Focus()
                Else
                    MsgBox("Invalid Voucher No", MsgBoxStyle.Critical)
                End If
            Else
                'Dim sqldel, res As String
                ''delete existing voucher
                'If GMod.InventoryFound = True Then
                '    sqldel = "Delete from " & GMod.INVENTORY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'"
                '    res = GMod.SqlExecuteNonQuery(sqldel)
                'End If
                'sqldel = "Delete from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'"
                'res = GMod.SqlExecuteNonQuery(sqldel)
                'If res = "SUCCESS" Then
                '    btnsave_Click(sender, e)
                'Else
                '    MsgBox(res)
                'End If

                '------------------------------------------------------------------------------------------------------------------------------

                If CheckBox3.Checked = True And btnsave.Enabled = True Then
                    'nxtvno()
                Else
                    GMod.Fill_Log(GMod.Cmpid, lblvouno.Text, cmbvtype.Text, dtvdate.Value, Now, GMod.Session, "M", GMod.username)
                End If
                Dim i As Integer

                Dim sqltrans As SqlClient.SqlTransaction
                Dim sqldel, paymod, Group_name, Sub_group_name, SqlGrpsubgrp As String
                Dim varcr, vardr, eid, c, d As Double
                sqltrans = GMod.SqlConn.BeginTransaction
                If GMod.Cmpid = "VIBU" Then
                    sqldel = "Delete from " & GMod.INVENTORY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'"
                    Dim cmd0 As New SqlClient.SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmd0.ExecuteNonQuery()
                End If
                sqldel = "Delete from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'"
                Dim cmd1 As New SqlClient.SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                cmd1.ExecuteNonQuery()
                d = -1
                c = 0
                Try
                    Dim sqlsave As String = ""
                    For i = 0 To dgvoucher.Rows.Count - 1
                        If Len(dgvoucher(1, i).Value) <> 0 Then
                            If Len(dgvoucher(1, i).Value) > 0 Then 'check for account head code is empaty
                                If Len(dgvoucher(4, i).Value) > 0 Then 'check for  paymod
                                    paymod = "CHEQUE"
                                Else
                                    paymod = "CASH"
                                End If 'for paymode
                                paymod = "-"
                                If dgvoucher(6, i).Value = "Dr" Then 'check amount
                                    vardr = dgvoucher(5, i).Value
                                    varcr = 0
                                    eid = d
                                    d = d - 1 ' for entry id 
                                Else
                                    vardr = 0
                                    varcr = dgvoucher(5, i).Value
                                    eid = c
                                    c = c + 1 'for entry id 
                                End If
                                'Getting Group and sub gropu from Acc_head table on basis of Acc_code
                                'Code by krishna 
                                SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & dgvoucher(1, i).Value & "'"
                                GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
                                Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
                                Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)

                                If Sub_group_name.Length = 0 Then
                                    Sub_group_name = "-"
                                End If

                                sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                                sqlsave += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                                sqlsave += ") values ( "
                                sqlsave += "'" & GMod.Cmpid & "','" & GMod.username & "'," & Val(dgvoucher(0, i).Value) & ",'" & lblvouno.Text & "',"
                                sqlsave += "'" & cmbvtype.Text & "','" & dtVdate.Value.ToShortDateString & "','" & dgvoucher(1, i).Value & "','" & dgvoucher(2, i).Value & "'," & Val(vardr) & "," & Val(varcr) & ","
                                sqlsave += "'" & paymod & "','" & dgvoucher(4, i).Value & "','" & dgvoucher(3, i).Value & "','" & Group_name & "',"
                                sqlsave += "'" & Sub_group_name & "')"
                                GMod.ds.Tables("Grp_Sub").Clear()
                            End If
                            Dim cmd2 As New SqlClient.SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                            cmd2.ExecuteNonQuery()
                        End If
                    Next
                    If GMod.Cmpid = "VIBU" Then
                        Dim cmd3 As New SqlClient.SqlCommand("insert into " & GMod.INVENTORY & " select * from tmpInvinfo where Cmp_id='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'", GMod.SqlConn, sqltrans)
                        'cmd3.ExecuteNonQuery()

                        'delete existing voucher
                        sqldel = "delete from tmpInvinfo where Cmp_id='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'"
                        Dim cmd5 As New SqlClient.SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                        cmd5.ExecuteNonQuery()
                    End If
                    'Setting Inventry Found to FASLE

                    sqltrans.Commit()
                    'nxtvno()
                    InventoryFound = False
                    btnsave.Enabled = True
                    dtVdate.Enabled = True
                    btnmodify.Text = "&Modify"
                    cmbvtype.Enabled = True
                    dgvoucher.Rows.Clear()
                    dgvoucher.Rows.Add()
                    dgvoucher.Focus()
                    MsgBox("Voucher modified")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, GMod.Cmpname)
                    sqltrans.Rollback()
                    InventoryFound = False
                    InventoryFound = False
                    btnsave.Enabled = True
                    dtVdate.Enabled = True
                    btnmodify.Text = "&Modify"
                    cmbvtype.Enabled = True
                    dgvoucher.Rows.Clear()
                    dgvoucher.Rows.Add()
                    dgvoucher.Focus()
                    'nxtvno()
                End Try
                sqltrans.Dispose()
                GMod.ds.Tables.Clear()
                '------------------------------------------------------------------------------------------------------------------------------
                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' SetLastVouDate()
        'GMod.setDate = dtvdate.Value

        'nxtvno()
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If btnsave.Enabled Then
            Dim i As Integer
            Dim r As New frmvoucherlist
            If cmbvtype.Enabled = False Then
                r.cmbvtype.Enabled = False
                r.lblvtype.Text = cmbvtype.Text
            End If
            r.ShowDialog()
            If LockDataCheck(r.txtvouno.Text, GMod.Session, r.cmbvtype.Text) = False Then
                MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim F As Integer
            Dim sql As String
            If Not (cmbvtype.Text = "PAYMENT" Or cmbvtype.Text = "RECEIPT") Then
                sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                sql += " and vou_type='" & r.cmbvtype.Text & "' order by entry_id"
                GMod.DataSetRet(sql, "ser")
                If GMod.ds.Tables("ser").Rows.Count > 0 Then
                    If dgvoucher.Rows.Count > 0 Then dgvoucher.Rows.Clear()
                    cmbvtype.Text = GMod.ds.Tables("ser").Rows(0)("vou_type")
                    dtvdate.Value = GMod.ds.Tables("ser").Rows(0)("vou_date")
                    lblvouno.Text = GMod.ds.Tables("ser").Rows(0)("vou_no")
                    For i = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                        dgvoucher.Rows.Add()
                        dgvoucher(0, i).Value = i + 1
                        dgvoucher(1, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head_code")
                        dgvoucher(2, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head")
                        dgvoucher(3, i).Value = GMod.ds.Tables("ser").Rows(i)("narration")
                        dgvoucher(4, i).Value = GMod.ds.Tables("ser").Rows(i)("cheque_no")
                        If GMod.ds.Tables("ser").Rows(i)("dramt") > 0 Then
                            dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("dramt")
                            dgvoucher(6, i).Value = "Dr"
                        Else
                            dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("cramt")
                            dgvoucher(6, i).Value = "Cr"
                        End If
                    Next
                    F = 1
                End If
                '--For Inventory----------------
                Dim sqlinv As String, sqlsave As String
                sqlinv = "select * from " & GMod.INVENTORY & " where Vou_no=" & lblvouno.Text & " and Vou_type='" & cmbvtype.Text & "'"
                GMod.DataSetRet(sqlinv, "Invtab")
                If GMod.ds.Tables("Invtab").Rows.Count > 0 Then
                    InventoryFound = True
                    sqlsave = "  insert into tmpInvinfo(Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, " _
                                 & "Acc_head, ItemName, Qty, QtyNos, Unit, Rate, Amount, Free_Qty, BillType, " _
                                & "BillNo, BillDate, AreaCode )  " _
                   & " select Cmp_id,'" & GMod.username & "', Vou_no, Vou_type, Vou_date, " _
                   & " Acc_head_code, Acc_head, ItemName, Qty, QtyNos, Unit, " _
                   & " Rate, Amount, Free_Qty, BillType, BillNo, BillDate,  " _
                   & " AreaCode from " & GMod.INVENTORY & " where Vou_no=" & lblvouno.Text & " and Vou_type='" & cmbvtype.Text & "'"
                    GMod.SqlExecuteNonQuery(sqlsave)
                    'Dim t As New frmInvInfo
                    't.ShowDialog()
                    'dgvoucher(5, dgvoucher.CurrentCell.RowIndex).Value = t.txtTotal.Text
                    'dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value = t.txtNarration.Text
                End If
            ElseIf cmbvtype.Text = "PAYMENT" Then
                sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                sql += " and vou_type='" & r.cmbvtype.Text & "' order by cramt desc"
                GMod.DataSetRet(sql, "ser")
                If GMod.ds.Tables("ser").Rows.Count > 0 Then
                    cmbacgroup.Text = GMod.ds.Tables("ser").Rows(0)("group_name")
                    cmbacsubgroup.Text = GMod.ds.Tables("ser").Rows(0)("sub_group_name")
                    cmbacheadcode.Text = GMod.ds.Tables("ser").Rows(0)("acc_head_code")
                    cmbacheadname.Text = GMod.ds.Tables("ser").Rows(0)("acc_head")
                    sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                    sql += " and vou_type='" & r.cmbvtype.Text & "' and dramt>0 order by entry_id"
                    GMod.DataSetRet(sql, "ser")

                    If dgvoucher.Rows.Count > 0 Then dgvoucher.Rows.Clear()
                    cmbvtype.Text = GMod.ds.Tables("ser").Rows(0)("vou_type")
                    dtvdate.Value = GMod.ds.Tables("ser").Rows(0)("vou_date")
                    lblvouno.Text = GMod.ds.Tables("ser").Rows(0)("vou_no")

                    For i = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                        dgvoucher.Rows.Add()
                        dgvoucher(0, i).Value = i + 1
                        dgvoucher(1, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head_code")
                        dgvoucher(2, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head")
                        dgvoucher(3, i).Value = GMod.ds.Tables("ser").Rows(i)("narration")
                        dgvoucher(4, i).Value = GMod.ds.Tables("ser").Rows(i)("cheque_no")
                        If GMod.ds.Tables("ser").Rows(i)("dramt") > 0 Then
                            dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("dramt")
                            dgvoucher(6, i).Value = "Dr"
                        Else
                            dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("cramt")
                            dgvoucher(6, i).Value = "Dr"
                        End If
                    Next
                    F = 1
                End If
            ElseIf cmbvtype.Text = "RECEIPT" Then
                sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                sql += " and vou_type='" & r.cmbvtype.Text & "' order by dramt desc"
                GMod.DataSetRet(sql, "ser")
                If GMod.ds.Tables("ser").Rows.Count > 0 Then
                    cmbacgroup.Text = GMod.ds.Tables("ser").Rows(0)("group_name")
                    cmbacsubgroup.Text = GMod.ds.Tables("ser").Rows(0)("sub_group_name")
                    cmbacheadcode.Text = GMod.ds.Tables("ser").Rows(0)("acc_head_code")
                    cmbacheadname.Text = GMod.ds.Tables("ser").Rows(0)("acc_head")
                    sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
                    sql += " and vou_type='" & r.cmbvtype.Text & "' and cramt>0 order by entry_id"
                    GMod.DataSetRet(sql, "ser")

                    If dgvoucher.Rows.Count > 0 Then dgvoucher.Rows.Clear()
                    cmbvtype.Text = GMod.ds.Tables("ser").Rows(0)("vou_type")
                    dtvdate.Value = GMod.ds.Tables("ser").Rows(0)("vou_date")
                    lblvouno.Text = GMod.ds.Tables("ser").Rows(0)("vou_no")
                    For i = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                        dgvoucher.Rows.Add()
                        dgvoucher(0, i).Value = i + 1
                        dgvoucher(1, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head_code")
                        dgvoucher(2, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head")
                        dgvoucher(3, i).Value = GMod.ds.Tables("ser").Rows(i)("narration")
                        dgvoucher(4, i).Value = GMod.ds.Tables("ser").Rows(i)("cheque_no")
                        If GMod.ds.Tables("ser").Rows(i)("dramt") > 0 Then
                            dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("dramt")
                            dgvoucher(6, i).Value = "Cr"
                        Else
                            dgvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("cramt")
                            dgvoucher(6, i).Value = "Cr"
                        End If
                    Next
                    F = 1
                End If
            End If
            If F = 1 Then
                btnsave.Enabled = False
                dtvdate.Enabled = False
                'btnmodify.Text = "&Update"
                cmbvtype.Enabled = False
                dgvoucher.Focus()

            Else
                MsgBox("Invalid Voucher No", MsgBoxStyle.Critical)
            End If

        Else
            If MsgBox("Are u sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                GMod.Fill_Log(GMod.Cmpid, lblvouno.Text, cmbvtype.Text, dtvdate.Value, Now, GMod.Session, "D", GMod.username)


                Dim sqlt As SqlClient.SqlTransaction
                sqlt = GMod.SqlConn.BeginTransaction
                Dim sqlinv As String
                sqlinv = "select * from " & GMod.INVENTORY & " where Vou_no=" & lblvouno.Text & " and Vou_type='" & cmbvtype.Text & "'"
                GMod.DataSetRet(sqlinv, "Invtab")
                If GMod.ds.Tables("Invtab").Rows.Count > 0 Then
                    Try
                        Dim cmd1 As New SqlClient.SqlCommand("delete from " & GMod.INVENTORY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'", GMod.SqlConn, sqlt)
                        cmd1.ExecuteNonQuery()

                        Dim cmd2 As New SqlClient.SqlCommand("delete from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'", GMod.SqlConn, sqlt)
                        cmd2.ExecuteNonQuery()

                        sqlt.Commit()
                        MsgBox("Voucher Deleted", MsgBoxStyle.Information)
                    Catch ex As Exception
                        sqlt.Rollback()
                        MsgBox("Error " & ex.Message)
                    End Try
                Else
                    Try
                        Dim cmd2 As New SqlClient.SqlCommand("delete from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'", GMod.SqlConn, sqlt)
                        cmd2.ExecuteNonQuery()

                        sqlt.Commit()
                        MsgBox("Voucher Deleted", MsgBoxStyle.Information)
                    Catch ex As Exception
                        sqlt.Rollback()
                    End Try
                    sqlt.Dispose()
                End If
            End If
            btnreset_Click(sender, e)
        End If
        InventoryFound = False
    End Sub
    Dim t As New frmCRVoucherNarration
    Dim t1 As New frmExpensesVoucherNarration
    Private Sub dgvoucher_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellEnter
        If e.ColumnIndex = 3 And cmbvtype.Text <> "CR VOUCHER" And cmbvtype.Text <> "EXPS-VOUCHER" Then
            frmnarrationlistobj.txtNarrationEntrty.Text = dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value
            frmnarrationlistobj.ShowDialog()
            dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value = frmnarrationlistobj.txtNarrationEntrty.Text
            'for CR Voucher 
        ElseIf cmbvtype.Text = "CR VOUCHER" And e.ColumnIndex = 3 Then
            t.ShowDialog()
            dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value = t.TextBox1.Text
            'ElseIf e.ColumnIndex = 5 Then
            '    'copying amount to next row
            '    If dgvoucher.CurrentCell.RowIndex > 0 Then
            '        dgvoucher(5, dgvoucher.CurrentCell.RowIndex).Value = dgvoucher(5, dgvoucher.CurrentCell.RowIndex - 1).Value
            '    End If
        ElseIf cmbvtype.Text = "EXPS-VOUCHER" And e.ColumnIndex = 3 Then
            t1.ShowDialog()
            dgvoucher(3, dgvoucher.CurrentCell.RowIndex).Value = t1.TextBox1.Text

        End If

    End Sub
    Private Sub cmbacheadname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadname.Leave
        If cmbacheadname.FindStringExact(cmbacheadname.Text) = -1 Then
            MsgBox("Head Name Doesn't Exists")
            cmbacheadname.Focus()
        Else
            cmbacheadname.Text = cmbacheadname.Text.ToUpper
        End If
    End Sub
    Private Sub cmbacheadcode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.Leave
        If cmbacheadcode.FindStringExact(cmbacheadcode.Text) = -1 Then
            MsgBox("Head Name Doesn't Exists")
            cmbacheadcode.Focus()
        Else
            cmbacheadcode.Text = cmbacheadcode.Text.ToUpper
        End If
    End Sub

    Private Sub dtvdate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GMod.Session = GMod.Getsession(dtVdate.Value) Then
        Else
            MsgBox("You are trying to enter data of differnrt session")
            dtVdate.Focus()
        End If
    End Sub

    Private Sub ChknewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChknewCustomer.Click
        If ChknewCustomer.Checked = True Then
            Dim t As New frmPartyaccount
            Dim sql As String
            sql = "select Group_name,Suffix from Groups where Group_name like '%CUSTOMER%' and Cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "Suffix")

            t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupname.DisplayMember = "Group_name"

            t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupsuffix.DisplayMember = "Suffix"

            t.Label1.Text = "Customer Account Heads"
            t.ShowDialog()
            ChknewCustomer.Checked = False
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        'If CheckBox3.Checked = True Then
        '    lblvouno.ReadOnly = True
        'Else
        '    lblvouno.ReadOnly = False
        'End If
    End Sub
    Private Sub dtvdate_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtVdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvoucher.Focus()
        End If
    End Sub

    Private Sub dtVdate_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtVdate.Leave
        If btnsave.Enabled = True Then
            GMod.DataSetRet("select isnull(max(vou_date),'" & dtVdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvtype.Text & "'", "getMaxDate")
            If dtVdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
                MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dtVdate.Focus()
            End If
        End If
    End Sub
    Private Sub dtVdate_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtVdate.ValueChanged
        'Setting voucher date accrding to session
        'dtVdate.Value = GMod.SessionCurrentDate
        ' dtVdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        ' dtVdate.MaxDate = GMod.SessionCurrentDate
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Dim ttds As New frmTdsEntry
            ttds.ShowDialog()
        End If
    End Sub

    Private Sub dgvoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellContentClick

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tseq As New frmSeqVentry
        tseq.ShowDialog()
    End Sub
End Class