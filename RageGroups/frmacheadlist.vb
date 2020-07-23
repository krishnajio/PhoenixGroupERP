Public Class frmacheadlist
    Dim st As String
    Private Sub frmacheadlist_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        GMod.AreaCode = cmbAreaCode.Text
    End Sub
    Private Sub frmacheadlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Len(GMod.AreaCode) = 0 Then
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        fillArea()
        'MsgBox(GMod.AreaCode)
        cmbAreaCode.Text = GMod.AreaCode
        fillAcc_head()
        cmbacheadlist.Focus()
        ' End If
        'cmbAreaName.Focus()
    End Sub
    Public Sub fillAcc_head()
        Dim sql As String
        sql = "select  account_head_name + '[' +account_code + ']' as head from " & GMod.ACC_HEAD & " where Area_code in ('" & GMod.AreaCode & "','**')  order by account_head_name"
        'MsgBox(sql)
        GMod.DataSetRet(sql, "acc_headx")
        cmbacheadlist.DataSource = GMod.ds.Tables("acc_headx")
        cmbacheadlist.DisplayMember = "head"
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
        'cmbAreaCode.Text = GMod.AreaCode

        sqlarea = "select group_name from groups where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlarea, "gn")

        cmbgroup.DataSource = GMod.ds.Tables("gn")
        cmbgroup.DisplayMember = "group_name"

    End Sub
    Private Sub cmbacheadlist_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' MsgBox(e.KeyCode.ToString)
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmbAreaCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaCode.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Control Then
            Me.Close()
        End If
    End Sub
    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        fillAcc_head()
        'GMod.AreaCode = cmbAreaCode.Text
    End Sub

    Private Sub cmbAreaName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyDown

    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Control Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            cmbgroup.Focus()
        End If
    End Sub

    Private Sub cmbAreaName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.SelectedIndexChanged
        'GMod.AreaCode = cmbAreaCode.Text
        fillAcc_head()
    End Sub
    Private Sub cmbAreaCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.Leave
        fillAcc_head()
    End Sub
    Private Sub cmbAreaName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.Leave
        GMod.AreaCode = cmbAreaCode.Text
        fillAcc_head()
    End Sub

    Private Sub cmbacheadlist_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbacheadlist.KeyPress
        If e.KeyChar = "[" Then
            MsgBox("Invalid ")
            'Application.Exit()
            cmbacheadlist.Text = ""
        ElseIf e.KeyChar = "]" Then
            MsgBox("Invalid ")
            cmbacheadlist.Text = ""
            'Application.Exit()
        End If
    End Sub

    Private Sub cmbacheadlist_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadlist.KeyUp
        'If cmbacheadlist.FindStringExact(cmbacheadlist.Text) = -1 Then
        '    MsgBox("Select A/c head correctoly")
        '    Exit Sub
        'End If
        If e.KeyCode = Keys.ControlKey Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmbgroup_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgroup.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            cmbgroup_Leave(sender, e)
            Me.Close()

        ElseIf e.KeyCode = Keys.Enter Then
            cmbacheadlist.Focus()
        End If
    End Sub

    Private Sub cmbgroup_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgroup.Leave
        'fillAcc_head()
        'End If
        If cmbgroup.FindStringExact(cmbgroup.Text) = -1 Then
            MsgBox("Please select proper group name", MsgBoxStyle.Critical)
            cmbgroup.Focus()
        Else
            Dim sql As String
            sql = "select  account_head_name + '[' +account_code + ']' as head from " & GMod.ACC_HEAD & " where Area_code in ('" & GMod.AreaCode & "','**')  and group_name = '" & cmbgroup.Text & "' order by account_head_name"
            'MsgBox(sql)
            GMod.DataSetRet(sql, "acc_headx")
            cmbacheadlist.DataSource = GMod.ds.Tables("acc_headx")
            cmbacheadlist.DisplayMember = "head"
        End If
    End Sub

    Private Sub cmbgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgroup.SelectedIndexChanged
        Dim sql As String
        sql = "select  account_head_name + '[' +account_code + ']' as head from " & GMod.ACC_HEAD & " where Area_code in ('" & GMod.AreaCode & "','**')  and group_name = '" & cmbgroup.Text & "' order by account_head_name"
        'MsgBox(sql)
        GMod.DataSetRet(sql, "acc_headx")
        cmbacheadlist.DataSource = GMod.ds.Tables("acc_headx")
        cmbacheadlist.DisplayMember = "head"
    End Sub

    Private Sub cmbacheadlist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadlist.SelectedIndexChanged

    End Sub
End Class