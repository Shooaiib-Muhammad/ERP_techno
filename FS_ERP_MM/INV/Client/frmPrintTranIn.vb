Public Class frmPrintTranIn
    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.Tbl_Inv_Tran_DateTableAdapter.Update(Me.DSNewTranIn.tbl_Inv_Tran_Date)

    End Sub



    Private Sub frmPrintTranIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSNewTranIn.tbl_In_Tran_PrintRec' table. You can move, or remove it, as needed.
        Me.Tbl_In_Tran_PrintRecTableAdapter.Fill(Me.DSNewTranIn.tbl_In_Tran_PrintRec)
        'TODO: This line of code loads data into the 'DSNewTranIn.tbl_Inv_L4' table. You can move, or remove it, as needed.
        If frmLoginVer.DeptID = 24 Then
            Me.Tbl_Inv_L4TableAdapter.FillBy1(Me.DSNewTranIn.tbl_Inv_L4)
        Else
            Me.Tbl_Inv_L4TableAdapter.FillBy2(Me.DSNewTranIn.tbl_Inv_L4)
        End If
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSNewTranIn.tbl_Inv_Tran_Date, CType(Now.Date.AddDays(-15), Date))
        Catch ex As System.Exception
        End Try

        'Me.Tbl_Inv_Tran_InBindingSource.Filter = "TranType='MBRN'"
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub

    Private Sub Tbl_In_Tran_PrintRecDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_In_Tran_PrintRecDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_In_Tran_PrintRecDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_In_Tran_PrintRecDataGridView.CellEnter
        If e.ColumnIndex = 6 Then
            If Tbl_In_Tran_PrintRecDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Tbl_In_Tran_PrintRecDataGridView(6, e.RowIndex).Value = UnitLabel2.Text
            End If
        End If
    End Sub

    Private Sub Tbl_In_Tran_PrintRecDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_In_Tran_PrintRecDataGridView.DataError

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Dim k As Int16 = Me.Tbl_In_Tran_PrintRecBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_In_Tran_PrintRecBindingSource.EndEdit()
            Me.Tbl_In_Tran_PrintRecTableAdapter.Update(Me.DSNewTranIn.tbl_In_Tran_PrintRec)
            Me.Tbl_In_Tran_PrintRecTableAdapter.Fill(Me.DSNewTranIn.tbl_In_Tran_PrintRec)
            Me.Tbl_In_Tran_PrintRecBindingSource.Position = k
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_In_Tran_PrintRecDataGridView_DockChanged(sender As Object, e As EventArgs) Handles Tbl_In_Tran_PrintRecDataGridView.DockChanged

    End Sub

    Private Sub Tbl_In_Tran_PrintRecDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_In_Tran_PrintRecDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class