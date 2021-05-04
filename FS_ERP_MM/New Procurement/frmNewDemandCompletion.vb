Public Class frmNewDemandCompletion
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

    Private Sub frmDemandCompletion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
        If e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control Then
            If Status = 3 Then
                SaveAmt()
            End If
        End If
    End Sub

    Private Sub frmDemandCompletion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPURBILL.tbl_Dept_Info_Test' table. You can move, or remove it, as needed.
        Me.Tbl_Dept_Info_TestTableAdapter.Fill(Me.DSPURBILL.tbl_Dept_Info_Test)
        'TODO: This line of code loads data into the 'DSNewProcurement.tbl_Sec_Middle' table. You can move, or remove it, as needed.
        'Me.Tbl_Sec_MiddleTableAdapter.Fill(Me.DSNewProcurement.tbl_Sec_Middle)
        'TODO: This line of code loads data into the 'DSNewProcurement.tbl_Dept_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Dept_InfoTableAdapter.Fill(Me.DSNewProcurement.tbl_Dept_Info)
        'TODO: This line of code loads data into the 'DSNewProcurement.tbl_Inv_Dept' table. You can move, or remove it, as needed.
        'Me.Tbl_Inv_DeptTableAdapter.Fill(Me.DSNewProcurement.tbl_Inv_Dept)
        'TODO: This line of code loads data into the 'DSNewProcurement.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        'Me.Tbl_Inv_LocalCustTableAdapter1.Fill(Me.DSNewProcurement.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSNewProcurement.tbl_Pur_PartialReceiving_New' table. You can move, or remove it, as needed.
        Me.Tbl_PUR_Vendor_InfoTableAdapter.Fill(Me.DSVendorInfo.tbl_PUR_Vendor_Info)
        Me.Tbl_Pur_PartialReceiving_NewTableAdapter.Fill(Me.DSNewProcurement.tbl_Pur_PartialReceiving_New)
        'TODO: This line of code loads data into the 'DSNewProcurement.tbl_Pur_Demand_New' table. You can move, or remove it, as needed.
        'Me.Tbl_Pur_Demand_NewTableAdapter.Fill(Me.DSNewProcurement.tbl_Pur_Demand_New)
        'Me.Tbl_Pur_Demand_PeriorityTableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Periority)
        Me.Tbl_Inv_LocalCust1TableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust1)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSPO.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPO.tbl_Inv_L4)
        CodeComboBox.SelectedIndex = 0
        'DateTimePicker1.Value = Me.Tbl_Pur_DemandTableAdapter.FirstDate
        Demand_FillBy1()
        KeyPreview = True
        loadflag = True
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
            txtGMNO.Enabled = False
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
            txtGMNO.Enabled = False
            Demand_FillBy3()

            DateTimePicker1.Select()
        End If
    End Sub

    'Private Sub SetButton()
    '    For i As Integer = 0 To Tbl_Pur_DemandDataGridView.RowCount - 1
    '        If Tbl_Pur_DemandDataGridView.Item(10, i).Value Is DBNull.Value Then
    '            Tbl_Pur_DemandDataGridView.Item(11, i).ReadOnly = True
    '            Tbl_Pur_DemandDataGridView.Item(12, i).ReadOnly = False
    '        Else
    '            Tbl_Pur_DemandDataGridView.Item(11, i).ReadOnly = False
    '            Tbl_Pur_DemandDataGridView.Item(12, i).ReadOnly = True
    '        End If
    '    Next

    'End Sub

    Private Sub Demand_FillBy1()
        If Status = 2 Then
            Try
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy(Me.DSNewProcurement.tbl_Pur_Demand_New, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            Catch ex As Exception
            End Try
        ElseIf Status = 3 Then
            Try
                Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.FillBy22(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            Catch ex As Exception
            End Try
        ElseIf Status = 1 Then
            Try
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy5(Me.DSNewProcurement.tbl_Pur_Demand_New, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            Catch ex As Exception
            End Try
        ElseIf Status = 4 Then
            Try
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy10(Me.DSNewProcurement.tbl_Pur_Demand_New, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            Catch ex As Exception
            End Try
        End If
      
        SetButton()
    End Sub

    Private Sub Demand_FillBy2()
        If Status = 2 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy1(Me.DSNewProcurement.tbl_Pur_Demand_New, CodeComboBox.SelectedValue)
                SetButton()
            End If
        ElseIf Status = 3 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.FillBy23(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, CodeComboBox.SelectedValue)
                SetButton()
            End If
        ElseIf Status = 1 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy6(Me.DSNewProcurement.tbl_Pur_Demand_New, CodeComboBox.SelectedValue)
                SetButton()
            End If
        ElseIf Status = 4 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy11(Me.DSNewProcurement.tbl_Pur_Demand_New, CodeComboBox.SelectedValue)
                'SetButton()
            End If
        End If
    End Sub

    Private Sub Demand_FillBy3()
        If Status = 2 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy3(Me.DSNewProcurement.tbl_Pur_Demand_New, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
                SetButton()
            End If
        ElseIf Status = 3 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.FillBy24(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
                SetButton()
            End If
        ElseIf Status = 1 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy8(Me.DSNewProcurement.tbl_Pur_Demand_New, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
                SetButton()
            End If
        ElseIf Status = 4 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy13(Me.DSNewProcurement.tbl_Pur_Demand_New, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
                SetButton()
            End If
        End If
    End Sub

    Private Sub Demand_FillBy4()
        If Status = 2 Then
            If CustNameComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy2(Me.DSNewProcurement.tbl_Pur_Demand_New, CustNameComboBox.SelectedValue)
            End If
            SetButton()
        ElseIf Status = 3 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Try
                    Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.FillBy38(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, CustNameComboBox.SelectedValue)
                Catch ex As Exception
                End Try
                SetButton()
            End If

        ElseIf Status = 1 Then
            If CustNameComboBox.SelectedValue <> Nothing Then
                Try
                    Me.Tbl_Pur_Demand_NewTableAdapter.FillBy7(Me.DSNewProcurement.tbl_Pur_Demand_New, CustNameComboBox.SelectedValue)
                Catch ex As Exception

                End Try

                SetButton()
            End If
        ElseIf Status = 4 Then
            If CustNameComboBox.SelectedValue <> Nothing Then
                Try
                    Me.Tbl_Pur_Demand_NewTableAdapter.FillBy12(Me.DSNewProcurement.tbl_Pur_Demand_New, CustNameComboBox.SelectedValue)
                Catch ex As Exception

                End Try

                SetButton()
            End If
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

    Private Sub SaveDemand1()
        Try
            Me.Validate()
            Me.Tbl_Pur_DemandBindingSource.EndEdit()
            Me.Tbl_Pur_DemandTableAdapter.Update(Me.DSPO.tbl_Pur_Demand)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellContentClick
        Dim dgResult As DialogResult
        If e.ColumnIndex = 12 And e.RowIndex >= 0 Then     'Opens Form of Partial Receiving
            If Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).ReadOnly = False Then
                PropertyPDIDNo = Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value
                PropertyGDNo = Tbl_Pur_DemandDataGridView.Item(1, e.RowIndex).Value
                ChildWindowOpen1("frmPartialReceiving")
            Else
                MsgBox("Partial Status is off")
            End If
        ElseIf e.ColumnIndex = 11 And e.RowIndex >= 0 Then  'Partial Receiving Status
            Dim OGStatus, PendingStatus As Boolean
            Try
                OGStatus = Tbl_Pur_DemandTableAdapter.OGStatus(Tbl_Pur_DemandDataGridView.Item(1, e.RowIndex).Value, Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value)
            Catch ex As Exception
                OGStatus = False
            End Try
            Try
                PendingStatus = Tbl_Pur_DemandTableAdapter.PendingStatus(Tbl_Pur_DemandDataGridView.Item(1, e.RowIndex).Value, Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value)
            Catch ex As Exception
                PendingStatus = False
            End Try
            If OGStatus = True Or PendingStatus = True Then
                MsgBox("First Off Pending Or Order Given Status To Continue")
            Else
                If Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value Is DBNull.Value Then
                    dgResult = MessageBox.Show("Are you sure! you have partial receivings?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If dgResult = Windows.Forms.DialogResult.Yes Then
                        Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value = True
                        Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).ReadOnly = False
                        PurchaseSave()
                    End If
                End If
            End If
        ElseIf e.ColumnIndex = 9 And e.RowIndex >= 0 Then  'Full Receiving Status
            Dim OGStatus, PendingStatus As Boolean
            Try
                OGStatus = Tbl_Pur_DemandTableAdapter.OGStatus(Tbl_Pur_DemandDataGridView.Item(1, e.RowIndex).Value, Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value)
            Catch ex As Exception
                OGStatus = False
            End Try
            Try
                PendingStatus = Tbl_Pur_DemandTableAdapter.PendingStatus(Tbl_Pur_DemandDataGridView.Item(1, e.RowIndex).Value, Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value)
            Catch ex As Exception
                PendingStatus = False
            End Try
            If OGStatus = True Then
                MsgBox("First Off Pending Or Order Given Status To Continue")
            Else
                If Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value Is DBNull.Value Then
                    If Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value Is DBNull.Value Then
                        If Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value Is DBNull.Value Then
                            dgResult = MessageBox.Show("Are you sure! you have full receiving?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If dgResult = DialogResult.Yes Then
                                Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = Tbl_Pur_DemandDataGridView.Item(5, e.RowIndex).Value
                                Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = True
                                Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value = Now.Date
                                Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = False
                                PurchaseSave()
                                Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                                Me.Tbl_Pur_DemandBindingSource.Filter = "CompStatus is null"
                            End If
                        Else
                            dgResult = MessageBox.Show("Are you sure! you have full receiving?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If dgResult = Windows.Forms.DialogResult.Yes Then
                                Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = True
                                Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value = Now.Date
                                Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = False
                                PurchaseSave()
                                Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                                Me.Tbl_Pur_DemandBindingSource.Filter = "CompStatus is null"
                            End If
                        End If
                    Else
                        If Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value Is DBNull.Value Then
                            dgResult = MessageBox.Show("Are you sure! you have received demand fully?" & vbCrLf & "Because this was partial receiving demand, so you must verify from partial receiving form," & vbCrLf & "that demand have been received as per requirements", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If dgResult = Windows.Forms.DialogResult.Yes Then
                                Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = Tbl_Pur_DemandDataGridView.Item(5, e.RowIndex).Value
                                Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = True
                                Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value = Now.Date
                                Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = False
                                PurchaseSave()
                                Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                                Me.Tbl_Pur_DemandBindingSource.Filter = "CompStatus is Null"
                            End If
                        Else
                            dgResult = MessageBox.Show("Are you sure! you have Received demand fully?" & vbCrLf & "Because this was partial receiving demand, so you must verify from partial receiving form," & vbCrLf & "that demand have been received as per requirements", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If dgResult = Windows.Forms.DialogResult.Yes Then
                                Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = True
                                Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value = Now.Date
                                Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = False
                                PurchaseSave()
                                Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                                Me.Tbl_Pur_DemandBindingSource.Filter = "CompStatus is null"
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellEnter
        If e.ColumnIndex >= 9 Then
            If Me.Tbl_Pur_DemandDataGridView(15, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Pur_DemandDataGridView(15, e.RowIndex).Value = Now.Date
            End If
            If Me.Tbl_Pur_DemandDataGridView(14, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Pur_DemandDataGridView(14, e.RowIndex).Value = 27
            End If
        End If
        If e.ColumnIndex = 16 Then
            If Me.Tbl_Pur_DemandDataGridView(14, e.RowIndex).Value = 27 Then
                Me.Tbl_Pur_DemandDataGridView(16, e.RowIndex).ReadOnly = True
            Else
                Me.Tbl_Pur_DemandDataGridView(16, e.RowIndex).ReadOnly = False
            End If
        End If
    End Sub

    Private Sub Tbl_Pur_DemandDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_DemandDataGridView.DataError

    End Sub

    'Private Sub ChildWindowOpen(ByVal childWindow As String)
    '    For Each f As Form In frmMain.MdiChildren
    '        If f.Name = childWindow Then
    '            f.Close()
    '        End If
    '    Next
    '    frmPartialReceiving.MdiParent = frmMain
    '    frmPartialReceiving.Show()
    'End Sub
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

    Private Sub GMNO_FillBy41()
       
        If txtGMNO.TextLength >= 0 Then
            If Status = 2 Then
                Try
                    Me.Tbl_Pur_Demand_NewTableAdapter.FillBy4(Me.DSNewProcurement.tbl_Pur_Demand_New, Val(txtGMNO.Text))
                Catch ex As Exception
                End Try
            ElseIf Status = 3 Then
                Try
                    Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.GMNOPurchaseAmt_FillBy41(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW, Val(txtGMNO.Text))
                Catch ex As Exception
                End Try
            ElseIf Status = 1 Then
                Try
                    Me.Tbl_Pur_Demand_NewTableAdapter.FillBy9(Me.DSNewProcurement.tbl_Pur_Demand_New, Val(txtGMNO.Text))
                Catch ex As Exception
                End Try
            ElseIf Status = 4 Then
                Try
                    Me.Tbl_Pur_Demand_NewTableAdapter.FillBy14(Me.DSNewProcurement.tbl_Pur_Demand_New, Val(txtGMNO.Text))
                Catch ex As Exception
                End Try
            End If



            SetButton()
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
    Private Sub LoadData()
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
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ToRefresh()
    End Sub
    Dim Status As Integer = 1
    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If Me.TabControl1.SelectedTab.Text = "Demand Status" Then
            Status = 1
            LoadData()
        ElseIf TabControl1.SelectedTab.Text = "Purchase" Then
            Status = 2
            LoadData()
        ElseIf TabControl1.SelectedTab.Text = "Setting Purchase Amount" Then
            Status = 3
            LoadData()
        ElseIf TabControl1.SelectedTab.Text = "All Demand Record" Then
            Status = 4
            LoadData()
            'All Demand Record
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
    
    Private Sub ChildWindowOpen1(ByVal childWindow As String)
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.Close()
            End If
        Next
        frmPartialReceiving.MdiParent = frmMain
        frmPartialReceiving.Show()
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
    Private Sub SetButton()
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Item(18, i).Value Is DBNull.Value Then
                DataGridView1.Item(19, i).ReadOnly = True
                DataGridView1.Item(5, i).ReadOnly = False
                DataGridView1.Item(10, i).ReadOnly = False
                DataGridView1.Item(11, i).ReadOnly = False
                DataGridView1.Item(12, i).ReadOnly = False
                DataGridView1.Item(13, i).ReadOnly = False
                DataGridView1.Item(14, i).ReadOnly = False
            Else
                DataGridView1.Item(19, i).ReadOnly = False
                DataGridView1.Item(5, i).ReadOnly = False
                DataGridView1.Item(10, i).ReadOnly = False
                DataGridView1.Item(11, i).ReadOnly = False
                DataGridView1.Item(12, i).ReadOnly = False
                DataGridView1.Item(14, i).ReadOnly = False
                DataGridView1.Item(13, i).ReadOnly = False
            End If
        Next
        For i As Integer = 0 To Tbl_Pur_DemandDataGridView.RowCount - 1
            If Tbl_Pur_DemandDataGridView.Item(10, i).Value Is DBNull.Value Then
                Tbl_Pur_DemandDataGridView.Item(11, i).ReadOnly = True
                Tbl_Pur_DemandDataGridView.Item(12, i).ReadOnly = False
            Else
                Tbl_Pur_DemandDataGridView.Item(11, i).ReadOnly = False
                Tbl_Pur_DemandDataGridView.Item(12, i).ReadOnly = True
            End If
        Next
    End Sub
    Private Sub SaveAmt()
        Try
            Me.Validate()
            Me.Tbl_Pur_Demand_Bill_NEWBindingSource.EndEdit()
            Me.Tbl_Pur_Demand_Bill_NEWTableAdapter.Update(Me.DSPURBILL.tbl_Pur_Demand_Bill_NEW)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub Tbl_Pur_DemandBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_DemandBindingNavigatorSaveItem.Click
        SaveAmt()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 21 And e.RowIndex >= 0 Then
            If DataGridView1.Item(20, e.RowIndex).Value IsNot DBNull.Value Then
                If DataGridView1.Item(20, e.RowIndex).Value = True Then
                    PropertyPDIDNo = DataGridView1.Item(0, e.RowIndex).Value
                    PropertyGDNo = DataGridView1.Item(1, e.RowIndex).Value
                    ChildWindowOpen("frmPartialRecAmt")
                Else
                    MsgBox("Partial Status is Off")
                End If
            Else
                MsgBox("Partial Status is Off")
            End If

        End If

    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If e.ColumnIndex >= 11 Then
            If DataGridView1.Item(14, e.RowIndex).Value IsNot DBNull.Value Then
                If DataGridView1.Item(22, e.RowIndex).Value Is DBNull.Value Then
                    DataGridView1.Item(22, e.RowIndex).Value = True
                ElseIf DataGridView1.Item(22, e.RowIndex).Value = False Then
                    DataGridView1.Item(22, e.RowIndex).Value = True
                End If
            Else
                If DataGridView1.Item(22, e.RowIndex).Value Is DBNull.Value Then
                    DataGridView1.Item(22, e.RowIndex).Value = False
                End If

            End If
        End If

        If DataGridView1.Item(20, e.RowIndex).Value Is DBNull.Value Then
            If e.ColumnIndex = 12 Then
                If DataGridView1.Item(12, e.RowIndex).Value Is DBNull.Value Then
                    If DataGridView1.Item(17, e.RowIndex).Value IsNot DBNull.Value And DataGridView1.Item(11, e.RowIndex).Value IsNot DBNull.Value Then
                        DataGridView1.Item(12, e.RowIndex).Value = DataGridView1.Item(17, e.RowIndex).Value * DataGridView1.Item(11, e.RowIndex).Value
                    End If
                End If
            ElseIf e.ColumnIndex = 13 Then
                If DataGridView1.Item(13, e.RowIndex).Value Is DBNull.Value Then
                    If DataGridView1.Item(12, e.RowIndex).Value IsNot DBNull.Value Then
                        DataGridView1.Item(13, e.RowIndex).Value = Now.Date
                    End If
                End If
            ElseIf e.ColumnIndex = 14 Then
                If DataGridView1.Item(14, e.RowIndex).Value Is DBNull.Value Then
                    If DataGridView1.Item(12, e.RowIndex).Value IsNot DBNull.Value Then
                        DataGridView1.Item(14, e.RowIndex).Value = "Cash"
                    End If
                End If
            End If
        End If
    End Sub
    Dim loadflag As Boolean = False
    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If loadflag = True Then
            If e.ColumnIndex >= 11 Then
                If DataGridView1.Item(14, e.RowIndex).Value IsNot DBNull.Value Then
                    If DataGridView1.Item(22, e.RowIndex).Value Is DBNull.Value Then
                        DataGridView1.Item(22, e.RowIndex).Value = True
                    ElseIf DataGridView1.Item(22, e.RowIndex).Value = False Then
                        DataGridView1.Item(22, e.RowIndex).Value = True
                    End If
                Else
                    If DataGridView1.Item(22, e.RowIndex).Value Is DBNull.Value Then
                        DataGridView1.Item(22, e.RowIndex).Value = False
                    End If

                    'DataGridView1.Item(21, e.RowIndex).Value = False
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_DataError1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Pur_Demand_NewBindingSource.EndEdit()
            Me.Tbl_Pur_Demand_NewTableAdapter.Update(Me.DSNewProcurement.tbl_Pur_Demand_New)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        If e.ColumnIndex = 18 Then
            If Me.DataGridView2(17, e.RowIndex).Value = "Order Given" Then
                Me.DataGridView2(18, e.RowIndex).ReadOnly = False
            Else
                Me.DataGridView2(18, e.RowIndex).ReadOnly = True
            End If
        End If
    End Sub

    Private Sub DataGridView2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView2.DataError

    End Sub
    Private Sub PurchaseSave()
        Try
            Me.ValidateChildren()
            Me.Tbl_Pur_Demand_NewBindingSource.EndEdit()
            Me.Tbl_Pur_Demand_NewTableAdapter.Update(Me.DSNewProcurement.tbl_Pur_Demand_New)
            'MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        PurchaseSave()
        MsgBox("Record Saved Successfully")
    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub DataGridView3_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView3.DataError

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class