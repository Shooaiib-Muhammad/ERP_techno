Public Class frmRptSaleInvoice
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Me.SIDComboBox.Enabled = True
            Me.SIDComboBox1.Enabled = True
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
            Me.CustomerNameComboBox.Enabled = False
        End If
    End Sub
    Sub ShowContents(ByVal SID As Boolean, ByVal Dt As Boolean, ByVal Cust As Boolean)
        Me.SIDComboBox.Enabled = SID
        Me.SIDComboBox1.Enabled = SID
        Me.DateTimePicker1.Enabled = Dt
        Me.DateTimePicker2.Enabled = Dt
        Me.CustomerNameComboBox.Enabled = Cust
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ShowContents(False, True, False)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        ShowContents(False, False, True)
    End Sub

    Private Sub Tbl_MM_CustomerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_MM_CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsRptSale)

    End Sub

    Private Sub frmRptSaleInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_MM_Sale1TableAdapter.Fill(Me.DsRptSale.tbl_MM_Sale1)
        Me.Tbl_MM_SaleTableAdapter.Fill(Me.DsRptSale.tbl_MM_Sale)
        Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DsRptSale.tbl_MM_Customer)
    End Sub

    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        If frmLoginVer.DeptID = 24 Then
            Path = "" & frmLoginVer.Reportpath & "\RptSale1.rpt"
        Else
            Path = "" & frmLoginVer.Reportpath & "\RptSale.rpt"
        End If
        If RadioButton1.Checked Then

            Filter = "{tbl_MM_Sale.SID} in " & Me.SIDComboBox.SelectedValue & " to " & Me.SIDComboBox1.SelectedValue & ""
        ElseIf RadioButton2.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptSale.rpt"
            Filter = "{tbl_MM_Sale.SDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        ElseIf RadioButton3.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptSale.rpt"
            Filter = "{tbl_MM_Sale.CustID}= " & Me.CustomerNameComboBox.SelectedValue & ""
        ElseIf RadioButton4.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptSale.rpt"
            Filter = " {tbl_MM_Sale.SDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_MM_Sale.CustID}= " & Me.CustomerNameComboBox.SelectedValue & ""
        ElseIf RadioButton5.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptCustLedger.rpt"
            Filter = "{View_Customer_Ledger.CustID}= " & Me.CustomerNameComboBox.SelectedValue & ""
        ElseIf RadioButton6.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptCustLedger.rpt"
            Filter = "{View_Customer_Ledger.SaleDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        ElseIf RadioButton8.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptCustLedger.rpt"
            Filter = "{View_Customer_Ledger.CustID} = " & Me.CustomerNameComboBox.SelectedValue & " and {View_Customer_Ledger.SaleDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        ElseIf RadioButton7.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptSaleBalance.rpt"
            Filter = "{View_MM_Sale_D.CustID}=" & Me.CustomerNameComboBox.SelectedValue & "And {View_MM_Sale_D.EntryDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        ShowContents(False, True, True)
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        ShowContents(False, False, True)
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        ShowContents(False, True, False)
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        ShowContents(False, True, True)
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        ShowContents(False, True, True)
    End Sub
End Class