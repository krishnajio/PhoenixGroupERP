Public Class frmBalancesheetMonthly

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        ' Try
        Dim i, iddr, idcr As Integer
        Dim sql As String
        iddr = 1
        idcr = 1
        If rdbal.Checked Then
            GMod.SqlExecuteNonQuery("Delete from tmppl where uname='" & GMod.username & "'")
            GMod.DataSetRet("select * from Groups where BS_PL='BS' and cmp_id='" & GMod.Cmpid & "'", "bs")
            For i = 0 To GMod.ds.Tables("bs").Rows.Count - 1
                If GMod.ds.Tables("bs").Rows(i)("dr_cr") = "Dr" Then
                    sql = "insert into tmppl(cmpid,headdr,dramt,uname,bspl,eid) " _
                    & " select '" & GMod.Cmpid & "'," _
                    & "'" & GMod.ds.Tables("bs").Rows(i)("group_name") & "'," _
                    & " isnull(SUM(isnull(p.dr,0) + isnull(q.opening_dr,0)),0)  - isnull(SUM(isnull(p.cr,0) + isnull(q.opening_cr,0)),0),'" & GMod.username & "','BS'," & iddr _
                    & " from  ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " & GMod.VENTRY _
                    & " where  ch_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Pay_mode<>'-'" _
                    & " and Group_name='" & GMod.ds.Tables("bs").Rows(i)("group_name") & "' and vou_type<>'BANKREC' and pay_mode<>'-'" _
                    & " group by Acc_head_code ) p  right Join" _
                    & "( select ISNULL(account_code,'') account_code ,ISNULL(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr ,isnull(opening_cr,0) opening_cr ,Group_name " _
                    & " from " & GMod.ACC_HEAD & " where Group_name='" & GMod.ds.Tables("bs").Rows(i)("group_name") & "' ) q on p.Acc_head_code = q.account_code "
                    GMod.SqlExecuteNonQuery(sql)
                    iddr = iddr + 1
                End If
            Next
            For i = 0 To GMod.ds.Tables("bs").Rows.Count - 1
                If GMod.ds.Tables("bs").Rows(i)("dr_cr") = "Cr" Then

                    If idcr <= iddr Then
                        sql = "select " _
                        & "'" & GMod.ds.Tables("bs").Rows(i)("group_name") & "'," _
                        & " isnull(SUM(isnull(p.dr,0) + isnull(q.opening_dr,0)),0)  - isnull(SUM(isnull(p.cr,0) + isnull(q.opening_cr,0)),0) " _
                        & " from  ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " & GMod.VENTRY _
                        & " where  ch_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Pay_mode<>'-'" _
                        & " and Group_name='" & GMod.ds.Tables("bs").Rows(i)("group_name") & "' and vou_type<>'BANKREC' and pay_mode<>'-' " _
                        & " group by Acc_head_code,Acc_head ) p  RIGHT Join" _
                        & "( select isnull(account_code,'') account_code ,isnull(account_head_name,'') account_head_name,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0) opening_cr , group_name " _
                        & " from " & GMod.ACC_HEAD & " where group_name='" & GMod.ds.Tables("bs").Rows(i)("group_name") & "') q on p.Acc_head_code = q.account_code "

                        GMod.DataSetRet(sql, "tm")

                        sql = "update tmppl set headcr='" & GMod.ds.Tables("tm").Rows(0)(0) & "',cramt=" & GMod.ds.Tables("tm").Rows(0)(1) _
                        & " where eid=" & idcr & " and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'"
                        GMod.SqlExecuteNonQuery(sql)
                    Else
                        sql = "insert into tmppl(cmpid,headdr,dramt,uname,bspl,eid) select '" & GMod.Cmpid & "'," _
                                                & "'" & GMod.ds.Tables("bs").Rows(i)("group_name") & "'," _
                                                & " isnull(SUM(p.dr + q.opening_dr),0)  - isnull(SUM(p.cr + q.opening_cr),0),'" & GMod.username & "','BS'," & idcr _
                                                & " from  ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " & GMod.VENTRY _
                                                & " where  ch_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Pay_mode<>'-'" _
                                                & " and Group_name='" & GMod.ds.Tables("bs").Rows(i)("group_name") & "' and vou_type<>'BANKREC'  and pay_mode<>'-' " _
                                                & " group by Acc_head_code,Acc_head ) p  Left Join" _
                                                & "( select account_code,account_head_name,opening_dr,opening_cr,sub_group_name " _
                                                & " from " & GMod.ACC_HEAD & " ) q on p.Acc_head_code = q.account_code "
                        GMod.SqlExecuteNonQuery(sql)
                    End If
                    idcr = idcr + 1
                End If
            Next

            '    GMod.DataSetRet("select * from tmppl where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'", "bs")
            '    Dim r As New CRBalanceSheet
            '    r.SetDataSource(GMod.ds.Tables("bs"))
            '    r.SetParameterValue("cname", GMod.Cmpname)
            '    r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
            '    CrViewerGenralLedger.ReportSource = r
        Else ' Now PL at at Here 
            GMod.SqlExecuteNonQuery("Delete from tmppl ") 'where uname='" & GMod.username & "'")

            sql = "insert into tmppl(cmpid,headdr,dramt,uname,bspl,eid) values("
            sql &= "'" & GMod.Cmpid & "',"
            sql &= "'Opening Stock " & ComboBox1.Text & "',"
            sql &= "'" & Val(txtopen.Text) & "',"
            sql &= "'" & GMod.username & "',"
            sql &= "'PL',"
            sql &= "'0')"
            GMod.SqlExecuteNonQuery(sql)

            GMod.DataSetRet("select * from Groups where BS_PL='PL' and cmp_id='" & GMod.Cmpid & "'", "bs")
            For i = 0 To GMod.ds.Tables("bs").Rows.Count - 1
                If GMod.ds.Tables("bs").Rows(i)("dr_cr") = "Dr" Then
                    sql = "insert into tmppl(cmpid,headdr,dramt,uname,bspl,eid) " _
                    & " select '" & GMod.Cmpid & "'," _
                    & "'" & GMod.ds.Tables("bs").Rows(i)("group_name") & "'," _
                    & " isnull(SUM(isnull(p.dr,0) + isnull(q.opening_dr,0)),0)  - isnull(SUM(isnull(p.cr,0) + isnull(q.opening_cr,0)),0),'" & GMod.username & "','PL'," & iddr _
                    & " from  ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code from " & GMod.VENTRY _
                    & " where  ch_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Pay_mode<>'-'" _
                    & " and  vou_type<>'BANKREC' " _
                    & " group by Acc_head_code ) p  right Join" _
                    & "( select ISNULL(account_code,'') account_code ,ISNULL(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr ,isnull(opening_cr,0) opening_cr ,Group_name " _
                    & " from " & GMod.ACC_HEAD & " where Group_name='" & GMod.ds.Tables("bs").Rows(i)("group_name") & "' ) q on p.Acc_head_code = q.account_code "
                    GMod.SqlExecuteNonQuery(sql)
                    iddr = iddr + 1
                End If
            Next
            For i = 0 To GMod.ds.Tables("bs").Rows.Count - 1
                If GMod.ds.Tables("bs").Rows(i)("dr_cr") = "Cr" Then

                    If idcr <= iddr Then
                        sql = "select " _
                        & "'" & GMod.ds.Tables("bs").Rows(i)("group_name") & "'," _
                        & " isnull(SUM(isnull(p.dr,0) + isnull(q.opening_dr,0)),0)  - isnull(SUM(isnull(p.cr,0) + isnull(q.opening_cr,0)),0) " _
                        & " from  ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code from " & GMod.VENTRY _
                        & " where  ch_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Pay_mode<>'-'" _
                        & " and  vou_type<>'BANKREC' " _
                        & " group by Acc_head_code ) p  RIGHT Join" _
                        & "( select isnull(account_code,'') account_code ,isnull(account_head_name,'') account_head_name,isnull(opening_dr,'') opening_dr, isnull(opening_cr,'') opening_cr , group_name " _
                        & " from " & GMod.ACC_HEAD & " where group_name='" & GMod.ds.Tables("bs").Rows(i)("group_name") & "') q on p.Acc_head_code = q.account_code "

                        GMod.DataSetRet(sql, "tm")
                        sql = "update tmppl set headcr='" & GMod.ds.Tables("tm").Rows(0)(0) & "',cramt=" & GMod.ds.Tables("tm").Rows(0)(1) _
                        & " where eid=" & idcr & " and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'"
                        GMod.SqlExecuteNonQuery(sql)
                    Else
                        sql = "insert into tmppl(cmpid,headdr,dramt,uname,bspl,eid) select '" & GMod.Cmpid & "'," _
                        & "'" & GMod.ds.Tables("bs").Rows(i)("group_name") & "'," _
                        & " isnull(SUM(p.dr + q.opening_dr),0)  - isnull(SUM(p.cr + q.opening_cr),0),'" & GMod.username & "','PL'," & idcr _
                        & " from  ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code from " & GMod.VENTRY _
                        & " where  ch_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Pay_mode<>'-'" _
                        & "  and vou_type<>'BANKREC' " _
                        & " group by Acc_head_code ) p  Left Join" _
                        & "( select account_code,account_head_name,opening_dr,opening_cr,sub_group_name " _
                        & " from " & GMod.ACC_HEAD & " ) q on p.Acc_head_code = q.account_code "
                        GMod.SqlExecuteNonQuery(sql)
                    End If
                    idcr = idcr + 1
                End If
            Next

            sql = "insert into tmppl(cmpid,headcr,cramt,uname,bspl,eid) values("
            sql &= "'" & GMod.Cmpid & "',"
            sql &= "'Closing Stock " & ComboBox1.Text & "',"
            sql &= "'" & Val(txtclosing.Text) & "',"
            sql &= "'" & GMod.username & "',"
            sql &= "'PL',"
            sql &= "'" & idcr + 1 & " ')"
            GMod.SqlExecuteNonQuery(sql)


            If ComboBox1.Text = "All" Then
                GMod.DataSetRet("select * from tmppl where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' or (dramt > 0 or cramt>0)", "bs")
            Else

                GMod.SqlExecuteNonQuery("update  tmppl set dramt =0 where headdr not like '%" & ComboBox1.Text & "%' and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                GMod.SqlExecuteNonQuery("update  tmppl set cramt =0 where headcr not like '%" & ComboBox1.Text & "%'  and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                GMod.SqlExecuteNonQuery("delete from tmppl where isnull(dramt,0) =0 and isnull(cramt,0) =0")

                GMod.DataSetRet("select * from tmppl where headdr like '%" & ComboBox1.Text & "%' or headcr like '%" & ComboBox1.Text & "%' and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' or (dramt > 0 or cramt>0)", "bs")
            End If
            Dim r As New CRProfitloss
            r.SetDataSource(GMod.ds.Tables("bs"))
            r.SetParameterValue("cname", GMod.Cmpname)
            r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
            r.SetParameterValue("p1", "Unit:" & ComboBox1.Text)
            CrViewerGenralLedger.ReportSource = r
        End If
        ' Catch ex As Exception
        'MsgBox(ex.Message)
        ' End Try
    End Sub

    Private Sub frmBalancesheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        'Seeting Session Start DATE
        Dim sdate As String = "4/1/" & GMod.Session.Substring(0, 2).ToString
        dtfrom.Value = CDate(sdate)
        CrViewerGenralLedger.Height = Me.Height - 150
    End Sub


End Class