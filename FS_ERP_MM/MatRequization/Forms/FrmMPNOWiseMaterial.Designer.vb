<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMPNOWiseMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMPNOWiseMaterial))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Matreq = New FS_ERP_MM.Matreq()
        Me.Tbl_PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_planTableAdapter = New FS_ERP_MM.MatreqTableAdapters.tbl_planTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.MatreqTableAdapters.TableAdapterManager()
        Me.Tbl_MPNO_Wise_MaterialTableAdapter = New FS_ERP_MM.MatreqTableAdapters.tbl_MPNO_Wise_MaterialTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.Tbl_MPNO_Wise_MaterialDataGridView = New System.Windows.Forms.DataGridView()
        Me.MPNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Label3 = New System.Windows.Forms.Label()
        MPIDLabel = New System.Windows.Forms.Label()
        ModelNameLabel = New System.Windows.Forms.Label()
        FactoryCodeLabel = New System.Windows.Forms.Label()
        TotalQtyLabel = New System.Windows.Forms.Label()
        PlanDateLabel = New System.Windows.Forms.Label()
        CType(Me.Matreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.View_MS_PlanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.View_MS_PlanBindingNavigator.SuspendLayout()
        CType(Me.Tbl_MPNO_Wise_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MPNO_Wise_MaterialDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(419, 34)
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
        MPIDLabel.Size = New System.Drawing.Size(108, 20)
        MPIDLabel.TabIndex = 20
        MPIDLabel.Text = "MP No.:"
        MPIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModelNameLabel
        '
        ModelNameLabel.Location = New System.Drawing.Point(237, 34)
        ModelNameLabel.Name = "ModelNameLabel"
        ModelNameLabel.Size = New System.Drawing.Size(67, 20)
        ModelNameLabel.TabIndex = 21
        ModelNameLabel.Text = "Article No.:"
        ModelNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FactoryCodeLabel
        '
        FactoryCodeLabel.Location = New System.Drawing.Point(32, 60)
        FactoryCodeLabel.Name = "FactoryCodeLabel"
        FactoryCodeLabel.Size = New System.Drawing.Size(81, 20)
        FactoryCodeLabel.TabIndex = 22
        FactoryCodeLabel.Text = "Factory Code:"
        FactoryCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalQtyLabel
        '
        TotalQtyLabel.Location = New System.Drawing.Point(237, 60)
        TotalQtyLabel.Name = "TotalQtyLabel"
        TotalQtyLabel.Size = New System.Drawing.Size(67, 20)
        TotalQtyLabel.TabIndex = 23
        TotalQtyLabel.Text = "Total Qty:"
        TotalQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PlanDateLabel
        '
        PlanDateLabel.Location = New System.Drawing.Point(386, 60)
        PlanDateLabel.Name = "PlanDateLabel"
        PlanDateLabel.Size = New System.Drawing.Size(81, 20)
        PlanDateLabel.TabIndex = 24
        PlanDateLabel.Text = "Plan Date:"
        PlanDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(989, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MPNo Wise Material"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Matreq
        '
        Me.Matreq.DataSetName = "Matreq"
        Me.Matreq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_PlanBindingSource
        '
        Me.Tbl_PlanBindingSource.DataMember = "tbl_Plan"
        Me.Tbl_PlanBindingSource.DataSource = Me.Matreq
        '
        'Tbl_planTableAdapter
        '
        Me.Tbl_planTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_MPNO_Wise_MaterialTableAdapter = Me.Tbl_MPNO_Wise_MaterialTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.MatreqTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_MPNO_Wise_MaterialTableAdapter
        '
        Me.Tbl_MPNO_Wise_MaterialTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.Panel2.Location = New System.Drawing.Point(6, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(590, 97)
        Me.Panel2.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PlanBindingSource, "ArtSize", True))
        Me.Label2.Location = New System.Drawing.Point(468, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_MS_PlanBindingNavigator
        '
        Me.View_MS_PlanBindingNavigator.AddNewItem = Me.ToolStripButton1
        Me.View_MS_PlanBindingNavigator.BindingSource = Me.Tbl_PlanBindingSource
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
        Me.View_MS_PlanBindingNavigator.Size = New System.Drawing.Size(588, 25)
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
        Me.MPIDComboBox.DataSource = Me.Tbl_PlanBindingSource
        Me.MPIDComboBox.DisplayMember = "MPID"
        Me.MPIDComboBox.FormattingEnabled = True
        Me.MPIDComboBox.Location = New System.Drawing.Point(114, 33)
        Me.MPIDComboBox.Name = "MPIDComboBox"
        Me.MPIDComboBox.Size = New System.Drawing.Size(117, 21)
        Me.MPIDComboBox.TabIndex = 21
        Me.MPIDComboBox.ValueMember = "MPID"
        '
        'ModelNameLabel1
        '
        Me.ModelNameLabel1.BackColor = System.Drawing.Color.White
        Me.ModelNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ModelNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PlanBindingSource, "ArtCode", True))
        Me.ModelNameLabel1.Location = New System.Drawing.Point(310, 34)
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
        Me.FactoryCodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PlanBindingSource, "FactoryCode", True))
        Me.FactoryCodeLabel1.Location = New System.Drawing.Point(114, 60)
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
        Me.TotalQtyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PlanBindingSource, "TotalQty", True))
        Me.TotalQtyLabel1.Location = New System.Drawing.Point(310, 60)
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
        Me.PlanDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PlanBindingSource, "PlanDate", True))
        Me.PlanDateLabel1.Location = New System.Drawing.Point(468, 60)
        Me.PlanDateLabel1.Name = "PlanDateLabel1"
        Me.PlanDateLabel1.Size = New System.Drawing.Size(100, 20)
        Me.PlanDateLabel1.TabIndex = 25
        Me.PlanDateLabel1.Text = "Label2"
        Me.PlanDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_MPNO_Wise_MaterialBindingSource
        '
        Me.Tbl_MPNO_Wise_MaterialBindingSource.DataMember = "tbl_Plan_tbl_MPNO_Wise_Material"
        Me.Tbl_MPNO_Wise_MaterialBindingSource.DataSource = Me.Tbl_PlanBindingSource
        '
        'Tbl_MPNO_Wise_MaterialDataGridView
        '
        Me.Tbl_MPNO_Wise_MaterialDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_MPNO_Wise_MaterialDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_MPNO_Wise_MaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_MPNO_Wise_MaterialDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MPNo, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Tbl_MPNO_Wise_MaterialDataGridView.DataSource = Me.Tbl_MPNO_Wise_MaterialBindingSource
        Me.Tbl_MPNO_Wise_MaterialDataGridView.Location = New System.Drawing.Point(8, 28)
        Me.Tbl_MPNO_Wise_MaterialDataGridView.Name = "Tbl_MPNO_Wise_MaterialDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_MPNO_Wise_MaterialDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Tbl_MPNO_Wise_MaterialDataGridView.RowHeadersWidth = 23
        Me.Tbl_MPNO_Wise_MaterialDataGridView.Size = New System.Drawing.Size(676, 393)
        Me.Tbl_MPNO_Wise_MaterialDataGridView.TabIndex = 33
        '
        'MPNo
        '
        Me.MPNo.DataPropertyName = "MPNo"
        Me.MPNo.HeaderText = "MP No"
        Me.MPNo.Name = "MPNo"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MaterialName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Material Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Qty"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UOM"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Naration"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Naration"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.Tbl_MPNO_Wise_MaterialDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(7, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 426)
        Me.Panel1.TabIndex = 34
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_MPNO_Wise_MaterialBindingSource
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(696, 25)
        Me.BindingNavigator1.TabIndex = 34
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
        'FrmMPNOWiseMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMPNOWiseMaterial"
        Me.Text = "FrmMPNOWiseMaterial"
        CType(Me.Matreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.View_MS_PlanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.View_MS_PlanBindingNavigator.ResumeLayout(False)
        Me.View_MS_PlanBindingNavigator.PerformLayout()
        CType(Me.Tbl_MPNO_Wise_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MPNO_Wise_MaterialDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Matreq As Matreq
    Friend WithEvents Tbl_PlanBindingSource As BindingSource
    Friend WithEvents Tbl_planTableAdapter As MatreqTableAdapters.tbl_planTableAdapter
    Friend WithEvents TableAdapterManager As MatreqTableAdapters.TableAdapterManager
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
    Friend WithEvents Tbl_MPNO_Wise_MaterialTableAdapter As MatreqTableAdapters.tbl_MPNO_Wise_MaterialTableAdapter
    Friend WithEvents Tbl_MPNO_Wise_MaterialBindingSource As BindingSource
    Friend WithEvents Tbl_MPNO_Wise_MaterialDataGridView As DataGridView
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
    Friend WithEvents MPNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
