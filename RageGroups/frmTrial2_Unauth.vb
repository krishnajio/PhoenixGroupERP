Imports System.IO
Public Class frmTrial2_Unauth

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


        If GMod.staff1 = 1 And GMod.role = "VIEWER LEVEL-1" Then
            ' GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "' and group_name NOT IN('PARTY','CUSTOMER','INTERNAL PARTY') order by group_name", "grp")
            GMod.DataSetRet("select distinct group_name from   " & GMod.ACC_HEAD & "  where group_name not in ('PARTY','STAFF(HO)') order by group_name", "grp")
        ElseIf GMod.staff1 = 2 And GMod.role = "VIEWER LEVEL-1" Then
            GMod.DataSetRet("select distinct group_name from   " & GMod.ACC_HEAD & "  where group_name not in ('PARTY') order by group_name", "grp")
        Else
            'GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "' and group_name NOT IN('PARTY','CUSTOMER','INTERNAL PARTY','STAFF') order by group_name", "grp")
            GMod.DataSetRet("select distinct group_name from   " & GMod.ACC_HEAD & "  where group_name not in ('PARTY','STAFF','STAFF(HO)') order by group_name", "grp")
        End If

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

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click


        If chkallgengrps.Checked = True Then
            AllGroup()
        Else
            GroupWise()
        End If

        Dim param As String
        If chkallgengrps.Checked = True Then
            param = "ALL GENERAL GROUPS"
        Else
            param = "GROUP: " & cmbgrpname.Text
        End If

        If chkArea.Checked = True Then
            param = param & "  AREA : [ " & cmbAreaName.Text & " ]"
        Else
            param = param & " [ ALL AREA ]"
        End If

        If chkadvformat.Checked = True Then
            Dim r As New CrTrial2
            r.SetDataSource(GMod.ds.Tables("trial2"))
            r.SetParameterValue("cmpname", GMod.Cmpname & "[Tentative Trial]")
            r.SetParameterValue("s1", "Tentative Trial Balance as on " & dtfrom.Text)
            r.SetParameterValue("s2", param)
            r.SetParameterValue("uid", GMod.username)
            CrViewerGenralLedger.ReportSource = r
            r = Nothing
        End If
        If chksimpleformat.Checked = True Then
            Dim r1 As New CrTrial2Simple
            r1.SetDataSource(GMod.ds.Tables("trial2"))
            r1.SetParameterValue("cmpname", GMod.Cmpname & "[Tentative Trial]")
            r1.SetParameterValue("s1", "Tentative Trial Balance as on " & dtfrom.Text)
            r1.SetParameterValue("s2", param)
            r1.SetParameterValue("uid", GMod.username)
            CrViewerGenralLedger.ReportSource = r1
            r1 = Nothing
        End If
        btnprint.Enabled = True
    End Sub
    Public Sub AllGroup()
        If rdwithopening.Checked = True Then
            sqlSelect = "select q.account_code,q.acname," _
           & " DrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 then  (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end, " _
           & " CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0 then  abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) else 0 end," _
           & " q.group_name," _
           & " isnull(p.dramt,0) + isnull(q.odr,0) d , isnull(p.cramt,0) + q.ocr c , isnull(q.odr,0) odr , q.ocr " _
           & " from (" _
           & " select isnull(sum(dramt),0) dramt ,isnull(sum(cramt),0) cramt,acc_head_code" _
           & " from " & GMod.VENTRY & " " _
           & " where vou_date<='" & dtfrom.Value.ToShortDateString & "' " _
           & " group by acc_head_code ) p " _
           & " Right Join " _
           & " ( select account_code,account_head_name acname ,group_name, isnull(opening_dr,0) odr  , " _
           & " isnull(opening_cr,0) ocr from " & GMod.ACC_HEAD & " where group_name not in ('CASH IN HAND','STAFF','STAFF(HO)'  )) q " _
           & " on p.acc_head_code=q.account_code  " _
           & " where ((isnull(p.dramt,0) + q.odr) <> (isnull(p.cramt,0) + q.ocr)) "

        End If

        If edwoopening.Checked = True Then
            SqlSelect1 = "select q.account_code,q.acname," _
                    & " DrAmt = case when  ((isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0))  > 0 then  (isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0) else 0 end, " _
                    & " CrAmt = case when  ((isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0))  < 0 then  abs((isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0)) else 0 end," _
                    & " q.group_name," _
                    & " isnull(p.dramt,0) + isnull(0,0) d , isnull(p.cramt,0) + 0 c , q.odr, q.ocr " _
                    & " from (" _
                    & " select isnull(sum(dramt),0) dramt ,isnull(sum(cramt),0) cramt,acc_head_code" _
                    & " from " & GMod.VENTRY & " " _
                    & " where vou_date<='" & dtfrom.Value.ToShortDateString & "'" _
                    & " group by acc_head_code ) p " _
                    & " Right Join " _
                    & " ( select account_code,account_head_name acname ,group_name, isnull(opening_dr,0) odr  , " _
                    & " isnull(opening_cr,0) ocr from " & GMod.ACC_HEAD & " where group_name<>'CASH IN HAND' ) q " _
                    & " on p.acc_head_code=q.account_code  " _
                    & " where ((isnull(p.dramt,0) + q.odr) <> (isnull(p.cramt,0) + q.ocr)) and q.group_name not in ('CASH IN HAND','STAFF','STAFF(HO)') "
        End If
        If BOTH.Checked = True Then

        End If
        If Dr.Checked = True Then
            sqlSelect = sqlSelect & " and ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0"
            SqlSelect1 = SqlSelect1 & " and ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0"
        End If
        If Cr.Checked = True Then
            sqlSelect = sqlSelect & " and ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0"
            SqlSelect1 = SqlSelect1 & " and ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0"
        End If
        If chkArea.Checked = True Then
            sqlSelect = sqlSelect & "and left(account_code,2)='" & cmbAreaCode.Text & "'"
            SqlSelect1 = SqlSelect1 & " and left(account_code,2)='" & cmbAreaCode.Text & "'"

        End If
        If rdCode.Checked = True Then
            sqlSelect = sqlSelect & " order by q.group_name,q.account_code"
            SqlSelect1 = SqlSelect1 & " order by q.group_name,q.account_code"
        End If

        If rdName.Checked = True Then
            sqlSelect = sqlSelect & " order by q.group_name,q.acname"
            SqlSelect1 = SqlSelect1 & " order by q.group_name,q.acname"
        End If

        If edwoopening.Checked = True Then
            GMod.DataSetRet(SqlSelect1, "trial2")
        Else
            GMod.DataSetRet(sqlSelect, "trial2")
        End If

    End Sub
    Dim sqlSelect, SqlSelect1 As String
    Public Sub GroupWise()

        If rdwithopening.Checked = True Then
            sqlSelect = "select q.account_code,q.acname," _
           & " DrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 then  (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end, " _
           & " CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0 then  abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) else 0 end," _
           & " q.group_name," _
           & " isnull(p.dramt,0) + isnull(q.odr,0) d , isnull(p.cramt,0) + q.ocr c , isnull(q.odr,0) odr , q.ocr " _
           & " from (" _
           & " select isnull(sum(dramt),0) dramt ,isnull(sum(cramt),0) cramt,acc_head_code" _
           & " from " & GMod.VENTRY & " " _
           & " where vou_date<='" & dtfrom.Value.ToShortDateString & "'" _
           & " group by acc_head_code ) p " _
           & " Right Join " _
           & " ( select account_code,account_head_name acname ,group_name, isnull(opening_dr,0) odr  , " _
           & " isnull(opening_cr,0) ocr from " & GMod.ACC_HEAD & " where group_name='" & cmbgrpname.Text & "' ) q " _
           & " on p.acc_head_code=q.account_code  " _
           & " where ((isnull(p.dramt,0) + q.odr) <> (isnull(p.cramt,0) + q.ocr))  "
        End If

        If edwoopening.Checked = True Then
            SqlSelect1 = "select q.account_code,q.acname," _
                    & " DrAmt = case when  ((isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0))  > 0 then  (isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0) else 0 end, " _
                    & " CrAmt = case when  ((isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0))  < 0 then  abs((isnull(p.dramt,0) + 0) - (isnull(p.cramt,0) + 0)) else 0 end," _
                    & " q.group_name," _
                    & " isnull(p.dramt,0) + isnull(0,0) d , isnull(p.cramt,0) + 0 c , q.odr, q.ocr " _
                    & " from (" _
                    & " select isnull(sum(dramt),0) dramt ,isnull(sum(cramt),0) cramt,acc_head_code" _
                    & " from " & GMod.VENTRY & " " _
                    & " where vou_date<='" & dtfrom.Value.ToShortDateString & "'" _
                    & " group by acc_head_code ) p " _
                    & " Right Join " _
                    & " ( select account_code,account_head_name acname ,group_name, isnull(opening_dr,0) odr  , " _
                    & " isnull(opening_cr,0) ocr from " & GMod.ACC_HEAD & " where group_name='" & cmbgrpname.Text & "' ) q " _
                    & " on p.acc_head_code=q.account_code  " _
                  & " where ((isnull(p.dramt,0) + q.odr) <> (isnull(p.cramt,0) + q.ocr))  "
        End If
        If BOTH.Checked = True Then

        End If
        If Dr.Checked = True Then
            sqlSelect = sqlSelect & " and ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0"
            SqlSelect1 = SqlSelect1 & " and ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0"
        End If
        If Cr.Checked = True Then
            sqlSelect = sqlSelect & " and ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0"
            SqlSelect1 = SqlSelect1 & " and ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0"
        End If
        If chkArea.Checked = True Then
            sqlSelect = sqlSelect & "and left(account_code,2)='" & cmbAreaCode.Text & "'"
            SqlSelect1 = SqlSelect1 & " and left(account_code,2)='" & cmbAreaCode.Text & "'"

        End If
        If rdCode.Checked = True Then
            sqlSelect = sqlSelect & " order by q.account_code"
            SqlSelect1 = SqlSelect1 & " order by q.account_code"
        End If

        If rdName.Checked = True Then
            sqlSelect = sqlSelect & " order by q.acname"
            SqlSelect1 = SqlSelect1 & " order by q.acname"
        End If

        If edwoopening.Checked = True Then
            GMod.DataSetRet(SqlSelect1, "trial2")
        Else
            GMod.DataSetRet(sqlSelect, "trial2")
        End If


    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        CrViewerGenralLedger.PrintReport()
        btnprint.Enabled = False
    End Sub

    Private Sub btnDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDos.Click
        'account_code, acname, DrAmt, CrAmt, group_name, d, c
        Dim dt() As String
        Dim cr, dr, bl As Double
        cr = 0
        dr = 0
        ln = 1
        Dim s As String
        sw = File.CreateText("trial.txt")
        pageno = 0
        If chkallgengrps.Checked = True Then
            gr = GMod.ds.Tables("trial2").Rows(0)("group_name")
        Else
            gr = cmbgrpname.Text
        End If
        heads()
        For re = 0 To GMod.ds.Tables("trial2").Rows.Count - 1
            s = "   "
            s = s & GMod.ds.Tables("trial2").Rows(re)("account_code")
            s = s & "    " & GMod.ds.Tables("trial2").Rows(re)("acname")
            While (s.Length < 49)
                s = s & " "
            End While
            bl = CDbl(GMod.ds.Tables("trial2").Rows(re)("DrAmt")) - CDbl(GMod.ds.Tables("trial2").Rows(re)("CrAmt"))
            If bl > 0 Then
                s = s & Format(bl, "0.00").PadLeft(12, " ")
                dr = dr + bl
                grpdr = grpdr + bl
            Else
                s = s & "                  " & Format(Math.Abs(bl), "0.00").PadLeft(12, " ")
                cr = cr + bl
                grpcr = grpcr + bl
            End If
            sw.WriteLine(s)
            ln = ln + 1
            sw.WriteLine("")
            ln = ln + 1

            If ln > 60 Then
                'MsgBox(ln)
                sw.WriteLine(Convert.ToChar(12).ToString)
                If chkallgengrps.Checked = True Then
                    gr = GMod.ds.Tables("trial2").Rows(re)("group_name")
                Else
                    gr = cmbgrpname.Text
                End If
                heads()
                'pageno = pageno + 1
                ln = 1
            End If
            If chkallgengrps.Checked = True Then
                If re < GMod.ds.Tables("trial2").Rows.Count - 1 Then
                    If GMod.ds.Tables("trial2").Rows(re)("group_name") <> GMod.ds.Tables("trial2").Rows(re + 1)("group_name") Then
                        If chkallgengrps.Checked = True Then
                            fotter()
                            sw.WriteLine(Convert.ToChar(12).ToString)
                            gr = GMod.ds.Tables("trial2").Rows(re + 1)("group_name")
                        Else
                            gr = cmbgrpname.Text
                        End If
                        heads()
                        ln = 1
                    End If
                End If
            Else

            End If
        Next
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        s = "                                            TOTAL:" & Format(Math.Abs(dr), "0.00").PadLeft(12, " ") & "     " & Format(Math.Abs(cr), "0.00").PadLeft(12, " ")
        sw.WriteLine(s)
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        bl = 0
        bl = dr - Math.Abs(cr)
        While (s.Length < 41)
            s = s & " "
        End While
        If bl > 0 Then
            s = s & "BALANCE: " & Format(bl, "0.00").PadLeft(12, " ") & " Dr"
        Else
            s = s & "                    BALANCE:" & Format(Math.Abs(bl), "0.00").PadLeft(12, " ") & " Cr"
        End If
        sw.WriteLine(s)
        sw.WriteLine(Convert.ToChar(12).ToString)
        'sw.Close()
        'Dim p As New Process
        'p.StartInfo.FileName = "trial.bat"
        'p.Start()
        'sw.Close()
        sw.Close()
        Dim p As New Process
        p.StartInfo.FileName = "printfile.bat"
        p.StartInfo.Arguments = "trial.txt"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.Start()




    End Sub
    Dim grpdr, grpcr As Double
    Sub fotter()
        Dim s As String, bl As Double
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        s = "                                            TOTAL:" & Format(Math.Abs(grpdr), "0.00").PadLeft(12, " ") & "     " & Format(Math.Abs(grpcr), "0.00").PadLeft(12, " ")
        sw.WriteLine(s)
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        bl = 0
        bl = grpdr - Math.Abs(grpcr)
        While (s.Length < 41)
            s = s & " "
        End While
        If bl > 0 Then
            s = s & "BALANCE: " & Format(bl, "0.00").PadLeft(12, " ") & " Dr"
        Else
            s = s & "                    BALANCE:" & Format(Math.Abs(bl), "0.00").PadLeft(12, " ") & " Cr"
        End If
        sw.WriteLine(s)
        grpdr = 0
        grpcr = 0
    End Sub
    Dim sw As StreamWriter
    Dim ln, pageno As Integer
    Dim gr As String
    Public Sub heads()
        pageno = pageno + 1
        Dim i As Integer
        sw.WriteLine("")
        Dim s As String
        For i = 0 To 30
            s = s + " "
        Next
        s = s & Convert.ToChar(14).ToString & GMod.Cmpname.ToUpper
        sw.WriteLine(s)
        s = ""
        For i = 0 To 30
            s = s + " "
        Next
        s = s & "TRIAL AS ON :" & " " & dtfrom.Text
        sw.WriteLine(s)
        s = ""

        s = "    GROUP NAME :" & Convert.ToChar(20).ToString & " " & gr
        'sw.WriteLine(s)
        For i = 0 To 41
            s = s + " "
        Next
        s = s + "Page No: " & pageno
        sw.WriteLine(s)
        s = ""
        If chkArea.Checked = True Then
            s = "    AREA :" & " " & cmbAreaName.Text
            sw.WriteLine(s)
        End If
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        s = ""
        sw.WriteLine("   A/c CODE    A/c NAME                             DEBIT R/s            CREDIT R/s ")
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
    End Sub
    Dim re As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub chksimpleformat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksimpleformat.CheckedChanged
        If chksimpleformat.Checked = True Then
            chkadvformat.Checked = False
        End If
    End Sub

    Private Sub chkadvformat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkadvformat.CheckedChanged
        If chkadvformat.Checked = True Then
            chksimpleformat.Checked = False
        End If
    End Sub

    Private Sub dtfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfrom.ValueChanged

    End Sub

    Private Sub chkallgengrps_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkallgengrps.CheckedChanged

    End Sub
End Class