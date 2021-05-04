Public Class CancelationGP


    Private Sub CancelationGP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSLocalPur.tbl_Mat_GatePass2' table. You can move, or remove it, as needed.
        Data()

    End Sub
    Private Sub Data()
        Try
            Me.Tbl_Mat_GatePass2TableAdapter.Fill(Me.DSLocalPur.tbl_Mat_GatePass2, DateTimePicker1.Text, DateTimePicker2.Text, ComboBox2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Data()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Data()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Tbl_Mat_GatePass2TableAdapter.UpdateQuery(ComboBox1.Text, GMNoLabel4.Text)
            Data()
            MsgBox("Data Saved")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Tbl_Mat_GatePass2BindingSource.Filter = "GPNo = " & Val(ToolStripTextBox1.Text)
            ToolStripTextBox1.Clear()
            ContextMenuStrip1.Visible = False
        End If
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_Mat_GatePass2BindingSource.RemoveFilter()
        Me.Tbl_Mat_GatePass2BindingSource.Position = Me.Tbl_Mat_GatePass2BindingSource.Count - 1
    End Sub
End Class