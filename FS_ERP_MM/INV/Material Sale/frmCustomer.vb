Public Class frmCustomer
    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmLoginVer.DeptID = 69 Or frmLoginVer.DeptID = 24 Then
            Me.Tbl_MM_CustomerTableAdapter.FillBy(Me.DsCust.tbl_MM_Customer)
            Me.CheckBox1.Visible = True
        Else
            Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DsCust.tbl_MM_Customer)
            Me.CheckBox1.Visible = False
        End If

    End Sub
    Private Sub Tbl_MM_CustomerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_MM_CustomerBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_MM_CustomerBindingSource.EndEdit()
            Me.Tbl_MM_CustomerTableAdapter.Update(Me.DsCust.tbl_MM_Customer)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CustomerTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerTextBox.GotFocus
        If Me.CustomerTextBox.Text = "Enter Customer Name" Then
            Me.CustomerTextBox.Text = ""
            Me.CustomerTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CustomerTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustomerTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_MM_CustomerBindingSource.Filter = "CompanyName like'%" & Me.CustomerTextBox.Text & "%'"
            Me.CustomerTextBox.Clear()
            Me.CustomerContextMenuStrip.Hide()
        End If
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_MM_CustomerBindingSource.RemoveFilter()
        Me.CustomerTextBox.Text = "Enter Customer Name"
        Me.CustomerTextBox.ForeColor = Color.Silver
    End Sub

    Private Sub AscendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tbl_MM_CustomerBindingSource.Sort = "CompanyName ASC"
    End Sub

    Private Sub DescendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tbl_MM_CustomerBindingSource.Sort = "CompanyName DESC"
    End Sub

    Private Sub RemoveOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tbl_MM_CustomerBindingSource.RemoveSort()
    End Sub

    Private Sub CustomerTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerTextBox.LostFocus
        If Me.CustomerTextBox.TextLength = 0 Then
            Me.CustomerTextBox.Text = "Enter Customer Name"
            Me.CustomerTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Tbl_MM_CustomerBindingSource.Filter = "Status=1"
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_MM_CustomerBindingSource.Filter = "Status IS NULL OR Status=0 "
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Tbl_MM_CustomerBindingSource.RemoveFilter()
    End Sub
End Class