Public Class Frmtestcatalog
    Private Sub Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Fit_Test_CatalogsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSFIT)

    End Sub

    Private Sub Frmtestcatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Test_Catalogs' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_Test_CatalogsTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Test_Catalogs)

    End Sub

    Private Sub Tbl_Fit_Test_CatalogsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Fit_Test_CatalogsDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Fit_Test_CatalogsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Fit_Test_CatalogsDataGridView.DataError

    End Sub

    Private Sub Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_Fit_Test_CatalogsBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Fit_Test_CatalogsBindingSource.EndEdit()
            Me.Tbl_Fit_Test_CatalogsTableAdapter.Update(Me.DSFIT.Tbl_Fit_Test_Catalogs)
            Me.Tbl_Fit_Test_CatalogsTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Test_Catalogs)
            Me.Tbl_Fit_Test_CatalogsBindingSource.Position = j
            MessageBox.Show("Record Save", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub
End Class