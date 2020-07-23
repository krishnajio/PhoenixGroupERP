Public Class frmCashBook2

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim dtInc As DateTime
        Dim n, i, j As Integer
        dg.Rows.Clear()
        n = DateDiff(DateInterval.Day, dtfrom.Value, dtto.Value)
        dtInc = dtfrom.Value
        Try
            'dleting old data for that use 
            GMod.SqlExecuteNonQuery("delete  from repGeneralLedger where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
            'Calulating openng and inserint into table 
            Dim sqlopen As String
            Dim opnbal, dr, cr As Double
            Dim sqlcashdel As String

            sqlopen = 0.0
            dr = 0.0
            cr = 0.0
            opnbal = 0.0
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
            Dim bal As Double = 0
            dg.Rows.Add()
            dg(0, 0).Style.BackColor = Color.LightBlue
            dg(1, 0).Style.BackColor = Color.LightBlue
            dg(0, 0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg(1, 0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg(2, 0).Style.BackColor = Color.LightBlue
            dg(3, 0).Style.BackColor = Color.LightBlue
            dg(4, 0).Style.BackColor = Color.LightBlue
            dg(0, 0).Value = dtInc
            dg(1, 0).Value = "CASH BALANCE B/F"
            dg(2, 0).Value = dr
            dg(3, 0).Value = cr
            bal = dr - cr
            dg(4, 0).Value = bal
            '------------------------------------------------------------------------------------------------------
            'Now inserting transtion os that accont head 

            'sqlsave = "insert into repGeneralLedger(cmpid, Acc_head_code, Narration, Vou_no,vou_type, dramt, cramt, Cheque_no, Uname) " _


            'select v.Cmp_id,Acc_head_code,Narration+ ' ' + v.Cheque_no as 
            'narration,Vou_no,Vou_type,dramt,cramt,v.Cheque_no ,'nema',
            'vou_date,receipt_id from VENTRY_RAFI_0809 v,CHQ_ISSUED_RAFI_0809 i
            ' where vou_date = '4/9/2008' and 
            'Acc_head_code='**CA0001' and v.vou_no=i.vouno order by receipt_id

            sqlsave = " select v.Cmp_id,Acc_head_code,Narration+ ' ' + v.Cheque_no as narration,Vou_no,Vou_type,dramt,cramt,v.Cheque_no ,'" & GMod.username & "',vou_date from " & GMod.VENTRY _
            & " v" _
            & " where vou_date = '" & dtInc.ToShortDateString & "' and Acc_head_code='" & GMod.ds.Tables("cashdet").Rows(0)(0) & "' order by vou_type,vou_no"
            GMod.DataSetRet(sqlsave, "det")
            Dim nr() As String
            Dim r As Integer = 1
            For j = 0 To ds.Tables("det").Rows.Count - 1
                dg.Rows.Add()
                nr = GMod.ds.Tables("det").Rows(j)("narration").ToString.Split(",")
                dg(0, r).Style.BackColor = Color.Honeydew
                dg(1, r).Style.BackColor = Color.Honeydew
                dg(2, r).Style.BackColor = Color.Honeydew
                dg(3, r).Style.BackColor = Color.Honeydew
                dg(4, r).Style.BackColor = Color.Honeydew
                dg(0, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg(1, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                dg(0, r).Value = GMod.ds.Tables("det").Rows(j)("vou_date")
                dg(1, r).Value = nr(0)
                dg(2, r).Value = GMod.ds.Tables("det").Rows(j)("dramt")
                dg(3, r).Value = GMod.ds.Tables("det").Rows(j)("cramt")
                bal = bal + Val(GMod.ds.Tables("det").Rows(j)("dramt")) - Val(GMod.ds.Tables("det").Rows(j)("cramt"))
                dg(4, r).Value = bal
                dg.Rows.Add()
                r = r + 1
                dg(0, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg(1, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg(0, r).Value = GMod.ds.Tables("det").Rows(j)("vou_no")
                If nr.Length = 2 Then dg(1, r).Value = nr(1)
                r = r + 1
            Next

            '---------------------------------------------------------------------------

            'Adding TotAL OF DAY
            sqlsave = " select '" & GMod.Cmpid & "','TOTAL','-',sum(dramt) dramt,sum(cramt) cramt,'" & GMod.username _
            & "' from " & GMod.VENTRY & " where vou_date ='" & dtInc.ToShortDateString & "' and Acc_head_code='" & GMod.ds.Tables("cashdet").Rows(0)(0) & "'"
            GMod.DataSetRet(sqlsave, "tot")

            dg.Rows.Add()
            dg(0, r).Style.BackColor = Color.Aqua
            dg(1, r).Style.BackColor = Color.Aqua
            dg(2, r).Style.BackColor = Color.Aqua
            dg(3, r).Style.BackColor = Color.Aqua
            dg(4, r).Style.BackColor = Color.Aqua
            dg(0, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg(1, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg(0, r).Value = dtInc
            dg(1, r).Value = "TOTAL "
            dg(2, r).Value = Val(GMod.ds.Tables("tot").Rows(0)("dramt")) + Val(dg(2, 0).Value)
            dg(3, r).Value = Val(GMod.ds.Tables("tot").Rows(0)("cramt")) + Val(dg(3, 0).Value)
            r = r + 1
            sqlsave = " select '" & GMod.Cmpid & "','BALANCE','-',case " _
                        & "when sum(dramt)-sum(cramt)>0 then sum(dramt)-sum(cramt)" _
                        & "else 0 end dr,case 	when sum(dramt)-sum(cramt)<0 then sum(dramt)-sum(cramt)" _
                        & "else 0 end cr,'" & GMod.username & "' from " & GMod.VENTRY & _
                        " where vou_date<='" & dtInc.ToShortDateString & "' and Acc_head_code='" & GMod.ds.Tables("cashdet").Rows(0)(0) & "'"
            GMod.DataSetRet(sqlsave, "bal")
            dg.Rows.Add()
            dg(0, r).Style.BackColor = Color.Aqua
            dg(1, r).Style.BackColor = Color.Aqua
            dg(2, r).Style.BackColor = Color.Aqua
            dg(0, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg(1, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            If GMod.ds.Tables("bal").Rows(0)("cr") > 0 Then dg(3, r).Style.BackColor = Color.LightPink Else dg(3, r).Style.BackColor = Color.Aqua
            dg(4, r).Style.BackColor = Color.Aqua
            dg(0, r).Value = dtInc
            dg(1, r).Value = "BALANCE c/f"
            dg(3, r).Value = Val(GMod.ds.Tables("bal").Rows(0)("dr").ToString)
            dg(2, r).Value = Val(GMod.ds.Tables("bal").Rows(0)("cr").ToString)
            r = r + 1
            dg.Rows.Add()
            dg(0, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg(1, r).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg(0, r).Style.BackColor = Color.BlueViolet
            dg(1, r).Style.BackColor = Color.BlueViolet
            dg(2, r).Style.BackColor = Color.BlueViolet
            If GMod.ds.Tables("bal").Rows(0)("cr") > 0 Then dg(3, r).Style.BackColor = Color.Pink Else dg(3, r).Style.BackColor = Color.BlueViolet
            dg(4, r).Style.BackColor = Color.BlueViolet
            dg(0, r).Value = dtInc
            dg(1, r).Value = "GRAND TOTAL"
            dg(3, r).Value = Val(dg(3, r - 2).Value) + Val(dg(3, r - 1).Value)
            dg(2, r).Value = Val(dg(2, r - 2).Value) + Val(dg(2, r - 1).Value)
            '------------------------------------------------------------------------------------------------
        Catch Ex As Exception
            If Not Ex.Message.Contains("DBNull") Then
                MsgBox(Ex.Message)
            End If
        End Try
    End Sub

    Private Sub frmCashBook2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dg.Height = Me.Height - 150
        btnshow_Click(sender, e)
        Me.Balance.Visible = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dtfrom.Value = dtfrom.Value.AddDays(1)
        btnshow_Click(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dtfrom.Value = dtfrom.Value.AddDays(-1)
        btnshow_Click(sender, e)
    End Sub

    Private Sub dg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.PageUp Then
            Button2_Click(sender, e)
        ElseIf e.KeyCode = Keys.PageDown Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dg.CurrentCell = dg(0, dg.RowCount - 1)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        dg.CurrentCell = dg(0, 0)
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim cr, i As Integer
        Dim chk As Integer = 0
        If txtfind.Text = "" Then
            MsgBox("Please type related informatin for search", MsgBoxStyle.Critical)
            txtfind.Focus()
            Exit Sub
        End If
        cr = dg.CurrentCell.RowIndex + 1
        If rdchqno.Checked Then
            For i = cr To dg.RowCount - 1
                If InStr(dg(1, i).Value, txtfind.Text) > 0 Then
                    dg.CurrentCell = dg(1, i)
                    chk = 1
                    Exit For
                End If
            Next
        Else
            For i = cr To dg.RowCount - 1
                If dg(2, i).Value = txtfind.Text Then
                    dg.CurrentCell = dg(2, i)
                    chk = 1
                    Exit For
                ElseIf dg(3, i).Value = txtfind.Text Then
                    dg.CurrentCell = dg(3, i)
                    chk = 1
                    Exit For
                End If
            Next
        End If
        If chk = 0 Then
            MsgBox("Not Found", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub dtfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfrom.ValueChanged
        btnshow_Click(sender, e)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Me.Balance.Visible = True
        Else
            Me.Balance.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim dtInc As DateTime
        Dim n, i, j As Integer
        dg.Rows.Clear()
        n = DateDiff(DateInterval.Day, dtfrom.Value, dtto.Value)
        dtInc = dtfrom.Value
        Try
            'dleting old data for that use 
            GMod.SqlExecuteNonQuery("delete  from cash_book where cmpid='" & GMod.Cmpid & "' and Uname='" & GMod.username & "'")
            'Calulating openng and inserint into table 
            Dim sqlopen As String
            Dim opnbal, dr, cr As Double
            Dim sqlcashdel As String

            sqlopen = 0.0
            dr = 0.0
            cr = 0.0
            opnbal = 0.0
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
            Dim bal As Double = 0
            bal = dr - cr
            sqlsave = "insert into cash_book values('" & GMod.Cmpid & "','" & GMod.username & "',0," _
            & "'0','" & dtInc.ToShortDateString & "','CASH BALANCE B/F',''," & Val(dr) & "," & Val(cr) & "," & Val(bal) & ")"
            GMod.SqlExecuteNonQuery(sqlsave)
            '------------------------------------------------------------------------------------------------------

            sqlsave = " select v.Cmp_id,Acc_head_code,Narration+ ' ' + v.Cheque_no as narration,Vou_no,Vou_type,dramt,cramt,v.Cheque_no ,'" & GMod.username & "',vou_date from " & GMod.VENTRY _
            & " v" _
            & " where vou_date = '" & dtInc.ToShortDateString & "' and Acc_head_code='" & GMod.ds.Tables("cashdet").Rows(0)(0) & "' order by vou_type,vou_no"
            GMod.DataSetRet(sqlsave, "det")
            Dim nr(), nr1 As String
            Dim r As Integer = 1
            For j = 0 To ds.Tables("det").Rows.Count - 1
                nr = GMod.ds.Tables("det").Rows(j)("narration").ToString.Split(",")
                If nr.Length = 2 Then nr1 = nr(1) Else nr1 = ""
                bal = bal + Val(GMod.ds.Tables("det").Rows(j)("dramt")) - Val(GMod.ds.Tables("det").Rows(j)("cramt"))
                sqlsave = "insert into cash_book values('" & GMod.Cmpid & "','" & GMod.username & "'," & r & "," _
                & "'" & GMod.ds.Tables("det").Rows(j)("vou_no") & "','" & GMod.ds.Tables("det").Rows(j)("vou_date") & "'," _
                & "'" & nr(0) & "','" & nr1 & "'," & GMod.ds.Tables("det").Rows(j)("dramt") & "," _
                & GMod.ds.Tables("det").Rows(j)("cramt") & "," & bal & ")"
                GMod.SqlExecuteNonQuery(sqlsave)
                r = r + 1
            Next
            Dim rp As New CRCashbook3
            GMod.DataSetRet("select * from cash_book where cmpid='" & GMod.Cmpid & "' and uname='" & GMod.username & "'", "repo")
            rp.SetDataSource(GMod.ds.Tables("repo"))
            rp.SetParameterValue("cname", GMod.Cmpname)
            CrystalReportViewer1.ReportSource = rp
            CrystalReportViewer1.Visible = True
            'CrystalReportViewer1.PrintReport()

                '------------------------------------------------------------------------------------------------
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub
End Class