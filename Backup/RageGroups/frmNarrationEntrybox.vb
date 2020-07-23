Public Class frmNarrationEntrybox

    Private Sub frmNarrationEntrybox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Text = Me.Text & "    " & GMod.Cmpname
    End Sub
    Private Sub txtNarrationEntrty_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNarrationEntrty.KeyUp
        If e.KeyCode = Keys.Enter Then
            MsgBox("You have pressed Entry key", MsgBoxStyle.Critical)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.ControlKey Then
            Me.Close()
        End If
    End Sub

    Private Sub txtNarrationEntrty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNarrationEntrty.TextChanged
        Me.Text = "Charchter Count: " & txtNarrationEntrty.Text.Length
        Wcont()
    End Sub

    Sub Wcont()
        Dim NoWocount() As String
        NoWocount = txtNarrationEntrty.Text.Split(" ")
        Me.Text = Me.Text & " Word Count: " & NoWocount.Length
    End Sub
End Class