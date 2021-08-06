<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGP
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
        Dim PurposeLabel As System.Windows.Forms.Label
        Dim CarryingPersonLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim EnteryDateLabel As System.Windows.Forms.Label
        Dim GMNoLabel As System.Windows.Forms.Label
        Dim LocalCustIDLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGP))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Mat_GatePassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSLocalPur = New FS_ERP_MM.DSLocalPur()
        Me.Tbl_GP_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PurposeTextBox = New System.Windows.Forms.TextBox()
        Me.CarryingPersonTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GMNoLabel4 = New System.Windows.Forms.Label()
        Me.EnteryDateLabel1 = New System.Windows.Forms.Label()
        Me.LocalCustIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Mat_GatePass_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.PDID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Mat_ItemsLayer4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Mat_MeasurementUnitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HODStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EnteryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_Mat_GatePass_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PreparedDeptID = New System.Windows.Forms.TextBox()
        Me.PreparedByTextBox = New System.Windows.Forms.TextBox()
        Me.FilterByGDNo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FilterByGDNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalCustIDLabel2 = New System.Windows.Forms.Label()
        Me.View_userDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Mat_GatePassTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_GatePassTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSLocalPurTableAdapters.TableAdapterManager()
        Me.Tbl_Mat_GatePass_DetailsTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_GatePass_DetailsTableAdapter()
        Me.Tbl_Mat_ItemsLayer4TableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_ItemsLayer4TableAdapter()
        Me.Tbl_Mat_Inter_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Mat_Inter_DeptTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_Inter_DeptTableAdapter()
        Me.Tbl_Mat_MeasurementUnitsTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_MeasurementUnitsTableAdapter()
        Me.View_userDeptTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.View_userDeptTableAdapter()
        Me.Tbl_GP_CustomerTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.tbl_GP_CustomerTableAdapter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        PurposeLabel = New System.Windows.Forms.Label()
        CarryingPersonLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        EnteryDateLabel = New System.Windows.Forms.Label()
        GMNoLabel = New System.Windows.Forms.Label()
        LocalCustIDLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Mat_GatePassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSLocalPur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_GP_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Mat_GatePass_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Mat_ItemsLayer4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Mat_MeasurementUnitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Mat_GatePass_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.FilterByGDNo.SuspendLayout()
        CType(Me.View_userDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Mat_Inter_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurposeLabel
        '
        PurposeLabel.Location = New System.Drawing.Point(587, 62)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(66, 20)
        PurposeLabel.TabIndex = 19
        PurposeLabel.Text = "Purpose:"
        PurposeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CarryingPersonLabel
        '
        CarryingPersonLabel.Location = New System.Drawing.Point(7, 62)
        CarryingPersonLabel.Name = "CarryingPersonLabel"
        CarryingPersonLabel.Size = New System.Drawing.Size(85, 20)
        CarryingPersonLabel.TabIndex = 18
        CarryingPersonLabel.Text = "Carrying Person:"
        CarryingPersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomerLabel
        '
        CustomerLabel.Location = New System.Drawing.Point(587, 35)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(66, 20)
        CustomerLabel.TabIndex = 17
        CustomerLabel.Text = "Party Name:"
        CustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EnteryDateLabel
        '
        EnteryDateLabel.Location = New System.Drawing.Point(179, 35)
        EnteryDateLabel.Name = "EnteryDateLabel"
        EnteryDateLabel.Size = New System.Drawing.Size(68, 20)
        EnteryDateLabel.TabIndex = 3
        EnteryDateLabel.Text = "Entery Date:"
        EnteryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GMNoLabel
        '
        GMNoLabel.Location = New System.Drawing.Point(7, 35)
        GMNoLabel.Name = "GMNoLabel"
        GMNoLabel.Size = New System.Drawing.Size(85, 20)
        GMNoLabel.TabIndex = 0
        GMNoLabel.Text = "Gate Pass No.:"
        GMNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LocalCustIDLabel
        '
        LocalCustIDLabel.Location = New System.Drawing.Point(352, 35)
        LocalCustIDLabel.Name = "LocalCustIDLabel"
        LocalCustIDLabel.Size = New System.Drawing.Size(86, 20)
        LocalCustIDLabel.TabIndex = 14
        LocalCustIDLabel.Text = "Gate Pass Type:"
        LocalCustIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(352, 62)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 20)
        Label5.TabIndex = 21
        Label5.Text = "Vehicle No.:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Label9.Location = New System.Drawing.Point(7, 87)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(85, 20)
        Label9.TabIndex = 23
        Label9.Text = "Sender Name:"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Label10.Location = New System.Drawing.Point(352, 87)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(86, 20)
        Label10.TabIndex = 25
        Label10.Text = "Receiver Name:"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1260, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Gate Pass"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DateTimePicker2)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(4, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 36)
        Me.Panel3.TabIndex = 25
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(283, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 22)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "From Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(207, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "To Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Label10)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Label9)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(PurposeLabel)
        Me.Panel2.Controls.Add(Me.PurposeTextBox)
        Me.Panel2.Controls.Add(CarryingPersonLabel)
        Me.Panel2.Controls.Add(Me.CarryingPersonTextBox)
        Me.Panel2.Controls.Add(CustomerLabel)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.GMNoLabel4)
        Me.Panel2.Controls.Add(EnteryDateLabel)
        Me.Panel2.Controls.Add(Me.EnteryDateLabel1)
        Me.Panel2.Controls.Add(GMNoLabel)
        Me.Panel2.Controls.Add(Me.LocalCustIDComboBox)
        Me.Panel2.Controls.Add(LocalCustIDLabel)
        Me.Panel2.Location = New System.Drawing.Point(4, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(972, 116)
        Me.Panel2.TabIndex = 21
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Mat_GatePassBindingSource, "Customer", True))
        Me.NameComboBox.DataSource = Me.Tbl_GP_CustomerBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(985, 455)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(303, 21)
        Me.NameComboBox.TabIndex = 29
        Me.NameComboBox.ValueMember = "Name"
        '
        'Tbl_Mat_GatePassBindingSource
        '
        Me.Tbl_Mat_GatePassBindingSource.DataMember = "tbl_Mat_GatePass"
        Me.Tbl_Mat_GatePassBindingSource.DataSource = Me.DSLocalPur
        '
        'DSLocalPur
        '
        Me.DSLocalPur.DataSetName = "DSLocalPur"
        Me.DSLocalPur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_GP_CustomerBindingSource
        '
        Me.Tbl_GP_CustomerBindingSource.DataMember = "tbl_GP_Customer"
        Me.Tbl_GP_CustomerBindingSource.DataSource = Me.DSLocalPur
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "ReceiverName", True))
        Me.TextBox3.Location = New System.Drawing.Point(440, 87)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(516, 20)
        Me.TextBox3.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "SenderName", True))
        Me.TextBox2.Location = New System.Drawing.Point(92, 87)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 20)
        Me.TextBox2.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "VehicleNo", True))
        Me.TextBox1.Location = New System.Drawing.Point(440, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "Purpose", True))
        Me.PurposeTextBox.Location = New System.Drawing.Point(653, 62)
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(303, 20)
        Me.PurposeTextBox.TabIndex = 20
        '
        'CarryingPersonTextBox
        '
        Me.CarryingPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "CarryingPerson", True))
        Me.CarryingPersonTextBox.Location = New System.Drawing.Point(92, 62)
        Me.CarryingPersonTextBox.Name = "CarryingPersonTextBox"
        Me.CarryingPersonTextBox.Size = New System.Drawing.Size(256, 20)
        Me.CarryingPersonTextBox.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(839, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 26)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Print GatePass"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.Tbl_Mat_GatePassBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.SaveToolStripButton, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.toolStripSeparator, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(970, 25)
        Me.BindingNavigator1.TabIndex = 15
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
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.SaveToolStripButton.Tag = ""
        Me.SaveToolStripButton.Text = "&Save"
        Me.SaveToolStripButton.ToolTipText = "Add New GD No"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Save Data"
        '
        'GMNoLabel4
        '
        Me.GMNoLabel4.BackColor = System.Drawing.Color.Bisque
        Me.GMNoLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GMNoLabel4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "GPNo", True))
        Me.GMNoLabel4.Location = New System.Drawing.Point(92, 35)
        Me.GMNoLabel4.Name = "GMNoLabel4"
        Me.GMNoLabel4.Size = New System.Drawing.Size(74, 20)
        Me.GMNoLabel4.TabIndex = 0
        Me.GMNoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnteryDateLabel1
        '
        Me.EnteryDateLabel1.BackColor = System.Drawing.Color.White
        Me.EnteryDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EnteryDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "EnteryDate", True))
        Me.EnteryDateLabel1.Location = New System.Drawing.Point(248, 35)
        Me.EnteryDateLabel1.Name = "EnteryDateLabel1"
        Me.EnteryDateLabel1.Size = New System.Drawing.Size(100, 20)
        Me.EnteryDateLabel1.TabIndex = 1
        Me.EnteryDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LocalCustIDComboBox
        '
        Me.LocalCustIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LocalCustIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LocalCustIDComboBox.BackColor = System.Drawing.Color.Lavender
        Me.LocalCustIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "Type", True))
        Me.LocalCustIDComboBox.FormattingEnabled = True
        Me.LocalCustIDComboBox.Items.AddRange(New Object() {"OUTWARD", "RETURNABLE", "INTERNAL TRANSFER PASS", "Return To Store", "TRANSFER PASS"})
        Me.LocalCustIDComboBox.Location = New System.Drawing.Point(440, 34)
        Me.LocalCustIDComboBox.Name = "LocalCustIDComboBox"
        Me.LocalCustIDComboBox.Size = New System.Drawing.Size(142, 21)
        Me.LocalCustIDComboBox.TabIndex = 2
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(979, 331)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(113, 20)
        Me.CustomerTextBox.TabIndex = 18
        Me.CustomerTextBox.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(875, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Right Click to Filter"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Bisque
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(849, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Lavender
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(727, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(753, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Required Fields"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Mat_GatePass_DetailsDataGridView)
        Me.Panel1.Controls.Add(Me.BindingNavigator2)
        Me.Panel1.Location = New System.Drawing.Point(4, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(972, 437)
        Me.Panel1.TabIndex = 26
        '
        'Tbl_Mat_GatePass_DetailsDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_Mat_GatePass_DetailsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Mat_GatePass_DetailsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Mat_GatePass_DetailsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_Mat_GatePass_DetailsDataGridView.ColumnHeadersHeight = 25
        Me.Tbl_Mat_GatePass_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PDID, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.UserID, Me.DepID, Me.HODStatus, Me.EnteryDate})
        Me.Tbl_Mat_GatePass_DetailsDataGridView.DataSource = Me.Tbl_Mat_GatePass_DetailsBindingSource
        Me.Tbl_Mat_GatePass_DetailsDataGridView.Location = New System.Drawing.Point(1, 24)
        Me.Tbl_Mat_GatePass_DetailsDataGridView.Name = "Tbl_Mat_GatePass_DetailsDataGridView"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Mat_GatePass_DetailsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Tbl_Mat_GatePass_DetailsDataGridView.RowHeadersWidth = 20
        Me.Tbl_Mat_GatePass_DetailsDataGridView.Size = New System.Drawing.Size(967, 408)
        Me.Tbl_Mat_GatePass_DetailsDataGridView.TabIndex = 0
        '
        'PDID
        '
        Me.PDID.DataPropertyName = "SrNo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PDID.DefaultCellStyle = DataGridViewCellStyle3
        Me.PDID.HeaderText = "Sr No"
        Me.PDID.Name = "PDID"
        Me.PDID.ReadOnly = True
        Me.PDID.Visible = False
        Me.PDID.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ItemCode"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.Tbl_Mat_ItemsLayer4BindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn5.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Material Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "ItemCode"
        Me.DataGridViewTextBoxColumn5.Width = 420
        '
        'Tbl_Mat_ItemsLayer4BindingSource
        '
        Me.Tbl_Mat_ItemsLayer4BindingSource.DataMember = "tbl_Mat_ItemsLayer4"
        Me.Tbl_Mat_ItemsLayer4BindingSource.DataSource = Me.DSLocalPur
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PDQty"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UOM"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.Tbl_Mat_MeasurementUnitsBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.DisplayMember = "UOM"
        Me.DataGridViewTextBoxColumn7.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn7.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "UOM"
        '
        'Tbl_Mat_MeasurementUnitsBindingSource
        '
        Me.Tbl_Mat_MeasurementUnitsBindingSource.DataMember = "tbl_Mat_MeasurementUnits"
        Me.Tbl_Mat_MeasurementUnitsBindingSource.DataSource = Me.DSLocalPur
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Narration"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn9.HeaderText = "Narration"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.Width = 270
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "UserID"
        Me.UserID.Name = "UserID"
        Me.UserID.Visible = False
        '
        'DepID
        '
        Me.DepID.DataPropertyName = "DepID"
        Me.DepID.HeaderText = "DepID"
        Me.DepID.Name = "DepID"
        Me.DepID.Visible = False
        '
        'HODStatus
        '
        Me.HODStatus.DataPropertyName = "HODStatus"
        Me.HODStatus.HeaderText = "HODStatus"
        Me.HODStatus.Name = "HODStatus"
        Me.HODStatus.Visible = False
        '
        'EnteryDate
        '
        Me.EnteryDate.DataPropertyName = "EnteryDate"
        Me.EnteryDate.HeaderText = "EnteryDate"
        Me.EnteryDate.Name = "EnteryDate"
        Me.EnteryDate.Visible = False
        '
        'Tbl_Mat_GatePass_DetailsBindingSource
        '
        Me.Tbl_Mat_GatePass_DetailsBindingSource.DataMember = "tbl_Mat_GatePass_tbl_Mat_GatePass_Details"
        Me.Tbl_Mat_GatePass_DetailsBindingSource.DataSource = Me.Tbl_Mat_GatePassBindingSource
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator2.BindingSource = Me.Tbl_Mat_GatePass_DetailsBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Pur_DemandBindingNavigatorSaveItem})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator2.Size = New System.Drawing.Size(970, 25)
        Me.BindingNavigator2.TabIndex = 20
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
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
        'Tbl_Pur_DemandBindingNavigatorSaveItem
        '
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Pur_DemandBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.Name = "Tbl_Pur_DemandBindingNavigatorSaveItem"
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Pur_DemandBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PreparedDeptID
        '
        Me.PreparedDeptID.BackColor = System.Drawing.SystemColors.Control
        Me.PreparedDeptID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PreparedDeptID.CausesValidation = False
        Me.PreparedDeptID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "DepartmentID", True))
        Me.PreparedDeptID.Enabled = False
        Me.PreparedDeptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreparedDeptID.ForeColor = System.Drawing.Color.Gainsboro
        Me.PreparedDeptID.Location = New System.Drawing.Point(508, 68)
        Me.PreparedDeptID.Name = "PreparedDeptID"
        Me.PreparedDeptID.Size = New System.Drawing.Size(10, 3)
        Me.PreparedDeptID.TabIndex = 22
        '
        'PreparedByTextBox
        '
        Me.PreparedByTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.PreparedByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PreparedByTextBox.CausesValidation = False
        Me.PreparedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "PreparedBy", True))
        Me.PreparedByTextBox.Enabled = False
        Me.PreparedByTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreparedByTextBox.ForeColor = System.Drawing.Color.Gainsboro
        Me.PreparedByTextBox.Location = New System.Drawing.Point(458, 68)
        Me.PreparedByTextBox.Name = "PreparedByTextBox"
        Me.PreparedByTextBox.Size = New System.Drawing.Size(10, 3)
        Me.PreparedByTextBox.TabIndex = 21
        '
        'FilterByGDNo
        '
        Me.FilterByGDNo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterByGDNoToolStripMenuItem, Me.RemoveFilterToolStripMenuItem})
        Me.FilterByGDNo.Name = "FilterByGDNo"
        Me.FilterByGDNo.Size = New System.Drawing.Size(152, 48)
        '
        'FilterByGDNoToolStripMenuItem
        '
        Me.FilterByGDNoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.FilterByGDNoToolStripMenuItem.Name = "FilterByGDNoToolStripMenuItem"
        Me.FilterByGDNoToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.FilterByGDNoToolStripMenuItem.Text = "&Filter By GDNo"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "&Remove Filter"
        '
        'LocalCustIDLabel2
        '
        Me.LocalCustIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_userDeptBindingSource, "LocalCustID", True))
        Me.LocalCustIDLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.LocalCustIDLabel2.Location = New System.Drawing.Point(1140, 265)
        Me.LocalCustIDLabel2.Name = "LocalCustIDLabel2"
        Me.LocalCustIDLabel2.Size = New System.Drawing.Size(100, 23)
        Me.LocalCustIDLabel2.TabIndex = 28
        Me.LocalCustIDLabel2.Text = "Label11"
        '
        'View_userDeptBindingSource
        '
        Me.View_userDeptBindingSource.DataMember = "View_userDept"
        Me.View_userDeptBindingSource.DataSource = Me.DSLocalPur
        '
        'Tbl_Mat_GatePassTableAdapter
        '
        Me.Tbl_Mat_GatePassTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_GP_Customer1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_GP_CustomerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass_Details_GMTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass_Details_HODTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass_DetailsTableAdapter = Me.Tbl_Mat_GatePass_DetailsTableAdapter
        Me.TableAdapterManager.tbl_Mat_GatePass1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePassTableAdapter = Me.Tbl_Mat_GatePassTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSLocalPurTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_GatePass_NewTableAdapter = Nothing
        Me.TableAdapterManager.View_GM_ApprovalTableAdapter = Nothing
        Me.TableAdapterManager.View_Mat_GatePassTableAdapter = Nothing
        '
        'Tbl_Mat_GatePass_DetailsTableAdapter
        '
        Me.Tbl_Mat_GatePass_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Mat_ItemsLayer4TableAdapter
        '
        Me.Tbl_Mat_ItemsLayer4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Mat_Inter_DeptBindingSource
        '
        Me.Tbl_Mat_Inter_DeptBindingSource.DataMember = "tbl_Mat_Inter_Dept"
        Me.Tbl_Mat_Inter_DeptBindingSource.DataSource = Me.DSLocalPur
        '
        'Tbl_Mat_Inter_DeptTableAdapter
        '
        Me.Tbl_Mat_Inter_DeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Mat_MeasurementUnitsTableAdapter
        '
        Me.Tbl_Mat_MeasurementUnitsTableAdapter.ClearBeforeFill = True
        '
        'View_userDeptTableAdapter
        '
        Me.View_userDeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_GP_CustomerTableAdapter
        '
        Me.Tbl_GP_CustomerTableAdapter.ClearBeforeFill = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(982, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(221, 36)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Special Note :IF Party Name  is Not Exist Contact to Ext# 270"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePassBindingSource, "Customer", True))
        Me.TextBox4.Location = New System.Drawing.Point(653, 34)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(303, 20)
        Me.TextBox4.TabIndex = 30
        '
        'frmGP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 745)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LocalCustIDLabel2)
        Me.Controls.Add(Me.PreparedDeptID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PreparedByTextBox)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGP"
        Me.Text = "Gate Pass"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Mat_GatePassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSLocalPur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_GP_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Mat_GatePass_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Mat_ItemsLayer4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Mat_MeasurementUnitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Mat_GatePass_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.FilterByGDNo.ResumeLayout(False)
        CType(Me.View_userDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Mat_Inter_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSLocalPur As FS_ERP_MM.DSLocalPur
    Friend WithEvents Tbl_Mat_GatePassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Mat_GatePassTableAdapter As FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_GatePassTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSLocalPurTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Mat_GatePass_DetailsTableAdapter As FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_GatePass_DetailsTableAdapter
    Friend WithEvents Tbl_Mat_GatePass_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PurposeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarryingPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GMNoLabel4 As System.Windows.Forms.Label
    Friend WithEvents EnteryDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents LocalCustIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Mat_ItemsLayer4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Mat_ItemsLayer4TableAdapter As FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_ItemsLayer4TableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tbl_Mat_GatePass_DetailsDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents Tbl_Pur_DemandBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PreparedDeptID As System.Windows.Forms.TextBox
    Friend WithEvents PreparedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tbl_Mat_Inter_DeptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Mat_Inter_DeptTableAdapter As FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_Inter_DeptTableAdapter
    Friend WithEvents Tbl_Mat_MeasurementUnitsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Mat_MeasurementUnitsTableAdapter As FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_MeasurementUnitsTableAdapter
    Friend WithEvents FilterByGDNo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FilterByGDNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents View_userDeptBindingSource As BindingSource
    Friend WithEvents View_userDeptTableAdapter As DSLocalPurTableAdapters.View_userDeptTableAdapter
    Friend WithEvents LocalCustIDLabel2 As Label
    Friend WithEvents PDID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents DepID As DataGridViewTextBoxColumn
    Friend WithEvents HODStatus As DataGridViewCheckBoxColumn
    Friend WithEvents EnteryDate As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_GP_CustomerBindingSource As BindingSource
    Friend WithEvents Tbl_GP_CustomerTableAdapter As DSLocalPurTableAdapters.tbl_GP_CustomerTableAdapter
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
