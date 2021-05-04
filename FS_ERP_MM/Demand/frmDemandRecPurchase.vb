Public Class frmDemandRecPurchase


    Private Sub frmDemandRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDemand.View_Tran_IN_new_one' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSNewProcurement.tbl_Pur_Demand_New' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSDemand.tbl_Inv_L4_New' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4_NewTableAdapter.Fill(Me.DSDemand.tbl_Inv_L4_New)
        'TODO: This line of code loads data into the 'DSDemand.tbl_Inv_LocalCust_New' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCust_NewTableAdapter.Fill(Me.DSDemand.tbl_Inv_LocalCust_New)
        'TODO: This line of code loads data into the 'DSPO.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSPO.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSDemand.tbl_PUR_Vendor_Info' table. You can move, or remove it, as needed.
        Me.Tbl_PUR_Vendor_InfoTableAdapter.Fill(Me.DSDemand.tbl_PUR_Vendor_Info)
        'TODO: This line of code loads data into the 'DSDemand.tbl_Sec_Middle' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DSDemand.DataTable1, Now.Date.AddMonths(-1))
        'TODO: This line of code loads data into the 'DSDemand.View_Tran_IN' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSDemand.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSDemand.tbl_Inv_Tran_Date)
        'TODO: This line of code loads data into the 'DSDemand.View_Pur_Demands' table. You can move, or remove it, as needed.

        loadData()
        'TODO: This line of code loads data into the 'DSDemand.tbl_Inv_Tran_In' table. You can move, or remove it, as needed.
        'Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSDemand.tbl_Inv_Tran_In)
        Tbl_Inv_Tran_DateBindingSource.MoveLast()
        View_Tran_INDataGridView.ReadOnly = False
        KeyPreview = True
        loadIssedData()
    End Sub
    Private Sub loadIssedData()
        If RadioButton8.Checked = True Then '' byDate
            TextBox1.Text = ""
            Try
                Me.View_Tran_IN_new_oneTableAdapter.Fill(Me.DSDemand.View_Tran_IN_new_one, DayID.Text)
            Catch ex As Exception

            End Try
        ElseIf RadioButton6.Checked = True Then  '' by item Name
            TextBox1.Text = ""
            Try
                Me.View_Tran_IN_new_oneTableAdapter.FillBy2(Me.DSDemand.View_Tran_IN_new_one, ComboBox3.SelectedValue)
            Catch ex As Exception

            End Try

        ElseIf RadioButton7.Checked = True Then  '' By Dept
            TextBox1.Text = ""
            Try
                Me.View_Tran_IN_new_oneTableAdapter.FillBy5(Me.DSDemand.View_Tran_IN_new_one, ComboBox2.SelectedValue)
            Catch ex As Exception

            End Try
        ElseIf RadioButton3.Checked = True Then '' By  GD No
            Try
                Me.View_Tran_IN_new_oneTableAdapter.FillBy4(Me.DSDemand.View_Tran_IN_new_one, TextBox1.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub loadData()

        If RadioButton1.Checked = True Then '' By Date Range
            txtGMNO.Text = ""
            Me.View_Pur_DemandsBindingSource.RemoveFilter()
            Try
                Me.View_Pur_DemandsTableAdapter.Fill(Me.DSDemand.View_Pur_Demands, DateTimePicker1.Text, DateTimePicker2.Text)
                Me.View_Pur_All_DetailsTableAdapter.Fill(Me.DSDemand.View_Pur_All_Details, DateTimePicker1.Text, DateTimePicker2.Text)
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy(Me.DSNewProcurement.tbl_Pur_Demand_New, DateTimePicker1.Text, DateTimePicker2.Text)
            Catch ex As Exception

            End Try

        ElseIf RadioButton2.Checked = True Then '' By Items
            txtGMNO.Text = ""
            Me.View_Pur_DemandsBindingSource.RemoveFilter()
            Try
                Me.View_Pur_DemandsTableAdapter.FillBy(Me.DSDemand.View_Pur_Demands, L4NameComboBox.SelectedValue)
                Me.View_Pur_All_DetailsTableAdapter.FillBy(Me.DSDemand.View_Pur_All_Details, L4NameComboBox.SelectedValue)
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy1(Me.DSNewProcurement.tbl_Pur_Demand_New, L4NameComboBox.SelectedValue)
            Catch ex As Exception

            End Try
        ElseIf RadioButton4.Checked = True Then '' By Dept
            txtGMNO.Text = ""
            Me.View_Pur_DemandsBindingSource.RemoveFilter()
            Try
                Me.View_Pur_DemandsTableAdapter.FillBy1(Me.DSDemand.View_Pur_Demands, CustNameComboBox.SelectedValue)
                Me.View_Pur_All_DetailsTableAdapter.FillBy2(Me.DSDemand.View_Pur_All_Details, CustNameComboBox.SelectedValue)
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy2(Me.DSNewProcurement.tbl_Pur_Demand_New, CustNameComboBox.SelectedValue)
            Catch ex As Exception

            End Try
        ElseIf RadioButton5.Checked = True Then
            txtGMNO.Text = txtGMNO.Text
            Try
                Me.View_Pur_DemandsTableAdapter.FillBy2(Me.DSDemand.View_Pur_Demands, txtGMNO.Text)
                Me.View_Pur_All_DetailsTableAdapter.FillBy1(Me.DSDemand.View_Pur_All_Details, txtGMNO.Text)
                Me.Tbl_Pur_Demand_NewTableAdapter.FillBy14(Me.DSNewProcurement.tbl_Pur_Demand_New, txtGMNO.Text)
            Catch ex As Exception

            End Try
        End If

    End Sub
    Private Sub View_Pur_DemandsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Pur_DemandsDataGridView.CellContentClick
        Dim Qty As Int64

        If e.ColumnIndex = 16 Then
            Dim btnMsg = MessageBox.Show("Are You Sure Want To Receive Material?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Dim Balance = Me.View_Pur_DemandsDataGridView.Item(9, e.RowIndex).Value
                Dim DemandQty = Me.View_Pur_DemandsDataGridView.Item(7, e.RowIndex).Value
                Dim EntryQty = Me.View_Pur_DemandsDataGridView.Item(13, e.RowIndex).Value
                Dim PIID = Me.View_Pur_DemandsDataGridView.Item(18, e.RowIndex).Value
                Dim CustID = Me.View_Pur_DemandsDataGridView.Item(21, e.RowIndex).Value
                Dim IsseddeptID = Me.View_Pur_DemandsDataGridView.Item(15, e.RowIndex).Value
                Dim GD = Me.View_Pur_DemandsDataGridView.Item(0, e.RowIndex).Value
                Dim Code = Me.View_Pur_DemandsDataGridView.Item(17, e.RowIndex).Value
                Dim UOm = Me.View_Pur_DemandsDataGridView.Item(6, e.RowIndex).Value
                If Me.View_Pur_DemandsDataGridView.Item(13, e.RowIndex).Value = "" Then

                    Qty = Me.View_Pur_DemandsDataGridView.Item(7, e.RowIndex).Value
                Else
                    Qty = Me.View_Pur_DemandsDataGridView.Item(13, e.RowIndex).Value
                End If

                Dim RNO = Me.View_Pur_DemandsDataGridView.Item(12, e.RowIndex).Value
                Dim PPU = 0
                Dim Narration = Me.View_Pur_DemandsDataGridView.Item(5, e.RowIndex).Value
                Dim Remarks = Me.View_Pur_DemandsDataGridView.Item(14, e.RowIndex).Value
                Dim ApprovedStatus As Boolean = Me.View_Pur_DemandsDataGridView.Item(10, e.RowIndex).Value

                'If EntryQty > DemandQty Then
                '    MsgBox("Enter Qty is Greater then Demand Qty", MsgBoxStyle.Critical, "Error")
                'Else
                If ApprovedStatus = True Then
                    Try
                        Tbl_Inv_Tran_InTableAdapter.Insert(DayID.Text, "GDR", Code, Qty, GD, PIID, "", RNO, PPU, CustID, Nothing, 1, UOm, 1, DemandQty, Remarks, Narration, IsseddeptID, "Cash")
                        'Me.View_Tran_INTableAdapter.Fill(Me.DSDemand.View_Tran_IN_new_one)
                        Me.View_Tran_IN_new_oneTableAdapter.Fill(Me.DSDemand.View_Tran_IN_new_one, DayID.Text)
                        MsgBox("Demand Qty is Received Successfully")
                        loadData()
                    Catch ex As Exception

                    End Try
                Else
                    MsgBox("Demand is Not Approved By GM", MsgBoxStyle.Critical, "Error")

                End If


                'End If
            End If



        End If
    End Sub






    Private Sub View_Pur_DemandsDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles View_Pur_DemandsDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    'Private Sub View_Tran_INDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
    '    If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
    '        CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
    '        CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
    '        CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    '    End If
    'End Sub

    Private Sub View_Tran_INDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles View_Tran_INDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loadData()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loadData()
    End Sub


    Private Sub SaveData()
        Try
            Me.ValidateChildren()
            Me.View_Tran_IN_new_oneTableAdapter.Update(Me.DSDemand.View_Tran_IN_new_one)
            loadIssedData()
            MsgBox("Data Updated Successfully")

        Catch ex As Exception

        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SaveData()
    End Sub



    Private Sub View_Tran_INDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles View_Tran_INDataGridView.CellEnter
        'If e.ColumnIndex = 8 Then
        '    If Me.View_Tran_INDataGridView.Item(8, e.RowIndex).Value > 0 Then

        '        If Me.View_Tran_INDataGridView.Item(10, e.RowIndex).Value Is DBNull.Value Then
        '            Me.View_Tran_INDataGridView.Item(10, e.RowIndex).Value = Now
        '        End If

        '    End If
        'End If
        If e.ColumnIndex = 14 Then
            If Me.View_Tran_INDataGridView.Item(13, e.RowIndex).Value > 0 Then

                Me.View_Tran_INDataGridView.Item(14, e.RowIndex).Value = Val(Me.View_Tran_INDataGridView.Item(7, e.RowIndex).Value) * Val(Me.View_Tran_INDataGridView.Item(13, e.RowIndex).Value)
                Me.View_Tran_INDataGridView.Item(20, e.RowIndex).Value = True
                If Me.View_Tran_INDataGridView.Item(15, e.RowIndex).Value Is DBNull.Value Then
                    Me.View_Tran_INDataGridView.Item(15, e.RowIndex).Value = Now

                End If
            End If
        End If
    End Sub

    Private Sub View_Tran_INDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Tran_INDataGridView.CellContentClick
        If e.ColumnIndex = 22 Then

            Dim TransID As Int32 = Me.View_Tran_INDataGridView.Item(21, e.RowIndex).Value

            Try
                View_Tran_IN_new_oneTableAdapter.DeleteQuery(TransID)

                MsgBox("Transaction is Undo Sucessfully")
                Me.View_Tran_IN_new_oneTableAdapter.Fill(Me.DSDemand.View_Tran_IN_new_one, DayID.Text)
                loadData()

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub View_Tran_INDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_Tran_INDataGridView.DataError

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        loadData()
    End Sub

    Private Sub txtGMNO_TextChanged(sender As Object, e As EventArgs) Handles txtGMNO.TextChanged
        Try
            Me.View_Pur_DemandsTableAdapter.FillBy2(Me.DSDemand.View_Pur_Demands, txtGMNO.Text)
            Me.View_Pur_All_DetailsTableAdapter.FillBy1(Me.DSDemand.View_Pur_All_Details, txtGMNO.Text)
            Me.Tbl_Pur_Demand_NewTableAdapter.FillBy2(Me.DSNewProcurement.tbl_Pur_Demand_New, txtGMNO.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtGMNO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGMNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_Pur_DemandsTableAdapter.FillBy2(Me.DSDemand.View_Pur_Demands, txtGMNO.Text)
            Me.View_Pur_All_DetailsTableAdapter.FillBy1(Me.DSDemand.View_Pur_All_Details, txtGMNO.Text)
            'Me.View_Pur_DemandsBindingSource.Filter = "GMNo = " & Val(txtGMNO.Text)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged


        If RadioButton5.Checked = True Then
            txtGMNO.Enabled = True
        Else
            txtGMNO.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged


        If RadioButton4.Checked = True Then
            CustNameComboBox.Enabled = True
        Else
            CustNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            L4NameComboBox.Enabled = True
        Else
            L4NameComboBox.Enabled = False
        End If
    End Sub

    Private Sub L4NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L4NameComboBox.SelectedIndexChanged
        loadData()
    End Sub

    Private Sub CustNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustNameComboBox.SelectedIndexChanged
        loadData()
    End Sub
    Private Sub Refresh()
        RadioButton1.Checked = True
        Me.View_Pur_DemandsBindingSource.RemoveCurrent()
        Try
            Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
            'TODO: This line of code loads data into the 'DSPO.tbl_Inv_L4' table. You can move, or remove it, as needed.
            Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPO.tbl_Inv_L4)
        Catch ex As Exception

        End Try
        Try
            Me.View_Pur_DemandsTableAdapter.Fill(Me.DSDemand.View_Pur_Demands, DateTimePicker1.Text, DateTimePicker2.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadData()
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        loadIssedData()

        If RadioButton8.Checked = True Then
            ComboBox3.Enabled = False
            ComboBox2.Enabled = False
            TextBox1.Enabled = False
        Else
            ComboBox3.Enabled = True
            ComboBox2.Enabled = True
            TextBox1.Enabled = True
        End If
        loadData()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

        If RadioButton6.Checked = True Then
            ComboBox3.Enabled = True
            ComboBox2.Enabled = False
            TextBox1.Enabled = False
        Else
            ComboBox3.Enabled = False
            ComboBox2.Enabled = True
            TextBox1.Enabled = True
        End If
        loadData()
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged

        If RadioButton7.Checked = True Then
            ComboBox3.Enabled = False
            ComboBox2.Enabled = True
            TextBox1.Enabled = False
        Else
            ComboBox3.Enabled = True
            ComboBox2.Enabled = False
            TextBox1.Enabled = True
        End If
        loadData()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        If RadioButton3.Checked = True Then
            ComboBox3.Enabled = False
            ComboBox2.Enabled = False
            TextBox1.Enabled = True
        Else
            ComboBox3.Enabled = True
            ComboBox2.Enabled = True
            TextBox1.Enabled = False
        End If
        loadData()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Me.View_Tran_IN_new_oneTableAdapter.FillBy4(Me.DSDemand.View_Tran_IN_new_one, TextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_Tran_IN_new_oneTableAdapter.FillBy4(Me.DSDemand.View_Tran_IN_new_one, TextBox1.Text)

            'Me.View_Pur_DemandsBindingSource.Filter = "GMNo = " & Val(txtGMNO.Text)
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        loadIssedData()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        loadIssedData()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        Dim btnMsg As DialogResult
        Dim Status As Boolean
        btnMsg = MessageBox.Show("Are You Sure Want To Issue All Materials?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then

            For k As Int16 = 0 To Me.View_Pur_DemandsDataGridView.Rows.Count - 1

                If Me.View_Pur_DemandsDataGridView(17, k).Value = "Received" Then
                    Status = True
                ElseIf Me.View_Pur_DemandsDataGridView(17, k).Value = "" Then
                    Status = False
                End If

                'MsgBox(Status)


                If Status = True Then
                    'Dim i As Integer = Me.View_Pur_DemandsDataGridView(9, k).Value
                    'Dim Balance As Integer = Me.View_Pur_DemandsDataGridView(9, k).Value
                    Dim EntryQty = Me.View_Pur_DemandsDataGridView.Item(7, k).Value
                    Dim PIID = Me.View_Pur_DemandsDataGridView.Item(15, k).Value
                    Dim CustID = Me.View_Pur_DemandsDataGridView.Item(16, k).Value
                    Dim GD = Me.View_Pur_DemandsDataGridView.Item(0, k).Value
                    Dim Code = Me.View_Pur_DemandsDataGridView.Item(14, k).Value
                    Dim UOm = Me.View_Pur_DemandsDataGridView.Item(6, k).Value
                    Dim Qty = Me.View_Pur_DemandsDataGridView.Item(7, k).Value
                    Dim RNO = Me.View_Pur_DemandsDataGridView.Item(10, k).Value
                    Dim PPU = 0

                    Dim Narration = Me.View_Pur_DemandsDataGridView.Item(5, k).Value
                    Dim remarks = Me.View_Pur_DemandsDataGridView.Item(12, k).Value
                    Try
                        'Tbl_Inv_Tran_InTableAdapter.Insert(DayID.Text, "GDR", Code, Qty, GD, PIID, "", RNO, PPU, CustID, Nothing, 1, UOm, 1, EntryQty, remarks, Narration,)

                    Catch ex As Exception

                    End Try
                End If

            Next

            Me.View_Tran_IN_new_oneTableAdapter.Fill(Me.DSDemand.View_Tran_IN_new_one, DayID.Text)
            MsgBox("Data Saved")
            loadData()


        End If
    End Sub

    Private Sub View_Pur_DemandsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_Pur_DemandsDataGridView.DataError

    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If Me.TabControl1.SelectedTab.Text = "Demand Receiving" Then
            GroupBox1.Visible = True
            GroupBox3.Visible = True
            GroupBox2.Visible = False
            GroupBox4.Visible = False
        ElseIf Me.TabControl1.SelectedTab.Text = "Demand Process" Then
            GroupBox2.Visible = True
            GroupBox4.Visible = True
            GroupBox1.Visible = False
            GroupBox3.Visible = False
        ElseIf Me.TabControl1.SelectedTab.Text = "All Demand Record" Then
            GroupBox1.Visible = True
            GroupBox3.Visible = True
            GroupBox2.Visible = False
            GroupBox4.Visible = False
        ElseIf Me.TabControl1.SelectedTab.Text = "All Demand" Then
            GroupBox1.Visible = True
            GroupBox3.Visible = True
            GroupBox2.Visible = False
            GroupBox4.Visible = False
        End If

    End Sub



    'Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.ValidateChildren()
    '        Me.View_Pur_Demands_AllBindingSource.EndEdit()
    '        Me.View_Pur_Demands_AllTableAdapter.Update(Me.DSDemand.View_Pur_Demands_All)
    '        MsgBox("Record Saved Successfully")
    '        loadData()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs)
        Try
            Me.ValidateChildren()
            Me.Tbl_Pur_Demand_NewBindingSource.EndEdit()
            Me.Tbl_Pur_Demand_NewTableAdapter.Update(Me.DSNewProcurement.tbl_Pur_Demand_New)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frmDemandRec_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Refresh()
        End If
        If e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control Then

            SaveData()

        End If
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        loadIssedData()
    End Sub
End Class