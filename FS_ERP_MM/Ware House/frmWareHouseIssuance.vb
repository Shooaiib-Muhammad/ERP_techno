Public Class frmWareHouseIssuance

    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSWareHouse)

    End Sub

    Private Sub frmWareHouseIssuance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_WareHouse_InfoTableAdapter.Fill(Me.DSWareHouse.tbl_Inv_WareHouse_Info)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSWareHouse.tbl_Inv_L4)
        Me.Tbl_Inv_WareHouse_IssuanceTableAdapter.Fill(Me.DSWareHouse.tbl_Inv_WareHouse_Issuance)
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSWareHouse.tbl_Inv_Tran_Date, Now.Date)
    End Sub

    Private Sub Tbl_Inv_WareHouse_IssuanceDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_WareHouse_IssuanceDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_WareHouse_IssuanceDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_WareHouse_IssuanceDataGridView.CellEnter
        If e.ColumnIndex > 5 Then
            If Me.Tbl_Inv_WareHouse_IssuanceDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_WareHouse_IssuanceDataGridView(7, e.RowIndex).Value = Me.UnitLabel1.Text
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_WareHouse_IssuanceDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_WareHouse_IssuanceDataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_WareHouse_IssuanceDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_WareHouse_IssuanceDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim i As Integer = Me.Tbl_Inv_WareHouse_IssuanceBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_WareHouse_IssuanceBindingSource.EndEdit()
            Me.Tbl_Inv_WareHouse_IssuanceTableAdapter.Update(Me.DSWareHouse.tbl_Inv_WareHouse_Issuance)
            Me.Tbl_Inv_WareHouse_IssuanceTableAdapter.Fill(Me.DSWareHouse.tbl_Inv_WareHouse_Issuance)
            Me.Tbl_Inv_WareHouse_IssuanceBindingSource.Position = i
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class