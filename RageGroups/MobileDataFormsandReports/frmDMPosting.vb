Imports System.Data.SqlClient
Public Class frmDMPosting
    Dim sql As String

    Private Property z As Integer

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If ComboBox1.Text = "ALL AREA" Then
            sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry where isAuth=1 and isnull([isPosted],0) = 0 and session= '" & GMod.Session & "' and isDm='" & isDm & "' order by dmidarea"
            GMod.DataSetRet(sql, "allAreadm")
            dg.DataSource = ds.Tables("allAreadm")
        End If

        If ComboBox1.Text = "SELECTED AREA" Then
            sql = "Select  isnull([isPosted],0) isPosted, isnull([isAuth],0) isAuth,[AreaCode], [Area],[DMNo], [DMDate],[uname], [entrydate], [Code], [CName], [Remarks], [Insurace],[VehNo], [DriverName], [Tcs_Per], [Tcs_Amt] from AreaDmPoultry  where  AreaCode = '" & txtAreaCode.Text & "' and  isAuth=1  and isnull([isPosted],0) = 0 and session= '" & GMod.Session & "'  and isDm='" & isDm & "' order by dmidarea"
            GMod.DataSetRet(sql, "SelectedAreadm")
            dg.DataSource = ds.Tables("SelectedAreadm")
        End If
        'DM BETWEEN
    End Sub
    Dim tablename As String
    Dim headtable As String

    Private Sub frmDMPosting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            GMod.SqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Connection open errpo")
        End Try
    End Sub
    Private Sub frmDMPosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'date set to as per session
        dtpPostingDate.Value = GMod.SessionCurrentDate
        dtpPostingDate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtpPostingDate.MaxDate = GMod.SessionCurrentDate

        isDm = 1

        tablename = "VENTRY" & "_" & "PHOE" & "_" & GMod.Getsession(Now)
        sql = "select vtype from Vtype where cmp_id='PHOE'  and session='" & GMod.Getsession(Now) & "' and vtype like '%SALE%'"
        GMod.DataSetRet(sql, "CRVT")
        cmbVoucherType.DataSource = GMod.ds.Tables("CRVT")
        cmbVoucherType.DisplayMember = "vtype"
        headtable = "ACC_HEAD" & "_" & "PHOE" & "_" & GMod.Getsession(Now)

        sql = " select * from " & headtable & " where cmp_id='PHOE' " 'and group_name='SALE'"
        GMod.DataSetRet(sql, "aclistins")
        cmbInsCode.DataSource = GMod.ds.Tables("aclistins")
        cmbInsCode.DisplayMember = "account_code"
        cmbInsHead.DataSource = GMod.ds.Tables("aclistins")
        cmbInsHead.DisplayMember = "account_head_name"

        sql = " select * from " & headtable & " where cmp_id='PHOE' and group_name='SALE'"
        GMod.DataSetRet(sql, "aclistcr")
        cmbBankCode.DataSource = GMod.ds.Tables("aclistcr")
        cmbBankCode.DisplayMember = "account_code"
        cmbbankHead.DataSource = GMod.ds.Tables("aclistcr")
        cmbbankHead.DisplayMember = "account_head_name"

        sql = " select * from " & headtable & " where cmp_id='PHOE' and group_name='TCS'"
        GMod.DataSetRet(sql, "aclist_tcs")
        cmdTcsCode.DataSource = GMod.ds.Tables("aclist_tcs")
        cmdTcsCode.DisplayMember = "account_code"
        cmbTcsHead.DataSource = GMod.ds.Tables("aclist_tcs")
        cmbTcsHead.DisplayMember = "account_head_name"


        sql = "select account_code,account_head_name from " & headtable & " where group_name like '%PAYBLE%'"
        GMod.DataSetRet(sql, "aclist_gst")
        cmbGSTCode.DataSource = GMod.ds.Tables("aclist_gst")
        cmbGSTCode.DisplayMember = "account_code"
        cmbGSTHead.DataSource = GMod.ds.Tables("aclist_gst")
        cmbGSTHead.DisplayMember = "account_head_name"

    End Sub
    Dim i, k As Integer
    Dim Narration, NarrationBody, vou_date As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tablename = "VENTRY" & "_" & "PHOE" & "_" & GMod.Getsession(Now)
        'BY  #TR NO. 002# DT. 02/Apr/19# Cash#SHEETAL#ADVANCE PAYMENT
        Dim amt As Double
        Dim billchicks As Integer
        Dim freechicks As Integer
        Dim layerFlag As Boolean
        Dim freeChicksPer As Integer = 0
        Dim neccAmount As Integer = 0
        Dim counter As Integer = 0
        Dim vouno, getvouno As Integer

        Dim total As Double
        Dim ins_amount As Double
        Dim tcs_amt As Double
        Dim sale_amt As Double
        Dim tcs_per As Double
        Dim gst_amt As Double = 0
        Dim DMSplit() As String

        sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & tablename & " where vou_type = '" & cmbVoucherType.Text & "'"
        GMod.DataSetRet(sql, "vnor")
        getvouno = CInt(ds.Tables("vnor").Rows(0)(0).ToString)

        Dim sqltrans As SqlTransaction
        sqltrans = GMod.SqlConn.BeginTransaction
        ' GMod.SqlConn.Open()
        Try
            For i = 0 To dg.Rows.Count - 1
                If dg(0, i).Value = 1 Then
                    'Genetraing Voucher No
                    ' GMod.VENTRY
                    vouno = getvouno + counter
                    'MsgBox(vouno)
                    sql = " select Insurace,Tcs_Amt, Insurace + Tcs_Amt ins_tcs_amt,Tcs_per from [AreaDMPoultry] where Dmno ='" & dg(5, i).Value & "' and session= '" & GMod.Session & "'"
                    GMod.DataSetRet(sql, "ins_tcs_amt")

                    If GMod.ds.Tables("ins_tcs_amt").Rows.Count > 0 Then
                        tcs_per = Val(GMod.ds.Tables("ins_tcs_amt").Rows(0)(3).ToString)
                        ins_amount = Val(GMod.ds.Tables("ins_tcs_amt").Rows(0)(0).ToString)
                        tcs_amt = Val(GMod.ds.Tables("ins_tcs_amt").Rows(0)(1).ToString)
                    Else
                        tcs_per = 0
                        ins_amount = 0
                        tcs_amt = 0
                        total = 0
                    End If

                    sql = "select Sum(Amount) amount from [AreaDMPoultry_det] where DmNo ='" & dg(5, i).Value.ToString & "' and session= '" & GMod.Session & "'"
                    GMod.DataSetRet(sql, "amount")

                    If GMod.ds.Tables("amount").Rows.Count > 0 Then
                        sale_amt = Val(GMod.ds.Tables("amount").Rows(0)(0).ToString)
                        total = Val(GMod.ds.Tables("ins_tcs_amt").Rows(0)(2).ToString) + Val(GMod.ds.Tables("amount").Rows(0)(0).ToString)

                    Else
                        Exit Sub

                    End If
                    DMSplit = dg(5, i).Value.ToString.Split("/")
                    Narration = "By " & DMSplit(0) & "/" & DMSplit(1) & "/" & DMSplit(2) & " Being Sale of "
                    sql = "select * from [dbo].[AreaDMPoultry_det] where DmNo ='" & dg(5, i).Value & "'  and session= '" & GMod.Session & "'"
                    GMod.DataSetRet(sql, "dm_det")
                    For k = 0 To GMod.ds.Tables("dm_det").Rows.Count - 1
                        NarrationBody &= GMod.ds.Tables("dm_det").Rows(k).Item(0).ToString & " Qty  Nos " & GMod.ds.Tables("dm_det").Rows(k).Item(1).ToString & " Kg " & GMod.ds.Tables("dm_det").Rows(k).Item(2).ToString & " @ " & GMod.ds.Tables("dm_det").Rows(k).Item(3).ToString
                        gst_amt = gst_amt + Val(GMod.ds.Tables("dm_det").Rows(k).Item(12).ToString)
                    Next
                    Narration = Narration + NarrationBody

                    'Customer Dr
                    sql = "insert into " & tablename & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, "
                    sql &= "Acc_head, dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name,Sub_group_name) values("
                    sql &= "'PHOE',"
                    sql &= "'" & GMod.username & "',"
                    sql &= "'1',"
                    sql &= "'" & vouno & "',"
                    sql &= "'" & cmbVoucherType.Text & "',"
                    sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                    sql &= "'" & dg(9, i).Value & "',"
                    sql &= "'" & dg(10, i).Value & "',"
                    sql &= "'" & total + gst_amt & "',"
                    sql &= "'0',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & Narration.ToUpper & "',"
                    sql &= "'CUSTOMER',"
                    sql &= "'-')"
                    Dim cmd1 As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmd1.ExecuteNonQuery()


                    'Sale Cr
                    sql = "insert into " & tablename & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, "
                    sql &= "Acc_head, cramt, dramt, Pay_mode, Cheque_no, Narration, Group_name,Sub_group_name) values("
                    sql &= "'PHOE',"
                    sql &= "'" & GMod.username & "',"
                    sql &= "'2',"
                    sql &= "'" & vouno & "',"
                    sql &= "'" & cmbVoucherType.Text & "',"
                    sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                    sql &= "'" & cmbBankCode.Text & "',"
                    sql &= "'" & cmbbankHead.Text & "',"
                    sql &= "'" & sale_amt & "',"
                    sql &= "'0',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'" & Narration.ToUpper & "',"
                    sql &= "'-',"
                    sql &= "'-')"
                    Dim cmd2 As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmd2.ExecuteNonQuery()

                    'Inurance amount Cr
                    If ins_amount > 0 Then
                        sql = "insert into " & tablename & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, "
                        sql &= "Acc_head, cramt, dramt, Pay_mode, Cheque_no, Narration, Group_name,Sub_group_name) values("
                        sql &= "'PHOE',"
                        sql &= "'" & GMod.username & "',"
                        sql &= "'3',"
                        sql &= "'" & vouno & "',"
                        sql &= "'" & cmbVoucherType.Text & "',"
                        sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                        sql &= "'" & cmbInsCode.Text & "',"
                        sql &= "'" & cmbInsHead.Text & "',"
                        sql &= "'" & ins_amount & "',"
                        sql &= "'0',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'" & Narration.ToUpper & "',"
                        sql &= "'-',"
                        sql &= "'-')"
                        Dim cmd3 As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                        cmd3.ExecuteNonQuery()
                    End If

                    'Tcs Amount Cr
                    If tcs_amt > 0 Then
                        sql = "insert into " & tablename & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, "
                        sql &= "Acc_head, cramt, dramt, Pay_mode, Cheque_no, Narration, Group_name,Sub_group_name) values("
                        sql &= "'PHOE',"
                        sql &= "'" & GMod.username & "',"
                        sql &= "'3',"
                        sql &= "'" & vouno & "',"
                        sql &= "'" & cmbVoucherType.Text & "',"
                        sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                        sql &= "'" & cmdTcsCode.Text & "',"
                        sql &= "'" & cmbTcsHead.Text & "',"
                        sql &= "'" & tcs_amt & "',"
                        sql &= "'0',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'" & Narration.ToUpper & "',"
                        sql &= "'-',"
                        sql &= "'-')"
                        Dim cmdTcs As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                        cmdTcs.ExecuteNonQuery()

                        'inserting data into tcs records
                        'Insert into TCS Report
                        sql = "insert into TdsEntry(Vou_Type, Vou_no, TdsType, Per, TdsDate, " _
                                      & " BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt," _
                                      & " Actualamt, session,Paidto,vou_date, TdsAmt,dcode,cmp_id,taxtype ) values( "
                        sql &= "'" & cmbVoucherType.Text & "',"
                        sql &= "'" & vouno & "',"
                        sql &= "'TCS',"
                        sql &= "'" & tcs_per & "',"
                        sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'-',"
                        sql &= "'0',"
                        sql &= "'" & total + tcs_amt & "',"
                        sql &= "'" & Val("") & "',"
                        sql &= "'" & GMod.Session & "',"
                        sql &= "'YES',"
                        sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                        sql &= "'" & tcs_amt & "',"
                        sql &= "'-',"
                        sql &= "'" & GMod.Cmpid & "','1')"

                        Dim cmdTcsReport As New SqlCommand(sql, SqlConn, sqltrans)
                        cmdTcsReport.ExecuteNonQuery()

                    End If


                    sql = "select * from AreaDMPoultry_det where DmNo ='" & dg(5, i).Value & "'"
                    GMod.DataSetRet(sql, "dm_details")
                    For k = 0 To GMod.ds.Tables("dm_details").Rows.Count - 1
                        'Inserting Other Sale Data
                        sql = "insert into OtherSaleData ([Vou_type], [Vou_no], [AccCode], [AccName], [Station], [ProductName], [OutQty]," _
                                       & " [Rate], [Amount], [OutQtyNos], [BillNo], [BillDate], [InQty], [InQtyNos], [Cmp_id], " _
                                       & " [Session],[mrktrate], [authr], [Prdunit], [Packing], [Insurance], [Discount]," _
                                       & " [CrHead],[tcs_per], [tcs_amt],cgstp,cgsta) VALUES ("
                        sql &= "'" & cmbVoucherType.Text & "',"
                        sql &= "'" & vouno & "',"
                        sql &= "'" & dg(9, i).Value & "',"
                        sql &= "'" & dg(10, i).Value & "',"
                        sql &= "'COMMON',"
                        sql &= "'" & GMod.ds.Tables("dm_details").Rows(k).Item(0).ToString & "',"
                        sql &= "'" & GMod.ds.Tables("dm_details").Rows(k).Item(2).ToString & "',"
                        sql &= "'" & GMod.ds.Tables("dm_details").Rows(k).Item(3).ToString & "',"
                        sql &= "'" & GMod.ds.Tables("dm_details").Rows(k).Item(4).ToString & "',"
                        sql &= "'" & GMod.ds.Tables("dm_details").Rows(k).Item(1).ToString & "',"
                        sql &= "'" & vouno & "',"
                        sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                        sql &= "'0',"
                        sql &= "'0',"
                        sql &= "'" & GMod.Cmpid & "',"
                        sql &= "'" & GMod.Session & "',"
                        sql &= "'" & Val("") & "',"
                        sql &= "'-'," 'Autorization
                        sql &= "'-',"
                        sql &= "'" & Val("") & "',"
                        sql &= "'" & ins_amount & "',"
                        sql &= "'" & Val("") & "',"
                        sql &= "'" & cmbbankHead.Text & "',"
                        sql &= "'" & tcs_per & "',"
                        sql &= "'" & tcs_amt & "',"
                        sql &= "'" & GMod.ds.Tables("dm_details").Rows(k).Item(11).ToString & "',"
                        sql &= "'" & GMod.ds.Tables("dm_details").Rows(k).Item(12).ToString & "')"

                        Dim cmd3 As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                        cmd3.ExecuteNonQuery()

                        'GST Ppostng to A/C
                        If Val(GMod.ds.Tables("dm_details").Rows(k).Item(12).ToString) > 0 Then
                            sql = "insert into " & tablename & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, "
                            sql &= "Acc_head, cramt, dramt, Pay_mode, Cheque_no, Narration, Group_name,Sub_group_name) values("
                            sql &= "'PHOE',"
                            sql &= "'" & GMod.username & "',"
                            sql &= "'3',"
                            sql &= "'" & vouno & "',"
                            sql &= "'" & cmbVoucherType.Text & "',"
                            sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
                            sql &= "'" & cmbGSTCode.Text & "',"
                            sql &= "'" & cmbGSTHead.Text & "',"
                            sql &= "'" & Val(GMod.ds.Tables("dm_details").Rows(k).Item(12).ToString) & "',"
                            sql &= "'0',"
                            sql &= "'-',"
                            sql &= "'-',"
                            sql &= "'" & Narration.ToUpper & "',"
                            sql &= "'-',"
                            sql &= "'-')"
                            Dim cmdGst As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                            cmdGst.ExecuteNonQuery()

                        End If

                    Next

                    sql = "Update AreaDMPoultry Set isPosted=1  Where DMNo ='" & dg(5, i).Value & "'"
                    Dim cmd4 As New SqlCommand(sql, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()

                    amt = 0
                    billchicks = 0
                    freechicks = 0
                    neccAmount = 0
                    layerFlag = False
                    freeChicksPer = 0
                    total = 0
                    tcs_amt = 0
                    ins_amount = 0
                    Narration = ""
                    NarrationBody = ""
                    gst_amt = 0
                    MessageBox.Show("Invoice No" & vouno.ToString)
                    counter = counter + 1
                End If
            Next
            sqltrans.Commit()
            vouno = 0
            counter = 0
            getvouno = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            getvouno = 0
            Try
                sqltrans.Rollback()
            Catch ex1 As Exception
                MessageBox.Show(ex1.Message)
            End Try

            'sqltrans.Dispose()
        End Try
        '  sqltrans.Rollback()
        sqltrans.Dispose()
        getvouno = 0
        ' MessageBox.Show(vouno)
        MessageBox.Show("Posted to Accounts Successfully ")
        btnShow_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ' RadioButton1.Checked = True
        If RadioButton1.Checked = True Then
            CrystalReportViewer1.BringToFront()
        End If
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        Try
            sql = "select * from [AreaDMPoultry_det] where DMNo='" & dg(5, e.RowIndex).Value.ToString & "' and session ='" & GMod.Session & "'"
            GMod.DataSetRet(sql, "dmDetials")
            dgDetials.DataSource = GMod.ds.Tables("dmDetials")
        Catch ex As Exception

        End Try
    End Sub
    Dim isDm As Integer
    Private Sub ChkisDm_CheckedChanged(sender As Object, e As EventArgs) Handles ChkisDm.CheckedChanged
        ChkisCm.Checked = False
        isDm = 1
    End Sub

    Private Sub ChkisCm_CheckedChanged(sender As Object, e As EventArgs) Handles ChkisCm.CheckedChanged
        ChkisDm.Checked = False
        isDm = 0
    End Sub
End Class