<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEDM
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
        Dim Label2 As System.Windows.Forms.Label
        Dim SpecialNoteLabel As System.Windows.Forms.Label
        Dim ReqDateLabel As System.Windows.Forms.Label
        Dim POIDLabel As System.Windows.Forms.Label
        Dim PODateLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim UOMLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEDM))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DSEDM = New FS_ERP_MM.DSEDM()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSEDMTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSEDMTableAdapters.TableAdapterManager()
        Me.Tbl_Pur_POTableAdapter = New FS_ERP_MM.DSEDMTableAdapters.tbl_Pur_POTableAdapter()
        Me.Tbl_Pur_Supplier_CodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_Supplier_CodeTableAdapter = New FS_ERP_MM.DSEDMTableAdapters.tbl_Pur_Supplier_CodeTableAdapter()
        Me.Tbl_Pur_POBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ImportStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.Formula = New System.Windows.Forms.Label()
        Me.NewReqDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SpecialNoteTextBox = New System.Windows.Forms.TextBox()
        Me.ReqDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.POIDLabel2 = New System.Windows.Forms.Label()
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
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New FS_ERP_MM.DSEDMTableAdapters.DataTable1TableAdapter()
        Me.POIDLabel3 = New System.Windows.Forms.Label()
        Me.View_MAX_PODNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSEDMTableAdapters.tbl_Inv_L4TableAdapter()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Pur_Supplier_Code_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.View_inv_CodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UOMLabel2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.DSEDMTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.View_Pur_PO_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Pur_PO_DTableAdapter = New FS_ERP_MM.DSEDMTableAdapters.View_Pur_PO_DTableAdapter()
        Me.View_Pur_PO_DDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.View_MAX_PODNoTableAdapter = New FS_ERP_MM.DSEDMTableAdapters.View_MAX_PODNoTableAdapter()
        Me.View_inv_CodeTableAdapter = New FS_ERP_MM.DSEDMTableAdapters.View_inv_CodeTableAdapter()
        Me.Tbl_Pur_Supplier_Code_NewTableAdapter = New FS_ERP_MM.DSEDMTableAdapters.tbl_Pur_Supplier_Code_NewTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Curency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReceivedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Label2 = New System.Windows.Forms.Label()
        SpecialNoteLabel = New System.Windows.Forms.Label()
        ReqDateLabel = New System.Windows.Forms.Label()
        POIDLabel = New System.Windows.Forms.Label()
        PODateLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        UOMLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.DSEDM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_Supplier_CodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Pur_POBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Pur_POBindingNavigator.SuspendLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MAX_PODNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_Supplier_Code_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.View_inv_CodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Pur_PO_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Pur_PO_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'L4NameLabel
        '
        L4NameLabel.AutoSize = True
        L4NameLabel.Location = New System.Drawing.Point(47, 12)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(50, 13)
        L4NameLabel.TabIndex = 37
        L4NameLabel.Text = "Material :"
        '
        'UOMLabel
        '
        UOMLabel.AutoSize = True
        UOMLabel.Location = New System.Drawing.Point(610, 12)
        UOMLabel.Name = "UOMLabel"
        UOMLabel.Size = New System.Drawing.Size(35, 13)
        UOMLabel.TabIndex = 42
        UOMLabel.Text = "UOM:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(757, 12)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(37, 13)
        Label9.TabIndex = 49
        Label9.Text = "Price :"
        '
        'DSEDM
        '
        Me.DSEDM.DataSetName = "DSEDM"
        Me.DSEDM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSEDM
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Me.Tbl_Inv_SupplierTableAdapter
        Me.TableAdapterManager.tbl_Pur_PO_DTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_POTableAdapter = Me.Tbl_Pur_POTableAdapter
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSEDMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_Pur_PO_DTableAdapter = Nothing
        '
        'Tbl_Pur_POTableAdapter
        '
        Me.Tbl_Pur_POTableAdapter.ClearBeforeFill = True
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
        'Tbl_Pur_POBindingSource
        '
        Me.Tbl_Pur_POBindingSource.DataMember = "tbl_Pur_PO"
        Me.Tbl_Pur_POBindingSource.DataSource = Me.DSEDM
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
        Me.Panel1.Location = New System.Drawing.Point(6, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 117)
        Me.Panel1.TabIndex = 7
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
        Me.Formula.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Formula.Location = New System.Drawing.Point(440, 57)
        Me.Formula.Name = "Formula"
        Me.Formula.Size = New System.Drawing.Size(100, 20)
        Me.Formula.TabIndex = 29
        '
        'NewReqDateMaskedTextBox
        '
        Me.NewReqDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "NewReqDate", True))
        Me.NewReqDateMaskedTextBox.Location = New System.Drawing.Point(740, 32)
        Me.NewReqDateMaskedTextBox.Mask = "00/00/0000"
        Me.NewReqDateMaskedTextBox.Name = "NewReqDateMaskedTextBox"
        Me.NewReqDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NewReqDateMaskedTextBox.TabIndex = 10
        Me.NewReqDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.ReqDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "ReqDate", True))
        Me.ReqDateMaskedTextBox.Location = New System.Drawing.Point(525, 32)
        Me.ReqDateMaskedTextBox.Mask = "00/00/0000"
        Me.ReqDateMaskedTextBox.Name = "ReqDateMaskedTextBox"
        Me.ReqDateMaskedTextBox.ReadOnly = True
        Me.ReqDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReqDateMaskedTextBox.TabIndex = 1
        Me.ReqDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'POIDLabel2
        '
        Me.POIDLabel2.BackColor = System.Drawing.Color.White
        Me.POIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "POID", True))
        Me.POIDLabel2.Location = New System.Drawing.Point(103, 32)
        Me.POIDLabel2.Name = "POIDLabel2"
        Me.POIDLabel2.Size = New System.Drawing.Size(100, 20)
        Me.POIDLabel2.TabIndex = 7
        Me.POIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Tbl_Pur_POBindingNavigator.Size = New System.Drawing.Size(900, 25)
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
        Me.PODateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "PODate", True))
        Me.PODateMaskedTextBox.Location = New System.Drawing.Point(313, 32)
        Me.PODateMaskedTextBox.Mask = "00/00/0000"
        Me.PODateMaskedTextBox.Name = "PODateMaskedTextBox"
        Me.PODateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PODateMaskedTextBox.TabIndex = 0
        Me.PODateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SupplierIDComboBox
        '
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1151, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Purchase Order (PO)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "POID", True))
        Me.Label4.Location = New System.Drawing.Point(929, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 31)
        Me.Label4.TabIndex = 36
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DSEDM
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'POIDLabel3
        '
        Me.POIDLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.POIDLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MAX_PODNoBindingSource, "PODNo", True))
        Me.POIDLabel3.Location = New System.Drawing.Point(929, 124)
        Me.POIDLabel3.Name = "POIDLabel3"
        Me.POIDLabel3.Size = New System.Drawing.Size(100, 23)
        Me.POIDLabel3.TabIndex = 37
        Me.POIDLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_MAX_PODNoBindingSource
        '
        Me.View_MAX_PODNoBindingSource.DataMember = "View_MAX_PODNo"
        Me.View_MAX_PODNoBindingSource.DataSource = Me.DSEDM
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSEDM
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Pur_Supplier_CodeBindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(103, 8)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(173, 21)
        Me.L4NameComboBox.TabIndex = 0
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Pur_Supplier_Code_NewBindingSource
        '
        Me.Tbl_Pur_Supplier_Code_NewBindingSource.DataSource = Me.Tbl_Inv_SupplierBindingSource
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(235, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Quantity :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_POBindingSource, "Discount", True))
        Me.TextBox2.Location = New System.Drawing.Point(339, 8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(906, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Label9)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.UOMLabel2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(UOMLabel)
        Me.Panel2.Controls.Add(Me.L4NameComboBox)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(L4NameLabel)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(6, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1046, 38)
        Me.Panel2.TabIndex = 42
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(504, 8)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_inv_CodeBindingSource, "UnitPrice", True))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(800, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_inv_CodeBindingSource
        '
        Me.View_inv_CodeBindingSource.DataMember = "View_inv_Code"
        Me.View_inv_CodeBindingSource.DataSource = Me.DSEDM
        '
        'UOMLabel2
        '
        Me.UOMLabel2.BackColor = System.Drawing.Color.White
        Me.UOMLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UOMLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_inv_CodeBindingSource, "UOM", True))
        Me.UOMLabel2.ForeColor = System.Drawing.Color.Black
        Me.UOMLabel2.Location = New System.Drawing.Point(651, 6)
        Me.UOMLabel2.Name = "UOMLabel2"
        Me.UOMLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UOMLabel2.TabIndex = 48
        Me.UOMLabel2.Text = "Label9"
        Me.UOMLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(441, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 23)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Currency :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataMember = "tbl_Pur_UnitOfMeasurement"
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DSEDM
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
        '
        'View_Pur_PO_DBindingSource
        '
        Me.View_Pur_PO_DBindingSource.DataMember = "tbl_Pur_PO_DataTable2"
        Me.View_Pur_PO_DBindingSource.DataSource = Me.Tbl_Pur_POBindingSource
        '
        'View_Pur_PO_DTableAdapter
        '
        Me.View_Pur_PO_DTableAdapter.ClearBeforeFill = True
        '
        'View_Pur_PO_DDataGridView
        '
        Me.View_Pur_PO_DDataGridView.AllowUserToAddRows = False
        Me.View_Pur_PO_DDataGridView.AllowUserToDeleteRows = False
        Me.View_Pur_PO_DDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_Pur_PO_DDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.View_Pur_PO_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Pur_PO_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn5, Me.Curency, Me.UOM, Me.UnitPrice, Me.Column1, Me.ReceivedStatus, Me.ReceivedDate})
        Me.View_Pur_PO_DDataGridView.DataSource = Me.View_Pur_PO_DBindingSource
        Me.View_Pur_PO_DDataGridView.Location = New System.Drawing.Point(-1, 27)
        Me.View_Pur_PO_DDataGridView.Name = "View_Pur_PO_DDataGridView"
        Me.View_Pur_PO_DDataGridView.RowHeadersWidth = 23
        Me.View_Pur_PO_DDataGridView.Size = New System.Drawing.Size(763, 291)
        Me.View_Pur_PO_DDataGridView.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BindingNavigator1)
        Me.Panel3.Controls.Add(Me.View_Pur_PO_DDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(6, 210)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(781, 323)
        Me.Panel3.TabIndex = 43
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.View_Pur_PO_DBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(779, 25)
        Me.BindingNavigator1.TabIndex = 24
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
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.FS_ERP_MM.My.Resources.Resources.images1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'View_MAX_PODNoTableAdapter
        '
        Me.View_MAX_PODNoTableAdapter.ClearBeforeFill = True
        '
        'View_inv_CodeTableAdapter
        '
        Me.View_inv_CodeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_Supplier_Code_NewTableAdapter
        '
        Me.Tbl_Pur_Supplier_Code_NewTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MAX_PODNoBindingSource, "PODNo", True))
        Me.Label6.Location = New System.Drawing.Point(910, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 44
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(914, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 106)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selector"
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(78, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 28)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Show Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "L4Name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "POQty"
        DataGridViewCellStyle12.Format = "N0"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Curency
        '
        Me.Curency.DataPropertyName = "Curency"
        DataGridViewCellStyle13.Format = "N0"
        Me.Curency.DefaultCellStyle = DataGridViewCellStyle13
        Me.Curency.HeaderText = "Curency"
        Me.Curency.Name = "Curency"
        '
        'UOM
        '
        Me.UOM.DataPropertyName = "UOM"
        Me.UOM.HeaderText = "UOM"
        Me.UOM.Name = "UOM"
        Me.UOM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'UnitPrice
        '
        Me.UnitPrice.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle14.Format = "N0"
        Me.UnitPrice.DefaultCellStyle = DataGridViewCellStyle14
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "POID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'ReceivedStatus
        '
        Me.ReceivedStatus.DataPropertyName = "ReceivedStatus"
        Me.ReceivedStatus.HeaderText = "Received Status"
        Me.ReceivedStatus.Name = "ReceivedStatus"
        Me.ReceivedStatus.Width = 70
        '
        'ReceivedDate
        '
        Me.ReceivedDate.DataPropertyName = "ReceivedDate"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Format = "d"
        Me.ReceivedDate.DefaultCellStyle = DataGridViewCellStyle15
        Me.ReceivedDate.HeaderText = "Received Date"
        Me.ReceivedDate.Name = "ReceivedDate"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 45)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(124, 17)
        Me.RadioButton2.TabIndex = 32
        Me.RadioButton2.Text = "PO Received Report"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'FrmEDM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 696)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.POIDLabel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmEDM"
        Me.Text = "FrmEDM"
        CType(Me.DSEDM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_Supplier_CodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Pur_POBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Pur_POBindingNavigator.ResumeLayout(False)
        Me.Tbl_Pur_POBindingNavigator.PerformLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_MAX_PODNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_Supplier_Code_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.View_inv_CodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Pur_PO_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Pur_PO_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSEDM As DSEDM
    Friend WithEvents Tbl_Inv_SupplierBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As DSEDMTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents TableAdapterManager As DSEDMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Pur_Supplier_CodeBindingSource As BindingSource
    Friend WithEvents Tbl_Pur_Supplier_CodeTableAdapter As DSEDMTableAdapters.tbl_Pur_Supplier_CodeTableAdapter
    Friend WithEvents Tbl_Pur_POTableAdapter As DSEDMTableAdapters.tbl_Pur_POTableAdapter
    Friend WithEvents Tbl_Pur_POBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ImportStatusCheckBox As CheckBox
    Friend WithEvents Formula As Label
    Friend WithEvents NewReqDateMaskedTextBox As MaskedTextBox
    Friend WithEvents SpecialNoteTextBox As TextBox
    Friend WithEvents ReqDateMaskedTextBox As MaskedTextBox
    Friend WithEvents POIDLabel2 As Label
    Friend WithEvents Tbl_Pur_POBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AddSale As ToolStripButton
    Friend WithEvents Tbl_Pur_POBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PODateMaskedTextBox As MaskedTextBox
    Friend WithEvents SupplierIDComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DSEDMTableAdapters.DataTable1TableAdapter
    Friend WithEvents POIDLabel3 As Label
    Friend WithEvents Tbl_Inv_L4BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As DSEDMTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents L4NameComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As DSEDMTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents View_Pur_PO_DBindingSource As BindingSource
    Friend WithEvents View_Pur_PO_DTableAdapter As DSEDMTableAdapters.View_Pur_PO_DTableAdapter
    Friend WithEvents View_Pur_PO_DDataGridView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents View_MAX_PODNoBindingSource As BindingSource
    Friend WithEvents View_MAX_PODNoTableAdapter As DSEDMTableAdapters.View_MAX_PODNoTableAdapter
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents View_inv_CodeBindingSource As BindingSource
    Friend WithEvents View_inv_CodeTableAdapter As DSEDMTableAdapters.View_inv_CodeTableAdapter
    Friend WithEvents UOMLabel2 As Label
    Friend WithEvents Tbl_Pur_Supplier_Code_NewBindingSource As BindingSource
    Friend WithEvents Tbl_Pur_Supplier_Code_NewTableAdapter As DSEDMTableAdapters.tbl_Pur_Supplier_Code_NewTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Curency As DataGridViewTextBoxColumn
    Friend WithEvents UOM As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedStatus As DataGridViewCheckBoxColumn
    Friend WithEvents ReceivedDate As DataGridViewTextBoxColumn
    Friend WithEvents RadioButton2 As RadioButton
End Class
