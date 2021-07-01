Public Class FrmmatReports
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False

        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False

        End If
    End Sub



    Private Sub FrmmatReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSSec.tbl_Prd_Lines' table. You can move, or remove it, as needed.
        Me.Tbl_Prd_LinesTableAdapter.Fill(Me.DSSec.tbl_Prd_Lines)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New Class_Utility
        Dim Filter As String = ""
        Dim Path As String
        Path = "" & frmLoginVer.Reportpath & "\materialCencel.rpt"
        If RadioButton7.Checked = True Then '' Adidas

            If RadioButton2.Checked = True Then '' All
                Filter = "{View_Plan_Req_Lock.ClientID} = 1"
            ElseIf RadioButton5.Checked = True Then '' by plan Date

                Filter = " {View_Plan_Req_Lock.ClientID} = 1 and  {View_Plan_Req_Lock.PlanDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton8.Checked = True Then '' by factory Code and plan Date
                Filter = "{View_Plan_Req_Lock.ClientID} = 1 and {View_Plan_Req_Lock.FactoryCode} = '" & ComboBox1.Text & "' And {View_Plan_Req_Lock.PlanDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton3.Checked = True Then '' by factory Code

                Filter = "{View_Plan_Req_Lock.ClientID} = 1 and {View_Plan_Req_Lock.FactoryCode} = '" & ComboBox1.Text & "'"
            ElseIf RadioButton4.Checked = True Then '' by Deaprtment Code
                Filter = "{View_Plan_Req_Lock.ClientID} = 1 and {View_Plan_Req_Lock.PrdLine} = " & ComboBox2.SelectedValue & ""
            End If

        Else RadioButton6.Checked = True ' Non Adidas
            If RadioButton2.Checked = True Then '' All
                Filter = "{View_Plan_Req_Lock.ClientID} > 1"
            ElseIf RadioButton5.Checked = True Then '' by plan Date

                Filter = " {View_Plan_Req_Lock.ClientID} >  1 and  {View_Plan_Req_Lock.PlanDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton8.Checked = True Then '' by factory Code and plan Date
                Filter = "{View_Plan_Req_Lock.ClientID} > 1 and {View_Plan_Req_Lock.FactoryCode} = '" & ComboBox1.Text & "' And {View_Plan_Req_Lock.PlanDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


            ElseIf RadioButton3.Checked = True Then '' by factory Code
                Filter = "{View_Plan_Req_Lock.ClientID} > 1 and {View_Plan_Req_Lock.FactoryCode} = '" & ComboBox1.Text & "'"
            ElseIf RadioButton4.Checked = True Then '' by Deaprtment Code
                Filter = "{View_Plan_Req_Lock.ClientID} > 1 and {View_Plan_Req_Lock.PrdLine} = " & ComboBox2.SelectedValue & ""
            End If
        End If
        obj.LoadReports(Path, Filter, "")
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            ComboBox1.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            ComboBox1.Enabled = False
        End If
    End Sub
End Class