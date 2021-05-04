Public Class FrmGroupComp

    Private Sub FrmGroupComp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_CompaniesTableAdapter.Fill(Me.DSCompanies.tbl_Companies)
    End Sub

    Private Sub Tbl_CompaniesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_CompaniesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_CompaniesBindingSource.EndEdit()
            Me.Tbl_CompaniesTableAdapter.Update(Me.DSCompanies.tbl_Companies)
            MsgBox("Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_CompaniesDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_CompaniesDataGridView.DataError

    End Sub
End Class