Public Class frmUserassignment

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmUserassignment_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub frmUserassignment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from usertab3 order by uname", "user")
        cmbuname.DataSource = GMod.ds.Tables("user")
        cmbuname.DisplayMember = "uname"
        filltab()
    End Sub
    Sub filltab()
        lremcmpname.Items.Clear()
        lallotcmpname.Items.Clear()
        GMod.DataSetRet("select cmp_id,cmpname from company where cmp_id not in (select cmp_id from cmp_assignment where uname='" & cmbuname.Text & "')", "remcmp")
        Dim i As Integer
        For i = 0 To GMod.ds.Tables("remcmp").Rows.Count - 1
            lremcmpname.Items.Add(GMod.ds.Tables("remcmp").Rows(i)(1))
        Next
        GMod.DataSetRet("select cmp_id,cmpname from company where cmp_id in (select cmp_id from cmp_assignment where uname='" & cmbuname.Text & "')", "remcmp")
        For i = 0 To GMod.ds.Tables("remcmp").Rows.Count - 1
            lallotcmpname.Items.Add(GMod.ds.Tables("remcmp").Rows(i)(1))
        Next
    End Sub

    Private Sub lremcmpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lremcmpname.SelectedIndexChanged
    End Sub

    Private Sub btnallot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallot.Click
        Dim i As Integer
        Dim cp As String
        For i = 0 To lremcmpname.SelectedItems.Count - 1
            cp = lremcmpname.GetItemText(lremcmpname.SelectedItems(lremcmpname.SelectedItems.Count - 1))
            lallotcmpname.Items.Add(cp)
            lremcmpname.Items.Remove(cp)
        Next
    End Sub

    Private Sub lremcmpid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lallotcmpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lallotcmpname.SelectedIndexChanged

    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Dim i As Integer
        Dim cp As String
        For i = 0 To lallotcmpname.SelectedItems.Count - 1
            cp = lallotcmpname.GetItemText(lallotcmpname.SelectedItems(lallotcmpname.SelectedItems.Count - 1))
            lremcmpname.Items.Add(cp)
            lallotcmpname.Items.Remove(cp)
        Next
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim sqltrans As SqlClient.SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction
        Dim i As Integer
        Try
            Dim cmd1 As New SqlClient.SqlCommand("delete from cmp_assignment where uname='" & cmbuname.Text & "'", GMod.SqlConn, sqltrans)
            Dim cmd2 As New SqlClient.SqlCommand
            cmd1.ExecuteNonQuery()
            For i = 0 To lallotcmpname.Items.Count - 1
                GMod.DataSetRet("select * from company where cmpname='" & lallotcmpname.Items.Item(i) & "'", "tmp")
                cmd2 = New SqlClient.SqlCommand("insert into cmp_assignment values('" & cmbuname.Text & "','" & GMod.ds.Tables("tmp").Rows(0)(0) & "')", GMod.SqlConn, sqltrans)
                cmd2.ExecuteNonQuery()
            Next
            sqltrans.Commit()
            MsgBox("Company Assigned sucessfully", MsgBoxStyle.Information)
            btnclose_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Error")
            sqltrans.Rollback()
        End Try
        

    End Sub

    Private Sub cmbuname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbuname.SelectedIndexChanged
        filltab()
    End Sub
End Class