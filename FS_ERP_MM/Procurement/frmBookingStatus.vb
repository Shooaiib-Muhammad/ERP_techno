Public Class frmBookingStatus
    Private Sub frmBookingStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub
    Private Sub frmProcDemandExceptPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Pur_Demand_PeriorityTableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Periority)
        Me.Tbl_Inv_LocalCust1TableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust1)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        CodeComboBox.SelectedIndex = 0
        DateTimePicker1.Value = Me.Tbl_Pur_DemandTableAdapter.FirstDate()
        Demand_FillBy1()
        KeyPreview = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label2.Enabled = True
            DateTimePicker1.Enabled = True

            Label4.Enabled = True
            DateTimePicker2.Enabled = True

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            Label5.Enabled = False
            CustNameComboBox.Enabled = False
            txtGMNO.Enabled = False
            Demand_FillBy1()

            DateTimePicker1.Select()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = True
            CodeComboBox.Enabled = True

            Label5.Enabled = False
            CustNameComboBox.Enabled = False
            txtGMNO.Enabled = False
            Demand_FillBy2()

            CodeComboBox.Select()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Label2.Enabled = True
            DateTimePicker1.Enabled = True

            Label4.Enabled = True
            DateTimePicker2.Enabled = True

            Label3.Enabled = True
            CodeComboBox.Enabled = True

            Label5.Enabled = False
            CustNameComboBox.Enabled = False
            txtGMNO.Enabled = False
            Demand_FillBy3()

            Me.DateTimePicker1.Select()
        End If
    End Sub

    Private Sub Demand_FillBy1()
        Try
            Me.Tbl_Pur_DemandTableAdapter.FillBy25(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Demand_FillBy2()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy26(Me.DSPO.tbl_Pur_Demand, CodeComboBox.SelectedValue)
        End If
    End Sub

    Private Sub Demand_FillBy3()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy27(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
        End If
    End Sub

    Private Sub Demand_FillBy4()
        If CustNameComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy33(Me.DSPO.tbl_Pur_Demand, CustNameComboBox.SelectedValue)
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If RadioButton1.Checked Then
            Demand_FillBy1()
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
        End If
    End Sub

    Private Sub CodeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeComboBox.SelectedIndexChanged
        If RadioButton2.Checked Then
            Demand_FillBy2()
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
        End If
    End Sub

    Private Sub SaveDemand()
        Try
            Me.Validate()
            Me.Tbl_Pur_DemandBindingSource.EndEdit()
            Me.Tbl_Pur_DemandTableAdapter.Update(Me.DSPO.tbl_Pur_Demand)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellContentClick
        If e.ColumnIndex = 12 And e.RowIndex >= 0 Then
            If Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value Is DBNull.Value Then 'For Booking Status
                Dim dgResult As DialogResult = MessageBox.Show("Are You Sure About The Action You Are Going to Perform?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dgResult = Windows.Forms.DialogResult.Yes Then
                    'Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = True
                    'Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = Now.Date
                    'Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = False
                    If DBNull.Value.Equals(Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value) Then
                        Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = True
                        Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = Now.Date
                        Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = False
                        SaveDemand()
                    Else
                        If Me.Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = False Then
                            Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = True
                            Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = Now.Date
                            Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = False
                            SaveDemand()
                        Else
                            Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = False
                            Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = DBNull.Value
                        End If
                    End If
                End If
            Else
            End If
            If Me.Tbl_Pur_DemandDataGridView.Item(17, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).ReadOnly = False
            Else
                Me.Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).ReadOnly = True
            End If
        ElseIf e.ColumnIndex = 14 And e.RowIndex >= 0 Then 'For Pending
            If Me.Tbl_Pur_DemandDataGridView(14, e.RowIndex).ReadOnly = False Then
                If Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value Is DBNull.Value Then
                    Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = True
                    Tbl_Pur_DemandDataGridView.Item(15, e.RowIndex).Value = Now.Date
                    'Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = True
                    'Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = DateAdd(DateInterval.Day, 3, Now.Date)
                    Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).ReadOnly = True
                    Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).ReadOnly = True
                    Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = False
                    SaveDemand()
                Else
                    If Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = False Then
                        Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = True
                        Tbl_Pur_DemandDataGridView.Item(15, e.RowIndex).Value = Now.Date
                        'Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = True
                        'Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = DateAdd(DateInterval.Day, 3, Now.Date)
                        Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).ReadOnly = True
                        Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).ReadOnly = True
                        Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = False
                        SaveDemand()
                    Else
                        Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = False
                        Tbl_Pur_DemandDataGridView.Item(15, e.RowIndex).Value = DBNull.Value
                        Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = DBNull.Value
                        Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = DBNull.Value
                        Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).ReadOnly = False
                        Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).ReadOnly = True
                        Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = True
                        SaveDemand()
                    End If
                End If
            End If
        ElseIf e.ColumnIndex = 16 And e.RowIndex >= 0 Then 'For Order Given
            If Me.Tbl_Pur_DemandDataGridView.Item(15, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).ReadOnly = False
            Else
                Me.Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).ReadOnly = True
            End If
            If Me.Tbl_Pur_DemandDataGridView(16, e.RowIndex).ReadOnly = False Then
                If Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).Value Is DBNull.Value Then
                    Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).Value = True
                    Tbl_Pur_DemandDataGridView.Item(17, e.RowIndex).Value = Now.Date
                    'Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = True
                    'Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = DateAdd(DateInterval.Day, 3, Now.Date)
                    'Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = Now.Date
                    Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).ReadOnly = True
                    Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = False
                    Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).ReadOnly = True
                    SaveDemand()
                Else
                    If Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).Value = False Then
                        Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).ReadOnly = True
                        Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).ReadOnly = True
                        Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).Value = True
                        Tbl_Pur_DemandDataGridView.Item(17, e.RowIndex).Value = Now.Date
                        'Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = True
                        'Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = DateAdd(DateInterval.Day, 3, Now.Date)
                        Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = False
                        SaveDemand()
                    Else
                        Tbl_Pur_DemandDataGridView.Item(16, e.RowIndex).Value = False
                        Tbl_Pur_DemandDataGridView.Item(17, e.RowIndex).Value = DBNull.Value
                        Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = DBNull.Value
                        Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = DBNull.Value
                        Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).ReadOnly = False
                        Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).ReadOnly = False
                        Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = True
                        SaveDemand()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If RadioButton1.Checked Then
            Demand_FillBy1()
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
        End If
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Tbl_Pur_DemandDataGridView.CellBeginEdit
        If e.ColumnIndex = 13 Then
            If Tbl_Pur_DemandDataGridView(12, e.RowIndex).Value Is DBNull.Value Then
                MsgBox("Booking Status is Off, So You can't Add Booking Due Date")
            End If
        End If
    End Sub

    Private Sub Tbl_Pur_DemandBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_DemandBindingNavigatorSaveItem.Click
        SaveDemand()
    End Sub
    Sub ToRefresh()
        If RadioButton1.Checked Then
            Demand_FillBy1()
            MsgBox("Record Refreshed")
        ElseIf RadioButton2.Checked Then
            Demand_FillBy2()
            MsgBox("Record Refreshed")
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
            MsgBox("Record Refreshed")
        ElseIf RadioButton4.Checked Then
            Demand_FillBy4()
            MsgBox("Record Refreshed")
        ElseIf RadioButton5.Checked Then
            GMNO_FillBy41()
            MsgBox("Record Refreshed")
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            Label5.Enabled = True
            CustNameComboBox.Enabled = True
            txtGMNO.Enabled = False
            Demand_FillBy4()

            Me.CustNameComboBox.Select()
        End If
    End Sub

    Private Sub CustNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustNameComboBox.SelectedIndexChanged
        If RadioButton4.Checked Then
            Demand_FillBy4()
        End If
    End Sub
    Private Sub Tbl_Pur_DemandDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_DemandDataGridView.DataError

    End Sub
    Private Sub GMNO_FillBy41()
        If txtGMNO.TextLength > 0 Then
            Try
                Me.Tbl_Pur_DemandTableAdapter.GMNOBookingStatus_FillBy41(Me.DSPO.tbl_Pur_Demand, txtGMNO.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            'Label6.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = True
            Me.txtGMNO.Enabled = True
            GMNO_FillBy41()
            Me.txtGMNO.Focus()
        End If
    End Sub

    Private Sub txtGMNO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGMNO.TextChanged
        If RadioButton5.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = False
            CodeComboBox.Enabled = False
            'Label6.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = True
            Me.txtGMNO.Enabled = True
            GMNO_FillBy41()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ToRefresh()
    End Sub
End Class