Public Class frmMatReq
    Public Shared PartialQty As Double
    Public Shared flag As Boolean = False
    Private Sub frmMatReq_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub
    Dim Adminflag As Boolean = False
    Private Sub frmMatReq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRequisition.View_Requisition_Date' table. You can move, or remove it, as needed.
        If Me.View_Requisition_DateTableAdapter.Fill(Me.DSRequisition.View_Requisition_Date) > 0 Then
            For k As Integer = 0 To Me.View_Requisition_DateBindingSource.Count - 1
                Me.View_Requisition_DateTableAdapter.UpdateQuery(Now.Date, Me.DSRequisition.View_Requisition_Date.Rows(k).Item("ReqID"))
            Next
        End If

        Try
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DsSaleIssuence.tbl_Inv_Rack_Info)
        Catch ex As Exception

        End Try
        If frmLoginVer.DeptID = 1 Then
            Adminflag = True
            Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DSRequisition.tbl_Inv_Tran_Date)
            Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Else
            Adminflag = False
            Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DSRequisition.tbl_Inv_Tran_Date)
            Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        End If
        If TabControl1.SelectedTab.Text = "Internal Requisition" Then
            Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Requisition)
            Try
                Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Me.DayNoLabel.Text)
            Catch ex As Exception
            End Try
            Me.CMtxtMP.Text = "Enter Master Plan No."
            CMtxtMP.ForeColor = Color.Silver
            MPText("Enter Master Plan No.")
        End If
        KeyPreview = True
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Timer1.Start()
    End Sub
    Private Shared MatBalance As Double
    Private Shared Qty, ReqBal As Double
    Private Shared DayNo, CPPU1, PrdLine, CustomerId, POH, POMNo, PODNo, ReqValue As Integer
    Private Shared Currency1, MaterialName As String
    Private Shared TranType As String = Nothing
    Private Shared ReqNo As Integer = 0
    Private Shared Code As String = Nothing
    Private Shared Unit1 As String = Nothing
    Private Shared RackNo1 As Integer = 0
    Dim Excepflag As Boolean = False
    Dim BatchNo As String = Nothing
    Sub RefreshPO()
        If Excepflag = False Then
            Me.View_inv_Requisition_POTableAdapter.Fill(Me.DSRequisition.View_inv_Requisition_PO)
            Me.View_Tran_Out1TableAdapter.Fill(Me.DSRequisition.View_Tran_Out1, Me.DayNoLabel.Text)
            Try
                'Me.Proc_MM_Inv_BalTableAdapter.FillBy(Me.DSRequisition.Proc_MM_Inv_Bal, Code)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedTab.Text = "Internal Requisition" Then
            Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Requisition)
            Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Me.DayNoLabel.Text)
            Me.CMtxtMP.Text = "Enter Master Plan No."
            CMtxtMP.ForeColor = Color.Silver
            MPText("Enter Master Plan No.")
        ElseIf TabControl1.SelectedTab.Text = "External Requisition" Then
            Try
                Me.View_Inv_Requisition_CustTableAdapter.Fill(Me.DSRequisition.View_Inv_Requisition_Cust)
            Catch ex As Exception
            End Try
            Me.View_Tran_OutTableAdapter.Fill(Me.DSRequisition.View_Tran_Out, DayNoLabel.Text)
            Me.CMtxtMP.Text = "Enter Master Plan No."
            CMtxtMP.ForeColor = Color.Silver
            MPText("Enter Master Plan No.")
        ElseIf TabControl1.SelectedTab.Text = "PO Wise Requisition" Then
            Me.View_inv_Requisition_POTableAdapter.Fill(Me.DSRequisition.View_inv_Requisition_PO)
            Me.View_Tran_Out1TableAdapter.Fill(Me.DSRequisition.View_Tran_Out1, Me.DayNoLabel.Text)
            Me.CMtxtMP.Text = "Enter Page Ref. No."
            CMtxtMP.ForeColor = Color.Silver
            MPText("Enter Page Ref. No.")
        End If
    End Sub
    Public Sub InsertQty()
        Try
            If PartialQty < Qty And PartialQty <> 0 Then
                If PartialQty < MatBalance Then
                    If CustomerId > 0 Then
                        Try
                            Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MSGP", ReqNo, Code, PartialQty, Nothing, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, CustomerId, RackNo1, BatchNo)
                        Catch ex As Exception
                        End Try
                    ElseIf POH > 1 And POMNo > 1 Then
                        Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, PartialQty, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, POH, POMNo, PODNo, Nothing, RackNo1, BatchNo)
                    Else
                        Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, PartialQty, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing, RackNo1, BatchNo)
                    End If
                Else
                    Msgflag = True
                    If CustomerId > 0 Then
                        Try
                            Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MSGP", ReqNo, Code, MatBalance, Nothing, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, CustomerId, RackNo1, BatchNo)
                        Catch ex As Exception
                        End Try
                    ElseIf POH > 1 Then
                        Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, MatBalance, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, POH, POMNo, PODNo, Nothing, RackNo1, BatchNo)
                    Else
                        Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, MatBalance, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing, RackNo1, BatchNo)
                    End If
                End If
            Else
                MsgBox("Partial Quantity Should Less Than Balance Quantity ", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Excepflag = True
            If CustomerId > 0 Then
                RefreshExternalReq()
            ElseIf POH > 0 Then
                RefreshPO()
            Else
                RefreshInternalReq()
            End If
            Excepflag = False
        End Try
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
            Dim ObjPartialQty As New FrmPartialQty
            FrmPartialQty.Size = New System.Drawing.Size(381, 131)
            ObjPartialQty.Show()
            ObjPartialQty.PartialQtyTextBox.Focus()
        End If
    End Sub
    Sub RefreshInternalReq()
        If Excepflag = False Then
            Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Requisition)
            Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Val(Me.DayNoLabel.Text))
            Try
                'Me.Proc_MM_Inv_BalTableAdapter.FillBy(Me.DSRequisition.Proc_MM_Inv_Bal, Code)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Shared Msgflag As Boolean = False
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Msgflag = True Then
            Msgflag = False
            MsgBox("Partial Quantity Is Greater Than Available Material Balance", MsgBoxStyle.Information)
        End If
        If flag = True Then
            If CustomerId > 0 Then
                RefreshExternalReq()
            ElseIf POH > 0 Then
                RefreshPO()
            Else
                RefreshInternalReq()
            End If
            flag = False
        End If
    End Sub
    Private Sub Tbl_Inv_RequisitionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_RequisitionDataGridView.CellContentClick
        DayNo = Val(Me.DayNoLabel.Text)
        Try
            Code = Me.Tbl_Inv_RequisitionDataGridView(6, e.RowIndex).Value
        Catch ex As Exception
        End Try

        If e.ColumnIndex = 19 Then
            ReqNo = Me.Tbl_Inv_RequisitionDataGridView(0, e.RowIndex).Value
            If ReqNo > 0 Then
                Qty = Me.Tbl_Inv_RequisitionDataGridView(13, e.RowIndex).Value
                Unit1 = Me.Tbl_Inv_RequisitionDataGridView(10, e.RowIndex).Value
                Try
                    Currency1 = Me.Tbl_Inv_RequisitionDataGridView(11, e.RowIndex).Value
                Catch ex As Exception
                    Currency1 = Nothing
                End Try
                Try
                    RackNo1 = Me.Tbl_Inv_RequisitionDataGridView(18, e.RowIndex).Value
                Catch ex As Exception
                    RackNo1 = Nothing
                End Try
                Try
                    CPPU1 = Me.Tbl_Inv_RequisitionDataGridView(12, e.RowIndex).Value
                Catch ex As Exception
                    CPPU1 = Nothing
                End Try
                Try
                    CustomerId = Me.Tbl_Inv_RequisitionDataGridView(17, e.RowIndex).Value
                Catch ex As Exception
                    CustomerId = Nothing
                End Try
                Try
                    POH = Me.Tbl_Inv_RequisitionDataGridView(14, e.RowIndex).Value
                Catch ex As Exception
                    POH = Nothing
                End Try
                Try
                    POMNo = Me.Tbl_Inv_RequisitionDataGridView(15, e.RowIndex).Value
                Catch ex As Exception
                    POMNo = Nothing
                End Try
                Try
                    PODNo = Me.Tbl_Inv_RequisitionDataGridView(16, e.RowIndex).Value
                Catch ex As Exception
                    PODNo = Nothing
                End Try
                If Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 1 Then  ' MLP - I    
                    PrdLine = 5
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 2 Or Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 27 Then ' QR - Free Hand    
                    PrdLine = 6
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 5 Then ' TM - I    
                    PrdLine = 10
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 15 Then ' RWPD - I    
                    PrdLine = 8
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 3 Then ' MLP+QR - I    
                    PrdLine = 5
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 4 Then ' QR+MLP - I    
                    PrdLine = 6
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 6 Then ' TM Carcass - I    
                    PrdLine = 10
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 13 Then ' QR+RND - I
                    PrdLine = 6
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 8 Or Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 23 Or Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 31 Then ' RND - I       
                    PrdLine = 9
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 16 Then ' TM-Star    
                    PrdLine = 59
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 20 Then ' TM-Euro    
                    PrdLine = 60
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 22 Then ' TM-Euro    
                    PrdLine = 58
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 28 Then ' AMW    
                    PrdLine = 112
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 30 Then ' DMCC    
                    PrdLine = 130
                ElseIf Me.Tbl_Inv_RequisitionDataGridView(3, e.RowIndex).Value = 33 Then ' DMCC    
                    PrdLine = 148
                Else
                    PrdLine = Nothing
                    TranType = Nothing
                End If
                MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(Code)
                If MatBalance > 0 Then
                    Dim btnMsg As DialogResult
                    Dim Dest As String = Me.Tbl_Inv_RequisitionDataGridView(4, e.RowIndex).Value.ToString.Trim
                    If Dest = "MLP+QR".Trim Then
                        Dest = "MLP"
                    ElseIf Dest = "QR+MLP".Trim Then
                        Dest = "QR+MLP"
                    End If

                    If Me.View_Inv_Tran_Temp_Out_tempTableAdapter.Fill(Me.DSRequisition.View_Inv_Tran_Temp_Out_temp, Code, Dest) > 0 Then
                        btnMsg = MessageBox.Show("This Material [ " & MaterialName & " ] is Pending For Adjustment " & vbCrLf & "Do You Want To Adjust ?.....", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        If btnMsg = Windows.Forms.DialogResult.No Then
                            TabControl2.SelectedIndex = 0
                            SaveRecord()
                        Else
                            TabControl2.SelectedIndex = 1
                        End If
                    Else
                        SaveRecord()
                    End If
                Else
                    MsgBox("Available Material Balance Is Nill", MsgBoxStyle.Critical)
                End If
            End If
        End If
        If e.ColumnIndex = 20 Then
            Dim btnMsg As DialogResult
            btnMsg = MessageBox.Show("Are you Sure Want To Cancel Material.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                btnMsg = MessageBox.Show("Are you Sure About The Action You Are Going To Perfom.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If btnMsg = Windows.Forms.DialogResult.Yes Then
                    ReqNo = Me.Tbl_Inv_RequisitionDataGridView(0, e.RowIndex).Value
                    Me.Tbl_Inv_RequisitionTableAdapter.UpdateCancelQuery(True, Now.Date, ReqNo)
                    Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Requisition)
                End If
            End If
        End If
    End Sub
    Sub SaveRecord()
        Try
            Dim btnMsg As DialogResult = MessageBox.Show("Are you Sure Want to Save Full Quantity.", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                If DayNo > 0 Then
                    If Qty <= MatBalance Then

                        If Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Tran_In, Code) > 0 Then
                            'For j As Int16 = 0 To Me.Tbl_Inv_Tran_InBindingSource.Count - 1
                            '    Dim Bal As Double
                            BatchNo = Me.DSRequisition.tbl_Inv_Tran_In.Rows(0).Item("batch")
                            '    If Qty <= CDbl(Me.DSRequisition.tbl_Inv_Tran_In.Rows(j).Item("Balance")) Then
                            '        Bal=
                            '        Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, Qty, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing, RackNo1, BatchNo) Then
                            '        Me.Tbl_Inv_Requisition_UpdateTableAdapter.Update(True, Now.Date, ReqNo)
                            '        PrdLine = Nothing
                            '        Exit For

                            '    End If

                            'Next
                            Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, Qty, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing, RackNo1, BatchNo)
                            Me.Tbl_Inv_Requisition_UpdateTableAdapter.Update(True, Now.Date, ReqNo)
                            PrdLine = Nothing
                        Else

                            Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, Qty, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing, RackNo1, Nothing)
                            Me.Tbl_Inv_Requisition_UpdateTableAdapter.Update(True, Now.Date, ReqNo)
                            PrdLine = Nothing
                        End If



                        RefreshInternalReq()
                    Else
                        MsgBox("Full Quantity Is Greater Than Available Material Balance", MsgBoxStyle.Information)
                        If Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Tran_In, Code) > 0 Then
                            BatchNo = Me.DSRequisition.tbl_Inv_Tran_In.Rows(0).Item("batch")
                            Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, MatBalance, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing, RackNo1, BatchNo)
                            PrdLine = Nothing
                            RefreshInternalReq()
                        Else
                            Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, MatBalance, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, Nothing, RackNo1, Nothing)
                            PrdLine = Nothing
                            RefreshInternalReq()
                        End If

                    End If
                Else
                    MsgBox("Set the Transaction Date.")
                End If
            ElseIf btnMsg = Windows.Forms.DialogResult.No Then
                frmMatReq.PartialMod()
            ElseIf btnMsg = Windows.Forms.DialogResult.Cancel Then
                btnMsg = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            RefreshInternalReq()
            Excepflag = False
        End Try
    End Sub
    Private Sub View_Inv_Requisition_CustDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Inv_Requisition_CustDataGridView.CellContentClick
        DayNo = Val(Me.DayNoLabel.Text)
        Try
            Code = Me.View_Inv_Requisition_CustDataGridView(6, e.RowIndex).Value
            If Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Tran_In, Code) > 0 Then
                BatchNo = Me.DSRequisition.tbl_Inv_Tran_In.Rows(0).Item("batchno")
            Else
                BatchNo = 0
            End If
        Catch ex As Exception
        End Try

        If e.ColumnIndex = 19 Then
            ReqNo = Me.View_Inv_Requisition_CustDataGridView(0, e.RowIndex).Value
            Try
                CPPU1 = Me.View_Inv_Requisition_CustDataGridView(11, e.RowIndex).Value
            Catch ex As Exception
                CPPU1 = 0
            End Try
            Try
                RackNo1 = Me.View_Inv_Requisition_CustDataGridView(18, e.RowIndex).Value
            Catch ex As Exception
                RackNo1 = 0
            End Try
            If CPPU1 > 0 Then
                MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(Code)
                Try
                    If MatBalance > 0 Then
                        If ReqNo > 0 Then
                            Qty = Me.View_Inv_Requisition_CustDataGridView(10, e.RowIndex).Value
                            Unit1 = Me.View_Inv_Requisition_CustDataGridView(13, e.RowIndex).Value
                            Try
                                Currency1 = Me.View_Inv_Requisition_CustDataGridView(14, e.RowIndex).Value
                            Catch ex As Exception
                                Currency1 = Nothing
                            End Try
                            POH = Nothing
                            Try
                                CustomerId = Me.View_Inv_Requisition_CustDataGridView(12, e.RowIndex).Value
                            Catch ex As Exception
                                CustomerId = Nothing
                            End Try
                            Dim btnMsg As DialogResult
                            btnMsg = MessageBox.Show("Are you Sure Want to Save Full Quantity.", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                            If btnMsg = Windows.Forms.DialogResult.Yes Then
                                If DayNo > 0 Then
                                    If Qty <= MatBalance Then
                                        Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MSGP", ReqNo, Code, Qty, Nothing, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, CustomerId, RackNo1, BatchNo)
                                        Me.Tbl_Inv_Requisition_UpdateTableAdapter.Update(True, Now.Date, ReqNo)
                                        RefreshExternalReq()
                                    Else
                                        MsgBox("Entered Quantity Is Greater Than Available Material Balance", MsgBoxStyle.Information)
                                        Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MSGP", ReqNo, Code, MatBalance, Nothing, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, CustomerId, RackNo1, BatchNo)
                                        RefreshExternalReq()
                                    End If
                                Else
                                    MsgBox("Set the Transaction Date.")
                                End If
                            ElseIf btnMsg = Windows.Forms.DialogResult.No Then
                                frmMatReq.PartialMod()
                            ElseIf btnMsg = Windows.Forms.DialogResult.Cancel Then
                                btnMsg = Windows.Forms.DialogResult.Cancel
                            End If
                        End If
                    Else
                        MsgBox("Material Available Balance Is Nill", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    RefreshExternalReq()
                    Excepflag = False
                End Try
            Else
                MsgBox("Enter Unit Price To Issue The Material", MsgBoxStyle.Information)
            End If
        Else
        End If
        If e.ColumnIndex = 20 Then
            Dim btnMsg As DialogResult
            btnMsg = MessageBox.Show("Are You Sure Want to Cancel Material.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                ReqNo = Me.View_Inv_Requisition_CustDataGridView(0, e.RowIndex).Value
                Me.Tbl_Inv_RequisitionTableAdapter.UpdateCancelQuery(True, Now.Date, ReqNo)
                Me.View_Inv_Requisition_CustTableAdapter.Fill(Me.DSRequisition.View_Inv_Requisition_Cust)
            End If
        End If
    End Sub
    Private Sub View_Inv_Tran_OutDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Inv_Tran_OutDataGridView.CellContentClick
        If e.ColumnIndex = 8 Then
            Dim Status As Integer
            Status = MsgBox("Are You Sure Want To  Undo It?....", MsgBoxStyle.YesNo)
            If (Status = 6) Then
                Dim Id As Integer = Nothing
                Dim ReqId As Integer = Nothing
                Id = Me.View_Inv_Tran_OutDataGridView(1, e.RowIndex).Value
                ReqId = Me.View_Inv_Tran_OutDataGridView(3, e.RowIndex).Value
                Me.Tbl_Inv_RequisitionTableAdapter.UpdateUndo(ReqId)
                Me.Tbl_Inv_Tran_OutTableAdapter.DeleteQuery(Id)
                RefreshInternalReq()
                MsgBox("Record Undo Successfully")
            End If
        Else
        End If
    End Sub
    Sub RefreshExternalReq()
        If Excepflag = False Then
            Me.View_Tran_OutTableAdapter.Fill(Me.DSRequisition.View_Tran_Out, Me.DayNoLabel.Text)
            Try
                Me.View_Inv_Requisition_CustTableAdapter.Fill(Me.DSRequisition.View_Inv_Requisition_Cust)
            Catch ex As Exception
            End Try
            Try
                'Me.Proc_MM_Inv_BalTableAdapter.FillBy(Me.DSRequisition.Proc_MM_Inv_Bal,  Code)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub View_Tran_OutDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Tran_OutDataGridView.CellContentClick
        If e.ColumnIndex = 8 Then
            Dim Status As Integer
            Status = MsgBox("Are You Sure  Want To Undo It.", MsgBoxStyle.YesNo)
            If (Status = 6) Then
                Dim Id As Integer = Nothing
                Dim ReqId As Integer = Nothing
                Id = Me.View_Tran_OutDataGridView(0, e.RowIndex).Value
                ReqId = Me.View_Tran_OutDataGridView(7, e.RowIndex).Value
                Me.Tbl_Inv_RequisitionTableAdapter.UpdateUndo(ReqId)
                Me.Tbl_Inv_Tran_OutTableAdapter.DeleteQuery(Id)
                RefreshExternalReq()
                MsgBox("Record Undo Successfully")
            End If
        Else
        End If
    End Sub

    Private Sub View_Tran_Out1DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Tran_Out1DataGridView.CellContentClick
        If e.ColumnIndex = 7 Then
            Dim Status As Integer
            Status = MsgBox("Are You Sure Want To  Undo It.", MsgBoxStyle.YesNo)
            If (Status = 6) Then
                Dim Id As Integer = Nothing
                Dim ReqId As Integer = Nothing
                Id = Me.View_Tran_Out1DataGridView(0, e.RowIndex).Value
                ReqId = Me.View_Tran_Out1DataGridView(2, e.RowIndex).Value
                Me.Tbl_Inv_RequisitionTableAdapter.UpdateUndo(ReqId)
                Me.Tbl_Inv_Tran_OutTableAdapter.DeleteQuery(Id)
                RefreshPO()
                MsgBox("Record Undo Successfully")
            End If
        Else
        End If
    End Sub

    Private Sub View_inv_Requisition_PODataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_inv_Requisition_PODataGridView.CellContentClick
        DayNo = Val(Me.DayNoLabel.Text)
        Try
            Code = Me.View_inv_Requisition_PODataGridView(7, e.RowIndex).Value
        Catch ex As Exception
        End Try
        If e.ColumnIndex = 19 Then
            ReqNo = Me.View_inv_Requisition_PODataGridView(0, e.RowIndex).Value
            If ReqNo > 0 Then
                Qty = Me.View_inv_Requisition_PODataGridView(14, e.RowIndex).Value
                Unit1 = Me.View_inv_Requisition_PODataGridView(11, e.RowIndex).Value
                Try
                    Currency1 = Me.View_inv_Requisition_PODataGridView(12, e.RowIndex).Value
                Catch ex As Exception
                    Currency1 = Nothing
                End Try
                Try
                    CPPU1 = Me.View_inv_Requisition_PODataGridView(13, e.RowIndex).Value
                Catch ex As Exception
                    CPPU1 = Nothing
                End Try
                CustomerId = Nothing
                Try
                    POH = Me.View_inv_Requisition_PODataGridView(3, e.RowIndex).Value
                Catch ex As Exception
                    POH = Nothing
                End Try
                Try
                    POMNo = Me.View_inv_Requisition_PODataGridView(15, e.RowIndex).Value
                Catch ex As Exception
                    POMNo = Nothing
                End Try
                Try
                    PODNo = Me.View_inv_Requisition_PODataGridView(16, e.RowIndex).Value
                Catch ex As Exception
                    PODNo = Nothing
                End Try
                Try
                    RackNo1 = Me.View_inv_Requisition_PODataGridView(18, e.RowIndex).Value
                Catch ex As Exception
                    RackNo1 = Nothing
                End Try
                If Me.View_inv_Requisition_PODataGridView(4, e.RowIndex).Value = 5 Then  ' TM-32    
                    PrdLine = 10
                ElseIf Me.View_inv_Requisition_PODataGridView(4, e.RowIndex).Value = 8 Then ' RND    
                    PrdLine = 9
                ElseIf Me.View_inv_Requisition_PODataGridView(4, e.RowIndex).Value = 15 Then ' RWPD
                    PrdLine = 8
                ElseIf Me.View_inv_Requisition_PODataGridView(4, e.RowIndex).Value = 16 Then ' TM-Star
                    PrdLine = 59
                ElseIf Me.View_inv_Requisition_PODataGridView(4, e.RowIndex).Value = 20 Then ' TM-Euro    
                    PrdLine = 60
                ElseIf Me.View_inv_Requisition_PODataGridView(4, e.RowIndex).Value = 30 Then ' TM-Euro    
                    PrdLine = 130
                Else
                    PrdLine = Nothing
                End If
                MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(Code)
                Try
                    If MatBalance > 0 Then
                        Dim btnMsg As DialogResult
                        btnMsg = MessageBox.Show("Are you Sure Want To Save Full Quantity.", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        If btnMsg = Windows.Forms.DialogResult.Yes Then
                            If DayNo > 0 Then
                                If Qty <= MatBalance Then
                                    Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, Qty, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, POH, POMNo, PODNo, Nothing, RackNo1, BatchNo)
                                    Me.Tbl_Inv_Requisition_UpdateTableAdapter.Update(True, Now.Date, ReqNo)
                                    PrdLine = Nothing
                                    RefreshPO()
                                Else
                                    MsgBox("Full Quantity Is Greater Than Available Material Balance", MsgBoxStyle.Information)
                                    Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MIR", ReqNo, Code, MatBalance, PrdLine, Nothing, ReqNo, Currency1, CPPU1, Unit1, POH, POMNo, PODNo, Nothing, RackNo1, BatchNo)
                                    PrdLine = Nothing
                                    RefreshPO()
                                End If
                            Else
                                MsgBox("Set the Transaction Date.")
                            End If
                        ElseIf btnMsg = Windows.Forms.DialogResult.No Then
                            frmMatReq.PartialMod()
                        ElseIf btnMsg = Windows.Forms.DialogResult.Cancel Then
                            btnMsg = Windows.Forms.DialogResult.Cancel
                        End If
                    Else
                        MsgBox("Material Available Balance Is Nill", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    RefreshPO()
                    Excepflag = False
                End Try
            End If
        End If
        If e.ColumnIndex = 20 Then
            Dim btnMsg As DialogResult
            btnMsg = MessageBox.Show("Are You Sure Want To Cancel Material.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                ReqNo = Me.View_inv_Requisition_PODataGridView(0, e.RowIndex).Value
                Me.Tbl_Inv_RequisitionTableAdapter.UpdateCancelQuery(True, Now.Date, ReqNo)
                Me.View_inv_Requisition_POTableAdapter.Fill(Me.DSRequisition.View_inv_Requisition_PO)
            End If
        End If
    End Sub
    Private Sub CMtxtPrdLine_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtPrdLine.GotFocus
        If CMtxtPrdLine.Text = "Enter Production Line" Then
            CMtxtPrdLine.Text = ""
            CMtxtPrdLine.ForeColor = Color.Black
        End If
    End Sub
    Sub ContexMenue()
        Me.CMtxtPrdLine.Text = "Enter Production Line"
        Me.CMtxtPrdLine.ForeColor = Color.Silver
        Me.CMtxtReqNo.Text = "Enter Requisition No."
        Me.CMtxtReqNo.ForeColor = Color.Silver
        Me.CMtxtMP.Text = Str
        Me.CMtxtMP.ForeColor = Color.Silver
        Me.CMtxtReqDate.Text = "Enter Required Date"
        Me.CMtxtReqDate.ForeColor = Color.Silver
        Me.CMtxtMatName.Text = "Enter Material Name"
        Me.CMtxtMatName.ForeColor = Color.Silver
        Me.CMMatReq.Hide()
    End Sub

    Private Sub CMtxtPrdLine_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtPrdLine.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CMtxtPrdLine.TextLength > 18 Then
                CMtxtPrdLine.Text = Nothing
            End If
            If CMtxtReqNo.TextLength > 15 Then
                CMtxtReqNo.Text = 0
            End If
            If CMtxtMP.TextLength > 15 Then
                CMtxtMP.Text = 0
            End If
            If CMtxtReqDate.TextLength > 15 Then
                CMtxtReqDate.Text = Nothing
            End If
            If CMtxtMatName.TextLength > 18 Then
                CMtxtMatName.Text = Nothing
            End If
            Try
                ContextManueFilter(CMtxtPrdLine.Text, CMtxtReqNo.Text, CMtxtMP.Text, CMtxtReqDate.Text, CMtxtMatName.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub CMtxtPrdLine_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMtxtPrdLine.KeyPress
        'To Enter Only Alphabet in The Text Box
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub CMtxtPrdLine_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtPrdLine.LostFocus
        If CMtxtPrdLine.Text = "" Then
            CMtxtPrdLine.Text = "Enter Production Line"
            CMtxtPrdLine.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub CMtxtReqNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtReqNo.GotFocus
        If CMtxtReqNo.Text = "Enter Requisition No." Then
            CMtxtReqNo.Text = ""
            CMtxtReqNo.ForeColor = Color.Black
        End If
    End Sub
    Dim Dateflag As Boolean = False
    Sub ContextManueFilter(ByVal PrdLine As String, ByVal ReqNo1 As Integer, ByVal MP As Integer, ByVal ReqDate As String, ByVal MatName As String)
        Dim Mydate As System.DateTime
        If Not ReqDate = Nothing Then
            Try
                Mydate = CDate("#" & ReqDate & "#")
            Catch ex As Exception
                MsgBox("Enter The Correct Date Formate.")
            End Try
            Dateflag = True
        End If
        ContexMenue()
        'For Internal Requisition
        If TabControl1.SelectedTab.Text = "Internal Requisition" Then
            If Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = False And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP = 0 And Dateflag = False And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & ""
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = False And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & "And MPID=" & MP & ""
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & "And MPID=" & MP & "And RequiredDate='" & Mydate & "'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And MPID=" & MP & " And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "' And RequiredDate='" & Mydate & "'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = False And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP = 0 And Dateflag = False And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "Reqid=" & ReqNo1 & " "
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = False And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "Reqid=" & ReqNo1 & " And MPID=" & MP & ""
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "Reqid=" & ReqNo1 & " And MPID=" & MP & " And RequiredDate='" & Mydate & "'"
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "Reqid=" & ReqNo1 & " And MPID=" & MP & " And RequiredDate='" & Mydate & "'And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = False And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "MPID=" & MP & " "
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "MPID=" & MP & " And RequiredDate='" & Mydate & "'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "MPID=" & MP & " And RequiredDate='" & Mydate & "'And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = " RequiredDate='" & Mydate & "'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = " RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = False And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'And MPID=" & MP & " And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = False And Not MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And MPID=" & MP & " And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.Tbl_Inv_RequisitionBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And MPID=" & MP & " And RequiredDate='" & Mydate & "'"
            End If
            'For External Requisition
            InternalReq()
        ElseIf TabControl1.SelectedTab.Text = "External Requisition" Then
            If Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = False And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP = 0 And Dateflag = False And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & ""
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = False And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & "And MPID=" & MP & ""
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & "And MPID=" & MP & "And RequiredDate='" & Mydate & "'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And MPID=" & MP & " And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "' And RequiredDate='" & Mydate & "'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = False And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP = 0 And Dateflag = False And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "Reqid=" & ReqNo1 & " "
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = False And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "Reqid=" & ReqNo1 & " And MPID=" & MP & ""
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "Reqid=" & ReqNo1 & " And MPID=" & MP & " And RequiredDate='" & Mydate & "'"
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "Reqid=" & ReqNo1 & " And MPID=" & MP & " And RequiredDate='" & Mydate & "'And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = False And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "MPID=" & MP & " "
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "MPID=" & MP & " And RequiredDate='" & Mydate & "'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "MPID=" & MP & " And RequiredDate='" & Mydate & "'And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = " RequiredDate='" & Mydate & "'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = " RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = False And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'And MPID=" & MP & " And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = False And Not MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And MPID=" & MP & " And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.View_Inv_Requisition_CustBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And MPID=" & MP & " And RequiredDate='" & Mydate & "'"
            End If
            ExternalReq()
            'For PO Wise Requisition
        ElseIf TabControl1.SelectedTab.Text = "PO Wise Requisition" Then
            If Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = False And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP = 0 And Dateflag = False And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & ""
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = False And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & "And PO=" & MP & ""
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & "And PO=" & MP & "And RequiredDate='" & Mydate & "'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And PO=" & MP & " And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "' And RequiredDate='" & Mydate & "'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = False And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP = 0 And Dateflag = False And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "Reqid=" & ReqNo1 & " "
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = False And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "Reqid=" & ReqNo1 & " And PO=" & MP & ""
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "Reqid=" & ReqNo1 & " And PO=" & MP & " And RequiredDate='" & Mydate & "'"
            ElseIf PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "Reqid=" & ReqNo1 & " And PO=" & MP & " And RequiredDate='" & Mydate & "'And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = False And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PO=" & MP & " "
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PO=" & MP & " And RequiredDate='" & Mydate & "'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PO=" & MP & " And RequiredDate='" & Mydate & "'And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = " RequiredDate='" & Mydate & "'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = " RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf PrdLine = "" And ReqNo1 = 0 And MP = 0 And Dateflag = False And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 = 0 And MP > 0 And Dateflag = True And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'And PO=" & MP & " And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP = 0 And Dateflag = True And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And RequiredDate='" & Mydate & "' And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = False And Not MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And PO=" & MP & " And L4name like'%" & MatName & "%'"
            ElseIf Not PrdLine = "" And ReqNo1 > 0 And MP > 0 And Dateflag = True And MatName = "" Then
                Me.View_inv_Requisition_POBindingSource.Filter = "PrdlineName='" & PrdLine & "'And Reqid=" & ReqNo1 & " And PO=" & MP & " And RequiredDate='" & Mydate & "'"
            End If
            PORequisition()
            Dateflag = False
        End If
    End Sub
    Private Sub CMtxtReqNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtReqNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CMtxtPrdLine.TextLength > 18 Then
                CMtxtPrdLine.Text = Nothing
            End If
            If CMtxtReqNo.TextLength > 15 Then
                CMtxtReqNo.Text = 0
            End If
            If CMtxtMP.TextLength > 15 Then
                CMtxtMP.Text = 0
            End If
            If CMtxtReqDate.TextLength > 15 Then
                CMtxtReqDate.Text = Nothing
            End If
            If CMtxtMatName.TextLength > 18 Then
                CMtxtMatName.Text = Nothing
            End If
            Try
                ContextManueFilter(CMtxtPrdLine.Text, CMtxtReqNo.Text, CMtxtMP.Text, CMtxtReqDate.Text, CMtxtMatName.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub CMtxtReqNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMtxtReqNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CMtxtReqNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtReqNo.LostFocus
        If CMtxtReqNo.Text = "" Then
            CMtxtReqNo.Text = "Enter Requisition No."
            CMtxtReqNo.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If TabControl1.SelectedTab.Text = "Internal Requisition" Then
            Me.Tbl_Inv_RequisitionBindingSource.RemoveFilter()
        ElseIf TabControl1.SelectedTab.Text = "PO Wise Requisition" Then
            Me.View_inv_Requisition_POBindingSource.RemoveFilter()
        ElseIf TabControl1.SelectedTab.Text = "External Requisition" Then
            Me.View_Inv_Requisition_CustBindingSource.RemoveFilter()
        End If
    End Sub
    Sub ToRefresh()
        If TabControl1.SelectedTab.Text = "Internal Requisition" Then
            Dim Position As Integer = Me.Tbl_Inv_RequisitionBindingSource.Position
            Me.Tbl_Inv_RequisitionBindingSource.RemoveFilter()
            Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Requisition)
            Try
                Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Me.DayNoLabel.Text)
            Catch ex As Exception
            End Try
            Me.Tbl_Inv_RequisitionBindingSource.Position = Position
        ElseIf TabControl1.SelectedTab.Text = "PO Wise Requisition" Then
            Dim Position As Integer = Me.View_inv_Requisition_POBindingSource.Position
            Me.View_inv_Requisition_POBindingSource.RemoveFilter()
            Me.View_inv_Requisition_POTableAdapter.Fill(Me.DSRequisition.View_inv_Requisition_PO)
            Try
                Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Me.DayNoLabel.Text)
            Catch ex As Exception
            End Try
            Me.View_inv_Requisition_POBindingSource.Position = Position
        ElseIf TabControl1.SelectedTab.Text = "External Requisition" Then
            Dim Position As Integer = Me.View_Inv_Requisition_CustBindingSource.Position
            Me.View_Inv_Requisition_CustBindingSource.RemoveFilter()
            Me.View_Inv_Requisition_CustTableAdapter.Fill(Me.DSRequisition.View_Inv_Requisition_Cust)
            Try
                Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Me.DayNoLabel.Text)
            Catch ex As Exception
            End Try
            Me.View_Inv_Requisition_CustBindingSource.Position = Position
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ToRefresh()
    End Sub
    Private Sub CMtxtReqDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtReqDate.GotFocus
        If CMtxtReqDate.Text = "Enter Required Date" Then
            CMtxtReqDate.Text = ""
            CMtxtReqDate.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CMtxtReqDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtReqDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CMtxtPrdLine.TextLength > 18 Then
                CMtxtPrdLine.Text = Nothing
            End If
            If CMtxtReqNo.TextLength > 15 Then
                CMtxtReqNo.Text = 0
            End If
            If CMtxtMP.TextLength > 15 Then
                CMtxtMP.Text = 0
            End If
            If CMtxtReqDate.TextLength > 15 Then
                CMtxtReqDate.Text = Nothing
            End If
            If CMtxtMatName.TextLength > 18 Then
                CMtxtMatName.Text = Nothing
            End If
            Try
                ContextManueFilter(CMtxtPrdLine.Text, CMtxtReqNo.Text, CMtxtMP.Text, CMtxtReqDate.Text, CMtxtMatName.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub CMtxtMatName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtMatName.GotFocus
        If CMtxtMatName.Text = "Enter Material Name" Then
            CMtxtMatName.Text = ""
            CMtxtMatName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CMtxtMatName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtMatName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CMtxtPrdLine.TextLength > 18 Then
                CMtxtPrdLine.Text = Nothing
            End If
            If CMtxtReqNo.TextLength > 15 Then
                CMtxtReqNo.Text = 0
            End If
            If CMtxtMP.TextLength > 15 Then
                CMtxtMP.Text = 0
            End If
            If CMtxtReqDate.TextLength > 15 Then
                CMtxtReqDate.Text = Nothing
            End If
            If CMtxtMatName.TextLength > 18 Then
                CMtxtMatName.Text = Nothing
            End If
            Try
                ContextManueFilter(CMtxtPrdLine.Text, CMtxtReqNo.Text, CMtxtMP.Text, CMtxtReqDate.Text, CMtxtMatName.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub CMtxtMatName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMtxtMatName.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub CMtxtMatName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtMatName.LostFocus
        If CMtxtMatName.Text = "" Then
            CMtxtMatName.Text = "Enter Material Name"
            CMtxtMatName.ForeColor = Color.Silver
        End If
    End Sub
    Dim Str As String = Nothing
    Sub MPText(ByVal Text As String)
        Str = Text
    End Sub
    Private Sub CMtxtMP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtMP.GotFocus
        If CMtxtMP.Text = Str Then
            CMtxtMP.Text = ""
            CMtxtMP.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CMtxtMP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtMP.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CMtxtPrdLine.TextLength > 18 Then
                CMtxtPrdLine.Text = Nothing
            End If
            If CMtxtReqNo.TextLength > 15 Then
                CMtxtReqNo.Text = 0
            End If
            If CMtxtMP.TextLength > 15 Then
                CMtxtMP.Text = 0
            End If
            If CMtxtReqDate.TextLength > 15 Then
                CMtxtReqDate.Text = Nothing
            End If
            If CMtxtMatName.TextLength > 18 Then
                CMtxtMatName.Text = Nothing
            End If
            Try
                ContextManueFilter(CMtxtPrdLine.Text, CMtxtReqNo.Text, CMtxtMP.Text, CMtxtReqDate.Text, CMtxtMatName.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub CMtxtMP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMtxtMP.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CMtxtMP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtMP.LostFocus
        If CMtxtMP.Text = "" Then
            CMtxtMP.Text = Str
            CMtxtMP.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub CMtxtReqDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMtxtReqDate.KeyPress
        If Not e.KeyChar = "/" And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CMtxtReqDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtReqDate.LostFocus
        If CMtxtReqDate.Text = "" Then
            CMtxtReqDate.Text = "Enter Required Date"
            CMtxtReqDate.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub CMtxtReqDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtReqDate.TextChanged
        If CMtxtReqDate.TextLength = 2 Then
            CMtxtReqDate.Text = String.Concat(CMtxtReqDate.Text, "/")
            CMtxtReqDate.Select(3, CMtxtReqDate.Text.Length)
        End If
        If CMtxtReqDate.TextLength = 5 Then
            CMtxtReqDate.Text = String.Concat(CMtxtReqDate.Text, "/")
            CMtxtReqDate.Select(6, CMtxtReqDate.Text.Length)
        End If
        If CMtxtReqDate.TextLength = 8 Then
            Me.CMtxtReqDate.Select(9, CMtxtReqDate.TextLength)
        End If
    End Sub

    Private Sub Tbl_Inv_RequisitionDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_RequisitionDataGridView.CellEnter
        ReqValue = Me.Tbl_Inv_RequisitionDataGridView(0, e.RowIndex).Value
        ReqBal = Me.Tbl_Inv_RequisitionDataGridView(13, e.RowIndex).Value
        MaterialName = Me.Tbl_Inv_RequisitionDataGridView(7, e.RowIndex).Value
        Dim Dest As String = Me.Tbl_Inv_RequisitionDataGridView(4, e.RowIndex).Value.ToString.Trim
        If Dest = "MLP+QR".Trim Then
            Dest = "MLP"
        ElseIf Dest = "QR+MLP" Then
            Dest = "QR+MLP"
        End If
        Me.View_Inv_Tran_Temp_OutTableAdapter.Fill(Me.DSRequisition.View_Inv_Tran_Temp_Out, Me.Tbl_Inv_RequisitionDataGridView(6, e.RowIndex).Value, Dest)
    End Sub

    Private Sub Tbl_Inv_RequisitionDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_RequisitionDataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_RequisitionDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_RequisitionDataGridView.RowLeave
        InternalReq()
    End Sub
    Private Sub View_Inv_Requisition_CustDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_Inv_Requisition_CustDataGridView.DataError

    End Sub

    Private Sub View_Inv_Requisition_CustDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Inv_Requisition_CustDataGridView.RowLeave
        ExternalReq()
    End Sub

    Private Sub View_inv_Requisition_PODataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_inv_Requisition_PODataGridView.RowLeave
        PORequisition()
    End Sub

    Private Sub View_Inv_Requisition_CustDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles View_Inv_Requisition_CustDataGridView.RowsAdded
        ExternalReq()
    End Sub

    Private Sub View_inv_Requisition_PODataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles View_inv_Requisition_PODataGridView.RowsAdded
        PORequisition()
    End Sub
    Sub InternalReq()
        Dim i As Integer
        Dim TotalReqQty, TotalBalanceQty As Double
        If Tbl_Inv_RequisitionDataGridView.RowCount > 0 Then
            For i = 0 To Me.Tbl_Inv_RequisitionDataGridView.RowCount - 1
                TotalReqQty += Val(Me.Tbl_Inv_RequisitionDataGridView(8, i).Value)
                TotalBalanceQty += Val(Me.Tbl_Inv_RequisitionDataGridView(13, i).Value)
            Next
            TotalInternalReqQtyLabel.Text = TotalReqQty
            TotalInternalBalanceQtylabel.Text = TotalBalanceQty
        Else
            TotalInternalReqQtyLabel.Text = 0
            TotalInternalBalanceQtylabel.Text = 0
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    'Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    '    Dim btnMsg As DialogResult

    '    btnMsg = MessageBox.Show("Are You Sure Want To Issue All Materials?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    '    If btnMsg = Windows.Forms.DialogResult.Yes Then
    '        For k As Int16 = 0 To Me.Tbl_Inv_RequisitionDataGridView.Rows.Count - 1
    '            'View_New_Demands_BalanceTableAdapter.InsertQuery("MID", GMNoComboBox.SelectedValue, Me.View_New_Demands_BalanceDataGridView.Item(9, k).Value.ToString, CDbl(Me.View_New_Demands_BalanceDataGridView.Item(6, k).Value), Me.View_New_Demands_BalanceDataGridView.Item(10, k).Value, Me.View_New_Demands_BalanceDataGridView.Item(15, k).Value.ToString, Me.View_New_Demands_BalanceDataGridView.Item(5, k).Value, Me.DayNoLabel1.Text, CInt(Me.View_New_Demands_BalanceDataGridView.Item(0, k).Value), GMNoComboBox.SelectedValue, UserID, CDbl(Me.View_New_Demands_BalanceDataGridView.Item(13, k).Value))
    '            'Me.View_Issued_demandsTableAdapter.UpdateQuery(CInt(Me.View_New_Demands_BalanceDataGridView.Item(0, k).Value))
    '            Me.Tbl_Inv_Tran_OutTableAdapter.Insert(DayNo, "MSGP", ReqNo, Code, Qty, Nothing, Nothing, ReqNo, Currency1, CPPU1, Unit1, Nothing, Nothing, Nothing, CustomerId, RackNo1, BatchNo)
    '            Me.Tbl_Inv_Requisition_UpdateTableAdapter.Update(True, Now.Date, ReqNo)



    '        Next
    '        Me.View_New_Demands_BalanceTableAdapter.Fill(Me.DSdemands.view_New_Demands_Balance, GMNoComboBox.Text)
    '        Try
    '            Me.View_Issued_demandsTableAdapter.Fill(Me.DSdemands.View_Issued_demands, DayNoLabel1.Text)
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    Sub PORequisition()
        Dim i As Integer
        Dim TotalReqQty, TotalBalanceQty As Double
        If View_inv_Requisition_PODataGridView.RowCount > 0 Then
            For i = 0 To Me.View_inv_Requisition_PODataGridView.RowCount - 1
                TotalReqQty += Val(Me.View_inv_Requisition_PODataGridView(9, i).Value)
                TotalBalanceQty += Val(View_inv_Requisition_PODataGridView(14, i).Value)
            Next
            TotalPOReqQtyLabel.Text = TotalReqQty
            TotalPOBalanceQtylabel.Text = TotalBalanceQty
        Else
            TotalPOReqQtyLabel.Text = 0
            TotalPOBalanceQtylabel.Text = 0
        End If
    End Sub
    Sub ExternalReq()
        Dim i As Integer
        Dim TotalReqQty, TotalBalanceQty As Double
        If View_Inv_Requisition_CustDataGridView.RowCount > 0 Then
            For i = 0 To Me.View_Inv_Requisition_CustDataGridView.RowCount - 1
                TotalReqQty += Val(Me.View_Inv_Requisition_CustDataGridView(8, i).Value)
                TotalBalanceQty += Val(Me.View_Inv_Requisition_CustDataGridView(10, i).Value)
            Next
            TotalExternalReqQtyLabel.Text = TotalReqQty
            TotalExternalBalanceQtylabel.Text = TotalBalanceQty
        Else
            TotalExternalReqQtyLabel.Text = 0
            TotalExternalBalanceQtylabel.Text = 0
        End If
    End Sub
    Private Sub Tbl_Inv_RequisitionDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Tbl_Inv_RequisitionDataGridView.RowsAdded
        InternalReq()
    End Sub

    Private Sub View_Inv_Tran_Temp_OutDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Inv_Tran_Temp_OutDataGridView.CellContentClick
        If e.ColumnIndex = 7 Then
            If ReqValue > 0 Then
                If CDbl(View_Inv_Tran_Temp_OutDataGridView(5, e.RowIndex).Value) <= ReqBal Then
                    Dim btnMsg As DialogResult = MessageBox.Show("Are you Sure Want To Adjust [" & MaterialName & "] Material Of Requisition No.[" & ReqValue & "]", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    If btnMsg = Windows.Forms.DialogResult.Yes Then
                        Dim Position As Integer = Me.Tbl_Inv_RequisitionBindingSource.Position
                        Try
                            Me.View_Inv_Tran_Temp_OutTableAdapter.UpdateQuery(ReqValue, ReqValue, View_Inv_Tran_Temp_OutDataGridView(0, e.RowIndex).Value, View_Inv_Tran_Temp_OutDataGridView(3, e.RowIndex).Value)
                            If ReqBal = CDbl(View_Inv_Tran_Temp_OutDataGridView(5, e.RowIndex).Value) Then
                                Me.Tbl_Inv_Requisition_UpdateTableAdapter.Update(True, Now.Date, ReqValue)
                            End If
                            Me.Tbl_Inv_RequisitionTableAdapter.Fill(Me.DSRequisition.tbl_Inv_Requisition)
                            Try
                                Me.Proc_MM_Inv_BalTableAdapter.FillBy(Me.DSRequisition.Proc_MM_Inv_Bal, View_Inv_Tran_Temp_OutDataGridView(3, e.RowIndex).Value)
                            Catch ex As Exception
                            End Try
                            Me.View_Inv_Tran_Temp_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Temp_Out)
                        Catch ex As Exception
                        End Try
                        Me.Tbl_Inv_RequisitionBindingSource.Position = Position
                        ReqValue = 0
                    Else
                        MsgBox("Material Not Adjusted")
                    End If
                Else
                    MsgBox("Requisition Balance Is Less Than Adjusted Quantity")
                End If
            Else
                MsgBox("Select Requisition No. To Adjust Material")
            End If
        End If
    End Sub
    Private Sub ReqDateTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TranDate.GotFocus
        If Me.TranDate.Text = "Enter Transaction Date" Then
            Me.TranDate.Text = ""
            Me.TranDate.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ReqDateTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TranDate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.Tbl_Inv_Tran_DateBindingSource.Filter = "DateName ='" & Me.TranDate.Text & "'"
                Me.TranDate.Clear()
                Me.CMReqDate.Hide()
                Tbl_Inv_Tran_DateBindingSource_PositionChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox("Enter Date In Correct Formate")
            Me.TranDate.Clear()
            Me.TranDate.Focus()
        End Try
    End Sub

    Private Sub ReqDateTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TranDate.LostFocus
        If Me.TranDate.TextLength = 0 Then
            Me.TranDate.Text = "Enter Transaction Date"
            Me.TranDate.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
            Me.View_Inv_Tran_OutTableAdapter.FillBy(Me.DSRequisition.View_Inv_Tran_Out, Me.DayNoLabel.Text)
            If Adminflag = True Then
            Else
                If Me.Label4.Text = Now.Date Then
                    Me.Panel2.Enabled = True
                    Me.Panel5.Enabled = True
                    Me.Panel7.Enabled = True
                Else
                    Me.Panel2.Enabled = False
                    Me.Panel5.Enabled = False
                    Me.Panel7.Enabled = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Tbl_Inv_Tran_DateBindingSource.RemoveFilter()
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Tbl_Inv_Tran_DateBindingSource_PositionChanged(Nothing, Nothing)
    End Sub

   
End Class