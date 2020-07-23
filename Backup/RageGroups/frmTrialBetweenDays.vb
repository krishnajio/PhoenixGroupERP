Imports System.IO
Public Class frmTrialbetweendays

    Private Sub frmTrial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtTo.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtTo.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString


        dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtfrom.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        Dim j As Integer
        Me.Text = Me.Text & "    [" & GMod.Cmpname & "]"
        fillArea()
        GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "' and group_name<>'PARTY' order by group_name", "grp")
        cmbgrpname.DataSource = GMod.ds.Tables("grp")
        cmbgrpname.DisplayMember = "group_name"

        CrViewerGenralLedger.Height = Me.Height - 195
        dgtrial.Location = CrViewerGenralLedger.Location

        dgtrial.Height = CrViewerGenralLedger.Height
        dgtrial.Width = CrViewerGenralLedger.Width

        If cmbsubgrpname.Text = "" Then
            cmbsubgrpname.Text = "-"
        End If
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
    Private Sub rdPary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPary.CheckedChanged
        cmbgrpname.Text = "PARTY"
        cmbgrpname.Enabled = False
        GMod.DataSetRet("select * from sub_group where group_name='PARTY' and  cmp_id='" & GMod.Cmpid & "'", "sgrp")
        cmbsubgrpname.DataSource = GMod.ds.Tables("sgrp")
        cmbsubgrpname.DisplayMember = "sub_group_name"
        'cmbsubgrpname_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub rdcustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdcustomer.CheckedChanged
        cmbgrpname.Text = "CUSTOMER"
        cmbgrpname.Enabled = False
        GMod.DataSetRet("select * from sub_group where group_name='CUSTOMER' and  cmp_id='" & GMod.Cmpid & "'", "sgrp")
        cmbsubgrpname.DataSource = GMod.ds.Tables("sgrp")
        cmbsubgrpname.DisplayMember = "sub_group_name"
        'cmbsubgrpname_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbgrpname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgrpname.Leave
        Button1.Enabled = False
    End Sub

    Private Sub cmbgrpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrpname.SelectedIndexChanged
        GMod.DataSetRet("select * from sub_group where group_name='" & cmbgrpname.Text & "' and  cmp_id='" & GMod.Cmpid & "'", "sgrp")
        cmbsubgrpname.DataSource = GMod.ds.Tables("sgrp")
        cmbsubgrpname.DisplayMember = "sub_group_name"
        ' cmbsubgrpname_SelectedIndexChanged(sender, e)
        If cmbsubgrpname.Text = "" Then
            cmbsubgrpname.Text = "-"
        End If
        Button1.Enabled = False
    End Sub

    Private Sub rdgeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgeneral.CheckedChanged
        cmbgrpname.Enabled = True
        GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "' and group_name<>'PARTY'", "grp")
        cmbgrpname.DataSource = GMod.ds.Tables("grp")
        cmbgrpname.DisplayMember = "group_name"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Sub grpwisetrial()
        Dim sql As String
        If chkArea.Checked = True Then
            If rdwithopening.Checked Then
                If cmbsubgrpname.Text = "-" Or cmbsubgrpname.Text = "" Then
                    sql = " select p.Acc_head_code,p.Acc_head,p.dr + q.opening_dr dr ,p.cr + q.opening_cr cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & "Group_name='" & cmbgrpname.Text & "'" _
                          & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' and vou_type<>'BANKREC'" _
                          & " group by Acc_head_code,Acc_head ) p  Left Join " _
                          & " ( select account_code,account_head_name,opening_dr,opening_cr,sub_group_name " _
                          & " from " & GMod.ACC_HEAD & " ) q on p.Acc_head_code = q.account_code "

                Else
                    sql = " select p.Acc_head_code,p.Acc_head,p.dr + q.opening_dr dr ,p.cr + q.opening_cr cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & "Group_name='" & cmbgrpname.Text & "' and  Sub_group_name='" & cmbsubgrpname.Text & "'" _
                          & "and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' and vou_type<>'BANKREC' " _
                          & " group by Acc_head_code,Acc_head ) p  Left Join " _
                          & " ( select account_code,account_head_name,opening_dr,opening_cr,sub_group_name " _
                          & " from " & GMod.ACC_HEAD & " ) q on p.Acc_head_code = q.account_code "
                End If
            Else
                If cmbsubgrpname.Text = "-" Or cmbsubgrpname.Text = "" Then
                    sql = " select p.Acc_head_code,p.Acc_head,p.dr  dr ,p.cr  cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & " Group_name='" & cmbgrpname.Text & "'" _
                          & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' and vou_type<>'BANKREC' " _
                          & " group by Acc_head_code,Acc_head ) p "
                Else
                    sql = " select p.Acc_head_code,p.Acc_head,p.dr  dr ,p.cr  cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & "Group_name='" & cmbgrpname.Text & "' and  Sub_group_name='" & cmbsubgrpname.Text & "'" _
                          & "and left(Acc_head_code,2)='" & cmbAreaCode.Text & "'  and vou_type<>'BANKREC'" _
                          & " group by Acc_head_code,Acc_head ) p "
                End If
            End If
        Else
            'trial with out area
            If rdwithopening.Checked Then
                If cmbsubgrpname.Text = "-" Or cmbsubgrpname.Text = "" Then
                    sql = " select p.Acc_head_code,p.Acc_head,p.dr + q.opening_dr dr ,p.cr + q.opening_cr cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & "Group_name='" & cmbgrpname.Text & "' and vou_type<>'BANKREC'" _
                          & " group by Acc_head_code,Acc_head ) p  Left Join " _
                          & " ( select account_code,account_head_name,opening_dr,opening_cr,sub_group_name " _
                          & " from " & GMod.ACC_HEAD & " ) q on p.Acc_head_code = q.account_code "

                Else
                    sql = " select p.Acc_head_code,p.Acc_head,p.dr + q.opening_dr dr ,p.cr + q.opening_cr cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & "Group_name='" & cmbgrpname.Text & "' and  Sub_group_name='" & cmbsubgrpname.Text & "' and vou_type<>'BANKREC'" _
                          & " group by Acc_head_code,Acc_head ) p  Left Join " _
                          & " ( select account_code,account_head_name,opening_dr,opening_cr,sub_group_name " _
                          & " from " & GMod.ACC_HEAD & " ) q on p.Acc_head_code = q.account_code "
                End If
            Else
                If cmbsubgrpname.Text = "-" Or cmbsubgrpname.Text = "" Then
                    sql = " select p.Acc_head_code,p.Acc_head,p.dr  dr ,p.cr  cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & " Group_name='" & cmbgrpname.Text & "' and vou_type<>'BANKREC'" _
                          & " group by Acc_head_code,Acc_head ) p "
                Else
                    sql = " select p.Acc_head_code,p.Acc_head,p.dr  dr ,p.cr  cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & "Group_name='" & cmbgrpname.Text & "' and  Sub_group_name='" & cmbsubgrpname.Text & "' and vou_type<>'BANKREC'" _
                          & " group by Acc_head_code,Acc_head ) p "
                End If
            End If
        End If
        GMod.DataSetRet(sql, "trial")
    End Sub
    Public Sub GrpWise()
        Dim sqladd As String

        Dim sql As String
        If chkArea.Checked = True Then
            If rdwithopening.Checked Then 'Witth area , rdwithopening 
                If Dr.Checked = True Then
                    sqladd = " and (z.dr-z.cr)  > 0 "
                ElseIf Cr.Checked = True Then
                    sqladd = " and (z.cr-z.dr) > 0 "
                Else
                    sqladd = ""
                End If
                sql = "select * from ( select q.account_code,q.account_head_name,isnull(p.dr,0) + isnull(q.opening_dr,0) dr ,isnull(p.cr,0) + isnull(q.opening_cr,0) cr  from " _
                          & " ( select isnull(sum(dramt),0) dr ,isnull(sum(cramt),0) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and " _
                          & " vou_type<>'BANKREC' and Group_name='" & cmbgrpname.Text & "' and sub_group_name='" & cmbsubgrpname.Text & "'" _
                          & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' " _
                          & " group by Acc_head_code,Acc_head ) p  Right Join " _
                          & " ( select isnull(account_code,'') account_code,isnull(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0) opening_cr ,sub_group_name " _
                          & " from " & GMod.ACC_HEAD & " where Group_name='" & cmbgrpname.Text & "' and sub_group_name='" & cmbsubgrpname.Text & "' and left(account_code,2)='" & cmbAreaCode.Text & "' ) q on p.Acc_head_code = q.account_code ) z where z.dr<>z.cr "
                If rdCode.Checked = True Then
                    sql = sql & sqladd & " order by z.account_code,z.account_head_name"
                End If
                If rdName.Checked = True Then
                    sql = sql & sqladd & " order by z.account_head_name"
                End If
            Else
                If Dr.Checked = True Then
                    sqladd = " and (p.dr-p.cr)  > 0 "
                ElseIf Cr.Checked = True Then
                    sqladd = " and (p.cr-p.dr) > 0 "
                Else
                    sqladd = ""
                End If
                sql = " select p.Acc_head_code account_code ,p.Acc_head account_head_name ,p.dr  dr ,p.cr  cr  from " _
                         & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                         & "" & GMod.VENTRY & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and " _
                         & " and vou_type<>'BANKREC' and Group_name='" & cmbgrpname.Text & "' and sub_group_name='" & cmbsubgrpname.Text & "'" _
                         & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "'" _
                         & " group by Acc_head_code,Acc_head ) p  where p.dr<>p.cr "
                If rdCode.Checked = True Then
                    sql = sql & sqladd & " order by p.Acc_head_code ,p.Acc_head"
                End If
                If rdName.Checked = True Then
                    sql = sql & sqladd & " order by p.Acc_head"
                End If
            End If
        Else ' Else of AREA
            'trial with out area and with opening 
            If rdwithopening.Checked Then
                If Dr.Checked = True Then
                    sqladd = " and (z.dr-z.cr)  > 0 "
                ElseIf Cr.Checked = True Then
                    sqladd = " and (z.cr-z.dr) > 0 "
                Else
                    sqladd = ""
                End If
                sql = "select * from ( select q.account_code,q.account_head_name,isnull(p.dr,0) + isnull(q.opening_dr,0) dr ,isnull(p.cr,0) + isnull(q.opening_cr,0) cr  from " _
                          & " ( select isnull(sum(dramt),0) dr ,isnull(sum(cramt),0) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and " _
                          & "vou_type<>'BANKREC' and Group_name='" & cmbgrpname.Text & "' and sub_group_name='" & cmbsubgrpname.Text & "'" _
                          & " group by Acc_head_code,Acc_head ) p  Right Join " _
                          & " ( select isnull(account_code,'') account_code,isnull(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0) opening_cr ,sub_group_name " _
                         & " from " & GMod.ACC_HEAD & " where Group_name='" & cmbgrpname.Text & "'  and sub_group_name='" & cmbsubgrpname.Text & "') q on p.Acc_head_code = q.account_code ) z where z.dr<>z.cr  "
                If rdCode.Checked = True Then
                    sql = sql & sqladd & " order by z.account_code,z.account_head_name"
                End If
                If rdName.Checked = True Then
                    sql = sql & sqladd & " order by z.account_head_name"
                End If
            Else  'trial with out area and with out opening 
                If Dr.Checked = True Then
                    sqladd = " and (p.dr-p.cr)  > 0 "
                ElseIf Cr.Checked = True Then
                    sqladd = " and (p.cr-p.dr) > 0 "
                Else
                    sqladd = ""
                End If
                sql = " select p.Acc_head_code account_code ,p.Acc_head account_head_name ,p.dr  dr ,p.cr  cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
                          & " and vou_type<>'BANKREC' and Group_name='" & cmbgrpname.Text & "' and sub_group_name='" & cmbsubgrpname.Text & "'" _
                          & " group by Acc_head_code,Acc_head ) p  where p.dr<>p.cr  "
                If rdCode.Checked = True Then
                    sql = sql & sqladd & " order by p.Acc_head_code ,p.Acc_head"
                End If
                If rdName.Checked = True Then
                    sql = sql & sqladd & " order by p.Acc_head"
                End If
            End If
        End If
        GMod.DataSetRet(sql, "trial")
    End Sub
    Public Sub GrpWiseALL()
        Dim sql As String
        Dim i As Integer
        If chkArea.Checked = True Then
            If rdwithopening.Checked Then
                For i = 0 To cmbgrpname.Items.Count - 1
                    cmbgrpname.SelectedIndex = i
                    sql = " insert into tmpTrial(account_code, account_head_name, dr, cr, Uname,grpname) select *,'" & GMod.username & "','" & cmbgrpname.Text & "' from ( select q.account_code,q.account_head_name,isnull(p.dr,0) + isnull(q.opening_dr,0) dr ,isnull(p.cr,0) + isnull(q.opening_cr,0) cr ,'" & GMod.username & "' from " _
                              & " ( select isnull(sum(dramt),0) dr ,isnull(sum(cramt),0) cr ,Acc_head_code,Acc_head from " _
                              & GMod.VENTRY & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and " _
                              & " vou_type<>'BANKREC' and Group_name='" & cmbgrpname.Text & "' and sub_group_name='" & cmbsubgrpname.Text & "'" _
                              & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' " _
                              & " group by Acc_head_code,Acc_head ) p  Right Join " _
                              & " ( select isnull(account_code,'') account_code,isnull(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0) opening_cr ,sub_group_name " _
                              & " from " & GMod.ACC_HEAD & " where Group_name='" & cmbgrpname.Text & "'  and sub_group_name='" & cmbsubgrpname.Text & "') q on p.Acc_head_code = q.account_code ) z where z.dr<>z.cr"
                    GMod.SqlExecuteNonQuery(sql)
                Next
            Else
                For i = 0 To cmbgrpname.Items.Count - 1
                    cmbgrpname.SelectedIndex = i
                    sql = "insert into tmpTrial(account_code, account_head_name, dr, cr, Uname,grpname) select p.Acc_head_code account_code ,p.Acc_head account_head_name ,p.dr  dr ,p.cr  cr ,'" & GMod.username & "','" & cmbgrpname.Text & "'  from " _
                             & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                             & GMod.VENTRY & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and " _
                             & " and vou_type<>'BANKREC' and Group_name='" & cmbgrpname.Text & "' and sub_group_name='" & cmbsubgrpname.Text & "'" _
                             & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "'" _
                             & " group by Acc_head_code,Acc_head ) p  where p.dr<>p.cr "
                    GMod.SqlExecuteNonQuery(sql)
                Next
            End If
        Else
            'trial with out area
            If rdwithopening.Checked Then
                For i = 0 To cmbgrpname.Items.Count - 1
                    cmbgrpname.SelectedIndex = i
                    sql = " insert into tmpTrial(account_code, account_head_name, dr, cr, Uname,grpname) select  *,'" & GMod.username & "','" & cmbgrpname.Text & "' from ( select q.account_code,q.account_head_name,isnull(p.dr,0) + isnull(q.opening_dr,0) dr ,isnull(p.cr,0) + isnull(q.opening_cr,0) cr  from " _
                              & " ( select isnull(sum(dramt),0) dr ,isnull(sum(cramt),0) cr ,Acc_head_code,Acc_head from " _
                              & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                              & "vou_type<>'BANKREC' and Group_name='" & cmbgrpname.Text & "'" _
                              & " group by Acc_head_code,Acc_head ) p  Right Join " _
                              & " ( select isnull(account_code,'') account_code,isnull(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0) opening_cr ,sub_group_name " _
                              & " from " & GMod.ACC_HEAD & " where Group_name='" & cmbgrpname.Text & "' and sub_group_name='" & cmbsubgrpname.Text & "') q on p.Acc_head_code = q.account_code ) z where z.dr<>z.cr"
                    GMod.SqlExecuteNonQuery(sql)
                Next
            Else
                For i = 0 To cmbgrpname.Items.Count - 1
                    cmbgrpname.SelectedIndex = i
                    sql = " insert into tmpTrial(account_code, account_head_name, dr, cr, Uname,grpname) select p.Acc_head_code account_code ,p.Acc_head account_head_name ,p.dr  dr ,p.cr  cr ,'" & GMod.username & "','" & cmbgrpname.Text & "'  from " _
                              & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                              & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "'" _
                              & " and vou_type<>'BANKREC' and Group_name='" & cmbgrpname.Text & "' and sub_group_name='" & cmbgrpname.Text & "'" _
                              & " group by Acc_head_code,Acc_head ) p  where p.dr<>p.cr "
                    GMod.SqlExecuteNonQuery(sql)
                Next
            End If
        End If
        'GMod.DataSetRet(sql, "trial")
    End Sub
    Sub allgrpwisetrial()
        Dim sql As String
        If chkArea.Checked = True Then
            If rdwithopening.Checked Then
                sql = "select * from ( select q.account_code,q.account_head_name,isnull(p.dr,0) + isnull(q.opening_dr,0) dr ,isnull(p.cr,0) + isnull(q.opening_cr,0) cr  from " _
                          & " ( select isnull(sum(dramt),0) dr ,isnull(sum(cramt),0) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & "vou_type<>'BANKREC'" _
                          & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' " _
                          & " group by Acc_head_code,Acc_head ) p  Right Join " _
                          & " ( select isnull(account_code,'') account_code,isnull(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0) opening_cr ,sub_group_name " _
                          & " from " & GMod.ACC_HEAD & " ) q on p.Acc_head_code = q.account_code ) z where z.dr<>z.cr"
            Else
                sql = " select p.Acc_head_code account_code ,p.Acc_head account_head_name ,p.dr  dr ,p.cr  cr  from " _
                         & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                         & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "'" _
                         & " and vou_type<>'BANKREC'" _
                         & " and left(Acc_head_code,2)='" & cmbAreaCode.Text & "'" _
                         & " group by Acc_head_code,Acc_head ) p  where p.dr<>p.cr"

            End If
        Else 'if of area 
            'trial with out area
            If rdwithopening.Checked Then
                sql = "select * from ( select q.account_code,q.account_head_name,isnull(p.dr,0) + isnull(q.opening_dr,0) dr ,isnull(p.cr,0) + isnull(q.opening_cr,0) cr  from " _
                          & " ( select isnull(sum(dramt),0) dr ,isnull(sum(cramt),0) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "' and " _
                          & "vou_type<>'BANKREC'" _
                          & " group by Acc_head_code,Acc_head ) p  Right Join " _
                          & " ( select isnull(account_code,'') account_code,isnull(account_head_name,'') account_head_name ,isnull(opening_dr,0) opening_dr, isnull(opening_cr,0) opening_cr ,sub_group_name " _
                          & " from " & GMod.ACC_HEAD & " ) q on p.Acc_head_code = q.account_code ) z where z.dr<>z.cr order by z.account_code,z.account_head_name"
            Else
                sql = " select p.Acc_head_code account_code ,p.Acc_head account_head_name ,p.dr  dr ,p.cr  cr  from " _
                          & " ( select sum(dramt) dr ,sum(cramt) cr ,Acc_head_code,Acc_head from " _
                          & "" & GMod.VENTRY & " where  Vou_date <= '" & dtfrom.Value.ToShortDateString & "'" _
                          & " and vou_type<>'BANKREC'" _
                          & " group by Acc_head_code,Acc_head ) p  where p.dr<>p.cr  ordr by Acc_head_code,Acc_head"
            End If
        End If
        GMod.DataSetRet(sql, "trial")
    End Sub
    Dim param As String
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        'MsgBox(GMod.ds.Tables("trial").Rows.Count)
        Try
            If chkallgengrps.Checked And rdgeneral.Checked Then
                'allgrpwisetrial()
                GMod.SqlExecuteNonQuery("delete from tmpTrial where Uname='" & GMod.username & "'")
                GrpWiseALL()
            Else
                ' grpwisetrial()
                GrpWise()
            End If
            Dim r As New CrTrial
            Dim sqlseelct As String

            If chkallgengrps.Checked = True Then
                param = "ALL GENERAL GROUPS"
            Else
                If cmbsubgrpname.Text.Length > 2 Then
                    param = "GROUP: " & cmbgrpname.Text & " / SUB GROUP:  " & cmbsubgrpname.Text
                Else
                    param = "GROUP: " & cmbgrpname.Text
                End If
            End If
            If chkArea.Checked = True Then
                param = param & "  AREA : [ " & cmbAreaName.Text & " ]"
            Else
                param = param & " [ ALL AREA ]"
            End If
            If chkallgengrps.Checked = True Then

                If Dr.Checked = True Then
                    If rdCode.Checked = True Then
                        sqlseelct = "select account_code, account_head_name, dr, cr from tmpTrial where Uname='" & GMod.username & "' and dr-cr > 0 order by id"
                    End If
                    If rdName.Checked = True Then
                        sqlseelct = "select account_code, account_head_name, dr, cr from tmpTrial where Uname='" & GMod.username & "' and dr-cr > 0 order by grpname,account_head_name,id"
                    End If
                ElseIf Cr.Checked = True Then
                    If rdCode.Checked = True Then
                        sqlseelct = "select account_code, account_head_name, dr, cr from tmpTrial where Uname='" & GMod.username & "' and cr-dr>0 order by id"
                    End If
                    If rdName.Checked = True Then
                        sqlseelct = "select account_code, account_head_name, dr, cr from tmpTrial where Uname='" & GMod.username & "' and cr-dr>0 order by grpname,account_head_name,id"
                    End If
                Else
                    If rdCode.Checked = True Then
                        sqlseelct = "select account_code, account_head_name, dr, cr from tmpTrial where Uname='" & GMod.username & "' order by id"
                    End If
                    If rdName.Checked = True Then
                        sqlseelct = "select account_code, account_head_name, dr, cr from tmpTrial where Uname='" & GMod.username & "' order by grpname,account_head_name,id"
                    End If
                End If

                GMod.DataSetRet(sqlseelct, "trialall")
                r.SetDataSource(GMod.ds.Tables("trialall"))
                r.SetParameterValue("cmpname", GMod.Cmpname)
                r.SetParameterValue("subhead", "Trial Balance as on " & dtfrom.Text)
                r.SetParameterValue("subhead1", param)
                r.SetParameterValue("uname", GMod.username)
                CrViewerGenralLedger.ReportSource = r
                dgtrial.DataSource = GMod.ds.Tables("trialall")
                'gridall()
                'r.Dispose()
            Else
                r.SetDataSource(GMod.ds.Tables("trial"))
                r.SetParameterValue("cmpname", GMod.Cmpname)
                r.SetParameterValue("subhead", "Trial Balance as on " & dtfrom.Text & " To " & dtTo.Text)
                r.SetParameterValue("subhead1", param)
                r.SetParameterValue("uname", GMod.username)
                CrViewerGenralLedger.ReportSource = r
                dgtrial.DataSource = GMod.ds.Tables("trial")

                'r.Dispose()
            End If
            Button1.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CalcDiff()
    End Sub

    Private Sub chkallgengrps_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkallgengrps.CheckedChanged
        If chkallgengrps.Checked And rdgeneral.Checked Then
            'cmbgrpname.Enabled = False
        ElseIf Not chkallgengrps.Checked And rdgeneral.Checked Then
            'cmbgrpname.Enabled = True
        End If
    End Sub

    Private Sub rdPrint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPrint.CheckedChanged
        If rdPrint.Checked = True Then
            dgtrial.SendToBack()
            CrViewerGenralLedger.BringToFront()
        End If
    End Sub

    Private Sub rdOnscreen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdOnscreen.Click
        If rdOnscreen.Checked = True Then
            dgtrial.BringToFront()
            CrViewerGenralLedger.SendToBack()
        End If
    End Sub
    Public Sub CalcDiff()
        Try
            Dim i As Integer
            Dim diff As Double
            For i = 0 To dgtrial.Rows.Count - 1
                diff = CDbl(dgtrial(2, i).Value) - CDbl(dgtrial(3, i).Value)
                If diff > 0 Then
                    dgtrial(2, i).Value = Math.Abs(diff)
                    dgtrial(3, i).Value = 0.0
                Else
                    dgtrial(3, i).Value = Math.Abs(diff)
                    dgtrial(2, i).Value = 0.0
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub gridall()
        Dim k As Integer
        For k = 0 To GMod.ds.Tables("trialall").Rows.Count - 1
            dgtrial(0, k).Value = GMod.ds.Tables("trialall").Rows(0)(k)
        Next
    End Sub
    Private Sub frmTrial_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try

        Catch ex As Exception

        End Try
    End Sub
    Dim sw As StreamWriter
    Dim ln, pageno As Integer
    Public Sub heads()
        pageno = pageno + 1
        Dim i As Integer
        sw.WriteLine("")
        Dim s As String
        For i = 0 To 30
            s = s + " "
        Next
        s = s + GMod.Cmpname.ToUpper
        sw.WriteLine(s)
        s = ""
        For i = 0 To 30
            s = s + " "
        Next
        s = s & "TRIAL AS ON :" & " " & dtfrom.Text & " TO " & dtTo.Text
        sw.WriteLine(s)
        s = ""
        s = "    " & param
        'sw.WriteLine(s)
        For i = 0 To 41
            s = s + " "
        Next
        s = s + "Page No: " & pageno
        sw.WriteLine(s)
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        s = ""
        sw.WriteLine("   A/c CODE    A/c NAME                             DEBIT R/s            CREDIT R/s ")
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
    End Sub

    Private Sub btnDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDos.Click
        Dim dt() As String
        Dim cr, dr, bl As Double
        cr = 0
        dr = 0

        Dim re As Integer
        ln = 1
        Dim s As String
        sw = File.CreateText("c:\\trial.txt")
        pageno = 0
        heads()

        For re = 0 To GMod.ds.Tables("trial").Rows.Count - 1

            s = "   "
            s = s & GMod.ds.Tables("trial").Rows(re)("account_code")
            s = s & "    " & GMod.ds.Tables("trial").Rows(re)("account_head_name")
            While (s.Length < 49)
                s = s & " "
            End While
            bl = CDbl(GMod.ds.Tables("trial").Rows(re)("dr")) - CDbl(GMod.ds.Tables("trial").Rows(re)("cr"))
            If bl > 0 Then
                s = s & Format(bl, "0.00").PadLeft(12, " ")
                dr = dr + bl
            Else
                s = s & "                  " & Format(Math.Abs(bl), "0.00").PadLeft(12, " ")
                cr = cr + bl
            End If
            sw.WriteLine(s)
            ln = ln + 1
            sw.WriteLine("")
            ln = ln + 1
            If ln > 60 Then
                sw.WriteLine(Convert.ToChar(12).ToString)
                heads()
                pageno = pageno + 1
                ln = 1
            End If
        Next
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        s = "                                            TOTAL:" & Format(Math.Abs(dr), "0.00").PadLeft(12, " ") & "     " & Format(Math.Abs(cr), "0.00").PadLeft(12, " ")
        sw.WriteLine(s)
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        bl = 0
        bl = dr - Math.Abs(cr)
        While (s.Length < 41)
            s = s & " "
        End While
        If bl > 0 Then
            s = s & "BALANCE: " & Format(bl, "0.00").PadLeft(12, " ") & " Dr"
        Else
            s = s & "                    BALANCE:" & Format(Math.Abs(bl), "0.00").PadLeft(12, " ") & " Cr"
        End If
        sw.WriteLine(s)
        'sw.Close()
        'Dim p As New Process
        'p.StartInfo.FileName = "trial.bat"
        'p.Start()
        'sw.Close()

        sw.Close()
        Dim p As New Process
        p.StartInfo.FileName = "printfile.bat"
        p.StartInfo.Arguments = "c:\trial.txt"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.Start()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        cmbgrpname.Text = "INTERNAL PARTY"
        cmbgrpname.Enabled = False
        GMod.DataSetRet("select * from sub_group where group_name='INTERNAL PARTY' and  cmp_id='" & GMod.Cmpid & "'", "sgrp")
        cmbsubgrpname.DataSource = GMod.ds.Tables("sgrp")
        cmbsubgrpname.DisplayMember = "sub_group_name"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CrViewerGenralLedger.PrintReport()
        Button1.Enabled = False
    End Sub
End Class