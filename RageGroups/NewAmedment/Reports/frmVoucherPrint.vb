Imports System.IO
Imports CrystalDecisions.Shared
Imports System.Net
Imports System.Net.Mail

Public Class frmVoucherPrint

    Private Sub frmVoucherPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and Vtype in ('BANK','CASH') and session = '" & GMod.Session & "'"
        GMod.DataSetRet(sql, "CRVT")
        cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
        cmbvoutype.DisplayMember = "vtype"

        fillcombo()
    End Sub
    Dim sql As String
    Sub fillcombo()
        sql = "select distinct vou_no from dummy_ventry where posted='N' and cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "vp_vou_no")
        ComboBox1.DataSource = GMod.ds.Tables("vp_vou_no")
        ComboBox1.DisplayMember = "vou_no"
    End Sub
    Dim rpdet As New CrPartyBillDetials
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            'sql = "select * from vk where vou_type_code='" & cmbvtypecode.Text & "' and vou_no ='" & ComboBox1.Text & "' order by cramt"
            sql = "SELECT * FROM dummy_VENTRY where vou_type = 'Bank' and vou_no ='" & ComboBox1.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' order by entry_id"
            GMod.DataSetRet(sql, "vp")

            'sql = "SELECT * FROM dummy_VENTRY where vou_type = 'Bank' and vou_no=1 and dramt>0"
            sql = "SELECT sum(dramt) dramt FROM dummy_VENTRY where vou_type = 'Bank' and vou_no ='" & ComboBox1.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and dramt>0"
            GMod.DataSetRet(sql, "vpdramt")

            sql = "SELECT * FROM bank_payment where vou_type = 'Bank' and vou_no ='" & ComboBox1.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sql, "bill_detials")

            Try

                sql = "SELECT * FROM chq_issue where vou_type = 'Bank' and vouno ='" & ComboBox1.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and amount>0"
                GMod.DataSetRet(sql, "chqdet")
                If GMod.ds.Tables("chqdet").Rows.Count = 0 Then
                    sql = "SELECT dramt FROM DUMMY_VENTRY where vou_type = 'Bank' and vou_no ='" & ComboBox1.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and GROUP_NAME='BANK'"
                    GMod.DataSetRet(sql, "bankdramt")

                    sql = "update chq_issue set amount ='" & GMod.ds.Tables("bankdramt").Rows(0)(0) & "' where vou_type = 'Bank' and vouno ='" & ComboBox1.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
                    GMod.SqlExecuteNonQuery(sql)
                End If


                sql = "SELECT * FROM chq_issue where vou_type = 'Bank' and vouno ='" & ComboBox1.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and amount>0"
                GMod.DataSetRet(sql, "chqdet")


                GMod.DataSetRet("select * from chqlayout where acc_head_code='" & GMod.ds.Tables("chqdet").Rows(0)("code").ToString.Trim & "' and cmp_id='" & GMod.Cmpid & "'", "chq")
            Catch ex As Exception

            End Try

            'getting party name for bill detials
            sql = "SELECT Acc_head FROM dummy_VENTRY where vou_type = 'Bank' and vou_no ='" & ComboBox1.Text & "' and session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and dramt>0 order by dramt"
            GMod.DataSetRet(sql, "gettingAc_Head")

            If GMod.Cmpid = "LWMI" Then
                Dim r As New CrVprintLNS
                r.SetDataSource(ds.Tables("vp"))
                'r.Subreports("bill_det").SetDataSource(GMod.ds.Tables("bill_detials"))
                r.SetParameterValue("p1", "")
                r.SetParameterValue("cmpid", "" & GMod.Cmpname & "")

                r.SetParameterValue("vtype", cmbvoutype.Text.ToUpper & " VOUCHER")
                r.SetParameterValue("ntow", splitNumber(GMod.ds.Tables("vpdramt").Rows(0)(0)) & " Only.")
                CrystalReportViewer1.ReportSource = r
            ElseIf GMod.Cmpid = "LWSS" Then
                Dim r As New CrVprintLWS
                r.SetDataSource(ds.Tables("vp"))
                'r.Subreports("bill_det").SetDataSource(GMod.ds.Tables("bill_detials"))
                r.SetParameterValue("p1", "")
                r.SetParameterValue("cmpid", "" & GMod.Cmpname & "")

                r.SetParameterValue("vtype", cmbvoutype.Text.ToUpper & " VOUCHER")
                r.SetParameterValue("ntow", splitNumber(GMod.ds.Tables("vpdramt").Rows(0)(0)) & " Only.")
                CrystalReportViewer1.ReportSource = r
            ElseIf GMod.Cmpid = "PHBR" Then
                Dim r As New CrVprintSMTLD
                r.SetDataSource(ds.Tables("vp"))
                'r.Subreports("bill_det").SetDataSource(GMod.ds.Tables("bill_detials"))
                r.SetParameterValue("p1", "")
                r.SetParameterValue("cmpid", "" & GMod.Cmpname & "")

                r.SetParameterValue("vtype", cmbvoutype.Text.ToUpper & " VOUCHER")
                r.SetParameterValue("ntow", splitNumber(GMod.ds.Tables("vpdramt").Rows(0)(0)) & " Only.")
                CrystalReportViewer1.ReportSource = r
            ElseIf GMod.Cmpid = "VIBU" Then
                Dim r As New CrVprintVB
                r.SetDataSource(ds.Tables("vp"))
                'r.Subreports("bill_det").SetDataSource(GMod.ds.Tables("bill_detials"))
                r.SetParameterValue("p1", "")
                r.SetParameterValue("cmpid", "" & GMod.Cmpname & "")

                r.SetParameterValue("vtype", cmbvoutype.Text.ToUpper & " VOUCHER")
                r.SetParameterValue("ntow", splitNumber(GMod.ds.Tables("vpdramt").Rows(0)(0)) & " Only.")
                CrystalReportViewer1.ReportSource = r
            Else
                Dim r As New CrVprint
                r.SetDataSource(ds.Tables("vp"))
                'r.Subreports("bill_det").SetDataSource(GMod.ds.Tables("bill_detials"))
                r.SetParameterValue("p1", "")
                r.SetParameterValue("cmpid", "(" & GMod.Cmpname & ")")

                r.SetParameterValue("vtype", cmbvoutype.Text.ToUpper & " VOUCHER")
                r.SetParameterValue("ntow", splitNumber(GMod.ds.Tables("vpdramt").Rows(0)(0)) & " Only.")
                CrystalReportViewer1.ReportSource = r
            End If
            'r.SetDataSource(ds.Tables("vp"))
            ''r.Subreports("bill_det").SetDataSource(GMod.ds.Tables("bill_detials"))
            'r.SetParameterValue("p1", "")
            'r.SetParameterValue("cmpid", "(" & GMod.Cmpname & ")")

            'r.SetParameterValue("vtype", cmbvoutype.Text.ToUpper & " VOUCHER")
            'r.SetParameterValue("ntow", splitNumber(GMod.ds.Tables("vpdramt").Rows(0)(0)) & " Only.")
            'CrystalReportViewer1.ReportSource = r

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            'for showing party det 
            sql = "select party_code, bill_no, bill_date, amt,  Chq_no, favourof, b.dr_amt as recpitid,b.tds_amt as Uname ," & _
                  " amount, Chq_date, Uname, c.Vouno, c.vou_type, code, c.session,   " & _
                  " a.account_head_name from bank_payment b " & _
                  " left join chq_issue c on b.cmp_id=c.cmp_id and b.session=c.session and b.vou_type=c.vou_type and b.vou_no=c.vouno " & _
                  " left join " & GMod.ACC_HEAD & " a on c.code=a.account_code where c.vou_type='" & cmbvoutype.Text & "' and c.vouno='" & ComboBox1.Text & "'  and b.session='" & GMod.Session & "'"
            GMod.DataSetRet(sql, "partybilldet")
            Dim bankDetials As String = ""
            Dim bankDetials1 As String = ""
            Try
                sql = "select ' Bank Name:- ' + bankName + ', Account:- ' + accNumber + ' ,IFSC:- ' + ifscCode + ' , Branch:- ' + branch  from PArtyBankDetials where partyCode ='" & ds.Tables("partybilldet").Rows(0)("party_code") & "'"
                GMod.DataSetRet(sql, "partybankDetials")

                If ds.Tables("partybilldet").Rows.Count > 0 Then
                    If ds.Tables("partybilldet").Rows.Count > 1 Then
                        bankDetials = ds.Tables("partybankDetials").Rows(0)(0)
                        bankDetials1 = ds.Tables("partybankDetials").Rows(1)(0)
                    Else
                        bankDetials = ds.Tables("partybankDetials").Rows(0)(0)
                        bankDetials1 = ""
                    End If
                Else
                    bankDetials = "-"
                End If
            Catch ex As Exception

            End Try



            rpdet.SetDataSource(ds.Tables("partybilldet"))
            rpdet.SetParameterValue("cmpid", "(" & GMod.Cmpname & ")")
            rpdet.SetParameterValue("p1", GMod.ds.Tables("gettingAc_Head").Rows(0)(0))
            'bankDetials
            rpdet.SetParameterValue("bankDetials", bankDetials)
            rpdet.SetParameterValue("vtype", bankDetials1)
            CrystalReportViewer2.ReportSource = rpdet

            'MailBillDetials()

        Catch ex As Exception

        End Try

    End Sub
    Dim ivar As Integer
    Dim headfont As Font
    Dim bodyfont As Font
    Dim sp(3) As String
    Dim amountstr As String
    Private Sub chqdocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles chqdocument.PrintPage
        dtchequedate.Value = CDate(GMod.ds.Tables("chqdet").Rows(0)("Chq_date"))
        headfont = New Font("arial", 12, FontStyle.Bold)
        bodyfont = New Font("Arial", 11)
        e.Graphics.DrawString(dtchequedate.Text.ToString, bodyfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("chq_datex"), GMod.ds.Tables("chq").Rows(0)("chq_datey"))
        spliter(titlecase(GMod.ds.Tables("chqdet").Rows(0)("favourof").ToString.Trim))
        e.Graphics.DrawString(sp(0), headfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("infavx"), GMod.ds.Tables("chq").Rows(0)("infavy"))
        e.Graphics.DrawString(sp(1), headfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("infavx1"), GMod.ds.Tables("chq").Rows(0)("infavy1"))
        spliter(splitNumber(GMod.ds.Tables("chqdet").Rows(0)("amount").ToString.Trim).Trim & " Only.*****")
        e.Graphics.DrawString(sp(0), bodyfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("amtinwx"), GMod.ds.Tables("chq").Rows(0)("amtinwy"))
        e.Graphics.DrawString(sp(1), bodyfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("amtinwx1"), GMod.ds.Tables("chq").Rows(0)("amtinwy1"))
        e.Graphics.DrawString(GMod.ds.Tables("chqdet").Rows(0)("amount").ToString.PadLeft(12, "*"), headfont, Brushes.Black, GMod.ds.Tables("chq").Rows(0)("amtx"), GMod.ds.Tables("chq").Rows(0)("amty"))
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
    Function titlecase(ByVal str As String) As String
        Dim ar(), st As String
        ar = str.Split(" ")
        Dim i As Integer
        For i = 0 To ar.Length - 1
            st = st & ar(i).Substring(0, 1).ToUpper & (ar(i).Substring(1, ar(i).Length - 1).ToUpper) & " "
        Next
        titlecase = st
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            chqdocument.DefaultPageSettings = chqsetup.PageSettings
            ' Dim customPaperSize As New Printing.PaperSize("8x10", Val(GMod.ds.Tables("chq").Rows(0)("cqhh")), Val(GMod.ds.Tables("chq").Rows(0)("chqw")))
            chqdocument.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' MailBillDetials()
    End Sub

    Public Sub MailBillDetials()
        Try
            System.IO.Directory.CreateDirectory("reports")
        Catch ex As Exception

        End Try
        Try
            'creating pdf
            Dim path As String = ""
            Dim str As String = ComboBox1.Text
            Dim str1 As String = str
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New  _
            DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()


            CrDiskFileDestinationOptions.DiskFileName = System.Environment.CurrentDirectory & "\reports\" & GMod.Session & "\" & str1 & ".pdf"
            path = System.Environment.CurrentDirectory & "\reports\" & GMod.Session & "\" & str1 & ".pdf"
            CrExportOptions = rpdet.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            rpdet.Export()
            ' Dim ii As Integer
            'For ii = 0 To 1000

            '            Next
            ' sendmail(path)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub sendmail(ByVal sid As String)
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient()
        SmtpServer.Credentials = New Net.NetworkCredential("purchase@phoenixsoftwaresolution.com ", "p@12345678#")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True
        mail = New MailMessage()
        Try
            mail.From = New MailAddress("purchase@phoenixgrp.co.in", " PHOENIX GROUP ", System.Text.Encoding.UTF8)
         
            mail.To.Add("purchase@phoenixgrp.co.in")
            mail.Bcc.Add("krishna@phoenixgrp.co.in,naresh@phoenixgrp.co.in")
                mail.Bcc.Add("naresh@phoenixgrp.co.in")
                mail.Subject = sid & " PURCHASE ORDER"
                mail.Body = "Download the attachments. Note: This is a system generated e-mail, please do not reply to it."
            mail.Attachments.Add(New Attachment(sid))
            '-----------------------
       
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                mail.ReplyTo = New MailAddress("purchase@phoenixgrp.co.in")
                SmtpServer.Send(mail)
                mail.Dispose()
                MsgBox("Successfully Sent..")
           
        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try
    End Sub

End Class