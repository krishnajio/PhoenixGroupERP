Public Class frmChangePassword

    Private Sub txtOldPassword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOldPassword.Leave
        sql = "select cast(Pwd as varchar(20)) from Usertab4 where Uname='" & GMod.username & "'"
        GMod.DataSetRet(sql, "GP")
        If GMod.ds.Tables("GP").Rows(0)(0).ToString = txtOldPassword.Text Then

        Else
            MsgBox("Please Enter Correct Password")
            txtOldPassword.Focus()
        End If
    End Sub
    Dim sql As String
    Private Sub txtOldPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOldPassword.TextChanged
       
    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOldPassword.Focus()
    End Sub

    Private Sub txtrepass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrepass.Leave
        If txtpassword.Text = txtrepass.Text Then
            Exit Sub
        Else
            MsgBox("Password & Retype Password Must Be Same", MsgBoxStyle.OkOnly, "Error")
            txtpassword.Text = ""
            txtrepass.Text = ""
            txtpassword.Focus()
        End If
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        Dim sqlupdate As String, sqlresult As String
        sqlupdate = "update usertab4 set"
        sqlupdate &= " Pwd=" & " CAST('" & txtpassword.Text & "' as varbinary(128))"
        sqlupdate &= " where  Uname=" & "'" & GMod.username & "'"
        MsgBox(GMod.SqlExecuteNonQuery(sqlupdate))
        txtOldPassword.Text = ""
        txtpassword.Text = ""
        txtrepass.Text = ""
    End Sub
End Class