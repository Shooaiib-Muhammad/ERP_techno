Public Class frmAddDemands
    Dim GlobalFlag As Integer

    Private Sub SaveDemand()
        Try
            Me.Validate()
            Me.Tbl_Pur_DemandBindingSource.EndEdit()
            Me.Tbl_Pur_DemandTableAdapter.Update(Me.DSPO.tbl_Pur_Demand)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Pur_DemandBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_DemandBindingNavigatorSaveItem.Click
        Try
            If GlobalFlag = 1 Then
                PDDateLabel2.Text = Now.ToShortDateString()
                SaveDemand()
            Else
                SaveDemand()
            End If
            GlobalFlag = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmAddDemands_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Pur_Demand_HeadTableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Head)
        Catch ex As Exception
        End Try
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSPO.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        DateTimePicker1.Value = Now.Date.AddMonths(-1)
        Me.Tbl_Pur_DemandTableAdapter.FillBy29(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Me.Tbl_Pur_Demand_HeadBindingSource.Position = Me.Tbl_Pur_Demand_HeadBindingSource.Count
        Me.Tbl_Pur_DemandBindingSource.Position = Me.Tbl_Pur_DemandBindingSource.Count
        KeyPreview = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Me.Tbl_Pur_DemandTableAdapter.FillBy29(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            Me.Tbl_Pur_DemandBindingSource.Position = Me.Tbl_Pur_DemandBindingSource.Count
        Catch ex As Exception
        End Try
        GlobalFlag = 0
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        GlobalFlag = 1
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Me.Tbl_Pur_DemandTableAdapter.FillBy29(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Me.Tbl_Pur_DemandBindingSource.Position = Me.Tbl_Pur_DemandBindingSource.Count
        GlobalFlag = 0
    End Sub

    Private Sub Tbl_Pur_Demand_HeadBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_Demand_HeadBindingSource.PositionChanged
        Me.Tbl_Pur_DemandTableAdapter.FillBy29(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Me.Tbl_Pur_DemandBindingSource.Position = Me.Tbl_Pur_DemandBindingSource.Count
        GlobalFlag = 0
    End Sub

    Private Sub DemandStatusComboBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemandStatusComboBox.Enter
        If GlobalFlag = 1 Then
            Me.DemandStatusComboBox.Text = ""
            Me.DemandStatusComboBox.SelectedText = Me.DemandStatusComboBox.Items.Item(0)
        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Tbl_Pur_Demand_HeadBindingSource.Filter = "GMNo = " & Val(ToolStripTextBox1.Text)
            ToolStripTextBox1.Clear()
            FilterByGDNo.Visible = False
        End If
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_Pur_Demand_HeadBindingSource.RemoveFilter()
        Me.Tbl_Pur_Demand_HeadBindingSource.Position = Me.Tbl_Pur_Demand_HeadBindingSource.Count - 1
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveNewGDNo()
    End Sub

    Private Sub SaveNewGDNo()
        Me.Tbl_Pur_Demand_HeadBindingSource.AddNew()
        EnteryDateLabel1.Text = Now.ToShortDateString()

        Me.Validate()
        Me.Tbl_Pur_Demand_HeadBindingSource.EndEdit()
        Me.Tbl_Pur_Demand_HeadTableAdapter.Update(Me.DSPO.tbl_Pur_Demand_Head)
        MsgBox("Record Saved")
        CodeComboBox.Focus()
    End Sub

    Private Sub frmAddDemands_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim dgResult As DialogResult
        If e.Control And e.KeyCode = Keys.S Then    'Ctrl+S For Save
            If GlobalFlag = 1 Then
                PDDateLabel2.Text = Now.ToShortDateString()
                SaveDemand()
            Else
                SaveDemand()
            End If
            GlobalFlag = 0
            CodeComboBox.Focus()
        ElseIf e.Control And e.KeyCode = Keys.A Then    'Ctrl+A for Add New Demand
            If GMNoLabel4.Text <> "" Then
                Me.Tbl_Pur_DemandBindingSource.AddNew()
                PDDateLabel2.Text = Now.ToShortDateString()
                CodeComboBox.Focus()
                GlobalFlag = 1
            End If
        ElseIf e.Control And e.KeyCode = Keys.D Then    'Ctrl+D for Delete Demand
            If GMNoLabel4.Text <> "" Then
                If PDIDLabel1.Text <> "" Then
                    dgResult = MessageBox.Show("Are you sure you want to delete record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If dgResult = Windows.Forms.DialogResult.Yes Then
                        Me.Tbl_Pur_DemandBindingSource.RemoveCurrent()
                        SaveDemand()
                    End If
                End If
            End If
        ElseIf e.Control And e.KeyCode = Keys.G Then    'Ctrl+G for Add and Save New GD No
            SaveNewGDNo()
        End If

    End Sub

    Private Sub PDQtyTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PDQtyTextBox.TextChanged
        'If PDQtyTextBox.TextLength > 0 Then
        '    Me.CodeComboBox.DropDownStyle = ComboBoxStyle.Simple
        'Else
        '    Me.CodeComboBox.DropDownStyle = ComboBoxStyle.DropDown
        'End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub EnteryDateLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GMNoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PDIDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CodeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PDQtyLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DemandStatusLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NarrationLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UOMLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PDDateLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GMNoLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LocalCustIDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DocIDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VerificationStatusLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub
End Class