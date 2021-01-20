Public Class frmCRDebit

    Private Sub frmCRDebit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        dtvdate.Focus()
        'GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype NOT in ('PAYMENT','RECEIPT') order by seqorder", "vty")

        Dim sqlq As String = "select * from vtype where cmp_id='" & GMod.Cmpid & "' and "
        If GMod.Cmpid = "PHHA" Then
            sqlq += "vtype  in ('COLL-AREA')"
        Else
            sqlq += "vtype NOT in ('PAYMENT','RECEIPT')  and session = '" & GMod.Session & "' "
        End If
        sqlq += " order by seqorder"
        GMod.DataSetRet(sqlq, "vty")

        cmbvtype.DataSource = GMod.ds.Tables("vty")
        cmbvtype.DisplayMember = "vtype"
        fillArea()
        cmbvtype.Text = "COLLection"
        'nxtvno()
        'GetLastVouDate() 'Getting last voucher date
        Dim sql As String
        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "'  and vtype like '%CR%'  and session = '" & GMod.Session & "'"
        GMod.DataSetRet(sql, "CRVT")
        cmbvou_type.DataSource = GMod.ds.Tables("CRVT")
        cmbvou_type.DisplayMember = "vtype"

        'SESSION CHECK FOR ENTRY 
        'MsgBox(GMod.Getsession(dtvdate.Value))
        If GMod.Getsession(dtvdate.Value) = GMod.Session Then
        Else
            'Me.Close()
        End If
        fillacclist()
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
    Dim sql As String
    Public Sub SetLastVouDate()

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
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
        'cmbAreaCode.Text = GMod.AreaCode

        GMod.DataSetRet(sqlarea, "AreaDisbur")

       


    End Sub
    Sub nxtvno()
        Dim sql As String
        Try
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "'"
            GMod.DataSetRet(sql, "vno10")
            lblvouno.Text = ds.Tables("vno10").Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub fillacclist()
        Dim Sqlacc As String
        Sqlacc = " select * from " & GMod.ACC_HEAD & " where group_name like '%COLL%' and left(account_code,2)='" & cmbAreaCode.Text & "'"
        GMod.DataSetRet(Sqlacc, "aclist1")
        cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadname.DisplayMember = "account_head_name"
    End Sub
    Private Sub cmbAreaCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.Leave
        fillacclist()
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
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        lblamount.Text = ""
        Try
            Dim sqlshow As String, i As Integer
            sqlshow = "select Vou_no,Vou_date,Acc_head_code ,Acc_head,Narration,cramt  from " & GMod.VENTRY _
                       & " where vou_type='" & cmbvou_type.Text & "' " _
                       & " and vou_no>=" & Val(txtCrNoFrom.Text) & " and vou_no<=" & Val(txtCrNoTo.Text) & " order by cast(vou_no as numeric(18,0)) "
            GMod.DataSetRet(sqlshow, "CRData")
            dgCRDebit.Rows.Clear()
            'dgCRDebit.DataSource = GMod.ds.Tables("CRData")
            For i = 0 To GMod.ds.Tables("CRData").Rows.Count - 1
                dgCRDebit.Rows.Add()
                dgCRDebit(0, i).Value = GMod.ds.Tables("CRData").Rows(i)("Vou_no")
                dgCRDebit(1, i).Value = GMod.ds.Tables("CRData").Rows(i)("Vou_date")
                dgCRDebit(2, i).Value = GMod.ds.Tables("CRData").Rows(i)("Acc_head_code")
                dgCRDebit(3, i).Value = GMod.ds.Tables("CRData").Rows(i)("Acc_head")
                dgCRDebit(4, i).Value = GMod.ds.Tables("CRData").Rows(i)("Narration")
                dgCRDebit(5, i).Value = GMod.ds.Tables("CRData").Rows(i)("cramt")
                lblamount.Text = Val(lblamount.Text) + Val(dgCRDebit(5, i).Value)
            Next
            lblamount.Text = Val(lblamount.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtndebit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtndebit.Click
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            '27-4-18
            If cmbvtype.Text = "CR VOUCHER" Then
                Exit Sub
            ElseIf cmbvtype.Text = "CR VOUCHER-TR" Then
                Exit Sub
            End If
            If dgCRDebit.Rows.Count = 0 Then
                MsgBox("Please Select vouchers's")
                txtCrNoFrom.Focus()
                Exit Sub
            End If
            If txtCrNoFrom.Text = "" Then
                MsgBox("CR NO. ca,t br blanck")
                Exit Sub
            End If
            If txtCrNoTo.Text = "" Then
                MsgBox("CR NO. ca,t br blanck")
                Exit Sub

            End If
            Dim eid As Integer = 0
            Dim varcr, vardr As Double
            Dim narration As String
            Dim sqlsavecr As String
            narration = "By CR Voucher #" + txtCrNoFrom.Text + "# To #" + txtCrNoTo.Text & "# " & txtNarration.Text.ToUpper
            vardr = Val(lblamount.Text)
            varcr = 0
            nxtvno()
            sqlsavecr = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
            sqlsavecr += "acc_head_code,Acc_head, cramt, dramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
            sqlsavecr += ") values( "
            sqlsavecr += "'" & GMod.Cmpid & "','" & GMod.username & "'," & eid & ",'" & lblvouno.Text & "',"
            sqlsavecr += "'" & cmbvtype.Text & "','" & dtvdate.Value.ToShortDateString & "','" & cmbacheadcode.Text & "','" & cmbacheadname.Text & "'," & Val(varcr) & "," & Val(vardr) & ","
            sqlsavecr += "'" & GMod.username & "','-','" & narration.ToUpper & "','" & cmbacgroup.Text & "',"
            sqlsavecr += "'" & cmbacsubgroup.Text & "')"

            'msgBox(sqlsavecr)
            If GMod.SqlExecuteNonQuery(sqlsavecr) = "SUCCESS" Then
                MsgBox("Amount Debited to A/c" & cmbacheadname.Text & "-" & cmbvtype.Text & "/" & lblvouno.Text, MsgBoxStyle.Information)
                txtCrNoFrom.Text = ""
                txtCrNoTo.Text = ""
                dgCRDebit.Rows.Clear()
                dtvdate.Focus()
                'nxtvno()
                lblamount.Text = "0.00"
                lblvouno.Text = ""
            Else
                MsgBox("Error in Debited to A/c" & cmbacheadname.Text, MsgBoxStyle.Information)
            End If
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If e.KeyCode = Keys.Enter Then txtCrNoFrom.Focus()
    End Sub
    Private Sub cmbAreaName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.Leave
        fillacclist()
    End Sub
    Private Sub cmbvtype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvtype.Leave
        'nxtvno()
    End Sub
    Private Sub cmbvtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype.SelectedIndexChanged
        'nxtvno()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As String
        r = InputBox("Enter the voucher No to be deleted")
        If r <> "" Then
            Dim sql As String
            sql = "delete  from " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "' and vou_no='" & r & "'"
            MsgBox(GMod.SqlExecuteNonQuery(sql) & "-- Voucher Deleted")
            nxtvno()
            dtvdate.Show()
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            lblvouno.ReadOnly = True
        Else
            lblvouno.ReadOnly = False
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub dtvdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtvdate.KeyUp
        If e.KeyCode = Keys.Enter Then cmbAreaName.Focus()
    End Sub

    Private Sub dtvdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtvdate.Leave
        'GMod.DataSetRet("select isnull(max(vou_date),'" & dtvdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvtype.Text & "'", "getMaxDate")
        'If dtvdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
        '    MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    dtvdate.Focus()
        'End If
    End Sub
    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.ValueChanged
        'Setting voucher date accrding to session
        'dtvdate.Value = GMod.SessionCurrentDate
        dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = GMod.SessionCurrentDate
    End Sub
    Private Sub txtCrNoFrom_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCrNoFrom.KeyUp
        If e.KeyCode = Keys.Enter Then txtCrNoTo.Focus()
    End Sub
    Private Sub txtCrNoTo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCrNoTo.KeyUp
        If e.KeyCode = Keys.Enter Then txtNarration.Focus()
    End Sub

    Private Sub txtNarration_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNarration.KeyUp
        If e.KeyCode = Keys.Enter Then btnshow.Focus()
    End Sub
    Private Sub btnshow_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnshow.KeyUp
        If e.KeyCode = Keys.Enter Then cmbacheadname.Focus()
    End Sub
    Private Sub cmbacheadname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyUp
        If e.KeyCode = Keys.Enter Then dtndebit.Focus()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim t As New frmCRPrint
        t.ShowDialog()
    End Sub
    Private Sub cmbacheadname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadname.Leave
        If cmbacheadname.FindStringExact(cmbacheadname.Text) = -1 Then
            MsgBox("Please select proper group name", MsgBoxStyle.Critical)
            cmbacheadname.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub cmbacheadname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadname.SelectedIndexChanged

    End Sub

  
End Class