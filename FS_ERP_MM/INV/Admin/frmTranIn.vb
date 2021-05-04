Public Class frmTranIn

    Private Sub frmTranIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '===============================================================
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSTranIn.tbl_Inv_Tran_Date)
        Me.Tbl_Inv_Tran_InTableAdapter.FillBy(Me.DSTranIn.tbl_Inv_Tran_In, Val(Me.DayNoLabel1.Text))
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSTranIn.tbl_Inv_Supplier)
        '===============================================================
        Me.Tbl_Inv_L1TableAdapter.Fill(Me.DSTranInCodeLayer.tbl_Inv_L1)
        Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSTranInCodeLayer.tbl_Inv_L2)
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSTranInCodeLayer.tbl_Inv_L3)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSTranInCodeLayer.tbl_Inv_L4)
        '===============================================================
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Me.Tbl_Inv_Tran_InBindingSource.MoveLast()

    End Sub

    Private Sub CodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeTextBox.TextChanged
        selectmaterial()
    End Sub

    Dim l1 As String
    Dim l2 As String
    Dim l3 As String
    Dim code As String
   
    Sub selectmaterial()
        code = Me.CodeTextBox.Text
        If Not code.Length = 0 Then
            l1 = code.Substring(0, 1)
            l2 = code.Substring(2, 2)
            l3 = code.Substring(5, 3)
            Try
                Me.L1NameComboBox.SelectedValue = l1
            Catch ex As Exception

            End Try
            Try
                Me.L2NameComboBox.SelectedValue = l2
            Catch ex As Exception

            End Try
            Try
                Me.L3NameComboBox.SelectedValue = l3
            Catch ex As Exception

            End Try
            Try
                Me.L4NameComboBox.SelectedValue = code
            Catch ex As Exception

            End Try
        End If
        
    End Sub

    Private Sub SaveIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveIn.Click
        If QtyTextBox.TextLength = 0 Then
            MsgBox("Enter Quantity")
            QtyTextBox.Focus()
        Else
            Dim cppuval As Double = Val(CPPULabel3.Text)
            Dim CPPU As Double = (cppuval + Val(PPUTextBox.Text)) / 2
            Me.Tbl_Inv_L4TableAdapter1.UpdateCPPU(CPPU, Me.L4NameComboBox.SelectedValue)
            Me.Tbl_Inv_L4TableAdapter1.Fill(Me.DSTranIn.tbl_Inv_L4)
            SaveTransaction()
        End If
    End Sub

    Sub SaveTransaction()
        Try
            Me.Validate()
            Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSTranIn.tbl_Inv_Tran_In)
            'showResults()
            MsgBox("Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'will be activated when Invoice system will be activated.

        'If Val(Me.lblBal.Text) = Val(Me.ActQtyLabel1.Text) Then
        '    MsgBox("No Change Commits.")
        'Else
        '    Dim OldAmount As Decimal = (Val(Me.ActQtyLabel1.Text) * Val(Me.CPPULabel1.Text))
        '    Dim NewUnit As Decimal = Val(Me.lblBal.Text) - Val(Me.ActQtyLabel1.Text)
        '    Dim NewAmount As Decimal = (Val(Me.PPUTextBox.Text) * NewUnit)
        '    Dim TotalAmount As Decimal = OldAmount + NewAmount
        '    Dim UnitPrice As Decimal = TotalAmount / Val(Me.lblBal.Text)

        '    Try
        '        Me.ValidateChildren()             ' cppu,  ActQty   
        '        Me.Tbl_Inv_L4TableAdapter1.Update1(UnitPrice, Val(Me.lblBal.Text), Now, Me.L4NameComboBox.SelectedValue)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
        showResults()
    End Sub
    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Me.Tbl_Inv_Tran_InTableAdapter.FillBy(Me.DSTranIn.tbl_Inv_Tran_In, Val(Me.DayNoLabel1.Text))
    End Sub

    Private Sub L4NameComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles L4NameComboBox.SelectedIndexChanged
        showResults()
    End Sub

    Sub showResults()
        Try
            Me.View_Inv_TotalInTableAdapter.Fill(Me.DSTranIn.View_Inv_TotalIn, Me.L4NameComboBox.SelectedValue)
        Catch ex As System.Exception
        End Try
        Try
            Me.View_Inv_TotalOutTableAdapter.Fill(Me.DSTranIn.View_Inv_TotalOut, Me.L4NameComboBox.SelectedValue)
        Catch ex As System.Exception
        End Try
        Me.lblBal.Text = Val(Me.TotalInLabel1.Text) - Val(Me.TotalOutLabel1.Text)
        Try
            Me.Tbl_Inv_L4TableAdapter1.FillBy(Me.DSTranIn.tbl_Inv_L4, Me.L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NarrationTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NarrationTextBox.Leave
        If Me.RadioButton2.Checked = True Then
            If QtyTextBox.TextLength = 0 Then
                MsgBox("Enter Quantity")
                QtyTextBox.Focus()
            Else
                Dim CPPU As Double = (Val(CPPULabel1.Text) + Val(PPUTextBox.Text)) / 2
                Me.Tbl_Inv_L4TableAdapter1.UpdateCPPU(CPPU, Me.L4NameComboBox.SelectedValue)
                Me.Tbl_Inv_L4TableAdapter1.Fill(Me.DSTranIn.tbl_Inv_L4)
                SaveTransaction()
                Me.Tbl_Inv_Tran_InBindingSource.AddNew()
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_L4BindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_L4BindingSource.PositionChanged
        Me.PPUTextBox.Text = Me.CPPULabel3.Text
        Me.CurrencyTextBox.Text = Me.CurrencyLabel1.Text
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Tbl_Inv_Tran_InBindingSource.CancelEdit()
    End Sub

    Private Sub QtyTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtyTextBox.TextChanged
        If QtyTextBox.TextLength > 0 Then
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.Simple
        Else
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub

    Private Sub CMtxtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtDate.GotFocus
        If CMtxtDate.Text = "Enter First Date" Then
            CMtxtDate.Text = ""
            CMtxtDate.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CMtxtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtDate.KeyDown
        If e.KeyCode = Keys.Enter And Me.CMtxtDate.Text.Length > 0 Then
            Dim mydate As System.DateTime
            Try
                mydate = CDate("#" & Me.CMtxtDate.Text & "#")
            Catch ex As Exception
                MsgBox("Enter the Correct Date Format.")
            End Try
            Me.Tbl_Inv_Tran_DateBindingSource.Filter = "DateName = '" & mydate & "'"
            Try
                Me.Tbl_Inv_Tran_InTableAdapter.FillBy(Me.DSTranIn.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
                Me.Tbl_Inv_Tran_InBindingSource.MoveLast()
            Catch ex As Exception
                'MsgBox("This Date Not Exist")
            End Try
            Me.CMtxtDate.Text = "Enter First Date"
            Me.CMtxtDate.ForeColor = Color.Silver
            Me.CMSDate.Hide()
        End If
    End Sub

    Private Sub CMtxtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtDate.LostFocus
        If CMtxtDate.Text = "" Then
            CMtxtDate.Text = "Enter First Date"
            CMtxtDate.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_Inv_Tran_DateBindingSource.RemoveFilter()
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub
End Class