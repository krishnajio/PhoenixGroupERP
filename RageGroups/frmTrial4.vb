Imports System.IO
Public Class frmTrial4

    Private Sub frmTrial2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            File.Delete("trial.txt")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CrViewerGenralLedger.Dispose()
    End Sub

    Private Sub frmTrial2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        'dtfrom.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString
        ' If GMod.role = "OPERATOR" Or GMod.role = "ADMIN" Then

        'Else

        'dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        'dtfrom.MinDate = CDate("31/3/" & Mid(GMod.Session, 1, 2)).ToShortDateString
        'End If
        Dim j As Integer
        Me.Text = "[" & GMod.Cmpname & "]" & " " & GMod.Session
        fillArea()
        GMod.DataSetRet("select distinct group_name from " & GMod.ACC_HEAD & " where  group_name not in ('PARTY','STAFF','STAFF(HO)') order by group_name", "grp")
        cmbgrpname.DataSource = GMod.ds.Tables("grp")
        cmbgrpname.DisplayMember = "group_name"
        

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

    Private Sub rdPary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPary.CheckedChanged
        If rdPary.Checked = True Then
            cmbgrpname.Text = "PARTY"
            cmbgrpname.Enabled = False

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            cmbgrpname.Text = "INTERNAL PARTY"
            cmbgrpname.Enabled = False
        End If
    End Sub

    Private Sub rdcustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdcustomer.CheckedChanged
        If rdcustomer.Checked = True Then
            cmbgrpname.Text = "CUSTOMER"
            cmbgrpname.Enabled = False
        End If
    End Sub

    Private Sub rdgeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgeneral.CheckedChanged
        If rdgeneral.Checked = True Then
            cmbgrpname.Enabled = True
        End If
    End Sub
    Dim sqlinst As String = ""
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        GMod.SqlExecuteNonQuery("delete from grp_summary")

        If rdwithopening.Checked = True Then
            sqlinst = "insert into grp_summary " _
     & "select x.account_code,x.account_head_name,isnull(x.td,0) td , isnull(x.tc,0) tc ,y.dramt,y.cramt, " _
    & "(isnull(x.td,0)+isnull(y.dramt,0)) -((isnull(x.tc,0)+isnull(y.cramt,0))) " _
    & "Closing,y.group_name,'" & GMod.username & "','" & GMod.Cmpid & "' from (select q.account_code,q.account_head_name,q.group_name,  " _
    & "DrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 " _
    & "then  (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end, " _
     & "CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0 " _
    & "then   abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) " _
    & " else 0 end ,p.dramt td ,p.cramt tc  from " _
    & "((select acc_head_code, isnull(sum( isnull(dramt,0)),0) dramt " _
     & ",isnull(sum(isnull(cramt,0)),0) cramt from  " & GMod.VENTRY & "  " _
     & "where  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Pay_mode<>'-' group by acc_head_code) p  " _
    & "right join ( select Account_code,account_head_name,group_name,  " _
    & "isnull(opening_dr,0) odr ,isnull(opening_cr,0) ocr " _
    & "from " & GMod.ACC_HEAD & ") q on q.account_code=p.acc_head_code ) ) x  " _
     & " Left Join(select q.account_code,q.account_head_name,q.group_name,DrAmt = case when  " _
    & " ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 then " _
     & " (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end," _
    & " CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) " _
     & " < 0 then   abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) " _
    & " else 0 end from ( (select acc_head_code, isnull(sum(dramt),0) dramt ," _
    & " isnull(sum(cramt),0) cramt from " & GMod.VENTRY & " where vou_date <'" & dtfrom.Value.ToShortDateString & "'" _
     & " group by acc_head_code)p right join ( select account_code,account_head_name,group_name,isnull(opening_dr,0) " _
     & " odr ,isnull(opening_cr,0) ocr   from " & GMod.ACC_HEAD & " ) q on q.account_code=p.acc_head_code)) y on x.account_code = y.account_code   "

            GMod.SqlExecuteNonQuery(sqlinst)

        Else

            sqlinst = "insert into grp_summary " _
     & "select x.account_code,x.account_head_name,x.td,x.tc,0,0, " _
    & "(isnull(x.td,0)) -(isnull(x.tc,0)) " _
    & "Closing,y.group_name,'" & GMod.username & "','" & GMod.Cmpid & "' from (select q.account_code,q.account_head_name,q.group_name,  " _
    & "DrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 " _
    & "then  (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end, " _
     & "CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0 " _
    & "then   abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) " _
    & " else 0 end ,p.dramt td ,p.cramt tc  from " _
    & "((select acc_head_code, isnull(sum( isnull(dramt,0)),0) dramt " _
     & ",isnull(sum(isnull(cramt,0)),0) cramt from  " & GMod.VENTRY & "  " _
     & "where  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Pay_mode<>'-' group by acc_head_code) p  " _
    & "right join ( select Account_code,account_head_name,group_name,  " _
    & "isnull(opening_dr,0) odr ,isnull(opening_cr,0) ocr " _
    & "from " & GMod.ACC_HEAD & ") q on q.account_code=p.acc_head_code ) ) x  " _
     & " Left Join(select q.account_code,q.account_head_name,q.group_name,DrAmt = case when  " _
    & " ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 then " _
     & " (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end," _
    & " CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) " _
     & " < 0 then   abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) " _
    & " else 0 end from ( (select acc_head_code, isnull(sum(dramt),0) dramt ," _
    & " isnull(sum(cramt),0) cramt from " & GMod.VENTRY & " where vou_date <'" & dtfrom.Value.ToShortDateString & "'" _
     & " group by acc_head_code)p right join ( select account_code,account_head_name,group_name,isnull(opening_dr,0) " _
     & " odr ,isnull(opening_cr,0) ocr   from " & GMod.ACC_HEAD & " ) q on q.account_code=p.acc_head_code)) y on x.account_code = y.account_code   "

            GMod.SqlExecuteNonQuery(sqlinst)

        End If

        'deleting record which has transaction cr/dr null

        GMod.SqlExecuteNonQuery("delete from grp_summary where (td is null) and (td is null)")
        If chkallgengrps.Checked = True Then
            AllGroup()
        Else
            GroupWise()
        End If

        If CheckBox1.Checked = True Then
            subgrp()
        End If

        Dim param As String
        If chkallgengrps.Checked = True Then
            param = "ALL GENERAL GROUPS"
        Else
            param = "GROUP/SUB GROUP: " & cmbgrpname.Text & "/"
        End If

        If chkArea.Checked = True Then
            param = param & "  AREA : [ " & cmbAreaName.Text & " ]"
        Else
            param = param & " [ ALL AREA ]"
        End If

        'If chkadvformat.Checked = True Then
        Dim r As New CrNewTrialBetDays

        r.SetDataSource(GMod.ds.Tables("trial2"))
        r.SetParameterValue("cmpname", GMod.Cmpname)
        r.SetParameterValue("s1", "Trial Balance between " & dtfrom.Text & " TO " & dtTo.Text)
        r.SetParameterValue("s2", ComboBox1.Text)
        'r.SetParameterValue("grp", "GROUP/SUB GROUP: " & cmbgrpname.Text & "/")
        'r.SetParameterValue("uid", GMod.username)
        CrViewerGenralLedger.ReportSource = r
        r = Nothing
        'End If

        btnprint.Enabled = True
    End Sub
    Dim sql As String
    Public Sub AllGroup()
        If chkArea.Checked = False Then
            sql = "select * from grp_summary where cmp_id ='" & GMod.Cmpid & "' and closing <> 0 order by acc_code"
            GMod.DataSetRet(sql, "trial2")
        Else
            sql = "select * from grp_summary where cmp_id ='" & GMod.Cmpid & "' and left(acc_code,2)='" & cmbAreaCode.Text & "' and closing <> 0 order by acc_code"
            GMod.DataSetRet(sql, "trial2")

        End If
    End Sub

    Sub subgrp()
        sql = "select g.* from grp_summary g inner join " & GMod.ACC_HEAD & "  s on g.acc_code=s.account_code  and sub_group_name ='" & ComboBox1.Text & "'  and g.cmp_id ='" & GMod.Cmpid & "'   and closing <> 0 order by acc_code"
        GMod.DataSetRet(sql, "trial2")

    End Sub
    Dim sqlSelect, SqlSelect1 As String
    Public Sub GroupWise()
        If chkArea.Checked = False Then
            sql = "select * from grp_summary where group_code ='" & cmbgrpname.Text & "' and cmp_id='" & GMod.Cmpid & "' and closing <> 0 order by acc_code"
            GMod.DataSetRet(sql, "trial2")
        Else
            sql = "select * from grp_summary where group_code ='" & cmbgrpname.Text & "' and cmp_id='" & GMod.Cmpid & "' and left(acc_code,2)='" & cmbAreaCode.Text & "' and closing <> 0 order by acc_code"
            GMod.DataSetRet(sql, "trial2")

        End If
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        CrViewerGenralLedger.PrintReport()
        btnprint.Enabled = False
    End Sub

    
    Dim grpdr, grpcr As Double
    
    Dim sw As StreamWriter
    Dim ln, pageno As Integer
    Dim gr As String
    
    Dim re As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Dim q As String
    Private Sub cmbgrpname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgrpname.Leave
        q = "select distinct sub_group_name  from " & GMod.ACC_HEAD & "  where group_name ='" & cmbgrpname.Text & "'"
        GMod.DataSetRet(q, "sgrp")

        ComboBox1.DataSource = GMod.ds.Tables("sgrp")
        ComboBox1.DisplayMember = "Sub_Group_name"

    End Sub
    Private Sub cmbgrpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrpname.SelectedIndexChanged

    End Sub
    Private Sub cmbSubGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class