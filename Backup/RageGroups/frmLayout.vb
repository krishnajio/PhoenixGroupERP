Public Class frmLayout

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer = 0
        Dim s As Integer = 0
        While i < 10
            s = s + i
            i = i + 1
        End While
        MsgBox(s)
    End Sub

    Private Sub Button1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)

    End Sub

    Private Sub Button1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
       
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
       
    End Sub

    Private Sub btninfav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninfav1.Click

    End Sub

    Private Sub btninfav_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btninfav1.Enter
        btninfav1.BackColor = Color.Red
    End Sub

    Private Sub btninfav_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btninfav1.KeyDown
        If e.KeyCode = Keys.Up Then
            btninfav1.Top = btninfav1.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btninfav1.Top = btninfav1.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btninfav1.Left = btninfav1.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btninfav1.Left = btninfav1.Left + 1
        End If
    End Sub

    Private Sub btndate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndate.Click

    End Sub

    Private Sub btndate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndate.Enter
        btndate.BackColor = Color.Red
    End Sub

    Private Sub btndate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btndate.KeyDown
        If e.KeyCode = Keys.Up Then
            btndate.Top = btndate.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btndate.Top = btndate.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btndate.Left = btndate.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btndate.Left = btndate.Left + 1
        End If
    End Sub

    Private Sub frmLayout_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter

    End Sub

    Private Sub frmLayout_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub frmLayout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbFormat.SelectedIndex = 0
        Me.Text = Me.Text & "    " & GMod.Cmpname
        Try
            GMod.DataSetRet("select * from " & GMod.ACC_HEAD & " where group_name='BANK'", "banklayout")
            cmbbank.DataSource = GMod.ds.Tables("banklayout")
            cmbbank.DisplayMember = "account_head_name"
            cmbbankcode.DataSource = GMod.ds.Tables("banklayout")
            cmbbankcode.DisplayMember = "account_code"
            cmbbankcode_SelectedIndexChanged(sender, e)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btndate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndate.Leave
        btndate.BackColor = Color.Lavender
    End Sub

    Private Sub btninfav_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btninfav1.Leave
        btninfav1.BackColor = Color.Lavender
    End Sub

    Private Sub btnamtinword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnamtinword1.Click

    End Sub

    Private Sub btnamtinword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnamtinword1.Enter
        btnamtinword1.BackColor = Color.Red
    End Sub

    Private Sub btnamtinword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnamtinword1.KeyDown
        If e.KeyCode = Keys.Up Then
            btnamtinword1.Top = btnamtinword1.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btnamtinword1.Top = btnamtinword1.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btnamtinword1.Left = btnamtinword1.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btnamtinword1.Left = btnamtinword1.Left + 1
        End If
    End Sub

    Private Sub btnamtinword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnamtinword1.Leave
        btnamtinword1.BackColor = Color.Lavender
    End Sub

    Private Sub btnamt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnamt.Click

    End Sub

    Private Sub btnamt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnamt.Enter
        btnamt.BackColor = Color.Red
    End Sub

    Private Sub btnamt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnamt.KeyDown
        If e.KeyCode = Keys.Up Then
            btnamt.Top = btnamt.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btnamt.Top = btnamt.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btnamt.Left = btnamt.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btnamt.Left = btnamt.Left + 1
        End If
    End Sub

    Private Sub btnamt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnamt.Leave
        btnamt.BackColor = Color.Lavender
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sql, s As String
        sql = "delete from chqlayout where acc_head_code='" & cmbbankcode.Text & "' and LayOut='" & cmbFormat.Text & "' and cmp_id='" & GMod.Cmpid & "'"
        s = GMod.SqlExecuteNonQuery(sql)
        sql = "insert into chqlayout(cmp_id, acc_head_code, chq_datex, chq_datey, infavx, infavy, infavx1, infavy1, amtinwx, amtinwy, amtinwx1, amtinwy1, amtx, amty, chqw, cqhh,imgpath,Layout) values('" & GMod.Cmpid & "','" & cmbbankcode.Text & "',"
        sql += Val(btndate.Left) & "," & Val(btndate.Top) & ","
        sql += Val(btninfav1.Left) & "," & Val(btninfav1.Top) & ","
        sql += Val(btninfav2.Left) & "," & Val(btninfav2.Top) & ","
        sql += Val(btnamtinword1.Left) & "," & Val(btnamtinword1.Top) & ","
        sql += Val(btnamtinword2.Left) & "," & Val(btnamtinword2.Top) & ","
        sql += Val(btnamt.Left) & "," & Val(btnamt.Top) & ","
        sql += Val(txtlength.Text) & "," & Val(txtheight.Text) & ",'" & txtFilename.Text & "','" & cmbFormat.Text & "')"
        s = GMod.SqlExecuteNonQuery(sql)
        If s <> "SUCCESS" Then
            MsgBox(s, MsgBoxStyle.Critical, "Error")
        Else
            MsgBox("Cheque Layout Saved Successfully", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtlength_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlength.Leave
        Me.Width = Val(txtlength.Text)
    End Sub

    Private Sub txtlength_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlength.TextChanged

    End Sub

    Private Sub txtheight_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtheight.Leave
        txtheight.Text = Me.Height
    End Sub

    Private Sub txtheight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtheight.TextChanged

    End Sub


    Private Sub btninfav2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninfav2.Enter
        btninfav2.BackColor = Color.Red
    End Sub

    Private Sub btnamtinword2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnamtinword2.Enter
        btnamtinword2.BackColor = Color.Red
    End Sub

    Private Sub btninfav2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninfav2.Leave
        btninfav2.BackColor = Color.Lavender
    End Sub

    Private Sub btnamtinword2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnamtinword2.Leave
        btnamtinword2.BackColor = Color.Lavender
    End Sub

    Private Sub btninfav2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btninfav2.KeyDown
        If e.KeyCode = Keys.Up Then
            btninfav2.Top = btninfav2.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btninfav2.Top = btninfav2.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btninfav2.Left = btninfav2.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btninfav2.Left = btninfav2.Left + 1
        End If
    End Sub

    Private Sub btnamtinword2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnamtinword2.KeyDown
        If e.KeyCode = Keys.Up Then
            btnamtinword2.Top = btnamtinword2.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btnamtinword2.Top = btnamtinword2.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btnamtinword2.Left = btnamtinword2.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btnamtinword2.Left = btnamtinword2.Left + 1
        End If
    End Sub

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        Try
            OpenFileDialog1.ShowDialog()
            txtFilename.Text = OpenFileDialog1.FileName.ToString
            Dim img As Image
            img = Image.FromFile(txtFilename.Text)
            Me.BackgroundImage = img
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbbankcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbankcode.SelectedIndexChanged

        Try
            GMod.DataSetRet("select * from chqlayout where acc_head_code='" & cmbbankcode.Text & "' and layout='" & cmbFormat.Text & "' AND CMP_ID='" & GMod.Cmpid & "'", "ser_layout")
            If GMod.ds.Tables("ser_layout").Rows.Count > 0 Then
                txtlength.Text = GMod.ds.Tables("ser_layout").Rows(0)("chqw")
                txtheight.Text = GMod.ds.Tables("ser_layout").Rows(0)("cqhh")
                btndate.Left = GMod.ds.Tables("ser_layout").Rows(0)("chq_datex")
                btndate.Top = GMod.ds.Tables("ser_layout").Rows(0)("chq_datey")

                btninfav1.Left = GMod.ds.Tables("ser_layout").Rows(0)("infavx")
                btninfav1.Top = GMod.ds.Tables("ser_layout").Rows(0)("infavy")

                btninfav2.Left = GMod.ds.Tables("ser_layout").Rows(0)("infavx1")
                btninfav2.Top = GMod.ds.Tables("ser_layout").Rows(0)("infavy1")

                btnamtinword1.Left = GMod.ds.Tables("ser_layout").Rows(0)("amtinwx")
                btnamtinword1.Top = GMod.ds.Tables("ser_layout").Rows(0)("amtinwy")

                btnamtinword2.Left = GMod.ds.Tables("ser_layout").Rows(0)("amtinwx1")
                btnamtinword2.Top = GMod.ds.Tables("ser_layout").Rows(0)("amtinwy1")


                btnamt.Left = GMod.ds.Tables("ser_layout").Rows(0)("amtx")
                btnamt.Top = GMod.ds.Tables("ser_layout").Rows(0)("amty")


                cmbFormat.Text = GMod.ds.Tables("ser_layout").Rows(0)("Layout")

                txtFilename.Text = GMod.ds.Tables("ser_layout").Rows(0)("imgpath")
                Me.BackgroundImage = Image.FromFile(GMod.ds.Tables("ser_layout").Rows(0)("imgpath").ToString())

                txtlength_Leave(sender, e)
                txtheight_Leave(sender, e)
            Else
                txtlength.Text = Me.Width
                txtheight.Text = Me.Height
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFormat.SelectedIndexChanged
        cmbbankcode_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbbank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbank.SelectedIndexChanged

    End Sub
End Class
