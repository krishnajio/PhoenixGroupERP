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
        Dim da1 As New SqlDataAdapter("select distinct orgid from  ORGANIZATIONMASTER", ConStrSal)
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
    Dim ds3 As New DataSet
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Try

       
        Sql = "exec TrafertoAcc '" & cmborgid.Text & "','" & dtSalaryDate.Value.ToShortDateString & "','" & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "'"
        Dim da1 As New SqlDataAdapter(Sql, ConStrSal)
        Dim ds2 As New DataSet
        da1.Fill(ds2)

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

            Try
                Sql = " insert into  [192.168.0.130].[PhxGroupERP].dbo.[" & GMod.VENTRY & "]"
                Sql &= "(Cmp_id,Uname,Entry_id,Vou_no,Vou_type,Vou_date,Acc_head_code,Acc_head,dramt,cramt,Narration,Cheque_no,Group_name,Sub_group_name) "
                Sql &= " select '" & GMod.Cmpid & "','" & GMod.username & "',entry_id,'" & lblvouno.Text & "','" & cmbvtype.Text & "', '" & dtVoucherDate.Value.ToShortDateString & "', empid,empname,dramt,cramt,narration,"
                Sql &= " '-','-','-'  from TRNASTOACC order by entry_id"

            Dim da3 As New SqlDataAdapter(Sql, ConStrSal)
                da3.Fill(ds3, "savesaltoacc")

                If GMod.Cmpid = "PHOE" Then
                    GMod.SqlExecuteNonQuery("update  v_UpdateStaffHeadd set Acc_head = account_head_name , vgrp = group_name , vsgrp = sub_group_name where vou_no = '" & lblvouno.Text & "' ")
                Else
                    GMod.SqlExecuteNonQuery("update  v_UpdateStaffHeadd_hatchery set Acc_head = account_head_name , vgrp = group_name , vsgrp = sub_group_name where vou_no = '" & lblvouno.Text & "' ")

                End If

                dgStaffsaalry.DataSource = vbNull
                MessageBox.Show("Data Save sussefully Voucher " & lblvouno.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class