Public Class frmBladderProcesses

    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSRepairBalderRec)
    End Sub

    Private Sub frmBladderProcesses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRepairBalderRec.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRepairBalderRec.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSRepairBalderRec.tbl_Inv_Repair_Blader_Processes' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Repair_Blader_ProcessesTableAdapter.Fill(Me.DSRepairBalderRec.tbl_Inv_Repair_Blader_Processes)
        'TODO: This line of code loads data into the 'DSRepairBalderRec.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DSRepairBalderRec.tbl_Inv_Tran_Date)
        Me.Tbl_Inv_Tran_DateBindingSource.Sort = "DateName ASC"
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Try
            Me.Validate()
            Me.Tbl_Inv_Repair_Blader_ProcessesBindingSource.EndEdit()
            Me.Tbl_Inv_Repair_Blader_ProcessesTableAdapter.Update(Me.DSRepairBalderRec.tbl_Inv_Repair_Blader_Processes)
            Me.Tbl_Inv_Repair_Blader_ProcessesTableAdapter.Fill(Me.DSRepairBalderRec.tbl_Inv_Repair_Blader_Processes)
            Me.Tbl_Inv_Repair_Blader_ProcessesBindingSource.MoveLast()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Inv_Repair_Blader_ProcessesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Repair_Blader_ProcessesDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Repair_Blader_ProcessesDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Repair_Blader_ProcessesDataGridView.CellEnter
        If e.ColumnIndex >= 1 Then
            If Me.Tbl_Inv_Repair_Blader_ProcessesDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Repair_Blader_ProcessesDataGridView(6, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_Repair_Blader_ProcessesDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Repair_Blader_ProcessesDataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_Repair_Blader_ProcessesDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Repair_Blader_ProcessesDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class