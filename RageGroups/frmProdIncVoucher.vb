Imports System.Data.SqlClient
Public Class frmProdincvVoucherDr
    Dim sql As String, sqlname As String
    Dim row As Integer = 0, j As Integer
    ' Dim ConStrSal As String = "Data Source=192.168.0.130;Initial Catalog=PhoenixSalUNOESI;User ID=sa;Password=Ph@hoenix#g"
    Dim ConStrSal As String = "Data Source=117.240.18.180;Initial Catalog=PhoenixSalUNOESI;User ID=sa;Password=Ph@hoenix#g"

    Private Sub frmSalaryBankDr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%sale%'"
        'GMod.DataSetRet(sql, "vt")
        'cmbvtype.DataSource = GMod.ds.Tables("vt")
        'cmbvtype.DisplayMember = "vtype"

        dtdate.Value = GMod.SessionCurrentDate
        dtdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtdate.MaxDate = GMod.SessionCurrentDate

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' AND group_name like  '%EXPENSES%' "
        GMod.DataSetRet(sql, "aclist1")
        cmbFrightCode.DataSource = GMod.ds.Tables("aclist1")
        cmbFrightCode.DisplayMember = "account_code"
        cmbFreightHead.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightHead.DisplayMember = "account_head_name"
        cmbFreightGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightGroup.DisplayMember = "group_name"

        cmbFreightSubGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightSubGroup.DisplayMember = "sub_group_name"

        Dim da1 As New SqlDataAdapter("select distinct orgid from  salacctransfer", ConStrSal)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        cmbDept.DataSource = ds1.Tables(0)
        cmbDept.DisplayMember = "orgid"

        'SESSION CHECK FOR ENTRY 
        'MsgBox(GMod.Getsession(dtvdate.Value))
        If GMod.Getsession(dtdate.Value) = GMod.Session Then
        Else
            ' Me.Close()
        End If
        Rdothr.Checked = True

    End Sub
    Private Sub cmbvtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype.SelectedIndexChanged
        Try
            If cmbvtype.FindStringExact(cmbvtype.Text) = -1 Then
                MsgBox("Please select correct voucher", MsgBoxStyle.Critical)
                cmbvtype.Focus()
            Else
                'sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "'"
                'MsgBox(sql)
                'GMod.DataSetRet(sql, "vno8")
                'lblvouno.Text = ds.Tables("vno8").Rows(0)(0)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Dim cr As Double
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        dgvoucher.Rows.Clear()
        Dim da As SqlDataAdapter
        Dim dsSal As New DataSet
        Try
            If ComboBox1.Text = "CASH" Then
                If cmbDept.Text = "Phoenix Poultry" Then
                    sql = "select empid,name,department,da tt from  salacctransfer " _
                    & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and da>0 AND paymode='" & ComboBox1.Text & "'  order by department,empid"
                Else
                    sql = "select empid,name,department,oa2+oa1-(secudep-oa1) tt from  salacctransfer " _
                    & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and oa2>0 AND paymode='" & ComboBox1.Text & "'  order by department,empid"
                End If
            Else
                If ComboBox1.Text = "CASH" Then
                    sql = "select empid,name,department,oa2+oa1-(secudep-oa1) tt from  salacctransfer " _
                    & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and oa2>0 AND paymode='" & ComboBox1.Text & "' order by department,empid"

                    ' sql = "select empid,name,department,da tt from  View_1 " _
                    '& " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and oa1>0 AND paymode='" & ComboBox1.Text & "'  and left(accountno,3)='" & ComboBox2.Text & "'  order by department,empid"
                Else

                    sql = "select empid,name,department,oa2+oa1-(secudep-oa1) tt from  View_1 " _
                   & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and oa2>0 AND paymode='" & ComboBox1.Text & "'  order by department,empid"

                End If
            End If
            If ComboBox1.Text = "BANK" Then
                If cmbDept.Text = "Phoenix Poultry" Then
                    sql = "select empid,name,department,oa2+oa1-(secudep-oa1) tt from  salacctransfer " _
                                     & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and oa2>0 AND paymode='" & ComboBox1.Text & "' order by department,empid"
                End If
                If cmbDept.Text = "PHOENIX POULTRY (HO)" Then
                    sql = "select empid,name,department,oa2+oa1-(secudep-oa1) tt from  salacctransfer " _
                                     & " where orgid='" & cmbDept.Text & "' and salmonth='" & dtSalaryDate.Text & "' and oa2>0 AND paymode='" & ComboBox1.Text & "'  order by department,empid"
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
                dgvoucher(3, row).Value = "0.00"
                dgvoucher(4, row).Value = dsSal.Tables("indacc").Rows(j)("tt")
                dgvoucher(5, row).Value = GMod.ds.Tables("empaccname").Rows(0)("group_name")
                dgvoucher(6, row).Value = GMod.ds.Tables("empaccname").Rows(0)("sub_group_name")
                'dgvoucher(6, row).Value = "BEING SALARY FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                row = row + 1
                cr = cr + Val(dsSal.Tables("indacc").Rows(j)("tt"))
            Next
        Catch ex As Exception
            MsgBox("ADMIN " & ex.Message)
        End Try
        txtnarr.Text = ""
        txtDr.Text = cr
        j = 0
        row = 0
        cr = 0
    End Sub
    Dim k As Integer
    Dim sqlsavenecc As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Are U sure", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim sql As String
            Try
                sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & cmbvtype.Text & "'"
                GMod.DataSetRet(sql, "vnosalded")
                lblvouno.Text = ds.Tables("vnosalded").Rows(0)(0)
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
                    & " Narration, Group_name, Sub_group_name,Cheque_no,pay_mode) VALUES ("
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
                    sqlsavenecc &= "'" & txtChqNo.Text & "',"
                    sqlsavenecc &= "'-')"

                    Dim cmd3 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                    cmd3.ExecuteNonQuery()
                Next
                sqlsavenecc = " insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                & " Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                & " Narration, Group_name, Sub_group_name,Cheque_no,pay_mode) VALUES ("
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
                sqlsavenecc &= "'" & txtChqNo.Text & "',"
                sqlsavenecc &= "'-')"
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
    End Sub
    Private Sub cmbFreightHead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFreightHead.Leave
        cmbFreightHead.Enabled = False
    End Sub

    Private Sub lblvouno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lblvouno.KeyPress
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdate.ValueChanged
        GMod.DataSetRet("select isnull(max(vou_date),'" & dtdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvtype.Text & "'", "getMaxDate")
        If dtdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
            MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            dtdate.Focus()
        End If
    End Sub
End Class