Partial Class DSOut
    Partial Class tbl_Inv_LocalCustDataTable

        Private Sub tbl_Inv_LocalCustDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CustNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
