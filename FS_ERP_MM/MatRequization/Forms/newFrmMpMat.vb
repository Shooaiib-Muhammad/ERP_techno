Public Class newFrmMpMat
    Private Sub newFrmMpMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMPMat.tbl_Prd_Lines' table. You can move, or remove it, as needed.
        Me.Tbl_Prd_LinesTableAdapter.Fill(Me.DSMPMat.tbl_Prd_Lines)
        'TODO: This line of code loads data into the 'DSMPMat.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSMPMat.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSMPMat.tbl_Inv_Requisition' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSMPMat.tbl_Inv_Requisition)
        'TODO: This line of code loads data into the 'DSMPMat.tbl_Pur_UnitOfMeasurement1' table. You can move, or remove it, as needed.
        'Me.Tbl_Pur_UnitOfMeasurement1TableAdapter.Fill(Me.DSMPMat.tbl_Pur_UnitOfMeasurement1)
        'TODO: This line of code loads data into the 'DSMPMat.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        'Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSMPMat.tbl_Pur_UnitOfMeasurement)
        'TODO: This line of code loads data into the 'DSMPMat.tbl_Pro_Material' table. You can move, or remove it, as needed.
        'Me.Tbl_Pro_MaterialTableAdapter.Fill(Me.DSMPMat.tbl_Pro_Material)
        'TODO: This line of code loads data into the 'DSMPMat.tbl_MPNO_Wise_Material' table. You can move, or remove it, as needed.
        'Me.Tbl_MPNO_Wise_MaterialTableAdapter.Fill(Me.DSMPMat.tbl_MPNO_Wise_Material)
        'TODO: This line of code loads data into the 'DSMPMat.view_Plan' table. You can move, or remove it, as needed.
        load()

    End Sub
    Private Sub load()
        Me.View_PlanTableAdapter.Fill(Me.DSMPMat.view_Plan, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_RequisitionBindingSource.EndEdit()
            Me.Tbl_Inv_RequisitionTableAdapter.Update(DSMPMat.tbl_Inv_Requisition)
            Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSMPMat.tbl_Inv_Requisition)
            MsgBox("Material Saved")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_MPNO_Wise_MaterialDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Tbl_MPNO_Wise_MaterialDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub Tbl_Inv_RequisitionDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Inv_RequisitionDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_RequisitionDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Inv_RequisitionDataGridView.CellEnter
        If e.ColumnIndex = 2 Then
            If Me.Tbl_Inv_RequisitionDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_RequisitionDataGridView(2, e.RowIndex).Value = Now.Date

            End If
            If Me.Tbl_Inv_RequisitionDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_RequisitionDataGridView(7, e.RowIndex).Value = Now.Date

            End If
            If Me.Tbl_Inv_RequisitionDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
                If Me.Tbl_Inv_RequisitionDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_Inv_RequisitionDataGridView(5, e.RowIndex).Value = UnitLabel1.Text

                End If
            End If

        End If
    End Sub

    Private Sub Tbl_Inv_RequisitionDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_RequisitionDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub

    Private Sub Tbl_Inv_RequisitionDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Inv_RequisitionDataGridView.DataError

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        load()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        load()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objFrmFilter As New frmRptViewer

        Filter = "{View_Pro_Plan_MPNO.MPID} = " & MPIDComboBox.Text & ""
        objFrmFilter.ViewReport("\\Server\MyReports$\FSERPMM\Inventory\ManualRequisition.rpt", Filter)
        objFrmFilter.MdiParent = frmMain
        objFrmFilter.Show()
    End Sub
End Class