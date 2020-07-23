Imports System.IO
Public Class frmSaleInvoicePrint

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Try
            Dim sql As String, i As Integer
            Dim sql2 As String, dd(3) As String
            sql2 = "select BillDate,AccCode,address,Area_code,Areaname,city,h.state " _
                    & " from Printdata p inner join " & GMod.ACC_HEAD & " h " _
                    & " on p.AccCode = h.account_code" _
                    & " left join Area on Area.prefix = h.Area_code " _
                    & " WHERE vou_type='" & voutype.Text & "' and  cast(vou_no as bigint)  between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "'  and (ProductName='BROILER CHICKS' OR ProductName='COCKREL CHICKS' or ProductName='BROILER HATCHING EGGS' OR ProductName='INVOICE CANCELLED' or ProductName='LAYER HATCHING EGGS') AND p.CMP_ID='" & Cmpid & "' AND SESSION = '" & GMod.Session & "' and authr<>'-' order by cast(BillNo as bigint)"

            'or  ProductName='BROILER CHICKS' 

            GMod.DataSetRet(sql2, "nextrow")

            sql = "select BillNo,HatchDate,AccName,Qty,FreeQty,Amount,NeccAmount,ProductName,rate,FreePer,neccrate,DiscountAmount,DisCountRate" _
            & " from Printdata WHERE  vou_type='" & voutype.Text & "' and cast(vou_no as bigint)  between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "'  and (ProductName='BROILER CHICKS' OR ProductName='COCKREL CHICKS' or  ProductName='BROILER HATCHING EGGS' OR ProductName='INVOICE CANCELLED' or ProductName='LAYER HATCHING EGGS') AND CMP_ID='" & Cmpid & "' AND SESSION = '" & GMod.Session & "' and authr<>'-' order by cast(BillNo as bigint)"

       
            GMod.DataSetRet(sql, "SaleReg")
            'MsgBox("sale reg :" & ds.Tables("salereg").Rows.Count)
            'MsgBox("second row :" & ds.Tables("salereg").Rows.Count)
            dgCRDebit.Rows.Clear()
            Dim r As Integer
            For i = 0 To GMod.ds.Tables("SaleReg").Rows.Count - 1
                dgCRDebit.Rows.Add()
                dgCRDebit(0, r).Value = voutype.Text & "/" & GMod.ds.Tables("SaleReg").Rows(i)(0)
                dd = GMod.ds.Tables("SaleReg").Rows(i)(1).ToString.Split("/")
                dgCRDebit(1, r).Value = dd(1) & "/" & dd(0) & "/" & dd(2).Substring(0, 4)
                dgCRDebit(2, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(2)
                dgCRDebit(3, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(3)
                dgCRDebit(4, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(4)
                dgCRDebit(5, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(5)
                dgCRDebit(6, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(6)
                dgCRDebit(11, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(7)
                If GMod.Cmpid = "PHHA" Then
                    dgCRDebit(12, r).Value = GMod.ds.Tables("SaleReg").Rows(i)("rate") - GMod.ds.Tables("SaleReg").Rows(i)("neccrate")
                Else
                    dgCRDebit(12, r).Value = GMod.ds.Tables("SaleReg").Rows(i)("rate")
                End If
                dgCRDebit(13, r).Value = GMod.ds.Tables("SaleReg").Rows(i)("FreePer")
                dgCRDebit(14, r).Value = GMod.ds.Tables("SaleReg").Rows(i)("neccrate")
                dgCRDebit(16, r).Value = GMod.ds.Tables("SaleReg").Rows(i)("DiscountAmount")
                dgCRDebit(17, r).Value = GMod.ds.Tables("SaleReg").Rows(i)("DiscountRate")

                Dim sqlt As String
                sqlt = " select Sum(Amount) tt from dbo.PrintData where Vou_no= '" & dgCRDebit(0, r).Value & "'"
                GMod.DataSetRet(sqlt, "XX")

                dgCRDebit(15, r).Value = GMod.ds.Tables("XX").Rows(0)("tt")
                GMod.ds.Tables("XX").Clear()
                If GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "LAYER CHICKS" Then
                    dgCRDebit(7, r).Value = Format(Val(GMod.ds.Tables("SaleReg").Rows(i)(5)) - Val(GMod.ds.Tables("SaleReg").Rows(i)(6)), "0.00")
                ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "BROILER CHICKS" Then
                    dgCRDebit(8, r).Value = Format(Val(GMod.ds.Tables("SaleReg").Rows(i)(5)), "0.00")
                ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "COCKREL CHICKS" Then
                    dgCRDebit(9, r).Value = Format(GMod.ds.Tables("SaleReg").Rows(i)(5), "0.00")
                ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "BROILER HATCHING EGGS" Then
                    dgCRDebit(18, r).Value = Format(GMod.ds.Tables("SaleReg").Rows(i)(5), "0.00")
                End If
                'MsgBox(GMod.ds.Tables("SaleReg").Rows(i)(5))
                r = r + 1
                'next row
                dgCRDebit.Rows.Add()
                'MsgBox(GMod.ds.Tables("nextrow").Rows(i)(0)) '.ToString.Split("\"))
                dd = GMod.ds.Tables("nextrow").Rows(i)(0).ToString.Split("/")
                dgCRDebit(0, r).Value = dd(1) & "/" & dd(0) & "/" & dd(2).Substring(0, 4)
                dgCRDebit(1, r).Value = GMod.ds.Tables("nextrow").Rows(i)(1)
                dgCRDebit(2, r).Value = GMod.ds.Tables("nextrow").Rows(i)(2)
                dgCRDebit(10, r - 1).Value = GMod.ds.Tables("nextrow").Rows(i)("city")
                dgCRDebit(10, r).Value = GMod.ds.Tables("nextrow").Rows(i)("state")
                r = r + 1
            Next
        Catch ex As Exception
            dgCRDebit.Rows.Clear()
            MsgBox("Error:Please Enter Voucher Number Again ")
            'Application.Exit()
        End Try
        
    End Sub
    Dim sw As StreamWriter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sw = File.CreateText("saleinv.txt")
            sw.WriteLine(Convert.ToChar(27).ToString & Convert.ToChar(67).ToString & Convert.ToChar(0).ToString & Convert.ToChar(8).ToString)
            Dim totalamtpp As Double
            Dim i, partirow As Integer, j As Integer, r As Integer
            Dim rec As String = ""
            r = 0
            While r < dgCRDebit.Rows.Count - 1
                'sw.WriteLine("")
                'sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                rec = "                                                              "
                rec = rec & Convert.ToChar(14).ToString & dgCRDebit(0, r).Value
                sw.WriteLine(rec)
                rec = "                                                              "
                rec = rec & dgCRDebit(0, r + 1).Value
                sw.WriteLine(rec)

                sw.WriteLine("")
                sw.WriteLine("")
                rec = "          "
                rec = rec & dgCRDebit(1, r).Value 'Hatch date
                sw.WriteLine(rec)

                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                rec = "                                                                " & dgCRDebit(10, r).Value 'Area Name
                sw.WriteLine(rec)

                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                rec = "             " & dgCRDebit(2, r).Value
                rec = rec & "                                            " & dgCRDebit(1, r + 1).Value
                sw.WriteLine(rec)
                'address 
                If dgCRDebit(2, r + 1).Value.ToString.Length > 0 Then
                    Dim ad1, ad2 As String
                    If dgCRDebit(2, r + 1).Value.ToString.Length > 50 Then
                        spliterbook(dgCRDebit(2, r + 1).Value.ToString)
                        'ad1 = dgCRDebit(2, r + 1).Value.ToString.Substring(0, 50)
                        'ad2 = dgCRDebit(2, r + 1).Value.ToString.Substring(51, dgCRDebit(2, r + 1).Value.ToString.Length - 1)
                        sw.WriteLine("              " & sp1(0).ToUpper) '1
                        sw.WriteLine("              " & sp1(1).ToUpper) '1
                    Else
                        sw.WriteLine("              " & dgCRDebit(2, r + 1).Value.ToString.ToUpper) '1
                        sw.WriteLine("") '2
                    End If
                End If
                'sw.WriteLine("") '1
                'sw.WriteLine("") '2
                rec = "             " & dgCRDebit(10, r).Value & "," & dgCRDebit(10, r + 1).Value
                sw.WriteLine(rec) '3
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                partirow = 1
                Dim totamt As Double = 0
repeatprod:
                rec = "          " & dgCRDebit(11, r).Value
                While rec.Length < 45
                    rec = rec & " "
                End While
                'qty
                rec = rec & dgCRDebit(3, r).Value.ToString.PadLeft(10, " ")
                While rec.Length < 55
                    rec = rec & " "
                End While
                'rate
                rec = rec & dgCRDebit(12, r).Value.ToString.PadLeft(8, " ")
                While rec.Length < 60
                    rec = rec & " "
                End While
                'amount
                If GMod.Cmpid = "PHHA" Then
                    If Val(dgCRDebit(7, r).Value) > 0 Then
                        rec = rec & dgCRDebit(7, r).Value.ToString.PadLeft(15, " ")
                        totamt = totamt + Val(dgCRDebit(7, r).Value)
                    End If
                    If Val(dgCRDebit(8, r).Value) > 0 Then
                        rec = rec & dgCRDebit(8, r).Value.ToString.PadLeft(15, " ")
                        totamt = totamt + Val(dgCRDebit(8, r).Value)
                    End If

                    If Val(dgCRDebit(9, r).Value) > 0 Then
                        rec = rec & dgCRDebit(9, r).Value.ToString.PadLeft(15, " ")
                        totamt = totamt + Val(dgCRDebit(9, r).Value)
                    End If
                    sw.WriteLine(rec)
                Else
                    Dim total As Double
                    total = Val(dgCRDebit(12, r).Value) * Val(dgCRDebit(3, r).Value)
                    total = Format(total, "0.00")


                    totalamtpp = totalamtpp + total '- Val(dgCRDebit(16, r).Value) + Val(dgCRDebit(6, r).Value)
                    rec = rec & Format(total, "0.00").ToString.PadLeft(15, " ")
                    sw.WriteLine(rec)

                End If
                partirow = partirow + 1
                'free Percentage
                If Val(dgCRDebit(13, r).Value) > 0 Then
                    rec = "          FREE EXTRA  " & dgCRDebit(13, r).Value & " %"
                    While rec.Length < 45
                        rec = rec & " "
                    End While
                    'qty
                    rec = rec & dgCRDebit(4, r).Value.ToString.PadLeft(10, " ")
                    While rec.Length < 60
                        rec = rec & " "
                    End While
                    sw.WriteLine(rec)
                    partirow = partirow + 1
                End If

                'NECC Amount
                'MsgBox(Val(dgCRDebit(14, r).Value))

                If Val(dgCRDebit(14, r).Value) > 0 Then
                    rec = "          N.E.C.C. AMOUNT "
                    While rec.Length < 55
                        rec = rec & " "
                    End While
                    'rate
                    'MsgBox(dgCRDebit(15, r).Value.ToString)
                    rec = rec & dgCRDebit(14, r).Value.ToString.PadLeft(8, " ")
                    While rec.Length < 60
                        rec = rec & " "
                    End While
                    'amount
                    If GMod.Cmpid = "PHHA" Then
                        rec = rec & dgCRDebit(6, r).Value.ToString.PadLeft(15, " ")
                        totamt = totamt + Val(dgCRDebit(6, r).Value)
                        sw.WriteLine(rec)
                    Else
                        rec = rec & dgCRDebit(6, r).Value.ToString.PadLeft(15, " ")
                        totalamtpp = totalamtpp + Val(dgCRDebit(6, r).Value)
                        sw.WriteLine(rec)
                    End If
                    partirow = partirow + 1
                End If

                'For Discount Amount
                'MsgBox(dgCRDebit(16, r).Value)
                Dim bool As Boolean
                If Val(dgCRDebit(16, r).Value) > 0 Then
                    bool = True
                    rec = "          DISCOUNT AMOUNT "
                    While rec.Length < 55
                        rec = rec & " "
                    End While
                    'rate
                    'MsgBox(dgCRDebit(15, r).Value.ToString)
                    rec = rec & dgCRDebit(17, r).Value.ToString.PadLeft(8, " ")
                    While rec.Length < 60
                        rec = rec & " "
                    End While
                    'amount
                    rec = rec & dgCRDebit(16, r).Value.ToString.PadLeft(15, " ")
                    totalamtpp = totalamtpp - Val(dgCRDebit(16, r).Value)
                    sw.WriteLine(rec)
                End If
                'eND dISCOUNT
                If r + 3 <= dgCRDebit.Rows.Count - 1 Then
                    If dgCRDebit(0, r).Value = dgCRDebit(0, r + 2).Value Then
                        r = r + 2
                        GoTo repeatprod
                    End If
                End If

                'invoice amount
                While partirow <= 7
                    sw.WriteLine("")
                    partirow = partirow + 1
                End While
                sw.WriteLine("")
                rec = "                                                               "
                If GMod.Cmpid = "PHHA" Then
                    rec = rec & Format(totamt, "0.00").ToString.PadLeft(15, " ")
                Else
                    rec = rec & Format(totalamtpp, "0.00").ToString.PadLeft(15, " ")
                End If
                sw.WriteLine(rec)
                'sw.WriteLine("")
                'sw.WriteLine("")
                If GMod.Cmpid = "PHHA" Then
                    spliterbookINV(splitNumber(Format(totamt, "0.00")))
                Else
                    spliterbookINV(splitNumber(Format(totalamtpp, "0.00")))
                End If
                If sp1(0).Length > 0 Then sw.WriteLine("       " & sp1(0)) Else sw.WriteLine("")
                If sp1(1).Length > 0 Then sw.WriteLine("       " & sp1(1)) Else sw.WriteLine("")
                If sp1(2).Length > 0 Then sw.WriteLine("        " & sp1(2)) Else sw.WriteLine("")
                r = r + 2
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                'sw.WriteLine("")
                If bool = True Then
                Else
                    sw.WriteLine("")
                End If
                bool = False
                totalamtpp = 0
                'total = 0
                'from feed charchter 
                sw.WriteLine(Convert.ToChar(12).ToString)
            End While
            'sw.Close()
            'Dim p As New Process
            'p.StartInfo.FileName = "saleinv.bat"
            'p.Start()
            sw.Close()
            Dim p As New Process
            p.StartInfo.FileName = "printfile.bat"
            p.StartInfo.Arguments = "saleinv.txt"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
            sw.Close()
        End Try
    End Sub
    Function spliterbookINV(ByVal st As String)
        Try
            Dim word() As String
            word = st.Split(" ")
            sp1(0) = ""
            sp1(1) = ""
            sp1(2) = ""
            Dim i As Integer
            For i = 0 To word.Length - 1
                'earlier it was 55
                If sp1(0).Length < 30 Then
                    sp1(0) = sp1(0) & word(i) & " "
                Else
                    sp1(1) = sp1(1) & word(i) & " "
                End If
            Next
            word = sp1(1).Split(" ")
            sp1(1) = ""
            For i = 0 To word.Length - 1
                If sp1(1).Length < 40 Then
                    sp1(1) = sp1(1) & word(i) & " "
                Else
                    sp1(2) = sp1(2) & word(i) & " "
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function splitNumber(ByVal number As String) As String
        Dim st() As String
        Dim retval As String

        st = number.Split(".")
        Dim CLS As New Module1.Num2Words
        'If num(1) = "00" Then
        '    retval = NameOfNumber(num(0), True, 9999)
        'Else
        '    retval = NameOfNumber(num(0), True, 9999) & "and "
        '    retval &= NameOfNumber(num(1), True, 9999) & "paise"
        'End If
        If st(1).ToString = "00" Then
            splitNumber = CLS.NUMMM(st(0)) & " Only "
        Else
            splitNumber = CLS.NUMMM(st(0)) & " and " & CLS.NUMMM(st(1)) & " Paise Only "
        End If
    End Function

    Private Sub frmSaleInvoicePrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " [" & GMod.Cmpname & "]"

        'If GMod.Cmpid = "PHHA" Then
        '    voutype.Text = "SALE"
        'Else


        GMod.SqlExecuteNonQuery("update " & GMod.ACC_HEAD & " set address ='-' where len(address) = 0   and group_name ='CUSTOMER'")
        GMod.SqlExecuteNonQuery("update " & GMod.ACC_HEAD & " set city ='-' where len(city) = 0  and group_name ='CUSTOMER'")
        GMod.SqlExecuteNonQuery("update " & GMod.ACC_HEAD & " set state ='-' where len(state) = 0  and group_name ='CUSTOMER'")



        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%SALE%' and vtype not like '%JOURNAL%'", "vou_typeP")
        voutype.DataSource = GMod.ds.Tables("vou_typeP")
        voutype.DisplayMember = "vtype"

        'End If

    End Sub

    Private Sub frmSaleInvoicePrint_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            File.Delete("saleinv.txt")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtCrNoFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrNoFrom.TextChanged

    End Sub

    Private Sub dgCRDebit_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCRDebit.CellContentClick

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtCrNoTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrNoTo.TextChanged

    End Sub
End Class