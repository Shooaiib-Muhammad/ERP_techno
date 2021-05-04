Public Class FrmRepaireBladderRec
    Private Sub FrmRepaireBladderRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSRepairBladderRec.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRepairBladderRec.tbl_Inv_L4)
        Me.Tbl_Bladder_RecTableAdapter.Fill(Me.DSRepairBladderRec.tbl_Bladder_Rec)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSRepairBladderRec.tbl_Inv_Tran_Date, CType(Now.Date, Date))
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub Tbl_Bladder_RecDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bladder_RecDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Bladder_RecDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Bladder_RecDataGridView.DataError

    End Sub

    Private Sub Tbl_Bladder_RecDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Bladder_RecDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim I As Integer = Me.Tbl_Bladder_RecBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Bladder_RecBindingSource.EndEdit()
            Me.Tbl_Bladder_RecTableAdapter.Update(Me.DSRepairBladderRec.tbl_Bladder_Rec)
            Me.Tbl_Bladder_RecTableAdapter.Fill(Me.DSRepairBladderRec.tbl_Bladder_Rec)
            Me.Tbl_Bladder_RecBindingSource.Position = I
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class