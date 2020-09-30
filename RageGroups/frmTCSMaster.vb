Public Class frmTCSMaster
    Dim sql As String
    Private Sub frmTdsMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(Sql, "aclist1")

        cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadname.DisplayMember = "account_head_name"
        fillGrid()
    End Sub
    Private Sub cmbacheadname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadname.Leave
        If cmbacheadname.FindStringExact(cmbacheadname.Text) = -1 Then
            MsgBox("Please select correct head", MsgBoxStyle.Critical)
            cmbacheadname.Focus()
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtTdsType.Text = "" Then
            MsgBox("TCS Type can't be blank")
            txtTdsType.Focus()
            Exit Sub
        End If

        If txtTdsper.Text = "" Then
            MsgBox("TCS Percentage can't be blank")
            txtTdsper.Focus()
            Exit Sub
        End If


        If cmbacheadname.Text = "" Then
            MsgBox("A/c Head can't be blank")
            txtTdsType.Focus()
            Exit Sub
        End If


        sql = "insert into TCSMaster(TcsType, Per, Acc_Code,cmp_id) values ("
        sql &= "'" & txtTdsType.Text.ToUpper & "',"
        sql &= "'" & txtTdsper.Text & "',"
        sql &= "'" & cmbacheadcode.Text & "',"
        sql &= "'" & GMod.Cmpid & "')"

        MsgBox(GMod.SqlExecuteNonQuery(sql))

        fillGrid()
        txtTdsper.Text = ""
        txtTdsType.Text = ""
        cmbacheadname.SelectedIndex = 0
        txtTdsType.Focus()
    End Sub

    Sub fillGrid()
        sql = "select * from TCSMaster where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "TdsMaster")
        dg.DataSource = GMod.ds.Tables("TdsMaster")

    End Sub


    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Try
            btnsave.Enabled = False
            btn_modify.Text = "&Update"
            txtTdsType.Text = dg(0, dg.CurrentCell.RowIndex).Value
            txtTdsper.Text = dg(1, dg.CurrentCell.RowIndex).Value
            cmbacheadcode.Text = dg(2, dg.CurrentCell.RowIndex).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modify.Click
        If btn_modify.Text = "&Update" Then

            If txtTdsType.Text = "" Then
                MsgBox("TCS Type can't be blank")
                txtTdsType.Focus()
                Exit Sub
            End If

            If txtTdsper.Text = "" Then
                MsgBox("TCS Percentage can't be blank")
                txtTdsper.Focus()
                Exit Sub
            End If


            If cmbacheadname.Text = "" Then
                MsgBox("A/c Head can't be blank")
                txtTdsType.Focus()
                Exit Sub
            End If


            sql = "Update TCSMaster "
            sql &= " set TcsType='" & txtTdsType.Text.ToUpper & "',"
            sql &= " Per='" & txtTdsper.Text & "',"
            sql &= " Acc_Code='" & cmbacheadcode.Text & "' where id = " & dg(3, dg.CurrentCell.RowIndex).Value

            MsgBox(GMod.SqlExecuteNonQuery(sql))
            fillGrid()

            btnsave.Enabled = True
            btn_modify.Text = "&Modify"
            txtTdsper.Text = ""
            txtTdsType.Text = ""
            cmbacheadname.SelectedIndex = 0
            txtTdsType.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtTdsper.Text = ""
        txtTdsType.Text = ""
        cmbacheadname.SelectedIndex = 0
    End Sub
End Class