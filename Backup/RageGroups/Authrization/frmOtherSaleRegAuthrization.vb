Imports System.Data.SqlClient
Public Class frmOtherSaleRegAuthrization

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        txtCrNoFrom.Enabled = False
        txtCrNoTo.Enabled = False
        'If CheckBox1.Checked = False Then
        GMod.DataSetRet("select * from OtherSaleData  where vou_type in ('" & voutype.Text & "') and cast(Vou_no as numeric(20)) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & "  AND session = '" & GMod.Session & "' and authr='-' ORDER BY CAST(VOU_NO AS BIGINT),ID ", "SaleReg1")
        'Else
        'GMod.DataSetRet("select * from OtherSaleData  where vou_type='OTHER SALE RET.' and cast(Vou_no as bigint) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & " ORDER BY ID ", "SaleReg1")

        ' End If
        'If CheckBox2.Checked = True Then
        'GMod.DataSetRet("select * from OtherSaleData  where vou_type='" & voutype.Text & "' and cast(Vou_no as bigint) between " & txtCrNoFrom.Text & " and  " & txtCrNoTo.Text & " ORDER BY ID ", "SaleReg1")
        'End If
        Dim crsr As New CryOtherSaleReg
        crsr.SetDataSource(GMod.ds.Tables("SaleReg1"))
        crsr.SetParameterValue("p1", GMod.Cmpname)
        crsr.SetParameterValue("p2", "Invoice No. From " & txtCrNoFrom.Text & " To " & txtCrNoTo.Text)
        crsr.SetParameterValue("p3", "Session " & GMod.Session)
        crsr.SetParameterValue("p4", "User Name " & GMod.username)
        'If CheckBox1.Checked = False Then
        crsr.SetParameterValue("p5", "Sale Register - B ")
        'Else
        'crsr.SetParameterValue("p5", "Sale Return - B ")
        'End If
        'If CheckBox1.Checked = True Then
        crsr.SetParameterValue("p5", voutype.Text)
        'End If
        CrystalReportViewer1.ReportSource = crsr


    End Sub
    Dim sql As String
    Private Sub btnAuth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuth.Click
        Dim i As Integer
        Dim trans As SqlTransaction
        trans = GMod.SqlConn.BeginTransaction
        Try

            Sql = " update " & GMod.VENTRY & " set pay_mode='" & GMod.username & "'  where vou_type='" & voutype.Text _
                          & "' and cast(vou_no as bigint) between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "'"
            Dim cmd As New SqlCommand(Sql, GMod.SqlConn, trans)
            cmd.ExecuteNonQuery()


            ' sql = "update tdsentry set authr='-' where session ='1112'"
            sql = " update othersaledata  set authr='" & GMod.username & "'  where vou_type='" & voutype.Text _
                                     & "' and cast(vou_no as bigint) between '" & txtCrNoFrom.Text & "' and '" & txtCrNoTo.Text & "' and session ='" & GMod.Session & "' and cmp_id='" & GMod.Cmpid & "'"
            Dim cmdtds As New SqlCommand(Sql, GMod.SqlConn, trans)
            cmdtds.ExecuteNonQuery()



            trans.Commit()
            MsgBox("Authorization Complete", MsgBoxStyle.Information)
        Catch ex As Exception
            trans.Rollback()
        End Try
    End Sub
End Class