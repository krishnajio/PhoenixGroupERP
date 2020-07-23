Public Class frmMisCashReceived

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql, sqlinst, cmp, cn As String, i As Integer

        If rdCashrec.Checked = True Then

            sql = "select * from dbo.Company where cmp_id like '%P%' or cmp_id like '%J%'  and cmp_id<>'GAPO'"
            GMod.DataSetRet(Sql, "CMP")
            GMod.SqlExecuteNonQuery("delete from tmpCashRec")

            For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
                'MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date))
                If GMod.ds.Tables("CMP").Rows(i)("Cmp_id").ToString.Trim() = "PHHA" Then
                    cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Session
                    cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
                    sqlinst = "insert into tmpCashRec  select '" & cn & "','CASH RECEIVED', round(isnull(sum(cramt),0),0) cr  from " & cmp _
                    & " where vou_type in ('CR VOUCHER','BANK TRANS','CASH COLL','CR VOUCHER-TR') and group_name  in ('CUSTOMER','CASH COLL','INCOME') " _
                    & " and  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Pay_mode<>'-'"
                    GMod.SqlExecuteNonQuery(sqlinst)
                ElseIf GMod.ds.Tables("CMP").Rows(i)("Cmp_id").ToString.Trim() = "PHCH" Then

                    cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Session
                    cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
                    sqlinst = "insert into tmpCashRec  select '" & cn & "','CASH RECEIVED', round(isnull(sum(cramt),0),0) cr  from " & cmp _
                    & " where vou_type in ('CR VOUCHER','BANK TRANS','CASH COLL','CR VOUCHER-TR') and group_name  in ('CUSTOMER','CASH COLLECTION','INCOME','COLLECTION') " _
                    & " and  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Pay_mode<>'-'"
                    GMod.SqlExecuteNonQuery(sqlinst)
                Else
                    cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Session
                    cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
                    sqlinst = "insert into tmpCashRec  select '" & cn & "','CASH RECEIVED', round(isnull(sum(cramt),0),0) cr  from " & cmp _
                    & " where vou_type in ('CR VOUCHER','BANK TRANS','CASH COLL','CR VOUCHER-TR') and group_name  in ('CUSTOMER','CASH COLL','INCOME','COLLECTION') " _
                    & " and  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Pay_mode<>'-'"
                    GMod.SqlExecuteNonQuery(sqlinst)

                End If
            Next
            'delete from tmpCashRec where  cmpname= 'GAURA POULTRY FARM'
            GMod.SqlExecuteNonQuery("delete from tmpCashRec where  cmpname= 'GAURA POULTRY FARM'")
            Sql = "select * from tmpCashRec where isnull(amt,0)<>0"
            GMod.DataSetRet(Sql, "tmpChqRep")
            Dim r As New CrCashReceived
            r.SetDataSource(GMod.ds.Tables("tmpChqRep"))
            ' r.SetParameterValue("subhead", "Over Amount :" & txtamt.Text)
            r.SetParameterValue("subhead1", "Date from :" & dtfrom.Text & " to " & dtTo.Text)
            r.SetParameterValue("p1", "Received")

            CrViewerGenralLedger.ReportSource = r

        ElseIf rdcashpayment.Checked = True Then

            sql = "select * from dbo.Company where cmp_id like '%P%' or cmp_id like '%J%'  and cmp_id<>'GAPO'"
            GMod.DataSetRet(sql, "CMP")
            GMod.SqlExecuteNonQuery("delete from tmpCashRec")

            For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
                'MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date))
                cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Session
                cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
                sqlinst = "insert into tmpCashRec  select '" & cn & "','BANK PAYMENT', round(isnull(sum(cramt),0),0) cr  from " & cmp _
                & " where vou_type in ('BANK')   and group_name not in ('INTERNAL PARTY') and left(acc_head_code,4)='**BA' " _
                & " and  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                GMod.SqlExecuteNonQuery(sqlinst)

                cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Session
                cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
                sqlinst = "insert into tmpCashRec  select '" & cn & "','CASH PAYMENT', round(isnull(sum(dramt),0),0) cr  from " & cmp _
                & " where vou_type in ('CASH')  and group_name not in ('BANK','INTERNAL PARTY')" _
                & " and  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Pay_mode<>'-'"
                GMod.SqlExecuteNonQuery(sqlinst)

                'delete from tmpCashRec where  cmpname= 'GAURA POULTRY FARM'

            Next
            GMod.SqlExecuteNonQuery("delete from tmpCashRec where  cmpname= 'GAURA POULTRY FARM'")
            sql = "select * from tmpCashRec where isnull(amt,0)<>0"
            GMod.DataSetRet(sql, "tmpChqRep")
            Dim r As New CrCashReceived
            r.SetDataSource(GMod.ds.Tables("tmpChqRep"))
            ' r.SetParameterValue("subhead", "Over Amount :" & txtamt.Text)
            r.SetParameterValue("subhead1", "Date from :" & dtfrom.Text & " to " & dtTo.Text)
            r.SetParameterValue("p1", "Payment")

            CrViewerGenralLedger.ReportSource = r
         
        End If
    End Sub

    Private Sub frmMisCashReceived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class