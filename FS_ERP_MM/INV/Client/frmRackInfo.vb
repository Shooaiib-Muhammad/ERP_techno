Public Class frmRackInfo

    Private Sub Tbl_Inv_Rack_InfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Rack_InfoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Inv_Rack_InfoBindingSource.EndEdit()
            Me.Tbl_Inv_Rack_InfoTableAdapter.Update(Me.DSYM.tbl_Inv_Rack_Info)
            MsgBox("Rack No. Entered")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRackInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSYM.tbl_Inv_Rack_Info)
    End Sub

    Private Sub Tbl_Inv_Rack_InfoDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Rack_InfoDataGridView.CellEnter
        If e.ColumnIndex = 1 Then
            If Me.Tbl_Inv_Rack_InfoDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Inv_Rack_InfoDataGridView(0, e.RowIndex).Value = Me.Tbl_Inv_Rack_InfoDataGridView(0, e.RowIndex - 1).Value + 1
                    Me.Tbl_Inv_Rack_InfoDataGridView(2, e.RowIndex).Value = True
                Catch ex As Exception
                    Me.Tbl_Inv_Rack_InfoDataGridView(0, e.RowIndex).Value = 1
                    Me.Tbl_Inv_Rack_InfoDataGridView(2, e.RowIndex).Value = True
                End Try
            End If
        End If
    End Sub

    Private Sub Tbl_Inv_Rack_InfoDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Rack_InfoDataGridView.DataError

    End Sub
End Class