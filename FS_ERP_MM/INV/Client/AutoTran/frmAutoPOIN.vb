Public Class frmAutoPOIN
    Private Sub frmAutoPOIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSAutoPOIN.tbl_Inv_Tran_Date, Now.Date)
        Try
            Me.View_PO_DTableAdapter.Fill(Me.DSAutoPOIN.View_PO_D)
        Catch ex As Exception

        End Try
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSAutoPOIN.tbl_Inv_Supplier)
        Try
            Me.View_Inv_Tran_InTableAdapter.Fill(Me.DSAutoPOIN.View_Inv_Tran_In, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub View_PO_DDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_PO_DDataGridView.CellContentClick
        Dim btnMsg As DialogResult
        Dim MRIN As String = Nothing
        If e.ColumnIndex = 24 Then
            btnMsg = MessageBox.Show("Are You Sure Want To Receive Material?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                If Me.DateNameLabel1.Text = "" Then
                    MsgBox("Please Enter Transaction Date To Continue", MsgBoxStyle.Critical)
                Else

                    Dim EnterQty As Double
                    Dim BatchNo As String = Nothing
                    If Me.View_PO_DDataGridView(19, e.RowIndex).Value <= CDbl(Me.View_PO_DDataGridView(16, e.RowIndex).Value) * 1.05 Then
                        EnterQty = CDbl(Me.View_PO_DDataGridView(19, e.RowIndex).Value)
                    Else
                        EnterQty = 0
                    End If
                    If EnterQty > 0 Then
                        MRIN = Me.View_PO_DDataGridView(18, e.RowIndex).Value
                        Try
                            BatchNo = Me.View_PO_DDataGridView(22, e.RowIndex).Value.ToString
                        Catch ex As Exception
                            BatchNo = ""
                        End Try
                        Dim Formula1 As Double
                        Try
                            Formula1 = Me.View_PO_DDataGridView(21, e.RowIndex).Value
                        Catch ex As Exception

                        End Try
                        If Me.Tbl_Inv_Tran_InTableAdapter.UnitQuery(Me.View_PO_DDataGridView(15, e.RowIndex).Value).ToString.Trim = Me.View_PO_DDataGridView(8, e.RowIndex).Value.ToString.Trim Then

                            'Me.Tbl_Inv_Tran_InTableAdapter.Insert(Me.DayNoLabel1.Text, Nothing, "MRI", MRIN, Me.View_PO_DDataGridView(3, e.RowIndex).Value, Me.View_PO_DDataGridView(4, e.RowIndex).Value, Me.View_PO_DDataGridView(5, e.RowIndex).Value, Me.View_PO_DDataGridView(15, e.RowIndex).Value, Me.View_PO_DDataGridView(6, e.RowIndex).Value, Me.View_PO_DDataGridView(7, e.RowIndex).Value, Nothing, EnterQty, Me.View_PO_DDataGridView(8, e.RowIndex).Value, Me.View_PO_DDataGridView(20, e.RowIndex).Value, Me.View_PO_DDataGridView(22, e.RowIndex).Value.ToString)
                            Me.Tbl_Inv_Tran_InTableAdapter.Insert(Me.DayNoLabel1.Text, Nothing, "MRI", MRIN, Me.View_PO_DDataGridView(3, e.RowIndex).Value, Me.View_PO_DDataGridView(4, e.RowIndex).Value, Me.View_PO_DDataGridView(5, e.RowIndex).Value, Me.View_PO_DDataGridView(15, e.RowIndex).Value, Me.View_PO_DDataGridView(6, e.RowIndex).Value, Me.View_PO_DDataGridView(7, e.RowIndex).Value, Nothing, EnterQty, Me.View_PO_DDataGridView(8, e.RowIndex).Value, Formula1, BatchNo)
                            Me.Tbl_Inv_Tran_InTableAdapter.UpdateQuery1(Me.View_PO_DDataGridView(7, e.RowIndex).Value, Me.View_PO_DDataGridView(15, e.RowIndex).Value)
                            If Me.View_PO_DDataGridView(19, e.RowIndex).Value >= CDbl(Me.View_PO_DDataGridView(16, e.RowIndex).Value) Then
                                Me.Tbl_Inv_Tran_InTableAdapter.UpdateQuery(Now.Date, Me.View_PO_DDataGridView(3, e.RowIndex).Value, Me.View_PO_DDataGridView(4, e.RowIndex).Value)
                            End If
                            Me.View_PO_DTableAdapter.Fill(Me.DSAutoPOIN.View_PO_D)
                            Try
                                Me.View_Inv_Tran_InTableAdapter.Fill(Me.DSAutoPOIN.View_Inv_Tran_In, Me.DayNoLabel1.Text)
                            Catch ex As Exception
                            End Try
                        Else
                        End If

                    Else
                        MsgBox("Enter Qty to Continue")
                    End If

                End If

            End If
        End If


        'btnMsg = MessageBox.Show("Are You Sure Want To Auto Purchase Order Receiving?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        'If btnMsg = Windows.Forms.DialogResult.Yes Then
        '    If Me.DateNameLabel1.Text = "" Then
        '        MsgBox("Please Enter Transaction Date To Continue", MsgBoxStyle.Critical)
        '    Else
        '        For i As Integer = 0 To Me.View_PO_DDataGridView.RowCount - 1
        '            If Me.View_PO_DDataGridView(20, i).Value = True Then
        '                MRIN = Me.View_PO_DDataGridView(18, i).Value
        '                If Me.Tbl_Inv_Tran_InTableAdapter.UnitQuery(Me.View_PO_DDataGridView(15, i).Value).ToString.Trim = Me.View_PO_DDataGridView(8, i).Value.ToString.Trim Then
        '                    Me.Tbl_Inv_Tran_InTableAdapter.Insert(Me.DayNoLabel1.Text, Nothing, "MRI", MRIN, Me.View_PO_DDataGridView(3, i).Value, Me.View_PO_DDataGridView(4, i).Value, Me.View_PO_DDataGridView(5, i).Value, Me.View_PO_DDataGridView(15, i).Value, Me.View_PO_DDataGridView(6, i).Value, Me.View_PO_DDataGridView(7, i).Value, Nothing, Me.View_PO_DDataGridView(16, i).Value, Me.View_PO_DDataGridView(8, i).Value, Me.View_PO_DDataGridView(20, i).Value)
        '                    Me.Tbl_Inv_Tran_InTableAdapter.UpdateQuery(Now.Date, Me.View_PO_DDataGridView(3, i).Value, Me.View_PO_DDataGridView(4, i).Value)
        '                    Me.Tbl_Inv_Tran_InTableAdapter.UpdateQuery1(Me.View_PO_DDataGridView(7, i).Value, Me.View_PO_DDataGridView(15, i).Value)
        '                Else
        '                End If
        '            End If
        '        Next
        '        Me.View_PO_DTableAdapter.Fill(Me.DSAutoPOIN.View_PO_D)
        '    End If
        'End If
    End Sub
    Private Sub View_PO_DDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_PO_DDataGridView.DataError
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim btnMsg As DialogResult
        Dim MRIN As String = Nothing
        btnMsg = MessageBox.Show("Are You Sure Want To Auto Purchase Order Receiving?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            If Me.DateNameLabel1.Text = "" Then
                MsgBox("Please Enter Transaction Date To Continue", MsgBoxStyle.Critical)
            Else
                Dim BatchNo As String = ""
                For i As Integer = 0 To Me.View_PO_DDataGridView.RowCount - 1
                    If Me.View_PO_DDataGridView(20, i).Value = True Then
                        MRIN = Me.View_PO_DDataGridView(18, i).Value

                        Try
                            BatchNo = Me.View_PO_DDataGridView(22, i).Value
                        Catch ex As Exception

                        End Try
                        Dim EnterQty As Double = Me.View_PO_DDataGridView(16, i).Value
                        Dim Formula1 As Double = Me.View_PO_DDataGridView(21, i).Value
                        If Me.Tbl_Inv_Tran_InTableAdapter.UnitQuery(Me.View_PO_DDataGridView(15, i).Value).ToString.Trim = Me.View_PO_DDataGridView(8, i).Value.ToString.Trim Then
                            'Me.Tbl_Inv_Tran_InTableAdapter.Insert(Me.DayNoLabel1.Text, Nothing, "MRI", MRIN, Me.View_PO_DDataGridView(3, i).Value, Me.View_PO_DDataGridView(4, i).Value, Me.View_PO_DDataGridView(5, i).Value, Me.View_PO_DDataGridView(15, i).Value, Me.View_PO_DDataGridView(6, i).Value, Me.View_PO_DDataGridView(7, i).Value, Nothing, Me.View_PO_DDataGridView(16, i).Value, Me.View_PO_DDataGridView(8, i).Value, Me.View_PO_DDataGridView(20, i).Value, Nothing)
                            'Me.Tbl_Inv_Tran_InTableAdapter.Insert(Me.DayNoLabel1.Text, Nothing, "MRI", MRIN, Me.View_PO_DDataGridView(3, i).Value, Me.View_PO_DDataGridView(4, i).Value, Me.View_PO_DDataGridView(5, i).Value, Me.View_PO_DDataGridView(15, i).Value, Me.View_PO_DDataGridView(6, i).Value, Me.View_PO_DDataGridView(7, i).Value, Nothing, EnterQty, Me.View_PO_DDataGridView(8, i).Value, Me.View_PO_DDataGridView(20, i).Value, BatchNo)
                            'Me.Tbl_Inv_Tran_InTableAdapter.Insert(Me.DayNoLabel1.Text, Nothing, "MRI", MRIN, Me.View_PO_DDataGridView(3, i).Value, Me.View_PO_DDataGridView(4, i).Value, Me.View_PO_DDataGridView(5, i).Value, Me.View_PO_DDataGridView(15, i).Value, Me.View_PO_DDataGridView(6, i).Value, Me.View_PO_DDataGridView(7, i).Value, Nothing, EnterQty, Me.View_PO_DDataGridView(8, i).Value, Me.View_PO_DDataGridView(20, i).Value, Nothing)
                            Me.Tbl_Inv_Tran_InTableAdapter.Insert(CInt(Me.DayNoLabel1.Text), Nothing, "MRI", MRIN, CInt(Me.View_PO_DDataGridView(3, i).Value), CInt(Me.View_PO_DDataGridView(4, i).Value), CInt(Me.View_PO_DDataGridView(5, i).Value), Me.View_PO_DDataGridView(15, i).Value.ToString, Me.View_PO_DDataGridView(6, i).Value.ToString, CDbl(Me.View_PO_DDataGridView(7, i).Value), 0, EnterQty, Me.View_PO_DDataGridView(8, i).Value.ToString, Formula1, BatchNo)
                            Me.Tbl_Inv_Tran_InTableAdapter.UpdateQuery(Now.Date, Me.View_PO_DDataGridView(3, i).Value, Me.View_PO_DDataGridView(4, i).Value)
                            Me.Tbl_Inv_Tran_InTableAdapter.UpdateQuery1(Me.View_PO_DDataGridView(7, i).Value, Me.View_PO_DDataGridView(15, i).Value)
                        Else
                            MsgBox("UOM is Miss Matched", MsgBoxStyle.Information)
                        End If
                    End If
                Next
                Me.View_PO_DTableAdapter.Fill(Me.DSAutoPOIN.View_PO_D)
                Try
                    Me.View_Inv_Tran_InTableAdapter.Fill(Me.DSAutoPOIN.View_Inv_Tran_In, Me.DayNoLabel1.Text)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Private Sub MatNameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MatNameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_PO_DBindingSource.Filter = "L4Name like '" & Me.MatNameTextBox.Text & "%'"
            Me.MatNameTextBox.Text = ""
            Me.CMSSupStatus.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.View_PO_DBindingSource.RemoveFilter()
    End Sub

    Private Sub CMtxtPONo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMtxtPONo.Click

    End Sub
    Sub ContextManueFilter(ByVal PONo As Boolean, ByVal PODate As Boolean, ByVal POMat As Boolean)
        Dim Mydate As System.DateTime
        If PODate = True Then
            Try
                Mydate = CDate("#" & CMtxtDate.Text & "#")
            Catch ex As Exception
                'MsgBox("Enter The Correct Date Formate.")
            End Try
        End If
        If PONo = True And PODate = False And POMat = False Then
            Me.View_PO_DBindingSource.Filter = "POID =" & Me.CMtxtPONo.Text & ""
        ElseIf PONo = True And PODate = False And POMat = True Then
            Me.View_PO_DBindingSource.Filter = "POID =" & Me.CMtxtPONo.Text & "And L4Name like '" & Me.CMtxtMatName.Text & "%'"
        ElseIf PONo = True And PODate = True And POMat = False Then
            Me.View_PO_DBindingSource.Filter = "POID =" & Me.CMtxtPONo.Text & "And PODate = '" & Mydate & "'"
        ElseIf PONo = False And PODate = True And POMat = True Then
            Me.View_PO_DBindingSource.Filter = "PODate = '" & Mydate & "' And L4Name like '" & Me.CMtxtMatName.Text & "%'"
        ElseIf PONo = False And PODate = False And POMat = True Then
            Me.View_PO_DBindingSource.Filter = "L4Name like '" & Me.CMtxtMatName.Text & "%'"
        ElseIf PONo = False And PODate = True And POMat = False Then
            Try
                Mydate = CDate("#" & CMtxtDate.Text & "#")
                Me.View_PO_DBindingSource.Filter = "PODate = '" & Mydate & "'"
            Catch ex As Exception
                MsgBox("Enter The Correct Date Formate.")
            End Try
        End If
        CMtxtPONo.Text = "Select PONO"
        CMtxtDate.Text = "Select PO Date"
        CMtxtMatName.Text = "Select Mat Name"
        CMtxtPONo.ForeColor = Color.Silver
        CMtxtDate.ForeColor = Color.Silver
        CMtxtMatName.ForeColor = Color.Silver
        Me.CMFilter.Hide()
    End Sub
    Dim POFlag As Boolean = False
    Dim MatFlag As Boolean = False
    Dim DateFlag As Boolean = False
    Private Sub CMtxtPONo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtPONo.GotFocus
        If CMtxtPONo.Text = "Select PONO" Then
            CMtxtPONo.Text = ""
            POflag = True
            CMtxtPONo.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CMtxtPONo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtPONo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Data()
            Try
                ContextManueFilter(PO, PODate, POMat)
            Catch ex As Exception
            End Try
            CMtxtPONo.Text = "Select PONO"
            POFlag = False
            CMtxtPONo.ForeColor = Color.Silver
            Me.CMFilter.Hide()
        End If
    End Sub

    Private Sub CMtxtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtDate.GotFocus
        'Select PO Date
        If CMtxtDate.Text = "Select PO Date" Then
            CMtxtDate.Text = ""
            dateFlag = True
            CMtxtDate.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CMtxtMatName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtMatName.GotFocus

        If CMtxtMatName.Text = "Select Mat Name" Then
            CMtxtMatName.Text = ""
            MatFlag = True
            CMtxtMatName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CMtxtPONo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtPONo.LostFocus
        If CMtxtPONo.Text = "" Then
            CMtxtPONo.Text = "Select PONO"
            POFlag = False
            CMtxtPONo.ForeColor = Color.Silver
        End If
    End Sub
    Dim PO, PODate, POMat As Boolean
    Private Sub Data()
        If CMtxtPONo.Text = "Select PONO" Then
            PO = False
        Else
            'CMtxtPONo.Text = "Select PONO"
            PO = True
        End If
        If CMtxtDate.Text = "Select PO Date" Then
            PODate = False
        Else
            'CMtxtDate.Text = "Select PO Date"
            PODate = True
        End If
        If CMtxtMatName.Text = "Select Mat Name" Then
            POMat = False
        Else
            'CMtxtMatName.Text = "Select Mat Name"
            POMat = True
        End If
    End Sub
    Private Sub CMtxtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Data()
            Try
                ContextManueFilter(PO, PODate, POMat)
            Catch ex As Exception
            End Try
            CMtxtDate.Text = "Select PO Date"
            DateFlag = False
            CMtxtDate.ForeColor = Color.Silver
        End If
     
    End Sub

    Private Sub CMtxtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtDate.LostFocus
        If CMtxtDate.Text = "" Then
            CMtxtDate.Text = "Select PO Date"
            DateFlag = True
            CMtxtDate.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub CMtxtMatName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtMatName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Data()
            Try
                ContextManueFilter(PO, PODate, POMat)
                CMtxtMatName.Text = "Select Mat Name"
                CMtxtMatName.ForeColor = Color.Silver
                Me.CMFilter.Hide()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub CMtxtMatName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtMatName.LostFocus
        If CMtxtMatName.Text = "" Then
            CMtxtMatName.Text = "Select Mat Name"
            MatFlag = True
            CMtxtMatName.ForeColor = Color.Silver
        End If
    End Sub



    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.View_PO_DBindingSource.RemoveFilter()
    End Sub

    Private Sub View_Inv_Tran_InDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Inv_Tran_InDataGridView.CellContentClick
        If e.ColumnIndex = 7 Then
            Dim btnMsg As DialogResult
            btnMsg = MessageBox.Show("Are You Sure Want To Undo Material Entry?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Me.View_Inv_Tran_InTableAdapter.DeleteQuery(Me.View_Inv_Tran_InDataGridView(0, e.RowIndex).Value)
                Me.Tbl_Inv_Tran_InTableAdapter.UpdateQuery2(Nothing, Me.View_Inv_Tran_InDataGridView(2, e.RowIndex).Value, Me.View_Inv_Tran_InDataGridView(8, e.RowIndex).Value)
                Me.View_PO_DTableAdapter.Fill(Me.DSAutoPOIN.View_PO_D)
                Try
                    Me.View_Inv_Tran_InTableAdapter.Fill(Me.DSAutoPOIN.View_Inv_Tran_In, Me.DayNoLabel1.Text)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
End Class