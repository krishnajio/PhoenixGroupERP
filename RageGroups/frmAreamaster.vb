Public Class frmAreamaster

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbareaname.SelectedIndexChanged

    End Sub
    Dim Sqlsavestr, Sqlresult As String
    Private Sub frmstockopening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & GMod.Cmpname
        fillArea()
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

    Dim Session As String
    Private Sub dtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If CmbState.Text = "" Then
            MsgBox("Item name ca't be null")
            Exit Sub
        End If


        Sqlsavestr = "Insert into Area(Areaname, prefix, state) values ("
        Sqlsavestr &= "'" & Cmbareaname.Text.ToUpper & "',"
        Sqlsavestr &= "'" & Cmbareacode.Text.ToUpper & "',"
        Sqlsavestr &= "'" & CmbState.Text.ToUpper & "',"
       


        Sqlresult = GMod.SqlExecuteNonQuery(Sqlsavestr)
        If Sqlresult <> "SUCCESS" Then
            If Sqlresult.Contains("PRIMARY") Then
                MsgBox("Error :Duplicate Item Opening ", MsgBoxStyle.Critical)
                fillgrid()
                CmbState.Focus()
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
        sql = "select * from area " 'where Uname='" & GMod.username & "'"
        GMod.DataSetRet(sql, "IO")
        dgItemOpening.DataSource = GMod.ds.Tables("IO")
    End Sub
    Dim rowidx As Integer
    Private Sub dgItemOpening_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgItemOpening.DoubleClick
        rowidx = dgItemOpening.CurrentCell.RowIndex
        Cmbareacode.Text = dgItemOpening(0, rowidx).Value
        CmbState.Text = dgItemOpening(1, rowidx).Value
       
    End Sub

  

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click

        MessageBox.Show(GMod.SqlExecuteNonQuery("update area set state ='" & CmbState.Text & "' where prefix ='" & Cmbareacode.Text & "'"))
        fillgrid()
    End Sub

    Private Sub CmbState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbState.SelectedIndexChanged

    End Sub

    Private Sub dgItemOpening_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOpening.CellContentClick

    End Sub
End Class