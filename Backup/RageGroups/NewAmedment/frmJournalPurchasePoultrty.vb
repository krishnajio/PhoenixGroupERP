Imports System.Data.SqlClient
Public Class frmJournalPurchasePoultrty
    Dim ach As New frmacheadlist

    Private Sub dgvoucher_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellEndEdit
        Dim st, h() As String
        If e.ColumnIndex = 1 Then
            If Len(dgvoucher(1, e.RowIndex).Value) = 0 Then
                ach.ShowDialog()
                ach.cmbAreaCode.Text = "**"
                ach.cmbgroup.Text = "PURCHASE"
                ach.ShowDialog()
                st = ach.cmbacheadlist.Text
                h = st.Split("[")
                dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
                h = h(1).Split("]")
                dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
                'ach.Dispose()
                Exit Sub
            Else
                Dim sqlacc As String
                sqlacc = "select account_code from " & GMod.ACC_HEAD & " where account_code='" & dgvoucher(1, e.RowIndex).Value & "'"
                GMod.DataSetRet(sqlacc, "Count")
                If GMod.ds.Tables("Count").Rows.Count > 0 Then

                Else
                    ach.ShowDialog()
                    st = ach.cmbacheadlist.Text
                    h = st.Split("[")
                    dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
                    h = h(1).Split("]")
                    dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
                    Exit Sub
                End If
                GMod.ds.Tables("Count").Clear()
            End If
        End If
        If e.ColumnIndex = 3 Then
            gridtotal()
        End If
    End Sub
    Dim sql As String
    Private Sub dgvoucher_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellLeave
        Try
            Dim s, st, h() As String
            s = dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value
            If e.ColumnIndex = 1 And String.IsNullOrEmpty(s) Then
                ach.cmbAreaCode.Text = "**"
                ach.cmbgroup.Text = "PURCHASE"
                ach.ShowDialog()

                st = ach.cmbacheadlist.Text.ToUpper
                h = st.Split("[")
                dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
                h = h(1).Split("]")
                dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
            ElseIf e.ColumnIndex = 2 Then
                '    sql = "select rate  from Purchase_Data where bill_date = ( " & _
                '          " select max(bill_date) from dbo.Purchase_Data " & _
                '          " where item_code='" & dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value & "') and  item_code='" & dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value & "'"
                '    GMod.DataSetRet(sql, "lstrate")
                '    dgvoucher(7, dgvoucher.CurrentCell.RowIndex).Value = GMod.ds.Tables("lstrate").Rows(0)(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub nxtvno()
        Dim sql As String
        Try
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & voutype.Text & "'"
            GMod.DataSetRet(sql, "vno8")
            lblvouno.Text = ds.Tables("vno8").Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub fillheads()

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and Group_name  in ('PARTY','INTERNAL PARTY')"
        GMod.DataSetRet(sql, "aclist4")
        cmbacheadcode.DataSource = GMod.ds.Tables("aclist4")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist4")
        cmbacheadname.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclist4")
        ComboBox1.DisplayMember = "group_name"

        cmbSubGroup.DataSource = GMod.ds.Tables("aclist4")
        cmbSubGroup.DisplayMember = "sub_group_name"

    End Sub
    Public Sub SetLastVouDate()
        Dim sql As String
        sql = "select * from  LastVouDate"
        GMod.DataSetRet(sql, "LastVouDate")
        If GMod.ds.Tables("LastVouDate").Rows.Count > 0 Then
            sql = "update LastVouDate set last_vou_date='" & dtVdate.Value.ToShortDateString & "' where Uname='" & GMod.username & "'"
            GMod.SqlExecuteNonQuery(sql)
        Else
            sql = "insert into LastVouDate values('" & dtvdate.Value.ToShortDateString & "','" & GMod.username & "')"
            GMod.SqlExecuteNonQuery(sql)
        End If
        GMod.ds.Tables("LastVouDate").Clear()
    End Sub

    Private Sub frmPurchasePoultrty_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='P' and cmp_id='" & GMod.Cmpid & "'")

    End Sub

    Private Sub frmPurchasePoultrty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$4 Resting date
        GMod.DataSetRet("select getdate()", "serverdate")
        ' dtVdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        dtVdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

        'filling production unit 
        GMod.DataSetRet("select prdunit from prdunit where cmp_id='" & GMod.Cmpid & "'", "prdunit")
        cmbPrdUnit.DataSource = GMod.ds.Tables("prdunit")
        cmbPrdUnit.DisplayMember = "prdunit"


        GMod.DataSetRet("select vtype from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%PUR JOURNAL%' and vtype NOT like '%BANK%'", "vt")
        voutype.DataSource = GMod.ds.Tables("vt")
        voutype.DisplayMember = "vtype"

        Me.dtpdate.Value = CDate("1/1/2000")
        Label6.Text = "JOURNAL PURCHASE - " + GMod.Cmpname

        sql = "select * from TdsMater where cmp_id ='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "tdm")

        cmbtdsType.DataSource = GMod.ds.Tables("tdm")
        cmbtdsType.DisplayMember = "TdsType"


        cmbTdsper.DataSource = GMod.ds.Tables("tdm")
        cmbTdsper.DisplayMember = "Per"

        cmbacheadcodetds.DataSource = GMod.ds.Tables("tdm")
        cmbacheadcodetds.DisplayMember = "Acc_Code"


        GetLastVouDate()
        dgvoucher.Rows.Add()
        ' nxtvno()
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        fillheads()
        If GMod.role.ToString <> "ADMIN" Then
            ' btn_modify.Enabled = False
        End If

        If GMod.Getsession(dtVdate.Value) = GMod.Session Then

        Else
            Me.Close()
        End If
    End Sub
    Public Sub GetLastVouDate()
        Dim sql As String
        sql = "select last_vou_date from LastVouDate where  Uname='" & GMod.username & "'"
        GMod.DataSetRet(sql, "LastVouDate")
        If GMod.ds.Tables("LastVouDate").Rows.Count > 0 Then
            dtVdate.Value = CDate(GMod.ds.Tables("LastVouDate").Rows(0)(0))
        End If
        GMod.ds.Tables("LastVouDate").Clear()
    End Sub
    Private Sub dgvoucher_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvoucher.KeyUp
        If e.KeyCode = Keys.Enter Then
            If dgvoucher.CurrentCell.ColumnIndex < dgvoucher.ColumnCount - 1 Then
                'SendKeys.Send("{Tab}")
                dgvoucher.CurrentCell = dgvoucher(dgvoucher.CurrentCell.ColumnIndex + 1, dgvoucher.CurrentCell.RowIndex)

            Else
                dgvoucher.Rows.Add()
                dgvoucher.CurrentCell = dgvoucher(0, dgvoucher.CurrentCell.RowIndex + 1)
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            'btnsave_Click(sender, e)
        End If
    End Sub
    Private Sub dgvoucher_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.RowEnter
        Dim r, pr As Integer
        r = e.RowIndex
        If r = 0 Then
            dgvoucher(0, r).Value = 1
        Else
            pr = r - 1
            dgvoucher(0, r).Value = dgvoucher(0, pr).Value + 1
        End If
        'sumdrcr()
    End Sub
    Sub ckechEntyValues()

    End Sub
    Dim chgFlag As Boolean = False
    Dim vat, cst, fr, tds, total As Double
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            'for Payment date
            'Dim pd As New frmPaymentDatePopUp
            'pd.ShowDialog()


            If Val(txtTotal.Text) <> -Val(txtFreight.Text) + Val(txtVat.Text) + Val(txtcstamt.Text) - Val(txtTDSamt.Text) + totgridamount Then
                MessageBox.Show("Calculation Mistake Please Review Data", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Exit Sub
            End If

            If ChkCform.Checked = True Then
                cform = 1
            Else
                cform = 0
            End If
            If voutype.Text = "" Then
                MsgBox("Please Select voucher Type")
                voutype.Focus()
                Exit Sub
            End If

            If txtBillNo.Text = "" Then
                MsgBox("Please Enter Bill No")
                txtBillNo.Focus()
                Exit Sub
            End If
            If txtPoNo.Text = "" Then
                MsgBox("Please Enter Purchase Order No")
                txtPoNo.Focus()
                Exit Sub
            End If
            If txtImwno.Text = "" Then
                MsgBox("Please Enter Inward No")
                txtImwno.Focus()
                Exit Sub
            End If

            If Val(txtTotal.Text) = 0 Then
                Me.Close()
                Exit Sub
            End If
            PaymentDate = Me.dtpdate.Value

            If btnsave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, lblvouno.Text, voutype.Text, dtVdate.Value, Now, GMod.Session, "M", GMod.username)
            End If
            GetLastVouDate()
            Dim sqlsave As String, i As Integer, sql, g, s As String
            Dim sqltrans As SqlTransaction
            Dim narration, narr As String
            sqltrans = GMod.SqlConn.BeginTransaction
            narration = "BILL NO " & txtBillNo.Text.Trim() & " DT." & dtbilldate.Text & "#" & cmbferhead.Text
            Try
                If btnsave.Enabled = False Then
                    Dim sqldel As String
                    sqldel = "delete from " & GMod.VENTRY & " where Vou_type='" & voutype.Text & "' and Vou_no= " & lblvouno.Text
                    Dim cmddel1 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmddel1.ExecuteNonQuery()

                    sqldel = "delete  from purchase_data where  Vou_no= '" & lblvouno.Text & "' and Vou_type='" & voutype.Text & "' and Cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                    Dim cmddel2 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmddel2.ExecuteNonQuery()

                    sql = "delete from Purchase_Payment where vou_type='" & voutype.Text & "' and  vou_no='" & lblvouno.Text & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    Dim cmddel As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmddel.ExecuteNonQuery()


                    sql = "delete from TdsEntry where vou_type='" & voutype.Text & "' and  vou_no='" & lblvouno.Text & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    Dim cmddeltds As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmddeltds.ExecuteNonQuery()

                Else
                    nxtvno()
                End If

                vat = Val(txtVat.Text)
                cst = Val(txtcstamt.Text)
                fr = Val(txtFreight.Text)
                tds = Val(txtTDSamt.Text)
                total = Val(txtTotal.Text)

                For i = 0 To dgvoucher.Rows.Count - 1
                    'SALE A/C Dr
                    'Getting Group name 
                    sql = "select group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_code='" & dgvoucher(1, i).Value & "'"
                    GMod.DataSetRet(sql, "heads")
                    g = GMod.ds.Tables("heads").Rows(0)("group_name").ToString
                    s = GMod.ds.Tables("heads").Rows(0)("sub_group_name").ToString
                    GMod.ds.Tables("heads").Dispose()
                    If g = "PARTY" Then
                        MsgBox("Please select correct head", MsgBoxStyle.Exclamation)
                        ' Exit Sub
                    End If

                    'narr = narr & dgvoucher(2, i).Value & " " & dgvoucher(4, i).Value & " " & dgvoucher(5, i).Value & " @" & dgvoucher(6, i).Value & ","
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                  & " Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " _
                  & "Narration, Group_name, Sub_group_name,Ch_issue_date,ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'-4',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & voutype.Text & "',"
                    sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & dgvoucher(1, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(2, i).Value & "',"
                    sqlsave &= "'" & Val(dgvoucher(3, i).Value) & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narration & "',"
                    sqlsave &= "'" & g & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & PaymentDate.ToShortDateString & "',"
                    sqlsave &= "'" & dtbilldate.Value.ToShortDateString & "')"
                    Dim cmd3 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd3.ExecuteNonQuery()

                    If i > 0 Then
                        chgFlag = True
                        txtVat.Text = 0
                        txtcstamt.Text = 0
                        txtFreight.Text = 0
                        txtTDSamt.Text = 0
                        txtTotal.Text = 0
                    End If


                    sqlsave = "insert into Purchase_Data ( For_where, Bill_no, Bill_date,vou_type, vou_no, " & _
                    " vou_date, party_code, item_code, item_name, rate, lst_rate, qty, " & _
                    " unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno, " & _
                    " cmp_id, session, username,amt, party_amt, inwdate," & _
                    " vathead, csthead, cst_code, cst_amt, porate,fr_head,cform,po_date, form49No, form49issue)  values ( "
                    sqlsave &= "'" & cmbPrdUnit.Text & "',"
                    sqlsave &= "'" & txtBillNo.Text & "',"
                    sqlsave &= "'" & dtbilldate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & voutype.Text & "',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbacheadcode.Text & "',"
                    sqlsave &= "'" & dgvoucher(1, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(2, i).Value & "',"
                    sqlsave &= "'" & Val(dgvoucher(6, i).Value) & "',"
                    sqlsave &= "'" & Val(dgvoucher(7, i).Value) & "',"
                    sqlsave &= "'" & Val(dgvoucher(4, i).Value) & "',"
                    sqlsave &= "'" & dgvoucher(5, i).Value & "',"
                    sqlsave &= "'" & cmbvatcode.Text & "',"
                    sqlsave &= "'" & Val(txtVat.Text) & "',"
                    sqlsave &= "'" & cmbfercode.Text & "',"
                    sqlsave &= "'" & Val(txtFreight.Text) & "',"
                    sqlsave &= "'" & txtPoNo.Text & "',"
                    sqlsave &= "'" & txtImwno.Text & "',"
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.Session & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'" & Val(dgvoucher(3, i).Value) & "',"
                    sqlsave &= "'" & Val(txtTotal.Text) & "',"
                    sqlsave &= "'" & dtpInwdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbvathead.Text & "',"
                    sqlsave &= "'" & cmbcsthead.Text & "',"
                    sqlsave &= "'" & cmbcstcode.Text & "',"
                    sqlsave &= "'" & Val(txtcstamt.Text) & "',"
                    sqlsave &= "'" & Val(dgvoucher(8, i).Value) & "',"
                    sqlsave &= "'" & narration & "',"
                    sqlsave &= "'" & cform.ToString & "',"
                    sqlsave &= "'" & dtpdate.Value.ToShortTimeString & "',"
                    sqlsave &= "'" & txtform49no.Text & "',"
                    sqlsave &= "'" & dtpf49issuedate.Text & "')"


                    Dim cmd5 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd5.ExecuteNonQuery()
                Next

                '' editing narration for showing veh. no.
                narration = narration & " " & narr & "#"
                If TxtVehNo.Text <> "" Then
                    narration = narration & "Veh.no-" & TxtVehNo.Text & " Inw. No.-" & txtImwno.Text & " Inw Date " & dtpInwdate.Value.ToString("dd-MMM-yyyy") & ""
                Else
                    narration = narration & " Inw. No.-" & txtImwno.Text & " Inw Date " & dtpInwdate.Value.ToString("dd-MMM-yyyy") & ""
                End If

                If TxtStockNo.Text <> "" Then
                    narration = narration & "Stock No-" & TxtStockNo.Text
                End If
                ''''stop editing

                'PARTY A/C Cr
                sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                & " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
                & "Narration, Group_name, Sub_group_name,Ch_issue_date,ch_date) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'1',"
                sqlsave &= "'" & lblvouno.Text & "',"
                sqlsave &= "'" & voutype.Text & "',"
                sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbacheadcode.Text & "',"
                sqlsave &= "'" & cmbacheadname.Text & "',"
                sqlsave &= "'" & total & "',"
                sqlsave &= "'0',"
                sqlsave &= "'-',"
                sqlsave &= "'-',"
                sqlsave &= "'" & narration & "',"
                sqlsave &= "'" & ComboBox1.Text & "',"
                sqlsave &= "'-',"
                sqlsave &= "'" & PaymentDate.ToShortDateString & "',"
                sqlsave &= "'" & dtbilldate.Value.ToShortDateString & "')"
                'MsgBox(sqlsave)
                Dim cmd2 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd2.ExecuteNonQuery()



                If vat > 0 Then
                    'Vat Dr
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                 & " Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " _
                 & "Narration, Group_name, Sub_group_name,Ch_issue_date,ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'-3',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & voutype.Text & "',"
                    sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbvatcode.Text & "',"
                    sqlsave &= "'" & cmbvathead.Text & "',"
                    sqlsave &= "'" & vat & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narration & "',"
                    sqlsave &= "'" & cmbgrpvat.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & PaymentDate.ToShortDateString & "',"
                    sqlsave &= "'" & dtbilldate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If

                If cst > 0 Then
                    'Vat Dr
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                 & " Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " _
                 & "Narration, Group_name, Sub_group_name,Ch_issue_date,ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'-3',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & voutype.Text & "',"
                    sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbcstcode.Text & "',"
                    sqlsave &= "'" & cmbcsthead.Text & "',"
                    sqlsave &= "'" & cst & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narration & "',"
                    sqlsave &= "'" & ComboBox2.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & PaymentDate.ToShortDateString & "',"
                    sqlsave &= "'" & dtbilldate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If


                If fr > 0 Then
                    'FREIGHT Cr
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                    & " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
                    & "Narration, Group_name, Sub_group_name,ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & voutype.Text & "',"
                    sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbfercode.Text & "',"
                    sqlsave &= "'" & cmbferhead.Text & "',"
                    sqlsave &= "'" & fr & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narration & "',"
                    sqlsave &= "'" & cmbgrpferi.Text & "',"
                    sqlsave &= "'-','" & dtbilldate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If


                If tds > 0 Then
                    'TDS Cr
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                    & " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
                    & "Narration, Group_name, Sub_group_name,ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & voutype.Text & "',"
                    sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbTdsCode.Text & "',"
                    sqlsave &= "'" & cmbTdsHead.Text & "',"
                    sqlsave &= "'" & tds & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narration & "',"
                    sqlsave &= "'" & CmbTdsGroup.Text & "',"
                    sqlsave &= "'-','" & dtbilldate.Value.ToShortDateString & "')"
                    Dim cmd5 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd5.ExecuteNonQuery()


                    sql = "insert into TdsEntry(Vou_Type, Vou_no, TdsType, Per, TdsDate, " _
                                   & " BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt," _
                                   & " Actualamt, session,Paidto,vou_date, TdsAmt,dcode,cmp_id ) values( "
                    sql &= "'" & voutype.Text & "',"
                    sql &= "'" & lblvouno.Text & "',"
                    sql &= "'" & cmbtdsType.Text & "',"
                    sql &= "'" & cmbTdsper.Text & "',"
                    sql &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'0',"
                    sql &= "'" & Val(tdspidamt.Text) & "',"
                    sql &= "'" & Val("") & "',"
                    sql &= "'" & GMod.Session & "',"
                    sql &= "'YES',"
                    sql &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sql &= "'" & tds & "',"
                    sql &= "'" & cmbacheadcode.Text & "',"
                    sql &= "'" & GMod.Cmpid & "')"

                    Dim cmd6 As New SqlCommand(sql, SqlConn, sqltrans)
                    cmd6.ExecuteNonQuery()
                End If
                'FOR Aging 
                If DataGridView1.Rows.Count = 0 Then
                    sqlsavecr = "insert into  Purchase_Payment (Ref_Type, Ref, Acc_Code, Vou_Type," & _
                    " Vou_No, Vou_Date, dr, cr, dueon, Session,cmp_id) values( "
                    sqlsavecr &= "'Ags Ref',"
                    sqlsavecr &= "'" & voutype.Text & "-" & txtBillNo.Text & "',"
                    sqlsavecr &= "'" & cmbacheadcode.Text & "',"
                    sqlsavecr &= "'" & voutype.Text & "',"
                    sqlsavecr &= "'" & lblvouno.Text & "',"
                    sqlsavecr &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsavecr &= "'" & Val("") & "',"
                    sqlsavecr &= "'" & Val(txtTotal.Text) & "',"
                    sqlsavecr &= "'" & CDate("1/1/2000") & "',"
                    sqlsavecr &= "'" & GMod.Session & "',"
                    sqlsavecr &= "'" & GMod.Cmpid & "')"

                    Dim cmdAG As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltrans)
                    cmdAG.ExecuteNonQuery()
                Else

                    For i = 0 To DataGridView1.Rows.Count - 1
                        cr = cr + Val(DataGridView1(3, i).Value)
                    Next

                    If cr <> Val(txtTotal.Text) Then
                        MsgBox("Amount not matching!!", MsgBoxStyle.Critical)
                        cmbacheadname.Focus()
                        cr = 0.0
                        pv = 0.0
                        Exit Sub
                    End If
                    For i = 0 To DataGridView1.RowCount - 1
                        sqlsavecr = "insert into  Purchase_Payment (Ref_Type, Ref, Acc_Code, Vou_Type," & _
                        " Vou_No, Vou_Date, cr, dr, dueon, Session,cmp_id) values( "
                        sqlsavecr &= "'" & DataGridView1(0, i).Value & "',"
                        sqlsavecr &= "'" & DataGridView1(1, i).Value & "',"
                        sqlsavecr &= "'" & cmbacheadcode.Text & "',"
                        sqlsavecr &= "'" & voutype.Text & "',"
                        sqlsavecr &= "'" & lblvouno.Text & "',"
                        sqlsavecr &= "'" & dtVdate.Value.ToShortDateString & "',"
                        sqlsavecr &= "'" & Val(DataGridView1(3, i).Value) & "',"
                        sqlsavecr &= "'" & Val("") & "',"
                        sqlsavecr &= "'" & CDate(DataGridView1(2, i).Value).ToShortDateString & "',"
                        sqlsavecr &= "'" & GMod.Session & "',"
                        sqlsavecr &= "'" & GMod.Cmpid & "')"

                        Dim cmdAG As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltrans)
                        cmdAG.ExecuteNonQuery()
                    Next
                End If
                Dim cmddd As New SqlCommand("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='P' and cmp_id='" & GMod.Cmpid & "'", GMod.SqlConn, sqltrans)
                cmddd.ExecuteNonQuery()
                '-------------------------------------------------------------------------------------------------

                sqltrans.Commit()
                MessageBox.Show(voutype.Text & "/" & lblvouno.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvoucher.Rows.Clear()
                txtBillNo.Focus()
                vat = 0
                cst = 0
                fr = 0
                tds = 0
                'nxtvno()
                lblvouno.Text = ""
                txtBillNo.Text = ""
                dgvoucher.Rows.Add()
                txtFreight.Text = "0"
                txtVat.Text = "0"
                txtcstamt.Text = "0"
                tdspidamt.Text = "0"
                txtTDSamt.Text = "0"
                txtTotal.Text = ""
                txtcstamt_Leave(sender, e)
                txtVat_Leave(sender, e)
                txtFreight_Leave(sender, e)
                DataGridView1.Rows.Clear()
                ChkCform.Checked = False
                chgFlag = False
                cmbferhead.Text = "-"
                TxtVehNo.Text = ""
                TxtStockNo.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
                sqltrans.Rollback()
            End Try
            sqltrans.Dispose()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtFreight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFreight.KeyPress
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtFreight_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFreight.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtFreight_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFreight.Leave
       
    End Sub
    Dim totgridamount As Double
    Sub gridtotal()
        totgridamount = 0
        Dim z As Integer
        For z = 0 To dgvoucher.Rows.Count - 1
            totgridamount = totgridamount + Val(dgvoucher(3, z).Value)
        Next
    End Sub
    Dim PaymentDate As Date = CDate("1/1/2000")

    Private Sub txtFreight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFreight.TextChanged
        gridtotal()
        txtTotal.Text = -Val(txtFreight.Text) + Val(txtVat.Text) + totgridamount
    End Sub

    Private Sub txtVat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVat.KeyPress
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtVat_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVat.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtVat_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVat.Leave
        'If cmbvathead.Items.Count = 0 Then
        If Val(txtVat.Text) > 0 Then
            Dim Sqlvat As String
            Sqlvat = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sqlvat, "A3")
            cmbvathead.DataSource = GMod.ds.Tables("A3")
            cmbvathead.DisplayMember = "account_head_name"

            cmbvatcode.DataSource = GMod.ds.Tables("A3")
            cmbvatcode.DisplayMember = "account_code"
            cmbgrpvat.DataSource = GMod.ds.Tables("A3")
            cmbgrpvat.DisplayMember = "group_name"
        Else
            cmbvathead.Text = "-"
            cmbvatcode.Text = "-"
            cmbgrpvat.Text = "-"
        End If
        'End If
    End Sub

    Private Sub txtVat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVat.TextChanged
        If chgFlag = False Then
            gridtotal()
            txtTotal.Text = -Val(txtFreight.Text) + Val(txtVat.Text) + Val(txtcstamt.Text) - Val(txtTDSamt.Text) + totgridamount
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Dim t As New frmPartyaccount
            Dim sql As String
            sql = "select Group_name,Suffix from Groups where Group_name like '%PARTY%' and Cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "Suffix")

            t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupname.DisplayMember = "Group_name"

            t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupsuffix.DisplayMember = "Suffix"
            t.lblgroupsuffix.Text = "PA"
            t.Label1.Text = "Party Account Heads"
            t.ShowDialog()
            CheckBox2.Checked = False
            fillheads()
        Else
        End If
    End Sub
    Private Sub txtTotal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.Enter
        gridtotal()
        txtTotal.Text = -Val(txtFreight.Text) + Val(txtVat.Text) + Val(txtcstamt.Text) - Val(txtTDSamt.Text) + totgridamount
    End Sub
    Private Sub dtVdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtVdate.KeyUp
        If e.KeyCode = Keys.Enter Then txtBillNo.Focus()
    End Sub

    Private Sub dtVdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtVdate.Leave
        If btnsave.Enabled = True Then
            GMod.DataSetRet("select isnull(max(vou_date),'" & dtVdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & voutype.Text & "'", "getMaxDate")
            If dtVdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
                MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dtVdate.Focus()
            End If
        End If
    End Sub
    Private Sub dtVdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtVdate.ValueChanged
        'SetLastVouDate()
        'GMod.setDate = dtVdate.Value

        ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$4 Resting date
        If btnsave.Enabled = True Then
            GMod.DataSetRet("select getdate()", "serverdate")

            dtVdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
            dtVdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        End If
    End Sub

    Private Sub dgvoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvoucher.KeyDown
        If e.KeyCode = Keys.F10 Then
            btnsave_Click(sender, e)
        End If
    End Sub
    Private Sub btn_modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modify.Click
        'btnsave.Enabled = False
        Dim vou As String
        Dim vt As String
        Dim j As Integer
        Dim narr() As String
        Dim dt() As String
        Try
            If btn_modify.Text = "&Modify" Then
                btnsave.Enabled = False
                btn_modify.Text = "&Update"
                vt = voutype.Text
                vou = InputBox("Enter Vouche No to be modify?")
                If vou <> "" And vt <> "" Then
                    lblvouno.Text = vou
                    voutype.Text = vt
                    voutype.Enabled = False
                    If LockDataCheck(vou, GMod.Session, voutype.Text) = False Then
                        'btnsave.Enabled = True
                        MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ' Exit Sub
                    End If
                    'For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, 
                    'party_code, item_code, item_name, Rate, lst_rate, Qty, 
                    'Unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno, 
                    'cmp_id, Session, username, amt, party_amt, inwdate, id, 
                    'vathead, csthead, cst_code, cst_amt, porate, fr_head

                    sql = " select * from Purchase_Data where vou_no='" & vou & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' AND VOU_TYPE='" & voutype.Text & "' and authr ='-'"
                    GMod.DataSetRet(sql, "pur_modify")


                    If GMod.ds.Tables("pur_modify").Rows.Count = 0 Then
                        MessageBox.Show("No Data Found For" & vt & "-" & vou, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        voutype.Enabled = True
                        voutype.Focus()
                        btn_modify.Text = "&Modify"
                        btnsave.Enabled = True
                        Exit Sub
                    End If
                    txtBillNo.Focus()
                    lblvouno.Text = GMod.ds.Tables("pur_modify").Rows(0)("vou_no")
                    dtVdate.MinDate = Convert.ToDateTime(GMod.ds.Tables("pur_modify").Rows(0)("vou_date"))
                    dtVdate.Value = Convert.ToDateTime(GMod.ds.Tables("pur_modify").Rows(0)("vou_date"))
                    txtBillNo.Text = GMod.ds.Tables("pur_modify").Rows(0)("Bill_no")
                    dtbilldate.Value = CDate(GMod.ds.Tables("pur_modify").Rows(0)("Bill_date"))
                    txtPoNo.Text = GMod.ds.Tables("pur_modify").Rows(0)("pono")
                    txtImwno.Text = GMod.ds.Tables("pur_modify").Rows(0)("inwno")
                    dtpInwdate.Value = CDate(GMod.ds.Tables("pur_modify").Rows(0)("inwdate"))
                    cmbPrdUnit.Text = GMod.ds.Tables("pur_modify").Rows(0)("For_where")
                    cmbacheadcode.Text = GMod.ds.Tables("pur_modify").Rows(0)("party_code")
                    For j = 0 To GMod.ds.Tables("pur_modify").Rows.Count - 1
                        dgvoucher.Rows.Add()
                        dgvoucher(0, j).Value = j
                        dgvoucher(1, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("item_code")
                        dgvoucher(2, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("item_name")
                        dgvoucher(3, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("amt")
                        dgvoucher(4, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("Qty")
                        dgvoucher(5, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("unit")
                        dgvoucher(6, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("Rate")
                        dgvoucher(7, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("lst_rate")
                        dgvoucher(8, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("porate")
                    Next
                    dgvoucher.Rows.RemoveAt(j)
                    txtVat.Text = GMod.ds.Tables("pur_modify").Rows(0)("varcst_amt")
                    txtVat_Leave(sender, e)
                    cmbvatcode.Text = GMod.ds.Tables("pur_modify").Rows(0)("vatcst_code")
                    txtcstamt.Text = GMod.ds.Tables("pur_modify").Rows(0)("cst_amt")
                    txtcstamt_Leave(sender, e)
                    cmbcstcode.Text = GMod.ds.Tables("pur_modify").Rows(0)("cst_code")

                    txtFreight.Text = GMod.ds.Tables("pur_modify").Rows(0)("fr_amt")
                    txtFreight_Leave(sender, e)
                    cmbfercode.Text = GMod.ds.Tables("pur_modify").Rows(0)("fr_code")
                    Try
                        sql = " select * from " & GMod.VENTRY & " where vou_no='" & vou & "'  AND Vou_type='" & voutype.Text & "'"
                        GMod.DataSetRet(sql, "vou_ch")
                        Dim narrup() As String
                        narrup = GMod.ds.Tables("vou_ch").Rows(0)("narration").ToString.Split("#")
                        cmbferhead.Text = narrup(1)
                    Catch ex As Exception

                    End Try

                    'fro aging fill data
                    'sql = "select ref_type,ref,dueon, cr from Purchase_Payment where vou_type='" & voutype.Text & "' and  vou_no='" & lblvouno.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
                    'dg.Visible = False
                    'GMod.DataSetRet(sql, "mfy")
                    'If GMod.ds.Tables("mfy").Rows.Count > 0 Then
                    '    For j = 0 To GMod.ds.Tables("mfy").Rows.Count - 1
                    '        DataGridView1.Rows.Add()
                    '        DataGridView1(0, j).Value = GMod.ds.Tables("mfy").Rows(j)(0)
                    '        DataGridView1(1, j).Value = GMod.ds.Tables("mfy").Rows(j)(1)
                    '        DataGridView1(2, j).Value = GMod.ds.Tables("mfy").Rows(j)(2)
                    '        DataGridView1(3, j).Value = GMod.ds.Tables("mfy").Rows(j)(3)
                    '    Next

                    'End If

                    sql = "select * from tdsentry where vou_type='" & voutype.Text & "' and  vou_no='" & lblvouno.Text & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    GMod.DataSetRet(sql, "tdsval")
                    If GMod.ds.Tables("tdsval").Rows.Count > 0 Then
                        cmbtdsType.Text = GMod.ds.Tables("tdsval").Rows(0)("tdstype")
                        tdspidamt.Text = GMod.ds.Tables("tdsval").Rows(0)("paidamt")
                        txtTDSamt.Text = GMod.ds.Tables("tdsval").Rows(0)("tdsamt")
                    End If
                    ' txtTDSamt_TextChanged(sender, e)
                End If
            Else
                If MessageBox.Show("Do U want to Modify", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    btnsave_Click(sender, e)
                    btn_modify.Text = "&Modify"
                    btnsave.Enabled = True
                    voutype.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub lblvouno_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lblvouno.KeyUp
        If e.KeyCode = Keys.Enter Then dtVdate.Focus()
    End Sub
    Private Sub txtBillNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBillNo.KeyUp
        If e.KeyCode = Keys.Enter Then dtbilldate.Focus()
    End Sub
    Private Sub dtbilldate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtbilldate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbacheadname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbacheadcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtTotal_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotal.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbvathead_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvathead.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbvatcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvatcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbferhead_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbfercode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbfercode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmPurchase_Register
        t.ShowDialog()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        ' btnsave.Enabled = False
        Dim vou As String
        vou = InputBox("Enter Voucher Number TO Delete?")
        If vou <> "" Then
            If LockDataCheck(vou, GMod.Session, "PURCHASE") = False Then
                btnsave.Enabled = True
                MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim narr() As String
            Dim dt() As String
            'Try
            If btnsave.Enabled = True Then
                'vou = InputBox("Enter Vouche No to be delete?")
                If vou <> "" Then
                    'For Filling PArty 
                    Dim sqlparty As String
                    sqlparty = "select * from " & GMod.VENTRY & " where Vou_type='PURCHASE' and vou_no = '" & vou & "' and Group_name='PARTY'"
                    GMod.DataSetRet(sqlparty, "PurParty")
                    If GMod.ds.Tables("PurParty").Rows.Count = 1 Then
                        narr = GMod.ds.Tables("PurParty").Rows(0)("narration").ToString.Split(" ")

                        txtBillNo.Text = narr(2)
                        dt = narr(3).Split(".")
                        dtbilldate.Value = CDate(dt(1))
                        lblvouno.Text = GMod.ds.Tables("PurParty").Rows(0)("Vou_no")
                        dtVdate.Value = CDate(GMod.ds.Tables("PurParty").Rows(0)("Vou_date").ToString)
                        cmbacheadcode.Text = GMod.ds.Tables("PurParty").Rows(0)("Acc_head_code")
                        cmbacheadname.Text = GMod.ds.Tables("PurParty").Rows(0)("Acc_head")
                    End If
                    'For Filling PURCHASE 
                    Dim sqlpurchase As String, i As Integer
                    sqlpurchase = "select * from " & GMod.VENTRY & " where Vou_type='PURCHASE' and vou_no = '" & vou & "' and Group_name='PURCHASE'"
                    GMod.DataSetRet(sqlpurchase, "Purchase")
                    For i = 0 To GMod.ds.Tables("Purchase").Rows.Count - 1
                        dgvoucher(0, i).Value = i + 1
                        dgvoucher(1, i).Value = GMod.ds.Tables("Purchase").Rows(i)("Acc_head_code")
                        dgvoucher(2, i).Value = GMod.ds.Tables("Purchase").Rows(i)("Acc_head")
                        'dgvoucher(3, i).Value = GMod.ds.Tables("Purchase").Rows(0)("Acc_head")
                        dgvoucher(3, i).Value = GMod.ds.Tables("Purchase").Rows(i)("dramt")
                        dgvoucher.Rows.Add()
                    Next
                    dgvoucher.Rows.RemoveAt(i)
                    'For Filling Vat 
                    Dim sqlvat As String
                    sqlvat = "select * from " & GMod.VENTRY & " where Vou_type='PURCHASE'and vou_no = '" & vou & "' and Group_name  in ('VAT')"
                    GMod.DataSetRet(sqlvat, "PurVat")
                    If GMod.ds.Tables("PurVat").Rows.Count = 1 Then
                        cmbvatcode.Text = GMod.ds.Tables("PurVat").Rows(0)("Acc_head_code")
                        cmbvathead.Text = GMod.ds.Tables("PurVat").Rows(0)("Acc_head")
                        'If Val(GMod.ds.Tables("PurVat").Rows(0)("dramt")) > 0 Then
                        txtVat.Text = GMod.ds.Tables("PurVat").Rows(0)("dramt")
                    End If


                    'For Filling FREIGHT 
                    Dim sqlfre As String
                    sqlvat = "select * from " & GMod.VENTRY & " where Vou_type='PURCHASE'and vou_no = '" & vou & "' and Group_name='EXPENSES' and cramt>0"
                    GMod.DataSetRet(sqlvat, "FREIGHT")
                    If GMod.ds.Tables("FREIGHT").Rows.Count = 1 Then
                        cmbfercode.Text = GMod.ds.Tables("FREIGHT").Rows(0)("Acc_head_code")
                        cmbferhead.Text = GMod.ds.Tables("FREIGHT").Rows(0)("Acc_head")
                        txtFreight.Text = GMod.ds.Tables("FREIGHT").Rows(0)("cramt")
                    End If
                    btndelete.Text = "&Confitm"
                    btnsave.Enabled = False
                Else ' 
                    MsgBox("Please Enter Purchase Voucher Number.")
                End If
            End If
            '--
            If MessageBox.Show("Are U Sure?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                GMod.Fill_Log(GMod.Cmpid, lblvouno.Text, "PURCHASE", dtVdate.Value, Now, GMod.Session, "D", GMod.username)

                Dim sqldel As String, sqldel1 As String
                sqldel = "delete from " & GMod.VENTRY & " where vou_no= '" & vou & "' and vou_type='PURCHASE'"
                MsgBox(GMod.SqlExecuteNonQuery(sqldel))

                sqldel1 = "delete from " & GMod.INVENTORY & " where vou_no= '" & vou & "' and vou_type='PURCHASE'"
                MsgBox(GMod.SqlExecuteNonQuery(sqldel1))
                btndelete.Text = "&Delete"
                btnsave.Enabled = True
            End If
            'nxtvno()
            dgvoucher.Rows.Clear()
            txtBillNo.Focus()
            'nxtvno()
            txtBillNo.Text = ""
            dgvoucher.Rows.Add()
            txtFreight.Text = ""
            txtVat.Text = ""
            txtTotal.Text = ""
        End If
    End Sub

    Private Sub txtBillNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNo.Leave

    End Sub

    Private Sub cmbacheadcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadcode.Leave
        txtBillNo_Leave(sender, e)
        Dim ch As String
        ch = "select bill_no from purchase_data where session ='" & GMod.Session & "' and party_code='" & cmbacheadcode.Text & "' and bill_no='" & txtBillNo.Text & "'"
        GMod.DataSetRet(ch, "chjj")
        If GMod.ds.Tables("chjj").Rows.Count > 0 Then
            MsgBox("Duplicate bill")
            txtBillNo.Focus()
            Exit Sub
        End If
        sql = "select *  from tmpAging where acc_code ='" & cmbacheadcode.Text & "' and vou_type='P' and cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "jj")
        If GMod.ds.Tables("jj").Rows.Count > 0 Then
            MsgBox("Please selecr diffent head")
            Me.Close()
            Exit Sub
        End If

        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='P' and cmp_id='" & GMod.Cmpid & "'")
        'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
        sql = " insert into  tmpAging (Ref_Type, Ref, Acc_Code,dr,vou_type,cmp_id) " & _
              " select Ref_type,Ref,acc_code,sum(Dr)-sum(Cr) Amount,'P',cmp_id  " & _
              " from Purchase_Payment group by Ref,acc_code,Ref_type,cmp_id having sum(dr)-sum(cr)>0 " & _
              " and acc_code='" & cmbacheadcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
        GMod.SqlExecuteNonQuery(sql)
        'cmbRefType_Leave(sender, e)
        filltdsparty()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim tg As New frmGeneralacchead
        tg.ShowDialog()
        CheckBox1.Checked = False
        fillheads()
    End Sub
    Private Sub cmbacheadname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadname.Leave
        'End If
        If cmbacheadname.FindStringExact(cmbacheadname.Text) = -1 Then
            MsgBox("Please Select Correct A/c Head Name", MsgBoxStyle.Critical)
            cmbacheadname.Focus()
            Exit Sub
        End If

    End Sub
    Private Sub cmbPrdUnit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPrdUnit.Leave
        If cmbPrdUnit.FindStringExact(cmbPrdUnit.Text) = -1 Then
            cmbPrdUnit.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub dgvoucher_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellEnter
        'Try
        '    If e.ColumnIndex = 6 Then
        '        'If Val(dgvoucher(4, e.RowIndex).Value) > 0 Then
        '        dgvoucher(6, e.RowIndex).Value = Math.Round(Val(dgvoucher(3, e.RowIndex).Value) / Val(dgvoucher(4, e.RowIndex).Value), 2)
        '        'End If
        '        'Else
        '        'dgvoucher(6, e.RowIndex).Value = 0
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub txtcstamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcstamt.KeyPress
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtcstamt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcstamt.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtcstamt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcstamt.Leave
        'If cmbcsthead.Items.Count = 0 Then
        If Val(txtcstamt.Text) > 0 Then
            GMod.DataSetRet("select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'", "A5")
            cmbcsthead.DataSource = GMod.ds.Tables("A5")
            cmbcsthead.DisplayMember = "account_head_name"
            cmbcstcode.DataSource = GMod.ds.Tables("A5")
            cmbcstcode.DisplayMember = "account_code"
            ComboBox2.DataSource = GMod.ds.Tables("A5")
            ComboBox2.DisplayMember = "group_name"
        Else
            cmbcsthead.Text = "-"
            cmbcstcode.Text = "-"
            ComboBox2.Text = "-"
        End If
        'End If
    End Sub

    Private Sub txtcstamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcstamt.TextChanged

        If Val(txtcstamt.Text) > 0 Then
            ChkCform.Checked = True
        Else
            ChkCform.Checked = False
        End If
        If chgFlag = False Then
            gridtotal()
            txtTotal.Text = -Val(txtFreight.Text) + Val(txtVat.Text) + Val(txtcstamt.Text) - Val(txtTDSamt.Text) + totgridamount
        End If
    End Sub

    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged

    End Sub
    Sub filltdsparty()

        Dim i As Integer
        sql = "select * from " & GMod.ACC_HEAD & "   where  cmp_id='" & GMod.Cmpid & "' and  account_code='" & cmbacheadcode.Text & "'"

        GMod.DataSetRet(sql, "acc")
        MessageBox.Show(GMod.ds.Tables("acc").Rows(0)("account_head_name") & " # " & GMod.ds.Tables("acc").Rows(0)("credit_days") & "#" & GMod.ds.Tables("acc").Rows(0)("address") & " ," & GMod.ds.Tables("acc").Rows(0)("state") & "#" & GMod.ds.Tables("acc").Rows(0)("pan_no"))

    End Sub

    Private Sub cmbRefType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRefType.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbRefType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRefType.Leave
        If cmbRefType.Text = "Ags Ref" Then
            sql = "select Ref,sum(Dr)-sum(Cr) Amount,acc_code from tmpAging group by Ref,acc_code,cmp_id having sum(dr)-sum(cr)>0  and acc_code='" & cmbacheadcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "aging")
            If GMod.ds.Tables("aging").Rows.Count > 0 Then
                dg.DataSource = GMod.ds.Tables("aging")
                dg.Visible = True
                dg.Focus()
            End If
        End If
    End Sub

   
    Dim sqlsavecr As String
    Dim i As Integer = -1
    Dim vouno As Long
    Dim ddate As DateTime = CDate("1/1/2000")
    Dim cr As Double = 0.0
    Dim pv As Double = 0.0
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtduedate.Text = "" Then
            txtduedate.Text = Format(ddate, "MM/dd/yyyy")
        End If
        Dim obj() As Object = {cmbRefType.Text, txtref.Text, txtduedate.Text, txtamount.Text}
        If i <> -1 Then
            DataGridView1.Rows.RemoveAt(i)
            DataGridView1.Rows.Insert(i, obj)
        Else
            DataGridView1.Rows.Add(obj)
        End If

        sqlsavecr = "insert into  tmpAging (Ref_Type, Ref, Acc_Code, Vou_Type," & _
        " Vou_No, Vou_Date, cr, dr, dueon, Session,usename,id,cmp_id) values( "
        sqlsavecr &= "'" & cmbRefType.Text & "',"
        sqlsavecr &= "'" & txtref.Text & "',"
        sqlsavecr &= "'" & cmbacheadcode.Text & "',"
        sqlsavecr &= "'S',"
        sqlsavecr &= "'" & VouNo & "',"
        sqlsavecr &= "'" & dtVdate.Value.ToShortDateString & "',"
        sqlsavecr &= "'" & Val(txtamount.Text) & "',"
        sqlsavecr &= "'" & Val("") & "',"
        sqlsavecr &= "'" & CDate(txtduedate.Text).ToShortDateString & "',"
        sqlsavecr &= "'" & GMod.Session & "',"
        sqlsavecr &= "'" & GMod.username & "',"
        sqlsavecr &= "'" & DataGridView1.CurrentCell.RowIndex & "',"
        sqlsavecr &= "'" & GMod.Cmpid & "')"

        GMod.SqlExecuteNonQuery(sqlsavecr)

        'If cr <> Val(dg(0, 4).Value) Then
        '    cmbRefType.Focus()
        'Else
        '    btnsave.Focus()
        'End If

        txtref.Clear()
        txtduedate.Clear()
        txtamount.Clear()
        i = -1
    End Sub
    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Escape Then
            txtref.Text = dg(0, dg.CurrentCell.RowIndex).Value
            txtamount.Text = dg(1, dg.CurrentCell.RowIndex).Value
            dg.Visible = False
            txtamount.Focus()
        End If
    End Sub
    Dim cform As Integer
    Private Sub ChkCform_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCform.CheckedChanged
        If ChkCform.Checked = True Then
            cform = 1
        Else
            cform = 0
        End If
    End Sub

    Private Sub txtBillNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBillNo.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub voutype_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles voutype.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub voutype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voutype.SelectedIndexChanged
        Label17.Text = voutype.Text
    End Sub
    Private Sub txtPoNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPoNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtImwno_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtImwno.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpInwdate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpInwdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbPrdUnit_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPrdUnit.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbcsthead_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcsthead.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbcstcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcstcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtref_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtref.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtduedate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtduedate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtamount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnOk_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOk.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbacheadname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadname.SelectedIndexChanged

    End Sub

    Private Sub cmbvathead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvathead.Leave
        If Val(txtVat.Text) > 0 Then
            If cmbvathead.FindStringExact(cmbvathead.Text) = -1 Then
                MsgBox("Please Select Correct A/c Head Name", MsgBoxStyle.Critical)
                cmbvathead.Focus()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub cmbvatcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbvatcode.Leave
        If Val(txtVat.Text) > 0 Then
            If cmbvatcode.FindStringExact(cmbvatcode.Text) = -1 Then
                MsgBox("Please Select Correct A/c Head Name", MsgBoxStyle.Critical)
                cmbvatcode.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmbcsthead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcsthead.Leave
        If Val(txtcstamt.Text) > 0 Then
            If cmbcsthead.FindStringExact(cmbcsthead.Text) = -1 Then
                MsgBox("Please Select Correct A/c Head Name", MsgBoxStyle.Critical)
                cmbcsthead.Focus()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub cmbcstcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcstcode.Leave
        If Val(txtcstamt.Text) > 0 Then
            If cmbcstcode.FindStringExact(cmbcstcode.Text) = -1 Then
                MsgBox("Please Select Correct A/c Head Name", MsgBoxStyle.Critical)
                cmbcstcode.Focus()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub cmbfercode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbfercode.Leave
        If Val(txtFreight.Text) Then
            If cmbfercode.FindStringExact(cmbfercode.Text) = -1 Then
                MsgBox("Please Select Correct A/c Head Name", MsgBoxStyle.Critical)
                cmbfercode.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub cmbacheadcodetds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcodetds.SelectedIndexChanged
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and account_code='" & cmbacheadcodetds.Text & "'"
        GMod.DataSetRet(sql, "aclist2")
        cmbTdsCode.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsCode.DisplayMember = "account_code"
        cmbTdsHead.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsHead.DisplayMember = "account_head_name"
        CmbTdsGroup.DataSource = GMod.ds.Tables("aclist2")
        CmbTdsGroup.DisplayMember = "group_name"
        cmbTdsSubGroup.DataSource = GMod.ds.Tables("aclist2")
        cmbTdsSubGroup.DisplayMember = "sub_group_name"
    End Sub

    Private Sub txtTDSamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTDSamt.TextChanged
        If chgFlag = False Then
            gridtotal()
            txtTotal.Text = -Val(txtFreight.Text) + Val(txtVat.Text) + Val(txtcstamt.Text) - Val(txtTDSamt.Text) + totgridamount
        End If
    End Sub

   
End Class