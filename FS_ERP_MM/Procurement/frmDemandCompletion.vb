Public Class frmDemandCompletion
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
    End Sub

    Private Sub frmDemandCompletion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Tbl_Pur_Demand_PeriorityTableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Periority)
        Me.Tbl_Inv_LocalCust1TableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust1)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSPO.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        CodeComboBox.SelectedIndex = 0
        'DateTimePicker1.Value = Me.Tbl_Pur_DemandTableAdapter.FirstDate
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

    Private Sub SetButton()
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

    Private Sub Demand_FillBy1()
        Try
            'Me.Tbl_Pur_DemandTableAdapter.FillBy10(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Catch ex As Exception
        End Try
        SetButton()
    End Sub

    Private Sub Demand_FillBy2()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy11(Me.DSPO.tbl_Pur_Demand, CodeComboBox.SelectedValue)
            SetButton()
        End If

    End Sub

    Private Sub Demand_FillBy3()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy12(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
            SetButton()
        End If
    End Sub

    Private Sub Demand_FillBy4()
        If CustNameComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy34(Me.DSPO.tbl_Pur_Demand, CustNameComboBox.SelectedValue)
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
        Dim dgResult As DialogResult
        If e.ColumnIndex = 11 And e.RowIndex >= 0 Then     'Opens Form of Partial Receiving
            If Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).ReadOnly = False Then
                PropertyPDIDNo = Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value
                PropertyGDNo = Tbl_Pur_DemandDataGridView.Item(1, e.RowIndex).Value
                ChildWindowOpen("frmPartialReceiving")
            Else
                MsgBox("Partial Status is off")
            End If
        ElseIf e.ColumnIndex = 10 And e.RowIndex >= 0 Then  'Partial Receiving Status
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
                If Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value Is DBNull.Value Then
                    dgResult = MessageBox.Show("Are you sure! you have partial receivings?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If dgResult = Windows.Forms.DialogResult.Yes Then
                        Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value = True
                        Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).ReadOnly = False
                        SaveDemand()
                    End If
                End If
            End If
        ElseIf e.ColumnIndex = 8 And e.RowIndex >= 0 Then  'Full Receiving Status
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
                If Tbl_Pur_DemandDataGridView.Item(8, e.RowIndex).Value Is DBNull.Value Then
                    If Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).Value Is DBNull.Value Then
                        If Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value Is DBNull.Value Then
                            dgResult = MessageBox.Show("Are you sure! you have full receiving?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If dgResult = DialogResult.Yes Then
                                Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = Tbl_Pur_DemandDataGridView.Item(5, e.RowIndex).Value
                                Tbl_Pur_DemandDataGridView.Item(8, e.RowIndex).Value = True
                                Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = Now.Date
                                Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = False
                                SaveDemand()
                                Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                                Me.Tbl_Pur_DemandBindingSource.Filter = "CompStatus is null"
                            End If
                        Else
                            dgResult = MessageBox.Show("Are you sure! you have full receiving?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If dgResult = Windows.Forms.DialogResult.Yes Then
                                Tbl_Pur_DemandDataGridView.Item(8, e.RowIndex).Value = True
                                Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = Now.Date
                                Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = False
                                SaveDemand()
                                Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                                Me.Tbl_Pur_DemandBindingSource.Filter = "CompStatus is null"
                            End If
                        End If
                    Else
                        If Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value Is DBNull.Value Then
                            dgResult = MessageBox.Show("Are you sure! you have received demand fully?" & vbCrLf & "Because this was partial receiving demand, so you must verify from partial receiving form," & vbCrLf & "that demand have been received as per requirements", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If dgResult = Windows.Forms.DialogResult.Yes Then
                                Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = Tbl_Pur_DemandDataGridView.Item(5, e.RowIndex).Value
                                Tbl_Pur_DemandDataGridView.Item(8, e.RowIndex).Value = True
                                Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = Now.Date
                                Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = False
                                SaveDemand()
                                Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                                Me.Tbl_Pur_DemandBindingSource.Filter = "CompStatus is Null"
                            End If
                        Else
                            dgResult = MessageBox.Show("Are you sure! you have Received demand fully?" & vbCrLf & "Because this was partial receiving demand, so you must verify from partial receiving form," & vbCrLf & "that demand have been received as per requirements", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If dgResult = Windows.Forms.DialogResult.Yes Then
                                Tbl_Pur_DemandDataGridView.Item(8, e.RowIndex).Value = True
                                Tbl_Pur_DemandDataGridView.Item(9, e.RowIndex).Value = Now.Date
                                Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = False
                                SaveDemand()
                                Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                                Me.Tbl_Pur_DemandBindingSource.Filter = "CompStatus is null"
                            End If
                        End If
                    End If
                End If
            End If
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
        frmPartialReceiving.MdiParent = frmMain
        frmPartialReceiving.Show()
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

    Private Sub GMNO_FillBy41()
        If txtGMNO.TextLength > 0 Then
            Try
                Me.Tbl_Pur_DemandTableAdapter.GMNODemandComp_FillBy41(Me.DSPO.tbl_Pur_Demand, txtGMNO.Text)
            Catch ex As Exception
            End Try

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

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ToRefresh()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Me.Tbl_Pur_DemandBindingSource.Filter = "SaleID = " & Val(txtfilterMatName.Text) & ""
            Me.Tbl_Pur_DemandBindingSource.Filter = "Narration Like '%" & Me.ToolStripTextBox1.Text & "%'"

            ContextMenuStrip1.Hide()

        End If
    End Sub

    Private Sub RemoveFIlterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFIlterToolStripMenuItem.Click
        Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
        ContextMenuStrip1.Hide()
    End Sub
End Class