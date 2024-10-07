Public Class FormSupply
    Dim sql As String
    Dim i As Integer
    Dim isDm As Integer
    Private Sub txtAreaCode_TextChanged(sender As Object, e As EventArgs)
        'sql = "Select Area,DMNo, DMDate,HatchDate,Code,CName,Chick_type,Rate,TotalChicks,Mortality,Hatchries,Remarks,isAuth From AreaDMData where AreaCode ='" & txtAreaCode.Text & "'" 'd HatchDate between '" & DtpTrDateFrom.Value.ToShortDateString & "' and '" & DtpTrDateTo.Value.ToShortDateString & "' order by HatchDate"

        ' sql = "Select * from AreaDMData where AreaCode='" & txtAreaCode.Text & "' "
        'GMod.DataSetRet(sql, "supply")
        'dg.DataSource = ds.Tables("supply")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To dg.Rows.Count - 1
            If dg(0, i).Value = 1 Then
                sql = "Update AreaDmPoultry Set isAuth=1 Where DMNo= '" & dg(5, i).Value & "'   and session='" & GMod.Session & "'"
                'GMod.SqlExecuteNonQuery(Sql)
                GMod.DataSetRet(sql, "setisAuthto1")
            End If
        Next
        MessageBox.Show("Authorised Successfully")
    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If ComboBox1.Text = "ALL AREA" Then
            If ComboBox2.Text = "UnAuth" Then
                sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where isDm  = " & isDm & "  and session='" & GMod.Session & "' and isnull([isAuth],0)=0  order by dmidarea"

            ElseIf ComboBox2.Text = "Auth" Then
                sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where isDm  = " & isDm & "  and session='" & GMod.Session & "' and isnull([isAuth],0)=1  order by dmidarea"

            ElseIf ComboBox2.Text = "All" Then
                sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where isDm  = " & isDm & "  and session='" & GMod.Session & "'  order by dmidarea"
            End If
            GMod.DataSetRet(sql, "allAreadm")
            dg.DataSource = ds.Tables("allAreadm")
        End If

        If ComboBox1.Text = "SELECTED AREA" Then
            If ComboBox2.Text = "UnAuth" Then
                sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where  AreaCode = '" & txtAreaCode.Text & "' and isDm  = " & isDm & "  and session='" & GMod.Session & "' and isnull([isAuth],0) = 0 order by dmidarea"

            ElseIf ComboBox2.Text = "Auth" Then
                sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where  AreaCode = '" & txtAreaCode.Text & "' and isDm  = " & isDm & "  and session='" & GMod.Session & "'  and isnull([isAuth],0) = 1 order by dmidarea"

            ElseIf ComboBox2.Text = "All" Then
                sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where  AreaCode = '" & txtAreaCode.Text & "' and isDm  = " & isDm & "  and session='" & GMod.Session & "' order by dmidarea"

            End If
            GMod.DataSetRet(sql, "SelectedAreadm")
            dg.DataSource = ds.Tables("SelectedAreadm")
        End If


        'DM BETWEEN
        If ComboBox1.Text = "DM BETWEEN" Then
            If ComboBox2.Text = "UnAuth" Then
                sql = "Select isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where  AreaCode = '" & txtAreaCode.Text & "'  and dmidarea between '" & Val(dm1.Text) & "' and '" & Val(dm2.Text) & "'  isnull([isAuth],0) = 0 order by dmidarea"

            ElseIf ComboBox2.Text = "Auth" Then
                sql = "Select isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where  AreaCode = '" & txtAreaCode.Text & "'  and dmidarea between '" & Val(dm1.Text) & "' and '" & Val(dm2.Text) & "'  isnull([isAuth],0) = 1 order by dmidarea"

            ElseIf ComboBox2.Text = "All" Then
                sql = "Select isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where  AreaCode = '" & txtAreaCode.Text & "'  and dmidarea between '" & Val(dm1.Text) & "' and '" & Val(dm2.Text) & "' order by dmidarea"

            End If

            GMod.DataSetRet(sql, "areahatchdatedm")
            dg.DataSource = ds.Tables("areahatchdatedm")
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        CrystalReportViewer1.BringToFront()
    End Sub

    

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        ' MsgBox(dg(5, e.RowIndex).Value.ToString)

        sql = "select * from [AreaDMPoultry_det] where DMNo='" & dg(5, e.RowIndex).Value.ToString & "' and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "dmDetials")
        dgDetials.DataSource = GMod.ds.Tables("dmDetials")
    End Sub

    Private Sub FormSupply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isDm = 1
    End Sub

    Private Sub ChkisDm_CheckedChanged(sender As Object, e As EventArgs) Handles ChkisDm.CheckedChanged
        ChkisCm.Checked = False
        isDm = 1

    End Sub

    Private Sub ChkisCm_CheckedChanged(sender As Object, e As EventArgs) Handles ChkisCm.CheckedChanged
        ChkisDm.Checked = False
        isDm = 0
    End Sub
End Class