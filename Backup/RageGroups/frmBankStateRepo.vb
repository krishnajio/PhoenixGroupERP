Public Class frmBankStateRepo

    Private Sub frmBankStateRepo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "    " & "[" & GMod.Cmpname & "]"
        fillArea()
        cmbAreaCode.Text = "JB"
        'cmbgrpname.SelectedIndex = 0
        CrViewerBankrec.Height = Me.Height - 200
        Try
            Dim sql As String
            sql = "select account_code,account_head_name,group_name,sub_group_name from " & GMod.ACC_HEAD & " where cmp_id='" & GMod.Cmpid & "'" _
                   & " and group_name in ('BANK') order by account_head_name"
            GMod.DataSetRet(sql, "bank")
            cmbacheadcode.DataSource = GMod.ds.Tables("bank")
            cmbacheadcode.DisplayMember = "account_code"
            cmbacheadname.DataSource = GMod.ds.Tables("bank")
            cmbacheadname.DisplayMember = "account_head_name"


            cmbgrpname.DataSource = GMod.ds.Tables("bank")
            cmbgrpname.DisplayMember = "group_name"

            cmbsubgrpname.DataSource = GMod.ds.Tables("bank")
            cmbsubgrpname.DisplayMember = "sub_group_name"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim opening, opnbakstate, opndiff As Double
    Public Sub fillArea()
        Dim sqlarea As String
        sqlarea = "select * from Area"
        GMod.DataSetRet(sqlarea, "Area")

        cmbAreaCode.DataSource = GMod.ds.Tables("Area")
        cmbAreaCode.DisplayMember = "prefix"

        cmbAreaName.DataSource = GMod.ds.Tables("Area")
        cmbAreaName.DisplayMember = "Areaname"
    End Sub
    Public Sub OpeningBankStatement(ByVal dt As DateTime)
        Try
            Dim sqlopenbankstate As String

            Dim sqlopeningbanstate As String = " select isnull(dramt,0) - isnull(cramt,0)  from " _
                                          & GMod.BANK_STATE_OPEN & " where bank_acc_code= '" & cmbacheadcode.Text & "'"
            GMod.DataSetRet(sqlopeningbanstate, "opeingbal")

            opnbakstate = CDbl(GMod.ds.Tables("opeingbal").Rows(0)(0).ToString)

            'MsgBox(opnbakstate.ToString)

            sqlopenbankstate = "select isnull(sum(dramt),0) - isnull(sum(cramt),0)  from " _
                                & " " & GMod.BANK_STATE & " where bank_acc_code='" & cmbacheadcode.Text & "' and  bankedate<'" & dt.ToShortDateString & "' and  detail<>'BANKREC'"

            MsgBox(sqlopenbankstate)
            GMod.ds.Tables("opeingbal").Clear()
            GMod.DataSetRet(sqlopenbankstate, "opeingbal")

            'MsgBox(GMod.ds.Tables("opeingbal").Rows(0)(0).ToString)
            opnbakstate = opnbakstate + CDbl(GMod.ds.Tables("opeingbal").Rows(0)(0).ToString)
            'MsgBox(opndiff.ToString)

        Catch ex As Exception
            If ex.Message.Contains("0") Then
                MsgBox("Please enter Bank opening", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message)
            End If

        End Try
        'MsgBox(opening.ToString)
    End Sub
    Dim sql As String
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        GMod.SqlExecuteNonQuery("delete from repBankState")
        OpeningBankStatement(dtfrom.Value)
        Dim cr, dr As Double
        If opnbakstate > 0 Then
            dr = opnbakstate
            cr = 0
        Else
            cr = opnbakstate
            dr = 0
        End If
        sql = "insert into repBankState (Cmp_id,bank_acc_code, detail, chddno, dramt, cramt, uname) values ("
        sql &= "'" & GMod.Cmpid & "',"
        sql &= "'" & cmbacheadcode.Text & "',"
        sql &= "'Balance as per Bank Statement',"
        sql &= "'-',"
        sql &= "" & Math.Abs(dr) & ","
        sql &= "" & Math.Abs(cr) & ","
        sql &= "'" & GMod.username & "')"
        GMod.SqlExecuteNonQuery(sql)

        sql = "insert into  repBankState (Cmp_id, Entryid, bank_acc_code, bankedate, paytype, detail, chddno, dramt, cramt, uname) " _
        & " select Cmp_id, Entryid, bank_acc_code, bankedate, paytype, detail, chddno, dramt, cramt, '" & GMod.username & "' from " & GMod.BANK_STATE _
        & " where bank_acc_code='" & cmbacheadcode.Text & "' and Cmp_id='" & GMod.Cmpid & "' and bankedate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and detail <> 'BANKREC'"
        GMod.SqlExecuteNonQuery(sql)

        GMod.DataSetRet("select * from repBankState", "BankState")
        Try
            Dim r As New CrBankState
            r.SetDataSource(GMod.ds.Tables("BankState"))
            r.SetParameterValue("cname", GMod.Cmpname)
            r.SetParameterValue("bname", "Account Holder : " & cmbacheadcode.Text & "-" & cmbacheadname.Text)
            r.SetParameterValue("subhead", "Bank Statement from :" & dtfrom.Text & " to " & dtTo.Text)
            CrViewerBankrec.ReportSource = r
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbAreaCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaCode.KeyDown
        If e.KeyCode = Keys.Enter Then cmbAreaName.Focus()
    End Sub

    Private Sub cmbAreaName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAreaName.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacheadname.Focus()
    End Sub

    Private Sub cmbacheadcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadcode.KeyDown
        If e.KeyCode = Keys.Enter Then dtTo.Focus()
    End Sub

    Private Sub cmbacheadname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbacheadname.KeyDown
        If e.KeyCode = Keys.Enter Then cmbacheadcode.Focus()
    End Sub

    Private Sub dtfrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtfrom.KeyDown
        If e.KeyCode = Keys.Enter Then dtTo.Focus()
    End Sub

    Private Sub dtTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtTo.KeyDown
        If e.KeyCode = Keys.Enter Then btnshow.Focus()
    End Sub
End Class