Public Class frmusermgt

    Private Sub txtrepass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrepass.Leave
        If txtpassword.Text = txtrepass.Text Then
            Exit Sub
        Else
            MsgBox("Password & Retype Password Must Be Same", MsgBoxStyle.OkOnly, "Error")
            txtpassword.Text = ""
            txtrepass.Text = ""
            txtpassword.Focus()
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtpassword.Text = ""
        txtrepass.Text = ""
        txtusername.Text = ""
        btnsave.Enabled = True
        txtusername.Focus()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'User_id, Uname, Pwd, Role

        Dim Sqlsavestr As String, Sqlresult As String
        Sqlsavestr = "Insert into Usertab2(Uname, Pwd, Role,dept) values ("
        Sqlsavestr &= "'" & txtusername.Text & "',"
        Sqlsavestr &= " CAST('" & txtpassword.Text & "' as varbinary(128)),"
        Sqlsavestr &= "'" & cmbrole.Text.ToUpper & "',"
        Sqlsavestr &= "'" & cmbdept.SelectedIndex & "')"

        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Name and password are required", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
        If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate company code", MsgBoxStyle.Critical)
            Else
                MsgBox("Error :" & Sqlresult, MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("User information saved", MsgBoxStyle.Critical)
            btnreset_Click(sender, e)
            fillgrid()
        End If
    End Sub
    Public Sub fillgrid()
        Dim sqlselectall As String
        sqlselectall = "select  Uname, Role,Dept from usertab2"
        GMod.DataSetRet(sqlselectall, "usertab")
        dguserinfo.DataSource = ds.Tables("usertab")
    End Sub

    Private Sub frmusermgt_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub frmusermgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GMod.role.ToUpper = "ADMIN" Then
            btnmodify.Enabled = True
            btndelete.Enabled = True
            btnsave.Enabled = True
        Else
            btnmodify.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = False
        End If
        fillgrid()
    End Sub
    Dim userid, rowidx As Integer
    Private Sub dguserinfo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dguserinfo.DoubleClick
        rowidx = dguserinfo.CurrentCell.RowIndex
        txtusername.Text = dguserinfo(0, rowidx).Value
        cmbrole.Text = dguserinfo(1, rowidx).Value
        txtusername.Focus()
        btnsave.Enabled = False
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        'User_id, Uname, Pwd, Role
        Dim sqlupdate As String, sqlresult As String
        sqlupdate = "update usertab2 set"
        sqlupdate &= " Uname=" & "'" & txtusername.Text & "',"
        sqlupdate &= " Pwd=" & " CAST('" & txtpassword.Text & "' as varbinary(128)),"
        sqlupdate &= " Role=" & "'" & cmbrole.Text.ToUpper & "',"
        sqlupdate &= " Dept=" & "'" & cmbdept.SelectedIndex & "' "
        sqlupdate &= " where  Uname=" & "'" & dguserinfo(0, rowidx).Value & "'"
        If btnsave.Enabled Then
            MsgBox("Please double click on the Company name to select", MsgBoxStyle.Critical)
        Else
            If txtusername.Text = "" Or txtpassword.Text = "" Then
                MsgBox("name and password are necessary", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If MessageBox.Show("Are u sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                sqlresult = GMod.SqlExecuteNonQuery(sqlupdate)
                If sqlresult <> "SUCCESS" Then
                    MsgBox("Error :" & sqlresult, MsgBoxStyle.Critical)
                Else
                    btnreset_Click(sender, e)
                End If
            Else
                btnreset_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txtusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then txtpassword.Focus()

    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then txtrepass.Focus()

    End Sub


    Private Sub txtrepass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrepass.KeyDown
        If e.KeyCode = Keys.Enter Then cmbrole.Focus()
    End Sub

    Private Sub cmbrole_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbrole.KeyDown
        If e.KeyCode = Keys.Enter Then btnsave.Focus()
    End Sub

    Private Sub txtrepass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrepass.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdept.SelectedIndexChanged

    End Sub
End Class