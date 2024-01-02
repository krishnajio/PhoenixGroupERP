Public Class frmDMList

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim sql As String
        sql = "select isAuth, isPosted, a.AreaCode, Area,a.DMNo,DMDate, Code,CName,"
        sql &= " ad.Product, ad.QtyNos, ad.QtyKg, ad.Rate, ad.Amount, Insurace, Tcs_Amt "
        sql &= " from AreaDMPoultry a inner join "
        sql &= " AreaDMPoultry_det ad on a.dmno = ad.dmno and a.AreaCode= ad.AreaCode "
        sql &= "  where a.session='" & GMod.Session & "'  AND a.AreaCode= '" & txtAreaCode.Text & "' order by AreaCode, DMDate"

        GMod.DataSetRet(sql, "SelectedAreadmlist")
        dg.DataSource = ds.Tables("SelectedAreadmlist")
    End Sub
End Class