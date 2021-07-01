Public Class frmDemandReports4Acc

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Label5.Enabled = True
            DateTimePicker1.Enabled = True

            Label6.Enabled = True
            DateTimePicker2.Enabled = True

            Label8.Enabled = False
            L4NameComboBox.Enabled = False

            Label10.Enabled = False
            CustNameComboBox.Enabled = False

            Label2.Enabled = False
            GMNoComboBox.Enabled = False
        End If

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Label5.Enabled = True
            DateTimePicker1.Enabled = True

            Label6.Enabled = True
            DateTimePicker2.Enabled = True

            Label8.Enabled = True
            L4NameComboBox.Enabled = True

            Label10.Enabled = False
            CustNameComboBox.Enabled = False

            Label2.Enabled = False
            GMNoComboBox.Enabled = False
        End If

    End Sub

    Private Sub frmDemandReports4Acc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Pur_Demand1TableAdapter.Fill(Me.DSPO.tbl_Pur_Demand1)
        Me.Tbl_Pur_Demand_HeadTableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Head)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\rptPurDemandsDt.rpt"
            If RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.PurchaseDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.PurchaseDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.PurchaseDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton8.Checked Then
                Path = "" & frmLoginVer.Reportpath & "\rptPurDemandsGDNo.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PurchaseStatus} =  true And {View_Rpt_Pur_GenDemands.PurchaseDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
        ElseIf RadioButton2.Checked Then
            MsgBox("Under Construction")
            Exit Sub
        ElseIf RadioButton3.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\rptAPVSDemandsDt.rpt"
            If RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AfterPurchaseVStatus} = True And {View_Rpt_Pur_GenDemands.AfterPurchaseVDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AfterPurchaseVStatus} = True And {View_Rpt_Pur_GenDemands.AfterPurchaseVDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AfterPurchaseVStatus} = True And {View_Rpt_Pur_GenDemands.AfterPurchaseVDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton8.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AfterPurchaseVStatus} = True And {View_Rpt_Pur_GenDemands.AfterPurchaseVDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            ElseIf RadioButton11.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AfterPurchaseVStatus} = True And {View_Rpt_Pur_GenDemands.VendorName} = '" & Me.VendorNameComboBox.Text & "'"
            ElseIf RadioButton12.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AfterPurchaseVStatus} = True And {View_Rpt_Pur_GenDemands.BillNo} = '" & Me.TextBox1.Text & "'"
            ElseIf RadioButton13.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AfterPurchaseVStatus} = True And {View_Rpt_Pur_GenDemands.AfterPurchaseVDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")And {View_Rpt_Pur_GenDemands.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {View_Rpt_Pur_GenDemands.BillNo} = '" & Me.TextBox1.Text & "'"
            ElseIf RadioButton14.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.AfterPurchaseVStatus} = True And {View_Rpt_Pur_GenDemands.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {View_Rpt_Pur_GenDemands.BillNo} = '" & Me.TextBox1.Text & "'"
            End If
        ElseIf RadioButton4.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\rptPartialReceivingVer.rpt"
            If RadioButton5.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.VerificationDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.VerificationDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.VerificationDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton8.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.VerificationDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue

                '''''''''''
            ElseIf RadioButton11.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.VendorName} = '" & Me.VendorNameComboBox.Text & "'"
            ElseIf RadioButton12.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.BillNo} = '" & Me.TextBox1.Text & "'"
            ElseIf RadioButton13.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.VerificationDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")And {tbl_Pur_PartialReceiving.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {tbl_Pur_PartialReceiving.BillNo} = '" & Me.TextBox1.Text & "'"
            ElseIf RadioButton14.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.VendorName} = '" & Me.VendorNameComboBox.Text & "'And {tbl_Pur_PartialReceiving.BillNo} = '" & Me.TextBox1.Text & "'"
                ''''''

            End If
            'Exit Sub
        ElseIf RadioButton9.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\rptAPVSDemandsDtAcc.rpt"
            If RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.ActStatus} = True And {View_Rpt_Pur_GenDemands.ActRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.ActStatus} = True And {View_Rpt_Pur_GenDemands.ActRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.ActStatus} = True And {View_Rpt_Pur_GenDemands.ActRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton8.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.ActStatus} = True And {View_Rpt_Pur_GenDemands.ActRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
        ElseIf RadioButton10.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\rptPartialReceivingVerAcct.rpt"
            If RadioButton5.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.ActVerDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton6.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.ActVerDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton7.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.ActVerDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton8.Checked Then
                Filter = "{tbl_Pur_PartialReceiving.ActVerDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            Label5.Enabled = True
            DateTimePicker1.Enabled = True

            Label6.Enabled = True
            DateTimePicker2.Enabled = True

            Label8.Enabled = False
            L4NameComboBox.Enabled = False

            Label10.Enabled = True
            CustNameComboBox.Enabled = True

            Label2.Enabled = False
            GMNoComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked Then
            Label5.Enabled = True
            DateTimePicker1.Enabled = True

            Label6.Enabled = True
            DateTimePicker2.Enabled = True

            Label8.Enabled = False
            L4NameComboBox.Enabled = False

            Label10.Enabled = False
            CustNameComboBox.Enabled = False

            Label2.Enabled = True
            GMNoComboBox.Enabled = True
        End If
    End Sub

    
    
    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False
        Me.VendorNameComboBox.Enabled = True
        Me.TextBox1.Enabled = False
        L4NameComboBox.Enabled = False
        CustNameComboBox.Enabled = False
        GMNoComboBox.Enabled = False
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True
        Me.VendorNameComboBox.Enabled = True
        Me.TextBox1.Enabled = True

        L4NameComboBox.Enabled = False
        CustNameComboBox.Enabled = False
        GMNoComboBox.Enabled = False
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False
        Me.VendorNameComboBox.Enabled = False
        Me.TextBox1.Enabled = True
        L4NameComboBox.Enabled = False
        CustNameComboBox.Enabled = False
        GMNoComboBox.Enabled = False
    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False
        Me.VendorNameComboBox.Enabled = True
        Me.TextBox1.Enabled = True
        L4NameComboBox.Enabled = False
        CustNameComboBox.Enabled = False
        GMNoComboBox.Enabled = False
    End Sub
End Class