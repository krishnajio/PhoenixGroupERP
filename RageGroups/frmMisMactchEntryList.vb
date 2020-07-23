Public Class frmMisMactchEntryList

    Private Sub frmMisMactchEntryList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdname_Click(sender, e)
    End Sub
    Private Sub rdname_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdname.Click
        If GMod.Cmpid = "PHCH" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")

            sql = "select * from dbo.InvPhxChicken  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name) order by cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
        ElseIf GMod.Cmpid = "PHHA" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")

            sql = "select * from PrintData v where session='" & GMod.Session & "' and Cmp_id='" & GMod.Cmpid & "' and AccName not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.AccName=a.account_head_name) order by cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
        ElseIf GMod.Cmpid = "PHOE" Or GMod.Cmpid = "PHPO" Or GMod.Cmpid = "JAHA" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")

            sql = "select * from PrintData v where session='" & GMod.Session & "' and Cmp_id='" & GMod.Cmpid & "' and AccName not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.AccName=a.account_head_name) order by cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
        ElseIf GMod.Cmpid = "PHFE" Or GMod.Cmpid = "PHFA" Or GMod.Cmpid = "PHBU" Or GMod.Cmpid = "PHLU" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")

            sql = "select * from " & GMod.INVENTORY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name) order by cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
        ElseIf GMod.Cmpid = "LWMI" Or GMod.Cmpid = "LWSS" Or GMod.Cmpid = "SHVI" Or GMod.Cmpid = "SMAN" Or GMod.Cmpid = "SMAN" Or GMod.Cmpid = "PHAG" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")

        End If
    End Sub

    Private Sub rdcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdcode.CheckedChanged

    End Sub

    Private Sub rdcode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdcode.Enter
        If GMod.Cmpid = "PHCH" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")

            sql = "select * from dbo.InvPhxChicken  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name) order by cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
        ElseIf GMod.Cmpid = "PHHA" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")

            sql = "select * from PrintData v where session='" & GMod.Session & "' and Cmp_id='" & GMod.Cmpid & "' and AccName not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.AccName=a.account_head_name) order by cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
        ElseIf GMod.Cmpid = "PHOE" Or GMod.Cmpid = "PHPO" Or GMod.Cmpid = "JAHA" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")

            sql = "select * from PrintData v where session='" & GMod.Session & "' and Cmp_id='" & GMod.Cmpid & "' and AccName not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.AccName=a.account_head_name) order by cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
        ElseIf GMod.Cmpid = "PHFE" Or GMod.Cmpid = "PHFA" Or GMod.Cmpid = "PHBR" Or GMod.Cmpid = "PHLU" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head_code not in ( select account_code from " & GMod.ACC_HEAD & " a  where   v.Acc_head_code=a.account_code)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")

            sql = "select * from " & GMod.INVENTORY & "  v where Acc_head_code not in ( select account_code from " & GMod.ACC_HEAD & " a  where   v.Acc_head_code=a.account_code) order by cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
            dgInventory.DataSource = GMod.ds.Tables("inv")
        ElseIf GMod.Cmpid = "LWMI" Or GMod.Cmpid = "LWSS" Or GMod.Cmpid = "SHVI" Or GMod.Cmpid = "SMAN" Or GMod.Cmpid = "SMAN" Or GMod.Cmpid = "PHAG" Then
            Dim sql As String
            sql = "select * from " & GMod.VENTRY & "  v where Acc_head not in ( select account_head_name from " & GMod.ACC_HEAD & " a  where   v.Acc_head=a.account_head_name)"
            GMod.DataSetRet(sql, "ventry")
            dgVentry.DataSource = GMod.ds.Tables("ventry")
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If GMod.Cmpid = "PHOE" Then
            Dim sql, up As String
            sql = "select * from " & GMod.VENTRY & " where vou_type='SALE' and vou_no='" & txtVouno.Text & "' and dramt>0"
            GMod.DataSetRet(sql, "values")

            'up = "update InvPhxChicken set Acc_head_code='" & GMod.ds.Tables("values").Rows(0)("Acc_head_code") & "',Acc_head='" & GMod.ds.Tables("values").Rows(0)("Acc_head") & "'  where vou_type='PURCHASE' and vou_no='" & txtVouno.Text & "'"
            up = "update printdata set AccCode='" & GMod.ds.Tables("values").Rows(0)("Acc_head_code") & "',AccName='" & GMod.ds.Tables("values").Rows(0)("Acc_head") & "'  where vou_type='SALE' and vou_no='" & txtVouno.Text & "' and cmp_id='" & GMod.Cmpid & "'"

            MsgBox(GMod.SqlExecuteNonQuery(up))
            txtVouno.Focus()
            txtVouno.SelectAll()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String, i As Integer
        Dim update1 As String, up2 As String
        ' sql = "select * from printdata where cmp_id='WEPH' order by vou_no"
        sql = "select distinct vou_no from  dbo.VENTRY_WEPH_0809 where vou_type='CR VOUCHER' order by vou_no"
        GMod.DataSetRet(sql, "xx")
        For i = 0 To GMod.ds.Tables("xx").Rows.Count - 1
            GMod.SqlExecuteNonQuery("update " & GMod.VENTRY & " set vou_no= '" & i + 1 & "' where vou_no='" & GMod.ds.Tables("xx").Rows(i)("vou_no") & "' and vou_type='CR VOUCHER'")
            'MsgBox(update1)

            'up2 = "update printdata set vou_no='" & i + 1 & "' where cmp_id='" & GMod.Cmpid & "' and session='0809'  and vou_no='" & GMod.ds.Tables("xx").Rows(i)("vou_no") & "' and vou_type='SALE'"
            'GMod.SqlExecuteNonQuery(up2)
        Next
        MsgBox("ok")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim sql As String, i As Integer
        'sql = "select distinct vou_no,hatchdate from printdata where cmp_id='PHHA' and cast(vou_no as bigint)  between 1000 and 1325 "
        'GMod.DataSetRet(sql, "xx")
        'For i = 0 To GMod.ds.Tables("xx").Rows.Count - 1
        '    sql = "update VENTRY_PHHA_0809 set vou_date='" & GMod.ds.Tables("xx").Rows(i)("hatchdate") & "' where  vou_type='SALE' and vou_no='" & GMod.ds.Tables("xx").Rows(i)("vou_no") & "'"
        '    GMod.SqlExecuteNonQuery(sql)
        'Next
        'MsgBox("done")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class