Public Class frmCustBladderFormula

    Private Sub frmCustBladderFormula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSCustBlader.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSCustBlader.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSCustBlader.tbl_Cust_Bladder_Formula' table. You can move, or remove it, as needed.
        Me.Tbl_Cust_Bladder_FormulaTableAdapter.Fill(Me.DSCustBlader.tbl_Cust_Bladder_Formula)
        'TODO: This line of code loads data into the 'DSCustBlader.tbl_MM_Customer' table. You can move, or remove it, as needed.
        Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSCustBlader.tbl_MM_Customer)

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim i As Integer = Me.Tbl_Cust_Bladder_FormulaBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Cust_Bladder_FormulaBindingSource.EndEdit()
            Me.Tbl_Cust_Bladder_FormulaTableAdapter.Update(Me.DSCustBlader.tbl_Cust_Bladder_Formula)
            Me.Tbl_Cust_Bladder_FormulaTableAdapter.Fill(Me.DSCustBlader.tbl_Cust_Bladder_Formula)
            Me.Tbl_Cust_Bladder_FormulaBindingSource.Position = i
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Cust_Bladder_FormulaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Cust_Bladder_FormulaDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Cust_Bladder_FormulaDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Cust_Bladder_FormulaDataGridView.DataError

    End Sub

    Private Sub Tbl_Cust_Bladder_FormulaDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Cust_Bladder_FormulaDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class