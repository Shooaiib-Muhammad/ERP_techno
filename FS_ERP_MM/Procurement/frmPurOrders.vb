Public Class frmPurOrders
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
        Me.View_Supplier_ItemsTableAdapter.Fill(Me.DSPurOrder.View_Supplier_Items)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSPurOrder.tbl_Inv_Supplier)
        Me.Tbl_Pur_PO_DTableAdapter.Fill(Me.DSPurOrder.tbl_Pur_PO_D)
        Me.Tbl_Pur_POTableAdapter.Fill(Me.DSPurOrder.tbl_Pur_PO)
        If frmLoginVer.DeptID = 24 Then
            Me.Tbl_inv_SupplierTypeTableAdapter.FillBy(Me.DSPurOrder.tbl_inv_SupplierType)
            TextBox1.Visible = True

            Label3.Visible = True
        Else
            Me.Tbl_inv_SupplierTypeTableAdapter.Fill(Me.DSPurOrder.tbl_inv_SupplierType)
            TextBox1.Visible = False
            Label3.Visible = False
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
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ReqDateMaskedTextBox.ReadOnly = False
        Addflag = True
    End Sub
    Dim flag As Boolean = False
    Private Sub Tbl_Pur_POBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_POBindingNavigatorSaveItem.Click
        Dim POPosition As Integer = Me.Tbl_Pur_POBindingSource.Position
        If flag = True Then
            Try
                Me.POIDLabel2.Text = Me.Tbl_Pur_POTableAdapter.MaxPO
                flag = False
                If frmLoginVer.DeptID = 24 Then
                    Me.Tbl_Pur_POTableAdapter.Insert(POIDLabel2.Text, Me.SupplierIDComboBox.SelectedValue, Me.SupplierTypeComboBox.SelectedValue, PODateMaskedTextBox.Text, ReqDateMaskedTextBox.Text, NewReqDateMaskedTextBox.Text, Nothing, SpecialNoteTextBox.Text, Nothing, Nothing, TextBox1.Text, 0, ImportStatusCheckBox.CheckState)
                Else
                    Me.Tbl_Pur_POTableAdapter.Insert(POIDLabel2.Text, Me.SupplierIDComboBox.SelectedValue, Me.SupplierTypeComboBox.SelectedValue, PODateMaskedTextBox.Text, ReqDateMaskedTextBox.Text, NewReqDateMaskedTextBox.Text, Nothing, SpecialNoteTextBox.Text, Nothing, Nothing, 0, 0, ImportStatusCheckBox.CheckState)
                End If

                Me.Tbl_Pur_POTableAdapter.Fill(Me.DSPurOrder.tbl_Pur_PO)
                Me.Tbl_Pur_POBindingSource.Position = POPosition
                MsgBox("Record Saved.")
                Me.ReqDateMaskedTextBox.ReadOnly = True
                Addflag = False
                DGVAttribute(True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                Me.SupplierType.Text = Me.SupplierTypeComboBox.SelectedValue
                Me.Validate()
                Me.Tbl_Pur_POBindingSource.EndEdit()
                Me.Tbl_Pur_POTableAdapter.Update(Me.DSPurOrder.tbl_Pur_PO)
                'Me.Tbl_Pur_POTableAdapter.Fill(Me.DSPurOrder.tbl_Pur_PO)
                Me.Tbl_Pur_POBindingSource.Position = POPosition
                MsgBox("Record Saved.")
                Me.ReqDateMaskedTextBox.ReadOnly = True
                Addflag = False
                DGVAttribute(True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
       
    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        DGVAttribute(True)
    End Sub
    Private Sub BindingNavigatorAddNewItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem1.Click
        PositionPODflag = True
        DGVAttribute(False)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.Validate()
            Me.Tbl_Pur_PO_DBindingSource.EndEdit()
            Me.Tbl_Pur_PO_DTableAdapter.Update(Me.DSPurOrder.tbl_Pur_PO_D)
            MsgBox("Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Pur_POBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Pur_POBindingSource.PositionChanged
        If Me.PODateMaskedTextBox.Text = "  /  /" Then
            Me.PODateMaskedTextBox.Text = Now.Date
        End If
        If MoveBackflag = True Then
            Me.ReqDateMaskedTextBox.ReadOnly = True
            MoveBackflag = False
        End If
        DGVAttribute(True)
    End Sub

    Private Sub PODateMaskedTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PODateMaskedTextBox.GotFocus
        If Me.PODateMaskedTextBox.Text = "  /  /" Then
            Me.PODateMaskedTextBox.Text = Now.Date
        End If
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
        ElseIf e.ColumnIndex = 4 Then
            If frmLoginVer.UserID = 8 Then
                Me.Tbl_Pur_PO_DDataGridView.Columns(4).ReadOnly = False
            Else
                Me.Tbl_Pur_PO_DDataGridView.Columns(4).ReadOnly = False
            End If
            'If Not Me.Tbl_Pur_Supplier_CodeTableAdapter.UnitPrice(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value) = Nothing Then

            If Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                Try
                    'Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value = Me.Tbl_Pur_Supplier_CodeTableAdapter.UnitPrice(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value)
                    Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value = Me.UnitPriceLabel1.Text
                Catch ex As Exception
                    Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value = 0.0001
                End Try
            End If
            'Else
            '    'MsgBox("Unit Price not found....")
            'End If
        ElseIf e.ColumnIndex = 3 Then
            PositionPODflag = False
            DGVAttribute(True)
            If Me.Tbl_Pur_PO_DDataGridView(3, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Pur_PO_DDataGridView(3, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Pur_PO_DDataGridView(5, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Pur_PO_DDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                If Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
                    'If Not Me.Tbl_Pur_Supplier_CodeTableAdapter.UOM(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value) = "" Then
                    If Me.Tbl_Pur_PO_DDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                        'Me.Tbl_Pur_PO_DDataGridView(3, e.RowIndex).Value = Me.Tbl_Pur_Supplier_CodeTableAdapter.UOM(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value)
                        Me.Tbl_Pur_PO_DDataGridView(3, e.RowIndex).Value = Me.UOMLabel1.Text
                    End If
                    'Else
                    '    MsgBox("Unit of Measurement not found....")
                    'End If
                    'If Not Me.Tbl_Pur_Supplier_CodeTableAdapter.UnitPrice(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value) = Nothing Then
                    '    If Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value Is DBNull.Value Or Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value = 0 Then
                    '        Me.Tbl_Pur_PO_DDataGridView(4, e.RowIndex).Value = Me.Tbl_Pur_Supplier_CodeTableAdapter.UnitPrice(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value)
                    '    End If
                    'Else
                    '    MsgBox("Unit Price not found....")
                    'End If
                    If Not Me.Tbl_Pur_Supplier_CodeTableAdapter.OtherChargesQuery(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value) = Nothing Then
                        If Me.Tbl_Pur_PO_DDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                            Me.Tbl_Pur_PO_DDataGridView(5, e.RowIndex).Value = Me.Tbl_Pur_Supplier_CodeTableAdapter.OtherChargesQuery(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value)
                        End If
                    End If
                    'If Not Me.Tbl_Pur_Supplier_CodeTableAdapter.Curency(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value) = "" Then
                    If Me.Tbl_Pur_PO_DDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                        'Me.Tbl_Pur_PO_DDataGridView(7, e.RowIndex).Value = Me.Tbl_Pur_Supplier_CodeTableAdapter.Curency(SupplierIDComboBox.SelectedValue, Me.Tbl_Pur_PO_DDataGridView(1, e.RowIndex).Value)
                        Me.Tbl_Pur_PO_DDataGridView(7, e.RowIndex).Value = Me.CurencyLabel1.Text
                    End If
                    'Else
                    '    MsgBox("Curency Not Found....")
                    'End If
                Else
                    MsgBox("Supplier's Material value Not found...again select the material", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Pur_PO_DDataGridView_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Tbl_Pur_PO_DDataGridView.CellMouseDoubleClick

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

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ToRefresh()
    End Sub

    Private Sub AddSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSale.Click
        flag = True
        Me.ReqDateMaskedTextBox.ReadOnly = False
        Addflag = True
        Me.Tbl_Pur_POBindingSource.AddNew()
        If frmLoginVer.UserID = 2 Or frmLoginVer.UserID = 342 Then
            Me.Tbl_Inv_SupplierTableAdapter.FillBy1(Me.DSPurOrder.tbl_Inv_Supplier)
        Else
            Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSPurOrder.tbl_Inv_Supplier)

        End If
        'Me.POIDLabel2.Text = Me.Tbl_Pur_POTableAdapter.MaxPO
    End Sub

    Private Sub NewReqDateTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewReqDateTextBox.Click

    End Sub

    Private Sub PONOTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PONOTextBox.Click

    End Sub

    Private Sub SuplierNameTextBox_Click(sender As Object, e As EventArgs) Handles SuplierNameTextBox.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        If RadioButton1.Checked Then
            If frmLoginVer.DeptID = 24 Then
                Path = "" & frmLoginVer.Reportpath & "\RptPO(Disc).rpt"
            Else
                Path = "" & frmLoginVer.Reportpath & "\RptPO.rpt"
            End If
            Filter = "{tbl_Pur_PO_D.POID} = " & Me.POIDLabel2.Text & ""
        ElseIf RadioButton2.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptPORec.rpt"
            Filter = "  {tbl_Pur_PO.POID} = " & Me.POIDLabel2.Text & ""
        End If

        Dim obj As New Class_Utility
        obj.LoadReports(Path, Filter, "")
    End Sub

    Private Sub NewReqDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles NewReqDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub ReqDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles ReqDateMaskedTextBox.MaskInputRejected

    End Sub
End Class

