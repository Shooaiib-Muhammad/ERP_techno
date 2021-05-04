Public Class frmLockedUsers
    Private Sub frmLockedUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.View_Users_LoginedTableAdapter.Fill(Me.DSLockedUsers.View_Users_Logined)
    End Sub

    Private Sub View_Users_LoginedDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Users_LoginedDataGridView.CellContentClick
        If e.ColumnIndex = 9 Then
            Me.View_Users_LoginedTableAdapter.UpdateQuery(Now.Date, View_Users_LoginedDataGridView(6, e.RowIndex).Value)
            Me.View_Users_LoginedTableAdapter.Fill(Me.DSLockedUsers.View_Users_Logined)
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are You Sure, You want to Un-Lock All Users", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If dgResult = 6 Then
            For i As Int16 = 0 To Me.View_Users_LoginedDataGridView.RowCount - 1
                Me.View_Users_LoginedTableAdapter.UpdateQuery(Now.Date, View_Users_LoginedDataGridView(6, i).Value)

            Next
            Me.View_Users_LoginedTableAdapter.Fill(Me.DSLockedUsers.View_Users_Logined)
        End If

    End Sub
End Class