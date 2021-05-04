Public Class frmCancelledReq
    Private Sub frmCancelledReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAudit.View_Inv_Req' table. You can move, or remove it, as needed.
        Me.View_Inv_ReqTableAdapter.Fill(Me.DSAudit.View_Inv_Req)
        'TODO: This line of code loads data into the 'DSAudit.View_Plan' table. You can move, or remove it, as needed.
        LoadPlan()

    End Sub
    Private Sub LoadPlan()
        Try
            Me.View_PlanTableAdapter.FillBy(Me.DSAudit.View_Plan, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadPlan()

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadPlan()
    End Sub

    Private Sub View_Inv_ReqDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Inv_ReqDataGridView.CellContentClick
        If e.ColumnIndex = 12 Then
            Dim dgResult As DialogResult = MessageBox.Show("Are you sure," & vbCrLf & "You want to Undo Cancel Material Requisition ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If dgResult = 6 Then
                Me.View_Inv_ReqTableAdapter.UpdateQuery(Me.View_Inv_ReqTableAdapter.UpdateQuery(Me.View_Inv_ReqDataGridView(0, e.RowIndex).Value))
                Me.View_Inv_ReqTableAdapter.Fill(Me.DSAudit.View_Inv_Req)
            End If
        End If
    End Sub

    Private Sub View_PlanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles View_PlanBindingNavigatorSaveItem.Click
        Me.View_PlanTableAdapter.UpdateQuery(Me.PlanDateMaskedTextBox.Text, Me.MPIDComboBox.Text)
        MsgBox("Record Updated Successfully")
    End Sub
End Class