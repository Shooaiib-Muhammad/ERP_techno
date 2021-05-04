Public Class IDMS_User_Dept
    Private Sub Tbl_PIR_UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_PIR_UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSUL)

    End Sub

    Private Sub IDMS_User_Dept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUL.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSUL.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSUL.tbl_idms_user_dept' table. You can move, or remove it, as needed.
        Me.Tbl_idms_user_deptTableAdapter.Fill(Me.DSUL.tbl_idms_user_dept)
        'TODO: This line of code loads data into the 'DSUL.tbl_PIR_Users' table. You can move, or remove it, as needed.
        Me.Tbl_PIR_UsersTableAdapter.Fill(Me.DSUL.tbl_PIR_Users)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.Tbl_PIR_UsersBindingSource.EndEdit()
            Me.Tbl_idms_user_deptTableAdapter.Update(Me.DSUL.tbl_idms_user_dept)
            Me.Tbl_idms_user_deptTableAdapter.Fill(Me.DSUL.tbl_idms_user_dept)
            MsgBox("Data Saved")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_IDMS_Sub_deptDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_IDMS_Sub_deptDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_IDMS_Sub_deptDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_IDMS_Sub_deptDataGridView.DataError

    End Sub

    Private Sub Tbl_IDMS_Sub_deptDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_IDMS_Sub_deptDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub
End Class