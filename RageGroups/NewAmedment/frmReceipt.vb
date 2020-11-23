Imports System.Data.SqlClient
Public Class frmReceipt
    Dim sql, sqlsavecr As String

    Private Sub frmReceipt_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbcode.Text & "' and vou_type='R' and cmp_id='" & GMod.Cmpid & "'")
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

        sqlarea = "select group_name from groups where cmp_id='" & GMod.Cmpid & "'  and session = '" & GMod.Session & "'  and session = '" & GMod.Session & "'"
        GMod.DataSetRet(sqlarea, "gn")

        cmbgroup.DataSource = GMod.ds.Tables("gn")
        cmbgroup.DisplayMember = "group_name"

    End Sub
    Private Sub frmReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'date set as per session
        dtvdate.Value = GMod.SessionCurrentDate
        dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = GMod.SessionCurrentDate

        fillArea()

        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "'  and (vtype like '%CR VOUCHER%'  or  vtype like '%RECEIPT%' or  vtype like '%FRECEIPT%') and vtype not like 'sale CR'  and session = '" & GMod.Session & "'"
        GMod.DataSetRet(sql, "CRVT")
        cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
        cmbvoutype.DisplayMember = "vtype"

        fillheads()

        If GMod.username.ToUpper = "ADMIN" Then
            If GMod.Cmpid = "PHOE" Then
                btnModify.Enabled = True
                btnDelete.Enabled = True
            Else
                btnModify.Enabled = True
            End If
        Else
            If GMod.Cmpid = "PHOE" Then
                btnModify.Enabled = False
                btnDelete.Enabled = False
            Else
                btnModify.Enabled = True
            End If
        End If
            cmbvoutype.Focus()

            'SESSION CHECK FOR ENTRY 
            'MsgBox(GMod.Getsession(dtvdate.Value))
            If GMod.Getsession(dtvdate.Value) = GMod.Session Then
            Else
            ' Me.Close()
            End If
    End Sub
    Sub fillheads()
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'  and  Area_code in ('" & cmbAreaCode.Text & "','**')  order by account_head_name"
        GMod.DataSetRet(sql, "aclistcr")

        cmbcode.DataSource = GMod.ds.Tables("aclistcr")
        cmbcode.DisplayMember = "account_code"
        cmbAcHead.DataSource = GMod.ds.Tables("aclistcr")
        cmbAcHead.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclistcr")
        ComboBox1.DisplayMember = "group_name"

        ComboBox2.DataSource = GMod.ds.Tables("aclistcr")
        ComboBox2.DisplayMember = "sub_group_name"

        CmbMobileNo.DataSource = GMod.ds.Tables("aclistcr")
        CmbMobileNo.DisplayMember = "phone"


    End Sub
    Dim t As New frmCRVoucherNarration
    Private Sub txtNarration_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNarration.Enter
        'If GMod.Cmpid = "PHOE" Or GMod.Cmpid = "PhHA" Then
        t.ShowDialog()
        txtNarration.Text = t.TextBox1.Text
        dtHatchDate.Value = t.dtHatchDate.Value.ToShortDateString
        'Else
        'txtNarration.ReadOnly = False
        'End If
    End Sub
    Dim i As Integer = -1
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

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
        sqlsavecr &= "'" & cmbcode.Text & "',"
        sqlsavecr &= "'R',"
        sqlsavecr &= "'" & vouno & "',"
        sqlsavecr &= "'" & dtvdate.Value.ToShortDateString & "',"
        sqlsavecr &= "'" & Val("") & "',"
        sqlsavecr &= "'" & Val(txtamount.Text) & "',"
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
    Dim vouno As Long
    Dim ddate As DateTime = CDate("1/1/2000")
    Dim cr As Double = 0.0
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim smsmsg As String
        If MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim paymod As String
            If GMod.Cmpid = "PHHA" Then
                paymod = "-"
            Else
                paymod = GMod.username
            End If
            Dim sqltans As SqlTransaction
            Dim i As Integer

            If Val(txtCrmat.Text) = 0 Then
                MsgBox("Please Enter CR Amount.", MsgBoxStyle.Critical)
                txtCrmat.Focus()
                Exit Sub
            End If

            For i = 0 To DataGridView1.Rows.Count - 1
                cr = cr + Val(DataGridView1(3, i).Value)
            Next
            If DataGridView1.Rows.Count > 0 Then
                If cr <> Val(txtCrmat.Text) Then
                    MsgBox("Amount not matching!!", MsgBoxStyle.Critical)
                    txtCrmat.Focus()
                    cr = 0.0
                    'Exit Sub
                End If
            End If
            If btnModify.Text = "&Modify" Then
                sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & cmbvoutype.Text & "'"
                GMod.DataSetRet(sql, "vnor")
                vouno = ds.Tables("vnor").Rows(0)(0)
                txtvouno.Text = vouno
                If txtvouno.Text = "" Then
                    Me.Close()
                End If
            Else
                vouno = vn
                txtvouno.Text = vn
            End If
            If btnSave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, txtvouno.Text, cmbvoutype.Text, dtvdate.Value, Now, GMod.Session, "M", GMod.username)
            End If
            sqltans = GMod.SqlConn.BeginTransaction
            Try
                sql = "delete from Sale_Receipt where vou_type='" & vt & "' and  vou_no='" & vouno & "' and cmp_id='" & GMod.Cmpid & "' and cmp_id='" & GMod.Cmpid & "'"
                Dim cmddel As New SqlCommand(sql, GMod.SqlConn, sqltans)
                cmddel.ExecuteNonQuery()

                sql = "delete from " & GMod.VENTRY & " where vou_type='" & vt & "' and  vou_no='" & vouno & "'"
                Dim cmddel1 As New SqlCommand(sql, GMod.SqlConn, sqltans)
                cmddel1.ExecuteNonQuery()

                'cr entry
                sqlsavecr = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                sqlsavecr += "acc_head_code,Acc_head, cramt, dramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name,ch_issue_date"
                sqlsavecr += ") values( "
                sqlsavecr += "'" & GMod.Cmpid & "','" & GMod.username & "',0,'" & vouno & "',"
                sqlsavecr += "'" & cmbvoutype.Text & "','" & dtvdate.Value.ToShortDateString & "','" & cmbcode.Text & "','" & cmbAcHead.Text & "'," & Val(txtCrmat.Text) & "," & Val("") & ","
                sqlsavecr += "'" & paymod & "','" & txtChqNo.Text & "','" & txtNarration.Text & "','" & ComboBox1.Text & "',"
                sqlsavecr += "'" & ComboBox2.Text & "','" & dtHatchDate.Value.ToString & "')"
                'MsgBox(sqlsavecr)
                Dim cmd As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltans)
                cmd.ExecuteNonQuery()

                'For i = 0 To DataGridView1.RowCount - 1
                '    sqlsavecr = "insert into  Sale_Receipt (Ref_Type, Ref, Acc_Code, Vou_Type," & _
                '    " Vou_No, Vou_Date, dr, cr, dueon, Session,cmp_id) values( "
                '    sqlsavecr &= "'" & DataGridView1(0, i).Value & "',"
                '    sqlsavecr &= "'" & DataGridView1(1, i).Value & "',"
                '    sqlsavecr &= "'" & cmbcode.Text & "',"
                '    sqlsavecr &= "'" & cmbvoutype.Text & "',"
                '    sqlsavecr &= "'" & vouno & "',"
                '    sqlsavecr &= "'" & dtvdate.Value.ToShortDateString & "',"
                '    sqlsavecr &= "'" & Val("") & "',"
                '    sqlsavecr &= "'" & Val(DataGridView1(3, i).Value) & "',"
                '    sqlsavecr &= "'" & CDate(DataGridView1(2, i).Value).ToShortDateString & "',"
                '    sqlsavecr &= "'" & GMod.Session & "',"
                '    sqlsavecr &= "'" & GMod.Cmpid & "')"

                ' Dim cmd1 As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltans)
                'cmd1.ExecuteNonQuery()
                'Next

                ' Dim cmd2 As New SqlCommand("delete from tmpAging where acc_code='" & cmbcode.Text & "' and vou_type='R' and cmp_id='" & GMod.Cmpid & "'", GMod.SqlConn, sqltans)
                'cmd2.ExecuteNonQuery()
                sqltans.Commit()


                smsmsg = "Your A/c Credited by RS " & txtCrmat.Text & " against CR No. " & txtvouno.Text & " Date " & dtvdate.Text
                'Sending Sms

                If GMod.Cmpid = "PHHA" Then
                    Try
                        'End If
                        If CmbMobileNo.Text.ToString.Length >= 10 Then
                            'Dim snd As New sendsms
                            'snd.send_sms(CmbMobileNo.Text, smsmsg)
                        End If
                    Catch ex As Exception

                    End Try

                End If
                '-------------------------------------------
                MsgBox(cmbvoutype.Text & " / " & vouno, MsgBoxStyle.Information)

                txtCrmat.Text = ""
                DataGridView1.Rows.Clear()
                'dg.Rows.Clear()
                'If GMod.username.ToUpper = "CASHCOUNTER" Then
                '    _CASHCOUNTER = 1
                '    Dim tt As New frmCRPrint
                '    tt.txtfrom.Text = vouno
                '    tt.txtto.Text = vouno
                '    tt.btnshow_Click(sender, e)
                '    tt.btnprint_Click(sender, e)
                '    'tt.ShowDialog()
                '    tt.Close()
                '    tt.Dispose()
                'End If

                txtamount.Clear()
                txtvouno.Clear()
                txtNarration.Clear()
                txtChqNo.Clear()

            Catch ex As Exception
                sqltans.Rollback()
                sqltans = Nothing
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("CANCLLED")
            dtvdate.Focus()
            Exit Sub
        End If
            cmbvoutype.Focus()
            _CASHCOUNTER = 0
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
    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Escape Then
            txtref.Text = dg(0, dg.CurrentCell.RowIndex).Value
            txtamount.Text = dg(1, dg.CurrentCell.RowIndex).Value
            dg.Visible = False
            txtamount.Focus()
        End If
    End Sub
    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Try
            If btnSave.Enabled = True Then
                MsgBox(GMod.SqlExecuteNonQuery("delete from tmpAging where ci = '" & DataGridView1.CurrentCell.RowIndex & "' and usename ='" & GMod.username & "'"))
            Else
                sql = "select id from Sale_Receipt where ref_type='" & DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value & "' and ref='" & DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value & "' and vou_no='" & txtvouno.Text & "' and cr='" & DataGridView1(3, DataGridView1.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sql, "delSale_Receipt")

                sql = "delete from Sale_Receipt where id ='" & GMod.ds.Tables("delSale_Receipt").Rows(0)(0).ToString & "'"
                GMod.SqlExecuteNonQuery(sql)


                GMod.SqlExecuteNonQuery("delete from tmpAging where ci = '" & DataGridView1.CurrentCell.RowIndex & "' and usename ='" & GMod.username & "'")
            End If
            GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbcode.Text & "' and vou_type='R'")
            'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
            sql = "insert into  tmpAging (Ref_Type, Ref, Acc_Code,dr,vou_type,cmp_id) " & _
                 " select Ref_type,Ref,acc_code,sum(dr)-sum(cr) Amount,'R',cmp_id  " & _
                " from Sale_Receipt group by Ref,acc_code,Ref_type,cmp_id having sum(dr)-sum(cr)>0 " & _
                 " and acc_code='" & cmbcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.SqlExecuteNonQuery(sql)
            cmbRefType.SelectedIndex = 0
            cmbRefType.Focus()
        Catch ex As Exception

        End Try

    End Sub
    Dim k As Integer
    Dim vn, vt As String
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            If btnModify.Text = "&Modify" Then
                btnSave.Enabled = False
                'Dim r As New frmvoucherlist
                'r.ShowDialog()

                vt = cmbvoutype.Text
                vn = InputBox("Please Enter Voucher No")
                txtvouno.Text = vn
                If LockDataCheck(vn, GMod.Session, vt) = False Then
                    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Exit Sub
                End If
                If vt <> "" And vn <> "" Then
                    sql = "select ref_type,ref,dueon, cr from Sale_Receipt where vou_type='" & vt & "' and  vou_no='" & vn & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
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
                sql = "select acc_head,acc_head_code,vou_date,cramt,narration,acc_head,group_name from " & GMod.VENTRY & " where vou_type='" & vt & "' and  vou_no='" & vn & "'"
                GMod.DataSetRet(sql, "mfy")
                cmbgroup.Text = GMod.ds.Tables("mfy").Rows(0)("group_name").ToString
                cmbcode.DropDownStyle = ComboBoxStyle.DropDown
                cmbcode.Text = GMod.ds.Tables("mfy").Rows(0)("acc_head_code").ToString
                cmbAcHead.Text = GMod.ds.Tables("mfy").Rows(0)("acc_head").ToString
                dtvdate.Value = CDate(GMod.ds.Tables("mfy").Rows(0)("vou_date"))
                txtCrmat.Text = GMod.ds.Tables("mfy").Rows(0)("cramt").ToString
                txtNarration.Text = GMod.ds.Tables("mfy").Rows(0)("narration").ToString
                'MsgBox(vt & vn)
                btnModify.Text = "&Update"
            Else
                If MessageBox.Show("Do U want to Modify", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    btnSave_Click(sender, e)
                    btnModify.Text = "&Modify"
                    DataGridView1.Rows.Clear()
                    dg.Rows.Clear()
                    btnSave.Enabled = True
                    txtvouno.Clear()
                    cmbcode.DropDownStyle = ComboBoxStyle.DropDownList
                Else
                    btnModify.Text = "&Modify"
                    DataGridView1.Rows.Clear()
                    dg.Rows.Clear()
                    btnSave.Enabled = True
                    txtvouno.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcode.Leave
        If btnSave.Enabled = True Then
            'sql = "select *  from tmpAging where acc_code ='" & cmbcode.Text & "' and vou_type='R' and cmp_id='" & GMod.Cmpid & "'"
            'GMod.DataSetRet(sql, "jj")
            'If GMod.ds.Tables("jj").Rows.Count > 0 Then
            '    MsgBox("Please select diffent head")
            '    Me.Close()
            '    Exit Sub
            'End If
        End If
        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbcode.Text & "' and vou_type='R'")
        'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
        sql = "insert into  tmpAging (Ref_Type, Ref, Acc_Code,dr,vou_type,cmp_id) " & _
             " select Ref_type,Ref,acc_code,sum(dr)-sum(cr) Amount,'R',cmp_id  " & _
            " from Sale_Receipt group by Ref,acc_code,Ref_type,cmp_id having sum(dr)-sum(cr)>0 " & _
             " and acc_code='" & cmbcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
        GMod.SqlExecuteNonQuery(sql)
    End Sub
    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'  and  left(account_code,2) in ('" & cmbAreaCode.Text & "')  order by account_head_name"
        GMod.DataSetRet(sql, "aclistcr")

        cmbcode.DataSource = GMod.ds.Tables("aclistcr")
        cmbcode.DisplayMember = "account_code"
        cmbAcHead.DataSource = GMod.ds.Tables("aclistcr")
        cmbAcHead.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclistcr")
        ComboBox1.DisplayMember = "group_name"

        ComboBox2.DataSource = GMod.ds.Tables("aclistcr")
        ComboBox2.DisplayMember = "sub_group_name"

        CmbMobileNo.DataSource = GMod.ds.Tables("aclistcr")
        CmbMobileNo.DisplayMember = "phone"

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'If GMod.username.ToUpper <> "CASHCOUNTER" Then
        _CASHCOUNTER = 0
        Dim tt As New frmCRPrintNew
        tt.ShowDialog()
        'End If
    End Sub

    Private Sub dtvdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtvdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtvdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtvdate.Leave
        GMod.DataSetRet("select isnull(max(vou_date),'" & dtvdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvoutype.Text & "'", "getMaxDate")
        If dtvdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
            MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            dtvdate.Focus()
        End If
    End Sub

    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.ValueChanged
        '---- Resting date to as per session
        'dtvdate.Value = GMod.SessionCurrentDate
        dtvdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtvdate.MaxDate = GMod.SessionCurrentDate

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
            MsgBox("Slecet correct A/c Head", MsgBoxStyle.Critical)
            cmbAcHead.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub cmbAcHead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAcHead.SelectedIndexChanged
       
    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAreaName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAreaName.Leave

    End Sub

    Private Sub cmbAreaName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.SelectedIndexChanged

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmbvoutype_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvoutype.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtvouno_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvouno.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtvouno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvouno.TextChanged

    End Sub

    Private Sub cmbgroup_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgroup.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgroup.SelectedIndexChanged

    End Sub

    Private Sub cmbcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcode.SelectedIndexChanged

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
    Private Sub txtNarration_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNarration.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtChqNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChqNo.KeyPress
       
    End Sub
    Private Sub txtChqNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChqNo.KeyUp
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

    Private Sub btnOk_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOk.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class