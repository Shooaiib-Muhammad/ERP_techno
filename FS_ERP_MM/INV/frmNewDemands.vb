Public Class frmNewDemands
    Dim GMNo As Int32
    Dim Code As String
    Dim Qty As Integer
    Dim deptiD As Int32
    Dim UOM As String
    Dim DayID As Int32
    Dim ReqID As Int32
    Dim DemandID As Int32
    Dim UserID As Int32
    Dim IssuedQty As Int32
    Dim Blance As Int32



    Private Sub frmNewDemands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSdemands.tbl_Demand_Head' table. You can move, or remove it, as needed.
        'Me.Tbl_Demand_HeadTableAdapter.Fill(Me.DSdemands.tbl_Demand_Head)
        Try
            If Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSdemands.tbl_Inv_Tran_Date, Now.Date) > 0 Then
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSdemands.tbl_Inv_Tran_Date, Now.Date.AddDays(-15))
            Else
                Me.Tbl_Inv_Tran_DateTableAdapter.Insert(Now.Date)
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSdemands.tbl_Inv_Tran_Date, Now.Date.AddDays(-15))
            End If
        Catch ex As System.Exception
            'MsgBox(ex.Message)
        End Try
        'Me.View_New_Demands_BalanceTableAdapter.Fill(Me.DSdemands.view_New_Demands_Balance,)
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
    End Sub



    Private Sub View_New_Demands_BalanceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_New_Demands_BalanceDataGridView.CellContentClick
        If e.ColumnIndex = 11 Then

            IssuedQty = Me.View_New_Demands_BalanceDataGridView.Item(8, e.RowIndex).Value
                Blance = Me.View_New_Demands_BalanceDataGridView.Item(7, e.RowIndex).Value
                GMNo = GMNoComboBox.SelectedValue
                Code = Me.View_New_Demands_BalanceDataGridView.Item(9, e.RowIndex).Value
                deptiD = Me.View_New_Demands_BalanceDataGridView.Item(10, e.RowIndex).Value
                UOM = Me.View_New_Demands_BalanceDataGridView.Item(5, e.RowIndex).Value
                DayID = DayNoLabel1.Text
                ReqID = GMNoComboBox.SelectedValue
                DemandID = GMNoComboBox.SelectedValue
                UserID = frmLoginVer.UserID
            Try
                View_New_Demands_BalanceTableAdapter.InsertQuery("MIR", GMNo, Code, IssuedQty, deptiD, "Demand Approved", UOM, DayID, ReqID, DemandID, UserID, CDbl(Me.View_New_Demands_BalanceDataGridView.Item(12, e.RowIndex).Value))
                'Me.View_New_Demands_BalanceTableAdapter.Fill(Me.DSdemands.view_New_Demands_Balance)
                MsgBox("Selected Material Is Issued")
            Catch ex As Exception
            End Try

        End If



    End Sub

    Private Sub Tbl_Demand_HeadBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Demand_HeadBindingSource.PositionChanged
        Try
            'Me.View_New_Demands_BalanceTableAdapter.Fill(Me.DSdemands.view_New_Demands_Balance)
        Catch ex As Exception

        End Try
    End Sub
End Class