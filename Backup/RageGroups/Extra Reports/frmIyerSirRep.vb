Imports System.Data
Imports System.Data.OleDb
Public Class frmIyerSirRep

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim n As Integer, i As Integer
        Dim sql As String
        n = DateDiff(DateInterval.Day, d1.Value, d2.Value)
        'MsgBox(n)
        GMod.SqlExecuteNonQuery("delete from tmpIyerSir")
        For i = 0 To n
            sql = " insert into tmpIyerSir(hatchdate, code, accname, qty, rate, amt) " _
          & " select hatchdate,AccCode,AccName,Qty,Rate,Amount from printdata where session='" & GMod.Session & "'  " _
          & " and cmp_id='phha' and left(acccode,2)='" & cmbareacode.Text & "' " _
          & " and productname not in ('N.E.E.C AMOUNT','DISCOUNT AMOUNT') " _
          & " and hatchdate = '" & d1.Value.AddDays(i).ToShortDateString & "' "
            GMod.SqlExecuteNonQuery(sql)
        Next

        sql = "select distinct code  from tmpIyerSir"
        GMod.DataSetRet(sql, "xx")
        For i = 0 To GMod.ds.Tables("xx").Rows.Count - 1
            sql = "insert into tmpIyerSir(hatchdate, code, accname,cramt) select vou_date,acc_head_code,'CR NO-' + Vou_no + ' '+narration ,cramt from " & GMod.VENTRY & " where Acc_head_code='" & GMod.ds.Tables("xx").Rows(i)("code") & "' and vou_type='CR VOUCHER' and vou_date between '" & d1.Value.ToShortDateString & "' and  '" & d2.Value.ToShortDateString & "'"
            GMod.SqlExecuteNonQuery(sql)
        Next


        Dim cr As New CrIyerSir
        GMod.DataSetRet("select * from tmpIyerSir", "zz")
        cr.SetDataSource(GMod.ds.Tables("zz"))
        cr.SetParameterValue("0", "Hatch Vs CR Report")
        cr.SetParameterValue("1", "Area-" & cmbAreaName.Text)
        cr.SetParameterValue("2", "Hatch Date/Cr Date" & d1.Text & " To " & d2.Text)


        CrystalReportViewer1.ReportSource = cr


    End Sub

    Private Sub frmIyerSirRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from area", "area")
        cmbAreaName.DataSource = GMod.ds.Tables("area")
        cmbAreaName.DisplayMember = "Areaname"

        cmbareacode.DataSource = GMod.ds.Tables("area")
        cmbareacode.DisplayMember = "prefix"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim bill() As String
        Dim i As Integer
        sql = "select Acc_head_code,Acc_head,narration from " & GMod.VENTRY & " where group_name='PARTY' and vou_type='PURCHASE' order by cast(vou_no as bigint) "
        GMod.DataSetRet(sql, "billdet")
        For i = 0 To GMod.ds.Tables("billdet").Rows.Count - 1
            bill = GMod.ds.Tables("billdet").Rows(i)("narration").ToString.Split(" ")
            sql = "insert into tmpaduit values("
            sql &= "'" & GMod.ds.Tables("billdet").Rows(i)("Acc_head_code").ToString.Trim & "',"
            sql &= "'" & GMod.ds.Tables("billdet").Rows(i)("Acc_head").ToString.Trim & "',"
            sql &= "'" & bill(2) & "')"
            GMod.SqlExecuteNonQuery(sql)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Dim conn As New OleDbConnection("Provider=Microsoft.Jet.oledb.4.0; Data Source=c:\db2.mdb")
            Dim sql As String
            Dim dsol As New DataSet

            sql = "select * from INWARD"
            Dim dao As New OleDbDataAdapter(sql, "Provider=Microsoft.Jet.oledb.4.0; Data Source=c:\db2.mdb")
            dao.Fill(dsol, "inward")
            Dim i As Integer
            For i = 0 To dsol.Tables("inward").Rows.Count - 1
                sql = "insert into tmpinw values("
                sql &= "'" & dsol.Tables("inward").Rows(i)(0).ToString.Trim & "',"
                sql &= "'" & dsol.Tables("inward").Rows(i)(1).ToString.Trim & "',"
                sql &= "'" & dsol.Tables("inward").Rows(i)(2).ToString.Trim & "',"
                sql &= "'" & dsol.Tables("inward").Rows(i)(3).ToString.Trim & "')"
                GMod.SqlExecuteNonQuery(sql)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class