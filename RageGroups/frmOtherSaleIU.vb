Imports System.Data.SqlClient
Public Class frmOtherSaleIU

    Private Sub dgvoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellContentClick

    End Sub
    Dim ach As New frmacheadlist
    Dim chgFlag As Boolean = False
    Dim vat, cst, fr, total As Double
    Dim amt, cgst, igsta, sgsta As Double
    Dim _gsttype As String = ""
    Dim _ggstper As Integer = 0
    Dim _igsttype As String = ""
    Dim _igstper As Integer = 0
    Dim _igstamt As Double = 0
    Dim _ggstamt As Double = 0
    Private Sub dgvoucher_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellEndEdit
        'If e.ColumnIndex = 3 Or e.ColumnIndex = 4 Then
        '    dgvoucher(6, e.RowIndex).Value = Math.Round(Val(dgvoucher(3, e.RowIndex).Value) / Val(dgvoucher(4, e.RowIndex).Value), 2)
        'End If

        'Dim st, h() As String
        'If e.ColumnIndex = 1 Then
        '    If Len(dgvoucher(1, e.RowIndex).Value) = 0 Then
        '        ach.ShowDialog()
        '        ach.cmbAreaCode.Text = "**"
        '        ach.cmbgroup.Text = "PURCHASE"
        '        ach.ShowDialog()
        '        st = ach.cmbacheadlist.Text
        '        h = st.Split("[")
        '        dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
        '        h = h(1).Split("]")
        '        dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
        '        'ach.Dispose()
        '        Exit Sub
        '    Else
        '        Dim sqlacc As String
        '        sqlacc = "select account_code from " & GMod.ACC_HEAD & " where account_code='" & dgvoucher(1, e.RowIndex).Value & "'"
        '        GMod.DataSetRet(sqlacc, "Count")
        '        If GMod.ds.Tables("Count").Rows.Count > 0 Then

        '        Else
        '            ach.ShowDialog()
        '            st = ach.cmbacheadlist.Text
        '            h = st.Split("[")
        '            dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
        '            h = h(1).Split("]")
        '            dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
        '            Exit Sub
        '        End If
        '        GMod.ds.Tables("Count").Clear()
        '    End If
        'End If
        'If e.ColumnIndex = 3 Then
        '    gridtotal()
        'End If
    End Sub
    Dim sql As String
    Private Sub dgvoucher_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellLeave
        'Try
        '    Dim s, st, h() As String
        '    s = dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value
        '    If e.ColumnIndex = 1 And String.IsNullOrEmpty(s) Then
        '        ach.cmbAreaCode.Text = "**"
        '        ach.cmbgroup.Text = "PURCHASE"
        '        ach.ShowDialog()

        '        st = ach.cmbacheadlist.Text.ToUpper
        '        h = st.Split("[")
        '        dgvoucher(2, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
        '        h = h(1).Split("]")
        '        dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value = h(0).ToUpper
        '    ElseIf e.ColumnIndex = 2 Then
        '        sql = "select rate  from Purchase_Data where bill_date = ( " & _
        '              " select max(bill_date) from dbo.Purchase_Data " & _
        '              " where item_code='" & dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value & "') and  item_code='" & dgvoucher(1, dgvoucher.CurrentCell.RowIndex).Value & "'"
        '        GMod.DataSetRet(sql, "lstrate")
        '        dgvoucher(7, dgvoucher.CurrentCell.RowIndex).Value = GMod.ds.Tables("lstrate").Rows(0)(0)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
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

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "aclist4")
        cmbacheadcode.DataSource = GMod.ds.Tables("aclist4")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist4")
        cmbacheadname.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclist4")
        ComboBox1.DisplayMember = "group_name"

        cmbSubGroup.DataSource = GMod.ds.Tables("aclist4")
        cmbSubGroup.DisplayMember = "sub_group_name"


        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and Group_name  in ('PARTY')"
        GMod.DataSetRet(sql, "tblBrokerList")
        cmbBrokerCode.DataSource = GMod.ds.Tables("tblBrokerList")
        cmbBrokerCode.DisplayMember = "account_code"
        cmbBrokerName.DataSource = GMod.ds.Tables("tblBrokerList")
        cmbBrokerName.DisplayMember = "account_head_name"


        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "tbliTEMList")
        cmbItemHead.DataSource = GMod.ds.Tables("tbliTEMList")
        cmbItemHead.DisplayMember = "account_head_name"
        cmbItemCode.DataSource = GMod.ds.Tables("tbliTEMList")
        cmbItemCode.DisplayMember = "account_code"

        'GMod.DataSetRet(sql, "CrHead")
        'cracc.DataSource = GMod.ds.Tables("tbliTEMList")
        'cracc.DisplayMember = "account_head_name"

        'cracccode.DataSource = GMod.ds.Tables("tbliTEMList")
        'cracccode.DisplayMember = "account_code"

        'craccgrp.DataSource = GMod.ds.Tables("tbliTEMList")
        'craccgrp.DisplayMember = "account_code"


        GMod.DataSetRet("select itemname from ItemMasterOther where cmp_id ='" & GMod.Cmpid & "'", "puritems")
        cmbPrduct.DataSource = GMod.ds.Tables("puritems")
        cmbPrduct.DisplayMember = "itemname"
    End Sub
    Public Sub SetLastVouDate()
        Dim sql As String
        sql = "select * from  LastVouDate"
        GMod.DataSetRet(sql, "LastVouDate")
        If GMod.ds.Tables("LastVouDate").Rows.Count > 0 Then
            sql = "update LastVouDate set last_vou_date='" & dtVdate.Value.ToShortDateString & "' where Uname='" & GMod.username & "'"
            GMod.SqlExecuteNonQuery(sql)
        Else
            sql = "insert into LastVouDate values('" & dtVdate.Value.ToShortDateString & "','" & GMod.username & "')"
            GMod.SqlExecuteNonQuery(sql)
        End If
        GMod.ds.Tables("LastVouDate").Clear()
    End Sub

    Private Sub frmPurchasePoultrty_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='P' and cmp_id='" & GMod.Cmpid & "'")

    End Sub
    Dim OtherCheck As Double = 0
    Dim TaxFlag As String
    Dim TaxPer As Integer
    Private Sub frmPurchasePoultrty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$4 Resting date
        'Checking for user Entrtry Permission
        If GMod.PerviousSession = True Then
            GMod.DataSetRet("select entry_status from SessionMaster where Uname ='" & GMod.username & "' and session ='" & GMod.Session & "'", "entry_status")
            GMod.EntryStatus = CInt(GMod.ds.Tables("entry_status").Rows(0)(0))
            If GMod.EntryStatus = 1 Then
            Else
                MessageBox.Show("Permission denied", "Permision denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Else
        End If

        'Setting voucher date accrding to session
        dtVdate.Value = GMod.SessionCurrentDate
        dtVdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtVdate.MaxDate = GMod.SessionCurrentDate

        'filling production unit 
        GMod.DataSetRet("select prdunit from prdunit where cmp_id='" & GMod.Cmpid & "'", "prdunit")
        cmbPrdUnit.DataSource = GMod.ds.Tables("prdunit")
        cmbPrdUnit.DisplayMember = "prdunit"

        GMod.DataSetRet("select vtype from vtype where cmp_id='" & GMod.Cmpid & "' and session = '" & GMod.Session & "' and vou_no_seq='" & GMod.Dept & "'", "vt")
        'GMod.DataSetRet("select vtype from vtype where cmp_id='" & GMod.Cmpid & "' and session = '" & GMod.Session & "'", "vt")
        voutype.DataSource = GMod.ds.Tables("vt")

        voutype.DisplayMember = "vtype"


        Label6.Text = "IU SALE - " + GMod.Cmpname

        GetLastVouDate()

        ' nxtvno()
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        fillheads()

        If GMod.role.ToString <> "ADMIN" Then
            ' btn_modify.Enabled = False
        End If

        If GMod.Getsession(dtVdate.Value) = GMod.Session Then
        Else
            ' Me.Close()
        End If
        cmbWiOs.SelectedIndex = 0
        cmbPrdType.SelectedIndex = 0

        GMod.DataSetRet("select stock_val from company where cmp_id ='" & GMod.Cmpid & "'", "othercmpCheck")
        If Val(GMod.ds.Tables("othercmpCheck").Rows(0)(0)) = 1.11 Then
            OtherCheck = 1.11
        Else
            OtherCheck = 0
        End If
        cmbBrokerName.Text = "DIRECT"
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
    Dim totgridamount, gst, sgst, igst As Double
    Sub gridtotal()
        totgridamount = 0
        gst = 0
        sgst = 0
        igst = 0
        Dim z As Integer
        For z = 0 To dgvoucher.Rows.Count - 1
            totgridamount = totgridamount + Val(dgvoucher(3, z).Value)
            gst = gst + Val(dgvoucher(10, z).Value)
            sgst = sgst + Val(dgvoucher(14, z).Value)
            igst = igst + Val(dgvoucher(18, z).Value)
        Next
    End Sub
    Dim PaymentDate As Date = CDate("1/1/2000")
    Sub ckechEntyValues()

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MessageBox.Show("Are U Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            'for Payment date
            'Dim pd As New frmPaymentDatePopUp
            'pd.ShowDialog()
            'If OtherCheck = 0.0 Then
            '    If Val(txtTotal.Text) <> -Val(txtFreight.Text) + Val(txtSGStamt.Text) + Val(txtigstamt.Text) + totgridamount Then
            '        MessageBox.Show("Calculation Mistake Please Review Data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If
            'Else
            '    If Val(txtTotal.Text) <> Val(txtFreight.Text) + Val(txtSGStamt.Text) + Val(txtigstamt.Text) + totgridamount Then
            '        MessageBox.Show("Calculation Mistake Please Review Data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If
            'End If
            'cmbPrduct
            If cmbPrduct.Text = "" Then
                MsgBox("Please Select Product .", MsgBoxStyle.Critical)
                cmbPrduct.Focus()
                Exit Sub
            End If

            If cmbWiOs.Text = "" Then
                MsgBox("Please Select w/s ...", MsgBoxStyle.Critical)
                cmbWiOs.Focus()
                Exit Sub
            End If


            If voutype.Text = "" Then
                MsgBox("Please Select Voucher Type")
                voutype.Focus()
                Exit Sub
            End If
            If txtBillNo.Text = "" Then
                MsgBox("Please Enter Bill No.")
                txtBillNo.Focus()
                Exit Sub
            End If
            If cmbPrdUnit.Text = "" Then
                MsgBox("Please Enter Production Unit.")
                cmbPrdUnit.Focus()
                Exit Sub
            End If
            If Val(txtTotal.Text) = 0 Then
                Me.Close()
                Exit Sub
            End If
            If btnsave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, lblvouno.Text, voutype.Text, dtVdate.Value, Now, GMod.Session, "M", GMod.username)
            End If
            GetLastVouDate()
            Dim sqlsave As String, i As Integer, sql, g, s As String
            Dim sqltrans As SqlTransaction
            Dim narration, narr As String
            sqltrans = GMod.SqlConn.BeginTransaction
            Try
                If btnsave.Enabled = False Then
                    Dim sqldel As String
                    sqldel = "delete from " & GMod.VENTRY & " where Vou_type='" & voutype.Text & "' and Vou_no= " & lblvouno.Text
                    Dim cmddel1 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmddel1.ExecuteNonQuery()

                    sqldel = "delete  from othersaledata where  Vou_no= '" & lblvouno.Text & "' and Vou_type='" & voutype.Text & "' and Cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                    Dim cmddel2 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmddel2.ExecuteNonQuery()
                Else
                    nxtvno()
                End If
                vat = Val("")
                cst = Val("")
                fr = Val("")
                total = Val(txtTotal.Text)
                'calculation narration 
                i = 0
                For i = 0 To dgvoucher.Rows.Count - 1
                    'purchase a/c cr
                    'Getting Group name 
                    sql = "select group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_code='" & dgvoucher(1, i).Value & "'"
                    GMod.DataSetRet(sql, "heads")
                    g = GMod.ds.Tables("heads").Rows(0)("group_name").ToString
                    s = GMod.ds.Tables("heads").Rows(0)("sub_group_name").ToString
                    GMod.ds.Tables("heads").Dispose()
                    If g = "PARTY" Then
                        MsgBox("Please select correct head", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                    & " Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " _
                    & "Narration, Group_name, Sub_group_name,Ch_issue_date,ch_date,item_name,VoucherTax, TaxPer, TaxType, WinOut) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'-4',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & voutype.Text & "',"
                    sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & dgvoucher(1, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(2, i).Value & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'" & Val(dgvoucher(3, i).Value) & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narration & "',"
                    sqlsave &= "'" & g & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & PaymentDate.ToShortDateString & "',"
                    sqlsave &= "'" & dtbilldate.Value.ToString & "',"
                    sqlsave &= "'" & dgvoucher(22, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(11, i).Value & "',"
                    sqlsave &= "'" & _ggstper + _igstper & "',"
                    sqlsave &= "'" & dgvoucher(12, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(15, i).Value & "')"

                    Dim cmd3 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd3.ExecuteNonQuery()

                    If i > 0 Then
                        chgFlag = True
                        'txtSGStamt.Text = 0
                        'txtigstamt.Text = 0
                        'txtFreight.Text = 0
                        txtTotal.Text = 0
                    End If

                    If Val(dgvoucher(10, i).Value) > 0 Then
                        ' 'GST Dr Entry
                        sqlsave = " insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no," _
                     & " Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " _
                     & "Narration, Group_name, Sub_group_name,Ch_issue_date, VoucherTax, TaxPer, TaxType, WinOut) values ("
                        sqlsave &= "'" & GMod.Cmpid & "',"
                        sqlsave &= "'" & GMod.username & "',"
                        sqlsave &= "'-3',"
                        sqlsave &= "'" & lblvouno.Text & "',"
                        sqlsave &= "'" & voutype.Text & "',"
                        sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                        sqlsave &= "'" & dgvoucher(1, i).Value & "',"
                        sqlsave &= "'" & dgvoucher(2, i).Value & "',"
                        sqlsave &= "'0',"
                        sqlsave &= "'" & Val(dgvoucher(10, i).Value) & "',"
                        sqlsave &= "'-',"
                        sqlsave &= "'-',"
                        sqlsave &= "'" & narration & "',"
                        sqlsave &= "'" & g & "',"
                        sqlsave &= "'" & s & "',"
                        sqlsave &= "'" & PaymentDate.ToShortDateString & "',"

                        sqlsave &= "'" & dgvoucher(11, i).Value & "',"
                        sqlsave &= "'" & Val(dgvoucher(9, i).Value) & "',"
                        sqlsave &= "'" & dgvoucher(12, i).Value & "',"
                        sqlsave &= "'" & dgvoucher(15, i).Value & "')"
                        Dim cmd11 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                        cmd11.ExecuteNonQuery()
                    End If

                    If Val(dgvoucher(18, i).Value) > 0 Then
                        ' 'GST Dr Entry
                        sqlsave = " insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no," _
                     & " Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " _
                     & "Narration, Group_name, Sub_group_name,Ch_issue_date, VoucherTax, TaxPer, TaxType, WinOut) values ("
                        sqlsave &= "'" & GMod.Cmpid & "',"
                        sqlsave &= "'" & GMod.username & "',"
                        sqlsave &= "'-3',"
                        sqlsave &= "'" & lblvouno.Text & "',"
                        sqlsave &= "'" & voutype.Text & "',"
                        sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                        sqlsave &= "'" & dgvoucher(1, i).Value & "',"
                        sqlsave &= "'" & dgvoucher(2, i).Value & "',"
                        sqlsave &= "'0',"
                        sqlsave &= "'" & Val(dgvoucher(18, i).Value) & "',"
                        sqlsave &= "'-',"
                        sqlsave &= "'-',"
                        sqlsave &= "'" & narration & "',"
                        sqlsave &= "'" & g & "',"
                        sqlsave &= "'" & s & "',"
                        sqlsave &= "'" & PaymentDate.ToShortDateString & "',"

                        sqlsave &= "'" & dgvoucher(11, i).Value & "',"
                        sqlsave &= "'" & Val(dgvoucher(17, i).Value) & "',"
                        sqlsave &= "'" & dgvoucher(12, i).Value & "',"
                        sqlsave &= "'" & dgvoucher(15, i).Value & "')"
                        Dim cmd11 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                        cmd11.ExecuteNonQuery()
                    End If


                    sqlsave = "insert into othersaledata(Vou_type, Vou_no, AccCode, AccName, Station, ProductName, OutQty, Rate, Amount, " & _
                    " OutQtyNos, BillNo, BillDate, InQty, InQtyNos, Cmp_id, Session, id, mrktrate, " & _
                    " authr, Prdunit, Packing, Insurance, Discount, CrHead, " & _
                    " cmp_id, session, username,amt, party_amt, inwdate," & _
                    " cgstp, cgsta, sgstp, sgsta, igstp, igsta)  values ( "
                    sqlsave &= "'" & cmbPrdUnit.Text & "',"
                    sqlsave &= "'" & txtBillNo.Text & "',"
                    sqlsave &= "'" & dtbilldate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & voutype.Text & "',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbacheadcode.Text & "',"
                    sqlsave &= "'" & dgvoucher(1, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(2, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(6, i).Value & "',"
                    sqlsave &= "'" & Val(dgvoucher(7, i).Value) & "',"
                    sqlsave &= "'" & dgvoucher(4, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(5, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(15, i).Value & "',"
                    sqlsave &= "'" & Val(dgvoucher(14, i).Value) & "',"
                    sqlsave &= "'" & cmbfercode.Text & "',"
                    sqlsave &= "'" & Val(txtFreight.Text) & "',"
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.Session & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'" & Val(dgvoucher(3, i).Value) & "',"
                    sqlsave &= "'" & total & "',"

                    'sqlsave &= "'-',"
                    sqlsave &= "'" & dgvoucher(22, i).Value.ToString() & "',"
                    sqlsave &= "'" & dgvoucher(19, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(20, i).Value & "',"
                    sqlsave &= "'" & Val(dgvoucher(18, i).Value) & "',"
                    sqlsave &= "'" & Val(dgvoucher(8, i).Value) & "',"
                    sqlsave &= "'" & cmbferhead.Text & "',"
                    sqlsave &= "'" & cform.ToString & "',"

                    sqlsave &= "'-',"
                    sqlsave &= "'" & dtpf49issuedate.Text & "',"
                    sqlsave &= "'" & cmbBrokerCode.Text & "',"
                    sqlsave &= "'-',"

                    sqlsave &= "'" & dgvoucher(12, i).Value & "',"
                    sqlsave &= "'" & Val(dgvoucher(9, i).Value) & "',"
                    sqlsave &= "'" & Val(dgvoucher(10, i).Value) & "',"

                    sqlsave &= "'" & Val(txtPoly.Text) & "',"
                    sqlsave &= "'" & Val(txtJute.Text) & "',"

                    sqlsave &= "'" & Val(dgvoucher(21, i).Value) & "'," 'HSN CODE
                    sqlsave &= "'" & Val(dgvoucher(17, i).Value) & "',"
                    sqlsave &= "'" & dgvoucher(22, i).Value.ToString() & "',"
                    sqlsave &= "'" & dgvoucher(11, i).Value.ToString() & "')"

                    Dim cmd5 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd5.ExecuteNonQuery()

                Next 'end loop od items 


                'Customer A/C Dr
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
                sqlsave &= "'0',"
                sqlsave &= "'" & total & "',"
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


                'Credit A/C Entry
                'sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                '& " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
                '& "Narration, Group_name, Sub_group_name,Ch_issue_date,ch_date) values ("
                'sqlsave &= "'" & GMod.Cmpid & "',"
                'sqlsave &= "'" & GMod.username & "',"
                'sqlsave &= "'1',"
                'sqlsave &= "'" & lblvouno.Text & "',"
                'sqlsave &= "'" & voutype.Text & "',"
                'sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                'sqlsave &= "'" & cracccode.Text & "',"
                'sqlsave &= "'" & cracc.Text & "',"
                'sqlsave &= "'" & Val(txtcramt.Text) & "',"
                'sqlsave &= "'0',"
                'sqlsave &= "'-',"
                'sqlsave &= "'-',"
                'sqlsave &= "'" & narration & "',"
                'sqlsave &= "'" & craccgrp.Text & "',"
                'sqlsave &= "'-',"
                'sqlsave &= "'" & PaymentDate.ToShortDateString & "',"
                'sqlsave &= "'" & dtbilldate.Value.ToShortDateString & "')"
                ''MsgBox(sqlsave)
                'Dim cmdcr As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                'cmdcr.ExecuteNonQuery()




                If fr > 0 Then
                    'FREIGHT Cr
                    If OtherCheck = 0.0 Then
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
                        ' sqlsave &= "'" & cmbgrpferi.Text & "',"
                        sqlsave &= "'-','" & dtbilldate.Value.ToShortDateString & "')"
                        Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                        cmd4.ExecuteNonQuery()
                    Else
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
                        sqlsave &= "'0',"
                        sqlsave &= "'" & fr & "',"
                        sqlsave &= "'-',"
                        sqlsave &= "'-',"
                        sqlsave &= "'" & narration & "',"
                        'sqlsave &= "'" & cmbgrpferi.Text & "',"
                        sqlsave &= "'-','" & dtbilldate.Value.ToShortDateString & "')"
                        Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                        cmd4.ExecuteNonQuery()
                    End If
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

                    gridtotal()

                    If totgridamount <> Val(txtTotal.Text) Then
                        MsgBox("Amount not matching!!", MsgBoxStyle.Critical)
                        cmbacheadname.Focus()
                        cr = 0.0
                        pv = 0.0
                        gridtotal()
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
                '-----------------------------
                sqltrans.Commit()
                MessageBox.Show(voutype.Text & "/" & lblvouno.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtBillNo.Focus()
                vat = 0
                cst = 0
                fr = 0
                'nxtvno()
                lblvouno.Text = ""
                txtBillNo.Text = ""
                ' dgvoucher.Rows.Add()
                txtFreight.Text = "0"

                txtTotal.Text = ""

                ' txtVat_Leave(sender, e)
                txtFreight_Leave(sender, e)
                DataGridView1.Rows.Clear()



                dgvoucher.Rows.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
                sqltrans.Rollback()
            End Try
            sqltrans.Dispose()
        Else
            Exit Sub
        End If
        clear()
    End Sub
    Private Sub txtFreight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFreight.KeyPress
        'MsgBox(e.KeyChar)
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            ''e.Handled = True
            ''MsgBox("Invalid Charchter")
        End If
    End Sub
    Private Sub txtFreight_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFreight.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtFreight_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFreight.Leave
        'If cmbferhead.Items.Count = 0 Then
        If Val(txtFreight.Text) > 0 Then
            Dim Sqlfer As String
            Sqlfer = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sqlfer, "A4")
            cmbferhead.DataSource = GMod.ds.Tables("A4")
            cmbferhead.DisplayMember = "account_head_name"
            cmbfercode.DataSource = GMod.ds.Tables("A4")
            cmbfercode.DisplayMember = "account_code"
            'cmbgrpferi.DataSource = GMod.ds.Tables("A4")
            'cmbgrpferi.DisplayMember = "group_name"

        Else
            cmbferhead.Text = "-"
            ' cmbfercode.Text = "-"
            'cmbgrpferi.Text = "-"
        End If
        'End If
    End Sub
    Private Sub txtFreight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFreight.TextChanged
        If chgFlag = False Then
            gridtotal()
            If OtherCheck = 0.0 Then
                txtTotal.Text = -Val(txtFreight.Text) + gst + igst + totgridamount
            Else
                txtTotal.Text = Val(txtFreight.Text) + gst + igst + totgridamount
            End If
        End If
    End Sub
    Private Sub txtVat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub
    Private Sub txtVat_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtTotal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.Enter
        gridtotal()
        If OtherCheck = 0.0 Then
            txtTotal.Text = -Val(txtFreight.Text) + gst + igst + totgridamount
        Else
            txtTotal.Text = Val(txtFreight.Text) + gst + igst + totgridamount
        End If
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
            'Setting voucher date accrding to session
            'dtVdate.Value = GMod.SessionCurrentDate
            dtVdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
            dtVdate.MaxDate = GMod.SessionCurrentDate
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
        Dim narrstr() As String
        Try
            If btn_modify.Text = "&Modify" Then
                btnsave.Enabled = False
                btn_modify.Text = "&Update"
                'vt = InputBox("Enter Vouche Type to be modify?")
                vt = voutype.Text
                vou = InputBox("Enter Vouche No to be modify?")
                If vou <> "" And vt <> "" Then
                    lblvouno.Text = vou
                    voutype.Text = vt
                    voutype.Enabled = False
                    If LockDataCheck(vou, GMod.Session, voutype.Text) = False Then
                        'btnsave.Enabled = True
                        'MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'Exit Sub
                    End If
                    'For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, 
                    'party_code, item_code, item_name, Rate, lst_rate, Qty, 
                    'Unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno, 
                    'cmp_id, Session, username, amt, party_amt, inwdate, id, 
                    'vathead, csthead, cst_code, cst_amt, porate, fr_head

                    sql = " select * from Purchase_Data where vou_no='" & vou & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' AND VOU_TYPE='" & voutype.Text & "' and authr='-'"
                    GMod.DataSetRet(sql, "pur_modify")

                    sql = " select * from " & GMod.VENTRY & " where vou_no='" & vou & "' and cmp_id='" & GMod.Cmpid & "' AND VOU_TYPE='" & voutype.Text & "' and pay_mode='-'"
                    GMod.DataSetRet(sql, "get_narration")


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
                    cmbPrdUnit.Text = GMod.ds.Tables("pur_modify").Rows(0)("For_where")
                    cmbacheadcode.Text = GMod.ds.Tables("pur_modify").Rows(0)("party_code")
                    'txtnarration.Text = GMod.ds.Tables("pur_modify").Rows(0)("fr_head")
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

                        dgvoucher(9, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("gst_per")
                        dgvoucher(10, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("gst_amt")
                        dgvoucher(11, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("gst_head")
                        dgvoucher(12, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("gst_code")

                        dgvoucher(13, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("vat_per")
                        dgvoucher(14, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("varcst_amt")
                        dgvoucher(15, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("vathead")
                        dgvoucher(16, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("vatcst_code")

                        dgvoucher(17, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("cst_per")
                        dgvoucher(18, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("cst_amt")
                        dgvoucher(19, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("csthead")
                        dgvoucher(20, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("cst_code")

                        dgvoucher(21, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("form49No")
                        dgvoucher(22, j).Value = GMod.ds.Tables("pur_modify").Rows(j)("itemname")

                    Next
                    '  dgvoucher.Rows.RemoveAt(j)

                    narrstr = GMod.ds.Tables("get_narration").Rows(0)("narration").ToString().Split("#")
                    'txtnarration.Text = narrstr(2)

                    txtFreight.Text = GMod.ds.Tables("pur_modify").Rows(0)("fr_amt")
                    txtFreight_Leave(sender, e)
                    cmbfercode.Text = GMod.ds.Tables("pur_modify").Rows(0)("fr_code")


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
    Private Sub cmbvathead_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbvatcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbferhead_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbferhead.KeyUp
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
                        'cmbgstcode.Text = GMod.ds.Tables("PurVat").Rows(0)("Acc_head_code")
                        'cmbgsthead.Text = GMod.ds.Tables("PurVat").Rows(0)("Acc_head")
                        'If Val(GMod.ds.Tables("PurVat").Rows(0)("dramt")) > 0 Then
                        'txtSGStamt.Text = GMod.ds.Tables("PurVat").Rows(0)("dramt")
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

            txtTotal.Text = ""
        End If
    End Sub
    Private Sub txtBillNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNo.Leave

    End Sub
    Private Sub cmbacheadcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadcode.Leave
        'txtBillNo_Leave(sender, e)
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
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tg As New frmGeneralacchead
        tg.ShowDialog()

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
        Try
            If e.ColumnIndex = 6 Then
                'If Val(dgvoucher(4, e.RowIndex).Value) > 0 Then
                dgvoucher(6, e.RowIndex).Value = Math.Round(Val(dgvoucher(3, e.RowIndex).Value) / Val(dgvoucher(4, e.RowIndex).Value), 2)
                'End If
                'Else
                'dgvoucher(6, e.RowIndex).Value = 0
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub txtcstamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub
    Private Sub txtcstamt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
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
    Dim vouno As Long
    Dim ddate As DateTime = CDate("1/1/2000")
    Dim cr As Double = 0.0
    Dim pv As Double = 0.0
    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Escape Then
            txtref.Text = dg(0, dg.CurrentCell.RowIndex).Value
            txtamount.Text = dg(1, dg.CurrentCell.RowIndex).Value
            dg.Visible = False
            txtamount.Focus()
        End If
    End Sub
    Dim cform As Integer
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub voutype_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles voutype.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub voutype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voutype.SelectedIndexChanged
        Label17.Text = voutype.Text
    End Sub
    Private Sub lblvouno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblvouno.TextChanged

    End Sub
    Private Sub dtbilldate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtbilldate.ValueChanged

    End Sub
    Private Sub txtPoNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtImwno_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub dtpInwdate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbPrdUnit_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPrdUnit.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub dtpdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbcsthead_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbcstcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
    Private Sub cmbferhead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbferhead.Leave
        If Val(txtFreight.Text) > 0 Then
            If cmbferhead.FindStringExact(cmbferhead.Text) = -1 Then
                MsgBox("Please Select Correct A/c Head Name", MsgBoxStyle.Critical)
                cmbferhead.Focus()
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
    Dim i As Integer = -1
    Dim k As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cmbTaxType.Text = "GST" Then

            If Val(txtAmt.Text) > 0 Then
                _ggstamt = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
            End If
            _igstper = 0
            _igstamt = 0

            _ggstamt = Val(txtTdsAmt.Text)
        ElseIf cmbTaxType.Text = "IGST" Then
            If Val(txtAmt.Text) > 0 Then
                _igstamt = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
            End If
            _ggstper = 0
            _ggstamt = 0
            _igstamt = Math.Round(Val(txtTdsAmt.Text), 0)
        End If
        ' If Val(txtAmt.Text) > 0 Then
        'txtTdsAmt.Text = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
        'End If


        k = 1
        Dim obj() As Object = {k, cmbItemCode.Text, cmbItemHead.Text, txtAmt.Text, txtQty.Text, cmbunit.Text, txtRate.Text, "txtLastRate.Text", "txtPoRate.Text", _ggstper, _ggstamt, cmbVoucherTax.Text, cmbTaxType.Text, "", "", cmbWiOs.Text, "", _igstper, _igstamt, "", "", txtHsnCode.Text, cmbPrduct.Text}
        If i <> -1 Then
            dgvoucher.Rows.RemoveAt(i)
            dgvoucher.Rows.Insert(i, obj)
        Else
            dgvoucher.Rows.Add(obj)
        End If

        ' For j = 0 To dgPayment.Rows.Count - 1
        'dr = dr + Val(dgPayment(2, j).Value)
        'cr = cr + Val(dgPayment(3, j).Value)
        'Next
        'lblcr.Text = cr
        'lblDr.Text = dr
        'dr = 0
        cr = 0
        i = -1
        k = k + 1
        'cmbAcHead.Focus()
        'If Val(lblcr.Text) = Val(lblDr.Text) Then
        ' txtNarration.Focus()
        'Else
        'cmbAcHead.Focus()
        'End If
        'txtCrmat.Text = "0.0"
        'txtDramt.Text = "0.0"
        'txtNarration.Text = ""
        _gsttype = ""
        _ggstper = 0
        _igsttype = ""
        _igstper = 0
        _igstamt = 0
        _ggstamt = 0
        clear()
    End Sub
    Public Sub clear()
        txtAmt.Clear()
        txtQty.Clear()
        txtRate.Clear()

        txtPoly.Text = 0
        txtJute.Text = 0
        k = 1
    End Sub
    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        If Val(txtQty.Text) <> 0 Then
            txtRate.Text = Math.Round(Val(txtAmt.Text) / Val(txtQty.Text), 2)
        Else
            txtRate.Text = 0
        End If
    End Sub
    Private Sub dgvoucher_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvoucher.CellContentDoubleClick
        Try
            i = e.RowIndex
            'cmbcode.Text = dgPayment(1, i).Value.ToString
            cmbItemHead.Text = dgvoucher(2, i).Value.ToString
            txtHsnCode.Text = dgvoucher(21, i).Value.ToString
            txtAmt.Text = dgvoucher(3, i).Value.ToString
            txtQty.Text = dgvoucher(4, i).Value.ToString
            txtRate.Text = dgvoucher(6, i).Value.ToString
            cmbunit.Text = dgvoucher(5, i).Value.ToString

            txtHsnCode.Text = dgvoucher(21, i).Value.ToString

            cmbVoucherTax.Text = dgvoucher(11, i).Value.ToString
            cmbTaxType.Text = dgvoucher(12, i).Value.ToString
            If dgvoucher(12, i).Value.ToString = "GST" Then
                cmbPer.Text = dgvoucher(9, i).Value.ToString
            Else
                cmbPer.Text = dgvoucher(17, i).Value.ToString
            End If


            cmbPrduct.Text = dgvoucher(22, i).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmbVoucherTax_Leave(sender As Object, e As EventArgs) Handles cmbVoucherTax.Leave
        cmbVoucherTax_SelectedIndexChanged(sender, e)
        If Val(txtAmt.Text) > 0 Then
            txtTdsAmt.Text = Val(txtAmt.Text) * (Val(cmbPer.Text) / 100)
        End If
    End Sub
    Private Sub cmbVoucherTax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVoucherTax.SelectedIndexChanged
        Dim sql As String
        If cmbVoucherTax.Text = "TDS" Then
            sql = "select TdsType from dbo.TdsMater where cmp_id ='PHOE'"
            GMod.DataSetRet(sql, "TdsType")
            cmbTaxType.DataSource = GMod.ds.Tables("TdsType")
            cmbTaxType.DisplayMember = "TdsType"

        ElseIf cmbVoucherTax.Text = "GST" Then
            sql = "select distinct GST from GST where cmp_id ='PHOE'"
            GMod.DataSetRet(sql, "TdsType")
            cmbTaxType.DataSource = GMod.ds.Tables("TdsType")
            cmbTaxType.DisplayMember = "GST"

        ElseIf cmbVoucherTax.Text = "-" Then
            cmbTaxType.DataSource = Nothing
        End If
        If Val(txtAmt.Text) > 0 Then
            txtTdsAmt.Text = Val(txtAmt.Text) * (Val(cmbPer.Text) / 100)
        End If
    End Sub
    Private Sub cmbTaxType_Leave(sender As Object, e As EventArgs) Handles cmbTaxType.Leave
        cmbTaxType_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub cmbTaxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTaxType.SelectedIndexChanged
        Dim sql As String
        If cmbVoucherTax.Text = "TDS" Then
            sql = "select per from dbo.TdsMater where cmp_id ='" & GMod.Cmpid & "' and TdsType ='" & cmbTaxType.Text & "'"
            GMod.DataSetRet(sql, "Tdsper")
            cmbPer.DataSource = GMod.ds.Tables("Tdsper")
            cmbPer.DisplayMember = "per"
        ElseIf cmbVoucherTax.Text = "GST" Then
            sql = "select per from dbo.GST where gst ='" & cmbTaxType.Text & "'"
            GMod.DataSetRet(sql, "Tdsper")
            cmbPer.DataSource = GMod.ds.Tables("Tdsper")
            cmbPer.DisplayMember = "per"
            If cmbTaxType.Text = "GST" Then
                _gsttype = cmbTaxType.Text
                _ggstper = Val(cmbPer.Text)
                cmbWiOs.Text = "W-S"
            ElseIf cmbTaxType.Text = "IGST" Then
                _igsttype = cmbTaxType.Text
                _igstper = Val(cmbPer.Text)
                cmbWiOs.Text = "O-S"
            Else
                cmbWiOs.Text = "-"
            End If
        ElseIf cmbVoucherTax.Text = "-" Then
            cmbPer.DataSource = Nothing
        End If
        ' WITH IN
        'OUT OF
    End Sub
    Private Sub cmbPer_Leave(sender As Object, e As EventArgs) Handles cmbPer.Leave
        If Val(txtAmt.Text) > 0 Then
            txtTdsAmt.Text = Val(txtAmt.Text) * (Val(cmbPer.Text) / 100)
        End If
    End Sub
    Private Sub cmbPer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPer.SelectedIndexChanged
        If cmbTaxType.Text = "GST" Then
            _gsttype = cmbTaxType.Text
            _ggstper = Val(cmbPer.Text)
            If Val(txtAmt.Text) > 0 Then
                _ggstamt = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
            End If
            _igsttype = ""
            _igstper = 0
            _igstamt = 0
        ElseIf cmbTaxType.Text = "IGST" Then
            _igsttype = cmbTaxType.Text
            _igstper = Val(cmbPer.Text)
            If Val(txtAmt.Text) > 0 Then
                _igstamt = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
            End If
            _gsttype = ""
            _ggstper = 0
            _ggstamt = 0
        End If
        If Val(txtAmt.Text) > 0 Then
            txtTdsAmt.Text = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
        End If
    End Sub
    Private Sub cmbPrdType_Leave(sender As Object, e As EventArgs) Handles cmbPrdType.Leave
        GMod.DataSetRet("select itemname,unit from ItemMasterOther where prdtype =1 and CAT='" & cmbPrdType.Text & "'", "puritems")
        cmbPrduct.DataSource = GMod.ds.Tables("puritems")
        cmbPrduct.DisplayMember = "itemname"

        cmbunit.DataSource = GMod.ds.Tables("puritems")
        cmbunit.DisplayMember = "unit"


    End Sub
    Private Sub txtAmt_TextChanged(sender As Object, e As EventArgs) Handles txtAmt.TextChanged
        If Val(txtAmt.Text) > 0 Then
            txtTdsAmt.Text = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
        End If
        If Val(txtAmt.Text) <> 0 Then
            txtRate.Text = Math.Round(Val(txtAmt.Text) / Val(txtQty.Text), 2)
        Else
            txtRate.Text = 0
        End If
    End Sub
    Private Sub cmbPrduct_Leave(sender As Object, e As EventArgs) Handles cmbPrduct.Leave
        ' MessageBox.Show(cmbPrduct.Text)
        If Len(cmbPrduct.Text) = 0 Then
            MsgBox("Please Select Product .", MsgBoxStyle.Critical)
            cmbPrduct.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub cmbPrduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrduct.SelectedIndexChanged

    End Sub
    Private Sub cmbWiOs_Leave(sender As Object, e As EventArgs) Handles cmbWiOs.Leave
        If cmbWiOs.Text = "" Then
            MsgBox("Please Select W/S .", MsgBoxStyle.Critical)
            cmbWiOs.Focus()
            Exit Sub
        End If
    End Sub
End Class