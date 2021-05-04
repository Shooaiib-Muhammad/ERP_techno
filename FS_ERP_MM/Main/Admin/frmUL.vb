Public Class frmUL
    Private Sub frmUL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUL.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSUL.tbl_Inv_LocalCust)
        Me.Tbl_User_LoginsTableAdapter.Fill(Me.DSUL.tbl_User_Logins)
    End Sub
    Private Sub Tbl_User_LoginsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_User_LoginsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_User_LoginsBindingSource.EndEdit()
            Me.Tbl_User_LoginsTableAdapter.Update(Me.DSUL.tbl_User_Logins)
            MsgBox("Record Updated.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_User_LoginsBindingSource.Filter = "LoginName like'%" & Me.ToolStripTextBox1.Text & "%'"
            Me.ToolStripTextBox1.Clear()
            Me.SupplierContextMenuStrip.Hide()
        End If
    End Sub
    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_User_LoginsBindingSource.RemoveFilter()

        'Me.ToolStripTextBox1.Text = "Enter Company Name"
        'Me.ToolStripTextBox1.ForeColor = Color.Silver
    End Sub
    Private Sub Tbl_User_LoginsDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_User_LoginsDataGridView.CellEnter
        If e.ColumnIndex = 5 Then
            If Me.Tbl_User_LoginsDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_User_LoginsDataGridView(5, e.RowIndex).Value = Now.Date
            End If
            If Me.Tbl_User_LoginsDataGridView(9, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_User_LoginsDataGridView(9, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub
    Private Sub Tbl_User_LoginsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_User_LoginsDataGridView.DataError
    End Sub
    Private Sub Tbl_User_LoginsDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_User_LoginsDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub Tbl_User_LoginsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_User_LoginsDataGridView.CellContentClick

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub
End Class