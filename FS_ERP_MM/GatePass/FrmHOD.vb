Public Class FrmHOD





    Private Sub LoadData()

        If RadioButton4.Checked = True Then '' pending
            Try
                Me.Tbl_Mat_GatePass_Details_HODTableAdapter.Fill(Me.DSLocalPur.tbl_Mat_GatePass_Details_HOD, LocalCustIDLabel1.Text, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
            Me.Tbl_Mat_GatePass_Details_HODDataGridView.Columns(11).Visible = False
            Label3.Visible = False
        ElseIf RadioButton2.Checked = True Then '' Approved
            Try
                Me.Tbl_Mat_GatePass_Details_HODTableAdapter.FillBy2(Me.DSLocalPur.tbl_Mat_GatePass_Details_HOD, LocalCustIDLabel1.Text, DateTimePicker1.Text, DateTimePicker2.Text)
                Tbl_Mat_GatePass_Details_HODDataGridView.ReadOnly = True
            Catch ex As Exception

            End Try

            Me.Tbl_Mat_GatePass_Details_HODDataGridView.Columns(11).Visible = False
            Label3.Visible = False
        ElseIf RadioButton3.Checked = True Then '' DisApproved
            Try
                Me.Tbl_Mat_GatePass_Details_HODTableAdapter.FillBy3(Me.DSLocalPur.tbl_Mat_GatePass_Details_HOD, LocalCustIDLabel1.Text, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
            Me.Tbl_Mat_GatePass_Details_HODDataGridView.Columns(11).Visible = False
            Label3.Visible = False
        ElseIf RadioButton1.Checked = True Then '' All
            Tbl_Mat_GatePass_Details_HODDataGridView.ReadOnly = True

            Try
                Me.Tbl_Mat_GatePass_Details_HODTableAdapter.FillBy4(Me.DSLocalPur.tbl_Mat_GatePass_Details_HOD, DateTimePicker1.Text, DateTimePicker2.Text, LocalCustIDLabel1.Text)
            Catch ex As Exception

            End Try

            Me.Tbl_Mat_GatePass_Details_HODDataGridView.Columns(11).Visible = True
            Label3.Visible = True
        End If

    End Sub
    Private Sub FrmHODApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.View_userDeptTableAdapter.Fill(Me.DSLocalPur.View_userDept, frmLoginVer.UserID)
        Catch ex As System.Exception

        End Try
        LoadData()

    End Sub

    Private Sub Tbl_Mat_GatePass_Details_HODBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Mat_GatePass_Details_HODBindingNavigatorSaveItem.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Mat_GatePass_Details_HODBindingSource.EndEdit()
            Me.Tbl_Mat_GatePass_Details_HODTableAdapter.Update(Me.DSLocalPur.tbl_Mat_GatePass_Details_HOD)
            LoadData()

            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadData()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
        Me.Tbl_Mat_GatePass_Details_HODBindingSource.RemoveFilter()
        ToolStripTextBox1.Text = ""
    End Sub

    Private Sub Tbl_Mat_GatePass_Details_HODDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Mat_GatePass_Details_HODDataGridView.CellContentClick
        If e.ColumnIndex = 6 Then
            If Me.Tbl_Mat_GatePass_Details_HODDataGridView.Item(6, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Mat_GatePass_Details_HODDataGridView.Item(6, e.RowIndex).Value = True
                Me.Tbl_Mat_GatePass_Details_HODDataGridView.Item(7, e.RowIndex).Value = Now


            Else
                If Me.Tbl_Mat_GatePass_Details_HODDataGridView.Item(6, e.RowIndex).Value = False Then
                    Me.Tbl_Mat_GatePass_Details_HODDataGridView.Item(6, e.RowIndex).Value = True
                    Me.Tbl_Mat_GatePass_Details_HODDataGridView.Item(7, e.RowIndex).Value = Now
                Else
                    Me.Tbl_Mat_GatePass_Details_HODDataGridView.Item(6, e.RowIndex).Value = False
                    Me.Tbl_Mat_GatePass_Details_HODDataGridView.Item(7, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub Tbl_Mat_GatePass_Details_HODDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Mat_GatePass_Details_HODDataGridView.CellEnter
        If e.ColumnIndex = 6 Then
            Me.Tbl_Mat_GatePass_Details_HODDataGridView.Item(8, e.RowIndex).Value = frmLoginVer.UserID
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        LoadData()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        LoadData()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        LoadData()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Tbl_Mat_GatePass_Details_HODBindingSource.Filter = "GPNo = " & Val(ToolStripTextBox1.Text)


        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub
    Dim BtnMsg As DialogResult
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            BtnMsg = MessageBox.Show("Are You Sure Want To Verify All ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If BtnMsg = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To Me.Tbl_Mat_GatePass_Details_HODDataGridView.RowCount - 1
                    Me.Tbl_Mat_GatePass_Details_HODDataGridView(6, i).Value = True
                    Me.Tbl_Mat_GatePass_Details_HODDataGridView(7, i).Value = Now
                    Me.Tbl_Mat_GatePass_Details_HODDataGridView(8, i).Value = frmLoginVer.UserID
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

    'Private Sub FillToolStripButton_Click_1(sender As Object, e As EventArgs)
    '    Try
    '        Me.View_GM_ApprovalTableAdapter.Fill(Me.DSLocalPur.View_GM_Approval, New System.Nullable(Of Date)(CType(EnteryDateToolStripTextBox.Text, Date)), New System.Nullable(Of Date)(CType(EnteryDate1ToolStripTextBox.Text, Date)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class