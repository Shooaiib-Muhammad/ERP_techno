<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDemands
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
        Dim PDIDLabel As System.Windows.Forms.Label
        Dim PDDateLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim PDQtyLabel As System.Windows.Forms.Label
        Dim NarrationLabel As System.Windows.Forms.Label
        Dim UOMLabel As System.Windows.Forms.Label
        Dim LocalCustIDLabel As System.Windows.Forms.Label
        Dim DocIDLabel As System.Windows.Forms.Label
        Dim GMNoLabel As System.Windows.Forms.Label
        Dim GMNoLabel2 As System.Windows.Forms.Label
        Dim EnteryDateLabel As System.Windows.Forms.Label
        Dim VerificationStatusLabel As System.Windows.Forms.Label
        Dim DemandStatusLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDemands))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Pur_DemandBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Pur_DemandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_Demand_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPO = New FS_ERP_MM.DSPO()
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
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_LocalCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DemandStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.LocalCustIDComboBox = New System.Windows.Forms.ComboBox()
        Me.VerificationStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.CodeComboBox = New System.Windows.Forms.ComboBox()
        Me.UOMComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMNoLabel3 = New System.Windows.Forms.Label()
        Me.DocIDTextBox = New System.Windows.Forms.TextBox()
        Me.PDDateLabel2 = New System.Windows.Forms.Label()
        Me.NarrationTextBox = New System.Windows.Forms.TextBox()
        Me.PDIDLabel1 = New System.Windows.Forms.Label()
        Me.PDQtyTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Inv_LocalCustTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Inv_LocalCustTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.GMNoLabel4 = New System.Windows.Forms.Label()
        Me.FilterByGDNo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FilterByGDNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnteryDateLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Pur_Demand_HeadTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_Demand_HeadTableAdapter()
        Me.Tbl_Pur_DemandTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_DemandTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        PDIDLabel = New System.Windows.Forms.Label()
        PDDateLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        PDQtyLabel = New System.Windows.Forms.Label()
        NarrationLabel = New System.Windows.Forms.Label()
        UOMLabel = New System.Windows.Forms.Label()
        LocalCustIDLabel = New System.Windows.Forms.Label()
        DocIDLabel = New System.Windows.Forms.Label()
        GMNoLabel = New System.Windows.Forms.Label()
        GMNoLabel2 = New System.Windows.Forms.Label()
        EnteryDateLabel = New System.Windows.Forms.Label()
        VerificationStatusLabel = New System.Windows.Forms.Label()
        DemandStatusLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.Tbl_Pur_DemandBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Pur_DemandBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Pur_DemandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_Demand_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.FilterByGDNo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PDIDLabel
        '
        PDIDLabel.BackColor = System.Drawing.Color.White
        PDIDLabel.Location = New System.Drawing.Point(22, 38)
        PDIDLabel.Name = "PDIDLabel"
        PDIDLabel.Size = New System.Drawing.Size(101, 20)
        PDIDLabel.TabIndex = 5
        PDIDLabel.Text = "Serial No:"
        PDIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler PDIDLabel.Click, AddressOf Me.PDIDLabel_Click
        '
        'PDDateLabel
        '
        PDDateLabel.BackColor = System.Drawing.Color.White
        PDDateLabel.Location = New System.Drawing.Point(235, 38)
        PDDateLabel.Name = "PDDateLabel"
        PDDateLabel.Size = New System.Drawing.Size(85, 20)
        PDDateLabel.TabIndex = 6
        PDDateLabel.Text = "Demand Date:"
        PDDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler PDDateLabel.Click, AddressOf Me.PDDateLabel_Click
        '
        'CodeLabel
        '
        CodeLabel.BackColor = System.Drawing.Color.White
        CodeLabel.Location = New System.Drawing.Point(22, 66)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(101, 20)
        CodeLabel.TabIndex = 7
        CodeLabel.Text = "Item Name:"
        CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler CodeLabel.Click, AddressOf Me.CodeLabel_Click
        '
        'PDQtyLabel
        '
        PDQtyLabel.BackColor = System.Drawing.Color.White
        PDQtyLabel.Location = New System.Drawing.Point(22, 92)
        PDQtyLabel.Name = "PDQtyLabel"
        PDQtyLabel.Size = New System.Drawing.Size(101, 20)
        PDQtyLabel.TabIndex = 8
        PDQtyLabel.Text = "Item Qty:"
        PDQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler PDQtyLabel.Click, AddressOf Me.PDQtyLabel_Click
        '
        'NarrationLabel
        '
        NarrationLabel.BackColor = System.Drawing.Color.White
        NarrationLabel.Location = New System.Drawing.Point(22, 144)
        NarrationLabel.Name = "NarrationLabel"
        NarrationLabel.Size = New System.Drawing.Size(101, 20)
        NarrationLabel.TabIndex = 10
        NarrationLabel.Text = "Description (If Any):"
        NarrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler NarrationLabel.Click, AddressOf Me.NarrationLabel_Click
        '
        'UOMLabel
        '
        UOMLabel.BackColor = System.Drawing.Color.White
        UOMLabel.Location = New System.Drawing.Point(248, 92)
        UOMLabel.Name = "UOMLabel"
        UOMLabel.Size = New System.Drawing.Size(101, 20)
        UOMLabel.TabIndex = 12
        UOMLabel.Text = "U . O . M:"
        UOMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler UOMLabel.Click, AddressOf Me.UOMLabel_Click
        '
        'LocalCustIDLabel
        '
        LocalCustIDLabel.BackColor = System.Drawing.Color.White
        LocalCustIDLabel.Location = New System.Drawing.Point(465, 66)
        LocalCustIDLabel.Name = "LocalCustIDLabel"
        LocalCustIDLabel.Size = New System.Drawing.Size(110, 20)
        LocalCustIDLabel.TabIndex = 14
        LocalCustIDLabel.Text = "Department:"
        LocalCustIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler LocalCustIDLabel.Click, AddressOf Me.LocalCustIDLabel_Click
        '
        'DocIDLabel
        '
        DocIDLabel.BackColor = System.Drawing.Color.White
        DocIDLabel.Location = New System.Drawing.Point(465, 92)
        DocIDLabel.Name = "DocIDLabel"
        DocIDLabel.Size = New System.Drawing.Size(110, 20)
        DocIDLabel.TabIndex = 15
        DocIDLabel.Text = "Document No:"
        DocIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler DocIDLabel.Click, AddressOf Me.DocIDLabel_Click
        '
        'GMNoLabel
        '
        GMNoLabel.BackColor = System.Drawing.Color.White
        GMNoLabel.Location = New System.Drawing.Point(14, 36)
        GMNoLabel.Name = "GMNoLabel"
        GMNoLabel.Size = New System.Drawing.Size(109, 20)
        GMNoLabel.TabIndex = 0
        GMNoLabel.Text = "General Demand No:"
        GMNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler GMNoLabel.Click, AddressOf Me.GMNoLabel_Click
        '
        'GMNoLabel2
        '
        GMNoLabel2.BackColor = System.Drawing.Color.White
        GMNoLabel2.Location = New System.Drawing.Point(465, 38)
        GMNoLabel2.Name = "GMNoLabel2"
        GMNoLabel2.Size = New System.Drawing.Size(110, 20)
        GMNoLabel2.TabIndex = 13
        GMNoLabel2.Text = "General Demand No:"
        GMNoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler GMNoLabel2.Click, AddressOf Me.GMNoLabel2_Click
        '
        'EnteryDateLabel
        '
        EnteryDateLabel.BackColor = System.Drawing.Color.White
        EnteryDateLabel.Location = New System.Drawing.Point(197, 36)
        EnteryDateLabel.Name = "EnteryDateLabel"
        EnteryDateLabel.Size = New System.Drawing.Size(68, 20)
        EnteryDateLabel.TabIndex = 3
        EnteryDateLabel.Text = "Entery Date:"
        EnteryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler EnteryDateLabel.Click, AddressOf Me.EnteryDateLabel_Click
        '
        'VerificationStatusLabel
        '
        VerificationStatusLabel.BackColor = System.Drawing.Color.White
        VerificationStatusLabel.Location = New System.Drawing.Point(466, 119)
        VerificationStatusLabel.Name = "VerificationStatusLabel"
        VerificationStatusLabel.Size = New System.Drawing.Size(109, 20)
        VerificationStatusLabel.TabIndex = 13
        VerificationStatusLabel.Text = "Verification Status:"
        VerificationStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler VerificationStatusLabel.Click, AddressOf Me.VerificationStatusLabel_Click
        '
        'DemandStatusLabel
        '
        DemandStatusLabel.BackColor = System.Drawing.Color.White
        DemandStatusLabel.Location = New System.Drawing.Point(22, 119)
        DemandStatusLabel.Name = "DemandStatusLabel"
        DemandStatusLabel.Size = New System.Drawing.Size(101, 20)
        DemandStatusLabel.TabIndex = 13
        DemandStatusLabel.Text = "Demand Status:"
        DemandStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler DemandStatusLabel.Click, AddressOf Me.DemandStatusLabel_Click
        '
        'Label9
        '
        Label9.BackColor = System.Drawing.Color.White
        Label9.Location = New System.Drawing.Point(248, 119)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(101, 20)
        Label9.TabIndex = 17
        Label9.Text = "Demand Type:"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler Label9.Click, AddressOf Me.Label9_Click
        '
        'Label10
        '
        Label10.BackColor = System.Drawing.Color.White
        Label10.Location = New System.Drawing.Point(445, 405)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(110, 20)
        Label10.TabIndex = 19
        Label10.Text = "Replacement Status:"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label10.Visible = False
        AddHandler Label10.Click, AddressOf Me.Label10_Click
        '
        'Label11
        '
        Label11.BackColor = System.Drawing.Color.White
        Label11.Location = New System.Drawing.Point(445, 430)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(110, 20)
        Label11.TabIndex = 21
        Label11.Text = "Item Qty:"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label11.Visible = False
        AddHandler Label11.Click, AddressOf Me.Label11_Click
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(878, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Add New Demands"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Pur_DemandBindingNavigator
        '
        Me.Tbl_Pur_DemandBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Pur_DemandBindingNavigator.BindingSource = Me.Tbl_Pur_DemandBindingSource
        Me.Tbl_Pur_DemandBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Pur_DemandBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Pur_DemandBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_Pur_DemandBindingNavigatorSaveItem, Me.BindingNavigatorDeleteItem})
        Me.Tbl_Pur_DemandBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Pur_DemandBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Pur_DemandBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Pur_DemandBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Pur_DemandBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Pur_DemandBindingNavigator.Name = "Tbl_Pur_DemandBindingNavigator"
        Me.Tbl_Pur_DemandBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Pur_DemandBindingNavigator.Size = New System.Drawing.Size(713, 25)
        Me.Tbl_Pur_DemandBindingNavigator.TabIndex = 4
        Me.Tbl_Pur_DemandBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Pur_DemandBindingSource
        '
        Me.Tbl_Pur_DemandBindingSource.DataMember = "tbl_Pur_Demand_Head_tbl_Pur_Demand"
        Me.Tbl_Pur_DemandBindingSource.DataSource = Me.Tbl_Pur_Demand_HeadBindingSource
        '
        'Tbl_Pur_Demand_HeadBindingSource
        '
        Me.Tbl_Pur_Demand_HeadBindingSource.DataMember = "tbl_Pur_Demand_Head"
        Me.Tbl_Pur_Demand_HeadBindingSource.DataSource = Me.DSPO
        '
        'DSPO
        '
        Me.DSPO.DataSetName = "DSPO"
        Me.DSPO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Tbl_Pur_DemandBindingNavigatorSaveItem
        '
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Pur_DemandBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.Name = "Tbl_Pur_DemandBindingNavigatorSaveItem"
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSPO
        '
        'Tbl_Inv_LocalCustBindingSource
        '
        Me.Tbl_Inv_LocalCustBindingSource.DataMember = "tbl_Inv_LocalCust"
        Me.Tbl_Inv_LocalCustBindingSource.DataSource = Me.DSPO
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(DemandStatusLabel)
        Me.Panel1.Controls.Add(VerificationStatusLabel)
        Me.Panel1.Controls.Add(Me.DemandStatusComboBox)
        Me.Panel1.Controls.Add(Me.LocalCustIDComboBox)
        Me.Panel1.Controls.Add(Me.VerificationStatusCheckBox)
        Me.Panel1.Controls.Add(Me.CodeComboBox)
        Me.Panel1.Controls.Add(Me.UOMComboBox)
        Me.Panel1.Controls.Add(GMNoLabel2)
        Me.Panel1.Controls.Add(Me.GMNoLabel3)
        Me.Panel1.Controls.Add(DocIDLabel)
        Me.Panel1.Controls.Add(Me.DocIDTextBox)
        Me.Panel1.Controls.Add(Me.PDDateLabel2)
        Me.Panel1.Controls.Add(NarrationLabel)
        Me.Panel1.Controls.Add(Me.NarrationTextBox)
        Me.Panel1.Controls.Add(LocalCustIDLabel)
        Me.Panel1.Controls.Add(Me.Tbl_Pur_DemandBindingNavigator)
        Me.Panel1.Controls.Add(Me.PDIDLabel1)
        Me.Panel1.Controls.Add(PDIDLabel)
        Me.Panel1.Controls.Add(UOMLabel)
        Me.Panel1.Controls.Add(PDDateLabel)
        Me.Panel1.Controls.Add(CodeLabel)
        Me.Panel1.Controls.Add(Me.PDQtyTextBox)
        Me.Panel1.Controls.Add(PDQtyLabel)
        Me.Panel1.Location = New System.Drawing.Point(38, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 208)
        Me.Panel1.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Active"})
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.Lavender
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "DemandType", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Admin", "Production"})
        Me.ComboBox1.Location = New System.Drawing.Point(355, 118)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'DemandStatusComboBox
        '
        Me.DemandStatusComboBox.AutoCompleteCustomSource.AddRange(New String() {"Active"})
        Me.DemandStatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DemandStatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DemandStatusComboBox.BackColor = System.Drawing.Color.Lavender
        Me.DemandStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "DemandStatus", True))
        Me.DemandStatusComboBox.FormattingEnabled = True
        Me.DemandStatusComboBox.Items.AddRange(New Object() {"Active", "Cancelled"})
        Me.DemandStatusComboBox.Location = New System.Drawing.Point(129, 118)
        Me.DemandStatusComboBox.Name = "DemandStatusComboBox"
        Me.DemandStatusComboBox.Size = New System.Drawing.Size(113, 21)
        Me.DemandStatusComboBox.TabIndex = 8
        '
        'LocalCustIDComboBox
        '
        Me.LocalCustIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LocalCustIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LocalCustIDComboBox.BackColor = System.Drawing.Color.Lavender
        Me.LocalCustIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Pur_DemandBindingSource, "LocalCustID", True))
        Me.LocalCustIDComboBox.DataSource = Me.Tbl_Inv_LocalCustBindingSource
        Me.LocalCustIDComboBox.DisplayMember = "CustName"
        Me.LocalCustIDComboBox.FormattingEnabled = True
        Me.LocalCustIDComboBox.Location = New System.Drawing.Point(580, 65)
        Me.LocalCustIDComboBox.Name = "LocalCustIDComboBox"
        Me.LocalCustIDComboBox.Size = New System.Drawing.Size(114, 21)
        Me.LocalCustIDComboBox.TabIndex = 4
        Me.LocalCustIDComboBox.ValueMember = "LocalCustID"
        '
        'VerificationStatusCheckBox
        '
        Me.VerificationStatusCheckBox.AutoCheck = False
        Me.VerificationStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Pur_DemandBindingSource, "VerificationStatus", True))
        Me.VerificationStatusCheckBox.Location = New System.Drawing.Point(581, 119)
        Me.VerificationStatusCheckBox.Name = "VerificationStatusCheckBox"
        Me.VerificationStatusCheckBox.Size = New System.Drawing.Size(16, 20)
        Me.VerificationStatusCheckBox.TabIndex = 10
        Me.VerificationStatusCheckBox.ThreeState = True
        Me.VerificationStatusCheckBox.UseVisualStyleBackColor = True
        '
        'CodeComboBox
        '
        Me.CodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CodeComboBox.BackColor = System.Drawing.Color.Lavender
        Me.CodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Pur_DemandBindingSource, "Code", True))
        Me.CodeComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.CodeComboBox.DisplayMember = "L4Name"
        Me.CodeComboBox.FormattingEnabled = True
        Me.CodeComboBox.Location = New System.Drawing.Point(129, 65)
        Me.CodeComboBox.Name = "CodeComboBox"
        Me.CodeComboBox.Size = New System.Drawing.Size(330, 21)
        Me.CodeComboBox.TabIndex = 3
        Me.CodeComboBox.ValueMember = "Code"
        '
        'UOMComboBox
        '
        Me.UOMComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.UOMComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UOMComboBox.BackColor = System.Drawing.Color.Lavender
        Me.UOMComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Pur_DemandBindingSource, "UOM", True))
        Me.UOMComboBox.DataSource = Me.Tbl_Pur_UnitOfMeasurementBindingSource
        Me.UOMComboBox.DisplayMember = "UOM"
        Me.UOMComboBox.FormattingEnabled = True
        Me.UOMComboBox.Location = New System.Drawing.Point(355, 91)
        Me.UOMComboBox.Name = "UOMComboBox"
        Me.UOMComboBox.Size = New System.Drawing.Size(104, 21)
        Me.UOMComboBox.TabIndex = 6
        Me.UOMComboBox.ValueMember = "UOM"
        '
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataMember = "tbl_Pur_UnitOfMeasurement"
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DSPO
        '
        'GMNoLabel3
        '
        Me.GMNoLabel3.BackColor = System.Drawing.Color.Lavender
        Me.GMNoLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GMNoLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "GMNo", True))
        Me.GMNoLabel3.Location = New System.Drawing.Point(580, 38)
        Me.GMNoLabel3.Name = "GMNoLabel3"
        Me.GMNoLabel3.Size = New System.Drawing.Size(114, 20)
        Me.GMNoLabel3.TabIndex = 14
        Me.GMNoLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DocIDTextBox
        '
        Me.DocIDTextBox.BackColor = System.Drawing.Color.Lavender
        Me.DocIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "DocID", True))
        Me.DocIDTextBox.Location = New System.Drawing.Point(580, 92)
        Me.DocIDTextBox.Name = "DocIDTextBox"
        Me.DocIDTextBox.Size = New System.Drawing.Size(114, 20)
        Me.DocIDTextBox.TabIndex = 7
        Me.DocIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PDDateLabel2
        '
        Me.PDDateLabel2.BackColor = System.Drawing.Color.Lavender
        Me.PDDateLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PDDateLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "PDDate", True))
        Me.PDDateLabel2.Location = New System.Drawing.Point(326, 38)
        Me.PDDateLabel2.Name = "PDDateLabel2"
        Me.PDDateLabel2.Size = New System.Drawing.Size(133, 20)
        Me.PDDateLabel2.TabIndex = 8
        Me.PDDateLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NarrationTextBox
        '
        Me.NarrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "Narration", True))
        Me.NarrationTextBox.Location = New System.Drawing.Point(129, 144)
        Me.NarrationTextBox.Multiline = True
        Me.NarrationTextBox.Name = "NarrationTextBox"
        Me.NarrationTextBox.Size = New System.Drawing.Size(330, 55)
        Me.NarrationTextBox.TabIndex = 9
        '
        'PDIDLabel1
        '
        Me.PDIDLabel1.BackColor = System.Drawing.Color.Lavender
        Me.PDIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PDIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "PDID", True))
        Me.PDIDLabel1.Location = New System.Drawing.Point(129, 38)
        Me.PDIDLabel1.Name = "PDIDLabel1"
        Me.PDIDLabel1.Size = New System.Drawing.Size(100, 20)
        Me.PDIDLabel1.TabIndex = 6
        Me.PDIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PDQtyTextBox
        '
        Me.PDQtyTextBox.BackColor = System.Drawing.Color.Lavender
        Me.PDQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_DemandBindingSource, "PDQty", True))
        Me.PDQtyTextBox.Location = New System.Drawing.Point(129, 92)
        Me.PDQtyTextBox.Name = "PDQtyTextBox"
        Me.PDQtyTextBox.Size = New System.Drawing.Size(113, 20)
        Me.PDQtyTextBox.TabIndex = 5
        Me.PDQtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lavender
        Me.TextBox1.Location = New System.Drawing.Point(560, 430)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox1.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteCustomSource.AddRange(New String() {"Active"})
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.BackColor = System.Drawing.Color.Lavender
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox2.Location = New System.Drawing.Point(560, 404)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(114, 21)
        Me.ComboBox2.TabIndex = 18
        Me.ComboBox2.Visible = False
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_LocalCustTableAdapter
        '
        Me.Tbl_Inv_LocalCustTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "From Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(222, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "To Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(298, 59)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(461, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Required Fields"
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.GMNoLabel4)
        Me.Panel2.Controls.Add(EnteryDateLabel)
        Me.Panel2.Controls.Add(Me.EnteryDateLabel1)
        Me.Panel2.Controls.Add(GMNoLabel)
        Me.Panel2.Location = New System.Drawing.Point(40, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(389, 67)
        Me.Panel2.TabIndex = 13
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.Tbl_Pur_Demand_HeadBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton, Me.toolStripSeparator})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(387, 25)
        Me.BindingNavigator1.TabIndex = 15
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
        Me.BindingNavigatorAddNewItem1.Visible = False
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
        Me.BindingNavigatorDeleteItem1.Visible = False
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
        Me.SaveToolStripButton.Tag = ""
        Me.SaveToolStripButton.Text = "&Save"
        Me.SaveToolStripButton.ToolTipText = "Add New GD No"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'GMNoLabel4
        '
        Me.GMNoLabel4.BackColor = System.Drawing.Color.Bisque
        Me.GMNoLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GMNoLabel4.ContextMenuStrip = Me.FilterByGDNo
        Me.GMNoLabel4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_Demand_HeadBindingSource, "GMNo", True))
        Me.GMNoLabel4.Location = New System.Drawing.Point(129, 36)
        Me.GMNoLabel4.Name = "GMNoLabel4"
        Me.GMNoLabel4.Size = New System.Drawing.Size(62, 20)
        Me.GMNoLabel4.TabIndex = 14
        Me.GMNoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FilterByGDNo
        '
        Me.FilterByGDNo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterByGDNoToolStripMenuItem, Me.RemoveFilterToolStripMenuItem})
        Me.FilterByGDNo.Name = "FilterByGDNo"
        Me.FilterByGDNo.Size = New System.Drawing.Size(152, 48)
        '
        'FilterByGDNoToolStripMenuItem
        '
        Me.FilterByGDNoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.FilterByGDNoToolStripMenuItem.Name = "FilterByGDNoToolStripMenuItem"
        Me.FilterByGDNoToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.FilterByGDNoToolStripMenuItem.Text = "&Filter By GDNo"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "&Remove Filter"
        '
        'EnteryDateLabel1
        '
        Me.EnteryDateLabel1.BackColor = System.Drawing.Color.White
        Me.EnteryDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EnteryDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pur_Demand_HeadBindingSource, "EnteryDate", True))
        Me.EnteryDateLabel1.Location = New System.Drawing.Point(271, 36)
        Me.EnteryDateLabel1.Name = "EnteryDateLabel1"
        Me.EnteryDateLabel1.Size = New System.Drawing.Size(100, 20)
        Me.EnteryDateLabel1.TabIndex = 4
        Me.EnteryDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Pur_Demand_HeadTableAdapter
        '
        Me.Tbl_Pur_Demand_HeadTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_DemandTableAdapter
        '
        Me.Tbl_Pur_DemandTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Lavender
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(435, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Bisque
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(435, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(461, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Right Click to Filter Record by GD No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(38, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 78)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Following are short keys from the keyboard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1- 'Ctrl +G' for New GDno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2- 'Ctrl" &
    " + S' for Save Demand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3- 'Ctrl + A' for Add New Demand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4- 'Ctrl + D' for Delet" &
    "e Selected Demand"
        '
        'frmAddDemands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(878, 516)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "frmAddDemands"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Demands"
        CType(Me.Tbl_Pur_DemandBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Pur_DemandBindingNavigator.ResumeLayout(False)
        Me.Tbl_Pur_DemandBindingNavigator.PerformLayout()
        CType(Me.Tbl_Pur_DemandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_Demand_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.FilterByGDNo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSPO As FS_ERP_MM.DSPO
    Friend WithEvents Tbl_Pur_DemandBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Pur_DemandBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Inv_LocalCustBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_LocalCustTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Inv_LocalCustTableAdapter
    Friend WithEvents PDIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents PDQtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NarrationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PDDateLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents DocIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Tbl_Pur_Demand_HeadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_Demand_HeadTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_Demand_HeadTableAdapter
    Friend WithEvents Tbl_Pur_DemandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_DemandTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_DemandTableAdapter
    Friend WithEvents GMNoLabel3 As System.Windows.Forms.Label
    Friend WithEvents UOMComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CodeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LocalCustIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EnteryDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents GMNoLabel4 As System.Windows.Forms.Label
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
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VerificationStatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DemandStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FilterByGDNo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FilterByGDNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
