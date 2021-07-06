Public Class frmMatAdjustment
    Private Sub frmAdjEntery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmLoginVer.UserID = 184 Or frmLoginVer.UserID = 69 Then
            Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DsAdjustEnteries.tbl_Inv_L4)
        Else
            Try
                Me.Tbl_Inv_L4TableAdapter.Fill(Me.DsAdjustEnteries.tbl_Inv_L4)
            Catch ex As Exception

            End Try
        End If

        Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DsAdjustEnteries.tbl_Inv_Tran_Out)
        Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DsAdjustEnteries.tbl_Inv_Tran_In)
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DsAdjustEnteries.tbl_Inv_Tran_Date, Now.Date.AddDays(-8))
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub
    Private Sub Tbl_Inv_Tran_InDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellEnter
        If e.ColumnIndex = 6 Then
            If Tbl_Inv_Tran_InDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Inv_Tran_InDataGridView(4, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.CurencyQuery(Me.Tbl_Inv_Tran_InDataGridView(3, e.RowIndex).Value)
                    Me.Tbl_Inv_Tran_InDataGridView(5, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.CPPUQuery(Me.Tbl_Inv_Tran_InDataGridView(3, e.RowIndex).Value)
                    Me.Tbl_Inv_Tran_InDataGridView(6, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.UOMQuery(Me.Tbl_Inv_Tran_InDataGridView(3, e.RowIndex).Value)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Private Sub Tbl_Inv_Tran_InDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Tran_InDataGridView.DataError

    End Sub
    Private Sub Tbl_Inv_Tran_OutDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.CellEnter
        If e.ColumnIndex = 6 Then
            If Tbl_Inv_Tran_OutDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Inv_Tran_OutDataGridView(4, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.CurencyQuery(Me.Tbl_Inv_Tran_OutDataGridView(3, e.RowIndex).Value)
                    Me.Tbl_Inv_Tran_OutDataGridView(5, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.CPPUQuery(Me.Tbl_Inv_Tran_OutDataGridView(3, e.RowIndex).Value)
                    Me.Tbl_Inv_Tran_OutDataGridView(6, e.RowIndex).Value = Me.Tbl_Inv_L4TableAdapter.UOMQuery(Me.Tbl_Inv_Tran_OutDataGridView(3, e.RowIndex).Value)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Private Sub Tbl_Inv_Tran_OutDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.DataError
    End Sub
    Sub SaveRecordIn()
        Me.Validate()
        Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
        Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DsAdjustEnteries.tbl_Inv_Tran_In)
        Me.Tbl_Inv_Tran_InTableAdapter.FillBy(Me.DsAdjustEnteries.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
    End Sub
    Sub SaveRecordOut()
        Try
            Me.Validate()
            Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DsAdjustEnteries.tbl_Inv_Tran_Out)
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DsAdjustEnteries.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Tbl_Inv_Tran_InDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Tran_InDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub Tbl_Inv_Tran_OutDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub Tbl_Inv_Tran_InDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 8 Then
                SaveRecordIn()
            End If
        End If
    End Sub
    Private Sub Tbl_Inv_Tran_OutDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 8 Then
                SaveRecordOut()
            End If
        End If
    End Sub
    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        SaveRecordIn()
        MsgBox("Positive Record Saved Successfully")
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveRecordOut()
        MsgBox("Negative Record Saved Successfully")
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Tran_OutDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.CellContentClick

    End Sub
End Class