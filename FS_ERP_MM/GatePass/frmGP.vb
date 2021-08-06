Public Class frmGP

    Dim GlobalFlag As Integer

    Private Sub SaveDemand()
        Dim k As Int16 = Me.Tbl_Mat_GatePass_DetailsBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Mat_GatePass_DetailsBindingSource.EndEdit()
            Me.Tbl_Mat_GatePass_DetailsTableAdapter.Update(Me.DSLocalPur.tbl_Mat_GatePass_Details)
            Me.Tbl_Mat_GatePass_DetailsTableAdapter.FillBy(Me.DSLocalPur.tbl_Mat_GatePass_Details, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            Me.Tbl_Mat_GatePass_DetailsBindingSource.Position = k
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmAddDemands_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then    'Ctrl+S for Save
            SaveDemand()
        ElseIf e.Control And e.KeyCode = Keys.A Then    'Ctrl+A for Add New Demand
            Me.Tbl_Mat_GatePassBindingSource.AddNew()
            EnteryDateLabel1.Text = Now.Date
            PreparedByTextBox.Text = Val(frmLoginVer.UserID)
            PreparedDeptID.Text = Val(frmLoginVer.DeptID)
        End If

    End Sub

    Private Sub frmAddDemands_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSLocalPur.tbl_GP_Customer' table. You can move, or remove it, as needed.
        Me.Tbl_GP_CustomerTableAdapter.Fill(Me.DSLocalPur.tbl_GP_Customer)
        Me.Tbl_Mat_Inter_DeptTableAdapter.Fill(Me.DSLocalPur.tbl_Mat_Inter_Dept)
        Try
            Me.Tbl_Mat_ItemsLayer4TableAdapter.Fill(Me.DSLocalPur.tbl_Mat_ItemsLayer4)
        Catch ex As Exception

        End Try
        Me.Tbl_Mat_MeasurementUnitsTableAdapter.Fill(Me.DSLocalPur.tbl_Mat_MeasurementUnits)
        DateTimePicker1.Value = Now.Date
        loadData()
        Me.Tbl_Mat_GatePassBindingSource.Position = Me.Tbl_Mat_GatePassBindingSource.Count
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        loadData()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        loadData()
    End Sub

    Private Sub Tbl_Pur_Demand_HeadBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadData()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If TextBox4.Text.Length > 0 Then

            Dim position As Integer = Tbl_Mat_GatePassBindingSource.Position
            Me.Validate()
            Me.Tbl_Mat_GatePassBindingSource.EndEdit()
            Me.Tbl_Mat_GatePassTableAdapter.Update(Me.DSLocalPur.tbl_Mat_GatePass)

            'Dim position As Integer = Val(BindingNavigatorPositionItem1.Text)
            MsgBox("Record Saved")
            Me.Tbl_Mat_GatePassTableAdapter.FillBy(Me.DSLocalPur.tbl_Mat_GatePass, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, frmLoginVer.UserID)

            Me.Tbl_Mat_GatePassBindingSource.Position = position
            loadprintbtn()
            Try
                'Me.Tbl_Mat_GatePass1TableAdapter.UpdateDeptID(Val(frmLogin.Department), GMNoLabel4.Text)
            Catch ex As Exception
            End Try
        Else
            MsgBox("Kindly Select Party Name first")

        End If

    End Sub
    Private Sub loadprintbtn()

        If LocalCustIDComboBox.Text = "OUTWARD" Or LocalCustIDComboBox.Text = "RETURNABLE" Then

            Button1.Visible = False
        Else
            Button1.Visible = True
        End If
    End Sub

    Private Sub loadData()
        If frmLoginVer.DeptID = 10 Then 'ERP_MM Admin
            Me.Tbl_Mat_GatePassTableAdapter.FillBy2(Me.DSLocalPur.tbl_Mat_GatePass, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Else
            Me.Tbl_Mat_GatePassTableAdapter.FillBy(Me.DSLocalPur.tbl_Mat_GatePass, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, frmLoginVer.UserID)
        End If
        Me.Tbl_Mat_GatePass_DetailsTableAdapter.FillBy(Me.DSLocalPur.tbl_Mat_GatePass_Details, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        'Me.Tbl_Mat_GatePass_DetailsTableAdapter.Fill(Me.DSLocalPur.tbl_Mat_GatePass_Details)
        Me.Tbl_Mat_GatePass_DetailsBindingSource.Position = Me.Tbl_Mat_GatePass_DetailsBindingSource.Count
        Try
            Me.View_userDeptTableAdapter.Fill(Me.DSLocalPur.View_userDept, frmLoginVer.UserID)
        Catch ex As Exception

        End Try

        loadPrintBtn()
    End Sub

    Private Sub Tbl_Mat_GatePass_DetailsDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Mat_GatePass_DetailsDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub

    Private Sub Tbl_Mat_GatePass_DetailsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Mat_GatePass_DetailsDataGridView.DataError

    End Sub

    Private Sub Tbl_Pur_DemandBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_DemandBindingNavigatorSaveItem.Click
        SaveDemand()
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Tbl_Mat_GatePassBindingSource.Filter = "GPNo = " & Val(ToolStripTextBox1.Text)
            ToolStripTextBox1.Clear()
            FilterByGDNo.Visible = False
        End If
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_Mat_GatePassBindingSource.RemoveFilter()
        Me.Tbl_Mat_GatePassBindingSource.Position = Me.Tbl_Mat_GatePassBindingSource.Count - 1
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Me.Tbl_Mat_GatePassBindingSource.AddNew()
        GMNoLabel4.Text = Val(Me.Tbl_Mat_GatePassTableAdapter.Max() + 1)
        EnteryDateLabel1.Text = Now.Date
        PreparedByTextBox.Text = Val(frmLoginVer.UserID)
        PreparedDeptID.Text = Val(frmLoginVer.DeptID)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objFrmFilter As New frmRptViewer

        Filter = "{View_Mat_SalesDetails.CancelationStatus} = 'Active' And {View_Mat_SalesDetails.GPNo} = " & Val(GMNoLabel4.Text) & ""
        Path = "" & frmLoginVer.Reportpath & "\RptGatePass.rpt"
        objFrmFilter.ViewReport(Path, Filter)

        objFrmFilter.MdiParent = frmMain
        objFrmFilter.Show()
    End Sub

    Private Sub CarryingPersonTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarryingPersonTextBox.TextChanged

    End Sub

    Private Sub CarryingPersonLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Tbl_Mat_GatePass_DetailsDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles Tbl_Mat_GatePass_DetailsDataGridView.CellContentClick

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Me.Tbl_Mat_GatePassBindingSource.RemoveCurrent()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click_1(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Tbl_Mat_GatePass_DetailsDataGridView_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Tbl_Mat_GatePass_DetailsDataGridView.CellPainting



    End Sub

    Private Sub Tbl_Mat_GatePass_DetailsDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Mat_GatePass_DetailsDataGridView.CellEnter
        If e.ColumnIndex = 1 Then
            Me.Tbl_Mat_GatePass_DetailsDataGridView.Item(5, e.RowIndex).Value = frmLoginVer.UserID
            Me.Tbl_Mat_GatePass_DetailsDataGridView.Item(8, e.RowIndex).Value = Now.Date
            Me.Tbl_Mat_GatePass_DetailsDataGridView.Item(6, e.RowIndex).Value = LocalCustIDLabel2.Text
        End If

    End Sub

    Private Sub Tbl_Mat_GatePass_DetailsDataGridView_CellToolTipTextChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Mat_GatePass_DetailsDataGridView.CellToolTipTextChanged

    End Sub

    Private Sub Tbl_Mat_GatePassBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Mat_GatePassBindingSource.PositionChanged
        loadprintbtn()
    End Sub
End Class