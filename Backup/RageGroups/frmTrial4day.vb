Public Class frmTrial4day

    Private Sub frmTrial4day_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    [" & GMod.Cmpname & "]"
        fillArea()
        GMod.DataSetRet("select * from groups where cmp_id='" & GMod.Cmpid & "' order by group_name", "grp")
        cmbgrpname.DataSource = GMod.ds.Tables("grp")
        cmbgrpname.DisplayMember = "group_name"

        CrViewerGenralLedger.Height = Me.Height - 100

    End Sub
    Dim sql As String
    Sub fillArea()
        sql = "select * from  Area"
        GMod.DataSetRet(sql, "Area")
        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "AreaName"

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "Prefix"

    End Sub
    Dim k As Integer
    Dim up As String

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        GMod.SqlExecuteNonQuery("delete from tmpTrial4date where Uname='" & GMod.username & "'")
        If rdwithopening.Checked = True Then
            'Putting opeing values 
            sql = "insert into dbo.tmpTrial4date(account_code,account_head_name,odr,ocr,Uname) select account_code,account_head_name,opening_dr,opening_cr,'" & GMod.username & "' from " & GMod.ACC_HEAD & " where group_name='" & cmbgrpname.Text & "' and left(account_code,2) = '" & cmbAreaCode.Text & "'"
            MsgBox(GMod.SqlExecuteNonQuery(sql))

            sql = "select p.account_code,p.account_head_name," _
    & "ClosingDr= case  when (p.opening_dr + q.vdr)-(opening_cr + q.vcr) > 0 then  (p.opening_dr + q.vdr)-(opening_cr + q.vcr) else 0 end, " _
    & "ClosingCr= case  when (p.opening_dr + q.vdr)-(opening_cr + q.vcr) < 0 then  (p.opening_dr + q.vdr)-(opening_cr + q.vcr) else 0 end " _
    & "from (" _
    & " select account_code,account_head_name,opening_dr,opening_cr" _
    & " from " & GMod.ACC_HEAD & " where group_name='" & cmbgrpname.Text & "') p " _
    & " inner Join " _
    & "( select Acc_head_code, sum(dramt) vdr ,sum(cramt) vcr from " & GMod.VENTRY _
    & " where group_name='" & cmbgrpname.Text & "'  and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' and  vou_date<='" & d1.Value.ToShortDateString & "' group by Acc_head_code) q " _
    & "on p.account_code=q.Acc_head_code "
            GMod.DataSetRet(sql, "d1")
            For k = 0 To GMod.ds.Tables("d1").Rows.Count - 1
                'MsgBox(GMod.ds.Tables("d1").Rows.Count & GMod.ds.Tables("d1").Rows(k)("account_code"))

                up = "update tmpTrial4date set [1dr]=" & Val(GMod.ds.Tables("d1").Rows(k)("ClosingDr")) & ", [1cr]=" & Val(GMod.ds.Tables("d1").Rows(k)("ClosingCr")) & " where account_code = '" & GMod.ds.Tables("d1").Rows(k)("account_code") & "'"
                GMod.SqlExecuteNonQuery(up)
            Next

            sql = "select p.account_code,p.account_head_name," _
  & "ClosingDr= case  when (p.opening_dr + q.vdr)-(opening_cr + q.vcr) > 0 then  (p.opening_dr + q.vdr)-(opening_cr + q.vcr) else 0 end, " _
  & "ClosingCr= case  when (p.opening_dr + q.vdr)-(opening_cr + q.vcr) < 0 then  (p.opening_dr + q.vdr)-(opening_cr + q.vcr) else 0 end " _
  & "from (" _
  & " select account_code,account_head_name,opening_dr,opening_cr" _
  & " from " & GMod.ACC_HEAD & " where group_name='" & cmbgrpname.Text & "') p " _
  & " inner Join " _
  & "( select Acc_head_code, sum(dramt) vdr ,sum(cramt) vcr from " & GMod.VENTRY _
  & " where group_name='" & cmbgrpname.Text & "'  and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' and  vou_date<='" & d2.Value.ToShortDateString & "' group by Acc_head_code) q " _
  & "on p.account_code=q.Acc_head_code "
            GMod.DataSetRet(sql, "d2")
            For k = 0 To GMod.ds.Tables("d2").Rows.Count - 1
                up = "update tmpTrial4date set [2dr]=" & Val(GMod.ds.Tables("d2").Rows(k)("ClosingDr")) & ", [2cr]=" & Val(GMod.ds.Tables("d2").Rows(k)("ClosingCr")) & " where account_code = '" & GMod.ds.Tables("d2").Rows(k)("account_code") & "'"
                GMod.SqlExecuteNonQuery(up)
            Next


            sql = "select p.account_code,p.account_head_name," _
& "ClosingDr= case  when (p.opening_dr + q.vdr)-(opening_cr + q.vcr) > 0 then  (p.opening_dr + q.vdr)-(opening_cr + q.vcr) else 0 end, " _
& "ClosingCr= case  when (p.opening_dr + q.vdr)-(opening_cr + q.vcr) < 0 then  (p.opening_dr + q.vdr)-(opening_cr + q.vcr) else 0 end " _
& "from (" _
& " select account_code,account_head_name,opening_dr,opening_cr" _
& " from " & GMod.ACC_HEAD & " where group_name='" & cmbgrpname.Text & "') p " _
& " inner Join " _
& "( select Acc_head_code, sum(dramt) vdr ,sum(cramt) vcr from " & GMod.VENTRY _
& " where group_name='" & cmbgrpname.Text & "'  and left(Acc_head_code,2)='" & cmbAreaCode.Text & "' and  vou_date<='" & d3.Value.ToShortDateString & "' group by Acc_head_code) q " _
& "on p.account_code=q.Acc_head_code "
            GMod.DataSetRet(sql, "d3")
            For k = 0 To GMod.ds.Tables("d3").Rows.Count - 1
                up = "update tmpTrial4date set [3dr]=" & Val(GMod.ds.Tables("d3").Rows(k)("ClosingDr")) & ", [3cr]=" & Val(GMod.ds.Tables("d3").Rows(k)("ClosingCr")) & " where account_code = '" & GMod.ds.Tables("d3").Rows(k)("account_code") & "'"
                GMod.SqlExecuteNonQuery(up)
            Next
        End If

        'Running crystal report
        Dim r As New CrTrial4day
        sql = "select * from  tmpTrial4date where Uname='" & GMod.username & "'  order by account_head_name"

        GMod.DataSetRet(sql, "trial")
        r.SetDataSource(GMod.ds.Tables("trial"))

        r.SetParameterValue("a", d1.Text)
        r.SetParameterValue("b", d2.Text)
        r.SetParameterValue("c", d3.Text)
        r.SetParameterValue("cmp", GMod.Cmpname)
        r.SetParameterValue("grp", cmbgrpname.Text & "[" & cmbAreaName.Text & "]")
        CrViewerGenralLedger.ReportSource = r

    End Sub
End Class