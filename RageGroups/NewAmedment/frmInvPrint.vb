Public Class frmInvPrint
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        '        OTHER SALE CASH RP(G
        'OTHER SALE CASH(GST)
        '        OTHER SALE(GST)
        '        SALE CR(GST)
        '        SALE HAJIPUR(GST)
        '        SALE JBP(GST)
        '        SALE LR(GST)
        '        SALE RAIPUR(GST)
        '        SALE VARANASI(GST)
        '        SALE WB - 1(GST)
        '        SALE WBH - 1(GST)
        If GMod.Cmpid = "PHOE" Then
            sql = "select Vou_type, cast(vou_no as bigint) Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, tcs_per as  DiscountRate, tcs_amt as DiscountAmount,  tds_per as  NeccRate, tds_amt as Amount, NeccAmount, FreePer, FreeQty, HatchDate, BillNo, BillDate, Session, type, PrdUnit, Mortality, a.account_type as authr from PrintData p," & GMod.ACC_HEAD & " a where  a.account_code = p.acccode and cast(vou_no as bigint)  between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "' and p.cmp_id ='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' and vou_type ='" & voutype.Text & "' and type ='P'  order by cast(vou_no as bigint)"
        Else
            If voutype.Text = "SALE BR(GST)" Or voutype.Text = "SALE CR(GST)" Then
                sql = "select Vou_type, cast(vou_no as bigint) Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, isnull(tcs_per,0) as  DiscountRate,  isnull(tcs_amt,0) as  DiscountAmount  , tds_per as  NeccRate,  isnull(tds_amt,0) as NeccAmount, FreePer, FreeQty, HatchDate, BillNo, BillDate, Session, type, PrdUnit, Mortality, a.account_type as authr from PrintData p," & GMod.ACC_HEAD & " a where  a.account_code = p.acccode and cast(vou_no as bigint)  between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "' and p.cmp_id ='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' and vou_type ='" & voutype.Text & "' and type ='P' and left(acccode,2)='" & txtAreacode.Text & "' order by cast(vou_no as bigint)"
            Else
                sql = "select Vou_type, cast(vou_no as bigint) Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, isnull(tcs_per,0) as  DiscountRate,  isnull(tcs_amt,0) as  DiscountAmount , isnull(tcs_amt,0) tcs_amt, NeccRate, NeccAmount, FreePer, FreeQty, HatchDate, BillNo, BillDate, Session, type, PrdUnit, Mortality, a.account_type as authr from PrintData p," & GMod.ACC_HEAD & " a where  a.account_code = p.acccode and cast(vou_no as bigint)  between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "' and p.cmp_id ='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' and vou_type ='" & voutype.Text & "' and type ='P' AND PRDUNIT ='" & ComboBox1.Text & "' and left(acccode,2)='" & txtAreacode.Text & "' order by cast(vou_no as bigint)"
            End If
        End If
        GMod.DataSetRet(sql, "prntinvleser")
        Dim crobjprnt
        Dim gstno As String = ""
        Dim adrs As String = ""
        If GMod.Cmpid = "PHOE" Then
            Dim crobjpp As New CrPrintInvLaserPPall
            If voutype.Text = "SALE JBP(GST)" Or voutype.Text = "SALE HATCHING EGGS" Then
                gstno = "GSTIN(M.P)  :  23AAJFP5811H1ZD"
            End If
            If voutype.Text = "SALE RAIPUR(GST)" Then
                gstno = "GSTIN(C.G)  :  22AAJFP5811H1ZF"
            End If
            If voutype.Text = "SALE HAJIPUR(GST)" Or voutype.Text = "SALE VARANASI(GST)" Then
                gstno = "GSTIN(U.P)  :  10AAJFP5811H1ZK"
            End If
            If voutype.Text = "SALE WB-1(GST)" Or voutype.Text = "SALE WB-2(GST)" Then
                gstno = "GSTIN(W.B)  :  19AAJFP5811H1Z2"
            End If

            crobjpp.SetDataSource(GMod.ds.Tables("prntinvleser"))
            crobjpp.SetParameterValue("gstno", gstno)
            CrystalReportViewer1.ReportSource = crobjpp
        Else

            If voutype.Text = "SALE BR(GST)" Or voutype.Text = "SALE CR(GST)" Or voutype.Text = "SALE WBH-1(GST)" Or voutype.Text = "SALE HAJIPUR(GST)" Or voutype.Text = "SALE RAIPUR(GST)" Or voutype.Text = "SALE VARANASI(GST)" Or voutype.Text = "SALE CR RAIPUR(GST)" Or voutype.Text = "SALE CR JBP(GST)" Or voutype.Text = "SALE HAZARIBAGH(GST)" Or voutype.Text = "SALE PURNIA" Or voutype.Text = "SALE ARRAH(GST)" Then
                If ComboBox1.Text = "WB-1" Or ComboBox1.Text = "WB-2" Then
                    gstno = "GSTIN(W.B)  :  19ADDPD8524C1ZV"
                    adrs = "201/15, Ratan Colony, PB.-75 Gorakhpur,JABALPUR-482001"
                End If
                If ComboBox1.Text = "PARIYAT UNIT" Or ComboBox1.Text = "HAZARIBAGH UNIT" Or ComboBox1.Text = "PURNIA UNIT" Or ComboBox1.Text = "ARRAH UNIT" Then
                    gstno = "GSTIN(M.P)  :  23ADDPD8524C1Z6"
                    adrs = "201/15, Ratan Colony, PB.-75 Gorakhpur,JABALPUR-482001"
                End If
                If ComboBox1.Text = "RAIPUR UNIT" Then
                    gstno = "GSTIN(C.G)  :  22ADDPD8524C1Z8"
                    adrs = "Q3.Sector-2,Near Vidhya Niketan School,Avantivihar Raipur(G.C)"
                End If
                If ComboBox1.Text = "VARANASI UNIT" Then
                    gstno = "GSTIN(U.P)  :  09ADDPD8524C1ZW"
                    adrs = "201/15, Ratan Colony, PB.-75 Gorakhpur,JABALPUR-482001"
                End If
                crobjprnt = New CrPrintInvLaserHat
                crobjprnt.SetDataSource(GMod.ds.Tables("prntinvleser"))
                crobjprnt.SetParameterValue("gstno", gstno)
                crobjprnt.SetParameterValue("adrs", adrs)
                CrystalReportViewer1.ReportSource = crobjprnt
            End If
        End If
        ' SALE HAJIPUR(GST)
        'SALE LR JBP(GST)
        'SALE LR RAIPUR(GST)
        If voutype.Text.Contains("LR") Then
            If voutype.Text = "SALE LR JBP(GST)" Then
                If ComboBox1.Text = "PARIYAT UNIT" Then
                    gstno = "GSTIN(M.P)  :  23ADDPD8524C1Z6"
                    adrs = "201/15, Ratan Colony, PB.-75 Gorakhpur,JABALPUR-482001"
                End If
            End If

            If voutype.Text = "SALE LR(GST)" Then
                If ComboBox1.Text = "PARIYAT UNIT" Then
                    gstno = "GSTIN(M.P)  :  23ADDPD8524C1Z6"
                    adrs = "201/15, Ratan Colony, PB.-75 Gorakhpur,JABALPUR-482001"
                End If
            End If
            If voutype.Text = "SALE LR RAIPUR(GST)" Then
                If ComboBox1.Text = "RAIPUR UNIT" Then
                    gstno = "GSTIN(C.G)  :  22ADDPD8524C1Z8"
                    adrs = "Q3.Sector-2,Near Vidhya Niketan School,Avantivihar Raipur(G.C)"
                End If
            End If
            If voutype.Text = "SALE HAJIPUR(GST)" Then
                If ComboBox1.Text = "RAIPUR UNIT" Then
                    gstno = "GSTIN(C.G)  :  22ADDPD8524C1Z8"
                    adrs = "Q3.Sector-2,Near Vidhya Niketan School,Avantivihar Raipur(G.C)"
                End If
            End If
            If ComboBox1.Text = "VARANASI UNIT" Then
                gstno = "GSTIN(U.P)  :  09ADDPD8524C1ZW"
                adrs = "201/15, Ratan Colony, PB.-75 Gorakhpur,JABALPUR-482001"
            End If
            crobjprnt = New CrPrintInvLaserHatLR
            crobjprnt.SetDataSource(GMod.ds.Tables("prntinvleser"))
            crobjprnt.SetParameterValue("gstno", gstno)
            crobjprnt.SetParameterValue("adrs", adrs)
            CrystalReportViewer1.ReportSource = crobjprnt
        End If

    End Sub

    Private Sub frmInvPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " [" & GMod.Cmpname & "]"

        'If GMod.Cmpid = "PHHA" Then
        '    voutype.Text = "SALE"
        'Else
        GMod.SqlExecuteNonQuery("update " & GMod.ACC_HEAD & " set address ='-' where len(address) = 0   and group_name ='CUSTOMER'")
        GMod.SqlExecuteNonQuery("update " & GMod.ACC_HEAD & " set city ='-' where len(city) = 0  and group_name ='CUSTOMER'")
        GMod.SqlExecuteNonQuery("update " & GMod.ACC_HEAD & " set state ='-' where len(state) = 0  and group_name ='CUSTOMER'")

        GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%SALE%' and vtype not like '%JOURNAL%' and session ='" & GMod.Session & "'", "vou_typeP")
        voutype.DataSource = GMod.ds.Tables("vou_typeP")
        voutype.DisplayMember = "vtype"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '        OTHER SALE CASH RP(G
        'OTHER SALE CASH(GST)
        '        OTHER SALE(GST)
        '        SALE CR(GST)
        '        SALE HAJIPUR(GST)
        '        SALE JBP(GST)
        '        SALE LR(GST)
        '        SALE RAIPUR(GST)
        '        SALE VARANASI(GST)
        '        SALE WB - 1(GST)
        '        SALE WBH - 1(GST)
        If GMod.Cmpid = "PHOE" Then
            sql = "select Vou_type, cast(vou_no as bigint) Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, tcs_per as  DiscountRate,tcs_amt as  DiscountAmount , NeccRate, NeccAmount, FreePer, FreeQty, HatchDate, BillNo, BillDate, Session, type, PrdUnit, Mortality, a.account_type as authr from PrintData p," & GMod.ACC_HEAD & " a where  a.account_code = p.acccode and cast(vou_no as bigint)  between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "' and p.cmp_id ='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' and vou_type ='" & voutype.Text & "' and type ='P'  order by cast(vou_no as bigint)"
        Else
            If voutype.Text = "SALE BR(GST)" Or voutype.Text = "SALE CR(GST)" Then
                sql = "select Vou_type, cast(vou_no as bigint) Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, isnull(tcs_per,0) as  DiscountRate, isnull(tcs_amt,0) as  DiscountAmount , NeccRate, NeccAmount, FreePer, FreeQty, HatchDate, BillNo, BillDate, Session, type, PrdUnit, Mortality, a.account_type as authr from PrintData p," & GMod.ACC_HEAD & " a where  a.account_code = p.acccode and Hatchdate  between '" & dtHatchdate.Value.ToShortDateString & "' and '" & dtphachdateTo.Value.ToShortDateString & "' and p.cmp_id ='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' and vou_type ='" & voutype.Text & "' and type ='P'  and  p.acccode='" & txtCustCode.Text & "'  order by cast(vou_no as bigint)"
            Else
                sql = "select Vou_type, cast(vou_no as bigint) Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, isnull(tcs_per,0) as  DiscountRate, isnull(tcs_amt,0) as  DiscountAmount, NeccRate, NeccAmount, FreePer, FreeQty, HatchDate, BillNo, BillDate, Session, type, PrdUnit, Mortality, a.account_type as authr from PrintData p," & GMod.ACC_HEAD & " a where  a.account_code = p.acccode and a.account_code = p.acccode and Hatchdate  between '" & dtHatchdate.Value.ToShortDateString & "' and '" & dtphachdateTo.Value.ToShortDateString & "' and p.cmp_id ='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' and vou_type ='" & voutype.Text & "' and type ='P' AND PRDUNIT ='" & ComboBox1.Text & "'  and  p.acccode='" & txtCustCode.Text & "'  order by cast(vou_no as bigint)"

            End If
        End If
        GMod.DataSetRet(sql, "prntinvleser")
        Dim crobjprnt
        Dim gstno As String = ""
        If GMod.Cmpid = "PHOE" Then
            Dim crobjpp As New CrPrintInvLaserPPall
            If voutype.Text = "SALE JBP(GST)" Then
                gstno = "GSTIN(M.P)  :  23AAJFP5811H1ZD"
            End If
            If voutype.Text = "SALE RAIPUR(GST)" Then
                gstno = "GSTIN(C.G)  :  22AAJFP5811H1ZF"
            End If
            If voutype.Text = "SALE HAJIPUR(GST)" Or voutype.Text = "SALE VARANASI(GST)" Then
                gstno = "GSTIN(U.P)  :  10AAJFP5811H1ZK"
            End If
            If voutype.Text = "SALE WB-1(GST)" Or voutype.Text = "SALE WB-2(GST)" Then
                gstno = "GSTIN(W.B)  :  19AAJFP5811H1Z2"
            End If

            crobjpp.SetDataSource(GMod.ds.Tables("prntinvleser"))
            crobjpp.SetParameterValue("gstno", gstno)
            CrystalReportViewer1.ReportSource = crobjpp
        Else
            If voutype.Text = "SALE BR(GST)" Or voutype.Text = "SALE CR(GST)" Or voutype.Text = "SALE WBH-1(GST)" Or voutype.Text = "SALE HAJIPUR(GST)" Or voutype.Text = "SALE RAIPUR(GST)" Or voutype.Text = "SALE VARANASI(GST)" Or voutype.Text = "SALE HAZARIBAGH(GST)" Or voutype.Text = "SALE PURNIA" Then
                If ComboBox1.Text = "WB-1" Or ComboBox1.Text = "WB-2" Then
                    gstno = "GSTIN(W.B)  :  19ADDPD8524C1ZV"
                End If
                If ComboBox1.Text = "PARIYAT UNIT" Or ComboBox1.Text = "HAJIPUR UNIT" Or ComboBox1.Text = "PURNIA UNIT" Or ComboBox1.Text = "HAZARIBAGH UNIT" Then
                    gstno = "GSTIN(M.P)  :  23ADDPD8524C1Z6"
                End If
                If ComboBox1.Text = "RAIPUR UNIT" Then
                    gstno = "GSTIN(C.G)  :  22ADDPD8524C1Z8"
                End If
                If ComboBox1.Text = "VARANASI UNIT" Then
                    gstno = "GSTIN(U.P)  :  09ADDPD8524C1ZW"
                End If
                crobjprnt = New CrPrintInvLaserHat
            End If
            If voutype.Text = "SALE LR(GST)" Then
                If ComboBox1.Text = "PARIYAT UNIT" Then
                    gstno = "GSTIN(M.P)  :  23ADDPD8524C1Z6"
                End If
                If ComboBox1.Text = "RAIPUR UNIT" Then
                    gstno = "GSTIN(C.G)  :  22ADDPD8524C1Z8"
                End If
                If ComboBox1.Text = "RAIPUR UNIT" Then
                    gstno = "GSTIN(C.G)  :  22ADDPD8524C1Z8"
                End If

                If ComboBox1.Text = "VARANASI UNIT" Then
                    gstno = "GSTIN(U.P)  :  09ADDPD8524C1ZW"
                End If

                crobjprnt = New CrPrintInvLaserHatLR
            End If
            crobjprnt.SetDataSource(GMod.ds.Tables("prntinvleser"))
            crobjprnt.SetParameterValue("gstno", gstno)
            CrystalReportViewer1.ReportSource = crobjprnt
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class