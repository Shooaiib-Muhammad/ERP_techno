<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim UpdateStatusLabel As System.Windows.Forms.Label
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim RegDateLabel As System.Windows.Forms.Label
        Dim PhoneNoLabel As System.Windows.Forms.Label
        Dim EmailAddLabel As System.Windows.Forms.Label
        Dim FaxNoLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim ManfCustStatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Tbl_MM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCust = New FS_ERP_MM.DSCust()
        Me.ManfCustStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.CustAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_MM_CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.CMSCustStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateStatusMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CustomerTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactPersonTextBox = New System.Windows.Forms.TextBox()
        Me.RegDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PhoneNoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddTextBox = New System.Windows.Forms.TextBox()
        Me.FaxNoTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_MM_CustomerTableAdapter = New FS_ERP_MM.DSCustTableAdapters.tbl_MM_CustomerTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSCustTableAdapters.TableAdapterManager()
        Me.CompanyNameListBox = New System.Windows.Forms.ListBox()
        SupplierIDLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        UpdateStatusLabel = New System.Windows.Forms.Label()
        ContactPersonLabel = New System.Windows.Forms.Label()
        RegDateLabel = New System.Windows.Forms.Label()
        PhoneNoLabel = New System.Windows.Forms.Label()
        EmailAddLabel = New System.Windows.Forms.Label()
        FaxNoLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CompanyNameLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        ManfCustStatusLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_MM_CustomerBindingNavigator.SuspendLayout()
        Me.CMSCustStatus.SuspendLayout()
        Me.CustomerContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Location = New System.Drawing.Point(8, 36)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(100, 20)
        SupplierIDLabel.TabIndex = 0
        SupplierIDLabel.Text = "Supplier No:"
        SupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusLabel
        '
        StatusLabel.Location = New System.Drawing.Point(8, 263)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(100, 20)
        StatusLabel.TabIndex = 22
        StatusLabel.Text = "Status:"
        StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.Location = New System.Drawing.Point(8, 61)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(100, 20)
        CompanyNameLabel.TabIndex = 2
        CompanyNameLabel.Text = "Company Name:"
        CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UpdateStatusLabel
        '
        UpdateStatusLabel.Location = New System.Drawing.Point(132, 263)
        UpdateStatusLabel.Name = "UpdateStatusLabel"
        UpdateStatusLabel.Size = New System.Drawing.Size(81, 20)
        UpdateStatusLabel.TabIndex = 20
        UpdateStatusLabel.Text = "Update Status:"
        UpdateStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.Location = New System.Drawing.Point(8, 86)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(100, 20)
        ContactPersonLabel.TabIndex = 4
        ContactPersonLabel.Text = "Contact Person:"
        ContactPersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RegDateLabel
        '
        RegDateLabel.Location = New System.Drawing.Point(8, 134)
        RegDateLabel.Name = "RegDateLabel"
        RegDateLabel.Size = New System.Drawing.Size(100, 20)
        RegDateLabel.TabIndex = 6
        RegDateLabel.Text = "Reg Date:"
        RegDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneNoLabel
        '
        PhoneNoLabel.Location = New System.Drawing.Point(8, 160)
        PhoneNoLabel.Name = "PhoneNoLabel"
        PhoneNoLabel.Size = New System.Drawing.Size(100, 20)
        PhoneNoLabel.TabIndex = 8
        PhoneNoLabel.Text = "Phone No:"
        PhoneNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailAddLabel
        '
        EmailAddLabel.Location = New System.Drawing.Point(8, 186)
        EmailAddLabel.Name = "EmailAddLabel"
        EmailAddLabel.Size = New System.Drawing.Size(100, 20)
        EmailAddLabel.TabIndex = 10
        EmailAddLabel.Text = "Email Add:"
        EmailAddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FaxNoLabel
        '
        FaxNoLabel.Location = New System.Drawing.Point(8, 211)
        FaxNoLabel.Name = "FaxNoLabel"
        FaxNoLabel.Size = New System.Drawing.Size(100, 20)
        FaxNoLabel.TabIndex = 12
        FaxNoLabel.Text = "Fax No:"
        FaxNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CityLabel
        '
        CityLabel.Location = New System.Drawing.Point(8, 235)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(100, 20)
        CityLabel.TabIndex = 16
        CityLabel.Text = "City:"
        CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel1
        '
        CompanyNameLabel1.BackColor = System.Drawing.Color.RoyalBlue
        CompanyNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        CompanyNameLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CompanyNameLabel1.Location = New System.Drawing.Point(8, 53)
        CompanyNameLabel1.Name = "CompanyNameLabel1"
        CompanyNameLabel1.Size = New System.Drawing.Size(235, 20)
        CompanyNameLabel1.TabIndex = 4
        CompanyNameLabel1.Text = "Select Customer To View Details"
        CompanyNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(8, 110)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 20)
        Label2.TabIndex = 24
        Label2.Text = "Customer Address:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ManfCustStatusLabel
        '
        ManfCustStatusLabel.Location = New System.Drawing.Point(8, 286)
        ManfCustStatusLabel.Name = "ManfCustStatusLabel"
        ManfCustStatusLabel.Size = New System.Drawing.Size(100, 20)
        ManfCustStatusLabel.TabIndex = 24
        ManfCustStatusLabel.Text = "Manf. Cust. Status:"
        ManfCustStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(ManfCustStatusLabel)
        Me.Panel1.Controls.Add(Me.ManfCustStatusCheckBox)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.CustAddressTextBox)
        Me.Panel1.Controls.Add(Me.Tbl_MM_CustomerBindingNavigator)
        Me.Panel1.Controls.Add(SupplierIDLabel)
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(Me.StatusCheckBox)
        Me.Panel1.Controls.Add(Me.SupplierIDTextBox)
        Me.Panel1.Controls.Add(Me.UpdateStatusMaskedTextBox)
        Me.Panel1.Controls.Add(CompanyNameLabel)
        Me.Panel1.Controls.Add(UpdateStatusLabel)
        Me.Panel1.Controls.Add(Me.CompanyNameTextBox)
        Me.Panel1.Controls.Add(ContactPersonLabel)
        Me.Panel1.Controls.Add(Me.ContactPersonTextBox)
        Me.Panel1.Controls.Add(RegDateLabel)
        Me.Panel1.Controls.Add(Me.RegDateMaskedTextBox)
        Me.Panel1.Controls.Add(PhoneNoLabel)
        Me.Panel1.Controls.Add(Me.PhoneNoTextBox)
        Me.Panel1.Controls.Add(EmailAddLabel)
        Me.Panel1.Controls.Add(Me.EmailAddTextBox)
        Me.Panel1.Controls.Add(FaxNoLabel)
        Me.Panel1.Controls.Add(Me.FaxNoTextBox)
        Me.Panel1.Controls.Add(CityLabel)
        Me.Panel1.Controls.Add(Me.CityTextBox)
        Me.Panel1.Location = New System.Drawing.Point(246, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 363)
        Me.Panel1.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_MM_CustomerBindingSource, "PurchaseStatus", True))
        Me.CheckBox1.Location = New System.Drawing.Point(11, 309)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(111, 18)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "Purchase Status:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Tbl_MM_CustomerBindingSource
        '
        Me.Tbl_MM_CustomerBindingSource.DataMember = "tbl_MM_Customer"
        Me.Tbl_MM_CustomerBindingSource.DataSource = Me.DsCust
        '
        'DsCust
        '
        Me.DsCust.DataSetName = "DsCust"
        Me.DsCust.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ManfCustStatusCheckBox
        '
        Me.ManfCustStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_MM_CustomerBindingSource, "ManfCustStatus", True))
        Me.ManfCustStatusCheckBox.Location = New System.Drawing.Point(109, 288)
        Me.ManfCustStatusCheckBox.Name = "ManfCustStatusCheckBox"
        Me.ManfCustStatusCheckBox.Size = New System.Drawing.Size(17, 18)
        Me.ManfCustStatusCheckBox.TabIndex = 25
        Me.ManfCustStatusCheckBox.UseVisualStyleBackColor = True
        '
        'CustAddressTextBox
        '
        Me.CustAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "CustAddress", True))
        Me.CustAddressTextBox.Location = New System.Drawing.Point(109, 110)
        Me.CustAddressTextBox.Name = "CustAddressTextBox"
        Me.CustAddressTextBox.Size = New System.Drawing.Size(300, 20)
        Me.CustAddressTextBox.TabIndex = 23
        '
        'Tbl_MM_CustomerBindingNavigator
        '
        Me.Tbl_MM_CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_MM_CustomerBindingNavigator.BindingSource = Me.Tbl_MM_CustomerBindingSource
        Me.Tbl_MM_CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_MM_CustomerBindingNavigator.DeleteItem = Nothing
        Me.Tbl_MM_CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_MM_CustomerBindingNavigatorSaveItem})
        Me.Tbl_MM_CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_MM_CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_MM_CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_MM_CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_MM_CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_MM_CustomerBindingNavigator.Name = "Tbl_MM_CustomerBindingNavigator"
        Me.Tbl_MM_CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_MM_CustomerBindingNavigator.Size = New System.Drawing.Size(453, 25)
        Me.Tbl_MM_CustomerBindingNavigator.TabIndex = 3
        Me.Tbl_MM_CustomerBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_MM_CustomerBindingNavigatorSaveItem
        '
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_MM_CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.Name = "Tbl_MM_CustomerBindingNavigatorSaveItem"
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_MM_CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.ContextMenuStrip = Me.CMSCustStatus
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_MM_CustomerBindingSource, "Status", True))
        Me.StatusCheckBox.Location = New System.Drawing.Point(109, 263)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(17, 20)
        Me.StatusCheckBox.TabIndex = 10
        '
        'CMSCustStatus
        '
        Me.CMSCustStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.CMSCustStatus.Name = "ContextMenuStrip1"
        Me.CMSCustStatus.Size = New System.Drawing.Size(194, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripMenuItem1.Text = "&Active Customers"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripMenuItem2.Text = "&Non Active Customers"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripMenuItem3.Text = "All &Customers"
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.CausesValidation = False
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "CustID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(109, 36)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SupplierIDTextBox.TabIndex = 1
        Me.SupplierIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UpdateStatusMaskedTextBox
        '
        Me.UpdateStatusMaskedTextBox.CausesValidation = False
        Me.UpdateStatusMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "UpdateStatus", True))
        Me.UpdateStatusMaskedTextBox.Location = New System.Drawing.Point(218, 263)
        Me.UpdateStatusMaskedTextBox.Mask = "00/00/00"
        Me.UpdateStatusMaskedTextBox.Name = "UpdateStatusMaskedTextBox"
        Me.UpdateStatusMaskedTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UpdateStatusMaskedTextBox.TabIndex = 11
        Me.UpdateStatusMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.CausesValidation = False
        Me.CompanyNameTextBox.ContextMenuStrip = Me.CustomerContextMenuStrip
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(109, 61)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(300, 20)
        Me.CompanyNameTextBox.TabIndex = 2
        '
        'CustomerContextMenuStrip
        '
        Me.CustomerContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerTextBox, Me.RemoveFilterToolStripMenuItem, Me.AscendingOrderToolStripMenuItem, Me.DescendingOrderToolStripMenuItem, Me.RemoveOrderToolStripMenuItem})
        Me.CustomerContextMenuStrip.Name = "SupplierContextMenuStrip"
        Me.CustomerContextMenuStrip.Size = New System.Drawing.Size(170, 117)
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CustomerTextBox.Text = "Enter Customer Name"
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
        'ContactPersonTextBox
        '
        Me.ContactPersonTextBox.CausesValidation = False
        Me.ContactPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "ContactPerson", True))
        Me.ContactPersonTextBox.Location = New System.Drawing.Point(109, 86)
        Me.ContactPersonTextBox.Name = "ContactPersonTextBox"
        Me.ContactPersonTextBox.Size = New System.Drawing.Size(300, 20)
        Me.ContactPersonTextBox.TabIndex = 3
        '
        'RegDateMaskedTextBox
        '
        Me.RegDateMaskedTextBox.CausesValidation = False
        Me.RegDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "RegDate", True))
        Me.RegDateMaskedTextBox.Location = New System.Drawing.Point(109, 134)
        Me.RegDateMaskedTextBox.Mask = "00/00/00"
        Me.RegDateMaskedTextBox.Name = "RegDateMaskedTextBox"
        Me.RegDateMaskedTextBox.Size = New System.Drawing.Size(104, 20)
        Me.RegDateMaskedTextBox.TabIndex = 4
        Me.RegDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhoneNoTextBox
        '
        Me.PhoneNoTextBox.CausesValidation = False
        Me.PhoneNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "PhoneNo", True))
        Me.PhoneNoTextBox.Location = New System.Drawing.Point(109, 160)
        Me.PhoneNoTextBox.Name = "PhoneNoTextBox"
        Me.PhoneNoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PhoneNoTextBox.TabIndex = 5
        Me.PhoneNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmailAddTextBox
        '
        Me.EmailAddTextBox.CausesValidation = False
        Me.EmailAddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "EmailAdd", True))
        Me.EmailAddTextBox.Location = New System.Drawing.Point(109, 186)
        Me.EmailAddTextBox.Name = "EmailAddTextBox"
        Me.EmailAddTextBox.Size = New System.Drawing.Size(300, 20)
        Me.EmailAddTextBox.TabIndex = 6
        '
        'FaxNoTextBox
        '
        Me.FaxNoTextBox.CausesValidation = False
        Me.FaxNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "FaxNo", True))
        Me.FaxNoTextBox.Location = New System.Drawing.Point(109, 211)
        Me.FaxNoTextBox.Name = "FaxNoTextBox"
        Me.FaxNoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.FaxNoTextBox.TabIndex = 7
        Me.FaxNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CityTextBox
        '
        Me.CityTextBox.CausesValidation = False
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_CustomerBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(109, 235)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(213, 20)
        Me.CityTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(802, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customers Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_MM_CustomerTableAdapter
        '
        Me.Tbl_MM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_MM_CustomerTableAdapter = Me.Tbl_MM_CustomerTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSCustTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompanyNameListBox
        '
        Me.CompanyNameListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_MM_CustomerBindingSource, "CustID", True))
        Me.CompanyNameListBox.DataSource = Me.Tbl_MM_CustomerBindingSource
        Me.CompanyNameListBox.DisplayMember = "CompanyName"
        Me.CompanyNameListBox.FormattingEnabled = True
        Me.CompanyNameListBox.Location = New System.Drawing.Point(8, 74)
        Me.CompanyNameListBox.Name = "CompanyNameListBox"
        Me.CompanyNameListBox.Size = New System.Drawing.Size(235, 342)
        Me.CompanyNameListBox.TabIndex = 3
        Me.CompanyNameListBox.ValueMember = "CustID"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 486)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CompanyNameLabel1)
        Me.Controls.Add(Me.CompanyNameListBox)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCustomer"
        Me.Text = "Customers Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_MM_CustomerBindingNavigator.ResumeLayout(False)
        Me.Tbl_MM_CustomerBindingNavigator.PerformLayout()
        Me.CMSCustStatus.ResumeLayout(False)
        Me.CustomerContextMenuStrip.ResumeLayout(False)
        Me.CustomerContextMenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SupplierIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateStatusMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CompanyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PhoneNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DsCust As FS_ERP_MM.DsCust
    Friend WithEvents Tbl_MM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_CustomerTableAdapter As FS_ERP_MM.DsCustTableAdapters.tbl_MM_CustomerTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DsCustTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_MM_CustomerBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_MM_CustomerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CompanyNameListBox As System.Windows.Forms.ListBox
    Friend WithEvents CustomerContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CustomerTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManfCustStatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CMSCustStatus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
