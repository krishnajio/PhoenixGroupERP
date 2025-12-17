Public Class frmScheduleReport
    Dim sql As String
    Private Sub frmScheduleReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql = "select distinct Chick_type from AreaDemandData order by Chick_type"
        GMod.DataSetRet(Sql, "prd1")

        cmbChickType.DataSource = GMod.ds.Tables("prd1")
        cmbChickType.DisplayMember = "Chick_type"
        'cmbcode.DataSource = GMod.ds.Tables("areafillhead")
        'cmbcode.DisplayMember = "prefix"


        'FILLING HATCHERYIES
        Sql = "select Hatcheryies from Hatcheries where active=1"
        GMod.DataSetRet(Sql, "Hatcheryies")

        cmbhatchery.DataSource = GMod.ds.Tables("Hatcheryies")
        cmbhatchery.DisplayMember = "Hatcheryies"
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        If CheckBox1.Checked = False Then

            Sql = "select * from V_ScheduleRepo  where hatchery='" & cmbhatchery.Text & "' and hatch_date='" & dtHdatedate.Value.ToShortDateString & "' and productname='" & cmbChickType.Text & "'"
            GMod.DataSetRet(Sql, "hatrep")
        Else
            Sql = "select * from V_ScheduleRepo  where hatch_date='" & dtHdatedate.Value.ToShortDateString & "' and productname='" & cmbChickType.Text & "'"
            GMod.DataSetRet(Sql, "hatrep")
        End If
        Dim cr As New CrRepSchedule
        cr.SetDataSource(GMod.ds.Tables("hatrep"))
        cr.SetParameterValue("hdate", dtHdatedate.Text)
        cr.SetParameterValue("ctype", cmbChickType.Text)
        cr.SetParameterValue("Note", txtNote.Text)
        CrystalReportViewer1.ReportSource = cr
    End Sub
End Class