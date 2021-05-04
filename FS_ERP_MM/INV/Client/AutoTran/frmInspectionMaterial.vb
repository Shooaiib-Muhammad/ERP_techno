Public Class frmInspectionMaterial

    Private Sub frmMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DsPasFaiQty.tbl_Inv_Tran_In)
        Me.View_QC_MaterialTableAdapter.Fill(Me.DsPasFaiQty.View_QC_Material, CType(Now.Date, Date))
        Me.View_inv_TranInTableAdapter.Fill(Me.DsPasFaiQty.View_inv_TranIn)
        Me.View_inv_TranInBindingSource.MoveLast()
        Me.DateNameLabel1.Text = Now.Date
    End Sub

    Private Sub View_inv_TranInDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_inv_TranInDataGridView.CellContentClick
        If e.ColumnIndex = 10 Then
            Dim btnMsg As DialogResult
            If Me.View_inv_TranInDataGridView(7, e.RowIndex).Value Is DBNull.Value Or Me.View_inv_TranInDataGridView(8, e.RowIndex).Value Is DBNull.Value Then
                MsgBox("Enter Pass Qty")
            Else
                Dim InQty As Double = Me.View_inv_TranInDataGridView(5, e.RowIndex).Value
                Dim passQty As Double = Me.View_inv_TranInDataGridView(7, e.RowIndex).Value
                Dim FailQty As Double = Me.View_inv_TranInDataGridView(8, e.RowIndex).Value
                Dim TraninId As Integer = Me.View_inv_TranInDataGridView(4, e.RowIndex).Value
                If passQty + FailQty <= InQty Then
                    btnMsg = MessageBox.Show("Are You Sure Want To Update It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    If btnMsg = Windows.Forms.DialogResult.Yes Then
                        Me.Tbl_Inv_Tran_InTableAdapter.UpdateQuery(passQty, FailQty, Now.Date, TraninId)
                        Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DsPasFaiQty.tbl_Inv_Tran_In)
                        Me.View_inv_TranInTableAdapter.Fill(Me.DsPasFaiQty.View_inv_TranIn)
                        Me.View_QC_MaterialTableAdapter.Fill(Me.DsPasFaiQty.View_QC_Material, CType(Now.Date, Date))
                    Else
                    End If
                Else
                    MsgBox("Pass And Fail Qty is Greater Than InQuantity")
                End If
        End If
        End If
    End Sub

    Private Sub View_QC_MaterialDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_QC_MaterialDataGridView.CellContentClick
        If e.ColumnIndex = 10 Then
            Dim TraninDate As Date = Me.View_QC_MaterialDataGridView(9, e.RowIndex).Value
            If TraninDate.Date = Now.Date Then
                Dim btnMsg As DialogResult
                btnMsg = MessageBox.Show("Are You Sure Want To Undo It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If btnMsg = Windows.Forms.DialogResult.Yes Then
                    Dim TraninId As Integer = Me.View_QC_MaterialDataGridView(4, e.RowIndex).Value
                    Me.Tbl_Inv_Tran_InTableAdapter.UpdateQuery(Nothing, Nothing, Nothing, TraninId)
                    Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DsPasFaiQty.tbl_Inv_Tran_In)
                    Me.View_inv_TranInTableAdapter.Fill(Me.DsPasFaiQty.View_inv_TranIn)
                    Me.View_QC_MaterialTableAdapter.Fill(Me.DsPasFaiQty.View_QC_Material, CType(Now.Date, Date))
                Else
                End If
            End If
        End If
    End Sub

    Private Sub View_QC_MaterialDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_QC_MaterialDataGridView.DataError

    End Sub

    Private Sub View_inv_TranInDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_inv_TranInDataGridView.CellEnter
        If e.ColumnIndex = 8 Then
            Try
                Dim InQty As Double = Me.View_inv_TranInDataGridView(5, e.RowIndex).Value
                Dim passQty As Double = Me.View_inv_TranInDataGridView(7, e.RowIndex).Value
                Me.View_inv_TranInDataGridView(8, e.RowIndex).Value = InQty - passQty
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub View_inv_TranInDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_inv_TranInDataGridView.DataError

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Clear()
            Me.View_inv_TranInBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked And TextBox1.Text = "" Then
            TextBox1.MaxLength = 8
            TextBox1.Clear()
            TextBox1.Focus()
        ElseIf RadioButton4.Checked And TextBox1.Text <> "" Then
            If TextBox1.TextLength = 8 Or TextBox1.TextLength = 10 Then
                Me.View_inv_TranInBindingSource.Filter = "DateName='" & TextBox1.Text & "'"
            End If
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked And TextBox1.Text = "" Then
            TextBox1.Focus()
        ElseIf RadioButton6.Checked And TextBox1.Text <> "" Then
            Me.View_inv_TranInBindingSource.Filter = "L4Name like '" & TextBox1.Text & "%'"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If RadioButton6.Checked Then
            If Not Char.IsDigit(e.KeyChar) And Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf RadioButton4.Checked Then
            If Not e.KeyChar = "/" And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If RadioButton4.Checked Then
            If TextBox1.TextLength = 2 Then
                TextBox1.Text = String.Concat(TextBox1.Text, "/")
                TextBox1.Select(3, TextBox1.Text.Length)
            End If
            If TextBox1.TextLength = 5 Then
                TextBox1.Text = String.Concat(TextBox1.Text, "/")
                TextBox1.Select(6, TextBox1.Text.Length)
            End If
            If TextBox1.TextLength = 8 Then
                Me.TextBox1.Select(0, TextBox1.TextLength)
            End If
        End If
        If TextBox1.Text = "" Then
            Me.View_inv_TranInBindingSource.RemoveFilter()
        End If
        If RadioButton4.Checked And TextBox1.Text <> "" Then
            If TextBox1.TextLength = 8 Or TextBox1.TextLength = 10 Then
                Try
                    Me.View_inv_TranInBindingSource.Filter = "DateName='" & TextBox1.Text & "'"
                Catch ex As Exception
                    MsgBox("Enter Date in Correct Formate")
                End Try
            End If
        End If
        If RadioButton6.Checked And TextBox1.Text <> "" Then
            Me.View_inv_TranInBindingSource.Filter = "L4Name like '" & TextBox1.Text & "%'"
        End If
    End Sub
End Class