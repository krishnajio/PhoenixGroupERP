Public Class frmVoucherPrintAll
    Dim sql As String
    Private Sub frmVoucherPrintAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "'  and session = '" & GMod.Session & "' and vtype not in ('SALARY EXPS','SALARY JOURNAL','BANK SAL TRANSFER','BANK TRANS')"
        GMod.DataSetRet(Sql, "CRVT")
        cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
        cmbvoutype.DisplayMember = "vtype"
    End Sub

    Private Sub cmbvoutype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvoutype.SelectedIndexChanged
        sql = "select distinct  cast(vou_no as numeric(18,0)) vou_no  from " & GMod.VENTRY & " where vou_type='" & cmbvoutype.Text & "' order by cast(vou_no as numeric(18,0))"
        GMod.DataSetRet(sql, "Vno")
        ComboBox1.DataSource = GMod.ds.Tables("Vno")
        ComboBox1.DisplayMember = "vou_no"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            'sql = "SELECT * FROM " & GMod.VENTRY & " where vou_type = '" & cmbvoutype.Text & "' and cast(vou_no as bigint) between '" & TextBox1.Text & "' and '" & TextBox2.Text & "' order by cast(vou_no as numeric(18,0)),dramt desc"
            sql = "select   Vou_no, Vou_type, convert(varchar,Vou_date,103) Vou_date ,account_code Acc_head_code, account_head_name Acc_head, " _
             & " Narration, dramt, cramt,  a.Group_name,pay_mode from " _
             & GMod.VENTRY & " v inner join " & GMod.ACC_HEAD & " a on v.Acc_head_code = a.account_code " _
              & " where vou_type='" & cmbvoutype.Text & "' and  " _
              & " cast(vou_no as numeric(18,0))  between " & TextBox1.Text & " and " & TextBox1.Text & "   order by cast(vou_no as numeric(18,0)),dramt desc"

            GMod.DataSetRet(sql, "vp")



            sql = "SELECT sum(dramt) FROM " & GMod.VENTRY & " where vou_type = '" & cmbvoutype.Text & "' and vou_no ='" & TextBox1.Text & "'"
            GMod.DataSetRet(sql, "sumdr")


            Dim r As New CrVprintAll
            r.SetDataSource(ds.Tables("vp"))
            'r.Subreports("bill_det").SetDataSource(GMod.ds.Tables("bill_detials"))
            r.SetParameterValue("p1", "")
            r.SetParameterValue("cmpid", "" & GMod.Cmpname & "")

            r.SetParameterValue("vtype", cmbvoutype.Text.ToUpper & " VOUCHER")
            r.SetParameterValue("ntow", NumberInWords(Val(GMod.ds.Tables("sumdr").Rows(0)(0))))
            CrystalReportViewer1.ReportSource = r
        Catch

        End Try
    End Sub
    Dim sp(3) As String
    Function splitNumber(ByVal number As String) As String
        'Dim num() As String
        'Dim retval As String
        'num = number.Split(".")
        'If num(1) = "00" Then
        '    retval = NameOfNumber(num(0), True, 9999)
        'Else
        '    retval = NameOfNumber(number, True, 9999)
        '    retval &= NameOfNumber(num(1), True, 9999) & "paise"
        'End If
        'splitNumber = retval


        'Dim num() As String
        'Dim retval As String
        'num = number.Split(".")
        'If num(1) = "00" Then
        '    retval = NameOfNumber(num(0), True, 9999)
        'Else
        '    retval = NameOfNumber(num(0), True, 9999) & "and "
        '    retval &= NameOfNumber(num(1), True, 9999) & "paise"
        'End If
        'splitNumber = retval

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
            splitNumber = CLS.NUMMM(st(0))
        Else
            splitNumber = CLS.NUMMM(st(0)) & " and " & CLS.NUMMM(st(1)) & " Paise"
        End If
    End Function
    Sub spliter(ByVal st As String)
        Try
            Dim word() As String
            word = st.Split(" ")
            sp(0) = ""
            sp(1) = ""
            Dim i As Integer
            For i = 0 To word.Length - 1
                If sp(0).Length < 50 Then
                    sp(0) = sp(0) & word(i) & " "
                Else
                    sp(1) = sp(1) & word(i) & " "
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
    Function NumberInWords(num As String)
        'Constants are Defined
        Dim digit(100) As String
        digit(0) = ""
        digit(1) = "One "
        digit(2) = "Two "
        digit(3) = "Three "
        digit(4) = "Four "
        digit(5) = "Five "
        digit(6) = "Six "
        digit(7) = "Seven "
        digit(8) = "Eight "
        digit(9) = "Nine "
        digit(10) = "Ten "
        digit(11) = "Eleven "
        digit(12) = "Twelve "
        digit(13) = "Thirteen "
        digit(14) = "Fourteen "
        digit(15) = "Fifteen "
        digit(16) = "Sixteen "
        digit(17) = "Seventeen "
        digit(18) = "Eighteen "
        digit(19) = "Ninteen "
        digit(20) = "Twenty "
        digit(30) = "Thirty "
        digit(40) = "Fourty "
        digit(50) = "Fifty "
        digit(60) = "Sixty "
        digit(70) = "Seventy "
        digit(80) = "Eighty "
        digit(90) = "Ninty "
        digit(100) = "Hundred "
        Dim tt(5) As String
        tt(2) = "Thousand "
        tt(3) = "Lakh "
        tt(4) = "Crore "
        tt(5) = "Hundred Crore "
        'Separating the Whole Number and Digits
        Dim nn As String
        Dim dd As String = ""
        nn = Math.Round(Val(num), 2)
        If InStr(nn, ".") <> 0 Then
            dd = Mid(nn, InStr(nn, ".") + 1)
            nn = Mid(nn, 1, InStr(nn, ".") - 1)
        End If

        'Variable nn stores the whole number and dd stores the digits
        'Finding the Word for numbers

        Dim x As Integer
        Dim y As Integer = 0
        x = nn.Length - 1
        Dim z As String
        Dim str As String = ""
        Dim str1 As String = ""
        If x > 1 Then
            While (x > -1)
                'First Loop Last two digits of Number is evaluated(ones and Tens)
                If y = 0 Then
                    z = Mid(nn, x, 2)
                    If Val(z) < 21 And Val(z) > 0 Then
                        str = digit(Val(z))
                    ElseIf Val(z) > 0 Then
                        str = digit(Val(z(0)) * 10)
                        str = str & digit(Val(z(1)))
                    End If
                    x = x - 1
                End If


                'Second Loop 3rd digits of Number is evaluated(Hundred)

                If y = 1 Then
                    z = Mid(nn, x, 1)
                    If Val(z) <> 0 Then
                        str = digit(Val(z)) & "Hundred " & str
                    End If
                    x = x - 2
                End If

                'Subsequent Loop Next two digits sequence of Number is evaluated(Thousands,Lakhs,Crore,etc)


                If y > 1 Then
                    If x <> 0 Then
                        z = Mid(nn, x, 2)
                        If Val(z) < 21 And Val(z) > 0 Then
                            str = digit(Val(z)) & tt(y) & str
                        ElseIf Val(z) > 0 Then
                            str1 = digit(Val(z(0)) * 10)
                            str = str1 & digit(Val(z(1))) & tt(y) & str
                        End If
                        x = x - 2
                    Else
                        z = Mid(nn, 1, 1)
                        If Val(z) < 21 And Val(z) > 0 Then
                            str = digit(Val(z)) & tt(y) & str
                        ElseIf Val(z) > 0 Then
                            str1 = digit(Val(z(0)) * 10)
                            str = str1 & digit(Val(z(1))) & tt(y) & str
                        End If
                        x = -1
                    End If
                End If
                y = y + 1
            End While
        Else
            If Val(nn) < 21 And Val(nn) > 0 Then
                str = digit(Val(nn))
            ElseIf Val(nn) > 0 Then
                str = digit(Val(nn(0)) * 10)
                str = str & digit(Val(nn(1)))
            End If

            'str = digit(nn)

        End If
        If str = "" Then
            str = "Zero "
        End If
        str = str & "Rupees "

        'Digits are evaluated(Paise)

        If Val(dd) > 0 Then
            If dd.Length = 1 Then
                z = Val(dd) * 10
            Else
                z = dd
            End If

            If Val(z) < 21 And Val(z) > 0 Then
                str = str & "and " & digit(Val(z)) & "Paise"
            ElseIf Val(z) > 0 Then
                str1 = digit(Val(z(0)) * 10)
                str = str & "and " & str1 & digit(Val(z(1))) & "Paise"
            End If
        End If

        'Word string is returned

        NumberInWords = str.ToUpper
    End Function


End Class