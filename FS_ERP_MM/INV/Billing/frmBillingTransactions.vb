Public Class frmBillingTransactions

    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingNavigatorSaveItem.Click
        Dim Position As Integer = Me.Tbl_Billing_TransactionsBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Billing_TransactionsBindingSource.EndEdit()
            Me.Tbl_Billing_TransactionsTableAdapter.Update(Me.DSBilling.tbl_Billing_Transactions)
            Me.Tbl_Billing_TransactionsTableAdapter.Fill(Me.DSBilling.tbl_Billing_Transactions, Me.DayNoLabel1.Text)
            Me.Tbl_Billing_TransactionsBindingSource.Position = Position
            MsgBox("Record Saved Successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Private Sub frmBillingTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Billing_PartyTableAdapter.Fill(Me.DSBilling.tbl_Billing_Party)
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSBilling.tbl_Inv_Tran_Date, Now.Date.AddDays(-7))
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()

        Me.Tbl_Billing_TransactionsTableAdapter.Fill(Me.DSBilling.tbl_Billing_Transactions, Me.DayNoLabel1.Text)
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
            Me.Tbl_Billing_TransactionsTableAdapter.Fill(Me.DSBilling.tbl_Billing_Transactions, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Tbl_Billing_TransactionsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Billing_TransactionsDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Billing_TransactionsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Billing_TransactionsDataGridView.DataError

    End Sub

    Private Sub Tbl_Billing_TransactionsDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Billing_TransactionsDataGridView.EditingControlShowing

        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If

    End Sub
End Class