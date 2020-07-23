Public Class frmItemManagementRCM
    Private Sub TransparentControls(ByVal topControl As Control)
        ' Ignore the control unless it is a textbox.
        If TypeOf topControl Is GroupBox Or TypeOf topControl Is Panel Or TypeOf topControl Is TabControl Then
            topControl.BackColor = Color.Transparent
        Else
            ' Process controls recursively.
            ' This is required if controls contain other controls
            ' (for example, if you use panels, group boxes, or other
            ' container controls).
            For Each childControl As Control In topControl.Controls
                TransparentControls(childControl)
            Next
        End If
    End Sub

    Private Sub ClearControls(ByVal topControl As Control)
        ' Ignore the control unless it is a textbox.
        If TypeOf topControl Is TextBox Or TypeOf topControl Is ComboBox Then
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

    Private Sub frmDataEntry_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter And Not (e.Alt Or e.Control) Then
            If Me.ActiveControl.GetType Is GetType(TextBox) Or Me.ActiveControl.GetType Is GetType(CheckBox) Or Me.ActiveControl.GetType Is GetType(DateTimePicker) Or Me.ActiveControl.GetType Is GetType(ComboBox) Then
                If e.Shift Then
                    Me.ProcessTabKey(False)
                Else
                    Me.ProcessTabKey(True)
                End If
            End If
        End If
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        'If GMod.role <> "Admin" Then
        '    MsgBox("You dont have sufficient Privileges to Modify the data", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        If btnModify.Text = "&Update" Then
            'validation

            If txtItemName.Text = "" Then
                MsgBox("Item Name cannot be blank.", MsgBoxStyle.Critical)
                txtItemName.Focus()
                Exit Sub
            End If

            
            If cmbItemType.Text = "" Then
                MsgBox("Select Item type.", MsgBoxStyle.Critical)
                cmbItemType.Focus()
                Exit Sub
            End If

           
            If txtExciseNo.Text = "" Then
                MsgBox("Enter Excise No..", MsgBoxStyle.Critical)
                txtExciseNo.Focus()
                Exit Sub
            End If
            If txtRate.Text = "" Then
                MsgBox("Enter Rate..", MsgBoxStyle.Critical)
                txtRate.Focus()
                ' Exit Sub
            End If
            'Update Query
            Dim QueryStr As String = "UPDATE ItemMasterRCM SET "
            QueryStr &= "Cmp_ID='" & GMod.Cmpid & "', "
            QueryStr &= "ItemName='" & txtItemName.Text.ToUpper.Trim & "', "
            QueryStr &= "ItemCategory='" & cmbItemCategory.Text.ToUpper.Trim & "', "
            QueryStr &= "ItemType='" & cmbItemType.Text.ToUpper.Trim & "', "
            QueryStr &= "SbPage=" & txtLedgerNo.Text.Trim & ", "
            QueryStr &= "Unit='" & cmbUnit.Text.ToUpper.Trim & "', "
            QueryStr &= "Excise_No='" & txtExciseNo.Text.Trim & "', "
            QueryStr &= "Basic_Ex_Per=" & Val(txtBasicExcise.Text) & ", "
            QueryStr &= "Edu_Per=" & Val(txtEDU.Text) & ", "
            QueryStr &= "Hs_Per=" & Val(txtHS.Text) & ", "
            QueryStr &= "VAT_Per=" & Val(txtVAT.Text) & ", "
            QueryStr &= "CST_per=" & Val(txtCST.Text) & ", "
            QueryStr &= "entry_tax=" & Val(txtentrytax.Text) & ", "
            QueryStr &= "OtherTax2=" & Val(txtOther2.Text) & ", "
            QueryStr &= "Rate=" & Val(txtRate.Text) & ", "
            QueryStr &= "sur_per=" & Val(txtSurcharge.Text) & ", "
            QueryStr &= "UserName='" & GMod.username & "', "
            QueryStr &= "SubHeadingNo='" & txtSubHeadingNo.Text & "', "
            QueryStr &= "prdgrp='" & cmbprdgrp.Text & "', "
            QueryStr &= "prdsfix='" & txtprdsuffix.Text & "', "
            QueryStr &= "othref='" & txtprdothref.Text & "', "
            QueryStr &= "ac_no='" & txtAcNo.Text & "', "
            QueryStr &= "ac_name='" & txtAcName.Text & "', "
            QueryStr &= "cost_code='" & txtCostCode.Text & "', "
            QueryStr &= "cost_name='" & txtCostName.Text & "', "
            QueryStr &= "live_type='" & cmblivetype.Text & "', "
            QueryStr &= "EntryDate='" & Format(Now.Date, "MM/dd/yy") & "',stock=" & Val(txtopeningstock.Text) & " Where ItemName='" & Label1.Text.ToUpper & "' AND CMP_ID='" & GMod.Cmpid & "'"

            Dim s As String = GMod.SqlExecuteNonQuery(QueryStr)
            If s = "SUCCESS" Then
                MsgBox("Item Information Updated.", MsgBoxStyle.Information)
            Else
                MsgBox(s)
            End If
        Else
            MsgBox("Select the Item to Update.", MsgBoxStyle.Exclamation)
        End If
        btnReset_Click(sender, e)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'validation
        If txtItemName.Text = "" Then
            MsgBox("Item Name cannot be blank.", MsgBoxStyle.Critical)
            txtItemName.Focus()
            Exit Sub
        End If
        If txtExciseNo.Text = "" Then
            MsgBox("Enter Excise No..", MsgBoxStyle.Critical)
            txtExciseNo.Focus()
            Exit Sub
        End If
        'If txtLedgerNo.Text = "" Then
        '    MsgBox("Enter Ledger Page No..", MsgBoxStyle.Critical)
        '    txtExciseNo.Focus()
        '    Exit Sub
        'End If
       

        'save query
        Dim QueryStr As String = "INSERT INTO ItemMasterRCM(Cmp_ID, ItemName, SubHeadingNo, ItemCategory, ItemType, SbPage, Unit, " & _
        "Excise_No, Basic_Ex_Per, Edu_Per, Hs_Per, VAT_Per, CST_per, Entry_tax, OtherTax2, UserName, EntryDate, Rate, sur_per,prdgrp,prdsfix,othref,ac_no,ac_name,cost_code,cost_name,live_type,stock) VALUES("
        QueryStr &= "'" & GMod.Cmpid & "', "
        QueryStr &= "'" & txtItemName.Text.ToUpper.Trim & "', "
        QueryStr &= "'" & txtSubHeadingNo.Text.Trim & "', "
        QueryStr &= "'" & cmbItemCategory.Text.ToUpper.Trim & "', "
        QueryStr &= "'" & cmbItemType.Text.ToUpper.Trim & "', "
        QueryStr &= Val(txtLedgerNo.Text) & ", "
        QueryStr &= "'" & cmbUnit.Text.ToUpper.Trim & "', "
        QueryStr &= "'" & txtExciseNo.Text.Trim & "', "
        QueryStr &= Val(txtBasicExcise.Text) & ", "
        QueryStr &= Val(txtEDU.Text) & ", "
        QueryStr &= Val(txtHS.Text) & ", "
        QueryStr &= Val(txtVAT.Text) & ", "
        QueryStr &= Val(txtCST.Text) & ", "
        QueryStr &= Val(txtentrytax.Text) & ", "
        QueryStr &= Val(txtOther2.Text) & ", "
        QueryStr &= "'" & GMod.username & "', "
        QueryStr &= "'" & Format(Now.Date, "MM/dd/yy") & "', "
        QueryStr &= Val(txtRate.Text) & ", "
        QueryStr &= Val(txtSurcharge.Text) & ","
        QueryStr &= "'" & cmbprdgrp.Text.ToUpper & "',"
        QueryStr &= "'" & txtprdsuffix.Text.ToUpper & "', "
        QueryStr &= "'" & txtprdothref.Text.ToUpper & "', "
        QueryStr &= "'" & txtAcNo.Text & "', "
        QueryStr &= "'" & txtAcName.Text & "', "
        QueryStr &= "'" & txtCostCode.Text & "', "
        QueryStr &= "'" & txtCostName.Text & "','" & cmblivetype.Text & "'," & Val(txtopeningstock.Text) & ")"

        Dim s As String = GMod.SqlExecuteNonQuery(QueryStr)

        If s = "SUCCESS" Then
            MsgBox("Item Information saved.", MsgBoxStyle.Information)
        Else
            MsgBox(s)
        End If
        btnReset_Click(sender, e)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If GMod.role <> "Admin" Then
            MsgBox("You dont have sufficient Privileges to Delete the data", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If btnModify.Text = "&Update" Then
            'validation

            If txtItemName.Text = "" Then
                MsgBox("User Name cannot be blank.", MsgBoxStyle.Critical)
                txtItemName.Focus()
                Exit Sub
            End If

            Dim querystr As String = "DELETE FROM ItemMaster WHERE ItemName='" & Label1.Text & "'"

            Dim s As String = GMod.SqlExecuteNonQuery(querystr)

            If s = "SUCCESS" Then
                MsgBox("Item Information Deleted.", MsgBoxStyle.Information)

            Else
                MsgBox(s)
            End If

        Else
            MsgBox("Select the Item to delete.", MsgBoxStyle.Exclamation)
        End If

        btnReset_Click(sender, e)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearControls(Me)
        btnSave.Enabled = True
        btnModify.Text = "&Modify"

        'GMod.DataSetRet("select ItemCategory from ItemCategory", "FillCombo1")
        'cmbItemCategory.DataSource = GMod.ds.Tables("FillCombo1")
        'cmbItemCategory.DisplayMember = "ItemCategory"

        'GMod.DataSetRet("select unit from UnitConversion", "FillCombo2")
        'cmbUnit.DataSource = GMod.ds.Tables("FillCombo2")
        'cmbUnit.DisplayMember = "unit"

        GMod.DataSetRet("select prdgrp [Product Group], prdsfix [Product Suffix], othref [Other Refences] ,ItemName [Prod. Name],stock, SubHeadingNo [Item No. Name], ItemCategory, ItemType, SbPage, Unit, Rate, Excise_No HSNNO, Basic_Ex_Per GST_Per, Edu_Per Tax1_Per, Hs_Per Tax2_Per, VAT_Per SGST_Pet , CST_per IGST_Per, entry_tax, OtherTax2,sur_per, ac_no, ac_name, cost_code, cost_name,live_type  from ItemMasterRCM WHERE cmp_id='" & GMod.Cmpid & "'", "FillGridData")
        dgvItem.DataSource = GMod.ds.Tables("FillGridData")
        txtItemName.Focus()
    End Sub

    Private Sub txtBasicExcise_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBasicExcise.KeyPress, txtEDU.KeyPress, txtHS.KeyPress, txtVAT.KeyPress, txtCST.KeyPress, txtentrytax.KeyPress, txtOther2.KeyPress, txtLedgerNo.KeyPress, txtSurcharge.KeyPress, txtRate.KeyPress, txtSurcharge.KeyPress
        'Numeric 
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub frmItemManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TransparentControls(Me)
        'GMod.DataSetRet("select ItemCategory from ItemCategory", "FillCombo1")
        'cmbItemCategory.DataSource = GMod.ds.Tables("FillCombo1")
        'cmbItemCategory.DisplayMember = "ItemCategory"

        'GMod.DataSetRet("select unit from UnitConversion", "FillCombo2")
        'cmbUnit.DataSource = GMod.ds.Tables("FillCombo2")
        'cmbUnit.DisplayMember = "unit"

        ''GMod.DataSetRet("select ItemName, SubHeadingNo, ItemCategory, ItemType, SbPage, Unit, Rate, Excise_No, Basic_Ex_Per, Edu_Per, Hs_Per, VAT_Per, CST_per, OtherTax1, OtherTax2,sur_per from ItemMaster", "FillGridDat")
        ''dgvItem.DataSource = GMod.ds.Tables("FillGridDat")


        'GMod.DataSetRet("select distinct prdgrp from ItemMaster where cmp_id='" & GMod.Cmpid & "'", "prdgrp")
        'cmbprdgrp.DataSource = GMod.ds.Tables("prdgrp")
        'cmbprdgrp.DisplayMember = "prdgrp"
        btnReset_Click(sender, e)

    End Sub

    Private Sub txtBasicExcise_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBasicExcise.TextChanged, txtEDU.TextChanged, txtHS.TextChanged, txtVAT.TextChanged, txtCST.TextChanged, txtentrytax.TextChanged, txtOther2.TextChanged, txtSurcharge.TextChanged
        If txtBasicExcise.Text <> "" Then
            If CType(txtBasicExcise.Text, Decimal) > 100.0 Then
                MsgBox("Enter as value less than 100")
                txtBasicExcise.Text = "0.00"
                txtExciseNo.Focus()
                Exit Sub
            End If
        End If
        If txtEDU.Text <> "" Then
            If CType(txtEDU.Text, Decimal) > 100.0 Then
                MsgBox("Enter as value less than 100")
                txtEDU.Text = "0.00"

                txtBasicExcise.Focus()
                Exit Sub
            End If
        End If
        If txtHS.Text <> "" Then
            If CType(txtHS.Text, Decimal) > 100.0 Then
                MsgBox("Enter as value less than 100")
                txtHS.Text = "0.00"

                txtEDU.Focus()
                Exit Sub
            End If
        End If
        If txtVAT.Text <> "" Then
            If CType(txtVAT.Text, Decimal) > 100.0 Then
                MsgBox("Enter as value less than 100")
                txtVAT.Text = "0.00"

                txtHS.Focus()
                Exit Sub
            End If

        End If
        If txtCST.Text <> "" Then
            If CType(txtCST.Text, Decimal) > 100.0 Then
                MsgBox("Enter as value less than 100")

                txtCST.Text = "0.00"

                txtVAT.Focus()
                Exit Sub
            End If
        End If

        If txtSurcharge.Text <> "" Then
            If CType(txtSurcharge.Text, Decimal) > 100.0 Then
                MsgBox("Enter as value less than 100")

                txtSurcharge.Text = "0.00"

                txtCST.Focus()
                Exit Sub
            End If
        End If

        If txtentrytax.Text <> "" Then
            If CType(txtentrytax.Text, Decimal) > 100.0 Then
                MsgBox("Enter as value less than 100")
                txtentrytax.Text = "0.00"

                txtSurcharge.Focus()
                Exit Sub
            End If
        End If

        If txtOther2.Text <> "" Then
            If CType(txtOther2.Text, Decimal) > 100.0 Then

                MsgBox("Enter as value less than 100")
                txtOther2.Text = "0.00"
                txtentrytax.Focus()

                Exit Sub
            End If
        End If

    End Sub

    Private Sub dgvItem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvItem.DoubleClick
        btnSave.Enabled = False
        btnModify.Text = "&Update"

        'For i As Integer = 0 To 14
        '    MsgBox(dgvItem(i, dgvItem.CurrentRow.Index).Value.ToString)
        'Next

        'fill textboxes

        txtItemName.Text = dgvItem(3, dgvItem.CurrentRow.Index).Value.ToString
        Label1.Text = dgvItem(3, dgvItem.CurrentRow.Index).Value.ToString
        txtopeningstock.Text = dgvItem(4, dgvItem.CurrentRow.Index).Value.ToString
        txtSubHeadingNo.Text = dgvItem(5, dgvItem.CurrentRow.Index).Value.ToString
        cmbItemCategory.Text = dgvItem(6, dgvItem.CurrentRow.Index).Value.ToString
        cmbItemType.Text = dgvItem(7, dgvItem.CurrentRow.Index).Value.ToString
        txtLedgerNo.Text = dgvItem(8, dgvItem.CurrentRow.Index).Value.ToString
        cmbUnit.Text = dgvItem(9, dgvItem.CurrentRow.Index).Value.ToString
        txtRate.Text = dgvItem(10, dgvItem.CurrentRow.Index).Value.ToString
        txtExciseNo.Text = dgvItem(11, dgvItem.CurrentRow.Index).Value.ToString
        txtBasicExcise.Text = dgvItem(12, dgvItem.CurrentRow.Index).Value.ToString
        txtEDU.Text = dgvItem(13, dgvItem.CurrentRow.Index).Value.ToString
        txtHS.Text = dgvItem(14, dgvItem.CurrentRow.Index).Value.ToString
        txtVAT.Text = dgvItem(15, dgvItem.CurrentRow.Index).Value.ToString
        txtCST.Text = dgvItem(16, dgvItem.CurrentRow.Index).Value.ToString
        txtentrytax.Text = dgvItem(17, dgvItem.CurrentRow.Index).Value.ToString
        txtOther2.Text = dgvItem(18, dgvItem.CurrentRow.Index).Value.ToString
        txtSurcharge.Text = dgvItem(19, dgvItem.CurrentRow.Index).Value.ToString
        txtAcNo.Text = dgvItem(20, dgvItem.CurrentRow.Index).Value.ToString
        txtAcName.Text = dgvItem(21, dgvItem.CurrentRow.Index).Value.ToString
        txtCostCode.Text = dgvItem(22, dgvItem.CurrentRow.Index).Value.ToString
        txtCostName.Text = dgvItem(23, dgvItem.CurrentRow.Index).Value.ToString
        cmblivetype.Text = dgvItem(24, dgvItem.CurrentRow.Index).Value.ToString

        cmbprdgrp.Text = dgvItem(0, dgvItem.CurrentRow.Index).Value.ToString
        txtprdsuffix.Text = dgvItem(1, dgvItem.CurrentRow.Index).Value.ToString
        txtprdothref.Text = dgvItem(2, dgvItem.CurrentRow.Index).Value.ToString


    End Sub
    Private Sub dgvItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.CellContentClick

    End Sub

    Private Sub cmbItemCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemCategory.SelectedIndexChanged

    End Sub
End Class