Public Class frmHeadDataTransfereToAnotherHead

    Private Sub frmHeadDataTransfereToAnotherHead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "'", "grp")
        cmbgrpname.DataSource = GMod.ds.Tables("grp")
        cmbgrpname.DisplayMember = "group_name"
        cmbgrpname_SelectedIndexChanged(sender, e)

        Me.Text = GMod.Cmpname
        'Dim sql As String
        'sql = "select account_code,account_head_name,group_name,sub_group_name,opening_dr,opening_cr from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
        '       & " order by account_head_name"
        'GMod.DataSetRet(sql, "acchead")


        'cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
        'cmbacheadcode.DisplayMember = "account_code"

        'cmbacheadname.DataSource = GMod.ds.Tables("acchead")
        'cmbacheadname.DisplayMember = "account_head_name"

        'cmbgrpname.DataSource = GMod.ds.Tables("acchead")
        'cmbgrpname.DisplayMember = "group_name"

        'cmbsubgrpname.DataSource = GMod.ds.Tables("acchead")
        'cmbsubgrpname.DisplayMember = "sub_group_name"

        'dr.DataSource = GMod.ds.Tables("acchead")
        'dr.DisplayMember = "opening_dr"

        'cr.DataSource = GMod.ds.Tables("acchead")
        'cr.DisplayMember = "opening_cr"

        ''To
        'GMod.DataSetRet(sql, "accheadto")

        'GMod.DataSetRet(sql, "accheadto")
        'cmbaccto.DataSource = GMod.ds.Tables("accheadto")
        'cmbaccto.DisplayMember = "account_head_name"

        'cmbcodeto.DataSource = GMod.ds.Tables("accheadto")
        'cmbcodeto.DisplayMember = "account_code"

        'cmbgrpto.DataSource = GMod.ds.Tables("accheadto")
        'cmbgrpto.DisplayMember = "group_name"


        'cmbsubto.DataSource = GMod.ds.Tables("accheadto")
        'cmbsubto.DisplayMember = "sub_group_name"
      

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Are u Sure", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim updateventery, sqlres, upPrintdata As String
            updateventery = "update " & GMod.VENTRY & ""
            updateventery &= " set Acc_head_code ='" & cmbcodeto.Text & "',"
            updateventery &= " Acc_head='" & cmbaccto.Text & "',"
            updateventery &= " Group_name='" & cmbgrpname.Text & "',"
            updateventery &= " Sub_group_name='" & cmbsubgrpname.Text & "'"
            updateventery &= " where Acc_head_code ='" & cmbacheadcode.Text & "'"
            sqlres = GMod.SqlExecuteNonQuery(updateventery)

            If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "PHOE" Or GMod.Cmpid = "JAHA" Or GMod.Cmpid = "PHPO" Then
                'Updatin in PrintDataTAbe
                upPrintdata = "update PrintData set AccName='" & cmbaccto.Text & "' , AccCode='" & cmbcodeto.Text & "' where  AccCode='" & cmbacheadcode.Text & "' and Cmp_id = '" & GMod.Cmpid & "' and session='" & GMod.Getsession(DateAndTime.Now) & "'"
                sqlres = GMod.SqlExecuteNonQuery(upPrintdata)
                'MsgBox(sqlres)
            ElseIf GMod.Cmpid = "PHCH" Then
                Dim UpChi As String
                UpChi = "update InvPhxChicken set Acc_head='" & cmbaccto.Text & "',Acc_head_code='" & cmbcodeto.Text & "' where  Acc_head_code='" & cmbacheadcode.Text & "' and Cmp_id = '" & GMod.Cmpid & "'"
                sqlres = GMod.SqlExecuteNonQuery(UpChi)
            Else
                Dim UpInv As String
                UpInv = "update " & GMod.INVENTORY & ""
                UpInv &= " set Acc_head_code ='" & cmbaccto.Text & "',"
                UpInv &= " Acc_head='" & cmbcodeto.Text & "'"
                UpInv &= " where Acc_head_code ='" & cmbacheadcode.Text & "'"
                sqlres = GMod.SqlExecuteNonQuery(UpInv)
            End If


            Fill_Log_Head(GMod.Cmpid, cmbaccto.Text, cmbcodeto.Text, Now, GMod.Session, "T", GMod.username)

            If MessageBox.Show("Do you want to Delete eMPTY  Head", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                MsgBox(GMod.SqlExecuteNonQuery("delete from " & GMod.ACC_HEAD & " where account_code= '" & cmbacheadcode.Text & "'"))
            Else
                MsgBox("Left the head.")
            End If
        End If
    End Sub

    Private Sub cmbsubgrpname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbsubgrpname.Leave

      

    End Sub

    Private Sub cmbsubgrpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubgrpname.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbgrpname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgrpname.Leave
        cmbgrpname.Enabled = False
    End Sub

    Private Sub cmbgrpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrpname.SelectedIndexChanged
        GMod.DataSetRet("select * from sub_group where group_name='" & cmbgrpname.Text & "' and  cmp_id='" & GMod.Cmpid & "'", "sgrp")
        cmbsubgrpname.DataSource = GMod.ds.Tables("sgrp")
        cmbsubgrpname.DisplayMember = "sub_group_name"

        Dim sql As String
        sql = "select account_code,account_head_name,opening_dr,opening_cr from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
               & " and group_name = '" & cmbgrpname.Text & "'"
        GMod.DataSetRet(sql, "acchead")
        cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
        cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("acchead")
        cmbacheadname.DisplayMember = "account_head_name"

        dr.DataSource = GMod.ds.Tables("acchead")
        dr.DisplayMember = "opening_dr"

        cr.DataSource = GMod.ds.Tables("acchead")
        cr.DisplayMember = "opening_cr"

        GMod.DataSetRet(sql, "accheadto")

        GMod.DataSetRet(sql, "accheadto")
        cmbaccto.DataSource = GMod.ds.Tables("accheadto")
        cmbaccto.DisplayMember = "account_head_name"

        cmbcodeto.DataSource = GMod.ds.Tables("accheadto")
        cmbcodeto.DisplayMember = "account_code"


        drTo.DataSource = GMod.ds.Tables("accheadto")
        drTo.DisplayMember = "opening_dr"

        crTo.DataSource = GMod.ds.Tables("accheadto")
        crTo.DisplayMember = "opening_cr"

    End Sub

    Private Sub cmbacheadname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadname.SelectedIndexChanged

    End Sub

    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged

    End Sub

    Private Sub cmbaccto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaccto.SelectedIndexChanged

    End Sub

    Private Sub cmbcodeto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcodeto.SelectedIndexChanged

    End Sub

    Private Sub drTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drTo.SelectedIndexChanged

    End Sub

    Private Sub crTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crTo.SelectedIndexChanged

    End Sub
End Class