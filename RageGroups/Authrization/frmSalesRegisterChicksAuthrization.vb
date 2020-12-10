Imports System.IO
Imports System.Data.SqlClient
Public Class frmSalesRegisterChicksAuthrization

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        voutype.Enabled = False
        Dim sql As String, i As Long
        Dim sql2 As String, dd(3) As String
        Dim sqldet As String
        Try


            Try
                GMod.ds.Tables("nextrow").Clear()
                GMod.ds.Tables("SaleReg").Clear()
            Catch ex As Exception

            End Try
            'id, invno, invdate, hdate, code, cname, qty, free, invamt, 
            'neccamt, pheadname, prd_name, Rate, area, uanme
            GMod.SqlExecuteNonQuery("delete from salereg")
            sql2 = " insert into salereg (invno, invdate, hdate, code, cname, qty, free," _
                    & " invamt, neccamt,prd_name, Rate, area, uanme,vou_type,prdunit ,mortality,gstin,tcs_per,tcs_amt) " _
                    & " select vou_no, BillDate,HatchDate,AccCode,h.account_head_name, " _
                    & " Qty,FreeQty,Amount,NeccAmount,ProductName,Rate,Station,'" & GMod.username & "',p.vou_type,PrdUnit,mortality,h.account_type,p.tcs_per,p.tcs_amt from Printdata p " _
                    & " inner join " & GMod.ACC_HEAD & " h  on p.AccCode = h.account_code left join " _
                    & " Area on Area.prefix = h.Area_code  WHERE vou_type='" & voutype.Text & "' and cast(vou_no as bigint) " _
                    & " between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & "  and (FreeQty<>0 OR ProductName in (select ItemName from itemmaster where p.cmp_id='" & GMod.Cmpid & "') " _
                    & " OR ProductName='INVOICE CANCELLED') AND p.CMP_ID='" & GMod.Cmpid & "' AND SESSION = '" & GMod.Session & "' and p.authr='-'" _
                    & " order by cast(BillNo as bigint)"


            GMod.SqlExecuteNonQuery(sql2)
            sql2 = "select * from salereg  where vou_type='" & voutype.Text & "' and uanme='" & GMod.username & "' order by id  "
            GMod.DataSetRet(sql2, "SaleReg")

            'dgCRDebit.Rows.Clear()
            'Dim r As Integer = 0
            'For i = 0 To GMod.ds.Tables("SaleReg").Rows.Count - 1
            '    dgCRDebit.Rows.Add()
            '    dgCRDebit(0, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(1)
            '    dd = GMod.ds.Tables("SaleReg").Rows(i)(2).ToString.Split("/")
            '    dgCRDebit(1, r).Value = dd(1) & "/" & dd(0) & "/" & dd(2).Substring(0, 4)

            '    dd = GMod.ds.Tables("SaleReg").Rows(i)(3).ToString.Split("/")
            '    dgCRDebit(2, r).Value = dd(1) & "/" & dd(0) & "/" & dd(2).Substring(0, 4)


            '    dgCRDebit(3, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(4)
            '    dgCRDebit(4, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(5)
            '    dgCRDebit(5, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(6)
            '    dgCRDebit(6, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(7)
            '    dgCRDebit(7, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(8)
            '    dgCRDebit(8, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(9)
            '    r = r + 1
            '    'next row
            'Next
            If voutype.Text.Contains("PURCHASE") Then

                For i = 0 To GMod.ds.Tables("SaleReg").Rows.Count - 1
                    sql2 = "select Acc_head from " & GMod.VENTRY & " where vou_no=" & GMod.ds.Tables("SaleReg").Rows(i)("invno") & " and vou_type='" & voutype.Text & "' and dramt>0 and acc_head like '%PUR%' "
                    GMod.DataSetRet(sql2, "crhead")

                    sql = "update  salereg set  pheadname='" & GMod.ds.Tables("crhead").Rows(0)(0).ToString & "' where invno='" & GMod.ds.Tables("SaleReg").Rows(i)("invno") & "'"
                    GMod.SqlExecuteNonQuery(sql)
                Next
            Else

                For i = 0 To GMod.ds.Tables("SaleReg").Rows.Count - 1
                    sql2 = "select Acc_head from " & GMod.VENTRY & " where vou_no=" & GMod.ds.Tables("SaleReg").Rows(i)("invno") & " and vou_type='" & voutype.Text & "' and cramt>0 and acc_head like '%SALE%'  and group_name like '%SALE%'"
                    GMod.DataSetRet(sql2, "crhead")

                    sql = "update  salereg set  pheadname='" & GMod.ds.Tables("crhead").Rows(0)(0).ToString & "' where invno='" & GMod.ds.Tables("SaleReg").Rows(i)("invno") & "'"
                    GMod.SqlExecuteNonQuery(sql)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        GMod.DataSetRet("select * from salereg  where vou_type='" & voutype.Text & "' and uanme='" & GMod.username & "' order by id  ", "SaleReg1")
        GMod.DataSetRet("select invno, CONVERT(VARCHAR(11), invdate, 103) invdate ,CONVERT(VARCHAR(11), hdate, 103)  hdate, code, cname, gstin,prd_name, qty, free,  qty + free total ,rate, invamt, neccamt,pheadname, prdunit,mortality,tcs_amt  from salereg  where vou_type='" & voutype.Text & "' and uanme='" & GMod.username & "' order by id  ", "SaleRegGrid")
        DataGridView1.DataSource = GMod.ds.Tables("SaleRegGrid")

        Dim crsr As New CrySaleReg1
        crsr.SetDataSource(GMod.ds.Tables("SaleReg1"))
        crsr.SetParameterValue("p1", GMod.Cmpname)
        crsr.SetParameterValue("p2", "Invoice No. From " & txtCrNoFrom.Text & " To " & txtCrNoTo.Text)
        crsr.SetParameterValue("p3", "Session " & GMod.Session)
        crsr.SetParameterValue("p4", "User Name " & GMod.username)
        crsr.SetParameterValue("p5", voutype.Text & " - REGISTER")
        CrystalReportViewer1.ReportSource = crsr


    End Sub
    Dim sw As StreamWriter
    Dim pageno As Integer = 0
    Sub header()
        pageno = pageno + 1
        Dim i As Integer
        sw.WriteLine("")
        Dim s As String
        For i = 0 To 50
            s = s + " "
        Next
        s = s & Convert.ToChar(14).ToString & GMod.Cmpname.ToUpper
        sw.WriteLine(s)
        s = ""
        For i = 0 To 50
            s = s + " "
        Next
        s = s & Convert.ToChar(20).ToString & "SALE REGISTER [" & GMod.Session & "]"
        sw.WriteLine(s)
        s = "     SALE NO. FROM: " & txtCrNoFrom.Text & "  TO  " & txtCrNoTo.Text
        For i = 0 To 88
            s = s + " "
        Next
        s = s + "Page No: " & pageno
        sw.WriteLine(s)
        s = ""
        sw.WriteLine("  ------------------------------------------------------------------------------------------------------------------------------------")
        s = ""
        Dim str, str1 As String

        sw.WriteLine("   INVOICE INV        HATCH       CUST.CODE CUSTOMER NAME                   QTY    FREE   INVOICE     NECC    PRODUCT NAME    ")
        sw.WriteLine("   NO      DATE       DATE                                                         QTY    AMOUNT      AMOUNT                  ")
        s = ""
        sw.WriteLine("  ------------------------------------------------------------------------------------------------------------------------------------")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String = " "
        Try
            pageno = 0
            Dim I As Integer, rec As String, j As Integer, len As Integer
            sw = File.CreateText("c:\\salereg.txt")
            header()
            Dim lineno As Integer = 0
            For I = 0 To dgCRDebit.Rows.Count - 1
                rec = "   " & dgCRDebit(0, I).Value.ToString

                len = rec.Length
                While rec.Length < 10
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(1, I).Value
                len = rec.Length
                While rec.Length < 22
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(2, I).Value

                len = rec.Length
                While rec.Length < 34
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(3, I).Value


                len = rec.Length
                While rec.Length < 44
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(4, I).Value

                len = rec.Length
                While rec.Length < 74
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(5, I).Value.ToString.PadLeft(7, " ")

                len = rec.Length
                While rec.Length < 81
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(6, I).Value.ToString.PadLeft(6, " ")

                len = rec.Length
                While rec.Length < 85
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(7, I).Value.ToString.PadLeft(11, " ")

                len = rec.Length
                While rec.Length < 97
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(8, I).Value.ToString.PadLeft(9, " ")

                Dim pn() As String
                Dim pnc As String = ""
                Dim pnl As Integer, z As Int16
                pn = dgCRDebit(9, I).Value.ToString.Split(" ")
                pnl = pn.Length
                For z = 2 To pnl - 1
                    pnc = pnc & " " & pn(z)
                Next

                len = rec.Length
                While rec.Length < 108
                    rec = rec & " "
                End While
                rec = rec & pnc
                pnc = ""
                pnl = 0
                sw.WriteLine(rec)
                sw.WriteLine("")
                lineno = lineno + 1
                If lineno > 35 Then
                    sw.WriteLine(Convert.ToChar(12).ToString)
                    header()
                    'pageno = pageno + 1
                    lineno = 0
                End If
                rec = ""
            Next
            'sw.Close()
            'p.StartInfo.FileName = "salesr.bat"
            'p.Start()

            sw.Close()
            Dim p As New Process
            p.StartInfo.FileName = "printfile.bat"
            p.StartInfo.Arguments = "c:\salereg.txt"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()


        Catch ex As Exception
            'sw.Close()
            'p.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSalesRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgCRDebit.Visible = False
        'txtCrNoFrom.Font = True
        dgCRDebit.Height = Me.Height - 150
        'If GMod.Cmpid = "PHHA" Then
        '    voutype.Text = "SALE"
        'Else


        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%SALE%' and vtype not like '%JOURNAL%' and session ='" & GMod.Session & "'", "vou_typesr")
        voutype.DataSource = GMod.ds.Tables("vou_typesr")
        voutype.DisplayMember = "vtype"

        ' End If
        DataGridView1.Visible = False
        CrystalReportViewer1.Visible = True
    End Sub

    Private Sub frmSalesRegister_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            File.Delete("c:\salereg.txt")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            DataGridView1.Visible = True
            CrystalReportViewer1.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            DataGridView1.Visible = False
            CrystalReportViewer1.Visible = True
        End If
    End Sub
    Dim sql As String
    Private Sub btnAuth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuth.Click
        Dim i As Integer
        Dim trans As SqlTransaction
        trans = GMod.SqlConn.BeginTransaction
        Try

            sql = " update " & GMod.VENTRY & " set pay_mode='" & GMod.username & "'  where vou_type='" & voutype.Text _
                          & "' and cast(vou_no as bigint) between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "' AND pay_mode='-'"
            Dim cmd As New SqlCommand(Sql, GMod.SqlConn, trans)
            cmd.ExecuteNonQuery()


            ' sql = "update tdsentry set authr='-' where session ='1112'"
            sql = " update printdata  set authr='" & GMod.username & "'  where vou_type='" & voutype.Text _
                                     & "' and cast(vou_no as bigint) between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' AND authr='-'"
            Dim cmdtds As New SqlCommand(Sql, GMod.SqlConn, trans)
            cmdtds.ExecuteNonQuery()



            trans.Commit()
            MsgBox("Authorization Complete", MsgBoxStyle.Information)
        Catch ex As Exception
            trans.Rollback()
        End Try
    End Sub

    Private Sub rdpur_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdpur.CheckedChanged
        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%PURCHASE%' and vtype not like '%JOURNAL%' and session ='" & GMod.Session & "'", "vou_typesr")
        voutype.DataSource = GMod.ds.Tables("vou_typesr")
        voutype.DisplayMember = "vtype"

    End Sub
End Class