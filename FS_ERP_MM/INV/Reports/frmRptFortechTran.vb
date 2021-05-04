Public Class frmRptFortechTran


    Private Sub frmRptFortechTran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsDailyTran.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.FillBy1(Me.DsDailyTran.tbl_Inv_L4)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New Class_Utility
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim Param As String = ""
        If RadioButton1.Checked Then
            Path = "\\Server\myreports$\FSERPMM\ForTech\RptDailyIn.rpt"
            Filter = "{View_WEB_Daily_Mat_In.DateName}in # " & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & " #"
        ElseIf RadioButton2.Checked Then
            Path = "\\Server\myreports$\FSERPMM\ForTech\RptDailyOut.rpt"
            Filter = "{View_WEB_Daily_Mat_In.DateName}in # " & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & " #"
        ElseIf RadioButton3.Checked Then
            Path = "\\Server\myreports$\FSERPMM\ForTech\RptMatBalance.rpt"
            Filter = "{View_WEB_Daily_Mat_In.ForTechStatus}"
        ElseIf RadioButton4.Checked Then
            Path = "\\Server\myreports$\FSERPMM\ForTech\RptMatBalance.rpt"
            Filter = "{View_WEB_Daily_Mat_In.ForTechStatus}and {View_WEB_Daily_Mat_In.Code} = '" & Me.L4NameCombobox.SelectedValue & "'"
        ElseIf RadioButton5.Checked Then
            Param = "FirstDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "\\Server\myreports$\FSERPMM\ForTech\RptInvLedger.rpt"
            Filter = "{View_Inv_Tran_Main.DateName}in # " & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & " #And {View_Inv_Tran_Main.Code}= '" & Me.L4NameCombobox.SelectedValue & "'"
        End If
        obj.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged
        If RadioButton1.Checked Or RadioButton2.Checked Then
            Me.L4NameCombobox.Enabled = False
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = True
        ElseIf RadioButton3.Checked Then
            Me.L4NameCombobox.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
        ElseIf RadioButton4.Checked Then
            Me.L4NameCombobox.Enabled = True
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
        ElseIf RadioButton5.Checked Then
            Me.L4NameCombobox.Enabled = True
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = True
        End If
    End Sub
End Class