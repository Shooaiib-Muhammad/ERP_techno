Public Class NewFromcreditDebit
    Private Sub Tbl_Audit_Credit_DebitBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_Audit_Credit_DebitBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSCredit)

    End Sub

    Private Sub NewFromcreditDebit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSCredit.tbl_Audit_Credit_debit_invoice' table. You can move, or remove it, as needed.
        Me.Tbl_Audit_Credit_debit_invoiceTableAdapter.Fill(Me.DSCredit.tbl_Audit_Credit_debit_invoice)
        'TODO: This line of code loads data into the 'DSCredit.tbl_Audit_Credit_Debit' table. You can move, or remove it, as needed.
        Me.Tbl_Audit_Credit_DebitTableAdapter.Fill(Me.DSCredit.tbl_Audit_Credit_Debit)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Tbl_Audit_Credit_debit_invoiceBindingSource.EndEdit()
            Tbl_Audit_Credit_debit_invoiceTableAdapter.Update(Me.DSCredit.tbl_Audit_Credit_debit_invoice)
            Tbl_Audit_Credit_debit_invoiceTableAdapter.Fill(Me.DSCredit.tbl_Audit_Credit_debit_invoice)
            MsgBox("Data Saved")

        Catch ex As Exception
            MsgBox("Data Not  Saved")
        End Try
    End Sub
End Class