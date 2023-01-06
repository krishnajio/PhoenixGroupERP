Imports System.Data
Imports System.Data.SqlClient
Public Class frmSalaryTransferPoultryCasual

    Private Sub frmSalaryTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select getdate()", "serverdate")

        'dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        'dtVoucherDate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

        'dtVoucherDate.Value = GMod.SessionCurrentDate
        ' dtVoucherDate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        'dtVoucherDate.MaxDate = GMod.SessionCurrentDate

        'dgvoucher.Rows.Add()
        If cmbvtype.Enabled = False Then
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype<>'OPEN' order by seqorder", "vty")
        Else
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype in ('SALARY JOURNAL') order by seqorder", "vty")
            'GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype='SALARY JOURNAL' order by seqorder", "vty")

        End If

        cmbvtype.DataSource = GMod.ds.Tables("vty")
        cmbvtype.DisplayMember = "vtype"

        ' Dim ConStrSal As String = "Data Source=192.168.0.130;Initial Catalog=PhoenixSalUNOESI;User ID=sa;Password=Ph@hoenix#g"
        Dim ConStrSal As String = "Data Source=117.240.18.180;Initial Catalog=PhoenixSalUNOESI;User ID=sa;Password=Ph@hoenix#g"

        Dim da1 As New SqlDataAdapter("select distinct orgid from  salacctransfer", ConStrSal)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        cmbDept.DataSource = ds1.Tables(0)
        cmbDept.DisplayMember = "orgid"
        If GMod.Getsession(dtVoucherDate.Value) = GMod.Session Then

        Else
            'Me.Close()
        End If
    End Sub
    Public dsSal As New DataSet
    Dim totalgis As Double
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        dgvoucher.Rows.Clear()
        ' Try
        Dim ConStrSal As String = "Data Source=117.240.18.180;Initial Catalog=PhoenixSalUNOESI;User ID=sa;Password=Ph@hoenix#g"
        Dim sql, orgid, sqlname As String
        Dim i, j, row As Integer
        Dim da As New SqlDataAdapter
        Dim a, b, c, d, f, t, p, h As String
        If GMod.Cmpid = "PHOE" Then
            orgid = cmbDept.Text

            'Phoenix Hatcheries
            'FEED CASUAL
            'Phoenix Poultry
            'APF CASUAL
            'Hatcheries Casual Staff

            sql = "select * from department where orgid='" & orgid & "' order by department"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "Department")

            a = "**EX0041"
            If orgid = "APF CASUAL" Then
                a = "**EX0137"
            ElseIf orgid = "glabour" Then
                a = "**EX0137"
            ElseIf orgid = "FEED CASUAL" Then
                a = "**EX0138"
            ElseIf orgid = "FEED LABOUR" Then
                a = "**EX0138"
            ElseIf orgid = "Hatcheries Casual Staff" Then
                a = "**EX0087"
            ElseIf orgid = "PPLABOUR" Then
                a = "**EX0087"
            ElseIf orgid = "MANSAR FARM" Then
                a = "**EX0165"
            ElseIf orgid = "mmlabour" Then
                a = "**EX0165"
            ElseIf orgid = "RAIPUR" Then
                a = "**EX0168"
            ElseIf orgid = "RAIPUR LABOUR" Then
                a = "**EX0168"
            ElseIf orgid = "WB LABOUR" Then
                a = "**EX0179"
            End If

            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & a & "'"
            GMod.DataSetRet(sql, "SALHAED")

            'Gettting CPF head  for Hatcheries Casual Staff
            If orgid = "APF CASUAL" Then
                b = "**EX0141"
            ElseIf orgid = "glabour" Then
                b = "**EX0141"
            ElseIf orgid = "FEED CASUAL" Then
                b = "**EX0142"
            ElseIf orgid = "FEED LABOUR" Then
                b = "**EX0142"
            ElseIf orgid = "Hatcheries Casual Staff" Then
                b = "**EX0151"
            ElseIf orgid = "PPLABOUR" Then
                b = "**EX0151"
            ElseIf orgid = "MANSAR FARM" Then
                b = "**EX0166"
            ElseIf orgid = "mmlabour" Then
                b = "**EX0166"
            ElseIf orgid = "RAIPUR" Then
                b = "**EX0169"
            ElseIf orgid = "RAIPUR" Then
                b = "**EX0169"
            ElseIf orgid = "RAIPUR LABOUR" Then
                b = "**EX0169"
            ElseIf orgid = "WB LABOUR" Then
                b = "**EX0180"
            End If

            'b = "**EX0051"
            Try
                sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & b & "'"
                GMod.DataSetRet(sql, "cpfhead")
            Catch ex As Exception
            End Try


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

            'ESI  diff
            h = "**EXOF0163"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & h & "'"
            GMod.DataSetRet(sql, "diffhead")



            '  t = "**TD0001"
            t = "**TD0008"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & t & "'"
            GMod.DataSetRet(sql, "ithead")


            If cmbDept.Text = "PHOENIX POULTRY MANSAR-UNIT" Then
                p = "**MA0168"
            Else
                p = "**EX0106"
            End If


            If cmbDept.Text = "PHOENIX POULTRY HAJIPUR UNIT" Then
                p = "**HJ0019"
            Else
                p = "**EX0106"
            End If


            If cmbDept.Text = "PHOENIX POULTRY VARANASI UNIT" Then
                p = "**BN0015"
            Else
                p = "**EX0106"
            End If
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


            t = "**TD0008"
            ' t = "**TD0001" for tds
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


            t = "**TD0008"
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


            t = "**TD0008"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & t & "'"
            GMod.DataSetRet(sql, "ithead")

            p = "**EX0105"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & p & "'"
            GMod.DataSetRet(sql, "ptaxhead")

        ElseIf GMod.Cmpid = "PRHE" Then
            orgid = "PRIMARY HEALTH CARE"
            sql = "select * from department where orgid='" & orgid & "' order by department"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "Department")
            a = "**JE0012"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & a & "'"
            GMod.DataSetRet(sql, "SALHAED")

            'Gettting CPF head  
            b = "**JE0053"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & b & "'"
            GMod.DataSetRet(sql, "cpfhead")

            c = "**JE0058"
            'Gettting CPF Acount head  for Hatcheries Casual Staff
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & c & "'"
            GMod.DataSetRet(sql, "cpfsum")


            'Employers Group Insurance 
            d = "**JE0058"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & d & "'"
            GMod.DataSetRet(sql, "groupinstot")


            t = "**JE0058"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & t & "'"
            GMod.DataSetRet(sql, "ithead")

            p = "**JE0058"
            sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & p & "'"
            GMod.DataSetRet(sql, "ptaxhead")

        End If

        row = 0
        For i = 0 To dsSal.Tables("Department").Rows.Count - 1
            'MsgBox(dsSal.Tables("Department").Rows(i)("Department").ToString)
            'Salary Account Dr with Department total
            dgvoucher.Rows.Add()
            Try
                dsSal.Tables("totaldept").Clear()
            Catch ex As Exception

            End Try
            'If GMod.Cmpid = "PHOE" Then
            sql = "select sum(amtpay+hra+cca+da) from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "'"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "totaldept")

            ''getting accounting salary head **********************

            Try
                dsSal.Tables("salcode").Clear()
            Catch ex As Exception

            End Try

            sql = "select salcode from department where  department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "'  and orgid='" & orgid & "' and isnull(salcode,'') <>''"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "salcode")

            Try
                sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & dsSal.Tables("salcode").Rows(0)(0).ToString & "'"
                GMod.DataSetRet(sql, "SALHAED")
            Catch ex As Exception

            End Try

            '*****************************-----------------------------------------
            dgvoucher(0, row).Value = row
            dgvoucher(1, row).Value = dsSal.Tables("salcode").Rows(0)(0).ToString
            dgvoucher(1, row).Style.BackColor = Color.Cyan
            dgvoucher(2, row).Value = GMod.ds.Tables("SALHAED").Rows(0)("Account_head_name")
            dgvoucher(4, row).Value = dsSal.Tables("totaldept").Rows(0)(0).ToString
            'dgvoucher(6, row).Value = "Dr"
            dgvoucher(6, row).Value = GMod.ds.Tables("SALHAED").Rows(0)("group_name")
            dgvoucher(3, row).Value = "BEING " & dsSal.Tables("Department").Rows(i)("Department").ToString & " SALARY FOR THE MONTH " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text


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
                sql = "select empid,name,department,(amtpay+hra+cca+da) tt from  salacctransfer " _
                      & " where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Text & "' and amtpay+hra+cca+oa2+da>0 order by department,amtpay desc"
                da = New SqlDataAdapter(sql, ConStrSal)
                da.Fill(dsSal, "indacc")

                For j = 0 To dsSal.Tables("indacc").Rows.Count - 1
                    'Getting Name of w.t to code    
                    sqlname = "select  account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & dsSal.Tables("indacc").Rows(j)("empid").ToString & "'"
                    GMod.DataSetRet(sqlname, "empaccname")

                    dgvoucher.Rows.Add()
                    row = row + 1
                    dgvoucher(0, row).Value = row
                    dgvoucher(1, row).Value = dsSal.Tables("indacc").Rows(j)("empid")
                    dgvoucher(2, row).Value = GMod.ds.Tables("empaccname").Rows(0)("account_head_name")
                    dgvoucher(5, row).Value = dsSal.Tables("indacc").Rows(j)("tt")
                    dgvoucher(6, row).Value = GMod.ds.Tables("empaccname").Rows(0)("group_name")
                    dgvoucher(3, row).Value = "BEING SALARY FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                Next
            Catch ex As Exception
                MsgBox("ADMIN " & ex.Message)
                MsgBox("Invalid Salary Month", MsgBoxStyle.Critical)
                Me.Close()
            End Try

            'CPF  Employer's Contribution Dr
            Try
                dsSal.Tables("cpftotal").Clear()
            Catch ex As Exception

            End Try

            dgvoucher.Rows.Add()
            row = row + 1
            sql = "select sum(amt833+amt367)  from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "'"
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


            sql = "select cpfcode from department where  department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "'  and orgid='" & orgid & "' and isnull(cpfcode,'') <>''"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "emplcode")

            Try
                sql = "SELECT account_code,account_head_name,group_name FROM " & GMod.ACC_HEAD & " WHERE account_code='" & dsSal.Tables("emplcode").Rows(0)(0).ToString & "'"
                GMod.DataSetRet(sql, "cpfhead")
            Catch ex As Exception

            End Try
            '*****************************-----------------------------

            dgvoucher(0, row).Value = row
            dgvoucher(1, row).Value = dsSal.Tables("emplcode").Rows(0)(0).ToString
            dgvoucher(2, row).Value = GMod.ds.Tables("cpfhead").Rows(0)("Account_head_name")
            dgvoucher(4, row).Value = dsSal.Tables("cpftotal").Rows(0)(0).ToString
            'dgvoucher(6, row).Value = "Dr"
            dgvoucher(6, row).Value = GMod.ds.Tables("cpfhead").Rows(0)("group_name")
            dgvoucher(3, row).Value = "BEING " & dsSal.Tables("Department").Rows(i)("Department").ToString & " CPF FOR THE MONTH " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
            dgvoucher(1, row).Style.BackColor = Color.BurlyWood
            'All Indisuasal CP Accont  cr
            Try
                dsSal.Tables("cpfacc").Clear()
            Catch ex As Exception

            End Try

            Try
                sql = "select empid,name,department,amt833+amt367 tt from  salacctransfer " _
                      & " where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Text & "' and amt833+amt367>0 order by department,amtpay desc"
                da = New SqlDataAdapter(sql, ConStrSal)
                da.Fill(dsSal, "cpfacc")

                For j = 0 To dsSal.Tables("cpfacc").Rows.Count - 1

                    'Getting Name of w.t to code    
                    sqlname = "select  account_head_name,group_name from " & GMod.ACC_HEAD & " where account_code='" & dsSal.Tables("cpfacc").Rows(j)("empid").ToString & "'"
                    GMod.DataSetRet(sqlname, "empaccname")
                    dgvoucher.Rows.Add()
                    row = row + 1
                    dgvoucher(0, row).Value = row
                    dgvoucher(1, row).Value = dsSal.Tables("cpfacc").Rows(j)("empid")
                    dgvoucher(2, row).Value = GMod.ds.Tables("empaccname").Rows(0)("account_head_name")
                    dgvoucher(4, row).Value = dsSal.Tables("cpfacc").Rows(j)("tt")
                    dgvoucher(6, row).Value = GMod.ds.Tables("empaccname").Rows(0)("group_name")
                    dgvoucher(3, row).Value = "BEING CPF COLLECTION FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                Next
            Catch ex As Exception
                MsgBox("cpf" & ex.Message)
                MsgBox("Invalid Salary Month", MsgBoxStyle.Critical)
                Me.Close()
            End Try

            'CPF Account BOTH 
            'MsgBox(dsSal.Tables("cpftotal").Rows(0)(0))
            Try
                dsSal.Tables("cpf").Clear()
            Catch ex As Exception
            End Try
            dgvoucher.Rows.Add()
            row = row + 1
            sql = "select sum(amt833+amt367)  from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "'"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "cpf")

            dgvoucher(0, row).Value = row
            dgvoucher(1, row).Value = c
            dgvoucher(2, row).Value = GMod.ds.Tables("cpfsum").Rows(0)("Account_head_name")
            dgvoucher(5, row).Value = Val(dsSal.Tables("cpf").Rows(0)(0).ToString) * 2
            dgvoucher(6, row).Value = GMod.ds.Tables("cpfsum").Rows(0)("group_name")
            dgvoucher(3, row).Value = "BEING " & dsSal.Tables("Department").Rows(i)("Department").ToString & " CPF BOTH FOR THE MONTH " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
            dgvoucher(1, row).Style.BackColor = Color.Cyan
            'Group Insurance detecthed 
            'All Indisuasal Accont  cr
            Try
                dsSal.Tables("groupinsurance").Clear()
            Catch ex As Exception

            End Try
            sql = "select empid,name,department,groupinsded from  salacctransfer " _
                  & " where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Text & "' and groupinsded > 0 order by department,amtpay desc"
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
                    dgvoucher(3, row).Value = "BEING GIS FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                Next
            Catch ex As Exception
                MsgBox("groupinsurance" & ex.Message)
                MsgBox("Invalid Salary Month", MsgBoxStyle.Critical)
                Me.Close()
            End Try
            'CPF  Employer's Contribution Dr
            Try
                dsSal.Tables("groupinstotal").Clear()
            Catch ex As Exception

            End Try

            dgvoucher.Rows.Add()
            row = row + 1
            sql = "select isnull(sum(groupinsded),0)  from  salacctransfer where department='" & dsSal.Tables("Department").Rows(i)("Department").ToString & "' and salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and orgid='" & orgid & "' and groupinsded>0"
            da = New SqlDataAdapter(sql, ConStrSal)
            da.Fill(dsSal, "groupinstotal")
            If dsSal.Tables("groupinstotal").Rows(0)(0) > 0 Then
                dgvoucher(0, row).Value = row
                dgvoucher(1, row).Value = d
                dgvoucher(2, row).Value = GMod.ds.Tables("groupinstot").Rows(0)("Account_head_name")
                dgvoucher(5, row).Value = dsSal.Tables("groupinstotal").Rows(0)(0).ToString
                'dgvoucher(6, row).Value = "Dr"
                dgvoucher(6, row).Value = GMod.ds.Tables("groupinstot").Rows(0)("group_name")
                dgvoucher(3, row).Value = "BEING EMPLOYER GROUP INSURANCE FOR " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                'totalgis = totalgis + Val(dsSal.Tables("groupinstotal").Rows(0)(0).ToString)
                row = row + 1
            End If

        Next ' Department LOOP
        If GMod.Cmpid = "PHOE" Then
            Try
                '''''FOR ESI
                sql = "select sum(secudep) from  salacctransfer where  salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "'"
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
                dgvoucher(3, row).Value = "BEING  ESI TOTAL" & "-" & cmbDept.Text
                'ESI STAFF A/C Dr

                sql = "select empid,oa1 from salacctransfer where secudep>0 and orgid='" & orgid & "' and salmonth='" & dtSalaryDate.Value.ToShortDateString & "' "
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
                    dgvoucher(4, row).Value = dsSal.Tables("staffesi").Rows(j)("oa1")
                    dgvoucher(6, row).Value = GMod.ds.Tables("empesi").Rows(0)("group_name")
                    dgvoucher(3, row).Value = "BEING ESI FOR THE MONTH OF -" & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                    row = row + 1
                Next

                sql = "select sum(secudep-oa1) from  salacctransfer where  salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "'"
                da = New SqlDataAdapter(sql, ConStrSal)
                da.Fill(dsSal, "diffesi")
                dgvoucher.Rows.Add()
                '
                dgvoucher(0, row).Value = row
                dgvoucher(1, row).Value = h
                dgvoucher(1, row).Style.BackColor = Color.Crimson
                dgvoucher(2, row).Value = GMod.ds.Tables("diffhead").Rows(0)("Account_head_name")
                dgvoucher(4, row).Value = dsSal.Tables("diffesi").Rows(0)(0).ToString
                'dgvoucher(6, row).Value = "Dr"
                dgvoucher(6, row).Value = GMod.ds.Tables("diffhead").Rows(0)("group_name")
                dgvoucher(3, row).Value = "BEING  ESI TOTAL" & "-" & cmbDept.Text

            Catch ex As Exception
                MsgBox("ESI " & ex.Message)
                MsgBox("Invalid Salary Month", MsgBoxStyle.Critical)
                Me.Close()
            End Try
        End If 'esi if for 

        '''''FOR TDS
        Try
            dgvoucher.Rows.Add()
            'row = row + 1
            sql = "select sum(it) from  salacctransfer where  salmonth='" & dtSalaryDate.Text & "' and orgid='" & orgid & "'"
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
                dgvoucher(3, row).Value = "BEING TDS DEDUCT FROM STAFF FOR THE MONTH OF -" & dtSalaryDate.Value.Month & "-" & cmbDept.Text
                'ESI STAFF A/C Dr

                sql = "select empid,it from salacctransfer where it>0 and orgid='" & orgid & "' and  salmonth='" & dtSalaryDate.Text & "'"
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
                    dgvoucher(3, row).Value = "BEING TDS DEDUCT FROM SALARY FOR THE MONTH OF " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                    row = row + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("IT " & ex.Message)
            MsgBox("Invalid Salary Month", MsgBoxStyle.Critical)
            Me.Close()
        End Try

        '''''FOR PROFESSION TAX
        Try
            dgvoucher.Rows.Add()
            'row = row + 1
            sql = "select sum(proftax) from  salacctransfer where  salmonth='" & dtSalaryDate.Value.ToShortDateString & "' and orgid='" & orgid & "'"
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
                dgvoucher(3, row).Value = "BEING PROF. TAX FOR THE MONTH OF- " & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                'ESI STAFF A/C Dr

                sql = "select empid,proftax from salacctransfer where proftax>0 and orgid='" & orgid & "' and  salmonth='" & dtSalaryDate.Value.ToShortDateString & "'"
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
                    dgvoucher(3, row).Value = "BEING PROF. TAX FOR THE MONTH OF-" & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "-" & cmbDept.Text
                    row = row + 1
                Next
            End If
        Catch ex As Exception
            MsgBox(" PTAX " & ex.Message)
            MsgBox("Invalid Salary Month", MsgBoxStyle.Critical)
            Me.Close()
        End Try
        drv = 0
        crv = 0

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
    Dim drv, crv As Double
    Dim x As Integer
    Dim q As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If lblvouno.Text = "" Then
        '    MsgBox("Voucher Number required", MsgBoxStyle.Critical)
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
                    GMod.DataSetRet(sqlsave, "vnosal_acc_transfer_casual")
                    lblvouno.Text = ds.Tables("vnosal_acc_transfer_casual").Rows(0)(0)
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
                        sqlsave &= "acc_head_code,Acc_head, dramt, cramt,Narration, Group_name, Sub_group_name,pay_mode"
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
                        sqlsave &= "'-',"
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

    Private Sub dgvoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellContentClick

    End Sub

    Private Sub lblvouno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblvouno.Leave
        If lblvouno.Text <> "" Then
            Dim q As String
            q = "select * from " & GMod.VENTRY & " where vou_no = '" & lblvouno.Text & "' and vou_type='" & cmbvtype.Text & "'"
            GMod.DataSetRet(q, "xx")
            If GMod.ds.Tables("xx").Rows.Count > 0 Then
                MsgBox("Voucher Already Entered")
                lblvouno.Focus()
                Me.Close()
                'Button1.Enabled = True
                Exit Sub

            Else
                'Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub lblvouno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblvouno.TextChanged

    End Sub

    Private Sub dtVoucherDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtVoucherDate.Leave
        GMod.DataSetRet("select getdate()", "serverdate")
        dtVoucherDate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        dtVoucherDate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)

    End Sub

    Private Sub dtVoucherDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtVoucherDate.ValueChanged
        GMod.DataSetRet("select getdate()", "serverdate")
        dtVoucherDate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-Val(GMod.nofd))
        dtVoucherDate.MaxDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
    End Sub
End Class