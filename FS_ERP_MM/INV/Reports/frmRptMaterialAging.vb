Public Class frmRptMaterialAging
    Private Sub frmRptMaterialAging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_L42TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L42)
        Me.Tbl_Inv_L41TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L41)
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L3)
        Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L2)
        Me.Tbl_Inv_L1TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L1)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.Layer1IDComboBox.Enabled = False
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False
        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = False
        Me.Layer3IDComboBox.Enabled = False
        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = False
        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = True
        Me.CodeComboBox.Enabled = False
        Me.CodeComboBox1.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.Layer1IDComboBox.Enabled = True
        Me.Layer2IDComboBox.Enabled = True
        Me.Layer3IDComboBox.Enabled = True
        Me.CodeComboBox.Enabled = True
        Me.CodeComboBox1.Enabled = True
    End Sub

    Private Sub btnShowRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRpt.Click
        Dim Filter As String = ""
        Dim objRptViewer As New Class_Utility
        Dim Path As String = "\\server\MyReports$\FSERPMM\Inventory\RptMatAgingBalance.rpt"
        Dim Param As String = "@TargetDate=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
        If RadioButton2.Checked = True Then
            If CheckBox1.Checked = True Then
                Filter = "{tbl_Inv_L4.Status}"
            ElseIf CheckBox1.Checked = False Then
                Filter = "not {tbl_Inv_L4.Status}"
            End If
        ElseIf RadioButton6.Checked = True Then
            If CheckBox1.Checked = True Then
                Filter = "{tbl_Inv_L4.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {tbl_Inv_L4.Status}"
            ElseIf CheckBox1.Checked = False Then
                Filter = "{tbl_Inv_L4.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And not {tbl_Inv_L4.Status}"
            End If
        ElseIf RadioButton9.Checked = True Then
            If CheckBox1.Checked = True Then
                Filter = "{tbl_Inv_L4.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {tbl_Inv_L4.Layer2ID}  = '" & Me.Layer2IDComboBox.SelectedValue & "'And {tbl_Inv_L4.Status}"
            ElseIf CheckBox1.Checked = False Then
                Filter = "{tbl_Inv_L4.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {tbl_Inv_L4.Layer2ID}  = '" & Me.Layer2IDComboBox.SelectedValue & "'And not {tbl_Inv_L4.Status}"
            End If
        ElseIf RadioButton10.Checked = True Then
            If CheckBox1.Checked = True Then
                Filter = "{tbl_Inv_L4.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {tbl_Inv_L4.Layer2ID}  = '" & Me.Layer2IDComboBox.SelectedValue & "' And {tbl_Inv_L4.Layer3ID}  = '" & Me.Layer3IDComboBox.SelectedValue & "'And {tbl_Inv_L4.Status}"
            ElseIf CheckBox1.Checked = False Then
                Filter = "{tbl_Inv_L4.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "'And {tbl_Inv_L4.Layer2ID}  = '" & Me.Layer2IDComboBox.SelectedValue & "' And {tbl_Inv_L4.Layer3ID}  = '" & Me.Layer3IDComboBox.SelectedValue & "'And not {tbl_Inv_L4.Status}"
            End If
        ElseIf RadioButton1.Checked = True Then
            If CheckBox1.Checked = True Then
                Filter = "{tbl_Inv_L4.Code}  in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "'And {tbl_Inv_L4.Status}"
            ElseIf CheckBox1.Checked = False Then
                Filter = "{tbl_Inv_L4.Code}  in '" & Me.CodeComboBox.SelectedValue & "' to '" & Me.CodeComboBox1.SelectedValue & "'And not {tbl_Inv_L4.Status}"
            End If
        End If
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub
End Class