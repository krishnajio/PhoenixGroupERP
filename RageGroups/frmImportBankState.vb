Imports System.Data.OleDb
Public Class frmImportBankState
    Dim conxls As String
    
    Private Sub frmImportBankState_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conxls = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
    "Data Source=C:\uti.xls;Extended Properties=""Excel 8.0;HDR=YES;"
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        Try
            GMod.ds.Tables.Clear()
            GMod.DataSetRet("select account_head_name,account_code from " & GMod.ACC_HEAD & " where Group_name='BANK'", "bankacchead")
            cmbacchead.DataSource = GMod.ds.Tables("bankacchead")
            cmbacchead.DisplayMember = "account_head_name"
            cmbacccode.DataSource = GMod.ds.Tables("bankacchead")
            cmbacccode.DisplayMember = "account_code"
            Dim r As Integer
            dgbankstate.Rows.Add()
            r = dgbankstate.Rows.Count - 1
            dgbankstate.CurrentCell = dgbankstate(0, r)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbacccode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbacccode.SelectedIndexChanged
        GMod.DataSetRet("select * from " & GMod.BANK_STATE_OPEN & " where bank_acc_code='" & cmbacccode.Text & "'", "bopen")
        If GMod.ds.Tables("bopen").Rows.Count > 0 Then
            If GMod.ds.Tables("bopen").Rows(0)(1) > 0 Then
                lblopen.Text = GMod.ds.Tables("bopen").Rows(0)(1)
            Else
                lblopen.Text = -1 * GMod.ds.Tables("bopen").Rows(0)(2)
            End If
        Else
            lblopen.Text = "0"
        End If
        'GMod.DataSetRet("select isnull(max(entryid),0) from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacccode.Text & "'", "trec")
        'tot_rec = GMod.ds.Tables("trec").Rows(0)(0)
        'ei = tot_rec
        'filldata()
        'If tot_rec = 0 Then dgbankstate.Rows.Add()

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
    Function dateformat(ByVal dtformat As String, ByVal dtval As String, ByVal sep As String) As String
        Dim dt(), dtfr() As String
        dtfr = dtformat.Split(sep)
        dt = dtval.Split(sep)
        Dim fd As String
        Dim m1 As String = ""
        Dim d, m, y As Integer
        If dtfr(0) = "DD" Then
            d = dt(0)
        ElseIf dtfr(1) = "DD" Then
            d = dt(1)
        Else
            d = dt(2)
        End If

        If dtfr(0) = "MM" Then
            m = dt(0)
        ElseIf dtfr(1) = "MM" Then
            m = dt(1)
        Else
            m = dt(2)
        End If

        If dtfr(0) = "MMM" Then
            m1 = dt(0)
        ElseIf dtfr(1) = "MMM" Then
            m1 = dt(1)
        ElseIf dtfr(2) = "MMM" Then
            m1 = dt(2)
        End If

        If dtfr(0) = "YY" Or dtfr(0) = "YYYY" Then
            y = dt(0)
        ElseIf dtfr(1) = "YY" Or dtfr(1) = "YYYY" Then
            y = dt(1)
        Else
            y = dt(2)
        End If
        If Len(m1) = 0 Then
            fd = d & "/" & MonthName(m).Substring(0, 3) & "/" & y
        Else
            fd = d & "/" & m1 & "/" & y
        End If
        dateformat = fd
    End Function
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        '  Dim connstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        '"Data Source=" & txtfilename.Text & ";Extended Properties=""Excel 8.0;HDR=YES;"""
        '  Dim pram As OleDbParameter
        '  Dim dr As DataRow
        '  Dim olecon As OleDbConnection
        '  Dim olecomm As OleDbCommand
        '  Dim olecomm1 As OleDbCommand
        '  Dim oleadpt As OleDbDataAdapter
        '  Dim ds As DataSet
        '  Dim sql As String
        '  Try
        '      olecon = New OleDbConnection
        '      olecon.ConnectionString = connstring
        '      olecomm = New OleDbCommand
        '      olecomm.CommandText = "Select * from [Sheet1$] order by no"
        '      olecomm.Connection = olecon
        '      olecomm1 = New OleDbCommand
        '      oleadpt = New OleDbDataAdapter(olecomm)
        '      ds = New DataSet
        '      olecon.Open()
        '      Dim i As Integer
        '      Dim dt() As String
        '      Dim dramt, cramt As Double
        '      oleadpt.Fill(ds, "Sheet1")
        '      dgbankstate.Rows.Clear()
        '      If rdsingle.Checked Then
        '          For i = 0 To ds.Tables("sheet1").Rows.Count - 1
        '              If ds.Tables("sheet1").Rows(i)(4) = "DR" Then
        '                  dramt = Val(ds.Tables("sheet1").Rows(i)(5).ToString)
        '                  cramt = 0
        '              Else
        '                  dramt = 0
        '                  cramt = Val(ds.Tables("sheet1").Rows(i)(5).ToString)
        '              End If

        '              dgbankstate.Rows.Add()
        '              dt = ds.Tables("sheet1").Rows(i)(1).ToString.Split("/")
        '              dgbankstate(1, i).Value = CDate(dt(1) & "/" & dt(0) & "/" & dt(2))
        '              dgbankstate(2, i).Value = ds.Tables("sheet1").Rows(i)(3)
        '              dgbankstate(3, i).Value = dramt
        '              dgbankstate(4, i).Value = cramt
        '              If dramt = 0 And cramt = 0 Then dgbankstate(3, i).Style.BackColor = Color.Red
        '              dgbankstate(0, i).Value = ds.Tables("sheet1").Rows(i)(0)
        '              dgbankstate(5, i).Value = ds.Tables("sheet1").Rows(i)(6)
        '              dgbankstate(8, i).Value = ds.Tables("sheet1").Rows(i)(2)
        '              If Len(dgbankstate(2, i).Value.ToString) > 0 Then
        '                  GMod.DataSetRet("select vou_date from " & GMod.VENTRY & " where cheque_no='" & dgbankstate(2, i).Value & "'", "serchq")
        '                  If GMod.ds.Tables("serchq").Rows.Count > 0 Then
        '                      dgbankstate(6, i).Value = GMod.ds.Tables("serchq").Rows(0)(0)
        '                  End If
        '              End If
        '          Next
        '      Else
        '          'get for two column
        '          For i = 0 To ds.Tables("sheet1").Rows.Count - 1
        '              dgbankstate.Rows.Add()
        '              MsgBox(ds.Tables("sheet1").Rows(i)(1).ToString)
        '              dt = ds.Tables("sheet1").Rows(i)(1).ToString.Split("/")
        '              dgbankstate(1, i).Value = CDate(dt(1) & "/" & dt(0) & "/" & dt(2))
        '              dgbankstate(2, i).Value = ds.Tables("sheet1").Rows(i)(3)
        '              dgbankstate(3, i).Value = Val(ds.Tables("sheet1").Rows(i)(4).ToString)
        '              dgbankstate(4, i).Value = Val(ds.Tables("sheet1").Rows(i)(5).ToString)

        '              dgbankstate(0, i).Value = ds.Tables("sheet1").Rows(i)(0)
        '              dgbankstate(5, i).Value = ds.Tables("sheet1").Rows(i)(6)
        '              dgbankstate(8, i).Value = ds.Tables("sheet1").Rows(i)(2)
        '              If Len(dgbankstate(2, i).Value.ToString) > 0 Then
        '                  GMod.DataSetRet("select vou_date from " & GMod.VENTRY & " where cheque_no='" & dgbankstate(2, i).Value & "'", "serchq")
        '                  If GMod.ds.Tables("serchq").Rows.Count > 0 Then
        '                      dgbankstate(6, i).Value = GMod.ds.Tables("serchq").Rows(0)(0)
        '                  End If
        '              End If
        '          Next
        '      End If
        '      btnsave.Enabled = True
        '  Catch ex As Exception
        '      MessageBox.Show(ex.Message)
        '  Finally
        '      olecon.Close()
        '      olecon = Nothing
        '      olecomm = Nothing
        '      oleadpt = Nothing
        '      ds = Nothing
        '      dr = Nothing
        '      pram = Nothing
        '  End Try
        Dim apex As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim sr, dt, narration, chqno, dr, cr, bal, drcr As String
        Try
            dgbankstate.Rows.Clear()
            wb = apex.Workbooks.Open(txtfilename.Text)
            ws = apex.Worksheets(1)
            GMod.DataSetRet("select isnull(max(entryid),0)+1 from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacccode.Text & "'", "ss")
            sr = GMod.ds.Tables("ss").Rows(0)(0)
            Dim i As Integer = 2
            Dim l As String = "Y"
            While l = "Y"
                dt = ws.Range("b" & i).Text
                If rdtwo.Checked Then
                    If Len(dt) = 0 Then Exit While
                    'sr = ws.Range("a" & i).Text
                    narration = ws.Range("c" & i).Text
                    CHQNO = ws.Range("d" & i).Text
                    dr = formatno(ws.Range("e" & i).Text)
                    cr = formatno(ws.Range("f" & i).Text)
                    bal = ws.Range("g" & i).Text
                    dgbankstate.Rows.Add()
                    dgbankstate(0, i - 2).Value = sr
                    dgbankstate(1, i - 2).Value = dateformat(txtdtformat.Text.ToUpper, ws.Range("b" & i).Text, txtdtsep.Text)
                    dgbankstate(2, i - 2).Value = CHQNO
                    dgbankstate(3, i - 2).Value = dr
                    dgbankstate(4, i - 2).Value = cr
                    dgbankstate(5, i - 2).Value = bal
                    dgbankstate(8, i - 2).Value = narration
                Else
                    If Len(dt) = 0 Then Exit While
                    'sr = ws.Range("a" & i).Text
                    narration = ws.Range("c" & i).Text
                    CHQNO = ws.Range("d" & i).Text
                    drcr = ws.Range("e" & i).Text
                    If drcr.ToUpper = "DR" Then
                        dr = formatno(ws.Range("f" & i).Text)
                        cr = 0
                    Else
                        dr = 0
                        cr = formatno(ws.Range("f" & i).Text)
                    End If
                    bal = ws.Range("g" & i).Text
                    dgbankstate.Rows.Add()
                    dgbankstate(0, i - 2).Value = sr
                    dgbankstate(1, i - 2).Value = dateformat(txtdtformat.Text.ToUpper, ws.Range("b" & i).Text, txtdtsep.Text)
                    dgbankstate(2, i - 2).Value = CHQNO
                    dgbankstate(3, i - 2).Value = dr
                    dgbankstate(4, i - 2).Value = cr
                    dgbankstate(5, i - 2).Value = bal
                    dgbankstate(8, i - 2).Value = narration

                End If
                If Len(dgbankstate(2, i - 2).Value.ToString) > 0 Then
                    GMod.DataSetRet("select vou_date from " & GMod.VENTRY & " where cheque_no='" & dgbankstate(2, i - 2).Value & "' and acc_head_code='" & cmbacccode.Text & "'", "serchq")
                    If GMod.ds.Tables("serchq").Rows.Count > 0 Then
                        dgbankstate(6, i - 2).Value = GMod.ds.Tables("serchq").Rows(0)(0)
                    End If
                End If
                i = i + 1
                sr = sr + 1
            End While
            wb.Close()
            btnsave.Enabled = True
        Catch ex As Exception
            MsgBox("Use Format according to date " & dt & ex.Message)
        End Try
        
    End Sub

    Function formatno(ByVal n As String) As String
        Dim r As String = ""
        Dim j, code As Integer
        For j = 0 To n.Length - 1
            code = Asc(n.Substring(j, 1))
            If (code >= 48 And code <= 57) Or code = 46 Then
                r = r & n.Substring(j, 1)
            End If
        Next
        formatno = r
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dgbankstate.Rows.Clear()
        OpenFileDialog1.ShowDialog()
        txtfilename.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sql, paymod As String
        Dim dt, dtst, dted As Date
        Dim i As Integer
        Try
            Dim res As String
            If MsgBox("Are you sure to import Data of Bank" & cmbacchead.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                dtst = CDate(dgbankstate(1, 0).Value)
                dted = CDate(dgbankstate(1, dgbankstate.Rows.Count - 1).Value)
                GMod.SqlExecuteNonQuery("delete from " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacccode.Text & "' and bankedate between '" & dtst & "' and '" & dted & "'")
                For i = 0 To dgbankstate.Rows.Count - 1
                    'Cmp_id, Entryid, bank_acc_code, bankedate, paytype, detail, 
                    'chddno, dramt, cramt, issuedate
                    If Len(dgbankstate(2, i).Value.ToString) > 0 Or dgbankstate(2, i).Value.ToString.ToUpper = "CHARGES" Then
                        paymod = "CHEQUE"
                    Else
                        paymod = "CASH"
                    End If

                    If Len(dgbankstate(6, i).Value) > 0 Then
                        dt = CDate(dgbankstate(6, i).Value)
                    Else
                        dt = "01/01/1900"
                    End If
                    Dim nar As String
                    'MsgBox(dgbankstate(8, i).Value.ToString.Trim.Length)
                    If dgbankstate(8, i).Value.ToString.Trim.Length > 40 Then
                        nar = dgbankstate(8, i).Value.ToString.Substring(0, 40)
                    Else
                        nar = dgbankstate(8, i).Value
                    End If
                    'If i = 130 Then
                    '    MsgBox("ds")

                    'End If
                    sql = "insert into " & GMod.BANK_STATE & " values('" & GMod.Cmpid & "'," _
                    & Val(dgbankstate(0, i).Value) & ",'" & cmbacccode.Text & "'," _
                    & "'" & dgbankstate(1, i).Value & "','" & paymod & "','" & nar & "'," _
                    & "'" & dgbankstate(2, i).Value.ToString & "'," & Val(dgbankstate(3, i).Value) & "," _
                    & Val(dgbankstate(4, i).Value) & ",'" & dt & "',0)"
                    res = GMod.SqlExecuteNonQuery(sql)
                    If res <> "SUCCESS" Then
                        MsgBox("Problem in Sr. No. " & i + 1 & "   " & res)
                    End If
                Next
                MsgBox("Successfully Import Data", MsgBoxStyle.Information)
                dgbankstate.Rows.Clear()
                btnsave.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim x As String
        'x = InputBox("Date")
        'MsgBox(dateformat(txtdtformat.Text, x, txtdtsep.Text))
        MsgBox(formatno(TextBox1.Text))
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class