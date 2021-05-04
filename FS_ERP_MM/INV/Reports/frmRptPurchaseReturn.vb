Public Class frmRptPurchaseReturn
    Private Sub frmRptPurchaseReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DsDailyTran.tbl_Inv_Supplier)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DsDailyTran.tbl_Inv_L4)
    End Sub
    Sub ShowContents(ByVal Sup As Boolean, ByVal L4 As Boolean, ByVal Dt As Boolean)
        Me.SupplierNameComboBox.Enabled = Sup
        Me.L4NameComboBox.Enabled = L4
        Me.DTPicker1.Enabled = Dt
        Me.DTPicker2.Enabled = Dt
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ShowContents(True, False, False)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ShowContents(False, True, False)
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        ShowContents(False, False, True)
    End Sub
    Private Sub btnNewRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRpt.Click
        Dim Filter As String = Nothing
        Dim objRptViewer As New Class_Utility
        Dim Path As String = "\\server\myreports$\FSERPMM\Inventory\New\Rptinvout.rpt"
        If RadioButton1.Checked = True Then
            Filter = "{tbl_Inv_Supplier.SupplierID} = " & Me.SupplierNameComboBox.SelectedValue & " And {tbl_Inv_Tran_Out.TranType} in ['MRGP', 'PRGP']"
        ElseIf RadioButton2.Checked = True Then
            Filter = "{tbl_Inv_L4.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And {tbl_Inv_Tran_Out.TranType} in ['MRGP', 'PRGP']"
        ElseIf RadioButton3.Checked = True Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And {tbl_Inv_Tran_Out.TranType} in ['MRGP', 'PRGP']"
        ElseIf RadioButton4.Checked = True Then
            Filter = "{tbl_Inv_Supplier.SupplierID} = " & Me.SupplierNameComboBox.SelectedValue & " And {tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And {tbl_Inv_Tran_Out.TranType} in ['MRGP', 'PRGP']"
        ElseIf RadioButton5.Checked = True Then
            Filter = "{tbl_Inv_Supplier.SupplierID}  = " & Me.SupplierNameComboBox.SelectedValue & " And {tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And {tbl_Inv_Tran_Out.TranType} in ['MRGP', 'PRGP'] And {tbl_Inv_L4.Code} = '" & Me.L4NameComboBox.SelectedValue & "'"
        End If
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        ShowContents(True, False, True)
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        ShowContents(True, True, True)
    End Sub
End Class