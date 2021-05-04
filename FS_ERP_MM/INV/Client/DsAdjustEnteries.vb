Partial Class DsAdjustEnteries
    Partial Class tbl_Inv_Tran_OutDataTable

        Private Sub tbl_Inv_Tran_OutDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TranDocNoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
