Public Class batchIN

    Private Sub load()
        Try
            Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DsUOM.tbl_Inv_Tran_In, CType(DateTimePicker1.Text, String), CType(DateTimePicker2.Text, String))
        Catch ex As System.Exception

        End Try
    End Sub
    Private Sub batchIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        load()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        load()

    End Sub

    Private Sub Tbl_Inv_Tran_InBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Inv_Tran_InBindingNavigatorSaveItem.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
            Tbl_Inv_Tran_InTableAdapter.Update(DsUOM.tbl_Inv_Tran_In)
            load()
            MsgBox("Data saved")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_Inv_Tran_InBindingSource.Filter = "CompanyName like'%" & Me.ToolStripTextBox1.Text & "%'"
            Me.ToolStripTextBox1.Clear()
            Me.ContextMenuStrip1.Hide()
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Tran_InDataGridView.DataError

    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Tbl_Inv_Tran_InBindingSource.RemoveFilter()
    End Sub
End Class