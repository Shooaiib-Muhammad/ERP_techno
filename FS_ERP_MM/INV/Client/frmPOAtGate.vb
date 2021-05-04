Public Class frmPOAtGate

    Private Sub frmPOAtGate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPURGate.View_PO_D' table. You can move, or remove it, as needed.
        Me.View_PO_DTableAdapter.Fill(Me.DSPURGate.View_PO_D)
        'TODO: This line of code loads data into the 'DSPURGate.View_PO_D' table. You can move, or remove it, as needed.
        Me.View_PO_DTableAdapter.Fill(Me.DSPURGate.View_PO_D)
        'TODO: This line of code loads data into the 'DSPURGate.tbl_Inv_Supplier' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSPURGate.tbl_Inv_Supplier)
        'TODO: This line of code loads data into the 'DSPURGate.tbl_PUR_PO_Gate_Entry' table. You can move, or remove it, as needed.
        Me.Tbl_PUR_PO_Gate_EntryTableAdapter.Fill(Me.DSPURGate.tbl_PUR_PO_Gate_Entry, Me.SupplierIDLabel1.Text)
        'TODO: This line of code loads data into the 'DSPURGate.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSPURGate.tbl_Inv_Tran_Date, Now.Date)

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim J As Integer = Me.Tbl_PUR_PO_Gate_EntryBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_PUR_PO_Gate_EntryBindingSource.EndEdit()
            Me.Tbl_PUR_PO_Gate_EntryTableAdapter.Update(Me.DSPURGate.tbl_PUR_PO_Gate_Entry)
            Me.Tbl_PUR_PO_Gate_EntryTableAdapter.Fill(Me.DSPURGate.tbl_PUR_PO_Gate_Entry, Me.SupplierIDLabel1.Text)
            Me.Tbl_PUR_PO_Gate_EntryBindingSource.Position = J
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_PUR_PO_Gate_EntryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_PUR_PO_Gate_EntryDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_PUR_PO_Gate_EntryDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_PUR_PO_Gate_EntryDataGridView.CellEnter
        If e.ColumnIndex > 0 Then
            If Me.Tbl_PUR_PO_Gate_EntryDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_PUR_PO_Gate_EntryDataGridView(4, e.RowIndex).Value = Now.Date
                Me.Tbl_PUR_PO_Gate_EntryDataGridView(2, e.RowIndex).Value = SupplierIDLabel1.Text
            End If
        End If
    End Sub

    Private Sub Tbl_PUR_PO_Gate_EntryDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_PUR_PO_Gate_EntryDataGridView.DataError

    End Sub

    Private Sub Tbl_PUR_PO_Gate_EntryDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_PUR_PO_Gate_EntryDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub Tbl_Inv_SupplierBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Me.Tbl_PUR_PO_Gate_EntryTableAdapter.Fill(Me.DSPURGate.tbl_PUR_PO_Gate_Entry, Me.SupplierIDLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub
End Class