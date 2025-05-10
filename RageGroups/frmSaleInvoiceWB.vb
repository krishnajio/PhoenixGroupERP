Imports System.Data.SqlClient
Public Class frmSaleInvoiceWB
    Dim ach As New frmacheadlist
    Dim frmnarrationlistobj As New frmNarrationEntrybox
    Private Sub frmSaleInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If GMod.Cmpid = "PHHA" Then
        Else

            GMod.DataSetRet("select getdate()", "serverdate")
            dtdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
            dtdate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        End If

        Label3.Text = "CR NOTE [" & GMod.Cmpname & "]"
        If cmbsubgroup.Text.Length = 0 Then
            cmbsubgroup.Text = "-"
        End If
        txtinvoiceno.Focus()
        fillItems()
        fillArea()
        cmbAreaCode.Text = "JB"
        nxtvno()
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        dgSaleVoucher.Rows.Add()
        Dim Sql As String
        Sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and Group_name in ('INTERNAL PARTY','CUSTOMER','PARTY','CANCELLED') and Area_Code='" & ComboBox2.Text & "'"
        GMod.DataSetRet(Sql, "aclist1")

        cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadname.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclist1")
        ComboBox1.DisplayMember = "group_name"

        cmbsubgroup.DataSource = GMod.ds.Tables("aclist1")
        cmbsubgroup.DisplayMember = "sub_group_name"

        txtremark1.DataSource = GMod.ds.Tables("aclist1")
        txtremark1.DisplayMember = "remark1"


        Sql = " select * from " & GMod.ACC_HEAD & " where Group_name like  '%SALE%'"
        GMod.DataSetRet(Sql, "salehead")

        CmbCrCode.DataSource = GMod.ds.Tables("salehead")
        CmbCrCode.DisplayMember = "account_code"
        CmbCrHead.DataSource = GMod.ds.Tables("salehead")
        CmbCrHead.DisplayMember = "account_head_name"


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
    End Sub
    Public Sub fillItems()
        Dim sql As String
        sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' order by ItemName "
        GMod.DataSetRet(sql, "Item1")

        Me.pcname.DataSource = GMod.ds.Tables("Item1")
        Me.pcname.DisplayMember = "ItemName"
    End Sub
    Private Sub dgSaleVoucher_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSaleVoucher.CellEndEdit
        'Calculatea al thing if feer per changes
        If e.ColumnIndex = 5 Or e.ColumnIndex = 2 Then
            Dim fr As Double
            Dim qty1 As String
            fr = (Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - (Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) * 100) / (dgSaleVoucher(5, dgSaleVoucher.CurrentCell.RowIndex).Value + 100))
            dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value = Math.Round(fr, 0)
            'MsgBox(fr)
            If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "WEPH" Then
                qty1 = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                dgSaleVoucher(4, dgSaleVoucher.CurrentCell.RowIndex).Value = qty1 * Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value)
            ElseIf GMod.Cmpid = "PHPO" Or GMod.Cmpid = "JAHA" Or GMod.Cmpid = "UNWE" Or GMod.Cmpid = "UNTH" Or GMod.Cmpid = "RAUN" Then
                qty1 = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                Dim sqlrate As String
                sqlrate = "select discount, necc , rate  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sqlrate, "rate")
                Dim neccamt1, rate1, dis As Double
                neccamt1 = Val(GMod.ds.Tables("rate").Rows(0)(1))
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
    End Sub
    Private Sub dgSaleVoucher_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSaleVoucher.CellEnter

        Dim qty As String
        If e.ColumnIndex = 4 Then
            If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "WEPH" Then
                qty = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                dgSaleVoucher(4, dgSaleVoucher.CurrentCell.RowIndex).Value = qty * Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value)
            ElseIf GMod.Cmpid = "PHPO" Or GMod.Cmpid = "JAHA" Or GMod.Cmpid = "UNWE" Or GMod.Cmpid = "UNTH" Or GMod.Cmpid = "RAUN" Then
                qty = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                Dim sqlrate As String
                sqlrate = "select discount, necc , rate  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sqlrate, "rate")
                Dim neccamt1, rate1, dis As Double
                neccamt1 = Val(GMod.ds.Tables("rate").Rows(0)(1))
                dis = Val(GMod.ds.Tables("rate").Rows(0)(0)) 'Discount Amount
                'MsgBox(dis)
                rate1 = Val(GMod.ds.Tables("rate").Rows(0)(2)) 'rate
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
            MsgBox("Please Create Head of N.E.C.C FARMER CONTRIBUTION")
        End If
    End Sub
    Sub gettingDISCOUNTcodes()
        Dim sql As String
        sql = "select account_code, account_head_name,group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='DISCOUNT AMOUNT'"
        GMod.DataSetRet(sql, "heads1")
        If GMod.ds.Tables("heads1").Rows.Count > 0 Then
            discode = GMod.ds.Tables("heads1").Rows(0)(0).ToString
        Else
            MsgBox("Please Create Head of DISCOUNT AMOUNT")
        End If
        GMod.ds.Tables("heads1").Dispose()
    End Sub

    Sub gettingcodes()
        Dim sql As String
        sql = " select account_code, account_head_name,group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='N.E.C.C FARMER CONTRIBUTION'"
        GMod.DataSetRet(sql, "heads")
        If GMod.ds.Tables("heads").Rows.Count > 0 Then
            neccode = GMod.ds.Tables("heads").Rows(0)(0).ToString
            necchead = GMod.ds.Tables("heads").Rows(0)(1).ToString
            neccgrp = GMod.ds.Tables("heads").Rows(0)(2).ToString
            neccsgrp = GMod.ds.Tables("heads").Rows(0)(3).ToString
            GMod.ds.Tables("heads").Dispose()
        Else
            MsgBox("Please Create Head of N.E.C.C FARMER CONTRIBUTION")
        End If

        sql = "select account_code, account_head_name,group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='DISCOUNT AMOUNT'"
        GMod.DataSetRet(sql, "heads1")
        If GMod.ds.Tables("heads").Rows.Count > 0 Then
            discode = GMod.ds.Tables("heads1").Rows(0)(0).ToString
        Else
            MsgBox("Please Create Head of DISCOUNT AMOUNT")
        End If
        GMod.ds.Tables("heads").Dispose()
        GMod.ds.Tables("heads1").Dispose()
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then


            If btnsave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, txtinvoiceno.Text, voutype.Text, dtdate.Value, Now, GMod.Session, "M", GMod.username)
            End If
            'If txtinvoiceno.Text = "" Then
            '    MsgBox("Invoice No. cant be blank")
            '    txtinvoiceno.Focus()
            '    Exit Sub
            'End If
            'gettingcodes()
            Dim sqltrans As SqlTransaction
            sqltrans = GMod.SqlConn.BeginTransaction
            Dim sqlneccamt As String
            Dim sql As String
            Dim neccamt, neccval, discountamount, discountval, productamount As Double
            Dim sqlsavenecc, zero, saveprd, ssaveprdvntry As String
            zero = "0"
            Dim i As Integer
            Dim c, h, g, s, pn As String
            Dim narration As String
            nxtvno()
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
                End If
                Dim qty As Double
                Dim nar As String
                For i = 0 To dgSaleVoucher.Rows.Count - 1
                    'MsgBox("SALE OF " & dgSaleVoucher(1, i).Value.ToString)
                    qty = dgSaleVoucher(2, i).Value - dgSaleVoucher(6, i).Value
                    pn = "SALE OF " & dgSaleVoucher(1, i).Value.ToString

                    narration = "BEING CREDIT NOTE ISSUED AGAINST " & txtinvoiceno.Text & " HATCH DATE : " & dtHatchdate.Text & "  QTY " & dgSaleVoucher(2, i).Value - dgSaleVoucher(6, i).Value & " + " & dgSaleVoucher(6, i).Value & "@ " & dgSaleVoucher(3, i).Value & " " & txtnarr.Text

                    nar = nar & narration
                    'Getting product head name
                    sql = "select account_code, account_head_name,group_name, sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='" & pn & "'"
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
                    If neccamt > 0 Then '
                        gettingNECCcodes()
                        neccval = (Val(dgSaleVoucher(2, i).Value) - Val(dgSaleVoucher(6, i).Value)) * neccamt
                        'MsgBox(neccval)
                        'Inserting NECC AMONT in VENTRY
                        sqlsavenecc = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name) VALUES ("
                        sqlsavenecc &= "'" & GMod.Cmpid & "',"
                        sqlsavenecc &= "'" & GMod.username & "',"
                        sqlsavenecc &= "'" & i + 8 & "',"
                        sqlsavenecc &= "'" & lblno.Text & "',"
                        sqlsavenecc &= "'" & voutype.Text & "',"
                        sqlsavenecc &= "'" & dtHatchdate.Value.ToShortDateString & "',"
                        sqlsavenecc &= "'" & neccode & "',"
                        sqlsavenecc &= "'" & necchead & "',"
                        sqlsavenecc &= "'" & neccval.ToString & "',"
                        sqlsavenecc &= "'" & Val(zero) & "',"
                        sqlsavenecc &= "'" & narration & "',"
                        sqlsavenecc &= "'" & neccgrp & "',"
                        sqlsavenecc &= "'" & neccsgrp & "')"
                        'MsgBox(sqlsavenecc)
                        'MsgBox(GMod.SqlExecuteNonQuery(sqlsavenecc))
                        Dim cmdneccventry As New SqlCommand(sqlsavenecc, GMod.SqlConn, sqltrans)
                        cmdneccventry.ExecuteNonQuery()

                        'Inserting NECC AMONT for PRINT DATA
                        sqlsavenecc = "insert into PrintData (Vou_type, Vou_no, AccCode, AccName, Station, ProductName," _
                                       & "Qty, Rate, Amount, DiscountRate, DiscountAmount, " _
                                       & "NeccRate, NeccAmount, FreePer, FreeQty, HatchDate," _
                                       & "BillNo, BillDate, Cmp_id, Session,type) VALUES ("
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
                        sqlsavenecc &= "'V')"
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
                        Dim cr As Double
                        cr = Val(dgSaleVoucher(4, i).Value.ToString) - neccval
                        'Inserting PRODUCT AMONT in VENTRY
                        ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name) VALUES ("
                        ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                        ssaveprdvntry &= "'" & GMod.username & "',"
                        ssaveprdvntry &= "'" & i + 1 & "',"
                        ssaveprdvntry &= "'" & lblno.Text & "',"
                        ssaveprdvntry &= "'" & voutype.Text & "',"
                        ssaveprdvntry &= "'" & dtHatchdate.Value.ToShortDateString & "',"
                        ssaveprdvntry &= "'" & CmbCrCode.Text & "',"
                        ssaveprdvntry &= "'" & CmbCrHead.Text & "',"

                        ssaveprdvntry &= "'" & cr.ToString & "',"
                        ssaveprdvntry &= "'" & Val(zero) & "',"
                        ssaveprdvntry &= "'" & narration.ToString & "',"
                        ssaveprdvntry &= "'-',"
                        ssaveprdvntry &= "'-')"
                        'MsgBox(ssaveprdvntry)
                        'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                        Dim cmd4 As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                        cmd4.ExecuteNonQuery()
                    Else
                        ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                        & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                        & " Narration, Group_name, Sub_group_name) VALUES ("
                        ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                        ssaveprdvntry &= "'" & GMod.username & "',"
                        ssaveprdvntry &= "'" & i + 1 & "',"
                        ssaveprdvntry &= "'" & lblno.Text & "',"
                        ssaveprdvntry &= "'" & voutype.Text & "',"
                        ssaveprdvntry &= "'" & dtHatchdate.Value.ToShortDateString & "',"
                        ssaveprdvntry &= "'" & CmbCrCode.Text & "',"
                        ssaveprdvntry &= "'" & CmbCrHead.Text & "',"

                        ssaveprdvntry &= "'" & dgSaleVoucher(4, i).Value & "',"
                        ssaveprdvntry &= "'" & Val(zero) & "',"
                        ssaveprdvntry &= "'" & narration.ToString & "',"
                        ssaveprdvntry &= "'-',"
                        ssaveprdvntry &= "'-')"
                        'MsgBox(ssaveprdvntry)
                        'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                        Dim cmd5 As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                        cmd5.ExecuteNonQuery()

                    End If
                    'Inserting product for PRINT DATA
                    sqlsavenecc = "insert into PrintData (Vou_type, Vou_no, AccCode, AccName, Station, ProductName," _
                                   & "Qty, Rate, Amount, DiscountRate, DiscountAmount, " _
                                   & "NeccRate, NeccAmount, FreePer, FreeQty, HatchDate," _
                                   & "BillNo, BillDate, Cmp_id, Session,type) VALUES ("
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
                    sqlsavenecc &= "'" & GMod.Getsession(dtdate.Value).ToString & "',"
                    sqlsavenecc &= "'P')"
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
                'Entry customer values Cr
                ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                                    & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                                    & " Narration, Group_name, Sub_group_name) VALUES ("
                ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                ssaveprdvntry &= "'" & GMod.username & "',"
                ssaveprdvntry &= "'0',"
                ssaveprdvntry &= "'" & lblno.Text & "',"
                ssaveprdvntry &= "'" & voutype.Text & "',"
                ssaveprdvntry &= "'" & dtHatchdate.Value.ToShortDateString & "',"
                ssaveprdvntry &= "'" & cmbacheadcode.Text & "',"
                ssaveprdvntry &= "'" & cmbacheadname.Text & "',"

                ssaveprdvntry &= "'0',"
                ssaveprdvntry &= "'" & productamount.ToString & "',"
                ssaveprdvntry &= "'" & nar & "',"
                ssaveprdvntry &= "'" & ComboBox1.Text & "',"
                ssaveprdvntry &= "'" & cmbsubgroup.Text & "')"
                'MsgBox(ssaveprdvntry)
                'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                Dim cmd6 As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                cmd6.ExecuteNonQuery()
                btnsave.Enabled = True
                btn_modify.Text = "&Modify"
                sqltrans.Commit()
                MsgBox("CREDIT NOTE / " & lblno.Text)
                dgSaleVoucher.Rows.Clear()
                dgSaleVoucher.Rows.Add()
                txtinvoiceno.Focus()
            Catch ex As Exception
                sqltrans.Rollback()
                MsgBox(ex.Message)
            End Try
            'nxtvno()

            sqltrans.Dispose()
        Else
            Exit Sub
        End If
    End Sub
    Sub nxtvno()
        Dim sql As String
        Try
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & voutype.Text & "'"
            GMod.DataSetRet(Sql, "vno8")
            lblno.Text = ds.Tables("vno8").Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

  

    Private Sub btn_modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modify.Click
        Try

            'Vou_type, Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, DiscountRate, DiscountAmount, NeccRate, 
            'NeccAmount, freeper, freeqty, HatchDate, BillNo, BillDate, Cmp_id, Session, Type
            If btn_modify.Text = "&Modify" Then
                'btnsave.Enabled = False
                'btn_modify.Text = "&Update"
                Dim r As String, sql As String, i As Integer
                r = InputBox("Enter Sale Voucher Number to be Modified?")
                If r <> "" Then
                    If LockDataChecks(r, GMod.Session, voutype.Text) = False Then
                        MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    btnsave.Enabled = False
                    btn_modify.Text = "&Update"
                    lblno.Text = r
                    sql = "select * from PrintData where type='P' and Vou_no= '" & r & "' and Vou_type='" & voutype.Text & "' and Cmp_id='" & GMod.Cmpid & "' and Session='" & GMod.Session & "'"
                    GMod.DataSetRet(sql, "PrintData")
                    txtinvoiceno.Text = GMod.ds.Tables("PrintData").Rows(0)("BillNo")
                    dtdate.Value = CDate(GMod.ds.Tables("PrintData").Rows(0)("BillDate"))
                    dtHatchdate.Value = CDate(GMod.ds.Tables("PrintData").Rows(0)("HatchDate"))
                    cmbAreaName.Text = GMod.ds.Tables("PrintData").Rows(0)("Station")
                    cmbacheadcode.Text = GMod.ds.Tables("PrintData").Rows(0)("AccCode")
                    ComboBox2.Text = GMod.ds.Tables("PrintData").Rows(0)("AccCode").ToString.Substring(0, 2)
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


                    sql = "select Acc_head , narration from " & GMod.VENTRY & " where dramt >0 and vou_type ='" & voutype.Text & "' and vou_no='" & r & "' and acc_head like '%" & dgSaleVoucher(1, 0).Value & "%'"
                    GMod.DataSetRet(sql, "crhead")
                    CmbCrHead.Text = GMod.ds.Tables("crhead").Rows(0)(0).ToString
                    txtnarr.Text = GMod.ds.Tables("crhead").Rows(0)(1).ToString


                    dgSaleVoucher.Rows.RemoveAt(i)
                Else
                    dgSaleVoucher.Rows.Add()
                    Exit Sub
                End If
            Else
                If MessageBox.Show("Do U want to Modify", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    btnsave_Click(sender, e)
                    btn_modify.Text = "&Modify"
                    btnsave.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Error in updation ")
        End Try
        
    End Sub

    Private Sub txtinvoiceno_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinvoiceno.KeyUp
        If e.KeyCode = Keys.Enter Then dtdate.Focus()
    End Sub

    Private Sub dtdate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtdate.KeyUp
        If e.KeyCode = Keys.Enter Then dtHatchdate.Focus()
    End Sub

    Private Sub dtHatchdate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtHatchdate.KeyUp
        If e.KeyCode = Keys.Enter Then cmbAreaName.Focus()
    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If e.KeyCode = Keys.Enter Then ComboBox3.Focus()
    End Sub
    Private Sub cmbacheadname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyUp
        If e.KeyCode = Keys.Enter Then dgSaleVoucher.Focus()
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
                sqlUnit = "select Rate,freeqtyper from ItemMaster " _
                   & " where cmp_id='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sqlUnit, "Unit")
                If btnsave.Enabled = True Then
                    dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value = GMod.ds.Tables("Unit").Rows(0)(0)
                End If
                dgSaleVoucher(5, dgSaleVoucher.CurrentCell.RowIndex).Value = GMod.ds.Tables("Unit").Rows(0)(1)
            ElseIf e.ColumnIndex = 3 Then
                'caculation
                freeqty = (Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - (Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) * 100) / (dgSaleVoucher(5, dgSaleVoucher.CurrentCell.RowIndex).Value + 100))
                dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value = Math.Round(freeqty)
            ElseIf e.ColumnIndex = 4 Then
                If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "WEPH" Then
                    qty = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                    dgSaleVoucher(4, dgSaleVoucher.CurrentCell.RowIndex).Value = qty * Val(dgSaleVoucher(3, dgSaleVoucher.CurrentCell.RowIndex).Value)
                ElseIf GMod.Cmpid = "PHPO" Or GMod.Cmpid = "JAHA" Or GMod.Cmpid = "UNWE" Or GMod.Cmpid = "UNTH" Or GMod.Cmpid = "RAUN" Then
                    qty = Val(dgSaleVoucher(2, dgSaleVoucher.CurrentCell.RowIndex).Value) - Val(dgSaleVoucher(6, dgSaleVoucher.CurrentCell.RowIndex).Value)
                    Dim sqlrate As String
                    sqlrate = "select discount, necc , rate  from ItemMaster where CmP_ID='" & GMod.Cmpid & "' and ItemName='" & dgSaleVoucher(1, dgSaleVoucher.CurrentCell.RowIndex).Value & "'"
                    GMod.DataSetRet(sqlrate, "rate")
                    Dim neccamt1, rate1, dis As Double
                    neccamt1 = Val(GMod.ds.Tables("rate").Rows(0)(1))
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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgSaleVoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgSaleVoucher.KeyDown
        If btnsave.Enabled = True Then
            If e.KeyCode = Keys.F10 Then
                btnsave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmPHCreditNotePrint
        frm.ShowDialog()
    End Sub
    Private Sub ComboBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox3.KeyUp
        If e.KeyCode = Keys.Enter Then cmbacheadname.Focus()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        heads()
    End Sub
    Public Sub heads()
        Dim Sql As String
        Sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and Group_name in ('INTERNAL PARTY','CUSTOMER','CANCELLED') and Area_Code='" & ComboBox2.Text & "'"
        GMod.DataSetRet(Sql, "aclist1")

        cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadname.DisplayMember = "account_head_name"

        ComboBox1.DataSource = GMod.ds.Tables("aclist1")
        ComboBox1.DisplayMember = "group_name"
    End Sub


    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        heads()
    End Sub

    Private Sub ChknewCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmPartyaccount
        Dim sql As String
        sql = "select Group_name,Suffix from Groups where Group_name like '%CUSTOMER%' and Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "Suffix")

        t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupname.DisplayMember = "Group_name"

        t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupsuffix.DisplayMember = "Suffix"

        t.Label1.Text = "Customer Account Heads"
        t.ShowDialog()

        heads()
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

    Private Sub dgSaleVoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSaleVoucher.CellContentClick

    End Sub

    Private Sub txtinvoiceno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinvoiceno.TextChanged
        '  lblno.Text = txtinvoiceno.Text
    End Sub

    Private Sub dtHatchdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtHatchdate.Leave
        If dtHatchdate.Value < dtdate.Value Then
        Else
            MsgBox("Invoice date is  greate than hatch date")
            dtdate.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub dtHatchdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtHatchdate.ValueChanged

    End Sub

    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdate.ValueChanged
        If GMod.Cmpid = "PHHA" Then

        Else

            GMod.DataSetRet("select getdate()", "serverdate")
            dtdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
            dtdate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        End If
    End Sub

 
    Private Sub lblno_TextChanged(sender As Object, e As EventArgs) Handles lblno.TextChanged

    End Sub
End Class