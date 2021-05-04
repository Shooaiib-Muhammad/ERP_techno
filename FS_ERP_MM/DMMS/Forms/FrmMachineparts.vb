Public Class FrmMachineparts
    Private Sub Tbl_DMMS_Parts1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_DMMS_Parts1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DMMS)

    End Sub

    Private Sub FrmMachineparts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMMS.tbl_DMMS_Parts1' table. You can move, or remove it, as needed.
        Me.Tbl_DMMS_Parts1TableAdapter.Fill(Me.DMMS.tbl_DMMS_Parts1)

    End Sub

    Private Sub Tbl_DMMS_Parts1BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_DMMS_Parts1BindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_DMMS_Parts1BindingSource.EndEdit()
            Me.Tbl_DMMS_Parts1TableAdapter.Update(Me.DMMS.tbl_DMMS_Parts1)
            Me.Tbl_DMMS_Parts1TableAdapter.Fill(Me.DMMS.tbl_DMMS_Parts1)
            MsgBox("Data Saved")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_DMMS_Parts1DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_DMMS_Parts1DataGridView.CellContentClick

    End Sub

    Private Sub Tbl_DMMS_Parts1DataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_DMMS_Parts1DataGridView.DataError

    End Sub
End Class