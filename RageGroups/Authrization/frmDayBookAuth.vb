Imports System.IO
Imports System.Diagnostics.Process
Imports System.Data.SqlClient
Public Class frmdayBookAuth
    Private Sub frmBook_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
        Try
            File.Delete("c:\daybook.txt")
        Catch ex As Exception

        End Try
    End Sub
    Dim sql As String = ""

    Private Sub frmBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        'dtfrom.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        GMod.SqlExecuteNonQuery("delete from Daybook")
        Me.Text = "Day" & Me.Text & "    " & "[" & GMod.Cmpname & "]"
        CreateTableDayBook()
        Dim i As Integer
        'Seeting Session Start DATE
        'Dim sdate As String = "4/1/" & GMod.Session.Substring(0, 2).ToString
        'dtfrom.Value = CDate(sdate)
        listgrp.Items.Clear()
        If GMod.role.ToUpper = "VIEWER LEVEL-1" Or GMod.role.ToUpper = "ADMIN" Then
            GMod.DataSetRet("select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vtype not in ('OPEN')  and Vou_no_seq not in ('99') and session = '" & GMod.Session & "' order by seqorder", "grp")
        Else
            GMod.DataSetRet("select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vtype not in ('OPEN')  and Vou_no_seq='" & GMod.Dept & "' and session ='" & GMod.Session & "'  order by seqorder", "grp")
        End If


        'sql = "select distinct vou_type from " & GMod.VENTRY & " where  vou_type  not like '%SALE JOURNAL%' and vou_type  not like '%SALE%' and  vou_type not like '%PUR%'  and  vou_type not like '%CASH%' and vou_type not like '%CR%' and vou_type not like '%BANK%'"
        ' sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and (vprefix like '%J%'  or vprefix like '%bt%'  or vprefix like '%F%' or vprefix like '%P%') and Vtype not in ('BANK','CR VOUCHER','CR VOUCHER-TR','CASH','OPEN') and VTYPE NOT LIKE '%OTHER SALE%' and VTYPE NOT LIKE '%CHICKS%' and vou_no_seq='" & GMod.Dept & "'"
        If GMod.Dept = 0 Then
            If GMod.Cmpid <> "PHCH" Then
                sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq='" & GMod.Dept & "' and vtype not like '%SALE%' and session = '" & GMod.Session & "'"
                listgrp.Items.Add("SALE JOURNAL")
                listgrp.Items.Add("SALE JOURNAL(GST)")
                listgrp.Items.Add("JOURNAL(GST)")
                listgrp.Items.Add("SALE CH")
            Else
                sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq='" & GMod.Dept & "'  and session = '" & GMod.Session & "' " ' and vtype not like '%SALE%'"
                listgrp.Items.Add("SALE JOURNAL")

            End If
        ElseIf GMod.Dept = 1 Then
            If GMod.Cmpid <> "PHCH" Then
                sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq='" & GMod.Dept & "' and session ='" & GMod.Session & "' and session ='" & GMod.Session & "'" ' and vtype like '%pur journal%'"
                listgrp.Items.Add("JOURNAL PURCHASE")
            Else
                sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq='" & GMod.Dept & "' and session ='" & GMod.Session & "' and session = '" & GMod.Session & "'"  ' and vtype not like '%SALE%'"
                listgrp.Items.Add("SALE JOURNAL")
            End If

        Else
            sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vou_no_seq='" & GMod.Dept & "' and session ='" & GMod.Session & "'"
        End If
        GMod.DataSetRet(sql, "grp")

            For i = 0 To GMod.ds.Tables("grp").Rows.Count - 1

                listgrp.Items.Add(GMod.ds.Tables("grp").Rows(i)("vtype"))
                listgrp.SetSelected(i, True)
            Next
            '
        'listgrp.Items.Add("BANK JOURNAL")
        listgrp.Items.Add("CR VOUCHER")
        listgrp.Items.Add("JOURNAL")
            For i = 0 To listgrp.Items.Count - 1

            Next
        CrystalReportViewer1.Height = Me.Height - 120


    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub


    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        'GMod.SqlExecuteNonQuery("delete from Daybook")
        CreateTableDayBook() 'Creatting table day book
        Dim lst As String = "", i As Integer
        Try
            'Deleting from day book 
            'MsgBox(GMod.SqlExecuteNonQuery("delete from daybook where Uname='" & GMod.username & "'"))
            GMod.SqlExecuteNonQuery("delete from Daybook")

            If listgrp.CheckedItems.Count > 0 Then
                For i = 0 To listgrp.CheckedItems.Count - 1
                    lst &= "'" & listgrp.CheckedItems([i].ToString) & "',"
                Next
            End If
            lst = lst.Remove(lst.Length - 1, 1)
            Dim ocr, odr As Double
            ' GMod.SqlExecuteNonQuery(sqlsave)
            'Calculating closing balance 
            Dim sqlinst, sqltotal As String
            'Inserting values to the table daybook according to sequence 
            If listgrp.CheckedItems.Count > 0 Then
                For i = 0 To listgrp.CheckedItems.Count - 1
                    ' MsgBox(listgrp.CheckedItems([i].ToString))
                    sqlinst = "insert into daybook(cmpid, Acc_code, Acc_name, Narration, Group_name, Sub_Group, Vtype, Vouno, " _
                              & "dramt, cramt, [Cheque No], Vdate, entryid, Uname) " _
                              & " select  v.Cmp_id,account_code Acc_head_code, account_head_name Acc_head,Narration,a.Group_name, " _
                              & "a.Sub_group_name,Vou_type,Vou_no,dramt,cramt,Cheque_no,Vou_date,Entry_id,'" & GMod.username & "' from " _
                              & GMod.VENTRY & " v inner join " & GMod.ACC_HEAD & " a on v.Acc_head_code = a.account_code  where vou_type='" & listgrp.CheckedItems([i].ToString) _
                              & "' and cast(vou_no as bigint) between '" & txtFrom.Text & "' and '" & txtTo.Text & "' and Pay_mode='-' order by cast(vou_no as numeric(18,0)),Entry_id"
                    GMod.SqlExecuteNonQuery(sqlinst)
                Next
            Else
                ' MsgBox(listgrp.CheckedItems([i].ToString))
                sqlinst = " insert into daybook(cmpid, Acc_code, Acc_name, Narration, Group_name, Sub_Group, Vtype, Vouno, " _
                          & "dramt, cramt, [Cheque No], Vdate, entryid, Uname) " _
                          & " select  v.Cmp_id,account_code Acc_head_code, account_head_name Acc_head,Narration,a.Group_name, " _
                          & "a.Sub_group_name,Vou_type,Vou_no,dramt,cramt,Cheque_no,Vou_date,Entry_id,Uname from " _
                          & GMod.VENTRY & " v inner join " & GMod.ACC_HEAD & " a on v.Acc_head_code = a.account_code where vou_no between '" & txtFrom.Text & "' and '" & txtTo.Text & "' and Pay_mode='-' order by cast(vou_no as numeric(18,0)),Entry_id"
                GMod.SqlExecuteNonQuery(sqlinst)
            End If
            '----------------------------------------------------------------------------
            'GMod.DataSetRet("select  Acc_code, Acc_name, Narration , Vtype, Vouno, dramt, cramt, [Cheque No] , Vdate from daybook where uname='" & GMod.username & "' order by id", "repo")
            Dim sqldaybook As String
            'Delete  Zero values
            GMod.SqlExecuteNonQuery("delete from Daybook where (dramt=0 and cramt=0) and Vtype<>'OPEN' and uname ='" & GMod.username & "'")
            sqldaybook = " select Acc_code, Acc_name, Narration, d.Vtype, Vouno, dramt, cramt, [Cheque No], " _
                         & " Vdate,v.vprefix  vprefix  from Daybook d " _
                         & " left join vtype v  on d.vtype=v.vtype  and d.cmpid=v.Cmp_id where uname='" & GMod.username & "' and v.cmp_id='" & GMod.Cmpid & "' and v.session ='" & GMod.Session & "' or d.vtype='OPEN' order by id"

            'GMod.DataSetRet("select  Acc_code, Acc_name, Narration, Vtype, Vouno, dramt, cramt, [Cheque No], Vdate from daybook where uname='" & GMod.username & "' order by id", "repo")
            GMod.DataSetRet(sqldaybook, "repo")


            'Dim s, q As String
            'For i = 0 To GMod.ds.Tables("repo").Rows.Count - 1
            '    s = "select account_head_name from " & GMod.ACC_HEAD & "  where account_code ='" & GMod.ds.Tables("repo").Rows(i)("Acc_code").ToString & "'"
            '    GMod.DataSetRet(s, "newerr")
            '    If GMod.ds.Tables("repo").Rows(i)("Acc_code").ToString <> GMod.ds.Tables("newerr").Rows(0)(0).ToString Then
            '        q = "update Daybook set Acc_name='" & GMod.ds.Tables("newerr").Rows(0)(0).ToString & "'  where Acc_code='" & GMod.ds.Tables("repo").Rows(i)("Acc_code").ToString & "'"
            '        GMod.SqlExecuteNonQuery(q)
            '    End If
            'Next

            Dim r As New CrBook
            r.SetDataSource(GMod.ds.Tables("repo"))
            r.SetParameterValue("cmpname", GMod.Cmpname)
            r.SetParameterValue("vdate", "")
            r.SetParameterValue("uname", GMod.username)
            CrystalReportViewer1.ReportSource = r

            dgAuth.DataSource = GMod.ds.Tables("repo")

            'GMod.SqlExecuteNonQuery("drop table daybook")
            ' btnprint.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CreateTableDayBook()
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='Daybook'", "tableaccountbook")
        If GMod.ds.Tables("tableaccountbook").Rows.Count = 0 Then
            Dim daybook As String
            daybook = "CREATE TABLE [Daybook](" _
            & " [cmpid] [varchar](4), " _
            & "[Acc_code] [varchar](18)," _
            & "[Acc_name] [varchar](50), " _
            & "[narration][varchar](500)," _
            & "[Group_name] [varchar](80), " _
            & "[Sub_Group] [varchar](80)," _
            & "[Vtype] [varchar](30)," _
            & "[Vouno] [varchar](18)," _
            & "[dramt] [numeric](18, 2) NULL," _
            & "[cramt] [numeric](18, 2) NULL," _
            & "[Cheque No] [varchar](100)," _
            & "[Vdate] [datetime] NULL," _
            & "[entryid] [int] NULL, " _
            & "[Uname] [varchar](50)  NULL, " _
            & "[id] [bigint] IDENTITY(1,1) NOT NULL )"
            GMod.SqlExecuteNonQuery(daybook)
        End If
        GMod.ds.Tables("tableaccountbook").Dispose()
    End Sub
    Private Sub rdOnscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' If rdOnscreen.Checked = True Then
        'dgBook.BringToFront()
        CrystalReportViewer1.SendToBack()
        Dim sqltotal As String
        sqltotal = " insert into Daybook (cmpid, Narration,dramt,cramt,vtype,Uname)  " _
                      & " select '" & GMod.Cmpid & "','TOTAL',sum(dramt) dr,Sum(cramt) cr ,'-','" & GMod.username & "' from Daybook where Uname='" & GMod.username & "' "
        GMod.SqlExecuteNonQuery(sqltotal)

        sqltotal = " insert into Daybook (cmpid,Narration,vtype,dramt,cramt,Uname)  " _
                              & " select '" & GMod.Cmpid & "','BALANCE','-',case " _
                               & " when sum(dramt)-sum(cramt)>0 then sum(dramt)-sum(cramt) " _
                               & " else 0 end dr,case when sum(dramt)-sum(cramt) < 0 then sum(dramt)-sum(cramt) " _
                               & " else 0 end ,'" & GMod.username & "' from  DayBook where Uname='" _
                                & GMod.username & "' and Narration<>'TOTAL'"
        GMod.SqlExecuteNonQuery(sqltotal)
        Dim sqldaybook As String
        sqldaybook = " select Acc_code, Acc_name, Narration, d.Vtype, Vouno, dramt, cramt, [Cheque No], " _
                     & " Vdate,v.vprefix  vprefix  from Daybook d " _
                     & " left join vtype v  on d.vtype=v.vtype where uname='" & GMod.username & "' and v.cmp_id='" & GMod.Cmpid & "' or d.vtype='OPEN' order by id"
        'GMod.DataSetRet("select  Acc_code, Acc_name, Narration, Vtype, Vouno, dramt, cramt, [Cheque No], Vdate from daybook where uname='" & GMod.username & "' order by id", "repo")
        GMod.DataSetRet(sqldaybook, "repo")
        'dgBook.DataSource = GMod.ds.Tables("repo")
        'rdOnscreen.Enabled = False
        'rdPrint.Enabled = True
        'End If
    End Sub

    Private Sub rdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If rdPrint.Checked = True Then
        '    CrystalReportViewer1.BringToFront()
        '    'dgBook.SendToBack()
        '    GMod.SqlExecuteNonQuery("delete from Daybook where Narration in ('TOTAL','BALANCE') AND cmpid='" & GMod.Cmpid & "'")
        '    rdOnscreen.Enabled = True
        '    rdPrint.Enabled = False
        'End If
    End Sub
    Dim sw As StreamWriter
    Dim ln, pageno As Integer
    Private Sub btndosprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rdPrint_Click(sender, e)
        Dim narration As String
        Dim cr, dr As Double
        cr = 0
        dr = 0
        Dim re As Integer
        ln = 1
        Dim s As String
        sw = File.CreateText("c:\daybook.txt")
        pageno = 0
        Try
            header()
            For re = 0 To GMod.ds.Tables("repo").Rows.Count - 1
                dr = dr + CDbl(GMod.ds.Tables("repo").Rows(re)("dramt"))
                cr = cr + CDbl(GMod.ds.Tables("repo").Rows(re)("cramt"))

                s = "     "
                'cmpid, Acc_code, Acc_name, narration, Group_name, Sub_Group, Vtype, Vouno, dramt, cramt, Cheque No, Vdate, entryid, Uname, id
                s = s & GMod.ds.Tables("repo").Rows(re)("acc_name")
                'adding blank space if name less than 30 
                While (s.Length <= 35)
                    s = s & " "
                End While
                'Adding cheque No to narration
                narration = ""
                If GMod.ds.Tables("repo").Rows(re)("Cheque No").ToString.Length > 1 Then
                    narration = GMod.ds.Tables("repo").Rows(re)("narration").ToString & " CHQ NO. " & GMod.ds.Tables("repo").Rows(re)("Cheque No").ToString
                Else
                    narration = GMod.ds.Tables("repo").Rows(re)("narration").ToString
                End If
                'MsgBox(narration.Contains(vbNewLine))
                GMod.spliterbook(narration)
                s = s & sp1(0)
                'adding blank space if naration less than 60
                While (s.Length < 97)
                    s = s & " "
                End While
                s = s & " "
                'If GMod.ds.Tables("repo").Rows(re)("vtype").ToString = "CR VOUCHER" Or GMod.ds.Tables("repo").Rows(re)("vtype").ToString = "COLL-AREA" Then
                'If GMod.ds.Tables("repo").Rows(re)("v.vprefix").ToString.Length > 0 Then
                's = s & GMod.ds.Tables("repo").Rows(re)("vtype").ToString.Substring(0, 2) & "/" & GMod.ds.Tables("repo").Rows(re)("vouNO")
                If GMod.ds.Tables("repo").Rows(re)("vtype").ToString = "OPEN" Then
                    s = s & "    "
                Else
                    s = s & GMod.ds.Tables("repo").Rows(re)("vprefix").ToString & "/" & GMod.ds.Tables("repo").Rows(re)("vouNO")
                End If
                'adding blank space
                While (s.Length < 105)
                    s = s & " "
                End While
                If GMod.ds.Tables("repo").Rows(re)("dramt") > 0 Then s = s & Format(GMod.ds.Tables("repo").Rows(re)("dramt"), "0.00").PadLeft(12, " ") Else s = s & "            "
                If GMod.ds.Tables("repo").Rows(re)("cramt") > 0 Then s = s & Format(GMod.ds.Tables("repo").Rows(re)("cramt"), "0.00").PadLeft(12, " ") Else s = s & "            "
                sw.WriteLine(s)
                s = "     "
                'secondd row
                'cmpid, Acc_code, Acc_name, narration, Group_name, Sub_Group, Vtype, Vouno, dramt, cramt, Cheque No, Vdate, entryid, Uname, id
                s = s & GMod.ds.Tables("repo").Rows(re)("acc_code")
                'adding blank space if name less than 30 
                While (s.Length <= 35)
                    s = s & " "
                End While
                If Len(sp1(1)) > 0 Then
                    s = s & sp1(1)
                    'adding blank space if naration less than 60
                    'earlier it was 97
                    While (s.Length < 92)
                        s = s & " "
                    End While
                End If
                ln = ln + 1
                sw.WriteLine(s)
                If Len(sp1(2)) > 0 Then
                    s = "                                    " & sp1(2)
                    ln = ln + 1
                    sw.WriteLine(s)
                End If

                ln = ln + 1
                sw.WriteLine("")
                If ln > 40 Then
                    sw.WriteLine(Convert.ToChar(12).ToString)
                    header()
                    'pageno = pageno + 1
                    ln = 1
                End If
            Next
            sw.WriteLine("")
            Dim ptotal As String = ""
            ptotal = "                                    TOTAL"
            ptotal = ptotal & "                                                                " & Format(dr, "0.00").PadLeft(12, " ")
            ptotal = ptotal & " " & Format(cr, "0.00").PadLeft(12, " ")
            sw.WriteLine("----------------------------------------------------------------------------------------------------------------------------------")
            sw.WriteLine(ptotal)
            sw.WriteLine("----------------------------------------------------------------------------------------------------------------------------------")
            sw.WriteLine("")
            Dim pbal As String = ""
            pbal = "                                    BALANCE "
            dr = dr - cr
            If dr > 0 Then
                pbal = pbal & "                                                                 " & Format(Math.Abs(dr), "0.00").PadLeft(12, " ")
            Else
                pbal = pbal & "                                                                          " & Format(Math.Abs(dr), "0.00").PadLeft(12, " ")
            End If
            sw.WriteLine(pbal)
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine(" (CHIEF GENERAL MANAGER)                     (ACCOUNTANT)               (GENERAL MANAGER)               (DATA PROCESSING MANAGER)")
            sw.WriteLine("   ACCOUNTS & FINANCE                                                      ACCOUNTS                                              ")
            'sw.Close()
            'Dim p As New Process
            'p.StartInfo.FileName = "daybook.bat"
            'p.Start()

            sw.Close()
            Dim p As New Process
            p.StartInfo.FileName = "printfile.bat"
            p.StartInfo.Arguments = "c:\daybook.txt"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()
            'p.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        sw.Close()

    End Sub
    Sub header()
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
        s = s & "DAILY  TRANSACTION BOOK"
        sw.WriteLine(s)
        s = "    Date: " + txtFrom.Text
        For i = 0 To 98
            s = s + " "
        Next
        s = s + "Page No: " & pageno
        sw.WriteLine(s)
        s = ""
        sw.WriteLine("----------------------------------------------------------------------------------------------------------------------------------")
        s = ""
        sw.WriteLine("    ACCOUNT HEAD                                         PARTICULAR                               DOC NO     DEBIT R/s  CREDIT R/s")
        s = ""
        sw.WriteLine("----------------------------------------------------------------------------------------------------------------------------------")
    End Sub
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CrystalReportViewer1.PrintReport()
        'btnprint.Enabled = False
    End Sub

    Private Sub btnAuth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuth.Click

        Dim i As Integer
        Dim trans As SqlTransaction
        trans = GMod.SqlConn.BeginTransaction
        Try

            If listgrp.CheckedItems.Count > 0 Then
                For i = 0 To listgrp.CheckedItems.Count - 1
                    sql = " update " & GMod.VENTRY & " set pay_mode='" & GMod.username & "'  where vou_type='" & listgrp.CheckedItems([i].ToString) _
                          & "' and cast(vou_no as bigint) between '" & txtFrom.Text & "' and '" & txtTo.Text & "'"
                    Dim cmd As New SqlCommand(sql, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()


                    ' sql = "update tdsentry set authr='-' where session ='1112'"
                    sql = " update tdsentry  set authr='" & GMod.username & "'  where vou_type='" & listgrp.CheckedItems([i].ToString) _
                                             & "' and cast(vou_no as bigint) between '" & txtFrom.Text & "' and '" & txtTo.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
                    Dim cmdtds As New SqlCommand(sql, GMod.SqlConn, trans)
                    cmdtds.ExecuteNonQuery()


                    If GMod.Dept = 1 Then
                        sql = " update purchase_data  set authr='" & GMod.username & "'  where vou_type='" & listgrp.CheckedItems([i].ToString) _
                                                                 & "' and cast(vou_no as bigint) between '" & txtFrom.Text & "' and '" & txtTo.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
                        Dim cmdpurdata As New SqlCommand(sql, GMod.SqlConn, trans)
                        cmdpurdata.ExecuteNonQuery()
                    End If
                Next
            End If
            trans.Commit()
            MsgBox("Authorization Complete", MsgBoxStyle.Information)
        Catch ex As Exception
            trans.Rollback()
        End Try

        CrystalReportViewer1.ReportSource = Nothing
    End Sub

    Private Sub rdOnscreen_CheckedChanged(sender As Object, e As EventArgs) Handles rdOnscreen.CheckedChanged
        If rdOnscreen.Checked = True Then
            dgAuth.Visible = True
            CrystalReportViewer1.Visible = False
            CrystalReportViewer1.SendToBack()
        End If
    End Sub

    Private Sub rdPrint_CheckedChanged(sender As Object, e As EventArgs) Handles rdPrint.CheckedChanged
        If rdPrint.Checked = True Then
            dgAuth.Visible = False
            CrystalReportViewer1.Visible = True
            dgAuth.SendToBack()
        End If
    End Sub
End Class