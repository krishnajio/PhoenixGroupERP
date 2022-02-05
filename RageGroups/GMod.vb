Imports System.Data.SqlClient
Module GMod
    Public SessionStartDate As DateTime
    Public SessionEndDate As DateTime
    Public SessionCurrentDate As DateTime
    Public PerviousSession As Boolean = False
    Public EntryStatus As Integer
    Public PrevSession As String

    Public tdsflag As Boolean = False
    Public tdsdcode As String = ""
    Public usrname As String = ""
    Public othcmp As Double = 0
    Public staff1 As Integer = 0
    Public Connstr As String = ""
    Public userid As Integer = 0
    Public username As String = ""
    Public role As String = ""
    Public status As String = ""
    Public Cmpid As String = ""
    Public Cmpname As String = ""
    Public Session As String = ""
    Public InventoryFound As Boolean = False
    Public nxtCR As Int64
    Public setDate As DateTime
    Public nofd As Integer
    'For DataBases    
    Public SqlConn As New SqlConnection(Connstr)
    Public ds As New DataSet
    Public Dept As Integer
    Public _CASHCOUNTER As Integer = 0
    Public cashcount As Integer = 0
    Public az As Integer = 0
    'For tables 
    Public ACC_HEAD As String
    Public VENTRY As String
    Public CHQ_ALLOT As String
    Public CHQ_ISSUED As String
    Public BANK_STATE As String
    Public BANK_STATE_OPEN As String
    Public CHQBOOK As String
    Public INVENTORY As String
    'For multiple chequ entry
    Public Chq_no As String
    Public ReciptId As String
    Public no_of_cheque As String
    Public ramdom As Boolean = False
    Public favourof As String
    Public damount As Double
    Public chq_date As DateTime
    Public VouNo As String
    Public Vtype As String
    'Area Code 
    Public AreaCode As String = "JB"

    'Cr 
    Public CrVouNo As String
    Public CrVouType As String

    Public vou_type As String = ""
    Public vou_no As String = ""
    Public setModifyFlag As Boolean = False

    'VoucherTax
    Public VoucherTax As String = ""
    'For Debit Note 
    Public BillNo As String = ""
    Public party_name As String = ""
    Public Billdate As Date
    Public Sub DataSetRet(ByVal sql As String, ByVal tablename As String)
        Try
            ds.Tables(tablename).Dispose()
        Catch ex As Exception

        End Try
        Try
            ds.Tables(tablename).Clear()
        Catch ex As Exception
        End Try
        Try
            Dim adp As New SqlDataAdapter(sql, Connstr)
            adp.Fill(ds, tablename)
            adp.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function SqlExecuteNonQuery(ByVal sql As String) As String

        'If GMod.SqlConn.State = ConnectionState.Closed Then
        '    GMod.SqlConn.Open()
        'End If
        Dim retval As String = ""
        Dim sqlcmd As New SqlCommand(sql, SqlConn)
        sqlcmd.CommandTimeout = 3000
        Try
            sqlcmd.ExecuteNonQuery()
            retval = "SUCCESS"
        Catch ex As Exception
            retval = ex.Message
        End Try
        sqlcmd.Dispose()
        'If GMod.SqlConn.State = ConnectionState.Open Then
        '    GMod.SqlConn.Close()
        'End If
        Return retval
    End Function
    Public Function Getsession(ByVal statusdate As DateTime) As String
        Dim year, x As Integer
        Dim yearstrsuff, yearstrpfx As String
        If statusdate.Month > 3 Then
            year = statusdate.Year
            x = year + 1
            yearstrsuff = year.ToString.Substring(2, 2)
            yearstrpfx = x.ToString.Substring(2, 2)
            Return yearstrsuff & yearstrpfx
        Else
            year = statusdate.Year - 1
            x = year + 1
            yearstrsuff = year.ToString.Substring(2, 2)
            yearstrpfx = x.ToString.Substring(2, 2)
            Return yearstrsuff & yearstrpfx
        End If
    End Function

    Public Function GetPrevsiousSession(ByVal statusdate As DateTime) As String
        Dim year, x As Integer
        Dim yearstrsuff, yearstrpfx As String
        If statusdate.Month > 3 Then
            year = statusdate.Year
            x = year + 1
            yearstrsuff = year.ToString.Substring(2, 2) - 1
            yearstrpfx = x.ToString.Substring(2, 2) - 1
            Return yearstrsuff & yearstrpfx
        Else
            year = statusdate.Year - 1
            x = year + 1
            yearstrsuff = year.ToString.Substring(2, 2) - 1
            yearstrpfx = x.ToString.Substring(2, 2) - 1
            Return yearstrsuff & yearstrpfx
        End If
    End Function

    Public Function EncryptionStr(ByVal strval As String, ByVal isencrypt As Boolean) As String
        Dim lenstr, i, t, addval As Integer
        Dim chr1, tmpstr As String
        tmpstr = ""
        lenstr = Len(strval)
        If isencrypt = True Then
            addval = 11
        Else
            addval = -11
        End If
        For i = 0 To lenstr - 1
            chr1 = strval.Substring(i, 1)
            t = Asc(chr1) + addval
            tmpstr = tmpstr + chr(t).ToString
        Next
        EncryptionStr = tmpstr
    End Function
    Public sp1(3) As String
    Function spliterbook(ByVal st As String)
        Try
            Dim word() As String
            word = st.Split(" ")
            sp1(0) = ""
            sp1(1) = ""
            sp1(2) = ""
            Dim i As Integer
            For i = 0 To word.Length - 1
                'earlier it was 55
                If sp1(0).Length < 50 Then
                    sp1(0) = sp1(0) & word(i) & " "
                Else
                    sp1(1) = sp1(1) & word(i) & " "
                End If
            Next
            word = sp1(1).Split(" ")
            sp1(1) = ""
            For i = 0 To word.Length - 1
                If sp1(1).Length < 50 Then
                    sp1(1) = sp1(1) & word(i) & " "
                Else
                    sp1(2) = sp1(2) & word(i) & " "
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub Fill_Log(ByVal cmp_id As String, ByVal vou_no As String, ByVal vou_type As String, ByVal vou_date As Date, ByVal Modfy_date As Date, ByVal session As String, ByVal TYPE As String, ByVal username As String)
        'Cmp_id, vou_no, vou_type, vou_date, Modfy_date, session, usename
        Dim InsertLogSql As String
        InsertLogSql = " insert into Log_Table (Cmp_id, vou_no, vou_type, vou_date, Modfy_date, session,TYPE, usename) values ("
        InsertLogSql &= "'" & cmp_id & "',"
        InsertLogSql &= "'" & vou_no & "',"
        InsertLogSql &= "'" & vou_type & "',"
        InsertLogSql &= "'" & vou_date & "',"
        InsertLogSql &= "'" & Modfy_date & "',"
        InsertLogSql &= "'" & session & "',"
        InsertLogSql &= "'" & TYPE & "',"
        InsertLogSql &= "'" & username & "')"
        'MsgBox(InsertLogSql)
        GMod.SqlExecuteNonQuery(InsertLogSql)
    End Sub
    Public Sub Fill_Log_Head(ByVal cmp_id As String, ByVal acc_code As String, ByVal acc_head As String, ByVal Modfy_date As Date, ByVal session As String, ByVal TYPE As String, ByVal username As String)
        'cmp_id, acc_code, acc_head, Modfy_date, session, TYPE, usename
        Dim InsertLogSql As String
        InsertLogSql = " insert into dbo.Log_Head_Table (cmp_id, acc_code, acc_head, Modfy_date, session, TYPE, usename) values ("
        InsertLogSql &= "'" & cmp_id & "',"
        InsertLogSql &= "'" & acc_code & "',"
        InsertLogSql &= "'" & acc_head & "',"
        InsertLogSql &= "'" & Modfy_date & "',"
        InsertLogSql &= "'" & session & "',"
        InsertLogSql &= "'" & TYPE & "',"
        InsertLogSql &= "'" & username & "')"
        'MsgBox(InsertLogSql)
        GMod.SqlExecuteNonQuery(InsertLogSql)
    End Sub
    Public Function LockDataCheck(ByVal vou_no As String, ByVal locksess As String, ByVal vou_type As String) As Boolean
        Dim sqls As String
        sqls = "select vou_date from " & GMod.VENTRY & " where vou_no='" & vou_no & "' and vou_type='" & vou_type & "'"
        GMod.DataSetRet(sqls, "VD")
        If GMod.ds.Tables("VD").Rows.Count > 0 Then
            'sqls = "select max(vou_date) from " & GMod.VENTRY & " where vou_type='" & vou_type & "'"
            sqls = "select getdate()"
            GMod.DataSetRet(sqls, "LD")
            'MsgBox(DateDiff(DateInterval.Day, CDate(GMod.ds.Tables("LD").Rows(0)(0)), CDate(GMod.ds.Tables("VD").Rows(0)(0))))
            If Math.Abs(DateDiff(DateInterval.Day, CDate(GMod.ds.Tables("LD").Rows(0)(0)), CDate(GMod.ds.Tables("VD").Rows(0)(0)))) >= Val(GMod.nofd) Then
                Return False
            Else
                'MsgBox(CDate(GMod.ds.Tables("LD").Rows(0)(0)).AddDays(-10))
                Return True
            End If
        Else
            MsgBox("Voucher doen't exists")
        End If
    End Function
    Public Function LockDataChecks(ByVal vou_no As String, ByVal locksess As String, ByVal vou_type As String) As Boolean
        Dim sqls As String
        sqls = "select billdate from printdata where vou_no='" & vou_no & "' and vou_type='" & vou_type & "' and cmp_id='" & GMod.Cmpid & "' and session='" & GMod.Session & "'"
        GMod.DataSetRet(sqls, "VD")
        If GMod.ds.Tables("VD").Rows.Count > 0 Then
            sqls = "select max(billdate) from printdata  where vou_type='" & vou_type & "' and cmp_id='" & GMod.Cmpid & "'"
            GMod.DataSetRet(sqls, "LD")
            'MsgBox(DateDiff(DateInterval.Day, CDate(GMod.ds.Tables("LD").Rows(0)(0)), CDate(GMod.ds.Tables("VD").Rows(0)(0))))
            If Math.Abs(DateDiff(DateInterval.Day, CDate(GMod.ds.Tables("LD").Rows(0)(0)), CDate(GMod.ds.Tables("VD").Rows(0)(0)))) > 90 Then
                Return False
            Else
                'MsgBox(CDate(GMod.ds.Tables("LD").Rows(0)(0)).AddDays(-10))
                Return True
            End If
        Else
            MsgBox("Voucher doen't exists")
        End If
    End Function
    
End Module
