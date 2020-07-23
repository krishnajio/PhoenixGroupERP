Public Class frmRtgsLayout

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer = 0
        Dim s As Integer = 0
        While i < 10
            s = s + i
            i = i + 1
        End While
        MsgBox(s)
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
    Private Sub btnamtinword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbranch.Enter
        btnbranch.BackColor = Color.Red
    End Sub

    Private Sub btnamtinword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnbranch.KeyDown
        If e.KeyCode = Keys.Up Then
            btnbranch.Top = btnbranch.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btnbranch.Top = btnbranch.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btnbranch.Left = btnbranch.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btnbranch.Left = btnbranch.Left + 1
        End If
    End Sub

    Private Sub btnamtinword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbranch.Leave
        btnbranch.BackColor = Color.Lavender
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
        sql = "delete from chqRTGSlayout where acc_head_code='" & cmbbankcode.Text & "' and LayOut='" & cmbFormat.Text & "' and cmp_id='" & GMod.Cmpid & "'"
        s = GMod.SqlExecuteNonQuery(sql)
        sql = "insert into chqRTGSlayout(cmp_id, acc_head_code, chq_datex, chq_datey, infavx, infavy, amtx, amty, amtinwx, amtinwy, beneAccNox, beneAccNoy, bankx, banky, bankbranchx, bankbranchy, cityx, cityy, beneAccNo1x, beneAccNo1y, beneAddressx, beneAddressy, chqx, chqy, chqw, cqhh, imgpath, layout) values('" & GMod.Cmpid & "','" & cmbbankcode.Text & "',"
        sql += Val(btndate.Left) & "," & Val(btndate.Top) & ","
        sql += Val(btninfav1.Left) & "," & Val(btninfav1.Top) & ","
        sql += Val(btnamt.Left) & "," & Val(btnamt.Top) & ","
        sql += Val(btnAmtInWrd.Left) & "," & Val(btnAmtInWrd.Top) & ","
        sql += Val(BtnBeneAccNo.Left) & "," & Val(BtnBeneAccNo.Top) & ","
        sql += Val(BtnBank.Left) & "," & Val(BtnBank.Top) & ","
        sql += Val(btnbranch.Left) & "," & Val(btnbranch.Top) & ","
        sql += Val(btncity.Left) & "," & Val(btncity.Top) & ","
        sql += Val(btnConfirmAcc.Left) & "," & Val(btnConfirmAcc.Top) & ","
        sql += Val(BtnBeneAdd.Left) & "," & Val(BtnBeneAdd.Top) & ","
        sql += Val(Btncheqe.Left) & "," & Val(Btncheqe.Top) & ","
        sql += Val(txtlength.Text) & "," & Val(txtheight.Text) & ",'" & txtFilename.Text & "','" & cmbFormat.Text & "')"
        s = GMod.SqlExecuteNonQuery(sql)
        If s <> "SUCCESS" Then
            MsgBox(s, MsgBoxStyle.Critical, "Error")
        Else
            MsgBox("Cheque Layout Saved Successfully", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtlength_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlength.Leave
        '  Me.Width = Val(txtlength.Text)
    End Sub

    Private Sub txtlength_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlength.TextChanged

    End Sub

    Private Sub txtheight_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtheight.Leave
        'txtheight.Text = Me.Height
    End Sub

    Private Sub txtheight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtheight.TextChanged

    End Sub


    Private Sub btninfav2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmtInWrd.Enter
        btnAmtInWrd.BackColor = Color.Red
    End Sub

    Private Sub btnamtinword2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmAcc.Enter
        btnConfirmAcc.BackColor = Color.Red
    End Sub

    Private Sub btninfav2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmtInWrd.Leave
        btnAmtInWrd.BackColor = Color.Lavender
    End Sub

    Private Sub btnamtinword2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmAcc.Leave
        btnConfirmAcc.BackColor = Color.Lavender
    End Sub

    Private Sub btninfav2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnAmtInWrd.KeyDown
        If e.KeyCode = Keys.Up Then
            btnAmtInWrd.Top = btnAmtInWrd.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btnAmtInWrd.Top = btnAmtInWrd.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btnAmtInWrd.Left = btnAmtInWrd.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btnAmtInWrd.Left = btnAmtInWrd.Left + 1
        End If
    End Sub

    Private Sub btnamtinword2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnConfirmAcc.KeyDown
        If e.KeyCode = Keys.Up Then
            btnConfirmAcc.Top = btnConfirmAcc.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btnConfirmAcc.Top = btnConfirmAcc.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btnConfirmAcc.Left = btnConfirmAcc.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btnConfirmAcc.Left = btnConfirmAcc.Left + 1
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
            GMod.DataSetRet("select * from chqRTGSlayout where acc_head_code='" & cmbbankcode.Text & "' and layout='" & cmbFormat.Text & "' AND CMP_ID='" & GMod.Cmpid & "'", "ser_layout1")
            If GMod.ds.Tables("ser_layout1").Rows.Count > 0 Then
                txtlength.Text = GMod.ds.Tables("ser_layout1").Rows(0)("chqw")
                txtheight.Text = GMod.ds.Tables("ser_layout1").Rows(0)("cqhh")

                btndate.Left = GMod.ds.Tables("ser_layout1").Rows(0)("chq_datex")
                btndate.Top = GMod.ds.Tables("ser_layout1").Rows(0)("chq_datey")

                btninfav1.Left = GMod.ds.Tables("ser_layout1").Rows(0)("infavx")
                btninfav1.Top = GMod.ds.Tables("ser_layout1").Rows(0)("infavy")

                btnamt.Left = GMod.ds.Tables("ser_layout1").Rows(0)("amtx")
                btnamt.Top = GMod.ds.Tables("ser_layout1").Rows(0)("amty")

                btnAmtInWrd.Left = GMod.ds.Tables("ser_layout1").Rows(0)("amtinwx")
                btnAmtInWrd.Top = GMod.ds.Tables("ser_layout1").Rows(0)("amtinwy")

                BtnBeneAccNo.Left = GMod.ds.Tables("ser_layout1").Rows(0)("beneAccNox")
                BtnBeneAccNo.Top = GMod.ds.Tables("ser_layout1").Rows(0)("beneAccNoy")

                BtnBank.Left = GMod.ds.Tables("ser_layout1").Rows(0)("bankx")
                BtnBank.Top = GMod.ds.Tables("ser_layout1").Rows(0)("banky")

                btnbranch.Left = GMod.ds.Tables("ser_layout1").Rows(0)("bankbranchx")
                btnbranch.Top = GMod.ds.Tables("ser_layout1").Rows(0)("bankbranchy")

                btncity.Left = GMod.ds.Tables("ser_layout1").Rows(0)("cityx")
                btncity.Top = GMod.ds.Tables("ser_layout1").Rows(0)("cityy")

                btnConfirmAcc.Left = GMod.ds.Tables("ser_layout1").Rows(0)("beneAccNo1x")
                btnConfirmAcc.Top = GMod.ds.Tables("ser_layout1").Rows(0)("beneAccNo1y")

                BtnBeneAdd.Left = GMod.ds.Tables("ser_layout1").Rows(0)("beneAddressx")
                BtnBeneAdd.Top = GMod.ds.Tables("ser_layout1").Rows(0)("beneAddressy")

                Btncheqe.Left = GMod.ds.Tables("ser_layout1").Rows(0)("chqx")
                Btncheqe.Top = GMod.ds.Tables("ser_layout1").Rows(0)("chqy")

                cmbFormat.Text = GMod.ds.Tables("ser_layout1").Rows(0)("Layout")

                txtFilename.Text = GMod.ds.Tables("ser_layout1").Rows(0)("imgpath")
                Me.BackgroundImage = Image.FromFile(GMod.ds.Tables("ser_layout1").Rows(0)("imgpath").ToString())

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

    Private Sub BtnBeneAccNo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBeneAccNo.Enter
        BtnBeneAccNo.BackColor = Color.Red
    End Sub


   

    Private Sub BtnBeneAccNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnBeneAccNo.KeyDown
        If e.KeyCode = Keys.Up Then
            BtnBeneAccNo.Top = BtnBeneAccNo.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            BtnBeneAccNo.Top = BtnBeneAccNo.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            BtnBeneAccNo.Left = BtnBeneAccNo.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            BtnBeneAccNo.Left = BtnBeneAccNo.Left + 1
        End If
    End Sub

    Private Sub BtnBank_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBank.Enter
        BtnBank.BackColor = Color.Red
    End Sub

  

    Private Sub BtnBank_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnBank.KeyDown
        If e.KeyCode = Keys.Up Then
            BtnBank.Top = BtnBank.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            BtnBank.Top = BtnBank.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            BtnBank.Left = BtnBank.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            BtnBank.Left = BtnBank.Left + 1
        End If
    End Sub

    Private Sub BtnBeneAdd_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBeneAdd.Enter
        BtnBeneAdd.BackColor = Color.Red
    End Sub

   

    Private Sub BtnBeneAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnBeneAdd.KeyDown
        If e.KeyCode = Keys.Up Then
            BtnBeneAdd.Top = BtnBeneAdd.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            BtnBeneAdd.Top = BtnBeneAdd.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            BtnBeneAdd.Left = BtnBeneAdd.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            BtnBeneAdd.Left = BtnBeneAdd.Left + 1
        End If
    End Sub

    Private Sub Btncheqe_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btncheqe.Enter
        Btncheqe.BackColor = Color.Red
    End Sub

    

    Private Sub Btncheqe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Btncheqe.KeyDown
        If e.KeyCode = Keys.Up Then
            Btncheqe.Top = Btncheqe.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            Btncheqe.Top = Btncheqe.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            Btncheqe.Left = Btncheqe.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            Btncheqe.Left = Btncheqe.Left + 1
        End If
    End Sub

    Private Sub btncity_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncity.Enter
        btncity.BackColor = Color.Red
    End Sub

    Private Sub btncity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btncity.KeyDown
        If e.KeyCode = Keys.Up Then
            btncity.Top = btncity.Top - 1
        ElseIf e.KeyCode = Keys.Down Then
            btncity.Top = btncity.Top + 1
        ElseIf e.KeyCode = Keys.Left Then
            btncity.Left = btncity.Left - 1
        ElseIf e.KeyCode = Keys.Right Then
            btncity.Left = btncity.Left + 1
        End If
    End Sub

    Private Sub BtnBank_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBank.Leave
        BtnBank.BackColor = Color.Lavender
    End Sub

    Private Sub BtnBeneAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBeneAccNo.Leave
        BtnBeneAccNo.BackColor = Color.Lavender
    End Sub

    Private Sub BtnBeneAdd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBeneAdd.Leave
        BtnBeneAdd.BackColor = Color.Lavender
    End Sub

    Private Sub Btncheqe_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btncheqe.Leave
        Btncheqe.BackColor = Color.Lavender
    End Sub

    Private Sub btncity_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncity.Leave
        btncity.BackColor = Color.Lavender
    End Sub
End Class
