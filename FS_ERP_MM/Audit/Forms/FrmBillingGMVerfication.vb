Public Class FrmBillingGMVerfication
    Private Sub Tbl_Sec_Middle_NEWBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Sec_Middle_NEWBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSInwardVeri)

    End Sub

    Private Sub FrmBillingGMVerfication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSInwardVeri.tbl_Sec_Middle_NEW' table. You can move, or remove it, as needed.
        load()

    End Sub
    Private Sub load()
        Try
            Me.Tbl_Sec_Middle_NEWTableAdapter.FillBy(Me.DSInwardVeri.tbl_Sec_Middle_NEW, DateTimePicker1.Text, DateTimePicker2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        load()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        load()
    End Sub

    Private Sub Tbl_Sec_Middle_NEWDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Sec_Middle_NEWDataGridView.CellContentClick
        'If e.ColumnIndex = 7 Then
        '    If Me.Tbl_Sec_Middle_NEWDataGridView.Item(7, e.RowIndex).Value Is DBNull.Value Then
        '        Me.Tbl_Sec_Middle_NEWDataGridView.Item(7, e.RowIndex).Value = True
        '        Me.Tbl_Sec_Middle_NEWDataGridView.Item(8, e.RowIndex).Value = Now
        '    End If
        'End If

        If e.ColumnIndex = 7 Then
            If Me.Tbl_Sec_Middle_NEWDataGridView.Item(7, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Sec_Middle_NEWDataGridView.Item(7, e.RowIndex).Value = True
                Me.Tbl_Sec_Middle_NEWDataGridView.Item(8, e.RowIndex).Value = Now
            Else
                If Me.Tbl_Sec_Middle_NEWDataGridView.Item(7, e.RowIndex).Value = False Then
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(8, e.RowIndex).Value = True
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(8, e.RowIndex).Value = Now
                Else
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(7, e.RowIndex).Value = False
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(8, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If

        If e.ColumnIndex = 9 Then
            If Me.Tbl_Sec_Middle_NEWDataGridView.Item(9, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Sec_Middle_NEWDataGridView.Item(9, e.RowIndex).Value = True
                Me.Tbl_Sec_Middle_NEWDataGridView.Item(10, e.RowIndex).Value = Now
            Else
                If Me.Tbl_Sec_Middle_NEWDataGridView.Item(9, e.RowIndex).Value = False Then
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(9, e.RowIndex).Value = True
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(10, e.RowIndex).Value = Now
                Else
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(9, e.RowIndex).Value = False
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(10, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
        If e.ColumnIndex = 11 Then
            If Me.Tbl_Sec_Middle_NEWDataGridView.Item(11, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Sec_Middle_NEWDataGridView.Item(11, e.RowIndex).Value = True
                Me.Tbl_Sec_Middle_NEWDataGridView.Item(12, e.RowIndex).Value = Now
            Else
                If Me.Tbl_Sec_Middle_NEWDataGridView.Item(11, e.RowIndex).Value = False Then
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(11, e.RowIndex).Value = True
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(12, e.RowIndex).Value = Now
                Else
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(11, e.RowIndex).Value = False
                    Me.Tbl_Sec_Middle_NEWDataGridView.Item(12, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If

    End Sub

    Private Sub Tbl_Sec_Middle_NEWDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Sec_Middle_NEWDataGridView.DataError

    End Sub

    Private Sub Tbl_Sec_Middle_NEWBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Sec_Middle_NEWBindingNavigatorSaveItem.Click
        Try

            Me.Validate()
            Me.Tbl_Sec_Middle_NEWBindingSource.EndEdit()
            Me.Tbl_Sec_Middle_NEWTableAdapter.Update(Me.DSInwardVeri.tbl_Sec_Middle_NEW)
            load()


            MsgBox("Data Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Sec_Middle_NEWDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Sec_Middle_NEWDataGridView.CellEnter
        'If e.ColumnIndex = 7 Then
        '    If Me.Tbl_Sec_Middle_NEWDataGridView.Item(7, e.RowIndex).Value Is DBNull.Value Then
        '        Me.Tbl_Sec_Middle_NEWDataGridView.Item(7, e.RowIndex).Value = True
        '        Me.Tbl_Sec_Middle_NEWDataGridView.Item(8, e.RowIndex).Value = Now
        '    End If
        'End If

        'If e.ColumnIndex = 9 Then
        '    If Me.Tbl_Sec_Middle_NEWDataGridView.Item(9, e.RowIndex).Value Is DBNull.Value Then
        '        Me.Tbl_Sec_Middle_NEWDataGridView.Item(9, e.RowIndex).Value = True
        '        Me.Tbl_Sec_Middle_NEWDataGridView.Item(10, e.RowIndex).Value = Now
        '    End If
        'End If
        'If e.ColumnIndex = 11 Then
        '    If Me.Tbl_Sec_Middle_NEWDataGridView.Item(11, e.RowIndex).Value Is DBNull.Value Then
        '        Me.Tbl_Sec_Middle_NEWDataGridView.Item(11, e.RowIndex).Value = True
        '        Me.Tbl_Sec_Middle_NEWDataGridView.Item(12, e.RowIndex).Value = Now
        '    End If
        'End If
    End Sub
    Dim BtnMsg As DialogResult
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = CheckState.Checked Then
            BtnMsg = MessageBox.Show("Are You Sure Want To Check All GM Verify  Status ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If BtnMsg = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To Me.Tbl_Sec_Middle_NEWDataGridView.RowCount - 1
                    Me.Tbl_Sec_Middle_NEWDataGridView(9, i).Value = True
                    Me.Tbl_Sec_Middle_NEWDataGridView(10, i).Value = Now.Date
                Next
                CheckBox1.CheckState = CheckState.Unchecked
            End If

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            BtnMsg = MessageBox.Show("Are You Sure Want To Check All Accounts Verify  Status ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If BtnMsg = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To Me.Tbl_Sec_Middle_NEWDataGridView.RowCount - 1
                    Me.Tbl_Sec_Middle_NEWDataGridView(11, i).Value = True
                    Me.Tbl_Sec_Middle_NEWDataGridView(12, i).Value = Now.Date
                Next
                CheckBox2.CheckState = CheckState.Unchecked
            End If

        End If
    End Sub
End Class