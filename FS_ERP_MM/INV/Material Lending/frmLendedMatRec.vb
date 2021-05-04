Public Class frmLendedMatRec
    Private Sub frmMat_Lended_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSMat_Brow.tbl_Inv_Rack_Info)
        Catch ex As Exception

        End Try
        Try
            Me.View_Lended_DTableAdapter.FillBy(Me.DSM_Lending.View_Lended_D, Me.L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
        Me.View_Lended_MTableAdapter.Fill(Me.DSM_Lending.View_Lended_M)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSM_Lending.tbl_Inv_Tran_Date, CType(Now.Date, Date))
        Catch ex As System.Exception
        End Try
        Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSM_Lending.tbl_Inv_Tran_In, Me.DayNoLabel2.Text)
        Me.Tbl_Inv_Tran_InBindingSource.MoveLast()
        If Me.DateNameLabel1.Text = Nothing Then
            ShowButtons(False, False)
        Else
            If Me.Tbl_Inv_Tran_InBindingSource.Count > 0 Then
                ShowButtons(True, True)
            Else
                ShowButtons(True, False)
            End If
        End If
    End Sub
    Sub ShowButtons(ByVal Add As Boolean, ByVal Delete As Boolean)
        AddIn.Visible = Add
        DeleteIn.Visible = Delete
        SaveIn.Visible = Delete
        UndoIn.Visible = Delete
        Me.L4NameComboBox.Enabled = Delete
    End Sub

    Private Sub View_Lended_MBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles View_Lended_MBindingSource.PositionChanged
        Try
            Me.View_Lended_DTableAdapter.FillBy(Me.DSM_Lending.View_Lended_D, L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub
    Dim Received, IssuedQty As Double
    Private Sub View_Lended_DDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Lended_DDataGridView.CellEnter
        If QtyTextBox.TextLength <= 0 Then
            Try
                Me.CPPULabel1.Text = Me.View_Lended_DDataGridView(3, e.RowIndex).Value
                Me.CurrencyLabel1.Text = Me.View_Lended_DDataGridView(8, e.RowIndex).Value
                Me.TranOutIDLabel2.Text = Me.View_Lended_DDataGridView(2, e.RowIndex).Value
                TrandocNoLabel1.Text = Me.View_Lended_DDataGridView(2, e.RowIndex).Value
                Me.UOMLabel1.Text = Me.View_Lended_DDataGridView(6, e.RowIndex).Value
                Me.ExCustIdLabel1.Text = Me.View_Lended_DDataGridView(11, e.RowIndex).Value
                Received = Me.View_Lended_DDataGridView(7, e.RowIndex).Value
                IssuedQty = Me.View_Lended_DDataGridView(4, e.RowIndex).Value
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub View_Lended_DDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_Lended_DDataGridView.DataError
    End Sub
    Private Sub AddIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddIn.Click
        Try
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
            Me.View_Lended_MTableAdapter.FillBy(Me.DSM_Lending.View_Lended_M)
        Catch ex As Exception
        End Try
        ShowButtons(True, True)
    End Sub
    Private Sub DeleteIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteIn.Click
        Dim position As Integer = Me.Tbl_Inv_Tran_InBindingSource.Position
        Dim btnMsg As DialogResult
        btnMsg = MessageBox.Show("Are You Sure Want To Delete It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Try
                Me.Tbl_Inv_Tran_InTableAdapter.DeleteQuery(Me.TranInIDLabel1.Text, Me.TranOutIDLabel2.Text)
                Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSM_Lending.tbl_Inv_Tran_In, Me.DayNoLabel2.Text)
                Me.View_Lended_DTableAdapter.FillBy(Me.DSM_Lending.View_Lended_D, Me.L4NameComboBox.SelectedValue)
            Catch ex As Exception
            End Try
        Else
            MsgBox("Record Not Deleted")
        End If
        Me.Tbl_Inv_Tran_InBindingSource.Position = position
        If TranInIDLabel1.Text = "" Then
            ShowButtons(True, False)
        Else
            ShowButtons(True, True)
        End If
    End Sub

    Private Sub SaveIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveIn.Click
        Dim positionOut As Integer = Me.Tbl_Inv_Tran_InBindingSource.Position
        Dim viewPosition As Integer = Me.View_Lended_DBindingSource.Position
        If QtyTextBox.TextLength > 0 Then
            If Received + Val(Me.QtyTextBox.Text) <= IssuedQty Then
                Try
                    Me.Validate()
                    Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
                    Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSM_Lending.tbl_Inv_Tran_In)
                    MsgBox("Record Saved")
                    Me.View_Lended_DTableAdapter.FillBy(Me.DSM_Lending.View_Lended_D, Me.L4NameComboBox.SelectedValue)
                    Me.View_Lended_DBindingSource.Position = viewPosition
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Dim btnMsg As DialogResult
                btnMsg = MessageBox.Show("Enter Quantity and Recieved Quantity is Greater than Order Quantity " & vbCrLf & "                Are You Sure Want To Save It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                If btnMsg = Windows.Forms.DialogResult.Yes Then
                    Try
                        Me.Validate()
                        Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
                        Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSM_Lending.tbl_Inv_Tran_In)
                        MsgBox("Record Saved")
                        Me.View_Lended_DTableAdapter.FillBy(Me.DSM_Lending.View_Lended_D, Me.L4NameComboBox.SelectedValue)
                        Me.View_Lended_DBindingSource.Position = viewPosition
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Me.QtyTextBox.Clear()
                    MsgBox("Record Not Saved")
                End If

            End If
        End If
        Me.Tbl_Inv_Tran_InBindingSource.Position = positionOut
    End Sub

    Private Sub UndoIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoIn.Click
        Try
            Me.View_Lended_MTableAdapter.Fill(Me.DSM_Lending.View_Lended_M)
            Me.Tbl_Inv_Tran_InBindingSource.CancelEdit()
            'Me.View_Lended_DTableAdapter.FillBy(Me.DSM_Lending.View_Lended_D, Me.L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
        If TranInIDLabel1.Text = "" Then
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

    Private Sub View_Lended_DDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Lended_DDataGridView.CellContentClick

    End Sub
End Class