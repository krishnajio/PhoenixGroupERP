Public Class frmDisburReg

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim Sqlsavestr, Sqlresult As String
    Private Sub frmstockopening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname

        GMod.DataSetRet("select * from Area", "Area")
        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"
        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"

        fillgrid()
        btnsave.Enabled = True
        btndelete.Enabled = False
        btnmodify.Enabled = False


    End Sub
    
  
    Dim Session As String
    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dthatchdate.ValueChanged
        ' Session = GMod.Getsession(dthatchdate.Value)
        fillgrid()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
     

        Sqlsavestr = "Insert into DisburReg(DisburNo, HatchDate, RecvDate, CollecDm, CollecRec, BankSlip, Remarks, TRNo, session, uname, entrydate, Area, AreaCode) values ("
        Sqlsavestr &= "'" & txtDisdurNo.Text & "',"
        Sqlsavestr &= "'" & dthatchdate.Value.ToShortDateString & "',"
        Sqlsavestr &= "'" & dtRecDate.Value.ToShortDateString & "',"
        Sqlsavestr &= "'" & Val(txtCollectionDm.Text) & "',"
        Sqlsavestr &= "'" & Val(txtCollectinRec.Text) & "',"
        Sqlsavestr &= "'" & txtBankSlip.Text & "',"
        Sqlsavestr &= "'" & txtRem.Text & "',"
        Sqlsavestr &= "'" & txtTrNo.Text & "',"
        Sqlsavestr &= "'" & GMod.Session & "',"
        Sqlsavestr &= "'" & GMod.username & "',"
        Sqlsavestr &= "'" & Now & "',"
        Sqlsavestr &= "'" & cmbAreaName.Text & "',"
        Sqlsavestr &= "'" & cmbAreaCode.Text & "')"
        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
        If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate Item Opening ", MsgBoxStyle.Critical)
                fillgrid()
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
        sql = "select * from DisburReg where session='" & GMod.Session & "'"
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
            lblId.Text = dgItemOpening(0, rowidx).Value
            txtDisdurNo.Text = dgItemOpening(1, rowidx).Value.ToString
            dthatchdate.Value = CDate(dgItemOpening(2, rowidx).Value)
            dtRecDate.Value = CDate(dgItemOpening(3, rowidx).Value)
            txtCollectionDm.Text = dgItemOpening(4, rowidx).Value.ToString
            txtCollectinRec.Text = dgItemOpening(5, rowidx).Value.ToString
            txtBankSlip.Text = dgItemOpening(6, rowidx).Value
            txtRem.Text = dgItemOpening(7, rowidx).Value
            txtTrNo.Text = dgItemOpening(8, rowidx).Value
            cmbAreaName.Text = dgItemOpening(12, rowidx).Value
        Catch ex As Exception

        End Try
        btnmodify.Text = "&Update"
        btnsave.Enabled = False
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        'If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

        '    Dim Sql As String
        '    Sql = "select * from printdata where hatchdate ='" & dthatchdate.Value.ToShortDateString & "'  and productname ='" & Cmbitemname.Text & "' and cmp_id='PHHA' and vou_type<>'PURCHASE'"
        '    GMod.DataSetRet(Sql, "prit_data")
        '    If GMod.ds.Tables("prit_data").Rows.Count > 0 Then
        '        MessageBox.Show("Unable to delete... ")
        '    Else
        '        GMod.SqlExecuteNonQuery("Delete from HatchWiseRate where Hatchdate='" & dthatchdate.Value & "' and id ='" & lblID.Text & "'")

        '        MessageBox.Show("Deleted... ")
        '        btnreset_Click(sender, e)
        '        fillgrid()
        '    End If
        'End If

    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

            GMod.SqlExecuteNonQuery("Delete from DisburReg where  id ='" & lblId.Text & "'")
            btnsave_Click(sender, e)
            fillgrid()
            btnmodify.Text = "&Modifiy"

            btnreset_Click(sender, e)
        End If
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtDisdurNo.Clear()
        txtCollectionDm.Clear()
        txtBankSlip.Text = ""
        txtCollectinRec.Text = ""
        txtRem.Clear()
        txtTrNo.Clear()
        btnsave.Enabled = True
        btndelete.Enabled = False
        btnmodify.Enabled = False
        txtDisdurNo.Focus()
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

    Private Sub dgItemOpening_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItemOpening.CellContentClick

    End Sub
End Class