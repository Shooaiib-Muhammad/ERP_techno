Public Class frmGPVerify
    Dim Filter As String = ""
    Dim Path As String = ""
    Dim parameter As String = ""
    Dim objRptViewer As New Class_Utility
    Private Sub frmGPVerify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Private Sub ShowData()
        GpStatus()
        If ComboBox1.Text = "OUTWARD" Then
            Me.View_GatePassDataGridView.Columns(13).Visible = False

            Me.View_GatePassDataGridView.Columns(15).Visible = True
            Me.View_GatePassDataGridView.Columns(16).Visible = True
            Me.View_GatePassDataGridView.Columns(17).Visible = False
            Me.View_GatePassDataGridView.Columns(18).Visible = False
            Me.View_GatePassDataGridView.Columns(20).Visible = False
        ElseIf ComboBox1.Text = "RETURNABLE" Then
            If frmLoginVer.UserID = 2 Or frmLoginVer.UserID = 114 Or frmLoginVer.UserID = 90 Then
                Me.View_GatePassDataGridView.Columns(20).Visible = True
            Else
                Me.View_GatePassDataGridView.Columns(20).Visible = False
            End If
            Me.View_GatePassDataGridView.Columns(13).Visible = True
            Me.View_GatePassDataGridView.Columns(15).Visible = True
            Me.View_GatePassDataGridView.Columns(16).Visible = True
            Me.View_GatePassDataGridView.Columns(17).Visible = True
            Me.View_GatePassDataGridView.Columns(18).Visible = True
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        ShowData()
    End Sub
    Private Sub GpStatus()
        If RadioButton1.Checked = True Then
            Try
                Me.View_GatePass_NewTableAdapter.FillBy(Me.DSLocalPur.View_GatePass_New, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text, Me.ComboBox1.Text)
            Catch ex As Exception
            End Try
        ElseIf RadioButton2.Checked = True Then
            Try
                Me.View_GatePass_NewTableAdapter.FillBy1(Me.DSLocalPur.View_GatePass_New, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text, Me.ComboBox1.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub View_GatePassDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_GatePassDataGridView.CellContentClick

        If e.ColumnIndex = 15 Then
            If Me.View_GatePassDataGridView.Item(15, e.RowIndex).Value Is DBNull.Value Then
                Me.View_GatePassDataGridView.Item(15, e.RowIndex).Value = True
                Me.View_GatePassDataGridView.Item(16, e.RowIndex).Value = Now
            End If
        End If

        If e.ColumnIndex = 17 Then
            If Me.View_GatePassDataGridView.Item(17, e.RowIndex).Value = False Then
                Me.View_GatePassDataGridView.Item(17, e.RowIndex).Value = True
                Me.View_GatePassDataGridView.Item(18, e.RowIndex).Value = Now

            End If
        End If


        If e.ColumnIndex = 12 Then
            If Me.View_GatePassDataGridView.Item(12, e.RowIndex).Value Is DBNull.Value Then
                Me.View_GatePassDataGridView.Item(12, e.RowIndex).Value = True
                Me.View_GatePassDataGridView.Item(13, e.RowIndex).Value = Now
            Else
                If Me.View_GatePassDataGridView.Item(12, e.RowIndex).Value = False Then
                    Me.View_GatePassDataGridView.Item(12, e.RowIndex).Value = True
                    Me.View_GatePassDataGridView.Item(13, e.RowIndex).Value = Now
                Else
                    Me.View_GatePassDataGridView.Item(12, e.RowIndex).Value = False
                    Me.View_GatePassDataGridView.Item(13, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
        If e.ColumnIndex = 22 Then 'Save And  Print

            Path = "\\server\MyReports$\FSERPMM\GatePass\RptGatePass_new.rpt"
            Filter = "{View_Mat_SalesDetails.CancelationStatus} = 'Active' And {View_Mat_SalesDetails.GPNo} = " & Me.View_GatePassDataGridView.Item(1, e.RowIndex).Value & ""
            objRptViewer.LoadReports(Path, Filter, parameter)




        End If
    End Sub

    Private Sub View_GatePassDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_GatePassDataGridView.DataError

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        ShowData()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ShowData()
    End Sub

    Private Sub View_GatePassBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View_GatePassBindingNavigatorSaveItem.Click
        Try
            Me.ValidateChildren()
            Me.View_GatePass_NewBindingSource.EndEdit()
            Me.View_GatePass_NewTableAdapter.Update(Me.DSLocalPur.View_GatePass_New)
            ShowData()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GpStatus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        GpStatus()
    End Sub
End Class