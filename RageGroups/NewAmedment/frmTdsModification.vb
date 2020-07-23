Public Class frmTdsModification
    Dim sql As String
    Private Sub frmTdsModification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq='" & GMod.Dept & "'"
        GMod.DataSetRet(Sql, "vttds")
        cmbvtype.DataSource = GMod.ds.Tables("vttds")
        cmbvtype.DisplayMember = "vtype"
    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        sql = "select TdsType, Per, TdsDate, BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt, Actualamt,  TdsAmt, dcode,id   from TdsEntry where cmp_id ='" & GMod.Cmpid & "' and Vou_type ='" & cmbvtype.Text & "' and vou_no ='" & txtVouNo.Text & "' and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "tdsmodify")
        dgTdsEntry.DataSource = GMod.ds.Tables("tdsmodify")
    End Sub
    Private Sub dgTdsEntry_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgTdsEntry.CellEndEdit
        If e.ColumnIndex = 0 Then
            ' MsgBox(dgTdsEntry(0, dgTdsEntry.CurrentCell.RowIndex).Value.ToString())
            ' MsgBox(dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString())
            GMod.SqlExecuteNonQuery("update  TdsEntry set TdsType='" & dgTdsEntry(0, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 1 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set Per='" & dgTdsEntry(1, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 2 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set TdsDate='" & dgTdsEntry(2, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 3 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set BiltyNo='" & dgTdsEntry(3, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 4 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set Biltyt='" & dgTdsEntry(4, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 5 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set VrhicleNo='" & dgTdsEntry(5, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 6 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set Qty='" & dgTdsEntry(6, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 7 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set Prd='" & dgTdsEntry(7, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 8 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set Paidamt='" & dgTdsEntry(8, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 9 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set Actualamt='" & dgTdsEntry(9, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 10 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set TdsAmt='" & dgTdsEntry(10, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
        If e.ColumnIndex = 11 Then
            GMod.SqlExecuteNonQuery("update  TdsEntry set dcode='" & dgTdsEntry(11, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "' where id ='" & dgTdsEntry(12, dgTdsEntry.CurrentCell.RowIndex).Value.ToString() & "'")
        End If
    End Sub
End Class