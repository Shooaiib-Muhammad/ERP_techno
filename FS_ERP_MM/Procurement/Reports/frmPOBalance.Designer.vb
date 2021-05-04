<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOBalance
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
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim POIDLabel1 As System.Windows.Forms.Label
        Dim POIDLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton10 = New System.Windows.Forms.RadioButton
        Me.RadioButton9 = New System.Windows.Forms.RadioButton
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.btnShowReport = New System.Windows.Forms.Button
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_inv_SupplierTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSupp = New FS_ERP_MM.DSSupp
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.POGroup = New System.Windows.Forms.GroupBox
        Me.SupplierTypeComboBox = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Tbl_Inv_Supplier1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POIDComboBox2 = New System.Windows.Forms.ComboBox
        Me.Tbl_Pur_POBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPO = New FS_ERP_MM.DSPO
        Me.POIDComboBox1 = New System.Windows.Forms.ComboBox
        Me.Tbl_Pur_PO1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_L4TableAdapter
        Me.Tbl_Pur_POTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_POTableAdapter
        Me.TableAdapterManager = New FS_ERP_MM.DSPOTableAdapters.TableAdapterManager
        Me.Tbl_Pur_PO1TableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_PO1TableAdapter
        Me.Tbl_inv_SupplierTypeTableAdapter = New FS_ERP_MM.DSSuppTableAdapters.tbl_inv_SupplierTypeTableAdapter
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_SupplierTableAdapter
        Me.Tbl_Inv_Supplier1TableAdapter = New FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_Supplier1TableAdapter
        CompanyNameLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        POIDLabel1 = New System.Windows.Forms.Label
        POIDLabel = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_inv_SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.POGroup.SuspendLayout()
        CType(Me.Tbl_Inv_Supplier1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_PO1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.Location = New System.Drawing.Point(8, 175)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(100, 20)
        CompanyNameLabel.TabIndex = 0
        CompanyNameLabel.Text = "Company Name:"
        CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(8, 145)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 20)
        Label2.TabIndex = 5
        Label2.Text = "2nd Date:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(8, 118)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(100, 20)
        Label3.TabIndex = 4
        Label3.Text = "1st Date:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POIDLabel1
        '
        POIDLabel1.Location = New System.Drawing.Point(8, 79)
        POIDLabel1.Name = "POIDLabel1"
        POIDLabel1.Size = New System.Drawing.Size(100, 20)
        POIDLabel1.TabIndex = 2
        POIDLabel1.Text = "PO No:"
        POIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POIDLabel
        '
        POIDLabel.Location = New System.Drawing.Point(8, 52)
        POIDLabel.Name = "POIDLabel"
        POIDLabel.Size = New System.Drawing.Size(100, 20)
        POIDLabel.TabIndex = 0
        POIDLabel.Text = "PO No:"
        POIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(8, 227)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 20)
        Label4.TabIndex = 15
        Label4.Text = "Material Name:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(8, 200)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(100, 20)
        Label6.TabIndex = 16
        Label6.Text = "Company Name:"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(8, 26)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(100, 20)
        Label7.TabIndex = 19
        Label7.Text = "Suplier Type:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton10)
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 328)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selection"
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(7, 242)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton10.TabIndex = 19
        Me.RadioButton10.Text = "Supplier List"
        Me.RadioButton10.UseVisualStyleBackColor = True
        Me.RadioButton10.Visible = False
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(7, 107)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(277, 17)
        Me.RadioButton9.TabIndex = 18
        Me.RadioButton9.Text = "PO Balance by Supplier ,Required Date And  Material"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(7, 219)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(153, 17)
        Me.RadioButton8.TabIndex = 17
        Me.RadioButton8.Text = "Supplier PO Pending Detail"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(7, 197)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(252, 17)
        Me.RadioButton7.TabIndex = 16
        Me.RadioButton7.Text = "PO Summary by Order Date And Supplier Name "
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(248, 60)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Check State"
        Me.CheckBox1.ThreeState = True
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(7, 174)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(136, 17)
        Me.RadioButton6.TabIndex = 14
        Me.RadioButton6.Text = "PO Balance by Material"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(110, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 41)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Check State On for Non Zero Balance POs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Checked State Off for Zero Balance POs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            "In Intermediate State for All POs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(7, 151)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(151, 17)
        Me.RadioButton5.TabIndex = 13
        Me.RadioButton5.Text = "PO Balance by Order Date"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(7, 128)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(168, 17)
        Me.RadioButton4.TabIndex = 12
        Me.RadioButton4.Text = "PO Balance by Required Date"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 64)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.Text = "PO Balance PO Wise"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 87)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(137, 17)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.Text = "PO Balance by Supplier"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 41)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(96, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "PO Balance All"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnShowReport
        '
        Me.btnShowReport.Location = New System.Drawing.Point(204, 275)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(90, 47)
        Me.btnShowReport.TabIndex = 8
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.CompanyNameComboBox.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox.Enabled = False
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(112, 174)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.CompanyNameComboBox.TabIndex = 7
        Me.CompanyNameComboBox.ValueMember = "SupplierID"
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
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(112, 145)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker2.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 118)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'POGroup
        '
        Me.POGroup.Controls.Add(Label7)
        Me.POGroup.Controls.Add(Me.SupplierTypeComboBox)
        Me.POGroup.Controls.Add(Label6)
        Me.POGroup.Controls.Add(Me.ComboBox1)
        Me.POGroup.Controls.Add(Label4)
        Me.POGroup.Controls.Add(Me.L4NameComboBox)
        Me.POGroup.Controls.Add(CompanyNameLabel)
        Me.POGroup.Controls.Add(Me.CompanyNameComboBox)
        Me.POGroup.Controls.Add(Label2)
        Me.POGroup.Controls.Add(POIDLabel1)
        Me.POGroup.Controls.Add(Me.DateTimePicker2)
        Me.POGroup.Controls.Add(Me.btnShowReport)
        Me.POGroup.Controls.Add(Me.POIDComboBox2)
        Me.POGroup.Controls.Add(Label3)
        Me.POGroup.Controls.Add(Me.DateTimePicker1)
        Me.POGroup.Controls.Add(Me.POIDComboBox1)
        Me.POGroup.Controls.Add(POIDLabel)
        Me.POGroup.Location = New System.Drawing.Point(405, 55)
        Me.POGroup.Name = "POGroup"
        Me.POGroup.Size = New System.Drawing.Size(338, 328)
        Me.POGroup.TabIndex = 7
        Me.POGroup.TabStop = False
        Me.POGroup.Text = "PO Range Selection"
        '
        'SupplierTypeComboBox
        '
        Me.SupplierTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierTypeComboBox.DataSource = Me.Tbl_inv_SupplierTypeBindingSource
        Me.SupplierTypeComboBox.DisplayMember = "SupplierType"
        Me.SupplierTypeComboBox.FormattingEnabled = True
        Me.SupplierTypeComboBox.Location = New System.Drawing.Point(114, 25)
        Me.SupplierTypeComboBox.Name = "SupplierTypeComboBox"
        Me.SupplierTypeComboBox.Size = New System.Drawing.Size(119, 21)
        Me.SupplierTypeComboBox.TabIndex = 18
        Me.SupplierTypeComboBox.ValueMember = "SupplierTypeID"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_Inv_Supplier1BindingSource
        Me.ComboBox1.DisplayMember = "CompanyName"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(112, 199)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.ValueMember = "SupplierID"
        '
        'Tbl_Inv_Supplier1BindingSource
        '
        Me.Tbl_Inv_Supplier1BindingSource.DataMember = "tbl_inv_SupplierType_tbl_Inv_Supplier1"
        Me.Tbl_Inv_Supplier1BindingSource.DataSource = Me.Tbl_inv_SupplierTypeBindingSource
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(112, 226)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.L4NameComboBox.TabIndex = 14
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSSupp
        '
        'POIDComboBox2
        '
        Me.POIDComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.POIDComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POIDComboBox2.DataSource = Me.Tbl_Pur_POBindingSource
        Me.POIDComboBox2.DisplayMember = "POID"
        Me.POIDComboBox2.Enabled = False
        Me.POIDComboBox2.FormattingEnabled = True
        Me.POIDComboBox2.Location = New System.Drawing.Point(112, 51)
        Me.POIDComboBox2.Name = "POIDComboBox2"
        Me.POIDComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.POIDComboBox2.TabIndex = 11
        Me.POIDComboBox2.ValueMember = "POID"
        '
        'Tbl_Pur_POBindingSource
        '
        Me.Tbl_Pur_POBindingSource.DataMember = "tbl_Pur_PO"
        Me.Tbl_Pur_POBindingSource.DataSource = Me.DSPO
        '
        'DSPO
        '
        Me.DSPO.DataSetName = "DSPO"
        Me.DSPO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'POIDComboBox1
        '
        Me.POIDComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.POIDComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POIDComboBox1.DataSource = Me.Tbl_Pur_PO1BindingSource
        Me.POIDComboBox1.DisplayMember = "POID"
        Me.POIDComboBox1.Enabled = False
        Me.POIDComboBox1.FormattingEnabled = True
        Me.POIDComboBox1.Location = New System.Drawing.Point(112, 78)
        Me.POIDComboBox1.Name = "POIDComboBox1"
        Me.POIDComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.POIDComboBox1.TabIndex = 4
        Me.POIDComboBox1.ValueMember = "POID"
        '
        'Tbl_Pur_PO1BindingSource
        '
        Me.Tbl_Pur_PO1BindingSource.DataMember = "tbl_Pur_PO1"
        Me.Tbl_Pur_PO1BindingSource.DataSource = Me.DSPO
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(810, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Purchase Order Balance Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_POTableAdapter
        '
        Me.Tbl_Pur_POTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_CodeTableAdapter = Nothing
        'Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_LocalCust1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_LocalCustTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_Demand_Head1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_Demand_HeadTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_Demand_PeriorityTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_DemandTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_PartialReceivingTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_PO_DTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_PO1TableAdapter = Me.Tbl_Pur_PO1TableAdapter
        Me.TableAdapterManager.tbl_Pur_POTableAdapter = Me.Tbl_Pur_POTableAdapter
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSPOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Pur_PO1TableAdapter
        '
        Me.Tbl_Pur_PO1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_inv_SupplierTypeTableAdapter
        '
        Me.Tbl_inv_SupplierTypeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Supplier1TableAdapter
        '
        Me.Tbl_Inv_Supplier1TableAdapter.ClearBeforeFill = True
        '
        'frmPOBalance
        '
        Me.AcceptButton = Me.btnShowReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 414)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.POGroup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPOBalance"
        Me.Text = "frmPOBalance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_inv_SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.POGroup.ResumeLayout(False)
        CType(Me.Tbl_Inv_Supplier1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_PO1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnShowReport As System.Windows.Forms.Button
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents POGroup As System.Windows.Forms.GroupBox
    Friend WithEvents POIDComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSPO As FS_ERP_MM.DSPO
    Friend WithEvents DSSupp As FS_ERP_MM.DSSupp
    Friend WithEvents POIDComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Pur_POBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_POTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_POTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSPOTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Pur_PO1TableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_PO1TableAdapter
    Friend WithEvents Tbl_Pur_PO1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_inv_SupplierTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_inv_SupplierTypeTableAdapter As FS_ERP_MM.DSSuppTableAdapters.tbl_inv_SupplierTypeTableAdapter
    Friend WithEvents SupplierTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents Tbl_Inv_Supplier1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Supplier1TableAdapter As FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_Supplier1TableAdapter
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
End Class
