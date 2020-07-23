Public Class frmPurchaseSaleDebitCashRecivedSummary

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        'Dim sql, sqlinst As String
        'sql = " select * from InvPhxChicken " _
        '& " where Vou_type='PURCHASE' and vou_date between '" & d1.Value.ToShortDateString & "' and  '" & d2.Value.ToShortDateString & "'"


        'sql = " select * from InvPhxChicken " _
        '& " where Vou_type='SALE' and vou_date between '" & d1.Value.ToShortDateString & "' and  '" & d2.Value.ToShortDateString & "'"


        'sqlinst = "  select sum(cramt) cr  from " & GMod.Cmpid _
        '             & " where vou_type in ('CR VOUCHER','BANK TRANS') and group_name not in ('INTERNAL PARTY','COLLECTION') " _
        '              & " and  vou_date between '" & d1.Value.ToShortDateString & "' and '" & d2.Value.ToShortDateString & "'"

        GMod.SqlExecuteNonQuery("delete from tmpSalePurExp")

        Dim sql, sqlinst, cmp, cn, up As String, i As Integer
        GMod.SqlExecuteNonQuery("delete from dbo.tmpSalePurExp")
        sql = "select * from dbo.Company where cmp_id = 'PHCH'"
        GMod.DataSetRet(sql, "CMP")


        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            'MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date))
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            sqlinst = "insert into tmpSalePurExp(cmpname) values('" & cn.ToString & "')"
            GMod.SqlExecuteNonQuery(sqlinst)
        Next

        sql = "select * from dbo.Company where cmp_id ='PHCH'"
        GMod.DataSetRet(sql, "CMP")
        MsgBox(GMod.ds.Tables("CMP").Rows.Count)
        'SALE
        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
            sql = "select isnull(sum(dramt),0) - isnull(sum(cramt),0) from " _
                       & cmp & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                        & " and vou_type<>'BANKREC' and Group_name in (select Group_name from Groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and BS_PL='PL'and Dr_Cr='Cr')"
            GMod.DataSetRet(sql, "sale")
            If GMod.ds.Tables("sale").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set sale = '" & GMod.ds.Tables("sale").Rows(0)(0) & "' where cmpname='" & cn & "'"
                MsgBox(GMod.SqlExecuteNonQuery(up))
            End If

            'PURCHASE
            sql = "select sum(dramt) - sum(cramt),Group_name from " _
                           & cmp & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                            & " and vou_type<>'BANKREC' and Group_name='PURCHASE' " _
                           & " group by  Group_name "
            'sql = "select sum(dramt) - sum(cramt),Group_name from " _
            '                         & cmp & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
            '                          & " and vou_type<>'BANKREC' and Group_name='PURCHASE' " _
            '                         & " group by  Group_name "

            GMod.DataSetRet(sql, "purchase")
            If GMod.ds.Tables("purchase").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set purchase = '" & GMod.ds.Tables("purchase").Rows(0)(0) & "' where cmpname='" & cn & "'"
                MsgBox(GMod.SqlExecuteNonQuery(up))
            End If
            'Cash Recevieid 
            sql = "  select sum(cramt) cr  from " & cmp _
                         & " where vou_type in ('CR VOUCHER','BANK TRANS') and group_name not in ('INTERNAL PARTY','COLLECTION') " _
                          & " and  vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
            GMod.DataSetRet(sql, "AA")
            If GMod.ds.Tables("AA").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set expenses = '" & GMod.ds.Tables("AA").Rows(0)(0) & "' where cmpname='" & cn & "'"
                MsgBox(GMod.SqlExecuteNonQuery(up))
            End If

            'Debit Amount 
            sql = "select SUM(dr-cr) from ( select q.account_code,q.account_head_name,isnull(p.dr,0) + isnull(q.opening_dr,0) dr ,isnull(p.cr,0) + isnull(q.opening_cr,0) cr  from  ( select isnull(sum(dramt),0) dr ,isnull(sum(cramt),0) cr ,Acc_head_code,Acc_head from VENTRY_PHCH_0809 " _
                   & " where  Vou_date between '10/1/2008' and '10/30/2008' and vou_type<>'BANKREC' and " _
                   & "  Group_name='CUSTOMER' and sub_group_name=''" _
                   & " group by Acc_head_code,Acc_head ) p  Right Join " _
                   & "( select isnull(account_code,'') account_code,isnull(account_head_name,'') " _
                   & " account_head_name ,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0)  " _
                   & " opening_cr ,sub_group_name  from ACC_HEAD_PHCH_0809 " _
                   & " where Group_name='CUSTOMER'  and sub_group_name='') " _
                   & " q on p.Acc_head_code = q.account_code ) z where z.dr<>z.cr  "
            GMod.DataSetRet(sql, "AA1")
            If GMod.ds.Tables("AA1").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set debit = '" & GMod.ds.Tables("AA1").Rows(0)(0) & "' where cmpname='" & cn & "'"
                MsgBox(GMod.SqlExecuteNonQuery(up))
            End If

        Next
        '------------------------------------------------------------
        cv1.Height = Me.Height - 100

        Dim cr As New c1
        sql = "select * from tmpSalePurExp"
        GMod.DataSetRet(sql, "ab")
        sql = "Date From " & dtfrom.Text & " TO " & dtTo.Text
        cr.SetDataSource(GMod.ds.Tables("ab"))
        cr.SetParameterValue("s", sql)
        cv1.ReportSource = cr
    End Sub
End Class