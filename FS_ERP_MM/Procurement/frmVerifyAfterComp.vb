Public Class frmVerifyAfterComp

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

    Private Sub frmVerifyAfterComp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub
    Private Sub frmVerifyAfterComp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSNewProcurement.tbl_Pur_Demand_New' table. You can move, or remove it, as needed.
        'Me.Tbl_Pur_Demand_NewTableAdapter.Fill(Me.DSNewProcurement.tbl_Pur_Demand_New)
        Me.Tbl_Inv_LocalCust1TableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust1)
        Me.Tbl_Pur_PartialReceivingTableAdapter.Fill(Me.DSPO.tbl_Pur_PartialReceiving)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSPO.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPO.tbl_Inv_L4)
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

            Label5.Enabled = False
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

            Label5.Enabled = False
            CustNameComboBox.Enabled = False
            Me.txtGMNO.Enabled = False
            Demand_FillBy3()

            Me.DateTimePicker1.Select()
        End If
    End Sub
    Private Sub SetButton()
        For i As Integer = 0 To Tbl_Pur_DemandDataGridView.RowCount - 1
            If Tbl_Pur_DemandDataGridView.Item(11, i).Value Is DBNull.Value Then
                Tbl_Pur_DemandDataGridView.Item(18, i).ReadOnly = True
            Else
                Tbl_Pur_DemandDataGridView.Item(18, i).ReadOnly = False
            End If
        Next
    End Sub
    Dim Status As Integer = 1
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
    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If Me.TabControl1.SelectedTab.Text = "Verification" Then
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
    Private Sub Demand_FillBy1()
        If Status = 1 Then
            Try
                Me.Tbl_Pur_DemandTableAdapter.FillBy13(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
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


        If Status = 1 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy14(Me.DSPO.tbl_Pur_Demand, CodeComboBox.SelectedValue)
            End If
        ElseIf Status = 4 Then
            Try
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy11(Me.DSNewProcurement.tbl_Pur_Demand_New, CodeComboBox.SelectedValue)
            Catch ex As Exception
            End Try
        End If


        SetButton()
        'End If
    End Sub
    Private Sub Demand_FillBy3()

        If Status = 1 Then
            If CodeComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy15(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
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

        If Status = 1 Then
            If CustNameComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_DemandTableAdapter.FillBy39(Me.DSPO.tbl_Pur_Demand, CustNameComboBox.SelectedValue)
            End If
        ElseIf Status = 4 Then
            If CustNameComboBox.SelectedValue <> Nothing Then
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy12(Me.DSNewProcurement.tbl_Pur_Demand_New, CustNameComboBox.SelectedValue)
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
    Private Sub SaveDemand()
        Try
            Me.Validate()
            Me.Tbl_Pur_DemandBindingSource.EndEdit()
            Me.Tbl_Pur_DemandTableAdapter.Update(Me.DSPO.tbl_Pur_Demand)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Tbl_Pur_DemandDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellContentClick
        If e.ColumnIndex = 8 And e.RowIndex >= 0 Then
            If Tbl_Pur_DemandDataGridView.Item(8, e.RowIndex).Value Is DBNull.Value Then
                If Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value Is DBNull.Value Then
                    Dim dgResult As DialogResult = MessageBox.Show("Are You Sure About The Action You Are Going to Perform?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If dgResult = Windows.Forms.DialogResult.Yes Then
                        Tbl_Pur_DemandDataGridView.Item(8, e.RowIndex).Value = True
                        Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = Now.Date
                        SaveDemand()

                        Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                        Me.Tbl_Pur_DemandBindingSource.Filter = "AfterPurchaseVStatus is null"
                    End If
                Else
                    Dim PDID As Integer = Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value
                    Dim Ret As Integer = Me.Tbl_Pur_PartialReceivingTableAdapter.FillBy1(Me.DSPO.tbl_Pur_PartialReceiving, PDID)
                    If Ret > 0 Then
                        MsgBox("Some of the partial verifications are missing")
                    Else
                        Dim dgResult As DialogResult = MessageBox.Show("Are You Sure About The Action You Are Going to Perform?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If dgResult = Windows.Forms.DialogResult.Yes Then
                            Tbl_Pur_DemandDataGridView.Item(8, e.RowIndex).Value = True
                            Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = Now.Date
                            SaveDemand()

                            Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                            Me.Tbl_Pur_DemandBindingSource.Filter = "AfterPurchaseVStatus is null"
                        End If
                    End If
                End If
            End If
        ElseIf e.ColumnIndex = 19 And e.RowIndex >= 0 Then
            Try
                If Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value = True Then
                    PropertyPDIDNo = Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value
                    PropertyGDNo = Tbl_Pur_DemandDataGridView.Item(1, e.RowIndex).Value
                    ChildWindowOpen("frmPartialRecVStatus")
                Else
                End If
            Catch ex As Exception
                MsgBox("Partial Status is off")
            End Try
        End If

    End Sub
    Private Sub Tbl_Pur_DemandDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_DemandDataGridView.DataError

    End Sub
    Private Sub ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.Close()
            End If
        Next
        frmPartialRecVStatus.MdiParent = frmMain
        frmPartialRecVStatus.Show()
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
            Me.txtGMNO.Enabled = False
            Demand_FillBy4()
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

            'Label6.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = True
            Me.txtGMNO.Enabled = True

            GMNO_FillBy41()

            Me.txtGMNO.Focus()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub GMNO_FillBy41()
        If txtGMNO.TextLength >= 0 Then
            If Status = 1 Then
                Try
                    Me.Tbl_Pur_DemandTableAdapter.GMNOVerificationBilling_FillBy41(Me.DSPO.tbl_Pur_Demand, txtGMNO.Text)
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

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub DataGridView3_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView3.DataError

    End Sub
End Class