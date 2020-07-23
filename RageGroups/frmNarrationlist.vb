Public Class frmNarrationlist

    Private Sub frmNarrationlist_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub frmNarrationlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        GMod.DataSetRet("select * from narration_master where cmp_id='" & GMod.Cmpid & "' order by narration", "nar")
        ComboBox1.DataSource = GMod.ds.Tables("nar")
        ComboBox1.DisplayMember = "Narration"
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress

    End Sub

    Private Sub ComboBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyUp
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
        Dim pp As Integer
        If e.KeyValue = 8 And e.KeyValue = 110 Then
            If pp > 1 Then

                pp = pp - 1
            Else

                pp = 1

            End If
        Else
            If e.KeyValue >= 65 And e.KeyValue <= 90 Then
                ComboBox1.SelectedIndex = ComboBox1.FindString(ComboBox1.Text)
                ComboBox1.SelectionStart = pp
                ComboBox1.Select(pp, ComboBox1.Text.Length)
                pp = pp + 1
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class