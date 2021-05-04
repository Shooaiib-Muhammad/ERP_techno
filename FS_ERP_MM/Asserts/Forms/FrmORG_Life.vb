Public Class FrmORG_Life
    Private Sub Tbl_Assert_OR_LifeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrmORG_Life_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAsserts.tbl_Assert_OR_Life' table. You can move, or remove it, as needed.
        Me.Tbl_Assert_OR_LifeTableAdapter.Fill(Me.DSAsserts.tbl_Assert_OR_Life)

    End Sub

    Private Sub Tbl_Assert_OR_LifeBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Assert_OR_LifeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Assert_OR_LifeBindingSource.EndEdit()
            Me.Tbl_Assert_OR_LifeTableAdapter.Update(Me.DSAsserts.tbl_Assert_OR_Life)
            Me.Tbl_Assert_OR_LifeTableAdapter.Fill(Me.DSAsserts.tbl_Assert_OR_Life)
            MsgBox("Data Saved")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Assert_OR_LifeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Assert_OR_LifeDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Assert_OR_LifeDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Assert_OR_LifeDataGridView.DataError

    End Sub
End Class