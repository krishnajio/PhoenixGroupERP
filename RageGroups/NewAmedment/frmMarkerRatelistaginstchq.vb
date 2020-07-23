Public Class frmMarkerRatelistaginstchq

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Dim sql As String
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Try

       
            sql = "select * from chq_issue where session ='" & GMod.Session & "' and chq_no='" & txtchqno.Text & "'"
            GMod.DataSetRet(sql, "vounom")


            sql = "select * from mrktrate where session ='" & GMod.Session & "' and vou_no='" & GMod.ds.Tables("vounom").Rows(0)("vouno") & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "mktrate")


            Dim r As New CrPoratevsMarketrate
            GMod.DataSetRet(sql, "mktlist")
            r.SetDataSource(GMod.ds.Tables("mktlist"))
            r.SetParameterValue("chqno", txtchqno.Text)
            r.SetParameterValue("pname", GMod.ds.Tables("vounom").Rows(0)("favourof"))
            r.SetParameterValue("camt", GMod.ds.Tables("vounom").Rows(0)("amount"))

            CrystalReportViewer1.ReportSource = r
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class