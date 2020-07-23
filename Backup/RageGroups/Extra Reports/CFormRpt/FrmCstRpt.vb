Public Class FrmCstRpt

    Private Sub FrmCstRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'M.P
        'Out of MP


        'Dim sql As String = "select account_code,account_head_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
        '    & "  order by account_head_name"

        Dim sql As String = "select distinct for_where  from purchase_data where session ='" & GMod.Session & "'"
        GMod.DataSetRet(sql, "accheadbank1")
        '  cmbacheadcode.DataSource = GMod.ds.Tables("accheadbank1")
        ' cmbacheadcode.DisplayMember = "account_code"

        cmbacheadname.DataSource = GMod.ds.Tables("accheadbank1")
        cmbacheadname.DisplayMember = "for_where"


        'sql = "select distinct state from  " & GMod.ACC_HEAD & ""
        'GMod.DataSetRet(sql, "getstate")
        'cmbstate.DataSource = GMod.ds.Tables("getstate")
        'cmbstate.DisplayMember = "state"



    End Sub
    Dim sql As String
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        dgdl.Visible = False
        'If CheckBox1.Checked = True Then
        '    sql = "select a.account_head_name,a.address,a.city,a.state,b.* from " & GMod.ACC_HEAD & " a join Purchase_Data b"
        '    sql += " on(a.account_code=b.party_code and a.cmp_id=b.cmp_id) "
        '    sql += " where a.cmp_id='" & GMod.Cmpid & "' and b.Bill_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and b.session ='" & GMod.Session & "'"

        'Else

        'M.P
        'C.G
        'BIHAR
        'M.H
        'W.B

        Select Case cmbstate.Text
            Case "M.P"
                sql = "select a.account_head_name,a.address,a.city,a.state, For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, party_code, item_code, item_name, rate, lst_rate, qty, unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno,  session, username, amt, party_amt, inwdate,  vathead, csthead, cst_code, cst_amt, porate, fr_head, cform, a.remark2 authr, po_date, form49No, form49issue, itemname, mkt_rate from " & GMod.ACC_HEAD & " a join Purchase_Data b"
                sql += " on(a.account_code=b.party_code and a.cmp_id=b.cmp_id) "
                sql += " where a.cmp_id='" & GMod.Cmpid & "' and b.for_where in (SELECT prdunit FROM prdunit WHERE cMP_ID ='" & GMod.Cmpid & "' AND state ='M.P')  and b.Bill_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and b.session ='" & GMod.Session & "' and a.state not in ('M.P','') and cst_amt >0 order by account_head_name"
            Case "C.G"
                sql = "select a.account_head_name,a.address,a.city,a.state, For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, party_code, item_code, item_name, rate, lst_rate, qty, unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno,  session, username, amt, party_amt, inwdate,  vathead, csthead, cst_code, cst_amt, porate, fr_head, cform, a.remark2 authr, po_date, form49No, form49issue, itemname, mkt_rate from " & GMod.ACC_HEAD & " a join Purchase_Data b"
                sql += " on(a.account_code=b.party_code and a.cmp_id=b.cmp_id) "
                sql += " where a.cmp_id='" & GMod.Cmpid & "' and b.for_where in (SELECT prdunit FROM prdunit WHERE cMP_ID ='" & GMod.Cmpid & "' AND state ='C.G')  and b.Bill_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and b.session ='" & GMod.Session & "' and a.state not in ('C.G','') and cst_amt >0 order by account_head_name"
            Case "W.B"
                sql = "select a.account_head_name,a.address,a.city,a.state, For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, party_code, item_code, item_name, rate, lst_rate, qty, unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno,  session, username, amt, party_amt, inwdate,  vathead, csthead, cst_code, cst_amt, porate, fr_head, cform, a.remark2 authr, po_date, form49No, form49issue, itemname, mkt_rate from " & GMod.ACC_HEAD & " a join Purchase_Data b"
                sql += " on(a.account_code=b.party_code and a.cmp_id=b.cmp_id) "
                sql += " where a.cmp_id='" & GMod.Cmpid & "' and b.for_where in (SELECT prdunit FROM prdunit WHERE cMP_ID ='" & GMod.Cmpid & "' AND state ='W.B')  and b.Bill_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and b.session ='" & GMod.Session & "' and a.state not in ('W.B','') and cst_amt >0 order by account_head_name"
            Case "BIHAR"
                sql = "select a.account_head_name,a.address,a.city,a.state, For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, party_code, item_code, item_name, rate, lst_rate, qty, unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno,  session, username, amt, party_amt, inwdate,  vathead, csthead, cst_code, cst_amt, porate, fr_head, cform, a.remark2 authr, po_date, form49No, form49issue, itemname, mkt_rate from " & GMod.ACC_HEAD & " a join Purchase_Data b"
                sql += " on(a.account_code=b.party_code and a.cmp_id=b.cmp_id) "
                sql += " where a.cmp_id='" & GMod.Cmpid & "' and b.for_where in (SELECT prdunit FROM prdunit WHERE cMP_ID ='" & GMod.Cmpid & "' AND state ='BIHAR')  and b.Bill_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and b.session ='" & GMod.Session & "' and a.state not in ('BIHAR','') and cst_amt >0 order by account_head_name"
            Case "M.H"
                sql = "select a.account_head_name,a.address,a.city,a.state, For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, party_code, item_code, item_name, rate, lst_rate, qty, unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno,  session, username, amt, party_amt, inwdate,  vathead, csthead, cst_code, cst_amt, porate, fr_head, cform, a.remark2 authr, po_date, form49No, form49issue, itemname, mkt_rate from " & GMod.ACC_HEAD & " a join Purchase_Data b"
                sql += " on(a.account_code=b.party_code and a.cmp_id=b.cmp_id) "
                sql += " where a.cmp_id='" & GMod.Cmpid & "' and b.for_where in (SELECT prdunit FROM prdunit WHERE cMP_ID ='" & GMod.Cmpid & "' AND state ='M.H')  and b.Bill_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and b.session ='" & GMod.Session & "' and a.state not in ('M.H','') and cst_amt >0 order by account_head_name"
            Case "U.P"
                sql = "select a.account_head_name,a.address,a.city,a.state, For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, party_code, item_code, item_name, rate, lst_rate, qty, unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno,  session, username, amt, party_amt, inwdate,  vathead, csthead, cst_code, cst_amt, porate, fr_head, cform, a.remark2 authr, po_date, form49No, form49issue, itemname, mkt_rate from " & GMod.ACC_HEAD & " a join Purchase_Data b"
                sql += " on(a.account_code=b.party_code and a.cmp_id=b.cmp_id) "
                sql += " where a.cmp_id='" & GMod.Cmpid & "' and b.for_where in (SELECT prdunit FROM prdunit WHERE cMP_ID ='" & GMod.Cmpid & "' AND state ='U.P')  and b.Bill_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and b.session ='" & GMod.Session & "' and a.state not in ('M.H','') and cst_amt >0 order by account_head_name"

        End Select
        'If cmbstate.Text = "M.P" Then
        '    sql = "select a.account_head_name,a.address,a.city,a.state, For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, party_code, item_code, item_name, rate, lst_rate, qty, unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno,  session, username, amt, party_amt, inwdate,  vathead, csthead, cst_code, cst_amt, porate, fr_head, cform, a.remark2 authr, po_date, form49No, form49issue, itemname, mkt_rate from " & GMod.ACC_HEAD & " a join Purchase_Data b"
        '    sql += " on(a.account_code=b.party_code and a.cmp_id=b.cmp_id) "
        '    sql += " where a.cmp_id='" & GMod.Cmpid & "' and b.for_where in ('GAURHA UNIT','LAB UNIT','PARIYAT UNIT','BROILER UNIT','LAYER UNIT','FEED UNIT')  and b.Bill_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and b.session ='" & GMod.Session & "' and a.state not in ('M.P','') and cst_amt >0 order by account_head_name"
        'Else
        '    sql = "select a.account_head_name,a.address,a.city,a.state, For_where, Bill_no, Bill_date, vou_type, vou_no, vou_date, party_code, item_code, item_name, rate, lst_rate, qty, unit, vatcst_code, varcst_amt, fr_code, fr_amt, pono, inwno,  session, username, amt, party_amt, inwdate,  vathead, csthead, cst_code, cst_amt, porate, fr_head, cform, a.remark2 authr, po_date, form49No, form49issue, itemname, mkt_rate from " & GMod.ACC_HEAD & " a join Purchase_Data b"
        '    sql += " on(a.account_code=b.party_code and a.cmp_id=b.cmp_id) "
        '    sql += " where a.cmp_id='" & GMod.Cmpid & "' and b.for_where in ('MANSAR UNIT','RAIPUR FEED UNIT','TILDA UNIT')  and b.Bill_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and b.session ='" & GMod.Session & "' and a.state not in ('C.G','') and cst_amt >0 order by account_head_name"
        'End If
        '   End If

        GMod.DataSetRet(sql, "cstrpt")

        Dim r As New CrCstRpt
        r.SetDataSource(GMod.ds.Tables("cstrpt"))
        r.SetParameterValue("frmdt", dtfrom.Value.ToShortDateString)
        r.SetParameterValue("todt", dtTo.Value.ToShortDateString)
        r.SetParameterValue("party", cmbacheadname.Text)
        CrystalReportViewer1.ReportSource = r
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dgdl.Visible = True
        sql = "select vou_type,vou_no,sum(cst_amt) cstamt from purchase_data where session ='" & GMod.Session & "' group by  vou_type,vou_no having count(item_name)>1 and sum(cst_amt)>0"
        GMod.DataSetRet(sql, "dglil")
        dgdl.DataSource = GMod.ds.Tables("dglil")
    End Sub
End Class