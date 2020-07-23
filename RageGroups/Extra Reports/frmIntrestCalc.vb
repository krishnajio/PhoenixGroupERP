Public Class frmIntrestCalc

    Private Sub frmIntrestCalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 1, 2))
        'dtfrom.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        dtto.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtto.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

          Dim sqlrole As String
        sqlrole = "select [role] from Usertab1 where Uname='" & GMod.username & "'"
        GMod.DataSetRet(sqlrole, "rr")
        If GMod.ds.Tables("rr").Rows(0)(0).ToString = "LIMITED" Then
            rdPary.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            drcustomer.Checked = True
            drcustomer_CheckedChanged(sender, e)
        Else
            rdPary.Enabled = True
            RadioButton1.Enabled = True
            Dim sql As String
            sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                   & " and group_name not in ('PARTY','CUSTOMER') order by account_head_name"
            GMod.DataSetRet(sql, "acchead")
            cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
            cmbacheadcode.DisplayMember = "account_code"

            cmbacheadname.DataSource = GMod.ds.Tables("acchead")
            cmbacheadname.DisplayMember = "account_head_name"
        End If
        RadioButton1_Click(sender, e)
        cmbgrpname_SelectedIndexChanged(sender, e)
        Me.Text = Me.Text & "    [" & GMod.Cmpname & "]"
        'Seeting Session Start DATE
        Dim sdate As String = "4/1/" & GMod.Session.Substring(0, 2).ToString
        dtfrom.Value = CDate(sdate)
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

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True Then
            cmbgrpname.Enabled = True
            GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "' and group_name NOT IN('PARTY','CUSTOMER','INTERNAL PARTY') order by group_name", "grp")
            cmbgrpname.DataSource = GMod.ds.Tables("grp")
            cmbgrpname.DisplayMember = "group_name"
            cmbgrpname_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub cmbgrpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrpname.SelectedIndexChanged
        GMod.DataSetRet("select * from sub_group where group_name='" & cmbgrpname.Text & "' and  cmp_id='" & GMod.Cmpid & "'", "sgrp")
        cmbsubgrpname.DataSource = GMod.ds.Tables("sgrp")
        cmbsubgrpname.DisplayMember = "sub_group_name"

        Dim sql As String
        sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
               & " and group_name = '" & cmbgrpname.Text & "'"
        GMod.DataSetRet(sql, "acchead")
        cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
        cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("acchead")
        cmbacheadname.DisplayMember = "account_head_name"
        
    End Sub

    Private Sub drcustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drcustomer.CheckedChanged

    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Try

            cmbacheadname.Enabled = False
            cmbacheadcode.Enabled = False
            cmbgrpname.Enabled = False
            cmbsubgrpname.Enabled = False
            GroupBox1.Enabled = False
            cmbAreaName.Enabled = False
            cmbAreaCode.Enabled = False
            CheckBoxArea.Enabled = False
            dtfrom.Enabled = False
            dtto.Enabled = False

            Dim HEAD As String = cmbacheadname.Text
            Dim CODE As String = cmbacheadcode.Text
            'dleting old data for that use 
            GMod.SqlExecuteNonQuery("delete  from repGeneralLedger1  where upper(Uname)='" & GMod.username.ToUpper & "'")
            'GMod.SqlExecuteNonQuery("delete  from repPartyLedger where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
            'Calulating openng and inserint into table 


            Dim sqlopen As String
            Dim opnbal, dr, cr As Double
            sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                      & " " & GMod.VENTRY & " where Acc_head_code='" & cmbacheadcode.Text & "' and  vou_date<'" & dtfrom.Text & "' and vou_type<>'BANKREC' and Pay_mode<>'-'"
            GMod.DataSetRet(sqlopen, "opening")
            opnbal = CDbl(GMod.ds.Tables("opening").Rows(0)(0))
            GMod.ds.Tables("opening").Clear()
            sqlopen = "select isnull(sum(opening_dr),0) - isnull(sum(opening_cr),0) from " & GMod.ACC_HEAD _
                       & " where Account_code='" & cmbacheadcode.Text & "'"
            GMod.DataSetRet(sqlopen, "opening")
            opnbal = opnbal + CDbl(GMod.ds.Tables("opening").Rows(0)(0))
            GMod.ds.Tables("opening").Clear()
            'MsgBox(opnbal.ToString)
            If opnbal > 0 Then
                dr = opnbal
                cr = 0
            Else
                dr = 0
                cr = -1 * opnbal
            End If
            Dim sqlsave As String
            If RadioButton1.Checked = True Or RadioButton2.Checked = True Or rdPary.Checked = True Then
                sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname,vou_date)  values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & cmbacheadcode.Text & "',"
                sqlsave &= "'OLD BALANCE',"
                sqlsave &= "'OPEN',"
                sqlsave &= "'" & dr.ToString & "',"
                sqlsave &= "'" & cr.ToString & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'" & dtfrom.Value.ToShortDateString & "')"
                GMod.SqlExecuteNonQuery(sqlsave)
            Else
                sqlsave = "insert into repPartyLedger(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & cmbacheadcode.Text & "',"
                sqlsave &= "'OLD BALANCE',"
                sqlsave &= "'OPEN',"
                sqlsave &= "'" & dr.ToString & "',"
                sqlsave &= "'" & cr.ToString & "',"
                sqlsave &= "'" & GMod.username & "')"
                MsgBox(GMod.SqlExecuteNonQuery(sqlsave))
            End If
            '------------------------------------------------------------------------------------------------------
            'Now inserting transtion os that accont head 
            If RadioButton1.Checked = True Or RadioButton2.Checked = True Or rdPary.Checked = True Then
                sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no, Uname) " _
                & " select Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                & " where vou_date between '" & dtfrom.Text & "' and '" & dtto.Text & "' and Acc_head_code='" & cmbacheadcode.Text & "' and vou_type<>'BANKREC' and left(Uname,1)<>'$'  and Pay_mode<>'-' order by vou_date,vou_no"
                GMod.SqlExecuteNonQuery(sqlsave)
            Else
                sqlsave = "insert into repPartyLedger(Cmpid, Uname,  Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head," _
                & " dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date)" _
                & " select Cmp_id,'" & GMod.username & "',vou_no,vou_type,vou_date,Acc_head_code,acc_head,dramt,cramt,pay_mode,Cheque_no," _
                & " Narration, group_name, sub_group_name, ch_issue_date, ch_date " _
                & " from " & GMod.VENTRY & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & cmbacheadcode.Text & "' and vou_type<>'BANKREC'  and left(Uname,1)<>'$' and Pay_mode<>'-' order by vou_date,vou_no,Entry_id"
                GMod.SqlExecuteNonQuery(sqlsave)
            End If
            '------------------------------------------------------------------------------------------------

            cal_gen_bal()
            'If boolall = False Then
            '    If RadioButton1.Checked Then
            '        GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,balance  from repGeneralLedger1 where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
            '        Dim r As New CrLedger 'CrCrLedger is name of report
            '        r.SetDataSource(GMod.ds.Tables("ledPrint"))
            '        r.SetParameterValue("cmpname", GMod.Cmpname)
            '        r.SetParameterValue("accholder", "Account Holder : " & CODE & " " & HEAD)
            '        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
            '        r.SetParameterValue("uname", GMod.username)
            '        CrViewerGenralLedger.ReportSource = r
            '        'For displaying in Data grid  setting fields--------------------
            '        'rdOnscreen_Click(sender, e)
            '        '----------------------------------------------------------------
            '    Else
            '        GMod.DataSetRet("select * from repPartyLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
            '        Dim r As New partyled
            '        r.SetDataSource(GMod.ds.Tables("ledPrint"))
            '        r.SetParameterValue("cmpname", GMod.Cmpname)
            '        r.SetParameterValue("accholder", "Account Holder : " & CODE & " " & HEAD)
            '        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
            '        r.SetParameterValue("uname", GMod.username)
            '        CrViewerGenralLedger.ReportSource = r
            '    End If
            '    btnwprint.Enabled = True
            'End If 'boolall False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub cal_gen_bal()
        Try
            GMod.ds.Tables("ba").Dispose()
        Catch ex As Exception

        End Try
        If RadioButton1.Checked = True Or RadioButton2.Checked = True Or rdPary.Checked = True Then
            GMod.DataSetRet("select * from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and Narration not in ('TOTAL','BALANCE') and uname='" & GMod.username & "' order by  vou_date,vou_type,cast(vou_no as bigint)", "ba")
            Dim i As Integer
            Dim prbal, bal As Double
            prbal = 0
            prbal = GMod.ds.Tables("ba").Rows(i)("dramt") - GMod.ds.Tables("ba").Rows(i)("cramt")
            GMod.SqlExecuteNonQuery("update repGeneralLedger1 set balance=" & prbal & " where trans_id=" & GMod.ds.Tables("ba").Rows(i)("trans_id"))
            For i = 0 To GMod.ds.Tables("ba").Rows.Count - 2
                bal = prbal + (GMod.ds.Tables("ba").Rows(i + 1)("dramt") - GMod.ds.Tables("ba").Rows(i + 1)("cramt"))
                GMod.SqlExecuteNonQuery("update repGeneralLedger1 set balance=" & prbal & " where trans_id=" & GMod.ds.Tables("ba").Rows(i + 1)("trans_id"))
                prbal = bal
                GMod.SqlExecuteNonQuery("update repGeneralLedger1 set balance=" & prbal & " where trans_id=" & GMod.ds.Tables("ba").Rows(i + 1)("trans_id"))
            Next
        Else
            GMod.DataSetRet("select * from repPartyLedger where cmpid='" & GMod.Cmpid & "' and vou_type not in ('TOTAL','BALANCE')  and uname='" & GMod.username & "' order by vou_date,vou_type,cast(vou_no as bigint)", "ba1")
            Dim i As Integer = 0
            Dim prbal, bal As Double
            prbal = 0
            prbal = GMod.ds.Tables("ba1").Rows(i)("dramt") - GMod.ds.Tables("ba1").Rows(i)("cramt")
            GMod.SqlExecuteNonQuery("update repPartyLedger set balamt=" & prbal & " where transid=" & GMod.ds.Tables("ba1").Rows(i)("transid"))
            For i = 0 To GMod.ds.Tables("ba1").Rows.Count - 2
                bal = prbal + (GMod.ds.Tables("ba1").Rows(i + 1)("dramt") - GMod.ds.Tables("ba1").Rows(i + 1)("cramt"))
                GMod.SqlExecuteNonQuery("update repPartyLedger set balamt=" & prbal & " where transid=" & GMod.ds.Tables("ba1").Rows(i + 1)("transid"))
                prbal = bal
                GMod.SqlExecuteNonQuery("update repPartyLedger set balamt=" & prbal & " where transid=" & GMod.ds.Tables("ba1").Rows(i + 1)("transid"))
            Next
        End If
    End Sub
    Dim sql As String, i As Integer, n As Integer, p As Double, sqlsave As String
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim bal As Double
        btnshow_Click(sender, e)
        GMod.SqlExecuteNonQuery("delete from tmpprodint where upper(userid)='" & GMod.username.ToUpper & "'")
        Try
            sql = "select * from repGeneralLedger1 where uname='" & GMod.username & "' order by vou_date,vou_type,cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "interest")
            For i = 0 To GMod.ds.Tables("interest").Rows.Count - 1
                'GMod.ds.Tables("interest").Rows(i)("vou_date")
                'If CDate(GMod.ds.Tables("interest").Rows(i)("vou_date")) <> CDate(GMod.ds.Tables("interest").Rows(i + 1)("vou_date")) Then
                'sql = "select q.account_code,q.account_head_name," _
                '& " ClosingDr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0 then  (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) else 0 end, " _
                '& " ClosingCr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then  abs((isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0))) else 0 end " _
                '& "from" _
                '& "(select  isnull(Acc_head_code,'') Acc_head_code , isnull(Acc_head,'') Acc_head , isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr " _
                '& " from  " & GMod.VENTRY _
                '& " where group_name='" & cmbgrpname.Text & "' and Acc_head_code='" & cmbacheadcode.Text & "' and vou_date<='" & CDate(GMod.ds.Tables("interest").Rows(i)("vou_date")) & "'   group by Acc_head_code,Acc_head  ) p " _
                '& " Right Join " _
                '& " ( select isnull(account_code,'') account_code ,account_head_name,isnull(opening_dr,0) od,isnull(opening_cr,0)  oc from " & GMod.ACC_HEAD _
                '& "  where group_name='" & cmbgrpname.Text & "'  and account_code='" & cmbacheadcode.Text & "') q on q.account_code=p.Acc_head_code order by p.Acc_head"
                'GMod.DataSetRet(sql, "closebal")

                'Dim bal As Double
                'If GMod.ds.Tables("closebal").Rows(0)(2) > 0 Then
                '    bal = -1 * Val(GMod.ds.Tables("closebal").Rows(0)(2))
                'Else
                '    bal = Val(GMod.ds.Tables("closebal").Rows(0)(3))
                'End If
                'MsgBox(GMod.ds.Tables("interest").Rows(i)("Balance"))
                If Val(GMod.ds.Tables("interest").Rows(i)("balance")) < 0 Then
                    'MsgBox(GMod.ds.Tables("interest").Rows(i)("balance"))
                    bal = -1 * Val(GMod.ds.Tables("interest").Rows(i)("balance"))
                    ' MsgBox(bal)
                Else
                    bal = -1 * Val(GMod.ds.Tables("interest").Rows(i)("balance"))
                End If
                n = DateDiff(DateInterval.Day, CDate(GMod.ds.Tables("interest").Rows(i)("vou_date")), CDate(GMod.ds.Tables("interest").Rows(i + 1)("vou_date")))
                p = (Val(txtintrate.Text) / 36500) * n * bal
                ' MsgBox(p)
                sqlsave = "Insert into tmpprodint(transdate, diffdays, closebal, cmpid, userid,intval) values ("
                sqlsave &= "'" & CDate(GMod.ds.Tables("interest").Rows(i)("vou_date")) & "',"
                sqlsave &= "'" & n & "',"
                sqlsave &= "'" & GMod.ds.Tables("interest").Rows(i)("balance") & "',"
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'" & p & "')"
                GMod.SqlExecuteNonQuery(sqlsave)
                'End If
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        sql = "select abs(datediff(day,mdate,'" & dtto.Value & "')) from (" _
        & " select max(vou_date) mdate from repGeneralLedger1  where uname ='" & GMod.username & "'   ) p "

        GMod.DataSetRet(sql, "mdate")
        'n = GMod.ds.Tables("mdate").Rows(0)(0)
        'p = (Val(txtintrate.Text) / 36500) * n * Val(GMod.ds.Tables("interest").Rows(i)("balance"))

        'bal = GMod.ds.Tables("interest").Rows(i)("balance")

        If Val(GMod.ds.Tables("interest").Rows(i)("balance")) < 0 Then
            'MsgBox(GMod.ds.Tables("interest").Rows(i)("balance"))
            bal = -1 * Val(GMod.ds.Tables("interest").Rows(i)("balance"))
            ' MsgBox(bal)
        Else
            bal = -1 * Val(GMod.ds.Tables("interest").Rows(i)("balance"))
        End If
        n = GMod.ds.Tables("mdate").Rows(0)(0)
        p = (Val(txtintrate.Text) / 36500) * n * bal

        sqlsave = "Insert into tmpprodint(transdate, diffdays, closebal, cmpid, userid,intval) values ("
        sqlsave &= "'" & dtto.Value & "',"
        sqlsave &= "'" & n & "',"
        sqlsave &= "'" & GMod.ds.Tables("interest").Rows(i)("balance") & "',"
        sqlsave &= "'" & GMod.Cmpid & "',"
        sqlsave &= "'" & GMod.username & "',"
        sqlsave &= "'" & p & "')"
        GMod.SqlExecuteNonQuery(sqlsave)


        GMod.DataSetRet("select * from tmpprodint where userid='" & GMod.username & "' order by transdate ", "intrep")
        Dim cr1 As New CrInterest
        cr1.SetDataSource(GMod.ds.Tables("intrep"))
        cr1.SetParameterValue("0", GMod.Cmpname)
        cr1.SetParameterValue("1", "Date From  " & dtfrom.Text & " To " & dtto.Text)
        cr1.SetParameterValue("2", cmbacheadname.Text)
        cr1.SetParameterValue("3", "Intrest rate " & txtintrate.Text & " %")
        CrystalReportViewer1.ReportSource = cr1
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        cmbgrpname.Text = "INTERNAL PARTY"
        cmbgrpname.Enabled = False
        Dim sql As String
        sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
               & " and group_name  in ('INTERNAL PARTY') order by account_head_name "
        GMod.DataSetRet(sql, "acchead")
        cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
        cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("acchead")
        cmbacheadname.DisplayMember = "account_head_name"
    End Sub
End Class