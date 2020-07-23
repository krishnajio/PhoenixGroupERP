Public Class frmUserSessionPermission
    Dim sql, session, prev As String
    Dim prevprefix, i As Integer
    Private Sub frmUserSessionPermission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select distinct Uname from usertab1"
        GMod.DataSetRet(sql, "username")

        cmbUserName.DataSource = GMod.ds.Tables("username")
        cmbUserName.DisplayMember = "Uname"


       

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GMod.DataSetRet("select convert(varchar(50),getdate(),106)", "svrdat")
        session = GMod.Getsession(CDate(GMod.ds.Tables("svrdat").Rows(0)(0)))


        If TextBox1.Text = "" Then
            MessageBox.Show("Please give how many numbers")
        Else
            For i = 0 To CInt(TextBox1.Text)
                cmbSession.Items.Add(session)
                prev = session.Substring(0, 2)
                prevprefix = CInt(prev) - 1
                session = prevprefix.ToString + prev
            Next
        End If
       

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        sql = "insert into SessionMaster(SessionId, session, Uname,entry_status) values('" & numericup.Value.ToString & "','" & cmbSession.Text & "','" & cmbUserName.Text & "','" & cmbEntryStatus.Text & "')"
        MessageBox.Show(GMod.SqlExecuteNonQuery(sql))
    End Sub

    Private Sub cmbSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSession.SelectedIndexChanged
        sql = "select * from SessionMaster where session = '" & cmbSession.Text & "'"
        GMod.DataSetRet(sql, "sessionmaster")
        dggroups.DataSource = GMod.ds.Tables("sessionmaster")
    End Sub

    Private Sub dggroups_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dggroups.CellContentClick
        i = e.RowIndex
        
    End Sub

    Private Sub dggroups_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dggroups.CellContentDoubleClick
        i = e.RowIndex
        MessageBox.Show(dggroups(0, i).Value.ToString())
        sql = "delete from SessionMaster where session = '" & cmbSession.Text & "' and id='" & dggroups(0, i).Value.ToString() & "'"
        MessageBox.Show(GMod.SqlExecuteNonQuery(sql))
        cmbSession_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        MessageBox.Show(dggroups(0, i).Value.ToString())
        sql = "update SessionMaster set entry_status ='" & cmbEntryStatus.Text & "' where session = '" & cmbSession.Text & "' and id='" & dggroups(0, i).Value.ToString() & "'"
        MessageBox.Show(GMod.SqlExecuteNonQuery(sql))
        cmbSession_SelectedIndexChanged(sender, e)
    End Sub
End Class