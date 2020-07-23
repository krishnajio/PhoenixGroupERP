Imports System.Data.SqlClient
Public Class frmRevSale

    Private Sub frmRevSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'reverse sale for 
        dtvdate.Focus()
        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype NOT in ('PAYMENT','RECEIPT') order by seqorder", "vty")
        cmbvtype.DataSource = GMod.ds.Tables("vty")
        cmbvtype.DisplayMember = "vtype"
        fillArea()
        cmbvtype.Text = "A-SALE"
        fillacclist()
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
    End Sub
    Sub fillacclist()
        Dim Sqlacc As String
        Sqlacc = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(Sqlacc, "aclist1")
        GMod.DataSetRet(Sqlacc, "aclist2")
        cmbacheadcodedr.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcodedr.DisplayMember = "account_code"
        cmbacheadnamedr.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadnamedr.DisplayMember = "account_head_name"

        cmbheadcr.DataSource = GMod.ds.Tables("aclist2")
        cmbheadcr.DisplayMember = "account_head_name"
        cmbcodecr.DataSource = GMod.ds.Tables("aclist2")
        cmbcodecr.DisplayMember = "account_code"


    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Try
            Dim sqlshow As String, i As Integer
            sqlshow = "select Vou_no,Vou_date,Acc_head_code ,Acc_head,Narration,cramt,dramt  from " & GMod.VENTRY _
                       & " where vou_type='SALE' " _
                       & " and Entry_id < 3  and vou_no >=" & Val(txtCrNoFrom.Text) & " and vou_no<=" & Val(txtCrNoTo.Text) & " order by cast(vou_no as numeric(18,0))  "
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
                dgCRDebit(5, i).Value = GMod.ds.Tables("CRData").Rows(i)("dramt")
                dgCRDebit(6, i).Value = GMod.ds.Tables("CRData").Rows(i)("cramt")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtnrevrse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtnrevrse.Click
        Dim eid As Integer = 0
        If dgCRDebit.Rows.Count = 0 Then
            MsgBox("Please Select vouchers's")
            txtCrNoFrom.Focus()
            Exit Sub
        End If
        Dim z As Integer
        Dim sqlsavedr, sqlsavecr, sqldel As String
        Dim sqltrans As SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction
        Try
            sqldel = "delete from " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "' and vou_no between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text
            Dim cmd1 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
            cmd1.ExecuteNonQuery()


            For z = 0 To dgCRDebit.Rows.Count - 1 Step 2
                'For Dr Entry 
                'If Val(dgCRDebit(5, z).Value) > 0 Then
                sqlsavedr = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                sqlsavedr += "acc_head_code,Acc_head, cramt, dramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                sqlsavedr += ") values( "
                sqlsavedr += "'" & GMod.Cmpid & "','" & GMod.username & "'," & eid & ",'" & dgCRDebit(0, z).Value & "',"
                sqlsavedr += "'" & cmbvtype.Text & "','" & dgCRDebit(1, z).Value & "','" & cmbacheadcodedr.Text & "','" & cmbacheadnamedr.Text & "'," & dgCRDebit(6, z).Value & "," & dgCRDebit(5, z).Value & ","
                sqlsavedr += "'-','-','" & dgCRDebit(4, z).Value & "','" & cmbacgroupdr.Text & "',"
                sqlsavedr += "'" & cmbacsubgroupdr.Text & "')"
                'MsgBox(sqlsavedr)
                Dim cmd0 As New SqlCommand(sqlsavedr, GMod.SqlConn, sqltrans)
                cmd0.ExecuteNonQuery()

                sqlsavecr = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                sqlsavecr += "acc_head_code,Acc_head, cramt, dramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
                sqlsavecr += ") values( "
                sqlsavecr += "'" & GMod.Cmpid & "','" & GMod.username & "'," & eid + 1 & ",'" & dgCRDebit(0, z + 1).Value & "',"
                sqlsavecr += "'" & cmbvtype.Text & "','" & dgCRDebit(1, z + 1).Value & "','" & cmbcodecr.Text & "','" & cmbheadcr.Text & "'," & dgCRDebit(6, z + 1).Value & "," & dgCRDebit(5, z + 1).Value & ","
                sqlsavecr += "'-','-','" & dgCRDebit(4, z + 1).Value & "','" & grpcr.Text & "',"
                sqlsavecr += "'" & sgrpcr.Text & "')"
                ' MsgBox(sqlsavecr)
                Dim cmd2 As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltrans)
                cmd2.ExecuteNonQuery()
                ' End If
                eid = eid + 1
            Next
            'For z = 0 To dgCRDebit.Rows.Count - 1
            '    'For Dr Entry 
            '    If Val(dgCRDebit(6, z).Value) > 0 Then
            '        'For Cr Entry 
            '        sqlsavecr = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
            '        sqlsavecr += "acc_head_code,Acc_head, cramt, dramt,Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name"
            '        sqlsavecr += ") values( "
            '        sqlsavecr += "'" & GMod.Cmpid & "','" & GMod.username & "'," & Val(dgCRDebit(0, z).Value) & ",'" & dgCRDebit(0, z).Value & "',"
            '        sqlsavecr += "'" & cmbvtype.Text & "','" & dgCRDebit(1, z).Value & "','" & cmbcodecr.Text & "','" & cmbheadcr.Text & "'," & dgCRDebit(6, z).Value & "," & dgCRDebit(5, z).Value & ","
            '        sqlsavecr += "'-','-','" & dgCRDebit(4, z).Value & "','" & grpcr.Text & "',"
            '        sqlsavecr += "'" & sgrpcr.Text & "')"
            '        MsgBox(sqlsavecr)
            '        Dim cmd2 As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltrans)
            '        cmd2.ExecuteNonQuery()
            '    End If
            'Next
            sqltrans.Commit()
            MsgBox("Reverse Entry Saved", MsgBoxStyle.Information)
            dgCRDebit.Rows.Clear()
            txtCrNoFrom.Text = ""
            txtCrNoTo.Text = ""
            txtCrNoFrom.Focus()
        Catch ex As Exception
            sqltrans.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbacheadcodedr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcodedr.SelectedIndexChanged
        Try
            If cmbacheadcodedr.Text <> "" Then
                Dim sql As String
                sql = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code='" & cmbacheadcodedr.Text & "'"
                GMod.DataSetRet(sql, "sub_grp")
                cmbacgroupdr.Text = GMod.ds.Tables("sub_grp").Rows(0)(0)
                cmbacsubgroupdr.Text = GMod.ds.Tables("sub_grp").Rows(0)(1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbcodecr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcodecr.SelectedIndexChanged
        Try
            If cmbcodecr.Text <> "" Then
                Dim sql As String
                sql = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code='" & cmbcodecr.Text & "'"
                GMod.DataSetRet(sql, "sub_grp1")
                grpcr.Text = GMod.ds.Tables("sub_grp1").Rows(0)(0)
                sgrpcr.Text = GMod.ds.Tables("sub_grp1").Rows(0)(1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As String
        r = InputBox("Enter the voucher No to be deleted")
        If r <> "" Then
            Dim sql As String
            sql = "delete  from " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "' and vou_no='" & r & "'"
            MsgBox(GMod.SqlExecuteNonQuery(sql) & "-- Voucher Deleted")
        End If
    End Sub
End Class