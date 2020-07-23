Public Class frmPaymentDatePopUp

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub frmPaymentDatePopUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpdate.Value = CDate("1/1/2000")
    End Sub

    Private Sub dtpdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOk.Focus()
        End If
    End Sub
End Class