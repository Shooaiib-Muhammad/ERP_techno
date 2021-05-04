Public Class frmDispatchPOsReceive
    Private Sub frmDispatchPOsReceive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DsDispatchPOs.tbl_Inv_Tran_Date, CType(Now.Date, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.View_PO_PandingTableAdapter.Fill(Me.DsDispatchPOs.View_PO_Panding)
        Try
            Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DsDispatchPOs.tbl_Inv_Tran_In)
        Catch ex As Exception
        End Try
        Me.View_PO_DTableAdapter.FillBy(Me.DsDispatchPOs.View_PO_D, Me.L4NameComboBox.SelectedValue)
        Me.Tbl_Pur_PO_DTableAdapter.Fill(Me.DsDispatchPOs.tbl_Pur_PO_D)
        Me.Tbl_Inv_Tran_InBindingSource.MoveLast()
    End Sub
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        Try
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
            Me.View_PO_PandingTableAdapter.FillBy(Me.DsDispatchPOs.View_PO_Panding)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim MyPosition As Integer = Me.Tbl_Inv_Tran_InBindingSource.Position
        Dim btnMsg As DialogResult
        btnMsg = MessageBox.Show("Are You Sure Want To Delete It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Me.Tbl_Pur_PO_DTableAdapter.UpdateQuery(False, Nothing, POIDLabel2.Text, PODNoLabel2.Text)
            Dim Status As Integer = Me.Tbl_Pur_PO_DTableAdapter.SelectQuery(Me.POIDLabel2.Text, Me.PODNoLabel2.Text)
            If Status = 0 Then
                Me.Tbl_Inv_Tran_InTableAdapter.DeleteQuery(Val(Me.TranInIDLabel2.Text))
                Me.Tbl_Inv_Tran_InTableAdapter.FillBy(Me.DsDispatchPOs.tbl_Inv_Tran_In, Val(Me.DayNoLabel1.Text))
                'Me.View_PO_DTableAdapter.Fill(Me.DSPOR.View_PO_D)
                Me.View_PO_DTableAdapter.FillBy(Me.DsDispatchPOs.View_PO_D, Me.L4NameComboBox.SelectedValue)
            Else
                Me.Tbl_Pur_PO_DBindingSource.CancelEdit()
            End If
        Else

        End If
        Me.Tbl_Inv_Tran_InBindingSource.Position = MyPosition
    End Sub
    Dim PO As Integer
    Dim POD As Integer
    Dim Currency As String = Nothing
    Dim Myrow As Integer
    Dim OQty As Integer
    Dim POBalance As Integer
    Private Sub CurrencyValue()
        Dim Currency As String = CurrencyLabel1.Text
        Dim TotalCurrency As Double
        If Not Currency = "PKR" Then
            Dim CurrencyValue As Double
            Try
                CurrencyValue = InputBox("Enter " & Currency & " Value")
            Catch ex As Exception
                MsgBox("Enter " & Currency & " Value")
            End Try
            If CurrencyValue > 1 Then
                Dim UnitPrice As Double = Me.Tbl_Pur_PO_DTableAdapter.SelectUnitPriceQuery(Val(Me.POIDLabel2.Text), Val(PODNoLabel2.Text))
                TotalCurrency = UnitPrice * CurrencyValue
            End If
        Else
            TotalCurrency = Val(Me.PPULabel2.Text)
        End If
        Dim CPPU As Double = Val(Me.CPPULabel1.Text)
        If CPPU = 0.0 Then
            CPPU = TotalCurrency
        Else
            CPPU = (CPPU + TotalCurrency) / 2
        End If
        Me.Tbl_Inv_L4TableAdapter.UpdateCPPU(CPPU, Me.L4NameComboBox.SelectedValue)
        Me.Tbl_Inv_L4TableAdapter.UpdateCurrencyQuery(Me.L4NameComboBox.SelectedValue)
        'Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DsDispatchPOs.tbl_Inv_Tran_In)
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim PositionIn As Integer = Tbl_Inv_Tran_InBindingSource.Position
        Dim PositionPO As Integer = View_PO_DBindingSource.Position
        If QtyTextBox.TextLength > 0 Then
            If Val(Me.QtyTextBox.Text) <= POBalance Then
                Try
                    Me.Validate()
                    Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
                    Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DsDispatchPOs.tbl_Inv_Tran_In)
                    MsgBox("Record Saved")
                    If Val(Me.QtyTextBox.Text) < POBalance Then
                        Me.View_PO_DTableAdapter.FillBy(Me.DsDispatchPOs.View_PO_D, Me.L4NameComboBox.SelectedValue)
                        Me.View_PO_DBindingSource.Position = PositionPO
                    ElseIf Val(Me.QtyTextBox.Text) = POBalance Then
                        Me.View_PO_DTableAdapter.FillBy1(Me.DsDispatchPOs.View_PO_D, Me.L4NameComboBox.SelectedValue)
                        Me.View_PO_DBindingSource.Position = PositionPO
                        Me.Tbl_Pur_PO_DTableAdapter.UpdateQuery(True, Now.Date, POIDLabel2.Text, PODNoLabel2.Text)
                        Me.View_PO_DTableAdapter.FillBy(Me.DsDispatchPOs.View_PO_D, Me.L4NameComboBox.SelectedValue)
                        Me.View_PO_DBindingSource.Position = PositionPO
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                '  Function for Non PKR Currency 

                CurrencyValue()
            Else
                Dim btnMsg As DialogResult
                btnMsg = MessageBox.Show("Enter Quantity and Recieved Quantity is Greater than Order Quantity " & vbCrLf & "Are You Sure Want To Save It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If btnMsg = Windows.Forms.DialogResult.Yes Then
                    Try
                        Me.Validate()
                        Me.Tbl_Inv_Tran_InBindingSource.EndEdit()

                        Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DsDispatchPOs.tbl_Inv_Tran_In)
                        MsgBox("Record Saved")
                        If Val(Me.QtyTextBox.Text) > POBalance Then
                            Me.View_PO_DTableAdapter.FillBy1(Me.DsDispatchPOs.View_PO_D, Me.L4NameComboBox.SelectedValue)
                            Me.View_PO_DBindingSource.Position = PositionPO
                            Me.Tbl_Pur_PO_DTableAdapter.UpdateQuery(True, Now.Date, POIDLabel2.Text, PODNoLabel2.Text)
                            Me.View_PO_DTableAdapter.FillBy(Me.DsDispatchPOs.View_PO_D, Me.L4NameComboBox.SelectedValue)
                            Me.View_PO_DBindingSource.Position = PositionPO
                        End If

                        '  Function for Non PKR Currency 

                        CurrencyValue()

                        'If POBalance < 0 Then
                        '    Me.Tbl_Pur_PO_DTableAdapter.UpdateQuery(True, Now.Date, POIDLabel2.Text, PODNoLabel2.Text)
                        '    Me.View_PO_DTableAdapter.FillBy1(Me.DSPOR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                        '    Me.View_PO_DBindingSource.Position = PositionPO
                        'End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Me.QtyTextBox.Clear()
                    MsgBox("Record Not Saved")
                End If
            End If
        End If
        Tbl_Inv_Tran_InBindingSource.Position = PositionIn
        View_PO_DBindingSource.Position = PositionPO
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.View_PO_PandingTableAdapter.Fill(Me.DsDispatchPOs.View_PO_Panding)
        Me.Tbl_Inv_Tran_InBindingSource.CancelEdit()
    End Sub
    Private Sub View_PO_DDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_PO_DDataGridView.CellEnter
        OQty = Me.View_PO_DDataGridView(8, e.RowIndex).Value
        POBalance = Me.View_PO_DDataGridView(12, e.RowIndex).Value
        If Me.QtyTextBox.Text.Length <= 0 Then
            Me.POIDLabel2.Text = Me.View_PO_DDataGridView(1, e.RowIndex).Value
            Me.PODNoLabel2.Text = Me.View_PO_DDataGridView(2, e.RowIndex).Value
            Me.UOMLabel1.Text = Me.View_PO_DDataGridView(11, e.RowIndex).Value
            Me.SupplierIDLabel1.Text = Me.View_PO_DDataGridView(3, e.RowIndex).Value
            Me.PPULabel2.Text = Me.View_PO_DDataGridView(10, e.RowIndex).Value
            Me.CurrencyLabel1.Text = Me.View_PO_DDataGridView(9, e.RowIndex).Value
        End If
    End Sub
    Private Sub View_PO_PandingBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles View_PO_PandingBindingSource.PositionChanged
        Try
            Me.View_PO_DTableAdapter.FillBy(Me.DsDispatchPOs.View_PO_D, Me.L4NameComboBox.SelectedValue)
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

    Private Sub View_PO_DDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_PO_DDataGridView.DataError

    End Sub

    Private Sub btnMRIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMRIN.Click
        If ChildWindowOpen("frmRptViewer") = False Then
            Dim objForm As New frmRptViewer
            Dim filter As String = "{View_Purchase_Order_MRIN.DayNo} = " & Val(DayNoLabel1.Text) & " AND {View_Purchase_Order_MRIN.SupplierID} = " & Val(SupplierIDLabel1.Text)
            objForm.ViewReport("\\server\myreports$\FSERPMM\Inventory\New\RptMRIN.rpt", filter, )
            objForm.MdiParent = frmMain
            objForm.Show()
        End If
    End Sub
    Function ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.WindowState = FormWindowState.Maximized
                Return True
            End If
        Next
        Return False
    End Function
End Class