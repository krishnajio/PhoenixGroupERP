Imports System.Data.SqlClient
Public Class frmSaleOther
    Private m_vtype As String
    Private m_vno As String
    Private m_vdt As System.DateTime


    Public Property Vtype() As String
        Get
            Return Me.m_vtype
        End Get
        Set(ByVal s As String)
            Me.m_vtype = s
        End Set
    End Property

    Public Property VNo() As String
        Get
            Return Me.m_vno
        End Get
        Set(ByVal s As String)
            Me.m_vno = s
        End Set
    End Property

    Public Property Vdt() As System.DateTime
        Get
            Return Me.m_vdt
        End Get
        Set(ByVal s As System.DateTime)
            Me.m_vdt = s.ToShortDateString
        End Set
    End Property

    Private Sub frmSaleChicken_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='" & cmbVoucherType.Text & "' and cmp_id='" & GMod.Cmpid & "'")

    End Sub
    Private Sub frmPurchaseChicken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GMod.PerviousSession = True Then
            GMod.DataSetRet("select entry_status from SessionMaster where Uname ='" & GMod.username & "' and session ='" & GMod.Session & "'", "entry_status")
            GMod.EntryStatus = CInt(GMod.ds.Tables("entry_status").Rows(0)(0))
            If GMod.EntryStatus = 1 Then
            Else
                MessageBox.Show("Permission denied", "Permision denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Else
        End If
        'date set to as per session
        dtVouDate.Value = GMod.SessionCurrentDate
        dtVouDate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtVouDate.MaxDate = GMod.SessionCurrentDate

        dtInvVate.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtInvVate.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        dtInvVate.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtInvVate.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        If btnSave.Enabled = True Then
            ' GMod.DataSetRet("select getdate()", "serverdate")
            'dtVouDate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)
        End If


        cmbVoucherType.SelectedIndex = 0
        Dim sqlitem As String
        fillArea()

        'filling production unit 
        GMod.DataSetRet("select prdunit from prdunit where cmp_id='" & GMod.Cmpid & "'", "prdunit")
        cmbprdunit.DataSource = GMod.ds.Tables("prdunit")
        cmbprdunit.DisplayMember = "prdunit"

        ' nxtvno()
        heads()
        '
        'GMod.DataSetRet("select * from dbo.Vtype where Cmp_id='" & GMod.Cmpid & "'", "vtype")


        'cmbVoucherType.DataSource = GMod.ds.Tables("vtype")
        'cmbVoucherType.DisplayMember = "Vtype"

        GMod.DataSetRet("SELECT * from ACC_HEAD_" & GMod.Cmpid & "_" & GMod.Session, "salhd")

        cmbSaleAcc.DataSource = GMod.ds.Tables("salhd")
        cmbSaleAcc.DisplayMember = "account_head_name"
        cmbSaleAccCode.DataSource = GMod.ds.Tables("salhd")
        cmbSaleAccCode.DisplayMember = "account_code"
        cmbSaleAccCode.ValueMember = "group_name"

        sqlitem = "select * from ItemMasterOther where cmp_id='" & GMod.Cmpid & "'" 'where prdtype='FEED'"
        GMod.DataSetRet(sqlitem, "ITEM")
        Me.Particular.DataSource = GMod.ds.Tables("ITEM")
        Me.Particular.DisplayMember = "ItemName"
        dgPurchase.Rows.Add()

        'Filling tcs tYPE 
        GMod.DataSetRet("select * from TCSMaster Where cmp_id='" & GMod.Cmpid & "' and type =1", "TCSTYPE")
        cmbTcsType.DataSource = GMod.ds.Tables("TCSTYPE")
        cmbTcsType.DisplayMember = "TcsType"



    End Sub
    Private Sub FetchTcsDetilas()
        Dim sql As String
        Try
            sql = "select tcs.*,a.account_head_name from TCsMaster tcs inner join " & GMod.ACC_HEAD & " a on tcs.Acc_code = a.account_code  where TcStype ='" & cmbTcsType.Text & "'"
            GMod.DataSetRet(sql, "tcsdata")

            cmbTcsHead.Text = GMod.ds.Tables("tcsdata").Rows(0)("account_head_name").ToString
            cmbTcsHeadCode.Text = GMod.ds.Tables("tcsdata").Rows(0)("Acc_code").ToString
            txtTcsPer.Text = GMod.ds.Tables("tcsdata").Rows(0)("Per").ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub nxtvno()
        Dim sql As String
        Try
            sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & GMod.VENTRY & " where vou_type='" & cmbVoucherType.Text & "'"
            GMod.DataSetRet(sql, "vno8")
            txtVoucherNo.Text = ds.Tables("vno8").Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If txtVoucherNo.Text = "" Then
            Exit Sub
        End If
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
        'cmbAreaCode.Text = GMod.AreaCode
    End Sub
    Dim total As Double, i As Integer
    Private Sub dgPurchase_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPurchase.CellEndEdit
        For i = 0 To dgPurchase.Rows.Count - 1
            total = total + Val(dgPurchase(4, i).Value)
        Next

        total = 0
        'Dim rate As Double
        'If e.ColumnIndex = 4 Then
        '    If Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
        '        rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value)
        '        dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
        '    ElseIf Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
        '        rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value)
        '        dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
        '    End If
        'ElseIf e.ColumnIndex = 2 Or e.ColumnIndex = 1 Then
        '    If Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
        '        rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value)
        '        dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
        '    ElseIf Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
        '        rate = Val(dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value) / Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value)
        '        dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = Math.Round(rate, 2)
        '    End If
        'End If
        If cmbVoucherType.Text = "OTHER SALE CASH" Then
            For i = 0 To dgPurchase.Rows.Count - 1
                ' dgPurchase(3, i).Value = ""
            Next
        End If
    End Sub

    Private Sub dgPurchase_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPurchase.CellEnter
        'Select Case cmbVoucherType.Text
        '    Case "OTHER SALE CASH", "CHICKS TRANSFER", "OTHER SALE CASH RP", "FEED TRANSFER"
        '        dgPurchase(4, dgPurchase.CurrentCell.RowIndex).ReadOnly = False
        '        dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = ""
        '    Case Else
        Dim amt As Double
        If e.ColumnIndex = 4 Then
            If Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
                amt = Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) * Val(dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value)
                amt = Math.Round(amt, 0, MidpointRounding.AwayFromZero)
                dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value = amt
            Else
                amt = Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value) * Val(dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value)
                amt = Math.Round(amt, 0, MidpointRounding.AwayFromZero)
                dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value = amt
            End If
        End If
        ' End Select
        'If cmbVoucherType.Text <> "OTHER SALE CASH" Or cmbVoucherType.Text <> "CHICKS TRANSFER" Then
        '    Dim amt As Double
        '    If e.ColumnIndex = 4 Then
        '        If Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) > 0 Then
        '            amt = Val(dgPurchase(2, dgPurchase.CurrentCell.RowIndex).Value) * Val(dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value)
        '            amt = Math.Round(amt, 0)
        '            dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value = amt
        '        Else
        '            amt = Val(dgPurchase(1, dgPurchase.CurrentCell.RowIndex).Value) * Val(dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value)
        '            amt = Math.Round(amt, 0)
        '            dgPurchase(4, dgPurchase.CurrentCell.RowIndex).Value = amt
        '        End If
        '    End If
        'Else
        '    dgPurchase(4, dgPurchase.CurrentCell.RowIndex).ReadOnly = False
        '    dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = ""
        'End If
    End Sub
    Private Sub dgPurchase_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPurchase.CellLeave
        Try
            'If e.ColumnIndex = 0 Then
            '    sqldel = "select rate from dbo.Daily_Rate WHERE item_name='" & dgPurchase(0, dgPurchase.CurrentCell.RowIndex).Value & "' and rdate='" & dtInvVate.Value.ToShortDateString & "'"
            '    GMod.DataSetRet(sqldel, "dailyrate")
            '    If GMod.ds.Tables("dailyrate").Rows.Count > 0 Then
            '        dgPurchase(5, dgPurchase.CurrentCell.RowIndex).Value = GMod.ds.Tables("dailyrate").Rows(0)(0)
            '    Else
            '        MsgBox("Please enter markt rate", MsgBoxStyle.Information)
            '        Exit Sub
            '    End If
            'End If
            If cmbVoucherType.Text = "OTHER SALE CASH" Then
                If e.ColumnIndex = 3 Then
                    ' dgPurchase(3, dgPurchase.CurrentCell.RowIndex).Value = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgPurchase_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgPurchase.KeyUp
        If e.KeyCode = Keys.Enter Then
            If dgPurchase.CurrentCell.ColumnIndex < dgPurchase.ColumnCount - 1 Then
                SendKeys.Send("{Tab}")
            Else
                dgPurchase.Rows.Add()
                dgPurchase.CurrentCell = dgPurchase(0, dgPurchase.CurrentCell.RowIndex + 1)
            End If
        End If
    End Sub
    Dim sqldel, sqldel1, sqlsavecr As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Are U sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            If dgPurchase.RowCount = 0 Then
                Me.Close()
                Exit Sub
            End If

            If Val(txtgtotal.Text) = 0 Then
                Me.Close()
                Exit Sub
            End If
            If btnSave.Enabled = False Then
                GMod.Fill_Log(GMod.Cmpid, txtVoucherNo.Text, cmbVoucherType.Text, dtVouDate.Value, Now, GMod.Session, "M", GMod.username)
            End If
            Dim sqlsave As String
            Dim sqltrans As SqlTransaction
            Dim narration, narrcust, narrinv As String
            sqltrans = GMod.SqlConn.BeginTransaction
            Try
                If cmbVoucherType.Text <> "OTHER SALE RET." Then
                    If btnSave.Enabled = False Then
                        sqldel = " delete from " & GMod.VENTRY & " where vou_no='" & txtVoucherNo.Text & "' and vou_type='" & cmbVoucherType.Text & "'"
                        Dim cmd5 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                        cmd5.ExecuteNonQuery()

                        sqldel = " delete from OtherSaledata where vou_no='" & txtVoucherNo.Text & "' and vou_type='" & cmbVoucherType.Text & "' and Session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
                        Dim cmd6 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                        cmd6.ExecuteNonQuery()

                        sqldel = "delete from TdsEntry where vou_type='" & cmbVoucherType.Text & "' and  vou_no='" & txtVoucherNo.Text & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                        Dim cmddel As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                        cmddel.ExecuteNonQuery()
                    Else
                        nxtvno()
                    End If
                    

                    narrinv = "DM No." & txtDmNo.Text & " DT." & dtInvVate.Text & " , INV NO " & txtVoucherNo.Text & " DT." & dtInvVate.Text & " "


                    Dim framt As Double
                    framt = Val(txtFreightamt.Text)


                For i = 0 To dgPurchase.Rows.Count - 1
                    'narration = "INV NO " & txtInvnoNo.Text & " DT." & dtInvVate.Value.ToShortDateString & " BATCH NO " & lblbatchno.Text & " "
                    If dgPurchase(4, i).Value.ToString.Length > 0 Then
                        narration = ""
                        narration &= dgPurchase(0, i).Value
                        If Val(dgPurchase(2, i).Value) > 0 And Val(dgPurchase(1, i).Value) > 0 Then
                            narration &= " " & dgPurchase(2, i).Value & " " & "KG " & dgPurchase(1, i).Value & " NO "
                        ElseIf Val(dgPurchase(1, i).Value) > 0 Then
                            narration &= " " & dgPurchase(1, i).Value & " NO " & dgPurchase(6, i).Value
                        ElseIf Val(dgPurchase(2, i).Value) > 0 And Val(dgPurchase(1, i).Value) = 0 Then
                            narration &= " " & dgPurchase(2, i).Value & " " & "KG " & dgPurchase(1, i).Value & " NO "
                        End If
                        narration &= " @ " & dgPurchase(3, i).Value & "HSN Code" & dgPurchase(5, i).Value
                        narrcust = narrcust & " " & narration

                            sqlsave = " insert into OtherSaledata (Vou_type, Vou_no, AccCode," & _
                            " AccName, Station, ProductName, OutQty, Rate, Amount, OutQtyNos," & _
                            " BillNo, BillDate, InQty, InQtyNos, Cmp_id, Session,mrktrate,authr,Prdunit,Packing, Insurance, Discount,crHead,cgstp, cgsta, sgstp, sgsta, igstp, igsta,tcs_per,tcs_amt,[freight]) values ("
                        sqlsave &= "'" & cmbVoucherType.Text & "',"
                        sqlsave &= "'" & txtVoucherNo.Text & "',"
                        sqlsave &= "'" & cmbacheadcode.Text & "',"
                        sqlsave &= "'" & cmbacheadname.Text & "',"
                        sqlsave &= "'" & cmbAreaName.Text & "',"
                        sqlsave &= "'" & dgPurchase(0, i).Value & "',"
                        sqlsave &= "'" & Val(dgPurchase(2, i).Value) & "',"
                        sqlsave &= "'" & Val(dgPurchase(3, i).Value) & "',"
                        sqlsave &= "'" & Val(dgPurchase(4, i).Value) & "',"
                        sqlsave &= "'" & Val(dgPurchase(1, i).Value) & "',"
                        If cmbVoucherType.Text = "OTHER SALE" Then
                            sqlsave &= "'OS" & txtVoucherNo.Text & "',"
                        ElseIf cmbVoucherType.Text = "OTHER SALE CASH" Then
                            sqlsave &= "'CS" & txtVoucherNo.Text & "',"
                        ElseIf cmbVoucherType.Text = "OTHER SALE MANSAR" Then
                            sqlsave &= "'SM/" & txtVoucherNo.Text & "',"
                        Else
                            sqlsave &= "'" & txtVoucherNo.Text & "',"
                        End If
                        sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "',"
                        sqlsave &= "'0',"
                        sqlsave &= "'" & txtDmNo.Text & "',"
                        sqlsave &= "'" & GMod.Cmpid & "',"
                        sqlsave &= "'" & GMod.Session & "',"
                        sqlsave &= "'" & Val(dgPurchase(5, i).Value) & "',"
                        sqlsave &= "'" & txtAuthorisation.Text & "',"
                        sqlsave &= "'" & cmbprdunit.Text & "',"
                        sqlsave &= "'" & Val(txtpacking.Text) & "',"
                        sqlsave &= "'" & Val(txtinsurance.Text) & "',"
                        sqlsave &= "'" & Val(txtcgstper.Text) & "',"
                        sqlsave &= "'" & cmbSaleAcc.Text & "',"

                        sqlsave &= "'" & Val(txtcgstper.Text) & "',"
                        sqlsave &= "'" & Val(txtcgstamt.Text) & "',"
                        sqlsave &= "'" & Val(txtsgstper.Text) & "',"
                        sqlsave &= "'" & Val(txtsgstamt.Text) & "',"
                        sqlsave &= "'" & Val(txtigstper.Text) & "',"
                        sqlsave &= "'" & Val(txtigstamt.Text) & "',"
                        sqlsave &= "'" & Val(txtTcsPer.Text) & "',"
                            sqlsave &= "'" & Val(txtTcsAmount.Text) & "',"
                            sqlsave &= "'" & framt & "')"


                        Dim cmd1 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                            cmd1.ExecuteNonQuery()

                            framt = 0
                    End If
                Next

                'CUSTOMER A/C Dr
                sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                & " Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " _
                & "Narration, Group_name, Sub_group_name,ch_date) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'0',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'" & cmbVoucherType.Text & "',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbacheadcode.Text & "',"
                sqlsave &= "'" & cmbacheadname.Text & "',"
                    sqlsave &= "'" & Val(txtgtotal.Text) - Val(txtgstamtdr.Text) + Val(txtTcsAmount.Text) & "',"
                sqlsave &= "'0',"
                sqlsave &= "'-',"
                sqlsave &= "'-',"
                sqlsave &= "'" & narrinv & narrcust & "',"
                sqlsave &= "'" & ComboBox1.Text & "',"
                sqlsave &= "'-','" & dtInvVate.Value.ToShortDateString & "')"
                'MsgBox(sqlsave)
                Dim cmd2 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd2.ExecuteNonQuery()


                '
                If Val(txtgstperdr.Text) > 0 Then

                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                    & " Vou_type, Vou_date, Acc_head_code, Acc_head, Cramt, Dramt, Pay_mode, Cheque_no, " _
                    & "Narration, Group_name, Sub_group_name,Ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'3',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbcodegstdr.Text & "',"
                    sqlsave &= "'" & cmbgstheaddr.Text & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'" & Val(txtgstamtdr.Text) & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narrcust & "',"
                    sqlsave &= "'" & ComboBox9.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If


                sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                & " Vou_type, Vou_date, Acc_head_code, Acc_head, cramt, dramt, Pay_mode, Cheque_no, " _
                & " Narration, Group_name, Sub_group_name,ch_date) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'0',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'" & cmbVoucherType.Text & "',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbSaleAccCode.Text & "',"
                sqlsave &= "'" & cmbSaleAcc.Text & "',"
                sqlsave &= "'" & Val(TextBox4.Text) & "',"
                sqlsave &= "'0',"
                sqlsave &= "'-',"
                sqlsave &= "'-',"
                sqlsave &= "'" & narrinv & narrcust & "',"
                sqlsave &= "'" & cmbSaleAccCode.SelectedValue & "',"
                sqlsave &= "'-','" & dtInvVate.Value.ToShortDateString & "')"
                Dim cmd3 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd3.ExecuteNonQuery()


                If Val(txtpacking.Text) > 0 Then
                        sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                    & " Vou_type, Vou_date, Acc_head_code, Acc_head, Cramt, Dramt, Pay_mode, Cheque_no, " _
                    & "Narration, Group_name, Sub_group_name,Ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'2',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbpackingcode.Text & "',"
                    sqlsave &= "'" & cmbpackinghead.Text & "',"
                    sqlsave &= "'" & Val(txtpacking.Text) & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narrcust & "',"
                    sqlsave &= "'" & ComboBox4.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()

                End If


                If Val(txtinsurance.Text) > 0 Then

                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                 & " Vou_type, Vou_date, Acc_head_code, Acc_head, Cramt, Dramt, Pay_mode, Cheque_no, " _
                 & "Narration, Group_name, Sub_group_name,Ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'3',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbinsurancecode.Text & "',"
                    sqlsave &= "'" & cmbinsurancehead.Text & "',"
                    sqlsave &= "'" & Val(txtinsurance.Text) & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narrcust & "',"
                    sqlsave &= "'" & ComboBox5.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If

                'Freight amount Cr
                If Val(txtFreightamt.Text) > 0 Then

                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                 & " Vou_type, Vou_date, Acc_head_code, Acc_head, Cramt, Dramt, Pay_mode, Cheque_no, " _
                 & "Narration, Group_name, Sub_group_name,Ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'3',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmdFreightCode.Text & "',"
                    sqlsave &= "'" & cmbFreightac.Text & "',"
                    sqlsave &= "'" & Val(txtFreightamt.Text) & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narrcust & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If


                If Val(txtcgstper.Text) > 0 Then

                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                 & " Vou_type, Vou_date, Acc_head_code, Acc_head, Cramt, Dramt, Pay_mode, Cheque_no, " _
                 & "Narration, Group_name, Sub_group_name,Ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'3',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbothercode.Text & "',"
                    sqlsave &= "'" & cmbother.Text & "',"
                    sqlsave &= "'" & Val(txtcgstamt.Text) & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narrcust & "',"
                    sqlsave &= "'" & ComboBox6.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If



                If Val(txtsgstper.Text) > 0 Then
                        sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                 & " Vou_type, Vou_date, Acc_head_code, Acc_head, Cramt, Dramt, Pay_mode, Cheque_no, " _
                 & "Narration, Group_name, Sub_group_name,Ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'3',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbsgstcode.Text & "',"
                    sqlsave &= "'" & cmbsgsthead.Text & "',"
                    sqlsave &= "'" & Val(txtsgstamt.Text) & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narrcust & "',"
                    sqlsave &= "'" & ComboBox7.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If



                If Val(txtigstper.Text) > 0 Then
                    'Vat Dr
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                 & " Vou_type, Vou_date, Acc_head_code, Acc_head, Cramt, Dramt, Pay_mode, Cheque_no, " _
                 & "Narration, Group_name, Sub_group_name,Ch_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'3',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbigstcode.Text & "',"
                    sqlsave &= "'" & cmbigsthead.Text & "',"
                    sqlsave &= "'" & Val(txtigstamt.Text) & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narrcust & "',"
                    sqlsave &= "'" & ComboBox8.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If
                Dim ssaveprdvntry As String
                'Inserting TCS tax amount in the Voucher entry Credit 
                If Val(txtTcsAmount.Text) > 0 Then
                    ssaveprdvntry = "insert into " & GMod.VENTRY & " (Cmp_id, Uname," _
                    & "Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt," _
                    & " Narration, Group_name, Sub_group_name,ch_date) VALUES ("
                    ssaveprdvntry &= "'" & GMod.Cmpid & "',"
                    ssaveprdvntry &= "'" & GMod.username & "',"
                    ssaveprdvntry &= "'" & i + 1 & "',"
                    ssaveprdvntry &= "'" & txtVoucherNo.Text & "',"
                    ssaveprdvntry &= "'" & cmbVoucherType.Text & "',"
                    ssaveprdvntry &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    ssaveprdvntry &= "'" & cmbTcsHeadCode.Text & "',"
                    ssaveprdvntry &= "'" & cmbTcsHead.Text & "',"
                    ssaveprdvntry &= "'" & Val("") & "',"
                    ssaveprdvntry &= "'" & Val(txtTcsAmount.Text) & "',"
                    ssaveprdvntry &= "'" & narrinv & narrcust & "',"
                    ssaveprdvntry &= "'',"
                    ssaveprdvntry &= "'','" & dtVouDate.Value.ToShortDateString & "')"
                    'MsgBox(ssaveprdvntry)
                    'MsgBox(GMod.SqlExecuteNonQuery(ssaveprdvntry))
                    Dim cmdTcstaxentry As New SqlCommand(ssaveprdvntry, GMod.SqlConn, sqltrans)
                    cmdTcstaxentry.ExecuteNonQuery()



                    'Insert into TCS Report
                    sql = "insert into TdsEntry(Vou_Type, Vou_no, TdsType, Per, TdsDate, " _
                                  & " BilltyNo, BilltyDt, VehicleNo, Qty, Prd, Paidamt," _
                                  & " Actualamt, session,Paidto,vou_date, TdsAmt,dcode,cmp_id,taxtype ) values( "
                    sql &= "'" & cmbVoucherType.Text & "',"
                    sql &= "'" & txtVoucherNo.Text & "',"
                    sql &= "'" & cmbTcsType.Text & "',"
                    sql &= "'" & txtTcsPer.Text & "',"
                    sql &= "'" & dtInvVate.Value.ToShortDateString & "',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'-',"
                    sql &= "'0',"
                    sql &= "'" & Val(txtgtotal.Text) & "',"
                    sql &= "'" & Val("") & "',"
                    sql &= "'" & GMod.Session & "',"
                    sql &= "'YES',"
                    sql &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sql &= "'" & Val(txtTcsAmount.Text) & "',"
                    sql &= "'" & cmbacheadcode.Text & "',"
                    sql &= "'" & GMod.Cmpid & "','1')"

                    Dim cmdTcsReport As New SqlCommand(sql, SqlConn, sqltrans)
                    cmdTcsReport.ExecuteNonQuery()

                End If

                sqltrans.Commit()
                MsgBox("Voucher NO. " & txtVoucherNo.Text & " Saved ...", MsgBoxStyle.Information)
                dgPurchase.Rows.Clear()
                txtInvnoNo.Focus()

                dgPurchase.Rows.Add()
                txtgtotal.Text = ""
                DataGridView1.Rows.Clear()
                txtinsurance.Text = "0"
                txtpacking.Text = "0"
                txtcgstper.Text = "0"
                txtTcsAmount.Text = "0"
                chKtcs.Checked = False
                ''*************************
                ElseIf cmbVoucherType.Text = "OTHER SALE RET." Then
                'saving other sale return data
                If btnSave.Enabled = False Then
                    sqldel = " delete from " & GMod.VENTRY & " where vou_no='" & txtVoucherNo.Text & "' and vou_type='" & cmbVoucherType.Text & "'"
                    Dim cmd5 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmd5.ExecuteNonQuery()

                    sqldel = " delete from OtherSaledata where vou_no='" & txtVoucherNo.Text & "' and vou_type='" & cmbVoucherType.Text & "' and Session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
                    Dim cmd6 As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmd6.ExecuteNonQuery()

                    sqldel = "delete from Sale_Receipt where vou_type='" & cmbVoucherType.Text & "' and  vou_no='" & txtVoucherNo.Text & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
                    Dim cmddel As New SqlCommand(sqldel, GMod.SqlConn, sqltrans)
                    cmddel.ExecuteNonQuery()
                Else
                    nxtvno()
                End If
                Dim framt As Double
                narrinv = "DM No." & txtDmNo.Text & ", INV NO " & txtVoucherNo.Text & " DT." & dtInvVate.Value.ToShortDateString & " "
                framt = Val(txtFreightamt.Text)
                For i = 0 To dgPurchase.Rows.Count - 1
                    'narration = "INV NO " & txtInvnoNo.Text & " DT." & dtInvVate.Value.ToShortDateString & " BATCH NO " & lblbatchno.Text & " "
                    If Val(dgPurchase(4, i).Value) > 0 Then
                        narration = ""
                        narration &= dgPurchase(0, i).Value
                        If Val(dgPurchase(2, i).Value) > 0 And Val(dgPurchase(1, i).Value) > 0 Then
                            narration &= " " & dgPurchase(2, i).Value & " " & "KG " & dgPurchase(1, i).Value & " NO "
                        ElseIf Val(dgPurchase(1, i).Value) > 0 Then
                            narration &= " " & dgPurchase(1, i).Value & " NO "
                        ElseIf Val(dgPurchase(2, i).Value) > 0 And Val(dgPurchase(1, i).Value) = 0 Then
                            narration &= " " & dgPurchase(2, i).Value & " " & "KG " & dgPurchase(1, i).Value & " NO "
                        End If
                        narration &= " @ " & dgPurchase(3, i).Value
                        narrcust = narrcust & " " & narration


                        sqlsave = "insert into OtherSaledata (Vou_type, Vou_no, AccCode," & _
                        "AccName, Station, ProductName, OutQty, Rate, Amount, OutQtyNos," & _
                        "BillNo, BillDate, InQty, InQtyNos, Cmp_id, Session,mrktrate,authr,Prdunit,[freight] ) values ("
                        sqlsave &= "'" & cmbVoucherType.Text & "',"
                        sqlsave &= "'" & txtVoucherNo.Text & "',"
                        sqlsave &= "'" & cmbacheadcode.Text & "',"
                        sqlsave &= "'" & cmbacheadname.Text & "',"
                        sqlsave &= "'" & cmbAreaName.Text & "',"
                        sqlsave &= "'" & dgPurchase(0, i).Value & "',"
                        sqlsave &= "'" & Val(dgPurchase(2, i).Value) & "',"
                        sqlsave &= "'" & Val(dgPurchase(3, i).Value) & "',"
                        sqlsave &= "'" & Val(dgPurchase(4, i).Value) & "',"
                        sqlsave &= "'" & Val(dgPurchase(1, i).Value) & "',"
                        sqlsave &= "'" & txtVoucherNo.Text & "',"
                        sqlsave &= "'" & dtInvVate.Value.ToShortDateString & "',"
                        sqlsave &= "'0',"
                        sqlsave &= "'" & Val(txtDmNo.Text) & "',"
                        sqlsave &= "'" & GMod.Cmpid & "',"
                        sqlsave &= "'" & GMod.Session & "',"
                        sqlsave &= "'" & Val(dgPurchase(5, i).Value) & "',"
                        sqlsave &= "'" & txtAuthorisation.Text & "',"
                        sqlsave &= "'" & cmbprdunit.Text & "',"
                        sqlsave &= "'" & framt & "')"

                        Dim cmd1 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                        cmd1.ExecuteNonQuery()

                        framt = 0
                    End If
                Next
                framt = 0
                'CUSTOMER A/C cr
                sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                & " Vou_type, Vou_date, Acc_head_code, Acc_head, Cramt, Dramt, Pay_mode, Cheque_no, " _
                & "Narration, Group_name, Sub_group_name) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'5',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'" & cmbVoucherType.Text & "',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbacheadcode.Text & "',"
                sqlsave &= "'" & cmbacheadname.Text & "',"
                sqlsave &= "'" & txtgtotal.Text & "',"
                sqlsave &= "'0',"
                sqlsave &= "'-',"
                sqlsave &= "'-',"
                sqlsave &= "'" & narrinv & narrcust & "',"
                sqlsave &= "'" & ComboBox1.Text & "',"
                sqlsave &= "'-')"
                'MsgBox(sqlsave)
                Dim cmd2 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd2.ExecuteNonQuery()

                'SALE DR
                sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                & " Vou_type, Vou_date, Acc_head_code, Acc_head, Dramt, Cramt, Pay_mode, Cheque_no, " _
                & " Narration, Group_name, Sub_group_name) values ("
                sqlsave &= "'" & GMod.Cmpid & "',"
                sqlsave &= "'" & GMod.username & "',"
                sqlsave &= "'4',"
                sqlsave &= "'" & txtVoucherNo.Text & "',"
                sqlsave &= "'" & cmbVoucherType.Text & "',"
                sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                sqlsave &= "'" & cmbSaleAccCode.Text & "',"
                sqlsave &= "'" & cmbSaleAcc.Text & "',"
                sqlsave &= "'" & Val(TextBox4.Text) & "',"
                sqlsave &= "'0.00',"
                sqlsave &= "'-',"
                sqlsave &= "'-',"
                sqlsave &= "'" & narrinv & narration & "',"
                sqlsave &= "'" & cmbSaleAccCode.SelectedValue & "',"
                sqlsave &= "'-')"
                Dim cmd3 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                cmd3.ExecuteNonQuery()


                If Val(txtpacking.Text) > 0 Then
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                 & " Vou_type, Vou_date, Acc_head_code, Acc_head, Dramt, Cramt, Pay_mode, Cheque_no, " _
                 & " Narration, Group_name, Sub_group_name,Ch_issue_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'3',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbpackingcode.Text & "',"
                    sqlsave &= "'" & cmbpackinghead.Text & "',"
                    sqlsave &= "'" & Val(txtpacking.Text) & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narration & "',"
                    sqlsave &= "'" & ComboBox4.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & CDate("1/1/2000") & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If

                If Val(txtinsurance.Text) > 0 Then
                    'Vat Dr
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                    & " Vou_type, Vou_date, Acc_head_code, Acc_head, Dramt,Cramt, Pay_mode, Cheque_no, " _
                    & "Narration, Group_name, Sub_group_name,Ch_issue_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'2',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbinsurancecode.Text & "',"
                    sqlsave &= "'" & cmbinsurancehead.Text & "',"
                    sqlsave &= "'" & Val(txtinsurance.Text) & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narration & "',"
                    sqlsave &= "'" & ComboBox5.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & CDate("1/1/2000") & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If
                If Val(txtcgstper.Text) > 0 Then
                    'Vat Dr
                    sqlsave = "insert into " & GMod.VENTRY & " (Cmp_id, Uname, Entry_id, Vou_no," _
                    & " Vou_type, Vou_date, Acc_head_code, Acc_head, Dramt, Cramt, Pay_mode, Cheque_no, " _
                    & " Narration, Group_name, Sub_group_name,Ch_issue_date) values ("
                    sqlsave &= "'" & GMod.Cmpid & "',"
                    sqlsave &= "'" & GMod.username & "',"
                    sqlsave &= "'3',"
                    sqlsave &= "'" & txtVoucherNo.Text & "',"
                    sqlsave &= "'" & cmbVoucherType.Text & "',"
                    sqlsave &= "'" & dtVouDate.Value.ToShortDateString & "',"
                    sqlsave &= "'" & cmbothercode.Text & "',"
                    sqlsave &= "'" & cmbother.Text & "',"
                    sqlsave &= "'0',"
                    sqlsave &= "'" & Val(txtcgstper.Text) & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & narrinv & narration & "',"
                    sqlsave &= "'" & ComboBox6.Text & "',"
                    sqlsave &= "'-',"
                    sqlsave &= "'" & CDate("1/1/2000") & "')"
                    Dim cmd4 As New SqlCommand(sqlsave, GMod.SqlConn, sqltrans)
                    cmd4.ExecuteNonQuery()
                End If

                    sqltrans.Commit()
                MsgBox("Voucher No. " & txtVoucherNo.Text & " Saved ...", MsgBoxStyle.Information)
                dgPurchase.Rows.Clear()
                txtInvnoNo.Focus()

                dgPurchase.Rows.Add()
                txtgtotal.Text = ""
                DataGridView1.Rows.Clear()
                txtinsurance.Text = "0"
                txtpacking.Text = "0"
                txtcgstper.Text = "0"
                txtTcsAmount.Text = "0"
                framt = 0
                txtFreightamt.Text = "0"
                ''*************************
                End If
                txtpacking_Leave(sender, e)
                txtinsurance_Leave(sender, e)
                txtother_Leave(sender, e)

            Catch ex As Exception
