<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsserts
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
        Dim AssertTypeLabel As System.Windows.Forms.Label
        Dim OriginalLifeLabel As System.Windows.Forms.Label
        Dim PurcaseDateLabel As System.Windows.Forms.Label
        Dim OverHallDateLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim OverHallCostLabel As System.Windows.Forms.Label
        Dim DepreciationLabel As System.Windows.Forms.Label
        Dim AllocationLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsserts))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DSAsserts = New FS_ERP_MM.DSAsserts()
        Me.Tbl_Asserts_TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Asserts_TypeTableAdapter = New FS_ERP_MM.DSAssertsTableAdapters.tbl_Asserts_TypeTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSAssertsTableAdapters.TableAdapterManager()
        Me.Tbl_Assert_OR_LifeTableAdapter = New FS_ERP_MM.DSAssertsTableAdapters.tbl_Assert_OR_LifeTableAdapter()
        Me.Tbl_AssertTableAdapter = New FS_ERP_MM.DSAssertsTableAdapters.tbl_AssertTableAdapter()
        Me.AssertTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_AssertBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Assert_OR_LifeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OriginalLifeComboBox = New System.Windows.Forms.ComboBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.OverHallCostTextBox = New System.Windows.Forms.TextBox()
        Me.DepreciationComboBox = New System.Windows.Forms.ComboBox()
        Me.AllocationTextBox = New System.Windows.Forms.TextBox()
        Me.SectEffectiveDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.View_AssertsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker14 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.View_AssertsTableAdapter = New FS_ERP_MM.DSAssertsTableAdapters.view_AssertsTableAdapter()
        Me.View_AssertsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        AssertTypeLabel = New System.Windows.Forms.Label()
        OriginalLifeLabel = New System.Windows.Forms.Label()
        PurcaseDateLabel = New System.Windows.Forms.Label()
        OverHallDateLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        OverHallCostLabel = New System.Windows.Forms.Label()
        DepreciationLabel = New System.Windows.Forms.Label()
        AllocationLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me.DSAsserts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Asserts_TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_AssertBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Assert_OR_LifeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.View_AssertsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_AssertsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AssertTypeLabel
        '
        AssertTypeLabel.AutoSize = True
        AssertTypeLabel.Location = New System.Drawing.Point(73, 16)
        AssertTypeLabel.Name = "AssertTypeLabel"
        AssertTypeLabel.Size = New System.Drawing.Size(63, 13)
        AssertTypeLabel.TabIndex = 17
        AssertTypeLabel.Text = "Asset Type:"
        '
        'OriginalLifeLabel
        '
        OriginalLifeLabel.AutoSize = True
        OriginalLifeLabel.Location = New System.Drawing.Point(276, 97)
        OriginalLifeLabel.Name = "OriginalLifeLabel"
        OriginalLifeLabel.Size = New System.Drawing.Size(65, 13)
        OriginalLifeLabel.TabIndex = 18
        OriginalLifeLabel.Text = "Original Life:"
        '
        'PurcaseDateLabel
        '
        PurcaseDateLabel.AutoSize = True
        PurcaseDateLabel.Location = New System.Drawing.Point(27, 43)
        PurcaseDateLabel.Name = "PurcaseDateLabel"
        PurcaseDateLabel.Size = New System.Drawing.Size(113, 13)
        PurcaseDateLabel.TabIndex = 19
        PurcaseDateLabel.Text = "Original Purcase Date:"
        '
        'OverHallDateLabel
        '
        OverHallDateLabel.AutoSize = True
        OverHallDateLabel.Location = New System.Drawing.Point(60, 69)
        OverHallDateLabel.Name = "OverHallDateLabel"
        OverHallDateLabel.Size = New System.Drawing.Size(80, 13)
        OverHallDateLabel.TabIndex = 20
        OverHallDateLabel.Text = "Over Hall Date:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(273, 44)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(67, 13)
        CostLabel.TabIndex = 22
        CostLabel.Text = "Orginal Cost:"
        '
        'OverHallCostLabel
        '
        OverHallCostLabel.AutoSize = True
        OverHallCostLabel.Location = New System.Drawing.Point(458, 46)
        OverHallCostLabel.Name = "OverHallCostLabel"
        OverHallCostLabel.Size = New System.Drawing.Size(78, 13)
        OverHallCostLabel.TabIndex = 23
        OverHallCostLabel.Text = "Over Hall Cost:"
        '
        'DepreciationLabel
        '
        DepreciationLabel.AutoSize = True
        DepreciationLabel.Location = New System.Drawing.Point(69, 97)
        DepreciationLabel.Name = "DepreciationLabel"
        DepreciationLabel.Size = New System.Drawing.Size(70, 13)
        DepreciationLabel.TabIndex = 24
        DepreciationLabel.Text = "Depreciation:"
        '
        'AllocationLabel
        '
        AllocationLabel.AutoSize = True
        AllocationLabel.Location = New System.Drawing.Point(273, 72)
        AllocationLabel.Name = "AllocationLabel"
        AllocationLabel.Size = New System.Drawing.Size(54, 13)
        AllocationLabel.TabIndex = 26
        AllocationLabel.Text = "Location :"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(278, 16)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 74
        NameLabel.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Firebrick
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1121, 40)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Assets Registration"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DSAsserts
        '
        Me.DSAsserts.DataSetName = "DSAsserts"
        Me.DSAsserts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Asserts_TypeBindingSource
        '
        Me.Tbl_Asserts_TypeBindingSource.DataMember = "tbl_Asserts_Type"
        Me.Tbl_Asserts_TypeBindingSource.DataSource = Me.DSAsserts
        '
        'Tbl_Asserts_TypeTableAdapter
        '
        Me.Tbl_Asserts_TypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Assert_OR_LifeTableAdapter = Me.Tbl_Assert_OR_LifeTableAdapter
        Me.TableAdapterManager.tbl_Asserts_TypeTableAdapter = Me.Tbl_Asserts_TypeTableAdapter
        Me.TableAdapterManager.tbl_AssertTableAdapter = Me.Tbl_AssertTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSAssertsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.view_AssertsTableAdapter = Nothing
        '
        'Tbl_Assert_OR_LifeTableAdapter
        '
        Me.Tbl_Assert_OR_LifeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_AssertTableAdapter
        '
        Me.Tbl_AssertTableAdapter.ClearBeforeFill = True
        '
        'AssertTypeComboBox
        '
        Me.AssertTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_AssertBindingSource, "AsTypeID", True))
        Me.AssertTypeComboBox.DataSource = Me.Tbl_Asserts_TypeBindingSource
        Me.AssertTypeComboBox.DisplayMember = "AssertType"
        Me.AssertTypeComboBox.FormattingEnabled = True
        Me.AssertTypeComboBox.Location = New System.Drawing.Point(146, 12)
        Me.AssertTypeComboBox.Name = "AssertTypeComboBox"
        Me.AssertTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AssertTypeComboBox.TabIndex = 18
        Me.AssertTypeComboBox.ValueMember = "TID"
        '
        'Tbl_AssertBindingSource
        '
        Me.Tbl_AssertBindingSource.DataMember = "tbl_Assert"
        Me.Tbl_AssertBindingSource.DataSource = Me.DSAsserts
        '
        'Tbl_Assert_OR_LifeBindingSource
        '
        Me.Tbl_Assert_OR_LifeBindingSource.DataMember = "tbl_Assert_OR_Life"
        Me.Tbl_Assert_OR_LifeBindingSource.DataSource = Me.DSAsserts
        '
        'OriginalLifeComboBox
        '
        Me.OriginalLifeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_AssertBindingSource, "OriginalLifeID", True))
        Me.OriginalLifeComboBox.DataSource = Me.Tbl_Assert_OR_LifeBindingSource
        Me.OriginalLifeComboBox.DisplayMember = "OriginalLife"
        Me.OriginalLifeComboBox.FormattingEnabled = True
        Me.OriginalLifeComboBox.Location = New System.Drawing.Point(347, 93)
        Me.OriginalLifeComboBox.Name = "OriginalLifeComboBox"
        Me.OriginalLifeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.OriginalLifeComboBox.TabIndex = 19
        Me.OriginalLifeComboBox.ValueMember = "ID"
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_AssertBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(347, 41)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(105, 20)
        Me.CostTextBox.TabIndex = 23
        '
        'OverHallCostTextBox
        '
        Me.OverHallCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_AssertBindingSource, "OverHallCost", True))
        Me.OverHallCostTextBox.Location = New System.Drawing.Point(542, 43)
        Me.OverHallCostTextBox.Name = "OverHallCostTextBox"
        Me.OverHallCostTextBox.Size = New System.Drawing.Size(121, 20)
        Me.OverHallCostTextBox.TabIndex = 24
        '
        'DepreciationComboBox
        '
        Me.DepreciationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_AssertBindingSource, "Depreciation", True))
        Me.DepreciationComboBox.FormattingEnabled = True
        Me.DepreciationComboBox.Items.AddRange(New Object() {"Reducely Balance"})
        Me.DepreciationComboBox.Location = New System.Drawing.Point(146, 93)
        Me.DepreciationComboBox.Name = "DepreciationComboBox"
        Me.DepreciationComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DepreciationComboBox.TabIndex = 25
        '
        'AllocationTextBox
        '
        Me.AllocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_AssertBindingSource, "Allocation", True))
        Me.AllocationTextBox.Location = New System.Drawing.Point(347, 69)
        Me.AllocationTextBox.Name = "AllocationTextBox"
        Me.AllocationTextBox.Size = New System.Drawing.Size(316, 20)
        Me.AllocationTextBox.TabIndex = 27
        '
        'SectEffectiveDateMaskedTextBox
        '
        Me.SectEffectiveDateMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.SectEffectiveDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_AssertBindingSource, "PurcaseDate", True))
        Me.SectEffectiveDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectEffectiveDateMaskedTextBox.Location = New System.Drawing.Point(146, 39)
        Me.SectEffectiveDateMaskedTextBox.Mask = "00-00-0000"
        Me.SectEffectiveDateMaskedTextBox.Name = "SectEffectiveDateMaskedTextBox"
        Me.SectEffectiveDateMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SectEffectiveDateMaskedTextBox.TabIndex = 42
        Me.SectEffectiveDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.LightBlue
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_AssertBindingSource, "OverHallDate", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(146, 65)
        Me.MaskedTextBox1.Mask = "00-00-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.MaskedTextBox1.TabIndex = 43
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BackColor = System.Drawing.Color.LightBlue
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_AssertBindingSource, "ExpiryDate", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(250, 11)
        Me.MaskedTextBox2.Mask = "00-00-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(112, 20)
        Me.MaskedTextBox2.TabIndex = 44
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker14)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.AssertTypeComboBox)
        Me.GroupBox1.Controls.Add(AssertTypeLabel)
        Me.GroupBox1.Controls.Add(AllocationLabel)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.AllocationTextBox)
        Me.GroupBox1.Controls.Add(Me.OriginalLifeComboBox)
        Me.GroupBox1.Controls.Add(Me.SectEffectiveDateMaskedTextBox)
        Me.GroupBox1.Controls.Add(OriginalLifeLabel)
        Me.GroupBox1.Controls.Add(DepreciationLabel)
        Me.GroupBox1.Controls.Add(PurcaseDateLabel)
        Me.GroupBox1.Controls.Add(Me.DepreciationComboBox)
        Me.GroupBox1.Controls.Add(OverHallDateLabel)
        Me.GroupBox1.Controls.Add(OverHallCostLabel)
        Me.GroupBox1.Controls.Add(Me.CostTextBox)
        Me.GroupBox1.Controls.Add(Me.OverHallCostTextBox)
        Me.GroupBox1.Controls.Add(CostLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 155)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Assets"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 33)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Expiry Date If Any :"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(201, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Yes"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(347, 10)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(15, 20)
        Me.DateTimePicker2.TabIndex = 75
        Me.DateTimePicker2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(123, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "No"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AssertsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(347, 13)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(316, 20)
        Me.NameTextBox.TabIndex = 75
        '
        'View_AssertsBindingSource
        '
        Me.View_AssertsBindingSource.DataMember = "view_Asserts"
        Me.View_AssertsBindingSource.DataSource = Me.DSAsserts
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(252, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(15, 20)
        Me.DateTimePicker1.TabIndex = 74
        '
        'DateTimePicker14
        '
        Me.DateTimePicker14.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker14.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker14.Location = New System.Drawing.Point(252, 40)
        Me.DateTimePicker14.Name = "DateTimePicker14"
        Me.DateTimePicker14.Size = New System.Drawing.Size(15, 20)
        Me.DateTimePicker14.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(542, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 30)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Add Assert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'View_AssertsTableAdapter
        '
        Me.View_AssertsTableAdapter.ClearBeforeFill = True
        '
        'View_AssertsDataGridView
        '
        Me.View_AssertsDataGridView.AllowUserToAddRows = False
        Me.View_AssertsDataGridView.AllowUserToDeleteRows = False
        Me.View_AssertsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_AssertsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_AssertsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_AssertsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn13, Me.Name, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.View_AssertsDataGridView.DataSource = Me.View_AssertsBindingSource
        Me.View_AssertsDataGridView.Location = New System.Drawing.Point(-1, 28)
        Me.View_AssertsDataGridView.Name = "View_AssertsDataGridView"
        Me.View_AssertsDataGridView.RowHeadersWidth = 23
        Me.View_AssertsDataGridView.Size = New System.Drawing.Size(1014, 295)
        Me.View_AssertsDataGridView.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.View_AssertsDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 328)
        Me.Panel1.TabIndex = 46
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.View_AssertsBindingSource
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(1016, 25)
        Me.BindingNavigator1.TabIndex = 46
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
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "AsstID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn12.HeaderText = "Reg No"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AssertType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Asset Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TransDate"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn13.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'Name
        '
        Me.Name.DataPropertyName = "Name"
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        Me.Name.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PurcaseDate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Purchase Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OverHallDate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.HeaderText = "Over Hall Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ExpiryDate"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "d"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "Expiry Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OriginalLife"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Original Life"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cost"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "OverHallCost"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn9.HeaderText = "Over Hall Cost"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Depreciation"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Depreciation"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Allocation"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'FrmAsserts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)

        Me.Text = "Asserts"
        CType(Me.DSAsserts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Asserts_TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_AssertBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Assert_OR_LifeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.View_AssertsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_AssertsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DSAsserts As DSAsserts
    Friend WithEvents Tbl_Asserts_TypeBindingSource As BindingSource
    Friend WithEvents Tbl_Asserts_TypeTableAdapter As DSAssertsTableAdapters.tbl_Asserts_TypeTableAdapter
    Friend WithEvents TableAdapterManager As DSAssertsTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Assert_OR_LifeTableAdapter As DSAssertsTableAdapters.tbl_Assert_OR_LifeTableAdapter
    Friend WithEvents AssertTypeComboBox As ComboBox
    Friend WithEvents Tbl_Assert_OR_LifeBindingSource As BindingSource
    Friend WithEvents Tbl_AssertTableAdapter As DSAssertsTableAdapters.tbl_AssertTableAdapter
    Friend WithEvents OriginalLifeComboBox As ComboBox
    Friend WithEvents Tbl_AssertBindingSource As BindingSource
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents OverHallCostTextBox As TextBox
    Friend WithEvents DepreciationComboBox As ComboBox
    Friend WithEvents AllocationTextBox As TextBox
    Friend WithEvents SectEffectiveDateMaskedTextBox As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker14 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents View_AssertsBindingSource As BindingSource
    Friend WithEvents View_AssertsTableAdapter As DSAssertsTableAdapters.view_AssertsTableAdapter
    Friend WithEvents View_AssertsDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
