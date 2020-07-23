Public Class frmCommonHeadCustomerBalances

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql, acchead, ventry As String
        Dim i As Integer
        sql = " select * from company  where cmpname like '%PHOENIX%' and cmp_id<>'PHHA'"
        GMod.DataSetRet(sql, "cmp")
        For i = 0 To GMod.ds.Tables("cmp").Rows.Count - 1
            acchead = "ACC_HEAD_" & GMod.ds.Tables("cmp").Rows(i)("cmp_id") & "_" & GMod.Session
            ventry = "VENTRY_" & GMod.ds.Tables("cmp").Rows(i)("cmp_id") & "_" & GMod.Session
            MsgBox(acchead)
            sql = " select * from " & acchead & " v1 " _
                & " inner join ACC_HEAD_PHHA_" & GMod.Session & " v2 on v1.account_head_name=v2.account_head_name and v1.area_code=v2.area_code and v1.group_name='CUSTOMER'  "

            GMod.DataSetRet(sql, "ch")

            sql = " select q.account_code,q.account_head_name,ClosingDr=  " _
                  & " case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0 then  " _
                  & " (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) else 0 end, " _
                  & " ClosingCr= case  " _
                  & " when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then " _
                  & "   abs((isnull(q.od, 0) + isnull(p.dr, 0)) - (isnull(q.oc, 0) + isnull(p.cr, 0))) " _
                  & " else 0 end,'" & GMod.username & "' uname,q.group_name from( select  isnull(Acc_head_code,'') Acc_head_code , isnull(Acc_head,'') Acc_head , " _
                  & " isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr, group_name  from " _
                  & "" & GMod.VENTRY & " where vou_date <='" & dtfrom.Value.ToShortDateString & "' and grou_name='CUSTOMER' group by Acc_head_code,Acc_head ,group_name ) p " _
                  & " Right Join  ( select isnull(account_code,'') account_code ,account_head_name, " _
                  & " isnull(opening_dr,0) od,isnull(opening_cr,0)  oc ,group_name " _
                  & " from " & GMod.ACC_HEAD & " ) q " _
                  & " on q.account_code=p.Acc_head_code order by q.group_name,left(account_code,2), q.account_head_name "
            GMod.SqlExecuteNonQuery(sql)



        Next
      
    End Sub
End Class