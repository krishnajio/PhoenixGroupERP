Public Class frmPendlingList

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        
    End Sub
    Dim i As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fillgrid()
        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1(9, i).Value = "-" Then
                DataGridView1(0, i).Style.BackColor = Color.LightGreen
                DataGridView1(1, i).Style.BackColor = Color.LightGreen
                DataGridView1(2, i).Style.BackColor = Color.LightGreen
                DataGridView1(3, i).Style.BackColor = Color.LightGreen
                DataGridView1(4, i).Style.BackColor = Color.LightGreen
                DataGridView1(5, i).Style.BackColor = Color.LightGreen
                DataGridView1(6, i).Style.BackColor = Color.LightGreen
                DataGridView1(7, i).Style.BackColor = Color.LightGreen
                DataGridView1(8, i).Style.BackColor = Color.LightGreen
                DataGridView1(9, i).Style.BackColor = Color.LightGreen
            End If
        Next
    End Sub
    Private Sub Button2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        
    End Sub
    Sub fillgrid()
        Dim sql As String
        sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date , Acc_head_code, Acc_head, Narration, dramt, cramt, " _
              & " Group_name,pay_mode from " & GMod.VENTRY & " where  pay_mode ='-'  and vou_type in ( select vtype from vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq ='" & GMod.Dept & "' ) order by vou_type,CAST(VOU_NO AS BIGINT)"
        GMod.DataSetRet(sql, "CVD")
        DataGridView1.DataSource = GMod.ds.Tables("CVD")
    End Sub
    Private Sub frmVoucherSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
    End Sub
End Class