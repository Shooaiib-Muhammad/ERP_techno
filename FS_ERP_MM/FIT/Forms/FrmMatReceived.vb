Public Class FrmMatReceived
    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSFIT)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrmMatReceived_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Test_Catalogs' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_Test_CatalogsTableAdapter.FillBy(Me.DSFIT.Tbl_Fit_Test_Catalogs)
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Test_Transaction' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_Test_TransactionTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Test_Transaction)
        'TODO: This line of code loads data into the 'DSFIT.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSFIT.tbl_Pur_UnitOfMeasurement)
        'TODO: This line of code loads data into the 'DSFIT.tbl_Inv_Supplier' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSFIT.tbl_Inv_Supplier)
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Material' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_MaterialTableAdapter.FillBy(Me.DSFIT.Tbl_Fit_Material)
        Try
            If Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSFIT.tbl_Inv_Tran_Date, Now.Date) > 0 Then
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSFIT.tbl_Inv_Tran_Date, Now.Date.AddDays(-30))
            Else
                Me.Tbl_Inv_Tran_DateTableAdapter.Insert(Now.Date)
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSFIT.tbl_Inv_Tran_Date, Now.Date.AddDays(-30))
            End If
        Catch ex As System.Exception
            'MsgBox(ex.Message)
        End Try
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Material_Received' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_Material_ReceivedTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Material_Received)
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim j As Int16 = Me.Tbl_Fit_Material_ReceivedBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Fit_Material_ReceivedBindingSource.EndEdit()
            Me.Tbl_Fit_Material_ReceivedTableAdapter.Update(Me.DSFIT.Tbl_Fit_Material_Received)
            Me.Tbl_Fit_Material_ReceivedTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Material_Received)
            Me.Tbl_Fit_Material_ReceivedBindingSource.Position = j
            MessageBox.Show("Record Save", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Fit_Material_ReceivedDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Fit_Material_ReceivedDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Fit_Material_ReceivedDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Fit_Material_ReceivedDataGridView.DataError

    End Sub

    Private Sub Tbl_Fit_Material_ReceivedDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Fit_Material_ReceivedDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub

    Private Sub Tbl_Fit_Test_TransactionDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Fit_Test_TransactionDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Fit_Test_TransactionDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Fit_Test_TransactionDataGridView.DataError

    End Sub

    Private Sub Tbl_Fit_Test_TransactionDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Fit_Test_TransactionDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub

    Private Sub Tbl_Fit_Test_TransactionDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Fit_Test_TransactionDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            If Me.Tbl_Fit_Test_TransactionDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Fit_Test_TransactionDataGridView(0, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        Dim j As Int16 = Me.Tbl_Fit_Test_TransactionBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Fit_Test_TransactionBindingSource.EndEdit()
            Me.Tbl_Fit_Test_TransactionTableAdapter.Update(Me.DSFIT.Tbl_Fit_Test_Transaction)
            Me.Tbl_Fit_Test_TransactionTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Test_Transaction)
            Me.Tbl_Fit_Test_TransactionBindingSource.Position = j
            MessageBox.Show("Record Save", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try

    End Sub
End Class