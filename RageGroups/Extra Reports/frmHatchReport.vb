Public Class frmHatchReport

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql As String
        Dim i As Integer
        Try
            GMod.SqlExecuteNonQuery("delete from HAtchReport")
            sql = " insert into HAtchReport(InvAmount,HatchDate,AreaCode)" _
                  & " select sum(dramt),vou_date,left(Acc_head_code,2) from  printdata where vou_type='SALE'" _
                  & " and vou_date  between '" & dtfrom.Value.ToShortDateString & "' and  '" & DateTimePicker1.Value.ToShortDateString & "' group by vou_date,left(Acc_head_code,2) "
            GMod.SqlExecuteNonQuery(sql)

            GMod.DataSetRet("Select * from HAtchReport", "hr")
            For i = 0 To GMod.ds.Tables("hr").Rows.Count - 1
                'MsgBox(CDate(GMod.ds.Tables("hr").Rows(i)("HatchDate")))
                dtfrom.Value = CDate(GMod.ds.Tables("hr").Rows(i)("HatchDate"))
                sql = "select sum(cramt),right(narration,11),left(Acc_head_code,2) acode from dbo.VENTRY_PHHA_0809" _
                & " where vou_type='CR VOUCHER'  " _
                & " and isdate( right(narration,11))=1 and right(narration,4)<>'2000' and left(Acc_head_code,2)='" & GMod.ds.Tables("hr").Rows(i)("AreaCode") & "'" _
                & " and  right(narration,11) = '" & dtfrom.Text & "'" _
                & " group by right(narration,11),left(Acc_head_code,2)"
                GMod.DataSetRet(sql, "hr1")
                If GMod.ds.Tables("hr1").Rows.Count > 0 Then
                    sql = "update HAtchReport set CRAmount='" & GMod.ds.Tables("hr1").Rows(0)(0) & "' where HatchDate='" & CDate(GMod.ds.Tables("hr").Rows(i)("HatchDate")) & "' and AreaCode='" & GMod.ds.Tables("hr").Rows(i)("AreaCode") & "'"
                    GMod.SqlExecuteNonQuery(sql)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        sql = " Select * from HAtchReport where [Difference]<>0"
        GMod.DataSetRet(sql, "hrf")
        Dim cr As New CrHatchReport
        cr.SetDataSource(GMod.ds.Tables("hrf"))
        cr.SetParameterValue("cname", GMod.Cmpname)
        ' cr.SetParameterValue("subhead","On wards" &  )
        cv1.ReportSource = cr
    End Sub
End Class