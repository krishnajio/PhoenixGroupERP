Public Class frmPartyLetter

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim bal As Double
        Dim ty As String
        Dim SqlSelect As String
        Try
            SqlSelect = "select q.account_code,q.acname," _
             & " DrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 then  (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end, " _
             & " CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0 then  abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) else 0 end," _
             & " q.group_name," _
             & " isnull(p.dramt,0) + isnull(q.odr,0) d , isnull(p.cramt,0) + q.ocr c , isnull(q.odr,0) odr , q.ocr " _
             & " from (" _
             & " select isnull(sum(dramt),0) dramt ,isnull(sum(cramt),0) cramt,acc_head_code" _
             & " from " & GMod.VENTRY & " " _
             & " where vou_date<='" & dt1.Value.ToShortDateString & "' and Pay_mode<>'-'" _
             & " group by acc_head_code ) p " _
             & " Right Join " _
             & " ( select account_code,account_head_name acname ,group_name, isnull(opening_dr,0) odr  , " _
             & " isnull(opening_cr,0) ocr from " & GMod.ACC_HEAD & " where group_name='" & cmbPartyGroup.Text & "' ) q " _
             & " on p.acc_head_code=q.account_code  " _
             & " where ((isnull(p.dramt,0) + q.odr) <> (isnull(p.cramt,0) + q.ocr)) and q.account_code='" & cmbPartCode.Text & "' "

            GMod.DataSetRet(SqlSelect, "partyletter")
            If GMod.ds.Tables("partyletter").Rows.Count > 0 Then
                If Val(GMod.ds.Tables("partyletter").Rows(0)("DrAmt")) > 0 Then
                    bal = Val(GMod.ds.Tables("partyletter").Rows(0)("DrAmt"))
                    ty = "DEBIT"
                    ' MessageBox.Show(bal.ToString())
                Else
                    bal = Val(GMod.ds.Tables("partyletter").Rows(0)("CrAmt"))
                    ty = "CREDIT"
                    MessageBox.Show(bal.ToString())
                End If
            Else
                bal = 0
                ty = " "
            End If

        Catch ex As Exception
            bal = 0
        End Try

        Try
            sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and account_code='" & cmbPartCode.Text & "'" 'and left(account_code,2) in ('**','" & cmbAreaCode.Text & "')"
            GMod.DataSetRet(sql, "parletter")

            If GMod.Cmpid = "PHOE" Then
                Dim crparlet As New CrPartyLetter
                crparlet.SetDataSource(GMod.ds.Tables("parletter"))
                crparlet.SetParameterValue("asondate", dt1.Value)
                crparlet.SetParameterValue("balance", bal)
                crparlet.SetParameterValue("ty", ty)
                crparlet.SetParameterValue("cmp", "POULTRY")
                crparlet.SetParameterValue("cmpf", "FOR PHOENIX POULTRY")
                'crparlet.SetParameterValue("uid", GMod.username)
                CrystalReportViewer1.ReportSource = crparlet
                crparlet = Nothing
            ElseIf GMod.Cmpid = "VIBU" Then
                Dim crparlet As New CrPartyLetterVindhya
                crparlet.SetDataSource(GMod.ds.Tables("parletter"))
                crparlet.SetParameterValue("asondate", dt1.Value)
                crparlet.SetParameterValue("balance", bal)
                crparlet.SetParameterValue("ty", ty)
                'crparlet.SetParameterValue("s2", param)
                'crparlet.SetParameterValue("uid", GMod.username)
                CrystalReportViewer1.ReportSource = crparlet
                crparlet = Nothing
            ElseIf GMod.Cmpid = "PHHA" Then
                Dim crparlet As New CrPartyLetter
                crparlet.SetDataSource(GMod.ds.Tables("parletter"))
                crparlet.SetParameterValue("asondate", dt1.Value)
                crparlet.SetParameterValue("balance", bal)
                crparlet.SetParameterValue("ty", ty)
                crparlet.SetParameterValue("cmp", "HATCHRIES")
                crparlet.SetParameterValue("cmpf", "FOR PHOENIX HATCHRIES")
                'crparlet.SetParameterValue("uid", GMod.username)
                CrystalReportViewer1.ReportSource = crparlet
                crparlet = Nothing

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim sql As String
    Private Sub frmTDSReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt1.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dt2.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        dt1.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dt2.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and group_name ='PARTY'"
        'and left(account_code,2) in ('**','" & cmbAreaCode.Text & "')"
        GMod.DataSetRet(sql, "aclist20")
        cmbPartCode.DataSource = GMod.ds.Tables("aclist20")
        cmbPartCode.DisplayMember = "account_code"
        cmbPartyHead.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyHead.DisplayMember = "account_head_name"
        cmbPartyGroup.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyGroup.DisplayMember = "group_name"

        sql = "select * from TdsMater where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(Sql, "tdm")

        cmbtdsType.DataSource = GMod.ds.Tables("tdm")
        cmbtdsType.DisplayMember = "TdsType"

        cmbTdsper.DataSource = GMod.ds.Tables("tdm")
        cmbTdsper.DisplayMember = "Per"
    End Sub

   
End Class