Imports System.Data
Imports System.Data.SqlClient
Public Class frmSalaryTransfer

    Private Sub frmSalaryTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GMod.DataSetRet("select getdate()", "serverdate")

        'dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        'dtVoucherDate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)


        'dgvoucher.Rows.Add()
        If cmbvtype.Enabled = False Then
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype in ('SALARY JOURNAL','SALARY EXPS') order by seqorder", "vty")
        Else
            ' GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype NOT in ('PAYMENT','OPEN') order by seqorder", "vty")
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype in ('SALARY JOURNAL','SALARY EXPS')  order by seqorder", "vty")

        End If
        cmbvtype.DataSource = GMod.ds.Tables("vty")
        cmbvtype.DisplayMember = "vtype"

        'SESSION CHECK FOR ENTRY 
        'MsgBox(GMod.Getsession(dtvdate.Value))
        If GMod.Getsession(dtVoucherDate.Value) = GMod.Session Then
        Else
            ' Me.Close()
        End If
        Rdothr.Checked = True
    End Sub
    Public dsSal As New DataSet
    Dim totalgis, drv, crv As Double
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        ' Try
        dgvoucher.Rows.Clear()
        'Dim ConStrSal As String = "Data Source=192.168.0.130;Initial Catalog=PhoenixSalUNOESI;User ID=sa;Password=Ph@hoenix#g"
        'Dim ConStrSal As String = "Data Source=117.240.18.180;Initial Catalog=PhoenixSalUNOESI;User ID=sa;Password=Ph@hoenix#g"
        Dim ConStrSal As String = "Data Source=192.168.0.27;Initial Catalog=PhoenixSALUNOESI;User ID=sa;Password=@hplgsamsung#"

        Dim sql, orgid, sqlname As String
        Dim i, j, row As Integer
        Dim da As New SqlDataAdapter
        Dim a, b, c, d, f, t, p As String
        If GMod.Cmpid = "PHOE" Then
            orgid = cmborgid.Text
            sql = "select * from department where orgid='" & orgid & "' order by department"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "Department")
            a = "**EX0041"

            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & a & "'"
            GMod.DataSetRet(sql, "SALHAED")

            'Gettting CPF head  for Hatcheries Casual Staff
            b = "**EX0051"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & b & "'"
            GMod.DataSetRet(sql, "cpfhead")
            c = "**SR0002"
            'Gettting CPF Acount head  for Hatcheries Casual Staff
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & c & "'"
            GMod.DataSetRet(sql, "cpfsum")


            'Employers Group Insurance 
            d = "**EX0053"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & d & "'"
            GMod.DataSetRet(sql, "groupinstot")


            'ESI 
            f = "**EX0069"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & f & "'"
            GMod.DataSetRet(sql, "esihead")

            t = "**TD0008"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & t & "'"
            GMod.DataSetRet(sql, "ithead")

            p = "**EX0106"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & p & "'"
            GMod.DataSetRet(sql, "ptaxhead")

        ElseIf GMod.Cmpid = "PHHA" Then
            orgid = "Phoenix Hatcheries"
            sql = "select * from department where orgid='" & orgid & "' order by department"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "Department")
            a = "**GE0007"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & a & "'"
            GMod.DataSetRet(sql, "SALHAED")

            'Gettting CPF head  for Hatcheries Casual Staff
            b = "**GE0024"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & b & "'"
            GMod.DataSetRet(sql, "cpfhead")

            c = "**SR0002"
            'Gettting CPF Acount head  for Hatcheries Casual Staff
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & c & "'"
            GMod.DataSetRet(sql, "cpfsum")


            'Employers Group Insurance 
            d = "**GE0009"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & d & "'"
            GMod.DataSetRet(sql, "groupinstot")


            t = "**TD0004"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & t & "'"
            GMod.DataSetRet(sql, "ithead")

            p = "**GE0042"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & p & "'"
            GMod.DataSetRet(sql, "ptaxhead")

        ElseIf GMod.Cmpid = "PHFE" Then

            orgid = "Phoenix Feed"
            sql = "select * from department where orgid='" & orgid & "' order by department"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "Department")
            a = "JBEX0001"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & a & "'"
            GMod.DataSetRet(sql, "SALHAED")

            'Gettting CPF head  for Hatcheries Casual Staff
            b = "**EX0045"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & b & "'"
            GMod.DataSetRet(sql, "cpfhead")

            c = "**EX0046"
            'Gettting CPF Acount head  for Hatcheries Casual Staff
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & c & "'"
            GMod.DataSetRet(sql, "cpfsum")


            'Employers Group Insurance 
            d = "**EX0047"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & d & "'"
            GMod.DataSetRet(sql, "groupinstot")


            ' t = "**TD0001"
            t = "**TD0008"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & t & "'"
            GMod.DataSetRet(sql, "ithead")

            p = "**EX0074"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & p & "'"
            GMod.DataSetRet(sql, "ptaxhead")

        ElseIf GMod.Cmpid = "PHLU" Then
            orgid = "Phoenix Farm"
            sql = "select * from department where orgid='" & orgid & "' order by department"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "Department")
            a = "**EX0036"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & a & "'"
            GMod.DataSetRet(sql, "SALHAED")

            'Gettting CPF head  
            b = "**EX0037"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & b & "'"
            GMod.DataSetRet(sql, "cpfhead")

            c = "**EX0038"
            'Gettting CPF Acount head  for Hatcheries Casual Staff
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & c & "'"
            GMod.DataSetRet(sql, "cpfsum")


            'Employers Group Insurance 
            d = "**EX0004"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & d & "'"
            GMod.DataSetRet(sql, "groupinstot")


            t = "**TD0001"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & t & "'"
            GMod.DataSetRet(sql, "ithead")

            p = "**EX0091"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & p & "'"
            GMod.DataSetRet(sql, "ptaxhead")

        ElseIf GMod.Cmpid = "PHCH" Then
            orgid = "Phoenix Chicken"
            sql = "select * from department where orgid='" & orgid & "' order by department"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "Department")
            a = "JBEX0039"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & a & "'"
            GMod.DataSetRet(sql, "SALHAED")

            'Gettting CPF head  
            b = "**EX0072"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & b & "'"
            GMod.DataSetRet(sql, "cpfhead")

            c = "**EX0073"
            'Gettting CPF Acount head  for Hatcheries Casual Staff
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & c & "'"
            GMod.DataSetRet(sql, "cpfsum")


            'Employers Group Insurance 
            d = "**EX0109"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & d & "'"
            GMod.DataSetRet(sql, "groupinstot")


            t = "**TD0001"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & t & "'"
            GMod.DataSetRet(sql, "ithead")

            p = "**EX0105"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & p & "'"
            GMod.DataSetRet(sql, "ptaxhead")

        ElseIf GMod.Cmpid = "PHFA" Then
            orgid = "Phoenix Federation"
            sql = "select * from department where orgid='" & orgid & "' order by department"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "Department")
            a = "**EX0005"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & a & "'"
            GMod.DataSetRet(sql, "SALHAED")

            'Gettting CPF head  
            b = "**EX0006"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & b & "'"
            GMod.DataSetRet(sql, "cpfhead")

            c = "**EX0007"
            'Gettting CPF Acount head  for Hatcheries Casual Staff
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & c & "'"
            GMod.DataSetRet(sql, "cpfsum")


            'Employers Group Insurance 
            d = "**EX0020"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & d & "'"
            GMod.DataSetRet(sql, "groupinstot")


            t = "**TD0001"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & t & "'"
            GMod.DataSetRet(sql, "ithead")

            p = "**EX0018"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & p & "'"
            GMod.DataSetRet(sql, "ptaxhead")

        End If
        row = 0


        'MsgBox(dsSal.Tables("Department").Rows(i)("Department").ToString)
        'Salary Account Dr with Department total
        dgvoucher.Rows.Add()
        Try
            dsSal.Tables("totaldept").Clear()
        Catch ex As Exception

        End Try
        'If GMod.Cmpid = "PHOE" Then
        If cmbPaymode.Text = "BANK" Then
            sql = "select sum(amtpay+hra+cca+oa2+da) from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='BANK'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
        ElseIf cmbPaymode.Text = "CASH" Then
            sql = "select sum(amtpay+hra+cca+oa2+da) from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='CASH'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
        End If
        da = New SqlDataAdapter(sql, ConStrSal)
        da.Fill(dsSal, "totaldept")

        ''getting accounting salary head **********************

        Try
            dsSal.Tables("salcode").Clear()
        Catch ex As Exception
        End Try

        Try
            dsSal.Tables("SALHAED").Clear()
        Catch ex As Exception
        End Try
        Try
            sql = "select salcode from department where  department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "'  and orgid='" & orgid & "' and isnull(salcode,'') <>'' "
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "salcode")
        Catch ex As Exception
            MsgBox("salcode" & ex.Message)
        End Try

        Try
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & dsSal.Tables("salcode").Rows(0)(0).ToString & "'"
            GMod.DataSetRet(sql, "SALHAED")

            dgvoucher(0, row).Value = row
            dgvoucher(1, row).Value = dsSal.Tables("salcode").Rows(0)(0).ToString
            dgvoucher(1, row).Style.BackColor = Color.Cyan
            dgvoucher(2, row).Value = GMod.ds.Tables("SALHAED").Rows(0)("Account_head_name")
            dgvoucher(4, row).Value = dsSal.Tables("totaldept").Rows(0)(0).ToString
            'dgvoucher(6, row).Value = "Dr"
            dgvoucher(6, row).Value = GMod.ds.Tables("SALHAED").Rows(0)("group_name")
            dgvoucher(3, row).Value = "BEING " & dsSal.Tables("Department").Rows(i)("Department").ToString & " SALARY FOR THE MONTH " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year

        Catch ex As Exception
            MsgBox("Salary head not present" & dsSal.Tables("salcode").Rows(0)(0).ToString)
        End Try
        '*****************************-----------------------------------------
        'ElseIf GMod.Cmpid = "PHHA" Then

        'sql = "select sum(amtpay+hra+cca+oa2) from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "'"
        'da = New SqlDataAdapter(sql, ConStrSal)
        'da.Fill(dsSal, "totaldept")

        'dgvoucher(0, row).Value = row
        'dgvoucher(1, row).Value = a
        'dgvoucher(2, row).Value = GMod.ds.Tables("SALHAED").Rows(0)("Account_head_name")
        'dgvoucher(4, row).Value = dsSal.Tables("totaldept").Rows(0)(0).ToString
        ''dgvoucher(6, row).Value = "Dr"
        'dgvoucher(6, row).Value = GMod.ds.Tables("SALHAED").Rows(0)("group_name")
        'dgvoucher(3, row).Value = "BEING " & dsSal.Tables("Department").Rows(i)("Department").ToString & " SALARY FOR THE MONTH " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
        'dgvoucher(1, row).Style.BackColor = Color.Aqua

        'End If
        'All Indisuasal Accont  cr
        Try
            dsSal.Tables("indacc").Clear()
        Catch ex As Exception

        End Try

        Try

            If cmbPaymode.Text = "BANK" Then
                sql = "select empid,name,department,(amtpay+hra+cca+oa2+da) tt from  salacctransfer " _
                & " where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Text & "' and amtpay+hra+cca+oa2+oa1>0 and paymode='BANK'  order by amtpay desc"
            ElseIf cmbPaymode.Text = "CASH" Then
                sql = "select empid,name,department,(amtpay+hra+cca+oa2+da) tt from  salacctransfer " _
                 & " where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Text & "' and amtpay+hra+cca+oa2+oa1+da>0 and paymode='CASH'  order by amtpay desc"
            End If

            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "indacc")

            For j = 0 To dsSal.Tables("indacc").Rows.Count - 1
                'Getting Name of w.t to code    

                Try
                    sqlname = "select  account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & dsSal.Tables("indacc").Rows(j)("empid").ToString & "'"
                    GMod.DataSetRet(sqlname, "empaccname")

                Catch ex As Exception
                    MsgBox("insd" & ex.Message)
                End Try

                dgvoucher.Rows.Add()
                row = row + 1
                dgvoucher(0, row).Value = row
                dgvoucher(1, row).Value = dsSal.Tables("indacc").Rows(j)("empid")
                dgvoucher(2, row).Value = GMod.ds.Tables("empaccname").Rows(0)("account_head_name")
                dgvoucher(5, row).Value = dsSal.Tables("indacc").Rows(j)("tt")
                dgvoucher(6, row).Value = GMod.ds.Tables("empaccname").Rows(0)("group_name")
                dgvoucher(3, row).Value = "BEING SALARY FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
            Next
        Catch ex As Exception
            MsgBox("ADMIN " & ex.Message)
            MsgBox("Invalid Month " & ex.Message)
            Me.Close()

        End Try

        'CPF  Employer's Contribution Dr
        Try
            dsSal.Tables("cpftotal").Clear()
        Catch ex As Exception

        End Try

        dgvoucher.Rows.Add()
        row = row + 1

        If cmbPaymode.Text = "BANK" Then
            sql = "select sum(amt833+amt367)  from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='BANK' " ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
        ElseIf cmbPaymode.Text = "CASH" Then
            sql = "select sum(amt833+amt367)  from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='CASH' " 'and is_ho_emp = '" & RdHO.Checked.ToString & "'"
        End If
        da = New SqlDataAdapter(sql, ConStrSal)
        da.Fill(dsSal, "cpftotal")
        ''getting employer contribution code **********************
        Try
            dsSal.Tables("emplcode").Clear()
        Catch ex As Exception
        End Try
        Try
            dsSal.Tables("cpfhead").Clear()
        Catch ex As Exception
        End Try
        Try
            sql = "select cpfcode from department where  department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "'  and orgid='" & orgid & "' and isnull(cpfcode,'') <>'' "
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "emplcode")
        Catch ex As Exception
            MsgBox("Emplyer's head not present")
        End Try

        Try
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & dsSal.Tables("emplcode").Rows(0)(0).ToString & "'"
            GMod.DataSetRet(sql, "cpfhead")
            dgvoucher(0, row).Value = row
            dgvoucher(1, row).Value = dsSal.Tables("emplcode").Rows(0)(0).ToString
            dgvoucher(1, row).Style.BackColor = Color.BurlyWood
            dgvoucher(2, row).Value = GMod.ds.Tables("cpfhead").Rows(0)("Account_head_name")
            dgvoucher(4, row).Value = dsSal.Tables("cpftotal").Rows(0)(0).ToString
            'dgvoucher(6, row).Value = "Dr"
            dgvoucher(6, row).Value = GMod.ds.Tables("cpfhead").Rows(0)("group_name")
            dgvoucher(3, row).Value = "BEING " & dsSal.Tables("Department").Rows(i)("Department").ToString & " CPF FOR THE MONTH " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
        Catch ex As Exception
            MsgBox("Emplyer's head not present")
        End Try
        '*****************************-----------------------------

        'All Indisuasal CP Accont  cr
        Try
            dsSal.Tables("cpfacc").Clear()
        Catch ex As Exception

        End Try
        Try
            If cmbPaymode.Text = "BANK" Then
                sql = "select empid,name,department,amt833+amt367 tt from  salacctransfer " _
                      & " where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Text & "' and amt833+amt367>0  and paymode='BANK' order by amtpay desc"
            Else
                sql = "select empid,name,department,amt833+amt367 tt from  salacctransfer " _
                                         & " where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Text & "' and  amt833+amt367>0 and paymode='CASH' order by amtpay desc"

            End If
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "cpfacc")

            For j = 0 To dsSal.Tables("cpfacc").Rows.Count - 1
                Try
                    sqlname = "select  account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & dsSal.Tables("cpfacc").Rows(j)("empid").ToString & "'"
                    GMod.DataSetRet(sqlname, "empaccname")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                'Getting Name of w.t to code    


                dgvoucher.Rows.Add()
                row = row + 1
                dgvoucher(0, row).Value = row
                dgvoucher(1, row).Value = dsSal.Tables("cpfacc").Rows(j)("empid")
                dgvoucher(2, row).Value = GMod.ds.Tables("empaccname").Rows(0)("account_head_name")
                dgvoucher(4, row).Value = dsSal.Tables("cpfacc").Rows(j)("tt")
                dgvoucher(6, row).Value = GMod.ds.Tables("empaccname").Rows(0)("group_name")
                dgvoucher(3, row).Value = "BEING CPF COLLECTION FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
            Next
        Catch ex As Exception
            MsgBox("cpf" & ex.Message)
        End Try

        'CPF Account BOTH 
        'MsgBox(dsSal.Tables("cpftotal").Rows(0)(0))
        Try
            dsSal.Tables("cpf").Clear()
        Catch ex As Exception
        End Try
        dgvoucher.Rows.Add()
        row = row + 1
        If cmbPaymode.Text = "BANK" Then
            sql = "select sum(amt833+amt367)  from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='BANK' " 'and is_ho_emp = '" & RdHO.Checked.ToString & "'"
        Else
            sql = "select sum(amt833+amt367)  from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='CASH' " ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
        End If
        da = New SqlDataAdapter(sql, ConStrSal)
        da.Fill(dsSal, "cpf")
        dgvoucher(0, row).Value = row
        dgvoucher(1, row).Value = c
        dgvoucher(2, row).Value = GMod.ds.Tables("cpfsum").Rows(0)("Account_head_name")
        dgvoucher(5, row).Value = Val(dsSal.Tables("cpf").Rows(0)(0).ToString) * 2
        dgvoucher(6, row).Value = GMod.ds.Tables("cpfsum").Rows(0)("group_name")
        dgvoucher(3, row).Value = "BEING " & dsSal.Tables("Department").Rows(i)("Department").ToString & " CPF BOTH FOR THE MONTH " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year

        'Group Insurance detecthed 
        'All Indisuasal Accont  cr
        Try
            dsSal.Tables("groupinsurance").Clear()
        Catch ex As Exception

        End Try
        If cmbPaymode.Text = "BANK" Then
            sql = "select empid,name,department,groupinsded from  salacctransfer " _
                  & " where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Text & "' and groupinsded > 0  and paymode='BANK' order by amtpay desc"
        Else
            sql = "select empid,name,department,groupinsded from  salacctransfer " _
                  & " where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Text & "' and groupinsded > 0  and paymode='CASH' order by amtpay desc"

        End If


        da = New SqlDataAdapter(sql, ConStrSal)
        da.Fill(dsSal, "groupinsurance")
        Try
            For j = 0 To dsSal.Tables("groupinsurance").Rows.Count - 1
                dgvoucher.Rows.Add()
                row = row + 1
                'Getting Name of w.t to code    
                sqlname = "select  account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & dsSal.Tables("groupinsurance").Rows(j)("empid").ToString & "'"
                GMod.DataSetRet(sqlname, "empaccname")
                dgvoucher(0, row).Value = row
                dgvoucher(1, row).Value = dsSal.Tables("groupinsurance").Rows(j)("empid")
                dgvoucher(2, row).Value = GMod.ds.Tables("empaccname").Rows(0)("account_head_name")
                dgvoucher(4, row).Value = dsSal.Tables("groupinsurance").Rows(j)("groupinsded")
                dgvoucher(6, row).Value = GMod.ds.Tables("empaccname").Rows(0)("group_name")
                dgvoucher(3, row).Value = "BEING GIS FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
            Next
        Catch ex As Exception
            MsgBox("groupinsurance" & ex.Message)
            MsgBox("Invalid Month " & ex.Message)
            Me.Close()
        End Try
        'CPF  Employer's Contribution Dr
        Try
            dsSal.Tables("groupinstotal").Clear()
        Catch ex As Exception

        End Try

        dgvoucher.Rows.Add()
        row = row + 1
        If cmbPaymode.Text = "BANK" Then
            sql = "select isnull(sum(groupinsded),0)  from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and orgid='" & orgid & "' and groupinsded>0 and paymode='BANK'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
        Else
            sql = "select isnull(sum(groupinsded),0)  from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and orgid='" & orgid & "' and groupinsded>0 and paymode='CASH' " '  and is_ho_emp = '" & RdHO.Checked.ToString & "'"
        End If

        da = New SqlDataAdapter(sql, ConStrSal)
        da.Fill(dsSal, "groupinstotal")
        If dsSal.Tables("groupinstotal").Rows(0)(0) > 0 Then
            dgvoucher(0, row).Value = row
            dgvoucher(1, row).Value = d
            dgvoucher(2, row).Value = GMod.ds.Tables("groupinstot").Rows(0)("Account_head_name")
            dgvoucher(5, row).Value = dsSal.Tables("groupinstotal").Rows(0)(0).ToString
            'dgvoucher(6, row).Value = "Dr"
            dgvoucher(6, row).Value = GMod.ds.Tables("groupinstot").Rows(0)("group_name")
            dgvoucher(3, row).Value = "BEING EMPLOYER GROUP INSURANCE FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
            'totalgis = totalgis + Val(dsSal.Tables("groupinstotal").Rows(0)(0).ToString)
            row = row + 1
        End If

        ' Department LOOP
        If GMod.Cmpid = "PHOE" Then
            Try
                '''''FOR ESI
                If cmbPaymode.Text = "BANK" Then
                    sql = "select sum(secudep) from  salacctransfer where  salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='BANK'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
                Else
                    sql = "select sum(secudep) from  salacctransfer where  salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='CASH'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"

                End If

                da = New SqlDataAdapter(sql, ConStrSal)
                da.Fill(dsSal, "totalesi")
                dgvoucher.Rows.Add()
                '

                dgvoucher(0, row).Value = row
                dgvoucher(1, row).Value = f
                dgvoucher(1, row).Style.BackColor = Color.Crimson
                dgvoucher(2, row).Value = GMod.ds.Tables("esihead").Rows(0)("Account_head_name")
                dgvoucher(5, row).Value = dsSal.Tables("totalesi").Rows(0)(0).ToString
                'dgvoucher(6, row).Value = "Dr"
                dgvoucher(6, row).Value = GMod.ds.Tables("esihead").Rows(0)("group_name")
                dgvoucher(3, row).Value = "BEING  ESI TOTAL"
                'ESI STAFF A/C Dr

                If cmbPaymode.Text = "BANK" Then
                    sql = "select empid,secudep from salacctransfer where secudep>0 and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and paymode='BANK' " 'and is_ho_emp = '" & RdHO.Checked.ToString & "'"
                Else
                    sql = "select empid,secudep from salacctransfer where secudep>0 and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and paymode='CASH' " 'and is_ho_emp = '" & RdHO.Checked.ToString & "'"
                End If
                da = New SqlDataAdapter(sql, ConStrSal)
                da.Fill(dsSal, "staffesi")
                row = row + 1
                For j = 0 To dsSal.Tables("staffesi").Rows.Count - 1
                    'Getting Name of w.t to code    
                    sqlname = "select  account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & dsSal.Tables("staffesi").Rows(j)("empid").ToString & "'"
                    GMod.DataSetRet(sqlname, "empesi")

                    dgvoucher.Rows.Add()
                    'row = row + 1
                    dgvoucher(0, row).Value = row
                    dgvoucher(1, row).Value = dsSal.Tables("staffesi").Rows(j)("empid")
                    dgvoucher(2, row).Value = GMod.ds.Tables("empesi").Rows(0)("account_head_name")
                    dgvoucher(4, row).Value = dsSal.Tables("staffesi").Rows(j)("secudep")
                    dgvoucher(6, row).Value = GMod.ds.Tables("empesi").Rows(0)("group_name")
                    dgvoucher(3, row).Value = "BEING ESI FOR THE MONTH OF -" & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
                    row = row + 1
                Next
            Catch ex As Exception
                MsgBox("ESI " & ex.Message)
            End Try
        End If 'esi if for 

        '''''FOR TDS
        Try
            dgvoucher.Rows.Add()
            'row = row + 1
            If cmbPaymode.Text = "BANK" Then
                sql = "select sum(it) from  salacctransfer where  salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='BANK'" 'and is_ho_emp = '" & RdHO.Checked.ToString & "'"
            Else
                sql = "select sum(it) from  salacctransfer where  salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "' and paymode='CASH'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
            End If
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "totalit")
            If Val(dsSal.Tables("totalit").Rows(0)(0)) > 0 Then
                dgvoucher(0, row).Value = row
                dgvoucher(1, row).Value = t
                dgvoucher(1, row).Style.BackColor = Color.DarkGreen
                dgvoucher(2, row).Value = GMod.ds.Tables("ithead").Rows(0)("Account_head_name")
                dgvoucher(5, row).Value = dsSal.Tables("totalit").Rows(0)(0).ToString
                'dgvoucher(6, row).Value = "Dr"
                dgvoucher(6, row).Value = GMod.ds.Tables("ithead").Rows(0)("group_name")
                dgvoucher(3, row).Value = "BEING TDS DEDUCT FROM STAFF FOR THE MONTH OF -" & dtSalaryDate.Value.Month
                'ESI STAFF A/C Dr

                If cmbPaymode.Text = "BANK" Then
                    sql = "select empid,it from salacctransfer where it>0 and orgid='" & orgid & "' and  salmonth='" & dtSalaryDate.Text & "' and paymode='BANK' " 'and is_ho_emp = '" & RdHO.Checked.ToString & "'"
                Else
                    sql = "select empid,it from salacctransfer where it>0 and orgid='" & orgid & "' and  salmonth='" & dtSalaryDate.Text & "' and paymode='CASH'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"

                End If

                da = New SqlDataAdapter(sql, ConStrSal)
                da.Fill(dsSal, "staffit")
                row = row + 1
                For j = 0 To dsSal.Tables("staffit").Rows.Count - 1
                    'Getting Name of w.t to code    
                    sqlname = "select  account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & dsSal.Tables("staffit").Rows(j)("empid").ToString & "'"
                    GMod.DataSetRet(sqlname, "empit")
                    dgvoucher.Rows.Add()
                    ' row = row + 1
                    dgvoucher(0, row).Value = row
                    dgvoucher(1, row).Value = dsSal.Tables("staffit").Rows(j)("empid")
                    dgvoucher(2, row).Value = GMod.ds.Tables("empit").Rows(0)("account_head_name")
                    dgvoucher(4, row).Value = dsSal.Tables("staffit").Rows(j)("it")
                    dgvoucher(6, row).Value = GMod.ds.Tables("empit").Rows(0)("group_name")
                    dgvoucher(3, row).Value = "BEING TDS DEDUCT FROM SALARY FOR THE MONTH OF " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
                    row = row + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("IT " & ex.Message)
        End Try

        '''''FOR PROFESSION TAX
        Try
            dgvoucher.Rows.Add()
            'row = row + 1
            If cmbPaymode.Text = "BANK" Then
                sql = "select sum(proftax) from  salacctransfer where  salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and orgid='" & orgid & "' and paymode='BANK'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
            Else
                sql = "select sum(proftax) from  salacctransfer where  salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and orgid='" & orgid & "' and paymode='CASH'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"

            End If

            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "totalptax")
            If Val(dsSal.Tables("totalptax").Rows(0)(0)) > 0 Then
                dgvoucher(0, row).Value = row
                dgvoucher(1, row).Value = p
                dgvoucher(1, row).Style.BackColor = Color.DarkSlateBlue
                dgvoucher(2, row).Value = GMod.ds.Tables("ptaxhead").Rows(0)("Account_head_name")
                dgvoucher(5, row).Value = dsSal.Tables("totalptax").Rows(0)(0).ToString
                'dgvoucher(6, row).Value = "Dr"
                dgvoucher(6, row).Value = GMod.ds.Tables("ptaxhead").Rows(0)("group_name")
                dgvoucher(3, row).Value = "BEING PROF. TAX FOR THE MONTH OF- " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
                'ESI STAFF A/C Dr

                If cmbPaymode.Text = "BANK" Then
                    sql = "select empid,proftax from salacctransfer where proftax>0 and orgid='" & orgid & "' and  salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and paymode='BANK'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
                Else
                    sql = "select empid,proftax from salacctransfer where proftax>0 and orgid='" & orgid & "' and  salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and paymode='CASH'" ' and is_ho_emp = '" & RdHO.Checked.ToString & "'"
                End If
                da = New SqlDataAdapter(sql, ConStrSal)
                da.Fill(dsSal, "staffptax")
                row = row + 1
                For j = 0 To dsSal.Tables("staffptax").Rows.Count - 1
                    'Getting Name of w.t to code    
                    sqlname = "select  account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & dsSal.Tables("staffptax").Rows(j)("empid").ToString & "'"
                    GMod.DataSetRet(sqlname, "empptax")
                    dgvoucher.Rows.Add()
                    ' row = row + 1
                    dgvoucher(0, row).Value = row
                    dgvoucher(1, row).Value = dsSal.Tables("staffptax").Rows(j)("empid")
                    dgvoucher(2, row).Value = GMod.ds.Tables("empptax").Rows(0)("account_head_name")
                    dgvoucher(4, row).Value = dsSal.Tables("staffptax").Rows(j)("proftax")
                    dgvoucher(6, row).Value = GMod.ds.Tables("empptax").Rows(0)("group_name")
                    dgvoucher(3, row).Value = "BEING PROF. TAX FOR THE MONTH OF-" & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year
                    row = row + 1
                Next
            End If
        Catch ex As Exception
            MsgBox(" PTAX " & ex.Message)
        End Try

        For i = 0 To dgvoucher.RowCount - 1
            drv = drv + Val(dgvoucher(4, i).Value)
            crv = crv + Val(dgvoucher(5, i).Value)
        Next

        dr.Text = drv.ToString
        cr.Text = crv.ToString
        'Catch ex As Exception
        'MsgBox("aa" ex.Message)
        ' End Try
    End Sub
    Dim x As Integer
    Dim q As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If lblvouno.Text = "" Then
        '    MsgBox("Voucher Number Required", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        Try
            For x = 0 To dgvoucher.RowCount - 1
                q = "select account_head_name from " & GMod.ACC_HEAD & " where account_code = '" & dgvoucher(1, x).Value.ToString & "'"
                GMod.DataSetRet(q, "ahd")
                If GMod.ds.Tables("ahd").Rows.Count > 0 Then
                    dgvoucher(2, x).Value = GMod.ds.Tables("ahd").Rows(0)(0).ToString
                Else
                    MsgBox("Invalid Selection of Head", MsgBoxStyle.Critical)
                    dgvoucher.Focus()
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox("Please Remove the Extras rows", MsgBoxStyle.Critical)
            Exit Sub
        End Try


        If MessageBox.Show("Are u Sure?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            If Val(dr.Text) = Val(cr.Text) Then
                Dim sqlsave As String, i As Integer
                Try
                    sqlsave = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type = '" & cmbvtype.Text & "'"
                    GMod.DataSetRet(sqlsave, "vnosal_acc_transfer")
                    lblvouno.Text = ds.Tables("vnosal_acc_transfer").Rows(0)(0)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Me.Close()
                End Try

                Dim trans As SqlTransaction
                trans = GMod.SqlConn.BeginTransaction
                Try
                    For i = 0 To dgvoucher.Rows.Count - 1
                        'If Val(dgvoucher(4, i).Value) <> 0 And Val(dgvoucher(5, i).Value) <> 0 Then
                        sqlsave = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date,"
                        sqlsave &= "acc_head_code,Acc_head, dramt, cramt,Narration, Group_name, Sub_group_name"
                        sqlsave &= ") values( "
                        sqlsave &= "'" & GMod.Cmpid & "',"
                        sqlsave &= "'" & GMod.username & "',"
                        sqlsave &= "'" & Val(dgvoucher(0, i).Value) & "',"
                        sqlsave &= "'" & lblvouno.Text & "',"
                        sqlsave &= "'" & cmbvtype.Text & "',"
                        sqlsave &= "'" & dtVoucherDate.Value.ToShortDateString & "',"
                        sqlsave &= "'" & dgvoucher(1, i).Value & "',"
                        sqlsave &= "'" & dgvoucher(2, i).Value & "',"
                        sqlsave &= "'" & Val(dgvoucher(4, i).Value) & "',"
                        sqlsave &= "'" & Val(dgvoucher(5, i).Value) & "',"
                        sqlsave &= "'" & dgvoucher(3, i).Value & "',"
                        sqlsave &= "'" & dgvoucher(6, i).Value & "',"
                        sqlsave &= "'-')"
                        ' MsgBox(sqlsave)
                        Dim cmd As New SqlCommand(sqlsave, GMod.SqlConn, trans)
                        cmd.ExecuteNonQuery()
                        'End If
                    Next
                    trans.Commit()
                    dgvoucher.Rows.Clear()
                    MsgBox(lblvouno.Text & "/" & cmbvtype.Text)
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox(ex.Message)
                End Try
            Else
                dr.BackColor = Color.Red
                cr.BackColor = Color.Red
                MsgBox("Dr<>Cr")
            End If
        End If
    End Sub

    Private Sub lblvouno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblvouno.Leave
        If lblvouno.Text <> "" Then
            Dim q As String
            q = "select * from " & GMod.VENTRY & " where vou_no = '" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'"
            GMod.DataSetRet(q, "xx")
            If GMod.ds.Tables("xx").Rows.Count > 0 Then
                MsgBox("Voucher Already Entered")
                lblvouno.Focus()
                'Button1.Enabled = True
                Me.Close()
                Exit Sub
            Else
                'Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub lblvouno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblvouno.TextChanged

    End Sub

    Private Sub dtVoucherDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtVoucherDate.Leave
        GMod.DataSetRet("select isnull(max(vou_date),'" & dtVoucherDate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbvtype.Text & "'", "getMaxDate")
        If dtVoucherDate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
            MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            dtVoucherDate.Focus()
        End If
    End Sub

    Private Sub dtVoucherDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtVoucherDate.ValueChanged
        'GMod.DataSetRet("select getdate()", "serverdate")
        'dtVoucherDate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        'dtVoucherDate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
    End Sub

    Private Sub cmborgid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmborgid.SelectedIndexChanged

    End Sub

    
    Private Sub Rdothr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdothr.CheckedChanged

    End Sub

    Private Sub cmbvtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvtype.SelectedIndexChanged

    End Sub
End Class