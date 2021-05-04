Public Class frmBladerBillingTran4Winding
    Private Sub frmBladerBillingTran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBladderBillingTran.View_UnWinded_Billing_Data' table. You can move, or remove it, as needed.

        LoadRecord()
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSBladderBillingTran.tbl_Inv_Tran_Date, Now.Date)
    End Sub
    Private Sub LoadRecord()
        Me.View_Bladder_Billing_TransactionTableAdapter.FillBy(Me.DSBladderBillingTran.View_Bladder_Billing_Transaction)
        'Me.View_Bladder_BillTableAdapter.Fill(Me.DSBladderBillingTran.View_Bladder_Bill, Me.DTPicker1.Text, Me.DTPicker2.Text)
        Try
            Me.View_UnWinded_Billing_DataTableAdapter.Fill(Me.DSBladderBillingTran.View_UnWinded_Billing_Data, Me.DTPicker1.Text, Me.DTPicker2.Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim btnMsg As DialogResult = MessageBox.Show("Are You Sure Want To Generate Un-Winded Bladders Bill? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Dim DateRange As String = "From " + Format(Me.DTPicker1.Value, "dd/MM/yyyy").ToString + " To " + Format(Me.DTPicker2.Value, "dd/MM/yyyy").ToString
            If Me.View_Bladder_BillDataGridView.RowCount > 0 Then
                For i As Integer = 0 To Me.View_Bladder_BillDataGridView.RowCount - 1
                    Me.Tbl_Bladder_Billing_TransactionsTableAdapter.Insert(CInt(Me.View_Bladder_BillDataGridView(0, i).Value), CInt(Me.View_Bladder_BillDataGridView(13, i).Value), CInt(Me.View_Bladder_BillDataGridView(3, i).Value), Me.View_Bladder_BillDataGridView(6, i).Value.ToString, Me.DayNoLabel1.Text, DateRange, CDbl(Me.View_Bladder_BillDataGridView(4, i).Value), CDbl(Me.View_Bladder_BillDataGridView(9, i).Value), CDbl(Me.View_Bladder_BillDataGridView(11, i).Value), 0, 0, Now.Date, True)
                Next
                LoadRecord()
            Else
                MsgBox("No Record Available To Generate Bladder Bill", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub DTPicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPicker1.ValueChanged
        Me.View_Bladder_BillTableAdapter.Fill(Me.DSBladderBillingTran.View_Bladder_Bill, Me.DTPicker1.Text, Me.DTPicker2.Text)
    End Sub

    Private Sub DTPicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPicker2.ValueChanged
        Me.View_Bladder_BillTableAdapter.Fill(Me.DSBladderBillingTran.View_Bladder_Bill, Me.DTPicker1.Text, Me.DTPicker2.Text)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.View_Bladder_Billing_TransactionBindingSource.EndEdit()
            Me.View_Bladder_Billing_TransactionTableAdapter.Update(Me.DSBladderBillingTran.View_Bladder_Billing_Transaction)
            LoadRecord()
            MsgBox("Billing Transaction Undo Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim obj As New Class_Utility
        obj.LoadReports("", "", "")
    End Sub

    Private Sub View_Bladder_BillDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Bladder_BillDataGridView.CellContentClick

    End Sub

    Private Sub View_Bladder_BillDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles View_Bladder_BillDataGridView.EditingControlShowing

    End Sub

    Private Sub BindingNavigator3_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator3.RefreshItems

    End Sub
End Class