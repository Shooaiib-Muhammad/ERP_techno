Public Class frmBillingVerifying

    Private Sub Tbl_Billing_TransactionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Billing_TransactionsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Billing_TransactionsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSBillingVerify)
            Me.Tbl_Billing_TransactionsTableAdapter.Fill(Me.DSBillingVerify.tbl_Billing_Transactions)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmBillingVerifying_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBillingVerify.tbl_Pur_PO' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_POTableAdapter.Fill(Me.DSBillingVerify.tbl_Pur_PO)
        'TODO: This line of code loads data into the 'DSBilling.tbl_Billing_Party' table. You can move, or remove it, as needed.
        Me.Tbl_Billing_PartyTableAdapter.Fill(Me.DSBilling.tbl_Billing_Party)
        'TODO: This line of code loads data into the 'DSBillingVerify.tbl_Billing_Transactions' table. You can move, or remove it, as needed.
        Me.Tbl_Billing_TransactionsTableAdapter.Fill(Me.DSBillingVerify.tbl_Billing_Transactions)
    End Sub

    Private Sub Tbl_Billing_TransactionsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Billing_TransactionsDataGridView.CellContentClick
        If e.ColumnIndex = 10 Then
            If Me.Tbl_Billing_TransactionsDataGridView.Item(10, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Billing_TransactionsDataGridView.Item(10, e.RowIndex).Value = True
                Me.Tbl_Billing_TransactionsDataGridView.Item(11, e.RowIndex).Value = Now.Date
            Else
                If Me.Tbl_Billing_TransactionsDataGridView.Item(10, e.RowIndex).Value = False Then
                    Me.Tbl_Billing_TransactionsDataGridView.Item(10, e.RowIndex).Value = True
                    Me.Tbl_Billing_TransactionsDataGridView.Item(11, e.RowIndex).Value = Now.Date
                Else
                    Me.Tbl_Billing_TransactionsDataGridView.Item(10, e.RowIndex).Value = False
                    Me.Tbl_Billing_TransactionsDataGridView.Item(11, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Billing_TransactionsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Billing_TransactionsDataGridView.DataError

    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Me.Tbl_Billing_TransactionsBindingSource.RemoveFilter()
    End Sub

    Private Sub BillingNoTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BillingNoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_Billing_TransactionsBindingSource.Filter = "InvoiceNo ='" & Me.BillingNoTextBox.Text & "'"
            Me.BillingNoTextBox.Clear()
            Me.CMBillingTran.Hide()
        End If
    End Sub

    Private Sub BillingNoTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BillingNoTextBox.TextChanged
        
    End Sub

    Private Sub Tbl_Billing_TransactionsDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Billing_TransactionsDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class