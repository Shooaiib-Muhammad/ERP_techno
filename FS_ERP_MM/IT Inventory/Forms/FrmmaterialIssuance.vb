Public Class FrmmaterialIssuance




    Private Sub FrmmaterialIssuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSFIT.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSFIT.tbl_Pur_UnitOfMeasurement)
        'TODO: This line of code loads data into the 'DSIT.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSIT.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSFIT.Tbl_Fit_Material' table. You can move, or remove it, as needed.
        Me.Tbl_Fit_MaterialTableAdapter.Fill(Me.DSFIT.Tbl_Fit_Material)
        'TODO: This line of code loads data into the 'DSIT.TBl_Daily_Issuance' table. You can move, or remove it, as needed.
        Me.TBl_Daily_IssuanceTableAdapter.Fill(Me.DSIT.TBl_Daily_Issuance)
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
        Dim j As Int16 = Me.TBl_Daily_IssuanceBindingSource.Position
        Try
            Me.Validate()
            Me.TBl_Daily_IssuanceBindingSource.EndEdit()
            Me.TBl_Daily_IssuanceTableAdapter.Update(Me.DSIT.TBl_Daily_Issuance)
            Me.TBl_Daily_IssuanceTableAdapter.Fill(Me.DSIT.TBl_Daily_Issuance)
            Me.TBl_Daily_IssuanceBindingSource.Position = j
            MessageBox.Show("Record Save", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TBl_Daily_IssuanceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TBl_Daily_IssuanceDataGridView.CellContentClick

    End Sub

    Private Sub TBl_Daily_IssuanceDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TBl_Daily_IssuanceDataGridView.CellEnter

    End Sub

    Private Sub TBl_Daily_IssuanceDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles TBl_Daily_IssuanceDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.TBl_Daily_IssuanceBindingSource.RemoveCurrent()
    End Sub
End Class