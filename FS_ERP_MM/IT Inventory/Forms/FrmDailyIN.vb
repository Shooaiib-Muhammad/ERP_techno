Public Class FrmDailyIN




    Private Sub FrmDailyIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSIT.tbl_Vendors' table. You can move, or remove it, as needed.
        Me.Tbl_VendorsTableAdapter.Fill(Me.DSIT.tbl_Vendors)
        'TODO: This line of code loads data into the 'DSFIT.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSFIT.tbl_Pur_UnitOfMeasurement)
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Material' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_MaterialTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Material)
        'TODO: This line of code loads data into the 'DSIT.Tbl_Fit_Material_Received' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_Material_ReceivedTableAdapter.Fill(Me.DSIT.Tbl_Fit_Material_Received)
        Try
            If Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSIT.tbl_Inv_Tran_Date, Now.Date) > 0 Then
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSIT.tbl_Inv_Tran_Date, Now.Date.AddDays(-30))
            Else
                Me.Tbl_Inv_Tran_DateTableAdapter.Insert(Now.Date)
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSIT.tbl_Inv_Tran_Date, Now.Date.AddDays(-30))
            End If
        Catch ex As System.Exception
            'MsgBox(ex.Message)
        End Try
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Material_Received' table. You can move, or remove it, as needed.

        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim j As Int16 = Me.Tbl_Fit_Material_ReceivedBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Fit_Material_ReceivedBindingSource.EndEdit()
            Me.Tbl_Fit_Material_ReceivedTableAdapter.Update(Me.DSIT.Tbl_Fit_Material_Received)
            Me.Tbl_Fit_Material_ReceivedTableAdapter.Fill(Me.DSIT.Tbl_Fit_Material_Received)
            Me.Tbl_Fit_Material_ReceivedBindingSource.Position = j
            MessageBox.Show("Record Save", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Fit_Material_ReceivedDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Fit_Material_ReceivedDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Fit_Material_ReceivedDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Fit_Material_ReceivedDataGridView.DataError

    End Sub

    Private Sub Tbl_Fit_Material_ReceivedDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Fit_Material_ReceivedDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Tbl_Fit_Material_ReceivedBindingSource.RemoveCurrent()
    End Sub
End Class