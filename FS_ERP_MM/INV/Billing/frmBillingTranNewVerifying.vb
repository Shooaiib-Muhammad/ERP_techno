Public Class frmBillingTranNewVerifying


    Private Sub frmBillingTranNewVerifying_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Pur_POTableAdapter.Fill(Me.DSBillingVerify.tbl_Pur_PO)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSBilling.tbl_Inv_L4)
        Me.Tbl_Billing_Transactions_DetailTableAdapter.Fill(Me.DSBilling.tbl_Billing_Transactions_Detail)
        Me.View_Billing_TransactionsTableAdapter.Fill(Me.DSBilling.View_Billing_Transactions)
        Me.View_Billing_TransactionsBindingSource.MoveLast()
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Tbl_Billing_Transactions_DetailDataGridView_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)

    End Sub
    Private Sub Tbl_Billing_Transactions_DetailDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Billing_TransactionsDataGridView.CellContentClick
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

    Private Sub Tbl_Billing_Transactions_DetailDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Billing_TransactionsDataGridView.DataError

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SaveToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Billing_Transactions_DetailBindingSource.EndEdit()
            Me.Tbl_Billing_Transactions_DetailTableAdapter.Update(Me.DSBilling.tbl_Billing_Transactions_Detail)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Try
            Me.ValidateChildren()
            Me.View_Billing_TransactionsBindingSource.EndEdit()
            Me.View_Billing_TransactionsTableAdapter.Update(Me.DSBilling.View_Billing_Transactions)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Me.View_Billing_TransactionsBindingSource.RemoveFilter()
    End Sub

    Private Sub BillingNoTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BillingNoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_Billing_TransactionsBindingSource.Filter = "InvoiceNo ='" & Me.BillingNoTextBox.Text & "'"
            Me.BillingNoTextBox.Clear()
            Me.CMBillingTran.Hide()
        End If
    End Sub

    Private Sub VerifyStatusCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerifyStatusCheckBox.CheckedChanged
        If VerifyStatusCheckBox.CheckState = CheckState.Checked Then
            Me.VerifyDateLabel.Text = Now.Date
        ElseIf VerifyStatusCheckBox.CheckState = CheckState.Unchecked Then
            Me.VerifyDateLabel.Text = Nothing
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.View_Billing_TransactionsBindingSource.RemoveFilter()
    End Sub

    Private Sub PartyNameText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyNameText.Click

    End Sub

    Private Sub PartyNameText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PartyNameText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_Billing_TransactionsBindingSource.Filter = "PartyName like'%" & Me.PartyNameText.Text & "%'"
            Me.PartyNameText.Clear()
            Me.CMPartyName.Hide()
        End If
    End Sub
End Class