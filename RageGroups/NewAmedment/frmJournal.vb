Imports System.Data.SqlClient
Public Class frmJournal
    Dim i As Integer = -1
    Dim j As Integer
    Dim cr, dr As Double
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Val(txtDramt.Text) + Val(txtCrmat.Text) = 0 Then
            MsgBox("Either Cr or Dr is Zero", MsgBoxStyle.Information)
            txtDramt.Focus()
            Exit Sub
        End If
        Dim obj() As Object = {cmbAcHead.Text, cmbcode.Text, txtDramt.Text, txtCrmat.Text, ComboBox1.Text, ComboBox2.Text, txtNarration.Text & "#" & CmbPayMethod.Text, txtChqNo.Text}
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
        If Val(lblcr.Text) = Val(lblDr.Text) Then
            txtNarration.Focus()
        Else
            cmbAcHead.Focus()
        End If
        txtCrmat.Text = "0.0"
        txtDramt.Text = "0.0"
        txtNarration.Text = ""
    End Sub
    Dim sql As String
    Dim expflag As Boolean = False
    Private Sub frmJournal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbcode.Text & "' and vou_type='" & cmbvoutype.Text & "' and cmp_id='" & GMod.Cmpid & "'")
    End Sub
    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Checking For Entry Per mission
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
        'date set as per sessiion
        dtvdate.Value = GMod.SessionCurrentDate
        dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = GMod.SessionCurrentDate

        If "$" & GMod.usrname <> GMod.username Then
            If GMod.Dept = 1 Then
                sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "'  and vou_no_seq='" & GMod.Dept & "' and vprefix='JP' and session ='" & GMod.Session & "'"
                GMod.DataSetRet(sql, "CRVT")
                cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
                cmbvoutype.DisplayMember = "vtype"
            Else
                sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "'  and (vprefix like '%T%' or vprefix like '%TR%' or vprefix like '%J%'  or vprefix like '%bt%'  or vprefix like '%F%' or vprefix like '%P%'  or vprefix like '%dr%' or   vprefix like '%cr%' or vprefix like '%SAL%' or vprefix like '%SE%' or vprefix like '%SE%') and Vtype not in ('BANK','CR VOUCHER','CR VOUCHER-TR','CASH','OPEN') and VTYPE NOT LIKE '%OTHER SALE%' and VTYPE NOT LIKE '%CHICKS%' and vou_no_seq='" & GMod.Dept & "' and session ='" & GMod.Session & "'"
                GMod.DataSetRet(sql, "CRVT")
                cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
                cmbvoutype.DisplayMember = "vtype"
            End If

            

            'dtpexpensedate.Value = CDate("1/1/2000")
            'dtpdate.Value = CDate("1/1/2000")
        Else
            sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "'  and (vprefix like '%T%' or vprefix like '%J%'  or vprefix like '%bt%'  or vprefix like '%F%' or vprefix like '%P%' or vprefix like '%dr%'or vprefix like '%cr%') and Vtype not in ('BANK','CR VOUCHER','CR VOUCHER-TR','CASH','OPEN') and VTYPE NOT LIKE '%OTHER SALE%' and VTYPE NOT LIKE '%CHICKS%' and session ='" & GMod.Session & "' "
            GMod.DataSetRet(sql, "CRVT")
            cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
            cmbvoutype.DisplayMember = "vtype"
        End If
        fillArea()
        fillheads()
        cmbAcHead.Focus()

        Label1.Text = cmbvoutype.Text
        Label6.Text = cmbvoutype.Text

        If GMod.role.ToUpper = "ADMIN" Then
            btnModify.Enabled = True
            'btnDelete.Enabled = True
        Else
            'btnModify.Enabled = False
            ' btnDelete.Enabled = False
        End If

        

    End Sub
    Sub fillheads()
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and left(account_code,2) in ('**','" & cmbAreaCode.Text & "')  and group_name <> ''"
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

        GMod.DataSetRet(sqlarea, "AreaDm")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"
        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
        'cmbAreaCode.Text = GMod.AreaCode


        ComboBox4.DataSource = GMod.ds.Tables("AreaDm")
        ComboBox4.DisplayMember = "prefix"
        ComboBox3.DataSource = GMod.ds.Tables("AreaDm")
        ComboBox3.DisplayMember = "Areaname"

        sqlarea = "select group_name from groups where cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' "
        'sqlarea = "select distinct Group_name from  " & GMod.VENTRY
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
        txtDramt.BackColor = Color.Pink
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
        txtDramt.BackColor = Color.White
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
        txtCrmat.BackColor = Color.Pink
    End Sub

    Private Sub txtCrmat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCrmat.KeyPress
        'MsgBox(e.KeyChar)
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

        If Val(txtDramt.Text) > 0 Then
            If Val(txtCrmat.Text) Then
                MsgBox("You have entered both Dr and Cr")
                txtDramt.Focus()
            End If
        End If
        txtCrmat.BackColor = Color.White

    End Sub
    Dim crcode, crhead As String
    Private Sub txtCrmat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrmat.TextChanged
        If Val(txtCrmat.Text) > 0 Then
            txtDramt.Enabled = False
            txtCollectinRec.Text = Val(txtCrmat.Text)
            crcode = cmbcode.Text
            crhead = cmbAcHead.Text
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
        If txtvou_no.Text = "" Then
            Me.Close()
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If GMod.Cmpid = "PHOE" Then
            If btnSave.Enabled = True Then
                If expflag = False Then
                    MessageBox.Show("Please Select the Expense Month/Date", "Expenses Month/Date:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpexpensedate.Focus()
                    Exit Sub
                End If
            Else
                If expflag = False Then
                    MessageBox.Show("Please Select the Expense Month/Date", "Expenses Month/Date:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpexpensedate.Focus()
                    ' Exit Sub
                End If
            End If
        End If
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            If Val(lblcr.Text) <> Val(lblDr.Text) Then
                MsgBox("Dr Amount Not Equal To Cr Amount", MsgBoxStyle.Critical)
                cmbAcHead.Focus()
                Exit Sub
            End If

            ''Disbusment register Checkung 27-4-18 
            'If GMod.Cmpid = "PHHA" And cmbvoutype.Text = "JOURNAL COLLECTION" Then
            '    If check() = True Then
            '    Else
            '        Exit Sub
            '    End If
            'End If

            Dim trans As SqlTransaction
            trans = GMod.SqlConn.BeginTransaction
            If btnSave.Enabled = True Then


                nxtvno()
                'Cheching for Duplicate voucher in Connection Break.
                GMod.DataSetRet("select * from " & GMod.VENTRY & " where vou_type= '" & cmbvoutype.Text & "' and vou_no='" & txtvou_no.Text & "'", "ckechVoucher")
                If GMod.ds.Tables("ckechVoucher").Rows.Count > 0 Then
                    MsgBox("Duplicate Voucher", MsgBoxStyle.Critical)
                    Exit Sub
                End If

            Else
                Dim cmdel As New SqlCommand("delete from " & GMod.VENTRY & " where vou_type='" & cmbvoutype.Text & "' and vou_no= '" & txtvou_no.Text & "'", GMod.SqlConn, trans)
                cmdel.ExecuteNonQuery()

                sql = "delete from Sale_Receipt where vou_type='" & cmbvoutype.Text & "' and  vou_no='" & txtvou_no.Text & "' and cmp_id='" & GMod.Cmpid & "' and cmp_id='" & GMod.Cmpid & "'"

                Dim cmddel1 As New SqlCommand(sql, GMod.SqlConn, trans)
                cmddel1.ExecuteNonQuery()
            End If
            '------------------------------------------------------------------------
            Try
                For j = 0 To dgPayment.Rows.Count - 1
                    sql = "insert into " & GMod.VENTRY & "( Cmp_id, Uname, Entry_id," & _
                    " Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt," & _
                    " cramt, Pay_mode, Cheque_no, Narration, Group_name," & _
                    " Sub_group_name, Ch_issue_date, exp_date) values ("
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
                    sql &= "'" & dtpdate.Value.ToShortDateString & "',"
                    'sql &= "'" & dtpexpensedate.Value.ToShortDateString & "')"
                    sql &= "'" & dtpexpensedate.Value.ToShortDateString & "')"

                    Dim cmd As New SqlCommand(sql, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                Next

                'Disburesement Register Entry 26-4-18
                'If GMod.Cmpid = "PHHA" And cmbvoutype.Text = "JOURNAL COLLECTION" Then
                '    sql = "select * from DisburReg where session = '" & GMod.Session & "' and disburno ='" & txtDisdurNo.Text & "'"
                '    GMod.DataSetRet(sql, "chkDisburNo")
                '    If GMod.ds.Tables("chkDisburNo").Rows.Count > 0 Then
                '        sql = "update DisburReg set CollecRecDr='" & Val(txtCollectionDm.Text) & "',CollecRecDr='" & Val(txtCollectinRec.Text) & "',DrCode='" & crcode & "',DrHead='" & crhead & "' where session ='" & GMod.Session & "' and DisburNo='" & txtDisdurNo.Text & "'"
                '    Else
                '        sql = "Insert into DisburReg(DisburNo, HatchDate, RecvDate, CollecRecDr, CollecRec, BankSlip, Remarks, TRNo, session, uname, entrydate, Area, AreaCode,CrCode, CrHead) values ("
                '        sql &= "'" & txtDisdurNo.Text & "',"
                '        sql &= "'" & dthatchdate.Value.ToShortDateString & "',"
                '        sql &= "'" & dtRecDate.Value.ToShortDateString & "',"
                '        sql &= "'" & Val(txtCollectionDm.Text) & "',"
                '        sql &= "'" & Val(txtCollectinRec.Text) & "',"
                '        sql &= "'-',"
                '        sql &= "'" & txtRem.Text & "',"
                '        sql &= "'" & txtTrNo.Text & "',"
                '        sql &= "'" & GMod.Session & "',"
                '        sql &= "'" & GMod.username & "',"
                '        sql &= "'" & Now & "',"
                '        sql &= "'" & cmbAreaName.Text & "',"
                '        sql &= "'" & cmbAreaCode.Text & "',"

                '        sql &= "'" & crcode & "',"
                '        sql &= "'" & crhead & "')"
                '    End If
                '    Dim cmd2 As New SqlCommand(sql, GMod.SqlConn, trans)
                '    cmd2.ExecuteNonQuery()
                'End If
                '---------------------------------------------
                trans.Commit()
                dgPayment.Rows.Clear()
                txtDramt.Clear()
                txtCrmat.Clear()
                txtNarration.Clear()
                txtChqNo.Clear()
                DataGridView1.Rows.Clear()
                txtref.Text = ""
                txtamount.Text = ""
                lblcr.Text = ""
                lblDr.Text = ""
                txtChqNo.Clear()
                MsgBox(cmbvoutype.Text & "/" & txtvou_no.Text, MsgBoxStyle.Information)

                i = -1
                cmbAcHead.SelectedIndex = 0
                cmbcode.SelectedIndex = 0
                btnReset_Click(sender, e)
                cmbvoutype.Focus()
            Catch ex As Exception
                trans.Rollback()
                MsgBox(ex.Message)
            End Try
        End If
        expflag = False
    End Sub
    Private Sub cmbAcHead_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAcHead.Enter
        cmbAcHead.BackColor = Color.Pink
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
        cmbAcHead.BackColor = Color.White
    End Sub

    Private Sub txtNarration_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNarration.Enter
        txtNarration.BackColor = Color.Pink
    End Sub

    Private Sub txtNarration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNarration.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
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
    End Sub

    Private Sub txtNarration_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNarration.Leave
        txtNarration.BackColor = Color.White
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
        Dim k As Integer
        If btnSave.Enabled Then
            btnSave.Enabled = False
            btnModify.Text = "&Update"
            Dim i As Integer
            Dim r As New frmvoucherlist
            r.ShowDialog()
            cmbvoutype.Text = r.cmbvtype.Text
            txtvou_no.Text = r.txtvouno.Text
            cmbvoutype.Enabled = False
            If r.txtvouno.Text = "" Then
                MsgBox("Voucher No Can't be Empty", MsgBoxStyle.Information)
                btnReset_Click(sender, e)
                Exit Sub
            End If
            ' If LockDataCheck(r.txtvouno.Text, GMod.Session, r.cmbvtype.Text) = False Then
            'MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'btnReset_Click(sender, e)
            'Exit Sub
            'End If

            sql = "select * from " & GMod.VENTRY & " where  vou_type ='" & cmbvoutype.Text & "' and vou_no='" & txtvou_no.Text & "'  order by entry_id"
            GMod.DataSetRet(sql, "modifypay")
            dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
            dtvdate.Value = CDate(GMod.ds.Tables("modifypay").Rows(0)("Vou_date"))
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
                dgPayment(7, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Cheque_No")
            Next
            For j = 0 To dgPayment.Rows.Count - 1
                dr = dr + Val(dgPayment(2, j).Value)
                cr = cr + Val(dgPayment(3, j).Value)
            Next
            If cmbvoutype.Text <> "" And txtvou_no.Text <> "" Then
                sql = "select ref_type,ref,dueon, cr from Sale_Receipt where vou_type='" & cmbvoutype.Text & "' and  vou_no='" & txtvou_no.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
                dg.Visible = False
                GMod.DataSetRet(sql, "mfy")
                If GMod.ds.Tables("mfy").Rows.Count > 0 Then
                    For k = 0 To GMod.ds.Tables("mfy").Rows.Count - 1
                        DataGridView1.Rows.Add()
                        DataGridView1(0, k).Value = GMod.ds.Tables("mfy").Rows(k)(0)
                        DataGridView1(1, k).Value = GMod.ds.Tables("mfy").Rows(k)(1)
                        DataGridView1(2, k).Value = GMod.ds.Tables("mfy").Rows(k)(2)
                        DataGridView1(3, k).Value = GMod.ds.Tables("mfy").Rows(k)(3)
                    Next
                End If
            End If
            lblcr.Text = cr
            lblDr.Text = dr
            dr = 0
            cr = 0
            cmbAcHead.Focus()
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
            dtvdate_ValueChanged_1(sender, e)
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
        txtDisdurNo.Clear()
        txtCollectionDm.Clear()
        txtCollectinRec.Text = ""
        txtRem.Clear()
        txtTrNo.Clear()
        txtDisdurNo.Focus()
    End Sub

    Private Sub cmbvoutype_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvoutype.Enter
        cmbvoutype.BackColor = Color.Pink
    End Sub

    Private Sub cmbvoutype_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvoutype.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbvoutype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvoutype.Leave
        cmbvoutype.BackColor = Color.White
        If cmbvoutype.FindStringExact(cmbvoutype.Text) = -1 Then
            MsgBox("Please select correct voucher type", MsgBoxStyle.Exclamation)
            cmbvoutype.Focus()
            Exit Sub
        End If
        If cmbvoutype.Text = "" Then
            MsgBox("Please select correct voucher type", MsgBoxStyle.Exclamation)
            cmbvoutype.Focus()
            Exit Sub
        End If

        If GMod.Cmpid = "PHHA" And cmbvoutype.Text = "JOURNAL COLLECTION" Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub cmbvoutype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvoutype.SelectedIndexChanged
        Label1.Text = cmbvoutype.Text
        Label6.Text = cmbvoutype.Text

    End Sub

    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        'fillheads()
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and left(account_code,2) in ('" & cmbAreaCode.Text & "')"
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

    Private Sub cmbgroup_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgroup.Leave
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

    Private Sub cmbgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgroup.SelectedIndexChanged
      
    End Sub

    Private Sub dtvdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtvou_no_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvou_no.Enter
        txtvou_no.BackColor = Color.Pink
    End Sub

    Private Sub txtvou_no_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvou_no.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbAreaName_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAreaName.Enter
        cmbAreaName.BackColor = Color.Pink
    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAreaName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAreaName.Leave
        If cmbAreaName.FindStringExact(cmbAreaName.Text) = -1 Then
            MsgBox("Please select correct Area", MsgBoxStyle.Exclamation)
            cmbAreaName.Focus()
            Exit Sub
        End If


        If cmbAreaName.Text = "" Then
            MsgBox("Please select correct Area", MsgBoxStyle.Exclamation)
            cmbAreaName.Focus()
            Exit Sub
        End If

        cmbAreaName.BackColor = Color.White
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and left(account_code,2) in ('" & cmbAreaCode.Text & "')"
        GMod.DataSetRet(sql, "aclist1")

        cmbcode.DataSource = GMod.ds.Tables("aclist1")
        cmbcode.DisplayMember = "account_code"
        cmbAcHead.DataSource = GMod.ds.Tables("aclist1")
        cmbAcHead.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclist1")
        ComboBox1.DisplayMember = "group_name"

        ComboBox2.DataSource = GMod.ds.Tables("aclist1")
        ComboBox2.DisplayMember = "sub_group_name"
        'fillheads()

        
    End Sub

    Private Sub cmbcode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcode.Enter
        cmbcode.BackColor = Color.Pink
    End Sub

    Private Sub cmbcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcode.Leave
        sql = "select account_code from " & GMod.ACC_HEAD & " where account_head_name = '" & cmbAcHead.Text & "' and  Area_code ='" & cmbAreaCode.Text & "' and group_name='" & cmbgroup.Text & "'"
        GMod.DataSetRet(sql, "account_codeJournal")
        If GMod.ds.Tables("account_codeJournal").Rows.Count > 0 Then
            If cmbcode.Text.Trim <> GMod.ds.Tables("account_codeJournal").Rows(0)(0) Then
                MsgBox("A/c Name and Code are Different", MsgBoxStyle.Information)
                cmbAcHead.Focus()
                Exit Sub
            End If
        Else
            'cmbAcHead.Focus()
            'Exit Sub
        End If
        cmbcode.BackColor = Color.White
        If chkpayment.Checked = True Then
            If btnSave.Enabled = True Then
                sql = "select *  from tmpAging where acc_code ='" & cmbcode.Text & "' and vou_type='" & cmbvoutype.Text & "' and cmp_id='" & GMod.Cmpid & "'"
                GMod.DataSetRet(sql, "jj")
                If GMod.ds.Tables("jj").Rows.Count > 0 Then
                    MsgBox("Please select diffent head")
                    Me.Close()
                    Exit Sub
                End If
            End If
            GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbcode.Text & "' and vou_type='" & cmbvoutype.Text & "'")
            'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
            sql = " insert into  tmpAging (Ref_Type, Ref, Acc_Code,dr,vou_type,cmp_id) " & _
                  " select Ref_type,Ref,acc_code,sum(dr)-sum(cr) Amount,'" & cmbvoutype.Text & "',cmp_id  " & _
                  " from Sale_Receipt group by Ref,acc_code,Ref_type,cmp_id having sum(dr)-sum(cr)>0 " & _
                  " and acc_code='" & cmbcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.SqlExecuteNonQuery(sql)
        End If
    End Sub

    Private Sub txtChqNo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChqNo.Enter
        txtChqNo.BackColor = Color.Pink
    End Sub
    Private Sub txtChqNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChqNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpexpensedate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpexpensedate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub dtpdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpdate.KeyDown
       
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

    Private Sub txtChqNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChqNo.Leave
        txtChqNo.BackColor = Color.White
    End Sub

    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If btnSave.Enabled = True Then
            '---- Resting date to server date 
            GMod.DataSetRet("select getdate()", "serverdate")
            dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
            dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Close()
    End Sub
    Private Sub dtvdate_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtvdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbRefType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRefType.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbRefType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRefType.Leave
        'Ags Ref
        'New Ref
        'Advance
        'On Account
        If cmbRefType.Text = "Ags Ref" Then
            sql = "select Ref,sum(dr)-sum(cr) Amount,acc_code from tmpAging group by Ref,acc_code,cmp_id having sum(dr)-sum(cr)>0  and acc_code='" & cmbcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "aging")
            If GMod.ds.Tables("aging").Rows.Count > 0 Then
                dg.DataSource = GMod.ds.Tables("aging")
                dg.Visible = True
                dg.Focus()
            End If
        End If
    End Sub
    Dim sqlsavecr As String
    Dim ddate As Date
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtamount.Text = "" Then
            MsgBox("Please enter amount")
            txtamount.Focus()
            Exit Sub
        End If
        If txtduedate.Text = "" Then
            txtduedate.Text = Format(ddate, "MM/dd/yyyy")
        End If
        Dim obj() As Object = {cmbRefType.Text, txtref.Text, txtduedate.Text, txtamount.Text, cmbcode.Text}
        If i <> -1 Then
            DataGridView1.Rows.RemoveAt(i)
            DataGridView1.Rows.Insert(i, obj)
        Else
            DataGridView1.Rows.Add(obj)
        End If

        sqlsavecr = "insert into  tmpAging (Ref_Type, Ref, Acc_Code, Vou_Type," & _
        " Vou_No, Vou_Date, dr, cr, dueon, Session,usename,id,cmp_id) values( "
        sqlsavecr &= "'" & cmbRefType.Text & "',"
        sqlsavecr &= "'" & txtref.Text & "',"
        sqlsavecr &= "'" & cmbcode.Text & "',"
        sqlsavecr &= "'" & cmbvoutype.Text & "',"
        sqlsavecr &= "'" & VouNo & "',"
        sqlsavecr &= "'" & dtvdate.Value.ToShortDateString & "',"
        sqlsavecr &= "'" & Val("") & "',"
        sqlsavecr &= "'" & Val(txtamount.Text) & "',"
        sqlsavecr &= "'" & CDate(txtduedate.Text).ToShortDateString & "',"
        sqlsavecr &= "'" & GMod.Session & "',"
        sqlsavecr &= "'" & GMod.username & "',"
        sqlsavecr &= "'" & DataGridView1.CurrentCell.RowIndex & "',"
        sqlsavecr &= "'" & GMod.Cmpid & "')"

        GMod.SqlExecuteNonQuery(sqlsavecr)

    End Sub

    Private Sub dg_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellClick

    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Escape Then
            txtref.Text = dg(0, dg.CurrentCell.RowIndex).Value
            txtamount.Text = dg(1, dg.CurrentCell.RowIndex).Value
            dg.Visible = False
            txtamount.Focus()

        End If
    End Sub
    Private Sub dtpdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtref_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtref.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtduedate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtduedate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtamount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub dgPayment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgPayment.KeyDown
        Try
            If e.KeyCode = Keys.F3 And dgPayment.CurrentCell.ColumnIndex = 6 And dgPayment.CurrentCell.RowIndex > 0 Then
                dgPayment(6, dgPayment.CurrentCell.RowIndex).Value = dgPayment(6, dgPayment.CurrentCell.RowIndex - 1).Value
            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub txtChqNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChqNo.TextChanged

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

    Private Sub dtvdate_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtvdate.LocationChanged

    End Sub

    Private Sub dtvdate_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.ValueChanged
        Try

            '---- Resting date to server date 
            'GMod.DataSetRet("select getdate()", "serverdate")
            'dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
            'dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

            ' dtvdate.Value = GMod.SessionCurrentDate
            dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
            dtvdate.MaxDate = GMod.SessionCurrentDate

            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
            If "$" & GMod.usrname <> GMod.username Then
                If btnSave.Enabled = True Then
                    'GMod.DataSetRet("select getdate()", "serverdate")
                    ' dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
                    ' dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
                End If
            Else

                'dtvdate.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2))
                'dtvdate.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
                'dtvdate.Value = CDate("3/31/" & Mid(GMod.Session, 3, 4))

                'dtvdate.Value = GMod.SessionCurrentDate
                dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
                dtvdate.MaxDate = GMod.SessionCurrentDate
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub chkpayment_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkpayment.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Function check() As Boolean
        If GMod.Cmpid = "PHHA" Then
            If ComboBox3.Text = "" Then
                MsgBox("Enter Area..")
                ComboBox3.Focus()
                Return False
            ElseIf txtDisdurNo.Text = "" Then
                MsgBox("Enter Disbusment No..")
                txtDisdurNo.Focus()
                Return False
            ElseIf txtCollectionDm.Text = "" Then
                MsgBox("Enter Collection DM ..")
                txtCollectionDm.Focus()
                Return False
            ElseIf txtCollectinRec.Text = "" Then
                MsgBox("Enter Collection Received ..")
                txtCollectinRec.Focus()
                ' Return False
            ElseIf txtTrNo.Text = "" Then
                MsgBox("Enter TR No ..")
                txtTrNo.Focus()
                Return False
            Else
                Return True
            End If
            End If
    End Function

    Private Sub dtpexpensedate_ValueChanged(sender As Object, e As EventArgs) Handles dtpexpensedate.ValueChanged
        expflag = True
    End Sub

  
    Private Sub dgPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPayment.CellContentClick

    End Sub
End Class
