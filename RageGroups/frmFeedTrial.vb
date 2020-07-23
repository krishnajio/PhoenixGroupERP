Public Class frmFeedTrial

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        GMod.SqlExecuteNonQuery("delete from tmpTrial where Uname='" & GMod.username & "'")
        Dim sql As String
        sql = " insert into tmpTrial(account_code, account_head_name, dr,uname) SELECT Acc_head_code,Acc_head + '  ' + Itemname, sum(amount),'" & GMod.username & "' from  " & GMod.INVENTORY _
               & " where vou_type='PURCHASE' and  vou_date <= '" & dtfrom.Value.ToShortDateString & "'" _
                & " group by Acc_head_code,Acc_head,ItemName  order by Acc_head "
        MsgBox(GMod.SqlExecuteNonQuery(sql))

        Dim r As New CrTrial
        Dim sqlseelct As String
        Dim param As String = ""
        sqlseelct = "select account_code, account_head_name, dr,cr from  tmpTrial where uname='" & GMod.username & "'"
        GMod.DataSetRet(sqlseelct, "trialall")
        r.SetDataSource(GMod.ds.Tables("trialall"))
        r.SetParameterValue("cmpname", GMod.Cmpname)
        r.SetParameterValue("subhead", "Trial Balance as on " & dtfrom.Text)
        r.SetParameterValue("subhead1", param)
        r.SetParameterValue("uname", GMod.userid)

        CrViewerGenralLedger.ReportSource = r
        ' r.DataSource = GMod.ds.Tables("trialall")
    End Sub

    Private Sub frmFeedTrial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrViewerGenralLedger.Height = Me.Height - 100
    End Sub
End Class