Public Class frmvoucherlist

    Private Sub frmvoucherlist_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GMod.ds.Tables.Clear()
    End Sub
    Dim sql As String
    Dim i As Integer
    Private Sub frmvoucherlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' order by seqorder", "vtylist")

        'sql = "select distinct vou_type from " & GMod.VENTRY & " where vou_type not like '%SALE%' and  vou_type not like '%PUR%'  and  vou_type not like '%CASH%' and vou_type not like '%CR%' and vou_type not like '%BANK%'" ' and vou_no_seq='" & GMod.Dept & "'"

        ' If GMod.staff1 = 1 Then
        sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and session ='" & GMod.Session & "'"
        'Else
        ' sql = "select vtype from Vtype where cmp_id='" & GMod.Cmpid & "' and (vprefix like '%J%'  or vprefix like '%bt%'  or vprefix like '%F%' or vprefix like '%P%') and Vtype not in ('BANK','CR VOUCHER','CR VOUCHER-TR','CASH','OPEN') and VTYPE NOT LIKE '%OTHER SALE%' and VTYPE NOT LIKE '%CHICKS%' and vou_no_seq='" & GMod.Dept & "'"
        ' sql = "select distinct vou_type from " & GMod.VENTRY & " where vou_type not like '%SALE%' and  vou_type not like 'PUR%'  and  vou_type not like '%CASH%' and vou_type not like '%CR%' and vou_type not like '%BANK%'" and vou_no_seq='" & GMod.Dept & "'"
        'End If

        GMod.DataSetRet(sql, "vtylist")
        For i = 0 To GMod.ds.Tables("vtylist").Rows.Count - 1
            Me.cmbvtype.Items.Add(GMod.ds.Tables("vtylist").Rows(i)(0))
        Next
        Me.cmbvtype.Items.Add("SALE JOURNAL")
        Me.cmbvtype.Items.Add("SALE JOURNAL(GST)")
        Me.cmbvtype.Items.Add("BANK JOURNAL")
        Me.cmbvtype.Items.Add("BANK TRANS")
        Me.cmbvtype.Items.Add("BANK")
        Me.cmbvtype.Items.Add("BANK TRANS(GST)")
        Me.cmbvtype.Items.Add("FARM BANK")
        Me.cmbvtype.Items.Add("FJOURNAL")
        'Me.cmbvtype.DataSource = GMod.ds.Tables("vtylist")
        'Me.cmbvtype.DisplayMember = "vou_type"
        Me.cmbvtype.Text = lblvtype.Text

    End Sub

    Private Sub cmbvtype_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvtype.Leave
        If cmbvtype.FindStringExact(cmbvtype.Text) = -1 Then
            MsgBox("Incorrect voucher type", MsgBoxStyle.Critical)
            cmbvtype.Focus()
        End If
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Close()
    End Sub

    Private Sub txtvouno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Close()
        End If
    End Sub
    Private Sub dtvdate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.Leave
        Try
            GMod.DataSetRet("select distinct vou_no from " & GMod.VENTRY & " where vou_type='" & cmbvtype.Text & "' and vou_date = '" & dtvdate.Value.ToShortDateString & "' and pay_mode='-'", "vn")
            txtvouno.DataSource = GMod.ds.Tables("vn")
            txtvouno.DisplayMember = "vou_no"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbvtype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvtype.KeyDown
        If e.KeyCode = Keys.Enter Then dtvdate.Focus()
    End Sub

    Private Sub dtvdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtvdate.KeyDown
        If e.KeyCode = Keys.Enter Then txtvouno.Focus()

    End Sub

    Private Sub txtvouno_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvouno.KeyDown
        If e.KeyCode = Keys.Enter Then btnsave.Focus()

    End Sub

    Private Sub dtvdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtvdate.ValueChanged

    End Sub

    Private Sub cmbvtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvtype.SelectedIndexChanged

    End Sub
End Class