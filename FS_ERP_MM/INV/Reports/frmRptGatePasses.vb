Public Class frmRptGatePasses
    Private Sub frmRptGatePasses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_Tran_Out1TableAdapter.Fill(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
        Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            VehicleTextBox1.Clear()
            Me.DriverNameTextBox2.Clear()
            Try
                Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Catch ex As Exception

            End Try
            Try
                Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
            Catch ex As Exception

            End Try


        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            VehicleTextBox1.Clear()
            Me.DriverNameTextBox2.Clear()
            Try
                Me.Tbl_Inv_Tran_Out1TableAdapter.Fill(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
                Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            VehicleTextBox1.Clear()
            Me.DriverNameTextBox2.Clear()
            Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy1(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy1(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            VehicleTextBox1.Clear()
            Me.DriverNameTextBox2.Clear()
            Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy2(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy2(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            VehicleTextBox1.Clear()
            Me.DriverNameTextBox2.Clear()
            Try
                Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy3(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Catch ex As Exception
            End Try
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy3(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objRptViewer As New Class_Utility
        Dim Param As String = ""
        If RadioButton1.Checked = True Then
            Filter = "{View_MM_TransferPass.tranoutID} in " & Me.TranOutIDComboBox.SelectedValue & " to " & Me.TranOutIDComboBox1.SelectedValue & ""
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptMatTransfPass.rpt"
            Param = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & ""
        ElseIf RadioButton2.Checked = True Then
            Filter = "{View_Inv_PR_GP.TranOutID}in " & Me.TranOutIDComboBox.SelectedValue & " to " & Me.TranOutIDComboBox1.SelectedValue & ""
            Path = "\\Server\MyReports$\FSERPMM\Inventory\RptPurchaseReturnGatePass.rpt"
            Param = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & ""
        ElseIf RadioButton3.Checked = True Then
            Filter = " {View_Mat_OutwardGatePass.TranOutID}in " & Me.TranOutIDComboBox.SelectedValue & " to " & Me.TranOutIDComboBox1.SelectedValue & ""
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptMatOutwardGatePass.rpt"
            Param = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & " &Vehicle1=" & Me.VehicleTextBox1.Text & "&Driver1=" & Me.DriverNameTextBox2.Text & ""
        ElseIf RadioButton4.Checked = True Then
            Filter = "{View_Lended_MM_GP.Tranoutid} in " & Me.TranOutIDComboBox.SelectedValue & " to " & Me.TranOutIDComboBox1.SelectedValue & ""
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptLendedMatGatePass.rpt"
            Param = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & ""
        ElseIf RadioButton5.Checked = True Then
            Filter = "{View_Inv_MRGP.TranOutID}in " & Me.TranOutIDComboBox.SelectedValue & " to " & Me.TranOutIDComboBox1.SelectedValue & ""
            Path = "\\Server\MyReports$\FSERPMM\Inventory\RptMaterialReturnGatePass.rpt"
            Param = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & ""
        ElseIf RadioButton6.Checked = True Then
            Filter = "{View_Mat_Sale.TranOutID}in " & Me.TranOutIDComboBox.SelectedValue & " to " & Me.TranOutIDComboBox1.SelectedValue & ""
            Path = "\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptMatOutwardSaleGatePass.rpt"
            Param = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & ""
        ElseIf RadioButton7.Checked = True Then
            Filter = "{View_Borrowed_MMGP.TranOutID}in " & Me.TranOutIDComboBox.SelectedValue & " to " & Me.TranOutIDComboBox1.SelectedValue & ""
            Path = "\\Server\MyReports$\FSERPMM\Procurement\OtherMaterial\RptBorrowedMatGatePass.rpt"
            Param = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & ""

            'Dim Filter As String = "{View_Borrowed_MMGP.DayNo} = " & Val(DayNoLabel1.Text) & " AND {View_Borrowed_MMGP.TranOutID} = " & Val(TranOutIDLabel1.Text)
            'Obj.LoadReports("\\Server\MyReports$\FSERPMM\Procurement\OtherMaterial\RptBorrowedMatGatePass.rpt", Filter, "")
        End If
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub DateTimePicker1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.TextChanged
        If RadioButton1.Checked = True Then
            Try
                Me.Tbl_Inv_Tran_Out1TableAdapter.Fill(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
                Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
            Catch ex As Exception

            End Try
        ElseIf RadioButton2.Checked = True Then
            Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy1(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy1(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
        ElseIf RadioButton3.Checked = True Then
            Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
        ElseIf RadioButton4.Checked = True Then
            Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy3(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy3(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
        ElseIf RadioButton5.Checked = True Then
            Try
                Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy2(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Catch ex As Exception
            End Try
            Try
                Me.Tbl_Inv_Tran_OutTableAdapter.FillBy2(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
            Catch ex As Exception
            End Try
        ElseIf RadioButton6.Checked = True Then
            Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy4(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy4(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            VehicleTextBox1.Clear()
            Me.DriverNameTextBox2.Clear()
            Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy4(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy4(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            VehicleTextBox1.Clear()
            Me.DriverNameTextBox2.Clear()
            Me.Tbl_Inv_Tran_Out1TableAdapter.FillBy5(Me.DSRptGatePasses.tbl_Inv_Tran_Out1, Me.DateTimePicker1.Text)
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy5(Me.DSRptGatePasses.tbl_Inv_Tran_Out, Me.DateTimePicker1.Text)
        End If
    End Sub
End Class