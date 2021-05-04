<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustItems
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
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustItems))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_MM_CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_MM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSCustItems = New FS_ERP_MM.DSCustItems()
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
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.CMSCustStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactPersonTextBox1 = New System.Windows.Forms.TextBox()
        Me.CompanyNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.CMSCustomer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CustomerTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Tbl_MM_Cust_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.Delete = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Add = New System.Windows.Forms.ToolStripButton()
        Me.Save = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_MM_Cust_ItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CMSItemName = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtfilterMatName = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_MM_CurrancyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_MM_CustomerTableAdapter = New FS_ERP_MM.DSCustItemsTableAdapters.tbl_MM_CustomerTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSCustItemsTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSCustItemsTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Inv_MatNameTableAdapter = New FS_ERP_MM.DSCustItemsTableAdapters.tbl_Inv_MatNameTableAdapter()
        Me.Tbl_MM_CurrancyTableAdapter = New FS_ERP_MM.DSCustItemsTableAdapters.tbl_MM_CurrancyTableAdapter()
        Me.Tbl_MM_Cust_ItemsTableAdapter = New FS_ERP_MM.DSCustItemsTableAdapters.tbl_MM_Cust_ItemsTableAdapter()
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.DSCustItemsTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.CompanyNameListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_MatNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ContactPersonLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_MM_CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_MM_CustomerBindingNavigator.SuspendLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCustItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSCustStatus.SuspendLayout()
        Me.CMSCustomer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_MM_Cust_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_Cust_ItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSItemName.SuspendLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_CurrancyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_MatNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.Location = New System.Drawing.Point(15, 61)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(88, 20)
        ContactPersonLabel.TabIndex = 4
        ContactPersonLabel.Text = "Contact Person:"
        ContactPersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.Location = New System.Drawing.Point(215, 36)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(88, 20)
        CompanyNameLabel.TabIndex = 2
        CompanyNameLabel.Text = "Company Name:"
        CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Location = New System.Drawing.Point(15, 36)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(88, 20)
        SupplierIDLabel.TabIndex = 0
        SupplierIDLabel.Text = "Customer No:"
        SupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusLabel
        '
        StatusLabel.Location = New System.Drawing.Point(309, 61)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(45, 20)
        StatusLabel.TabIndex = 9
        StatusLabel.Text = "Status:"
        StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_MM_CustomerBindingNavigator)
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(Me.StatusCheckBox)
        Me.Panel1.Controls.Add(Me.ContactPersonTextBox1)
        Me.Panel1.Controls.Add(Me.CompanyNameTextBox1)
        Me.Panel1.Controls.Add(Me.CustIDTextBox)
        Me.Panel1.Controls.Add(ContactPersonLabel)
        Me.Panel1.Controls.Add(CompanyNameLabel)
        Me.Panel1.Controls.Add(SupplierIDLabel)
        Me.Panel1.Location = New System.Drawing.Point(220, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 90)
        Me.Panel1.TabIndex = 1
        '
        'Tbl_MM_CustomerBindingNavigator
        '
        Me.Tbl_MM_CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_MM_CustomerBindingNavigator.BindingSource = Me.Tbl_MM_CustomerBindingSource
        Me.Tbl_MM_CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_MM_CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_MM_CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_MM_CustomerBindingNavigatorSaveItem})
        Me.Tbl_MM_CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_MM_CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_MM_CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_MM_CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_MM_CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_MM_CustomerBindingNavigator.Name = "Tbl_MM_CustomerBindingNavigator"
        Me.Tbl_MM_CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_MM_CustomerBindingNavigator.Size = New System.Drawing.Size(750, 25)
        Me.Tbl_MM_CustomerBindingNavigator.TabIndex = 5
        Me.Tbl_MM_CustomerBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_MM_CustomerBindingSource
        '
        Me.Tbl_MM_CustomerBindingSource.DataMember = "tbl_MM_Customer"
        Me.Tbl_MM_CustomerBindingSource.DataSource = Me.DSCustItems
        '
        'DSCustItems
        '
        Me.DSCustItems.DataSetName = "DSCustItems"
        Me.DSCustItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Tbl_MM_CustomerBindingNavigatorSaveItem
        '
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_MM_CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.Name = "Tbl_MM_CustomerBindingNavigatorSaveItem"
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.ContextMenuStrip = Me.CMSCustStatus
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_MM_CustomerBindingSource, "Status", True))
        Me.StatusCheckBox.Location = New System.Drawing.Point(360, 61)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(21, 20)
        Me.StatusCheckBox.TabIndex = 8
        Me.StatusCheckBox.TabStop = False
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'CMSCustStatus
        '
        Me.CMSCustStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.CMSCustStatus.Name = "ContextMenuStrip1"
        Me.CMSCustStatus.Size = New System.Drawing.Size(194, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripMenuItem1.Text = "&Active Customers"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripMenuItem2.Text = "&Non Active Customers"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripMenuItem3.Text = "All &Customers"
        '
        'ContactPersonTextBox1
        '
        Me.ContactPersonTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "ContactPerson", True))
        Me.ContactPersonTextBox1.Location = New System.Drawing.Point(109, 61)
        Me.ContactPersonTextBox1.Name = "ContactPersonTextBox1"
        Me.ContactPersonTextBox1.Size = New System.Drawing.Size(194, 20)
        Me.ContactPersonTextBox1.TabIndex = 5
        '
        'CompanyNameTextBox1
        '
        Me.CompanyNameTextBox1.ContextMenuStrip = Me.CMSCustomer
        Me.CompanyNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox1.Location = New System.Drawing.Point(309, 36)
        Me.CompanyNameTextBox1.Name = "CompanyNameTextBox1"
        Me.CompanyNameTextBox1.Size = New System.Drawing.Size(299, 20)
        Me.CompanyNameTextBox1.TabIndex = 5
        '
        'CMSCustomer
        '
        Me.CMSCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerTextBox, Me.RemoveFilterToolStripMenuItem, Me.AscendingOrderToolStripMenuItem, Me.DescendingOrderToolStripMenuItem, Me.RemoveOrderToolStripMenuItem})
        Me.CMSCustomer.Name = "SupplierContextMenuStrip"
        Me.CMSCustomer.Size = New System.Drawing.Size(170, 117)
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CustomerTextBox.Text = "Enter Customer Name"
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove &Filter"
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
        'CustIDTextBox
        '
        Me.CustIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "CustID", True))
        Me.CustIDTextBox.Location = New System.Drawing.Point(109, 36)
        Me.CustIDTextBox.Name = "CustIDTextBox"
        Me.CustIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustIDTextBox.TabIndex = 5
        Me.CustIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1139, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customers Items"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.Tbl_MM_Cust_ItemsDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(220, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 518)
        Me.Panel2.TabIndex = 4
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_MM_Cust_ItemsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.Delete
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.Add, Me.Delete, Me.Save})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(750, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'Tbl_MM_Cust_ItemsBindingSource
        '
        Me.Tbl_MM_Cust_ItemsBindingSource.DataMember = "tbl_MM_Customer_tbl_MM_Cust_Items"
        Me.Tbl_MM_Cust_ItemsBindingSource.DataSource = Me.Tbl_MM_CustomerBindingSource
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'Delete
        '
        Me.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.Name = "Delete"
        Me.Delete.RightToLeftAutoMirrorImage = True
        Me.Delete.Size = New System.Drawing.Size(23, 22)
        Me.Delete.Text = "Delete"
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
        'Add
        '
        Me.Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Add.Image = CType(resources.GetObject("Add.Image"), System.Drawing.Image)
        Me.Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(23, 22)
        Me.Add.Text = "Add new"
        '
        'Save
        '
        Me.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(23, 22)
        Me.Save.Text = "&Save"
        '
        'Tbl_MM_Cust_ItemsDataGridView
        '
        Me.Tbl_MM_Cust_ItemsDataGridView.AllowUserToAddRows = False
        Me.Tbl_MM_Cust_ItemsDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_MM_Cust_ItemsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_MM_Cust_ItemsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_MM_Cust_ItemsDataGridView.ColumnHeadersHeight = 46
        Me.Tbl_MM_Cust_ItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8})
        Me.Tbl_MM_Cust_ItemsDataGridView.DataSource = Me.Tbl_MM_Cust_ItemsBindingSource
        Me.Tbl_MM_Cust_ItemsDataGridView.Location = New System.Drawing.Point(3, 27)
        Me.Tbl_MM_Cust_ItemsDataGridView.Name = "Tbl_MM_Cust_ItemsDataGridView"
        Me.Tbl_MM_Cust_ItemsDataGridView.Size = New System.Drawing.Size(744, 486)
        Me.Tbl_MM_Cust_ItemsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CustID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CustID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustItemID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Serial No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
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
        Me.DataGridViewTextBoxColumn3.Width = 190
        '
        'CMSItemName
        '
        Me.CMSItemName.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtfilterMatName, Me.ToolStripMenuItem4})
        Me.CMSItemName.Name = "ContextMenuStrip1"
        Me.CMSItemName.Size = New System.Drawing.Size(166, 51)
        '
        'txtfilterMatName
        '
        Me.txtfilterMatName.ForeColor = System.Drawing.Color.Silver
        Me.txtfilterMatName.Name = "txtfilterMatName"
        Me.txtfilterMatName.Size = New System.Drawing.Size(105, 23)
        Me.txtfilterMatName.Text = "Enter Material Name"
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
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSCustItems
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Curency"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.Tbl_MM_CurrancyBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.DisplayMember = "Currancy"
        Me.DataGridViewTextBoxColumn4.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Curency"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "Currancy"
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'Tbl_MM_CurrancyBindingSource
        '
        Me.Tbl_MM_CurrancyBindingSource.DataMember = "tbl_MM_Currancy"
        Me.Tbl_MM_CurrancyBindingSource.DataSource = Me.DSCustItems
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UOM"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.Tbl_Pur_UnitOfMeasurementBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.DisplayMember = "UOM"
        Me.DataGridViewTextBoxColumn6.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "UOM"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataMember = "tbl_Pur_UnitOfMeasurement"
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DSCustItems
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RegDate"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "d"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn7.HeaderText = "Reg Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UpdateDate"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "d"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn8.HeaderText = "Update Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'Tbl_MM_CustomerTableAdapter
        '
        Me.Tbl_MM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_CodeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager.tbl_Inv_MatNameTableAdapter = Me.Tbl_Inv_MatNameTableAdapter
        Me.TableAdapterManager.tbl_MM_CurrancyTableAdapter = Me.Tbl_MM_CurrancyTableAdapter
        Me.TableAdapterManager.tbl_MM_Cust_ItemsTableAdapter = Me.Tbl_MM_Cust_ItemsTableAdapter
        Me.TableAdapterManager.tbl_MM_CustomerTableAdapter = Me.Tbl_MM_CustomerTableAdapter
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Me.Tbl_Pur_UnitOfMeasurementTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSCustItemsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_MatNameTableAdapter
        '
        Me.Tbl_Inv_MatNameTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_CurrancyTableAdapter
        '
        Me.Tbl_MM_CurrancyTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_Cust_ItemsTableAdapter
        '
        Me.Tbl_MM_Cust_ItemsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
        '
        'CompanyNameListBox
        '
        Me.CompanyNameListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_MM_CustomerBindingSource, "CustID", True))
        Me.CompanyNameListBox.DataSource = Me.Tbl_MM_CustomerBindingSource
        Me.CompanyNameListBox.DisplayMember = "CompanyName"
        Me.CompanyNameListBox.FormattingEnabled = True
        Me.CompanyNameListBox.Location = New System.Drawing.Point(8, 72)
        Me.CompanyNameListBox.Name = "CompanyNameListBox"
        Me.CompanyNameListBox.Size = New System.Drawing.Size(208, 589)
        Me.CompanyNameListBox.TabIndex = 5
        Me.CompanyNameListBox.ValueMember = "CustID"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(8, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select Customer To Add Items"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_MatNameBindingSource
        '
        Me.Tbl_Inv_MatNameBindingSource.DataSource = Me.DSCustItems
        Me.Tbl_Inv_MatNameBindingSource.Position = 0
        '
        'frmCustItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 689)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CompanyNameListBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCustItems"
        Me.Text = "Customers Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_MM_CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_MM_CustomerBindingNavigator.ResumeLayout(False)
        Me.Tbl_MM_CustomerBindingNavigator.PerformLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCustItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSCustStatus.ResumeLayout(False)
        Me.CMSCustomer.ResumeLayout(False)
        Me.CMSCustomer.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_MM_Cust_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_Cust_ItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSItemName.ResumeLayout(False)
        Me.CMSItemName.PerformLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_CurrancyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_MatNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ContactPersonTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CompanyNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CustIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DSCustItems As FS_ERP_MM.DSCustItems
    Friend WithEvents Tbl_MM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_CustomerTableAdapter As FS_ERP_MM.DSCustItemsTableAdapters.tbl_MM_CustomerTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSCustItemsTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_MM_CustomerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_MM_Cust_ItemsTableAdapter As FS_ERP_MM.DSCustItemsTableAdapters.tbl_MM_Cust_ItemsTableAdapter
    Friend WithEvents Tbl_MM_Cust_ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_Cust_ItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSCustItemsTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_CurrancyTableAdapter As FS_ERP_MM.DSCustItemsTableAdapters.tbl_MM_CurrancyTableAdapter
    Friend WithEvents Tbl_MM_CurrancyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As FS_ERP_MM.DSCustItemsTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents CMSCustomer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CustomerTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyNameListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tbl_MM_CustomerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Add As System.Windows.Forms.ToolStripButton
    Friend WithEvents CMSCustStatus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMSItemName As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtfilterMatName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tbl_Inv_MatNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_MatNameTableAdapter As FS_ERP_MM.DSCustItemsTableAdapters.tbl_Inv_MatNameTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
