Public Class FrmScrapSale
    Private Sub SaveRecord()
        Dim Position As Integer = Me.Tbl_Inv_Tran_OutBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSSSGP.tbl_Inv_Tran_Out)
            Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSSSGP.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
            Me.Tbl_Inv_Tran_OutBindingSource.Position = Position
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingNavigatorSaveItem.Click
        SaveRecord()
    End Sub
    Private Sub ReqDateTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ReqDateTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.Tbl_Inv_Tran_DateBindingSource.Filter = "DateName ='" & Me.ReqDateTextBox.Text & "'"
                Try
                    Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSSSGP.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
                Catch ex As Exception
                End Try
                Me.ReqDateTextBox.Clear()
                Me.CMReqDate.Hide()
            End If
        Catch ex As Exception
            MsgBox("Enter Date In Correct Formate")
            Me.ReqDateTextBox.Clear()
            Me.ReqDateTextBox.Focus()
        End Try
    End Sub

    Private Sub FrmScrapSale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then    'Ctrl+S For Save

            SaveRecord()
        End If
    End Sub

    Private Sub FrmScrapSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSSSGP.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSSSGP.tbl_Pur_UnitOfMeasurement)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSSSGP.tbl_Inv_Tran_Date)
            Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'TODO: This line of code loads data into the 'DSSSGP.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSSSGP.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSSSGP.tbl_Vendor_Info' table. You can move, or remove it, as needed.
        'Me.Tbl_Vendor_InfoTableAdapter.Fill(Me.DSSSGP.tbl_Vendor_Info)
        'TODO: This line of code loads data into the 'DSSSGP.tbl_Inv_Tran_Out' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSSSGP.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
        KeyPreview = True
    End Sub
    Dim obj As New Class_Utility
    Private Sub Tbl_Inv_Tran_OutDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.CellContentClick

        If e.ColumnIndex = 10 Then

            obj.LoadReports("\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptMatOutwardSaleGatePassScrap.rpt", "{View_Mat_Sale.TranOutID}= " & Me.Tbl_Inv_Tran_OutDataGridView(1, e.RowIndex).Value & "", "")
            'Filter = "{View_Mat_Sale.TranOutID}in " & Me.TranOutIDComboBox.SelectedValue & " to " & Me.TranOutIDComboBox1.SelectedValue & ""
            'Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptMatOutwardSaleGatePass.rpt"+
        ElseIf e.ColumnIndex = 11 Then
            'Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptSale.rpt"
            'Filter = "{tbl_MM_Sale.SID} in " & Me.SIDComboBox.SelectedValue & " to " & Me.SIDComboBox1.SelectedValue & ""
            obj.LoadReports("\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptSaleScrap.rpt", "{tbl_Inv_Tran_Out.TranOutID}= " & Me.Tbl_Inv_Tran_OutDataGridView(1, e.RowIndex).Value & "", "")
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_OutDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.CellEnter
        If e.ColumnIndex >= 7 Then
            If Me.Tbl_Inv_Tran_OutDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Tran_OutDataGridView(7, e.RowIndex).Value = UnitLabel1.Text
            End If
            If Me.Tbl_Inv_Tran_OutDataGridView(8, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_Tran_OutDataGridView(8, e.RowIndex).Value = Me.CPPULabel1.Text
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_OutDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_Tran_OutDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
            Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSSSGP.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_Inv_Tran_DateBindingSource.RemoveFilter()
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Try
            Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSSSGP.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ReqDateTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReqDateTextBox.Click

    End Sub
End Class