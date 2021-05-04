Public Class frmActsBilling
    Private Sub Tbl_Billing_TransactionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Billing_TransactionsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Billing_TransactionsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSBillingVerify)
            Me.Tbl_Billing_TransactionsTableAdapter.FillBy(Me.DSBillingVerify.tbl_Billing_Transactions)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception

        End Try
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
    Private Sub frmActsBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Billing_PartyTableAdapter.Fill(Me.DSBilling.tbl_Billing_Party)
        Me.Tbl_Billing_TransactionsTableAdapter.FillBy(Me.DSBillingVerify.tbl_Billing_Transactions)
    End Sub

    Private Sub Tbl_Billing_TransactionsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Billing_TransactionsDataGridView.CellContentClick
        If e.ColumnIndex = 2 Then
            If Me.Tbl_Billing_TransactionsDataGridView.Item(2, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Billing_TransactionsDataGridView.Item(2, e.RowIndex).Value = True
                Me.Tbl_Billing_TransactionsDataGridView.Item(3, e.RowIndex).Value = Now.Date
            Else
                If Me.Tbl_Billing_TransactionsDataGridView.Item(2, e.RowIndex).Value = False Then
                    Me.Tbl_Billing_TransactionsDataGridView.Item(2, e.RowIndex).Value = True
                    Me.Tbl_Billing_TransactionsDataGridView.Item(3, e.RowIndex).Value = Now.Date
                Else
                    Me.Tbl_Billing_TransactionsDataGridView.Item(2, e.RowIndex).Value = False
                    Me.Tbl_Billing_TransactionsDataGridView.Item(3, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Billing_TransactionsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Billing_TransactionsDataGridView.DataError

    End Sub
End Class