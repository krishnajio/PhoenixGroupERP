Imports System.Data
Imports System.Data.SqlClient
Public Class frmPostDataToaccNewBAak
    Dim sql As String
    Private Sub frmPostDataToacc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and Vtype in ('BANK','CASH')"
        GMod.DataSetRet(sql, "CRVT")
        cmbvoutype.DataSource = GMod.ds.Tables("CRVT")
        cmbvoutype.DisplayMember = "vtype"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql = "select DISTINCT vou_type,vou_no from dummy_VENTRY where vou_type='" & cmbvoutype.Text & "' and session='1112' and dramt>0 and  Posted='N' AND CMP_ID ='" & GMod.Cmpid & "'" ' order by cast(vou_no as bigint) "
        GMod.DataSetRet(sql, "dventry")
        dgBillNo.DataSource = GMod.ds.Tables("dventry")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim trans As SqlTransaction
        trans = GMod.SqlConn.BeginTransaction

        Try
            Dim i As Integer
            For i = 0 To dgBillNo.Rows.Count - 1
                If dgBillNo(0, i).Value = 1 Then
                    sql = "insert into " & GMod.VENTRY & "(Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date ) select Cmp_id, Uname, Entry_id, '" & dgBillNo("NewVoucheNo", i).Value & "', Vou_type, '" & CDate(dgBillNo("NewDate", i).Value) & "', Acc_head_code, Acc_head, dramt, cramt, '" & GMod.username & "', Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date from dummy_VENTRY where vou_no='" & dgBillNo("vou_no", i).Value & "' and vou_type='" & cmbvoutype.Text & "' and session ='1112' and Posted='N'"
                    Dim cmd1 As New SqlCommand(sql, GMod.SqlConn, trans)
                    cmd1.ExecuteNonQuery()
                    ' GMod.SqlExecuteNonQuery(sql)
                    sql = "update dummy_VENTRY set Posted='Y' where vou_no='" & dgBillNo("vou_no", i).Value & "' and vou_type='" & cmbvoutype.Text & "' and session ='1112' and Posted='N'"
                    'GMod.SqlExecuteNonQuery(sql)
                    Dim cmd2 As New SqlCommand(sql, GMod.SqlConn, trans)
                    cmd2.ExecuteNonQuery()

                    sql = "update chq_issue set vouno ='" & dgBillNo("NewVoucheNo", i).Value & "' , session ='1213' where vouno = '" & dgBillNo("vou_no", i).Value & "' and session ='1112'"

                    'Dim cmd3 As New SqlCommand(sql, GMod.SqlConn, trans)
                    'cmd3.ExecuteNonQuery()

                End If
            Next
            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message)
        End Try

        MsgBox("Voucher Posted...", MsgBoxStyle.Information)
        Button1_Click(sender, e)

        trans = Nothing
    End Sub
End Class