Public Class frmMortalityRep
    Dim sql As String = ""
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        sql = "select * from printdata where session ='" & GMod.Session & "' and cmp_id='PHHA' and vou_type='SALE BR' and hatchdate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' order by hatchdate "
        GMod.DataSetRet(sql, "mortality")
        Dim mrcr As New CrMortalityRep
        mrcr.SetDataSource(GMod.ds.Tables("mortality"))
        mrcr.SetParameterValue("p1", "Hatch Date from :" & dtfrom.Text & " to " & dtto.Text)
        CrystalReportViewer1.ReportSource = mrcr

    End Sub
End Class