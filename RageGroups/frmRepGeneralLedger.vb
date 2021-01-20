Imports System.IO
Imports System.Diagnostics
Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Shared

Public Class frmRepGeneralLedger

    Private Sub frmRepGeneralLedger_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
        'Try
        '    File.Delete("c:\Ledger.txt")
        'Catch ex As Exception
        '    'MsgBox(ex.Message)
        'End Try
        CrViewerGenralLedger.Dispose()
    End Sub

    Private Sub frmRepGeneralLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbgrpname.Focus()
        'If GMod.role = "ADMIN" Or GMod.role = "VIEWER LEVEL-1" Then

        'Else
        '    CrViewerGenralLedger.ShowExportButton = False
        'End If


        dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtfrom.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        dtto.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtto.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        btnwprint.Enabled = False
        CrViewerGenralLedger.BringToFront()
        CrViewerGenralLedger.ShowPrintButton = False
        rdPrint_Click(sender, e)
        panel1.Visible = False
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
            Select Case GMod.role.ToUpper
                Case "ADMIN", "VIEWER LEVEL-1"
                    rdPary.Enabled = True
                    RadioButton1.Enabled = True
                    Dim sql As String
                    sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                           & " and group_name not in ('PARTY','CUSTOMER') order by account_code"
                    GMod.DataSetRet(sql, "acchead")
                    cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
                    cmbacheadcode.DisplayMember = "account_code"

                    cmbacheadname.DataSource = GMod.ds.Tables("acchead")
                    cmbacheadname.DisplayMember = "account_head_name"
                Case Else
                    rdPary.Enabled = True
                    RadioButton1.Enabled = True
                    Dim sql As String
                    sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                     & " and group_name not in ('PARTY','CUSTOMER') order by account_code"
                    GMod.DataSetRet(sql, "acchead")
                    cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
                    cmbacheadcode.DisplayMember = "account_code"

                    cmbacheadname.DataSource = GMod.ds.Tables("acchead")
                    cmbacheadname.DisplayMember = "account_head_name"
            End Select
        End If
        RadioButton1_Click(sender, e)
        cmbgrpname_SelectedIndexChanged(sender, e)
        Me.Text = Me.Text & "    [" & GMod.Cmpname & "]"
        'Seeting Session Start DATE
        Dim sdate As String = "4/1/" & GMod.Session.Substring(0, 2).ToString
        dtfrom.Value = CDate(sdate)
        fillArea()

        cmbAreaCode.Text = "JB"

        CrViewerGenralLedger.Height = Me.Height - 198
        dgGridLeger.Location = CrViewerGenralLedger.Location
        dgParty.Location = CrViewerGenralLedger.Location

        dgGridLeger.Height = CrViewerGenralLedger.Height
        dgGridLeger.Width = CrViewerGenralLedger.Width

        dgParty.Height = CrViewerGenralLedger.Height
        dgParty.Width = CrViewerGenralLedger.Width
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
    Dim HEAD As String = ""
    Dim CODE As String = ""

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

            HEAD = cmbacheadname.Text
            CODE = cmbacheadcode.Text
            'dleting old data for that use 
            GMod.SqlExecuteNonQuery("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
            GMod.SqlExecuteNonQuery("delete  from repPartyLedger where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
            'Calulating openng and inserint into table 


            Dim sqlopen As String
            Dim opnbal, dr, cr As Double
            opnbal = 0
            dr = 0
            cr = 0
            Try
                GMod.ds.Tables("opening").Clear()
            Catch ex As Exception

            End Try
            sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                      & " " & GMod.VENTRY & " where Acc_head_code='" & cmbacheadcode.Text & "' and  vou_date<'" & dtfrom.Text & "' and vou_type<>'BANKREC' and Pay_mode<>'-'"
            GMod.DataSetRet(sqlopen, "opening")
            opnbal = CDbl(GMod.ds.Tables("opening").Rows(0)(0))
            Try
                GMod.ds.Tables("opening").Clear()
            Catch ex As Exception

            End Try
            sqlopen = "select isnull(sum(opening_dr),0) - isnull(sum(opening_cr),0) from " & GMod.ACC_HEAD _
                       & " where Account_code='" & cmbacheadcode.Text & "'"
            GMod.DataSetRet(sqlopen, "opening")
            opnbal = opnbal + CDbl(GMod.ds.Tables("opening").Rows(0)(0))
            Try
                GMod.ds.Tables("opening").Clear()
            Catch ex As Exception

            End Try
            'MsgBox(opnbal.ToString)
            If opnbal > 0 Then
                dr = opnbal
                cr = 0
            Else
                dr = 0
                cr = -1 * opnbal
            End If
            Dim sqlsave As String
            If rdwithopening.Checked = True Then
                If RadioButton1.Checked Then
                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & cmbacheadcode.Text & "',"
                    sqlsave &= "'OLD BALANCE',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & dr.ToString & "',"
                    sqlsave &= "'" & cr.ToString & "',"
                    sqlsave &= "'" & GMod.username & "')"
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
                    GMod.SqlExecuteNonQuery(sqlsave)
                End If
            End If
            '------------------------------------------------------------------------------------------------------
            'Now inserting transtion os that accont head 
            If RadioButton1.Checked Then
                sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no, Uname) " _
                & " select Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & cmbacheadcode.Text & "' and vou_type<>'BANKREC' and left(Uname,1)<>'$' and Pay_mode<>'-'order by vou_date,vou_no"
                GMod.SqlExecuteNonQuery(sqlsave)
            Else
                sqlsave = "insert into repPartyLedger(Cmpid, Uname,  Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head," _
                & " dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date)" _
                & " select Cmp_id,'" & GMod.username & "',vou_no,vou_type,vou_date,Acc_head_code,acc_head,dramt,cramt,pay_mode,Cheque_no," _
                & " Narration, group_name, sub_group_name, ch_issue_date, ch_date " _
                & " from " & GMod.VENTRY & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & cmbacheadcode.Text & "' and vou_type<>'BANKREC' and Pay_mode<>'-' and left(Uname,1)<>'$' order by vou_date,vou_no,Entry_id"
                GMod.SqlExecuteNonQuery(sqlsave)
            End If
            '------------------------------------------------------------------------------------------------

            'Deleyting Zero Valus
            GMod.SqlExecuteNonQuery("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and vou_type<>'OPEN' and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
            GMod.SqlExecuteNonQuery("delete from repPartyLedger where (dramt=0 and cramt=0) and vou_type<>'OPEN' and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")

            'For Ledger Sisde Balance
            'cal_gen_bal() For Ledger Sisde Balance
            If boolall = False Then
                'Getting Acc Name From 
                GMod.DataSetRet("select account_head_name from " & GMod.ACC_HEAD & " where account_code='" & cmbacheadcode.Text & "'", "ledhanedname")
                If RadioButton1.Checked Then
                    GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,balance  from repGeneralLedger1 where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
                    Dim r As New CrLedger 'CrCrLedger is name of report
                    r.SetDataSource(GMod.ds.Tables("ledPrint"))
                    r.SetParameterValue("cmpname", GMod.Cmpname)
                    r.SetParameterValue("accholder", "Account Holder : " & CODE & " " & GMod.ds.Tables("ledhanedname").Rows(0)(0).ToString())
                    r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
                    r.SetParameterValue("uname", GMod.username)
                    r.SetParameterValue("unauth", "")
                    CrViewerGenralLedger.ReportSource = r
                    'For displaying in Data grid  setting fields--------------------
                    'rdOnscreen_Click(sender, e)
                    '----------------------------------------------------------------
                    r = Nothing
                Else
                    GMod.DataSetRet("select * from repPartyLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
                    Dim r As New partyled
                    r.SetDataSource(GMod.ds.Tables("ledPrint"))
                    r.SetParameterValue("cmpname", GMod.Cmpname)
                    r.SetParameterValue("accholder", "Account Holder : " & CODE & " " & GMod.ds.Tables("ledhanedname").Rows(0)(0).ToString())
                    r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
                    r.SetParameterValue("uname", GMod.username)
                    r.SetParameterValue("unauth", "")
                    CrViewerGenralLedger.ReportSource = r
                    r = Nothing
                End If
                btnwprint.Enabled = True
            End If 'boolall False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub cal_gen_bal()
        Try
            GMod.ds.Tables("ba").Dispose()
        Catch ex As Exception

        End Try
        If RadioButton1.Checked = True Then
            GMod.DataSetRet("select * from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and Narration not in ('TOTAL','BALANCE') and uname='" & GMod.username & "' order by trans_id", "ba")
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
            GMod.DataSetRet("select * from repPartyLedger where cmpid='" & GMod.Cmpid & "' and vou_type not in ('TOTAL','BALANCE')  and uname='" & GMod.username & "' order by transid", "ba1")
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
    Sub total()
        Dim sqlsave As String
        If RadioButton1.Checked Then

            'Inserting Total and Balance
            sqlsave = " insert into repGeneralLedger1(cmpid, Narration,vou_type, " _
                       & " dramt, cramt, Uname) select '" & GMod.Cmpid & "','TOTAL','-',sum(dramt),sum(cramt) ,'" & GMod.username & "' from repGeneralLedger1 where Uname='" & GMod.username & "'"
            GMod.SqlExecuteNonQuery(sqlsave)


            sqlsave = "insert into repGeneralLedger1(cmpid, Narration,vou_type, " _
                       & "dramt, cramt, Uname) select '" & GMod.Cmpid & "','BALANCE','-',case " _
                        & "when sum(dramt)-sum(cramt)>0 then sum(dramt)-sum(cramt)" _
                        & "else 0 end dr,case 	when sum(dramt)-sum(cramt)<0 then sum(dramt)-sum(cramt)" _
                        & "else 0 end ,'" & GMod.username & "' from  repGeneralLedger1 where Uname='" & GMod.username & "' and Narration<>'TOTAL'"
        Else
            sqlsave = " insert into repPartyLedger(cmpid, Narration,vou_type, " _
                                  & " dramt, cramt, Uname) select '" & GMod.Cmpid & "','TOTAL','-',sum(dramt),sum(cramt) ,'" & GMod.username & "' from repPartyLedger where Uname='" & GMod.username & "'"
            GMod.SqlExecuteNonQuery(sqlsave)
            sqlsave = "insert into repPartyLedger(cmpid, Narration,vou_type, " _
                       & "dramt, cramt, Uname) select '" & GMod.Cmpid & "','BALANCE','-',case " _
                        & "when sum(dramt)-sum(cramt)>0 then sum(dramt)-sum(cramt)" _
                        & "else 0 end dr,case 	when sum(dramt)-sum(cramt)<0 then sum(dramt)-sum(cramt)" _
                        & "else 0 end ,'" & GMod.username & "' from  repPartyLedger where Uname='" & GMod.username & "' and Narration<>'TOTAL'"
        End If
        GMod.SqlExecuteNonQuery(sqlsave)
    End Sub
    Sub interest()
        Dim sql As String = "select * from repPartyLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by vou_date"
        GMod.DataSetRet(sql, "int")
        Dim i, nodays As Integer
        Dim bal, int, print As Double
        Dim prdate As Date
        For i = 0 To GMod.ds.Tables("int").Rows.Count - 2
            'MsgBox(GMod.ds.Tables("int").Rows(i)("vou_date") & "  " & GMod.ds.Tables("int").Rows(i + 1)("vou_date"))
            If CDate(GMod.ds.Tables("int").Rows(i)("vou_date").ToString) <> CDate(GMod.ds.Tables("int").Rows(i + 1)("vou_date").ToString) Then
                prdate = CDate(GMod.ds.Tables("int").Rows(i)("vou_date").ToString)
                bal = closeing(cmbacheadcode.Text, GMod.ds.Tables("int").Rows(i)("vou_date").ToString)
                If Val(lblintrule.Text) = 1 Then
                    nodays = DateDiff(DateInterval.Day, CDate(GMod.ds.Tables("int").Rows(i)("vou_date").ToString), CDate(GMod.ds.Tables("int").Rows(i + 1)("vou_date").ToString))
                ElseIf Val(lblintrule.Text) = 2 Then
                    nodays = DateDiff(DateInterval.Day, CDate(GMod.ds.Tables("int").Rows(i)("vou_date").ToString), CDate(GMod.ds.Tables("int").Rows(i + 1)("vou_date").ToString))
                End If
                Dim p As Double
                If lblinttype.Text = "Monthly" Then
                    p = nodays / 30
                ElseIf lblinttype.Text = "Yearly" Then
                    p = nodays / 365
                ElseIf lblinttype.Text = "Half Yearly" Then
                    p = nodays / 180
                End If
                int = ((bal + int) * p) * Val(lblintper.Text) / 100
                print = print + int
                GMod.SqlExecuteNonQuery("update repPartyLedger set intamt = " & int & " where transid=" & GMod.ds.Tables("int").Rows(i)("transid"))
                GMod.SqlExecuteNonQuery("update repPartyLedger set intbal = " & print & " where transid=" & GMod.ds.Tables("int").Rows(i)("transid"))
            End If
        Next
        'calculate for last
        'i = i - 1
        bal = closeing(cmbacheadcode.Text, GMod.ds.Tables("int").Rows(i)("vou_date").ToString)
        If Val(lblintrule.Text) = 1 Then
            nodays = DateDiff(DateInterval.Day, CDate(GMod.ds.Tables("int").Rows(i)("ch_date").ToString), dtto.Value)
        ElseIf Val(lblintrule.Text) = 2 Then
            nodays = DateDiff(DateInterval.Day, CDate(GMod.ds.Tables("int").Rows(i)("vou_date").ToString), dtto.Value)
        End If
        int = ((bal + int) * nodays) * Val(lblintper.Text) / 100
        print = print + int
        GMod.SqlExecuteNonQuery("update repPartyLedger set intamt = " & int & " where transid=" & GMod.ds.Tables("int").Rows(i)("transid"))
        GMod.SqlExecuteNonQuery("update repPartyLedger set intbal = " & print & " where transid=" & GMod.ds.Tables("int").Rows(i)("transid"))
    End Sub
    Function closeing(ByVal accode As String, ByVal dt As Date) As Double
        Dim sqlopen As String
        Dim closebal As Double
        sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                  & " " & GMod.VENTRY & " where Acc_head_code='" & accode & "' and  vou_date<='" & dt & "' and vou_type<>'BANKREC'"
        GMod.DataSetRet(sqlopen, "opening")
        closebal = CDbl(GMod.ds.Tables("opening").Rows(0)(0))
        GMod.ds.Tables("opening").Clear()
        sqlopen = "select isnull(sum(opening_dr),0) - isnull(sum(opening_cr),0) from " & GMod.ACC_HEAD _
                   & " where Account_code='" & accode & "'"
        GMod.DataSetRet(sqlopen, "opening")
        closebal = closebal + CDbl(GMod.ds.Tables("opening").Rows(0)(0))
        GMod.ds.Tables("opening").Clear()
        closeing = closebal
    End Function
    Private Sub rdPary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPary.CheckedChanged
        cmbgrpname.Text = "PARTY"
        cmbgrpname.Enabled = False
        Dim sql As String
        sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
               & " and group_name  in ('PARTY') order by account_code "
        GMod.DataSetRet(sql, "acchead")
        cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
        cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("acchead")
        cmbacheadname.DisplayMember = "account_head_name"

        chklistled.Items.Clear()
        For rw = 0 To GMod.ds.Tables("acchead").Rows.Count - 1
            chklistled.Items.Add(GMod.ds.Tables("acchead").Rows(rw)("account_code") & "#" & GMod.ds.Tables("acchead").Rows(rw)("account_head_name"))
        Next

    End Sub

    Private Sub drcustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drcustomer.CheckedChanged
        cmbgrpname.Text = "CUSTOMER"
        cmbgrpname.Enabled = False
        Dim sql As String
        sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
               & " and group_name  in ('CUSTOMER') and Area_code='" & cmbAreaCode.Text & "' order by account_code"
        GMod.DataSetRet(sql, "acchead")
        cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
        cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("acchead")
        cmbacheadname.DisplayMember = "account_head_name"
        chklistled.Items.Clear()
        For rw = 0 To GMod.ds.Tables("acchead").Rows.Count - 1
            chklistled.Items.Add(GMod.ds.Tables("acchead").Rows(rw)("account_code") & "#" & GMod.ds.Tables("acchead").Rows(rw)("account_head_name"))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub cmbacheadcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadcode.Leave
        btnwprint.Enabled = False
        'btnshow_Click(sender, e)
        'MsgBox("Please Press Show button then ,PRINT", MsgBoxStyle.Information)
    End Sub
    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged
        btnwprint.Enabled = False
        'Try
        '    If cmbacheadcode.Text <> "" Then
        '        Dim sql As String
        '        sql = "select group_name,sub_group_name,rate_of_interest,interest_rule_id,remark3 from " & GMod.ACC_HEAD & " where account_code='" & cmbacheadcode.Text & "'"
        '        GMod.DataSetRet(sql, "sub_grp")
        '        cmbgrpname.Text = GMod.ds.Tables("sub_grp").Rows(0)(0)
        '        cmbsubgrpname.Text = GMod.ds.Tables("sub_grp").Rows(0)(1)
        '        lblintper.Text = GMod.ds.Tables("sub_grp").Rows(0)(2)
        '        lblintrule.Text = GMod.ds.Tables("sub_grp").Rows(0)(3)
        '        lblinttype.Text = GMod.ds.Tables("sub_grp").Rows(0)(4)
        '    Else
        '        lblintper.Text = ""
        '        lblintrule.Text = ""
        '        lblinttype.Text = ""
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cmbacheadcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadcode.KeyDown
        If e.KeyCode = Keys.Enter Then dtfrom.Focus()
        'If e.KeyCode = Keys.Enter Then cmbacheadname.Focus()
    End Sub

    Private Sub cmbacheadname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacheadcode.Focus()
    End Sub

    Private Sub dtfrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtfrom.KeyDown
        If e.KeyCode = Keys.Enter Then dtto.Focus()
    End Sub

    Private Sub dtto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtto.KeyDown
        If e.KeyCode = Keys.Enter Then btnshow.Focus()
    End Sub

    Private Sub CheckBoxArea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxArea.CheckedChanged
        If CheckBoxArea.Checked = True Then
            If RadioButton1.Checked = True Then
                Dim sql As String
                sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                       & " and group_name ='" & cmbgrpname.Text & "' and Area_code='" & cmbAreaCode.Text & "' order by account_code"
                GMod.DataSetRet(sql, "acchead")
                cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
                cmbacheadcode.DisplayMember = "account_code"

                cmbacheadname.DataSource = GMod.ds.Tables("acchead")
                cmbacheadname.DisplayMember = "account_head_name"
            End If
            If rdPary.Checked = True Then
                Dim sql As String
                sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                       & " and group_name in ('PARTY') and Area_code='" & cmbAreaCode.Text & "' order by account_code"
                GMod.DataSetRet(sql, "acchead")
                cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
                cmbacheadcode.DisplayMember = "account_code"

                cmbacheadname.DataSource = GMod.ds.Tables("acchead")
                cmbacheadname.DisplayMember = "account_head_name"
            End If
            If drcustomer.Checked = True Then
                Dim sql As String
                sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                       & " and group_name in ('CUSTOMER') and Area_code='" & cmbAreaCode.Text & "' order by account_code"
                GMod.DataSetRet(sql, "acchead")
                cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
                cmbacheadcode.DisplayMember = "account_code"

                cmbacheadname.DataSource = GMod.ds.Tables("acchead")
                cmbacheadname.DisplayMember = "account_head_name"
            End If
        End If
        chklistled.Items.Clear()
        For rw = 0 To GMod.ds.Tables("acchead").Rows.Count - 1
            chklistled.Items.Add(GMod.ds.Tables("acchead").Rows(rw)("account_code") & "#" & GMod.ds.Tables("acchead").Rows(rw)("account_head_name"))
        Next
    End Sub

    Private Sub rdPary_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdPary.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacheadcode.Focus()
    End Sub

    Private Sub drcustomer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drcustomer.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacheadcode.Focus()
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Select Case GMod.role.ToUpper
            Case "ADMIN"
                If RadioButton1.Checked = True Then
                    cmbgrpname.Enabled = True
                    'If GMod.Dept = 0 Then
                    GMod.DataSetRet("select distinct group_name from " & GMod.ACC_HEAD & " where  group_name NOT IN('PARTY','CUSTOMER','INTERNAL PARTY') order by group_name", "grp")
                    'Else
                    'GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "' and group_name NOT IN('PARTY','CUSTOMER','INTERNAL PARTY','STAFF') order by group_name", "grp")

                    'End If
                    cmbgrpname.DataSource = GMod.ds.Tables("grp")
                    cmbgrpname.DisplayMember = "group_name"
                    cmbgrpname_SelectedIndexChanged(sender, e)
                End If
            Case Else
                If RadioButton1.Checked = True Then
                    cmbgrpname.Enabled = True
                    If GMod.staff1 = 1 And GMod.role = "VIEWER LEVEL-1" Then
                        GMod.DataSetRet("select distinct group_name from " & GMod.ACC_HEAD & " where group_name NOT IN('PARTY','CUSTOMER','INTERNAL PARTY','STAFF(HO)') order by group_name", "grp")
                    ElseIf GMod.staff1 = 2 And GMod.role = "VIEWER LEVEL-1" Then
                        GMod.DataSetRet("select distinct group_name from " & GMod.ACC_HEAD & " where group_name NOT IN('PARTY','CUSTOMER','INTERNAL PARTY') order by group_name", "grp")
                    Else
                        GMod.DataSetRet("select distinct group_name from " & GMod.ACC_HEAD & " where group_name NOT IN('PARTY','CUSTOMER','INTERNAL PARTY','STAFF','STAFF(HO)') order by group_name", "grp")
                    End If
                    cmbgrpname.DataSource = GMod.ds.Tables("grp")
                    cmbgrpname.DisplayMember = "group_name"
                    cmbgrpname_SelectedIndexChanged(sender, e)
                End If
        End Select
    End Sub

    Private Sub RadioButton1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RadioButton1.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacheadcode.Focus()
    End Sub
    Private Sub rdOnscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdOnscreen.Click
        Try
            GMod.ds.Tables("led").Dispose()
        Catch ex As Exception

        End Try
        Try
            GMod.ds.Tables("ledParty").Dispose()
        Catch ex As Exception

        End Try

        If rdOnscreen.Checked = True Then
            dgGridLeger.BringToFront()
            CrViewerGenralLedger.SendToBack()
            If RadioButton1.Checked Then
                total()
                GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,balance  from repGeneralLedger1 where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by trans_id", "led")
                Me.dgParty.Visible = False
                Me.dgGridLeger.Visible = True
                Me.dgGridLeger.DataSource = GMod.ds.Tables("led")
            Else
                total()
                GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,balamt  from repPartyLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by transid", "ledParty")
                Me.dgGridLeger.Visible = False
                Me.dgParty.Visible = True
                Me.dgParty.DataSource = GMod.ds.Tables("ledParty")
            End If
            rdOnscreen.Enabled = False
            rdPrint.Enabled = True
        End If
    End Sub

    Private Sub rdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPrint.Click
        If rdPrint.Checked = True Then
            dgGridLeger.SendToBack()
            CrViewerGenralLedger.BringToFront()
            If RadioButton1.Checked Then
                GMod.SqlExecuteNonQuery("delete from repGeneralLedger1 where narration in ('TOTAL','BALANCE') AND cmpid='" & GMod.Cmpid & "'")
            Else
                GMod.SqlExecuteNonQuery("delete from repPartyLedger where narration in ('TOTAL','BALANCE') AND cmpid='" & GMod.Cmpid & "'")
            End If
            rdOnscreen.Enabled = False
            rdPrint.Enabled = False
        End If
    End Sub
    Dim sw As StreamWriter
    Dim ln, pageno As Integer
    Sub header(ByVal code As String, ByVal name As String)
        pageno = pageno + 1
        Dim i As Integer
        sw.WriteLine("")
        Dim s As String
        For i = 0 To 50
            s = s + " "
        Next
        s = s & Convert.ToChar(14).ToString & GMod.Cmpname.ToUpper
        sw.WriteLine(s)
        s = ""
        For i = 0 To 50
            s = s + " "
        Next
        s = s & "LEDGER :" & Convert.ToChar(20).ToString & name & " " & code
        sw.WriteLine(s)

        s = "Date: " + dtfrom.Text.ToUpper() + " TO " + dtto.Text.ToUpper()
        For i = 0 To 85
            s = s + " "
        Next
        s = s + "Page No: " & pageno
        sw.WriteLine(s)
        s = ""
        sw.WriteLine("------------------------------------------------------------------------------------------------------------------------------------")
        s = ""
        sw.WriteLine("   DATE                       PARTICULAR                                      DOC NO         DEBIT R/s       CREDIT R/s")
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------")
        ln = ln + 6
    End Sub
    Private Sub btnDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDos.Click
        sw = File.CreateText("Ledger.txt")
        LedgerDOSPrint(cmbacheadcode.Text, cmbacheadname.Text)
        Try

            sw.Close()
            Dim p As New Process
            p.StartInfo.FileName = "printfile.bat"
            p.StartInfo.Arguments = "Ledger.txt"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()

            cmbacheadname.Enabled = True
            cmbacheadcode.Enabled = True
            cmbgrpname.Enabled = True
            cmbsubgrpname.Enabled = True
            btnDos.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim flag As Boolean
    Public Sub LedgerDOSPrint(ByVal code As String, ByVal name As String)
        flag = False
        'Dim sql As String
        'If RadioButton1.Checked Then
        '    sql = "select min(vou_date) from repGeneralLedger where Uname='" & GMod.username & "'"
        '    GMod.DataSetRet(sql, "XZ")
        '    If dtfrom.Value > CDate(GMod.ds.Tables("XZ").Rows(0)(0)) Then
        '        Me.Close()
        '    End If
        'Else
        '    sql = "select min(vou_date) from repGeneralLedger1 where Uname='" & GMod.username & "'"
        '    GMod.DataSetRet(sql, "XZ")
        '    If dtfrom.Value > CDate(GMod.ds.Tables("XZ").Rows(0)(0)) Then
        '        Me.Close()
        '    End If

        'End If
        Dim narration, displaydate As String
        Dim dt() As String
        Dim cr, dr As Double
        cr = 0
        dr = 0
        Dim re As Integer = 0
        ln = 1
        Dim s As String = ""

        'pageno = 0
        Try
            If filef = True Then
                If Not Directory.Exists("LedgerFle") Then
                    Directory.CreateDirectory("LedgerFle")
                Else

                End If
                sw = File.CreateText("LedgerFle\\" & code & ".txt")
            Else
                'sw = File.CreateText("c:\\Ledger.txt")
            End If


            Dim sqlledger As String
            If RadioButton1.Checked = True Then
                sqlledger = " select Narration, d.Vou_type vou_type, Vou_no, dramt, cramt, " _
                            & " [Cheque_No],  Vou_date,v.vprefix  vprefix  from repGeneralLedger1 d " _
                            & " left join vtype v  on d.vou_type=v.vtype and d.cmpid=v.Cmp_id where upper(uname)='" & GMod.username.ToUpper & "' and " _
                            & " v.cmp_id='" & GMod.Cmpid & "'  order by Vou_date,cast(Vou_no as bigint) "
            Else
                sqlledger = " select Narration, d.Vou_type vou_type, Vou_no, dramt, cramt, " _
                            & " [Cheque_No],  Vou_date,v.vprefix  vprefix  from dbo.repPartyLedger d " _
                            & " left join vtype v  on d.vou_type=v.vtype  and d.cmpid=v.Cmp_id  where upper(uname)='" & GMod.username.ToUpper & "' and " _
                            & " v.cmp_id='" & GMod.Cmpid & "'  order by Vou_date,cast(Vou_no as bigint) "
            End If

            Try
                GMod.ds.Tables("Ledger").Dispose()
            Catch ex As Exception

            End Try
            Try
                GMod.ds.Tables("Ledger").Clear()
            Catch ex As Exception

            End Try

            GMod.DataSetRet(sqlledger, "Ledger")
            'MsgBox(GMod.ds.Tables("Ledger").Rows.Count)
            If Val(GMod.ds.Tables("Ledger").Rows.Count) = 1 Then
                If Math.Abs(Val(GMod.ds.Tables("Ledger").Rows(0)("dramt")) - Val(GMod.ds.Tables("Ledger").Rows(0)("cramt"))) > 0 Then
                    flag = True
                Else
                    Exit Sub
                End If
            Else
                'If Math.Abs(CDbl(GMod.ds.Tables("Ledger").Rows(1)("dramt")) - CDbl(GMod.ds.Tables("Ledger").Rows(1)("cramt"))) > 0 Then
                'Else
                '    Exit Sub
                'End If
                flag = True
            End If

            header(code, name)
            For re = 0 To GMod.ds.Tables("Ledger").Rows.Count - 1
                dr = dr + CDbl(GMod.ds.Tables("Ledger").Rows(re)("dramt"))
                cr = cr + CDbl(GMod.ds.Tables("Ledger").Rows(re)("cramt"))
                s = "   "
                If GMod.ds.Tables("Ledger").Rows(re)("Vou_date").ToString.Length > 0 Then
                    dt = GMod.ds.Tables("Ledger").Rows(re)("Vou_date").ToString.Split("/")
                    displaydate = dt(1) & "/" & dt(0) & "/" & dt(2).Substring(0, 4)
                End If
                s = s & displaydate
                While (s.Length <= 15)
                    s = s & " "
                End While

                narration = ""
                If GMod.ds.Tables("Ledger").Rows(re)("Cheque_No").ToString.Length > 1 Then
                    narration = GMod.ds.Tables("Ledger").Rows(re)("narration").ToString & " CHQ NO. " & GMod.ds.Tables("Ledger").Rows(re)("Cheque_No").ToString
                Else
                    narration = GMod.ds.Tables("Ledger").Rows(re)("narration").ToString
                End If
                'MsgBox(narration.Contains(vbNewLine))
                GMod.spliterbook(narration)
                s = s & sp1(0)
                'adding blank space if naration less than 60
                While (s.Length < 79)
                    s = s & " "
                End While
                s = s & " "

                If GMod.ds.Tables("Ledger").Rows(re)("vou_type").ToString = "OPEN" Then
                    s = s & "    "
                Else
                    s = s & GMod.ds.Tables("Ledger").Rows(re)("vprefix").ToString & "/" & GMod.ds.Tables("Ledger").Rows(re)("vou_no")
                End If
                While (s.Length < 89)
                    s = s & " "
                End While

                If GMod.ds.Tables("Ledger").Rows(re)("dramt") > 0 Then s = s & Format(GMod.ds.Tables("Ledger").Rows(re)("dramt"), "0.00").PadLeft(12, " ") Else s = s & "                 "
                If GMod.ds.Tables("Ledger").Rows(re)("cramt") > 0 Then s = s & Format(GMod.ds.Tables("Ledger").Rows(re)("cramt"), "0.00").PadLeft(12, " ") Else s = s & "            "
                sw.WriteLine(s)
                ln = ln + 1
                'Next Line
                s = "   "
                While (s.Length <= 15)
                    s = s & " "
                End While
                Dim rema As String
                rema = sp1(1)
                If rema.Length > 2 Then
                    s = s & sp1(1)
                    'adding blank space if naration less than 60
                    'earlier it was 97
                    While (s.Length < 76)
                        s = s & " "
                    End While
                    sw.WriteLine(s)
                    ln = ln + 1
                    'w.WriteLine("")
                End If

                If Len(sp1(2)) > 0 Then
                    s = ""
                    While (s.Length <= 15)
                        s = s & " "
                    End While
                    s = s & sp1(2)
                    sw.WriteLine(s)
                    ln = ln + 1
                    'sw.WriteLine("")
                End If
                sw.WriteLine("")
                ln = ln + 1
                If ln > 63 Then
                    sw.WriteLine(Convert.ToChar(12).ToString)
                    ln = 1
                    header(code, name)
                    'pageno = pageno + 1
                End If
            Next
            sw.WriteLine("")
            Dim ptotal As String = ""
            ptotal = "                                    TOTAL"
            ptotal = ptotal & "                                               " & Format(dr, "0.00").PadLeft(12, " ")
            ptotal = ptotal & "     " & Format(cr, "0.00").PadLeft(12, " ")
            sw.WriteLine("------------------------------------------------------------------------------------------------------------------------------------")
            sw.WriteLine(ptotal)
            sw.WriteLine("------------------------------------------------------------------------------------------------------------------------------------")
            sw.WriteLine("")
            Dim pbal As String = ""
            pbal = "                                    BALANCE "
            dr = dr - cr
            If dr > 0 Then
                pbal = pbal & "                                           " & Format(Math.Abs(dr), "0.00").PadLeft(12, " ") & " " & "Dr"
            Else
                pbal = pbal & "                                                          " & Format(Math.Abs(dr), "0.00").PadLeft(12, " ") & " " & "Cr"
            End If
            sw.WriteLine(pbal)
            sw.WriteLine(Convert.ToChar(12).ToString)
            'sw.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim boolall As Boolean = False
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        boolall = True
        Dim z As Integer, k As Double
        For z = 0 To cmbacheadcode.Items.Count - 1
            'pageno = 0
            cmbacheadcode.SelectedIndex = z
            btnshow_Click(sender, e)
            'MsgBox(cmbacheadname.Text)
            'sw.WriteLine(Convert.ToChar(12).ToString)


            LedgerDOSPrint(cmbacheadcode.Text, cmbacheadname.Text)
            'Dim p As New Process
            'p.StartInfo.FileName = "ledger.bat"
            'p.Start()
            'sw.Close()
            'If flag = True Then
            sw.Close()
            Dim p As New Process
            p.StartInfo.FileName = "printfile.bat"
            p.StartInfo.Arguments = "c:\Ledger.txt"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()
            'End If
        Next
        MsgBox("ALL Ledger Printed", MsgBoxStyle.Information)
        boolall = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        cmbgrpname.Text = "INTERNAL PARTY"
        cmbgrpname.Enabled = False
        Dim sql As String
        sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
               & " and group_name  in ('INTERNAL PARTY') order by account_code "
        GMod.DataSetRet(sql, "acchead")
        cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
        cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("acchead")
        cmbacheadname.DisplayMember = "account_head_name"
        chklistled.Items.Clear()
        For rw = 0 To GMod.ds.Tables("acchead").Rows.Count - 1
            chklistled.Items.Add(GMod.ds.Tables("acchead").Rows(rw)("account_code") & "#" & GMod.ds.Tables("acchead").Rows(rw)("account_head_name"))
        Next
    End Sub
    Dim filef As Boolean
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        boolall = True
        Dim z As Integer
        filef = True
        For z = 0 To cmbacheadcode.Items.Count - 1
            btnshow_Click(sender, e)
            cmbacheadcode.SelectedIndex = z
            'MsgBox(cmbacheadname.Text)
            LedgerDOSPrint(cmbacheadcode.Text, cmbacheadname.Text)
        Next
        MessageBox.Show("ALL Ledger Create")
        filef = False
        boolall = False
        Button3.Enabled = False
    End Sub

    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        If drcustomer.Checked = True Then
            Dim sql As String
            sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                   & " and group_name in ('CUSTOMER') and Area_code='" & cmbAreaCode.Text & "' order by account_code"
            GMod.DataSetRet(sql, "acchead")
            cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
            cmbacheadcode.DisplayMember = "account_code"

            cmbacheadname.DataSource = GMod.ds.Tables("acchead")
            cmbacheadname.DisplayMember = "account_head_name"
        End If
    End Sub
    Dim rw As Long

    Private Sub cmbgrpname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgrpname.Leave
        If cmbgrpname.FindStringExact(cmbgrpname.Text) = -1 Then
            MsgBox("Slecet Correct Group", MsgBoxStyle.Critical)
            cmbgrpname.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub cmbgrpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrpname.SelectedIndexChanged
        If GMod.Cmpid = "PHOE" Then

            If chkWithoutSubgroup.Checked = False Then
                GMod.DataSetRet("select * from sub_group where group_name='" & cmbgrpname.Text & "' and  cmp_id='" & GMod.Cmpid & "' and session = '" & GMod.Session & "'", "sgrp")
                cmbsubgrpname.DataSource = GMod.ds.Tables("sgrp")
                cmbsubgrpname.DisplayMember = "sub_group_name"
            Else
                GMod.ds.Tables("sgrp").Clear()
                fillHead()
            End If

        Else
            fillHead()
        End If

    End Sub
    Public Sub fillHead()
        Dim sql As String
        sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
               & " and group_name = '" & cmbgrpname.Text & "' order by account_code"
        GMod.DataSetRet(sql, "acchead")
        cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
        cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("acchead")
        cmbacheadname.DisplayMember = "account_head_name"
        If CheckBoxSelect.Checked = True Then
            chklistled.Items.Clear()
            For rw = 0 To GMod.ds.Tables("acchead").Rows.Count - 1
                chklistled.Items.Add(GMod.ds.Tables("acchead").Rows(rw)("account_code") & "#" & GMod.ds.Tables("acchead").Rows(rw)("account_head_name"))
            Next
        End If
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim codefor10 As String = ""
        CheckBoxSelect.Enabled = False
        'If chklistled.CheckedItems.Count > 11 Then
        '    MsgBox("Select only 10 Ledger at time", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        Try

            Dim code(3) As String
            boolall = True
            Dim z As Integer, i As Integer, K As Double
            z = 0
            Dim zzz As Double
            pageno = Val(TextBox1.Text)
            sw = File.CreateText("Ledger.txt")
            For z = 0 To chklistled.CheckedItems.Count - 1
                'cmbacheadcode.SelectedIndex = z
                For K = 0 To 10000000

                Next
                panel1.BringToFront()
                'MsgBox(cmbacheadname.Text)
                'sw.WriteLine(Convert.ToChar(12).ToString)

                code = chklistled.CheckedItems.Item(z).ToString().Split("#")
                'MsgBox(code(0))
                'cmbacheadcode.Text = code(0)
                '------------------------------------------------------------------------------------------------
                'btnshow_Click(sender, e)
                HEAD = code(1)
                codefor10 = code(0)

                'dleting old data for that use 
                GMod.SqlExecuteNonQuery("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'")
                GMod.SqlExecuteNonQuery("delete  from repPartyLedger where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'")
                'Calulating openng and inserint into table 


                Dim sqlopen As String
                Dim opnbal, dr, cr As Double
                opnbal = 0
                dr = 0
                cr = 0
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                          & " " & GMod.VENTRY & " where Acc_head_code='" & codefor10 & "' and  vou_date<'" & dtfrom.Text & "' and vou_type<>'BANKREC' and Pay_mode<>'-'"
                GMod.DataSetRet(sqlopen, "opening")
                opnbal = CDbl(GMod.ds.Tables("opening").Rows(0)(0))
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                sqlopen = "select isnull(sum(opening_dr),0) - isnull(sum(opening_cr),0) from " & GMod.ACC_HEAD _
                           & " where Account_code='" & codefor10 & "'"
                GMod.DataSetRet(sqlopen, "opening")
                opnbal = opnbal + CDbl(GMod.ds.Tables("opening").Rows(0)(0))
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                'MsgBox(opnbal.ToString)
                If opnbal > 0 Then
                    dr = opnbal
                    cr = 0
                Else
                    dr = 0
                    cr = -1 * opnbal
                End If
                Dim sqlsave As String
                If RadioButton1.Checked Then
                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & codefor10 & "',"
                    sqlsave &= "'OLD BALANCE',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & dr.ToString & "',"
                    sqlsave &= "'" & cr.ToString & "',"
                    sqlsave &= "'" & GMod.username & "')"
                    GMod.SqlExecuteNonQuery(sqlsave)
                Else
                    sqlsave = "insert into repPartyLedger(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & codefor10 & "',"
                    sqlsave &= "'OLD BALANCE',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & dr.ToString & "',"
                    sqlsave &= "'" & cr.ToString & "',"
                    sqlsave &= "'" & GMod.username & "')"
                    GMod.SqlExecuteNonQuery(sqlsave)
                End If
                '------------------------------------------------------------------------------------------------------
                'Now inserting transtion os that accont head 
                If RadioButton1.Checked Then
                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no, Uname) " _
                    & " select Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                    & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC' and left(Uname,1)<>'$' and Pay_mode<>'-' order by vou_date,vou_no"
                    GMod.SqlExecuteNonQuery(sqlsave)
                Else
                    sqlsave = "insert into repPartyLedger(Cmpid, Uname,  Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head," _
                    & " dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date)" _
                    & " select Cmp_id,'" & GMod.username & "',vou_no,vou_type,vou_date,Acc_head_code,acc_head,dramt,cramt,pay_mode,Cheque_no," _
                    & " Narration, group_name, sub_group_name, ch_issue_date, ch_date " _
                    & " from " & GMod.VENTRY & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC'  and left(Uname,1)<>'$' and Pay_mode<>'-' order by vou_date,vou_no,Entry_id"
                    GMod.SqlExecuteNonQuery(sqlsave)
                End If
                '----------------------------------------------------------------------------------------
                'Deleyting Zero Valus
                GMod.SqlExecuteNonQuery("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and vou_type<>'OPEN' and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                GMod.SqlExecuteNonQuery("delete from repPartyLedger where (dramt=0 and cramt=0) and vou_type<>'OPEN' and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                '----------------------------------------------------------------------------------------
                LedgerDOSPrint(code(0), code(1))
                'MessageBox.Show("NEXT")
                code(0) = ""
                code(1) = ""
                codefor10 = ""
            Next
            z = 0
            sw.Close()
            Dim p As New Process
            p.StartInfo.FileName = "printfile.bat"
            p.StartInfo.Arguments = "Ledger.txt"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()
            MsgBox("ALL Ledger Printed", MsgBoxStyle.Information)
            boolall = False
            panel1.Visible = False
            z = 0
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CheckBoxSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxSelect.Click
        If CheckBoxSelect.Checked = True Then
            panel1.Visible = True
            panel1.BringToFront()
            'pageno = 0
        Else
            panel1.Visible = False
            panel1.SendToBack()
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwprint.Click
        CrViewerGenralLedger.PrintReport()
        btnwprint.Enabled = True
        cmbacheadname.Enabled = True
        cmbacheadcode.Enabled = True
        cmbgrpname.Enabled = True
        cmbsubgrpname.Enabled = True
        GroupBox1.Enabled = True
        cmbAreaName.Enabled = True
        cmbAreaCode.Enabled = True
        CheckBoxArea.Enabled = True
        dtfrom.Enabled = True
        dtto.Enabled = True
        CrViewerGenralLedger.ReportSource = Nothing
    End Sub
    Private Sub cmbacheadname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadname.Leave
        btnwprint.Enabled = False
        If cmbacheadname.FindStringExact(cmbacheadname.Text) = -1 Then
            MsgBox("Invalid A/c Head")
            cmbacheadname.Focus()
        Else

        End If
    End Sub
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        CrViewerGenralLedger.ReportSource = Nothing
        btnwprint.Enabled = True
        cmbacheadname.Enabled = True
        cmbacheadcode.Enabled = True
        cmbgrpname.Enabled = True
        cmbsubgrpname.Enabled = True
        GroupBox1.Enabled = True
        cmbAreaName.Enabled = True
        cmbAreaCode.Enabled = True
        CheckBoxArea.Enabled = True
        btnDos.Enabled = True
        dtfrom.Enabled = True
        dtto.Enabled = True
        CheckBoxSelect.Enabled = True
        pageno = 0
        CrViewerGenralLedger.ReportSource = Nothing
        'cmbgrpname.Focus()
    End Sub
    Private Sub cmbacheadname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadname.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim i As Integer = 0
        If CheckBox1.Checked = True Then
            For i = 0 To chklistled.Items.Count - 1
                chklistled.SetItemChecked(i, True)
                'chklistled.Items
            Next
        Else
            For i = 0 To chklistled.Items.Count - 1
                chklistled.SetItemChecked(i, False)
                'chklistled.Items
            Next
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim codefor10 As String = ""
        CheckBoxSelect.Enabled = False
        'If chklistled.CheckedItems.Count > 11 Then
        '    MsgBox("Select only 10 Ledger at time", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        Try

            Dim code(3) As String
            boolall = True
            Dim z As Integer, i As Integer, K As Double
            z = 0
            Dim zzz As Double
            pageno = Val(TextBox1.Text)
            ' sw = File.CreateText("Ledger.txt")
            For z = 0 To chklistled.CheckedItems.Count - 1
                'cmbacheadcode.SelectedIndex = z
                For K = 0 To 10000000

                Next
                panel1.BringToFront()
                'MsgBox(cmbacheadname.Text)
                'sw.WriteLine(Convert.ToChar(12).ToString)

                code = chklistled.CheckedItems.Item(z).ToString().Split("#")
                'MsgBox(code(0))
                'cmbacheadcode.Text = code(0)
                '------------------------------------------------------------------------------------------------
                'btnshow_Click(sender, e)
                HEAD = code(1)
                codefor10 = code(0)

                'dleting old data for that use 
                GMod.SqlExecuteNonQuery("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'")
                GMod.SqlExecuteNonQuery("delete  from repPartyLedger where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'")
                'Calulating openng and inserint into table 


                Dim sqlopen As String
                Dim opnbal, dr, cr As Double
                opnbal = 0
                dr = 0
                cr = 0
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                          & " " & GMod.VENTRY & " where Acc_head_code='" & codefor10 & "' and  vou_date<'" & dtfrom.Text & "' and vou_type<>'BANKREC' and Pay_mode<>'-'"
                GMod.DataSetRet(sqlopen, "opening")
                opnbal = CDbl(GMod.ds.Tables("opening").Rows(0)(0))
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                sqlopen = "select isnull(sum(opening_dr),0) - isnull(sum(opening_cr),0) from " & GMod.ACC_HEAD _
                           & " where Account_code='" & codefor10 & "'"
                GMod.DataSetRet(sqlopen, "opening")
                opnbal = opnbal + CDbl(GMod.ds.Tables("opening").Rows(0)(0))
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                'MsgBox(opnbal.ToString)
                If opnbal > 0 Then
                    dr = opnbal
                    cr = 0
                Else
                    dr = 0
                    cr = -1 * opnbal
                End If
                Dim sqlsave As String
                If RadioButton1.Checked Then
                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & codefor10 & "',"
                    sqlsave &= "'OLD BALANCE',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & dr.ToString & "',"
                    sqlsave &= "'" & cr.ToString & "',"
                    sqlsave &= "'" & GMod.username & "')"
                    GMod.SqlExecuteNonQuery(sqlsave)
                Else
                    sqlsave = "insert into repPartyLedger(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & codefor10 & "',"
                    sqlsave &= "'OLD BALANCE',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & dr.ToString & "',"
                    sqlsave &= "'" & cr.ToString & "',"
                    sqlsave &= "'" & GMod.username & "')"
                    GMod.SqlExecuteNonQuery(sqlsave)
                End If
                '------------------------------------------------------------------------------------------------------
                'Now inserting transtion os that accont head 
                If RadioButton1.Checked Then
                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no, Uname) " _
                    & " select Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                    & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC' and left(Uname,1)<>'$' and Pay_mode<>'-' order by vou_date,vou_no"
                    GMod.SqlExecuteNonQuery(sqlsave)
                Else
                    sqlsave = "insert into repPartyLedger(Cmpid, Uname,  Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head," _
                    & " dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date)" _
                    & " select Cmp_id,'" & GMod.username & "',vou_no,vou_type,vou_date,Acc_head_code,acc_head,dramt,cramt,pay_mode,Cheque_no," _
                    & " Narration, group_name, sub_group_name, ch_issue_date, ch_date " _
                    & " from " & GMod.VENTRY & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC'  and left(Uname,1)<>'$' and Pay_mode<>'-' order by vou_date,vou_no,Entry_id"
                    GMod.SqlExecuteNonQuery(sqlsave)
                End If
                '----------------------------------------------------------------------------------------
                'Deleyting Zero Valus
                'GMod.SqlExecuteNonQuery("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and vou_type<>'OPEN' and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                'GMod.SqlExecuteNonQuery("delete from repPartyLedger where (dramt=0 and cramt=0) and vou_type<>'OPEN' and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")


                GMod.SqlExecuteNonQuery("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                GMod.SqlExecuteNonQuery("delete from repPartyLedger where (dramt=0 and cramt=0) and  uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")


                '----------------------------------------------------------------------------------------

                If RadioButton1.Checked Then
                    GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,balance  from repGeneralLedger1 where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
                    If GMod.ds.Tables("ledPrint").Rows.Count > 0 Then
                        Dim r As New CrLedger 'CrCrLedger is name of report
                        r.SetDataSource(GMod.ds.Tables("ledPrint"))
                        r.SetParameterValue("cmpname", GMod.Cmpname)
                        r.SetParameterValue("accholder", "Account Holder : " & codefor10 & " " & HEAD)
                        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
                        r.SetParameterValue("uname", GMod.username)
                        ' CrViewerGenralLedger.ReportSource = r
                        'For displaying in Data grid  setting fields--------------------
                        'rdOnscreen_Click(sender, e)
                        '----------------------------------------------------------------
                        'CrViewerGenralLedger.PrintReport()
                        r.PrintToPrinter(1, True, 1, 0)
                        r = Nothing
                    End If
                Else
                    GMod.DataSetRet("select * from repPartyLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
                    If GMod.ds.Tables("ledPrint").Rows.Count > 0 Then
                        Dim r As New partyled
                        r.SetDataSource(GMod.ds.Tables("ledPrint"))
                        r.SetParameterValue("cmpname", GMod.Cmpname)
                        r.SetParameterValue("accholder", "Account Holder : " & codefor10 & " " & HEAD)
                        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
                        r.SetParameterValue("uname", GMod.username)
                        'CrViewerGenralLedger.ReportSource = r
                        'CrViewerGenralLedger.PrintReport()
                        r.PrintToPrinter(1, True, 1, 0)
                        r = Nothing
                    End If
                End If
                code(0) = ""
                code(1) = ""
                codefor10 = ""
            Next
            z = 0
            MsgBox("ALL Ledger Printed", MsgBoxStyle.Information)
            boolall = False
            panel1.Visible = False
            z = 0
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Ledger Print With Trasaction

        Dim codefor10 As String = ""
        CheckBoxSelect.Enabled = False
        'If chklistled.CheckedItems.Count > 11 Then
        '    MsgBox("Select only 10 Ledger at time", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        Dim cmd As SqlCommand
        Try

            Dim code(3) As String
            boolall = True
            Dim z As Integer, i As Integer, K As Double
            z = 0
            Dim zzz As Double
            pageno = Val(TextBox1.Text)
            ' sw = File.CreateText("Ledger.txt")
            For z = 0 To chklistled.CheckedItems.Count - 1
                'cmbacheadcode.SelectedIndex = z

                Dim trans As SqlTransaction
                trans = GMod.SqlConn.BeginTransaction

                For K = 0 To 10000000

                Next
                panel1.BringToFront()
                'MsgBox(cmbacheadname.Text)
                'sw.WriteLine(Convert.ToChar(12).ToString)

                code = chklistled.CheckedItems.Item(z).ToString().Split("#")
                'MsgBox(code(0))
                'cmbacheadcode.Text = code(0)
                '------------------------------------------------------------------------------------------------
                'btnshow_Click(sender, e)
                HEAD = code(1)
                codefor10 = code(0)

                'dleting old data for that use 
                'GMod.SqlExecuteNonQuery("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'")
                'GMod.SqlExecuteNonQuery("delete  from repPartyLedger where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'")
                cmd = New SqlCommand("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'", GMod.SqlConn, trans)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("delete  from repPartyLedger where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'", GMod.SqlConn, trans)
                cmd.ExecuteNonQuery()

                'Calulating openng and inserint into table 


                Dim sqlopen As String
                Dim opnbal, dr, cr As Double
                opnbal = 0
                dr = 0
                cr = 0
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                          & " " & GMod.VENTRY & " where Acc_head_code='" & codefor10 & "' and  vou_date<'" & dtfrom.Text & "' and vou_type<>'BANKREC' and Pay_mode<>'-'"
                GMod.DataSetRet(sqlopen, "opening")
                opnbal = CDbl(GMod.ds.Tables("opening").Rows(0)(0))
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                sqlopen = "select isnull(sum(opening_dr),0) - isnull(sum(opening_cr),0) from " & GMod.ACC_HEAD _
                           & " where Account_code='" & codefor10 & "'"
                GMod.DataSetRet(sqlopen, "opening")
                opnbal = opnbal + CDbl(GMod.ds.Tables("opening").Rows(0)(0))
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                'MsgBox(opnbal.ToString)
                If opnbal > 0 Then
                    dr = opnbal
                    cr = 0
                Else
                    dr = 0
                    cr = -1 * opnbal
                End If
                Dim sqlsave As String
                If RadioButton1.Checked Then
                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & codefor10 & "',"
                    sqlsave &= "'OLD BALANCE',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & dr.ToString & "',"
                    sqlsave &= "'" & cr.ToString & "',"
                    sqlsave &= "'" & GMod.username & "')"
                    'GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                Else
                    sqlsave = "insert into repPartyLedger(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & codefor10 & "',"
                    sqlsave &= "'OLD BALANCE',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & dr.ToString & "',"
                    sqlsave &= "'" & cr.ToString & "',"
                    sqlsave &= "'" & GMod.username & "')"
                    'GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                End If
                '------------------------------------------------------------------------------------------------------
                'Now inserting transtion os that accont head 
                If RadioButton1.Checked Then
                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no, Uname) " _
                    & " select Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                    & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC' and left(Uname,1)<>'$' and Pay_mode<>'-' order by vou_date,vou_no"
                    ' GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                Else
                    sqlsave = "insert into repPartyLedger(Cmpid, Uname,  Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head," _
                    & " dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date)" _
                    & " select Cmp_id,'" & GMod.username & "',vou_no,vou_type,vou_date,Acc_head_code,acc_head,dramt,cramt,pay_mode,Cheque_no," _
                    & " Narration, group_name, sub_group_name, ch_issue_date, ch_date " _
                    & " from " & GMod.VENTRY & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC'  and left(Uname,1)<>'$' and Pay_mode<>'-' order by vou_date,vou_no,Entry_id"
                    'GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                End If
                '----------------------------------------------------------------------------------------
                'Deleyting Zero Valus
                'GMod.SqlExecuteNonQuery("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and vou_type<>'OPEN' and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                'GMod.SqlExecuteNonQuery("delete from repPartyLedger where (dramt=0 and cramt=0) and vou_type<>'OPEN' and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")


                'GMod.SqlExecuteNonQuery("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                'GMod.SqlExecuteNonQuery("delete from repPartyLedger where (dramt=0 and cramt=0) and  uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")

                cmd = New SqlCommand("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'", GMod.SqlConn, trans)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("delete from repPartyLedger where (dramt=0 and cramt=0) and  uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'", GMod.SqlConn, trans)
                cmd.ExecuteNonQuery()
                Try
                    trans.Commit()
                Catch ex As Exception
                    trans.Rollback()
                End Try

                '----------------------------------------------------------------------------------------

                If RadioButton1.Checked Then
                    GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,balance  from repGeneralLedger1 where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
                    If GMod.ds.Tables("ledPrint").Rows.Count > 0 Then
                        Dim r As New CrLedger 'CrCrLedger is name of report
                        r.SetDataSource(GMod.ds.Tables("ledPrint"))
                        r.SetParameterValue("cmpname", GMod.Cmpname)
                        r.SetParameterValue("accholder", "Account Holder : " & codefor10 & " " & HEAD)
                        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
                        r.SetParameterValue("uname", GMod.username)
                        ' CrViewerGenralLedger.ReportSource = r
                        'For displaying in Data grid  setting fields--------------------
                        'rdOnscreen_Click(sender, e)
                        '----------------------------------------------------------------
                        'CrViewerGenralLedger.PrintReport()
                        r.PrintToPrinter(1, True, 1, 0)
                        r = Nothing
                    End If
                Else
                    GMod.DataSetRet("select * from repPartyLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
                    If GMod.ds.Tables("ledPrint").Rows.Count > 0 Then
                        Dim r As New partyled
                        r.SetDataSource(GMod.ds.Tables("ledPrint"))
                        r.SetParameterValue("cmpname", GMod.Cmpname)
                        r.SetParameterValue("accholder", "Account Holder : " & codefor10 & " " & HEAD)
                        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
                        r.SetParameterValue("uname", GMod.username)
                        'CrViewerGenralLedger.ReportSource = r
                        'CrViewerGenralLedger.PrintReport()
                        r.PrintToPrinter(1, True, 1, 0)
                        r = Nothing
                    End If
                End If
                code(0) = ""
                code(1) = ""
                codefor10 = ""
            Next
            z = 0
            MsgBox("ALL Ledger Printed", MsgBoxStyle.Information)
            boolall = False
            panel1.Visible = False
            z = 0
            Me.Close()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbsubgrpname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsubgrpname.SelectedIndexChanged
        If GMod.Cmpid = "PHOE" Then
            Dim sql As String

            If cmbsubgrpname.Text <> "" Then

                sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                       & " and group_name = '" & cmbgrpname.Text & "' and sub_group_name = '" & cmbsubgrpname.Text & "' order by account_code"
                GMod.DataSetRet(sql, "acchead")
                cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
                cmbacheadcode.DisplayMember = "account_code"

                cmbacheadname.DataSource = GMod.ds.Tables("acchead")
                cmbacheadname.DisplayMember = "account_head_name"
                If CheckBoxSelect.Checked = True Then
                    chklistled.Items.Clear()
                    For rw = 0 To GMod.ds.Tables("acchead").Rows.Count - 1
                        chklistled.Items.Add(GMod.ds.Tables("acchead").Rows(rw)("account_code") & "#" & GMod.ds.Tables("acchead").Rows(rw)("account_head_name"))
                    Next
                End If
            Else

            End If

        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim codefor10 As String = ""
        CheckBoxSelect.Enabled = False
        'If chklistled.CheckedItems.Count > 11 Then
        '    MsgBox("Select only 10 Ledger at time", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        Dim cmd As SqlCommand
        Try

            Dim code(3) As String
            boolall = True
            Dim z As Integer, i As Integer, K As Double
            z = 0
            Dim zzz As Double
            pageno = Val(TextBox1.Text)
            ' sw = File.CreateText("Ledger.txt")
            For z = 0 To chklistled.CheckedItems.Count - 1
                'cmbacheadcode.SelectedIndex = z

                Dim trans As SqlTransaction
                trans = GMod.SqlConn.BeginTransaction

                For K = 0 To 10000000

                Next
                panel1.BringToFront()
                'MsgBox(cmbacheadname.Text)
                'sw.WriteLine(Convert.ToChar(12).ToString)

                code = chklistled.CheckedItems.Item(z).ToString().Split("#")
                'MsgBox(code(0))
                'cmbacheadcode.Text = code(0)
                '------------------------------------------------------------------------------------------------
                'btnshow_Click(sender, e)
                HEAD = code(1)
                codefor10 = code(0)

                'dleting old data for that use 
                'GMod.SqlExecuteNonQuery("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'")
                'GMod.SqlExecuteNonQuery("delete  from repPartyLedger where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'")
                cmd = New SqlCommand("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'", GMod.SqlConn, trans)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("delete  from repPartyLedger where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'", GMod.SqlConn, trans)
                cmd.ExecuteNonQuery()

                'Calulating openng and inserint into table 


                Dim sqlopen As String
                Dim opnbal, dr, cr As Double
                opnbal = 0
                dr = 0
                cr = 0
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                          & " " & GMod.VENTRY & " where Acc_head_code='" & codefor10 & "' and  vou_date<'" & dtfrom.Text & "' and vou_type<>'BANKREC' and Pay_mode<>'-'"
                GMod.DataSetRet(sqlopen, "opening")
                opnbal = CDbl(GMod.ds.Tables("opening").Rows(0)(0))
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                sqlopen = "select isnull(sum(opening_dr),0) - isnull(sum(opening_cr),0) from " & GMod.ACC_HEAD _
                           & " where Account_code='" & codefor10 & "'"
                GMod.DataSetRet(sqlopen, "opening")
                opnbal = opnbal + CDbl(GMod.ds.Tables("opening").Rows(0)(0))
                Try
                    GMod.ds.Tables("opening").Clear()
                Catch ex As Exception

                End Try
                'MsgBox(opnbal.ToString)
                If opnbal > 0 Then
                    dr = opnbal
                    cr = 0
                Else
                    dr = 0
                    cr = -1 * opnbal
                End If
                Dim sqlsave As String
                If RadioButton1.Checked Then
                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & codefor10 & "',"
                    sqlsave &= "'OLD BALANCE',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & dr.ToString & "',"
                    sqlsave &= "'" & cr.ToString & "',"
                    sqlsave &= "'" & GMod.username & "')"
                    'GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                Else
                    sqlsave = "insert into repPartyLedger(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & codefor10 & "',"
                    sqlsave &= "'OLD BALANCE',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & dr.ToString & "',"
                    sqlsave &= "'" & cr.ToString & "',"
                    sqlsave &= "'" & GMod.username & "')"
                    'GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                End If
                '------------------------------------------------------------------------------------------------------
                'Now inserting transtion os that accont head 
                If RadioButton1.Checked Then
                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no, Uname) " _
                    & " select Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                    & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC' and left(Uname,1)<>'$' and Pay_mode<>'-' order by vou_date,vou_no"
                    ' GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                Else
                    sqlsave = "insert into repPartyLedger(Cmpid, Uname,  Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head," _
                    & " dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date)" _
                    & " select Cmp_id,'" & GMod.username & "',vou_no,vou_type,vou_date,Acc_head_code,acc_head,dramt,cramt,pay_mode,Cheque_no," _
                    & " Narration, group_name, sub_group_name, ch_issue_date, ch_date " _
                    & " from " & GMod.VENTRY & " where vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC'  and left(Uname,1)<>'$' and Pay_mode<>'-' order by vou_date,vou_no,Entry_id"
                    'GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                End If
                '----------------------------------------------------------------------------------------
                'Deleyting Zero Valus
                'GMod.SqlExecuteNonQuery("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and vou_type<>'OPEN' and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                'GMod.SqlExecuteNonQuery("delete from repPartyLedger where (dramt=0 and cramt=0) and vou_type<>'OPEN' and uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")


                'GMod.SqlExecuteNonQuery("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")
                'GMod.SqlExecuteNonQuery("delete from repPartyLedger where (dramt=0 and cramt=0) and  uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'")

                cmd = New SqlCommand("delete from repGeneralLedger1 where (dramt=0 and cramt=0) and   uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'", GMod.SqlConn, trans)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("delete from repPartyLedger where (dramt=0 and cramt=0) and  uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "'", GMod.SqlConn, trans)
                cmd.ExecuteNonQuery()
                Try
                    trans.Commit()
                Catch ex As Exception
                    trans.Rollback()
                End Try

                '----------------------------------------------------------------------------------------

                If RadioButton1.Checked Then
                    GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,balance  from repGeneralLedger1 where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
                    If GMod.ds.Tables("ledPrint").Rows.Count > 0 Then
                        Dim r As New CrLedger 'CrCrLedger is name of report
                        r.SetDataSource(GMod.ds.Tables("ledPrint"))
                        r.SetParameterValue("cmpname", GMod.Cmpname)
                        r.SetParameterValue("accholder", "Account Holder : " & codefor10 & " " & HEAD)
                        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
                        r.SetParameterValue("uname", GMod.username)
                        CrViewerGenralLedger.ReportSource = r
                        'For displaying in Data grid  setting fields--------------------
                        'rdOnscreen_Click(sender, e)
                        '----------------------------------------------------------------
                        'CrViewerGenralLedger.PrintReport()
                        'r.PrintToPrinter(1, True, 1, 0)
                        'r = Nothing
                        Dim str As String
                        Dim codeprefic As String = codefor10.Substring(0, 2)
                        If codeprefic = "**" Then
                            If codefor10.Length = 8 Then
                                str = codefor10.Substring(2, 6)
                            Else
                                str = codefor10.Substring(2, 8)
                            End If
                        Else
                            str = codefor10
                        End If


                        Dim str1 As String = str
                        Dim CrExportOptions As ExportOptions
                        Dim CrDiskFileDestinationOptions As New  _
                        DiskFileDestinationOptions()
                        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()

                        CrDiskFileDestinationOptions.DiskFileName = System.Environment.CurrentDirectory & "\Ledger\" & str1 & ".pdf"
                        CrExportOptions = r.ExportOptions
                        With CrExportOptions
                            .ExportDestinationType = ExportDestinationType.DiskFile
                            .ExportFormatType = ExportFormatType.PortableDocFormat
                            .DestinationOptions = CrDiskFileDestinationOptions
                            .FormatOptions = CrFormatTypeOptions
                        End With
                        r.Export()
                        Dim ii As Integer
                        For ii = 0 To 1000

                        Next

                    End If
                Else
                    GMod.DataSetRet("select * from repPartyLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
                    If GMod.ds.Tables("ledPrint").Rows.Count > 0 Then
                        Dim r As New partyled
                        r.SetDataSource(GMod.ds.Tables("ledPrint"))
                        r.SetParameterValue("cmpname", GMod.Cmpname)
                        r.SetParameterValue("accholder", "Account Holder : " & codefor10 & " " & HEAD)
                        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
                        r.SetParameterValue("uname", GMod.username)
                        CrViewerGenralLedger.ReportSource = r
                        'CrViewerGenralLedger.PrintReport()
                        'r.PrintToPrinter(1, True, 1, 0)
                        'r = Nothing

                        '----------------------------------------------------
                        Dim str As String
                        Dim codeprefic As String = codefor10.Substring(0, 2)
                        If codeprefic = "**" Then
                            If codefor10.Length = 8 Then
                                str = codefor10.Substring(2, 6)
                            Else
                                str = codefor10.Substring(2, 8)
                            End If
                        Else
                            str = codefor10
                        End If
                            Dim str1 As String = str
                            Dim CrExportOptions As ExportOptions
                            Dim CrDiskFileDestinationOptions As New  _
                            DiskFileDestinationOptions()
                            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()

                            CrDiskFileDestinationOptions.DiskFileName = System.Environment.CurrentDirectory & "\Ledger\" & str1 & ".pdf"
                            CrExportOptions = r.ExportOptions
                            With CrExportOptions
                                .ExportDestinationType = ExportDestinationType.DiskFile
                                .ExportFormatType = ExportFormatType.PortableDocFormat
                                .DestinationOptions = CrDiskFileDestinationOptions
                                .FormatOptions = CrFormatTypeOptions
                            End With
                            r.Export()
                            Dim ii As Integer
                            For ii = 0 To 1000

                            Next



                        End If
                End If
                code(0) = ""
                code(1) = ""
                codefor10 = ""
            Next
            z = 0
            MsgBox("ALL Ledger Printed", MsgBoxStyle.Information)
            boolall = False
            panel1.Visible = False
            z = 0
            Me.Close()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkWithoutSubgroup_CheckedChanged(sender As Object, e As EventArgs) Handles chkWithoutSubgroup.CheckedChanged

    End Sub
End Class