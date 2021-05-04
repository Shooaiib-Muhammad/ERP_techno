Public Class frmPurchaseReturn
    Dim PositionPO As Integer = Nothing
    Private Sub frmPurchaseReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Pur_PO_DTableAdapter.Fill(Me.DSPR.tbl_Pur_PO_D)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPR.tbl_Inv_L4)
        Me.View_PO_DTableAdapter.FillBy(Me.DSPR.View_PO_D, Me.L4NameComboBox.SelectedValue)
        Try
            Me.View_PO_PandingTableAdapter.Fill(Me.DSPR.View_PO_Panding)
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSPR.tbl_Inv_Tran_Date, CType(Now.Date, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSPR.tbl_Inv_Tran_Out)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        Me.Tbl_Inv_Tran_OutBindingSource.AddNew()
        Me.View_PO_PandingTableAdapter.FillBy(Me.DSPR.View_PO_Panding)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.View_PO_PandingTableAdapter.Fill(Me.DSPR.View_PO_Panding)
        Me.Tbl_Inv_Tran_OutBindingSource.CancelEdit()
    End Sub

    Private Sub View_PO_PandingBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles View_PO_PandingBindingSource.PositionChanged
        Try
            Me.View_PO_DTableAdapter.FillBy(Me.DSPR.View_PO_D, Me.L4NameComboBox.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub
    Dim PO As Integer
    Dim POD As Integer
    Dim Myrow As Integer
    Dim ReceivedQty As Integer
    Dim PRReceived As Integer
    Private Sub View_PO_DDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_PO_DDataGridView.CellEnter
        PRReceived = Me.View_PO_DDataGridView(13, e.RowIndex).Value
        If Me.QtyTextBox.Text.Length <= 0 Then
            Me.POIDLabel2.Text = Me.View_PO_DDataGridView(1, e.RowIndex).Value
            Me.PODNoLabel2.Text = Me.View_PO_DDataGridView(2, e.RowIndex).Value
            Me.UOMLabel1.Text = Me.View_PO_DDataGridView(11, e.RowIndex).Value
            Me.SupplierIDLabel1.Text = Me.View_PO_DDataGridView(3, e.RowIndex).Value
            Me.PPULabel2.Text = Me.View_PO_DDataGridView(10, e.RowIndex).Value
            Me.CurrencyLabel1.Text = Me.View_PO_DDataGridView(9, e.RowIndex).Value
        End If
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim PositionIn As Integer = Tbl_Inv_Tran_OutBindingSource.Position
        PositionPO = View_PO_DBindingSource.Position
        If QtyTextBox.TextLength > 0 Then
            If Val(Me.QtyTextBox.Text) <= PRReceived Then
                Try
                    Me.Validate()
                    Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
                    Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSPR.tbl_Inv_Tran_Out)
                    MsgBox("Record Saved")
                    View_PO_DBindingSource.Position = PositionPO
                    Me.Tbl_Pur_PO_DTableAdapter.UpdateStatus(False, Nothing, Me.POIDLabel2.Text, Me.PODNoLabel2.Text)
                    Me.View_PO_DTableAdapter.FillBy(Me.DSPR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Dim btnMsg As DialogResult
                btnMsg = MessageBox.Show("Enter Quantity and Recieved Quantity is Greater than Order Quantity " & vbCrLf & "                Are You Sure Want To Save It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If btnMsg = Windows.Forms.DialogResult.Yes Then
                    Try
                        Me.Validate()
                        Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
                        Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSPR.tbl_Inv_Tran_Out)
                        MsgBox("Record Saved")
                        View_PO_DBindingSource.Position = PositionPO
                        Me.Tbl_Pur_PO_DTableAdapter.UpdateStatus(False, Nothing, Me.POIDLabel2.Text, Me.PODNoLabel2.Text)
                        Me.View_PO_DTableAdapter.FillBy(Me.DSPR.View_PO_D, Me.L4NameComboBox.SelectedValue)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Me.QtyTextBox.Clear()
                    MsgBox("Record Not Saved")
                End If
            End If
        End If
        Tbl_Inv_Tran_OutBindingSource.Position = PositionIn
        View_PO_DBindingSource.Position = PositionPO
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim btnMsg As DialogResult
        btnMsg = MessageBox.Show("Are You Sure Want To Delete It?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Dim UpdateQty As Integer = Me.View_PO_DTableAdapter.SelectQtyQuery(Val(Me.POIDLabel2.Text), Val(Me.PODNoLabel2.Text))
            Dim OQty As Integer = Me.Tbl_Pur_PO_DTableAdapter.SelectQuery(Val(Me.POIDLabel2.Text), Val(Me.PODNoLabel2.Text))
            Dim MyPosition As Integer = Me.Tbl_Inv_Tran_OutBindingSource.Position
            Me.Tbl_Inv_Tran_OutTableAdapter.DeleteQuery(Val(Me.TranInIDLabel1.Text))
            If UpdateQty >= OQty Then
                Me.Tbl_Pur_PO_DTableAdapter.UpdateStatus(True, Now.Date, Val(Me.POIDLabel2.Text), Val(Me.PODNoLabel2.Text))
            End If
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSPR.tbl_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
            Me.View_PO_DTableAdapter.FillBy(Me.DSPR.View_PO_D, Me.L4NameComboBox.SelectedValue)
            Me.Tbl_Inv_Tran_OutBindingSource.Position = MyPosition
        Else
            MsgBox("Record Not Deleted")
        End If


    End Sub
    Private Sub QtyTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtyTextBox.TextChanged
        If QtyTextBox.TextLength > 0 Then
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.Simple
        Else
            Me.L4NameComboBox.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub
    Private Sub View_PO_DDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_PO_DDataGridView.DataError
    End Sub
    Function ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.WindowState = FormWindowState.Maximized
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ChildWindowOpen("frmRptViewer") = False Then
            Dim objForm As New frmRptViewer
            Dim filter As String = "{View_Inv_PR_GP.TranOutID} = " & Val(TranInIDLabel1.Text)
            objForm.ViewReport("\\Server\MyReports$\FSERPMM\Inventory\RptPurchaseReturnGatePass11.rpt", filter, )
            objForm.MdiParent = frmMain
            objForm.Show()
        End If
    End Sub
End Class