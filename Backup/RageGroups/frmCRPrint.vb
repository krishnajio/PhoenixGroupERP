Imports System.IO
Public Class frmCRPrint

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub txtfrom_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfrom.Leave
        If txtfrom.Text = "" Then
            MsgBox("CR Voucher No can't be blank")
            txtfrom.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtto.Leave
        If txtto.Text = "" Then
            MsgBox("CR Voucher No can't be blank")
            txtfrom.Focus()
            Exit Sub
        End If
    End Sub

    Public Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Try
            Dim sqlshow As String, i As Integer
            If _CASHCOUNTER = 0 Then
                sqlshow = "select Vou_no,convert(varchar(20),Vou_date,105) Vou_date,Acc_head_code ,Acc_head,Narration,cramt  from " & GMod.VENTRY _
                & " where vou_type='CR VOUCHER' " _
                & " and vou_no>=" & Val(txtfrom.Text) & " and vou_no<=" & Val(txtto.Text) & "  and uname<>'CASHCOUNTER'  order by cast(vou_no as numeric(18,0)) "
            Else
                sqlshow = "select Vou_no,convert(varchar(20),Vou_date,105) Vou_date ,Acc_head_code ,Acc_head,Narration,cramt  from " & GMod.VENTRY _
                & " where vou_type='CR VOUCHER' " _
                & " and vou_no>=" & Val(txtfrom.Text) & " and vou_no<=" & Val(txtto.Text) & "  and uname='CASHCOUNTER'  order by cast(vou_no as numeric(18,0)) "
            End If
            GMod.DataSetRet(sqlshow, "CRData")
            dgCRDebit.Rows.Clear()
            'dgCRDebit.DataSource = GMod.ds.Tables("CRData")
            For i = 0 To GMod.ds.Tables("CRData").Rows.Count - 1
                dgCRDebit.Rows.Add()
                dgCRDebit(0, i).Value = GMod.ds.Tables("CRData").Rows(i)("Vou_no")
                dgCRDebit(1, i).Value = GMod.ds.Tables("CRData").Rows(i)("Vou_date")
                dgCRDebit(2, i).Value = GMod.ds.Tables("CRData").Rows(i)("Acc_head_code")
                dgCRDebit(3, i).Value = GMod.ds.Tables("CRData").Rows(i)("Acc_head")
                dgCRDebit(4, i).Value = GMod.ds.Tables("CRData").Rows(i)("Narration")
                dgCRDebit(5, i).Value = GMod.ds.Tables("CRData").Rows(i)("cramt")
                'lblamount.Text = Val(lblamount.Text) + Val(dgCRDebit(5, i).Value)

            Next
            'lblamount.Text = Val(lblamount.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim sw As StreamWriter, rec As String, brk As Integer

    Public Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        brk = 0
        Try
            sw = File.CreateText("c:\\final.txt")
            Dim z As Integer
            Dim rec As String
            Dim narr() As String
            Dim pgno As Integer = 1
            For z = 0 To dgCRDebit.Rows.Count - 1

                If GMod.username.ToUpper = "CASHCOUNTER" Then
                    sw.WriteLine(Convert.ToChar(27).ToString & Convert.ToChar(67).ToString & Convert.ToChar(36).ToString)
                End If

                'Else
                sw.WriteLine("")
                'End If
                sw.WriteLine("          " & Convert.ToChar(14).ToString & GMod.Cmpname.ToUpper)
                sw.WriteLine("")
                If brk = 0 Then
                    sw.WriteLine("")
                End If
                If pgno > 1 Then
                    sw.WriteLine("")
                End If
                'Voucher No 
                rec = "                                                                      " & dgCRDebit(0, z).Value
                sw.WriteLine(rec)
                sw.WriteLine("")
                'dtPrint.Value = CDate(dgCRDebit(1, z).Value.ToString)
                rec = "                                                                      " & dgCRDebit(1, z).Value.ToString.ToUpper
                sw.WriteLine(rec)
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                'sw.WriteLine("")
                'sw.WriteLine("")

                rec = "                   " + dgCRDebit(2, z).Value 'Customer Code
                sw.WriteLine(rec)
                sw.WriteLine("")
                rec = "                   " + dgCRDebit(3, z).Value ' Customer Head
                sw.WriteLine(rec)

                'Spllilting narratiomn
                narr = dgCRDebit(4, z).Value.ToString.Split("#")
                'MsgBox(narr.Length)
                'TR No and Date
                rec = "                    " & narr(1)
                sw.WriteLine("")
                rec = rec + "                               " & narr(2)
                sw.WriteLine(rec)


                ' Mode Of Payment and deposired by
                If narr(3).ToString.ToUpper.Trim() = "CASH" Then
                    rec = "                    CASH                                " & narr(3)
                Else
                    rec = "                    CHEQUE                              " & narr(3)
                End If
                sw.WriteLine("")
                sw.WriteLine("")
                'If narr.Length >  Then
                '    rec = rec + "                               " & narr(4)
                '    sw.WriteLine(rec)
                '    sw.WriteLine("")
                'Else
                'rec = rec & "                              AREA INCH.-" & dgCRDebit(2, z).Value.ToString.Substring(0, 2)
                sw.WriteLine(rec)
                sw.WriteLine("")
                sw.WriteLine("")
                'End If
                'For Amount
                If narr(4).ToString.ToUpper = "" Then
                    rec = "                    " & "CHICKS OR FEED                        AREA INCH.-" & dgCRDebit(2, z).Value.ToString.Substring(0, 2)
                Else
                    rec = "                    " & "CHICKS OR FEED                      " & narr(4).ToUpper
                End If

                sw.WriteLine(rec)
                sw.WriteLine("")
                rec = ""
                rec = "                                                         " & dgCRDebit(5, z).Value
                sw.WriteLine(rec)
                sw.WriteLine("")
                sw.WriteLine("")
                rec = "                    " & splitNumber(dgCRDebit(5, z).Value)
                sw.WriteLine(rec)

                'For Next 
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("")
                'sw.WriteLine("")
                'sw.WriteLine("")
                pgno = pgno + 1
                If GMod.username.ToUpper <> "CASHCOUNTER" Then
                    If pgno > 2 Then
                        sw.WriteLine("")
                        sw.WriteLine(Convert.ToChar(12).ToString)
                        pgno = 1
                        brk = 1
                    End If
                End If
                If GMod.username.ToUpper = "CASHCOUNTER" Then
                    cashcount = cashcount + 1
                    ' MsgBox(cashcount)
                    If cashcount = 2 Then
                        'sw.WriteLine(Convert.ToChar(12).ToString)
                        cashcount = 0
                    End If
                End If

                If pgno = 2 Then
                    sw.WriteLine("")
                    sw.WriteLine("")
                    If brk = 1 Then
                        sw.WriteLine("")
                    End If
                    'sw.WriteLine("")
                End If
            Next
            'sw.Close()
            'Dim p As New Process
            'p.StartInfo.FileName = "final.bat"
            'p.Start()

            sw.Close()
            Dim p As New Process
            p.StartInfo.FileName = "printfile.bat"
            p.StartInfo.Arguments = "c:\final.txt"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()
            p.Close()
        Catch EX As Exception
            MsgBox(EX.Message)
            sw.Close()
        End Try
        Me.Close()
    End Sub
    Function splitNumber(ByVal number As String) As String
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
            splitNumber = CLS.NUMMM(st(0)) & " Only "
        Else
            splitNumber = CLS.NUMMM(st(0)) & " and " & CLS.NUMMM(st(1)) & " Paise Only "
        End If
    End Function

    Private Sub btnclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub frmCRPrint_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _CASHCOUNTER = 0
    End Sub

    Private Sub frmCRPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            _CASHCOUNTER = 1
        End If
    End Sub

    Private Sub txtfrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfrom.TextChanged
        txtto.Text = txtfrom.Text
    End Sub
End Class