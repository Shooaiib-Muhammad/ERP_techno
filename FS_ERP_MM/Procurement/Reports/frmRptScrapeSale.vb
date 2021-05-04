Public Class frmRptScrapeSale
    Private Sub frmRptScrapeSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSVendorInfo.tbl_PUR_Vendor_Info' table. You can move, or remove it, as needed.
        Me.Tbl_PUR_Vendor_InfoTableAdapter.Fill(Me.DSVendorInfo.tbl_PUR_Vendor_Info)
        'TODO: This line of code loads data into the 'DSSSGP.tbl_Mat_SaleH' table. You can move, or remove it, as needed.
        Me.Tbl_Mat_SaleHTableAdapter.Fill(Me.DSSSGP.tbl_Mat_SaleH)
        'TODO: This line of code loads data into the 'DSSSGP.View_Vendor_Info' table. You can move, or remove it, as needed.
        Me.View_Vendor_InfoTableAdapter.Fill(Me.DSSSGP.View_Vendor_Info)
        'TODO: This line of code loads data into the 'DSSSGP.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSSSGP.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSSSGP.tbl_Vendor_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Vendor_InfoTableAdapter.Fill(Me.DSSSGP.tbl_Vendor_Info)
    End Sub

    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        Dim obj As New Class_Utility
        Dim Path As String = "\\server\myreports$\FSERPMM\Inventory\New\RptScrapSale.rpt"
        Dim Filter As String = ""
        If RadioButton1.Checked Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = 'LSGP'"
        ElseIf RadioButton4.Checked Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = 'LSGP' AND {@Company} = '" & Me.NarationComboBox.Text & "'"
        ElseIf RadioButton6.Checked Then
            Filter = "{tbl_Inv_Tran_Out.SaleID} =" & Me.InvoiceNoComboBox1.SelectedValue & ""
        ElseIf RadioButton2.Checked Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = 'LSGP' AND {tbl_Inv_Tran_Out.Code} = '" & Me.CompanyNameComboBox.SelectedValue & "'"
        ElseIf RadioButton3.Checked Then
            Path = "\\server\myreports$\FSERPMM\Inventory\New\RptScrapSaleSummary.rpt"
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = 'LSGP'"
        ElseIf RadioButton5.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\RptDailyJalaEntry.rpt"
            If RadioButton12.Checked = True Then

                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # "
            ElseIf RadioButton7.Checked = True Then

                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  and {tbl_Inv_Jala_Entry.Status}=True"
            ElseIf RadioButton8.Checked = True Then

                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # and {tbl_Inv_Jala_Entry.Status}=False"
            End If
        ElseIf RadioButton9.Checked = True Then
            Path = "\\server\myreports$\ERPProcurement\ScrapSummaryRpt.rpt"
            If RadioButton12.Checked = True Then

                Filter = "{view_Scrab_material.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # "
            End If
        End If
        obj.LoadReports(Path, Filter, "")
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged
        Me.InvoiceNoComboBox1.Enabled = False
        Me.CompanyNameComboBox.Enabled = False
        Me.NarationComboBox.Enabled = False
        Me.DTPicker1.Enabled = True
        Me.DTPicker2.Enabled = True

        If RadioButton2.Checked Then
            Me.CompanyNameComboBox.Enabled = True
        End If
        If RadioButton4.Checked Then
            Me.NarationComboBox.Enabled = True
        End If
        If RadioButton6.Checked Then
            Me.InvoiceNoComboBox1.Enabled = True
            Me.DTPicker1.Enabled = False
            Me.DTPicker2.Enabled = False
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            RadioButton7.Enabled = False
            RadioButton8.Enabled = False
        Else
            RadioButton7.Enabled = True
            RadioButton8.Enabled = True
        End If
    End Sub
End Class