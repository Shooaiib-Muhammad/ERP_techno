Public Class frmGPApp
    'Private Sub Tbl_Mat_GatePass_Details_GMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Mat_GatePass_Details_GMBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.Tbl_Mat_GatePass_Details_GMBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DSLocalPur)

    'End Sub

    Private Sub frmGPApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUM.tbl_User_Logins' table. You can move, or remove it, as needed.
        Me.Tbl_User_LoginsTableAdapter.Fill(Me.DSUM.tbl_User_Logins)
        'TODO: This line of code loads data into the 'DSLocalCust.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSLocalCust.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSLocalPur.tbl_Mat_ItemsLayer4' table. You can move, or remove it, as needed.
        Me.Tbl_Mat_ItemsLayer4TableAdapter.Fill(Me.DSLocalPur.tbl_Mat_ItemsLayer4)
        'TODO: This line of code loads data into the 'DSLocalPur.tbl_Mat_GatePass_Details_GM' table. You can move, or remove it, as needed.
        LoadData()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
        Me.Tbl_Mat_GatePass_Details_GMBindingSource.RemoveFilter()
        ToolStripTextBox1.Text = ""
    End Sub

    Private Sub Tbl_Mat_GatePass_Details_GMDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Mat_GatePass_Details_GMDataGridView.CellContentClick
        If e.ColumnIndex = 10 Then
            If Me.Tbl_Mat_GatePass_Details_GMDataGridView.Item(10, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Mat_GatePass_Details_GMDataGridView.Item(10, e.RowIndex).Value = True
                Me.Tbl_Mat_GatePass_Details_GMDataGridView.Item(11, e.RowIndex).Value = Now
            Else
                If Me.Tbl_Mat_GatePass_Details_GMDataGridView.Item(10, e.RowIndex).Value = False Then
                    Me.Tbl_Mat_GatePass_Details_GMDataGridView.Item(10, e.RowIndex).Value = True
                    Me.Tbl_Mat_GatePass_Details_GMDataGridView.Item(11, e.RowIndex).Value = Now
                Else
                    Me.Tbl_Mat_GatePass_Details_GMDataGridView.Item(10, e.RowIndex).Value = False
                    Me.Tbl_Mat_GatePass_Details_GMDataGridView.Item(12, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Mat_GatePass_Details_GMDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Mat_GatePass_Details_GMDataGridView.DataError

    End Sub

    Private Sub Tbl_Mat_GatePass_Details_GMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Mat_GatePass_Details_GMBindingNavigatorSaveItem.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Mat_GatePass_Details_GMBindingSource.EndEdit()
            Me.Tbl_Mat_GatePass_Details_GMTableAdapter.Update(Me.DSLocalPur.tbl_Mat_GatePass_Details_GM)
            LoadData()

            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Mat_GatePass_Details_GMDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Mat_GatePass_Details_GMDataGridView.CellEnter
        If e.ColumnIndex = 10 Then
            Me.Tbl_Mat_GatePass_Details_GMDataGridView.Item(21, e.RowIndex).Value = frmLoginVer.UserID
        End If
    End Sub
    Private Sub LoadData()
        If RadioButton4.Checked = True Then '' pending
            Try
                Me.Tbl_Mat_GatePass_Details_GMTableAdapter.Fill(Me.DSLocalPur.tbl_Mat_GatePass_Details_GM, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
        ElseIf RadioButton2.Checked = True Then '' Approved
            Try
                Me.Tbl_Mat_GatePass_Details_GMTableAdapter.FillBy(Me.DSLocalPur.tbl_Mat_GatePass_Details_GM, DateTimePicker1.Text, DateTimePicker2.Text)
                Tbl_Mat_GatePass_Details_GMDataGridView.ReadOnly = True
            Catch ex As Exception

            End Try
        ElseIf RadioButton3.Checked = True Then '' DisApproved
            Try
                Me.Tbl_Mat_GatePass_Details_GMTableAdapter.FillBy1(Me.DSLocalPur.tbl_Mat_GatePass_Details_GM, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
        ElseIf RadioButton1.Checked = True Then ' All
            Try
                Me.Tbl_Mat_GatePass_Details_GMTableAdapter.FillBy2(Me.DSLocalPur.tbl_Mat_GatePass_Details_GM, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        loadData()
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

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadData()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadData()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        LoadData()
        Me.Tbl_Mat_GatePass_Details_GMBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Tbl_Mat_GatePass_Details_GMBindingSource.Filter = "GPNo = " & Val(ToolStripTextBox1.Text)


        End If
    End Sub


End Class