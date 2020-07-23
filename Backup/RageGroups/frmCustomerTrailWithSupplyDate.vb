Public Class frmCustomerTrailWithSupplyDate

    Private Sub frmCustomerTrailWithSupplyDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    [" & GMod.Cmpname & "]"
        CrViewerGenralLedger.Height = Me.Height - 195
        fillArea()
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
    End Sub
    Public Sub GrpWiseALL()
        'Customer Trial with last supply date
        Dim sql As String
        Dim i As Integer
        If chkArea.Checked = True Then
            If rdwithopening.Checked Then
                sql = " insert into tmpCustTrialLastSuppDate(account_code, account_head_name, dr, cr, Uname,grpname) select *,'" & GMod.username & "','CUSTOMER' from ( select q.account_code,q.account_head_name,isnull(p.dr,0) + isnull(q.opening_dr,0) dr ,isnull(p.cr,0) + isnull(q.opening_cr,0) cr ,'" & GMod.username & "' from " _
                              & " ( select isnull(sum(dramt),0) dr ,isnull(sum(cramt),0) cr ,Acc_head_code,Acc_head from " _
                              & GMod.VENTRY & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and " _
                              & " vou_type<>'BANKREC' and Group_name='CUSTOMER' and Pay_mode<>'-'" _
                              & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' " _
                              & " group by Acc_head_code,Acc_head ) p  Right Join " _
                              & " ( select isnull(account_code,'') account_code,isnull(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0) opening_cr ,sub_group_name " _
                              & " from " & GMod.ACC_HEAD & " where Group_name='CUSTOMER'  ) q on p.Acc_head_code = q.account_code ) z where z.dr<>z.cr"
                GMod.SqlExecuteNonQuery(sql)
            Else
                sql = "insert into tmpCustTrialLastSuppDate(account_code, account_head_name, dr, cr, Uname,grpname) select p.Acc_head_code account_code ,p.Acc_head account_head_name ,p.dr  dr ,p.cr  cr ,'" & GMod.username & "','CUSTOMER'  from " _
                             & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                             & GMod.VENTRY & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and " _
                             & " and vou_type<>'BANKREC' and Group_name='CUSTOMER' and Pay_mode<>'-'" _
                             & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "'" _
                             & " group by Acc_head_code,Acc_head ) p  where p.dr<>p.cr "
                GMod.SqlExecuteNonQuery(sql)
            End If
        Else
            'trial with out area
            If rdwithopening.Checked Then
                sql = " insert into tmpCustTrialLastSuppDate(account_code, account_head_name, dr, cr, Uname,grpname) select  *,'" & GMod.username & "','CUSTOMER' from ( select q.account_code,q.account_head_name,isnull(p.dr,0) + isnull(q.opening_dr,0) dr ,isnull(p.cr,0) + isnull(q.opening_cr,0) cr  from " _
                              & " ( select isnull(sum(dramt),0) dr ,isnull(sum(cramt),0) cr ,Acc_head_code,Acc_head from " _
                              & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                              & "vou_type<>'BANKREC' and Group_name='CUSTOMER' and Pay_mode<>'-'" _
                              & " group by Acc_head_code,Acc_head ) p  Right Join " _
                              & " ( select isnull(account_code,'') account_code,isnull(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0) opening_cr ,sub_group_name " _
                              & " from " & GMod.ACC_HEAD & " where Group_name='CUSTOMER' ) q on p.Acc_head_code = q.account_code ) z where z.dr<>z.cr"
                GMod.SqlExecuteNonQuery(sql)
            Else
                sql = " insert into tmpCustTrialLastSuppDate(account_code, account_head_name, dr, cr, Uname,grpname) select p.Acc_head_code account_code ,p.Acc_head account_head_name ,p.dr  dr ,p.cr  cr ,'" & GMod.username & "','CUSTOMER'  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "'" _
                          & " and vou_type<>'BANKREC' and Group_name='CUSTOMER' and Pay_mode<>'-'" _
                          & " group by Acc_head_code,Acc_head ) p  where p.dr<>p.cr "
                GMod.SqlExecuteNonQuery(sql)
            End If
        End If
        'GMod.DataSetRet(sql, "trial")
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        GMod.SqlExecuteNonQuery("delete from tmpCustTrialLastSuppDate where Uname='" & GMod.username & "'")
        GrpWiseALL()
        Dim sql, sqlup, sqlget, pname As String
        Dim i, j As Integer
        If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "PHOE" Then
            sql = "select account_code from tmpCustTrialLastSuppDate where Uname='" & GMod.username & "' order by id"
            GMod.DataSetRet(sql, "XX")
            For i = 0 To GMod.ds.Tables("XX").Rows.Count - 1
                sqlget = "select HatchDate,ProductName from PrintData where AccCode='" & GMod.ds.Tables("XX").Rows(i)(0) & "'" _
                           & " and hatchDate = (select max(HatchDate) from PrintData  where AccCode='" & GMod.ds.Tables("XX").Rows(i)(0) & "')"
                GMod.DataSetRet(sqlget, "HatchDate")
                If GMod.ds.Tables("HatchDate").Rows.Count > 0 Then
                    pname = ""
                    For j = 0 To GMod.ds.Tables("HatchDate").Rows.Count - 1
                        pname = pname & "," & GMod.ds.Tables("HatchDate").Rows(j)(1)
                    Next

                    sqlup = "update tmpCustTrialLastSuppDate set SuppDate = '" & GMod.ds.Tables("HatchDate").Rows(0)(0) & "',ProductName='" & pname & "' where account_code='" & GMod.ds.Tables("XX").Rows(i)(0) & " '"
                    GMod.SqlExecuteNonQuery(sqlup)
                End If
            Next
        ElseIf GMod.Cmpid = "PHFE" Then
            'For Feed
            sql = "select account_code from tmpCustTrialLastSuppDate where Uname='" & GMod.username & "' order by id"
            GMod.DataSetRet(sql, "XX")
            For i = 0 To GMod.ds.Tables("XX").Rows.Count - 1
                sqlget = "select vou_date,ItemName from " & GMod.INVENTORY & " where Acc_head_code='" & GMod.ds.Tables("XX").Rows(i)(0) & "'" _
                           & " and vou_type='SALE' and vou_date = (select max(vou_date) from " & GMod.INVENTORY & "  where Acc_head_code='" & GMod.ds.Tables("XX").Rows(i)(0) & "')"
                GMod.DataSetRet(sqlget, "HatchDate")
                If GMod.ds.Tables("HatchDate").Rows.Count > 0 Then
                    pname = ""
                    For j = 0 To GMod.ds.Tables("HatchDate").Rows.Count - 1
                        pname = pname & "," & GMod.ds.Tables("HatchDate").Rows(j)(1)
                    Next

                    sqlup = "update tmpCustTrialLastSuppDate set SuppDate = '" & GMod.ds.Tables("HatchDate").Rows(0)(0) & "',ProductName='" & pname & "' where account_code='" & GMod.ds.Tables("XX").Rows(i)(0) & " '"
                    GMod.SqlExecuteNonQuery(sqlup)
                End If
            Next
        End If
        Dim sqlseelct As String
        If Dr.Checked = True Then
            If rdCode.Checked = True Then
                sqlseelct = "select account_code, account_head_name, dr, cr,SuppDate,ProductName from tmpCustTrialLastSuppDate where Uname='" & GMod.username & "' and dr-cr > 0 order by id"
            End If
            If rdName.Checked = True Then
                sqlseelct = "select account_code, account_head_name, dr, cr,SuppDate,ProductName from tmpCustTrialLastSuppDate where Uname='" & GMod.username & "' and dr-cr > 0 order by grpname,account_head_name,id"
            End If
        ElseIf Cr.Checked = True Then
            If rdCode.Checked = True Then
                sqlseelct = "select account_code, account_head_name, dr, cr,SuppDate,ProductName from tmpCustTrialLastSuppDate where Uname='" & GMod.username & "' and cr-dr>0 order by id"
            End If
            If rdName.Checked = True Then
                sqlseelct = "select account_code, account_head_name, dr, cr,SuppDate,ProductName from tmpCustTrialLastSuppDate where Uname='" & GMod.username & "' and cr-dr>0 order by grpname,account_head_name,id"
            End If
        Else
            If rdCode.Checked = True Then
                sqlseelct = "select account_code, account_head_name, dr, cr,SuppDate,ProductName from tmpCustTrialLastSuppDate where Uname='" & GMod.username & "' order by id"
            End If
            If rdName.Checked = True Then
                sqlseelct = "select account_code, account_head_name, dr, cr,SuppDate,ProductName from tmpCustTrialLastSuppDate where Uname='" & GMod.username & "' order by grpname,account_head_name,id"
            End If
        End If
        GMod.DataSetRet(sqlseelct, "custtrial")

        Dim r As New CrCustomerTrilaWithLastSupplyDate ' Cryatal Report Object
        GMod.DataSetRet(sqlseelct, "custtrial") 'Passing dataset
        r.SetDataSource(GMod.ds.Tables("custtrial")) 'Passing Parameter
        r.SetParameterValue("cmpname", GMod.Cmpname) 'Passing Parameter
        r.SetParameterValue("subhead", "Customer Trial as on " & dtfrom.Text) 'Passing Parameter
        CrViewerGenralLedger.ReportSource = r 'Crystal Report Viewer 
    End Sub
End Class