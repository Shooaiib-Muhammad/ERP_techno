<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartialRecAmt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PDIDLabel As System.Windows.Forms.Label
        Dim PDDateLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim PDQtyLabel As System.Windows.Forms.Label
        Dim NarrationLabel As System.Windows.Forms.Label
        Dim PRIDLabel As System.Windows.Forms.Label
        Dim PartialQtyLabel As System.Windows.Forms.Label
        Dim PatialRecDateLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim GMNoLabel As System.Windows.Forms.Label
        Dim PartialUnitPriceLabel As System.Windows.Forms.Label
        Dim PartialAmtLabel As System.Windows.Forms.Label
        Dim CashCreditLabel As System.Windows.Forms.Label
        Dim VendorNameLabel As System.Windows.Forms.Label
        Dim OtherChargesLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartialRecAmt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.L4NameLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPO = New FS_ERP_MM.DSPO()
        Me.GMNoLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Pur_DemandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PDDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.NarrationLabel1 = New System.Windows.Forms.Label()
        Me.PDQtyLabel1 = New System.Windows.Forms.Label()
        Me.PDIDLabel1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Tbl_Pur_PartialReceivingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Sec_MiddleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSNewProcurement = New FS_ERP_MM.DSNewProcurement()
        Me.PartialUnitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_PUR_Vendor_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSVendorInfo = New FS_ERP_MM.DSVendorInfo()
        Me.OtherChargesTextBox = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.CashCreditComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PartialAmtTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.PatialRecDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PartialQtyTextBox = New System.Windows.Forms.TextBox()
        Me.PRIDLabel1 = New System.Windows.Forms.Label()
        Me.CodeLabel2 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Pur_DemandTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_DemandTableAdapter()
        Me.Tbl_Pur_PartialReceivingTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_PartialReceivingTableAdapter()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_PUR_Vendor_InfoTableAdapter = New FS_ERP_MM.DSVendorInfoTableAdapters.tbl_PUR_Vendor_InfoTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSVendorInfoTableAdapters.TableAdapterManager()
        Me.Tbl_Sec_MiddleTableAdapter = New FS_ERP_MM.DSNewProcurementTableAdapters.tbl_Sec_MiddleTableAdapter()
        Me.TableAdapterManager1 = New FS_ERP_MM.DSNewProcurementTableAdapters.TableAdapterManager()
        Me.Label6 = New System.Windows.Forms.Label()
        PDIDLabel = New System.Windows.Forms.Label()
        PDDateLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        PDQtyLabel = New System.Windows.Forms.Label()
        NarrationLabel = New System.Windows.Forms.Label()
        PRIDLabel = New System.Windows.Forms.Label()
        PartialQtyLabel = New System.Windows.Forms.Label()
        PatialRecDateLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        GMNoLabel = New System.Windows.Forms.Label()
        PartialUnitPriceLabel = New System.Windows.Forms.Label()
        PartialAmtLabel = New System.Windows.Forms.Label()
        CashCreditLabel = New System.Windows.Forms.Label()
        VendorNameLabel = New System.Windows.Forms.Label()
        OtherChargesLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_DemandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Tbl_Pur_PartialReceivingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_MiddleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSNewProcurement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PUR_Vendor_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSVendorInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PDIDLabel
        '
        PDIDLabel.Location = New System.Drawing.Point(13, 39)
        PDIDLabel.Name = "PDIDLabel"
        PDIDLabel.Size = New System.Drawing.Size(80, 20)
        PDIDLabel.TabIndex = 0
        PDIDLabel.Text = "Serial No:"
        PDIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PDDateLabel
        '
        PDDateLabel.Location = New System.Drawing.Point(339, 39)
        PDDateLabel.Name = "PDDateLabel"
        PDDateLabel.Size = New System.Drawing.Size(80, 20)
        PDDateLabel.TabIndex = 2
        PDDateLabel.Text = "Demand Date:"
        PDDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodeLabel
        '
        CodeLabel.Location = New System.Drawing.Point(13, 66)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(80, 20)
        CodeLabel.TabIndex = 4
        CodeLabel.Text = "Material:"
        CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PDQtyLabel
        '
        PDQtyLabel.Location = New System.Drawing.Point(339, 66)
        PDQtyLabel.Name = "PDQtyLabel"
        PDQtyLabel.Size = New System.Drawing.Size(80, 20)
        PDQtyLabel.TabIndex = 6
        PDQtyLabel.Text = "Demand Qty:"
        PDQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NarrationLabel
        '
        NarrationLabel.Location = New System.Drawing.Point(13, 94)
        NarrationLabel.Name = "NarrationLabel"
        NarrationLabel.Size = New System.Drawing.Size(80, 20)
        NarrationLabel.TabIndex = 8
        NarrationLabel.Text = "Description:"
        NarrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PRIDLabel
        '
        PRIDLabel.Location = New System.Drawing.Point(13, 41)
        PRIDLabel.Name = "PRIDLabel"
        PRIDLabel.Size = New System.Drawing.Size(80, 20)
        PRIDLabel.TabIndex = 0
        PRIDLabel.Text = "Serial No:"
        PRIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PartialQtyLabel
        '
        PartialQtyLabel.Location = New System.Drawing.Point(167, 41)
        PartialQtyLabel.Name = "PartialQtyLabel"
        PartialQtyLabel.Size = New System.Drawing.Size(80, 20)
        PartialQtyLabel.TabIndex = 2
        PartialQtyLabel.Text = "Partial Qty:"
        PartialQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PatialRecDateLabel
        '
        PatialRecDateLabel.Location = New System.Drawing.Point(338, 41)
        PatialRecDateLabel.Name = "PatialRecDateLabel"
        PatialRecDateLabel.Size = New System.Drawing.Size(80, 20)
        PatialRecDateLabel.TabIndex = 4
        PatialRecDateLabel.Text = "Receive Date:"
        PatialRecDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemarksLabel
        '
        RemarksLabel.Location = New System.Drawing.Point(13, 67)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(148, 20)
        RemarksLabel.TabIndex = 10
        RemarksLabel.Text = "Remarks (Demand Officer):"
        RemarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GMNoLabel
        '
        GMNoLabel.Location = New System.Drawing.Point(167, 39)
        GMNoLabel.Name = "GMNoLabel"
        GMNoLabel.Size = New System.Drawing.Size(60, 20)
        GMNoLabel.TabIndex = 13
        GMNoLabel.Text = "G.D. No:"
        GMNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PartialUnitPriceLabel
        '
        PartialUnitPriceLabel.Location = New System.Drawing.Point(61, 113)
        PartialUnitPriceLabel.Name = "PartialUnitPriceLabel"
        PartialUnitPriceLabel.Size = New System.Drawing.Size(100, 20)
        PartialUnitPriceLabel.TabIndex = 13
        PartialUnitPriceLabel.Text = "Partial Unit Price:"
        PartialUnitPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PartialAmtLabel
        '
        PartialAmtLabel.Location = New System.Drawing.Point(257, 112)
        PartialAmtLabel.Name = "PartialAmtLabel"
        PartialAmtLabel.Size = New System.Drawing.Size(116, 20)
        PartialAmtLabel.TabIndex = 14
        PartialAmtLabel.Text = "Partial Amount:"
        PartialAmtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CashCreditLabel
        '
        CashCreditLabel.Location = New System.Drawing.Point(273, 139)
        CashCreditLabel.Name = "CashCreditLabel"
        CashCreditLabel.Size = New System.Drawing.Size(100, 20)
        CashCreditLabel.TabIndex = 13
        CashCreditLabel.Text = "Cash Credit:"
        CashCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VendorNameLabel
        '
        VendorNameLabel.Location = New System.Drawing.Point(45, 213)
        VendorNameLabel.Name = "VendorNameLabel"
        VendorNameLabel.Size = New System.Drawing.Size(116, 20)
        VendorNameLabel.TabIndex = 17
        VendorNameLabel.Text = "Vendor Name:"
        VendorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OtherChargesLabel
        '
        OtherChargesLabel.Location = New System.Drawing.Point(45, 164)
        OtherChargesLabel.Name = "OtherChargesLabel"
        OtherChargesLabel.Size = New System.Drawing.Size(116, 20)
        OtherChargesLabel.TabIndex = 19
        OtherChargesLabel.Text = "Other Charges:"
        OtherChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(273, 164)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(100, 20)
        Label3.TabIndex = 22
        Label3.Text = "Bill No.:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(45, 189)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(116, 20)
        Label4.TabIndex = 23
        Label4.Text = "Register No.:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(273, 189)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(100, 20)
        Label5.TabIndex = 26
        Label5.Text = "GST Amt."
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(64, 239)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(100, 20)
        Label7.TabIndex = 28
        Label7.Text = "Fair Price :"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(918, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Partial Amount Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(GMNoLabel)
        Me.Panel2.Controls.Add(Me.L4NameLabel1)
        Me.Panel2.Controls.Add(Me.GMNoLabel1)
        Me.Panel2.Controls.Add(Me.PDDateMaskedTextBox)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(NarrationLabel)
        Me.Panel2.Controls.Add(PDDateLabel)
        Me.Panel2.Controls.Add(Me.NarrationLabel1)
        Me.Panel2.Controls.Add(PDQtyLabel)
        Me.Panel2.Controls.Add(Me.PDQtyLabel1)
        Me.Panel2.Controls.Add(CodeLabel)
        Me.Panel2.Controls.Add(PDIDLabel)
        Me.Panel2.Controls.Add(Me.PDIDLabel1)
        Me.Panel2.Location = New System.Drawing.Point(101, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(541, 150)
        Me.Panel2.TabIndex = 11
        '
        'L4NameLabel1
        '
        Me.L4NameLabel1.BackColor = System.Drawing.Color.White
        Me.L4NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L4NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource, "L4Name", True))
        Me.L4NameLabel1.Location = New System.Drawing.Point(99, 66)
        Me.L4NameLabel1.Name = "L4NameLabel1"
        Me.L4NameLabel1.Size = New System.Drawing.Size(234, 20)
        Me.L4NameLabel1.TabIndex = 13
        Me.L4NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSPO
        '
        'DSPO
        '
        Me.DSPO.DataSetName = "DSPO"
        Me.DSPO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMNoLabel1
        '
        Me.GMNoLabel1.BackColor = System.Drawing.Color.White
        Me.GMNoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GMNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "GMNo", True))
        Me.GMNoLabel1.Location = New System.Drawing.Point(233, 39)
        Me.GMNoLabel1.Name = "GMNoLabel1"
        Me.GMNoLabel1.Size = New System.Drawing.Size(100, 20)
        Me.GMNoLabel1.TabIndex = 14
        Me.GMNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Pur_DemandBindingSource
        '
        Me.Tbl_Pur_DemandBindingSource.DataMember = "tbl_Pur_Demand"
        Me.Tbl_Pur_DemandBindingSource.DataSource = Me.DSPO
        '
        'PDDateMaskedTextBox
        '
        Me.PDDateMaskedTextBox.BackColor = System.Drawing.Color.White
        Me.PDDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "PDDate", True))
        Me.PDDateMaskedTextBox.Location = New System.Drawing.Point(425, 39)
        Me.PDDateMaskedTextBox.Mask = "00/00/0000"
        Me.PDDateMaskedTextBox.Name = "PDDateMaskedTextBox"
        Me.PDDateMaskedTextBox.ReadOnly = True
        Me.PDDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PDDateMaskedTextBox.TabIndex = 2
        Me.PDDateMaskedTextBox.TabStop = False
        Me.PDDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.Tbl_Pur_DemandBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(539, 25)
        Me.BindingNavigator1.TabIndex = 10
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        Me.BindingNavigatorAddNewItem1.Visible = False
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        Me.BindingNavigatorDeleteItem1.Visible = False
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'NarrationLabel1
        '
        Me.NarrationLabel1.BackColor = System.Drawing.Color.White
        Me.NarrationLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NarrationLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "Narration", True))
        Me.NarrationLabel1.Location = New System.Drawing.Point(99, 94)
        Me.NarrationLabel1.Name = "NarrationLabel1"
        Me.NarrationLabel1.Size = New System.Drawing.Size(426, 40)
        Me.NarrationLabel1.TabIndex = 9
        '
        'PDQtyLabel1
        '
        Me.PDQtyLabel1.BackColor = System.Drawing.Color.White
        Me.PDQtyLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PDQtyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "PDQty", True))
        Me.PDQtyLabel1.Location = New System.Drawing.Point(425, 66)
        Me.PDQtyLabel1.Name = "PDQtyLabel1"
        Me.PDQtyLabel1.Size = New System.Drawing.Size(100, 20)
        Me.PDQtyLabel1.TabIndex = 7
        Me.PDQtyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PDIDLabel1
        '
        Me.PDIDLabel1.BackColor = System.Drawing.Color.White
        Me.PDIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PDIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "PDID", True))
        Me.PDIDLabel1.Location = New System.Drawing.Point(99, 39)
        Me.PDIDLabel1.Name = "PDIDLabel1"
        Me.PDIDLabel1.Size = New System.Drawing.Size(62, 20)
        Me.PDIDLabel1.TabIndex = 1
        Me.PDIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Label7)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Label5)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.ComboBox2)
        Me.Panel3.Controls.Add(Label4)
        Me.Panel3.Controls.Add(Label3)
        Me.Panel3.Controls.Add(Me.PartialUnitPriceTextBox)
        Me.Panel3.Controls.Add(PartialUnitPriceLabel)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(OtherChargesLabel)
        Me.Panel3.Controls.Add(Me.OtherChargesTextBox)
        Me.Panel3.Controls.Add(VendorNameLabel)
        Me.Panel3.Controls.Add(CashCreditLabel)
        Me.Panel3.Controls.Add(Me.MaskedTextBox1)
        Me.Panel3.Controls.Add(Me.CashCreditComboBox)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(PartialAmtLabel)
        Me.Panel3.Controls.Add(Me.PartialAmtTextBox)
        Me.Panel3.Controls.Add(Me.BindingNavigator2)
        Me.Panel3.Controls.Add(RemarksLabel)
        Me.Panel3.Controls.Add(Me.RemarksTextBox)
        Me.Panel3.Controls.Add(PatialRecDateLabel)
        Me.Panel3.Controls.Add(Me.PatialRecDateMaskedTextBox)
        Me.Panel3.Controls.Add(PartialQtyLabel)
        Me.Panel3.Controls.Add(Me.PartialQtyTextBox)
        Me.Panel3.Controls.Add(PRIDLabel)
        Me.Panel3.Controls.Add(Me.PRIDLabel1)
        Me.Panel3.Location = New System.Drawing.Point(101, 234)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 321)
        Me.Panel3.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Linen
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "FairPrice", True))
        Me.TextBox3.Location = New System.Drawing.Point(170, 239)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 27
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tbl_Pur_PartialReceivingBindingSource
        '
        Me.Tbl_Pur_PartialReceivingBindingSource.DataMember = "tbl_Pur_Demand_tbl_Pur_PartialReceiving"
        Me.Tbl_Pur_PartialReceivingBindingSource.DataSource = Me.Tbl_Pur_DemandBindingSource
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Linen
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "GSDAmt", True))
        Me.TextBox2.Location = New System.Drawing.Point(379, 189)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 25
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.BackColor = System.Drawing.Color.Linen
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Pur_PartialReceivingBindingSource, "RegID", True))
        Me.ComboBox2.DataSource = Me.Tbl_Sec_MiddleBindingSource
        Me.ComboBox2.DisplayMember = "MiddleSerial"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(170, 188)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 24
        Me.ComboBox2.ValueMember = "MiddleSerial"
        '
        'Tbl_Sec_MiddleBindingSource
        '
        Me.Tbl_Sec_MiddleBindingSource.DataMember = "tbl_Sec_Middle"
        Me.Tbl_Sec_MiddleBindingSource.DataSource = Me.DSNewProcurement
        '
        'DSNewProcurement
        '
        Me.DSNewProcurement.DataSetName = "DSNewProcurement"
        Me.DSNewProcurement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartialUnitPriceTextBox
        '
        Me.PartialUnitPriceTextBox.BackColor = System.Drawing.Color.Linen
        Me.PartialUnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "PartialUnitPrice", True))
        Me.PartialUnitPriceTextBox.Location = New System.Drawing.Point(170, 113)
        Me.PartialUnitPriceTextBox.Name = "PartialUnitPriceTextBox"
        Me.PartialUnitPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PartialUnitPriceTextBox.TabIndex = 2
        Me.PartialUnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Linen
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "BillNo", True))
        Me.TextBox1.Location = New System.Drawing.Point(379, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.Linen
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Pur_PartialReceivingBindingSource, "VendorName", True))
        Me.ComboBox1.DataSource = Me.Tbl_PUR_Vendor_InfoBindingSource
        Me.ComboBox1.DisplayMember = "VendorName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(170, 212)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(312, 21)
        Me.ComboBox1.TabIndex = 20
        Me.ComboBox1.ValueMember = "VendorName"
        '
        'Tbl_PUR_Vendor_InfoBindingSource
        '
        Me.Tbl_PUR_Vendor_InfoBindingSource.DataMember = "tbl_PUR_Vendor_Info"
        Me.Tbl_PUR_Vendor_InfoBindingSource.DataSource = Me.DSVendorInfo
        '
        'DSVendorInfo
        '
        Me.DSVendorInfo.DataSetName = "DSVendorInfo"
        Me.DSVendorInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OtherChargesTextBox
        '
        Me.OtherChargesTextBox.BackColor = System.Drawing.Color.Linen
        Me.OtherChargesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "OtherCharges", True))
        Me.OtherChargesTextBox.Location = New System.Drawing.Point(170, 164)
        Me.OtherChargesTextBox.Name = "OtherChargesTextBox"
        Me.OtherChargesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OtherChargesTextBox.TabIndex = 5
        Me.OtherChargesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.Linen
        Me.MaskedTextBox1.CausesValidation = False
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "PartialAmtEntryDate", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(170, 139)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 3
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CashCreditComboBox
        '
        Me.CashCreditComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CashCreditComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CashCreditComboBox.BackColor = System.Drawing.Color.Linen
        Me.CashCreditComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "CashCredit", True))
        Me.CashCreditComboBox.FormattingEnabled = True
        Me.CashCreditComboBox.Items.AddRange(New Object() {"Cash", "Cash1", "Cash2", "Cash3", "Cash4", "Cash5", "Cash6", "Cash7", "Cash8", "Cash9", "Cash10", "Credit", "Shaban"})
        Me.CashCreditComboBox.Location = New System.Drawing.Point(379, 138)
        Me.CashCreditComboBox.Name = "CashCreditComboBox"
        Me.CashCreditComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CashCreditComboBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(45, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Partial Amt Entry Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PartialAmtTextBox
        '
        Me.PartialAmtTextBox.BackColor = System.Drawing.Color.Linen
        Me.PartialAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "PartialAmt", True))
        Me.PartialAmtTextBox.Location = New System.Drawing.Point(379, 112)
        Me.PartialAmtTextBox.Name = "PartialAmtTextBox"
        Me.PartialAmtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PartialAmtTextBox.TabIndex = 1
        Me.PartialAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem2
        Me.BindingNavigator2.BindingSource = Me.Tbl_Pur_PartialReceivingBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem2
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem2, Me.SaveToolStripButton, Me.ToolStripSeparator21, Me.ToolStripSeparator20, Me.ToolStripSeparator19, Me.ToolStripSeparator18, Me.ToolStripSeparator17, Me.ToolStripSeparator16, Me.ToolStripSeparator15, Me.ToolStripSeparator14, Me.ToolStripSeparator13, Me.ToolStripSeparator12, Me.ToolStripSeparator11, Me.ToolStripSeparator10, Me.ToolStripSeparator9, Me.ToolStripSeparator8, Me.ToolStripSeparator7, Me.ToolStripSeparator6, Me.ToolStripSeparator5, Me.ToolStripSeparator4, Me.ToolStripSeparator3, Me.ToolStripSeparator2, Me.ToolStripSeparator1, Me.toolStripSeparator, Me.BindingNavigatorDeleteItem2})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator2.Size = New System.Drawing.Size(552, 25)
        Me.BindingNavigator2.TabIndex = 12
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem2"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem2.Text = "Add new"
        Me.BindingNavigatorAddNewItem2.Visible = False
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem2"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem2.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(170, 67)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.ReadOnly = True
        Me.RemarksTextBox.Size = New System.Drawing.Size(358, 40)
        Me.RemarksTextBox.TabIndex = 3
        Me.RemarksTextBox.TabStop = False
        '
        'PatialRecDateMaskedTextBox
        '
        Me.PatialRecDateMaskedTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PatialRecDateMaskedTextBox.CausesValidation = False
        Me.PatialRecDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "PatialRecDate", True))
        Me.PatialRecDateMaskedTextBox.Location = New System.Drawing.Point(425, 41)
        Me.PatialRecDateMaskedTextBox.Mask = "00/00/0000"
        Me.PatialRecDateMaskedTextBox.Name = "PatialRecDateMaskedTextBox"
        Me.PatialRecDateMaskedTextBox.ReadOnly = True
        Me.PatialRecDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PatialRecDateMaskedTextBox.TabIndex = 2
        Me.PatialRecDateMaskedTextBox.TabStop = False
        Me.PatialRecDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PartialQtyTextBox
        '
        Me.PartialQtyTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PartialQtyTextBox.CausesValidation = False
        Me.PartialQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "PartialQty", True))
        Me.PartialQtyTextBox.Location = New System.Drawing.Point(253, 41)
        Me.PartialQtyTextBox.Name = "PartialQtyTextBox"
        Me.PartialQtyTextBox.ReadOnly = True
        Me.PartialQtyTextBox.Size = New System.Drawing.Size(80, 20)
        Me.PartialQtyTextBox.TabIndex = 1
        Me.PartialQtyTextBox.TabStop = False
        Me.PartialQtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PRIDLabel1
        '
        Me.PRIDLabel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PRIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PRIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_PartialReceivingBindingSource, "PRID", True))
        Me.PRIDLabel1.Location = New System.Drawing.Point(99, 41)
        Me.PRIDLabel1.Name = "PRIDLabel1"
        Me.PRIDLabel1.Size = New System.Drawing.Size(62, 20)
        Me.PRIDLabel1.TabIndex = 1
        Me.PRIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CodeLabel2
        '
        Me.CodeLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "Code", True))
        Me.CodeLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.CodeLabel2.Location = New System.Drawing.Point(99, 52)
        Me.CodeLabel2.Name = "CodeLabel2"
        Me.CodeLabel2.Size = New System.Drawing.Size(100, 23)
        Me.CodeLabel2.TabIndex = 13
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_DemandTableAdapter
        '
        Me.Tbl_Pur_DemandTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_PartialReceivingTableAdapter
        '
        Me.Tbl_Pur_PartialReceivingTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSPO
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PUR_Vendor_InfoTableAdapter
        '
        Me.Tbl_PUR_Vendor_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_PUR_Vendor_InfoTableAdapter = Me.Tbl_PUR_Vendor_InfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSVendorInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Sec_MiddleTableAdapter
        '
        Me.Tbl_Sec_MiddleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Bill_DemandTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Dept_InfoTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_DeptTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Pur_Demand_NewTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Pur_PartialReceiving_NewTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Sec_MiddleTableAdapter = Me.Tbl_Sec_MiddleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DSNewProcurementTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(648, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Press Ctrl+S to Save Record"
        '
        'frmPartialRecAmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(918, 644)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CodeLabel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPartialRecAmt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Partial Amount Entry"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_DemandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Tbl_Pur_PartialReceivingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_MiddleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSNewProcurement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PUR_Vendor_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSVendorInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSPO As FS_ERP_MM.DSPO
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents NarrationLabel1 As System.Windows.Forms.Label
    Friend WithEvents PDQtyLabel1 As System.Windows.Forms.Label
    Friend WithEvents PDIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PDDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatialRecDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PartialQtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents L4NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Pur_DemandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_DemandTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_DemandTableAdapter
    Friend WithEvents CodeLabel2 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Pur_PartialReceivingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_PartialReceivingTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_PartialReceivingTableAdapter
    Friend WithEvents GMNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents PartialAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartialUnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CashCreditComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents OtherChargesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DSVendorInfo As FS_ERP_MM.DSVendorInfo
    Friend WithEvents Tbl_PUR_Vendor_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PUR_Vendor_InfoTableAdapter As FS_ERP_MM.DSVendorInfoTableAdapters.tbl_PUR_Vendor_InfoTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSVendorInfoTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DSNewProcurement As FS_ERP_MM.DSNewProcurement
    Friend WithEvents Tbl_Sec_MiddleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Sec_MiddleTableAdapter As FS_ERP_MM.DSNewProcurementTableAdapters.tbl_Sec_MiddleTableAdapter
    Friend WithEvents TableAdapterManager1 As FS_ERP_MM.DSNewProcurementTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ToolStripSeparator21 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator20 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator19 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
