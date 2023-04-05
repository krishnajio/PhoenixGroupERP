Imports System.Data.SqlClient
Public Class frmTdsMultiPleEntry
    Dim sql As String
    Dim TaxFlag As String
    Dim TaxPer As Integer
    Private Sub frmTdsMultiPleEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            GMod.DataSetRet("select getdate()", "serverdate")
            dtdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try

        
            'dtpexpensedate.Value = CDate("1/1/2000")
            If GMod.Cmpid = "PHOE" Then
                sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq='" & GMod.Dept & "'  and session = '" & GMod.Session & "'"

            Else
                sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and session = '" & GMod.Session & "'"
            End If
            GMod.DataSetRet(sql, "vtmultds")
        cmbvtype.DataSource = GMod.ds.Tables("vtmultds")
        cmbvtype.DisplayMember = "vtype"

        cmbvtype.SelectedIndex = 1

        sql = "select * from TdsMater where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "tdm")

        cmbtdsType.DataSource = GMod.ds.Tables("tdm")
        cmbtdsType.DisplayMember = "TdsType"


        cmbTdsper.DataSource = GMod.ds.Tables("tdm")
        cmbTdsper.DisplayMember = "Per"


        cmbacheadcode.DataSource = GMod.ds.Tables("tdm")
        cmbacheadcode.DisplayMember = "Acc_Code"

        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
        'cmbAreaCode.Text = GMod.AreaCode



        sqlarea = "select group_name from groups where cmp_id='" & GMod.Cmpid & "'  and session = '" & GMod.Session & "'"

        'sqlarea = "select distinct Group_name from  " & GMod.VENTRY
        GMod.DataSetRet(sqlarea, "gn")
        cmbgroup.DataSource = GMod.ds.Tables("gn")
        cmbgroup.DisplayMember = "group_name"
        cmbTdsYn.SelectedIndex = 0




        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'and left(account_code,2) in ('**','" & cmbAreaCode.Text & "')"
        GMod.DataSetRet(sql, "aclist20")
        cmbPartCode.DataSource = GMod.ds.Tables("aclist20")
        cmbPartCode.DisplayMember = "account_code"
        cmbPartyHead.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyHead.DisplayMember = "account_head_name"
        cmbPartyGroup.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyGroup.DisplayMember = "group_name"
        ' cmbPartySubGroup.DataSource = GMod.ds.Tables("aclist20")
        'cmbPartySubGroup.DisplayMember = "sub_group_name"
        'SESSION CHECK FOR ENTRY 
        'MsgBox(GMod.Getsession(dtvdate.Value))
        Catch ex As Exception

        End Try
        If GMod.Getsession(dtdate.Value) = GMod.Session Then
        Else
            ' Me.Close()
        End If
        cmbvtype.Focus()
    End Sub

    Private Sub cmbvtype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvtype.Leave

    End Sub

    Private Sub cmbvtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype.SelectedIndexChanged
        If cmbvtype.FindStringExact(cmbvtype.Text) = -1 Then
            MsgBox("Please select correct voucher", MsgBoxStyle.Critical)
            cmbvtype.Focus()
        Else
            'sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "'"
            ''MsgBox(sql)
            'GMod.DataSetRet(sql, "vno8")
            'lblvouno.Text = ds.Tables("vno8").Rows(0)(0)
        End If
    End Sub
    Dim i As Integer = -1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim obj() As Object = {cmbFreightHead.Text, cmbFrightCode.Text, txtDr.Text, txtCr.Text, cmbTdsYn.Text, cmbFreightGroup.Text, cmbFreightSubGroup.Text, txtnarr.Text, cmbPartCode.Text, txtActualAmt.Text, cmbtdsType.Text, cmbTdsper.Text}
            If i <> -1 Then
                DataGridView1.Rows.RemoveAt(i)
                DataGridView1.Rows.Insert(i, obj)
            Else
                DataGridView1.Rows.Add(obj)
            End If
            cmbFreightHead.Select()
            i = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        sum()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        sum()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Dim k As Integer
    Dim sqlsavenecc As String
    Dim expflag As Boolean = False

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If expflag = False Then
            MessageBox.Show("Please Select the Expense Month/Date", "Expenses Month/Date:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpexpensedate.Focus()
            Exit Sub
        End If
        If cmbvtype.Text = "BANK" Then
            sql = "select * from dummy_VENTRY where Posted='N' and cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"

            GMod.DataSetRet(sql, "chkforpost")
            If GMod.ds.Tables("chkforpost").Rows.Count > 0 Then
                MsgBox("Please post bank voucher", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

            If Val(lblcr.Text) <> Val(lbldr.Text) Then
                MsgBox("Dr Not Equals to Cr")
                Exit Sub
                cmbvtype.Focus()
            End If

            Dim trans As SqlTransaction
            trans = GMod.SqlConn.BeginTransaction
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "'"
            ''MsgBox(sql)
            GMod.DataSetRet(sql, "vno8")
            lblvouno.Text = ds.Tables("vno8").Rows(0)(0)
            Try

                For k = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1(4, k).Value.ToString.ToUpper = "YES" Then
                        VoucherTax = DataGridView1(10, k).Value
                        TaxFlag = "TDS"
                        TaxPer = Val(DataGridView1(11, k).Value)
                    End If
                Next
                For k = 0 To DataGridView1.Rows.Count - 1
                    sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                    & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                    & " Narration, Group_name, Sub_group_name,exp_date,VoucherTax, TaxPer, TaxType, WinOut) VALUES ("
                    sqlsavenecc &= "'" & GMod.Cmpid & "',"
                    sqlsavenecc &= "'" & GMod.username & "',"
                    sqlsavenecc &= "'" & k & "',"
                    sqlsavenecc &= "'" & lblvouno.Text & "',"
                    sqlsavenecc &= "'" & cmbvtype.Text & "',"
                    sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                    sqlsavenecc &= "'" & DataGridView1(1, k).Value & "',"
                    sqlsavenecc &= "'" & DataGridView1(0, k).Value & "',"
                    sqlsavenecc &= "'" & Val(DataGridView1(2, k).Value) & "',"
                    sqlsavenecc &= "'" & Val(DataGridView1(3, k).Value) & "',"
                    sqlsavenecc &= "'" & DataGridView1(7, k).Value & "',"
                    sqlsavenecc &= "'" & DataGridView1(5, k).Value & "',"
                    sqlsavenecc &= "'" & DataGridView1(6, k).Value & "',"
                    sqlsavenecc &= "'" & dtpexpensedate.Value.ToShortDateString & "',"

                    sqlsavenecc &= "'" & TaxFlag & "',"
                    sqlsavenecc &= "'" & TaxPer & "',"
                    sqlsavenecc &= "'" & VoucherTax & "',"
                    sqlsavenecc &= "'')"

                    Dim cmd3 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                    cmd3.ExecuteNonQuery()

                    If DataGridView1(4, k).Value.ToString.ToUpper = "YES" Then
                        sql = "insert into TdsEntry(Vou_Type, Vou_no, TdsType, Per, TdsDate, " _
                        & " BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt," _
                         & " Actualamt, session,Paidto,vou_date, TdsAmt,dcode,cmp_id ) values( "
                        sql &= "'" & cmbvtype.Text & "',"
                        sql &= "'" & lblvouno.Text & "',"
                        sql &= "'" & DataGridView1(10, k).Value & "',"
                        sql &= "'" & Val(DataGridView1(11, k).Value) & "',"
                        sql &= "'" & dtdate.Value.ToShortDateString & "',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'0',"
                        sql &= "'" & Val(DataGridView1(9, k).Value) & "',"
                        sql &= "'" & Val("") & "',"
                        sql &= "'" & GMod.Session & "',"
                        sql &= "'YES',"
                        sql &= "'" & dtdate.Value.ToShortDateString & "',"
                        sql &= "'" & Val(DataGridView1(3, k).Value) & "',"
                        sql &= "'" & DataGridView1(8, k).Value & "',"
                        sql &= "'" & GMod.Cmpid & "')"

                        Dim cmd6 As New SqlCommand(sql, SqlConn, trans)
                        cmd6.ExecuteNonQuery()
                    End If
                Next
                VoucherTax = ""
                TaxFlag = ""
                TaxPer = Val("")
                trans.Commit()
                MsgBox(cmbvtype.Text & "/" & lblvouno.Text)
                DataGridView1.Rows.Clear()
                ClearControls(Me)
            Catch ex As Exception
                MsgBox(ex.Message)
                trans.Rollback()
            End Try
            lblcr.Text = ""
            lbldr.Text = ""
        Else
            Exit Sub
        End If
        expflag = False
    End Sub
    Private Sub ClearControls(ByVal topControl As Control)
        ' Ignore the control unless it is a textbox.
        If TypeOf topControl Is TextBox Then
            topControl.Text = ""
        Else
            ' Process controls recursively.
            ' This is required if controls contain other controls
            ' (for example, if you use panels, group boxes, or other
            ' container controls).
            For Each childControl As Control In topControl.Controls
                ClearControls(childControl)
            Next
        End If
    End Sub
    Private Sub txtDr_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDr.Enter
        txtDr.SelectAll()
    End Sub

    Private Sub txtDr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDr.TextChanged
        If Val(txtDr.Text) > 0 Then
            txtCr.Enabled = False
        Else
            txtCr.Enabled = True
        End If
    End Sub

    Private Sub txtCr_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCr.Enter
        txtCr.SelectAll()
    End Sub

    Private Sub txtCr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCr.TextChanged
        If Val(txtCr.Text) > 0 Then
            txtDr.Enabled = False
        Else
            txtDr.Enabled = True
        End If
    End Sub

    Private Sub cmbTdsYn_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTdsYn.Leave
        If cmbTdsYn.Text.ToUpper = "YES" Then
            cmbPartyHead.Visible = True
            cmbPartCode.Visible = True
            cmbPartyGroup.Visible = True
        Else
            cmbPartyHead.Visible = False
            cmbPartCode.Visible = False
            cmbPartyGroup.Visible = False
        End If
    End Sub

    Private Sub cmbTdsYn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTdsYn.SelectedIndexChanged
        If cmbTdsYn.Text.ToUpper = "YES" Then
            cmbPartyHead.Visible = True
            cmbPartCode.Visible = True
            cmbPartyGroup.Visible = True
            txtActualAmt.Visible = True
            Label11.Visible = True
            Label12.Visible = True

            cmbtdsType.Visible = True
            cmbTdsper.Visible = True
            cmbacheadcode.Visible = True
            cmbFreightSubGroup.Visible = True
            Label4.Visible = True


        Else
            cmbPartyHead.Visible = False
            cmbPartCode.Visible = False
            cmbPartyGroup.Visible = False
            txtActualAmt.Visible = False
            Label11.Visible = False
            Label12.Visible = False


            cmbtdsType.Visible = False
            cmbTdsper.Visible = False
            cmbacheadcode.Visible = False
            cmbFreightSubGroup.Visible = False
            Label4.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(DataGridView1(4, 0).Value.ToString.ToUpper)
    End Sub


    Sub sum()
        Dim i As Integer
        Dim cr, dr As Double
        cr = 0
        dr = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            dr = Val(dr) + Val(DataGridView1(2, i).Value)
            cr = Val(cr) + Val(DataGridView1(3, i).Value)
        Next
        lbldr.Text = dr
        lblcr.Text = cr
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            sum()
        End If
    End Sub



    Private Sub dtdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtdate.Leave
        If Button2.Enabled = True Then
            GMod.DataSetRet("select isnull(max(vou_date),'" & dtdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvtype.Text & "'", "getMaxDate")
            If dtdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
                MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dtdate.Focus()
            End If
        End If
    End Sub

    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdate.ValueChanged
        'SetLastVouDate()
        'GMod.DataSetRet("select getdate()", "serverdate")

        'dtdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        'dtdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        Try
            '---- Resting date to server date 
            ' GMod.DataSetRet("select getdate()", "serverdate")
            'dtdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
            'dtdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbFreightHead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFreightHead.Leave
        If cmbFreightHead.FindStringExact(cmbFreightHead.Text) = -1 Then
            MsgBox("Please select proper head name", MsgBoxStyle.Critical)
            cmbFreightHead.Focus()
            Exit Sub
        End If
    End Sub



    Private Sub cmbPartyHead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartyHead.Leave
        If cmbPartyHead.FindStringExact(cmbPartyHead.Text) = -1 Then
            MsgBox("Please select proper head name", MsgBoxStyle.Critical)
            cmbPartyHead.Focus()
            Exit Sub
        End If

    End Sub
    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'and left(account_code,2) in ('**','" & cmbAreaCode.Text & "')"
        GMod.DataSetRet(sql, "aclisttds")
        cmbFrightCode.DataSource = GMod.ds.Tables("aclisttds")
        cmbFrightCode.DisplayMember = "account_code"
        cmbFreightHead.DataSource = GMod.ds.Tables("aclisttds")
        cmbFreightHead.DisplayMember = "account_head_name"
        cmbFreightGroup.DataSource = GMod.ds.Tables("aclisttds")
        cmbFreightGroup.DisplayMember = "group_name"

        cmbFreightSubGroup.DataSource = GMod.ds.Tables("aclisttds")
        cmbFreightSubGroup.DisplayMember = "sub_group_name"



        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'and left(account_code,2) in ('**','" & cmbAreaCode.Text & "')"
        GMod.DataSetRet(sql, "aclist20")
        cmbPartCode.DataSource = GMod.ds.Tables("aclist20")
        cmbPartCode.DisplayMember = "account_code"
        cmbPartyHead.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyHead.DisplayMember = "account_head_name"
        cmbPartyGroup.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyGroup.DisplayMember = "group_name"
    End Sub

    Private Sub cmbAreaName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAreaName.Leave
        If cmbAreaName.FindStringExact(cmbAreaName.Text) = -1 Then
            MsgBox("Please select correct Area", MsgBoxStyle.Exclamation)
            cmbAreaName.Focus()
            Exit Sub
        End If
    End Sub
    Dim j As Integer
    Dim dr1, cr1 As Double

    Private Sub btn_modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modify.Click
        If Button2.Enabled Then
            Button2.Enabled = False
            btn_modify.Text = "&Update"
            'Dim i As Integer
            'Dim r As New frmvoucherlist
            'r.ShowDialog()
            'cmbvoutype.Text = r.cmbvtype.Text
            lblvouno.Text = InputBox("Enter Voucher No:")
            If lblvouno.Text = "" Then
                Exit Sub
                MsgBox("Please enter voucher no")
            End If
            cmbvtype.Enabled = False

            sql = "select * from " & GMod.VENTRY & " where  vou_type ='" & cmbvtype.Text & "' and vou_no='" & lblvouno.Text & "'"
            GMod.DataSetRet(sql, "modifypay")
            If GMod.ds.Tables("modifypay").Rows.Count = 0 Then
                MsgBox("No voucher found...", MsgBoxStyle.Critical)
                cmbvtype.Enabled = False
                cmbvtype.Focus()
                btn_modify.Text = "&Modify"
                Exit Sub
            Else
                For i = 0 To GMod.ds.Tables("modifypay").Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1(0, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Acc_head")
                    DataGridView1(1, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Acc_head_code")
                    DataGridView1(2, i).Value = GMod.ds.Tables("modifypay").Rows(i)("dramt")
                    DataGridView1(3, i).Value = GMod.ds.Tables("modifypay").Rows(i)("cramt")
                    DataGridView1(5, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Group_name")
                    DataGridView1(6, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Sub_group_name")
                    DataGridView1(7, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Narration")
                    'DataGridView1(7, i).Value = GMod.ds.Tables("modifypay").Rows(i)("Cheque_no")
                Next
                For j = 0 To DataGridView1.Rows.Count - 1
                    dr1 = dr1 + Val(DataGridView1(2, j).Value)
                    cr1 = cr1 + Val(DataGridView1(3, j).Value)
                Next
                lblcr.Text = cr1
                lbldr.Text = dr1
                dr1 = 0
                cr1 = 0

            End If
            dtdate.MinDate = CDate(GMod.ds.Tables("modifypay").Rows(0)("Vou_date"))
            dtdate.Value = CDate(GMod.ds.Tables("modifypay").Rows(0)("Vou_date"))

        End If

    End Sub

    Private Sub cmbPartCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartCode.Leave


    End Sub

    Private Sub cmbPartCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartCode.SelectedIndexChanged

    End Sub

    Private Sub cmbPartyHead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartyHead.SelectedIndexChanged

    End Sub

    Private Sub txtActualAmt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtActualAmt.Enter
        ' tdsflag = True
        'tdsdcode = cmbPartCode.Text
        'Dim objPartyfrom As New frmPartyaccount
        'objPartyfrom.ShowDialog()
        'tdsflag = False
        'On Error Resume Next
        filltdsparty()
    End Sub
    Sub filltdsparty()

        Dim i As Integer
        sql = "select * from " & GMod.ACC_HEAD & "   where  cmp_id='" & GMod.Cmpid & "' and  account_code='" & cmbPartCode.Text & "'"

        GMod.DataSetRet(sql, "acc")
        MessageBox.Show(GMod.ds.Tables("acc").Rows(0)("account_head_name") & " # " & GMod.ds.Tables("acc").Rows(0)("credit_days") & "#" & GMod.ds.Tables("acc").Rows(0)("address") & " ," & GMod.ds.Tables("acc").Rows(0)("state") & "#" & GMod.ds.Tables("acc").Rows(0)("pan_no"))

    End Sub

    Private Sub txtActualAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtActualAmt.TextChanged

    End Sub

    Private Sub cmbgroup_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgroup.Leave

        If cmbgroup.FindStringExact(cmbgroup.Text) = -1 Then
            MsgBox("Please select proper head name", MsgBoxStyle.Critical)
            cmbgroup.Focus()
            Exit Sub
        End If


        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'and left(account_code,2) in ('**','" & cmbAreaCode.Text & "') and group_name ='" & cmbgroup.Text & "'"
        GMod.DataSetRet(sql, "aclist1")
        cmbFrightCode.DataSource = GMod.ds.Tables("aclist1")
        cmbFrightCode.DisplayMember = "account_code"
        cmbFreightHead.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightHead.DisplayMember = "account_head_name"
        cmbFreightGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightGroup.DisplayMember = "group_name"

        cmbFreightSubGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightSubGroup.DisplayMember = "sub_group_name"
    End Sub

    Private Sub cmbgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgroup.SelectedIndexChanged

    End Sub

    Private Sub cmbPartyGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartyGroup.SelectedIndexChanged

    End Sub

    Private Sub cmbFreightHead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFreightHead.SelectedIndexChanged

    End Sub

    Private Sub dtpexpensedate_ValueChanged(sender As Object, e As EventArgs) Handles dtpexpensedate.ValueChanged
        expflag = True
    End Sub
End Class