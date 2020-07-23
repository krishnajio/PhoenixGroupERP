Public Class frmMISRepChqIssueToParty

    Private Sub frmMISRepChqIssueToParty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Text = Me.Text & "    [" & GMod.Cmpname & "]"
        CrViewerGenralLedger.Height = Me.Height - 195
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql, sqlinst, cmp, cn As String, i As Integer
        sql = "select * from dbo.Company where cmp_id like '%P%' or  cmp_id like '%HA%'"
        GMod.DataSetRet(sql, "CMP")
        GMod.SqlExecuteNonQuery("delete from tmpChqRep")

        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            'MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date))
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            sqlinst = "insert into tmpChqRep  select '" & cn & "',Cmp_id,Acc_head,dramt,Cheque_no from " & cmp _
                       & " where group_name='PARTY' and group_name<>'INTERNAL PARTY' and len(Cheque_no) > 1 " _
                        & " and  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                        & " and dramt >" & Val(txtamt.Text)
            GMod.SqlExecuteNonQuery(sqlinst)
        Next

        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            'MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date))
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            sqlinst = "insert into tmpChqRep  select '" & cn & "',Cmp_id,Acc_head,dramt,substring(Narration,7,patindex('%PAID%',Narration)-7) from " & cmp _
                       & " where group_name='PARTY' and group_name<>'INTERNAL PARTY' " _
                        & " and  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                        & " and  narration like '%DD.NO.%' and dramt >" & Val(txtamt.Text)
            GMod.SqlExecuteNonQuery(sqlinst)
        Next

        sql = "select * from tmpChqRep"
        GMod.DataSetRet(sql, "tmpChqRep")
        Dim r As New CRChqREP
        r.SetDataSource(GMod.ds.Tables("tmpChqRep"))
        r.SetParameterValue("subhead", "Over Amount :" & txtamt.Text)
        r.SetParameterValue("subhead1", "Date from :" & dtfrom.Text & " to " & dtTo.Text)
        CrViewerGenralLedger.ReportSource = r
    End Sub
End Class