Imports System.Data
Imports System.Data.SqlClient
Public Class frmFeedTransfer
    Dim tablename As String = ""
    Dim tablenameacc As String = ""
    Dim sql As String
    Dim getvouno As Integer
    Dim headtable As String
    Dim dsFeedTrf As New DataSet
    Dim Narration As String
    Dim ConStrFeed As String = "Data Source=192.168.0.130,3759;Initial Catalog=phxfeed_2324;User ID=sa;Password=Ph@hoenix#g;Connect Timeout=600;Encrypt=False;TrustServerCertificate=True;"
    Public Sub fillVou_no()
        Try
            'sql = "select * from OtherSaleData where Vou_type='Inter Unit Transfer' and Session = YEAR(getdate())"
            cmbIuList.DataSource = Nothing


            ' ✅ CLEAR DATASET TABLE
            If dsFeedTrf.Tables.Contains("IUTrsVouNo") Then
                dsFeedTrf.Tables("IUTrsVouNo").Clear()
            End If

            sql = "select Vou_no from OtherSaleData where Session = '2026'  and Vou_type='Inter Unit Transfer' and "
            sql &= " vou_no not in ( select BillNo from [PhxGroupERP].dbo.OtherSaleData where Session='" & GMod.Session & "' and Vou_type='INTER TRANSFER' and BillNo like 'IU-%') order by vou_no"

            sql = "SELECT a.Vou_no " &
             "FROM OtherSaleData a " &
             "WHERE a.Session = '2026' " &
             "AND a.Vou_type = 'Inter Unit Transfer' " &
             "AND NOT EXISTS ( " &
             "    SELECT 1 " &
             "    FROM [PhxGroupERP].dbo.OtherSaleData b " &
             "    WHERE b.Session = '" & GMod.Session & "' " &
             "    AND b.Vou_type = 'INTER TRANSFER' " &
             "    AND b.BillNo = a.Vou_no " &
             ") " &
             "ORDER BY a.Vou_no"


            Dim da As New SqlDataAdapter(sql, ConStrFeed)
            da.Fill(dsFeedTrf, "IUTrsVouNo")
            cmbIuList.DataSource = dsFeedTrf.Tables("IUTrsVouNo")
            cmbIuList.DisplayMember = "Vou_no"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmFeedTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        fillVou_no()


        'date set to as per session
        dtpPostingDate.Value = GMod.SessionCurrentDate
        dtpPostingDate.MinDate = CDate(GMod.SessionCurrentDate).AddDays(-Val(GMod.nofd))
        dtpPostingDate.MaxDate = GMod.SessionCurrentDate



        tablename = "VENTRY" & "_" & "PHOE" & "_" & GMod.Session
        tablenameacc = "ACC_HEAD" & "_" & "PHOE" & "_" & GMod.Session
        sql = "select vtype from Vtype where cmp_id='PHOE'  and session='" & GMod.Session & "' and vtype like '%INTER%'"
        GMod.DataSetRet(sql, "CRVT")
        cmbVoucherType.DataSource = GMod.ds.Tables("CRVT")
        cmbVoucherType.DisplayMember = "vtype"

        headtable = "ACC_HEAD" & "_" & "PHOE" & "_" & GMod.Session
        sql = " select * from " & headtable & " where cmp_id='PHOE' " 'and group_name='SALE'"


    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Try
            If dsFeedTrf.Tables.Contains("IUTrsList") Then
                dsFeedTrf.Tables("IUTrsList").Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        sql = "select Billdate,formulaname,OutQty,OutQtyNos,Rate,Amount,ToFarm from OtherSaleData "
        sql &= " where Vou_type='Inter Unit Transfer' and Session = '2026' and Vou_no=@vouNo"

        Dim da As New SqlDataAdapter(sql, ConStrFeed)
        da.SelectCommand.Parameters.AddWithValue("@vouNo", cmbIuList.Text)

        da.Fill(dsFeedTrf, "IUTrsList")

        dgIUTRFList.DataSource = dsFeedTrf.Tables("IUTrsList")
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click

        tablename = "VENTRY" & "_" & "PHOE" & "_" & GMod.Session
        sql = "SELECT isnull(max(cast(vou_no as numeric(18,0))),0) + 1 FROM " & tablename & " where vou_type = '" & cmbVoucherType.Text & "'"
        GMod.DataSetRet(sql, "vnor")
        getvouno = CInt(ds.Tables("vnor").Rows(0)(0).ToString)


        Narration = "BEING " & dgIUTRFList(1, 0).Value.ToString & " No.of Bags" & dgIUTRFList(3, 0).Value.ToString & " Qty kg" & dgIUTRFList(2, 0).Value.ToString & " @ " & dgIUTRFList(4, 0).Value.ToString
        Narration &= "TRANSFER FROM BEEJAPURI FEED FACTORY TO " & dgIUTRFList(6, 0).Value.ToString & "Inv No." & cmbIuList.Text & "DATED" & dgIUTRFList(0, 0).Value.ToString

        sql = "select * from " & tablenameacc & " where remark3 ='" & dgIUTRFList(6, 0).Value.ToString & "'"
        GMod.DataSetRet(sql, "crheads")

        sql = "INSERT INTO " & tablename & "(" &
              "Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, " &
              "Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " &
              "Narration, Group_name, Sub_group_name, entry_date) VALUES ("
        sql &= "'" & GMod.Cmpid & "',"
        sql &= "'" & GMod.username & "',"
        sql &= "'0',"
        sql &= "'" & getvouno & "',"
        sql &= "'" & cmbVoucherType.Text & "',"
        sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
        sql &= "'" & ds.Tables("crheads").Rows(0)("account_code") & "',"
        sql &= "'" & ds.Tables("crheads").Rows(0)("account_head_name") & "',"
        sql &= "'" & dgIUTRFList(5, 0).Value.ToString & "',"
        sql &= "'0',"
        sql &= "'-',"
        sql &= "'-',"
        sql &= "'" & Narration & "'," 'Narration
        sql &= "'" & ds.Tables("crheads").Rows(0)("group_name") & "',"
        sql &= "'" & ds.Tables("crheads").Rows(0)("sub_group_name") & "',"
        sql &= "'" & Now.ToShortDateString & "')"
        GMod.SqlExecuteNonQuery(sql)

        sql = "insert into OtherSaleData ([Vou_type], [Vou_no], [AccCode], [AccName], [Station], [ProductName], [OutQty]," _
                                       & " [Rate], [Amount], [OutQtyNos], [BillNo], [BillDate], [InQty], [InQtyNos], [Cmp_id], " _
                                       & " [Session],[mrktrate], [authr], [Prdunit], [Packing], [Insurance], [Discount]," _
                                       & " [CrHead],[tcs_per], [tcs_amt],cgstp,cgsta) VALUES ("
        sql &= "'" & cmbVoucherType.Text & "',"
        sql &= "'" & getvouno & "',"
        sql &= "'" & ds.Tables("crheads").Rows(0)("account_code") & "',"
        sql &= "'" & ds.Tables("crheads").Rows(0)("account_head_name") & "',"
        sql &= "'COMMON',"
        sql &= "'" & dgIUTRFList(1, 0).Value.ToString & "',"
        sql &= "'" & Val(dgIUTRFList(2, 0).Value.ToString) & "',"
        sql &= "'" & Val(dgIUTRFList(4, 0).Value.ToString) & "',"
        sql &= "'" & dgIUTRFList(5, 0).Value.ToString & "',"
        sql &= "'" & dgIUTRFList(3, 0).Value.ToString & "',"
        sql &= "'" & cmbIuList.Text & "',"
        sql &= "'" & dgIUTRFList(0, 0).Value.ToString & "',"
        sql &= "'0',"
        sql &= "'0',"
        sql &= "'" & GMod.Cmpid & "',"
        sql &= "'" & GMod.Session & "',"
        sql &= "'" & Val("") & "',"
        sql &= "'-'," 'Autorization
        sql &= "'-',"
        sql &= "'" & Val("") & "',"
        sql &= "'0',"
        sql &= "'" & Val("") & "',"
        sql &= "'BEEJAPURI - FEED TRANSFER TO PARIYAT UNIT',"
        sql &= "'0',"
        sql &= "'0',"
        sql &= "'0',"
        sql &= "'0')"

        GMod.SqlExecuteNonQuery(sql)

        sql = "INSERT INTO " & tablename & "(" &
              "Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, " &
              "Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " &
              "Narration, Group_name, Sub_group_name, entry_date) VALUES ("
        sql &= "'" & GMod.Cmpid & "',"
        sql &= "'" & GMod.username & "',"
        sql &= "'0',"
        sql &= "'" & getvouno & "',"
        sql &= "'" & cmbVoucherType.Text & "',"
        sql &= "'" & dtpPostingDate.Value.ToShortDateString & "',"
        sql &= "'**TFPA0014',"
        sql &= "'BEEJAPURI - FEED TRANSFER TO PARIYAT UNIT',"
        sql &= "'" & dgIUTRFList(5, 0).Value.ToString & "',"
        sql &= "'0',"
        sql &= "'-',"
        sql &= "'-',"
        sql &= "'" & Narration & "'," 'Narration
        sql &= "'TRANSFER',"
        sql &= "'PARIYAT UNIT',"
        sql &= "'" & Now.ToShortDateString & "')"
        GMod.SqlExecuteNonQuery(sql)


        
        'BEEJAPURI - FEED TRANSFER TO PARIYAT UNIT
        'TRANSFER
        ''PARIYAT UNIT
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection(GMod.Connstr)
        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction()

        Try
            Dim tablename As String = "VENTRY" & "_" & "PHOE" & "_" & GMod.Session
            Dim getvouno As Integer = 0
            Dim sql As String = ""

            '========================
            ' GET VOUCHER NO (LOCKED)
            '========================
            sql = "SELECT ISNULL(MAX(CAST(vou_no AS NUMERIC(18,0))),0) + 1  FROM " & tablename & " WITH (UPDLOCK, HOLDLOCK)  WHERE vou_type = '" & cmbVoucherType.Text.Replace("'", "''") & "'"

            Dim cmdVou As New SqlCommand(sql, conn, tran)
            getvouno = Convert.ToInt32(cmdVou.ExecuteScalar())

            '========================
            ' GET ACCOUNT HEAD
            '========================
            sql = "SELECT * FROM " & tablenameacc & " WHERE remark3 = '" & dgIUTRFList(6, 0).Value.ToString.Replace("'", "''") & "'"

            Dim da As New SqlDataAdapter(sql, conn)
            da.SelectCommand.Transaction = tran

            Dim ds As New DataSet()
            da.Fill(ds, "crheads")

            If ds.Tables("crheads").Rows.Count = 0 Then
                Throw New Exception("Account head not found")
            End If

            '========================
            ' NARRATION
            '========================
            Dim Narration As String = "BEING " & dgIUTRFList(1, 0).Value.ToString &
                                      " No.of Bags " & dgIUTRFList(3, 0).Value.ToString &
                                      " Qty kg " & dgIUTRFList(2, 0).Value.ToString &
                                      " @ " & dgIUTRFList(4, 0).Value.ToString

            Narration &= " TRANSFER FROM BEEJAPURI FEED FACTORY TO " &
                         dgIUTRFList(6, 0).Value.ToString &
                         " Inv No. " & cmbIuList.Text &
                         " DATED " & dgIUTRFList(0, 0).Value.ToString

            Narration = Narration.Replace("'", "''")

            '========================
            ' FIRST ENTRY (CREDIT)
            '========================
            sql = "INSERT INTO " & tablename & " (" &
                  "Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, " &
                  "Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " &
                  "Narration, Group_name, Sub_group_name, entry_date) VALUES (" &
                  "'" & GMod.Cmpid & "'," &
                  "'" & GMod.username & "'," &
                  "0," &
                  "'" & getvouno & "'," &
                  "'" & cmbVoucherType.Text.Replace("'", "''") & "'," &
                  "'" & Format(dtpPostingDate.Value, "yyyy-MM-dd") & "'," &
                  "'" & ds.Tables("crheads").Rows(0)("account_code") & "'," &
                  "'" & ds.Tables("crheads").Rows(0)("account_head_name").ToString.Replace("'", "''") & "'," &
                  Val(dgIUTRFList(5, 0).Value) & "," &
                  "0," &
                  "'-','-'," &
                  "'" & Narration & "'," &
                  "'" & ds.Tables("crheads").Rows(0)("group_name") & "'," &
                  "'" & ds.Tables("crheads").Rows(0)("sub_group_name") & "'," &
                  "'" & Format(Now, "yyyy-MM-dd") & "')"

            Dim cmd1 As New SqlCommand(sql, conn, tran)
            cmd1.ExecuteNonQuery()

            '========================
            ' OTHER SALE DATA
            '========================
            sql = "INSERT INTO OtherSaleData " &
                  "([Vou_type],[Vou_no],[AccCode],[AccName],[Station],[ProductName],[OutQty]," &
                  "[Rate],[Amount],[OutQtyNos],[BillNo],[BillDate],[InQty],[InQtyNos],[Cmp_id]," &
                  "[Session],[mrktrate],[authr],[Prdunit],[Packing],[Insurance],[Discount]," &
                  "[CrHead],[tcs_per],[tcs_amt],cgstp,cgsta) VALUES (" &
                  "'" & cmbVoucherType.Text.Replace("'", "''") & "'," &
                  "'" & getvouno & "'," &
                  "'" & ds.Tables("crheads").Rows(0)("account_code") & "'," &
                  "'" & ds.Tables("crheads").Rows(0)("account_head_name").ToString.Replace("'", "''") & "'," &
                  "'COMMON'," &
                  "'" & dgIUTRFList(1, 0).Value.ToString.Replace("'", "''") & "'," &
                  Val(dgIUTRFList(2, 0).Value) & "," &
                  Val(dgIUTRFList(4, 0).Value) & "," &
                  Val(dgIUTRFList(5, 0).Value) & "," &
                  Val(dgIUTRFList(3, 0).Value) & "," &
                  "'" & cmbIuList.Text.Replace("'", "''") & "'," &
                  "'" & Format(Convert.ToDateTime(dgIUTRFList(0, 0).Value), "yyyy-MM-dd") & "'," &
                  "0,0," &
                  "'" & GMod.Cmpid & "'," &
                  "'" & GMod.Session & "'," &
                  "0,'-','-',0,0,0," &
                  "'BEEJAPURI - FEED TRANSFER TO PARIYAT UNIT'," &
                  "0,0,0,0)"

            Dim cmd2 As New SqlCommand(sql, conn, tran)
            cmd2.ExecuteNonQuery()

            '========================
            ' SECOND ENTRY (DEBIT)
            '========================
            sql = "INSERT INTO " & tablename & " (" &
                  "Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, " &
                  "Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, " &
                  "Narration, Group_name, Sub_group_name, entry_date) VALUES (" &
                  "'" & GMod.Cmpid & "'," &
                  "'" & GMod.username & "'," &
                  "0," &
                  "'" & getvouno & "'," &
                  "'" & cmbVoucherType.Text.Replace("'", "''") & "'," &
                  "'" & Format(dtpPostingDate.Value, "yyyy-MM-dd") & "'," &
                  "'**TFPA0014'," &
                  "'BEEJAPURI - FEED TRANSFER TO PARIYAT UNIT'," &
                  "0," &
                  Val(dgIUTRFList(5, 0).Value) & "," &
                  "'-','-'," &
                  "'" & Narration & "'," &
                  "'TRANSFER'," &
                  "'PARIYAT UNIT'," &
                  "'" & Format(Now, "yyyy-MM-dd") & "')"

            Dim cmd3 As New SqlCommand(sql, conn, tran)
            cmd3.ExecuteNonQuery()

            '========================
            ' COMMIT
            '========================
            tran.Commit()
            ' cmbIuList.DataSource = Nothing
            MessageBox.Show("Voucher Posted Successfully: " & getvouno)

        Catch ex As Exception
            tran.Rollback()
            MessageBox.Show("Error: " & ex.Message)

        Finally
            conn.Close()
        End Try
        If dsFeedTrf.Tables.Contains("IUTrsList") Then
            dsFeedTrf.Tables("IUTrsList").Clear()
        End If
        fillVou_no()
    End Sub
End Class