﻿Public Class Reports


    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSSec.tbl_Sec_Vehicle' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_VehicleTableAdapter.Fill(Me.DSSec.tbl_Sec_Vehicle)
        'TODO: This line of code loads data into the 'DSSec.tbl_Sec_Driver' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_DriverTableAdapter.Fill(Me.DSSec.tbl_Sec_Driver)
        'TODO: This line of code loads data into the 'DSSec.tbl_Sec_Maker' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_MakerTableAdapter.Fill(Me.DSSec.tbl_Sec_Maker)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New Class_Utility
        Dim Filter As String = ""
        Dim Path As String

        If RadioButton7.Checked Then
            Path = "\\server\MyReports$\FSERPPC\Security\RptVehicleDetail.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        ElseIf RadioButton4.Checked Then
            Path = "\\server\MyReports$\FSERPPC\Security\RptVehicleDetail.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Vehicle_Enteries.Vehicle} = '" & Me.VehicleComboBox.Text & "'"
        ElseIf RadioButton5.Checked Then
            Path = "\\server\MyReports$\FSERPPC\Security\RptVehicleDetail.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Driver.DriverID} = " & Me.DriverNameComboBox1.SelectedValue & ""
        End If
        If RadioButton1.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\InwardEntries.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
        End If
        If RadioButton12.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\InwardEntries.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'And {tbl_Sec_Maker.MakerID} = '" & Me.MakerComboBox1.SelectedValue & "'"
        End If

        If RadioButton2.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\OutwardEntries.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "' And {tbl_Sec_Maker.MakerID} = '" & Me.MakerComboBox1.SelectedValue & "'"
        End If
        If RadioButton11.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\OutwardEntries.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "' "
        End If
        If RadioButton9.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\ArticalIssuranceVerRpt.rpt"
            Filter = " {tbl_PC_Issue_Art.VerifyDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        End If
        If RadioButton3.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\IssuanceVerification.rpt"
            Filter = " {tbl_PC_Issue_Art.VerifyDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
        End If


        obj.LoadReports(Path, Filter, "")
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton8.CheckedChanged, RadioButton11.CheckedChanged, RadioButton12.CheckedChanged
        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True
        Me.DriverNameComboBox1.Enabled = False
        Me.VehicleComboBox.Enabled = False
        Me.INOUTComboBox.Enabled = False
        Me.MakerComboBox1.Enabled = False
        If RadioButton4.Checked Then
            Me.VehicleComboBox.Enabled = True
        ElseIf RadioButton5.Checked Then
            Me.DriverNameComboBox1.Enabled = True
        End If
        If RadioButton1.Checked Or RadioButton2.Checked Then
            Me.INOUTComboBox.Enabled = True
            Me.MakerComboBox1.Enabled = True
        End If
        If RadioButton12.Checked Then
            Me.INOUTComboBox.Enabled = False
            Me.MakerComboBox1.Enabled = True
        End If
    End Sub
End Class