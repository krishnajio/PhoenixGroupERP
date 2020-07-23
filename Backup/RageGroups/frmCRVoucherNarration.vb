Public Class frmCRVoucherNarration
    Private Sub rdCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdCash.Click
        If rdCash.Checked = True Then
            Label2.Visible = False
            txtDDChqNO.Visible = False
        End If
    End Sub
    Private Sub rdDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDD.Click
        If rdDD.Checked = True Then
            Label2.Visible = True
            txtDDChqNO.Visible = True
        End If
    End Sub
    Private Sub rdCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdCheque.Click
        If rdCheque.Checked = True Then
            Label2.Visible = True
            txtDDChqNO.Visible = True
        End If
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "WEPH" Then
            If cmbpaymenttype.Text = "OLD PAYMENT" Or cmbpaymenttype.Text = "ADVANCE PAYMENT" Then
                'dtHatchDate.Visible = False
                If rdCash.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# " + rdCash.Text & "#" & TextBox2.Text & "#" & cmbpaymenttype.Text
                ElseIf rdDD.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# DD NO. " + txtDDChqNO.Text & "#" & TextBox2.Text & "#" & cmbpaymenttype.Text
                ElseIf rdCheque.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# CH NO. " + txtDDChqNO.Text + "#" & TextBox2.Text & "#" & cmbpaymenttype.Text
                ElseIf rdRTGS.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# RTGS NO. " + txtDDChqNO.Text + "#" & TextBox2.Text & "#" & cmbpaymenttype.Text
                ElseIf rdNeft.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# NEFT NO. " + txtDDChqNO.Text + "#" & TextBox2.Text & "#" & cmbpaymenttype.Text
                End If
            Else
                If rdCash.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# " + rdCash.Text & "#" & TextBox2.Text & "#" & dtHatchDate.Text
                ElseIf rdDD.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# DD NO. " + txtDDChqNO.Text & "#" & TextBox2.Text & "#" & dtHatchDate.Text
                ElseIf rdCheque.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# CH NO. " + txtDDChqNO.Text + "#" & TextBox2.Text & "#" & dtHatchDate.Text
                ElseIf rdRTGS.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# RTGS NO. " + txtDDChqNO.Text + "#" & TextBox2.Text & "#" & dtHatchDate.Text
                ElseIf rdNeft.Checked = True Then
                    TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# NEFT NO. " + txtDDChqNO.Text + "#" & TextBox2.Text & "#" & dtHatchDate.Text
                End If
            End If
            GMod.nxtCR = Val(txtTRNo.Text) + 1
            Me.Close()
            txtDDChqNO.Text = ""
        Else
            If rdCash.Checked = True Then
                TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# " + rdCash.Text & "#" & TextBox2.Text
            ElseIf rdDD.Checked = True Then
                TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# DD NO. " + txtDDChqNO.Text & "#" & TextBox2.Text
            ElseIf rdCheque.Checked = True Then
                TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# CH NO. " + txtDDChqNO.Text + "#" & TextBox2.Text
            ElseIf rdRTGS.Checked = True Then
                TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# RTGS NO. " + txtDDChqNO.Text + "#" & TextBox2.Text
            ElseIf rdNeft.Checked = True Then
                TextBox1.Text = "BY  #TR NO. " + txtTRNo.Text + "# DT. " + dtTrDate.Text + "# NEFT NO. " + txtDDChqNO.Text + "#" & TextBox2.Text
            End If
            GMod.nxtCR = Val(txtTRNo.Text) + 1
            Me.Close()
            txtDDChqNO.Text = ""
        End If
    End Sub
    Private Sub frmCRVoucherNarration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTRNo.Text = GMod.nxtCR.ToString
        Me.Text = Me.Text & "    " & GMod.Cmpname
        txtTRNo.Focus()
    End Sub
    Private Sub txtTRNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTRNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtTrDate.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub dtTrDate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtTrDate.KeyUp
        If e.KeyCode = Keys.Enter Then
            rdCash.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub rdDD_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdDD.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtDDChqNO.Focus()
        End If
    End Sub
    Private Sub txtDDChqNO_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDDChqNO.KeyUp
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub frmCRVoucherNarration_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnOk_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOk.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnCancel_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCancel.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub rdCash_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdCash.KeyUp
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbpaymenttype.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub dtHatchDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtHatchDate.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOk.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub cmbpaymenttype_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpaymenttype.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtHatchDate.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub cmbpaymenttype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpaymenttype.SelectedIndexChanged
        'OLD PAYMENT 
        'ADVANCE PAYMENT
        'CURRENT PAYMENT
        If cmbpaymenttype.Text = "OLD PAYMENT" Then
            dtHatchDate.Visible = False
        End If
        If cmbpaymenttype.Text = "ADVANCE PAYMENT" Then
            dtHatchDate.Visible = False
        End If
        If cmbpaymenttype.Text = "CURRENT PAYMENT" Then
            dtHatchDate.Visible = True
        End If
    End Sub


    Private Sub rdRTGS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdRTGS.Click
        If rdRTGS.Checked = True Then
            Label2.Visible = True
            txtDDChqNO.Visible = True
        End If
    End Sub

    Private Sub rdNeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdNeft.Click
        If rdNeft.Checked = True Then
            Label2.Visible = True
            txtDDChqNO.Visible = True
        End If
    End Sub
End Class