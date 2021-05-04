Public Class FrmuserDept


    Private Sub FrmuserDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUM.View_user_Dept' table. You can move, or remove it, as needed.
        Try
            Me.View_user_DeptTableAdapter.Fill(Me.DSUM.View_user_Dept)
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DSUM.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSUM.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSUM.tbl_User_Logins' table. You can move, or remove it, as needed.
        Me.Tbl_User_LoginsTableAdapter.Fill(Me.DSUM.tbl_User_Logins)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Status As Boolean
        If CheckBox1.Checked = True Then
            Status = True
        Else
            Status = False
        End If

        Try
            Tbl_User_LoginsTableAdapter.UpdateQuery(CustNameComboBox.SelectedValue, Status, LoginNameComboBox.SelectedValue)
            MsgBox("User Assign Successfuly")

            Me.View_user_DeptTableAdapter.Fill(Me.DSUM.View_user_Dept)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub View_user_DeptDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_user_DeptDataGridView.CellContentClick

    End Sub

    Private Sub View_user_DeptDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_user_DeptDataGridView.DataError

    End Sub
End Class