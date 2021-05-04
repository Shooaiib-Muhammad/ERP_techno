Public Class frmNewBEMatIssued
    Private Sub frmNewBEMatIssued_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSNewBEMatIssuance.tbl_Inv_Tran_Date, Now.Date.AddDays(-2))
            Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_Pro_PO_HTableAdapter.Fill(Me.DSNewBEMatIssuance.tbl_Pro_PO_H)
        Catch ex As Exception
        End Try
        Me.Tbl_Pro_PO_DTableAdapter.Fill(Me.DSNewBEMatIssuance.tbl_Pro_PO_D)
        Me.Tbl_Exp_InvTableAdapter.Fill(Me.DSNewBEMatIssuance.tbl_Exp_Inv)
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Me.View_PO_EOU_MaterialTableAdapter.Fill(Me.DSNewBEMatIssuance.View_PO_EOU_Material, Me.POLabel1.Text, Me.POMLabel1.Text, PODLabel1.Text, Me.InvoiceIDLabel1.Text)
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_BE_Tran_OutTableAdapter.Fill(Me.DSNewBEMatIssuance.tbl_BE_Tran_Out, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim btnMsg As DialogResult
        Dim Balance As Double = 0
        btnMsg = MessageBox.Show("Are You Sure Want To Issue Material Of Invoice No." & Me.InvoiceNoComboBox.Text & "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            If Me.Tbl_Pro_PO_H1TableAdapter.Fill(Me.DSNewBEMatIssuance.tbl_Pro_PO_H1, Me.InvoiceIDLabel1.Text) > 0 Then
                For L As Integer = 0 To Me.Tbl_Pro_PO_H1BindingSource.Count - 1
                    Me.Tbl_Pro_PO_D1TableAdapter.Fill(Me.DSNewBEMatIssuance.tbl_Pro_PO_D1, Me.DSNewBEMatIssuance.tbl_Pro_PO_H1.Rows(L).Item("PO"), Me.DSNewBEMatIssuance.tbl_Pro_PO_H1.Rows(L).Item("POM"))
                    For i As Integer = 0 To Me.Tbl_Pro_PO_D1BindingSource.Count - 1
                        If Me.View_PO_EOU_Material1TableAdapter.Fill(Me.DSNewBEMatIssuance.View_PO_EOU_Material1, Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("PO"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("POM"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("POD"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("ClientId"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("ModelID"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("ArtId"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("ArtSize"), Me.InvoiceIDLabel1.Text) > 0 Then
                            For K As Integer = 0 To Me.View_PO_EOU_Material1BindingSource.Count - 1
                                Balance = Me.View_PO_EOU_MaterialTableAdapter.ReqBalance(Me.DSNewBEMatIssuance.tbl_Pro_PO_H1.Rows(L).Item("PO"), Me.DSNewBEMatIssuance.tbl_Pro_PO_H1.Rows(L).Item("POM"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("POD"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code"), Me.InvoiceIDLabel1.Text)
                                If Balance > 0 Then
                                    If Me.View_BE_Mat_BalanceTableAdapter.Fill(Me.DSNewBEMatIssuance.View_BE_Mat_Balance, Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code")) > 0 Then
                                        For j As Integer = 0 To Me.View_BE_Mat_BalanceBindingSource.Count - 1
                                            If Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance") >= Balance Then
                                                Dim Bal As Double = Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance") - Balance
                                                Me.Tbl_BE_Tran_Out1TableAdapter.Insert(Me.DayNoLabel1.Text, Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("BEID"), Me.DSNewBEMatIssuance.tbl_Pro_PO_H1.Rows(L).Item("POCode"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("PO"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("POM"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("POD"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ClientId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ModelId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ArtId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ArtSize"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code"), CDbl(Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("EOUFormula")), Balance, CDbl(Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("MatWaste")), CDbl(Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance")), Bal, Val(Me.InvoiceIDLabel1.Text), CInt(Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("OrderQty")), Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("UOM"))
                                                Exit For
                                            Else
                                                Dim MyBal As Double = Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance")
                                                Me.Tbl_BE_Tran_Out1TableAdapter.Insert(Me.DayNoLabel1.Text, Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("BEID"), Me.DSNewBEMatIssuance.tbl_Pro_PO_H1.Rows(L).Item("POCode"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("PO"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("POM"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("POD"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ClientId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ModelId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ArtId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ArtSize"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code"), CDbl(Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("EOUFormula")), MyBal, CDbl(Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("MatWaste")), CDbl(Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance")), 0, Val(Me.InvoiceIDLabel1.Text), CInt(Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("OrderQty")), Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("UOM"))
                                                Balance = Me.View_PO_EOU_MaterialTableAdapter.ReqBalance(Me.DSNewBEMatIssuance.tbl_Pro_PO_H1.Rows(L).Item("PO"), Me.DSNewBEMatIssuance.tbl_Pro_PO_H1.Rows(L).Item("POM"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("POD"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code"), Me.InvoiceIDLabel1.Text)
                                            End If
                                        Next
                                    Else
                                        Continue For
                                    End If
                                End If
                            Next
                        End If
                    Next
                Next
                LoadData()
            End If
        End If

    End Sub

    Private Sub Tbl_BE_Tran_OutDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_BE_Tran_OutDataGridView.CellContentClick
        If e.ColumnIndex = 12 Then
            Dim btnMsg As DialogResult
            btnMsg = MessageBox.Show("Are You Sure Want To Undo Material Issuance Of B/E " & Me.Tbl_BE_Tran_OutDataGridView(3, e.RowIndex).Value & " ?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Tbl_BE_Tran_Out1TableAdapter.DeleteQuery(Tbl_BE_Tran_OutDataGridView(0, e.RowIndex).Value)
                LoadData()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim btnMsg As DialogResult
        Dim Balance As Double = 0
        btnMsg = MessageBox.Show("Are You Sure Want To Issue Material Of " & Me.POCodeComboBox.Text & "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Me.Tbl_Pro_PO_D1TableAdapter.Fill(Me.DSNewBEMatIssuance.tbl_Pro_PO_D1, Me.POLabel1.Text, POMLabel1.Text)
            For i As Integer = 0 To Me.Tbl_Pro_PO_D1BindingSource.Count - 1
                If Me.View_PO_EOU_Material1TableAdapter.Fill(Me.DSNewBEMatIssuance.View_PO_EOU_Material1, Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("PO"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("POM"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("POD"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("ClientId"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("ModelID"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("ArtId"), Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("ArtSize"), Me.InvoiceIDLabel1.Text) > 0 Then
                    For K As Integer = 0 To Me.View_PO_EOU_Material1BindingSource.Count - 1
                        Balance = Me.View_PO_EOU_MaterialTableAdapter.ReqBalance(Me.POLabel1.Text, 1, Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("POD"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code"), Me.InvoiceIDLabel1.Text)
                        If Balance > 0 Then
                            If Me.View_BE_Mat_BalanceTableAdapter.Fill(Me.DSNewBEMatIssuance.View_BE_Mat_Balance, Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code")) > 0 Then
                                For j As Integer = 0 To Me.View_BE_Mat_BalanceBindingSource.Count - 1
                                    If Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance") >= Balance Then
                                        Dim Bal As Double = Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance") - Balance
                                        Me.Tbl_BE_Tran_Out1TableAdapter.Insert(Me.DayNoLabel1.Text, Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("BEID"), Me.POCodeComboBox.Text, Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("PO"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("POM"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("POD"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ClientId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ModelId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ArtId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ArtSize"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code"), CDbl(Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("EOUFormula")), Balance, CDbl(Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("MatWaste")), CDbl(Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance")), Bal, Val(Me.InvoiceIDLabel1.Text), CInt(Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("OrderQty")), Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("UOM"))
                                        Exit For
                                    Else
                                        Dim MyBal As Double = Balance - Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance")
                                        Me.Tbl_BE_Tran_Out1TableAdapter.Insert(Me.DayNoLabel1.Text, Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("BEID"), Me.POCodeComboBox.Text, Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("PO"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("POM"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("POD"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ClientId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ModelId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ArtId"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("ArtSize"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code"), CDbl(Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("EOUFormula")), MyBal, CDbl(Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("MatWaste")), CDbl(Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("Balance")), 0, Val(Me.InvoiceIDLabel1.Text), CInt(Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("OrderQty")), Me.DSNewBEMatIssuance.View_BE_Mat_Balance.Rows(j).Item("UOM"))
                                        Balance = Me.View_PO_EOU_MaterialTableAdapter.ReqBalance(Me.POLabel1.Text, 1, Me.DSNewBEMatIssuance.tbl_Pro_PO_D1.Rows(i).Item("POD"), Me.DSNewBEMatIssuance.View_PO_EOU_Material1.Rows(K).Item("Code"), Me.InvoiceIDLabel1.Text)
                                    End If
                                Next
                            Else
                                Continue For
                            End If
                        End If
                    Next
                End If
            Next
            LoadData()
        End If
    End Sub
    Private Sub Tbl_Exp_InvBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Exp_InvBindingSource.PositionChanged
        LoadData()
    End Sub

    Private Sub Tbl_Pro_PO_HBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Pro_PO_HBindingSource.PositionChanged
        LoadData()
    End Sub

    Private Sub Tbl_Pro_PO_DBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Pro_PO_DBindingSource.PositionChanged
        LoadData()
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
            Me.Tbl_BE_Tran_OutTableAdapter.Fill(Me.DSNewBEMatIssuance.tbl_BE_Tran_Out, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub
End Class