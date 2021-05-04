Public Class frmProcessDemand
    Private Shared sGDNo As Integer
    Private Shared sPDIDNo As Integer

    Private Shared sItemCode As String
    Private Shared sUOM As String
    Private Shared sPOID As Integer
    Private Shared sSupID As Integer

    Public Property PropertyGDNo() As Integer
        Get
            Return sGDNo
        End Get
        Set(ByVal value As Integer)
            sGDNo = value
        End Set
    End Property
    Public Property PropertyPDIDNo() As Integer
        Get
            Return sPDIDNo
        End Get
        Set(ByVal value As Integer)
            sPDIDNo = value
        End Set
    End Property
    Public Property PropertyItemCode() As String
        Get
            Return sItemCode
        End Get
        Set(ByVal value As String)
            sItemCode = value
        End Set
    End Property
    Public Property PropertyUOM() As String
        Get
            Return sUOM
        End Get
        Set(ByVal value As String)
            sUOM = value
        End Set
    End Property
    Public Property PropertyPOID() As Integer
        Get
            Return sPOID
        End Get
        Set(ByVal value As Integer)
            sPOID = value
        End Set
    End Property
    Public Property PropertySupID() As Integer
        Get
            Return sSupID
        End Get
        Set(ByVal value As Integer)
            sSupID = value
        End Set
    End Property
    Private Sub GMNO_FillBy41()
        If txtGMNO.TextLength > 0 Then
            Try
                Me.Tbl_Pur_DemandTableAdapter.GMNOPOS_FillBy41(Me.DSPO.tbl_Pur_Demand, txtGMNO.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub frmProcessDemand_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ToRefresh()
        End If
    End Sub
    Private Sub frmProcessDemand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Inv_LocalCust1TableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust1)
        Me.View_Rpt_Pur_SupplierItemTableAdapter.Fill(Me.DSPO.View_Rpt_Pur_SupplierItem)
        Me.Tbl_Pur_PO_DTableAdapter.Fill(Me.DSPO.tbl_Pur_PO_D)
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSPO.tbl_Inv_LocalCust)
        Me.Tbl_SuppliersTableAdapter.Fill(Me.DSPO.tbl_Suppliers)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSPO.tbl_Inv_Supplier)
        Me.Tbl_Pur_POTableAdapter.FillBy(Me.DSPO.tbl_Pur_PO)
        Me.Tbl_Inv_L4TableAdapter.FillBy(Me.DSPO.tbl_Inv_L4)
        Me.Tbl_Pur_POBindingSource.MoveLast()
        Me.View_Rpt_Pur_SupplierItemBindingSource.Position = Me.View_Rpt_Pur_SupplierItemBindingSource.Count
        'DateTimePicker1.Value = Me.Tbl_Pur_DemandTableAdapter.FirstDate()
        CodeComboBox.SelectedIndex = 0
        Demand_FillBy1()
        KeyPreview = True
    End Sub
    Private Sub Tbl_Pur_DemandDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Pur_DemandDataGridView.CellContentClick
        Dim PDID As Integer
        Dim PDQty As Double
        Dim UOM As String
        Dim InvCode As String
        Dim SupCodeReturn As Integer
        Dim dgResult As DialogResult
        Dim UnitPrice As Double
        Dim MaxPODID As Integer
        If e.ColumnIndex = 7 And e.RowIndex >= 0 Then
            If Tbl_Pur_DemandDataGridView.Item(7, e.RowIndex).Value Is DBNull.Value Then
                If Tbl_Pur_DemandDataGridView.Item(15, e.RowIndex).Value Is DBNull.Value Then
                    MsgBox("'Other Charges' field was null, So enter Other Charges Amount, If no then enter 0")
                Else
                    PDID = Me.Tbl_Pur_DemandDataGridView(0, e.RowIndex).Value
                    InvCode = Me.Tbl_Pur_DemandDataGridView(3, e.RowIndex).Value
                    PDQty = Me.Tbl_Pur_DemandDataGridView(5, e.RowIndex).Value
                    UOM = Me.Tbl_Pur_DemandDataGridView(6, e.RowIndex).Value
                    SupCodeReturn = Me.Tbl_Pur_Supplier_CodeTableAdapter.FillBy(Me.DSPO.tbl_Pur_Supplier_Code, InvCode, SupplierIDComboBox.SelectedValue)
                    If SupCodeReturn = 1 Then
                        dgResult = MessageBox.Show("Are You Sure! You Want to Generate PO?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If dgResult = Windows.Forms.DialogResult.Yes Then
                            Tbl_Pur_DemandDataGridView.Item(7, e.RowIndex).Value = True
                            Tbl_Pur_DemandDataGridView.Item(8, e.RowIndex).Value = Now.Date
                            If Me.DSPO.tbl_Pur_Supplier_Code(0).Item(4) Is DBNull.Value Then
                                UnitPrice = 0
                            Else
                                UnitPrice = Me.DSPO.tbl_Pur_Supplier_Code(0).Item(4)
                            End If
                            Tbl_Pur_DemandDataGridView.Item(11, e.RowIndex).Value = UnitPrice * PDQty
                            Tbl_Pur_DemandDataGridView.Item(12, e.RowIndex).Value = UnitPrice
                            Tbl_Pur_DemandDataGridView.Item(13, e.RowIndex).Value = Now.Date
                            Tbl_Pur_DemandDataGridView.Item(14, e.RowIndex).Value = SupplierIDComboBox.Text
                            If Me.Tbl_Pur_PO_DTableAdapter.MaxPODID(Val(POIDLabel1.Text)) = Nothing Then
                                MaxPODID = 0
                            Else
                                MaxPODID = Me.Tbl_Pur_PO_DTableAdapter.MaxPODID(Val(POIDLabel1.Text))
                            End If
                            SaveDemand()
                            Me.Tbl_Pur_PO_DTableAdapter.Insert(Val(POIDLabel1.Text), MaxPODID + 1, SupplierIDComboBox.SelectedValue, Me.DSPO.tbl_Pur_Supplier_Code(0).Item(1), PDID, PDQty, Me.DSPO.tbl_Pur_Supplier_Code(0).Item(9), Me.DSPO.tbl_Pur_Supplier_Code(0).Item(4), UOM, Nothing, Now.Date, Nothing, Nothing, Nothing)
                            Me.View_Rpt_Pur_SupplierItemTableAdapter.Fill(Me.DSPO.View_Rpt_Pur_SupplierItem)
                            Me.Tbl_Pur_POBindingSource.Position = Me.Tbl_Pur_POBindingSource.Count
                            Me.View_Rpt_Pur_SupplierItemBindingSource.Position = Me.View_Rpt_Pur_SupplierItemBindingSource.Count
                            Me.Tbl_Pur_DemandBindingSource.RemoveFilter()
                            Me.Tbl_Pur_DemandBindingSource.Filter = "POStatus is null"
                        End If
                    Else
                        MsgBox("Invalid Supplier For the Selected Material")
                    End If
                End If
            End If
        ElseIf e.ColumnIndex = 10 And e.RowIndex >= 0 Then
            If Tbl_Pur_DemandDataGridView.Item(10, e.RowIndex).ReadOnly = False Then
                PropertyPDIDNo = Tbl_Pur_DemandDataGridView.Item(0, e.RowIndex).Value
                PropertyGDNo = Tbl_Pur_DemandDataGridView.Item(1, e.RowIndex).Value
                PropertyItemCode = Me.Tbl_Pur_DemandDataGridView(3, e.RowIndex).Value
                PropertyUOM = Me.Tbl_Pur_DemandDataGridView(6, e.RowIndex).Value
                If Val(POIDLabel1.Text) > 0 Then
                    PropertyPOID = Val(POIDLabel1.Text)
                End If
                If SupplierIDComboBox.SelectedValue <> Nothing Then
                    PropertySupID = SupplierIDComboBox.SelectedValue
                End If
                ChildWindowOpen("frmPartialPO")
            Else
                MsgBox("Partial Status is off")
            End If
        End If
    End Sub
    Private Sub ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.Close()
            End If
        Next
        frmPartialPO.MdiParent = frmMain
        frmPartialPO.Show()
    End Sub
    Private Sub SetButton()
        For i As Integer = 0 To Tbl_Pur_DemandDataGridView.RowCount - 1
            If Tbl_Pur_DemandDataGridView.Item(9, i).Value Is DBNull.Value Then
                Tbl_Pur_DemandDataGridView.Item(10, i).ReadOnly = True
                Tbl_Pur_DemandDataGridView.Item(15, i).ReadOnly = False
            Else
                Tbl_Pur_DemandDataGridView.Item(10, i).ReadOnly = False
                Tbl_Pur_DemandDataGridView.Item(15, i).ReadOnly = True
            End If
        Next
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label2.Enabled = True
            DateTimePicker1.Enabled = True

            Label4.Enabled = True
            DateTimePicker2.Enabled = True

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            Label5.Enabled = False
            CustNameComboBox.Enabled = False
            Me.txtGMNO.Enabled = False
            Demand_FillBy1()

            Me.DateTimePicker1.Select()
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label5.Enabled = False
            CustNameComboBox.Enabled = False

            Label3.Enabled = True
            CodeComboBox.Enabled = True
            Me.txtGMNO.Enabled = False
            Demand_FillBy2()

            Me.CodeComboBox.Select()
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Label2.Enabled = True
            DateTimePicker1.Enabled = True

            Label4.Enabled = True
            DateTimePicker2.Enabled = True

            Label3.Enabled = True
            CodeComboBox.Enabled = True

            Label5.Enabled = False
            CustNameComboBox.Enabled = False
            Me.txtGMNO.Enabled = False
            Demand_FillBy3()

            Me.DateTimePicker1.Select()
        End If
    End Sub
    Private Sub Demand_FillBy1()
        Try
            Me.Tbl_Pur_DemandTableAdapter.FillBy1(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Catch ex As Exception
        End Try
        SetButton()
    End Sub
    Private Sub Demand_FillBy2()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy2(Me.DSPO.tbl_Pur_Demand, CodeComboBox.SelectedValue)
            SetButton()
        End If
    End Sub
    Private Sub Demand_FillBy3()
        If CodeComboBox.SelectedValue <> Nothing Then
            Me.Tbl_Pur_DemandTableAdapter.FillBy3(Me.DSPO.tbl_Pur_Demand, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CodeComboBox.SelectedValue)
            SetButton()
        End If
    End Sub
    Private Sub Demand_FillBy4()
        If CustNameComboBox.SelectedValue <> Nothing Then
            Try
                Me.Tbl_Pur_DemandTableAdapter.FillBy37(Me.DSPO.tbl_Pur_Demand, CustNameComboBox.SelectedValue)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If RadioButton1.Checked Then
            Demand_FillBy1()
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
        End If
    End Sub
    Private Sub CodeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeComboBox.SelectedIndexChanged
        If RadioButton2.Checked Then
            Demand_FillBy2()
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
        End If
    End Sub
    Private Sub SaveDemand()
        Try
            Me.Validate()
            Me.Tbl_Pur_DemandBindingSource.EndEdit()
            Me.Tbl_Pur_DemandTableAdapter.Update(Me.DSPO.tbl_Pur_Demand)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Dim Position As Integer = Me.Tbl_Pur_POBindingSource.Position
        Try
            If Addflag = True Then
                Addflag = False
                Me.Tbl_Pur_POTableAdapter.Insert(POIDLabel1.Text, SupplierIDComboBox.SelectedValue, PODateMaskedTextBox.Text, ReqDateMaskedTextBox.Text, Nothing, SpecialNoteTextBox.Text, Nothing, Nothing, Nothing, 2, Val(Me.DiscountTextBox.Text), Val(Me.TextBox1.Text))
            Else
                Me.Validate()
                Me.Tbl_Pur_POBindingSource.EndEdit()
                Me.Tbl_Pur_POTableAdapter.Update(Me.DSPO.tbl_Pur_PO)
            End If
            Me.Tbl_Pur_POTableAdapter.FillBy(Me.DSPO.tbl_Pur_PO)
            Me.Tbl_Pur_POBindingSource.Position = Position
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ToRefresh()
        If RadioButton1.Checked Then
            Demand_FillBy1()
            MsgBox("Record Refreshed")
        ElseIf RadioButton2.Checked Then
            Demand_FillBy2()
            MsgBox("Record Refreshed")
        ElseIf RadioButton3.Checked Then
            Demand_FillBy3()
            MsgBox("Record Refreshed")
        ElseIf RadioButton5.Checked Then
            GMNO_FillBy41()
            MsgBox("Record Refreshed")
        End If
    End Sub
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If RadioButton1.Checked = True Then
            Demand_FillBy1()
        ElseIf RadioButton3.Checked = True Then
            Demand_FillBy3()
        End If
    End Sub
    Private Sub Tbl_Pur_DemandDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Pur_DemandDataGridView.DataError
    End Sub
    Private Sub Tbl_Pur_PO_DDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.View_Rpt_Pur_SupplierItemTableAdapter.FillBy(Me.DSPO.View_Rpt_Pur_SupplierItem, Val(POIDLabel1.Text))
    End Sub
    Private Sub Tbl_Pur_POBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Pur_POBindingSource.PositionChanged
        Me.View_Rpt_Pur_SupplierItemTableAdapter.FillBy(Me.DSPO.View_Rpt_Pur_SupplierItem, Val(POIDLabel1.Text))
    End Sub
    Private Sub View_Rpt_Pur_SupplierItemDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_Rpt_Pur_SupplierItemDataGridView.DataError
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            Label5.Enabled = True
            CustNameComboBox.Enabled = True
            Me.txtGMNO.Enabled = False
            Demand_FillBy4()
            Me.CustNameComboBox.Select()
        End If
    End Sub
    Private Sub CustNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustNameComboBox.SelectedIndexChanged
        If RadioButton4.Checked Then
            Demand_FillBy4()
        End If
    End Sub
    Private Sub frmProcessDemand_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.View_Rpt_Pur_SupplierItemTableAdapter.FillBy(Me.DSPO.View_Rpt_Pur_SupplierItem, Val(POIDLabel1.Text))
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            CustNameComboBox.Enabled = False

            Label7.Enabled = True
            Me.txtGMNO.Enabled = True

            GMNO_FillBy41()

            Me.txtGMNO.Focus()
        End If
    End Sub
    Private Sub txtGMNO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGMNO.TextChanged
        If RadioButton5.Checked Then
            Label2.Enabled = False
            DateTimePicker1.Enabled = False

            Label4.Enabled = False
            DateTimePicker2.Enabled = False

            Label3.Enabled = False
            CodeComboBox.Enabled = False

            CustNameComboBox.Enabled = False

            Label7.Enabled = True
            Me.txtGMNO.Enabled = True

            GMNO_FillBy41()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ToRefresh()
    End Sub
    Dim Addflag As Boolean = False
    Private Sub AddSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSale.Click
        Addflag = True
        Me.Tbl_Pur_POBindingSource.AddNew()
        Me.POIDLabel1.Text = Me.Tbl_Pur_POTableAdapter.MaxPO()
    End Sub
End Class