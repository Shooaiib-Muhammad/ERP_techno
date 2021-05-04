Public Class frmWindedBladderProcess

    Private Sub frmWindedBladderProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Winded_ExectNameTableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Winded_ExectName)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Inv_L4)
        Me.Tbl_Bladder_Winded_ProcessTableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Bladder_Winded_Process)
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Inv_Tran_Date, Now.Date)
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Bladder_Winded_ProcessBindingSource.EndEdit()
            Me.Tbl_Bladder_Winded_ProcessTableAdapter.Update(Me.DSWindedBladderIssuance.tbl_Bladder_Winded_Process)
            Me.Tbl_Bladder_Winded_ProcessTableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Bladder_Winded_Process)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Bladder_Winded_ProcessDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bladder_Winded_ProcessDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Bladder_Winded_ProcessDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bladder_Winded_ProcessDataGridView.CellEnter
        'If e.ColumnIndex = 6 Then
        '    If Me.Tbl_Bladder_Winded_ProcessDataGridView(6, e.RowIndex).Value = 0 Then
        '        Me.Tbl_Bladder_Winded_ProcessDataGridView(6, e.RowIndex).Value = Me.Tbl_Bladder_Winded_ProcessDataGridView(5, e.RowIndex).Value
        '    End If
        'End If
    End Sub

    Private Sub Tbl_Bladder_Winded_ProcessDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Bladder_Winded_ProcessDataGridView.DataError

    End Sub

    Private Sub Tbl_Bladder_Winded_ProcessDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Bladder_Winded_ProcessDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Obj As New Class_Utility
        Dim Filter As String = "{View_MM_TransferPass.DayNo}= " & Val(DayNoLabel1.Text) & " "
        Obj.LoadReports("\\server\myreports$\FSERPMM\Bladders\RptBladderTransfPass.rpt", Filter, "")
    End Sub
End Class