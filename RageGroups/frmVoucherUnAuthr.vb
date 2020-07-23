Public Class frmVoucherUnAuthr

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub
    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        If e.KeyCode = Keys.Enter Then
            Button2.Focus()
        End If
    End Sub
    Dim i As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
    Private Sub Button2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyUp
        If e.KeyCode = Keys.Enter Then
            TextBox1.Focus()
        End If
    End Sub
    Sub fillgrid()
        Dim sql As String
        sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date , Acc_head_code, Acc_head, Narration, dramt, cramt, " _
              & " Group_name,pay_mode from " & GMod.VENTRY & " where vou_type='" & cmbcptype.Text & "' and  cast(vou_no as numeric(18,0)) " _
            & " between " & TextBox1.Text & " and " & TextBox2.Text & "  order by cast(vou_no as numeric(18,0)) ,ENTRY_ID"
        GMod.DataSetRet(sql, "CVD")
        DataGridView1.DataSource = GMod.ds.Tables("CVD")
    End Sub
    Private Sub frmVoucherSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If GMod.staff1 = 1 Then
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype not in ('BANK SAL TRANSFER') and session = '" & GMod.Session & "' order by seqorder", "vty")
            cmbcptype.DataSource = GMod.ds.Tables("vty")
            cmbcptype.DisplayMember = "vtype"
        Else
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype not in ('SALARY JOURNAL','BANK SAL TRANSFER')  and Vou_no_seq not in ('99')  and session = '" & GMod.Session & "' order by seqorder", "vty")
            cmbcptype.DataSource = GMod.ds.Tables("vty")
            cmbcptype.DisplayMember = "vtype"
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "update " & GMod.VENTRY & " set pay_mode ='-' where cast(vou_no as bigint) between " & TextBox1.Text & " and " & TextBox2.Text & " and vou_type ='" & cmbcptype.Text & "'"
        GMod.SqlExecuteNonQuery(sql)
        'update purchase_data set authr ='-' where cast(vou_no as bigint) between 44 and 31 and vou_type ='pur journal'

        sql = "update purchase_data set  authr  ='-' where cast(vou_no as bigint) between " & TextBox1.Text & " and " & TextBox2.Text & " and vou_type ='" & cmbcptype.Text & "' and session ='" & GMod.Session & "' and cmp_id ='" & GMod.Cmpid & "'"
        GMod.SqlExecuteNonQuery(sql)

        sql = "update printdata set  authr  ='-' where cast(vou_no as bigint) between " & TextBox1.Text & " and " & TextBox2.Text & " and vou_type ='" & cmbcptype.Text & "' and session ='" & GMod.Session & "'and cmp_id ='" & GMod.Cmpid & "'"
        GMod.SqlExecuteNonQuery(sql)

        sql = "update othersaledata set  authr  ='-' where cast(vou_no as bigint) between " & TextBox1.Text & " and " & TextBox2.Text & " and vou_type ='" & cmbcptype.Text & "' and session ='" & GMod.Session & "'and cmp_id ='" & GMod.Cmpid & "'"
        GMod.SqlExecuteNonQuery(sql)

    End Sub
End Class