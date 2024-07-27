Public Class frmHDFCRtgs
    Dim Sql As String
    Private Sub frmHDFCRtgs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql = "select * from chq_issue where session='" & GMod.Session & "' and Cmp_id='PHOE' and code ='**BABA0136'"
        GMod.DataSetRet(Sql, "rtgsvono")

        cmbvono.DataSource = GMod.ds.Tables("rtgsvono")
        cmbvono.DisplayMember = "vouno"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Sql = "select Chq_no,amount from chq_issue where session='" & GMod.Session & "' and Cmp_id='PHOE'  and vouno='" & cmbvono.Text & "'"
            GMod.DataSetRet(Sql, "rtgschqdata")

            Sql = "select Acc_head_code from dummy_ventry where Vou_no='" & cmbvono.Text & "' and Vou_type='BANK' and cmp_id='PHOE' and session='" & GMod.Session & "'"
            GMod.DataSetRet(Sql, "rtgsventry")

            Sql = "select * from " & GMod.ACC_HEAD & " where account_code='" & GMod.ds.Tables("rtgsventry").Rows(0)("Acc_head_code") & "'"
            GMod.DataSetRet(Sql, "rtgsaccdata")

            Sql = "select * from partyBankDetials where partyCode='" & GMod.ds.Tables("rtgsventry").Rows(0)("Acc_head_code") & "' and Cmp_id = 'PHOE'"
            GMod.DataSetRet(Sql, "pbakdetails")

            Dim r As New CrHDRCRtgs
            r.SetParameterValue("chqno", GMod.ds.Tables("rtgschqdata").Rows(0)("Chq_no"))
            r.SetParameterValue("amt", GMod.ds.Tables("rtgschqdata").Rows(0)("amount"))
            r.SetParameterValue("benifecryName", GMod.ds.Tables("rtgsaccdata").Rows(0)("account_head_name"))
            r.SetParameterValue("address", GMod.ds.Tables("rtgsaccdata").Rows(0)("city"))
            r.SetParameterValue("bankbranch", GMod.ds.Tables("pbakdetails").Rows(0)("bankName"))
            'bankaddress
            r.SetParameterValue("bankaddress", GMod.ds.Tables("pbakdetails").Rows(0)("branch"))
            r.SetParameterValue("ifsc", GMod.ds.Tables("pbakdetails").Rows(0)("ifscCode"))
            r.SetParameterValue("accno", GMod.ds.Tables("pbakdetails").Rows(0)("accNumber"))

            r.SetParameterValue("atow", splitNumber(GMod.ds.Tables("rtgschqdata").Rows(0)("amount")))
            CrystalReportViewer1.ReportSource = r

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

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
        'Dim CLS As New Module2.NewNtoW
        'If num(1) = "00" Then
        '    retval = NameOfNumber(num(0), True, 9999)
        'Else
        '    retval = NameOfNumber(num(0), True, 9999) & "and "
        '    retval &= NameOfNumber(num(1), True, 9999) & "paise"
        'End If
        If st(1).ToString = "00" Then
            splitNumber = CLS.NUMMM(st(0))
        Else
            splitNumber = CLS.NUMMM(Val(st(0))) & " and " & CLS.NUMMM(st(1)) & " Paise"
        End If
    End Function
    Dim sp(3) As String
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
End Class