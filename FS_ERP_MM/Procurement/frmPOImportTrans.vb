Public Class frmPOImportTrans

    Private Sub frmPOImportTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPOImportEntry.View_PO_D' table. You can move, or remove it, as needed.
        Me.View_PO_DTableAdapter.Fill(Me.DSPOImportEntry.View_PO_D)
        'TODO: This line of code loads data into the 'DSPOImportEntry.tbl_Inv_Imp_Mat_Trans' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Imp_Mat_TransTableAdapter.Fill(Me.DSPOImportEntry.tbl_Inv_Imp_Mat_Trans)
        'TODO: This line of code loads data into the 'DSPOImportEntry.View_PO_ID' table. You can move, or remove it, as needed.
        Me.View_PO_IDTableAdapter.Fill(Me.DSPOImportEntry.View_PO_ID)

    End Sub
    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter And Me.ToolStripTextBox1.Text.Length > 0 Then
            'Dim mydate As System.DateTime
            'Try
            '    mydate = CDate("#" & Me.CMtxtEF.Text & "#")
            'Catch ex As Exception
            '    MsgBox("Enter The Correct Date Format.")
            'End Try
            Me.View_PO_IDBindingSource.Filter = "CompanyName like'%" & Me.ToolStripTextBox1.Text & "%'"
            Me.ToolStripTextBox1.Text = ""
            'Me.CMtxtEF.ForeColor = Color.Silver
            CMComp.Hide()
        End If
    End Sub
    Private Sub Tbl_Inv_Imp_Mat_TransDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Imp_Mat_TransDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Imp_Mat_TransDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Imp_Mat_TransDataGridView.CellEnter
        If e.ColumnIndex = 5 Then
            If Me.Tbl_Inv_Imp_Mat_TransDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Imp_Mat_TransDataGridView(3, e.RowIndex).Value = Me.PODNoLabel1.Text
            End If
        End If
        If e.ColumnIndex = 9 Then
            If Me.Tbl_Inv_Imp_Mat_TransDataGridView(9, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Imp_Mat_TransDataGridView(9, e.RowIndex).Value = Me.POQtyLabel1.Text
            End If
            If Me.Tbl_Inv_Imp_Mat_TransDataGridView(10, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Imp_Mat_TransDataGridView(10, e.RowIndex).Value = Me.UOMLabel1.Text
            End If
            If Me.Tbl_Inv_Imp_Mat_TransDataGridView(29, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Imp_Mat_TransDataGridView(29, e.RowIndex).Value = Me.CurencyLabel1.Text
            End If
        End If

    End Sub

    Private Sub Tbl_Inv_Imp_Mat_TransDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Imp_Mat_TransDataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_Imp_Mat_TransDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Imp_Mat_TransDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim k As Integer = Me.Tbl_Inv_Imp_Mat_TransBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_Imp_Mat_TransBindingSource.EndEdit()
            Me.Tbl_Inv_Imp_Mat_TransTableAdapter.Update(Me.DSPOImportEntry.tbl_Inv_Imp_Mat_Trans)
            Me.Tbl_Inv_Imp_Mat_TransTableAdapter.Fill(Me.DSPOImportEntry.tbl_Inv_Imp_Mat_Trans)
            Me.Tbl_Inv_Imp_Mat_TransBindingSource.Position = k
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.View_PO_IDBindingSource.RemoveFilter()
    End Sub
End Class