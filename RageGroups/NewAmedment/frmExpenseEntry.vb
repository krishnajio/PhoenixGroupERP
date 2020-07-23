
Public Class frmExpenseEntry
    Dim sql As String
    Private Sub frmExpenseEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNarration.Text = ""
        Dim k As Integer
        Try
            If setModifyFlag = True Then
                sql = "select convert(varchar, hatch_date, 3),hatch_date,area,no_of_chicks,deisel,toll_tax,da,la_ul,other,totalkms,ltrsmt,ltrscash, ltrsbpcl,driver_name,acc_name,acc_code from Expenses_det where vou_type='" & GMod.vou_type & "' and vou_no='" & GMod.vou_no & "' and session ='" & GMod.Session & "'"
                'no_of_chicks, area, deisel, toll_tax, da, other, driver_name, la_ul, id, uname, session, ltrsmt, totalkms, ltrscash, ltrsbpcl
                GMod.DataSetRet(sql, "exp_det")
                ' dgexpenses.DataSource = GMod.ds.Tables("exp_det")

                For k = 0 To GMod.ds.Tables("exp_det").Rows.Count - 1
                    dgexpenses.Rows.Add()
                    dgexpenses(0, k).Value = GMod.ds.Tables("exp_det").Rows(k)(0)
                    dgexpenses(1, k).Value = GMod.ds.Tables("exp_det").Rows(k)(1)
                    dgexpenses(2, k).Value = GMod.ds.Tables("exp_det").Rows(k)(2)
                    dgexpenses(3, k).Value = GMod.ds.Tables("exp_det").Rows(k)(3)
                    dgexpenses(4, k).Value = GMod.ds.Tables("exp_det").Rows(k)(4)
                    dgexpenses(5, k).Value = GMod.ds.Tables("exp_det").Rows(k)(5)
                    dgexpenses(6, k).Value = GMod.ds.Tables("exp_det").Rows(k)(6)
                    dgexpenses(7, k).Value = GMod.ds.Tables("exp_det").Rows(k)(7)
                    dgexpenses(8, k).Value = GMod.ds.Tables("exp_det").Rows(k)(8)
                    dgexpenses(9, k).Value = GMod.ds.Tables("exp_det").Rows(k)(9)
                    dgexpenses(10, k).Value = GMod.ds.Tables("exp_det").Rows(k)(10)
                    dgexpenses(11, k).Value = GMod.ds.Tables("exp_det").Rows(k)(11)
                    dgexpenses(12, k).Value = GMod.ds.Tables("exp_det").Rows(k)(12)
                    'dgexpenses(13, k).Value = GMod.ds.Tables("exp_det").Rows(k)(13)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgexpenses.CellContentClick

    End Sub
    Dim i As Integer = -1
    Private Sub detadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detadd.Click
        txtNarration.Text = "BEING VEHICLE EXPENSE " & txtarea.Text.ToUpper & " HATCH DATE " & dtpHatchDt.Text & " BY " & txtDriverName.Text.ToUpper
        Dim obj() As Object = {dtpHatchDt.Value.ToShortDateString, txtarea.Text, txtNoChicks.Text, txtDeisel.Text, txtToll.Text, txtda.Text, txtLA.Text, txtOther.Text, txtTotalkm.Text, txtDMt.Text, txtDriverName.Text, txtAcName.Text, lblcode.Text, txtDCash.Text, txtDBpcl.Text}
        If i <> -1 Then
            dgexpenses.Rows.RemoveAt(i)
            dgexpenses.Rows.Insert(i, obj)
        Else
            dgexpenses.Rows.Add(obj)
        End If
        clearall()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GMod.SqlExecuteNonQuery("delete from Expenses_tmp where uanme ='" & GMod.username & "'")
        Dim i As Integer
        For i = 0 To dgexpenses.Rows.Count - 1
            sql = "insert into Expenses_tmp(vou_type, vou_no, acc_code, " & _
            " acc_name, hatch_date, no_of_chicks, area, deisel, toll_tax," & _
            " da, other, driver_name, la_ul,uname,ltrsmt,totalkms,ltrscash,ltrsbpcl) values ("
            sql &= "'" & txtvou_type.Text & "',"
            sql &= "'" & txtvou_no.Text & "',"
            sql &= "'" & dgexpenses(12, i).Value.ToString & "',"
            sql &= "'" & dgexpenses(11, i).Value.ToString & "',"
            sql &= "'" & CDate(dgexpenses(0, i).Value) & "',"
            sql &= "'" & Val(dgexpenses(2, i).Value) & "',"
            sql &= "'" & dgexpenses(1, i).Value.ToString & "',"
            sql &= "'" & Val(dgexpenses(3, i).Value) & "',"
            sql &= "'" & Val(dgexpenses(4, i).Value) & "',"
            sql &= "'" & Val(dgexpenses(5, i).Value) & "',"
            sql &= "'" & dgexpenses(7, i).Value & "',"
            sql &= "'" & dgexpenses(10, i).Value & "',"
            sql &= "'" & Val(dgexpenses(6, i).Value) & "',"

            sql &= "'" & GMod.username & "',"
            sql &= "'" & dgexpenses(9, i).Value & "',"
            sql &= "'" & dgexpenses(8, i).Value & "',"
            sql &= "'" & dgexpenses(13, i).Value & "',"
            sql &= "'" & dgexpenses(14, i).Value & "')"
            GMod.SqlExecuteNonQuery(sql)
        Next
        i = Nothing
        dgexpenses.Rows.Clear()
        Me.Close()

        Try
            GMod.ds.Tables("exp_det").Clear()
        Catch ex As Exception

        End Try
    End Sub
    Sub clearall()
        txtNoChicks.Clear()
        txtarea.Clear()
        txtDeisel.Clear()
        txtToll.Clear()
        txtda.Clear()
        txtOther.Clear()
        txtDriverName.Clear()
        txtLA.Clear()
        txtTotalkm.Clear()
        txtDMt.Clear()
    End Sub
    Private Sub dgexpenses_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgexpenses.CellDoubleClick
        i = e.RowIndex
        dtpHatchDt.Value = CDate(dgexpenses(0, i).Value)
        txtNoChicks.Text = dgexpenses(1, i).Value
        txtarea.Text = dgexpenses(2, i).Value
        txtDeisel.Text = dgexpenses(3, i).Value
        txtToll.Text = dgexpenses(4, i).Value
        txtda.Text = dgexpenses(5, i).Value
        txtOther.Text = dgexpenses(6, i).Value
        txtDriverName.Text = dgexpenses(7, i).Value
        txtLA.Text = dgexpenses(8, i).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GMod.SqlExecuteNonQuery("delete from Expenses_tmp where uanme ='" & GMod.username & "'")
        dgexpenses.Rows.Clear()
    End Sub

    Private Sub dtpHatchDt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpHatchDt.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpHatchDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHatchDt.ValueChanged

    End Sub

    Private Sub txtarea_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtarea.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtarea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtarea.TextChanged

    End Sub

    Private Sub txtNoChicks_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoChicks.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtNoChicks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoChicks.TextChanged

    End Sub

    Private Sub txtDeisel_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDeisel.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDeisel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeisel.TextChanged
        txtTotal.Text = Val(txtDeisel.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)
    End Sub

    Private Sub txtToll_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtToll.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtToll_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtToll.TextChanged
        txtTotal.Text = Val(txtDeisel.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)

    End Sub

    Private Sub txtda_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtda.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtda.TextChanged
        txtTotal.Text = Val(txtDeisel.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)

    End Sub

    Private Sub txtLA_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLA.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtLA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLA.TextChanged
        txtTotal.Text = Val(txtDeisel.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)

    End Sub

    Private Sub txtOther_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOther.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtOther_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOther.TextChanged
        txtTotal.Text = Val(txtDeisel.Text) + Val(txtToll.Text) + Val(txtda.Text) + Val(txtLA.Text) + Val(txtOther.Text)

    End Sub

    Private Sub txtTotalkm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotalkm.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtTotalkm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalkm.TextChanged

    End Sub

    Private Sub txtTotalDiedelltrs_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDMt.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtTotalDiedelltrs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDMt.TextChanged

    End Sub

    Private Sub txtDriverName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDriverName.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDriverName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDriverName.TextChanged

    End Sub
End Class