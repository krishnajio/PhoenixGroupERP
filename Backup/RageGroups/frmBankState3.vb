Public Class frmBankState3

    Private Sub cmbacccode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacccode.SelectedIndexChanged
        GMod.DataSetRet("select * from " & GMod.BANK_STATE_OPEN & " where bank_acc_code='" & cmbacccode.Text & "'", "bopen")
        If GMod.ds.Tables("bopen").Rows.Count > 0 Then
            If GMod.ds.Tables("bopen").Rows(0)(1) > 0 Then
                lblopen.Text = GMod.ds.Tables("bopen").Rows(0)(1)
            Else
                lblopen.Text = -1 * GMod.ds.Tables("bopen").Rows(0)(2)
            End If
        Else
            lblopen.Text = "0"
        End If
        filldata()
    End Sub
    Sub filldata()
        Dim sql As String
        sql = "select bankedate,chddno,dramt,cramt,entryid,IssueDate from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacccode.Text & "' order by bankedate,entryid"
        GMod.DataSetRet(sql, "fillstate")
        Dim i As Integer
        Dim dt1(3) As String
        dgbankstate.Rows.Clear()
        ' MsgBox(GMod.ds.Tables("fillstate").Rows.Count)
        For i = 0 To GMod.ds.Tables("fillstate").Rows.Count - 1
            dgbankstate.Rows.Add()
            dt1 = GMod.ds.Tables("fillstate").Rows(i)(0).ToString().Split("/")
            dgbankstate(0, i).Value = dt1(1) & "/" & dt1(0) & "/" & dt1(2).Remove(5, 11)
            dgbankstate(1, i).Value = GMod.ds.Tables("fillstate").Rows(i)(1).ToString()
            dgbankstate(2, i).Value = GMod.ds.Tables("fillstate").Rows(i)(2).ToString()
            dgbankstate(3, i).Value = GMod.ds.Tables("fillstate").Rows(i)(3).ToString()

            If GMod.ds.Tables("fillstate").Rows(i)("dramt") > 0 And CDate(GMod.ds.Tables("fillstate").Rows(i)(5).ToString()) <> CDate("1900-01-01") Then
                dgbankstate(5, i).Value = CDate(GMod.ds.Tables("fillstate").Rows(i)(5).ToString())
            ElseIf GMod.ds.Tables("fillstate").Rows(i)("cramt") > 0 And CDate(GMod.ds.Tables("fillstate").Rows(i)(5).ToString()) <> CDate("1900-01-01") Then
                dgbankstate(5, i).Value = CDate(GMod.ds.Tables("fillstate").Rows(i)(5).ToString())
            Else
                dgbankstate(5, i).Value = " "
            End If
            dgbankstate(6, i).Value = GMod.ds.Tables("fillstate").Rows(i)("entryid").ToString()
            'dgbankstate(7, i).Value = GMod.ds.Tables("fillstate").Rows(i)("voucher_no").ToString()
        Next
        If GMod.ds.Tables("fillstate").Rows.Count = 0 Then
            dgbankstate.Rows.Add()
        End If
        reclac()
        dgbankstate.CurrentCell=dgbankstate(0,dgbankstate.Rows.Count-1)
        dgbankstate.Focus()
    End Sub

    Private Sub frmBankState3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        Try
            GMod.ds.Tables.Clear()
            GMod.DataSetRet("select account_head_name,account_code from " & GMod.ACC_HEAD & " where Group_name='BANK'", "bankacchead")
            cmbacchead.DataSource = GMod.ds.Tables("bankacchead")
            cmbacchead.DisplayMember = "account_head_name"
            cmbacccode.DataSource = GMod.ds.Tables("bankacchead")
            cmbacccode.DisplayMember = "account_code"
            Dim r As Integer
            dgbankstate.Rows.Add()
            r = dgbankstate.Rows.Count - 1
            dgbankstate.CurrentCell = dgbankstate(0, r)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgbankstate_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbankstate.CellContentClick

    End Sub

    Private Sub dgbankstate_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbankstate.CellEndEdit
        updatedata()
    End Sub

    Private Sub dgbankstate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgbankstate.KeyDown
        Try
            'MsgBox(dgbankstate(6, dgbankstate.CurrentCell.RowIndex - 1).Value & "  " & ei - 1)
            If e.KeyCode = Keys.Enter Then
                Dim r, c, tr As Integer
                If dgbankstate.CurrentCell.ColumnIndex < dgbankstate.ColumnCount - 2 Then
                    SendKeys.Send("{Tab}")
                    'moving tab in current row
                    If dgbankstate.CurrentCell.RowIndex <> dgbankstate.Rows.Count - 1 Then
                        dgbankstate.CurrentCell = dgbankstate(dgbankstate.CurrentCell.ColumnIndex, dgbankstate.CurrentCell.RowIndex - 1)
                    End If
                    'update existing row
                Else

                    If dgbankstate.CurrentCell.RowIndex = dgbankstate.Rows.Count - 1 Then
                        dgbankstate.Rows.Add()
                        dgbankstate.CurrentCell = dgbankstate(0, dgbankstate.CurrentCell.RowIndex)
                        'save privious row
                        savedata()
                        dgbankstate(0, dgbankstate.CurrentCell.RowIndex + 1).Value = dgbankstate(0, dgbankstate.CurrentCell.RowIndex).Value
                    End If
                End If
            ElseIf e.KeyCode = Keys.Delete Then
                If Val(dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
                    MsgBox(GMod.SqlExecuteNonQuery("delete from " & GMod.BANK_STATE & " where entryid=" & Val(dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value) & " and bank_acc_code='" & cmbacccode.Text & "'"))
                End If
                End If

        Catch ex As Exception
        End Try
        
    End Sub

    Private Sub dgbankstate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgbankstate.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim r, c, tr As Integer
            If dgbankstate.CurrentCell.ColumnIndex < dgbankstate.ColumnCount - 2 Then
                'moving tab in current row
                If dgbankstate.CurrentCell.RowIndex <> dgbankstate.Rows.Count - 1 Then
                    dgbankstate.CurrentCell = dgbankstate(dgbankstate.CurrentCell.ColumnIndex, dgbankstate.CurrentCell.RowIndex)
                End If
            Else
                If dgbankstate.CurrentCell.RowIndex <> dgbankstate.Rows.Count - 1 Then
                    dgbankstate.CurrentCell = dgbankstate(0, dgbankstate.CurrentCell.RowIndex + 1)
                End If

                'update existing row
            End If
            End If
    End Sub
    Private Sub reclac()
        Dim i As Integer
        Dim curbal As Double
        curbal = Val(lblopen.Text)
        For i = 0 To dgbankstate.Rows.Count - 1
            dgbankstate(4, i).Value = Val(curbal) - Val(dgbankstate(2, i).Value) + Val(dgbankstate(3, i).Value)
            curbal = Val(curbal) - Val(dgbankstate(2, i).Value) + Val(dgbankstate(3, i).Value)
        Next
    End Sub
    Sub updatedata()
        Dim dt1(), paymod, sql, tdt As String
        Dim edt As Date
        Dim eid As Long

        'update information

        Try
            If Val(dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value) = 0 Then
                Exit Sub
            End If
            Dim ur As Integer
            '  If dgbankstate.CurrentCell.RowIndex < tot_rec Then
            ur = dgbankstate.CurrentCell.RowIndex + 1
            If Val(dgbankstate(0, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
                dt1 = dgbankstate(0, dgbankstate.CurrentCell.RowIndex).Value.ToString().Split("/")
                edt = dt1(1) & "/" & dt1(0) & "/" & dt1(2)
            End If
            If Val(dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value) > 0 Or dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value = "CHARGES" Then
                paymod = "CHEQUE"
            Else
                paymod = "CASH"
            End If
            '----------update cheque date ------------
            tdt = "1900/1/1"
            'If Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) <> 0 Then
            '    If Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
            '        sql = "select * from " & GMod.VENTRY & " where " _
            '        & " cheque_no='" & dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value & "'" _
            '        & " and cramt=" & Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value)
            '    ElseIf Val(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
            '        sql = "select * from " & GMod.VENTRY & " where " _
            '        & " cheque_no='" & dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value & "'" _
            '        & " and dramt=" & Val(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value)
            '    End If
            '    GMod.DataSetRet(sql, "check_ghqdt")
            '    If GMod.ds.Tables("check_ghqdt").Rows.Count > 0 Then
            '        dgbankstate(5, dgbankstate.CurrentCell.RowIndex).Value = GMod.ds.Tables("check_ghqdt").Rows(0)("ch_issue_date")
            '        If Len(GMod.ds.Tables("check_ghqdt").Rows(0)("ch_issue_date").ToString) > 0 Then
            '            tdt = GMod.ds.Tables("check_ghqdt").Rows(0)("ch_issue_date").ToString
            '        End If

            '    End If
            'End If
            '--------------------------------------------------------------------
            sql = "update " & GMod.BANK_STATE & " set bankedate='" & edt & "'," _
            & "paytype='" & paymod & "',chddno='" & dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value & "'," _
            & "dramt='" & Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) & "'," _
            & "cramt='" & Val(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value) & "',issuedate='" & CDate(tdt) & "'," _
            & "voucher_no=''" _
            & " where entryid=" & dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value & " and bank_acc_code='" & cmbacccode.Text & "'"
            GMod.SqlExecuteNonQuery(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        reclac()
    End Sub
    Sub savedata()
        Try
            If Len(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) > 0 Or Len(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
                Dim dt1(), paymod, sql, tdt As String
                Dim edt As Date
                Dim eid As Long
                'check entry id is existed or not
                If Val(dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then

        
                Else
                    'calculate entry id
                    GMod.DataSetRet("select isnull(max(entryid),0)+1 from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacccode.Text & "'", "lastid")
                    eid = GMod.ds.Tables("lastid").Rows(0)(0)
                    dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value = eid
                    '----------update cheque date ------------
                    tdt = "1900/1/1"
                    'If Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) <> 0 Then
                    '    If Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
                    '        sql = "select * from " & GMod.VENTRY & " where " _
                    '        & " cheque_no='" & dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value & "'" _
                    '        & " and cramt=" & Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value)
                    '    ElseIf Val(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
                    '        sql = "select * from " & GMod.VENTRY & " where " _
                    '        & " cheque_no='" & dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value & "'" _
                    '        & " and dramt=" & Val(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value)
                    '    End If
                    '    GMod.DataSetRet(sql, "check_ghqdt")
                    '    If GMod.ds.Tables("check_ghqdt").Rows.Count > 0 Then
                    '        dgbankstate(5, dgbankstate.CurrentCell.RowIndex).Value = GMod.ds.Tables("check_ghqdt").Rows(0)("ch_issue_date")
                    '        If Len(GMod.ds.Tables("check_ghqdt").Rows(0)("ch_issue_date").ToString) > 0 Then
                    '            tdt = GMod.ds.Tables("check_ghqdt").Rows(0)("ch_issue_date").ToString
                    '        End If

                    '    End If
                    'End If
                    ''-------------save data -----------
                    If Val(dgbankstate(0, dgbankstate.CurrentCell.RowIndex).Value.ToString) > 0 Then
                        dt1 = dgbankstate(0, dgbankstate.CurrentCell.RowIndex).Value.ToString().Split("/")
                        edt = dt1(1) & "/" & dt1(0) & "/" & dt1(2)
                    End If

                    If Len(dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
                        paymod = "CHEQUE"
                    Else
                        paymod = "CASH"
                    End If

                    
                    sql = "insert into " & GMod.BANK_STATE & " (Cmp_id, Entryid, bank_acc_code, bankedate, paytype, chddno, dramt, cramt,detail,IssueDate) values ("
                    sql &= "'" & GMod.Cmpid & "',"
                    sql &= "'" & dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value & "',"
                    sql &= "'" & cmbacccode.Text & "',"
                    sql &= "'" & edt & "',"
                    sql &= "'" & paymod & "',"
                    sql &= "'" & dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value & "',"
                    sql &= "'" & Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) & "',"
                    sql &= "'" & Val(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value) & "',"
                    sql &= "'-',"
                    sql &= "'" & CDate(tdt).ToShortDateString & "')"
                    GMod.SqlExecuteNonQuery(sql)
                End If
            End If
        Catch ex As Exception
            MsgBox("Entry Not Saved :" & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ''update entries from  bank book to statement
        'Dim i, j As Integer
        'Dim sql As String
        ''reconsile cheque entries
        'i = 0
        'Dim prchq As String
        'GMod.DataSetRet("select cheque_no,dramt,cramt,vou_type,vou_date,ch_issue_date,vou_no from " & GMod.VENTRY & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and acc_head_code='" & cmbacccode.Text & "' and len(cheque_no)>0 order by cheque_no", "chq_Rec")
        'GMod.SqlExecuteNonQuery("update " & GMod.BANK_STATE & " set voucher_no='' , issuedate='1900-1-1' where bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and bank_acc_code='" & cmbacccode.Text & "'")
        'While i < GMod.ds.Tables("chq_rec").Rows.Count
        '    If GMod.ds.Tables("chq_rec").Rows(i)("dramt") > 0 Then
        '        'search in bank statement cr side
        '        sql = "select * from " & GMod.BANK_STATE & " where chddno='" & GMod.ds.Tables("chq_rec").Rows(i)(0) & "'" _
        '        & " and cramt=" & GMod.ds.Tables("chq_rec").Rows(i)(1) & " and bank_acc_code='" & cmbacccode.Text & "' order by chddno"
        '    Else
        '        sql = "select * from " & GMod.BANK_STATE & " where chddno='" & GMod.ds.Tables("chq_rec").Rows(i)(0) & "'" _
        '        & " and dramt=" & GMod.ds.Tables("chq_rec").Rows(i)(2) & "  and bank_acc_code='" & cmbacccode.Text & "' order by chddno"
        '    End If
        '    GMod.DataSetRet(sql, "chq_bs")
        '    prchq = GMod.ds.Tables("chq_rec").Rows(i)("cheque_no")
        '    For j = 0 To GMod.ds.Tables("chq_bs").Rows.Count - 1
        '        If GMod.ds.Tables("chq_rec").Rows(i)("vou_type") = "CHQ ISSUED" Then
        '            GMod.SqlExecuteNonQuery("update " & GMod.BANK_STATE & " set  voucher_no='" & GMod.ds.Tables("chq_rec").Rows(i)("vou_no").ToString & "' , issuedate='" & GMod.ds.Tables("chq_rec").Rows(i)("ch_issue_date") & "' where bank_acc_code='" & cmbacccode.Text & "' and entryid=" & GMod.ds.Tables("chq_bs").Rows(j)("entryid"))
        '        Else
        '            GMod.SqlExecuteNonQuery("update " & GMod.BANK_STATE & " set voucher_no='" & GMod.ds.Tables("chq_rec").Rows(i)("vou_no").ToString & "' ,issuedate='" & GMod.ds.Tables("chq_rec").Rows(i)("vou_date") & "' where bank_acc_code='" & cmbacccode.Text & "' and entryid=" & GMod.ds.Tables("chq_bs").Rows(j)("entryid"))
        '        End If
        '        If i < GMod.ds.Tables("chq_rec").Rows.Count - 1 Then
        '            i = i + 1
        '            If prchq <> GMod.ds.Tables("chq_rec").Rows(i)("cheque_no") Then Exit For
        '        Else
        '            Exit While
        '        End If
        '    Next
        '    If GMod.ds.Tables("chq_bs").Rows.Count = 0 Then i = i + 1
        'End While
        ''reconsile amount
        'i = 0
        'GMod.DataSetRet("select cheque_no,dramt,cramt,vou_type,vou_date,ch_issue_date,vou_no from " & GMod.VENTRY & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and acc_head_code='" & cmbacccode.Text & "' and len(cheque_no)=0", "amt_Rec")
        'Dim pramt, cuamt As Double
        'Dim prdate As Date
        'While i < GMod.ds.Tables("amt_rec").Rows.Count
        '    If GMod.ds.Tables("amt_rec").Rows(i)("dramt") > 0 Then
        '        'search in bank statement cr side
        '        sql = "select * from " & GMod.BANK_STATE & " where bankedate='" & GMod.ds.Tables("amt_rec").Rows(i)("vou_date") & "'" _
        '        & " and cramt=" & GMod.ds.Tables("amt_rec").Rows(i)(1) & "  and bank_acc_code='" & cmbacccode.Text & "' order by bankedate,dramt,cramt"
        '    Else
        '        sql = "select * from " & GMod.BANK_STATE & " where bankedate='" & GMod.ds.Tables("amt_rec").Rows(i)("vou_date") & "'" _
        '        & " and dramt=" & GMod.ds.Tables("amt_rec").Rows(i)(2) & "  and bank_acc_code='" & cmbacccode.Text & "' order by bankedate,dramt,cramt"
        '    End If
        '    GMod.DataSetRet(sql, "amt_bs")
        '    prdate = GMod.ds.Tables("amt_rec").Rows(i)("vou_date")
        '    If GMod.ds.Tables("amt_rec").Rows(i)("dramt") > 0 Then
        '        pramt = GMod.ds.Tables("amt_rec").Rows(i)("dramt")
        '    Else
        '        pramt = GMod.ds.Tables("amt_rec").Rows(i)("cramt")
        '    End If

        '    For j = 0 To GMod.ds.Tables("amt_bs").Rows.Count - 1
        '        GMod.SqlExecuteNonQuery("update " & GMod.BANK_STATE & " set voucher_no='" & GMod.ds.Tables("amt_rec").Rows(i)("vou_no").ToString & "',issuedate='" & GMod.ds.Tables("amt_rec").Rows(i)("vou_date") & "' where bank_acc_code='" & cmbacccode.Text & "' and entryid=" & GMod.ds.Tables("amt_bs").Rows(j)("entryid"))
        '        If i < GMod.ds.Tables("amt_rec").Rows.Count - 1 Then
        '            i = i + 1
        '            If GMod.ds.Tables("amt_rec").Rows(i)("dramt") > 0 Then
        '                cuamt = GMod.ds.Tables("amt_rec").Rows(i)("dramt")
        '            Else
        '                cuamt = GMod.ds.Tables("amt_rec").Rows(i)("cramt")
        '            End If
        '            If pramt <> cuamt Then Exit For
        '        Else
        '            Exit While
        '        End If
        '    Next
        '    If GMod.ds.Tables("amt_bs").Rows.Count = 0 Then i = i + 1
        'End While

        'select all entries of bank state b/w dates
        Panel1.Visible = False
        Dim i, j As Integer
        Dim sql, res As String
        Dim vcount, bcount, dif As Integer
        If MsgBox("Do you want refill all the entries", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            GMod.SqlExecuteNonQuery("update " & GMod.BANK_STATE & " set issuedate='1900-1-1',voucher_no=0 where bankedate between '" & CDate(dtfrom1.Value.ToShortDateString) & "' and '" & CDate(dtto.Value.ToShortDateString) & "'")
            GMod.SqlExecuteNonQuery("update " & GMod.VENTRY & " set ch_date='1900-1-1' where vou_date between '" & CDate(dtfrom1.Value.ToShortDateString) & "' and '" & CDate(dtto.Value.ToShortDateString) & "'")
            GMod.SqlExecuteNonQuery("update " & GMod.CHQ_ISSUED & " set final_date='1900-1-1' where chq_date between '" & CDate(dtfrom1.Value.ToShortDateString) & "' and '" & CDate(dtto.Value.ToShortDateString) & "'")
        End If
        'select all cheque from bank statement 
        sql = "select bankedate,chddno,dramt,cramt,entryid from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacccode.Text & "'" _
        & " and bankedate between '" & CDate(dtfrom1.Value.ToShortDateString) & "' and '" & CDate(dtto.Value.ToShortDateString) & "' " _
         & " and paytype='CHEQUE' and issuedate='1900-1-1' order by bankedate"
        GMod.DataSetRet(sql, "chqselect")
        For i = 0 To GMod.ds.Tables("chqselect").Rows.Count - 1
            'If GMod.ds.Tables("chqselect").Rows(i)("entryid") = "95" Then
            'MsgBox("Aya")
            'End If
            Me.Text = "Cheque Reconcilation Dt. " & GMod.ds.Tables("chqselect").Rows(i)("bankedate") & " Entry id " & GMod.ds.Tables("chqselect").Rows(i)("entryid")
            'search entried of cheque into ventry
            sql = "select vou_date,vou_no,vou_type,ch_issue_date,cheque_no,dramt,cramt from " & GMod.VENTRY & " where acc_head_code='" & cmbacccode.Text & "' " _
            & " and cheque_no='" & GMod.ds.Tables("chqselect").Rows(i)("chddno") & "'" _
            & " and dramt=" & Val(GMod.ds.Tables("chqselect").Rows(i)("cramt")) & " and " _
            & " cramt=" & Val(GMod.ds.Tables("chqselect").Rows(i)("dramt")) & " and pay_mode='CHEQUE'  order by cheque_no"
            '& " and vou_date between '" & CDate(dtfrom1.Value.ToShortDateString) & "' and '" & CDate(dtto.Value.ToShortDateString) & "' " _
            GMod.DataSetRet(sql, "chqchk")
            vcount = GMod.ds.Tables("chqchk").Rows.Count
            'search entried of cheque into bank statement
            sql = "select * from " & GMod.BANK_STATE & " where " _
            & " bank_acc_code='" & cmbacccode.Text & "'" _
            & " and chddno='" & GMod.ds.Tables("chqselect").Rows(i)("chddno") & "'" _
            & " and cramt='" & GMod.ds.Tables("chqselect").Rows(i)("cramt") & "'" _
            & " and dramt='" & GMod.ds.Tables("chqselect").Rows(i)("dramt") & "' and paytype='CHEQUE' order by entryid"
            GMod.DataSetRet(sql, "bcount")
            bcount = GMod.ds.Tables("bcount").Rows.Count

            If vcount = 1 And bcount = 1 Then
                'updating bank state
                If GMod.ds.Tables("chqchk").Rows(0)("vou_type") = "CHQ ISSUED" Then
                    sql = "update " & GMod.BANK_STATE & " set " _
                    & "issuedate='" & GMod.ds.Tables("chqchk").Rows(0)("ch_issue_date") & "'," _
                    & "voucher_no='" & GMod.ds.Tables("chqchk").Rows(0)("vou_no") & "' where " _
                    & " bank_acc_code ='" & cmbacccode.Text & "' " _
                    & " and chddno='" & GMod.ds.Tables("chqchk").Rows(0)("cheque_no") & "' and " _
                    & "(dramt=" & Val(GMod.ds.Tables("chqchk").Rows(0)("cramt")) & " and cramt=" & Val(GMod.ds.Tables("chqchk").Rows(0)("dramt")) & ")"
                Else
                    sql = "update " & GMod.BANK_STATE & " set " _
                    & "issuedate='" & GMod.ds.Tables("chqchk").Rows(0)("vou_date") & "'," _
                    & "voucher_no='" & GMod.ds.Tables("chqchk").Rows(0)("vou_no") & "' where " _
                    & " bank_acc_code ='" & cmbacccode.Text & "' " _
                    & " and chddno='" & GMod.ds.Tables("chqchk").Rows(0)("cheque_no") & "' and " _
                    & "(dramt=" & Val(GMod.ds.Tables("chqchk").Rows(0)("cramt")) & " and cramt=" & Val(GMod.ds.Tables("chqchk").Rows(0)("dramt")) & ")"
                End If
                res = GMod.SqlExecuteNonQuery(sql)
                If res <> "SUCCESS" Then MsgBox("Error in Updation Bank State " & res)
                'update voucher entries
                sql = "update " & GMod.VENTRY & " set " _
                & " ch_date='" & GMod.ds.Tables("chqselect").Rows(i)("bankedate") & "'," _
                & " bank_eid='" & GMod.ds.Tables("chqselect").Rows(i)("entryid") & "' " _
                & " where acc_head_code='" & cmbacccode.Text & "' and " _
                & " cheque_no='" & GMod.ds.Tables("chqselect").Rows(i)("chddno") & "' and " _
                & "(dramt=" & Val(GMod.ds.Tables("chqselect").Rows(i)("cramt")) & " and cramt=" & Val(GMod.ds.Tables("chqselect").Rows(i)("dramt")) & ")"
                res = GMod.SqlExecuteNonQuery(sql)
                If res <> "SUCCESS" Then MsgBox("Error in Updation Our Bank Book " & res)
                'update cheque issued 
                sql = "update " & GMod.CHQ_ISSUED & " set " _
                & "final_date='" & GMod.ds.Tables("chqselect").Rows(i)("bankedate") & "'" _
                & " where bankacc_code ='" & cmbacccode.Text & "' and " _
                & " cheque_no='" & GMod.ds.Tables("chqselect").Rows(i)("chddno") & "' and" _
                & " (amount = " & Val(GMod.ds.Tables("chqselect").Rows(i)("cramt")) & " or " _
                & " amount = " & Val(GMod.ds.Tables("chqselect").Rows(i)("dramt")) & ")"
                res = GMod.SqlExecuteNonQuery(sql)
                If res <> "SUCCESS" Then MsgBox("Error in Updation Our Chque issued " & res)
                'multiple cheque in bank book
            ElseIf vcount > 1 Or bcount > 1 Then
                If vcount > bcount Then
                    dif = bcount
                Else
                    dif = vcount
                End If
                For j = 0 To dif - 1
                    'updating bank state
                    If GMod.ds.Tables("chqchk").Rows(0)("vou_type") = "CHQ ISSUED" Then
                        sql = "update " & GMod.BANK_STATE & " set " _
                        & "issuedate='" & GMod.ds.Tables("chqchk").Rows(0)("ch_issue_date") & "'," _
                        & "voucher_no='" & GMod.ds.Tables("chqchk").Rows(0)("vou_no") & "' where " _
                        & " bank_acc_code ='" & cmbacccode.Text & "' " _
                        & " and chddno='" & GMod.ds.Tables("chqchk").Rows(0)("cheque_no") & "' and " _
                        & "(dramt=" & Val(GMod.ds.Tables("chqchk").Rows(0)("cramt")) & " and cramt=" & Val(GMod.ds.Tables("chqchk").Rows(0)("dramt")) & ")" _
                        & " and entryid='" & GMod.ds.Tables("bcount").Rows(j)("entryid") & "'"
                    Else
                        sql = "update " & GMod.BANK_STATE & " set " _
                        & "issuedate='" & GMod.ds.Tables("chqchk").Rows(0)("vou_date") & "'," _
                        & "voucher_no='" & GMod.ds.Tables("chqchk").Rows(0)("vou_no") & "' where " _
                        & " bank_acc_code ='" & cmbacccode.Text & "' " _
                        & " and chddno='" & GMod.ds.Tables("chqchk").Rows(0)("cheque_no") & "' and " _
                        & "(dramt=" & Val(GMod.ds.Tables("chqchk").Rows(0)("cramt")) & " and cramt=" & Val(GMod.ds.Tables("chqchk").Rows(0)("dramt")) & ")" _
                        & " and entryid='" & GMod.ds.Tables("bcount").Rows(j)("entryid") & "'"
                    End If
                    res = GMod.SqlExecuteNonQuery(sql)
                    If res <> "SUCCESS" Then MsgBox("Error in Updation Bank State " & res)
                    'update voucher entries
                    sql = "update " & GMod.VENTRY & " set " _
                    & " ch_date='" & GMod.ds.Tables("chqselect").Rows(i)("bankedate") & "'," _
                    & " bank_eid='" & GMod.ds.Tables("chqselect").Rows(i)("entryid") & "' " _
                    & " where acc_head_code='" & cmbacccode.Text & "' and " _
                    & " cheque_no='" & GMod.ds.Tables("chqselect").Rows(i)("chddno") & "' and " _
                    & "(dramt=" & Val(GMod.ds.Tables("chqselect").Rows(i)("cramt")) & " and cramt=" & Val(GMod.ds.Tables("chqselect").Rows(i)("dramt")) & ")" _
                    & " and vou_no='" & GMod.ds.Tables("chqchk").Rows(j)("vou_no") & "'"
                    res = GMod.SqlExecuteNonQuery(sql)
                    If res <> "SUCCESS" Then MsgBox("Error in Updation Our Bank Book " & res)
                    'update cheque issued 
                    sql = "update " & GMod.CHQ_ISSUED & " set " _
                    & "final_date='" & GMod.ds.Tables("chqselect").Rows(i)("bankedate") & "'" _
                    & " where bankacc_code ='" & cmbacccode.Text & "' and " _
                    & " cheque_no='" & GMod.ds.Tables("chqselect").Rows(i)("chddno") & "' and" _
                    & " (amount = " & Val(GMod.ds.Tables("chqselect").Rows(i)("cramt")) & " or " _
                    & " amount = " & Val(GMod.ds.Tables("chqselect").Rows(i)("dramt")) & ")"
                    res = GMod.SqlExecuteNonQuery(sql)
                    If res <> "SUCCESS" Then MsgBox("Error in Updation Our Chque issued " & res)
                    If i = GMod.ds.Tables("chqselect").Rows.Count - 1 Then Exit Sub
                    i = i + 1
                Next
            End If
            GMod.ds.Tables("chqchk").Clear()
        Next





        'select all cash entries from bank statement
        sql = "select bankedate,dramt,cramt,entryid from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacccode.Text & "'" _
        & " and bankedate between '" & CDate(dtfrom1.Value.ToShortDateString) & "' and '" & CDate(dtto.Value.ToShortDateString) & "'" _
        & " and paytype='CASH' order by dramt,cramt"
        GMod.DataSetRet(sql, "amtselect")
        For i = 0 To GMod.ds.Tables("amtselect").Rows.Count - 1
            Me.Text = "Cash Reconcilation Dt. " & GMod.ds.Tables("amtselect").Rows(i)("bankedate") & " Entry Id : " & GMod.ds.Tables("amtselect").Rows(i)("entryid")
            'check entries of amount in ventry
            sql = "Select vou_date,vou_no,cramt,dramt from " & GMod.VENTRY & " where " _
            & " acc_head_code='" & cmbacccode.Text & "' and " _
            & " vou_date='" & GMod.ds.Tables("amtselect").Rows(i)("bankedate") & "' " _
            & " and cramt=" & Val(GMod.ds.Tables("amtselect").Rows(i)("dramt")) _
            & " and dramt=" & Val(GMod.ds.Tables("amtselect").Rows(i)("cramt")) & " and pay_mode='CASH' order by vou_date,vou_no,dramt,cramt"
            GMod.DataSetRet(sql, "amtchk")
            vcount = GMod.ds.Tables("amtchk").Rows.Count
            sql = "select * from " & GMod.BANK_STATE & " where " _
                        & " bank_acc_code='" & cmbacccode.Text & "'" _
                        & " and bankedate='" & GMod.ds.Tables("amtselect").Rows(i)("bankedate") & "'" _
                        & " and cramt='" & GMod.ds.Tables("amtselect").Rows(i)("cramt") & "'" _
                        & " and dramt='" & GMod.ds.Tables("amtselect").Rows(i)("dramt") & "' AND paytype='CASH' order by entryid"
            GMod.DataSetRet(sql, "bcount")
            bcount = GMod.ds.Tables("bcount").Rows.Count

            If vcount = 1 And bcount = 1 Then
                'update bank statement
                sql = "update " & GMod.BANK_STATE & " set " _
                & " issuedate='" & GMod.ds.Tables("amtchk").Rows(0)("vou_date") & "'," _
                & " voucher_no='" & GMod.ds.Tables("amtchk").Rows(0)("vou_no") & "' where " _
                & " bank_acc_code='" & cmbacccode.Text & "' and " _
                & " bankedate = '" & GMod.ds.Tables("amtchk").Rows(0)("vou_date") & "'" _
                & " and cramt=" & Val(GMod.ds.Tables("amtchk").Rows(0)("dramt")) _
                & " and dramt=" & Val(GMod.ds.Tables("amtchk").Rows(0)("cramt"))
                res = GMod.SqlExecuteNonQuery(sql)
                If res <> "SUCCESS" Then MsgBox("Error in Updation bank statement for cash " & res)
                'updating voucher entry
                sql = "update " & GMod.VENTRY & " set " _
                & " ch_date='" & GMod.ds.Tables("amtselect").Rows(i)("bankedate") & "'," _
                & " bank_eid='" & GMod.ds.Tables("amtselect").Rows(i)("entryid") & "' where " _
                & " acc_head_code='" & cmbacccode.Text & "' and " _
                & " vou_date = '" & GMod.ds.Tables("amtselect").Rows(i)("bankedate") & "' " _
                & " and cramt=" & Val(GMod.ds.Tables("amtselect").Rows(i)("dramt")) _
                & " and dramt=" & Val(GMod.ds.Tables("amtselect").Rows(i)("cramt"))
                res = GMod.SqlExecuteNonQuery(sql)
                If res <> "SUCCESS" Then MsgBox("Error in Updation bank statement for cash " & res)
            ElseIf vcount > 1 Or bcount > 1 Then
                If vcount > bcount Then
                    dif = bcount
                Else
                    dif = vcount
                End If
                For j = 0 To dif - 1
                    'update bank statement
                    sql = "update " & GMod.BANK_STATE & " set " _
                    & " issuedate='" & GMod.ds.Tables("amtchk").Rows(0)("vou_date") & "'," _
                    & " voucher_no='" & GMod.ds.Tables("amtchk").Rows(j)("vou_no") & "' where " _
                    & " bank_acc_code='" & cmbacccode.Text & "' and " _
                    & " bankedate = '" & GMod.ds.Tables("amtchk").Rows(0)("vou_date") & "'" _
                    & " and cramt=" & Val(GMod.ds.Tables("amtchk").Rows(0)("dramt")) _
                    & " and dramt=" & Val(GMod.ds.Tables("amtchk").Rows(0)("cramt")) _
                    & " and entryid='" & GMod.ds.Tables("bcount").Rows(j)("entryid") & "'"
                    res = GMod.SqlExecuteNonQuery(sql)
                    If res <> "SUCCESS" Then MsgBox("Error in Updation bank statement for cash " & res)
                    'updating voucher entry
                    sql = "update " & GMod.VENTRY & " set " _
                    & " ch_date='" & GMod.ds.Tables("amtselect").Rows(i)("bankedate") & "'," _
                    & " bank_eid='" & GMod.ds.Tables("amtselect").Rows(i)("entryid") & "' where " _
                    & " acc_head_code='" & cmbacccode.Text & "' and " _
                    & " vou_date = '" & GMod.ds.Tables("amtselect").Rows(i)("bankedate") & "' " _
                    & " and cramt=" & Val(GMod.ds.Tables("amtselect").Rows(i)("dramt")) _
                    & " and dramt=" & Val(GMod.ds.Tables("amtselect").Rows(i)("cramt")) _
                    & " and vou_no='" & GMod.ds.Tables("amtchk").Rows(j)("vou_no") & "'"
                    res = GMod.SqlExecuteNonQuery(sql)
                    If res <> "SUCCESS" Then MsgBox("Error in Updation bank statement for cash " & res)
                    If i = GMod.ds.Tables("amtselect").Rows.Count - 1 Then Exit Sub
                    i = i + 1
                Next
                ' i = i + Math.Abs(vcount - bcount) - 1
            End If
        Next
        Panel1.Visible = False
        MsgBox("Update Completed")
        filldata()
        Me.Text = GMod.Cmpname
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim cr, i As Integer
        Dim chk As Integer = 0
        If txtfind.Text = "" Then
            MsgBox("Please type related informatin for search", MsgBoxStyle.Critical)
            txtfind.Focus()
            Exit Sub
        End If
        cr = dgbankstate.CurrentCell.RowIndex + 1
        If rdchqno.Checked Then
            For i = cr To dgbankstate.RowCount - 1
                If InStr(dgbankstate(1, i).Value, txtfind.Text) > 0 Then
                    dgbankstate.CurrentCell = dgbankstate(1, i)
                    chk = 1
                    Exit For
                End If
            Next
        ElseIf rdamt.Checked Then
            For i = cr To dgbankstate.RowCount - 1
                If dgbankstate(2, i).Value = txtfind.Text Then
                    dgbankstate.CurrentCell = dgbankstate(2, i)
                    chk = 1
                    Exit For
                ElseIf dgbankstate(3, i).Value = txtfind.Text Then
                    dgbankstate.CurrentCell = dgbankstate(3, i)
                    chk = 1
                    Exit For
                End If
            Next
        Else
            For i = cr To dgbankstate.RowCount - 1
                'MsgBox(dgbankstate(0, i).Value)
                If Trim(dgbankstate(0, i).Value) = Trim(txtfind.Text) Then
                    dgbankstate.CurrentCell = dgbankstate(0, i)
                    chk = 1
                    Exit For
                End If
            Next
        End If

        If chk = 0 Then
            MsgBox("Not Found", MsgBoxStyle.Information)
            If MsgBox("Do u want search from begining", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                dgbankstate.CurrentCell = dgbankstate(0, 0)
            End If
        End If
    End Sub

    Private Sub dtfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfrom.ValueChanged
        filldata()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        dtfrom.Value = dtfrom.Value.AddDays(1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dtfrom.Value = dtfrom.Value.AddDays(-1)
    End Sub

    Private Sub cmbacchead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacchead.SelectedIndexChanged

    End Sub
End Class