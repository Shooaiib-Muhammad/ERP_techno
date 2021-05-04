Public Class frmTMBalances
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            Me.L4NameComboBox.Enabled = False
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Me.L4NameComboBox.Enabled = True
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = True
        End If
    End Sub
    Private Sub frmTMBalances_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L4)
    End Sub
    Private Sub btnShowRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRpt.Click
        Dim Filter As String = Nothing
        Dim Path As String = Nothing
        Dim Param As String = Nothing
        Dim objRptViewer As New Class_Utility
        If Me.RadioButton7.Checked = True Then
            Param = "FirstDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Filter = "{Proc_MM_Inv_Bal;1.TMStatus}"
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvMMTMBalance.rpt"
        ElseIf Me.RadioButton8.Checked = True Then
            Param = "FirstDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Filter = "{View_Inv_Tran_Main.Code} ='" & Me.L4NameComboBox.SelectedValue & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to  #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "\\server\myreports$\FSERPMM\Inventory\RptCompInvLedger.rpt"
        End If
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub
End Class