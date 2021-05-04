Public Class frmBladderRepairIssuance

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Obj As New Class_Utility
        Dim Filter As String = "{View_MM_TransferPass.DayNo}= " & Val(DayNoLabel1.Text) & " "
        Obj.LoadReports("\\server\myreports$\FSERPMM\Bladders\RptPuncturedBladderTransfPass.rpt", Filter, "")
    End Sub

    Private Sub frmBladderRepairIssuance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Bladder_Repair_Out11TableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Bladder_Repair_Out11)
        Me.Tbl_Bladder_Winded_Process11TableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Bladder_Winded_Process11)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Inv_Supplier)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Inv_L4)
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Inv_Tran_Date, Now.Date)
    End Sub
    Dim btnMsg As DialogResult
    Private Sub Tbl_Bladder_Winded_Process11DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bladder_Winded_Process11DataGridView.CellContentClick
        If e.ColumnIndex = 11 Then
            btnMsg = MessageBox.Show("Are You Sure Want To Issue Selected Bladder For Repairing? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Dim EnterQty As Double = 0.0
                If Me.Tbl_Bladder_Winded_Process11DataGridView(10, e.RowIndex).Value > 0 Then
                    EnterQty = CDbl(Me.Tbl_Bladder_Winded_Process11DataGridView(10, e.RowIndex).Value)
                Else
                    EnterQty = CDbl(Me.Tbl_Bladder_Winded_Process11DataGridView(6, e.RowIndex).Value)
                End If
                Me.Tbl_Bladder_Repair_OutTableAdapter.Insert(Me.DayNoLabel1.Text, Me.Tbl_Bladder_Winded_Process11DataGridView(1, e.RowIndex).Value, "BIR", Me.Tbl_Bladder_Winded_Process11DataGridView(4, e.RowIndex).Value, EnterQty, Me.Tbl_Bladder_Winded_Process11DataGridView(9, e.RowIndex).Value, Now.Date, False)
                If EnterQty >= CDbl(Me.Tbl_Bladder_Winded_Process11DataGridView(6, e.RowIndex).Value) Then
                    Me.Tbl_Bladder_Repair_OutTableAdapter.UpdateQuery(True, Me.Tbl_Bladder_Winded_Process11DataGridView(1, e.RowIndex).Value)
                End If
                Me.Tbl_Bladder_Winded_Process11TableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Bladder_Winded_Process11)
                Me.Tbl_Bladder_Repair_Out11TableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Bladder_Repair_Out11)
            End If
        End If
    End Sub

    Private Sub Tbl_Bladder_Winded_Process11DataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Bladder_Winded_Process11DataGridView.DataError

    End Sub

    Private Sub Tbl_Bladder_Winded_Process11DataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Bladder_Winded_Process11DataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub Tbl_Bladder_Repair_Out11DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bladder_Repair_Out11DataGridView.CellContentClick
        If e.ColumnIndex = 9 Then
            btnMsg = MessageBox.Show("Are You Sure Want Undo To Selected Bladder Repairing Transactions? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Me.Tbl_Bladder_Repair_OutTableAdapter.DeleteQuery(Me.Tbl_Bladder_Repair_Out11DataGridView(2, e.RowIndex).Value)
                Me.Tbl_Bladder_Repair_OutTableAdapter.UpdateQuery(False, Me.Tbl_Bladder_Repair_Out11DataGridView(0, e.RowIndex).Value)
                Me.Tbl_Bladder_Winded_Process11TableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Bladder_Winded_Process11)
                Me.Tbl_Bladder_Repair_Out11TableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Bladder_Repair_Out11)
            End If
        End If
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click

    End Sub
End Class