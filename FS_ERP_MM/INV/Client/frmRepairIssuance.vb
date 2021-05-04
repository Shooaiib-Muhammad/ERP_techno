Public Class frmRepairIssuance

    'Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DSRepairIssuance)

    'End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSRepairIssuance.tbl_Inv_Tran_Date, CType(DateNameToolStripTextBox.Text, Date))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
    Private Sub frmRepairIssuance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRepairIssuance.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRepairIssuance.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSRepairIssuance.tbl_Inv_Supplier' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSRepairIssuance.tbl_Inv_Supplier)
        'TODO: This line of code loads data into the 'DSRepairIssuance.tbl_Inv_Tran_Out' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSRepairIssuance.tbl_Inv_Tran_Out)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSRepairIssuance.tbl_Inv_Tran_Date, Now.Date)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Dim I As Integer = Me.Tbl_Inv_Tran_OutBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSRepairIssuance.tbl_Inv_Tran_Out)
            Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSRepairIssuance.tbl_Inv_Tran_Out)
            Me.Tbl_Inv_Tran_OutBindingSource.Position = I
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If e.ColumnIndex = 5 Then
            If DataGridView1(5, e.RowIndex).Value Is DBNull.Value Then
                Me.DataGridView1(5, e.RowIndex).Value = Me.UnitLabel1.Text
                Me.DataGridView1(8, e.RowIndex).Value = Me.CPPULabel1.Text
                Me.DataGridView1(9, e.RowIndex).Value = Me.CurrencyLabel1.Text
            End If
        End If
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class