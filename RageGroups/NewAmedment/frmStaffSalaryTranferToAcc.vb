Imports System.Data.SqlClient

Public Class frmStaffSalaryTranferToAcc

    Private Sub frmStaffSalaryTranferToAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select getdate()", "serverdate")

        'dtvdate.MinDate = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString).AddDays(-2)
        'dtVoucherDate.Value = CDate(GMod.ds.Tables("serverdate").Rows(0)(0).ToString)


        'dgvoucher.Rows.Add()
        If cmbvtype.Enabled = False Then
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype in ('SALARY JOURNAL','SALARY EXPS') order by seqorder", "vty")
        Else
            ' GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype NOT in ('PAYMENT','OPEN') order by seqorder", "vty")
            GMod.DataSetRet("select * from vtype where cmp_id='" & GMod.Cmpid & "' and vtype in ('SALARY JOURNAL','SALARY EXPS')  order by seqorder", "vty")

        End If
        cmbvtype.DataSource = GMod.ds.Tables("vty")
        cmbvtype.DisplayMember = "vtype"

        'SESSION CHECK FOR ENTRY 
        'MsgBox(GMod.Getsession(dtvdate.Value))
        If GMod.Getsession(dtVoucherDate.Value) = GMod.Session Then
        Else
            ' Me.Close()
        End If
        ' Dim ConStrSal As String = "Data Source=192.168.0.150;Initial Catalog=PHXSAL;User ID=sa;Password=@hplgsamsung#"
        Dim da1 As New SqlDataAdapter("select distinct orgid from  ORGANIZATIONMASTER", ConStrSal)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        cmborgid.DataSource = ds1.Tables(0)
        cmborgid.DisplayMember = "orgid"
        If GMod.Getsession(dtVoucherDate.Value) = GMod.Session Then
        Else
            'Me.Close()
        End If
    End Sub
    Dim Sql As String
    Dim ConStrSal As String = "Data Source=192.168.0.150;Initial Catalog=PHXSAL;User ID=sa;Password=Ph@hoenix#g"
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Sql = "exec TrafertoAcc '" & cmborgid.Text & "','" & dtSalaryDate.Value.ToShortDateString & "','" & MonthName(dtSalaryDate.Value.Month).ToUpper & "-" & dtSalaryDate.Value.Year & "'"
        Dim da1 As New SqlDataAdapter(Sql, ConStrSal)
        Dim ds2 As New DataSet
        da1.Fill(ds2)

        Sql = "select * from TRNASTOACC order by entry_id"
        Dim da2 As New SqlDataAdapter(Sql, ConStrSal)
        Dim ds3 As New DataSet
        da2.Fill(ds3, "saltrftoacc")
        dgStaffsaalry.DataSource = ds3.Tables("saltrftoacc")
    End Sub
End Class