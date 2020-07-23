Public Class frmMarketRate
    Dim sql As String
    Private Sub frmMarketRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'filling production unit 
        GMod.DataSetRet("select prdunit from prdunit where cmp_id='" & GMod.Cmpid & "'", "prdunit")
        cmbPrdUnit.DataSource = GMod.ds.Tables("prdunit")
        cmbPrdUnit.DisplayMember = "prdunit"

        'filling party
        Sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and Group_name  in ('PARTY','INTERNAL PARTY')"
        GMod.DataSetRet(Sql, "aclist4")
        cmbacheadcode.DataSource = GMod.ds.Tables("aclist4")
        cmbacheadcode.DisplayMember = "account_code"
        cmbacheadname.DataSource = GMod.ds.Tables("aclist4")
        cmbacheadname.DisplayMember = "account_head_name"



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmbacheadcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadcode.Leave
        sql = "select bill_no from purchase_data where session ='" & GMod.Session & "' and party_code ='" & cmbacheadcode.Text & "'"
        GMod.DataSetRet(sql, "billlist4")
        cmbBill.DataSource = GMod.ds.Tables("billlist4")
        cmbBill.DisplayMember = "bill_no"
       

    End Sub

    Private Sub cmbacheadcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadcode.SelectedIndexChanged

    End Sub

    Private Sub cmbBill_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBill.Leave

        If cmbBill.FindStringExact(cmbBill.Text) = -1 Then
            MsgBox("Please Select Correct Bill")
            cmbBill.Focus()
        End If




        sql = "select pono from purchase_data where session ='" & GMod.Session & "' and party_code ='" & cmbacheadcode.Text & "' and bill_no='" & cmbBill.Text & "'"
        GMod.DataSetRet(sql, "polist4")
        cmbPOno.DataSource = GMod.ds.Tables("polist4")
        cmbPOno.DisplayMember = "pono"
    End Sub

    Private Sub cmbBill_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBill.SelectedIndexChanged

    End Sub

    Private Sub cmbPOno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPOno.Leave
        If cmbPOno.FindStringExact(cmbPOno.Text) = -1 Then
            MsgBox("Please Select PO No.")
            cmbPOno.Focus()
        End If

    End Sub

    Private Sub cmbPOno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPOno.SelectedIndexChanged

    End Sub

    Private Sub cmbacheadname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadname.Leave
        If cmbacheadname.FindStringExact(cmbacheadname.Text) = -1 Then
            MsgBox("Please Select Party Name.")
            cmbPOno.Focus()
        End If
    End Sub

    Private Sub cmbacheadname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacheadname.SelectedIndexChanged

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        sql = "update purchase_data set itemname = '" & txtitamnae.Text & "', mkt_rate = '" & TextBox1.Text & "' where session ='" & GMod.Session & "' and party_code ='" & cmbacheadcode.Text & "' and bill_no ='" & cmbBill.Text & "' and  pono= '" & cmbPOno.Text & "'"
        MsgBox(GMod.SqlExecuteNonQuery(sql))

    End Sub
End Class