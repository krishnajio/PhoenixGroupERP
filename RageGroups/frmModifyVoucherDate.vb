Public Class frmModifyVoucherDate

    Private Sub frmModifyVoucherDate_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'GMod.ds.Tables("CVD").Dispose()
    End Sub

    Private Sub frmModifyVoucherDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype not in ('SALE','PURCHASE') order by seqorder", "vty")
        cmbcptype.DataSource = GMod.ds.Tables("vty")
        cmbcptype.DisplayMember = "vtype"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Voucher No. From Can't be blank")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Voucher No. TO Can't be blank")
            Exit Sub
        End If
        If Val(TextBox1.Text) - Val(TextBox2.Text) <= 5 Then
            If LockDataChecks(TextBox1.Text, GMod.Session, cmbcptype.Text) = False Then
                MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim sql, sql1, sql2, sql3 As String
            sql = "update  " & GMod.VENTRY & " set vou_date='" & dtvdate.Value.ToShortDateString & "'" _
                 & " where Vou_type='" & cmbcptype.Text & "'" _
                 & " and  cast(vou_no as numeric(18,0))  between " & TextBox1.Text & " and " & TextBox2.Text & ""

            'sql1 = "update  " & GMod.INVENTORY & " set vou_date='" & dtvdate.Value.ToShortDateString & "'" _
            '       & " where Vou_type='" & cmbcptype.Text & "'" _
            '       & " and  cast(vou_no as numeric(18,0))  between " & TextBox1.Text & " and " & TextBox2.Text & ""

            'sql2 = "update  PrintData set HatchDate='" & dtvdate.Value.ToShortDateString & "'" _
            '             & " where Vou_type='" & cmbcptype.Text & "'" _
            '             & " and  cast(vou_no as numeric(18,0))  between " & TextBox1.Text & " and " & TextBox2.Text & ""


            'sql3 = "update  InvPhxChicken set vou_date='" & dtvdate.Value.ToShortDateString & "'" _
            '                   & " where Vou_type='" & cmbcptype.Text & "'" _
            '                   & " and  cast(vou_no as numeric(18,0))  between " & TextBox1.Text & " and " & TextBox2.Text & ""

            If MessageBox.Show("Are U Sure? TO set Voucher Date TO: " & dtvdate.Text, "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                'MsgBox(sql)
                'If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "PHOE" Or GMod.Cmpid = "JAHA" Or GMod.Cmpid = "PHPO" Then
                '    GMod.SqlExecuteNonQuery(sql2)
                'ElseIf GMod.Cmpid = "PHCH" Then
                '    GMod.SqlExecuteNonQuery(sql3)
                'Else
                '    GMod.SqlExecuteNonQuery(sql1)
                'End If
                ' MsgBox(GMod.SqlExecuteNonQuery(sql))
                GMod.Fill_Log(GMod.Cmpid, TextBox1.Text, cmbcptype.Text, dtvdate.Value.ToShortDateString, Now, GMod.Session, "M", GMod.username)

                fillgrid()
            Else
                MsgBox("5 voucher at a time")
            End If
        End If
    End Sub
    Sub fillgrid()
        Dim sql As String
        sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date , Acc_head_code, Acc_head, Narration, dramt, cramt, " _
               & " Group_name from  " & GMod.VENTRY & " where vou_type='" & cmbcptype.Text & "' and  cast(vou_no as numeric(18,0)) " _
            & " between " & TextBox1.Text & " and " & TextBox2.Text & "  order by cast(vou_no as numeric(18,0)) ,ENTRY_ID"
        GMod.DataSetRet(sql, "CVD")
        DataGridView1.DataSource = GMod.ds.Tables("CVD")
    End Sub

    Private Sub frmModifyVoucherDate_MaximumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximumSizeChanged

    End Sub

    Private Sub TextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Leave

        If Math.Abs(Val(TextBox2.Text) - Val(TextBox1.Text)) < 6 Then
            fillgrid()
        Else
            MsgBox("5 voucher at a time")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub cmbcptype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcptype.SelectedIndexChanged

    End Sub
End Class