Public Class frmDemandApproval
    Dim GMNo As Int32
    Dim Code As String
    Dim Qty As Double
    Dim deptiD As Int32
    Dim UOM As String
    Dim DayID As Int32
    Dim ReqID As Int32
    Dim DemandID As Int32
    Dim UserID As Int32
    Dim IssuedQty As Double
    Dim Blance As Double

    Private Sub frmDemandApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSdemands.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSdemands.tbl_Pur_UnitOfMeasurement)
        'TODO: This line of code loads data into the 'DSdemands.tbl_Demand_Head' table. You can move, or remove it, as needed.
        If Me.View_New_Demands_Balance_NEWTableAdapter.Fill(Me.DSdemands.view_New_Demands_Balance_NEW, Now.Date.AddDays(-15)) > 0 Then
            For i As Int16 = 0 To Me.View_New_Demands_Balance_NEWBindingSource.Count - 1
                Me.View_New_Demands_Balance_NEWTableAdapter.UpdateQuery(Me.DSdemands.view_New_Demands_Balance_NEW.Rows(i).Item("PDID"))
            Next


        End If
        Try
            Me.Tbl_Demand_HeadTableAdapter.Fill(Me.DSdemands.tbl_Demand_Head)
        Catch ex As Exception

        End Try
        Try
            If Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSdemands.tbl_Inv_Tran_Date, Now.Date) > 0 Then
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSdemands.tbl_Inv_Tran_Date, Now.Date)
            Else
                Me.Tbl_Inv_Tran_DateTableAdapter.Insert(Now.Date)
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSdemands.tbl_Inv_Tran_Date, Now.Date)
            End If
        Catch ex As System.Exception
            'MsgBox(ex.Message)
        End Try
        Try
            Me.View_Issued_demandsTableAdapter.Fill(Me.DSdemands.View_Issued_demands, DayNoLabel1.Text)
        Catch ex As Exception

        End Try
        'Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()




    End Sub

    Private Sub View_New_Demands_BalanceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_New_Demands_BalanceDataGridView.CellContentClick
        If e.ColumnIndex = 11 Then

            IssuedQty = Me.View_New_Demands_BalanceDataGridView.Item(8, e.RowIndex).Value
            Blance = Me.View_New_Demands_BalanceDataGridView.Item(7, e.RowIndex).Value
            If (IssuedQty > Blance) Then
                MsgBox("Issued Qty is Not Available")
            Else
               
                Dim PIID As Int64 = Me.View_New_Demands_BalanceDataGridView.Item(0, e.RowIndex).Value
                GMNo = GMNoComboBox.Text
                Code = Me.View_New_Demands_BalanceDataGridView.Item(9, e.RowIndex).Value
                deptiD = Me.View_New_Demands_BalanceDataGridView.Item(10, e.RowIndex).Value
                UOM = Me.View_New_Demands_BalanceDataGridView.Item(5, e.RowIndex).Value
                DayID = DayNoLabel1.Text
                ReqID = GMNoComboBox.Text
                DemandID = GMNoComboBox.Text
                UserID = frmLoginVer.UserID
                Try
                    View_New_Demands_BalanceTableAdapter.InsertQuery("MID", GMNo, Code, IssuedQty, deptiD, Me.View_New_Demands_BalanceDataGridView.Item(15, e.RowIndex).Value.ToString, UOM, DayID, PIID, DemandID, UserID, CDbl(Me.View_New_Demands_BalanceDataGridView.Item(13, e.RowIndex).Value))
                    Me.View_Issued_demandsTableAdapter.UpdateQuery(PIID)
                    Me.View_New_Demands_BalanceTableAdapter.Fill(Me.DSdemands.view_New_Demands_Balance, GMNoComboBox.Text)
                    Try
                        Me.View_Issued_demandsTableAdapter.Fill(Me.DSdemands.View_Issued_demands, DayNoLabel1.Text)
                    Catch ex As Exception

                    End Try
                    MsgBox("Selected Material Is Issued")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If


        End If
    End Sub

    Private Sub View_New_Demands_BalanceDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_New_Demands_BalanceDataGridView.DataError

    End Sub

    Private Sub Tbl_Demand_HeadBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Demand_HeadBindingSource.PositionChanged
        Try
            Me.View_New_Demands_BalanceTableAdapter.Fill(Me.DSdemands.view_New_Demands_Balance, GMNoComboBox.Text)

        Catch ex As Exception

        End Try
        Try
            Me.View_Issued_demandsTableAdapter.Fill(Me.DSdemands.View_Issued_demands, DayNoLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub View_Issued_demandsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Issued_demandsDataGridView.CellContentClick
        If e.ColumnIndex = 9 Then

            Dim TransID As Int32 = Me.View_Issued_demandsDataGridView.Item(10, e.RowIndex).Value

            Try
                View_Issued_demandsTableAdapter.DeleteQuery(TransID)
                Me.View_New_Demands_BalanceTableAdapter.Fill(Me.DSdemands.view_New_Demands_Balance, GMNoComboBox.Text)
                Try
                    Me.View_Issued_demandsTableAdapter.Fill(Me.DSdemands.View_Issued_demands, DayNoLabel1.Text)
                Catch ex As Exception

                End Try
                MsgBox("Transaction is Undo Sucessfully")
            Catch ex As Exception
                End Try
            End If



    End Sub

    Private Sub View_Issued_demandsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_Issued_demandsDataGridView.DataError

    End Sub
    Private Sub loadDemands()
        If RadioButton1.Checked = True Then
            Try
                Me.Tbl_Demand_HeadTableAdapter.Fill(Me.DSdemands.tbl_Demand_Head)
            Catch ex As Exception

            End Try

        ElseIf RadioButton2.Checked = True Then
            Try
                Me.Tbl_Demand_HeadTableAdapter.FillBy(Me.DSdemands.tbl_Demand_Head)
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        loadDemands()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        loadDemands()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim btnMsg As DialogResult

        btnMsg = MessageBox.Show("Are You Sure Want To Issue All Materials?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            For k As Int16 = 0 To Me.View_New_Demands_BalanceDataGridView.Rows.Count - 1
                View_New_Demands_BalanceTableAdapter.InsertQuery("MID", GMNoComboBox.SelectedValue, Me.View_New_Demands_BalanceDataGridView.Item(9, k).Value.ToString, CDbl(Me.View_New_Demands_BalanceDataGridView.Item(6, k).Value), Me.View_New_Demands_BalanceDataGridView.Item(10, k).Value, Me.View_New_Demands_BalanceDataGridView.Item(15, k).Value.ToString, Me.View_New_Demands_BalanceDataGridView.Item(5, k).Value, Me.DayNoLabel1.Text, CInt(Me.View_New_Demands_BalanceDataGridView.Item(0, k).Value), GMNoComboBox.SelectedValue, UserID, CDbl(Me.View_New_Demands_BalanceDataGridView.Item(13, k).Value))
                Me.View_Issued_demandsTableAdapter.UpdateQuery(CInt(Me.View_New_Demands_BalanceDataGridView.Item(0, k).Value))
            Next
            Me.View_New_Demands_BalanceTableAdapter.Fill(Me.DSdemands.view_New_Demands_Balance, GMNoComboBox.Text)
            Try
                Me.View_Issued_demandsTableAdapter.Fill(Me.DSdemands.View_Issued_demands, DayNoLabel1.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub
End Class