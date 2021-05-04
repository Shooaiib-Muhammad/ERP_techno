Public Class frmRptDailyTran

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Path As String = Nothing
        Dim Filter As String = Nothing
        Dim Obj As New Class_Utility
        If RadioButton1.Checked Then
            Path = "\\server\myreports$\MisExp\BE\RtpBERec.rpt"
            Filter = "{tbl_Inv_Tran_Date.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        ElseIf RadioButton2.Checked Then
            Path = "\\server\myreports$\MisExp\BE\RtpBEIssuance.rpt"
            Filter = "{tbl_Inv_Tran_Date.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        ElseIf RadioButton3.Checked Then
            Path = "\\server\myreports$\MisExp\BE\RptBEBalance.rpt"
            Filter = "{View_BE_Mat_Balance.BEId} in " & Me.BENumberComboBox.SelectedValue & " to " & Me.BENumberComboBox1.SelectedValue & ""
        ElseIf RadioButton4.Checked Then
            Path = "\\server\myreports$\MisExp\BE\RptBEMatBalance.rpt"
            Filter = "{View_BE_Mat_Balance.BEId} in " & Me.BENumberComboBox.SelectedValue & " to " & Me.BENumberComboBox1.SelectedValue & ""
        ElseIf RadioButton5.Checked Then
            Path = "\\server\myreports$\MisExp\BE\RptBEDatewiseBalance1.rpt"
            Filter = "{tbl_BE_Head.BEId} in " & Me.BENumberComboBox.SelectedValue & " to " & Me.BENumberComboBox1.SelectedValue & "And {tbl_Inv_Tran_Date.DateName}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        ElseIf RadioButton6.Checked Then
            Path = "\\server\myreports$\MisExp\BE\RptBEDetail.rpt"
            Filter = "{tbl_BE_Head.BEId} in " & Me.BENumberComboBox.SelectedValue & " to " & Me.BENumberComboBox1.SelectedValue & ""
        End If
        Obj.LoadReports(Path, Filter, Nothing)
    End Sub
    Private Sub ShowContents(ByVal dt As Boolean, ByVal BE As Boolean)
        DateTimePicker1.Enabled = dt
        DateTimePicker2.Enabled = dt
        BENumberComboBox.Enabled = BE
        BENumberComboBox1.Enabled = BE
    End Sub
    Private Sub frmRptDailyTran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_BE_Head1TableAdapter.Fill(Me.DSRptBE.tbl_BE_Head1)
        Me.Tbl_BE_HeadTableAdapter.Fill(Me.DSRptBE.tbl_BE_Head)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        ShowContents(True, False)
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged
        If RadioButton5.Checked Then
            ShowContents(True, True)
        Else
            ShowContents(False, True)
        End If
    End Sub
End Class