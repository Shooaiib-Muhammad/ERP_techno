Public Class frmRptMIRN
    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        Dim Filter As String = Nothing
        Dim Path As String = Nothing
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked = True Then
            Filter = "{View_Purchase_Order_MRIN.RecDate}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\New\RptMRIN.rpt"
        ElseIf RadioButton13.Checked = True Then
            Filter = "{View_Purchase_Order_MRIN.RecDate}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Purchase_Order_MRIN.Narration} = '" & NarrationComboBox.Text & "'"
            Path = "" & frmLoginVer.Reportpath & "\New\RptMRINSpecialNote.rpt"
        ElseIf RadioButton2.Checked Then
            Filter = "{View_Purchase_Order_MRIN.RecDate}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Purchase_Order_MRIN.SupplierID} = " & Me.SupplierNameComboBox.SelectedValue & " "
            Path = "" & frmLoginVer.Reportpath & "\New\RptMRIN.rpt"
        ElseIf RadioButton12.Checked Then
            Filter = "{View_Purchase_Order_MRIN.RecDate}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Purchase_Order_MRIN.SupplierID} = " & Me.SupplierNameComboBox.SelectedValue & "  And {View_Purchase_Order_MRIN.L4Name} = '" & Me.L4NameComboBox.Text & "'"
            Path = "" & frmLoginVer.Reportpath & "\New\RptMRIN.rpt"
        ElseIf RadioButton3.Checked Then
            Filter = "{View_Lended_MIRN.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
            Path = "" & frmLoginVer.Reportpath & "\New\RptLendedMRIN.rpt"
        ElseIf RadioButton9.Checked Then
            Filter = "{View_Lended_MIRN.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
            Path = "" & frmLoginVer.Reportpath & "\New\RptReturnedMRIN.rpt"
        ElseIf RadioButton4.Checked Then
            Filter = "{View_Lended_MIRN.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Lended_MIRN.CustId} = " & Me.CompanyNameComboBox.SelectedValue & " "
            Path = "" & frmLoginVer.Reportpath & "\New\RptLendedMRIN.rpt"
        ElseIf RadioButton6.Checked Then
            Filter = "{View_Lended_MIRN.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
            Path = "" & frmLoginVer.Reportpath & "\New\RptBorrowedMRIN.rpt"
        ElseIf RadioButton5.Checked Then
            Filter = "{View_Lended_MIRN.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Lended_MIRN.CustId} = " & Me.SupplierNameComboBox.SelectedValue & " "
            Path = "" & frmLoginVer.Reportpath & "\New\RptBorrowedMRIN.rpt"
        ElseIf RadioButton7.Checked Then
            Filter = "{View_Rpt_Lended_Mat_Summary.Balance} > 0.00"
            Path = "\\server\myreports$\FSERPMM\Procurement\LendedMaterialSummary.rpt"
        ElseIf RadioButton8.Checked Then
            Filter = "{View_Lended_MIRN.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
            Path = "" & frmLoginVer.Reportpath & "\New\RptLendedMRINSlip.rpt"
        ElseIf RadioButton10.Checked = True Then
            Filter = "{View_Lended_MIRN.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#  And {View_Lended_MIRN.CompanyName} = '" & Me.CompanyNameComboBox.Text & "'"
            Path = "" & frmLoginVer.Reportpath & "\New\RptLendedMRIN.rpt"
        ElseIf RadioButton11.Checked = True Then
            Filter = "{View_Lended_MIRN.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#  And {View_Lended_MIRN.CompanyName} = '" & Me.SupplierNameComboBox.Text & "'"
            Path = "" & frmLoginVer.Reportpath & "\New\RptReturnedMRIN.rpt"
        ElseIf RadioButton14.Checked Then
            Filter = "{View_Rpt_Lended_Mat_Summary.Balance} > 0.00"
            Path = "\\server\myreports$\FSERPMM\Procurement\MRGP_Mat_Summary.rpt"
        ElseIf RadioButton15.Checked = True Then
            Filter = "{View_Purchase_Order_MRIN.RecDate}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And  Not isnull({View_Purchase_Order_MRIN.Narration})"
            Path = "" & frmLoginVer.Reportpath & "\New\RptMRINsp.rpt"
        End If
            objRptViewer.LoadReports(Path, Filter, "")
    End Sub
    Sub ShowContents(ByVal dt As Boolean, ByVal Sup As Boolean, ByVal Cust As Boolean)
        Me.DateTimePicker1.Enabled = dt
        Me.DateTimePicker2.Enabled = dt
        Me.SupplierNameComboBox.Enabled = Sup
        Me.CompanyNameComboBox.Enabled = Cust
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ShowContents(True, False, False)
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ShowContents(True, True, False)
    End Sub
    Private Sub frmrptMIRN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBilling.View_Purchase_Order_MRIN' table. You can move, or remove it, as needed.
        Me.View_Purchase_Order_MRINTableAdapter.Fill(Me.DSBilling.View_Purchase_Order_MRIN)
        'TODO: This line of code loads data into the 'DSBilling.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSBilling.tbl_Inv_L4)
        Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSRpt.tbl_MM_Customer)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSRpt.tbl_Inv_Supplier)
        If CheckBox1.Checked Then
            'RadioButton3.Checked = True
            'RadioButton1.Enabled = False
            'RadioButton2.Enabled = False
            'RadioButton3.Enabled = True
            'RadioButton4.Enabled = True
            'ShowContents(True, False, True)
        Else
            'RadioButton1.Checked = True
            'RadioButton1.Enabled = True
            'RadioButton2.Enabled = True
            'RadioButton3.Enabled = False
            'RadioButton4.Enabled = False
            'ShowContents(True, True, False)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged, RadioButton8.CheckedChanged, RadioButton9.CheckedChanged
        ShowContents(True, False, False)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        ShowContents(True, False, True)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            'RadioButton3.Checked = True
            'RadioButton1.Enabled = False
            'RadioButton2.Enabled = False
            'RadioButton3.Enabled = True
            'RadioButton4.Enabled = True
            'ShowContents(True, False, True)
        Else
            'RadioButton1.Checked = True
            'RadioButton1.Enabled = True
            'RadioButton2.Enabled = True
            'RadioButton3.Enabled = False
            'RadioButton4.Enabled = False
            'ShowContents(True, True, False)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        ShowContents(True, True, False)
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        ShowContents(True, False, False)
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        ShowContents(False, False, False)
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            SupplierNameComboBox.Enabled = True
            CompanyNameComboBox.Enabled = False
        Else
            SupplierNameComboBox.Enabled = False
            CompanyNameComboBox.Enabled = True
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            SupplierNameComboBox.Enabled = True
        Else
            SupplierNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            L4NameComboBox.Enabled = True
            Me.SupplierNameComboBox.Enabled = True
        Else
            L4NameComboBox.Enabled = False
            Me.SupplierNameComboBox.Enabled = False
        End If

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged

        If RadioButton13.Checked = True Then
            NarrationComboBox.Enabled = True
        Else
            NarrationComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        ShowContents(True, False, False)
    End Sub
End Class