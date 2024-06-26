Imports System.Data.SqlClient
Public Class frmExpensesWithVeh_Detials

    Dim i As Integer = -1
    Dim j As Integer
    Dim cr, dr As Double
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If Val(txtDramt.Text) + Val(txtCrmat.Text) = 0 Then
            MsgBox("Either Cr or Dr is Zero", MsgBoxStyle.Information)
            txtDramt.Focus()
            Exit Sub
        End If
        Dim obj() As Object = {cmbAcHead.Text, cmbcode.Text, txtDramt.Text, txtCrmat.Text, ComboBox1.Text, ComboBox2.Text, txtNarration.Text}
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
        txtCrmat.Text = "0.0"
        txtDramt.Text = "0.0"
        txtNarration.Text = ""
    End Sub
    Dim sql As String
    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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


        dtpexpensedate.Value = CDate("1/1/2000")
        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and  vou_no_seq=2 and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "CRVT")
        cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
        cmbvoutype.DisplayMember = "vtype"


        fillArea()
        fillheads()
        cmbAcHead.Focus()

        Label1.Text = cmbvoutype.Text
        Label6.Text = cmbvoutype.Text

        'filling production unit 
        GMod.DataSetRet("select prdunit from prdunit where cmp_id='" & GMod.Cmpid & "'", "prdunit")
        cmbprdunit.DataSource = GMod.ds.Tables("prdunit")
        cmbprdunit.DisplayMember = "prdunit"

        cmbdetials.SelectedIndex = 0

        If GMod.role.ToUpper = "ADMIN" Then
            ' btnModify.Enabled = True
            'btnDelete.Enabled = True
        Else
            'btnModify.Enabled = False
            ' btnDelete.Enabled = False
        End If
        If GMod.Getsession(dtvdate.Value) = GMod.Session Then

        Else
            Me.Close()
        End If
    End Sub
    Sub fillheads()
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



    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
        'cmbAreaCode.Text = GMod.AreaCode

        sqlarea = "select group_name from groups where cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sqlarea, "gn")

        cmbgroup.DataSource = GMod.ds.Tables("gn")
        cmbgroup.DisplayMember = "group_name"

    End Sub

    Private Sub dgPayment_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPayment.CellDoubleClick
        i = e.RowIndex
        cmbcode.Text = dgPayment(1, i).Value.ToString
        txtDramt.Text = dgPayment(2, i).Value.ToString
        txtCrmat.Text = dgPayment(3, i).Value.ToString

        ComboBox1.Text = dgPayment(4, i).Value.ToString
        ComboBox2.Text = dgPayment(5, i).Value.ToString

        txtNarration.Text = dgPayment(6, i).Value.ToString
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

    Private Sub txtDramt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDramt.TextChanged
        If Val(txtDramt.Text) > 0 Then
            txtCrmat.Enabled = False
        Else
            txtCrmat.Enabled = True
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

    Private Sub txtCrmat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrmat.TextChanged
        If Val(txtCrmat.Text) > 0 Then
            txtDramt.Enabled = False
        Else
            txtDramt.Enabled = True
        End If
    End Sub
    Sub nxtvno()
        Dim sql As String
        Try
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & cmbvoutype.Text & "'"
            GMod.DataSetRet(sql, "vnopay")
            txtvou_no.Text = ds.Tables("vnopay").Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            'Cheching for Duplicate voucher in Connection Break.

            If Val(lblcr.Text) <> Val(lblDr.Text) Then
                MsgBox("Dr Amount Not Equal To Cr Amount", MsgBoxStyle.Critical)
                cmbAcHead.Focus()
                Exit Sub
            End If
            Dim trans As SqlTransaction
            trans = GMod.SqlConn.BeginTransaction
            If btnSave.Enabled = True Then
                nxtvno()
                If btnSave.Enabled = True Then
                    GMod.DataSetRet("select * from " & GMod.VENTRY & " where vou_type= '" & cmbvoutype.Text & "' and vou_no='" & txtvou_no.Text & "'", "ckechVoucher")
                    If GMod.ds.Tables("ckechVoucher").Rows.Count > 0 Then
                        MsgBox("Duplicate Voucher", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            Else
                Dim cmdel As New SqlCommand("delete from " & GMod.VENTRY & " where vou_type='" & cmbvoutype.Text & "' and vou_no= '" & txtvou_no.Text & "'", GMod.SqlConn, trans)
                cmdel.ExecuteNonQuery()

                Dim cmdel1 As New SqlCommand("delete from Expenses_det where vou_type='" & cmbvoutype.Text & "' and vou_no= '" & txtvou_no.Text & "' and session='" & GMod.Session & "'", GMod.SqlConn, trans)
                cmdel1.ExecuteNonQuery()
            End If



            '------------------------------------------------------------------------

            Try
                For j = 0 To dgPayment.Rows.Count - 1
                    sql = "insert into " & GMod.VENTRY & "( Cmp_id, Uname, Entry_id," & _
                    " Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt," & _
                    " cramt, Pay_mode, Cheque_no, Narration, Group_name," & _
                    " Sub_group_name, Ch_issue_date, Ch_date) values ("
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
                    sql &= "'" & txtChqNo.Text & "',"
                    sql &= "'" & dgPayment(6, j).Value & "',"
                    sql &= "'" & dgPayment(4, j).Value & "',"
                    sql &= "'" & dgPayment(5, j).Value & "',"
                    sql &= "'1/1/2000',"
                    sql &= "'" & dtpexpensedate.Value.ToShortDateString & "')"

                    Dim cmd As New SqlCommand(sql, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                Next

                sql = "insert into Expenses_det(vou_type, vou_no, acc_code, acc_name, hatch_date, no_of_chicks, area, deisel, toll_tax, da, other, driver_name, la_ul, uname, session, ltrsmt, totalkms, ltrscash, ltrsbpcl, opnr, clsr, gprs, prd, mor, sht) "
                sql &= " select vou_type, " & txtvou_no.Text & ", acc_code, acc_name, hatch_date, no_of_chicks, area, deisel, toll_tax, da, other, driver_name, la_ul, uname, session, ltrsmt, totalkms, ltrscash, ltrsbpcl, opnr, clsr, gprs, prd, mor, sht from Expenses_tmp where uname ='" & GMod.username & "'"
                Dim cmd1 As New SqlCommand(sql, GMod.SqlConn, trans)
                cmd1.ExecuteNonQuery()


                Dim cmdd As New SqlCommand("delete from Expenses_tmp where uname ='" & GMod.username & "'", GMod.SqlConn, trans)
                cmdd.ExecuteNonQuery()

                trans.Commit()
                MsgBox(cmbvoutype.Text & " / " & txtvou_no.Text, MsgBoxStyle.Information)
                dgPayment.Rows.Clear()
                txtDramt.Clear()
                txtCrmat.Clear()
                txtNarration.Clear()
                txtChqNo.Clear()
                cmbvoutype.Focus()
                i = -1
                cmbAcHead.SelectedIndex = 0
                cmbcode.SelectedIndex = 0
                DataGridView1.DataSource = Nothing
                DataGridView1.Rows.Clear()
            Catch ex As Exception
                trans.Rollback()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub cmbAcHead_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAcHead.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
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

            Try
                btnSave.Enabled = False
                btnModify.Text = "&Update"
                Dim i As Integer
                Dim r As New frmvoucherlist
                r.ShowDialog()
                cmbvoutype.Text = r.cmbvtype.Text
                txtvou_no.Text = r.txtvouno.Text
                cmbvoutype.Enabled = False
                'for exp det 
                vou_type = r.cmbvtype.Text
                vou_no = r.txtvouno.Text
                setModifyFlag = True
                '------------
                If LockDataCheck(r.txtvouno.Text, GMod.Session, r.cmbvtype.Text) = False Then
                    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'btnReset_Click(sender, e)
                    ' Exit Sub
                End If

                sql = "select * from " & GMod.VENTRY & " where  vou_type ='" & cmbvoutype.Text & "' and vou_no='" & txtvou_no.Text & "'  order by entry_id"
                GMod.DataSetRet(sql, "modifypay")
                dtvdate.Value = CDate(GMod.ds.Tables("modifypay").Rows(0)("Vou_date"))
                'txtNarration.Text = GMod.ds.Tables("modifypay").Rows(0)("Narration")
                txtChqNo.Text = GMod.ds.Tables("modifypay").Rows(0)("Cheque_no")
                For i = 0 To GMod.ds.Tables("modifypay").Rows.Count - 1
                    dgPayment.Rows.Add()
                    dgPayment(0, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Acc_head")
                    dgPayment(1, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Acc_head_code")
                    dgPayment(2, i).Value = GMod.ds.Tables("modifypay").Rows(i)("dramt")
                    dgPayment(3, i).Value = GMod.ds.Tables("modifypay").Rows(i)("cramt")
                    dgPayment(4, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Group_name")
                    dgPayment(5, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Sub_group_name")
                    dgPayment(6, i).Value = GMod.ds.Tables("modifypay").Rows(i)("narration")

                Next
                For j = 0 To dgPayment.Rows.Count - 1
                    dr = dr + Val(dgPayment(2, j).Value)
                    cr = cr + Val(dgPayment(3, j).Value)
                Next
                lblcr.Text = cr
                lblDr.Text = dr
                dr = 0
                cr = 0


                'sql = "select * from Expenses_det where vou_type='" & cmbvoutype.Text & "' and vou_no='" & txtvou_no.Text & "' and session='" & GMod.Session & "'"
                sql = "select convert(varchar, hatch_date, 3) hatch_date,area,no_of_chicks,deisel,toll_tax,da,la_ul,other,totalkms,ltrsmt,driver_name,acc_name,acc_code from Expenses_det where vou_type='" & GMod.vou_type & "' and vou_no='" & GMod.vou_no & "' and session ='" & GMod.Session & "'"
                GMod.DataSetRet(sql, "exp_det")
                Dim z As New frmExpenseEntry

                'z.txtAcName.Text = GMod.ds.Tables("Expenses_det").Rows(0)("acc_name")
                'z.lblcode.Text = GMod.ds.Tables("Expenses_det").Rows(0)("acc_code")
                z.txtvou_type.Text = cmbvoutype.Text
                z.txtvou_no.Text = txtvou_no.Text

                For i = 0 To GMod.ds.Tables("exp_det").Rows.Count - 1
                    z.dgexpenses.Rows.Add()
                    z.dgexpenses(0, i).Value = GMod.ds.Tables("exp_det").Rows(i)(0)
                    z.dgexpenses(1, i).Value = GMod.ds.Tables("exp_det").Rows(i)(1)
                    z.dgexpenses(2, i).Value = GMod.ds.Tables("exp_det").Rows(i)(2)
                    z.dgexpenses(3, i).Value = GMod.ds.Tables("exp_det").Rows(i)(3)
                    z.dgexpenses(4, i).Value = GMod.ds.Tables("exp_det").Rows(i)(4)
                    z.dgexpenses(5, i).Value = GMod.ds.Tables("exp_det").Rows(i)(5)
                    z.dgexpenses(6, i).Value = GMod.ds.Tables("exp_det").Rows(i)(6)
                    z.dgexpenses(7, i).Value = GMod.ds.Tables("exp_det").Rows(i)(7)
                    z.dgexpenses(8, i).Value = GMod.ds.Tables("exp_det").Rows(i)(8)
                    z.dgexpenses(9, i).Value = GMod.ds.Tables("exp_det").Rows(i)(9)
                    z.dgexpenses(10, i).Value = GMod.ds.Tables("exp_det").Rows(i)(10)
                    z.dgexpenses(11, i).Value = GMod.ds.Tables("exp_det").Rows(i)(11)
                    z.dgexpenses(12, i).Value = GMod.ds.Tables("exp_det").Rows(i)(12)
                    'z.dgexpenses(13, i).Value = GMod.ds.Tables("exp_det").Rows(i)(13)
                Next
                z.ShowDialog()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            If MessageBox.Show("Do U want to Modify", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                GMod.Fill_Log(GMod.Cmpid, txtvou_no.Text, cmbvoutype.Text, dtvdate.Value, Now, GMod.Session, "M", GMod.username)
                btnSave_Click(sender, e)
                btnModify.Text = "&Modify"
                btnSave.Enabled = True
                cmbvoutype.Enabled = True
                txtvou_no.Clear()
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

    Private Sub cmbvoutype_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvoutype.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbvoutype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvoutype.SelectedIndexChanged
        Label1.Text = cmbvoutype.Text
        Label6.Text = cmbvoutype.Text
    End Sub

    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        fillheads()
    End Sub

    Private Sub cmbgroup_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgroup.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgroup.SelectedIndexChanged
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and Area_code in ('**','" & cmbAreaCode.Text & "') and group_name ='" & cmbgroup.Text & "'"
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

    Private Sub cmbdetials_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdetials.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbdetials_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdetials.Leave
        If cmbdetials.Text = "YES" Then
            Dim t As New frmExpenseEntry
            t.txtAcName.Text = cmbAcHead.Text
            t.lblcode.Text = cmbcode.Text
            t.txtvou_type.Text = cmbvoutype.Text
            t.ShowDialog()
            txtNarration.Text = t.txtNarration.Text
        End If
    End Sub

    Private Sub cmbdetials_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdetials.SelectedIndexChanged


    End Sub

    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---- Resting date to server date 
        GMod.DataSetRet("select getdate()", "serverdate")
        dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim t As New frmTdsEntry
            t.ShowDialog()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Close()
    End Sub

    Private Sub dtvdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtvdate_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---- Resting date to server date 
        GMod.DataSetRet("select getdate()", "serverdate")
        dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

    End Sub

    Private Sub txtvou_no_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvou_no.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtvou_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvou_no.TextChanged

    End Sub

    Private Sub cmbprdunit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbprdunit.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbprdunit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprdunit.SelectedIndexChanged

    End Sub

    Private Sub cmbExpType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbExpType.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbExpType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExpType.SelectedIndexChanged

    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAreaName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.SelectedIndexChanged

    End Sub

    Private Sub cmbcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcode.Leave
        sql = "select account_code from " & GMod.ACC_HEAD & " where account_head_name = '" & cmbAcHead.Text & "' and  Area_code ='" & cmbAreaCode.Text & "'"
        GMod.DataSetRet(sql, "account_codeexpenses")
        If GMod.ds.Tables("account_codeexpenses").Rows.Count > 0 Then
            If cmbcode.Text.Trim <> GMod.ds.Tables("account_codeexpenses").Rows(0)(0) Then
                MsgBox("A/c Name and Code are Different", MsgBoxStyle.Information)
                cmbAcHead.Focus()
                Exit Sub
            End If
        Else
            cmbAcHead.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub cmbcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcode.SelectedIndexChanged

    End Sub

    Private Sub txtChqNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChqNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtChqNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChqNo.TextChanged

    End Sub

    Private Sub dtpexpensedate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpexpensedate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpexpensedate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpexpensedate.ValueChanged

    End Sub

    Private Sub dtvdate_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtvdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtvdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtvdate.Leave
        If btnSave.Enabled = True Then
            GMod.DataSetRet("select isnull(max(vou_date),'" & dtvdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvoutype.Text & "'", "getMaxDate")
            If dtvdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
                MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dtvdate.Focus()
            End If
        End If
    End Sub



    Private Sub detadd_Click(sender As Object, e As EventArgs) Handles detadd.Click

        Try
            sql = "insert into Expenses_tmp (vou_type, vou_no, acc_code, acc_name, hatch_date,"
            sql &= " no_of_chicks, area, deisel, toll_tax, da, other, driver_name, la_ul, uname, session,"
            sql &= " ltrsmt, totalkms, ltrscash, ltrsbpcl, opnr, clsr, gprs, prd,mor,sht) values("
            sql &= "'" & cmbvoutype.Text & "',"
            sql &= "'0',"
            sql &= "'" & cmbcode.Text & "',"
            sql &= "'" & cmbAcHead.Text & "',"
            sql &= "'" & dtpHatchDt.Value.ToShortDateString & "',"
            sql &= "'" & Val(txtNoChicks.Text) & "',"
            sql &= "'" & txtarea.Text & "',"
            sql &= "'" & Val(txtDeisel.Text) & "',"
            sql &= "'" & Val(txtToll.Text) & "',"
            sql &= "'" & Val(txtda.Text) & "',"
            sql &= "'" & Val(txtOther.Text) & "',"
            sql &= "'" & txtDriverName.Text & "',"
            sql &= "'" & Val(txtLA.Text) & "',"
            sql &= "'" & GMod.username & "',"
            sql &= "'" & GMod.Session & "',"
            sql &= "'" & Val(txtDMt.Text) & "',"
            sql &= "'" & Val(txtTotalkm.Text) & "',"
            sql &= "'" & Val(txtDCash.Text) & "',"
            sql &= "'" & Val(txtDBpcl.Text) & "',"
            sql &= "'" & Val(txtOpkr.Text) & "',"
            sql &= "'" & Val(txtCLr.Text) & "',"
            sql &= "'" & Val(txtGprsr.Text) & "',"
            sql &= "'" & cmbprd.Text & "',"
            sql &= "'" & Val(txtMor.Text) & "',"
            sql &= "'" & Val(txtShot.Text) & "')"
            GMod.SqlExecuteNonQuery(sql)
        Catch ex As Exception
            MessageBox.Show("Error...")

        End Try
        Dim narr As String
        If Val(txtNoChicks.Text) > 0 Then
            narr = "BEING VEHICLE SUPPLY EXPENSES ON HATCH DATE " & dtpHatchDt.Text & " TO " & txtarea.Text & "," & cmbprd.Text & " QTY. " & txtNoChicks.Text & " THROUGH " & txtDriverName.Text & ""
        Else
            narr = "BEING VEHICLE SUPPLY EXPENSES ON  DATE " & dtpHatchDt.Text & " TO " & txtarea.Text & "," & cmbprd.Text & " THROUGH " & txtDriverName.Text & ""

        End If

        txtNarration.Text = narr
        fillg()

        txtarea.Clear()
        txtDeisel.Clear()
        txtToll.Clear()
        txtda.Clear()
        txtOther.Clear()
        txtDriverName.Clear()
        txtLA.Clear()
        txtDMt.Clear()
        txtTotalkm.Clear()
        txtDCash.Clear()
        txtDBpcl.Clear()
        txtOpkr.Clear()
        txtCLr.Clear()
        txtGprsr.Clear()
        txtMor.Clear()
        txtShot.Clear()
        txtNoChicks.Clear()
    End Sub
    Sub fillg()
        Try
            sql = "select * from Expenses_tmp where uname='" & GMod.username & "'"
            GMod.DataSetRet(sql, "vehdetnew")
            DataGridView1.DataSource = GMod.ds.Tables("vehdetnew")

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtDCash_TextChanged(sender As Object, e As EventArgs) Handles txtDCash.TextChanged
        TextBox1.Text = Val(txtDCash.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)
    End Sub

    Private Sub txtToll_TextChanged(sender As Object, e As EventArgs) Handles txtToll.TextChanged
        TextBox1.Text = Val(txtDCash.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)
    End Sub

    Private Sub txtda_TextChanged(sender As Object, e As EventArgs) Handles txtda.TextChanged
        TextBox1.Text = Val(txtDCash.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)
    End Sub

    Private Sub txtLA_TextChanged(sender As Object, e As EventArgs) Handles txtLA.TextChanged
        TextBox1.Text = Val(txtDCash.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)
    End Sub

    Private Sub txtOther_TextChanged(sender As Object, e As EventArgs) Handles txtOther.TextChanged
        TextBox1.Text = Val(txtDCash.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(GMod.SqlExecuteNonQuery("delete from Expenses_tmp where id = " & id))
        fillg()
    End Sub
    Dim id As Integer
    Private Sub DataGridView1DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        id = Val(DataGridView1(13, DataGridView1.CurrentCell.RowIndex).Value.ToString())
    End Sub

    Private Sub dtvdate_ValueChanged_2(sender As Object, e As EventArgs) Handles dtvdate.ValueChanged
        'Setting voucher date accrding to session
        'dtvdate.Value = GMod.SessionCurrentDate
        dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = GMod.SessionCurrentDate
    End Sub
End Class