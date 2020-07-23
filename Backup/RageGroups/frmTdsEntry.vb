Imports System.Data.SqlClient
Public Class frmTdsEntry
    Dim sql As String, sqlsavenecc As String
    Private Sub cmbvtype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvtype.Leave

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


    Private Sub frmTdsEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GMod.DataSetRet("select getdate()", "serverdate")

        ' dtdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        dtdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq='" & GMod.Dept & "'"
        GMod.DataSetRet(sql, "vttds")
        cmbvtype.DataSource = GMod.ds.Tables("vttds")
        cmbvtype.DisplayMember = "vtype"



        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq='" & GMod.Dept & "'"
        GMod.DataSetRet(sql, "vt1")
        cmbvtype1.DataSource = GMod.ds.Tables("vt1")
        cmbvtype1.DisplayMember = "vtype"

        sql = "select * from TdsMater where cmp_id ='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "tdm")

        cmbtdsType.DataSource = GMod.ds.Tables("tdm")
        cmbtdsType.DisplayMember = "TdsType"


        cmbTdsper.DataSource = GMod.ds.Tables("tdm")
        cmbTdsper.DisplayMember = "Per"

        cmbacheadcode.DataSource = GMod.ds.Tables("tdm")
        cmbacheadcode.DisplayMember = "Acc_Code"


        FillAcHead()
        fillgrid()
        cmbtdsType_Leave(sender, e)
        dtpexpensedate.Value = CDate("1/1/2000")

        If GMod.Getsession(dtdate.Value) = GMod.Session Then
        Else
            Me.Close()
        End If
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

    Sub FillAcHead()
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "aclist1")
        cmbFrightCode.DataSource = GMod.ds.Tables("aclist1")
        cmbFrightCode.DisplayMember = "account_code"
        cmbFreightHead.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightHead.DisplayMember = "account_head_name"
        cmbFreightGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightGroup.DisplayMember = "group_name"
        cmbFreightSubGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightSubGroup.DisplayMember = "sub_group_name"

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and group_name like '%PARTY%'"
        GMod.DataSetRet(sql, "aclist20")
        cmbPartCode.DataSource = GMod.ds.Tables("aclist20")
        cmbPartCode.DisplayMember = "account_code"
        cmbPartyHead.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyHead.DisplayMember = "account_head_name"
        cmbPartyGroup.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyGroup.DisplayMember = "group_name"
        cmbPartySubGroup.DataSource = GMod.ds.Tables("aclist20")
        cmbPartySubGroup.DisplayMember = "sub_group_name"

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "aclistb")
        cmbbankcode.DataSource = GMod.ds.Tables("aclistb")
        cmbbankcode.DisplayMember = "account_code"
        cmbbankHead.DataSource = GMod.ds.Tables("aclistb")
        cmbbankHead.DisplayMember = "account_head_name"
        cmbbankgroup.DataSource = GMod.ds.Tables("aclistb")
        cmbbankgroup.DisplayMember = "group_name"
        cmbbanksubgroup.DataSource = GMod.ds.Tables("aclistb")
        cmbbanksubgroup.DisplayMember = "sub_group_name"
    End Sub

    Private Sub cmbtdsType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtdsType.Leave
        'cmbTdsCode.Text = cmbacheadcode.Text

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and account_code='" & cmbacheadcode.Text & "'"
        GMod.DataSetRet(sql, "aclist2")
        cmbTdsCode.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsCode.DisplayMember = "account_code"
        cmbTdsHead.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsHead.DisplayMember = "account_head_name"
        CmbTdsGroup.DataSource = GMod.ds.Tables("aclist2")
        CmbTdsGroup.DisplayMember = "group_name"
        cmbTdsSubGroup.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsSubGroup.DisplayMember = "sub_group_name"
    End Sub
    Private Sub cmbtdsType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtdsType.SelectedIndexChanged
        cmbtdsType_Leave(sender, e)
    End Sub
    Private Sub txtActualAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtActualAmt.TextChanged
        txttdsAmount.Text = Val(txtActualAmt.Text) * (Val(cmbTdsper.Text) / 100)
    End Sub
    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged
        ' cmbTdsCode.Text = cmbacheadcode.Text
    End Sub
    Dim narr As String
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmbvtype.Text = "BANK" Then
            GMod.DataSetRet("select  * from dummy_VENTRY where  cmp_id='" & GMod.Cmpid & "' and posted='N' and vou_type='BANK' and session ='" & GMod.Session & "'", "chkposted")
            If GMod.ds.Tables("chkposted").Rows.Count > 0 Then
                MsgBox("Please Post the voucher", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Dim trans As SqlTransaction
            trans = GMod.SqlConn.BeginTransaction

            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "'"
            ''MsgBox(sql)
            GMod.DataSetRet(sql, "vno8")
            lblvouno.Text = ds.Tables("vno8").Rows(0)(0)
            Try
                sql = "delete from TdsEntry where vou_type='" & cmbvtype.Text & "' and vou_no='" & lblvouno.Text & " ' and session='" & GMod.Session & "'"
                Dim cmd1 As New SqlCommand(sql, SqlConn, trans)
                cmd1.ExecuteNonQuery()

                Dim cmd2 As New SqlCommand("delete from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'", GMod.SqlConn, trans)
                cmd2.ExecuteNonQuery()

                sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                & " Narration, Group_name, Sub_group_name,Ch_date) VALUES ("
                sqlsavenecc &= "'" & GMod.Cmpid & "',"
                sqlsavenecc &= "'" & GMod.username & "',"
                sqlsavenecc &= "'0',"
                sqlsavenecc &= "'" & lblvouno.Text & "',"
                sqlsavenecc &= "'" & cmbvtype.Text & "',"
                sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                sqlsavenecc &= "'" & cmbFrightCode.Text & "',"
                sqlsavenecc &= "'" & cmbFreightHead.Text & "',"
                sqlsavenecc &= "'" & Val(txtPaidAmt.Text) & "',"
                sqlsavenecc &= "'0',"
                sqlsavenecc &= "'" & narr & "',"
                sqlsavenecc &= "'" & cmbFreightGroup.Text & "',"
                sqlsavenecc &= "'" & cmbFreightSubGroup.Text & "',"
                sqlsavenecc &= "'" & dtpexpensedate.Value.ToShortDateString & "')"

                Dim cmd3 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                cmd3.ExecuteNonQuery()



                sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
               & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
               & " Narration, Group_name, Sub_group_name,Ch_date) VALUES ("
                sqlsavenecc &= "'" & GMod.Cmpid & "',"
                sqlsavenecc &= "'" & GMod.username & "',"
                sqlsavenecc &= "'1',"
                sqlsavenecc &= "'" & lblvouno.Text & "',"
                sqlsavenecc &= "'" & cmbvtype.Text & "',"
                sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                sqlsavenecc &= "'" & cmbTdsCode.Text & "',"
                sqlsavenecc &= "'" & cmbTdsHead.Text & "',"
                sqlsavenecc &= "'0',"
                sqlsavenecc &= "'" & Val(txttdsAmount.Text) & "',"
                sqlsavenecc &= "'" & narr & "',"
                sqlsavenecc &= "'" & CmbTdsGroup.Text & "',"
                sqlsavenecc &= "'" & cmbTdsSubGroup.Text & "',"
                sqlsavenecc &= "'" & dtpexpensedate.Value.ToShortDateString() & "')"
                Dim cmd4 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                cmd4.ExecuteNonQuery()


                sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                & " Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                sqlsavenecc &= "'" & GMod.Cmpid & "',"
                sqlsavenecc &= "'" & GMod.username & "',"
                sqlsavenecc &= "'2',"
                sqlsavenecc &= "'" & lblvouno.Text & "',"
                sqlsavenecc &= "'" & cmbvtype.Text & "',"
                sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                sqlsavenecc &= "'" & cmbPartCode.Text & "',"
                sqlsavenecc &= "'" & cmbPartyHead.Text & "',"
                sqlsavenecc &= "'0',"
                sqlsavenecc &= "'" & Val(txtPaidAmt.Text) - Val(txttdsAmount.Text) & "',"
                sqlsavenecc &= "'" & narr & "',"
                sqlsavenecc &= "'" & cmbPartyGroup.Text & "',"
                sqlsavenecc &= "'" & cmbPartySubGroup.Text & "',"
                sqlsavenecc &= "'" & dtpexpensedate.Value.ToShortDateString() & "')"
                Dim cmd5 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                cmd5.ExecuteNonQuery()

                sql = "insert into TdsEntry(Vou_Type, Vou_no, TdsType, Per, TdsDate, " _
                & " BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt," _
                & " Actualamt, session,Paidto,vou_date, TdsAmt,dcode,cmp_id) values( "
                sql &= "'" & cmbvtype.Text & "',"
                sql &= "'" & lblvouno.Text & "',"
                sql &= "'" & cmbtdsType.Text & "',"
                sql &= "'" & cmbTdsper.Text & "',"
                sql &= "'" & dtdate.Value.ToShortDateString & "',"
                sql &= "'" & txtBilltyNo.Text & "',"
                sql &= "'" & txtBilltydate.Text & "',"
                sql &= "'" & txtVhno.Text & "',"
                sql &= "'" & txtqty.Text & "',"
                sql &= "'" & txtPrd.Text & "',"
                sql &= "'" & Val(txtPaidAmt.Text) & "',"
                sql &= "'" & Val(txtActualAmt.Text) & "',"
                sql &= "'" & GMod.Session & "',"
                sql &= "'" & txtPaidTo.Text & "',"
                sql &= "'" & dtdate.Value.ToShortDateString & "',"
                sql &= "'" & Val(txttdsAmount.Text) & "',"
                sql &= "'" & cmbPartCode.Text & "',"
                sql &= "'" & GMod.Cmpid & "')"

                Dim cmd6 As New SqlCommand(sql, SqlConn, trans)
                cmd6.ExecuteNonQuery()


                If ChkBankEntry.Checked = True Then
                    If Val(txtBankamt.Text) = 0 Then
                        sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name,Cheque_no) VALUES ("
                        sqlsavenecc &= "'" & GMod.Cmpid & "',"
                        sqlsavenecc &= "'" & GMod.username & "',"
                        sqlsavenecc &= "'2',"
                        sqlsavenecc &= "'" & lblvouno1.Text & "',"
                        sqlsavenecc &= "'" & cmbvtype1.Text & "',"
                        sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                        sqlsavenecc &= "'" & cmbPartCode.Text & "',"
                        sqlsavenecc &= "'" & cmbPartyHead.Text & "',"
                        sqlsavenecc &= "'" & Val(txtPaidAmt.Text) - Val(txttdsAmount.Text) & "',"
                        sqlsavenecc &= "'0',"
                        sqlsavenecc &= "'" & narr & "',"
                        sqlsavenecc &= "'" & cmbPartyGroup.Text & "',"
                        sqlsavenecc &= "'" & cmbPartySubGroup.Text & "',"
                        sqlsavenecc &= "'" & txtchq.Text & "')"

                        Dim cmd7 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                        cmd7.ExecuteNonQuery()


                        sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name,Cheque_no) VALUES ("
                        sqlsavenecc &= "'" & GMod.Cmpid & "',"
                        sqlsavenecc &= "'" & GMod.username & "',"
                        sqlsavenecc &= "'2',"
                        sqlsavenecc &= "'" & lblvouno1.Text & "',"
                        sqlsavenecc &= "'" & cmbvtype1.Text & "',"
                        sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                        sqlsavenecc &= "'" & cmbbankcode.Text & "',"
                        sqlsavenecc &= "'" & cmbbankHead.Text & "',"
                        sqlsavenecc &= "'0',"
                        sqlsavenecc &= "'" & Val(txtPaidAmt.Text) - Val(txttdsAmount.Text) & "',"
                        sqlsavenecc &= "'" & narr & "',"
                        sqlsavenecc &= "'" & cmbbankgroup.Text & "',"
                        sqlsavenecc &= "'" & cmbbanksubgroup.Text & "',"
                        sqlsavenecc &= "'" & txtchq.Text & "')"
                        Dim cmd8 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                        cmd8.ExecuteNonQuery()
                    Else

                        sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                                           & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                                           & " Narration, Group_name, Sub_group_name,Cheque_no) VALUES ("
                        sqlsavenecc &= "'" & GMod.Cmpid & "',"
                        sqlsavenecc &= "'" & GMod.username & "',"
                        sqlsavenecc &= "'2',"
                        sqlsavenecc &= "'" & lblvouno1.Text & "',"
                        sqlsavenecc &= "'" & cmbvtype1.Text & "',"
                        sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                        sqlsavenecc &= "'" & cmbPartCode.Text & "',"
                        sqlsavenecc &= "'" & cmbPartyHead.Text & "',"
                        sqlsavenecc &= "'" & Val(txtBankamt.Text) & "',"
                        sqlsavenecc &= "'0',"
                        sqlsavenecc &= "'" & narr & "',"
                        sqlsavenecc &= "'" & cmbPartyGroup.Text & "',"
                        sqlsavenecc &= "'" & cmbPartySubGroup.Text & "',"
                        sqlsavenecc &= "'" & txtchq.Text & "')"

                        Dim cmd7 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                        cmd7.ExecuteNonQuery()


                        sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name,Cheque_no) VALUES ("
                        sqlsavenecc &= "'" & GMod.Cmpid & "',"
                        sqlsavenecc &= "'" & GMod.username & "',"
                        sqlsavenecc &= "'2',"
                        sqlsavenecc &= "'" & lblvouno1.Text & "',"
                        sqlsavenecc &= "'" & cmbvtype1.Text & "',"
                        sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                        sqlsavenecc &= "'" & cmbbankcode.Text & "',"
                        sqlsavenecc &= "'" & cmbbankHead.Text & "',"
                        sqlsavenecc &= "'0',"
                        sqlsavenecc &= "'" & Val(txtBankamt.Text) & "',"
                        sqlsavenecc &= "'" & narr & "',"
                        sqlsavenecc &= "'" & cmbbankgroup.Text & "',"
                        sqlsavenecc &= "'" & cmbbanksubgroup.Text & "',"
                        sqlsavenecc &= "'" & txtchq.Text & "')"
                        Dim cmd8 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                        cmd8.ExecuteNonQuery()
                    End If
                End If
                trans.Commit()
                MsgBox(cmbvtype.Text & "/" & lblvouno.Text)
                fillgrid()
                ClearControls(Me)
            Catch ex As Exception
                MsgBox(ex.Message)
                trans.Rollback()
            End Try
        Else
            Exit Sub
        End If
    End Sub
    Public Sub fillgrid()
        sql = "select Vou_Type, Vou_no, TdsType, Per, TdsDate, BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt, Actualamt, session,authr from TdsEntry where session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "TdsVal")
        dgTds.DataSource = ds.Tables("TdsVal")
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
    Private Sub dgTds_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTds.DoubleClick
        'Vou_Type, Vou_no, TdsType, Per, TdsDate, BilltyNo, 
        'BilltyDt, VehicleNo, Qty, Prd, Paidamt, Actualamt, Session

        Try
            If dgTds(13, dgTds.CurrentCell.RowIndex).Value <> "-" Then
                btnsave.Enabled = False
                btn_modify.Text = "&Update"
                cmbtdsType.Enabled = False

                cmbvtype.Text = dgTds(0, dgTds.CurrentCell.RowIndex).Value
                lblvouno.Text = dgTds(1, dgTds.CurrentCell.RowIndex).Value
                cmbtdsType.Text = dgTds(2, dgTds.CurrentCell.RowIndex).Value
                dtdate.Value = CDate(dgTds(4, dgTds.CurrentCell.RowIndex).Value)
                txtBilltyNo.Text = dgTds(5, dgTds.CurrentCell.RowIndex).Value
                txtBilltydate.Text = dgTds(6, dgTds.CurrentCell.RowIndex).Value
                txtVhno.Text = dgTds(7, dgTds.CurrentCell.RowIndex).Value
                txtqty.Text = dgTds(8, dgTds.CurrentCell.RowIndex).Value
                txtPrd.Text = dgTds(9, dgTds.CurrentCell.RowIndex).Value
                txtPaidAmt.Text = dgTds(10, dgTds.CurrentCell.RowIndex).Value
                txtActualAmt.Text = dgTds(11, dgTds.CurrentCell.RowIndex).Value


                'for tds head 
                cmbtdsType_Leave(sender, e)

                'For A/c Heads 
                sql = "select * from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "' order by Entry_id"
                GMod.DataSetRet(sql, "tdsdata")
                cmbFrightCode.Text = GMod.ds.Tables("tdsdate").Rows(0)("account_code")
                cmbPartCode.Text = GMod.ds.Tables("tdsdate").Rows(1)("account_code")
            Else
                MsgBox("Can't Modify this voucher no...", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim sqlup As String
    Private Sub btn_modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modify.Click

        If btn_modify.Text = "&Update" Then
            btnsave_Click(sender, e)
            btnsave.Enabled = True
            btn_modify.Text = "&Modify"
            cmbtdsType.Enabled = False
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are u sure", "TDS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Dim trans As SqlTransaction
            trans = GMod.SqlConn.BeginTransaction
            Dim narr As String
            narr = "Being " & txtqty.Text & "," & txtPrd.Text & "," & txtBilltyNo.Text & "," & txtBilltydate.Text & "," & txtVehicleNo1.Text
            Try
                sql = "delete from TdsEntry where vou_type='" & cmbvtype.Text & "' and vou_no='" & lblvouno.Text & " ' and session='" & GMod.Session & "' and cmp_id ='" & GMod.Cmpid & "'"
                Dim cmd1 As New SqlCommand(sql, SqlConn, trans)
                cmd1.ExecuteNonQuery()

                Dim cmd2 As New SqlCommand("delete from " & GMod.VENTRY & " where vou_no='" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'", GMod.SqlConn, trans)
                cmd2.ExecuteNonQuery()
                trans.Commit()

                btnsave.Enabled = True
                btn_modify.Text = "&Modify"
                cmbtdsType.Enabled = False
            Catch EX As Exception
                MsgBox(EX.Message)
                trans.Rollback()
            End Try
        End If
    End Sub

    Private Sub txtPaidAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaidAmt.TextChanged
        txttdsAmount.Text = Math.Ceiling(Val(txtPaidAmt.Text) * (Val(cmbTdsper.Text) / 100))
    End Sub
    Private Sub ChkBankEntry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBankEntry.CheckedChanged
        If ChkBankEntry.Checked = True Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub cmbvtype1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvtype1.Leave
        If cmbvtype1.FindStringExact(cmbvtype1.Text) = -1 Then
            MsgBox("Please select correct voucher", MsgBoxStyle.Critical)
            cmbvtype.Focus()
        Else
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype1.Text & "'"
            'MsgBox(sql)
            GMod.DataSetRet(sql, "vno9")
            lblvouno1.Text = ds.Tables("vno9").Rows(0)(0)
        End If
    End Sub

    Private Sub cmbvtype1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype1.SelectedIndexChanged

        If cmbvtype.FindStringExact(cmbvtype.Text) = -1 Then
            MsgBox("Please select correct voucher", MsgBoxStyle.Critical)
            cmbvtype.Focus()
        Else
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype1.Text & "'"
            'MsgBox(sql)
            GMod.DataSetRet(sql, "vno9")
            lblvouno1.Text = ds.Tables("vno9").Rows(0)(0)
        End If
    End Sub

    Private Sub txtNarration_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNarration.Enter
        If GMod.Cmpid = "PHOE" Then
            txtNarration.Text = "BEING " & txtqty.Text & " " & txtPrd.Text & " FROM " & cmbPartyHead.Text & " AGAINST BILTY NO." & txtBilltyNo.Text & " DT." & txtBilltydate.Text & " VEHICLE NO " & txtVhno.Text & " PAID TO  " & txtPaidTo.Text
        End If
    End Sub

    Private Sub txtNarration_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNarration.Leave
        narr = txtNarration.Text
    End Sub

    Private Sub txtNarration_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNarration.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        frmTdsMultiPleEntry.ShowDialog()
    End Sub

    Private Sub dtdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtdate.Leave
        If btnsave.Enabled = True Then
            GMod.DataSetRet("select isnull(max(vou_date),'" & dtdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvtype.Text & "'", "getMaxDate")
            If dtdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
                MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dtdate.Focus()
            End If
        End If
    End Sub

    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdate.ValueChanged
        'SetLastVouDate()
        GMod.DataSetRet("select getdate()", "serverdate")
        dtdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        dtdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
    End Sub

    Private Sub cmbFreightHead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFreightHead.Leave
        If cmbFreightHead.FindStringExact(cmbFreightHead.Text) = -1 Then
            MsgBox("Please select proper group name", MsgBoxStyle.Critical)
            cmbFreightHead.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub cmbPartyHead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartyHead.Leave
        If cmbPartyHead.FindStringExact(cmbPartyHead.Text) = -1 Then
            MsgBox("Please select proper group name", MsgBoxStyle.Critical)
            cmbPartyHead.Focus()
            Exit Sub
        End If

    End Sub
    Private Sub cmbbankHead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbbankHead.Leave
        If cmbbankHead.FindStringExact(cmbbankHead.Text) = -1 Then
            MsgBox("Please select proper group name", MsgBoxStyle.Critical)
            cmbbankHead.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub cmbPartCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartCode.SelectedIndexChanged
        filltdsparty()
    End Sub
    Sub filltdsparty()
        Try
            Dim i As Integer
            sql = "select * from " & GMod.ACC_HEAD & "   where  cmp_id='" & GMod.Cmpid & "' and  account_code='" & cmbPartCode.Text & "'"

            GMod.DataSetRet(sql, "acc")
            MessageBox.Show(GMod.ds.Tables("acc").Rows(0)("account_head_name") & " # " & GMod.ds.Tables("acc").Rows(0)("credit_days") & "#" & GMod.ds.Tables("acc").Rows(0)("address") & " ," & GMod.ds.Tables("acc").Rows(0)("state") & "#" & GMod.ds.Tables("acc").Rows(0)("pan_no"))
        Catch ex As Exception

        End Try
    End Sub
End Class