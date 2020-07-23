Imports System.Data.SqlClient
Public Class frmPurchaseChicken

    Private Sub frmPurchaseChicken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillArea()
        nxtvno()
       
        'Filling item list

        heads()
        Dim sqlitem As String
        sqlitem = "select * from ItemMaster where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlitem, "ITEM")
        Me.Particular.DataSource = GMod.ds.Tables("ITEM")
        Me.Particular.DisplayMember = "ItemName"
        dgPurchase.Rows.Add()
        If GMod.Getsession(dtVouDate.Value) = GMod.Session Then
        Else
            Me.Close()
        End If
    End Sub
    Sub nxtvno()
        Dim sql As String
        Try
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='PURCHASE'"
            GMod.DataSetRet(sql, "vno8")
            txtVoucherNo.Text = ds.Tables("vno8").Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
        'cmbAreaCode.Text = GMod.AreaCode
    End Sub
    Private Sub dgPurchase_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPurchase.CellContentClick

    End Sub
    Dim total As Double, i As Integer

    Private Sub dgPurchase_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPurchase.CellEndEdit
       
        Dim rate As Double
        If e.ColumnIndex = 3 Then
            If Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
                '    rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value)
                '    dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
                'ElseIf Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
                ' rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value)
                'Purchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)

            End If
        ElseIf e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 1 Then
            If Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
                '    rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value)
                '    dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
                'ElseIf Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
                rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value)
                dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
            End If
        End If
        For i = 0 To dgPurchase.Rows.Count - 1
            total = total + Val(dgPurchase(4, i).Value)
        Next
        txtTotal.Text = total.ToString
        total = 0
    End Sub

    Private Sub dgPurchase_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPurchase.CellEnter
        Dim amt As Double
        If e.ColumnIndex = 4 Then
            If Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
                amt = Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) * Val(dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value)
                amt = Math.Round(amt, 0, MidpointRounding.ToEven)
                dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value = amt
            Else
                amt = Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value) * Val(dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value)
                amt = Math.Round(amt, 0, MidpointRounding.ToEven)
                dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value = amt
            End If
        End If
    End Sub
    Private Sub dgPurchase_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPurchase.CellLeave
        For i = 0 To dgPurchase.Rows.Count - 1
            total = total + Val(dgPurchase(4, i).Value)
        Next
        txtTotal.Text = total.ToString
        total = 0

    End Sub

    Private Sub dgPurchase_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgPurchase.KeyUp
        If e.KeyCode = Keys.Enter Then

            If dgPurchase.CurrentCell.ColumnIndex < dgPurchase.ColumnCount - 1 Then
                SendKeys.Send("{Tab}")
            Else
                dgPurchase.Rows.Add()
                dgPurchase.CurrentCell = dgPurchase(0, dgPurchase.CurrentCell.RowIndex + 1)
            End If
        End If
    End Sub

    Private Sub txtbatch_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbatch.Leave
        If btnSave.Enabled = True Then
            lblbatchno.Text = cmbAreaCode.Text & txtbatch.Text
        End If
    End Sub

    Private Sub txtbatch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbatch.TextChanged
        lblbatchno.Text = cmbAreaCode.Text & txtbatch.Text
    End Sub

    Private Sub cnklock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklock.CheckedChanged

    End Sub

    Private Sub cnklock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklock.Click
        If chklock.Checked = True Then
            txtVoucherNo.ReadOnly = True
        Else
            txtVoucherNo.ReadOnly = False
        End If
    End Sub

    Private Sub txtTotal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.Leave

    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged
        'If btnSave.Enabled = True Then
        txtgtotal.Text = Val(txtTotal.Text) + Val(txtFreight.Text) - Val(txtComm.Text)
        'End If
    End Sub
    Dim DrAmt As Double
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Enabled = False Then
            GMod.Fill_Log(GMod.Cmpid, txtVoucherNo.Text, "PURCHASE", dtVouDate.Value, Now, GMod.Session, "M", GMod.username)
        End If
        If txtbatch.Text = "" Then
            MsgBox("Enter Batch No:")
            txtbatch.Focus()
            Exit Sub
        End If


        Dim sqlsave As String
        Dim sqltrans As SqlTransaction
        Dim narration, narrcust, narrinv As String
        sqltrans = GMod.SqlConn.BeginTransaction

        narration = "BILL NO " & txtInvnoNo.Text & " DT." & dtInvVate.Text & " BATCH NO " & lblbatchno.Text & " "
        Try
            For i = 0 To dgPurchase.Rows.Count - 1
                'narration = " "
                narration &= dgPurchase(0, i).Value
                If Val(dgPurchase(2, i).Value) > 0 And Val(dgPurchase(1, i).Value) > 0 Then
                    narration &= " " & dgPurchase(2, i).Value & " " & "KG " & dgPurchase(1, i).Value & " NO "
                ElseIf Val(dgPurchase(1, i).Value) > 0 Then
                    narration &= " " & dgPurchase(1, i).Value & " NO "
                ElseIf Val(dgPurchase(2, i).Value) > 0 And Val(dgPurchase(1, i).Value) = 0 Then
                    narration &= " " & dgPurchase(2, i).Value & " " & "KG " & dgPurchase(1, i).Value & " NO "
                End If
                narration &= " @ " & dgPurchase(3, i).Value
                narrcust = narrcust & " " & narration
                sqlsave = " insert into InvPhxChicken (Cmp_id, Uname, Vou_no, Vou_type" _
               & ", Vou_date, Acc_head_code, Acc_head, ItemName, Qty, QtyNos, Unit, Rate," _
               & "  Amount, Free_Qty, BillType, BillNo, BillDate, AreaCode,BatchNo,Session) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'PURCHASE',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbacheadcode.Text & "',"
                sqlsave &= "'" & cmbacheadname.Text & "',"
                sqlsave &= "'" & dgPurchase(0, i).Value & "',"
                sqlsave &= "'" & Val(dgPurchase(2, i).Value) & "',"
                sqlsave &= "'" & Val(dgPurchase(1, i).Value) & "',"
                sqlsave &= "'-',"
                sqlsave &= "'" & Val(dgPurchase(3, i).Value) & "',"
                sqlsave &= "'" & Val(dgPurchase(4, i).Value) & "',"
                sqlsave &= "'0',"
                sqlsave &= "'PURCHASE',"
                sqlsave &= "'" & txtInvnoNo.Text & "',"
                sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbAreaCode.Text & "',"
                sqlsave &= "'" & lblbatchno.Text & "',"
                sqlsave &= "'" & GMod.Session & "')"
                DrAmt = DrAmt + Val(dgPurchase(4, i).Value)

                Dim cmd1 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd1.ExecuteNonQuery()


                ''Getting Head/code 
                'Dim c, h, s, g As String
                'Try

                '    s = "select account_code,account_head_name,group_name from " & GMod.ACC_HEAD & " where account_head_name='PUR. OF " & dgPurchase(0, i).Value & "-" & cmbAreaCode.Text & "'"
                '    GMod.DataSetRet(s, "ZZ")
                '    c = GMod.ds.Tables("ZZ").Rows(0)(0)
                '    h = GMod.ds.Tables("ZZ").Rows(0)(1)
                '    g = GMod.ds.Tables("ZZ").Rows(0)(2)
                'Catch ex As Exception
                '    MsgBox(ex.Message & "PLEASE CREATE PURCHAE HEAD")
                'End Try
            Next
            'PURCAHSE A/C Dr
            sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
         & " Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " _
         & "Narration, Group_name, Sub_group_name) values ("
            sqlsave &= "'" & GMod.Cmpid & "',"
            sqlsave &= "'" & GMod.username & "',"
            sqlsave &= "'-2',"
            sqlsave &= "'" & txtVoucherNo.Text & "',"
            sqlsave &= "'PURCHASE',"
            sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
            sqlsave &= "'" & cmbcodePur.Text & "',"
            sqlsave &= "'" & cmbPurofhead.Text & "',"
            sqlsave &= "'" & DrAmt & "',"
            sqlsave &= "'0',"
            sqlsave &= "'-',"
            sqlsave &= "'-',"
            sqlsave &= "'" & narrinv & narration & "',"
            sqlsave &= "'" & ComboBox2.Text & "',"
            sqlsave &= "'-')"
            Dim cmd3 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
            cmd3.ExecuteNonQuery()

            'PARTY A/C Cr
            sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
            & " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
            & "Narration, Group_name, Sub_group_name) values ("
            sqlsave &= "'" & GMod.Cmpid & "',"
            sqlsave &= "'" & GMod.username & "',"
            sqlsave &= "'0',"
            sqlsave &= "'" & txtVoucherNo.Text & "',"
            sqlsave &= "'PURCHASE',"
            sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
            sqlsave &= "'" & cmbacheadcode.Text & "',"
            sqlsave &= "'" & cmbacheadname.Text & "',"
            sqlsave &= "'" & txtgtotal.Text & "',"
            sqlsave &= "'0',"
            sqlsave &= "'-',"
            sqlsave &= "'-',"
            sqlsave &= "'" & narrinv & narration & "',"
            sqlsave &= "'" & ComboBox1.Text & "',"
            sqlsave &= "'-')"
            'MsgBox(sqlsave)
            Dim cmd2 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
            cmd2.ExecuteNonQuery()

            

            If Val(txtComm.Text) > 0 Then
                'Commosion Cr
                sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
             & " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
             & "Narration, Group_name, Sub_group_name) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'1',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'PURCHASE',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbcommcode.Text & "',"
                sqlsave &= "'" & cmbcommhead.Text & "',"
                sqlsave &= "'" & txtComm.Text & "',"
                sqlsave &= "'0',"
                sqlsave &= "'-',"
                sqlsave &= "'-',"
                sqlsave &= "'" & narrinv & narration & "',"
                sqlsave &= "'" & ComboBox3.Text & "',"
                sqlsave &= "'-')"
                Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd4.ExecuteNonQuery()
            End If

            If Val(txtFreight.Text) > 0 Then
                'FREIGHT Cr
                sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                & " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
                & "Narration, Group_name, Sub_group_name) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'2',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'PURCHASE',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbfercode.Text & "',"
                sqlsave &= "'" & cmbferhead.Text & "',"
                sqlsave &= "'" & txtFreight.Text & "',"
                sqlsave &= "'0',"
                sqlsave &= "'-',"
                sqlsave &= "'-',"
                sqlsave &= "'" & narrinv & narrcust & "',"
                sqlsave &= "'" & ComboBox4.Text & "',"
                sqlsave &= "'-')"
                Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd4.ExecuteNonQuery()
            End If
            sqltrans.Commit()
            MsgBox("Voucher Saved ...", MsgBoxStyle.Information)
            dgPurchase.Rows.Clear()
            txtInvnoNo.Focus()
            nxtvno()
            dgPurchase.Rows.Add()
            txtComm.Text = ""
            txtTotal.Text = ""
            txtFreight.Text = ""
            txtgtotal.Text = ""
            DrAmt = 0
        Catch ex As Exception
            MsgBox(ex.Message)
            sqltrans.Rollback()
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click

        Try

        

            'PURCHASE
            Dim vou_no As String
            Dim sql As String
            Dim sqlinv As String, i As Integer
            If btnSave.Enabled = True Then
                btnSave.Enabled = False
                vou_no = InputBox("Entry voucher Number to modify?")
                If vou_no <> "" Then
                    'If LockDataCheck(vou_no, GMod.Session, "PURCHASE") = False Then
                    '    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Exit Sub
                    'End If
                    sqlinv = "select * from InvPhxChicken where Vou_no='" & vou_no & "' and Vou_type='PURCHASE' and Session ='" & GMod.Session & "'"
                    GMod.DataSetRet(sqlinv, "inv")
                    'Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, 
                    'ItemName, Qty, QtyNos, Unit, Rate, Amount, Free_Qty, BillType, BillNo,
                    'BillDate, AreaCode, Free_Per, Hatch_date, BatchNo
                    cmbacheadcode.Text = GMod.ds.Tables("inv").Rows(0)("Acc_head_code")
                    cmbacheadname.Text = GMod.ds.Tables("inv").Rows(0)("Acc_head")

                    txtInvnoNo.Text = GMod.ds.Tables("inv").Rows(0)("BillNo")
                    dtInvVate.Value = CDate(GMod.ds.Tables("inv").Rows(0)("BillDate").ToString)
                    txtVoucherNo.Text = vou_no
                    dtVouDate.Value = CDate(GMod.ds.Tables("inv").Rows(0)("Vou_date").ToString)
                    cmbAreaCode.Text = GMod.ds.Tables("inv").Rows(0)("AreaCode")
                    If Len(GMod.ds.Tables("inv").Rows(0)("BatchNo").ToString) > 0 Then lblbatchno.Text = GMod.ds.Tables("inv").Rows(0)("BatchNo")
                    txtbatch.Text = ""
                    For i = 0 To GMod.ds.Tables("inv").Rows.Count - 1
                        dgPurchase.Rows.Add()
                        dgPurchase(0, i).Value = GMod.ds.Tables("inv").Rows(i)("ItemName")
                        dgPurchase(1, i).Value = GMod.ds.Tables("inv").Rows(i)("QtyNos")
                        dgPurchase(2, i).Value = GMod.ds.Tables("inv").Rows(i)("Qty")
                        dgPurchase(3, i).Value = GMod.ds.Tables("inv").Rows(i)("Rate")
                        dgPurchase(4, i).Value = GMod.ds.Tables("inv").Rows(i)("Amount")
                    Next
                    dgPurchase.Rows.RemoveAt(i)

                    'Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, 
                    'cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date
                    sql = "select * from " & GMod.VENTRY & " where Vou_no='" & vou_no & "' and group_name='COMMISSION' and vou_type='PURCHASE'"
                    GMod.DataSetRet(sql, "comm")
                    If GMod.ds.Tables("comm").Rows.Count > 0 Then
                        cmbcommcode.Text = GMod.ds.Tables("comm").Rows(0)("Acc_head_code")
                        txtComm.Text = GMod.ds.Tables("comm").Rows(0)("cramt")
                    End If

                    sql = "select * from " & GMod.VENTRY & " where Vou_no='" & vou_no & "' and vou_type='PURCHASE' and   group_name in ('FREIGHT','EXPENSES','FREIGHT')"
                    GMod.DataSetRet(sql, "FRI")
                    If GMod.ds.Tables("FRI").Rows.Count > 0 Then
                        cmbfercode.Text = GMod.ds.Tables("FRI").Rows(0)("Acc_head_code")
                        txtFreight.Text = GMod.ds.Tables("FRI").Rows(0)("cramt")
                    End If

                    'sql = "select * from " & GMod.VENTRY & " where Vou_no='" & vou_no & "' and group_name in ('PARTY','INTERNAL PARTY','CUSTOMER')  and vou_type='PURCHASE'"
                    'GMod.DataSetRet(sql, "party")
                    'If GMod.ds.Tables("party").Rows.Count > 0 Then
                    '    'cmbacheadcode.Text = GMod.ds.Tables("party").Rows(0)("Acc_head_code")
                    '    txtgtotal.Text = GMod.ds.Tables("party").Rows(0)("cramt")
                    'End If
                    btnSave.Enabled = False
                    txtgtotal_Enter(sender, e)
                    txtgtotal.Focus()
                    btnModify.Text = "&Update"

                End If
            Else
                Dim sqldel, sqldel1 As String
                sqldel = "delete from " & GMod.VENTRY & " where vou_no='" & txtVoucherNo.Text & "' and vou_type='PURCHASE'"
                GMod.SqlExecuteNonQuery(sqldel)

                sqldel1 = "delete from InvPhxChicken where vou_no='" & txtVoucherNo.Text & "' and vou_type='PURCHASE' and Session ='" & GMod.Session & "'"
                GMod.SqlExecuteNonQuery(sqldel1)
                btnSave_Click(sender, e)
                btnModify.Text = "&Modify"
                btnSave.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub txtFreight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFreight.TextChanged
        'If btnSave.Enabled = True Then
        txtgtotal.Text = Val(txtFreight.Text) + Val(txtTotal.Text) - Val(txtComm.Text)
        'End If
    End Sub

    Private Sub txtComm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComm.TextChanged
        'If btnSave.Enabled = True Then
        txtgtotal.Text = Val(txtTotal.Text) + Val(txtFreight.Text) - Val(txtComm.Text)
        'End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim vou_no As String
        vou_no = InputBox("Entry voucher Number to Delete?")
        If MessageBox.Show("Want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            If vou_no <> "" Then
                'If LockDataCheck(vou_no, GMod.Session, "PURCHASE") = False Then
                '    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Sub
                'End If
                GMod.Fill_Log(GMod.Cmpid, vou_no, "PURCHASE", dtVouDate.Value, Now, GMod.Session, "D", GMod.username)

                Dim sqldel, sqldel1 As String
                sqldel = "delete from " & GMod.VENTRY & " where vou_no='" & vou_no & "' and vou_type='PURCHASE'"
                GMod.SqlExecuteNonQuery(sqldel)

                sqldel1 = "delete from InvPhxChicken where vou_no='" & vou_no & "' and vou_type='PURCHASE'and Session ='" & GMod.Session & "'"
                MsgBox(GMod.SqlExecuteNonQuery(sqldel1))

            End If

            nxtvno()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim t As New frmPartyaccount
        Dim sql As String
        sql = "select Group_name,Suffix from Groups where Group_name like '%PARTY%' and Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "Suffix")

        t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupname.DisplayMember = "Group_name"

        t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupsuffix.DisplayMember = "Suffix"
        t.lblgroupsuffix.Text = "PA"
        t.Label1.Text = "Party Account Heads"
        t.ShowDialog()
        CheckBox2.Checked = False
        heads()
    End Sub

    Private Sub ChknewCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChknewCustomer.CheckedChanged
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
        heads()
    End Sub
    Public Sub heads()
        Dim sql As String
        sql = " select account_head_name,account_code,group_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and group_name in ('PARTY','SHOP','INTERNAL PARTY','CUSTOMER') " 'and left(account_code,2) in('" & cmbAreaCode.Text & "','**')"
        GMod.DataSetRet(sql, "A1")
        cmbacheadname.DataSource = GMod.ds.Tables("A1")
        cmbacheadname.DisplayMember = "account_head_name"


        cmbacheadcode.DataSource = GMod.ds.Tables("A1")
        cmbacheadcode.DisplayMember = "account_code"

        ComboBox1.DataSource = GMod.ds.Tables("A1")
        ComboBox1.DisplayMember = "group_name"

        Dim sqlsale As String
        sqlsale = "select * from " & GMod.ACC_HEAD & " where group_name like '%PURCHASE%'"
        GMod.DataSetRet(sqlsale, "A2")
        cmbPurofhead.DataSource = GMod.ds.Tables("A2")
        cmbPurofhead.DisplayMember = "account_head_name"

        cmbcodePur.DataSource = GMod.ds.Tables("A2")
        cmbcodePur.DisplayMember = "account_code"
        ComboBox2.DataSource = GMod.ds.Tables("A2")
        ComboBox2.DisplayMember = "group_name"

        Dim sqlcomm As String
        sqlcomm = "select * from " & GMod.ACC_HEAD & " where group_name like '%SALE%' "
        GMod.DataSetRet(sqlcomm, "A3")
        cmbcommhead.DataSource = GMod.ds.Tables("A3")
        cmbcommhead.DisplayMember = "account_head_name"

        cmbcommcode.DataSource = GMod.ds.Tables("A3")
        cmbcommcode.DisplayMember = "account_code"
        ComboBox3.DataSource = GMod.ds.Tables("A3")
        ComboBox3.DisplayMember = "group_name"


        Dim sqlfer As String
        sqlfer = "select * from " & GMod.ACC_HEAD & " where group_name in('FRIEGHT','EXPENSES','FREIGHT')"
        GMod.DataSetRet(sqlfer, "A4")
        cmbferhead.DataSource = GMod.ds.Tables("A4")
        cmbferhead.DisplayMember = "account_head_name"

        cmbfercode.DataSource = GMod.ds.Tables("A4")
        cmbfercode.DisplayMember = "account_code"

        ComboBox4.DataSource = GMod.ds.Tables("A4")
        ComboBox4.DisplayMember = "group_name"

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim tg As New frmGeneralacchead
        tg.ShowDialog()
        heads()
    End Sub

    Private Sub cmbAreaName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.SelectedIndexChanged
        ' heads()
    End Sub

    Private Sub txtgtotal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgtotal.Enter
        'dgPurchase_CellLeave(sender, e)
        If btnSave.Enabled = False Then
            For i = 0 To dgPurchase.Rows.Count - 1
                total = total + Val(dgPurchase(4, i).Value)
            Next
            txtTotal.Text = total.ToString
            total = 0
        End If
    End Sub

    Private Sub txtgtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgtotal.TextChanged

    End Sub

    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        If btnSave.Enabled = True Then
            heads()
        Else
            Dim sqlcomm As String
            sqlcomm = "select * from " & GMod.ACC_HEAD & " where group_name like '%COMM%'  and left(account_code,2) in ('" & cmbAreaCode.Text & "')"
            GMod.DataSetRet(sqlcomm, "A3")
            cmbcommhead.DataSource = GMod.ds.Tables("A3")
            cmbcommhead.DisplayMember = "account_head_name"
        End If
    End Sub

    Private Sub lblbatchno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblbatchno.Click

    End Sub

    Private Sub lblbatchno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblbatchno.Leave

    End Sub

    Private Sub cmbPurofhead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPurofhead.Leave
        If cmbPurofhead.FindStringExact(cmbPurofhead.Text) = -1 Then
            MsgBox("Invalid...")
            cmbPurofhead.Focus()
        Else

        End If
    End Sub

    Private Sub cmbPurofhead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPurofhead.SelectedIndexChanged
        
    End Sub

    Private Sub cmbcodePur_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcodePur.Leave
        If cmbcodePur.FindStringExact(cmbcodePur.Text) = -1 Then
            MsgBox("Invalid...")
            cmbcodePur.Focus()
        Else

        End If
    End Sub

    Private Sub cmbcodePur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcodePur.SelectedIndexChanged

    End Sub

    Private Sub cmbcommhead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcommhead.Leave
        If cmbcommhead.FindStringExact(cmbcommhead.Text) = -1 Then
            MsgBox("Invalid...")
            cmbcommhead.Focus()
        Else

        End If
    End Sub

    Private Sub cmbcommhead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcommhead.SelectedIndexChanged

    End Sub

    Private Sub cmbcommcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcommcode.Leave
        If cmbcommcode.FindStringExact(cmbcommcode.Text) = -1 Then
            MsgBox("Invalid...")
            cmbcommcode.Focus()
        Else

        End If
    End Sub

    Private Sub cmbcommcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcommcode.SelectedIndexChanged

    End Sub

    Private Sub cmbferhead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbferhead.Leave
        If cmbferhead.FindStringExact(cmbferhead.Text) = -1 Then
            MsgBox("Invalid...")
            cmbferhead.Focus()
        Else

        End If
    End Sub

    Private Sub cmbferhead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbferhead.SelectedIndexChanged
        
    End Sub

    Private Sub cmbfercode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbfercode.Leave
        If cmbfercode.FindStringExact(cmbfercode.Text) = -1 Then
            MsgBox("Invalid...")
            cmbfercode.Focus()
        Else

        End If
    End Sub

    Private Sub cmbfercode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfercode.SelectedIndexChanged

    End Sub

    Private Sub dtVouDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtVouDate.ValueChanged

    End Sub
End Class