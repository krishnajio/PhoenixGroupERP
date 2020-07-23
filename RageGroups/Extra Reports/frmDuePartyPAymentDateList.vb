Public Class frmDuePartyPAymentDateList

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql As String
        ' sql = "select * from " & GMod.VENTRY & " where vou_type='" & voutype.Text & "' and group_name='PARTY' and Ch_issue_date='" & dtdate.Value.ToShortDateString & "' and Pay_mode<>'-'"
        Dim lst As String
        If listgrp.CheckedItems.Count > 0 Then
            For i = 0 To listgrp.CheckedItems.Count - 1
                lst &= "'" & listgrp.CheckedItems([i].ToString) & "',"
            Next
        End If
        lst = lst.Remove(lst.Length - 1, 1)

        sql = "select * from " & GMod.VENTRY & " where vou_type in (" & lst & ") and group_name='PARTY' and  Pay_mode<>'-' and Ch_issue_date between '" & dtdate.Value.ToShortDateString & "' and '" & DtpTo.Value.ToShortDateString & "' order by vou_type"
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
    Dim i As Integer

    Private Sub frmDuePartyPAymentDateList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  GMod.DataSetRet("select distinct vtype from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%purchase%' or vtype like '%JOURNAL%'", "vt")
        ' voutype.DataSource = GMod.ds.Tables("vt")
        'voutype.DisplayMember = "vtype"


        listgrp.Items.Clear()
        GMod.DataSetRet("select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq<>'99'  and session ='" & GMod.Session & "' order by vtype", "grp")
        For i = 0 To GMod.ds.Tables("grp").Rows.Count - 1
            listgrp.Items.Add(GMod.ds.Tables("grp").Rows(i)(0))
            listgrp.SetSelected(i, True)
        Next


    End Sub

    Private Sub btngroup_Click(sender As Object, e As EventArgs) Handles btngroup.Click
        Panel1.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.SendToBack()
    End Sub
End Class