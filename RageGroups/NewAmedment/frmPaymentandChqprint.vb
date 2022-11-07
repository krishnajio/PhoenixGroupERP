Imports System.Data.SqlClient
Public Class frmPaymentandChqprint
    Dim i As Integer = -1
    Dim j As Integer
    Dim cr, dr As Double
    Dim SelectQuery As String
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'f MessageBox.Show("Want to add more", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        If Val(txtDramt.Text) + Val(txtCrmat.Text) = 0 Then
            MsgBox("Either Cr or Dr is Zero", MsgBoxStyle.Information)
            txtDramt.Focus()
            Exit Sub
        End If

        'If chkpayment.Checked = True Then
        '    If lblpartycode.Text = "-" Then
        '        MsgBox("Please Select party head", MsgBoxStyle.Critical)
        '        Exit Sub
        '    End If
        'End If

        Dim obj() As Object = {cmbAcHead.Text, cmbcode.Text, txtDramt.Text, txtCrmat.Text, ComboBox1.Text, ComboBox2.Text, txtNarration.Text, txtChqNo.Text}
        If i <> -1 Then
            dgPayment.Rows.RemoveAt(i)
            dgPayment.Rows.Insert(i, obj)
        Else
            dgPayment.Rows.Add(obj)
        End If

        For j = 0 To dgPayment.Rows.Count - 1
            dr = dr + Val(dgPayment(2, j).Value)
            cr = cr + Val(dgPayment(3, j).Value)
        Next
        lblcr.Text = cr
        lblDr.Text = dr
        dr = 0
        cr = 0
        i = -1
        cmbAcHead.Focus()
        'lse()
        'xtNarration.Focus()
        'End If
        txtCrmat.Text = "0.0"
        txtDramt.Text = "0.0"
        txtNarration.Text = ""
        ' txtChqNo.Text = ""
    End Sub
    Dim sql As String = ""
    Dim expflag As Boolean = False

    Private Sub frmPayment_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & dgPayment(1, 0).Value & "' and vou_type='PAY' and cmp_id='" & GMod.Cmpid & "'")
    End Sub
    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'date set to server date 

        'sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and Vtype in ('BANK','CASH')"
        'GMod.DataSetRet(sql, "CRVT")
        'cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
        'cmbvoutype.DisplayMember = "vtype"
        cmbvoutype.SelectedIndex = 0

        'GMod.DataSetRet("select getdate()", "serverdate")
        'dtvdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

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
        dtvdate.Value = GMod.SessionCurrentDate
        dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = GMod.SessionCurrentDate



        If GMod.Getsession(dtvdate.Value) = GMod.Session Then
        Else
            ' Me.Close()
        End If

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and left(account_code,2) in ('**','" & cmbAreaCode.Text & "')"
        GMod.DataSetRet(sql, "aclist1")

        cmbcode.DataSource = GMod.ds.Tables("aclist1")
        cmbcode.DisplayMember = "account_code"
        cmbAcHead.DataSource = GMod.ds.Tables("aclist1")

        cmbAcHead.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclist1")
        ComboBox1.DisplayMember = "group_name"

        ComboBox2.DataSource = GMod.ds.Tables("aclist1")
        ComboBox2.DisplayMember = "sub_group_name"

        cmbAcHead.Focus()
        Label1.Text = cmbvoutype.Text
        Label6.Text = cmbvoutype.Text


        If GMod.role.ToUpper = "ADMIN" Then
            'btnModify.Enabled = True
            'btnDelete.Enabled = True
        Else
            'btnModify.Enabled = False
            'btnDelete.Enabled = False
        End If
        cmbvoutype.Focus()

        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"

        GMod.DataSetRet("SELECT DISTINCT favourof FROM chq_issue", "favour")
        cmbfavourof.DataSource = GMod.ds.Tables("favour")
        cmbfavourof.DisplayMember = "favourof"

        'nxtvno()

        'If cmbvoutype.Text = "" Then
        '    Me.Close()
        'End If

        'For Tds
        sql = "select * from TdsMater where cmp_id ='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "tdm")
        cmbtdsType.DataSource = GMod.ds.Tables("tdm")
        cmbtdsType.DisplayMember = "TdsType"
        cmbTdsper.DataSource = GMod.ds.Tables("tdm")
        cmbTdsper.DisplayMember = "Per"
        cmbacheadcode.DataSource = GMod.ds.Tables("tdm")
        cmbacheadcode.DisplayMember = "Acc_Code"
        FillAcHeadfortds()

    End Sub

    Private Sub dgPayment_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPayment.CellContentClick

    End Sub

    Private Sub dgPayment_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPayment.CellDoubleClick
        i = e.RowIndex
        cmbcode.Text = dgPayment(1, i).Value.ToString
        txtDramt.Text = dgPayment(2, i).Value.ToString
        txtCrmat.Text = dgPayment(3, i).Value.ToString

        ComboBox1.Text = dgPayment(4, i).Value.ToString
        ComboBox2.Text = dgPayment(5, i).Value.ToString

        txtNarration.Text = dgPayment(6, i).Value.ToString
        txtChqNo.Text = dgPayment(7, i).Value.ToString

    End Sub

    Private Sub dgPayment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgPayment.KeyDown
        Try
            If e.KeyCode = Keys.F3 And dgPayment.CurrentCell.ColumnIndex = 6 And dgPayment.CurrentCell.RowIndex > 0 Then
                dgPayment(6, dgPayment.CurrentCell.RowIndex).Value = dgPayment(6, dgPayment.CurrentCell.RowIndex - 1).Value
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgPayment_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgPayment.UserDeletedRow
        For j = 0 To dgPayment.Rows.Count - 1
            dr = dr + Val(dgPayment(2, j).Value)
            cr = cr + Val(dgPayment(3, j).Value)
        Next
        lblcr.Text = cr
        lblDr.Text = dr
        dr = 0
        cr = 0
        i = -1
    End Sub

    Private Sub txtDramt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDramt.Enter
        txtDramt.SelectAll()
    End Sub

    Private Sub txtDramt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDramt.KeyPress
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtDramt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDramt.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtDramt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDramt.Leave
        If txtDramt.Text = "" Then
            MsgBox("Please enter Dr amount")
            txtDramt.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub txtCrmat_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrmat.Enter
        txtCrmat.SelectAll()
    End Sub

    Private Sub txtCrmat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCrmat.KeyPress
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtCrmat_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCrmat.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCrmat_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrmat.Leave
        If txtCrmat.Text = "" Then
            MsgBox("Please enter Cr amount")
            txtCrmat.Focus()
            Exit Sub
        End If
    End Sub
    Sub nxtvno()
        Dim sql As String
        Try
            sql = "select isnull(max(cast(vou_no as numeric(18,0))),0) + 1 from dummy_VENTRY  where vou_type = '" & cmbvoutype.Text & "' and session ='" & GMod.Session & "'  and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "dvou_no")

            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & "  where vou_type = '" & cmbvoutype.Text & "'" ' and session ='" & GMod.Session & "'"
            GMod.DataSetRet(sql, "vnopay")
            'txtvou_no.Text = ds.Tables("vnopay").Rows(0)(0)


            If Val(ds.Tables("vnopay").Rows(0)(0)) > Val(ds.Tables("dvou_no").Rows(0)(0)) Then
                txtvou_no.Text = ds.Tables("vnopay").Rows(0)(0)
            Else
                txtvou_no.Text = ds.Tables("dvou_no").Rows(0)(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Try
        '    If GMod.ds.Tables("dvou_no").Rows.Count > 0 Then
        '        sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM dummy_VENTRY  where vou_type = '" & cmbvoutype.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
        '        GMod.DataSetRet(sql, "vnopay")
        '        txtvou_no.Text = ds.Tables("vnopay").Rows(0)(0)
        '    Else
        '        sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & "  where vou_type = '" & cmbvoutype.Text & "'" ' and session ='" & GMod.Session & "'"
        '        GMod.DataSetRet(sql, "vnopay")
        '        txtvou_no.Text = ds.Tables("vnopay").Rows(0)(0)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'If expflag = False Then
        '    MessageBox.Show("Please Select the Expense Month/Date", "Expenses Month/Date:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    dtpexpensedate.Focus()
        '    Exit Sub
        'End If
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

            'adiing Dr amount for ckecing to bill amount
            If amtchk > 0 Then
                Dim rcount1 As Integer = 0
                Dim dramtckh As Double = 0
                For rcount1 = 0 To dgPayment.Rows.Count - 1
                    dramtckh = dramtckh + Val(dgPayment(3, rcount1).Value)
                Next

                If dramtckh <> amtchk Then
                    MsgBox("Bill Amount and Dr Amount are differ")
                    Exit Sub
                End If
                dramtckh = 0
                amtchk = 0
            End If
            '------------------------------

            If cmbvoutype.Text = "" Then
                MsgBox("Please select voucher type", MsgBoxStyle.Critical)
                Me.Close()
            End If

            If cmbvoutype.Text = "CASH" Then
                txtCrmat.Enabled = False
            Else
                If Val(lblcr.Text) <> Val(lblDr.Text) Then
                    MsgBox("Dr Amount Not Equal To Cr Amount", MsgBoxStyle.Critical)
                    cmbAcHead.Focus()
                    Exit Sub
                End If
            End If
            Dim trans As SqlTransaction
            trans = GMod.SqlConn.BeginTransaction

            If btnSave.Enabled = True Then
                nxtvno()
            Else
                Dim cmdel As New SqlCommand("delete from dummy_VENTRY where vou_type='" & cmbvoutype.Text & "' and vou_no= '" & txtvou_no.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and Posted='N'", GMod.SqlConn, trans)
                cmdel.ExecuteNonQuery()

                Dim cmdel1 As New SqlCommand("delete from chq_issue where vou_type='" & cmbvoutype.Text & "' and vouno= '" & txtvou_no.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'", GMod.SqlConn, trans)
                cmdel1.ExecuteNonQuery()


                Dim cmdel2 As New SqlCommand("delete from bank_payment where vou_type='" & cmbvoutype.Text & "' and vou_no= '" & txtvou_no.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'", GMod.SqlConn, trans)
                cmdel2.ExecuteNonQuery()

            End If

            If btnSave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, txtvou_no.Text, cmbvoutype.Text, dtvdate.Value, Now, GMod.Session, "M", GMod.username)
            End If
            Try
                For j = 0 To dgPayment.Rows.Count - 1
                    sql = "insert into dummy_VENTRY ( Cmp_id, Uname, Entry_id," & _
                    " Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt," & _
                    " cramt, Pay_mode, Cheque_no, Narration, Group_name," & _
                    " Sub_group_name, Ch_issue_date, Ch_date,session,exp_date) values ("
                    sql &= "'" & GMod.Cmpid & "',"
                    sql &= "'" & GMod.username & "',"
                    sql &= "'" & j & "',"
                    sql &= "'" & txtvou_no.Text & "',"
                    sql &= "'" & cmbvoutype.Text & "',"
                    sql &= "'" & dtvdate.Value.ToShortDateString & "',"
                    sql &= "'" & dgPayment(1, j).Value & "',"
                    sql &= "'" & dgPayment(0, j).Value & "',"
                    sql &= "'" & Val(dgPayment(2, j).Value) & "',"
                    sql &= "'" & Val(dgPayment(3, j).Value) & "',"
                    sql &= "'-',"
                    sql &= "'" & dgPayment(7, j).Value.ToString & "',"
                    sql &= "'" & dgPayment(6, j).Value.ToString & "',"
                    sql &= "'" & dgPayment(4, j).Value & "',"
                    sql &= "'" & dgPayment(5, j).Value & "',"
                    sql &= "'1/1/2000',"
                    sql &= "'1/1/2000',"
                    sql &= "'" & GMod.Session & "',"
                    sql &= "'" & dtpexpensedate.Value.ToShortDateString & "')"

                    Dim cmd As New SqlCommand(sql, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()

                    If dgPayment(4, j).Value.ToString = "BANK" Then
                        sql = "insert into chq_issue(Cmp_id, Chq_no, favourof, recpitid, amount, Chq_date, Uname, Vouno, vou_type, code,session) values( "
                        sql &= "'" & GMod.Cmpid & "',"
                        sql &= "'" & dgPayment(7, j).Value.ToString & "',"
                        sql &= "'" & cmbfavourof.Text & "',"
                        sql &= "'" & ComboBox3.Text & "',"
                        sql &= "'" & Val(dgPayment(3, j).Value) & "',"
                        sql &= "'" & dtchequedate.Value.ToShortDateString & "',"
                        sql &= "'" & GMod.username & "',"
                        sql &= "'" & txtvou_no.Text & "',"
                        sql &= "'" & cmbvoutype.Text & "',"
                        sql &= "'" & dgPayment(1, j).Value & "',"
                        sql &= "'" & GMod.Session & "')"

                        Dim cmdchq As New SqlCommand(sql, GMod.SqlConn, trans)
                        cmdchq.ExecuteNonQuery()
                    End If
                Next

                Dim rcount As Integer = 0
                Dim amt As Double
                For rcount = 0 To dgBillNo.Rows.Count - 1
                    If dgBillNo(0, rcount).Value = 1 Then
                        'dgBillNo(0, rcount).Value = 1
                        sql = "insert into bank_payment(party_code, bill_no, bill_date, amt, session, cmp_id,vou_type,vou_no,dr_amt,tds_amt) values( "
                        sql &= "'" & acc_code & "',"
                        sql &= "'" & dgBillNo(1, rcount).Value & "',"
                        sql &= "'" & dgBillNo(2, rcount).Value & "',"
                        sql &= "'" & dgBillNo(3, rcount).Value & "',"
                        sql &= "'" & GMod.Session & "',"
                        sql &= "'" & GMod.Cmpid & "',"
                        sql &= "'" & cmbvoutype.Text & "',"
                        sql &= "'" & txtvou_no.Text & "',"
                        sql &= "'" & Val(dgBillNo(5, rcount).Value) & "',"
                        sql &= "'" & Val(dgBillNo(6, rcount).Value) & "')"
                        Dim cmd1 As New SqlCommand(sql, GMod.SqlConn, trans)
                        cmd1.ExecuteNonQuery()

                        'updating prcase data table field paid
                        sql = "update purchase_data set  paid = 1 where party_code ='" & acc_code & "' and session ='" & dgBillNo(4, rcount).Value.ToString.Trim & "' and cmp_id ='" & GMod.Cmpid & "' and bill_no ='" & dgBillNo(1, rcount).Value & "'" ' and vou_no ='" & txtvou_no.Text & "'"
                        Dim cmdpaid As New SqlCommand(sql, GMod.SqlConn, trans)
                        cmdpaid.ExecuteNonQuery()
                    End If
                Next

                If chkTdsEntry.Checked = True Then
                    sql = "insert into TdsEntry(Vou_Type, Vou_no, TdsType, Per, TdsDate, " _
                      & " BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt," _
                      & " Actualamt, session,Paidto,vou_date, TdsAmt,dcode,cmp_id) values( "
                    sql &= "'" & cmbvoutype.Text & "',"
                    sql &= "'" & txtvou_no.Text & "',"
                    sql &= "'" & cmbtdsType.Text & "',"
                    sql &= "'" & cmbTdsper.Text & "',"
                    sql &= "'" & dtvdate.Value.ToShortDateString & "',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & Val("") & "',"
                    sql &= "'-',"
                    sql &= "'" & Val(txtPaidAmt.Text) & "',"
                    sql &= "'" & Val(txtActualAmt.Text) & "',"
                    sql &= "'" & GMod.Session & "',"
                    sql &= "'-',"
                    sql &= "'" & dtvdate.Value.ToShortDateString & "',"
                    sql &= "'" & Val(txttdsAmount.Text) & "',"
                    sql &= "'" & cmbPartCode.Text & "',"
                    sql &= "'" & GMod.Cmpid & "')"

                    Dim cmd6 As New SqlCommand(sql, SqlConn, trans)
                    cmd6.ExecuteNonQuery()
                End If

                trans.Commit()
                MsgBox(cmbvoutype.Text & " / " & txtvou_no.Text, MsgBoxStyle.Information)

                dgPayment.Rows.Clear()
                dgBillNo.Rows.Clear()
                txtDramt.Clear()
                txtCrmat.Clear()
                txtNarration.Clear()
                txtChqNo.Clear()
                txtChqNo.Enabled = True
                txtCrmat.Enabled = True
                lblcr.Text = ""
                lblDr.Text = ""
                cmbAcHead.SelectedIndex = 0
                cmbcode.SelectedIndex = 0
                'cmbvoutype.Focus()
                cmbAcHead.Focus()
                cmbvoutype.SelectedIndex = 0

            Catch ex As Exception
                trans.Rollback()
                MsgBox(ex.Message)
            End Try
            i = -1
        Else
            MsgBox("CANCELLED")
            dtvdate.Focus()
            Exit Sub
        End If
        expflag = False
    End Sub

    Private Sub cmbAcHead_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAcHead.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAcHead_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAcHead.KeyUp

    End Sub

    Private Sub cmbAcHead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAcHead.Leave
        If cmbAcHead.FindStringExact(cmbAcHead.Text) = -1 Then
            MsgBox("Slecet correct head", MsgBoxStyle.Critical)
            cmbAcHead.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtNarration_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNarration.KeyPress
        e.Handled = True
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtNarration_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNarration.KeyUp
        If e.KeyCode = Keys.F4 Then
            Dim nl As New frmNarrationlist
            nl.ShowDialog()
            txtNarration.Text = nl.ComboBox1.Text
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtNarration_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNarration.TextChanged
        Me.Label9.Text = "Charchter Count: " & txtNarration.Text.Length
        Wcont()
    End Sub
    Sub Wcont()
        Dim NoWocount() As String
        NoWocount = txtNarration.Text.Split(" ")
        Me.Label9.Text = Me.Label9.Text & " Word Count: " & NoWocount.Length
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        'Cmp_id, Uname, Entry_id, Vou_no, Vou_type, 
        'Vou_date, Acc_head_code, Acc_head, dramt, cramt,
        'Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, 
        'Ch_issue_date, Ch_date
        If btnSave.Enabled Then
            btnSave.Enabled = False
            btnModify.Text = "&Update"
            'Dim i As Integer
            'Dim r As New frmvoucherlist
            'r.ShowDialog()
            'cmbvoutype.Text = r.cmbvtype.Text
            txtvou_no.Text = InputBox("Enter Voucher No:")
            If txtvou_no.Text = "" Then
                Exit Sub
                MsgBox("Please enter voucher no")
            End If
            cmbvoutype.Enabled = False
            'If LockDataCheck(txtvou_no.Text, GMod.Session, cmbvoutype.Text) = False Then
            '    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    btnReset_Click(sender, e)
            '    Exit Sub
            'End If
            sql = "select * from dummy_VENTRY where  vou_type ='" & cmbvoutype.Text & "' and vou_no='" & txtvou_no.Text & "' and session =  '" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and Posted='N'"
            GMod.DataSetRet(sql, "modifypay")
            If GMod.ds.Tables("modifypay").Rows.Count = 0 Then
                MsgBox("No voucher found", MsgBoxStyle.Critical)
                cmbvoutype.Enabled = False
                cmbvoutype.Focus()
                Exit Sub
            End If
            dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
            ' dtvdate.Value = CDate(GMod.ds.Tables("modifypay").Rows(0)("Vou_date"))

            'txtNarration.Text = GMod.ds.Tables("modifypay").Rows(0)("Narration")
            'txtChqNo.Text = GMod.ds.Tables("modifypay").Rows(0)("Cheque_no")
            For i = 0 To GMod.ds.Tables("modifypay").Rows.Count - 1
                dgPayment.Rows.Add()
                dgPayment(0, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Acc_head")
                dgPayment(1, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Acc_head_code")
                dgPayment(2, i).Value = GMod.ds.Tables("modifypay").Rows(i)("dramt")
                dgPayment(3, i).Value = GMod.ds.Tables("modifypay").Rows(i)("cramt")
                dgPayment(4, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Group_name")
                dgPayment(5, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Sub_group_name")
                dgPayment(6, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Narration")
                dgPayment(7, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Cheque_no")

            Next
            For j = 0 To dgPayment.Rows.Count - 1
                dr = dr + Val(dgPayment(2, j).Value)
                cr = cr + Val(dgPayment(3, j).Value)
            Next
            lblcr.Text = cr
            lblDr.Text = dr
            dr = 0
            cr = 0

        Else
            If MessageBox.Show("Do U want to Modify", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                btnSave_Click(sender, e)
                btnModify.Text = "&Modify"
                btnSave.Enabled = True
                cmbvoutype.Enabled = True
                txtvou_no.Clear()
                dtvdate_ValueChanged_1(sender, e)
            Else
                btnModify.Text = "&Modify"
                btnSave.Enabled = True
                cmbvoutype.Enabled = True
                txtvou_no.Clear()
                dgPayment.Rows.Clear()
                txtDramt.Clear()
                txtCrmat.Clear()
                txtNarration.Clear()
                txtChqNo.Clear()
                cmbvoutype.Focus()
                dtvdate_ValueChanged_1(sender, e)
            End If
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        btnModify.Text = "&Modify"
        btnSave.Enabled = True
        cmbvoutype.Enabled = True
        txtvou_no.Clear()
        dgPayment.Rows.Clear()
        txtDramt.Clear()
        txtCrmat.Clear()
        txtNarration.Clear()
        txtChqNo.Clear()
        cmbvoutype.Focus()
    End Sub

    Private Sub cmbcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            'txtDramt.Focus()
        End If
    End Sub
    Dim acc_code As String
    Private Sub cmbcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcode.Leave
        Try
            'cmbcode.Enabled = False
            sql = "select account_code from " & GMod.ACC_HEAD & " where account_head_name = '" & cmbAcHead.Text & "' and  Area_code ='" & cmbAreaCode.Text & "'"
            GMod.DataSetRet(sql, "account_codepayment")
            If GMod.ds.Tables("account_codepayment").Rows.Count > 0 Then
                If cmbcode.Text.Trim <> GMod.ds.Tables("account_codepayment").Rows(0)(0) Then
                    MsgBox("A/c Name and Code are Different", MsgBoxStyle.Information)
                    cmbAcHead.Focus()
                    Exit Sub
                End If
            Else
                cmbAcHead.Focus()
                Exit Sub
            End If


            'check for party balance 
            sql = "select q.account_code,q.acname," _
                        & " DrAmt = case when  ((isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0))  > 0 then  (isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0) else 0 end, " _
                        & " CrAmt = case when  ((isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0))  < 0 then  abs((isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0)) else 0 end," _
                        & " q.group_name," _
                        & " isnull(p.dramt,0) + isnull(0,0) d , isnull(p.cramt,0) + 0 c , q.odr, q.ocr " _
                        & " from (" _
                        & " select isnull(sum(dramt),0) dramt ,isnull(sum(cramt),0) cramt,acc_head_code" _
                        & " from " & GMod.VENTRY & " " _
                        & " where vou_date<='" & Now & "' and Pay_mode<>'-'" _
                        & " group by acc_head_code ) p " _
                        & " Right Join " _
                        & " ( select account_code,account_head_name acname ,group_name, isnull(opening_dr,0) odr  , " _
                        & " isnull(opening_cr,0) ocr from " & GMod.ACC_HEAD & " where account_code='" & cmbcode.Text.Trim & "' and group_name ='PARTY'  ) q " _
                        & " on p.acc_head_code=q.account_code  " _
                      & " where ((isnull(p.dramt,0) + q.odr) <> (isnull(p.cramt,0) + q.ocr))  "
            GMod.DataSetRet(sql, "checkbalparty")
            Dim flagch As Boolean
            If ds.Tables("checkbalparty").Rows.Count > 0 Then

            Else
                Exit Sub
            End If
            '--------------------------------------------------------------

            If dgBillNo.RowCount > 1 Then
                Exit Sub
            End If
            If chkpayment.Checked = True Then
                acc_code = cmbcode.Text
                'SelectQuery = "select party_code, bill_no,bill_date, sum(party_amt) amt ,session  from " & _
                ' " purchase_data group by bill_no,bill_date ,party_code,session" & _
                ' " having session ='" & GMod.Session & "' and Party_code='" & cmbcode.Text & "' order by bill_date"
                acc_code = cmbcode.Text
                '    SelectQuery = "select * from (" _
                '& " select distinct bill_no,  party_code, bill_date, sum(party_amt) amt ,session ,cmp_id " _
                '& " from  purchase_data group by bill_no,bill_date ,party_code,session ,cmp_id,id" _
                '& " having session ='" & GMod.Session & "' and Party_code='" & cmbcode.Text & "') p where p.bill_no not in " _
                '& " (select bill_no from bank_payment b where " _
                '& " p.party_code =b.party_code and p.session=b.session and p.cmp_id=b.cmp_id ) "


                ' SelectQuery = " select distinct bill_no,  party_code, bill_date, sum(party_amt) amt ,session ,cmp_id,paid,vou_type " _
                '& " from  purchase_data group by bill_no,bill_date ,party_code,session ,cmp_id,id,paid,vou_type" _
                '& " having session ='" & GMod.Session & "' and Party_code='" & cmbcode.Text & "' and paid =0 and cmp_id ='" & GMod.Cmpid & "' and vou_type <>'DR Note(PUR)'"

                GMod.SqlExecuteNonQuery("exec [p_bank_billing_new] '" & GMod.Session & "','" & cmbcode.Text & "','" & GMod.Cmpid & "','" & GMod.username & "'")
                GMod.SqlExecuteNonQuery("exec [p_bank_billing_new_prev] '" & GMod.PrevSession & "','" & cmbcode.Text & "','" & GMod.Cmpid & "','" & GMod.username & "'")

                SelectQuery = "select * from bank_billing  where party_code='" & cmbcode.Text & "' and cmp_id ='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'"
                GMod.DataSetRet(SelectQuery, "party_bill")
                Dim party_bill_count As Integer
                dgBillNo.Rows.Clear()
                For party_bill_count = 0 To GMod.ds.Tables("party_bill").Rows.Count - 1
                    dgBillNo.Rows.Add()
                    dgBillNo(1, party_bill_count).Value = GMod.ds.Tables("party_bill").Rows(party_bill_count)(0).ToString
                    dgBillNo(2, party_bill_count).Value = GMod.ds.Tables("party_bill").Rows(party_bill_count)(2).ToString
                    dgBillNo(3, party_bill_count).Value = GMod.ds.Tables("party_bill").Rows(party_bill_count)(3).ToString
                    dgBillNo(4, party_bill_count).Value = GMod.ds.Tables("party_bill").Rows(party_bill_count)("Session").ToString
                    dgBillNo(5, party_bill_count).Value = GMod.ds.Tables("party_bill").Rows(party_bill_count)("debit_amt").ToString
                    dgBillNo(6, party_bill_count).Value = GMod.ds.Tables("party_bill").Rows(party_bill_count)("tds_amt").ToString
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try


        'GMod.DataSetRet("select * from chqlayout where acc_head_code='" & cmbcode.Text & "'", "chq")
    End Sub
    Private Sub cmbRefType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Dim vouno As Long
    Dim ddate As DateTime = CDate("1/1/2000")
    Dim sqlsavecr As String

    Private Sub cmbvoutype_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvoutype.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbvoutype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvoutype.Leave
        If cmbvoutype.Text = "CASH" Then
            txtCrmat.Enabled = False
            'txtChqNo.Enabled = False
        End If

    End Sub

    Private Sub cmbvoutype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvoutype.SelectedIndexChanged
        Label1.Text = cmbvoutype.Text
        Label6.Text = cmbvoutype.Text
    End Sub
    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---- Resting date to server date 
        'GMod.DataSetRet("select getdate()", "serverdate")
        'dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        'dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Close()

        'Dim sqlupdate As String
        'GMod.DataSetRet("select * from dbo.chqLayout where acc_head_code='" & cmbcode.Text & "'", "ChqLayout")
        'If GMod.ds.Tables("ChqLayout").Rows.Count > 0 Then
        '    Dim i As Integer = 0
        '    Try
        '        chqdocument.DefaultPageSettings = chqsetup.PageSettings
        '        ' Dim customPaperSize As New Printing.PaperSize("8x10", Val(GMod.ds.Tables("chq").Rows(0)("cqhh")), Val(GMod.ds.Tables("chq").Rows(0)("chqw")))
        '        chqdocument.Print()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If

    End Sub

    Private Sub dtvdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtvdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtvou_no_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvou_no.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtChqNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChqNo.KeyPress
        e.Handled = True
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtChqNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChqNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtref_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtduedate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtduedate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtamount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtDramt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDramt.TextChanged
        If Val(txtDramt.Text) > 0 Then
            txtCrmat.Enabled = False
        Else
            txtCrmat.Enabled = True
        End If
    End Sub

    Private Sub txtCrmat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrmat.TextChanged
        If Val(txtCrmat.Text) > 0 Then
            txtDramt.Enabled = False
        Else
            txtDramt.Enabled = True
        End If
    End Sub

    Private Sub dtvdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtvdate.Leave
        GMod.DataSetRet("select isnull(max(vou_date),'" & dtvdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvoutype.Text & "'", "getMaxDate")
        If dtvdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
            MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            dtvdate.Focus()
        End If
    End Sub

    Private Sub dtvdate_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.ValueChanged

        'If btnSave.Enabled = True Then
        '    GMod.DataSetRet("select getdate()", "serverdate")
        '    dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        '    dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        'End If

        'Setting voucher date accrding to session
        'dtvdate.Value = GMod.SessionCurrentDate
        dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = GMod.SessionCurrentDate
    End Sub
    Private Sub chkpayment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpayment.CheckedChanged
        'If chkpayment.Checked = True Then
        '    chkpayment.Checked = False
        'End If
    End Sub
    Private Sub chkpayment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkpayment.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkpayment_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkpayment.KeyUp

    End Sub

    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and left(account_code,2) in ('**','" & cmbAreaCode.Text & "')"
        GMod.DataSetRet(sql, "aclist1")

        cmbcode.DataSource = GMod.ds.Tables("aclist1")
        cmbcode.DisplayMember = "account_code"
        cmbAcHead.DataSource = GMod.ds.Tables("aclist1")
        cmbAcHead.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclist1")
        ComboBox1.DisplayMember = "group_name"

        ComboBox2.DataSource = GMod.ds.Tables("aclist1")
        ComboBox2.DisplayMember = "sub_group_name"
    End Sub


    Dim amtchk As Double = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rcount As Integer = 0
        Dim amt As Double
        amt = 0
        amtchk = 0
        For rcount = 0 To dgBillNo.Rows.Count - 1
            If dgBillNo(0, rcount).Value = 1 Then
                amt = amt + (Val(dgBillNo(3, rcount).Value) - Val(dgBillNo(5, rcount).Value) - Val(dgBillNo(6, rcount).Value))
                amtchk = amt

                ' MessageBox.Show(dgBillNo(0, rcount).Value.ToString() + "  " + dgBillNo(1, rcount).Value.ToString)
            End If
        Next
        dgBillNo.Enabled = False
        txtDramt.Text = amt
        amt = 0

    End Sub
    Dim ivar As Integer
    Dim headfont As Font
    Dim bodyfont As Font
    Dim sp(3) As String
    Dim amountstr As String
    Private Sub chqdocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles chqdocument.PrintPage
        headfont = New Font("arial", 11, FontStyle.Bold)
        bodyfont = New Font("Arial", 10)
        e.Graphics.DrawString(dtchequedate.Text.ToString, bodyfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("chq_datex"), GMod.ds.Tables("chq").Rows(0)("chq_datey"))
        spliter(titlecase(cmbfavourof.Text.Trim))
        e.Graphics.DrawString(sp(0), headfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("infavx"), GMod.ds.Tables("chq").Rows(0)("infavy"))
        e.Graphics.DrawString(sp(1), headfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("infavx1"), GMod.ds.Tables("chq").Rows(0)("infavy1"))
        spliter(titlecase(splitNumber(txtDramt.Text) & "Only"))
        e.Graphics.DrawString(sp(0), bodyfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("amtinwx"), GMod.ds.Tables("chq").Rows(0)("amtinwy"))
        e.Graphics.DrawString(sp(1), bodyfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("amtinwx1"), GMod.ds.Tables("chq").Rows(0)("amtinwy1"))
        e.Graphics.DrawString(txtDramt.Text.ToString.PadLeft(12, "*"), headfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("amtx"), GMod.ds.Tables("chq").Rows(0)("amty"))
    End Sub
    Function splitNumber(ByVal number As String) As String
        Dim num() As String
        Dim retval As String
        num = number.Split(".")
        If num(1) = "00" Then
            retval = NameOfNumber(num(0), True, 9999)
        Else
            retval = NameOfNumber(num(0), True, 9999) & "and "
            retval &= NameOfNumber(num(1), True, 9999) & "paise"
        End If
        splitNumber = retval
    End Function
    Sub spliter(ByVal st As String)
        Try
            Dim word() As String
            word = st.Split(" ")
            sp(0) = ""
            sp(1) = ""
            Dim i As Integer
            For i = 0 To word.Length - 1
                If sp(0).Length < 50 Then
                    sp(0) = sp(0) & word(i) & " "
                Else
                    sp(1) = sp(1) & word(i) & " "
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function titlecase(ByVal str As String) As String
        Dim ar(), st As String
        ar = str.Split(" ")
        Dim i As Integer
        For i = 0 To ar.Length - 1
            st = st & ar(i).Substring(0, 1).ToUpper & (ar(i).Substring(1, ar(i).Length - 1).ToLower) & " "
        Next
        titlecase = st
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim t As New frmVoucherPrint
        t.ShowDialog()
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim t As New frmPostDataToacc
        t.ShowDialog()
    End Sub



    Private Sub cmbcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcode.SelectedIndexChanged

    End Sub

    Private Sub cmbAcHead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAcHead.SelectedIndexChanged

    End Sub

    Private Sub dtpexpensedate_ValueChanged(sender As Object, e As EventArgs) Handles dtpexpensedate.ValueChanged
        expflag = True
    End Sub

    Private Sub dtchequedate_ValueChanged(sender As Object, e As EventArgs) Handles dtchequedate.ValueChanged
        dtpexpensedate.Value = dtchequedate.Value
    End Sub

    Private Sub dgBillNo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBillNo.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

       
        Dim rcount As Integer
        For rcount = 0 To dgBillNo.Rows.Count - 1
                'If dgBillNo(0, rcount).Value = 1 Then
                dgBillNo(0, rcount).Value = 0
                'End If
            Next
            dgBillNo.Enabled = True
            txtDramt.Text = 0


            sql = "insert into bankreset(party_code,dt) values('" & cmbcode.Text & "','" & Now & "')"
            GMod.SqlExecuteNonQuery(sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub FillAcHeadfortds()
       

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and group_name like '%PARTY%'"
        GMod.DataSetRet(sql, "aclist20")
        cmbPartCode.DataSource = GMod.ds.Tables("aclist20")
        cmbPartCode.DisplayMember = "account_code"
        cmbPartyHead.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyHead.DisplayMember = "account_head_name"
        cmbPartyGroup.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyGroup.DisplayMember = "group_name"
       

        
    End Sub

    Private Sub cmbtdsType_Leave(sender As Object, e As EventArgs)

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and account_code='" & cmbacheadcode.Text & "'"
        GMod.DataSetRet(sql, "aclist2")
        cmbTdsCode.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsCode.DisplayMember = "account_code"
        cmbTdsHead.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsHead.DisplayMember = "account_head_name"
        CmbTdsGroup.DataSource = GMod.ds.Tables("aclist2")
        CmbTdsGroup.DisplayMember = "group_name"

    End Sub

    Private Sub cmbtdsType_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPaidAmt_TextChanged(sender As Object, e As EventArgs) Handles txtPaidAmt.TextChanged
        txttdsAmount.Text = Math.Ceiling(Val(txtPaidAmt.Text) * (Val(cmbTdsper.Text) / 100))
    End Sub

    Private Sub chkTdsEntry_CheckedChanged(sender As Object, e As EventArgs) Handles chkTdsEntry.CheckedChanged
        If chkTdsEntry.Checked = True Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

   
   
    Private Sub cmbtdsType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbtdsType.SelectedIndexChanged
        cmbtdsType_Leave_1(sender, e)
    End Sub

    Private Sub cmbtdsType_Leave_1(sender As Object, e As EventArgs) Handles cmbtdsType.Leave
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and account_code='" & cmbacheadcode.Text & "'"
        GMod.DataSetRet(sql, "aclist2")
        cmbTdsCode.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsCode.DisplayMember = "account_code"
        cmbTdsHead.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsHead.DisplayMember = "account_head_name"
        CmbTdsGroup.DataSource = GMod.ds.Tables("aclist2")
        CmbTdsGroup.DisplayMember = "group_name"
        ' cmbTdsSubGroup.DataSource = GMod.ds.Tables("aclist2")
        ' cmbTdsSubGroup.DisplayMember = "sub_group_name"
    End Sub
End Class