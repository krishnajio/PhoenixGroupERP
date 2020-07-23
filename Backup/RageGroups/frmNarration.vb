Public Class frmNarration

    Private Sub frmNarration_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub frmNarration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        fillgrid()
    End Sub
    Sub fillgrid()
        GMod.DataSetRet("select narration from narration_master where cmp_id='" & GMod.Cmpid & "'", "narr")
        dgnarration.Rows.Clear()
        Dim i As Integer
        For i = 0 To GMod.ds.Tables("narr").Rows.Count - 1
            dgnarration.Rows.Add()
            dgnarration(0, i).Value = GMod.ds.Tables("narr").Rows(i)(0)
        Next

    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim s As String
        If txtnarration.Text = "" Then
            MsgBox("Please entered narration", MsgBoxStyle.Critical)
            Exit Sub
        End If
        s = GMod.SqlExecuteNonQuery("insert into narration_master(cmp_id,narration) values('" & GMod.Cmpid & "','" & txtnarration.Text & "')")
        If s <> "SUCCESS" Then
            MsgBox(s, MsgBoxStyle.Critical, "Error")
        Else
            MsgBox("Narration Stored successfully", MsgBoxStyle.Information)
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtnarration.Text = ""
        btnsave.Enabled = True
        btnmodify.Text = "&Modify"
        txtnarration.Focus()
        fillgrid()
    End Sub

    Private Sub dgnarration_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgnarration.CellContentClick

    End Sub

    Private Sub dgnarration_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgnarration.DoubleClick
        Dim r As Integer
        r = dgnarration.CurrentRow.Index
        txtnarration.Text = dgnarration(0, r).Value
        lblnarration.Text = dgnarration(0, r).Value
        btnsave.Enabled = False
        btnmodify.Text = "&Update"
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        If btnsave.Enabled Then
            MsgBox("Double Click on Narration", MsgBoxStyle.Critical)
        Else
            Dim s As String
            If txtnarration.Text = "" Then
                MsgBox("Please entered narration", MsgBoxStyle.Critical)
                Exit Sub
            End If
            s = GMod.SqlExecuteNonQuery("update narration_master set narration='" & txtnarration.Text & "'  where cmp_id='" & GMod.Cmpid & "' and narration='" & lblnarration.Text & "'")

            If s <> "SUCCESS" Then
                MsgBox(s, MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Narration updated successfully", MsgBoxStyle.Information)
                btnreset_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If btnsave.Enabled Then
            MsgBox("Double Click on Narration", MsgBoxStyle.Critical)
        Else
            Dim s As String
            If vbYes = MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) Then
                s = GMod.SqlExecuteNonQuery("delete narration_master where cmp_id='" & GMod.Cmpid & "' and narration='" & lblnarration.Text & "'")
                If s <> "SUCCESS" Then
                    MsgBox(s, MsgBoxStyle.Critical, "Error")
                Else
                    MsgBox("Narration deleted successfully", MsgBoxStyle.Information)
                End If
            End If
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub txtnarration_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnarration.KeyDown
        If e.KeyCode = Keys.Enter Then btnsave.Focus()
    End Sub
End Class