Public Class frmRptSupplierLedger

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.MaterialNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.MaterialNameComboBox.Enabled = True
    End Sub

    Private Sub frmRptSupplierLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsDailyTran.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DsDailyTran.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DsDailyTran.View_Inv_CompName' table. You can move, or remove it, as needed.
        Me.View_Inv_CompNameTableAdapter.Fill(Me.DsDailyTran.View_Inv_CompName)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim Param As String = ""
        Dim obj As New Class_Utility
        If RadioButton1.Checked Then
            Path = "\\server\myreports$\FSERPMM\Bladders\RptCompanyLedger.rpt"
            Filter = "{tbl_MM_Customer.CompanyName} = '" & Me.SupplierNameComboBox.Text & "'"
            Param = "FromDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & "&ToDate= " & Format(Me.DateTimePicker2.Value, "dd/MM/yyyy") & ""
        ElseIf RadioButton2.Checked Then
            Path = "\\server\myreports$\FSERPMM\Bladders\RptCompanyLedgerMat.rpt"
            Filter = "{tbl_MM_Customer.CompanyName} = '" & Me.SupplierNameComboBox.Text & "'"
            Param = "FromDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & "&ToDate= " & Format(Me.DateTimePicker2.Value, "dd/MM/yyyy") & "&Code=" & Me.MaterialNameComboBox.SelectedValue & ""
        End If
        obj.LoadReports(Path, Filter, Param)
    End Sub
End Class