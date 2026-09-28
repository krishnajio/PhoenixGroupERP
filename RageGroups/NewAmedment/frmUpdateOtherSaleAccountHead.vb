Imports System.Data.SqlClient

Public Class frmUpdateOtherSaleAccountHead
    Dim sql As String
    Private Sub frmUpdateOtherSaleAccountHead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select vtype from Vtype where cmp_id='PHOE'  and session='" & GMod.Getsession(Now) & "' and vtype like '%SALE%'"
        GMod.DataSetRet(sql, "CRVT")
        cmbVoucherType.DataSource = GMod.ds.Tables("CRVT")
        cmbVoucherType.DisplayMember = "vtype"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateOtherSaleAccountHead()
        sql = "select * from " & GMod.VENTRY & " where vou_no ='" & txtVoucherType.Text & "' and Vou_type='" & cmbVoucherType.Text & "'"
        GMod.DataSetRet(sql, "gridata")
        DataGridView1.DataSource = GMod.ds.Tables("gridata")
    End Sub
    Public Sub UpdateOtherSaleAccountHead()

        Using con As New SqlConnection(GMod.Connstr)
            Using cmd As New SqlCommand("sp_UpdateOtherSaleAccountHead", con)
                cmd.CommandType = CommandType.StoredProcedure
                ' 🔹 Parameters
                cmd.Parameters.AddWithValue("@AccountCode", txtNewAccountCode.Text)
                cmd.Parameters.AddWithValue("@VouType", cmbVoucherType.Text)
                cmd.Parameters.AddWithValue("@VouNo", txtVoucherType.Text)
                cmd.Parameters.AddWithValue("@OldCode", txtOldAccountCode.Text)
                Try
                    con.Open()
                    ' If procedure returns SELECT (Status, SessionId)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim status As String = reader("Status").ToString()
                        '' Dim sessionId As String = reader("SessionId").ToString()

                        MessageBox.Show("Status: " & status & vbCrLf)
                    End If

                    reader.Close()

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    con.Close()
                End Try

            End Using
        End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "select * from " & GMod.VENTRY & " where vou_no ='" & txtVoucherType.Text & "' and Vou_type='" & cmbVoucherType.Text & "'"
        GMod.DataSetRet(sql, "gridata")
        DataGridView1.DataSource = GMod.ds.Tables("gridata")
    End Sub
End Class