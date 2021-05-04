Public Class frmExtCust

    Private Sub frmExtCust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_ExternalCustTableAdapter.Fill(Me.DSExtCust.tbl_Inv_ExternalCust)
    End Sub
    Private Sub Tbl_Inv_ExternalCustBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Inv_ExternalCustBindingNavigatorSaveItem.Click
        
        Try
            Me.Validate()
            Me.Tbl_Inv_ExternalCustBindingSource.EndEdit()
            Me.Tbl_Inv_ExternalCustTableAdapter.Update(Me.DSExtCust.tbl_Inv_ExternalCust)
            MsgBox("Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Inv_ExternalCustDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_ExternalCustDataGridView.DataError

    End Sub
End Class