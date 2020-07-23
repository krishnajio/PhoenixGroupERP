Imports System.IO
Public Class frmPurchase_RegisterOther


    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click

        'Try
        On Error Resume Next
        dgPurchase.Rows.Clear()
        Dim i As Integer
        Dim sql1 As String, sql2 As String, sqlexp As String
        sql1 = " SELECT  narration,a.account_head_name name ,a.remark2 rm ,a.address addr,v.vou_no FROM " & GMod.VENTRY & " v " _
               & " right join " & GMod.ACC_HEAD & " a on v. Acc_head_code=a.account_code " _
             & " WHERE vou_type='PURCHASE' and cast(vou_no as bigint) between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & " and v.group_name='PARTY' order by cast(vou_no as bigint)  "
        ' & " WHERE vou_type='PURCHASE' and vou_date between '" & dtFrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and v.group_name='PARTY' order by cast(vou_no as bigint)  "

        GMod.DataSetRet(sql1, "sql1")


        sql2 = " select  Vou_no,Acc_head,dramt from " & GMod.VENTRY _
                       & " where Vou_type='PURCHASE' and cast(vou_no as bigint) between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & "  and Group_name='PURCHASE' " _
                       & "  order by cast(vou_no as bigint)  "
        '& " WHERE vou_type='PURCHASE' and vou_date between '" & dtFrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Group_name='PURCHASE'  order by cast(vou_no as bigint)  "

        GMod.DataSetRet(sql2, "sql2")


        Dim sql3 As String
        sql2 = " select * from " & GMod.INVENTORY _
                        & " where Vou_type='PURCHASE' and cast(vou_no as bigint) between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text _
                        & "  order by cast(vou_no as bigint)  "
        GMod.DataSetRet(sql2, "sql3")

        Dim arr() As String
        Dim arrdt() As String
        Dim r As Integer = 0
        Dim c As Integer = 0
        Dim chk As Integer = 0
        Dim pr As String = ""
        For i = 0 To GMod.ds.Tables("sql3").Rows.Count - 1
            If pr <> Val(GMod.ds.Tables("sql3").Rows(i)("Vou_no")) Then
                'MsgBox(GMod.ds.Tables("sql3").Rows(i)("Vou_no"))
                chk = 0
                dgPurchase.Rows.Add()
                arr = GMod.ds.Tables("sql1").Rows(c)("narration").ToString.Split(" ")
                dgPurchase(0, r).Value = arr(2)
                dgPurchase(1, r).Value = GMod.ds.Tables("sql1").Rows(c)("name")
                dgPurchase(2, r).Value = "P/" & GMod.ds.Tables("sql3").Rows(i)("Vou_no")
                dgPurchase(3, r).Value = GMod.ds.Tables("sql3").Rows(i)("itemname") & " [" & GMod.ds.Tables("sql3").Rows(i)("Acc_head") & "]" 'For Product Name 
                dgPurchase(4, r).Value = GMod.ds.Tables("sql3").Rows(i)("Amount")
                ' MsgBox(GMod.ds.Tables("sql3").Rows(i)("Vou_no"))
                'Calculating Expneses
                sqlexp = " select dramt,cramt from " & GMod.VENTRY & " where Vou_type='PURCHASE' and cast(vou_no as bigint) =" & GMod.ds.Tables("sql3").Rows(i)("Vou_no").ToString _
                         & " and Group_name = 'FREIGHT'"
                GMod.DataSetRet(sqlexp, "exp")
                If GMod.ds.Tables("exp").Rows.Count > 0 Then
                    If Val(GMod.ds.Tables("exp").Rows(0)("dramt")) > 0 Then
                        dgPurchase(5, r).Value = GMod.ds.Tables("exp").Rows(0)("dramt")
                    Else
                        dgPurchase(5, r).Value = GMod.ds.Tables("exp").Rows(0)("cramt")
                    End If
                End If

                'Calculating VAT
                sqlexp = " select dramt,cramt from " & GMod.VENTRY & " where Vou_type='PURCHASE' and cast(vou_no as bigint) =" & GMod.ds.Tables("sql3").Rows(i)("Vou_no").ToString _
                         & " and Group_name in ('VAT','TDS')"
                GMod.DataSetRet(sqlexp, "vat")
                If GMod.ds.Tables("vat").Rows.Count > 0 Then
                    If Val(GMod.ds.Tables("vat").Rows(0)("dramt")) > 0 Then
                        dgPurchase(6, r).Value = GMod.ds.Tables("vat").Rows(0)("dramt")
                    Else
                        dgPurchase(6, r).Value = GMod.ds.Tables("vat").Rows(0)("cramt")
                    End If
                End If

                'Calculating Party AMOUNT
                sqlexp = " select cramt from " & GMod.VENTRY & " where Vou_type='PURCHASE' and cast(vou_no as bigint) =" & GMod.ds.Tables("sql3").Rows(i)("Vou_no").ToString _
                         & " and Group_name='PARTY'"
                GMod.DataSetRet(sqlexp, "party")
                If GMod.ds.Tables("party").Rows.Count > 0 Then
                    dgPurchase(7, r).Value = GMod.ds.Tables("party").Rows(0)("cramt")
                End If


                'Next Line
                r = r + 1
                dgPurchase.Rows.Add()
                arrdt = arr(3).Split(".")
                'MsgBox(arr(2))
                dgPurchase(0, r).Value = arrdt(1)
                dgPurchase(1, r).Value = GMod.ds.Tables("sql1").Rows(c)("addr")
                dgPurchase(2, r).Value = GMod.ds.Tables("sql1").Rows(c)("rm")
                r = r + 1
                c = c + 1
                pr = Val(GMod.ds.Tables("sql3").Rows(i)("Vou_no"))
            Else
               
                dgPurchase(3, r - 1).Value = GMod.ds.Tables("sql3").Rows(i)("itemname") & " [" & GMod.ds.Tables("sql3").Rows(i)("Acc_head") & "]"
                dgPurchase(4, r - 1).Value = GMod.ds.Tables("sql3").Rows(i)("amount")
                pr = Val(GMod.ds.Tables("sql3").Rows(i)("Vou_no"))
                'If pr = Val(GMod.ds.Tables("sql3").Rows(i)("Vou_no")) Then
                dgPurchase.Rows.Add()
                r = r + 1
                'End If
                'dgPurchase.Rows.Add()

            End If
            'dgPurchase.Rows.Add()
            'If Val(GMod.ds.Tables("sql2").Rows(i)("Vou_no")) <> Val(GMod.ds.Tables("sql2").Rows(i + 1)("Vou_no")) Then

            '    arr = GMod.ds.Tables("sql1").Rows(c)("narration").ToString.Split(" ")
            '    dgPurchase(0, r).Value = arr(2)
            '    dgPurchase(1, r).Value = GMod.ds.Tables("sql1").Rows(c)("name")
            '    dgPurchase(2, r).Value = "P/" & GMod.ds.Tables("sql2").Rows(i)("Vou_no")
            '    dgPurchase(3, r).Value = GMod.ds.Tables("sql2").Rows(i)("Acc_head")
            '    dgPurchase(4, r).Value = GMod.ds.Tables("sql2").Rows(i)("dramt")

            '    'Calculating Expneses
            '    sqlexp = " select dramt,cramt from " & GMod.VENTRY & " where Vou_type='PURCHASE' and cast(vou_no as bigint) =" & GMod.ds.Tables("sql2").Rows(i)("Vou_no").ToString _
            '             & " and Group_name='EXPENSES' "
            '    GMod.DataSetRet(sqlexp, "exp")
            '    If GMod.ds.Tables("exp").Rows.Count > 0 Then
            '        If Val(GMod.ds.Tables("exp").Rows(0)("cramt")) > 0 Then
            '            dgPurchase(5, r).Value = GMod.ds.Tables("exp").Rows(0)("cramt")
            '        Else
            '            dgPurchase(6, r).Value = GMod.ds.Tables("exp").Rows(0)("dramt")
            '        End If
            '    End If

            '    'Calculating VAT
            '    sqlexp = " select dramt from " & GMod.VENTRY & " where Vou_type='PURCHASE' and cast(vou_no as bigint) =" & GMod.ds.Tables("sql2").Rows(i)("Vou_no").ToString _
            '             & " and Group_name='VAT'"
            '    GMod.DataSetRet(sqlexp, "vat")
            '    If GMod.ds.Tables("vat").Rows.Count > 0 Then
            '        dgPurchase(6, r).Value = GMod.ds.Tables("vat").Rows(0)("dramt")
            '    End If

            '    'Calculating Party AMOUNT
            '    sqlexp = " select cramt from " & GMod.VENTRY & " where Vou_type='PURCHASE' and cast(vou_no as bigint) =" & GMod.ds.Tables("sql2").Rows(i)("Vou_no").ToString _
            '             & " and Group_name='PARTY'"
            '    GMod.DataSetRet(sqlexp, "party")
            '    If GMod.ds.Tables("party").Rows.Count > 0 Then
            '        dgPurchase(7, r).Value = GMod.ds.Tables("party").Rows(0)("cramt")
            '    End If


            '    'Next Line
            '    r = r + 1
            '    dgPurchase.Rows.Add()
            '    arrdt = arr(3).Split(".")
            '    'MsgBox(arr(2))
            '    dgPurchase(0, r).Value = arrdt(1)
            '    dgPurchase(1, r).Value = GMod.ds.Tables("sql1").Rows(c)("addr")
            '    dgPurchase(2, r).Value = GMod.ds.Tables("sql1").Rows(c)("rm")
            '    r = r + 1
            '    c = c + 1
            'Else
            '    'MsgBox(GMod.ds.Tables("sql2").Rows(i + 1)("Acc_head"))

            '    arr = GMod.ds.Tables("sql1").Rows(c)("narration").ToString.Split(" ")
            '    dgPurchase(0, r).Value = arr(2)
            '    dgPurchase(1, r).Value = GMod.ds.Tables("sql1").Rows(c)("name")
            '    dgPurchase(2, r).Value = "P/" & GMod.ds.Tables("sql2").Rows(i)("Vou_no")
            '    dgPurchase(3, r).Value = GMod.ds.Tables("sql2").Rows(i)("Acc_head")
            '    dgPurchase(4, r).Value = GMod.ds.Tables("sql2").Rows(i)("dramt")



            '    'Calculating Expneses
            '    sqlexp = " select cramt from " & GMod.VENTRY & " where Vou_type='PURCHASE' and cast(vou_no as bigint) =" & GMod.ds.Tables("sql2").Rows(i)("Vou_no").ToString _
            '             & " and Group_name='EXPENSES' "
            '    GMod.DataSetRet(sqlexp, "exp")
            '    If GMod.ds.Tables("exp").Rows.Count > 0 Then
            '        dgPurchase(5, r).Value = GMod.ds.Tables("exp").Rows(0)("cramt")
            '    End If

            '    'Calculating VAT
            '    sqlexp = " select dramt from " & GMod.VENTRY & " where Vou_type='PURCHASE' and cast(vou_no as bigint) =" & GMod.ds.Tables("sql2").Rows(i)("Vou_no").ToString _
            '             & " and Group_name='VAT'"
            '    GMod.DataSetRet(sqlexp, "vat")
            '    If GMod.ds.Tables("vat").Rows.Count > 0 Then
            '        dgPurchase(6, r).Value = GMod.ds.Tables("vat").Rows(0)("dramt")
            '    End If

            '    'Calculating Party AMOUNT
            '    sqlexp = " select cramt from " & GMod.VENTRY & " where Vou_type='PURCHASE' and cast(vou_no as bigint) =" & GMod.ds.Tables("sql2").Rows(i)("Vou_no").ToString _
            '             & " and Group_name='PARTY'"
            '    GMod.DataSetRet(sqlexp, "party")
            '    If GMod.ds.Tables("party").Rows.Count > 0 Then
            '        dgPurchase(7, r).Value = GMod.ds.Tables("party").Rows(0)("cramt")
            '    End If
            '    'Next Line
            '    r = r + 1
            '    dgPurchase.Rows.Add()
            '    dgPurchase(0, r).Value = arr(3)
            '    dgPurchase(1, r).Value = GMod.ds.Tables("sql1").Rows(c)("addr")
            '    dgPurchase(2, r).Value = GMod.ds.Tables("sql1").Rows(c)("rm")
            '    'r = r + 1

            '    'dgPurchase.Rows.Add()
            '    'dgPurchase(3, r-1).Value = GMod.ds.Tables("sql2").Rows(i + 1)("Acc_head")
            '    'dgPurchase(4, r-1).Value = GMod.ds.Tables("sql2").Rows(i + 1)("dramt")
            '    'i = i + 1
            '    r = r + 1
            '    ' i = i + 2
            'End If

        Next
        'Catch ex As Exception
        'dgPurchase.Rows.Clear()
        'MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub frmPurchase_Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgPurchase.Height = Me.Height - 100
    End Sub
    Dim sw As StreamWriter
    Dim pageno As Integer = 0
    Sub header()
        pageno = pageno + 1
        Dim i As Integer
        sw.WriteLine("")
        Dim s As String
        For i = 0 To 48
            s = s + " "
        Next
        s = s + GMod.Cmpname.ToUpper
        sw.WriteLine(s)
        s = ""
        For i = 0 To 50
            s = s + " "
        Next
        s = s + "PURCHASE REGISTER"
        sw.WriteLine(s)
        s = "     PURCHASE FROM: " & txtCrNoFrom.Text & "  TO  " & txtCrNoTo.Text
        For i = 0 To 85
            s = s + " "
        Next
        s = s + "Page No: " & pageno
        sw.WriteLine(s)
        s = ""
        sw.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------")
        s = ""
        Dim str, str1 As String
        sw.WriteLine("    BILL NO        PARTY NAME AND ADDRESS       PUR. NO.    PRODUCT NAME                    TOTAL        FREIGHT    VAT/CST     PARTY")
        sw.WriteLine("    DATE                                        TIN NO.                                     AMOUNT       AMOUNT      AMOUNT     AMOUNT")
        s = ""
        sw.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------")
    End Sub

    Private Sub btndosprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndosprint.Click
        pageno = 0
        Dim totalamt As Double
        Dim I As Integer, rec As String, j As Integer, len As Integer, blnspc As String = " "
        Dim lineno As Integer = 0
        sw = File.CreateText("c:\\pur_reg.txt")
        header()
        For I = 0 To dgPurchase.Rows.Count - 1
            totalamt = totalamt + dgPurchase(4, I).Value
            rec = "   " & dgPurchase(0, I).Value

            len = rec.Length
            While rec.Length < 15
                rec = rec & " "
            End While
            rec = rec & dgPurchase(1, I).Value

            len = rec.Length
            While rec.Length < 48
                rec = rec & " "
            End While

            rec = rec & dgPurchase(2, I).Value

            len = rec.Length
            While rec.Length < 60
                rec = rec & " "
            End While
            rec = rec & dgPurchase(3, I).Value

            len = rec.Length 'Party Amount
            While rec.Length < 90
                rec = rec & " "
            End While
            If Val(dgPurchase(4, I).Value) > 0 Then
                rec = rec & dgPurchase(4, I).Value.ToString.PadLeft(10, " ")
            Else
                rec = rec & blnspc.PadLeft(10, " ")
            End If
            len = rec.Length ' Frieght Amount
            While rec.Length < 101
                rec = rec & " "
            End While
            If Val(dgPurchase(5, I).Value) > 0 Then
                rec = rec & dgPurchase(5, I).Value.ToString.PadLeft(10, " ")
            Else
                rec = rec & blnspc.PadLeft(10, " ")
            End If

            len = rec.Length ' VAT/CST Amount
            While rec.Length < 115
                rec = rec & " "
            End While
            If Val(dgPurchase(6, I).Value) > 0 Then
                rec = rec & dgPurchase(6, I).Value.ToString.PadLeft(10, " ")
            Else
                rec = rec & blnspc.PadLeft(10, " ")
            End If

            len = rec.Length ' Total Amount
            While rec.Length < 122
                rec = rec & " "
            End While
            If Val(dgPurchase(7, I).Value) > 0 Then
                rec = rec & dgPurchase(7, I).Value.ToString.PadLeft(9, " ")
            Else
                rec = rec & blnspc.PadLeft(9, " ")
            End If
            sw.WriteLine(rec)
            lineno = lineno + 1
            If I < dgPurchase.Rows.Count - 1 Then
                If Val(dgPurchase(7, I + 1).Value) > 0 Then
                    sw.WriteLine("")
                End If
            End If
            If lineno > 37 Then
                sw.WriteLine(Convert.ToChar(12).ToString)
                header()
                'pageno = pageno + 1
                lineno = 0
            End If
            rec = ""
        Next
        Dim s As String
        For I = 0 To 60
            s = s + " "
        Next
        sw.Write(s & "TOTAL PURCHASE IN AMOUNT Rs " & Format(totalamt, "0.00").PadLeft(9, " "))
        'sw.Close()
        'Dim p As New Process
        'p.StartInfo.FileName = "purchase.bat"
        'p.Start()

        sw.Close()
        Dim p As New Process
        p.StartInfo.FileName = "printfile.bat"
        p.StartInfo.Arguments = "c:\pur_reg.txt"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.Start()
        p.Close()
    End Sub
End Class