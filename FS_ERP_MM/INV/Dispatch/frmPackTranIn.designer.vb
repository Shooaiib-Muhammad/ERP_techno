<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackTranIn
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
        Dim TranTypeLabel As System.Windows.Forms.Label
        Dim MRINLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim NarrationLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackTranIn))
        Me.SupplierIDLabel = New System.Windows.Forms.Label()
        Me.CompanyIDLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Inv_Tran_DateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPackTranIn = New FS_ERP_MM.DSPackTranIn()
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
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Tbl_Inv_Tran_InBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_CompaniesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NarrationTextBox = New System.Windows.Forms.TextBox()
        Me.CodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRINTextBox = New System.Windows.Forms.TextBox()
        Me.TranTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSPackTranInTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.Tbl_Inv_Tran_InTableAdapter = New FS_ERP_MM.DSPackTranInTableAdapters.tbl_Inv_Tran_InTableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSPackTranInTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSPackTranInTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_CompaniesTableAdapter = New FS_ERP_MM.DSPackTranInTableAdapters.tbl_CompaniesTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        DateNameLabel = New System.Windows.Forms.Label()
        TranTypeLabel = New System.Windows.Forms.Label()
        MRINLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        NarrationLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPackTranIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_CompaniesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(40, 41)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(97, 20)
        DateNameLabel.TabIndex = 0
        DateNameLabel.Text = "Current Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TranTypeLabel
        '
        TranTypeLabel.Location = New System.Drawing.Point(38, 41)
        TranTypeLabel.Name = "TranTypeLabel"
        TranTypeLabel.Size = New System.Drawing.Size(100, 20)
        TranTypeLabel.TabIndex = 0
        TranTypeLabel.Text = "Tran Type:"
        TranTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MRINLabel
        '
        MRINLabel.Location = New System.Drawing.Point(38, 67)
        MRINLabel.Name = "MRINLabel"
        MRINLabel.Size = New System.Drawing.Size(100, 20)
        MRINLabel.TabIndex = 2
        MRINLabel.Text = "MRIN:"
        MRINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodeLabel
        '
        CodeLabel.Location = New System.Drawing.Point(38, 94)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(100, 20)
        CodeLabel.TabIndex = 4
        CodeLabel.Text = "Material:"
        CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NarrationLabel
        '
        NarrationLabel.Location = New System.Drawing.Point(38, 121)
        NarrationLabel.Name = "NarrationLabel"
        NarrationLabel.Size = New System.Drawing.Size(100, 20)
        NarrationLabel.TabIndex = 6
        NarrationLabel.Text = "Narration:"
        NarrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QtyLabel
        '
        QtyLabel.Location = New System.Drawing.Point(326, 94)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(100, 20)
        QtyLabel.TabIndex = 12
        QtyLabel.Text = "Item Quantity:"
        QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierIDLabel
        '
        Me.SupplierIDLabel.Location = New System.Drawing.Point(326, 40)
        Me.SupplierIDLabel.Name = "SupplierIDLabel"
        Me.SupplierIDLabel.Size = New System.Drawing.Size(100, 20)
        Me.SupplierIDLabel.TabIndex = 8
        Me.SupplierIDLabel.Text = "Supplier:"
        Me.SupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyIDLabel
        '
        Me.CompanyIDLabel.Location = New System.Drawing.Point(326, 67)
        Me.CompanyIDLabel.Name = "CompanyIDLabel"
        Me.CompanyIDLabel.Size = New System.Drawing.Size(100, 20)
        Me.CompanyIDLabel.TabIndex = 10
        Me.CompanyIDLabel.Text = "Company:"
        Me.CompanyIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(655, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transaction Inward"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Inv_Tran_DateBindingNavigator)
        Me.Panel1.Controls.Add(DateNameLabel)
        Me.Panel1.Controls.Add(Me.DateNameLabel1)
        Me.Panel1.Location = New System.Drawing.Point(23, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 80)
        Me.Panel1.TabIndex = 2
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
        Me.Tbl_Inv_Tran_DateBindingNavigator.Size = New System.Drawing.Size(318, 25)
        Me.Tbl_Inv_Tran_DateBindingNavigator.TabIndex = 5
        Me.Tbl_Inv_Tran_DateBindingNavigator.Text = "BindingNavigator1"
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSPackTranIn
        '
        'DSPackTranIn
        '
        Me.DSPackTranIn.DataSetName = "DSPackTranIn"
        Me.DSPackTranIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DateNameLabel1.Location = New System.Drawing.Point(143, 41)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DateNameLabel1.TabIndex = 1
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(QtyLabel)
        Me.Panel2.Controls.Add(Me.QtyTextBox)
        Me.Panel2.Controls.Add(Me.CompanyIDLabel)
        Me.Panel2.Controls.Add(Me.CompanyIDComboBox)
        Me.Panel2.Controls.Add(Me.SupplierIDLabel)
        Me.Panel2.Controls.Add(Me.SupplierIDComboBox)
        Me.Panel2.Controls.Add(NarrationLabel)
        Me.Panel2.Controls.Add(Me.NarrationTextBox)
        Me.Panel2.Controls.Add(CodeLabel)
        Me.Panel2.Controls.Add(Me.CodeComboBox)
        Me.Panel2.Controls.Add(MRINLabel)
        Me.Panel2.Controls.Add(Me.MRINTextBox)
        Me.Panel2.Controls.Add(TranTypeLabel)
        Me.Panel2.Controls.Add(Me.TranTypeComboBox)
        Me.Panel2.Location = New System.Drawing.Point(22, 148)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(604, 157)
        Me.Panel2.TabIndex = 3
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_Tran_InBindingSource
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(602, 25)
        Me.BindingNavigator1.TabIndex = 14
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'Tbl_Inv_Tran_InBindingSource
        '
        Me.Tbl_Inv_Tran_InBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Inv_Tran_In"
        Me.Tbl_Inv_Tran_InBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
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
        'QtyTextBox
        '
        Me.QtyTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(432, 94)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(121, 20)
        Me.QtyTextBox.TabIndex = 5
        '
        'CompanyIDComboBox
        '
        Me.CompanyIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyIDComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CompanyIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_InBindingSource, "CompanyID", True))
        Me.CompanyIDComboBox.DataSource = Me.Tbl_CompaniesBindingSource
        Me.CompanyIDComboBox.DisplayMember = "CompanyName"
        Me.CompanyIDComboBox.FormattingEnabled = True
        Me.CompanyIDComboBox.Location = New System.Drawing.Point(432, 66)
        Me.CompanyIDComboBox.Name = "CompanyIDComboBox"
        Me.CompanyIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CompanyIDComboBox.TabIndex = 3
        Me.CompanyIDComboBox.ValueMember = "CompanyID"
        '
        'Tbl_CompaniesBindingSource
        '
        Me.Tbl_CompaniesBindingSource.DataMember = "tbl_Companies"
        Me.Tbl_CompaniesBindingSource.DataSource = Me.DSPackTranIn
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierIDComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_InBindingSource, "SupplierID", True))
        Me.SupplierIDComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.SupplierIDComboBox.DisplayMember = "CompanyName"
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(432, 39)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SupplierIDComboBox.TabIndex = 1
        Me.SupplierIDComboBox.ValueMember = "SupplierID"
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSPackTranIn
        '
        'NarrationTextBox
        '
        Me.NarrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Narration", True))
        Me.NarrationTextBox.Location = New System.Drawing.Point(144, 121)
        Me.NarrationTextBox.Name = "NarrationTextBox"
        Me.NarrationTextBox.Size = New System.Drawing.Size(409, 20)
        Me.NarrationTextBox.TabIndex = 6
        '
        'CodeComboBox
        '
        Me.CodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CodeComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_InBindingSource, "Code", True))
        Me.CodeComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.CodeComboBox.DisplayMember = "L4Name"
        Me.CodeComboBox.FormattingEnabled = True
        Me.CodeComboBox.Location = New System.Drawing.Point(144, 93)
        Me.CodeComboBox.Name = "CodeComboBox"
        Me.CodeComboBox.Size = New System.Drawing.Size(176, 21)
        Me.CodeComboBox.TabIndex = 4
        Me.CodeComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSPackTranIn
        '
        'MRINTextBox
        '
        Me.MRINTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MRINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "MRIN", True))
        Me.MRINTextBox.Location = New System.Drawing.Point(144, 67)
        Me.MRINTextBox.Name = "MRINTextBox"
        Me.MRINTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRINTextBox.TabIndex = 2
        '
        'TranTypeComboBox
        '
        Me.TranTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TranTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TranTypeComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TranTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "TranType", True))
        Me.TranTypeComboBox.FormattingEnabled = True
        Me.TranTypeComboBox.Items.AddRange(New Object() {"MRI", "MTP"})
        Me.TranTypeComboBox.Location = New System.Drawing.Point(144, 40)
        Me.TranTypeComboBox.Name = "TranTypeComboBox"
        Me.TranTypeComboBox.Size = New System.Drawing.Size(100, 21)
        Me.TranTypeComboBox.TabIndex = 0
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_InTableAdapter
        '
        Me.Tbl_Inv_Tran_InTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_CompaniesTableAdapter
        '
        Me.Tbl_CompaniesTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Press Ctrl+S to Save Record"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Press Ctrl+A to add new Record"
        '
        'frmPackTranIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 332)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPackTranIn"
        Me.Text = "Transaction Inward"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.ResumeLayout(False)
        Me.Tbl_Inv_Tran_DateBindingNavigator.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPackTranIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_CompaniesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DSPackTranIn As FS_ERP_MM.DSPackTranIn
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSPackTranInTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
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
    Friend WithEvents Tbl_Inv_Tran_InBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_InTableAdapter As FS_ERP_MM.DSPackTranInTableAdapters.tbl_Inv_Tran_InTableAdapter
    Friend WithEvents CodeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MRINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TranTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NarrationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSPackTranInTableAdapters.tbl_Inv_L4TableAdapter
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
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSPackTranInTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents Tbl_CompaniesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_CompaniesTableAdapter As FS_ERP_MM.DSPackTranInTableAdapters.tbl_CompaniesTableAdapter
    Friend WithEvents SupplierIDLabel As System.Windows.Forms.Label
    Friend WithEvents CompanyIDLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
