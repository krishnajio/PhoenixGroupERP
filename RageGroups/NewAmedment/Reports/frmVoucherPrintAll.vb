Public Class frmVoucherPrintAll
    Dim sql As String
    Private Sub frmVoucherPrintAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "'  and session = '" & GMod.Session & "'"
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
              & " cast(vou_no as numeric(18,0))  between " & TextBox1.Text & " and " & TextBox2.Text & "   order by cast(vou_no as numeric(18,0)),dramt desc"

            GMod.DataSetRet(sql, "vp")



            sql = "SELECT sum(dramt) FROM " & GMod.VENTRY & " where vou_type = '" & cmbvoutype.Text & "' and vou_no ='" & ComboBox1.Text & "'"
            GMod.DataSetRet(sql, "sumdr")


            Dim r As New CrVprintAll
            r.SetDataSource(ds.Tables("vp"))
            'r.Subreports("bill_det").SetDataSource(GMod.ds.Tables("bill_detials"))
            r.SetParameterValue("p1", "")
            r.SetParameterValue("cmpid", "" & GMod.Cmpname & "")

            r.SetParameterValue("vtype", cmbvoutype.Text.ToUpper & " VOUCHER")
            '   r.SetParameterValue("ntow", splitNumber(GMod.ds.Tables("sumdr").Rows(0)(0)) & " Only.")
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
End Class