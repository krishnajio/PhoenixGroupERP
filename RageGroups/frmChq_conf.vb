Public Class frmChq_conf

    Private Sub frmChq_conf_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub frmChq_conf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        Try
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' order by seqorder", "vty")
            cmbvtype.DataSource = GMod.ds.Tables("vty")
            cmbvtype.DisplayMember = "vtype"


            GMod.DataSetRet("select group_name from groups where cmp_id='" & GMod.Cmpid & "'", "grp")
            cmbacgroup.DataSource = GMod.ds.Tables("grp")
            cmbacgroup.DisplayMember = "group_name"

            GMod.DataSetRet("select group_name from groups where cmp_id='" & GMod.Cmpid & "'", "grp1")
            Combo1.DataSource = GMod.ds.Tables("grp1")
            Combo1.DisplayMember = "group_name"
            GMod.DataSetRet("select * from dbo.Chq_conf where cmp_id='" & GMod.Cmpid & "'", "chk")
            If GMod.ds.Tables("chk").Rows.Count > 0 Then
                btnsave.Enabled = False
                btnmodify.Enabled = True
                cmbacgroup.Text = GMod.ds.Tables("chk").Rows(0)("group_name")
                cmbacsubgroup.Text = GMod.ds.Tables("chk").Rows(0)("sub_group_name")
                cmbacheadcode.Text = GMod.ds.Tables("chk").Rows(0)("acc_code")

                Combo1.Text = GMod.ds.Tables("chk").Rows(1)("group_name")
                Combo2.Text = GMod.ds.Tables("chk").Rows(1)("sub_group_name")
                Combo3.Text = GMod.ds.Tables("chk").Rows(1)("acc_code")

                cmbvtype.Text = GMod.ds.Tables("chk").Rows(1)("vou_type")
                lblvtype.Text = GMod.ds.Tables("chk").Rows(1)("vou_type")

            Else
                btnsave.Enabled = True
                btnmodify.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmbacgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacgroup.SelectedIndexChanged
        GMod.DataSetRet("select sub_group_name from sub_group where group_name='" & cmbacgroup.Text & "' and cmp_id='" & GMod.Cmpid & "'", "subgrp")
        cmbacsubgroup.DataSource = GMod.ds.Tables("subgrp")
        cmbacsubgroup.DisplayMember = "sub_group_name"

        cmbacsubgroup_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbacsubgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacsubgroup.SelectedIndexChanged
        If cmbacsubgroup.Text <> "" Then
            GMod.DataSetRet("select account_code, account_head_name from " & GMod.ACC_HEAD & " where group_name='" & cmbacgroup.Text & "' and sub_group_name='" & cmbacsubgroup.Text & "' and cmp_id='" & GMod.Cmpid & "' order by account_head_name", "aclist1")
        Else
            GMod.DataSetRet("select account_code, account_head_name from " & GMod.ACC_HEAD & " where group_name='" & cmbacgroup.Text & "' and cmp_id='" & GMod.Cmpid & "' order by account_head_name", "aclist1")
        End If
        cmbacheadcode.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist1")
        cmbacheadname.DisplayMember = "account_head_name"
    End Sub

    Private Sub Combo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo1.SelectedIndexChanged
        GMod.DataSetRet("select sub_group_name from sub_group where group_name='" & cmbacgroup.Text & "' and cmp_id='" & GMod.Cmpid & "'", "subgrp1")
        Combo2.DataSource = GMod.ds.Tables("subgrp1")
        Combo2.DisplayMember = "sub_group_name"
        Combo2_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Combo2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo2.SelectedIndexChanged
        If cmbacsubgroup.Text <> "" Then
            GMod.DataSetRet("select account_code, account_head_name from " & GMod.ACC_HEAD & " where group_name='" & Combo1.Text & "' and sub_group_name='" & Combo2.Text & "' and cmp_id='" & GMod.Cmpid & "' order by account_head_name", "aclist2")
        Else
            GMod.DataSetRet("select account_code, account_head_name from " & GMod.ACC_HEAD & " where group_name='" & Combo1.Text & "' and cmp_id='" & GMod.Cmpid & "' order by account_head_name", "aclist2")
        End If
        Combo3.DataSource = GMod.ds.Tables("aclist2")
        Combo3.DisplayMember = "account_code"

        Combo4.DataSource = GMod.ds.Tables("aclist2")
        Combo4.DisplayMember = "account_head_name"

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim Sqlsavestr As String
        Sqlsavestr = "Insert into Chq_conf (Cmp_id, Group_name, Sub_group_name, Acc_Code, Acc_head, Vou_type) values ("
        Sqlsavestr &= "'" & Cmpid.ToUpper & "',"
        Sqlsavestr &= "'" & cmbacgroup.Text.ToUpper & "',"
        Sqlsavestr &= "'" & cmbacsubgroup.Text.ToUpper & "',"
        Sqlsavestr &= "'" & cmbacheadcode.Text & "',"
        Sqlsavestr &= "'" & cmbacheadname.Text & "',"
        Sqlsavestr &= "'" & cmbvtype.Text & "')"
        GMod.SqlExecuteNonQuery(Sqlsavestr)

        Sqlsavestr = "Insert into Chq_conf (Cmp_id, Group_name, Sub_group_name, Acc_Code, Acc_head, Vou_type) values ("
        Sqlsavestr &= "'" & Cmpid.ToUpper & "',"
        Sqlsavestr &= "'" & Combo1.Text.ToUpper & "',"
        Sqlsavestr &= "'" & Combo2.Text.ToUpper & "',"
        Sqlsavestr &= "'" & Combo3.Text & "',"
        Sqlsavestr &= "'" & Combo4.Text & "',"
        Sqlsavestr &= "'" & cmbvtype.Text & "')"
        GMod.SqlExecuteNonQuery(Sqlsavestr)
        btnsave.Enabled = False
        btnmodify.Enabled = True
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        Try
            GMod.SqlExecuteNonQuery("delete from chq_conf where vou_type='" & lblvtype.Text & "'")
            btnsave_Click(sender, e)
            MsgBox("Cheque Configuration Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class