Public Class frmNoofDays

    Private Sub txtCrmat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrmat.TextChanged

    End Sub
    Private Sub Cramt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cramt.Click

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(GMod.SqlExecuteNonQuery("update dbo.nofd set nofd='" & txtCrmat.Text & "'"))
    End Sub
End Class