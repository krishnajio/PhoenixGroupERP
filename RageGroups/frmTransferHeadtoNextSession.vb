Public Class frmTransferHeadtoNextSession
    Dim sql As String
    Private Sub frmTransferHeadtoNextSession_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillSession()
        
    End Sub
    Public Sub FillSession()
        Dim i As Integer
        Dim start As Integer = 8
        DateTimePicker1.Value = "4/1/08"
        For i = 0 To 50
            DateTimePicker1.Value = DateTimePicker1.Value.AddYears(i)
            cmbSession.Items.Add(GMod.Getsession(DateTimePicker1.Value))
            cmbSessionTo.Items.Add(GMod.Getsession(DateTimePicker1.Value))
        Next
    End Sub
    Dim cfrom, headfrom As String
    Dim cto, headto As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(cmbSession.Text) <> "" Then
            Dim sql As String, i As Integer
            cfrom = "VENTRY_" & GMod.Cmpid & "_" & cmbSession.Text
            cto = "VENTRY_" & GMod.Cmpid & "_" & cmbSessionTo.Text
            headfrom = "ACC_HEAD_" & GMod.Cmpid & "_" & cmbSession.Text
            headto = "ACC_HEAD_" & GMod.Cmpid & "_" & cmbSessionTo.Text
            sql = "select q.account_code,q.account_head_name," _
            & " ClosingDr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0) ) > 0 then  (isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0)) else 0 end, " _
            & " ClosingCr= case  when ( isnull(q.od,0) + isnull(p.dr,0) )-(isnull(q.oc,0) + isnull(p.cr,0)) < 0 then  abs((isnull(q.od,0) + isnull(p.dr,0))-(isnull(q.oc,0) + isnull(p.cr,0))) else 0 end " _
            & "from" _
            & "(select  isnull(Acc_head_code,'') Acc_head_code , isnull(Acc_head,'') Acc_head , isnull(sum(dramt),0)  dr , isnull(sum(cramt),0)  cr " _
            & " from  " & cfrom _
            & " where group_name='" & cmbGroups.Text & "'  group by Acc_head_code,Acc_head  ) p " _
            & " Right Join " _
            & " ( select isnull(account_code,'') account_code ,account_head_name,isnull(opening_dr,0) od,isnull(opening_cr,0)  oc from " & headfrom _
            & "  where group_name='" & cmbGroups.Text & "') q on q.account_code=p.Acc_head_code order by left(q.account_code,2) ,q.account_head_name  "

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
    End Sub
    Dim count As Integer
    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked = True Then
            For count = 0 To dgCurrentSession.Rows.Count - 1
                dgCurrentSession(0, count).Value = True
            Next
        Else
            For count = 0 To dgCurrentSession.Rows.Count - 1
                dgCurrentSession(0, count).Value = False
            Next
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Trim(cmbSessionTo.Text) <> "" Then
                Dim headfrom, headto As String
                headfrom = "ACC_HEAD_" & GMod.Cmpid & "_" & cmbSession.Text
                headto = "ACC_HEAD_" & GMod.Cmpid & "_" & cmbSessionTo.Text
                Dim i As Integer
                Dim SqlQuery As String
                If chkSelectAll.Checked = True Then
                    If chkwithzero.Checked = False Then
                        For i = 0 To dgCurrentSession.Rows.Count - 2
                            SqlQuery = "insert into " & headto & " select Cmp_id, account_code, account_head_name, group_name, sub_group_name, credit_days, credit_limit," & dgCurrentSession(3, i).Value & ", " & dgCurrentSession(4, i).Value & ", account_type, address, city, state, phone, pan_no, rate_of_interest, interest_rule_id, Area_code, remark1, remark2, remark3 from " & headfrom & " where account_code='" & dgCurrentSession(1, i).Value.ToString & "'"
                            GMod.SqlExecuteNonQuery(SqlQuery)
                        Next
                    Else
                        'If dgCurrentSession(1, i).Value.ToString = 1 Then
                        For i = 0 To dgCurrentSession.Rows.Count - 2
                            SqlQuery = "insert into " & headto & " select Cmp_id, account_code, account_head_name, group_name, sub_group_name, credit_days, credit_limit,0,0,account_type, address, city, state, phone, pan_no, rate_of_interest, interest_rule_id, Area_code, remark1, remark2, remark3 from " & headfrom & " where account_code='" & dgCurrentSession(1, i).Value.ToString & "'"
                            GMod.SqlExecuteNonQuery(SqlQuery)
                        Next
                        'End If
                    End If
                Else

                    If chkwithzero.Checked = False Then

                        For i = 0 To dgCurrentSession.Rows.Count - 2
                            If dgCurrentSession(0, i).Value = 1 Then
                                SqlQuery = "insert into " & headto & " select Cmp_id, account_code, account_head_name, group_name, sub_group_name, credit_days, credit_limit," & dgCurrentSession(3, i).Value & ", " & dgCurrentSession(4, i).Value & ", account_type, address, city, state, phone, pan_no, rate_of_interest, interest_rule_id, Area_code, remark1, remark2, remark3 from " & headfrom & " where account_code='" & dgCurrentSession(1, i).Value.ToString & "'"
                                GMod.SqlExecuteNonQuery(SqlQuery)
                            End If
                        Next
                    Else

                        For i = 0 To dgCurrentSession.Rows.Count - 2
                            If dgCurrentSession(0, i).Value = 1 Then
                                SqlQuery = "insert into " & headto & " select Cmp_id, account_code, account_head_name, group_name, sub_group_name, credit_days, credit_limit,0,0,account_type, address, city, state, phone, pan_no, rate_of_interest, interest_rule_id, Area_code, remark1, remark2, remark3 from " & headfrom & " where account_code='" & dgCurrentSession(1, i).Value.ToString & "'"
                                GMod.SqlExecuteNonQuery(SqlQuery)
                            End If
                        Next
                End If
                    End If
                MsgBox("Transfered...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "Select * from Groups where cmp_id ='" & GMod.Cmpid & "' and session ='" & cmbSession.Text & "'"
        GMod.DataSetRet(sql, "XX")
        cmbGroups.DataSource = GMod.ds.Tables("XX")
        cmbGroups.DisplayMember = "group_name"


        ComboBox1.DataSource = GMod.ds.Tables("XX")
        ComboBox1.DisplayMember = "BS_PL"
    End Sub
End Class