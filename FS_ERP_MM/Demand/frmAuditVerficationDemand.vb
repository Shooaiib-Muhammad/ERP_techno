Public Class frmAuditVerficationDemand


    Private Sub frmAuditVerficationDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDemand.View_Tran_IN' table. You can move, or remove it, as needed.
        loadData()
        'TODO: This line of code loads data into the 'DSDemand.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        'Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSDemand.tbl_Inv_Tran_Date)
        'Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.ValidateChildren()
            Me.View_Audit_Billing_verficationTableAdapter.Update(Me.DSDemand.view_Audit_Billing_verfication)
            loadData()

            MsgBox("Data Updated Successfully")

        Catch ex As Exception

        End Try
    End Sub
    Private Sub loadData()
        If RadioButton4.Checked = True Then
            Try
                Me.View_Audit_Billing_verficationTableAdapter.Fill(Me.DSDemand.view_Audit_Billing_verfication, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
        ElseIf RadioButton2.Checked = True Then
            Try
                Me.View_Audit_Billing_verficationTableAdapter.FillBy(Me.DSDemand.view_Audit_Billing_verfication, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
        End If



    End Sub
    Private Sub View_Tran_INDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Tran_INDataGridView.CellContentClick
        If e.ColumnIndex = 18 Then
            If Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value Is DBNull.Value Then
                Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value = True
                Me.View_Tran_INDataGridView.Item(19, e.RowIndex).Value = Now
            Else
                If Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value = False Then
                    Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value = True
                    Me.View_Tran_INDataGridView.Item(19, e.RowIndex).Value = Now
                Else
                    Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value = False
                    Me.View_Tran_INDataGridView.Item(19, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub View_Tran_INDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles View_Tran_INDataGridView.CellEnter

        'If e.ColumnIndex = 18 Then
        '    If Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value Is DBNull.Value Then
        '        Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value = True
        '        Me.View_Tran_INDataGridView.Item(19, e.RowIndex).Value = Now
        '    Else
        '        If Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value = False Then
        '            Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value = True
        '            Me.View_Tran_INDataGridView.Item(19, e.RowIndex).Value = Now
        '        Else
        '            Me.View_Tran_INDataGridView.Item(18, e.RowIndex).Value = False
        '            Me.View_Tran_INDataGridView.Item(19, e.RowIndex).Value = DBNull.Value
        '        End If
        '    End If
        'End If
    End Sub
    Dim BtnMsg As DialogResult
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            BtnMsg = MessageBox.Show("Are You Sure Want To Verify All ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If BtnMsg = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To Me.View_Tran_INDataGridView.RowCount - 1
                    Me.View_Tran_INDataGridView(18, i).Value = True
                    Me.View_Tran_INDataGridView(19, i).Value = Now
                    'Me.View_Tran_INDataGridView(14, i).Value = frmLoginVer.UserID
                Next
                CheckBox1.CheckState = CheckState.Unchecked
            End If
            'ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
            '    BtnMsg = MessageBox.Show("Are You Sure Want To Un-Check All SBA1 Label Status ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            '    If BtnMsg = Windows.Forms.DialogResult.Yes Then
            '        For i As Integer = 0 To Me.Tbl_Pro_PO_HDataGridView.RowCount - 1
            '            Me.Tbl_Pro_PO_HDataGridView(11, i).Value = False
            '        Next
            '    End If
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loadData()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loadData()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        loadData()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        loadData()
    End Sub

    Private Sub View_Tran_INDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_Tran_INDataGridView.DataError

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Me.View_Audit_Billing_verficationTableAdapter.FillBy1(DSDemand.view_Audit_Billing_verfication, TextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.View_Audit_Billing_verficationBindingSource.RemoveFilter()
    End Sub
End Class