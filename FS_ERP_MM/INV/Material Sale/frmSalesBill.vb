Public Class frmSalesBill
    Private Sub frmSalesBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.View_Sale_DTableAdapter.Fill(Me.DSSaleBill.View_Sale_D)
        Catch ex As Exception
        End Try
        Me.Tbl_MM_Sale_Bill_DTableAdapter.Fill(Me.DSSaleBill.tbl_MM_Sale_Bill_D)
        Me.View_Sale_DTableAdapter.Fill(Me.DSSaleBill.View_Sale_D)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSSaleBill.tbl_Inv_L4)
        Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSSaleBill.tbl_MM_Customer)
        Me.Tbl_MM_Sale_Bill_DTableAdapter.Fill(Me.DSSaleBill.tbl_MM_Sale_Bill_D)
        Me.Tbl_MM_Sale_Bill_HTableAdapter.Fill(Me.DSSaleBill.tbl_MM_Sale_Bill_H)
        Me.Tbl_MM_Sale_Bill_HBindingSource.MoveLast()
    End Sub
    Dim BtnMsg As DialogResult
    Sub RefreshAll()
        Me.Tbl_MM_Sale_Bill_DTableAdapter.Fill(Me.DSSaleBill.tbl_MM_Sale_Bill_D)
        Me.View_Sale_DTableAdapter.FillBy(Me.DSSaleBill.View_Sale_D, Me.CustidComboBox.SelectedValue)
    End Sub
    Dim Deleteflag As Boolean = False
    Sub SaveRecord()
        Try
            Me.Validate()
            Me.Tbl_MM_Sale_Bill_HBindingSource.EndEdit()
            Me.Tbl_MM_Sale_Bill_HTableAdapter.Update(Me.DSSaleBill.tbl_MM_Sale_Bill_H)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Dim position As Integer = Me.Tbl_MM_Sale_Bill_HBindingSource.Position
        If Deleteflag = False Then
            SaveRecord()
            Me.Tbl_MM_Sale_Bill_HTableAdapter.Fill(Me.DSSaleBill.tbl_MM_Sale_Bill_H)
            Me.Tbl_MM_Sale_Bill_HBindingSource.Position = position
            MsgBox("Record Saved Successfully")
        Else
            SaveRecord()
            Me.Tbl_MM_Sale_Bill_HTableAdapter.Fill(Me.DSSaleBill.tbl_MM_Sale_Bill_H)
            Me.View_Sale_DTableAdapter.FillBy(Me.DSSaleBill.View_Sale_D, Me.CustidComboBox.SelectedValue)
            Me.Tbl_MM_Sale_Bill_HBindingSource.Position = position
            MsgBox("Record Deleted Successfully")
            Deleteflag = False
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim position As Integer = Me.Tbl_MM_Sale_Bill_DBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_MM_Sale_Bill_DBindingSource.EndEdit()
            Me.Tbl_MM_Sale_Bill_DTableAdapter.Update(Me.DSSaleBill.tbl_MM_Sale_Bill_D)
            Me.Tbl_MM_Sale_Bill_DTableAdapter.Fill(Me.DSSaleBill.tbl_MM_Sale_Bill_D)
            Me.Tbl_MM_Sale_Bill_DBindingSource.Position = position
            MsgBox("Record Updated Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_MM_CustomerBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_MM_CustomerBindingSource.PositionChanged
        Me.View_Sale_DTableAdapter.FillBy(Me.DSSaleBill.View_Sale_D, Me.CustidComboBox.SelectedValue)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BtnMsg = MessageBox.Show("Are You Sure Want To Undo All Materials? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If BtnMsg = Windows.Forms.DialogResult.Yes Then
            Dim BillNo, BillDNo, TranOutID As Integer
            Dim Code As String = Nothing
            For row = 0 To Me.Tbl_MM_Sale_Bill_DBindingSource.Count - 1
                BillNo = Me.Tbl_MM_Sale_Bill_DDataGridView(0, row).Value
                BillDNo = Me.Tbl_MM_Sale_Bill_DDataGridView(1, row).Value
                TranOutID = Me.Tbl_MM_Sale_Bill_DDataGridView(3, row).Value
                Me.Tbl_MM_Sale_Bill_DTableAdapter.DeleteQuery(BillNo, BillDNo, TranOutID)
                Me.View_Sale_DTableAdapter.UpdateQuery(Nothing, Nothing, TranOutID)
            Next
            RefreshAll()
            MsgBox("All Materials Undo Successfully")
        Else
        End If
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BtnMsg = MessageBox.Show("Are You Sure Want To Send All Materials? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If BtnMsg = Windows.Forms.DialogResult.Yes Then
            Dim row, TranOutID, SaleInvoiceNo As Integer
            Dim Qty, UnitPrice As Double
            Dim Code As String = Nothing
            Dim UOM As String = Nothing
            For row = 0 To Me.View_Sale_DBindingSource.Count - 1
                TranOutID = Me.View_Sale_DDataGridView(1, row).Value
                SaleInvoiceNo = Me.View_Sale_DDataGridView(0, row).Value
                Code = Me.View_Sale_DDataGridView(3, row).Value
                Qty = Me.View_Sale_DDataGridView(5, row).Value
                Try
                    UOM = Me.View_Sale_DDataGridView(6, row).Value
                Catch ex As Exception
                    UOM = Nothing
                End Try
                Try
                    UnitPrice = Me.View_Sale_DDataGridView(7, row).Value
                Catch ex As Exception
                    UnitPrice = Nothing
                End Try
                Dim MaxID As Integer
                Try
                    MaxID = Me.Tbl_MM_Sale_Bill_DTableAdapter.SelectMaxQuery(Me.BillIDLabel1.Text) + 1
                Catch ex As Exception
                    MaxID = 1
                End Try
                Try
                    Me.Tbl_MM_Sale_Bill_DTableAdapter.InsertQuery(Me.BillIDLabel1.Text, MaxID, SaleInvoiceNo, TranOutID, Code, Qty, UOM, UnitPrice, Nothing, Me.CustidComboBox.SelectedValue)
                    Me.View_Sale_DTableAdapter.UpdateQuery(True, Now.Date, TranOutID)
                Catch ex As Exception
                End Try
            Next
            RefreshAll()
            MsgBox("All Materials Sent Successfully")
        Else
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objRptViewer As New Class_Utility
        objRptViewer.LoadReports("\\server\myreports$\FSERPMM\Inventory\RptSaleBill.rpt", "{View_Sale_Bill.BillID}= " & Me.BillIDLabel1.Text & "", Nothing)
    End Sub

    Private Sub View_Sale_DDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Sale_DDataGridView.CellContentClick
        Dim TranOutID, SaleInvoiceNo As Integer
        Dim UOM As String = Nothing
        Dim Code As String = Nothing
        If e.ColumnIndex = 9 Then
            BtnMsg = MessageBox.Show("Are You Sure Want To Send Material? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If BtnMsg = Windows.Forms.DialogResult.Yes Then
                Dim Qty, UnitPrice As Double
                TranOutID = Me.View_Sale_DDataGridView(1, e.RowIndex).Value
                SaleInvoiceNo = Me.View_Sale_DDataGridView(0, e.RowIndex).Value
                Code = Me.View_Sale_DDataGridView(3, e.RowIndex).Value
                Qty = Me.View_Sale_DDataGridView(5, e.RowIndex).Value
                Try
                    UOM = Me.View_Sale_DDataGridView(6, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    UnitPrice = Me.View_Sale_DDataGridView(7, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Dim MaxID As Integer
                Try
                    MaxID = Me.Tbl_MM_Sale_Bill_DTableAdapter.SelectMaxQuery(Me.BillIDLabel1.Text) + 1
                Catch ex As Exception
                    MaxID = 1
                End Try
                Try
                    Me.Tbl_MM_Sale_Bill_DTableAdapter.InsertQuery(Me.BillIDLabel1.Text, MaxID, SaleInvoiceNo, TranOutID, Code, Qty, UOM, UnitPrice, Nothing, Me.CustidComboBox.SelectedValue)
                    Me.View_Sale_DTableAdapter.UpdateQuery(True, Now.Date, TranOutID)
                    RefreshAll()
                Catch ex As Exception
                End Try
            Else
            End If
        ElseIf e.ColumnIndex = 10 Then
            BtnMsg = MessageBox.Show("Are You Sure Want To Cancel Material? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If BtnMsg = Windows.Forms.DialogResult.Yes Then
                TranOutID = Me.View_Sale_DDataGridView(1, e.RowIndex).Value
                Me.View_Sale_DTableAdapter.UpdateCancelStatus(TranOutID)
                Me.View_Sale_DTableAdapter.FillBy(Me.DSSaleBill.View_Sale_D, Me.CustidComboBox.SelectedValue)
            Else
            End If
        End If
    End Sub

    Private Sub Tbl_MM_Sale_Bill_DDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_MM_Sale_Bill_DDataGridView.CellContentClick
        If e.ColumnIndex = 8 Then
            BtnMsg = MessageBox.Show("Are You Sure Want To Undo Material? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If BtnMsg = Windows.Forms.DialogResult.Yes Then
                Dim BillNo, BillDNo, TranOutID As Integer
                Dim Code As String = Nothing
                BillNo = Me.Tbl_MM_Sale_Bill_DDataGridView(0, e.RowIndex).Value
                BillDNo = Me.Tbl_MM_Sale_Bill_DDataGridView(1, e.RowIndex).Value
                TranOutID = Me.Tbl_MM_Sale_Bill_DDataGridView(3, e.RowIndex).Value
                Me.Tbl_MM_Sale_Bill_DTableAdapter.DeleteQuery(BillNo, BillDNo, TranOutID)
                Me.View_Sale_DTableAdapter.UpdateQuery(Nothing, Nothing, TranOutID)
                RefreshAll()
                MsgBox("Material Undo Successfully")
            Else
            End If
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Deleteflag = True
    End Sub

    Private Sub CMtxtGPDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtGPDate.GotFocus
        If CMtxtGPDate.Text = "Enter Gate Pass Date" Then
            CMtxtGPDate.Text = ""
            CMtxtGPDate.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CMtxtGPDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtGPDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim mydate As System.DateTime
            If CMtxtGPDate.TextLength < 11 Then
                Try
                    mydate = CDate("#" & Me.CMtxtGPDate.Text & "#")
                Catch ex As Exception
                    MsgBox("Enter the Correct Date Format.")
                End Try
            End If
            If CMtxtGPNo.TextLength < 8 Then
                Me.View_Sale_DBindingSource.Filter = "TranoutID=" & CMtxtGPNo.Text & " And DateName='" & mydate & "'"
            Else
                Me.View_Sale_DBindingSource.Filter = "DateName='" & mydate & "'"
            End If
            ContexMenue()
        End If
    End Sub

    Private Sub CMtxtGPDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMtxtGPDate.KeyPress
        If Not e.KeyChar = "/" And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CMtxtGPDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtGPDate.LostFocus
        If CMtxtGPDate.Text = "" Then
            CMtxtGPDate.Text = "Enter Gate Pass Date"
            CMtxtGPDate.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub CMtxtGPDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtGPDate.TextChanged
        If CMtxtGPDate.TextLength = 2 Then
            CMtxtGPDate.Text = String.Concat(CMtxtGPDate.Text, "/")
            CMtxtGPDate.Select(3, CMtxtGPDate.Text.Length)
        End If
        If CMtxtGPDate.TextLength = 5 Then
            CMtxtGPDate.Text = String.Concat(CMtxtGPDate.Text, "/")
            CMtxtGPDate.Select(6, CMtxtGPDate.Text.Length)
        End If
        If CMtxtGPDate.TextLength = 8 Then
            Me.CMtxtGPDate.Select(0, CMtxtGPDate.TextLength)
        End If
    End Sub

    Private Sub CMtxtGPNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtGPNo.GotFocus
        If CMtxtGPNo.Text = "Enter Gate Pass No." Then
            CMtxtGPNo.Text = ""
            CMtxtGPNo.ForeColor = Color.Black
        End If
    End Sub
    Sub ContexMenue()
        Me.CMtxtGPNo.Text = "Enter Gate Pass No."
        Me.CMtxtGPNo.ForeColor = Color.Silver
        Me.CMtxtGPDate.Text = "Enter Gate Pass Date"
        Me.CMtxtGPDate.ForeColor = Color.Silver
        Me.CMMatReq.Hide()
    End Sub
    Private Sub CMtxtGPNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtGPNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim mydate As System.DateTime
            If CMtxtGPDate.TextLength < 11 Then
                Try
                    mydate = CDate("#" & Me.CMtxtGPDate.Text & "#")
                Catch ex As Exception
                    MsgBox("Enter The Correct Date Format.")
                End Try
            End If
            If CMtxtGPDate.TextLength < 11 Then
                Me.View_Sale_DBindingSource.Filter = "TranoutID=" & CMtxtGPNo.Text & " And DateName='" & mydate & "'"
            Else
                Me.View_Sale_DBindingSource.Filter = "TranoutID=" & CMtxtGPNo.Text & ""
            End If
            ContexMenue()
        End If
    End Sub

    Private Sub CMtxtGPNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMtxtGPNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CMtxtGPNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtGPNo.LostFocus
        If CMtxtGPNo.Text = "" Then
            CMtxtGPNo.Text = "Enter Gate Pass No."
            CMtxtGPNo.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.View_Sale_DBindingSource.RemoveFilter()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.View_Sale_DBindingSource.RemoveFilter()
    End Sub
End Class