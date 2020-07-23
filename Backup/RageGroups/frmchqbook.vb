Public Class frmchqbook

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        If btnsave.Enabled Then
            MsgBox("Please double click on the list", MsgBoxStyle.Information)
        Else
            If txtbookno.Text = "" Then
                MsgBox("Please type Book No", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            If txtchqnofrom.Text = "" Then
                MsgBox("Please type Starting Cheque No", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            'Cmp_id, Uname, Entry_id, Entry_date, Acc_head_code, Acc_head, 
            'Book_no, Cheque_no_from, Cheque_no_to, isavailable
            If txtchqnoto.Text = "" Then
                MsgBox("Please type Ending Cheque No", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            Dim sql, s As String
            sql = "update " & GMod.CHQBOOK & " set entry_date='" & Dtentry.Value.ToShortDateString & "'," _
            & "acc_head_code='" & Cmbbankcode.Text & "',acc_head='" & cmbbankname.Text & "',book_no='" & txtbookno.Text & "'," _
            & "Cheque_no_from='" & txtchqnofrom.Text & "',Cheque_no_to='" & txtchqnoto.Text & "' where " _
            & " entry_id=" & txtentryid.Text
            s = GMod.SqlExecuteNonQuery(sql)
            If s = "SUCCESS" Then
                btnreset_Click(sender, e)
            Else
                MsgBox(s)
            End If
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtentryid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtentryid.KeyDown
        If e.KeyCode = Keys.Enter Then Dtentry.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtentryid.TextChanged

    End Sub

    Private Sub frmchqbook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        nxtid()
        fillgrid()
        GMod.DataSetRet("select * from " & GMod.ACC_HEAD & " where group_name='BANK'", "bank")
        Cmbbankcode.DataSource = GMod.ds.Tables("bank")
        Cmbbankcode.DisplayMember = "account_code"
        cmbbankname.DataSource = GMod.ds.Tables("bank")
        cmbbankname.DisplayMember = "account_head_name"
    End Sub
    Sub nxtid()
        GMod.DataSetRet("select isnull(max(entry_id)+1,1) from " & GMod.CHQBOOK, "id")
        txtentryid.Text = GMod.ds.Tables("id").Rows(0)(0)
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub Dtentry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dtentry.KeyDown
        If e.KeyCode = Keys.Enter Then Cmbbankcode.Focus()
    End Sub

    Private Sub Dtentry_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtentry.ValueChanged

    End Sub

    Private Sub Cmbbankcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmbbankcode.KeyDown
        If e.KeyCode = Keys.Enter Then cmbbankname.Focus()
    End Sub

    Private Sub cmbbankname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbankname.KeyDown
        If e.KeyCode = Keys.Enter Then txtbookno.Focus()
    End Sub

    Private Sub txtbookno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbookno.KeyDown
        If e.KeyCode = Keys.Enter Then txtchqnofrom.Focus()
    End Sub

    Private Sub txtchqnofrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtchqnofrom.KeyDown
        If e.KeyCode = Keys.Enter Then txtchqnoto.Focus()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtbookno.Text = "" Then
            MsgBox("Please type Book No", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If txtchqnofrom.Text = "" Then
            MsgBox("Please type Starting Cheque No", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If txtchqnoto.Text = "" Then
            MsgBox("Please type Ending Cheque No", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim sql, s As String
        sql = "insert into " & GMod.CHQBOOK & "(Cmp_id, Uname, Entry_id, Entry_date, Acc_head_code, " _
        & " Acc_head, Book_no, Cheque_no_from, Cheque_no_to, isavailable)" _
        & " values('" & GMod.Cmpid & "','" & GMod.username & "','" & txtentryid.Text & "','" & Dtentry.Value.ToShortDateString & "'," _
        & "'" & Cmbbankcode.Text & "','" & cmbbankname.Text & "','" & txtbookno.Text & "','" & txtchqnofrom.Text & "'," _
        & "'" & txtchqnoto.Text & "','Y')"
        s = GMod.SqlExecuteNonQuery(sql)
        If s <> "SUCCESS" Then
            MsgBox(s, MsgBoxStyle.Critical, "Error")
        Else
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        nxtid()
        txtbookno.Text = ""
        txtchqnofrom.Text = ""
        txtchqnoto.Text = ""
        btnsave.Enabled = True
        btnmodify.Text = "&Modify"
        fillgrid()
    End Sub
    Sub fillgrid()
        GMod.DataSetRet("select * from " & GMod.CHQBOOK & " where isavailable='Y'", "dis")
        dgchequebook.Rows.Clear()
        Dim i As Integer
        If dgchequebook.Rows.Count > 0 Then dgchequebook.Rows.Clear()
        For i = 0 To ds.Tables("dis").Rows.Count - 1
            dgchequebook.Rows.Add()
            dgchequebook(0, i).Value = GMod.ds.Tables("dis").Rows(i)("entry_id")
            dgchequebook(1, i).Value = GMod.ds.Tables("dis").Rows(i)("Acc_head_code")
            dgchequebook(2, i).Value = GMod.ds.Tables("dis").Rows(i)("ACC_HEAD")
            dgchequebook(3, i).Value = GMod.ds.Tables("dis").Rows(i)("Entry_date")
            dgchequebook(4, i).Value = GMod.ds.Tables("dis").Rows(i)("book_no")
            dgchequebook(5, i).Value = GMod.ds.Tables("dis").Rows(i)("Cheque_no_from")
            dgchequebook(6, i).Value = GMod.ds.Tables("dis").Rows(i)("Cheque_no_to")
        Next
    End Sub

    Private Sub dgchequebook_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgchequebook.CellContentClick

    End Sub

    Private Sub dgchequebook_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgchequebook.DoubleClick
        Dim r As Integer
        r = dgchequebook.CurrentCell.RowIndex
        txtentryid.Text = dgchequebook(0, r).Value
        Dtentry.Value = dgchequebook(3, r).Value
        Cmbbankcode.Text = dgchequebook(1, r).Value
        cmbbankname.Text = dgchequebook(2, r).Value
        txtbookno.Text = dgchequebook(4, r).Value
        txtchqnofrom.Text = dgchequebook(5, r).Value
        txtchqnoto.Text = dgchequebook(6, r).Value
        btnsave.Enabled = False
        btnmodify.Text = "&Update"

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If btnsave.Enabled Then
            MsgBox("Please double click on the list", MsgBoxStyle.Information)
        Else
            Dim sql, s As String
            If MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbYes Then
                sql = "delete from " & GMod.CHQBOOK & " where entry_id='" & txtentryid.Text & "'"
                s = GMod.SqlExecuteNonQuery(sql)
                If s <> "SUCCESS" Then
                    MsgBox(s)
                End If
            End If
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub Cmbbankcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbbankcode.SelectedIndexChanged
        GMod.DataSetRet("select isnull(max(cast (book_no as Integer))+1,1) from " & GMod.CHQBOOK & " where acc_head_code='" & Cmbbankcode.Text & "' and cmp_id='" & GMod.Cmpid & "'", "bno")
        txtbookno.Text = GMod.ds.Tables("bno").Rows(0)(0)
    End Sub

    Private Sub btndelete_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndelete.Leave
        Cmbbankcode_SelectedIndexChanged(sender, e)
    End Sub
End Class