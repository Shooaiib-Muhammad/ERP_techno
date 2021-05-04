Public Class frmVerifyDemand

    Private Sub Tbl_Pur_DemandBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_DemandBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Pur_DemandBindingSource.EndEdit()
            Me.Tbl_Pur_DemandTableAdapter.Update(Me.DSPO.tbl_Pur_Demand)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmVerifyDemand_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub
    Private Sub frmVerifyDemand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSLocalSale.tbl_PIR_Users' table. You can move, or remove it, as needed.
        Me.Tbl_PIR_UsersTableAdapter.Fill(Me.DSLocalSale.tbl_PIR_Users)
        'TODO: This line of code loads data into the 'DsUOM.View_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_Demand_PeriorityTableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Periority)
        DateTimePicker1.Value = Now.Date.AddMonths(-6)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSPO.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        Me.Tbl_Pur_DemandTableAdapter.FillBy(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        If RadioButton4.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy9(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        End If
        KeyPreview = True
    End Sub
    Dim Obj As New Class_Utility
    Private Sub Tbl_Pur_DemandDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellContentClick
        If e.ColumnIndex = 12 Then
            If DBNull.Value.Equals(Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value) Then
                Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = True
                Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = Now
                Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = Obj.USerIDValue
            Else
                If Me.Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = False Then
                    Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = True
                    Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = Now
                    Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = Obj.USerIDValue
                Else
                    Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = False
                    Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            If RadioButton1.Checked Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
            ElseIf RadioButton2.Checked Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy7(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
            ElseIf RadioButton3.Checked Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy8(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
            ElseIf RadioButton4.Checked Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy9(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If RadioButton1.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        ElseIf RadioButton2.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy7(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        ElseIf RadioButton3.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy8(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        ElseIf RadioButton4.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy9(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy7(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy8(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Try
                Me.Tbl_Pur_DemandTableAdapter.FillBy9(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub ToRefresh()
        If RadioButton1.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        ElseIf RadioButton2.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy7(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        ElseIf RadioButton3.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy8(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        ElseIf RadioButton4.Checked Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy9(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ToRefresh()
        If Tbl_Pur_DemandDataGridView.RowCount = 0 Then
            Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim btnMsg As DialogResult
        btnMsg = MessageBox.Show("Are You Sure Want To Verify All Demands ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Dim i As Integer
            For i = 0 To Tbl_Pur_DemandDataGridView.RowCount - 1
                If Me.Tbl_Pur_DemandDataGridView.Item(9 + 2, i).Value Is DBNull.Value Then
                    Me.Tbl_Pur_DemandDataGridView.Item(9 + 2, i).Value = True
                    Me.Tbl_Pur_DemandDataGridView.Item(10 + 2, i).Value = Now
                    Me.Tbl_Pur_DemandDataGridView.Item(12 + 1, i).Value = Obj.USerIDValue
                Else
                    If Me.Tbl_Pur_DemandDataGridView.Item(8 + 3, i).Value = False Then
                        Me.Tbl_Pur_DemandDataGridView.Item(8 + 3, i).Value = True
                        Me.Tbl_Pur_DemandDataGridView.Item(9 + 3, i).Value = Now
                        Me.Tbl_Pur_DemandDataGridView.Item(12 + 1, i).Value = Obj.USerIDValue
                    End If
                End If
            Next
        End If
    End Sub
    Dim Deptflag As Boolean = False

    Private Sub Tbl_Pur_DemandDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellEnter
        Dim NewCode As String = Me.Tbl_Pur_DemandDataGridView(3, e.RowIndex).Value
        Try
            Me.View_L4TableAdapter.Fill(Me.DsUOM.View_L4, NewCode)
            Me.Tbl_Pur_DemandDataGridView(9, e.RowIndex).Value = Me.DsUOM.View_L4.Rows(0).Item("CPPU")
            Me.Tbl_Pur_DemandDataGridView(10, e.RowIndex).Value = Me.DsUOM.View_L4.Rows(0).Item("Unit")
            Me.Tbl_Pur_DemandDataGridView(8, e.RowIndex).Value = Me.DsUOM.View_L4.Rows(0).Item("Description")

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Tbl_Pur_DemandDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Tbl_Pur_DemandDataGridView.CellMouseDown
        If e.ColumnIndex = 1 Then
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Deptflag = False
            End If
        ElseIf e.ColumnIndex = 7 Then
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Deptflag = True
            End If
        End If
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_DemandDataGridView.DataError

    End Sub

    Private Sub txtVD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtVD.TextLength > 0 Then
                If Deptflag = True Then
                    Dim Custid As Integer
                    Try
                        Custid = Me.Tbl_Inv_LocalCustTableAdapter.CustID(Me.txtVD.Text)
                    Catch ex As Exception
                        Custid = 0
                    End Try
                    If Custid > 0 Then
                        Me.Tbl_Pur_DemandBindingSource.Filter = "LocalCustId=" & Custid & ""
                        Me.txtVD.Text = Nothing
                        Me.CMVD.Hide()
                    Else
                        MsgBox("No Such Department Exist", MsgBoxStyle.Information)
                        Me.txtVD.Text = Nothing
                        Me.CMVD.Hide()
                    End If
                Else
                    Me.Tbl_Pur_DemandBindingSource.Filter = "GMNO=" & Me.txtVD.Text & ""
                    Me.txtVD.Text = Nothing
                    Me.CMVD.Hide()
                End If
            Else
                MsgBox("Enter Department Name To Filter Records", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Pur_DemandDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub txtVD_Click(sender As Object, e As EventArgs) Handles txtVD.Click

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_GotFocus(sender As Object, e As EventArgs) Handles ToolStripTextBox1.GotFocus



    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown

    End Sub

    Private Sub ToolStripTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ToolStripTextBox1.KeyPress

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        If ToolStripTextBox1.TextLength > 0 Then
            Me.Tbl_Pur_DemandBindingSource.Filter = "GMNO=" & Me.ToolStripTextBox1.Text & ""
        Else
            Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
        End If

    End Sub
End Class