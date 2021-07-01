Public Class frmRptDeptWiseOut
    Private Sub frmRptDeptWiseOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSLocalCust.tbl_Inv_Supplier' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSLocalCust.tbl_Inv_Supplier)
        'TODO: This line of code loads data into the 'DSRptL4Code.tbl_Inv_L42' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L42TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L42)
        Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSLocalCust.tbl_MM_Customer)
        Me.Tbl_CompaniesTableAdapter.Fill(Me.DSLocalCust.tbl_Companies)
        Me.Tbl_Inv_ExternalCustTableAdapter.Fill(Me.DSLocalCust.tbl_Inv_ExternalCust)
        Me.Tbl_Inv_L41TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L41)
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L3)
        Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L2)
        Me.Tbl_Inv_L1TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L1)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSLocalCust.tbl_Inv_LocalCust)
    End Sub
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Dim objRptViewer As New Class_Utility
        If Me.RadioButton1.Checked = True Then
            Filter = "{tbl_Inv_Tran_Out.LocalCustID} = " & Me.CustNameComboBox.SelectedValue & " AND {tbl_Inv_Tran_Out.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutDeptwiseDate1.rpt"
        ElseIf Me.RadioButton2.Checked = True Then
            Filter = "{tbl_Inv_Tran_Out.LocalCustID} = " & Me.CustNameComboBox.SelectedValue & " AND {tbl_Inv_Tran_Out.Code} in '" & Me.CodeComboBox.SelectedValue & "'to '" & Me.CodeComboBox1.SelectedValue & "'"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutDeptwiseDate1.rpt"
        ElseIf Me.RadioButton3.Checked = True Then
            Filter = "{tbl_Inv_Tran_Out.LocalCustID} = " & Me.CustNameComboBox.SelectedValue & " AND {tbl_Inv_Tran_Out.Code} in '" & Me.CodeComboBox.SelectedValue & "'to '" & Me.CodeComboBox1.SelectedValue & "' AND {tbl_Inv_Tran_Out.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutDeptwiseDate1.rpt"
        ElseIf Me.RadioButton6.Checked = True Then
            Filter = "{tbl_Inv_ExternalCust.ExtCustID} = " & Me.ComboBox1.SelectedValue & " AND {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutCustwise.rpt"
        ElseIf Me.RadioButton5.Checked = True Then
            Filter = "{tbl_Inv_ExternalCust.ExtCustID} = " & Me.ComboBox1.SelectedValue & " AND {tbl_Inv_Code.Code} in '" & Me.CodeComboBox.SelectedValue & "'to '" & Me.CodeComboBox1.SelectedValue & "'"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutCustwise.rpt"
        ElseIf Me.RadioButton4.Checked = True Then
            Filter = "{tbl_Inv_ExternalCust.ExtCustID} = " & Me.ComboBox1.SelectedValue & " AND {tbl_Inv_Code.Code} in '" & Me.CodeComboBox.SelectedValue & "'to '" & Me.CodeComboBox1.SelectedValue & "' AND {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutCustwise.rpt"
        ElseIf Me.RadioButton9.Checked = True Then
            Filter = "{tbl_Companies.CompanyID} = " & Me.ComboBox2.SelectedValue & " AND {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutCompwise.rpt"
        ElseIf Me.RadioButton8.Checked = True Then
            Filter = "{tbl_Companies.CompanyID} = " & Me.ComboBox2.SelectedValue & " AND {tbl_Inv_Code.Code} in '" & Me.CodeComboBox.SelectedValue & "'to '" & Me.CodeComboBox1.SelectedValue & "'"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutCompwise.rpt"
        ElseIf Me.RadioButton7.Checked = True Then
            Filter = "{tbl_Companies.CompanyID} = " & Me.ComboBox2.SelectedValue & " AND {tbl_Inv_Code.Code} in '" & Me.CodeComboBox.SelectedValue & "'to '" & Me.CodeComboBox1.SelectedValue & "' AND {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutCompwise.rpt"
        ElseIf Me.RadioButton25.Checked = True Then '' By date range
            Filter = "{tbl_Inv_Tran_Out.TranType} = 'MSGP' And {tbl_Inv_Tran_Date.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutSaleCompwise.rpt"
        ElseIf Me.RadioButton12.Checked = True Then ' By Comany and Date rang
            Filter = "{tbl_MM_Customer.CustID} = " & Me.CompanyNameComboBox.SelectedValue & " And {tbl_Inv_Tran_Date.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutSaleCompwise.rpt"
        ElseIf Me.RadioButton11.Checked = True Then
            Filter = "{tbl_Inv_Tran_Out.TranType} = '""'  And {tbl_MM_Customer.CustID} = " & Me.CompanyNameComboBox.SelectedValue & " And {tbl_Inv_Code.Code} In '" & Me.CodeComboBox.SelectedValue & "'to '" & Me.CodeComboBox1.SelectedValue & "'"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutSaleCompwise.rpt"
        ElseIf RadioButton26.Checked = True Then

            Filter = "{tbl_Inv_Tran_Out.TranType} = 'LSGP' And {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutSaleCompwiseLSGP.rpt"

        ElseIf Me.RadioButton10.Checked = True Then
            Filter = "{tbl_MM_Customer.CustID} = " & Me.CompanyNameComboBox.SelectedValue & " AND {tbl_Inv_Code.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "' AND {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutSaleCompwise.rpt"
        ElseIf Me.RadioButton24.Checked = True Then
            Filter = "{tbl_Inv_Code.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "' AND {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutSaleCompwise.rpt"
            '
        ElseIf Me.RadioButton21.Checked = True Then
            Filter = "{tbl_Inv_Supplier.SupplierID} = " & Me.CompanyNameComboBox1.SelectedValue & " AND {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutSuplierwise.rpt"
        ElseIf Me.RadioButton20.Checked = True Then
            Filter = "{tbl_Inv_Supplier.SupplierID} = " & Me.CompanyNameComboBox1.SelectedValue & " AND {tbl_Inv_Code.Code} in '" & Me.CodeComboBox.SelectedValue & "'to '" & Me.CodeComboBox1.SelectedValue & "'"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutSuplierwise.rpt"
        ElseIf Me.RadioButton19.Checked = True Then
            Filter = "{tbl_Inv_Supplier.SupplierID} = " & Me.CompanyNameComboBox1.SelectedValue & " AND {tbl_Inv_Code.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "' AND {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptInvOutSuplierwise.rpt"

        ElseIf Me.RadioButton22.Checked = True Then
            Filter = "{View_Borrowed_MatBalance.SupplierID} = " & Me.CompanyNameComboBox1.SelectedValue & ""
            Path = "" & frmLoginVer.Reportpath & "\RptBrowedMatBal.rpt"
        ElseIf Me.RadioButton23.Checked = True Then
            Filter = "{View_Borrowed_MatBalance.ExtCustID} = " & Me.CompanyNameComboBox.SelectedValue & ""
            Path = "" & frmLoginVer.Reportpath & "\RptLendedMatBal.rpt"

        End If
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = True
        Me.GroupBox4.Visible = False
        Me.CustNameComboBox.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.CompanyNameComboBox1.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.CompanyNameComboBox.Enabled = False
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = False
        Me.GroupBox4.Visible = True
        Me.CompanyNameComboBox1.Enabled = False
        Me.CustNameComboBox.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.CompanyNameComboBox.Enabled = False
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = True
        Me.GroupBox4.Visible = True
        Me.CustNameComboBox.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.CompanyNameComboBox1.Enabled = False
        Me.CompanyNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = True
        Me.GroupBox4.Visible = False
        Me.CompanyNameComboBox1.Enabled = False
        Me.CustNameComboBox.Enabled = False
        Me.ComboBox1.Enabled = True
        Me.ComboBox2.Enabled = False
        Me.CompanyNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = False
        Me.GroupBox4.Visible = True
        Me.CompanyNameComboBox1.Enabled = False
        Me.CustNameComboBox.Enabled = False
        Me.ComboBox1.Enabled = True
        Me.ComboBox2.Enabled = False
        Me.CompanyNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = True
        Me.GroupBox4.Visible = True
        Me.CustNameComboBox.Enabled = False
        Me.CompanyNameComboBox1.Enabled = False
        Me.ComboBox1.Enabled = True
        Me.ComboBox2.Enabled = False
        Me.CompanyNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = True
        Me.GroupBox4.Visible = False
        Me.CompanyNameComboBox1.Enabled = False
        Me.CustNameComboBox.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = True
        Me.CompanyNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = False
        Me.GroupBox4.Visible = True
        Me.CompanyNameComboBox1.Enabled = False
        Me.CustNameComboBox.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = True
        Me.CompanyNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = True
        Me.GroupBox4.Visible = True
        Me.CompanyNameComboBox1.Enabled = False
        Me.CustNameComboBox.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = True
        Me.CompanyNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged, RadioButton21.CheckedChanged, RadioButton22.CheckedChanged
        Me.CompanyNameComboBox1.Enabled = False

        Me.GroupBox2.Visible = True

        Me.GroupBox4.Visible = False
        Me.CompanyNameComboBox.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.CustNameComboBox.Enabled = False
        If RadioButton21.Checked Or RadioButton22.Checked Then
            Me.CompanyNameComboBox1.Enabled = True
            Me.CompanyNameComboBox.Enabled = False

        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged, RadioButton20.CheckedChanged
        Me.CompanyNameComboBox1.Enabled = False
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = False
        Me.GroupBox4.Visible = True
        Me.CompanyNameComboBox.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.CustNameComboBox.Enabled = False
        If RadioButton21.Checked Then
            Me.CompanyNameComboBox1.Enabled = True
            Me.CompanyNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged, RadioButton19.CheckedChanged
        Me.CompanyNameComboBox1.Enabled = False
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = True
        Me.GroupBox4.Visible = True
        Me.CompanyNameComboBox.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.CustNameComboBox.Enabled = False
        If RadioButton10.Checked Then
            Me.CodeComboBox1.Visible = True
            Me.Label7.Visible = True
        Else
            Me.CodeComboBox1.Visible = False
            Me.Label7.Visible = False
        End If
        If RadioButton21.Checked Then
            Me.CompanyNameComboBox1.Enabled = True
            Me.CompanyNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        Me.CompanyNameComboBox1.Enabled = False
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = True
        Me.GroupBox4.Visible = True
        Me.CompanyNameComboBox.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.CustNameComboBox.Enabled = False
        If RadioButton10.Checked Then
            Me.CodeComboBox1.Visible = True
            Me.Label7.Visible = True
        Else
            Me.CodeComboBox1.Visible = True
            Me.Label7.Visible = True
        End If

        Me.CompanyNameComboBox1.Enabled = False
            Me.CompanyNameComboBox.Enabled = False

    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        Me.CompanyNameComboBox1.Enabled = False
    End Sub



    'Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
    '    If RadioButton25.Checked = True Then
    '        End
    '    End If
    'End Sub
End Class