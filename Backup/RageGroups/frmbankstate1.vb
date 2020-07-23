Public Class frmbankstate1
    Dim sql As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim n As Integer, i As Integer, c As Integer = 0
            sql = "select max(cast(vou_no as bigint)) from " & GMod.VENTRY & "  where vou_type='CR VOUCHER'"
            GMod.DataSetRet(sql, "no")
            n = CInt(GMod.ds.Tables("no").Rows(0)(0))
            sql = "select vou_no  from " & GMod.VENTRY & "  where vou_type='CR VOUCHER' order by cast(vou_no as bigint) "
            GMod.DataSetRet(sql, "no1")
            'Do While i <= GMod.ds.Tables("no1").Rows.Count - 1
            For i = 0 To GMod.ds.Tables("no1").Rows.Count - 1
                If i + 1 = Val(GMod.ds.Tables("no1").Rows(c)("vou_no")) Then
                    'Exit For
                    c = c + 1
                Else
                    ListBox1.Items.Add(i + 1)
                    'GoTo x
                    'i = i + 1
                    'MsgBox(GMod.ds.Tables("no1").Rows(i)("vou_no"))
                End If
            Next
            'Loop
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GMod.SqlExecuteNonQuery("delete from tfeed")

        Dim i As Integer
        Dim sptNarration() As String
        Dim sptTrNo() As String
        sql = "select narration  from " & GMod.VENTRY & "  where vou_type='CR VOUCHER'  and left(acc_head_code,2) = '" & cmbAreaCode.Text & "' order by cast(vou_no as bigint)"
        GMod.DataSetRet(sql, "no1")
        GMod.SqlExecuteNonQuery("delete from tfeed")
        For i = 0 To GMod.ds.Tables("no1").Rows.Count - 1
            sptNarration = GMod.ds.Tables("no1").Rows(i)("narration").ToString.Split("#")
            sptTrNo = sptNarration(1).Split(".")
            'ListBox2.Items.Add(Val(sptTrNo(1)))
            GMod.SqlExecuteNonQuery("insert into tfeed(v) values(" & sptTrNo(1) & ")")
        Next
        Dim c As Integer
        ListBox2.Items.Clear()
        For i = Val(TextBox1.Text) To Val(TextBox2.Text)

            sql = "select * from tfeed where v = " & i
            GMod.DataSetRet(sql, "no1")
            If GMod.ds.Tables("no1").Rows.Count = 0 Then
                ListBox2.Items.Add(i)
            Else

            End If
        Next

        MsgBox("OK")
        If MessageBox.Show("want to add", "confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If ListBox2.Items.Count > 0 Then
                For i = 0 To ListBox2.Items.Count - 1
                    ListBox3.Items.Add(cmbAreaName.Text & "->" & ListBox2.Items(i))
                    ' ComboBox1.Items.Add(cmbAreaName.Text & "->" & ListBox2.Items(i))

                    sql = "insert into misstr (ff, session, cmpid) values("
                    sql &= "'" & cmbAreaName.Text & "->" & ListBox2.Items(i) & "',"
                    sql &= "'" & GMod.Session & "',"
                    sql &= "'" & GMod.Cmpid & "')"
                    GMod.SqlExecuteNonQuery(sql)
                Next
            End If
        End If
        cmbAreaName.Focus()
        'select * from tfeed order by v
        'Try
        '    Dim n As Integer, c As Integer = 0
        '    sql = "select max(v) from tfeed "
        '    GMod.DataSetRet(sql, "no")
        '    n = CInt(GMod.ds.Tables("no").Rows(0)(0))
        '    sql = "select * from tfeed order by v"
        '    GMod.DataSetRet(sql, "no1")
        '    'Do While i <= GMod.ds.Tables("no1").Rows.Count - 1
        '    For i = 0 To n
        '        If i + 1 = Val(GMod.ds.Tables("no1").Rows(c)("v")) Then
        '            'Exit For
        '            c = c + 1
        '            MsgBox(Val(GMod.ds.Tables("no1").Rows(c)("v")))
        '        Else
        '            ListBox2.Items.Add(i + 1)
        '            'GoTo x
        '            'i = i + 1
        '            'MsgBox(GMod.ds.Tables("no1").Rows(i)("vou_no"))
        '        End If
        '    Next
        '    'Loop
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub frmbankstate1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.SelectAll()
    End Sub

    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        If e.KeyCode = Keys.Enter Then
            Button2.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub cmbAreaName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyUp
        If e.KeyCode = Keys.Enter Then
            TextBox1.Focus()
        End If
    End Sub

    Private Sub cmbAreaName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAreaName.SelectedIndexChanged

    End Sub

    Private Sub Button2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbAreaCode.Focus()
        End If
    End Sub
End Class