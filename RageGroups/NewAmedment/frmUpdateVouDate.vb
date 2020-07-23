Public Class frmUpdateVouDate

    Private Sub frmUpdateVouDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from vtype where cmp_id='PHHA' and (vtype like '%SALE%'  or vtype like '%PURCHASE%')   and session = '" & GMod.Session & "'", "vou_type")
        'and vtype not like '%other%'  and vtype not like '%JOURNAL%' and vtype not like 'SALE'", "vou_type")
        voutype.DataSource = GMod.ds.Tables("vou_type")
        voutype.DisplayMember = "vtype"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "select billdate,* from printdata where cmp_id ='" & GMod.Cmpid & "' and vou_type ='" & voutype.Text & "' and cast(vou_no as bigint) between " & Val(txtFrom.Text) & " and " & Val(txtTO.Text) & " and session ='" & GMod.Session & "' order by  cast(vou_no as bigint)"
        GMod.DataSetRet(sql, "vupdata")
        DataGridView1.DataSource = GMod.ds.Tables("vupdata")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'bill date 
        Dim i As Integer
        Try
            For i = 0 To DataGridView1.RowCount - 2

                dtppp.Value = CDate(DataGridView1.Item(0, i).Value.ToString())

                Dim q As String = ""
                q = "update printdata set billdate ='" & dtpdate.Value.ToShortDateString() & "'  where session ='" & GMod.Session & "' and cmp_id ='" & GMod.Cmpid & "' and vou_type ='" & voutype.Text & "' and cast(vou_no as bigint) = " & Val(DataGridView1.Item(2, i).Value.ToString()) & "  and session ='" & GMod.Session & "'"
                GMod.SqlExecuteNonQuery(q)


                q = "update ventry_phha_" & GMod.Session & " set vou_date ='" & dtpdate.Value.ToShortDateString() & "',narration = REPLACE(narration, 'DT. " & dtppp.Text & "', 'DT. " & dtpdate.Text & "')     where cmp_id ='" & GMod.Cmpid & "' and vou_type ='" & voutype.Text & "' and cast(vou_no as bigint) = " & Val(DataGridView1.Item(2, i).Value.ToString())
                GMod.SqlExecuteNonQuery(q)
            Next
            MessageBox.Show("Sucess....")
            DataGridView1.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'hatch date 
        Dim i As Integer
        Try
            For i = 0 To DataGridView1.RowCount - 2

                dtppp.Value = CDate(DataGridView1.Item(16, i).Value.ToString())

                Dim q As String = ""
                q = "update printdata set billdate ='" & dtpdate.Value.ToShortDateString() & "'  where session ='" & GMod.Session & "' and cmp_id ='" & GMod.Cmpid & "' and vou_type ='" & voutype.Text & "' and cast(vou_no as bigint) = " & Val(DataGridView1.Item(2, i).Value.ToString()) & "  and session ='" & GMod.Session & "'"
                GMod.SqlExecuteNonQuery(q)


                q = "update ventry_phha_" & GMod.Session & " set vou_date ='" & dtpdate.Value.ToShortDateString() & "',narration = REPLACE(narration, 'Hatch Date " & dtppp.Text & "', 'Hatch Date " & dthatchdate.Text & "')     where cmp_id ='" & GMod.Cmpid & "' and vou_type ='" & voutype.Text & "' and cast(vou_no as bigint) = " & Val(DataGridView1.Item(2, i).Value.ToString())
                GMod.SqlExecuteNonQuery(q)
            Next
            MessageBox.Show("Sucess....")
            DataGridView1.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class