Public Class FrmVendors


    Private Sub FrmVendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSIT.tbl_Vendors' table. You can move, or remove it, as needed.
        Me.Tbl_VendorsTableAdapter.Fill(Me.DSIT.tbl_Vendors)

    End Sub

    Private Sub Tbl_VendorsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_VendorsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_VendorsBindingSource.EndEdit()
            Me.Tbl_VendorsTableAdapter.Update(Me.DSIT.tbl_Vendors)
            Me.Tbl_VendorsTableAdapter.Fill(Me.DSIT.tbl_Vendors)
            MsgBox("Data Saved")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_VendorsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_VendorsDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_VendorsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_VendorsDataGridView.DataError

    End Sub
End Class