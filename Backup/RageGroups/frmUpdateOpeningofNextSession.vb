Public Class frmUpdateOpeningofNextSession

    Private Sub frmUpdateOpeningofNextSession_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillSession()
        Dim sql As String
        sql = "Select * from Groups where cmp_id ='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "XX")
        cmbGroups.DataSource = GMod.ds.Tables("XX")
        cmbGroups.DisplayMember = "group_name"


    End Sub
    Public Sub FillSession()
        Dim i As Integer
        Dim start As Integer = 8
        dtfrom.Value = "4/1/08"
        For i = 0 To 50
            dtfrom.Value = dtfrom.Value.AddYears(i)
            cmbSession.Items.Add(GMod.Getsession(dtfrom.Value))
            cmbSessionTo.Items.Add(GMod.Getsession(dtfrom.Value))
        Next
    End Sub
    Dim cfrom, headfrom As String
    Dim cto, headto As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            dtfrom.Value = "3/31/" & cmbSession.Text.Substring(2, 2)
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try

        Dim sql As String, i As Integer
        If Trim(cmbSession.Text) <> "" Then

            cfrom = "VENTRY_" & GMod.Cmpid & "_" & cmbSession.Text
            cto = "VENTRY_" & GMod.Cmpid & "_" & cmbSessionTo.Text
            headfrom = "ACC_HEAD_" & GMod.Cmpid & "_" & cmbSession.Text
            headto = "ACC_HEAD_" & GMod.Cmpid & "_" & cmbSessionTo.Text

            sql = "select q.account_code,q.account_head_name," _
            & " ClosingDr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0 then  (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) else 0 end, " _
            & " ClosingCr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then  abs((isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0))) else 0 end " _
            & "from" _
            & "(select  isnull(Acc_head_code,'') Acc_head_code , isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr " _
            & " from  " & cfrom _
            & " where group_name='" & cmbGroups.Text & "' and Pay_mode<>'-' group by Acc_head_code  ) p " _
            & " Right Join " _
            & " ( select isnull(account_code,'') account_code ,account_head_name,isnull(opening_dr,0) od,isnull(opening_cr,0)  oc from " & headfrom _
            & "  where group_name='" & cmbGroups.Text & "') q on q.account_code=p.Acc_head_code order by q.account_code"



            sql = "select q.account_code,q.acname," _
       & " DrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 then  (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) else 0 end, " _
       & " CrAmt = case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  < 0 then  abs((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr)) else 0 end," _
       & " q.group_name," _
       & " isnull(p.dramt,0) + isnull(q.odr,0) d , isnull(p.cramt,0) + q.ocr c , isnull(q.odr,0) odr , q.ocr " _
       & " from (" _
       & " select isnull(sum(dramt),0) dramt ,isnull(sum(cramt),0) cramt,acc_head_code" _
       & " from " & cfrom & " " _
       & " where vou_date<='" & dtfrom.Value.ToShortDateString & "' and Pay_mode<>'-' " _
       & " group by acc_head_code ) p " _
       & " Right Join " _
       & " ( select account_code,account_head_name acname ,group_name, isnull(opening_dr,0) odr  , " _
       & " isnull(opening_cr,0) ocr from " & headfrom & " where group_name='" & cmbGroups.Text & "' ) q " _
       & " on p.acc_head_code=q.account_code  " _
      ' & " where ((isnull(p.dramt,0) + q.odr) <> (isnull(p.cramt,0) + q.ocr))  "

            GMod.DataSetRet(sql, "DT1")
            dgCurrentSession.Rows.Clear()
            For i = 0 To GMod.ds.Tables("DT1").Rows.Count - 1
                dgCurrentSession.Rows.Add()
                dgCurrentSession(1, i).Value = GMod.ds.Tables("DT1").Rows(i)(0).ToString
                dgCurrentSession(2, i).Value = GMod.ds.Tables("DT1").Rows(i)(1).ToString
                dgCurrentSession(3, i).Value = GMod.ds.Tables("DT1").Rows(i)(2).ToString
                dgCurrentSession(4, i).Value = GMod.ds.Tables("DT1").Rows(i)(3).ToString
                'dgCurrentSession(5, i).Value = GMod.ds.Tables("DT1").Rows(i)(4).ToString
            Next
            'dgCurrentSession.Rows.RemoveAt(i)
            GMod.ds.Tables("DT1").Clear()
        End If

        If Trim(cmbSessionTo.Text) <> "" Then
            sql = "select isnull(account_code,'') account_code ,account_head_name,isnull(opening_dr,0) od,isnull(opening_cr,0)  oc from " & headto _
                    & "  where group_name='" & cmbGroups.Text & "'"
            GMod.DataSetRet(sql, "DT2")
            dgnew.Rows.Clear()
            For i = 0 To GMod.ds.Tables("DT2").Rows.Count - 1
                dgnew.Rows.Add()
                dgnew(1, i).Value = GMod.ds.Tables("DT2").Rows(i)(0).ToString
                dgnew(2, i).Value = GMod.ds.Tables("DT2").Rows(i)(1).ToString
                dgnew(3, i).Value = GMod.ds.Tables("DT2").Rows(i)(2).ToString
                dgnew(4, i).Value = GMod.ds.Tables("DT2").Rows(i)(3).ToString
                'dgCurrentSession(5, i).Value = GMod.ds.Tables("DT1").Rows(i)(4).ToString
            Next
            'dgCurrentSession.Rows.RemoveAt(i)
            GMod.ds.Tables("DT2").Clear()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer, j As Integer
        'For i = 0 To dgCurrentSession.RowCount - 1
        '    For j = 0 To dgnew.RowCount - 1
        '        If j <= i Then
        '            If dgnew(1, j).Value.ToString.Trim = dgCurrentSession(1, i).Value.ToString.Trim Then
        '                'MsgBox(dgnew(1, j).Value & " " & dgCurrentSession(1, i).Value.ToString.Trim)
        '                dgnew(1, j).Style.BackColor = Color.Blue
        '            Else
        '                'dgnew(1, j).Style.BackColor = Color.Red
        '            End If
        '        End If
        '    Next j
        'Next i
        If chkwithzero.Checked = False Then
            Dim updatesql As String
            For i = 0 To dgCurrentSession.RowCount - 1
                updatesql = "update " & headto & " set opening_dr='" & dgCurrentSession(3, i).Value & "', opening_cr='" & dgCurrentSession(4, i).Value & "' where account_code='" & dgCurrentSession(1, i).Value & "'"
                GMod.SqlExecuteNonQuery(updatesql)
            Next
            MsgBox("Updated")
        Else
            Dim updatesql As String
            For i = 0 To dgCurrentSession.RowCount - 1
                updatesql = "update " & headto & " set opening_dr=0.00, opening_cr=0.00 where account_code='" & dgCurrentSession(1, i).Value & "'"
                GMod.SqlExecuteNonQuery(updatesql)
            Next
            MsgBox("Updated")
        End If
    End Sub
End Class