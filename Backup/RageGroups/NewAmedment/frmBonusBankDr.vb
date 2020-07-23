Imports System.Data.SqlClient
Public Class frmBonusBankDr

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Dim q As String
    Dim sql As String, sqlname As String
    Dim row As Integer = 0, j As Integer
    Dim cr As Double
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        q = "select * from " & GMod.VENTRY & " where vou_type= '" & cmbvtype.Text & "'  and vou_no='" & lblvouno.Text & "'"
        GMod.DataSetRet(q, "bonusbankdr")
        For j = 0 To GMod.ds.Tables("bonusbankdr").Rows.Count - 1
            dgvoucher.Rows.Add()
            dgvoucher(0, row).Value = row
            dgvoucher(1, row).Value = ds.Tables("bonusbankdr").Rows(j)("Acc_head_code")
            dgvoucher(2, row).Value = ds.Tables("bonusbankdr").Rows(j)("Acc_head")
            dgvoucher(3, row).Value = ds.Tables("bonusbankdr").Rows(j)("cramt")
            dgvoucher(4, row).Value = "0.00"
            dgvoucher(5, row).Value = ds.Tables("bonusbankdr").Rows(j)("group_name")
            dgvoucher(6, row).Value = ds.Tables("bonusbankdr").Rows(j)("sub_group_name")
            'dgvoucher(6, row).Value = "BEING SALARY FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
            row = row + 1
            cr = cr + Val(ds.Tables("bonusbankdr").Rows(j)("dramt"))
        Next
        txtCr.Text = cr
    End Sub

    Private Sub frmBonusBankDr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "vtB")
        cmbvtype.DataSource = GMod.ds.Tables("vtB")
        cmbvtype.DisplayMember = "vtype"

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' AND group_name in ('BANK','IMPREST')"
        GMod.DataSetRet(sql, "aclist1")
        cmbFrightCode.DataSource = GMod.ds.Tables("aclist1")
        cmbFrightCode.DisplayMember = "account_code"
        cmbFreightHead.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightHead.DisplayMember = "account_head_name"
        cmbFreightGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightGroup.DisplayMember = "group_name"

        cmbFreightSubGroup.DataSource = GMod.ds.Tables("aclist1")
        cmbFreightSubGroup.DisplayMember = "sub_group_name"




        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' AND group_name in ('BANK','IMPREST')"
        GMod.DataSetRet(sql, "aclist2")
        ComboBox1.DataSource = GMod.ds.Tables("aclist2")
        ComboBox1.DisplayMember = "account_code"
        ComboBox2.DataSource = GMod.ds.Tables("aclist2")
        ComboBox2.DisplayMember = "account_head_name"

        ComboBox3.DataSource = GMod.ds.Tables("aclist2")
        ComboBox3.DisplayMember = "group_name"

        ' ComboBox3.DataSource = GMod.ds.Tables("aclist1")
        ' ComboBox3.DisplayMember = "sub_group_name"





    End Sub
    Dim k As Integer
    Dim sqlsavenecc As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Are U sure", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & cmbvtype1.Text & "'"
                GMod.DataSetRet(sql, "vnosalbanktransfer")
                lblvouno1.Text = ds.Tables("vnosalbanktransfer").Rows(0)(0)
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
                    sqlsavenecc &= "'" & lblvouno1.Text & "',"
                    sqlsavenecc &= "'" & cmbvtype1.Text & "',"
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
                sqlsavenecc &= "'" & lblvouno1.Text & "',"
                sqlsavenecc &= "'" & cmbvtype1.Text & "',"
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


                sqlsavenecc = " insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
              & " Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
              & " Narration, Group_name, Sub_group_name,Cheque_no) VALUES ("
                sqlsavenecc &= "'" & GMod.Cmpid & "',"
                sqlsavenecc &= "'" & GMod.username & "',"
                sqlsavenecc &= "'" & k & "',"
                sqlsavenecc &= "'" & lblvouno1.Text & "',"
                sqlsavenecc &= "'" & cmbvtype1.Text & "',"
                sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                sqlsavenecc &= "'" & ComboBox1.Text & "',"
                sqlsavenecc &= "'" & ComboBox2.Text & "',"
                sqlsavenecc &= "'" & Val(TextBox2.Text) & "',"
                sqlsavenecc &= "'" & Val(TextBox1.Text) & "',"
                sqlsavenecc &= "'" & txtnarr.Text & "',"
                sqlsavenecc &= "'" & ComboBox3.Text & "',"
                sqlsavenecc &= "'-',"
                sqlsavenecc &= "'" & txtChqNo.Text & "')"
                Dim cmd5 As New SqlCommand(sqlsavenecc, SqlConn, trans)
                cmd5.ExecuteNonQuery()
                trans.Commit()




                MsgBox("Bank entry saved...")
                dgvoucher.Rows.Clear()
                ' cmbvtype_SelectedIndexChanged(sender, e)
            Catch ex As Exception
                trans.Rollback()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellContentClick

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
End Class