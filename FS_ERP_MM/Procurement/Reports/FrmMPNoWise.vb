Public Class FrmMPNoWise
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = Nothing
        Dim Path As String
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked = True Then
            Path = "" & frmLoginVer.Reportpath & "\RptMatBatchOut.rpt"
            If RadioButton2.Checked Then '' By Date Wise
                Filter = "{View_Inv_BatchNo_Issue.IssueDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "

            ElseIf RadioButton3.Checked Then '' By MPNo Wise
                Filter = "{View_Inv_BatchNo_Issue.MPID} =  " & Me.MPIDComboBox.SelectedValue & " "

            End If

        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub



    Private Sub FrmMPNoWise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRpt.tbl_Pro_Plan1' table. You can move, or remove it, as needed.

        Try
            Me.Tbl_Pro_Plan1TableAdapter.Fill(Me.DSRpt.tbl_Pro_Plan1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            MPIDComboBox.Enabled = True
        Else
            MPIDComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        End If
    End Sub
End Class