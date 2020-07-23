Public Class frmInvFromNarration

    Private Sub frmInvFromNarration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtfrom.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtfrom.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        dtto.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dtto.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        Dim sql As String = ""
        sql = "select * from " & GMod.ACC_HEAD & " WHERE group_name in('PURCHASE','SALE','JOURNAL','FEED SALE','CHICKS SALE','FEED TRANSFER','GOODS SENT','INTERNAL PARTY') "
        GMod.DataSetRet(sql, "head")

        cmbacccode.DataSource = GMod.ds.Tables("head")
        cmbacccode.DisplayMember = "account_code"

        cmbaccname.DataSource = GMod.ds.Tables("head")
        cmbaccname.DisplayMember = "account_head_name"

    End Sub
    Private Sub cmbaccname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbaccname.Leave
        cmbaccname.Enabled = False
        cmbacccode.Enabled = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sql As String = ""
        sql = "select narration,abs(dramt-cramt) from " & GMod.VENTRY & " where acc_head_code='" & cmbacccode.Text & "' and vou_type='" & ComboBox1.Text & "' and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "'  and narration not like '%hatch date%' and Pay_mode<>'-'"
        GMod.DataSetRet(sql, "narr")
        MsgBox(GMod.ds.Tables("narr").Rows.Count)
        Dim st() As String
        GMod.SqlExecuteNonQuery("delete from audit_stock where uname='" & GMod.username & "'")
        Dim i As Integer
        For i = 0 To ds.Tables("narr").Rows.Count - 1
            st = ds.Tables("narr").Rows(i)("narration").ToString.Split(" ")
            Dim y As Integer
            y = 9
            While y <= st.Length
                If y = 9 Then
                    sql = "insert into audit_stock(inv_no, item_name, qty, rate,led_amt,uname)" _
                    & " values(" & st(2) & ",'" & st(y - 5) & "'," & Val(st(y - 4)) & "," _
                    & Val(st(y - 1)) & "," & ds.Tables("narr").Rows(i)(1) & ",'" & GMod.username & "')"
                Else
                    sql = "insert into audit_stock(inv_no, item_name, qty, rate,led_amt,uname)" _
                    & " values(" & st(2) & ",'" & st(y - 5) & "'," & Val(st(y - 4)) & "," _
                    & Val(st(y - 1)) & ",0,'" & GMod.username & "')"
                End If
                GMod.SqlExecuteNonQuery(sql)
                y = y + 5
            End While
        Next
        GMod.DataSetRet("select * from audit_stock where uname='" & GMod.username & "'", "showfeed")
        Dim cr As New CrAduitStcok
        cr.SetDataSource(GMod.ds.Tables("showfeed"))
        cr.SetParameterValue("0", GMod.Cmpname)
        cr.SetParameterValue("1", "Date From  " & dtfrom.Text & " To " & dtto.Text)
        cr.SetParameterValue("2", "A/c:" & cmbacccode.Text & "-" & cmbaccname.Text & " / " & ComboBox1.Text)
        CrystalReportViewer1.ReportSource = cr
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sql As String = ""
        sql = "select narration,abs(dramt-cramt)  from " & GMod.VENTRY & " where acc_head_code='" & cmbacccode.Text & "' and vou_type='" & ComboBox1.Text & "' and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Pay_mode<>'-'"
        GMod.DataSetRet(sql, "narr")
        MsgBox(GMod.ds.Tables("narr").Rows.Count)
        Dim st() As String
        GMod.SqlExecuteNonQuery("delete from audit_stock where uname='" & GMod.username & "'")
        Dim i As Integer
        Try
            For i = 0 To ds.Tables("narr").Rows.Count - 1
                st = ds.Tables("narr").Rows(i)("narration").ToString.Split(" ")
                Dim y As Integer
                y = 9
                ' While y <= st.Length
                sql = "insert into audit_stock(inv_no, item_name, qty, rate,led_amt,uname)" _
                & " values(" & st(2) & ",'" & st(7) & "'," & Val(st(8)) & "," _
                & Val(st(13)) & "," & ds.Tables("narr").Rows(i)(1) & ",'" & GMod.username & "')"

                GMod.SqlExecuteNonQuery(sql)
                'End While
            Next
        Catch ex As Exception
        End Try
        GMod.DataSetRet("select * from audit_stock where uname='" & GMod.username & "'", "showfeed")
        Dim cr As New CrAduitStcok
        cr.SetDataSource(GMod.ds.Tables("showfeed"))
        cr.SetParameterValue("0", GMod.Cmpname)
        cr.SetParameterValue("1", "Date From  " & dtfrom.Text & " To " & dtto.Text)
        cr.SetParameterValue("2", "A/c:" & cmbacccode.Text & "-" & cmbaccname.Text & " / " & ComboBox1.Text)
        CrystalReportViewer1.ReportSource = cr
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmbacccode.Enabled = True
        cmbaccname.Enabled = True
        cmbaccname.Focus()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GMod.SqlExecuteNonQuery("delete from PrdLedger where uname='" & GMod.username & "'")
        Dim sql As String = ""
        sql = "select narration,abs(dramt-cramt),vou_no  from " & GMod.VENTRY & " where acc_head_code='" & cmbacccode.Text & "' and vou_type='" & ComboBox1.Text & "' and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "' and Pay_mode<>'-'"
        GMod.DataSetRet(sql, "narr")
        MsgBox(GMod.ds.Tables("narr").Rows.Count)
        Dim st() As String
        GMod.SqlExecuteNonQuery("delete from audit_stock where uname='" & GMod.username & "'")
        Dim i As Integer
        For i = 0 To ds.Tables("narr").Rows.Count - 1
            st = ds.Tables("narr").Rows(i)("narration").ToString.Split(" ")
            Dim y As Integer
            y = 9
            ' While y <= st.Length

            sql = "insert into PrdLedger(hdate, billno, billdate, vtype, vno, inqty," _
            & " infree,uname) values ("
            sql &= "'" & st(6) & "',"
            sql &= "'" & st(2) & "',"
            sql &= "'" & st(3) & "',"
            sql &= "'PURCHASE',"
            sql &= "'" & ds.Tables("narr").Rows(i)("vou_no") & "',"
            sql &= "'" & Val(st(9)) & "',"
            sql &= "'" & Val(st(11)) & "',"
            sql &= "'" & GMod.username & "')"
            GMod.SqlExecuteNonQuery(sql)

            'End While
            Dim prd() As String, pname As String
            prd = cmbaccname.Text.Split(" ")
            pname = prd(2) & " " + prd(3)
            sql = "insert into PrdLedger (hdate,vtype,vno,acc,outqty,outfree,outbillno,outbilldate,uname) "
            sql &= " select HatchDate,Vou_type,Vou_no,AccName,Qty,FreeQty,BillNo,BillDate,'" & GMod.username & "' from printdata where ProductName='" & pname & "' and session ='" & GMod.Session & "' and HatchDate='" & CDate(st(6)) & "' order by hatchdate "
            GMod.SqlExecuteNonQuery(sql)
        Next
        i = 0
        Try
            GMod.ds.Tables("ba").Dispose()
        Catch ex As Exception
        End Try
        GMod.DataSetRet("select * from PrdLedger where  uname='" & GMod.username & "' order by id", "ba")
        'Dim i As Integer
        Dim prbal, bal As Double
        prbal = 0
        prbal = GMod.ds.Tables("ba").Rows(i)("inqty") - GMod.ds.Tables("ba").Rows(i)("outqty")
        GMod.SqlExecuteNonQuery("update PrdLedger set balqty=" & prbal & " where id=" & GMod.ds.Tables("ba").Rows(i)("id"))
        For i = 0 To GMod.ds.Tables("ba").Rows.Count - 2
            bal = prbal + (GMod.ds.Tables("ba").Rows(i + 1)("inqty") - GMod.ds.Tables("ba").Rows(i + 1)("outqty"))
            GMod.SqlExecuteNonQuery("update PrdLedger set balqty=" & prbal & " where id=" & GMod.ds.Tables("ba").Rows(i + 1)("id"))
            prbal = bal
            GMod.SqlExecuteNonQuery("update PrdLedger set balqty=" & prbal & " where id=" & GMod.ds.Tables("ba").Rows(i + 1)("id"))
        Next
        GMod.DataSetRet("select * from PrdLedger where uname='" & GMod.username & "' order by id", "showfeed")
        Dim cr As New CrProductLedgerHatchries
        cr.SetDataSource(GMod.ds.Tables("showfeed"))
        cr.SetParameterValue("0", GMod.Cmpname)
        cr.SetParameterValue("1", "Date From  " & dtfrom.Text & " To " & dtto.Text)
        'cr.SetParameterValue("2", "A/c:" & cmbaccname.Text)
        CrystalReportViewer1.ReportSource = cr
    End Sub

    Private Sub btnfeedpurchases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfeedpurchases.Click
        Dim sql As String = ""
        sql = "select narration,abs(dramt-cramt),vou_no from " & GMod.VENTRY & " where acc_head_code='" & cmbacccode.Text & "' and vou_type='" & ComboBox1.Text & "' and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtto.Value.ToShortDateString & "'  and narration not like '%hatch date%' and Pay_mode<>'-'"
        GMod.DataSetRet(sql, "narr")
        MsgBox(GMod.ds.Tables("narr").Rows.Count)
        Dim st() As String
        GMod.SqlExecuteNonQuery("delete from audit_stock where uname='" & GMod.username & "'")
        Dim i As Integer
        For i = 0 To ds.Tables("narr").Rows.Count - 1
            st = ds.Tables("narr").Rows(i)("narration").ToString.Split(" ")
            Dim y As Integer
            y = 9
            While y <= st.Length
                sql = "insert into audit_stock(inv_no, item_name, qty, rate,led_amt,uname)" _
                & " values(" & st(2) & ",'" & st(y - 5) & "'," & Val(st(y - 4)) & "," _
                & Val(st(y - 1)) & "," & ds.Tables("narr").Rows(i)("vou_no") & ",'" & GMod.username & "')"
                GMod.SqlExecuteNonQuery(sql)
                y = y + 5
            End While
        Next
        GMod.DataSetRet("select * from audit_stock where uname='" & GMod.username & "'", "showfeedpur")
        Dim cr As New CrAduitStcok
        cr.SetDataSource(GMod.ds.Tables("showfeedpur"))
        cr.SetParameterValue("0", GMod.Cmpname)
        cr.SetParameterValue("1", "Date From  " & dtfrom.Text & " To " & dtto.Text)
        cr.SetParameterValue("2", "A/c:" & cmbacccode.Text & "-" & cmbaccname.Text & " / " & ComboBox1.Text)
        CrystalReportViewer1.ReportSource = cr
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class