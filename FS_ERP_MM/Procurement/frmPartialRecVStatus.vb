Public Class frmPartialRecVStatus

    Private Sub frmPartialReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Pur_DemandTableAdapter.FillBy28(Me.DSPO.tbl_Pur_Demand, frmVerifyAfterComp.PropertyPDIDNo, frmVerifyAfterComp.PropertyGDNo)
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_Inv_L4TableAdapter.FillBy1(Me.DSPO.tbl_Inv_L4, CodeLabel2.Text)
        Catch ex As Exception

        End Try

        Me.Tbl_Pur_PartialReceivingTableAdapter.Fill(Me.DSPO.tbl_Pur_PartialReceiving)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveData()
    End Sub

    Private Sub PartialBillingVerificationCheckBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialBillingVerificationCheckBox.Click
        If Val(TextBox1.Text) = 0 Then
            MsgBox("Sorry verification Failed, Partial Amount was Missing or Zero")
        Else
            If PartialBillingVerificationCheckBox.CheckState = CheckState.Indeterminate Then
                Dim dgResult As DialogResult = MessageBox.Show("Are You Sure, You want to verify Billing status for this demand", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
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

   
   
    Private Sub PartialBillingVerificationCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialBillingVerificationCheckBox.CheckedChanged

    End Sub
End Class