Public Class frmSetPurchaseAmtTemp
    Private Shared sGDNo As Integer
    Private Shared sPDIDNo As Integer

    Public Property PropertyGDNo() As Integer
        Get
            Return sGDNo
        End Get
        Set(ByVal value As Integer)
            sGDNo = value
        End Set
    End Property

    Public Property PropertyPDIDNo() As Integer
        Get
            Return sPDIDNo
        End Get
        Set(ByVal value As Integer)
            sPDIDNo = value
        End Set
    End Property

    Private Sub frmSetPurchaseAmt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmSetPurchaseAmt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.S And e.Control) Then
            SaveDemand()
            MsgBox("Record Saved")
        ElseIf e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub
    Private Sub frmDemandPurchased_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSVendorInfo.tbl_PUR_Vendor_Info' table. You can move, or remove it, as needed.
        Me.Tbl_PUR_Vendor_InfoTableAdapter.Fill(Me.DSVendorInfo.tbl_PUR_Vendor_Info)
        Me.Tbl_Inv_LocalCust1TableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust1)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSPO.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        'DateTimePicker1.Value = Me.Tbl_Pur_DemandTableAdapter.FirstDate()
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

            Label6.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = False
            Me.txtGMNO.Enabled = False

            Label9.Enabled = False
            Me.txtVendorName.Enabled = False

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

            Label6.Enabled = False
            CustNameComboBox.Enabled = False

            Label3.Enabled = True
            CodeComboBox.Enabled = True

            Label7.Enabled = False
            Me.txtGMNO.Enabled = False

            Label9.Enabled = False
            Me.txtVendorName.Enabled = False

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

            Label7.Enabled = False
            Me.txtGMNO.Enabled = False

            Label9.Enabled = False
            Me.txtVendorName.Enabled = False

            Demand_FillBy3()

            Me.DateTimePicker1.Select()
        End If
    End Sub

    Private Sub SetButton()
        For i As Integer = 0 To Tbl_Pur_DemandDataGridView.RowCount - 1
            If Tbl_Pur_DemandDataGridView.Item(17, i).Value Is DBNull.Value Then
                Tbl_Pur_DemandDataGridView.Item(18, i).ReadOnly = True
                Tbl_Pur_DemandDataGridView.Item(5, i).ReadOnly = False
                Tbl_Pur_DemandDataGridView.Item(10, i).ReadOnly = False
                Tbl_Pur_DemandDataGridView.Item(11, i).ReadOnly = False
                Tbl_Pur_DemandDataGridView.Item(12, i).ReadOnly = False
                Tbl_Pur_DemandDataGridView.Item(13, i).ReadOnly = False
                Tbl_Pur_DemandDataGridView.Item(14, i).ReadOnly = False
            Else
                Tbl_Pur_DemandDataGridView.Item(18, i).ReadOnly = False
                Tbl_Pur_DemandDataGridView.Item(5, i).ReadOnly = True
                Tbl_Pur_DemandDataGridView.Item(10, i).ReadOnly = True
                Tbl_Pur_DemandDataGridView.Item(11, i).ReadOnly = True
                Tbl_Pur_DemandDataGridView.Item(12, i).ReadOnly = True
                Tbl_Pur_DemandDataGridView.Item(14, i).ReadOnly = True
                Tbl_Pur_DemandDataGridView.Item(13, i).ReadOnly = True
            End If
        Next

    End Sub

    Private Sub Demand_FillBy1()
        Try
            Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.FillBy22(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Catch ex As Exception
        End Try
        SetButton()
    End Sub

    Private Sub Demand_FillBy2()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.FillBy23(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, CodeComboBox.SelectedValue)
            SetButton()
        End If

    End Sub

    Private Sub Demand_FillBy3()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.FillBy24(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
            SetButton()
        End If

    End Sub
    Private Sub GMNO_FillBy41()
        If txtGMNO.TextLength > 0 Then
            Try
                Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.GMNOPurchaseAmt_FillBy41(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, txtGMNO.Text)
            Catch ex As Exception
            End Try
            SetButton()
        End If
    End Sub
    Private Sub Demand_FillBy4()
        If CodeComboBox.SelectedValue <> Nothing Then
            Try
                Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.FillBy38(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, CustNameComboBox.SelectedValue)
            Catch ex As Exception
            End Try
            SetButton()
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

    Private Sub Tbl_Pur_DemandDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_DemandDataGridView.DataError

    End Sub

    Private Sub SaveDemand()
        Try
            Me.Validate()
            Me.Tbl_Pur_Demand_Bill_NEWBindingSource.EndEdit()
            Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.Update(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Tbl_Pur_DemandBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_DemandBindingNavigatorSaveItem.Click
        SaveDemand()
        MsgBox("Record Saved")
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellContentClick
        If e.ColumnIndex = 18 And e.RowIndex >= 0 Then
            If Tbl_Pur_DemandDataGridView.Item(18, e.RowIndex).ReadOnly = False Then
                PropertyPDIDNo = Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value
                PropertyGDNo = Tbl_Pur_DemandDataGridView.Item(1, e.RowIndex).Value
                ChildWindowOpen("frmPartialRecAmt")
            Else
                MsgBox("Partial Status is Off")
            End If
        End If

    End Sub

    Private Sub ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.Close()
            End If
        Next
        frmPartialRecAmt.MdiParent = frmMain
        frmPartialRecAmt.Show()
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellEnter
        If Tbl_Pur_DemandDataGridView.Item(17, e.RowIndex).Value Is DBNull.Value Then
            If e.ColumnIndex = 11 Then
                If Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value Is DBNull.Value Then
                    If Tbl_Pur_DemandDataGridView.Item(15, e.RowIndex).Value IsNot DBNull.Value And Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value IsNot DBNull.Value Then
                        Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value = Tbl_Pur_DemandDataGridView.Item(15, e.RowIndex).Value * Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value
                    End If
                End If
            ElseIf e.ColumnIndex = 12 Then
                If Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value Is DBNull.Value Then
                    If Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value IsNot DBNull.Value Then
                        Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = Now.Date
                    End If
                End If
            ElseIf e.ColumnIndex = 13 Then
                If Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value Is DBNull.Value Then
                    If Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value IsNot DBNull.Value Then
                        Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = "Cash"
                    End If
                End If
            End If
        End If
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
        ElseIf RadioButton6.Checked = True Then
            VendorName_Fillby45()
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

            Label6.Enabled = True
            CustNameComboBox.Enabled = True
            CustNameComboBox.Focus()

            Label7.Enabled = False
            Me.txtGMNO.Enabled = False

            Label9.Enabled = False
            Me.txtVendorName.Enabled = False

            Demand_FillBy4()

            Me.CustNameComboBox.Select()
        End If
    End Sub

    Private Sub CustNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustNameComboBox.SelectedIndexChanged
        If RadioButton4.Checked Then
            Demand_FillBy4()
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

            Label9.Enabled = False
            Me.txtVendorName.Enabled = False

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

            Label9.Enabled = False
            Me.txtVendorName.Enabled = False

            GMNO_FillBy41()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            Label6.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = False
            Me.txtGMNO.Enabled = False

            Label9.Enabled = True
            Me.txtVendorName.Enabled = True

            VendorName_Fillby45()
            Me.txtVendorName.Focus()
        End If
    End Sub

    Private Sub VendorName_Fillby45()
        If txtVendorName.TextLength > 0 Then
            Try
                'Me.Tbl_Pur_DemandBindingSource.Filter = "VendorName like '" & txtVendorName.Text & "%'And PurchaseStatus = 1 And POStatus IS NULL And DemandStatus = 'Active' And SleepStatus IS NULL OR SleepStatus = 0 "
                Me.Tbl_Pur_DemandTableAdapter.VendorName_FillBy45(Me.DSPO.tbl_Pur_Demand, txtVendorName.Text)
            Catch ex As Exception
            End Try
            SetButton()
        Else
            Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
        End If
    End Sub
    Private Sub txtVendorName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVendorName.TextChanged

        If RadioButton6.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            Label6.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = False
            Me.txtGMNO.Enabled = False

            Label9.Enabled = True
            Me.txtVendorName.Enabled = True
            VendorName_Fillby45()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ToRefresh()
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Pur_DemandDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.Fill(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, CType(PDDateToolStripTextBox.Text, Date), CType(PDDate1ToolStripTextBox.Text, Date))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class