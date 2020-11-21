Imports System.IO
Public Class frmOtherSalePrintInvoice
    Dim sql As String
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        sql = " select distinct Vou_type, cast(os.vou_no as bigint), AccCode, AccName, BillNo, convert(varchar(50),BillDate,105) BillDate,Station ,ah.account_head_name,ah.address,os.InqtyNos,os.prdunit from OtherSaleData  os " & _
               " left join " & GMod.ACC_HEAD & " ah on os.accCode=ah.account_code " & _
               " where vou_type='" & cmbVoucherType.Text & "' and os.session=" & GMod.Session & " and cast(vou_no as bigint) between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & "  and os.cmp_id = '" & GMod.Cmpid & "' order by cast(os.vou_no as bigint)"
        GMod.DataSetRet(sql, "invprn")
        dgCRDebit.DataSource = GMod.ds.Tables("invprn")
    End Sub
    Dim sw As StreamWriter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            sw = File.CreateText("saleinv.txt")
            Dim totalamtpp As Double
            Dim i, partirow As Integer, j As Integer, r As Integer
            Dim rec As String = ""
            r = 0
            Dim line As Integer = 0
            While r < dgCRDebit.Rows.Count - 1
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                line = line + 8
                rec = "                                                                    "
                rec = rec & dgCRDebit(0, r).Value
                sw.WriteLine(rec)

                rec = "                                                                    "
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
                rec = rec & "      " & dgCRDebit(1, r + 1).Value
                sw.WriteLine(rec)

                sw.WriteLine("")
                sw.WriteLine("")
                rec = "             " & dgCRDebit(10, r).Value
                sw.WriteLine(rec)
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
                sw.WriteLine("")
                If bool = True Then

                Else
                    sw.WriteLine("")

                End If
                bool = False
                totalamtpp = 0
                'total = 0
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim bool As Boolean
        Try
            sw = File.CreateText("saleinvoth.txt")
            Dim totalamtpp As Double
            Dim i, partirow As Integer, j As Integer, r As Integer
            Dim rec As String = ""
            r = 0
            Dim line As Integer
            While r < dgCRDebit.Rows.Count
                ' sw.WriteLine(Convert.ToChar(27).ToString & Convert.ToChar(67).ToString & Convert.ToChar(0).ToString & Convert.ToChar(4).ToString)
                'sw.WriteLine(Convert.ToChar(27).ToString & Convert.ToChar(50).ToString)

                sw.WriteLine("") '1
                sw.WriteLine("") '2
                sw.WriteLine("") '3
                sw.WriteLine("") '4
                sw.WriteLine("") '5
                sw.WriteLine("") '6
                rec = "        " & dgCRDebit(9, r).Value & "                                                            "
                rec = rec & dgCRDebit(4, r).Value
                sw.WriteLine(rec) '7

                'getting vou_date 
                sql = "select convert(varchar(50),vou_date,105) vou_date  from " & GMod.VENTRY & " where vou_no='" & dgCRDebit(1, r).Value & "' and vou_type='" & dgCRDebit(0, r).Value & "'"
                GMod.DataSetRet(sql, "inv_date")
                rec = "                                                                    "
                rec = rec & GMod.ds.Tables("inv_date").Rows(0)(0).ToString
                sw.WriteLine(rec) '8

                rec = "                                                                    "
                rec = rec & dgCRDebit(10, r).Value.ToString
                sw.WriteLine(rec) '8


                'sw.WriteLine("")
                sw.WriteLine("") '10
                rec = "          "
                'rec = rec & dgCRDebit(1, r).Value 'Hatch date
                'sw.WriteLine(rec)

                sw.WriteLine("") '11
                sw.WriteLine("      " & dgCRDebit(5, r).Value) '11
                sw.WriteLine("") '12
                sw.WriteLine("") '13
                'rec = "                                                                " & dgCRDebit(10, r).Value 'Area Name
                'sw.WriteLine(rec)

                sw.WriteLine("") '14
                sw.WriteLine("") '15
                sw.WriteLine("") '16

                sw.WriteLine("") '15
                sw.WriteLine("") '16


                rec = "      " & dgCRDebit(3, r).Value
                rec = rec & "                   " & dgCRDebit(2, r).Value
                sw.WriteLine(rec) '17

                sw.WriteLine("") '18
                sw.WriteLine("") '19
                rec = "              " & dgCRDebit(8, r).Value

                sw.WriteLine(rec) '20
                sw.WriteLine("") '21
                sw.WriteLine("") '22
                sw.WriteLine("") '23
                ' sw.WriteLine("") '24
                ' sw.WriteLine("") '25

                partirow = 1
                Dim totamt As Double = 0

                sw.WriteLine("") '26'
                sw.WriteLine("") '26'
                line = line + 28
                sql = "select ProductName, OutQty, Rate, Amount, OutQtyNos  from OtherSaleData where vou_no='" & dgCRDebit(1, r).Value & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "' and vou_type='" & dgCRDebit(0, r).Value & "'"
                GMod.DataSetRet(sql, "othdet")
                Dim z As Integer
                Dim amt As Double
                For z = 0 To GMod.ds.Tables("othdet").Rows.Count - 1
                    rec = ""
                    rec = rec & GMod.ds.Tables("othdet").Rows(z)("ProductName").ToString.PadRight(40, " ")
                    rec = rec & GMod.ds.Tables("othdet").Rows(z)("OutQty").ToString.PadLeft(10, " ")
                    rec = rec & GMod.ds.Tables("othdet").Rows(z)("OutQtyNos").ToString.PadLeft(10, " ")
                    rec = rec & GMod.ds.Tables("othdet").Rows(z)("rate").ToString.PadLeft(6, " ")
                    rec = rec & GMod.ds.Tables("othdet").Rows(z)("Amount").ToString.PadLeft(12, " ")
                    amt = amt + Val(GMod.ds.Tables("othdet").Rows(z)("Amount").ToString())
                    sw.WriteLine(rec)
                    line = line + 1
                Next
                While (line <= 33)
                    line = line + 1
                    sw.WriteLine("")
                End While

                sw.WriteLine("") '34
                rec = amt.ToString & ".00"
                sw.WriteLine(rec.ToString.PadLeft(80, " ")) '35

                spliterbookINV(splitNumber(Format(amt, "0.00")))

                If sp1(0).Length > 0 Then sw.WriteLine("" & sp1(0)) Else sw.WriteLine("")
                If sp1(1).Length > 0 Then sw.WriteLine(" " & sp1(1)) Else sw.WriteLine("")
                If sp1(2).Length > 0 Then sw.WriteLine(" " & sp1(2)) Else sw.WriteLine("")

                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                If bool = True Then

                Else
                    sw.WriteLine("")
                End If

                If r Mod 3 = 0 Then
                    sw.WriteLine("")
                End If

                If r Mod 2 = 0 Then
                    sw.WriteLine("")
                End If
                bool = False
                'While (line <= 48)
                '    line = line + 1
                '    sw.WriteLine("")
                'End While

                'If line >= 48 Then
                'sw.WriteLine(Convert.ToChar(12).ToString) '33
                'total = 0
                line = 0
                'End If
                r = r + 1
                amt = 0
            End While
            'sw.Close()
            'Dim p As New Process
            'p.StartInfo.FileName = "saleinv.bat"
            'p.Start()
            sw.Close()
            Dim p As New Process
            p.StartInfo.FileName = "printfile.bat"
            p.StartInfo.Arguments = "saleinvoth.txt"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
            sw.Close()
        End Try
    End Sub

    Private Sub dgCRDebit_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCRDebit.CellContentClick

    End Sub
    Dim q As String
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        q = " Station, ProductName, OutQty, Rate,  Amount, OutQtyNos, BillNo, BillDate, InQty, InQtyNos, Session,mrktrate, Prdunit, Packing, Insurance, Discount, CrHead, cgstp, cgsta, sgstp, sgsta, igstp, igsta,tcs_per,tcs_amt, "
        sql = "select distinct Vou_type, cast(vou_no as bigint) vou_no, AccCode, AccName, BillNo, convert(varchar(50),BillDate,105) BillDate,Station ,ah.account_head_name,ah.address, " & q & " account_type  as authr  from OtherSaleData  os " & _
              "left join " & GMod.ACC_HEAD & " ah on os.accCode=ah.account_code " & _
              " where vou_type='" & cmbVoucherType.Text & "' and os.session=" & GMod.Session & " and cast(vou_no as bigint) between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & "  and os.cmp_id = '" & GMod.Cmpid & "' order by cast(os.vou_no as bigint)"
        GMod.DataSetRet(sql, "invprn")

        Dim crobjprnt
        If GMod.Cmpid = "PHOE" Then
            crobjprnt = New CrDM1
        Else
            crobjprnt = New CrDM1
        End If
        crobjprnt.SetDataSource(GMod.ds.Tables("invprn"))
        CrystalReportViewer1.ReportSource = crobjprnt
    End Sub

    Private Sub frmOtherSalePrintInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select distinct vou_type from othersaledata where session ='" & GMod.Session & "' and cmp_id ='phoe'"
        GMod.DataSetRet(sql, "osvtype")
        cmbVoucherType.DataSource = GMod.ds.Tables("osvtype")
        cmbVoucherType.DisplayMember = "vou_type"
    End Sub
End Class