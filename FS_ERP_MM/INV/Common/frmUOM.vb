Public Class frmUOM
    Private Sub frmUOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DsUOM.tbl_Pur_UnitOfMeasurement)

    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub Tbl_Pur_UnitOfMeasurementDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_UnitOfMeasurementDataGridView.DataError

    End Sub

    Private Sub Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Pur_UnitOfMeasurementBindingSource.EndEdit()
            Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Update(Me.DsUOM.tbl_Pur_UnitOfMeasurement)
            MsgBox("Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class