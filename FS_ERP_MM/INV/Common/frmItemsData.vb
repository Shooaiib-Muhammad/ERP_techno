Public Class frmItemsData
    Private Sub Tbl_Inv_L3BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Inv_L3BindingNavigatorSaveItem.Click
        Dim I As Int16 = Me.Tbl_Inv_L3BindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Inv_L3BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSMatData)
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSMatData.tbl_Inv_Rack_Info)
            Me.Tbl_Inv_L3BindingSource.Position = I
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub frmItemsData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMatData.tbl_Inv_Rack_Info' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSMatData.tbl_Inv_Rack_Info)
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'DSMatData.tbl_Inv_L3' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSMatData.tbl_Inv_L3)

    End Sub

    Private Sub Tbl_Inv_L3DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Inv_L3DataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_L3DataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Inv_L3DataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_L3DataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_L3DataGridView.EditingControlShowing

        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If

    End Sub
End Class