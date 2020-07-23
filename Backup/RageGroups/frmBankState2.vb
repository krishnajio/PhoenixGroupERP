Public Class frmBankState2

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
    Sub filldata()
        Dim sql As String
        sql = "select bankedate,chddno,dramt,cramt,entryid,IssueDate,entryid from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacccode.Text & "' order by entryid,bankedate"
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
            If CDate(GMod.ds.Tables("fillstate").Rows(i)(5).ToString()) = CDate("1900-01-01") Then
                dgbankstate(5, i).Value = " "
            Else
                dgbankstate(5, i).Value = CDate(GMod.ds.Tables("fillstate").Rows(i)(5).ToString())
            End If
            dgbankstate(6, i).Value = GMod.ds.Tables("fillstate").Rows(i)(6).ToString()
        Next
        reclac()
        Try
            dgbankstate.CurrentCell = dgbankstate(0, dgbankstate.RowCount - 1)
        Catch ex As Exception

        End Try

        'If i > 0 Then dgbankstate.CurrentCell = dgbankstate(0, i)
        dgbankstate.Focus()
    End Sub

    Private Sub frmBankState2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub reclac()
        Dim i As Integer
        Dim curbal As Double
        curbal = Val(lblopen.Text)
        For i = 0 To dgbankstate.Rows.Count - 1
            dgbankstate(4, i).Value = Val(curbal) - Val(dgbankstate(2, i).Value) + Val(dgbankstate(3, i).Value)
            curbal = Val(curbal) - Val(dgbankstate(2, i).Value) + Val(dgbankstate(3, i).Value)
        Next
    End Sub

    Private Sub dgbankstate_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbankstate.CellEndEdit
        Dim ur As Integer
        Dim dt1(), edt, sql, paymod, tdt As String
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


        If Len(dgbankstate(5, dgbankstate.CurrentCell.RowIndex).Value) <= 1 Then
            tdt = "1900-01-01"
        Else
            tdt = dgbankstate(5, dgbankstate.CurrentCell.RowIndex).Value
        End If
        sql = "update " & GMod.BANK_STATE & " set bankedate='" & edt & "'," _
        & "paytype='" & paymod & "',chddno='" & dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value & "'," _
        & "dramt='" & Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) & "'," _
        & "cramt='" & Val(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value) & "'" _
        & " where entryid=" & ur & " and bank_acc_code='" & cmbacccode.Text & "'"
        'MsgBox(sql)
        GMod.SqlExecuteNonQuery(sql)
        'MsgBox("aya")
        'End If
    End Sub

    Private Sub dgbankstate_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbankstate.CellEnter
        Try
            If dgbankstate.CurrentCell.ColumnIndex = 0 Then
                If dgbankstate.RowCount > 1 Then dgbankstate(0, dgbankstate.CurrentCell.RowIndex).Value = dgbankstate(0, dgbankstate.CurrentCell.RowIndex - 1).Value
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub dgbankstate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgbankstate.KeyDown
        Try
            Dim dr As Integer
            If e.KeyCode = Keys.Delete Then
                dr = dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value
                MsgBox(GMod.SqlExecuteNonQuery("delete from " & GMod.BANK_STATE & " where entryid=" & Val(dr) & " and bank_acc_code='" & cmbacccode.Text & "'"))
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgbankstate_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbankstate.CellContentClick

    End Sub
    Dim tot_rec As Long
    Dim ei As Integer
    Private Sub dgbankstate_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbankstate.CellLeave
        Try
            If e.ColumnIndex = 4 Then
                reclac()
                Dim dt1(), paymod, sql As String
                Dim edt As Date
                '----------update cheque date ------------
                If Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) <> 0 Then
                    If Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
                        sql = "select * from " & GMod.VENTRY & " where " _
                        & " cheque_no='" & dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value & "'" _
                        & " and cramt=" & Val(dgbankstate(2, dgbankstate.CurrentCell.RowIndex).Value)
                    ElseIf Val(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
                        sql = "select * from " & GMod.VENTRY & " where " _
                        & " cheque_no='" & dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value & "'" _
                        & " and dramt=" & Val(dgbankstate(3, dgbankstate.CurrentCell.RowIndex).Value)
                    End If
                    GMod.DataSetRet(sql, "check_ghqdt")
                    If GMod.ds.Tables("check_ghqdt").Rows.Count > 0 Then
                        dgbankstate(5, dgbankstate.CurrentCell.RowIndex).Value = GMod.ds.Tables("check_ghqdt").Rows(0)("vou_date")
                    End If
                End If
                '-------------save data -----------

                If tot_rec = 0 Or tot_rec < Val(dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value) Then
                    If Val(dgbankstate(0, dgbankstate.CurrentCell.RowIndex).Value) > 0 Then
                        dt1 = dgbankstate(0, dgbankstate.CurrentCell.RowIndex).Value.ToString().Split("/")
                        edt = dt1(1) & "/" & dt1(0) & "/" & dt1(2)
                    End If

                    If Val(dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value) > 0 Or dgbankstate(1, dgbankstate.CurrentCell.RowIndex).Value = "CHARGES" Then
                        paymod = "CHEQUE"
                    Else
                        paymod = "CASH"
                    End If

                    Dim tdt As String
                    If Len(dgbankstate(5, dgbankstate.CurrentCell.RowIndex).Value) <= 1 Then
                        tdt = "1900-01-01"
                    Else
                        tdt = dgbankstate(5, dgbankstate.CurrentCell.RowIndex).Value
                    End If
                    'MsgBox(tdt)

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
                    ei = ei + 1

                End If
            ElseIf e.ColumnIndex = 0 Then
                'If dgbankstate.RowCount > 1 And dgbankstate.CurrentCell.RowIndex <> 0 Then dgbankstate(0, dgbankstate.CurrentCell.RowIndex).Value = dgbankstate(0, dgbankstate.CurrentCell.RowIndex - 1).Value

            End If ' end if auto save 

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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
        GMod.DataSetRet("select isnull(max(entryid),0) from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacccode.Text & "'", "trec")
            tot_rec = GMod.ds.Tables("trec").Rows(0)(0)
        ei = tot_rec
            filldata()
        If tot_rec = 0 Then dgbankstate.Rows.Add()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgbankstate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgbankstate.KeyUp
        Dim dr As Integer
        Try
            If e.KeyCode = Keys.Enter Then
                Dim r, c, tr As Integer
                If dgbankstate.CurrentCell.ColumnIndex < dgbankstate.ColumnCount - 2 Then
                    SendKeys.Send("{Tab}")
                Else
                    dgbankstate.Rows.Add()
                    dgbankstate.CurrentCell = dgbankstate(0, dgbankstate.CurrentCell.RowIndex + 1)
                    dgbankstate(6, dgbankstate.CurrentCell.RowIndex).Value = ei + 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgbankstate_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgbankstate.CellMouseClick

    End Sub
End Class