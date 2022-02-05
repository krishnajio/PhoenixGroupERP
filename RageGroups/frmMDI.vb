Imports System.IO
Imports System.Data.SqlClient
Public Class frmMDI

    Private Sub CompanyInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstrpcmpinfo.Click
        Dim frmcompanyobj As New frmcomp
        frmcomp.ShowDialog()
    End Sub
    Private Sub BankStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bankstatementobj As New frmBankState2
        bankstatementobj.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub AssigneCompanyToUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstrpassgincmp.Click
        If GMod.role = "ADMIN" Then
            Dim t As New frmUserassignment
            t.ShowDialog()
        End If
    End Sub


    Private Sub tstrpusermgt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstrpusermgt.Click
        Dim t As New frmusermgt
        t.ShowDialog()
    End Sub

    Private Sub strpgroupmgt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles strpgroupmgt.Click
        Dim t As New frmgroups
        t.ShowDialog()
    End Sub

    Private Sub frmMDI_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        GMod.ds.Dispose()
        Dim st() As String
        GMod.SqlExecuteNonQuery("drop table Daybook")
        Dim sql As String
        GMod.DataSetRet("select getdate()", "serverlogout")

        sql = "update UserStatus set login ='" & CDate(GMod.ds.Tables("serverlogout").Rows(0)(0)).AddMinutes(-1) & "',status =0 where uname='" & GMod.username & "'"
        GMod.SqlExecuteNonQuery(sql)
        GMod.SqlConn.Close()
        GMod.SqlConn.Dispose()

        st = Environment.SystemDirectory.ToUpper.Split("\")
        'DOCUME~1\krishna\LOCALS~1\Temp
        st(1) = st(0) & "\" & "DOCUME~1\" & Environment.UserName & "\LOCALS~1\Temp"
        'MsgBox(st(1))



        Dim names As String() = Directory.GetFiles(st(1))

        'now loop through all the files and delete them

        For Each file As String In names

            Try
                System.IO.File.Delete(file)
            Catch ex As Exception
            End Try
        Next

        Try
            System.IO.Directory.Delete(st(1), True)
        Catch ex As Exception

        End Try
        GMod.SqlConn.Close()
        Name = Nothing
        st = Nothing
        Application.Exit()
    End Sub

    Private Sub tstrpnarrationmaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstrpnarrationmaster.Click
        Dim t As New frmNarration
        t.ShowDialog()
    End Sub

    Private Sub tstrpsubgroupmgt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstrpsubgroupmgt.Click
        Dim t As New frmsubgroup
        t.ShowDialog()
    End Sub

    Private Sub tstrpintrules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstrpintrules.Click
        Dim t As New frmInterest
        t.ShowDialog()
    End Sub

    Private Sub tstropartyhead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstropartyhead.Click
        Try
            Dim t As New frmPartyaccount
            Dim sql As String
            sql = "select Group_name,Suffix from Groups where Group_name like '%PART%' and Cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'"
            GMod.DataSetRet(sql, "Suffix")

            t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupname.DisplayMember = "Group_name"

            t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
            t.lblgroupsuffix.DisplayMember = "Suffix"


            t.lblgroupsuffix.Text = "PA"
            t.Label1.Text = "Party Account Heads"
            t.ShowDialog()
        Catch ez As Exception

        End Try
    End Sub

    Private Sub tstrpgeneralacchead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstrpgeneralacchead.Click
        If GMod.Cmpid = "PHOE" Then
            'If GMod.Session = "1819" Then
            '    Dim t As New frmGeneralacchead_New
            '    t.ShowDialog()
            'Else
            '    Dim t As New frmGeneralacchead
            '    t.ShowDialog()
            'End If
            Dim t As New frmGeneralacchead_New
            t.ShowDialog()
        Else
            Dim t As New frmGeneralacchead
            t.ShowDialog()
        End If
    End Sub
    Dim sqlvouseq As String
    Private Sub ReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmVentry
        t.cmbvtype.Text = "RECEIPT"
        t.cmbvtype.Enabled = False
        t.Label1.Text = t.Label1.Text & "- RECEIPT"
        sqlvouseq = "select Vou_no_seq from Vtype where vtype='RECEIPT'"
        GMod.DataSetRet(sqlvouseq, "Vou_seq")
        t.lblvouseq.Text = GMod.ds.Tables("Vou_seq").Rows(0)(0)
        t.ShowDialog()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmVentry
        t.cmbvtype.Text = "PAYMENT"
        t.Label1.Text = t.Label1.Text & "- PAYMENT"
        t.cmbvtype.Enabled = False
        sqlvouseq = "select Vou_no_seq from Vtype where vtype='PAYMENT'"
        GMod.DataSetRet(sqlvouseq, "Vou_seq")
        t.lblvouseq.Text = GMod.ds.Tables("Vou_seq").Rows(0)(0)
        t.ShowDialog()
    End Sub

    Private Sub JournalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmVentry
        t.cmbvtype.Text = "JOURNAL"
        t.Label1.Text = t.Label1.Text & "- JOURNAL"
        t.cmbvtype.Enabled = False
        t.cmbacheadname.Enabled = True
        t.cmbacheadname.Enabled = True
        sqlvouseq = "select Vou_no_seq from Vtype where vtype='JOURNAL'"
        GMod.DataSetRet(sqlvouseq, "Vou_seq")
        t.lblvouseq.Text = GMod.ds.Tables("Vou_seq").Rows(0)(0)
        t.ShowDialog()
    End Sub

    Private Sub OtherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmVentry
        t.Show()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmlogin
        t.ShowDialog()
    End Sub

    Private Sub customertoolstrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customertoolstrip.Click
        Dim t As New frmPartyaccount
        Dim sql As String
        sql = "select Group_name,Suffix from Groups where Group_name like '%CUSTOMER%' and Cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "Suffix")

        t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupname.DisplayMember = "Group_name"

        t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupsuffix.DisplayMember = "Suffix"

        t.Label1.Text = "Customer Account Heads"
        t.ShowDialog()
    End Sub

    Private Sub tstrpvouchermgt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstrpvouchermgt.Click
        Dim t As New frmvtype
        t.ShowDialog()
    End Sub

    Private Sub frmMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        MenuStripRagaGroup.Renderer = New CustomRenderer

        'Timer1.Start()
        'updating time 
        Me.Text = "Company : " & GMod.Cmpname & " [" & GMod.Session & "] User Name : " & GMod.username

        GMod.AreaCode = "JB"
        PictureBox1.Left = Me.Width - 120
        PictureBox1.Top = Me.Height - 90
          CrystalReportViewer1.Left = Me.Width - 120
        CrystalReportViewer1.Top = Me.Height - 90
        'Dim r As New demo
        ' CrystalReportViewer1.ReportSource = r

        If GMod.Cmpid = "PHFA" Then

        ElseIf GMod.Cmpid = "PHFA" Then

        ElseIf GMod.Cmpid = "PHOE" Then

        End If

        'GMod.DataSetRet("select getdate()", "serverdate")
        NotifyIcon1.Visible = True

        GMod.DataSetRet("select convert(varchar(50),getdate(),106)", "sdate")
        ToolStripStatusLabel1.Text = "Server Date:" & GMod.ds.Tables("sdate").Rows(0)(0).ToString

        If GMod.PerviousSession = True Then
            ToolStripStatusLabel1.ForeColor = Color.DarkRed
            ToolStripStatusLabel2.ForeColor = Color.DarkRed

            ToolStripStatusLabel1.Font = New Drawing.Font("Verdana", 12, FontStyle.Bold)
            ToolStripStatusLabel2.Font = New Drawing.Font("Verdana", 12, FontStyle.Bold)


            Label2.BringToFront()
            Label2.Font = New Drawing.Font("Verdana", 30, FontStyle.Bold Or FontStyle.Italic)
            Label2.ForeColor = Color.DarkRed
            Label2.Text = "YOU ARE IN PREVIOUS SESSION:- " & GMod.Session
        Else

        End If
        ToolStripStatusLabel2.Text = Me.Text

        ' GMod.SqlExecuteNonQuery("update up_head set acc_head_code =account_code")

        GMod.DataSetRet("select stock_val,Opn_cashDr from company where cmp_id ='" & GMod.Cmpid & "'", "othercmpCheck")
        GMod.othcmp = Val(GMod.ds.Tables("othercmpCheck").Rows(0)(0))
        If Val(GMod.ds.Tables("othercmpCheck").Rows(0)(0)) = 1.11 Or GMod.Cmpid = "PHAG" Then
            OthersToolStripMenuItem.Visible = True
            ' ToolStripMenuItem29.Visible = True
            ' BMToolStripMenuItem.Visible = True

        Else
            ' 'OthersToolStripMenuItem.Visible = False
            'ToolStripMenuItem29.Visible = False
            'BMToolStripMenuItem.Visible = False
            ' GMod.othcmp = 0.0


        End If
        ' staff = GMod.ds.Tables("othercmpCheck").Rows(0)(1)



        'If GMod.username = "salphx" Or GMod.username = "salph" Then
        'SalaryToolStripMenuItem.Visible = True
        'End If
        If (GMod.role = "VIEWER LEVEL-1" Or GMod.role.ToLower = "admin") And GMod.staff1 = 1 And GMod.Dept = 99 Then
            SalaryToolStripMenuItem.Visible = True
        End If


        'backup code
        Dim namebak As String = ""
        Dim sqlbak As String = ""
        Dim sw As StreamWriter
        namebak = "E:\\PhoenixGroup" & GMod.ds.Tables("sdate").Rows(0)(0).ToString & ""

        Dim dsBackDataSet As New DataSet
        Dim daBackUpAdp As New SqlDataAdapter("exec backupproc '" & namebak & "'", GMod.Connstr)

        daBackUpAdp.SelectCommand.CommandTimeout = 3000
        Try
            ' daBackUpAdp.Fill(dsBackDataSet)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        If GMod.role = "VIEWER LEVEL-1" Then
            TranseectionToolStripMenuItem.Enabled = True
            frmPendlingList.ShowDialog()
        End If

        If (GMod.Cmpid = "PHHA") Then
            PurchaseToolStripMenuItem4.Visible = True
            HatchToolStripMenuItem.Visible = True
        Else
            PurchaseToolStripMenuItem4.Visible = False
            HatchToolStripMenuItem.Visible = False
        End If

    End Sub



    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmRepGeneralLedger
        t.GroupBox1.Visible = False
        t.ShowDialog()
    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim t As New frmBankopening
        t.ShowDialog()
    End Sub

    Private Sub ChequeIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequeIssueToolStripMenuItem.Click
        'Dim t As New frmChequeIssued
        't.ShowDialog()
    End Sub

    Private Sub AllotChequeToUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllotChequeToUserToolStripMenuItem.Click
        Dim t As New frmChequaAllotuser
        t.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        Dim t As New frmChq_conf
        t.Show()
    End Sub


    Private Sub ChequeSearchPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequeSearchPrintToolStripMenuItem.Click
        Dim t As New frmChequeReport
        t.ShowDialog()
    End Sub

    Private Sub btnchqissued_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim t As New frmChequeIssued
        't.ShowDialog()
    End Sub

    Private Sub btnpartylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmPartyaccount
        Dim sql As String
        sql = "select Suffix from dbo.Groups where Group_name='PARTY' and Cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "Suffix")
        t.lblgroupname1.Text = "PARTY"
        t.lblgroupsuffix1.Text = GMod.ds.Tables("Suffix").Rows(0)(0)
        t.ShowDialog()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmVentry
        t.cmbvtype.Text = "RECEIPT"
        t.cmbvtype.Enabled = False
        t.Label1.Text = t.Label1.Text & "- RECEIPT"
        sqlvouseq = "select Vou_no_seq from Vtype where vtype='RECEIPT'"
        GMod.DataSetRet(sqlvouseq, "Vou_seq")
        t.lblvouseq.Text = GMod.ds.Tables("Vou_seq").Rows(0)(0)
        t.ShowDialog()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        'PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        'PictureBox2.Visible = False
    End Sub

    Private Sub AllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub firmtoolbar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub PartyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BankReconcilationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmBankReconcilation
        t.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        Dim t As New frmchqbook
        t.ShowDialog()
    End Sub

    Private Sub LedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmRepGeneralLedger
        t.GroupBox1.Visible = True
        t.ShowDialog()
    End Sub

    Private Sub TrialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmTrialbetweendays
        t.GroupBox1.Visible = True
        t.ShowDialog()
    End Sub

    Private Sub PLBalanceSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PLBalanceSheetToolStripMenuItem.Click
        If GMod.role.ToUpper = "VIEWER LEVEL-1" Then
            Dim t As New frmBalancesheet
            t.ShowDialog()
        ElseIf GMod.role.ToUpper = "ADMIN" Then
            Dim t As New frmBalancesheet
            t.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        Dim t As New Frmpaymentstop
        t.Show()
    End Sub

    Private Sub CashBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmCashBook2
        't.MdiParent = Me
        t.Show()
    End Sub

    Private Sub ToolStripMenuBankStatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmBankStateRepo
        t.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        Dim t As New frmItemmaster
        t.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        Dim t As New frmItemManagementRCM
        t.ShowDialog()
    End Sub

    Private Sub SequentialVentryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmSeqVentry
        t.ShowDialog()
    End Sub

    Private Sub BackYearOurBookChequesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackYearOurBookChequesToolStripMenuItem.Click
        'Dim t As New frmBackDateChqOurBook
        't.ShowDialog()
    End Sub

    Private Sub BackYearBankBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackYearBankBookToolStripMenuItem.Click
        Dim t As New frmBackDateChqBankBook
        t.ShowDialog()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        Dim t As New frmlogin
        t.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BankBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmBankBook2
        t.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmTrialbetweendays
        t.ShowDialog()
    End Sub

    Private Sub SaleInvoicePoultryHatchriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub HeadTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadTransferToolStripMenuItem.Click
        'Dim t As New frmHeadTransfer
        't.ShowDialog()
    End Sub

    Private Sub CRVoucherEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim t As New CRVoucherFeeding
        ' t.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        Dim th As New frmHeadDataTransfereToAnotherHead
        th.ShowDialog()
    End Sub

    Private Sub RSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rsale As New frmRevSale
        rsale.ShowDialog()
    End Sub

    Private Sub SalesReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rt As New frmSalesRegister
        rt.ShowDialog()
    End Sub

    Private Sub PurchaePhoenixChickenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frmpur As New frmPurchaseChicken
        ' frmpur.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim p As New frmPurchaseChicken
        p.ShowDialog()

    End Sub

    Private Sub SaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New frmSaleChicken
        s.ShowDialog()
    End Sub

    Private Sub PurchasePoultryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New frmPurchasePoultrty_NewGst
        obj.ShowDialog()
    End Sub

    Private Sub SaleRepToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmSaleRepPHHAPHOE
        t.ShowDialog()
    End Sub

    Private Sub PoultryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmPurchase_Register
        t.ShowDialog()
    End Sub

    Private Sub LedgerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedgerToolStripMenuItem.Click
        Dim t As New frmRepGeneralLedger
        t.ShowDialog()
    End Sub

    Private Sub TrialToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrialToolStripMenuItem.Click
        Dim t As New frmTrial2
        t.ShowDialog()
    End Sub

    Private Sub PoultryHatchriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tsale As New frmSaleInvoice
        tsale.ShowDialog()
    End Sub

    Private Sub HatchriesWestBengalUnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim saleWB As New frmSaleInvoiceWB
        saleWB.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        Dim cpobj As New frmcpvoucher
        cpobj.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        Dim t As New frmCashBook1
        t.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmModifyVoucherDate
        t.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click
        Dim custtrial As New frmCustomerTrailWithSupplyDate
        custtrial.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem23.Click
        Dim sr As New frmSearch
        sr.ShowDialog()
    End Sub
    Private Sub ChequeIssueReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequeIssueReportsToolStripMenuItem.Click
        Dim gh As New frmMISRepChqIssueToParty
        gh.ShowDialog()
    End Sub

    Private Sub CashReceivedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashReceivedToolStripMenuItem.Click
        Dim ghcash As New frmMisCashReceived
        ghcash.ShowDialog()
    End Sub

    Private Sub SalePurExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalePurExpensesToolStripMenuItem.Click
        Dim gh1 As New frmMISsalepurexp_rep
        gh1.ShowDialog()
    End Sub

    Private Sub VoucherSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoucherSToolStripMenuItem.Click
        Dim t As New frmVoucherSearch
        t.ShowDialog()
    End Sub

    Private Sub ImportBankStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim im As New frmImportBankState
        'im.ShowDialog()
    End Sub

    Private Sub BankReconcilationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankReconcilationToolStripMenuItem1.Click
        Dim brec As New frmTCSReport
        brec.ShowDialog()
    End Sub

    Private Sub BankStatementToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankStatementToolStripMenuItem1.Click
        Dim bas As New frmBankState3
        bas.ShowDialog()
    End Sub

    Private Sub FeedStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transfer.Click

    End Sub

    Private Sub FeedTrailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeedTrailToolStripMenuItem.Click
        Dim rtr As New frmFeedTrial
        rtr.ShowDialog()
    End Sub

    Private Sub TrialBetweenDaysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmTrialbetweendays
        t.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String, i As Integer
        'sql = "select * from printdata  where vou_type='SALE' and cmp_id='PHHA' and type='P' order by cast(vou_no as bigint)"
        'GMod.DataSetRet(sql, "PRINT")
        'For i = 0 To GMod.ds.Tables("PRINT").Rows.Count - 1

        '    sql = "select Acc_head_code from dbo.VENTRY_PHHA_0809 where vou_type='SALE' and Acc_head_code='" & GMod.ds.Tables("PRINT").Rows(i)("AccCode") & "' and vou_no='" & GMod.ds.Tables("PRINT").Rows(i)("vou_no") & "'"
        '    GMod.DataSetRet(sql, "dispaly")
        '    If GMod.ds.Tables("dispaly").Rows.Count > 0 Then
        '        'MsgBox(GMod.ds.Tables("dispaly").Rows(0)("Acc_head_code"))
        '    Else
        '        MsgBox(GMod.ds.Tables("PRINT").Rows(i)("AccCode"))
        '    End If
        'Next


        'Dim sql As String, i As Integer
        'Dim sqlupdat As String
        'sql = "select * from printdata  where vou_type='SALE' and cmp_id='PHHA' and type='P' and session='0809' order by cast(vou_no as bigint) "
        'GMod.DataSetRet(sql, "PRINT")
        'For i = 0 To GMod.ds.Tables("PRINT").Rows.Count - 1
        '    sqlupdat = "update " & GMod.VENTRY & " set vou_date='" & CDate(GMod.ds.Tables("PRINT").Rows(i)("Hatchdate")) & "' where vou_type='SALE' and vou_no='" & GMod.ds.Tables("PRINT").Rows(i)("vou_no").ToString & "'"
        '    GMod.SqlExecuteNonQuery(sqlupdat)
        'Next
        'MsgBox("ok")
    End Sub


    Private Sub DimSrAsNewFrmSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DimSrAsNewFrmSearchToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DimSrAsNewFrmSearchToolStripMenuItem.Click
        Dim sr As New frmSearch
        sr.ShowDialog()
    End Sub

    Private Sub NarrationUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NarrationUpdateToolStripMenuItem.Click
        'If GMod.role.ToUpper = "Admin".ToUpper Then
        Dim tfrm As New frmNarrationUpdate
        tfrm.ShowDialog()
        'End If
    End Sub

    Private Sub ToolStripMenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        'frmSaleRepPHHAPHOE.ShowDialog()
        'End If
    End Sub

    Private Sub JABALPURHATCHERIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim saleWB As New frmSaleInvoiceWB
        saleWB.ShowDialog()
    End Sub

    Private Sub SaleInvFederationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmSaleInvoicePrintFederation
        t.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim sql, up As String
        'sql = " select * from INVINFO_PHFA_0809 where vou_type='SALE' and itemname='CHICKS' order by cast(vou_no as bigint)"
        'GMod.DataSetRet(sql, "ZZ")
        'Dim i As Int16
        'For i = 0 To GMod.ds.Tables("ZZ").Rows.Count - 1
        '    up = "update INVINFO_PHFA_0809 set free_per = " & i + 1 & " where vou_no='" & GMod.ds.Tables("ZZ").Rows(i)("vou_no") & "'  and  vou_type='SALE' and itemname='CHICKS' "
        '    GMod.SqlExecuteNonQuery(up)
        'Next
    End Sub

    Private Sub MisMatchEntriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MisMatchEntriesToolStripMenuItem.Click
        Dim t As New frmMisMactchEntryList
        t.ShowDialog()
    End Sub

    Private Sub ChichkenBatchWiseSummToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChichkenBatchWiseSummToolStripMenuItem.Click
        Dim tfrm As New frmTrial3
        tfrm.ShowDialog()
    End Sub

    Private Sub SupplementryVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim prvuname As String = ""
        prvuname = GMod.username
        GMod.username = "$" & GMod.username
        MsgBox(GMod.username)
        Dim t As New frmVentry
        t.ShowDialog()
        GMod.username = prvuname
        'MsgBox(GMod.username)
    End Sub

    Private Sub CommonCustomerAccountHeadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommonCustomerAccountHeadToolStripMenuItem.Click
        Dim cmacchead As New frmCommonList
        cmacchead.ShowDialog()
    End Sub

    Private Sub OtherCompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim otcmp As New frmPurchase_RegisterOther
        otcmp.ShowDialog()
    End Sub

    Private Sub Trail4DayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tr4 As New frmTrial4day
        tr4.ShowDialog()
    End Sub

    Private Sub ChichkenCrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChichkenCrToolStripMenuItem.Click
        Dim t As New frmPurchaseSaleDebitCashRecivedSummary
        t.ShowDialog()
    End Sub

    Private Sub HatchAmountReceivedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HatchAmountReceivedToolStripMenuItem.Click
        Dim t As New frmHatchAmountReport
        t.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UpdateSubGroupWithToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateSubGroupWithToolStripMenuItem.Click
        If MessageBox.Show("Are u sure?", "Confirmation", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            '    Dim sqlt As String
            '    sqlt = "update  " & GMod.ACC_HEAD & "  set sub_group_name ='-' where len(sub_group_name) = 0 "
            '    MsgBox(GMod.SqlExecuteNonQuery(sqlt))
            '    sqlt = "update  " & GMod.VENTRY & "  set sub_group_name ='-' where len(sub_group_name) = 0 "
            '    MsgBox(GMod.SqlExecuteNonQuery(sqlt))
        End If
    End Sub

    Private Sub Trial4DayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Trial4DayToolStripMenuItem.Click
        Dim t As New frmTrial4day
        t.ShowDialog()
    End Sub

    Private Sub ChangeOwnPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeOwnPasswordToolStripMenuItem.Click
        Dim cp As New frmChangePassword
        cp.ShowDialog()
    End Sub

    Private Sub TrialBetweenDaysToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tbd As New frmTrial3
        tbd.ShowDialog()
    End Sub

    Private Sub HeadTransferToNextSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadTransferToNextSessionToolStripMenuItem.Click
        Dim tf As New frmTransferHeadtoNextSession
        tf.ShowDialog()
    End Sub

    Private Sub TrialControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FeedSaleToPartyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmStockReport
        t.ShowDialog()
    End Sub

    Private Sub CommonHeadBalancesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommonHeadBalancesToolStripMenuItem.Click
        Dim tt As New frmCommonHeadCustomerBalances
        tt.ShowDialog()
    End Sub

    Private Sub HatchReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HatchReportToolStripMenuItem.Click
        Dim ty As New frmHatchReport
        ty.ShowDialog()
    End Sub

    Private Sub HatchReportDetialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HatchReportDetialToolStripMenuItem.Click
        Dim ty As New frmHatchReportDetial
        ty.ShowDialog()
    End Sub

    Private Sub SaleRegisterAccordingToProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleRegisterAccordingToProductToolStripMenuItem.Click
        Dim tsalereg As New frmSaleRegisterProductWise
        tsalereg.ShowDialog()
    End Sub

    Private Sub UpdateOpeningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateOpeningToolStripMenuItem.Click
        Dim frmupopening As New frmUpdateOpeningofNextSession
        frmupopening.Show()
    End Sub

    Private Sub SearchFromDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchFromDataToolStripMenuItem.Click
        Dim tserach As New frmSearch
        tserach.ShowDialog()
    End Sub

    Private Sub CustomerListWithWithoutMobileNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListWithWithoutMobileNoToolStripMenuItem.Click
        Dim frmobjcustmobile As New frmCustListWithMobileNo
        frmobjcustmobile.Show()
    End Sub

    Private Sub PurchaseRegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pr As New frmPurchase_Register
        pr.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmTrial2.ShowDialog()
    End Sub

    Private Sub DueDateReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DueDateReportToolStripMenuItem.Click
        Dim t As New frmDuePartyPAymentDateList
        t.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ChqIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChqIssueToolStripMenuItem.Click
        frmMISRepChqIssueToParty.Show()
    End Sub
    Private Sub PurchaseSaleSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseSaleSummaryToolStripMenuItem.Click
        Dim feedst As New frmInvFromNarration
        feedst.ShowDialog()
    End Sub

    Private Sub IntrestCalculationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntrestCalculationToolStripMenuItem.Click
        frmIntrestCalc.Show()
    End Sub
    Private Sub DayBookBwDayaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayBookBwDayaToolStripMenuItem.Click
        frmDayBookBetweenDays.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GMod.DataSetRet("select getdate()", "serverdate")
        Dim sql As String
        sql = "update UserStatus set login='" & CDate(GMod.ds.Tables("serverdate").Rows(0)(0)) & "' where uname='" & GMod.username & "'"
        GMod.SqlExecuteNonQuery(sql)
    End Sub

    Private Sub MissingTRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MissingTRToolStripMenuItem.Click
        Dim tmiss As New frmbankstate1
        tmiss.ShowDialog()
    End Sub

    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmSaleInvoiceWithDiscountOnAmout.Show()
    End Sub

    Private Sub SupplementryLedgerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplementryLedgerToolStripMenuItem.Click
        Dim frmsupled As New frmSupplementHeadList
        frmsupled.Show()
    End Sub

    Private Sub DayWiseSaleCRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayWiseSaleCRToolStripMenuItem.Click
        frmIyerSirRep.ShowDialog()
    End Sub

    Private Sub SaleWithDiscountOnAmountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmdis As New frmSaleInvoiceWithDiscountOnAmout
        frmdis.ShowDialog()
    End Sub

    Private Sub CodeListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeListToolStripMenuItem.Click
        frmCodeList.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem24_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        Dim frmtc As New frmTrialControl
        frmtc.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tsrpp As New frmSalesRegister2
        tsrpp.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem26.Click
       
    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        Dim tds As New frmTdsMaster
        tds.ShowDialog()
    End Sub

    Private Sub TdsEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tdse As New frmTdsEntry
        tdse.ShowDialog()
    End Sub

    Private Sub TdsReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TdsReportToolStripMenuItem.Click
        Dim tdsrep As New frmTDSReport
        tdsrep.ShowDialog()
    End Sub

    Private Sub BankTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If GMod.Cmpid = "Phoe" Then

        'End If
    End Sub

    Private Sub CRDebitEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmCRDebit
        t.ShowDialog()
    End Sub

    Private Sub XXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xt As New frmXX
        xt.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim rt As New frmReceipt
        rt.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click, Button6.Click
        'frmLayout.ShowDialog()
        'frmOtherSalePrintInvoice.ShowDialog()
        'frmDailyRate.Show()
        'frmSaleChicken.ShowDialog()
        'frmPayment.ShowDialog()
        'frmSaleChicken.ShowDialog()
        'frmNewPurchaseRegister.ShowDialog()
        ' Dim UU As New frmBonusFrmXls
        'UU.ShowDialog()
        frmPaymentandChqprint.Show()
    End Sub

    Private Sub JournalVouchersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalVouchersToolStripMenuItem.Click
        Dim JounalObj As New frmJournal
        JounalObj.ShowDialog()
    End Sub

    Private Sub OtherSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherSaleToolStripMenuItem.Click
        Dim OtherSaleObj As New frmSaleOther
        OtherSaleObj.ShowDialog()
    End Sub
    Private Sub SaleToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleToolStripMenuItem2.Click
        If GMod.Cmpid = "PHOE" Then
            Dim Saleobj As New frmSaleInvoice
            Saleobj.ShowDialog()
        ElseIf GMod.Cmpid = "PHHA" Then
            Dim Saleobj As New frmSaleInvoice
            Saleobj.ShowDialog()
        Else
            Dim Saleobj As New frmSaleInvoiceWB
            Saleobj.ShowDialog()
        End If
    End Sub
    Private Sub ReceiptToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptToolStripMenuItem1.Click
        Dim ReceiptObj As New frmReceipt
        ReceiptObj.ShowDialog()
    End Sub
    Private Sub CrDebitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrDebitToolStripMenuItem.Click
        Dim t As New frmCRDebit
        t.ShowDialog()
    End Sub
    Private Sub SalaryTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub SalaryTransferCasualStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If GMod.Cmpid = "PHOE" Then
        'If GMod.role = "ADMIN" And GMod.role = "VIEWER LEVEL-1" Then
        If GMod.staff1 = 1 And (GMod.role = "VIEWER LEVEL-1" Or GMod.username = "admin") Then
            Dim saltrf As New frmSalaryTransferPoultryCasual
            saltrf.ShowDialog()
        End If
        'End If
    End Sub
    Private Sub PaymnetOthersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymnetOthersToolStripMenuItem.Click
        Dim Paymentobj As New frmPaymentandChqprint
        Paymentobj.ShowDialog()
    End Sub
    Private Sub SalaryBankTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ExpensesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesToolStripMenuItem1.Click
        Dim frmObj As New frmExpenses
        frmObj.ShowDialog()
    End Sub
    Private Sub PurchaseToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem2.Click
        Dim t As New frmPurchasePoultrty_NewGst
        t.ShowDialog()
    End Sub
    Private Sub PurchaseRegisterToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseRegisterToolStripMenuItem.Click
        Dim t As New frmNewPurchaseRegister
        t.ShowDialog()
    End Sub
    Private Sub SaleRegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleRegisterToolStripMenuItem.Click
        Dim frmsrobj As New frmSalesRegister2
        frmsrobj.ShowDialog()
    End Sub
    Private Sub SaleRegisterOthersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleRegisterOthersToolStripMenuItem.Click
        Dim frmsrobjoth As New frmOtherSaleReg
        frmsrobjoth.ShowDialog()
    End Sub
    Private Sub ReceiptToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptToolStripMenuItem.Click
        Dim ReceiptObj As New frmReceipt
        ReceiptObj.ShowDialog()
    End Sub
    Private Sub PaymentToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        Dim Paymentobj As New frmPayment
        Paymentobj.ShowDialog()
    End Sub
    Private Sub InvoiceReceiptDetialsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceReceiptDetialsToolStripMenuItem.Click
        Dim t As New frmBillDetialsSale
        t.lblsp.Text = "S"
        t.ShowDialog()

    End Sub
    Private Sub TDSEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDSEntryToolStripMenuItem1.Click
        Dim t As New frmTdsEntry
        t.ShowDialog()
    End Sub
    Private Sub TDSEntryToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDSEntryToolStripMenuItem.Click
        Dim t As New frmTdsEntry
        t.ShowDialog()
    End Sub
    Private Sub DelevaryVanExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelevaryVanExpensesToolStripMenuItem.Click
        Dim tobj As New frmExpensesVehiclereport
        tobj.ShowDialog()
    End Sub
    Private Sub PurchasePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchasePaymentToolStripMenuItem.Click
        Dim t As New frmBillDetialsSale
        t.lblsp.Text = "P"
        t.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem25_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
       
    End Sub
    Private Sub JournalPurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalPurchaseToolStripMenuItem.Click
        Dim t As New frmPurchasePoultrty_NewGstWithTds
        t.ShowDialog()
    End Sub
    Private Sub JournalPurchaseRegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalPurchaseRegisterToolStripMenuItem.Click
        Dim t As New frmNewPurchaseJournalRegister
        t.ShowDialog()
    End Sub
    Private Sub DailyExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyExpensesToolStripMenuItem.Click
        frmExpensesDailyMonthly.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        If GMod.role = "VIEWER LEVEL-1" Or GMod.role = "ADMIN" Then
            Dim fomobjbook As New frmBook
            fomobjbook.ShowDialog()
        End If
    End Sub
    Private Sub SaleProductWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleProductWiseToolStripMenuItem.Click
        frmSaleRegisterProductWise.ShowDialog()
    End Sub
    Private Sub SendBulkSmsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendBulkSmsToolStripMenuItem.Click
        If GMod.username.ToUpper = "ADMIN" Then
            frmSendBulkSms.ShowDialog()
        End If
    End Sub

    Private Sub OtherDetectionVoucherEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherDetectionVoucherEntryToolStripMenuItem.Click
        Dim OBJfrmOtherDetectionVoucherDr As New frmOtherDetectionVoucherDr
        OBJfrmOtherDetectionVoucherDr.ShowDialog()
    End Sub
    Private Sub PurchaseQtyMonthlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseQtyMonthlyToolStripMenuItem.Click
        'if GMod.role.ToUpper = "ADMIN" Then
        Dim t As New frmPurRepQtyMonth
        t.ShowDialog()
        'End If
    End Sub

    Private Sub SaleRepAreaDetialsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleRepAreaDetialsToolStripMenuItem.Click
        frmSaleRepPHHAPHOE.ShowDialog()
    End Sub

    Private Sub FinishedProductLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishedProductLedgerToolStripMenuItem.Click
        Dim pl As New frmProductLedger
        pl.ShowDialog()
    End Sub
    Private Sub BonusEntryBankDrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BonusEntryBankDrToolStripMenuItem.Click
        Dim bonus As New frmBonusBankDr
        bonus.ShowDialog()
    End Sub

    Private Sub TdsReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TdsReportToolStripMenuItem1.Click
        Dim t As New frmTDSReport
        t.ShowDialog()
    End Sub
    Private Sub OthersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersToolStripMenuItem.Click
        Dim t As New frmVentry
        t.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click
        Dim t As New frmBookOther
        t.ShowDialog()
    End Sub

    Private Sub PurchaseSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseSummaryToolStripMenuItem.Click
        Dim t As New frmPurcahseSumaryItemWise
        t.ShowDialog()
    End Sub

    Private Sub TdsEntryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TdsEntryToolStripMenuItem2.Click
        Dim t As New frmTdsEntry
        t.ShowDialog()
    End Sub

    Private Sub ChqLayoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChqLayoutToolStripMenuItem.Click
        Dim t As New frmLayout
        t.ShowDialog()
    End Sub

    Private Sub SuplementryEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuplementryEntryToolStripMenuItem.Click

        usrname = GMod.username
        GMod.username = "$" & GMod.username
        MsgBox(GMod.username)
        Dim JounalObj As New frmJournal
        JounalObj.ShowDialog()
        GMod.username = usrname
        MsgBox(GMod.username)
    End Sub

    Private Sub UpdateOpeningToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If GMod.role = "VIEWER LEVEL-1" Or GMod.role = "ADMIN" Then
        'Dim frmupopening As New frmUpdateOpeningofNextSession
        'frmupopening.Show()
        'End If
    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        Dim t As New frmTrial4
        t.ShowDialog()
    End Sub

    Private Sub BonusTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BonusTransferToolStripMenuItem.Click
        Dim UU As New frmBonusFrmXls
        UU.ShowDialog()
    End Sub

    Private Sub CashRecivedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashRecivedToolStripMenuItem.Click
        Dim ghcash As New frmMisCashReceived
        ghcash.ShowDialog()
    End Sub

    Private Sub DailyPaymentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyPaymentReportToolStripMenuItem.Click
        Dim ghcash As New frmDailyBnakPaymentRep
        ghcash.ShowDialog()
    End Sub

    Private Sub VoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoucherToolStripMenuItem.Click
        If GMod.role = "VIEWER LEVEL-1" Or GMod.role = "ADMIN" Then
            Dim t As New frmdayBookAuth
            t.ShowDialog()
        End If
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        If GMod.role = "VIEWER LEVEL-1" And GMod.Dept = 1 Then
            Dim t As New frmPurchaseRegisterAuthrization
            t.ShowDialog()
        End If
    End Sub

    Private Sub SaleRegisterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleRegisterToolStripMenuItem1.Click
        'If GMod.role = "VIEWER LEVEL-1" And GMod.Dept = 0 Then
        Dim t As New frmSalesRegisterChicksAuthrization
        t.ShowDialog()
        'End If
    End Sub

    Private Sub SaleRegisterOtherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleRegisterOtherToolStripMenuItem.Click
        'If GMod.role = "VIEWER LEVEL-1" And GMod.Dept = 0 Then
        Dim t As New frmOtherSaleRegAuthrization
        t.ShowDialog()
        'End If
    End Sub

    Private Sub PendingListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingListToolStripMenuItem.Click
        If GMod.role = "VIEWER LEVEL-1" Or GMod.role = "Admin" Then
            Dim t As New frmPendlingList
            t.ShowDialog()
        End If
    End Sub
    Private Sub PoAndBillReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PoAndBillReportToolStripMenuItem.Click
        Dim t As New frmPoAgsBillReport
        t.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem4.Click
        Dim t As New frmPurchaseHatchries
        t.ShowDialog()
    End Sub
    Private Sub NoOfDaysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoOfDaysToolStripMenuItem.Click
        Dim tnofdays As New frmNoofDays
        tnofdays.ShowDialog()
    End Sub
    Private Sub TempInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempInvoiceToolStripMenuItem.Click
        Dim tmmpinv As New frmpoultrytmpinv
        tmmpinv.ShowDialog()
    End Sub
    Private Sub BonusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BonusToolStripMenuItem.Click
        Dim bonusxls As New frmBonusDebitFrmXls
        bonusxls.ShowDialog()
    End Sub
    Private Sub CFormReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFormReportToolStripMenuItem.Click
        Dim cformobj As New FrmCstRpt
        cformobj.ShowDialog()
    End Sub
    Private Sub SaleToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleToolStripMenuItem.Click
        Dim frmsalebm As New frmSaleChicken
        frmsalebm.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem5.Click
        Dim frmpurbm As New frmPurchaseChicken
        frmpurbm.ShowDialog()
    End Sub

    Private Sub Form49IssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form49IssueToolStripMenuItem.Click
        Dim frm49issue As New frmDrNote
        frm49issue.ShowDialog()
    End Sub

    Private Sub Form49ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form49ReportToolStripMenuItem.Click
        Dim frm49rpt As New FrmForm49Rpt
        frm49rpt.ShowDialog()
    End Sub

    Private Sub MonthlyPLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyPLToolStripMenuItem.Click
        Dim frmmonthlypl As New frmBalancesheetMonthly
        frmmonthlypl.ShowDialog()
    End Sub
    Private Sub HatchQtyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HatchQtyToolStripMenuItem1.Click
        Dim frmHatchqtyobj As New frmHatchQty
        frmHatchqtyobj.ShowDialog()
    End Sub

    Private Sub AreaHatchQtyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaHatchQtyToolStripMenuItem.Click
        Dim frmHatchqtyobj As New frmHatchDistribution
        frmHatchqtyobj.ShowDialog()
    End Sub

    Private Sub MortalityReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MortalityReportToolStripMenuItem.Click
        Dim mrtr As New frmMortalityRep
        mrtr.ShowDialog()
    End Sub

    Private Sub MarketRateUpdationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarketRateUpdationToolStripMenuItem.Click
        Dim mrktrate As New frmMarketRate
        mrktrate.ShowDialog()
    End Sub

    Private Sub MarketRateVSPoRateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarketRateVSPoRateToolStripMenuItem.Click
        Dim mrktrate1 As New frmMarkerRatelistaginstchq
        mrktrate1.ShowDialog()
    End Sub

    Private Sub AreaMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaMasterToolStripMenuItem.Click
        Dim frmamaster As New frmAreamaster
        frmamaster.ShowDialog()
    End Sub

    Private Sub ChickRateMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChickRateMasterToolStripMenuItem.Click
        Dim frmchicksrate As New frmChicksratemaster
        frmchicksrate.ShowDialog()
    End Sub

    Private Sub SalePurchaseRegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalePurchaseRegisterToolStripMenuItem.Click
        Dim frmsale_pur_reg As New frmSale_Purchase_Summary
        frmsale_pur_reg.ShowDialog()
    End Sub

    Private Sub MultipleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultipleToolStripMenuItem.Click
        frmTdsMultiPleEntry.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Dim objproductmaster As New frmItemMasterOther
        objproductmaster.ShowDialog()
    End Sub

    Private Sub PToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PToolStripMenuItem.Click
        Dim objpurledgaer As New frmPurchaseLedeger
        objpurledgaer.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem33.Click
        Dim j As New frmPurcahseSumaryItemWiseJournal
        j.ShowDialog()
    End Sub

    Private Sub PartyBalanceLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyBalanceLetterToolStripMenuItem.Click
        Dim partyletter As New frmPartyLetter
        partyletter.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem34.Click
        Dim frmVprint As New frmVoucherPrintAll
        frmVprint.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem36.Click
        Dim frmVprint As New frmTrial2WithAddress
        frmVprint.ShowDialog()
    End Sub
    Private Sub ReceiptToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptToolStripMenuItem2.Click
        Dim ReceiptObj As New frmReceipt
        ReceiptObj.ShowDialog()
    End Sub
    Private Sub PaymentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem1.Click
        Dim Paymentobj As New frmPayment
        Paymentobj.ShowDialog()
    End Sub
    Private Sub SalaryBankTransferToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryBankTransferToolStripMenuItem1.Click
        'If GMod.role = "ADMIN" Then
        ' If GMod.Dept = 3 And GMod.role = "VIEWER LEVEL-1" Then
        Dim objsaltrf As New frmSalaryBankDr
        objsaltrf.ShowDialog()
        ' End If
    End Sub
    Private Sub SalaryTransferCasualStaffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryTransferCasualStaffToolStripMenuItem1.Click
        'If GMod.role = "ADMIN" And GMod.role = "VIEWER LEVEL-1" Then
        If GMod.staff1 = 1 And (GMod.role = "VIEWER LEVEL-1" Or GMod.username.ToLower = "admin") Then
            Dim saltrf As New frmSalaryTransferPoultryCasual
            saltrf.ShowDialog()
        End If
        'End If
    End Sub
    Private Sub ProductionIncentiveVoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionIncentiveVoucherToolStripMenuItem.Click
        If GMod.staff1 = 1 And (GMod.role = "VIEWER LEVEL-1" Or GMod.username.ToLower = "admin") Then
            Dim t As New frmProdincvVoucherDr
            t.ShowDialog()
        End If
    End Sub
    Private Sub SalaryTransferToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryTransferToolStripMenuItem1.Click
        If GMod.Cmpid = "PHOE" Then
            If GMod.staff1 = 1 And (GMod.role = "VIEWER LEVEL-1" Or GMod.role.ToLower = "admin") Then
                Dim saltrf As New frmSalaryTransfer
                saltrf.ShowDialog()
            End If
        ElseIf GMod.Cmpid = "PHHA" Then

            If GMod.staff1 = 1 And (GMod.role = "VIEWER LEVEL-1" Or GMod.role.ToLower = "admin") Then
                Dim saltrf As New frmSalaryTransferHatch
                saltrf.ShowDialog()
            End If
        End If
    End Sub

    Private Sub PartyPendingListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyPendingListToolStripMenuItem.Click
        Dim pdlfrm As New frmPartyDueBill
        pdlfrm.ShowDialog()
    End Sub

    Private Sub TrailWSOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrailWSOSToolStripMenuItem.Click
        Dim frmTWsOs As New frmTrialWSOS
        frmTWsOs.ShowDialog()
    End Sub
    Private Sub PendingListConsolidatedMonthlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingListConsolidatedMonthlyToolStripMenuItem.Click
        Dim pdlfrm As New frmPartyDueBillG
        pdlfrm.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem37.Click
        Dim BTfrm As New frmBTVoucher
        BTfrm.ShowDialog()
    End Sub
    Private Sub XLSFiltToVoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XLSFiltToVoucherToolStripMenuItem.Click
        Dim bonusxls As New frmBonusDebitFrmXls
        bonusxls.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        ' If GMod.Cmpid = "PHHA" And GMod.role = "VIEWER LEVEL-1" Then
        Dim frmbillupobj As New frmUpdateVouDate
        frmbillupobj.ShowDialog()
        'End If
    End Sub
    Private Sub TDsEntryModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TDsEntryModifyToolStripMenuItem.Click
        Dim frmTdsModify As New frmTdsModification
        frmTdsModify.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem1.Click

    End Sub

    Private Sub RCMVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RCMVoucherToolStripMenuItem.Click
        Dim frmRcm As New frmRCMVou
        frmRcm.ShowDialog()
    End Sub

    Private Sub PJTDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PJTDSToolStripMenuItem.Click
        Dim t As New frmGSTTDS
        t.ShowDialog()
    End Sub

    Private Sub GSTRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GSTRegisterToolStripMenuItem.Click
        Dim g As New frmGSTReg
        g.ShowDialog()
    End Sub

    Private Sub MissingTRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MissingTRToolStripMenuItem1.Click
        frmbankstate1.ShowDialog()
    End Sub

    Private Sub UpdateOpeningToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles UpdateOpeningToolStripMenuItem1.Click
        Dim frmupopening As New frmUpdateOpeningofNextSession
        frmupopening.Show()
    End Sub

    Private Sub ExpensesWithVehicleDetialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpensesWithVehicleDetialsToolStripMenuItem.Click
        Dim frmExpwithvehet As New frmExpensesWithVeh_Detials
        frmExpwithvehet.Show()
    End Sub

    Private Sub DisbursementRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisbursementRegisterToolStripMenuItem.Click
       
    End Sub
    Private Sub ToolStripMenuItem39_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem39.Click
        Dim advledger As New frmAdvanceLedger
        advledger.ShowDialog()
    End Sub

    Private Sub DisbursmentRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisbursmentRegisterToolStripMenuItem.Click
        Dim t As New frmDisburmentReg
        t.ShowDialog()
    End Sub

    Private Sub UnathrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnathrToolStripMenuItem.Click
        If GMod.username = "admin" Or GMod.username = "sysadmin" Then
            Dim t As New frmVoucherUnAuthr
            t.ShowDialog()
        End If
    End Sub

    Private Sub PurchaseRegisterGridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseRegisterGridViewToolStripMenuItem.Click
        Dim t As New frmNewPurRegGrig
        t.ShowDialog()
    End Sub

    Private Sub OtherSaleIUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherSaleIUToolStripMenuItem.Click
        Dim osiu As New frmOtherSaleIU
        osiu.ShowDialog()
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click

    End Sub

    Private Sub InvoicePrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoicePrintToolStripMenuItem.Click
        Dim frmbminvprint As New frmBmInvPrint
        frmbminvprint.ShowDialog()
    End Sub

    Private Sub BMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMToolStripMenuItem.Click

    End Sub

    Private Sub CustomerBalanceLetterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerBalanceLetterToolStripMenuItem.Click
        Dim frmcustomerbal As New frmCustomerBalanceLetter
        frmcustomerbal.ShowDialog()
    End Sub



    Private Sub PhoenixHAtchriesGSTR1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhoenixHAtchriesGSTR1ToolStripMenuItem.Click
        Dim gatr1 As New frmGSTR1PhooenixHatchrries
        gatr1.ShowDialog()
    End Sub

    Private Sub SessionPermissionToUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SessionPermissionToUserToolStripMenuItem.Click
        Dim sessionPermissionObj As New frmUserSessionPermission
        sessionPermissionObj.ShowDialog()
    End Sub

    Private Sub BankPartyListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankPartyListToolStripMenuItem.Click
        Dim t As New frmPartyBankList
        t.ShowDialog()
    End Sub

    Private Sub TCSMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TCSMasterToolStripMenuItem.Click
        Dim t As New frmTCSMaster
        t.Show()
    End Sub

    Private Sub TCSReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TCSReportToolStripMenuItem.Click
        Dim tcsrep As New frmTCSReport
        tcsrep.ShowDialog()
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmChangePassword.Show()
    End Sub
    Private Sub TRAuthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRAuthToolStripMenuItem.Click
        Dim frmTrtep As New FrmAreaWiseReport
        frmTrtep.ShowDialog()
    End Sub

    Private Sub TRPostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRPostToolStripMenuItem.Click
        Dim frmTrtep As New frmPostToAccounts
        frmTrtep.ShowDialog()
    End Sub

    Private Sub DMAuthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DMAuthToolStripMenuItem.Click
        Dim frmSupply As New FormSupply
        frmSupply.ShowDialog()
    End Sub

    Private Sub DMPostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DMPostToolStripMenuItem.Click
        Dim frmSupplyPost As New frmDMPosting
        frmSupplyPost.ShowDialog()
    End Sub

    Private Sub TRPostMultiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRPostMultiToolStripMenuItem.Click
        Dim t As New frmPostToAccounts_Mutiple_Tr
        t.ShowDialog()
    End Sub

    Private Sub UnAuthrisedLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnAuthrisedLedgerToolStripMenuItem.Click
        Dim t As New frmRepGeneralLedgerUnAuthData
        t.ShowDialog()
    End Sub

    Private Sub UnAuthridesTrialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnAuthridesTrialToolStripMenuItem.Click
        Dim t As New frmTrial2_Unauth
        t.ShowDialog()
    End Sub
End Class