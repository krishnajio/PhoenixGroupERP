Public Class frmInvInfo

    Private Sub frmInvInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillItems()
        'If GMod.Cmpid = "PHFE" Then
        If GMod.Cmpid.ToString = "WEPH" Then

        Else
            dtHatchDate.Value = CDate("1/1/2000")
        End If
        ' End If
        Me.Text = "Inventory" & "   " & "[" & GMod.Cmpname & "]"
        'If GMod.InventoryFound = True Then
        fillGrid()
        'Else
        dgInvInfo.Rows.Add()
        txtinvoiceno.Focus()
        'End If
    End Sub
    Public Sub fillItems()
        Dim sql As String
        sql = "select * from ItemMaster where Cmp_id='" & GMod.Cmpid & "' order by ItemName "
        GMod.DataSetRet(sql, "Item1")

        Me.cmbItemName.DataSource = GMod.ds.Tables("Item1")
        Me.cmbItemName.DisplayMember = "ItemName"
    End Sub

    Private Sub txtHeadName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHeadName.KeyDown
        If e.KeyCode = Keys.Enter Then txtHeadCode.Focus()
    End Sub

    Private Sub txtHeadCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHeadCode.KeyDown
        If e.KeyCode = Keys.Enter Then dtdate.Focus()
    End Sub

    Private Sub dtdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtdate.KeyDown
        If e.KeyCode = Keys.Enter Then cmbinttype.Focus()
    End Sub

    Private Sub cmbinttype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbinttype.KeyDown
        If e.KeyCode = Keys.Enter Then dtHatchDate.Focus()
    End Sub
    Dim sum As Double = 0
    Dim qty1 As Double, rate1 As Double
    Private Sub dgInvInfo_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvInfo.CellEndEdit
        Dim rate As Double
        If e.ColumnIndex = 7 Then
            If Val(dgInvInfo(2, dgInvInfo.CurrentCell.RowIndex).Value) > 0 Then
                rate = Val(dgInvInfo(7, dgInvInfo.CurrentCell.RowIndex).Value) / Val(dgInvInfo(2, dgInvInfo.CurrentCell.RowIndex).Value)
                dgInvInfo(4, dgInvInfo.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
            ElseIf Val(dgInvInfo(3, dgInvInfo.CurrentCell.RowIndex).Value) > 0 Then
                rate = Val(dgInvInfo(7, dgInvInfo.CurrentCell.RowIndex).Value) / Val(dgInvInfo(3, dgInvInfo.CurrentCell.RowIndex).Value)
                dgInvInfo(4, dgInvInfo.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
            End If
        ElseIf e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
            If Val(dgInvInfo(2, dgInvInfo.CurrentCell.RowIndex).Value) > 0 Then
                rate = Val(dgInvInfo(7, dgInvInfo.CurrentCell.RowIndex).Value) / Val(dgInvInfo(2, dgInvInfo.CurrentCell.RowIndex).Value)
                dgInvInfo(4, dgInvInfo.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
            ElseIf Val(dgInvInfo(3, dgInvInfo.CurrentCell.RowIndex).Value) > 0 Then
                rate = Val(dgInvInfo(7, dgInvInfo.CurrentCell.RowIndex).Value) / Val(dgInvInfo(3, dgInvInfo.CurrentCell.RowIndex).Value)
                dgInvInfo(4, dgInvInfo.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
            End If
        End If
    End Sub
    Private Sub dgInvInfo_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvInfo.CellEnter
        Try
            If e.RowIndex = 0 Then
                dgInvInfo(0, e.RowIndex).Value = 1
            Else
                dgInvInfo(0, e.RowIndex).Value = Val(dgInvInfo(0, e.RowIndex - 1).Value) + 1
            End If
            If e.ColumnIndex = 5 Then
                sqlUnit = "select Unit from ItemMaster " _
                 & " where cmp_id='" & GMod.Cmpid & "' and ItemName='" & dgInvInfo(1, dgInvInfo.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sqlUnit, "Unit")
                dgInvInfo(5, dgInvInfo.CurrentCell.RowIndex).Value = GMod.ds.Tables("Unit").Rows(0)(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim sqlUnit As String
    Private Sub dgInvInfo_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvInfo.CellLeave
        If e.ColumnIndex = 5 Then
            'qty1 = CDbl(dgInvInfo(2, dgInvInfo.CurrentCell.RowIndex).Value)
            'rate1 = CDbl(dgInvInfo(4, dgInvInfo.CurrentCell.RowIndex).Value)
            'qty1 = Math.Round(qty1 * rate1, 0)
            'dgInvInfo(7, dgInvInfo.CurrentCell.RowIndex).Value = qty1.ToString
        ElseIf e.ColumnIndex = 7 Then
            Dim i As Integer
            For i = 0 To dgInvInfo.Rows.Count - 1
                sum = sum + CDbl(dgInvInfo(7, i).Value)
            Next
            txtTotal.Text = sum.ToString
            sum = 0
        End If
    End Sub
    Dim Narration As String
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        saveInv()
        Me.Close()
    End Sub
    Public Sub saveInv()
        If cmbinttype.Text = "SALE" Or cmbinttype.Text = "PURCHASE" Then
            Narration = "BILL NO" & " " & txtinvoiceno.Text & " " & "DT." & dtdate.Text & ""
        Else
            Narration = "INV. NO" & " " & txtinvoiceno.Text & " " & "DT." & dtdate.Text & ""
        End If
        If dtHatchDate.Value <> CDate("1/1/2000") Then
            Narration = Narration & " Hatch Date " & dtHatchDate.Text & ""
        End If
        GMod.SqlExecuteNonQuery("delete tmpInvinfo where Cmp_id='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
        Dim sqlsave As String = ""
        Dim i As Integer
        For i = 0 To dgInvInfo.Rows.Count - 1

            'For Narration
            If Val(dgInvInfo(2, i).Value) > 0 And Val(dgInvInfo(3, i).Value) = 0 And Val(dgInvInfo(6, i).Value) = 0 Then
                Narration = Narration & " " & dgInvInfo(1, i).Value & " " & dgInvInfo(2, i).Value _
                & " " & dgInvInfo(5, i).Value & " @ " & dgInvInfo(4, i).Value & "/-"

            ElseIf Val(dgInvInfo(2, i).Value) > 0 And Val(dgInvInfo(3, i).Value) = 0 And Val(dgInvInfo(6, i).Value) > 0 Then
                Narration = Narration & " " & dgInvInfo(1, i).Value & " " & dgInvInfo(2, i).Value _
                & " + " & dgInvInfo(6, i).Value & " " & dgInvInfo(5, i).Value & " @ " & dgInvInfo(4, i).Value & "/- "

            ElseIf Val(dgInvInfo(2, i).Value) > 0 And Val(dgInvInfo(3, i).Value) > 0 And Val(dgInvInfo(6, i).Value) = 0 Then
                Narration = Narration & " " & dgInvInfo(1, i).Value & " " & dgInvInfo(2, i).Value _
                & " " & dgInvInfo(5, i).Value & " @ " & dgInvInfo(4, i).Value & "/- " & dgInvInfo(3, i).Value & " Nos"
            End If
            sqlsave = "insert into tmpInvinfo (Cmp_id, Uname, Vou_no, Vou_type, Vou_date," _
            & "Acc_head_code, Acc_head, ItemName, Qty, Rate, Amount, Free_Qty, BillType, " _
            & "BillNo, BillDate, AreaCode,Unit,QtyNos,Hatch_date) values ("
            sqlsave &= "'" & GMod.Cmpid & "',"
            sqlsave &= "'" & GMod.username & "',"
            sqlsave &= "'" & txtVouno.Text & "',"
            sqlsave &= "'" & txtVtype.Text & "',"
            sqlsave &= "'" & dtVoudate.Value.ToShortDateString & "',"
            sqlsave &= "'" & txtHeadCode.Text & "',"
            sqlsave &= "'" & txtHeadName.Text & "',"
            sqlsave &= "'" & dgInvInfo(1, i).Value & "',"
            sqlsave &= "'" & Val(dgInvInfo(2, i).Value) & "',"
            sqlsave &= "'" & Val(dgInvInfo(4, i).Value) & "',"
            sqlsave &= "'" & Val(dgInvInfo(7, i).Value) & "',"
            sqlsave &= "'" & Val(dgInvInfo(6, i).Value) & "',"
            sqlsave &= "'" & cmbinttype.Text & "',"
            sqlsave &= "'" & txtinvoiceno.Text & "',"
            sqlsave &= "'" & dtdate.Value.ToShortDateString & "',"
            sqlsave &= "'" & txtHeadCode.Text.Substring(0, 2) & "',"
            sqlsave &= "'" & dgInvInfo(5, i).Value & "',"
            sqlsave &= "'" & Val(dgInvInfo(3, i).Value) & "',"
            sqlsave &= "'" & dtHatchDate.Value.ToShortDateString & "')"
            GMod.SqlExecuteNonQuery(sqlsave)
            'MsgBox(sqlsave)
        Next
        If Narration.Length <= 180 Then
            txtNarration.Text = Narration
        Else
            MsgBox("Lengh of Narration is greater please type narration manually")
        End If
    End Sub
    Public Sub fillGrid()
        Dim sql As String, i As Integer
        sql = "select Cmp_id, Uname, Vou_no, Vou_type, Vou_date, " _
        & " Acc_head_code, Acc_head, ItemName, Qty, QtyNos, " _
        & " Unit, Rate, Amount, Free_Qty, BillType, " _
        & "BillNo, BillDate, AreaCode,Hatch_date from tmpInvinfo " _
        & "where Uname='" & GMod.username & "'"
        GMod.DataSetRet(sql, "GetData")
        If GMod.ds.Tables("GetData").Rows.Count > 0 Then
            'txtHeadCode.Text = ds.Tables("GetData").Rows(0)(5)
            'txtHeadName.Text = ds.Tables("GetData").Rows(0)(6)
            dtdate.Value = CDate(ds.Tables("GetData").Rows(0)("BillDate"))
            cmbinttype.Text = ds.Tables("GetData").Rows(0)(14)
            txtinvoiceno.Text = ds.Tables("GetData").Rows(0)(15)
            If CDate(ds.Tables("GetData").Rows(0)("Hatch_date").ToString) <> CDate("1/1/2000") Then
                dtHatchDate.Value = CDate(ds.Tables("GetData").Rows(0)("Hatch_date").ToString)
            End If
            'MsgBox(ds.Tables("GetData").Rows.Count)
            On Error Resume Next
            For i = 0 To ds.Tables("GetData").Rows.Count - 1
                dgInvInfo.Rows.Add()
                dgInvInfo(0, i).Value = i + 1
                dgInvInfo(1, i).Value = ds.Tables("GetData").Rows(i)(7)
                dgInvInfo(2, i).Value = ds.Tables("GetData").Rows(i)(8)
                dgInvInfo(3, i).Value = ds.Tables("GetData").Rows(i)(9)
                dgInvInfo(4, i).Value = ds.Tables("GetData").Rows(i)(11)
                dgInvInfo(5, i).Value = ds.Tables("GetData").Rows(i)(10)
                dgInvInfo(6, i).Value = ds.Tables("GetData").Rows(i)(13)
                dgInvInfo(7, i).Value = ds.Tables("GetData").Rows(i)(12)
            Next
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        GMod.SqlExecuteNonQuery("delete FROM tmpinvinfo where cmp_id='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
        Close()
    End Sub

    Private Sub dgInvInfo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgInvInfo.KeyUp
        If e.KeyCode = Keys.Enter Then

            If dgInvInfo.CurrentCell.ColumnIndex < dgInvInfo.ColumnCount - 1 Then
                SendKeys.Send("{Tab}")
            Else
                dgInvInfo.Rows.Add()
                dgInvInfo.CurrentCell = dgInvInfo(0, dgInvInfo.CurrentCell.RowIndex + 1)
            End If
        End If
    End Sub

    Private Sub txtinvoiceno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinvoiceno.KeyDown
        If e.KeyCode = Keys.Enter Then dtdate.Focus() 'dgInvInfo.Focus()
    End Sub
    Private Sub dgInvInfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgInvInfo.KeyDown
        If e.KeyCode = Keys.F8 Then
            btnok_Click(sender, e)
        End If
    End Sub

    Private Sub dgInvInfo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvInfo.CellContentClick

    End Sub

    Private Sub txtinvoiceno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinvoiceno.Leave
        On Error Resume Next
        Dim sql As String
        sql = "select * from " & GMod.VENTRY & " where vou_type='PURCHASE' and  Acc_head_code ='" & txtHeadCode.Text & "' and narration like 'BILL NO " & txtinvoiceno.Text & " %'"
        GMod.DataSetRet(sql, "BILLNO")
        If GMod.ds.Tables("BILLNO").Rows.Count > 0 Then
            MsgBox("BILL NO ALREADY EXISTS OF THIS PARTY")
        End If
    End Sub

    Private Sub txtinvoiceno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinvoiceno.TextChanged

    End Sub

    Private Sub frmInvInfo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'GMod.SqlExecuteNonQuery("delete FROM tmpinvinfo where cmp_id='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
    End Sub

    Private Sub lbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl.Click

    End Sub

    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdate.ValueChanged

    End Sub

    Private Sub cmbinttype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbinttype.SelectedIndexChanged

    End Sub

    Private Sub dtHatchDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtHatchDate.KeyDown
        If e.KeyCode = Keys.Enter Then dgInvInfo.Focus()
    End Sub
End Class