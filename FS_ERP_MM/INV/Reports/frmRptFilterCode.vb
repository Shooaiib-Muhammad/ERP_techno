Public Class frmRptFilterCode
    Private Sub frmRptFilterCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_L42TableAdapter.Fill(Me.DSRptCode.tbl_Inv_L42)
        Me.Tbl_Inv_L41TableAdapter.Fill(Me.DSRptCode.tbl_Inv_L41)
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSRptCode.tbl_Inv_L3)
        Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSRptCode.tbl_Inv_L2)
        Me.Tbl_Inv_L11TableAdapter.Fill(Me.DSRptCode.tbl_Inv_L11)
        Me.Tbl_Inv_L12TableAdapter.Fill(Me.DSRptCode.tbl_Inv_L12)
    End Sub
    Private Sub btnRptShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptShow.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objRptViewer As New Class_Utility
        Dim Param As String = ""
        If RadioButton1.Checked = True Then
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvCode.rpt"
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Inv_L1.Layer1ID} in '" & Me.Layer1IDComboBox.SelectedValue & "' to '" & Me.Layer1IDComboBox1.SelectedValue & "' AND {tbl_Inv_L4.Status} "
            Else
                Filter = "{tbl_Inv_L1.Layer1ID} in '" & Me.Layer1IDComboBox.SelectedValue & "' to '" & Me.Layer1IDComboBox1.SelectedValue & "'"
            End If
        ElseIf RadioButton2.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Inv_L1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' and {tbl_Inv_L2.Layer2ID} = '" & Me.L2NameComboBox.SelectedValue & "' AND {tbl_Inv_L4.Status}"
            Else
                Filter = "{tbl_Inv_L1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' and {tbl_Inv_L2.Layer2ID} = '" & Me.L2NameComboBox.SelectedValue & "'"
            End If
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvCode.rpt"
        ElseIf RadioButton3.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Inv_L1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' and {tbl_Inv_L2.Layer2ID} ='" & Me.L2NameComboBox.SelectedValue & "' and {tbl_Inv_L3.Layer3ID} ='" & Me.L3NameComboBox.SelectedValue & "' AND {tbl_Inv_L4.Status}"
            Else
                Filter = "{tbl_Inv_L1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' and {tbl_Inv_L2.Layer2ID} ='" & Me.L2NameComboBox.SelectedValue & "' and {tbl_Inv_L3.Layer3ID} ='" & Me.L3NameComboBox.SelectedValue & "'"
            End If
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvCode.rpt"
        ElseIf RadioButton4.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = "{tbl_Inv_L1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' and {tbl_Inv_L2.Layer2ID} ='" & Me.L2NameComboBox.SelectedValue & "' and {tbl_Inv_L3.Layer3ID} ='" & Me.L3NameComboBox.SelectedValue & "' and {tbl_Inv_L4.Layer4ID} in '" & Me.L4NameComboBox.SelectedValue & "' to '" & Me.L4NameComboBox1.SelectedValue & "'AND {tbl_Inv_L4.Status}"
            Else
                Filter = "{tbl_Inv_L1.Layer1ID} = '" & Me.Layer1IDComboBox.SelectedValue & "' and {tbl_Inv_L2.Layer2ID} ='" & Me.L2NameComboBox.SelectedValue & "' and {tbl_Inv_L3.Layer3ID} ='" & Me.L3NameComboBox.SelectedValue & "' and {tbl_Inv_L4.Layer4ID} in '" & Me.L4NameComboBox.SelectedValue & "' to '" & Me.L4NameComboBox1.SelectedValue & "'"
            End If
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvCode.rpt"
        ElseIf RadioButton5.Checked = True Then
            Filter = "{tbl_Inv_L4.Status}"
            Path = "\\server\myreports$\FSERPMM\Inventory\RptInvCode.rpt"
        End If
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Layer1IDComboBox.Enabled = True
            Layer1IDComboBox1.Enabled = True
        Else
            Layer1IDComboBox.Enabled = False
            Layer1IDComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Layer1IDComboBox.Enabled = True
            L2NameComboBox.Enabled = True
        Else
            Layer1IDComboBox.Enabled = False
            L2NameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Layer1IDComboBox.Enabled = True
            L2NameComboBox.Enabled = True
            L3NameComboBox.Enabled = True
        Else
            Layer1IDComboBox.Enabled = False
            L2NameComboBox.Enabled = False
            L3NameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Layer1IDComboBox.Enabled = True
            L2NameComboBox.Enabled = True
            L3NameComboBox.Enabled = True
            L4NameComboBox.Enabled = True
            L4NameComboBox1.Enabled = True
        Else
            Layer1IDComboBox.Enabled = False
            L2NameComboBox.Enabled = False
            L3NameComboBox.Enabled = False
            L4NameComboBox.Enabled = False
            L4NameComboBox1.Enabled = False
        End If
    End Sub
End Class