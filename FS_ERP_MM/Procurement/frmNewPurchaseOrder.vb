Public Class frmNewPurchaseOrder

    Private Sub frmNewPurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSNewPurOrders.tbl_Pur_Supplier_Code' table. You can move, or remove it, as needed.
        'Me.Tbl_Pur_Supplier_CodeTableAdapter.Fill(Me.DSNewPurOrders.tbl_Pur_Supplier_Code)
        'TODO: This line of code loads data into the 'DSNewPurOrders.View_Supplier_Items' table. You can move, or remove it, as needed.
        Me.View_Supplier_ItemsTableAdapter.Fill(Me.DSNewPurOrders.View_Supplier_Items)
        'TODO: This line of code loads data into the 'DSNewPurOrders.tbl_Inv_Supplier' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSNewPurOrders.tbl_Inv_Supplier)
        'TODO: This line of code loads data into the 'DSNewPurOrders.tbl_Pur_PO_D' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_PO_DTableAdapter.Fill(Me.DSNewPurOrders.tbl_Pur_PO_D)
        'TODO: This line of code loads data into the 'DSNewPurOrders.tbl_Pur_PO' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_POTableAdapter.Fill(Me.DSNewPurOrders.tbl_Pur_PO)
        'TODO: This line of code loads data into the 'DSNewPurOrders.tbl_inv_SupplierType' table. You can move, or remove it, as needed.
        Me.Tbl_inv_SupplierTypeTableAdapter.Fill(Me.DSNewPurOrders.tbl_inv_SupplierType)
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Pur_POBindingSource.EndEdit()
            Me.Tbl_Pur_POTableAdapter.Update(Me.DSNewPurOrders.tbl_Pur_PO)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Tbl_Pur_PO_DDataGridView_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_PO_DDataGridView.CellContentClick
        If e.ColumnIndex = 9 Then
            If Me.Tbl_Pur_PO_DDataGridView.Item(9, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Pur_PO_DDataGridView.Item(9, e.RowIndex).Value = True
                Me.Tbl_Pur_PO_DDataGridView.Item(10, e.RowIndex).Value = Now.Date
            Else
                If Me.Tbl_Pur_PO_DDataGridView.Item(9, e.RowIndex).Value = False Then
                    Me.Tbl_Pur_PO_DDataGridView.Item(9, e.RowIndex).Value = True
                    Me.Tbl_Pur_PO_DDataGridView.Item(10, e.RowIndex).Value = Now.Date
                Else
                    Me.Tbl_Pur_PO_DDataGridView.Item(9, e.RowIndex).Value = False
                    Me.Tbl_Pur_PO_DDataGridView.Item(10, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub
    Private Sub Tbl_Pur_PO_DDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_PO_DDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            If POIDLabel2.Text <> "" Then
                If Tbl_Pur_PO_DDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                    If Me.Tbl_Pur_PO_DDataGridView.RowCount > 1 Then
                        Try
                            Tbl_Pur_PO_DDataGridView(0, e.RowIndex).Value = Tbl_Pur_PO_DDataGridView(0, e.RowIndex - 1).Value + 1
                        Catch ex As Exception
                            Tbl_Pur_PO_DDataGridView(0, e.RowIndex).Value = 1
                        End Try
                        PositionPODflag = True
                        DGVAttribute(False)
                    Else
                        Tbl_Pur_PO_DDataGridView(0, e.RowIndex).Value = 1
                        PositionPODflag = True
                        DGVAttribute(False)
                    End If
                End If
            End If
        ElseIf e.ColumnIndex = 2 Then
            If Me.Tbl_Pur_PO_DDataGridView(11, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Pur_PO_DDataGridView(11, e.RowIndex).Value = Formula.Text
                Catch ex As Exception
                    Me.Tbl_Pur_PO_DDataGridView(11, e.RowIndex).Value = 0.0
                End Try
            End If
        ElseIf e.ColumnIndex = 3 Then
            PositionPODflag = False
            DGVAttribute(True)
            If Me.Tbl_Pur_PO_DDataGridView(3, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Pur_PO_DDataGridView(3, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Pur_PO_DDataGridView(5, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Pur_PO_DDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                If Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
                    If Not Me.Tbl_Pur_Supplier_CodeTableAdapter.UOM(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value) = "" Then
                        If Me.Tbl_Pur_PO_DDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                            Me.Tbl_Pur_PO_DDataGridView(3, e.RowIndex).Value = Me.Tbl_Pur_Supplier_CodeTableAdapter.UOM(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value)
                        End If
                    Else
                        MsgBox("Unit of Measurement not found....")
                    End If
                    If Not Me.Tbl_Pur_Supplier_CodeTableAdapter.UnitPrice(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value) = Nothing Then
                        If Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                            Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value = Me.Tbl_Pur_Supplier_CodeTableAdapter.UnitPrice(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value)
                        End If
                    Else
                        MsgBox("Unit Price not found....")
                    End If
                    If Not Me.Tbl_Pur_Supplier_CodeTableAdapter.OtherChargesQuery(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value) = Nothing Then
                        If Me.Tbl_Pur_PO_DDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                            Me.Tbl_Pur_PO_DDataGridView(5, e.RowIndex).Value = Me.Tbl_Pur_Supplier_CodeTableAdapter.OtherChargesQuery(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value)
                        End If
                    End If
                    If Not Me.Tbl_Pur_Supplier_CodeTableAdapter.Curency(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value) = "" Then
                        If Me.Tbl_Pur_PO_DDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                            Me.Tbl_Pur_PO_DDataGridView(7, e.RowIndex).Value = Me.Tbl_Pur_Supplier_CodeTableAdapter.Curency(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value)
                        End If
                    Else
                        MsgBox("Curency Not Found....")
                    End If
                Else
                    MsgBox("Supplier's Material value Not found...again select the material", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub
    Private Sub Tbl_Pur_PO_DDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_PO_DDataGridView.DataError

    End Sub
    Private Sub Tbl_Pur_PO_DDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Pur_PO_DDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub Tbl_Pur_PO_DBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Pur_PO_DBindingSource.PositionChanged
        If PositionPODflag = False Then
            DGVAttribute(True)
        Else
            DGVAttribute(False)
            PositionPODflag = False
        End If
    End Sub
    Private Sub ReqDateMaskedTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReqDateMaskedTextBox.TextChanged
        If Addflag = True And ReqDateMaskedTextBox.Enabled = True Then
            Try
                Me.NewReqDateMaskedTextBox.Text = Me.ReqDateMaskedTextBox.Text
            Catch ex As Exception
            End Try
        End If
    End Sub
    Dim PositionPODflag As Boolean = False
    Dim Addflag As Boolean = False
    Dim MoveBackflag As Boolean = False
    Private Sub PONOTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PONOTextBox.GotFocus
        If PONOTextBox.Text = "Enter PO Number" Then
            PONOTextBox.Text = ""
            PONOTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PONOTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PONOTextBox.KeyDown
        If e.KeyCode = Keys.Enter And Me.PONOTextBox.Text.Length > 0 And PONOTextBox.Text <> "Enter PO Number" Then
            Me.Tbl_Pur_POBindingSource.Filter = "POid =" & PONOTextBox.Text
            PONOTextBox.ForeColor = Color.Silver
            PONOTextBox.Clear()
            CMPONO.Hide()
        End If
    End Sub

    Private Sub PONOTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PONOTextBox.LostFocus
        If PONOTextBox.Text = "" Then
            PONOTextBox.Text = "Enter PO Number"
            PONOTextBox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub BindingNavigatorMovePreviousItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        If Addflag = True Then
            MoveBackflag = True
        End If
    End Sub
    Sub DGVAttribute(ByVal Value As Boolean)
        Tbl_Pur_PO_DDataGridView.Columns(0).ReadOnly = True
        Tbl_Pur_PO_DDataGridView.Columns(1).ReadOnly = Value
        Tbl_Pur_PO_DDataGridView.Columns(3).ReadOnly = Value
        Tbl_Pur_PO_DDataGridView.Columns(7).ReadOnly = Value
        Tbl_Pur_PO_DDataGridView.Columns(9).ReadOnly = Value
        Tbl_Pur_PO_DDataGridView.Columns(10).ReadOnly = Value
    End Sub
    Private Sub BindingNavigatorMoveFirstItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        If Addflag = True Then
            MoveBackflag = True

        End If
    End Sub
    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_Pur_POBindingSource.RemoveFilter()
    End Sub
    Private Sub OrderDateTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderDateTextBox.GotFocus
        If Me.OrderDateTextBox.Text = "Enter Production Order Date" Then
            Me.OrderDateTextBox.Text = ""
            Me.OrderDateTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub OrderDateTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles OrderDateTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.Tbl_Pur_POBindingSource.Filter = "PODate ='" & Me.OrderDateTextBox.Text & "'"
                Me.OrderDateTextBox.Clear()
                Me.CMOrderDate.Hide()
            End If
        Catch ex As Exception
            MsgBox("Enter Date In Correct Formate")
            Me.OrderDateTextBox.Clear()
            Me.OrderDateTextBox.Focus()
        End Try
    End Sub

    Private Sub OrderDateTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderDateTextBox.LostFocus
        If Me.OrderDateTextBox.TextLength = 0 Then
            Me.OrderDateTextBox.Text = "Enter Production Order Date"
            Me.OrderDateTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ReqDateTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReqDateTextBox.GotFocus
        If Me.ReqDateTextBox.Text = "Enter Required Date" Then
            Me.ReqDateTextBox.Text = ""
            Me.ReqDateTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ReqDateTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ReqDateTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.Tbl_Pur_POBindingSource.Filter = "ReqDate ='" & Me.ReqDateTextBox.Text & "'"
                Me.ReqDateTextBox.Clear()
                Me.CMReqDate.Hide()
            End If
        Catch ex As Exception
            MsgBox("Enter Date In Correct Formate")
            Me.ReqDateTextBox.Clear()
            Me.ReqDateTextBox.Focus()
        End Try
    End Sub

    Private Sub ReqDateTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReqDateTextBox.LostFocus
        If Me.ReqDateTextBox.TextLength = 0 Then
            Me.ReqDateTextBox.Text = "Enter Required Date"
            Me.ReqDateTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub NewReqDateTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewReqDateTextBox.GotFocus
        If Me.NewReqDateTextBox.Text = "Enter New Required Date" Then
            Me.NewReqDateTextBox.Text = ""
            Me.NewReqDateTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub NewReqDateTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NewReqDateTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.Tbl_Pur_POBindingSource.Filter = "NewReqDate ='" & Me.NewReqDateTextBox.Text & "'"
                Me.NewReqDateTextBox.Clear()
                Me.CMNewReqDate.Hide()
            End If
        Catch ex As Exception
            MsgBox("Enter Date In Correct Formate")
            Me.NewReqDateTextBox.Clear()
            Me.NewReqDateTextBox.Focus()
        End Try
    End Sub

    Private Sub NewReqDateTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewReqDateTextBox.LostFocus
        If Me.NewReqDateTextBox.TextLength = 0 Then
            Me.NewReqDateTextBox.Text = "Enter New Required Date"
            Me.NewReqDateTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Tbl_Pur_POBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_Pur_POBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Me.Tbl_Pur_POBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Tbl_Pur_POBindingSource.Sort = "ReqDate ASC"
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Tbl_Pur_POBindingSource.Sort = "ReqDate DESC"
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Me.Tbl_Pur_POBindingSource.RemoveSort()
    End Sub

    Private Sub AscendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AscendingOrderToolStripMenuItem.Click
        Me.Tbl_Pur_POBindingSource.Sort = "PODate ASC"
    End Sub

    Private Sub DescendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescendingOrderToolStripMenuItem.Click
        Me.Tbl_Pur_POBindingSource.Sort = "PODate DESC"
    End Sub

    Private Sub RemoveOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveOrderToolStripMenuItem.Click
        Me.Tbl_Pur_POBindingSource.RemoveSort()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Me.Tbl_Pur_POBindingSource.Sort = "NewReqDate ASC"
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Me.Tbl_Pur_POBindingSource.Sort = "NewReqDate DESC"
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Me.Tbl_Pur_POBindingSource.RemoveSort()
    End Sub

    Private Sub SuplierNameTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SuplierNameTextBox.GotFocus
        If Me.SuplierNameTextBox.Text = "Enter Supplier Name" Then
            Me.SuplierNameTextBox.Text = ""
            Me.SuplierNameTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SuplierNameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SuplierNameTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.Tbl_Pur_POBindingSource.Filter = "SupplierID =" & Me.Tbl_Inv_SupplierTableAdapter.SelectQuery(Me.SuplierNameTextBox.Text) & ""
                Me.SuplierNameTextBox.Clear()
                Me.CMSupplierName.Hide()
            End If
        Catch ex As Exception
            MsgBox("Supplier Name Not Match")
            Me.SuplierNameTextBox.Clear()
            Me.SuplierNameTextBox.Focus()
        End Try
    End Sub

    Private Sub SuplierNameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SuplierNameTextBox.LostFocus
        If Me.SuplierNameTextBox.TextLength = 0 Then
            Me.SuplierNameTextBox.Text = "Enter Supplier Name"
            Me.SuplierNameTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Me.Tbl_Pur_POBindingSource.RemoveFilter()
    End Sub

    Private Sub Tbl_Pur_PO_DDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_PO_DDataGridView.RowLeave
        If e.ColumnIndex = 8 Then
            Try
                Me.Tbl_Pur_PO_DBindingSource.MoveFirst()
            Catch ex As Exception
            End Try
        End If
    End Sub

    'Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
    '    ToRefresh()
    'End Sub

    'Private Sub AddSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSale.Click
    '    flag = True
    '    Me.ReqDateMaskedTextBox.ReadOnly = False
    '    Addflag = True
    '    Me.Tbl_Pur_POBindingSource.AddNew()
    '    'Me.POIDLabel2.Text = Me.Tbl_Pur_POTableAdapter.MaxPO
    'End Sub
    Private Sub frmPurOrders_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub
    Private Sub frmPOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAll()
        KeyPreview = True
        Me.Tbl_Pur_POBindingSource.MoveLast()
    End Sub
    Sub LoadAll()
        Me.View_Supplier_ItemsTableAdapter.Fill(Me.DSNewPurOrders.View_Supplier_Items)
        'Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSPurOrder.tbl_Inv_Supplier)
        Me.Tbl_Pur_PO_DTableAdapter.Fill(Me.DSNewPurOrders.tbl_Pur_PO_D)
        Me.Tbl_Pur_POTableAdapter.Fill(Me.DSNewPurOrders.tbl_Pur_PO)
        If frmLoginVer.DeptID = 24 Then
            Me.Tbl_inv_SupplierTypeTableAdapter.FillBy(Me.DSNewPurOrders.tbl_inv_SupplierType)
        Else
            Me.Tbl_inv_SupplierTypeTableAdapter.Fill(Me.DSNewPurOrders.tbl_inv_SupplierType)
        End If
    End Sub
    Sub ToRefresh()
        Dim SupType As Integer = Me.Tbl_inv_SupplierTypeBindingSource.Position
        Dim PO As Integer = Me.Tbl_Pur_POBindingSource.Position
        Dim POD As Integer = Me.Tbl_Pur_PO_DBindingSource.Position
        LoadAll()
        Me.Tbl_inv_SupplierTypeBindingSource.Position = SupType
        Me.Tbl_Pur_POBindingSource.Position = PO
        Me.Tbl_Pur_PO_DBindingSource.Position = POD
    End Sub

    Private Sub btnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ToRefresh()
    End Sub
End Class