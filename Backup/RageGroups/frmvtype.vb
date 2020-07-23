Public Class frmvtype

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'Cmp_id, Vtype, Seqorder
        MsgBox(cmbvouchernoseq.SelectedIndex)
        Dim Sqlsavestr As String, Sqlresult As String
        Sqlsavestr = "Insert into Vtype(Cmp_id, Vtype, Seqorder,Vou_no_seq,vprefix) values ("
        Sqlsavestr &= "'" & GMod.Cmpid.ToUpper & "',"
        Sqlsavestr &= "'" & txtvtype.Text.ToUpper & "',"
        Sqlsavestr &= "'" & numericup.Value.ToString & "',"
        Sqlsavestr &= "'" & cmbvouchernoseq.SelectedIndex.ToString & "',"
        Sqlsavestr &= "'" & txtPrefix.Text & "')"
        If txtvtype.Text = "" Then
            MsgBox("Voucher type  is required", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
        If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate vtype (Voucher type already exists for this company)", MsgBoxStyle.Critical)
            Else
                MsgBox("Error :" & Sqlresult, MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Voucher type saved", MsgBoxStyle.Information)
            btnreset_Click(sender, e)
            fillgrid()
        End If
        txtvtype.Focus()
    End Sub
    Public Sub fillgrid()
        Dim sqlselectall As String
        sqlselectall = "select Vtype, Seqorder,Vou_no_seq,vprefix from Vtype where Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlselectall, "vtype")
        dggroups.DataSource = ds.Tables("vtype")
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtvtype.Text = ""
        txtvtype.Focus()
        btnsave.Enabled = True
        dggroups.Enabled = True
        fillgrid()
    End Sub

    Private Sub frmvtype_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub
    Private Sub frmvtype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        fillgrid()

        If GMod.role.ToUpper = "ADMIN" Then
            btnmodify.Enabled = True
            btndelete.Enabled = True
            btnsave.Enabled = True
        Else
            btnmodify.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = False
        End If
    End Sub
    Dim rowidx As Integer
    Private Sub dggroups_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dggroups.DoubleClick
        rowidx = dggroups.CurrentCell.RowIndex
        txtvtype.Text = dggroups(0, rowidx).Value
        numericup.Value = dggroups(1, rowidx).Value
        cmbvouchernoseq.SelectedIndex = dggroups(2, rowidx).Value
        txtPrefix.Text = dggroups(3, rowidx).Value
        btnsave.Enabled = False
        dggroups.Enabled = False
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        Dim sqltrans As SqlClient.SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction

        Dim sqlupdate, sqlupdate1 As String
        sqlupdate = "update Vtype set "
        sqlupdate &= " Vtype=" & "'" & txtvtype.Text & "',"
        sqlupdate &= " Seqorder=" & "'" & numericup.Value & "',"
        sqlupdate &= " Vou_no_seq=" & "'" & cmbvouchernoseq.SelectedIndex.ToString & "',"
        sqlupdate &= " vprefix=" & "'" & txtPrefix.Text & "' "
        sqlupdate &= " where  Cmp_id=" & "'" & Cmpid & "' and Vtype='" & dggroups(0, rowidx).Value & "'"
        If btnsave.Enabled Then
            MsgBox("Please double click on the Company name to select", MsgBoxStyle.Critical)
        Else
            If txtvtype.Text = "" Then
                MsgBox("Vtype is necessary", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If MessageBox.Show("Are u sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                 Try
                    Dim cmd1 As New SqlClient.SqlCommand(sqlupdate, GMod.SqlConn, sqltrans)
                    cmd1.ExecuteNonQuery()
                    sqlupdate1 = "update " & GMod.VENTRY & " set vou_type='" & txtvtype.Text & "' where cmp_id='" & GMod.Cmpid & "' and vou_type='" & dggroups(0, rowidx).Value & "'"
                    Dim cmd2 As New SqlClient.SqlCommand(sqlupdate1, GMod.SqlConn, sqltrans)
                    cmd2.ExecuteNonQuery()
                    sqltrans.Commit()
                    MsgBox("Voucher type Modified successfully", MsgBoxStyle.Information, "Information")
                    btnreset_Click(sender, e)
                    fillgrid()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    sqltrans.Rollback()
                End Try
                sqltrans.Dispose()
            Else
                btnreset_Click(sender, e)
        End If
        End If
        sqltrans = Nothing
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim sqldelete As String
        sqldelete = "delete from vtype "
        sqldelete &= " where  Cmp_id=" & "'" & Cmpid & "' and Vtype='" & dggroups(0, rowidx).Value & "'"
        If btnsave.Enabled Then
            MsgBox("Please double click on the Company name to select", MsgBoxStyle.Critical)
        Else
            If txtvtype.Text = "" Then
                MsgBox("Vtype is necessary", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If MessageBox.Show("Are u sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                GMod.DataSetRet("select * from " & GMod.VENTRY & " where Cmp_id=" & "'" & Cmpid & "' and Vou_type='" & dggroups(0, rowidx).Value & "'", "ser")
                If GMod.ds.Tables("ser").Rows.Count > 0 Then
                    MsgBox("Voucher Type Can not deleted. There are some entries of that voucher", MsgBoxStyle.Critical, "Error")
                Else
                    GMod.SqlExecuteNonQuery(sqldelete)
                    MsgBox("Voucher Type Deleted Successfully", MsgBoxStyle.Information, "Error")
                End If
            End If
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
End Class