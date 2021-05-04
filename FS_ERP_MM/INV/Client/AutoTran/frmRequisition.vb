Public Class frmRequisition
    Public Shared partialQty As Double
    Public Shared flag As Boolean = False
    Private Sub frmRequisition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.View_Inv_Tran_OutTableAdapter.Fill(Me.DSRequisition.View_Inv_Tran_Out)
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Tran_Date, Now.Date)
        Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Requisition)
        Timer1.Start()
    End Sub
    Private Shared Qty As Double = 0
    Private Shared ExtCust, DayNo, CPPU1, PrdLine, POH, POMNo, PODNo As Integer
    Private Shared currency1 As String
    Private Shared TranType As String = Nothing
    Private Shared ReqNo As Integer = 0
    Private Shared Code As String = Nothing
    Private Shared Unit1 As String = Nothing

    Private Sub Tbl_Inv_RequisitionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_RequisitionDataGridView.CellContentClick
        DayNo = Val(Me.DayNoLabel1.Text)
        If e.ColumnIndex = 11 Then
            ReqNo = Me.Tbl_Inv_RequisitionDataGridView(0, e.RowIndex).Value
            If ReqNo > 0 Then
                Code = Me.Tbl_Inv_RequisitionDataGridView(6, e.RowIndex).Value
                Qty = Me.Tbl_Inv_RequisitionDataGridView(10, e.RowIndex).Value
                Unit1 = Me.Tbl_Inv_RequisitionDataGridView(12, e.RowIndex).Value
                'To Take PO,POM,POD Values
                Try
                    POH = Me.Tbl_Inv_RequisitionDataGridView(16, e.RowIndex).Value
                    POMNo = Me.Tbl_Inv_RequisitionDataGridView(17, e.RowIndex).Value
                    PODNo = Me.Tbl_Inv_RequisitionDataGridView(18, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    currency1 = Me.Tbl_Inv_RequisitionDataGridView(13, e.RowIndex).Value
                Catch ex As Exception
                    currency1 = Nothing
                End Try
                Try
                    CPPU1 = Me.Tbl_Inv_RequisitionDataGridView(14, e.RowIndex).Value
                Catch ex As Exception
                    CPPU1 = Nothing
                End Try
                If Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 1 Then  ' MLP - I    
                    PrdLine = 5
                    TranType = "MIR"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 2 Then ' QR - I    
                    PrdLine = 6
                    TranType = "MIR"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 5 Then ' TM - I    
                    PrdLine = 10
                    TranType = "MIR"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 15 Then ' RWPD - I    
                    PrdLine = 8
                    TranType = "MIR"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 3 Then ' MLP+QR - I    
                    TranType = "MIR"
                    PrdLine = 5
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 4 Then ' QR+MLP - I    
                    PrdLine = 6
                    TranType = "MIR"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 5 Then ' TM Hall - I    
                    PrdLine = 10
                    TranType = "MIR"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 6 Then ' TM Carcass - I    
                    PrdLine = 10
                    TranType = "MIR"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 7 Then ' Aware Sports - E
                    ExtCust = 16
                    TranType = "MOGP"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 13 Then ' QR+RND - I
                    'ExtCust = 17
                    PrdLine = 6
                    TranType = "MIR"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 12 Then ' Rehan & Sons
                    ExtCust = 95
                    TranType = "MOGP"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 8 Then ' RND - I       
                    PrdLine = 9
                    TranType = "MIR"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 9 Then ' Arif Medicine - E
                    ExtCust = 12
                    TranType = "MOGP"
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 10 Then ' B.J. Sports - E
                    ExtCust = 15
                    TranType = "MOGP"
                Else
                    PrdLine = Nothing
                    TranType = Nothing
                End If
                Dim btnMsg As DialogResult
                btnMsg = MessageBox.Show("Are you sure you want to save Full Quantity.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If btnMsg = Windows.Forms.DialogResult.Yes Then
                    If DayNo > 0 Then
                        If Not PrdLine = Nothing Or Not ExtCust = Nothing Or POH > 0 Then
                            Me.Tbl_Inv_Requisition_UpdateTableAdapter.Update(True, Now.Date, ReqNo, Nothing, Nothing)
                            If Not PrdLine = Nothing Then
                                Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, TranType, ReqNo, Code, Qty, PrdLine, Nothing, ReqNo, currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing)
                                PrdLine = Nothing
                            ElseIf Not ExtCust = Nothing Then
                                Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, TranType, ReqNo, Code, Qty, Nothing, ExtCust, ReqNo, currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing)
                                ExtCust = Nothing
                            ElseIf POH > 0 And POMNo > 0 And PODNo > 0 Then
                                Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, TranType, ReqNo, Code, Qty, PrdLine, Nothing, ReqNo, currency1, CPPU1, Unit1, POH, POMNo, PODNo, Nothing)
                            End If
                            Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Requisition)
                            Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
                        Else
                            MsgBox("Department not exist")
                        End If
                    Else
                        MsgBox("Set the Transaction Date.")
                    End If
                Else
                    frmRequisition.PartialMod()
                End If
            Else
                MsgBox("There is No Record to Save.")
            End If
        End If
        If e.ColumnIndex = 15 Then
            ReqNo = Me.Tbl_Inv_RequisitionDataGridView(0, e.RowIndex).Value
            Me.Tbl_Inv_RequisitionTableAdapter.UpdateCancelQuery(True, Now, ReqNo)
        End If
    End Sub
    'Dim obj As frmRequisition
    Public Sub InsertQty()
        If partialQty <= Qty Then
            Try
                If Not PrdLine = Nothing Then
                    Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, TranType, ReqNo, Code, partialQty, PrdLine, Nothing, ReqNo, currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing)
                    PrdLine = Nothing
                ElseIf Not ExtCust = Nothing Then
                    Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, TranType, ReqNo, Code, partialQty, Nothing, ExtCust, ReqNo, currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing)
                    ExtCust = Nothing
                ElseIf POH > 0 And POMNo > 0 And PODNo > 0 Then
                    Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, TranType, ReqNo, Code, partialQty, PrdLine, Nothing, ReqNo, currency1, CPPU1, Unit1, POH, POMNo, PODNo, Nothing)
                End If
                Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
            Catch ex As Exception
            End Try
        Else
            MsgBox("Partial Quantity Is Greater Than Balance Quantity", MsgBoxStyle.Critical)
        End If
            
    End Sub

    Public Shared Function ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.Focus()
                Return True
            End If
        Next
        Return False
    End Function

    Public Shared Sub PartialMod()
        If ChildWindowOpen("frmPartialQty") = False Then
            Dim objPartialQty As New FrmPartialQty
            FrmPartialQty.Size = New System.Drawing.Size(381, 131)
            objPartialQty.Show()
            objPartialQty.PartialQtyTextBox.Focus()
        End If
    End Sub

    Private Sub View_Inv_Tran_OutDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Inv_Tran_OutDataGridView.CellContentClick
        If e.ColumnIndex = 7 Then
            'If Me.View_Inv_Tran_OutDataGridView(2, e.RowIndex).Value.ToString.Length > 0 Then
            Dim status As Integer
            status = MsgBox("Are you sure you want to  Undo it.", MsgBoxStyle.YesNo)
            If (status = 6) Then
                Dim ID As Integer = Nothing
                Dim ReqID As Integer = Nothing
                ID = Me.View_Inv_Tran_OutDataGridView(1, e.RowIndex).Value
                ReqID = Me.View_Inv_Tran_OutDataGridView(3, e.RowIndex).Value
                Me.Tbl_Inv_RequisitionTableAdapter.UpdateUndo(ReqID)
                Me.Tbl_Inv_Tran_OutTableAdapter.DeleteQuery(ID, ReqID)
                Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Requisition)
                Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
                MsgBox("Record Undo Successfully")
            End If
        Else
            MsgBox("Select the right Record.")
        End If
        'End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked And TextBox1.Text = "" Then
            TextBox1.MaxLength = 8
            TextBox1.Clear()
            TextBox1.Focus()
        ElseIf RadioButton2.Checked And TextBox1.Text <> "" Then
            If TextBox1.TextLength = 8 Or TextBox1.TextLength = 10 Then
                Tbl_Inv_RequisitionBindingSource.Filter = "RequestDate='" & TextBox1.Text & "'"
            End If
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Clear()
        If RadioButton3.Checked And TextBox1.Text = "" Then
            TextBox1.Focus()
        ElseIf RadioButton3.Checked And TextBox1.Text <> "" Then
            Tbl_Inv_RequisitionBindingSource.Filter = "MPID='" & TextBox1.Text & "'"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Clear()
            Tbl_Inv_RequisitionBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked And TextBox1.Text = "" Then
            TextBox1.MaxLength = 8
            TextBox1.Clear()
            TextBox1.Focus()
        ElseIf RadioButton4.Checked And TextBox1.Text <> "" Then
            If TextBox1.TextLength = 8 Then
                Tbl_Inv_RequisitionBindingSource.Filter = "RequiredDate='" & TextBox1.Text & "'"
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If RadioButton2.Checked Or RadioButton4.Checked Then
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
            Tbl_Inv_RequisitionBindingSource.RemoveFilter()
        End If
        If RadioButton2.Checked And TextBox1.Text <> "" Then
            If TextBox1.TextLength = 8 Or TextBox1.TextLength = 10 Then
                Try
                    Tbl_Inv_RequisitionBindingSource.Filter = "RequestDate='" & TextBox1.Text & "'"
                Catch ex As Exception
                    MsgBox("Enter Date in Correct Formate")
                End Try
            End If
        End If
        If RadioButton3.Checked And TextBox1.Text <> "" Then
            Tbl_Inv_RequisitionBindingSource.Filter = "MPID='" & TextBox1.Text & "'"
        End If
        If RadioButton4.Checked And TextBox1.Text <> "" Then
            If TextBox1.TextLength = 8 Or TextBox1.TextLength = 10 Then
                Try
                    Tbl_Inv_RequisitionBindingSource.Filter = "RequiredDate='" & TextBox1.Text & "'"
                Catch ex As Exception
                    MsgBox("Enter Date in Correct Formate")
                End Try
            End If
        End If
        If RadioButton5.Checked And TextBox1.Text <> "" Then
            Tbl_Inv_RequisitionBindingSource.Filter = "PrdLineName like '" & TextBox1.Text & "%'"
        End If
        If RadioButton6.Checked And TextBox1.Text <> "" Then
            Tbl_Inv_RequisitionBindingSource.Filter = "L4Name like '" & TextBox1.Text & "%'"
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked And TextBox1.Text = "" Then
            TextBox1.Focus()
        ElseIf RadioButton5.Checked And TextBox1.Text <> "" Then
            Tbl_Inv_RequisitionBindingSource.Filter = "PrdLineName like '" & TextBox1.Text & "%'"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked And TextBox1.Text = "" Then
            TextBox1.Focus()
        ElseIf RadioButton6.Checked And TextBox1.Text <> "" Then
            Tbl_Inv_RequisitionBindingSource.Filter = "L4Name like '" & TextBox1.Text & "%'"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If RadioButton3.Checked Then
            If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        ElseIf RadioButton6.Checked Then
            If Not Char.IsDigit(e.KeyChar) And Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
            'If Char.IsNumber(e.KeyChar) And e.KeyChar = Chr(Keys.Back) Then
            '    e.Handled = True
            'End If
        ElseIf RadioButton5.Checked Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf RadioButton2.Checked Or RadioButton4.Checked Then
            If Not e.KeyChar = "/" And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub RefreshRequisition()
        Tbl_Inv_RequisitionTableAdapter.Fill(DSRequisition.tbl_Inv_Requisition)
        View_Inv_Tran_OutTableAdapter.FillBy(DSRequisition.View_Inv_Tran_Out, Val(Me.DayNoLabel1.Text))
    End Sub

    Private Sub Tbl_Inv_RequisitionDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_RequisitionDataGridView.DataError

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If flag = True Then
            RefreshRequisition()
            flag = False
        End If
    End Sub
End Class