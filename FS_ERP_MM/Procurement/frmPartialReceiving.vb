Public Class frmPartialReceiving
    Private Sub frmPartialReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If PartialQtyTextBox.Text.Length > 0 Then
            If IsNumeric(PartialQtyTextBox.Text) Then
                Try
                    If PatialRecDateMaskedTextBox.Text = "  /  /" Then
                        PatialRecDateMaskedTextBox.Text = Now.Date
                    End If
                    Me.Validate()
                    Me.Tbl_Pur_PartialReceivingBindingSource.EndEdit()
                    Me.Tbl_Pur_PartialReceivingTableAdapter.Update(Me.DSPO.tbl_Pur_PartialReceiving)
                    If flag = True Then
                        Me.Tbl_Pur_DemandTableAdapter.UpdateReceivingQty(0, Val(PDIDLabel1.Text))
                        Me.Tbl_Pur_DemandTableAdapter.UpdateCompStatus(False, Nothing, False, Val(PDIDLabel1.Text))
                    Else
                        flag = False
                        Dim PartialQty As Integer = Me.Tbl_Pur_PartialReceivingTableAdapter.PartialSum(Val(PDIDLabel1.Text))
                        If PartialQty >= Val(PDQtyLabel1.Text) Then
                            Me.Tbl_Pur_DemandTableAdapter.UpdateCompStatus(True, PatialRecDateMaskedTextBox.Text, False, Val(PDIDLabel1.Text))
                        End If
                        Me.Tbl_Pur_DemandTableAdapter.UpdateReceivingQty(PartialQty, Val(PDIDLabel1.Text))
                    End If

                    MsgBox("Record Saved")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Record Saving Failed Due to the Error Given Below")
            End If
        End If

    End Sub

    Private Sub PartialQtyTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialQtyTextBox.TextChanged
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

    Private Sub PatialRecDateMaskedTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatialRecDateMaskedTextBox.Enter
        If PatialRecDateMaskedTextBox.Text = "  /  /" Then
            PatialRecDateMaskedTextBox.Text = Now.Date
        End If
    End Sub
    Dim flag As Boolean = False
    Private Sub BindingNavigatorDeleteItem2_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem2.Click
        flag = True
    End Sub
End Class