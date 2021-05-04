Public Class frmPartialPO
    Dim obj As New Class_Utility
    Private Sub frmPartialReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Pur_DemandTableAdapter.FillBy28(Me.DSPO.tbl_Pur_Demand, frmProcessDemand.PropertyPDIDNo, frmProcessDemand.PropertyGDNo)
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
        MsgBox("Record Saved")
    End Sub
    Private Sub SaveData()
        Try
            Me.Validate()
            Me.Tbl_Pur_PartialReceivingBindingSource.EndEdit()
            Me.Tbl_Pur_PartialReceivingTableAdapter.Update(Me.DSPO.tbl_Pur_PartialReceiving)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PartialPOStatusCheckBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialPOStatusCheckBox.Click
        Dim SupCodeReturn As Integer
        Dim PartialAmtSum As Double
        Dim PartialQtySum As Double
        Dim AvgUnitPrice As Double
        Dim OtherCharges As Double
        Dim SupplierName As String = Nothing
        Dim MaxPODID As Integer
        If PartialPOStatusCheckBox.CheckState = CheckState.Indeterminate Then
            'MsgBox("Item Code:" & frmProcessDemand.PropertyItemCode & " And SupID:" & frmProcessDemand.PropertySupID)
            SupCodeReturn = Me.Tbl_Pur_Supplier_CodeTableAdapter.FillBy(Me.DSPO.tbl_Pur_Supplier_Code, frmProcessDemand.PropertyItemCode, frmProcessDemand.PropertySupID)
            If SupCodeReturn = 1 Then
                Dim dgResult As DialogResult = MessageBox.Show("Are You Sure, You Want to generate Partial PO for this demand?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dgResult = Windows.Forms.DialogResult.Yes Then
                    PartialPOStatusCheckBox.CheckState = CheckState.Checked
                    If PartialPODateMaskedTextBox.Text = "  /  /" Then
                        PartialPODateMaskedTextBox.Text = Now.Date
                    End If
                    If CashCreditComboBox.Text = "" Then
                        CashCreditComboBox.SelectedItem = "Cash"
                    End If
                    If OtherChargesTextBox.Text = "" Then
                        OtherChargesTextBox.Text = 0
                    End If
                    PartialAmtTextBox.Text = Me.DSPO.tbl_Pur_Supplier_Code(0).Item(4) * Val(PartialQtyTextBox.Text)
                    PartialUnitPriceTextBox.Text = Me.DSPO.tbl_Pur_Supplier_Code(0).Item(4)
                    SaveData()
                    If Me.Tbl_Inv_SupplierTableAdapter.FillBy(Me.DSPO.tbl_Inv_Supplier, frmProcessDemand.PropertySupID) > 0 Then
                        If Me.DSPO.tbl_Inv_Supplier(0).Item(1) IsNot DBNull.Value Then
                            SupplierName = Me.DSPO.tbl_Inv_Supplier(0).Item(1)
                        End If
                    End If
                    PartialAmtSum = Me.Tbl_Pur_PartialReceivingTableAdapter.PartialAmtSum(PDIDLabel1.Text)
                    PartialQtySum = Me.Tbl_Pur_PartialReceivingTableAdapter.PartialSum(PDIDLabel1.Text)
                    AvgUnitPrice = PartialAmtSum / PartialQtySum
                    OtherCharges = Me.Tbl_Pur_PartialReceivingTableAdapter.AvgCharges(Val(PDIDLabel1.Text))

                    Me.Tbl_Pur_DemandTableAdapter.UpdatePurchaseAmt(PartialAmtSum, Now.Date, AvgUnitPrice, PartialQtySum, OtherCharges, Val(PDIDLabel1.Text))
                    'MsgBox(frmProcessDemand.PropertyPOID)
                    If Me.Tbl_Pur_PO_DTableAdapter.MaxPODID(frmProcessDemand.PropertyPOID) Is DBNull.Value Then
                        MaxPODID = 0
                    Else
                        MaxPODID = Me.Tbl_Pur_PO_DTableAdapter.MaxPODID(frmProcessDemand.PropertyPOID)
                    End If
                    Me.Tbl_Pur_PO_DTableAdapter.Insert(frmProcessDemand.PropertyPOID, MaxPODID + 1, frmProcessDemand.PropertySupID, Me.DSPO.tbl_Pur_Supplier_Code(0).Item(1), frmProcessDemand.PropertyPDIDNo, Val(PartialQtyTextBox.Text), Me.DSPO.tbl_Pur_Supplier_Code(0).Item(9), Me.DSPO.tbl_Pur_Supplier_Code(0).Item(4), frmProcessDemand.PropertyUOM, Nothing, Now.Date, Nothing, Nothing, Nothing)
                    MsgBox("Record Saved")
                End If
            Else
                If SupCodeReturn > 1 Then
                    MsgBox("More than One Suppliers Found for the Selected Material, So PO can't be generated")
                Else
                    MsgBox("No Supplier Found for the Selected Material, So PO can't be generated")
                End If
            End If
        End If
    End Sub
    Private Sub frmPartialPO_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        CashCreditComboBox.SelectedItem = "Credit"
    End Sub
End Class