Public Class frmLocalCust

    Private Sub frmLocalCust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSLocalCust.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSLocalCust.tbl_Inv_LocalCust)
    End Sub

    Private Sub Tbl_Inv_LocalCustBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Inv_LocalCustBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Inv_LocalCustBindingSource.EndEdit()
            Me.Tbl_Inv_LocalCustTableAdapter.Update(Me.DSLocalCust.tbl_Inv_LocalCust)
            MsgBox("Customer Record Saved.")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Inv_LocalCustDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_LocalCustDataGridView.DataError
    End Sub
End Class