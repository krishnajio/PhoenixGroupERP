Public Class frmsubgroup

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'Sub_group_name, Group_name, Sqorder, Group_level, Balances, Shedules, Cmp_id
        Dim Sqlsavestr As String, Sqlresult As String
        Sqlsavestr = "Insert into Sub_Group(Sub_group_name, Group_name,Shedules,Cmp_id) values ("
        Sqlsavestr &= "'" & txtsubgroupname.Text.ToUpper & "',"
        Sqlsavestr &= "'" & cmbgroup.Text.ToUpper & "',"
        Sqlsavestr &= "'" & txtshedules.Text.ToUpper & "',"
        Sqlsavestr &= "'" & GMod.Cmpid.ToUpper & "')"
        If txtsubgroupname.Text = "" Or cmbgroup.Text = "" Then
            MsgBox("Sub group Name is required", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
        If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate sub group (sub Group already exists for this company)", MsgBoxStyle.Critical)
            Else
                MsgBox("Error :" & Sqlresult, MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Group information saved", MsgBoxStyle.Information)
            btnreset_Click(sender, e)
            'fillgrid()
        End If
        txtsubgroupname.Focus()
    End Sub
    Private Sub fillcomboGroups()
        Dim sqlselectroup As String
        sqlselectroup = "select Group_name from Groups where Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlselectroup, "Gropu_name")

        cmbgroup.DataSource = GMod.ds.Tables("Gropu_name")
        cmbgroup.DisplayMember = "Group_name"
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtsubgroupname.Text = ""
        txtshedules.Text = ""
        txtsubgroupname.Focus()
        btnsave.Enabled = True
        fillgrid()
    End Sub
    Dim cmpid As String, rowidx As Integer

    Private Sub frmsubgroup_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub
    Private Sub frmsubgroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        fillcomboGroups()
        fillgrid()
    End Sub
    Private Sub dgsubgroups_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsubgroups.CellContentClick
        
    End Sub
    Public Sub fillgrid()
        Dim sqlselectall As String
        sqlselectall = "select Sub_group_name, Group_name,  Shedules from Sub_Group where Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlselectall, "subgroup")
        dgsubgroups.DataSource = ds.Tables("subgroup")
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        'Sub_group_name, Group_name, Sqorder, Group_level, Balances, Shedules, Cmp_id
        Dim sqlupdate As String, sqlresult As String, sqlupdateventry As String
        sqlupdate = "update Sub_Group set "
        sqlupdate &= " Sub_group_name=" & "'" & txtsubgroupname.Text.ToUpper & "',"
        sqlupdate &= " Shedules=" & "'" & txtshedules.Text.ToUpper & "',"
        sqlupdate &= " Group_name=" & "'" & cmbgroup.Text.ToUpper & "'"
        sqlupdate &= " where Sub_Group_name=" & "'" & dgsubgroups(0, rowidx).Value & "' and Cmp_id='" & GMod.Cmpid & "'"


        sqlupdateventry = "update " & GMod.VENTRY & " set  sub_Group_name='" & txtsubgroupname.Text & "' where  " _
                            & " Group_name='" & dgsubgroups(1, rowidx).Value & "' and  sub_group_name='" & dgsubgroups(0, rowidx).Value & "' and Cmp_id='" & GMod.Cmpid & "'"

        If btnsave.Enabled Then
            MsgBox("Please double click on the Company name to select", MsgBoxStyle.Critical)
        Else
            If txtsubgroupname.Text = "" Or cmbgroup.Text = "" Then
                MsgBox("SUb Group name is necessary", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If MessageBox.Show("Are u sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                sqlresult = GMod.SqlExecuteNonQuery(sqlupdate)
                sqlresult = GMod.SqlExecuteNonQuery(sqlupdateventry)
                If sqlresult <> "SUCCESS" Then
                    MsgBox("Error :" & sqlresult, MsgBoxStyle.Critical)
                Else
                    btnreset_Click(sender, e)
                    fillgrid()
                End If
            Else
                btnreset_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub dgsubgroups_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgsubgroups.DoubleClick
        rowidx = dgsubgroups.CurrentCell.RowIndex
        txtsubgroupname.Text = dgsubgroups(0, rowidx).Value
        cmbgroup.Text = dgsubgroups(1, rowidx).Value
        txtshedules.Text = dgsubgroups(2, rowidx).Value
        btnsave.Enabled = False
        txtsubgroupname.Focus()
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim sqldelete As String, sqlresult As String
        sqldelete = "delete from Sub_Group "
        sqldelete &= " where  Group_name=" & "'" & dgsubgroups(1, rowidx).Value & "' and Cmp_id='" & GMod.Cmpid & "' and sub_group_name='" & dgsubgroups(0, rowidx).Value & "'"
        If btnsave.Enabled Then
            MsgBox("Please double click on the Sub group name to select", MsgBoxStyle.Critical)
        Else
            GMod.DataSetRet("select * from " & GMod.ACC_HEAD & " where sub_group_name='" & txtsubgroupname.Text & "' and cmp_id='" & GMod.Cmpid & "'", "ser")
            If MessageBox.Show("Are u sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                If GMod.ds.Tables("ser").Rows.Count > 0 Then
                    MsgBox("Subgroup can not Deteted. There are some account head exist of this subgroup", MsgBoxStyle.Information)
                    Exit Sub
                End If
                sqlresult = GMod.SqlExecuteNonQuery(sqldelete)
                If sqlresult <> "SUCCESS" Then
                    MsgBox("Error :" & sqlresult, MsgBoxStyle.Critical)
                Else
                    btnreset_Click(sender, e)
                    fillgrid()
                End If
            Else
                btnreset_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        'MsgBox(Me.cmbgroup.Items.Contains(Me.cmbgroup.Text))
        Me.Close()
    End Sub

    Private Sub txtsubgroupname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsubgroupname.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbgroup.Focus()
        End If
    End Sub

    Private Sub cmbgroup_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgroup.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtshedules.Focus()
        End If
    End Sub

    Private Sub txtshedules_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtshedules.KeyUp
        If e.KeyCode = Keys.Enter Then
            If btnsave.Enabled = True Then
                btnsave.Focus()
            Else
                btnmodify.Focus()
            End If
        End If
    End Sub

    Private Sub btnsave_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnsave.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnmodify.Focus()
        End If

    End Sub

    Private Sub btnmodify_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnmodify.KeyUp
        If e.KeyCode = Keys.Enter Then
            btndelete.Focus()
        End If
    End Sub

    Private Sub btndelete_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btndelete.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnclose.Focus()
        End If
    End Sub

    Private Sub btnreset_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnreset.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnclose.Focus()
        End If
    End Sub
End Class