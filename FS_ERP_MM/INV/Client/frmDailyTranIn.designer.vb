<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyTranIn
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
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim UnitLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyTranIn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Inv_Tran_InDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSNewTranIn = New FS_ERP_MM.DSNewTranIn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BallType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BallRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Strock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MakerID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_MakersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RackId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Inv_Rack_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMat_Brow = New FS_ERP_MM.DSMat_Brow()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_Inv_Tran_InBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Inv_LocalCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.Tbl_Inv_Tran_InTableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_Tran_InTableAdapter()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Tran_DateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.UnitLabel1 = New System.Windows.Forms.Label()
        Me.CurrencyLabel1 = New System.Windows.Forms.Label()
        Me.CPPULabel1 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Inv_LocalCustTableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_LocalCustTableAdapter()
        Me.Tbl_Inv_Rack_InfoTableAdapter = New FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Rack_InfoTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSMat_BrowTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_L4TableAdapter()
        Me.UnitLabel2 = New System.Windows.Forms.Label()
        Me.Tbl_MakersTableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_MakersTableAdapter()
        Me.RateLabel1 = New System.Windows.Forms.Label()
        Me.StrockLabel1 = New System.Windows.Forms.Label()
        DateNameLabel = New System.Windows.Forms.Label()
        UnitLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_InDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSNewTranIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MakersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMat_Brow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(7, 32)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(100, 20)
        DateNameLabel.TabIndex = 0
        DateNameLabel.Text = "Transaction Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UnitLabel
        '
        UnitLabel.AutoSize = True
        UnitLabel.Location = New System.Drawing.Point(921, 53)
        UnitLabel.Name = "UnitLabel"
        UnitLabel.Size = New System.Drawing.Size(29, 13)
        UnitLabel.TabIndex = 44
        UnitLabel.Text = "Unit:"
        UnitLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1364, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Daily A Grade Material Inward Entries"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Inv_Tran_InDataGridView)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Location = New System.Drawing.Point(3, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1327, 547)
        Me.Panel1.TabIndex = 0
        '
        'Tbl_Inv_Tran_InDataGridView
        '
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_Inv_Tran_InDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27
        Me.Tbl_Inv_Tran_InDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Inv_Tran_InDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.Tbl_Inv_Tran_InDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Inv_Tran_InDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn15, Me.BallType, Me.BallRate, Me.Strock, Me.MakerID, Me.DataGridViewTextBoxColumn6, Me.RackId, Me.DataGridViewTextBoxColumn12})
        Me.Tbl_Inv_Tran_InDataGridView.DataSource = Me.Tbl_Inv_Tran_InBindingSource
        Me.Tbl_Inv_Tran_InDataGridView.Location = New System.Drawing.Point(2, 26)
        Me.Tbl_Inv_Tran_InDataGridView.Name = "Tbl_Inv_Tran_InDataGridView"
        Me.Tbl_Inv_Tran_InDataGridView.RowHeadersWidth = 10
        Me.Tbl_Inv_Tran_InDataGridView.Size = New System.Drawing.Size(1321, 516)
        Me.Tbl_Inv_Tran_InDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TranInID"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tran In No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TranType"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tran Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MRIN"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tran Doc.No."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn7.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn7.HeaderText = "Material Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "Code"
        Me.DataGridViewTextBoxColumn7.Width = 210
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSNewTranIn
        '
        'DSNewTranIn
        '
        Me.DSNewTranIn.DataSetName = "DSNewTranIn"
        Me.DSNewTranIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PPU"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PPU"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Qty"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewTextBoxColumn9.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Currency"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "UOM"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridViewTextBoxColumn15.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 60
        '
        'BallType
        '
        Me.BallType.DataPropertyName = "BallType"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.BallType.DefaultCellStyle = DataGridViewCellStyle34
        Me.BallType.DisplayStyleForCurrentCellOnly = True
        Me.BallType.HeaderText = "Ball Type"
        Me.BallType.Items.AddRange(New Object() {"Normal", "AMB", "MS", "AMB Printing"})
        Me.BallType.Name = "BallType"
        Me.BallType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BallType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BallType.Width = 80
        '
        'BallRate
        '
        Me.BallRate.DataPropertyName = "BallRate"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.BallRate.DefaultCellStyle = DataGridViewCellStyle35
        Me.BallRate.HeaderText = "Rate"
        Me.BallRate.Name = "BallRate"
        Me.BallRate.Width = 70
        '
        'Strock
        '
        Me.Strock.DataPropertyName = "Strock"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Strock.DefaultCellStyle = DataGridViewCellStyle36
        Me.Strock.HeaderText = "Strock"
        Me.Strock.Name = "Strock"
        Me.Strock.Width = 50
        '
        'MakerID
        '
        Me.MakerID.DataPropertyName = "MakerID"
        Me.MakerID.DataSource = Me.Tbl_MakersBindingSource
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.MakerID.DefaultCellStyle = DataGridViewCellStyle37
        Me.MakerID.DisplayMember = "MakerName"
        Me.MakerID.DisplayStyleForCurrentCellOnly = True
        Me.MakerID.HeaderText = "Maker Name"
        Me.MakerID.Name = "MakerID"
        Me.MakerID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MakerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MakerID.ValueMember = "MakerID"
        Me.MakerID.Width = 250
        '
        'Tbl_MakersBindingSource
        '
        Me.Tbl_MakersBindingSource.DataMember = "tbl_Makers"
        Me.Tbl_MakersBindingSource.DataSource = Me.DSNewTranIn
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "LocalCustID"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.Tbl_Inv_SupplierBindingSource
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle38
        Me.DataGridViewTextBoxColumn6.DisplayMember = "CompanyName"
        Me.DataGridViewTextBoxColumn6.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "Department Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "SupplierID"
        Me.DataGridViewTextBoxColumn6.Width = 180
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSNewTranIn
        '
        'RackId
        '
        Me.RackId.DataPropertyName = "RackId"
        Me.RackId.DataSource = Me.Tbl_Inv_Rack_InfoBindingSource
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.RackId.DefaultCellStyle = DataGridViewCellStyle39
        Me.RackId.DisplayMember = "RackNo"
        Me.RackId.DisplayStyleForCurrentCellOnly = True
        Me.RackId.HeaderText = "Rack No."
        Me.RackId.Name = "RackId"
        Me.RackId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RackId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RackId.ValueMember = "RackId"
        Me.RackId.Visible = False
        Me.RackId.Width = 115
        '
        'Tbl_Inv_Rack_InfoBindingSource
        '
        Me.Tbl_Inv_Rack_InfoBindingSource.DataMember = "tbl_Inv_Rack_Info"
        Me.Tbl_Inv_Rack_InfoBindingSource.DataSource = Me.DSMat_Brow
        '
        'DSMat_Brow
        '
        Me.DSMat_Brow.DataSetName = "DSMat_Brow"
        Me.DSMat_Brow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Narration"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Narration"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 250
        '
        'Tbl_Inv_Tran_InBindingSource
        '
        Me.Tbl_Inv_Tran_InBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Inv_Tran_In"
        Me.Tbl_Inv_Tran_InBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSNewTranIn
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_Tran_InBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1325, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'Tbl_Inv_LocalCustBindingSource
        '
        Me.Tbl_Inv_LocalCustBindingSource.DataMember = "tbl_Inv_LocalCust"
        Me.Tbl_Inv_LocalCustBindingSource.DataSource = Me.DSNewTranIn
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_InTableAdapter
        '
        Me.Tbl_Inv_Tran_InTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DayNoLabel1)
        Me.Panel3.Controls.Add(Me.Tbl_Inv_Tran_DateBindingNavigator)
        Me.Panel3.Controls.Add(DateNameLabel)
        Me.Panel3.Controls.Add(Me.DateNameLabel1)
        Me.Panel3.Location = New System.Drawing.Point(3, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 64)
        Me.Panel3.TabIndex = 4
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.Location = New System.Drawing.Point(219, 36)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(36, 10)
        Me.DayNoLabel1.TabIndex = 6
        '
        'Tbl_Inv_Tran_DateBindingNavigator
        '
        Me.Tbl_Inv_Tran_DateBindingNavigator.AddNewItem = Nothing
        Me.Tbl_Inv_Tran_DateBindingNavigator.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.Tbl_Inv_Tran_DateBindingNavigator.CountItem = Me.ToolStripLabel2
        Me.Tbl_Inv_Tran_DateBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Inv_Tran_DateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripSeparator6})
        Me.Tbl_Inv_Tran_DateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveFirstItem = Me.ToolStripButton8
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveLastItem = Me.ToolStripButton11
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveNextItem = Me.ToolStripButton10
        Me.Tbl_Inv_Tran_DateBindingNavigator.MovePreviousItem = Me.ToolStripButton9
        Me.Tbl_Inv_Tran_DateBindingNavigator.Name = "Tbl_Inv_Tran_DateBindingNavigator"
        Me.Tbl_Inv_Tran_DateBindingNavigator.PositionItem = Me.ToolStripTextBox2
        Me.Tbl_Inv_Tran_DateBindingNavigator.Size = New System.Drawing.Size(290, 25)
        Me.Tbl_Inv_Tran_DateBindingNavigator.TabIndex = 5
        Me.Tbl_Inv_Tran_DateBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Move first"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Move next"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(113, 32)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DateNameLabel1.TabIndex = 1
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnitLabel1
        '
        Me.UnitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource, "Unit", True))
        Me.UnitLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UnitLabel1.Location = New System.Drawing.Point(592, 53)
        Me.UnitLabel1.Name = "UnitLabel1"
        Me.UnitLabel1.Size = New System.Drawing.Size(66, 22)
        Me.UnitLabel1.TabIndex = 5
        '
        'CurrencyLabel1
        '
        Me.CurrencyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource, "Currency", True))
        Me.CurrencyLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.Location = New System.Drawing.Point(698, 54)
        Me.CurrencyLabel1.Name = "CurrencyLabel1"
        Me.CurrencyLabel1.Size = New System.Drawing.Size(66, 22)
        Me.CurrencyLabel1.TabIndex = 6
        '
        'CPPULabel1
        '
        Me.CPPULabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource, "CPPU", True))
        Me.CPPULabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.Location = New System.Drawing.Point(770, 52)
        Me.CPPULabel1.Name = "CPPULabel1"
        Me.CPPULabel1.Size = New System.Drawing.Size(100, 22)
        Me.CPPULabel1.TabIndex = 7
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(368, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 17)
        Me.RadioButton2.TabIndex = 44
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Manual Save"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(462, 51)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton1.TabIndex = 43
        Me.RadioButton1.Text = "Auto Save"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'Tbl_Inv_LocalCustTableAdapter
        '
        Me.Tbl_Inv_LocalCustTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Rack_InfoTableAdapter
        '
        Me.Tbl_Inv_Rack_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_Rack_InfoTableAdapter = Me.Tbl_Inv_Rack_InfoTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_OutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSMat_BrowTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'UnitLabel2
        '
        Me.UnitLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource, "Unit", True))
        Me.UnitLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.UnitLabel2.Location = New System.Drawing.Point(956, 51)
        Me.UnitLabel2.Name = "UnitLabel2"
        Me.UnitLabel2.Size = New System.Drawing.Size(100, 13)
        Me.UnitLabel2.TabIndex = 45
        Me.UnitLabel2.Text = "Label2"
        '
        'Tbl_MakersTableAdapter
        '
        Me.Tbl_MakersTableAdapter.ClearBeforeFill = True
        '
        'RateLabel1
        '
        Me.RateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MakersBindingSource, "Rate", True))
        Me.RateLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.RateLabel1.Location = New System.Drawing.Point(592, 662)
        Me.RateLabel1.Name = "RateLabel1"
        Me.RateLabel1.Size = New System.Drawing.Size(100, 10)
        Me.RateLabel1.TabIndex = 46
        '
        'StrockLabel1
        '
        Me.StrockLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MakersBindingSource, "Strock", True))
        Me.StrockLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.StrockLabel1.Location = New System.Drawing.Point(717, 662)
        Me.StrockLabel1.Name = "StrockLabel1"
        Me.StrockLabel1.Size = New System.Drawing.Size(100, 10)
        Me.StrockLabel1.TabIndex = 47
        '
        'frmDailyTranIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1364, 688)
        Me.Controls.Add(Me.StrockLabel1)
        Me.Controls.Add(Me.RateLabel1)
        Me.Controls.Add(UnitLabel)
        Me.Controls.Add(Me.UnitLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.CPPULabel1)
        Me.Controls.Add(Me.CurrencyLabel1)
        Me.Controls.Add(Me.UnitLabel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDailyTranIn"
        Me.Text = "Daily Material Inward Entries"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_Tran_InDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSNewTranIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MakersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMat_Brow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.ResumeLayout(False)
        Me.Tbl_Inv_Tran_DateBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSNewTranIn As FS_ERP_MM.DSNewTranIn
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Inv_Tran_InBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_InTableAdapter As FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_Tran_InTableAdapter
    Friend WithEvents Tbl_Inv_Tran_InDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_Tran_DateBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents UnitLabel1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents CPPULabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_Inv_LocalCustBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_LocalCustTableAdapter As FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_LocalCustTableAdapter
    Friend WithEvents DSMat_Brow As FS_ERP_MM.DSMat_Brow
    Friend WithEvents Tbl_Inv_Rack_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Rack_InfoTableAdapter As FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Rack_InfoTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSMat_BrowTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents UnitLabel2 As System.Windows.Forms.Label
    Friend WithEvents Tbl_MakersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MakersTableAdapter As FS_ERP_MM.DSNewTranInTableAdapters.tbl_MakersTableAdapter
    Friend WithEvents RateLabel1 As Label
    Friend WithEvents StrockLabel1 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents BallType As DataGridViewComboBoxColumn
    Friend WithEvents BallRate As DataGridViewTextBoxColumn
    Friend WithEvents Strock As DataGridViewTextBoxColumn
    Friend WithEvents MakerID As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
    Friend WithEvents RackId As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
