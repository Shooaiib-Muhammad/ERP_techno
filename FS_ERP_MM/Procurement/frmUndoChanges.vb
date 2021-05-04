Public Class frmUndoChanges

    Private Sub frmUndoChanges_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
            '()            
        End If
    End Sub

    Private Sub frmUndoChanges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_LocalCust1TableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust1)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSPO.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        CodeComboBox.SelectedIndex = 0
        'DateTimePicker1.Value = Me.Tbl_Pur_DemandTableAdapter.FirstDate()
        Demand_FillBy1()
        KeyPreview = True
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

    Private Sub Demand_FillBy1()
        Try
            Me.Tbl_Pur_DemandTableAdapter.FillBy30(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Demand_FillBy2()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy31(Me.DSPO.tbl_Pur_Demand, CodeComboBox.SelectedValue)
        End If
    End Sub

    Private Sub Demand_FillBy3()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy32(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
        End If
    End Sub

    Private Sub Demand_FillBy4()
        If CustNameComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy40(Me.DSPO.tbl_Pur_Demand, CustNameComboBox.SelectedValue)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label2.Enabled = True
            DateTimePicker1.Enabled = True

            Label4.Enabled = True
            DateTimePicker2.Enabled = True

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            Label6.Enabled = False
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

            Label6.Enabled = False
            CustNameComboBox.Enabled = False

            Label3.Enabled = True
            CodeComboBox.Enabled = True
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

            Label6.Enabled = False
            CustNameComboBox.Enabled = False
            Me.txtGMNO.Enabled = False
            Demand_FillBy3()

            Me.DateTimePicker1.Select()

        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If RadioButton1.Checked Then
            Demand_FillBy1()
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
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

    Private Sub Tbl_Pur_DemandDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellContentClick
        Dim dgResult As DialogResult
        If e.ColumnIndex = 14 And e.RowIndex >= 0 Then
            dgResult = MessageBox.Show("Are you sure! You want to reverse the actions done on this demand?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dgResult = Windows.Forms.DialogResult.Yes Then
                Try
                    Me.Tbl_Pur_PO_DTableAdapter.DeletePODetails(Me.Tbl_Pur_DemandDataGridView(0, e.RowIndex).Value)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    Me.Tbl_Pur_PartialReceivingTableAdapter.DeletePartialReceivings(Me.Tbl_Pur_DemandDataGridView(0, e.RowIndex).Value)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    Me.Tbl_Pur_DemandTableAdapter.ResetDemandValues(Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Me.Tbl_Pur_DemandDataGridView(0, e.RowIndex).Value)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                MsgBox("Record Successfully Undo")
                Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                Me.Tbl_Pur_DemandBindingSource.Filter = "InProcessStatus is Null or InProcessStatus = 1"
            End If
        End If
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_DemandDataGridView.DataError

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            Label6.Enabled = True
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
    Private Sub GMNO_FillBy41()
        If txtGMNO.TextLength > 0 Then
            Try
                Me.Tbl_Pur_DemandTableAdapter.GMNOUndoChnges_FillBy41(Me.DSPO.tbl_Pur_Demand, txtGMNO.Text)
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

            Label6.Enabled = False
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

            Label6.Enabled = False
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