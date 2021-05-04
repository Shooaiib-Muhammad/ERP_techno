<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Machines
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
        Dim MachineNameLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Machines))
        Me.DMMS = New FS_ERP_MM.DMMS()
        Me.Tbl_PIR_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PIR_DeptTableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_PIR_DeptTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DMMSTableAdapters.TableAdapterManager()
        Me.Tbl_DMMS_MachinesTableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_DMMS_MachinesTableAdapter()
        Me.Tbl_PIR_SectionTableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_PIR_SectionTableAdapter()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_PIR_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_DMMS_MachinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.MachineNameTextBox = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Tbl_DMMS_Scheduling_ParmetersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_DMMS_Scheduling_ParmetersTableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_DMMS_Scheduling_ParmetersTableAdapter()
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView = New System.Windows.Forms.DataGridView()
        Me.SchedulePeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        SectionNameLabel = New System.Windows.Forms.Label()
        MachineNameLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DMMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PIR_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PIR_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_DMMS_MachinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_DMMS_Scheduling_ParmetersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_DMMS_Scheduling_ParmetersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeptNameLabel
        '
        DeptNameLabel.AutoSize = True
        DeptNameLabel.Location = New System.Drawing.Point(21, 49)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(68, 13)
        DeptNameLabel.TabIndex = 1
        DeptNameLabel.Text = "Department :"
        '
        'SectionNameLabel
        '
        SectionNameLabel.AutoSize = True
        SectionNameLabel.Location = New System.Drawing.Point(376, 49)
        SectionNameLabel.Name = "SectionNameLabel"
        SectionNameLabel.Size = New System.Drawing.Size(77, 13)
        SectionNameLabel.TabIndex = 3
        SectionNameLabel.Text = "Section Name:"
        '
        'MachineNameLabel
        '
        MachineNameLabel.AutoSize = True
        MachineNameLabel.Location = New System.Drawing.Point(7, 82)
        MachineNameLabel.Name = "MachineNameLabel"
        MachineNameLabel.Size = New System.Drawing.Size(82, 13)
        MachineNameLabel.TabIndex = 0
        MachineNameLabel.Text = "Machine Name:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(507, 87)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(87, 13)
        StatusLabel.TabIndex = 2
        StatusLabel.Text = "Machine Status :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(376, 87)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(101, 13)
        Label2.TabIndex = 5
        Label2.Text = "Department Status :"
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
        Me.TableAdapterManager.tbl_DMMS_MachinesTableAdapter = Me.Tbl_DMMS_MachinesTableAdapter
        Me.TableAdapterManager.tbl_DMMS_Parts1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_PartsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_Scheduling_ParmetersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PIR_DeptTableAdapter = Me.Tbl_PIR_DeptTableAdapter
        Me.TableAdapterManager.tbl_PIR_SectionTableAdapter = Me.Tbl_PIR_SectionTableAdapter
        Me.TableAdapterManager.tbl_PIR_UsersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DMMSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_DMMS_MachinesTableAdapter = Nothing
        '
        'Tbl_DMMS_MachinesTableAdapter
        '
        Me.Tbl_DMMS_MachinesTableAdapter.ClearBeforeFill = True
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
        Me.DeptNameComboBox.Location = New System.Drawing.Point(91, 45)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(268, 21)
        Me.DeptNameComboBox.TabIndex = 2
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
        Me.SectionNameComboBox.Location = New System.Drawing.Point(459, 45)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(216, 21)
        Me.SectionNameComboBox.TabIndex = 4
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
        Me.Label1.Size = New System.Drawing.Size(1412, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DMMS Machines"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.DeptNameComboBox)
        Me.Panel2.Controls.Add(SectionNameLabel)
        Me.Panel2.Controls.Add(DeptNameLabel)
        Me.Panel2.Controls.Add(Me.SectionNameComboBox)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(StatusLabel)
        Me.Panel2.Controls.Add(Me.StatusCheckBox)
        Me.Panel2.Controls.Add(MachineNameLabel)
        Me.Panel2.Controls.Add(Me.MachineNameTextBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 116)
        Me.Panel2.TabIndex = 13
        '
        'CheckBox1
        '
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_PIR_DeptBindingSource, "MMSStatus", True))
        Me.CheckBox1.Location = New System.Drawing.Point(483, 82)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(26, 24)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_DMMS_MachinesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(707, 25)
        Me.BindingNavigator1.TabIndex = 4
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
        'Tbl_DMMS_MachinesBindingSource
        '
        Me.Tbl_DMMS_MachinesBindingSource.DataMember = "tbl_PIR_Section_tbl_DMMS_Machines"
        Me.Tbl_DMMS_MachinesBindingSource.DataSource = Me.Tbl_PIR_SectionBindingSource
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
        'StatusCheckBox
        '
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_DMMS_MachinesBindingSource, "Status", True))
        Me.StatusCheckBox.Location = New System.Drawing.Point(600, 82)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.StatusCheckBox.TabIndex = 3
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'MachineNameTextBox
        '
        Me.MachineNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_DMMS_MachinesBindingSource, "MachineName", True))
        Me.MachineNameTextBox.Location = New System.Drawing.Point(95, 78)
        Me.MachineNameTextBox.Name = "MachineNameTextBox"
        Me.MachineNameTextBox.Size = New System.Drawing.Size(264, 20)
        Me.MachineNameTextBox.TabIndex = 1
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(26, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Daily"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(160, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.Text = "Monthly"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(379, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton3.TabIndex = 16
        Me.RadioButton3.Text = "Yearly"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Tbl_DMMS_Scheduling_ParmetersBindingSource
        '
        Me.Tbl_DMMS_Scheduling_ParmetersBindingSource.DataMember = "tbl_DMMS_Machines_tbl_DMMS_Scheduling_Parmeters"
        Me.Tbl_DMMS_Scheduling_ParmetersBindingSource.DataSource = Me.Tbl_DMMS_MachinesBindingSource
        '
        'Tbl_DMMS_Scheduling_ParmetersTableAdapter
        '
        Me.Tbl_DMMS_Scheduling_ParmetersTableAdapter.ClearBeforeFill = True
        '
        'Tbl_DMMS_Scheduling_ParmetersDataGridView
        '
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView.AutoGenerateColumns = False
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SchedulePeriod, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView.DataSource = Me.Tbl_DMMS_Scheduling_ParmetersBindingSource
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView.Name = "Tbl_DMMS_Scheduling_ParmetersDataGridView"
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView.RowHeadersWidth = 23
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView.Size = New System.Drawing.Size(436, 383)
        Me.Tbl_DMMS_Scheduling_ParmetersDataGridView.TabIndex = 17
        '
        'SchedulePeriod
        '
        Me.SchedulePeriod.DataPropertyName = "SchedulePeriod"
        Me.SchedulePeriod.HeaderText = "Period"
        Me.SchedulePeriod.Name = "SchedulePeriod"
        Me.SchedulePeriod.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PeremeterName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BindingNavigator2)
        Me.Panel4.Controls.Add(Me.Tbl_DMMS_Scheduling_ParmetersDataGridView)
        Me.Panel4.Location = New System.Drawing.Point(16, 217)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(444, 429)
        Me.Panel4.TabIndex = 18
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.ToolStripButton2
        Me.BindingNavigator2.BindingSource = Me.Tbl_DMMS_Scheduling_ParmetersBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripButton7})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator2.Size = New System.Drawing.Size(442, 25)
        Me.BindingNavigator2.TabIndex = 18
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
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
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.FS_ERP_MM.My.Resources.Resources.images1
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "ToolStripButton1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 46)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheduling Period :"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(228, 19)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton6.TabIndex = 19
        Me.RadioButton6.Text = "3 Month"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(298, 19)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton5.TabIndex = 18
        Me.RadioButton5.Text = "6 Month"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(91, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton4.TabIndex = 17
        Me.RadioButton4.Text = "Weekly"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PIR_DeptBindingSource, "DeptID", True))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(793, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Label3"
        '
        'Machines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1412, 776)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Machines"
        Me.Text = "Machines"
        CType(Me.DMMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PIR_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PIR_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_DMMS_MachinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_DMMS_Scheduling_ParmetersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_DMMS_Scheduling_ParmetersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Tbl_DMMS_MachinesTableAdapter As DMMSTableAdapters.tbl_DMMS_MachinesTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tbl_DMMS_MachinesBindingSource As BindingSource
    Friend WithEvents MachineNameTextBox As TextBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents StatusCheckBox As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Tbl_DMMS_Scheduling_ParmetersBindingSource As BindingSource
    Friend WithEvents Tbl_DMMS_Scheduling_ParmetersTableAdapter As DMMSTableAdapters.tbl_DMMS_Scheduling_ParmetersTableAdapter
    Friend WithEvents Tbl_DMMS_Scheduling_ParmetersDataGridView As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SchedulePeriod As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
End Class
