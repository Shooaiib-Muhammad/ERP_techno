Public Class frmDispMat
    Private Sub frmDispMat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSClient.tbl_Inv_L4)
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ShowContents(True, False)
    End Sub
    Sub ShowContents(ByVal dt As Boolean, ByVal l4 As Boolean)
        Me.DateTimePicker1.Enabled = dt
        Me.DateTimePicker2.Enabled = dt
        Me.L4NameComboBox.Enabled = l4
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ShowContents(True, False)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        ShowContents(False, True)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        ShowContents(False, True)
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        ShowContents(True, True)
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        ShowContents(False, False)
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        ShowContents(False, False)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked = True Then
            Path = "\\server\MyReports$\FSERPMER\MER\MatReqDM.rpt"
            Filter = "{View_PC_Plan_ReqMat_DM.SecondConfDate}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        ElseIf RadioButton2.Checked = True Then
            Path = "\\server\MyReports$\FSERPMER\MER\MatReqDM.rpt"
            Filter = "{View_PC_Plan_ReqMat_DM.SecondConfDate}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_PC_Plan_ReqMat_DM.Balance} <> 0.00 "
        ElseIf RadioButton3.Checked = True Then
            Path = "\\server\MyReports$\FSERPMER\MER\MatReqDM.rpt"
            Filter = "{View_PC_Plan_ReqMat_DM.Code}= '" & Me.L4NameComboBox.SelectedValue & "'"
        ElseIf RadioButton4.Checked = True Then
            Path = "\\server\MyReports$\FSERPMER\MER\MatReqDM.rpt"
            Filter = "{View_PC_Plan_ReqMat_DM.Code}= '" & Me.L4NameComboBox.SelectedValue & "'And {View_PC_Plan_ReqMat_DM.Balance} <> 0.00"
        ElseIf RadioButton5.Checked = True Then
            Path = "\\server\MyReports$\FSERPMER\MER\MatReqDM.rpt"
            Filter = "{View_PC_Plan_ReqMat_DM.SecondConfDate}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_PC_Plan_ReqMat_DM.Code}= '" & Me.L4NameComboBox.SelectedValue & "'And {View_PC_Plan_ReqMat_DM.Balance} <> 0.00"
        ElseIf RadioButton6.Checked = True Then
            Path = "\\server\MyReports$\FSERPMER\MER\MatReqDM.rpt"
            Filter = "{View_PC_Plan_ReqMat_DM.Balance} <> 0.00"
        ElseIf RadioButton7.Checked = True Then
            Path = "\\server\MyReports$\FSERPMER\MER\MatReqSumDM.rpt"
            Filter = "{View_PC_Plan_ReqMat_DM.Balance} <> 0.00"
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub
End Class