Imports System.Data.SqlClient
Public Class frmSaleInvRCM

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
    Dim sql As String
    Private Sub frmSaleInv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' MsgBox(Math.Round(12.5))
        'MsgBox(Math.Round(12.51))

        '  dtinvdate.MinDate = Format(CDate("4/1/" & Mid(GMod.Session, 1, 2)), "MM/dd/yyyy")
        ' dtinvdate.MaxDate = Format(CDate("3/31/" & Mid(GMod.Session, 3, 4)), "MM/dd/yyyy")
        'dtinvdate.MinDate = Now
        'dtinvdate.MaxDate = Now
        ' dtpChallanDate.MinDate = Now
        'dtpChallanDate.MaxDate = Now

        ' dtpIssue.MinDate = Now
        'dtpIssue.MaxDate = Now
        ' dtpRemoval.MinDate = Now
        ' dtpRemoval.MaxDate = Now

        If Vtype = "Debit Note" Then
            sql = " select * from Acc_head " _
            & " where group_code in ( " _
            & " select groupcode from Groups where GroupName like '%Sundry Creditors%' " _
            & "or UnderGroup like '%Sundry Creditors%' )  AND CMP_ID='" & GMod.Cmpid & "' order by acc_name"
        End If
        If Vtype = "TAX INVOICE(RCM)" Or Vtype = "Payment Voucher" Then
            sql = " select * from Acc_head " _
            & " where group_code in ( " _
            & " select groupcode from Groups where GroupName like '%Sundry Creditors%' " _
            & "or UnderGroup like '%Sundry Creditors%' )  AND CMP_ID='" & GMod.Cmpid & "' order by acc_name"
        End If

        If Vtype = "Credit Note" Then
            sql = " select * from Acc_head " _
            & " where group_code in ( " _
            & " select groupcode from Groups where GroupName like '%Sundry Debtors%' " _
            & "or UnderGroup like '%Sundry Debtors%' )  AND CMP_ID='" & GMod.Cmpid & "' order by acc_name"
        End If

        sql = "select * from " & GMod.ACC_HEAD
        GMod.DataSetRet(sql, "Party")
        cmbcode.DataSource = GMod.ds.Tables("Party")
        cmbcode.DisplayMember = "Account_code"

        cmbParty.DataSource = GMod.ds.Tables("Party")
        cmbParty.DisplayMember = "Account_head_name"

        cmbAdd.DataSource = GMod.ds.Tables("Party")
        cmbAdd.DisplayMember = "Address"

        cmbtin.DataSource = GMod.ds.Tables("Party")
        cmbtin.DisplayMember = "Remark3"

        cmbState.DataSource = GMod.ds.Tables("Party")
        cmbState.DisplayMember = "State"


        'Fill Product 

        'Filling Voucher Type
        sql = "select * from Vouchers where  cmp_id='" & GMod.Cmpid & "' and voucher_type like '%" & Vtype & "%' or under_voucher_type='" & Vtype & "' or (voucher_type like '%STOCK JOURNAL%' or under_voucher_type='STOCK JOURNAL') or (voucher_type like '%GOODS RETURN%' )"
        GMod.DataSetRet(sql, "SaleVType88")
        cmbVouchertype.DataSource = GMod.ds.Tables("SaleVType88")
        cmbVouchertype.DisplayMember = "voucher_type"

        cmbvtypecode.DataSource = GMod.ds.Tables("SaleVType88")
        cmbvtypecode.DisplayMember = "voucher_type_code"
        cmbVouchertype_SelectedIndexChanged(sender, e)
        dtpcustOrdRefDt.Value = CDate("2000/1/1")
        fillGrid()

        sql = "select isnull(max(right(invoice_no,6)),0) + 1 invno from sale_inv  where cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' AND inv_type ='" & Vtype & "'"
        GMod.DataSetRet(sql, "invno")
        txtinvoiceno.Text = Format(ds.Tables("invno").Rows(0)(0), "0000")
        'cmbVouchertype.SelectedIndex = 0
        cmbParty.Focus()
    End Sub

    Private Sub cmbAdd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdd.SelectedIndexChanged
        txtAddress.Text = cmbAdd.Text
    End Sub

    Private Sub cmbtin_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtin.SelectedIndexChanged
        txtTIN.Text = cmbtin.Text
    End Sub
    Private Sub cmbVouchertype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVouchertype.Leave
        If cmbVouchertype.FindStringExact(cmbVouchertype.Text) = -1 Then
            MsgBox("Select Correct Voucher type", MsgBoxStyle.Information)
            cmbVouchertype.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub cmbVouchertype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVouchertype.SelectedIndexChanged
        sql = "select isnull(max(right(invoice_no,6)),0) + 1 invno from sale_inv  where cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' and inv_type ='" & Vtype & "'"
        GMod.DataSetRet(sql, "invno")
        txtinvoiceno.Text = Format(ds.Tables("invno").Rows(0)(0), "0000")
    End Sub
    Private Sub cmbproduct_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbproduct.Enter
        'Try
        '    GMod.ds.Tables("Product").Clear()
        'Catch ex As Exception
        'End Try

        'Dim sql As String
        'sql = "select * from ItemVsAccCode where cmp_id='" & GMod.Cmpid & "' and acccode='" & cmbcode.Text & "' "
        'GMod.DataSetRet(sql, "Product")

        'cmbproduct.DataSource = GMod.ds.Tables("Product")
        'cmbproduct.DisplayMember = "itemname"

        'cmbDesc.DataSource = GMod.ds.Tables("Product")
        'cmbDesc.DisplayMember = "Descrp"

        'grp1.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub cmbproduct_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbproduct.Leave
        'If cmbproduct.Text = "" Then
        '    MsgBox("Please Select A Product", MsgBoxStyle.Information)
        '    cmbproduct.Focus()
        '    Exit Sub
        'End If
        If cmbproduct.FindStringExact(cmbproduct.Text) = -1 Then
            MsgBox("Please Select Correct Product", MsgBoxStyle.Information)
            'cmbproduct.Focus()
            Exit Sub
        End If
        Dim sql As String 'OtherTax1, OtherTax2, username, EntryDate, Rate
        Try

            Dim b() As String
            b = cmbproduct.Text.Split("#")
            sql = "select * from ItemMaster where cmp_id='" & GMod.Cmpid & "' and itemname='" & cmbproduct.Text & "'"
            GMod.DataSetRet(sql, "param")

            cmbunit.Text = GMod.ds.Tables("param").Rows(0)("unit")
            txtrate.Text = GMod.ds.Tables("param").Rows(0)("rate").ToString

            If GMod.ds.Tables("param").Rows(0)("Basic_Ex_Per") > 0 Then txtbasicexciseper.Text = GMod.ds.Tables("param").Rows(0)("Basic_Ex_Per") Else txtbasicexciseper.Text = ""
            If GMod.ds.Tables("param").Rows(0)("Edu_Per") > 0 Then txtedusesper.Text = GMod.ds.Tables("param").Rows(0)("Edu_Per") Else txtedusesper.Text = ""
            If GMod.ds.Tables("param").Rows(0)("Hs_Per") > 0 Then txthrsesper.Text = GMod.ds.Tables("param").Rows(0)("Hs_Per") Else txthrsesper.Text = ""

            If GMod.ds.Tables("param").Rows(0)("VAT_Per") > 0 Then txtvatper.Text = GMod.ds.Tables("param").Rows(0)("VAT_Per") Else txtvatper.Text = ""
            If GMod.ds.Tables("param").Rows(0)("CST_per") > 0 Then txtcstper.Text = GMod.ds.Tables("param").Rows(0)("CST_per") Else txtcstper.Text = ""

            lblExciseNo.Text = GMod.ds.Tables("param").Rows(0)("Excise_No").ToString

            'Adding Condition for Vat as Cst 
            ' If cmbState.Text.ToUpper = "MADHYA PRADESH"  Then
            If cmbState.Text.ToUpper = "MADHYA PRADESH" Then
                txtcstper.Text = "0"
                txtcstval.Text = "0"
                txtcstper.Enabled = False
                txtcstval.Enabled = False

                txtvatper.Enabled = True
                txtvatval.Enabled = True
            Else
                txtvatper.Text = "0"
                txtvatper.Text = "0"
                txtbasicexciseper.Text = "0"
                txtcstper.Enabled = True
                txtcstval.Enabled = True

                txtvatper.Enabled = False
                txtvatval.Enabled = False
            End If
        Catch ex As Exception

        End Try

        ' sql = "select * from ItemVsAccCode where cmp_id='" & GMod.Cmpid & "' and acccode='" & cmbcode.Text & "'  AND ITEMNAME = '" & cmbproduct.Text & "'"
        ' GMod.DataSetRet(sql, "Product")


        'txtDocDis.Text = GMod.ds.Tables("Product").Rows(0)("dESCRP")
        'cmbDesc.DisplayMember = "Descrp"
        '
        'txtDocDis.Text = cmbDesc.Text

    End Sub

    Private Sub cmbproduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproduct.SelectedIndexChanged
        Try
            Dim a() As String
            a = cmbproduct.Text.Split("#")
            txtDocDis.Text = a(1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtpacking_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpacking.Enter
        If lblExciseNo.Text = "Excise No" Then
            cmbproduct_Leave(sender, e)
        End If
    End Sub

    Private Sub txtpacking_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpacking.TextChanged

        txtqty.Text = Val(txtavgcontent.Text) * Val(txtpacking.Text)
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        If RadioButton1.Checked = True Then
            txtamt.Text = Math.Round(Val(txtqty.Text) * Val(txtrate.Text))
        End If
    End Sub

    Private Sub txtrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrate.TextChanged
        If RadioButton1.Checked = True Then
            txtamt.Text = Math.Round(Val(txtqty.Text) * Val(txtrate.Text), 0)
        ElseIf RadioButton2.Checked = True Then
            txtamt.Text = Math.Round(Val(txtqty.Text) * Val(txtrate.Text), 0)
        End If
    End Sub
    Public Sub totalamount()
        Try
            txttotalval.Text = Val(txtamt.Text) + Val(txttotalexcise.Text) + Val(txtvatval.Text) + Val(txtcstval.Text) + Val(txtSurVal.Text)
            Dim a() As String
            a = txttotalval.Text.Split(".")
            If a.Length >= 2 Then
                txtdisamt.Text = "." & a(1)
                txtnetamt.Text = Math.Round(Val(txttotalval.Text), 0, MidpointRounding.ToEven) + Val(txtfrieght.Text)
                'If cmbisinsured.Text = "Yes" Then
                '    txtinsamt.Text = txtnetamt.Text
                'Else
                '    txtinsamt.Text = "0"
                'End If
            Else
                txtnetamt.Text = Math.Round(Val(txttotalval.Text), 0, MidpointRounding.ToEven) + Val(txtfrieght.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamt.TextChanged
        If RadioButton1.Checked = True Then
            txtAfterDiscount.Text = Val(txtamt.Text) - Val(txtdisper.Text)
            txtbasicecciseval.Text = Math.Round(Val(txtAfterDiscount.Text) * Val((Val(txtbasicexciseper.Text) / 100)), 0)
            TotalExciseVAl()
            AmountWithEcise()
            totalamount()
        ElseIf RadioButton2.Checked = True Then
            txtAfterDiscount.Text = Val(txtamt.Text) - Val(txtdisper.Text)
            txtbasicecciseval.Text = Math.Round(Val(txtAfterDiscount.Text) * Val((Val(txtbasicexciseper.Text) / 100)), 0)

        End If
    End Sub
    Public Sub TotalExciseVAl()
        If RadioButton1.Checked = True Then
            txttotalexcise.Text = Val(txtbasicecciseval.Text) + Val(txtedusesval.Text) + Val(txthrsesval.Text)
        End If
    End Sub
    Public Sub AmountWithEcise()
        If RadioButton1.Checked = True Then
            txtamtexcise.Text = Math.Round(Val(txtamt.Text) + Val(txttotalexcise.Text))
        End If
    End Sub
    Private Sub txtedusesper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtedusesper.TextChanged
        If RadioButton1.Checked = True Then
            txtedusesval.Text = Math.Round(Val(txtbasicecciseval.Text) * (Val(txtedusesper.Text) / 100))
            TotalExciseVAl()
            AmountWithEcise()
            totalamount()
            If RadioButton2.Checked = True Then

            End If
        End If
    End Sub
    Dim sqlstr As String, document As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtinvoiceno.Text = "" Then
            sql = "select isnull(max(right(invoice_no,6)),0) + 1 invno from sale_inv  where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "invno")
            txtinvoiceno.Text = Format(ds.Tables("invno").Rows(0)(0), "0000")
        End If

        Dim prdCount As Integer = 0
        document = ""
        For prdCount = 0 To dgitem.Rows.Count - 1
            document = document & Chr(13) & dgitem(30, prdCount).Value.ToString
        Next

        For prdCount = 0 To dgitem.Rows.Count - 1

            sqlstr = "insert  Sale_Inv(Cmp_id, inv_type, invoice_no, " & _
            "invoice_date, Acc_code, challanno, challan_date, issue_date_time, " & _
            "removal_date_time, Order_no, order_date, Item_name, batch_no, bag_from," & _
            "bag_to, Excise_no, avg_content, no_of_pack, qty, unit, rate, total_val," & _
             "basic_excise_per, basic_excise_val, edu_per, edu_val, hs_per, hs_val," & _
             "cst_per, cst_val, vat_per, vat_val, oth1_per, oth1_val, oth2_per, oth2_val," & _
            "surcharge_per, surcharge_val, freight_invoice, transporter, lorry_no, lr_no," & _
            "lr_date, Document,  Uname, discount_per, discount_amt, Net_amt," & _
            "sale_form, Session,Remark11) values ("
            If prdCount > 1 Then
                lblGrandTotal.Text = 0
            End If

            sqlstr &= "'" & GMod.Cmpid & "',"
            sqlstr &= "'" & Vtype & "',"
            sqlstr &= "'" & txtinvoiceno.Text & "',"
            sqlstr &= "'" & dtinvdate.Value.ToShortDateString & "',"
            sqlstr &= "'" & cmbcode.Text & "',"
            sqlstr &= "'" & txtChallano.Text & "',"
            sqlstr &= "'" & dtpChallanDate.Value.ToShortDateString & "',"
            sqlstr &= "'" & dtpIssue.Value & "',"
            sqlstr &= "'" & dtpRemoval.Value & "',"

            sqlstr &= "'" & txtcustrefno.Text & "',"
            sqlstr &= "'" & dtpcustOrdRefDt.Value.ToShortDateString & "',"

            sqlstr &= "'" & dgitem(0, prdCount).Value.ToString & "',"
            sqlstr &= "'" & dgitem(1, prdCount).Value.ToString & "',"
            sqlstr &= "'" & dgitem(8, prdCount).Value.ToString & "',"
            sqlstr &= "'" & dgitem(9, prdCount).Value.ToString & "',"
            sqlstr &= "'" & dgitem(25, prdCount).Value.ToString & "',"
            sqlstr &= "'" & Val(dgitem(2, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(3, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(4, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & dgitem(5, prdCount).Value.ToString & "',"
            sqlstr &= "'" & Val(dgitem(6, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(7, prdCount).Value.ToString) & "',"

            sqlstr &= "'" & Val(dgitem(10, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(11, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(12, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(13, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(14, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(15, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(18, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(19, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(20, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(21, prdCount).Value.ToString) & "',"
            sqlstr &= "'0',"
            sqlstr &= "'0',"
            sqlstr &= "'0',"
            sqlstr &= "'0',"
            sqlstr &= "'0',"
            sqlstr &= "'0',"
            sqlstr &= "'" & Val(dgitem(29, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & cmbCarrier.Text & "',"
            sqlstr &= "'" & txtLorry.Text & "',"
            sqlstr &= "'" & txtLr.Text & "',"
            sqlstr &= "'" & dtpLrDt.Value.ToShortDateString & "',"
            sqlstr &= "'" & dgitem(30, prdCount).Value.ToString & "',"
            sqlstr &= "'" & GMod.username & "',"
            sqlstr &= "'" & Val(dgitem(26, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(dgitem(27, prdCount).Value.ToString) & "',"
            sqlstr &= "'" & Val(lblGrandTotal.Text) & "',"
            sqlstr &= "'" & cmbsaleform.Text & "',"
            sqlstr &= "'" & GMod.Session & "',"
            sqlstr &= "'" & txtrem1.Text & "')"
            GMod.SqlExecuteNonQuery(sqlstr)
        Next
        MsgBox("Sale Invoice Sucessfully Saved", MsgBoxStyle.Information)
        btnReset_Click(sender, e)
        cmbVouchertype_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub ClearControls(ByVal topControl As Control)
        ' Ignore the control unless it is a textbox.
        If TypeOf topControl Is TextBox Then
            topControl.Text = ""
        Else
            ' Process controls recursively.
            ' This is required if controls contain other controls
            ' (for example, if you use panels, group boxes, or other
            ' container controls).
            For Each childControl As Control In topControl.Controls
                ClearControls(childControl)
            Next
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearControls(Me)
        dtinvdate.Focus()
        dgitem.Rows.Clear()
        fillGrid()
        grp1.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        btnSave.Enabled = True
        btnModify.Text = "&Modify"
        'cmbVouchertype.SelectedIndex = 0
        cmbcode.SelectedIndex = 0
        'cmbproduct.SelectedIndex = 0
    End Sub
    Sub fillGrid()
        sqlstr = "select distinct inv_type,invoice_no,s.Acc_code,Acc_name,Net_amt from  Sale_Inv s " & _
        " inner join Acc_Head a on s.Acc_code=a.acc_code and s.cmp_id=a.cmp_id where   S.cmp_id='" & GMod.Cmpid & "' and S.session = '" & GMod.Session & "' and inv_type='" & Vtype & "'" ' order by cast(invoice_no as bigint) desc"
        GMod.DataSetRet(sqlstr, "saledata")
        dg.DataSource = GMod.ds.Tables("saledata")
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
       
    End Sub

    Private Sub cmbParty_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbParty.Leave
        cmbproduct.Focus()
        Try


            If cmbParty.Text = "" Then
                MsgBox("Please Select Correct Head", MsgBoxStyle.Information)
                cmbParty.Focus()
                Exit Sub
            End If
            If cmbParty.FindStringExact(cmbParty.Text) = -1 Then
                MsgBox("Please Select Correct Head", MsgBoxStyle.Information)
                cmbParty.Focus()
                Exit Sub
            End If
            Dim sql As String
            sql = "select * ,itemname  xx  from ItemMaster where cmp_id='" & GMod.Cmpid & "'" ' and acccode='" & cmbcode.Text & "' "
            GMod.DataSetRet(sql, "Product")

            cmbproduct.DataSource = GMod.ds.Tables("Product")
            cmbproduct.DisplayMember = "xx"

            cmbDesc.DataSource = GMod.ds.Tables("Product")
            cmbDesc.DisplayMember = "Descrp"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private i As Integer = -1
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If lblExciseNo.Text = "Excise No" Then
            MsgBox("Please Select a Product ", MsgBoxStyle.Exclamation)
            cmbproduct.Focus()
            'Exit Sub
        End If
        If txtqty.Text = "" Then
            MsgBox("Quantity Cann't Be Blank", MsgBoxStyle.Exclamation)
            txtqty.Focus()
            Exit Sub
        End If

        If txtpacking.Text = "" Then
            ' MsgBox("No of Package Cann't Be Blank", MsgBoxStyle.Exclamation)
            'txtpacking.Focus()
            'Exit Sub
        End If
        If cmbproduct.Text = "" Then
            'cmbproduct.Focus()
            MsgBox("Please Select A Product")
            Exit Sub
        End If
        ' Dim c() As String
        'c = cmbproduct.Text
        Dim obj() As Object = {cmbproduct.Text, txtBatchno.Text, Val(txtavgcontent.Text), Val(txtpacking.Text), Val(txtqty.Text), cmbunit.Text, Val(txtrate.Text), Val(txtamt.Text), txtsrnofrom.Text, txtsrnoto.Text, txtbasicexciseper.Text, txtbasicecciseval.Text, txtedusesper.Text, txtedusesval.Text, txthrsesper.Text, txthrsesval.Text, txttotalexcise.Text, txtamtexcise.Text, txtcstper.Text, txtcstval.Text, txtvatper.Text, txtvatval.Text, txtSurPer.Text, txtSurVal.Text, txttotalval.Text, lblExciseNo.Text, txtdisper.Text, txtdisamt.Text, txtnetamt.Text, txtfrieght.Text, txtDocDis.Text.ToUpper()}
        If i <> -1 Then
            dgitem.Rows.RemoveAt(i)
            dgitem.Rows.Insert(i, obj)
        Else
            dgitem.Rows.Add(obj)
        End If
        i = -1
        If MessageBox.Show("Want to Add More", "Add More", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmbproduct.Focus()
        Else
            If btnSave.Enabled = True Then
                btnSave.Focus()
            Else
                btnModify.Focus()
            End If

        End If
        ClearControlEx()
    End Sub
    Public Sub ClearControlEx()
        cmbproduct.Text = ""
        cmbmobatch.Text = ""
        txtBatchno.Text = ""
        'txtavgcontent.Text = ""
        txtpacking.Text = ""
        txtqty.Text = ""
        'cmbunit.Text = ""
        txtrate.Text = ""
        txtamt.Text = ""
        txtsrnofrom.Text = ""
        txtsrnoto.Text = ""
        txtbasicexciseper.Text = ""
        txtbasicecciseval.Text = ""
        txtedusesper.Text = ""
        txtedusesval.Text = ""
        txthrsesper.Text = ""
        txthrsesval.Text = ""
        txttotalexcise.Text = ""
        txtamtexcise.Text = ""
        txtcstper.Text = ""
        txtcstval.Text = ""
        txtvatper.Text = ""
        txtvatval.Text = ""
        txtSurPer.Text = ""
        txtSurVal.Text = ""
        txttotalval.Text = ""
        lblExciseNo.Text = ""
        txtdisper.Text = ""
        txtdisamt.Text = ""
        txtnetamt.Text = ""
        txtfrieght.Text = ""

    End Sub

    Private Sub dgitem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgitem.CellContentClick

    End Sub

    Private Sub txttotalval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotalval.TextChanged

    End Sub

    Private Sub txtfrieght_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfrieght.TextChanged
        totalamount()
    End Sub

    Private Sub btnAdd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Leave
        Dim k As Integer
        Dim gndtotal As Double = 0
        For k = 0 To dgitem.Rows.Count - 1
            gndtotal = gndtotal + Val(dgitem(28, k).Value.ToString)
        Next
        lblGrandTotal.Text = gndtotal
    End Sub
    Private Sub txtbasicecciseval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbasicecciseval.TextChanged
        If RadioButton1.Checked = True Then
            txtedusesval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txtedusesper.Text) / 100))
            txthrsesval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txthrsesper.Text) / 100))
            TotalExciseVAl()
        ElseIf RadioButton2.Checked = True Then
            txtedusesval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txtedusesper.Text) / 100))
            txthrsesval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txthrsesper.Text) / 100))

            txtcstval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txtcstper.Text) / 100))
            txtvatval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txtvatper.Text) / 100))

        End If
    End Sub

    Private Sub txtamtexcise_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamtexcise.TextChanged
        If RadioButton1.Checked = True Then
            txtcstval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txtcstper.Text) / 100))
            txtvatval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txtvatper.Text) / 100))
            TotalExciseVAl()
            AmountWithEcise()
            totalamount()
        Else
            txtcstval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txtcstper.Text) / 100))
            txtvatval.Text = Math.Round(Val(txtAfterDiscount.Text) * (Val(txtvatper.Text) / 100))

        End If
    End Sub
    Private Sub dtpIssue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpIssue.ValueChanged
        'dtinvdate.Value = dtpIssue.Value
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        If btnModify.Text = "&Update" Then
            Dim trans As SqlTransaction
            trans = GMod.SqlConn.BeginTransaction()
            Try
                sql = "delete from Sale_Inv where invoice_no='" & txtinvoiceno.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and inv_type =" & Vtype & "'"
                Dim cmd1 As New SqlCommand(sql, GMod.SqlConn, trans)
                cmd1.ExecuteNonQuery()

                Dim prdCount As Integer = 0
                document = ""
                For prdCount = 0 To dgitem.Rows.Count - 1
                    document = document & Chr(13) & dgitem(30, prdCount).Value.ToString
                Next

                For prdCount = 0 To dgitem.Rows.Count - 1
                    sqlstr = "insert  Sale_Inv (Cmp_id, inv_type, invoice_no, " & _
                    "invoice_date, Acc_code, challanno, challan_date, issue_date_time, " & _
                    "removal_date_time, Order_no, order_date, Item_name, batch_no, bag_from," & _
                    "bag_to, Excise_no, avg_content, no_of_pack, qty, unit, rate, total_val," & _
                     "basic_excise_per, basic_excise_val, edu_per, edu_val, hs_per, hs_val," & _
                     "cst_per, cst_val, vat_per, vat_val, oth1_per, oth1_val, oth2_per, oth2_val," & _
                    "surcharge_per, surcharge_val, freight_invoice, transporter, lorry_no, lr_no," & _
                    "lr_date, Document,  Uname, discount_per, discount_amt, Net_amt," & _
                    "sale_form, Session,Remark11) values ("
                    sqlstr &= "'" & GMod.Cmpid & "',"
                    sqlstr &= "'" & cmbVouchertype.Text & "',"
                    sqlstr &= "'" & txtinvoiceno.Text & "',"
                    sqlstr &= "'" & dtinvdate.Value.ToShortDateString & "',"
                    sqlstr &= "'" & cmbcode.Text & "',"
                    sqlstr &= "'" & txtChallano.Text & "',"
                    sqlstr &= "'" & dtpChallanDate.Value.ToShortDateString & "',"
                    sqlstr &= "'" & dtpIssue.Value & "',"
                    sqlstr &= "'" & dtpRemoval.Value & "',"

                    sqlstr &= "'" & txtcustrefno.Text & "',"
                    sqlstr &= "'" & dtpcustOrdRefDt.Value.ToShortDateString & "',"

                    sqlstr &= "'" & dgitem(0, prdCount).Value.ToString & "',"
                    sqlstr &= "'" & dgitem(1, prdCount).Value.ToString & "',"
                    sqlstr &= "'" & dgitem(8, prdCount).Value.ToString & "',"
                    sqlstr &= "'" & dgitem(9, prdCount).Value.ToString & "',"
                    sqlstr &= "'" & dgitem(25, prdCount).Value.ToString & "',"
                    sqlstr &= "'" & Val(dgitem(2, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(3, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(4, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & dgitem(5, prdCount).Value.ToString & "',"
                    sqlstr &= "'" & Val(dgitem(6, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(7, prdCount).Value.ToString) & "',"

                    sqlstr &= "'" & Val(dgitem(10, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(11, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(12, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(13, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(14, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(15, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(18, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(19, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(20, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(21, prdCount).Value.ToString) & "',"
                    sqlstr &= "'0',"
                    sqlstr &= "'0',"
                    sqlstr &= "'0',"
                    sqlstr &= "'0',"
                    sqlstr &= "'0',"
                    sqlstr &= "'0',"
                    sqlstr &= "'" & Val(dgitem(29, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & cmbCarrier.Text & "',"
                    sqlstr &= "'" & txtLorry.Text & "',"
                    sqlstr &= "'" & txtLr.Text & "',"
                    sqlstr &= "'" & dtpLrDt.Value.ToShortDateString & "',"
                    sqlstr &= "'" & document & "',"
                    sqlstr &= "'" & GMod.username & "',"
                    sqlstr &= "'" & Val(dgitem(26, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(dgitem(27, prdCount).Value.ToString) & "',"
                    sqlstr &= "'" & Val(lblGrandTotal.Text) & "',"
                    sqlstr &= "'" & cmbsaleform.Text & "',"
                    sqlstr &= "'" & GMod.Session & "',"
                    sqlstr &= "'" & txtrem1.Text & "')"
                    Dim cmd2 As New SqlCommand(sqlstr, GMod.SqlConn, trans)
                    cmd2.ExecuteNonQuery()
                Next
                trans.Commit()
                MsgBox("Sale Invoice Sucessfully Saved", MsgBoxStyle.Information)

            Catch ex As Exception
                trans.Rollback()
                btnReset_Click(sender, e)
                MsgBox(ex.Message)
            End Try
            trans = Nothing
        End If
        btnReset_Click(sender, e)
        cmbVouchertype_SelectedIndexChanged(sender, e)

    End Sub
    Private Sub dg_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellDoubleClick
        Dim invno As String = ""
        Dim totexcise As Double = 0
        Dim amtplusexcise As Double = 0
        Dim total As Double = 0
        Dim rec As Integer = 0
        ' If btnModify.Text = "&Modify" Then
        sql = "select * from SalInv where invoice_no='" & dg(1, dg.CurrentCell.RowIndex).Value.ToString & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and inv_type ='" & Vtype & "'"
        GMod.DataSetRet(sql, "sinv_modi")
        If GMod.ds.Tables("sinv_modi").Rows.Count > 0 Then
            cmbVouchertype.Text = GMod.ds.Tables("sinv_modi").Rows(0)("inv_type")
            txtinvoiceno.Text = GMod.ds.Tables("sinv_modi").Rows(0)("invoice_no")
            dtinvdate.Value = CDate(GMod.ds.Tables("sinv_modi").Rows(0)("invoice_date"))
            cmbcode.Text = GMod.ds.Tables("sinv_modi").Rows(0)("Acc_code")
            txtChallano.Text = GMod.ds.Tables("sinv_modi").Rows(0)("challanno")
            dtpChallanDate.Value = CDate(GMod.ds.Tables("sinv_modi").Rows(0)("challan_date"))
            dtpIssue.Value = Convert.ToDateTime(GMod.ds.Tables("sinv_modi").Rows(0)("issue_date_time"))
            dtpRemoval.Value = Convert.ToDateTime(GMod.ds.Tables("sinv_modi").Rows(0)("removal_date_time"))
            txtcustrefno.Text = GMod.ds.Tables("sinv_modi").Rows(0)("Order_no")
            dtpcustOrdRefDt.Value = CDate(GMod.ds.Tables("sinv_modi").Rows(0)("order_date"))
            cmbCarrier.Text = GMod.ds.Tables("sinv_modi").Rows(0)("transporter")
            txtLorry.Text = GMod.ds.Tables("sinv_modi").Rows(0)("lorry_no")
            txtLr.Text = GMod.ds.Tables("sinv_modi").Rows(0)("lorry_no")
            dtpLrDt.Value = CDate(GMod.ds.Tables("sinv_modi").Rows(0)("lr_date"))
            'txtDocDis.Text = GMod.ds.Tables("sinv_modi").Rows(0)("Document")
            txtrem1.Text = GMod.ds.Tables("sinv_modi").Rows(0)("Remark11")
            dgitem.Rows.Clear()
            For rec = 0 To GMod.ds.Tables("sinv_modi").Rows.Count - 1
                dgitem.Rows.Add()
                dgitem(0, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("Item_name") '0
                dgitem(1, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("batch_no") '1
                dgitem(2, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("avg_content") '2
                dgitem(3, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("no_of_pack") '3
                dgitem(4, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("qty") '4
                dgitem(5, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("unit") '5
                dgitem(6, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("rate") '6
                dgitem(7, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("total_val") '7
                dgitem(8, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("bag_from") '8
                dgitem(9, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("bag_to") '9
                dgitem(10, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("basic_excise_per") '10
                dgitem(11, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("basic_excise_val") '11
                dgitem(12, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("edu_per") '12
                dgitem(13, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("edu_val") '13
                dgitem(14, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("hs_per") '14
                dgitem(15, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("hs_val") '15 
                totexcise = Val(dgitem(11, rec).Value) + Val(dgitem(13, rec).Value) + Val(dgitem(15, rec).Value)
                dgitem(16, rec).Value = totexcise '16
                amtplusexcise = totexcise + Val(dgitem(7, rec).Value)
                dgitem(17, rec).Value = amtplusexcise '17
                dgitem(18, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("cst_per") '18
                dgitem(19, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("cst_val") '19
                dgitem(20, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("vat_per") '20
                dgitem(21, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("vat_val") '21
                dgitem(22, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("surcharge_per") '22
                dgitem(23, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("surcharge_val") '23
                total = amtplusexcise + Val(dgitem(19, rec).Value) + Val(dgitem(21, rec).Value) + Val(dgitem(23, rec).Value)
                dgitem(24, rec).Value = total '24
                dgitem(25, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("Excise_no") '25
                dgitem(26, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("discount_per") '26
                dgitem(27, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("discount_amt") '27
                dgitem(28, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("Net_amt") '28
                dgitem(29, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("freight_invoice") '29  
                dgitem(30, rec).Value = GMod.ds.Tables("sinv_modi").Rows(rec)("Document") '30  
            Next
        End If
        btnSave.Enabled = False
        btnModify.Text = "&Update"
        'Else 'btn if 

        'End If
    End Sub

    Private Sub btnSave_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Enter
        Dim k As Integer
        Dim gndtotal As Double = 0
        For k = 0 To dgitem.Rows.Count - 1
            gndtotal = gndtotal + Val(dgitem(28, k).Value.ToString)
        Next
        lblGrandTotal.Text = gndtotal
    End Sub

    Private Sub btnModify_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModify.Enter
        If btnModify.Text = "&Update" Then
            Dim k As Integer
            Dim gndtotal As Double = 0
            For k = 0 To dgitem.Rows.Count - 1
                gndtotal = gndtotal + Val(dgitem(28, k).Value.ToString)
            Next
            lblGrandTotal.Text = gndtotal
        End If
    End Sub

    Private Sub dgitem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgitem.CellDoubleClick
        ' Dim obj() As Object = {cmbproduct.Text, txtBatchno.Text,
        ' Val(txtavgcontent.Text), Val(txtpacking.Text), Val(txtqty.Text), 
        'cmbunit.Text, Val(txtrate.Text), Val(txtamt.Text), txtsrnofrom.Text, txtsrnoto.Text,
        ' txtbasicexciseper.Text, txtbasicecciseval.Text, txtedusesper.Text, 
        'txtedusesval.Text, txthrsesper.Text, txthrsesval.Text, txttotalexcise.Text, 
        'txtamtexcise.Text, txtcstper.Text, txtcstval.Text, txtvatper.Text, txtvatval.Text,
        ' txtSurPer.Text, txtSurVal.Text, txttotalval.Text, lblExciseNo.Text, txtdisper.Text, txtdisamt.Text,
        ' txtnetamt.Text, txtfrieght.Text}
        Try
            i = e.RowIndex
            Dim rInx As Integer = dgitem.CurrentCell.RowIndex
            rInx = i
            cmbproduct.Text = dgitem(0, rInx).Value
            txtDocDis.Text = dgitem(30, rInx).Value

            txtBatchno.Text = dgitem(1, rInx).Value
            txtavgcontent.Text = dgitem(2, rInx).Value
            txtpacking.Text = dgitem(3, rInx).Value
            txtqty.Text = dgitem(4, rInx).Value
            cmbunit.Text = dgitem(5, rInx).Value
            txtrate.Text = dgitem(6, rInx).Value
            txtamt.Text = dgitem(7, rInx).Value
            txtsrnofrom.Text = dgitem(8, rInx).Value
            txtsrnoto.Text = dgitem(9, rInx).Value
            txtbasicexciseper.Text = dgitem(10, rInx).Value
            txtbasicecciseval.Text = dgitem(11, rInx).Value
            txtedusesper.Text = dgitem(12, rInx).Value
            txtedusesval.Text = dgitem(13, rInx).Value
            txthrsesper.Text = dgitem(14, rInx).Value
            txthrsesval.Text = dgitem(15, rInx).Value
            txttotalexcise.Text = dgitem(16, rInx).Value
            txtamtexcise.Text = dgitem(17, rInx).Value
            txtcstper.Text = dgitem(18, rInx).Value
            txtcstval.Text = dgitem(19, rInx).Value
            txtvatper.Text = dgitem(20, rInx).Value
            txtvatval.Text = dgitem(21, rInx).Value
            txtSurPer.Text = dgitem(22, rInx).Value
            txtSurVal.Text = dgitem(23, rInx).Value
            txttotalval.Text = dgitem(24, rInx).Value
            lblExciseNo.Text = dgitem(25, rInx).Value
            txtdisper.Text = dgitem(26, rInx).Value
            txtdisamt.Text = dgitem(27, rInx).Value
            txtfrieght.Text = dgitem(29, rInx).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtavgcontent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtavgcontent.TextChanged
        'If btnModify.Text = "&Update" Then
        txtqty.Text = Val(txtavgcontent.Text) * Val(txtpacking.Text)
        'Else

        'End If
    End Sub


    Private Sub txtDocDis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocDis.TextChanged

    End Sub

    Private Sub cmbDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDesc.SelectedIndexChanged
        'txtdisper.Text = cmbDesc.Text
    End Sub

    Private Sub cmbParty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbParty.SelectedIndexChanged

    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are u Sure?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            sql = "delete from Sale_Inv where invoice_no='" & txtinvoiceno.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
            MsgBox(GMod.SqlExecuteNonQuery(sql))
            MsgBox("Invoice Deleted", MsgBoxStyle.Information)
            fillGrid()
            Me.Close()
        End If
    End Sub

    Private Sub txtvatper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvatper.TextChanged

    End Sub

    Private Sub Chklock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chklock.CheckedChanged

        If Chklock.Checked = True Then
            txtinvoiceno.ReadOnly = False
            txtinvoiceno.Text = 0
        Else
            cmbVouchertype_SelectedIndexChanged(sender, e)
        End If

    End Sub

    Private Sub txtinvoiceno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinvoiceno.Leave
        Try


            If txtinvoiceno.Text.Length <> 4 Then
                MsgBox("Please Enter Correct Format", MsgBoxStyle.Critical)
                txtinvoiceno.Focus()
                Exit Sub
            End If


            sql = "select * from Sale_Inv where cast(invoice_no as numeric(18)) ='" & txtinvoiceno.Text & "' and cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'"
            GMod.DataSetRet(sql, "chkinvno")

            If GMod.ds.Tables("chkinvno").Rows.Count > 0 Then
                MsgBox("This Invoice No Already Present", MsgBoxStyle.Exclamation)
                cmbVouchertype_SelectedIndexChanged(sender, e)
                txtinvoiceno.ReadOnly = True
                Chklock.Checked = False
                dtinvdate.Focus()
            Else

            End If


            sql = "select max( cast(invoice_no as numeric(18)))  from Sale_Inv where cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'"
            GMod.DataSetRet(sql, "chkinvnogrter")

            'If Val(txtinvoiceno.Text) > Val(GMod.ds.Tables("chkinvnogrter").Rows(0)(0)) Then
            '    MsgBox("You are trying to enter Gretere Invoice No. ", MsgBoxStyle.Critical)
            '    Me.Close()
            '    txtinvoiceno.Focus()
            '    Exit Sub
            'End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtinvoiceno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinvoiceno.TextChanged

    End Sub

    Private Sub txtdisper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdisper.TextChanged
        'txtrate_TextChanged(sender, e)
        'txtamt.Text = Val(txtamt.Text) - Val(txtdisper.Text)

        txtAfterDiscount.Text = Val(txtamt.Text) - Val(txtdisper.Text)
        txtbasicecciseval.Text = Math.Round(Val(txtAfterDiscount.Text) * Val((Val(txtbasicexciseper.Text) / 100)))
        TotalExciseVAl()
        AmountWithEcise()
        totalamount()
    End Sub

    Private Sub txtcstper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcstper.TextChanged

    End Sub

    Private Sub txtcstval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcstval.TextChanged

    End Sub

    Private Sub dtinvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtinvdate.ValueChanged

    End Sub

    Private Sub lblHeading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub txtTIN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTIN.TextChanged

    End Sub

    Private Sub txtbasicexciseper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbasicexciseper.TextChanged

    End Sub

    Private Sub txtAfterDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAfterDiscount.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim t As New frmPartyaccount
        t.ShowDialog()
        frmSaleInv_Load(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t As New frmItemManagementRCM
        t.ShowDialog()
        Dim sql As String
        sql = "select * ,itemname  xx  from ItemMaster where cmp_id='" & GMod.Cmpid & "'" ' and acccode='" & cmbcode.Text & "' "
        GMod.DataSetRet(sql, "Product")

        cmbproduct.DataSource = GMod.ds.Tables("Product")
        cmbproduct.DisplayMember = "xx"

        cmbDesc.DataSource = GMod.ds.Tables("Product")
        cmbDesc.DisplayMember = "Descrp"

        cmbproduct.Focus()
    End Sub

    Private Sub txtnetamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnetamt.TextChanged
        Dim a, b, c As Double
        If RadioButton2.Checked = True Then
            txtnetamt.Enabled = True
            a = Val(txtbasicexciseper.Text) + Val(txtvatper.Text)
            a = a + 100
            b = a / 100
            txtrate.Text = Math.Round(Val(txtnetamt.Text) / b, 0)
        End If
    End Sub

    Private Sub txtvatval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvatval.TextChanged

    End Sub
End Class