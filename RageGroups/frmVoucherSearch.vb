Public Class frmVoucherSearch
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
        'sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date , Acc_head_code, Acc_head, Narration, dramt, cramt, " _
        '     & " Group_name,pay_mode from " & GMod.VENTRY & " where vou_type='" & cmbcptype.Text & "' and  cast(vou_no as numeric(18,0)) " _
        '  & " between " & TextBox1.Text & " and " & TextBox2.Text & "  order by cast(vou_no as numeric(18,0)) ,ENTRY_ID"

        sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date ,account_code Acc_head_code, account_head_name Acc_head, " _
               & " Narration, dramt, cramt,  a.Group_name,pay_mode from " _
               & GMod.VENTRY & " v inner join " & GMod.ACC_HEAD & " a on v.Acc_head_code = a.account_code " _
                & " where vou_type='" & cmbcptype.Text & "' and  " _
                & " cast(vou_no as numeric(18,0))  between " & TextBox1.Text & " and " & TextBox2.Text & "  order by cast(vou_no as numeric(18,0)) ,ENTRY_ID"

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
End Class