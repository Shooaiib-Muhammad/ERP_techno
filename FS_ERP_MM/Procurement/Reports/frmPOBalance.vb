Public Class frmPOBalance
    Sub RdEnable(ByVal PO As Boolean, ByVal comp1 As Boolean, ByVal Comp As Boolean, ByVal dt As Boolean, ByVal L4 As Boolean, ByVal CB As Boolean)
        Me.POIDComboBox1.Enabled = PO
        Me.POIDComboBox2.Enabled = PO
        Me.CompanyNameComboBox.Enabled = Comp
        Me.ComboBox1.Enabled = comp1
        Me.SupplierTypeComboBox.Enabled = Comp
        Me.DateTimePicker1.Enabled = dt
        Me.DateTimePicker2.Enabled = dt
        Me.L4NameComboBox.Enabled = L4
        Me.CheckBox1.Enabled = CB
    End Sub
    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPORec.rpt"
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{@BCheckStatealance} > 0.00"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = ""
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{@Balance} = 0.00"
            End If
        ElseIf RadioButton2.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPORec.rpt"
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Pur_PO.POID} in " & Me.POIDComboBox2.SelectedValue & " to " & Me.POIDComboBox1.SelectedValue & "And {@Balance} > 0.00"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Pur_PO.POID} in " & Me.POIDComboBox2.SelectedValue & " to " & Me.POIDComboBox1.SelectedValue & ""
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Pur_PO.POID} in " & Me.POIDComboBox2.SelectedValue & " to " & Me.POIDComboBox1.SelectedValue & "And {@Balance} = 0.00"
            End If
        ElseIf RadioButton3.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPORec.rpt"
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Pur_PO.SupplierID} = " & Me.CompanyNameComboBox.SelectedValue & "And {@Balance} > 0.00"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Pur_PO.SupplierID} = " & Me.CompanyNameComboBox.SelectedValue & ""
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Pur_PO.SupplierID} = " & Me.CompanyNameComboBox.SelectedValue & "And {@Balance} = 0.00"
            End If
            'here
        ElseIf RadioButton9.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPORec.rpt"
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Pur_PO.SupplierID} = " & Me.CompanyNameComboBox.SelectedValue & "And {tbl_Pur_Supplier_Code.Code} ='" & Me.L4NameComboBox.SelectedValue & "' And {tbl_Pur_PO.ReqDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {@Balance} > 0.00"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Pur_PO.SupplierID} = " & Me.CompanyNameComboBox.SelectedValue & "And {tbl_Pur_Supplier_Code.Code} ='" & Me.L4NameComboBox.SelectedValue & "' And {tbl_Pur_PO.ReqDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Pur_PO.SupplierID} = " & Me.CompanyNameComboBox.SelectedValue & "And {tbl_Pur_Supplier_Code.Code} ='" & Me.L4NameComboBox.SelectedValue & "' And {tbl_Pur_PO.ReqDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {@Balance} = 0.00"
            End If
            'end here
        ElseIf RadioButton4.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPORec.rpt"
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Pur_PO.ReqDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#And {@Balance} > 0.00"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Pur_PO.ReqDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Pur_PO.ReqDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#And {@Balance} = 0.00"
            End If
        ElseIf RadioButton5.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPORec.rpt"
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Pur_PO.PODate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#And {@Balance} > 0.00"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Pur_PO.PODate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Pur_PO.PODate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#And {@Balance} = 0.00"
            End If
        ElseIf RadioButton6.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPORec.rpt"
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Pur_Supplier_Code.Code} ='" & Me.L4NameComboBox.SelectedValue & "'And {@Balance} > 0.00"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Pur_Supplier_Code.Code} ='" & Me.L4NameComboBox.SelectedValue & "'"
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Pur_Supplier_Code.Code} ='" & Me.L4NameComboBox.SelectedValue & "'And {@Balance} = 0.00"
            End If
        ElseIf RadioButton7.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPODetail.rpt"
            Filter = "{View_Rpt_MM_PO.PODate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_MM_PO.SupplierID}=" & Me.CompanyNameComboBox.SelectedValue & ""
        ElseIf RadioButton8.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptSupPODetail.rpt"
            Filter = "{View_Rpt_MM_PO.SupplierID} in " & Me.CompanyNameComboBox.SelectedValue & " to " & Me.ComboBox1.SelectedValue & ""
        ElseIf RadioButton10.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\RptSupList.rpt"
            Filter = "not isnull({tbl_Inv_Supplier.CompanyName})"
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub
    Private Sub frmPOBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_Supplier1TableAdapter.Fill(Me.DSSupp.tbl_Inv_Supplier1)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSSupp.tbl_Inv_Supplier)
        Me.Tbl_inv_SupplierTypeTableAdapter.Fill(Me.DSSupp.tbl_inv_SupplierType)
        Me.Tbl_Pur_PO1TableAdapter.Fill(Me.DSPO.tbl_Pur_PO1)
        Me.Tbl_Pur_POTableAdapter.Fill(Me.DSPO.tbl_Pur_PO)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSSupp.tbl_Inv_L4)
        Me.Tbl_Pur_POBindingSource.Sort = "POID DESC"
        Me.Tbl_Pur_PO1BindingSource.Sort = "POID DESC"
        If RadioButton1.Checked Then
            RdEnable(False, False, False, False, False, True)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton10.CheckedChanged
        RdEnable(False, False, False, False, False, True)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        RdEnable(True, False, False, False, False, True)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        RdEnable(False, False, True, False, False, True)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        RdEnable(False, False, False, True, False, True)
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        RdEnable(False, False, False, True, False, True)
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        RdEnable(False, False, False, False, True, True)
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        RdEnable(False, False, True, True, False, False)
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        RdEnable(False, True, True, False, False, False)
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        RdEnable(False, False, True, True, True, True)
    End Sub
End Class