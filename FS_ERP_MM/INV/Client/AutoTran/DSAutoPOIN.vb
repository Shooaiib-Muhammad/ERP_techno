Partial Class DSAutoPOIN
    Partial Class View_PO_DDataTable

        Private Sub View_PO_DDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.POIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
