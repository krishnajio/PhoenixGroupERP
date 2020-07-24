Public Class frmPartyBankList

    Private Sub frmPartyBankList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from partybanklist"
        GMod.DataSetRet(sql, "partybanklist")

        Dim crpartylisr As New CrpartybankList
        crpartylisr.SetDataSource(GMod.ds.Tables("partybanklist"))
        CrystalReportViewer1.ReportSource = crpartylisr
    End Sub
End Class