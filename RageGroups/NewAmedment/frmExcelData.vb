Public Class frmExcelData
    Dim sql As String
    Private Sub frmExcelData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select * from " & GMod.VENTRY & " where Group_name not in ( Select [GroupNameConcealed]  from [GroupNameConcealed] )"
        GMod.DataSetRet(sql, "datatoexcel")
        DataGridView1.DataSource = GMod.ds.Tables("datatoexcel")
    End Sub
End Class