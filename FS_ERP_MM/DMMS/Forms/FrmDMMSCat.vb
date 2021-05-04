Public Class FrmDMMSCat


    Private Sub FrmDMMSCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMMS.tbl_DMMS_Catagory' table. You can move, or remove it, as needed.
        Me.Tbl_DMMS_CatagoryTableAdapter.Fill(Me.DMMS.tbl_DMMS_Catagory)

    End Sub

    Private Sub Tbl_DMMS_CatagoryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_DMMS_CatagoryBindingNavigatorSaveItem.Click
        Dim postion As Integer = Tbl_DMMS_CatagoryBindingSource.Position
        Try

            Me.ValidateChildren()
            Me.Tbl_DMMS_CatagoryBindingSource.EndEdit()
            Me.Tbl_DMMS_CatagoryTableAdapter.Update(Me.DMMS.tbl_DMMS_Catagory)
            Me.Tbl_DMMS_CatagoryTableAdapter.Fill(Me.DMMS.tbl_DMMS_Catagory)
            Tbl_DMMS_CatagoryBindingSource.Position = postion
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub
End Class