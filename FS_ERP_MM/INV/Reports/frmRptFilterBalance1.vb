Public Class frmRptFilterBalance1
    Private Sub frmRptFilterBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L4)
        Me.Tbl_Inv_L42TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L42)
        Me.Tbl_Inv_L41TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L41)
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L3)
        Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L2)
        Me.Tbl_Inv_L1TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L1)
    End Sub
   
    Private Sub btnShowRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRpt.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objRptViewer As New Class_Utility
        Dim Param As String = ""
        If Me.RadioButton1.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            If Me.Status.CheckState = CheckState.Checked Then
                Filter = "{Proc_MM_Inv_Bal;1.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "'" & " And {Proc_MM_Inv_Bal;1.Status}"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            Else
                Filter = "{Proc_MM_Inv_Bal;1.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "'"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            End If
        ElseIf Me.RadioButton2.Checked = True Then
            Filter = ""
            Path = "" & frmLoginVer.Reportpath & "\RptMinBalAlert.rpt"
        ElseIf Me.RadioButton3.Checked = True Then
            Param = "FirstDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            If Me.Status.CheckState = CheckState.Checked Then
                Filter = "{View_Inv_Tran_Main.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Inv_Tran_Main.ActStat}"
                Path = "" & frmLoginVer.Reportpath & "\RptInvLedger.rpt"
            Else
                Filter = "{View_Inv_Tran_Main.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to  #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                Path = "" & frmLoginVer.Reportpath & "\RptInvLedger.rpt"
            End If
        ElseIf Me.RadioButton13.Checked = True Then
            'Param = "FirstDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")"&ToDate=" & Format(DateTimePicker2.Value, "dd/MM/yyyy")"
            Param = "FirstDate=" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(DateTimePicker2.Value, "dd/MM/yyyy")
            'If Me.Status.CheckState = CheckState.Checked Then
            Filter = "{View_Inv_Tran_Main.L3Name} = '" & Me.Layer3IDComboBox.Text & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Inv_Tran_Main.ActStat}"
            Path = "" & frmLoginVer.Reportpath & "\RptInvLedgerNew.rpt"
            'Else
            '    Filter = "{View_Inv_Tran_Main.Code} in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to  #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            '    Path = "" & frmLoginVer.Reportpath & "\RptInvLedger.rpt"
            'End If
        ElseIf Me.RadioButton4.Checked = True Then
            If Me.Status.CheckState = CheckState.Checked Then
                Filter = "{tbl_Inv_Code.Code} >= '" & Me.CodeComboBox.SelectedValue & "' And {tbl_Inv_Code.Code} <= '" & Me.CodeComboBox1.SelectedValue & "'" & " And {tbl_Inv_L4.Status}"
                Path = "" & frmLoginVer.Reportpath & "\RptInvDailyBalance.rpt"
            Else
                Filter = "{tbl_Inv_Code.Code} >= '" & Me.CodeComboBox.SelectedValue & "' And {tbl_Inv_Code.Code} <= '" & Me.CodeComboBox1.SelectedValue & "'"
                Path = "" & frmLoginVer.Reportpath & "\RptInvDailyBalance.rpt"
            End If
        ElseIf Me.RadioButton5.Checked = True Then
            Filter = ""
            Param = "TillDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Path = "" & frmLoginVer.Reportpath & "\RptInvL3Balance.rpt"
        ElseIf Me.RadioButton7.Checked = True Then
            Filter = "{tbl_Inv_L4.TMStatus}"
            Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceTM.rpt"
        ElseIf Me.RadioButton8.Checked = True Then
            Param = "FirstDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            Filter = "{View_Inv_Tran_Main.Code} ='" & Me.L4NameComboBox.SelectedValue & "' AND {View_Inv_Tran_Main.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to  #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Path = "" & frmLoginVer.Reportpath & "\RptCompInvLedger.rpt"
        ElseIf Me.RadioButton6.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            If Me.Status.CheckState = CheckState.Checked Then
                Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Status} "
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            Else
                Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            End If
        ElseIf Me.RadioButton9.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            If Me.Status.CheckState = CheckState.Checked Then
                Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Status}"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            Else
                Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "'"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            End If
        ElseIf Me.RadioButton10.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            If Me.Status.CheckState = CheckState.Checked Then
                Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer3ID} = '" & Me.Layer3IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Status}"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            Else
                Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer2ID} = '" & Me.Layer2IDComboBox.SelectedValue & "' And {Proc_MM_Inv_Bal;1.Layer3ID} = '" & Me.Layer3IDComboBox.SelectedValue & "'"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            End If
        ElseIf Me.RadioButton11.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            If Me.Status.CheckState = CheckState.Checked Then
                Filter = " {Proc_MM_Inv_Bal;1.Status}"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            Else
                Filter = ""
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmount.rpt"
            End If
        ElseIf Me.RadioButton12.Checked = True Then
            Param = "MyDate = " & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            If Me.Status.CheckState = CheckState.Checked Then
                Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} =  '1' and {Proc_MM_Inv_Bal;1.Balance}>00 and {Proc_MM_Inv_Bal;1.Status}"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmountSum.rpt"
            Else
                Filter = "{Proc_MM_Inv_Bal;1.Layer1ID} = '1' and {Proc_MM_Inv_Bal;1.Balance}>00"
                Path = "" & frmLoginVer.Reportpath & "\RptInvBalanceAmountSum.rpt"
            End If
        ElseIf Me.RadioButton14.Checked = True Then


            Filter = "{View_INV_Month_INOUT.MONTH} = " & Me.DateTimePicker1.Value.Month & " and {View_INV_Month_INOUT.YEAR} = " & Me.DateTimePicker1.Value.Year & ""
            Path = "" & frmLoginVer.Reportpath & "\rptInvMonthINOUT.rpt"


        End If
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        Me.GroupBox2.Visible = True

        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = True

        Me.CodeComboBox.Enabled = True
        Me.CodeComboBox1.Enabled = True

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.GroupBox2.Visible = True

        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = True

        Me.CodeComboBox.Enabled = True
        Me.CodeComboBox1.Enabled = True

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True

        Me.L4NameComboBox.Enabled = False
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
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

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Me.GroupBox2.Enabled = True

        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged

        Me.GroupBox2.Visible = True

        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False


        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged

        Me.GroupBox2.Visible = True

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

        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        Me.GroupBox2.Enabled = True

        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = True

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        Me.GroupBox2.Enabled = True

        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged, RadioButton14.CheckedChanged
        Me.GroupBox2.Enabled = True

        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False

        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False

        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = False

        Me.L4NameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
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
End Class