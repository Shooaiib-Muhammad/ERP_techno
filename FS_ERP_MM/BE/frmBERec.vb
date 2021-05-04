Public Class frmBERec
    Private Sub Tbl_BE_DetailDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_BE_DetailDataGridView.CellEnter
        If e.ColumnIndex = 4 Then
            If Me.Tbl_BE_DetailDataGridView(3, e.RowIndex).Value IsNot DBNull.Value Then
                Me.Tbl_BE_DetailDataGridView(1, e.RowIndex).Value = DayNoLabel1.Text
            End If
        End If
    End Sub

    Private Sub Tbl_BE_DetailDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_BE_DetailDataGridView.DataError

    End Sub

    Private Sub Tbl_BE_DetailDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_BE_DetailDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub frmBERec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_BE_Head1TableAdapter.Fill(Me.DSBERec.tbl_BE_Head1)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSBERec.tbl_Inv_Supplier)
        Me.Tbl_Pro_CountryTableAdapter.Fill(Me.DSBERec.tbl_Pro_Country)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSBERec.tbl_Inv_L4)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSBERec.tbl_Inv_Tran_Date, Now.Date.AddDays(-30))
            Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_BE_DetailTableAdapter.Fill(Me.DSBERec.tbl_BE_Detail)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Tbl_BE_HeadTableAdapter.Fill(Me.DSBERec.tbl_BE_Head)
    End Sub

    Private Sub Tbl_BE_HeadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_BE_HeadBindingNavigatorSaveItem.Click
        Dim i As Integer = Me.Tbl_BE_HeadBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_BE_HeadBindingSource.EndEdit()
            Me.Tbl_BE_HeadTableAdapter.Update(Me.DSBERec.tbl_BE_Head)
            Me.Tbl_BE_HeadTableAdapter.Fill(Me.DSBERec.tbl_BE_Head)
            Me.Tbl_BE_HeadBindingSource.Position = i
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim i As Integer = Me.Tbl_BE_DetailBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_BE_DetailBindingSource.EndEdit()
            Me.Tbl_BE_DetailTableAdapter.Update(Me.DSBERec.tbl_BE_Detail)
            Me.Tbl_BE_DetailTableAdapter.Fill(Me.DSBERec.tbl_BE_Detail)
            Me.Tbl_BE_DetailBindingSource.Position = i
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_BE_DetailDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_BE_DetailDataGridView.CellContentClick

    End Sub

    Private Sub BETextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BETextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_BE_Head1BindingSource.Filter = "BENumber='" & Me.BETextBox.Text & "'"
            Me.Tbl_Inv_Tran_DateBindingSource.Filter = "DayNo=" & Me.DayIdLabel1.Text & ""
            Me.Tbl_BE_HeadBindingSource.Filter = "BEId=" & Me.BEIdLabel3.Text & ""
            Me.BETextBox.Text = Nothing
            Me.CMBESearch.Hide()
        End If
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_Inv_Tran_DateBindingSource.RemoveFilter()
        Me.Tbl_BE_HeadBindingSource.RemoveFilter()
        Me.Tbl_BE_Head1BindingSource.RemoveFilter()
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub
End Class