Public Class FrmRTGSchqPrint
    Dim ivar As Integer
    Dim headfont As Font
    Dim bodyfont As Font
    Dim sp(3) As String
    Dim amountstr As String

    Private Sub chqdocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles chqdocument.PrintPage
        GMod.DataSetRet("select * from chqRTGSlayout", "Rtgschq")
        headfont = New Font("arial", 12, FontStyle.Bold)
        bodyfont = New Font("Arial", 11)
        e.Graphics.DrawString(Dtpchqdate.Text.ToString, bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("chq_datex"), GMod.ds.Tables("Rtgschq").Rows(0)("chq_datey"))
        e.Graphics.DrawString("01980500574", bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("infavx"), GMod.ds.Tables("Rtgschq").Rows(0)("infavy"))
        e.Graphics.DrawString(Val(TxtAmt.Text).ToString, bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("amtx"), GMod.ds.Tables("Rtgschq").Rows(0)("amty"))
        e.Graphics.DrawString(splitNumber(Format("0.00", Val(TxtAmt.Text))).ToString, bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("amtinwx"), GMod.ds.Tables("Rtgschq").Rows(0)("amtinwy"))
        e.Graphics.DrawString("9    4    0    5    3     2    1     1     0     0    0    0    0    0    1", bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("beneAccNox"), GMod.ds.Tables("Rtgschq").Rows(0)("beneAccNoy"))
        e.Graphics.DrawString("Bank Of India".ToString, bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("bankx"), GMod.ds.Tables("Rtgschq").Rows(0)("banky"))
        e.Graphics.DrawString("Narmada Road".ToString, bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("bankbranchx"), GMod.ds.Tables("Rtgschq").Rows(0)("bankbranchy"))
        e.Graphics.DrawString("Jabalpur".ToString, bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("cityx"), GMod.ds.Tables("Rtgschq").Rows(0)("cityy"))
        e.Graphics.DrawString("9    4    0    5    3     2    1     1     0     0    0    0    0    0    1", bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("beneAccNo1x"), GMod.ds.Tables("Rtgschq").Rows(0)("beneAccNo1y"))
        e.Graphics.DrawString("201/15 Ratan Colony Gorakhpur JBP.", bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("beneAddressx"), GMod.ds.Tables("Rtgschq").Rows(0)("beneAddressy"))
        e.Graphics.DrawString(TxtChqNo.Text.ToString, bodyfont, Brushes.Black, GMod.ds.Tables("Rtgschq").Rows(0)("chqx"), GMod.ds.Tables("Rtgschq").Rows(0)("chqy"))
    End Sub
    Function splitNumber(ByVal number As String) As String
        Dim st() As String
        Dim retval As String = ""
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
        Try
            If TxtSrNo.Text = "" Then
                MsgBox("Enter Sr. No.")
                TxtSrNo.Focus()
                Exit Sub
            End If
            chqdocument.DefaultPageSettings = chqsetup.PageSettings
            ' Dim customPaperSize As New Printing.PaperSize("8x10", Val(GMod.ds.Tables("chq").Rows(0)("cqhh")), Val(GMod.ds.Tables("chq").Rows(0)("chqw")))
            chqdocument.Print()

            Dim sql As String = "Insert into RtgsChqEntry(chqdate, chqno, chqAmt, ChqSrNo) values("
            sql += "'" & Dtpchqdate.Value & "',"
            sql += "'" & TxtChqNo.Text & "',"
            sql += "" & Val(TxtAmt.Text) & ","
            sql += "'" & TxtSrNo.Text & "')"
            GMod.SqlExecuteNonQuery(sql)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class