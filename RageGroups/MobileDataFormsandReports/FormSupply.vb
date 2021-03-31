Public Class FormSupply
    Dim sql As String
    Dim i As Integer
    Private Sub txtAreaCode_TextChanged(sender As Object, e As EventArgs)
        'sql = "Select Area,DMNo, DMDate,HatchDate,Code,CName,Chick_type,Rate,TotalChicks,Mortality,Hatchries,Remarks,isAuth From AreaDMData where AreaCode ='" & txtAreaCode.Text & "'" 'd HatchDate between '" & DtpTrDateFrom.Value.ToShortDateString & "' and '" & DtpTrDateTo.Value.ToShortDateString & "' order by HatchDate"

        ' sql = "Select * from AreaDMData where AreaCode='" & txtAreaCode.Text & "' "
        'GMod.DataSetRet(sql, "supply")
        'dg.DataSource = ds.Tables("supply")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To dg.Rows.Count - 1
            If dg(0, i).Value = 1 Then
                sql = "Update AreaDmPoultry Set isAuth=1 Where DMNo= '" & dg(5, i).Value & "'"
                GMod.SqlExecuteNonQuery(Sql)
            End If
        Next
        MessageBox.Show("Authorised Successfully")

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If ComboBox1.Text = "ALL AREA" Then
            sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry order by dmidarea"
            GMod.DataSetRet(sql, "allAreadm")
            dg.DataSource = ds.Tables("allAreadm")
        End If

        If ComboBox1.Text = "SELECTED AREA" Then
            sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where  AreaCode = '" & txtAreaCode.Text & "' order by dmidarea"
            GMod.DataSetRet(sql, "SelectedAreadm")
            dg.DataSource = ds.Tables("SelectedAreadm")
        End If


        'DM BETWEEN
        If ComboBox1.Text = "DM BETWEEN" Then
            sql = "Select isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where  AreaCode = '" & txtAreaCode.Text & "'  and dmidarea between '" & Val(dm1.Text) & "' and '" & Val(dm2.Text) & "' order by dmidarea"
            GMod.DataSetRet(sql, "areahatchdatedm")
            dg.DataSource = ds.Tables("areahatchdatedm")
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        CrystalReportViewer1.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "ALL AREA" Then
            ' Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,convert(varchar,TrDate,103) TrDate,convert(varchar,HatchDate,103) HatchDate,convert(varchar,entrydate,103) entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from AreaTrData where isAuth=1 and isnull(isPosted,0)=0 and pay_mode <>'CASH'" 'Where TrDate='" & DtpTrDate.Text.ToString & "' "
            sql = "Select Area,DMNo, DMDate, convert(varchar,HatchDate,103) HatchDate,Code,CName,Chick_type,Rate,TotalChicks,Mortality,Hatchries,Remarks,isAuth,HatchDate From AreaDMData where Chick_type='" & cmbChicksType.Text & "' order by dmidarea"
            GMod.DataSetRet(sql, "allAreadm")
            dg.DataSource = ds.Tables("allAreadm")
        End If

        'SELECTED AREA
        'BY HATCH DATE
        If ComboBox1.Text = "SELECTED AREA" Then
            'Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate, convert(varchar,HatchDate,103) HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from AreaTrData Where AreaCode='" & txtAreaCode.Text & "' and isAuth=1 and isnull(isPosted,0)=0"
            sql = "Select Area,DMNo, DMDate, convert(varchar,HatchDate,103) HatchDate,Code,CName,Chick_type,Rate,TotalChicks,Mortality,Hatchries,Remarks,isAuth From AreaDMData where  AreaCode = '" & txtAreaCode.Text & "' and Chick_type='" & cmbChicksType.Text & "'  order by dmidarea"
            GMod.DataSetRet(sql, "SelectedAreadm")
            'dg.DataSource = ds.Tables("SelectedAreadm")
            Dim Crrep As New CrSupplyReport1
            Crrep.SetDataSource(ds.Tables("SelectedAreadm"))
            CrystalReportViewer1.ReportSource = Crrep
        End If

        If ComboBox1.Text = "BY HATCH DATE" Then
            ' Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate, convert(varchar,HatchDate,103) HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from AreaTrData Where HatchDate='" & DtpTrDate.Text.ToString & "' and isAuth=1 and isnull(isPosted,0) =0"
            'sql = "Select Area,DMNo, DMDate, convert(varchar,HatchDate,103) HatchDate,Code,CName,Chick_type,Rate,TotalChicks,Mortality,Hatchries,Remarks,isAuth From AreaDMData where isAuth=1 and isnull(isPosted,0)=0 "
            sql = "Select Area,DMNo, DMDate, convert(varchar,HatchDate,103) HatchDate,Code,CName,Chick_type,Rate,TotalChicks,Mortality,Hatchries,Remarks,isAuth,HatchDate From AreaDMData where HatchDate between '" & DtpTrDate.Value.ToShortDateString & "' and '" & dthdate.Value.ToShortDateString & "' and Chick_type='" & cmbChicksType.Text & "'  order by dmidarea"
            GMod.DataSetRet(sql, "hatchdatedm")
            Dim Crrep As New CrSupplyReport1
            Crrep.SetDataSource(ds.Tables("hatchdatedm"))
            CrystalReportViewer1.ReportSource = Crrep
        End If

        If ComboBox1.Text = "SELECT AREA AND HATCH DATE" Then
            sql = "Select Area,DMNo, DMDate, convert(varchar,HatchDate,103) HatchDate,Code,CName,Chick_type,Rate,TotalChicks,Mortality,Hatchries,Remarks,isAuth,HatchDate From AreaDMData where HatchDate between '" & DtpTrDate.Value.ToShortDateString & "' and '" & dthdate.Value.ToShortDateString & "' and Chick_type='" & cmbChicksType.Text & "' and AreaCode = '" & txtAreaCode.Text & "'  order by dmidarea"
            GMod.DataSetRet(sql, "areahatchdatedm")
            ' dg.DataSource = ds.Tables("areahatchdatedm")

            Dim Crrep As New CrSupplyReport1
            Crrep.SetDataSource(ds.Tables("areahatchdatedm"))
            CrystalReportViewer1.ReportSource = Crrep
        End If


        'DM BETWEEN
        If ComboBox1.Text = "DM BETWEEN" Then
            sql = "Select Area,DMNo, DMDate, convert(varchar,HatchDate,103) HatchDate,Code,CName,Chick_type,Rate,TotalChicks,Mortality,Hatchries,Remarks,isAuth,HatchDate From AreaDMData where dmidarea between '" & Val(dm1.Text) & "' and '" & Val(dm2.Text) & "' and Chick_type='" & cmbChicksType.Text & "' and AreaCode = '" & txtAreaCode.Text & "'  order by dmidarea"
            GMod.DataSetRet(sql, "areahatchdatedm")
          
            Dim Crrep As New CrSupplyReport1
            Crrep.SetDataSource(ds.Tables("areahatchdatedm"))
            CrystalReportViewer1.ReportSource = Crrep
        End If
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        ' MsgBox(dg(5, e.RowIndex).Value.ToString)

        sql = "select * from [AreaDMPoultry_det] where DMNo='" & dg(5, e.RowIndex).Value.ToString & "' and session ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "dmDetials")
        dgDetials.DataSource = GMod.ds.Tables("dmDetials")
    End Sub
End Class