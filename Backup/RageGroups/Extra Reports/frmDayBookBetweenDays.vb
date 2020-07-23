Imports System.IO
Public Class frmDayBookBetweenDays

    Private Sub frmDayBookBetweenDays_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtfrom.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        GMod.SqlExecuteNonQuery("delete from Daybook")
        Me.Text = "Day" & Me.Text & "    " & "[" & GMod.Cmpname & "]"
        CreateTableDayBook()
        Dim i As Integer
        'Seeting Session Start DATE
        'Dim sdate As String = "4/1/" & GMod.Session.Substring(0, 2).ToString
        'dtfrom.Value = CDate(sdate)
        listgrp.Items.Clear()
        GMod.DataSetRet("select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and vtype<>'OPEN' order by seqorder", "grp")
        For i = 0 To GMod.ds.Tables("grp").Rows.Count - 1
            listgrp.Items.Add(GMod.ds.Tables("grp").Rows(i)(0))
            listgrp.SetSelected(i, True)
        Next
        For i = 0 To listgrp.Items.Count - 1

        Next

    End Sub
    Public Sub CreateTableDayBook()
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='Daybook'", "tableaccountbook")
        If GMod.ds.Tables("tableaccountbook").Rows.Count = 0 Then
            Dim daybook As String
            daybook = "CREATE TABLE [Daybook](" _
            & " [cmpid] [varchar](4), " _
            & "[Acc_code] [varchar](8)," _
            & "[Acc_name] [varchar](30), " _
            & "[narration][varchar](180)," _
            & "[Group_name] [varchar](40), " _
            & "[Sub_Group] [varchar](40)," _
            & "[Vtype] [varchar](30)," _
            & "[Vouno] [varchar](18)," _
            & "[dramt] [numeric](18, 2) NULL," _
            & "[cramt] [numeric](18, 2) NULL," _
            & "[Cheque No] [varchar](20)," _
            & "[Vdate] [datetime] NULL," _
            & "[entryid] [int] NULL, " _
            & "[Uname] [varchar](10)  NULL, " _
            & "[id] [bigint] IDENTITY(1,1) NOT NULL )"
            GMod.SqlExecuteNonQuery(daybook)
        End If
        GMod.ds.Tables("tableaccountbook").Dispose()
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        GMod.SqlExecuteNonQuery("delete from Daybook")
        CreateTableDayBook() 'Creatting table day book
        Dim lst As String = "", i As Integer, n As Integer, j As Integer
        n = DateDiff(DateInterval.Day, dtfrom.Value, dtTo.Value)
        GMod.SqlExecuteNonQuery("delete from Daybook")
        Try
            For j = 0 To n
                'Deleting from day book 
                'MsgBox(GMod.SqlExecuteNonQuery("delete from daybook where Uname='" & GMod.username & "'"))


                If listgrp.CheckedItems.Count > 0 Then
                    For i = 0 To listgrp.CheckedItems.Count - 1
                        lst &= "'" & listgrp.CheckedItems([i].ToString) & "',"
                    Next
                End If
                lst = lst.Remove(lst.Length - 1, 1)
                Dim ocr, odr As Double
                'Getting Openg cash of the company 
                Dim sqlopncash As String = "select opening_cr, opening_dr from " & GMod.ACC_HEAD & " where account_head_name ='CASH' and cmp_id='" & GMod.Cmpid & "'"
                GMod.DataSetRet(sqlopncash, "Opencash")
                ocr = CDbl(GMod.ds.Tables("Opencash").Rows(0)(0).ToString)
                odr = CDbl(GMod.ds.Tables("Opencash").Rows(0)(1).ToString)
                GMod.ds.Tables.Clear()
                'Getting Closing cash of the day before of day book 
                Dim sqldaybefore As String = "select isnull(sum(dramt),0),isnull(sum(cramt),0) " _
                                             & "from " & GMod.VENTRY & " where vou_date < '" & dtfrom.Value.AddDays(j).ToShortDateString & "' and vou_type<>'BANKREC' and vou_type in(" & lst & ")"
                GMod.DataSetRet(sqldaybefore, "Opencash")

                ocr = ocr + CDbl(GMod.ds.Tables("Opencash").Rows(0)(1).ToString) 'Rows(rows)(coloumn)
                odr = odr + CDbl(GMod.ds.Tables("Opencash").Rows(0)(0).ToString)


                'adding Up both the value 
                GMod.ds.Tables.Clear()
                ocr = (odr - ocr) ' Substracting value and putting in ocr (always dr-cr)
                'MsgBox(ocr.ToString & "-" & odr.ToString)
                'Inserting in table day book 
                Dim sqlsave As String
                If ocr >= 0 Then
                    sqlsave = "insert into dbo.Daybook(cmpid, Narration,dramt,cramt,vtype,Uname,vdate)values( "
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'CASH BALANCE b/d',"
                    sqlsave &= "'" & ocr & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'" & dtfrom.Value.AddDays(j).ToShortDateString & "')"
                Else
                    ocr = -1 * ocr
                    sqlsave = "insert into Daybook(cmpid, Narration,dramt,cramt,vtype,Uname,vdate)values( "
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'CASH BALANCE b/d',"
                    sqlsave &= "'0',"
                    sqlsave &= "'" & ocr & "',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'" & dtfrom.Value.AddDays(j).ToShortDateString & "')"
                End If
                GMod.SqlExecuteNonQuery(sqlsave)
                'Calculating closing balance 
                Dim sqlinst, sqltotal As String
                'Inserting values to the table daybook according to sequence 
                If listgrp.CheckedItems.Count > 0 Then
                    For i = 0 To listgrp.CheckedItems.Count - 1
                        ' MsgBox(listgrp.CheckedItems([i].ToString))
                        sqlinst = "insert into daybook(cmpid, Acc_code, Acc_name, Narration, Group_name, Sub_Group, Vtype, Vouno, " _
                                  & "dramt, cramt, [Cheque No], Vdate, entryid, Uname) " _
                                  & " select  Cmp_id,Acc_head_code,Acc_head,Narration,Group_name, " _
                                  & "Sub_group_name,Vou_type,Vou_no,dramt,cramt,Cheque_no,Vou_date,Entry_id,'" & GMod.username & "' from " _
                                  & GMod.VENTRY & " where vou_type='" & listgrp.CheckedItems([i].ToString) _
                                  & "' and vou_date='" & dtfrom.Value.AddDays(j).ToShortDateString & "' order by cast(vou_no as numeric(18,0)),Entry_id"
                        GMod.SqlExecuteNonQuery(sqlinst)
                    Next
                Else
                    ' MsgBox(listgrp.CheckedItems([i].ToString))
                    sqlinst = "insert into daybook(cmpid, Acc_code, Acc_name, Narration, Group_name, Sub_Group, Vtype, Vouno, " _
                              & "dramt, cramt, [Cheque No], Vdate, entryid, Uname) " _
                              & " select  Cmp_id,Acc_head_code,Acc_head,Narration,Group_name, " _
                              & "Sub_group_name,Vou_type,Vou_no,dramt,cramt,Cheque_no,Vou_date,Entry_id,Uname from " _
                              & GMod.VENTRY & " where vou_date='" & dtfrom.Value.AddDays(j).ToShortDateString & "' and Uname='" & GMod.username & "' order by vou_no,entry_id "
                    GMod.SqlExecuteNonQuery(sqlinst)
                End If
            Next
            '----------------------------------------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim sw As StreamWriter
    Dim ln, pageno As Integer
    Private Sub btndosprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndosprint.Click

        btnshow_Click(sender, e)
        Dim narration As String
        Dim cr, dr As Double, n As Integer, j As Integer
        cr = 0
        dr = 0
        Dim re As Integer
        ln = 1
        Dim s As String
        sw = File.CreateText("c:\daybook.txt")
        pageno = 0
        n = DateDiff(DateInterval.Day, dtfrom.Value, dtTo.Value)
        ' MsgBox(n)
        Try
            For j = 0 To n
                pageno = 0
                dr = 0
                cr = 0
                Dim sqldaybook As String
                sqldaybook = " select Acc_code, Acc_name, Narration, d.Vtype, Vouno, dramt, cramt, [Cheque No], " _
                             & " Vdate,v.vprefix  vprefix  from Daybook d " _
                             & " left join vtype v  on d.vtype=v.vtype  and d.cmpid=v.Cmp_id where uname='" & GMod.username & "' and v.cmp_id='" & GMod.Cmpid & "'  and vdate='" & dtfrom.Value.AddDays(j).ToShortDateString & "' order by id"
                'GMod.DataSetRet("select  Acc_code, Acc_name, Narration, Vtype, Vouno, dramt, cramt, [Cheque No], Vdate from daybook where uname='" & GMod.username & "' order by id", "repo")
                GMod.DataSetRet(sqldaybook, "repo")

                If GMod.ds.Tables("repo").Rows.Count > 1 Then

                    header(dtfrom.Value.AddDays(j))
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
                            header(dtfrom.Value.AddDays(j))
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
                    sw.WriteLine(Convert.ToChar(12).ToString)
                End If
            Next
            sw.Close()
            Dim p As New Process
            p.StartInfo.FileName = "printfile.bat"
            p.StartInfo.Arguments = "c:\daybook.txt"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()
            MsgBox("ALL BOOK PRINTED", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub
    Sub header(ByVal hdate As DateTime)
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
        dtTo.Value = hdate
        s = "    Date: " + dtTo.Text
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
End Class