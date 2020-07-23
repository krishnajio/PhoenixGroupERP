Public Class frmNarrationUpdate

    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.ValueChanged

    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql As String
        sql = "select distinct narration from " & GMod.VENTRY & " where vou_type='" & cmbcptype.Text & "' and vou_no='" & txtvono.Text & "'"
        GMod.DataSetRet(sql, "narr")
        DataGridView1.DataSource = GMod.ds.Tables("narr")
        cmbcptype.Enabled = False
        txtvono.Enabled = False
    End Sub

    Private Sub frmNarrationUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' order by seqorder", "vty")
        cmbcptype.DataSource = GMod.ds.Tables("vty")
        cmbcptype.DisplayMember = "vtype"
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        txtOldNarration.Text = DataGridView1(DataGridView1.CurrentCell.ColumnIndex, DataGridView1.CurrentCell.RowIndex).Value
        txtnewnarration.Text = txtOldNarration.Text
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim sqlup As String
        sqlup = "update " & GMod.VENTRY & " set narration='" & txtnewnarration.Text & "' where narration='" & txtOldNarration.Text & "' and vou_type='" & cmbcptype.Text & "' and vou_no='" & txtvono.Text & "'"
        MsgBox(GMod.SqlExecuteNonQuery(sqlup))
        MsgBox("Narration Updated")
        cmbcptype.Enabled = True
        txtvono.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class