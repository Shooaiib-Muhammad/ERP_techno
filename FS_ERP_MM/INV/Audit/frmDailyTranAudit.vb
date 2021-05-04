Public Class frmDailyTranAudit
    Private Sub frmDailyTranAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSInWard.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSInWard.tbl_Pur_UnitOfMeasurement)
        'TODO: This line of code loads data into the 'DSInWard.View_Inv_Tran_OUT_Audit' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSInWard.View_INV_Tran_IN' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSInWard.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DSInWard.tbl_Inv_Tran_Date, Now.Date.AddDays(-90))
        Try
            Me.View_INV_Tran_INTableAdapter.FillBy(Me.DSInWard.View_INV_Tran_IN, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadRecord()
        Try
            Me.View_Inv_Tran_OUT_AuditTableAdapter.FillBy(Me.DSInWard.View_Inv_Tran_OUT_Audit, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try
        Try
            Me.View_INV_Tran_INTableAdapter.FillBy(Me.DSInWard.View_INV_Tran_IN, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSInWard)

    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        LoadRecord()
    End Sub

    Private Sub SuplierNameTextBox_Click(sender As Object, e As EventArgs) Handles SuplierNameTextBox.Click

    End Sub
    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedTab.Text = "Inward" Then
            Try
                Me.View_INV_Tran_INTableAdapter.FillBy(Me.DSInWard.View_INV_Tran_IN, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try

        ElseIf TabControl1.SelectedTab.Text = "Outward" Then
            Try
                Me.View_Inv_Tran_OUT_AuditTableAdapter.FillBy(Me.DSInWard.View_Inv_Tran_OUT_Audit, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub SuplierNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SuplierNameTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.View_INV_Tran_INBindingSource.Filter = "TranInID =" & Me.SuplierNameTextBox.Text & ""
                Me.SuplierNameTextBox.Clear()
                Me.CMInWard.Hide()
            End If
        Catch ex As Exception
            Me.SuplierNameTextBox.Clear()
            Me.SuplierNameTextBox.Focus()
        End Try
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        Me.View_INV_Tran_INBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.View_Inv_Tran_OUT_AuditBindingSource.Filter = "TranOutID =" & Me.ToolStripTextBox1.Text & ""
                Me.ToolStripTextBox1.Clear()
                Me.CMOutward.Hide()
            End If
        Catch ex As Exception
            Me.ToolStripTextBox1.Clear()
            Me.ToolStripTextBox1.Focus()
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.View_Inv_Tran_OUT_AuditBindingSource.RemoveFilter()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.Validate()
            Me.View_INV_Tran_INBindingSource.EndEdit()
            Me.View_INV_Tran_INTableAdapter.Update(Me.DSInWard.View_INV_Tran_IN)
            Try
                Me.View_INV_Tran_INTableAdapter.FillBy(Me.DSInWard.View_INV_Tran_IN, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripButton1_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton1.Click
        Try
            Me.Validate()
            Me.View_Inv_Tran_OUT_AuditBindingSource.EndEdit()
            Me.View_Inv_Tran_OUT_AuditTableAdapter.Update(Me.DSInWard.View_Inv_Tran_OUT_Audit)
            Try
                Me.View_Inv_Tran_OUT_AuditTableAdapter.FillBy(Me.DSInWard.View_Inv_Tran_OUT_Audit, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub View_INV_Tran_INDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_INV_Tran_INDataGridView.CellContentClick

    End Sub

    Private Sub View_INV_Tran_INDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_INV_Tran_INDataGridView.DataError

    End Sub

    Private Sub View_Inv_Tran_OUT_AuditDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Inv_Tran_OUT_AuditDataGridView.CellContentClick

    End Sub

    Private Sub View_Inv_Tran_OUT_AuditDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_Inv_Tran_OUT_AuditDataGridView.DataError

    End Sub
End Class