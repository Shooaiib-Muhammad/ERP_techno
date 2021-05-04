Public Class frmAutoSaleIssuance

    Private Sub frmAutoSaleIssuance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.AutoSaleIssuance.tbl_Inv_Tran_Date, Now.Date.AddDays(-7))
        Catch ex As System.Exception
        End Try
        If frmLoginVer.DeptID = 24 Or frmLoginVer.UserID = 139 Then
            Me.Tbl_MM_CustomerTableAdapter.FillBy(Me.AutoSaleIssuance.tbl_MM_Customer)
        Else
            Me.Tbl_MM_CustomerTableAdapter.Fill(Me.AutoSaleIssuance.tbl_MM_Customer)
        End If

        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Me.View_Sale_DetailTableAdapter.Fill(Me.AutoSaleIssuance.View_Sale_Detail, CustIDLabel.Text)
        Catch ex As Exception
        End Try
    End Sub
    Dim Flag As Boolean = False
    Dim EntryFlag As Boolean = False
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim Number As Integer = 8
        'Dim Value As Integer = 100

        'Select Case Number
        '    Case 1 To 5
        '        Value = Number - 1
        '    Case 6 To 7
        '        Value = Number - 2
        'End Select
        'MsgBox(Value)



        Dim btnMsg As DialogResult
        Dim IssueQty, AvailQty As Double
        btnMsg = MessageBox.Show("Are You Sure Want To Issue Selected Material?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            For i As Integer = 0 To Me.View_Sale_DetailDataGridView.RowCount - 1
                AvailQty = Me.Tbl_MM_CustomerTableAdapter.MatAvailable(Me.View_Sale_DetailDataGridView(1, i).Value)
                EntryFlag = False
                If Me.View_Sale_DetailDataGridView(11, i).Value > 0 Then
                    IssueQty = Me.View_Sale_DetailDataGridView(11, i).Value
                    If Me.View_Sale_DetailDataGridView(11, i).Value >= Me.View_Sale_DetailDataGridView(10, i).Value Then
                        EntryFlag = False
                    Else
                        EntryFlag = True
                    End If
                Else
                    IssueQty = Me.View_Sale_DetailDataGridView(10, i).Value
                End If
                Flag = False
                If AvailQty > 0 Then
                    If IssueQty > AvailQty Then
                        Flag = True
                        IssueQty = AvailQty
                    End If
                End If
                If Me.View_Sale_DetailDataGridView(12, i).Value = True Then
                    Me.Tbl_Inv_Tran_OutTableAdapter.Insert(Me.DayNoLabel1.Text, Me.View_Sale_DetailDataGridView(2, i).Value, Me.View_Sale_DetailDataGridView(3, i).Value, "MSGP", "'1'", Me.View_Sale_DetailDataGridView(1, i).Value, Me.View_Sale_DetailDataGridView(4, i).Value, Me.View_Sale_DetailDataGridView(6, i).Value, IssueQty, Me.View_Sale_DetailDataGridView(5, i).Value, Me.View_Sale_DetailDataGridView(9, i).Value, Nothing)
                    If Flag = False And EntryFlag = False Then
                        Me.View_Sale_DetailTableAdapter.UpdateQuery(Now.Date, Me.View_Sale_DetailDataGridView(2, i).Value, Me.View_Sale_DetailDataGridView(3, i).Value)
                    End If
                End If
            Next
            LoadData()
        End If
    End Sub

    Private Sub Tbl_MM_CustomerBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_MM_CustomerBindingSource.PositionChanged
        LoadData()
    End Sub

    Private Sub MatNameTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatNameTextBox.Click

    End Sub

    Private Sub MatNameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MatNameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_Sale_DetailBindingSource.Filter = "L4Name like '" & Me.MatNameTextBox.Text & "%'"
            Me.MatNameTextBox.Text = ""
            Me.CMSSupStatus.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.View_Sale_DetailBindingSource.RemoveFilter()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objRptViewer As New Class_Utility
        Dim Filter As String = "{View_MM_SI_GP.DayNo} = " & Val(DayNoLabel1.Text) & " AND {View_MM_SI_GP.CustID} = " & Val(CustIDLabel.Text)
        Dim param As String = "Vehicle=""&Driver="" "
        If frmLoginVer.DeptID = 24 Or frmLoginVer.UserID = 139 Then
            objRptViewer.LoadReports("\\Server\MyReports$\FSERPMM\Procurement\OtherMaterial\rptSaleGatePass1.rpt", Filter, param)
        Else
            objRptViewer.LoadReports("\\Server\MyReports$\FSERPMM\Procurement\OtherMaterial\rptSaleGatePass.rpt", Filter, param)
        End If

    End Sub
End Class