Public Class frmMiscReports4Purchase
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked And RadioButton3.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptSupplierItems.rpt"
            Filter = "{View_Rpt_Proc_SupplierItems.SupplierID} = " & CompanyNameComboBox.SelectedValue & ""
        ElseIf RadioButton1.Checked And RadioButton4.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptSupplierItems.rpt"
            Filter = "{View_Rpt_Proc_SupplierItems.Code} = '" & Me.L4NameComboBox.SelectedValue & "'"
        ElseIf RadioButton2.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptAPVSDemandsDt.rpt"
            If RadioButton3.Checked Then
                ' Filter = "{View_Rpt_Pur_GenDemands.AfterPurchaseVStatus} = True And {View_Rpt_Pur_GenDemands.AfterPurchaseVDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                Filter = "{View_Rpt_Pur_GenDemands.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton4.Checked Then
                Filter = "And {View_Rpt_Pur_GenDemands.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub

    Private Sub frmMiscReports4Purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSPO.tbl_Inv_Supplier)
        Me.Tbl_Pur_Demand_Head1TableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Head1)
        Me.Tbl_Pur_Demand_HeadTableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Head)
        If RadioButton1.Checked Then
            RadioButton3.Text = "Filter By Supplier Name"
            RadioButton3.Enabled = True
            RadioButton4.Text = "Filter By Item Name"
            RadioButton4.Enabled = True
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton3.Checked = False
            RadioButton3.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton3.Text = "Filter By Supplier Name"
            RadioButton3.Enabled = True
            RadioButton4.Text = "Filter By Item Name"
            RadioButton4.Enabled = True
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton3.Checked = False
            RadioButton3.Checked = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton3.Text = "Filter By Verification Date"
            RadioButton3.Enabled = True
            RadioButton4.Text = "Filter By Verificiation Date and Item"
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton3.Checked = False
            RadioButton3.Checked = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            If RadioButton3.Text = "Filter By Verification Date" Then
                Panel4.Enabled = True
                Panel5.Enabled = False
            Else
                Panel4.Enabled = False
                Panel5.Enabled = True
                L4NameComboBox.Enabled = False
                CustNameComboBox.Enabled = False
                GMNoComboBox.Enabled = False
                GMNoComboBox1.Enabled = False
                CompanyNameComboBox.Enabled = True
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            If RadioButton4.Text = "Filter By Item Name" Then
                Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPO.tbl_Inv_L4)
                Panel4.Enabled = False
                Panel5.Enabled = True
                L4NameComboBox.Enabled = True
                CustNameComboBox.Enabled = False
                GMNoComboBox.Enabled = False
                GMNoComboBox1.Enabled = False
                CompanyNameComboBox.Enabled = False
            Else
                Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
                Panel4.Enabled = True
                Panel5.Enabled = True
                L4NameComboBox.Enabled = True
                CustNameComboBox.Enabled = False
                GMNoComboBox.Enabled = False
                GMNoComboBox1.Enabled = False
                CompanyNameComboBox.Enabled = False
            End If
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Panel4.Enabled = True
            Panel5.Enabled = True
            L4NameComboBox.Enabled = False
            CustNameComboBox.Enabled = True
            GMNoComboBox.Enabled = False
            GMNoComboBox1.Enabled = False
            CompanyNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Panel4.Enabled = True
            Panel5.Enabled = True
            L4NameComboBox.Enabled = False
            CustNameComboBox.Enabled = False
            GMNoComboBox.Enabled = True
            GMNoComboBox1.Enabled = True
            CompanyNameComboBox.Enabled = False
        End If
    End Sub

End Class