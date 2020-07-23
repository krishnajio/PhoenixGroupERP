Public Class frmInvRCMPrint
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
        sql = "select  itemname as fr_head,pd.*,ach.account_head_name,ach.address, account_type as remark2 from Purchase_Data pd"
        sql &= " left join " & GMod.ACC_HEAD & " ach on pd.party_code= ach.account_code where pd.session='" & GMod.Session & "' and vou_type='" & voutype.Text & "' and pd.cmp_id ='" & GMod.Cmpid & "'" ' and authr<>'-' "
        sql &= " and  cast(vou_no as numeric(18,0)) between " & txtCrNoFrom.Text & " and " & txtCrNoTo.Text & ""

        GMod.DataSetRet(sql, "prntinvleser")
        Dim crobjprnt
        Dim gstno As String = ""
        If voutype.Text = "RCM(PUR)" Then
            Dim crobjpp As New CryInvRCMpp
            If GMod.Cmpid = "PHOE" Then
                gstno = "GSTIN(M.P)  :  23AAJFP5811H1ZD"

                crobjpp.SetDataSource(GMod.ds.Tables("prntinvleser"))
                crobjpp.SetParameterValue("p1", gstno)
                CrystalReportViewer1.ReportSource = crobjpp
            Else
                gstno = "hatch  :  23AAJFP5811H1ZD"

                crobjpp.SetDataSource(GMod.ds.Tables("prntinvleser"))
                crobjpp.SetParameterValue("p1", gstno)
                CrystalReportViewer1.ReportSource = crobjpp
            End If
        ElseIf voutype.Text = "RCM(EXPS)" Then

            Dim crobjpp As New CryInvRCMpp
            If GMod.Cmpid = "PHOE" Then
                gstno = "GSTIN(M.P)  :  23AAJFP5811H1ZD"

                crobjpp.SetDataSource(GMod.ds.Tables("prntinvleser"))
                crobjpp.SetParameterValue("p1", gstno)
                CrystalReportViewer1.ReportSource = crobjpp
            Else
                gstno = "hatch  :  23AAJFP5811H1ZD"

                crobjpp.SetDataSource(GMod.ds.Tables("prntinvleser"))
                crobjpp.SetParameterValue("p1", gstno)
                CrystalReportViewer1.ReportSource = crobjpp
            End If

        Else
            Dim crobjpp As New CrDebitNotePur
            If GMod.Cmpid = "PHOE" Then
                gstno = "GSTIN(M.P)  :  23AAJFP5811H1ZD"

                crobjpp.SetDataSource(GMod.ds.Tables("prntinvleser"))
                crobjpp.SetParameterValue("p1", gstno)
                CrystalReportViewer1.ReportSource = crobjpp
            Else
                gstno = "hatch  :  23AAJFP5811H1ZD"

                crobjpp.SetDataSource(GMod.ds.Tables("prntinvleser"))
                crobjpp.SetParameterValue("p1", gstno)
                CrystalReportViewer1.ReportSource = crobjpp
            End If
        End If
       
    End Sub

    Private Sub frmInvPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " [" & GMod.Cmpname & "]"

        'If GMod.Cmpid = "PHHA" Then
        '    voutype.Text = "SALE"
        'Else
        ' GMod.SqlExecuteNonQuery("update " & GMod.ACC_HEAD & " set address ='-' where len(address) = 0   and group_name ='CUSTOMER'")
        ' GMod.SqlExecuteNonQuery("update " & GMod.ACC_HEAD & " set city ='-' where len(city) = 0  and group_name ='CUSTOMER'")
        'GMod.SqlExecuteNonQuery("update " & GMod.ACC_HEAD & " set state ='-' where len(state) = 0  and group_name ='CUSTOMER'")

        'GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype like '%SALE%' and vtype not like '%JOURNAL%'", "vou_typeP")
        'voutype.DataSource = GMod.ds.Tables("vou_typeP")
        'voutype.DisplayMember = "vtype"
    End Sub
End Class