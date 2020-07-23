Public Class frmHatchQty

    Dim Sqlsavestr, Sqlresult As String
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txthatchqty.Text = "" Then
            MsgBox("Item Qty Requierd", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
       
        Sqlsavestr = "Insert into Hatch_Qty( Hatch_date, Hatch_Qty, Entry_date, Session,cmp_id,prd_unit) "
        Sqlsavestr &= " values ("
        Sqlsavestr &= "'" & dtHatchdate.Value.ToShortDateString & "',"
        Sqlsavestr &= "'" & txthatchqty.Text & "',"
        Sqlsavestr &= "'" & Now.ToShortDateString & "',"

        Sqlsavestr &= "'" & GMod.Session & "',"
        Sqlsavestr &= "'" & GMod.Cmpid & "',"
        Sqlsavestr &= "'" & cmbPrdUnit.Text & "')"
        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
         If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate Entry", MsgBoxStyle.Critical)
            Else
                MsgBox("Error :" & Sqlresult, MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Hatch Qty Saved", MsgBoxStyle.Information)

        End If
        dtHatchdate.Focus()
        FillGrid()

        If GMod.Getsession(dtHatchdate.Value) = GMod.Session Then
        Else
            Me.Close()
        End If
    End Sub
    Dim q As String
    Public Sub FillGrid()
        q = "select id,Hatch_date, Hatch_Qty,prd_unit from Hatch_Qty where session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(q, "hqty")
        dgHatchQty.DataSource = GMod.ds.Tables("hqty")
    End Sub
    Private Sub frmHatchQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select prdunit from prdunit where cmp_id='" & GMod.Cmpid & "'", "prdunit")
        cmbPrdUnit.DataSource = GMod.ds.Tables("prdunit")
        cmbPrdUnit.DisplayMember = "prdunit"
        dtHatchdate.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtHatchdate.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString
        FillGrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Label2.Text <> "Label2" Then
            MsgBox(GMod.SqlExecuteNonQuery("delete  from Hatch_Qty where id ='" & Label2.Text & "'"))
            FillGrid()
        End If
    End Sub

    Private Sub dgHatchQty_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgHatchQty.CellContentClick


    End Sub

    Private Sub dgHatchQty_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgHatchQty.CellDoubleClick
        Dim i As Integer
        cmbPrdUnit.Text = dgHatchQty(3, i).Value.ToString
        dtHatchdate.Value = CDate(dgHatchQty(1, i).Value.ToString)
        txthatchqty.Text = dgHatchQty(2, i).Value.ToString
        Label2.Text = dgHatchQty(0, i).Value.ToString
        'cmbcode.Text = dgPayment(1, i).Value.ToString
        'txtDramt.Text = dgPayment(2, i).Value.ToString
        'txtCrmat.Text = dgPayment(3, i).Value.ToString
    End Sub

    Private Sub dgHatchQty_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgHatchQty.DoubleClick
      
    End Sub
End Class