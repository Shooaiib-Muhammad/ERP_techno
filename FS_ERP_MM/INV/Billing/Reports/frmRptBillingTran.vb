Public Class frmRptBillingTran

    Private Sub btnNewRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRpt.Click
        Dim obj As New Class_Utility
        Dim status As String = ""
        Dim Filter As String = ""
        Dim Path As String = "\\server\myreports$\FSERPMM\Billing\RptDailyBilling.rpt"
        If CheckBox2.Checked Then
            Path = "\\server\myreports$\FSERPMM\Billing\RptDailyBillingNew.rpt"
        End If

        If CheckBox3.CheckState = CheckState.Checked Then
            status = "{tbl_Sec_Middle.AuditVefiy} = True "
        ElseIf CheckBox3.CheckState = CheckState.Unchecked Then
            status = " {tbl_Sec_Middle.AuditVefiy}= False  "
            'ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
            '    Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
        End If

        If RadioButton1.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Pending'"
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Done'"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            End If
        ElseIf RadioButton2.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Pending'And {tbl_Billing_Party.PartyID} = " & Me.ComboBox1.SelectedValue & ""
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Done'And {tbl_Billing_Party.PartyID} = " & Me.ComboBox1.SelectedValue & ""
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {tbl_Billing_Party.PartyID} = " & Me.ComboBox1.SelectedValue & ""
            End If
        ElseIf RadioButton11.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Pending'And {tbl_Billing_Transactions_Detail.Code}  = '" & Me.ComboBox3.SelectedValue & "'"
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Done'And {tbl_Billing_Transactions_Detail.Code}  = '" & Me.ComboBox3.SelectedValue & "'"
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {tbl_Billing_Transactions_Detail.Code}  = '" & Me.ComboBox3.SelectedValue & "'"
            End If
        ElseIf RadioButton3.Checked Then
            If CheckBox2.Checked Then
                If CheckBox1.CheckState = CheckState.Checked Then
                    Filter = "{tbl_Billing_Transactions_Detail.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Pending'"
                ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                    Filter = "{tbl_Billing_Transactions_Detail.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Done'"
                ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                    Filter = "{tbl_Billing_Transactions_Detail.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
                End If
            Else
                If CheckBox1.CheckState = CheckState.Checked Then
                    Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Pending'"
                ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                    Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@VerifyStatus} = 'Done'"
                ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                    Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
                End If
            End If

        ElseIf RadioButton4.Checked Then
            Path = "\\server\myreports$\FSERPMM\Billing\RptDailyBillingSummary.rpt"
            Filter = "{tbl_Billing_Transactions.Amount} > 0.00"
        ElseIf RadioButton5.Checked Then
            Path = "\\server\myreports$\FSERPMM\Billing\RptDailyBillingSummaryNew.rpt"
            Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@ACStatus} = 'Done'"
        ElseIf RadioButton6.Checked Then
            Path = "\\server\myreports$\FSERPMM\Billing\RptDailyBillingSummaryNew.rpt"
            Filter = "{tbl_Billing_Transactions.VerifyDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #And {@ACStatus} = 'Done' And {tbl_Billing_Party.PartyID} = " & Me.ComboBox1.SelectedValue & ""
        ElseIf RadioButton7.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\InwardEntries.rpt"
            If INOUTComboBox.Text = "ALL" Then
                Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
            Else
                Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
            End If

        ElseIf RadioButton9.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\InwardEntries.rpt"
            If INOUTComboBox.Text = "ALL" Then
                Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Maker.Maker}='" & Me.MakerComboBox.Text & "'"
            Else
                Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "' And {tbl_Sec_Maker.Maker}='" & Me.MakerComboBox.Text & "'"
            End If

        ElseIf RadioButton8.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\OutwardEntries.rpt"
            If INOUTComboBox.Text = "ALL" Then
                Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
            Else
                Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
            End If

        ElseIf RadioButton10.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\OutwardEntries.rpt"
            If INOUTComboBox.Text = "ALL" Then
                Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Maker.Maker}='" & Me.MakerComboBox.Text & "'"

            Else
                Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "' And {tbl_Sec_Maker.Maker}='" & Me.MakerComboBox.Text & "'"

            End If



        ElseIf RadioButton12.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\InwardEntriesAuditverfication.rpt"
            If RadioButton15.Checked = True Then ' All
                If INOUTComboBox.Text = "ALL" Then
                    Filter = status & " and {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                Else
                    Filter = status & " and {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                End If

            ElseIf RadioButton14.Checked = True Then '' By Maker
                If INOUTComboBox.Text = "ALL" Then
                    Filter = status & " and {tbl_Sec_Maker.Maker} =  '" & Me.MakerComboBox.Text & "' and {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                Else
                    Filter = status & " and {tbl_Sec_Maker.Maker} =  '" & Me.MakerComboBox.Text & "' and {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                End If

            ElseIf RadioButton16.Checked = True Then '' By Summary
                If INOUTComboBox.Text = "ALL" Then
                    Filter = status & " and {tbl_Sec_Middle.CashSummary} = '" & Me.ComboBox4.Text & "' And {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                Else
                    Filter = status & " and {tbl_Sec_Middle.CashSummary} = '" & Me.ComboBox4.Text & "' And {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                End If

            ElseIf RadioButton18.Checked = True Then '' By Items
                If INOUTComboBox.Text = "ALL" Then
                    Filter = status & " and {tbl_Sec_Enteries.Item} =  '" & Me.ComboBox2.Text & "' And {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                Else
                    Filter = status & " and {tbl_Sec_Enteries.Item} =  '" & Me.ComboBox2.Text & "' And {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                End If

            ElseIf RadioButton19.Checked = True Then '' By Items and Maker
                If INOUTComboBox.Text = "ALL" Then
                    Filter = status & " and {tbl_Sec_Enteries.Item} =  '" & Me.ComboBox2.Text & "' and {tbl_Sec_Maker.Maker} =  '" & Me.MakerComboBox.Text & "'  And {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                Else
                    Filter = status & " and {tbl_Sec_Enteries.Item} =  '" & Me.ComboBox2.Text & "' and {tbl_Sec_Maker.Maker} =  '" & Me.MakerComboBox.Text & "'  And {tbl_Sec_Middle.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                End If


            End If

        ElseIf RadioButton17.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\inwardItems.rpt"
            If RadioButton15.Checked = True Then ' All
                If CheckBox3.CheckState = CheckState.Checked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "{tbl_Sec_Middle.AccountsVeirfyDate} And {tbl_Sec_Middle.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = "{tbl_Sec_Middle.AccountsVeirfyDate} And {tbl_Sec_Middle.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                    End If

                ElseIf CheckBox3.CheckState = CheckState.Unchecked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "not {tbl_Sec_Middle.AccountsVeirfyDate} and {tbl_Sec_Middle.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "

                    Else
                        Filter = "not {tbl_Sec_Middle.AccountsVeirfyDate} and {tbl_Sec_Middle.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "not {tbl_Sec_Middle.AccountsVeirfyDate} and {tbl_Sec_Middle.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = "not {tbl_Sec_Middle.AccountsVeirfyDate} and {tbl_Sec_Middle.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                    Filter = "not {tbl_Sec_Middle.AccountsVeirfyDate} and {tbl_Sec_Middle.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                    'ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                    '    Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {tbl_Sec_Middle.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                End If

            End If
        ElseIf RadioButton13.Checked = True Then
            Path = "\\server\MyReports$\FSERPPC\Security\InwardEntriesSummary1.rpt"
            If RadioButton15.Checked = True Then ' All
                If CheckBox3.CheckState = CheckState.Checked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "{View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = "{View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "#  And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                    End If

                ElseIf CheckBox3.CheckState = CheckState.Unchecked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = " not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "

                    Else
                        Filter = " not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "#  And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = " not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = " not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "#  And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                    'Filter = " not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                    'ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                    '    Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                End If
            ElseIf RadioButton16.Checked = True Then '' By Summary
                If CheckBox3.CheckState = CheckState.Checked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "{View_Inward_items_Summary.CashSummary} = '" & Me.ComboBox4.Text & "' And  {View_Inward_items_Summary.AccountsVeirfy} And {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = "{View_Inward_items_Summary.CashSummary} = '" & Me.ComboBox4.Text & "' And  {View_Inward_items_Summary.AccountsVeirfy} And {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                    'Filter = "{View_Inward_items_Summary.CashSummary} = '" & Me.ComboBox4.Text & "' And  {View_Inward_items_Summary.AccountsVeirfy} And {View_Inward_items_Summary.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                ElseIf CheckBox3.CheckState = CheckState.Unchecked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "{View_Inward_items_Summary.CashSummary} = '" & Me.ComboBox4.Text & "' And  not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = "{View_Inward_items_Summary.CashSummary} = '" & Me.ComboBox4.Text & "' And  not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                    'ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                    '    Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                End If
            ElseIf RadioButton14.Checked = True Then '' By maker
                If CheckBox3.CheckState = CheckState.Checked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "{View_Inward_items_Summary.Maker} = '" & Me.MakerComboBox.Text & "' And  {View_Inward_items_Summary.AccountsVeirfy} And {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = "{View_Inward_items_Summary.Maker} = '" & Me.MakerComboBox.Text & "' And  {View_Inward_items_Summary.AccountsVeirfy} And {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                ElseIf CheckBox3.CheckState = CheckState.Unchecked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "{View_Inward_items_Summary.Maker} = '" & Me.MakerComboBox.Text & "' And  not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = "{View_Inward_items_Summary.Maker} = '" & Me.MakerComboBox.Text & "' And  not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AccountsVeirfyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                    'ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                    '    Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                End If
            ElseIf RadioButton18.Checked = True Then '' By Items
                If CheckBox3.CheckState = CheckState.Checked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "{View_Inward_items_Summary.Maker} = '" & Me.MakerComboBox.Text & "' And  {View_Inward_items_Summary.AccountsVeirfy} And {View_Inward_items_Summary.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = "{View_Inward_items_Summary.Maker} = '" & Me.MakerComboBox.Text & "' And  {View_Inward_items_Summary.AccountsVeirfy} And {View_Inward_items_Summary.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                ElseIf CheckBox3.CheckState = CheckState.Unchecked Then
                    If INOUTComboBox.Text = "ALL" Then
                        Filter = "{View_Inward_items_Summary.Maker} = '" & Me.MakerComboBox.Text & "' And  not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = "{View_Inward_items_Summary.Maker} = '" & Me.MakerComboBox.Text & "' And  not {View_Inward_items_Summary.AccountsVeirfy} and {View_Inward_items_Summary.AuditVerifyDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"

                    End If
                    'ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                    '    Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in #" & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & "# And {View_Inward_items_Summary.INOUT} = '" & Me.INOUTComboBox.Text & "'"
                End If
            End If
        End If
        obj.LoadReports(Path, Filter, "")
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged, RadioButton9.CheckedChanged, RadioButton10.CheckedChanged, RadioButton11.CheckedChanged

        Me.ComboBox3.Enabled = True

        Me.ComboBox3.Visible = True
        INOUTComboBox.Enabled = False
        Me.MakerComboBox.Enabled = False
        Me.ComboBox1.Enabled = False
        If RadioButton1.Checked Or RadioButton3.Checked Or RadioButton5.Checked Or RadioButton6.Checked Then
            Me.ComboBox1.Enabled = False
        ElseIf RadioButton2.Checked Then
            Me.ComboBox1.Enabled = True
        End If
        If RadioButton9.Checked Or RadioButton10.Checked Then
            INOUTComboBox.Enabled = True
            Me.MakerComboBox.Enabled = True
        End If

        If RadioButton4.Checked Then
            Me.DTPicker1.Enabled = False
            Me.DTPicker2.Enabled = False
            Me.ComboBox1.Enabled = False
        Else
            Me.DTPicker2.Enabled = True
            Me.DTPicker1.Enabled = True
            Me.ComboBox1.Enabled = True
        End If
        If RadioButton7.Checked Or RadioButton8.Checked Then
            Me.ComboBox1.Enabled = False
            INOUTComboBox.Enabled = True
            Me.DTPicker2.Enabled = True
            Me.DTPicker1.Enabled = True
        End If
        If RadioButton11.Checked Then
            Me.ComboBox1.Enabled = False
            Me.DTPicker2.Enabled = True
            Me.DTPicker1.Enabled = True
            Me.ComboBox2.Visible = False
            Me.ComboBox3.Visible = True
            Me.ComboBox3.Enabled = True
            Me.ComboBox2.Enabled = False
        Else
            Me.ComboBox2.Visible = True
            Me.ComboBox3.Visible = False
            Me.ComboBox3.Enabled = False
            Me.ComboBox2.Enabled = True
        End If
    End Sub

    Private Sub frmRptBillingTran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBilling.tbl_Sec_Enteries_Items' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_Enteries_ItemsTableAdapter.Fill(Me.DSBilling.tbl_Sec_Enteries_Items)
        'TODO: This line of code loads data into the 'DSBilling.tbl_Sec_Enteries' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_EnteriesTableAdapter.Fill(Me.DSBilling.tbl_Sec_Enteries)
        'TODO: This line of code loads data into the 'DataSet1.tbl_Sec_Maker_NEW' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_Maker_NEWTableAdapter.Fill(Me.DataSet1.tbl_Sec_Maker_NEW)
        Me.Tbl_Billing_PartyTableAdapter.Fill(Me.DSBilling.tbl_Billing_Party)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DsDailyTran.tbl_Inv_L4)
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            Me.DTPicker1.Enabled = True
            Me.DTPicker2.Enabled = True
            INOUTComboBox.Enabled = True
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            MakerComboBox.Enabled = False
            CheckBox3.Enabled = True
            GroupBox2.Visible = True
            RadioButton16.Visible = True
        Else

            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            Me.DTPicker1.Enabled = True
            Me.DTPicker2.Enabled = True
            INOUTComboBox.Enabled = True
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            MakerComboBox.Enabled = False
            CheckBox3.Enabled = True

            RadioButton18.Visible = False
            RadioButton19.Visible = False
            GroupBox2.Visible = True
            RadioButton16.Visible = True
        Else

            RadioButton18.Visible = True
            RadioButton19.Visible = True
            RadioButton16.Visible = False
            GroupBox2.Visible = False
        End If

    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = True Then
            MakerComboBox.Enabled = True
        Else
            MakerComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then
            ComboBox4.Enabled = True
        Else
            ComboBox4.Enabled = False
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged

        If RadioButton17.Checked = True Then
            Me.DTPicker1.Enabled = True
            Me.DTPicker2.Enabled = True
            INOUTComboBox.Enabled = True

            RadioButton14.Enabled = False
            RadioButton16.Enabled = False
            CheckBox3.Enabled = True
            GroupBox2.Visible = True


        Else
            RadioButton14.Enabled = True
            RadioButton16.Enabled = True
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked = True Then
            ComboBox2.Enabled = True
            MakerComboBox.Enabled = True
        Else
            ComboBox2.Enabled = False
            MakerComboBox.Enabled = False
        End If
    End Sub
End Class