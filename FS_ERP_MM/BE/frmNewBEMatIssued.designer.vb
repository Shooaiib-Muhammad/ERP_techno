<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewBEMatIssued
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
        Dim InvoiceNoLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim POCodeLabel As System.Windows.Forms.Label
        Dim POLabel As System.Windows.Forms.Label
        Dim ArtCodeLabel As System.Windows.Forms.Label
        Dim ModelNameLabel As System.Windows.Forms.Label
        Dim OrderQtyLabel As System.Windows.Forms.Label
        Dim ArtSizeLabel As System.Windows.Forms.Label
        Dim PODLabel As System.Windows.Forms.Label
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewBEMatIssued))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InvoiceNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Exp_InvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSNewBEMatIssuance = New FS_ERP_MM.DSNewBEMatIssuance()
        Me.Tbl_Pro_PO_HBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_PO_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_PO_EOU_MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Exp_InvTableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Exp_InvTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.TableAdapterManager()
        Me.Tbl_Pro_PO_HTableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Pro_PO_HTableAdapter()
        Me.Tbl_Pro_PO_DTableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Pro_PO_DTableAdapter()
        Me.View_PO_EOU_MaterialTableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_PO_EOU_MaterialTableAdapter()
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.Tbl_BE_Tran_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_BE_Tran_OutTableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_BE_Tran_OutTableAdapter()
        Me.Tbl_BE_Tran_Out1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_BE_Tran_Out1TableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_BE_Tran_Out1TableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ArtCodeLabel1 = New System.Windows.Forms.Label()
        Me.ModelNameLabel1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomerNameLabel1 = New System.Windows.Forms.Label()
        Me.POCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.POLabel1 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.POMLabel1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.OrderQtyLabel1 = New System.Windows.Forms.Label()
        Me.ArtSizeLabel1 = New System.Windows.Forms.Label()
        Me.PODLabel1 = New System.Windows.Forms.Label()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.View_PO_EOU_MaterialDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatWaste = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem3 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem3 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BindingNavigator5 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem4 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem4 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_BE_Tran_OutDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtId = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.View_BE_Mat_BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_BE_Mat_BalanceTableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_BE_Mat_BalanceTableAdapter()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.InvoiceIDLabel1 = New System.Windows.Forms.Label()
        Me.View_BE_Invoice_MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_BE_Invoice_MaterialTableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_BE_Invoice_MaterialTableAdapter()
        Me.View_BE_Invoice_Material1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_BE_Invoice_Material1TableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_BE_Invoice_Material1TableAdapter()
        Me.Tbl_BE_InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_BE_InvoiceTableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_BE_InvoiceTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Tbl_Pro_PO_D1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_PO_D1TableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Pro_PO_D1TableAdapter()
        Me.View_PO_EOU_Material1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_PO_EOU_Material1TableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_PO_EOU_Material1TableAdapter()
        Me.Tbl_Pro_PO_H1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_PO_H1TableAdapter = New FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Pro_PO_H1TableAdapter()
        InvoiceNoLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        POCodeLabel = New System.Windows.Forms.Label()
        POLabel = New System.Windows.Forms.Label()
        ArtCodeLabel = New System.Windows.Forms.Label()
        ModelNameLabel = New System.Windows.Forms.Label()
        OrderQtyLabel = New System.Windows.Forms.Label()
        ArtSizeLabel = New System.Windows.Forms.Label()
        PODLabel = New System.Windows.Forms.Label()
        DateNameLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.Tbl_Exp_InvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSNewBEMatIssuance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_PO_HBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_PO_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_PO_EOU_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_BE_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_BE_Tran_Out1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.View_PO_EOU_MaterialDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator5.SuspendLayout()
        CType(Me.Tbl_BE_Tran_OutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_BE_Mat_BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_BE_Invoice_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_BE_Invoice_Material1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_BE_InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.Tbl_Pro_PO_D1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_PO_EOU_Material1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_PO_H1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceNoLabel
        '
        InvoiceNoLabel.Location = New System.Drawing.Point(242, 45)
        InvoiceNoLabel.Name = "InvoiceNoLabel"
        InvoiceNoLabel.Size = New System.Drawing.Size(62, 20)
        InvoiceNoLabel.TabIndex = 10
        InvoiceNoLabel.Text = "Invoice No:"
        InvoiceNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(388, 31)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(75, 20)
        Label4.TabIndex = 11
        Label4.Text = "Customer No.:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.Location = New System.Drawing.Point(585, 31)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(88, 20)
        CustomerNameLabel.TabIndex = 5
        CustomerNameLabel.Text = "Customer Name:"
        CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POCodeLabel
        '
        POCodeLabel.Location = New System.Drawing.Point(160, 31)
        POCodeLabel.Name = "POCodeLabel"
        POCodeLabel.Size = New System.Drawing.Size(69, 20)
        POCodeLabel.TabIndex = 3
        POCodeLabel.Text = "POCode:"
        POCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POLabel
        '
        POLabel.Location = New System.Drawing.Point(-1, 31)
        POLabel.Name = "POLabel"
        POLabel.Size = New System.Drawing.Size(69, 20)
        POLabel.TabIndex = 1
        POLabel.Text = "PO:"
        POLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ArtCodeLabel
        '
        ArtCodeLabel.Location = New System.Drawing.Point(160, 54)
        ArtCodeLabel.Name = "ArtCodeLabel"
        ArtCodeLabel.Size = New System.Drawing.Size(69, 20)
        ArtCodeLabel.TabIndex = 17
        ArtCodeLabel.Text = "Article No.:"
        ArtCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModelNameLabel
        '
        ModelNameLabel.Location = New System.Drawing.Point(388, 54)
        ModelNameLabel.Name = "ModelNameLabel"
        ModelNameLabel.Size = New System.Drawing.Size(75, 20)
        ModelNameLabel.TabIndex = 15
        ModelNameLabel.Text = "Model Name:"
        ModelNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OrderQtyLabel
        '
        OrderQtyLabel.Location = New System.Drawing.Point(340, 32)
        OrderQtyLabel.Name = "OrderQtyLabel"
        OrderQtyLabel.Size = New System.Drawing.Size(75, 20)
        OrderQtyLabel.TabIndex = 5
        OrderQtyLabel.Text = "Order Qty:"
        OrderQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ArtSizeLabel
        '
        ArtSizeLabel.Location = New System.Drawing.Point(120, 32)
        ArtSizeLabel.Name = "ArtSizeLabel"
        ArtSizeLabel.Size = New System.Drawing.Size(69, 20)
        ArtSizeLabel.TabIndex = 3
        ArtSizeLabel.Text = "Art Size:"
        ArtSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PODLabel
        '
        PODLabel.Location = New System.Drawing.Point(7, 32)
        PODLabel.Name = "PODLabel"
        PODLabel.Size = New System.Drawing.Size(39, 20)
        PODLabel.TabIndex = 1
        PODLabel.Text = "POD:"
        PODLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateNameLabel
        '
        DateNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DateNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateNameLabel.Location = New System.Drawing.Point(7, 29)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(92, 30)
        DateNameLabel.TabIndex = 19
        DateNameLabel.Text = "Transaction Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(-1, 54)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(69, 20)
        Label2.TabIndex = 19
        Label2.Text = "Model No.:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1020, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bill Of Entry Material Issuance Transactions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InvoiceNoComboBox
        '
        Me.InvoiceNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.InvoiceNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.InvoiceNoComboBox.DataSource = Me.Tbl_Exp_InvBindingSource
        Me.InvoiceNoComboBox.DisplayMember = "InvoiceNo"
        Me.InvoiceNoComboBox.FormattingEnabled = True
        Me.InvoiceNoComboBox.Location = New System.Drawing.Point(310, 44)
        Me.InvoiceNoComboBox.Name = "InvoiceNoComboBox"
        Me.InvoiceNoComboBox.Size = New System.Drawing.Size(187, 21)
        Me.InvoiceNoComboBox.TabIndex = 11
        Me.InvoiceNoComboBox.ValueMember = "InvoiceID"
        '
        'Tbl_Exp_InvBindingSource
        '
        Me.Tbl_Exp_InvBindingSource.DataMember = "tbl_Exp_Inv"
        Me.Tbl_Exp_InvBindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'DSNewBEMatIssuance
        '
        Me.DSNewBEMatIssuance.DataSetName = "DSNewBEMatIssuance"
        Me.DSNewBEMatIssuance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Pro_PO_HBindingSource
        '
        Me.Tbl_Pro_PO_HBindingSource.DataMember = "tbl_Exp_Inv_tbl_Pro_PO_H"
        Me.Tbl_Pro_PO_HBindingSource.DataSource = Me.Tbl_Exp_InvBindingSource
        '
        'Tbl_Pro_PO_DBindingSource
        '
        Me.Tbl_Pro_PO_DBindingSource.DataMember = "tbl_Pro_PO_H_tbl_Pro_PO_D"
        Me.Tbl_Pro_PO_DBindingSource.DataSource = Me.Tbl_Pro_PO_HBindingSource
        '
        'View_PO_EOU_MaterialBindingSource
        '
        Me.View_PO_EOU_MaterialBindingSource.DataMember = "tbl_Pro_PO_D_View_PO_EOU_Material"
        Me.View_PO_EOU_MaterialBindingSource.DataSource = Me.Tbl_Pro_PO_DBindingSource
        '
        'Tbl_Exp_InvTableAdapter
        '
        Me.Tbl_Exp_InvTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_BE_InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tbl_BE_Tran_Out1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Exp_InvTableAdapter = Me.Tbl_Exp_InvTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Pro_PO_HTableAdapter
        '
        Me.Tbl_Pro_PO_HTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pro_PO_DTableAdapter
        '
        Me.Tbl_Pro_PO_DTableAdapter.ClearBeforeFill = True
        '
        'View_PO_EOU_MaterialTableAdapter
        '
        Me.View_PO_EOU_MaterialTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'Tbl_BE_Tran_OutBindingSource
        '
        Me.Tbl_BE_Tran_OutBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_BE_Tran_Out"
        Me.Tbl_BE_Tran_OutBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'Tbl_BE_Tran_OutTableAdapter
        '
        Me.Tbl_BE_Tran_OutTableAdapter.ClearBeforeFill = True
        '
        'Tbl_BE_Tran_Out1BindingSource
        '
        Me.Tbl_BE_Tran_Out1BindingSource.DataMember = "tbl_BE_Tran_Out1"
        Me.Tbl_BE_Tran_Out1BindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'Tbl_BE_Tran_Out1TableAdapter
        '
        Me.Tbl_BE_Tran_Out1TableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(ArtCodeLabel)
        Me.Panel1.Controls.Add(Me.ArtCodeLabel1)
        Me.Panel1.Controls.Add(ModelNameLabel)
        Me.Panel1.Controls.Add(Me.ModelNameLabel1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(CustomerNameLabel)
        Me.Panel1.Controls.Add(Me.CustomerNameLabel1)
        Me.Panel1.Controls.Add(POCodeLabel)
        Me.Panel1.Controls.Add(Me.POCodeComboBox)
        Me.Panel1.Controls.Add(POLabel)
        Me.Panel1.Controls.Add(Me.POLabel1)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Location = New System.Drawing.Point(6, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(893, 83)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_HBindingSource, "ModelNo", True))
        Me.Label3.Location = New System.Drawing.Point(74, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ArtCodeLabel1
        '
        Me.ArtCodeLabel1.BackColor = System.Drawing.Color.White
        Me.ArtCodeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ArtCodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_HBindingSource, "ArtCode", True))
        Me.ArtCodeLabel1.Location = New System.Drawing.Point(235, 54)
        Me.ArtCodeLabel1.Name = "ArtCodeLabel1"
        Me.ArtCodeLabel1.Size = New System.Drawing.Size(147, 20)
        Me.ArtCodeLabel1.TabIndex = 18
        Me.ArtCodeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ModelNameLabel1
        '
        Me.ModelNameLabel1.BackColor = System.Drawing.Color.White
        Me.ModelNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ModelNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_HBindingSource, "ModelName", True))
        Me.ModelNameLabel1.Location = New System.Drawing.Point(464, 54)
        Me.ModelNameLabel1.Name = "ModelNameLabel1"
        Me.ModelNameLabel1.Size = New System.Drawing.Size(308, 20)
        Me.ModelNameLabel1.TabIndex = 16
        Me.ModelNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_HBindingSource, "CustCode", True))
        Me.Label5.Location = New System.Drawing.Point(464, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomerNameLabel1
        '
        Me.CustomerNameLabel1.BackColor = System.Drawing.Color.White
        Me.CustomerNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_HBindingSource, "CustomerName", True))
        Me.CustomerNameLabel1.Location = New System.Drawing.Point(680, 31)
        Me.CustomerNameLabel1.Name = "CustomerNameLabel1"
        Me.CustomerNameLabel1.Size = New System.Drawing.Size(196, 20)
        Me.CustomerNameLabel1.TabIndex = 6
        Me.CustomerNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'POCodeComboBox
        '
        Me.POCodeComboBox.DataSource = Me.Tbl_Pro_PO_HBindingSource
        Me.POCodeComboBox.DisplayMember = "POCode"
        Me.POCodeComboBox.FormattingEnabled = True
        Me.POCodeComboBox.Location = New System.Drawing.Point(235, 30)
        Me.POCodeComboBox.Name = "POCodeComboBox"
        Me.POCodeComboBox.Size = New System.Drawing.Size(147, 21)
        Me.POCodeComboBox.TabIndex = 4
        Me.POCodeComboBox.ValueMember = "PO"
        '
        'POLabel1
        '
        Me.POLabel1.BackColor = System.Drawing.Color.White
        Me.POLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_HBindingSource, "PO", True))
        Me.POLabel1.Location = New System.Drawing.Point(74, 31)
        Me.POLabel1.Name = "POLabel1"
        Me.POLabel1.Size = New System.Drawing.Size(80, 20)
        Me.POLabel1.TabIndex = 2
        Me.POLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Pro_PO_HBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(891, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'POMLabel1
        '
        Me.POMLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.POMLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_HBindingSource, "POM", True))
        Me.POMLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.POMLabel1.Location = New System.Drawing.Point(681, 52)
        Me.POMLabel1.Name = "POMLabel1"
        Me.POMLabel1.Size = New System.Drawing.Size(25, 13)
        Me.POMLabel1.TabIndex = 14
        Me.POMLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(OrderQtyLabel)
        Me.Panel3.Controls.Add(Me.OrderQtyLabel1)
        Me.Panel3.Controls.Add(ArtSizeLabel)
        Me.Panel3.Controls.Add(Me.ArtSizeLabel1)
        Me.Panel3.Controls.Add(PODLabel)
        Me.Panel3.Controls.Add(Me.PODLabel1)
        Me.Panel3.Controls.Add(Me.BindingNavigator3)
        Me.Panel3.Location = New System.Drawing.Point(6, 154)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(566, 66)
        Me.Panel3.TabIndex = 15
        '
        'OrderQtyLabel1
        '
        Me.OrderQtyLabel1.BackColor = System.Drawing.Color.White
        Me.OrderQtyLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OrderQtyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_DBindingSource, "OrderQty", True))
        Me.OrderQtyLabel1.Location = New System.Drawing.Point(421, 32)
        Me.OrderQtyLabel1.Name = "OrderQtyLabel1"
        Me.OrderQtyLabel1.Size = New System.Drawing.Size(100, 20)
        Me.OrderQtyLabel1.TabIndex = 6
        Me.OrderQtyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ArtSizeLabel1
        '
        Me.ArtSizeLabel1.BackColor = System.Drawing.Color.White
        Me.ArtSizeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ArtSizeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_DBindingSource, "ArtSize", True))
        Me.ArtSizeLabel1.Location = New System.Drawing.Point(194, 32)
        Me.ArtSizeLabel1.Name = "ArtSizeLabel1"
        Me.ArtSizeLabel1.Size = New System.Drawing.Size(140, 20)
        Me.ArtSizeLabel1.TabIndex = 4
        Me.ArtSizeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PODLabel1
        '
        Me.PODLabel1.BackColor = System.Drawing.Color.White
        Me.PODLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PODLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_PO_DBindingSource, "POD", True))
        Me.PODLabel1.Location = New System.Drawing.Point(52, 32)
        Me.PODLabel1.Name = "PODLabel1"
        Me.PODLabel1.Size = New System.Drawing.Size(64, 20)
        Me.PODLabel1.TabIndex = 2
        Me.PODLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Nothing
        Me.BindingNavigator3.BindingSource = Me.Tbl_Pro_PO_DBindingSource
        Me.BindingNavigator3.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator3.DeleteItem = Nothing
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator3.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator3.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator3.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator3.Size = New System.Drawing.Size(564, 25)
        Me.BindingNavigator3.TabIndex = 0
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
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
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Font = New System.Drawing.Font("Haettenschweiler", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateNameLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.DateNameLabel1.Location = New System.Drawing.Point(106, 29)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(130, 30)
        Me.DateNameLabel1.TabIndex = 18
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.View_PO_EOU_MaterialDataGridView)
        Me.Panel4.Controls.Add(Me.BindingNavigator4)
        Me.Panel4.Location = New System.Drawing.Point(6, 222)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(893, 171)
        Me.Panel4.TabIndex = 20
        '
        'View_PO_EOU_MaterialDataGridView
        '
        Me.View_PO_EOU_MaterialDataGridView.AllowUserToAddRows = False
        Me.View_PO_EOU_MaterialDataGridView.AllowUserToDeleteRows = False
        Me.View_PO_EOU_MaterialDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_PO_EOU_MaterialDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_PO_EOU_MaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_PO_EOU_MaterialDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.MatWaste, Me.DataGridViewTextBoxColumn13, Me.AvailBalance, Me.Balance})
        Me.View_PO_EOU_MaterialDataGridView.DataSource = Me.View_PO_EOU_MaterialBindingSource
        Me.View_PO_EOU_MaterialDataGridView.Location = New System.Drawing.Point(2, 26)
        Me.View_PO_EOU_MaterialDataGridView.Name = "View_PO_EOU_MaterialDataGridView"
        Me.View_PO_EOU_MaterialDataGridView.ReadOnly = True
        Me.View_PO_EOU_MaterialDataGridView.Size = New System.Drawing.Size(886, 142)
        Me.View_PO_EOU_MaterialDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "POM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "POM"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "POD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "POD"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ClientID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ClientID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ModelID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ModelID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ArtID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ArtID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ArtSize"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ArtSize"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "L4Name"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn12.HeaderText = "Material Name"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 250
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "OrderQty"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn8.HeaderText = "Order Qty"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EOUFormula"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn10.HeaderText = "EOU Formula"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ReqMaterial"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn11.HeaderText = "Req Material"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'MatWaste
        '
        Me.MatWaste.DataPropertyName = "MatWaste"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.MatWaste.DefaultCellStyle = DataGridViewCellStyle6
        Me.MatWaste.HeaderText = "Mat Waste"
        Me.MatWaste.Name = "MatWaste"
        Me.MatWaste.ReadOnly = True
        Me.MatWaste.Width = 80
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Unit"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn13.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 70
        '
        'AvailBalance
        '
        Me.AvailBalance.DataPropertyName = "AvailBalance"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AvailBalance.DefaultCellStyle = DataGridViewCellStyle8
        Me.AvailBalance.HeaderText = "Available Qty"
        Me.AvailBalance.Name = "AvailBalance"
        Me.AvailBalance.ReadOnly = True
        Me.AvailBalance.Width = 80
        '
        'Balance
        '
        Me.Balance.DataPropertyName = "Balance"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N4"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Balance.DefaultCellStyle = DataGridViewCellStyle9
        Me.Balance.HeaderText = "Issuance Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        Me.Balance.Width = 80
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Nothing
        Me.BindingNavigator4.BindingSource = Me.View_PO_EOU_MaterialBindingSource
        Me.BindingNavigator4.CountItem = Me.BindingNavigatorCountItem3
        Me.BindingNavigator4.DeleteItem = Nothing
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem3, Me.BindingNavigatorMovePreviousItem3, Me.BindingNavigatorSeparator9, Me.BindingNavigatorPositionItem3, Me.BindingNavigatorCountItem3, Me.BindingNavigatorSeparator10, Me.BindingNavigatorMoveNextItem3, Me.BindingNavigatorMoveLastItem3, Me.BindingNavigatorSeparator11})
        Me.BindingNavigator4.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator4.MoveFirstItem = Me.BindingNavigatorMoveFirstItem3
        Me.BindingNavigator4.MoveLastItem = Me.BindingNavigatorMoveLastItem3
        Me.BindingNavigator4.MoveNextItem = Me.BindingNavigatorMoveNextItem3
        Me.BindingNavigator4.MovePreviousItem = Me.BindingNavigatorMovePreviousItem3
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Me.BindingNavigatorPositionItem3
        Me.BindingNavigator4.Size = New System.Drawing.Size(891, 25)
        Me.BindingNavigator4.TabIndex = 1
        Me.BindingNavigator4.Text = "BindingNavigator4"
        '
        'BindingNavigatorCountItem3
        '
        Me.BindingNavigatorCountItem3.Name = "BindingNavigatorCountItem3"
        Me.BindingNavigatorCountItem3.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem3.Text = "of {0}"
        Me.BindingNavigatorCountItem3.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem3
        '
        Me.BindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem3.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem3.Name = "BindingNavigatorMoveFirstItem3"
        Me.BindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem3.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem3
        '
        Me.BindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem3.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem3.Name = "BindingNavigatorMovePreviousItem3"
        Me.BindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem3.Text = "Move previous"
        '
        'BindingNavigatorSeparator9
        '
        Me.BindingNavigatorSeparator9.Name = "BindingNavigatorSeparator9"
        Me.BindingNavigatorSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem3
        '
        Me.BindingNavigatorPositionItem3.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem3.AutoSize = False
        Me.BindingNavigatorPositionItem3.Name = "BindingNavigatorPositionItem3"
        Me.BindingNavigatorPositionItem3.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem3.Text = "0"
        Me.BindingNavigatorPositionItem3.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem3.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator10
        '
        Me.BindingNavigatorSeparator10.Name = "BindingNavigatorSeparator10"
        Me.BindingNavigatorSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem3
        '
        Me.BindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem3.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem3.Name = "BindingNavigatorMoveNextItem3"
        Me.BindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem3.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem3
        '
        Me.BindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem3.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem3.Name = "BindingNavigatorMoveLastItem3"
        Me.BindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem3.Text = "Move last"
        '
        'BindingNavigatorSeparator11
        '
        Me.BindingNavigatorSeparator11.Name = "BindingNavigatorSeparator11"
        Me.BindingNavigatorSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.BindingNavigator5)
        Me.Panel5.Controls.Add(Me.Tbl_BE_Tran_OutDataGridView)
        Me.Panel5.Location = New System.Drawing.Point(6, 395)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(921, 244)
        Me.Panel5.TabIndex = 21
        '
        'BindingNavigator5
        '
        Me.BindingNavigator5.AddNewItem = Nothing
        Me.BindingNavigator5.BindingSource = Me.Tbl_BE_Tran_OutBindingSource
        Me.BindingNavigator5.CountItem = Me.BindingNavigatorCountItem4
        Me.BindingNavigator5.DeleteItem = Nothing
        Me.BindingNavigator5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem4, Me.BindingNavigatorMovePreviousItem4, Me.BindingNavigatorSeparator12, Me.BindingNavigatorPositionItem4, Me.BindingNavigatorCountItem4, Me.BindingNavigatorSeparator13, Me.BindingNavigatorMoveNextItem4, Me.BindingNavigatorMoveLastItem4, Me.BindingNavigatorSeparator14})
        Me.BindingNavigator5.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator5.MoveFirstItem = Me.BindingNavigatorMoveFirstItem4
        Me.BindingNavigator5.MoveLastItem = Me.BindingNavigatorMoveLastItem4
        Me.BindingNavigator5.MoveNextItem = Me.BindingNavigatorMoveNextItem4
        Me.BindingNavigator5.MovePreviousItem = Me.BindingNavigatorMovePreviousItem4
        Me.BindingNavigator5.Name = "BindingNavigator5"
        Me.BindingNavigator5.PositionItem = Me.BindingNavigatorPositionItem4
        Me.BindingNavigator5.Size = New System.Drawing.Size(919, 25)
        Me.BindingNavigator5.TabIndex = 1
        Me.BindingNavigator5.Text = "BindingNavigator5"
        '
        'BindingNavigatorCountItem4
        '
        Me.BindingNavigatorCountItem4.Name = "BindingNavigatorCountItem4"
        Me.BindingNavigatorCountItem4.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem4.Text = "of {0}"
        Me.BindingNavigatorCountItem4.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem4
        '
        Me.BindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem4.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem4.Name = "BindingNavigatorMoveFirstItem4"
        Me.BindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem4.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem4
        '
        Me.BindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem4.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem4.Name = "BindingNavigatorMovePreviousItem4"
        Me.BindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem4.Text = "Move previous"
        '
        'BindingNavigatorSeparator12
        '
        Me.BindingNavigatorSeparator12.Name = "BindingNavigatorSeparator12"
        Me.BindingNavigatorSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem4
        '
        Me.BindingNavigatorPositionItem4.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem4.AutoSize = False
        Me.BindingNavigatorPositionItem4.Name = "BindingNavigatorPositionItem4"
        Me.BindingNavigatorPositionItem4.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem4.Text = "0"
        Me.BindingNavigatorPositionItem4.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem4.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator13
        '
        Me.BindingNavigatorSeparator13.Name = "BindingNavigatorSeparator13"
        Me.BindingNavigatorSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem4
        '
        Me.BindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem4.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem4.Name = "BindingNavigatorMoveNextItem4"
        Me.BindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem4.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem4
        '
        Me.BindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem4.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem4.Name = "BindingNavigatorMoveLastItem4"
        Me.BindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem4.Text = "Move last"
        '
        'BindingNavigatorSeparator14
        '
        Me.BindingNavigatorSeparator14.Name = "BindingNavigatorSeparator14"
        Me.BindingNavigatorSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_BE_Tran_OutDataGridView
        '
        Me.Tbl_BE_Tran_OutDataGridView.AllowUserToAddRows = False
        Me.Tbl_BE_Tran_OutDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_BE_Tran_OutDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_BE_Tran_OutDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Tbl_BE_Tran_OutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_BE_Tran_OutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn17, Me.POCode, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn23, Me.ArtId})
        Me.Tbl_BE_Tran_OutDataGridView.DataSource = Me.Tbl_BE_Tran_OutBindingSource
        Me.Tbl_BE_Tran_OutDataGridView.Location = New System.Drawing.Point(2, 26)
        Me.Tbl_BE_Tran_OutDataGridView.Name = "Tbl_BE_Tran_OutDataGridView"
        Me.Tbl_BE_Tran_OutDataGridView.ReadOnly = True
        Me.Tbl_BE_Tran_OutDataGridView.Size = New System.Drawing.Size(915, 213)
        Me.Tbl_BE_Tran_OutDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TranId"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn14.HeaderText = "Sr.No."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 80
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DayId"
        Me.DataGridViewTextBoxColumn15.HeaderText = "DayId"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "BEId"
        Me.DataGridViewTextBoxColumn16.HeaderText = "BEId"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "BENumber"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn24.HeaderText = "B/E Number"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 110
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PO"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn17.HeaderText = "PO"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 70
        '
        'POCode
        '
        Me.POCode.DataPropertyName = "POCode"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.POCode.DefaultCellStyle = DataGridViewCellStyle14
        Me.POCode.HeaderText = "PO No."
        Me.POCode.Name = "POCode"
        Me.POCode.ReadOnly = True
        Me.POCode.Width = 110
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "POM"
        Me.DataGridViewTextBoxColumn18.HeaderText = "POM"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "POD"
        Me.DataGridViewTextBoxColumn19.HeaderText = "POD"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "L4Name"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn22.HeaderText = "Material Name"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 250
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "IssuedQty"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn21.HeaderText = "Issued Qty"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 70
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Unit"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn23.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 60
        '
        'ArtId
        '
        Me.ArtId.DataPropertyName = "ArtId"
        Me.ArtId.HeaderText = "Undo Record"
        Me.ArtId.Name = "ArtId"
        Me.ArtId.ReadOnly = True
        Me.ArtId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ArtId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ArtId.Text = "Undo Record"
        Me.ArtId.UseColumnTextForButtonValue = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(515, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 25)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Material Issuance At Invoice Level"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'View_BE_Mat_BalanceBindingSource
        '
        Me.View_BE_Mat_BalanceBindingSource.DataMember = "View_BE_Mat_Balance"
        Me.View_BE_Mat_BalanceBindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'View_BE_Mat_BalanceTableAdapter
        '
        Me.View_BE_Mat_BalanceTableAdapter.ClearBeforeFill = True
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.Location = New System.Drawing.Point(821, 49)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(23, 10)
        Me.DayNoLabel1.TabIndex = 24
        '
        'InvoiceIDLabel1
        '
        Me.InvoiceIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Exp_InvBindingSource, "InvoiceID", True))
        Me.InvoiceIDLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.InvoiceIDLabel1.Location = New System.Drawing.Point(811, 128)
        Me.InvoiceIDLabel1.Name = "InvoiceIDLabel1"
        Me.InvoiceIDLabel1.Size = New System.Drawing.Size(33, 11)
        Me.InvoiceIDLabel1.TabIndex = 25
        '
        'View_BE_Invoice_MaterialBindingSource
        '
        Me.View_BE_Invoice_MaterialBindingSource.DataMember = "View_BE_Invoice_Material"
        Me.View_BE_Invoice_MaterialBindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'View_BE_Invoice_MaterialTableAdapter
        '
        Me.View_BE_Invoice_MaterialTableAdapter.ClearBeforeFill = True
        '
        'View_BE_Invoice_Material1BindingSource
        '
        Me.View_BE_Invoice_Material1BindingSource.DataMember = "View_BE_Invoice_Material1"
        Me.View_BE_Invoice_Material1BindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'View_BE_Invoice_Material1TableAdapter
        '
        Me.View_BE_Invoice_Material1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_BE_InvoiceBindingSource
        '
        Me.Tbl_BE_InvoiceBindingSource.DataMember = "tbl_BE_Invoice"
        Me.Tbl_BE_InvoiceBindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'Tbl_BE_InvoiceTableAdapter
        '
        Me.Tbl_BE_InvoiceTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator2)
        Me.Panel2.Controls.Add(Me.DateNameLabel1)
        Me.Panel2.Controls.Add(DateNameLabel)
        Me.Panel2.Location = New System.Drawing.Point(575, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 66)
        Me.Panel2.TabIndex = 26
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator2.Size = New System.Drawing.Size(248, 25)
        Me.BindingNavigator2.TabIndex = 0
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Exp_InvBindingSource, "InvoiceID", True))
        Me.Label6.Location = New System.Drawing.Point(102, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(905, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 67)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Material  Issuance At PO Level"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Tbl_Pro_PO_D1BindingSource
        '
        Me.Tbl_Pro_PO_D1BindingSource.DataMember = "tbl_Pro_PO_D1"
        Me.Tbl_Pro_PO_D1BindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'Tbl_Pro_PO_D1TableAdapter
        '
        Me.Tbl_Pro_PO_D1TableAdapter.ClearBeforeFill = True
        '
        'View_PO_EOU_Material1BindingSource
        '
        Me.View_PO_EOU_Material1BindingSource.DataMember = "View_PO_EOU_Material1"
        Me.View_PO_EOU_Material1BindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'View_PO_EOU_Material1TableAdapter
        '
        Me.View_PO_EOU_Material1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pro_PO_H1BindingSource
        '
        Me.Tbl_Pro_PO_H1BindingSource.DataMember = "tbl_Pro_PO_H1"
        Me.Tbl_Pro_PO_H1BindingSource.DataSource = Me.DSNewBEMatIssuance
        '
        'Tbl_Pro_PO_H1TableAdapter
        '
        Me.Tbl_Pro_PO_H1TableAdapter.ClearBeforeFill = True
        '
        'frmNewBEMatIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 742)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.InvoiceIDLabel1)
        Me.Controls.Add(Me.DayNoLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(InvoiceNoLabel)
        Me.Controls.Add(Me.InvoiceNoComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.POMLabel1)
        Me.Name = "frmNewBEMatIssued"
        Me.Text = "BE Material Transactions"
        CType(Me.Tbl_Exp_InvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSNewBEMatIssuance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_PO_HBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_PO_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_PO_EOU_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_BE_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_BE_Tran_Out1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.View_PO_EOU_MaterialDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator5.ResumeLayout(False)
        Me.BindingNavigator5.PerformLayout()
        CType(Me.Tbl_BE_Tran_OutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_BE_Mat_BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_BE_Invoice_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_BE_Invoice_Material1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_BE_InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.Tbl_Pro_PO_D1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_PO_EOU_Material1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_PO_H1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSNewBEMatIssuance As FS_ERP_MM.DSNewBEMatIssuance
    Friend WithEvents Tbl_Exp_InvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Exp_InvTableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Exp_InvTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.TableAdapterManager
    Friend WithEvents InvoiceNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Pro_PO_HBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pro_PO_HTableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Pro_PO_HTableAdapter
    Friend WithEvents Tbl_Pro_PO_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pro_PO_DTableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Pro_PO_DTableAdapter
    Friend WithEvents View_PO_EOU_MaterialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_PO_EOU_MaterialTableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_PO_EOU_MaterialTableAdapter
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents Tbl_BE_Tran_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BE_Tran_OutTableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_BE_Tran_OutTableAdapter
    Friend WithEvents Tbl_BE_Tran_Out1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BE_Tran_Out1TableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_BE_Tran_Out1TableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CustomerNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents POCodeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents POLabel1 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ArtCodeLabel1 As System.Windows.Forms.Label
    Friend WithEvents ModelNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents POMLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents OrderQtyLabel1 As System.Windows.Forms.Label
    Friend WithEvents ArtSizeLabel1 As System.Windows.Forms.Label
    Friend WithEvents PODLabel1 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator3 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents View_PO_EOU_MaterialDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatWaste As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator4 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator5 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_BE_Tran_OutDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtId As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents View_BE_Mat_BalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_BE_Mat_BalanceTableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_BE_Mat_BalanceTableAdapter
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents InvoiceIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents View_BE_Invoice_MaterialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_BE_Invoice_MaterialTableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_BE_Invoice_MaterialTableAdapter
    Friend WithEvents View_BE_Invoice_Material1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_BE_Invoice_Material1TableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_BE_Invoice_Material1TableAdapter
    Friend WithEvents Tbl_BE_InvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BE_InvoiceTableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_BE_InvoiceTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Tbl_Pro_PO_D1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pro_PO_D1TableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Pro_PO_D1TableAdapter
    Friend WithEvents View_PO_EOU_Material1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_PO_EOU_Material1TableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.View_PO_EOU_Material1TableAdapter
    Friend WithEvents Tbl_Pro_PO_H1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pro_PO_H1TableAdapter As FS_ERP_MM.DSNewBEMatIssuanceTableAdapters.tbl_Pro_PO_H1TableAdapter
End Class
