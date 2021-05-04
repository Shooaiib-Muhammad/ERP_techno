Public Class frmWindedExect

    Private Sub Tbl_Winded_ExectNameBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Winded_ExectNameBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Winded_ExectNameBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSWindedBladderIssuance)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmWindedExect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Winded_ExectNameTableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Winded_ExectName)
    End Sub

    Private Sub Tbl_Winded_ExectNameDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Winded_ExectNameDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Winded_ExectNameDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Winded_ExectNameDataGridView.DataError

    End Sub
End Class