<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SupplierTypeLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel1 As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupItems))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CMSSupStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_inv_SupplierTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSupItems = New FS_ERP_MM.DSSupItems()
        Me.CMSCompName = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtFilterSuppliers = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSItemName = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtfilterMatName = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPO = New FS_ERP_MM.DSPO()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.Tbl_Inv_L4BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4TableAdapter1 = New FS_ERP_MM.DSPOTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Pur_UnitofMeasurementDtlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.tbl_Pur_UnitofMeasurementDtlTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSSupItemsTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_inv_SupplierTypeTableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.tbl_inv_SupplierTypeTableAdapter()
        Me.Tbl_Pur_Supplier_CodeTableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.tbl_Pur_Supplier_CodeTableAdapter()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_Supplier_CodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.CompanyNameListBox = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddSupItem = New System.Windows.Forms.ToolStripButton()
        Me.DeleteSupItem = New System.Windows.Forms.ToolStripButton()
        Me.SaveSupplierItem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Pur_Supplier_CodeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Curency = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherCharges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Formula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactPersonTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_Inv_SupplierBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Inv_SupplierBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupplierIDLabel1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        SupplierTypeLabel = New System.Windows.Forms.Label()
        CompanyNameLabel1 = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        ContactPersonLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        Me.CMSSupStatus.SuspendLayout()
        CType(Me.Tbl_inv_SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSupItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSCompName.SuspendLayout()
        Me.CMSItemName.SuspendLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitofMeasurementDtlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_Supplier_CodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Pur_Supplier_CodeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Inv_SupplierBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SupplierTypeLabel
        '
        SupplierTypeLabel.Location = New System.Drawing.Point(211, 48)
        SupplierTypeLabel.Name = "SupplierTypeLabel"
        SupplierTypeLabel.Size = New System.Drawing.Size(104, 20)
        SupplierTypeLabel.TabIndex = 16
        SupplierTypeLabel.Text = "Supplier Type:"
        SupplierTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel1
        '
        CompanyNameLabel1.BackColor = System.Drawing.Color.LightGray
        CompanyNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        CompanyNameLabel1.Location = New System.Drawing.Point(4, 75)
        CompanyNameLabel1.Name = "CompanyNameLabel1"
        CompanyNameLabel1.Size = New System.Drawing.Size(193, 20)
        CompanyNameLabel1.TabIndex = 15
        CompanyNameLabel1.Text = "Select Supplier to Add New Material:"
        CompanyNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusLabel
        '
        StatusLabel.Location = New System.Drawing.Point(305, 61)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(45, 20)
        StatusLabel.TabIndex = 7
        StatusLabel.Text = "Status:"
        StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.Location = New System.Drawing.Point(11, 61)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(88, 20)
        ContactPersonLabel.TabIndex = 4
        ContactPersonLabel.Text = "Contact Person:"
        ContactPersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.Location = New System.Drawing.Point(211, 34)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(88, 20)
        CompanyNameLabel.TabIndex = 2
        CompanyNameLabel.Text = "Company Name:"
        CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Location = New System.Drawing.Point(11, 34)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(88, 20)
        SupplierIDLabel.TabIndex = 0
        SupplierIDLabel.Text = "Supplier No:"
        SupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CMSSupStatus
        '
        Me.CMSSupStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.CMSSupStatus.Name = "ContextMenuStrip1"
        Me.CMSSupStatus.Size = New System.Drawing.Size(185, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem1.Text = "&Active Suppliers"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem2.Text = "&Non Active Suppliers"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem3.Text = "All &Suppliers"
        '
        'Tbl_inv_SupplierTypeBindingSource
        '
        Me.Tbl_inv_SupplierTypeBindingSource.DataMember = "tbl_inv_SupplierType"
        Me.Tbl_inv_SupplierTypeBindingSource.DataSource = Me.DSSupItems
        '
        'DSSupItems
        '
        Me.DSSupItems.DataSetName = "DSSupItems"
        Me.DSSupItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CMSCompName
        '
        Me.CMSCompName.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtFilterSuppliers, Me.RemoveFilterToolStripMenuItem, Me.AscendingOrderToolStripMenuItem, Me.DescendingOrderToolStripMenuItem, Me.RemoveOrderToolStripMenuItem})
        Me.CMSCompName.Name = "ContextMenuStrip1"
        Me.CMSCompName.Size = New System.Drawing.Size(170, 117)
        '
        'txtFilterSuppliers
        '
        Me.txtFilterSuppliers.ForeColor = System.Drawing.Color.Silver
        Me.txtFilterSuppliers.Name = "txtFilterSuppliers"
        Me.txtFilterSuppliers.Size = New System.Drawing.Size(105, 23)
        Me.txtFilterSuppliers.Text = "Enter Company Name"
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "R&emove Filter"
        '
        'AscendingOrderToolStripMenuItem
        '
        Me.AscendingOrderToolStripMenuItem.Name = "AscendingOrderToolStripMenuItem"
        Me.AscendingOrderToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AscendingOrderToolStripMenuItem.Text = "&Ascending Order"
        '
        'DescendingOrderToolStripMenuItem
        '
        Me.DescendingOrderToolStripMenuItem.Name = "DescendingOrderToolStripMenuItem"
        Me.DescendingOrderToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DescendingOrderToolStripMenuItem.Text = "&Descending Order"
        '
        'RemoveOrderToolStripMenuItem
        '
        Me.RemoveOrderToolStripMenuItem.Name = "RemoveOrderToolStripMenuItem"
        Me.RemoveOrderToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RemoveOrderToolStripMenuItem.Text = "&Remove Order"
        '
        'CMSItemName
        '
        Me.CMSItemName.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtfilterMatName, Me.ToolStripMenuItem4})
        Me.CMSItemName.Name = "ContextMenuStrip1"
        Me.CMSItemName.Size = New System.Drawing.Size(166, 51)
        '
        'txtfilterMatName
        '
        Me.txtfilterMatName.ForeColor = System.Drawing.Color.Black
        Me.txtfilterMatName.Name = "txtfilterMatName"
        Me.txtfilterMatName.Size = New System.Drawing.Size(105, 23)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem4.Text = "R&emove Filter"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSSupItems
        '
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataMember = "tbl_Pur_UnitOfMeasurement"
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DSPO
        '
        'DSPO
        '
        Me.DSPO.DataSetName = "DSPO"
        Me.DSPO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1276, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Supplier Items"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4BindingSource1
        '
        Me.Tbl_Inv_L4BindingSource1.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource1.DataSource = Me.DSPO
        '
        'Tbl_Inv_L4TableAdapter1
        '
        Me.Tbl_Inv_L4TableAdapter1.ClearBeforeFill = True
        '
        'Tbl_Pur_UnitofMeasurementDtlBindingSource
        '
        Me.Tbl_Pur_UnitofMeasurementDtlBindingSource.DataSource = Me.DSSupItems
        Me.Tbl_Pur_UnitofMeasurementDtlBindingSource.Position = 0
        '
        'Tbl_Pur_UnitofMeasurementDtlTableAdapter
        '
        Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Me.Tbl_Inv_SupplierTableAdapter
        Me.TableAdapterManager.tbl_inv_SupplierTypeTableAdapter = Me.Tbl_inv_SupplierTypeTableAdapter
        Me.TableAdapterManager.tbl_Pur_Supplier_CodeTableAdapter = Me.Tbl_Pur_Supplier_CodeTableAdapter
        Me.TableAdapterManager.tbl_Pur_UnitofMeasurementDtlTableAdapter = Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSSupItemsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_inv_SupplierTypeTableAdapter
        '
        Me.Tbl_inv_SupplierTypeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_Supplier_CodeTableAdapter
        '
        Me.Tbl_Pur_Supplier_CodeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_inv_SupplierType_tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.Tbl_inv_SupplierTypeBindingSource
        '
        'Tbl_Pur_Supplier_CodeBindingSource
        '
        Me.Tbl_Pur_Supplier_CodeBindingSource.DataMember = "tbl_Inv_Supplier_tbl_Pur_Supplier_Code"
        Me.Tbl_Pur_Supplier_CodeBindingSource.DataSource = Me.Tbl_Inv_SupplierBindingSource
        '
        'SupplierTypeComboBox
        '
        Me.SupplierTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierTypeComboBox.DataSource = Me.Tbl_inv_SupplierTypeBindingSource
        Me.SupplierTypeComboBox.DisplayMember = "SupplierType"
        Me.SupplierTypeComboBox.FormattingEnabled = True
        Me.SupplierTypeComboBox.Location = New System.Drawing.Point(318, 47)
        Me.SupplierTypeComboBox.Name = "SupplierTypeComboBox"
        Me.SupplierTypeComboBox.Size = New System.Drawing.Size(195, 21)
        Me.SupplierTypeComboBox.TabIndex = 17
        Me.SupplierTypeComboBox.ValueMember = "SupplierTypeID"
        '
        'CompanyNameListBox
        '
        Me.CompanyNameListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_SupplierBindingSource, "SupplierID", True))
        Me.CompanyNameListBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.CompanyNameListBox.DisplayMember = "CompanyName"
        Me.CompanyNameListBox.FormattingEnabled = True
        Me.CompanyNameListBox.Location = New System.Drawing.Point(4, 97)
        Me.CompanyNameListBox.Name = "CompanyNameListBox"
        Me.CompanyNameListBox.Size = New System.Drawing.Size(193, 563)
        Me.CompanyNameListBox.TabIndex = 13
        Me.CompanyNameListBox.ValueMember = "SupplierID"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.Tbl_Pur_Supplier_CodeDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(199, 164)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(962, 495)
        Me.Panel2.TabIndex = 14
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Pur_Supplier_CodeBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.AddSupItem, Me.DeleteSupItem, Me.SaveSupplierItem, Me.toolStripSeparator1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(960, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'AddSupItem
        '
        Me.AddSupItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddSupItem.Image = CType(resources.GetObject("AddSupItem.Image"), System.Drawing.Image)
        Me.AddSupItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddSupItem.Name = "AddSupItem"
        Me.AddSupItem.Size = New System.Drawing.Size(23, 22)
        Me.AddSupItem.Text = "Add new"
        '
        'DeleteSupItem
        '
        Me.DeleteSupItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteSupItem.Image = CType(resources.GetObject("DeleteSupItem.Image"), System.Drawing.Image)
        Me.DeleteSupItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteSupItem.Name = "DeleteSupItem"
        Me.DeleteSupItem.Size = New System.Drawing.Size(23, 22)
        Me.DeleteSupItem.Text = "Delete"
        '
        'SaveSupplierItem
        '
        Me.SaveSupplierItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveSupplierItem.Image = CType(resources.GetObject("SaveSupplierItem.Image"), System.Drawing.Image)
        Me.SaveSupplierItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveSupplierItem.Name = "SaveSupplierItem"
        Me.SaveSupplierItem.Size = New System.Drawing.Size(23, 22)
        Me.SaveSupplierItem.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_Pur_Supplier_CodeDataGridView
        '
        Me.Tbl_Pur_Supplier_CodeDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_Pur_Supplier_CodeDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Pur_Supplier_CodeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Pur_Supplier_CodeDataGridView.ColumnHeadersHeight = 32
        Me.Tbl_Pur_Supplier_CodeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Curency, Me.DataGridViewTextBoxColumn4, Me.OtherCharges, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Formula, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn7})
        Me.Tbl_Pur_Supplier_CodeDataGridView.DataSource = Me.Tbl_Pur_Supplier_CodeBindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tbl_Pur_Supplier_CodeDataGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.Tbl_Pur_Supplier_CodeDataGridView.Location = New System.Drawing.Point(2, 26)
        Me.Tbl_Pur_Supplier_CodeDataGridView.Name = "Tbl_Pur_Supplier_CodeDataGridView"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Pur_Supplier_CodeDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.Tbl_Pur_Supplier_CodeDataGridView.RowHeadersWidth = 22
        Me.Tbl_Pur_Supplier_CodeDataGridView.Size = New System.Drawing.Size(955, 464)
        Me.Tbl_Pur_Supplier_CodeDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SupplierID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SupplierID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SupplierCodeID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Serial No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.ContextMenuStrip = Me.CMSItemName
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.Tbl_Inv_L4BindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Code"
        Me.DataGridViewTextBoxColumn3.Width = 280
        '
        'Curency
        '
        Me.Curency.DataPropertyName = "Curency"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Curency.DefaultCellStyle = DataGridViewCellStyle4
        Me.Curency.DisplayStyleForCurrentCellOnly = True
        Me.Curency.HeaderText = "Curency"
        Me.Curency.Items.AddRange(New Object() {"PKR", "$", "¢", "£", "¥", "€", "₤", "₣"})
        Me.Curency.Name = "Curency"
        Me.Curency.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Curency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Curency.Width = 55
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'OtherCharges
        '
        Me.OtherCharges.DataPropertyName = "OtherCharges"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.OtherCharges.DefaultCellStyle = DataGridViewCellStyle6
        Me.OtherCharges.HeaderText = "Other Charges"
        Me.OtherCharges.Name = "OtherCharges"
        Me.OtherCharges.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UOM"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.Tbl_Pur_UnitOfMeasurementBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.DisplayMember = "UOM"
        Me.DataGridViewTextBoxColumn5.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "UOM"
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RegDate"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn6.HeaderText = "Registration Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'Formula
        '
        Me.Formula.DataPropertyName = "Formula"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Formula.DefaultCellStyle = DataGridViewCellStyle9
        Me.Formula.HeaderText = "Formula"
        Me.Formula.Name = "Formula"
        Me.Formula.Width = 70
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.ThreeState = True
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UpdateDate"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn7.HeaderText = "Update Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(Me.StatusCheckBox)
        Me.Panel1.Controls.Add(Me.CompanyNameTextBox)
        Me.Panel1.Controls.Add(Me.ContactPersonTextBox)
        Me.Panel1.Controls.Add(Me.Tbl_Inv_SupplierBindingNavigator)
        Me.Panel1.Controls.Add(ContactPersonLabel)
        Me.Panel1.Controls.Add(CompanyNameLabel)
        Me.Panel1.Controls.Add(SupplierIDLabel)
        Me.Panel1.Controls.Add(Me.SupplierIDLabel1)
        Me.Panel1.Location = New System.Drawing.Point(200, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 90)
        Me.Panel1.TabIndex = 12
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.ContextMenuStrip = Me.CMSSupStatus
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Inv_SupplierBindingSource, "Status", True))
        Me.StatusCheckBox.Location = New System.Drawing.Point(356, 61)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(17, 20)
        Me.StatusCheckBox.TabIndex = 4
        Me.StatusCheckBox.TabStop = False
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.ContextMenuStrip = Me.CMSCompName
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(305, 34)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(389, 20)
        Me.CompanyNameTextBox.TabIndex = 2
        Me.CompanyNameTextBox.TabStop = False
        '
        'ContactPersonTextBox
        '
        Me.ContactPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "ContactPerson", True))
        Me.ContactPersonTextBox.Location = New System.Drawing.Point(105, 61)
        Me.ContactPersonTextBox.Name = "ContactPersonTextBox"
        Me.ContactPersonTextBox.Size = New System.Drawing.Size(194, 20)
        Me.ContactPersonTextBox.TabIndex = 3
        Me.ContactPersonTextBox.TabStop = False
        '
        'Tbl_Inv_SupplierBindingNavigator
        '
        Me.Tbl_Inv_SupplierBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Inv_SupplierBindingNavigator.BindingSource = Me.Tbl_Inv_SupplierBindingSource
        Me.Tbl_Inv_SupplierBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Inv_SupplierBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Inv_SupplierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Inv_SupplierBindingNavigatorSaveItem, Me.ToolStripSeparator2})
        Me.Tbl_Inv_SupplierBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Inv_SupplierBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Inv_SupplierBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Inv_SupplierBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Inv_SupplierBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Inv_SupplierBindingNavigator.Name = "Tbl_Inv_SupplierBindingNavigator"
        Me.Tbl_Inv_SupplierBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Inv_SupplierBindingNavigator.Size = New System.Drawing.Size(721, 25)
        Me.Tbl_Inv_SupplierBindingNavigator.TabIndex = 6
        Me.Tbl_Inv_SupplierBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
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
        'Tbl_Inv_SupplierBindingNavigatorSaveItem
        '
        Me.Tbl_Inv_SupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Inv_SupplierBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Inv_SupplierBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Inv_SupplierBindingNavigatorSaveItem.Name = "Tbl_Inv_SupplierBindingNavigatorSaveItem"
        Me.Tbl_Inv_SupplierBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Inv_SupplierBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SupplierIDLabel1
        '
        Me.SupplierIDLabel1.BackColor = System.Drawing.Color.AliceBlue
        Me.SupplierIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SupplierIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "SupplierID", True))
        Me.SupplierIDLabel1.Location = New System.Drawing.Point(105, 34)
        Me.SupplierIDLabel1.Name = "SupplierIDLabel1"
        Me.SupplierIDLabel1.Size = New System.Drawing.Size(100, 20)
        Me.SupplierIDLabel1.TabIndex = 1
        Me.SupplierIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Red
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Yellow
        Me.btnRefresh.Location = New System.Drawing.Point(646, 44)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(107, 26)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "Refresh"
        Me.ToolTip1.SetToolTip(Me.btnRefresh, " Press F5 To Refresh Records ")
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'frmSupItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1276, 746)
        Me.Controls.Add(SupplierTypeLabel)
        Me.Controls.Add(Me.SupplierTypeComboBox)
        Me.Controls.Add(CompanyNameLabel1)
        Me.Controls.Add(Me.CompanyNameListBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Name = "frmSupItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suppliers Items"
        Me.CMSSupStatus.ResumeLayout(False)
        CType(Me.Tbl_inv_SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSupItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSCompName.ResumeLayout(False)
        Me.CMSCompName.PerformLayout()
        Me.CMSItemName.ResumeLayout(False)
        Me.CMSItemName.PerformLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitofMeasurementDtlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_Supplier_CodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Pur_Supplier_CodeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Inv_SupplierBindingNavigator.ResumeLayout(False)
        Me.Tbl_Inv_SupplierBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSSupItems As FS_ERP_MM.DSSupItems
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents DSPO As FS_ERP_MM.DSPO
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents Tbl_Inv_L4BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter1 As FS_ERP_MM.DSPOTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents CMSCompName As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtFilterSuppliers As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tbl_Pur_UnitofMeasurementDtlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_UnitofMeasurementDtlTableAdapter As FS_ERP_MM.DSSupItemsTableAdapters.tbl_Pur_UnitofMeasurementDtlTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSSupItemsTableAdapters.TableAdapterManager
    Friend WithEvents CMSSupStatus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMSItemName As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtfilterMatName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tbl_inv_SupplierTypeTableAdapter As FS_ERP_MM.DSSupItemsTableAdapters.tbl_inv_SupplierTypeTableAdapter
    Friend WithEvents Tbl_inv_SupplierTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_Supplier_CodeTableAdapter As FS_ERP_MM.DSSupItemsTableAdapters.tbl_Pur_Supplier_CodeTableAdapter
    Friend WithEvents Tbl_Pur_Supplier_CodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CompanyNameListBox As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddSupItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteSupItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveSupplierItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_Pur_Supplier_CodeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CompanyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tbl_Inv_SupplierBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_Inv_SupplierBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SupplierIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Curency As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherCharges As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Formula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
