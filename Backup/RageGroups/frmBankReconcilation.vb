Public Class frmBankReconcilation

    Private Sub frmBankReconcilation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        'Seeting Session Start DATE
        Dim sdate As String = "4/1/" & GMod.Session.Substring(0, 2).ToString
        dtfrom.Value = CDate(sdate)
        fillArea()
        cmbAreaCode.Text = "JB"
        'cmbgrpname.SelectedIndex = 0

        Try
            Dim sql As String
            sql = "select account_code,account_head_name,group_name,sub_group_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                   & " and group_name in ('BANK') order by account_head_name"
            GMod.DataSetRet(sql, "bank")
            cmbacheadcode.DataSource = GMod.ds.Tables("bank")
            cmbacheadcode.DisplayMember = "account_code"
            cmbacheadname.DataSource = GMod.ds.Tables("bank")
            cmbacheadname.DisplayMember = "account_head_name"


            cmbgrpname.DataSource = GMod.ds.Tables("bank")
            cmbgrpname.DisplayMember = "group_name"

            cmbsubgrpname.DataSource = GMod.ds.Tables("bank")
            cmbsubgrpname.DisplayMember = "sub_group_name"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CrViewerBankrec.Height = Me.Height - 180
        dg.Top = CrViewerBankrec.Top
        dg.Left = CrViewerBankrec.Left
        dg.Width = CrViewerBankrec.Width
        dg.Height = CrViewerBankrec.Height
    End Sub
    Dim opening, opnbakstate, opndiff As Double 'Actuallay Opeing is Closing Balace
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
    End Sub

    Public Sub CalcBankOpening()
        Try
            Dim sqlopen As String

            Dim sqlopeningbal As String = " select isnull(opening_dr,0) - isnull(opening_cr,0)  from " _
                                          & GMod.ACC_HEAD & " where account_code= '" & cmbacheadcode.Text & "'"
            GMod.DataSetRet(sqlopeningbal, "opeingbal")
            opening = CDbl(GMod.ds.Tables("opeingbal").Rows(0)(0).ToString)

            sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                                & " " & GMod.VENTRY & " where Acc_head_code='" & cmbacheadcode.Text & "' and  vou_date<='" & dtTo.Text & "' and vou_type<>'BANKREC'"

            GMod.DataSetRet(sqlopen, "opeingbal")
            opening = opening + CDbl(GMod.ds.Tables("opeingbal").Rows(0)(0).ToString)
            'MsgBox(opening.ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub OpeningBankStatement(ByVal dt As DateTime)
        Try
            Dim sqlopenbankstate As String

            Dim sqlopeningbanstate As String = " select isnull(dramt,0) - isnull(cramt,0)  from " _
                                          & GMod.BANK_STATE_OPEN & " where bank_acc_code= '" & cmbacheadcode.Text & "'"
            GMod.DataSetRet(sqlopeningbanstate, "opeingbalbank")

            opnbakstate = Convert.ToDouble(GMod.ds.Tables("opeingbalbank").Rows(0)(0).ToString)

            sqlopenbankstate = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                                & " " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacheadcode.Text & "' and  bankedate<='" & dt & "'"

            GMod.ds.Tables("opeingbalbank").Clear()
            GMod.DataSetRet(sqlopenbankstate, "opeingbalbank")
            opnbakstate = opnbakstate + CDbl(GMod.ds.Tables("opeingbalbank").Rows(0)(0).ToString)
            'MsgBox(opnbakstate.ToString)

        Catch ex As Exception
            If ex.Message.Contains("0") Then
                MsgBox("Please enter Bank opening", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message)
            End If

        End Try
        'MsgBox(opening.ToString)
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        dg.BringToFront()
        Try
            GMod.SqlExecuteNonQuery("delete from Bank_rec")
            CalcBankOpening() 'for compuring bank Closing
            ' If opening >= 0 Then
            'econDr()
            'else() 
            'reconCr()
            'reconCrBackDate()
            'End If
            recon2()
            recon4()

        Catch ex As Exception
            MsgBox("Main" & ex.Message)
        End Try

        Try
            Dim Sql, sqlsummary As String
            Dim i, j, r As Integer
            Sql = "select distinct(rec_head) from Bank_rec order by rec_head"
            GMod.DataSetRet(Sql, "recon1")
            dg.Rows.Clear()
            r = 0
            For i = 0 To ds.Tables("recon1").Rows.Count - 1
                dg.Rows.Add()
                dg(0, r).Style.BackColor = Color.SteelBlue
                dg(1, r).Style.BackColor = Color.SteelBlue
                dg(2, r).Style.BackColor = Color.SteelBlue
                dg(3, r).Style.BackColor = Color.SteelBlue
                dg(0, r).Style.ForeColor = Color.Yellow
                dg(1, r).Style.ForeColor = Color.Yellow
                dg(2, r).Style.ForeColor = Color.Yellow
                dg(3, r).Style.ForeColor = Color.Yellow
                dg(0, r).Value = GMod.ds.Tables("recon1").Rows(i)(0)
                Sql = "select * from bank_rec where rec_head='" & GMod.ds.Tables("recon1").Rows(i)(0) & "' order by rec_head,issue_date"
                GMod.DataSetRet(Sql, "recon11")
                r = r + 1
                For j = 0 To GMod.ds.Tables("recon11").Rows.Count - 1
                    dg.Rows.Add()
                    dg(1, r).Value = GMod.ds.Tables("recon11").Rows(j)("issue_date")
                    dg(2, r).Value = GMod.ds.Tables("recon11").Rows(j)("Chq_no")
                    dg(3, r).Value = GMod.ds.Tables("recon11").Rows(j)("amt")
                    r = r + 1
                Next
                sqlsummary = "select sum(Amt) from bank_rec where rec_head='" & GMod.ds.Tables("recon1").Rows(i)(0) & "'"
                GMod.DataSetRet(sqlsummary, "tt")
                dg.Rows.Add()
                dg(0, r).Style.BackColor = Color.Aqua
                dg(1, r).Style.BackColor = Color.Aqua
                dg(2, r).Style.BackColor = Color.Aqua
                dg(3, r).Style.BackColor = Color.Aqua
                dg(0, r).Value = "Total of " & GMod.ds.Tables("recon1").Rows(i)(0).ToString.Substring(2, GMod.ds.Tables("recon1").Rows(i)(0).ToString.Length - 2)
                dg(3, r).Value = GMod.ds.Tables("tt").Rows(0)(0)
                r = r + 1
            Next
            dg.Rows.Add()
            dg(0, r).Style.BackColor = Color.Red
            dg(1, r).Style.BackColor = Color.Red
            dg(2, r).Style.BackColor = Color.Red
            dg(3, r).Style.BackColor = Color.Red
            dg(0, r).Value = "SUMMARY"
            r = r + 1
            dg.Rows.Add()
            Dim a, b, c, d, e1 As Double
            '1.Balance As per Our Book
            sqlsummary = "select sum(Amt) from bank_rec where rec_head='1.Balance As per Our Book'"
            GMod.DataSetRet(sqlsummary, "One")
            If GMod.ds.Tables("One").Rows.Count > 0 Then
                dg(0, r).Value = "Balance as Per Book"
                dg(3, r).Value = Val(GMod.ds.Tables("One").Rows(0)(0).ToString)
                a = Val(GMod.ds.Tables("One").Rows(0)(0).ToString)
            Else
                dg(0, r).Value = "Balance as Per Book"
                dg(3, r).Value = "0"
                a = 0
            End If
            '2.ADD: Amount Credited by bank
            r = r + 1
            dg.Rows.Add()
            sqlsummary = "select sum(Amt) from bank_rec where rec_head='2.ADD: Amount Credited by bank'"
            GMod.DataSetRet(sqlsummary, "Two")
            If GMod.ds.Tables("Two").Rows.Count > 0 Then
                dg(0, r).Value = "Amount Credited by Bank"
                dg(3, r).Value = Val(GMod.ds.Tables("Two").Rows(0)(0).ToString)
                b = Val(GMod.ds.Tables("Two").Rows(0)(0).ToString)
            Else
                dg(0, r).Value = "Amount Credited by Bank"
                dg(3, r).Value = "0"
                b = 0
            End If
            '3.LESS: Amount Debited by bank
            r = r + 1
            dg.Rows.Add()
            sqlsummary = "select sum(Amt) from bank_rec where rec_head='3.LESS: Amount Debited by bank'"
            GMod.DataSetRet(sqlsummary, "Three")
            If GMod.ds.Tables("Three").Rows.Count > 0 Then
                dg(0, r).Value = "Amount Debited by Bank"
                dg(3, r).Value = Val(GMod.ds.Tables("Three").Rows(0)(0).ToString)
                c = Val(GMod.ds.Tables("Three").Rows(0)(0).ToString)
            Else
                dg(0, r).Value = "Amount Debited by Bank"
                dg(3, r).Value = "0"
                c = 0
            End If

            '4.ADD: Cheque issued but not present
            r = r + 1
            dg.Rows.Add()
            sqlsummary = "select sum(Amt) from bank_rec where rec_head='4.ADD: Cheque issued but not present'"
            GMod.DataSetRet(sqlsummary, "Four")
            If GMod.ds.Tables("Four").Rows.Count > 0 Then
                dg(0, r).Value = "Cheque Issued but not Present"
                dg(3, r).Value = Val(GMod.ds.Tables("Four").Rows(0)(0).ToString)
                d = Val(GMod.ds.Tables("Four").Rows(0)(0).ToString)
            Else
                dg(0, r).Value = "Cheque Issued but not Present"
                dg(3, r).Value = "0"
                d = 0
            End If

            '5.LESS: Cheque deposite but not cleared by bank
            r = r + 1
            dg.Rows.Add()
            sqlsummary = "select sum(Amt) from bank_rec where rec_head='5.LESS: Cheque deposite but not cleared by bank'"
            GMod.DataSetRet(sqlsummary, "Five")
            If GMod.ds.Tables("Five").Rows.Count > 0 Then
                dg(0, r).Value = "Cheque deposite but not cleared by bank"
                dg(3, r).Value = Val(GMod.ds.Tables("Five").Rows(0)(0).ToString)
                e1 = Val(GMod.ds.Tables("Five").Rows(0)(0).ToString)
            Else
                dg(0, r).Value = "Cheque deposite but not cleared by bank"
                dg(3, r).Value = "0"
                e1 = 0
            End If
            r = r + 1
            dg.Rows.Add()
            dg(0, r).Value = "Balance as per Bank Statement"
            dg(3, r).Value = (a + b + d) - (c + e1)

            'cr.SetParameterValue("baspb", opening)
            '' If opening < 0 Then
            'cr.SetParameterValue("f1", "ADD")
            'cr.SetParameterValue("f2", "LESS")
            'cr.SetParameterValue("f3", "ADD")
            'cr.SetParameterValue("f4", "LESS")
            ' Else
            'cr.SetParameterValue("f1", "LESS")
            'cr.SetParameterValue("f2", "ADD")
            'cr.SetParameterValue("f3", "LESS")
            'cr.SetParameterValue("f4", "ADD")
            'End If


            'Dim cr As New CrBankrec

            'Dim bankbal, bal, addamt, lessamt As Double

            'cr.SetDataSource(GMod.ds.Tables("recon1"))
            'cr.SetParameterValue("cname", GMod.Cmpname)
            'cr.SetParameterValue("head1", "Bank Reconcilation between " & dtfrom.Text & " and " & dtTo.Text)
            'cr.SetParameterValue("head2", cmbacheadcode.Text & " - " & cmbacheadname.Text)

            ''--------------Passing Pramerte---------
            'Dim sqlSummary As String
            ''1.Balance As per Our Book
            'sqlsummary = "select sum(Amt) from bank_rec where rec_head='1.Balance As per Our Book'"
            'GMod.DataSetRet(sqlsummary, "One")
            'If GMod.ds.Tables("One").Rows.Count > 0 Then
            '    cr.SetParameterValue("a", Val(GMod.ds.Tables("One").Rows(0)(0).ToString))
            'Else
            '    cr.SetParameterValue("a", 0)
            'End If
            ''2.ADD: Amount Credited by bank
            'sqlsummary = "select sum(Amt) from bank_rec where rec_head='2.ADD: Amount Credited by bank'"
            'GMod.DataSetRet(sqlsummary, "Two")
            'If GMod.ds.Tables("Two").Rows.Count > 0 Then
            '    cr.SetParameterValue("b", Val(GMod.ds.Tables("Two").Rows(0)(0).ToString))
            'Else
            '    cr.SetParameterValue("b", 0)
            'End If
            ''3.LESS: Amount Debited by bank
            'sqlsummary = "select sum(Amt) from bank_rec where rec_head='3.LESS: Amount Debited by bank'"
            'GMod.DataSetRet(sqlsummary, "Three")
            'If GMod.ds.Tables("Three").Rows.Count > 0 Then
            '    cr.SetParameterValue("c", Val(GMod.ds.Tables("Three").Rows(0)(0).ToString))
            'Else
            '    cr.SetParameterValue("c", 0)
            'End If

            ''4.ADD: Cheque issued but not present
            'sqlsummary = "select sum(Amt) from bank_rec where rec_head='4.ADD: Cheque issued but not present'"
            'GMod.DataSetRet(sqlsummary, "Four")
            'If GMod.ds.Tables("Four").Rows.Count > 0 Then
            '    cr.SetParameterValue("d", Val(GMod.ds.Tables("Four").Rows(0)(0).ToString))
            'Else
            '    cr.SetParameterValue("d", 0)
            'End If

            ''5.LESS: Cheque deposite but not cleared by bank
            'sqlsummary = "select sum(Amt) from bank_rec where rec_head='5.LESS: Cheque deposite but not cleared by bank'"
            'GMod.DataSetRet(sqlsummary, "Five")
            'If GMod.ds.Tables("Five").Rows.Count > 0 Then
            '    cr.SetParameterValue("e", Val(GMod.ds.Tables("Five").Rows(0)(0).ToString))
            'Else
            '    cr.SetParameterValue("e", 0)
            'End If
            'cr.SetParameterValue("baspb", opening)
            '' If opening < 0 Then
            'cr.SetParameterValue("f1", "ADD")
            'cr.SetParameterValue("f2", "LESS")
            'cr.SetParameterValue("f3", "ADD")
            'cr.SetParameterValue("f4", "LESS")
            '' Else
            ''cr.SetParameterValue("f1", "LESS")
            ''cr.SetParameterValue("f2", "ADD")
            ''cr.SetParameterValue("f3", "LESS")
            ''cr.SetParameterValue("f4", "ADD")
            ''End If
            ''---------------------------------------------------------------
            'CrViewerBankrec.ReportSource = cr

        Catch ex As Exception
            MsgBox("display " & ex.Message)
        End Try
        
    End Sub
    Dim tr As Integer
    Dim bs1() As Date
    Dim bs2() As String
    Dim bs3() As Double
    Dim bs4() As Double
    Dim bs5() As String
    Dim bs6() As String
    Dim bs7() As Date

    Sub recon2()
        'Try
        'Dim recchoice As Boolean = False
        'If MsgBox("Are you want reconcile all entries [Yes] or only unreconciled entries [No]", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    recchoice = True
        'End If
        Dim getres As String
        Dim i, j As Integer
        Dim tr1, tr2 As Integer
        Dim prchq As String
        Dim sql As String


        '1. Balance as per our book

        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        sql &= "'1.Balance As per Our Book',"
        sql &= "'-',"
        sql &= "'-',"
        sql &= "'" & dtTo.Text & "',"
        sql &= "'-',"
        sql &= "'" & opening & "')"
        'MsgBox(sql)
        getres = GMod.SqlExecuteNonQuery(sql)
        '*******************************************************************************************************
        'CHEQUE RECONSILE WHILE DOES NOT EXIST
        sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
        & " select '4.ADD: Cheque issued but not present',vou_date,cheque_no,cramt  from " & GMod.VENTRY & " v " _
        & " where cheque_no not in (select chddno from " & GMod.BANK_STATE & " b " _
        & " where v.cramt=b.dramt and v.dramt=b.cramt and b.bank_acc_code=v.acc_head_code and b.paytype='CHEQUE'" _
        & " and b.bankedate<='" & dtTo.Value.ToShortDateString & "') " _
        & " and v.acc_head_code='" & cmbacheadcode.Text & "' and pay_mode='CHEQUE' and v.vou_date<='" & dtTo.Value.ToShortDateString & "' and v.cramt>0 "
        GMod.SqlExecuteNonQuery(sql)

        sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                & " select '5.LESS: Cheque deposite but not cleared by bank',vou_date,cheque_no,dramt  from " & GMod.VENTRY & " v " _
                & " where cheque_no not in (select chddno from " & GMod.BANK_STATE & " b " _
                & " where v.cramt=b.dramt and v.dramt=b.cramt and b.bank_acc_code=v.acc_head_code and b.paytype='CHEQUE'" _
                & " and b.bankedate<='" & dtTo.Value.ToShortDateString & "') " _
                & " and v.acc_head_code='" & cmbacheadcode.Text & "' and pay_mode='CHEQUE' and v.vou_date<='" & dtTo.Value.ToShortDateString & "' and v.dramt>0 "
        GMod.SqlExecuteNonQuery(sql)

        sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
        & " select '3.LESS: Amount Debited by bank',bankedate,chddno,dramt from " & GMod.BANK_STATE & " b " _
        & " where chddno not in (select cheque_no from " & GMod.VENTRY & " v where b.bank_acc_code=v.acc_head_code " _
        & " and v.pay_mode='CHEQUE' and b.dramt=v.cramt and vou_date<='" & dtTo.Value.ToShortDateString & "') " _
        & " and b.bank_acc_code='" & cmbacheadcode.Text & "' and b.paytype='CHEQUE' and b.bankedate<='" & dtTo.Value.ToShortDateString & "' and  b.dramt>0 "
        GMod.SqlExecuteNonQuery(sql)



        sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                & " select '2.ADD: Amount Credited by bank',bankedate,chddno,cramt from " & GMod.BANK_STATE & " b " _
                & " where chddno not in (select cheque_no from " & GMod.VENTRY & " v where b.bank_acc_code=v.acc_head_code " _
                & " and v.pay_mode='CHEQUE' and b.cramt=v.dramt and vou_date<='" & dtTo.Value.ToShortDateString & "') " _
                & " and b.bank_acc_code='" & cmbacheadcode.Text & "' and b.paytype='CHEQUE' and b.bankedate<='" & dtTo.Value.ToShortDateString & "' and  b.cramt>0 "
        GMod.SqlExecuteNonQuery(sql)
        'search for the multiple cheques
        Dim k As Integer
        Dim pramt As Double
        sql = "select * from (select cheque_no,acc_head_code,count(*) cntventry " _
        & " from " & GMod.VENTRY & " where pay_mode='CHEQUE' and acc_head_code='" & cmbacheadcode.Text & "'" _
        & " and vou_date<='" & dtTo.Value.ToShortDateString & "'" _
        & " group by cheque_no,acc_head_code) t1 full outer join " _
        & " (select chddno,bank_acc_code,count(*) cntbank " _
        & " from " & GMod.BANK_STATE & " where paytype='CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "'" _
        & " and bankedate<='" & dtTo.Value.ToShortDateString & "' group by chddno,bank_acc_code)t2 on " _
        & " t2.chddno=t1.cheque_no and t2.bank_acc_code = t1.acc_head_code" _
        & " where(t2.cntbank > 1 And t1.cntventry <> t2.cntbank)"
        GMod.DataSetRet(sql, "mchq")
        For i = 0 To GMod.ds.Tables("mchq").Rows.Count - 1
            sql = "delete from bank_rec where chq_no='" & GMod.ds.Tables("mchq").Rows(i)("chddno") & "'"
            GMod.SqlExecuteNonQuery(sql)
            'If GMod.ds.Tables("RECCOUNT").Rows.Count = 0 Then
            If GMod.ds.Tables("mchq").Rows(i)("cntventry") > GMod.ds.Tables("mchq").Rows(i)("cntbank") Then
                'more entry in our bank book
                'search more cheque in DR side our book
                sql = "select * from " & GMod.VENTRY & " where cheque_no='" & GMod.ds.Tables("mchq").Rows(i)("cheque_no") & "'" _
                & " and acc_head_code='" & cmbacheadcode.Text & "' and vou_date<='" & dtTo.Value.ToShortDateString & "'" _
                & " and dramt>0 order by vou_date"
                GMod.DataSetRet(sql, "ser")

                For j = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                    If pramt <> GMod.ds.Tables("ser").Rows(j)("dramt") Then
                        pramt = GMod.ds.Tables("ser").Rows(j)("dramt")
                        sql = "select * from " & GMod.VENTRY & " where cheque_no='" & GMod.ds.Tables("mchq").Rows(i)("cheque_no") & "'" _
                        & " and acc_head_code='" & cmbacheadcode.Text & "' and vou_date<='" & dtTo.Value.ToShortDateString & "'" _
                        & " and dramt= " & GMod.ds.Tables("ser").Rows(j)("dramt") & " order by vou_date"
                        GMod.DataSetRet(sql, "ser1")
                        tr1 = GMod.ds.Tables("ser1").Rows.Count - 1

                        sql = "select * from " & GMod.BANK_STATE & " where chddno='" & GMod.ds.Tables("mchq").Rows(i)("cheque_no") & "'" _
                        & " and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'" _
                        & " and cramt=" & GMod.ds.Tables("ser").Rows(j)("dramt") & " order by bankedate"
                        GMod.DataSetRet(sql, "ser2")
                        tr2 = GMod.ds.Tables("ser2").Rows.Count - 1

                        If tr1 > tr2 Then
                            'entries more in our book at dr side
                            For k = tr2 + 1 To tr1
                                sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                                & " values('5.LESS: Cheque deposite but not cleared by bank','" & GMod.ds.Tables("ser1").Rows(k)("vou_date") & "'," _
                                & "'" & GMod.ds.Tables("ser1").Rows(k)("cheque_no") & "'," _
                                & GMod.ds.Tables("ser1").Rows(k)("dramt") & ")"
                                GMod.SqlExecuteNonQuery(sql)
                            Next
                        ElseIf tr2 > tr1 Then
                            'entries more in bank statement at cr side
                            For k = tr1 + 1 To tr2
                                sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                                & " values('2.ADD: Amount Credited by bank','" & GMod.ds.Tables("ser2").Rows(k)("bankedate") & "'," _
                                & "'" & GMod.ds.Tables("ser2").Rows(k)("chddno") & "'," _
                                & GMod.ds.Tables("ser2").Rows(k)("dramt") & ")"
                                GMod.SqlExecuteNonQuery(sql)
                            Next
                        End If
                    End If
                Next
                pramt = 0
                'search more cheque in CR side our book
                sql = "select * from " & GMod.VENTRY & " where cheque_no='" & GMod.ds.Tables("mchq").Rows(i)("cheque_no") & "'" _
                & " and acc_head_code='" & cmbacheadcode.Text & "' and vou_date<='" & dtTo.Value.ToShortDateString & "'" _
                & " and cramt>0 order by vou_date"
                GMod.DataSetRet(sql, "ser")
                For j = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                    If pramt <> GMod.ds.Tables("ser").Rows(j)("cramt") Then
                        pramt = GMod.ds.Tables("ser").Rows(j)("cramt")
                        sql = "select * from " & GMod.VENTRY & " where cheque_no='" & GMod.ds.Tables("mchq").Rows(i)("cheque_no") & "'" _
                        & " and acc_head_code='" & cmbacheadcode.Text & "' and vou_date<='" & dtTo.Value.ToShortDateString & "'" _
                        & " and cramt=" & GMod.ds.Tables("ser").Rows(j)("cramt") & "order by vou_date"
                        GMod.DataSetRet(sql, "ser1")
                        tr1 = GMod.ds.Tables("ser1").Rows.Count - 1

                        sql = "select * from " & GMod.BANK_STATE & " where chddno='" & GMod.ds.Tables("mchq").Rows(i)("cheque_no") & "'" _
                        & " and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'" _
                        & " and dramt=" & GMod.ds.Tables("ser").Rows(j)("cramt") & " order by bankedate"
                        GMod.DataSetRet(sql, "ser2")
                        tr2 = GMod.ds.Tables("ser2").Rows.Count - 1
                        If tr1 > tr2 Then
                            'entries more in our book at dr side
                            For k = tr2 + 1 To tr1
                                sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                                & " values('4.ADD: Cheque issued but not present','" & GMod.ds.Tables("ser1").Rows(k)("vou_date") & "'," _
                                & "'" & GMod.ds.Tables("ser1").Rows(k)("cheque_no") & "'," _
                                & GMod.ds.Tables("ser1").Rows(k)("cramt") & ")"
                                GMod.SqlExecuteNonQuery(sql)
                            Next
                        ElseIf tr2 > tr1 Then
                            'entries more in bank statement at cr side
                            For k = tr1 + 1 To tr2
                                sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                                & " values('3.LESS: Amount Debited by bank','" & GMod.ds.Tables("ser2").Rows(k)("bankedate") & "'," _
                                & "'" & GMod.ds.Tables("ser2").Rows(k)("chddno") & "'," _
                                & GMod.ds.Tables("ser2").Rows(k)("dramt") & ")"
                                GMod.SqlExecuteNonQuery(sql)
                            Next
                        End If
                    End If
                Next
            Else
                pramt = 0
                'more entries in bank statement
                'check dr side
                sql = "select * from " & GMod.BANK_STATE & " where chddno='" & GMod.ds.Tables("mchq").Rows(i)("chddno") & "'" _
                & " and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'" _
                & " and dramt>0"
                GMod.DataSetRet(sql, "ser")
                For j = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                    If pramt <> GMod.ds.Tables("ser").Rows(j)("dramt") Then
                        pramt = GMod.ds.Tables("ser").Rows(j)("dramt")
                        sql = "select * from " & GMod.BANK_STATE & " where chddno='" & GMod.ds.Tables("mchq").Rows(i)("chddno") & "'" _
                        & " and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'" _
                        & " and dramt=" & GMod.ds.Tables("ser").Rows(j)("dramt") & " order by bankedate"
                        GMod.DataSetRet(sql, "ser1")
                        tr1 = GMod.ds.Tables("ser1").Rows.Count - 1

                        sql = "select * from " & GMod.VENTRY & " where cheque_no='" & GMod.ds.Tables("mchq").Rows(i)("chddno") & "'" _
                        & " and acc_head_code='" & cmbacheadcode.Text & "' and vou_date<='" & dtTo.Value.ToShortDateString & "'" _
                        & " and cramt=" & GMod.ds.Tables("ser").Rows(j)("dramt") & " order by vou_date"
                        GMod.DataSetRet(sql, "ser2")
                        tr2 = GMod.ds.Tables("ser2").Rows.Count - 1
                        If tr1 > tr2 Then
                            'more cheque in bank statement
                            For k = tr2 + 1 To tr1
                                sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                                & " values('3.LESS: Amount Debited by bank','" & GMod.ds.Tables("ser1").Rows(k)("bankedate") & "'," _
                                & "'" & GMod.ds.Tables("ser1").Rows(k)("chddno") & "'," _
                                & GMod.ds.Tables("ser1").Rows(k)("dramt") & ")"
                                GMod.SqlExecuteNonQuery(sql)
                            Next
                        ElseIf tr2 > tr1 Then
                            'more cheque in our statement
                            For k = tr1 + 1 To tr2
                                sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                                & " values('4.ADD: Cheque issued but not present','" & GMod.ds.Tables("ser2").Rows(k)("vou_date") & "'," _
                                & "'" & GMod.ds.Tables("ser2").Rows(k)("cheque_no") & "'," _
                                & GMod.ds.Tables("ser2").Rows(k)("cramt") & ")"
                                GMod.SqlExecuteNonQuery(sql)
                            Next
                        End If
                    End If
                Next
                pramt = 0
                'check CR side
                sql = "select * from " & GMod.BANK_STATE & " where chddno='" & GMod.ds.Tables("mchq").Rows(i)("chddno") & "'" _
                & " and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'" _
                & " and cramt>0"
                GMod.DataSetRet(sql, "ser")
                For j = 0 To GMod.ds.Tables("ser").Rows.Count - 1
                    If pramt <> GMod.ds.Tables("ser").Rows(j)("cramt") Then
                        pramt = GMod.ds.Tables("ser").Rows(j)("cramt")
                        sql = "select * from " & GMod.BANK_STATE & " where chddno='" & GMod.ds.Tables("mchq").Rows(i)("chddno") & "'" _
                        & " and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'" _
                        & " and cramt=" & GMod.ds.Tables("ser").Rows(j)("cramt") & " order by bankedate"
                        GMod.DataSetRet(sql, "ser1")
                        tr1 = GMod.ds.Tables("ser1").Rows.Count - 1

                        sql = "select * from " & GMod.VENTRY & " where cheque_no='" & GMod.ds.Tables("mchq").Rows(i)("chddno") & "'" _
                        & " and acc_head_code='" & cmbacheadcode.Text & "' and vou_date<='" & dtTo.Value.ToShortDateString & "'" _
                        & " and dramt=" & GMod.ds.Tables("ser").Rows(j)("cramt") & " order by vou_date"
                        GMod.DataSetRet(sql, "ser2")
                        tr2 = GMod.ds.Tables("ser2").Rows.Count - 1
                        If tr1 > tr2 Then
                            'more cheque in bank statement
                            For k = tr2 + 1 To tr1
                                sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                                & " values('2.ADD: Amount Credited by bank','" & GMod.ds.Tables("ser1").Rows(k)("bankedate") & "'," _
                                & "'" & GMod.ds.Tables("ser1").Rows(k)("chddno") & "'," _
                                & GMod.ds.Tables("ser1").Rows(k)("cramt") & ")"
                                GMod.SqlExecuteNonQuery(sql)
                            Next
                        ElseIf tr2 > tr1 Then
                            'more cheque in our statement
                            For k = tr1 + 1 To tr2
                                sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt) " _
                                & " values('5.LESS: Cheque deposite but not cleared by bank','" & GMod.ds.Tables("ser2").Rows(k)("vou_date") & "'," _
                                & "'" & GMod.ds.Tables("ser2").Rows(k)("cheque_no") & "'," _
                                & GMod.ds.Tables("ser2").Rows(k)("dramt") & ")"
                                GMod.SqlExecuteNonQuery(sql)
                            Next
                        End If
                    End If
                Next
            End If
            'End If
        Next

        'MsgBox("completed")
    End Sub    '-----------------------------------------------------------------------------------------------
    Sub recon3()
        'Try
        'Dim recchoice As Boolean = False
        'If MsgBox("Are you want reconcile all entries [Yes] or only unreconciled entries [No]", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    recchoice = True
        'End If
        Dim getres As String
        Dim i, j As Integer
        Dim tr1, tr2 As Integer
        Dim prchq As String
        Dim sql As String


        '1. Balance as per our book

        'sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        'sql &= "'1.Balance As per Our Book',"
        'sql &= "'-',"
        'sql &= "'-',"
        'sql &= "'" & dtTo.Text & "',"
        'sql &= "'-',"
        'sql &= "'" & opening & "')"
        ''MsgBox(sql)
        'getres = GMod.SqlExecuteNonQuery(sql)
        '*******************************************************************************************************
        'AMOUNT RECONSILE WHILE DOES NOT EXIST
        'AMOUNT EXISTS AT CR SITE IN VENTRY BUT NOT IN DRSITE OF STATEMENT
        sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        & " select '4.ADD: Cheque issued but not present',vou_date,'-',cramt  " _
        & " from " & GMod.VENTRY & " v  where cramt not in " _
        & " (select dramt from " & GMod.BANK_STATE & " b  where v.cramt=b.dramt and " _
        & " v.dramt=b.cramt and b.bankedate=v.vou_date and b.bank_acc_code=v.acc_head_code and b.paytype='CASH'" _
        & " and b.bankedate<='" & dtTo.Value.ToShortDateString & "')  and v.acc_head_code='" & cmbacheadcode.Text & "' and " _
        & " pay_mode='CASH' and v.vou_date<='" & dtTo.Value.ToShortDateString & "' and v.cramt>0 "
        GMod.SqlExecuteNonQuery(sql)
        'AMOUNT EXISTS AT DR SITE IN VENTRY BUT NOT IN CR SITE OF STATEMENT
        sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        & " select '5.LESS: Cheque deposite but not cleared by bank',vou_date,'-',dramt  " _
        & " from " & GMod.VENTRY & " v  where dramt not in " _
        & " (select cramt from " & GMod.BANK_STATE & "  b  where v.cramt=b.dramt and " _
        & " v.dramt=b.cramt and b.bankedate=v.vou_date and b.bank_acc_code=v.acc_head_code and b.paytype='CASH' " _
        & " and b.bankedate<='" & dtTo.Value.ToShortDateString & "')  and v.acc_head_code='" & cmbacheadcode.Text & "' and " _
        & " pay_mode='CASH' and v.vou_date<='" & dtTo.Value.ToShortDateString & "' and v.dramt>0 "
        GMod.SqlExecuteNonQuery(sql)
        'AMOUNT EXISTS AT DR SITE OF THE STATEMENT BUT NOT IN CR SITE OR BOOK
        sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        & " select '3.LESS: Amount Debited by bank',bankedate,'-',dramt " _
        & " from " & GMod.BANK_STATE & " b  where dramt not in (select cramt " _
        & " from " & GMod.VENTRY & " v where b.bank_acc_code=v.acc_head_code  and " _
        & " v.pay_mode='CASH' and v.vou_date=b.bankedate and vou_date<='" & dtTo.Value.ToShortDateString & "')  " _
        & " and b.bank_acc_code='" & cmbacheadcode.Text & "'" _
        & " and b.paytype='CASH' and b.bankedate<='" & dtTo.Value.ToShortDateString & "' and  b.dramt>0 "
        GMod.SqlExecuteNonQuery(sql)
        'AMOUNT EXISTS AT CR SITE OF THE STATEMENT BUT NOT IN DR SITE OR BOOK
        sql = " select '2.ADD: Amount Credited by bank',bankedate,'-',cramt " _
        & " from " & GMod.BANK_STATE & "  b  where cramt not in (select dramt " _
        & " from " & GMod.VENTRY & " v where b.bank_acc_code=v.acc_head_code  and " _
        & " v.pay_mode='CASH' and v.vou_date=b.bankedate and vou_date<='" & dtTo.Value.ToShortDateString & "') " _
        & " and b.bank_acc_code='" & cmbacheadcode.Text & "'" _
        & " and b.paytype='CASH' and b.bankedate<='" & dtTo.Value.ToShortDateString & "' and  b.cramt>0 "
        GMod.SqlExecuteNonQuery(sql)

        ''search for the multiple cash entries at our book
        ''search in dr site
        'sql = " select * from (select dramt,vou_date,count(*) cventry  from " & GMod.VENTRY & " where " _
        '& " pay_mode='CASH' and acc_head_code='" & cmbacheadcode.Text & "'" _
        '& " group by dramt,vou_date ) p where cventry>1 and dramt>0"
        'GMod.DataSetRet(sql, "ser1")
        'For i = 0 To GMod.ds.Tables("ser1").Rows.Count - 1
        '    tr1 = GMod.ds.Tables("ser1").Rows(i)("cventry") - 1
        '    sql = "select * from " & GMod.BANK_STATE & " where cramt=" & GMod.ds.Tables("ser1").Rows(i)("dramt") _
        '    & " and paytype='CASH' and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate='" & GMod.ds.Tables("ser1").Rows(i)("vou_date") & "'"
        '    GMod.DataSetRet(sql, "ser2")
        '    tr2 = GMod.ds.Tables("ser2").Rows.Count - 1
        '    If tr1 > tr2 Then
        '        sql = "select * from " & GMod.VENTRY & " where " _
        '        & " pay_mode='CASH' and acc_head_code='" & cmbacheadcode.Text & "'" _
        '        & " and vou_date='" & GMod.ds.Tables("ser1").Rows(i)("vou_date") & "'" _
        '        & " and dramt=" & GMod.ds.Tables("ser1").Rows(i)("dramt")
        '        GMod.DataSetRet(sql, "ser3")
        '        For j = tr2 + 1 To tr1
        '            sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        '            & " select '5.LESS: Cheque deposite but not cleared by bank'," _
        '            & "'" & GMod.ds.Tables("ser3").Rows(j)("vou_date") & "','-'," _
        '            & GMod.ds.Tables("ser3").Rows(j)("dramt")
        '            GMod.SqlExecuteNonQuery(sql)
        '        Next
        '    ElseIf tr2 > tr1 Then
        '        For j = tr1 + 1 To tr2
        '            sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        '            & " select '2.ADD: Amount Credited by bank'," _
        '            & "'" & GMod.ds.Tables("ser2").Rows(j)("bankedate") & "','-'," _
        '            & GMod.ds.Tables("ser2").Rows(j)("cramt")
        '            GMod.SqlExecuteNonQuery(sql)
        '        Next
        '    End If
        'Next
        ''search in cr side
        'sql = " select * from (select cramt,vou_date,count(*) cventry  from " & GMod.VENTRY & " where " _
        '        & " pay_mode='CASH' and acc_head_code='" & cmbacheadcode.Text & "'" _
        '        & " group by cramt,vou_date ) p where cventry>1 and cramt>0"
        'GMod.DataSetRet(sql, "ser1")
        'For i = 0 To GMod.ds.Tables("ser1").Rows.Count - 1
        '    tr1 = GMod.ds.Tables("ser1").Rows(i)("cventry")
        '    sql = "select * from " & GMod.BANK_STATE & " where dramt=" & GMod.ds.Tables("ser1").Rows(i)("cramt") _
        '    & "  and paytype='CASH' and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate='" & GMod.ds.Tables("ser1").Rows(i)("vou_date") & "'"
        '    GMod.DataSetRet(sql, "ser2")
        '    tr2 = GMod.ds.Tables("ser2").Rows.Count - 1
        '    If tr1 > tr2 Then
        '        sql = "select * from " & GMod.VENTRY & " where " _
        '        & " pay_mode='CASH' and acc_head_code='" & cmbacheadcode.Text & "'" _
        '        & " and vou_date='" & GMod.ds.Tables("ser1").Rows(i)("vou_date") & "'" _
        '        & " and cramt=" & GMod.ds.Tables("ser1").Rows(i)("cramt")
        '        GMod.DataSetRet(sql, "ser3")
        '        For j = tr2 + 1 To tr1
        '            sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        '            & " select '4.ADD: Cheque issued but not present'," _
        '            & "'" & GMod.ds.Tables("ser3").Rows(j)("vou_date") & "','-'," _
        '            & GMod.ds.Tables("ser3").Rows(j)("dramt")
        '            GMod.SqlExecuteNonQuery(sql)
        '        Next
        '    ElseIf tr2 > tr1 Then
        '        For j = tr1 + 1 To tr2
        '            sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        '            & " select '3.LESS: Amount Debited by bank'," _
        '            & "'" & GMod.ds.Tables("ser2").Rows(j)("bankedate") & "','-'," _
        '            & GMod.ds.Tables("ser2").Rows(j)("cramt")
        '            GMod.SqlExecuteNonQuery(sql)
        '        Next
        '    End If
        'Next


        ''search for the multiple cash entries at book statement
        ''search in dr site
        'sql = " select * from (select dramt,bankedate,count(*) cbank  from " & GMod.BANK_STATE & " where " _
        '& " paytype ='CASH' and bank_acc_code='" & cmbacheadcode.Text & "'" _
        '& " group by dramt,bankedate ) p where cbank > 1 and dramt>0"
        'GMod.DataSetRet(sql, "ser1")
        'For i = 0 To GMod.ds.Tables("ser1").Rows.Count - 1
        '    tr1 = GMod.ds.Tables("ser1").Rows(i)("cbank") - 1
        '    sql = "select * from " & GMod.VENTRY & " where cramt=" & GMod.ds.Tables("ser1").Rows(i)("dramt") _
        '    & " and pay_mode='CASH' and acc_head_code='" & cmbacheadcode.Text & "' and vou_date='" & GMod.ds.Tables("ser1").Rows(i)("bankedate") & "'"
        '    GMod.DataSetRet(sql, "ser2")
        '    If GMod.ds.Tables("ser2").Rows.Count > 0 Then tr2 = GMod.ds.Tables("ser2").Rows.Count - 1 Else tr2 = tr1
        '    If tr1 > tr2 Then
        '        sql = "select * from " & GMod.BANK_STATE & " where " _
        '        & " paytype ='CASH' and bank_acc_code='" & cmbacheadcode.Text & "'" _
        '        & " and bankedate='" & GMod.ds.Tables("ser1").Rows(i)("bankedate") & "'" _
        '        & " and dramt=" & GMod.ds.Tables("ser1").Rows(i)("dramt")
        '        GMod.DataSetRet(sql, "ser3")
        '        For j = tr2 + 1 To tr1
        '            sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        '            & " select '5.LESS: Cheque deposite but not cleared by bank'," _
        '            & "'" & GMod.ds.Tables("ser3").Rows(j)("bankedate") & "','-'," _
        '            & GMod.ds.Tables("ser3").Rows(j)("dramt")
        '            GMod.SqlExecuteNonQuery(sql)
        '        Next
        '    ElseIf tr2 > tr1 Then
        '        For j = tr1 + 1 To tr2
        '            sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        '            & " select '2.ADD: Amount Credited by bank'," _
        '            & "'" & GMod.ds.Tables("ser2").Rows(j)("vou_date") & "','-'," _
        '            & GMod.ds.Tables("ser2").Rows(j)("cramt")
        '            GMod.SqlExecuteNonQuery(sql)
        '        Next
        '    End If
        'Next
        ''search in cr side
        'sql = " select * from (select cramt,bankedate,count(*) cbank  from " & GMod.BANK_STATE & " where " _
        '        & " paytype='CASH' and bank_acc_code='" & cmbacheadcode.Text & "'" _
        '        & " group by bankedate,cramt ) p where cbank >1 and cramt>0"
        'GMod.DataSetRet(sql, "ser1")
        'For i = 0 To GMod.ds.Tables("ser1").Rows.Count - 1
        '    tr1 = GMod.ds.Tables("ser1").Rows(i)("cbank")
        '    sql = "select * from " & GMod.VENTRY & " where dramt=" & GMod.ds.Tables("ser1").Rows(i)("cramt") _
        '    & " and pay_mode='CASH' and acc_head_code='" & cmbacheadcode.Text & "' and vou_date='" & GMod.ds.Tables("ser1").Rows(i)("vou_date") & "'"
        '    GMod.DataSetRet(sql, "ser2")
        '    If GMod.ds.Tables("ser2").Rows.Count > 0 Then tr2 = GMod.ds.Tables("ser2").Rows.Count - 1 Else tr2 = tr1
        '    If tr1 > tr2 Then
        '        sql = "select * from " & GMod.BANK_STATE & " where " _
        '        & " paytype='CASH' and bank_acc_code='" & cmbacheadcode.Text & "'" _
        '        & " and bankedate='" & GMod.ds.Tables("ser1").Rows(i)("bankedate") & "'" _
        '        & " and cramt=" & GMod.ds.Tables("ser1").Rows(i)("cramt")
        '        GMod.DataSetRet(sql, "ser3")
        '        For j = tr2 + 1 To tr1
        '            sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        '            & " select '4.ADD: Cheque issued but not present'," _
        '            & "'" & GMod.ds.Tables("ser3").Rows(j)("bankedate") & "','-'," _
        '            & GMod.ds.Tables("ser3").Rows(j)("dramt")
        '            GMod.SqlExecuteNonQuery(sql)
        '        Next
        '    ElseIf tr2 > tr1 Then
        '        For j = tr1 + 1 To tr2
        '            sql = "insert into bank_rec(Rec_head, Issue_date, Chq_No, Amt)  " _
        '            & " select '3.LESS: Amount Debited by bank'," _
        '            & "'" & GMod.ds.Tables("ser2").Rows(j)("vou_date") & "','-'," _
        '            & GMod.ds.Tables("ser2").Rows(j)("cramt")
        '            GMod.SqlExecuteNonQuery(sql)
        '        Next
        '    End If
        'Next

        MsgBox("completed")
    End Sub
    Sub recon4()
        'Try
        Dim recchoice As Boolean = False
        If MsgBox("Are you want reconcile all entries [Yes] or only unreconciled entries [No]", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            recchoice = True
        End If
        Dim getres As String
        Dim i, j As Integer
        Dim tr1, tr2 As Integer
        Dim prchq As String
        Dim sql As String

        Dim c As Integer
        '*******************************************************************************************************
        Try
            '2.Less : Amount Withdrawl but not present (B)
            If recchoice Then
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " cramt>0 and Pay_mode<>'CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & "  and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' "
            Else
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " cramt>0 and Pay_mode<>'CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & " and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date='1900-1-1'"
            End If

            GMod.DataSetRet(sql, "Amt_Withdrawal")
            tr1 = GMod.ds.Tables("Amt_Withdrawal").Rows.Count
            For i = 0 To GMod.ds.Tables("Amt_Withdrawal").Rows.Count - 1
                c = i
                sql = "select * from " & GMod.BANK_STATE & " where dramt = " & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("cramt") & " and bankedate= '" _
                & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("Vou_date") & "' and paytype<>'CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "'" _
                & " and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                GMod.DataSetRet(sql, "Amt_wd_count")
                If GMod.ds.Tables("Amt_wd_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'4.ADD: Cheque issued but not present',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("Vou_date") & "',"
                    sql &= "'-',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("Amt_Withdrawal").Rows(i)("cramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("Amt_wd_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("Amt_wd_count").Rows.Count
                    sql = "select count(*) from " & GMod.VENTRY & " where cramt = " & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("cramt") & " and vou_date= '" _
                    & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("Vou_date") & "' and pay_mode<>'CHEQUE' and acc_head_code='" & cmbacheadcode.Text & "'"
                    GMod.DataSetRet(sql, "ourbook_count")
                    tr1 = GMod.ds.Tables("ourbook_count").Rows(0)(0)
                    If tr1 < tr2 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'3.LESS: Amount Debited by bank',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("Amt_wd_count").Rows(j)("bankedate") & "',"
                            sql &= "'-',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("Amt_wd_count").Rows(j)("dramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
        Catch ex As Exception
            MsgBox(c.ToString)
            MsgBox("2" & ex.Message)
        End Try
        'MsgBox("2 is completed")
        '***********************************************************************************************
        '***********************************************************************************************
        '3.ADD: Amount deposite but not cleared by bank (B)
        Try
            If recchoice Then
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " dramt>0 and Pay_mode<>'CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & " and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' order by vou_date,dramt"
            Else
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " dramt>0 and Pay_mode<>'CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & " and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date='1900-1-1' order by vou_date,dramt"
            End If
            GMod.DataSetRet(sql, "amt_deposite")
            tr1 = GMod.ds.Tables("amt_deposite").Rows.Count
            For i = 0 To GMod.ds.Tables("amt_deposite").Rows.Count - 1
                sql = "select * from " & GMod.BANK_STATE & " where cramt = " & GMod.ds.Tables("amt_deposite").Rows(i)("dramt") & " and bankedate= '" _
                & GMod.ds.Tables("amt_deposite").Rows(i)("Vou_date") & "' and paytype<>'CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "'" _
                & " and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("amt_deposite").Rows(i)("Vou_date") & "',"
                    sql &= "'-',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("amt_deposite").Rows(i)("dramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.VENTRY & " where dramt = " & GMod.ds.Tables("amt_deposite").Rows(i)("dramt") & " and vou_date= '" _
                    & GMod.ds.Tables("amt_deposite").Rows(i)("Vou_date") & "' and pay_mode<>'CHEQUE' and acc_head_code='" & cmbacheadcode.Text & "'"
                    GMod.DataSetRet(sql, "ourbook_count")
                    tr1 = GMod.ds.Tables("ourbook_count").Rows(0)(0)

                    If tr1 < tr2 Then

                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'2.ADD: Amount Credited by bank',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("bankedate") & "',"
                            sql &= "'-',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
        Catch ex As Exception
            MsgBox("4" & ex.Message)
        End Try
        'MsgBox("4 is completed")
        '***********************************************************************************************
        '4.ADD: Cheque debited by bank (A)
        Try
                 '**************************************************************************************************************
            '4.ADD: Amount debited by bank (B)
            If recchoice Then
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE'"
            Else
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE' and issuedate='1900-1-1'"
            End If

            GMod.DataSetRet(sql, "amt_debit")
            tr1 = GMod.ds.Tables("amt_debit").Rows.Count
            For i = 0 To GMod.ds.Tables("amt_debit").Rows.Count - 1
                sql = "select * from " & GMod.VENTRY & " where cramt=" & GMod.ds.Tables("amt_debit").Rows(i)("dramt") _
                & " and Vou_date='" & GMod.ds.Tables("amt_debit").Rows(i)("bankedate") & "' and Pay_mode<>'CHEQUE' and acc_head_code='" & cmbacheadcode.Text _
                & "' and (vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' or vou_type='BANKREC')"
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'3.LESS: Amount Debited by bank',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("amt_debit").Rows(i)("bankedate") & "',"
                    sql &= "'-',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("amt_debit").Rows(i)("dramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.BANK_STATE & " where dramt=" & GMod.ds.Tables("amt_debit").Rows(i)("dramt") & " and bankedate='" & GMod.ds.Tables("amt_debit").Rows(i)("bankedate") & "' and Paytype<>'CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                    GMod.DataSetRet(sql, "book_count")
                    tr1 = GMod.ds.Tables("book_count").Rows(0)(0)
                    If tr1 < tr2 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'4.ADD: Cheque issued but not present',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
                            sql &= "'-',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
        Catch ex As Exception
            MsgBox("4" & ex.Message)
        End Try
        'MsgBox("6 is completed")
        '***********************************************************************************************
        '5.LESS: Cheque Credited by bank (A)
        Try
            '5. LESS: Amount Credited by Bank (B)
            If recchoice Then
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE'"
            Else
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE' and issuedate='1900-1-1'"
            End If
            GMod.DataSetRet(sql, "amt_credit")
            tr1 = GMod.ds.Tables("amt_credit").Rows.Count
            For i = 0 To GMod.ds.Tables("amt_credit").Rows.Count - 1
                sql = "select * from " & GMod.VENTRY & " where acc_head_code='" & cmbacheadcode.Text & "' and dramt=" _
                & GMod.ds.Tables("amt_credit").Rows(i)("cramt") _
                & " and (Vou_date='" & CDate(GMod.ds.Tables("amt_credit").Rows(i)("bankedate")) & "' or vou_type='BANKREC') and pay_mode<>'CHEQUE'"
                'MsgBox(sql)
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'2.ADD: Amount Credited by bank',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("amt_credit").Rows(i)("bankedate") & "',"
                    sql &= "'-',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("amt_credit").Rows(i)("cramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacheadcode.Text & "' and cramt=" & GMod.ds.Tables("amt_credit").Rows(i)("cramt") _
                    & " and bankedate='" & CDate(GMod.ds.Tables("amt_credit").Rows(i)("bankedate")) & "' and paytype<>'CHEQUE'"
                    GMod.DataSetRet(sql, "bank_count")
                    tr1 = GMod.ds.Tables("bank_count").Rows(0)(0)

                    If tr1 < tr2 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
                            sql &= "'-',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("dramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
            'MsgBox("8 is completed")
        Catch ex As Exception
            MsgBox("5" & ex.Message)
        End Try

        '******************************************************************************************
        '6. Less: Opening Difference 
        OpeningBankStatement(dtfrom.Value)
        CalcBankOpening()
        opndiff = opening - opnbakstate
        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        sql &= "'6. Less: Opening Difference ',"
        sql &= "'-',"
        sql &= "'-',"
        sql &= "'" & dtTo.Text & "',"
        sql &= "'-',"
        sql &= "" & Math.Abs(opndiff) & ")"
        'getres = GMod.SqlExecuteNonQuery(sql)
        '******************************************************************************************
        ''7. Balance as per bank statement
        'OpeningBankStatement(dtTo.Value)
        'sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        'sql &= "'7. Balance as per Bank Statement',"
        'sql &= "'-',"
        'sql &= "'-',"
        'sql &= "'" & dtTo.Text & "',"
        'sql &= "'-',"
        'sql &= "" & opnbakstate & ")"
        'getres = GMod.SqlExecuteNonQuery(sql)

    End Sub
    Public Sub reconCr() 'Reconciltion When opening balance of bank Accounr head inour books is on the Dr side
        'Try
        Dim recchoice As Boolean = False
        If MsgBox("Are you want reconcile all entries [Yes] or only unreconciled entries [No]", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            recchoice = True
        End If
        Dim getres As String
        Dim i, j As Integer
        Dim tr1, tr2 As Integer
        Dim prchq As String
        Dim sql As String


        '1. Balance as per our book

        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        sql &= "'1.Balance As per Our Book',"
        sql &= "'-',"
        sql &= "'-',"
        sql &= "'" & dtTo.Text & "',"
        sql &= "'-',"
        sql &= "'" & opening & "')"
        'MsgBox(sql)
        getres = GMod.SqlExecuteNonQuery(sql)
        '*******************************************************************************************************
        '2.LESS : Cheque issued but not present (A)
        Try
            If recchoice Then
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " cramt > 0 and Pay_mode='CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & "  and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' order by cheque_no,cramt"
            Else
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " cramt > 0 and Pay_mode='CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & " and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date = '1900-1-1' order by cheque_no,cramt"
            End If

            GMod.DataSetRet(sql, "ch_issue")
            tr1 = GMod.ds.Tables("ch_issue").Rows.Count
            For i = 0 To GMod.ds.Tables("ch_issue").Rows.Count - 1
                sql = "select chddno,bankedate,cramt,dramt from " & GMod.BANK_STATE & " where dramt=" & GMod.ds.Tables("ch_issue").Rows(i)("cramt") & " and chddno = '" & GMod.ds.Tables("ch_issue").Rows(i)("Cheque_no") & "' and bank_acc_code ='" & cmbacheadcode.Text & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'4.ADD: Cheque issued but not present',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("ch_issue").Rows(i)("Vou_date") & "',"
                    sql &= "'" & GMod.ds.Tables("ch_issue").Rows(i)("Cheque_no") & "',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("ch_issue").Rows(i)("cramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.VENTRY & " where cramt=" & GMod.ds.Tables("ch_issue").Rows(i)("cramt") & " and cheque_no = '" & GMod.ds.Tables("ch_issue").Rows(i)("Cheque_no") & "' and acc_head_code ='" & cmbacheadcode.Text & "'"
                    GMod.DataSetRet(sql, "ourbook_count")
                    tr1 = GMod.ds.Tables("ourbook_count").Rows(0)(0)

                    If tr2 > tr1 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'3.LESS: Amount Debited by bank',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("bankedate") & "',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("chddno") & "',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("dramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
        Catch ex As Exception
            MsgBox("1" & ex.Message)
        End Try
        MsgBox("1 is completed")
        Dim c As Integer
        Try
            '2.Less : Amount Withdrawl but not present (B)
            If recchoice Then
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " cramt>0 and Pay_mode<>'CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & "  and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' "
            Else
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " cramt>0 and Pay_mode<>'CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & " and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date='1900-1-1'"
            End If

            GMod.DataSetRet(sql, "Amt_Withdrawal")
            tr1 = GMod.ds.Tables("Amt_Withdrawal").Rows.Count
            For i = 0 To GMod.ds.Tables("Amt_Withdrawal").Rows.Count - 1
                c = i
                sql = "select * from " & GMod.BANK_STATE & " where dramt = " & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("cramt") & " and bankedate= '" _
                & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("Vou_date") & "' and paytype<>'CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "'" _
                & " and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                GMod.DataSetRet(sql, "Amt_wd_count")
                If GMod.ds.Tables("Amt_wd_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'4.ADD: Cheque issued but not present',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("Vou_date") & "',"
                    sql &= "'-',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("Amt_Withdrawal").Rows(i)("cramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("Amt_wd_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("Amt_wd_count").Rows.Count
                    sql = "select count(*) from " & GMod.VENTRY & " where cramt = " & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("cramt") & " and vou_date= '" _
                    & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("Vou_date") & "' and pay_mode<>'CHEQUE' and acc_head_code='" & cmbacheadcode.Text & "'"
                    GMod.DataSetRet(sql, "ourbook_count")
                    tr1 = GMod.ds.Tables("ourbook_count").Rows(0)(0)
                    If tr1 < tr2 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'3.LESS: Amount Debited by bank',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("Amt_wd_count").Rows(j)("bankedate") & "',"
                            sql &= "'-',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("Amt_wd_count").Rows(j)("dramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
        Catch ex As Exception
            MsgBox(c.ToString)
            MsgBox("2" & ex.Message)
        End Try
        MsgBox("2 is completed")
        '***********************************************************************************************
        '3.ADD: Cheuqe deposite but not cleared (A)
        Try
            If recchoice Then
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " dramt>0 and Pay_mode='CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & "  and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "'"
            Else
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " dramt>0 and Pay_mode='CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & " and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date='1900-1-1'"
            End If
            GMod.DataSetRet(sql, "ch_deposite")
            tr1 = GMod.ds.Tables("ch_deposite").Rows.Count
            For i = 0 To GMod.ds.Tables("ch_deposite").Rows.Count - 1
                sql = "select chddno,bankedate,cramt,dramt from " & GMod.BANK_STATE & " where cramt=" & GMod.ds.Tables("ch_deposite").Rows(i)("dramt") & " and bank_acc_code='" & cmbacheadcode.Text & "' and chddno = '" & GMod.ds.Tables("ch_deposite").Rows(i)("Cheque_no") & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("ch_deposite").Rows(i)("Vou_date") & "',"
                    sql &= "'" & GMod.ds.Tables("ch_deposite").Rows(i)("Cheque_no") & "',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("ch_deposite").Rows(i)("dramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.VENTRY & " where dramt=" & GMod.ds.Tables("ch_deposite").Rows(i)("dramt") & " and acc_head_code='" & cmbacheadcode.Text & "' and cheque_no = '" & GMod.ds.Tables("ch_deposite").Rows(i)("Cheque_no") & "'"
                    GMod.DataSetRet(sql, "ourbook_count")

                    If tr1 < tr2 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'2.ADD: Amount Credited by bank',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("bankedate") & "',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("chddno") & "',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
            MsgBox("3 is completed")
            '***********************************************************************************************
            '3.ADD: Amount deposite but not cleared by bank (B)
            If recchoice Then
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " dramt>0 and Pay_mode<>'CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & " and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' order by vou_date,dramt"
            Else
                sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
                & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
                & " dramt>0 and Pay_mode<>'CHEQUE' and " _
                & " Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                & " and vou_type<>'BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date='1900-1-1' order by vou_date,dramt"
            End If
            GMod.DataSetRet(sql, "amt_deposite")
            tr1 = GMod.ds.Tables("amt_deposite").Rows.Count
            For i = 0 To GMod.ds.Tables("amt_deposite").Rows.Count - 1
                sql = "select * from " & GMod.BANK_STATE & " where cramt = " & GMod.ds.Tables("amt_deposite").Rows(i)("dramt") & " and bankedate= '" _
                & GMod.ds.Tables("amt_deposite").Rows(i)("Vou_date") & "' and paytype<>'CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "'" _
                & " and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("amt_deposite").Rows(i)("Vou_date") & "',"
                    sql &= "'-',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("amt_deposite").Rows(i)("dramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.VENTRY & " where dramt = " & GMod.ds.Tables("amt_deposite").Rows(i)("dramt") & " and vou_date= '" _
                    & GMod.ds.Tables("amt_deposite").Rows(i)("Vou_date") & "' and pay_mode<>'CHEQUE' and acc_head_code='" & cmbacheadcode.Text & "'"
                    GMod.DataSetRet(sql, "ourbook_count")
                    tr1 = GMod.ds.Tables("ourbook_count").Rows(0)(0)

                    If tr1 < tr2 Then

                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'2.ADD: Amount Credited by bank',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("bankedate") & "',"
                            sql &= "'-',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
        Catch ex As Exception
            MsgBox("4" & ex.Message)
        End Try
        MsgBox("4 is completed")
        '***********************************************************************************************
        '4.ADD: Cheque debited by bank (A)
        Try
            If recchoice Then
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype='CHEQUE'"
            Else
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype='CHEQUE' and issuedate='1900-1-1'"
            End If

            GMod.DataSetRet(sql, "ch_debit")
            tr1 = GMod.ds.Tables("ch_debit").Rows.Count
            For i = 0 To GMod.ds.Tables("ch_debit").Rows.Count - 1
                sql = "select * from " & GMod.VENTRY & " where cramt=" & GMod.ds.Tables("ch_debit").Rows(i)("dramt") & " and acc_head_code='" & cmbacheadcode.Text & "' and Cheque_no='" & GMod.ds.Tables("ch_debit").Rows(i)("chddno") & "' and (vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' or vou_type='BANKREC')"
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'3.LESS: Amount Debited by bank',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("ch_debit").Rows(i)("bankedate") & "',"
                    sql &= "'" & GMod.ds.Tables("ch_debit").Rows(i)("chddno") & "',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("ch_debit").Rows(i)("dramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.BANK_STATE & " where dramt=" & GMod.ds.Tables("ch_debit").Rows(i)("dramt") & " and bank_acc_code='" & cmbacheadcode.Text & "' and Chddno='" & GMod.ds.Tables("ch_debit").Rows(i)("chddno") & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                    GMod.DataSetRet(sql, "bankstate_count")
                    tr1 = GMod.ds.Tables("bankstate_count").Rows(0)(0)
                    If tr1 < tr2 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'4.ADD: Cheque issued but not present',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("cheque_no") & "',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
            MsgBox("5 is completed")
            '**************************************************************************************************************
            '4.ADD: Amount debited by bank (B)
            If recchoice Then
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE'"
            Else
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE' and issuedate='1900-1-1'"
            End If

            GMod.DataSetRet(sql, "amt_debit")
            tr1 = GMod.ds.Tables("amt_debit").Rows.Count
            For i = 0 To GMod.ds.Tables("amt_debit").Rows.Count - 1
                sql = "select * from " & GMod.VENTRY & " where cramt=" & GMod.ds.Tables("amt_debit").Rows(i)("dramt") _
                & " and Vou_date='" & GMod.ds.Tables("amt_debit").Rows(i)("bankedate") & "' and Pay_mode<>'CHEQUE' and acc_head_code='" & cmbacheadcode.Text _
                & "' and (vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' or vou_type='BANKREC')"
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'3.LESS: Amount Debited by bank',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("amt_debit").Rows(i)("bankedate") & "',"
                    sql &= "'-',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("amt_debit").Rows(i)("dramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.BANK_STATE & " where dramt=" & GMod.ds.Tables("amt_debit").Rows(i)("dramt") & " and bankedate='" & GMod.ds.Tables("amt_debit").Rows(i)("bankedate") & "' and Paytype<>'CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                    GMod.DataSetRet(sql, "book_count")
                    tr1 = GMod.ds.Tables("book_count").Rows(0)(0)
                    If tr1 < tr2 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'4.ADD: Cheque issued but not present',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
                            sql &= "'-',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
        Catch ex As Exception
            MsgBox("4" & ex.Message)
        End Try
        MsgBox("6 is completed")
        '***********************************************************************************************
        '5.LESS: Cheque Credited by bank (A)
        Try
            If recchoice Then
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype='CHEQUE'"
            Else
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype='CHEQUE' and issuedate='1900-1-1'"
            End If
            GMod.DataSetRet(sql, "ch_credit")
            tr1 = GMod.ds.Tables("ch_credit").Rows.Count
            For i = 0 To GMod.ds.Tables("ch_credit").Rows.Count - 1
                sql = "select * from " & GMod.VENTRY & " where dramt=" & GMod.ds.Tables("ch_credit").Rows(i)("cramt") _
                & " and acc_head_code='" & cmbacheadcode.Text & "' and  Cheque_no='" & GMod.ds.Tables("ch_credit").Rows(i)("chddno") _
                & "' and (vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' or vou_type='BANKREC')"
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'2.ADD: Amount Credited by bank',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("ch_credit").Rows(i)("bankedate") & "',"
                    sql &= "'" & GMod.ds.Tables("ch_credit").Rows(i)("chddno") & "',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("ch_credit").Rows(i)("cramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.BANK_STATE & " where cramt=" & GMod.ds.Tables("ch_credit").Rows(i)("cramt") & " and bank_acc_code='" & cmbacheadcode.Text & "' and chddno='" & GMod.ds.Tables("ch_credit").Rows(i)("chddno") & "' and bankedate='" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                    GMod.DataSetRet(sql, "bank_count")
                    tr1 = GMod.ds.Tables("bank_count").Rows(0)(0)
                    If tr1 < tr2 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("cheque_no") & "',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("dramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
            MsgBox("7 is completed")
            '5. LESS: Amount Credited by Bank (B)
            If recchoice Then
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE'"
            Else
                sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
                & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" _
                & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE' and issuedate='1900-1-1'"
            End If
            GMod.DataSetRet(sql, "amt_credit")
            tr1 = GMod.ds.Tables("amt_credit").Rows.Count
            For i = 0 To GMod.ds.Tables("amt_credit").Rows.Count - 1
                sql = "select * from " & GMod.VENTRY & " where acc_head_code='" & cmbacheadcode.Text & "' and dramt=" _
                & GMod.ds.Tables("amt_credit").Rows(i)("cramt") _
                & " and (Vou_date='" & CDate(GMod.ds.Tables("amt_credit").Rows(i)("bankedate")) & "' or vou_type='BANKREC') and pay_mode<>'CHEQUE'"
                'MsgBox(sql)
                GMod.DataSetRet(sql, "ch_count")
                If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                    sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                    sql &= "'2.ADD: Amount Credited by bank',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & GMod.ds.Tables("amt_credit").Rows(i)("bankedate") & "',"
                    sql &= "'-',"
                    sql &= "'" & Math.Abs(GMod.ds.Tables("amt_credit").Rows(i)("cramt")) & "')"
                    getres = GMod.SqlExecuteNonQuery(sql)
                ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                    tr2 = GMod.ds.Tables("ch_count").Rows.Count
                    sql = "select count(*) from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacheadcode.Text & "' and cramt=" & GMod.ds.Tables("amt_credit").Rows(i)("cramt") _
                    & " and bankedate='" & CDate(GMod.ds.Tables("amt_credit").Rows(i)("bankedate")) & "' and paytype<>'CHEQUE'"
                    GMod.DataSetRet(sql, "bank_count")
                    tr1 = GMod.ds.Tables("bank_count").Rows(0)(0)

                    If tr1 < tr2 Then
                        For j = (tr2 - tr1 - 1) To tr2 - 1
                            sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                            sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
                            sql &= "'-',"
                            sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("dramt")) & "')"
                            getres = GMod.SqlExecuteNonQuery(sql)
                        Next
                    End If
                    i = i + tr1 - 1
                End If

            Next
            MsgBox("8 is completed")
        Catch ex As Exception
            MsgBox("5" & ex.Message)
        End Try

        '******************************************************************************************
        '6. Less: Opening Difference 
        OpeningBankStatement(dtfrom.Value)
        CalcBankOpening()
        opndiff = opening - opnbakstate
        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        sql &= "'6. Less: Opening Difference ',"
        sql &= "'-',"
        sql &= "'-',"
        sql &= "'" & dtTo.Text & "',"
        sql &= "'-',"
        sql &= "" & Math.Abs(opndiff) & ")"
        'getres = GMod.SqlExecuteNonQuery(sql)
        '******************************************************************************************
        ''7. Balance as per bank statement
        'OpeningBankStatement(dtTo.Value)
        'sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        'sql &= "'7. Balance as per Bank Statement',"
        'sql &= "'-',"
        'sql &= "'-',"
        'sql &= "'" & dtTo.Text & "',"
        'sql &= "'-',"
        'sql &= "" & opnbakstate & ")"
        'getres = GMod.SqlExecuteNonQuery(sql)

    End Sub
    Public Sub reconCrBackDate() 'Reconciltion When opening balance of bank Accounr head inour books is on the Dr side
        Dim recchoice As Boolean = False
        If MsgBox("Are you want reconcile all Back Date entries [Yes] or only unreconciled entries [No]", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            recchoice = True
        End If
        Dim getres As String
        Dim i, j As Integer
        Dim tr1, tr2 As Integer
        Dim prchq As String
        ''1. Balance as per our book
        Dim sql As String
        'sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        'sql &= "'1.Balance As per Our Book',"
        'sql &= "'-',"
        'sql &= "'-',"
        'sql &= "'" & dtTo.Text & "',"
        'sql &= "'-',"
        'sql &= "'" & opening & "')"
        ''MsgBox(sql)
        'getres = GMod.SqlExecuteNonQuery(sql)
        '*******************************************************************************************************
        '2.LESS : Cheque issued but not present (A)
        If recchoice Then
            sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
            & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
            & " cramt > 0 and Pay_mode='CHEQUE' " _
            & " and vou_type='BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' order by cheque_no,cramt"
        Else
            sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
            & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
            & " cramt > 0 and Pay_mode='CHEQUE' " _
            & " and vou_type='BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date = '1900-1-1' order by cheque_no,cramt"
        End If
        GMod.DataSetRet(sql, "ch_issue")
        tr1 = GMod.ds.Tables("ch_issue").Rows.Count
        For i = 0 To GMod.ds.Tables("ch_issue").Rows.Count - 1
            sql = "select chddno,bankedate,cramt,dramt from " & GMod.BANK_STATE & " where dramt=" & GMod.ds.Tables("ch_issue").Rows(i)("cramt") & " and chddno = '" & GMod.ds.Tables("ch_issue").Rows(i)("Cheque_no") & "' and bank_acc_code ='" & cmbacheadcode.Text & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'"
            GMod.DataSetRet(sql, "ch_count")
            If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                sql &= "'4.ADD: Cheque issued but not present',"
                sql &= "'-',"
                sql &= "'-',"
                sql &= "'" & GMod.ds.Tables("ch_issue").Rows(i)("Vou_date") & "',"
                sql &= "'" & GMod.ds.Tables("ch_issue").Rows(i)("Cheque_no") & "',"
                sql &= "'" & Math.Abs(GMod.ds.Tables("ch_issue").Rows(i)("cramt")) & "')"
                getres = GMod.SqlExecuteNonQuery(sql)
            ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                tr2 = GMod.ds.Tables("ch_count").Rows.Count
                sql = "select count(*) from " & GMod.VENTRY & " where cramt=" & GMod.ds.Tables("ch_issue").Rows(i)("cramt") & " and cheque_no = '" & GMod.ds.Tables("ch_issue").Rows(i)("Cheque_no") & "' and acc_head_code ='" & cmbacheadcode.Text & "'"
                GMod.DataSetRet(sql, "ourbook_count")
                tr1 = GMod.ds.Tables("ourbook_count").Rows(0)(0)

                If tr2 > tr1 Then
                    For j = (tr2 - tr1 - 1) To tr2 - 1
                        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                        sql &= "'3.LESS: Amount Debited by bank',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("bankedate") & "',"
                        sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("chddno") & "',"
                        sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("dramt")) & "')"
                        getres = GMod.SqlExecuteNonQuery(sql)
                    Next
                End If
                i = i + tr1 - 1
            End If

        Next
        '2.Less : Amount Withdrawl but not present (B)
        If recchoice Then
            sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
            & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
            & " cramt>0 and Pay_mode<>'CHEQUE' " _
            & " and vou_type='BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "'"
        Else
            sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
            & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
            & " cramt>0 and Pay_mode<>'CHEQUE' " _
            & " and vou_type='BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date='1900-1-1'"
        End If

        GMod.DataSetRet(sql, "Amt_Withdrawal")
        tr1 = GMod.ds.Tables("Amt_Withdrawal").Rows.Count
        For i = 0 To GMod.ds.Tables("Amt_Withdrawal").Rows.Count - 1
            sql = "select * from " & GMod.BANK_STATE & " where dramt = " & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("cramt") & " and bankedate= '" _
            & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("Vou_date") & "' and paytype<>'CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'"
            GMod.DataSetRet(sql, "Amt_wd_count")
            If GMod.ds.Tables("Amt_wd_count").Rows.Count = 0 Then
                sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                sql &= "'4.ADD: Cheque issued but not present',"
                sql &= "'-',"
                sql &= "'-',"
                sql &= "'" & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("Vou_date") & "',"
                sql &= "'-',"
                sql &= "'" & Math.Abs(GMod.ds.Tables("Amt_Withdrawal").Rows(i)("cramt")) & "')"
                getres = GMod.SqlExecuteNonQuery(sql)
            ElseIf GMod.ds.Tables("Amt_wd_count").Rows.Count > 1 Then
                tr2 = GMod.ds.Tables("Amt_wd_count").Rows.Count
                sql = "select count(*) from " & GMod.VENTRY & " where cramt = " & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("cramt") & " and vou_date= '" _
                & GMod.ds.Tables("Amt_Withdrawal").Rows(i)("Vou_date") & "' and pay_mode<>'CHEQUE' and acc_head_code='" & cmbacheadcode.Text & "'"
                tr1 = GMod.ds.Tables("ourbook_count").Rows(0)(0)
                If tr1 < tr2 Then
                    For j = (tr2 - tr1 - 1) To tr2 - 1
                        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                        sql &= "'3.LESS: Amount Debited by bank',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'" & GMod.ds.Tables("Amt_wd_count").Rows(j)("bankedate") & "',"
                        sql &= "'-',"
                        sql &= "'" & Math.Abs(GMod.ds.Tables("Amt_wd_count").Rows(j)("dramt")) & "')"
                        getres = GMod.SqlExecuteNonQuery(sql)
                    Next
                End If
                i = i + tr1 - 1
            End If

        Next
        '***********************************************************************************************
        '3.ADD: Cheuqe deposite but not cleared (A)
        If recchoice Then
            sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
            & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
            & " dramt>0 and Pay_mode='CHEQUE' " _
            & " and vou_type='BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "'"
        Else
            sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
            & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
            & " dramt>0 and Pay_mode='CHEQUE' " _
            & " and vou_type='BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date='1900-1-1'"
        End If
        GMod.DataSetRet(sql, "ch_deposite")
        tr1 = GMod.ds.Tables("ch_deposite").Rows.Count
        For i = 0 To GMod.ds.Tables("ch_deposite").Rows.Count - 1
            sql = "select chddno,bankedate,cramt,dramt from " & GMod.BANK_STATE & " where cramt=" & GMod.ds.Tables("ch_deposite").Rows(i)("dramt") & " and bank_acc_code='" & cmbacheadcode.Text & "' and chddno = '" & GMod.ds.Tables("ch_deposite").Rows(i)("Cheque_no") & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'"
            GMod.DataSetRet(sql, "ch_count")
            If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
                sql &= "'-',"
                sql &= "'-',"
                sql &= "'" & GMod.ds.Tables("ch_deposite").Rows(i)("Vou_date") & "',"
                sql &= "'" & GMod.ds.Tables("ch_deposite").Rows(i)("Cheque_no") & "',"
                sql &= "'" & Math.Abs(GMod.ds.Tables("ch_deposite").Rows(i)("dramt")) & "')"
                getres = GMod.SqlExecuteNonQuery(sql)
            ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                tr2 = GMod.ds.Tables("ch_count").Rows.Count
                sql = "select count(*) from " & GMod.VENTRY & " where dramt=" & GMod.ds.Tables("ch_deposite").Rows(i)("dramt") & " and acc_head_code='" & cmbacheadcode.Text & "' and cheque_no = '" & GMod.ds.Tables("ch_deposite").Rows(i)("Cheque_no") & "'"
                GMod.DataSetRet(sql, "ourbook_count")

                If tr1 < tr2 Then
                    For j = (tr2 - tr1 - 1) To tr2 - 1
                        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                        sql &= "'2.ADD: Amount Credited by bank',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("bankedate") & "',"
                        sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("chddno") & "',"
                        sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
                        getres = GMod.SqlExecuteNonQuery(sql)
                    Next
                End If
                i = i + tr1 - 1
            End If

        Next
        '***********************************************************************************************
        '3.ADD: Amount deposite but not cleared by bank (B)
        If recchoice Then
            sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
            & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
            & " dramt>0 and Pay_mode<>'CHEQUE' " _
            & " and vou_type='BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' order by vou_date,dramt"
        Else
            sql = "select  Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, " _
            & " Cheque_no , Ch_issue_date, Ch_date from " & GMod.VENTRY & " where " _
            & " dramt>0 and Pay_mode<>'CHEQUE' " _
            & " and vou_type='BANKREC' and Acc_head_code='" & cmbacheadcode.Text & "' and ch_date='1900-1-1' order by vou_date,dramt"
        End If
        GMod.DataSetRet(sql, "amt_deposite")
        tr1 = GMod.ds.Tables("amt_deposite").Rows.Count
        For i = 0 To GMod.ds.Tables("amt_deposite").Rows.Count - 1
            sql = "select * from " & GMod.BANK_STATE & " where cramt = " & GMod.ds.Tables("amt_deposite").Rows(i)("dramt") & " and bankedate= '" _
            & GMod.ds.Tables("amt_deposite").Rows(i)("Vou_date") & "' and paytype<>'CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "' and bankedate<='" & dtTo.Value.ToShortDateString & "'"
            GMod.DataSetRet(sql, "ch_count")
            If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
                sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
                sql &= "'-',"
                sql &= "'-',"
                sql &= "'" & GMod.ds.Tables("amt_deposite").Rows(i)("Vou_date") & "',"
                sql &= "'-',"
                sql &= "'" & Math.Abs(GMod.ds.Tables("amt_deposite").Rows(i)("dramt")) & "')"
                getres = GMod.SqlExecuteNonQuery(sql)
            ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
                tr2 = GMod.ds.Tables("ch_count").Rows.Count
                sql = "select count(*) from " & GMod.VENTRY & " where dramt = " & GMod.ds.Tables("amt_deposite").Rows(i)("dramt") & " and vou_date= '" _
                & GMod.ds.Tables("amt_deposite").Rows(i)("Vou_date") & "' and pay_mode<>'CHEQUE' and acc_head_code='" & cmbacheadcode.Text & "'"
                GMod.DataSetRet(sql, "ourbook_count")
                tr1 = GMod.ds.Tables("ourbook_count").Rows(0)(0)
                If tr1 < tr2 Then
                    For j = (tr2 - tr1 - 1) To tr2 - 1
                        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
                        sql &= "'2.ADD: Amount Credited by bank',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("bankedate") & "',"
                        sql &= "'-',"
                        sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
                        getres = GMod.SqlExecuteNonQuery(sql)
                    Next
                End If
                i = i + tr1 - 1
            End If
        Next
        ''***********************************************************************************************
        ''4.ADD: Cheque debited by bank (A)
        'Dim bdt As Date
        'bdt = "4/1/" & GMod.Getsession(Now.ToShortDateString).Substring(0, 2)
        'If recchoice Then
        '    sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
        '    & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype='CHEQUE'"
        'Else
        '    sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
        '    & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and paytype='CHEQUE' and issuedate='1900-1-1'"
        'End If

        'GMod.DataSetRet(sql, "ch_debit")
        'tr1 = GMod.ds.Tables("ch_debit").Rows.Count
        'For i = 0 To GMod.ds.Tables("ch_debit").Rows.Count - 1
        '    sql = "select * from " & GMod.VENTRY & " where cramt=" & GMod.ds.Tables("ch_debit").Rows(i)("dramt") & " and acc_head_code='" & cmbacheadcode.Text & "' and Cheque_no='" & GMod.ds.Tables("ch_debit").Rows(i)("chddno") & "' and vou_type='BANKREC'"
        '    GMod.DataSetRet(sql, "ch_count")
        '    If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
        '        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        '        sql &= "'3.LESS: Amount Debited by bank ',"
        '        sql &= "'-',"
        '        sql &= "'-',"
        '        sql &= "'" & GMod.ds.Tables("ch_debit").Rows(i)("bankedate") & "',"
        '        sql &= "'" & GMod.ds.Tables("ch_debit").Rows(i)("chddno") & "',"
        '        sql &= "'" & Math.Abs(GMod.ds.Tables("ch_debit").Rows(i)("dramt")) & "')"
        '        getres = GMod.SqlExecuteNonQuery(sql)
        '    ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
        '        tr2 = GMod.ds.Tables("ch_count").Rows.Count
        '        sql = "select count(*) from " & GMod.BANK_STATE & " where dramt=" & GMod.ds.Tables("ch_debit").Rows(i)("dramt") & " and bank_acc_code='" & cmbacheadcode.Text & "' and Chddno='" & GMod.ds.Tables("ch_debit").Rows(i)("chddno") & "'"
        '        GMod.DataSetRet(sql, "bankstate_count")
        '        tr1 = GMod.ds.Tables("bankstate_count").Rows(0)(0)
        '        If tr1 < tr2 Then
        '            For j = (tr2 - tr1 - 1) To tr2 - 1
        '                sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        '                sql &= "'4.ADD: Cheque issued but not present',"
        '                sql &= "'-',"
        '                sql &= "'-',"
        '                sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
        '                sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("cheque_no") & "',"
        '                sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
        '                getres = GMod.SqlExecuteNonQuery(sql)
        '            Next
        '        End If
        '        i = i + tr1 - 1
        '    End If

        'Next
        ''**************************************************************************************************************
        ''4.ADD: Amount debited by bank (B)
        'If recchoice Then
        '    sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
        '    & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate <= '" _
        '    & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE'"
        'Else
        '    sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
        '    & " where dramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate <= '" _
        '    & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE' and issuedate='1900-1-1'"
        'End If

        'GMod.DataSetRet(sql, "amt_debit")
        'tr1 = GMod.ds.Tables("amt_debit").Rows.Count
        'For i = 0 To GMod.ds.Tables("amt_debit").Rows.Count - 1
        '    sql = "select * from " & GMod.VENTRY & " where cramt=" & GMod.ds.Tables("amt_debit").Rows(i)("dramt") & " and Vou_date='" & GMod.ds.Tables("amt_debit").Rows(i)("bankedate") & "' and Pay_mode<>'CHEQUE' and acc_head_code='" & cmbacheadcode.Text & "'"
        '    GMod.DataSetRet(sql, "ch_count")
        '    If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
        '        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        '        sql &= "'3.LESS: Amount Debited by bank dddd',"
        '        sql &= "'-',"
        '        sql &= "'-',"
        '        sql &= "'" & GMod.ds.Tables("amt_debit").Rows(i)("bankedate") & "',"
        '        sql &= "'-',"
        '        sql &= "'" & Math.Abs(GMod.ds.Tables("amt_debit").Rows(i)("dramt")) & "')"
        '        getres = GMod.SqlExecuteNonQuery(sql)
        '    ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
        '        tr2 = GMod.ds.Tables("ch_count").Rows.Count
        '        sql = "select count(*) from " & GMod.BANK_STATE & " where dramt=" & GMod.ds.Tables("amt_debit").Rows(i)("dramt") & " and bankedate='" & GMod.ds.Tables("amt_debit").Rows(i)("bankedate") & "' and Paytype<>'CHEQUE' and bank_acc_code='" & cmbacheadcode.Text & "'"
        '        GMod.DataSetRet(sql, "book_count")
        '        tr1 = GMod.ds.Tables("book_count").Rows(0)(0)
        '        If tr1 < tr2 Then
        '            For j = (tr2 - tr1 - 1) To tr2 - 1
        '                sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        '                sql &= "'4.ADD: Cheque issued but not present',"
        '                sql &= "'-',"
        '                sql &= "'-',"
        '                sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
        '                sql &= "'-',"
        '                sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("cramt")) & "')"
        '                getres = GMod.SqlExecuteNonQuery(sql)
        '            Next
        '        End If
        '        i = i + tr1 - 1
        '    End If

        'Next
        ''***********************************************************************************************
        ''5.LESS: Cheque Credited by bank (A)
        'If recchoice Then
        '    sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
        '    & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate <= '" _
        '    & dtTo.Value.ToShortDateString & "' and paytype='CHEQUE'"
        'Else
        '    sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
        '    & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate <= '" _
        '    & dtTo.Value.ToShortDateString & "' and paytype='CHEQUE' and issuedate='1900-1-1'"
        'End If
        'GMod.DataSetRet(sql, "ch_credit")
        'tr1 = GMod.ds.Tables("ch_credit").Rows.Count
        'For i = 0 To GMod.ds.Tables("ch_credit").Rows.Count - 1
        '    sql = "select * from " & GMod.VENTRY & " where dramt=" & GMod.ds.Tables("ch_credit").Rows(i)("cramt") & " and acc_head_code='" & cmbacheadcode.Text & "' and  Cheque_no='" & GMod.ds.Tables("ch_credit").Rows(i)("chddno") & "'"
        '    GMod.DataSetRet(sql, "ch_count")
        '    If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
        '        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        '        sql &= "'2.ADD: Amount Credited by bank',"
        '        sql &= "'-',"
        '        sql &= "'-',"
        '        sql &= "'" & GMod.ds.Tables("ch_credit").Rows(i)("bankedate") & "',"
        '        sql &= "'" & GMod.ds.Tables("ch_credit").Rows(i)("chddno") & "',"
        '        sql &= "'" & Math.Abs(GMod.ds.Tables("ch_credit").Rows(i)("cramt")) & "')"
        '        getres = GMod.SqlExecuteNonQuery(sql)
        '    ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
        '        tr2 = GMod.ds.Tables("ch_count").Rows.Count
        '        sql = "select count(*) from " & GMod.BANK_STATE & " where cramt=" & GMod.ds.Tables("ch_credit").Rows(i)("cramt") & " and bank_acc_code='" & cmbacheadcode.Text & "' and chddno='" & GMod.ds.Tables("ch_credit").Rows(i)("chddno") & "'"
        '        GMod.DataSetRet(sql, "bank_count")
        '        tr1 = GMod.ds.Tables("bank_count").Rows(0)(0)
        '        If tr1 < tr2 Then
        '            For j = (tr2 - tr1 - 1) To tr2 - 1
        '                sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        '                sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
        '                sql &= "'-',"
        '                sql &= "'-',"
        '                sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
        '                sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("cheque_no") & "',"
        '                sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("dramt")) & "')"
        '                getres = GMod.SqlExecuteNonQuery(sql)
        '            Next
        '        End If
        '        i = i + tr1 - 1
        '    End If

        'Next

        ''5. LESS: Amount Credited by Bank (B)
        'If recchoice Then
        '    sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
        '    & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate <= '" _
        '    & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE'"
        'Else
        '    sql = "select bank_acc_code, bankedate, paytype,  chddno, dramt, cramt from " & GMod.BANK_STATE & "" _
        '    & " where cramt > 0 and  bank_acc_code='" & cmbacheadcode.Text & "' and bankedate <= '" _
        '    & dtTo.Value.ToShortDateString & "' and paytype<>'CHEQUE' and issuedate='1900-1-1'"
        'End If
        'GMod.DataSetRet(sql, "amt_credit")
        'tr1 = GMod.ds.Tables("amt_credit").Rows.Count
        'For i = 0 To GMod.ds.Tables("amt_credit").Rows.Count - 1
        '    sql = "select * from " & GMod.VENTRY & " where acc_head_code='" & cmbacheadcode.Text & "' and dramt=" & GMod.ds.Tables("amt_credit").Rows(i)("cramt") _
        '    & " and Vou_date='" & CDate(GMod.ds.Tables("amt_credit").Rows(i)("bankedate")) & "' and pay_mode<>'CHEQUE'"
        '    'MsgBox(sql)
        '    GMod.DataSetRet(sql, "ch_count")
        '    If GMod.ds.Tables("ch_count").Rows.Count = 0 Then
        '        sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        '        sql &= "'2.ADD: Amount Credited by bank',"
        '        sql &= "'-',"
        '        sql &= "'-',"
        '        sql &= "'" & GMod.ds.Tables("amt_credit").Rows(i)("bankedate") & "',"
        '        sql &= "'-',"
        '        sql &= "'" & Math.Abs(GMod.ds.Tables("amt_credit").Rows(i)("cramt")) & "')"
        '        getres = GMod.SqlExecuteNonQuery(sql)
        '    ElseIf GMod.ds.Tables("ch_count").Rows.Count > 1 Then
        '        tr2 = GMod.ds.Tables("ch_count").Rows.Count
        '        sql = "select count(*) from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacheadcode.Text & "' and cramt=" & GMod.ds.Tables("amt_credit").Rows(i)("cramt") _
        '        & " and bankedate='" & CDate(GMod.ds.Tables("amt_credit").Rows(i)("bankedate")) & "' and paytype<>'CHEQUE'"
        '        GMod.DataSetRet(sql, "bank_count")
        '        tr1 = GMod.ds.Tables("bank_count").Rows(0)(0)

        '        If tr1 < tr2 Then
        '            For j = (tr2 - tr1 - 1) To tr2 - 1
        '                sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        '                sql &= "'5.LESS: Cheque deposite but not cleared by bank',"
        '                sql &= "'-',"
        '                sql &= "'-',"
        '                sql &= "'" & GMod.ds.Tables("ch_count").Rows(j)("vou_date") & "',"
        '                sql &= "'-',"
        '                sql &= "'" & Math.Abs(GMod.ds.Tables("ch_count").Rows(j)("dramt")) & "')"
        '                getres = GMod.SqlExecuteNonQuery(sql)
        '            Next
        '        End If
        '        i = i + tr1 - 1
        '    End If

        'Next
        '******************************************************************************************
        ''6. Less: Opening Difference 
        'OpeningBankStatement(dtfrom.Value)
        'CalcBankOpening()
        'opndiff = opening - opnbakstate
        'sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        'sql &= "'6. Less: Opening Difference ',"
        'sql &= "'-',"
        'sql &= "'-',"
        'sql &= "'" & dtTo.Text & "',"
        'sql &= "'-',"
        'sql &= "" & Math.Abs(opndiff) & ")"
        ''getres = GMod.SqlExecuteNonQuery(sql)
        ''******************************************************************************************
        ''7. Balance as per bank statement
        'OpeningBankStatement(dtTo.Value)
        'sql = "insert into Bank_rec(Rec_head, Acc_head_code, Acc_head, Issue_date, Chq_No, Amt) values ("
        'sql &= "'7. Balance as per Bank Statement',"
        'sql &= "'-',"
        'sql &= "'-',"
        'sql &= "'" & dtTo.Text & "',"
        'sql &= "'-',"
        'sql &= "" & opnbakstate & ")"
        'getres = GMod.SqlExecuteNonQuery(sql)

    End Sub

    Private Sub cmbAreaCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaCode.KeyDown
        If e.KeyCode = Keys.Enter Then cmbAreaName.Focus()
    End Sub

    Private Sub cmbAreaName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacheadname.Focus()
    End Sub

    Private Sub cmbacheadcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadcode.KeyDown
        If e.KeyCode = Keys.Enter Then dtfrom.Focus()
    End Sub

    Private Sub cmbacheadname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacheadcode.Focus()
    End Sub

    Private Sub dtfrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtfrom.KeyDown
        If e.KeyCode = Keys.Enter Then dtTo.Focus()
    End Sub

    Private Sub dtTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtTo.KeyDown
        If e.KeyCode = Keys.Enter Then btnshow.Focus()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim cr As New CrBankrec
        Dim sql As String
        Dim bankbal, bal, addamt, lessamt As Double
        sql = "select * from bank_rec order by rec_head,issue_date"
        GMod.DataSetRet(sql, "recon2")
        cr.SetDataSource(GMod.ds.Tables("recon2"))
        cr.SetParameterValue("cname", GMod.Cmpname)
        cr.SetParameterValue("head1", "Bank Reconcilation between " & dtfrom.Text & " and " & dtTo.Text)
        cr.SetParameterValue("head2", cmbacheadcode.Text & " - " & cmbacheadname.Text)

        '--------------Passing Pramerte---------
        Dim sqlSummary As String
        '1.Balance As per Our Book
        sqlSummary = "select sum(Amt) from bank_rec where rec_head='1.Balance As per Our Book'"
        GMod.DataSetRet(sqlSummary, "One")
        If GMod.ds.Tables("One").Rows.Count > 0 Then
            cr.SetParameterValue("a", Val(GMod.ds.Tables("One").Rows(0)(0).ToString))
        Else
            cr.SetParameterValue("a", 0)
        End If
        '2.ADD: Amount Credited by bank
        sqlSummary = "select sum(Amt) from bank_rec where rec_head='2.ADD: Amount Credited by bank'"
        GMod.DataSetRet(sqlSummary, "Two")
        If GMod.ds.Tables("Two").Rows.Count > 0 Then
            cr.SetParameterValue("b", Val(GMod.ds.Tables("Two").Rows(0)(0).ToString))
        Else
            cr.SetParameterValue("b", 0)
        End If
        '3.LESS: Amount Debited by bank
        sqlSummary = "select sum(Amt) from bank_rec where rec_head='3.LESS: Amount Debited by bank'"
        GMod.DataSetRet(sqlSummary, "Three")
        If GMod.ds.Tables("Three").Rows.Count > 0 Then
            cr.SetParameterValue("c", Val(GMod.ds.Tables("Three").Rows(0)(0).ToString))
        Else
            cr.SetParameterValue("c", 0)
        End If

        '4.ADD: Cheque issued but not present
        sqlSummary = "select sum(Amt) from bank_rec where rec_head='4.ADD: Cheque issued but not present'"
        GMod.DataSetRet(sqlSummary, "Four")
        If GMod.ds.Tables("Four").Rows.Count > 0 Then
            cr.SetParameterValue("d", Val(GMod.ds.Tables("Four").Rows(0)(0).ToString))
        Else
            cr.SetParameterValue("d", 0)
        End If

        '5.LESS: Cheque deposite but not cleared by bank
        sqlSummary = "select sum(Amt) from bank_rec where rec_head='5.LESS: Cheque deposite but not cleared by bank'"
        GMod.DataSetRet(sqlSummary, "Five")
        If GMod.ds.Tables("Five").Rows.Count > 0 Then
            cr.SetParameterValue("e", Val(GMod.ds.Tables("Five").Rows(0)(0).ToString))
        Else
            cr.SetParameterValue("e", 0)
        End If
        'cr.SetParameterValue("baspb", opening)
        ' If opening < 0 Then
        cr.SetParameterValue("f1", "ADD")
        cr.SetParameterValue("f2", "LESS")
        cr.SetParameterValue("f3", "ADD")
        cr.SetParameterValue("f4", "LESS")
        'Else
        'cr.SetParameterValue("f1", "LESS")
        'cr.SetParameterValue("f2", "ADD")
        'cr.SetParameterValue("f3", "LESS")
        'cr.SetParameterValue("f4", "ADD")
        'End If
        '---------------------------------------------------------------
        CrViewerBankrec.ReportSource = cr
        'CrViewerBankrec.PrintReport()
        CrViewerBankrec.BringToFront()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpeningBankStatement(dtTo.Value)
        MsgBox(opnbakstate)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GMod.SqlExecuteNonQuery("delete from bank_rec")
        recon2()
        recon3()
    End Sub
End Class