Public Class frmItemmaster

    Private Sub frmItemmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        fillgrid()
    End Sub
    Public Sub fillgrid()
        Dim sqlselectall As String
        sqlselectall = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlselectall, "ItemMaster")
        dgItemMaster.DataSource = ds.Tables("ItemMaster")
    End Sub
    Dim Sqlsavestr, Sqlresult As String
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click, Button5.Click
        If txtitemname.Text = "" Then
            MsgBox("Item name Required")
            Exit Sub
        End If
        If txtitemname.Text = "" Then
            MsgBox("Rate  Required")
            Exit Sub
        End If
        Sqlsavestr = "Insert into ItemMaster(ItemName, Rate, Unit, Cmp_id, discount, necc, freeqtyper) "
        Sqlsavestr &= " values ("
        Sqlsavestr &= "'" & txtitemname.Text.ToUpper & "',"
        Sqlsavestr &= "'" & txtrate.Text & "',"
        Sqlsavestr &= "'" & cmbunit.Text & "',"
        Sqlsavestr &= "'" & GMod.Cmpid & "',"
        Sqlsavestr &= Val(txtdiscountper.Text) & ","
        Sqlsavestr &= Val(txtnecc.Text) & ","
        Sqlsavestr &= Val(txtfreeqty.Text) & ")"
        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
        If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate company code", MsgBoxStyle.Critical)
            Else
                MsgBox("Error :" & Sqlresult, MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Company information saved", MsgBoxStyle.Information)
            btnreset_Click(sender, e)
        End If
        txtitemname.Focus()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click, Button2.Click
        txtitemname.Text = ""
        txtrate.Text = ""
        txtfreeqty.Text = ""
        txtdiscountamt.Text = ""
        txtdiscountper.Text = ""
        txtnecc.Text = ""
        txtitemname.Focus()
        fillgrid()
    End Sub

    Private Sub txtitemname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtitemname.KeyDown
        If e.KeyCode = Keys.Enter Then cmbunit.Focus()
    End Sub

    Private Sub cmbunit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbunit.KeyDown
        If e.KeyCode = Keys.Enter Then txtrate.Focus()

    End Sub

    Private Sub txtrate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrate.KeyDown
        If e.KeyCode = Keys.Enter Then btnsave.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub txtdiscountper_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdiscountper.Leave
        'txtdiscountamt.Text = Math.Round((Val(txtrate.Text) * Val(txtdiscountper.Text) / 100), 2)
    End Sub

    Private Sub txtdiscountamt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdiscountamt.Leave
        'txtdiscountper.Text = Math.Round((Val(txtdiscountamt.Text) / Val(txtrate.Text)) * 100, 2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim iname As String
                iname = dgItemMaster(0, dgItemMaster.CurrentCell.RowIndex).Value
                'GMod.SqlExecuteNonQuery("delete from itemmaster where itemname='" & iname & "' and cmp_id='" & GMod.Cmpid & "'")
            End If
            btnreset_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("select item from the list and click on delete button. After add as new item", MsgBoxStyle.Information)
    End Sub

    Private Sub dgItemMaster_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemMaster.CellContentClick

    End Sub

    Private Sub dgItemMaster_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemMaster.CellEndEdit
        'MsgBox(dgItemMaster(0, e.RowIndex).Value)
        If e.ColumnIndex = 1 Then
            Dim sql As String
            sql = "update ItemMaster set Rate='" & dgItemMaster(1, e.RowIndex).Value & "' where Cmp_id='" & GMod.Cmpid & "' and ItemName='" & dgItemMaster(0, e.RowIndex).Value & "'"
            If GMod.SqlExecuteNonQuery(sql) = "SUCCESS" Then
                MsgBox("Rate Updated")
            End If
        ElseIf e.ColumnIndex = 6 Then
            Dim sql As String
            sql = "update ItemMaster set freeqtyper='" & dgItemMaster(6, e.RowIndex).Value & "' where Cmp_id='" & GMod.Cmpid & "' and ItemName='" & dgItemMaster(0, e.RowIndex).Value & "'"
            If GMod.SqlExecuteNonQuery(sql) = "SUCCESS" Then
                MsgBox("Free Per Updated")
            End If
        ElseIf e.ColumnIndex = 5 Then
            Dim sql As String
            sql = "update ItemMaster set necc='" & dgItemMaster(5, e.RowIndex).Value & "' where Cmp_id='" & GMod.Cmpid & "' and ItemName='" & dgItemMaster(0, e.RowIndex).Value & "'"
            If GMod.SqlExecuteNonQuery(sql) = "SUCCESS" Then
                MsgBox("NECC Updated")
            End If
        ElseIf e.ColumnIndex = 4 Then
            Dim sql As String
            sql = "update ItemMaster set discount='" & dgItemMaster(4, e.RowIndex).Value & "' where Cmp_id='" & GMod.Cmpid & "' and ItemName='" & dgItemMaster(0, e.RowIndex).Value & "'"
            If GMod.SqlExecuteNonQuery(sql) = "SUCCESS" Then
                MsgBox("Discount Updated")
            End If

        End If
    End Sub

    Private Sub txtitemname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemname.TextChanged
        Dim sqlselectall As String
        sqlselectall = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' and ItemName like '%" & txtitemname.Text & "%'"
        GMod.DataSetRet(sqlselectall, "ItemMaster")
        dgItemMaster.DataSource = ds.Tables("ItemMaster")
    End Sub
End Class