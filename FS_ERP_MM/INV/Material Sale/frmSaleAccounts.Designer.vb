<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleAccounts
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
        Dim CustIDLabel As System.Windows.Forms.Label
        Dim SpecialNoteLabel As System.Windows.Forms.Label
        Dim SDateLabel As System.Windows.Forms.Label
        Dim SIDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaleAccounts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DSSaleAcounts = New FS_ERP_MM.DSSaleAcounts()
        Me.Tbl_MM_SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MM_SaleTableAdapter = New FS_ERP_MM.DSSaleAcountsTableAdapters.tbl_MM_SaleTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSSaleAcountsTableAdapters.TableAdapterManager()
        Me.Tbl_MM_CustomerTableAdapter = New FS_ERP_MM.DSSaleAcountsTableAdapters.tbl_MM_CustomerTableAdapter()
        Me.Tbl_MM_SaleDetailTableAdapter = New FS_ERP_MM.DSSaleAcountsTableAdapters.tbl_MM_SaleDetailTableAdapter()
        Me.Tbl_MM_SaleDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MM_Cust_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MM_Cust_ItemsTableAdapter = New FS_ERP_MM.DSSaleAcountsTableAdapters.tbl_MM_Cust_ItemsTableAdapter()
        Me.Tbl_MM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.CMSDate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMtxtDate = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingNumberTextBox = New System.Windows.Forms.TextBox()
        Me.BillingNoMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BillingNoTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompAddTextBox = New System.Windows.Forms.TextBox()
        Me.CompNameTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CompanyTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
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
        Me.CustomerMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CustomerTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialNoteTextBox = New System.Windows.Forms.TextBox()
        Me.SDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SIDTextBox = New System.Windows.Forms.TextBox()
        Me.ContextMenuInvoiceNo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InvoiceNoTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tbl_MM_SaleDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.SDNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SaleIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        CustIDLabel = New System.Windows.Forms.Label()
        SpecialNoteLabel = New System.Windows.Forms.Label()
        SDateLabel = New System.Windows.Forms.Label()
        SIDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.DSSaleAcounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_SaleDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_Cust_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CMSDate.SuspendLayout()
        Me.BillingNoMenuStrip.SuspendLayout()
        Me.CompanyContextMenuStrip.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.CustomerMenuStrip.SuspendLayout()
        Me.ContextMenuInvoiceNo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_MM_SaleDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustIDLabel
        '
        CustIDLabel.Location = New System.Drawing.Point(3, 63)
        CustIDLabel.Name = "CustIDLabel"
        CustIDLabel.Size = New System.Drawing.Size(100, 20)
        CustIDLabel.TabIndex = 7
        CustIDLabel.Text = "Customer:"
        CustIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SpecialNoteLabel
        '
        SpecialNoteLabel.Location = New System.Drawing.Point(3, 141)
        SpecialNoteLabel.Name = "SpecialNoteLabel"
        SpecialNoteLabel.Size = New System.Drawing.Size(100, 20)
        SpecialNoteLabel.TabIndex = 6
        SpecialNoteLabel.Text = "Special Note:"
        SpecialNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SDateLabel
        '
        SDateLabel.Location = New System.Drawing.Point(211, 36)
        SDateLabel.Name = "SDateLabel"
        SDateLabel.Size = New System.Drawing.Size(79, 20)
        SDateLabel.TabIndex = 5
        SDateLabel.Text = "Invoice Date:"
        SDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler SDateLabel.Click, AddressOf Me.SDateLabel_Click
        '
        'SIDLabel
        '
        SIDLabel.Location = New System.Drawing.Point(3, 36)
        SIDLabel.Name = "SIDLabel"
        SIDLabel.Size = New System.Drawing.Size(100, 20)
        SIDLabel.TabIndex = 4
        SIDLabel.Text = "Sale Invoice No.:"
        SIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(3, 89)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 20)
        Label2.TabIndex = 13
        Label2.Text = "Company Name:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(0, 115)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(100, 20)
        Label3.TabIndex = 14
        Label3.Text = "Company Address:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(402, 36)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(66, 20)
        Label4.TabIndex = 16
        Label4.Text = "Billing No.:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(580, 36)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(75, 20)
        Label5.TabIndex = 18
        Label5.Text = "Billing Date:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(956, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Accounts Sales Invoice"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DSSaleAcounts
        '
        Me.DSSaleAcounts.DataSetName = "DSSaleAcounts"
        Me.DSSaleAcounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_MM_SaleBindingSource
        '
        Me.Tbl_MM_SaleBindingSource.DataMember = "tbl_MM_Sale"
        Me.Tbl_MM_SaleBindingSource.DataSource = Me.DSSaleAcounts
        '
        'Tbl_MM_SaleTableAdapter
        '
        Me.Tbl_MM_SaleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_MM_CustomerTableAdapter = Me.Tbl_MM_CustomerTableAdapter
        Me.TableAdapterManager.tbl_MM_SaleDetailTableAdapter = Me.Tbl_MM_SaleDetailTableAdapter
        Me.TableAdapterManager.tbl_MM_SaleTableAdapter = Me.Tbl_MM_SaleTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSSaleAcountsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_MM_CustomerTableAdapter
        '
        Me.Tbl_MM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_SaleDetailTableAdapter
        '
        Me.Tbl_MM_SaleDetailTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_SaleDetailBindingSource
        '
        Me.Tbl_MM_SaleDetailBindingSource.DataMember = "tbl_MM_Sale_tbl_MM_SaleDetail"
        Me.Tbl_MM_SaleDetailBindingSource.DataSource = Me.Tbl_MM_SaleBindingSource
        '
        'Tbl_MM_Cust_ItemsBindingSource
        '
        Me.Tbl_MM_Cust_ItemsBindingSource.DataMember = "tbl_MM_Cust_Items"
        Me.Tbl_MM_Cust_ItemsBindingSource.DataSource = Me.DSSaleAcounts
        '
        'Tbl_MM_Cust_ItemsTableAdapter
        '
        Me.Tbl_MM_Cust_ItemsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_CustomerBindingSource
        '
        Me.Tbl_MM_CustomerBindingSource.DataMember = "tbl_MM_Customer"
        Me.Tbl_MM_CustomerBindingSource.DataSource = Me.DSSaleAcounts
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.BillingNumberTextBox)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.CompAddTextBox)
        Me.Panel1.Controls.Add(Me.CompNameTextBox)
        Me.Panel1.Controls.Add(Me.BindingNavigator2)
        Me.Panel1.Controls.Add(CustIDLabel)
        Me.Panel1.Controls.Add(Me.CustIDComboBox)
        Me.Panel1.Controls.Add(SpecialNoteLabel)
        Me.Panel1.Controls.Add(Me.SpecialNoteTextBox)
        Me.Panel1.Controls.Add(SDateLabel)
        Me.Panel1.Controls.Add(Me.SDateMaskedTextBox)
        Me.Panel1.Controls.Add(SIDLabel)
        Me.Panel1.Controls.Add(Me.SIDTextBox)
        Me.Panel1.Location = New System.Drawing.Point(46, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(868, 173)
        Me.Panel1.TabIndex = 7
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.White
        Me.MaskedTextBox1.ContextMenuStrip = Me.CMSDate
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "BillingDate", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(661, 36)
        Me.MaskedTextBox1.Mask = "00/00/00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.ReadOnly = True
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 17
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMSDate
        '
        Me.CMSDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMtxtDate, Me.ToolStripMenuItem10})
        Me.CMSDate.Name = "SupplierContextMenuStrip"
        Me.CMSDate.Size = New System.Drawing.Size(161, 51)
        '
        'CMtxtDate
        '
        Me.CMtxtDate.ForeColor = System.Drawing.Color.Silver
        Me.CMtxtDate.Name = "CMtxtDate"
        Me.CMtxtDate.Size = New System.Drawing.Size(100, 23)
        Me.CMtxtDate.Text = "Enter Billing Date"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem10.Text = "Remove &Filter"
        '
        'BillingNumberTextBox
        '
        Me.BillingNumberTextBox.ContextMenuStrip = Me.BillingNoMenuStrip
        Me.BillingNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "BillingNumber", True))
        Me.BillingNumberTextBox.Location = New System.Drawing.Point(474, 36)
        Me.BillingNumberTextBox.Name = "BillingNumberTextBox"
        Me.BillingNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BillingNumberTextBox.TabIndex = 15
        '
        'BillingNoMenuStrip
        '
        Me.BillingNoMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingNoTextBox, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9})
        Me.BillingNoMenuStrip.Name = "SupplierContextMenuStrip"
        Me.BillingNoMenuStrip.Size = New System.Drawing.Size(170, 117)
        '
        'BillingNoTextBox
        '
        Me.BillingNoTextBox.ForeColor = System.Drawing.Color.Silver
        Me.BillingNoTextBox.Name = "BillingNoTextBox"
        Me.BillingNoTextBox.Size = New System.Drawing.Size(100, 23)
        Me.BillingNoTextBox.Text = "Enter Billing No."
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem6.Text = "Remove &Filter"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem7.Text = "&Ascending Order"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem8.Text = "&Descending Order"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem9.Text = "&Remove Order"
        '
        'CompAddTextBox
        '
        Me.CompAddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "CompAdd", True))
        Me.CompAddTextBox.Location = New System.Drawing.Point(106, 115)
        Me.CompAddTextBox.Name = "CompAddTextBox"
        Me.CompAddTextBox.Size = New System.Drawing.Size(362, 20)
        Me.CompAddTextBox.TabIndex = 12
        '
        'CompNameTextBox
        '
        Me.CompNameTextBox.ContextMenuStrip = Me.CompanyContextMenuStrip
        Me.CompNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "CompName", True))
        Me.CompNameTextBox.Location = New System.Drawing.Point(107, 89)
        Me.CompNameTextBox.Name = "CompNameTextBox"
        Me.CompNameTextBox.Size = New System.Drawing.Size(361, 20)
        Me.CompNameTextBox.TabIndex = 10
        '
        'CompanyContextMenuStrip
        '
        Me.CompanyContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyTextBox, Me.RemoveFilterToolStripMenuItem})
        Me.CompanyContextMenuStrip.Name = "SupplierContextMenuStrip"
        Me.CompanyContextMenuStrip.Size = New System.Drawing.Size(161, 51)
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CompanyTextBox.Text = "Enter Company Name"
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove &Filter"
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.Tbl_MM_SaleBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.SaveToolStripButton1})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator2.Size = New System.Drawing.Size(866, 25)
        Me.BindingNavigator2.TabIndex = 9
        Me.BindingNavigator2.Text = "BindingNavigator2"
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
        Me.CustIDComboBox.ContextMenuStrip = Me.CustomerMenuStrip
        Me.CustIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_MM_SaleBindingSource, "CustID", True))
        Me.CustIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CustIDComboBox.FormattingEnabled = True
        Me.CustIDComboBox.Location = New System.Drawing.Point(106, 62)
        Me.CustIDComboBox.Name = "CustIDComboBox"
        Me.CustIDComboBox.Size = New System.Drawing.Size(363, 21)
        Me.CustIDComboBox.TabIndex = 8
        '
        'CustomerMenuStrip
        '
        Me.CustomerMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerTextBox, Me.ToolStripMenuItem5})
        Me.CustomerMenuStrip.Name = "SupplierContextMenuStrip"
        Me.CustomerMenuStrip.Size = New System.Drawing.Size(161, 51)
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CustomerTextBox.Text = "Enter Customer ID"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem5.Text = "Remove &Filter"
        '
        'SpecialNoteTextBox
        '
        Me.SpecialNoteTextBox.BackColor = System.Drawing.Color.White
        Me.SpecialNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "SpecialNote", True))
        Me.SpecialNoteTextBox.Location = New System.Drawing.Point(106, 141)
        Me.SpecialNoteTextBox.Name = "SpecialNoteTextBox"
        Me.SpecialNoteTextBox.ReadOnly = True
        Me.SpecialNoteTextBox.Size = New System.Drawing.Size(738, 20)
        Me.SpecialNoteTextBox.TabIndex = 7
        '
        'SDateMaskedTextBox
        '
        Me.SDateMaskedTextBox.BackColor = System.Drawing.Color.White
        Me.SDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "SDate", True))
        Me.SDateMaskedTextBox.Location = New System.Drawing.Point(296, 36)
        Me.SDateMaskedTextBox.Mask = "00/00/00"
        Me.SDateMaskedTextBox.Name = "SDateMaskedTextBox"
        Me.SDateMaskedTextBox.ReadOnly = True
        Me.SDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SDateMaskedTextBox.TabIndex = 6
        Me.SDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SIDTextBox
        '
        Me.SIDTextBox.BackColor = System.Drawing.Color.White
        Me.SIDTextBox.ContextMenuStrip = Me.ContextMenuInvoiceNo
        Me.SIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_SaleBindingSource, "SID", True))
        Me.SIDTextBox.Location = New System.Drawing.Point(106, 36)
        Me.SIDTextBox.Name = "SIDTextBox"
        Me.SIDTextBox.ReadOnly = True
        Me.SIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SIDTextBox.TabIndex = 5
        Me.SIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContextMenuInvoiceNo
        '
        Me.ContextMenuInvoiceNo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceNoTextBox, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ContextMenuInvoiceNo.Name = "SupplierContextMenuStrip"
        Me.ContextMenuInvoiceNo.Size = New System.Drawing.Size(170, 117)
        '
        'InvoiceNoTextBox
        '
        Me.InvoiceNoTextBox.ForeColor = System.Drawing.Color.Silver
        Me.InvoiceNoTextBox.Name = "InvoiceNoTextBox"
        Me.InvoiceNoTextBox.Size = New System.Drawing.Size(100, 23)
        Me.InvoiceNoTextBox.Text = "Enter Invoice No."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem1.Text = "Remove &Filter"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem2.Text = "&Ascending Order"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem3.Text = "&Descending Order"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem4.Text = "&Remove Order"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Tbl_MM_SaleDetailDataGridView)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Location = New System.Drawing.Point(47, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(867, 271)
        Me.Panel2.TabIndex = 8
        '
        'Tbl_MM_SaleDetailDataGridView
        '
        Me.Tbl_MM_SaleDetailDataGridView.AllowUserToAddRows = False
        Me.Tbl_MM_SaleDetailDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_MM_SaleDetailDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_MM_SaleDetailDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_MM_SaleDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_MM_SaleDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SDNo, Me.SID, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.SaleQty, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1, Me.SaleIssueDate})
        Me.Tbl_MM_SaleDetailDataGridView.DataSource = Me.Tbl_MM_SaleDetailBindingSource
        Me.Tbl_MM_SaleDetailDataGridView.Location = New System.Drawing.Point(4, 28)
        Me.Tbl_MM_SaleDetailDataGridView.Name = "Tbl_MM_SaleDetailDataGridView"
        Me.Tbl_MM_SaleDetailDataGridView.Size = New System.Drawing.Size(858, 236)
        Me.Tbl_MM_SaleDetailDataGridView.TabIndex = 1
        '
        'SDNo
        '
        Me.SDNo.DataPropertyName = "SDNo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SDNo.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn4.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "CustItemID"
        Me.DataGridViewTextBoxColumn4.Width = 210
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Curency"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Curency"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 65
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UOM"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 65
        '
        'SaleQty
        '
        Me.SaleQty.DataPropertyName = "SaleQty"
        Me.SaleQty.HeaderText = "Sale Qty"
        Me.SaleQty.Name = "SaleQty"
        Me.SaleQty.ReadOnly = True
        Me.SaleQty.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EntryDate"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "d"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "Entry Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "SaleStatus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Sale Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'SaleIssueDate
        '
        Me.SaleIssueDate.DataPropertyName = "SaleIssueDate"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "d"
        Me.SaleIssueDate.DefaultCellStyle = DataGridViewCellStyle8
        Me.SaleIssueDate.HeaderText = "Sale Date"
        Me.SaleIssueDate.Name = "SaleIssueDate"
        Me.SaleIssueDate.ReadOnly = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_MM_SaleDetailBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(865, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'frmSaleAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 513)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmSaleAccounts"
        Me.Text = "Acounts Sales Invoice"
        CType(Me.DSSaleAcounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_SaleDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_Cust_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CMSDate.ResumeLayout(False)
        Me.CMSDate.PerformLayout()
        Me.BillingNoMenuStrip.ResumeLayout(False)
        Me.BillingNoMenuStrip.PerformLayout()
        Me.CompanyContextMenuStrip.ResumeLayout(False)
        Me.CompanyContextMenuStrip.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.CustomerMenuStrip.ResumeLayout(False)
        Me.CustomerMenuStrip.PerformLayout()
        Me.ContextMenuInvoiceNo.ResumeLayout(False)
        Me.ContextMenuInvoiceNo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_MM_SaleDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSSaleAcounts As FS_ERP_MM.DSSaleAcounts
    Friend WithEvents Tbl_MM_SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_SaleTableAdapter As FS_ERP_MM.DSSaleAcountsTableAdapters.tbl_MM_SaleTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSSaleAcountsTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_MM_SaleDetailTableAdapter As FS_ERP_MM.DSSaleAcountsTableAdapters.tbl_MM_SaleDetailTableAdapter
    Friend WithEvents Tbl_MM_SaleDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_Cust_ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_Cust_ItemsTableAdapter As FS_ERP_MM.DSSaleAcountsTableAdapters.tbl_MM_Cust_ItemsTableAdapter
    Friend WithEvents Tbl_MM_CustomerTableAdapter As FS_ERP_MM.DSSaleAcountsTableAdapters.tbl_MM_CustomerTableAdapter
    Friend WithEvents Tbl_MM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpecialNoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents SIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Tbl_MM_SaleDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CompAddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompNameTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents CompanyContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CompanyTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuInvoiceNo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents InvoiceNoTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CustomerMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CustomerTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingNoMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BillingNoTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMSDate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMtxtDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
End Class
