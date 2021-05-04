Public Class frmBillingParty

    Private Sub Tbl_Billing_PartyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Billing_PartyBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Billing_PartyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSBilling)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmBillingParty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBilling.tbl_Billing_Party' table. You can move, or remove it, as needed.
        Me.Tbl_Billing_PartyTableAdapter.Fill(Me.DSBilling.tbl_Billing_Party)

    End Sub

    Private Sub Tbl_Billing_PartyDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Billing_PartyDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Billing_PartyDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Billing_PartyDataGridView.DataError

    End Sub
End Class