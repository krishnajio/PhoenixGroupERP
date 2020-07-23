Public Class frmChicksratemaster

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAREA.SelectedIndexChanged

    End Sub
    Dim Sqlsavestr, Sqlresult As String
    Private Sub frmstockopening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        fillArea()
        fillItems()
        fillgrid()
        btnsave.Enabled = True
        btndelete.Enabled = False
        btnmodify.Enabled = False
        CmbHatchery.SelectedIndex = 0

    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select prefix, areaname,STATE from Area order by areaname"
        GMod.DataSetRet(sqlarea, "Area")

        CmbAREA.DataSource = GMod.ds.Tables("Area")
        CmbAREA.DisplayMember = "areaname"
        Cmbarecode.DataSource = GMod.ds.Tables("Area")
        Cmbarecode.DisplayMember = "prefix"
        CmbState.DataSource = GMod.ds.Tables("Area")
        CmbState.DisplayMember = "STATE"
    End Sub
    Public Sub fillItems()
        Dim sql As String
        sql = "select * from ItemMaster where cmp_id='" & GMod.Cmpid & "' order by ItemName "
        GMod.DataSetRet(sql, "Item")

        Cmbitemname.DataSource = GMod.ds.Tables("Item")
        Cmbitemname.DisplayMember = "ItemName"

        txtRate.DataSource = GMod.ds.Tables("Item")
        txtRate.DisplayMember = "Rate"

    End Sub
    Dim Session As String
    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dthatchdate.ValueChanged
        ' Session = GMod.Getsession(dthatchdate.Value)
        fillgrid()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If Cmbitemname.Text = "" Then
            MsgBox("Item name ca't be null")
            Exit Sub
        End If

        If txtRate.Text = "" Then
            MsgBox("Rate ca't be null")
            Exit Sub
        End If

        Sqlsavestr = "Insert into HatchWiseRate( state, AreaCode, Hatchdate, rate, Product,  Areaname,cmp_id,qty,hatchery,transmortality) values ("
        Sqlsavestr &= "'" & CmbState.Text & "',"
        Sqlsavestr &= "'" & Cmbarecode.Text & "',"
        Sqlsavestr &= "'" & dthatchdate.Value.ToShortDateString & "',"
        Sqlsavestr &= "'" & Val(txtRate.Text) & "',"
        Sqlsavestr &= "'" & Cmbitemname.Text & "',"
        Sqlsavestr &= "'" & CmbAREA.Text & "',"
        Sqlsavestr &= "'" & GMod.Cmpid & "',"
        Sqlsavestr &= "'" & Val(Txtqty.Text) & "',"
        Sqlsavestr &= "'" & CmbHatchery.Text & "',"
        Sqlsavestr &= "'" & Val(Txtmort.Text) & "')"
        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
        If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate Item Opening ", MsgBoxStyle.Critical)
                fillgrid()
                Cmbitemname.Focus()
            Else
                MsgBox("Error :" & Sqlresult, MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Information saved", MsgBoxStyle.Information)
            btnreset_Click(sender, e)
        End If
        ' txtitemname.Focus()
        fillgrid()
    End Sub
    Public Sub fillgrid()
        Dim sql As String
        'sql = "select state,Product,Hatchdate, rate , id from HatchWiseRate where Hatchdate='" & dthatchdate.Value.ToShortDateString & "' and cmp_id='" & GMod.Cmpid & "'"
        sql = "select Areaname,Product,Hatchdate,rate,id,qty,hatchery,transmortality from HatchWiseRate where Hatchdate='" & dthatchdate.Value.ToShortDateString & "' and cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(sql, "hwr")
        dgItemOpening.DataSource = GMod.ds.Tables("hwr")
    End Sub
    Dim rowidx As Integer

    
    Private Sub dgItemOpening_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgItemOpening.DoubleClick

        btnsave.Enabled = False
        btndelete.Enabled = True
        btnmodify.Enabled = True

        rowidx = dgItemOpening.CurrentCell.RowIndex
        Try
            rowidx = dgItemOpening.CurrentCell.RowIndex
            CmbAREA.Text = dgItemOpening(0, rowidx).Value
            Cmbitemname.Text = dgItemOpening(1, rowidx).Value
            dthatchdate.Value = CDate(dgItemOpening(2, rowidx).Value)
            txtRate.Text = dgItemOpening(3, rowidx).Value
            lblID.Text = dgItemOpening(4, rowidx).Value
            Txtqty.Text = dgItemOpening(5, rowidx).Value
            CmbHatchery.Text = dgItemOpening(6, rowidx).Value
            Txtmort.Text = dgItemOpening(7, rowidx).Value
        Catch ex As Exception

        End Try
        btnmodify.Text = "&Update"
        btnsave.Enabled = False
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

            Dim Sql As String
            Sql = "select * from printdata where hatchdate ='" & dthatchdate.Value.ToShortDateString & "'  and productname ='" & Cmbitemname.Text & "' and cmp_id='PHHA' and vou_type<>'PURCHASE'"
            GMod.DataSetRet(Sql, "prit_data")
            If GMod.ds.Tables("prit_data").Rows.Count > 0 Then
                MessageBox.Show("Unable to delete... ")
            Else
                GMod.SqlExecuteNonQuery("Delete from HatchWiseRate where Hatchdate='" & dthatchdate.Value & "' and id ='" & lblID.Text & "'")

                MessageBox.Show("Deleted... ")
                btnreset_Click(sender, e)
                fillgrid()
            End If
        End If

    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Dim Sql As String
            Sql = "select * from printdata where hatchdate ='" & dthatchdate.Value.ToShortDateString & "'  and productname ='" & Cmbitemname.Text & "' and cmp_id='PHHA' and vou_type<>'PURCHASE'"
            GMod.DataSetRet(Sql, "prit_data")
            If GMod.ds.Tables("prit_data").Rows.Count > 0 Then
                MessageBox.Show("Unable to change... ")
            Else
                GMod.SqlExecuteNonQuery("Delete from HatchWiseRate where Hatchdate='" & dthatchdate.Value & "' and id ='" & lblID.Text & "'")
                btnsave_Click(sender, e)
                fillgrid()
                btnmodify.Text = "&Modifiy"
            End If
            btnreset_Click(sender, e)
        End If
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Txtmort.Text = ""
        Txtqty.Text = ""
        txtRate.Text = ""
        btnsave.Enabled = True
        btndelete.Enabled = False
        btnmodify.Enabled = False
    End Sub
    Private Sub frmDataEntry_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter And Not (e.Alt Or e.Control) Then
            If Me.ActiveControl.GetType Is GetType(TextBox) Or Me.ActiveControl.GetType Is GetType(CheckBox) Or Me.ActiveControl.GetType Is GetType(DateTimePicker) Or Me.ActiveControl.GetType Is GetType(ComboBox) Or Me.ActiveControl.GetType Is GetType(CheckedListBox) Or Me.ActiveControl.GetType Is GetType(DataGridView) Then
                If e.Shift Then
                    Me.ProcessTabKey(False)
                Else
                    Me.ProcessTabKey(True)
                End If
            End If
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class