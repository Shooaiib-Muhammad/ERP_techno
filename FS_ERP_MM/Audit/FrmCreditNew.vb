Public Class FrmCreditNew


    Private Sub FrmCreditNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSCredit.tbl_Mat_MeasurementUnits' table. You can move, or remove it, as needed.
        Me.Tbl_Mat_MeasurementUnitsTableAdapter.Fill(Me.DSCredit.tbl_Mat_MeasurementUnits)
        'TODO: This line of code loads data into the 'DSCredit.tbl_Inv_Supplier' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSCredit.tbl_Inv_Supplier)
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DSCredit.tbl_Audit_Credit_debit_invoice' table. You can move, or remove it, as needed.
        Me.Tbl_Audit_Credit_debit_invoiceTableAdapter.Fill(Me.DSCredit.tbl_Audit_Credit_debit_invoice)
        'TODO: This line of code loads data into the 'DSCredit.tbl_Audit_Credit_Debit' table. You can move, or remove it, as needed.
        Me.Tbl_Audit_Credit_DebitTableAdapter.Fill(Me.DSCredit.tbl_Audit_Credit_Debit)
        loadData()
    End Sub
    Private Sub loadData()
        If Me.Tbl_Audit_Credit_DebitTableAdapter.Fill(Me.DSCredit.tbl_Audit_Credit_Debit) > 0 Then
            Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Enabled = True

        Else
            Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Enabled = True

        End If

    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click



        Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Enabled = True
        MaskedTextBox1.Text = Now.Date
        Label4.Text = Val(Tbl_Audit_Credit_DebitTableAdapter.MAX + 1)



    End Sub

    Private Sub Tbl_Audit_Credit_DebitBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Click

        Try
            Tbl_Audit_Credit_DebitBindingSource.EndEdit()
            Tbl_Audit_Credit_DebitTableAdapter.Update(Me.DSCredit.tbl_Audit_Credit_Debit)
            Tbl_Audit_Credit_DebitTableAdapter.Fill(Me.DSCredit.tbl_Audit_Credit_Debit)
            Me.Tbl_Audit_Credit_DebitBindingSource.MoveLast()
            MsgBox("Data Saved")
            Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click


        Try
            Tbl_Audit_Credit_debit_invoiceBindingSource.EndEdit()
            Tbl_Audit_Credit_debit_invoiceTableAdapter.Update(Me.DSCredit.tbl_Audit_Credit_debit_invoice)
            Tbl_Audit_Credit_debit_invoiceTableAdapter.Fill(Me.DSCredit.tbl_Audit_Credit_debit_invoice)
            MsgBox("Data Saved")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Audit_Credit_debit_invoiceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Audit_Credit_debit_invoiceDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Audit_Credit_debit_invoiceDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Audit_Credit_debit_invoiceDataGridView.DataError

    End Sub

    Private Sub Tbl_Audit_Credit_debit_invoiceDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Audit_Credit_debit_invoiceDataGridView.CellEnter
        If e.ColumnIndex = 4 Then
            If Me.Tbl_Audit_Credit_debit_invoiceDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Audit_Credit_debit_invoiceDataGridView(4, e.RowIndex).Value = Now.Date
            End If
        End If

        If e.ColumnIndex = 11 Then
            Try
                Dim TID As Int64 = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(0, e.RowIndex).Value
                Dim InvoiceNo As Int64 = CType(Me.Tbl_Audit_Credit_debit_invoiceDataGridView(1, e.RowIndex).Value, String)
                Dim PCS As Int64 = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(2, e.RowIndex).Value
                Dim UOM As String = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(3, e.RowIndex).Value
                Dim Dater As String = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(4, e.RowIndex).Value
                Dim Reasson As String = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(5, e.RowIndex).Value
                Dim ACtQty As Int64 = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(6, e.RowIndex).Value
                Dim Diff As Int64 = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(7, e.RowIndex).Value
                Dim EXTaxDiff As Int64 = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(8, e.RowIndex).Value
                Dim taxDiff As Int64 = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(9, e.RowIndex).Value
                Dim TotalDIffer As Int64 = Me.Tbl_Audit_Credit_debit_invoiceDataGridView(10, e.RowIndex).Value

                Me.Tbl_Audit_Credit_debit_invoiceTableAdapter.UpdateQuery(InvoiceNo, UOM, Dater, Reasson, ACtQty, Diff, EXTaxDiff, taxDiff, TotalDIffer, PCS, TID)
                MsgBox("Data UpDated")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objFrmFilter As New frmRptViewer
        Filter = "{tbl_Audit_Credit_Debit.TID} = " & Val(Label4.Text) & ""
        objFrmFilter.ViewReport("\\server\MyReports$\FSERPMM\GatePass\RptDEBitCreditNew.rpt", Filter)
        objFrmFilter.MdiParent = frmMain
        objFrmFilter.Show()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox1.GotFocus
        If MaskedTextBox1.Text = "  -  -    " Then
            MaskedTextBox1.Text = Now.Date
        End If
    End Sub
End Class