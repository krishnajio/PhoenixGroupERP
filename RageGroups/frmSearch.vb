Public Class frmSearch
    Dim sql As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'sql = "select * from dbo.VENTRY_PHHA_0809 where narration like '%TR NO. 32#%'"
        If txtTRNO.Text <> "" Then
            sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date , Acc_head_code, Acc_head, Narration, dramt, cramt, " _
                        & " Group_name from  " & GMod.VENTRY & " where narration like '%TR NO. " & txtTRNO.Text & "#%' and Pay_mode<>'-'"
            GMod.DataSetRet(sql, "CVD")
            DataGridView1.DataSource = GMod.ds.Tables("CVD")
        ElseIf txtBillNO.Text <> "" Then
            sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date , Acc_head_code, Acc_head, Narration, dramt, cramt, " _
                        & " Group_name from  " & GMod.VENTRY & " where narration like '%BILL NO." & txtBillNO.Text & "%' and Pay_mode<>'-'"
            GMod.DataSetRet(sql, "CVD")
            DataGridView1.DataSource = GMod.ds.Tables("CVD")
        ElseIf txtchqno.Text <> "" Then
            sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date , Acc_head_code, Acc_head, Narration, dramt, cramt, " _
                        & " Cheque_no from  " & GMod.VENTRY & " where cheque_no like '%" & txtchqno.Text & "' and Pay_mode<>'-'"
            GMod.DataSetRet(sql, "CVD")
            DataGridView1.DataSource = GMod.ds.Tables("CVD")
        ElseIf txtAmount.Text <> "" Then
            sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date , Acc_head_code, Acc_head, Narration, dramt, cramt, " _
                                   & " Cheque_no from  " & GMod.VENTRY & " where dramt = '" & txtAmount.Text & "' or cramt='" & txtAmount.Text & "' and Pay_mode<>'-'"
            GMod.DataSetRet(sql, "CVD")
            DataGridView1.DataSource = GMod.ds.Tables("CVD")
        ElseIf txtInvNo.Text <> "" Then
            sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date , Acc_head_code, Acc_head ,itemname,amount  " _
                                   & " Cheque_no from  " & GMod.INVENTORY & " where billno like '%" & txtchqno.Text & "' and Pay_mode<>'-'"
            GMod.DataSetRet(sql, "CVD")
            DataGridView1.DataSource = GMod.ds.Tables("CVD")
        End If
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "select AreaCode,Code,Cname,TRNo,TrAmount,Bank_det,bankdate,pay_mode,vou_type,vou_no from AreaTrData  where session ='" & GMod.Session & "' and len(vou_no)>0 order by AreaCode,id"
        GMod.DataSetRet(sql, "trdatawithbankdet")
        DataGridView1.DataSource = GMod.ds.Tables("trdatawithbankdet")
    End Sub
End Class