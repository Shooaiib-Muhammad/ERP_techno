Public Class frmPassBaladerRec

    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSPassBladder)

    End Sub

    Private Sub frmPassBaladerRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRepairBalderRec.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRepairBalderRec.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSPassBladder.tbl_Inv_Tran_In' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSPassBladder.tbl_Inv_Tran_In)
        'TODO: This line of code loads data into the 'DSPassBladder.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DSPassBladder.tbl_Inv_Tran_Date)
        Me.Tbl_Inv_Tran_DateBindingSource.Sort = "DateName ASC"
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSPassBladder.tbl_Inv_Tran_In)
            Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSPassBladder.tbl_Inv_Tran_In)
            MsgBox("Record Saved Successfully")
            Me.Tbl_Inv_Tran_InBindingSource.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellEnter
        If e.ColumnIndex >= 2 Then
            If Me.Tbl_Inv_Tran_InDataGridView(10, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Tran_InDataGridView(10, e.RowIndex).Value = Now.Date
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