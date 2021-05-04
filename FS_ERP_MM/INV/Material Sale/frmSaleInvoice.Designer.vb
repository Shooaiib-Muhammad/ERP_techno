<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleInvoice
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
        Dim SIDLabel As System.Windows.Forms.Label
        Dim SDateLabel As System.Windows.Forms.Label
        Dim SpecialNoteLabel As System.Windows.Forms.Label
        Dim CustIDLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaleInvoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_MM_SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSale = New FS_ERP_MM.DSSale()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SaleIDLabel = New System.Windows.Forms.Label()
        Me.CMSaleNo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleNOTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SaveToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CustIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CMCustomerName = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CustomerNameTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_MM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpecialNoteTextBox = New System.Windows.Forms.TextBox()
        Me.SDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.InvoiceDateContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InvoiceDateTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tbl_MM_SaleDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.SDNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_MM_Cust_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SaleIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_MM_SaleDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TableAdapterManager = New FS_ERP_MM.DSSaleTableAdapters.TableAdapterManager()
        Me.Tbl_MM_CustomerTableAdapter = New FS_ERP_MM.DSSaleTableAdapters.tbl_MM_CustomerTableAdapter()
        Me.Tbl_MM_SaleDetailTableAdapter = New FS_ERP_MM.DSSaleTableAdapters.tbl_MM_SaleDetailTableAdapter()
        Me.Tbl_MM_SaleTableAdapter = New FS_ERP_MM.DSSaleTableAdapters.tbl_MM_SaleTableAdapter()
        Me.Tbl_MM_Cust_ItemsTableAdapter = New FS_ERP_MM.DSSaleTableAdapters.tbl_MM_Cust_ItemsTableAdapter()
        Me.View_Mat_BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Mat_BalanceTableAdapter = New FS_ERP_MM.DSSaleTableAdapters.View_Mat_BalanceTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        SIDLabel = New System.Windows.Forms.Label()
        SDateLabel = New System.Windows.Forms.Label()
        SpecialNoteLabel = New System.Windows.Forms.Label()
        CustIDLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_MM_SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSaleNo.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.CMCustomerName.SuspendLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoiceDateContextMenuStrip.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_MM_SaleDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_Cust_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_SaleDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_Mat_BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SIDLabel
        '
        SIDLabel.Location = New System.Drawing.Point(3, 31)
        SIDLabel.Name = "SIDLabel"
        SIDLabel.Size = New System.Drawing.Size(100, 20)
        SIDLabel.TabIndex = 4
        SIDLabel.Text = "Sale Invoice No.:"
        SIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SDateLabel
        '
        SDateLabel.Location = New System.Drawing.Point(252, 31)
        SDateLabel.Name = "SDateLabel"
        SDateLabel.Size = New System.Drawing.Size(100, 20)
        SDateLabel.TabIndex = 5
        SDateLabel.Text = "Invoice Date:"
        SDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SpecialNoteLabel
        '
        SpecialNoteLabel.Location = New System.Drawing.Point(3, 80)
        SpecialNoteLabel.Name = "SpecialNoteLabel"
        SpecialNoteLabel.Size = New System.Drawing.Size(100, 20)
        SpecialNoteLabel.TabIndex = 6
        SpecialNoteLabel.Text = "Special Note:"
        SpecialNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustIDLabel
        '
        CustIDLabel.Location = New System.Drawing.Point(3, 56)
        CustIDLabel.Name = "CustIDLabel"
        CustIDLabel.Size = New System.Drawing.Size(100, 20)
        CustIDLabel.TabIndex = 7
        CustIDLabel.Text = "Customer:"
        CustIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(744, 31)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(100, 20)
        Label3.TabIndex = 28
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QtyLabel
        '
        QtyLabel.Location = New System.Drawing.Point(462, 56)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(77, 20)
        QtyLabel.TabIndex = 33
        QtyLabel.Text = "Discount:"
        QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1151, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sales Invoice"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.SaleIDLabel)
        Me.Panel1.Controls.Add(Me.BindingNavigator2)
        Me.Panel1.Controls.Add(CustIDLabel)
        Me.Panel1.Controls.Add(Me.CustIDComboBox)
        Me.Panel1.Controls.Add(SpecialNoteLabel)
        Me.Panel1.Controls.Add(Me.SpecialNoteTextBox)
        Me.Panel1.Controls.Add(SDateLabel)
        Me.Panel1.Controls.Add(Me.SDateMaskedTextBox)
        Me.Panel1.Controls.Add(SIDLabel)
        Me.Panel1.Location = New System.Drawing.Point(11, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(869, 110)
        Me.Panel1.TabIndex = 6
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "Discount", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(545, 56)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTextBox.TabIndex = 32
        Me.QtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tbl_MM_SaleBindingSource
        '
        Me.Tbl_MM_SaleBindingSource.DataMember = "tbl_MM_Sale"
        Me.Tbl_MM_SaleBindingSource.DataSource = Me.DSSale
        '
        'DSSale
        '
        Me.DSSale.DataSetName = "DSSale"
        Me.DSSale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_MM_SaleBindingSource, "PurchaseStatus", True))
        Me.CheckBox1.Location = New System.Drawing.Point(464, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(115, 18)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Local Sale Status:"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SaleIDLabel
        '
        Me.SaleIDLabel.BackColor = System.Drawing.Color.White
        Me.SaleIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SaleIDLabel.ContextMenuStrip = Me.CMSaleNo
        Me.SaleIDLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "SID", True))
        Me.SaleIDLabel.Location = New System.Drawing.Point(106, 31)
        Me.SaleIDLabel.Name = "SaleIDLabel"
        Me.SaleIDLabel.Size = New System.Drawing.Size(100, 20)
        Me.SaleIDLabel.TabIndex = 10
        Me.SaleIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMSaleNo
        '
        Me.CMSaleNo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem10, Me.ToolStripMenuItem1})
        Me.CMSaleNo.Name = "SupplierContextMenuStrip"
        Me.CMSaleNo.Size = New System.Drawing.Size(173, 48)
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleNOTextBox})
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem10.Text = "Enter Sale Number"
        '
        'SaleNOTextBox
        '
        Me.SaleNOTextBox.ForeColor = System.Drawing.Color.Silver
        Me.SaleNOTextBox.Name = "SaleNOTextBox"
        Me.SaleNOTextBox.Size = New System.Drawing.Size(100, 23)
        Me.SaleNOTextBox.Text = "Enter Sale Invoice No."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem1.Text = "Remove &Filter"
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator2.BindingSource = Me.Tbl_MM_SaleBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton1})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator2.Size = New System.Drawing.Size(867, 25)
        Me.BindingNavigator2.TabIndex = 9
        Me.BindingNavigator2.Text = "BindingNavigator2"
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
        'SaveToolStripButton1
        '
        Me.SaveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton1.Image = CType(resources.GetObject("SaveToolStripButton1.Image"), System.Drawing.Image)
        Me.SaveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton1.Name = "SaveToolStripButton1"
        Me.SaveToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton1.Text = "&Save"
        '
        'CustIDComboBox
        '
        Me.CustIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustIDComboBox.ContextMenuStrip = Me.CMCustomerName
        Me.CustIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_MM_SaleBindingSource, "CustID", True))
        Me.CustIDComboBox.DataSource = Me.Tbl_MM_CustomerBindingSource
        Me.CustIDComboBox.DisplayMember = "CompanyName"
        Me.CustIDComboBox.FormattingEnabled = True
        Me.CustIDComboBox.Location = New System.Drawing.Point(106, 55)
        Me.CustIDComboBox.Name = "CustIDComboBox"
        Me.CustIDComboBox.Size = New System.Drawing.Size(352, 21)
        Me.CustIDComboBox.TabIndex = 8
        Me.CustIDComboBox.ValueMember = "CustID"
        '
        'CMCustomerName
        '
        Me.CMCustomerName.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerNameTextBox, Me.ToolStripMenuItem11})
        Me.CMCustomerName.Name = "SupplierContextMenuStrip"
        Me.CMCustomerName.Size = New System.Drawing.Size(171, 51)
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(110, 23)
        Me.CustomerNameTextBox.Text = "Enter Customer Name"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem11.Text = "Remove &Filter"
        '
        'Tbl_MM_CustomerBindingSource
        '
        Me.Tbl_MM_CustomerBindingSource.DataMember = "tbl_MM_Customer"
        Me.Tbl_MM_CustomerBindingSource.DataSource = Me.DSSale
        '
        'SpecialNoteTextBox
        '
        Me.SpecialNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "SpecialNote", True))
        Me.SpecialNoteTextBox.Location = New System.Drawing.Point(106, 80)
        Me.SpecialNoteTextBox.Name = "SpecialNoteTextBox"
        Me.SpecialNoteTextBox.Size = New System.Drawing.Size(738, 20)
        Me.SpecialNoteTextBox.TabIndex = 7
        '
        'SDateMaskedTextBox
        '
        Me.SDateMaskedTextBox.ContextMenuStrip = Me.InvoiceDateContextMenuStrip
        Me.SDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "SDate", True))
        Me.SDateMaskedTextBox.Location = New System.Drawing.Point(358, 31)
        Me.SDateMaskedTextBox.Mask = "00/00/0000"
        Me.SDateMaskedTextBox.Name = "SDateMaskedTextBox"
        Me.SDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SDateMaskedTextBox.TabIndex = 6
        Me.SDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InvoiceDateContextMenuStrip
        '
        Me.InvoiceDateContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceDateTextBox, Me.RemoveFilterToolStripMenuItem, Me.AscendingOrderToolStripMenuItem, Me.DescendingOrderToolStripMenuItem, Me.RemoveOrderToolStripMenuItem})
        Me.InvoiceDateContextMenuStrip.Name = "SupplierContextMenuStrip"
        Me.InvoiceDateContextMenuStrip.Size = New System.Drawing.Size(170, 117)
        '
        'InvoiceDateTextBox
        '
        Me.InvoiceDateTextBox.ForeColor = System.Drawing.Color.Silver
        Me.InvoiceDateTextBox.Name = "InvoiceDateTextBox"
        Me.InvoiceDateTextBox.Size = New System.Drawing.Size(100, 23)
        Me.InvoiceDateTextBox.Text = "Enter Invoice Date"
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove &Filter"
        '
        'AscendingOrderToolStripMenuItem
        '
        Me.AscendingOrderToolStripMenuItem.Name = "AscendingOrderToolStripMenuItem"
        Me.AscendingOrderToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AscendingOrderToolStripMenuItem.Text = "&Ascending Order"
        '
        'DescendingOrderToolStripMenuItem
        '
        Me.DescendingOrderToolStripMenuItem.Name = "DescendingOrderToolStripMenuItem"
        Me.DescendingOrderToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DescendingOrderToolStripMenuItem.Text = "&Descending Order"
        '
        'RemoveOrderToolStripMenuItem
        '
        Me.RemoveOrderToolStripMenuItem.Name = "RemoveOrderToolStripMenuItem"
        Me.RemoveOrderToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RemoveOrderToolStripMenuItem.Text = "&Remove Order"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Tbl_MM_SaleDetailDataGridView)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Location = New System.Drawing.Point(11, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(869, 415)
        Me.Panel2.TabIndex = 7
        '
        'Tbl_MM_SaleDetailDataGridView
        '
        Me.Tbl_MM_SaleDetailDataGridView.AllowUserToAddRows = False
        Me.Tbl_MM_SaleDetailDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_MM_SaleDetailDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_MM_SaleDetailDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_MM_SaleDetailDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_MM_SaleDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_MM_SaleDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SDNo, Me.SID, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.SaleQty, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1, Me.SaleIssueDate})
        Me.Tbl_MM_SaleDetailDataGridView.DataSource = Me.Tbl_MM_SaleDetailBindingSource
        Me.Tbl_MM_SaleDetailDataGridView.Location = New System.Drawing.Point(3, 27)
        Me.Tbl_MM_SaleDetailDataGridView.Name = "Tbl_MM_SaleDetailDataGridView"
        Me.Tbl_MM_SaleDetailDataGridView.Size = New System.Drawing.Size(862, 384)
        Me.Tbl_MM_SaleDetailDataGridView.TabIndex = 1
        '
        'SDNo
        '
        Me.SDNo.DataPropertyName = "SDNo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SDNo.DefaultCellStyle = DataGridViewCellStyle3
        Me.SDNo.HeaderText = "S.No."
        Me.SDNo.Name = "SDNo"
        Me.SDNo.ReadOnly = True
        Me.SDNo.Width = 60
        '
        'SID
        '
        Me.SID.DataPropertyName = "SID"
        Me.SID.HeaderText = "SID"
        Me.SID.Name = "SID"
        Me.SID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SID.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CustID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CustID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CustItemID"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.Tbl_MM_Cust_ItemsBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn4.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "CustItemID"
        Me.DataGridViewTextBoxColumn4.Width = 320
        '
        'Tbl_MM_Cust_ItemsBindingSource
        '
        Me.Tbl_MM_Cust_ItemsBindingSource.DataMember = "tbl_MM_Customer_tbl_MM_Cust_Items"
        Me.Tbl_MM_Cust_ItemsBindingSource.DataSource = Me.Tbl_MM_CustomerBindingSource
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Curency"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Curency"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 65
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UOM"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn7.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 65
        '
        'SaleQty
        '
        Me.SaleQty.DataPropertyName = "SaleQty"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SaleQty.DefaultCellStyle = DataGridViewCellStyle8
        Me.SaleQty.HeaderText = "Sale Qty"
        Me.SaleQty.Name = "SaleQty"
        Me.SaleQty.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EntryDate"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "d"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn8.HeaderText = "Entry Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "SaleStatus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Sale Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'SaleIssueDate
        '
        Me.SaleIssueDate.DataPropertyName = "SaleIssueDate"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "d"
        Me.SaleIssueDate.DefaultCellStyle = DataGridViewCellStyle10
        Me.SaleIssueDate.HeaderText = "Sale Date"
        Me.SaleIssueDate.Name = "SaleIssueDate"
        Me.SaleIssueDate.ReadOnly = True
        Me.SaleIssueDate.Width = 90
        '
        'Tbl_MM_SaleDetailBindingSource
        '
        Me.Tbl_MM_SaleDetailBindingSource.DataMember = "tbl_MM_Sale_tbl_MM_SaleDetail"
        Me.Tbl_MM_SaleDetailBindingSource.DataSource = Me.Tbl_MM_SaleBindingSource
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.Tbl_MM_SaleDetailBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(867, 25)
        Me.BindingNavigator1.TabIndex = 1
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
        Me.SaveToolStripButton.Text = "&Save"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_MM_CustomerTableAdapter = Me.Tbl_MM_CustomerTableAdapter
        Me.TableAdapterManager.tbl_MM_SaleDetailTableAdapter = Me.Tbl_MM_SaleDetailTableAdapter
        Me.TableAdapterManager.tbl_MM_SaleTableAdapter = Me.Tbl_MM_SaleTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSSaleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_MM_CustomerTableAdapter
        '
        Me.Tbl_MM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_SaleDetailTableAdapter
        '
        Me.Tbl_MM_SaleDetailTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_SaleTableAdapter
        '
        Me.Tbl_MM_SaleTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_Cust_ItemsTableAdapter
        '
        Me.Tbl_MM_Cust_ItemsTableAdapter.ClearBeforeFill = True
        '
        'View_Mat_BalanceBindingSource
        '
        Me.View_Mat_BalanceBindingSource.DataMember = "View_Mat_Balance"
        Me.View_Mat_BalanceBindingSource.DataSource = Me.DSSale
        '
        'View_Mat_BalanceTableAdapter
        '
        Me.View_Mat_BalanceTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(884, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 39)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "View Sale Invoice"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmSaleInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 624)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSaleInvoice"
        Me.Text = "Sales Invoice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_MM_SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSaleNo.ResumeLayout(False)
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.CMCustomerName.ResumeLayout(False)
        Me.CMCustomerName.PerformLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoiceDateContextMenuStrip.ResumeLayout(False)
        Me.InvoiceDateContextMenuStrip.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_MM_SaleDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_Cust_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_SaleDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_Mat_BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSSale As FS_ERP_MM.DSSale
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSSaleTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_MM_SaleTableAdapter As FS_ERP_MM.DSSaleTableAdapters.tbl_MM_SaleTableAdapter
    Friend WithEvents Tbl_MM_SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpecialNoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Tbl_MM_CustomerTableAdapter As FS_ERP_MM.DSSaleTableAdapters.tbl_MM_CustomerTableAdapter
    Friend WithEvents Tbl_MM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_MM_SaleDetailTableAdapter As FS_ERP_MM.DSSaleTableAdapters.tbl_MM_SaleDetailTableAdapter
    Friend WithEvents Tbl_MM_SaleDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_SaleDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Tbl_MM_Cust_ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_Cust_ItemsTableAdapter As FS_ERP_MM.DSSaleTableAdapters.tbl_MM_Cust_ItemsTableAdapter
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SaveToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents InvoiceDateContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents InvoiceDateTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents View_Mat_BalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Mat_BalanceTableAdapter As FS_ERP_MM.DSSaleTableAdapters.View_Mat_BalanceTableAdapter
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaleIDLabel As System.Windows.Forms.Label
    Friend WithEvents CMCustomerName As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CustomerNameTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMSaleNo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleNOTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SDNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaleQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SaleIssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
End Class
