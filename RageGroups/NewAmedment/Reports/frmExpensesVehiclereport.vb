Public Class frmExpensesVehiclereport
    Dim sql As String
    Private Sub frmExpensesVehiclereport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select distinct acc_name from Expenses_det"
        GMod.DataSetRet(sql, "vehname")
        cmbVehNo.DataSource = GMod.ds.Tables("vehname")
        cmbVehNo.DisplayMember = "acc_name"

        sql = "select distinct area from Expenses_det"
        GMod.DataSetRet(sql, "aname")
        cmbarea.DataSource = GMod.ds.Tables("aname")
        cmbarea.DisplayMember = "area"

        sql = "select distinct vou_type from Expenses_det"
        GMod.DataSetRet(sql, "vou_type")
        cmbVou_type.DataSource = GMod.ds.Tables("vou_type")
        cmbVou_type.DisplayMember = "vou_type"

    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        sql = "select * from Expenses_det where hatch_date between '" & dtpfrom.Value.ToShortDateString & "' and '" & dtpto.Value.ToShortDateString & "' and session='" & GMod.Session & "'"
        If CheckBox1.Checked = True Then
            sql &= "  and acc_name ='" & cmbVehNo.Text & "'"
        End If
        If CheckBox1.Checked = True Then
            sql &= "  and area ='" & cmbarea.Text & "'"
        End If
        sql &= " and vou_type='" & cmbVou_type.Text & "'"
        GMod.DataSetRet(sql, "dvexp")
        Dim cr As New CrDelevaryVan
        cr.SetDataSource(GMod.ds.Tables("dvexp"))

        cr.SetParameterValue("p1", GMod.Cmpname)
        cr.SetParameterValue("p2", "Hatch Date From " & dtpfrom.Text & " To " & dtpto.Text)
        cr.SetParameterValue("p3", "Session " & GMod.Session)
        cr.SetParameterValue("p4", "User Name " & GMod.username)

        CrystalReportViewer1.ReportSource = cr
    End Sub
End Class