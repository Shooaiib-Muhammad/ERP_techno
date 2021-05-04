Public Class Frm_Asserts_type
    Private Sub Tbl_Asserts_TypeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Frm_Asserts_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAsserts.tbl_Asserts_Type' table. You can move, or remove it, as needed.
        Me.Tbl_Asserts_TypeTableAdapter.Fill(Me.DSAsserts.tbl_Asserts_Type)

    End Sub

    Private Sub Tbl_Asserts_TypeBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Asserts_TypeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Asserts_TypeBindingSource.EndEdit()
            Me.Tbl_Asserts_TypeTableAdapter.Update(Me.DSAsserts.tbl_Asserts_Type)
            Me.Tbl_Asserts_TypeTableAdapter.Fill(Me.DSAsserts.tbl_Asserts_Type)
            MsgBox("Date Saved")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Asserts_TypeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Asserts_TypeDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Asserts_TypeDataGridView_DefaultCellStyleChanged(sender As Object, e As EventArgs) Handles Tbl_Asserts_TypeDataGridView.DefaultCellStyleChanged

    End Sub
End Class