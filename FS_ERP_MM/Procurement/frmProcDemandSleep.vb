Public Class frmProcDemandSleep

    Private Sub frmProcDemandSleep_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub

    Private Sub frmProcDemandExceptPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_LocalCust1TableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust1)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        DateTimePicker1.Value = Me.Tbl_Pur_DemandTableAdapter.FirstDate()
        CodeComboBox.SelectedIndex = 0
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
            Me.txtGMNO.Enabled = False
            Demand_FillBy1()

            Me.DateTimePicker1.Select()
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
            Me.txtGMNO.Enabled = False
            Demand_FillBy2()

            Me.CodeComboBox.Select()
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
            Me.txtGMNO.Enabled = False
            Demand_FillBy3()

            Me.DateTimePicker1.Select()
        End If
    End Sub

    Private Sub Demand_FillBy1()
        Try
            Me.Tbl_Pur_DemandTableAdapter.FillBy41(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Demand_FillBy2()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy42(Me.DSPO.tbl_Pur_Demand, CodeComboBox.SelectedValue)
        End If
    End Sub

    Private Sub Demand_FillBy3()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy43(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
        End If
    End Sub

    Private Sub Demand_FillBy4()
        If CustNameComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy44(Me.DSPO.tbl_Pur_Demand, CustNameComboBox.SelectedValue)
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If RadioButton1.Checked Then
            Demand_FillBy1()
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ToRefresh()
        MsgBox("Record Refreshed")
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
            Me.txtGMNO.Enabled = False
            Demand_FillBy4()

            Me.CustNameComboBox.Select()
        End If
    End Sub

    Private Sub CustNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustNameComboBox.SelectedIndexChanged
        If RadioButton4.Checked Then
            Demand_FillBy4()
        End If
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub
    Private Sub GMNO_FillBy41()
        If txtGMNO.TextLength > 0 Then
            Try
                Me.Tbl_Pur_DemandTableAdapter.GMNODemandProcess_FillBy45(Me.DSPO.tbl_Pur_Demand, txtGMNO.Text)
            Catch ex As Exception

            End Try

            'SetButton()
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

    Private Sub Tbl_Pur_DemandDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellEnter
        If e.ColumnIndex = 13 Then
            If Me.Tbl_Pur_DemandDataGridView(13, e.RowIndex).Value = True Then
                Dim btnMsg As DialogResult
                btnMsg = MessageBox.Show("Are You Sure Want To Status Off? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If btnMsg = Windows.Forms.DialogResult.Yes Then
                    Me.Tbl_Pur_DemandDataGridView(13, e.RowIndex).Value = DBNull.Value
                    Me.Tbl_Pur_DemandDataGridView(14, e.RowIndex).Value = DBNull.Value
                    SaveDemand()
                    ToRefresh()
                    MsgBox("Record Updated")
                Else

                End If
            End If
        End If
    End Sub
    Private Sub ToRefresh()
        If RadioButton1.Checked Then
            Demand_FillBy1()
        ElseIf RadioButton2.Checked Then
            Demand_FillBy2()
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
        ElseIf RadioButton4.Checked Then
            Demand_FillBy4()
        ElseIf RadioButton5.Checked Then
            GMNO_FillBy41()
        End If
    End Sub
    Private Sub Tbl_Pur_DemandDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellContentClick
        If e.ColumnIndex = 9 And e.RowIndex >= 0 Then
            If Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value Is DBNull.Value Then
                Dim dgResult As DialogResult = MessageBox.Show("Are You Sure About The Action You Are Going to Perform?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dgResult = Windows.Forms.DialogResult.Yes Then
                    Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = True
                    Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value = Now.Date
                    SaveDemand()
                    Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                    Me.Tbl_Pur_DemandBindingSource.Filter = "InProcessStatus is null"
                End If
            End If
        End If

    End Sub
End Class