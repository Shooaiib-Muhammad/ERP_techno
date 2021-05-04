Public Class frmRptMaterialReceiving
    Private Sub frmRptMatAndSup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRpt.tbl_MM_Customer' table. You can move, or remove it, as needed.
        Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSRpt.tbl_MM_Customer)
        Me.Tbl_Inv_Supplier1TableAdapter.Fill(Me.DSRpt.tbl_Inv_Supplier1)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSRpt.tbl_Inv_Supplier)
        Me.Tbl_Inv_L41TableAdapter.Fill(Me.DSRpt.tbl_Inv_L41)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRpt.tbl_Inv_L4)
        If RadioButton1.Checked Then
            ShowContents(True, False, False)
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ShowContents(True, False, False)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ShowContents(True, False, True)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        ShowContents(False, True, False)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged, RadioButton9.CheckedChanged, RadioButton10.CheckedChanged
        If RadioButton4.Checked Then
            ShowContents(False, True, True)
        Else
            ShowContents(True, True, True)
        End If

    End Sub
    Sub ShowContents(ByVal Comp As Boolean, ByVal L4 As Boolean, ByVal dt As Boolean)
        Me.CompanyNameComboBox.Enabled = Comp
        Me.CompanyNameComboBox1.Enabled = Comp
        Me.L4NameComboBox.Enabled = L4
        Me.L4NameComboBox1.Enabled = L4
        Me.DTPicker1.Enabled = dt
        Me.DTPicker2.Enabled = dt
        ComboBox1.Enabled = True
        Me.CompanyNameComboBox2.Enabled = False
    End Sub
    Private Sub ReportFilter()
        If Me.ComboBox1.Text = "MRI" Then
        ElseIf Me.ComboBox1.Text = "MRI" Then
        ElseIf Me.ComboBox1.Text = "MRI" Then
        ElseIf Me.ComboBox1.Text = "MRI" Then
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\New\RptInvInSupwise.rpt"
            Filter = "{tbl_Inv_Tran_In.SupplierID} in " & Me.CompanyNameComboBox.SelectedValue & " to " & Me.CompanyNameComboBox1.SelectedValue & ""
        ElseIf RadioButton2.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\New\RptInvInSupwise.rpt"
            Filter = "{tbl_Inv_Tran_In.SupplierID} in " & Me.CompanyNameComboBox.SelectedValue & " to " & Me.CompanyNameComboBox1.SelectedValue & " And {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton10.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\New\RptInvInSupwise.rpt"
            Filter = "{tbl_Inv_Tran_In.Code} in '" & Me.L4NameComboBox.SelectedValue & "' to '" & Me.L4NameComboBox1.SelectedValue & "'And {tbl_Inv_Tran_In.SupplierID} in " & Me.CompanyNameComboBox.SelectedValue & " to " & Me.CompanyNameComboBox1.SelectedValue & " And {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton3.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\New\RptInvInMatwise.rpt"
            Filter = "{tbl_Inv_Tran_In.Code} in '" & Me.L4NameComboBox.SelectedValue & "' to '" & Me.L4NameComboBox1.SelectedValue & "'"
        ElseIf RadioButton9.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\New\RptInvInMatwise.rpt"
            Filter = "{tbl_Inv_Tran_In.Code} in '" & Me.L4NameComboBox.SelectedValue & "' to '" & Me.L4NameComboBox1.SelectedValue & "'And {tbl_Inv_Tran_In.SupplierID} in " & Me.CompanyNameComboBox.SelectedValue & " to " & Me.CompanyNameComboBox1.SelectedValue & " And {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton4.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\New\RptInvInMatwise.rpt"
            Filter = "{tbl_Inv_Tran_In.Code} in '" & Me.L4NameComboBox.SelectedValue & "' to '" & Me.L4NameComboBox1.SelectedValue & "' And {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton5.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\RptBladderRec.rpt"
            Filter = "{View_Rpt_Bladder_Rec.SupplierID}in " & Me.CompanyNameComboBox.SelectedValue & " to " & Me.CompanyNameComboBox1.SelectedValue & " And {View_Rpt_Bladder_Rec.DateName}in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton6.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\RptRubberIssuance.rpt"
            Filter = "{View_Rpt_Rubber_Vendor_Info.SupplierId}in " & Me.CompanyNameComboBox.SelectedValue & " to " & Me.CompanyNameComboBox1.SelectedValue & " And {View_Rpt_Rubber_Vendor_Info.DateValue} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton7.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\RptBladderRec.rpt"
            Filter = "{View_Rpt_Bladder_Rec.Code} in '" & Me.L4NameComboBox.SelectedValue & "' to '" & Me.L4NameComboBox1.SelectedValue & "' And {View_Rpt_Bladder_Rec.DateName}in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton8.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\RptRubberIssuance.rpt"
            Filter = "{View_Rpt_Rubber_Vendor_Info.Code} in '" & Me.L4NameComboBox.SelectedValue & "' to '" & Me.L4NameComboBox1.SelectedValue & "' And {View_Rpt_Rubber_Vendor_Info.DateValue} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton11.Checked Then
            Path = "\\Server\myreports$\FSERPMM\Inventory\New\RptInvInLR.rpt"
            Filter = "{tbl_Inv_Tran_In.Code} in '" & Me.L4NameComboBox.SelectedValue & "' to '" & Me.L4NameComboBox1.SelectedValue & "'And {tbl_Inv_Tran_In.custid} = " & Me.CompanyNameComboBox2.SelectedValue & " And {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Inv_Tran_In.TranType} = 'MLRN'"
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged, RadioButton5.CheckedChanged
        ShowContents(True, False, True)
        ComboBox1.Enabled = False
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged, RadioButton7.CheckedChanged
        ShowContents(False, True, True)
        ComboBox1.Enabled = False
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        ShowContents(True, True, True)
        CompanyNameComboBox1.Enabled = False
        CompanyNameComboBox.Enabled = False
        Me.CompanyNameComboBox2.Enabled = True
    End Sub
End Class