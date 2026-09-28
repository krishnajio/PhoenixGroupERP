Imports System.Data.SqlClient

Public Class frmStaffSalaryTranferToAcc

    Private Sub frmStaffSalaryTranferToAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select getdate()", "serverdate")

        'dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        'dtVoucherDate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)


        'dgvoucher.Rows.Add()
        If cmbvtype.Enabled = False Then
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype in ('SALARY JOURNAL','SALARY EXPS')  and session = '" & GMod.Session & "' order by seqorder", "vty")
        Else
            ' GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype NOT in ('PAYMENT','OPEN') order by seqorder", "vty")
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype in ('SALARY JOURNAL','SALARY EXPS')  and session = '" & GMod.Session & "' order by seqorder", "vty")

        End If
        cmbvtype.DataSource = GMod.ds.Tables("vty")
        cmbvtype.DisplayMember = "vtype"

        'SESSION CHECK FOR ENTRY 
        'MsgBox(GMod.Getsession(dtvdate.Value))
        If GMod.Getsession(dtVoucherDate.Value) = GMod.Session Then
        Else
            ' Me.Close()
        End If
        ' Dim ConStrSal As String = "Data Source=192.168.0.150;Initial Catalog=PHXSAL;User ID=sa;Password=@hplgsamsung#"
        Dim da1 As New SqlDataAdapter("select distinct orgid from  ORGANIZATIONMASTER WHERE cmp_id ='" & GMod.Cmpid & "'", ConStrSal)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        cmborgid.DataSource = ds1.Tables(0)
        cmborgid.DisplayMember = "orgid"
        If GMod.Getsession(dtVoucherDate.Value) = GMod.Session Then
        Else
            'Me.Close()
        End If
    End Sub
    Dim Sql As String
    Dim ConStrSal As String = "Data Source=192.168.0.150;Initial Catalog=PHXSAL;User ID=sa;Password=Ph@hoenix#g"
    Public SqlConntrfsal As New SqlConnection(ConStrSal)
    Dim ds3 As New DataSet
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Try
            Sql = "exec TrafertoAcc '" & cmborgid.Text & "','" & dtSalaryDate.Value.ToShortDateString & "','" & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "'"
            'Dim da1 As New SqlDataAdapter(Sql, ConStrSal)
            'Dim ds2 As New DataSet
            'da1.Fill(ds2)
            Dim sqlcmdtrfsal As New SqlCommand(Sql, SqlConntrfsal)
            sqlcmdtrfsal.CommandTimeout = 3000
            Try
                SqlConntrfsal.Open()
                sqlcmdtrfsal.ExecuteNonQuery()
            Catch ex As Exception
                SqlConntrfsal.Close()
                MsgBox(ex.Message)
            End Try
            SqlConntrfsal.Close()
            sqlcmdtrfsal.Dispose()

            Sql = "select * from TRNASTOACC order by entry_id"
            Dim da2 As New SqlDataAdapter(Sql, ConStrSal)

            da2.Fill(ds3, "saltrftoacc")
            dgStaffsaalry.DataSource = ds3.Tables("saltrftoacc")


            Sql = "select sum(dramt),sum(cramt) from TRNASTOACC "
            Dim da3 As New SqlDataAdapter(Sql, ConStrSal)
            da3.Fill(ds3, "saldrcr")
            lbldr.Text = ds3.Tables("saldrcr").Rows(0)(0)
            lblcr.Text = ds3.Tables("saldrcr").Rows(0)(1)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(lbldr.Text) = Val(lblcr.Text) Then
            Dim sqlsave As String, i As Integer
            Try
                sqlsave = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & cmbvtype.Text & "'"
                GMod.DataSetRet(sqlsave, "vnosal_acc_transfer")
                lblvouno.Text = ds.Tables("vnosal_acc_transfer").Rows(0)(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.Close()
            End Try

            'Try
            '    Sql = " insert into  [192.168.0.130,3759].[PhxGroupERP].dbo.[" & GMod.VENTRY & "]"
            '    Sql &= "(Cmp_id,Uname,Entry_id,Vou_no,Vou_type,Vou_date,Acc_head_code,Acc_head,dramt,cramt,Narration,Cheque_no,Group_name,Sub_group_name) "
            '    Sql &= " select '" & GMod.Cmpid & "','" & GMod.username & "',entry_id,'" & lblvouno.Text & "','" & cmbvtype.Text & "', '" & dtVoucherDate.Value.ToShortDateString & "', empid,empname,dramt,cramt,narration,"
            '    Sql &= " '-','-','-'  from TRNASTOACC order by entry_id"

            '    Dim da3 As New SqlDataAdapter(Sql, ConStrSal)
            '    da3.Fill(ds3, "savesaltoacc")

            '    If GMod.Cmpid = "PHOE" Then
            '        GMod.SqlExecuteNonQuery("update  v_UpdateStaffHeadd set Acc_head = account_head_name , vgrp = group_name , vsgrp = sub_group_name where vou_no = '" & lblvouno.Text & "' ")
            '    Else
            '        GMod.SqlExecuteNonQuery("update  v_UpdateStaffHeadd_hatchery set Acc_head = account_head_name , vgrp = group_name , vsgrp = sub_group_name where vou_no = '" & lblvouno.Text & "' ")
            '    End If

            '    dgStaffsaalry.DataSource = vbNull
            '    MessageBox.Show("Data Save sussefully Voucher " & lblvouno.Text)
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try


            Dim conDest As New SqlConnection(GMod.Connstr)
            Dim trans As SqlTransaction = Nothing
            Try
                conDest.Open()
                trans = conDest.BeginTransaction()

                ' 🔥 SQL with string concatenation
                Dim SqlInsert As String = ""
                SqlInsert = "INSERT INTO " & GMod.VENTRY & " "
                SqlInsert &= "(Cmp_id,Uname,Entry_id,Vou_no,Vou_type,Vou_date, "
                SqlInsert &= "Acc_head_code,Acc_head,dramt,cramt,Narration, "
                SqlInsert &= "Cheque_no,Group_name,Sub_group_name) "
                SqlInsert &= "VALUES ("
                SqlInsert &= "@Cmp_id,@Uname,@Entry_id,@Vou_no,@Vou_type,@Vou_date,"
                SqlInsert &= "@Acc_head_code,@Acc_head,@dramt,@cramt,@Narration,"
                SqlInsert &= "@Cheque_no,@Group_name,@Sub_group_name"
                SqlInsert &= ")"

                Dim cmd As New SqlCommand(SqlInsert, conDest, trans)

                ' ✅ Add parameters once
                cmd.Parameters.Add("@Cmp_id", SqlDbType.VarChar)
                cmd.Parameters.Add("@Uname", SqlDbType.VarChar)
                cmd.Parameters.Add("@Entry_id", SqlDbType.Int)
                cmd.Parameters.Add("@Vou_no", SqlDbType.VarChar)
                cmd.Parameters.Add("@Vou_type", SqlDbType.VarChar)
                cmd.Parameters.Add("@Vou_date", SqlDbType.Date)

                cmd.Parameters.Add("@Acc_head_code", SqlDbType.VarChar)
                cmd.Parameters.Add("@Acc_head", SqlDbType.VarChar)

                cmd.Parameters.Add("@dramt", SqlDbType.Decimal).Precision = 18
                cmd.Parameters("@dramt").Scale = 2

                cmd.Parameters.Add("@cramt", SqlDbType.Decimal).Precision = 18
                cmd.Parameters("@cramt").Scale = 2

                cmd.Parameters.Add("@Narration", SqlDbType.VarChar)
                cmd.Parameters.Add("@Cheque_no", SqlDbType.VarChar)
                cmd.Parameters.Add("@Group_name", SqlDbType.VarChar)
                cmd.Parameters.Add("@Sub_group_name", SqlDbType.VarChar)

                ' 🔁 Loop DataGridView
                For Each dgRow As DataGridViewRow In dgStaffsaalry.Rows

                    ' Skip empty row
                    If dgRow.IsNewRow Then Continue For

                    cmd.Parameters("@Cmp_id").Value = GMod.Cmpid
                    cmd.Parameters("@Uname").Value = GMod.username
                    cmd.Parameters("@Entry_id").Value = dgRow.Cells("entry_id").Value
                    cmd.Parameters("@Vou_no").Value = lblvouno.Text
                    cmd.Parameters("@Vou_type").Value = cmbvtype.Text
                    cmd.Parameters("@Vou_date").Value = dtVoucherDate.Value

                    cmd.Parameters("@Acc_head_code").Value = dgRow.Cells("empid").Value
                    cmd.Parameters("@Acc_head").Value = dgRow.Cells("empname").Value

                    cmd.Parameters("@dramt").Value = Val(dgRow.Cells("dramt").Value)
                    cmd.Parameters("@cramt").Value = Val(dgRow.Cells("cramt").Value)

                    cmd.Parameters("@Narration").Value = dgRow.Cells("narration").Value

                    cmd.Parameters("@Cheque_no").Value = "-"
                    cmd.Parameters("@Group_name").Value = "-"
                    cmd.Parameters("@Sub_group_name").Value = "-"

                    cmd.ExecuteNonQuery()

                Next
                ' ✅ Commit
                trans.Commit()
                dgStaffsaalry.DataSource = vbNull
                MessageBox.Show("✅ Data transferred successfully. Voucher: " & lblvouno.Text)
            Catch ex As Exception
                conDest.Close()
                conDest.Dispose()
                ' ❌ Rollback
                If trans IsNot Nothing Then
                    Try
                        trans.Rollback()
                    Catch
                    End Try
                End If
                MessageBox.Show("❌ Error: " & ex.Message)
            Finally
                conDest.Close()
                conDest.Dispose()
            End Try
        End If
    End Sub
End Class