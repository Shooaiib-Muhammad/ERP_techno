Public Class FrmGM

    Dim Filter As String = ""
    Dim Path As String = ""
    Dim parameter As String = ""
    Dim objRptViewer As New Class_Utility



    Private Sub LoadData()
        Try

        Catch ex As Exception

        End Try
        If RadioButton4.Checked = True Then '' pending
            Try
                Me.View_GM_ApprovalTableAdapter.Fill(Me.DSLocalPur.View_GM_Approval, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
            CheckBox1.Visible = True
        ElseIf RadioButton2.Checked = True Then '' Approved
            Try
                Me.View_GM_ApprovalTableAdapter.FillBy(Me.DSLocalPur.View_GM_Approval, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
            CheckBox1.Visible = False
        ElseIf RadioButton3.Checked = True Then '' DisApproved
            Try
                Me.View_GM_ApprovalTableAdapter.FillBy1(Me.DSLocalPur.View_GM_Approval, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
            CheckBox1.Visible = False
        ElseIf RadioButton1.Checked = True Then '' All
            Try
                Me.View_GM_ApprovalTableAdapter.FillBy2(Me.DSLocalPur.View_GM_Approval, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
            CheckBox1.Visible = False
        End If
    End Sub
    Private Sub FrmHODApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Try
            Me.View_userDeptTableAdapter.Fill(Me.DSLocalPur.View_userDept, frmLoginVer.UserID)
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub Tbl_Mat_GatePass_Details_HODBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Mat_GatePass_Details_HODBindingNavigatorSaveItem.Click
        Try
            Me.ValidateChildren()
            Me.View_GM_ApprovalBindingSource.EndEdit()
            Me.View_GM_ApprovalTableAdapter.Update(Me.DSLocalPur.View_GM_Approval)
            Me.View_GM_ApprovalTableAdapter.Fill(Me.DSLocalPur.View_GM_Approval, DateTimePicker1.Text, DateTimePicker2.Text)
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
        Me.View_GM_ApprovalBindingSource.RemoveFilter()
    End Sub



    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

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
        LoadData()
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.View_GM_ApprovalBindingSource.Filter = "GPNo = " & Val(ToolStripTextBox1.Text)


        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub View_GM_ApprovalDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_GM_ApprovalDataGridView.CellContentClick
        If e.ColumnIndex = 12 Then
            If Me.View_GM_ApprovalDataGridView.Item(12, e.RowIndex).Value Is DBNull.Value Then
                Me.View_GM_ApprovalDataGridView.Item(12, e.RowIndex).Value = True
                Me.View_GM_ApprovalDataGridView.Item(13, e.RowIndex).Value = Now
            Else
                If Me.View_GM_ApprovalDataGridView.Item(12, e.RowIndex).Value = False Then
                    Me.View_GM_ApprovalDataGridView.Item(12, e.RowIndex).Value = True
                    Me.View_GM_ApprovalDataGridView.Item(13, e.RowIndex).Value = Now
                Else
                    Me.View_GM_ApprovalDataGridView.Item(12, e.RowIndex).Value = False
                    Me.View_GM_ApprovalDataGridView.Item(13, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub View_GM_ApprovalDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles View_GM_ApprovalDataGridView.CellEnter
        If e.ColumnIndex = 12 Then
            Me.View_GM_ApprovalDataGridView.Item(14, e.RowIndex).Value = frmLoginVer.UserID
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim GP As Int16 = InputBox("Enter GP Number")

        Path = "\\server\MyReports$\FSERPMM\GatePass\RptGatePass_new.rpt"
            Filter = "{View_Mat_SalesDetails.CancelationStatus} = 'Active' And {View_Mat_SalesDetails.GPNo} = " & GP & ""
            objRptViewer.LoadReports(Path, Filter, parameter)


    End Sub
    Dim BtnMsg As DialogResult
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            BtnMsg = MessageBox.Show("Are You Sure Want To Verify All ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If BtnMsg = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To Me.View_GM_ApprovalDataGridView.RowCount - 1
                    Me.View_GM_ApprovalDataGridView(12, i).Value = True
                    Me.View_GM_ApprovalDataGridView(13, i).Value = Now
                    Me.View_GM_ApprovalDataGridView(14, i).Value = frmLoginVer.UserID
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

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub
End Class