Public Class Machines
    Dim Scheduling As Int16




    Private Sub Machines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMMS.tbl_DMMS_Scheduling_Parmeters' table. You can move, or remove it, as needed.
        load()
        'TODO: This line of code loads data into the 'DMMS.tbl_PIR_Section' table. You can move, or remove it, as needed.
        Me.Tbl_PIR_SectionTableAdapter.Fill(Me.DMMS.tbl_PIR_Section)
        'TODO: This line of code loads data into the 'DMMS.tbl_PIR_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_PIR_DeptTableAdapter.Fill(Me.DMMS.tbl_PIR_Dept)

    End Sub
    Private Sub load()
        Me.Tbl_DMMS_MachinesTableAdapter.Fill(Me.DMMS.tbl_DMMS_Machines)
        If RadioButton1.Checked = True Then
            Me.Tbl_DMMS_Scheduling_ParmetersTableAdapter.FillBy(Me.DMMS.tbl_DMMS_Scheduling_Parmeters)
        ElseIf RadioButton2.Checked = True Then
            Me.Tbl_DMMS_Scheduling_ParmetersTableAdapter.FillBy1(Me.DMMS.tbl_DMMS_Scheduling_Parmeters)
        ElseIf RadioButton3.Checked = True Then
            Me.Tbl_DMMS_Scheduling_ParmetersTableAdapter.FillBy2(Me.DMMS.tbl_DMMS_Scheduling_Parmeters)
        ElseIf RadioButton4.Checked = True Then
            Me.Tbl_DMMS_Scheduling_ParmetersTableAdapter.FillBy3(Me.DMMS.tbl_DMMS_Scheduling_Parmeters)
        ElseIf RadioButton5.Checked = True Then
            Me.Tbl_DMMS_Scheduling_ParmetersTableAdapter.FillBy5(Me.DMMS.tbl_DMMS_Scheduling_Parmeters)
        ElseIf RadioButton6.Checked = True Then
            Me.Tbl_DMMS_Scheduling_ParmetersTableAdapter.FillBy4(Me.DMMS.tbl_DMMS_Scheduling_Parmeters)

        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim postion As Integer = Tbl_DMMS_MachinesBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_DMMS_MachinesBindingSource.EndEdit()
            Me.Tbl_DMMS_MachinesTableAdapter.Update(Me.DMMS.tbl_DMMS_Machines)
            Tbl_PIR_DeptTableAdapter.UpdateQuery(CheckBox1.CheckState, Label3.Text)
            load()
            Tbl_DMMS_MachinesBindingSource.Position = postion
            MsgBox("Data Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim postion As Integer = Tbl_DMMS_Scheduling_ParmetersBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_DMMS_Scheduling_ParmetersBindingSource.EndEdit()
            Me.Tbl_DMMS_Scheduling_ParmetersTableAdapter.Update(Me.DMMS.tbl_DMMS_Scheduling_Parmeters)

            Tbl_DMMS_Scheduling_ParmetersBindingSource.Position = postion
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load()
        Catch ex As Exception
            MessageBox.Show("Record Not Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        load()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        load()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        load()
    End Sub

    Private Sub Tbl_DMMS_Scheduling_ParmetersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_DMMS_Scheduling_ParmetersDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_DMMS_Scheduling_ParmetersDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_DMMS_Scheduling_ParmetersDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            If RadioButton1.Checked = True Then

                If Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value = RadioButton1.Text
                End If
            ElseIf RadioButton2.Checked = True Then
                If Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value = RadioButton2.Text
                End If
            ElseIf RadioButton3.Checked = True Then
                If Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value = RadioButton3.Text
                End If
            ElseIf RadioButton4.Checked = True Then
                If Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value = RadioButton4.Text
                End If
            ElseIf RadioButton6.Checked = True Then
                If Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value = RadioButton6.Text
                End If
            ElseIf RadioButton5.Checked = True Then
                If Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_DMMS_Scheduling_ParmetersDataGridView(0, e.RowIndex).Value = RadioButton5.Text
                End If
            End If

        End If
    End Sub

    Private Sub Tbl_DMMS_Scheduling_ParmetersDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_DMMS_Scheduling_ParmetersDataGridView.DataError

    End Sub

    Private Sub Tbl_PIR_DeptBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_PIR_DeptBindingSource.PositionChanged
        load()
    End Sub

    Private Sub Tbl_PIR_SectionBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_PIR_SectionBindingSource.PositionChanged
        load()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        load()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        load()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        load()
    End Sub


End Class