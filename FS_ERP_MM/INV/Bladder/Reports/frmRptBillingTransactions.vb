Public Class frmRptBillingTransactions

   

    Private Sub frmRptBillingTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSWindedBladderIssuance.tbl_Winded_ExectName' table. You can move, or remove it, as needed.
        Me.Tbl_Winded_ExectNameTableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Winded_ExectName)

    End Sub

    Private Sub btnShowRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRpt.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim obj As New Class_Utility
        Filter = "{View_Bladder_Billing_Transaction.ExeID} = " & Me.ExecuterNameComboBox.SelectedValue & " And {View_Bladder_Billing_Transaction.DateName}=# " & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
        If RadioButton1.Checked Then
            'Filter = "{View_Bladder_Billing_Transaction.ExeID} = " & Me.ExecuterNameComboBox.SelectedValue & " And {View_Bladder_Billing_Transaction.DateName}=# " & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
            If CheckBox1.Checked Then
                Path = "\\server\myreports$\FSERPMM\Billing\RptBladderUnWindingTransactionMaker.rpt"
            Else
                Path = "\\server\myreports$\FSERPMM\Billing\RptBladderUnWindingTransactionAccounts.rpt"
            End If
        ElseIf RadioButton2.Checked Then
            'Filter = "{View_Bladder_Billing_Transaction.ExeID} = " & Me.ExecuterNameComboBox.SelectedValue & " And {View_Bladder_Billing_Transaction.DateName}=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & ""
            If CheckBox1.Checked Then
                Path = "\\server\myreports$\FSERPMM\Billing\RptBladderRepairTransactionMaker.rpt"
            Else
                Path = "\\server\myreports$\FSERPMM\Billing\RptBladderRepairTransactionAccounts.rpt"
            End If
        ElseIf RadioButton3.Checked Then
            'Filter = "{View_Bladder_Billing_Transaction.ExeID} = " & Me.ExecuterNameComboBox.SelectedValue & " And {View_Bladder_Billing_Transaction.DateName}=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & ""
            Path = "\\server\myreports$\FSERPMM\Bladders\RptBladderBalance.rpt"
            Filter = "{View_Repairable_Bladder_Balance_Final.SuplierId} = " & Me.ExecuterNameComboBox.SelectedValue & ""
        ElseIf RadioButton4.Checked Then
            'Filter = "{View_Bladder_Billing_Transaction.ExeID} = " & Me.ExecuterNameComboBox.SelectedValue & " And {View_Bladder_Billing_Transaction.DateName}=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & ""
            Path = "\\server\myreports$\FSERPMM\Bladders\RptBldderSummary.rpt"
            Filter = "{View_Bladder_Rec_Daily.ExectID} = " & Me.ExecuterNameComboBox.SelectedValue & " And {View_Bladder_Rec_Daily.DateName}=# " & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
        End If

        obj.LoadReports(Path, Filter, "")
    End Sub
End Class