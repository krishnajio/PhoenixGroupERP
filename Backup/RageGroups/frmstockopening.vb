Public Class frmstockopening

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbareaname.SelectedIndexChanged

    End Sub
    Dim Sqlsavestr, Sqlresult As String
    Private Sub frmstockopening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        fillArea()
        fillItems()
        fillgrid()
    End Sub
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area order by Areaname"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
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
    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdate.ValueChanged
        Session = GMod.Getsession(dtdate.Value)
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If Cmbitemname.Text = "" Then
            MsgBox("Item name ca't be null")
            Exit Sub
        End If
        If Txtqty.Text = "" Then
            MsgBox("Quantiy ca't be null")
            Exit Sub
        End If
        If txtRate.Text = "" Then
            MsgBox("Rate ca't be null")
            Exit Sub
        End If

        Sqlsavestr = "Insert into ItemOpening(AreaCode, ItemName, Qty, Rate, Unit, Session, Cmp_id, Uname) values ("
        Sqlsavestr &= "'" & Cmbareacode.Text.ToUpper & "',"
        Sqlsavestr &= "'" & Cmbitemname.Text.ToUpper & "',"
        Sqlsavestr &= "'" & Txtqty.Text & "',"
        Sqlsavestr &= "'" & txtRate.Text & "',"
        Sqlsavestr &= "'" & cmbunit.Text.ToUpper & "',"
        Sqlsavestr &= "'" & GMod.Getsession(dtdate.Value) & "',"
        Sqlsavestr &= "'" & GMod.Cmpid & "',"
        Sqlsavestr &= "'" & GMod.username & "')"


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
            'btnreset_Click(sender, e)
        End If
        ' txtitemname.Focus()

    End Sub
    Public Sub fillgrid()
        Dim sql As String
        sql = "select * from ItemOpening " 'where Uname='" & GMod.username & "'"
        GMod.DataSetRet(sql, "IO")
        dgItemOpening.DataSource = GMod.ds.Tables("IO")
    End Sub
    Dim rowidx As Integer
    Private Sub dgItemOpening_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgItemOpening.DoubleClick
        rowidx = dgItemOpening.CurrentCell.RowIndex
        Cmbareacode.Text = dgItemOpening(0, rowidx).Value
        Cmbitemname.Text = dgItemOpening(1, rowidx).Value
        Txtqty.Text = dgItemOpening(2, rowidx).Value
        txtRate.Text = dgItemOpening(3, rowidx).Value
        cmbunit.Text = dgItemOpening(5, rowidx).Value
        cmbAmount.Text = dgItemOpening(4, rowidx).Value
        btnmodify.Text = "&Update"
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim sqldelete As String
        sqldelete = "delete from ItemOpening where AreaCode='" & Cmbareacode.Text & "' and ItemName='" & Cmbitemname.Text & "' and Cmp_id='" & GMod.Cmpid & "'"
        GMod.SqlExecuteNonQuery(sqldelete)
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        btndelete_Click(sender, e)
        btnsave_Click(sender, e)
        fillgrid()
        btnmodify.Text = "&Modifiy"
    End Sub
End Class