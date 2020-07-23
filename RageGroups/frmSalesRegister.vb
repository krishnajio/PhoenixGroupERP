Imports System.IO
Public Class frmSalesRegister

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Try
            Dim sql As String, i As Long
            Dim sql2 As String, dd(3) As String
            Dim sqldet As String

            Try
                GMod.ds.Tables("nextrow").Clear()
                GMod.ds.Tables("SaleReg").Clear()
            Catch ex As Exception

            End Try
            sql2 = "select BillDate,AccCode,address,Area_code,Areaname " _
                    & " from Printdata p inner join " & GMod.ACC_HEAD & " h " _
                    & " on p.AccCode = h.account_code" _
                    & " left join Area on Area.prefix = h.Area_code " _
                    & " WHERE cast(vou_no as bigint)  between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & "  and (FreeQty<>0 OR ProductName='COCKREL CHICKS'  OR ProductName='BROILER HATCHING EGGS' OR ProductName='LAYER HATCHING EGGS' OR ProductName='INVOICE CANCELLED') AND p.CMP_ID='" & Cmpid & "' AND SESSION = '" & GMod.Session & "'  order by cast(BillNo as bigint)"
            GMod.DataSetRet(sql2, "nextrow")

            'FreeQyt <> 0 cahged on 5/12/09 ot ProductNasme=Broiler chicks
            'sql = "select BillNo,HatchDate,AccName,Qty,FreeQty,Amount,NeccAmount,ProductName,Vou_no " _
            '& " from Printdata WHERE cast(vou_no as bigint)  between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & "  and (FreeQty<>0 OR ProductName='COCKREL CHICKS'  OR ProductName='BROILER HATCHING EGGS' OR ProductName='LAYER HATCHING EGGS' OR ProductName='INVOICE CANCELLED') AND CMP_ID='" & Cmpid & "' AND SESSION = '" & GMod.Session & "' order by cast(BillNo as bigint)"

            sql = "select BillNo,HatchDate,AccName,Qty,FreeQty,Amount,NeccAmount,ProductName,Vou_no " _
                   & " from Printdata WHERE cast(vou_no as bigint)  between " _
                   & txtCrNoFrom.Text & " and " & txtCrNoTo.Text _
                   & " and (ProductName='LAYER CHICKS' or ProductName='BROILER CHICKS' OR ProductName='COCKREL CHICKS'  OR ProductName='BROILER HATCHING EGGS' OR ProductName='LAYER HATCHING EGGS' OR ProductName='INVOICE CANCELLED') AND CMP_ID='" & Cmpid & "' AND SESSION = '" & GMod.Session & "' order by cast(BillNo as bigint)"

            GMod.DataSetRet(sql, "SaleReg")
            dgCRDebit.Rows.Clear()
            Dim r As Integer
            For i = 0 To GMod.ds.Tables("SaleReg").Rows.Count - 1
                dgCRDebit.Rows.Add()
                dgCRDebit(0, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(0)
                dd = GMod.ds.Tables("SaleReg").Rows(i)(1).ToString.Split("/")
                dgCRDebit(1, r).Value = dd(1) & "/" & dd(0) & "/" & dd(2).Substring(0, 4)
                dgCRDebit(2, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(2)
                dgCRDebit(3, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(3)
                dgCRDebit(4, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(4)
                dgCRDebit(5, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(5)
                dgCRDebit(6, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(6)

               

                If GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "LAYER CHICKS" Then
                    dgCRDebit(7, r).Value = Val(GMod.ds.Tables("SaleReg").Rows(i)(5)) - Val(GMod.ds.Tables("SaleReg").Rows(i)(6))
                ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "BROILER CHICKS" Then
                    dgCRDebit(8, r).Value = Val(GMod.ds.Tables("SaleReg").Rows(i)(5))
                ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "COCKREL CHICKS" Then
                    dgCRDebit(9, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(5)
                End If


                'sql for getting discount amoutn from printdatadet table

                'sqldet = "select * from printdatadet where cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "' and vou_no='" & GMod.ds.Tables("SaleReg").Rows(i)(0) & "'"
                'GMod.DataSetRet(sqldet, "printdatadet")

                'If GMod.ds.Tables("printdatadet").Rows.Count > 0 Then
                '    dgCRDebit(7, r).Value = Val(dgCRDebit(7, r).Value) + Val(GMod.ds.Tables("printdatadet").Rows(0)("DiscountAmount"))
                'End If


                'Try
                '    If GMod.ds.Tables("SaleReg").Rows(i)(8) = GMod.ds.Tables("SaleReg").Rows(i + 1)(8) Then
                '        If GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "LAYER CHICKS" Then
                '            dgCRDebit(7, r).Value = Val(GMod.ds.Tables("SaleReg").Rows(i)(5)) - Val(GMod.ds.Tables("SaleReg").Rows(i)(6))
                '        ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "BROILER CHICKS" Then
                '            dgCRDebit(8, r).Value = Val(GMod.ds.Tables("SaleReg").Rows(i)(5))
                '        ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "COCKRELE CHICKS" Then
                '            dgCRDebit(9, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(5)
                '        End If

                '        If GMod.ds.Tables("SaleReg").Rows(i + 1)(7).ToString = "LAYER CHICKS" Then
                '            dgCRDebit(7, r).Value = Val(GMod.ds.Tables("SaleReg").Rows(i + 1)(5)) - Val(GMod.ds.Tables("SaleReg").Rows(i + 1)(6))
                '        ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "BROILER CHICKS" Then
                '            dgCRDebit(8, r).Value = Val(GMod.ds.Tables("SaleReg").Rows(i + 1)(5))
                '        ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "COCKRELE CHICKS" Then
                '            dgCRDebit(9, r).Value = GMod.ds.Tables("SaleReg").Rows(i + 1)(5)
                '        End If
                '        i = i + 1
                '    Else
                '        If GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "LAYER CHICKS" Then
                '            dgCRDebit(7, r).Value = Val(GMod.ds.Tables("SaleReg").Rows(i)(5)) - Val(GMod.ds.Tables("SaleReg").Rows(i)(6))
                '        ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "BROILER CHICKS" Then
                '            dgCRDebit(8, r).Value = Val(GMod.ds.Tables("SaleReg").Rows(i)(5))
                '        ElseIf GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "COCKRELE CHICKS" Then
                '            dgCRDebit(9, r).Value = GMod.ds.Tables("SaleReg").Rows(i)(5)
                '        End If
                '    End If
                'Catch ex As Exception

                'End Try


                r = r + 1
                'next row
                dgCRDebit.Rows.Add()
                'MsgBox(GMod.ds.Tables("nextrow").Rows(i)(0)) '.ToString.Split("\"))
                dd = GMod.ds.Tables("nextrow").Rows(i)(0).ToString.Split("/")
                dgCRDebit(0, r).Value = dd(1) & "/" & dd(0) & "/" & dd(2).Substring(0, 4)
                dgCRDebit(1, r).Value = GMod.ds.Tables("nextrow").Rows(i)(1)
                dgCRDebit(2, r).Value = GMod.ds.Tables("nextrow").Rows(i)(2)
                If GMod.Cmpid = "PHHA" Or GMod.Cmpid = "JAHA" Then
                    dgCRDebit.Columns(11).Visible = False
                    dgCRDebit(10, r - 1).Value = GMod.ds.Tables("nextrow").Rows(i)(4)
                ElseIf GMod.Cmpid = "PHOE" Then
                    dgCRDebit.Columns(10).Visible = False
                    If GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "BROILER HATCHING EGGS" Or GMod.ds.Tables("SaleReg").Rows(i)(7).ToString = "LAYER HATCHING EGGS" Then
                        dgCRDebit(11, r - 1).Value = GMod.ds.Tables("SaleReg").Rows(i)(5)
                    End If
                End If
                r = r + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        s = s + GMod.Cmpname.ToUpper
        sw.WriteLine(s)
        s = ""
        For i = 0 To 50
            s = s + " "
        Next
        s = s + "SALE REGISTER [" & GMod.Session & "]"
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
        If GMod.Cmpid = "PHHA" Then
            str = "AREA"
            str1 = ""
        Else
            str = "HATCH"
            str1 = ".EGGS"
        End If
        sw.WriteLine("   INVOICE    HATCH       CUSTOMER NAME                NO. OF   FREE  INVOICE     NECC    LAYER       BROILER    COCKREL    " & str)
        sw.WriteLine("   NO.&DATE   DATE        AND ADDRESS                  CHICKS   QTY   AMOUNT      AMOUNT  AMOUNT      AMOUNT      AMOUNT    " & str1)
        s = ""
        sw.WriteLine("  ------------------------------------------------------------------------------------------------------------------------------------")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = " "
        Try
            pageno = 0
            Dim I As Integer, rec As String, j As Integer, len As Integer
            sw = File.CreateText("c:\\salereg.txt")
            header()
            Dim lineno As Integer = 0
            For I = 0 To dgCRDebit.Rows.Count - 1
                rec = "  " & dgCRDebit(0, I).Value

                len = rec.Length
                While rec.Length < 14
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(1, I).Value
                len = rec.Length
                While rec.Length < 24
                    rec = rec & " "
                End While
                rec = rec & dgCRDebit(2, I).Value

                len = rec.Length
                While rec.Length < 55
                    rec = rec & " "
                End While
                If Val(dgCRDebit(3, I).Value) > 0 Then
                    rec = rec & dgCRDebit(3, I).Value.ToString.PadLeft(6, " ")
                Else
                    rec = rec & str.PadLeft(5, " ")
                End If


                len = rec.Length
                While rec.Length < 62
                    rec = rec & " "
                End While
                'rec = rec & dgCRDebit(4, I).Value
                If Val(dgCRDebit(4, I).Value) > 0 Then
                    rec = rec & dgCRDebit(4, I).Value.ToString.PadLeft(5, " ")
                Else
                    rec = rec & str.PadLeft(5, " ")
                End If

                len = rec.Length
                While rec.Length < 68
                    rec = rec & " "
                End While
                'rec = rec & dgCRDebit(5, I).Value
                If Val(dgCRDebit(5, I).Value) > 0 Then
                    rec = rec & dgCRDebit(5, I).Value.ToString.PadLeft(10, " ")
                Else
                    rec = rec & str.PadLeft(5, " ")
                End If

                len = rec.Length
                While rec.Length < 78
                    rec = rec & " "
                End While
                'rec = rec & dgCRDebit(6, I).Value
                If Val(dgCRDebit(6, I).Value) > 0 Then
                    rec = rec & dgCRDebit(6, I).Value.ToString.PadLeft(10, " ")
                Else
                    rec = rec & str.PadLeft(10, " ")
                End If

                len = rec.Length
                While rec.Length < 88
                    rec = rec & " "
                End While
                'rec = rec & dgCRDebit(7, I).Value
                If Val(dgCRDebit(7, I).Value) > 0 Then
                    rec = rec & Format(dgCRDebit(7, I).Value, "0.00").PadLeft(10, " ")
                Else
                    rec = rec & Format(dgCRDebit(7, I).Value, " ").PadLeft(10, " ")
                End If

                len = rec.Length
                While rec.Length < 102
                    rec = rec & " "
                End While
                'rec = rec & dgCRDebit(8, I).Value
                If Val(dgCRDebit(8, I).Value) > 0 Then
                    rec = rec & Format(dgCRDebit(8, I).Value, "0.00").PadLeft(10, " ")
                Else
                    rec = rec & str.PadLeft(10, " ")
                End If

                len = rec.Length
                While rec.Length < 112
                    rec = rec & " "
                End While
                'rec = rec & dgCRDebit(9, I).Value
                If Val(dgCRDebit(9, I).Value) > 0 Then
                    rec = rec & Format(dgCRDebit(9, I).Value, "0.00").PadLeft(10, " ")
                Else
                    rec = rec & str.PadLeft(10, " ")
                End If

                len = rec.Length
                While rec.Length < 124
                    rec = rec & " "
                End While
                If GMod.Cmpid = "PHHA" Then
                    rec = rec & dgCRDebit(10, I).Value

                Else
                    'rec = rec & dgCRDebit(11, I).Value
                    'MsgBox(dgCRDebit(11, I).Value)
                    If Val(dgCRDebit(11, I).Value) > 0 Then
                        rec = rec & dgCRDebit(11, I).Value.ToString.PadLeft(10, " ")
                    Else
                        rec = rec & str.PadLeft(11, " ")
                    End If
                End If
                sw.WriteLine(rec)
                lineno = lineno + 1
                If lineno Mod 2 = 0 Then
                    sw.WriteLine("")
                End If
                If lineno > 37 Then
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
        'txtCrNoFrom.Font = True
        dgCRDebit.Height = Me.Height - 150
    End Sub

    Private Sub frmSalesRegister_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            File.Delete("c:\salereg.txt")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
End Class