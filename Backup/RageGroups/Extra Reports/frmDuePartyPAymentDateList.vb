Public Class frmDuePartyPAymentDateList

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql As String
        ' sql = "select * from " & GMod.VENTRY & " where vou_type='" & voutype.Text & "' and group_name='PARTY' and Ch_issue_date='" & dtdate.Value.ToShortDateString & "' and Pay_mode<>'-'"
        sql = "select * from " & GMod.VENTRY & " where vou_type='" & voutype.Text & "' and group_name='PARTY' and  Pay_mode<>'-' and Ch_issue_date between '" & dtdate.Value.ToShortDateString & "' and '" & DtpTo.Value.ToShortDateString & "'"
        GMod.DataSetRet(sql, "duedate")
        'Dim r1 As New CrDuePaymentDate
        Dim r1 As New CrDuePaymentDateN
        r1.SetDataSource(GMod.ds.Tables("duedate"))
        r1.SetParameterValue("cmpname", GMod.Cmpname)
        'r1.SetParameterValue("aa", "Due Date " & dtdate.Text)
        r1.SetParameterValue("aa", "Due Date between " & dtdate.Text & " and " & DtpTo.Text)
        r1.SetParameterValue("uid", GMod.username)

        CrystalReportViewer1.ReportSource = r1
    End Sub

    Private Sub frmDuePartyPAymentDateList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select distinct vtype from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%purchase%' or vtype like '%JOURNAL%'", "vt")
        voutype.DataSource = GMod.ds.Tables("vt")
        voutype.DisplayMember = "vtype"
    End Sub
End Class