Public Class frmCustomerMonthlyTrialDR
    Dim sql As String
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        Dim Session As String = cmbSession.Text
        Dim Year As Integer = CInt("20" & Session.Substring(0, 2))
        sql = "exec [SP_FillCustomerMonthlyBalance] '" + cmbSession.Text + "' , '4','" + Year.ToString + "' ,'" + cmbGroup.Text + "'"
        GMod.SqlExecuteNonQuery(sql)

        sql = "SELECT * " & _
            "FROM (" & _
            " SELECT Account_Code, Account_Name, MonthName, Balance " & _
            " FROM CustomerMonthlyBalance " & _
            ") t " & _
            "PIVOT ( " & _
            " SUM(Balance) " & _
            " FOR MonthName IN ([April],[May],[June],[July],[August],[September],[October],[November],[December],[January],[February],[March]) " & _
            ") p " & _
            "ORDER BY Account_Name"

        GMod.DataSetRet(sql, "custdelist")
        DataGridView1.DataSource = GMod.ds.Tables("custdelist")




    End Sub

    Private Sub frmCustomerMonthlyTrialDR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select DISTINCT session from SessionMaster ", "SessionMaster")
        cmbSession.DataSource = GMod.ds.Tables("SessionMaster")
        cmbSession.DisplayMember = "session"

    End Sub
End Class