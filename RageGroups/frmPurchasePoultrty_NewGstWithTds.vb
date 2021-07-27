Imports System.Data.SqlClient
Public Class frmPurchasePoultrty_NewGstWithTds

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
        ''Resting date
        'GMod.DataSetRet("select getdate()", "serverdate")
        'dtVdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        'dtVdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

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

        Me.dtpdate.Value = CDate("1/1/2000")
        Label6.Text = "PURCHASE - " + GMod.Cmpname

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

        sql = "select * from TdsMater where cmp_id ='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "tdm")

        cmbtdsType.DataSource = GMod.ds.Tables("tdm")
        cmbtdsType.DisplayMember = "TdsType"


        cmbTdsper.DataSource = GMod.ds.Tables("tdm")
        cmbTdsper.DisplayMember = "Per"

        cmbacheadcodetds.DataSource = GMod.ds.Tables("tdm")
        cmbacheadcodetds.DisplayMember = "Acc_Code"


        sql = "select * from [TCSMaster] where cmp_id ='" & GMod.Cmpid & "' and type = 0"
        GMod.DataSetRet(sql, "tcsmaster")

        cmbTCSType.DataSource = GMod.ds.Tables("tcsmaster")
        cmbTCSType.DisplayMember = "TcsType"


        cmbTCSper.DataSource = GMod.ds.Tables("tcsmaster")
        cmbTCSper.DisplayMember = "Per"

        cmbacheadcodeTCS.DataSource = GMod.ds.Tables("tcsmaster")
        cmbacheadcodeTCS.DisplayMember = "Acc_Code"

        GMod.DataSetRet("select stock_val from company where cmp_id ='" & GMod.Cmpid & "'", "othercmpCheck")
        If Val(GMod.ds.Tables("othercmpCheck").Rows(0)(0)) = 1.11 Then
            OtherCheck = 1.11
        Else
            OtherCheck = 0
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
    Public Sub Save()
        If Val("") > 0 Then
            ChkCform.Checked = True
        Else
            ChkCform.Checked = False
        End If
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
            If txtPoNo.Text = "" Then
                MsgBox("Please Enter Purchase Order No.")
                txtPoNo.Focus()
                Exit Sub
            End If
            If txtImwno.Text = "" Then
                MsgBox("Please Enter Inward No.")
                txtImwno.Focus()
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
            Checkbill()
            PaymentDate = Me.dtpdate.Value
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

                    sqldel = "delete  from purchase_data where  Vou_no= '" & lblvouno.Text & "' and Vou_type='" & voutype.Text & "' and Cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                    Dim cmddel2 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmddel2.ExecuteNonQuery()

                    sql = "delete from Purchase_Payment where vou_type='" & voutype.Text & "' and  vou_no='" & lblvouno.Text & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    Dim cmddel As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmddel.ExecuteNonQuery()

                    sql = "delete from tdsentry where vou_type='" & voutype.Text & "' and  vou_no='" & lblvouno.Text & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    Dim cmddeltds As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmddeltds.ExecuteNonQuery()

                Else
                    nxtvno()
                End If
                vat = Val("")
                cst = Val("")
                fr = Val("")
                total = Val(txtTotal.Text)


                'calculation narration 
                narration = "BILL NO " & txtBillNo.Text.Trim() & " DT." & dtbilldate.Text & ""
                If Val(dgvoucher(4, i).Value) > 0 Then
                    For i = 0 To dgvoucher.Rows.Count - 1
                        narr = narr & dgvoucher(22, i).Value & "," & dgvoucher(2, i).Value & " " & dgvoucher(4, i).Value & " " & dgvoucher(5, i).Value & " @" & dgvoucher(6, i).Value & "," & dgvoucher(15, i).Value & ","
                    Next
                End If

                narration = narration & " " & narr & "#" & txtnarration.Text
                If TxtVehNo.Text <> "" Then
                    narration = narration & "Veh.no-" & TxtVehNo.Text & " Inw. No.-" & txtImwno.Text & " Inw Date " & dtpInwdate.Value.ToString("dd-MMM-yyyy") & " #PO.No/" & txtPoNo.Text
                Else
                    narration = narration & " Inw. No.-" & txtImwno.Text & " Inw Date " & dtpInwdate.Value.ToString("dd-MMM-yyyy") & " #PO.No/" & txtPoNo.Text
                End If

                If TxtStockNo.Text <> "" Then
                    narration = narration & "Stock No-" & TxtStockNo.Text & "#"
                Else
                    'narration = narration & "Stock No-" & TxtStockNo.Text & "#"
                End If

                If True Then

                End If

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
                    & "Narration, Group_name, Sub_group_name,Ch_issue_date,ch_date,item_name) values ("
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
                    sqlsave &= "'" & dtbilldate.Value.ToString & "',"
                    sqlsave &= "'" & dgvoucher(22, i).Value & "')"

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
                        sqlsave &= "'" & Val(dgvoucher(10, i).Value) & "',"
                        sqlsave &= "'0',"
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
                        sqlsave &= "'" & Val(dgvoucher(18, i).Value) & "',"
                        sqlsave &= "'0',"
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

                    sqlsave = "insert into Purchase_Data( For_where, Bill_no, Bill_date,vou_type, vou_no, " & _
                    " vou_date, party_code, item_code, item_name, rate, lst_rate, qty, " & _
                    " unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno, " & _
                    " cmp_id, session, username,amt, party_amt, inwdate," & _
                    " vathead, csthead, cst_code, cst_amt, porate,fr_head,cform,po_date, form49No, form49issue,Broker_Code,mkt_rate,gst_code, gst_per, gst_amt, poly, jute,vat_per,cst_per,itemname,gst_head)  values ( "
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
                    If i = 0 Then
                        sqlsave &= "'" & Val(txtTdsAmt1.Text) & "'," 'varcst_amt BEFORE 12-7-21  Val(dgvoucher(14, i).Value)
                    Else
                        sqlsave &= "'" & Val("") & "',"
                    End If
                    sqlsave &= "'" & cmbfercode.Text & "',"

                    If i = 0 Then
                        sqlsave &= "'" & Val(txtTcsAmount.Text) & "',"
                    Else
                        sqlsave &= "'" & Val("") & "',"
                    End If
                    sqlsave &= "'" & txtPoNo.Text & "',"
                    sqlsave &= "'" & txtImwno.Text & "',"
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.Session & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'" & Val(dgvoucher(3, i).Value) & "',"
                    sqlsave &= "'" & total & "',"
                    sqlsave &= "'" & dtpInwdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & dgvoucher(22, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(19, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(20, i).Value & "',"
                    sqlsave &= "'" & Val(dgvoucher(18, i).Value) & "',"
                    sqlsave &= "'" & Val(dgvoucher(8, i).Value) & "',"
                    sqlsave &= "'" & cmbferhead.Text & "',"
                    sqlsave &= "'" & cform.ToString & "',"
                    sqlsave &= "'" & dtpdate.Value.ToShortTimeString & "',"
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

                'TCS Amount Debit Entry 
                If Val(txtTcsAmount.Text) > 0 Then
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                    & " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
                    & "Narration, Group_name, Sub_group_name,Ch_issue_date,ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'1',"
                    sqlsave &= "'" & lblvouno.Text & "',"
                    sqlsave &= "'" & voutype.Text & "',"
                    sqlsave &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbacheadcodeTCS.Text & "',"
                    sqlsave &= "'" & cmbTcsHead.Text & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'" & Val(txtTcsAmount.Text) & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narration & "',"
                    sqlsave &= "'" & CmbTcsGroup.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & PaymentDate.ToShortDateString & "',"
                    sqlsave &= "'" & dtbilldate.Value.ToShortDateString & "')"
                    'MsgBox(sqlsave)
                    Dim cmdTcs As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmdTcs.ExecuteNonQuery()

                    'Insert into TCS Report
                    sql = "insert into TdsEntry(Vou_Type, Vou_no, TdsType, Per, TdsDate, " _
                                  & " BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt," _
                                  & " Actualamt, session,Paidto,vou_date, TdsAmt,dcode,cmp_id,taxtype ) values( "
                    sql &= "'" & voutype.Text & "',"
                    sql &= "'" & lblvouno.Text & "',"
                    sql &= "'" & cmbTCSType.Text & "',"
                    sql &= "'" & cmbTCSper.Text & "',"
                    sql &= "'" & dtbilldate.Value.ToShortDateString & "',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'0',"
                    sql &= "'" & Val(txtGrandTotal.Text) & "',"
                    sql &= "'" & Val("") & "',"
                    sql &= "'" & GMod.Session & "',"
                    sql &= "'YES',"
                    sql &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sql &= "'" & Val(txtTcsAmount.Text) & "',"
                    sql &= "'" & cmbacheadcode.Text & "',"
                    sql &= "'" & GMod.Cmpid & "','1')"

                    Dim cmdTcsReport As New SqlCommand(sql, SqlConn, sqltrans)
                    cmdTcsReport.ExecuteNonQuery()

                End If

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
                sqlsave &= "'" & total - Val("") + Val(txtTcsAmount.Text) & "',"
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
                'FOR TDS
                If Val(txtTdsAmt1.Text) > 0 Then
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
                    sqlsave &= "'" & Val(txtTdsAmt1.Text) & "',"
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
                    sql &= "'" & Val(txtTdsAmt1.Text) & "',"
                    sql &= "'" & cmbacheadcode.Text & "',"
                    sql &= "'" & GMod.Cmpid & "')"

                    Dim cmd6 As New SqlCommand(sql, SqlConn, sqltrans)
                    cmd6.ExecuteNonQuery()
                End If

                'gridtotal()

                'If totgridamount <> Val(txtTotal.Text) Then
                '    MsgBox("Amount not matching!!", MsgBoxStyle.Critical)
                '    cmbacheadname.Focus()
                '    cr = 0.0
                '    pv = 0.0
                '    gridtotal()
                '    Exit Sub
                'End If

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

                txtTotal.Text = "0"
                tdspidamt.Text = "0"
                txtTdsAmt1.Text = "0"

                ' txtVat_Leave(sender, e)
                ' txtFreight_Leave(sender, e)

                ChkCform.Checked = False
                chgFlag = False
                txtPoNo.Text = ""
                txtImwno.Text = ""
                TxtVehNo.Text = ""
                TxtStockNo.Text = ""

                txtnarration.Clear()
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
    Public Sub Reverse()
        If Val("") > 0 Then
            ChkCform.Checked = True
        Else
            ChkCform.Checked = False
        End If
        If MessageBox.Show("Are U Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
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
            If txtPoNo.Text = "" Then
                MsgBox("Please Enter Purchase Order No.")
                txtPoNo.Focus()
                Exit Sub
            End If
            If txtImwno.Text = "" Then
                MsgBox("Please Enter Inward No.")
                txtImwno.Focus()
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
            PaymentDate = Me.dtpdate.Value
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

                    sqldel = "delete  from purchase_data where  Vou_no= '" & lblvouno.Text & "' and Vou_type='" & voutype.Text & "' and Cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                    Dim cmddel2 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmddel2.ExecuteNonQuery()

                    sql = "delete from Purchase_Payment where vou_type='" & voutype.Text & "' and  vou_no='" & lblvouno.Text & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    Dim cmddel As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmddel.ExecuteNonQuery()

                    sql = "delete from tdsentry where vou_type='" & voutype.Text & "' and  vou_no='" & lblvouno.Text & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    Dim cmddeltds As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmddeltds.ExecuteNonQuery()

                Else
                    nxtvno()
                End If
                vat = Val("")
                cst = Val("")
                fr = Val("")
                total = Val(txtTotal.Text)


                'calculation narration 
                narration = "BILL NO " & txtBillNo.Text.Trim() & " DT." & dtbilldate.Text & ""
                If Val(dgvoucher(4, i).Value) > 0 Then
                    For i = 0 To dgvoucher.Rows.Count - 1
                        narr = narr & dgvoucher(22, i).Value & "," & dgvoucher(2, i).Value & " " & dgvoucher(4, i).Value & " " & dgvoucher(5, i).Value & " @" & dgvoucher(6, i).Value & "," & dgvoucher(15, i).Value & ","
                    Next
                End If

                narration = narration & " " & narr & "#" & txtnarration.Text
                If TxtVehNo.Text <> "" Then
                    narration = narration & "Veh.no-" & TxtVehNo.Text & " Inw. No.-" & txtImwno.Text & " Inw Date " & dtpInwdate.Value.ToString("dd-MMM-yyyy") & " #PO.No/" & txtPoNo.Text
                Else
                    narration = narration & " Inw. No.-" & txtImwno.Text & " Inw Date " & dtpInwdate.Value.ToString("dd-MMM-yyyy") & " #PO.No/" & txtPoNo.Text
                End If

                If TxtStockNo.Text <> "" Then
                    narration = narration & "Stock No-" & TxtStockNo.Text & "#"
                Else
                    'narration = narration & "Stock No-" & TxtStockNo.Text & "#"
                End If

                If True Then

                End If

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
                    & "Narration, Group_name, Sub_group_name,Ch_issue_date,ch_date,item_name) values ("
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
                    sqlsave &= "'" & dgvoucher(22, i).Value & "')"

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




                    sqlsave = "insert into Purchase_Data( For_where, Bill_no, Bill_date,vou_type, vou_no, " & _
                    " vou_date, party_code, item_code, item_name, rate, lst_rate, qty, " & _
                    " unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno, " & _
                    " cmp_id, session, username,amt, party_amt, inwdate," & _
                    " vathead, csthead, cst_code, cst_amt, porate,fr_head,cform,po_date, form49No, form49issue,Broker_Code,mkt_rate,gst_code, gst_per, gst_amt, poly, jute,vat_per,cst_per,itemname,gst_head)  values ( "
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
                    sqlsave &= "'-" & Val(dgvoucher(7, i).Value) & "',"
                    sqlsave &= "'" & dgvoucher(4, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(5, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(15, i).Value & "',"
                    sqlsave &= "'-" & Val(dgvoucher(14, i).Value) & "',"
                    sqlsave &= "'" & cmbfercode.Text & "',"
                    sqlsave &= "'-" & Val(txtFreight.Text) & "',"
                    sqlsave &= "'" & txtPoNo.Text & "',"
                    sqlsave &= "'" & txtImwno.Text & "',"
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.Session & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'-" & Val(dgvoucher(3, i).Value) & "',"
                    sqlsave &= "'" & total & "',"
                    sqlsave &= "'" & dtpInwdate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & dgvoucher(22, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(19, i).Value & "',"
                    sqlsave &= "'" & dgvoucher(20, i).Value & "',"
                    sqlsave &= "'-" & Val(dgvoucher(18, i).Value) & "',"
                    sqlsave &= "'-" & Val(dgvoucher(8, i).Value) & "',"
                    sqlsave &= "'" & cmbferhead.Text & "',"
                    sqlsave &= "'" & cform.ToString & "',"
                    sqlsave &= "'" & dtpdate.Value.ToShortTimeString & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & dtpf49issuedate.Text & "',"
                    sqlsave &= "'" & cmbBrokerCode.Text & "',"
                    sqlsave &= "'-',"

                    sqlsave &= "'" & dgvoucher(12, i).Value & "',"
                    sqlsave &= "'" & Val(dgvoucher(9, i).Value) & "',"
                    sqlsave &= "'-" & Val(dgvoucher(10, i).Value) & "',"

                    sqlsave &= "'-" & Val(txtPoly.Text) & "',"
                    sqlsave &= "'-" & Val(txtJute.Text) & "',"

                    sqlsave &= "'-" & Val(dgvoucher(21, i).Value) & "'," 'HSN CODE
                    sqlsave &= "'-" & Val(dgvoucher(17, i).Value) & "',"
                    sqlsave &= "'" & dgvoucher(22, i).Value.ToString() & "',"
                    sqlsave &= "'" & dgvoucher(11, i).Value.ToString() & "')"

                    Dim cmd5 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd5.ExecuteNonQuery()

                Next 'end loop od items 


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

                sqlsave &= "'0',"
                sqlsave &= "'" & total - Val("") & "',"
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
                'FOR TDS
                If Val(txtTdsAmt1.Text) > 0 Then
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

                    sqlsave &= "'0',"
                    sqlsave &= "'" & Val(txtTdsAmt1.Text) & "',"
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
                    sql &= "'-" & Val(tdspidamt.Text) & "',"
                    sql &= "'" & Val("") & "',"
                    sql &= "'" & GMod.Session & "',"
                    sql &= "'YES',"
                    sql &= "'" & dtVdate.Value.ToShortDateString & "',"
                    sql &= "'-" & Val(txtTdsAmt1.Text) & "',"
                    sql &= "'" & cmbacheadcode.Text & "',"
                    sql &= "'" & GMod.Cmpid & "')"

                    Dim cmd6 As New SqlCommand(sql, SqlConn, sqltrans)
                    cmd6.ExecuteNonQuery()
                End If

                'gridtotal()

                'If totgridamount <> Val(txtTotal.Text) Then
                '    MsgBox("Amount not matching!!", MsgBoxStyle.Critical)
                '    cmbacheadname.Focus()
                '    cr = 0.0
                '    pv = 0.0
                '    gridtotal()
                '    Exit Sub
                'End If

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

                txtTotal.Text = "0"
                tdspidamt.Text = "0"
                txtTdsAmt1.Text = "0"

                ' txtVat_Leave(sender, e)
                'txtFreight_Leave(sender, e)

                ChkCform.Checked = False
                chgFlag = False
                txtPoNo.Text = ""
                txtImwno.Text = ""
                TxtVehNo.Text = ""
                TxtStockNo.Text = ""

                txtnarration.Clear()
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

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If CheckBox4.Checked = False Then
            Save()
        ElseIf CheckBox4.Checked = True Then
            Reverse()
        End If
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
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Dim t As New frmPartyaccount
            Dim sql As String
            sql = "select Group_name,Suffix from Groups where Group_name like '%PARTY%' and Cmp_id='" & GMod.Cmpid & "'  and session = '" & GMod.Session & "'"
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
        'If btnsave.Enabled = True Then
        '    GMod.DataSetRet("select getdate()", "serverdate")
        '    dtVdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        '    dtVdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        'Else
        '    GMod.DataSetRet("select getdate()", "serverdate")
        '    dtVdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        '    dtVdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        'End If

        'dtVdate.Value = GMod.SessionCurrentDate
        dtVdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtVdate.MaxDate = GMod.SessionCurrentDate
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
                    dtVdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
                    dtVdate.Value = Convert.ToDateTime(GMod.ds.Tables("pur_modify").Rows(0)("vou_date"))
                    txtBillNo.Text = GMod.ds.Tables("pur_modify").Rows(0)("Bill_no")
                    dtbilldate.Value = CDate(GMod.ds.Tables("pur_modify").Rows(0)("Bill_date"))
                    txtPoNo.Text = GMod.ds.Tables("pur_modify").Rows(0)("pono")
                    txtImwno.Text = GMod.ds.Tables("pur_modify").Rows(0)("inwno")
                    dtpInwdate.Value = CDate(GMod.ds.Tables("pur_modify").Rows(0)("inwdate"))
                    cmbPrdUnit.Text = GMod.ds.Tables("pur_modify").Rows(0)("For_where")
                    cmbacheadcode.Text = GMod.ds.Tables("pur_modify").Rows(0)("party_code")
                    txtnarration.Text = GMod.ds.Tables("pur_modify").Rows(0)("fr_head")
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
                    txtnarration.Text = narrstr(2)

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
    Public Function Checkbill()
        Dim ch As String
        ch = "select bill_no from purchase_data where session ='" & GMod.Session & "' and party_code='" & cmbacheadcode.Text.Trim & "' and bill_no='" & txtBillNo.Text.Trim & "' and vou_type<>'DR NOTE(PUR)'" ' and authr <>'-'"
        GMod.DataSetRet(ch, "chk_bill")
        If GMod.ds.Tables("chk_bill").Rows.Count > 0 Then
            MessageBox.Show("Duplicate bill", "Duplicate bill", MessageBoxButtons.OKCancel)
            txtBillNo.Focus()
            'Exit Sub
            Me.Close()
        End If
    End Function
    Private Sub cmbacheadcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadcode.Leave
        'txtBillNo_Leave(sender, e)
        Checkbill()

        sql = "select *  from tmpAging where acc_code ='" & cmbacheadcode.Text & "' and vou_type='P' and cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "jj")
        If GMod.ds.Tables("jj").Rows.Count > 0 Then
            MsgBox("Please select diffent head")
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
    Private Sub cmbRefType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Dim sqlsavecr As String
    Dim vouno As Long
    Dim ddate As DateTime = CDate("1/1/2000")
    Dim cr As Double = 0.0
    Dim pv As Double = 0.0



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

    Private Sub txtref_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtduedate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtamount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub btnOk_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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

            k = 1
            Dim obj() As Object = {k, cmbItemCode.Text, cmbItemHead.Text, txtAmt.Text, txtQty.Text, cmbunit.Text, txtRate.Text, txtLastRate.Text, txtPoRate.Text, _ggstper, _ggstamt, cmbVoucherTax.Text, cmbTaxType.Text, "", "", cmbWiOs.Text, "", _igstper, _igstamt, "", "", txtHsnCode.Text, cmbPrduct.Text}
            If i <> -1 Then
                dgvoucher.Rows.RemoveAt(i)
                dgvoucher.Rows.Insert(i, obj)
            Else
                dgvoucher.Rows.Add(obj)
            End If

        ElseIf cmbTaxType.Text = "IGST" Then
            If Val(txtAmt.Text) > 0 Then
                _igstamt = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
            End If
            _ggstper = 0
            _ggstamt = 0
            _igstamt = Val(txtTdsAmt.Text)
            k = 1
            Dim obj() As Object = {k, cmbItemCode.Text, cmbItemHead.Text, txtAmt.Text, txtQty.Text, cmbunit.Text, txtRate.Text, txtLastRate.Text, txtPoRate.Text, _ggstper, _ggstamt, cmbVoucherTax.Text, cmbTaxType.Text, "", "", cmbWiOs.Text, "", _igstper, _igstamt, "", "", txtHsnCode.Text, cmbPrduct.Text}
            If i <> -1 Then
                dgvoucher.Rows.RemoveAt(i)
                dgvoucher.Rows.Insert(i, obj)
            Else
                dgvoucher.Rows.Add(obj)
            End If
        ElseIf cmbTaxType.Text = "" Then
            _gsttype = ""
            _ggstper = 0
            _igsttype = ""
            _igstper = 0
            _igstamt = 0
            _ggstamt = 0
            If Val(txtAmt.Text) > 0 Then
                _igstamt = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
            End If
            _ggstper = 0
            _ggstamt = 0
            _igstamt = Val(txtTdsAmt.Text)
            k = 1
            Dim obj() As Object = {k, cmbItemCode.Text, cmbItemHead.Text, txtAmt.Text, txtQty.Text, cmbunit.Text, txtRate.Text, txtLastRate.Text, txtPoRate.Text, _ggstper, _ggstamt, cmbVoucherTax.Text, cmbTaxType.Text, "", "", cmbWiOs.Text, "", _igstper, _igstamt, "", "", txtHsnCode.Text, cmbPrduct.Text}
            If i <> -1 Then
                dgvoucher.Rows.RemoveAt(i)
                dgvoucher.Rows.Insert(i, obj)
            Else
                dgvoucher.Rows.Add(obj)
            End If
        End If
        ' If Val(txtAmt.Text) > 0 Then
        'txtTdsAmt.Text = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
        'End If




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
        txtLastRate.Clear()
        txtPoRate.Clear()
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
            txtLastRate.Text = dgvoucher(7, i).Value.ToString
            txtPoRate.Text = dgvoucher(8, i).Value.ToString
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
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Dim t As New frmRCMVou
            t.txtBillNo.Text = txtBillNo.Text
            t.dtbilldate.Value = dtbilldate.Value
            t.ShowDialog()
            CheckBox3.Checked = False
        Else

        End If
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
            sql = "select TdsType from dbo.TdsMater where cmp_id ='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "TdsType")
            cmbTaxType.DataSource = GMod.ds.Tables("TdsType")
            cmbTaxType.DisplayMember = "TdsType"

        ElseIf cmbVoucherTax.Text = "GST" Then
            sql = "select distinct GST from GST where cmp_id ='" & GMod.Cmpid & "'"
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
        GMod.DataSetRet("select itemname from ItemMasterOther where prdtype =1 and CAT='" & cmbPrdType.Text & "'", "puritems")
        cmbPrduct.DataSource = GMod.ds.Tables("puritems")
        cmbPrduct.DisplayMember = "itemname"
    End Sub

    Private Sub cmbPrdType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrdType.SelectedIndexChanged
        GMod.DataSetRet("select itemname from ItemMasterOther where prdtype =1 and CAT='" & cmbPrdType.Text & "'", "puritems")
        cmbPrduct.DataSource = GMod.ds.Tables("puritems")
        cmbPrduct.DisplayMember = "itemname"
    End Sub

    Private Sub txtAmt_TextChanged(sender As Object, e As EventArgs) Handles txtAmt.TextChanged
        If Val(txtAmt.Text) > 0 Then
            txtTdsAmt.Text = Math.Round(Val(txtAmt.Text) * (Val(cmbPer.Text) / 100), 0)
        End If
    End Sub

    Private Sub cmbPrduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrduct.SelectedIndexChanged

    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

    End Sub

    Private Sub cmbacheadcodetds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbacheadcodetds.SelectedIndexChanged
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTdsAmt1.TextChanged
        If chgFlag = False Then
            gridtotal()
            txtTotal.Text = -Val(txtFreight.Text) - Val(txtTdsAmt1.Text) + totgridamount + gst + igst
        End If
    End Sub

    Private Sub tdspidamt_TextChanged(sender As Object, e As EventArgs) Handles tdspidamt.TextChanged
        If Val(tdspidamt.Text) > 0 Then
            txtTdsAmt1.Text = Math.Round(Val(tdspidamt.Text) * (Val(cmbTdsper.Text) / 100))
        End If
    End Sub

   
    Private Sub cmbacheadcodeTCS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbacheadcodeTCS.SelectedIndexChanged
        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and account_code='" & cmbacheadcodeTCS.Text & "'"
        GMod.DataSetRet(sql, "tcsaclist2")
        cmbTcsCode.DataSource = GMod.ds.Tables("tcsaclist2")
        cmbTcsCode.DisplayMember = "account_code"
        cmbTcsHead.DataSource = GMod.ds.Tables("tcsaclist2")
        cmbTcsHead.DisplayMember = "account_head_name"
        CmbTcsGroup.DataSource = GMod.ds.Tables("tcsaclist2")
        CmbTcsGroup.DisplayMember = "group_name"
        cmbTcsSubGroup.DataSource = GMod.ds.Tables("tcsaclist2")
        cmbTcsSubGroup.DisplayMember = "sub_group_name"
    End Sub

    Private Sub txtTcsAmount_TextChanged(sender As Object, e As EventArgs) Handles txtTcsAmount.TextChanged
        txtGrandTotal.Text = Val(txtTcsAmount.Text) + Val(txtTotal.Text)
    End Sub

 
End Class