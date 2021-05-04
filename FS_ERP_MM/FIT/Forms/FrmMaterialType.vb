Public Class FrmMaterialType
    Private Sub Tbl_Fit_Mat_TypeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Fit_Mat_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSFIT)

    End Sub

    Private Sub FrmMaterialType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Material' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_MaterialTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Material)
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Mat_Type' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_Mat_TypeTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Mat_Type)

    End Sub

    Private Sub Tbl_Fit_Mat_TypeBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Fit_Mat_TypeBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_Fit_Mat_TypeBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Fit_Mat_TypeBindingSource.EndEdit()
            Me.Tbl_Fit_Mat_TypeTableAdapter.Update(Me.DSFIT.Tbl_Fit_Mat_Type)
            Me.Tbl_Fit_Mat_TypeTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Mat_Type)
            Me.Tbl_Fit_Mat_TypeBindingSource.Position = j
            MessageBox.Show("Material Type Save", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.Tbl_Fit_MaterialBindingSource.EndEdit()
            Me.Tbl_Fit_MaterialTableAdapter.Update(Me.DSFIT.Tbl_Fit_Material)
            Me.Tbl_Fit_MaterialTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Material)
            MessageBox.Show("Material Save", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Fit_MaterialDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Fit_MaterialDataGridView.CellContentClick

    End Sub



    Private Sub Tbl_Fit_MaterialDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Fit_MaterialDataGridView.DataError

    End Sub
End Class