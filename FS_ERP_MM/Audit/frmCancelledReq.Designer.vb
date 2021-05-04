<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelledReq
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
        Dim MPIDLabel As System.Windows.Forms.Label
        Dim ArtCodeLabel As System.Windows.Forms.Label
        Dim ClientNameLabel As System.Windows.Forms.Label
        Dim PlanDateLabel As System.Windows.Forms.Label
        Dim FactoryCodeLabel As System.Windows.Forms.Label
        Dim TotPlanQtyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCancelledReq))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.View_PlanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.View_PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAudit = New FS_ERP_MM.DSAudit()
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
        Me.View_PlanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MPIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TotPlanQtyLabel1 = New System.Windows.Forms.Label()
        Me.FactoryCodeLabel1 = New System.Windows.Forms.Label()
        Me.PlanDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ClientNameLabel1 = New System.Windows.Forms.Label()
        Me.ArtCodeLabel1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.View_Inv_ReqBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.View_Inv_ReqDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.View_PlanTableAdapter = New FS_ERP_MM.DSAuditTableAdapters.View_PlanTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSAuditTableAdapters.TableAdapterManager()
        Me.View_Inv_ReqTableAdapter = New FS_ERP_MM.DSAuditTableAdapters.View_Inv_ReqTableAdapter()
        MPIDLabel = New System.Windows.Forms.Label()
        ArtCodeLabel = New System.Windows.Forms.Label()
        ClientNameLabel = New System.Windows.Forms.Label()
        PlanDateLabel = New System.Windows.Forms.Label()
        FactoryCodeLabel = New System.Windows.Forms.Label()
        TotPlanQtyLabel = New System.Windows.Forms.Label()
        CType(Me.View_PlanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.View_PlanBindingNavigator.SuspendLayout()
        CType(Me.View_PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_Inv_ReqBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Inv_ReqDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MPIDLabel
        '
        MPIDLabel.AutoSize = True
        MPIDLabel.Location = New System.Drawing.Point(5, 35)
        MPIDLabel.Name = "MPIDLabel"
        MPIDLabel.Size = New System.Drawing.Size(37, 13)
        MPIDLabel.TabIndex = 1
        MPIDLabel.Text = "MPID:"
        '
        'ArtCodeLabel
        '
        ArtCodeLabel.AutoSize = True
        ArtCodeLabel.Location = New System.Drawing.Point(176, 35)
        ArtCodeLabel.Name = "ArtCodeLabel"
        ArtCodeLabel.Size = New System.Drawing.Size(51, 13)
        ArtCodeLabel.TabIndex = 3
        ArtCodeLabel.Text = "Art Code:"
        '
        'ClientNameLabel
        '
        ClientNameLabel.AutoSize = True
        ClientNameLabel.Location = New System.Drawing.Point(337, 35)
        ClientNameLabel.Name = "ClientNameLabel"
        ClientNameLabel.Size = New System.Drawing.Size(67, 13)
        ClientNameLabel.TabIndex = 5
        ClientNameLabel.Text = "Client Name:"
        '
        'PlanDateLabel
        '
        PlanDateLabel.AutoSize = True
        PlanDateLabel.Location = New System.Drawing.Point(535, 35)
        PlanDateLabel.Name = "PlanDateLabel"
        PlanDateLabel.Size = New System.Drawing.Size(57, 13)
        PlanDateLabel.TabIndex = 7
        PlanDateLabel.Text = "Plan Date:"
        '
        'FactoryCodeLabel
        '
        FactoryCodeLabel.AutoSize = True
        FactoryCodeLabel.Location = New System.Drawing.Point(702, 35)
        FactoryCodeLabel.Name = "FactoryCodeLabel"
        FactoryCodeLabel.Size = New System.Drawing.Size(73, 13)
        FactoryCodeLabel.TabIndex = 9
        FactoryCodeLabel.Text = "Factory Code:"
        '
        'TotPlanQtyLabel
        '
        TotPlanQtyLabel.AutoSize = True
        TotPlanQtyLabel.Location = New System.Drawing.Point(884, 35)
        TotPlanQtyLabel.Name = "TotPlanQtyLabel"
        TotPlanQtyLabel.Size = New System.Drawing.Size(69, 13)
        TotPlanQtyLabel.TabIndex = 11
        TotPlanQtyLabel.Text = "Tot Plan Qty:"
        '
        'View_PlanBindingNavigator
        '
        Me.View_PlanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.View_PlanBindingNavigator.BindingSource = Me.View_PlanBindingSource
        Me.View_PlanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.View_PlanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.View_PlanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.View_PlanBindingNavigatorSaveItem})
        Me.View_PlanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.View_PlanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.View_PlanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.View_PlanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.View_PlanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.View_PlanBindingNavigator.Name = "View_PlanBindingNavigator"
        Me.View_PlanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.View_PlanBindingNavigator.Size = New System.Drawing.Size(1069, 25)
        Me.View_PlanBindingNavigator.TabIndex = 0
        Me.View_PlanBindingNavigator.Text = "BindingNavigator1"
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
        'View_PlanBindingSource
        '
        Me.View_PlanBindingSource.DataMember = "View_Plan"
        Me.View_PlanBindingSource.DataSource = Me.DSAudit
        '
        'DSAudit
        '
        Me.DSAudit.DataSetName = "DSAudit"
        Me.DSAudit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'View_PlanBindingNavigatorSaveItem
        '
        Me.View_PlanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.View_PlanBindingNavigatorSaveItem.Image = CType(resources.GetObject("View_PlanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.View_PlanBindingNavigatorSaveItem.Name = "View_PlanBindingNavigatorSaveItem"
        Me.View_PlanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.View_PlanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MPIDComboBox
        '
        Me.MPIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MPIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MPIDComboBox.DataSource = Me.View_PlanBindingSource
        Me.MPIDComboBox.DisplayMember = "MPID"
        Me.MPIDComboBox.FormattingEnabled = True
        Me.MPIDComboBox.Location = New System.Drawing.Point(48, 32)
        Me.MPIDComboBox.Name = "MPIDComboBox"
        Me.MPIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MPIDComboBox.TabIndex = 2
        Me.MPIDComboBox.ValueMember = "MPID"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(TotPlanQtyLabel)
        Me.Panel1.Controls.Add(Me.TotPlanQtyLabel1)
        Me.Panel1.Controls.Add(FactoryCodeLabel)
        Me.Panel1.Controls.Add(Me.FactoryCodeLabel1)
        Me.Panel1.Controls.Add(PlanDateLabel)
        Me.Panel1.Controls.Add(Me.PlanDateMaskedTextBox)
        Me.Panel1.Controls.Add(ClientNameLabel)
        Me.Panel1.Controls.Add(Me.ClientNameLabel1)
        Me.Panel1.Controls.Add(ArtCodeLabel)
        Me.Panel1.Controls.Add(Me.ArtCodeLabel1)
        Me.Panel1.Controls.Add(MPIDLabel)
        Me.Panel1.Controls.Add(Me.MPIDComboBox)
        Me.Panel1.Controls.Add(Me.View_PlanBindingNavigator)
        Me.Panel1.Location = New System.Drawing.Point(6, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1071, 63)
        Me.Panel1.TabIndex = 3
        '
        'TotPlanQtyLabel1
        '
        Me.TotPlanQtyLabel1.BackColor = System.Drawing.Color.White
        Me.TotPlanQtyLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotPlanQtyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "TotPlanQty", True))
        Me.TotPlanQtyLabel1.Location = New System.Drawing.Point(959, 31)
        Me.TotPlanQtyLabel1.Name = "TotPlanQtyLabel1"
        Me.TotPlanQtyLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TotPlanQtyLabel1.TabIndex = 12
        Me.TotPlanQtyLabel1.Text = "Label2"
        Me.TotPlanQtyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FactoryCodeLabel1
        '
        Me.FactoryCodeLabel1.BackColor = System.Drawing.Color.White
        Me.FactoryCodeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FactoryCodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "FactoryCode", True))
        Me.FactoryCodeLabel1.Location = New System.Drawing.Point(777, 33)
        Me.FactoryCodeLabel1.Name = "FactoryCodeLabel1"
        Me.FactoryCodeLabel1.Size = New System.Drawing.Size(101, 20)
        Me.FactoryCodeLabel1.TabIndex = 10
        Me.FactoryCodeLabel1.Text = "Label2"
        Me.FactoryCodeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlanDateMaskedTextBox
        '
        Me.PlanDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "PlanDate", True))
        Me.PlanDateMaskedTextBox.Location = New System.Drawing.Point(598, 33)
        Me.PlanDateMaskedTextBox.Mask = "00/00/0000"
        Me.PlanDateMaskedTextBox.Name = "PlanDateMaskedTextBox"
        Me.PlanDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlanDateMaskedTextBox.TabIndex = 8
        Me.PlanDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PlanDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ClientNameLabel1
        '
        Me.ClientNameLabel1.BackColor = System.Drawing.Color.White
        Me.ClientNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "ClientName", True))
        Me.ClientNameLabel1.Location = New System.Drawing.Point(408, 33)
        Me.ClientNameLabel1.Name = "ClientNameLabel1"
        Me.ClientNameLabel1.Size = New System.Drawing.Size(120, 20)
        Me.ClientNameLabel1.TabIndex = 6
        Me.ClientNameLabel1.Text = "Label2"
        Me.ClientNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ArtCodeLabel1
        '
        Me.ArtCodeLabel1.BackColor = System.Drawing.Color.White
        Me.ArtCodeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ArtCodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PlanBindingSource, "ArtCode", True))
        Me.ArtCodeLabel1.Location = New System.Drawing.Point(229, 32)
        Me.ArtCodeLabel1.Name = "ArtCodeLabel1"
        Me.ArtCodeLabel1.Size = New System.Drawing.Size(100, 20)
        Me.ArtCodeLabel1.TabIndex = 4
        Me.ArtCodeLabel1.Text = "Label2"
        Me.ArtCodeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.View_Inv_ReqDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(7, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1069, 526)
        Me.Panel2.TabIndex = 4
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator1.BindingSource = Me.View_Inv_ReqBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Me.ToolStripButton2
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton7})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1067, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'View_Inv_ReqBindingSource
        '
        Me.View_Inv_ReqBindingSource.DataMember = "View_Plan_View_Inv_Req"
        Me.View_Inv_ReqBindingSource.DataSource = Me.View_PlanBindingSource
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
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Enabled = False
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Save Data"
        Me.ToolStripButton7.Visible = False
        '
        'View_Inv_ReqDataGridView
        '
        Me.View_Inv_ReqDataGridView.AllowUserToAddRows = False
        Me.View_Inv_ReqDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.View_Inv_ReqDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.View_Inv_ReqDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_Inv_ReqDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.View_Inv_ReqDataGridView.ColumnHeadersHeight = 32
        Me.View_Inv_ReqDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.Column1})
        Me.View_Inv_ReqDataGridView.DataSource = Me.View_Inv_ReqBindingSource
        Me.View_Inv_ReqDataGridView.Location = New System.Drawing.Point(2, 25)
        Me.View_Inv_ReqDataGridView.Name = "View_Inv_ReqDataGridView"
        Me.View_Inv_ReqDataGridView.RowHeadersWidth = 20
        Me.View_Inv_ReqDataGridView.Size = New System.Drawing.Size(1063, 497)
        Me.View_Inv_ReqDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ReqID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sr.No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PrdLineName"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn10.HeaderText = "PrdLine Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "RequiredDate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn11.HeaderText = "Required Date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "L4Name"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn9.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 300
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ReqFormula"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "Req Formula"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ReqQty"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn7.HeaderText = "Req Qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RequestDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RequestDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MPID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MPID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PrdLine"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PrdLine"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CancelStatus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Cancel Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CancelDate"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cancel Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Undo Cancel"
        Me.Column1.Name = "Column1"
        Me.Column1.Text = "Undo Cancel"
        Me.Column1.ToolTipText = "Undo Cancel"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1477, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cancelled Material Requisition"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(211, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Select Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Select Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(283, 49)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker2.TabIndex = 31
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(106, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 30
        '
        'View_PlanTableAdapter
        '
        Me.View_PlanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSAuditTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_Inv_ReqTableAdapter
        '
        Me.View_Inv_ReqTableAdapter.ClearBeforeFill = True
        '
        'frmCancelledReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 781)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCancelledReq"
        Me.Text = "frmCancelledReq"
        CType(Me.View_PlanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.View_PlanBindingNavigator.ResumeLayout(False)
        Me.View_PlanBindingNavigator.PerformLayout()
        CType(Me.View_PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAudit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_Inv_ReqBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Inv_ReqDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSAudit As DSAudit
    Friend WithEvents View_PlanBindingSource As BindingSource
    Friend WithEvents View_PlanTableAdapter As DSAuditTableAdapters.View_PlanTableAdapter
    Friend WithEvents TableAdapterManager As DSAuditTableAdapters.TableAdapterManager
    Friend WithEvents View_PlanBindingNavigator As BindingNavigator
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
    Friend WithEvents View_PlanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MPIDComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents View_Inv_ReqBindingSource As BindingSource
    Friend WithEvents View_Inv_ReqTableAdapter As DSAuditTableAdapters.View_Inv_ReqTableAdapter
    Friend WithEvents PlanDateMaskedTextBox As MaskedTextBox
    Friend WithEvents ClientNameLabel1 As Label
    Friend WithEvents ArtCodeLabel1 As Label
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents View_Inv_ReqDataGridView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TotPlanQtyLabel1 As Label
    Friend WithEvents FactoryCodeLabel1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
End Class
