Public Class frmBackDateChqBankBook

    Private Sub frmBackDateChqOurBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        Dim Sql As String
        Sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and Group_name in ('BANK','PARTY')"
        GMod.DataSetRet(Sql, "aclist1")
        cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadname.DisplayMember = "account_head_name"
        fillGrid()
    End Sub

    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged
        Try
            If cmbacheadcode.Text <> "" Then
                Dim sql As String
                sql = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code='" & cmbacheadcode.Text & "'"
                GMod.DataSetRet(sql, "sub_grp")
                cmbacgroup.Text = GMod.ds.Tables("sub_grp").Rows(0)(0)
                cmbacsubgroup.Text = GMod.ds.Tables("sub_grp").Rows(0)(1)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim Entryid As Integer
    Public Sub getEntryid()
        Dim sqlid As String
        sqlid = "select isnull(max(Entryid),0) + 1 from " & GMod.BANK_STATE & " where detail='BANKREC'"
        GMod.DataSetRet(sqlid, "ID")
        Entryid = Val(GMod.ds.Tables("ID").Rows(0)(0))
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        getEntryid()
        Dim sqlsave As String, paytype As String
        Dim cr, dr As Double
        If cmbDrCr.Text = "Dr" Then
            dr = Val(txtAmount.Text)
            cr = 0
        Else
            cr = Val(txtAmount.Text)
            dr = 0
        End If
        If txtChqo.Text <> "" Then
            paytype = "CHEQUE"
        Else
            paytype = "CASH"
        End If

        sqlsave = "insert into " & GMod.BANK_STATE & "(Cmp_id, Entryid, bank_acc_code, bankedate, paytype, " _
        & "detail, chddno, dramt, cramt) values ("
        sqlsave &= "'" & GMod.Cmpid & "',"
        sqlsave &= "'" & Entryid & "',"
        sqlsave &= "'" & cmbacheadcode.Text & "',"
        sqlsave &= "'" & dtvdate.Value.ToShortDateString & "',"
        sqlsave &= "'" & paytype & "',"
        sqlsave &= "'BANKREC',"
        sqlsave &= "'" & txtChqo.Text & "',"
        sqlsave &= "'" & dr.ToString & "',"
        sqlsave &= "'" & cr.ToString & "')"
        MsgBox(GMod.SqlExecuteNonQuery(sqlsave))
        btnreset_Click(sender, e)
        dtvdate.Focus()
        fillGrid()
    End Sub

    Private Sub cmbacheadname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyDown
        If e.KeyCode = Keys.Enter Then dtvdate.Focus()
    End Sub

    Private Sub dtvdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtvdate.KeyDown
        If e.KeyCode = Keys.Enter Then txtAmount.Focus()
    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyDown
        If e.KeyCode = Keys.Enter Then cmbDrCr.Focus()
    End Sub

    Private Sub cmbDrCr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDrCr.KeyDown
        If e.KeyCode = Keys.Enter Then txtChqo.Focus()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtAmount.Text = ""
        txtChqo.Text = ""
    End Sub

    Private Sub txtChqo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChqo.KeyDown
        If e.KeyCode = Keys.Enter Then btnsave.Focus()
    End Sub
    Public Sub fillGrid()
        Dim sql As String
        sql = "SELECT bank_acc_code, bankedate," _
        & "chddno, dramt, cramt,Entryid from " & GMod.BANK_STATE & " where Cmp_id='" & GMod.Cmpid & "' and detail='BANKREC'"
        GMod.DataSetRet(sql, "XX")
        dgBankBook.DataSource = GMod.ds.Tables("XX")
    End Sub
    Dim rwidx As Integer
    Private Sub dgBankBook_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgBankBook.DoubleClick
        rwidx = dgBankBook.CurrentCell.RowIndex
        cmbacheadcode.Text = dgBankBook(0, rwidx).Value
        dtvdate.Value = CDate(dgBankBook(1, rwidx).Value)
        txtChqo.Text = dgBankBook(2, rwidx).Value
        If Val(dgBankBook(3, rwidx).Value) > 0 Then
            txtAmount.Text = dgBankBook(3, rwidx).Value
            'cmbDrCr.SelectedIndex = 0
        End If

        If Val(dgBankBook(4, rwidx).Value) > 0 Then
            txtAmount.Text = dgBankBook(4, rwidx).Value
            'cmbDrCr.SelectedIndex = 1
        End If
        Entryid = Val(dgBankBook(5, rwidx).Value)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim sqldel As String
        sqldel = "delete from " & GMod.BANK_STATE & " where Entryid = " & Entryid & " and detail='BANKREC'"
        GMod.SqlExecuteNonQuery(sqldel)
        fillGrid()
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        btndelete_Click(sender, e)
        btnsave_Click(sender, e)
        fillGrid()
    End Sub
End Class