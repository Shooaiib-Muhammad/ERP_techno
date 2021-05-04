Public Class frmPOIn
    Dim PositionPO As Integer
    Private Sub CMtxtTranDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtTranDate.GotFocus
        If CMtxtTranDate.Text = "Enter First Date" Then
            CMtxtTranDate.Text = ""
            CMtxtTranDate.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CMtxtTranDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtTranDate.KeyDown
        If e.KeyCode = Keys.Enter And Me.CMtxtTranDate.Text.Length > 0 Then
            Dim Mydate As System.DateTime
            Try
                Mydate = CDate("#" & Me.CMtxtTranDate.Text & "#")
            Catch ex As Exception
                MsgBox("Enter The Correct Date Format.")
            End Try
            Me.Tbl_Inv_Tran_DateBindingSource.Filter = "DateName = '" & Mydate & "'"
            'Filterflag = True
            'LoadHead()
            Me.CMtxtTranDate.Text = "Enter First Date"
            Me.CMtxtTranDate.ForeColor = Color.Silver
            Me.CMSTranDate.Hide()
        End If
    End Sub

    Private Sub CMtxtTranDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtTranDate.LostFocus
        If CMtxtTranDate.Text = "" Then
            CMtxtTranDate.Text = "Enter First Date"
            CMtxtTranDate.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub frmPOIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSPOR.tbl_Inv_Rack_Info)
        Catch ex As Exception

        End Try
        Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.Fill(Me.DSPOR.tbl_Pur_UnitofMeasurementDtl)
        Try
            'Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSPOR.tbl_Inv_Tran_Date, CDate(Now.Date))
        Catch ex As System.Exception
        End Try
        Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DSPOR.tbl_Inv_Tran_Date)
        Me.Tbl_Inv_Tran_DateBindingSource.Sort = "DateName ASC"
        Try
            Me.View_PO_PandingTableAdapter.Fill(Me.DSPOR.View_PO_Panding)
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSPOR.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
        Try
            Me.View_PO_DTableAdapter.FillBy(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
        'Me.Tbl_Pur_PO_DTableAdapter.Fill(Me.DSPOR.tbl_Pur_PO_D)
        Me.Tbl_Inv_Tran_InBindingSource.MoveLast()
        If Me.DateNameLabel1.Text = Nothing Then
            ShowButtons(False, False)
        Else
            If Me.Tbl_Inv_Tran_InBindingSource.Count > 0 Then
                ShowButtons(True, True)
            Else
                ShowButtons(True, False)
            End If
        End If
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub
    Dim flag As Boolean = False
    Sub ShowButtons(ByVal Add As Boolean, ByVal Delete As Boolean)
        AddPOs.Visible = Add
        DeletePOs.Visible = Delete
        SavePOs.Visible = Delete
        UndoPOs.Visible = Delete
        Me.L4NameComboBox.Enabled = Delete
    End Sub
    Private Sub btnMRIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMRIN.Click
        Dim objRptViewer As New Class_Utility
        objRptViewer.LoadReports("\\Server\Myreports$\FSERPMM\Inventory\New\RptMRIN.rpt", "{View_Purchase_Order_MRIN.DayNo} = " & Val(DayNoLabel1.Text) & " AND {View_Purchase_Order_MRIN.SupplierID} = " & Val(SupplierIDLabel1.Text), Nothing)
    End Sub
    Dim OQty As Integer
    Dim POBalance As Integer
    Private Sub CurrencyValue() 'Method for Non PKR Currency And Calculated Weighted Average Cost
        Dim OldUnit, NewUnit, TotalUnit As Double
        Dim OldCost, NewCost, TotalCost As Double
        Dim OldValue, NewValue, TotalValue As Double
        Dim Currency As String = CurrencyLabel1.Text.Trim
        'For Old Units
        OldUnit = Me.Proc_MM_Inv_BalTableAdapter.SelectMatBalanceQuery(Me.L4NameComboBox.SelectedValue)
        Try
            OldCost = Me.Tbl_Inv_L4TableAdapter.SelelctCPPUQuery(Me.L4NameComboBox.SelectedValue)
        Catch ex As Exception
            OldCost = Nothing
        End Try
        Me.LWACLabel1.Text = OldCost
        OldValue = OldUnit * OldCost
        'For New Unit
        If Not Currency = "PKR" Then
            Dim CurrencyValue As Double
            Try
                CurrencyValue = InputBox("Enter " & Currency & " Value")
            Catch ex As Exception
                MsgBox("Enter " & Currency & " Value")
            End Try
            If CurrencyValue > 0 Then
                Dim UnitPrice As Double = Val(Me.PPULabel2.Text)
                NewCost = UnitPrice * CurrencyValue
                Me.PPULabel2.Text = NewCost
                Me.CurrencyLabel1.Text = "PKR"
            End If
        Else
            NewCost = Val(Me.PPULabel2.Text)
        End If
        'NewUnit = Val(Me.QtyTextBox.Text)
        'NewValue = NewCost * NewUnit
        'TotalUnit = OldUnit + NewUnit
        'TotalValue = OldValue + NewValue
        TotalCost = NewCost
        If TotalCost > 0 Then
            Me.Tbl_Inv_L4TableAdapter.UpdateCPPU(TotalCost, Me.L4NameComboBox.SelectedValue)
        End If
    End Sub
    Sub Save(ByVal QtyValue As Double, ByVal ParaUOMValue As Double)
        If QtyValue <= POBalance And PObalflag = False Then
            'Method for Non PKR Currency And Calculated Weighted Average Cost Used Here 
            CurrencyValue()
            Try
                Me.Validate()
                Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
                Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSPOR.tbl_Inv_Tran_In)
                MsgBox("Record Saved")
                If QtyValue < POBalance And (POBalance - QtyValue) > (POBalance * 0.05) Then
                    Me.View_PO_DTableAdapter.FillBy(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                    Me.View_PO_DBindingSource.Position = PositionPO
                ElseIf QtyValue = POBalance Or (POBalance - QtyValue) <= (POBalance * 0.05) Then
                    Me.View_PO_DTableAdapter.FillBy1(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                    Me.View_PO_DBindingSource.Position = PositionPO
                    Me.Tbl_Pur_PO_DTableAdapter.UpdateQuery(True, Now.Date, POIDLabel2.Text, PODNoLabel2.Text)
                    Me.View_PO_DTableAdapter.FillBy(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                    Me.View_PO_DBindingSource.Position = PositionPO
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf PObalflag = False And QtyValue > POBalance Then
            Dim btnMsg As DialogResult
            btnMsg = MessageBox.Show("Enter Quantity And Recieved Quantity is Greater Than Order Quantity " & vbCrLf & " Are You Sure Want To Save It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                If ParaUOMValue = 0 Then
                    If QtyValue > POBalance + 20 Then
                        QtyTextBox.Text = POBalance + 20
                    Else
                        QtyTextBox.Text = QtyValue
                    End If
                    'Else
                    '    If QtyValue > POBalance + 20 Then
                    '        QtyTextBox.Text = POBalance + 20
                    '    Else
                    '        QtyTextBox.Text = QtyValue
                    '    End If
                End If
                
                'Method For Non PKR Currency And Calculated Weighted Average Cost Used here 
                CurrencyValue()
                Try
                    Me.Validate()
                    Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
                    Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSPOR.tbl_Inv_Tran_In)
                    MsgBox("Record Saved")
                    If Val(Me.QtyTextBox.Text) > POBalance Then
                        Me.View_PO_DTableAdapter.FillBy1(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                        Me.View_PO_DBindingSource.Position = PositionPO
                        Me.Tbl_Pur_PO_DTableAdapter.UpdateQuery(True, Now.Date, POIDLabel2.Text, PODNoLabel2.Text)
                        Me.View_PO_DTableAdapter.FillBy(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                        Me.View_PO_DBindingSource.Position = PositionPO
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Me.QtyTextBox.Clear()
                MsgBox("Record Not Saved")
            End If
        Else
            'Method for Non PKR Currency And Calculated Weighted Average Cost 
            CurrencyValue()
            Try
                Me.Validate()
                Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
                Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSPOR.tbl_Inv_Tran_In)
                PObalflag = False
                MsgBox("Record Saved")
                If Val(Me.QtyTextBox.Text) >= POBalance Then
                    Me.View_PO_DTableAdapter.FillBy1(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                    Me.View_PO_DBindingSource.Position = PositionPO
                    Me.Tbl_Pur_PO_DTableAdapter.UpdateQuery(True, Now.Date, POIDLabel2.Text, PODNoLabel2.Text)
                    Me.View_PO_DTableAdapter.FillBy(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                    Me.View_PO_DBindingSource.Position = PositionPO
                Else
                    Me.View_PO_DTableAdapter.FillBy(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                    Me.View_PO_DBindingSource.Position = PositionPO
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Dim PObalflag As Boolean = False
    Private Sub View_PO_PandingBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles View_PO_PandingBindingSource.PositionChanged
        Try
            Me.View_PO_DTableAdapter.FillBy(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub QtyTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtyTextBox.TextChanged
        If QtyTextBox.TextLength > 0 Then
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.Simple
        Else
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub
    Dim Receive As Integer
    Dim OtherCharge As Double
    Private Sub View_PO_DDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_PO_DDataGridView.CellEnter
        OQty = Me.View_PO_DDataGridView(8, e.RowIndex).Value
        POBalance = Me.View_PO_DDataGridView(12, e.RowIndex).Value
        Receive = Me.View_PO_DDataGridView(14, e.RowIndex).Value
        If Me.QtyTextBox.Text.Length <= 0 Then
            Me.POIDLabel2.Text = Me.View_PO_DDataGridView(1, e.RowIndex).Value
            Me.PODNoLabel2.Text = Me.View_PO_DDataGridView(2, e.RowIndex).Value
            Me.UOMLabel1.Text = Me.View_PO_DDataGridView(11, e.RowIndex).Value
            Me.SupplierIDLabel1.Text = Me.View_PO_DDataGridView(3, e.RowIndex).Value
            If Not Me.View_PO_DDataGridView(15, e.RowIndex).Value Is DBNull.Value Then
                OtherCharge = Me.View_PO_DDataGridView(15, e.RowIndex).Value
            Else
                OtherCharge = 0
            End If
            Me.Formula1.Text = Me.View_PO_DDataGridView(16, e.RowIndex).Value
            Me.PPULabel2.Text = Me.View_PO_DDataGridView(10, e.RowIndex).Value + OtherCharge
            Me.CurrencyLabel1.Text = Me.View_PO_DDataGridView(9, e.RowIndex).Value.ToString.Trim
        End If
    End Sub
    Private Sub View_PO_DDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_PO_DDataGridView.DataError
    End Sub
    Private Sub AddPOs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPOs.Click
        flag = True
        Try
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
            Me.View_PO_PandingTableAdapter.FillBy(Me.DSPOR.View_PO_Panding)
        Catch ex As Exception
        End Try
        ShowButtons(True, True)
    End Sub
    Private Sub DeletePOs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePOs.Click
        Dim MyPosition As Integer = Me.Tbl_Inv_Tran_InBindingSource.Position
        Dim btnMsg As DialogResult
        btnMsg = MessageBox.Show("Are You Sure Want To Delete It?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Me.Tbl_Pur_PO_DTableAdapter.UpdateQuery(False, Nothing, POIDLabel2.Text, PODNoLabel2.Text)
            Dim Status As Integer = Me.Tbl_Pur_PO_DTableAdapter.SelectQuery(Me.POIDLabel2.Text, Me.PODNoLabel2.Text)
            If Status = 0 Then
                Dim LWAC As Double = Me.Tbl_Inv_Tran_InTableAdapter.SelectLWACQuery(Val(Me.TranInIDTextBox.Text), Me.L4NameComboBox.SelectedValue)
                Me.Tbl_Inv_L4TableAdapter.UpdateCPPU(LWAC, Me.L4NameComboBox.SelectedValue)
                Me.Tbl_Inv_Tran_InTableAdapter.DeleteQuery(Val(Me.TranInIDTextBox.Text))
                Me.Proc_MM_Inv_BalTableAdapter.FillBy(Me.DSPOR.Proc_MM_Inv_Bal, Me.L4NameComboBox.SelectedValue)
                Try
                    Me.View_PO_DTableAdapter.FillBy(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                Catch ex As Exception
                End Try
                Me.Tbl_Inv_Tran_InTableAdapter.FillBy(Me.DSPOR.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
            Else
                Me.Tbl_Pur_PO_DBindingSource.CancelEdit()
            End If
        Else
        End If
        Me.Tbl_Inv_Tran_InBindingSource.Position = MyPosition
        If TranInIDTextBox.Text = "" Then
            ShowButtons(True, False)
        Else
            ShowButtons(True, True)
        End If
    End Sub
    Dim UOMValue As Double = 0
    Private Sub SavePOs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePOs.Click
        If flag = True Then
            flag = False
            UOMValue = 0
            Dim PositionIn As Integer = Tbl_Inv_Tran_InBindingSource.Position
            PositionPO = View_PO_DBindingSource.Position
            Dim UOM As String = Me.View_PO_PandingTableAdapter.SelectQuery(Me.L4NameComboBox.SelectedValue)
            Dim QtyValue As Double = Val(Me.QtyTextBox.Text)
            If UOM = UOMLabel1.Text Then
                Save(Val(QtyTextBox.Text), UOMValue)
                Me.Proc_MM_Inv_BalTableAdapter.FillBy(Me.DSPOR.Proc_MM_Inv_Bal, Me.L4NameComboBox.SelectedValue)
            Else
                Try
                    UOMValue = Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.SelectUOMQuery(UOM, Me.L4NameComboBox.SelectedValue, UOMLabel1.Text)
                Catch ex As Exception
                End Try
                If UOMValue > 0 Then
                    Me.PPULabel2.Text = Val(PPULabel2.Text) / UOMValue
                    QtyTextBox.Text = Val(QtyTextBox.Text) * UOMValue
                    UOMLabel1.Text = UOM
                    Save(QtyValue, UOMValue)
                Else
                    MsgBox("Record Not Saved " & vbCrLf & "Unit Of Measurement Difference")
                    Me.QtyTextBox.Clear()
                End If
            End If
            Me.View_PO_PandingTableAdapter.Fill(Me.DSPOR.View_PO_Panding)
            Me.Tbl_Inv_Tran_InTableAdapter.FillBy(Me.DSPOR.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
            Tbl_Inv_Tran_InBindingSource.Position = PositionIn
            View_PO_DBindingSource.Position = PositionPO
        Else
            Try
                Me.ValidateChildren()
                Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
                Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSPOR.tbl_Inv_Tran_In)
                MsgBox("Record Entered Successfully")
            Catch ex As Exception

            End Try
        End If
        
    End Sub
    Private Sub UndoPOs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoPOs.Click
        Me.View_PO_PandingTableAdapter.Fill(Me.DSPOR.View_PO_Panding)
        Me.Tbl_Inv_Tran_InBindingSource.CancelEdit()
        If TranInIDTextBox.Text = "" Then
            ShowButtons(True, False)
        Else
            ShowButtons(True, True)
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim position As Integer = Me.Tbl_Inv_Tran_DateBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_DateTableAdapter.Update(Me.DSPOR.tbl_Inv_Tran_Date)
            Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DSPOR.tbl_Inv_Tran_Date)
            Me.Tbl_Inv_Tran_DateBindingSource.Position = position
            MsgBox("Date Added Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
            If Me.DateNameMaskedTextBox.Text = Now.Date Then
                ShowButtons(True, True)
                Me.QtyTextBox.Enabled = True
            Else
                ShowButtons(False, False)
                Me.QtyTextBox.Enabled = False
                SavePOs.Visible = True
            End If
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSPOR.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_Inv_Tran_DateBindingSource.RemoveFilter()
    End Sub

    Private Sub View_PO_DDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_PO_DDataGridView.CellContentClick

    End Sub
End Class