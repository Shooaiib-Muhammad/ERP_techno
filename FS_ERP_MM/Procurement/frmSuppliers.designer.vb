<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim RegDateLabel As System.Windows.Forms.Label
        Dim PhoneNoLabel As System.Windows.Forms.Label
        Dim EmailAddLabel As System.Windows.Forms.Label
        Dim FaxNoLabel As System.Windows.Forms.Label
        Dim CountryIDLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim UpdateStatusLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel1 As System.Windows.Forms.Label
        Dim SupplierTypeLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuppliers))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CMSSupStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_inv_SupplierTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSupp = New FS_ERP_MM.DSSupp()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SaveSupplier = New System.Windows.Forms.ToolStripButton()
        Me.CountryNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Pro_CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateStatusMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
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
        Me.CompanyNameListBox = New System.Windows.Forms.ListBox()
        Me.Tbl_inv_SupplierTypeTableAdapter = New FS_ERP_MM.DSSuppTableAdapters.tbl_inv_SupplierTypeTableAdapter()
        Me.SupplierTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_Pro_CountryTableAdapter = New FS_ERP_MM.DSSuppTableAdapters.tbl_Pro_CountryTableAdapter()
        SupplierIDLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        ContactPersonLabel = New System.Windows.Forms.Label()
        RegDateLabel = New System.Windows.Forms.Label()
        PhoneNoLabel = New System.Windows.Forms.Label()
        EmailAddLabel = New System.Windows.Forms.Label()
        FaxNoLabel = New System.Windows.Forms.Label()
        CountryIDLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        UpdateStatusLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CompanyNameLabel1 = New System.Windows.Forms.Label()
        SupplierTypeLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.CMSSupStatus.SuspendLayout()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_inv_SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Pro_CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Location = New System.Drawing.Point(27, 38)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(100, 20)
        SupplierIDLabel.TabIndex = 0
        SupplierIDLabel.Text = "Supplier No:"
        SupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.Location = New System.Drawing.Point(27, 64)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(100, 20)
        CompanyNameLabel.TabIndex = 2
        CompanyNameLabel.Text = "Company Name:"
        CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.Location = New System.Drawing.Point(27, 90)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(100, 20)
        ContactPersonLabel.TabIndex = 4
        ContactPersonLabel.Text = "Contact Person:"
        ContactPersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RegDateLabel
        '
        RegDateLabel.Location = New System.Drawing.Point(27, 116)
        RegDateLabel.Name = "RegDateLabel"
        RegDateLabel.Size = New System.Drawing.Size(100, 20)
        RegDateLabel.TabIndex = 6
        RegDateLabel.Text = "Reg Date:"
        RegDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneNoLabel
        '
        PhoneNoLabel.Location = New System.Drawing.Point(27, 142)
        PhoneNoLabel.Name = "PhoneNoLabel"
        PhoneNoLabel.Size = New System.Drawing.Size(100, 20)
        PhoneNoLabel.TabIndex = 8
        PhoneNoLabel.Text = "Phone No:"
        PhoneNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailAddLabel
        '
        EmailAddLabel.Location = New System.Drawing.Point(27, 168)
        EmailAddLabel.Name = "EmailAddLabel"
        EmailAddLabel.Size = New System.Drawing.Size(100, 20)
        EmailAddLabel.TabIndex = 10
        EmailAddLabel.Text = "Email Add:"
        EmailAddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FaxNoLabel
        '
        FaxNoLabel.Location = New System.Drawing.Point(27, 194)
        FaxNoLabel.Name = "FaxNoLabel"
        FaxNoLabel.Size = New System.Drawing.Size(100, 20)
        FaxNoLabel.TabIndex = 12
        FaxNoLabel.Text = "Fax No:"
        FaxNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CountryIDLabel
        '
        CountryIDLabel.Location = New System.Drawing.Point(27, 220)
        CountryIDLabel.Name = "CountryIDLabel"
        CountryIDLabel.Size = New System.Drawing.Size(100, 20)
        CountryIDLabel.TabIndex = 14
        CountryIDLabel.Text = "Country:"
        CountryIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CityLabel
        '
        CityLabel.Location = New System.Drawing.Point(27, 246)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(100, 20)
        CityLabel.TabIndex = 16
        CityLabel.Text = "City:"
        CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UpdateStatusLabel
        '
        UpdateStatusLabel.Location = New System.Drawing.Point(156, 275)
        UpdateStatusLabel.Name = "UpdateStatusLabel"
        UpdateStatusLabel.Size = New System.Drawing.Size(81, 20)
        UpdateStatusLabel.TabIndex = 20
        UpdateStatusLabel.Text = "Update Status:"
        UpdateStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusLabel
        '
        StatusLabel.Location = New System.Drawing.Point(27, 275)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(100, 20)
        StatusLabel.TabIndex = 22
        StatusLabel.Text = "Status:"
        StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel1
        '
        CompanyNameLabel1.BackColor = System.Drawing.Color.LightGray
        CompanyNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        CompanyNameLabel1.Location = New System.Drawing.Point(12, 75)
        CompanyNameLabel1.Name = "CompanyNameLabel1"
        CompanyNameLabel1.Size = New System.Drawing.Size(250, 20)
        CompanyNameLabel1.TabIndex = 2
        CompanyNameLabel1.Text = "Select Supplier To View Details"
        CompanyNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SupplierTypeLabel
        '
        SupplierTypeLabel.Location = New System.Drawing.Point(12, 47)
        SupplierTypeLabel.Name = "SupplierTypeLabel"
        SupplierTypeLabel.Size = New System.Drawing.Size(90, 20)
        SupplierTypeLabel.TabIndex = 6
        SupplierTypeLabel.Text = "Supplier Type:"
        SupplierTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(27, 295)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 20)
        Label2.TabIndex = 25
        Label2.Text = "TM Status:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.CountryNameComboBox)
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
        Me.Panel1.Controls.Add(CountryIDLabel)
        Me.Panel1.Controls.Add(CityLabel)
        Me.Panel1.Controls.Add(Me.CityTextBox)
        Me.Panel1.Location = New System.Drawing.Point(265, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 323)
        Me.Panel1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.ContextMenuStrip = Me.CMSSupStatus
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Inv_SupplierBindingSource, "TMStatus", True))
        Me.CheckBox1.Location = New System.Drawing.Point(133, 295)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(17, 20)
        Me.CheckBox1.TabIndex = 24
        '
        'CMSSupStatus
        '
        Me.CMSSupStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.CMSSupStatus.Name = "ContextMenuStrip1"
        Me.CMSSupStatus.Size = New System.Drawing.Size(185, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem1.Text = "&Active Suppliers"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem2.Text = "&Non Active Suppliers"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem3.Text = "All &Suppliers"
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_inv_SupplierType_tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.Tbl_inv_SupplierTypeBindingSource
        '
        'Tbl_inv_SupplierTypeBindingSource
        '
        Me.Tbl_inv_SupplierTypeBindingSource.DataMember = "tbl_inv_SupplierType"
        Me.Tbl_inv_SupplierTypeBindingSource.DataSource = Me.DSSupp
        '
        'DSSupp
        '
        Me.DSSupp.DataSetName = "DSSupp"
        Me.DSSupp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_SupplierBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.SaveSupplier})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(467, 25)
        Me.BindingNavigator1.TabIndex = 23
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'SaveSupplier
        '
        Me.SaveSupplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveSupplier.Image = CType(resources.GetObject("SaveSupplier.Image"), System.Drawing.Image)
        Me.SaveSupplier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveSupplier.Name = "SaveSupplier"
        Me.SaveSupplier.Size = New System.Drawing.Size(23, 22)
        Me.SaveSupplier.Text = "&Save"
        '
        'CountryNameComboBox
        '
        Me.CountryNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CountryNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CountryNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_SupplierBindingSource, "CountryID", True))
        Me.CountryNameComboBox.DataSource = Me.Tbl_Pro_CountryBindingSource
        Me.CountryNameComboBox.DisplayMember = "CountryName"
        Me.CountryNameComboBox.FormattingEnabled = True
        Me.CountryNameComboBox.Location = New System.Drawing.Point(133, 219)
        Me.CountryNameComboBox.Name = "CountryNameComboBox"
        Me.CountryNameComboBox.Size = New System.Drawing.Size(213, 21)
        Me.CountryNameComboBox.TabIndex = 8
        Me.CountryNameComboBox.ValueMember = "CountryID"
        '
        'Tbl_Pro_CountryBindingSource
        '
        Me.Tbl_Pro_CountryBindingSource.DataMember = "tbl_Pro_Country"
        Me.Tbl_Pro_CountryBindingSource.DataSource = Me.DSSupp
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.ContextMenuStrip = Me.CMSSupStatus
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Inv_SupplierBindingSource, "Status", True))
        Me.StatusCheckBox.Location = New System.Drawing.Point(133, 275)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(17, 20)
        Me.StatusCheckBox.TabIndex = 10
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.CausesValidation = False
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "SupplierID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(133, 38)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SupplierIDTextBox.TabIndex = 1
        Me.SupplierIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UpdateStatusMaskedTextBox
        '
        Me.UpdateStatusMaskedTextBox.CausesValidation = False
        Me.UpdateStatusMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "UpdateStatus", True))
        Me.UpdateStatusMaskedTextBox.Location = New System.Drawing.Point(242, 275)
        Me.UpdateStatusMaskedTextBox.Mask = "00/00/00"
        Me.UpdateStatusMaskedTextBox.Name = "UpdateStatusMaskedTextBox"
        Me.UpdateStatusMaskedTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UpdateStatusMaskedTextBox.TabIndex = 11
        Me.UpdateStatusMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.CausesValidation = False
        Me.CompanyNameTextBox.ContextMenuStrip = Me.SupplierContextMenuStrip
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(133, 64)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(300, 20)
        Me.CompanyNameTextBox.TabIndex = 2
        '
        'SupplierContextMenuStrip
        '
        Me.SupplierContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.RemoveFilterToolStripMenuItem, Me.AscendingOrderToolStripMenuItem, Me.DescendingOrderToolStripMenuItem, Me.RemoveOrderToolStripMenuItem})
        Me.SupplierContextMenuStrip.Name = "SupplierContextMenuStrip"
        Me.SupplierContextMenuStrip.Size = New System.Drawing.Size(170, 117)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.ForeColor = System.Drawing.Color.Silver
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "Enter Company Name"
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
        Me.ContactPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "ContactPerson", True))
        Me.ContactPersonTextBox.Location = New System.Drawing.Point(133, 90)
        Me.ContactPersonTextBox.Name = "ContactPersonTextBox"
        Me.ContactPersonTextBox.Size = New System.Drawing.Size(300, 20)
        Me.ContactPersonTextBox.TabIndex = 3
        '
        'RegDateMaskedTextBox
        '
        Me.RegDateMaskedTextBox.CausesValidation = False
        Me.RegDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "RegDate", True))
        Me.RegDateMaskedTextBox.Location = New System.Drawing.Point(133, 116)
        Me.RegDateMaskedTextBox.Mask = "00/00/00"
        Me.RegDateMaskedTextBox.Name = "RegDateMaskedTextBox"
        Me.RegDateMaskedTextBox.Size = New System.Drawing.Size(104, 20)
        Me.RegDateMaskedTextBox.TabIndex = 4
        Me.RegDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhoneNoTextBox
        '
        Me.PhoneNoTextBox.CausesValidation = False
        Me.PhoneNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "PhoneNo", True))
        Me.PhoneNoTextBox.Location = New System.Drawing.Point(133, 142)
        Me.PhoneNoTextBox.Name = "PhoneNoTextBox"
        Me.PhoneNoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PhoneNoTextBox.TabIndex = 5
        Me.PhoneNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmailAddTextBox
        '
        Me.EmailAddTextBox.CausesValidation = False
        Me.EmailAddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "EmailAdd", True))
        Me.EmailAddTextBox.Location = New System.Drawing.Point(133, 168)
        Me.EmailAddTextBox.Name = "EmailAddTextBox"
        Me.EmailAddTextBox.Size = New System.Drawing.Size(300, 20)
        Me.EmailAddTextBox.TabIndex = 6
        '
        'FaxNoTextBox
        '
        Me.FaxNoTextBox.CausesValidation = False
        Me.FaxNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "FaxNo", True))
        Me.FaxNoTextBox.Location = New System.Drawing.Point(133, 194)
        Me.FaxNoTextBox.Name = "FaxNoTextBox"
        Me.FaxNoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.FaxNoTextBox.TabIndex = 7
        Me.FaxNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CityTextBox
        '
        Me.CityTextBox.CausesValidation = False
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_SupplierBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(133, 246)
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
        Me.Label1.Size = New System.Drawing.Size(792, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage Suppliers Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompanyNameListBox
        '
        Me.CompanyNameListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_SupplierBindingSource, "SupplierID", True))
        Me.CompanyNameListBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.CompanyNameListBox.DisplayMember = "CompanyName"
        Me.CompanyNameListBox.FormattingEnabled = True
        Me.CompanyNameListBox.Location = New System.Drawing.Point(12, 98)
        Me.CompanyNameListBox.Name = "CompanyNameListBox"
        Me.CompanyNameListBox.Size = New System.Drawing.Size(250, 550)
        Me.CompanyNameListBox.TabIndex = 3
        Me.CompanyNameListBox.ValueMember = "SupplierID"
        '
        'Tbl_inv_SupplierTypeTableAdapter
        '
        Me.Tbl_inv_SupplierTypeTableAdapter.ClearBeforeFill = True
        '
        'SupplierTypeComboBox
        '
        Me.SupplierTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierTypeComboBox.DataSource = Me.Tbl_inv_SupplierTypeBindingSource
        Me.SupplierTypeComboBox.DisplayMember = "SupplierType"
        Me.SupplierTypeComboBox.FormattingEnabled = True
        Me.SupplierTypeComboBox.Location = New System.Drawing.Point(108, 46)
        Me.SupplierTypeComboBox.Name = "SupplierTypeComboBox"
        Me.SupplierTypeComboBox.Size = New System.Drawing.Size(154, 21)
        Me.SupplierTypeComboBox.TabIndex = 7
        Me.SupplierTypeComboBox.ValueMember = "SupplierTypeID"
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pro_CountryTableAdapter
        '
        Me.Tbl_Pro_CountryTableAdapter.ClearBeforeFill = True
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 733)
        Me.Controls.Add(SupplierTypeLabel)
        Me.Controls.Add(Me.SupplierTypeComboBox)
        Me.Controls.Add(Me.CompanyNameListBox)
        Me.Controls.Add(CompanyNameLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSuppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suppliers Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CMSSupStatus.ResumeLayout(False)
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_inv_SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSupp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Pro_CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierContextMenuStrip.ResumeLayout(False)
        Me.SupplierContextMenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DSSupp As FS_ERP_MM.DSSupp
    Friend WithEvents SupplierIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PhoneNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateStatusMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents StatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CountryNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CompanyNameListBox As System.Windows.Forms.ListBox
    Friend WithEvents SupplierContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tbl_inv_SupplierTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_inv_SupplierTypeTableAdapter As FS_ERP_MM.DSSuppTableAdapters.tbl_inv_SupplierTypeTableAdapter
    Friend WithEvents SupplierTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SaveSupplier As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Pro_CountryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pro_CountryTableAdapter As FS_ERP_MM.DSSuppTableAdapters.tbl_Pro_CountryTableAdapter
    Friend WithEvents CMSSupStatus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
End Class
