Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmBooksData
    Dim sql As String
    Dim dsCust As New DataSet

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmBooksData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select * from VENTRY_PHHA_2324 where Group_name='CUSTOMER'"
        GMod.DataSetRet(sql, "customerdata")
        DataGridView1.DataSource = GMod.ds.Tables("customerdata")

        Dim dt As DataTable
        dt = GMod.ds.Tables("customerdata")

        Dim xlApp As New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlWorkBook = xlApp.Workbooks.Add()
        xlWorkSheet = xlWorkBook.Sheets(1)

        'Column Headers
        For i As Integer = 0 To dt.Columns.Count - 1
            xlWorkSheet.Cells(1, i + 1) = dt.Columns(i).ColumnName
        Next

        'Rows
        For i As Integer = 0 To dt.Rows.Count - 1
            For j As Integer = 0 To dt.Columns.Count - 1
                xlWorkSheet.Cells(i + 2, j + 1) = dt.Rows(i)(j).ToString()
            Next
        Next

        xlApp.Visible = True

      


    End Sub
End Class