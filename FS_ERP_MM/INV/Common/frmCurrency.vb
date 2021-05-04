Public Class frmCurrency

    Private Sub Tbl_MM_CurrancyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_MM_CurrancyBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_MM_CurrancyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsUOM)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub

    Private Sub frmCurrency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsUOM.tbl_MM_Currancy' table. You can move, or remove it, as needed.
        Me.Tbl_MM_CurrancyTableAdapter.Fill(Me.DsUOM.tbl_MM_Currancy)

    End Sub

    Private Sub Tbl_MM_CurrancyDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_MM_CurrancyDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_MM_CurrancyDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_MM_CurrancyDataGridView.DataError

    End Sub
End Class