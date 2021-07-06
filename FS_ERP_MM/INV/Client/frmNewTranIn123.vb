Public Class frmNewTranIn
    Private Sub frmNewTranIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSLOM.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSLOM.tbl_Pur_UnitOfMeasurement)
        Try
            Me.Tbl_Inv_L4TableAdapter.FillBy3(Me.DSNewTranIn.tbl_Inv_L4)
        Catch ex As Exception

        End Try
        Try
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSMat_Brow.tbl_Inv_Rack_Info)
        Catch ex As Exception

        End Try
        'Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSNewTranIn.tbl_Inv_Supplier)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSNewTranIn.tbl_Inv_LocalCust)
        Me.Tbl_Inv_Tran_InTableAdapter.FillBy4(Me.DSNewTranIn.tbl_Inv_Tran_In)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSNewTranIn.tbl_Inv_Tran_Date, CType(Now.Date, Date))
        Catch ex As System.Exception
        End Try
        Me.Tbl_Inv_Tran_InBindingSource.Filter = "TranType='STOCK'"
    End Sub
    Sub Save()
        Me.Validate()
        Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
        Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSNewTranIn.tbl_Inv_Tran_In)
    End Sub
    Dim Deleteflag As Boolean = False
    Sub SaveRecord()
        If Deleteflag = False Then
            Save()
            MsgBox("Record Saved Successfully", MsgBoxStyle.OkOnly)
            Me.Tbl_Inv_Tran_InTableAdapter.FillBy4(Me.DSNewTranIn.tbl_Inv_Tran_In)
        Else
            Save()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.OkOnly)
            Me.Tbl_Inv_Tran_InTableAdapter.FillBy4(Me.DSNewTranIn.tbl_Inv_Tran_In)
            Deleteflag = False
        End If
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveRecord()
    End Sub
    Private Sub Tbl_Inv_Tran_InDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellEnter
        If Tbl_Inv_Tran_InDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
            Me.Tbl_Inv_Tran_InDataGridView(1, e.RowIndex).Value = "STOCK"
        End If
        If e.ColumnIndex = 7 Then
            If Me.CPPULabel1.Text = Nothing Then
                CPPULabel1.Text = 0
            End If
            Me.Tbl_Inv_Tran_InDataGridView(4, e.RowIndex).Value = Me.CPPULabel1.Text
            Me.Tbl_Inv_Tran_InDataGridView(6, e.RowIndex).Value = Me.CurrencyLabel1.Text
            Me.Tbl_Inv_Tran_InDataGridView(7, e.RowIndex).Value = Me.UnitLabel1.Text
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Tran_InDataGridView.DataError

    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Deleteflag = True
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Tran_InDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub Tbl_Inv_Tran_InDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 9 Then
                SaveRecord()
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellContentClick

    End Sub


End Class