Public Class frmbillingMatTran

    Private Sub View_Tran_INBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View_Tran_INBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.View_Tran_INBindingSource.EndEdit()
            'Me.TableAdapterManager.UpdateAll(Me.DSBilling)
            Me.View_Tran_INTableAdapter.Update(Me.DSBilling.View_Tran_IN)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmbillingMatTran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBilling.View_Tran_IN' table. You can move, or remove it, as needed.
        Try
            Me.View_Tran_INTableAdapter.FillBy(Me.DSBilling.View_Tran_IN, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Me.View_Tran_INTableAdapter.FillBy(Me.DSBilling.View_Tran_IN, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            Me.View_Tran_INTableAdapter.FillBy(Me.DSBilling.View_Tran_IN, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub View_Tran_INDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Tran_INDataGridView.CellContentClick
        If e.ColumnIndex = 16 Then
            If Me.View_Tran_INDataGridView.Item(16, e.RowIndex).Value Is DBNull.Value Then
                Me.View_Tran_INDataGridView.Item(16, e.RowIndex).Value = True
                Me.View_Tran_INDataGridView.Item(17, e.RowIndex).Value = Now.Date
            Else
                If Me.View_Tran_INDataGridView.Item(16, e.RowIndex).Value = False Then
                    Me.View_Tran_INDataGridView.Item(16, e.RowIndex).Value = True
                    Me.View_Tran_INDataGridView.Item(17, e.RowIndex).Value = Now.Date
                Else
                    Me.View_Tran_INDataGridView.Item(16, e.RowIndex).Value = False
                    Me.View_Tran_INDataGridView.Item(14, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub View_Tran_INDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Tran_INDataGridView.CellEnter
        
        If e.ColumnIndex >= 11 Then
            Try
                'MsgBox(View_Tran_INDataGridView(10, e.RowIndex).Value)
            Catch ex As Exception

            End Try

            If View_Tran_INDataGridView(12, e.RowIndex).Value Is DBNull.Value Then
                Try
                    View_Tran_INDataGridView(12, e.RowIndex).Value = View_Tran_INDataGridView(12, e.RowIndex - 1).Value
                Catch ex As Exception
                End Try
            ElseIf View_Tran_INDataGridView(12, e.RowIndex).Value = Nothing Then
                Try
                    View_Tran_INDataGridView(12, e.RowIndex).Value = View_Tran_INDataGridView(12, e.RowIndex - 1).Value
                Catch ex As Exception
                End Try
            End If
            If View_Tran_INDataGridView(13, e.RowIndex).Value Is DBNull.Value Then
                Try
                    View_Tran_INDataGridView(13, e.RowIndex).Value = View_Tran_INDataGridView(13, e.RowIndex - 1).Value
                Catch ex As Exception
                End Try
            End If

            If View_Tran_INDataGridView(11, e.RowIndex).Value Is DBNull.Value Then
                Try
                    View_Tran_INDataGridView(11, e.RowIndex).Value = View_Tran_INDataGridView(11, e.RowIndex - 1).Value
                Catch ex As Exception
                End Try
            ElseIf View_Tran_INDataGridView(11, e.RowIndex).Value = Nothing Then
                Try
                    View_Tran_INDataGridView(11, e.RowIndex).Value = View_Tran_INDataGridView(11, e.RowIndex - 1).Value
                Catch ex As Exception
                End Try
            End If

            If View_Tran_INDataGridView(18, e.RowIndex).Value Is DBNull.Value Then
                Try
                    View_Tran_INDataGridView(18, e.RowIndex).Value = View_Tran_INDataGridView(18, e.RowIndex - 1).Value
                Catch ex As Exception
                End Try
            End If
        End If

        'If e.ColumnIndex = 9 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Then
        '    'MsgBox(View_Tran_INDataGridView(10, e.RowIndex).Value)
        '    If View_Tran_INDataGridView(10, e.RowIndex).Value Is DBNull.Value Then
        '        Try
        '            View_Tran_INDataGridView(10, e.RowIndex).Value = View_Tran_INDataGridView(10, e.RowIndex - 1).Value
        '        Catch ex As Exception
        '        End Try
        '    End If

        '    If View_Tran_INDataGridView(11, e.RowIndex).Value Is DBNull.Value Then
        '        Try
        '            View_Tran_INDataGridView(11, e.RowIndex).Value = View_Tran_INDataGridView(11, e.RowIndex - 1).Value
        '        Catch ex As Exception
        '        End Try
        '    End If
        If View_Tran_INDataGridView(11, e.RowIndex).Value IsNot DBNull.Value Or View_Tran_INDataGridView(12, e.RowIndex).Value IsNot DBNull.Value Then
            If View_Tran_INDataGridView(21, e.RowIndex).Value Is DBNull.Value Then
                View_Tran_INDataGridView(21, e.RowIndex).Value = Now.Date
            End If
        End If
        '    If View_Tran_INDataGridView(9, e.RowIndex).Value Is DBNull.Value Then
        '        Try
        '            View_Tran_INDataGridView(9, e.RowIndex).Value = View_Tran_INDataGridView(9, e.RowIndex - 1).Value
        '        Catch ex As Exception
        '        End Try

        '    End If
        '    'If View_Tran_INDataGridView(15, e.RowIndex).Value Is DBNull.Value Then
        '    '    Try
        '    '        View_Tran_INDataGridView(15, e.RowIndex).Value = View_Tran_INDataGridView(15, e.RowIndex - 1).Value
        '    '    Catch ex As Exception
        '    '    End Try
        '    'End If
        'End If
        ''If e.ColumnIndex = 11 Then

        ''    If View_Tran_INDataGridView(11, e.RowIndex).Value Is DBNull.Value And View_Tran_INDataGridView(10, e.RowIndex).Value IsNot DBNull.Value Then
        ''        View_Tran_INDataGridView(11, e.RowIndex).Value = Now.Date
        ''    End If

        ''End If
        'If e.ColumnIndex = 13 Then

        '    If View_Tran_INDataGridView(16, e.RowIndex).Value Is DBNull.Value And View_Tran_INDataGridView(10, e.RowIndex).Value IsNot DBNull.Value Then
        '        View_Tran_INDataGridView(16, e.RowIndex).Value = Now.Date
        '    End If
        'End If
    End Sub

    Private Sub View_Tran_INDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_Tran_INDataGridView.DataError

    End Sub

    Private Sub PONOtextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PONOtextBox.Click

    End Sub

    Private Sub PONOtextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PONOtextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_Tran_INBindingSource.Filter = "POID=" & Me.PONOtextBox.Text & ""
            PONOtextBox.Text = ""
            CMBillingTran.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Me.View_Tran_INBindingSource.RemoveFilter()
    End Sub

    Private Sub CompanyNameText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyNameText.Click

    End Sub

    Private Sub CompanyNameText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CompanyNameText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_Tran_INBindingSource.Filter = "CompanyName like'%" & Me.CompanyNameText.Text & "%'"
            CompanyNameText.Text = ""
            CMCompanyName.Hide()
        End If
    End Sub

    Private Sub CMItemNameText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMItemNameText.Click

    End Sub

    Private Sub CMItemNameText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMItemNameText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_Tran_INBindingSource.Filter = "L4Name like'%" & Me.CMItemNameText.Text & "%'"
            CMItemNameText.Text = ""
            CMItemName.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.View_Tran_INBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.View_Tran_INBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.View_Tran_INBindingSource.RemoveFilter()
    End Sub
End Class