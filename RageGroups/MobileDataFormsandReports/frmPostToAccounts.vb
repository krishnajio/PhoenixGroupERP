Public Class frmPostToAccounts
   

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        If ComboBox1.Text = "ALL AREA" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,convert(varchar,TrDate,103) TrDate,convert(varchar,HatchDate,103) HatchDate,convert(varchar,entrydate,103) entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from [AreaTrPoultry] where isAuth=1 and isnull(isPosted,0)=0  and session = '" & GMod.Session & "'" 'Where TrDate='" & DtpTrDate.Text.ToString & "' "
            GMod.DataSetRet(sql, "allAreatrposting")
            dg.DataSource = ds.Tables("allAreatrposting")
        End If

        'SELECTED AREA
        'BY HATCH DATE

        If ComboBox1.Text = "SELECTED AREA" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from AreaTrPoultry Where AreaCode='" & txtAreaCode.Text & "' and isAuth=1 and isnull(isPosted,0)=0 and session = '" & GMod.Session & "'"
            GMod.DataSetRet(sql, "selectedAreatrposting")
            dg.DataSource = ds.Tables("selectedAreatrposting")
        End If

        If ComboBox1.Text = "BY HATCH DATE" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from AreaTrPoultry Where HatchDate='" & DtpTrDate.Text.ToString & "' and isAuth=1 and isnull(isPosted,0) =0 and session = '" & GMod.Session & "'"
            GMod.DataSetRet(sql, "hatchdatrposting")
            dg.DataSource = ds.Tables("hatchdatrposting")
        End If

       
    End Sub
    Dim i As Integer
    Dim sql, Narration, vou_date As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tablename = "VENTRY" & "_" & GMod.Cmpid & "_" & GMod.Getsession(Now)
        'BY  #TR NO. 002# DT. 02/Apr/19# Cash#SHEETAL#ADVANCE PAYMENT
        Dim vouno, getvouno As Integer
        sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & tablename & " where vou_type = '" & cmbVoucherType.Text & "'"
        GMod.DataSetRet(sql, "vnor")
        getvouno = CInt(ds.Tables("vnor").Rows(0)(0).ToString)
        Dim counter As Integer = 0

        Try
            For i = 0 To dg.Rows.Count - 1
                If dg(0, i).Value = 1 Then
                    'Genetraing Voucher No
                    ' GMod.VENTRY
                    vouno = getvouno + counter
                    'Dim dd() As String
                    'dd = dg(7, i).Value.ToString().Split("/")
                    'vou_date = dd(1) & "/" & dd(0) & "/" & dd(2)

                    Narration = "By TR NO " & dg(4, i).Value & " Dt." & dg(5, i).Value & " # " & dg(15, i).Value
                    'Customer Account Credited
                    sql = "insert into " & tablename & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, "
                    sql &= "Acc_head, dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name,sub_group_name) values("
                    sql &= "'" & GMod.Cmpid & "',"
                    sql &= "'" & GMod.username & "',"
                    sql &= "'0',"
                    sql &= "'" & vouno & "',"
                    sql &= "'" & cmbVoucherType.Text & "',"
                    sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                    sql &= "'" & dg(8, i).Value & "',"
                    sql &= "'" & dg(9, i).Value & "',"
                    sql &= "'0',"
                    sql &= "'" & dg(10, i).Value & "',"
                    sql &= "'-',"
                    sql &= "'" & dg(14, i).Value & "',"
                    sql &= "'" & Narration & "',"
                    sql &= "'CUSTOMER',"
                    sql &= "'-')"
                    GMod.SqlExecuteNonQuery(sql)

                    'Collection Account Debited
                    sql = "insert into " & tablename & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, "
                    sql &= "Acc_head, cramt, dramt, Pay_mode, Cheque_no, Narration, Group_name,sub_group_name) values("
                    sql &= "'" & GMod.Cmpid & "',"
                    sql &= "'" & GMod.username & "',"
                    sql &= "'0',"
                    sql &= "'" & vouno & "',"
                    sql &= "'" & cmbVoucherType.Text & "',"
                    sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                    sql &= "'" & cmbBankCode.Text & "',"
                    sql &= "'" & cmbbankHead.Text & "',"
                    sql &= "'0',"
                    sql &= "'" & dg(10, i).Value & "',"
                    sql &= "'-',"
                    sql &= "'" & dg(14, i).Value & "',"
                    sql &= "'" & Narration & "',"
                    sql &= "'-',"
                    sql &= "'-')"
                    GMod.SqlExecuteNonQuery(sql)

                    MessageBox.Show(vouno)
                    counter = counter + 1
                    sql = "Update AreaTrPoultry Set isPosted=1  Where TrNo= '" & dg(4, i).Value & "' and session ='" & GMod.Session & "'"
                    GMod.SqlExecuteNonQuery(sql)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnShow_Click(sender, e)
        vouno = 0
        counter = 0
        getvouno = 0
        MessageBox.Show("Posted to Accounts Successfully ")
    End Sub
    Dim tablename, vouno As String
    Dim headtable As String

    Private Sub frmPostToAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tablename = "VENTRY" & "_" & "PHOE" & "_" & GMod.Getsession(Now)
        sql = "select vtype from Vtype where cmp_id='PHHA'  and (vtype like '%CR VOUCHER%'  or  vtype like '%RECEIPT%' or  vtype like '%FRECEIPT%') and vtype not like 'sale CR'  and session = '" & GMod.Getsession(Now) & "'"
        GMod.DataSetRet(sql, "CRVT")
        cmbVoucherType.DataSource = GMod.ds.Tables("CRVT")
        cmbVoucherType.DisplayMember = "vtype"

        headtable = "ACC_HEAD" & "_" & "PHOE" & "_" & GMod.Getsession(Now)

        sql = " select * from " & headtable & " where cmp_id='PHOE' and group_name='COLLECTION'"
        GMod.DataSetRet(sql, "aclistcr")

        cmbBankCode.DataSource = GMod.ds.Tables("aclistcr")
        cmbBankCode.DisplayMember = "account_code"

        cmbbankHead.DataSource = GMod.ds.Tables("aclistcr")
        cmbbankHead.DisplayMember = "account_head_name"


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpPostingDate.ValueChanged

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            CrystalReportViewer1.BringToFront()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "ALL AREA" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,convert(varchar,TrDate,103) TrDate,convert(varchar,HatchDate,103) HatchDate,convert(varchar,entrydate,103) entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from AreaTrData where isAuth=1 and isnull(isPosted,0)=0  order by tridarea" 'Where TrDate='" & DtpTrDate.Text.ToString & "' "
            GMod.DataSetRet(sql, "allArea")
            Dim cr As New CrAreaWiseTrReport
            cr.SetDataSource(ds.Tables("allArea"))
            CrystalReportViewer1.ReportSource = cr
        End If

        'SELECTED AREA
        'BY HATCH DATE

        If ComboBox1.Text = "SELECTED AREA" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from AreaTrData Where AreaCode='" & txtAreaCode.Text & "' and isAuth=1 and isnull(isPosted,0)=0 order by tridarea"
            GMod.DataSetRet(sql, "allArea")
            Dim cr As New CrAreaWiseTrReport
            cr.SetDataSource(ds.Tables("allArea"))
            CrystalReportViewer1.ReportSource = cr
        End If

        If ComboBox1.Text = "BY HATCH DATE" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from AreaTrData Where HatchDate='" & DtpTrDate.Text.ToString & "' and isAuth=1 and isnull(isPosted,0) =0 order by tridarea"
            GMod.DataSetRet(sql, "allArea")
            Dim cr As New CrAreaWiseTrReport
            cr.SetDataSource(ds.Tables("allArea"))
            CrystalReportViewer1.ReportSource = cr
        End If

        'AREA AND HATCH DATE

        If ComboBox1.Text = "AREA AND HATCH DATE" Then
            Dim sql As String = "Select isAuth,Area,AreaCode,TRNo,TrDate,HatchDate,entrydate,Code,CName, TrAmount,Bank_det,Pay_mode,bankdate,DD_No,Chick_type,Rate,Remarks,Pay_type from AreaTrData Where HatchDate='" & DtpTrDate.Text.ToString & "' and isAuth=1 and isnull(isPosted,0) =0 AND AreaCode='" & txtAreaCode.Text & "' order by tridarea"
            GMod.DataSetRet(sql, "hatchdatrposting")
            ' dg.DataSource = ds.Tables("hatchdatrposting")
            Dim cr As New CrAreaWiseTrReport
            cr.SetDataSource(ds.Tables("allArea"))
            CrystalReportViewer1.ReportSource = cr
        End If
    End Sub


End Class