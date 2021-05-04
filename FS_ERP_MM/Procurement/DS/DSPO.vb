

Partial Public Class DSPO
    Partial Public Class tbl_Pur_DemandDataTable
        Private Sub tbl_Pur_DemandDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.InProcessStatusColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class View_Rpt_Pur_SupplierItemDataTable

        Private Sub View_Rpt_Pur_SupplierItemDataTable_View_Rpt_Pur_SupplierItemRowChanging(ByVal sender As System.Object, ByVal e As View_Rpt_Pur_SupplierItemRowChangeEvent) Handles Me.View_Rpt_Pur_SupplierItemRowChanging

        End Sub

    End Class

End Class

Namespace DSPOTableAdapters
    
    Partial Public Class tbl_Pur_DemandTableAdapter
    End Class
End Namespace
