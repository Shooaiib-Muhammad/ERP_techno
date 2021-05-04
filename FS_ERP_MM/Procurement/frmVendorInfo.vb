Public Class frmVendorInfo

    Private Sub Tbl_Vendor_InfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Vendor_InfoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Vendor_InfoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSSSGP)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmVendorInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSSSGP.tbl_Vendor_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Vendor_InfoTableAdapter.Fill(Me.DSSSGP.tbl_Vendor_Info)
    End Sub

    Private Sub Tbl_Vendor_InfoDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Vendor_InfoDataGridView.CellContentClick
       
    End Sub

    Private Sub Tbl_Vendor_InfoDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Vendor_InfoDataGridView.CellEnter
        If e.ColumnIndex = 2 Then
            If Tbl_Vendor_InfoDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Vendor_InfoDataGridView(2, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub Tbl_Vendor_InfoDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Vendor_InfoDataGridView.DataError

    End Sub
End Class