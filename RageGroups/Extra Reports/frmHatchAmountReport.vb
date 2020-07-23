Public Class frmHatchAmountReport

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql, up As String
        Dim i As Integer




        GMod.SqlExecuteNonQuery("delete from tmpTrial4date")
        sql = "insert into tmpTrial4date(account_code, account_head_name) select * from Area"
        GMod.SqlExecuteNonQuery(sql)
        GMod.DataSetRet("select account_code, account_head_name from tmpTrial4date", "Area")
        For i = 0 To GMod.ds.Tables("Area").Rows.Count - 1
            'Invoice Amount
            sql = "select isnull(sum(dramt),0) from dbo.VENTRY_PHHA_0809 where vou_type='SALE' and dramt>0 " _
            & " and left(Acc_head_code,2)='" & GMod.ds.Tables("Area").Rows(i)("account_head_name") & "' and vou_date between '" & dtfrom.Value.ToShortDateString & "' and  '" & dtfrom.Value.ToShortDateString & "'"
            GMod.DataSetRet(sql, "xx")
            up = "update tmpTrial4date set odr=" & GMod.ds.Tables("xx").Rows(0)(0) & " where account_head_name='" & GMod.ds.Tables("Area").Rows(i)("account_head_name") & "'"
            GMod.SqlExecuteNonQuery(up)



            'Amount Recieved
            sql = " select isnull(sum(cramt),0) from VENTRY_PHHA_0809 where " _
                & " vou_type in ('CR VOUCHER','BANK TRANS') and " _
                & " group_name not in ('INTERNAL PARTY','COLLECTION')" _
                & " and  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtfrom.Value.AddDays(TextBox1.Text).ToShortDateString & "'  and  left(Acc_head_code,2)='" & GMod.ds.Tables("Area").Rows(i)("account_head_name") & "'" _
                & " and Acc_head_code in ( select Acc_head_code from dbo.VENTRY_PHHA_0809 where vou_type='SALE' and dramt>0 " _
                & " and left(Acc_head_code,2)='" & GMod.ds.Tables("Area").Rows(i)("account_head_name") & "' and vou_date between '" & dtfrom.Value.ToShortDateString & "' and  '" & dtfrom.Value.ToShortDateString & "' ) "

            GMod.DataSetRet(sql, "yy")
            up = "update tmpTrial4date set ocr=" & GMod.ds.Tables("yy").Rows(0)(0) & " where account_head_name='" & GMod.ds.Tables("Area").Rows(i)("account_head_name") & "'"
            GMod.SqlExecuteNonQuery(up)

        Next

        cv1.Height = Me.Height - 100

        Dim cr As New c2
        sql = "select * from tmpTrial4date where ocr>0 and odr>0"
        GMod.DataSetRet(sql, "ab")
        sql = "Hatch From " & dtfrom.Text
        cr.SetDataSource(GMod.ds.Tables("ab"))
        sql = "Hatch Date " & dtfrom.Text
        cr.SetParameterValue("s", sql)
        cr.SetParameterValue("cmp", GMod.Cmpname)
        cv1.ReportSource = cr

    End Sub

    Private Sub cv1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cv1.Load

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub dtfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfrom.ValueChanged

    End Sub
End Class