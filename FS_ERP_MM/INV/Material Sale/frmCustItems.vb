Public Class frmCustItems
    Private Sub frmCustItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSCustItems.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_MM_CurrancyTableAdapter.Fill(Me.DSCustItems.tbl_MM_Currancy)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSCustItems.tbl_Inv_L4)
        'Me.Tbl_MM_Cust_ItemsTableAdapter.Fill(Me.DSCustItems.tbl_MM_Cust_Items)
        If frmLoginVer.DeptID = 72 Then
            Me.Tbl_MM_CustomerTableAdapter.FillBy(Me.DSCustItems.tbl_MM_Customer)
        ElseIf frmLoginVer.DeptID = 69 Or frmLoginVer.DeptID = 24 Then
            Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSCustItems.tbl_MM_Customer)
        Else
            Me.Tbl_MM_CustomerTableAdapter.FillBy(Me.DSCustItems.tbl_MM_Customer)
        End If
        Me.Tbl_MM_Cust_ItemsTableAdapter.Fill(Me.DSCustItems.tbl_MM_Cust_Items)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSCustItems.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_MM_CurrancyTableAdapter.Fill(Me.DSCustItems.tbl_MM_Currancy)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSCustItems.tbl_Inv_L4)
        Me.Tbl_MM_CustomerBindingSource.MoveLast()
        Loadflag = True
    End Sub
    Dim flag As Boolean = False

    Private Sub Tbl_MM_Cust_ItemsDataGridView_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_MM_Cust_ItemsDataGridView.CellContentClick
        If e.ColumnIndex = 7 Then
            If Me.Tbl_MM_Cust_ItemsDataGridView.Item(7, e.RowIndex) Is DBNull.Value Then
                Me.Tbl_MM_Cust_ItemsDataGridView.Item(7, e.RowIndex).Value = True
                Me.Tbl_MM_Cust_ItemsDataGridView.Item(8, e.RowIndex).Value = Now
            Else
                If Me.Tbl_MM_Cust_ItemsDataGridView.Item(7, e.RowIndex).Value = False Then
                    Me.Tbl_MM_Cust_ItemsDataGridView.Item(7, e.RowIndex).Value = True
                    Me.Tbl_MM_Cust_ItemsDataGridView.Item(8, e.RowIndex).Value = Now
                Else
                    Me.Tbl_MM_Cust_ItemsDataGridView.Item(7, e.RowIndex).Value = False
                End If
            End If
        End If

    End Sub

    Private Sub Tbl_MM_Cust_ItemsDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_MM_Cust_ItemsDataGridView.CellEnter
        If e.ColumnIndex = 1 Then
            If Addflag = True Then
                Dim Id As Integer
                Try
                    Id = Me.Tbl_MM_Cust_ItemsDataGridView(1, e.RowIndex - 1).Value
                Catch ex As Exception
                    Id = 0
                End Try
                Me.Tbl_MM_Cust_ItemsDataGridView(1, e.RowIndex).Value = Id + 1
                Addflag = False
            End If
        ElseIf e.ColumnIndex = 3 Then
            If Tbl_MM_Cust_ItemsDataGridView(3, e.RowIndex).Value Is DBNull.Value And Tbl_MM_Cust_ItemsDataGridView(4, e.RowIndex).Value Is DBNull.Value And Tbl_MM_Cust_ItemsDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                If Me.Tbl_MM_Cust_ItemsDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
                    If Not Me.Tbl_Inv_L4TableAdapter.Currency(Me.Tbl_MM_Cust_ItemsDataGridView(2, e.RowIndex).Value) = "" Then
                        Tbl_MM_Cust_ItemsDataGridView(3, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.Currency(Me.Tbl_MM_Cust_ItemsDataGridView(2, e.RowIndex).Value)
                    Else
                        MsgBox("Curency not found....")
                    End If
                    If Not Me.Tbl_Inv_L4TableAdapter.UnitPrice(Me.Tbl_MM_Cust_ItemsDataGridView(2, e.RowIndex).Value).ToString = "" Then
                        Tbl_MM_Cust_ItemsDataGridView(4, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.UnitPrice(Me.Tbl_MM_Cust_ItemsDataGridView(2, e.RowIndex).Value)
                    Else
                        MsgBox("Unit Price not found....")
                    End If
                    If Not Me.Tbl_Inv_L4TableAdapter.UOM(Me.Tbl_MM_Cust_ItemsDataGridView(2, e.RowIndex).Value) = "" Then
                        Tbl_MM_Cust_ItemsDataGridView(5, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.UOM(Me.Tbl_MM_Cust_ItemsDataGridView(2, e.RowIndex).Value)
                    Else
                        MsgBox("Unit of Measurement not found....")
                    End If
                End If
            End If
        ElseIf e.ColumnIndex = 6 Then
            If Tbl_MM_Cust_ItemsDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Tbl_MM_Cust_ItemsDataGridView(6, e.RowIndex).Value = Now.Date
            End If
        ElseIf e.ColumnIndex = 7 Then
            If Tbl_MM_Cust_ItemsDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Tbl_MM_Cust_ItemsDataGridView(7, e.RowIndex).Value = True
            End If
        ElseIf e.ColumnIndex = 8 Then
            If Tbl_MM_Cust_ItemsDataGridView(8, e.RowIndex).Value Is DBNull.Value Then
                Tbl_MM_Cust_ItemsDataGridView(8, e.RowIndex).Value = Now.Date
            End If
        End If
        flag = True
    End Sub

    Private Sub Tbl_MM_Cust_ItemsDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_MM_Cust_ItemsDataGridView.CellValueChanged
        If flag = True Then
            Me.Tbl_MM_Cust_ItemsDataGridView.Item(8, e.RowIndex).Value = Now
        End If
    End Sub

    Private Sub Tbl_MM_Cust_ItemsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_MM_Cust_ItemsDataGridView.DataError

    End Sub

    Private Sub CustomerTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerTextBox.GotFocus
        If Me.CustomerTextBox.Text = "Enter Customer Name" Then
            Me.CustomerTextBox.Text = ""
            Me.CustomerTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CustomerTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustomerTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_MM_CustomerBindingSource.Filter = "CompanyName like'%" & Me.CustomerTextBox.Text & "%'"
            Me.CustomerTextBox.Clear()
            Me.CMSCustomer.Hide()
        End If
    End Sub

    Private Sub CustomerTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerTextBox.LostFocus
        If Me.CustomerTextBox.TextLength = 0 Then
            Me.CustomerTextBox.Text = "Enter Customer Name"
            Me.CustomerTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub AscendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AscendingOrderToolStripMenuItem.Click
        Me.Tbl_MM_CustomerBindingSource.Sort = "CompanyName ASC"
    End Sub

    Private Sub DescendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescendingOrderToolStripMenuItem.Click
        Me.Tbl_MM_CustomerBindingSource.Sort = "CompanyName DESC"
    End Sub

    Private Sub RemoveOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveOrderToolStripMenuItem.Click
        Me.Tbl_MM_CustomerBindingSource.RemoveSort()
        Me.CustomerTextBox.Text = "Enter Customer Name"
        Me.CustomerTextBox.ForeColor = Color.Silver
        Me.Tbl_MM_CustomerBindingSource.Position = Me.Tbl_MM_CustomerBindingSource.Count
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_MM_CustomerBindingSource.RemoveFilter()
        Me.CustomerTextBox.Text = "Enter Customer Name"
        Me.CustomerTextBox.ForeColor = Color.Silver
        Me.Tbl_MM_CustomerBindingSource.Position = Me.Tbl_MM_CustomerBindingSource.Count
    End Sub

    Private Sub Tbl_MM_Cust_ItemsDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_MM_Cust_ItemsDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Dim Addflag As Boolean = False
    Dim Positionflag As Boolean = False

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        Addflag = True
        Positionflag = True
        Me.Tbl_MM_Cust_ItemsBindingSource.AddNew()
        DGVAttribute(False)
        Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSCustItems.tbl_Inv_L4)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Tbl_MM_CustomerBindingSource.Filter = "Status=1"
        ButtonVisible(True)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_MM_CustomerBindingSource.Filter = "Status IS NULL OR Status=0 "
        ButtonVisible(False)
    End Sub
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Tbl_MM_CustomerBindingSource.RemoveFilter()
    End Sub
    Private Sub txtfilterMatName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfilterMatName.GotFocus
        If Me.txtfilterMatName.Text = "Enter Material Name" Then
            Me.txtfilterMatName.Clear()
            Me.txtfilterMatName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtfilterMatName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfilterMatName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim NewCode As String
            Dim Ret As Integer
            Dim CodeStr As String = ""
            If txtfilterMatName.Text.Length = 0 Then
                Me.Tbl_MM_Cust_ItemsBindingSource.RemoveFilter()
            Else
                Ret = Me.Tbl_Inv_MatNameTableAdapter.FillBy(Me.DSCustItems.tbl_Inv_MatName, txtfilterMatName.Text)
                If Ret > 0 Then
                    For i As Integer = 0 To Ret - 1
                        NewCode = Me.DSCustItems.tbl_Inv_MatName(i).Item(4)
                        If CodeStr.Length = 0 Then
                            CodeStr = "'" & NewCode & "'"
                        Else
                            CodeStr = CodeStr & ", '" & NewCode & "'"
                        End If
                    Next
                    Me.Tbl_MM_Cust_ItemsBindingSource.RemoveFilter()
                    Me.Tbl_MM_Cust_ItemsBindingSource.Filter = "(Code in (" & CodeStr & ")) And CustID = " & Val(CustIDTextBox.Text) & ""
                    If Tbl_MM_Cust_ItemsBindingSource.Count = 0 Then
                        MsgBox("No Match Found")
                        Me.Tbl_MM_Cust_ItemsBindingSource.RemoveFilter()
                    End If
                Else
                    MsgBox("No Match Found")
                End If
            End If
            Me.txtfilterMatName.Clear()
            Me.CMSItemName.Hide()
        End If
    End Sub
    Private Sub txtfilterMatName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfilterMatName.LostFocus
        If Me.txtfilterMatName.Text = "" Then
            Me.txtfilterMatName.Text = "Enter Material Name"
            Me.txtfilterMatName.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Tbl_MM_Cust_ItemsBindingSource.RemoveFilter()
    End Sub

    Private Sub Tbl_MM_CustomerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_MM_CustomerBindingNavigatorSaveItem.Click
        Dim Position As Int16 = Me.Tbl_MM_CustomerBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_MM_CustomerBindingSource.EndEdit()
            Me.Tbl_MM_CustomerTableAdapter.Update(Me.DSCustItems.tbl_MM_Customer)
            Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSCustItems.tbl_MM_Customer)
            Me.Tbl_MM_CustomerBindingSource.Position = Position
            MsgBox("Record Updated Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim Loadflag As Boolean = False
    Sub ButtonVisible(ByVal Value As Boolean)
        Add.Visible = Value
        Delete.Visible = Value
        Save.Visible = Value
    End Sub
    Sub DGVAttribute(ByVal Value As Boolean)
        Tbl_MM_Cust_ItemsDataGridView.Columns(2).ReadOnly = Value
        Tbl_MM_Cust_ItemsDataGridView.Columns(3).ReadOnly = Value
        Tbl_MM_Cust_ItemsDataGridView.Columns(5).ReadOnly = Value
        Tbl_MM_Cust_ItemsDataGridView.Columns(6).ReadOnly = Value
    End Sub
    Private Sub Tbl_MM_CustomerBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_MM_CustomerBindingSource.PositionChanged
        If Loadflag = True Then
            Dim Status As Boolean
            Try
                Status = Me.Tbl_MM_CustomerTableAdapter.StatusQuery(Me.CustIDTextBox.Text)
            Catch ex As Exception
                Status = False
            End Try
            If Status = True Then
                ButtonVisible(True)
            Else
                ButtonVisible(False)
            End If
            DGVAttribute(False)
        End If
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        DGVAttribute(False)
    End Sub

    Private Sub Tbl_MM_Cust_ItemsBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_MM_Cust_ItemsBindingSource.PositionChanged
        If Positionflag = False Then
            DGVAttribute(False)
        Else
            DGVAttribute(False)
            Positionflag = False
        End If
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Try
            Me.Validate()
            Me.Tbl_MM_Cust_ItemsBindingSource.EndEdit()
            Me.Tbl_MM_Cust_ItemsTableAdapter.Update(Me.DSCustItems.tbl_MM_Cust_Items)
            Me.Tbl_MM_Cust_ItemsTableAdapter.Fill(Me.DSCustItems.tbl_MM_Cust_Items)
            Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSCustItems.tbl_Inv_L4)
            MsgBox("Record Saved")
            DGVAttribute(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class