Public Class frmRptSaleBill
    Private Sub frmRptSaleBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSRptSaleBill.tbl_MM_Customer)
        Catch ex As Exception
        End Try
        Me.Tbl_MM_Sale_Bill_H1TableAdapter.Fill(Me.DSRptSaleBill.tbl_MM_Sale_Bill_H1)
        Me.Tbl_MM_Sale_Bill_HTableAdapter.Fill(Me.DSRptSaleBill.tbl_MM_Sale_Bill_H)
    End Sub
    Sub ShowContents(ByVal BillId As Boolean, ByVal Dt As Boolean, ByVal Com As Boolean)
        Me.BillIDComboBox.Enabled = BillId
        Me.BillIDComboBox1.Enabled = BillId
        Me.DateTimePicker1.Enabled = Dt
        Me.DateTimePicker2.Enabled = Dt
        Me.CompanyNameComboBox.Enabled = Com
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ShowContents(True, False, False)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ShowContents(False, True, False)
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        ShowContents(False, False, True)
    End Sub
    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        Dim Path As String = "" & frmLoginVer.Reportpath & "\RptSaleBill.rpt"
        If RadioButton1.Checked = True Then
            Filter = "{View_Sale_Bill.BillID}in " & Me.BillIDComboBox.SelectedValue & " to " & Me.BillIDComboBox1.SelectedValue & " "
        ElseIf RadioButton2.Checked = True Then
            Filter = "{View_Sale_Bill.BillDate}in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
        ElseIf RadioButton3.Checked = True Then
            Filter = "{View_Sale_Bill.Custid}=" & Me.CompanyNameComboBox.SelectedValue & ""
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub
End Class