Public Class frmcpvoucher

    Private Sub frmcpvoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' order by seqorder", "vty")
        cmbcptype.DataSource = GMod.ds.Tables("vty")
        cmbcptype.DisplayMember = "vtype"
        FillSession()
    End Sub
    Public Sub FillSession()
        Dim i As Integer
        Dim start As Integer = 8
        DateTimePicker1.Value = "4/1/08"
        For i = 0 To 50
            DateTimePicker1.Value = DateTimePicker1.Value.AddYears(i)
            cmbSession.Items.Add(GMod.Getsession(DateTimePicker1.Value))
            cmbSessionTo.Items.Add(GMod.Getsession(DateTimePicker1.Value))
        Next
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim cfrom, headfrom As String
    Dim cto, headto As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        headfrom = "VENTRY_" & GMod.Cmpid & "_" & cmbSession.Text
        headto = "VENTRY_" & GMod.Cmpid & "_" & cmbSessionTo.Text

        If TextBox1.Text = "" Then
            MsgBox("Old voucher No. Can't be blank")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("New voucher No. Can't be blank")
            Exit Sub
        End If
        Dim sql As String

        If CheckBox1.Checked = False Then

            If MessageBox.Show("Are U Sure?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                sql = "select * from " & GMod.VENTRY & " where vou_type='" & cmbcptype.Text & "' and vou_no='" & TextBox2.Text & "'"
                GMod.DataSetRet(sql, "cpcheck")
                If GMod.ds.Tables("cpcheck").Rows.Count > 0 Then
                    MsgBox("Voucher already exists", MsgBoxStyle.Critical)
                Else
                    sql = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date)" _
                    & " select Cmp_id, Uname, Entry_id, '" & TextBox2.Text & "', Vou_type, '" & dtvdate.Value.ToShortDateString & "', " _
                    & " Acc_head_code, Acc_head, dramt, cramt, '-', Cheque_no, Narration, Group_name, " _
                    & " Sub_group_name, Ch_issue_date, Ch_date from " _
                    & GMod.VENTRY & " where Vou_type ='" & cmbcptype.Text & "' and vou_no='" & TextBox1.Text & "'"
                    MsgBox(GMod.SqlExecuteNonQuery(sql))
                End If
            End If
            'MsgBox(sql)
        Else
            If MessageBox.Show("Are U Sure?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                sql = "select * from " & headto & " where vou_type='" & cmbcptype.Text & "' and vou_no='" & TextBox2.Text & "'"
                GMod.DataSetRet(sql, "cpcheck")
                If GMod.ds.Tables("cpcheck").Rows.Count > 0 Then
                    MsgBox("Voucher already exists", MsgBoxStyle.Critical)
                Else
                    sql = "insert into " & headto & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date)" _
                    & " select Cmp_id, Uname, Entry_id, '" & TextBox2.Text & "', Vou_type, '" & dtvdate.Value.ToShortDateString & "', " _
                    & " Acc_head_code, Acc_head, dramt, cramt, '-', Cheque_no, Narration, Group_name, " _
                    & " Sub_group_name, Ch_issue_date, Ch_date from " _
                    & headfrom & " where Vou_type ='" & cmbcptype.Text & "' and vou_no='" & TextBox1.Text & "'"
                    MsgBox(GMod.SqlExecuteNonQuery(sql))
                End If
            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub cmbSession_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSession.SelectedIndexChanged

    End Sub
End Class