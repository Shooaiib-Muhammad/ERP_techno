Public Class FrmSupplipers
    Private Sub Tbl_Inv_SupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrmSupplipers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSFIT.tbl_Inv_Supplier' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSFIT.tbl_Inv_Supplier)

    End Sub

    Private Sub Tbl_Inv_SupplierBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Inv_SupplierBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Inv_SupplierBindingSource.EndEdit()
            Me.Tbl_Inv_SupplierTableAdapter.Update(Me.DSFIT.tbl_Inv_Supplier)
            Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSFIT.tbl_Inv_Supplier)
            MessageBox.Show("Record Save", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try

    End Sub
End Class