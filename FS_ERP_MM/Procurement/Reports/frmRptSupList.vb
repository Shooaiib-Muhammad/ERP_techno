Public Class frmRptSupList

    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptSupList.rpt"
            Filter = "not isnull({tbl_Inv_Supplier.CompanyName})"
        ElseIf RadioButton2.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\SupplierItems.rpt"
            Filter = "{tbl_Inv_Supplier.SupplierID} = " & Me.CompanyNameComboBox.SelectedValue & ""
        ElseIf RadioButton3.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptInvPriceAnalysis.rpt"
            Filter = "{View_Mat_Price_Analysis.Code} = '" & Me.L4NameComboBox.SelectedValue & "'"
        ElseIf RadioButton4.Checked = True Then
            Path = "" & frmLoginVer.Reportpath & "\New\RptInvInSupwisevALUE.rpt"
            Filter = "{tbl_Inv_Tran_In.SupplierID} in " & Me.CompanyNameComboBox.SelectedValue & " to " & Me.ComboBox1.SelectedValue & ""
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub

    Private Sub frmRptSupList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSSupItems.tbl_Inv_Supplier1' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Supplier1TableAdapter.Fill(Me.DSSupItems.tbl_Inv_Supplier1)
        'TODO: This line of code loads data into the 'DSSupItems.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSSupItems.tbl_Inv_L4)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSSupItems.tbl_Inv_Supplier)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.CompanyNameComboBox.Enabled = False
        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.CompanyNameComboBox.Enabled = True
        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.CompanyNameComboBox.Enabled = False
        Me.L4NameComboBox.Enabled = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ComboBox1.Enabled = True
            CompanyNameComboBox.Enabled = True
        Else
            ComboBox1.Enabled = False
            CompanyNameComboBox.Enabled = False
        End If
    End Sub
End Class