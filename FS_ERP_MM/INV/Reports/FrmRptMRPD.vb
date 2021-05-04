Public Class FrmRptMRPD
    Private Sub FrmRptMatRequisition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.View_Rpt_Filter_PO1TableAdapter.Fill(Me.DSClient.View_Rpt_Filter_PO1)
        Me.View_Rpt_Filter_POTableAdapter.Fill(Me.DSClient.View_Rpt_Filter_PO)
        Me.Tbl_Prd_LinesTableAdapter.Fill(Me.DSClient.tbl_Prd_Lines)
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ShowContents(True, False, False)
    End Sub
    Sub ShowContents(ByVal Po As Boolean, ByVal dt As Boolean, ByVal Prd As Boolean)
        Me.POComboBox.Enabled = Po
        Me.POComboBox1.Enabled = Po
        Me.DTPicker1.Enabled = dt
        Me.DTPicker2.Enabled = dt
        'Me.PrdLineNameComboBox.Enabled = Prd
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ShowContents(False, True, False)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Path As String = "\\Server\MyReports$\ERPPPS\Material\MatRequisition.rpt"
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        Dim PrdLine As String = Nothing
        If PrdLineNameComboBox.SelectedValue = 5 Or PrdLineNameComboBox.SelectedValue = 16 Or PrdLineNameComboBox.SelectedValue = 17 Or PrdLineNameComboBox.SelectedValue = 18 Or PrdLineNameComboBox.SelectedValue = 19 Or PrdLineNameComboBox.SelectedValue = 20 Then
            PrdLine = "[15,5,16,17,18,19,20,100]"
        ElseIf PrdLineNameComboBox.SelectedValue = 15 Then
            PrdLine = "[15,100,5]"
        ElseIf PrdLineNameComboBox.SelectedValue = 8 Then
            PrdLine = "[8,100]"
        End If
        If RadioButton1.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Pro_PO_H.PO} in " & Me.POComboBox.SelectedValue & " to " & Me.POComboBox1.SelectedValue & "  And isnull({View_Rpt_Requisition.ODate})And {View_Rpt_Requisition.MatPrdline} in " & PrdLine & ""
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Pro_PO_H.PO} in " & Me.POComboBox.SelectedValue & " to " & Me.POComboBox1.SelectedValue & " And {View_Rpt_Requisition.MatPrdline} in " & PrdLine & ""
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Pro_PO_H.PO} in " & Me.POComboBox.SelectedValue & " to " & Me.POComboBox1.SelectedValue & " And Not isnull({View_Rpt_Requisition.ODate}) And {View_Rpt_Requisition.MatPrdline} in " & PrdLine & ""
            End If
        ElseIf RadioButton2.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Prd_Lines.PrdLine}=" & Me.PrdLineNameComboBox.SelectedValue & " And{View_Rpt_Requisition.RequiredDate}in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "#  And isnull({View_Rpt_Requisition.ODate}) And {View_Rpt_Requisition.MatPrdline} in " & PrdLine & ""
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Prd_Lines.PrdLine}=" & Me.PrdLineNameComboBox.SelectedValue & " And{View_Rpt_Requisition.RequiredDate}in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Requisition.MatPrdline} in " & PrdLine & ""
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Prd_Lines.PrdLine}=" & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Requisition.RequiredDate}in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And Not isnull({View_Rpt_Requisition.ODate})And {View_Rpt_Requisition.MatPrdline} in " & PrdLine & ""
            End If
        End If
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Dim Param As String = "UserName=" & frmLoginVer.LoginName & "&IPAddress=" & frmLoginVer.SysIP & "&SysName=" & ComputerName & ""
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub
End Class