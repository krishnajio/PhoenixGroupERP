Imports System.Data.SqlClient
Public Class FrmForm49
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If TxtfrmNo.Text = "" Then
            MsgBox("Field required..")
            TxtfrmNo.Focus()
            Exit Sub
        End If

        Dim sql As String
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = GMod.SqlConn
        If GMod.SqlConn.State = ConnectionState.Closed Then
            GMod.SqlConn.Open()
        End If
        If TxtNoOfFrm.Text = "" Then
            TxtNoOfFrm.Text = 0
        End If

        Dim trans As SqlTransaction = GMod.SqlConn.BeginTransaction
        Try
            sql = "delete from Form_49 where session='" & GMod.Session & "' and id=" & Val(lblID.Text)
            cmd.CommandText = sql
            cmd.Transaction = trans
            cmd.ExecuteNonQuery()

            sql = "insert into Form_49(party_code, frm_no, frm_issue, issue_date, rec_bill_no, bill_date, frm_rec_date, session) values("
            sql += "'" & CmbCode.Text & "',"
            sql += "'" & TxtfrmNo.Text & "',"
            sql += Val(TxtNoOfFrm.Text) & ","
            sql += "'" & DtpIssueDate.Value.ToShortDateString & "',"
            sql += "'" & TxtReceivedBill.Text & "',"
            sql += "'" & DtpBillDate.Value.ToShortDateString & "',"
            sql += "'" & DtpfrmrecDate.Value.ToShortDateString & "',"
            sql += "'" & GMod.Session & "')"


            cmd.CommandText = sql
            cmd.Transaction = trans
            cmd.ExecuteNonQuery()
            trans.Commit()
            MsgBox("Data Saved Successfully", MsgBoxStyle.Exclamation)
            btnreset_Click(sender, e)

        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ClearControls(ByVal topControl As Control)
        ' Ignore the control unless it is a textbox.
        If TypeOf topControl Is TextBox Then
            topControl.Text = ""
        Else
            ' Process controls recursively.
            ' This is required if controls contain other controls
            ' (for example, if you use panels, group boxes, or other
            ' container controls).
            For Each childControl As Control In topControl.Controls
                ClearControls(childControl)
            Next
        End If
    End Sub
    Private Sub frmDataEntry_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter And Not (e.Alt Or e.Control) Then
            If Me.ActiveControl.GetType Is GetType(TextBox) Or Me.ActiveControl.GetType Is GetType(CheckBox) Or Me.ActiveControl.GetType Is GetType(DateTimePicker) Or Me.ActiveControl.GetType Is GetType(ComboBox) Or Me.ActiveControl.GetType Is GetType(CheckedListBox) Or Me.ActiveControl.GetType Is GetType(DataGridView) Then
                If e.Shift Then
                    Me.ProcessTabKey(False)
                Else
                    Me.ProcessTabKey(True)
                End If
            End If
        End If
    End Sub

    Private Sub FrmForm49_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblID.Text = 0
        btnsave.Enabled = True
        btnmodify.Enabled = False
        btndelete.Enabled = False

        GMod.DataSetRet("select account_code,account_head_name from " & GMod.ACC_HEAD & " order by  account_head_name", "cmbacccode")
        cmbName.DataSource = GMod.ds.Tables("cmbacccode")
        cmbName.DisplayMember = "account_head_name"
        CmbCode.DataSource = GMod.ds.Tables("cmbacccode")
        CmbCode.DisplayMember = "account_code"

        filldg()
    End Sub
    Private Sub filldg()
        Dg.Rows.Clear()
        Try
            Dim sql As String = "select * from Form_49 where session='" & GMod.Session & "'"
            GMod.DataSetRet(sql, "dg49")

            Dim i As Integer
            For i = 0 To GMod.ds.Tables("dg49").Rows.Count - 1
                dg.Rows.Add()
                dg("id", i).Value = GMod.ds.Tables("dg49").Rows(i)("id")
                dg("frm_no", i).Value = GMod.ds.Tables("dg49").Rows(i)("frm_no")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        If MsgBox("Are you sure ? ", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            btnsave_Click(sender, e)
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure ? ", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

            Dim sql As String = "delete from Form_49 where session='" & GMod.Session & "' and id=" & Val(lblID.Text)

            Dim str As String = GMod.SqlExecuteNonQuery(sql)
            If str = "SUCCESS" Then
                MsgBox("Deleted..")
                btnreset_Click(sender, e)
            Else
                MsgBox(str)
            End If
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        btnsave.Enabled = True
        btnmodify.Enabled = False
        btndelete.Enabled = False
        filldg()
        ClearControls(Me)
        lblID.Text = 0
        cmbName.Focus()
    End Sub

    Private Sub TxtNoOfFrm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNoOfFrm.KeyPress
        'Numeric 
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        btnsave.Enabled = False
        btnmodify.Enabled = True
        btndelete.Enabled = True

        Dim sql As String = "select * from Form_49 where session='" & GMod.Session & "' and frm_no='" & dg("frm_no", dg.CurrentCell.RowIndex).Value & "' and id=" & Val(dg("id", dg.CurrentCell.RowIndex).Value)
        GMod.DataSetRet(sql, "fillFrm49")

        If GMod.ds.Tables("fillFrm49").Rows.Count > 0 Then
            lblID.Text = dg("id", dg.CurrentCell.RowIndex).Value
            CmbCode.Text = GMod.ds.Tables("fillFrm49").Rows(0)("party_code")
            TxtfrmNo.Text = GMod.ds.Tables("fillFrm49").Rows(0)("frm_no")
            TxtNoOfFrm.Text = GMod.ds.Tables("fillFrm49").Rows(0)("frm_issue")
            DtpIssueDate.Value = GMod.ds.Tables("fillFrm49").Rows(0)("issue_date")
            TxtReceivedBill.Text = GMod.ds.Tables("fillFrm49").Rows(0)("rec_bill_no")
            DtpBillDate.Value = GMod.ds.Tables("fillFrm49").Rows(0)("bill_date")
            DtpfrmrecDate.Value = GMod.ds.Tables("fillFrm49").Rows(0)("frm_rec_date")

        End If

    End Sub
End Class