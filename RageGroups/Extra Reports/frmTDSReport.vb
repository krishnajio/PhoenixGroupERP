Public Class frmTDSReport

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'Cmp_id, account_code, account_head_name, group_name, sub_group_name,
        'credit_days, credit_limit, opening_dr, opening_cr, account_type, 
        'address, city, state, phone, pan_no, rate_of_interest, 
        'interest_rule_id, Area_code, remark1, remark2, remark3
        GMod.SqlExecuteNonQuery("delete from tmpTds")
        Dim sql As String
        Dim i As Integer
        sql = "select * from TdsEntry  where tdstype='" & cmbtdsType.Text & "' and vou_date between '" & dt1.Value.ToShortDateString & "' and '" & dt2.Value.ToShortDateString & "' and session ='" & GMod.Session & "' AND CMP_ID ='" & GMod.Cmpid & "' and Authr<>'-'  order by vou_date,cast(vou_no as bigint)"
        GMod.DataSetRet(sql, "tdse")
        Try

            For i = 0 To GMod.ds.Tables("tdse").Rows.Count - 1
                sql = "select * from " & GMod.ACC_HEAD & " where account_code ='" & GMod.ds.Tables("tdse").Rows(i)("dcode") & "'"
                GMod.DataSetRet(sql, "ddata")

                sql = "insert into tmpTds(dcode, dpan, dname, address, city," _
                & " state, pin, payamt, ddate, seccode, per, amt,vou_type,vou_no,vou_date,uname,prop) values("
                sql &= "'" & GMod.ds.Tables("ddata").Rows(0)("account_code") & "',"
                sql &= "'" & GMod.ds.Tables("ddata").Rows(0)("pan_no") & "',"
                sql &= "'" & GMod.ds.Tables("ddata").Rows(0)("account_head_name") & "',"
                sql &= "'" & GMod.ds.Tables("ddata").Rows(0)("address") & "',"
                sql &= "'" & GMod.ds.Tables("ddata").Rows(0)("city") & "',"
                sql &= "'" & GMod.ds.Tables("ddata").Rows(0)("state") & "',"
                sql &= "'" & GMod.ds.Tables("ddata").Rows(0)("rate_of_interest") & "',"
                sql &= "'" & GMod.ds.Tables("tdse").Rows(i)("Paidamt") & "',"
                sql &= "'" & GMod.ds.Tables("tdse").Rows(i)("vou_date") & "',"
                sql &= "'" & GMod.ds.Tables("ddata").Rows(0)("credit_limit") & "',"
                sql &= "'" & GMod.ds.Tables("tdse").Rows(i)("Per") & "',"
                sql &= "'" & GMod.ds.Tables("tdse").Rows(i)("TdsAmt") & "',"
                sql &= "'" & GMod.ds.Tables("tdse").Rows(i)("vou_type") & "',"
                sql &= "'" & GMod.ds.Tables("tdse").Rows(i)("vou_no") & "',"
                sql &= "'" & CDate(GMod.ds.Tables("tdse").Rows(i)("vou_date")) & "',"
                sql &= "'" & GMod.username & "',"
                sql &= "'" & GMod.ds.Tables("ddata").Rows(0)("credit_days").ToString & "')"
                GMod.SqlExecuteNonQuery(sql)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & sql & GMod.ds.Tables("tdse").Rows(i)("vou_no"))
        End Try

        sql = "select * from TdsEntry  where tdstype='" & cmbtdsType.Text & "' and vou_date between '" & dt1.Value.ToShortDateString & "' and '" & dt2.Value.ToShortDateString & "' and session ='" & GMod.Session & "' AND CMP_ID ='" & GMod.Cmpid & "' and Authr<>'-'  order by vou_date,cast(vou_no as bigint)"
        GMod.DataSetRet(sql, "tdse")
        Try
            For i = 0 To GMod.ds.Tables("tdse").Rows.Count - 1

                sql = "select * from " & GMod.VENTRY & " where vou_type ='" & GMod.ds.Tables("tdse").Rows(i)("vou_type") & "' and vou_no='" & GMod.ds.Tables("tdse").Rows(i)("vou_no") & "' and dramt >0 "
                GMod.DataSetRet(sql, "ddata")

                sql = "update tmpTds set  pin = '" & GMod.ds.Tables("ddata").Rows(0)("acc_head") & "'  where vou_type ='" & GMod.ds.Tables("tdse").Rows(i)("vou_type") & "' and vou_no='" & GMod.ds.Tables("tdse").Rows(i)("vou_no") & "'"
                GMod.SqlExecuteNonQuery(sql)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim party As String
        If ChkAllParty.Checked = True Then

            sql = "select * from tmpTDS where uname ='" & GMod.username & "' order by vou_date,cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "tddsrep")
            party = "ALL"
        Else
            sql = "select * from tmpTDS where uname ='" & GMod.username & "' and dcode = '" & cmbPartCode.Text & "' order by vou_date,cast(vou_no as bigint)"
            GMod.DataSetRet(sql, "tddsrep")
            party = cmbPartyHead.Text
        End If

        Dim crTds As New CrTDSRep
        crTds.SetDataSource(GMod.ds.Tables("tddsrep"))
        crTds.SetParameterValue("p1", "Date From:" & dt1.Text & " To :" & dt2.Text)
        crTds.SetParameterValue("p2", "TDS Type:" & cmbtdsType.Text & "---- TDS Per:" & cmbTdsper.Text)
        crTds.SetParameterValue("p3", "Deductee Name:" & party)

        CrystalReportViewer1.ReportSource = crTds

    End Sub
    Dim sql As String
    Private Sub frmTDSReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt1.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dt2.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString

        dt1.MaxDate = CDate("3/31/" & Mid(GMod.Session, 3, 4))
        dt2.MinDate = CDate("4/1/" & Mid(GMod.Session, 1, 2)).ToShortDateString


        sql = " select * from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" 'and left(account_code,2) in ('**','" & cmbAreaCode.Text & "')"
        GMod.DataSetRet(sql, "aclist20")
        cmbPartCode.DataSource = GMod.ds.Tables("aclist20")
        cmbPartCode.DisplayMember = "account_code"
        cmbPartyHead.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyHead.DisplayMember = "account_head_name"
        cmbPartyGroup.DataSource = GMod.ds.Tables("aclist20")
        cmbPartyGroup.DisplayMember = "group_name"

        sql = "select * from TdsMater where cmp_id='" & GMod.Cmpid & "'"
        GMod.DataSetRet(Sql, "tdm")

        cmbtdsType.DataSource = GMod.ds.Tables("tdm")
        cmbtdsType.DisplayMember = "TdsType"


        cmbTdsper.DataSource = GMod.ds.Tables("tdm")
        cmbTdsper.DisplayMember = "Per"

    End Sub
End Class