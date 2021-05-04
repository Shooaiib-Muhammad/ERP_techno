<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim QtyLabel As System.Windows.Forms.Label
        Dim NarationLabel As System.Windows.Forms.Label
        Dim LocalCustIDLabel As System.Windows.Forms.Label
        Dim L1NameLabel As System.Windows.Forms.Label
        Dim L2NameLabel As System.Windows.Forms.Label
        Dim L3NameLabel As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim DayNoLabel As System.Windows.Forms.Label
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim TranOutIDLabel As System.Windows.Forms.Label
        Dim ActQtyLabel As System.Windows.Forms.Label
        Dim POLabel As System.Windows.Forms.Label
        Dim UOMLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim PPULabel As System.Windows.Forms.Label
        Dim TranTypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOut))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSOut = New FS_ERP_MM.DSOut()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.CMSDate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMtxtDate = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UnitLabel1 = New System.Windows.Forms.Label()
        Me.TranTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Tran_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrencyTextBox = New System.Windows.Forms.TextBox()
        Me.UOMComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PPUTextBox = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.POComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Pro_POBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalCustIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_LocalCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NarationTextBox = New System.Windows.Forms.TextBox()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.TranOutIDLabel1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSCode = New FS_ERP_MM.DSCode()
        Me.L3NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.L2NameComboBox = New System.Windows.Forms.ComboBox()
        Me.L1NameComboBox = New System.Windows.Forms.ComboBox()
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
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Balance = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSOutTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.Tbl_Inv_Tran_OutTableAdapter = New FS_ERP_MM.DSOutTableAdapters.tbl_Inv_Tran_OutTableAdapter()
        Me.Tbl_Inv_LocalCustTableAdapter = New FS_ERP_MM.DSOutTableAdapters.tbl_Inv_LocalCustTableAdapter()
        Me.View_Inv_TotalInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Inv_TotalInTableAdapter = New FS_ERP_MM.DSOutTableAdapters.View_Inv_TotalInTableAdapter()
        Me.TotalInLabel1 = New System.Windows.Forms.Label()
        Me.View_Inv_TotalOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Inv_TotalOutTableAdapter = New FS_ERP_MM.DSOutTableAdapters.View_Inv_TotalOutTableAdapter()
        Me.TotalOutLabel1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L4BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4TableAdapter1 = New FS_ERP_MM.DSOutTableAdapters.tbl_Inv_L4TableAdapter()
        Me.ActQtyLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Pro_POTableAdapter = New FS_ERP_MM.DSOutTableAdapters.tbl_Pro_POTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNewBal = New System.Windows.Forms.Label()
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.DSOutTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.CPPULabel1 = New System.Windows.Forms.Label()
        Me.CurrencyLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L1TableAdapter = New FS_ERP_MM.DSCodeTableAdapters.tbl_Inv_L1TableAdapter()
        Me.Tbl_Inv_L2TableAdapter = New FS_ERP_MM.DSCodeTableAdapters.tbl_Inv_L2TableAdapter()
        Me.Tbl_Inv_L3TableAdapter = New FS_ERP_MM.DSCodeTableAdapters.tbl_Inv_L3TableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSCodeTableAdapters.tbl_Inv_L4TableAdapter()
        QtyLabel = New System.Windows.Forms.Label()
        NarationLabel = New System.Windows.Forms.Label()
        LocalCustIDLabel = New System.Windows.Forms.Label()
        L1NameLabel = New System.Windows.Forms.Label()
        L2NameLabel = New System.Windows.Forms.Label()
        L3NameLabel = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        DayNoLabel = New System.Windows.Forms.Label()
        DateNameLabel = New System.Windows.Forms.Label()
        TranOutIDLabel = New System.Windows.Forms.Label()
        ActQtyLabel = New System.Windows.Forms.Label()
        POLabel = New System.Windows.Forms.Label()
        UOMLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        PPULabel = New System.Windows.Forms.Label()
        TranTypeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSDate.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_POBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_Inv_TotalInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Inv_TotalOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QtyLabel
        '
        QtyLabel.Location = New System.Drawing.Point(349, 142)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(99, 20)
        QtyLabel.TabIndex = 32
        QtyLabel.Text = "Quantity:"
        QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NarationLabel
        '
        NarationLabel.Location = New System.Drawing.Point(25, 252)
        NarationLabel.Name = "NarationLabel"
        NarationLabel.Size = New System.Drawing.Size(87, 20)
        NarationLabel.TabIndex = 34
        NarationLabel.Text = "Naration:"
        NarationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LocalCustIDLabel
        '
        LocalCustIDLabel.Location = New System.Drawing.Point(349, 192)
        LocalCustIDLabel.Name = "LocalCustIDLabel"
        LocalCustIDLabel.Size = New System.Drawing.Size(99, 20)
        LocalCustIDLabel.TabIndex = 40
        LocalCustIDLabel.Text = "Customer:"
        LocalCustIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L1NameLabel
        '
        L1NameLabel.Location = New System.Drawing.Point(11, 30)
        L1NameLabel.Name = "L1NameLabel"
        L1NameLabel.Size = New System.Drawing.Size(87, 21)
        L1NameLabel.TabIndex = 2
        L1NameLabel.Text = "L1 Name:"
        L1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L2NameLabel
        '
        L2NameLabel.Location = New System.Drawing.Point(11, 57)
        L2NameLabel.Name = "L2NameLabel"
        L2NameLabel.Size = New System.Drawing.Size(87, 21)
        L2NameLabel.TabIndex = 4
        L2NameLabel.Text = "L2 Name:"
        L2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L3NameLabel
        '
        L3NameLabel.Location = New System.Drawing.Point(11, 84)
        L3NameLabel.Name = "L3NameLabel"
        L3NameLabel.Size = New System.Drawing.Size(87, 21)
        L3NameLabel.TabIndex = 6
        L3NameLabel.Text = "L3 Name:"
        L3NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameLabel
        '
        L4NameLabel.Location = New System.Drawing.Point(11, 111)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(87, 21)
        L4NameLabel.TabIndex = 3
        L4NameLabel.Text = "Material:"
        L4NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DayNoLabel
        '
        DayNoLabel.Location = New System.Drawing.Point(50, 35)
        DayNoLabel.Name = "DayNoLabel"
        DayNoLabel.Size = New System.Drawing.Size(62, 20)
        DayNoLabel.TabIndex = 0
        DayNoLabel.Text = "Date No:"
        DayNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(370, 35)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(77, 20)
        DateNameLabel.TabIndex = 2
        DateNameLabel.Text = "Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TranOutIDLabel
        '
        TranOutIDLabel.Location = New System.Drawing.Point(25, 36)
        TranOutIDLabel.Name = "TranOutIDLabel"
        TranOutIDLabel.Size = New System.Drawing.Size(100, 20)
        TranOutIDLabel.TabIndex = 42
        TranOutIDLabel.Text = "Serial No:"
        TranOutIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ActQtyLabel
        '
        ActQtyLabel.Location = New System.Drawing.Point(677, 204)
        ActQtyLabel.Name = "ActQtyLabel"
        ActQtyLabel.Size = New System.Drawing.Size(77, 20)
        ActQtyLabel.TabIndex = 10
        ActQtyLabel.Text = "Actual Qty:"
        ActQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ActQtyLabel.Visible = False
        '
        'POLabel
        '
        POLabel.Location = New System.Drawing.Point(349, 167)
        POLabel.Name = "POLabel"
        POLabel.Size = New System.Drawing.Size(99, 20)
        POLabel.TabIndex = 44
        POLabel.Text = "Page Ref:"
        POLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UOMLabel
        '
        UOMLabel.Location = New System.Drawing.Point(349, 218)
        UOMLabel.Name = "UOMLabel"
        UOMLabel.Size = New System.Drawing.Size(99, 20)
        UOMLabel.TabIndex = 46
        UOMLabel.Text = "UOM:"
        UOMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(349, 90)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(99, 20)
        Label7.TabIndex = 36
        Label7.Text = "Currency:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PPULabel
        '
        PPULabel.Location = New System.Drawing.Point(349, 116)
        PPULabel.Name = "PPULabel"
        PPULabel.Size = New System.Drawing.Size(99, 20)
        PPULabel.TabIndex = 35
        PPULabel.Text = "Price Per Unit:"
        PPULabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranTypeLabel
        '
        TranTypeLabel.Location = New System.Drawing.Point(25, 60)
        TranTypeLabel.Name = "TranTypeLabel"
        TranTypeLabel.Size = New System.Drawing.Size(100, 21)
        TranTypeLabel.TabIndex = 49
        TranTypeLabel.Text = "Transaction Type:"
        TranTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BindingNavigator2)
        Me.Panel1.Controls.Add(DateNameLabel)
        Me.Panel1.Controls.Add(Me.DateNameLabel1)
        Me.Panel1.Controls.Add(DayNoLabel)
        Me.Panel1.Controls.Add(Me.DayNoLabel1)
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 69)
        Me.Panel1.TabIndex = 0
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator2.Size = New System.Drawing.Size(661, 25)
        Me.BindingNavigator2.TabIndex = 4
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSOut
        '
        'DSOut
        '
        Me.DSOut.DataSetName = "DSOut"
        Me.DSOut.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.ContextMenuStrip = Me.CMSDate
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(453, 35)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(119, 20)
        Me.DateNameLabel1.TabIndex = 3
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMSDate
        '
        Me.CMSDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMtxtDate, Me.ToolStripMenuItem2})
        Me.CMSDate.Name = "SupplierContextMenuStrip"
        Me.CMSDate.Size = New System.Drawing.Size(161, 51)
        '
        'CMtxtDate
        '
        Me.CMtxtDate.ForeColor = System.Drawing.Color.Silver
        Me.CMtxtDate.Name = "CMtxtDate"
        Me.CMtxtDate.Size = New System.Drawing.Size(100, 23)
        Me.CMtxtDate.Text = "Enter First Date"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem2.Text = "Remove &Filter"
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.BackColor = System.Drawing.Color.White
        Me.DayNoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.Location = New System.Drawing.Point(118, 35)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DayNoLabel1.TabIndex = 1
        Me.DayNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.UnitLabel1)
        Me.Panel2.Controls.Add(TranTypeLabel)
        Me.Panel2.Controls.Add(Me.TranTypeComboBox)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Controls.Add(Me.CurrencyTextBox)
        Me.Panel2.Controls.Add(UOMLabel)
        Me.Panel2.Controls.Add(PPULabel)
        Me.Panel2.Controls.Add(Me.UOMComboBox)
        Me.Panel2.Controls.Add(Me.PPUTextBox)
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(POLabel)
        Me.Panel2.Controls.Add(Me.POComboBox)
        Me.Panel2.Controls.Add(Me.LocalCustIDComboBox)
        Me.Panel2.Controls.Add(Me.NarationTextBox)
        Me.Panel2.Controls.Add(Me.QtyTextBox)
        Me.Panel2.Controls.Add(Me.CodeTextBox)
        Me.Panel2.Controls.Add(TranOutIDLabel)
        Me.Panel2.Controls.Add(Me.TranOutIDLabel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(QtyLabel)
        Me.Panel2.Controls.Add(NarationLabel)
        Me.Panel2.Controls.Add(LocalCustIDLabel)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Location = New System.Drawing.Point(12, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(664, 294)
        Me.Panel2.TabIndex = 1
        '
        'UnitLabel1
        '
        Me.UnitLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UnitLabel1.Location = New System.Drawing.Point(337, 33)
        Me.UnitLabel1.Name = "UnitLabel1"
        Me.UnitLabel1.Size = New System.Drawing.Size(78, 10)
        Me.UnitLabel1.TabIndex = 50
        '
        'TranTypeComboBox
        '
        Me.TranTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TranTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TranTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranType", True))
        Me.TranTypeComboBox.FormattingEnabled = True
        Me.TranTypeComboBox.Items.AddRange(New Object() {"MIR", "MTP", "MOGP", "MRGP"})
        Me.TranTypeComboBox.Location = New System.Drawing.Point(131, 60)
        Me.TranTypeComboBox.Name = "TranTypeComboBox"
        Me.TranTypeComboBox.Size = New System.Drawing.Size(116, 21)
        Me.TranTypeComboBox.TabIndex = 48
        '
        'Tbl_Inv_Tran_OutBindingSource
        '
        Me.Tbl_Inv_Tran_OutBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Inv_Tran_Out"
        Me.Tbl_Inv_Tran_OutBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'CurrencyTextBox
        '
        Me.CurrencyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Currency", True))
        Me.CurrencyTextBox.Location = New System.Drawing.Point(455, 90)
        Me.CurrencyTextBox.Name = "CurrencyTextBox"
        Me.CurrencyTextBox.Size = New System.Drawing.Size(117, 20)
        Me.CurrencyTextBox.TabIndex = 37
        Me.CurrencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UOMComboBox
        '
        Me.UOMComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "UOM", True))
        Me.UOMComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "UOM", True))
        Me.UOMComboBox.DataSource = Me.Tbl_Pur_UnitOfMeasurementBindingSource
        Me.UOMComboBox.DisplayMember = "UOM"
        Me.UOMComboBox.FormattingEnabled = True
        Me.UOMComboBox.Location = New System.Drawing.Point(455, 217)
        Me.UOMComboBox.Name = "UOMComboBox"
        Me.UOMComboBox.Size = New System.Drawing.Size(119, 21)
        Me.UOMComboBox.TabIndex = 47
        Me.UOMComboBox.ValueMember = "UOM"
        '
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataMember = "tbl_Pur_UnitOfMeasurement"
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DSOut
        '
        'PPUTextBox
        '
        Me.PPUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "PPU", True))
        Me.PPUTextBox.Location = New System.Drawing.Point(455, 116)
        Me.PPUTextBox.Name = "PPUTextBox"
        Me.PPUTextBox.Size = New System.Drawing.Size(117, 20)
        Me.PPUTextBox.TabIndex = 34
        Me.PPUTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PPUTextBox.WordWrap = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(443, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton2.TabIndex = 46
        Me.RadioButton2.Text = "Auto Save"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(347, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 45
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Manuall Save"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'POComboBox
        '
        Me.POComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.POComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "PO", True))
        Me.POComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "PO", True))
        Me.POComboBox.DataSource = Me.Tbl_Pro_POBindingSource
        Me.POComboBox.DisplayMember = "PO"
        Me.POComboBox.FormattingEnabled = True
        Me.POComboBox.Location = New System.Drawing.Point(455, 166)
        Me.POComboBox.Name = "POComboBox"
        Me.POComboBox.Size = New System.Drawing.Size(117, 21)
        Me.POComboBox.TabIndex = 2
        Me.POComboBox.ValueMember = "PO"
        '
        'Tbl_Pro_POBindingSource
        '
        Me.Tbl_Pro_POBindingSource.DataMember = "tbl_Pro_PO"
        Me.Tbl_Pro_POBindingSource.DataSource = Me.DSOut
        '
        'LocalCustIDComboBox
        '
        Me.LocalCustIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LocalCustIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LocalCustIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "LocalCustID", True))
        Me.LocalCustIDComboBox.DataSource = Me.Tbl_Inv_LocalCustBindingSource
        Me.LocalCustIDComboBox.DisplayMember = "CustName"
        Me.LocalCustIDComboBox.FormattingEnabled = True
        Me.LocalCustIDComboBox.Location = New System.Drawing.Point(455, 191)
        Me.LocalCustIDComboBox.Name = "LocalCustIDComboBox"
        Me.LocalCustIDComboBox.Size = New System.Drawing.Size(187, 21)
        Me.LocalCustIDComboBox.TabIndex = 3
        Me.LocalCustIDComboBox.ValueMember = "LocalCustID"
        '
        'Tbl_Inv_LocalCustBindingSource
        '
        Me.Tbl_Inv_LocalCustBindingSource.DataMember = "tbl_Inv_LocalCust"
        Me.Tbl_Inv_LocalCustBindingSource.DataSource = Me.DSOut
        '
        'NarationTextBox
        '
        Me.NarationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Naration", True))
        Me.NarationTextBox.Location = New System.Drawing.Point(118, 252)
        Me.NarationTextBox.Name = "NarationTextBox"
        Me.NarationTextBox.Size = New System.Drawing.Size(522, 20)
        Me.NarationTextBox.TabIndex = 4
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(455, 142)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(117, 20)
        Me.QtyTextBox.TabIndex = 1
        Me.QtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CodeTextBox
        '
        Me.CodeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Code", True))
        Me.CodeTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CodeTextBox.Location = New System.Drawing.Point(12, 68)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(100, 13)
        Me.CodeTextBox.TabIndex = 44
        Me.CodeTextBox.TabStop = False
        '
        'TranOutIDLabel1
        '
        Me.TranOutIDLabel1.BackColor = System.Drawing.Color.White
        Me.TranOutIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TranOutIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranOutID", True))
        Me.TranOutIDLabel1.Location = New System.Drawing.Point(131, 36)
        Me.TranOutIDLabel1.Name = "TranOutIDLabel1"
        Me.TranOutIDLabel1.Size = New System.Drawing.Size(116, 20)
        Me.TranOutIDLabel1.TabIndex = 43
        Me.TranOutIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.L4NameComboBox)
        Me.Panel3.Controls.Add(L4NameLabel)
        Me.Panel3.Controls.Add(Me.L3NameComboBox)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(L1NameLabel)
        Me.Panel3.Controls.Add(Me.L2NameComboBox)
        Me.Panel3.Controls.Add(L3NameLabel)
        Me.Panel3.Controls.Add(L2NameLabel)
        Me.Panel3.Controls.Add(Me.L1NameComboBox)
        Me.Panel3.Location = New System.Drawing.Point(13, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(326, 152)
        Me.Panel3.TabIndex = 0
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "Code", True))
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(104, 111)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(204, 21)
        Me.L4NameComboBox.TabIndex = 3
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L3_tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.Tbl_Inv_L3BindingSource
        '
        'Tbl_Inv_L3BindingSource
        '
        Me.Tbl_Inv_L3BindingSource.DataMember = "tbl_Inv_L2_tbl_Inv_L3"
        Me.Tbl_Inv_L3BindingSource.DataSource = Me.Tbl_Inv_L2BindingSource
        '
        'Tbl_Inv_L2BindingSource
        '
        Me.Tbl_Inv_L2BindingSource.DataMember = "tbl_Inv_L1_tbl_Inv_L2"
        Me.Tbl_Inv_L2BindingSource.DataSource = Me.Tbl_Inv_L1BindingSource
        '
        'Tbl_Inv_L1BindingSource
        '
        Me.Tbl_Inv_L1BindingSource.DataMember = "tbl_Inv_L1"
        Me.Tbl_Inv_L1BindingSource.DataSource = Me.DSCode
        '
        'DSCode
        '
        Me.DSCode.DataSetName = "DSCode"
        Me.DSCode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'L3NameComboBox
        '
        Me.L3NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L3NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L3NameComboBox.DataSource = Me.Tbl_Inv_L3BindingSource
        Me.L3NameComboBox.DisplayMember = "L3Name"
        Me.L3NameComboBox.FormattingEnabled = True
        Me.L3NameComboBox.Location = New System.Drawing.Point(104, 84)
        Me.L3NameComboBox.Name = "L3NameComboBox"
        Me.L3NameComboBox.Size = New System.Drawing.Size(204, 21)
        Me.L3NameComboBox.TabIndex = 2
        Me.L3NameComboBox.ValueMember = "Layer3ID"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Select Material"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L2NameComboBox
        '
        Me.L2NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L2NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L2NameComboBox.DataSource = Me.Tbl_Inv_L2BindingSource
        Me.L2NameComboBox.DisplayMember = "L2Name"
        Me.L2NameComboBox.FormattingEnabled = True
        Me.L2NameComboBox.Location = New System.Drawing.Point(104, 57)
        Me.L2NameComboBox.Name = "L2NameComboBox"
        Me.L2NameComboBox.Size = New System.Drawing.Size(204, 21)
        Me.L2NameComboBox.TabIndex = 1
        Me.L2NameComboBox.ValueMember = "Layer2ID"
        '
        'L1NameComboBox
        '
        Me.L1NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L1NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L1NameComboBox.DataSource = Me.Tbl_Inv_L1BindingSource
        Me.L1NameComboBox.DisplayMember = "L1Name"
        Me.L1NameComboBox.FormattingEnabled = True
        Me.L1NameComboBox.Location = New System.Drawing.Point(104, 30)
        Me.L1NameComboBox.Name = "L1NameComboBox"
        Me.L1NameComboBox.Size = New System.Drawing.Size(204, 21)
        Me.L1NameComboBox.TabIndex = 0
        Me.L1NameComboBox.ValueMember = "Layer1ID"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_Tran_OutBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton, Me.ToolStripButton3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(662, 25)
        Me.BindingNavigator1.TabIndex = 22
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
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Undo"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(677, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Balance:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Balance
        '
        Me.Balance.BackColor = System.Drawing.Color.White
        Me.Balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Balance.Location = New System.Drawing.Point(760, 169)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(100, 20)
        Me.Balance.TabIndex = 8
        Me.Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(888, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Material Transections Issued"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_OutTableAdapter
        '
        Me.Tbl_Inv_Tran_OutTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_LocalCustTableAdapter
        '
        Me.Tbl_Inv_LocalCustTableAdapter.ClearBeforeFill = True
        '
        'View_Inv_TotalInBindingSource
        '
        Me.View_Inv_TotalInBindingSource.DataMember = "View_Inv_TotalIn"
        Me.View_Inv_TotalInBindingSource.DataSource = Me.DSOut
        '
        'View_Inv_TotalInTableAdapter
        '
        Me.View_Inv_TotalInTableAdapter.ClearBeforeFill = True
        '
        'TotalInLabel1
        '
        Me.TotalInLabel1.BackColor = System.Drawing.Color.White
        Me.TotalInLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalInLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Inv_TotalInBindingSource, "TotalIn", True))
        Me.TotalInLabel1.ForeColor = System.Drawing.Color.Black
        Me.TotalInLabel1.Location = New System.Drawing.Point(760, 120)
        Me.TotalInLabel1.Name = "TotalInLabel1"
        Me.TotalInLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TotalInLabel1.TabIndex = 5
        Me.TotalInLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Inv_TotalOutBindingSource
        '
        Me.View_Inv_TotalOutBindingSource.DataMember = "View_Inv_TotalOut"
        Me.View_Inv_TotalOutBindingSource.DataSource = Me.DSOut
        '
        'View_Inv_TotalOutTableAdapter
        '
        Me.View_Inv_TotalOutTableAdapter.ClearBeforeFill = True
        '
        'TotalOutLabel1
        '
        Me.TotalOutLabel1.BackColor = System.Drawing.Color.White
        Me.TotalOutLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalOutLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Inv_TotalOutBindingSource, "TotalOut", True))
        Me.TotalOutLabel1.ForeColor = System.Drawing.Color.Black
        Me.TotalOutLabel1.Location = New System.Drawing.Point(760, 144)
        Me.TotalOutLabel1.Name = "TotalOutLabel1"
        Me.TotalOutLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TotalOutLabel1.TabIndex = 7
        Me.TotalOutLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(677, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total In:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(677, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Out:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_Inv_L4BindingSource1
        '
        Me.Tbl_Inv_L4BindingSource1.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource1.DataSource = Me.DSOut
        '
        'Tbl_Inv_L4TableAdapter1
        '
        Me.Tbl_Inv_L4TableAdapter1.ClearBeforeFill = True
        '
        'ActQtyLabel1
        '
        Me.ActQtyLabel1.BackColor = System.Drawing.Color.White
        Me.ActQtyLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ActQtyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource1, "ActQty", True))
        Me.ActQtyLabel1.Location = New System.Drawing.Point(760, 204)
        Me.ActQtyLabel1.Name = "ActQtyLabel1"
        Me.ActQtyLabel1.Size = New System.Drawing.Size(100, 20)
        Me.ActQtyLabel1.TabIndex = 11
        Me.ActQtyLabel1.Visible = False
        '
        'Tbl_Pro_POTableAdapter
        '
        Me.Tbl_Pro_POTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(677, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Live Balance:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNewBal
        '
        Me.lblNewBal.BackColor = System.Drawing.Color.White
        Me.lblNewBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewBal.Location = New System.Drawing.Point(760, 243)
        Me.lblNewBal.Name = "lblNewBal"
        Me.lblNewBal.Size = New System.Drawing.Size(100, 20)
        Me.lblNewBal.TabIndex = 13
        Me.lblNewBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
        '
        'CPPULabel1
        '
        Me.CPPULabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource1, "CPPU", True))
        Me.CPPULabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.Location = New System.Drawing.Point(760, 287)
        Me.CPPULabel1.Name = "CPPULabel1"
        Me.CPPULabel1.Size = New System.Drawing.Size(100, 10)
        Me.CPPULabel1.TabIndex = 14
        '
        'CurrencyLabel1
        '
        Me.CurrencyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource1, "Currency", True))
        Me.CurrencyLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.Location = New System.Drawing.Point(776, 318)
        Me.CurrencyLabel1.Name = "CurrencyLabel1"
        Me.CurrencyLabel1.Size = New System.Drawing.Size(100, 10)
        Me.CurrencyLabel1.TabIndex = 16
        '
        'Tbl_Inv_L1TableAdapter
        '
        Me.Tbl_Inv_L1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L2TableAdapter
        '
        Me.Tbl_Inv_L2TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L3TableAdapter
        '
        Me.Tbl_Inv_L3TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'frmOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(888, 446)
        Me.Controls.Add(Me.CurrencyLabel1)
        Me.Controls.Add(Me.CPPULabel1)
        Me.Controls.Add(Me.lblNewBal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ActQtyLabel)
        Me.Controls.Add(Me.ActQtyLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.TotalOutLabel1)
        Me.Controls.Add(Me.TotalInLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Outward"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSDate.ResumeLayout(False)
        Me.CMSDate.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_POBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_Inv_TotalInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Inv_TotalOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DSOut As FS_ERP_MM.DSOut
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents L1NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents L2NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents L3NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSOutTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_Tran_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_OutTableAdapter As FS_ERP_MM.DSOutTableAdapters.tbl_Inv_Tran_OutTableAdapter
    Friend WithEvents NarationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TranOutIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_LocalCustBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_LocalCustTableAdapter As FS_ERP_MM.DSOutTableAdapters.tbl_Inv_LocalCustTableAdapter
    Friend WithEvents LocalCustIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DSCode As FS_ERP_MM.DSCode
    Friend WithEvents View_Inv_TotalInBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Inv_TotalInTableAdapter As FS_ERP_MM.DSOutTableAdapters.View_Inv_TotalInTableAdapter
    Friend WithEvents TotalInLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Inv_TotalOutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Inv_TotalOutTableAdapter As FS_ERP_MM.DSOutTableAdapters.View_Inv_TotalOutTableAdapter
    Friend WithEvents TotalOutLabel1 As System.Windows.Forms.Label
    Friend WithEvents Balance As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_L4BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter1 As FS_ERP_MM.DSOutTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents ActQtyLabel1 As System.Windows.Forms.Label
    Friend WithEvents POComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Pro_POBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pro_POTableAdapter As FS_ERP_MM.DSOutTableAdapters.tbl_Pro_POTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNewBal As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents UOMComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As FS_ERP_MM.DSOutTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents CurrencyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PPUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPPULabel1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TranTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CMSDate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMtxtDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_L1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L1TableAdapter As FS_ERP_MM.DSCodeTableAdapters.tbl_Inv_L1TableAdapter
    Friend WithEvents Tbl_Inv_L2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L2TableAdapter As FS_ERP_MM.DSCodeTableAdapters.tbl_Inv_L2TableAdapter
    Friend WithEvents Tbl_Inv_L3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L3TableAdapter As FS_ERP_MM.DSCodeTableAdapters.tbl_Inv_L3TableAdapter
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSCodeTableAdapters.tbl_Inv_L4TableAdapter
End Class
