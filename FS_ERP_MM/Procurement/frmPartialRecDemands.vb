Public Class frmPartialRecDemands


    Private Sub frmPartialRecDemands_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDemandIssuance.tbl_Inv_L41' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L41TableAdapter.Fill(Me.DSDemandIssuance.tbl_Inv_L41)
        'TODO: This line of code loads data into the 'DSDemandIssuance.tbl_Inv_LocalCust1' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCust1TableAdapter.Fill(Me.DSDemandIssuance.tbl_Inv_LocalCust1)
        'TODO: This line of code loads data into the 'DSDemandIssuance.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSDemandIssuance.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSDemandIssuance.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSDemandIssuance.tbl_Inv_L4)
        ShowData()
    End Sub
    Private Sub Tbl_Pur_DemandDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellContentClick
        If e.ColumnIndex = 11 Then
            If Me.Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value = True
                Me.Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = Now.Date
            Else
                If Me.Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value = False Then
                    Me.Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value = True
                    Me.Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = Now.Date
                Else
                    Me.Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value = False
                    Me.Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_DemandDataGridView.DataError

    End Sub
    Private Sub ShowContents(ByVal dt As Boolean, ByVal Item As Boolean, ByVal dept As Boolean, ByVal GD As Boolean)
        DateTimePicker1.Enabled = dt
        DateTimePicker2.Enabled = dt
        CodeComboBox.Enabled = Item
        CustNameComboBox.Enabled = dept
        txtGMNO.Enabled = GD
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged
        If RadioButton1.Checked Then
            ShowContents(True, False, False, False)
        ElseIf RadioButton2.Checked Then
            ShowContents(False, True, False, False)
        ElseIf RadioButton3.Checked Then
            ShowContents(True, True, False, False)
        ElseIf RadioButton4.Checked Then
            ShowContents(False, False, True, False)
        ElseIf RadioButton5.Checked Then
            ShowContents(False, False, False, True)
        End If
        ShowData()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        ShowData()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        ShowData()
    End Sub

    Private Sub CodeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeComboBox.SelectedIndexChanged
        ShowData()
    End Sub

    Private Sub CustNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustNameComboBox.SelectedIndexChanged
        ShowData()
    End Sub

    Private Sub txtGMNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGMNO.TextChanged
        ShowData()
    End Sub
    Private Sub ShowData()
        Try
            If RadioButton1.Checked Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy(Me.DSPartialDemandsTransactions.tbl_Pur_Demand, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
            ElseIf RadioButton2.Checked Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy2(Me.DSPartialDemandsTransactions.tbl_Pur_Demand, Me.CodeComboBox.SelectedValue)
            ElseIf RadioButton3.Checked Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy3(Me.DSPartialDemandsTransactions.tbl_Pur_Demand, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text, Me.CodeComboBox.SelectedValue)
            ElseIf RadioButton4.Checked Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy1(Me.DSPartialDemandsTransactions.tbl_Pur_Demand, CustNameComboBox.SelectedValue)
            ElseIf RadioButton5.Checked Then
                Me.Tbl_Pur_DemandTableAdapter.Fill(Me.DSPartialDemandsTransactions.tbl_Pur_Demand, Me.txtGMNO.Text)
            End If
            'DSDemandIssuance
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Tbl_Pur_DemandBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_DemandBindingNavigatorSaveItem.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Pur_DemandBindingSource.EndEdit()
            Me.Tbl_Pur_DemandTableAdapter.Update(Me.DSPartialDemandsTransactions.tbl_Pur_Demand)
            ShowData()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception

        End Try
    End Sub
End Class