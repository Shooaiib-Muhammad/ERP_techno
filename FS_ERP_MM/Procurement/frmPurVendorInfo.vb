Public Class frmPurVendorInfo

    Private Sub Tbl_PUR_Vendor_InfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_PUR_Vendor_InfoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_PUR_Vendor_InfoBindingSource.EndEdit()
            Me.Tbl_PUR_Vendor_InfoTableAdapter.Update(Me.DSVendorInfo.tbl_PUR_Vendor_Info)
            Me.Tbl_PUR_Vendor_InfoTableAdapter.Fill(Me.DSVendorInfo.tbl_PUR_Vendor_Info)
            Me.Tbl_PUR_Vendor_InfoBindingSource.MoveLast()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmPurVendorInfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.S And e.Control) Then
            'SaveDemand()
            Try
                Me.Validate()
                Me.Tbl_PUR_Vendor_InfoBindingSource.EndEdit()
                Me.Tbl_PUR_Vendor_InfoTableAdapter.Update(Me.DSVendorInfo.tbl_PUR_Vendor_Info)
                Me.Tbl_PUR_Vendor_InfoTableAdapter.Fill(Me.DSVendorInfo.tbl_PUR_Vendor_Info)
                Me.Tbl_PUR_Vendor_InfoBindingSource.MoveLast()
                MsgBox("Record Saved Successfully")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'MsgBox("Record Saved")
        End If
    End Sub

    Private Sub frmPurVendorInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSVendorInfo.tbl_PUR_Vendor_Info' table. You can move, or remove it, as needed.
        Me.Tbl_PUR_Vendor_InfoTableAdapter.Fill(Me.DSVendorInfo.tbl_PUR_Vendor_Info)
        KeyPreview = True
    End Sub

    Private Sub Tbl_PUR_Vendor_InfoDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_PUR_Vendor_InfoDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_PUR_Vendor_InfoDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_PUR_Vendor_InfoDataGridView.DataError

    End Sub
End Class