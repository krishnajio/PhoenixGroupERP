Public Class frmCustListWithMobileNo

    Private Sub frmCustListWithMobileNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillArea()
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sql As String
        If chkmobileno.Checked = True Then
            sql = "select account_code,account_head_name,phone, address group_name from " & GMod.ACC_HEAD & " where group_name='CUSTOMER' and left(account_code,2)='" & cmbAreaCode.Text & "' and phone<>''"
            GMod.DataSetRet(sql, "MobileNO")

            Dim crmob As New CrMobileList
            crmob.SetDataSource(GMod.ds.Tables("MobileNO"))
            crmob.SetParameterValue("cmpname", GMod.Cmpname)
            crmob.SetParameterValue("area", cmbAreaName.Text)
            CrystalReportViewer1.ReportSource = crmob
        Else
            sql = "select account_code,account_head_name,phone, address group_name from " & GMod.ACC_HEAD & " where group_name='CUSTOMER' and left(account_code,2)='" & cmbAreaCode.Text & "' and phone=''"
            GMod.DataSetRet(sql, "MobileNO")

            Dim crmob As New CrMobileList
            crmob.SetDataSource(GMod.ds.Tables("MobileNO"))
            crmob.SetParameterValue("cmpname", GMod.Cmpname)
            crmob.SetParameterValue("area", cmbAreaName.Text)
            CrystalReportViewer1.ReportSource = crmob

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "select Acc_head_code,Acc_head from VENTRY_PHHA_0809  where cmp_id='PHHA' and vou_no='" & TextBox1.Text & "' and vou_type='SALE' and Group_name='CUSTOMER'"
        GMod.DataSetRet(sql, "xyz")

        sql = "update printdata set acccode='" & GMod.ds.Tables("xyz").Rows(0)("Acc_head_code").ToString.Trim & "' , accname=' " & GMod.ds.Tables("xyz").Rows(0)("Acc_head").ToString.Trim & "' where vou_no='" & TextBox1.Text & "' and cmp_id='PHHA' and session='0809'"
        MsgBox(GMod.SqlExecuteNonQuery(sql))
    End Sub
End Class