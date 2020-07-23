Public Class frmCashBook

    Private Sub frmCashBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        'Seeting Session Start DATE
        Dim sdate As String = "4/1/" & GMod.Session.Substring(0, 2).ToString
        dtfrom.Value = CDate(sdate)
        CrViewerGenralLedger.Height = Me.Height - 120
        DataGridView1.Location = CrViewerGenralLedger.Location
        DataGridView1.Height = Me.Height - 120
        DataGridView1.Width = CrViewerGenralLedger.Width
        'rdscreen_Click(sender, e)
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim dtInc As DateTime
        Dim n, i As Integer
        n = DateDiff(DateInterval.Day, dtfrom.Value, dtto.Value)
        dtInc = dtfrom.Value
        Try
            'dleting old data for that use 
            GMod.SqlExecuteNonQuery("delete  from repGeneralLedger where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
            'Calulating openng and inserint into table 
            Dim sqlopen As String
            Dim opnbal, dr, cr As Double
            Dim sqlcashdel As String
            For i = 0 To n

                sqlopen = 0
                dr = 0
                cr = 0
                opnbal = 0
                sqlcashdel = "select account_code,group_name,sub_group_name from " & GMod.ACC_HEAD & " where account_head_name='CASH'"
                GMod.DataSetRet(sqlcashdel, "CashDet")

                sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                          & " " & GMod.VENTRY & " where Acc_head_code='" & GMod.ds.Tables("cashdet").Rows(0)(0) & "' and  vou_date <'" & dtInc.ToShortDateString & "'"
                GMod.DataSetRet(sqlopen, "opening")
                opnbal = CDbl(GMod.ds.Tables("opening").Rows(0)(0))
                GMod.ds.Tables("opening").Clear()
                sqlopen = "select isnull(sum(opening_dr),0) - isnull(sum(opening_cr),0) from " & GMod.ACC_HEAD _
                           & " where Account_code='" & GMod.ds.Tables("cashdet").Rows(0)(0) & "'"
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
                sqlsave = "insert into repGeneralLedger(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname,Vou_date)  values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.ds.Tables("cashdet").Rows(0)(0) & "',"
                sqlsave &= "'CASH BALANCE B/F',"
                sqlsave &= "'OPEN',"
                sqlsave &= "'" & (dr.ToString) & "',"
                sqlsave &= "'" & cr.ToString & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'" & dtInc.ToShortDateString & "')"
                GMod.SqlExecuteNonQuery(sqlsave)

                '------------------------------------------------------------------------------------------------------
                'Now inserting transtion os that accont head 

                'sqlsave = "insert into repGeneralLedger(cmpid, Acc_head_code, Narration, Vou_no,vou_type, dramt, cramt, Cheque_no, Uname) " _
                sqlsave = " select Cmp_id,Acc_head_code,Narration+ ' ' + Cheque_no,Vou_no,Vou_type,dramt,cramt,Cheque_no ,'" & GMod.username & "' from " & GMod.VENTRY _
                    & " where vou_date = '" & dtInc.ToShortDateString & "' and Acc_head_code='" & GMod.ds.Tables("cashdet").Rows(0)(0) & "' order by vou_date,Cheque_no"
                GMod.DataSetRet(sqlsave, "det")

                '---------------------------------------------------------------------------

                'Adding TotAL OF DAY
                sqlsave = " insert into repGeneralLedger(cmpid, Narration,vou_type, " _
                           & " dramt, cramt, Uname) select '" & GMod.Cmpid & "','TOTAL','-',sum(dramt),sum(cramt) ,'" & GMod.username _
                & "' from " & GMod.VENTRY & " where vou_date<='" & dtInc.ToShortDateString & "' and Acc_head_code='" & GMod.ds.Tables("cashdet").Rows(0)(0) & "'"
                GMod.SqlExecuteNonQuery(sqlsave)

                sqlsave = "insert into repGeneralLedger(cmpid, Narration,vou_type, " _
                           & "dramt, cramt, Uname) select '" & GMod.Cmpid & "','BALANCE','-',case " _
                            & "when sum(dramt)-sum(cramt)>0 then sum(dramt)-sum(cramt)" _
                            & "else 0 end dr,case 	when sum(dramt)-sum(cramt)<0 then sum(dramt)-sum(cramt)" _
                            & "else 0 end ,'" & GMod.username & "' from " & GMod.VENTRY & _
                            " where vou_date<='" & dtInc.ToShortDateString & "' and Acc_head_code='" & GMod.ds.Tables("cashdet").Rows(0)(0) & "'"
                GMod.SqlExecuteNonQuery(sqlsave)


                dtInc = dtInc.AddDays(1)
            Next
            cal_gen_bal()
            '------------------------------------------------------------------------------------------------
            GMod.DataSetRet("select Vou_date,NARRATION,Cheque_no,dramt,cramt,Balance from repGeneralLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by trans_id", "ledCash")
            Dim r As New CrCashBook
            r.SetDataSource(GMod.ds.Tables("ledCash"))
            r.SetParameterValue("cmpname", GMod.Cmpname)
            r.SetParameterValue("accholder", "Account Holder : " & GMod.ds.Tables("cashdet").Rows(0)(0))
            r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtto.Text)
            'If rdprint.Checked Then
            CrViewerGenralLedger.ReportSource = r
            'Else
            Me.DataGridView1.DataSource = GMod.ds.Tables("ledCash")
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rdscreen_Click(sender, e)
    End Sub
    Private Sub frmCashBook_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            GMod.ds.Tables("ledCash").Dispose()
            GMod.ds.Tables("ba").Dispose()
            GMod.ds.Tables("ledCAshBook").Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub rdscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdscreen.Click
        If rdscreen.Checked = True Then
            ' btnshow_Click(sender, e)
            DataGridView1.BringToFront()
            CrViewerGenralLedger.SendToBack()
            'Inserting Total and Balance
            'Dim sqlsave As String
            'sqlsave = " insert into repGeneralLedger(cmpid, Narration,vou_type, " _
            '           & " dramt, cramt, Uname) select '" & GMod.Cmpid & "','TOTAL','-',sum(dramt),sum(cramt) ,'" & GMod.username & "' from repGeneralLedger where Uname='" & GMod.username & "'"
            'GMod.SqlExecuteNonQuery(sqlsave)
            'sqlsave = "insert into repGeneralLedger(cmpid, Narration,vou_type, " _
            '           & "dramt, cramt, Uname) select '" & GMod.Cmpid & "','BALANCE','-',case " _
            '            & "when sum(dramt)-sum(cramt)>0 then sum(dramt)-sum(cramt)" _
            '            & "else 0 end dr,case 	when sum(dramt)-sum(cramt)<0 then sum(dramt)-sum(cramt)" _
            '            & "else 0 end ,'" & GMod.username & "' from  repGeneralLedger where Uname='" _
            '            & GMod.username & "' and Narration<>'TOTAL'"
            'GMod.SqlExecuteNonQuery(sqlsave)
            cal_gen_bal()
            GMod.DataSetRet("select Vou_date,NARRATION,Cheque_no,dramt,cramt,Balance from repGeneralLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by trans_id", "ledCAshBook")
            Me.DataGridView1.DataSource = GMod.ds.Tables("ledCAshBook")
            rdscreen.Enabled = False
            rdprint.Enabled = True
        End If
    End Sub

    Private Sub rdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdprint.Click
        If rdprint.Checked = True Then
            DataGridView1.SendToBack()
            CrViewerGenralLedger.BringToFront()
            'GMod.SqlExecuteNonQuery("delete from repGeneralLedger where Narration in ('TOTAL','BALANCE') AND cmpid='" & GMod.Cmpid & "'")
            rdscreen.Enabled = True
            rdprint.Enabled = False
        End If
    End Sub
    Sub cal_gen_bal()
        GMod.DataSetRet("select * from repGeneralLedger where cmpid='" & GMod.Cmpid & "' and Narration not in ('TOTAL','BALANCE','CASH BALANCE B/F') and uname='" & GMod.username & "' order by trans_id", "ba")
        Dim i As Integer
        Dim prbal, bal As Double
        prbal = 0
        prbal = GMod.ds.Tables("ba").Rows(i)("dramt") - GMod.ds.Tables("ba").Rows(i)("cramt")
        GMod.SqlExecuteNonQuery("update repGeneralLedger set balance=" & prbal & " where trans_id=" & GMod.ds.Tables("ba").Rows(i)("trans_id"))
        For i = 0 To GMod.ds.Tables("ba").Rows.Count - 2
            bal = prbal + (GMod.ds.Tables("ba").Rows(i + 1)("dramt") - GMod.ds.Tables("ba").Rows(i + 1)("cramt"))
            GMod.SqlExecuteNonQuery("update repGeneralLedger set balance=" & prbal & " where trans_id=" & GMod.ds.Tables("ba").Rows(i + 1)("trans_id"))
            prbal = bal
            GMod.SqlExecuteNonQuery("update repGeneralLedger set balance=" & prbal & " where trans_id=" & GMod.ds.Tables("ba").Rows(i + 1)("trans_id"))
        Next
    End Sub
    Public Sub closing()

    End Sub
End Class