Public Class frmGPReports

    Private Sub btn_Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Show_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Show.Click
        Dim Filter As String = ""
        Dim Param As String = ""
        Dim Staus As String
        Dim objFrmFilter As New frmRptViewer
        If RadioGatePass.Checked Then


            If TypeCombo.Text = "All" Then
                If RadioEntryDate.Checked = True Then
                    Filter = "{View_Mat_SalesDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioGPRange.Checked = True Then
                    Filter = "{View_Mat_SalesDetails.GPNo} in " & GPNO.Text & " To " & GPNO1.Text
                ElseIf RadioUserName.Checked = True Then
                    Filter = "{View_Mat_SalesDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# and  {View_Mat_SalesDetails.UserID} =" & ComboBoxUsername.SelectedValue & ""
                ElseIf RadioButton3.Checked = True Then '' By Status
                    Filter = "{View_Mat_SalesDetails.CancelationStatus} = '" & ComboBox1.Text & "'  And {View_Mat_SalesDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# "
                End If
            Else
                If RadioEntryDate.Checked = True Then
                    Filter = "{View_Mat_SalesDetails.Type} = '" & TypeCombo.Text & "' and {View_Mat_SalesDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioGPRange.Checked = True Then
                    Filter = "{View_Mat_SalesDetails.Type} = '" & TypeCombo.Text & "' and {View_Mat_SalesDetails.GPNo} in " & GPNO.Text & " To " & GPNO1.Text
                ElseIf RadioUserName.Checked = True Then
                    Filter = "{View_Mat_SalesDetails.Type} = '" & TypeCombo.Text & "' and {View_Mat_SalesDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# and  {View_Mat_SalesDetails.UserID} =" & ComboBoxUsername.SelectedValue & ""
                ElseIf RadioButton3.Checked = True Then '' By Status
                    Filter = "{View_Mat_SalesDetails.CancelationStatus} = '" & ComboBox1.Text & "'  And {View_Mat_SalesDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# "

                End If
            End If

            objFrmFilter.ViewReport("\\server\MyReports$\FSERPMM\GatePass\RptGatePass_new.rpt", Filter)
            objFrmFilter.MdiParent = frmMain
            objFrmFilter.Show()
        ElseIf RadioButton1.Checked Then


            If RadioEntryDate.Checked = True Then
                Filter = "{View_Mat_GatePassDetails.Type} = 'RETURNABLE' and not {View_Mat_GatePassDetails.InStatus} And {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioGPRange.Checked = True Then
                Filter = "{View_Mat_GatePassDetails.Type} = 'RETURNABLE' and not {View_Mat_GatePassDetails.InStatus} And {View_Mat_GatePassDetails.GPNo} in " & GPNO.Text & " To " & GPNO1.Text
                'ElseIf RadioUserName.Checked = True Then
                '    Filter = "{View_Mat_GatePassDetails.Type} = '" & TypeCombo.Text & "' and {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# and  {View_Mat_SalesDetails.UserID} =" & ComboBoxUsername.SelectedValue & ""
            End If
            objFrmFilter.ViewReport("\\server\MyReports$\FSERPMM\GatePass\RptPendingReturnableGP.rpt", Filter)
            objFrmFilter.MdiParent = frmMain
            objFrmFilter.Show()
        ElseIf RadioButton2.Checked Then


            If TypeCombo.Text = "All" Then
                If RadioEntryDate.Checked = True Then
                    Filter = "{View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioGPRange.Checked = True Then
                    Filter = "{View_Mat_GatePassDetails.GPNo} in " & GPNO.Text & " To " & GPNO1.Text
                ElseIf RadioUserName.Checked = True Then
                    Filter = "{View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# and  {View_Mat_GatePassDetails.UserID} =" & ComboBoxUsername.SelectedValue & ""
                ElseIf RadioButton3.Checked = True Then '' By Status
                    Filter = " {View_Mat_GatePassDetails.CancelationStatus} = '" & ComboBox1.Text & "'  And {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton7.Checked = True Then '' By Items
                    Filter = " {View_Mat_GatePassDetails.L4Name} = '" & L4NameComboBox.Text & "'  And {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton6.Checked = True Then '' By Customer
                    Filter = "{View_Mat_GatePassDetails.Customer} = '" & NameComboBox.Text & "'  And {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# "

                End If
            Else
                If RadioEntryDate.Checked = True Then
                    Filter = " {View_Mat_GatePassDetails.Type} = '" & TypeCombo.Text & "' and {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioGPRange.Checked = True Then
                    Filter = "{View_Mat_GatePassDetails.Type} = '" & TypeCombo.Text & "' and {View_Mat_GatePassDetails.GPNo} in " & GPNO.Text & " To " & GPNO1.Text
                ElseIf RadioUserName.Checked = True Then
                    Filter = "{View_Mat_GatePassDetails.Type} = '" & TypeCombo.Text & "' and {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# and  {View_Mat_GatePassDetails.UserID} =" & ComboBoxUsername.SelectedValue & ""
                ElseIf RadioButton3.Checked = True Then '' By Status
                    Filter = " {View_Mat_GatePassDetails.CancelationStatus} = '" & ComboBox1.Text & "'  And {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton7.Checked = True Then '' By Items
                    Filter = " {View_Mat_GatePassDetails.L4Name} = '" & L4NameComboBox.Text & "'  And {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton6.Checked = True Then '' By Customer
                    Filter = "{View_Mat_GatePassDetails.Customer} = '" & NameComboBox.Text & "'  And {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "# "

                End If



            End If

            objFrmFilter.ViewReport("\\server\MyReports$\FSERPMM\GatePass\RptDailyGP.rpt", Filter)
            objFrmFilter.MdiParent = frmMain
            objFrmFilter.Show()


        ElseIf RadioButton4.Checked Then

            If ComboBox2.Text = "Pending" Then
                Staus = "not {View_Mat_GatePassDetails.HODStatus}"
            ElseIf ComboBox2.Text = "Approved" Then
                Staus = "  {View_Mat_GatePassDetails.HODStatus}"
            End If


            If RadioEntryDate.Checked = True Then
                Filter = "{View_Mat_GatePassDetails.DepID} = " & LocalCustIDLabel1.Text & " And {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "#  AND " & Staus & ""
            ElseIf RadioGPRange.Checked = True Then
                Filter = "{View_Mat_GatePassDetails.DepID} = " & LocalCustIDLabel1.Text & " And {View_Mat_GatePassDetails.GPNo} in " & GPNO.Text & " To " & GPNO1.Text & " And " & Staus & ""

            End If
            objFrmFilter.ViewReport("\\server\MyReports$\FSERPMM\GatePass\RptDailyGPHODApproval.rpt", Filter)
            objFrmFilter.MdiParent = frmMain
            objFrmFilter.Show()

        ElseIf RadioButton5.Checked Then
            If ComboBox2.Text = "Pending" Then
                Staus = "not {View_Mat_GatePassDetails.GMStatus} "
            ElseIf ComboBox2.Text = "Approved" Then
                Staus = "  {View_Mat_GatePassDetails.GMStatus}"
            End If


            If RadioEntryDate.Checked = True Then
                Filter = "{View_Mat_GatePassDetails.DepID} = " & LocalCustIDLabel1.Text & " And {View_Mat_GatePassDetails.EnteryDate} in #" & Format(Me.dtFrom.Value, "MM/dd/yyyy") & "# to #" & Format(Me.dtTo.Value, "MM/dd/yyyy") & "#  AND " & Staus & ""
            ElseIf RadioGPRange.Checked = True Then
                Filter = "{View_Mat_GatePassDetails.DepID} = " & LocalCustIDLabel1.Text & " And {View_Mat_GatePassDetails.GPNo} in " & GPNO.Text & " To " & GPNO1.Text & " And " & Staus & ""

            End If
            objFrmFilter.ViewReport("\\server\MyReports$\FSERPMM\GatePass\RptDailyGPGMApproval.rpt", Filter)
            objFrmFilter.MdiParent = frmMain
            objFrmFilter.Show()
        End If
    End Sub

    Private Sub RadioGPRange_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioGPRange.CheckedChanged
        If RadioGPRange.Checked = True Then
            GPNO.Enabled = True
            GPNO1.Enabled = True
        Else
            GPNO.Enabled = False
            GPNO1.Enabled = False
        End If
    End Sub

    Private Sub RadioEntryDate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioEntryDate.CheckedChanged
        If RadioEntryDate.Checked = True Then
            dtFrom.Enabled = True
            dtTo.Enabled = True
        Else
            dtFrom.Enabled = False
            dtTo.Enabled = False
        End If
    End Sub

    Private Sub frmGPReports_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSLocalPur.tbl_GP_Customer' table. You can move, or remove it, as needed.
        Me.Tbl_GP_CustomerTableAdapter.Fill(Me.DSLocalPur.tbl_GP_Customer)
        'TODO: This line of code loads data into the 'DSLocalPur.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSLocalPur.tbl_Inv_L4)
        Me.View_Mat_GatePass_UserTableAdapter.Fill(Me.DSLocalPur.View_Mat_GatePass_User)
        Try
            Me.View_userDeptTableAdapter.Fill(Me.DSLocalPur.View_userDept, frmLoginVer.UserID)
        Catch ex As Exception

        End Try
        'TypeCombo.Text = "OUTWARD"
        If frmLoginVer.UserID = 69 Or frmLoginVer.UserID = 2 Or frmLoginVer.DeptID = 24 Or frmLoginVer.UserID = 90 Then
            TypeCombo.Items.Add("All")
            TypeCombo.Items.Add("OUTWARD")
            TypeCombo.Items.Add("RETURNABLE")
            TypeCombo.Items.Add("INTERNAL TRANSFER PASS")
            TypeCombo.Items.Add("Return To Store")
            TypeCombo.Items.Add("TRANSFER PASS")
        Else
            TypeCombo.Items.Add("All")
            TypeCombo.Items.Add("INTERNAL TRANSFER PASS")
            TypeCombo.Items.Add("Return To Store")
            TypeCombo.Items.Add("TRANSFER PASS")
        End If
    End Sub

    Private Sub RadioUserName_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioUserName.CheckedChanged
        If RadioUserName.Checked = True Then
            dtFrom.Enabled = True
            dtTo.Enabled = True
            ComboBoxUsername.Enabled = True
        Else
            dtFrom.Enabled = False
            dtTo.Enabled = False
            ComboBoxUsername.Enabled = False
        End If
    End Sub

    Private Sub RadioGatePass_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGatePass.CheckedChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioGatePass.Checked Or RadioButton2.Checked Then
            RadioUserName.Enabled = True
            Me.TypeCombo.Enabled = True

        Else
            RadioUserName.Enabled = False
            Me.TypeCombo.Enabled = False

        End If
        If RadioButton2.Checked Then
            RadioButton6.Visible = True
            RadioButton7.Visible = True
            dtFrom.Enabled = True
            dtTo.Enabled = True
        Else
            RadioButton6.Visible = False
            RadioButton7.Visible = False
        End If
        dtFrom.Enabled = True
        dtTo.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            ComboBox1.Enabled = True
            dtFrom.Enabled = True
            dtTo.Enabled = True
            TypeCombo.Enabled = False
        Else
            ComboBox1.Enabled = False
            dtFrom.Enabled = False
            dtTo.Enabled = False
            TypeCombo.Enabled = True
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ComboBox2.Enabled = True
            RadioEntryDate.Checked = True
            RadioButton3.Enabled = False
        Else
            ComboBox2.Enabled = False
            RadioButton3.Enabled = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            RadioEntryDate.Checked = True
            ComboBox2.Enabled = True
            RadioButton3.Enabled = False
        Else
            ComboBox2.Enabled = False
            RadioButton3.Enabled = True
        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            L4NameComboBox.Enabled = True
        Else
            L4NameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            NameComboBox.Enabled = True
        Else
            NameComboBox.Enabled = False
        End If
    End Sub
End Class