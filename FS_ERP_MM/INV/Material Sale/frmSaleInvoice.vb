Public Class frmSaleInvoice
    Private Sub frmSaleHead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_MM_SaleDetailTableAdapter.Fill(Me.DSSale.tbl_MM_SaleDetail)

        If frmLoginVer.DeptID = 24 Then
            Me.CheckBox1.Visible = True
            Me.QtyTextBox.Enabled = True
            Me.Tbl_MM_Cust_ItemsTableAdapter.FillBy(Me.DSSale.tbl_MM_Cust_Items)

            Me.Tbl_MM_CustomerTableAdapter.FillBy(Me.DSSale.tbl_MM_Customer)
            Me.Tbl_MM_SaleTableAdapter.FillBy(Me.DSSale.tbl_MM_Sale)
            Me.Tbl_MM_SaleDetailDataGridView.Columns(5).ReadOnly = True
        Else
            Me.Tbl_MM_Cust_ItemsTableAdapter.Fill(Me.DSSale.tbl_MM_Cust_Items)
            Me.CheckBox1.Visible = False
            Me.QtyTextBox.Enabled = False
            Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSSale.tbl_MM_Customer)
            Me.Tbl_MM_SaleTableAdapter.Fill(Me.DSSale.tbl_MM_Sale)
            Me.Tbl_MM_SaleDetailDataGridView.Columns(5).ReadOnly = False
        End If

        Me.Tbl_MM_SaleBindingSource.MoveLast()
       
    End Sub
    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Dim SavePosition As Int16 = Me.Tbl_MM_SaleBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_MM_SaleBindingSource.EndEdit()
            Me.Tbl_MM_SaleTableAdapter.Update(Me.DSSale.tbl_MM_Sale)
            If frmLoginVer.DeptID = 24 Then
                Me.CheckBox1.Visible = True
                'Me.Tbl_MM_CustomerTableAdapter.FillBy(Me.DSSale.tbl_MM_Customer)
                Me.Tbl_MM_SaleTableAdapter.FillBy(Me.DSSale.tbl_MM_Sale)
                Me.Tbl_MM_SaleDetailDataGridView.Columns(5).ReadOnly = True
            Else
                Me.CheckBox1.Visible = False
                'Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSSale.tbl_MM_Customer)
                Me.Tbl_MM_SaleTableAdapter.Fill(Me.DSSale.tbl_MM_Sale)
                Me.Tbl_MM_SaleDetailDataGridView.Columns(5).ReadOnly = False
            End If
            'Me.Tbl_MM_SaleTableAdapter.Fill(Me.DSSale.tbl_MM_Sale)
            Me.Tbl_MM_SaleBindingSource.Position = SavePosition
            DGVAttribute(True)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim SaveDPosition As Int16 = Me.Tbl_MM_SaleBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_MM_SaleDetailBindingSource.EndEdit()
            Me.Tbl_MM_SaleDetailTableAdapter.Update(Me.DSSale.tbl_MM_SaleDetail)
            'Me.View_Mat_BalanceTableAdapter.Fill(Me.DSSale.View_Mat_Balance, Code)
            Me.Tbl_MM_SaleDetailTableAdapter.Fill(Me.DSSale.tbl_MM_SaleDetail)
            MsgBox("Record Saved")
            Me.Tbl_MM_SaleBindingSource.Position = SaveDPosition
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim Code As String = Nothing
    Private Sub Tbl_MM_SaleDetailDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_MM_SaleDetailDataGridView.CellEnter
        Try
            Code = Me.Tbl_MM_Cust_ItemsTableAdapter.SelectCodeQuery(Me.Tbl_MM_SaleDetailDataGridView(2, e.RowIndex).Value, Me.Tbl_MM_SaleDetailDataGridView(3, e.RowIndex).Value)
        Catch ex As Exception
        End Try
        If Addflag = True Then
            If e.ColumnIndex = 4 Then
                If Me.Tbl_MM_SaleDetailDataGridView(3, e.RowIndex).Value IsNot DBNull.Value And Me.Tbl_MM_SaleDetailDataGridView(4, e.RowIndex).Value Is DBNull.Value And Me.Tbl_MM_SaleDetailDataGridView(5, e.RowIndex).Value Is DBNull.Value And Me.Tbl_MM_SaleDetailDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_MM_SaleDetailDataGridView(4, e.RowIndex).Value = Me.Tbl_MM_Cust_ItemsTableAdapter.Currency(Me.Tbl_MM_SaleDetailDataGridView(2, e.RowIndex).Value, Me.Tbl_MM_SaleDetailDataGridView(3, e.RowIndex).Value)
                    Me.Tbl_MM_SaleDetailDataGridView(5, e.RowIndex).Value = Me.Tbl_MM_Cust_ItemsTableAdapter.UnitPrice(Me.Tbl_MM_SaleDetailDataGridView(2, e.RowIndex).Value, Me.Tbl_MM_SaleDetailDataGridView(3, e.RowIndex).Value)
                    Me.Tbl_MM_SaleDetailDataGridView(6, e.RowIndex).Value = Me.Tbl_MM_Cust_ItemsTableAdapter.UOM(Me.Tbl_MM_SaleDetailDataGridView(2, e.RowIndex).Value, Me.Tbl_MM_SaleDetailDataGridView(3, e.RowIndex).Value)
                End If
            End If
            If e.ColumnIndex = 8 Then
                If Me.Tbl_MM_SaleDetailDataGridView(8, e.RowIndex).Value Is DBNull.Value Then
                    Dim SaleQty, BalanceQty As Double
                    If Me.Tbl_MM_SaleDetailDataGridView(6, e.RowIndex).Value IsNot DBNull.Value Then
                        BalanceQty = Me.View_Mat_BalanceTableAdapter.SelectQuery(Code)
                        If BalanceQty > 0 Then
                            SaleQty = Me.Tbl_MM_SaleDetailDataGridView(7, e.RowIndex).Value
                            If SaleQty > BalanceQty Then
                                MsgBox("Entered Quantity is Greater Than Material Available Balance")
                                Me.Tbl_MM_SaleDetailDataGridView(7, e.RowIndex).Value = BalanceQty
                            End If
                            'Me.Tbl_MM_SaleDetailDataGridView(8, e.RowIndex).Value = Now.Date.ToShortDateString
                            Addflag = False
                        Else
                            Addflag = False
                            MsgBox("Available Material Is Nill", MsgBoxStyle.Critical)
                            Try
                                Me.Tbl_MM_SaleDetailBindingSource.ResetBindings(True)
                                Me.Tbl_MM_SaleDetailBindingSource.RemoveCurrent()
                            Catch ex As Exception
                            End Try
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Tbl_MM_SaleDetailDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_MM_SaleDetailDataGridView.DataError

    End Sub
    Private Sub InvoiceDateTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoiceDateTextBox.GotFocus
        If Me.InvoiceDateTextBox.Text = "Enter Invoice Date" Then
            Me.InvoiceDateTextBox.Text = ""
            Me.InvoiceDateTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub InvoiceDateTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InvoiceDateTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.Tbl_MM_SaleBindingSource.Filter = "SDate ='" & Me.InvoiceDateTextBox.Text & "'"
                Me.InvoiceDateTextBox.Clear()
                Me.InvoiceDateContextMenuStrip.Hide()
            End If
        Catch ex As Exception
            MsgBox("Enter Date In Correct Formate")
            Me.InvoiceDateTextBox.Clear()
            Me.InvoiceDateTextBox.Focus()
        End Try
    End Sub
    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_MM_SaleBindingSource.RemoveFilter()
        Me.InvoiceDateTextBox.Text = "Enter Invoice Date"
        Me.InvoiceDateTextBox.ForeColor = Color.Silver
        Me.Tbl_MM_SaleBindingSource.MoveLast()
    End Sub
    Private Sub AscendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AscendingOrderToolStripMenuItem.Click
        Me.Tbl_MM_SaleBindingSource.Sort = "SDate ASC"
    End Sub
    Private Sub DescendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescendingOrderToolStripMenuItem.Click
        Me.Tbl_MM_SaleBindingSource.Sort = "SDate DESC"
    End Sub
    Private Sub RemoveOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveOrderToolStripMenuItem.Click
        Me.Tbl_MM_SaleBindingSource.RemoveSort()
    End Sub
    Private Sub InvoiceDateTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoiceDateTextBox.LostFocus
        If Me.InvoiceDateTextBox.TextLength = 0 Then
            Me.InvoiceDateTextBox.Text = "Enter Invoice Date"
            Me.InvoiceDateTextBox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub InvoiceDateTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoiceDateTextBox.TextChanged
        If InvoiceDateTextBox.TextLength = 2 Then
            InvoiceDateTextBox.Text = String.Concat(InvoiceDateTextBox.Text, "/")
            InvoiceDateTextBox.Select(3, InvoiceDateTextBox.Text.Length)
        End If
        If InvoiceDateTextBox.TextLength = 5 Then
            InvoiceDateTextBox.Text = String.Concat(InvoiceDateTextBox.Text, "/")
            InvoiceDateTextBox.Select(6, InvoiceDateTextBox.Text.Length)
        End If
        If InvoiceDateTextBox.TextLength = 8 Then
            Me.InvoiceDateTextBox.Select(9, InvoiceDateTextBox.TextLength)
        End If
    End Sub

    Private Sub Tbl_MM_SaleDetailDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_MM_SaleDetailDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub Tbl_MM_SaleDetailDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Tbl_MM_SaleDetailDataGridView.RowsAdded
        Try
            If Me.Tbl_MM_SaleDetailDataGridView(0, 0).Value Is DBNull.Value Then
                Me.Tbl_MM_SaleDetailDataGridView(0, e.RowIndex).Value = 1
            ElseIf Me.Tbl_MM_SaleDetailDataGridView(0, e.RowIndex - 1).Value IsNot DBNull.Value Then
                Me.Tbl_MM_SaleDetailDataGridView(0, e.RowIndex).Value = Me.Tbl_MM_SaleDetailDataGridView(0, e.RowIndex - 1).Value + 1
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub DGVAttribute(ByVal Value As Boolean)
        Tbl_MM_SaleDetailDataGridView.Columns(3).ReadOnly = Value
        Tbl_MM_SaleDetailDataGridView.Columns(4).ReadOnly = Value
        Tbl_MM_SaleDetailDataGridView.Columns(6).ReadOnly = Value
        Tbl_MM_SaleDetailDataGridView.Columns(8).ReadOnly = Value
        Tbl_MM_SaleDetailDataGridView.Columns(9).ReadOnly = False
        Tbl_MM_SaleDetailDataGridView.Columns(10).ReadOnly = False
    End Sub
    Private Sub SDateMaskedTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SDateMaskedTextBox.GotFocus
        If Me.SDateMaskedTextBox.Text = "  /  /" Then
            Me.SDateMaskedTextBox.Text = Now.Date.ToShortDateString
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        DGVAttribute(True)
    End Sub
    Dim PositionSaleDflag As Boolean = False
    Dim Addflag As Boolean = False
    Private Sub BindingNavigatorAddNewItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem1.Click
        Addflag = True
        PositionSaleDflag = True
        DGVAttribute(False)
    End Sub

    Private Sub Tbl_MM_SaleBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_MM_SaleBindingSource.PositionChanged
        DGVAttribute(True)
    End Sub

    Private Sub Tbl_MM_SaleDetailBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_MM_SaleDetailBindingSource.PositionChanged
        If PositionSaleDflag = False Then
            DGVAttribute(True)
        Else
            DGVAttribute(False)
            PositionSaleDflag = False
        End If
    End Sub

    Private Sub SaleNOTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaleNOTextBox.GotFocus
        If SaleNOTextBox.Text = "Enter Sale Invoice No." Then
            SaleNOTextBox.Text = ""
            SaleNOTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SaleNOTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SaleNOTextBox.KeyDown
        If e.KeyCode = Keys.Enter And Me.SaleNOTextBox.Text.Length > 0 And SaleNOTextBox.Text <> "Enter Sale Invoice No." Then
            Me.Tbl_MM_SaleBindingSource.Filter = "SId =" & SaleNOTextBox.Text
            SaleNOTextBox.ForeColor = Color.Silver
            SaleNOTextBox.Clear()
            CMSaleNo.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Tbl_MM_SaleBindingSource.RemoveFilter()
    End Sub

    Private Sub SaleNOTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaleNOTextBox.LostFocus
        If SaleNOTextBox.Text = "" Then
            SaleNOTextBox.Text = "Enter Sale Invoice No."
            SaleNOTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub CustomerNameTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerNameTextBox.GotFocus
        If Me.CustomerNameTextBox.Text = "Enter Customer Name" Then
            Me.CustomerNameTextBox.Text = ""
            Me.CustomerNameTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CustomerNameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustomerNameTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.Tbl_MM_SaleBindingSource.Filter = "CustID =" & Me.Tbl_MM_CustomerTableAdapter.SelectCustNameQuery(Me.CustomerNameTextBox.Text) & ""
                Me.CustomerNameTextBox.Clear()
                Me.CMCustomerName.Hide()
            End If
        Catch ex As Exception
            MsgBox("Customer Name Not Match")
            Me.CustomerNameTextBox.Clear()
            Me.CustomerNameTextBox.Focus()
        End Try
    End Sub

    Private Sub CustomerNameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerNameTextBox.LostFocus
        If Me.CustomerNameTextBox.TextLength = 0 Then
            Me.CustomerNameTextBox.Text = "Enter Customer Name"
            Me.CustomerNameTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Me.Tbl_MM_SaleBindingSource.RemoveFilter()
    End Sub

    Private Sub Tbl_MM_SaleDetailDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_MM_SaleDetailDataGridView.CellContentClick

    End Sub

   
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        If frmLoginVer.DeptID = 24 Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptSale1.rpt"
        Else
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptSale.rpt"
        End If
        Filter = "{tbl_MM_Sale.SID} in " & Me.SaleIDLabel.Text & " to " & Me.SaleIDLabel.Text & ""
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub
End Class