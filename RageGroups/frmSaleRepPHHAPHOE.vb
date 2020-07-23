Public Class frmSaleRepPHHAPHOE

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cr As New CrSaleRepRHHAPHOE
        CrystalReportViewer1.Height = Me.Height - 100
        If GMod.Cmpid = "PHHA" Then
            Dim sql As String = "Select * from SaleRepFinal where Cmp_id='" & GMod.Cmpid & "'" _
                  & " and ProductName not in ('N.E.E.C AMOUNT','DISCOUNT AMOUNT') and HatchDate between '" & dtHatchDate.Value.ToShortDateString & "' and '" & DateTimePicker1.Value.ToShortDateString & "' order by AreaCode"
            GMod.DataSetRet(sql, "SALE")
            cr.SetDataSource(GMod.ds.Tables("SALE"))
            cr.SetParameterValue("cmpName", GMod.Cmpname)
            cr.SetParameterValue("subhead", "Date from :" & dtHatchDate.Text & " to " & DateTimePicker1.Text)
            CrystalReportViewer1.ReportSource = cr
        ElseIf GMod.Cmpid = "PHOE" Then
            'Dim sql As String = "Select * from SaleRepFinal where Cmp_id='" & GMod.Cmpid & "'" _
            '                & " and HatchDate between '" & dtHatchDate.Value.ToShortDateString & "' and '" & DateTimePicker1.Value.ToShortDateString & "' order by AreaCode"
            'GMod.DataSetRet(sql, "SALE")
            'cr.SetDataSource(GMod.ds.Tables("SALE"))
            'cr.SetParameterValue("cmpName", GMod.Cmpname)
            'cr.SetParameterValue("subhead", "Date from :" & dtHatchDate.Text & " to " & DateTimePicker1.Text)
            'CrystalReportViewer1.ReportSource = cr
        End If
    End Sub
    Private Sub frmSaleRepPHHAPHOE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class