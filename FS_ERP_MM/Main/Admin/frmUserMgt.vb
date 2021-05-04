Public Class frmUserMgt
    Private Sub frmUserMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_User_LoginsTableAdapter.Fill(Me.DSUM.tbl_User_Logins)
        Me.Tbl_User_DomainTableAdapter.Fill(Me.DSUM.tbl_User_Domain)
        Me.Tbl_User_AccountsTableAdapter.Fill(Me.DSUM.tbl_User_Accounts)
        Me.Tbl_User_ERP_ModTableAdapter.Fill(Me.DSUM.tbl_User_ERP_Mod)
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.Validate()
            Me.Tbl_User_AccountsBindingSource.EndEdit()
            Me.Tbl_User_AccountsTableAdapter.Update(Me.DSUM.tbl_User_Accounts)
            MsgBox("Records Updated.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_User_AccountsDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_User_AccountsDataGridView.CellEnter
        If e.ColumnIndex = 3 Then
            If Me.Tbl_User_AccountsDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_User_AccountsDataGridView(3, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub
    Private Sub Tbl_User_AccountsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_User_AccountsDataGridView.DataError
    End Sub
    Private Sub Tbl_User_AccountsDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_User_AccountsDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class