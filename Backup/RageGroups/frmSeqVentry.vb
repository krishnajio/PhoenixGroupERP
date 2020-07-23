Public Class frmSeqVentry
    Dim ach As New frmacheadlist
    Dim frmnarrationlistobj As New frmNarrationEntrybox

    Private Sub frmSeqVentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select getdate()", "serverdate")
        'dtVdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        dtvdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

        dgSeqvoucher.Rows.Add()
        'Dim sql As String
        'If cmbvtype.Text = "PAYMENT" Then ' For voucher type payment
        '    ' MsgBox(cmbvtype.Text)
        '    sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and  group_name in (" _
        '           & " select Group_name from Groups where effectsin like '%PAYMENT%' " _
        '           & " or effectsin like '%All%' and cmp_id='" & GMod.Cmpid & "' ) "
        '    GMod.DataSetRet(sql, "aclist1")
        'ElseIf cmbvtype.Text = "RECEIPT" Then ' For voucher type Recepit
        '    sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and  group_name in (" _
        '                      & " select Group_name from Groups where effectsin like '%RECEIPT%' " _
        '                      & " or effectsin like '%All%' and cmp_id='" & GMod.Cmpid & "' )"
        '    GMod.DataSetRet(sql, "aclist1")

        'Else
        '    sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
        '    GMod.DataSetRet(sql, "aclist1")
        'End If

        'cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        'cmbacheadcode.DisplayMember = "account_code"
        'cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        'cmbacheadname.DisplayMember = "account_head_name"


        'GMod.DataSetRet("select  account_head_name,account_code  from " & GMod.ACC_HEAD & "  order by account_head_name", "acc_head")
        'cmbacheadlist.DataSource = GMod.ds.Tables("acc_head")
        'cmbacheadlist.DisplayMember = "account_head_name"
        'cmbacheadcodelist.DataSource = GMod.ds.Tables("acc_head")
        'cmbacheadcodelist.DisplayMember = "account_code"


        If cmbvtype.Enabled Then
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and Vtype not in ('PAYMENT','OPEN')  order by seqorder", "vtyseq")
            cmbvtype.DataSource = GMod.ds.Tables("vtyseq")
            cmbvtype.DisplayMember = "vtype"
        End If
        'nxtvno()
        If cmbvtype.Enabled = True Then
            cmbvtype.Focus()
        Else
            dtvdate.Focus()
        End If
        GetLastVouDate() 'Getting last voucher date
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
        fillseqo()
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
        If btnsave.Enabled = True Then
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
        End If
    End Sub
    Private Sub dgSeqvoucher_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSeqvoucher.CellEndEdit
        Dim s, st, h() As String
        If e.ColumnIndex = 1 Then
            If Len(dgSeqvoucher(1, e.RowIndex).Value) = 0 Then
                ach.ShowDialog()
                st = ach.cmbacheadlist.Text
                h = st.Split("[")
                dgSeqvoucher(2, dgSeqvoucher.CurrentCell.RowIndex).Value = h(0)
                h = h(1).Split("]")
                dgSeqvoucher(1, dgSeqvoucher.CurrentCell.RowIndex).Value = h(0)
                Exit Sub
            End If
            s = dgSeqvoucher(1, e.RowIndex).Value.ToString()
            If cmbacheadcodelist.FindString(Trim(s)) > -1 Then
                cmbacheadlist.SelectedIndex = cmbacheadcodelist.FindString(Trim(s))
                dgSeqvoucher(2, e.RowIndex).Value = cmbacheadlist.Text
            Else
                MsgBox("Invalid Account Head Code", MsgBoxStyle.Critical)
                ach.ShowDialog()
                st = ach.cmbacheadlist.Text
                h = st.Split("[")
                dgSeqvoucher(2, dgSeqvoucher.CurrentCell.RowIndex).Value = h(0)
                h = h(1).Split("]")
                dgSeqvoucher(1, dgSeqvoucher.CurrentCell.RowIndex).Value = h(0)
            End If
        End If
        sumdrcr()
    End Sub

    Private Sub dgSeqvoucher_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSeqvoucher.CellLeave
        Try
            Dim s, st, h() As String
            s = dgSeqvoucher(1, dgSeqvoucher.CurrentCell.RowIndex).Value
            If e.ColumnIndex = 1 And String.IsNullOrEmpty(s) Then
                ach.ShowDialog()
                st = ach.cmbacheadlist.Text
                h = st.Split("[")
                dgSeqvoucher(2, dgSeqvoucher.CurrentCell.RowIndex).Value = h(0)
                h = h(1).Split("]")
                dgSeqvoucher(1, dgSeqvoucher.CurrentCell.RowIndex).Value = h(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgSeqvoucher_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgSeqvoucher.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgSeqvoucher.CurrentCell.ColumnIndex < dgSeqvoucher.ColumnCount - 1 Then
                SendKeys.Send("{Tab}")
            Else
                dgSeqvoucher.Rows.Add()
                dgSeqvoucher.CurrentCell = dgSeqvoucher(0, dgSeqvoucher.CurrentCell.RowIndex)
            End If
        End If
    End Sub

    Private Sub dgSeqvoucher_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgSeqvoucher.KeyUp
        Try
            If e.KeyCode = Keys.F3 And dgSeqvoucher.CurrentCell.ColumnIndex = 3 And dgSeqvoucher.CurrentCell.RowIndex > 0 Then
                dgSeqvoucher(3, dgSeqvoucher.CurrentCell.RowIndex).Value = dgSeqvoucher(3, dgSeqvoucher.CurrentCell.RowIndex - 1).Value
            End If
            If e.KeyCode = Keys.F4 And dgSeqvoucher.CurrentCell.ColumnIndex = 3 Then
                Dim nl As New frmNarrationlist
                nl.ShowDialog()
                dgSeqvoucher(3, dgSeqvoucher.CurrentCell.RowIndex).Value = nl.ComboBox1.Text
            End If
        Catch ex As Exception
            dgSeqvoucher.Focus()
        End Try
    End Sub

    Private Sub dgSeqvoucher_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSeqvoucher.RowEnter
        sumdrcr()
        Dim r, pr As Integer
        r = e.RowIndex
        If r = 0 Then
            dgSeqvoucher(0, r).Value = 1
        Else
            pr = r - 1
            dgSeqvoucher(0, r).Value = dgSeqvoucher(0, pr).Value + 1
        End If
        sumdrcr()
    End Sub
    Sub sumdrcr()
        Try
            Dim i As Integer
            Dim dramt, cramt As Double
            For i = 0 To dgSeqvoucher.Rows.Count - 1
                If Len(dgSeqvoucher(6, i).Value) > 0 Then
                    If dgSeqvoucher(6, i).Value = "Dr" Then
                        dramt = dramt + dgSeqvoucher(5, i).Value
                    Else
                        cramt = cramt + dgSeqvoucher(5, i).Value
                    End If
                End If
            Next
            lblcrsum.Text = cramt
            lbldrsum.Text = dramt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.ValueChanged
        'SetLastVouDate()
        If btnsave.Enabled = True Then
            GMod.DataSetRet("select getdate()", "serverdate")

            dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-GMod.nofd)
            dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        dgSeqvoucher.Rows.Clear()
        dgSeqvoucher.Rows.Add()
        btnsave.Enabled = True
        btnmodify.Text = "&Modify"
        'If (cmbvtype.Text <> "PAYMENT" Or cmbvtype.Text = "RECEIPT" Or cmbvtype.Text = "JOURNAL") Then cmbvtype.Enabled = True
        cmbvtype.Enabled = True
        'nxtvno()
        dgSeqvoucher.Focus()
    End Sub
    Private Function SingleEntry() As Boolean
        If btnsave.Enabled = False Then
            GMod.Fill_Log(GMod.Cmpid, lblvouno.Text, cmbvtype.Text, dtvdate.Value, Now, GMod.Session, "M", GMod.username)
        End If

        Dim i As Integer
        Dim sqltrans As SqlClient.SqlTransaction
        Dim paymod, Group_name, Sub_group_name, SqlGrpsubgrp As String
        Dim varcr, vardr, eid, c, d As Double
        sqltrans = GMod.SqlConn.BeginTransaction
        d = -1
        c = 0
        nxtvno()
        Try
            Dim sqlsave As String = ""
            'save voucher entry
            For i = 0 To dgSeqvoucher.Rows.Count - 1
                If Len(dgSeqvoucher(1, i).Value) <> 0 Then
                    If Len(dgSeqvoucher(1, i).Value) > 0 Then 'check for account head code is empaty
                        If Len(dgSeqvoucher(4, i).Value) > 0 Then 'check for  paymod
                            paymod = "CHEQUE"
                        Else
                            paymod = "CASH"
                        End If 'for paymode

                        If dgSeqvoucher(6, i).Value.ToString = "Dr" Then 'check for  paymod
                            vardr = dgSeqvoucher(5, i).Value
                            varcr = 0
                        Else
                            varcr = dgSeqvoucher(5, i).Value
                            vardr = 0
                        End If 'for paymode

                        eid = CDbl(dgSeqvoucher(0, i).Value)
                        'Getting Group and sub gropu from Acc_head table on basis of Acc_code
                        'Code by krishna 
                        If CheckBox4.Checked = False Then
                            SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & dgSeqvoucher(1, i).Value & "'"
                            GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
                            Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
                            Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)

                            sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                            sqlsave += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                            sqlsave += ") values ( "
                            sqlsave += "'" & GMod.Cmpid & "','" & GMod.username & "'," & eid & ",'" & lblvouno.Text & "',"
                            sqlsave += "'" & cmbvtype.Text & "','" & dtvdate.Value.ToShortDateString & "','" & dgSeqvoucher(1, i).Value & "','" & dgSeqvoucher(2, i).Value & "'," & Val(vardr) & "," & Val(varcr) & ","
                            sqlsave += "'" & paymod & "','" & dgSeqvoucher(4, i).Value & "','" & dgSeqvoucher(3, i).Value.ToString.ToUpper & "','" & Group_name & "',"
                            sqlsave += "'" & Sub_group_name & "')"
                            GMod.ds.Tables("Grp_Sub").Clear()
                        Else
                            sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                            sqlsave += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration"
                            sqlsave += ") values ( "
                            sqlsave += "'" & GMod.Cmpid & "','" & GMod.username & "'," & eid & ",'" & lblvouno.Text & "',"
                            sqlsave += "'" & cmbvtype.Text & "','" & dtvdate.Value.ToShortDateString & "','" & dgSeqvoucher(1, i).Value & "','" & dgSeqvoucher(2, i).Value & "'," & Val(vardr) & "," & Val(varcr) & ","
                            sqlsave += "'" & paymod & "','" & dgSeqvoucher(4, i).Value & "','" & dgSeqvoucher(3, i).Value.ToString.ToUpper & "')"
                        End If
                    End If
                    Dim cmd2 As New SqlClient.SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd2.ExecuteNonQuery()
                End If
            Next
            sqltrans.Commit()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, GMod.Cmpname)
            sqltrans.Rollback()
            Return False
        End Try
        GMod.ds.Tables.Clear()
    End Function
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        If SingleEntry() = True Then
            MsgBox(cmbvtype.Text & "/" & lblvouno.Text)
            lblvouno.Text = ""
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub dgSeqvoucher_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSeqvoucher.CellClick
        If MessageBox.Show("WANT TO ADD A ROW", "ADD ROW", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            Try
                If MessageBox.Show("(YES)-FOR ABOVE THIS ROW, (NO)-FOR BELOE THIS ROW", "ADD ROW", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    ' MsgBox(e.RowIndex)
                    dgSeqvoucher.Rows.Insert(e.RowIndex)
                Else
                    'MsgBox(e.RowIndex)
                    dgSeqvoucher.Rows.Insert(e.RowIndex + 1)
                End If
                fillseqo()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    

    Private Sub cmbvtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype.SelectedIndexChanged
        If btnsave.Enabled = True Then
            Try
                cmbvtype_Leave(sender, e)
                Label1.Text = "Voucher Entry - " & cmbvtype.Text
                'nxtvno()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmbvtype_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype.Leave
        If cmbvtype.Text = "" Then Exit Sub
        If cmbvtype.FindStringExact(cmbvtype.Text) = -1 Then
            MsgBox("Incorrect voucher type", MsgBoxStyle.Critical)
            cmbvtype.Focus()
        Else
            Dim sqlvouseq As String
            sqlvouseq = "select Vou_no_seq  from dbo.Vtype where vtype='" & cmbvtype.Text & "' AND cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sqlvouseq, "Vou_Seq")
            If GMod.ds.Tables("vou_seq").Rows.Count > 0 Then lblvouseq.Text = GMod.ds.Tables("Vou_Seq").Rows(0)(0)
            ' nxtvno()
        End If
    End Sub
    Private Sub cmbvtype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvtype.KeyDown
        If e.KeyCode = Keys.Enter Then dtvdate.Focus()
    End Sub

    Private Sub dtvdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtvdate.KeyDown
        If e.KeyCode = Keys.Enter Then dgSeqvoucher.Focus()
    End Sub
    Public Sub fillseqo()
        Dim i As Integer
        For i = 0 To dgSeqvoucher.Rows.Count - 1
            dgSeqvoucher(0, i).Value = i + 1
        Next
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
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
                ' Exit Sub
            End If
            Dim F As Integer
            Dim sql As String
            'If Not (cmbvtype.Text = "PAYMENT" Or cmbvtype.Text = "RECEIPT") Then
            sql = "select * from " & GMod.VENTRY & " where vou_no='" & r.txtvouno.Text & "'"
            sql += " and vou_type='" & r.cmbvtype.Text & "' order by entry_id"
            GMod.DataSetRet(sql, "ser")
            If GMod.ds.Tables("ser").Rows.Count > 0 Then
                If dgSeqvoucher.Rows.Count > 0 Then dgSeqvoucher.Rows.Clear()
                cmbvtype.Text = GMod.ds.Tables("ser").Rows(0)("vou_type")
                dtvdate.MinDate = GMod.ds.Tables("ser").Rows(0)("vou_date")
                lblvouno.Text = GMod.ds.Tables("ser").Rows(0)("vou_no")
                For i = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                    dgSeqvoucher.Rows.Add()
                    dgSeqvoucher(0, i).Value = i + 1
                    dgSeqvoucher(1, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head_code")
                    dgSeqvoucher(2, i).Value = GMod.ds.Tables("ser").Rows(i)("acc_head")
                    dgSeqvoucher(3, i).Value = GMod.ds.Tables("ser").Rows(i)("narration")
                    dgSeqvoucher(4, i).Value = GMod.ds.Tables("ser").Rows(i)("cheque_no")
                    If GMod.ds.Tables("ser").Rows(i)("dramt") > 0 Then
                        dgSeqvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("dramt")
                        dgSeqvoucher(6, i).Value = "Dr"
                    Else
                        dgSeqvoucher(5, i).Value = GMod.ds.Tables("ser").Rows(i)("cramt")
                        dgSeqvoucher(6, i).Value = "Cr"
                    End If
                Next
                F = 1
                'End If
                '--For Inventory---------------------
                'Dim sqlinv As String, sqlsave As String
                'sqlinv = "select * from " & GMod.INVENTORY & " where Vou_no=" & lblvouno.Text & " and Vou_type='" & cmbvtype.Text & "'"
                'GMod.DataSetRet(sqlinv, "Invtab")
                'If GMod.ds.Tables("Invtab").Rows.Count > 0 Then
                '    InventoryFound = True
                '    sqlsave = "  insert into tmpInvinfo  " _
                '   & " select Cmp_id," & GMod.username & ", Vou_no, Vou_type, Vou_date, " _
                '   & " Acc_head_code, Acc_head, ItemName, Qty, QtyNos, Unit, " _
                '   & " Rate, Amount, Free_Qty, BillType, BillNo, BillDate,  " _
                '   & "AreaCode from " & GMod.INVENTORY & " where Vou_no=" & lblvouno.Text & " and Vou_type='" & cmbvtype.Text & "'"
                'End If
            End If
            If F = 1 Then
                btnsave.Enabled = False

                btnmodify.Text = "&Update"
                cmbvtype.Enabled = False

            Else
                MsgBox("Invalid Voucher No", MsgBoxStyle.Critical)
            End If
        Else
            Dim sqldel, res As String
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

            '-------------------------------------------------------------------------------------------------------
            If btnsave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, lblvouno.Text, cmbvtype.Text, dtvdate.Value, Now, GMod.Session, "M", GMod.username)
            End If

            Dim i As Integer
            Dim sqltrans As SqlClient.SqlTransaction
            Dim paymod, Group_name, Sub_group_name, SqlGrpsubgrp As String
            Dim varcr, vardr, eid, c, d As Double
            sqltrans = GMod.SqlConn.BeginTransaction

            'sqldel = "Delete from " & GMod.INVENTORY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'"
            'Dim cmd1 As New SqlClient.SqlCommand(sqldel, GMod.SqlConn, sqltrans)
            'cmd1.ExecuteNonQuery()
            sqldel = "Delete from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'"
            Dim cmd0 As New SqlClient.SqlCommand(sqldel, GMod.SqlConn, sqltrans)
            cmd0.ExecuteNonQuery()

            d = -1
            c = 0
            Try
                Dim sqlsave As String = ""
                'save voucher entry
                For i = 0 To dgSeqvoucher.Rows.Count - 1
                    If Len(dgSeqvoucher(1, i).Value) <> 0 Then
                        If Len(dgSeqvoucher(1, i).Value) > 0 Then 'check for account head code is empaty
                            If Len(dgSeqvoucher(4, i).Value) > 0 Then 'check for  paymod
                                paymod = "-"
                            Else
                                paymod = "-"
                            End If 'for paymode

                            If dgSeqvoucher(6, i).Value.ToString = "Dr" Then 'check for  paymod
                                vardr = dgSeqvoucher(5, i).Value
                                varcr = 0
                            Else
                                varcr = dgSeqvoucher(5, i).Value
                                vardr = 0
                            End If 'for paymode

                            eid = CDbl(dgSeqvoucher(0, i).Value)
                            'Getting Group and sub gropu from Acc_head table on basis of Acc_code
                            'Code by krishna 
                            If CheckBox4.Checked = False Then
                                SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & dgSeqvoucher(1, i).Value & "'"
                                GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
                                Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
                                Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)

                                sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                                sqlsave += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                                sqlsave += ") values ( "
                                sqlsave += "'" & GMod.Cmpid & "','" & GMod.username & "'," & eid & ",'" & lblvouno.Text & "',"
                                sqlsave += "'" & cmbvtype.Text & "','" & dtvdate.Value.ToShortDateString & "','" & dgSeqvoucher(1, i).Value & "','" & dgSeqvoucher(2, i).Value & "'," & Val(vardr) & "," & Val(varcr) & ","
                                sqlsave += "'-','" & dgSeqvoucher(4, i).Value & "','" & dgSeqvoucher(3, i).Value.ToString.ToUpper & "','" & Group_name & "',"
                                sqlsave += "'" & Sub_group_name & "')"

                                GMod.ds.Tables("Grp_Sub").Clear()
                            Else
                                sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                                sqlsave += "acc_head_code,Acc_head, dramt, cramt,Pay_mode, Cheque_no, Narration"
                                sqlsave += ") values ( "
                                sqlsave += "'" & GMod.Cmpid & "','" & GMod.username & "'," & eid & ",'" & lblvouno.Text & "',"
                                sqlsave += "'" & cmbvtype.Text & "','" & dtvdate.Value.ToShortDateString & "','" & dgSeqvoucher(1, i).Value & "','" & dgSeqvoucher(2, i).Value & "'," & Val(vardr) & "," & Val(varcr) & ","
                                sqlsave += "'-','" & dgSeqvoucher(4, i).Value & "','" & dgSeqvoucher(3, i).Value.ToString.ToUpper & "')"

                            End If
                        End If
                        Dim cmd2 As New SqlClient.SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                        cmd2.ExecuteNonQuery()
                    End If
                Next

                sqltrans.Commit()
                btnsave.Enabled = True
                dtvdate.Enabled = True
                btnmodify.Text = "&Modify"
                cmbvtype.Enabled = True
                MsgBox("Voucher Modified")
                dgSeqvoucher.Rows.Clear()
                dgSeqvoucher.Rows.Add()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, GMod.Cmpname)
                sqltrans.Rollback()
            End Try
            GMod.ds.Tables.Clear()

            '-----------------------------------------------------------------------------------------------------------
        End If
    End Sub
    Dim t As New frmCRVoucherNarration
    Private Sub dgSeqvoucher_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSeqvoucher.CellEnter
        If e.ColumnIndex = 3 And cmbvtype.Text <> "CR VOUCHER" Then
            frmnarrationlistobj.txtNarrationEntrty.Text = dgSeqvoucher(3, dgSeqvoucher.CurrentCell.RowIndex).Value
            frmnarrationlistobj.ShowDialog()
            dgSeqvoucher(3, dgSeqvoucher.CurrentCell.RowIndex).Value = frmnarrationlistobj.txtNarrationEntrty.Text
            'for CR Voucher 
        ElseIf cmbvtype.Text = "CR VOUCHER" And e.ColumnIndex = 3 Then
            t.ShowDialog()
            dgSeqvoucher(3, dgSeqvoucher.CurrentCell.RowIndex).Value = t.TextBox1.Text
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If btnsave.Enabled Then
            btnmodify_Click(sender, e)
        Else
            GMod.DataSetRet("select max(vou_no) from " & GMod.VENTRY & " where vou_date = '" & dtvdate.Value.ToShortDateString & "'", "lvou")
            If lblvouno.Text = GMod.ds.Tables("lvou").Rows(0)(0) Then
                If MsgBox("Are u sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    MsgBox(GMod.SqlExecuteNonQuery("delete from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "'"))
                End If
            Else
                MsgBox("Only last voucher " & GMod.ds.Tables("lvou").Rows(0)(0) & " can be deleted", MsgBoxStyle.Critical, "Error")
            End If
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        Dim tg As New frmGeneralacchead
        tg.ShowDialog()
        CheckBox1.Checked = False
    End Sub
    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        Dim t1 As New frmPartyaccount
        Dim sql As String
        sql = "select Group_name,Suffix from Groups where Group_name like '%PARTY%' and Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "Suffix")

        t1.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t1.lblgroupname.DisplayMember = "Group_name"

        t1.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t1.lblgroupsuffix.DisplayMember = "Suffix"
        t1.lblgroupsuffix.Text = "PA"
        t1.Label1.Text = "Party Account Heads"
        t1.ShowDialog()
        CheckBox2.Checked = False
    End Sub

    Private Sub txtSearth_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearth.Leave
        Dim cr, i As Integer
        Dim chk As Integer = 0
        If txtSearth.Text = "" Then
            MsgBox("Please type related informatin for search", MsgBoxStyle.Critical)
            txtSearth.Focus()
            Exit Sub
        End If
        cr = dgSeqvoucher.CurrentCell.RowIndex + 1
        For i = cr To dgSeqvoucher.RowCount - 1
            If InStr(dgSeqvoucher(2, i).Value, txtSearth.Text) > 0 Then
                dgSeqvoucher.CurrentCell = dgSeqvoucher(2, i)
                chk = 1
                Exit For
            End If
        Next
    End Sub

    Private Sub txtSearth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearth.TextChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = False Then
            lblvouno.Enabled = True
        Else
            lblvouno.Enabled = False
        End If
    End Sub

    Private Sub dgSeqvoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSeqvoucher.CellContentClick

    End Sub
End Class