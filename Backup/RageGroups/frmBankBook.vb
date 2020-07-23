Public Class frmBankBook

    Private Sub frmBankBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        Dim sql As String
        sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
               & " and group_name  in ('BANK') order by account_head_name"
        GMod.DataSetRet(sql, "accheadbank")
        cmbacheadcode.DataSource = GMod.ds.Tables("accheadbank")
        cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("accheadbank")
        cmbacheadname.DisplayMember = "account_head_name"

        CrViewerGenralLedger.Height = Me.Height - 150
        dgGridLeger.Location = CrViewerGenralLedger.Location

        dgGridLeger.Height = CrViewerGenralLedger.Height - 30
        dgGridLeger.Width = CrViewerGenralLedger.Width

    End Sub
    Sub total()
        Dim sqlsave As String
        'Inserting Total and Balance
        sqlsave = " insert into repGeneralLedger(cmpid, Narration,vou_type, " _
                   & " dramt, cramt, Uname) select '" & GMod.Cmpid & "','TOTAL','-',sum(dramt),sum(cramt) ,'" & GMod.username & "' from repGeneralLedger where Uname='" & GMod.username & "'"
        GMod.SqlExecuteNonQuery(sqlsave)


        sqlsave = "insert into repGeneralLedger(cmpid, Narration,vou_type, " _
                   & "dramt, cramt, Uname) select '" & GMod.Cmpid & "','BALANCE','-',case " _
                    & "when sum(dramt)-sum(cramt)>0 then sum(dramt)-sum(cramt)" _
                    & "else 0 end dr,case 	when sum(dramt)-sum(cramt)<0 then sum(dramt)-sum(cramt)" _
                    & "else 0 end ,'" & GMod.username & "' from  repGeneralLedger where Uname='" & GMod.username & "' and Narration<>'TOTAL'"

        GMod.SqlExecuteNonQuery(sqlsave)
    End Sub

    Private Sub rdOnscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdOnscreen.Click
        If rdOnscreen.Checked = True Then
            dgGridLeger.BringToFront()
            CrViewerGenralLedger.SendToBack()
            total()
            GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,balance,Ch_date  from repGeneralLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by trans_id ", "led")
            Me.dgGridLeger.DataSource = GMod.ds.Tables("led")
            rdOnscreen.Enabled = False
            rdPrint.Enabled = True
        End If
    End Sub

    Private Sub rdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPrint.Click
        If rdPrint.Checked = True Then
            dgGridLeger.SendToBack()
            CrViewerGenralLedger.BringToFront()
            GMod.SqlExecuteNonQuery("delete from repGeneralLedger where narration in ('TOTAL','BALANCE') AND cmpid='" & GMod.Cmpid & "'")
            rdOnscreen.Enabled = True
            rdPrint.Enabled = False
        End If
    End Sub
    Dim grp As String

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        grp = "PARTY"
        Try
            'dleting old data for that use 
            GMod.SqlExecuteNonQuery("delete  from repGeneralLedger where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
            'Calulating openng and inserint into table 
            Dim sqlopen As String
            Dim opnbal, dr, cr As Double
            sqlopen = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                      & " " & GMod.VENTRY & " where Acc_head_code='" & cmbacheadcode.Text & "' and  vou_date<'" & dtfrom.Text & "' and vou_type<>'BANKREC'"
            GMod.DataSetRet(sqlopen, "opening")
            opnbal = CDbl(GMod.ds.Tables("opening").Rows(0)(0))
            GMod.ds.Tables("opening").Clear()
            sqlopen = "select isnull(sum(opening_dr),0) - isnull(sum(opening_cr),0) from " & GMod.ACC_HEAD _
                       & " where Account_code='" & cmbacheadcode.Text & "'"
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
            sqlsave = "insert into repGeneralLedger(cmpid, Acc_head_code, Narration,vou_type, dramt, cramt, Uname)  values ("
            sqlsave &= "'" & GMod.Cmpid & "',"
            sqlsave &= "'" & cmbacheadcode.Text & "',"
            sqlsave &= "'OLD BALANCE',"
            sqlsave &= "'OPEN',"
            sqlsave &= "'" & (dr.ToString) & "',"
            sqlsave &= "'" & cr.ToString & "',"
            sqlsave &= "'" & GMod.username & "')"
            GMod.SqlExecuteNonQuery(sqlsave)
            '------------------------------------------------------------------------------------------------------
            'Now inserting transtion os that accont head 
            If grp <> "PARTY" Or grp <> "CUSTOMER" Then
                sqlsave = "insert into repGeneralLedger(cmpid, Acc_head_code, Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, Cheque_no,Ch_date, Uname) " _
                & " select v.Cmp_id,Acc_head_code,Narration,Vou_no,Vou_date,Vou_type,v.dramt,v.cramt,Cheque_no ,b.bankedate,'" & GMod.username & "' from " & GMod.VENTRY _
                & " v left join " & GMod.BANK_STATE & " b on v.Acc_head_code =b.bank_acc_code  and v.Cheque_no=b.chddno where vou_date between '" & dtfrom.Text & "' and '" & dtTo.Text & "' and Acc_head_code='" & cmbacheadcode.Text & "' and vou_type<>'BANKREC' order by vou_date"
                GMod.SqlExecuteNonQuery(sqlsave)
                cal_gen_bal()
            End If
            '------------------------------------------------------------------------------------------------


            GMod.DataSetRet("select Narration, Vou_no, Vou_date,  vou_type, dramt, cramt, balance  from repGeneralLedger where uname='" & GMod.username & "' and cmpid='" & GMod.Cmpid & "' order by trans_id", "led5")

            Dim r1 As New CrBankBook
            r1.SetDataSource(GMod.ds.Tables("led5"))
            r1.SetParameterValue("cmpname", GMod.Cmpname)
            r1.SetParameterValue("accholder", "Account Holder : " & cmbacheadcode.Text & " " & cmbacheadname.Text)
            r1.SetParameterValue("subhead", "Date  :" & dtfrom.Text & " to " & dtTo.Text)

            CrViewerGenralLedger.ReportSource = r1

            'For displaying in Data grid  setting fields--------------------
            rdOnscreen_Click(sender, e)

            '----------------------------------------------------------------

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cal_gen_bal()
        GMod.DataSetRet("select * from repGeneralLedger where cmpid='" & GMod.Cmpid & "' and Narration not in ('TOTAL','BALANCE') and uname='" & GMod.username & "' order by trans_id", "ba")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub frmBankBook_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            GMod.ds.Tables("led").Dispose()
            GMod.ds.Tables("ba").Dispose()
            GMod.ds.Tables("led5").Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class