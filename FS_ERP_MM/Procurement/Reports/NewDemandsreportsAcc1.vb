Public Class NewDemandsreportsAcc1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objRptViewer As New Class_Utility
        If RadioButton1.Checked Then 'For Pending Demands
            If RadioButton4.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.VerificationStatus}) And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton5.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.VerificationStatus}) And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton6.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.VerificationStatus}) And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton17.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.VerificationStatus}) And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton10.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.VerificationStatus}) And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            ElseIf RadioButton11.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.VerificationStatus}) And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month
            ElseIf RadioButton12.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.VerificationStatus}) And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton13.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.VerificationStatus}) And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton9.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.VerificationStatus}) And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
        ElseIf RadioButton2.Checked Then 'For Approved Demands After Process
            If RadioButton4.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And Isnull({View_Rpt_Pur_GenDemands.BookingStatus})And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton5.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true  And {View_Rpt_Pur_GenDemands.InProcessStatus}And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton6.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And {View_Rpt_Pur_GenDemands.InProcessStatus} And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton17.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus}= True And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton10.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And {View_Rpt_Pur_GenDemands.InProcessStatus} And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            ElseIf RadioButton11.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And {View_Rpt_Pur_GenDemands.InProcessStatus}And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month
            ElseIf RadioButton12.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And {View_Rpt_Pur_GenDemands.InProcessStatus} And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton13.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And {View_Rpt_Pur_GenDemands.InProcessStatus} And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton9.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And {View_Rpt_Pur_GenDemands.InProcessStatus} And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
        ElseIf RadioButton3.Checked Then 'For All Generated Demands
            If RadioButton4.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton5.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton6.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton17.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton10.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            ElseIf RadioButton11.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month
            ElseIf RadioButton12.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton13.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton9.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
        ElseIf RadioButton7.Checked Then 'For Rejected Demands
            If RadioButton4.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = False And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton5.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = False And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton6.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = False And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton17.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus}= false And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton10.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = False And {View_Rpt_Pur_GenDemands.PDDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            ElseIf RadioButton11.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = False And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month
            ElseIf RadioButton12.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = False And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton13.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = False And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton9.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsMn.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = False And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
        ElseIf RadioButton8.Checked Then 'For Full Received Demands
            If RadioButton4.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton5.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton6.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton17.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton10.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsDt.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {View_Rpt_Pur_GenDemands.CompDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            ElseIf RadioButton11.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsMn.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month
            ElseIf RadioButton12.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsMn.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton13.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsMn.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton9.Checked Then
                Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsMn.rpt"
                Filter = "Isnull({View_Rpt_Pur_GenDemands.PartialRecStatus}) And {View_Rpt_Pur_GenDemands.CompStatus} = True And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
            'here
        ElseIf RadioButton16.Checked Then 'For Issuance Demands
            Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptIssueDemandsDt.rpt"
            If RadioButton4.Checked Then
                'Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptIssueDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.DateName} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton5.Checked Then
                'Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.DateName} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton6.Checked Then
                'Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.DateName} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue & ""
            ElseIf RadioButton17.Checked Then
                'Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsDt.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.DateName} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue & ""
            ElseIf RadioButton10.Checked Then
                'Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsDt.rpt"
                Filter = "View_Rpt_Pur_GenDemands.DateName} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue & ""
            ElseIf RadioButton11.Checked Then
                'Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsMnIssuance.rpt"
                Filter = "{@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " "
            ElseIf RadioButton12.Checked Then
                'Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptRecDemandsMnIssuance.rpt"
                Filter = "{View_Rpt_Pur_GenDemands.Code}  = '" & L4NameComboBox.SelectedValue & "' And {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " "
            ElseIf RadioButton13.Checked Then

                Filter = "  {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue & ""
            ElseIf RadioButton9.Checked Then
                'Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptIssuedDemandsMn.rpt"
                Filter = " {@MyYear} = " & DateTimePicker1.Value.Year & " And {@MyMonth} = " & DateTimePicker1.Value.Month & " And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue & ""
            End If
            'End here
        ElseIf RadioButton14.Checked Then 'For Partial Received Demands
            Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptPartialReceiving.rpt"
            If RadioButton5.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = True And Isnull({View_Rpt_Pur_GenDemands.CompStatus}) And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  True And {tbl_Pur_PartialReceiving.PatialRecDate} In Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") To Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & L4NameComboBox.SelectedValue & "'"
            ElseIf RadioButton6.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And Isnull({View_Rpt_Pur_GenDemands.CompStatus}) And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {tbl_Pur_PartialReceiving.PatialRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton17.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And Isnull({View_Rpt_Pur_GenDemands.CompStatus}) And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {tbl_Pur_PartialReceiving.PatialRecDate} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Pur_GenDemands.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And {View_Rpt_Pur_GenDemands.LocalCustID} = " & CustNameComboBox.SelectedValue
            ElseIf RadioButton10.Checked Then
                Filter = "{View_Rpt_Pur_GenDemands.VerificationStatus} = true And Isnull({View_Rpt_Pur_GenDemands.CompStatus}) And {View_Rpt_Pur_GenDemands.PartialRecStatus} =  true And {View_Rpt_Pur_GenDemands.GMNo} = " & GMNoComboBox.SelectedValue
            End If
        ElseIf RadioButton15.Checked Then 'For Approved Demands Before Process
            Path = "\\server\MyReports$\FSERPMM\NewProcuments\OtherMaterial\rptGenDemandsDt.rpt"
            Filter = "{View_Rpt_Pur_GenDemands.DemandStatus} = 'Active' And {View_Rpt_Pur_GenDemands.VerificationStatus} And isnull({View_Rpt_Pur_GenDemands.InProcessStatus})"

        ElseIf RadioButton18.Checked Then 'For Approved Demands Before Process
            Path = "\\server\MyReports$\FSERPMM\NewProcuments\RptPendingDemands.rpt"
            Filter = "{View_PUR_Pending_Issuance.DateName} in Datetime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ") to Datetime(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
        ElseIf RadioButton19.Checked Then
            Path = "\\server\MyReports$\FSERPPC\Security\Rpt_Inv_Receivestore.rpt"
            If RadioButton4.Checked = True Then
                Filter = "{View_Inv_Receive_Qty.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton5.Checked Then
                Filter = "{View_Inv_Receive_Qty.L4Name} = '" & L4NameComboBox.Text & "' And {View_Inv_Receive_Qty.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton6.Checked Then

                Filter = "{View_Inv_Receive_Qty.CustName} = '" & CustNameComboBox.Text & "' And {View_Inv_Receive_Qty.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton17.Checked Then
                Filter = "{View_Inv_Receive_Qty.L4Name} = '" & L4NameComboBox.Text & "' And {View_Inv_Receive_Qty.CustName} = '" & CustNameComboBox.Text & "' And {View_Inv_Receive_Qty.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

            ElseIf RadioButton10.Checked Then

                Filter = "{View_Inv_Receive_Qty.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And  {View_Inv_Receive_Qty.GMNO} = " & GMNoComboBox.SelectedValue & ""

            End If

        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub
    Private Sub frmDemandReports4Ver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Pur_Demand_Head1TableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Head1)
        Me.Tbl_Pur_Demand_HeadTableAdapter.Fill(Me.DSPO.tbl_Pur_Demand_Head)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        If RadioButton4.Checked Then
            EnableDisabel(True, True, True, True, False, False, False, False, False, False)
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            EnableDisabel(True, True, True, True, False, False, False, False, False, False)
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            EnableDisabel(True, True, True, True, True, True, False, False, False, False)
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged, RadioButton17.CheckedChanged
        If RadioButton6.Checked Then
            EnableDisabel(True, True, True, True, False, False, True, True, False, False)
        ElseIf RadioButton17.Checked Then
            EnableDisabel(True, True, True, True, True, True, True, True, False, False)
        End If
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub EnableDisabel(ByVal L5Status As Boolean, ByVal DT1Status As Boolean, ByVal L6Status As Boolean, ByVal DT2Status As Boolean, ByVal L8Status As Boolean, ByVal CMB1Status As Boolean, ByVal L10Status As Boolean, ByVal CMB2Status As Boolean, ByVal L2Status As Boolean, ByVal CMB3Status As Boolean)
        Label5.Enabled = L5Status
        DateTimePicker1.Enabled = DT1Status

        Label6.Enabled = L6Status
        DateTimePicker2.Enabled = DT2Status

        Label8.Enabled = L8Status
        L4NameComboBox.Enabled = CMB1Status

        Label10.Enabled = L10Status
        CustNameComboBox.Enabled = CMB2Status

        Label2.Enabled = L2Status
        GMNoComboBox.Enabled = CMB3Status

    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked Then
            EnableDisabel(True, True, False, False, False, False, False, False, False, False)
            DateTimePicker1.CustomFormat = "MMM, yyyy"
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked Then
            EnableDisabel(True, True, False, False, True, True, False, False, False, False)
            DateTimePicker1.CustomFormat = "MMM, yyyy"
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked Then
            EnableDisabel(True, True, False, False, False, False, True, True, False, False)
            DateTimePicker1.CustomFormat = "MMM, yyyy"
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked Then
            If RadioButton10.Text = "Filter By Date Range And G.D. No" Then
                EnableDisabel(True, True, True, True, False, False, False, False, True, True)
                DateTimePicker1.CustomFormat = "dd/MM/yyyy"
            Else
                EnableDisabel(False, False, False, False, False, False, False, False, True, True)
            End If
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked Then
            EnableDisabel(True, True, False, False, False, False, False, False, True, True)
            DateTimePicker1.CustomFormat = "MMM, yyyy"
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked Then
            RadioButton4.Enabled = True
            'RadioButton5.Enabled = True
            'RadioButton6.Enabled = True
            'RadioButton10.Enabled = True

            RadioButton11.Enabled = False
            RadioButton12.Enabled = False
            RadioButton13.Enabled = False
            RadioButton9.Enabled = False
            RadioButton4.Checked = True
            EnableDisabel(False, False, False, False, False, False, False, False, False, False)
            RadioButton10.Text = "Filter By G.D. No Only"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            RadioButton4.Enabled = True
            'RadioButton5.Enabled = True
            'RadioButton6.Enabled = True
            'RadioButton10.Enabled = True

            RadioButton11.Enabled = True
            RadioButton12.Enabled = True
            RadioButton13.Enabled = True
            RadioButton9.Enabled = True
            RadioButton10.Text = "Filter By Date Range And G.D. No"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton4.Enabled = True
            'RadioButton5.Enabled = True
            'RadioButton6.Enabled = True
            'RadioButton10.Enabled = True

            RadioButton11.Enabled = True
            RadioButton12.Enabled = True
            RadioButton13.Enabled = True
            RadioButton9.Enabled = True
            RadioButton10.Text = "Filter By Date Range And G.D. No"
        End If
        If RadioButton4.Checked Then
            EnableDisabel(True, True, True, True, False, False, False, False, False, False)
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            RadioButton4.Enabled = True
            'RadioButton5.Enabled = True
            'RadioButton6.Enabled = True
            'RadioButton10.Enabled = True

            RadioButton11.Enabled = True
            RadioButton12.Enabled = True
            RadioButton13.Enabled = True
            RadioButton9.Enabled = True
            RadioButton10.Text = "Filter By Date Range And G.D. No"
        End If
        If RadioButton4.Checked Then
            EnableDisabel(True, True, True, True, False, False, False, False, False, False)
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton4.Enabled = True
            'RadioButton5.Enabled = True
            'RadioButton6.Enabled = True
            'RadioButton10.Enabled = True

            RadioButton11.Enabled = True
            RadioButton12.Enabled = True
            RadioButton13.Enabled = True
            RadioButton9.Enabled = True
            RadioButton10.Text = "Filter By Date Range And G.D. No"
        End If
        If RadioButton4.Checked Then
            EnableDisabel(True, True, True, True, False, False, False, False, False, False)
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged, RadioButton16.CheckedChanged
        If RadioButton8.Checked Or RadioButton16.Checked Then
            RadioButton4.Enabled = True
            'RadioButton5.Enabled = True
            'RadioButton6.Enabled = True
            'RadioButton10.Enabled = True

            RadioButton11.Enabled = True
            RadioButton12.Enabled = True
            RadioButton13.Enabled = True
            RadioButton9.Enabled = True
            RadioButton10.Text = "Filter By Date Range And G.D. No"
        End If
        If RadioButton4.Checked Then
            EnableDisabel(True, True, True, True, False, False, False, False, False, False)
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked Then
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton17.Enabled = False
            RadioButton10.Enabled = False

            EnableDisabel(False, False, False, False, False, False, False, False, False, False)
            GMNoComboBox1.Enabled = False
            RadioButton11.Enabled = False
            RadioButton12.Enabled = False
            RadioButton13.Enabled = False
            RadioButton9.Enabled = False
            'RadioButton10.Text = "Filter By Date Range And G.D. No"
        End If
    End Sub
End Class