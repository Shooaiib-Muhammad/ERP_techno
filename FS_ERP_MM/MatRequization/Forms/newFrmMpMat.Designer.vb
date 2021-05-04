<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newFrmMpMat
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
        Dim Label3 As System.Windows.Forms.Label
        Dim MPIDLabel As System.Windows.Forms.Label
        Dim ModelNameLabel As System.Windows.Forms.Label
        Dim FactoryCodeLabel As System.Windows.Forms.Label
        Dim TotalQtyLabel As System.Windows.Forms.Label
        Dim PlanDateLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newFrmMpMat))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DSMPMat = New FS_ERP_MM.DSMPMat()
        Me.View_PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_PlanTableAdapter = New FS_ERP_MM.DSMPMatTableAdapters.view_PlanTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSMPMatTableAdapters.TableAdapterManager()
        Me.Tbl_MPNO_Wise_MaterialTableAdapter = New FS_ERP_MM.DSMPMatTableAdapters.tbl_MPNO_Wise_MaterialTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.View_MS_PlanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.View_MS_PlanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MPIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ModelNameLabel1 = New System.Windows.Forms.Label()
        Me.FactoryCodeLabel1 = New System.Windows.Forms.Label()
        Me.TotalQtyLabel1 = New System.Windows.Forms.Label()
        Me.PlanDateLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_MPNO_Wise_MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Inv_RequisitionDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_RequisitionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Prd_LinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Pro_MaterialTableAdapter = New FS_ERP_MM.DSMPMatTableAdapters.tbl_Pro_MaterialTableAdapter()
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.DSMPMatTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.Tbl_Pur_UnitOfMeasurement1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_UnitOfMeasurement1TableAdapter = New FS_ERP_MM.DSMPMatTableAdapters.tbl_Pur_UnitOfMeasurement1TableAdapter()
        Me.Tbl_Inv_RequisitionTableAdapter = New FS_ERP_MM.DSMPMatTableAdapters.tbl_Inv_RequisitionTableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSMPMatTableAdapters.tbl_Inv_L4TableAdapter()
        Me.UnitLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Prd_LinesTableAdapter = New FS_ERP_MM.DSMPMatTableAdapters.tbl_Prd_LinesTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrdLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequiredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Label3 = New System.Windows.Forms.Label()
        MPIDLabel = New System.Windows.Forms.Label()
        ModelNameLabel = New System.Windows.Forms.Label()
        FactoryCodeLabel = New System.Windows.Forms.Label()
        TotalQtyLabel = New System.Windows.Forms.Label()
        PlanDateLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.DSMPMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.View_MS_PlanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.View_MS_PlanBindingNavigator.SuspendLayout()
        CType(Me.Tbl_MPNO_Wise_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_RequisitionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_RequisitionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Prd_LinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurement1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(393, 34)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(48, 20)
        Label3.TabIndex = 29
        Label3.Text = "Size:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MPIDLabel
        '
        MPIDLabel.Location = New System.Drawing.Point(5, 34)
        MPIDLabel.Name = "MPIDLabel"
        MPIDLabel.Size = New System.Drawing.Size(60, 20)
        MPIDLabel.TabIndex = 20
        MPIDLabel.Text = "MP No.:"
        MPIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModelNameLabel
        '
        ModelNameLabel.Location = New System.Drawing.Point(211, 34)
        ModelNameLabel.Name = "ModelNameLabel"
        ModelNameLabel.Size = New System.Drawing.Size(67, 20)
        ModelNameLabel.TabIndex = 21
        ModelNameLabel.Text = "Article No.:"
        ModelNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FactoryCodeLabel
        '
        FactoryCodeLabel.Location = New System.Drawing.Point(557, 34)
        FactoryCodeLabel.Name = "FactoryCodeLabel"
        FactoryCodeLabel.Size = New System.Drawing.Size(81, 20)
        FactoryCodeLabel.TabIndex = 22
        FactoryCodeLabel.Text = "Factory Code:"
        FactoryCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalQtyLabel
        '
        TotalQtyLabel.Location = New System.Drawing.Point(762, 34)
        TotalQtyLabel.Name = "TotalQtyLabel"
        TotalQtyLabel.Size = New System.Drawing.Size(53, 20)
        TotalQtyLabel.TabIndex = 23
        TotalQtyLabel.Text = "Plan Qty:"
        TotalQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PlanDateLabel
        '
        PlanDateLabel.Location = New System.Drawing.Point(900, 34)
        PlanDateLabel.Name = "PlanDateLabel"
        PlanDateLabel.Size = New System.Drawing.Size(81, 20)
        PlanDateLabel.TabIndex = 24
        PlanDateLabel.Text = "Plan Date:"
        PlanDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(1078, 34)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(52, 20)
        Label7.TabIndex = 31
        Label7.Text = "Prd Line:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DSMPMat
        '
        Me.DSMPMat.DataSetName = "DSMPMat"
        Me.DSMPMat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_PlanBindingSource
        '
        Me.View_PlanBindingSource.DataMember = "view_Plan"
        Me.View_PlanBindingSource.DataSource = Me.DSMPMat
        '
        'View_PlanTableAdapter
        '
        Me.View_PlanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_RequisitionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MPNO_Wise_MaterialTableAdapter = Me.Tbl_MPNO_Wise_MaterialTableAdapter
        Me.TableAdapterManager.tbl_Prd_LinesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_MaterialTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurement1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSMPMatTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_MPNO_Wise_MaterialTableAdapter
        '
        Me.Tbl_MPNO_Wise_MaterialTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.View_MS_PlanBindingNavigator)
        Me.Panel2.Controls.Add(Me.MPIDComboBox)
        Me.Panel2.Controls.Add(MPIDLabel)
        Me.Panel2.Controls.Add(Me.ModelNameLabel1)
        Me.Panel2.Controls.Add(ModelNameLabel)
        Me.Panel2.Controls.Add(Me.FactoryCodeLabel1)
        Me.Panel2.Controls.Add(FactoryCodeLabel)
        Me.Panel2.Controls.Add(Me.TotalQtyLabel1)
        Me.Panel2.Controls.Add(TotalQtyLabel)
        Me.Panel2.Controls.Add(Me.PlanDateLabel1)
        Me.Panel2.Controls.Add(PlanDateLabel)
        Me.Panel2.Location = New System.Drawing.Point(6, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1249, 69)
        Me.Panel2.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "PrdLineName", True))
        Me.Label6.Location = New System.Drawing.Point(1131, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Label2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "ArtSize", True))
        Me.Label2.Location = New System.Drawing.Point(442, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_MS_PlanBindingNavigator
        '
        Me.View_MS_PlanBindingNavigator.AddNewItem = Me.ToolStripButton1
        Me.View_MS_PlanBindingNavigator.BindingSource = Me.View_PlanBindingSource
        Me.View_MS_PlanBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.View_MS_PlanBindingNavigator.DeleteItem = Me.ToolStripButton2
        Me.View_MS_PlanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.View_MS_PlanBindingNavigatorSaveItem})
        Me.View_MS_PlanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.View_MS_PlanBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.View_MS_PlanBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.View_MS_PlanBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.View_MS_PlanBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.View_MS_PlanBindingNavigator.Name = "View_MS_PlanBindingNavigator"
        Me.View_MS_PlanBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.View_MS_PlanBindingNavigator.Size = New System.Drawing.Size(1247, 25)
        Me.View_MS_PlanBindingNavigator.TabIndex = 20
        Me.View_MS_PlanBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Delete"
        Me.ToolStripButton2.Visible = False
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
        'View_MS_PlanBindingNavigatorSaveItem
        '
        Me.View_MS_PlanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.View_MS_PlanBindingNavigatorSaveItem.Enabled = False
        Me.View_MS_PlanBindingNavigatorSaveItem.Image = CType(resources.GetObject("View_MS_PlanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.View_MS_PlanBindingNavigatorSaveItem.Name = "View_MS_PlanBindingNavigatorSaveItem"
        Me.View_MS_PlanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.View_MS_PlanBindingNavigatorSaveItem.Text = "Save Data"
        Me.View_MS_PlanBindingNavigatorSaveItem.Visible = False
        '
        'MPIDComboBox
        '
        Me.MPIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MPIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MPIDComboBox.DataSource = Me.View_PlanBindingSource
        Me.MPIDComboBox.DisplayMember = "MPID"
        Me.MPIDComboBox.FormattingEnabled = True
        Me.MPIDComboBox.Location = New System.Drawing.Point(71, 34)
        Me.MPIDComboBox.Name = "MPIDComboBox"
        Me.MPIDComboBox.Size = New System.Drawing.Size(127, 21)
        Me.MPIDComboBox.TabIndex = 21
        Me.MPIDComboBox.ValueMember = "MPID"
        '
        'ModelNameLabel1
        '
        Me.ModelNameLabel1.BackColor = System.Drawing.Color.White
        Me.ModelNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ModelNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "ArtCode", True))
        Me.ModelNameLabel1.Location = New System.Drawing.Point(284, 34)
        Me.ModelNameLabel1.Name = "ModelNameLabel1"
        Me.ModelNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.ModelNameLabel1.TabIndex = 22
        Me.ModelNameLabel1.Text = "Label2"
        Me.ModelNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FactoryCodeLabel1
        '
        Me.FactoryCodeLabel1.BackColor = System.Drawing.Color.White
        Me.FactoryCodeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FactoryCodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "FactoryCode", True))
        Me.FactoryCodeLabel1.Location = New System.Drawing.Point(639, 34)
        Me.FactoryCodeLabel1.Name = "FactoryCodeLabel1"
        Me.FactoryCodeLabel1.Size = New System.Drawing.Size(117, 20)
        Me.FactoryCodeLabel1.TabIndex = 23
        Me.FactoryCodeLabel1.Text = "Label2"
        Me.FactoryCodeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalQtyLabel1
        '
        Me.TotalQtyLabel1.BackColor = System.Drawing.Color.White
        Me.TotalQtyLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalQtyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "TotalQty", True))
        Me.TotalQtyLabel1.Location = New System.Drawing.Point(820, 34)
        Me.TotalQtyLabel1.Name = "TotalQtyLabel1"
        Me.TotalQtyLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TotalQtyLabel1.TabIndex = 24
        Me.TotalQtyLabel1.Text = "Label2"
        Me.TotalQtyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlanDateLabel1
        '
        Me.PlanDateLabel1.BackColor = System.Drawing.Color.White
        Me.PlanDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlanDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "PlanDate", True))
        Me.PlanDateLabel1.Location = New System.Drawing.Point(977, 34)
        Me.PlanDateLabel1.Name = "PlanDateLabel1"
        Me.PlanDateLabel1.Size = New System.Drawing.Size(100, 20)
        Me.PlanDateLabel1.TabIndex = 25
        Me.PlanDateLabel1.Text = "Label2"
        Me.PlanDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_MPNO_Wise_MaterialBindingSource
        '
        Me.Tbl_MPNO_Wise_MaterialBindingSource.DataMember = "view_Plan_tbl_MPNO_Wise_Material"
        Me.Tbl_MPNO_Wise_MaterialBindingSource.DataSource = Me.View_PlanBindingSource
        '
        'Tbl_Pro_MaterialBindingSource
        '
        Me.Tbl_Pro_MaterialBindingSource.DataMember = "tbl_Pro_Material"
        Me.Tbl_Pro_MaterialBindingSource.DataSource = Me.DSMPMat
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Inv_RequisitionDataGridView)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Location = New System.Drawing.Point(6, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1169, 525)
        Me.Panel1.TabIndex = 35
        '
        'Tbl_Inv_RequisitionDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_Inv_RequisitionDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Inv_RequisitionDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Inv_RequisitionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_Inv_RequisitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Inv_RequisitionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.PrdLine, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn10, Me.RequiredDate})
        Me.Tbl_Inv_RequisitionDataGridView.DataSource = Me.Tbl_Inv_RequisitionBindingSource
        Me.Tbl_Inv_RequisitionDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_Inv_RequisitionDataGridView.Name = "Tbl_Inv_RequisitionDataGridView"
        Me.Tbl_Inv_RequisitionDataGridView.RowHeadersWidth = 20
        Me.Tbl_Inv_RequisitionDataGridView.Size = New System.Drawing.Size(1161, 492)
        Me.Tbl_Inv_RequisitionDataGridView.TabIndex = 36
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSMPMat
        '
        'Tbl_Inv_RequisitionBindingSource
        '
        Me.Tbl_Inv_RequisitionBindingSource.DataMember = "view_Plan_tbl_Inv_Requisition"
        Me.Tbl_Inv_RequisitionBindingSource.DataSource = Me.View_PlanBindingSource
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_RequisitionBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton7})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1167, 25)
        Me.BindingNavigator1.TabIndex = 35
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
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.FS_ERP_MM.My.Resources.Resources.images1
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'Tbl_Prd_LinesBindingSource
        '
        Me.Tbl_Prd_LinesBindingSource.DataMember = "tbl_Prd_Lines"
        Me.Tbl_Prd_LinesBindingSource.DataSource = Me.DSMPMat
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1336, 40)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Manual Material Requisition"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Pro_MaterialTableAdapter
        '
        Me.Tbl_Pro_MaterialTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DSMPMat
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.Position = 0
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_UnitOfMeasurement1BindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurement1BindingSource.DataSource = Me.DSMPMat
        Me.Tbl_Pur_UnitOfMeasurement1BindingSource.Position = 0
        '
        'Tbl_Pur_UnitOfMeasurement1TableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurement1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_RequisitionTableAdapter
        '
        Me.Tbl_Inv_RequisitionTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'UnitLabel1
        '
        Me.UnitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource, "Unit", True))
        Me.UnitLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.UnitLabel1.Location = New System.Drawing.Point(475, 52)
        Me.UnitLabel1.Name = "UnitLabel1"
        Me.UnitLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UnitLabel1.TabIndex = 37
        Me.UnitLabel1.Text = "Label4"
        '
        'Tbl_Prd_LinesTableAdapter
        '
        Me.Tbl_Prd_LinesTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DateTimePicker2)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(6, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(425, 36)
        Me.Panel3.TabIndex = 38
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(309, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 22)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(134, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "From Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(233, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "To Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(979, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 29)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "View Requisition"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ReqID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serial No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.Tbl_Inv_L4BindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn7.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn7.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ToolTipText = "Item Name"
        Me.DataGridViewTextBoxColumn7.ValueMember = "Code"
        Me.DataGridViewTextBoxColumn7.Width = 450
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "RequestDate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn11.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ReqQty"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn13.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 70
        '
        'PrdLine
        '
        Me.PrdLine.DataPropertyName = "PrdLine"
        Me.PrdLine.HeaderText = "PrdLine"
        Me.PrdLine.Name = "PrdLine"
        Me.PrdLine.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "UOM"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn14.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 70
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Narration"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn10.HeaderText = "Narration"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 350
        '
        'RequiredDate
        '
        Me.RequiredDate.DataPropertyName = "RequiredDate"
        Me.RequiredDate.HeaderText = "RequiredDate"
        Me.RequiredDate.Name = "RequiredDate"
        Me.RequiredDate.Visible = False
        '
        'newFrmMpMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 749)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.UnitLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "newFrmMpMat"
        Me.Text = "Manual Material Requisition"
        CType(Me.DSMPMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.View_MS_PlanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.View_MS_PlanBindingNavigator.ResumeLayout(False)
        Me.View_MS_PlanBindingNavigator.PerformLayout()
        CType(Me.Tbl_MPNO_Wise_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_RequisitionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_RequisitionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Prd_LinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurement1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSMPMat As DSMPMat
    Friend WithEvents View_PlanBindingSource As BindingSource
    Friend WithEvents View_PlanTableAdapter As DSMPMatTableAdapters.view_PlanTableAdapter
    Friend WithEvents TableAdapterManager As DSMPMatTableAdapters.TableAdapterManager
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents View_MS_PlanBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents View_MS_PlanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MPIDComboBox As ComboBox
    Friend WithEvents ModelNameLabel1 As Label
    Friend WithEvents FactoryCodeLabel1 As Label
    Friend WithEvents TotalQtyLabel1 As Label
    Friend WithEvents PlanDateLabel1 As Label
    Friend WithEvents Tbl_MPNO_Wise_MaterialTableAdapter As DSMPMatTableAdapters.tbl_MPNO_Wise_MaterialTableAdapter
    Friend WithEvents Tbl_MPNO_Wise_MaterialBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
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
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Tbl_Pro_MaterialBindingSource As BindingSource
    Friend WithEvents Tbl_Pro_MaterialTableAdapter As DSMPMatTableAdapters.tbl_Pro_MaterialTableAdapter
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As DSMPMatTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents Tbl_Pur_UnitOfMeasurement1BindingSource As BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurement1TableAdapter As DSMPMatTableAdapters.tbl_Pur_UnitOfMeasurement1TableAdapter
    Friend WithEvents Tbl_Inv_RequisitionBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_RequisitionTableAdapter As DSMPMatTableAdapters.tbl_Inv_RequisitionTableAdapter
    Friend WithEvents Tbl_Inv_RequisitionDataGridView As DataGridView
    Friend WithEvents Tbl_Inv_L4BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As DSMPMatTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents UnitLabel1 As Label
    Friend WithEvents Tbl_Prd_LinesBindingSource As BindingSource
    Friend WithEvents Tbl_Prd_LinesTableAdapter As DSMPMatTableAdapters.tbl_Prd_LinesTableAdapter
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents PrdLine As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents RequiredDate As DataGridViewTextBoxColumn
End Class