x1:
                MsgBox(ex.Message)
                sqltrans.Rollback()
            Finally
                'frmPurchaseChicken_Load(sender, e)
            End Try
        End If
    End Sub
    Dim k As Integer
    'Dim mdfy As Boolean
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        'MessageBox.Show("Set Voucher date", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Try
            'mdfy = True
            Dim vou_no As String
            Dim sql As String
            Dim sqlinv As String, i As Integer
            If btnSave.Enabled = True Then
                'vou_no = InputBox("Entry voucher Number to modify?")
                vou_no = InputBox("Enter Voucher No.")

                If vou_no <> "" Then

                    'If LockDataCheck(vou_no, GMod.Session, "OTHER SALE") = False Then
                    '    ' MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    'Exit Sub
                    'End If
                    sqlinv = "select * from OtherSaledata where Vou_no='" & vou_no & "' and Vou_type='" & cmbVoucherType.Text & "' and Session='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "' and authr='-'"
                    GMod.DataSetRet(sqlinv, "inv")
                    'Cmp_id, Uname, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, 
                    'ItemName, Qty, QtyNos, Unit, Rate, Amount, Free_Qty, BillType, BillNo,
                    'BillDate, AreaCode, Free_Per, Hatch_date, BatchNo

                    cmbacheadcode.Text = GMod.ds.Tables("inv").Rows(0)("AccCode")
                    ' cmbacheadname.Text = GMod.ds.Tables("inv").Rows(0)("Acc_head")
                    txtInvnoNo.Text = GMod.ds.Tables("inv").Rows(0)("BillNo")
                    dtInvVate.Value = CDate(GMod.ds.Tables("inv").Rows(0)("BillDate").ToString)
                    txtVoucherNo.Text = vou_no
                    dtVouDate.MinDate = CDate(GMod.ds.Tables("inv").Rows(0)("BillDate").ToString)
                    dtVouDate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
                    ' dtVouDate.Value = CDate(GMod.ds.Tables("inv").Rows(0)("BillDate").ToString)

                    cmbAreaCode.Text = GMod.ds.Tables("inv").Rows(0)("Station")
                    txtAuthorisation.Text = GMod.ds.Tables("inv").Rows(0)("authr")
                    txtDmNo.Text = GMod.ds.Tables("inv").Rows(0)("InqtyNos")
                    'Vou_type, Vou_no, AccCode, AccName, 
                    'Station, ProductName, OutQty, Rate, Amount, 
                    'OutQtyNos, BillNo, BillDate, InQty, InQtyNos, Cmp_id, Session, id
                    cmbprdunit.Text = GMod.ds.Tables("inv").Rows(0)("PrdUnit")

                    For i = 0 To GMod.ds.Tables("inv").Rows.Count - 1
                        dgPurchase.Rows.Add()
                        ' dgPurchase(0, i).Value = GMod.ds.Tables("inv").Rows(i)("ProductName")
                        dgPurchase(1, i).Value = GMod.ds.Tables("inv").Rows(i)("OutQtyNos")
                        dgPurchase(2, i).Value = GMod.ds.Tables("inv").Rows(i)("OutQty")
                        dgPurchase(3, i).Value = GMod.ds.Tables("inv").Rows(i)("Rate")
                        dgPurchase(4, i).Value = GMod.ds.Tables("inv").Rows(i)("Amount")
                        dgPurchase(5, i).Value = GMod.ds.Tables("inv").Rows(i)("mrktrate")

                    Next
                    dgPurchase.Rows.RemoveAt(i)

                    btnModify.Text = "&Update"
                    btnSave.Enabled = False

                    dgPurchase_Leave(sender, e)
                End If

                sql = "select acc_head_code,vou_date from " & GMod.VENTRY & " where vou_no='" & txtVoucherNo.Text & "' and vou_type='" & cmbVoucherType.Text & "' and cramt>0"
                GMod.DataSetRet(sql, "cramt")
                cmbSaleAccCode.Text = GMod.ds.Tables("cramt").Rows(0)(0).ToString
                dtVouDate.Value = CDate(GMod.ds.Tables("cramt").Rows(0)("vou_date").ToString)

                sql = "select ref_type,ref,dueon, cr from Sale_Receipt where vou_type='" & cmbVoucherType.Text & "' and  vou_no='" & vou_no & "' and session ='" & GMod.Session & "'"
                dg.Visible = False
                GMod.DataSetRet(sql, "mfy")
                If GMod.ds.Tables("mfy").Rows.Count > 0 Then
                    For k = 0 To GMod.ds.Tables("mfy").Rows.Count - 1
                        DataGridView1.Rows.Add()
                        DataGridView1(0, k).Value = GMod.ds.Tables("mfy").Rows(k)(0)
                        DataGridView1(1, k).Value = GMod.ds.Tables("mfy").Rows(k)(1)
                        DataGridView1(2, k).Value = GMod.ds.Tables("mfy").Rows(k)(2)
                        DataGridView1(3, k).Value = GMod.ds.Tables("mfy").Rows(k)(3)
                    Next
                End If
            Else
                btnSave_Click(sender, e)
                btnModify.Text = "&Modify"
                btnSave.Enabled = True
            End If
            txtgtotal.Focus()
            txtFreightamt.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub txtgtotal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgtotal.Enter
        ''dgPurchase_CellLeave(sender, e)
        'If btnSave.Enabled = False Then
        '    For i = 0 To dgPurchase.Rows.Count - 1
        '        total = total + Val(dgPurchase(4, i).Value)
        '    Next
        '    txtgtotal.Text = total.ToString
        '    'total = 0
        'End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim vou_no As String
        vou_no = InputBox("Entry voucher Number to modify?")
        If MessageBox.Show("Want to Delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            If vou_no <> "" Then

                If LockDataCheck(vou_no, GMod.Session, "SALE") = False Then
                    MessageBox.Show("Duration Exceeds Than The Changing Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                GMod.Fill_Log(GMod.Cmpid, vou_no, "SALE", dtVouDate.Value, Now, GMod.Session, "M", GMod.username)
                Dim sqldel, sqldel1 As String
                sqldel = "delete from " & GMod.VENTRY & " where vou_no='" & vou_no & "' and vou_type='SALE'"
                GMod.SqlExecuteNonQuery(sqldel)

                sqldel1 = "delete from InvPhxChicken where vou_no='" & vou_no & "' and vou_type='SALE' and Session='" & GMod.Session & "'"
                MsgBox(GMod.SqlExecuteNonQuery(sqldel1))

            End If
            nxtvno()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t1 As New frmPartyaccount
        Dim sql As String
        sql = "select Group_name,Suffix from Groups where Group_name like '%PARTY%' and Cmp_id='" & GMod.Cmpid & "' and session = '" & GMod.Session & "'"
        GMod.DataSetRet(sql, "Suffix")

        t1.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t1.lblgroupname.DisplayMember = "Group_name"

        t1.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t1.lblgroupsuffix.DisplayMember = "Suffix"
        t1.lblgroupsuffix.Text = "PA"
        t1.Label1.Text = "Party Account Heads"
        t1.ShowDialog()

        heads()
    End Sub

    Private Sub ChknewCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmPartyaccount
        Dim sql As String
        sql = "select Group_name,Suffix from Groups where Group_name like '%CUSTOMER%' and Cmp_id='" & GMod.Cmpid & "'  and session = '" & GMod.Session & "'"
        GMod.DataSetRet(sql, "Suffix")

        t.lblgroupname.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupname.DisplayMember = "Group_name"

        t.lblgroupsuffix.DataSource = GMod.ds.Tables("Suffix")
        t.lblgroupsuffix.DisplayMember = "Suffix"

        t.Label1.Text = "Customer Account Heads"
        t.ShowDialog()

        heads()
    End Sub
    Public Sub heads()
        Dim sql As String
        ' sql = " select account_head_name,account_code,group_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and group_name in('CUSTOMER','IMPREST','INTERNAL PARTY','COLLECTION','CASH COLLECTION','CASH COLL','AREA MANAGER','EXPENSES','CUSTOMER')   and left(account_code,2) in('" & cmbAreaCode.Text & "','**')  OR (account_head_name LIKE '%TRANSFER%') or (Group_name LIKE '%BROILER EXPS%')"

        sql = " select account_head_name,account_code,group_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "' and left(account_code,2) in ('" & cmbAreaCode.Text & "','**')  "


        GMod.DataSetRet(sql, "A1")
        cmbacheadname.DataSource = GMod.ds.Tables("A1")
        cmbacheadname.DisplayMember = "account_head_name"

        cmbacheadcode.DataSource = GMod.ds.Tables("A1")
        cmbacheadcode.DisplayMember = "account_code"

        ComboBox1.DataSource = GMod.ds.Tables("A1")
        ComboBox1.DisplayMember = "group_name"

        'Filling item list
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tg As New frmGeneralacchead
        tg.ShowDialog()
        heads()
    End Sub

    Private Sub cmbVoucherType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbVoucherType.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbVoucherType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVoucherType.SelectedIndexChanged
        'nxtvno()
        Label16.Text = cmbVoucherType.Text
    End Sub

    Private Sub txtgtotal_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgtotal.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtgtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgtotal.TextChanged

    End Sub

    Private Sub dgPurchase_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPurchase.Leave

        For i = 0 To dgPurchase.Rows.Count - 1
            total = total + Val(dgPurchase(4, i).Value)
        Next

        txtgtotal.Text = total.ToString
        TextBox4.Text = total.ToString
        total = 0
    End Sub
    Sub CALCSUM()
        For i = 0 To dgPurchase.Rows.Count - 1
            total = total + Val(dgPurchase(4, i).Value)
        Next

        txtgtotal.Text = total.ToString
        total = 0
    End Sub

    Private Sub txtInvnoNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInvnoNo.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtInvnoNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInvnoNo.TextChanged

    End Sub

    Private Sub dtInvVate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtInvVate.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

 

    Private Sub txtVoucherNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoucherNo.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtVoucherNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoucherNo.TextChanged

    End Sub

    Private Sub dtVouDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbacheadname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbacheadcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadcode.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbacheadcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadcode.Leave

        sql = "select account_code from " & GMod.ACC_HEAD & " where account_head_name = '" & cmbacheadname.Text & "' and  Area_code ='" & cmbAreaCode.Text & "'"
        GMod.DataSetRet(sql, "account_codeexpenses")
        If GMod.ds.Tables("account_codeexpenses").Rows.Count > 0 Then
            If cmbacheadcode.Text.Trim <> GMod.ds.Tables("account_codeexpenses").Rows(0)(0) Then
                MsgBox("A/c Name and Code are Different", MsgBoxStyle.Information)
                cmbacheadcode.Focus()
                Exit Sub
            End If
        Else
            cmbacheadname.Focus()
            Exit Sub
        End If
        sql = "select *  from tmpAging where acc_code ='" & cmbacheadcode.Text & "' and vou_type='" & cmbVoucherType.Text & "' and cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "jj")
        If GMod.ds.Tables("jj").Rows.Count > 0 Then
            MsgBox("Please selecr diffent head")
            Me.Close()
            Exit Sub
        End If

        GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='" & cmbVoucherType.Text & "' and cmp_id='" & GMod.Cmpid & "'")
        'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
        sql = "insert into  tmpAging (Ref_Type, Ref, Acc_Code,cr,vou_type,cmp_id) " & _
              " select Ref_type,Ref,acc_code,sum(cr)-sum(dr) Amount,'" & cmbVoucherType.Text & "',cmp_id  " & _
              " from Sale_Receipt group by Ref,acc_code,Ref_type,cmp_id having sum(cr)-sum(dr)>0 " & _
              " and acc_code='" & cmbacheadcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
        GMod.SqlExecuteNonQuery(sql)
        'cmbRefType_Leave(sender, e)



        Try
            GMod.DataSetRet("select sum(dramt) from " & GMod.VENTRY & " where acc_head_code = '" & cmbacheadcode.Text & "'", "tcsamtcheck")
            If Val(GMod.ds.Tables("tcsamtcheck").Rows(0)(0)) >= 5000000 Then
                MsgBox("Customer Eligible for TCS...")
            End If

            '

            GMod.DataSetRet("select pan_no from " & GMod.ACC_HEAD & "  where account_code = '" & cmbacheadcode.Text & "'", "cuspanno")
            If GMod.ds.Tables("cuspanno").Rows(0)(0).ToString.Length > 8 Then
                lblpan.Text = GMod.ds.Tables("cuspanno").Rows(0)(0).ToString
            Else
                lblpan.Text = "PAN Not Available"
            End If
        Catch ex As Exception
            lblpan.Text = "PAN Not Available"
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbSaleAcc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSaleAcc.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbSaleAccCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSaleAccCode.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbSaleAccCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSaleAccCode.SelectedIndexChanged

    End Sub

    Private Sub txtAuthorisation_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAuthorisation.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtAuthorisation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAuthorisation.TextChanged

    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAreaName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.SelectedIndexChanged

    End Sub
    Dim sql As String
    Private Sub cmbRefType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRefType.Leave
        'MsgBox(cmbRefType.Text)
        'MsgBox(cmbRefType.SelectedIndex)
        If cmbRefType.Text = "Ags Ref" Then
            sql = "select Ref,sum(cr)-sum(dr) Amount,acc_code from tmpAging group by Ref,acc_code,vou_type,cmp_id having sum(cr)-sum(dr)>0  and acc_code='" & cmbacheadcode.Text & "' and cmp_id='" & GMod.Cmpid & "' and vou_type='" & cmbVoucherType.Text & "'"
            GMod.DataSetRet(sql, "aging")
            If GMod.ds.Tables("aging").Rows.Count > 0 Then
                dg.DataSource = GMod.ds.Tables("aging")
                dg.Visible = True
                dg.Focus()
            End If
        End If
    End Sub

    Private Sub cmbRefType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(cmbRefType.Text)
    End Sub
    Dim j As Integer = -1
    Dim vouno As Long
    Dim ddate As DateTime = CDate("1/1/2000")
    Dim cr As Double = 0.0
    Dim pv As Double = 0.0
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtduedate.Text = "" Then
            txtduedate.Text = Format(ddate, "MM/dd/yyyy")
        End If
        Dim obj() As Object = {cmbRefType.Text, txtref.Text, txtduedate.Text, txtamount.Text}
        If j <> -1 Then
            DataGridView1.Rows.RemoveAt(j)
            DataGridView1.Rows.Insert(j, obj)
        Else
            DataGridView1.Rows.Add(obj)


        End If

        sqlsavecr = "insert into  tmpAging (Ref_Type, Ref, Acc_Code, Vou_Type," & _
        " Vou_No, Vou_Date, cr, dr, dueon, Session,usename,id,cmp_id) values( "
        sqlsavecr &= "'" & cmbRefType.Text & "',"
        sqlsavecr &= "'" & txtref.Text & "',"
        sqlsavecr &= "'" & cmbacheadcode.Text & "',"
        sqlsavecr &= "'" & cmbVoucherType.Text & "',"
        sqlsavecr &= "'" & vouno & "',"
        sqlsavecr &= "'" & dtVouDate.Value.ToShortDateString & "',"
        sqlsavecr &= "'" & Val("") & "',"
        sqlsavecr &= "'" & Val(txtamount.Text) & "',"
        sqlsavecr &= "'" & CDate(txtduedate.Text).ToShortDateString & "',"
        sqlsavecr &= "'" & GMod.Session & "',"
        sqlsavecr &= "'" & GMod.username & "',"
        sqlsavecr &= "'" & DataGridView1.CurrentCell.RowIndex & "',"
        sqlsavecr &= "'" & GMod.Cmpid & "')"

        GMod.SqlExecuteNonQuery(sqlsavecr)

        'If cr <> Val(dg(0, 4).Value) Then
        '    cmbRefType.Focus()
        'Else
        '    btnsave.Focus()
        'End If
        'cmbRefType.SelectedIndex = 0
        txtref.Clear()
        txtduedate.Clear()
        txtamount.Clear()
        j = -1

    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Escape Then
            txtref.Text = dg(0, dg.CurrentCell.RowIndex).Value
            txtamount.Text = dg(1, dg.CurrentCell.RowIndex).Value
            dg.Visible = False
            txtamount.Focus()
        End If
    End Sub

    Private Sub cmbprdunit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbprdunit.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbprdunit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbprdunit.Leave
        If cmbprdunit.FindStringExact(cmbprdunit.Text) = -1 Then
            cmbprdunit.Focus()
            Exit Sub
        Else
        End If
    End Sub

    Private Sub cmbprdunit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprdunit.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs)
        Try
            If btnSave.Enabled = True Then
                MsgBox(GMod.SqlExecuteNonQuery("delete from tmpAging where ci = '" & DataGridView1.CurrentCell.RowIndex & "' and usename ='" & GMod.username & "'"))
            Else
                sql = "select id from Sale_Receipt where ref_type='" & DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value & "' and ref='" & DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value & "' and vou_no='" & txtVoucherNo.Text & "' and cr='" & DataGridView1(3, DataGridView1.CurrentCell.RowIndex).Value & "'"
                GMod.DataSetRet(sql, "delSale_Receipt")

                sql = "delete from Sale_Receipt where id ='" & GMod.ds.Tables("delSale_Receipt").Rows(0)(0).ToString & "'"
                GMod.SqlExecuteNonQuery(sql)

                GMod.SqlExecuteNonQuery("delete from tmpAging where ci = '" & DataGridView1.CurrentCell.RowIndex & "' and usename ='" & GMod.username & "'")
            End If
            GMod.SqlExecuteNonQuery("delete from tmpAging where acc_code='" & cmbacheadcode.Text & "' and vou_type='" & cmbVoucherType.Text & "' and cmp_id='" & GMod.Cmpid & "'")
            'sql = "insert into tmpAging select *,'" & GMod.username & "' u,-1 from Sale_Receipt where acc_code='" & cmbcode.Text & "' and session='" & GMod.Session & "' and dr>0"
            sql = "insert into  tmpAging (Ref_Type, Ref, Acc_Code,cr,vou_type,cmp_id) " & _
                  " select Ref_type,Ref,acc_code,sum(cr)-sum(dr) Amount,'" & cmbVoucherType.Text & "',cmp_id  " & _
                  " from Sale_Receipt group by Ref,acc_code,Ref_type,cmp_id having sum(cr)-sum(dr)>0 " & _
                  " and acc_code='" & cmbacheadcode.Text & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.SqlExecuteNonQuery(sql)
            cmbRefType.SelectedIndex = 0
            cmbRefType.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprint.Click
        Dim tosp As New frmOtherSalePrintInvoice
        tosp.ShowDialog()
    End Sub

    Private Sub chklock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbAreaCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaCode.SelectedIndexChanged
        heads()
    End Sub

    Private Sub txtDmNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDmNo.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDmNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDmNo.TextChanged

    End Sub

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            'e.Handled = True
            'MsgBox("Invalid Charchter")
        End If
    End Sub

    Private Sub txtpacking_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpacking.Leave
        If Val(txtpacking.Text) > 0 Then
            Dim Sqlvat As String
            Sqlvat = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sqlvat, "A3")
            cmbpackinghead.DataSource = GMod.ds.Tables("A3")
            cmbpackinghead.DisplayMember = "account_head_name"

            cmbpackingcode.DataSource = GMod.ds.Tables("A3")
            cmbpackingcode.DisplayMember = "account_code"

            ComboBox4.DataSource = GMod.ds.Tables("A3")
            ComboBox4.DisplayMember = "group_name"

            cmbpackinghead.Text = "EGG PACKING CHARGES"
        Else
            cmbpackinghead.Text = "-"
            cmbpackingcode.Text = "-"
            ComboBox4.Text = "-"
        End If
    End Sub
    Private Sub txtpacking_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpacking.TextChanged
        CALCSUM()
        txtgtotal.Text = Val(txtcgstper.Text) + Val(txtpacking.Text) + Val(txtinsurance.Text) + Val(txtgtotal.Text) + Val(txtFreightamt.Text)
    End Sub

    Private Sub txtinsurance_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinsurance.Leave
        If Val(txtinsurance.Text) > 0 Then
            Dim Sqlvat As String
            Sqlvat = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sqlvat, "A4")
            cmbinsurancehead.DataSource = GMod.ds.Tables("A4")
            cmbinsurancehead.DisplayMember = "account_head_name"

            cmbinsurancecode.DataSource = GMod.ds.Tables("A4")
            cmbinsurancecode.DisplayMember = "account_code"

            ComboBox5.DataSource = GMod.ds.Tables("A4")
            ComboBox5.DisplayMember = "group_name"

            cmbinsurancehead.Text = "TRANSIT EGGS INSURANCE"
        Else
            cmbinsurancehead.Text = "-"
            cmbinsurancecode.Text = "-"
            ComboBox5.Text = "-"
        End If
    End Sub

    Private Sub txtinsurance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinsurance.TextChanged
        CALCSUM()
        txtgtotal.Text = Val(txtcgstper.Text) + Val(txtpacking.Text) + Val(txtinsurance.Text) + Val(txtgtotal.Text) + Val(txtFreightamt.Text)
    End Sub

    Private Sub txtother_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcgstper.Leave
        If Val(txtcgstper.Text) > 0 Then
            Dim Sqlvat As String
            Sqlvat = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sqlvat, "A5")
            cmbother.DataSource = GMod.ds.Tables("A5")
            cmbother.DisplayMember = "account_head_name"

            cmbothercode.DataSource = GMod.ds.Tables("A5")
            cmbothercode.DisplayMember = "account_code"

            ComboBox6.DataSource = GMod.ds.Tables("A5")
            ComboBox6.DisplayMember = "group_name"
        Else
            cmbother.Text = "-"
            cmbothercode.Text = "-"
            ComboBox6.Text = "-"
        End If

        txtcgstamt.Text = Math.Round((Val(txtcgstper.Text) / 100) * Val(TextBox4.Text), 0, MidpointRounding.AwayFromZero).ToString()
    End Sub

    Private Sub txtother_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcgstper.TextChanged
        'If cmbVoucherType.Text <> "OTHER SALE RET." Then
        '    CALCSUM()
        '    txtgtotal.Text = Val(txtcgstper.Text) + Val(txtpacking.Text) + Val(txtinsurance.Text) + Val(txtgtotal.Text) + Val(txtcgstamt.Text) + Val(txtsgstamt.Text) + Val(txtigstamt.Text)
        'Else
        '    CALCSUM()
        '    txtgtotal.Text = Val(txtpacking.Text) + Val(txtinsurance.Text) + Val(txtgtotal.Text) - Val(txtcgstper.Text) + Val(txtcgstamt.Text) + Val(txtsgstamt.Text) + Val(txtigstamt.Text)

        'End If

    End Sub
    Private Sub cmbacheadname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbacheadname.Leave
        If cmbacheadname.FindStringExact(cmbacheadname.Text) = -1 Then
            MsgBox("Please Select Correct A/c Head", MsgBoxStyle.Information)
            cmbacheadname.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub dtVouDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtVouDate.Leave
        'If btnSave.Enabled = True Then
        '    GMod.DataSetRet("select isnull(max(vou_date),'" & dtVouDate.Value & "') from " & GMod.VENTRY & " where vou_type ='" & cmbVoucherType.Text & "'", "getMaxDate")
        '    If dtVouDate.Value < CDate(GMod.ds.Tables("getMaxDate").Rows(0)(0).ToString) Then
        '        MessageBox.Show("Selected Date is Less Than Prevois Entred Voucher date", "DateError", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '        dtVouDate.Focus()
        '    End If
        'End If
    End Sub
    Private Sub txtcgstamt_TextChanged(sender As Object, e As EventArgs) Handles txtcgstamt.TextChanged
        CALCSUM()
        txtgtotal.Text = Val(txtpacking.Text) + Val(txtinsurance.Text) + Val(txtgtotal.Text) + Val(txtcgstamt.Text) + Val(txtsgstamt.Text) + Val(txtigstamt.Text) + Val(txtFreightamt.Text)
    End Sub
    Private Sub txtsgstamt_TextChanged(sender As Object, e As EventArgs) Handles txtsgstamt.TextChanged
        CALCSUM()
        txtgtotal.Text = Val(txtpacking.Text) + Val(txtinsurance.Text) + Val(txtgtotal.Text) + Val(txtcgstamt.Text) + Val(txtsgstamt.Text) + Val(txtigstamt.Text) + Val(txtFreightamt.Text)

    End Sub
    Private Sub txtigstamt_TextChanged(sender As Object, e As EventArgs) Handles txtigstamt.TextChanged
        CALCSUM()
        txtgtotal.Text = Val(txtpacking.Text) + Val(txtinsurance.Text) + Val(txtgtotal.Text) + Val(txtcgstamt.Text) + Val(txtsgstamt.Text) + Val(txtigstamt.Text) + Val(txtFreightamt.Text)
    End Sub

    Private Sub txtsgstper_Leave(sender As Object, e As EventArgs) Handles txtsgstper.Leave
        If Val(txtsgstper.Text) > 0 Then
            Dim Sqlvat As String
            Sqlvat = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sqlvat, "A10")
            cmbsgsthead.DataSource = GMod.ds.Tables("A10")
            cmbsgsthead.DisplayMember = "account_head_name"

            cmbsgstcode.DataSource = GMod.ds.Tables("A10")
            cmbsgstcode.DisplayMember = "account_code"

            ComboBox7.DataSource = GMod.ds.Tables("A10")
            ComboBox7.DisplayMember = "group_name"
        Else
            cmbsgsthead.Text = "-"
            cmbsgstcode.Text = "-"
            ComboBox7.Text = "-"
        End If
        txtsgstamt.Text = Math.Round((Val(txtsgstper.Text) / 100) * Val(TextBox4.Text), 0, MidpointRounding.AwayFromZero).ToString()
    End Sub

    Private Sub txtsgstper_TextChanged(sender As Object, e As EventArgs) Handles txtsgstper.TextChanged

    End Sub

    Private Sub txtigstper_Leave(sender As Object, e As EventArgs) Handles txtigstper.Leave
        If Val(txtigstper.Text) > 0 Then
            Dim Sqlvat As String
            Sqlvat = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sqlvat, "A11")
            cmbigsthead.DataSource = GMod.ds.Tables("A11")
            cmbigsthead.DisplayMember = "account_head_name"

            cmbigstcode.DataSource = GMod.ds.Tables("A11")
            cmbigstcode.DisplayMember = "account_code"

            ComboBox8.DataSource = GMod.ds.Tables("A11")
            ComboBox8.DisplayMember = "group_name"
        Else
            cmbigsthead.Text = "-"
            cmbigstcode.Text = "-"
            ComboBox8.Text = "-"
        End If
        txtigstamt.Text = Math.Round((Val(txtigstper.Text) / 100) * Val(TextBox4.Text), 0, MidpointRounding.AwayFromZero).ToString()
    End Sub

    Private Sub txtigstper_TextChanged(sender As Object, e As EventArgs) Handles txtigstper.TextChanged

    End Sub

    Private Sub txtgstperdr_Leave(sender As Object, e As EventArgs) Handles txtgstperdr.Leave

    End Sub

    Private Sub txtgstperdr_TextChanged(sender As Object, e As EventArgs) Handles txtgstperdr.TextChanged
        If Val(txtgstperdr.Text) > 0 Then
            Dim Sqlvat As String
            Sqlvat = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sqlvat, "A50")
            cmbgstheaddr.DataSource = GMod.ds.Tables("A50")
            cmbgstheaddr.DisplayMember = "account_head_name"

            cmbcodegstdr.DataSource = GMod.ds.Tables("A50")
            cmbcodegstdr.DisplayMember = "account_code"

            ComboBox9.DataSource = GMod.ds.Tables("A50")
            ComboBox9.DisplayMember = "group_name"
        Else
            cmbother.Text = "-"
            cmbothercode.Text = "-"
            ComboBox9.Text = "-"
        End If

        txtcgstamt.Text = Math.Round((Val(txtcgstper.Text) / 100) * Val(TextBox4.Text), 0, MidpointRounding.AwayFromZero).ToString()
    End Sub

    Private Sub dtVouDate_ValueChanged(sender As Object, e As EventArgs) Handles dtVouDate.ValueChanged
        ' dtVouDate.Value = GMod.SessionCurrentDate
        dtVouDate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtVouDate.MaxDate = GMod.SessionCurrentDate
    End Sub

   
    Private Sub dtInvVate_ValueChanged(sender As Object, e As EventArgs) Handles dtInvVate.ValueChanged

    End Sub

    Private Sub dgPurchase_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPurchase.CellContentClick

    End Sub

    Private Sub cmbTcsType_Leave(sender As Object, e As EventArgs) Handles cmbTcsType.Leave
        FetchTcsDetilas()
    End Sub

    Private Sub cmbTcsType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTcsType.SelectedIndexChanged
        FetchTcsDetilas()
    End Sub

    Private Sub chKtcs_CheckedChanged(sender As Object, e As EventArgs) Handles chKtcs.CheckedChanged
        If chKtcs.Checked = True Then
            Try
                Dim tcs As Double
                tcs = Math.Ceiling(Val(txtgtotal.Text) * (Val(txtTcsPer.Text) / 100))
                txtTcsAmount.Text = tcs.ToString
            Catch ex As Exception

            End Try
        Else
            txtTcsAmount.Text = 0
        End If
    End Sub

    Private Sub cmbacheadcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbacheadcode.SelectedIndexChanged

    End Sub

    Private Sub cmbcodegstdr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodegstdr.SelectedIndexChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtFreightamt_Leave(sender As Object, e As EventArgs) Handles txtFreightamt.Leave
        If Val(txtFreightamt.Text) > 0 Then
            Dim Sqlvat As String
            Sqlvat = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(Sqlvat, "fr_heads")
            cmbFreightac.DataSource = GMod.ds.Tables("fr_heads")
            cmbFreightac.DisplayMember = "account_head_name"

            cmdFreightCode.DataSource = GMod.ds.Tables("fr_heads")
            cmdFreightCode.DisplayMember = "account_code"

           
        Else
            cmbinsurancehead.Text = "-"
            cmbinsurancecode.Text = "-"
            ComboBox5.Text = "-"
        End If
    End Sub

    Private Sub txtFreightamt_TextChanged(sender As Object, e As EventArgs) Handles txtFreightamt.TextChanged
        CALCSUM()
        txtgtotal.Text = Val(txtcgstper.Text) + Val(txtpacking.Text) + Val(txtinsurance.Text) + Val(txtgtotal.Text) + Val(txtFreightamt.Text)

    End Sub
End Class