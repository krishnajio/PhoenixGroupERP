Public Class frmChequaAllotuser
    Private Sub frmChequaAllotuser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub
    Private Sub frmChequaAllotuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        'Cmp_id, U_name, Bank_acc_head, Ch_no_from, Ch_no_to, Ch_allot_date, Chq_remain
        'fill bank account head
        GMod.DataSetRet("select *  from " & GMod.CHQBOOK & " where isavailable='Y'", "bankacchead")
        cmbacchead.DataSource = GMod.ds.Tables("bankacchead")
        cmbacchead.DisplayMember = "acc_head"

        cmbacccode.DataSource = GMod.ds.Tables("bankacchead")
        cmbacccode.DisplayMember = "acc_head_code"

        Dim sql As String
        sql = "select uname from cmp_assignment where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "user")
        cmbuser.DataSource = GMod.ds.Tables("user")
        cmbuser.DisplayMember = "uname"
        fillgrid()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtchqnofrom.Text = "" Or txtchqnoto.Text = "" Then
            MsgBox("Please type Cheque Details", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim sql, s As String
        Dim no_of_chq As Integer
        Dim sqltrans As SqlClient.SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction
        Try
            Dim ddno, zero, lcno As String
            Dim i, l As Integer
            ddno = txtchqnofrom.Text
            ' MsgBox(ddno)
            l = txtchqnofrom.Text.Length
            For i = 0 To l - 1
                zero = zero + "0"
            Next
            lcno = Format(Val(ddno) - 1, zero)

            no_of_chq = (Val(txtchqnoto.Text) - Val(txtchqnofrom.Text)) + 1
            sql = "insert into " & GMod.CHQ_ALLOT & "(Cmp_id, U_name, Bank_acc_head, Ch_no_from, Ch_no_to, Ch_allot_date, Chq_remain, last_che,book_no) "
            sql += " values('" & GMod.Cmpid & "','" & cmbuser.Text & "','" & cmbacccode.Text & "',"
            sql += "'" & txtchqnofrom.Text & "','" & txtchqnoto.Text & "','" & dtIssuedate.Value.ToShortDateString & "'," & no_of_chq & ",'" & lcno & "','" & cmbbookno.Text & "')"
            'MsgBox(sql)
            Dim cmd1 As New SqlClient.SqlCommand(sql, SqlConn, sqltrans)
            cmd1.ExecuteNonQuery()
            sql = "update " & GMod.CHQBOOK & " set isavailable='N' where book_no='" & cmbbookno.Text & "' and acc_head_code='" & cmbacccode.Text & "'"
            Dim cmd2 As New SqlClient.SqlCommand(sql, SqlConn, sqltrans)
            cmd2.ExecuteNonQuery()
            sqltrans.Commit()
            btnreset_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
            sqltrans.Rollback()
        End Try
        
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtchqnofrom.Text = ""
        txtchqnoto.Text = ""
        btnsave.Enabled = True
        btnmodify.Text = "Modify"
        DataGridView1.Enabled = True
        fillgrid()
        GMod.DataSetRet("select *  from " & GMod.CHQBOOK & " where isavailable='Y'", "bankacchead")
        cmbacchead.DataSource = GMod.ds.Tables("bankacchead")
        cmbacchead.DisplayMember = "acc_head"

        cmbacccode.DataSource = GMod.ds.Tables("bankacchead")
        cmbacccode.DisplayMember = "acc_head_code"
    End Sub
    Sub fillgrid()
        GMod.DataSetRet("select * from " & GMod.CHQ_ALLOT & " where u_name='" & cmbuser.Text & "'", "chq")
        Dim i As Integer
        DataGridView1.Rows.Clear()
        For i = 0 To GMod.ds.Tables("chq").Rows.Count - 1
            DataGridView1.Rows.Add()
            DataGridView1(0, i).Value = GMod.ds.Tables("chq").Rows(i)("Bank_acc_head")
            DataGridView1(1, i).Value = GMod.ds.Tables("chq").Rows(i)("Ch_no_from")
            DataGridView1(2, i).Value = GMod.ds.Tables("chq").Rows(i)("Ch_no_to")
            DataGridView1(3, i).Value = GMod.ds.Tables("chq").Rows(i)("Ch_allot_date")
            DataGridView1(4, i).Value = GMod.ds.Tables("chq").Rows(i)("Chq_remain")
            DataGridView1(5, i).Value = GMod.ds.Tables("chq").Rows(i)("U_name")
            DataGridView1(6, i).Value = GMod.ds.Tables("chq").Rows(i)("Book_No")
        Next
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            'If Val(DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value) - Val(DataGridView1(2, DataGridView1.CurrentCell.RowIndex).Value) + 1 <> Val(DataGridView1(3, DataGridView1.CurrentCell.RowIndex).Value) Then
            '    MsgBox("Can Not Modify. Cheques are Issued from this issue", MsgBoxStyle.Critical, "Error")
            '    Exit Sub
            'End If
            cmbacchead.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            txtchqnofrom.Text = DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value
            txtchqnoto.Text = DataGridView1(2, DataGridView1.CurrentCell.RowIndex).Value
            dtIssuedate.Value = DataGridView1(3, DataGridView1.CurrentCell.RowIndex).Value
            cmbbookno.Text = DataGridView1(6, DataGridView1.CurrentCell.RowIndex).Value
            cmbuser.Text = DataGridView1(5, DataGridView1.CurrentCell.RowIndex).Value
            btnsave.Enabled = False
            btnmodify.Text = "&Update"
            DataGridView1.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        'Cmp_id, U_name, Bank_acc_head, Ch_no_from, Ch_no_to, Ch_allot_date, Chq_remain
        If btnsave.Enabled Then
            MsgBox("Double click on the list", MsgBoxStyle.Information)
        Else
            MsgBox(DataGridView1(2, DataGridView1.CurrentCell.RowIndex).Value())
            Dim sqlupdate As String
            sqlupdate = "update " & GMod.CHQ_ALLOT & " set "
            sqlupdate &= " Bank_acc_head=" & "'" & cmbacccode.Text & "',"
            sqlupdate &= " Ch_no_from=" & "'" & txtchqnofrom.Text & "',"
            sqlupdate &= " Ch_no_to=" & "'" & txtchqnoto.Text & "',"
            sqlupdate &= " Ch_allot_date=" & "'" & dtIssuedate.Value & "',"
            sqlupdate &= " where  Uname=" & "'" & GMod.username & "'"
            sqlupdate &= " and  Ch_no_from=" & "'" & DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value & "'"
            sqlupdate &= " and  Ch_no_to=" & "'" & DataGridView1(2, DataGridView1.CurrentCell.RowIndex).Value & "'"
        End If
    End Sub
    Private Sub cmbbookno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbookno.SelectedIndexChanged
        GMod.DataSetRet("select * from " & GMod.CHQBOOK & " where book_no='" & cmbbookno.Text & "' and acc_head_code='" & cmbacccode.Text & "'", "ser")
        If GMod.ds.Tables("ser").Rows.Count > 0 Then
            txtchqnofrom.Text = ds.Tables("ser").Rows(0)("Cheque_no_from")
            txtchqnoto.Text = ds.Tables("ser").Rows(0)("Cheque_no_to")
        End If
    End Sub
    Private Sub cmbuser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbuser.SelectedIndexChanged
        fillgrid()
    End Sub
    Private Sub cmbacccode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacccode.SelectedIndexChanged
        GMod.DataSetRet("select * from " & GMod.CHQBOOK & " where acc_head_code='" & cmbacccode.Text & "'", "cbook")
        cmbbookno.DataSource = GMod.ds.Tables("cbook")
        cmbbookno.DisplayMember = "book_no"
        cmbbookno_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBox("Are u sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim sqldel As String
            sqldel = "delete from " & GMod.CHQ_ALLOT & " where  U_name='" & cmbuser.Text & "' and Book_No=" & cmbbookno.Text _
            & " and Bank_acc_head='" & cmbacccode.Text & "'"
            GMod.SqlExecuteNonQuery(sqldel)
            sqldel = "update " & GMod.CHQBOOK & " set isavailable='Y' where Book_no=" & cmbbookno.Text
            MsgBox(GMod.SqlExecuteNonQuery(sqldel))
            fillgrid()
        End If
    End Sub
End Class