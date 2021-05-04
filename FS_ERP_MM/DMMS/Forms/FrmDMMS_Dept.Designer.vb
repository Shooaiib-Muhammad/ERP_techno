<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDMMS_Dept
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
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim SectionNameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDMMS_Dept))
        Me.DMMS = New FS_ERP_MM.DMMS()
        Me.Tbl_PIR_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PIR_DeptTableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_PIR_DeptTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DMMSTableAdapters.TableAdapterManager()
        Me.Tbl_PIR_SectionTableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_PIR_SectionTableAdapter()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_PIR_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HolderIDLabel1 = New System.Windows.Forms.Label()
        Me.Max_HoldeIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Tbl_DMMS_HoldersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_DMMS_HoldersTableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_DMMS_HoldersTableAdapter()
        Me.View_DMMS_MachinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_DMMS_MachinesTableAdapter = New FS_ERP_MM.DMMSTableAdapters.View_DMMS_MachinesTableAdapter()
        Me.View_DMMS_MachinesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrpitions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_PIR_UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PIR_UsersTableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_PIR_UsersTableAdapter()
        Me.Max_HoldeIDTableAdapter = New FS_ERP_MM.DMMSTableAdapters.max_HoldeIDTableAdapter()
        DeptNameLabel = New System.Windows.Forms.Label()
        SectionNameLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.DMMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PIR_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PIR_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Max_HoldeIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_DMMS_HoldersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_DMMS_MachinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_DMMS_MachinesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_PIR_UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeptNameLabel
        '
        DeptNameLabel.AutoSize = True
        DeptNameLabel.Location = New System.Drawing.Point(14, 30)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(99, 13)
        DeptNameLabel.TabIndex = 1
        DeptNameLabel.Text = "Department Name :"
        '
        'SectionNameLabel
        '
        SectionNameLabel.AutoSize = True
        SectionNameLabel.Location = New System.Drawing.Point(371, 29)
        SectionNameLabel.Name = "SectionNameLabel"
        SectionNameLabel.Size = New System.Drawing.Size(51, 13)
        SectionNameLabel.TabIndex = 2
        SectionNameLabel.Text = "Sections:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(67, 57)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(38, 13)
        Label2.TabIndex = 5
        Label2.Text = "Name:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(345, 58)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(79, 13)
        Label3.TabIndex = 7
        Label3.Text = "Email Address :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(49, 83)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(64, 13)
        Label4.TabIndex = 9
        Label4.Text = "Phone No. :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(385, 83)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(37, 13)
        Label5.TabIndex = 12
        Label5.Text = "Skills :"
        '
        'DMMS
        '
        Me.DMMS.DataSetName = "DMMS"
        Me.DMMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_PIR_DeptBindingSource
        '
        Me.Tbl_PIR_DeptBindingSource.DataMember = "tbl_PIR_Dept"
        Me.Tbl_PIR_DeptBindingSource.DataSource = Me.DMMS
        '
        'Tbl_PIR_DeptTableAdapter
        '
        Me.Tbl_PIR_DeptTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_DMMS_CatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_HoldersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_MachinesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_Scheduling_ParmetersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PIR_DeptTableAdapter = Me.Tbl_PIR_DeptTableAdapter
        Me.TableAdapterManager.tbl_PIR_SectionTableAdapter = Me.Tbl_PIR_SectionTableAdapter
        Me.TableAdapterManager.tbl_PIR_UsersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DMMSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_DMMS_MachinesTableAdapter = Nothing
        '
        'Tbl_PIR_SectionTableAdapter
        '
        Me.Tbl_PIR_SectionTableAdapter.ClearBeforeFill = True
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_PIR_DeptBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(120, 26)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(217, 21)
        Me.DeptNameComboBox.TabIndex = 0
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'Tbl_PIR_SectionBindingSource
        '
        Me.Tbl_PIR_SectionBindingSource.DataMember = "tbl_PIR_Dept_tbl_PIR_Section"
        Me.Tbl_PIR_SectionBindingSource.DataSource = Me.Tbl_PIR_DeptBindingSource
        '
        'SectionNameComboBox
        '
        Me.SectionNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SectionNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SectionNameComboBox.DataSource = Me.Tbl_PIR_SectionBindingSource
        Me.SectionNameComboBox.DisplayMember = "SectionName"
        Me.SectionNameComboBox.FormattingEnabled = True
        Me.SectionNameComboBox.Location = New System.Drawing.Point(431, 25)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(302, 21)
        Me.SectionNameComboBox.TabIndex = 1
        Me.SectionNameComboBox.ValueMember = "SectionID"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1193, 40)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "DMMS Holders"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.HolderIDLabel1)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.DeptNameComboBox)
        Me.Panel1.Controls.Add(DeptNameLabel)
        Me.Panel1.Controls.Add(SectionNameLabel)
        Me.Panel1.Controls.Add(Me.SectionNameComboBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 221)
        Me.Panel1.TabIndex = 0
        '
        'HolderIDLabel1
        '
        Me.HolderIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Max_HoldeIDBindingSource, "HolderID", True))
        Me.HolderIDLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HolderIDLabel1.Location = New System.Drawing.Point(781, 53)
        Me.HolderIDLabel1.Name = "HolderIDLabel1"
        Me.HolderIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.HolderIDLabel1.TabIndex = 15
        Me.HolderIDLabel1.Text = "Label6"
        '
        'Max_HoldeIDBindingSource
        '
        Me.Max_HoldeIDBindingSource.DataMember = "Max_HoldeID"
        Me.Max_HoldeIDBindingSource.DataSource = Me.DMMS
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(431, 83)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(305, 97)
        Me.TextBox4.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(760, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(120, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(219, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(433, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(302, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(219, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Tbl_DMMS_HoldersBindingSource
        '
        Me.Tbl_DMMS_HoldersBindingSource.DataMember = "tbl_DMMS_Holders"
        Me.Tbl_DMMS_HoldersBindingSource.DataSource = Me.DMMS
        '
        'Tbl_DMMS_HoldersTableAdapter
        '
        Me.Tbl_DMMS_HoldersTableAdapter.ClearBeforeFill = True
        '
        'View_DMMS_MachinesBindingSource
        '
        Me.View_DMMS_MachinesBindingSource.DataMember = "View_DMMS_Machines"
        Me.View_DMMS_MachinesBindingSource.DataSource = Me.DMMS
        '
        'View_DMMS_MachinesTableAdapter
        '
        Me.View_DMMS_MachinesTableAdapter.ClearBeforeFill = True
        '
        'View_DMMS_MachinesDataGridView
        '
        Me.View_DMMS_MachinesDataGridView.AutoGenerateColumns = False
        Me.View_DMMS_MachinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_DMMS_MachinesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.UserID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Descrpitions, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.View_DMMS_MachinesDataGridView.DataSource = Me.View_DMMS_MachinesBindingSource
        Me.View_DMMS_MachinesDataGridView.Location = New System.Drawing.Point(3, 30)
        Me.View_DMMS_MachinesDataGridView.Name = "View_DMMS_MachinesDataGridView"
        Me.View_DMMS_MachinesDataGridView.RowHeadersWidth = 23
        Me.View_DMMS_MachinesDataGridView.Size = New System.Drawing.Size(884, 374)
        Me.View_DMMS_MachinesDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DeptName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 123
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SectionName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Section"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "UserID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PhoneNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Descrpitions
        '
        Me.Descrpitions.DataPropertyName = "Descrpitions"
        Me.Descrpitions.HeaderText = "Skills"
        Me.Descrpitions.Name = "Descrpitions"
        Me.Descrpitions.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "HODName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "HOD Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "HODEmial"
        Me.DataGridViewTextBoxColumn8.HeaderText = "HOD Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.View_DMMS_MachinesDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(6, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(892, 407)
        Me.Panel2.TabIndex = 14
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.View_DMMS_MachinesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(890, 25)
        Me.BindingNavigator1.TabIndex = 14
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.FS_ERP_MM.My.Resources.Resources.images1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Tbl_PIR_UsersBindingSource
        '
        Me.Tbl_PIR_UsersBindingSource.DataMember = "tbl_PIR_Users"
        Me.Tbl_PIR_UsersBindingSource.DataSource = Me.DMMS
        '
        'Tbl_PIR_UsersTableAdapter
        '
        Me.Tbl_PIR_UsersTableAdapter.ClearBeforeFill = True
        '
        'Max_HoldeIDTableAdapter
        '
        Me.Max_HoldeIDTableAdapter.ClearBeforeFill = True
        '
        'FrmDMMS_Dept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 727)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDMMS_Dept"
        Me.Text = "FrmDMMS_Dept"
        CType(Me.DMMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PIR_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PIR_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Max_HoldeIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_DMMS_HoldersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_DMMS_MachinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_DMMS_MachinesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_PIR_UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DMMS As DMMS
    Friend WithEvents Tbl_PIR_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_PIR_DeptTableAdapter As DMMSTableAdapters.tbl_PIR_DeptTableAdapter
    Friend WithEvents TableAdapterManager As DMMSTableAdapters.TableAdapterManager
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents Tbl_PIR_SectionTableAdapter As DMMSTableAdapters.tbl_PIR_SectionTableAdapter
    Friend WithEvents Tbl_PIR_SectionBindingSource As BindingSource
    Friend WithEvents SectionNameComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Tbl_DMMS_HoldersBindingSource As BindingSource
    Friend WithEvents Tbl_DMMS_HoldersTableAdapter As DMMSTableAdapters.tbl_DMMS_HoldersTableAdapter
    Friend WithEvents View_DMMS_MachinesBindingSource As BindingSource
    Friend WithEvents View_DMMS_MachinesTableAdapter As DMMSTableAdapters.View_DMMS_MachinesTableAdapter
    Friend WithEvents View_DMMS_MachinesDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Descrpitions As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_PIR_UsersBindingSource As BindingSource
    Friend WithEvents Tbl_PIR_UsersTableAdapter As DMMSTableAdapters.tbl_PIR_UsersTableAdapter
    Friend WithEvents Max_HoldeIDBindingSource As BindingSource
    Friend WithEvents Max_HoldeIDTableAdapter As DMMSTableAdapters.max_HoldeIDTableAdapter
    Friend WithEvents HolderIDLabel1 As Label
End Class
