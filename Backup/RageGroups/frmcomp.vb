Public Class frmcomp

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtadd.Text = ""
        txttinno.Text = ""
        txtcompname.Text = ""
        txtopncash.Text = ""
        txtstockval.Text = ""
        btnsave.Enabled = True
        txtcompname.Focus()
        fillgrid()
    End Sub
    Dim valcr, valdr As Long
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim Cmpbreakdname() As String, Cmpid As String, Sqlsavestr As String, Sqlresult As String

        Cmpbreakdname = Split(txtcompname.Text)
        If Cmpbreakdname.Length >= 2 Then
            Cmpid = Cmpbreakdname(0).Substring(0, 2) + Cmpbreakdname(1).Substring(0, 2)

        Else
            Cmpid = Cmpbreakdname(0).Substring(0, 4)
        End If

        If cmbDrCr.Text = "Cr" Then
            valcr = CLng(txtopncash.Text)
            valdr = 0
        Else
            valcr = 0
            valdr = CLng(txtopncash.Text)
        End If
        ' Cmpid = TextBox1.Text
        Sqlsavestr = "Insert into Company(Cmp_id, Cmpname, Address, Book_date, Tin_no,Opn_cashCr, Opn_cashDr, Stock_val) values ("
        Sqlsavestr &= "'" & Cmpid.ToUpper & "',"
        Sqlsavestr &= "'" & txtcompname.Text.ToUpper & "',"
        Sqlsavestr &= "'" & txtadd.Text.ToUpper & "',"
        Sqlsavestr &= "'" & dtpbookstd.Value.ToShortDateString & "',"
        Sqlsavestr &= "'" & txttinno.Text.ToUpper & "',"
        Sqlsavestr &= "'" & valcr & "',"
        Sqlsavestr &= "'" & valdr & "',"
        Sqlsavestr &= "'" & txtstockval.Text.ToUpper & "')"
        If txtcompname.Text = "" Or txtadd.Text = "" Then
            MsgBox("Comapny Name and Address are required", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
        If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate company code", MsgBoxStyle.Critical)
            Else
                MsgBox("Error :" & Sqlresult, MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Company information saved", MsgBoxStyle.Information)
            CreatingCmpData()
            btnreset_Click(sender, e)
        End If
        txtcompname.Focus()
    End Sub

    Private Sub frmcomp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GMod.role.ToUpper = "ADMIN" Then
            btnmodify.Enabled = True
            btndelete.Enabled = True
            btnsave.Enabled = True
        Else
            btnmodify.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = False
        End If

        GMod.ds.Tables.Clear()
        fillgrid()
        cmbDrCr.SelectedIndex = 0
    End Sub
    Public Sub fillgrid()
        Dim sqlselectall As String
        sqlselectall = "select * from company"
        GMod.DataSetRet(sqlselectall, "company")
        dgcompany.DataSource = ds.Tables("company")
    End Sub
    Dim cmpidNEW As String, rowidx As Integer
    Private Sub dgcompany_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgcompany.DoubleClick
        Try
            rowidx = dgcompany.CurrentCell.RowIndex
            cmpid = dgcompany(0, rowidx).Value
            txtcompname.Text = dgcompany(1, rowidx).Value
            txtadd.Text = dgcompany(2, rowidx).Value
            dtpbookstd.Value = CDate(dgcompany(3, rowidx).Value)
            txttinno.Text = dgcompany(4, rowidx).Value
            If CLng(dgcompany(5, rowidx).Value) > 0 Then
                cmbDrCr.Text = "Cr"
                txtopncash.Text = dgcompany(5, rowidx).Value
            Else
                cmbDrCr.Text = "Dr"
                txtopncash.Text = dgcompany(6, rowidx).Value
            End If
            txtstockval.Text = dgcompany(7, rowidx).Value
            txtcompname.Focus()
            btnsave.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        On Error Resume Next
        'Cmp_id, Cmpname, Address, Book_date, Tin_no, Opn_cashCr, Opn_cashDr, Stock_val
        If cmbDrCr.Text = "Cr" Then
            valcr = CLng(txtopncash.Text)
            valdr = 0
        Else
            valcr = 0
            valdr = CLng(txtopncash.Text)
        End If
        Dim sqlupdate As String, sqlresult As String
        sqlupdate = "update company set "
        sqlupdate &= " Cmpname=" & "'" & txtcompname.Text & "',"
        sqlupdate &= "Address=" & "'" & txtadd.Text & "',"
        sqlupdate &= "Book_date=" & "'" & dtpbookstd.Value.ToShortDateString & "',"
        sqlupdate &= "Tin_no=" & "'" & txttinno.Text.ToUpper & "',"
        sqlupdate &= "Opn_cashCr=" & "'" & valcr & "',"
        sqlupdate &= "Opn_cashDr=" & "'" & valdr & "',"
        sqlupdate &= "Stock_val=" & "'" & txtstockval.Text.ToUpper & "'"
        sqlupdate &= " where  Cmp_id=" & "'" & cmpid & "'"
        If btnsave.Enabled Then
            MsgBox("Please double click on the Company name to select", MsgBoxStyle.Critical)
        Else
            If txtcompname.Text = "" Or txtadd.Text = "" Then
                MsgBox("Company name and code are necessary", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If MessageBox.Show("Are u sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                sqlresult = GMod.SqlExecuteNonQuery(sqlupdate)
                If sqlresult <> "SUCCESS" Then
                    MsgBox("Error :" & sqlresult, MsgBoxStyle.Critical)
                Else
                    btnreset_Click(sender, e)
                    fillgrid()
                End If
            Else
                btnreset_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim sqldelete As String, sqlresult As String
        sqldelete = "delete from company "
        sqldelete &= " where  Cmp_id=" & "'" & cmpid & "'"
        If btnsave.Enabled Then
            MsgBox("Please double click on the Company name to select", MsgBoxStyle.Critical)
        Else
            If txtcompname.Text = "" Or txtadd.Text = "" Then
                MsgBox("Company name and code are necessary", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If MessageBox.Show("Are u sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                GMod.DataSetRet("select * from groups where cmp_id='" & dgcompany(0, dgcompany.CurrentCell.RowIndex).Value & "'", "ser")
                If GMod.ds.Tables("ser").Rows.Count > 0 Then
                    MsgBox("Company can not deleted. There are some groups created", MsgBoxStyle.Critical, "Error")
                Else
                    sqlresult = GMod.SqlExecuteNonQuery(sqldelete)
                    If sqlresult <> "SUCCESS" Then
                        MsgBox("Error :" & sqlresult, MsgBoxStyle.Critical)
                    Else
                        MsgBox("Company Deleted Successfully", MsgBoxStyle.Information)
                    End If
                End If
            End If
            btnreset_Click(sender, e)
        End If
    End Sub

    Private Sub frmcomp_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        GMod.ds.Tables.Clear()
    End Sub

    Private Sub txtcompname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcompname.TextChanged

    End Sub

    Private Sub txtcompname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcompname.KeyDown
        If e.KeyCode = Keys.Enter Then txtadd.Focus()
    End Sub

    Private Sub txtadd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtadd.KeyDown
        If e.KeyCode = Keys.Enter Then dtpbookstd.Focus()
    End Sub

    Private Sub dtpbookstd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpbookstd.KeyDown
        If e.KeyCode = Keys.Enter Then txttinno.Focus()
    End Sub

    Private Sub txttinno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttinno.KeyDown
        If e.KeyCode = Keys.Enter Then txtopncash.Focus()

    End Sub

    Private Sub txtopncash_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtopncash.KeyDown
        If e.KeyCode = Keys.Enter Then cmbDrCr.Focus()

    End Sub

    Private Sub cmbDrCr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDrCr.KeyDown
        If e.KeyCode = Keys.Enter Then txtstockval.Focus()
    End Sub

    Private Sub txtstockval_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstockval.KeyDown
        If e.KeyCode = Keys.Enter Then btnsave.Focus()
    End Sub
    Public Sub CreatingCmpData()
        Dim tablename As String, createtablesql As String, sqlresult As String
        tablename = "ACC_HEAD" & "_" & Cmpid & "_" & GMod.Getsession(dtpbookstd.Value)
        GMod.DataSetRet("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and TABLE_NAME='" & tablename & "'", "tableaccount")
        GMod.ACC_HEAD = tablename
        If GMod.ds.Tables("tableaccount").Rows.Count = 0 Then
            createtablesql = "CREATE TABLE " & tablename & "(" _
                             & "[Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-') ," _
                             & "[account_code] [varchar](8)  NOT NULL DEFAULT ('-') primary key," _
                             & "[account_head_name] [varchar](30)  NOT NULL DEFAULT ('-')," _
                             & "[group_name] [varchar](40)  NOT NULL DEFAULT ('-') ," _
                             & "[sub_group_name] [varchar](60)  NOT NULL DEFAULT ('-') ," _
                             & "[credit_days] [numeric](2, 0)  NOT NULL DEFAULT ((0))," _
                             & "[credit_limit] [numeric](18, 2) NOT NULL DEFAULT ((0))," _
                             & "[opening_dr] [numeric](18, 2) NOT NULL DEFAULT ((0))," _
                             & "[opening_cr] [numeric](18, 2) NOT NULL   DEFAULT ((0))," _
                             & "[account_type] [char](1) NOT NULL DEFAULT ('-')," _
                             & "[address] [varchar](80) NOT NULL  DEFAULT ('-'), " _
                             & "[city] [varchar](30) NOT NULL DEFAULT ('-')," _
                             & "[state] [varchar](30) NOT NULL  DEFAULT ('-')," _
                             & "[phone] [varchar](20) NOT NULL DEFAULT ('-')," _
                             & "[pan_no] [varchar](20)  NOT NULL DEFAULT ('-')," _
                             & "[rate_of_interest] [numeric](6, 2)NOT NULL  DEFAULT ((0))," _
                             & "[interest_rule_id] [numeric](6, 2)  DEFAULT ((0))," _
                             & "[Area_code] [Varchar](2)  DEFAULT ('-')," _
                             & "[remark1] [varchar](100) NOT NULL DEFAULT ('-')," _
                             & "[remark2] [varchar](100) NOT NULL DEFAULT ('-')," _
                             & "[remark3] [varchar](100) NOT NULL  DEFAULT ('-')) "
            sqlresult = GMod.SqlExecuteNonQuery(createtablesql)
        End If
        Dim sql As String
        sql = "insert into " & GMod.ACC_HEAD _
        & " select '" & Cmpid & "', account_code, account_head_name, group_name, sub_group_name, credit_days, credit_limit, opening_dr, opening_cr, account_type, address, city, state, phone, pan_no, rate_of_interest, interest_rule_id, Area_code, remark1, remark2, remark3 from dbo.tmpacchead "
        sqlresult = GMod.SqlExecuteNonQuery(sql)

        sql = "insert into Groups " _
        & " select Group_name, Suffix, BS_PL, Amount, Sqorder, '" & Cmpid & "', Dr_Cr, EffectsIN from Groups where Cmp_id='TT'"
        sqlresult = GMod.SqlExecuteNonQuery(sql)

        sql = "insert into Vtype" _
        & " select '" & Cmpid & "', Vtype, Seqorder, Vou_no_seq from Vtype where Cmp_id='TT'"
        sqlresult = GMod.SqlExecuteNonQuery(sql)

        sql = "insert into Chq_conf" _
             & " select  '" & Cmpid & "', Group_name, Sub_group_name, Acc_Code, Acc_head, Vou_type from Chq_conf  where Cmp_id='TT'"
        sqlresult = GMod.SqlExecuteNonQuery(sql)
    End Sub
End Class