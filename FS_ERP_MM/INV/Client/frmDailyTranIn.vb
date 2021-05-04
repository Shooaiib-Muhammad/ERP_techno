Public Class frmDailyTranIn
    Dim Type As String
    Private Sub frmNewTranIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSNewTranIn.tbl_Makers' table. You can move, or remove it, as needed.
        Me.Tbl_MakersTableAdapter.Fill(Me.DSNewTranIn.tbl_Makers)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSNewTranIn.tbl_Inv_Tran_Date, CType(Now.Date.AddDays(-8), Date))
        Catch ex As System.Exception
        End Try
        If frmLoginVer.DeptID = 24 Then
            Me.Tbl_Inv_L4TableAdapter.FillBy1(Me.DSNewTranIn.tbl_Inv_L4)
            Type = "AGrade"
            Try
                Me.Tbl_Inv_Tran_InTableAdapter.FillBy3(Me.DSNewTranIn.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try
            Try
                Me.Tbl_Inv_Tran_InTableAdapter.FillBy3(Me.DSNewTranIn.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try
        Else
            Me.Tbl_Inv_L4TableAdapter.FillBy1(Me.DSNewTranIn.tbl_Inv_L4)
            Type = "AGrade"
            Try
                Me.Tbl_Inv_Tran_InTableAdapter.FillBy2(Me.DSNewTranIn.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try
        End If

        'Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSMat_Brow.tbl_Inv_Rack_Info)
        Me.Tbl_Inv_SupplierTableAdapter.FillBy(Me.DSNewTranIn.tbl_Inv_Supplier)


        'Me.Tbl_Inv_Tran_InBindingSource.Filter = "TranType='MBRN'"
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub
    Sub Save()
        Me.Validate()
        Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
        Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSNewTranIn.tbl_Inv_Tran_In)
    End Sub
    Dim Deleteflag As Boolean = False
    Sub SaveRecord()
        If Deleteflag = False Then
            Save()
            MsgBox("Record Saved Successfully", MsgBoxStyle.OkOnly)
            Me.Tbl_Inv_Tran_InTableAdapter.FillBy2(Me.DSNewTranIn.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
        Else
            Save()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.OkOnly)
            Me.Tbl_Inv_Tran_InTableAdapter.FillBy2(Me.DSNewTranIn.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
            Deleteflag = False
        End If
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveRecord()
    End Sub
    Private Sub Tbl_Inv_Tran_InDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellEnter
        If Tbl_Inv_Tran_InDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
            Me.Tbl_Inv_Tran_InDataGridView(1, e.RowIndex).Value = Type
        End If
        If e.ColumnIndex = 7 Then
            If Me.CPPULabel1.Text = Nothing Then
                CPPULabel1.Text = 0
            End If
            Me.Tbl_Inv_Tran_InDataGridView(4, e.RowIndex).Value = Me.CPPULabel1.Text
            Me.Tbl_Inv_Tran_InDataGridView(6, e.RowIndex).Value = Me.CurrencyLabel1.Text
            Me.Tbl_Inv_Tran_InDataGridView(7, e.RowIndex).Value = Me.UnitLabel1.Text
        End If
        If e.ColumnIndex = 9 Then
            If Me.Tbl_Inv_Tran_InDataGridView(8, e.RowIndex).Value IsNot DBNull.Value And Me.Tbl_Inv_Tran_InDataGridView(9, e.RowIndex).Value Is DBNull.Value Then
                If Me.Tbl_Inv_Tran_InDataGridView(8, e.RowIndex).Value = "Normal" Then
                    Me.Tbl_Inv_Tran_InDataGridView(9, e.RowIndex).Value = 0
                ElseIf Me.Tbl_Inv_Tran_InDataGridView(8, e.RowIndex).Value = "MS" Then
                    Me.Tbl_Inv_Tran_InDataGridView(9, e.RowIndex).Value = 15
                ElseIf Me.Tbl_Inv_Tran_InDataGridView(8, e.RowIndex).Value = "AMB" Then
                    Me.Tbl_Inv_Tran_InDataGridView(9, e.RowIndex).Value = 5
                ElseIf Me.Tbl_Inv_Tran_InDataGridView(8, e.RowIndex).Value = "AMB Printing" Then
                    Me.Tbl_Inv_Tran_InDataGridView(9, e.RowIndex).Value = 0.83
                    'Me.Tbl_Inv_Tran_InDataGridView(14, e.RowIndex).Value = 6
                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Tran_InDataGridView.DataError

    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Deleteflag = True
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Tran_InDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub Tbl_Inv_Tran_InDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 9 Then
                SaveRecord()
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_InDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_InDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        If frmLoginVer.DeptID = 24 Then
            Try
                Me.Tbl_Inv_Tran_InTableAdapter.FillBy3(Me.DSNewTranIn.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try
        Else
            Try
                Me.Tbl_Inv_Tran_InTableAdapter.FillBy2(Me.DSNewTranIn.tbl_Inv_Tran_In, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try
        End If

    End Sub
End Class