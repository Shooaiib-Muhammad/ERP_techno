Public Class frmBillingTranNew

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
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSBilling.tbl_Inv_L4)
        Me.Tbl_Billing_PartyTableAdapter.Fill(Me.DSBilling.tbl_Billing_Party)
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSBilling.tbl_Inv_Tran_Date, Now.Date.AddDays(-300))
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Me.Tbl_Billing_Transactions_DetailTableAdapter.FillBy1(Me.DSBilling.tbl_Billing_Transactions_Detail)
        Me.Tbl_Billing_TransactionsTableAdapter.Fill(Me.DSBilling.tbl_Billing_Transactions, Me.DayNoLabel1.Text)
        If frmLoginVer.UserID = 74 Then
            Me.Delete.Visible = True
            Me.Delete.Visible = True
        Else
            Me.Delete.Visible = True
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
            Me.Tbl_Billing_TransactionsTableAdapter.Fill(Me.DSBilling.tbl_Billing_Transactions, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
        TotalAMount1()
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Billing_Transactions_DetailBindingSource.EndEdit()
            Me.Tbl_Billing_Transactions_DetailTableAdapter.Update(Me.DSBilling.tbl_Billing_Transactions_Detail)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        'Dim Position As Integer = Me.Tbl_Billing_TransactionsBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Billing_TransactionsBindingSource.EndEdit()
            Me.Tbl_Billing_TransactionsTableAdapter.Update(Me.DSBilling.tbl_Billing_Transactions)
            Me.Tbl_Billing_TransactionsTableAdapter.Fill(Me.DSBilling.tbl_Billing_Transactions, Me.DayNoLabel1.Text)
            Me.Tbl_Billing_TransactionsBindingSource.MoveLast()
            'Me.Tbl_Billing_TransactionsBindingSource.Position = Position
            MsgBox("Record Saved Successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TotalAMount1()
        Dim TotalAmount As Integer = 0
        If Me.Tbl_Billing_Transactions_DetailDataGridView.RowCount > 0 Then
            For i As Integer = 0 To Me.Tbl_Billing_Transactions_DetailDataGridView.RowCount - 1
                Try
                    TotalAmount = TotalAmount + Me.Tbl_Billing_Transactions_DetailDataGridView(6, i).Value
                Catch ex As Exception
                End Try
            Next
        Else
            TotalAmount = 0
        End If
        
        Me.AmountLabel.Text = TotalAmount
    End Sub
    Private Sub Tbl_Billing_Transactions_DetailDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Billing_Transactions_DetailDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Billing_Transactions_DetailDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Billing_Transactions_DetailDataGridView.DataError

    End Sub

    Private Sub Tbl_Billing_Transactions_DetailDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Billing_Transactions_DetailDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If

    End Sub

    Private Sub Tbl_Billing_Transactions_DetailDataGridView_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Billing_Transactions_DetailDataGridView.RowEnter
        TotalAMount1()
    End Sub

    Private Sub Tbl_Billing_Transactions_DetailDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Billing_Transactions_DetailDataGridView.RowLeave
        TotalAMount1()
    End Sub

    Private Sub Tbl_Billing_TransactionsBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Billing_TransactionsBindingSource.PositionChanged
        TotalAMount1()
    End Sub
End Class