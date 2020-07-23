Public Class frmBalanceSheet3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
    Sub pl()
        'Calculating Pforit & loss
        Dim sql As String
        Dim chk As Double
        GMod.SqlExecuteNonQuery("delete from tmpforbspl where uname='" & GMod.username & "'")
        GMod.SqlExecuteNonQuery("delete from tmptrial where uname='" & GMod.username & "'")
        GMod.SqlExecuteNonQuery("delete from tmppl where uname='" & GMod.username & "'")

        sql = "insert into tmpforbspl  select q.account_code,q.account_head_name,ClosingDr= case  " _
          & " when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0  " _
          & " then  (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) " _
          & " else 0 end, ClosingCr= case  when " _
          & "( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then  " _
          & " abs((isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0))) else 0  " _
          & " end , q.group_name, '" & GMod.username & "' from(select  isnull(Acc_head_code,'') Acc_head_code , isnull(Acc_head,'') " _
          & "Acc_head , isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr  from  " _
          & GMod.VENTRY & " where VOU_DATE<='" & dtto.Value.ToShortDateString & "'" _
          & "  AND VOU_TYPE<>'BANKREC' group by Acc_head_code,Acc_head  ) p Right Join  " _
          & " ( select isnull(account_code,'') account_code ,account_head_name,isnull(opening_dr,0) od, " _
          & " isnull(opening_cr,0)  oc,group_name from " & GMod.ACC_HEAD & ") " _
          & " q on q.account_code=p.Acc_head_code order by p.Acc_head"
        GMod.SqlExecuteNonQuery(Sql)

        Sql = "select sum(bal) balpl from" _
               & " ( select sum(abs(dr)-abs(cr)) bal ,group_name from tmpforbspl group by group_name ) p " _
               & " inner Join ( select * from groups where cmp_id='" & GMod.Cmpid & "') q " _
               & "on p.group_name=q.group_name where bs_pl='PL'"
        GMod.DataSetRet(Sql, "valpl")

        'MsgBox(GMod.ds.Tables("valpl").Rows(0)(0).ToString)
        chk = GMod.ds.Tables("valpl").Rows(0)(0)
        Dim pdr, pcr As Double
        Dim s1 As String
        If GMod.ds.Tables("valpl").Rows(0)(0) > 0 Then
            pdr = Math.Abs(GMod.ds.Tables("valpl").Rows(0)(0))
            pcr = 0
        Else
            pdr = 0
            pcr = Math.Abs(GMod.ds.Tables("valpl").Rows(0)(0))
        End If

        GMod.DataSetRet("select * from " & GMod.VENTRY & " where acc_head='PROFIT & LOSS' and cmp_id='" & GMod.Cmpid & "'", "ser1")
        If GMod.ds.Tables("ser1").Rows.Count = 0 Then
            'insert new row for pl
            'Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, 
            'Acc_head, dramt,cramt, Pay_mode, Cheque_no, Narration, Group_name, 
            'Sub_group_name, Ch_issue_date,Ch_date, bank_eid

            GMod.DataSetRet("select * from " & GMod.ACC_HEAD & " where account_head_name='PROFIT & LOSS' and cmp_id='" & GMod.Cmpid & "'", "code")
            'sql = "insert into " & GMod.VENTRY & "(cmp_id,uname,entry_id,vou_no,vou_date," _
            '& "acc_head_code,acc_head,dramt,cramt,group_name,sub_group_name) values('" & GMod.Cmpid & "'," _
            '& "'" & GMod.username & "'," & pdr & "," & pcr & ",'" & GMod.setDate.ToShortDateString & "'," _
            '& "'" & GMod.ds.Tables("code").Rows(0)("account_code") & "'," _
            '& "'" & GMod.ds.Tables("code").Rows(0)("account_head_name") & "'," _
            '& pdr & "," & pcr & ",'" & GMod.ds.Tables("code").Rows(0)("group_name") & "'," _
            '& "'" & GMod.ds.Tables("code").Rows(0)("sub_group_name") & "')"
        Else
            'update rows for pl
            sql = "update " & GMod.VENTRY & " set dramt=" & pdr & ",cramt=" & pcr _
            & " ,vou_date='" & dtto.Value.AddDays(1).ToShortDateString & "' where cmp_id='" & GMod.Cmpid & "' and acc_head='PROFIT & LOSS'"
        End If
        's1 = GMod.SqlExecuteNonQuery(sql)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'If rdbal.Checked Then
        btnprint.Enabled = True
        CrystalReportViewer1.Visible = False
        GMod.SqlExecuteNonQuery("delete from tmptrial where uname='" & GMod.username & "'")
        Dim i As Integer
        Dim sql As String
        pl()
        sql = "insert into tmptrial(account_code, account_head_name, dr, cr, group_name,Uname)  select q.account_code,q.account_head_name,ClosingDr= case  " _
            & " when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0  " _
            & " then  (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) " _
            & " else 0 end, ClosingCr= case  when " _
            & "( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then  " _
            & " abs((isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0))) else 0  " _
            & " end , q.group_name, '" & GMod.username & "' from(select  isnull(Acc_head_code,'') Acc_head_code , isnull(Acc_head,'') " _
            & "Acc_head , isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr  from  " _
            & GMod.VENTRY & " where VOU_DATE<='" & dtto.Value.ToShortDateString & "'" _
            & "  AND VOU_TYPE<>'BANKREC' group by Acc_head_code,Acc_head  ) p Right Join  " _
            & " ( select isnull(account_code,'') account_code ,account_head_name,isnull(opening_dr,0) od, " _
            & " isnull(opening_cr,0)  oc,group_name from " & GMod.ACC_HEAD & ") " _
            & " q on q.account_code=p.Acc_head_code order by p.Acc_head"

        GMod.SqlExecuteNonQuery(sql)

        'Next
        Dim oppl, cupl, actpl As Double
        sql = "select opening_dr-opening_cr from " & GMod.ACC_HEAD & " where account_head_name='Profit & loss'"
        GMod.DataSetRet(sql, "PLOPEN")
        oppl = Val(GMod.ds.Tables("PLOPEN").Rows(0)(0))

        sql = "select dramt-cramt from " & GMod.VENTRY & " where acc_head='Profit & loss'"
        GMod.DataSetRet(sql, "PLOPEN")
        cupl = Math.Abs(Val(GMod.ds.Tables("PLOPEN").Rows(0)(0)))
        actpl = oppl - cupl
        If actpl > 0 Then
            sql = "update tmptrial set  dr =  " & actpl & " where account_head_name='Profit & loss'"
        Else
            sql = "update tmptrial set  cr =  " & Math.Abs(actpl) & " where account_head_name='Profit & loss'"
        End If


        GMod.SqlExecuteNonQuery(sql)
        'updating cr groups
        sql = "select account_code,group_name,remark2 from " & GMod.ACC_HEAD _
        & " where(group_name <> remark2)"
        GMod.DataSetRet(sql, "crgrp")
        For i = 0 To ds.Tables("crgrp").Rows.Count - 1
            sql = "select * from tmptrial where cr>0 and account_code='" & GMod.ds.Tables("crgrp").Rows(i)("account_code") & "'"
            GMod.DataSetRet(sql, "tmp")
            If ds.Tables("tmp").Rows.Count > 0 Then
                sql = "update tmptrial set group_name='" & GMod.ds.Tables("crgrp").Rows(i)("remark2") & "' where account_code='" & ds.Tables("tmp").Rows(0)("account_code") & "'"
                GMod.SqlExecuteNonQuery(sql)
            End If
        Next

        sql = "insert into tmppl(cmpid,headdr,dramt,uname) " _
        & " select '" & GMod.Cmpid & "' cmp ,group_name,sum(dr)-sum(cr) cr,'" & GMod.username & "' uname from tmptrial where uname='" & GMod.username & "'" _
        & " group by group_name order by group_name"
        GMod.SqlExecuteNonQuery(sql)
        GMod.SqlExecuteNonQuery("update tmppl set cramt=abs(dramt),dramt=0 where dramt<0 and uname='" & GMod.username & "'")

        If rdwodetail.Checked Then
            If rdbal.Checked Then
                'sql = "select headdr,dramt,cramt from tmppl where (dramt>0 or cramt>0) and uname='" & GMod.username & "' and headdr in (select group_name" _
                '& " from groups where bs_pl='BS' and cmp_id='" & GMod.Cmpid & "')"
                sql = "select headdr,dramt,cramt,g.effectsIN from (select headdr,dramt,cramt from tmppl where (dramt>0 or cramt>0) and uname='" & GMod.username & "' and " _
                & " headdr in (select group_name from groups where bs_pl='BS' and cmp_id='" & GMod.Cmpid & "')) p,groups g where cmp_id='" & GMod.Cmpid & "' and g.group_name=p.headdr order by g.effectsin,group_name"
            Else
                sql = "select headdr,dramt,cramt,g.effectsIN from (select headdr,dramt,cramt from tmppl where (dramt>0 or cramt>0) and uname='" & GMod.username & "' and " _
                & " headdr in (select group_name from groups where bs_pl='PL' and cmp_id='" & GMod.Cmpid & "'))p,groups g where cmp_id='" & GMod.Cmpid & "' and g.group_name=p.headdr  order by g.effectsin,group_name"
            End If
            GMod.DataSetRet(sql, "data")
            dgsummary.Visible = True
            dgdetail.Visible = False
            Dim sumdr, sumcr As Double
            dgsummary.Rows.Clear()
            For i = 0 To ds.Tables("data").Rows.Count - 1
                dgsummary.Rows.Add()
                dgsummary(0, i).Value = ds.Tables("data").Rows(i)("headdr")
                dgsummary(1, i).Value = ds.Tables("data").Rows(i)("EffectsIN")
                dgsummary(2, i).Value = ds.Tables("data").Rows(i)("dramt")
                dgsummary(3, i).Value = ds.Tables("data").Rows(i)("cramt")
                sumdr = sumdr + Val(ds.Tables("data").Rows(i)("dramt"))
                sumcr = sumcr + Val(ds.Tables("data").Rows(i)("cramt"))
            Next
            dgsummary.Rows.Add()
            dgsummary(0, i).Style.BackColor = Color.LightSteelBlue
            dgsummary(1, i).Style.BackColor = Color.LightSteelBlue
            dgsummary(2, i).Style.BackColor = Color.LightSteelBlue
            dgsummary(3, i).Style.BackColor = Color.LightSteelBlue

            dgsummary(0, i).Value = "Total"
            dgsummary(2, i).Value = sumdr
            dgsummary(3, i).Value = sumcr
            i = i + 1
            dgsummary.Rows.Add()
            dgsummary(0, i).Style.BackColor = Color.LightSteelBlue
            dgsummary(1, i).Style.BackColor = Color.LightSteelBlue
            dgsummary(2, i).Style.BackColor = Color.LightSteelBlue
            dgsummary(3, i).Style.BackColor = Color.LightSteelBlue

            If rdbal.Checked Then
                dgsummary(0, i).Value = "Difference"
            Else
                dgsummary(0, i).Value = "Profit & Loss"
            End If
            If sumdr - sumcr > 0 Then
                dgsummary(2, i).Value = sumdr - sumcr
            Else
                dgsummary(3, i).Value = sumcr - sumdr
            End If
        Else
            dgsummary.Visible = False
            dgdetail.Visible = True
            If rdbal.Checked Then
                sql = "select group_name,account_head_name,dr,cr from tmptrial where (dr>0 or cr>0) and  uname='" & GMod.username & "' and group_name in " _
                & " (select group_name from groups where bs_pl='BS' and cmp_id='" & GMod.Cmpid & "') order by group_name,account_head_name "
            Else
                sql = "select group_name,account_head_name,dr,cr from tmptrial where (dr>0 or cr>0) and  uname='" & GMod.username & "' and group_name in " _
                & " (select group_name from groups where bs_pl='PL' and cmp_id='" & GMod.Cmpid & "') order by group_name,account_head_name "
            End If
            GMod.DataSetRet(sql, "data")
            dgsummary.Visible = True
            Dim sumdr, sumcr As Double
            dgdetail.Rows.Clear()
            For i = 0 To ds.Tables("data").Rows.Count - 1
                dgdetail.Rows.Add()
                dgdetail(0, i).Value = ds.Tables("data").Rows(i)("group_name")
                dgdetail(1, i).Value = ds.Tables("data").Rows(i)("account_head_name")
                dgdetail(2, i).Value = ds.Tables("data").Rows(i)("dr")
                dgdetail(3, i).Value = ds.Tables("data").Rows(i)("cr")
                sumdr = sumdr + Val(ds.Tables("data").Rows(i)("dr"))
                sumcr = sumcr + Val(ds.Tables("data").Rows(i)("cr"))
            Next
            dgdetail.Rows.Add()
            dgdetail(0, i).Style.BackColor = Color.LightSteelBlue
            dgdetail(1, i).Style.BackColor = Color.LightSteelBlue
            dgdetail(2, i).Style.BackColor = Color.LightSteelBlue
            dgdetail(3, i).Style.BackColor = Color.LightSteelBlue

            dgdetail(0, i).Value = "Total"
            dgdetail(2, i).Value = sumdr
            dgdetail(3, i).Value = sumcr
            i = i + 1
            dgdetail.Rows.Add()
            dgdetail(0, i).Style.BackColor = Color.LightSteelBlue
            dgdetail(1, i).Style.BackColor = Color.LightSteelBlue
            dgdetail(2, i).Style.BackColor = Color.LightSteelBlue
            dgdetail(3, i).Style.BackColor = Color.LightSteelBlue

            If rdbal.Checked Then
                dgdetail(0, i).Value = "Difference"
            Else
                dgdetail(0, i).Value = "Profit & Loss"
            End If
            If sumdr - sumcr > 0 Then
                dgdetail(2, i).Value = sumdr - sumcr
            Else
                dgdetail(3, i).Value = sumcr - sumdr
            End If
        End If
    End Sub
    Private Sub dgdetail_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdetail.CellClick
        dgdetail.CurrentCell.Style.BackColor = Color.Pink
    End Sub
    Private Sub dgsummary_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsummary.CellClick
        dgsummary.CurrentCell.Style.BackColor = Color.Pink
    End Sub
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim cr, i As Integer
        Dim chk As Integer = 0
        If txtfind.Text = "" Then
            MsgBox("Please type related informatin for search", MsgBoxStyle.Critical)
            txtfind.Focus()
            Exit Sub
        End If
        If rdwodetail.Checked Then
            cr = dgsummary.CurrentCell.RowIndex + 1
            If rdchqno.Checked Then
                For i = cr To dgsummary.RowCount - 1
                    If InStr(dgsummary(0, i).Value, txtfind.Text) > 0 Then
                        dgsummary.CurrentCell = dgsummary(0, i)
                        chk = 1
                        Exit For
                    End If
                Next
            ElseIf rdamt.Checked Then
                For i = cr To dgsummary.RowCount - 1
                    ' MsgBox(dg(1, i).Value)
                    If Val(dgsummary(2, i).Value) = txtfind.Text Then
                        dgsummary.CurrentCell = dgsummary(2, i)
                        chk = 1
                        Exit For
                    ElseIf Val(dgsummary(3, i).Value) = txtfind.Text Then
                        dgsummary.CurrentCell = dgsummary(3, i)
                        chk = 1
                        Exit For
                    End If
                Next
            End If

            If chk = 0 Then
                MsgBox("Not Found", MsgBoxStyle.Information)
                If MsgBox("Do u want search from begining", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    dgsummary.CurrentCell = dgsummary(0, 0)
                End If
            End If
        Else
            cr = dgdetail.CurrentCell.RowIndex + 1
            If rdchqno.Checked Then
                For i = cr To dgdetail.RowCount - 1
                    If InStr(dgdetail(1, i).Value, txtfind.Text) > 0 Then
                        dgdetail.CurrentCell = dgdetail(1, i)
                        chk = 1
                        Exit For
                    End If
                Next
            ElseIf rdamt.Checked Then
                For i = cr To dgdetail.RowCount - 1
                    ' MsgBox(dg(1, i).Value)
                    If Val(dgdetail(2, i).Value) = txtfind.Text Then
                        dgdetail.CurrentCell = dgdetail(2, i)
                        chk = 1
                        Exit For
                    ElseIf Val(dgdetail(3, i).Value) = txtfind.Text Then
                        dgdetail.CurrentCell = dgdetail(3, i)
                        chk = 1
                        Exit For
                    End If
                Next
            End If

            If chk = 0 Then
                MsgBox("Not Found", MsgBoxStyle.Information)
                If MsgBox("Do u want search from begining", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    dgdetail.CurrentCell = dgdetail(0, 0)
                End If
            End If
        End If
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        'btnprint.Enabled = False
        'Dim sql As String
        'CrystalReportViewer1.Visible = True
        'If rdwodetail.Checked Then
        '    If rdbal.Checked Then
        '        'code for balance sheet
        '        'sql = "select headdr,dramt,cramt from tmppl where (dramt>0 or cramt>0) and uname='" & GMod.username & "' and headdr in (select group_name" _
        '        '& " from groups where bs_pl='BS' and cmp_id='" & GMod.Cmpid & "')"
        '        sql = "select headdr,dramt,cramt,g.effectsIN from (select headdr,dramt,cramt from tmppl where (dramt>0 or cramt>0) and uname='" & GMod.username & "' and " _
        '        & " headdr in (select group_name from groups where bs_pl='BS' and cmp_id='" & GMod.Cmpid & "')) p,groups g where cmp_id='" & GMod.Cmpid & "' and g.group_name=p.headdr order by g.effectsin,group_name"
        '        GMod.DataSetRet(sql, "data")
        '        Dim r As New CRBalance3
        '        r.SetDataSource(ds.Tables("data"))
        '        r.SetParameterValue("cmpname", GMod.Cmpname)
        '        r.SetParameterValue("address", GMod.cmpadd)
        '        r.SetParameterValue("subhead", "Balance Sheet ")
        '        r.SetParameterValue("h1", "lib")
        '        r.SetParameterValue("h2", "ast")
        '        r.SetParameterValue("p2", "Balance")
        '        CrystalReportViewer1.ReportSource = r
        '    Else
        '        'code for profit & loss
        '        sql = "select headdr,dramt,cramt,g.effectsIN from (select headdr,dramt,cramt from tmppl where (dramt>0 or cramt>0) and uname='" & GMod.username & "' and " _
        '        & " headdr in (select group_name from groups where bs_pl='PL' and cmp_id='" & GMod.Cmpid & "'))p,groups g where cmp_id='" & GMod.Cmpid & "' and g.group_name=p.headdr  order by g.effectsin,group_name"
        '        GMod.DataSetRet(sql, "data")
        '        Dim r As New CRBalance3
        '        r.SetDataSource(ds.Tables("data"))
        '        r.SetParameterValue("cmpname", GMod.Cmpname)
        '        r.SetParameterValue("address", GMod.cmpadd)
        '        r.SetParameterValue("subhead", "Profit & Loss ")
        '        r.SetParameterValue("h1", "Profit")
        '        r.SetParameterValue("h2", "Loss")
        '        r.SetParameterValue("p2", "Profit & Loss")
        '        CrystalReportViewer1.ReportSource = r
        '    End If
        'Else

        '    If rdbal.Checked Then
        '        sql = "select group_name,account_head_name,dr,cr from tmptrial where (dr>0 or cr>0) and  uname='" & GMod.username & "' and group_name in " _
        '        & " (select group_name from groups where bs_pl='BS' and cmp_id='" & GMod.Cmpid & "') order by group_name,account_head_name "
        '        GMod.DataSetRet(sql, "data")
        '        Dim r As New CRDetailBS
        '        r.SetDataSource(ds.Tables("data"))
        '        r.SetParameterValue("cmpname", GMod.Cmpname)
        '        r.SetParameterValue("address", GMod.cmpadd)
        '        r.SetParameterValue("subhead", "Profit & Loss ")
        '        r.SetParameterValue("h1", "Lib")
        '        r.SetParameterValue("h2", "Ass")
        '        r.SetParameterValue("p2", "Balance")
        '        CrystalReportViewer1.ReportSource = r
        '    Else
        '        sql = "select group_name,account_head_name,dr,cr from tmptrial where (dr>0 or cr>0) and  uname='" & GMod.username & "' and group_name in " _
        '        & " (select group_name from groups where bs_pl='PL' and cmp_id='" & GMod.Cmpid & "') order by group_name,account_head_name "
        '        GMod.DataSetRet(sql, "data")
        '        Dim r As New CRDetailBS
        '        r.SetDataSource(ds.Tables("data"))
        '        r.SetParameterValue("cmpname", GMod.Cmpname)
        '        r.SetParameterValue("address", GMod.cmpadd)
        '        r.SetParameterValue("subhead", "Profit & Loss ")
        '        r.SetParameterValue("h1", "Profit")
        '        r.SetParameterValue("h2", "Loss")
        '        r.SetParameterValue("p2", "Profit & Loss")
        '        CrystalReportViewer1.ReportSource = r
        '    End If

        'End If

    End Sub
End Class