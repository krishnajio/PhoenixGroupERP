'Imports Microsoft.Office.Interop.Excel
'Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Public Class frmBonusDebitFrmXls

    Private Sub frmBonusFrmXls_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GMod.DataSetRet("select getdate()", "serverdate")

        'dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        dtVoucherDate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

        'dgvoucher.Rows.Add()
        If cmbvtype.Enabled = False Then
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype<>'OPEN' order by seqorder", "vty")
        Else
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype NOT in ('PAYMENT','OPEN') order by seqorder", "vty")
        End If

        cmbvtype.DataSource = GMod.ds.Tables("vty")
        cmbvtype.DisplayMember = "vtype"



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Are u Sure?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' If Val(dr.Text) = Val(cr.Text) Then
            Dim sqlsave As String, i As Integer

            Try
                sqlsave = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & cmbvtype.Text & "'"
                GMod.DataSetRet(sqlsave, "vnosal_acc_transfer_casual")
                lblvouno.Text = ds.Tables("vnosal_acc_transfer_casual").Rows(0)(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.Close()
            End Try
            Dim trans As SqlTransaction
            trans = GMod.SqlConn.BeginTransaction
            Try
                For i = 0 To dgvoucher.Rows.Count - 1
                    'If Val(dgvoucher(4, i).Value) <> 0 And Val(dgvoucher(5, i).Value) <> 0 Then
                    sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                    sqlsave &= "acc_head_code,Acc_head, dramt, cramt,Narration, Group_name, Sub_group_name"
                    sqlsave &= ") values( "
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'" & Val(dgvoucher(0, i).Value) & "',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & cmbvtype.Text & "',"
                    sqlsave &= "'" & dtVoucherDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & dgvoucher(1, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(2, i).Value & "',"
                    sqlsave &= "'" & Val(dgvoucher(4, i).Value) & "',"
                    sqlsave &= "'" & Val(dgvoucher(5, i).Value) & "',"
                    sqlsave &= "'" & dgvoucher(3, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(6, i).Value & "',"
                    sqlsave &= "'-')"
                    ' MsgBox(sqlsave)
                    Dim cmd As New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                    'End If
                Next
                trans.Commit()
                dgvoucher.Rows.Clear()
                MsgBox(lblvouno.Text & "/" & cmbvtype.Text)
            Catch ex As Exception
                trans.Rollback()
                MsgBox(ex.Message)
            End Try
            'Else
            'dr.BackColor = Color.Red
            ' cr.BackColor = Color.Red
            MsgBox("Dr<>Cr")
            ' End If
        End If
    End Sub
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim i As Integer
        Dim sql As String = ""
        Dim drv, crv As Double
        Try
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim DtSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            MyConnection = New System.Data.OleDb.OleDbConnection _
            ("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & path & "';Extended Properties=Excel 8.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                ("select * from [XLSFILE$]", MyConnection)
            MyCommand.TableMappings.Add("Table", "TestTable")
            DtSet = New System.Data.DataSet
            MyCommand.Fill(DtSet)
            dgvoucher.Rows.Add()
            dgvoucher(1, 0).Value = DtSet.Tables(0).Rows(0)(1).ToString.Trim
            sql = "select account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & DtSet.Tables(0).Rows(0)(1).ToString.Trim & "' "
            GMod.DataSetRet(sql, "bonushead")
            dgvoucher(0, 0).Value = i.ToString

            dgvoucher(2, 0).Value = GMod.ds.Tables("bonushead").Rows(0)("account_head_name")
            dgvoucher(6, 0).Value = GMod.ds.Tables("bonushead").Rows(0)("group_name")

            dgvoucher(3, 0).Value = DtSet.Tables(0).Rows(0)(5).ToString.Trim
            dgvoucher(4, 0).Value = DtSet.Tables(0).Rows(0)(3).ToString.Trim
            dgvoucher(5, 0).Value = DtSet.Tables(0).Rows(0)(4).ToString.Trim


            For i = 0 To DtSet.Tables(0).Rows.Count
                If DtSet.Tables(0).Rows(i)(1).ToString.Length > 0 Then
                    dgvoucher.Rows.Add()
                    dgvoucher(1, i).Value = DtSet.Tables(0).Rows(i)(1).ToString.Trim
                    sql = "select account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & DtSet.Tables(0).Rows(i)(1).ToString.Trim & "' "
                    GMod.DataSetRet(sql, "bonushead")
                    dgvoucher(0, i).Value = i.ToString

                    dgvoucher(2, i).Value = GMod.ds.Tables("bonushead").Rows(0)("account_head_name")
                    dgvoucher(6, i).Value = GMod.ds.Tables("bonushead").Rows(0)("group_name")

                    dgvoucher(3, i).Value = DtSet.Tables(0).Rows(i)(5).ToString.Trim
                    dgvoucher(4, i).Value = DtSet.Tables(0).Rows(i)(4).ToString.Trim
                    dgvoucher(5, i).Value = DtSet.Tables(0).Rows(i)(3).ToString.Trim
                Else
                    Exit For
                End If
            Next
            'dgvoucher.DataSource = DtSet.Tables(0)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        For i = 0 To dgvoucher.RowCount - 1
            drv = drv + Val(dgvoucher(4, i).Value)
            crv = crv + Val(dgvoucher(5, i).Value)
        Next

        dr.Text = drv.ToString
        cr.Text = crv.ToString
    End Sub
    Dim path As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        od.ShowDialog()
        path = od.FileName
    End Sub
End Class