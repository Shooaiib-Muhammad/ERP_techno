<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseReturn
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
        Me.components = New System.ComponentModel.Container
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim PODNoLabel As System.Windows.Forms.Label
        Dim POIDLabel As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim TranInIDLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseReturn))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DateNameLabel1 = New System.Windows.Forms.Label
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPR = New FS_ERP_MM.DSPR
        Me.DayNoLabel1 = New System.Windows.Forms.Label
        Me.Tbl_Inv_Tran_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox
        Me.View_PO_PandingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CPPULabel1 = New System.Windows.Forms.Label
        Me.CurrencyLabel1 = New System.Windows.Forms.Label
        Me.SupplierIDLabel1 = New System.Windows.Forms.Label
        Me.PODNoLabel2 = New System.Windows.Forms.Label
        Me.POIDLabel2 = New System.Windows.Forms.Label
        Me.PPULabel2 = New System.Windows.Forms.Label
        Me.UOMLabel = New System.Windows.Forms.Label
        Me.UOMLabel1 = New System.Windows.Forms.Label
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Add = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.QtyTextBox = New System.Windows.Forms.TextBox
        Me.TranInIDLabel1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.View_PO_DDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.POReceived = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Received = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.View_PO_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSPRTableAdapters.tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager = New FS_ERP_MM.DSPRTableAdapters.TableAdapterManager
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSPRTableAdapters.tbl_Inv_L4TableAdapter
        Me.Tbl_Inv_Tran_OutTableAdapter = New FS_ERP_MM.DSPRTableAdapters.tbl_Inv_Tran_OutTableAdapter
        Me.Tbl_Pur_PO_DTableAdapter = New FS_ERP_MM.DSPRTableAdapters.tbl_Pur_PO_DTableAdapter
        Me.View_PO_DTableAdapter = New FS_ERP_MM.DSPRTableAdapters.View_PO_DTableAdapter
        Me.View_PO_PandingTableAdapter = New FS_ERP_MM.DSPRTableAdapters.View_PO_PandingTableAdapter
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_PO_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        DateNameLabel = New System.Windows.Forms.Label
        QtyLabel = New System.Windows.Forms.Label
        PODNoLabel = New System.Windows.Forms.Label
        POIDLabel = New System.Windows.Forms.Label
        L4NameLabel = New System.Windows.Forms.Label
        TranInIDLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.View_PO_PandingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_PO_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_PO_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_PO_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(19, 52)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(79, 20)
        DateNameLabel.TabIndex = 6
        DateNameLabel.Text = "Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QtyLabel
        '
        QtyLabel.Location = New System.Drawing.Point(8, 162)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(69, 20)
        QtyLabel.TabIndex = 10
        QtyLabel.Text = "Qty:"
        QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PODNoLabel
        '
        PODNoLabel.Location = New System.Drawing.Point(8, 136)
        PODNoLabel.Name = "PODNoLabel"
        PODNoLabel.Size = New System.Drawing.Size(69, 20)
        PODNoLabel.TabIndex = 6
        PODNoLabel.Text = "PO Item No.:"
        PODNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'POIDLabel
        '
        POIDLabel.Location = New System.Drawing.Point(8, 110)
        POIDLabel.Name = "POIDLabel"
        POIDLabel.Size = New System.Drawing.Size(69, 20)
        POIDLabel.TabIndex = 4
        POIDLabel.Text = "PO No.:"
        POIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L4NameLabel
        '
        L4NameLabel.Location = New System.Drawing.Point(8, 62)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(69, 20)
        L4NameLabel.TabIndex = 2
        L4NameLabel.Text = "Material:"
        L4NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TranInIDLabel
        '
        TranInIDLabel.Location = New System.Drawing.Point(8, 36)
        TranInIDLabel.Name = "TranInIDLabel"
        TranInIDLabel.Size = New System.Drawing.Size(69, 20)
        TranInIDLabel.TabIndex = 0
        TranInIDLabel.Text = "S. No.:"
        TranInIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(8, 86)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(69, 20)
        Label3.TabIndex = 25
        Label3.Text = "Tran Doc.#:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(104, 52)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DateNameLabel1.TabIndex = 3
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSPR
        '
        'DSPR
        '
        Me.DSPR.DataSetName = "DSPR"
        Me.DSPR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.Location = New System.Drawing.Point(222, 56)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(59, 16)
        Me.DayNoLabel1.TabIndex = 7
        '
        'Tbl_Inv_Tran_OutBindingSource
        '
        Me.Tbl_Inv_Tran_OutBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Inv_Tran_Out"
        Me.Tbl_Inv_Tran_OutBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.L4NameComboBox)
        Me.Panel1.Controls.Add(Me.CPPULabel1)
        Me.Panel1.Controls.Add(Me.CurrencyLabel1)
        Me.Panel1.Controls.Add(Me.SupplierIDLabel1)
        Me.Panel1.Controls.Add(Me.PODNoLabel2)
        Me.Panel1.Controls.Add(Me.POIDLabel2)
        Me.Panel1.Controls.Add(Me.PPULabel2)
        Me.Panel1.Controls.Add(Me.UOMLabel)
        Me.Panel1.Controls.Add(Me.UOMLabel1)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Controls.Add(PODNoLabel)
        Me.Panel1.Controls.Add(POIDLabel)
        Me.Panel1.Controls.Add(L4NameLabel)
        Me.Panel1.Controls.Add(TranInIDLabel)
        Me.Panel1.Controls.Add(Me.TranInIDLabel1)
        Me.Panel1.Location = New System.Drawing.Point(12, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 279)
        Me.Panel1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranDocNo", True))
        Me.TextBox1.Location = New System.Drawing.Point(77, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "Code", True))
        Me.L4NameComboBox.DataSource = Me.View_PO_PandingBindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(77, 61)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(243, 21)
        Me.L4NameComboBox.TabIndex = 10
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'View_PO_PandingBindingSource
        '
        Me.View_PO_PandingBindingSource.DataMember = "View_PO_Panding"
        Me.View_PO_PandingBindingSource.DataSource = Me.DSPR
        '
        'CPPULabel1
        '
        Me.CPPULabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.Location = New System.Drawing.Point(234, 136)
        Me.CPPULabel1.Name = "CPPULabel1"
        Me.CPPULabel1.Size = New System.Drawing.Size(34, 20)
        Me.CPPULabel1.TabIndex = 23
        Me.CPPULabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CurrencyLabel1
        '
        Me.CurrencyLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.Location = New System.Drawing.Point(234, 162)
        Me.CurrencyLabel1.Name = "CurrencyLabel1"
        Me.CurrencyLabel1.Size = New System.Drawing.Size(34, 20)
        Me.CurrencyLabel1.TabIndex = 21
        Me.CurrencyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SupplierIDLabel1
        '
        Me.SupplierIDLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SupplierIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "SupplierID", True))
        Me.SupplierIDLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SupplierIDLabel1.Location = New System.Drawing.Point(234, 84)
        Me.SupplierIDLabel1.Name = "SupplierIDLabel1"
        Me.SupplierIDLabel1.Size = New System.Drawing.Size(34, 20)
        Me.SupplierIDLabel1.TabIndex = 20
        Me.SupplierIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PODNoLabel2
        '
        Me.PODNoLabel2.BackColor = System.Drawing.Color.White
        Me.PODNoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PODNoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "PODNo", True))
        Me.PODNoLabel2.Location = New System.Drawing.Point(77, 136)
        Me.PODNoLabel2.Name = "PODNoLabel2"
        Me.PODNoLabel2.Size = New System.Drawing.Size(100, 20)
        Me.PODNoLabel2.TabIndex = 17
        Me.PODNoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'POIDLabel2
        '
        Me.POIDLabel2.BackColor = System.Drawing.Color.White
        Me.POIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "PO", True))
        Me.POIDLabel2.Location = New System.Drawing.Point(77, 110)
        Me.POIDLabel2.Name = "POIDLabel2"
        Me.POIDLabel2.Size = New System.Drawing.Size(100, 20)
        Me.POIDLabel2.TabIndex = 16
        Me.POIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PPULabel2
        '
        Me.PPULabel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PPULabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PPULabel2.Location = New System.Drawing.Point(234, 110)
        Me.PPULabel2.Name = "PPULabel2"
        Me.PPULabel2.Size = New System.Drawing.Size(34, 20)
        Me.PPULabel2.TabIndex = 15
        Me.PPULabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UOMLabel
        '
        Me.UOMLabel.Location = New System.Drawing.Point(8, 188)
        Me.UOMLabel.Name = "UOMLabel"
        Me.UOMLabel.Size = New System.Drawing.Size(69, 20)
        Me.UOMLabel.TabIndex = 13
        Me.UOMLabel.Text = "UOM:"
        Me.UOMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UOMLabel1
        '
        Me.UOMLabel1.BackColor = System.Drawing.Color.White
        Me.UOMLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UOMLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "UOM", True))
        Me.UOMLabel1.Location = New System.Drawing.Point(77, 188)
        Me.UOMLabel1.Name = "UOMLabel1"
        Me.UOMLabel1.Size = New System.Drawing.Size(100, 20)
        Me.UOMLabel1.TabIndex = 14
        Me.UOMLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_Tran_OutBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Add, Me.toolStripSeparator, Me.ToolStripButton2, Me.SaveToolStripButton, Me.toolStripSeparator3, Me.ToolStripButton3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(328, 25)
        Me.BindingNavigator1.TabIndex = 12
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'Add
        '
        Me.Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Add.Image = CType(resources.GetObject("Add.Image"), System.Drawing.Image)
        Me.Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(23, 22)
        Me.Add.Text = "Add new"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Delete"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(77, 162)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTextBox.TabIndex = 2
        Me.QtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TranInIDLabel1
        '
        Me.TranInIDLabel1.BackColor = System.Drawing.Color.White
        Me.TranInIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TranInIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranOutID", True))
        Me.TranInIDLabel1.Location = New System.Drawing.Point(77, 36)
        Me.TranInIDLabel1.Name = "TranInIDLabel1"
        Me.TranInIDLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TranInIDLabel1.TabIndex = 1
        Me.TranInIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1124, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Purchase Return"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_PO_DDataGridView
        '
        Me.View_PO_DDataGridView.AllowUserToAddRows = False
        Me.View_PO_DDataGridView.AllowUserToDeleteRows = False
        Me.View_PO_DDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_PO_DDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_PO_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_PO_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.POReceived, Me.Received})
        Me.View_PO_DDataGridView.DataSource = Me.View_PO_DBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.View_PO_DDataGridView.DefaultCellStyle = DataGridViewCellStyle10
        Me.View_PO_DDataGridView.Location = New System.Drawing.Point(347, 105)
        Me.View_PO_DDataGridView.Name = "View_PO_DDataGridView"
        Me.View_PO_DDataGridView.Size = New System.Drawing.Size(665, 252)
        Me.View_PO_DDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CompanyName"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Suppliers"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "POID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "PO No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PODNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PODNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SupplierID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SupplierID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SupplierCodeID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SupplierCodeID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PODate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn12.HeaderText = "Order Date"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ReqDate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn13.HeaderText = "Req Date"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "POQty"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "PO Qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Curency"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Curency"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "UOM"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn10.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'POReceived
        '
        Me.POReceived.DataPropertyName = "POReceive"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.POReceived.DefaultCellStyle = DataGridViewCellStyle8
        Me.POReceived.HeaderText = " Received Qty"
        Me.POReceived.Name = "POReceived"
        Me.POReceived.ReadOnly = True
        Me.POReceived.Width = 65
        '
        'Received
        '
        Me.Received.DataPropertyName = "Received"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Received.DefaultCellStyle = DataGridViewCellStyle9
        Me.Received.HeaderText = "Received"
        Me.Received.Name = "Received"
        Me.Received.ReadOnly = True
        Me.Received.Visible = False
        Me.Received.Width = 70
        '
        'View_PO_DBindingSource
        '
        Me.View_PO_DBindingSource.DataMember = "View_PO_D"
        Me.View_PO_DBindingSource.DataSource = Me.DSPR
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Me.Tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_OutTableAdapter = Me.Tbl_Inv_Tran_OutTableAdapter
        Me.TableAdapterManager.tbl_Pur_PO_DTableAdapter = Me.Tbl_Pur_PO_DTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSPRTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_OutTableAdapter
        '
        Me.Tbl_Inv_Tran_OutTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_PO_DTableAdapter
        '
        Me.Tbl_Pur_PO_DTableAdapter.ClearBeforeFill = True
        '
        'View_PO_DTableAdapter
        '
        Me.View_PO_DTableAdapter.ClearBeforeFill = True
        '
        'View_PO_PandingTableAdapter
        '
        Me.View_PO_PandingTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSPR
        '
        'Tbl_Pur_PO_DBindingSource
        '
        Me.Tbl_Pur_PO_DBindingSource.DataMember = "tbl_Pur_PO_D"
        Me.Tbl_Pur_PO_DBindingSource.DataSource = Me.DSPR
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(347, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(665, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select the Appropriate PO for Purchase Return"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Gate Pass"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPurchaseReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1124, 596)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.View_PO_DDataGridView)
        Me.Controls.Add(Me.DayNoLabel1)
        Me.Controls.Add(DateNameLabel)
        Me.Controls.Add(Me.DateNameLabel1)
        Me.Name = "frmPurchaseReturn"
        Me.Text = "Purchase Return"
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.View_PO_PandingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_PO_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_PO_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_PO_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSPR As FS_ERP_MM.DSPR
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSPRTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSPRTableAdapters.TableAdapterManager
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_Tran_OutTableAdapter As FS_ERP_MM.DSPRTableAdapters.tbl_Inv_Tran_OutTableAdapter
    Friend WithEvents Tbl_Inv_Tran_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_PO_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_PO_DTableAdapter As FS_ERP_MM.DSPRTableAdapters.View_PO_DTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CPPULabel1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents SupplierIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents PODNoLabel2 As System.Windows.Forms.Label
    Friend WithEvents POIDLabel2 As System.Windows.Forms.Label
    Friend WithEvents PPULabel2 As System.Windows.Forms.Label
    Friend WithEvents UOMLabel As System.Windows.Forms.Label
    Friend WithEvents UOMLabel1 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Add As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TranInIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents View_PO_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents View_PO_PandingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_PO_PandingTableAdapter As FS_ERP_MM.DSPRTableAdapters.View_PO_PandingTableAdapter
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSPRTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_PO_DTableAdapter As FS_ERP_MM.DSPRTableAdapters.tbl_Pur_PO_DTableAdapter
    Friend WithEvents Tbl_Pur_PO_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POReceived As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Received As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
