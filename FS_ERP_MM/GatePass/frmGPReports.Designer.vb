<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPReports
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
        Dim Label4 As System.Windows.Forms.Label
        Dim MPNOLabel1 As System.Windows.Forms.Label
        Dim MPNOLabel As System.Windows.Forms.Label
        Dim ClientNameLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Show = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_GP_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSLocalPur = New FS_ERP_MM.DSLocalPur()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxUsername = New System.Windows.Forms.ComboBox()
        Me.View_Mat_GatePass_UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GPNO1 = New System.Windows.Forms.TextBox()
        Me.GPNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.TypeCombo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioUserName = New System.Windows.Forms.RadioButton()
        Me.RadioGPRange = New System.Windows.Forms.RadioButton()
        Me.RadioEntryDate = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioGatePass = New System.Windows.Forms.RadioButton()
        Me.View_Mat_GatePassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Mat_GatePassTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.View_Mat_GatePassTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSLocalPurTableAdapters.TableAdapterManager()
        Me.View_Mat_GatePass_UserTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.View_Mat_GatePass_UserTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.View_userDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_userDeptTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.View_userDeptTableAdapter()
        Me.LocalCustIDLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_GP_CustomerTableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.tbl_GP_CustomerTableAdapter()
        Label4 = New System.Windows.Forms.Label()
        MPNOLabel1 = New System.Windows.Forms.Label()
        MPNOLabel = New System.Windows.Forms.Label()
        ClientNameLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_GP_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSLocalPur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Mat_GatePass_UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.View_Mat_GatePassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_userDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(9, 123)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(80, 16)
        Label4.TabIndex = 67
        Label4.Text = "User Name:"
        '
        'MPNOLabel1
        '
        MPNOLabel1.ForeColor = System.Drawing.Color.Black
        MPNOLabel1.Location = New System.Drawing.Point(226, 52)
        MPNOLabel1.Name = "MPNOLabel1"
        MPNOLabel1.Size = New System.Drawing.Size(73, 18)
        MPNOLabel1.TabIndex = 64
        MPNOLabel1.Text = "To GP NO:"
        MPNOLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'MPNOLabel
        '
        MPNOLabel.ForeColor = System.Drawing.Color.Black
        MPNOLabel.Location = New System.Drawing.Point(9, 54)
        MPNOLabel.Name = "MPNOLabel"
        MPNOLabel.Size = New System.Drawing.Size(87, 18)
        MPNOLabel.TabIndex = 63
        MPNOLabel.Text = "From GP NO:"
        MPNOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClientNameLabel
        '
        ClientNameLabel.AutoSize = True
        ClientNameLabel.ForeColor = System.Drawing.Color.Black
        ClientNameLabel.Location = New System.Drawing.Point(9, 89)
        ClientNameLabel.Name = "ClientNameLabel"
        ClientNameLabel.Size = New System.Drawing.Size(43, 16)
        ClientNameLabel.TabIndex = 46
        ClientNameLabel.Text = "Type:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.ForeColor = System.Drawing.Color.Black
        Label5.Location = New System.Drawing.Point(9, 158)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(45, 16)
        Label5.TabIndex = 69
        Label5.Text = "Status"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.ForeColor = System.Drawing.Color.Black
        Label6.Location = New System.Drawing.Point(9, 188)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(109, 16)
        Label6.TabIndex = 71
        Label6.Text = "Approval Status :"
        '
        'L4NameLabel
        '
        L4NameLabel.AutoSize = True
        L4NameLabel.ForeColor = System.Drawing.Color.Black
        L4NameLabel.Location = New System.Drawing.Point(10, 220)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(102, 16)
        L4NameLabel.TabIndex = 61
        L4NameLabel.Text = "Material Name :"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.ForeColor = System.Drawing.Color.Black
        NameLabel.Location = New System.Drawing.Point(17, 245)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(79, 16)
        NameLabel.TabIndex = 72
        NameLabel.Text = "Party Name"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Maroon
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.Yellow
        Me.btn_Cancel.Location = New System.Drawing.Point(634, 326)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(103, 35)
        Me.btn_Cancel.TabIndex = 58
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Show
        '
        Me.btn_Show.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Show.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Show.ForeColor = System.Drawing.Color.Yellow
        Me.btn_Show.Location = New System.Drawing.Point(524, 326)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(103, 35)
        Me.btn_Show.TabIndex = 57
        Me.btn_Show.Text = "&Show"
        Me.btn_Show.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(NameLabel)
        Me.GroupBox3.Controls.Add(Me.NameComboBox)
        Me.GroupBox3.Controls.Add(L4NameLabel)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.L4NameComboBox)
        Me.GroupBox3.Controls.Add(Label6)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Me.ComboBoxUsername)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Me.GPNO1)
        Me.GroupBox3.Controls.Add(Me.GPNO)
        Me.GroupBox3.Controls.Add(MPNOLabel1)
        Me.GroupBox3.Controls.Add(MPNOLabel)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.dtTo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtFrom)
        Me.GroupBox3.Controls.Add(Me.TypeCombo)
        Me.GroupBox3.Controls.Add(ClientNameLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(312, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(436, 280)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataSource = Me.Tbl_GP_CustomerBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.Enabled = False
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(118, 242)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(279, 24)
        Me.NameComboBox.TabIndex = 73
        Me.NameComboBox.ValueMember = "Name"
        '
        'Tbl_GP_CustomerBindingSource
        '
        Me.Tbl_GP_CustomerBindingSource.DataMember = "tbl_GP_Customer"
        Me.Tbl_GP_CustomerBindingSource.DataSource = Me.DSLocalPur
        '
        'DSLocalPur
        '
        Me.DSLocalPur.DataSetName = "DSLocalPur"
        Me.DSLocalPur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DisplayMember = "ClientName"
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Pending", "Approved"})
        Me.ComboBox2.Location = New System.Drawing.Point(118, 182)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(279, 24)
        Me.ComboBox2.TabIndex = 72
        Me.ComboBox2.Text = "Pending"
        Me.ComboBox2.ValueMember = "ClientID"
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.Enabled = False
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(118, 212)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(279, 24)
        Me.L4NameComboBox.TabIndex = 62
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSLocalPur
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "ClientName"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Active", "Cancel"})
        Me.ComboBox1.Location = New System.Drawing.Point(118, 152)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(279, 24)
        Me.ComboBox1.TabIndex = 70
        Me.ComboBox1.Text = "Active"
        Me.ComboBox1.ValueMember = "ClientID"
        '
        'ComboBoxUsername
        '
        Me.ComboBoxUsername.DataSource = Me.View_Mat_GatePass_UserBindingSource
        Me.ComboBoxUsername.DisplayMember = "FirstName"
        Me.ComboBoxUsername.Enabled = False
        Me.ComboBoxUsername.FormattingEnabled = True
        Me.ComboBoxUsername.Location = New System.Drawing.Point(118, 117)
        Me.ComboBoxUsername.Name = "ComboBoxUsername"
        Me.ComboBoxUsername.Size = New System.Drawing.Size(279, 24)
        Me.ComboBoxUsername.TabIndex = 68
        Me.ComboBoxUsername.ValueMember = "UserID"
        '
        'View_Mat_GatePass_UserBindingSource
        '
        Me.View_Mat_GatePass_UserBindingSource.DataMember = "View_Mat_GatePass_User"
        Me.View_Mat_GatePass_UserBindingSource.DataSource = Me.DSLocalPur
        '
        'GPNO1
        '
        Me.GPNO1.Enabled = False
        Me.GPNO1.Location = New System.Drawing.Point(297, 50)
        Me.GPNO1.Name = "GPNO1"
        Me.GPNO1.Size = New System.Drawing.Size(100, 22)
        Me.GPNO1.TabIndex = 66
        Me.GPNO1.Text = "1"
        Me.GPNO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GPNO
        '
        Me.GPNO.Enabled = False
        Me.GPNO.Location = New System.Drawing.Point(118, 52)
        Me.GPNO.Name = "GPNO"
        Me.GPNO.Size = New System.Drawing.Size(102, 22)
        Me.GPNO.TabIndex = 65
        Me.GPNO.Text = "1"
        Me.GPNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(226, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "To Date :"
        '
        'dtTo
        '
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTo.Location = New System.Drawing.Point(297, 19)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(100, 22)
        Me.dtTo.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "From Date :"
        '
        'dtFrom
        '
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFrom.Location = New System.Drawing.Point(118, 19)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(102, 22)
        Me.dtFrom.TabIndex = 45
        '
        'TypeCombo
        '
        Me.TypeCombo.DisplayMember = "ClientName"
        Me.TypeCombo.FormattingEnabled = True
        Me.TypeCombo.Items.AddRange(New Object() {"OUTWARD", "RETURNABLE", "INTERNAL TRANSFER PASS", "Return To Store", "TRANSFER PASS"})
        Me.TypeCombo.Location = New System.Drawing.Point(118, 83)
        Me.TypeCombo.Name = "TypeCombo"
        Me.TypeCombo.Size = New System.Drawing.Size(279, 24)
        Me.TypeCombo.TabIndex = 47
        Me.TypeCombo.ValueMember = "ClientID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioUserName)
        Me.GroupBox2.Controls.Add(Me.RadioGPRange)
        Me.GroupBox2.Controls.Add(Me.RadioEntryDate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 178)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selector"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(17, 149)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(102, 20)
        Me.RadioButton6.TabIndex = 55
        Me.RadioButton6.Text = "By Customer"
        Me.RadioButton6.UseVisualStyleBackColor = True
        Me.RadioButton6.Visible = False
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(17, 123)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(77, 20)
        Me.RadioButton7.TabIndex = 54
        Me.RadioButton7.Text = "By Items"
        Me.RadioButton7.UseVisualStyleBackColor = True
        Me.RadioButton7.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(17, 97)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(82, 20)
        Me.RadioButton3.TabIndex = 53
        Me.RadioButton3.Text = "By Status"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioUserName
        '
        Me.RadioUserName.AutoSize = True
        Me.RadioUserName.ForeColor = System.Drawing.Color.Black
        Me.RadioUserName.Location = New System.Drawing.Point(17, 71)
        Me.RadioUserName.Name = "RadioUserName"
        Me.RadioUserName.Size = New System.Drawing.Size(114, 20)
        Me.RadioUserName.TabIndex = 52
        Me.RadioUserName.Text = "By User Name"
        Me.RadioUserName.UseVisualStyleBackColor = True
        '
        'RadioGPRange
        '
        Me.RadioGPRange.AutoSize = True
        Me.RadioGPRange.ForeColor = System.Drawing.Color.Black
        Me.RadioGPRange.Location = New System.Drawing.Point(17, 46)
        Me.RadioGPRange.Name = "RadioGPRange"
        Me.RadioGPRange.Size = New System.Drawing.Size(108, 20)
        Me.RadioGPRange.TabIndex = 51
        Me.RadioGPRange.Text = "By GP Range"
        Me.RadioGPRange.UseVisualStyleBackColor = True
        '
        'RadioEntryDate
        '
        Me.RadioEntryDate.AutoSize = True
        Me.RadioEntryDate.Checked = True
        Me.RadioEntryDate.ForeColor = System.Drawing.Color.Black
        Me.RadioEntryDate.Location = New System.Drawing.Point(17, 21)
        Me.RadioEntryDate.Name = "RadioEntryDate"
        Me.RadioEntryDate.Size = New System.Drawing.Size(107, 20)
        Me.RadioEntryDate.TabIndex = 49
        Me.RadioEntryDate.TabStop = True
        Me.RadioEntryDate.Text = "By Entry Date"
        Me.RadioEntryDate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioGatePass)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 131)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(6, 108)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(204, 20)
        Me.RadioButton5.TabIndex = 55
        Me.RadioButton5.Text = "Gate Pas GM Approval Status"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(6, 86)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(213, 20)
        Me.RadioButton4.TabIndex = 54
        Me.RadioButton4.Text = "Gate Pas HOD Approval Status"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(173, 20)
        Me.RadioButton2.TabIndex = 53
        Me.RadioButton2.Text = "Daily Items Transactions"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(6, 64)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(274, 20)
        Me.RadioButton1.TabIndex = 52
        Me.RadioButton1.Text = "Pending Returnable Items Inward Enteries"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioGatePass
        '
        Me.RadioGatePass.AutoSize = True
        Me.RadioGatePass.Checked = True
        Me.RadioGatePass.ForeColor = System.Drawing.Color.Black
        Me.RadioGatePass.Location = New System.Drawing.Point(6, 20)
        Me.RadioGatePass.Name = "RadioGatePass"
        Me.RadioGatePass.Size = New System.Drawing.Size(89, 20)
        Me.RadioGatePass.TabIndex = 45
        Me.RadioGatePass.TabStop = True
        Me.RadioGatePass.Text = "Gate Pass"
        Me.RadioGatePass.UseVisualStyleBackColor = True
        '
        'View_Mat_GatePassBindingSource
        '
        Me.View_Mat_GatePassBindingSource.DataMember = "View_Mat_GatePass"
        Me.View_Mat_GatePassBindingSource.DataSource = Me.DSLocalPur
        '
        'View_Mat_GatePassTableAdapter
        '
        Me.View_Mat_GatePassTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_GP_Customer1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_GP_CustomerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass_Details_GMTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass_Details_HODTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePassTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSLocalPurTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_GatePass_NewTableAdapter = Nothing
        Me.TableAdapterManager.View_GM_ApprovalTableAdapter = Nothing
        Me.TableAdapterManager.View_Mat_GatePassTableAdapter = Me.View_Mat_GatePassTableAdapter
        '
        'View_Mat_GatePass_UserTableAdapter
        '
        Me.View_Mat_GatePass_UserTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(856, 40)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_userDeptBindingSource
        '
        Me.View_userDeptBindingSource.DataMember = "View_userDept"
        Me.View_userDeptBindingSource.DataSource = Me.DSLocalPur
        '
        'View_userDeptTableAdapter
        '
        Me.View_userDeptTableAdapter.ClearBeforeFill = True
        '
        'LocalCustIDLabel1
        '
        Me.LocalCustIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_userDeptBindingSource, "LocalCustID", True))
        Me.LocalCustIDLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.LocalCustIDLabel1.Location = New System.Drawing.Point(579, 514)
        Me.LocalCustIDLabel1.Name = "LocalCustIDLabel1"
        Me.LocalCustIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.LocalCustIDLabel1.TabIndex = 61
        Me.LocalCustIDLabel1.Text = "Label7"
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_GP_CustomerTableAdapter
        '
        Me.Tbl_GP_CustomerTableAdapter.ClearBeforeFill = True
        '
        'frmGPReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 584)
        Me.Controls.Add(Me.LocalCustIDLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Show)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGPReports"
        Me.Text = "Gate Pass Reports "
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_GP_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSLocalPur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Mat_GatePass_UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.View_Mat_GatePassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_userDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSLocalPur As FS_ERP_MM.DSLocalPur
    Friend WithEvents View_Mat_GatePassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Mat_GatePassTableAdapter As FS_ERP_MM.DSLocalPurTableAdapters.View_Mat_GatePassTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSLocalPurTableAdapters.TableAdapterManager
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Show As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxUsername As System.Windows.Forms.ComboBox
    Friend WithEvents GPNO1 As System.Windows.Forms.TextBox
    Friend WithEvents GPNO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents TypeCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioUserName As System.Windows.Forms.RadioButton
    Friend WithEvents RadioGPRange As System.Windows.Forms.RadioButton
    Friend WithEvents RadioEntryDate As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioGatePass As System.Windows.Forms.RadioButton
    Friend WithEvents View_Mat_GatePass_UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Mat_GatePass_UserTableAdapter As FS_ERP_MM.DSLocalPurTableAdapters.View_Mat_GatePass_UserTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents View_userDeptBindingSource As BindingSource
    Friend WithEvents View_userDeptTableAdapter As DSLocalPurTableAdapters.View_userDeptTableAdapter
    Friend WithEvents LocalCustIDLabel1 As Label
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents Tbl_Inv_L4BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As DSLocalPurTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents L4NameComboBox As ComboBox
    Friend WithEvents Tbl_GP_CustomerBindingSource As BindingSource
    Friend WithEvents Tbl_GP_CustomerTableAdapter As DSLocalPurTableAdapters.tbl_GP_CustomerTableAdapter
    Friend WithEvents NameComboBox As ComboBox
End Class
