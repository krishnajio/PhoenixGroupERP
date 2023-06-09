Imports System.IO
Imports System.Diagnostics
Public Class frmlogin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
    Private Sub frmlogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub
    Public Sub FillSession()
        Dim sqlgetate As String
        sqlgetate = "select getdate()"
        GMod.DataSetRet(sqlgetate, "gdate")
        dtCurrDate.Value = CDate(GMod.ds.Tables("gdate").Rows(0)(0))
        'Dim i As Integer
        Dim start As Integer = 8
        'dtCurrDate.Value = "4/1/08"
        'For i = 0 To 50
        'dtCurrDate.Value = dtCurrDate.Value.AddYears(i)
        'cmbSession.Items.Add(GMod.Getsession(dtCurrDate.Value))
        'Next
    End Sub
    Public Sub createBatchFile()
        Dim sw As StreamWriter
        sw = File.CreateText("printfile.bat")
        sw.WriteLine("@echo off")
        sw.WriteLine("pause")
        sw.WriteLine("type %* > prn")
        sw.WriteLine("type %* >>b.txt")
        sw.WriteLine("exit")
        sw.Close()
    End Sub
    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim procList() As Process = Process.GetProcesses()
        'Dim i As Integer
        'For i = 0 To procList.Length - 1
        '    Dim strProcName As String = procList(i).ProcessName
        '    Dim iProcID As Integer = procList(i).Id
        '    'MsgBox(strProcName)
        '    If strProcName = "PhoenixGroups" Then
        '        'MsgBox ("Progra")
        '        Me.Close()
        '    End If
        'Next
        createBatchFile()
        Try
            If System.IO.File.Exists("Config_ERP.txt") Then
                Dim fs As New FileStream("Config_ERP.txt", FileMode.Open, FileAccess.Read)
                Dim sr As New StreamReader(fs)
                While sr.Peek() > -1
                    GMod.Connstr = EncryptionStr(sr.ReadLine.ToString, False)
                End While
                sr.Close()
                SqlConn.ConnectionString = GMod.Connstr
                'If GMod.SqlConn.State = ConnectionState.Closed Then
                GMod.SqlConn.Open()
                'End If
            ElseIf System.IO.File.Exists("c:\Config_ERP.txt") Then
                Dim fs1 As New FileStream("c:\Config_ERP.txt", FileMode.Open, FileAccess.Read)
                Dim sr1 As New StreamReader(fs1)
                While sr1.Peek() > -1
                    GMod.Connstr = EncryptionStr(sr1.ReadLine.ToString, False)
                End While
                sr1.Close()
                'SqlConn.ConnectionString = GMod.Connstr
                GMod.SqlConn.Open()
            Else
                frmServerdetection.ShowDialog()
                Exit Sub
            End If
        Catch ex As Exception
            frmServerdetection.ShowDialog()
            Exit Sub
        End Try
        FillSession()

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Try
            'GMod.DataSetRet("select nofd from nofd", "nofd")
            'GMod.nofd = GMod.ds.Tables("nofd").Rows(0)(0)
            GMod.Session = cmbSession.Text

            If GMod.Session = "" Then
                Me.Close()
            Else
                GMod.Session = cmbSession.Text
                GMod.DataSetRet("select nofd from nofd_session2 where session ='" & GMod.Session & "'", "nofd")
                GMod.nofd = GMod.ds.Tables("nofd").Rows(0)(0)
                'MsgBox(GMod.nofd)

                GMod.DataSetRet("select entry_status,noofdays from SessionMaster where Uname ='" & Trim(txtuname.Text) & "' and session ='" & GMod.Session & "'", "entry_status")
                GMod.EntryStatus = CInt(GMod.ds.Tables("entry_status").Rows(0)(0))
                GMod.nofd = CInt(GMod.ds.Tables("entry_status").Rows(0)(1))
                MsgBox(GMod.ds.Tables("entry_status").Rows(0)(1))


            End If
            ' GMod.nofd = 365
            'Setting Session Start and End Date
            GMod.SessionStartDate = CDate("4/1/" & GMod.Session.Substring(0, 2))
            GMod.SessionEndDate = CDate("3/31/" & GMod.Session.Substring(2, 2))
            ' MessageBox.Show(GMod.SessionStartDate + "  " + GMod.SessionEndDate)
            GMod.DataSetRet("select getdate()", "getserverdate")
            'MsgBox(GMod.ds.Tables("getserverdate").Rows(0)(0))
            'MessageBox.Show(GMod.Getsession(CDate(GMod.ds.Tables("getserverdate").Rows(0)(0))))
            If GMod.Getsession(CDate(GMod.ds.Tables("getserverdate").Rows(0)(0))) = GMod.Session Then
                GMod.SessionCurrentDate = CDate(GMod.ds.Tables("getserverdate").Rows(0)(0))
                GMod.PerviousSession = False
                GMod.PrevSession = GMod.GetPrevsiousSession(CDate(GMod.ds.Tables("getserverdate").Rows(0)(0)))
            Else
                GMod.SessionCurrentDate = GMod.SessionEndDate
                GMod.PerviousSession = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try

        Dim rl As String
        Try
            Dim sqllogin As String
            sqllogin = "select role,dept,isnull(staff,0) staff from Usertab3 where uname='" & txtuname.Text & "' and cast(Pwd as varchar(50)) = '" & txtpwd.Text & "'"
            GMod.DataSetRet(sqllogin, "isexists")
            If GMod.ds.Tables("isexists").Rows.Count > 0 Then

                rl = GMod.ds.Tables("isexists").Rows(0)(0)
                GMod.Cmpid = cmbcmpid.Text
                GMod.Cmpname = cmbcmpname.Text
                GMod.role = GMod.ds.Tables("isexists").Rows(0)(0).ToString()
                GMod.username = txtuname.Text
                GMod.Dept = Val(GMod.ds.Tables("isexists").Rows(0)(1).ToString())
                ' GMod.Session = GMod.Getsession(dtCurrDate.Value)
                GMod.Session = cmbSession.Text
                'MsgBox(GMod.Session)
                GMod.staff1 = GMod.ds.Tables("isexists").Rows(0)("staff")

                Try
                    'getting ip address
                    Dim comname As String
                    Dim ipad As String
                    comname = System.Net.Dns.GetHostName()
                    ipad = System.Net.Dns.GetHostAddresses(comname)(0).ToString

                    'Inserting into User Status
                    sqllogin = "insert into UserStatus (uname, ipadd, login, status) values ("
                    sqllogin &= "'" & GMod.username & "',"
                    sqllogin &= "'" & ipad & "',"
                    sqllogin &= "'" & Now & "',"
                    sqllogin &= "'1')"
                    GMod.SqlExecuteNonQuery(sqllogin)
                Catch ex As Exception
                    Application.Exit()

                End Try


                Try

                    'Checking for already login
                    GMod.DataSetRet("select getdate()", "getserverdate")
                    sqllogin = "select login from UserStatus where uname='" & GMod.username & "'"
                    GMod.DataSetRet(sqllogin, "chck")
                    Dim n As Integer
                    n = DateDiff(DateInterval.Minute, GMod.ds.Tables("getserverdate").Rows(0)(0), GMod.ds.Tables("chck").Rows(0)(0))
                    'MsgBox(n)
                    'MsgBox(GMod.ds.Tables("getserverdate").Rows(0)(0))
                    'MsgBox(GMod.ds.Tables("chck").Rows(0)(0))

                    If Math.Abs(n) > 0 Then
                        GMod.DataSetRet("select getdate()", "serverdate")
                        Dim sql As String
                        sql = "update UserStatus set login='" & CDate(GMod.ds.Tables("serverdate").Rows(0)(0)) & "' where uname='" & GMod.username & "'"
                        GMod.SqlExecuteNonQuery(sql)
                    Else
                        MsgBox("User Already Loged In!!,Please wait", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Application.Exit()
                End Try

                'getting table name
                GettingTableName()
                Dim frmmdiobj As New frmMDI
                If rl = "OPERATOR" Then

                    If GMod.Dept = 0 Then
                        'sale 
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = True
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = True
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = True
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = True

                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = False

                        frmmdiobj.BankToolStripMenuItem.Enabled = False
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = False
                        '
                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = False

                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = False
                        frmmdiobj.SaleProductWiseToolStripMenuItem.Enabled = True
                        frmmdiobj.FinishedProductLedgerToolStripMenuItem.Enabled = True


                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = True
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = True
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = True
                        frmmdiobj.OtherSaleToolStripMenuItem.Enabled = True
                        frmmdiobj.ReceiptToolStripMenuItem1.Enabled = True
                    ElseIf GMod.Dept = 1 Then
                        'purchase

                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False


                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = True
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = True
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = True
                        frmmdiobj.TDSEntryToolStripMenuItem.Enabled = True

                        frmmdiobj.BankToolStripMenuItem.Enabled = False
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = False


                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = False

                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = False

                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = True
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = True
                        frmmdiobj.PurchaseSummaryToolStripMenuItem.Visible = True



                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = False
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherSaleToolStripMenuItem.Enabled = False
                        frmmdiobj.ReceiptToolStripMenuItem1.Enabled = False

                    ElseIf GMod.Dept = 3 Then
                        'bank
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False


                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = False

                        frmmdiobj.BankToolStripMenuItem.Enabled = True
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = True


                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = False

                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = False


                        frmmdiobj.TdsEntryToolStripMenuItem2.Visible = True


                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = False
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherSaleToolStripMenuItem.Enabled = False
                        frmmdiobj.ReceiptToolStripMenuItem1.Enabled = False

                    ElseIf GMod.Dept = 2 Then
                        'expenses
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False


                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = False

                        frmmdiobj.BankToolStripMenuItem.Enabled = False
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = False


                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = True
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = True
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = True
                        frmmdiobj.TDSEntryToolStripMenuItem1.Enabled = True


                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = False


                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = False
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = False


                    ElseIf GMod.Dept = 4 Then
                        'cash counter

                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False


                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = False

                        frmmdiobj.BankToolStripMenuItem.Enabled = False
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = False


                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = False

                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = True
                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = True
                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = False


                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = False
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherSaleToolStripMenuItem.Enabled = False
                        frmmdiobj.ReceiptToolStripMenuItem1.Enabled = True
                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = True

                    End If
                    'frmmdiobj.MasterEntriesToolStripMenuItem.Enabled = False
                    frmmdiobj.ChequeToolStripMenuItem.Enabled = False
                    frmmdiobj.tstrpassgincmp.Enabled = False
                    frmmdiobj.tstrpcmpinfo.Enabled = False
                    frmmdiobj.tstrpusermgt.Enabled = False
                    frmmdiobj.MisReporToolStripMenuItem.Enabled = False
                    'frmmdiobj.ToolStripMenuItem19.Enabled = False
                    frmmdiobj.transfer.Enabled = False
                    frmmdiobj.ToolStripMenuItem19.Enabled = False
                ElseIf rl = "VIEWER" Then
                    frmmdiobj.MasterEntriesToolStripMenuItem.Enabled = False
                    frmmdiobj.ChequeToolStripMenuItem.Enabled = False
                    frmmdiobj.TranseectionToolStripMenuItem.Enabled = False
                    frmmdiobj.DisplayPrintToolStripMenuItem.Enabled = False
                    frmmdiobj.ToolsToolStripMenuItem.Enabled = False
                    frmmdiobj.MisReporToolStripMenuItem.Enabled = False
                    frmmdiobj.VoucherSToolStripMenuItem.Enabled = True

                ElseIf rl = "LIMITED" Then

                    frmmdiobj.MasterEntriesToolStripMenuItem.Enabled = False
                    frmmdiobj.ChequeToolStripMenuItem.Enabled = False
                    frmmdiobj.TranseectionToolStripMenuItem.Enabled = False
                    frmmdiobj.DisplayPrintToolStripMenuItem.Enabled = False
                    frmmdiobj.ToolsToolStripMenuItem.Enabled = False
                    frmmdiobj.TrialToolStripMenuItem.Enabled = True
                    frmmdiobj.ToolStripMenuItem21.Enabled = False
                    frmmdiobj.MisReporToolStripMenuItem.Enabled = False
                    frmmdiobj.ToolStripMenuItem28.Enabled = False
                    frmmdiobj.ToolStripMenuItem29.Enabled = False

                ElseIf rl = "VIEWER LEVEL-1" Then

                    frmmdiobj.MasterEntriesToolStripMenuItem.Enabled = True
                    frmmdiobj.ChequeToolStripMenuItem.Enabled = False
                    frmmdiobj.TranseectionToolStripMenuItem.Enabled = False
                    frmmdiobj.ToolsToolStripMenuItem.Enabled = False
                    frmmdiobj.MisReporToolStripMenuItem.Enabled = False


                    frmmdiobj.ReceiptToolStripMenuItem.Enabled = True
                    frmmdiobj.CrDebitToolStripMenuItem.Enabled = True
                    frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = True
                    frmmdiobj.PurchaseSummaryToolStripMenuItem.Visible = True

                    If GMod.Dept = 0 Then
                        'sale 
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = True
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = True
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = True
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = True

                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = False

                        frmmdiobj.BankToolStripMenuItem.Enabled = False
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = False


                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = False

                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = False
                        frmmdiobj.SaleProductWiseToolStripMenuItem.Enabled = True
                        frmmdiobj.FinishedProductLedgerToolStripMenuItem.Enabled = True


                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = True
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = True
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = True
                        frmmdiobj.OtherSaleToolStripMenuItem.Enabled = True
                        frmmdiobj.ReceiptToolStripMenuItem1.Enabled = True
                    ElseIf GMod.Dept = 1 Then
                        'purchase

                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False


                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = True
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = True
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = True
                        frmmdiobj.TDSEntryToolStripMenuItem.Enabled = True

                        frmmdiobj.BankToolStripMenuItem.Enabled = False
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = False


                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = False

                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = False

                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = True
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = True
                        frmmdiobj.PurchaseSummaryToolStripMenuItem.Visible = True

                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = False
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherSaleToolStripMenuItem.Enabled = False
                        frmmdiobj.ReceiptToolStripMenuItem1.Enabled = False

                    ElseIf GMod.Dept = 3 Then
                        'bank
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False


                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = False

                        frmmdiobj.BankToolStripMenuItem.Enabled = True
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = True

                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = False

                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = False


                        frmmdiobj.TdsEntryToolStripMenuItem2.Visible = True

                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = False
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherSaleToolStripMenuItem.Enabled = False
                        frmmdiobj.ReceiptToolStripMenuItem1.Enabled = False

                    ElseIf GMod.Dept = 2 Then
                        'expenses

                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False


                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = False

                        frmmdiobj.BankToolStripMenuItem.Enabled = False
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = False


                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = True
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = True
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = True
                        frmmdiobj.TDSEntryToolStripMenuItem1.Enabled = True


                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = False

                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = False
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherSaleToolStripMenuItem.Enabled = False
                        frmmdiobj.ReceiptToolStripMenuItem1.Enabled = False


                    ElseIf GMod.Dept = 4 Then
                        'cash counter

                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem2.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem3.Enabled = False
                        frmmdiobj.SaleToolStripMenuItem1.Enabled = False


                        frmmdiobj.PurchaseToolStripMenuItem1.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem2.Enabled = False
                        frmmdiobj.PurchaseToolStripMenuItem3.Enabled = False

                        frmmdiobj.BankToolStripMenuItem.Enabled = False
                        frmmdiobj.PaymnetOthersToolStripMenuItem.Enabled = False


                        frmmdiobj.ExpensesToolStripMenuItem.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem1.Enabled = False
                        frmmdiobj.ExpensesToolStripMenuItem2.Enabled = False

                        frmmdiobj.CashCounterToolStripMenuItem.Enabled = True
                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = True
                        frmmdiobj.JournalPurchaseToolStripMenuItem.Enabled = False
                        frmmdiobj.JournalPurchaseRegisterToolStripMenuItem.Enabled = False

                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = False
                        frmmdiobj.CrDebitToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = False
                        frmmdiobj.OtherSaleToolStripMenuItem.Enabled = False
                        frmmdiobj.ReceiptToolStripMenuItem1.Enabled = True
                        frmmdiobj.ReceiptToolStripMenuItem.Enabled = True
                    End If
                    frmmdiobj.ChqLayoutToolStripMenuItem.Visible = False


                ElseIf rl = "MIS" Then
                ElseIf rl = "ADMIN" Then
                    frmmdiobj.ChqLayoutToolStripMenuItem.Visible = True
                    frmmdiobj.FinishedProductLedgerToolStripMenuItem.Enabled = True
                    CreateTables() 'Creating table Only Administrator Righit
                    frmmdiobj.PurchaseSummaryToolStripMenuItem.Visible = True
                    frmmdiobj.TdsEntryToolStripMenuItem2.Visible = True


                    frmmdiobj.ReceiptToolStripMenuItem.Enabled = True
                    frmmdiobj.CrDebitToolStripMenuItem.Enabled = True
                    frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = True


                    frmmdiobj.ReceiptToolStripMenuItem.Enabled = True
                    frmmdiobj.CrDebitToolStripMenuItem.Enabled = True
                    frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = True

                    frmmdiobj.ReceiptToolStripMenuItem.Enabled = True
                    frmmdiobj.CrDebitToolStripMenuItem.Enabled = True
                    frmmdiobj.OtherDetectionVoucherEntryToolStripMenuItem.Enabled = True
                    frmmdiobj.OtherSaleToolStripMenuItem.Enabled = True
                    frmmdiobj.ReceiptToolStripMenuItem1.Enabled = True
                End If
                frmmdiobj.Text = GMod.Cmpname
                Me.Hide()
                frmmdiobj.ShowDialog()
            Else
                MsgBox("Password doesn't match", MsgBoxStyle.Critical)
                txtpwd.Text = ""
                txtpwd.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Hide()
            frmServerdetection.ShowDialog()
        End Try


    End Sub

    Private Sub txtuname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuname.KeyDown
        If e.KeyCode = Keys.Enter Then cmbcmpname.Focus()
    End Sub
    Private Sub txtuname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuname.Leave
        Try
            Dim sqlselect As String
            sqlselect = "select * from Usertab3 where uname='" & txtuname.Text & "'"
            GMod.DataSetRet(sqlselect, "checkuser")
            If GMod.ds.Tables("checkuser").Rows.Count > 0 Then
                sqlselect = "select cam.Cmp_id,Cmpname from Cmp_assignment cam "
                sqlselect &= "inner join Company cmp  on cam.Cmp_id=cmp.Cmp_id where Uname='" & txtuname.Text & "'"
                GMod.DataSetRet(sqlselect, "usercompany")
                cmbcmpname.DataSource = GMod.ds.Tables("usercompany")
                cmbcmpname.DisplayMember = "Cmpname"
                cmbcmpid.DataSource = GMod.ds.Tables("usercompany")
                cmbcmpid.DisplayMember = "Cmp_id"
            Else
                MsgBox("User name doesn't exists", MsgBoxStyle.Critical)
                txtuname.Text = ""
                txtuname.Focus()
            End If
        Catch ex As Exception
            frmServerdetection.Show()
            Me.Hide()
        End Try

        'select * from SessionMaster order by id desc
        GMod.DataSetRet("select * from SessionMaster  where uname='" & txtuname.Text & "' order by SessionId desc", "SessionMaster")
        cmbSession.DataSource = GMod.ds.Tables("SessionMaster")
        cmbSession.DisplayMember = "session"



    End Sub
    Dim tablename As String, createtablesql As String, sqlresult As String
    Private Sub GettingTableName()
        tablename = "ACC_HEAD" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.ACC_HEAD = tablename

        tablename = "CHQBOOK" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.CHQBOOK = tablename

        tablename = "VENTRY" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.VENTRY = tablename

        tablename = "CHQ_ALLOT" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.CHQ_ALLOT = tablename

        tablename = "CHQ_ISSUED" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.CHQ_ISSUED = tablename

        tablename = "BANK_STATE" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.BANK_STATE = tablename

        tablename = "BANK_STATE_OPEN" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.BANK_STATE_OPEN = tablename

        'For inventory 
        tablename = "INVINFO" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.INVENTORY = tablename


    End Sub

    Private Sub CreateTables() 'Creating Tables Only ADMIN right
        'in this tha tables are created according to cmoid and session 
        'we are braking the table on the basis of company and session 

        'Greating table for account head
        ' Note: We break the table on the basis of  company and session and the initial table name will be stored in the database.
        'Eg: Company Name – Raga Finvest Pvt Ltd. (Code: RAFI)
        'Session 2007-2008 : 0708 
        'For GroupName  GroupInfo(Code)
        'Then table name will be :- GroupInfoRAFI0708


        tablename = "ACC_HEAD" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & tablename & "'", "tableaccount")
        GMod.ACC_HEAD = tablename
        If GMod.ds.Tables("tableaccount").Rows.Count = 0 Then
            createtablesql = "CREATE TABLE " & tablename & "(" _
                             & "[Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-') ," _
                             & "[account_code] [varchar](18)  NOT NULL DEFAULT ('-') primary key," _
                             & "[account_head_name] [varchar](50)  NOT NULL DEFAULT ('-')," _
                             & "[group_name] [varchar](40)  NOT NULL DEFAULT ('-') ," _
                             & "[sub_group_name] [varchar](60)  NOT NULL DEFAULT ('-') ," _
                             & "[credit_days] [varchar](50)  NOT NULL DEFAULT ('-')," _
                             & "[credit_limit] [varchar](50) NOT NULL DEFAULT ('-')," _
                             & "[opening_dr] [numeric](18, 2) NOT NULL DEFAULT ((0))," _
                             & "[opening_cr] [numeric](18, 2) NOT NULL   DEFAULT ((0))," _
                             & "[account_type] [varchar](50) NOT NULL DEFAULT ('-')," _
                             & "[address] [varchar](100) NOT NULL  DEFAULT ('-'), " _
                             & "[city] [varchar](30) NOT NULL DEFAULT ('-')," _
                             & "[state] [varchar](30) NOT NULL  DEFAULT ('-')," _
                             & "[phone] [varchar](20) NOT NULL DEFAULT ('-')," _
                             & "[pan_no] [varchar](20)  NOT NULL DEFAULT ('-')," _
                             & "[rate_of_interest] [varchar](50) NOT NULL  DEFAULT ('-')," _
                             & "[interest_rule_id] [varchar](50)  DEFAULT ('-')," _
                             & "[Area_code] [Varchar](2)  DEFAULT ('-')," _
                             & "[remark1] [varchar](100) NOT NULL DEFAULT ('-')," _
                             & "[remark2] [varchar](100) NOT NULL DEFAULT ('-')," _
                             & "[remark3] [varchar](100) NOT NULL  DEFAULT ('-') ) "
            sqlresult = GMod.SqlExecuteNonQuery(createtablesql)
        End If
        tablename = "CHQBOOK" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & tablename & "'", "tableaccount")
        GMod.CHQBOOK = tablename
        If GMod.ds.Tables("tableaccount").Rows.Count = 0 Then
            createtablesql = "CREATE TABLE " & tablename & "(" _
                                & "[Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-') ," _
                                & "[Uname]  [varchar](15)  NOT NULL DEFAULT ('-') ," _
                                & "[Entry_id]  [numeric](8)  NOT NULL DEFAULT ((0)) ," _
                                & "[Entry_date]  [Datetime] NOT NULL ," _
                                & "[Acc_head_code] [varchar](18)  NOT NULL DEFAULT ('-') ," _
                                & "[Acc_head] [varchar](50)  NOT NULL DEFAULT ('-') ," _
                                & "[Book_no] [varchar](30)  NOT NULL DEFAULT ('-') ," _
                                & "[Cheque_no_from] [varchar](15) NOT NULL  DEFAULT ('-')," _
                                & "[Cheque_no_to] [varchar](15) NOT NULL  DEFAULT ('-')," _
                                & "[isavailable] [varchar](1) NOT NULL DEFAULT ('-'))"
            'sqlresult = GMod.SqlExecuteNonQuery(createtablesql)
        End If

        tablename = "VENTRY" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & tablename & "'", "tableaccount")
        GMod.VENTRY = tablename
        If GMod.ds.Tables("tableaccount").Rows.Count = 0 Then
            createtablesql = "CREATE TABLE " & tablename & "(" _
                                & "[Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-') ," _
                                & "[Uname]  [varchar](15)  NOT NULL DEFAULT ('-') ," _
                                & "[Entry_id]  [numeric](18,2)  NOT NULL DEFAULT ((0)) ," _
                                & "[Vou_no] [varchar](12)  NOT NULL DEFAULT ('-') ," _
                                & "[Vou_type] [varchar](20)  NOT NULL DEFAULT ('-')," _
                                & "[Vou_date] [Datetime] NOT NULL ," _
                                & "[Acc_head_code] [varchar](18)  NOT NULL DEFAULT ('-') ," _
                                & "[Acc_head] [varchar](50)  NOT NULL DEFAULT ('-') ," _
                                & "[dramt] [numeric](18, 2)  NOT NULL DEFAULT ((0))," _
                                & "[cramt] [numeric](18, 2) NOT NULL DEFAULT ((0))," _
                                & "[Pay_mode] [varchar](20) NOT NULL DEFAULT ('-')," _
                                & "[Cheque_no] [varchar](15) NOT NULL  DEFAULT ('-'), " _
                                & "[Narration] [varchar](180) NOT NULL DEFAULT ('-')," _
                                & "[Group_name] [varchar](40) NOT NULL  DEFAULT ('-')," _
                                & "[Sub_group_name] [varchar](60) NOT NULL DEFAULT ('-')," _
                                & "[Ch_issue_date] [Datetime]  NULL," _
                                & "[Ch_date] [Datetime]  NULL, " _
                                & "[id] [bigint] IDENTITY(1,1) NOT NULL," _
                                & "[VoucherTax] [varchar](50) NULL," _
                                & "[TaxPer] [numeric](18, 2) NULL," _
                                & "[TaxType] [varchar](50) NULL, " _
                                & "[WinOut] [varchar](50) NULL ," _
                                & "[exp_date] [Datetime]  NULL, " _
                                & "[item_name] [varchar](50)  NULL) "
            sqlresult = GMod.SqlExecuteNonQuery(createtablesql)
        End If
        'For Tigger
        createtablesql = "create TRIGGER trdel_" & GMod.Cmpid & "_" & GMod.Session & " ON " & GMod.VENTRY & " for DELETE,update AS " _
        & " BEGIN " _
        & " declare @update_userid varchar(20) " _
        & " select @update_userid=Uname from inserted " _
        & " insert into ventrytrgg (Cmp_id, Uname, Entry_id, " _
        & "Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,  " _
        & "cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, " _
        & "Ch_issue_date, Ch_date, Update_date, Un) " _
        & "select Cmp_id, Uname, Entry_id, " _
        & "Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, " _
        & "cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, " _
        & "Ch_issue_date, Ch_date ,getdate(),@update_userid from deleted " _
        & " End "
        sqlresult = GMod.SqlExecuteNonQuery(createtablesql)


        tablename = "CHQ_ALLOT" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & tablename & "'", "tableaccount")
        GMod.CHQ_ALLOT = tablename
        If GMod.ds.Tables("tableaccount").Rows.Count = 0 Then
            createtablesql = "CREATE TABLE " & tablename & "(" _
                                            & "[Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-') ," _
                                            & "[U_name] [varchar](15)  NOT NULL DEFAULT ('-') ," _
                                            & "[Bank_acc_head] [varchar](50)  NOT NULL DEFAULT ('-')," _
                                            & "[Book_No] [varchar](10)  NOT NULL DEFAULT ('-')," _
                                            & "[Ch_no_from] [varchar](15)  NOT NULL DEFAULT ('-') ," _
                                            & "[Ch_no_to] [varchar](15) NOT NULL  DEFAULT ('-'), " _
                                            & "[Ch_allot_date] [Datetime] NOT NULL  , " _
                                            & "[last_che] [varchar](15) NOT NULL  DEFAULT ('-') ," _
                                            & "[Chq_remain] [int] NOT NULL  primary key(U_name,Ch_no_from,Ch_no_to))"

            'sqlresult = GMod.SqlExecuteNonQuery(createtablesql)
        End If
        tablename = "CHQ_ISSUED" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & tablename & "'", "tableaccount")
        GMod.CHQ_ISSUED = tablename
        If GMod.ds.Tables("tableaccount").Rows.Count = 0 Then
            createtablesql = "CREATE TABLE " & tablename & "(" _
                                 & "[Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-') ," _
                                 & "[Receipt_id] [varchar](12)  NOT NULL DEFAULT ('-') ," _
                                 & "[Issue_date] [Datetime]  NOT NULL ," _
                                 & "[Chq_date] [Datetime]  NOT NULL ," _
                                 & "[Cheque_no] [varchar](15)  NOT NULL DEFAULT ('-') ," _
                                 & "[BankAcc_code] [Varchar](18)  NOT NULL DEFAULT ('-')," _
                                 & "[Amount] [numeric](18, 2) NOT NULL DEFAULT ((0))," _
                                 & "[Dd_Charge_per] [numeric](6, 2) NOT NULL DEFAULT ((0))," _
                                 & "[Dd_charge] [numeric](10, 2) NOT NULL   DEFAULT ((0))," _
                                 & "[Service_tax] [numeric](10, 2) NOT NULL  DEFAULT ((0))," _
                                 & "[Receipt_amt] [numeric](18, 2)  DEFAULT ((0))," _
                                 & "[party_code] [varchar](8) NOT NULL  DEFAULT ('-')," _
                                 & "[party_name] [varchar](50) NOT NULL  DEFAULT ('-')," _
                                 & "[final_date] [datetime]," _
                                 & "[favourof] [varchar](100)," _
                                 & "[vouno] [varchar](12)," _
                                 & "[stop_bounce] [varchar](1) NOT NULL  DEFAULT ('F') ,  " _
                                 & "[Rect_type] [varchar](10) NOT NULL  DEFAULT ('-') ,  " _
                                 & "[Remark] [varchar](50) NOT NULL  DEFAULT ('-') ,  " _
                                 & "[IsPrinted] [varchar](1) NOT NULL  DEFAULT ('N')  primary key (Cheque_no,BankAcc_code)) "
            'sqlresult = GMod.SqlExecuteNonQuery(createtablesql)
        End If
        'Creating bank statement table
        tablename = "BANK_STATE" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & tablename & "'", "tableaccount")
        GMod.BANK_STATE = tablename
        If GMod.ds.Tables("tableaccount").Rows.Count = 0 Then
            createtablesql = "CREATE TABLE " & tablename & "(" _
                                 & "[Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-')," _
                                 & "[Entryid] [bigint] null," _
                                 & "[bank_acc_code] [varchar](8)  NOT NULL DEFAULT ('-')," _
                                 & "[bankedate] [datetime] NULL," _
                                 & "[paytype] [varchar](15) NULL," _
                                 & "[detail] [varchar](50) NULL," _
                                 & "[chddno] [varchar](15) NULL," _
                                 & "[dramt] [numeric](18, 2) NULL," _
                                 & "[cramt] [numeric](18, 2) NULL ," _
                                 & "[IssueDate] [Datetime] )"
            'sqlresult = GMod.SqlExecuteNonQuery(createtablesql)
        End If
        tablename = "BANK_STATE_OPEN" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & tablename & "'", "tableaccount")
        GMod.BANK_STATE_OPEN = tablename
        If GMod.ds.Tables("tableaccount").Rows.Count = 0 Then
            createtablesql = "CREATE TABLE " & tablename & "(" _
                                 & "[bank_acc_code] [varchar](8)  NOT NULL DEFAULT ('-')," _
                                 & "[dramt] [numeric](18, 2) NULL," _
                                 & "[cramt] [numeric](18, 2) NULL )"
            'sqlresult = GMod.SqlExecuteNonQuery(createtablesql)
        End If
        'For inventory 
        tablename = "INVINFO" & "_" & GMod.Cmpid & "_" & GMod.Session
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & tablename & "'", "tableaccount")
        GMod.INVENTORY = tablename
        If GMod.ds.Tables("tableaccount").Rows.Count = 0 Then
            createtablesql = "CREATE TABLE " & tablename & "(" _
                                & "[Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-') ," _
                                & "[Uname]  [varchar](15)  NOT NULL DEFAULT ('-') ," _
                                & "[Vou_no] [varchar](12)  NOT NULL DEFAULT ('-') ," _
                                & "[Vou_type] [varchar](20)  NOT NULL DEFAULT ('-')," _
                                & "[Vou_date] [Datetime] NOT NULL ," _
                                & "[Acc_head_code] [varchar](18)  NOT NULL DEFAULT ('-') ," _
                                & "[Acc_head] [varchar](50)  NOT NULL DEFAULT ('-') ," _
                                & "[ItemName] [varchar](30) NOT NULL DEFAULT ('-')," _
                                & "[Qty] [numeric](18,2) NOT NULL  DEFAULT ((0)), " _
                                & "[QtyNos] [numeric](18,2) NOT NULL  DEFAULT ((0)), " _
                                & "[Unit] [varchar](10) NOT NULL DEFAULT ('-')," _
                                & "[Rate] [numeric](18,2) NOT NULL  DEFAULT ((0)), " _
                                & "[Amount] [numeric](18,2) NOT NULL  DEFAULT ((0)), " _
                                & "[Free_Qty] [numeric](6,2) NOT NULL  DEFAULT ((0)), " _
                                & "[BillType] [varchar](10)  NULL," _
                                & "[BillNo] [varchar](10)  NULL," _
                                & "[BillDate] [Datetime]  NULL ," _
                                & "[AreaCode] [varchar](2)  NULL ," _
                                & "[Free_Per] [numeric](6,2)  NULL, " _
                                & "[Hatch_date] [Datetime]  NULL )"

            'sqlresult = GMod.SqlExecuteNonQuery(createtablesql)
        End If
        GMod.ds.Tables("tableaccount").Dispose()
        CreateTableDayBook()
    End Sub
    Private Sub txtpwd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpwd.KeyDown
        If e.KeyCode = Keys.Enter Then cmbSession.Focus()
    End Sub
    Private Sub cmbcmpname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcmpname.KeyDown
        If e.KeyCode = Keys.Enter Then txtpwd.Focus()
    End Sub

    Public Sub CreateTableDayBook()
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='Daybook'", "tableaccountbook")
        If GMod.ds.Tables("tableaccountbook").Rows.Count = 0 Then
            Dim daybook As String
            daybook = "CREATE TABLE [Daybook](" _
            & " [cmpid] [varchar](4), " _
            & "[Acc_code] [varchar](18)," _
            & "[Acc_name] [varchar](40), " _
            & "[narration] [varchar](500)," _
            & "[Group_name] [varchar](40), " _
            & "[Sub_Group] [varchar](40)," _
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CLS As New Module1.Num2Words
        MsgBox(CLS.NUMMM(InputBox("Nm")))
    End Sub

    Private Sub cmbSession_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSession.KeyDown
        If e.KeyCode = Keys.Enter Then btnlogin_Click(sender, e)
    End Sub

    Private Sub cmbSession_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSession.Leave
        If cmbSession.Text = "" Then
            MsgBox("Please Select session ")
            cmbSession.Focus()
            btnlogin.Enabled = False
        Else
            btnlogin.Enabled = True
        End If
    End Sub
    Private Sub cmbcmpname_Leave(sender As Object, e As EventArgs) Handles cmbcmpname.Leave
        cmbSession.SelectedIndex = 0
    End Sub

   
    Private Sub txtuname_TextChanged(sender As Object, e As EventArgs) Handles txtuname.TextChanged

    End Sub
End Class
