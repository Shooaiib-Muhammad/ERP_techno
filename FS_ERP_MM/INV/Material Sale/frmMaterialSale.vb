Public Class frmMaterialSale
    Private Sub frmMaterialSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DsSaleIssuence.tbl_Inv_Rack_Info)
        Catch ex As Exception

        End Try
        'If frmLoginVer.DeptID = 1 Then
        '    Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DsSaleIssuence.tbl_Inv_Tran_Date)
        '    Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        'Else
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DsSaleIssuence.tbl_Inv_Tran_Date, CType(Now.Date, Date))
        Catch ex As System.Exception
        End Try
        'End If
        Try
            Me.View_MM_SaleTableAdapter.FillBy1(Me.DsSaleIssuence.View_MM_Sale)
        Catch ex As Exception
        End Try
        Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DsSaleIssuence.tbl_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
        Me.View_Customer_DTableAdapter.FillBy(Me.DsSaleIssuence.View_Customer_D, Me.L4NameComboBox.SelectedValue)
        Me.Tbl_Inv_Tran_OutBindingSource.MoveLast()
        If Me.DateNameLabel1.Text = Nothing Then
            ShowButtons(False, False)
        Else
            If Me.Tbl_Inv_Tran_OutBindingSource.Count > 0 Then
                ShowButtons(True, True)
            Else
                ShowButtons(True, False)
            End If
        End If
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub
    Sub ShowButtons(ByVal Add As Boolean, ByVal Delete As Boolean)
        AddSale.Visible = Add
        DeleteSale.Visible = Delete
        SaveSale.Visible = Delete
        UndoSale.Visible = Delete
        Me.L4NameComboBox.Enabled = Delete
    End Sub
    Sub Save(ByVal SaleQty As Double, ByVal TotalSaleQty As Double, ByVal ViewPosition As Integer)
        Dim Position As Integer = Me.Tbl_Inv_Tran_OutBindingSource.Position
        If Issued + SaleQty <= TotalSaleQty Then
            Try
                Me.Validate()
                Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
                Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DsSaleIssuence.tbl_Inv_Tran_Out)
                Me.View_MM_SaleTableAdapter.FillBy1(Me.DsSaleIssuence.View_MM_Sale)
                Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DsSaleIssuence.tbl_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
                Me.Tbl_Inv_Tran_OutBindingSource.Position = Position
                'To Update TrandocNo.                
                Me.Tbl_Inv_Tran_OutTableAdapter.UpdateQuery(Val(Me.TranOutIDLabel1.Text))
                MsgBox("Material Issued For Sale", MsgBoxStyle.Information)
                Me.View_Customer_DTableAdapter.FillBy(Me.DsSaleIssuence.View_Customer_D, Me.L4NameComboBox.SelectedValue)
                Me.View_Customer_DBindingSource.Position = ViewPosition
                If Issued >= TotalSaleQty Then
                    Me.View_Customer_DTableAdapter.UpdateQuery(True, Now.Date, Me.SIDLabel2.Text, SDNoLabel2.Text)
                End If
                Me.View_Customer_DTableAdapter.FillBy(Me.DsSaleIssuence.View_Customer_D, Me.L4NameComboBox.SelectedValue)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Dim btnMsg As DialogResult
            btnMsg = MessageBox.Show("Entered Quantity is Greater Than Sale Balance Quantity " & vbCrLf & "  Are You Sure Want To Save It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Try
                    Me.Validate()
                    Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
                    Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DsSaleIssuence.tbl_Inv_Tran_Out)
                    Me.View_MM_SaleTableAdapter.FillBy1(Me.DsSaleIssuence.View_MM_Sale)
                    Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DsSaleIssuence.tbl_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
                    Me.Tbl_Inv_Tran_OutBindingSource.Position = Position
                    'To Update TrandocN
                    Me.Tbl_Inv_Tran_OutTableAdapter.UpdateQuery(Val(Me.TranOutIDLabel1.Text))
                    MsgBox("Material Issued For Sale", MsgBoxStyle.Information)
                    Me.View_Customer_DTableAdapter.FillBy(Me.DsSaleIssuence.View_Customer_D, Me.L4NameComboBox.SelectedValue)
                    Me.View_Customer_DBindingSource.Position = ViewPosition
                    If Issued >= TotalSaleQty Then
                        Me.View_Customer_DTableAdapter.UpdateQuery(True, Now.Date, Me.SIDLabel2.Text, SDNoLabel2.Text)
                    End If
                    Me.View_Customer_DTableAdapter.FillBy(Me.DsSaleIssuence.View_Customer_D, Me.L4NameComboBox.SelectedValue)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Me.QtyTextBox.Clear()
                MsgBox("Record Not Saved")
            End If
        End If
    End Sub
    Dim Sqty, Issued As Double
    Private Sub QtyTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtyTextBox.TextChanged
        If QtyTextBox.TextLength > 0 Then
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.Simple
        Else
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objRptViewer As New Class_Utility
        Dim Filter As String = "{View_MM_SI_GP.DayNo} = " & Val(DayNoLabel1.Text) & " AND {View_MM_SI_GP.SID} = " & Val(SIDLabel2.Text)
        objRptViewer.LoadReports("\\Server\MyReports$\FSERPMM\Procurement\OtherMaterial\rptSaleGatePass.rpt", Filter, "")
    End Sub
    Private Sub View_Customer_DDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub
    Private Sub View_MM_SaleBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles View_MM_SaleBindingSource.PositionChanged
        Try
            Me.View_Customer_DTableAdapter.FillBy(Me.DsSaleIssuence.View_Customer_D, Me.L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub View_Customer_DDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Customer_DDataGridView.CellEnter
        Issued = Me.View_Customer_DDataGridView(8, e.RowIndex).Value
        If Me.View_Customer_DDataGridView(5, e.RowIndex).Value IsNot DBNull.Value Then
            Sqty = Me.View_Customer_DDataGridView(5, e.RowIndex).Value
        End If
        If QtyTextBox.TextLength <= 0 Then
            Me.SIDLabel2.Text = Me.View_Customer_DDataGridView(1, e.RowIndex).Value
            Me.SDNoLabel2.Text = Me.View_Customer_DDataGridView(2, e.RowIndex).Value
            Me.CurrencyLabel1.Text = Me.View_Customer_DDataGridView(3, e.RowIndex).Value
            Me.CPPULabel1.Text = Me.View_Customer_DDataGridView(4, e.RowIndex).Value
            Me.UOMLabel1.Text = Me.View_Customer_DDataGridView(6, e.RowIndex).Value
            Me.CustIDLabel1.Text = Me.View_Customer_DDataGridView(9, e.RowIndex).Value
        End If
    End Sub

    Private Sub AddSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSale.Click
        Try
            Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
            Me.View_MM_SaleTableAdapter.FillBy(Me.DsSaleIssuence.View_MM_Sale)
        Catch ex As Exception
        End Try
        ShowButtons(True, True)
    End Sub

    Private Sub DeleteSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSale.Click
        Dim position As Integer = Me.Tbl_Inv_Tran_OutBindingSource.Position
        Dim btnMsg As DialogResult
        btnMsg = MessageBox.Show("Are You Sure Want To Delete It?......", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Try
                Me.Tbl_Inv_Tran_OutTableAdapter.DeleteQuery(Me.TranOutIDLabel1.Text, SIDLabel2.Text, SDNoLabel2.Text)
                Me.View_Customer_DTableAdapter.UpdateDateQuery(False, Me.SIDLabel2.Text, SDNoLabel2.Text)
                Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DsSaleIssuence.tbl_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
                Me.View_Customer_DTableAdapter.FillBy(Me.DsSaleIssuence.View_Customer_D, Me.L4NameComboBox.SelectedValue)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If
        Me.Tbl_Inv_Tran_OutBindingSource.Position = position
        If TranOutIDLabel1.Text = "" Then
            ShowButtons(True, False)
        Else
            ShowButtons(True, True)
        End If
    End Sub

    Private Sub SaveSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSale.Click
        Dim PositionOut As Integer = Me.Tbl_Inv_Tran_OutBindingSource.Position
        Dim ViewPosition As Integer = Me.View_Customer_DBindingSource.Position
        Dim MatBalance As Double = Me.View_Inv_Mat_AvailableTableAdapter.ScalarQuery(Me.L4NameComboBox.SelectedValue)
        If MatBalance > 0 Then
            If Val(Me.QtyTextBox.Text) <= MatBalance Then
                Save(Val(Me.QtyTextBox.Text), Sqty, ViewPosition)
            Else
                MsgBox("Entered Quantity Is Greater Than Available Material Balance")
                Me.QtyTextBox.Text = MatBalance
                Save(MatBalance, Sqty, ViewPosition)
            End If
        Else
            MsgBox("Available Material Balance Is Nill", MsgBoxStyle.Critical)
            Me.QtyTextBox.Clear()
            Me.UndoSale_Click(Nothing, Nothing)
        End If
        Me.Tbl_Inv_Tran_OutBindingSource.Position = PositionOut
    End Sub

    Private Sub UndoSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoSale.Click
        Me.View_MM_SaleTableAdapter.FillBy1(Me.DsSaleIssuence.View_MM_Sale)
        Me.Tbl_Inv_Tran_OutBindingSource.CancelEdit()
        If TranOutIDLabel1.Text = "" Then
            ShowButtons(True, False)
        Else
            ShowButtons(True, True)
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DsSaleIssuence.tbl_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
    End Sub

    Private Sub View_Customer_DDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles View_Customer_DDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class