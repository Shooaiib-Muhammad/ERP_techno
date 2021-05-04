Public Class frmNewPartialReceiving
    Private Sub frmPartialReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSNewProcurement.tbl_Dept_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Dept_InfoTableAdapter.Fill(Me.DSNewProcurement.tbl_Dept_Info)
        Try
            Me.Tbl_Pur_DemandTableAdapter.FillBy28(Me.DSPO.tbl_Pur_Demand, frmNewVerifyAfterComp.PropertyPDIDNo, frmNewVerifyAfterComp.PropertyGDNo)
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_Inv_L4TableAdapter.FillBy1(Me.DSPO.tbl_Inv_L4, CodeLabel2.Text)
        Catch ex As Exception

        End Try

        Me.Tbl_Pur_PartialReceivingTableAdapter.FillBy(Me.DSPO.tbl_Pur_PartialReceiving)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If PartialQtyTextBox.Text.Length > 0 Then
            If IsNumeric(PartialQtyTextBox.Text) Then
                Try
                    If PatialRecDateMaskedTextBox.Text = "  /  /" Then
                        PatialRecDateMaskedTextBox.Text = Now.Date
                    End If
                    Me.Validate()
                    Me.Tbl_Pur_PartialReceivingBindingSource.EndEdit()
                    Me.Tbl_Pur_PartialReceivingTableAdapter.Update(Me.DSPO.tbl_Pur_PartialReceiving)
                    Dim PartialQty As Integer = Me.Tbl_Pur_PartialReceivingTableAdapter.PartialSum(Val(PDIDLabel1.Text))
                    If PartialQty >= Val(PDQtyLabel1.Text) Then
                        Me.Tbl_Pur_DemandTableAdapter.UpdateCompStatus(True, PatialRecDateMaskedTextBox.Text, False, Val(PDIDLabel1.Text))
                    End If
                    Me.Tbl_Pur_DemandTableAdapter.UpdateReceivingQty(PartialQty, Val(PDIDLabel1.Text))
                    MsgBox("Record Saved")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Record Saving Failed Due to the Error Given Below")
            End If
        End If

    End Sub

    Private Sub PartialQtyTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If PartialQtyTextBox.Text.Length > 0 Then
            If IsNumeric(PartialQtyTextBox.Text) Then
                PartialQtyTextBox.BackColor = Color.Linen
                PartialQtyTextBox.ForeColor = Color.Black
                Label2.Text = ""
            Else
                PartialQtyTextBox.BackColor = Color.Red
                PartialQtyTextBox.ForeColor = Color.White
                Label2.Text = "Numeric Value Required"
            End If
        Else
            PartialQtyTextBox.BackColor = Color.Linen
            PartialQtyTextBox.ForeColor = Color.Black
            Label2.Text = ""
        End If

    End Sub

    'Private Sub PatialRecDateMaskedTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If PatialRecDateMaskedTextBox.Text = "  /  /" Then
    '        PatialRecDateMaskedTextBox.Text = Now.Date
    '    End If
    'End Sub
    Private Sub PartialBillingVerificationCheckBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialBillingVerificationCheckBox.Click
        If Val(PartialAmtTextBox.Text) = 0 Then
            MsgBox("Sorry verification Failed, Partial Amount was Missing or Zero")
        Else
            If PartialBillingVerificationCheckBox.CheckState = CheckState.Indeterminate Then
                Dim dgResult As DialogResult = MessageBox.Show("Are You Sure, You want to verify Accounts status for this demand", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dgResult = Windows.Forms.DialogResult.Yes Then
                    PartialBillingVerificationCheckBox.CheckState = CheckState.Checked
                    VerificationDateMaskedTextBox.Text = Now.Date
                    SaveData()
                End If
            End If
        End If

    End Sub
    Private Sub SaveData()
        Try
            Me.Validate()
            Me.Tbl_Pur_PartialReceivingBindingSource.EndEdit()
            Me.Tbl_Pur_PartialReceivingTableAdapter.Update(Me.DSPO.tbl_Pur_PartialReceiving)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class