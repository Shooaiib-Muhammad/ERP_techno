Public Class frmBladerRepRec

    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmBladerRepRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRepairBalderRec.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRepairBalderRec.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSRepairBalderRec.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSRepairBalderRec.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSRepairBalderRec.tbl_Inv_Blader_Repair_Rec' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Blader_Repair_RecTableAdapter.Fill(Me.DSRepairBalderRec.tbl_Inv_Blader_Repair_Rec)
        'TODO: This line of code loads data into the 'DSRepairBalderRec.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DSRepairBalderRec.tbl_Inv_Tran_Date)
        Me.Tbl_Inv_Tran_DateBindingSource.Sort = "DateName ASC"
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Try
            Me.Validate()
            Me.Tbl_Inv_Blader_Repair_RecBindingSource.EndEdit()
            Me.Tbl_Inv_Blader_Repair_RecTableAdapter.Update(Me.DSRepairBalderRec.tbl_Inv_Blader_Repair_Rec)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Inv_Blader_Repair_RecDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Blader_Repair_RecDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Blader_Repair_RecDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Blader_Repair_RecDataGridView.CellEnter
        If e.ColumnIndex >= 1 Then
            If Me.Tbl_Inv_Blader_Repair_RecDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Blader_Repair_RecDataGridView(7, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_Blader_Repair_RecDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Blader_Repair_RecDataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_Blader_Repair_RecDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Blader_Repair_RecDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class