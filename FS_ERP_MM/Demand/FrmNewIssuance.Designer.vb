<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewIssuance
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
        Dim GMNOLabel As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim CustNameLabel As System.Windows.Forms.Label
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewIssuance))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GMNOComboBox = New System.Windows.Forms.ComboBox()
        Me.Active_GD_NoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDemand = New FS_ERP_MM.DSDemand()
        Me.View_GPNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Tran_IN_TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Tran_IN_TransDataGridView = New System.Windows.Forms.DataGridView()
        Me.View_Tran_IN_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.View_GPNoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.View_Demand_IssuanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.undo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TranOutID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_Demand_IssuanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_LocalCust_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtGMNO = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tbl_Inv_Tran_DateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateNameComboBox = New System.Windows.Forms.ComboBox()
        Me.View_GPNoTableAdapter = New FS_ERP_MM.DSDemandTableAdapters.View_GPNoTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSDemandTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSDemandTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.View_Tran_IN_TransTableAdapter = New FS_ERP_MM.DSDemandTableAdapters.View_Tran_IN_TransTableAdapter()
        Me.View_Demand_IssuanceTableAdapter = New FS_ERP_MM.DSDemandTableAdapters.View_Demand_IssuanceTableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSDemandTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Inv_LocalCust_NewTableAdapter = New FS_ERP_MM.DSDemandTableAdapters.tbl_Inv_LocalCust_NewTableAdapter()
        Me.View_Tran_IN_newTableAdapter = New FS_ERP_MM.DSDemandTableAdapters.View_Tran_IN_newTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Active_GD_NoTableAdapter = New FS_ERP_MM.DSDemandTableAdapters.Active_GD_NoTableAdapter()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GMNO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Matbalaance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuedQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Issued = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        GMNOLabel = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        CustNameLabel = New System.Windows.Forms.Label()
        DateNameLabel = New System.Windows.Forms.Label()
        CType(Me.Active_GD_NoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDemand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_GPNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Tran_IN_TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Tran_IN_TransDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Tran_IN_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.View_GPNoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.View_GPNoBindingNavigator.SuspendLayout()
        CType(Me.View_Demand_IssuanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Demand_IssuanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_Inv_LocalCust_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'GMNOLabel
        '
        GMNOLabel.AutoSize = True
        GMNOLabel.ForeColor = System.Drawing.SystemColors.Control
        GMNOLabel.Location = New System.Drawing.Point(1259, 653)
        GMNOLabel.Name = "GMNOLabel"
        GMNOLabel.Size = New System.Drawing.Size(43, 13)
        GMNOLabel.TabIndex = 1
        GMNOLabel.Text = "GMNO:"
        GMNOLabel.Visible = False
        '
        'L4NameLabel
        '
        L4NameLabel.Location = New System.Drawing.Point(10, 51)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(78, 13)
        L4NameLabel.TabIndex = 10
        L4NameLabel.Text = "Material Name:"
        '
        'CustNameLabel
        '
        CustNameLabel.AutoSize = True
        CustNameLabel.Location = New System.Drawing.Point(23, 78)
        CustNameLabel.Name = "CustNameLabel"
        CustNameLabel.Size = New System.Drawing.Size(65, 13)
        CustNameLabel.TabIndex = 11
        CustNameLabel.Text = "Department:"
        '
        'DateNameLabel
        '
        DateNameLabel.AutoSize = True
        DateNameLabel.Location = New System.Drawing.Point(4, 43)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(64, 13)
        DateNameLabel.TabIndex = 72
        DateNameLabel.Text = "Date Name:"
        '
        'GMNOComboBox
        '
        Me.GMNOComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GMNOComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GMNOComboBox.DataSource = Me.Active_GD_NoBindingSource
        Me.GMNOComboBox.DisplayMember = "GMNO"
        Me.GMNOComboBox.FormattingEnabled = True
        Me.GMNOComboBox.Location = New System.Drawing.Point(89, 102)
        Me.GMNOComboBox.Name = "GMNOComboBox"
        Me.GMNOComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GMNOComboBox.TabIndex = 2
        Me.GMNOComboBox.ValueMember = "GMNO"
        '
        'Active_GD_NoBindingSource
        '
        Me.Active_GD_NoBindingSource.DataMember = "Active_GD_No"
        Me.Active_GD_NoBindingSource.DataSource = Me.DSDemand
        '
        'DSDemand
        '
        Me.DSDemand.DataSetName = "DSDemand"
        Me.DSDemand.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_GPNoBindingSource
        '
        Me.View_GPNoBindingSource.DataMember = "View_GPNo"
        Me.View_GPNoBindingSource.DataSource = Me.DSDemand
        '
        'View_Tran_IN_TransBindingSource
        '
        Me.View_Tran_IN_TransBindingSource.DataMember = "View_GPNo_View_Tran_IN1"
        Me.View_Tran_IN_TransBindingSource.DataSource = Me.View_GPNoBindingSource
        '
        'View_Tran_IN_TransDataGridView
        '
        Me.View_Tran_IN_TransDataGridView.AllowUserToAddRows = False
        Me.View_Tran_IN_TransDataGridView.AllowUserToDeleteRows = False
        Me.View_Tran_IN_TransDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_Tran_IN_TransDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_Tran_IN_TransDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Tran_IN_TransDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.GMNO1, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn11, Me.Narration, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn23, Me.Matbalaance, Me.IssuedQty, Me.Issued, Me.DataGridViewTextBoxColumn24})
        Me.View_Tran_IN_TransDataGridView.DataSource = Me.View_Tran_IN_NewBindingSource
        Me.View_Tran_IN_TransDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.View_Tran_IN_TransDataGridView.Name = "View_Tran_IN_TransDataGridView"
        Me.View_Tran_IN_TransDataGridView.RowHeadersWidth = 23
        Me.View_Tran_IN_TransDataGridView.Size = New System.Drawing.Size(1279, 239)
        Me.View_Tran_IN_TransDataGridView.TabIndex = 3
        '
        'View_Tran_IN_NewBindingSource
        '
        Me.View_Tran_IN_NewBindingSource.DataMember = "View_Tran_IN_New"
        Me.View_Tran_IN_NewBindingSource.DataSource = Me.DSDemand
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.View_GPNoBindingNavigator)
        Me.Panel1.Controls.Add(Me.View_Tran_IN_TransDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(7, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 272)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1149, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ISSUE ALL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_GPNoBindingNavigator
        '
        Me.View_GPNoBindingNavigator.AddNewItem = Nothing
        Me.View_GPNoBindingNavigator.BindingSource = Me.View_Tran_IN_NewBindingSource
        Me.View_GPNoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.View_GPNoBindingNavigator.DeleteItem = Nothing
        Me.View_GPNoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.View_GPNoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.View_GPNoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.View_GPNoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.View_GPNoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.View_GPNoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.View_GPNoBindingNavigator.Name = "View_GPNoBindingNavigator"
        Me.View_GPNoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.View_GPNoBindingNavigator.Size = New System.Drawing.Size(1282, 25)
        Me.View_GPNoBindingNavigator.TabIndex = 4
        Me.View_GPNoBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Firebrick
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1377, 40)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Demand Issuance"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Demand_IssuanceDataGridView
        '
        Me.View_Demand_IssuanceDataGridView.AllowUserToAddRows = False
        Me.View_Demand_IssuanceDataGridView.AllowUserToDeleteRows = False
        Me.View_Demand_IssuanceDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_Demand_IssuanceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.View_Demand_IssuanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Demand_IssuanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn7, Me.undo, Me.TranOutID})
        Me.View_Demand_IssuanceDataGridView.DataSource = Me.View_Demand_IssuanceBindingSource
        Me.View_Demand_IssuanceDataGridView.Location = New System.Drawing.Point(-2, 28)
        Me.View_Demand_IssuanceDataGridView.Name = "View_Demand_IssuanceDataGridView"
        Me.View_Demand_IssuanceDataGridView.RowHeadersWidth = 23
        Me.View_Demand_IssuanceDataGridView.Size = New System.Drawing.Size(763, 181)
        Me.View_Demand_IssuanceDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TranDocNo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "TranDocNo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DateName"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "d"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "DeptName"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Department Name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "L4Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 220
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "UOM"
        Me.DataGridViewTextBoxColumn15.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TranType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TranType"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IssuedQty"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IssuedQty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Issued Qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'undo
        '
        Me.undo.HeaderText = "Undo"
        Me.undo.Name = "undo"
        Me.undo.Text = "Undo"
        Me.undo.ToolTipText = "Undo"
        Me.undo.UseColumnTextForButtonValue = True
        '
        'TranOutID
        '
        Me.TranOutID.DataPropertyName = "TranOutID"
        Me.TranOutID.HeaderText = "TranOutID"
        Me.TranOutID.Name = "TranOutID"
        Me.TranOutID.Visible = False
        '
        'View_Demand_IssuanceBindingSource
        '
        Me.View_Demand_IssuanceBindingSource.DataMember = "View_Demand_Issuance"
        Me.View_Demand_IssuanceBindingSource.DataSource = Me.DSDemand
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.View_Demand_IssuanceDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(6, 456)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(762, 210)
        Me.Panel2.TabIndex = 18
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.View_Demand_IssuanceBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton1
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton4
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton3
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton2
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(760, 25)
        Me.BindingNavigator1.TabIndex = 18
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(1229, 504)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Label1"
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSDemand
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 117)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection :"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 89)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(104, 17)
        Me.RadioButton3.TabIndex = 67
        Me.RadioButton3.Text = "Filter By G.D.No "
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Checked = True
        Me.RadioButton8.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadioButton8.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(118, 17)
        Me.RadioButton8.TabIndex = 65
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Filter By Trans Date"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(9, 43)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton6.TabIndex = 65
        Me.RadioButton6.Text = "Filter By Item"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(9, 66)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(120, 17)
        Me.RadioButton7.TabIndex = 66
        Me.RadioButton7.Text = "Filter By Department"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.CustNameComboBox)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(L4NameLabel)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(CustNameLabel)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.L4NameComboBox)
        Me.GroupBox3.Controls.Add(Me.GMNOComboBox)
        Me.GroupBox3.Location = New System.Drawing.Point(178, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 131)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selection:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(89, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "To Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustNameComboBox
        '
        Me.CustNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustNameComboBox.DataSource = Me.Tbl_Inv_LocalCust_NewBindingSource
        Me.CustNameComboBox.DisplayMember = "CustName"
        Me.CustNameComboBox.Enabled = False
        Me.CustNameComboBox.FormattingEnabled = True
        Me.CustNameComboBox.Location = New System.Drawing.Point(89, 74)
        Me.CustNameComboBox.Name = "CustNameComboBox"
        Me.CustNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CustNameComboBox.TabIndex = 12
        Me.CustNameComboBox.ValueMember = "LocalCustID"
        '
        'Tbl_Inv_LocalCust_NewBindingSource
        '
        Me.Tbl_Inv_LocalCust_NewBindingSource.DataMember = "tbl_Inv_LocalCust_New"
        Me.Tbl_Inv_LocalCust_NewBindingSource.DataSource = Me.DSDemand
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(21, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "G.D.No.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "From Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(279, 19)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 22)
        Me.DateTimePicker2.TabIndex = 1
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.Enabled = False
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(89, 47)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(209, 21)
        Me.L4NameComboBox.TabIndex = 11
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSDemand
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(690, 140)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 69
        Me.TextBox1.Visible = False
        '
        'txtGMNO
        '
        Me.txtGMNO.Enabled = False
        Me.txtGMNO.Location = New System.Drawing.Point(915, 132)
        Me.txtGMNO.Name = "txtGMNO"
        Me.txtGMNO.Size = New System.Drawing.Size(121, 20)
        Me.txtGMNO.TabIndex = 67
        Me.txtGMNO.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Tbl_Inv_Tran_DateBindingNavigator)
        Me.Panel3.Controls.Add(Me.DateNameComboBox)
        Me.Panel3.Controls.Add(DateNameLabel)
        Me.Panel3.Location = New System.Drawing.Point(572, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(233, 74)
        Me.Panel3.TabIndex = 75
        '
        'Tbl_Inv_Tran_DateBindingNavigator
        '
        Me.Tbl_Inv_Tran_DateBindingNavigator.AddNewItem = Nothing
        Me.Tbl_Inv_Tran_DateBindingNavigator.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.Tbl_Inv_Tran_DateBindingNavigator.CountItem = Me.ToolStripLabel2
        Me.Tbl_Inv_Tran_DateBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Inv_Tran_DateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripSeparator6})
        Me.Tbl_Inv_Tran_DateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveFirstItem = Me.ToolStripButton5
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveLastItem = Me.ToolStripButton8
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveNextItem = Me.ToolStripButton7
        Me.Tbl_Inv_Tran_DateBindingNavigator.MovePreviousItem = Me.ToolStripButton6
        Me.Tbl_Inv_Tran_DateBindingNavigator.Name = "Tbl_Inv_Tran_DateBindingNavigator"
        Me.Tbl_Inv_Tran_DateBindingNavigator.PositionItem = Me.ToolStripTextBox2
        Me.Tbl_Inv_Tran_DateBindingNavigator.Size = New System.Drawing.Size(231, 25)
        Me.Tbl_Inv_Tran_DateBindingNavigator.TabIndex = 74
        Me.Tbl_Inv_Tran_DateBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move first"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move previous"
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
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Move next"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'DateNameComboBox
        '
        Me.DateNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DateNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DateNameComboBox.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.DateNameComboBox.DisplayMember = "DateName"
        Me.DateNameComboBox.FormattingEnabled = True
        Me.DateNameComboBox.Location = New System.Drawing.Point(74, 40)
        Me.DateNameComboBox.Name = "DateNameComboBox"
        Me.DateNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DateNameComboBox.TabIndex = 73
        Me.DateNameComboBox.ValueMember = "DayNo"
        '
        'View_GPNoTableAdapter
        '
        Me.View_GPNoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L4_NewTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_LocalCust_NewTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Me.Tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_InTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PUR_Vendor_InfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSDemandTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.view_Audit_Billing_verficationTableAdapter = Nothing
        Me.TableAdapterManager.View_Pur_Demands_AllTableAdapter = Nothing
        Me.TableAdapterManager.View_Tran_IN_new_oneTableAdapter = Nothing
        Me.TableAdapterManager.View_Tran_INTableAdapter = Nothing
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'View_Tran_IN_TransTableAdapter
        '
        Me.View_Tran_IN_TransTableAdapter.ClearBeforeFill = True
        '
        'View_Demand_IssuanceTableAdapter
        '
        Me.View_Demand_IssuanceTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_LocalCust_NewTableAdapter
        '
        Me.Tbl_Inv_LocalCust_NewTableAdapter.ClearBeforeFill = True
        '
        'View_Tran_IN_newTableAdapter
        '
        Me.View_Tran_IN_newTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(824, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 31)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Reload Data "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Active_GD_NoTableAdapter
        '
        Me.Active_GD_NoTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "DateName"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn22.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'GMNO1
        '
        Me.GMNO1.DataPropertyName = "GMNO1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GMNO1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GMNO1.HeaderText = "GD No,"
        Me.GMNO1.Name = "GMNO1"
        Me.GMNO1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CustName"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Department Name"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "L4Name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 220
        '
        'Narration
        '
        Me.Narration.DataPropertyName = "Narration"
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.ReadOnly = True
        Me.Narration.Width = 250
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "UpdateUOM"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn19.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "VendorName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Vendor Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TranInID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TranInID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TranType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TranType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Qty"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PPU"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PPU"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Balance"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N0"
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn23.HeaderText = "GD Balance"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 80
        '
        'Matbalaance
        '
        Me.Matbalaance.DataPropertyName = "Matbalaance"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Matbalaance.DefaultCellStyle = DataGridViewCellStyle7
        Me.Matbalaance.HeaderText = "Material Balance"
        Me.Matbalaance.Name = "Matbalaance"
        Me.Matbalaance.ReadOnly = True
        '
        'IssuedQty
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "N0"
        Me.IssuedQty.DefaultCellStyle = DataGridViewCellStyle8
        Me.IssuedQty.HeaderText = "Issued Qty"
        Me.IssuedQty.Name = "IssuedQty"
        '
        'Issued
        '
        Me.Issued.HeaderText = "Issued"
        Me.Issued.Name = "Issued"
        Me.Issued.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Issued.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Issued.Text = "Issued"
        Me.Issued.ToolTipText = "Issued"
        Me.Issued.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "LocalCustID"
        Me.DataGridViewTextBoxColumn24.HeaderText = "LocalCustID"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'FrmNewIssuance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1377, 790)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(GMNOLabel)
        Me.Controls.Add(Me.txtGMNO)
        Me.Name = "FrmNewIssuance"
        Me.Text = "FrmNewIssuance"
        CType(Me.Active_GD_NoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDemand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_GPNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Tran_IN_TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Tran_IN_TransDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Tran_IN_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.View_GPNoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.View_GPNoBindingNavigator.ResumeLayout(False)
        Me.View_GPNoBindingNavigator.PerformLayout()
        CType(Me.View_Demand_IssuanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Demand_IssuanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_Inv_LocalCust_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.ResumeLayout(False)
        Me.Tbl_Inv_Tran_DateBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSDemand As DSDemand
    Friend WithEvents View_GPNoBindingSource As BindingSource
    Friend WithEvents View_GPNoTableAdapter As DSDemandTableAdapters.View_GPNoTableAdapter
    Friend WithEvents TableAdapterManager As DSDemandTableAdapters.TableAdapterManager
    Friend WithEvents GMNOComboBox As ComboBox
    Friend WithEvents View_Tran_IN_TransBindingSource As BindingSource
    Friend WithEvents View_Tran_IN_TransTableAdapter As DSDemandTableAdapters.View_Tran_IN_TransTableAdapter
    Friend WithEvents View_Tran_IN_TransDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents View_GPNoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Label3 As Label
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As DSDemandTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As BindingSource
    Friend WithEvents View_Demand_IssuanceBindingSource As BindingSource
    Friend WithEvents View_Demand_IssuanceTableAdapter As DSDemandTableAdapters.View_Demand_IssuanceTableAdapter
    Friend WithEvents View_Demand_IssuanceDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Tbl_Inv_L4BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As DSDemandTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents CustNameComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents L4NameComboBox As ComboBox
    Friend WithEvents txtGMNO As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Tbl_Inv_Tran_DateBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents DateNameComboBox As ComboBox
    Friend WithEvents Tbl_Inv_LocalCust_NewBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_LocalCust_NewTableAdapter As DSDemandTableAdapters.tbl_Inv_LocalCust_NewTableAdapter
    Friend WithEvents View_Tran_IN_NewBindingSource As BindingSource
    Friend WithEvents View_Tran_IN_newTableAdapter As DSDemandTableAdapters.View_Tran_IN_newTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents undo As DataGridViewButtonColumn
    Friend WithEvents TranOutID As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Active_GD_NoBindingSource As BindingSource
    Friend WithEvents Active_GD_NoTableAdapter As DSDemandTableAdapters.Active_GD_NoTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents GMNO1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Narration As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents Matbalaance As DataGridViewTextBoxColumn
    Friend WithEvents IssuedQty As DataGridViewTextBoxColumn
    Friend WithEvents Issued As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
End Class
