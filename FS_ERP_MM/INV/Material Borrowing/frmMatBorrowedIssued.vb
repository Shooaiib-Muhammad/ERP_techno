Public Class frmMatBorrowedIssued
    Private Sub frmMatBrowedIssued_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMat_Brow.tbl_Inv_Rack_Info' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSMat_Brow.tbl_Inv_Rack_Info)
        Catch ex As Exception

        End Try
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSMat_Brow.tbl_Inv_Tran_Date, CType(Now.Date, Date))
        Catch ex As System.Exception
        End Try
        Try
            Me.View_Browed_MatTableAdapter.Fill(Me.DSMat_Brow.View_Browed_Mat)
        Catch ex As Exception
        End Try
        Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSMat_Brow.tbl_Inv_Tran_Out)
        Try
            Me.View_BrowedMat_DTableAdapter.FillBy(Me.DSMat_Brow.View_BrowedMat_D, L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
        Me.Tbl_Inv_Tran_OutBindingSource.MoveLast()
        If Me.DateNameLabel1.Text = Nothing Then
            ShowButtons(False, False)
        Else
            If Me.Tbl_Inv_Tran_OutBindingSource.Count > 0 Then
                ShowButtons(True, True)
            Else
                ShowButtons(True, False)
            End If
        End If
    End Sub
    Sub ShowButtons(ByVal Add As Boolean, ByVal Delete As Boolean)
        AddOut.Visible = Add
        DeleteOut.Visible = Delete
        SaveOut.Visible = Delete
        UndoOut.Visible = Delete
        Me.L4NameComboBox.Enabled = Delete
    End Sub
    Dim IssuedQty, Received As Double
    Private Sub View_BrowedMat_DDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_BrowedMat_DDataGridView.CellEnter
        If QtyTextBox.TextLength <= 0 Then
            Me.TranInIDLabel2.Text = Me.View_BrowedMat_DDataGridView(1, e.RowIndex).Value
            Me.UOMLabel1.Text = Me.View_BrowedMat_DDataGridView(5, e.RowIndex).Value
            Try
                Me.CurrencyLabel1.Text = Me.View_BrowedMat_DDataGridView(2, e.RowIndex).Value
            Catch ex As Exception
            End Try
            Try
                Me.SupplierIDLabel1.Text = Me.View_BrowedMat_DDataGridView(8, e.RowIndex).Value
            Catch ex As Exception
            End Try
        End If
        Received = Me.View_BrowedMat_DDataGridView(3, e.RowIndex).Value
        IssuedQty = Me.View_BrowedMat_DDataGridView(6, e.RowIndex).Value
    End Sub
    Private Sub View_BrowedMat_DDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_BrowedMat_DDataGridView.DataError
    End Sub
    Private Sub View_Browed_MatBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles View_Browed_MatBindingSource.PositionChanged
        Try
            Me.View_BrowedMat_DTableAdapter.FillBy(Me.DSMat_Brow.View_BrowedMat_D, L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnGatePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGatePass.Click
        Dim Obj As New Class_Utility
        Dim Filter As String = "{View_Borrowed_MMGP.DayNo} = " & Val(DayNoLabel1.Text) & " AND {View_Borrowed_MMGP.TranOutID} = " & Val(TranOutIDLabel1.Text)
        Obj.LoadReports("\\Server\MyReports$\FSERPMM\Procurement\OtherMaterial\RptBorrowedMatGatePass.rpt", Filter, "")
    End Sub
    Private Sub AddOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOut.Click
        Try
            Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
            Me.View_Browed_MatTableAdapter.FillBy(Me.DSMat_Brow.View_Browed_Mat)
            Me.TranDocNoLabel1.Text = Val(Me.TranOutIDLabel1.Text)
        Catch ex As Exception
        End Try
        ShowButtons(True, True)
    End Sub
    Private Sub DeleteOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteOut.Click
        Dim Position As Integer = Me.Tbl_Inv_Tran_OutBindingSource.Position
        Dim btnMsg As DialogResult
        btnMsg = MessageBox.Show("Are You Sure Want To Delete It?..........", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Try
                Me.Tbl_Inv_Tran_OutTableAdapter.DeleteQuery(Me.TranOutIDLabel1.Text, TranInIDLabel2.Text)
                Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSMat_Brow.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
                Me.View_BrowedMat_DTableAdapter.FillBy(Me.DSMat_Brow.View_BrowedMat_D, L4NameComboBox.SelectedValue)
            Catch ex As Exception
            End Try
        Else
            MsgBox("Record Not Deleted")
        End If
        Me.Tbl_Inv_Tran_OutBindingSource.Position = Position
        If TranOutIDLabel1.Text = "" Then
            ShowButtons(True, False)
        Else
            ShowButtons(True, True)
        End If
    End Sub
    Sub Save(ByVal QtyValue As Double)
        Dim PositionOut As Integer = Me.Tbl_Inv_Tran_OutBindingSource.Position
        Dim ViewPosition As Integer = Me.View_BrowedMat_DBindingSource.Position
        If QtyTextBox.TextLength > 0 Then
            If IssuedQty + QtyValue <= Received Then
                Try
                    Me.Validate()
                    Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
                    Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSMat_Brow.tbl_Inv_Tran_Out)
                    Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSMat_Brow.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
                    Me.Tbl_Inv_Tran_OutBindingSource.Position = PositionOut
                    'To Update TrandocNo.
                    Me.Tbl_Inv_Tran_OutTableAdapter.UpdateQuery(Val(Me.TranOutIDLabel1.Text))
                    MsgBox("Borrowed Material Issued", MsgBoxStyle.Information)
                    Me.View_BrowedMat_DTableAdapter.FillBy(Me.DSMat_Brow.View_BrowedMat_D, Me.L4NameComboBox.SelectedValue)
                    Me.View_BrowedMat_DBindingSource.Position = ViewPosition
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Dim btnMsg As DialogResult
                btnMsg = MessageBox.Show("Entered Quantity is Greater Than Borrowed Material Balance Quantity " & vbCrLf & " Are You Sure Want To Issue It?.....", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If btnMsg = Windows.Forms.DialogResult.Yes Then
                    Try
                        Me.Validate()
                        Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
                        Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSMat_Brow.tbl_Inv_Tran_Out)
                        Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSMat_Brow.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
                        Me.Tbl_Inv_Tran_OutBindingSource.Position = PositionOut
                        'To Update TrandocNo.
                        Me.Tbl_Inv_Tran_OutTableAdapter.UpdateQuery(Val(Me.TranOutIDLabel1.Text))
                        MsgBox("Borrowed Material Issued", MsgBoxStyle.Information)
                        Me.View_BrowedMat_DTableAdapter.FillBy(Me.DSMat_Brow.View_BrowedMat_D, Me.L4NameComboBox.SelectedValue)
                        Me.View_BrowedMat_DBindingSource.Position = ViewPosition
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Me.QtyTextBox.Clear()
                    MsgBox("Record Not Saved")
                End If
            End If
        End If
        Me.Tbl_Inv_Tran_OutBindingSource.Position = PositionOut
    End Sub
    Private Sub SaveOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveOut.Click
        Dim MatBalance As Double = Me.View_Inv_Mat_AvailableTableAdapter.ScalarQuery(Me.L4NameComboBox.SelectedValue)
        If MatBalance > 0 Then
            If Val(QtyTextBox.Text) <= MatBalance Then
                Save(QtyTextBox.Text)
            Else
                MsgBox("Entered Quantity Is Greater Than Available Material Balance", MsgBoxStyle.Information)
                QtyTextBox.Text = MatBalance
                Save(MatBalance)
            End If
        Else

            MsgBox("Available Material Is Nill", MsgBoxStyle.Critical)
            QtyTextBox.Clear()
            UndoOut_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub UndoOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoOut.Click
        Try
            Me.View_Browed_MatTableAdapter.Fill(Me.DSMat_Brow.View_Browed_Mat)
            Me.Tbl_Inv_Tran_OutBindingSource.CancelEdit()
        Catch ex As Exception
        End Try
        If TranOutIDLabel1.Text = "" Then
            ShowButtons(True, False)
        Else
            ShowButtons(True, True)
        End If
    End Sub
    Private Sub QtyTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtyTextBox.TextChanged
        If QtyTextBox.TextLength > 0 Then
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.Simple
        Else
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub
End Class