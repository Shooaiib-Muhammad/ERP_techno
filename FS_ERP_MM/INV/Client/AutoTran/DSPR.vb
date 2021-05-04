

Partial Public Class DSPR
    Partial Class View_PO_PandingDataTable

        Private Sub View_PO_PandingDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CodeColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace DSPRTableAdapters
    
    Partial Public Class View_PO_DTableAdapter
    End Class
End Namespace
