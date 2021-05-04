<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillingTranNewVerifying
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
        Dim InvoiceDateLabel As System.Windows.Forms.Label
        Dim RefNoLabel As System.Windows.Forms.Label
        Dim InvoiceNoLabel As System.Windows.Forms.Label
        Dim PartyIDLabel As System.Windows.Forms.Label
        Dim TranIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillingTranNewVerifying))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.VerifyDateLabel = New System.Windows.Forms.Label
        Me.VerifyStatusCheckBox = New System.Windows.Forms.CheckBox
        Me.PartyNameLabel1 = New System.Windows.Forms.Label
        Me.CMPartyName = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PartyNameText = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.InvoiceNoLabel2 = New System.Windows.Forms.Label
        Me.CMBillingTran = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BillingNoTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
        Me.InvoiceDateLabel2 = New System.Windows.Forms.Label
        Me.RefNoTextBox = New System.Windows.Forms.TextBox
        Me.TranIdLabel1 = New System.Windows.Forms.Label
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.Tbl_Billing_Transactions_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.Tbl_Billing_TransactionsDataGridView = New System.Windows.Forms.DataGridView
        Me.Tbl_Pur_POBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBillingVerify = New FS_ERP_MM.DSBillingVerify
        Me.Tbl_Pur_POTableAdapter = New FS_ERP_MM.DSBillingVerifyTableAdapters.tbl_Pur_POTableAdapter
        Me.TableAdapterManager1 = New FS_ERP_MM.DSBillingVerifyTableAdapters.TableAdapterManager
        Me.View_Billing_TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBilling = New FS_ERP_MM.DSBilling
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.View_Billing_TransactionsTableAdapter = New FS_ERP_MM.DSBillingTableAdapters.View_Billing_TransactionsTableAdapter
        Me.TableAdapterManager = New FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager
        Me.Tbl_Billing_Transactions_DetailTableAdapter = New FS_ERP_MM.DSBillingTableAdapters.tbl_Billing_Transactions_DetailTableAdapter
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSBillingTableAdapters.tbl_Inv_L4TableAdapter
        InvoiceDateLabel = New System.Windows.Forms.Label
        RefNoLabel = New System.Windows.Forms.Label
        InvoiceNoLabel = New System.Windows.Forms.Label
        PartyIDLabel = New System.Windows.Forms.Label
        TranIdLabel = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.CMPartyName.SuspendLayout()
        Me.CMBillingTran.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.Tbl_Billing_Transactions_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.Tbl_Billing_TransactionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBillingVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Billing_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceDateLabel
        '
        InvoiceDateLabel.AutoSize = True
        InvoiceDateLabel.Location = New System.Drawing.Point(328, 36)
        InvoiceDateLabel.Name = "InvoiceDateLabel"
        InvoiceDateLabel.Size = New System.Drawing.Size(71, 13)
        InvoiceDateLabel.TabIndex = 8
        InvoiceDateLabel.Text = "Invoice Date:"
        '
        'RefNoLabel
        '
        RefNoLabel.AutoSize = True
        RefNoLabel.Location = New System.Drawing.Point(355, 59)
        RefNoLabel.Name = "RefNoLabel"
        RefNoLabel.Size = New System.Drawing.Size(44, 13)
        RefNoLabel.TabIndex = 7
        RefNoLabel.Text = "Ref No:"
        '
        'InvoiceNoLabel
        '
        InvoiceNoLabel.AutoSize = True
        InvoiceNoLabel.Location = New System.Drawing.Point(153, 36)
        InvoiceNoLabel.Name = "InvoiceNoLabel"
        InvoiceNoLabel.Size = New System.Drawing.Size(62, 13)
        InvoiceNoLabel.TabIndex = 5
        InvoiceNoLabel.Text = "Invoice No:"
        '
        'PartyIDLabel
        '
        PartyIDLabel.AutoSize = True
        PartyIDLabel.Location = New System.Drawing.Point(3, 59)
        PartyIDLabel.Name = "PartyIDLabel"
        PartyIDLabel.Size = New System.Drawing.Size(65, 13)
        PartyIDLabel.TabIndex = 3
        PartyIDLabel.Text = "Party Name:"
        '
        'TranIdLabel
        '
        TranIdLabel.AutoSize = True
        TranIdLabel.Location = New System.Drawing.Point(3, 36)
        TranIdLabel.Name = "TranIdLabel"
        TranIdLabel.Size = New System.Drawing.Size(40, 13)
        TranIdLabel.TabIndex = 1
        TranIdLabel.Text = "Sr.No.:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Billing Transactions Verification"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.VerifyDateLabel)
        Me.Panel1.Controls.Add(Me.VerifyStatusCheckBox)
        Me.Panel1.Controls.Add(Me.PartyNameLabel1)
        Me.Panel1.Controls.Add(Me.InvoiceNoLabel2)
        Me.Panel1.Controls.Add(InvoiceDateLabel)
        Me.Panel1.Controls.Add(Me.InvoiceDateLabel2)
        Me.Panel1.Controls.Add(RefNoLabel)
        Me.Panel1.Controls.Add(Me.RefNoTextBox)
        Me.Panel1.Controls.Add(InvoiceNoLabel)
        Me.Panel1.Controls.Add(PartyIDLabel)
        Me.Panel1.Controls.Add(TranIdLabel)
        Me.Panel1.Controls.Add(Me.TranIdLabel1)
        Me.Panel1.Controls.Add(Me.BindingNavigator2)
        Me.Panel1.Location = New System.Drawing.Point(3, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 84)
        Me.Panel1.TabIndex = 9
        '
        'VerifyDateLabel
        '
        Me.VerifyDateLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Billing_TransactionsBindingSource, "VerifyDate", True))
        Me.VerifyDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VerifyDateLabel.Location = New System.Drawing.Point(522, 60)
        Me.VerifyDateLabel.Name = "VerifyDateLabel"
        Me.VerifyDateLabel.Size = New System.Drawing.Size(36, 10)
        Me.VerifyDateLabel.TabIndex = 14
        '
        'VerifyStatusCheckBox
        '
        Me.VerifyStatusCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VerifyStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.View_Billing_TransactionsBindingSource, "VerifyStatus", True))
        Me.VerifyStatusCheckBox.Location = New System.Drawing.Point(512, 33)
        Me.VerifyStatusCheckBox.Name = "VerifyStatusCheckBox"
        Me.VerifyStatusCheckBox.Size = New System.Drawing.Size(87, 20)
        Me.VerifyStatusCheckBox.TabIndex = 12
        Me.VerifyStatusCheckBox.Text = "Verify Status"
        Me.VerifyStatusCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VerifyStatusCheckBox.UseVisualStyleBackColor = True
        '
        'PartyNameLabel1
        '
        Me.PartyNameLabel1.BackColor = System.Drawing.Color.White
        Me.PartyNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PartyNameLabel1.ContextMenuStrip = Me.CMPartyName
        Me.PartyNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Billing_TransactionsBindingSource, "PartyName", True))
        Me.PartyNameLabel1.Location = New System.Drawing.Point(70, 57)
        Me.PartyNameLabel1.Name = "PartyNameLabel1"
        Me.PartyNameLabel1.Size = New System.Drawing.Size(252, 20)
        Me.PartyNameLabel1.TabIndex = 10
        Me.PartyNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CMPartyName
        '
        Me.CMPartyName.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartyNameText, Me.ToolStripMenuItem1})
        Me.CMPartyName.Name = "SupplierContextMenuStrip"
        Me.CMPartyName.Size = New System.Drawing.Size(171, 51)
        '
        'PartyNameText
        '
        Me.PartyNameText.ForeColor = System.Drawing.Color.Black
        Me.PartyNameText.Name = "PartyNameText"
        Me.PartyNameText.Size = New System.Drawing.Size(110, 23)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem1.Text = "Remove &Filter"
        '
        'InvoiceNoLabel2
        '
        Me.InvoiceNoLabel2.BackColor = System.Drawing.Color.White
        Me.InvoiceNoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InvoiceNoLabel2.ContextMenuStrip = Me.CMBillingTran
        Me.InvoiceNoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Billing_TransactionsBindingSource, "InvoiceNo", True))
        Me.InvoiceNoLabel2.Location = New System.Drawing.Point(221, 33)
        Me.InvoiceNoLabel2.Name = "InvoiceNoLabel2"
        Me.InvoiceNoLabel2.Size = New System.Drawing.Size(100, 20)
        Me.InvoiceNoLabel2.TabIndex = 11
        Me.InvoiceNoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMBillingTran
        '
        Me.CMBillingTran.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingNoTextBox, Me.ToolStripMenuItem11})
        Me.CMBillingTran.Name = "SupplierContextMenuStrip"
        Me.CMBillingTran.Size = New System.Drawing.Size(171, 51)
        '
        'BillingNoTextBox
        '
        Me.BillingNoTextBox.ForeColor = System.Drawing.Color.Black
        Me.BillingNoTextBox.Name = "BillingNoTextBox"
        Me.BillingNoTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem11.Text = "Remove &Filter"
        '
        'InvoiceDateLabel2
        '
        Me.InvoiceDateLabel2.BackColor = System.Drawing.Color.White
        Me.InvoiceDateLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InvoiceDateLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Billing_TransactionsBindingSource, "InvoiceDate", True))
        Me.InvoiceDateLabel2.Location = New System.Drawing.Point(405, 33)
        Me.InvoiceDateLabel2.Name = "InvoiceDateLabel2"
        Me.InvoiceDateLabel2.Size = New System.Drawing.Size(100, 20)
        Me.InvoiceDateLabel2.TabIndex = 10
        Me.InvoiceDateLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RefNoTextBox
        '
        Me.RefNoTextBox.Location = New System.Drawing.Point(405, 57)
        Me.RefNoTextBox.Name = "RefNoTextBox"
        Me.RefNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RefNoTextBox.TabIndex = 8
        '
        'TranIdLabel1
        '
        Me.TranIdLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TranIdLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TranIdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Billing_TransactionsBindingSource, "TranId", True))
        Me.TranIdLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.TranIdLabel1.Location = New System.Drawing.Point(70, 33)
        Me.TranIdLabel1.Name = "TranIdLabel1"
        Me.TranIdLabel1.Size = New System.Drawing.Size(74, 20)
        Me.TranIdLabel1.TabIndex = 2
        Me.TranIdLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.View_Billing_TransactionsBindingSource
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
        Me.BindingNavigator2.Size = New System.Drawing.Size(614, 25)
        Me.BindingNavigator2.TabIndex = 0
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
        'SaveToolStripButton1
        '
        Me.SaveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton1.Image = CType(resources.GetObject("SaveToolStripButton1.Image"), System.Drawing.Image)
        Me.SaveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton1.Name = "SaveToolStripButton1"
        Me.SaveToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton1.Text = "&Save"
        '
        'Tbl_Billing_Transactions_DetailBindingSource
        '
        Me.Tbl_Billing_Transactions_DetailBindingSource.DataMember = "View_Billing_Transactions_tbl_Billing_Transactions_Detail"
        Me.Tbl_Billing_Transactions_DetailBindingSource.DataSource = Me.View_Billing_TransactionsBindingSource
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator3)
        Me.Panel2.Controls.Add(Me.Tbl_Billing_TransactionsDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(3, 122)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 555)
        Me.Panel2.TabIndex = 10
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator3.BindingSource = Me.Tbl_Billing_Transactions_DetailBindingSource
        Me.BindingNavigator3.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator3.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator3.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator3.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator3.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator3.Size = New System.Drawing.Size(968, 25)
        Me.BindingNavigator3.TabIndex = 1
        Me.BindingNavigator3.Text = "BindingNavigator3"
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
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
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
        'Tbl_Billing_TransactionsDataGridView
        '
        Me.Tbl_Billing_TransactionsDataGridView.AllowUserToAddRows = False
        Me.Tbl_Billing_TransactionsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_Billing_TransactionsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Billing_TransactionsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Billing_TransactionsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_Billing_TransactionsDataGridView.ColumnHeadersHeight = 32
        Me.Tbl_Billing_TransactionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Tbl_Billing_TransactionsDataGridView.DataSource = Me.Tbl_Billing_Transactions_DetailBindingSource
        Me.Tbl_Billing_TransactionsDataGridView.Location = New System.Drawing.Point(2, 27)
        Me.Tbl_Billing_TransactionsDataGridView.Name = "Tbl_Billing_TransactionsDataGridView"
        Me.Tbl_Billing_TransactionsDataGridView.Size = New System.Drawing.Size(964, 523)
        Me.Tbl_Billing_TransactionsDataGridView.TabIndex = 0
        '
        'Tbl_Pur_POBindingSource
        '
        Me.Tbl_Pur_POBindingSource.DataMember = "tbl_Pur_PO"
        Me.Tbl_Pur_POBindingSource.DataSource = Me.DSBillingVerify
        '
        'DSBillingVerify
        '
        Me.DSBillingVerify.DataSetName = "DSBillingVerify"
        Me.DSBillingVerify.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Pur_POTableAdapter
        '
        Me.Tbl_Pur_POTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_Billing_Transactions11TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Billing_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DSBillingVerifyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_Billing_TransactionsBindingSource
        '
        Me.View_Billing_TransactionsBindingSource.DataMember = "View_Billing_Transactions"
        Me.View_Billing_TransactionsBindingSource.DataSource = Me.DSBilling
        '
        'DSBilling
        '
        Me.DSBilling.DataSetName = "DSBilling"
        Me.DSBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PartyID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PartyID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TranId"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TranId"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DayID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DayID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TranDID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sr.No."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.Tbl_Inv_L4BindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn5.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Material Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "Code"
        Me.DataGridViewTextBoxColumn5.Width = 270
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSBilling
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Qty"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Amount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Description"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 230
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PaymentDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PaymentDate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "VerifyStatus"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Verify Status"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "VerifyDate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "VerifyDate"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PO"
        Me.DataGridViewTextBoxColumn11.DataSource = Me.Tbl_Pur_POBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn11.DisplayMember = "POID"
        Me.DataGridViewTextBoxColumn11.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn11.HeaderText = "PO #"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn11.ValueMember = "POID"
        Me.DataGridViewTextBoxColumn11.Width = 70
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "MRINDate"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "d"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn12.HeaderText = "MRIN Date"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 70
        '
        'View_Billing_TransactionsTableAdapter
        '
        Me.View_Billing_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Billing_PartyTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Billing_Transactions_DetailTableAdapter = Me.Tbl_Billing_Transactions_DetailTableAdapter
        Me.TableAdapterManager.tbl_Billing_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_Billing_TransactionsTableAdapter = Nothing
        '
        'Tbl_Billing_Transactions_DetailTableAdapter
        '
        Me.Tbl_Billing_Transactions_DetailTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'frmBillingTranNewVerifying
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 771)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBillingTranNewVerifying"
        Me.Text = "Billing Transactions Verification"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CMPartyName.ResumeLayout(False)
        Me.CMPartyName.PerformLayout()
        Me.CMBillingTran.ResumeLayout(False)
        Me.CMBillingTran.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.Tbl_Billing_Transactions_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.Tbl_Billing_TransactionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBillingVerify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Billing_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSBilling As FS_ERP_MM.DSBilling
    Friend WithEvents View_Billing_TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Billing_TransactionsTableAdapter As FS_ERP_MM.DSBillingTableAdapters.View_Billing_TransactionsTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PartyNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents InvoiceNoLabel2 As System.Windows.Forms.Label
    Friend WithEvents InvoiceDateLabel2 As System.Windows.Forms.Label
    Friend WithEvents RefNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TranIdLabel1 As System.Windows.Forms.Label
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
    Friend WithEvents VerifyStatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Tbl_Billing_Transactions_DetailTableAdapter As FS_ERP_MM.DSBillingTableAdapters.tbl_Billing_Transactions_DetailTableAdapter
    Friend WithEvents Tbl_Billing_Transactions_DetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSBillingTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator3 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Billing_TransactionsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DSBillingVerify As FS_ERP_MM.DSBillingVerify
    Friend WithEvents Tbl_Pur_POBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_POTableAdapter As FS_ERP_MM.DSBillingVerifyTableAdapters.tbl_Pur_POTableAdapter
    Friend WithEvents TableAdapterManager1 As FS_ERP_MM.DSBillingVerifyTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMBillingTran As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BillingNoTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerifyDateLabel As System.Windows.Forms.Label
    Friend WithEvents CMPartyName As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PartyNameText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
