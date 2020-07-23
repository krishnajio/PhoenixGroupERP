Imports System.Data
Imports System.Data.SqlClient
Public Class frmChequeIssued
    Dim AccCodeCash, GroupCash, SuggrpCash As String
    Private Sub frmChequeIssued_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        Rect_type = "CASH" 'for recept type 
        Dim sqlcashdel As String
        sqlcashdel = "select account_code,group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='CASH'"
        GMod.DataSetRet(sqlcashdel, "CashDet")

        If GMod.ds.Tables("CashDet").Rows.Count > 0 Then
            AccCodeCash = GMod.ds.Tables("CashDet").Rows(0)(0)
            GroupCash = GMod.ds.Tables("CashDet").Rows(0)(1)
            SuggrpCash = GMod.ds.Tables("CashDet").Rows(0)(2)
        Else
            MsgBox("CASH Account head is not created , please create it", MsgBoxStyle.Information)
            Me.Close()
        End If
        GMod.ds.Tables("CashDet").Clear()
        'Disabling buttons
        btndelete.Enabled = False
        btnsave.Enabled = False
        btnprint.Enabled = False
        btnprintall.Enabled = False
        'btnprintvoucher.Enabled = False
        Try
            dtIssuedate.Focus()

            'id, Cmp_id, Group_name, Sub_group_name, Acc_Code, Acc_head, Vou_type
            GMod.DataSetRet("select *  from Chq_conf where Cmp_id='" & GMod.Cmpid & "' order by id", "Chq_conf")
            'fill bank account head
            GMod.DataSetRet("select account_head_name,account_code from " & GMod.ACC_HEAD & " where Group_name='BANK'", "bankacchead")
            cmbacchead.DataSource = GMod.ds.Tables("bankacchead")
            cmbacchead.DisplayMember = "account_head_name"
            cmbacccode.DataSource = GMod.ds.Tables("bankacchead")
            cmbacccode.DisplayMember = "account_code"

            'Getting all Favour of names
            GMod.DataSetRet("select * from favof", "favof")
            cmbfavourof.DataSource = GMod.ds.Tables("favof")
            cmbfavourof.DisplayMember = "favourof"
            nxtchqno()
            nxtrecid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dtIssuedate.Focus()

        'id, Cmp_id, Group_name, Sub_group_name, Acc_Code, Acc_head, Vou_type
        GMod.DataSetRet("select *  from Chq_conf order by id", "Chq_conf")

        'fill bank account head
        GMod.DataSetRet("select account_head_name,account_code from " & GMod.ACC_HEAD & " where Group_name='BANK'", "bankacchead")

        cmbacchead.DataSource = GMod.ds.Tables("bankacchead")
        cmbacchead.DisplayMember = "account_head_name"
        cmbacccode.DataSource = GMod.ds.Tables("bankacchead")
        cmbacccode.DisplayMember = "account_code"

        'Getting all Favour of names
        GMod.DataSetRet("select * from favof", "favof")
        cmbfavourof.DataSource = GMod.ds.Tables("favof")
        cmbfavourof.DisplayMember = "favourof"
        nxtchqno()
        nxtvnoCHQ()
    End Sub
    Sub nxtrecid()
        Try
            GMod.DataSetRet("SELECT isnull(max(Receipt_id),0) + 1 FROM " & GMod.CHQ_ISSUED & " where Rect_type='" & Rect_type & "' ", "nxtrec")
            lblrecno.Text = Format(GMod.ds.Tables("nxtrec").Rows(0)(0), "0000000000")
            GMod.ReciptId = Format(lblrecno.Text, "0000000000")
        Catch ex As Exception
            MsgBox("RECEPIT ID NOT GENERATED" & ex.Message)
        End Try
    End Sub
    Sub nxtchqno()
        Try

            ' GMod.DataSetRet("select * from " & GMod.CHQ_ALLOT & " where u_name='" & GMod.username & "' and bank_acc_head='" & cmbacccode.Text & "' and chq_remain>0", "nxtchq")
            Dim sqlchqno As String
            sqlchqno = "select * from " & GMod.CHQ_ALLOT _
            & " where bank_acc_head='" & cmbacccode.Text & "' and U_name='" & GMod.username & "' and Book_no= ( select max(Book_no) from " & GMod.CHQ_ALLOT _
            & " where U_name='" & GMod.username & "' and bank_acc_head='" & cmbacccode.Text & "')"
            'MsgBox(sqlchqno)
            GMod.DataSetRet(sqlchqno, "nxtchq")
            Dim ddno As String
            Dim zero As String = ""
            Dim i, l As Integer
            'If GMod.ds.Tables("nxtchq").Rows.Count > 0 Then
            '    ddno = Str(Val(GMod.ds.Tables("nxtchq").Rows(0)("ch_no_to")) - GMod.ds.Tables("nxtchq").Rows(0)("chq_remain") + 1)

            '    l = GMod.ds.Tables("nxtchq").Rows(0)("ch_no_to").ToString.Length
            '    For i = 0 To l - 1
            '        zero = zero + "0"
            '    Next
            '    txtchqno.Text = Format(Val(ddno), zero)
            'Else
            '    'MsgBox("Chq Not assigne to user", MsgBoxStyle.Critical)
            '    txtchqno.Text = ""
            'End If

            ddno = GMod.ds.Tables("nxtchq").Rows(0)("last_che").ToString
            ' MsgBox(ddno)
            l = GMod.ds.Tables("nxtchq").Rows(0)("last_che").ToString.Length
            For i = 0 To l - 1
                zero = zero + "0"
            Next
            txtchqno.Text = Format(Val(ddno) + 1, zero)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtIssuedate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtIssuedate.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacchead.Focus()
    End Sub
    Private Sub cmbacccode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacccode.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacchead.Focus()
    End Sub

    Private Sub cmbacchead_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacchead.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtchqno.Focus()
        ElseIf e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
            dtIssuedate.Focus()
        End If
    End Sub

    Private Sub txtchqno_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtchqno.Enter
        nxtchqno()
    End Sub

    Private Sub txtchqno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtchqno.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtchequedate.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbacchead.Focus()
        End If
    End Sub

    Private Sub dtchequedate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtchequedate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpartyacchead.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtchqno.Focus()
        End If

    End Sub

    Private Sub cmbpartyacccode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpartyacccode.KeyDown
        If e.KeyCode = Keys.Enter Then cmbpartyacchead.Focus()
    End Sub

    Private Sub cmbpartyacchead_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpartyacchead.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbfavourof.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            dtchequedate.Focus()
        End If

    End Sub

    Private Sub cmbfavourof_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbfavourof.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamount.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbpartyacchead.Focus()
        End If

    End Sub

    Private Sub txtamount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtddchrgper.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cmbfavourof.Focus()
        End If

    End Sub

    Private Sub txtddchrgper_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtddchrgper.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtddcharges.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtamount.Focus()
        End If

    End Sub

    Private Sub txtddcharges_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtddcharges.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsertaxper.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtddchrgper.Focus()
        End If
    End Sub

    Private Sub txtservicetax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtservicetax.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrectamt.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtsertaxper.Focus()
        End If
    End Sub

    Private Sub txtrectamt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrectamt.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnchangerepno.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtservicetax.Focus()
        End If
    End Sub

    Private Sub txtsertaxper_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsertaxper.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtservicetax.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtddcharges.Focus()
        End If


    End Sub

    Private Sub txtddchrgper_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtddchrgper.Leave
        txtddcharges.Text = Math.Floor(Val(txtddchrgper.Text) / 100 * Val(txtamount.Text))
    End Sub

    Private Sub txtsertaxper_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsertaxper.Leave
        txtservicetax.Text = Math.Floor(Val(txtsertaxper.Text) / 100 * Val(txtddcharges.Text))
    End Sub

    Private Sub rdParty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdParty.CheckedChanged
        If rdParty.Checked = True Then
            'fill party acchead
            GMod.DataSetRet("select account_head_name,account_code from " & GMod.ACC_HEAD & " where Group_name='PARTY'", "party")
            cmbpartyacchead.DataSource = GMod.ds.Tables("party")
            cmbpartyacchead.DisplayMember = "account_head_name"

            cmbpartyacccode.DataSource = GMod.ds.Tables("party")
            cmbpartyacccode.DisplayMember = "account_code"
        End If
    End Sub

    Private Sub rdother_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdother.CheckedChanged
        If rdother.Checked = True Then
            'fill party acchead
            GMod.DataSetRet("select account_head_name,account_code from " & GMod.ACC_HEAD & " where Group_name not in ('PARTY')", "other")
            cmbpartyacchead.DataSource = GMod.ds.Tables("other")
            cmbpartyacchead.DisplayMember = "account_head_name"

            cmbpartyacccode.DataSource = GMod.ds.Tables("other")
            cmbpartyacccode.DisplayMember = "account_code"
        End If
    End Sub
    Dim single_multiple As String
    Private Sub btnaddsingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddsingle.Click
        nxtvnoCHQ() 'Generating voucher number
        single_multiple = "S"
        If txtchqno.Text = "" Then
            MsgBox("Cheque No. cant't be blank")
            txtchqno.Focus()
            Exit Sub
        End If
        'save cheque info into temp
        btnaddmultiple.Enabled = False
        btnaddsingle.Enabled = False
        btndelete.Enabled = False
        btnprint.Enabled = False
        btnprintall.Enabled = False
        'btnprintvoucher.Enabled = False
        btnsave.Enabled = True
        MsgBox("Add Single", MsgBoxStyle.Information)
    End Sub
    Dim sqlpartycach, partybank, partycomm, partyservice, partydr
    Public Rect_type As String
    Public Sub SingleCheque()
        'Getting Group and sub gropu from Acc_head table on basis of Acc_code
        'Code by krishna 
        SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & cmbpartyacccode.Text & "'"
        GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
        Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
        Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)
        Dim amtrecipt As Double
        amtrecipt = CDbl(txtrectamt.Text)
        Dim voudate As Date
        If amtrecipt > 0 Then
            voudate = dtIssuedate.Value
        Else
            voudate = dtchequedate.Value
        End If

        'Getting Group and sub gropu from Acc_head table on basis of Acc_code
        'Code by krishna 
        'SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & cmbpartyacccode.Text & "'"
        'GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
        'Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
        'Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)
        'Entry_id
        'CASH Dr
        sqlsavecr = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
        sqlsavecr &= "'" & GMod.Cmpid & "',"
        sqlsavecr &= "'" & GMod.username & "',"
        sqlsavecr &= "'" & lastid & "',"
        sqlsavecr &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
        sqlsavecr &= "'" & voudate.ToShortDateString & "',"
        sqlsavecr &= "'" & AccCodeCash & "',"
        sqlsavecr &= "'CASH',"
        sqlsavecr &= "'" & txtrectamt.Text & "',"
        sqlsavecr &= "'CHEQUE',"
        sqlsavecr &= "'TO " & cmbpartyacchead.Text & "," & "BY CASH RECEIVED AGAINST CHQ. NO ',"
        sqlsavecr &= "'" & GroupCash & "',"
        sqlsavecr &= "'" & SuggrpCash & "',"
        sqlsavecr &= "'" & txtchqno.Text & "',"
        sqlsavecr &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        sqlsavecr &= "'" & dtchequedate.Value.ToShortDateString & "',"
        sqlsavecr &= "'1')"

        'Party Cr
        sqlpartycach = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head,cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
        sqlpartycach &= "'" & GMod.Cmpid & "',"
        sqlpartycach &= "'" & GMod.username & "',"
        sqlpartycach &= "'" & lastid & "',"
        sqlpartycach &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
        sqlpartycach &= "'" & voudate.ToShortDateString & "',"
        sqlpartycach &= "'" & cmbpartyacccode.Text & "',"
        sqlpartycach &= "'" & cmbpartyacchead.Text & "',"
        sqlpartycach &= "'" & txtrectamt.Text & "',"
        sqlpartycach &= "'CHEQUE',"
        sqlpartycach &= "'BEING CASH PAID ANAINST CHQ NO ',"
        sqlpartycach &= "'" & Group_name & "',"
        sqlpartycach &= "'" & Sub_group_name & "',"
        sqlpartycach &= "'" & txtchqno.Text & "',"
        sqlpartycach &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        sqlpartycach &= "'" & dtchequedate.Value.ToShortDateString & "',"
        sqlpartycach &= "'5')"

        'Party Dr if not paying cash
        partydr = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head,dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
        partydr &= "'" & GMod.Cmpid & "',"
        partydr &= "'" & GMod.username & "',"
        partydr &= "'" & lastid & "',"
        partydr &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
        partydr &= "'" & voudate.ToShortDateString & "',"
        partydr &= "'" & cmbpartyacccode.Text & "',"
        partydr &= "'" & cmbpartyacchead.Text & "',"
        partydr &= "'" & dramt & "',"
        partydr &= "'CHEQUE',"
        partydr &= "'BEING CHEQUE ISSUED CHQ NO ',"
        partydr &= "'" & Group_name & "',"
        partydr &= "'" & Sub_group_name & "',"
        partydr &= "'" & txtchqno.Text & "',"
        partydr &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        partydr &= "'" & dtchequedate.Value.ToShortDateString & "',"
        partydr &= "'4')"

        'Both will cacel each other Party (Cr) and Cash (Dr) 

        'BANK CR
        sqlsaveba = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id ) values ("
        sqlsaveba &= "'" & GMod.Cmpid & "',"
        sqlsaveba &= "'" & GMod.username & "',"
        sqlsaveba &= "'" & lastid & "',"
        sqlsaveba &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
        sqlsaveba &= "'" & voudate.ToShortDateString & "',"
        sqlsaveba &= "'" & cmbacccode.Text & "',"
        sqlsaveba &= "'" & cmbacchead.Text & "',"
        sqlsaveba &= "'" & txtamount.Text & "',"
        sqlsaveba &= "'CHEQUE',"
        sqlsaveba &= "'TO " & cmbpartyacchead.Text & "," & "BY CASH RECEIVED AGAINST CHQ. NO ',"
        sqlsaveba &= "'BANK',"
        sqlsaveba &= "'-',"
        sqlsaveba &= "'" & txtchqno.Text & "',"
        sqlsaveba &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        sqlsaveba &= "'" & dtchequedate.Value.ToShortDateString & "',"
        sqlsaveba &= "'6')"
        'MsgBox(sqlsaveba)


        'Party will Dr by Cheque Amount of Bank
        partybank = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
        partybank &= "'" & GMod.Cmpid & "',"
        partybank &= "'" & GMod.username & "',"
        partybank &= "'" & lastid & "',"
        partybank &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
        partybank &= "'" & voudate.ToShortDateString & "',"
        partybank &= "'" & cmbpartyacccode.Text & "',"
        partybank &= "'" & cmbpartyacchead.Text & "',"
        partybank &= "'" & txtamount.Text & "',"
        partybank &= "'CHEQUE',"
        partybank &= "'BEING CHEQUE RECEIVED AGAINST CHQ NO ',"
        partybank &= "'" & Group_name & "',"
        partybank &= "'" & Sub_group_name & "',"
        partybank &= "'" & txtchqno.Text & "',"
        partybank &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        partybank &= "'" & dtchequedate.Value.ToShortDateString & "',"
        partybank &= "'1')"

        'DD COMISION Cr
        sqlsavedd = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
        sqlsavedd &= "'" & GMod.Cmpid & "',"
        sqlsavedd &= "'" & GMod.username & "',"
        sqlsavedd &= "'" & lastid & "',"
        sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
        sqlsavedd &= "'" & voudate.ToShortDateString & "',"
        sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(4) & "',"
        sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(5) & "',"
        sqlsavedd &= "'" & txtddcharges.Text & "',"
        sqlsavedd &= "'CHEQUE',"
        sqlsavedd &= "'DD CHARGES',"
        sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(2) & "',"
        sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(3) & "',"
        sqlsavedd &= "'" & txtchqno.Text & "',"
        sqlsavedd &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        sqlsavedd &= "'" & dtchequedate.Value.ToShortDateString & "',"
        sqlsavedd &= "'7')"

        'Party will Dr by Commision amount
        partycomm = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
        partycomm &= "'" & GMod.Cmpid & "',"
        partycomm &= "'" & GMod.username & "',"
        partycomm &= "'" & lastid & "',"
        partycomm &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
        partycomm &= "'" & voudate.ToShortDateString & "',"
        partycomm &= "'" & cmbpartyacccode.Text & "',"
        partycomm &= "'" & cmbpartyacchead.Text & "',"
        partycomm &= "'" & txtddcharges.Text & "',"
        partycomm &= "'CHEQUE',"
        partycomm &= "'DD CHARGES PAID',"
        partycomm &= "'" & Group_name & "',"
        partycomm &= "'" & Sub_group_name & "',"
        partycomm &= "'" & txtchqno.Text & "',"
        partycomm &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        partycomm &= "'" & dtchequedate.Value.ToShortDateString & "',"
        partycomm &= "'2')"

        'MsgBox(sqlsavedd)

        'SERVICE TAX  Cr
        sqlsavest = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
        sqlsavest &= "'" & GMod.Cmpid & "',"
        sqlsavest &= "'" & GMod.username & "',"
        sqlsavest &= "'" & lastid & "',"
        sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
        sqlsavest &= "'" & voudate.ToShortDateString & "',"
        sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(4) & "',"
        sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(5) & "',"
        sqlsavest &= "'" & txtservicetax.Text & "',"
        sqlsavest &= "'CHEQUE',"
        sqlsavest &= "'SERVICE TAX',"
        sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(2) & "',"
        sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(3) & "',"
        sqlsavest &= "'" & txtchqno.Text & "',"
        sqlsavest &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        sqlsavest &= "'" & dtchequedate.Value.ToShortDateString & "',"
        sqlsavest &= "'8')"

        'Party will Dr by Service Tax Amount
        partyservice = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
        partyservice &= "'" & GMod.Cmpid & "',"
        partyservice &= "'" & GMod.username & "',"
        partyservice &= "'" & lastid & "',"
        partyservice &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
        partyservice &= "'" & voudate.ToShortDateString & "',"
        partyservice &= "'" & cmbpartyacccode.Text & "',"
        partyservice &= "'" & cmbpartyacchead.Text & "',"
        partyservice &= "'" & txtservicetax.Text & "',"
        partyservice &= "'CHEQUE',"
        partyservice &= "'SERVICE TAX PAID',"
        partyservice &= "'" & Group_name & "',"
        partyservice &= "'" & Sub_group_name & "',"
        partyservice &= "'" & txtchqno.Text & "',"
        partyservice &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        partyservice &= "'" & dtchequedate.Value.ToShortDateString & "',"
        partyservice &= "'3')"

        'MsgBox(sqlsavest)

        'Cmp_id, Receipt_id, Issue_date, Chq_date, Cheque_no, BankAcc_code, Amount, Dd_Charge_per, Dd_charge, Service_tax, Receipt_amt, party_code, party_name, final_date, favourof, vouno, stop_bounce
        sqlsavechq = "insert into " & GMod.CHQ_ISSUED & " (Cmp_id, Receipt_id, Issue_date, Chq_date, Cheque_no, BankAcc_code, Amount, Dd_Charge_per, Dd_charge, Service_tax, Receipt_amt,party_code,party_name,favourof,vouno,Rect_type) values ( "
        sqlsavechq &= "'" & GMod.Cmpid & "',"
        sqlsavechq &= "'" & lblrecno.Text & "',"
        sqlsavechq &= "'" & dtIssuedate.Value.ToShortDateString & "',"
        sqlsavechq &= "'" & dtchequedate.Value.ToShortDateString & "',"
        sqlsavechq &= "'" & txtchqno.Text & "',"
        sqlsavechq &= "'" & cmbacccode.Text & "',"
        sqlsavechq &= "'" & txtamount.Text & "',"
        sqlsavechq &= "'" & txtddchrgper.Text & "',"
        sqlsavechq &= "'" & txtddcharges.Text & "',"
        sqlsavechq &= "'" & txtservicetax.Text & "',"
        sqlsavechq &= "'" & txtrectamt.Text & "',"
        sqlsavechq &= "'" & cmbpartyacccode.Text & "',"
        sqlsavechq &= "'" & cmbpartyacchead.Text & "',"
        sqlsavechq &= "'" & cmbfavourof.Text & "',"
        sqlsavechq &= "'" & lastid & "',"
        sqlsavechq &= "'" & Rect_type & "')"
        'MsgBox(sqlsavechq)

        'Inserint into temp table
        Dim sqlsavechqtmp As String
        Dim sqldel As String = "delete from tmp_multiple_chq where uname='" & GMod.username & "'"
        sqlsavechqtmp = "insert into tmp_multiple_chq (Cmp_id, Chq_no, favourof, recpitid, amount, Chq_date,Uname) values ( "
        sqlsavechqtmp &= "'" & GMod.Cmpid & "',"
        sqlsavechqtmp &= "'" & txtchqno.Text & "',"
        sqlsavechqtmp &= "'" & cmbfavourof.Text & "',"
        sqlsavechqtmp &= "'" & lblrecno.Text & "',"
        sqlsavechqtmp &= "'" & txtamount.Text & "',"
        sqlsavechqtmp &= "'" & dtchequedate.Text & "',"
        sqlsavechqtmp &= "'" & GMod.username & "')"


        'update cheqhe  allotment book of user
        Dim sqluchq As String
        'sqluchq = "update " & GMod.CHQ_ALLOT & " set chq_remain = chq_remain-1 Where u_name='" & GMod.username & "' and"
        'sqluchq += " bank_acc_head='" & cmbacccode.Text & "' and chq_remain>0"

        'new code written by krishna
        sqluchq = "update " & GMod.CHQ_ALLOT & " set last_che = '" & txtchqno.Text & "' Where u_name='" & GMod.username & "' and"
        sqluchq &= " bank_acc_head='" & cmbacccode.Text & "' and Book_no= ( select max(Book_no) from " & GMod.CHQ_ALLOT _
         & " where U_name='" & GMod.username & "' and bank_acc_head='" & cmbacccode.Text & "')"
        'MsgBox(sqluchq)

        Dim sqltrans As SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction
        Try
            If amtrecipt > 0 Then
                Dim cmd1 As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltrans)
                cmd1.ExecuteNonQuery()

                Dim cmd2 As New SqlCommand(sqlpartycach, GMod.SqlConn, sqltrans)
                cmd2.ExecuteNonQuery()
            Else
                ' Dim cmdPartydr As New SqlCommand(partydr, GMod.SqlConn, sqltrans)
                'cmdPartydr.ExecuteNonQuery()
            End If
            Dim cmd3 As New SqlCommand(sqlsavest, GMod.SqlConn, sqltrans)
            cmd3.ExecuteNonQuery()

            Dim cmd4 As New SqlCommand(partyservice, GMod.SqlConn, sqltrans)
            cmd4.ExecuteNonQuery()

            Dim cmd5 As New SqlCommand(sqlsavedd, GMod.SqlConn, sqltrans)
            cmd5.ExecuteNonQuery()

            Dim cmd6 As New SqlCommand(partycomm, GMod.SqlConn, sqltrans)
            cmd6.ExecuteNonQuery()

            Dim cmd7 As New SqlCommand(sqlsaveba, GMod.SqlConn, sqltrans)
            cmd7.ExecuteNonQuery()

            Dim cmd8 As New SqlCommand(partybank, GMod.SqlConn, sqltrans)
            cmd8.ExecuteNonQuery()


            Dim cmdCHQ As New SqlCommand(sqlsavechq, GMod.SqlConn, sqltrans)
            cmdCHQ.ExecuteNonQuery()

            'Other than treansections
            Dim cmd9 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
            cmd9.ExecuteNonQuery()

            Dim cmd10 As New SqlCommand(sqlsavechqtmp, GMod.SqlConn, sqltrans)
            cmd10.ExecuteNonQuery()

            Dim cmd11 As New SqlCommand(sqluchq, GMod.SqlConn, sqltrans)
            cmd11.ExecuteNonQuery()


            sqltrans.Commit()
            MsgBox("Cheque voucher saved", MsgBoxStyle.Information)
        Catch ex As Exception
            sqltrans.Rollback()
            If ex.Message.Contains("PRIMARY KEY") Then
                MsgBox("CHEQUE ALREADY ISSUED", MsgBoxStyle.Critical)
            Else
                MsgBox("Error" & ex.Message)
            End If
        End Try
    End Sub
    Public Sub MultipleCeque()
        'Getting Group and sub gropu from Acc_head table on basis of Acc_code
        'Code by krishna
        nxtvnoCHQ()
        nxtrecid()
        Dim z As Integer
        Dim zer1 As String = ""
        For z = 0 To GMod.ReciptId.Length - 1
            zer1 = zer1 & "0"
        Next
        SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & cmbpartyacccode.Text & "'"
        GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
        Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
        Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)

        Dim amtrecipt As Double
        Dim voudatmul As Date
        amtrecipt = CDbl(txtrectamt.Text)
        Dim sqltrans As SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction
        Try
            If amtrecipt > 0 Then
                Rect_type = "CASH" 'fOR PAY TYPE
                voudatmul = dtIssuedate.Value
                'Getting Group and sub gropu from Acc_head table on basis of Acc_code
                ''Code by krishna 
                'SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & cmbpartyacccode.Text & "'"
                'GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
                'Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
                'Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)

                GMod.DataSetRet("select * from tmp_multiple_chq where Cmp_id='" & GMod.Cmpid & "' and uname='" & GMod.username & "'", "MultipleChq")
                'Cmp_id, Chq_no, favourof, recpitid, amount, Chq_date, Uname
                Dim i As Integer
                For i = 0 To GMod.ds.Tables("MultipleChq").Rows.Count - 1
                    'CASH DR
                    sqlsavecr = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name, Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    sqlsavecr &= "'" & GMod.Cmpid & "',"
                    sqlsavecr &= "'" & GMod.username & "',"
                    sqlsavecr &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    sqlsavecr &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    sqlsavecr &= "'" & voudatmul.ToShortDateString & "',"
                    sqlsavecr &= "'" & AccCodeCash & "',"
                    sqlsavecr &= "'CASH',"
                    sqlsavecr &= "'" & txtrectamt.Text & "',"
                    sqlsavecr &= "'CHEQUE',"
                    sqlsavecr &= "'TO " & cmbpartyacchead.Text & "," & " BY CASH RECEIVED AGAINST CHQ. NO ',"
                    sqlsavecr &= "'" & GroupCash & "',"
                    sqlsavecr &= "'" & SuggrpCash & "',"
                    sqlsavecr &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlsavecr &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlsavecr &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlsavecr &= "'5')"

                    'MsgBox(sqlsavecr)
                    Dim cmdcash As New SqlCommand(sqlsavecr, GMod.SqlConn, sqltrans)
                    cmdcash.ExecuteNonQuery()


                    'Party Cr
                    sqlpartycach = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head,cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    sqlpartycach &= "'" & GMod.Cmpid & "',"
                    sqlpartycach &= "'" & GMod.username & "',"
                    sqlpartycach &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    sqlpartycach &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    sqlpartycach &= "'" & voudatmul.ToShortDateString & "',"
                    sqlpartycach &= "'" & cmbpartyacccode.Text & "',"
                    sqlpartycach &= "'" & cmbpartyacchead.Text & "',"
                    sqlpartycach &= "'" & txtrectamt.Text & "',"
                    sqlpartycach &= "'CHEQUE',"
                    sqlpartycach &= "'BEING CASH PAID AGAINST CHQ NO ',"
                    sqlpartycach &= "'" & Group_name & "',"
                    sqlpartycach &= "'" & Sub_group_name & "',"
                    sqlpartycach &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlpartycach &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlpartycach &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlpartycach &= "'4')"
                    Dim cmd1 As New SqlCommand(sqlpartycach, GMod.SqlConn, sqltrans)
                    cmd1.ExecuteNonQuery()


                    'Party will Dr by Commision amount
                    partycomm = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    partycomm &= "'" & GMod.Cmpid & "',"
                    partycomm &= "'" & GMod.username & "',"
                    partycomm &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    partycomm &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    partycomm &= "'" & voudatmul.ToShortDateString & "',"
                    partycomm &= "'" & cmbpartyacccode.Text & "',"
                    partycomm &= "'" & cmbpartyacchead.Text & "',"
                    partycomm &= "'" & txtddcharges.Text & "',"
                    partycomm &= "'CHEQUE',"
                    partycomm &= "'DD CHARGES PAID',"
                    partycomm &= "'" & Group_name & "',"
                    partycomm &= "'" & Sub_group_name & "',"
                    partycomm &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    partycomm &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    partycomm &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    partycomm &= "'2')"

                    Dim cmd2 As New SqlCommand(partycomm, GMod.SqlConn, sqltrans)
                    cmd2.ExecuteNonQuery()

                    'DD COMISION Cr
                    sqlsavedd = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    sqlsavedd &= "'" & GMod.Cmpid & "',"
                    sqlsavedd &= "'" & GMod.username & "',"
                    sqlsavedd &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    sqlsavedd &= "'" & voudatmul.ToShortDateString & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(4) & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(5) & "',"
                    sqlsavedd &= "'" & txtddcharges.Text & "',"
                    sqlsavedd &= "'CHEQUE',"
                    sqlsavedd &= "'DD CHARGES',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(2) & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(3) & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlsavedd &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlsavedd &= "'4')"
                    'MsgBox(sqlsavedd)
                    Dim cmddd As New SqlCommand(sqlsavedd, GMod.SqlConn, sqltrans)
                    cmddd.ExecuteNonQuery()

                    'Party will Dr by Service Tax Amount
                    partyservice = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    partyservice &= "'" & GMod.Cmpid & "',"
                    partyservice &= "'" & GMod.username & "',"
                    partyservice &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    partyservice &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    partyservice &= "'" & voudatmul.ToShortDateString & "',"
                    partyservice &= "'" & cmbpartyacccode.Text & "',"
                    partyservice &= "'" & cmbpartyacchead.Text & "',"
                    partyservice &= "'" & txtservicetax.Text & "',"
                    partyservice &= "'CHEQUE',"
                    partyservice &= "'SERVICE TAX PAID',"
                    partyservice &= "'" & Group_name & "',"
                    partyservice &= "'" & Sub_group_name & "',"
                    partyservice &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    partyservice &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    partyservice &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    partyservice &= "'3')"
                    Dim cmd3 As New SqlCommand(partyservice, GMod.SqlConn, sqltrans)
                    cmd3.ExecuteNonQuery()


                    'SERVICE TAX  Cr
                    sqlsavest = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    sqlsavest &= "'" & GMod.Cmpid & "',"
                    sqlsavest &= "'" & GMod.username & "',"
                    sqlsavest &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    sqlsavest &= "'" & voudatmul.ToShortDateString & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(4) & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(5) & "',"
                    sqlsavest &= "'" & txtservicetax.Text & "',"
                    sqlsavest &= "'CHEQUE',"
                    sqlsavest &= "'SERVICE TAX',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(2) & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(3) & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlsavest &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlsavest &= "'6')"
                    'MsgBox(sqlsavest)
                    Dim cmdst As New SqlCommand(sqlsavest, GMod.SqlConn, sqltrans)
                    cmdst.ExecuteNonQuery()


                    'Party will Dr by Cheque Amount of Bank
                    partybank = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    partybank &= "'" & GMod.Cmpid & "',"
                    partybank &= "'" & GMod.username & "',"
                    partybank &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    partybank &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    partybank &= "'" & voudatmul.ToShortDateString & "',"
                    partybank &= "'" & cmbpartyacccode.Text & "',"
                    partybank &= "'" & cmbpartyacchead.Text & "',"
                    partybank &= "'" & txtamount.Text & "',"
                    partybank &= "'CHEQUE',"
                    partybank &= "'BEING CHEQUE RECEIVED AGAINST CHQ NO',"
                    partybank &= "'" & Group_name & "',"
                    partybank &= "'" & Sub_group_name & "',"
                    partybank &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    partybank &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    partybank &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    partybank &= "'1')"

                    Dim cmd4 As New SqlCommand(partybank, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()


                    'BANK for multiple cheque Cr
                    sqlsaveba = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id ) values ("
                    sqlsaveba &= "'" & GMod.Cmpid & "',"
                    sqlsaveba &= "'" & GMod.username & "',"
                    sqlsaveba &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    sqlsaveba &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    sqlsaveba &= "'" & voudatmul.ToShortDateString & "',"
                    sqlsaveba &= "'" & cmbacccode.Text & "',"
                    sqlsaveba &= "'" & cmbacchead.Text & "',"
                    sqlsaveba &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(4) & "',"
                    sqlsaveba &= "'CHEQUE',"
                    sqlsaveba &= "'TO " & cmbpartyacchead.Text & "," & " BY CASH RECEIVED AGAINST CHQ. NO ',"
                    sqlsaveba &= "'BANK',"
                    sqlsaveba &= "'-',"
                    sqlsaveba &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlsaveba &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlsaveba &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlsaveba &= "'8')"
                    'MsgBox(sqlsaveba)
                    Dim cmdba As New SqlCommand(sqlsaveba, GMod.SqlConn, sqltrans)
                    cmdba.ExecuteNonQuery()

                    'Cmp_id, Receipt_id, Issue_date, Chq_date, Cheque_no, BankAcc_code, 
                    'Amount, Dd_Charge_per, Dd_charge, Service_tax, Receipt_amt, party_code, party_name, final_date, favourof, vouno, stop_bounce

                    sqlsavechq = "insert into " & GMod.CHQ_ISSUED & " (Cmp_id, Receipt_id, Issue_date, Chq_date, Cheque_no, BankAcc_code, Amount, Dd_Charge_per, Dd_charge, Service_tax, Receipt_amt, party_code, party_name,favourof,vouno,Rect_type) values ( "
                    sqlsavechq &= "'" & GMod.Cmpid & "',"
                    sqlsavechq &= "'" & Format(Val(GMod.ReciptId) + i, zer1) & "',"
                    sqlsavechq &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlsavechq &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlsavechq &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlsavechq &= "'" & cmbacccode.Text & "',"
                    sqlsavechq &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(4) & "',"
                    sqlsavechq &= "'" & txtddchrgper.Text & "',"
                    sqlsavechq &= "'" & txtddcharges.Text & "',"
                    sqlsavechq &= "'" & txtservicetax.Text & "',"
                    sqlsavechq &= "'" & txtrectamt.Text & "',"
                    sqlsavechq &= "'" & cmbpartyacccode.Text & "',"
                    sqlsavechq &= "'" & cmbpartyacchead.Text & "',"
                    sqlsavechq &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(2) & "',"
                    sqlsavechq &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(7) & "',"
                    sqlsavechq &= "'" & Rect_type & "')"
                    'MsgBox(sqlsavechq)
                    Dim cmdchq As New SqlCommand(sqlsavechq, GMod.SqlConn, sqltrans)
                    cmdchq.ExecuteNonQuery()


                Next
                Dim sqluchq As String
                sqluchq = "update " & GMod.CHQ_ALLOT & " set last_che = '" & GMod.ds.Tables("MultipleChq").Rows(i - 1)(1) & "' Where u_name='" & GMod.username & "' and"
                sqluchq &= " bank_acc_head='" & cmbacccode.Text & "' and Book_no= ( select max(Book_no) from " & GMod.CHQ_ALLOT _
                 & " where U_name='" & GMod.username & "' and bank_acc_head='" & cmbacccode.Text & "')"

                Dim cmduchq As New SqlCommand(sqluchq, GMod.SqlConn, sqltrans)
                cmduchq.ExecuteNonQuery()
                'MsgBox(sqluchq)
                '-------------------------------------------------------------------------------------------------------------------
            Else ' IF AMOUNT IS ZERO THEN DEBIT PARTY 
                Rect_type = "CREDIT" 'FOR PAY TYPE 
                voudatmul = dtchequedate.Value
                'Party 
                'Cmp_id, Chq_no, favourof, recpitid, amount, Chq_date, Uname
                GMod.DataSetRet("select * from tmp_multiple_chq where Cmp_id='" & GMod.Cmpid & "' and uname='" & GMod.username & "'", "MultipleChq")
                Dim i As Integer
                For i = 0 To GMod.ds.Tables("MultipleChq").Rows.Count - 1

                    'Party will Dr by Commision amount
                    partycomm = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    partycomm &= "'" & GMod.Cmpid & "',"
                    partycomm &= "'" & GMod.username & "',"
                    partycomm &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    partycomm &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    partycomm &= "'" & voudatmul.ToShortDateString & "',"
                    partycomm &= "'" & cmbpartyacccode.Text & "',"
                    partycomm &= "'" & cmbpartyacchead.Text & "',"
                    partycomm &= "'" & txtddcharges.Text & "',"
                    partycomm &= "'CHEQUE',"
                    partycomm &= "'DD CHARGES PAID',"
                    partycomm &= "'" & Group_name & "',"
                    partycomm &= "'" & Sub_group_name & "',"
                    partycomm &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    partycomm &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    partycomm &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    partycomm &= "'2')"

                    Dim cmd2 As New SqlCommand(partycomm, GMod.SqlConn, sqltrans)
                    cmd2.ExecuteNonQuery()

                    'DD COMISION Cr
                    sqlsavedd = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    sqlsavedd &= "'" & GMod.Cmpid & "',"
                    sqlsavedd &= "'" & GMod.username & "',"
                    sqlsavedd &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    sqlsavedd &= "'" & voudatmul.ToShortDateString & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(4) & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(5) & "',"
                    sqlsavedd &= "'" & txtddcharges.Text & "',"
                    sqlsavedd &= "'CHEQUE',"
                    sqlsavedd &= "'DD CHARGES',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(2) & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(3) & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlsavedd &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlsavedd &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlsavedd &= "'4')"
                    'MsgBox(sqlsavedd)
                    Dim cmddd As New SqlCommand(sqlsavedd, GMod.SqlConn, sqltrans)
                    cmddd.ExecuteNonQuery()

                    'Party will Dr by Service Tax Amount
                    partyservice = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    partyservice &= "'" & GMod.Cmpid & "',"
                    partyservice &= "'" & GMod.username & "',"
                    partyservice &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    partyservice &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    partyservice &= "'" & voudatmul.ToShortDateString & "',"
                    partyservice &= "'" & cmbpartyacccode.Text & "',"
                    partyservice &= "'" & cmbpartyacchead.Text & "',"
                    partyservice &= "'" & txtservicetax.Text & "',"
                    partyservice &= "'CHEQUE',"
                    partyservice &= "'SERVICE TAX PAID',"
                    partyservice &= "'" & Group_name & "',"
                    partyservice &= "'" & Sub_group_name & "',"
                    partyservice &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    partyservice &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    partyservice &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    partyservice &= "'3')"
                    Dim cmd3 As New SqlCommand(partyservice, GMod.SqlConn, sqltrans)
                    cmd3.ExecuteNonQuery()


                    'SERVICE TAX  Cr
                    sqlsavest = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    sqlsavest &= "'" & GMod.Cmpid & "',"
                    sqlsavest &= "'" & GMod.username & "',"
                    sqlsavest &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    sqlsavest &= "'" & voudatmul.ToShortDateString & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(4) & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(5) & "',"
                    sqlsavest &= "'" & txtservicetax.Text & "',"
                    sqlsavest &= "'CHEQUE',"
                    sqlsavest &= "'SERVICE TAX',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(2) & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("Chq_conf").Rows(1)(3) & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlsavest &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlsavest &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlsavest &= "'6')"
                    'MsgBox(sqlsavest)
                    Dim cmdst As New SqlCommand(sqlsavest, GMod.SqlConn, sqltrans)
                    cmdst.ExecuteNonQuery()


                    'Party will Dr by Cheque Amount of Bank
                    partybank = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id) values ("
                    partybank &= "'" & GMod.Cmpid & "',"
                    partybank &= "'" & GMod.username & "',"
                    partybank &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    partybank &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    partybank &= "'" & voudatmul.ToShortDateString & "',"
                    partybank &= "'" & cmbpartyacccode.Text & "',"
                    partybank &= "'" & cmbpartyacchead.Text & "',"
                    partybank &= "'" & txtamount.Text & "',"
                    partybank &= "'CHEQUE',"
                    partybank &= "'BEING CHEQUE RECEIVED',"
                    partybank &= "'" & Group_name & "',"
                    partybank &= "'" & Sub_group_name & "',"
                    partybank &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    partybank &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    partybank &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    partybank &= "'1')"

                    Dim cmd4 As New SqlCommand(partybank, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()


                    'BANK for multiple cheque Cr
                    sqlsaveba = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, cramt,Pay_mode,Narration, Group_name, Sub_group_name,Cheque_no,Ch_issue_date, Ch_date,Entry_id ) values ("
                    sqlsaveba &= "'" & GMod.Cmpid & "',"
                    sqlsaveba &= "'" & GMod.username & "',"
                    sqlsaveba &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    sqlsaveba &= "'" & GMod.ds.Tables("Chq_conf").Rows(0)(6) & "',"
                    sqlsaveba &= "'" & voudatmul.ToShortDateString & "',"
                    sqlsaveba &= "'" & cmbacccode.Text & "',"
                    sqlsaveba &= "'" & cmbacchead.Text & "',"
                    sqlsaveba &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(4) & "',"
                    sqlsaveba &= "'CHEQUE',"
                    sqlsaveba &= "'TO " & cmbpartyacchead.Text & "," & " BY CASH RECEIVED AGAINST CHQ. NO ',"
                    sqlsaveba &= "'BANK',"
                    sqlsaveba &= "'-',"
                    sqlsaveba &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlsaveba &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlsaveba &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlsaveba &= "'8')"
                    'MsgBox(sqlsaveba)
                    Dim cmdba As New SqlCommand(sqlsaveba, GMod.SqlConn, sqltrans)
                    cmdba.ExecuteNonQuery()




                    'Cmp_id, Receipt_id, Issue_date, Chq_date, Cheque_no, BankAcc_code, 
                    'Amount, Dd_Charge_per, Dd_charge, Service_tax, Receipt_amt, party_code, party_name, final_date, favourof, vouno, stop_bounce

                    sqlsavechq = "insert into " & GMod.CHQ_ISSUED & " (Cmp_id, Receipt_id, Issue_date, Chq_date, Cheque_no, BankAcc_code, Amount, Dd_Charge_per, Dd_charge, Service_tax, Receipt_amt, party_code, party_name,favourof,vouno,Rect_type) values ( "
                    sqlsavechq &= "'" & GMod.Cmpid & "',"
                    sqlsavechq &= "'" & Format(Val(GMod.ReciptId) + i, zer1) & "',"
                    sqlsavechq &= "'" & dtIssuedate.Value.ToShortDateString & "',"
                    sqlsavechq &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(5) & "',"
                    sqlsavechq &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(1) & "',"
                    sqlsavechq &= "'" & cmbacccode.Text & "',"
                    sqlsavechq &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(4) & "',"
                    sqlsavechq &= "'" & txtddchrgper.Text & "',"
                    sqlsavechq &= "'" & txtddcharges.Text & "',"
                    sqlsavechq &= "'" & txtservicetax.Text & "',"
                    sqlsavechq &= "'" & txtrectamt.Text & "',"
                    sqlsavechq &= "'" & cmbpartyacccode.Text & "',"
                    sqlsavechq &= "'" & cmbpartyacchead.Text & "',"
                    sqlsavechq &= "'" & GMod.ds.Tables("MultipleChq").Rows(i)(2) & "',"
                    sqlsavechq &= "'" & Format(Val(GMod.VouNo) + i) & "',"
                    sqlsavechq &= "'" & Rect_type & "')"
                    'MsgBox(sqlsavechq)
                    Dim cmdchq As New SqlCommand(sqlsavechq, GMod.SqlConn, sqltrans)
                    cmdchq.ExecuteNonQuery()

                Next
                'update cheqhe  allotment book of user
                Dim sqluchq As String
                sqluchq = "update " & GMod.CHQ_ALLOT & " set last_che = '" & GMod.ds.Tables("MultipleChq").Rows(i - 1)(1) & "' Where u_name='" & GMod.username & "' and"
                sqluchq &= " bank_acc_head='" & cmbacccode.Text & "' and Book_no= ( select max(Book_no) from " & GMod.CHQ_ALLOT _
                 & " where U_name='" & GMod.username & "' and  bank_acc_head='" & cmbacccode.Text & "')"
                Dim cmduchq As New SqlCommand(sqluchq, GMod.SqlConn, sqltrans)
                cmduchq.ExecuteNonQuery()
            End If
            sqltrans.Commit()
            MsgBox("Cheque voucher's saved", MsgBoxStyle.Information)
        Catch ex As Exception
            sqltrans.Rollback()
            If ex.Message.Contains("PRIMARY KEY") Then
                MsgBox("CHEQUE ALREADY ISSUED", MsgBoxStyle.Critical)
            Else
                MsgBox("Error" & ex.Message)
            End If
        End Try
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        lblchequeno.Text = lastid
        Timer1.Enabled = True
        Try
            'if the party is paying cash payment then thier should be value in txtrecepit (textbaoc)
            'it would genetrate two type of voucher
            '(1) CR VOUCHER for cash recepit
            '(2) BANK for cheque
            'Cash Dr
            'DD Commision Cr
            'Service tax Cr
            'Bank Cr

            'and if party is not paying payment then the thier should be "0" value in txtrecepit (textbaoc)
            'it would genetate only BNAK voucher
            'and pary is Dr
            'Party Dr (with rrecipt amount)
            ''DD Commision Cr
            'Service tax Cr
            'Bank Cr
            'Configration table sequence
            ' Cmp_id, Group_name, Sub_group_name, Acc_Code, Acc_head, Vou_type
            Dim amt As Double
            amt = CDbl(txtrectamt.Text)
            If amt > 0 Then ' Checking for paytype
                Rect_type = "CASH"
            Else
                Rect_type = "CREDIT"
            End If
            nxtrecid()
            If single_multiple = "S" Then
                SingleCheque()
            Else
                MultipleCeque()
            End If
            btnprint_Click(sender, e)
            btnsave.Enabled = False
            btnprint.Enabled = True
        Catch ex As Exception
            MsgBox("Error:-" & ex.Message)
        End Try
        nxtchqno()
        nxtvnoCHQ()
    End Sub
    Dim lastid, SqlGrpsubgrp, Group_name, Sub_group_name, sqlsavecr, sqlsavedd, sqlsavest, sqlsaveba, sqlsavechq, sqlsavepdrccamt, sqlsavepdrst As String
    Sub nxtvnoCHQ()
        Dim j As Integer
        Try
            Dim sql As String
            sql = "SELECT isnull(max(cast (vou_no as numeric(18,0))),0) vou_no FROM " & GMod.VENTRY & " where vou_type='" _
            & GMod.ds.Tables("Chq_conf").Rows(0)(6).ToString & "' and  day(vou_date)=" & dtIssuedate.Value.Day & " and month(vou_date)=" _
            & dtIssuedate.Value.Month & " and year(vou_date)=" & dtIssuedate.Value.Year

            GMod.DataSetRet(sql, "vno")

            If GMod.ds.Tables("vno").Rows(0)(0) <> 0 Then
                For j = 0 To ds.Tables("vno").Rows.Count - 1
                    lastid = ds.Tables("vno").Rows(j)("vou_no")
                Next
                lastid = Val(lastid) + 1
                'lastid = Format(Val(GMod.ds.Tables("vno").Rows(0)(0)) + 1, "000000000000")
            Else
                lastid = dtIssuedate.Value.Year.ToString()
                If dtIssuedate.Value.Month.ToString().Length = 1 Then
                    lastid = lastid & "0" & dtIssuedate.Value.Month.ToString()
                Else
                    lastid = lastid & dtIssuedate.Value.Month.ToString()
                End If
                If dtIssuedate.Value.Day.ToString() = 1 Then
                    lastid = lastid & "0" & dtIssuedate.Value.Day.ToString()
                Else
                    lastid = lastid & dtIssuedate.Value.Day.ToString()
                End If
                lastid = lastid & Format(1, "0000")
            End If
            lblchequeno.Text = lastid
            lblvouno.Text = lastid
            GMod.VouNo = lastid
        Catch ex As Exception
            MsgBox("Voucher No error:" & ex.Message)
        End Try

    End Sub
    Dim recid As String
    Private Sub btnchangerepno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangerepno.Click
        Timer1.Enabled = False
        recid = InputBox("Input Recepit ID?")
        lblrecno.Text = recid
        If MessageBox.Show("DO WANT TO  SAVE", "SAVE CHEQUE", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            btnsave_Click(sender, e)
        End If
    End Sub
    Dim dramt As Double
    Private Sub txtservicetax_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtservicetax.Leave

    End Sub
    Private Sub cmbfavourof_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfavourof.Leave
        If cmbfavourof.FindStringExact(cmbfavourof.Text) = -1 Then
            GMod.SqlExecuteNonQuery("Insert into favof values ('" & cmbfavourof.Text & "')")
            'MsgBox("Valid")
        Else
            'MsgBox("In Valid")
        End If
    End Sub
    Dim pp, qq As Integer, noofcheque As String

    Private Sub btnaddmultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddmultiple.Click
        nxtvnoCHQ()
        single_multiple = "M"
        If txtchqno.Text = "" Then
            MsgBox("Cheque No. cant't be blank")
            txtchqno.Focus()
            Exit Sub
        End If
        btnaddmultiple.Enabled = True
        btnsave.Enabled = False
        btnaddsingle.Enabled = False
        btndelete.Enabled = False
        btnprint.Enabled = False
        btnprintall.Enabled = False
        'btnprintvoucher.Enabled = False
        If MessageBox.Show("Are U want same name in favour of or random name", "Multiple Cheque ", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ramdom = False
        Else
            ramdom = True
        End If
        noofcheque = InputBox("HOW MANY NO OF CHEQUES?")
        GMod.damount = Val(txtamount.Text)
        Try
            GMod.no_of_cheque = noofcheque
            GMod.Chq_no = txtchqno.Text
            GMod.ReciptId = lblrecno.Text
            GMod.favourof = cmbfavourof.Text
            GMod.chq_date = dtchequedate.Value
            GMod.damount = CDbl(txtamount.Text)
            GMod.VouNo = lastid
            Dim t As New frmMultiChequeList
            t.lblrect_type.Text = Rect_type
            t.ShowDialog()
            btnsave.Enabled = True
            btnsave_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub txtchqno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchqno.Leave
        If txtchqno.Text = "" Then
            MsgBox("Cheque No. cant't be blank")
            txtchqno.Focus()
        Else
            Dim sql As String
            sql = "select Cheque_no from " & GMod.CHQ_ISSUED & " where Cheque_no='" & txtchqno.Text & "' and bankacc_code='" & cmbacccode.Text & "'"
            GMod.DataSetRet(sql, "duplichq")
            If GMod.ds.Tables("duplichq").Rows.Count > 0 Then
                MsgBox("CHEQUE ALREADY ISSUED", MsgBoxStyle.Critical, "ERROR")
                txtchqno.Focus()
            End If
        End If
    End Sub
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim sqlupdate As String
        GMod.DataSetRet("select * from dbo.chqLayout where acc_head_code='" & cmbacccode.Text & "'", "ChqLayout")
        If GMod.ds.Tables("ChqLayout").Rows.Count > 0 Then
            Dim i As Integer = 0
            Try
                GMod.DataSetRet("select * from tmp_multiple_chq where Cmp_id='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'", "chqdet")
                GMod.DataSetRet("select * from chqlayout where acc_head_code='" & cmbacccode.Text & "'", "chq")
                chqprintpreview.Document = chqdocument
                ' If MessageBox.Show("Do U want to print cheque" & "(" & ivar + 1 & ")" & "St Cheque", "Print", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                For ivar = 0 To GMod.ds.Tables("chqdet").Rows.Count - 1
                    If MessageBox.Show("Do U want to print cheque" & "(" & ivar + 1 & ")" & "St Cheque", "Print", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        chqdocument.DefaultPageSettings = chqsetup.PageSettings
                        ' Dim customPaperSize As New Printing.PaperSize("8x10", Val(GMod.ds.Tables("chq").Rows(0)("cqhh")), Val(GMod.ds.Tables("chq").Rows(0)("chqw")))
                        chqdocument.Print()
                        sqlupdate = "update " & GMod.CHQ_ISSUED & " set IsPrinted = 'P' where Cheque_no='" & GMod.ds.Tables("chqdet").Rows(ivar)("Chq_no").ToString & "'"
                        GMod.SqlExecuteNonQuery(sqlupdate)
                    End If
                Next
                'Else
                'End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'Disabling buttons
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnprint.Enabled = False
            btnprintall.Enabled = False
            'btnprintvoucher.Enabled = False
            btnaddsingle.Enabled = True
            btnaddmultiple.Enabled = True
            txtamount.Text = "0.00"
            txtddcharges.Text = "0.00"
            txtddchrgper.Text = "0.00"
            txtrectamt.Text = "0.00"
            txtsertaxper.Text = "0.00"
            txtsertaxper.Text = "0.00"
            txtservicetax.Text = "0.00"
            dtIssuedate.Focus()
        Else
            MsgBox("Please Save Cheque Layuot for this bank", MsgBoxStyle.Critical)
        End If
    End Sub
    Dim ivar As Integer
    Dim headfont As Font
    Dim bodyfont As Font
    Dim sp(3) As String
    Dim amountstr As String
    Private Sub chqdocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles chqdocument.PrintPage
        headfont = New Font("arial", 11, FontStyle.Bold)
        bodyfont = New Font("Arial", 10)
        e.Graphics.DrawString(ChangeDateFormat(GMod.ds.Tables("chqdet").Rows(ivar)("Chq_date")), bodyfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("chq_datex"), GMod.ds.Tables("chq").Rows(0)("chq_datey"))
        spliter(titlecase(GMod.ds.Tables("chqdet").Rows(ivar)("favourof").ToString))
        e.Graphics.DrawString(sp(0), headfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("infavx"), GMod.ds.Tables("chq").Rows(0)("infavy"))
        e.Graphics.DrawString(sp(1), headfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("infavx1"), GMod.ds.Tables("chq").Rows(0)("infavy1"))
        spliter(titlecase(splitNumber(GMod.ds.Tables("chqdet").Rows(0)("amount").ToString).TrimEnd) & "Only")
        e.Graphics.DrawString(sp(0), bodyfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("amtinwx"), GMod.ds.Tables("chq").Rows(0)("amtinwy"))
        e.Graphics.DrawString(sp(1), bodyfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("amtinwx1"), GMod.ds.Tables("chq").Rows(0)("amtinwy1"))
        e.Graphics.DrawString(GMod.ds.Tables("chqdet").Rows(ivar)("amount").ToString.PadLeft(12, "*"), headfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("amtx"), GMod.ds.Tables("chq").Rows(0)("amty"))
    End Sub
    Function titlecase(ByVal str As String) As String
        Dim ar(), st As String
        ar = str.Split(" ")
        Dim i As Integer
        For i = 0 To ar.Length - 1
            st = st & ar(i).Substring(0, 1).ToUpper & (ar(i).Substring(1, ar(i).Length - 1).ToLower) & " "
        Next
        titlecase = st
    End Function

    Function ChangeDateFormat(ByVal dd As String) As String
        Dim gdate() As String
        gdate = dd.Split("/")
        ChangeDateFormat = gdate(1) & "/" & gdate(0) & "/" & gdate(2)
    End Function

    Function splitNumber(ByVal number As String) As String
        Dim num() As String
        Dim retval As String
        num = number.Split(".")
        If num(1) = "00" Then
            retval = NameOfNumber(num(0), True, 9999)
        Else
            retval = NameOfNumber(num(0), True, 9999) & "and "
            retval &= NameOfNumber(num(1), True, 9999) & "paise"
        End If
        splitNumber = retval
    End Function
    Sub spliter(ByVal st As String)
        Try
            Dim word() As String
            word = st.Split(" ")
            sp(0) = ""
            sp(1) = ""
            Dim i As Integer
            For i = 0 To word.Length - 1
                If sp(0).Length < 50 Then
                    sp(0) = sp(0) & word(i) & " "
                Else
                    sp(1) = sp(1) & word(i) & " "
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
    Private Sub dtchequedate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtchequedate.ValueChanged
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        spliter("New System.Drawing.Printing.PaperSize(A4 (210 x 297 mm)")
        'MsgBox(sp(0))
        'MsgBox(sp(1))
    End Sub
    Private Sub cmbacccode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacccode.SelectedIndexChanged
        nxtchqno()
    End Sub
  

    Private Sub txtamount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        'MsgBox(Asc(e.KeyChar.ToString()))
        If (Asc(e.KeyChar.ToString()) > 47 And Asc(e.KeyChar.ToString()) < 58) Or Asc(e.KeyChar.ToString()) = 8 Or Asc(e.KeyChar.ToString()) = 46 Or Asc(e.KeyChar.ToString()) = 13 Then

        Else
            MessageBox.Show("Only numeric value is allowed")
            e.Handled = True
        End If
    End Sub

    Private Sub txtddchrgper_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtddchrgper.KeyPress
        'MsgBox(Asc(e.KeyChar.ToString()))
        If (Asc(e.KeyChar.ToString()) > 47 And Asc(e.KeyChar.ToString()) < 58) Or Asc(e.KeyChar.ToString()) = 8 Or Asc(e.KeyChar.ToString()) = 46 Or Asc(e.KeyChar.ToString()) = 13 Then

        Else
            MessageBox.Show("Only numeric value is allowed")
            e.Handled = True
        End If
    End Sub

    Private Sub txtddcharges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtddcharges.KeyPress
        'MsgBox(Asc(e.KeyChar.ToString()))
        If (Asc(e.KeyChar.ToString()) > 47 And Asc(e.KeyChar.ToString()) < 58) Or Asc(e.KeyChar.ToString()) = 8 Or Asc(e.KeyChar.ToString()) = 46 Or Asc(e.KeyChar.ToString()) = 13 Then

        Else
            MessageBox.Show("Only numeric value is allowed")
            e.Handled = True
        End If
    End Sub

    Private Sub txtsertaxper_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsertaxper.KeyPress
        'MsgBox(Asc(e.KeyChar.ToString()))
        If (Asc(e.KeyChar.ToString()) > 47 And Asc(e.KeyChar.ToString()) < 58) Or Asc(e.KeyChar.ToString()) = 8 Or Asc(e.KeyChar.ToString()) = 46 Or Asc(e.KeyChar.ToString()) = 13 Then

        Else
            MessageBox.Show("Only numeric value is allowed")
            e.Handled = True
        End If
    End Sub



    Private Sub txtrectamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrectamt.KeyPress
        'MsgBox(Asc(e.KeyChar.ToString()))
        If (Asc(e.KeyChar.ToString()) > 47 And Asc(e.KeyChar.ToString()) < 58) Or Asc(e.KeyChar.ToString()) = 8 Or Asc(e.KeyChar.ToString()) = 46 Or Asc(e.KeyChar.ToString()) = 13 Then

        Else
            MessageBox.Show("Only numeric value is allowed")
            e.Handled = True
        End If
    End Sub

    Private Sub txtservicetax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtservicetax.KeyPress
        'MsgBox(Asc(e.KeyChar.ToString()))
        If (Asc(e.KeyChar.ToString()) > 47 And Asc(e.KeyChar.ToString()) < 58) Or Asc(e.KeyChar.ToString()) = 8 Or Asc(e.KeyChar.ToString()) = 46 Or Asc(e.KeyChar.ToString()) = 13 Then

        Else
            MessageBox.Show("Only numeric value is allowed")
            e.Handled = True
        End If
    End Sub

    Private Sub btnprintvoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintvoucher.Click

        txtamount.Text = "0.00"
        txtddcharges.Text = "0.00"
        txtddchrgper.Text = "0.00"
        txtrectamt.Text = "0.00"
        txtsertaxper.Text = "0.00"
        txtsertaxper.Text = "0.00"
        txtservicetax.Text = "0.00"
        'Disabling buttons
        btnaddsingle.Enabled = True
        btnaddmultiple.Enabled = True
        btndelete.Enabled = False
        btnsave.Enabled = False
        btnprint.Enabled = False
        btnprintall.Enabled = False
        dtIssuedate.Focus()
        CheckBox3_CheckedChanged(sender, e)
        nxtrecid()
        'btnprintvoucher.Enabled = False
    End Sub

    Private Sub cmbpartyacchead_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpartyacchead.Leave
        Try
            If cmbpartyacchead.FindStringExact(cmbpartyacchead.Text) = -1 Then
                MsgBox("Invalid party Name", MsgBoxStyle.Critical, "Error")
                cmbpartyacchead.Focus()
                Exit Sub
            End If
            'Getting Group and sub gropu from Acc_head table on basis of Acc_code
            SqlGrpsubgrp = "select group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_code = '" & cmbpartyacccode.Text & "'"
            GMod.DataSetRet(SqlGrpsubgrp, "Grp_Sub")
            Group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(0)
            Sub_group_name = GMod.ds.Tables("Grp_Sub").Rows(0)(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmChequeIssued_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        GMod.ds.Tables.Clear()
        Timer1.Enabled = False
    End Sub
    Private Sub cmbacccode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacccode.Leave
        If cmbacccode.FindStringExact(cmbacccode.Text) = -1 Then
            MsgBox("Invalid Bank Code", MsgBoxStyle.Critical, "Error")
            cmbacccode.Focus()
        End If
    End Sub
    Private Sub cmbacchead_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacchead.Leave
        If cmbacchead.FindStringExact(cmbacchead.Text) = -1 Then
            MsgBox("Invalid Bank Name", MsgBoxStyle.Critical)
            cmbacchead.Focus()
        End If
    End Sub
    Private Sub cmbpartyacccode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpartyacccode.Leave
        If cmbpartyacccode.FindStringExact(cmbpartyacccode.Text) = -1 Then
            MsgBox("Invalid Party Code", MsgBoxStyle.Critical)
            cmbpartyacccode.Focus()
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Dim achead As New frmPartyaccount
            achead.ShowDialog()
            rdParty_CheckedChanged(sender, e)
            CheckBox2.Checked = False
            cmbacchead.Focus()
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim achead As New frmGeneralacchead
            achead.ShowDialog()
            rdother_CheckedChanged(sender, e)
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub txtrectamt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrectamt.Enter
        Try
            dramt = Val(txtamount.Text) + Val(txtservicetax.Text) + Val(txtddcharges.Text)
            txtrectamt.Text = dramt.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtchqno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchqno.KeyPress
        If (Asc(e.KeyChar.ToString()) > 47 And Asc(e.KeyChar.ToString()) < 58) Or Asc(e.KeyChar.ToString()) = 8 Or Asc(e.KeyChar.ToString()) = 46 Or Asc(e.KeyChar.ToString()) = 13 Then

        Else
            MessageBox.Show("Only numeric value is allowed")
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        nxtrecid()
        'MsgBox("adad")
    End Sub

    Private Sub dtIssuedate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtIssuedate.Leave
        If GMod.Session = GMod.Getsession(dtIssuedate.Value) Then

        Else
            MsgBox("You are trying to enter data of differnrt session")
            dtIssuedate.Focus()
        End If
    End Sub

    Private Sub txtchqno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchqno.TextChanged

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nxtvnoCHQ()
    End Sub

   
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Dim sqlsave As String
            sqlsave = "select sum(dramt) dramt,sum(cramt) from VENTRY_RAFI_0809 " _
            & " where acc_head='CASH' and vou_date ='" & dtIssuedate.Value.ToShortDateString & "'"
            'sqlsave = " select '" & GMod.Cmpid & "','TOTAL','-',sum(dramt) dramt,sum(cramt) cramt,'" & GMod.username _
            ' & "' from " & GMod.VENTRY & " where vou_date ='" & dtIssuedate.Value.ToShortDateString & "'"
            GMod.DataSetRet(sqlsave, "daytot")
            CheckBox3.Text = Val(GMod.ds.Tables("daytot").Rows(0)(0).ToString) - Val(GMod.ds.Tables("daytot").Rows(0)(1).ToString)
        Else
            CheckBox3.Text = "-"
        End If
    End Sub

    Private Sub cmbacchead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacchead.SelectedIndexChanged

    End Sub
End Class