Public Class frmSupItems
    Private Sub frmSupItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub
    Private Sub frmSupItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_inv_SupplierTypeTableAdapter.Fill(Me.DSSupItems.tbl_inv_SupplierType)
        Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.Fill(Me.DSSupItems.tbl_Pur_UnitofMeasurementDtl)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSPO.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSSupItems.tbl_Inv_L4)
        Me.Tbl_Pur_Supplier_CodeTableAdapter.Fill(Me.DSSupItems.tbl_Pur_Supplier_Code)
        If frmLoginVer.UserID = 2 Or frmLoginVer.UserID = 342 Then
            Me.Tbl_Inv_SupplierTableAdapter.FillBy1(Me.DSSupItems.tbl_Inv_Supplier)
        Else
            Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSSupItems.tbl_Inv_Supplier)
        End If
        If frmLoginVer.UserID = 9 Then
            Me.Tbl_Pur_Supplier_CodeDataGridView.Columns(8).Visible = True
        Else
            Me.Tbl_Pur_Supplier_CodeDataGridView.Columns(8).Visible = False
        End If
        DGVAttribute(True)
        Loadflag = True
        KeyPreview = True
    End Sub
    Sub Save()
        Try
            Me.Validate()
            Me.Tbl_Pur_Supplier_CodeBindingSource.EndEdit()
            Me.Tbl_Pur_Supplier_CodeTableAdapter.Update(Me.DSSupItems.tbl_Pur_Supplier_Code)
            Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSSupItems.tbl_Inv_L4)
            MsgBox("Record Saved")
            RemoveFalg = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim UOMfalg As Boolean = False
    Sub DGVAttribute(ByVal Value As Boolean)
        Tbl_Pur_Supplier_CodeDataGridView.Columns(2).ReadOnly = Value
        'Tbl_Pur_Supplier_CodeDataGridView.Columns(3).ReadOnly = Value
        'Tbl_Pur_Supplier_CodeDataGridView.Columns(6).ReadOnly = Value
        Tbl_Pur_Supplier_CodeDataGridView.Columns(7).ReadOnly = Value
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSupplierItem.Click
        Dim position As Integer = Me.Tbl_Pur_Supplier_CodeBindingSource.Position
        Dim L4UOM As String = Me.Tbl_Inv_L4TableAdapter.SelectUOMQuery(Code)
        If UOMfalg = False Then
            If Not L4UOM = Nothing Then
                If Not L4UOM = UOM Then
                    Dim UOMValue As Double
                    Try
                        UOMValue = Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.ScalarQuery(UOM, Code, L4UOM)
                    Catch ex As Exception
                        UOMValue = 0
                    End Try
                    If UOMValue > 0 Then
                        MsgBox("Conversion Unit Of This UOM  Already Exist")
                        Save()
                    Else
                        Try
                            UOMValue = InputBox("UOM in Material Layer 4 is " & L4UOM & " And Purchasing UOM is " & UOM & " " & vbCrLf & " Enter the Calculated Value To Continue" & vbCrLf & "e.g Drum in Kg=205 And Kg in Drum =0.004")
                        Catch ex As Exception
                        End Try
                        If UOMValue > 0 Then
                            Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.Insert(UOM, Code, L4UOM, UOMValue)
                            Save()
                        End If
                    End If
                Else
                    Save()
                End If
            Else
                Save()
            End If
        ElseIf UOMfalg = True Then
            MsgBox("Record has been Deleted")
            UOMfalg = False
        End If
        Me.Tbl_Pur_Supplier_CodeTableAdapter.Fill(Me.DSSupItems.tbl_Pur_Supplier_Code)
        DGVAttribute(True)
        Me.Tbl_Pur_Supplier_CodeBindingSource.Position = position
    End Sub
    Private Sub Tbl_Inv_SupplierBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Inv_SupplierBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Inv_SupplierBindingSource.EndEdit()
            Me.Tbl_Inv_SupplierTableAdapter.Update(Me.DSSupItems.tbl_Inv_Supplier)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EnableDisableControls(ByVal SaveItemStatus As Boolean, ByVal AddItemStatus As Boolean, ByVal RightLastItemStatus As Boolean, ByVal RightNextItemStatus As Boolean, ByVal LeftLastItemStatus As Boolean, ByVal LeftNextItemStatus As Boolean, ByVal PositionItemStatus As Boolean)
        Tbl_Inv_SupplierBindingNavigatorSaveItem.Enabled = SaveItemStatus
        BindingNavigatorAddNewItem.Enabled = AddItemStatus
        BindingNavigatorMoveLastItem.Enabled = RightLastItemStatus
        BindingNavigatorMoveNextItem.Enabled = RightNextItemStatus
        BindingNavigatorMovePreviousItem.Enabled = LeftNextItemStatus
        BindingNavigatorMoveFirstItem.Enabled = LeftLastItemStatus
        BindingNavigatorPositionItem.Enabled = PositionItemStatus
    End Sub
    Dim flag As Boolean = False
    Private Sub Tbl_Pur_Supplier_CodeDataGridView_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_Supplier_CodeDataGridView.CellContentClick
        If e.ColumnIndex = 9 Then
            If Me.Tbl_Pur_Supplier_CodeDataGridView.Item(9, e.RowIndex) Is DBNull.Value Then
                Me.Tbl_Pur_Supplier_CodeDataGridView.Item(9, e.RowIndex).Value = True
                'Me.Tbl_Pur_Supplier_CodeDataGridView.Item(10, e.RowIndex).Value = Now.Date
            Else
                If Me.Tbl_Pur_Supplier_CodeDataGridView.Item(9, e.RowIndex).Value = False Then
                    Me.Tbl_Pur_Supplier_CodeDataGridView.Item(9, e.RowIndex).Value = True
                    'Me.Tbl_Pur_Supplier_CodeDataGridView.Item(10, e.RowIndex).Value = Now.Date
                Else
                    Me.Tbl_Pur_Supplier_CodeDataGridView.Item(9, e.RowIndex).Value = False
                End If
            End If
        End If
    End Sub
    Dim UOM As String = Nothing
    Dim SupplierID, SupplierCodeID As Integer
    Dim Code As String = Nothing
    Dim Addflag As Boolean = False
    Private Sub Tbl_Pur_Supplier_CodeDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_Supplier_CodeDataGridView.CellEnter
        If e.ColumnIndex = 4 Then
            If Me.Tbl_Pur_Supplier_CodeDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Pur_Supplier_CodeDataGridView.Columns(4).ReadOnly = False
            Else
                If frmLoginVer.UserID = 8 Then
                    Me.Tbl_Pur_Supplier_CodeDataGridView.Columns(4).ReadOnly = False
                Else
                    Me.Tbl_Pur_Supplier_CodeDataGridView.Columns(4).ReadOnly = False
                End If
            End If
        End If
        If e.ColumnIndex = 1 Then
            If Me.Tbl_Pur_Supplier_CodeDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
                Dim Id As Integer
                Try
                    Id = Me.Tbl_Pur_Supplier_CodeDataGridView(1, e.RowIndex - 1).Value
                Catch ex As Exception
                    Id = 0
                End Try
                Me.Tbl_Pur_Supplier_CodeDataGridView(1, e.RowIndex).Value = Id + 1
                DGVAttribute(False)
                Addflag = False
            End If
        ElseIf e.ColumnIndex = 3 Then
            If Tbl_Pur_Supplier_CodeDataGridView(3, e.RowIndex).Value Is DBNull.Value And Tbl_Pur_Supplier_CodeDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
                Tbl_Pur_Supplier_CodeDataGridView(3, e.RowIndex).Value = "PKR"
            End If
        ElseIf e.ColumnIndex = 6 Then
            If Tbl_Pur_Supplier_CodeDataGridView(4, e.RowIndex).Value IsNot DBNull.Value And Tbl_Pur_Supplier_CodeDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Pur_Supplier_CodeDataGridView(6, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.SelectUOMQuery(Me.Tbl_Pur_Supplier_CodeDataGridView(2, e.RowIndex).Value)
            End If
        ElseIf e.ColumnIndex = 7 Then
            If Tbl_Pur_Supplier_CodeDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Pur_Supplier_CodeDataGridView(7, e.RowIndex).Value = Now.Date
                DGVAttribute(True)
            End If
        ElseIf e.ColumnIndex = 9 Then
            If Tbl_Pur_Supplier_CodeDataGridView(9, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Pur_Supplier_CodeDataGridView(9, e.RowIndex).Value = True
            End If
        ElseIf e.ColumnIndex = 10 Then
            If Tbl_Pur_Supplier_CodeDataGridView(10, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Pur_Supplier_CodeDataGridView(10, e.RowIndex).Value = Now.Date
            End If
        End If
        Try
            UOM = Me.Tbl_Pur_Supplier_CodeDataGridView(6, e.RowIndex).Value
        Catch ex As Exception
        End Try
        Try
            SupplierID = Me.Tbl_Pur_Supplier_CodeDataGridView(0, e.RowIndex).Value
        Catch ex As Exception
        End Try
        Try
            SupplierCodeID = Me.Tbl_Pur_Supplier_CodeDataGridView(1, e.RowIndex).Value
        Catch ex As Exception
        End Try
        Try
            Code = Me.Tbl_Pur_Supplier_CodeDataGridView(2, e.RowIndex).Value
        Catch ex As Exception
        End Try
        flag = True
    End Sub
    Private Sub txtFilterSuppliers_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilterSuppliers.GotFocus
        If Me.txtFilterSuppliers.Text = "Enter Company Name" Then
            Me.txtFilterSuppliers.Clear()
            Me.txtFilterSuppliers.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtFilterSuppliers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFilterSuppliers.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_Inv_SupplierBindingSource.Filter = "CompanyName like'%" & Me.txtFilterSuppliers.Text & "%'"
            Me.txtFilterSuppliers.Clear()
            Me.CMSCompName.Hide()
        End If
    End Sub
    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_Inv_SupplierBindingSource.RemoveFilter()
    End Sub
    Private Sub AscendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AscendingOrderToolStripMenuItem.Click
        Me.Tbl_Inv_SupplierBindingSource.Sort = "CompanyName ASC"
    End Sub
    Private Sub DescendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescendingOrderToolStripMenuItem.Click
        Me.Tbl_Inv_SupplierBindingSource.Sort = "CompanyName DESC"
    End Sub
    Private Sub RemoveOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveOrderToolStripMenuItem.Click
        Me.Tbl_Inv_SupplierBindingSource.RemoveSort()
    End Sub
    Private Sub txtFilterSuppliers_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilterSuppliers.LostFocus
        If Me.txtFilterSuppliers.Text = "" Then
            Me.txtFilterSuppliers.Text = "Enter Company Name"
            Me.txtFilterSuppliers.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub Tbl_Pur_Supplier_CodeDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_Supplier_CodeDataGridView.CellValueChanged
        If flag = True Then
            If e.ColumnIndex = 4 Then
                Me.Tbl_Pur_Supplier_CodeDataGridView.Item(10, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub
    Private Sub Tbl_Pur_Supplier_CodeDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_Supplier_CodeDataGridView.DataError
    End Sub
    Dim RemoveFalg As Boolean = False
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSupItem.Click
        If RemoveFalg = False Then
            Dim btnMsg As DialogResult = MessageBox.Show("Are You Sure Want To Delete it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.DeleteQuery(UOM, Code)
                Me.Tbl_Pur_Supplier_CodeTableAdapter.DeleteQuery(SupplierID, SupplierCodeID, Code)
                Me.Tbl_Pur_Supplier_CodeTableAdapter.Fill(Me.DSSupItems.tbl_Pur_Supplier_Code)
                UOMfalg = True
            Else
                UOMfalg = False
            End If
        Else
            Me.Tbl_Pur_Supplier_CodeBindingSource.RemoveCurrent()
            RemoveFalg = False
        End If
        DGVAttribute(True)
    End Sub
    Private Sub Tbl_Pur_Supplier_CodeDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Pur_Supplier_CodeDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Tbl_Inv_SupplierTableAdapter.FillBy(Me.DSSupItems.tbl_Inv_Supplier)
    End Sub
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSupItem.Click
        Addflag = True
        RemoveFalg = True
        Positionflag = True
        UOMfalg = False
        Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSSupItems.tbl_Inv_L4)
        Me.Tbl_Pur_Supplier_CodeBindingSource.AddNew()
        DGVAttribute(False)
        Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSSupItems.tbl_Inv_L4)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Tbl_Inv_SupplierBindingSource.Filter = "Status=1"
        VisibleButtons(True)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_Inv_SupplierBindingSource.Filter = "Status IS NULL OR Status=0 "
        VisibleButtons(False)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Tbl_Inv_SupplierBindingSource.RemoveFilter()
    End Sub
    Dim Loadflag As Boolean = False
    Sub VisibleButtons(ByVal Value As Boolean)
        AddSupItem.Visible = Value
        DeleteSupItem.Visible = Value
        SaveSupplierItem.Visible = Value
    End Sub
    Private Sub Tbl_Inv_SupplierBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_SupplierBindingSource.PositionChanged
        If Loadflag = True Then
            Dim Status As Boolean = False
            Try
                Status = Me.Tbl_Inv_SupplierTableAdapter.SelectQuery(Val(Me.SupplierIDLabel1.Text))
            Catch ex As Exception
            End Try
            If Status = True Then
                VisibleButtons(True)
            Else
                VisibleButtons(False)
            End If
            DGVAttribute(True)
        End If
    End Sub
    Dim Filterflag As Boolean = False
    Private Sub txtfilterMatName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfilterMatName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Filterflag = True
            Dim NewCode As String
            Dim Ret As Integer
            Dim CodeStr As String = ""
            If txtfilterMatName.Text.Length = 0 Then
                Me.Tbl_Pur_Supplier_CodeBindingSource.RemoveFilter()
            Else
                Ret = Me.Tbl_Inv_L4TableAdapter1.FillBy2(Me.DSPO.tbl_Inv_L4, txtfilterMatName.Text)
                If Ret > 0 Then
                    For i As Integer = 0 To Ret - 1
                        NewCode = Me.DSPO.tbl_Inv_L4(i).Item(4)
                        If CodeStr.Length = 0 Then
                            CodeStr = "'" & NewCode & "'"
                        Else
                            CodeStr = CodeStr & ", '" & NewCode & "'"
                        End If
                    Next
                    Me.Tbl_Pur_Supplier_CodeBindingSource.RemoveFilter()
                    Me.Tbl_Pur_Supplier_CodeBindingSource.Filter = "(Code in (" & CodeStr & ")) And SupplierID = " & Val(SupplierIDLabel1.Text) & ""
                    If Tbl_Pur_Supplier_CodeBindingSource.Count = 0 Then
                        MsgBox("No Match Found")
                    End If
                Else
                    MsgBox("No Match Found")
                End If
            End If
            Me.txtfilterMatName.Clear()
            Me.CMSItemName.Hide()
        End If
    End Sub
    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Tbl_Pur_Supplier_CodeBindingSource.RemoveFilter()
        Filterflag = False
    End Sub
    Dim Positionflag As Boolean = False
    Private Sub Tbl_Pur_Supplier_CodeBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Pur_Supplier_CodeBindingSource.PositionChanged
        If Positionflag = False Then
            DGVAttribute(True)
        Else
            DGVAttribute(False)
            Positionflag = False
        End If
    End Sub
    Sub ToRefresh()
        Filterflag = False
        Dim PositionSup As Integer = Me.Tbl_Inv_SupplierBindingSource.Position
        Dim PositionSupCode As Integer = Me.Tbl_Pur_Supplier_CodeBindingSource.Position
        Me.Tbl_Inv_SupplierBindingSource.RemoveFilter()
        Me.Tbl_Pur_Supplier_CodeBindingSource.RemoveFilter()
        If frmLoginVer.UserID = 2 Or frmLoginVer.UserID = 342 Then
            Me.Tbl_Inv_SupplierTableAdapter.FillBy1(Me.DSSupItems.tbl_Inv_Supplier)
        Else
            Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSSupItems.tbl_Inv_Supplier)
        End If
        Me.Tbl_Pur_Supplier_CodeTableAdapter.Fill(Me.DSSupItems.tbl_Pur_Supplier_Code)
        Me.Tbl_Inv_SupplierBindingSource.Position = PositionSup
        Me.Tbl_Pur_Supplier_CodeBindingSource.Position = PositionSupCode
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ToRefresh()
    End Sub
    Private Sub txtfilterMatName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfilterMatName.TextChanged
        If txtfilterMatName.TextLength > 0 Then
            Dim NewCode As String
            Dim Ret As Integer
            Dim CodeStr As String = ""
            Ret = Me.Tbl_Inv_L4TableAdapter1.FillBy2(Me.DSPO.tbl_Inv_L4, txtfilterMatName.Text)
            If Ret > 0 Then
                For i As Integer = 0 To Ret - 1
                    NewCode = Me.DSPO.tbl_Inv_L4(i).Item(4)
                    If CodeStr.Length = 0 Then
                        CodeStr = "'" & NewCode & "'"
                    Else
                        CodeStr = CodeStr & ", '" & NewCode & "'"
                    End If
                Next
                Me.Tbl_Pur_Supplier_CodeBindingSource.Filter = "(Code in (" & CodeStr & ")) And SupplierID = " & Val(SupplierIDLabel1.Text) & ""
                If Tbl_Pur_Supplier_CodeBindingSource.Count = 0 Then
                    'MsgBox("No Match Found")
                End If
            Else
                'MsgBox("No Match Found")
            End If
        ElseIf txtfilterMatName.TextLength = 0 And Filterflag = False Then
            Me.Tbl_Pur_Supplier_CodeBindingSource.RemoveFilter()
            Me.CMSItemName.Hide()
        End If
    End Sub
    Private Sub CMSItemName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMSItemName.Click
        Me.txtfilterMatName.Clear()
    End Sub

    Private Sub txtfilterMatName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfilterMatName.Click

    End Sub
End Class