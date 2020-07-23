Public Class frmInterest

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmInterest_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub frmInterest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        fillgrid()
        nxtid()
        cmbinttype.SelectedIndex = 0
    End Sub
    Sub fillgrid()
        GMod.DataSetRet("select * from interest_rules where cmp_id='" & GMod.Cmpid & "'", "rul")
        dginterest.Rows.Clear()
        Dim i As Integer
        For i = 0 To GMod.ds.Tables("rul").Rows.Count - 1
            dginterest.Rows.Add()
            dginterest(0, i).Value = GMod.ds.Tables("rul").Rows(i)("rule_id")
            dginterest(1, i).Value = GMod.ds.Tables("rul").Rows(i)("description")
            dginterest(2, i).Value = GMod.ds.Tables("rul").Rows(i)("rateofint")
            dginterest(3, i).Value = GMod.ds.Tables("rul").Rows(i)("int_type")
        Next
    End Sub
    Sub nxtid()
        GMod.DataSetRet("select isnull(max(rule_id)+1,1) from interest_rules where cmp_id='" & GMod.Cmpid & "'", "id")
        txtruleid.Text = GMod.ds.Tables("id").Rows(0)(0)
    End Sub
    Dim s As String
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtdescr.Text = "" Then
            MsgBox("Type Descrription of Interest Rule", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txtrate.Text = "" Then
            MsgBox("Type Rate of Interest Rule", MsgBoxStyle.Critical)
            Exit Sub
        End If
        s = GMod.SqlExecuteNonQuery("insert into interest_rules(cmp_id,rule_id,description,rateofint,int_type) values('" & GMod.Cmpid & "'," & Val(txtruleid.Text) & ",'" & txtdescr.Text & "'," & Val(txtrate.Text) & ",'" & cmbinttype.Text & "')")
        If s <> "SUCCESS" Then
            MsgBox(s, MsgBoxStyle.Critical, "Error")
        Else
            MsgBox("Information saved successfuly", MsgBoxStyle.Information)
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtdescr.Text = ""
        txtrate.Text = ""
        btnsave.Enabled = True
        btnmodify.Text = "&Modify"
        nxtid()
        fillgrid()
    End Sub

    Private Sub dginterest_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dginterest.CellContentClick

    End Sub

    Private Sub dginterest_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dginterest.DoubleClick
        Dim r As Integer
        r = dginterest.CurrentRow.Index
        txtruleid.Text = dginterest(0, r).Value
        txtdescr.Text = dginterest(1, r).Value
        txtrate.Text = dginterest(2, r).Value
        cmbinttype.Text = dginterest(3, r).Value
        btnsave.Enabled = False
        btnmodify.Text = "&Update"
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        If btnsave.Enabled Then
            MsgBox("Double Click on List", MsgBoxStyle.Critical)
        Else
            Dim s As String
            If txtdescr.Text = "" Then
                MsgBox("Type Descrription of Interest Rule", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If txtrate.Text = "" Then
                MsgBox("Type Rate of Interest Rule", MsgBoxStyle.Critical)
                Exit Sub
            End If
            s = GMod.SqlExecuteNonQuery("update interest_rules set description='" & txtdescr.Text & "',rateofint=" & Val(txtrate.Text) & ",int_type='" & cmbinttype.Text & "'  where  rule_id=" & Val(txtruleid.Text) & " and cmp_id='" & GMod.Cmpid & "'")
            If s <> "SUCCESS" Then
                MsgBox(s, MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Information updated successfully", MsgBoxStyle.Information)
                btnreset_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If btnsave.Enabled Then
            MsgBox("Double Click on List", MsgBoxStyle.Critical)
        Else
            Dim s As String
            If vbYes = MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) Then
                s = GMod.SqlExecuteNonQuery("delete interest_rules where  rule_id=" & Val(txtruleid.Text) & " and cmp_id='" & GMod.Cmpid & "'")
                If s <> "SUCCESS" Then
                    MsgBox(s, MsgBoxStyle.Critical, "Error")
                Else
                    MsgBox("Information Deleted successfully", MsgBoxStyle.Information)
                End If
            End If
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub txtdescr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdescr.KeyDown
        If e.KeyCode = Keys.Enter Then txtrate.Focus()
    End Sub

    Private Sub txtrate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrate.KeyDown
        If e.KeyCode = Keys.Enter Then cmbinttype.Focus()
    End Sub

    Private Sub txtruleid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtruleid.KeyDown
        If e.KeyCode = Keys.Enter Then txtdescr.Focus()

    End Sub

    Private Sub cmbinttype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbinttype.KeyDown
        If e.KeyCode = Keys.Enter Then btnsave.Focus()
    End Sub

End Class