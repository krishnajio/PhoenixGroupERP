Public Class frmExpensesVoucherNarration

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        TextBox1.Text = ""
        Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        TextBox1.Text = "" & txtnarr1.Text & "#" + txtName.Text & "FOR MONTH #" & dtExpDate.Text & "#"
        Me.Close()
    End Sub

    Private Sub txtnarr1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnarr1.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub txtnarr1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnarr1.TextChanged

    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub dtExpDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtExpDate.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub dtExpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtExpDate.ValueChanged

    End Sub

    Private Sub btnOk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOk.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmExpensesVoucherNarration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub frmExpensesVoucherNarration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class