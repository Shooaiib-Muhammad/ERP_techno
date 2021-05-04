Public Class frmOut
    Private Sub frmOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '===========================================================
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSOut.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSOut.tbl_Inv_LocalCust)
        '=========================================================
        Me.Tbl_Inv_L4TableAdapter.FillBy2(Me.DSCode.tbl_Inv_L4)
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSCode.tbl_Inv_L3)
        Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSCode.tbl_Inv_L2)
        Me.Tbl_Inv_L1TableAdapter.Fill(Me.DSCode.tbl_Inv_L1)
        '=========================================================
        Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSOut.tbl_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSOut.tbl_Inv_Tran_Date)
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Me.Tbl_Inv_Tran_OutBindingSource.MoveLast()
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If QtyTextBox.TextLength = 0 Then
            MsgBox("Enter Quantity")
            QtyTextBox.Focus()
        Else
            SaveRecord()
        End If
    End Sub
    Sub SaveRecord()
        Try
            Me.Validate()
            Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSOut.tbl_Inv_Tran_Out)
            ShowResult()
            MsgBox("Record Transaction Out Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'will be activated when invoice system will launched

        'If Val(Me.Balance.Text) = Val(Me.ActQtyLabel1.Text) Then
        '    MsgBox("No Change Commits.")
        'Else
        '    Dim NewUnits As Decimal = Val(Me.Balance.Text)
        '    Dim OldUnits As Decimal = Val(Me.ActQtyLabel1.Text)
        '    Dim Unit As Decimal = OldUnits - NewUnits

        '    Dim NewValue As Decimal = OldUnits - Unit
        '    Try
        '        Me.Tbl_Inv_L4TableAdapter1.Update1(NewValue, Now, Me.L4NameComboBox.SelectedValue)
        '    Catch ex As Exception

        '    End Try
        'End If
        ShowResult()

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
    End Sub
    Private Sub L4NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L4NameComboBox.SelectedIndexChanged
        ShowResult()
    End Sub
    Sub ShowResult()
        Try
            Me.View_Inv_TotalInTableAdapter.Fill(Me.DSOut.View_Inv_TotalIn, Me.L4NameComboBox.SelectedValue)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_Inv_TotalOutTableAdapter.Fill(Me.DSOut.View_Inv_TotalOut, Me.L4NameComboBox.SelectedValue)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Balance.Text = Val(Me.TotalInLabel1.Text) - Val(Me.TotalOutLabel1.Text)
        Catch ex As Exception

        End Try
        Try
            'TODO: This line of code loads data into the 'DSOut.tbl_Inv_L4' table. You can move, or remove it, as needed.
            Me.Tbl_Inv_L4TableAdapter1.FillBy(Me.DSOut.tbl_Inv_L4, Me.L4NameComboBox.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSOut.tbl_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
        Catch ex As Exception

        End Try

    End Sub
    Private Sub NarationTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NarationTextBox.Leave
        If QtyTextBox.TextLength = 0 Then
            MsgBox("Enter Quantity")
            QtyTextBox.Focus()
        Else
            SaveRecord()
            Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
        End If
    End Sub
    Dim a As Integer
    Private Sub QtyTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QtyTextBox.TextChanged
        If QtyTextBox.TextLength > 0 Then
            Me.lblNewBal.Text = Val(Me.Balance.Text) - Val(Me.QtyTextBox.Text)
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.Simple
        Else
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.DropDown
        End If

    End Sub

    Private Sub Tbl_Inv_L4BindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.CurrencyTextBox.Text = Me.CurrencyLabel1.Text
        Me.PPUTextBox.Text = Me.CPPULabel1.Text
        Me.UOMComboBox.Text = Me.UnitLabel1.Text
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Tbl_Inv_Tran_OutBindingSource.CancelEdit()
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
                Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSOut.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
                Me.Tbl_Inv_Tran_OutBindingSource.MoveLast()
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