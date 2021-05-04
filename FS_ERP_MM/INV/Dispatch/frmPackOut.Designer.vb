<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackOut
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
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackOut))
        Me.TranTypeLabel = New System.Windows.Forms.Label()
        Me.TranDocNoLabel = New System.Windows.Forms.Label()
        Me.POLabel = New System.Windows.Forms.Label()
        Me.LocalCustIDLabel = New System.Windows.Forms.Label()
        Me.CodeLabel = New System.Windows.Forms.Label()
        Me.CompanyIDLabel = New System.Windows.Forms.Label()
        Me.QtyLabel = New System.Windows.Forms.Label()
        Me.NarationLabel = New System.Windows.Forms.Label()
        Me.ExtCustIDLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Inv_Tran_DateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPackTranOut = New FS_ERP_MM.DSPackTranOut()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UOMLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Tran_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BalanceLabel1 = New System.Windows.Forms.Label()
        Me.Proc_MM_Inv_BalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExtCustIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_ExternalCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NarationTextBox = New System.Windows.Forms.TextBox()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_CompaniesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodeComboBox = New System.Windows.Forms.ComboBox()
        Me.LocalCustIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_LocalCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POTextBox = New System.Windows.Forms.TextBox()
        Me.TranDocNoTextBox = New System.Windows.Forms.TextBox()
        Me.TranTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.Tbl_Inv_Tran_OutTableAdapter = New FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_Tran_OutTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_CompaniesTableAdapter = New FS_ERP_MM.DSPackTranOutTableAdapters.tbl_CompaniesTableAdapter()
        Me.Tbl_Inv_ExternalCustTableAdapter = New FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_ExternalCustTableAdapter()
        Me.Tbl_Inv_LocalCustTableAdapter = New FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_LocalCustTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CurrencyLabel1 = New System.Windows.Forms.Label()
        Me.CPPULabel1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Proc_MM_Inv_BalTableAdapter = New FS_ERP_MM.DSPackTranOutTableAdapters.Proc_MM_Inv_BalTableAdapter()
        Me.UnitLabel1 = New System.Windows.Forms.Label()
        Me.PPULabel1 = New System.Windows.Forms.Label()
        Me.CurrencyLabel2 = New System.Windows.Forms.Label()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        DateNameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPackTranOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Proc_MM_Inv_BalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Inv_ExternalCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_CompaniesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(30, 40)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(98, 20)
        DateNameLabel.TabIndex = 0
        DateNameLabel.Text = "Current Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranTypeLabel
        '
        Me.TranTypeLabel.Location = New System.Drawing.Point(27, 40)
        Me.TranTypeLabel.Name = "TranTypeLabel"
        Me.TranTypeLabel.Size = New System.Drawing.Size(100, 20)
        Me.TranTypeLabel.TabIndex = 0
        Me.TranTypeLabel.Text = "Tran Type:"
        Me.TranTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranDocNoLabel
        '
        Me.TranDocNoLabel.Location = New System.Drawing.Point(27, 66)
        Me.TranDocNoLabel.Name = "TranDocNoLabel"
        Me.TranDocNoLabel.Size = New System.Drawing.Size(100, 20)
        Me.TranDocNoLabel.TabIndex = 2
        Me.TranDocNoLabel.Text = "Tran Doc No:"
        Me.TranDocNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POLabel
        '
        Me.POLabel.Location = New System.Drawing.Point(358, 40)
        Me.POLabel.Name = "POLabel"
        Me.POLabel.Size = New System.Drawing.Size(100, 20)
        Me.POLabel.TabIndex = 4
        Me.POLabel.Text = "PO:"
        Me.POLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LocalCustIDLabel
        '
        Me.LocalCustIDLabel.Location = New System.Drawing.Point(358, 66)
        Me.LocalCustIDLabel.Name = "LocalCustIDLabel"
        Me.LocalCustIDLabel.Size = New System.Drawing.Size(100, 20)
        Me.LocalCustIDLabel.TabIndex = 6
        Me.LocalCustIDLabel.Text = "Department:"
        Me.LocalCustIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodeLabel
        '
        Me.CodeLabel.Location = New System.Drawing.Point(27, 93)
        Me.CodeLabel.Name = "CodeLabel"
        Me.CodeLabel.Size = New System.Drawing.Size(100, 20)
        Me.CodeLabel.TabIndex = 8
        Me.CodeLabel.Text = "Material:"
        Me.CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyIDLabel
        '
        Me.CompanyIDLabel.Location = New System.Drawing.Point(358, 93)
        Me.CompanyIDLabel.Name = "CompanyIDLabel"
        Me.CompanyIDLabel.Size = New System.Drawing.Size(100, 20)
        Me.CompanyIDLabel.TabIndex = 10
        Me.CompanyIDLabel.Text = "Company:"
        Me.CompanyIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QtyLabel
        '
        Me.QtyLabel.Location = New System.Drawing.Point(27, 119)
        Me.QtyLabel.Name = "QtyLabel"
        Me.QtyLabel.Size = New System.Drawing.Size(100, 20)
        Me.QtyLabel.TabIndex = 12
        Me.QtyLabel.Text = "Quantity:"
        Me.QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NarationLabel
        '
        Me.NarationLabel.Location = New System.Drawing.Point(27, 145)
        Me.NarationLabel.Name = "NarationLabel"
        Me.NarationLabel.Size = New System.Drawing.Size(100, 20)
        Me.NarationLabel.TabIndex = 14
        Me.NarationLabel.Text = "Naration:"
        Me.NarationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExtCustIDLabel
        '
        Me.ExtCustIDLabel.Location = New System.Drawing.Point(358, 119)
        Me.ExtCustIDLabel.Name = "ExtCustIDLabel"
        Me.ExtCustIDLabel.Size = New System.Drawing.Size(100, 20)
        Me.ExtCustIDLabel.TabIndex = 16
        Me.ExtCustIDLabel.Text = "External Customer:"
        Me.ExtCustIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Inv_Tran_DateBindingNavigator)
        Me.Panel1.Controls.Add(DateNameLabel)
        Me.Panel1.Controls.Add(Me.DateNameLabel1)
        Me.Panel1.Location = New System.Drawing.Point(31, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 75)
        Me.Panel1.TabIndex = 0
        '
        'Tbl_Inv_Tran_DateBindingNavigator
        '
        Me.Tbl_Inv_Tran_DateBindingNavigator.AddNewItem = Nothing
        Me.Tbl_Inv_Tran_DateBindingNavigator.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.Tbl_Inv_Tran_DateBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Inv_Tran_DateBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Inv_Tran_DateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Tbl_Inv_Tran_DateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Inv_Tran_DateBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Inv_Tran_DateBindingNavigator.Name = "Tbl_Inv_Tran_DateBindingNavigator"
        Me.Tbl_Inv_Tran_DateBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Inv_Tran_DateBindingNavigator.Size = New System.Drawing.Size(457, 25)
        Me.Tbl_Inv_Tran_DateBindingNavigator.TabIndex = 3
        Me.Tbl_Inv_Tran_DateBindingNavigator.Text = "BindingNavigator1"
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSPackTranOut
        '
        'DSPackTranOut
        '
        Me.DSPackTranOut.DataSetName = "DSPackTranOut"
        Me.DSPackTranOut.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(134, 40)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(112, 20)
        Me.DateNameLabel1.TabIndex = 1
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.UOMLabel1)
        Me.Panel2.Controls.Add(Me.BalanceLabel1)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.ExtCustIDLabel)
        Me.Panel2.Controls.Add(Me.ExtCustIDComboBox)
        Me.Panel2.Controls.Add(Me.NarationLabel)
        Me.Panel2.Controls.Add(Me.NarationTextBox)
        Me.Panel2.Controls.Add(Me.QtyLabel)
        Me.Panel2.Controls.Add(Me.QtyTextBox)
        Me.Panel2.Controls.Add(Me.CompanyIDLabel)
        Me.Panel2.Controls.Add(Me.CompanyIDComboBox)
        Me.Panel2.Controls.Add(Me.CodeLabel)
        Me.Panel2.Controls.Add(Me.CodeComboBox)
        Me.Panel2.Controls.Add(Me.LocalCustIDLabel)
        Me.Panel2.Controls.Add(Me.LocalCustIDComboBox)
        Me.Panel2.Controls.Add(Me.POLabel)
        Me.Panel2.Controls.Add(Me.POTextBox)
        Me.Panel2.Controls.Add(Me.TranDocNoLabel)
        Me.Panel2.Controls.Add(Me.TranDocNoTextBox)
        Me.Panel2.Controls.Add(Me.TranTypeLabel)
        Me.Panel2.Controls.Add(Me.TranTypeComboBox)
        Me.Panel2.Location = New System.Drawing.Point(31, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(729, 194)
        Me.Panel2.TabIndex = 1
        '
        'UOMLabel1
        '
        Me.UOMLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "UOM", True))
        Me.UOMLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UOMLabel1.Location = New System.Drawing.Point(623, 122)
        Me.UOMLabel1.Name = "UOMLabel1"
        Me.UOMLabel1.Size = New System.Drawing.Size(41, 17)
        Me.UOMLabel1.TabIndex = 25
        '
        'Tbl_Inv_Tran_OutBindingSource
        '
        Me.Tbl_Inv_Tran_OutBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Inv_Tran_Out"
        Me.Tbl_Inv_Tran_OutBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'BalanceLabel1
        '
        Me.BalanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Proc_MM_Inv_BalBindingSource, "Balance", True))
        Me.BalanceLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BalanceLabel1.Location = New System.Drawing.Point(580, 39)
        Me.BalanceLabel1.Name = "BalanceLabel1"
        Me.BalanceLabel1.Size = New System.Drawing.Size(58, 21)
        Me.BalanceLabel1.TabIndex = 24
        '
        'Proc_MM_Inv_BalBindingSource
        '
        Me.Proc_MM_Inv_BalBindingSource.DataMember = "tbl_Inv_L4_Proc_MM_Inv_Bal"
        Me.Proc_MM_Inv_BalBindingSource.DataSource = Me.Tbl_Inv_L4BindingSource
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSPackTranOut
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_Tran_OutBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(727, 25)
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
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'ExtCustIDComboBox
        '
        Me.ExtCustIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ExtCustIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ExtCustIDComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ExtCustIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "ExtCustID", True))
        Me.ExtCustIDComboBox.DataSource = Me.Tbl_Inv_ExternalCustBindingSource
        Me.ExtCustIDComboBox.DisplayMember = "ExtCustName"
        Me.ExtCustIDComboBox.FormattingEnabled = True
        Me.ExtCustIDComboBox.Location = New System.Drawing.Point(464, 118)
        Me.ExtCustIDComboBox.Name = "ExtCustIDComboBox"
        Me.ExtCustIDComboBox.Size = New System.Drawing.Size(153, 21)
        Me.ExtCustIDComboBox.TabIndex = 17
        Me.ExtCustIDComboBox.ValueMember = "ExtCustID"
        '
        'Tbl_Inv_ExternalCustBindingSource
        '
        Me.Tbl_Inv_ExternalCustBindingSource.DataMember = "tbl_Inv_ExternalCust"
        Me.Tbl_Inv_ExternalCustBindingSource.DataSource = Me.DSPackTranOut
        '
        'NarationTextBox
        '
        Me.NarationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "ExtCustID", True))
        Me.NarationTextBox.Location = New System.Drawing.Point(133, 145)
        Me.NarationTextBox.Name = "NarationTextBox"
        Me.NarationTextBox.Size = New System.Drawing.Size(484, 20)
        Me.NarationTextBox.TabIndex = 15
        '
        'QtyTextBox
        '
        Me.QtyTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(133, 119)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTextBox.TabIndex = 13
        '
        'CompanyIDComboBox
        '
        Me.CompanyIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyIDComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CompanyIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "CompanyID", True))
        Me.CompanyIDComboBox.DataSource = Me.Tbl_CompaniesBindingSource
        Me.CompanyIDComboBox.DisplayMember = "CompanyName"
        Me.CompanyIDComboBox.FormattingEnabled = True
        Me.CompanyIDComboBox.Location = New System.Drawing.Point(464, 92)
        Me.CompanyIDComboBox.Name = "CompanyIDComboBox"
        Me.CompanyIDComboBox.Size = New System.Drawing.Size(153, 21)
        Me.CompanyIDComboBox.TabIndex = 11
        Me.CompanyIDComboBox.ValueMember = "CompanyID"
        '
        'Tbl_CompaniesBindingSource
        '
        Me.Tbl_CompaniesBindingSource.DataMember = "tbl_Companies"
        Me.Tbl_CompaniesBindingSource.DataSource = Me.DSPackTranOut
        '
        'CodeComboBox
        '
        Me.CodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CodeComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "Code", True))
        Me.CodeComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.CodeComboBox.DisplayMember = "L4Name"
        Me.CodeComboBox.FormattingEnabled = True
        Me.CodeComboBox.Location = New System.Drawing.Point(133, 92)
        Me.CodeComboBox.Name = "CodeComboBox"
        Me.CodeComboBox.Size = New System.Drawing.Size(219, 21)
        Me.CodeComboBox.TabIndex = 9
        Me.CodeComboBox.ValueMember = "Code"
        '
        'LocalCustIDComboBox
        '
        Me.LocalCustIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LocalCustIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LocalCustIDComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LocalCustIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "LocalCustID", True))
        Me.LocalCustIDComboBox.DataSource = Me.Tbl_Inv_LocalCustBindingSource
        Me.LocalCustIDComboBox.DisplayMember = "CustName"
        Me.LocalCustIDComboBox.FormattingEnabled = True
        Me.LocalCustIDComboBox.Location = New System.Drawing.Point(464, 65)
        Me.LocalCustIDComboBox.Name = "LocalCustIDComboBox"
        Me.LocalCustIDComboBox.Size = New System.Drawing.Size(153, 21)
        Me.LocalCustIDComboBox.TabIndex = 7
        Me.LocalCustIDComboBox.ValueMember = "LocalCustID"
        '
        'Tbl_Inv_LocalCustBindingSource
        '
        Me.Tbl_Inv_LocalCustBindingSource.DataMember = "tbl_Inv_LocalCust"
        Me.Tbl_Inv_LocalCustBindingSource.DataSource = Me.DSPackTranOut
        '
        'POTextBox
        '
        Me.POTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "PO", True))
        Me.POTextBox.Location = New System.Drawing.Point(464, 40)
        Me.POTextBox.Name = "POTextBox"
        Me.POTextBox.Size = New System.Drawing.Size(88, 20)
        Me.POTextBox.TabIndex = 5
        '
        'TranDocNoTextBox
        '
        Me.TranDocNoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TranDocNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranDocNo", True))
        Me.TranDocNoTextBox.Location = New System.Drawing.Point(133, 66)
        Me.TranDocNoTextBox.Name = "TranDocNoTextBox"
        Me.TranDocNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TranDocNoTextBox.TabIndex = 3
        '
        'TranTypeComboBox
        '
        Me.TranTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TranTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TranTypeComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TranTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranType", True))
        Me.TranTypeComboBox.FormattingEnabled = True
        Me.TranTypeComboBox.Items.AddRange(New Object() {"MIR", "MTP", "MOGP"})
        Me.TranTypeComboBox.Location = New System.Drawing.Point(133, 39)
        Me.TranTypeComboBox.Name = "TranTypeComboBox"
        Me.TranTypeComboBox.Size = New System.Drawing.Size(100, 21)
        Me.TranTypeComboBox.TabIndex = 1
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_OutTableAdapter
        '
        Me.Tbl_Inv_Tran_OutTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(844, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Transaction Outward"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_CompaniesTableAdapter
        '
        Me.Tbl_CompaniesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_ExternalCustTableAdapter
        '
        Me.Tbl_Inv_ExternalCustTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_LocalCustTableAdapter
        '
        Me.Tbl_Inv_LocalCustTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(493, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Press Ctrl+Z to Cancel Record"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Press Ctrl+S to Save Record"
        '
        'CurrencyLabel1
        '
        Me.CurrencyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource, "Currency", True))
        Me.CurrencyLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.Location = New System.Drawing.Point(509, 60)
        Me.CurrencyLabel1.Name = "CurrencyLabel1"
        Me.CurrencyLabel1.Size = New System.Drawing.Size(47, 10)
        Me.CurrencyLabel1.TabIndex = 6
        '
        'CPPULabel1
        '
        Me.CPPULabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource, "CPPU", True))
        Me.CPPULabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.Location = New System.Drawing.Point(553, 60)
        Me.CPPULabel1.Name = "CPPULabel1"
        Me.CPPULabel1.Size = New System.Drawing.Size(59, 12)
        Me.CPPULabel1.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(496, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Press Ctrl+A to add new Record"
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Proc_MM_Inv_BalTableAdapter
        '
        Me.Proc_MM_Inv_BalTableAdapter.ClearBeforeFill = True
        '
        'UnitLabel1
        '
        Me.UnitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource, "Unit", True))
        Me.UnitLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UnitLabel1.Location = New System.Drawing.Point(618, 63)
        Me.UnitLabel1.Name = "UnitLabel1"
        Me.UnitLabel1.Size = New System.Drawing.Size(100, 13)
        Me.UnitLabel1.TabIndex = 13
        '
        'PPULabel1
        '
        Me.PPULabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "PPU", True))
        Me.PPULabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PPULabel1.Location = New System.Drawing.Point(685, 83)
        Me.PPULabel1.Name = "PPULabel1"
        Me.PPULabel1.Size = New System.Drawing.Size(41, 23)
        Me.PPULabel1.TabIndex = 14
        '
        'CurrencyLabel2
        '
        Me.CurrencyLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Currency", True))
        Me.CurrencyLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel2.Location = New System.Drawing.Point(685, 107)
        Me.CurrencyLabel2.Name = "CurrencyLabel2"
        Me.CurrencyLabel2.Size = New System.Drawing.Size(41, 23)
        Me.CurrencyLabel2.TabIndex = 15
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.Location = New System.Drawing.Point(512, 60)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(72, 13)
        Me.DayNoLabel1.TabIndex = 16
        '
        'frmPackOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 392)
        Me.Controls.Add(Me.DayNoLabel1)
        Me.Controls.Add(Me.CurrencyLabel2)
        Me.Controls.Add(Me.PPULabel1)
        Me.Controls.Add(Me.UnitLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CPPULabel1)
        Me.Controls.Add(Me.CurrencyLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPackOut"
        Me.Text = "Transaction Outward"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.ResumeLayout(False)
        Me.Tbl_Inv_Tran_DateBindingNavigator.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPackTranOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Proc_MM_Inv_BalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Inv_ExternalCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_CompaniesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DSPackTranOut As FS_ERP_MM.DSPackTranOut
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents Tbl_Inv_Tran_DateBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_Tran_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_OutTableAdapter As FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_Tran_OutTableAdapter
    Friend WithEvents TranTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TranDocNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents POTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalCustIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CodeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CompanyIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NarationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExtCustIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TranTypeLabel As System.Windows.Forms.Label
    Friend WithEvents TranDocNoLabel As System.Windows.Forms.Label
    Friend WithEvents POLabel As System.Windows.Forms.Label
    Friend WithEvents LocalCustIDLabel As System.Windows.Forms.Label
    Friend WithEvents CodeLabel As System.Windows.Forms.Label
    Friend WithEvents CompanyIDLabel As System.Windows.Forms.Label
    Friend WithEvents QtyLabel As System.Windows.Forms.Label
    Friend WithEvents NarationLabel As System.Windows.Forms.Label
    Friend WithEvents ExtCustIDLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_CompaniesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_CompaniesTableAdapter As FS_ERP_MM.DSPackTranOutTableAdapters.tbl_CompaniesTableAdapter
    Friend WithEvents Tbl_Inv_ExternalCustBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_ExternalCustTableAdapter As FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_ExternalCustTableAdapter
    Friend WithEvents Tbl_Inv_LocalCustBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_LocalCustTableAdapter As FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_LocalCustTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents CPPULabel1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BalanceLabel1 As System.Windows.Forms.Label
    Friend WithEvents UOMLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSPackTranOutTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Proc_MM_Inv_BalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Proc_MM_Inv_BalTableAdapter As FS_ERP_MM.DSPackTranOutTableAdapters.Proc_MM_Inv_BalTableAdapter
    Friend WithEvents UnitLabel1 As System.Windows.Forms.Label
    Friend WithEvents PPULabel1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel2 As System.Windows.Forms.Label
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
End Class
