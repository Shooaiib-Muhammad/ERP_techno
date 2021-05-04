Public Class FrmNewIssuance
    Dim GMNo As Int32
    Dim Code As String
    Dim TType As String
    Dim Qty1 As Double
    Dim deptiD As Int32
    Dim UOM As String
    Dim DayID As Int32
    Dim ReqID As Int32
    Dim DemandID As Int32
    Dim UserID As Int32
    Dim Qtty As Int64
    Dim PPU As Int64
    Dim Blance As Double
    Dim TID As Int64
    Private Sub FrmNewIssuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDemand.Active_GD_No' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSDemand.View_Tran_IN_new' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSDemand.tbl_Inv_LocalCust_New' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCust_NewTableAdapter.Fill(Me.DSDemand.tbl_Inv_LocalCust_New)
        'TODO: This line of code loads data into the 'DSDemand.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSDemand.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSDemand.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSDemand.tbl_Inv_Tran_Date)
        'TODO: This line of code loads data into the 'DSDemand.View_Tran_IN_Trans' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSDemand.View_GPNo' table. You can move, or remove it, as needed.

        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()

        loadData()
    End Sub

    Private Sub View_Tran_IN_TransDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Tran_IN_TransDataGridView.CellContentClick


    End Sub
    Private Sub loadData()
        Try
            Me.Active_GD_NoTableAdapter.Fill(Me.DSDemand.Active_GD_No)
            Me.View_Demand_IssuanceTableAdapter.Fill(Me.DSDemand.View_Demand_Issuance, Label1.Text)
        Catch ex As Exception

        End Try
        If RadioButton8.Checked = True Then '' By Date

            Try
                Me.View_Tran_IN_newTableAdapter.FillBy(Me.DSDemand.View_Tran_IN_new, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try

        ElseIf RadioButton6.Checked = True Then '' By Item

            Try
                Me.View_Tran_IN_newTableAdapter.FillBy2(Me.DSDemand.View_Tran_IN_new, L4NameComboBox.SelectedValue, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
        ElseIf RadioButton7.Checked = True Then '' By Dept

            Try
                Me.View_Tran_IN_newTableAdapter.FillBy3(Me.DSDemand.View_Tran_IN_new, CustNameComboBox.SelectedValue, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try
        ElseIf RadioButton3.Checked = True Then '' By GD No.

            Try
                Me.View_Tran_IN_newTableAdapter.FillBy4(Me.DSDemand.View_Tran_IN_new, TextBox1.Text)
            Catch ex As Exception

            End Try

        End If


    End Sub

    Private Sub View_Tran_IN_TransDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles View_Tran_IN_TransDataGridView.CellEnter
        If e.ColumnIndex = 15 Then

            Dim issuedQty As Int64
            If Me.View_Tran_IN_TransDataGridView.Item(14, e.RowIndex).Value = "" Then
                issuedQty = Me.View_Tran_IN_TransDataGridView.Item(12, e.RowIndex).Value
                Qtty = Me.View_Tran_IN_TransDataGridView.Item(12, e.RowIndex).Value
            Else
                Qtty = Me.View_Tran_IN_TransDataGridView.Item(14, e.RowIndex).Value
                issuedQty = Me.View_Tran_IN_TransDataGridView.Item(14, e.RowIndex).Value

            End If
            Blance = Me.View_Tran_IN_TransDataGridView.Item(12, e.RowIndex).Value
            If (issuedQty > Blance) Then
                MsgBox("Issued Qty is Not Available")
            Else
                TID = Me.View_Tran_IN_TransDataGridView.Item(7, e.RowIndex).Value
                'Dim PIID As Int64 = Me.View_Tran_INDataGridView.Item(0, e.RowIndex).Value
                GMNo = Me.View_Tran_IN_TransDataGridView.Item(1, e.RowIndex).Value
                Code = Me.View_Tran_IN_TransDataGridView.Item(9, e.RowIndex).Value
                TType = Me.View_Tran_IN_TransDataGridView.Item(8, e.RowIndex).Value
                PPU = 0
                deptiD = Me.View_Tran_IN_TransDataGridView.Item(16, e.RowIndex).Value
                UOM = Me.View_Tran_IN_TransDataGridView.Item(5, e.RowIndex).Value


                DayID = Label1.Text
                ReqID = Me.View_Tran_IN_TransDataGridView.Item(1, e.RowIndex).Value
                DemandID = Me.View_Tran_IN_TransDataGridView.Item(1, e.RowIndex).Value
                UserID = frmLoginVer.UserID
                Try
                    'View_New_Demands_BalanceTableAdapter.InsertQuery("MID", GMNo, Code, issuedQty, deptiD, Me.View_New_Demands_BalanceDataGridView.Item(15, e.RowIndex).Value.ToString, UOM, DayID, PIID, DemandID, UserID, CDbl(Me.View_New_Demands_BalanceDataGridView.Item(13, e.RowIndex).Value))

                    View_Tran_IN_TransTableAdapter.InsertQuery(TType, GMNo, Code, Qtty, deptiD, Me.View_Tran_IN_TransDataGridView.Item(4, e.RowIndex).Value.ToString, UOM, DayID, UserID, PPU, issuedQty, DemandID)
                    'Tbl_Inv_L4TableAdapter.UpdateQuery(PPU, Code)

                    MsgBox("Selected Material Is Issued")
                    Me.View_Demand_IssuanceTableAdapter.Fill(Me.DSDemand.View_Demand_Issuance, Label1.Text)
                    loadData()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                'Catch ex As Exception
                '    MsgBox(ex.Message)
                'End Try
            End If
        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub View_Demand_IssuanceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Demand_IssuanceDataGridView.CellContentClick

    End Sub

    Private Sub View_Demand_IssuanceDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles View_Demand_IssuanceDataGridView.CellEnter
        If e.ColumnIndex = 8 Then
            Try
                View_Demand_IssuanceTableAdapter.DeleteQuery(Me.View_Demand_IssuanceDataGridView.Item(9, e.RowIndex).Value)
                MsgBox("Undo Successfully Done")
                loadData()
                Try
                    Me.View_Demand_IssuanceTableAdapter.Fill(Me.DSDemand.View_Demand_Issuance, Label1.Text)
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

        If RadioButton6.Checked = True Then
            L4NameComboBox.Enabled = True
            CustNameComboBox.Enabled = False
            GMNOComboBox.Enabled = False
        Else
            L4NameComboBox.Enabled = False
            CustNameComboBox.Enabled = True
            GMNOComboBox.Enabled = True
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        loadData()

        If RadioButton8.Checked = True Then
            L4NameComboBox.Enabled = False
            CustNameComboBox.Enabled = False
            GMNOComboBox.Enabled = False
        Else
            L4NameComboBox.Enabled = False
            CustNameComboBox.Enabled = False
            GMNOComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            L4NameComboBox.Enabled = False
            CustNameComboBox.Enabled = True
            GMNOComboBox.Enabled = False
        Else
            L4NameComboBox.Enabled = False
            CustNameComboBox.Enabled = False
            GMNOComboBox.Enabled = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            L4NameComboBox.Enabled = False
            CustNameComboBox.Enabled = False
            GMNOComboBox.Enabled = True
        Else
            L4NameComboBox.Enabled = False
            CustNameComboBox.Enabled = False
            GMNOComboBox.Enabled = False
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loadData()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loadData()
    End Sub

    Private Sub L4NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L4NameComboBox.SelectedIndexChanged
        loadData()
    End Sub

    Private Sub CustNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustNameComboBox.SelectedIndexChanged
        loadData()
    End Sub

    Private Sub GMNOComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GMNOComboBox.SelectedIndexChanged
        Try
            Me.View_Tran_IN_newTableAdapter.FillBy4(Me.DSDemand.View_Tran_IN_new, GMNOComboBox.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
            Me.View_Demand_IssuanceTableAdapter.Fill(Me.DSDemand.View_Demand_Issuance, Label1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim btnMsg As DialogResult

        btnMsg = MessageBox.Show("Are You Sure Want To Issue All Materials?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            For k As Int16 = 0 To Me.View_Tran_IN_TransDataGridView.Rows.Count - 1

                Dim issQty As Int64
                If Me.View_Tran_IN_TransDataGridView.Item(14, k).Value = "" Then
                    issQty = Me.View_Tran_IN_TransDataGridView.Item(12, k).Value
                    Qtty = Me.View_Tran_IN_TransDataGridView.Item(12, k).Value
                Else
                    Qtty = Me.View_Tran_IN_TransDataGridView.Item(14, k).Value
                    issQty = Me.View_Tran_IN_TransDataGridView.Item(14, k).Value

                End If
                Blance = Me.View_Tran_IN_TransDataGridView.Item(12, k).Value
                If (issQty > Blance) Then
                    MsgBox("Issued Qty is Not Available")
                Else
                    TID = Me.View_Tran_IN_TransDataGridView.Item(7, k).Value
                    'Dim PIID As Int64 = Me.View_Tran_INDataGridView.Item(0, e.RowIndex).Value
                    GMNo = Me.View_Tran_IN_TransDataGridView.Item(1, k).Value
                    Code = Me.View_Tran_IN_TransDataGridView.Item(9, k).Value
                    TType = Me.View_Tran_IN_TransDataGridView.Item(8, k).Value
                    PPU = 0
                    deptiD = Me.View_Tran_IN_TransDataGridView.Item(16, k).Value
                    UOM = Me.View_Tran_IN_TransDataGridView.Item(5, k).Value


                    DayID = Label1.Text
                    ReqID = Me.View_Tran_IN_TransDataGridView.Item(1, k).Value
                    DemandID = Me.View_Tran_IN_TransDataGridView.Item(1, k).Value
                    UserID = frmLoginVer.UserID
                    Try
                        View_Tran_IN_TransTableAdapter.InsertQuery(TType, GMNo, Code, Qtty, deptiD, Me.View_Tran_IN_TransDataGridView.Item(4, k).Value.ToString, UOM, DayID, UserID, PPU, issQty, DemandID)
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    End Try
                End If
            Next
            MsgBox("Selected Material Is Issued")
            loadData()
            Try
            Me.View_Demand_IssuanceTableAdapter.Fill(Me.DSDemand.View_Demand_Issuance, Label1.Text)

            Catch ex As Exception

        End Try
        End If

    End Sub

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    '    Try
    '        Me.View_Tran_IN_newTableAdapter.FillBy4(Me.DSDemand.View_Tran_IN_new, TextBox1.Text)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
    '    If e.KeyCode = Keys.Enter Then


    '        'Me.View_Pur_DemandsBindingSource.Filter = "GMNo = " & Val(txtGMNO.Text)
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadData()
    End Sub

    Private Sub View_GPNoBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles View_GPNoBindingSource.PositionChanged

    End Sub
End Class