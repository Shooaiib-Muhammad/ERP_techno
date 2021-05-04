Public Class frmRepairedBladderRec

    Private Sub frmRepairedBladderRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.View_Repair_Bladder_OutTableAdapter.Fill(Me.DSRepairedBladdersRec.View_Repair_Bladder_Out)
        'Me.View_Inv_Tran_INTableAdapter.Fill(Me.DSRepairedBladdersRec.View_Inv_Tran_IN)
        LoadRecord()
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSRepairedBladdersRec.tbl_Inv_Tran_Date, Now.Date)
    End Sub
    Dim btnMsg As DialogResult
    Private Sub View_Repair_Bladder_OutDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Repair_Bladder_OutDataGridView.CellContentClick
        If e.ColumnIndex = 11 Then
            btnMsg = MessageBox.Show("Are You Sure Want To Receive Selected Bladder? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Dim RecQty As Double = 0
                If Me.View_Repair_Bladder_OutDataGridView(9, e.RowIndex).Value > 0 Then
                    RecQty = CDbl(Me.View_Repair_Bladder_OutDataGridView(9, e.RowIndex).Value)
                Else
                    RecQty = CDbl(Me.View_Repair_Bladder_OutDataGridView(7, e.RowIndex).Value)
                End If
                Me.Tbl_Inv_Tran_InTableAdapter.Insert(Me.DayNoLabel1.Text, "RBR", Nothing, Me.View_Repair_Bladder_OutDataGridView(6, e.RowIndex).Value.ToString, RecQty, Me.View_Repair_Bladder_OutDataGridView(10, e.RowIndex).Value.ToString, CInt(Me.View_Repair_Bladder_OutDataGridView(1, e.RowIndex).Value), CInt(Me.View_Repair_Bladder_OutDataGridView(8, e.RowIndex).Value))
                If RecQty >= CDbl(Me.View_Repair_Bladder_OutDataGridView(7, e.RowIndex).Value) Then
                    Me.View_Repair_Bladder_OutTableAdapter.UpdateQuery(True, Now.Date, CInt(Me.View_Repair_Bladder_OutDataGridView(1, e.RowIndex).Value))
                End If
                LoadRecord()
            End If
        End If
    End Sub
    Private Sub LoadRecord()
        Me.View_Repair_Bladder_OutTableAdapter.Fill(Me.DSRepairedBladdersRec.View_Repair_Bladder_Out)
        Me.View_Inv_Tran_INTableAdapter.Fill(Me.DSRepairedBladdersRec.View_Inv_Tran_IN)
    End Sub
    Private Sub View_Repair_Bladder_OutDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_Repair_Bladder_OutDataGridView.DataError

    End Sub

    Private Sub View_Inv_Tran_INDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Inv_Tran_INDataGridView.CellContentClick
        If e.ColumnIndex = 9 Then
            btnMsg = MessageBox.Show("Are You Sure Want To Undo Selected Bladder Transaction? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Me.View_Repair_Bladder_OutTableAdapter.DeleteQuery(Me.View_Inv_Tran_INDataGridView(1, e.RowIndex).Value)
                'Me.View_Repair_Bladder_OutTableAdapter.UpdateQuery(False, Nothing, CInt(Me.View_Inv_Tran_INDataGridView(7, e.RowIndex).Value))
                LoadRecord()
            End If
        End If
    End Sub

    Private Sub View_Inv_Tran_INDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_Inv_Tran_INDataGridView.DataError

    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Try
            Me.ValidateChildren()
            Me.View_Inv_Tran_INBindingSource.EndEdit()
            Me.View_Inv_Tran_INTableAdapter.Update(Me.DSRepairedBladdersRec.View_Inv_Tran_IN)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class