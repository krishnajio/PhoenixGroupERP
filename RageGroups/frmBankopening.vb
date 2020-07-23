Public Class frmBankopening

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmBankopening_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub frmBankopening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Satenemt Opening" & "    " & "[" & GMod.Cmpname & "]"
        GMod.DataSetRet("Select * from " & GMod.ACC_HEAD & " where group_name='BANK'", "bankgrp")
        cmbheadcode.DataSource = GMod.ds.Tables("bankgrp")
        cmbheadcode.DisplayMember = "account_code"
        cmbheadname.DataSource = GMod.ds.Tables("bankgrp")
        cmbheadname.DisplayMember = "account_head_name"
        fillgrid()
    End Sub
    Sub fillgrid()
        Dim sql As String
        sql = "Select bank_acc_code,account_head_name,bo.dramt,bo.cramt from "
        sql += GMod.BANK_STATE_OPEN & " as bo, " & GMod.ACC_HEAD & "  as ah"
        sql += " where bo.bank_acc_code=ah.account_code"
        GMod.DataSetRet(sql, "bank1")
        If dgaccounthead.Rows.Count > 0 Then dgaccounthead.Rows.Clear()
        Dim i As Integer
        For i = 0 To GMod.ds.Tables("bank1").Rows.Count - 1
            dgaccounthead.Rows.Add()
            dgaccounthead(0, i).Value = GMod.ds.Tables("bank1").Rows(i)(0)
            dgaccounthead(1, i).Value = GMod.ds.Tables("bank1").Rows(i)(1)
            dgaccounthead(2, i).Value = GMod.ds.Tables("bank1").Rows(i)(2)
            dgaccounthead(3, i).Value = GMod.ds.Tables("bank1").Rows(i)(3)
        Next
    End Sub

    Private Sub cmbheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbheadcode.SelectedIndexChanged

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim s, sql As String
        If cmbdrcr.Text = "" Or txtamt.Text = "" Then
            MsgBox("Please Type Opeing Amount and its type", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        sql = "Select * from " & GMod.BANK_STATE_OPEN & " where bank_acc_code='" & cmbheadcode.Text & "'"
        GMod.DataSetRet(sql, "ser")
        If GMod.ds.Tables("ser").Rows.Count = 0 Then
            If cmbdrcr.Text = "Dr" Then
                sql = "insert into " & GMod.BANK_STATE_OPEN & "(bank_acc_code,dramt,cramt) values("
                sql += "'" & cmbheadcode.Text & "'," & Val(txtamt.Text) & ",0)"
            Else
                sql = "insert into " & GMod.BANK_STATE_OPEN & "(bank_acc_code,dramt,cramt) values("
                sql += "'" & cmbheadcode.Text & "',0," & Val(txtamt.Text) & ")"
            End If
            s = GMod.SqlExecuteNonQuery(sql)
        Else
            MsgBox("Bank Opening Already Entered", MsgBoxStyle.Critical, "Error")
        End If
        fillgrid()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        cmbdrcr.SelectedIndex = 0
        txtamt.Text = ""
        btnsave.Enabled = True
        btnmodify.Text = "&Modify"
        cmbheadcode.Enabled = True
        cmbheadname.Enabled = True
    End Sub

    Private Sub dgaccounthead_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgaccounthead.CellContentClick

    End Sub

    Private Sub dgaccounthead_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgaccounthead.DoubleClick
        Try
            Dim r As Integer
            r = dgaccounthead.CurrentCell.RowIndex
            cmbheadcode.Text = dgaccounthead(0, r).Value
            If dgaccounthead(2, r).Value > 0 Then
                cmbdrcr.Text = "Dr"
                txtamt.Text = dgaccounthead(2, r).Value
            Else
                cmbdrcr.Text = "Cr"
                txtamt.Text = dgaccounthead(3, r).Value
            End If
            btnsave.Enabled = False
            btnmodify.Text = "Update"
            cmbheadcode.Enabled = False
            cmbheadname.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        If btnsave.Enabled Then
            MsgBox("Double click on the Bank Account", MsgBoxStyle.Critical, "Error")
        Else
            If cmbdrcr.Text = "Dr" Then
                GMod.SqlExecuteNonQuery("update " & GMod.BANK_STATE_OPEN & " set dramt=" & Val(txtamt.Text) & ",cramt=0 where bank_acc_code='" & cmbheadcode.Text & "'")
            Else
                GMod.SqlExecuteNonQuery("update " & GMod.BANK_STATE_OPEN & " set dramt=0,cramt=" & Val(txtamt.Text) & " where bank_acc_code='" & cmbheadcode.Text & "'")
            End If
            fillgrid()
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If btnsave.Enabled Then
            MsgBox("Double click on the Bank Account", MsgBoxStyle.Critical, "Error")
        Else
            GMod.SqlExecuteNonQuery("delete from " & GMod.BANK_STATE_OPEN & " where bank_acc_code='" & cmbheadcode.Text & "'")
            fillgrid()
            btnreset_Click(sender, e)
        End If
    End Sub
End Class