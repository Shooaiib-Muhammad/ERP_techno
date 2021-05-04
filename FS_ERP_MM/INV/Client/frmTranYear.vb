Public Class frmTranYear
    Private Sub frmTranYear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSYM.tbl_Inv_Tran_Date)
        Me.Tbl_Inv_Tran_DateBindingSource.Position = Me.Tbl_Inv_Tran_DateBindingSource.Count

    End Sub
    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_DateTableAdapter.Update(Me.DSYM.tbl_Inv_Tran_Date)
            MsgBox("Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim dt As String = Me.Tbl_Inv_Tran_DateTableAdapter.DateQuery(DateNameMaskedTextBox.Text)
            If dt Is Nothing Then
                Me.Tbl_Inv_Tran_DateTableAdapter.InsertQuery(DateNameMaskedTextBox.Text)
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSYM.tbl_Inv_Tran_Date)
                Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
                DateNameMaskedTextBox.Clear()
                DateNameMaskedTextBox.Enabled = False
            Else
                MsgBox("Already Date Exist", MsgBoxStyle.ApplicationModal)
                DateNameMaskedTextBox.Clear()

                DateNameMaskedTextBox.Focus()
            End If
        Catch ex As Exception
            MsgBox("Enter Date in Correct Formate", MsgBoxStyle.Critical)
            DateNameMaskedTextBox.Focus()
        End Try
        
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DateNameMaskedTextBox.Enabled = True
        DateNameMaskedTextBox.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Tbl_Inv_Tran_DateDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Tran_DateDataGridView.DataError

    End Sub
End Class