Public Class frmLOMRec

    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSLOM)

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      

    End Sub

    Private Sub frmLOMRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSLOM.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSLOM.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSLOM.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSLOM.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSLOM.tbl_Inv_Tran_In' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSLOM.tbl_Inv_Tran_Date, Now.Date.AddDays(-7))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Me.Tbl_Inv_Tran_InTableAdapter.FillBy(Me.DSLOM.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim j As Integer = Me.Tbl_Inv_Tran_InBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSLOM.tbl_Inv_Tran_In)
            LoadData()
            Me.Tbl_Inv_Tran_InBindingSource.Position = j
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        LoadData()
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellEnter
        If e.ColumnIndex = 6 Then
            If Me.Tbl_Inv_Tran_InDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Tran_InDataGridView(6, e.RowIndex).Value = UnitLabel1.Text
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Tran_InDataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Tran_InDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class