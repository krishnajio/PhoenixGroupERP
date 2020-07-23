Public Class frmBillDetialsSale

    Dim sql As String
    Private Sub frmBillDetialsSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lblsp.Text = "S" Then

            sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                   & " and group_name in ('CUSTOMER','INTERNAL PARTY','IMPREST') order by account_code"
            GMod.DataSetRet(sql, "acchead")
            cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
            cmbacheadcode.DisplayMember = "account_code"

            cmbacheadname.DataSource = GMod.ds.Tables("acchead")
            cmbacheadname.DisplayMember = "account_head_name"

            Label1.Text = "Sale/Receipt"

        ElseIf lblsp.Text = "P" Then

            sql = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                   & " and group_name in ('PARTY','INTERNAL PARTY','IMPREST') order by account_code"
            GMod.DataSetRet(sql, "acchead")
            cmbacheadcode.DataSource = GMod.ds.Tables("acchead")
            cmbacheadcode.DisplayMember = "account_code"

            cmbacheadname.DataSource = GMod.ds.Tables("acchead")
            cmbacheadname.DisplayMember = "account_head_name"
            Label1.Text = "Purchase/Payment"
        End If
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        cmbacheadname.Enabled = False
        cmbacheadcode.Enabled = False
        If lblsp.Text = "S" Then
            Dim r As New CrInvoice_Receipt
            sql = "select * from Sale_Receipt where session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and acc_code='" & cmbacheadcode.Text & "'"
            GMod.DataSetRet(sql, "Sale_Receipt")
            r.SetDataSource(GMod.ds.Tables("Sale_Receipt"))
            r.SetParameterValue("P1", GMod.Cmpname)
            r.SetParameterValue("P3", "Date From " & dtfrom.Text & " To " & dtto.Text)
            r.SetParameterValue("P2", "A/c Head " & cmbacheadname.Text)
            r.SetParameterValue("P4", "User Name " & GMod.username)
            CrystalReportViewer1.ReportSource = r
        ElseIf lblsp.Text = "P" Then

            Dim r As New CrInvoice_Receipt
            sql = "select * from Purchase_Payment where session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and acc_code='" & cmbacheadcode.Text & "'"
            GMod.DataSetRet(sql, "Sale_Receipt")
            r.SetDataSource(GMod.ds.Tables("Sale_Receipt"))
            r.SetParameterValue("P1", GMod.Cmpname)
            r.SetParameterValue("P3", "Date From " & dtfrom.Text & " To " & dtto.Text)
            r.SetParameterValue("P2", "A/c Head " & cmbacheadname.Text)
            r.SetParameterValue("P4", "User Name " & GMod.username)
            CrystalReportViewer1.ReportSource = r

        End If

    End Sub
End Class