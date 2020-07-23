Imports System.Data.SqlClient
Public Class frmPayment
    Dim i As Integer = -1
    Dim j As Integer
    Dim cr, dr As Double
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'f MessageBox.Show("Want to add more", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        If Val(txtDramt.Text) + Val(txtCrmat.Text) = 0 Then
            MsgBox("Either Cr or Dr is Zero", MsgBoxStyle.Information)
            txtDramt.Focus()
            Exit Sub
        End If

        If chkpayment.Checked = True Then
            If lblpartycode.Text = "-" Then
                MsgBox("Please Select party head", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

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
        txtChqNo.Text = ""
    End Sub
    Dim sql As String

    Private Sub frmPayment_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & dgPayment(1, 0).Value & "' and vou_type='PAY' and cmp_id='" & GMod.Cmpid & "'")
    End Sub
    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'date set to server date 
        GMod.DataSetRet("select getdate()", "serverdate")
        dtvdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)


        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and Vtype in ('BANK','CASH','JOURNAL')"
        GMod.DataSetRet(sql, "CRVT")
        cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
        cmbvoutype.DisplayMember = "vtype"

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
            btnModify.Enabled = True
            'btnDelete.Enabled = True
        Else
            btnModify.Enabled = False
            ' btnDelete.Enabled = False
        End If
        cmbvoutype.Focus()
        If GMod.Getsession(dtvdate.Value) = GMod.Session Then
        Else
            Me.Close()
        End If

        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
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
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

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
                Dim cmdel As New SqlCommand("delete from " & GMod.VENTRY & " where vou_type='" & cmbvoutype.Text & "' and vou_no= '" & txtvou_no.Text & "'", GMod.SqlConn, trans)
                cmdel.ExecuteNonQuery()
            End If

            If btnSave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, txtvou_no.Text, cmbvoutype.Text, dtvdate.Value, Now, GMod.Session, "M", GMod.username)
            End If

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
                    sql &= "'" & GMod.username & "',"
                    sql &= "'" & dgPayment(7, j).Value.ToString & "',"
                    sql &= "'" & dgPayment(6, j).Value.ToString & "',"
                    sql &= "'" & dgPayment(4, j).Value & "',"
                    sql &= "'" & dgPayment(5, j).Value & "',"
                    sql &= "'1/1/2000',"
                    sql &= "'" & dtpexpensedate.Value.ToString & "')"

                    Dim cmd As New SqlCommand(sql, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                Next

                For i = 0 To DataGridView1.RowCount - 1
                    sqlsavecr = "insert into  Purchase_Payment (Ref_Type, Ref, Acc_Code, Vou_Type," & _
                    " Vou_No, Vou_Date, cr, dr, dueon, Session,cmp_id) values( "
                    sqlsavecr &= "'" & DataGridView1(0, i).Value & "',"
                    sqlsavecr &= "'PAY" & txtvou_no.Text & "',"
                    sqlsavecr &= "'" & lblpartycode.Text & "',"
                    sqlsavecr &= "'" & cmbvoutype.Text & "',"
                    sqlsavecr &= "'" & txtvou_no.Text & "',"
                    sqlsavecr &= "'" & dtvdate.Value.ToShortDateString & "',"
                    sqlsavecr &= "'" & Val("") & "',"
                    sqlsavecr &= "'" & Val(DataGridView1(3, i).Value) & "',"
                    sqlsavecr &= "'" & CDate(DataGridView1(2, i).Value).ToShortDateString & "',"
                    sqlsavecr &= "'" & GMod.Session & "',"
                    sqlsavecr &= "'" & GMod.Cmpid & "')"
                    Dim cmd1 As New SqlCommand(sqlsavecr, GMod.SqlConn, trans)
                    cmd1.ExecuteNonQuery()
                Next

                Dim cmd2 As New SqlCommand("delete from tmpAging where acc_code='" & dgPayment(1, 0).Value & "' and vou_type='PAY' and cmp_id='" & GMod.Cmpid & "'", GMod.SqlConn, trans)
                cmd2.ExecuteNonQuery()
                trans.Commit()
                MsgBox(cmbvoutype.Text & " / " & txtvou_no.Text, MsgBoxStyle.Information)

                dgPayment.Rows.Clear()
                DataGridView1.Rows.Clear()
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
            Dim i As Integer
            Dim r As New frmvoucherlist
            r.ShowDialog()
            cmbvoutype.Text = r.cmbvtype.Text
            txtvou_no.Text = r.txtvouno.Text
            cmbvoutype.Enabled = False
            If LockDataCheck(r.txtvouno.Text, GMod.Session, r.cmbvtype.Text) = False Then
                MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' btnReset_Click(sender, e)
                ' Exit Sub
            End If
            sql = "select * from " & GMod.VENTRY & " where  vou_type ='" & cmbvoutype.Text & "' and vou_no='" & txtvou_no.Text & "'  order by entry_id"
            GMod.DataSetRet(sql, "modifypay")
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

            Dim k As Integer
            sql = "select ref_type,ref,dueon, dr from purchase_payment where vou_type='" & cmbvoutype.Text & "' and  vou_no='" & txtvou_no.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
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
        Else
            If MessageBox.Show("Do U want to Modify", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
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

    Private Sub cmbcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcode.Leave
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

        If chkpayment.Checked = True Then
            If lblpartycode.Text = "-" Then
                lblpartycode.Text = cmbcode.Text
                sql = "select *  from tmpAging where acc_code ='" & lblpartycode.Text & "' and vou_type='PAY' and cmp_id='" & GMod.Cmpid & "'"
                GMod.DataSetRet(sql, "jj")
                If GMod.ds.Tables("jj").Rows.Count > 0 Then
                    MsgBox("Please select diffent head")
                    Me.Close()
                    Exit Sub
                End If
                GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbcode.Text & "' and vou_type='PAY'")
                'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
                sql = "insert into  tmpAging (Ref_Type, Ref, Acc_Code,cr,vou_type,cmp_id) " & _
                     " select Ref_type,Ref,acc_code,sum(cr)-sum(dr) Amount,'PAY',cmp_id  " & _
                    " from Purchase_Payment group by Ref,acc_code,Ref_type,cmp_id having sum(cr)-sum(dr)>0 " & _
                     " and acc_code='" & lblpartycode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
                GMod.SqlExecuteNonQuery(sql)
            End If
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
            sql = "select Ref,sum(cr)-sum(dr) Amount,acc_code from tmpAging group by Ref,acc_code,cmp_id having sum(cr)-sum(dr)>0  and acc_code='" & lblpartycode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "aging")
            If GMod.ds.Tables("aging").Rows.Count > 0 Then
                dg.DataSource = GMod.ds.Tables("aging")
                dg.Visible = True
                dg.Focus()
            End If
        End If
    End Sub
    Dim vouno As Long
    Dim ddate As DateTime = CDate("1/1/2000")
    Dim sqlsavecr As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If txtamount.Text = "" Then
            MsgBox("Please enter amount")
            txtamount.Focus()
            Exit Sub
        End If
        If txtduedate.Text = "" Then
            txtduedate.Text = Format(ddate, "MM/dd/yyyy")
        End If
        Dim obj() As Object = {cmbRefType.Text, txtref.Text, txtduedate.Text, txtamount.Text}
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
        sqlsavecr &= "'" & lblpartycode.Text & "',"
        sqlsavecr &= "'PAY',"
        sqlsavecr &= "'" & VouNo & "',"
        sqlsavecr &= "'" & dtvdate.Value.ToShortDateString & "',"
        sqlsavecr &= "'" & Val(txtamount.Text) & "',"
        sqlsavecr &= "'" & Val("") & "',"
        sqlsavecr &= "'" & CDate(txtduedate.Text).ToShortDateString & "',"
        sqlsavecr &= "'" & GMod.Session & "',"
        sqlsavecr &= "'" & GMod.username & "',"
        sqlsavecr &= "'" & DataGridView1.CurrentCell.RowIndex & "',"
        sqlsavecr &= "'" & GMod.Cmpid & "')"

        GMod.SqlExecuteNonQuery(sqlsavecr)

        If cr <> Val(txtCrmat.Text) Then
            cmbRefType.SelectedIndex = 0
            cmbRefType.Focus()
        Else
            btnSave.Focus()
        End If

        txtref.Clear()
        txtduedate.Clear()
        txtamount.Clear()
        i = -1
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Escape Then
            txtref.Text = dg(0, dg.CurrentCell.RowIndex).Value
            txtamount.Text = dg(1, dg.CurrentCell.RowIndex).Value
            dg.Visible = False
            txtamount.Focus()
        End If
    End Sub

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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Try
            If btnSave.Enabled = True Then
                MsgBox(GMod.SqlExecuteNonQuery("delete from tmpAging where ci = '" & DataGridView1.CurrentCell.RowIndex & "' and usename ='" & GMod.username & "'"))
            Else
                sql = "select id from purchase_payment where ref_type='" & DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value & "' and ref='" & DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value & "' and vou_no='" & txtvou_no.Text & "' and dr='" & DataGridView1(3, DataGridView1.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sql, "delSale_Receipt")

                sql = "delete from purchase_payment where id ='" & GMod.ds.Tables("delSale_Receipt").Rows(0)(0).ToString & "'"
                GMod.SqlExecuteNonQuery(sql)


                GMod.SqlExecuteNonQuery("delete from tmpAging where ci = '" & DataGridView1.CurrentCell.RowIndex & "' and usename ='" & GMod.username & "'")
            End If
            GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbcode.Text & "' and vou_type='PAY'")
            'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
            sql = "insert into  tmpAging (Ref_Type, Ref, Acc_Code,cr,vou_type,cmp_id) " & _
                 " select Ref_type,Ref,acc_code,sum(cr)-sum(dr) Amount,'PAY',cmp_id  " & _
                " from Purchase_Payment group by Ref,acc_code,Ref_type,cmp_id having sum(cr)-sum(dr)>0 " & _
                 " and acc_code='" & lblpartycode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.SqlExecuteNonQuery(sql)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbAcHead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAcHead.SelectedIndexChanged

    End Sub

    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---- Resting date to server date 
        GMod.DataSetRet("select getdate()", "serverdate")
        dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Close()
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

    Private Sub txtChqNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChqNo.TextChanged

    End Sub

    Private Sub cmbRefType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRefType.SelectedIndexChanged

    End Sub

    Private Sub txtref_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtref.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtref_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtref.TextChanged

    End Sub

    Private Sub txtduedate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtduedate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtduedate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtduedate.TextChanged

    End Sub

    Private Sub txtamount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged

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
        GMod.DataSetRet("select getdate()", "serverdate")
        dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub chkpayment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpayment.CheckedChanged

    End Sub

    Private Sub cmbcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcode.SelectedIndexChanged

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

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub
End Class