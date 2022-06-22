Imports System.Data.SqlClient
Public Class frmSaleInvoice
    Dim ach As New frmacheadlist
    Dim frmnarrationlistobj As New frmNarrationEntrybox

    Private Sub frmSaleInvoice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='S' and cmp_id='" & GMod.Cmpid & "'")
    End Sub
    Private Sub frmSaleInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        'Setting Date as per Session
        dtdate.Value = GMod.SessionCurrentDate
        dtdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtdate.MaxDate = GMod.SessionCurrentDate

        'filling production unit 
        GMod.DataSetRet("select prdunit from prdunit where cmp_id='" & GMod.Cmpid & "'", "prdunit")
        cmbPrdUnit.DataSource = GMod.ds.Tables("prdunit")
        cmbPrdUnit.DisplayMember = "prdunit"


        'If GMod.Cmpid = "PHHA" Then
        '    voutype.Text = "SALE"
        'Else
        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vgrp='GST'  AND vtype like '%SALE%' and session = '" & GMod.Session & "'", "vou_type")
        voutype.DataSource = GMod.ds.Tables("vou_type")
        voutype.DisplayMember = "vtype"
        'End If
        'date set to server date 
        'GMod.DataSetRet("select getdate()", "serverdate")
        'dtdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

        'End If
        Label3.Text = "SALE INVOICE  [" & GMod.Cmpname & "]"
        If cmbsubgrp.Text.Length = 0 Then
            cmbsubgrp.Text = "-"
        End If
        'voutype.SelectedIndex = 0

        txtinvoiceno.Focus()
        fillItems()
        fillArea()
        cmbAreaCode.Text = "JB"
        'Filling tcs tYPE 
        GMod.DataSetRet("select * from TCSMaster Where cmp_id='" & GMod.Cmpid & "' and type =1", "TCSTYPE")
        cmbTcsType.DataSource = GMod.ds.Tables("TCSTYPE")
        cmbTcsType.DisplayMember = "TcsType"


       

        'nxtvno()
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        dgSaleVoucher.Rows.Add()
        Dim Sql As String
        Sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and Group_name in ('INTERNAL PARTY','CUSTOMER','CANCELLED','PARTNERS CAPITAL') and Area_Code='" & ComboBox2.Text & "'"
        GMod.DataSetRet(Sql, "aclist1")

        cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadname.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclist1")
        ComboBox1.DisplayMember = "group_name"

        cmbsubgrp.DataSource = GMod.ds.Tables("aclist1")
        cmbsubgrp.DisplayMember = "sub_group_name"

        txtremark1.DataSource = GMod.ds.Tables("aclist1")
        txtremark1.DisplayMember = "remark1"

        CmbMobileNo.DataSource = GMod.ds.Tables("aclist1")
        CmbMobileNo.DisplayMember = "phone"


        txtinvoiceno.Text = lblno.Text

        Sql = " select * from " & GMod.ACC_HEAD & " where Group_name like  '%SALE%'"
        GMod.DataSetRet(Sql, "salehead")

        CmbCrCode.DataSource = GMod.ds.Tables("salehead")
        CmbCrCode.DisplayMember = "account_code"
        CmbCrHead.DataSource = GMod.ds.Tables("salehead")
        CmbCrHead.DisplayMember = "account_head_name"



        'Tds 
        Sql = "select * from TdsMater where cmp_id ='" & GMod.Cmpid & "'"
        GMod.DataSetRet(Sql, "tdm")

        cmbtdsType.DataSource = GMod.ds.Tables("tdm")
        cmbtdsType.DisplayMember = "TdsType"


        cmbTdsper.DataSource = GMod.ds.Tables("tdm")
        cmbTdsper.DisplayMember = "Per"

        cmbacheadcodetds.DataSource = GMod.ds.Tables("tdm")
        cmbacheadcodetds.DisplayMember = "Acc_Code"


        If GMod.role.ToUpper = "ADMIN" Then
            btn_modify.Enabled = True
            btnDelete.Enabled = True
        Else
            'btn_modify.Enabled = False
            btnDelete.Enabled = False
        End If

        dtdate.Focus()

        'SESSION CHECK FOR ENTRY 
        'MsgBox(GMod.Getsession(dtvdate.Value))
        If GMod.Getsession(dtdate.Value) = GMod.Session Then
        Else
            ' Me.Close()
        End If
        dtHatchdate.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtHatchdate.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")
        GMod.DataSetRet(sqlarea, "Area1")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"
        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"

        ComboBox2.DataSource = GMod.ds.Tables("Area1")
        ComboBox2.DisplayMember = "prefix"

        ComboBox3.DataSource = GMod.ds.Tables("Area1")
        ComboBox3.DisplayMember = "Areaname"

        CmbState.DataSource = GMod.ds.Tables("Area1")
        CmbState.DisplayMember = "state"


    End Sub
    Public Sub fillItems()
       
    End Sub

    Private Sub dgSaleVoucher_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSaleVoucher.CellEndEdit
        'Calculatea al thing if feer per changes
        If e.ColumnIndex = 5 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
            Dim fr As Double
            Dim qty1 As String
            fr = (Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - (Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) * 100) / (dgSaleVoucher(5, dgSaleVoucher.CurrentCell.RowIndex).Value + 100))
            dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value = Math.Round(fr, 0)
            'MsgBox(fr)
            If GMod.Cmpid = "PHHA" Then
                qty1 = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                dgSaleVoucher(4, dgSaleVoucher.CurrentCell.RowIndex).Value = qty1 * Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value)
            ElseIf GMod.Cmpid = "PHOE" Or GMod.Cmpid = "JAHA" Then
                qty1 = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                Dim sqlrate As String
                sqlrate = "select discount, necc , rate  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sqlrate, "rate")

                Dim neccamt1, rate1, dis As Double
                neccamt1 = Val(GMod.ds.Tables("rate").Rows(0)(1))
                ' neccamt1 = 0
                dis = Val(GMod.ds.Tables("rate").Rows(0)(0))
                'MsgBox(dis)
                rate1 = Val(GMod.ds.Tables("rate").Rows(0)(2))
                rate1 = Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value)
                If txtremark1.Text = "DISCOUNT" Then
                    rate1 = rate1 + neccamt1 - dis
                Else
                    rate1 = rate1 + neccamt1
                End If
                'MsgBox(rate1)

                dgSaleVoucher(4, dgSaleVoucher.CurrentCell.RowIndex).Value = qty1 * rate1
            End If
        End If

      


        'If dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value = "LAYER CHICKS" And voutype.Text = "SALE LR" Then
        'ElseIf dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value = "BROILER CHICKS" And voutype.Text = "SALE BR" Then
        'Else
        '    MsgBox("Please select correct voucher type")
        '    voutype.Focus()
        '    Exit Sub
        'End If
      

       
    End Sub
    Dim neccamt1, rate1, dis As Double
    Private Sub dgSaleVoucher_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSaleVoucher.CellEnter
        Dim qty As String
        If e.ColumnIndex = 4 Then
            If GMod.Cmpid = "PHHA" Then
                qty = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                dgSaleVoucher(4, dgSaleVoucher.CurrentCell.RowIndex).Value = qty * Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value)
            ElseIf GMod.Cmpid = "PHOE" Or GMod.Cmpid = "JAHA" Then
                qty = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                Dim sqlrate As String
                sqlrate = "select discount, necc , rate  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sqlrate, "rate")

                neccamt1 = Val(GMod.ds.Tables("rate").Rows(0)(1))
                'neccamt1 = 0
                dis = Val(GMod.ds.Tables("rate").Rows(0)(0)) 'Discount Amount
                'MsgBox(dis)
                rate1 = Val(GMod.ds.Tables("rate").Rows(0)(2))
                rate1 = Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value)
                If txtremark1.Text = "DISCOUNT" Then
                    rate1 = rate1 + neccamt1 - dis
                Else
                    rate1 = rate1 + neccamt1
                End If
                'MsgBox(rate1)

                dgSaleVoucher(4, dgSaleVoucher.CurrentCell.RowIndex).Value = qty * rate1
            End If
        End If
    End Sub
    Private Sub dgSaleVoucher_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgSaleVoucher.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                If dgSaleVoucher.CurrentCell.ColumnIndex < dgSaleVoucher.ColumnCount - 1 Then
                    ' dgSaleVoucher(dgSaleVoucher.CurrentCell.ColumnIndex + 1, dgSaleVoucher.CurrentCell.ColumnIndex).s()
                    SendKeys.Send("{Tab}")
                Else
                    dgSaleVoucher.Rows.Add()
                    dgSaleVoucher.CurrentCell = dgSaleVoucher(0, dgSaleVoucher.CurrentCell.RowIndex + 1)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgSaleVoucher_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSaleVoucher.RowEnter
        Dim r, pr As Integer
        r = e.RowIndex
        If r = 0 Then
            dgSaleVoucher(0, r).Value = 1
        Else
            pr = r - 1
            dgSaleVoucher(0, r).Value = dgSaleVoucher(0, pr).Value + 1
        End If
    End Sub
    Public Sub claceccamount()
        'getting code 
        Dim head As String = "**IN0001"
        Dim code As String = "N.E.C.C AMOUNT"
        Dim per, amount As Double
        amount = Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value) * 0.5

        'MsgBox(amount.ToString)
        dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value = head
        dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value = code
        dgSaleVoucher(5, dgSaleVoucher.CurrentCell.RowIndex).Value = amount
    End Sub
    Dim discode As String, discounthead As String
    Dim neccode As String, necchead As String, neccgrp As String, neccsgrp As String
    Sub gettingNECCcodes()
        Dim sql As String
        sql = " select account_code, account_head_name,group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='N.E.C.C FARMER CONTRIBUTION'"
        GMod.DataSetRet(sql, "heads")
        If GMod.ds.Tables("heads").Rows.Count > 0 Then
            neccode = GMod.ds.Tables("heads").Rows(0)(0).ToString
            necchead = GMod.ds.Tables("heads").Rows(0)(1).ToString
            neccgrp = GMod.ds.Tables("heads").Rows(0)(2).ToString
            neccsgrp = GMod.ds.Tables("heads").Rows(0)(3).ToString
            If neccsgrp.Length = 0 Then
                neccsgrp = "-"
            End If
            GMod.ds.Tables("heads").Dispose()
        Else
            MsgBox("Please Create Head of:- N.E.C.C FARMER CONTRIBUTION")
        End If
    End Sub
    Sub gettingDISCOUNTcodes()
        Dim sql As String
        sql = "select account_code, account_head_name,group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='DISCOUNT AMOUNT'"
        GMod.DataSetRet(sql, "heads1")
        If GMod.ds.Tables("heads1").Rows.Count > 0 Then
            discode = GMod.ds.Tables("heads1").Rows(0)(0).ToString
        Else
            MsgBox("Please Create Head of:- DISCOUNT AMOUNT")
        End If
        GMod.ds.Tables("heads1").Dispose()
    End Sub
    Sub gettingcodes()
        Dim sql As String
        If GMod.Cmpid = "PHHA" Then
            sql = " select account_code, account_head_name,group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='N.E.C.C FARMER CONTRIBUTION'"
            GMod.DataSetRet(sql, "heads")
            If GMod.ds.Tables("heads").Rows.Count > 0 Then
                neccode = GMod.ds.Tables("heads").Rows(0)(0).ToString
                necchead = GMod.ds.Tables("heads").Rows(0)(1).ToString
                neccgrp = GMod.ds.Tables("heads").Rows(0)(2).ToString
                neccsgrp = GMod.ds.Tables("heads").Rows(0)(3).ToString
                GMod.ds.Tables("heads").Dispose()
            Else
                MsgBox("Please Create Head of:- N.E.C.C FARMER CONTRIBUTION")
            End If
        End If
        If GMod.Cmpid = "PHOE" Or GMod.Cmpid = "JAHA" Then
            sql = "select account_code, account_head_name,group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='DISCOUNT AMOUNT'"
            GMod.DataSetRet(sql, "heads1")
            If GMod.ds.Tables("heads1").Rows.Count > 0 Then
                discode = GMod.ds.Tables("heads1").Rows(0)(0).ToString
            Else
                MsgBox("Please Create Head of DISCOUNT AMOUNT")
            End If
            GMod.ds.Tables("heads1").Dispose()
        End If
    End Sub
    Dim vouno As Long
    Dim ddate As DateTime = CDate("1/1/2000")
    Dim cr As Double = 0.0
    Dim pv As Double = 0.0
    Dim gloop As Integer = 0
    Dim tdsper As Double
    Dim tdsamt As Double
    Dim tdshead As String
    Dim tcsper As Double
    Dim tcsamt As Double
    Dim tcshead As String

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim smsmsg As String
        Dim i As Integer
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            If CmbCrHead.FindStringExact(CmbCrHead.Text) = -1 Then
                MsgBox("Account Code does not exists")
                CmbCrHead.Focus()
            End If
            If voutype.Text = "" Then
                MsgBox("Please select voucher type")
                voutype.Focus()
                Exit Sub
            End If
            If btnsave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, txtinvoiceno.Text, voutype.Text, dtdate.Value, Now, GMod.Session, "M", GMod.username)
            End If
            'If txtinvoiceno.Text = "" Then
            '    MsgBox("Invoice No. cant be blank")
            '    txtinvoiceno.Focus()
            '    Exit Sub
            'End If
            'gettingcodes()
            If GMod.Cmpid = "PHHA" Then
                For gloop = 0 To dgSaleVoucher.RowCount - 1
                    ' MessageBox.Show(Val(dgSaleVoucher(2, gloop).Value) * Val(dgSaleVoucher(3, gloop).Value))
                    ' MessageBox.Show(dgSaleVoucher(3, gloop).Value)
                    Dim qty As Double
                    qty = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)

                    If (qty * Val(dgSaleVoucher(3, gloop).Value)) <> Val(dgSaleVoucher(4, gloop).Value) Then
                        MessageBox.Show("Please ckeck the data,check calculation...")
                        Exit Sub
                    End If
                Next
            End If
            Dim sqltrans As SqlTransaction
            sqltrans = GMod.SqlConn.BeginTransaction
            Dim sqlneccamt As String
            Dim sql As String
            Dim neccamt, neccval, discountamount, discountval, productamount As Double
            Dim sqlsavenecc, zero, saveprd, ssaveprdvntry As String
            zero = "0"

            Dim c, h, g, s, pn As String
            Dim narration As String
            If btnsave.Enabled = True Then
                nxtvno()
            Else

            End If
            txtinvoiceno.Text = lblno.Text
            Try
                'deteleing existing data for new modifyinh
                If btnsave.Enabled = False Then
                    Dim sqldel As String
                    sqldel = "delete from " & GMod.VENTRY & " where Vou_type='" & voutype.Text & "' and Vou_no= " & lblno.Text
                    Dim cmddel1 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmddel1.ExecuteNonQuery()

                    sqldel = "delete  from PrintData where  Vou_no= '" & lblno.Text & "' and Vou_type='" & voutype.Text & "' and Cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                    Dim cmddel2 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmddel2.ExecuteNonQuery()

                    sql = "delete from Sale_Receipt where vou_type='" & voutype.Text & "' and  vou_no='" & lblno.Text & "' and cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                    Dim cmddel As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmddel.ExecuteNonQuery()

                End If

                Dim qty As Double
                Dim nar As String
                For i = 0 To dgSaleVoucher.Rows.Count - 1
                    'MsgBox("SALE OF " & dgSaleVoucher(1, i).Value.ToString)
                    qty = dgSaleVoucher(2, i).Value - dgSaleVoucher(6, i).Value
                    pn = "SALE OF " & dgSaleVoucher(1, i).Value.ToString
                    narration = "BEING SALE OF " & dgSaleVoucher(1, i).Value.ToString & "Hatch Date " & dtHatchdate.Text
                    narration = narration & "TO INV NO." & txtinvoiceno.Text & " QTY " & dgSaleVoucher(2, i).Value - dgSaleVoucher(6, i).Value & " + " & dgSaleVoucher(6, i).Value & "@ " & dgSaleVoucher(3, i).Value & " TM " & dgSaleVoucher(7, i).Value
                    nar = nar & narration

                    smsmsg = "Your A/c Debited by RS " & dgSaleVoucher(4, i).Value.ToString & " against " & dgSaleVoucher(1, i).Value & " No. " & dgSaleVoucher(2, i).Value - dgSaleVoucher(6, i).Value & " Free " & dgSaleVoucher(6, i).Value & " @ " & dgSaleVoucher(3, i).Value & " Vide Inv. No " & txtinvoiceno.Text & " Hatch Date " & dtHatchdate.Text

                    'Getting product head name
                    sql = "select account_code, account_head_name,group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='" & CmbCrHead.Text & "'"
                    GMod.DataSetRet(sql, "heads")
                    c = GMod.ds.Tables("heads").Rows(0)(0).ToString
                    h = GMod.ds.Tables("heads").Rows(0)(1).ToString
                    g = GMod.ds.Tables("heads").Rows(0)(2).ToString
                    s = GMod.ds.Tables("heads").Rows(0)(3).ToString
                    If s.Length = 0 Then
                        s = "-"
                    End If
                    GMod.ds.Tables("heads").Dispose()
                    'MsgBox(c)
                    'getting necc amont 
                    sqlneccamt = "select discount, necc  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, i).Value & "'"
                    GMod.DataSetRet(sqlneccamt, "NECCAMOUNT")
                    'MsgBox(neccamt)
                    neccamt = Val(GMod.ds.Tables("NECCAMOUNT").Rows(0)(1))
                    'getting discount amount 
                    discountamount = Val(GMod.ds.Tables("NECCAMOUNT").Rows(0)(0))

                    If neccamt > 0 Then 'FOR NECC CONTRIBUTION
                        gettingNECCcodes() 'Geeting NEEC HEAD Codes
                        neccval = (Val(dgSaleVoucher(2, i).Value) - Val(dgSaleVoucher(6, i).Value)) * neccamt
                        'MsgBox(neccval)
                        'Inserting NECC AMONT in VENTRY
                        sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                        sqlsavenecc &= "'" & GMod.Cmpid & "',"
                        sqlsavenecc &= "'" & GMod.username & "',"
                        sqlsavenecc &= "'" & i + 8 & "',"
                        sqlsavenecc &= "'" & lblno.Text & "',"
                        sqlsavenecc &= "'" & voutype.Text & "',"
                        sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                        sqlsavenecc &= "'" & neccode & "',"
                        sqlsavenecc &= "'" & necchead & "',"
                        sqlsavenecc &= "'" & Val(zero) & "',"
                        sqlsavenecc &= "'" & neccval.ToString & "',"
                        sqlsavenecc &= "'" & narration & "',"
                        sqlsavenecc &= "'" & neccgrp & "',"
                        sqlsavenecc &= "'" & neccsgrp & "','" & dtHatchdate.Value.ToShortDateString & "')"
                        'MsgBox(sqlsavenecc)
                        'MsgBox(GMod.SqlExecuteNonQuery(sqlsavenecc))
                        Dim cmdneccventry As New SqlCommand(sqlsavenecc, GMod.SqlConn, sqltrans)
                        cmdneccventry.ExecuteNonQuery()

                        'Inserting NECC AMONT for PRINT DATA
                        sqlsavenecc = "insert into PrintData (Vou_type, Vou_no, AccCode, AccName, Station, ProductName," _
                                       & "Qty, Rate, Amount, DiscountRate, DiscountAmount, " _
                                       & "NeccRate, NeccAmount, FreePer, FreeQty, HatchDate," _
                                       & "BillNo, BillDate, Cmp_id, Session,type,Mortality) VALUES ("
                        sqlsavenecc &= "'" & voutype.Text & "',"
                        sqlsavenecc &= "'" & lblno.Text & "',"
                        sqlsavenecc &= "'" & c & "',"
                        sqlsavenecc &= "'" & h & "',"
                        sqlsavenecc &= "'" & cmbAreaName.Text & "',"
                        sqlsavenecc &= "'N.E.E.C AMOUNT',"
                        sqlsavenecc &= "'" & qty & "',"
                        sqlsavenecc &= "'" & dgSaleVoucher(3, i).Value & "',"
                        sqlsavenecc &= "'" & dgSaleVoucher(4, i).Value & "',"
                        sqlsavenecc &= "'" & Val(zero) & "',"
                        sqlsavenecc &= "'" & Val(zero) & "',"
                        sqlsavenecc &= "'" & neccamt.ToString & "',"
                        sqlsavenecc &= "'" & neccval.ToString & "',"
                        sqlsavenecc &= "'" & Val(zero) & "',"
                        sqlsavenecc &= "'" & Val(zero) & "',"
                        sqlsavenecc &= "'" & dtHatchdate.Value.ToShortDateString & "',"
                        sqlsavenecc &= "'" & txtinvoiceno.Text & "',"
                        sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                        sqlsavenecc &= "'" & GMod.Cmpid & "',"
                        sqlsavenecc &= "'" & GMod.Getsession(dtdate.Value).ToString & "',"
                        sqlsavenecc &= "'V',"
                        sqlsavenecc &= "'" & dgSaleVoucher(7, i).Value & "')"
                        'MsgBox(sqlsavenecc)
                        'MsgBox(GMod.SqlExecuteNonQuery(sqlsavenecc))
                        Dim cmd1 As New SqlCommand(sqlsavenecc, GMod.SqlConn, sqltrans)
                        cmd1.ExecuteNonQuery()

                    End If
                    'for discount amount 
                    If txtremark1.Text = "DISCOUNT" Then 'if customer get the discount 
                        If discountamount > 0 Then
                            gettingDISCOUNTcodes()
                            discountval = discountamount * (Val(dgSaleVoucher(2, i).Value) - Val(dgSaleVoucher(6, i).Value))
                            'MsgBox(discountval)
                            'Inserting DISCOUNT AMONT for PRINT DATA
                            sqlsavenecc = "insert into PrintData (Vou_type, Vou_no, AccCode, AccName, Station, ProductName," _
                                           & "Qty, Rate, Amount, DiscountRate, DiscountAmount, " _
                                           & "NeccRate, NeccAmount, FreePer, FreeQty, HatchDate," _
                                           & "BillNo, BillDate, Cmp_id, Session,type) VALUES ("
                            sqlsavenecc &= "'" & voutype.Text & "',"
                            sqlsavenecc &= "'" & lblno.Text & "',"
                            sqlsavenecc &= "'" & cmbacheadcode.Text & "',"
                            sqlsavenecc &= "'" & cmbacheadname.Text & "',"
                            sqlsavenecc &= "'" & cmbAreaName.Text & "',"
                            sqlsavenecc &= "'DISCOUNT AMOUNT',"
                            sqlsavenecc &= "'" & qty & "',"
                            sqlsavenecc &= "'" & dgSaleVoucher(3, i).Value & "',"
                            sqlsavenecc &= "'" & dgSaleVoucher(4, i).Value & "',"
                            sqlsavenecc &= "'" & discountamount.ToString & "',"
                            sqlsavenecc &= "'" & discountval.ToString & "',"
                            sqlsavenecc &= "'" & Val(zero) & "',"
                            sqlsavenecc &= "'" & Val(zero) & "',"
                            sqlsavenecc &= "'" & Val(zero) & "',"
                            sqlsavenecc &= "'" & Val(zero) & "',"
                            sqlsavenecc &= "'" & dtHatchdate.Value.ToShortDateString & "',"
                            sqlsavenecc &= "'" & txtinvoiceno.Text & "',"
                            sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                            sqlsavenecc &= "'" & GMod.Cmpid & "',"
                            sqlsavenecc &= "'" & GMod.Getsession(dtdate.Value).ToString & "',"
                            sqlsavenecc &= "'V')"
                            'MsgBox(sqlsavenecc)
                            'MsgBox(GMod.SqlExecuteNonQuery(sqlsavenecc))
                            Dim cmd3 As New SqlCommand(sqlsavenecc, GMod.SqlConn, sqltrans)
                            cmd3.ExecuteNonQuery()

                        End If
                    End If
                    If neccamt > 0 Then
                        gettingNECCcodes()
                        Dim cr As Double
                        cr = Val(dgSaleVoucher(4, i).Value.ToString) - neccval
                        'Inserting PRODUCT AMONT in VENTRY
                        ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                        ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                        ssaveprdvntry &= "'" & GMod.username & "',"
                        ssaveprdvntry &= "'" & i + 1 & "',"
                        ssaveprdvntry &= "'" & lblno.Text & "',"
                        ssaveprdvntry &= "'" & voutype.Text & "',"
                        ssaveprdvntry &= "'" & dtdate.Value.ToShortDateString & "',"
                        ssaveprdvntry &= "'" & c & "',"
                        ssaveprdvntry &= "'" & h & "',"
                        ssaveprdvntry &= "'" & Val(zero) & "',"
                        ssaveprdvntry &= "'" & cr.ToString & "',"
                        ssaveprdvntry &= "'" & narration.ToString & "',"
                        ssaveprdvntry &= "'" & g & "',"
                        ssaveprdvntry &= "'" & s & "','" & dtHatchdate.Value.ToShortDateString & "')"
                        'MsgBox(ssaveprdvntry)
                        'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                        Dim cmd4 As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                        cmd4.ExecuteNonQuery()
                    Else
                        ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                        ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                        ssaveprdvntry &= "'" & GMod.username & "',"
                        ssaveprdvntry &= "'" & i + 1 & "',"
                        ssaveprdvntry &= "'" & lblno.Text & "',"
                        ssaveprdvntry &= "'" & voutype.Text & "',"
                        ssaveprdvntry &= "'" & dtdate.Value.ToShortDateString & "',"
                        ssaveprdvntry &= "'" & c & "',"
                        ssaveprdvntry &= "'" & h & "',"
                        ssaveprdvntry &= "'" & Val(zero) & "',"
                        ssaveprdvntry &= "'" & dgSaleVoucher(4, i).Value & "',"
                        ssaveprdvntry &= "'" & narration.ToString & "',"
                        ssaveprdvntry &= "'" & g & "',"
                        ssaveprdvntry &= "'" & s & "','" & dtHatchdate.Value.ToShortDateString & "')"
                        'MsgBox(ssaveprdvntry)
                        'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                        Dim cmd5 As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                        cmd5.ExecuteNonQuery()

                    End If

                    'Inserting TCS tax amount in the Voucher entry Credit 
                    If Val(txtTcsAmount.Text) > 0 Then

                        tcsper = Val(txtTcsPer.Text)
                        tcsamt = Val(txtTcsAmount.Text)
                        tcshead = cmbTcsHeadCode.Text


                        ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                        ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                        ssaveprdvntry &= "'" & GMod.username & "',"
                        ssaveprdvntry &= "'" & i + 1 & "',"
                        ssaveprdvntry &= "'" & lblno.Text & "',"
                        ssaveprdvntry &= "'" & voutype.Text & "',"
                        ssaveprdvntry &= "'" & dtdate.Value.ToShortDateString & "',"
                        ssaveprdvntry &= "'" & cmbTcsHeadCode.Text & "',"
                        ssaveprdvntry &= "'" & cmbTcsHead.Text & "',"
                        ssaveprdvntry &= "'" & Val(zero) & "',"
                        ssaveprdvntry &= "'" & Val(txtTcsAmount.Text) & "',"
                        ssaveprdvntry &= "'" & narration.ToString & "',"
                        ssaveprdvntry &= "'TCS',"
                        ssaveprdvntry &= "'" & s & "','" & dtHatchdate.Value.ToShortDateString & "')"
                        'MsgBox(ssaveprdvntry)
                        'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                        Dim cmdTcstaxentry As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                        cmdTcstaxentry.ExecuteNonQuery()


                        ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
               & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
               & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                        ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                        ssaveprdvntry &= "'" & GMod.username & "',"
                        ssaveprdvntry &= "'0',"
                        ssaveprdvntry &= "'" & lblno.Text & "',"
                        ssaveprdvntry &= "'" & voutype.Text & "',"
                        ssaveprdvntry &= "'" & dtdate.Value.ToShortDateString & "',"
                        ssaveprdvntry &= "'" & cmbacheadcode.Text & "',"
                        ssaveprdvntry &= "'" & cmbacheadname.Text & "',"
                        ssaveprdvntry &= "'" & Val(txtTcsAmount.Text) & "',"
                        ssaveprdvntry &= "'0',"
                        ssaveprdvntry &= "'" & "TCS " & nar & "',"
                        ssaveprdvntry &= "'" & ComboBox1.Text & "',"
                        ssaveprdvntry &= "'" & cmbsubgrp.Text & "','" & dtHatchdate.Value.ToShortDateString & "')"

                        Dim cmdTcstaxentry1 As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                        cmdTcstaxentry1.ExecuteNonQuery()
                    Else
                        tcsper = 0
                        tcsamt = 0
                        tcshead = "-"

                    End If 'TCS Amount 

                    '**************************************************
                    'Inserting TDS tax amount in the Voucher entry Credit 
                    If Val(txtTDSAmount.Text) > 0 Then

                        tdsper = Val(cmbTdsper.Text)
                        tdsamt = Val(txtTDSAmount.Text)
                        tdshead = cmbTdsCode.Text

                        ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                        ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                        ssaveprdvntry &= "'" & GMod.username & "',"
                        ssaveprdvntry &= "'" & i + 1 & "',"
                        ssaveprdvntry &= "'" & lblno.Text & "',"
                        ssaveprdvntry &= "'" & voutype.Text & "',"
                        ssaveprdvntry &= "'" & dtdate.Value.ToShortDateString & "',"
                        ssaveprdvntry &= "'" & cmbTdsCode.Text & "',"
                        ssaveprdvntry &= "'" & cmbTdsHead.Text & "',"
                        ssaveprdvntry &= "'" & Val(txtTDSAmount.Text) & "',"
                        ssaveprdvntry &= "'" & Val(zero) & "',"
                        ssaveprdvntry &= "'" & narration.ToString & "',"
                        ssaveprdvntry &= "'TCS',"
                        ssaveprdvntry &= "'" & s & "','" & dtHatchdate.Value.ToShortDateString & "')"
                        'MsgBox(ssaveprdvntry)
                        'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                        Dim cmdTcstaxentry As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                        cmdTcstaxentry.ExecuteNonQuery()


                        ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
               & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
               & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                        ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                        ssaveprdvntry &= "'" & GMod.username & "',"
                        ssaveprdvntry &= "'0',"
                        ssaveprdvntry &= "'" & lblno.Text & "',"
                        ssaveprdvntry &= "'" & voutype.Text & "',"
                        ssaveprdvntry &= "'" & dtdate.Value.ToShortDateString & "',"
                        ssaveprdvntry &= "'" & cmbacheadcode.Text & "',"
                        ssaveprdvntry &= "'" & cmbacheadname.Text & "',"
                        ssaveprdvntry &= "'0',"
                        ssaveprdvntry &= "'" & Val(txtTDSAmount.Text) & "',"
                        ssaveprdvntry &= "'" & "TDS " & nar & "',"
                        ssaveprdvntry &= "'" & ComboBox1.Text & "',"
                        ssaveprdvntry &= "'" & cmbsubgrp.Text & "','" & dtHatchdate.Value.ToShortDateString & "')"

                        Dim cmdTcstaxentry1 As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                        cmdTcstaxentry1.ExecuteNonQuery()


                        'Inserting into TDS Report
                        sql = "insert into TdsEntry(Vou_Type, Vou_no, TdsType, Per, TdsDate, " _
                                  & " BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt," _
                                  & " Actualamt, session,Paidto,vou_date, TdsAmt,dcode,cmp_id ) values( "
                        sql &= "'" & voutype.Text & "',"
                        sql &= "'" & lblno.Text & "',"
                        sql &= "'" & cmbtdsType.Text & "',"
                        sql &= "'" & cmbTdsper.Text & "',"
                        sql &= "'" & dtdate.Value.ToShortDateString & "',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'0',"
                        sql &= "'" & productamount & "',"
                        sql &= "'" & Val("") & "',"
                        sql &= "'" & GMod.Session & "',"
                        sql &= "'YES',"
                        sql &= "'" & dtdate.Value.ToShortDateString & "',"
                        sql &= "'" & Val(txtTDSAmount.Text) & "',"
                        sql &= "'" & cmbacheadcode.Text & "',"
                        sql &= "'" & GMod.Cmpid & "')"

                        Dim cmdTdsSale As New SqlCommand(sql, SqlConn, sqltrans)
                        cmdTdsSale.ExecuteNonQuery()
                    Else
                        tdsper = 0
                        tdsamt = 0
                        tdshead = ""

                    End If 'TDS Amount 
                    '********************************************************************************************




                    'Inserting product for PRINT DATA
                    sqlsavenecc = "insert into PrintData (Vou_type, Vou_no, AccCode, AccName, Station, ProductName," _
                                   & "Qty, Rate, Amount, DiscountRate, DiscountAmount, " _
                                   & "NeccRate, NeccAmount, FreePer, FreeQty, HatchDate," _
                                   & "BillNo, BillDate, Cmp_id, Session,type,PrdUnit,Mortality,tcs_head, tcs_per, tcs_amt,tds_head, tds_per, tds_amt) VALUES ("
                    sqlsavenecc &= "'" & voutype.Text & "',"
                    sqlsavenecc &= "'" & lblno.Text & "',"
                    sqlsavenecc &= "'" & cmbacheadcode.Text & "',"
                    sqlsavenecc &= "'" & cmbacheadname.Text & "',"
                    sqlsavenecc &= "'" & cmbAreaName.Text & "',"
                    sqlsavenecc &= "'" & dgSaleVoucher(1, i).Value & "',"
                    sqlsavenecc &= "'" & qty & "',"
                    sqlsavenecc &= "'" & dgSaleVoucher(3, i).Value & "',"
                    sqlsavenecc &= "'" & dgSaleVoucher(4, i).Value & "',"
                    sqlsavenecc &= "'" & Val(discountamount) & "',"
                    sqlsavenecc &= "'" & Val(discountval) & "',"
                    sqlsavenecc &= "'" & Val(neccamt) & "',"
                    sqlsavenecc &= "'" & Val(neccval) & "',"
                    sqlsavenecc &= "'" & dgSaleVoucher(5, i).Value & "',"
                    sqlsavenecc &= "'" & dgSaleVoucher(6, i).Value & "',"
                    sqlsavenecc &= "'" & dtHatchdate.Value.ToShortDateString & "',"
                    sqlsavenecc &= "'" & lblno.Text & "',"
                    sqlsavenecc &= "'" & dtdate.Value.ToShortDateString & "',"
                    sqlsavenecc &= "'" & GMod.Cmpid & "',"
                    sqlsavenecc &= "'" & GMod.Session & "',"
                    sqlsavenecc &= "'P',"
                    sqlsavenecc &= "'" & cmbPrdUnit.Text & "',"
                    sqlsavenecc &= "'" & dgSaleVoucher(7, i).Value & "',"
                    sqlsavenecc &= "'" & cmbTcsHeadCode.Text & "',"
                    sqlsavenecc &= "'" & Val(txtTcsPer.Text) & "',"
                    sqlsavenecc &= "'" & Val(txtTcsAmount.Text) & "',"
                    sqlsavenecc &= "'" & tdshead & "',"
                    sqlsavenecc &= "'" & tdsper & "',"
                    sqlsavenecc &= "'" & tdsamt & "')"

                    'MsgBox(sqlsavenecc)
                    'MsgBox(GMod.SqlExecuteNonQuery(sqlsavenecc))
                    Dim cmd2 As New SqlCommand(sqlsavenecc, GMod.SqlConn, sqltrans)
                    cmd2.ExecuteNonQuery()


                    productamount = productamount + Val(dgSaleVoucher(4, i).Value)
                    'MsgBox(productamount)
                    'Resetting values
                    neccamt = 0
                    neccval = 0
                    discountamount = 0
                    discountval = 0
                Next
                'Saving customer entry Dr
                ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                ssaveprdvntry &= "'" & GMod.username & "',"
                ssaveprdvntry &= "'0',"
                ssaveprdvntry &= "'" & lblno.Text & "',"
                ssaveprdvntry &= "'" & voutype.Text & "',"
                ssaveprdvntry &= "'" & dtdate.Value.ToShortDateString & "',"
                ssaveprdvntry &= "'" & cmbacheadcode.Text & "',"
                ssaveprdvntry &= "'" & cmbacheadname.Text & "',"
                ssaveprdvntry &= "'" & Val(productamount) & "',"
                ssaveprdvntry &= "'0',"
                ssaveprdvntry &= "'" & nar & "',"
                ssaveprdvntry &= "'" & ComboBox1.Text & "',"
                ssaveprdvntry &= "'" & cmbsubgrp.Text & "','" & dtHatchdate.Value.ToShortDateString & "')"
                'MsgBox(ssaveprdvntry)
                'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                Dim cmd6 As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                cmd6.ExecuteNonQuery()

                If DataGridView1.Rows.Count = 0 Then
                    sqlsavecr = "insert into  Sale_Receipt (Ref_Type, Ref, Acc_Code, Vou_Type," & _
                    " Vou_No, Vou_Date, dr, cr, dueon, Session,cmp_id) values( "
                    sqlsavecr &= "'Ags Ref',"
                    sqlsavecr &= "'" & voutype.Text & lblno.Text & "',"
                    sqlsavecr &= "'" & cmbacheadcode.Text & "',"
                    sqlsavecr &= "'" & voutype.Text & "',"
                    sqlsavecr &= "'" & lblno.Text & "',"
                    sqlsavecr &= "'" & dtdate.Value.ToShortDateString & "',"
                    sqlsavecr &= "'" & Val(productamount.ToString) & "',"
                    sqlsavecr &= "'" & Val("") & "',"
                    sqlsavecr &= "'" & CDate("1/1/2000") & "',"
                    sqlsavecr &= "'" & GMod.Session & "',"
                    sqlsavecr &= "'" & GMod.Cmpid & "')"

                    Dim cmdAG As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltrans)
                    cmdAG.ExecuteNonQuery()
                Else

                    For i = 0 To DataGridView1.Rows.Count - 1
                        cr = cr + Val(DataGridView1(3, i).Value)
                    Next
                    For i = 0 To dgSaleVoucher.Rows.Count - 1
                        pv = pv + Val(dgSaleVoucher(4, i).Value)
                    Next
                    If cr <> pv Then
                        'MsgBox("Amount not matching!!", MsgBoxStyle.Critical)
                        cmbacheadname.Focus()
                        cr = 0.0
                        pv = 0.0
                        'Exit Sub
                    End If
                    For i = 0 To DataGridView1.RowCount - 1
                        sqlsavecr = "insert into  Sale_Receipt (Ref_Type, Ref, Acc_Code, Vou_Type," & _
                        " Vou_No, Vou_Date, cr, dr, dueon, Session,cmp_id) values( "
                        sqlsavecr &= "'" & DataGridView1(0, i).Value & "',"
                        sqlsavecr &= "'" & DataGridView1(1, i).Value & "',"
                        sqlsavecr &= "'" & cmbacheadcode.Text & "',"
                        sqlsavecr &= "'" & voutype.Text & "',"
                        sqlsavecr &= "'" & lblno.Text & "',"
                        sqlsavecr &= "'" & dtdate.Value.ToShortDateString & "',"
                        sqlsavecr &= "'" & Val("") & "',"
                        sqlsavecr &= "'" & Val(DataGridView1(3, i).Value) & "',"
                        sqlsavecr &= "'" & CDate(DataGridView1(2, i).Value).ToShortDateString & "',"
                        sqlsavecr &= "'" & GMod.Session & "',"
                        sqlsavecr &= "'" & GMod.Cmpid & "')"

                        Dim cmdAG As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltrans)
                        cmdAG.ExecuteNonQuery()
                    Next
                End If
                Dim cmddd As New SqlCommand("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='S' and cmp_id='" & GMod.Cmpid & "'", GMod.SqlConn, sqltrans)
                cmddd.ExecuteNonQuery()
                btnsave.Enabled = True
                btn_modify.Text = "&Modify"
                sqltrans.Commit()
                'Sending Sms
                'If GMod.Cmpid = "PHHA" Then
                '    'End If
                '    Try
                '        If CmbMobileNo.Text.Length >= 10 Then
                '            Dim snd As New sendsms
                '            snd.send_sms(CmbMobileNo.Text, smsmsg)
                '        End If
                '    Catch ex As Exception

                '    End Try
                'End If
                '-------------------------------------------
                MessageBox.Show(voutype.Text & "/" & lblno.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgSaleVoucher.Rows.Clear()
                DataGridView1.Rows.Clear()

                dgSaleVoucher.Rows.Add()
                txtinvoiceno.Focus()
                voutype.Enabled = True
            Catch ex As Exception
                sqltrans.Rollback()
                MsgBox(ex.Message)
            End Try
            sqltrans.Dispose()
            'nxtvno()
            txtinvoiceno.Text = ""
            txtTcsAmount.Text = "0"
            chKtcs.Checked = False
            ' sqltrans.Dispose()
        Else
            Exit Sub
        End If
    End Sub
    Dim sqlsavecr As String
    Sub nxtvno()
        Dim sql As String
        Try
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & voutype.Text & "'"
            GMod.DataSetRet(Sql, "vno8")
            lblno.Text = ds.Tables("vno8").Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If lblno.Text = "" Then
            Me.Close()
        End If
    End Sub
    Private Sub btn_modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modify.Click
        Dim k As Integer
        Try
            'Vou_type, Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, DiscountRate, DiscountAmount, NeccRate, 
            'NeccAmount, freeper, freeqty, HatchDate, BillNo, BillDate, Cmp_id, Session, Type
            If btn_modify.Text = "&Modify" Then
                'btnsave.Enabled = False
                'btn_modify.Text = "&Update"
                Dim r As String, sql As String, i As Integer, vt As String
                'vt = InputBox("Enter  Voucher Type to be Modified?")
                vt = voutype.Text
                r = InputBox("Enter Sale Voucher Number to be Modified?")
                If r <> "" And vt <> "" Then
                    If LockDataChecks(r, GMod.Session, vt) = False Then
                        MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '--------------------------------------------------------------------------------------------------------------
                        voutype.Enabled = True
                        btn_modify.Text = "&Modify"
                        btnsave.Enabled = True
                        CmbCrHead.Enabled = True
                        CmbCrCode.Enabled = True
                        dgSaleVoucher.Rows.Clear()
                        DataGridView1.Rows.Clear()
                        dgSaleVoucher.Rows.Add()
                        txtinvoiceno.Focus()
                        cmbRefType.SelectedIndex = 0
                        '---------------------------------------------------
                        'Exit Sub
                    End If
                    btnsave.Enabled = False
                    btn_modify.Text = "&Update"
                    voutype.Enabled = False
                    lblno.Text = r
                    voutype.Text = vt

                    voutype_Leave(sender, e)
                    voutype.Enabled = False


                    sql = "select * from PrintData where type='P' and Vou_no= '" & r & "' and Vou_type='" & vt & "' and Cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "' and authr='-'"
                    GMod.DataSetRet(sql, "PrintData")
                    If GMod.ds.Tables("PrintData").Rows.Count = 0 Then
                        MessageBox.Show("No Data Found For" & vt & "-" & r, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        voutype.Enabled = True
                        voutype.Focus()
                        btn_modify.Text = "&Modify"
                        btnsave.Enabled = True
                        Exit Sub
                    End If
                    dtdate.Focus()
                    txtinvoiceno.Text = GMod.ds.Tables("PrintData").Rows(0)("BillNo")
                    dtdate.MinDate = CDate(GMod.ds.Tables("PrintData").Rows(0)("BillDate"))
                    dtdate.Value = CDate(GMod.ds.Tables("PrintData").Rows(0)("BillDate"))
                    dtHatchdate.Value = CDate(GMod.ds.Tables("PrintData").Rows(0)("HatchDate"))
                    cmbAreaName.Text = GMod.ds.Tables("PrintData").Rows(0)("Station")
                    cmbacheadcode.Text = GMod.ds.Tables("PrintData").Rows(0)("AccCode")
                    ComboBox2.Text = GMod.ds.Tables("PrintData").Rows(0)("AccCode").ToString.Substring(0, 2)
                    lblno.Text = GMod.ds.Tables("PrintData").Rows(0)("vou_no")
                    'MsgBox(GMod.ds.Tables("PrintData").Rows(0)("AccCode").ToString.Substring(0, 2))
                    cmbacheadname.Text = GMod.ds.Tables("PrintData").Rows(0)("AccName")
                    For i = 0 To GMod.ds.Tables("PrintData").Rows.Count - 1
                        dgSaleVoucher(0, i).Value = i + 1
                        dgSaleVoucher(1, i).Value = GMod.ds.Tables("PrintData").Rows(i)("ProductName")
                        dgSaleVoucher(2, i).Value = Val(GMod.ds.Tables("PrintData").Rows(i)("Qty")) + Val(GMod.ds.Tables("PrintData").Rows(i)("freeqty"))
                        dgSaleVoucher(3, i).Value = GMod.ds.Tables("PrintData").Rows(i)("Rate")
                        dgSaleVoucher(4, i).Value = GMod.ds.Tables("PrintData").Rows(i)("Amount")
                        dgSaleVoucher(5, i).Value = GMod.ds.Tables("PrintData").Rows(i)("freeper")
                        dgSaleVoucher(6, i).Value = GMod.ds.Tables("PrintData").Rows(i)("freeqty")
                        dgSaleVoucher(7, i).Value = GMod.ds.Tables("PrintData").Rows(i)("Mortality")

                        dgSaleVoucher.Rows.Add()
                    Next
                    dgSaleVoucher.Rows.RemoveAt(i)
                Else
                    dgSaleVoucher.Rows.Add()
                    Exit Sub
                End If

                sql = "select Acc_head from " & GMod.VENTRY & " where cramt >0 and vou_type ='" & vt & "' and vou_no='" & r & "' and acc_head like '%" & dgSaleVoucher(1, 0).Value & "%'"
                GMod.DataSetRet(sql, "crhead")
                CmbCrHead.Text = GMod.ds.Tables("crhead").Rows(0)(0).ToString
                'CmbCrHead.Enabled = False
                'CmbCrCode.Enabled = False

                sql = "select ref_type,ref,dueon,dr from Sale_Receipt where vou_type='" & vt & "' and  vou_no='" & r & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
                dg.Visible = False
                GMod.DataSetRet(sql, "mfy")
                If GMod.ds.Tables("mfy").Rows.Count > 0 Then
                    For k = 0 To GMod.ds.Tables("mfy").Rows.Count - 1
                        DataGridView1.Rows.Add()
                        DataGridView1(0, k).Value = GMod.ds.Tables("mfy").Rows(k)(0)
                        DataGridView1(1, k).Value = GMod.ds.Tables("mfy").Rows(k)(1)
                        DataGridView1(2, k).Value = GMod.ds.Tables("mfy").Rows(k)(2)
                        DataGridView1(3, k).Value = GMod.ds.Tables("mfy").Rows(k)(3)
                    Next
                End If
            Else
                If MessageBox.Show("Do U want to Modify", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    btnsave_Click(sender, e)
                    btn_modify.Text = "&Modify"
                    btnsave.Enabled = True
                    CmbCrHead.Enabled = True
                    CmbCrCode.Enabled = True
                    cmbRefType.SelectedIndex = 0
                Else
                    voutype.Enabled = True
                    btn_modify.Text = "&Modify"
                    btnsave.Enabled = True
                    CmbCrHead.Enabled = True
                    CmbCrCode.Enabled = True
                    dgSaleVoucher.Rows.Clear()
                    DataGridView1.Rows.Clear()
                    dgSaleVoucher.Rows.Add()
                    txtinvoiceno.Focus()
                    cmbRefType.SelectedIndex = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtinvoiceno_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinvoiceno.KeyUp
        If e.KeyCode = Keys.Enter Then dtdate.Focus()
    End Sub
    Private Sub dtdate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then dtHatchdate.Focus()
    End Sub

    Private Sub dtHatchdate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtHatchdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbacheadname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmSalesRegister
        t.ShowDialog()
    End Sub
    Dim sqlUnit As String
    Private Sub dgSaleVoucher_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSaleVoucher.CellLeave
        Try
            Dim freeqty As Double
            Dim qty As Double
            If e.ColumnIndex = 2 Then
                Try
                    'sqlUnit = "select rate from HatchWiseRate where Hatchdate='" & dtHatchdate.Value.ToShortDateString & "' and product='" & dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value & "'  and cmp_id='" & GMod.Cmpid & "' and state='" & CmbState.Text & "'"
                    'GMod.DataSetRet(sqlUnit, "hwrate")

                    'If GMod.ds.Tables("hwrate").Rows.Count <= 0 Then
                    '    MessageBox.Show("Rate Missing For Hatchdate...", "No Rate", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    '    dtHatchdate.Focus()
                    '    Exit Sub
                    'End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                sqlUnit = "select Rate,freeqtyper from ItemMaster " _
                  & " where cmp_id='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sqlUnit, "Unit")

                If btnsave.Enabled = True Then
                    dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value = GMod.ds.Tables("unit").Rows(0)(0)
                End If
                dgSaleVoucher(5, dgSaleVoucher.CurrentCell.RowIndex).Value = GMod.ds.Tables("Unit").Rows(0)(1)
            ElseIf e.ColumnIndex = 3 Then
                'caculation
                freeqty = (Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - (Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) * 100) / (dgSaleVoucher(5, dgSaleVoucher.CurrentCell.RowIndex).Value + 100))
                dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value = Math.Round(freeqty)
            ElseIf e.ColumnIndex = 4 Then
                If GMod.Cmpid = "PHHA" Then
                    qty = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                    dgSaleVoucher(4, dgSaleVoucher.CurrentCell.RowIndex).Value = qty * Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value)
                ElseIf GMod.Cmpid = "PHOE" Or GMod.Cmpid = "JAHA" Then
                    qty = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                    Dim sqlrate As String
                    sqlrate = "select discount, necc , rate  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value & "'"
                    GMod.DataSetRet(sqlrate, "rate")
                    Dim neccamt1, rate1, dis As Double
                    neccamt1 = Val(GMod.ds.Tables("rate").Rows(0)(1))
                    'neccamt1 = 0
                    dis = Val(GMod.ds.Tables("rate").Rows(0)(0))
                    rate1 = Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value)
                    If txtremark1.Text = "DISCOUNT" Then
                        rate1 = rate1 + neccamt1 - dis
                    Else
                        rate1 = rate1 + neccamt1
                    End If
                    'MsgBox(rate1)

                    dgSaleVoucher(4, dgSaleVoucher.CurrentCell.RowIndex).Value = qty * rate1
                End If
            ElseIf e.ColumnIndex = 1 Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '  Dim frm As New frmSaleInvoicePrint
        Dim frm As New frmInvPrint
        frm.ShowDialog()
    End Sub
    Private Sub ComboBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox3.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        heads()
    End Sub
    Public Sub heads()
        Dim Sql As String
        Sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and Group_name in ('INTERNAL PARTY','CUSTOMER','CANCELLED','PARTNERS CAPITAL') and Area_Code='" & ComboBox2.Text & "'"
        GMod.DataSetRet(Sql, "aclist1")

        cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadname.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclist1")
        ComboBox1.DisplayMember = "group_name"
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim t1 As New frmPartyaccount
        Dim sql As String
        sql = "select Group_name,Suffix from Groups where Group_name like '%PART%' and Cmp_id='" & GMod.Cmpid & "'  and session = '" & GMod.Session & "'"
        GMod.DataSetRet(sql, "Suffix")

        t1.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t1.lblgroupname.DisplayMember = "Group_name"

        t1.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t1.lblgroupsuffix.DisplayMember = "Suffix"
        t1.lblgroupsuffix.Text = "PA"
        t1.Label1.Text = "Party Account Heads"
        t1.ShowDialog()
        CheckBox2.Checked = False
        heads()
    End Sub
    Private Sub ChknewCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChknewCustomer.CheckedChanged
        Dim t As New frmPartyaccount
        Dim sql As String
        sql = "select Group_name,Suffix from Groups where Group_name like '%CUSTOMER%' and Cmp_id='" & GMod.Cmpid & "' and session = '" & GMod.Session & "'"
        GMod.DataSetRet(sql, "Suffix")

        t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupname.DisplayMember = "Group_name"

        t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupsuffix.DisplayMember = "Suffix"

        t.Label1.Text = "Customer Account Heads"
        t.ShowDialog()
        CheckBox2.Checked = False
        heads()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim r As New frmItemmaster
            r.ShowDialog()
            CheckBox1.Checked = False
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim r As String, sql As String, i As Integer
        r = InputBox("Enter Sale Voucher Number to be Modified?")
        If r <> "" Then
            If r <> "" Then
                If LockDataCheck(r, GMod.Session, "SALE") = False Then
                    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'btnsave.Enabled = False
                'btn_modify.Text = "&Update"
                lblno.Text = r
                sql = "select * from PrintData where type='P' and Vou_no= '" & r & "' and Vou_type='SALE' and Cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                GMod.DataSetRet(sql, "PrintData")
                txtinvoiceno.Text = GMod.ds.Tables("PrintData").Rows(0)("BillNo")
                dtdate.Value = CDate(GMod.ds.Tables("PrintData").Rows(0)("BillDate"))
                dtHatchdate.Value = CDate(GMod.ds.Tables("PrintData").Rows(0)("HatchDate"))
                cmbAreaName.Text = GMod.ds.Tables("PrintData").Rows(0)("Station")
                cmbacheadcode.Text = GMod.ds.Tables("PrintData").Rows(0)("AccCode")
                ComboBox2.Text = GMod.ds.Tables("PrintData").Rows(0)("AccCode").ToString.Substring(0, 2)
                lblno.Text = GMod.ds.Tables("PrintData").Rows(0)("vou_no")
                'MsgBox(GMod.ds.Tables("PrintData").Rows(0)("AccCode").ToString.Substring(0, 2))
                cmbacheadname.Text = GMod.ds.Tables("PrintData").Rows(0)("AccName")
                For i = 0 To GMod.ds.Tables("PrintData").Rows.Count - 1
                    dgSaleVoucher(0, i).Value = i + 1
                    dgSaleVoucher(1, i).Value = GMod.ds.Tables("PrintData").Rows(i)("ProductName")
                    dgSaleVoucher(2, i).Value = Val(GMod.ds.Tables("PrintData").Rows(i)("Qty")) + Val(GMod.ds.Tables("PrintData").Rows(i)("freeqty"))
                    dgSaleVoucher(3, i).Value = GMod.ds.Tables("PrintData").Rows(i)("Rate")
                    dgSaleVoucher(4, i).Value = GMod.ds.Tables("PrintData").Rows(i)("Amount")
                    dgSaleVoucher(5, i).Value = GMod.ds.Tables("PrintData").Rows(i)("freeper")
                    dgSaleVoucher(6, i).Value = GMod.ds.Tables("PrintData").Rows(i)("freeqty")
                    dgSaleVoucher.Rows.Add()
                Next
                dgSaleVoucher.Rows.RemoveAt(i)
            Else
                dgSaleVoucher.Rows.Add()
                Exit Sub
            End If

            If MessageBox.Show("Are U Sure?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                lblno.Text = r
                sql = "delete from PrintData where  Vou_no= '" & r & "' and Vou_type='SALE' and Cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                GMod.SqlExecuteNonQuery(sql)
                sql = "delete from " & GMod.VENTRY & " where  Vou_no= '" & r & "' and Vou_type='SALE' and Cmp_id='" & GMod.Cmpid & "'"
                GMod.SqlExecuteNonQuery(sql)

                sql = "delete from Sale_Receipt where vou_type='" & voutype.Text & "' and  vou_no='" & lblno.Text & "' and cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                GMod.SqlExecuteNonQuery(sql)


                MsgBox("Voucher Deleted", MsgBoxStyle.Information)
                'If btnsave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, r, voutype.Text, dtdate.Value, Now, GMod.Session, "D", GMod.username)
                dgSaleVoucher.Rows.Clear()
                dgSaleVoucher.Rows.Add()
                txtinvoiceno.Focus()
                'End If
            End If
        End If
        'nxtvno()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        cmbAreaName.Text = ComboBox3.Text
    End Sub
    Dim sql As String
    Private Sub cmbacheadname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadname.Leave
        'MsgBox(cmbacheadname.FindStringExact(cmbacheadname.Text))
        If cmbacheadname.FindStringExact(cmbacheadname.Text) = -1 Then
            MsgBox("Account Code does not exists Create A-c Head  **Press SPACE Bar**")
            cmbacheadname.Focus()
        End If
    End Sub
    Private Sub dtHatchdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtHatchdate.Leave
        'If DateDiff(DateInterval.Day, dtHatchdate.Value, dtdate.Value) = 0 Then
        'Else
        '    MessageBox.Show("Invoice Date is  Greater than Hatch Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    dtdate.Focus()
        '    Exit Sub
        'End If
        'MsgBox(DateDiff(DateInterval.Day, dtHatchdate.Value, dtdate.Value))
        'If (DateDiff(DateInterval.Day, dtdate.Value, dtHatchdate.Value)) >= 0 Then
        'Else
        '    MessageBox.Show("Invoice Date is  Greater than Hatch Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    dtdate.Focus()
        '    Exit Sub
        'End If

        
    End Sub
    Private Sub CmbCrHead_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCrHead.KeyUp
        If btnsave.Enabled = True Then
            If e.KeyCode = Keys.F10 Then
                btnsave_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CmbCrHead_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCrHead.Leave
        If CmbCrHead.FindStringExact(CmbCrHead.Text) = -1 Then
            MsgBox("Account Code does not exists")
            CmbCrHead.Focus()
        End If
    End Sub
    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$4 Resting date
        If GMod.Cmpid = "PHHA" Then

        Else
            GMod.DataSetRet("select getdate()", "serverdate")
            dtdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
            dtdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        End If
    End Sub
    Private Sub cmbRefType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRefType.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbRefType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRefType.Leave
        If cmbRefType.Text = "Ags Ref" Then
            sql = "select Ref,sum(cr)-sum(dr) Amount,acc_code from tmpAging group by Ref,acc_code,cmp_id having sum(cr)-sum(dr)>0  and acc_code='" & cmbacheadcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "aging")
            If GMod.ds.Tables("aging").Rows.Count > 0 Then
                dg.DataSource = GMod.ds.Tables("aging")
                dg.Visible = True
                dg.Focus()
            End If
        End If
    End Sub

    Private Sub cmbRefType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRefType.SelectedIndexChanged

    End Sub
    Dim i As Integer = -1
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
        sqlsavecr &= "'" & dtdate.Value.ToShortDateString & "',"
        sqlsavecr &= "'" & Val("") & "',"
        sqlsavecr &= "'" & Val(txtamount.Text) & "',"
        sqlsavecr &= "'" & CDate(txtduedate.Text).ToShortDateString & "',"
        sqlsavecr &= "'" & GMod.Session & "',"
        sqlsavecr &= "'" & GMod.username & "',"
        sqlsavecr &= "'" & DataGridView1.CurrentCell.RowIndex & "',"
        sqlsavecr &= "'" & GMod.Cmpid & "')"

        'GMod.SqlExecuteNonQuery(sqlsavecr)

        'If cr <> Val(dg(0, 4).Value) Then
        '    cmbRefType.Focus()
        'Else
        '    btnsave.Focus()
        'End If
        cmbRefType.SelectedIndex = 0
        txtref.Clear()
        txtduedate.Clear()
        txtamount.Clear()
        i = -1
    End Sub

    Private Sub cmbacheadcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            'dgSaleVoucher.Focus()
        End If
    End Sub
    Private Sub cmbacheadcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadcode.Leave
        Try
            GMod.DataSetRet("select isnull(sum(dramt),0) dramt from " & GMod.VENTRY & " where acc_head_code = '" & cmbacheadcode.Text & "'", "tcsamtcheck")
            If Val(GMod.ds.Tables("tcsamtcheck").Rows(0)(0)) >= 5000000 Then
                MsgBox("Customer Eligible for TCS...")
            End If

            '

            GMod.DataSetRet("select pan_no from " & GMod.ACC_HEAD & "  where account_code = '" & cmbacheadcode.Text & "'", "cuspanno")
            If GMod.ds.Tables("cuspanno").Rows(0)(0).ToString.Length > 8 Then
                lblpan.Text = GMod.ds.Tables("cuspanno").Rows(0)(0).ToString
            Else
                lblpan.Text = "PAN Not Available"
            End If
        Catch ex As Exception
            lblpan.Text = "PAN Not Available"
            MsgBox(ex.Message)
        End Try
       


        'TCS elegibiltuy by pan number 
        sql = "select isnull(sum(dramt),0) from " & GMod.VENTRY & " where Acc_head_code in (select account_code from " & GMod.ACC_HEAD & "  where pan_no='" & lblpan.Text & "')"
        If Val(GMod.ds.Tables("tcsamtcheck").Rows(0)(0)) >= 5000000 Then
            MsgBox("Customer Eligible for TCS...")
        End If


        sql = "select account_code from " & GMod.ACC_HEAD & " where account_head_name = '" & cmbacheadname.Text & "' and  Area_code ='" & cmbAreaCode.Text & "'"
        GMod.DataSetRet(sql, "account_codeexpenses")
        If GMod.ds.Tables("account_codeexpenses").Rows.Count > 0 Then
            If cmbacheadcode.Text.Trim <> GMod.ds.Tables("account_codeexpenses").Rows(0)(0) Then
                MsgBox("A/c Name and Code are Different", MsgBoxStyle.Information)
                cmbacheadcode.Focus()
                Exit Sub
            End If
        Else
            'cmbacheadname.Focus()
            'Exit Sub
        End If


        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='S' and cmp_id='" & GMod.Cmpid & "'")
        'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
        sql = "insert into  tmpAging (Ref_Type, Ref, Acc_Code,cr,vou_type,cmp_id) " & _
              " select Ref_type,Ref,acc_code,sum(cr)-sum(dr) Amount,'S',cmp_id  " & _
              " from Sale_Receipt group by Ref,acc_code,Ref_type,cmp_id having sum(cr)-sum(dr)>0 " & _
              " and acc_code='" & cmbacheadcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
        ' GMod.SqlExecuteNonQuery(sql)
        'cmbRefType_Leave(sender, e)



        '---calculating ledger blance of customer-----------
        Try
            Dim sqlSelect As String = "select q.account_code,q.acname," _
              & " DrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 then  (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end, " _
              & " CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0 then  abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) else 0 end," _
              & " q.group_name," _
              & " isnull(p.dramt,0) + isnull(q.odr,0) d , isnull(p.cramt,0) + q.ocr c , isnull(q.odr,0) odr , q.ocr " _
              & " from (" _
              & " select isnull(sum(dramt),0) dramt ,isnull(sum(cramt),0) cramt,acc_head_code" _
              & " from " & GMod.VENTRY & " " _
              & " where vou_date<='" & Now & "' and Pay_mode<>'-'" _
              & " group by acc_head_code ) p " _
              & " Right Join " _
              & " ( select account_code,account_head_name acname ,group_name, isnull(opening_dr,0) odr  , " _
              & " isnull(opening_cr,0) ocr from " & GMod.ACC_HEAD & " where group_name='CUSTOMER'   and account_code='" & cmbacheadcode.Text & "') q " _
              & " on p.acc_head_code=q.account_code  " _
              & " and  p.acc_head_code='" & cmbacheadcode.Text & "'"

            GMod.DataSetRet(sqlSelect, "custledbal")

            lbldr.Text = GMod.ds.Tables("custledbal").Rows(0)("DrAmt")
            lblcr.Text = GMod.ds.Tables("custledbal").Rows(0)("CrAmt")


           


        Catch ex As Exception
            lbldr.Text = "0.00"
            lblcr.Text = "0.00"
        End Try

        'setting  cr head 
        If voutype.Text = "SALE BR(GST)" Then
            If (voutype.Text = "SALE BR(GST)" And CmbState.Text = "Madhya Pradesh") Then
                CmbCrCode.Text = "**SA0006"
            Else
                CmbCrCode.Text = "**SA0007"
            End If
        End If

        If voutype.Text = "SALE LR(GST)" Then
            If voutype.Text = "SALE LR(GST)" And CmbState.Text = "Madhya Pradesh" Then
                CmbCrCode.Text = "**SA0016"
            Else
                CmbCrCode.Text = "**SA0017"
            End If
        End If

        If voutype.Text = "SALE CR(GST)" Then
            If voutype.Text = "SALE CR(GST)" And CmbState.Text = "Madhya Pradesh" Then
                CmbCrCode.Text = "**SA0021"
            Else
                CmbCrCode.Text = "**SA0022"
            End If
        End If
        If voutype.Text = "SALE HAJIPUR(GST)" Then
            If voutype.Text = "SALE HAJIPUR(GST)" And CmbState.Text = "Bihar" Then
                CmbCrCode.Text = "**SA0014"
            Else
                CmbCrCode.Text = "**SA0015"
            End If
        End If

        If voutype.Text = "SALE RAIPUR(GST)" Then
            If voutype.Text = "SALE RAIPUR(GST)" And CmbState.Text = "Chhattisgarh" Then
                CmbCrCode.Text = "**SA0008"
            Else
                CmbCrCode.Text = "**SA0009"
            End If
        End If

        If voutype.Text = "SALE VARANASI(GST)" Then
            If voutype.Text = "SALE VARANASI(GST)" And CmbState.Text = "Uttar Pradesh" Then
                CmbCrCode.Text = "**SA0012"
            Else
                CmbCrCode.Text = "**SA0013"
            End If
        End If

        If voutype.Text = "SALE WBH-1(GST)" Then
            If voutype.Text = "SALE WBH-1(GST)" And CmbState.Text = "Uttar Pradesh" Then
                CmbCrCode.Text = "**SA0010"
            Else
                CmbCrCode.Text = "**SA0011"
            End If
        End If
    End Sub
    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Escape Then
            txtref.Text = dg(0, dg.CurrentCell.RowIndex).Value
            txtamount.Text = dg(1, dg.CurrentCell.RowIndex).Value
            dg.Visible = False
            txtamount.Focus()
        End If
    End Sub
    Private Sub cmbPrdUnit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPrdUnit.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbPrdUnit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPrdUnit.Leave
        If cmbPrdUnit.FindStringExact(cmbPrdUnit.Text) = -1 Then
            cmbPrdUnit.Focus()
            Exit Sub
        Else
        End If
    End Sub
    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Try
            If btnsave.Enabled = True Then
                MsgBox(GMod.SqlExecuteNonQuery("delete from tmpAging where ci = '" & DataGridView1.CurrentCell.RowIndex & "' and usename ='" & GMod.username & "'"))
            Else
                sql = "select id from Sale_Receipt where ref_type='" & DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value & "' and ref='" & DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value & "' and vou_no='" & lblno.Text & "' and cr='" & DataGridView1(3, DataGridView1.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sql, "delSale_Receipt")

                sql = "delete from Sale_Receipt where id ='" & GMod.ds.Tables("delSale_Receipt").Rows(0)(0).ToString & "'"
                GMod.SqlExecuteNonQuery(sql)


                GMod.SqlExecuteNonQuery("delete from tmpAging where ci = '" & DataGridView1.CurrentCell.RowIndex & "' and usename ='" & GMod.username & "'")

            End If
            GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='S' and cmp_id='" & GMod.Cmpid & "'")
            'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
            sql = "insert into  tmpAging (Ref_Type, Ref, Acc_Code,cr,vou_type,cmp_id) " & _
                  " select Ref_type,Ref,acc_code,sum(cr)-sum(dr) Amount,'S',cmp_id  " & _
                  " from Sale_Receipt group by Ref,acc_code,Ref_type,cmp_id having sum(cr)-sum(dr)>0 " & _
                  " and acc_code='" & cmbacheadcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.SqlExecuteNonQuery(sql)
            cmbRefType.SelectedIndex = 0
            cmbRefType.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub voutype_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles voutype.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub voutype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles voutype.Leave
        Dim sql As String
        'If GMod.Cmpid = "PHHA" Then
        '    If btnsave.Enabled = True Then
        '        If voutype.Text = "SALE BR(GST)" Or voutype.Text = "SALES" Then
        '            sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' and  ItemName like '%BROILER%'  order by ItemName "
        '            GMod.DataSetRet(sql, "Item1")

        '            Me.pcname.DataSource = GMod.ds.Tables("Item1")
        '            Me.pcname.DisplayMember = "ItemName"
        '        End If
        '        If voutype.Text = "SALE LR(GST)" Or voutype.Text = "SALES LAYER" Or voutype.Text = "SALE LR RAIPUR(GST)" Or voutype.Text = "SALE LR JBP(GST)" Then
        '            sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' and  ItemName like '%LAYER%'  order by ItemName "
        '            GMod.DataSetRet(sql, "Item1")

        '            Me.pcname.DataSource = GMod.ds.Tables("Item1")
        '            Me.pcname.DisplayMember = "ItemName"
        '        End If
        '        If voutype.Text = "SALE CR(GST)" Or voutype.Text = "SALE CR RAIPUR(GST)" Or voutype.Text = "SALE CR JBP(GST)" Then
        '            sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' and  ItemName like '%COCKREL%'  order by ItemName "
        '            GMod.DataSetRet(sql, "Item1")

        '            Me.pcname.DataSource = GMod.ds.Tables("Item1")
        '            Me.pcname.DisplayMember = "ItemName"
        '        End If
        '        If voutype.Text = "SALE WBH-1(GST)" Then
        '            sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' and  ItemName like '%BROILER%'  order by ItemName "
        '            GMod.DataSetRet(sql, "Item1")

        '            Me.pcname.DataSource = GMod.ds.Tables("Item1")
        '            Me.pcname.DisplayMember = "ItemName"
        '        End If
        '        If voutype.Text = "SALE WBH-1(GST)" Or voutype.Text = "SALES WBR" Then
        '            sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' and  ItemName like '%BROILER%'  order by ItemName "
        '            GMod.DataSetRet(sql, "Item1")

        '            Me.pcname.DataSource = GMod.ds.Tables("Item1")
        '            Me.pcname.DisplayMember = "ItemName"
        '        End If
        '        If voutype.Text = "SALE HAJIPUR(GST)" Or voutype.Text = "SALES HJ" Then
        '            sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' order by ItemName "
        '            GMod.DataSetRet(sql, "Item1")

        '            Me.pcname.DataSource = GMod.ds.Tables("Item1")
        '            Me.pcname.DisplayMember = "ItemName"
        '        End If

        '        If voutype.Text = "SALE VARANASI(GST)" Or voutype.Text = "SALES VNS" Then
        '            sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' order by ItemName "
        '            GMod.DataSetRet(sql, "Item1")

        '            Me.pcname.DataSource = GMod.ds.Tables("Item1")
        '            Me.pcname.DisplayMember = "ItemName"

        '        End If
        '        'SALE RAIPUR
        '        If voutype.Text = "SALE RAIPUR(GST)" Or voutype.Text = "SALES RP" Then
        '            sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' order by ItemName "
        '            GMod.DataSetRet(sql, "Item1")

        '            Me.pcname.DataSource = GMod.ds.Tables("Item1")
        '            Me.pcname.DisplayMember = "ItemName"
        '        End If
        '    Else

        '        sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' order by ItemName "
        '        GMod.DataSetRet(sql, "Item1")

        '        Me.pcname.DataSource = GMod.ds.Tables("Item1")
        '        Me.pcname.DisplayMember = "ItemName"

        '    End If
        'Else
        sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and prdtype='CHICKS' order by ItemName "
        GMod.DataSetRet(sql, "Item1")

        Me.pcname.DataSource = GMod.ds.Tables("Item1")
        Me.pcname.DisplayMember = "ItemName"
        'End If
        voutype.Enabled = False
    End Sub

    Private Sub voutype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voutype.SelectedIndexChanged
        Label17.Text = voutype.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub dtdate_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub lblno_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lblno.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAreaCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaCode.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CmbCrCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCrCode.KeyUp
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

    Private Sub dtdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtdate.Leave
        If btnsave.Enabled = True Then
            GMod.DataSetRet("select isnull(max(vou_date),'" & dtdate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & voutype.Text & "'", "getMaxDate")
            If dtdate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
                MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dtdate.Focus()
            End If
        End If
    End Sub

    Private Sub dtdate_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdate.ValueChanged
        'If btnsave.Enabled = True Then
        'GMod.DataSetRet("select getdate()", "serverdate")
        'dtdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        'dtdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        'End If

        'dtdate.Value = GMod.SessionCurrentDate
        dtdate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtdate.MaxDate = GMod.SessionCurrentDate
    End Sub

    Private Sub FetchTcsDetilas()
        Dim sql As String
        Try
            sql = "select tcs.*,a.account_head_name from TCsMaster tcs inner join " & GMod.ACC_HEAD & " a on tcs.Acc_code = a.account_code  where TcStype ='" & cmbTcsType.Text & "'"
            GMod.DataSetRet(sql, "tcsdata")

            cmbTcsHead.Text = GMod.ds.Tables("tcsdata").Rows(0)("account_head_name").ToString
            cmbTcsHeadCode.Text = GMod.ds.Tables("tcsdata").Rows(0)("Acc_code").ToString
            txtTcsPer.Text = GMod.ds.Tables("tcsdata").Rows(0)("Per").ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbTcsType_Leave(sender As Object, e As EventArgs) Handles cmbTcsType.Leave
        FetchTcsDetilas()
    End Sub

    Private Sub cmbTcsType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTcsType.SelectedIndexChanged
        FetchTcsDetilas()
    End Sub
    Private Sub chKtcs_CheckedChanged(sender As Object, e As EventArgs) Handles chKtcs.CheckedChanged
        Dim neccamttcs As Integer = 0
        Dim neccvaltcs As Double = 0
        Try
            'Dim sql As String
            'If chKtcs.Checked = True Then
            'sql = "select discount, necc  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, 0).Value & "'"
            'GMod.DataSetRet(sql, "neccamyfortcs")
            'MessageBox.Show(Val(GMod.ds.Tables("neccamyfortcs").Rows(0)(1)))
            'End If
            If chKtcs.Checked = True Then
                'If GMod.Cmpid = "PHHA" Then
                '    Dim s As String = "select discount, necc  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, 0).Value & "'"
                '    GMod.DataSetRet(s, "NECCAMOUNTfortcs")
                '    neccamttcs = Val(GMod.ds.Tables("NECCAMOUNTfortcs").Rows(0)(1))

                '    If neccamttcs > 0 Then 'FOR NECC CONTRIBUTION
                '        neccvaltcs = (Val(dgSaleVoucher(2, 0).Value) - Val(dgSaleVoucher(6, 0).Value)) * neccamttcs
                '    End If
                'End If
                Dim tcs As Double
                tcs = Math.Ceiling((Val(dgSaleVoucher(4, 0).Value) + neccvaltcs) * (Val(txtTcsPer.Text) / 100))
                txtTcsAmount.Text = tcs.ToString
            Else
                txtTcsAmount.Text = 0
            End If
            neccamttcs = 0
            neccvaltcs = 0
        Catch ex As Exception

        End Try

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

    Private Sub chkTDS_CheckedChanged(sender As Object, e As EventArgs) Handles chkTDS.CheckedChanged
        Dim neccamttcs As Integer = 0
        Dim neccvaltcs As Double = 0
        Try
            If chkTDS.Checked = True Then
                Dim tds As Double
                tds = Math.Ceiling((Val(dgSaleVoucher(4, 0).Value) + neccvaltcs) * (Val(cmbTdsper.Text) / 100))
                txtTDSAmount.Text = tds.ToString
            Else
                txtTDSAmount.Text = 0
            End If
            neccamttcs = 0
            neccvaltcs = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgSaleVoucher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSaleVoucher.CellContentClick

    End Sub
End Class