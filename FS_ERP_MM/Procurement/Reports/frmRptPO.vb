Public Class frmRptPO

    Private Sub frmRptPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSSupp.tbl_Inv_L4)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSSupp.tbl_Inv_Supplier)
        Me.Tbl_Pur_PO1TableAdapter.Fill(Me.DSPO.tbl_Pur_PO1)
        Me.Tbl_Pur_POTableAdapter.Fill(Me.DSPO.tbl_Pur_PO)
        Me.Tbl_Pur_POBindingSource.Sort = " POId DESC"
        Me.Tbl_Pur_PO1BindingSource.Sort = "POID DESC"
        If Me.RadioButton1.Checked = True Then
            Me.POIDComboBox1.Enabled = True
            Me.POIDComboBox2.Enabled = True
            Me.CompanyNameComboBox.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
            Me.L4NameComboBox.Enabled = False
            Me.RadioButton5.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            RadioButton5.Enabled = True
            Me.POIDComboBox1.Enabled = True
            Me.POIDComboBox2.Enabled = True
            Me.CompanyNameComboBox.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
            Me.L4NameComboBox.Enabled = False
            Me.RadioButton5.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked = True Then
            RadioButton5.Enabled = True
            Me.POIDComboBox1.Enabled = False
            Me.POIDComboBox2.Enabled = False
            Me.CompanyNameComboBox.Enabled = False
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = True
            Me.L4NameComboBox.Enabled = False
            Me.RadioButton5.Enabled = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If Me.RadioButton3.Checked = True Then
            RadioButton5.Enabled = True
            Me.POIDComboBox1.Enabled = False
            Me.POIDComboBox2.Enabled = False
            Me.CompanyNameComboBox.Enabled = True
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
            Me.L4NameComboBox.Enabled = False
            Me.RadioButton5.Enabled = True
        End If
    End Sub
    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim Param As String = Nothing
        Dim objRptViewer As New Class_Utility
        If RadioButton4.Checked And RadioButton7.Checked = False And RadioButton8.Checked = False Then
            If frmLoginVer.DeptID = 24 Then
                Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPO(Disc).rpt"
            Else
                Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPO.rpt"
            End If
        ElseIf RadioButton5.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPODouble.rpt"
        ElseIf RadioButton4.Checked = True And RadioButton7.Checked Or RadioButton8.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptPODetail.rpt"
        End If
        If Me.RadioButton1.Checked = True Then
            Filter = "{tbl_Pur_PO_D.POID} in " & Me.POIDComboBox1.SelectedValue & " to " & Me.POIDComboBox2.SelectedValue & ""
        ElseIf Me.RadioButton2.Checked = True Then
            Filter = "{tbl_Pur_PO_D.PODate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
        ElseIf Me.RadioButton3.Checked = True Then
            Filter = "{tbl_Pur_PO_D.SupplierID} = " & Me.CompanyNameComboBox.SelectedValue
        ElseIf Me.RadioButton6.Checked = True Then
            Filter = "{tbl_Pur_PO_D.Code} = '" & Me.L4NameComboBox.SelectedValue & "'"
        ElseIf Me.RadioButton7.Checked = True Then
            Filter = "{View_Rpt_MM_PO.POID} in " & Me.POIDComboBox1.SelectedValue & " to " & Me.POIDComboBox2.SelectedValue & ""
        ElseIf Me.RadioButton8.Checked = True Then
            Filter = "{View_Rpt_MM_PO.PODate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        ElseIf RadioButton9.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\PurchaseSummary.rpt"
            Param = "FromDate=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DateTimePicker2.Value, "dd/MM/yyyy") & ""
            Filter = "{View_Pur_Sup_PO.PODate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Pur_Sup_PO.SupplierID}=" & Me.CompanyNameComboBox.SelectedValue & ""
        End If
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            RadioButton5.Enabled = True
            Me.POIDComboBox1.Enabled = False
            Me.POIDComboBox2.Enabled = False
            Me.CompanyNameComboBox.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
            Me.L4NameComboBox.Enabled = True
            Me.RadioButton5.Enabled = True
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If Me.RadioButton7.Checked = True Then
            RadioButton5.Enabled = True
            Me.POIDComboBox1.Enabled = True
            Me.POIDComboBox2.Enabled = True
            Me.CompanyNameComboBox.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
            Me.L4NameComboBox.Enabled = False
            Me.RadioButton5.Enabled = False
            Me.RadioButton4.Checked = True
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If Me.RadioButton8.Checked = True Then
            RadioButton5.Enabled = True
            Me.POIDComboBox1.Enabled = False
            Me.POIDComboBox2.Enabled = False
            Me.CompanyNameComboBox.Enabled = False
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = True
            Me.L4NameComboBox.Enabled = False
            Me.RadioButton5.Enabled = False
            Me.RadioButton4.Checked = True
            RadioButton5.Enabled = True
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        RadioButton5.Enabled = False
        Me.POIDComboBox1.Enabled = False
        Me.POIDComboBox2.Enabled = False
        DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True
        L4NameComboBox.Enabled = False
        CompanyNameComboBox.Enabled = True
    End Sub
End Class