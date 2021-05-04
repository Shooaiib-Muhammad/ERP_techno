Public Class frmGDemandIssue
    'Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DSDemandOut)

    'End Sub



    Private Sub frmGDemandIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDemandOut.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSDemandOut.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSDemandOut.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.FillBy1(Me.DSDemandOut.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSDemandOut.tbl_Pur_Demand_Issuance' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_Demand_IssuanceTableAdapter.Fill(Me.DSDemandOut.tbl_Pur_Demand_Issuance)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSDemandOut.tbl_Inv_Tran_Date, Now.Date.AddYears(-1))
            Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.Validate()
            Me.Tbl_Pur_Demand_IssuanceBindingSource.EndEdit()
            Me.Tbl_Pur_Demand_IssuanceTableAdapter.Update(Me.DSDemandOut.tbl_Pur_Demand_Issuance)
            MsgBox("Records Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Pur_Demand_IssuanceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Pur_Demand_IssuanceDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Pur_Demand_IssuanceDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Pur_Demand_IssuanceDataGridView.CellEnter
        If e.ColumnIndex = 3 Then
            If Tbl_Pur_Demand_IssuanceDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Pur_Demand_IssuanceDataGridView(2, e.RowIndex).Value = Now.Date
            End If
        ElseIf e.ColumnIndex = 6 Then
            If Tbl_Pur_Demand_IssuanceDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Pur_Demand_IssuanceDataGridView(7, e.RowIndex).Value = Me.UnitLabel1.Text
            End If
        End If
    End Sub

    Private Sub Tbl_Pur_Demand_IssuanceDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Pur_Demand_IssuanceDataGridView.DataError

    End Sub

    Private Sub Tbl_Pur_Demand_IssuanceDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Pur_Demand_IssuanceDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class