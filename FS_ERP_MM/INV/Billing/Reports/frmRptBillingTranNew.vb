Public Class frmRptBillingTranNew

    Private Sub btnNewRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRpt.Click
        Dim obj As New Class_Utility
        Dim Filter As String = ""
        Dim Path As String = "\\server\myreports$\FSERPMM\Billing\New\RptDailyBilling.rpt"
        'If CheckBox2.Checked Then
        '    Path = "\\server\myreports$\FSERPMM\Billing\New\RptDailyBillingNew.rpt"
        'End If
        Path = "\\server\myreports$\FSERPMM\Billing\New\RptDailyBillingNew.rpt"
        If RadioButton1.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Billing_Transactions.BillRecDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Pending'"
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Billing_Transactions.BillRecDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Done'"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Billing_Transactions.BillRecDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            End If
        ElseIf RadioButton2.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Billing_Transactions.BillRecDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Pending' And {tbl_Billing_Transactions.SupplierID} = " & Me.ComboBox1.SelectedValue & ""
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Billing_Transactions.BillRecDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Done' And {tbl_Billing_Transactions.SupplierID} = " & Me.ComboBox1.SelectedValue & ""
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Billing_Transactions.BillRecDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {tbl_Billing_Transactions.SupplierID} = " & Me.ComboBox1.SelectedValue & ""
            End If
        ElseIf RadioButton3.Checked Then
            If CheckBox2.Checked Then
                If CheckBox1.CheckState = CheckState.Checked Then
                    Filter = "{tbl_Billing_Transactions_Detail.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Pending'"
                ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                    Filter = "{tbl_Billing_Transactions_Detail.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Done'"
                ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                    Filter = "{tbl_Billing_Transactions_Detail.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
                End If
            Else
                If CheckBox1.CheckState = CheckState.Checked Then
                    Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Pending'"
                ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                    Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Done'"
                ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                    Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
                End If
            End If

            'ElseIf RadioButton4.Checked Then
            '    Path = "\\server\myreports$\FSERPMM\Billing\New\RptDailyBillingSummary.rpt"
            '    Filter = "{@Amt} > 0.00"
        ElseIf RadioButton5.Checked Then
            Path = "\\server\myreports$\FSERPMM\Billing\New\RptDailyBillingSummaryNew.rpt"
            Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@ACStatus} = 'Done'"
        ElseIf RadioButton9.Checked Then
            Path = "\\server\myreports$\FSERPMM\Billing\New\RptDailyBillingSummaryNew.rpt"
            Filter = "{tbl_Billing_Transactions.SupplierID}=" & Me.ComboBox1.SelectedValue & " And {tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@ACStatus} = 'Done'"
        ElseIf RadioButton6.Checked Then
            Path = "\\server\myreports$\FSERPMM\Billing\New\RptDailyBillingSummaryNew.rpt"
            Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@ACStatus} = 'Done' And {tbl_Billing_Transactions.SupplierID} = " & Me.ComboBox1.SelectedValue & ""
        ElseIf RadioButton7.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\New\InwardEntries.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
        ElseIf RadioButton8.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\New\OutwardEntries.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"


        ElseIf RadioButton10.Checked = True Then
            Path = "\\server\myreports$\FSERPMM\Billing\RptInvoiceAmount.rpt"
            Filter = "{tbl_Inv_Tran_In.InvoiceDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton11.Checked = True Then
            Path = "\\server\myreports$\FSERPMM\Billing\RptInvoiceAmount.rpt"
            Filter = "{tbl_Inv_Tran_In.InvoiceDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Inv_Tran_In.Code} = '" & Me.ComboBox2.SelectedValue & "'"
        ElseIf RadioButton12.Checked = True Then
            Path = "\\server\myreports$\FSERPMM\Billing\RptInvoiceAmount.rpt"
            Filter = "{tbl_Inv_Supplier.CompanyName} = '" & Me.ComboBox1.Text & "' And {tbl_Inv_Tran_In.InvoiceDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Inv_Tran_In.Code} = '" & Me.ComboBox2.SelectedValue & "'"

        End If

        obj.LoadReports(Path, Filter, "")
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged, RadioButton9.CheckedChanged, RadioButton10.CheckedChanged, RadioButton11.CheckedChanged
        INOUTComboBox.Enabled = False
        Me.ComboBox2.Enabled = False
        If RadioButton1.Checked Or RadioButton3.Checked Or RadioButton5.Checked Or RadioButton6.Checked Or RadioButton10.Checked Then
            Me.ComboBox1.Enabled = False
        ElseIf RadioButton2.Checked Or RadioButton9.Checked Then
            Me.ComboBox1.Enabled = True
        End If
        If RadioButton11.Checked Then
            Me.ComboBox2.Enabled = True
        End If
        'If RadioButton4.Checked Then
        '    Me.DTPicker1.Enabled = False
        '    Me.DTPicker2.Enabled = False
        '    Me.ComboBox1.Enabled = False
        'Else
        '    Me.DTPicker2.Enabled = True
        '    Me.DTPicker1.Enabled = True
        '    Me.ComboBox1.Enabled = True
        'End If
        'If RadioButton7.Checked Or RadioButton8.Checked Then
        '    Me.ComboBox1.Enabled = False
        '    INOUTComboBox.Enabled = True
        '    Me.DTPicker2.Enabled = True
        '    Me.DTPicker1.Enabled = True
        'End If
    End Sub

    Private Sub frmRptBillingTran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsDailyTran.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DsDailyTran.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSBilling.tbl_Supplier' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_SupplierTableAdapter.Fill(Me.DSBilling.tbl_Supplier)
        Catch ex As Exception

        End Try
        Me.Tbl_Billing_PartyTableAdapter.Fill(Me.DSBilling.tbl_Billing_Party)

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            Me.ComboBox1.Enabled = True
            Me.ComboBox2.Enabled = True
        Else
            Me.ComboBox1.Enabled = False
            Me.ComboBox2.Enabled = False
        End If
    End Sub
End Class