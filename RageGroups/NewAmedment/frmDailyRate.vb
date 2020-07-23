Public Class frmDailyRate
    Dim sql As String
    Private Sub frmDailyRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select itemname from itemmaster where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "itemdailyrate")
        cmbItemName.DataSource = GMod.ds.Tables("itemdailyrate")
        cmbItemName.DisplayMember = "itemname"
        fillGrid()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        sql = "insert into Daily_Rate(item_name, rate, rdate)  values("
        sql &= "'" & cmbItemName.Text & "',"
        sql &= "'" & txtraye.Text & "',"
        sql &= "'" & dtpdate.Value.ToShortDateString & "')"
        MsgBox(GMod.SqlExecuteNonQuery(sql))
        fillGrid()
        txtraye.Clear()
    End Sub
    Sub fillGrid()
        sql = "select * from Daily_Rate"
        GMod.DataSetRet(sql, "showDaily_Rate")
        dgdaily.DataSource = GMod.ds.Tables("showDaily_Rate")
    End Sub
    Private Sub dgdaily_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdaily.DoubleClick
        Try
            cmbItemName.Text = dgdaily(0, dgdaily.CurrentCell.RowIndex).Value
            dtpdate.Value = CDate(dgdaily(2, dgdaily.CurrentCell.RowIndex).Value)
            txtraye.Text = dgdaily(1, dgdaily.CurrentCell.RowIndex).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class