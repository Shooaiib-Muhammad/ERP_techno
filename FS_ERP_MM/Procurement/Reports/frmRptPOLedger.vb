Public Class frmRptPOLedger
    Private Sub frmRptPOLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.View_Pur_Supplier_CodeTableAdapter.Fill(Me.DSSupItems.View_Pur_Supplier_Code)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSSupItems.tbl_Inv_Supplier)
    End Sub
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objRptViewer As New Class_Utility

        If Me.RadioButton1.Checked = True Then
            Filter = "{View_Rpt_Pur_Sup_Ledger_H.SupplierID} = " & Me.CompanyNameComboBox.SelectedValue & " AND {View_Rpt_Pur_Sup_Ledger_H2.Code} =  '" & Me.L4NameComboBox.SelectedValue & "'"
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPOLedger.rpt"
        ElseIf RadioButton2.Checked Then
            Filter = "{tbl_MM_Customer.PurchaseStatus}"
            Path = "\\server\myreports$\FSERPMM\Inventory\RptCustItem.rpt"
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Me.CompanyNameComboBox.Enabled = False
            Me.L4NameComboBox.Enabled = False
        Else
            Me.CompanyNameComboBox.Enabled = True
            Me.L4NameComboBox.Enabled = True

        End If
    End Sub
End Class