Imports System.IO
Public Class frmServerdetection

    Private Sub frmServerdetection_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub
    Private Sub frmServerdetection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbserver.Focus()
        Dim DT1 As New DataTable
        Dim row1 As DataRow
        DT1 = Sql.SqlDataSourceEnumerator.Instance.GetDataSources()
        For Each row1 In DT1.Rows
            cmbserver.Items.Add(row1("ServerName"))
            'MsgBox("Server " & row1("ServerName"))
        Next
    End Sub

    Private Sub cmbserver_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbserver.SelectedIndexChanged

    End Sub
    Private Sub btncontinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontinue.Click
        Try
            'If bool = True Then
            Dim ConnStr As String = "Data Source= " & cmbserver.Text & ";Initial Catalog=" & txtdb.Text & ";User ID=" & txtusername.Text & ";Password=" & txtpwd1.Text & ";Connect Timeout=3000;"
            'MsgBox(ConnStr)
            Dim tmpstr As String
            tmpstr = EncryptionStr(ConnStr, True)
            Dim fs As New FileStream("Config_ERP.txt", FileMode.Create)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(tmpstr)
            sr.Close()
            GMod.Connstr = ConnStr
            frmlogin.Show()
            Me.Hide()
            File.Copy("Config_ERP.txt", "C:\Config_ERP.txt")
            'End If
        Catch ex As Exception

        End Try

    End Sub
    Dim bool As Boolean = False
    Private Sub txtpwd1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpwd1.Leave
        Try
            Dim i As Integer
            If txtpwd.Text <> txtpwd1.Text Then
                MsgBox("Password does't matches", MsgBoxStyle.Critical)
                txtpwd.Focus()
                Exit Sub
            Else
                btncontinue.Focus()
            End If
            Dim ConnStrMaster As String = "Data Source= " & cmbserver.Text & ";Initial Catalog=master;User ID=" & txtusername.Text & ";Password=" & txtpwd1.Text & ""
            Dim da As New SqlClient.SqlDataAdapter("exec sp_databases", ConnStrMaster)
            da.Fill(GMod.ds, "DbNames")
            For i = 0 To GMod.ds.Tables("DbNames").Rows.Count - 1
                'MsgBox(GMod.ds.Tables("DbNames").Rows(i)(0).ToString)
                If GMod.ds.Tables("DbNames").Rows(i)(0).ToString = "RagaGroup" Then
                    bool = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "Data bases is not attached")
        End Try

    End Sub

    Private Sub txtpwd1_TextChanged(sender As Object, e As EventArgs) Handles txtpwd1.TextChanged

    End Sub
End Class