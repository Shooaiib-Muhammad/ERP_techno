

Partial Public Class DSPOR
    Partial Class tbl_Pur_PO_DDataTable

        Private Sub tbl_Pur_PO_DDataTable_tbl_Pur_PO_DRowChanging(ByVal sender As System.Object, ByVal e As tbl_Pur_PO_DRowChangeEvent) Handles Me.tbl_Pur_PO_DRowChanging

        End Sub

    End Class

    Partial Class View_MM_PO_RECDataTable
    End Class
    Partial Class tbl_Inv_Tran_InDataTable

        Private Sub tbl_Inv_Tran_InDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DayNoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace DSPORTableAdapters
    
    Partial Public Class View_PO_DTableAdapter
    End Class
End Namespace
