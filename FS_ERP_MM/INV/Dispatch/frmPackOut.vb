Public Class frmPackOut

    Private Sub frmPackOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Proc_MM_Inv_BalTableAdapter.Fill(Me.DSPackTranOut.Proc_MM_Inv_Bal, CType(Now.Date, Date))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSPackTranOut.tbl_Inv_Tran_Date, CType(Now.Date, Date))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPackTranOut.tbl_Inv_L4)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPackTranOut.tbl_Inv_LocalCust)
        Me.Tbl_Inv_ExternalCustTableAdapter.Fill(Me.DSPackTranOut.tbl_Inv_ExternalCust)
        Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSPackTranOut.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
        Me.Tbl_CompaniesTableAdapter.Fill(Me.DSPackTranOut.tbl_Companies)
        KeyPreview = True
    End Sub

    Private Sub TranTypeComboBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TranTypeComboBox.GotFocus
        If Me.TranTypeComboBox.Text = "" Then
            Me.TranTypeComboBox.Text = "MIR"
            Me.POLabel.Visible = True
            Me.POTextBox.Visible = True
            Me.LocalCustIDLabel.Visible = True
            Me.LocalCustIDComboBox.Visible = True

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False

            Me.ExtCustIDLabel.Visible = False
            Me.ExtCustIDComboBox.Visible = False

        ElseIf Me.TranTypeComboBox.Text = "MIR" Then
            Me.POLabel.Visible = True
            Me.POTextBox.Visible = True
            Me.LocalCustIDLabel.Visible = True
            Me.LocalCustIDComboBox.Visible = True

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False

            Me.ExtCustIDLabel.Visible = False
            Me.ExtCustIDComboBox.Visible = False

        ElseIf Me.TranTypeComboBox.Text = "MTP" Then
            Me.POLabel.Visible = False
            Me.POTextBox.Visible = False
            Me.LocalCustIDLabel.Visible = False
            Me.LocalCustIDComboBox.Visible = False

            Me.CompanyIDLabel.Visible = True
            Me.CompanyIDComboBox.Visible = True

            Me.ExtCustIDLabel.Visible = False
            Me.ExtCustIDComboBox.Visible = False

        ElseIf Me.TranTypeComboBox.Text = "MOGP" Then
            Me.POLabel.Visible = False
            Me.POTextBox.Visible = False
            Me.LocalCustIDLabel.Visible = False
            Me.LocalCustIDComboBox.Visible = False

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False

            Me.ExtCustIDLabel.Visible = True
            Me.ExtCustIDComboBox.Visible = True
        End If
    End Sub
    Private Sub TranTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranTypeComboBox.SelectedIndexChanged
        If Me.TranTypeComboBox.Text = "" Then

            Me.POLabel.Visible = True
            Me.POTextBox.Visible = True
            Me.LocalCustIDLabel.Visible = True
            Me.LocalCustIDComboBox.Visible = True

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False

            Me.ExtCustIDLabel.Visible = False
            Me.ExtCustIDComboBox.Visible = False

        ElseIf Me.TranTypeComboBox.Text = "MIR" Then
            Me.POLabel.Visible = True
            Me.POTextBox.Visible = True
            Me.LocalCustIDLabel.Visible = True
            Me.LocalCustIDComboBox.Visible = True

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False

            Me.ExtCustIDLabel.Visible = False
            Me.ExtCustIDComboBox.Visible = False

        ElseIf Me.TranTypeComboBox.Text = "MTP" Then
            Me.POLabel.Visible = False
            Me.POTextBox.Visible = False
            Me.LocalCustIDLabel.Visible = False
            Me.LocalCustIDComboBox.Visible = False

            Me.CompanyIDLabel.Visible = True
            Me.CompanyIDComboBox.Visible = True

            Me.ExtCustIDLabel.Visible = False
            Me.ExtCustIDComboBox.Visible = False

        ElseIf Me.TranTypeComboBox.Text = "MOGP" Then
            Me.POLabel.Visible = False
            Me.POTextBox.Visible = False
            Me.LocalCustIDLabel.Visible = False
            Me.LocalCustIDComboBox.Visible = False

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False

            Me.ExtCustIDLabel.Visible = True
            Me.ExtCustIDComboBox.Visible = True
        End If
    End Sub

    Private Sub NarationTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NarationTextBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
        If (e.KeyCode = Keys.Z And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.CancelEdit()
        End If
    End Sub
    Private Sub TranTypeComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TranTypeComboBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
            Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPackTranOut.tbl_Inv_L4)
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
        If (e.KeyCode = Keys.Z And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.CancelEdit()
        End If
    End Sub
    Private Sub TranDocNoTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TranDocNoTextBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
            Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPackTranOut.tbl_Inv_L4)
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
        If (e.KeyCode = Keys.Z And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.CancelEdit()
        End If
    End Sub
    Private Sub CodeComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodeComboBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
            Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPackTranOut.tbl_Inv_L4)
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
        If (e.KeyCode = Keys.Z And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.CancelEdit()
        End If
    End Sub
    Private Sub QtyTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QtyTextBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
            Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPackTranOut.tbl_Inv_L4)
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
        If (e.KeyCode = Keys.Z And e.Control) Then
            Me.Tbl_Inv_Tran_OutBindingSource.CancelEdit()
        End If
    End Sub

    Sub SaveRecord()
        If Not Me.TranTypeComboBox.Text = "" Then
            If Not Me.TranDocNoTextBox.Text = "" Then
                If Not Me.CodeComboBox.Text = "" Then
                    If Not Me.QtyTextBox.Text = "" Then
                        If Val(Me.QtyTextBox.Text) <= Val(BalanceLabel1.Text) Then
                            Try
                                Me.Validate()
                                Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
                                Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSPackTranOut.tbl_Inv_Tran_Out)
                                MsgBox("Record Saved.")
                                Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSPackTranOut.tbl_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                            Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
                            Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPackTranOut.tbl_Inv_L4)
                        Else
                            MsgBox("Entered Quantity is Greater Than Material Balance")
                        End If
                    Else
                        MsgBox("Quantity Missing")
                        QtyTextBox.Focus()
                    End If
                Else
                    MsgBox("Material Missing")
                    CodeComboBox.Focus()
                End If
            Else
                MsgBox("Transaction Doc Number Missing")
                TranDocNoTextBox.Focus()
            End If
        Else
            MsgBox("Transaction Type Missing")
            TranTypeComboBox.Focus()
        End If
    End Sub

    Private Sub NarationTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NarationTextBox.Leave
        SaveRecord()
    End Sub
    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Tbl_Inv_L4BindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_L4BindingSource.PositionChanged
        Me.CurrencyLabel2.Text = Me.CurrencyLabel1.Text
        Me.PPULabel1.Text = Me.CPPULabel1.Text
        Me.UOMLabel1.Text = Me.UnitLabel1.Text
    End Sub
End Class