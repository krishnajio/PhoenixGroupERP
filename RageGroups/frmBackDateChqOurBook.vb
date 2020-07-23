Public Class frmBackDateChqOurBook

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
    Dim Entryid As Integer
    Public Sub getEntryid()
        Dim sqlid As String
        sqlid = "select isnull(max(Entry_id),0) + 1 from " & GMod.VENTRY & " WHERE VOU_TYPE='BANKREC'"
        GMod.DataSetRet(sqlid, "ID1")
        Entryid = Val(GMod.ds.Tables("ID1").Rows(0)(0))
    End Sub
    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged
        Try
            If cmbacheadcode.Text <> "" Then
                Dim sql As String
                sql = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code='" & cmbacheadcode.Text & "'"
                GMod.DataSetRet(sql, "sub_grp")
                cmbacgroup.Text = GMod.ds.Tables("sub_grp").Rows(0)(0)
                cmbacsubgroup.Text = GMod.ds.Tables("sub_grp").Rows(0)(1)
                fillGrid()
            End If
        Catch ex As Exception

        End Try
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
        sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, " _
        & "Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, " _
        & "Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date) values ("
        sqlsave &= "'" & GMod.Cmpid & "',"
        sqlsave &= "'" & GMod.username & "',"
        sqlsave &= "'" & Entryid & "',"
        sqlsave &= "'" & Entryid & "',"
        sqlsave &= "'BANKREC',"
        sqlsave &= "'" & dtvdate.Value.ToShortDateString & "',"
        sqlsave &= "'" & cmbacheadcode.Text & "',"
        sqlsave &= "'" & cmbacheadname.Text & "',"
        sqlsave &= "'" & dr.ToString & "',"
        sqlsave &= "'" & cr.ToString & "',"
        sqlsave &= "'" & paytype & "',"
        sqlsave &= "'" & txtChqo.Text & "',"
        sqlsave &= "'BACK DATE ',"
        sqlsave &= "'" & cmbacgroup.Text & "',"
        sqlsave &= "'" & cmbacsubgroup.Text & "',"
        sqlsave &= "'" & dtvdate.Value.ToShortDateString & "',"
        sqlsave &= "'" & dtvdate.Value.ToShortDateString & "')"
        MsgBox(GMod.SqlExecuteNonQuery(sqlsave))
        btnreset_Click(sender, e)
        fillGrid()
        dtvdate.Focus()
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
        btnsave.Enabled = True
        btnmodify.Enabled = True
        btndelete.Enabled = True
        Button2.Enabled = False
        dgimp.Visible = False
    End Sub
    Private Sub txtChqo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChqo.KeyDown
        If e.KeyCode = Keys.Enter Then btnsave.Focus()
    End Sub
    Public Sub fillGrid()
        Dim sql As String
        sql = "select Acc_head_code,Vou_date,Cheque_no,dramt,cramt,Entry_id from " & GMod.VENTRY & " where Cmp_id='" & GMod.Cmpid & "' AND vou_type='BANKREC' and acc_head_code='" & cmbacheadcode.Text & "'"
        GMod.DataSetRet(sql, "XX1")
        dgOurBook.DataSource = GMod.ds.Tables("XX1")
    End Sub
    Dim rwidx As Integer
    Private Sub dgOurBook_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgOurBook.DoubleClick
        Try
            rwidx = dgOurBook.CurrentCell.RowIndex
            cmbacheadcode.Text = dgOurBook(0, rwidx).Value
            dtvdate.Value = CDate(dgOurBook(1, rwidx).Value)
            txtChqo.Text = dgOurBook(2, rwidx).Value
            If Val(dgOurBook(3, rwidx).Value) > 0 Then
                txtAmount.Text = dgOurBook(3, rwidx).Value
                'cmbDrCr.SelectedIndex = 0
            End If
            If Val(dgOurBook(4, rwidx).Value) > 0 Then
                txtAmount.Text = dgOurBook(4, rwidx).Value
                'cmbDrCr.SelectedIndex = 1
            End If
            Entryid = Val(dgOurBook(5, rwidx).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim sqldel As String
        sqldel = "delete from " & GMod.VENTRY & " where vou_no = " & Entryid & " and Vou_type='BANKREC'"
        GMod.SqlExecuteNonQuery(sqldel)
        fillGrid()
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        btndelete_Click(sender, e)
        btnsave_Click(sender, e)
        fillGrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fileopen.ShowDialog()
        Dim apex As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim sr, dt, narration, chqno, dr, cr, bal, drcr As String
        wb = apex.Workbooks.Open(fileopen.FileName)
        ws = apex.Worksheets(1)
        Dim vno As Long
        GMod.DataSetRet("select isnull(max(vou_no),0)+1 from " & GMod.VENTRY & " where vou_type='BANKREC'", "nxtvno")
        vno = GMod.ds.Tables("nxtvno").Rows(0)(0)
        Dim i As Integer = 2
        Dim dt1() As String
        Dim l As String = "Y"
        dgimp.Rows.Clear()
        While l = "Y"
            dt = ws.Range("a" & i).Value
            If Len(dt) > 0 Then
                dgimp.Rows.Add()
                dgimp(0, i - 2).Value = vno
                dt1 = dt.Split("-")
                dgimp(1, i - 2).Value = dt1(0) & "/" & dt1(1) & "/" & dt1(2)
                dgimp(2, i - 2).Value = ws.Range("b" & i).Value
                If Val(ws.Range("e" & i).Value) > 0 Then
                    dgimp(3, i - 2).Value = ws.Range("e" & i).Value
                    dgimp(4, i - 2).Value = 0
                Else
                    dgimp(3, i - 2).Value = 0
                    dgimp(4, i - 2).Value = Math.Abs(ws.Range("e" & i).Value)
                End If
                dgimp(5, i - 2).Value = ws.Range("d" & i).Value
                i = i + 1
                vno = vno + 1
            Else
                l = "N"
            End If
        End While
        wb.Close()
        dgimp.Visible = True
        btnsave.Enabled = False
        btnmodify.Enabled = False
        btndelete.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim sqlsave, sqlchq, res, paymod, dt1() As String
        Dim dt As Date

        GMod.SqlExecuteNonQuery("delete from " & GMod.VENTRY & " where narration='BACK DATE IMPORT' and acc_head_code='" & cmbacheadcode.Text & "'")
        GMod.SqlExecuteNonQuery("delete from " & GMod.CHQ_ISSUED & " where rect_typr='BACK' and bankacc_code='" & cmbacheadcode.Text & "'")
        For i = 0 To dgimp.Rows.Count - 1
            If Len(dgimp(2, i).Value) > 0 Then
                paymod = "CHEQUE"
            Else
                paymod = "CASH"
            End If
            dt1 = dgimp(1, i).Value.ToString.Split("/")
            dt = dt1(1) & "/" & dt1(0) & "/" & dt1(2)
            sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, " _
            & "Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, " _
            & "Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date) values ("
            sqlsave &= "'" & GMod.Cmpid & "',"
            sqlsave &= "'" & GMod.username & "',"
            sqlsave &= "'" & dgimp(0, i).Value & "',"
            sqlsave &= "'" & dgimp(0, i).Value & "',"
            sqlsave &= "'BANKREC',"
            sqlsave &= "'" & dt.ToShortDateString & "',"
            sqlsave &= "'" & cmbacheadcode.Text & "',"
            sqlsave &= "'" & cmbacheadname.Text & "',"
            sqlsave &= "'" & dgimp(3, i).Value & "',"
            sqlsave &= "'" & dgimp(4, i).Value & "',"
            sqlsave &= "'" & paymod & "',"
            sqlsave &= "'" & dgimp(2, i).Value & "',"
            sqlsave &= "'BACK DATE IMPORT',"
            sqlsave &= "'" & cmbacgroup.Text & "',"
            sqlsave &= "'" & cmbacsubgroup.Text & "',"
            sqlsave &= "'1900-1-1',"
            sqlsave &= "'1900-1-1')"
            res = GMod.SqlExecuteNonQuery(sqlsave)
            ''cheque for the cheque issue
            If dgimp(5, i).Value.ToString.Contains("Client") Then

                'Record has to bet store in Cheque issued table
                'Cmp_id, Receipt_id, Issue_date, Chq_date, Cheque_no, BankAcc_code, Amount, 
                'Dd_Charge_per, Dd_charge, Service_tax, Receipt_amt, party_code, party_name, 
                'final_date, favourof, VouNo, stop_bounce, Rect_type, Remark, IsPrinted

                sqlchq = "insert into " & GMod.CHQ_ISSUED & "(cmp_id,issue_date,chq_date,cheque_no,bankacc_code," _
                & "amount,stop_bounce,Rect_type) values('" & GMod.Cmpid & "','" & dt.ToShortDateString & "'," _
                & "'" & dt.ToShortDateString & "','" & dgimp(2, i).Value & "','" & cmbacheadcode.Text & "'," _
                & "'" & Val(dgimp(4, i).Value) & "','F','BACK')"
                res = GMod.SqlExecuteNonQuery(sqlchq)
            End If

            If res <> "SUCCESS" Then MsgBox(res)
        Next
        MsgBox("Data Import Successfully", MsgBoxStyle.Information)
        btnsave.Enabled = True
        btnmodify.Enabled = True
        btndelete.Enabled = True
        Button2.Enabled = False
        dgimp.Visible = False
    End Sub
End Class