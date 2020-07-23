Public Class frmDailyBnakPaymentRep
    Dim sql As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GMod.SqlExecuteNonQuery("DELETE FROM dailypayrep1")
        sql = "INSERT INTO dailypayrep1  SELECT distinct c.Chq_no, c.favourof, c.amount, c.Chq_date, v.Vou_date, v.Acc_head, v.Group_name, c.recpitid FROM  chq_issue AS c INNER JOIN " & GMod.VENTRY & " AS v ON c.Vouno = v.Vou_no AND c.vou_type = v.Vou_type " & _
              " AND v.cramt > 0 AND c.session='" & GMod.Session & "' and c.cmp_id='" & GMod.Cmpid & "' and amount >0 and v.group_name ='BANK'"

        GMod.SqlExecuteNonQuery(sql)
      
        Dim i As Integer
        sql = "select * from dailypayrep1 where Chq_date='" & dtfrom.Value.ToShortDateString & "' and group_name ='BANK'"
        GMod.DataSetRet(sql, "tmpdailypaymentup")

        ' Try
        On Error Resume Next
        For i = 0 To GMod.ds.Tables("tmpdailypaymentup").Rows.Count - 1
            sql = "SELECT Acc_head FROM " & GMod.VENTRY & " WHERE CHEQUE_NO='" & GMod.ds.Tables("tmpdailypaymentup").Rows(i)("chq_no") & "' AND GROUP_NAME='party'"
            GMod.DataSetRet(sql, "partyname")

            sql = "update  dailypayrep1 set favourof='" & GMod.ds.Tables("partyname").Rows(0)(0) & "'  WHERE CHQ_NO='" & GMod.ds.Tables("tmpdailypaymentup").Rows(i)("chq_no") & "'"
            GMod.SqlExecuteNonQuery(sql)
        Next

        'for updating 0 value
        sql = "select * from dailypayrep1 where Chq_date='" & dtfrom.Value.ToShortDateString & "' and group_name ='BANK' and amount=0"
        GMod.DataSetRet(sql, "tmpdailypaymentup")

        ' Try
        On Error Resume Next
        For i = 0 To GMod.ds.Tables("tmpdailypaymentup").Rows.Count - 1
            sql = "SELECT dramt FROM " & GMod.VENTRY & " WHERE CHEQUE_NO='" & GMod.ds.Tables("tmpdailypaymentup").Rows(i)("chq_no") & "' AND vou_type='BANK'"
            GMod.DataSetRet(sql, "partyname1")

            sql = "update  dailypayrep1 set amount='" & GMod.ds.Tables("partyname1").Rows(0)(0) & "'  WHERE CHQ_NO='" & GMod.ds.Tables("tmpdailypaymentup").Rows(i)("chq_no") & "'"
            GMod.SqlExecuteNonQuery(sql)
        Next

        'Catch ex As Exception
        ' MsgBox(ex.Message & sql)
        ' End Try
        If rdCashrec.Checked = True Then
            sql = "select distinct Chq_no, favourof, amount, Chq_date, Vou_date, Acc_head, Group_name, recpitid from dailypayrep1 where Chq_date='" & dtfrom.Value.ToShortDateString & "' and group_name ='BANK'"
            GMod.DataSetRet(sql, "tmpdailypayment")
            Dim r As New CrDailyPaymentRep
            r.SetDataSource(GMod.ds.Tables("tmpdailypayment"))
            CrystalReportViewer1.ReportSource = r
        Else
            sql = "select distinct Chq_no, favourof, amount, Chq_date, Vou_date, Acc_head, Group_name, recpitid from dailypayrep1 where vou_date='" & dtfrom.Value.ToShortDateString & "' and group_name ='BANK'"
            GMod.DataSetRet(sql, "tmpdailypayment")
            Dim r As New CrDailyPaymentRep
            r.SetDataSource(GMod.ds.Tables("tmpdailypayment"))
            CrystalReportViewer1.ReportSource = r
        End If
    End Sub

    Private Sub rdCashrec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdCashrec.CheckedChanged

    End Sub
End Class