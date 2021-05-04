Public Class frmNewPartialRecAmt
    Private Sub frmPartialReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSVendorInfo.tbl_PUR_Vendor_Info' table. You can move, or remove it, as needed.
        Me.Tbl_PUR_Vendor_InfoTableAdapter.Fill(Me.DSVendorInfo.tbl_PUR_Vendor_Info)
        Try
            Me.Tbl_Pur_DemandTableAdapter.FillBy28(Me.DSPO.tbl_Pur_Demand, frmNewDemandCompletion.PropertyPDIDNo, frmNewDemandCompletion.PropertyGDNo)
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_Inv_L4TableAdapter.FillBy1(Me.DSPO.tbl_Inv_L4, CodeLabel2.Text)
        Catch ex As Exception

        End Try

        Me.Tbl_Pur_PartialReceivingTableAdapter.Fill(Me.DSPO.tbl_Pur_PartialReceiving)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim SupplierName As String = Nothing
        Try
            If MaskedTextBox1.Text = "  /  /" Then
                MaskedTextBox1.Text = Now.Date
            End If
            If OtherChargesTextBox.Text = "" Then
                OtherChargesTextBox.Text = 0
            End If
            If PartialAmtTextBox.Text = "" Then
                PartialAmtTextBox.Text = 0
            End If
            If PartialUnitPriceTextBox.Text = "" Then
                PartialUnitPriceTextBox.Text = 0
            End If
            If CashCreditComboBox.Text = "" Then
                CashCreditComboBox.SelectedItem = "Cash"
            End If

            Me.Validate()
            Me.Tbl_Pur_PartialReceivingBindingSource.EndEdit()
            Me.Tbl_Pur_PartialReceivingTableAdapter.Update(Me.DSPO.tbl_Pur_PartialReceiving)

            Dim PartialAmtSum As Double = Me.Tbl_Pur_PartialReceivingTableAdapter.PartialAmtSum(Val(PDIDLabel1.Text))
            Dim PartialRecQtySum As Double = Me.Tbl_Pur_PartialReceivingTableAdapter.PartialSum(Val(PDIDLabel1.Text))
            Dim AvgOtherCharges As Double = Me.Tbl_Pur_PartialReceivingTableAdapter.AvgCharges(Val(PDIDLabel1.Text))

            Me.Tbl_Pur_DemandTableAdapter.UpdatePurchaseAmt(PartialAmtSum, MaskedTextBox1.Text, PartialAmtSum / PartialRecQtySum, PartialRecQtySum, AvgOtherCharges, Val(PDIDLabel1.Text))
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MaskedTextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.Enter
        If MaskedTextBox1.Text = "  /  /" Then
            MaskedTextBox1.Text = Now.Date
        End If
    End Sub

    Private Sub CashCreditComboBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashCreditComboBox.Enter
        If CashCreditComboBox.Text = "" Then
            CashCreditComboBox.SelectedItem = "Cash"
        End If
    End Sub

End Class