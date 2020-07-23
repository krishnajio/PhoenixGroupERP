Public Class frmUpdateVouDate

    Private Sub frmUpdateVouDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%SALE%' and vtype not like '%other%'  and vtype not like '%JOURNAL%' and vtype not like 'SALE'", "vou_type")
        voutype.DataSource = GMod.ds.Tables("vou_type")
        voutype.DisplayMember = "vtype"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "select CONVERT(VARCHAR(10),BillDate,105),* from printdata where cmp_id ='" & GMod.Cmpid & "' and vou_type ='" & voutype.Text & "' and cast(vou_no as bigint) between " & Val(txtFrom.Text) & " and " & Val(txtTO.Text) & " and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "vupdata")
        DataGridView1.DataSource = GMod.ds.Tables("vupdata")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

      
            Dim q As String = ""
            q = "update printdata set billdate ='" & dtpdate.Value.ToShortDateString() & "'  where session ='" & GMod.Session & "' and cmp_id ='" & GMod.Cmpid & "' and vou_type ='" & voutype.Text & "' and cast(vou_no as bigint) between " & Val(txtFrom.Text) & " and " & Val(txtTO.Text) & " and session ='" & GMod.Session & "'"
            GMod.SqlExecuteNonQuery(q)


            q = "update ventry_phha_" & GMod.Session & " set vou_date ='" & dtpdate.Value.ToShortDateString() & "'  where cmp_id ='" & GMod.Cmpid & "' and vou_type ='" & voutype.Text & "' and cast(vou_no as bigint) between " & Val(txtFrom.Text) & " and " & Val(txtTO.Text) & ""
            GMod.SqlExecuteNonQuery(q)

            MessageBox.Show("Sucess....")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class