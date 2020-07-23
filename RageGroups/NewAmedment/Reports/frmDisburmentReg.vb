Public Class frmDisburmentReg

    Dim sql As String
    Private Sub frmPurRepQtyMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' sql = "select  account_type  + '#' + account_head_name act from acc_head_phoe_1718 where group_name ='party' and len(account_type)>=15 union select 'ALL'  act from acc_head_phoe_1718"
        sql = "select distinct CrCode,Crhead from Disburreg where  collecRec>0"
        GMod.DataSetRet(sql, "_collhead")
        cmbhead.DataSource = GMod.ds.Tables("_collhead")
        cmbhead.DisplayMember = "Crhead"

        cmbcode.DataSource = GMod.ds.Tables("_collhead")
        cmbcode.DisplayMember = "CrCode"

        '  cmbprdunit.Text = ""
        'GMod.DataSetRet("select vtype from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%PUR%'", "vtpm")
        'cmbvou_type.DataSource = GMod.ds.Tables("vtpm")
        'cmbvou_type.DisplayMember = "vtype"
    End Sub
    Dim p2, p3, p4, p5 As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            sql = "select * from DisburReg"
        Else
            sql = "select * from DisburReg "
        End If

        If CheckBox2.Checked = True Then
            sql = sql & " where hatchdate between '" & d1.Value.ToShortDateString & "' and '" & d2.Value.ToShortDateString & "' and session ='" & GMod.Session & "'"
        End If
        GMod.DataSetRet(sql, "DisReg")
        Dim r As New CrDisburReg
        r.SetDataSource(GMod.ds.Tables("DisReg"))
        'r.SetParameterValue("p7", GMod.username)
        'r.SetParameterValue("p8", 0)
        CrystalReportViewer1.ReportSource = r
    End Sub
End Class