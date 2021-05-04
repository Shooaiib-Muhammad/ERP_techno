Public Class FrmDemandsupdatation

    Private Sub Load()
        Try
            Me.View_Pur_demandsTableAdapter.Fill(Me.DSInwardVeri.view_Pur_demands, DateTimePicker1.Text, DateTimePicker2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmDemandsupdatation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSInwardVeri.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSInwardVeri.tbl_Pur_UnitOfMeasurement)
        'TODO: This line of code loads data into the 'DSInwardVeri.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSInwardVeri.tbl_Inv_L4)
        Load()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Load()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Load()
    End Sub

    Private Sub View_Pur_demandsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles View_Pur_demandsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.View_Pur_demandsBindingSource.EndEdit()
            Me.View_Pur_demandsTableAdapter.Update(Me.DSInwardVeri.view_Pur_demands)
            Load()
            'Me.Tbl_Mat_GatePass_DetailsBindingSource.Position = Me.Tbl_Mat_GatePass_DetailsBindingSource.Count
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub View_Pur_demandsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Pur_demandsDataGridView.CellContentClick

    End Sub

    Private Sub View_Pur_demandsDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles View_Pur_demandsDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.View_Pur_demandsTableAdapter.FillBy(Me.DSInwardVeri.view_Pur_demands, ToolStripTextBox1.Text)


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Load()

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        Try
            Me.View_Pur_demandsTableAdapter.FillBy(Me.DSInwardVeri.view_Pur_demands, ToolStripTextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub View_Pur_demandsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_Pur_demandsDataGridView.DataError

    End Sub
End Class