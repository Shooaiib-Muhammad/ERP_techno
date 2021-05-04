Public Class frmRptRepairedBladders

    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSRptRepairBladers)

    End Sub

    Private Sub frmRptRepairedBladders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSWindedBladderIssuance.tbl_Winded_ExectName' table. You can move, or remove it, as needed.
        Me.Tbl_Winded_ExectNameTableAdapter.Fill(Me.DSWindedBladderIssuance.tbl_Winded_ExectName)
        'TODO: This line of code loads data into the 'DSRptRepairBladers.tbl_Bladder_Repair_Out1' table. You can move, or remove it, as needed.
        Me.Tbl_Bladder_Repair_Out1TableAdapter.Fill(Me.DSRptRepairBladers.tbl_Bladder_Repair_Out1)
        'TODO: This line of code loads data into the 'DSRptRepairBladers.tbl_Bladder_Repair_Out' table. You can move, or remove it, as needed.
        Me.Tbl_Bladder_Repair_OutTableAdapter.Fill(Me.DSRptRepairBladers.tbl_Bladder_Repair_Out)
        'TODO: This line of code loads data into the 'DSRptRepairBladers.tbl_Bladder_Winded_Process1' table. You can move, or remove it, as needed.
        Me.Tbl_Bladder_Winded_Process1TableAdapter.Fill(Me.DSRptRepairBladers.tbl_Bladder_Winded_Process1)
        'TODO: This line of code loads data into the 'DSRptRepairBladers.tbl_Bladder_Winded_Process' table. You can move, or remove it, as needed.
        Me.Tbl_Bladder_Winded_ProcessTableAdapter.Fill(Me.DSRptRepairBladers.tbl_Bladder_Winded_Process)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSRptRepairBladers.tbl_Inv_Tran_Date, CType(Now.Date.AddDays(-6), Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            Me.TranIdComboBox.Enabled = True
            Me.TranIdComboBox1.Enabled = True
            Me.TranOutIdComboBox.Enabled = False
            Me.TranOutIdComboBox1.Enabled = False
        ElseIf RadioButton2.Checked Then
            Me.TranIdComboBox.Enabled = False
            Me.TranIdComboBox1.Enabled = False
            Me.TranOutIdComboBox.Enabled = True
            Me.TranOutIdComboBox1.Enabled = True
        End If

    End Sub

    Private Sub btnShowRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRpt.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim obj As New Class_Utility
        Dim Param As String = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & ""
        If RadioButton1.Checked Then
            Path = "\\server\myreports$\FSERPMM\Bladders\RptBladderTransfPass.rpt"
            Filter = "{View_MM_TransferPass.TranOutID} in " & Me.TranIdComboBox.SelectedValue & " to " & Me.TranIdComboBox1.SelectedValue & ""
        ElseIf RadioButton2.Checked Then
            Path = "\\server\myreports$\FSERPMM\Bladders\RptPuncturedBladderTransfPass.rpt"
            Filter = "{View_MM_TransferPass.TranOutID} in " & Me.TranOutIdComboBox.SelectedValue & " to " & Me.TranOutIdComboBox1.SelectedValue & ""
        ElseIf RadioButton4.Checked Then
            Param = ""
            'Filter = "{View_Bladder_Billing_Transaction.ExeID} = " & Me.ExecuterNameComboBox.SelectedValue & " And {View_Bladder_Billing_Transaction.DateName}=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & ""
            Path = "\\server\myreports$\FSERPMM\Bladders\RptBldderSummary.rpt"
            Filter = "{View_Bladder_Rec_Daily.ExectID} = " & Me.ExecuterNameComboBox.SelectedValue & " And {View_Bladder_Rec_Daily.DayNo} = " & Me.DateNameComboBox.SelectedValue & ""
        End If
        obj.LoadReports(Path, Filter, Param)
    End Sub
End Class