Partial Class PrintInv
    Partial Class PrintInvDataTable

        Private Sub PrintInvDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.cstateColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace PrintInvTableAdapters

    Partial Public Class PrintInvTableAdapter
    End Class
End Namespace
