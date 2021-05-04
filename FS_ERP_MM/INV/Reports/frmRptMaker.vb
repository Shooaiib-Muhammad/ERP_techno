Public Class frmRptMaker

    Private Sub btnNewRpt_Click(sender As Object, e As EventArgs) Handles btnNewRpt.Click
        Dim obj As New Class_Utility
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        If Me.RadioButton1.Checked Then
            Filter = "{View_Bladder_Billing_Transaction.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # and {View_Bladder_Billing_Transaction.ExeID} = " & Me.MakerComboBox.SelectedValue & ""
            Param = "FromDate = " & Format(Me.DTPicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DTPicker2.Value, "dd/MM/yyyy") & ""
            Path = "\\server\myreports$\FSERPMM\Billing\RptBillMaker.rpt"
        ElseIf Me.RadioButton11.Checked Then
            Filter = "{View_Bladder_Billing_Transaction.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # and {View_Bladder_Billing_Transaction.ExeID} = " & Me.MakerComboBox.SelectedValue & ""
            Param = "FromDate = " & Format(Me.DTPicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DTPicker2.Value, "dd/MM/yyyy") & ""
            Path = "\\server\myreports$\FSERPMM\Billing\RptBillMakerAccount.rpt"

        End If
        If RadioButton2.Checked Then
            Filter = "{View_AMB_Print_Balance.Status}"
            'Param = "FromDate = " & Format(Me.DTPicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DTPicker2.Value, "dd/MM/yyyy") & ""
            Path = "\\server\myreports$\FSERPMM\AMB\RptPrintedBallBalance.rpt"
        End If
        obj.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub frmRptMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_MakersTableAdapter.Fill(Me.DSNewTranIn.tbl_Makers)
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Me.GroupBox1.Enabled = True
        Me.GroupBox3.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.GroupBox1.Enabled = False
        Me.GroupBox3.Enabled = False
    End Sub
End Class