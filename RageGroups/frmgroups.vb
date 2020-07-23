Imports System.Data.SqlClient
Public Class frmgroups

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim i As Integer, vtype As String
        Dim sql As String
        sql = "select * from Groups where cmp_id='" & GMod.Cmpid & "' and suffix='" & txtgroupsfx.Text & "' AND SESSION ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "sufixchk")

        If GMod.ds.Tables("sufixchk").Rows.Count > 0 Then
            MsgBox("Suffix aredy created...")
            Exit Sub
        End If
        If chkall.Checked = True Then
            vtype = "All"
        Else
            For i = 0 To Me.listeffectsin.Items.Count - 1
                vtype = vtype & "," & listeffectsin.Items(i)
            Next
        End If
        cmbdr_cr.SelectedIndex = 0
        'Group_name, BS_PL, Amount, Cmp_id, Sqorder
        Dim Sqlsavestr As String, Sqlresult As String
        Sqlsavestr = "Insert into Groups(Group_name,Suffix,BS_PL,Cmp_id,Dr_Cr, EffectsIN,session) values ("
        Sqlsavestr &= "'" & txtgroupname.Text.ToUpper & "',"
        Sqlsavestr &= "'" & txtgroupsfx.Text.ToUpper & "',"
        Sqlsavestr &= "'" & cmbbs_pl.Text.ToUpper & "',"
        Sqlsavestr &= "'" & GMod.Cmpid.ToUpper & "',"
        Sqlsavestr &= "'" & cmbdr_cr.Text & "',"
        Sqlsavestr &= "'" & vtype.ToString & "',"
        Sqlsavestr &= "'" & GMod.Session & "')"
        If txtgroupname.Text = "" Or cmbbs_pl.Text = "" Then
            MsgBox("Group Name is required", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
        If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate group (Group already exists for this company)", MsgBoxStyle.Critical)
            Else
                MsgBox("Error :" & Sqlresult, MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Group information saved", MsgBoxStyle.Information)
            btnreset_Click(sender, e)
            fillgrid()
        End If
        txtgroupname.Focus()
    End Sub
    Public Sub fillgrid()
        Dim sqlselectall As String
        sqlselectall = "select Group_name,Suffix, BS_PL,Dr_Cr, EffectsIN  from Groups where Cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sqlselectall, "group")
        dggroups.DataSource = ds.Tables("group")
    End Sub

    Private Sub frmgroups_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub
    Private Sub frmgroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If GMod.role.ToUpper = "ADMIN" Then
            btnmodify.Enabled = True
            btndelete.Enabled = True
            btnsave.Enabled = True
        Else
            btnmodify.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = False
        End If

        cmbdr_cr.SelectedIndex = 0
        cmbbs_pl.SelectedIndex = 0
        Me.Text = Me.Text & "    " & GMod.Cmpname
        Me.listremvtype.Items.Clear()
        Me.listeffectsin.Items.Clear()
        fillgrid()
        If chkall.Checked = True Then
            Dim sqlvtype As String
            sqlvtype = "select vtype from  dbo.Vtype where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sqlvtype, "Vtype")
            Dim i As Integer
            For i = 0 To GMod.ds.Tables("Vtype").Rows.Count - 1
                Me.listremvtype.Items.Add(GMod.ds.Tables("Vtype").Rows(i)(0))
            Next

            Me.listremvtype.Enabled = False
            Me.listeffectsin.Enabled = False

        End If


    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtgroupname.Text = ""
        txtgroupname.Focus()
        btnsave.Enabled = True
    End Sub
    Dim cmpid As String, rowidx As Integer
    Dim gprefix As String
    Private Sub dggroups_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dggroups.DoubleClick
        listremvtype.Items.Clear()
        Dim sqlvtype As String
        sqlvtype = "select vtype from  Vtype where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sqlvtype, "Vtype")
        Dim i As Integer
        For i = 0 To GMod.ds.Tables("Vtype").Rows.Count - 1
            Me.listremvtype.Items.Add(GMod.ds.Tables("Vtype").Rows(i)(0))
        Next
        Try
            rowidx = dggroups.CurrentCell.RowIndex
            If dggroups(0, rowidx).Value.ToString.Length > 0 Then
                txtgroupname.Text = dggroups(0, rowidx).Value
            End If


            If dggroups(1, rowidx).Value.ToString.Length > 0 Then
                txtgroupsfx.Text = dggroups(1, rowidx).Value
                gprefix = dggroups(1, rowidx).Value
            End If
            If dggroups(2, rowidx).Value.ToString.Length Then cmbbs_pl.Text = dggroups(2, rowidx).Value
            If dggroups(3, rowidx).Value.ToString.Length Then cmbdr_cr.Text = dggroups(3, rowidx).Value
            btnsave.Enabled = False

            Dim vtypearray(), sql As String, j As Integer
            sql = "select EffectsIN from Groups  where Group_name='" & dggroups(0, rowidx).Value & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "effectsin")
            vtypearray = GMod.ds.Tables("effectsin").Rows(0)(0).ToString.Split(",")
            'MsgBox(vtypearray(1))
            ' Me.listremvtype.Items.Clear()
            Me.listeffectsin.Items.Clear()
            For j = 0 To vtypearray.Length - 1
                Me.listeffectsin.Items.Add(vtypearray(j))
            Next

            For j = 0 To Me.listeffectsin.Items.Count - 1
                listremvtype.Items.Remove(Me.listeffectsin.Items(j))
            Next

            txtgroupname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        'getting all voucher type that are alrready associated
        Dim sqlupdate, sqlupdateventry, sqlacchead As String
        'listing all voucher type
        Dim i As Integer, vtype As String

        Dim sql As String
        sql = "select * from Groups where cmp_id='" & GMod.Cmpid & "' and suffix='" & txtgroupsfx.Text & "' and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "sufixchk")

        If GMod.ds.Tables("sufixchk").Rows.Count > 0 Then
            MsgBox("Suffix aredy created...")
            Exit Sub
        End If

        If chkall.Checked = True Then
            vtype = "All"
        Else
            For i = 0 To Me.listeffectsin.Items.Count - 1
                vtype = vtype & "," & listeffectsin.Items(i)
            Next
        End If


        sqlupdate = " update Groups set "
        sqlupdate &= " Group_name=" & "'" & txtgroupname.Text & "',"
        sqlupdate &= " Suffix=" & "'" & txtgroupsfx.Text & "',"
        sqlupdate &= " BS_PL=" & "'" & cmbbs_pl.Text & "',"
        sqlupdate &= " Dr_Cr=" & "'" & cmbdr_cr.Text & "',"
        sqlupdate &= " EffectsIN=" & "'" & vtype & "'"
        sqlupdate &= " where  Group_name=" & "'" & dggroups(0, rowidx).Value & "' and Cmp_id='" & GMod.Cmpid & "'"

        sqlupdateventry = "update " & GMod.VENTRY & " set Group_name='" & txtgroupname.Text & "' where  " _
                            & " Group_name='" & dggroups(0, rowidx).Value & "' and Cmp_id='" & GMod.Cmpid & "'"


        sqlacchead = "update " & GMod.ACC_HEAD & " set Group_name='" & txtgroupname.Text & "' where  " _
                                 & " Group_name='" & dggroups(0, rowidx).Value & "' and Cmp_id='" & GMod.Cmpid & "'"


        Dim sqltrans As SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction
        Dim cmd1 As New SqlCommand(sqlupdate, GMod.SqlConn, sqltrans)
        Dim cmd2 As New SqlCommand(sqlupdateventry, GMod.SqlConn, sqltrans)
        Dim cmd3 As New SqlCommand(sqlacchead, GMod.SqlConn, sqltrans)
        Try
            If btnsave.Enabled Then
                MsgBox("Please double click on the Company name to select", MsgBoxStyle.Critical)
            Else
                If txtgroupname.Text = "" Or cmbbs_pl.Text = "" Then
                    MsgBox("Group name is necessary", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If MessageBox.Show("Are u sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    cmd1.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()
                    sqltrans.Commit()
                    fillgrid()
                    btnreset_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            sqltrans.Commit()
            If ex.Message.Contains("PRIMARY KEY") Then
                MsgBox("GROUP ALREADY EXISTS", MsgBoxStyle.Critical)
            Else
                MsgBox("Error" & ex.Message)
            End If
            MsgBox(ex.Message)
            btnreset_Click(sender, e)
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim sqldelete As String, sqlresult As String
        sqldelete = "delete from Groups "
        sqldelete &= " where  Group_name=" & "'" & dggroups(0, rowidx).Value & "' and Cmp_id='" & GMod.Cmpid & "'"
        If btnsave.Enabled Then
            MsgBox("Please double click on the Company name to select", MsgBoxStyle.Critical)
        Else
            If txtgroupname.Text = "" Or cmbbs_pl.Text = "" Then
                MsgBox("Group nameis necessary", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If MessageBox.Show("Are u sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                GMod.DataSetRet("select * from sub_group where group_name='" & txtgroupname.Text & "' AND SESSION ='" & GMod.Session & "'", "ser")
                If GMod.ds.Tables("ser").Rows.Count > 0 Then
                    MsgBox("Can not delete company. There are some sub group", MsgBoxStyle.Critical, "Error")
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
        Me.Close()
    End Sub

    Private Sub txtgroupname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgroupname.Leave
        If txtgroupname.Text.Length > 0 Then
            txtgroupsfx.Text = txtgroupname.Text.Substring(0, 2).ToUpper
            txtgroupname.Text = txtgroupname.Text.ToUpper
            gprefix = txtgroupname.Text.Substring(0, 3).ToUpper
        End If
    End Sub

    Private Sub txtgroupname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgroupname.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtgroupsfx.Focus()
        End If
    End Sub

    Private Sub txtgroupsfx_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgroupsfx.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbbs_pl.Focus()
        End If
    End Sub

    Private Sub cmbbs_pl_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbs_pl.KeyUp
        If e.KeyCode = Keys.Enter Then
            If btnsave.Enabled = True Then
                btnsave.Focus()
            Else
                btnmodify.Focus()
            End If
        End If
    End Sub

    Private Sub btnmodify_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnmodify.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnmodify.Focus()
        End If
    End Sub

    Private Sub btndelete_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btndelete.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnreset.Focus()
        End If
    End Sub

    Private Sub btnreset_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnreset.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnclose.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnallot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallot.Click
        Dim i As Integer
        Dim cp As String
        For i = 0 To Me.listremvtype.SelectedItems.Count - 1
            cp = Me.listremvtype.GetItemText(listremvtype.SelectedItems(listremvtype.SelectedItems.Count - 1))
            Me.listeffectsin.Items.Add(cp)
            listremvtype.Items.Remove(cp)
        Next
    End Sub

    Private Sub chkall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkall.Click
        If chkall.Checked = False Then
            Me.listremvtype.Enabled = True
            Me.listeffectsin.Enabled = True
        Else
            Me.listremvtype.Enabled = False
            Me.listeffectsin.Enabled = False
        End If
    End Sub

    Private Sub txtgroupsfx_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgroupsfx.Leave
        gprefix = txtgroupsfx.Text
        txtgroupsfx.Text = gprefix
    End Sub

    Private Sub dggroups_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dggroups.CellContentClick

    End Sub

    Private Sub txtgroupname_TextChanged(sender As Object, e As EventArgs) Handles txtgroupname.TextChanged

    End Sub

    Private Sub txtgroupsfx_TextChanged(sender As Object, e As EventArgs) Handles txtgroupsfx.TextChanged

    End Sub
End Class