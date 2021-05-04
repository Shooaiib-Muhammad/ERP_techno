Public Class frmNewTranOut
    Private Sub frmNewTranOut_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AutoFlag = False
        deleteflag = False
    End Sub

    Private Sub frmNewTranOut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub
    Private Sub frmNewTranOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Inv_Rack_InfoTableAdapter.Fill(Me.DSNewTranOut.tbl_Inv_Rack_Info)
        Catch ex As Exception

        End Try
        Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSNewTranOut.tbl_MM_Customer)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSNewTranOut.tbl_Inv_Supplier)
        Me.Tbl_Inv_ExternalCustTableAdapter.Fill(Me.DSNewTranOut.tbl_Inv_ExternalCust)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSNewTranOut.tbl_Inv_LocalCust)
        Me.Tbl_CompaniesTableAdapter.Fill(Me.DSNewTranOut.tbl_Companies)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSNewTranOut.tbl_Inv_L4)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSNewTranOut.tbl_Pur_UnitOfMeasurement)
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSNewTranOut.tbl_Inv_Tran_Date, CDate(Now.Date))
        Catch ex As System.Exception
        End Try
        Try
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSNewTranOut.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
        Catch ex As Exception
        End Try
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Me.Tbl_Inv_Tran_OutBindingSource.Filter = "TranType='" & Me.TabControl1.SelectedTab.Text & "'"
        KeyPreview = True
        Me.Tbl_Inv_Tran_OutBindingSource.MoveLast()
    End Sub
    Sub Save()
        Try
            Me.Validate()
            Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSNewTranOut.tbl_Inv_Tran_Out)
            'Me.Proc_MM_Inv_BalTableAdapter.FillBy(Me.DSNewTranOut.Proc_MM_Inv_Bal, MatCode)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Dim AutoFlag As Boolean = False
    Sub SaveRecord()
        If deleteflag = False And AutoFlag = False Then
            Save()
            MsgBox("Record Saved Successfully")
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSNewTranOut.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
            Me.Tbl_Inv_Tran_OutBindingSource.MoveLast()
        ElseIf deleteflag = True Then
            Save()
            MsgBox("Record Deleted Successfully")
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSNewTranOut.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
            Me.Tbl_Inv_Tran_OutBindingSource.MoveLast()
            deleteflag = False
        End If
        If AutoFlag = True And deleteflag = False Then
            Save()
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSNewTranOut.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
            Me.Tbl_Inv_Tran_OutBindingSource.MoveLast()
            AutoFlag = False
        End If
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveRecord()
    End Sub
    Dim MatCode As String
    Dim MatBalance, OutQty As Double
    Private Sub View_Issud_MaterialDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Issud_MaterialDataGridView.CellEnter
        If Me.View_Issud_MaterialDataGridView(3, e.RowIndex).Value Is DBNull.Value Or Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value Is DBNull.Value Or Me.View_Issud_MaterialDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
            Me.View_Issud_MaterialDataGridView.Columns(3).ReadOnly = False
            Me.View_Issud_MaterialDataGridView.Columns(4).ReadOnly = False
        Else
            Me.View_Issud_MaterialDataGridView.Columns(3).ReadOnly = True
            Me.View_Issud_MaterialDataGridView.Columns(4).ReadOnly = True
        End If
        If Me.View_Issud_MaterialDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
            Me.View_Issud_MaterialDataGridView(2, e.RowIndex).Value = Me.TabControl1.SelectedTab.Text
        End If
        Try
            If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(6, e.RowIndex).Value.ToString.Length = 0 Then
                Try
                    MatCode = Me.View_Issud_MaterialDataGridView(3, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(MatCode)
                Catch ex As Exception
                End Try
                If MatBalance > 0 Then
                    Try
                        OutQty = Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value
                    Catch ex As Exception
                    End Try
                    If OutQty > MatBalance Then
                        MsgBox("Entered Quantity is Greater Than Material Available Balance")
                        Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value = Me.MatBalance
                    End If
                    If Me.CPPULabel1.Text = Nothing Then
                        CPPULabel1.Text = 0
                    End If
                    If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(3, e.RowIndex).Value.ToString.Length > 0 And View_Issud_MaterialDataGridView(5, e.RowIndex).Value.ToString.Length = 0 Then
                        Me.View_Issud_MaterialDataGridView(5, e.RowIndex).Value = Me.UnitLabel1.Text
                        Me.View_Issud_MaterialDataGridView(8, e.RowIndex).Value = Me.CPPULabel1.Text
                        Me.View_Issud_MaterialDataGridView(9, e.RowIndex).Value = Me.CurrencyLabel1.Text
                    End If
                Else
                    MsgBox("AvailAble Material Is Nill", MsgBoxStyle.Critical)
                    Try
                        Me.Tbl_Inv_Tran_OutBindingSource.ResetBindings(True)
                        Me.Tbl_Inv_Tran_OutBindingSource.RemoveCurrent()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 11 Then
            Dim Obj As New Class_Utility
            Dim Filter As String = "{View_MM_TransferPass.DayNo}= " & Val(DayNoLabel1.Text) & " AND {View_MM_TransferPass.tranoutID}  = " & Me.TranOutIDLabel1.Text
            Obj.LoadReports("\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptMatTransfPass.rpt", Filter, "")
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1(3, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView1(4, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView1(5, e.RowIndex).Value Is DBNull.Value Then
            DataGridView1.Columns(3).ReadOnly = False
            DataGridView1.Columns(4).ReadOnly = False
        Else
            DataGridView1.Columns(3).ReadOnly = True
            DataGridView1.Columns(4).ReadOnly = True
        End If
        Try
            If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(6, e.RowIndex).Value.ToString.Length = 0 Then
                Try
                    MatCode = Me.View_Issud_MaterialDataGridView(3, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(MatCode)
                Catch ex As Exception
                End Try
                If MatBalance > 0 Then
                    Try
                        OutQty = Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value
                    Catch ex As Exception
                    End Try
                    If OutQty > MatBalance Then
                        MsgBox("Entered Quantity is Greater Than Material AvailAble Balance")
                        Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value = Me.MatBalance
                    End If
                    If Me.CPPULabel1.Text = Nothing Then
                        CPPULabel1.Text = 0
                    End If
                    If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(3, e.RowIndex).Value.ToString.Length > 0 And View_Issud_MaterialDataGridView(5, e.RowIndex).Value.ToString.Length = 0 Then
                        Me.View_Issud_MaterialDataGridView(5, e.RowIndex).Value = Me.UnitLabel1.Text
                        Me.View_Issud_MaterialDataGridView(8, e.RowIndex).Value = Me.CPPULabel1.Text
                        Me.View_Issud_MaterialDataGridView(9, e.RowIndex).Value = Me.CurrencyLabel1.Text
                    End If
                Else
                    MsgBox("Available Material Is Nill", MsgBoxStyle.Critical)
                    Try
                        Me.Tbl_Inv_Tran_OutBindingSource.ResetBindings(True)
                        Me.Tbl_Inv_Tran_OutBindingSource.RemoveCurrent()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        SaveRecord()
    End Sub
    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        Me.Tbl_Inv_Tran_OutBindingSource.Filter = "TranType='" & Me.TabControl1.SelectedTab.Text & "'"
    End Sub
    Private Sub DataGridView2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        If DataGridView2(3, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView2(4, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView2(5, e.RowIndex).Value Is DBNull.Value Then
            DataGridView2.Columns(3).ReadOnly = False
            DataGridView2.Columns(4).ReadOnly = False
        Else
            DataGridView2.Columns(3).ReadOnly = True
            DataGridView2.Columns(4).ReadOnly = True
        End If

        If Me.DataGridView2.Item(11, e.RowIndex).Value Is DBNull.Value Then
            Me.DataGridView2.Item(11, e.RowIndex).Value = Now
        End If
        Try
            If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(6, e.RowIndex).Value.ToString.Length = 0 Then
                Try
                    MatCode = Me.View_Issud_MaterialDataGridView(3, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(MatCode)
                Catch ex As Exception
                End Try
                If MatBalance > 0 Then
                    Try
                        OutQty = Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value
                    Catch ex As Exception
                    End Try
                    If OutQty > MatBalance Then
                        MsgBox("Entered Quantity is Greater Than Material Available Balance")
                        Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value = Me.MatBalance
                    End If
                    If Me.CPPULabel1.Text = Nothing Then
                        CPPULabel1.Text = 0
                    End If
                    If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(3, e.RowIndex).Value.ToString.Length > 0 And View_Issud_MaterialDataGridView(5, e.RowIndex).Value.ToString.Length = 0 Then
                        Me.View_Issud_MaterialDataGridView(5, e.RowIndex).Value = Me.UnitLabel1.Text
                        Me.View_Issud_MaterialDataGridView(8, e.RowIndex).Value = Me.CPPULabel1.Text
                        Me.View_Issud_MaterialDataGridView(9, e.RowIndex).Value = Me.CurrencyLabel1.Text
                    End If
                Else
                    MsgBox("Available Material Is Nill", MsgBoxStyle.Critical)
                    Try
                        Me.Tbl_Inv_Tran_OutBindingSource.ResetBindings(True)
                        Me.Tbl_Inv_Tran_OutBindingSource.RemoveCurrent()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView3_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEnter
        If DataGridView3(3, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView3(4, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView3(5, e.RowIndex).Value Is DBNull.Value Then
            DataGridView3.Columns(3).ReadOnly = False
            DataGridView3.Columns(4).ReadOnly = False
        Else
            DataGridView3.Columns(3).ReadOnly = True
            DataGridView3.Columns(4).ReadOnly = True
        End If

        Try
            If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(6, e.RowIndex).Value.ToString.Length = 0 Then
                Try
                    MatCode = Me.View_Issud_MaterialDataGridView(3, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(MatCode)
                Catch ex As Exception
                End Try
                If MatBalance > 0 Then
                    Try
                        OutQty = Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value
                    Catch ex As Exception
                    End Try
                    If OutQty > MatBalance Then
                        MsgBox("Entered Quantity is Greater Than Material Available Balance")
                        Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value = Me.MatBalance
                    End If
                    If Me.CPPULabel1.Text = Nothing Then
                        CPPULabel1.Text = 0
                    End If
                    If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(3, e.RowIndex).Value.ToString.Length > 0 And View_Issud_MaterialDataGridView(5, e.RowIndex).Value.ToString.Length = 0 Then
                        Me.View_Issud_MaterialDataGridView(5, e.RowIndex).Value = Me.UnitLabel1.Text
                        Me.View_Issud_MaterialDataGridView(8, e.RowIndex).Value = Me.CPPULabel1.Text
                        Me.View_Issud_MaterialDataGridView(9, e.RowIndex).Value = Me.CurrencyLabel1.Text
                    End If
                Else
                    MsgBox("Available Material Is Nill", MsgBoxStyle.Critical)
                    Try
                        Me.Tbl_Inv_Tran_OutBindingSource.ResetBindings(True)
                        Me.Tbl_Inv_Tran_OutBindingSource.RemoveCurrent()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView4_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellEnter
        If DataGridView4(3, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView4(4, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView4(5, e.RowIndex).Value Is DBNull.Value Then
            DataGridView4.Columns(3).ReadOnly = False
            DataGridView4.Columns(4).ReadOnly = False
        Else
            DataGridView4.Columns(3).ReadOnly = True
            DataGridView4.Columns(4).ReadOnly = True
        End If
        Try
            If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(6, e.RowIndex).Value.ToString.Length = 0 Then
                Try
                    MatCode = Me.View_Issud_MaterialDataGridView(3, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(MatCode)
                Catch ex As Exception
                End Try
                If MatBalance > 0 Then
                    Try
                        OutQty = Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value
                    Catch ex As Exception
                    End Try
                    If OutQty > MatBalance Then
                        MsgBox("Entered Quantity is Greater Than Material Available Balance")
                        Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value = Me.MatBalance
                    End If
                    If Me.CPPULabel1.Text = Nothing Then
                        CPPULabel1.Text = 0
                    End If
                    If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(3, e.RowIndex).Value.ToString.Length > 0 And View_Issud_MaterialDataGridView(5, e.RowIndex).Value.ToString.Length = 0 Then
                        Me.View_Issud_MaterialDataGridView(5, e.RowIndex).Value = Me.UnitLabel1.Text
                        Me.View_Issud_MaterialDataGridView(8, e.RowIndex).Value = Me.CPPULabel1.Text
                        Me.View_Issud_MaterialDataGridView(9, e.RowIndex).Value = Me.CurrencyLabel1.Text
                    End If
                Else
                    MsgBox("Available Material Is Nill", MsgBoxStyle.Critical)
                    Try
                        Me.Tbl_Inv_Tran_OutBindingSource.ResetBindings(True)
                        Me.Tbl_Inv_Tran_OutBindingSource.RemoveCurrent()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView5_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellEnter
        If DataGridView5(3, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView5(4, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView5(5, e.RowIndex).Value Is DBNull.Value Then
            DataGridView5.Columns(3).ReadOnly = False
            DataGridView5.Columns(4).ReadOnly = False
        Else
            DataGridView5.Columns(3).ReadOnly = True
            DataGridView5.Columns(4).ReadOnly = True
        End If
        If Me.DataGridView5.Item(11, e.RowIndex).Value Is DBNull.Value Then
            Me.DataGridView5.Item(11, e.RowIndex).Value = Now
        End If

        Try
            If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(6, e.RowIndex).Value.ToString.Length = 0 Then
                Try
                    MatCode = Me.View_Issud_MaterialDataGridView(3, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(MatCode)
                Catch ex As Exception
                End Try
                If MatBalance > 0 Then
                    Try
                        OutQty = Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value
                    Catch ex As Exception
                    End Try
                    If OutQty > MatBalance Then
                        MsgBox("Entered Quantity is Greater Than Material Available Balance")
                        Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value = Me.MatBalance
                    End If
                    If Me.CPPULabel1.Text = Nothing Then
                        CPPULabel1.Text = 0
                    End If
                    If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(3, e.RowIndex).Value.ToString.Length > 0 And View_Issud_MaterialDataGridView(5, e.RowIndex).Value.ToString.Length = 0 Then
                        Me.View_Issud_MaterialDataGridView(5, e.RowIndex).Value = Me.UnitLabel1.Text
                        Me.View_Issud_MaterialDataGridView(8, e.RowIndex).Value = Me.CPPULabel1.Text
                        Me.View_Issud_MaterialDataGridView(9, e.RowIndex).Value = Me.CurrencyLabel1.Text
                    End If
                Else
                    MsgBox("AvailAble Material Is Nill", MsgBoxStyle.Critical)
                    Try
                        Me.Tbl_Inv_Tran_OutBindingSource.ResetBindings(True)
                        Me.Tbl_Inv_Tran_OutBindingSource.RemoveCurrent()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        If e.ColumnIndex = 11 Then
            Dim obj As New Class_Utility
            Dim Filter As String = "{View_Mat_OutwardGatePass.DayNo}= " & Val(DayNoLabel1.Text) & " AND {View_Mat_OutwardGatePass.TranOutID}= " & Me.TranOutIDLabel1.Text
            obj.LoadReports("\\Server\myreports$\FSERPMM\Procurement\OtherMaterial\RptMatOutwardGatePass.rpt", Filter, "")
        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        If e.ColumnIndex = 11 Then
            Dim obj As New Class_Utility
            Dim Filter As String = "{View_Inv_PR_GP.DayNo}= " & Val(DayNoLabel1.Text) & "  AND {View_Inv_PR_GP.TranOutID}= " & Val(Me.TranOutIDLabel1.Text)
            obj.LoadReports("\\Server\MyReports$\FSERPMM\Inventory\RptPurchaseReturnGatePass.rpt", Filter, "")
        End If
    End Sub

    Private Sub DataGridView5_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        If e.ColumnIndex = 12 Then
            Dim Obj As New Class_Utility
            Dim Param As String = ""
            Dim Filter As String = "{View_Lended_MM_GP.DayNo} = " & Val(DayNoLabel1.Text) & " AND {View_Lended_MM_GP.Tranoutid}= " & Me.TranOutIDLabel1.Text
            Param = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & ""
            Obj.LoadReports("\\server\myreports$\FSERPMM\Procurement\OtherMaterial\RptLendedMatGatePass.rpt", Filter, Param)


        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.ColumnIndex = 12 Then
            Dim Obj As New Class_Utility
            Dim Filter As String = "{View_Inv_MRGP.DayNo}= " & Val(DayNoLabel1.Text) & " AND {View_Inv_MRGP.TranOutID}= " & Val(Me.TranOutIDLabel1.Text)
            Obj.LoadReports("\\Server\MyReports$\FSERPMM\Inventory\RptMaterialReturnGatePass.rpt", Filter, "")
        End If
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        SaveRecord()
    End Sub

    Private Sub ToolStripButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton29.Click
        SaveRecord()
    End Sub

    Private Sub ToolStripButton36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton36.Click
        SaveRecord()
    End Sub

    Private Sub ToolStripButton43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton43.Click
        SaveRecord()
    End Sub
    Private Sub View_Issud_MaterialDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles View_Issud_MaterialDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub DataGridView2_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView2.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub DataGridView3_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView3.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub DataGridView4_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView4.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub DataGridView5_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView5.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
    Private Sub View_Issud_MaterialDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_Issud_MaterialDataGridView.DataError

    End Sub

    Private Sub DataGridView2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView2.DataError

    End Sub

    Private Sub DataGridView3_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView3.DataError

    End Sub

    Private Sub DataGridView4_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView4.DataError

    End Sub

    Private Sub DataGridView5_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView5.DataError

    End Sub

    Private Sub View_Issud_MaterialDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Issud_MaterialDataGridView.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 7 Then
                AutoFlag = True
                SaveRecord()
            End If
        End If
    End Sub

    Private Sub DataGridView1_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 7 Then
                AutoFlag = True
                SaveRecord()
            End If
        End If
    End Sub

    Private Sub DataGridView2_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 7 Then
                AutoFlag = True
                SaveRecord()
            End If
        End If
    End Sub

    Private Sub DataGridView3_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 7 Then
                AutoFlag = True
                SaveRecord()
            End If
        End If
    End Sub

    Private Sub DataGridView4_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 7 Then
                AutoFlag = True
                SaveRecord()
            End If
        End If
    End Sub
    Private Sub DataGridView5_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 7 Then
                AutoFlag = True
                SaveRecord()
            End If
        End If
    End Sub
    Dim deleteflag As Boolean = False
    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        deleteflag = True
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        deleteflag = True
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        deleteflag = True
    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click
        deleteflag = True
    End Sub

    Private Sub ToolStripButton31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton31.Click
        deleteflag = True
    End Sub
    Private Sub ToolStripButton38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton38.Click
        deleteflag = True
    End Sub
    Private Sub DataGridView6_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick
        If e.ColumnIndex = 11 Then
            Dim Obj As New Class_Utility
            Dim filter As String = "{View_Mat_Sale.DayNo} = " & Val(DayNoLabel1.Text) & " AND {View_Mat_Sale.TranOutID}  = " & Val(Me.TranOutIDLabel1.Text)
            Obj.LoadReports("\\Server\myreports$\FSERPMM\Procurement\OtherMaterial\RptMatOutwardSaleGatePass.rpt", filter, "")
        End If
    End Sub
    Private Sub DataGridView6_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellEnter
        If DataGridView6(3, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView1(4, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView1(5, e.RowIndex).Value Is DBNull.Value Then
            DataGridView6.Columns(3).ReadOnly = False
            DataGridView6.Columns(4).ReadOnly = False
        Else
            DataGridView6.Columns(3).ReadOnly = True
            DataGridView6.Columns(4).ReadOnly = True
        End If
        Try
            If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(6, e.RowIndex).Value.ToString.Length = 0 Then
                Try
                    MatCode = Me.View_Issud_MaterialDataGridView(3, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(MatCode)
                Catch ex As Exception
                End Try
                If MatBalance > 0 Then
                    Try
                        OutQty = Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value
                    Catch ex As Exception
                    End Try
                    If OutQty > MatBalance Then
                        MsgBox("Entered Quantity is Greater Than Material Available Balance")
                        Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value = Me.MatBalance
                    End If
                    If Me.CPPULabel1.Text = Nothing Then
                        CPPULabel1.Text = 0
                    End If
                    If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(3, e.RowIndex).Value.ToString.Length > 0 And View_Issud_MaterialDataGridView(5, e.RowIndex).Value.ToString.Length = 0 Then
                        Me.View_Issud_MaterialDataGridView(5, e.RowIndex).Value = Me.UnitLabel1.Text
                        Me.View_Issud_MaterialDataGridView(8, e.RowIndex).Value = Me.CPPULabel1.Text
                        Me.View_Issud_MaterialDataGridView(9, e.RowIndex).Value = Me.CurrencyLabel1.Text
                    End If
                Else
                    MsgBox("Available Material Is Nill", MsgBoxStyle.Critical)
                    Try
                        Me.Tbl_Inv_Tran_OutBindingSource.ResetBindings(True)
                        Me.Tbl_Inv_Tran_OutBindingSource.RemoveCurrent()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripButton50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton50.Click
        SaveRecord()
    End Sub

    Private Sub ToolStripButton45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton45.Click
        deleteflag = True
    End Sub

    Private Sub DataGridView6_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView6.DataError

    End Sub
    Private Sub DataGridView6_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView6.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub DataGridView6_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 7 Then
                AutoFlag = True
                SaveRecord()
            End If
        End If
    End Sub
    Sub ToRefresh()
        Try
            Dim Position As Integer = Me.Tbl_Inv_Tran_OutBindingSource.Position
            Me.Tbl_Inv_Tran_OutTableAdapter.FillBy(Me.DSNewTranOut.tbl_Inv_Tran_Out, Me.DayNoLabel1.Text)
            Me.Tbl_Inv_Tran_OutBindingSource.Position = Position
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView7_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellEnter
        If DataGridView7(3, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView7(4, e.RowIndex).Value Is DBNull.Value Or Me.DataGridView7(5, e.RowIndex).Value Is DBNull.Value Then
            DataGridView7.Columns(3).ReadOnly = False
            DataGridView7.Columns(4).ReadOnly = False
        Else
            DataGridView7.Columns(3).ReadOnly = True
            DataGridView7.Columns(4).ReadOnly = True
        End If
        Try
            If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(6, e.RowIndex).Value.ToString.Length = 0 Then
                Try
                    MatCode = Me.View_Issud_MaterialDataGridView(3, e.RowIndex).Value
                Catch ex As Exception
                End Try
                Try
                    MatBalance = Me.Proc_MM_Inv_BalTableAdapter.SelectQuery(MatCode)
                Catch ex As Exception
                End Try
                If MatBalance > 0 Then
                    Try
                        OutQty = Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value
                    Catch ex As Exception
                    End Try
                    If OutQty > MatBalance Then
                        MsgBox("Entered Quantity is Greater Than Material Available Balance")
                        Me.View_Issud_MaterialDataGridView(4, e.RowIndex).Value = Me.MatBalance
                    End If
                    If Me.CPPULabel1.Text = Nothing Then
                        CPPULabel1.Text = 0
                    End If
                    If e.ColumnIndex = 5 And View_Issud_MaterialDataGridView(3, e.RowIndex).Value.ToString.Length > 0 And View_Issud_MaterialDataGridView(5, e.RowIndex).Value.ToString.Length = 0 Then
                        Me.View_Issud_MaterialDataGridView(5, e.RowIndex).Value = Me.UnitLabel1.Text
                        Me.View_Issud_MaterialDataGridView(8, e.RowIndex).Value = Me.CPPULabel1.Text
                        Me.View_Issud_MaterialDataGridView(9, e.RowIndex).Value = Me.CurrencyLabel1.Text
                    End If
                Else
                    MsgBox("Available Material Is Nill", MsgBoxStyle.Critical)
                    Try
                        Me.Tbl_Inv_Tran_OutBindingSource.ResetBindings(True)
                        Me.Tbl_Inv_Tran_OutBindingSource.RemoveCurrent()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView7_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView7.DataError

    End Sub

    Private Sub DataGridView7_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView7.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub DataGridView7_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.RowLeave
        If RadioButton1.Checked = True Then
            If e.ColumnIndex = 7 Then
                AutoFlag = True
                SaveRecord()
            End If
        End If
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        SaveRecord()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ToRefresh()
    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        ToRefresh()
    End Sub

    Private Sub View_Issud_MaterialDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Issud_MaterialDataGridView.CellContentClick

    End Sub



    Private Sub DataGridView7_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick

    End Sub
End Class