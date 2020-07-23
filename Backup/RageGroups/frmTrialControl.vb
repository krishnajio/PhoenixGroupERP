Public Class frmTrialControl

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim sql As String
        GMod.SqlExecuteNonQuery("delete from  tmptrial where uname='" & GMod.username & "'")
        'sql = " insert into tmptrial" _
        '& " select q.account_code,q.account_head_name,ClosingDr=  " _
        '& " case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0 then  " _
        '& " (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) else 0 end, " _
        '& " ClosingCr= case  " _
        '& " when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then " _
        '& " abs((isnull(q.od, 0) + isnull(p.dr, 0)) - (isnull(q.oc, 0) + isnull(p.cr, 0))) " _
        '& " else 0 end,'" & GMod.username & "' uname,q.group_name from( select  isnull(Acc_head_code,'') Acc_head_code , isnull(Acc_head,'') Acc_head , " _
        '& " isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr, group_name  from " _
        '& "" & GMod.VENTRY & " where vou_date <='" & dtfrom.Value.ToShortDateString & "' group by Acc_head_code,group_name ) p " _
        '& " Right Join  ( select isnull(account_code,'') account_code ,account_head_name, " _
        '& " isnull(opening_dr,0) od,isnull(opening_cr,0)  oc ,group_name " _
        '& " from " & GMod.ACC_HEAD & " ) q " _
        '& " on q.account_code=p.Acc_head_code order by q.group_name,left(account_code,2), q.account_head_name "
        sql = " insert into tmptrial(account_code, account_head_name, dr, cr,grpname,Uname) select q.account_code,q.acname," _
        & " DrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 then  (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end, " _
        & " CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0 then  abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) else 0 end," _
        & " q.group_name, " _
                & "'" & GMod.username & "'" _
                & " from (" _
                & " select isnull(sum(dramt),0) dramt ,isnull(sum(cramt),0) cramt,acc_head_code" _
                & " from " & GMod.VENTRY & " " _
                & " where vou_date<='" & dtfrom.Value.ToShortDateString & "' and Pay_mode<>'-'" _
                & " group by acc_head_code ) p " _
                & " Right Join " _
                & " ( select account_code,account_head_name acname ,group_name, isnull(opening_dr,0) odr  , " _
                & " isnull(opening_cr,0) ocr from " & GMod.ACC_HEAD & " where group_name<>'CASH IN HAND'  ) q " _
                & " on p.acc_head_code=q.account_code  " _
                & " where ((isnull(p.dramt,0) + q.odr) <> (isnull(p.cramt,0) + q.ocr)) "



        GMod.SqlExecuteNonQuery(sql)
        GMod.SqlExecuteNonQuery("delete from tmpTrialControl")

        sql = " insert into tmpTrialControl(dr, cr, grpname, AreaCode, AreaName, Uname )" _
        & "select p.dr,p.cr,p.grpname,p.ac,area.areaname,'" & GMod.username & "' from ( " _
        & "select sum(dr) dr ,sum(cr)cr ," _
        & "grpname,left(account_code,2) ac  from tmptrial   where uname ='" & GMod.username & "' " _
        & "group by grpname,left(account_code,2)  ) p left join " _
        & " area on p.ac=area.prefix order by grpname,ac "
        GMod.SqlExecuteNonQuery(sql)
        sql = "select * from tmpTrialControl where abs(dr-cr)>0  order by id,grpname,Areacode"
        GMod.DataSetRet(sql, "trialcontrol")
        Dim r1 As New CrTrialControl
        r1.SetDataSource(GMod.ds.Tables("trialcontrol"))
        r1.SetParameterValue("cmpname", GMod.Cmpname)
        r1.SetParameterValue("subhead", "Trial Control as on " & dtfrom.Text)
        'r1.SetParameterValue("subhead1", param)
        r1.SetParameterValue("uname", GMod.username)

        CrViewerGenralLedger.ReportSource = r1
    End Sub

    Private Sub frmTrialControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        'dtfrom.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        CrViewerGenralLedger.Height = Me.Height - 100
    End Sub
End Class