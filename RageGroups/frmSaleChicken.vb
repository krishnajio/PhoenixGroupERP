Imports System.Data.SqlClient
Public Class frmSaleChicken

    Private Sub frmPurchaseChicken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillArea()
        nxtvno()
        heads()
        Dim sqlitem As String
        sqlitem = "select * from ItemMasterOther where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlitem, "ITEM")
        Me.Particular.DataSource = GMod.ds.Tables("ITEM")
        Me.Particular.DisplayMember = "ItemName"
        dgPurchase.Rows.Add()

        If GMod.Getsession(dtVouDate.Value) = GMod.Session Then
        Else
            '  Me.Close()
        End If
        cmbvtype.SelectedIndex = 0
        'Filling tcs tYPE 
        GMod.DataSetRet("select * from TCSMaster Where cmp_id='" & GMod.Cmpid & "' and type =1", "TCSTYPE")
        cmbTcsType.DataSource = GMod.ds.Tables("TCSTYPE")
        cmbTcsType.DisplayMember = "TcsType"

    End Sub
    Sub nxtvno()
        Dim sql As String
        Try
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "'"
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
        


        Dim amt As Double
        If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
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

        For i = 0 To dgPurchase.Rows.Count - 1
            If dgPurchase(0, i).Value <> "FREIGHT" Then
                total = total + Val(dgPurchase(4, i).Value)
            End If
        Next
        txtTotal.Text = total.ToString
        total = 0

        'Dim rate As Double
        'If e.ColumnIndex = 4 Then
        '    If Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
        '        rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value)
        '        dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
        '    ElseIf Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
        '        rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value)
        '        dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
        '    End If
        'ElseIf e.ColumnIndex = 2 Or e.ColumnIndex = 1 Then
        '    If Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
        '        rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value)
        '        dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
        '    ElseIf Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
        '        rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value)
        '        dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
        '    End If
        'End If
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
        If e.ColumnIndex = 4 Then
            For i = 0 To dgPurchase.Rows.Count - 1
                If dgPurchase(0, i).Value <> "FREIGHT" Then
                    total = total + Val(dgPurchase(4, i).Value)
                End If
            Next


        End If
        txtTotal.Text = total.ToString
        total = 0

        If e.ColumnIndex = 4 Then
            For i = 0 To dgPurchase.Rows.Count - 1
                If dgPurchase(0, i).Value = "FREIGHT" Then
                    FR = FR + Val(dgPurchase(4, i).Value)
                End If
            Next
            txtFreight.Text = FR.ToString
            FR = 0
        End If
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
        lblbatchno.Text = txtbatch.Text
    End Sub

    Private Sub txtbatch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbatch.TextChanged
        lblbatchno.Text = txtbatch.Text
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
    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged
        'If btnSave.Enabled = True Then
        txtgtotal.Text = Val(txtTotal.Text) + Val(txtComm.Text) + Val(txtFreight.Text)
        'End If
    End Sub
    Dim CrAmt As Double
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtbatch.Text = "" Then
            MsgBox("Enter Batch No:")
            txtbatch.Focus()
            Exit Sub
        End If
        If btnSave.Enabled = False Then
            GMod.Fill_Log(GMod.Cmpid, txtVoucherNo.Text, "SALE", dtVouDate.Value, Now, GMod.Session, "M", GMod.username)
        End If
        Dim sqlsave As String
        Dim sqltrans As SqlTransaction
        Dim narration, narrcust, narrinv As String
        sqltrans = GMod.SqlConn.BeginTransaction

        sqlsave = "delete from " & GMod.VENTRY & " where vou_no='" & txtVoucherNo.Text & "' and vou_type='" & cmbvtype.Text & "'"
        Dim cmd12 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
        cmd12.ExecuteNonQuery()


        sqlsave = "delete from InvPhxChicken where vou_no='" & txtVoucherNo.Text & "' and vou_type='" & cmbvtype.Text & "' and Session='" & GMod.Session & "'"
        Dim cmd13 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
        cmd13.ExecuteNonQuery()


        narrinv = "INV NO " & txtInvnoNo.Text & " DT." & dtInvVate.Text & " DM NO " & lblbatchno.Text & " "

        narration = ""
        Try
            For i = 0 To dgPurchase.Rows.Count - 1
                'narration = "INV NO " & txtInvnoNo.Text & " DT." & dtInvVate.Value.ToShortDateString & " BATCH NO " & lblbatchno.Text & " "

                narration &= dgPurchase(0, i).Value
                If Val(dgPurchase(2, i).Value) > 0 And Val(dgPurchase(1, i).Value) > 0 Then
                    narration &= " " & dgPurchase(2, i).Value & " " & "KG " & dgPurchase(1, i).Value & " NO "
                ElseIf Val(dgPurchase(1, i).Value) > 0 Then
                    narration &= " " & dgPurchase(1, i).Value & " NO "
                ElseIf Val(dgPurchase(2, i).Value) > 0 And Val(dgPurchase(1, i).Value) = 0 Then
                    narration &= " " & dgPurchase(2, i).Value & " " & "KG " & dgPurchase(1, i).Value & " NO "
                End If

                narration &= " @ " & dgPurchase(3, i).Value

                ' narrcust = narrcust & " " & narration

                sqlsave = " insert into InvPhxChicken (Cmp_id, Uname, Vou_no, Vou_type" _
               & ", Vou_date, Acc_head_code, Acc_head, ItemName, Qty, QtyNos, Unit, Rate," _
               & "  Amount, Free_Qty, BillType, BillNo, BillDate, AreaCode,BatchNo,Session,tcs_per,tcs_amt) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'" & cmbvtype.Text & "',"
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
                sqlsave &= "'" & cmbvtype.Text & "',"
                sqlsave &= "'" & txtInvnoNo.Text & "',"
                sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbAreaCode.Text & "',"
                sqlsave &= "'" & lblbatchno.Text & "',"
                sqlsave &= "'" & GMod.Session & "',"
                sqlsave &= "'" & txtTcsPer.Text & "',"
                sqlsave &= "'" & txtTcsAmount.Text & "')"

                CrAmt = CrAmt + Val(dgPurchase(4, i).Value)

                Dim cmd1 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd1.ExecuteNonQuery()

                ''SALE A/C Cr
                ''Getting Head/code 
                'Dim c, h, s, g As String
                'Try
                '    s = "select account_code,account_head_name,group_name from " & GMod.ACC_HEAD & " where account_head_name='SALE OF " & dgPurchase(0, i).Value & "-" & cmbAreaCode.Text & "'"
                '    GMod.DataSetRet(s, "ZZ")
                '    c = GMod.ds.Tables("ZZ").Rows(0)(0)
                '    h = GMod.ds.Tables("ZZ").Rows(0)(1)
                '    g = GMod.ds.Tables("ZZ").Rows(0)(2)

                'Catch ex As Exception
                '    MsgBox(ex.Message & "PLEASE CREATE sale HEAD")
                '    sqltrans.Rollback()
                '    Exit Sub
                'End Try

            Next

            'Inserting TCS tax amount in the Voucher entry Credit 
            If Val(txtTcsAmount.Text) > 0 Then
                sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'" & i + 1 & "',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'" & cmbvtype.Text & "',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbTcsHeadCode.Text & "',"
                sqlsave &= "'" & cmbTcsHead.Text & "',"
                sqlsave &= "'" & Val("") & "',"
                sqlsave &= "'" & Val(txtTcsAmount.Text) & "',"
                sqlsave &= "'" & narration.ToString & "',"
                sqlsave &= "'',"
                sqlsave &= "'" & " " & "','1/1/2000')"
                'MsgBox(ssaveprdvntry)
                'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                Dim cmdTcstaxentry As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmdTcstaxentry.ExecuteNonQuery()

            End If


            'CUSTOMER A/C Dr
            sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
            & " Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " _
            & "Narration, Group_name, Sub_group_name) values ("
            sqlsave &= "'" & GMod.Cmpid & "',"
            sqlsave &= "'" & GMod.username & "',"
            sqlsave &= "'-2',"
            sqlsave &= "'" & txtVoucherNo.Text & "',"
            sqlsave &= "'" & cmbvtype.Text & "',"
            sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
            sqlsave &= "'" & cmbacheadcode.Text & "',"
            sqlsave &= "'" & cmbacheadname.Text & "',"
            sqlsave &= "'" & Val(txtgtotal.Text) + Val(txtTcsAmount.Text) & "',"
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
                sqlsave &= "'2',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'" & cmbvtype.Text & "',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbcommcode.Text & "',"
                sqlsave &= "'" & cmbcommhead.Text & "',"
                sqlsave &= "'" & txtComm.Text & "',"
                sqlsave &= "'0',"
                sqlsave &= "'-',"
                sqlsave &= "'-',"
                sqlsave &= "'" & narrinv & narrcust & "',"
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
                sqlsave &= "'3',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'" & cmbvtype.Text & "',"
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
            If dgPurchase(0, 0).Value <> "FREIGHT" Then
                sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                & " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
                & "Narration, Group_name, Sub_group_name) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'0',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'" & cmbvtype.Text & "',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbcodePur.Text & "',"
                sqlsave &= "'" & cmbPurofhead.Text & "',"
                sqlsave &= "'" & Val(txtTotal.Text) & "',"
                sqlsave &= "'0',"
                sqlsave &= "'-',"
                sqlsave &= "'-',"
                sqlsave &= "'" & narrinv & narration & "',"
                sqlsave &= "'" & ComboBox2.Text & "',"
                sqlsave &= "'-')"
                Dim cmd3 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd3.ExecuteNonQuery()
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
            CrAmt = 0
            ' cmbvtype.SelectedIndex = 0
        Catch ex As Exception
