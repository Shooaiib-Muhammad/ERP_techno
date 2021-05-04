Public Class frmRptFilterBalance
    Private Sub frmRptFilterBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRptL4Code.tbl_Inv_L_NEW' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSRptL4Code.tbl_Inv_L43' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L43TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L43)
        Try
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSMat_Brow.tbl_Inv_Rack_Info)
        Catch ex As Exception

        End Try

        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L4)
        Me.Tbl_Inv_L42TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L42)
        Me.Tbl_Inv_L41TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L41)
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L3)
        Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L2)
        Me.Tbl_Inv_L1TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L1)
        Me.L4NameComboBox.Enabled = True
    End Sub
    Private Sub btnShowRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRpt.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = Nothing
        Dim objRptViewer As New Class_Utility
        If Me.RadioButton1.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "\\server\MyReports$\FSERPMM\Inventory\RptInvMMBalance.rpt"
            If Me.Status.CheckState = CheckState.Checked Then
                If CheckBox1.Checked Then
                    Filter = "{Proc_MM_Inv_Bal;1.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "'" & " And {Proc_MM_Inv_Bal;1.Status} And {Proc_MM_Inv_Bal;1.Balance} <= 0.00"
                Else
                    Filter = "{Proc_MM_Inv_Bal;1.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "'" & " And {Proc_MM_Inv_Bal;1.Status} and {Proc_MM_Inv_Bal;1.Balance} > 0.00"
                End If
            Else
                If CheckBox1.Checked Then
                    Filter = "{Proc_MM_Inv_Bal;1.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "'" & " And {Proc_MM_Inv_Bal;1.Balance} <= 0.00"
                Else
                    Filter = "{Proc_MM_Inv_Bal;1.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "'" & " and {Proc_MM_Inv_Bal;1.Balance} > 0.00"
                End If
            End If
        ElseIf Me.RadioButton2.Checked = True Then
            Filter = ""
            Path = "\\server\myreports$\FSERPMM\Inventory\RptMinBalAlert.rpt"
        ElseIf Me.RadioButton3.Checked = True Then
            If Me.Tbl_Inv_L_NEWTableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L_NEW, Me.L4NameComboBox.Text) > 0 Then
                Param = "FirstDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
                If Me.Status.CheckState = CheckState.Checked Then
                    Filter = "{View_Inv_Tran_Main.Code} = '" & Me.DSRptL4Code.tbl_Inv_L_NEW.Rows(0).Item("Code") & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Inv_Tran_Main.ActStat}"
                    Path = "\\server\myreports$\FSERPMM\Inventory\RptInvLedger.rpt"
                Else
                    Path = "\\server\myreports$\FSERPMM\Inventory\RptInvLedger.rpt"
                    Filter = "{View_Inv_Tran_Main.Code} = '" & Me.DSRptL4Code.tbl_Inv_L_NEW.Rows(0).Item("Code") & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to  #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If

            End If

        ElseIf Me.RadioButton20.Checked = True Then
            'Param = "FirstDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")"&ToDate=" & Format(DateTimePicker2.Value, "dd/MM/yyyy")"
            Param = "FirstDate=" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(DateTimePicker2.Value, "dd/MM/yyyy")
            'If Me.Status.CheckState = CheckState.Checked Then
            Filter = "{View_Inv_Tran_Main.L3Name} = '" & Me.Layer3IDComboBox.Text & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Inv_Tran_Main.ActStat}"
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvLedgerNew.rpt"
            'Else
            '    Filter = "{View_Inv_Tran_Main.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to  #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            '    Path = "\\server\myreports$\FSERPMM\Inventory\RptInvLedger.rpt"
            'End If
        ElseIf Me.RadioButton4.Checked = True Then
            If Me.Status.CheckState = CheckState.Checked Then
                Path = "\\server\myreports$\FSERPMM\Inventory\RptInvDailyBalance.rpt"
                Filter = "{tbl_Inv_Code.Code} >= '" & Me.CodeComboBox.SelectedValue & "' And {tbl_Inv_Code.Code} <= '" & Me.CodeComboBox1.SelectedValue & "'" & " And {tbl_Inv_L4.Status}"
            Else
                Path = "\\server\myreports$\FSERPMM\Inventory\RptInvDailyBalance.rpt"
                Filter = "{tbl_Inv_Code.Code} >= '" & Me.CodeComboBox.SelectedValue & "' And {tbl_Inv_Code.Code} <= '" & Me.CodeComboBox1.SelectedValue & "'"
            End If
        ElseIf Me.RadioButton5.Checked = True Then
            Filter = ""
            Param = "TillDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvL3Balance.rpt"
        ElseIf Me.RadioButton7.Checked = True Then
            Filter = "{Proc_MM_Inv_Bal;1.TMStatus}"
            Param = "TillDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvMMTMBalance.rpt"
        ElseIf Me.RadioButton16.Checked = True Then
            Filter = "{Proc_MM_Inv_Bal;1.MS}"
            Param = "TillDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvMMMSBalance.rpt"
        ElseIf Me.RadioButton15.Checked = True Then
            Filter = "{Proc_MM_Inv_Bal;1.HS}"
            Param = "TillDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvMMHSBalance.rpt"
        ElseIf Me.RadioButton8.Checked = True Then
            Param = "FirstDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Filter = "{View_Inv_Tran_Main.Code} ='" & Me.L4NameComboBox.SelectedValue & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to  #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "\\server\myreports$\FSERPMM\Inventory\RptCompInvLedger.rpt"
        ElseIf Me.RadioButton6.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "\\server\MyReports$\FSERPMM\Inventory\RptInvMMBalance.rpt"
            If Me.Status.CheckState = CheckState.Checked Then
                If CheckBox1.Checked = True Then
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Status}And {Proc_MM_Inv_Bal;1.Balance} <= 0.00"
                Else
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Status}And {Proc_MM_Inv_Bal;1.Balance} > 0.00"
                End If
            Else
                'Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'"
                If CheckBox1.Checked = True Then
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Balance} <= 0.00"
                Else
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Balance} > 0.00"
                End If
            End If
        ElseIf Me.RadioButton9.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "\\server\MyReports$\FSERPMM\Inventory\RptInvMMBalance.rpt"
            If Me.Status.CheckState = CheckState.Checked Then
                If CheckBox1.Checked Then
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Status} = true And {Proc_MM_Inv_Bal;1.Balance} <= 0.00 "
                Else
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Status} = true And {Proc_MM_Inv_Bal;1.Balance} > 0.00 "
                End If
            Else
                If CheckBox1.Checked Then
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Balance} <= 0.00"
                Else
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Balance} > 0.00"
                End If
            End If
        ElseIf RadioButton19.Checked Then
            Filter = "{tbl_Inv_L3.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {tbl_Inv_L3.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {tbl_Inv_L3.Layer3ID} = '" & Me.Layer3IDComboBox.SelectedValue & "'AND {tbl_Inv_Tran_Date.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to  #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "\\server\MyReports$\FSERPMM\Inventory\New\RptDailyOut.rpt"

        ElseIf Me.RadioButton10.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "\\server\MyReports$\FSERPMM\Inventory\RptInvMMBalance.rpt"
            If Me.Status.CheckState = CheckState.Checked Then
                If CheckBox1.Checked Then
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer3ID} = '" & Me.Layer3IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Status} = true And {Proc_MM_Inv_Bal;1.Balance} <= 0.00"
                Else
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer3ID} = '" & Me.Layer3IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Status} = true And {Proc_MM_Inv_Bal;1.Balance} > 0.00"
                End If
            Else
                If CheckBox1.Checked Then
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer3ID} = '" & Me.Layer3IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Balance} <= 0.00"
                Else
                    Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer3ID} = '" & Me.Layer3IDComboBox.SelectedValue & "'And {Proc_MM_Inv_Bal;1.Balance} > 0.00"
                End If
            End If
        ElseIf RadioButton11.Checked Then
            Path = "\\server\MyReports$\FSERPMM\Inventory\RptRackwiseMatBal.rpt"
            Filter = "{View_Inv_Rack_Balance.RackId} = " & Me.RackNoComboBox.SelectedValue & ""
        ElseIf RadioButton12.Checked Then
            Path = "\\server\MyReports$\FSERPMM\Inventory\RptInvL3Out.rpt"
            Param = "FromDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DateTimePicker2.Value, "dd/MM/yyyy") & ""
            Filter = "{tbl_Inv_L3.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' "
        ElseIf RadioButton13.Checked Then
            Path = "\\server\MyReports$\FSERPMM\Inventory\RptUnUsedMaterial.rpt"
            Param = "FromDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DateTimePicker2.Value, "dd/MM/yyyy") & ""
            'Filter = "{tbl_Inv_L4.Layer1ID} = '1'"
            Filter = "{tbl_Inv_L4.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "'" & ""
        ElseIf Me.RadioButton14.Checked = True Then
            Path = "\\server\myreports$\FSERPMM\WareHouse\RptInvWHBalance.rpt"
            Filter = "{tbl_Inv_L4.Code} >= '" & Me.CodeComboBox.SelectedValue & "' And {tbl_Inv_L4.Code} <= '" & Me.CodeComboBox1.SelectedValue & "'" & " And {tbl_Inv_L4.Status}"
        ElseIf Me.RadioButton17.Checked = True Then
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvMonthlyIssuance.rpt"
            '{tbl_Inv_L3.L3Name} = "Poly Bags"
            Filter = "{tbl_Inv_L3.L3Name} = '" & Me.Layer3IDComboBox.Text & "'And {@Month} =" & Me.DateTimePicker1.Value.Month & " And {@Year} =" & Me.DateTimePicker1.Value.Year & ""
        ElseIf RadioButton18.Checked Then
            Param = "FirstDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&MyDate1=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&MyDate2=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & ""
            Filter = "{View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "\\server\myreports$\MisExp\BE\RptImpMatLedger.rpt"
        End If
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton17.CheckedChanged, RadioButton13.CheckedChanged
        Me.RackNoComboBox.Enabled = False
        Me.GroupBox2.Visible = True

        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = True

        Me.CodeComboBox.Enabled = True
        Me.CodeComboBox1.Enabled = True

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        If RadioButton13.Checked Then
            Me.DateTimePicker2.Enabled = True
        End If

        Me.L4NameComboBox.Enabled = False
        If RadioButton17.Checked Then
            Me.CodeComboBox1.Enabled = False
            Me.CodeComboBox.Enabled = False
        Else
            Me.CodeComboBox1.Enabled = True
        End If

    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.RackNoComboBox.Enabled = False
        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True

        Me.L4NameComboBox.Enabled = True
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged, RadioButton14.CheckedChanged
        Me.RackNoComboBox.Enabled = False
        Me.GroupBox2.Visible = True

        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = True

        Me.CodeLabel2.Enabled = True
        Me.CodeLabel3.Enabled = True

        Me.CodeComboBox.Enabled = True
        Me.CodeComboBox1.Enabled = True

        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Me.GroupBox2.Visible = True

        Me.RackNoComboBox.Enabled = False
        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeLabel2.Enabled = False
        Me.CodeLabel3.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False

    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.RackNoComboBox.Enabled = False
        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeLabel2.Enabled = False
        Me.CodeLabel3.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged, RadioButton12.CheckedChanged, RadioButton18.CheckedChanged

        Me.GroupBox2.Enabled = True
        Me.RackNoComboBox.Enabled = False
        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True


        Me.L4NameComboBox.Enabled = False
        If RadioButton12.Checked Or RadioButton13.Checked Then
            Me.Layer1IDComboBox.Enabled = True
        ElseIf RadioButton18.Checked Then
            Me.Layer1IDComboBox.Enabled = False
            Me.DateTimePicker2.Enabled = True
        Else

            Me.DateTimePicker2.Enabled = False
        End If

    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged, RadioButton15.CheckedChanged, RadioButton16.CheckedChanged

        Me.GroupBox2.Visible = True
        Me.RackNoComboBox.Enabled = False
        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False


        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged

        Me.GroupBox2.Visible = True
        Me.RackNoComboBox.Enabled = False
        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True

        Me.L4NameComboBox.Enabled = True
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        Me.GroupBox2.Enabled = True
        Me.RackNoComboBox.Enabled = False
        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged, RadioButton19.CheckedChanged
        Me.GroupBox2.Enabled = True
        Me.RackNoComboBox.Enabled = False
        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = True

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
        If RadioButton19.Checked Then
            Me.DateTimePicker2.Enabled = True
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        Me.GroupBox2.Enabled = True
        Me.RackNoComboBox.Enabled = True
        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        Me.GroupBox2.Enabled = True

        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = True

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub L4NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L4NameComboBox.SelectedIndexChanged

    End Sub
    Sub BindAutoComplete(ByVal comboControl As ComboBox, ByVal dataSource As DataTable, ByVal valueColumn As String, ByVal textColumn As String)
        comboControl.ValueMember = "id"
        comboControl.DisplayMember = "Text"
        comboControl.Items.Clear()
        Dim RowFilter = "" & textColumn & " like '%" & comboControl.Text & "%'"
        Dim listNew = dataSource.Select(RowFilter).Select(Function(fu) New With {.Id = fu(valueColumn), .Text = fu(textColumn)}).ToList
        comboControl.Items.AddRange(listNew.ToArray())
        comboControl.SelectionStart = comboControl.Text.Length
        Cursor = Cursors.[Default]
        'comboControl.DroppedDown = True

    End Sub
    Private Sub L4NameComboBox_TextUpdate(sender As Object, e As EventArgs) Handles L4NameComboBox.TextUpdate
        BindAutoComplete(L4NameComboBox, Me.DSRptL4Code.tbl_Inv_L43, "Code", "L4Name")
        L4NameComboBox.DroppedDown = True
    End Sub
End Class