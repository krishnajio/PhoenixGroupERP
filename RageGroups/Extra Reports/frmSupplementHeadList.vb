Imports System.IO
Imports System.Data.SqlClient
Public Class frmSupplementHeadList

    Private Sub frmSupplementHeadList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Supp. Ledger  " & GMod.Cmpname
        dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtfrom.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        dtto.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtto.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        dtfrom.Value = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString
        dtto.Value = CDate("3/31/" & Mid(GMod.Session, 3, 4))


        Dim sql As String
        sql = "select distinct Acc_head_code,Acc_head from " & GMod.VENTRY & " where left(uname,1)='$'"
        GMod.DataSetRet(sql, "supphead")

        cmbacheadcode.DataSource = GMod.ds.Tables("supphead")
        cmbacheadcode.DisplayMember = "Acc_head_code"


        cmbacheadname.DataSource = GMod.ds.Tables("supphead")
        cmbacheadname.DisplayMember = "Acc_head"

        If GMod.role.ToUpper = "VIEWER LEVEL-1" Or GMod.role.ToUpper = "ADMIN" Then
            btnDos.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
        Else
            btnDos.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        cmbacheadcode.Enabled = True
        cmbacheadname.Enabled = True
        Dim SQL As String, sqlsave As String
        Dim bal As Double = 0.0
        SQL = "select q.account_code,q.account_head_name," _
        & " ClosingDr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0 then  (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) else 0 end, " _
        & " ClosingCr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then  abs((isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0))) else 0 end " _
        & "from" _
        & "(select  isnull(Acc_head_code,'') Acc_head_code , isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr " _
        & " from  " & GMod.VENTRY _
        & " where Acc_head_code='" & cmbacheadcode.Text & "' and vou_date BETWEEN '" & dtfrom.Value.ToShortDateString & "' AND '" & dtto.Value.ToShortDateString & "' and left(Uname,1)<>'$' and Pay_mode<>'-' group by Acc_head_code  ) p " _
        & " Right Join " _
        & " ( select isnull(account_code,'') account_code ,account_head_name,isnull(opening_dr,0) od,isnull(opening_cr,0)  oc from " & GMod.ACC_HEAD _
        & "  where   account_code='" & cmbacheadcode.Text & "') q on q.account_code=p.Acc_head_code "
        GMod.DataSetRet(SQL, "closebal")

        bal = Math.Abs(Val(GMod.ds.Tables("closebal").Rows(0)(2)) - Val(GMod.ds.Tables("closebal").Rows(0)(3)))

        ' MsgBox(GMod.ds.Tables("closebal").Rows(0)(2) & GMod.ds.Tables("closebal").Rows(0)(3))
        'dleting old data for that use 
        GMod.SqlExecuteNonQuery("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")


        sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
        sqlsave &= "'" & GMod.Cmpid & "',"
        sqlsave &= "'" & cmbacheadcode.Text & "',"
        sqlsave &= "' BALANCE C/F',"
        sqlsave &= "'OPEN',"
        sqlsave &= "'" & Val(GMod.ds.Tables("closebal").Rows(0)(2)) & "',"
        sqlsave &= "'" & Val(GMod.ds.Tables("closebal").Rows(0)(3)) & "',"
        sqlsave &= "'" & GMod.username & "')"
        GMod.SqlExecuteNonQuery(sqlsave)


        sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no, Uname) " _
                      & " select Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                      & " where  Acc_head_code='" & cmbacheadcode.Text & "' and vou_type<>'BANKREC' and left(Uname,1)='$'  and Pay_mode<>'-' order by vou_date,vou_no"
        GMod.SqlExecuteNonQuery(sqlsave)

        GMod.DataSetRet("select account_head_name from " & GMod.ACC_HEAD & " where account_code='" & cmbacheadcode.Text & "'", "ledhanedname")

        GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,balance  from repGeneralLedger1 where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by Vou_date,cast(Vou_no as bigint)", "ledPrint")
        Dim r As New CrLedger 'CrCrLedger is name of report
        r.SetDataSource(GMod.ds.Tables("ledPrint"))
        r.SetParameterValue("cmpname", GMod.Cmpname)
        r.SetParameterValue("accholder", "Account Holder : " & cmbacheadcode.Text & " " & GMod.ds.Tables("ledhanedname").Rows(0)(0).ToString())
        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
        r.SetParameterValue("uname", GMod.username)
        r.SetParameterValue("unauth", "")
        CrystalReportViewer1.ReportSource = r
    End Sub
    Dim sw As StreamWriter
    Dim ln, pageno As Integer
    Private Sub btnDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDos.Click
        'sw = File.CreateText("c:\\Ledger.txt")
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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub header(ByVal code As String, ByVal name As String)
        pageno = pageno + 1
        Dim i As Integer
        sw.WriteLine("")
        Dim s As String = ""
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
    Public Sub LedgerDOSPrint(ByVal code As String, ByVal name As String)
        'flag = False
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
        If boolall = False Then
            sw = File.CreateText("Ledger.txt")
        End If
        Dim narration, displaydate As String
        Dim dt() As String
        Dim cr, dr As Double
        cr = 0
        dr = 0
        Dim re As Integer
        ln = 1
        Dim s As String

        'pageno = 0
        Try
            'If filef = True Then
            '    If Not Directory.Exists("c:\\LedgerFle") Then
            '        Directory.CreateDirectory("c:\\LedgerFle")
            '    Else

            '    End If
            '    sw = File.CreateText("c:\\LedgerFle\\" & code & ".txt")
            'Else
            '    sw = File.CreateText("c:\\Ledger.txt")
            'End If


            Dim sqlledger As String
            sqlledger = " select Narration, d.Vou_type vou_type, Vou_no, dramt, cramt, " _
                            & " [Cheque_No],  Vou_date,v.vprefix  vprefix  from repGeneralLedger1 d " _
                            & " left join vtype v  on d.vou_type=v.vtype and d.cmpid=v.Cmp_id where uname='" & GMod.username & "' and " _
                            & " v.cmp_id='" & GMod.Cmpid & "'  order by Vou_date,cast(Vou_no as bigint) "

            GMod.DataSetRet(sqlledger, "Ledger")
            'MsgBox(GMod.ds.Tables("Ledger").Rows.Count)
            'If Val(GMod.ds.Tables("Ledger").Rows.Count) = 1 Then
            '    If Math.Abs(Val(GMod.ds.Tables("Ledger").Rows(0)("dramt")) - Val(GMod.ds.Tables("Ledger").Rows(0)("cramt"))) > 0 Then
            '        flag = True
            '    Else
            '        Exit Sub
            '    End If
            'Else
            '    'If Math.Abs(CDbl(GMod.ds.Tables("Ledger").Rows(1)("dramt")) - CDbl(GMod.ds.Tables("Ledger").Rows(1)("cramt"))) > 0 Then
            '    'Else
            '    '    Exit Sub
            '    'End If
            '    flag = True
            'End If

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
            ptotal = ptotal & " " & Format(cr, "0.00").PadLeft(12, " ")
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
                pbal = pbal & "                                                      " & Format(Math.Abs(dr), "0.00").PadLeft(12, " ") & " " & "Cr"
            End If
            sw.WriteLine(pbal)
            sw.WriteLine(Convert.ToChar(12).ToString)
            If boolall = False Then
                sw.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbacheadcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadcode.Leave
        cmbacheadcode.Enabled = False
        cmbacheadname.Enabled = False
    End Sub

    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged

    End Sub
    Private Sub cmbacheadname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadname.Leave
        ' MsgBox(cmbacheadname.FindStringExact(cmbacheadname.Text))
        If cmbacheadname.FindStringExact(cmbacheadname.Text) = -1 Then
            MsgBox("Please select correct head", MsgBoxStyle.Information)
            cmbacheadname.Focus()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(GMod.SqlExecuteNonQuery("update " & GMod.VENTRY & " set uname = '" & GMod.username & "' where acc_head_code='" & cmbacheadcode.Text & "'"))
    End Sub
    Private Sub cmbacheadname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadname.SelectedIndexChanged

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Are u sure?", "confiramtion", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MsgBox(GMod.SqlExecuteNonQuery("update " & GMod.VENTRY & " set uname = '" & GMod.username & "'  where left(uname,1) ='$' and Pay_mode<>'-'"))
        End If
    End Sub
    Private Sub CheckBoxSelect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSelect.CheckedChanged
        If CheckBoxSelect.Checked = True Then
            panel1.Visible = True
            Dim sql As String
            Dim i As Integer
            sql = "select distinct Acc_head_code+'#'+Acc_head from " & GMod.VENTRY & " where left(uname,1)='$' and Pay_mode<>'-'"
            GMod.DataSetRet(sql, "supphead1")
            For i = 0 To GMod.ds.Tables("supphead1").Rows.Count - 1
                chklistled.Items.Add(ds.Tables("supphead1").Rows(i)(0).ToString)
            Next

        Else
            panel1.Visible = False
        End If
    End Sub
    Dim boolall As Boolean = False
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim codefor10 As String = ""
        Dim HEAD As String = ""
        CheckBoxSelect.Enabled = False
        'If chklistled.CheckedItems.Count > 11 Then
        '    MsgBox("Select only 10 Ledger at time", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        Dim sqlsave As String
        Dim sql As String
        Dim bal As Double
        Try

            Dim code(3) As String
            boolall = True
            Dim z As Integer, i As Integer, K As Double
            z = 0
            Dim zzz As Double
            pageno = 0
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


                sql = "select q.account_code,q.account_head_name," _
        & " ClosingDr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0 then  (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) else 0 end, " _
        & " ClosingCr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then  abs((isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0))) else 0 end " _
        & " from" _
        & " (select  isnull(Acc_head_code,'') Acc_head_code , isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr " _
        & " from  " & GMod.VENTRY _
        & " where Acc_head_code='" & codefor10 & "' and vou_date BETWEEN '" & dtfrom.Value.ToShortDateString & "' AND '" & dtto.Value.ToShortDateString & "' and left(Uname,1)<>'$' and Pay_mode<>'-' group by Acc_head_code  ) p " _
        & " Right Join " _
        & " ( select isnull(account_code,'') account_code ,account_head_name,isnull(opening_dr,0) od,isnull(opening_cr,0)  oc from " & GMod.ACC_HEAD _
        & " where   account_code='" & codefor10 & "') q on q.account_code=p.Acc_head_code "
                GMod.DataSetRet(Sql, "closebal")

                bal = Math.Abs(Val(GMod.ds.Tables("closebal").Rows(0)(2)) - Val(GMod.ds.Tables("closebal").Rows(0)(3)))

                ' MsgBox(GMod.ds.Tables("closebal").Rows(0)(2) & GMod.ds.Tables("closebal").Rows(0)(3))
                'dleting old data for that use 
                GMod.SqlExecuteNonQuery("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")


                sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & codefor10 & "',"
                sqlsave &= "' BALANCE C/F',"
                sqlsave &= "'OPEN',"
                sqlsave &= "'" & Val(GMod.ds.Tables("closebal").Rows(0)(2)) & "',"
                sqlsave &= "'" & Val(GMod.ds.Tables("closebal").Rows(0)(3)) & "',"
                sqlsave &= "'" & GMod.username & "')"
                GMod.SqlExecuteNonQuery(sqlsave)


                sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no, Uname) " _
                              & " select Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                              & " where  Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC' and left(Uname,1)='$' and Pay_mode<>'-' order by vou_date,vou_no"
                GMod.SqlExecuteNonQuery(sqlsave)

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim codefor10 As String = ""
        Dim HEAD As String = ""
        CheckBoxSelect.Enabled = False
        'If chklistled.CheckedItems.Count > 11 Then
        '    MsgBox("Select only 10 Ledger at time", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        Dim sqlsave As String
        Dim sql As String
        Dim bal As Double
        Dim cmd As SqlCommand
        Try

            Dim code(3) As String
            boolall = True
            Dim z As Integer, i As Integer, K As Double
            z = 0
            Dim zzz As Double
            pageno = 0
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
                'Calulating openng and inserint into table 


                sql = "select q.account_code,q.account_head_name," _
        & " ClosingDr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0 then  (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) else 0 end, " _
        & " ClosingCr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then  abs((isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0))) else 0 end " _
        & " from" _
        & " (select  isnull(Acc_head_code,'') Acc_head_code , isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr " _
        & " from  " & GMod.VENTRY _
        & " where Acc_head_code='" & codefor10 & "' and vou_date BETWEEN '" & dtfrom.Value.ToShortDateString & "' AND '" & dtto.Value.ToShortDateString & "' and left(Uname,1)<>'$' and Pay_mode<>'-' group by Acc_head_code  ) p " _
        & " Right Join " _
        & " ( select isnull(account_code,'') account_code ,account_head_name,isnull(opening_dr,0) od,isnull(opening_cr,0)  oc from " & GMod.ACC_HEAD _
        & " where   account_code='" & codefor10 & "') q on q.account_code=p.Acc_head_code "
                GMod.DataSetRet(sql, "closebal")

                bal = Math.Abs(Val(GMod.ds.Tables("closebal").Rows(0)(2)) - Val(GMod.ds.Tables("closebal").Rows(0)(3)))

                ' MsgBox(GMod.ds.Tables("closebal").Rows(0)(2) & GMod.ds.Tables("closebal").Rows(0)(3))
                'dleting old data for that use 
                'GMod.SqlExecuteNonQuery("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
                

                Try
                    cmd = New SqlCommand("delete  from repGeneralLedger1 where cmpid='" & GMod.Cmpid & "' and upper(Uname)='" & GMod.username.ToUpper & "'", GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()


                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & codefor10 & "',"
                    sqlsave &= "' BALANCE C/F',"
                    sqlsave &= "'OPEN',"
                    sqlsave &= "'" & Val(GMod.ds.Tables("closebal").Rows(0)(2)) & "',"
                    sqlsave &= "'" & Val(GMod.ds.Tables("closebal").Rows(0)(3)) & "',"
                    sqlsave &= "'" & GMod.username & "')"
                    ' GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()

                    sqlsave = "insert into repGeneralLedger1(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no, Uname) " _
                                  & " select Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                                  & " where  Acc_head_code='" & codefor10 & "' and vou_type<>'BANKREC' and left(Uname,1)='$' and Pay_mode<>'-' order by vou_date,vou_no"
                    'GMod.SqlExecuteNonQuery(sqlsave)
                    cmd = New SqlCommand(sqlsave, GMod.SqlConn, trans)
                    cmd.ExecuteNonQuery()
                    trans.Commit()
                Catch ex As Exception
                    trans.Rollback()
                    Me.Close()
                End Try

                '----------------------------------------------------------------------------------------
                'LedgerDOSPrint(code(0), code(1))
                'MessageBox.Show("NEXT")
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

                code(0) = ""
                code(1) = ""
                codefor10 = ""
            Next
            z = 0
            ' sw.Close()
            Dim p As New Process
            ' p.StartInfo.FileName = "printfile.bat"
            'p.StartInfo.Arguments = "Ledger.txt"
            ' p.StartInfo.UseShellExecute = False
            'p.StartInfo.RedirectStandardOutput = True
            'p.Start()
            MsgBox("ALL Ledger Printed", MsgBoxStyle.Information)
            boolall = False
            panel1.Visible = False
            z = 0
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class