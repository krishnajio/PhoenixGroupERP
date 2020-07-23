Public Class frmChequeReport

    Private Sub frmChequeReport_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub frmChequeReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "ChequeReport" & "    " & "[" & GMod.Cmpname & "]"
        ''cmborderby.SelectedIndex = 0
        'GMod.DataSetRet("select account_head_name,account_code from " & GMod.ACC_HEAD & "", "heads")
        'cmbname.DataSource = GMod.ds.Tables("heads")
        'cmbname.DisplayMember = "account_head_name"

        'cmbcode.DataSource = GMod.ds.Tables("heads")
        'cmbcode.DisplayMember = "account_code"
        dgChequeReport.Height = Me.Height - 150
        dtissuefrom.Value = CDate("1/1/1900")
        dtissueto.Value = CDate("1/1/1900")
        dtchqfrom.Value = CDate("1/1/1900")
        dtchqto.Value = CDate("1/1/1900")
        GMod.DataSetRet("select * from " & GMod.ACC_HEAD & " where group_name='BANK'", "bk")
        Dim i As Integer
        cmbacheadcode.Items.Add("Any")
        cmbacheadname.Items.Add("Any")
        For i = 0 To GMod.ds.Tables("bk").Rows.Count - 1
            cmbacheadcode.Items.Add(GMod.ds.Tables("bk").Rows(i)("account_code"))
            cmbacheadname.Items.Add(GMod.ds.Tables("bk").Rows(i)("account_head_name"))
        Next
        cmbacheadcode.SelectedIndex = 0
        cmbacheadname.SelectedIndex = 0
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql, qr As String
        qr = ""
        sql = " select issue_date,chq_date,cheque_no,receipt_id,party_name," _
        & "amount,bankacc_code,account_head_name,favourof,final_date,stop_bounce,dd_charge,service_tax" _
        & " from " & GMod.CHQ_ISSUED & " chqissue," & GMod.ACC_HEAD & " chqhead  "
        qr = " account_code=bankacc_code"
        If txtchqno.Text <> "" Then
            qr &= " and Cheque_no = '" & txtchqno.Text & "'"
        End If
        If txtname.Text <> "" Then
            If qr.Length > 0 Then
                qr &= " and party_name like '%" & txtname.Text & "%'"
            Else
                qr &= " party_name like '%" & txtname.Text & "%'"
            End If
        End If
        If txtfavourof.Text <> "" Then
            If qr.Length > 0 Then
                qr &= " and favourof like '%" & txtfavourof.Text & "%'"
            Else
                qr &= " favourof like '%" & txtfavourof.Text & "%'"
            End If
        End If

        If cmbacheadcode.Text <> "Any" Then
            If qr.Length > 0 Then
                qr &= " and bankacc_code = '" & cmbacheadcode.Text & "'"
            Else
                qr &= " bankacc_code = '" & cmbacheadcode.Text & "'"
            End If
        End If

        If dtchqfrom.Text <> "01/Jan/1900" And dtchqto.Text <> "01/Jan/1900" Then
            If qr.Length > 0 Then
                qr &= " and chq_date between '" & dtchqfrom.Value.ToShortDateString & "' and '" & dtchqto.Value.ToShortDateString & "'"
            Else
                qr &= " chq_date between '" & dtchqfrom.Value.ToShortDateString & "' and '" & dtchqto.Value.ToShortDateString & "'"
            End If
        End If

        If dtissuefrom.Text <> "01/Jan/1900" And dtissueto.Text <> "01/Jan/1900" Then
            If qr.Length > 0 Then
                qr &= " and issue_date between '" & dtissuefrom.Value.ToShortDateString & "' and '" & dtissueto.Value.ToShortDateString & "'"
            Else
                qr &= " issue_date between '" & dtissuefrom.Value.ToShortDateString & "' and '" & dtissueto.Value.ToShortDateString & "'"
            End If
        End If
        If qr.Length > 0 Then
            sql = sql & " where " & qr
        Else
            sql = sql
        End If
        Try
            GMod.DataSetRet(sql, "chqdata")
            Dim i As Integer
            If dgChequeReport.Rows.Count > 0 Then dgChequeReport.Rows.Clear()
            For i = 0 To GMod.ds.Tables("chqdata").Rows.Count - 1
                dgChequeReport.Rows.Add()
                dgChequeReport(0, i).Value = GMod.ds.Tables("chqdata").Rows(i)("issue_date")
                dgChequeReport(1, i).Value = GMod.ds.Tables("chqdata").Rows(i)("chq_date")
                dgChequeReport(2, i).Value = GMod.ds.Tables("chqdata").Rows(i)("cheque_no")
                dgChequeReport(3, i).Value = GMod.ds.Tables("chqdata").Rows(i)("receipt_id")
                dgChequeReport(4, i).Value = GMod.ds.Tables("chqdata").Rows(i)("party_name")
                dgChequeReport(5, i).Value = GMod.ds.Tables("chqdata").Rows(i)("amount")
                dgChequeReport(6, i).Value = GMod.ds.Tables("chqdata").Rows(i)("bankacc_code")
                dgChequeReport(7, i).Value = GMod.ds.Tables("chqdata").Rows(i)("account_head_name")
                dgChequeReport(8, i).Value = GMod.ds.Tables("chqdata").Rows(i)("favourof")
                dgChequeReport(9, i).Value = GMod.ds.Tables("chqdata").Rows(i)("final_date")
                dgChequeReport(10, i).Value = GMod.ds.Tables("chqdata").Rows(i)("stop_bounce")
                dgChequeReport(11, i).Value = GMod.ds.Tables("chqdata").Rows(i)("dd_charge")
                dgChequeReport(12, i).Value = GMod.ds.Tables("chqdata").Rows(i)("service_tax")
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim chqno As String
            If vbYes = MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) Then
                Dim sql, sql1, sql2 As String
                chqno = dgChequeReport(2, dgChequeReport.CurrentCell.RowIndex).Value
                sql = "Select isprinted from " & GMod.CHQ_ISSUED & " where cheque_no='" & chqno & "'"
                GMod.DataSetRet(sql, "print")
                If GMod.ds.Tables("print").Rows(0)(0) = "P" Then
                    MsgBox("Printed Cheque can not be deleted", MsgBoxStyle.Information, "Information")
                    Exit Sub
                End If
                Dim sqltrans As SqlClient.SqlTransaction
                sqltrans = GMod.SqlConn.BeginTransaction

                Try
                    sql1 = "delete from " & GMod.CHQ_ISSUED & " where cheque_no='" & chqno & "'"
                    Dim cmd1 As New SqlClient.SqlCommand(sql1, GMod.SqlConn, sqltrans)
                    cmd1.ExecuteNonQuery()

                    sql2 = "delete from " & GMod.VENTRY & " where cheque_no='" & chqno & "'"
                    Dim cmd2 As New SqlClient.SqlCommand(sql2, GMod.SqlConn, sqltrans)
                    cmd2.ExecuteNonQuery()
                    sqltrans.Commit()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    sqltrans.Rollback()
                End Try
                btnsave_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgChequeReport_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgChequeReport.CellContentClick

    End Sub

    Private Sub dgChequeReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgChequeReport.KeyDown
        If e.KeyCode = Keys.Delete Then
            Button2_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sqlupdate As String
        Dim ivar, r As Integer
        r = dgChequeReport.CurrentCell.RowIndex
        GMod.SqlExecuteNonQuery("delete from tmp_multiple_chq where uname='" & GMod.username & "'")
        GMod.DataSetRet("select * from dbo.chqLayout where acc_head_code='" & dgChequeReport(5, r).Value & "'", "ChqLayout")
        If GMod.ds.Tables("ChqLayout").Rows.Count > 0 Then
            Dim i As Integer = 0
            Try
                GMod.SqlExecuteNonQuery("insert into tmp_multiple_chq(Cmp_id, Chq_no, favourof, recpitid, amount, Chq_date, Uname) select Cmp_id, Cheque_no,favourof,Receipt_id,Amount,Chq_date,'" & GMod.username & "' from " & GMod.CHQ_ISSUED & " where cheque_no='" & dgChequeReport(2, r).Value & "' and bankacc_code='" & dgChequeReport(5, r).Value & "'")
                GMod.DataSetRet("select * from tmp_multiple_chq where uname='" & GMod.username & "'", "chqdet")
                GMod.DataSetRet("select * from chqlayout where acc_head_code='" & dgChequeReport(5, r).Value & "'", "chq")
                chqprintpreview.Document = chqdocument
                For ivar = 0 To GMod.ds.Tables("chqdet").Rows.Count - 1
                    If MessageBox.Show("Do U want to print cheque" & "(" & ivar + 1 & ")" & "St Cheque", "Print", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        chqdocument.DefaultPageSettings = chqsetup.PageSettings
                        ' Dim customPaperSize As New Printing.PaperSize("8x10", Val(GMod.ds.Tables("chq").Rows(0)("cqhh")), Val(GMod.ds.Tables("chq").Rows(0)("chqw")))
                        chqdocument.Print()
                        sqlupdate = "update " & GMod.CHQ_ISSUED & " set IsPrinted = 'P' where Cheque_no='" & GMod.ds.Tables("chqdet").Rows(ivar)("Chq_no").ToString & "'"
                        GMod.SqlExecuteNonQuery(sqlupdate)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'Disabling buttons
        Else
            MsgBox("Please Save Cheque Layuot for this bank", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged
        cmbacheadname.SelectedIndex = cmbacheadcode.SelectedIndex
    End Sub

    Private Sub cmbacheadname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadname.SelectedIndexChanged
        cmbacheadcode.SelectedIndex = cmbacheadname.SelectedIndex
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sql As String, up As String
        Dim ddInc As New DataSet
        Dim i As Integer
        sql = "select Cheque_no,BankAcc_code,Amount from CHQ_ISSUED_RAFI_0809 order by Receipt_id"
        Dim da As New SqlClient.SqlDataAdapter(sql, GMod.Connstr)
        da.Fill(ddInc)
        Try

       
            For i = 0 To ddInc.Tables(0).Rows.Count - 1
                'nxtrecid()
                rectid = Format(i + 1, "0000000000")
                up = "update CHQ_ISSUED_RAFI_0809 set Receipt_id='" & rectid & "'" _
                     & "  where Rect_type='CASH' and Cheque_no='" & ddInc.Tables(0).Rows(i)(0) & "' and BankAcc_code='" & ddInc.Tables(0).Rows(i)(1) & "' and Amount=" & Val(ddInc.Tables(0).Rows(i)(2))
                GMod.SqlExecuteNonQuery(up)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim rectid As String
   
End Class