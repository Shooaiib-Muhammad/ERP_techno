Public Class frmUOMD

    Private Sub Tbl_Pur_UnitofMeasurementDtlBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_UnitofMeasurementDtlBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Pur_UnitofMeasurementDtlBindingSource.EndEdit()
            Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.Update(Me.DSExtCust.tbl_Pur_UnitofMeasurementDtl)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmUOMD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSExtCust.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSExtCust.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSExtCust.tbl_Pur_UnitofMeasurementDtl' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.Fill(Me.DSExtCust.tbl_Pur_UnitofMeasurementDtl)

    End Sub

    Private Sub Tbl_Pur_UnitofMeasurementDtlDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_UnitofMeasurementDtlDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Pur_UnitofMeasurementDtlDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_UnitofMeasurementDtlDataGridView.DataError

    End Sub

    Private Sub Tbl_Pur_UnitofMeasurementDtlDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Pur_UnitofMeasurementDtlDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class