x1:
            MsgBox(ex.Message)
            sqltrans.Rollback()
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim vou_no As String
        Dim sql As String
        Dim sqlinv As String, i As Integer
        If btnSave.Enabled = True Then

            vou_no = InputBox("Entry voucher Number to modify?")
            If vou_no <> "" Then
                'If LockDataCheck(vou_no, GMod.Session, "SALE") = False Then
                '    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Sub
                'End If
                sqlinv = "select * from InvPhxChicken where Vou_no='" & vou_no & "' and Vou_type='" & cmbvtype.Text & "' and Session='" & GMod.Session & "'"
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
                lblbatchno.Text = GMod.ds.Tables("inv").Rows(0)("BatchNo")

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
                sql = "select * from " & GMod.VENTRY & " where Vou_no='" & vou_no & "' and group_name='COMMISSION' and vou_type='" & cmbvtype.Text & "' "
                GMod.DataSetRet(sql, "comm")
                If GMod.ds.Tables("comm").Rows.Count > 0 Then
                    cmbcommcode.Text = GMod.ds.Tables("comm").Rows(0)("Acc_head_code")
                    txtComm.Text = GMod.ds.Tables("comm").Rows(0)("cramt")
                End If

                sql = "select * from " & GMod.VENTRY & " where Vou_no='" & vou_no & "' and vou_type='" & cmbvtype.Text & "' "
                GMod.DataSetRet(sql, "FRI")
                If GMod.ds.Tables("FRI").Rows.Count > 0 Then
                    cmbfercode.Text = GMod.ds.Tables("FRI").Rows(0)("Acc_head_code")
                    txtFreight.Text = GMod.ds.Tables("FRI").Rows(0)("cramt")
                End If

                'sql = "select * from " & GMod.VENTRY & " where Vou_no='" & vou_no & "' and group_name='PARTY'  and vou_type='SALE' "
                'GMod.DataSetRet(sql, "party")
                'If GMod.ds.Tables("party").Rows.Count > 0 Then
                '    cmbacheadcode.Text = GMod.ds.Tables("party").Rows(0)("Acc_head_code")
                '    txtgtotal.Text = GMod.ds.Tables("party").Rows(0)("cramt")
                'End If
                btnModify.Text = "&Update"
                btnSave.Enabled = False
            End If
        Else
            Dim sqldel, sqldel1 As String
               btnSave_Click(sender, e)
            btnModify.Text = "&Modify"
            btnSave.Enabled = True
        End If
        txtgtotal.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtComm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComm.TextChanged
        'If btnSave.Enabled = True Then
        txtgtotal.Text = Val(txtComm.Text) + Val(txtTotal.Text) + Val(txtFreight.Text)
        'End If
    End Sub

    Private Sub txtFreight_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFreight.Enter
        For i = 0 To dgPurchase.Rows.Count - 1
            If dgPurchase(0, i).Value = "FREIGHT" Then
                FR = FR + Val(dgPurchase(4, i).Value)
            End If
        Next
        txtFreight.Text = FR.ToString
        FR = 0
    End Sub

    Private Sub txtFreight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFreight.TextChanged
        ''If btnSave.Enabled = True Then
        txtgtotal.Text = Val(txtFreight.Text) + Val(txtTotal.Text) - Val(txtComm.Text)
        'End If
    End Sub
    Dim FR As Double
    Private Sub txtgtotal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgtotal.Enter
        'dgPurchase_CellLeave(sender, e)
        If btnSave.Enabled = False Then
            For i = 0 To dgPurchase.Rows.Count - 1
                If dgPurchase(0, i).Value <> "FREIGHT" Then
                    total = total + Val(dgPurchase(4, i).Value)
                End If
            Next
            txtTotal.Text = total.ToString
            total = 0

            For i = 0 To dgPurchase.Rows.Count - 1
                If dgPurchase(0, i).Value = "FREIGHT" Then
                    FR = FR + Val(dgPurchase(4, i).Value)
                End If
            Next
            txtFreight.Text = FR.ToString
            FR = 0

        End If
    End Sub

    Private Sub txtgtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgtotal.TextChanged

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim vou_no As String
        vou_no = InputBox("Entry voucher Number to modify?")
        If MessageBox.Show("Want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            If vou_no <> "" Then

                'If LockDataCheck(vou_no, GMod.Session, "SALE") = False Then
                '    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Sub
                'End If
                GMod.Fill_Log(GMod.Cmpid, vou_no, "SALE", dtVouDate.Value, Now, GMod.Session, "M", GMod.username)
                Dim sqldel, sqldel1 As String
                sqldel = "delete from " & GMod.VENTRY & " where vou_no='" & vou_no & "' and vou_type='SALE'"
                GMod.SqlExecuteNonQuery(sqldel)

                sqldel1 = "delete from InvPhxChicken where vou_no='" & vou_no & "' and vou_type='SALE' and Session='" & GMod.Session & "'"
                MsgBox(GMod.SqlExecuteNonQuery(sqldel1))

            End If
            nxtvno()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
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
        heads()
    End Sub

    Private Sub ChknewCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChknewCustomer.CheckedChanged
        Dim t As New frmPartyaccount
        Dim sql As String
        Sql = "select Group_name,Suffix from Groups where Group_name like '%CUSTOMER%' and Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(Sql, "Suffix")

        t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupname.DisplayMember = "Group_name"

        t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupsuffix.DisplayMember = "Suffix"

        t.Label1.Text = "Customer Account Heads"
        t.ShowDialog()
        CheckBox2.Checked = False
        heads()
    End Sub
    Public Sub heads()
        Dim sql As String
        sql = " select account_head_name,account_code,group_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "A1")
        cmbacheadname.DataSource = GMod.ds.Tables("A1")
        cmbacheadname.DisplayMember = "account_head_name"

        cmbacheadcode.DataSource = GMod.ds.Tables("A1")
        cmbacheadcode.DisplayMember = "account_code"

        ComboBox1.DataSource = GMod.ds.Tables("A1")
        ComboBox1.DisplayMember = "group_name"

        Dim sqlsale As String
        sqlsale = "select * from " & GMod.ACC_HEAD
        GMod.DataSetRet(sqlsale, "A2")
        cmbPurofhead.DataSource = GMod.ds.Tables("A2")
        cmbPurofhead.DisplayMember = "account_head_name"

        cmbcodePur.DataSource = GMod.ds.Tables("A2")
        cmbcodePur.DisplayMember = "account_code"

        ComboBox2.DataSource = GMod.ds.Tables("A2")
        ComboBox2.DisplayMember = "group_name"

        Dim sqlcomm As String
        sqlcomm = "select * from " & GMod.ACC_HEAD
        GMod.DataSetRet(sqlcomm, "A3")
        cmbcommhead.DataSource = GMod.ds.Tables("A3")
        cmbcommhead.DisplayMember = "account_head_name"

        cmbcommcode.DataSource = GMod.ds.Tables("A3")
        cmbcommcode.DisplayMember = "account_code"
        ComboBox3.DataSource = GMod.ds.Tables("A3")
        ComboBox3.DisplayMember = "group_name"


        Dim sqlfer As String
        sqlfer = "select * from " & GMod.ACC_HEAD
        GMod.DataSetRet(sqlfer, "A4")
        cmbferhead.DataSource = GMod.ds.Tables("A4")
        cmbferhead.DisplayMember = "account_head_name"

        cmbfercode.DataSource = GMod.ds.Tables("A4")
        cmbfercode.DisplayMember = "account_code"

        ComboBox4.DataSource = GMod.ds.Tables("A4")
        ComboBox4.DisplayMember = "group_name"
        'Filling item list
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim tg As New frmGeneralacchead
        tg.ShowDialog()
        heads()
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

    Private Sub cmbvtype_Leave(sender As Object, e As EventArgs) Handles cmbvtype.Leave
        nxtvno()
    End Sub

    Private Sub cmbvtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvtype.SelectedIndexChanged

        nxtvno()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub cmbTcsType_Leave(sender As Object, e As EventArgs) Handles cmbTcsType.Leave
        FetchTcsDetilas()
    End Sub

    Private Sub cmbTcsType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTcsType.SelectedIndexChanged
        FetchTcsDetilas()
    End Sub
    Private Sub FetchTcsDetilas()
        Dim sql As String
        Try
            sql = "select tcs.*,a.account_head_name from TCsMaster tcs inner join acc_head_phha_" & GMod.Session & " a on tcs.Acc_code = a.account_code  where TcStype ='" & cmbTcsType.Text & "'"
            GMod.DataSetRet(sql, "tcsdata")

            cmbTcsHead.Text = GMod.ds.Tables("tcsdata").Rows(0)("account_head_name").ToString
            cmbTcsHeadCode.Text = GMod.ds.Tables("tcsdata").Rows(0)("Acc_code").ToString
            txtTcsPer.Text = GMod.ds.Tables("tcsdata").Rows(0)("Per").ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chKtcs_CheckedChanged(sender As Object, e As EventArgs) Handles chKtcs.CheckedChanged
        Try
            'Dim sql As String
            'If chKtcs.Checked = True Then
            'sql = "select discount, necc  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, 0).Value & "'"
            'GMod.DataSetRet(sql, "neccamyfortcs")
            'MessageBox.Show(Val(GMod.ds.Tables("neccamyfortcs").Rows(0)(1)))
            'End If
            If chKtcs.Checked = True Then
                Dim tcs As Double
                tcs = Math.Round(Val(txtgtotal.Text) * (Val(txtTcsPer.Text) / 100), 0)
                txtTcsAmount.Text = tcs.ToString
            Else
                txtTcsAmount.Text = 0
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class