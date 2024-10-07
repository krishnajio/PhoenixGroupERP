Public Class FrmAreaWiseReport
    Dim sql As String
    Private Sub btnShow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow1.Click
        'UnAuth
        'Auth
        'All
        If ComboBox1.Text = "ALL AREA" Then
            If ComboBox2.Text = "UnAuth" Then
                sql = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks from [AreaTrPoultry] where session ='" & GMod.Session & "' and isAuth=0 order by tridarea" 'Where TrDate='" & DtpTrDate.Text.ToString & "' "

            ElseIf ComboBox2.Text = "Auth" Then
                sql = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks from [AreaTrPoultry] where session ='" & GMod.Session & "' and isAuth=1 order by tridarea" 'Where TrDate='" & DtpTrDate.Text.ToString & "' "

            ElseIf ComboBox2.Text = "All" Then
                sql = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks from [AreaTrPoultry] where session ='" & GMod.Session & "'  order by tridarea" 'Where TrDate='" & DtpTrDate.Text.ToString & "' "
            End If

            GMod.DataSetRet(sql, "allAreatr")
            dg.DataSource = ds.Tables("allAreatr")
        End If

        'SELECTED AREA
        'BY HATCH DATE

        If ComboBox1.Text = "SELECTED AREA" Then

            If ComboBox2.Text = "UnAuth" Then
                sql = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks from [AreaTrPoultry] Where AreaCode='" & txtAreaCode.Text & "' and session ='" & GMod.Session & "' and isAuth=0 order by tridarea "

            ElseIf ComboBox2.Text = "Auth" Then
                sql = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks from [AreaTrPoultry] Where AreaCode='" & txtAreaCode.Text & "' and session ='" & GMod.Session & "' and isAuth=1 order by tridarea "

            ElseIf ComboBox2.Text = "All" Then
                sql = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks from [AreaTrPoultry] Where AreaCode='" & txtAreaCode.Text & "' and session ='" & GMod.Session & "' order by tridarea "
            End If

            GMod.DataSetRet(sql, "SelectedArea")
            dg.DataSource = ds.Tables("SelectedArea")
        End If

    End Sub

    Private Sub txtAreaCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAreaCode.TextChanged

        'Dim sql As String = "Select * from AreaTrData where AreaCode='" & txtAreaCode.Text & "' "
        'God.DataSetRet(sql, "ar")
        'dg.DataSource = ds.Tables("ar")

    End Sub
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 0 To dg.Rows.Count - 1
            If dg(0, i).Value = 1 Then
                sql = "Update AreaTrPoultry Set isAuth=1, AuthBy = '" & GMod.username & "' Where TrNo= '" & dg(4, i).Value & "'"
                GMod.SqlExecuteNonQuery(sql)
            End If
        Next
        MessageBox.Show("Authorised Successfully")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For i = 0 To dg.Rows.Count - 1
            If dg(0, i).Value = 1 Then
                sql = "Update AreaTrPoultry Set isAuth=0,AuthBy ='" & GMod.username & "' Where TrNo= '" & dg(4, i).Value & "' and isnull(isPosted,0)=0"
                GMod.SqlExecuteNonQuery(sql)
            End If
        Next
        MessageBox.Show("UN-Authorised Successfully")

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.Text = "ALL AREA" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks from AreaTrPoultry  where isAuth=1  order by tridarea" 'Where TrDate='" & DtpTrDate.Text.ToString & "' "
            GMod.DataSetRet(sql, "allAreatr")
            dg.DataSource = ds.Tables("allAreatr")

            Dim CRtR As New CrAreaWiseTrReport
            CRtR.SetDataSource(ds.Tables("allAreatr"))
            CrystalReportViewer1.ReportSource = CRtR
        End If

        'SELECTED AREA
        'BY HATCH DATE

        If ComboBox1.Text = "SELECTED AREA" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks from AreaTrPoultry Where AreaCode='" & txtAreaCode.Text & "' and isAuth=1 order by tridarea "
            GMod.DataSetRet(sql, "SelectedArea")
            dg.DataSource = ds.Tables("SelectedArea")

            Dim CRtR As New CrAreaWiseTrReport
            CRtR.SetDataSource(ds.Tables("SelectedArea"))
            CrystalReportViewer1.ReportSource = CRtR
        End If

        'TR NO BETWEEN
        If ComboBox1.Text = "TR NO BETWEEN" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks from AreaTrPoultry Where AreaCode='" & txtAreaCode.Text & "' and tridarea between '" & Val(tr1.Text) & "' and '" & Val(tr2.Text) & "'  order by tridarea "
            GMod.DataSetRet(sql, "areahatchdatetr")
            dg.DataSource = ds.Tables("areahatchdatetr")
            Dim CRtR As New CrAreaWiseTrReport
            CRtR.SetDataSource(ds.Tables("areahatchdatetr"))
            CrystalReportViewer1.ReportSource = CRtR
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        CrystalReportViewer1.BringToFront()
    End Sub

   
End Class
