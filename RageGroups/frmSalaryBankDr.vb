Imports System.Data.SqlClient
Public Class frmSalaryBankDr
    Dim sql As String, sqlname As String
    Dim row As Integer = 0, j As Integer
    Dim ConStrSal As String = "Data Source=192.168.0.130;Initial Catalog=PhoenixSALUNOESI;User ID=sa;Password=ph@hoenix#g"

    Private Sub frmSalaryBankDr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GMod.DataSetRet("select getdate()", "serverdate")
        dtdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

        If GMod.Getsession(dtdate.Value) = GMod.Session Then
        Else
            'Me.Close()
        End If


        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vtype in ('BANK SAL TRANSFER','SALARY EXPS')"
        GMod.DataSetRet(sql, "vtbst")
        cmbvtype.DataSource = GMod.ds.Tables("vtbst")
        cmbvtype.DisplayMember = "vtype"

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' AND group_name in ('BANK','IMPREST','BANK JOURNAL')"
        GMod.DataSetRet(sql, "aclist1")
        cmbFrightCode.DataSource = GMod.ds.Tables("aclist1")
        cmbFrightCode.DisplayMember = "account_code"
        cmbFreightHead.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightHead.DisplayMember = "account_head_name"
        cmbFreightGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightGroup.DisplayMember = "group_name"

        cmbFreightSubGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightSubGroup.DisplayMember = "sub_group_name"
        Dim ds1 As New DataSet
        Dim q As String
        If CheckBox1.Checked = False Then
            If GMod.Dept = 99 And GMod.role = "VIEWER LEVEL-1" Then
                q = "select distinct orgid from  salacctransfer " 'where orgid in('Phoenix Poultry','APF CASUAL')"
            ElseIf GMod.Dept = 99 Then
                q = "select distinct orgid from  salacctransfer where orgid not in('Phoenix Poultry','Phoenix Hatcheries')"
            End If
        Else
            q = "select distinct orgid from  novsal"
        End If

        If GMod.Cmpid = "PHHA" And GMod.Dept = 99 Then
            q = "select distinct orgid from  salacctransfer where orgid in ('Phoenix Hatcheries')"
        End If
        ' q = "select distinct orgid from  salacctransfer where orgid in('Phoenix Poultry','APF CASUAL')"

            Dim da1 As New SqlDataAdapter(q, ConStrSal)

            da1.Fill(ds1)
            cmbDept.DataSource = ds1.Tables(0)
            cmbDept.DisplayMember = "orgid"

            If GMod.Getsession(dtdate.Value) = GMod.Session Then

            Else
            ' Me.Close()
        End If
        Rdothr.Checked = True
    End Sub

    Private Sub cmbvtype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvtype.Leave
        Try
            If cmbvtype.FindStringExact(cmbvtype.Text) = -1 Then
                MsgBox("Please select correct voucher", MsgBoxStyle.Critical)
                cmbvtype.Focus()
            Else
                sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "'"
                'MsgBox(sql)
                GMod.DataSetRet(sql, "vno8")
                lblvouno.Text = ds.Tables("vno8").Rows(0)(0)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmbvtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype.SelectedIndexChanged
        
    End Sub
    Dim cr As Double
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        dgvoucher.Rows.Clear()
        Dim da As SqlDataAdapter
        Dim dsSal As New DataSet
        Try

            If CheckBox1.Checked = False Then
                If ComboBox1.Text = "CASH" Then
                    sql = "select empid,name,department,(amtpay+ da+ hra+ cca+ oa1+ oa2  + amt833 + amt367) - (it+proftax+collegeloan+groupinsded+od1+secudep)-2*(amt833 + amt367) tt from  salacctransfer " _
                    & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and amtpay+hra+cca+oa2+oa1+da>0 AND paymode='" & ComboBox1.Text & "' order by [name]"
                Else
                    sql = "select empid,name,department,(amtpay+ da+ hra+ cca+ oa1+ oa2 + amt833 + amt367) - (it+proftax+collegeloan+groupinsded+od1+secudep)-2*(amt833 + amt367) tt from  View_1 " _
                    & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and amtpay+hra+cca+oa2+oa1+da>0 AND paymode='" & ComboBox1.Text & "'  and left(accountno,3)='" & ComboBox2.Text & "' order by [name]"
                End If
            Else
                If ComboBox1.Text = "CASH" Then
                    sql = "select empid,name,department,(amtpay+ da+ hra+ cca+ oa1+ oa2 +  amt833 + amt367) - (it+proftax+collegeloan+groupinsded+od1+secudep)-2*(amt833 + amt367) tt from  novsal " _
                    & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and amtpay+hra+cca+oa2+oa1+da>0 AND paymode='" & ComboBox1.Text & "' and  is_ho_emp = '" & RdHO.Checked.ToString & "' order by department,empid"
                Else
                    sql = "select empid,name,department,(amtpay+ da+ hra+ cca+ oa1+ oa2 + amt833 + amt367) - (it+proftax+collegeloan+groupinsded+od1+secudep)-2*(amt833 + amt367) tt from  novsal " _
                    & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and amtpay+hra+cca+oa2+oa1+da>0 AND paymode='" & ComboBox1.Text & "'  and left(accountno,3)='" & ComboBox2.Text & "' and  order by [name]"
                End If
            End If
            'sql = "select empid,name,department,(amtpay+ da+ hra+ cca+ oa1+ oa2  + amt833 + amt367) - (it+proftax+collegeloan+groupinsded)-2*(amt833 + amt367) tt from  novsal " _
            '    & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and amtpay+hra+cca+oa2+oa1>0 AND paymode='" & ComboBox1.Text & "' order by department,empid"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "indacc")
            For j = 0 To dsSal.Tables("indacc").Rows.Count - 1
                'Getting Name of w.t to code    
                sqlname = "select  account_head_name,group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code='" & dsSal.Tables("indacc").Rows(j)("empid").ToString & "'"
                GMod.DataSetRet(sqlname, "empaccname")
                dgvoucher.Rows.Add()
                dgvoucher(0, row).Value = row
                dgvoucher(1, row).Value = dsSal.Tables("indacc").Rows(j)("empid")
                dgvoucher(2, row).Value = GMod.ds.Tables("empaccname").Rows(0)("account_head_name")
                dgvoucher(3, row).Value = dsSal.Tables("indacc").Rows(j)("tt")
                dgvoucher(4, row).Value = "0.00"
                dgvoucher(5, row).Value = GMod.ds.Tables("empaccname").Rows(0)("group_name")
                dgvoucher(6, row).Value = GMod.ds.Tables("empaccname").Rows(0)("sub_group_name")
                'dgvoucher(6, row).Value = "BEING SALARY FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                row = row + 1
                cr = cr + Val(dsSal.Tables("indacc").Rows(j)("tt"))
            Next
        Catch ex As Exception
            MsgBox("ADMIN " & ex.Message)
        End Try
        txtnarr.Text = "BEING AMT CHQ PAID AS SALARY FOR THE MONTH "
        txtCr.Text = cr
    End Sub
    Dim k As Integer = 0
    Dim sqlsavenecc As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbvtype.Text = "BANK" Then
            sql = "select * from dummy_VENTRY where Posted='N' and cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'"
            GMod.DataSetRet(sql, "chkforpost")
            If GMod.ds.Tables("chkforpost").Rows.Count > 0 Then
                MsgBox("Please post bank voucher", MsgBoxStyle.Information)
                cmbvtype.Focus()
                Exit Sub
            End If
        End If

        If MessageBox.Show("Are U sure", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & cmbvtype.Text & "'"
                GMod.DataSetRet(sql, "vnosalbanktransfer")
                lblvouno.Text = ds.Tables("vnosalbanktransfer").Rows(0)(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.Close()
            End Try

            Dim trans As SqlTransaction
            trans = GMod.SqlConn.BeginTransaction
            Try
                For k = 0 To dgvoucher.Rows.Count - 1
                    sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                    & " Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                    & " Narration, Group_name, Sub_group_name,Cheque_no) VALUES ("
                    sqlsavenecc &= "'" & GMod.Cmpid & "',"
                    sqlsavenecc &= "'" & GMod.username & "',"
                    sqlsavenecc &= "'" & k & "',"
                    sqlsavenecc &= "'" & lblvouno.Text & "',"
                    sqlsavenecc &= "'" & cmbvtype.Text & "',"
                    sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                    sqlsavenecc &= "'" & dgvoucher(1, k).Value & "',"
                    sqlsavenecc &= "'" & dgvoucher(2, k).Value & "',"
                    sqlsavenecc &= "'" & Val(dgvoucher(3, k).Value) & "',"
                    sqlsavenecc &= "'" & Val(dgvoucher(4, k).Value) & "',"
                    sqlsavenecc &= "'" & txtnarr.Text & "',"
                    sqlsavenecc &= "'" & dgvoucher(5, k).Value & "',"
                    sqlsavenecc &= "'" & dgvoucher(6, k).Value & "',"
                    sqlsavenecc &= "'" & txtChqNo.Text & "')"

                    Dim cmd3 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                    cmd3.ExecuteNonQuery()
                Next
                sqlsavenecc = " insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                & " Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                & " Narration, Group_name, Sub_group_name,Cheque_no) VALUES ("
                sqlsavenecc &= "'" & GMod.Cmpid & "',"
                sqlsavenecc &= "'" & GMod.username & "',"
                sqlsavenecc &= "'" & k & "',"
                sqlsavenecc &= "'" & lblvouno.Text & "',"
                sqlsavenecc &= "'" & cmbvtype.Text & "',"
                sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                sqlsavenecc &= "'" & cmbFrightCode.Text & "',"
                sqlsavenecc &= "'" & cmbFreightHead.Text & "',"
                sqlsavenecc &= "'" & Val(txtDr.Text) & "',"
                sqlsavenecc &= "'" & Val(txtCr.Text) & "',"
                sqlsavenecc &= "'" & txtnarr.Text & "',"
                sqlsavenecc &= "'" & cmbFreightGroup.Text & "',"
                sqlsavenecc &= "'" & cmbFreightSubGroup.Text & "',"
                sqlsavenecc &= "'" & txtChqNo.Text & "')"
                Dim cmd4 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                cmd4.ExecuteNonQuery()
                trans.Commit()
                MsgBox("Bank entry saved...")
                dgvoucher.Rows.Clear()
                cmbvtype_SelectedIndexChanged(sender, e)
            Catch ex As Exception
                trans.Rollback()
                MsgBox(ex.Message)
            End Try
        End If
        Button1.Enabled = False
    End Sub
    Private Sub cmbFreightHead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFreightHead.Leave
        cmbFreightHead.Enabled = False
    End Sub
    Private Sub dgvoucher_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvoucher.RowsRemoved
        Try
            cr = 0
            For j = 0 To dgvoucher.Rows.Count - 1
                'Getting Name of w.t to code    
                cr = cr + Val(dgvoucher(3, j).Value)
            Next
            txtCr.Text = cr
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtdate.Leave
        GMod.DataSetRet("select isnull(max(vou_date),'" & dtdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvtype.Text & "'", "getMaxDate")
        If dtdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
            MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            dtdate.Focus()
        End If
    End Sub

    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdate.ValueChanged
        Try
            '---- Resting date to server date 
            GMod.DataSetRet("select getdate()", "serverdate")
            dtdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
            dtdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim ds1 As New DataSet
        Dim q As String
        If CheckBox1.Checked = False Then
            q = "select distinct orgid from  salacctransfer"
        Else
            q = "select distinct orgid from  novsal"
        End If
        Dim da1 As New SqlDataAdapter(q, ConStrSal)

        da1.Fill(ds1)
        cmbDept.DataSource = ds1.Tables(0)
        cmbDept.DisplayMember = "orgid"

    End Sub

    Private Sub txtnarr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnarr.KeyPress
        e.Handled = True
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

   
End Class