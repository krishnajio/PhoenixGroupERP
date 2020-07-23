Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmCommonList

    Private Sub frmCommonList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillArea()
        fillcompany()
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area order by Areaname"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
    End Sub
    Public Sub fillcompany()
        Dim sqlcmp As String
        sqlcmp = "select Cmpname,Cmp_id from dbo.Company"
        GMod.DataSetRet(sqlcmp, "Company")

        cmbCmpcode.DataSource = GMod.ds.Tables("Company")
        cmbCmpcode.DisplayMember = "Cmp_id"

        cmbCmpCompany.DataSource = GMod.ds.Tables("Company")
        cmbCmpCompany.DisplayMember = "Cmpname"

        GMod.DataSetRet(sqlcmp, "Company1")
        cmbCmpCodeTO.DataSource = GMod.ds.Tables("Company1")
        cmbCmpCodeTO.DisplayMember = "Cmp_id"

        cmpCompantTo.DataSource = GMod.ds.Tables("Company1")
        cmpCompantTo.DisplayMember = "Cmpname"

    End Sub

    Sub fillgrid()
        Dim i As Integer
        Dim sql As String
        Dim c1, c2 As String
        c1 = "ACC_HEAD_" & cmbCmpcode.Text & "_" & GMod.Session
        c2 = "ACC_HEAD_" & cmbCmpCodeTO.Text & "_" & GMod.Session

        'If a = "" Then
        '    Sql = "select * from " & GMod.ACC_HEAD & "   where group_name='" & lblgroupname.Text & "' and cmp_id='" & GMod.Cmpid & "' and Area_code='" & cmbAreaCode.Text & "' order by account_head_name,group_name,sub_group_name "
        'Else
        '    Sql = "select * from " & GMod.ACC_HEAD & "  where cmp_id='" & GMod.Cmpid & "' and account_head_name like '%" & a & "%' and group_name='" & lblgroupname.Text & "' and Area_code='" & cmbAreaCode.Text & "' order by  account_head_name,group_name,sub_group_name"
        'End If

        sql = "select * from " & c1 & " where group_name='" & lblgroupname.Text & "'" _
        & " and area_code='" & cmbAreaCode.Text & "' and left(account_head_name," & txno_of_char.Text & ") in  (" _
        & " select left(account_head_name," & txno_of_char.Text & ") from " & c2 & " where group_name='" & lblgroupname.Text & "'" _
        & " and area_code='" & cmbAreaCode.Text & "')"


        GMod.DataSetRet(sql, "acc")
        dgaccounthead.Rows.Clear()
        For i = 0 To GMod.ds.Tables("acc").Rows.Count - 1
            dgaccounthead.Rows.Add()
            dgaccounthead(0, i).Value = GMod.ds.Tables("acc").Rows(i)("account_code")
            dgaccounthead(1, i).Value = GMod.ds.Tables("acc").Rows(i)("account_head_name")
            dgaccounthead(2, i).Value = GMod.ds.Tables("acc").Rows(i)("group_name")
            dgaccounthead(3, i).Value = GMod.ds.Tables("acc").Rows(i)("sub_group_name")
            dgaccounthead(4, i).Value = GMod.ds.Tables("acc").Rows(i)("opening_dr")
            dgaccounthead(5, i).Value = GMod.ds.Tables("acc").Rows(i)("opening_cr")
            dgaccounthead(6, i).Value = GMod.ds.Tables("acc").Rows(i)("credit_limit")
            dgaccounthead(7, i).Value = GMod.ds.Tables("acc").Rows(i)("credit_days")
            dgaccounthead(8, i).Value = GMod.ds.Tables("acc").Rows(i)("interest_rule_id")
            dgaccounthead(9, i).Value = GMod.ds.Tables("acc").Rows(i)("rate_of_interest")
            dgaccounthead(10, i).Value = GMod.ds.Tables("acc").Rows(i)("remark3")
        Next
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        fillgrid()
    End Sub

  
    'For Dos Printing of Customer List 13,oct,2008
    Dim sw As StreamWriter
    Dim ln, pageno As Integer
    Dim gr As String
    Public Sub heads()
        pageno = pageno + 1
        Dim i As Integer
        sw.WriteLine("")
        Dim s As String = ""
        For i = 0 To 30
            s = s + " "
        Next
        s = s & Convert.ToChar(14).ToString & GMod.Cmpname.ToUpper
        sw.WriteLine(s)
        s = ""
        For i = 0 To 30
            s = s + " "
        Next
        s = s & lblgroupname.Text
        sw.WriteLine(s)
        s = ""

        s = "    GROUP NAME :" & Convert.ToChar(20).ToString & " " & lblgroupname.Text
        'sw.WriteLine(s)
        For i = 0 To 41
            s = s + " "
        Next
        s = s + "Page No: " & pageno
        sw.WriteLine(s)
        s = ""
        'If chkArea.Checked = True Then
        s = "    AREA :" & " " & cmbAreaName.Text
        sw.WriteLine(s)
        'End If
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        s = ""
        sw.WriteLine("    A/c CODE               A/c NAME                                                               ")
        s = ""
        sw.WriteLine("-------------------------------------------------------------------------------------")
        ln = ln + 8
    End Sub
    'For Dos Printing of Customer List
    Dim s As String
    Private Sub btnDosprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDosprint.Click
        ln = 1
        sw = File.CreateText("c:\\curlist.txt")
        heads()
        Dim i As Integer
        For i = 0 To dgaccounthead.Rows.Count - 1
            s = "    " & dgaccounthead(0, i).Value.ToString & "               " & dgaccounthead(1, i).Value.ToString
            sw.WriteLine(s)
            sw.WriteLine("")
            s = ""
            ln = ln + 2
            If ln > 68 Then
                sw.WriteLine(Convert.ToChar(12).ToString)
                ln = 1
                pageno = pageno + 1
                heads()
            End If
        Next
        sw.WriteLine(Convert.ToChar(12).ToString)
        sw.Close()
        Dim p As New Process
        p.StartInfo.FileName = "curlist.bat"
        p.Start()
        sw.Close()
    End Sub
    Dim i As Integer
    Private Sub btnShow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow1.Click
        Dim dsCN As New DataSet
        Dim daCN As New SqlDataAdapter
        Dim sql As String

        Try
            dsCN.Tables.Clear()
        Catch ex As Exception

        End Try
        Try
            sql = "select * from company"
            GMod.DataSetRet(sql, "cmp")
            For i = 0 To GMod.ds.Tables("cmp").Rows.Count - 1
                sql = "select *,'" & GMod.ds.Tables("cmp").Rows(i)("Cmpname") & "' cmp from ACC_HEAD_" & GMod.ds.Tables("cmp").Rows(i)("Cmp_id") & "_" & GMod.Session & " where account_head_name like '%" & txtName.Text.ToUpper & "%'  and group_name in ('PARTY','CUSTOMER')"
                daCN = New SqlDataAdapter(sql, GMod.Connstr)
                daCN.Fill(dsCN)
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
       
        Dim cr As New CrystalReportCNL
        cr.SetDataSource(dsCN.Tables(0))
        CrystalReportViewer1.ReportSource = cr
    End Sub
End Class