<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurOrders
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
        Dim SupplierTypeLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim SpecialNoteLabel As System.Windows.Forms.Label
        Dim ReqDateLabel As System.Windows.Forms.Label
        Dim POIDLabel As System.Windows.Forms.Label
        Dim PODateLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurOrders))
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupplierTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_inv_SupplierTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPurOrder = New FS_ERP_MM.DSPurOrder()
        Me.Tbl_inv_SupplierTypeTableAdapter = New FS_ERP_MM.DSPurOrderTableAdapters.tbl_inv_SupplierTypeTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSPurOrderTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSPurOrderTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_Pur_PO_DTableAdapter = New FS_ERP_MM.DSPurOrderTableAdapters.tbl_Pur_PO_DTableAdapter()
        Me.Tbl_Pur_POTableAdapter = New FS_ERP_MM.DSPurOrderTableAdapters.tbl_Pur_POTableAdapter()
        Me.Tbl_Pur_POBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_PO_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_Supplier_CodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_Supplier_CodeTableAdapter = New FS_ERP_MM.DSPurOrderTableAdapters.tbl_Pur_Supplier_CodeTableAdapter()
        Me.View_Supplier_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Supplier_ItemsTableAdapter = New FS_ERP_MM.DSPurOrderTableAdapters.View_Supplier_ItemsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ImportStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.Formula = New System.Windows.Forms.Label()
        Me.NewReqDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CMNewReqDate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewReqDateTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialNoteTextBox = New System.Windows.Forms.TextBox()
        Me.ReqDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CMReqDate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReqDateTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.POIDLabel2 = New System.Windows.Forms.Label()
        Me.CMPONO = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PONOTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_Pur_POBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AddSale = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Pur_POBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PODateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CMOrderDate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OrderDateTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CMSupplierName = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuplierNameTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierType = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tbl_Pur_PO_DDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherCharges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSTTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CurencyLabel1 = New System.Windows.Forms.Label()
        Me.UnitPriceLabel1 = New System.Windows.Forms.Label()
        Me.UOMLabel1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        SupplierTypeLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        SpecialNoteLabel = New System.Windows.Forms.Label()
        ReqDateLabel = New System.Windows.Forms.Label()
        POIDLabel = New System.Windows.Forms.Label()
        PODateLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_inv_SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPurOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_PO_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_Supplier_CodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Supplier_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CMNewReqDate.SuspendLayout()
        Me.CMReqDate.SuspendLayout()
        Me.CMPONO.SuspendLayout()
        CType(Me.Tbl_Pur_POBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Pur_POBindingNavigator.SuspendLayout()
        Me.CMOrderDate.SuspendLayout()
        Me.CMSupplierName.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Pur_PO_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SupplierTypeLabel
        '
        SupplierTypeLabel.Location = New System.Drawing.Point(168, 47)
        SupplierTypeLabel.Name = "SupplierTypeLabel"
        SupplierTypeLabel.Size = New System.Drawing.Size(100, 21)
        SupplierTypeLabel.TabIndex = 4
        SupplierTypeLabel.Text = "Supplier Type:"
        SupplierTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(631, 32)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(105, 20)
        Label2.TabIndex = 11
        Label2.Text = "New Required Date:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SpecialNoteLabel
        '
        SpecialNoteLabel.Location = New System.Drawing.Point(3, 83)
        SpecialNoteLabel.Name = "SpecialNoteLabel"
        SpecialNoteLabel.Size = New System.Drawing.Size(96, 20)
        SpecialNoteLabel.TabIndex = 9
        SpecialNoteLabel.Text = "Special Note:"
        SpecialNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ReqDateLabel
        '
        ReqDateLabel.Location = New System.Drawing.Point(419, 32)
        ReqDateLabel.Name = "ReqDateLabel"
        ReqDateLabel.Size = New System.Drawing.Size(100, 20)
        ReqDateLabel.TabIndex = 7
        ReqDateLabel.Text = "Required Date:"
        ReqDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POIDLabel
        '
        POIDLabel.Location = New System.Drawing.Point(3, 32)
        POIDLabel.Name = "POIDLabel"
        POIDLabel.Size = New System.Drawing.Size(96, 20)
        POIDLabel.TabIndex = 0
        POIDLabel.Text = "PO Number:"
        POIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PODateLabel
        '
        PODateLabel.Location = New System.Drawing.Point(207, 32)
        PODateLabel.Name = "PODateLabel"
        PODateLabel.Size = New System.Drawing.Size(100, 20)
        PODateLabel.TabIndex = 2
        PODateLabel.Text = "Order Date:"
        PODateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Location = New System.Drawing.Point(3, 57)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(96, 20)
        SupplierIDLabel.TabIndex = 4
        SupplierIDLabel.Text = "Supplier:"
        SupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1205, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Purchase Order (PO)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SupplierTypeComboBox
        '
        Me.SupplierTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierTypeComboBox.DataSource = Me.Tbl_inv_SupplierTypeBindingSource
        Me.SupplierTypeComboBox.DisplayMember = "SupplierType"
        Me.SupplierTypeComboBox.FormattingEnabled = True
        Me.SupplierTypeComboBox.Location = New System.Drawing.Point(279, 47)
        Me.SupplierTypeComboBox.Name = "SupplierTypeComboBox"
        Me.SupplierTypeComboBox.Size = New System.Drawing.Size(165, 21)
        Me.SupplierTypeComboBox.TabIndex = 5
        Me.SupplierTypeComboBox.ValueMember = "SupplierTypeID"
        '
        'Tbl_inv_SupplierTypeBindingSource
        '
        Me.Tbl_inv_SupplierTypeBindingSource.DataMember = "tbl_inv_SupplierType"
        Me.Tbl_inv_SupplierTypeBindingSource.DataSource = Me.DSPurOrder
        '
        'DSPurOrder
        '
        Me.DSPurOrder.DataSetName = "DSPurOrder"
        Me.DSPurOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_inv_SupplierTypeTableAdapter
        '
        Me.Tbl_inv_SupplierTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Me.Tbl_Inv_SupplierTableAdapter
        Me.TableAdapterManager.tbl_inv_SupplierTypeTableAdapter = Me.Tbl_inv_SupplierTypeTableAdapter
        Me.TableAdapterManager.tbl_Pur_PO_DTableAdapter = Me.Tbl_Pur_PO_DTableAdapter
        Me.TableAdapterManager.tbl_Pur_POTableAdapter = Me.Tbl_Pur_POTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSPurOrderTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_PO_DTableAdapter
        '
        Me.Tbl_Pur_PO_DTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_POTableAdapter
        '
        Me.Tbl_Pur_POTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_POBindingSource
        '
        Me.Tbl_Pur_POBindingSource.DataMember = "tbl_inv_SupplierType_tbl_Pur_PO"
        Me.Tbl_Pur_POBindingSource.DataSource = Me.Tbl_inv_SupplierTypeBindingSource
        '
        'Tbl_Pur_PO_DBindingSource
        '
        Me.Tbl_Pur_PO_DBindingSource.DataMember = "tbl_Pur_PO_tbl_Pur_PO_D"
        Me.Tbl_Pur_PO_DBindingSource.DataSource = Me.Tbl_Pur_POBindingSource
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
        'Tbl_Pur_Supplier_CodeTableAdapter
        '
        Me.Tbl_Pur_Supplier_CodeTableAdapter.ClearBeforeFill = True
        '
        'View_Supplier_ItemsBindingSource
        '
        Me.View_Supplier_ItemsBindingSource.DataMember = "tbl_Inv_Supplier_View_Supplier_Items"
        Me.View_Supplier_ItemsBindingSource.DataSource = Me.Tbl_Inv_SupplierBindingSource
        '
        'View_Supplier_ItemsTableAdapter
        '
        Me.View_Supplier_ItemsTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ImportStatusCheckBox)
        Me.Panel1.Controls.Add(Me.Formula)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.NewReqDateMaskedTextBox)
        Me.Panel1.Controls.Add(SpecialNoteLabel)
        Me.Panel1.Controls.Add(Me.SpecialNoteTextBox)
        Me.Panel1.Controls.Add(ReqDateLabel)
        Me.Panel1.Controls.Add(Me.ReqDateMaskedTextBox)
        Me.Panel1.Controls.Add(Me.POIDLabel2)
        Me.Panel1.Controls.Add(Me.Tbl_Pur_POBindingNavigator)
        Me.Panel1.Controls.Add(POIDLabel)
        Me.Panel1.Controls.Add(PODateLabel)
        Me.Panel1.Controls.Add(Me.PODateMaskedTextBox)
        Me.Panel1.Controls.Add(SupplierIDLabel)
        Me.Panel1.Controls.Add(Me.SupplierIDComboBox)
        Me.Panel1.Location = New System.Drawing.Point(6, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 109)
        Me.Panel1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "Discount", True))
        Me.TextBox1.Location = New System.Drawing.Point(740, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 32
        '
        'ImportStatusCheckBox
        '
        Me.ImportStatusCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ImportStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Pur_POBindingSource, "ImportStatus", True))
        Me.ImportStatusCheckBox.Location = New System.Drawing.Point(443, 57)
        Me.ImportStatusCheckBox.Name = "ImportStatusCheckBox"
        Me.ImportStatusCheckBox.Size = New System.Drawing.Size(97, 20)
        Me.ImportStatusCheckBox.TabIndex = 31
        Me.ImportStatusCheckBox.Text = "Import Status"
        Me.ImportStatusCheckBox.UseVisualStyleBackColor = True
        '
        'Formula
        '
        Me.Formula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Supplier_ItemsBindingSource, "Formula", True))
        Me.Formula.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Formula.Location = New System.Drawing.Point(440, 57)
        Me.Formula.Name = "Formula"
        Me.Formula.Size = New System.Drawing.Size(100, 20)
        Me.Formula.TabIndex = 29
        '
        'NewReqDateMaskedTextBox
        '
        Me.NewReqDateMaskedTextBox.ContextMenuStrip = Me.CMNewReqDate
        Me.NewReqDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "NewReqDate", True))
        Me.NewReqDateMaskedTextBox.Location = New System.Drawing.Point(740, 32)
        Me.NewReqDateMaskedTextBox.Mask = "00/00/0000"
        Me.NewReqDateMaskedTextBox.Name = "NewReqDateMaskedTextBox"
        Me.NewReqDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NewReqDateMaskedTextBox.TabIndex = 10
        Me.NewReqDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMNewReqDate
        '
        Me.CMNewReqDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewReqDateTextBox, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9})
        Me.CMNewReqDate.Name = "SupplierContextMenuStrip"
        Me.CMNewReqDate.Size = New System.Drawing.Size(176, 117)
        '
        'NewReqDateTextBox
        '
        Me.NewReqDateTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NewReqDateTextBox.ForeColor = System.Drawing.Color.Silver
        Me.NewReqDateTextBox.Name = "NewReqDateTextBox"
        Me.NewReqDateTextBox.Size = New System.Drawing.Size(115, 23)
        Me.NewReqDateTextBox.Text = "Enter New Required Date"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem6.Text = "Remove &Filter"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem7.Text = "&Ascending Order"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem8.Text = "&Descending Order"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem9.Text = "&Remove Order"
        '
        'SpecialNoteTextBox
        '
        Me.SpecialNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "SpecialNote", True))
        Me.SpecialNoteTextBox.Location = New System.Drawing.Point(103, 83)
        Me.SpecialNoteTextBox.Name = "SpecialNoteTextBox"
        Me.SpecialNoteTextBox.Size = New System.Drawing.Size(522, 20)
        Me.SpecialNoteTextBox.TabIndex = 3
        '
        'ReqDateMaskedTextBox
        '
        Me.ReqDateMaskedTextBox.ContextMenuStrip = Me.CMReqDate
        Me.ReqDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "ReqDate", True))
        Me.ReqDateMaskedTextBox.Location = New System.Drawing.Point(525, 32)
        Me.ReqDateMaskedTextBox.Mask = "00/00/0000"
        Me.ReqDateMaskedTextBox.Name = "ReqDateMaskedTextBox"
        Me.ReqDateMaskedTextBox.ReadOnly = True
        Me.ReqDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReqDateMaskedTextBox.TabIndex = 1
        Me.ReqDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMReqDate
        '
        Me.CMReqDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReqDateTextBox, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.CMReqDate.Name = "SupplierContextMenuStrip"
        Me.CMReqDate.Size = New System.Drawing.Size(171, 117)
        '
        'ReqDateTextBox
        '
        Me.ReqDateTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ReqDateTextBox.ForeColor = System.Drawing.Color.Silver
        Me.ReqDateTextBox.Name = "ReqDateTextBox"
        Me.ReqDateTextBox.Size = New System.Drawing.Size(110, 23)
        Me.ReqDateTextBox.Text = "Enter Required Date"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem2.Text = "Remove &Filter"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem3.Text = "&Ascending Order"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem4.Text = "&Descending Order"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem5.Text = "&Remove Order"
        '
        'POIDLabel2
        '
        Me.POIDLabel2.BackColor = System.Drawing.Color.White
        Me.POIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POIDLabel2.ContextMenuStrip = Me.CMPONO
        Me.POIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "POID", True))
        Me.POIDLabel2.Location = New System.Drawing.Point(103, 32)
        Me.POIDLabel2.Name = "POIDLabel2"
        Me.POIDLabel2.Size = New System.Drawing.Size(100, 20)
        Me.POIDLabel2.TabIndex = 7
        Me.POIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMPONO
        '
        Me.CMPONO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem10, Me.RemoveFilterToolStripMenuItem})
        Me.CMPONO.Name = "SupplierContextMenuStrip"
        Me.CMPONO.Size = New System.Drawing.Size(168, 48)
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PONOTextBox})
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem10.Text = "Enter PO Number"
        '
        'PONOTextBox
        '
        Me.PONOTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PONOTextBox.ForeColor = System.Drawing.Color.Silver
        Me.PONOTextBox.Name = "PONOTextBox"
        Me.PONOTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PONOTextBox.Text = "Enter PO Number"
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove &Filter"
        '
        'Tbl_Pur_POBindingNavigator
        '
        Me.Tbl_Pur_POBindingNavigator.AddNewItem = Nothing
        Me.Tbl_Pur_POBindingNavigator.BindingSource = Me.Tbl_Pur_POBindingSource
        Me.Tbl_Pur_POBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Pur_POBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Pur_POBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AddSale, Me.BindingNavigatorDeleteItem, Me.Tbl_Pur_POBindingNavigatorSaveItem})
        Me.Tbl_Pur_POBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Pur_POBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Pur_POBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Pur_POBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Pur_POBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Pur_POBindingNavigator.Name = "Tbl_Pur_POBindingNavigator"
        Me.Tbl_Pur_POBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Pur_POBindingNavigator.Size = New System.Drawing.Size(899, 25)
        Me.Tbl_Pur_POBindingNavigator.TabIndex = 6
        Me.Tbl_Pur_POBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'AddSale
        '
        Me.AddSale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddSale.Image = CType(resources.GetObject("AddSale.Image"), System.Drawing.Image)
        Me.AddSale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddSale.Name = "AddSale"
        Me.AddSale.Size = New System.Drawing.Size(23, 22)
        Me.AddSale.Text = "Add new"
        '
        'Tbl_Pur_POBindingNavigatorSaveItem
        '
        Me.Tbl_Pur_POBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Pur_POBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Pur_POBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Pur_POBindingNavigatorSaveItem.Name = "Tbl_Pur_POBindingNavigatorSaveItem"
        Me.Tbl_Pur_POBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Pur_POBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PODateMaskedTextBox
        '
        Me.PODateMaskedTextBox.ContextMenuStrip = Me.CMOrderDate
        Me.PODateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "PODate", True))
        Me.PODateMaskedTextBox.Location = New System.Drawing.Point(313, 32)
        Me.PODateMaskedTextBox.Mask = "00/00/0000"
        Me.PODateMaskedTextBox.Name = "PODateMaskedTextBox"
        Me.PODateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PODateMaskedTextBox.TabIndex = 0
        Me.PODateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMOrderDate
        '
        Me.CMOrderDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderDateTextBox, Me.ToolStripMenuItem1, Me.AscendingOrderToolStripMenuItem, Me.DescendingOrderToolStripMenuItem, Me.RemoveOrderToolStripMenuItem})
        Me.CMOrderDate.Name = "SupplierContextMenuStrip"
        Me.CMOrderDate.Size = New System.Drawing.Size(176, 117)
        '
        'OrderDateTextBox
        '
        Me.OrderDateTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.OrderDateTextBox.ForeColor = System.Drawing.Color.Silver
        Me.OrderDateTextBox.Name = "OrderDateTextBox"
        Me.OrderDateTextBox.Size = New System.Drawing.Size(115, 23)
        Me.OrderDateTextBox.Text = "Enter Production Order Date"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem1.Text = "Remove &Filter"
        '
        'AscendingOrderToolStripMenuItem
        '
        Me.AscendingOrderToolStripMenuItem.Name = "AscendingOrderToolStripMenuItem"
        Me.AscendingOrderToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AscendingOrderToolStripMenuItem.Text = "&Ascending Order"
        '
        'DescendingOrderToolStripMenuItem
        '
        Me.DescendingOrderToolStripMenuItem.Name = "DescendingOrderToolStripMenuItem"
        Me.DescendingOrderToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DescendingOrderToolStripMenuItem.Text = "&Descending Order"
        '
        'RemoveOrderToolStripMenuItem
        '
        Me.RemoveOrderToolStripMenuItem.Name = "RemoveOrderToolStripMenuItem"
        Me.RemoveOrderToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.RemoveOrderToolStripMenuItem.Text = "&Remove Order"
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierIDComboBox.ContextMenuStrip = Me.CMSupplierName
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Pur_POBindingSource, "SupplierID", True))
        Me.SupplierIDComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.SupplierIDComboBox.DisplayMember = "CompanyName"
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(103, 56)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(310, 21)
        Me.SupplierIDComboBox.TabIndex = 2
        Me.SupplierIDComboBox.ValueMember = "SupplierID"
        '
        'CMSupplierName
        '
        Me.CMSupplierName.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuplierNameTextBox, Me.ToolStripMenuItem11})
        Me.CMSupplierName.Name = "SupplierContextMenuStrip"
        Me.CMSupplierName.Size = New System.Drawing.Size(171, 51)
        '
        'SuplierNameTextBox
        '
        Me.SuplierNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SuplierNameTextBox.ForeColor = System.Drawing.Color.Silver
        Me.SuplierNameTextBox.Name = "SuplierNameTextBox"
        Me.SuplierNameTextBox.Size = New System.Drawing.Size(110, 23)
        Me.SuplierNameTextBox.Text = "Enter Supplier Name"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem11.Text = "Remove &Filter"
        '
        'SupplierType
        '
        Me.SupplierType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "SupplierTypeID", True))
        Me.SupplierType.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SupplierType.Location = New System.Drawing.Point(913, 64)
        Me.SupplierType.Name = "SupplierType"
        Me.SupplierType.Size = New System.Drawing.Size(27, 20)
        Me.SupplierType.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Tbl_Pur_PO_DDataGridView)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Location = New System.Drawing.Point(6, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(979, 559)
        Me.Panel2.TabIndex = 7
        '
        'Tbl_Pur_PO_DDataGridView
        '
        Me.Tbl_Pur_PO_DDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_Pur_PO_DDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Pur_PO_DDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.Tbl_Pur_PO_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Pur_PO_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.OtherCharges, Me.GSTTax, Me.DataGridViewTextBoxColumn7, Me.Description, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn1})
        Me.Tbl_Pur_PO_DDataGridView.DataSource = Me.Tbl_Pur_PO_DBindingSource
        Me.Tbl_Pur_PO_DDataGridView.Location = New System.Drawing.Point(2, 27)
        Me.Tbl_Pur_PO_DDataGridView.Name = "Tbl_Pur_PO_DDataGridView"
        Me.Tbl_Pur_PO_DDataGridView.Size = New System.Drawing.Size(973, 527)
        Me.Tbl_Pur_PO_DDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PODNo"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn4.HeaderText = "Serial No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SupplierCodeID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.View_Supplier_ItemsBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "SupplierCodeID"
        Me.DataGridViewTextBoxColumn3.Width = 210
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "POQty"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn6.HeaderText = "Order Qty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UOM"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn9.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.Format = "N4"
        DataGridViewCellStyle27.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'OtherCharges
        '
        Me.OtherCharges.DataPropertyName = "OtherCharges"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OtherCharges.DefaultCellStyle = DataGridViewCellStyle28
        Me.OtherCharges.HeaderText = "Other Charges"
        Me.OtherCharges.Name = "OtherCharges"
        Me.OtherCharges.Width = 60
        '
        'GSTTax
        '
        Me.GSTTax.DataPropertyName = "GSTTax"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.GSTTax.DefaultCellStyle = DataGridViewCellStyle29
        Me.GSTTax.HeaderText = "GST Amt."
        Me.GSTTax.Name = "GSTTax"
        Me.GSTTax.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Curency"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn7.HeaderText = "Curency"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Description.DefaultCellStyle = DataGridViewCellStyle31
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 120
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "RecStatus"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle32.NullValue = System.Windows.Forms.CheckState.Indeterminate
        Me.DataGridViewCheckBoxColumn1.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Received Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCheckBoxColumn1.ThreeState = True
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "OrdCompDate"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle33.Format = "d"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridViewTextBoxColumn10.HeaderText = "Received Date"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Formula"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Formula"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.Tbl_Pur_PO_DBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton, Me.toolStripSeparator1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(977, 25)
        Me.BindingNavigator1.TabIndex = 1
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
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.IndianRed
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Yellow
        Me.btnRefresh.Location = New System.Drawing.Point(517, 45)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 23)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.ToolTip1.SetToolTip(Me.btnRefresh, " Press F5 To Refresh Records ")
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'CurencyLabel1
        '
        Me.CurencyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Supplier_ItemsBindingSource, "Curency", True))
        Me.CurencyLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.CurencyLabel1.Location = New System.Drawing.Point(936, 95)
        Me.CurencyLabel1.Name = "CurencyLabel1"
        Me.CurencyLabel1.Size = New System.Drawing.Size(100, 14)
        Me.CurencyLabel1.TabIndex = 12
        '
        'UnitPriceLabel1
        '
        Me.UnitPriceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Supplier_ItemsBindingSource, "UnitPrice", True))
        Me.UnitPriceLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.UnitPriceLabel1.Location = New System.Drawing.Point(954, 120)
        Me.UnitPriceLabel1.Name = "UnitPriceLabel1"
        Me.UnitPriceLabel1.Size = New System.Drawing.Size(100, 10)
        Me.UnitPriceLabel1.TabIndex = 13
        '
        'UOMLabel1
        '
        Me.UOMLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Supplier_ItemsBindingSource, "UOM", True))
        Me.UOMLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.UOMLabel1.Location = New System.Drawing.Point(936, 136)
        Me.UOMLabel1.Name = "UOMLabel1"
        Me.UOMLabel1.Size = New System.Drawing.Size(100, 10)
        Me.UOMLabel1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(79, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 28)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(916, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 106)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selector"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 46)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "PO Balance"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "PO Report"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(636, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Discount :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPurOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 880)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SupplierType)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(SupplierTypeLabel)
        Me.Controls.Add(Me.UOMLabel1)
        Me.Controls.Add(Me.UnitPriceLabel1)
        Me.Controls.Add(Me.CurencyLabel1)
        Me.Controls.Add(Me.SupplierTypeComboBox)
        Me.Name = "frmPurOrders"
        Me.Text = "Purchase Orders"
        CType(Me.Tbl_inv_SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPurOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_PO_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_Supplier_CodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Supplier_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CMNewReqDate.ResumeLayout(False)
        Me.CMNewReqDate.PerformLayout()
        Me.CMReqDate.ResumeLayout(False)
        Me.CMReqDate.PerformLayout()
        Me.CMPONO.ResumeLayout(False)
        CType(Me.Tbl_Pur_POBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Pur_POBindingNavigator.ResumeLayout(False)
        Me.Tbl_Pur_POBindingNavigator.PerformLayout()
        Me.CMOrderDate.ResumeLayout(False)
        Me.CMOrderDate.PerformLayout()
        Me.CMSupplierName.ResumeLayout(False)
        Me.CMSupplierName.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Pur_PO_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SupplierTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DSPurOrder As FS_ERP_MM.DSPurOrder
    Friend WithEvents Tbl_inv_SupplierTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_inv_SupplierTypeTableAdapter As FS_ERP_MM.DSPurOrderTableAdapters.tbl_inv_SupplierTypeTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSPurOrderTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Pur_POTableAdapter As FS_ERP_MM.DSPurOrderTableAdapters.tbl_Pur_POTableAdapter
    Friend WithEvents Tbl_Pur_POBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_PO_DTableAdapter As FS_ERP_MM.DSPurOrderTableAdapters.tbl_Pur_PO_DTableAdapter
    Friend WithEvents Tbl_Pur_PO_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSPurOrderTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_Supplier_CodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_Supplier_CodeTableAdapter As FS_ERP_MM.DSPurOrderTableAdapters.tbl_Pur_Supplier_CodeTableAdapter
    Friend WithEvents View_Supplier_ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Supplier_ItemsTableAdapter As FS_ERP_MM.DSPurOrderTableAdapters.View_Supplier_ItemsTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NewReqDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents SpecialNoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReqDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents POIDLabel2 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Pur_POBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Pur_POBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PODateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Tbl_Pur_PO_DDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CMPONO As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PONOTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMOrderDate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OrderDateTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMReqDate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReqDateTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMNewReqDate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewReqDateTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMSupplierName As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SuplierNameTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AddSale As System.Windows.Forms.ToolStripButton
    Friend WithEvents SupplierType As System.Windows.Forms.Label
    Friend WithEvents CurencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents UnitPriceLabel1 As System.Windows.Forms.Label
    Friend WithEvents UOMLabel1 As System.Windows.Forms.Label
    Friend WithEvents ImportStatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Formula As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents OtherCharges As DataGridViewTextBoxColumn
    Friend WithEvents GSTTax As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
