Imports System.IO
Public Class frmXX
    Dim s, q As String
    Dim i, j As Integer
    Private Sub frmXX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        s = " select distinct vou_type from " & GMod.VENTRY
        GMod.DataSetRet(s, "vtx")
        cmbvt.DataSource = GMod.ds.Tables("vtx")
        cmbvt.DisplayMember = "vou_type"
    End Sub
    Dim sw As StreamWriter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sw = File.CreateText("c:\\xx.txt")
        For i = 0 To cmbvt.Items.Count - 1
            cmbvt.SelectedIndex = i
            s = "select max(cast(vou_no as bigint)) from " & GMod.VENTRY & " where vou_type='" & cmbvt.Text & "'"
            GMod.DataSetRet(s, "vnx")
            For j = 0 To Val(GMod.ds.Tables("vnx").Rows(0)(0).ToString)
                s = "select * from " & GMod.VENTRY & " where vou_type='" & cmbvt.Text & "' and vou_no='" & j + 1 & "'"
                GMod.DataSetRet(s, "xx1")
                If GMod.ds.Tables("xx1").Rows.Count > 0 Then

                Else
                    q = cmbvt.Text & "/" & j + 1 & "/" & GMod.Session & "/" & GMod.Cmpid
                    sw.WriteLine(q)
                End If
                Me.Text = cmbvt.Text & "/" & j + 1
            Next
        Next
        sw.Close()
    End Sub
    Dim sql As String = ""
    Dim up As String = ""
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim k As Integer = 0
        Dim n() As String
        Dim n1 As String
        'sql = "select * from printdata where session ='1213' and cmp_id='PHHA' and vou_type='SALES' and cast(vou_no as bigint) between 1 and 10 "
        sql = "select * from printdata where session ='1213' and cmp_id='PHHA' and vou_type='PURCHASE' and cast(vou_no as bigint) between " & TextBox1.Text & " and " & TextBox2.Text & " and productname ='BROILER CHICKS' order by cast(vou_no as bigint)"
        GMod.DataSetRet(sql, "pdatac")
        For k = 0 To GMod.ds.Tables("pdatac").Rows.Count - 1
            sql = "select * from ventry_phha_1213 where vou_type='PURCHASE' and vou_no='" & GMod.ds.Tables("pdatac").Rows(k)("vou_no") & "' and narration like '%BROILER CHICKS%'"
            GMod.DataSetRet(sql, "vdatam")
            n = GMod.ds.Tables("vdatam").Rows(0)("narration").ToString.Split("@")
            n1 = n(0) & " @ " & GMod.ds.Tables("pdatac").Rows(k)("rate")
            up = "update ventry_phha_1213 set dramt = '" & GMod.ds.Tables("pdatac").Rows(k)("Amount") & "', narration ='" & n1 & "' where vou_type='PURCHASE' and vou_no=" & GMod.ds.Tables("pdatac").Rows(k)("vou_no") & " and dramt >0 and narration like '%BROILER%'"
            GMod.SqlExecuteNonQuery(up)
            up = "update ventry_phha_1213 set cramt = '" & GMod.ds.Tables("pdatac").Rows(k)("Amount") & "', narration ='" & n1 & "' where vou_type='PURCHASE' and vou_no=" & GMod.ds.Tables("pdatac").Rows(k)("vou_no") & " and cramt >0 and narration like '%BROILER%'"
            GMod.SqlExecuteNonQuery(up)
        Next
        MessageBox.Show("Ok...")
    End Sub
End Class