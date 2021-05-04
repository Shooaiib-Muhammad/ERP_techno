Public Class frmDemandReports11
    Private Sub frmDemandReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPO.tbl_Pur_Demand2' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_Demand2TableAdapter.Fill(Me.DSPO.tbl_Pur_Demand2)
        Me.Tbl_Pur_Demand1TableAdapter.Fill(Me.DSPO.tbl_Pur_Demand1)
        Me.Tbl_Pur_Demand_Head1TableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Head1)
        Me.Tbl_Pur_Demand_HeadTableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Head)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPO.tbl_Inv_L4)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSPO.tbl_Inv_Supplier)
        RadioButton5.Checked = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptInProcDemandsDt.rpt"
            If RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Pur_GenDemands.ReceiveQty} = 0.00"
                'Filter = "{View_Rpt_Pur_GenDemands.VerificationDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.ReceiveQty} = 0.00 And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_GenDemands.ReceiveQty} = 0.00"
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.ReceiveQty} = 0.00 And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Filter = " {View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.ReceiveQty} = 0.00 And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If
        ElseIf RadioButton25.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptInProcDemandsDtBal.rpt"
            If RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Pur_GenDemands.Balance} > 0.00"
                'Filter = "{View_Rpt_Pur_GenDemands.VerificationDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.Balance} > 0.00 And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_GenDemands.ReceiveQty} > 0.00 And {View_Rpt_Pur_GenDemands.Balance} > 0.00"
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.ReceiveQty} > 0.00 And {View_Rpt_Pur_GenDemands.Balance} > 0.00 And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.ReceiveQty} > 0.00 And {View_Rpt_Pur_GenDemands.Balance} > 0.00 And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If
        ElseIf RadioButton4.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptRecDemandsDt.rpt"
            If RadioButton5.Checked Then
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If
        ElseIf RadioButton9.Checked Then
            If RadioButton5.Checked Then
                Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptPurDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.PurchaseDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptPurDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.PurchaseDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptPurDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.PurchaseDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptPurDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.PurchaseDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            ElseIf RadioButton15.Checked Then
                Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptPurDemandsGDNo.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If
        ElseIf RadioButton10.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptBookingDemandsDt.rpt"
            ''Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptRecDemandsDtNew.rpt"
            'rptRecDemandsDtNew
            If RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "' "
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue & " "
            ElseIf RadioButton12.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue & " "
            End If
        ElseIf RadioButton11.Checked And RadioButton18.Checked = False And RadioButton24.Checked = False Then
            'TextBox1
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSum.rpt"

            If RadioButton5.Checked Then   'For Non POs Only
                If TextBox1.Text = "" Then
                    Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                Else
                    Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.BillNo}='" & Me.TextBox1.Text & "' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                End If

            ElseIf RadioButton6.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton8.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.SupplierID} = " & CompanyNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            ElseIf RadioButton15.Checked Then
                Path = "\\server\MyReports$\ERPProcurement\Demands\rptDemandAmtSumGDNo.rpt"
                Filter = "isnull({View_Rpt_Pur_GenDemands.POStatus}) And {View_Rpt_Pur_GenDemands.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_GenDemands.PurchaseAmt}) = false And {View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If

            'If RadioButton5.Checked Then    'For Both POs and Non POs
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            'ElseIf RadioButton6.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.Code} = '" & L4NameComboBox.SelectedValue & "'"
            'ElseIf RadioButton7.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.LocalCustID} = " & CustNameComboBox.SelectedValue
            'ElseIf RadioButton8.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.SupplierID} = " & CompanyNameComboBox.SelectedValue
            'ElseIf RadioButton12.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            'ElseIf RadioButton15.Checked Then
            '    Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSumGDNo.rpt"
            '    Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_GenDemands.PurchaseAmt}) = false And {View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            'End If
        ElseIf RadioButton22.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptItemPriceList.rpt"
            If RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_PartialFullUnion.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            End If
        ElseIf RadioButton21.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptItemPriceList.rpt"
            If RadioButton18.Checked Then
                Filter = "{View_Rpt_Pur_PartialFullUnion.VendorName} = '" & Me.VendorNameComboBox.Text & "' And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            End If
        ElseIf RadioButton16.Checked And RadioButton18.Checked = False And RadioButton24.Checked = False Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSum.rpt"

            If RadioButton5.Checked Then   'For Non POs Only
                If TextBox1.Text = "" Then
                    Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = '" & Me.ComboBox1.Text & "' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                Else
                    Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus})  And {View_Rpt_Pur_PartialFullUnion.BillNo}='" & Me.TextBox1.Text & "' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = '" & Me.ComboBox1.Text & "' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                End If

            ElseIf RadioButton6.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = '" & Me.ComboBox1.Text & "' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then   'For Non POs Only
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = '" & Me.ComboBox1.Text & "' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton8.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription}= '" & Me.ComboBox1.Text & "' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.SupplierID} = " & CompanyNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = '" & Me.ComboBox1.Text & "' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
                'ElseIf RadioButton24.Checked Then
                '    Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.VendorName} = '" & Me.VendorNameComboBox.Text & "' And {View_Rpt_Pur_PartialFullUnion.BillNo} = '" & Me.TextBox1.Text & "'"
            ElseIf RadioButton15.Checked Then
                Path = "\\server\MyReports$\ERPProcurement\Demands\rptDemandAmtSumGDNo.rpt"
                Filter = "isnull({View_Rpt_Pur_GenDemands.POStatus}) And {View_Rpt_Pur_GenDemands.PurchaseDescription} = 'Cash' And Isnull({View_Rpt_Pur_GenDemands.PurchaseAmt}) = false And {View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If

            'If RadioButton5.Checked Then    'For Both POs and Non POs
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            'ElseIf RadioButton6.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.Code} = '" & L4NameComboBox.SelectedValue & "'"
            'ElseIf RadioButton7.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.LocalCustID} = " & CustNameComboBox.SelectedValue
            'ElseIf RadioButton8.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.SupplierID} = " & CompanyNameComboBox.SelectedValue
            'ElseIf RadioButton12.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            'ElseIf RadioButton15.Checked Then
            '    Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSumGDNo.rpt"
            '    Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.PurchaseDescription} = 'Cash' And Isnull({View_Rpt_Pur_GenDemands.PurchaseAmt}) = false And {View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            'End If
        ElseIf RadioButton2.Checked And RadioButton18.Checked = False And RadioButton24.Checked = False Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSum.rpt"
            If RadioButton5.Checked Then   'For Non POs Only
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton8.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.SupplierID} = " & CompanyNameComboBox.SelectedValue
            ElseIf RadioButton24.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.VendorName} = '" & Me.VendorNameComboBox.Text & "' And {View_Rpt_Pur_PartialFullUnion.BillNo} = '" & Me.TextBox1.Text & "'"
            ElseIf RadioButton12.Checked Then
                Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            ElseIf RadioButton15.Checked Then
                Path = "\\server\MyReports$\ERPProcurement\Demands\rptDemandAmtSumGDNo.rpt"
                Filter = "isnull({View_Rpt_Pur_GenDemands.POStatus}) And ({View_Rpt_Pur_GenDemands.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_GenDemands.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_GenDemands.PurchaseAmt}) = false And {View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If

            'If RadioButton5.Checked Then    'For Both POs and Non POs
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            'ElseIf RadioButton6.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.Code} = '" & L4NameComboBox.SelectedValue & "'"
            'ElseIf RadioButton7.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.LocalCustID} = " & CustNameComboBox.SelectedValue
            'ElseIf RadioButton8.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.SupplierID} = " & CompanyNameComboBox.SelectedValue
            'ElseIf RadioButton12.Checked Then
            '    Filter = "{View_Rpt_Pur_PartialFullUnion.DemandStatus} = 'Active' And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            'ElseIf RadioButton15.Checked Then
            '    Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSumGDNo.rpt"
            '    Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And ({View_Rpt_Pur_GenDemands.PurchaseDescription} = 'Cash' Or {View_Rpt_Pur_GenDemands.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_GenDemands.PurchaseAmt}) = false And {View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            'End If
        ElseIf RadioButton13.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptPartialReceivingSum.rpt"
            If RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {tbl_Pur_PartialReceiving.PatialRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {tbl_Pur_PartialReceiving.PatialRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {tbl_Pur_PartialReceiving.PatialRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {tbl_Pur_PartialReceiving.PatialRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            ElseIf RadioButton15.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If
        ElseIf RadioButton14.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptPartialReceiving.rpt"
            If RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True  And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {tbl_Pur_PartialReceiving.PatialRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True  And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {tbl_Pur_PartialReceiving.PatialRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True  And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {tbl_Pur_PartialReceiving.PatialRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            ElseIf RadioButton15.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True  And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If
        ElseIf RadioButton3.Checked Then
            'Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptPendingDemandsDt.rpt"
            'If RadioButton5.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.PendingStatus} = True And {View_Rpt_Pur_GenDemands.PendingDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not {View_Rpt_Pur_GenDemands.CompStatus}"
            'ElseIf RadioButton6.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.PendingStatus} = True And {View_Rpt_Pur_GenDemands.PendingDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "' And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not{View_Rpt_Pur_GenDemands.CompStatus}"
            'ElseIf RadioButton7.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.PendingStatus} = True And {View_Rpt_Pur_GenDemands.PendingDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue & " And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not {View_Rpt_Pur_GenDemands.CompStatus}"
            'ElseIf RadioButton12.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.PendingStatus} = True And {View_Rpt_Pur_GenDemands.PendingDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue & " And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not {View_Rpt_Pur_GenDemands.CompStatus}"
            'ElseIf RadioButton18.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.PendingStatus} = True And {View_Rpt_Pur_GenDemands.PendingDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue & " And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not {View_Rpt_Pur_GenDemands.CompStatus} and {View_Rpt_Pur_GenDemands.VendorName} = '" & Me.VendorNameComboBox.Text & "'"
            'ElseIf RadioButton20.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.PendingStatus} = True And {View_Rpt_Pur_GenDemands.PendingDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.OrderGivenDesc} ='" & Me.OrderGivenDescComboBox.Text & "'"
            'End If
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptInProcDemandsDtNonActive.rpt"
            If RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} in ['Cancel', 'Pending'] And {View_Rpt_Pur_GenDemands.VerificationStatus} And{View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} in ['Cancel', 'Pending'] And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} in ['Cancel', 'Pending'] And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} in ['Cancel', 'Pending'] And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If
        ElseIf RadioButton17.Checked Then
            'Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptOGDemandsDt.rpt"
            'If RadioButton5.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.OGStatus} = True And {View_Rpt_Pur_GenDemands.OGDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not {View_Rpt_Pur_GenDemands.CompStatus}"
            'ElseIf RadioButton6.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.OGStatus} = True And {View_Rpt_Pur_GenDemands.OGDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "' And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not{View_Rpt_Pur_GenDemands.CompStatus}"
            'ElseIf RadioButton7.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.OGStatus} = True And {View_Rpt_Pur_GenDemands.OGDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue & " And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not {View_Rpt_Pur_GenDemands.CompStatus}"
            'ElseIf RadioButton12.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.OGStatus} = True And {View_Rpt_Pur_GenDemands.OGDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue & " And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not {View_Rpt_Pur_GenDemands.CompStatus}"
            'ElseIf RadioButton18.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.OGStatus} = True And {View_Rpt_Pur_GenDemands.OGDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue & " And isnull({View_Rpt_Pur_GenDemands.CompStatus})or not {View_Rpt_Pur_GenDemands.CompStatus}and {View_Rpt_Pur_GenDemands.VendorName} = '" & Me.VendorNameComboBox.Text & "'"
            'ElseIf RadioButton19.Checked Then
            '    Filter = "{View_Rpt_Pur_GenDemands.OGStatus} = True And {View_Rpt_Pur_GenDemands.OGDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.OrderGivenDesc} = '" & Me.OrderGivenDescComboBox.Text & "'"
            'End If

            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptInProcDemandsDtOG.rpt"
            If RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} in ['Order Given'] And {View_Rpt_Pur_GenDemands.VerificationStatus} And{View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} in ['Order Given'] And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} in ['Order Given'] And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton12.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} in ['Order Given'] And {View_Rpt_Pur_GenDemands.VerificationStatus} And {View_Rpt_Pur_GenDemands.CompStatus} = False And {View_Rpt_Pur_GenDemands.VerificationDate1} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} in " & GMNoComboBox.SelectedValue & " to " & GMNoComboBox1.SelectedValue
            End If

        ElseIf RadioButton16.Checked And RadioButton18.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSum.rpt"
            Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = '" & Me.ComboBox1.Text & "' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
        ElseIf RadioButton11.Checked And RadioButton18.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSum.rpt"
            Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
        ElseIf RadioButton2.Checked And RadioButton18.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSum.rpt"
            Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = '" & Me.ComboBox1.Text & "' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            '
        ElseIf RadioButton16.Checked And RadioButton24.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSum.rpt"
            Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = '" & Me.ComboBox1.Text & "' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.BillNo} = '" & Me.TextBox1.Text & "'"
        ElseIf RadioButton11.Checked And RadioButton24.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSum.rpt"
            Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit' And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")And {View_Rpt_Pur_PartialFullUnion.BillNo} = '" & Me.TextBox1.Text & "'"
        ElseIf RadioButton2.Checked And RadioButton24.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\rptDemandAmtSum.rpt"
            Filter = "isnull({View_Rpt_Pur_PartialFullUnion.POStatus}) And ({View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = '" & Me.ComboBox1.Text & "' Or {View_Rpt_Pur_PartialFullUnion.PurchaseDescription} = 'Credit') And Isnull({View_Rpt_Pur_PartialFullUnion.PurchaseAmt}) = false And {View_Rpt_Pur_PartialFullUnion.PurchaseStatus} =  true And {View_Rpt_Pur_PartialFullUnion.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {View_Rpt_Pur_PartialFullUnion.AmtEntryDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_PartialFullUnion.BillNo} = '" & Me.TextBox1.Text & "'"
            '

        ElseIf RadioButton23.Checked Then
            Path = "\\server\myreports$\FSERPMM\Procurement\RptVendorInfo.rpt"
            Filter = "{tbl_PUR_Vendor_Info.VendorID} > 0"
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Label5.Enabled = True
            DateTimePicker1.Enabled = True
            Me.OrderGivenDescComboBox.Enabled = False
            Label6.Enabled = True
            DateTimePicker2.Enabled = True

            Label8.Enabled = False
            L4NameComboBox.Enabled = False

            Label10.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = False
            CompanyNameComboBox.Enabled = False

            Label2.Enabled = False
            GMNoComboBox.Enabled = False

            Label20.Enabled = False
            GMNoComboBox1.Enabled = False
            VendorNameComboBox.Enabled = False
        End If

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Label5.Enabled = True
            DateTimePicker1.Enabled = True

            Label6.Enabled = True
            DateTimePicker2.Enabled = True
            Me.OrderGivenDescComboBox.Enabled = False
            VendorNameComboBox.Enabled = False
            Label8.Enabled = True
            L4NameComboBox.Enabled = True

            Label10.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = False
            CompanyNameComboBox.Enabled = False

            Label2.Enabled = False
            GMNoComboBox.Enabled = False

            Label20.Enabled = False
            GMNoComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            Label5.Enabled = True
            DateTimePicker1.Enabled = True

            Label6.Enabled = True
            DateTimePicker2.Enabled = True
            Me.OrderGivenDescComboBox.Enabled = False

            VendorNameComboBox.Enabled = False
            Label8.Enabled = False
            L4NameComboBox.Enabled = False

            Label10.Enabled = True
            CustNameComboBox.Enabled = True

            Label7.Enabled = False
            CompanyNameComboBox.Enabled = False

            Label2.Enabled = False
            GMNoComboBox.Enabled = False

            Label20.Enabled = False
            GMNoComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked Then
            Label5.Enabled = True
            DateTimePicker1.Enabled = True

            Label6.Enabled = True
            DateTimePicker2.Enabled = True

            Me.OrderGivenDescComboBox.Enabled = False
            VendorNameComboBox.Enabled = False
            Label8.Enabled = False
            L4NameComboBox.Enabled = False

            Label10.Enabled = False
            CustNameComboBox.Enabled = False

            Label2.Enabled = False
            GMNoComboBox.Enabled = False

            Label20.Enabled = False
            GMNoComboBox1.Enabled = False

            Label7.Enabled = True
            CompanyNameComboBox.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton25.CheckedChanged
        If RadioButton1.Checked Or RadioButton25.Checked Then
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = False
            RadioButton15.Enabled = False
            RadioButton5.Checked = True
            Me.RadioButton18.Enabled = False
            Me.RadioButton19.Enabled = False
            Me.RadioButton20.Enabled = False
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = False
            RadioButton15.Enabled = False
            RadioButton5.Checked = True
            Me.RadioButton19.Enabled = False
            Me.RadioButton18.Enabled = False
            Me.RadioButton20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked Then
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = False
            RadioButton15.Enabled = True
            Me.RadioButton19.Enabled = False
            RadioButton5.Checked = True
            Me.RadioButton18.Enabled = False
            Me.RadioButton20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked Then
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = False
            RadioButton15.Enabled = False
            RadioButton5.Checked = True
            Me.RadioButton19.Enabled = False
            Me.RadioButton18.Enabled = False
            Me.RadioButton20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked Then
            Label5.Enabled = True
            DateTimePicker1.Enabled = True
            Me.OrderGivenDescComboBox.Enabled = False
            Label6.Enabled = True
            DateTimePicker2.Enabled = True

            VendorNameComboBox.Enabled = False
            Label8.Enabled = False
            L4NameComboBox.Enabled = False

            Label10.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = False
            CompanyNameComboBox.Enabled = False

            Label2.Enabled = True
            GMNoComboBox.Enabled = True

            Label20.Enabled = True
            GMNoComboBox1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked Then
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = False
            RadioButton15.Enabled = True
            Me.RadioButton19.Enabled = False
            RadioButton12.Enabled = True
            RadioButton5.Checked = True
            Me.RadioButton18.Enabled = True
            Me.RadioButton20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked Then
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = False
            Me.RadioButton19.Enabled = False
            RadioButton15.Enabled = True
            Me.RadioButton18.Enabled = False
            RadioButton15.Checked = True
            Me.RadioButton20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked Then
            RadioButton5.Enabled = False
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = False
            RadioButton15.Enabled = True
            Me.RadioButton19.Enabled = False
            RadioButton15.Checked = True
            Me.RadioButton18.Enabled = False
            Me.RadioButton20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked Then
            Label5.Enabled = False
            DateTimePicker1.Enabled = False
            Me.OrderGivenDescComboBox.Enabled = False
            Label6.Enabled = False
            DateTimePicker2.Enabled = False

            Label8.Enabled = False
            L4NameComboBox.Enabled = False

            Label10.Enabled = False
            CustNameComboBox.Enabled = False

            Label7.Enabled = False
            CompanyNameComboBox.Enabled = False

            Label2.Enabled = True
            GMNoComboBox.Enabled = True

            VendorNameComboBox.Enabled = False
            Label20.Enabled = True
            GMNoComboBox1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked Then
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = False
            RadioButton15.Enabled = True
            Me.RadioButton19.Enabled = False
            RadioButton12.Enabled = True
            RadioButton5.Checked = True
            Me.RadioButton18.Enabled = True
            Me.RadioButton20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = False
            RadioButton15.Enabled = True
            Me.RadioButton19.Enabled = False
            RadioButton12.Enabled = True
            RadioButton5.Checked = True
            Me.RadioButton18.Enabled = True
            Me.RadioButton20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged, RadioButton22.CheckedChanged, RadioButton21.CheckedChanged
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton12.Enabled = True
        RadioButton8.Enabled = False
        RadioButton15.Enabled = False
        Me.RadioButton19.Enabled = False
        RadioButton5.Checked = True
        Me.RadioButton18.Enabled = True
        Me.RadioButton20.Enabled = True
        If RadioButton22.Checked Then
            RadioButton5.Enabled = False
            RadioButton6.Enabled = True
            RadioButton12.Enabled = False
            RadioButton7.Enabled = False
            RadioButton8.Enabled = False
            RadioButton15.Enabled = False
            Me.RadioButton19.Enabled = False
            RadioButton5.Checked = False
            Me.RadioButton18.Enabled = False
            Me.RadioButton20.Enabled = False
        ElseIf RadioButton21.Checked Then
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton12.Enabled = False
            RadioButton7.Enabled = False
            RadioButton8.Enabled = False
            RadioButton15.Enabled = False
            Me.RadioButton19.Enabled = False
            RadioButton5.Checked = False
            Me.RadioButton18.Enabled = True
            Me.RadioButton20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton17.CheckedChanged
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = False
        RadioButton15.Enabled = False
        RadioButton5.Checked = True
        Me.RadioButton19.Enabled = True
        Me.RadioButton18.Enabled = True
        Me.RadioButton18.Checked = True
        Me.RadioButton20.Enabled = False
    End Sub

    Private Sub RadioButton18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton18.CheckedChanged, RadioButton24.CheckedChanged
        Label5.Enabled = True
        DateTimePicker1.Enabled = True

        Label6.Enabled = True
        DateTimePicker2.Enabled = True

        Me.OrderGivenDescComboBox.Enabled = False
        VendorNameComboBox.Enabled = True
        Label8.Enabled = False
        L4NameComboBox.Enabled = False

        Label10.Enabled = False
        CustNameComboBox.Enabled = False

        Label2.Enabled = False
        GMNoComboBox.Enabled = False

        Label20.Enabled = False
        GMNoComboBox1.Enabled = False

        Label7.Enabled = True
        CompanyNameComboBox.Enabled = False
        Me.TextBox1.Enabled = True
    End Sub

    Private Sub RadioButton19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton19.CheckedChanged, RadioButton20.CheckedChanged
        Label5.Enabled = True
        DateTimePicker1.Enabled = True

        Label6.Enabled = True
        DateTimePicker2.Enabled = True
        Me.OrderGivenDescComboBox.Enabled = True

        VendorNameComboBox.Enabled = False
        Label8.Enabled = False
        L4NameComboBox.Enabled = False

        Label10.Enabled = False
        CustNameComboBox.Enabled = False

        Label2.Enabled = False
        GMNoComboBox.Enabled = False

        Label20.Enabled = False
        GMNoComboBox1.Enabled = False

        Label7.Enabled = True
        CompanyNameComboBox.Enabled = False
    End Sub
End Class