Public Class frmDailyJALAEntry

    Private Sub frmDailyJALAEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then    'Ctrl+S For Save
            SaveRecord()
        End If
    End Sub
    Private Sub SaveRecord()
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_Jala_EntryBindingSource.EndEdit()
            Me.Tbl_Inv_Jala_EntryTableAdapter.Update(Me.DSJalaEntry.tbl_Inv_Jala_Entry)
            Me.Tbl_Inv_Jala_EntryTableAdapter.Fill(Me.DSJalaEntry.tbl_Inv_Jala_Entry)
            Me.Tbl_Inv_Jala_EntryBindingSource.MoveLast()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmDailyJALAEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSJalaEntry.tbl_Inv_Jala_Entry' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Jala_EntryTableAdapter.Fill(Me.DSJalaEntry.tbl_Inv_Jala_Entry)
        'TODO: This line of code loads data into the 'DSJalaEntry.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSJalaEntry.tbl_Inv_Tran_Date)
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        KeyPreview = True
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveRecord()
        'Try
        '    Me.ValidateChildren()
        '    Me.Tbl_Inv_Jala_EntryBindingSource.EndEdit()
        '    Me.Tbl_Inv_Jala_EntryTableAdapter.Update(Me.DSJalaEntry.tbl_Inv_Jala_Entry)
        '    Me.Tbl_Inv_Jala_EntryTableAdapter.Fill(Me.DSJalaEntry.tbl_Inv_Jala_Entry)
        '    Me.Tbl_Inv_Jala_EntryBindingSource.MoveLast()
        '    MsgBox("Record Saved Successfully")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_Inv_Tran_DateBindingSource.RemoveFilter()
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub
    Private Sub ReqDateTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ReqDateTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.Tbl_Inv_Tran_DateBindingSource.Filter = "DateName ='" & Me.ReqDateTextBox.Text & "'"
                Me.ReqDateTextBox.Clear()
                Me.CMReqDate.Hide()
            End If
        Catch ex As Exception
            MsgBox("Enter Date In Correct Formate")
            Me.ReqDateTextBox.Clear()
            Me.ReqDateTextBox.Focus()
        End Try
    End Sub
    Private Sub Tbl_Inv_Jala_EntryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Jala_EntryDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Jala_EntryDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Jala_EntryDataGridView.DataError

    End Sub

    Private Sub ReqDateTextBox_Click(sender As Object, e As EventArgs) Handles ReqDateTextBox.Click

    End Sub
End Class