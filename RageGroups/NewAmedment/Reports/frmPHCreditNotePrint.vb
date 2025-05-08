Public Class frmPHCreditNotePrint
    Dim Sql As String
    Dim crobjprnt
    Dim gstno As String = ""
    Dim adrs As String = ""
    Dim phone As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Sql = "select Vou_type, cast(vou_no as bigint) Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, isnull(tcs_per,0) as  DiscountRate,  isnull(tcs_amt,0) as  DiscountAmount  , tds_per as  NeccRate,  isnull(tds_amt,0) as NeccAmount, FreePer, FreeQty, HatchDate, BillNo, BillDate, Session, type, PrdUnit, Mortality, a.account_type as authr from PrintData p," & GMod.ACC_HEAD & " a where  a.account_code = p.acccode and cast(vou_no as bigint)  between '" & cmbVouNo.Text & "' and '" & cmbVouNo.Text & "' and p.cmp_id ='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' and vou_type ='CREDIT NOTE' and type ='P'  order by cast(vou_no as bigint)"
        Sql = "select Vou_type, cast(vou_no as bigint) Vou_no, AccCode, AccName, Station, ProductName, Qty, Rate, Amount, isnull(tcs_per,0) as  DiscountRate,  isnull(tcs_amt,0) as  DiscountAmount , isnull(tcs_amt,0) tcs_amt, NeccRate, NeccAmount, FreePer, FreeQty, HatchDate, BillNo, BillDate, Session, type, PrdUnit, Mortality, a.account_type as authr from PrintData p," & GMod.ACC_HEAD & " a where  a.account_code = p.acccode and cast(vou_no as bigint)  between '" & cmbVouNo.Text & "' and '" & cmbVouNo.Text & "' and p.cmp_id ='" & GMod.Cmpid & "' and session ='" & GMod.Session & "' and vou_type ='CREDIT NOTE' and type ='P' order by cast(vou_no as bigint)"


        GMod.DataSetRet(Sql, "prntinvleser")

        If ComboBox1.Text = "WB-1" Or ComboBox1.Text = "WB-2" Then
            gstno = "GSTIN(W.B)  :  19ADDPD8524C1ZV"
            adrs = "201/15, Ratan Colony, PB.-75 Gorakhpur,JABALPUR-482001"
            phone = "Phone :2662155,2661102,2661714 Fax0761-2663964,2665383"
        End If
        If ComboBox1.Text = "PARIYAT UNIT" Or ComboBox1.Text = "HAZARIBAGH UNIT" Or ComboBox1.Text = "PURNIA UNIT" Or ComboBox1.Text = "ARRAH UNIT" Then
            gstno = "GSTIN(M.P)  :  23ADDPD8524C1Z6"
            adrs = "201/15, Ratan Colony, PB.-75 Gorakhpur,JABALPUR-482001"
            phone = "Phone :2662155,2661102,2661714 Fax0761-2663964,2665383"
        End If
        If ComboBox1.Text = "RAIPUR UNIT" Then
            gstno = "GSTIN(C.G)  :  22ADDPD8524C1Z8"
            adrs = "Q3.Sector-2,Near Vidhya Niketan School,Avantivihar Raipur(G.C)"
            phone = "Phone :2662155,2661102,2661714 Fax0761-2663964,2665383"
        End If
        If ComboBox1.Text = "VARANASI UNIT" Then
            gstno = "GSTIN(U.P)  :  09ADDPD8524C1ZW"
            adrs = "201/15, Ratan Colony, PB.-75 Gorakhpur,JABALPUR-482001"
            phone = "Phone :2662155,2661102,2661714 Fax0761-2663964,2665383"
        End If

        If ComboBox1.Text = "PURNIA UNIT" Or ComboBox1.Text = "ARRAH UNIT" Or ComboBox1.Text = "HAJIPUR UNIT" Then
            gstno = "GSTIN(BR)  :  10ADDPD8524C1ZD"
            adrs = "01, JandahaRoad,Bhidupur,Chak Ganagadhar,Vaishali,Bihar-844102"
            phone = "Mob:6386421935,9685043443"
        End If
        crobjprnt = New CrPrintInvLaserHatLR_CRNote
        crobjprnt.SetDataSource(GMod.ds.Tables("prntinvleser"))
        crobjprnt.SetParameterValue("gstno", gstno)
        crobjprnt.SetParameterValue("adrs", adrs)
        'crobjprnt.SetParameterValue("phone", phone)
        CrystalReportViewer1.ReportSource = crobjprnt



    End Sub

    Private Sub frmPHCreditNotePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class