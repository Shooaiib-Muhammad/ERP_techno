<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRptFilterTran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DayNoLabel As System.Windows.Forms.Label
        Dim DayNoLabel1 As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim L1NameLabel As System.Windows.Forms.Label
        Dim L2NameLabel As System.Windows.Forms.Label
        Dim L3NameLabel As System.Windows.Forms.Label
        Me.DTPicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnNewRpt = New System.Windows.Forms.Button()
        Me.RBOutward = New System.Windows.Forms.RadioButton()
        Me.RBInward = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton27 = New System.Windows.Forms.RadioButton()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRptL4Code = New FS_ERP_MM.DSRptL4Code()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSNewTranIn = New FS_ERP_MM.DSNewTranIn()
        Me.RadioButton23 = New System.Windows.Forms.RadioButton()
        Me.RadioButton22 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Tbl_PIR_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton20 = New System.Windows.Forms.RadioButton()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_LocalCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MakerComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_MakersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Tbl_MakersTableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_MakersTableAdapter()
        Me.Tbl_Inv_LocalCustTableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_LocalCustTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton26 = New System.Windows.Forms.RadioButton()
        Me.RadioButton25 = New System.Windows.Forms.RadioButton()
        Me.RadioButton24 = New System.Windows.Forms.RadioButton()
        Me.RadioButton21 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.Tbl_PIR_DeptTableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_PIR_DeptTableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Inv_L1TableAdapter = New FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L1TableAdapter()
        Me.Tbl_Inv_L2TableAdapter = New FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L2TableAdapter()
        Me.Tbl_Inv_L3TableAdapter = New FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L3TableAdapter()
        DayNoLabel = New System.Windows.Forms.Label()
        DayNoLabel1 = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        L1NameLabel = New System.Windows.Forms.Label()
        L2NameLabel = New System.Windows.Forms.Label()
        L3NameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRptL4Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSNewTranIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PIR_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MakersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DayNoLabel
        '
        DayNoLabel.Location = New System.Drawing.Point(28, 52)
        DayNoLabel.Name = "DayNoLabel"
        DayNoLabel.Size = New System.Drawing.Size(111, 21)
        DayNoLabel.TabIndex = 15
        DayNoLabel.Text = "Select First Date:"
        DayNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DayNoLabel1
        '
        DayNoLabel1.Location = New System.Drawing.Point(28, 77)
        DayNoLabel1.Name = "DayNoLabel1"
        DayNoLabel1.Size = New System.Drawing.Size(111, 21)
        DayNoLabel1.TabIndex = 16
        DayNoLabel1.Text = "Select Second  Date:"
        DayNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameLabel
        '
        L4NameLabel.AutoSize = True
        L4NameLabel.Location = New System.Drawing.Point(61, 275)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(78, 13)
        L4NameLabel.TabIndex = 50
        L4NameLabel.Text = "Material Name:"
        '
        'L1NameLabel
        '
        L1NameLabel.AutoSize = True
        L1NameLabel.Location = New System.Drawing.Point(89, 302)
        L1NameLabel.Name = "L1NameLabel"
        L1NameLabel.Size = New System.Drawing.Size(50, 13)
        L1NameLabel.TabIndex = 17
        L1NameLabel.Text = "L1Name:"
        '
        'L2NameLabel
        '
        L2NameLabel.AutoSize = True
        L2NameLabel.Location = New System.Drawing.Point(89, 328)
        L2NameLabel.Name = "L2NameLabel"
        L2NameLabel.Size = New System.Drawing.Size(50, 13)
        L2NameLabel.TabIndex = 18
        L2NameLabel.Text = "L2Name:"
        '
        'L3NameLabel
        '
        L3NameLabel.AutoSize = True
        L3NameLabel.Location = New System.Drawing.Point(89, 354)
        L3NameLabel.Name = "L3NameLabel"
        L3NameLabel.Size = New System.Drawing.Size(50, 13)
        L3NameLabel.TabIndex = 19
        L3NameLabel.Text = "L3Name:"
        '
        'DTPicker2
        '
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(145, 78)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(133, 20)
        Me.DTPicker2.TabIndex = 17
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(145, 53)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(133, 20)
        Me.DTPicker1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1093, 40)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Daily Material Transaction Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(145, 18)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(111, 17)
        Me.RadioButton1.TabIndex = 24
        Me.RadioButton1.Text = "Outward Summary"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnNewRpt
        '
        Me.btnNewRpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewRpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRpt.Location = New System.Drawing.Point(639, 293)
        Me.btnNewRpt.Name = "btnNewRpt"
        Me.btnNewRpt.Size = New System.Drawing.Size(102, 41)
        Me.btnNewRpt.TabIndex = 18
        Me.btnNewRpt.Text = "Show Report"
        Me.btnNewRpt.UseVisualStyleBackColor = False
        '
        'RBOutward
        '
        Me.RBOutward.AutoSize = True
        Me.RBOutward.Location = New System.Drawing.Point(72, 18)
        Me.RBOutward.Name = "RBOutward"
        Me.RBOutward.Size = New System.Drawing.Size(65, 17)
        Me.RBOutward.TabIndex = 23
        Me.RBOutward.Text = "Outward"
        Me.RBOutward.UseVisualStyleBackColor = True
        '
        'RBInward
        '
        Me.RBInward.AutoSize = True
        Me.RBInward.Checked = True
        Me.RBInward.Location = New System.Drawing.Point(9, 18)
        Me.RBInward.Name = "RBInward"
        Me.RBInward.Size = New System.Drawing.Size(57, 17)
        Me.RBInward.TabIndex = 22
        Me.RBInward.TabStop = True
        Me.RBInward.Text = "Inward"
        Me.RBInward.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL", "MRI", "MTP", "MAE", "MRET", "MREP", "MLRN", "MBRN", "MRRN", "RBR", "WEA", "BGrade", "General"})
        Me.ComboBox1.Location = New System.Drawing.Point(145, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Outward Type:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"ALL", "MIR", "MTP", "MOGP", "MAE", "MRGP", "MREP", "MLGP", "MSGP", "PRGP", "MBRGP", "TPI", "WAE", "Manual Issuance", "Planning Issuance", "General", "MID"})
        Me.ComboBox2.Location = New System.Drawing.Point(145, 133)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox2.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Inward Type:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton27)
        Me.Panel1.Controls.Add(Me.ComboBox8)
        Me.Panel1.Controls.Add(Me.ComboBox7)
        Me.Panel1.Controls.Add(Me.ComboBox6)
        Me.Panel1.Controls.Add(L3NameLabel)
        Me.Panel1.Controls.Add(L4NameLabel)
        Me.Panel1.Controls.Add(Me.L4NameComboBox)
        Me.Panel1.Controls.Add(L2NameLabel)
        Me.Panel1.Controls.Add(Me.RadioButton23)
        Me.Panel1.Controls.Add(Me.RadioButton22)
        Me.Panel1.Controls.Add(L1NameLabel)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ComboBox5)
        Me.Panel1.Controls.Add(Me.RadioButton20)
        Me.Panel1.Controls.Add(Me.RadioButton19)
        Me.Panel1.Controls.Add(Me.RadioButton18)
        Me.Panel1.Controls.Add(Me.RadioButton17)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.btnNewRpt)
        Me.Panel1.Controls.Add(Me.RadioButton13)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.MakerComboBox)
        Me.Panel1.Controls.Add(Me.RadioButton12)
        Me.Panel1.Controls.Add(Me.RadioButton11)
        Me.Panel1.Controls.Add(Me.RadioButton10)
        Me.Panel1.Controls.Add(Me.RadioButton9)
        Me.Panel1.Controls.Add(Me.RadioButton8)
        Me.Panel1.Controls.Add(Me.RadioButton6)
        Me.Panel1.Controls.Add(Me.RadioButton7)
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RBOutward)
        Me.Panel1.Controls.Add(Me.RBInward)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DTPicker2)
        Me.Panel1.Controls.Add(DayNoLabel)
        Me.Panel1.Controls.Add(DayNoLabel1)
        Me.Panel1.Controls.Add(Me.DTPicker1)
        Me.Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 420)
        Me.Panel1.TabIndex = 16
        '
        'RadioButton27
        '
        Me.RadioButton27.AutoSize = True
        Me.RadioButton27.Location = New System.Drawing.Point(408, 386)
        Me.RadioButton27.Name = "RadioButton27"
        Me.RadioButton27.Size = New System.Drawing.Size(139, 17)
        Me.RadioButton27.TabIndex = 55
        Me.RadioButton27.Text = "Internal Expiry Demands"
        Me.RadioButton27.UseVisualStyleBackColor = True
        '
        'ComboBox8
        '
        Me.ComboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox8.DataSource = Me.Tbl_Inv_L3BindingSource
        Me.ComboBox8.DisplayMember = "L3Name"
        Me.ComboBox8.Enabled = False
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(145, 354)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox8.TabIndex = 54
        Me.ComboBox8.ValueMember = "Layer3ID"
        '
        'Tbl_Inv_L3BindingSource
        '
        Me.Tbl_Inv_L3BindingSource.DataMember = "tbl_Inv_L2_tbl_Inv_L3"
        Me.Tbl_Inv_L3BindingSource.DataSource = Me.Tbl_Inv_L2BindingSource
        '
        'Tbl_Inv_L2BindingSource
        '
        Me.Tbl_Inv_L2BindingSource.DataMember = "tbl_Inv_L1_tbl_Inv_L2"
        Me.Tbl_Inv_L2BindingSource.DataSource = Me.Tbl_Inv_L1BindingSource
        '
        'Tbl_Inv_L1BindingSource
        '
        Me.Tbl_Inv_L1BindingSource.DataMember = "tbl_Inv_L1"
        Me.Tbl_Inv_L1BindingSource.DataSource = Me.DSRptL4Code
        '
        'DSRptL4Code
        '
        Me.DSRptL4Code.DataSetName = "DSRptL4Code"
        Me.DSRptL4Code.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox7
        '
        Me.ComboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox7.DataSource = Me.Tbl_Inv_L2BindingSource
        Me.ComboBox7.DisplayMember = "L2Name"
        Me.ComboBox7.Enabled = False
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(145, 328)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox7.TabIndex = 53
        Me.ComboBox7.ValueMember = "Layer2ID"
        '
        'ComboBox6
        '
        Me.ComboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox6.DataSource = Me.Tbl_Inv_L1BindingSource
        Me.ComboBox6.DisplayMember = "L1Name"
        Me.ComboBox6.Enabled = False
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(145, 299)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox6.TabIndex = 52
        Me.ComboBox6.ValueMember = "Layer1ID"
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.Enabled = False
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(145, 272)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(238, 21)
        Me.L4NameComboBox.TabIndex = 51
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSNewTranIn
        '
        'DSNewTranIn
        '
        Me.DSNewTranIn.DataSetName = "DSNewTranIn"
        Me.DSNewTranIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButton23
        '
        Me.RadioButton23.AutoSize = True
        Me.RadioButton23.Location = New System.Drawing.Point(407, 363)
        Me.RadioButton23.Name = "RadioButton23"
        Me.RadioButton23.Size = New System.Drawing.Size(146, 17)
        Me.RadioButton23.TabIndex = 50
        Me.RadioButton23.Text = "General Stock Transction"
        Me.RadioButton23.UseVisualStyleBackColor = True
        '
        'RadioButton22
        '
        Me.RadioButton22.AutoSize = True
        Me.RadioButton22.Location = New System.Drawing.Point(407, 340)
        Me.RadioButton22.Name = "RadioButton22"
        Me.RadioButton22.Size = New System.Drawing.Size(178, 17)
        Me.RadioButton22.TabIndex = 49
        Me.RadioButton22.Text = "Daily External Demand Issuance"
        Me.RadioButton22.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(28, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 21)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "IDMS Dept Name:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox5
        '
        Me.ComboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox5.DataSource = Me.Tbl_PIR_DeptBindingSource
        Me.ComboBox5.DisplayMember = "DeptName"
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(145, 245)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox5.TabIndex = 47
        Me.ComboBox5.ValueMember = "DeptID"
        '
        'Tbl_PIR_DeptBindingSource
        '
        Me.Tbl_PIR_DeptBindingSource.DataMember = "tbl_PIR_Dept"
        Me.Tbl_PIR_DeptBindingSource.DataSource = Me.DSNewTranIn
        '
        'RadioButton20
        '
        Me.RadioButton20.AutoSize = True
        Me.RadioButton20.Location = New System.Drawing.Point(408, 317)
        Me.RadioButton20.Name = "RadioButton20"
        Me.RadioButton20.Size = New System.Drawing.Size(137, 17)
        Me.RadioButton20.TabIndex = 46
        Me.RadioButton20.Text = "Daily Demand Issuance"
        Me.RadioButton20.UseVisualStyleBackColor = True
        '
        'RadioButton19
        '
        Me.RadioButton19.AutoSize = True
        Me.RadioButton19.Location = New System.Drawing.Point(407, 294)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(226, 17)
        Me.RadioButton19.TabIndex = 45
        Me.RadioButton19.Text = "Daily Canceled Material Requisition Report"
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Location = New System.Drawing.Point(407, 271)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(154, 17)
        Me.RadioButton18.TabIndex = 44
        Me.RadioButton18.Text = "Daily General Material Rec."
        Me.RadioButton18.UseVisualStyleBackColor = True
        Me.RadioButton18.Visible = False
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Location = New System.Drawing.Point(407, 248)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(118, 17)
        Me.RadioButton17.TabIndex = 43
        Me.RadioButton17.Text = "Daily Material Wise "
        Me.RadioButton17.UseVisualStyleBackColor = True
        Me.RadioButton17.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(28, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Factory Code:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox4
        '
        Me.ComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"B34001", "B34002", "B34003", "B34004", "B34005", "B34006", "B34007"})
        Me.ComboBox4.Location = New System.Drawing.Point(145, 218)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox4.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(28, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 21)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Department Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DataSource = Me.Tbl_Inv_LocalCustBindingSource
        Me.ComboBox3.DisplayMember = "CustName"
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(145, 191)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox3.TabIndex = 39
        Me.ComboBox3.ValueMember = "LocalCustID"
        '
        'Tbl_Inv_LocalCustBindingSource
        '
        Me.Tbl_Inv_LocalCustBindingSource.DataMember = "tbl_Inv_LocalCust"
        Me.Tbl_Inv_LocalCustBindingSource.DataSource = Me.DSNewTranIn
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(407, 225)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(152, 17)
        Me.RadioButton13.TabIndex = 38
        Me.RadioButton13.Text = "Daily Printing Material Rec."
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(28, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Maker Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'MakerComboBox
        '
        Me.MakerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MakerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MakerComboBox.DataSource = Me.Tbl_MakersBindingSource
        Me.MakerComboBox.DisplayMember = "MakerName"
        Me.MakerComboBox.FormattingEnabled = True
        Me.MakerComboBox.Location = New System.Drawing.Point(145, 162)
        Me.MakerComboBox.Name = "MakerComboBox"
        Me.MakerComboBox.Size = New System.Drawing.Size(133, 21)
        Me.MakerComboBox.TabIndex = 36
        Me.MakerComboBox.ValueMember = "MakerID"
        Me.MakerComboBox.Visible = False
        '
        'Tbl_MakersBindingSource
        '
        Me.Tbl_MakersBindingSource.DataMember = "tbl_Makers"
        Me.Tbl_MakersBindingSource.DataSource = Me.DSNewTranIn
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(555, 18)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(200, 17)
        Me.RadioButton12.TabIndex = 35
        Me.RadioButton12.Text = "Canceled Material Requisition Report"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(407, 75)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(182, 17)
        Me.RadioButton11.TabIndex = 34
        Me.RadioButton11.Text = "Weekly Bill Report Account Copy"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(407, 52)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(172, 17)
        Me.RadioButton10.TabIndex = 33
        Me.RadioButton10.Text = "Weekly Bill Report Maker Copy"
        Me.RadioButton10.UseVisualStyleBackColor = True
        Me.RadioButton10.Visible = False
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(402, 18)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(147, 17)
        Me.RadioButton9.TabIndex = 32
        Me.RadioButton9.Text = "Gate Inward Transactions"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(256, 18)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(140, 17)
        Me.RadioButton8.TabIndex = 31
        Me.RadioButton8.Text = "Material In Out Summary"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(407, 202)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(232, 17)
        Me.RadioButton6.TabIndex = 30
        Me.RadioButton6.Text = "Daily Warehouse Material Receiving Report"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(407, 182)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(227, 17)
        Me.RadioButton7.TabIndex = 29
        Me.RadioButton7.Text = "Daily Warehouse Material Issuance Report"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(407, 157)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(189, 17)
        Me.RadioButton5.TabIndex = 28
        Me.RadioButton5.Text = "Daily Repaired Bladders Receiving"
        Me.RadioButton5.UseVisualStyleBackColor = True
        Me.RadioButton5.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(407, 137)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(199, 17)
        Me.RadioButton4.TabIndex = 27
        Me.RadioButton4.Text = "Daily Bladder Issuance For Repairing"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(407, 114)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(210, 17)
        Me.RadioButton3.TabIndex = 26
        Me.RadioButton3.Text = "Daily Issuance For Un-Winding Bladder"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(407, 94)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(192, 17)
        Me.RadioButton2.TabIndex = 25
        Me.RadioButton2.Text = "Daily Repairable Bladder Receiving"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Tbl_MakersTableAdapter
        '
        Me.Tbl_MakersTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_LocalCustTableAdapter
        '
        Me.Tbl_Inv_LocalCustTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton26)
        Me.GroupBox1.Controls.Add(Me.RadioButton25)
        Me.GroupBox1.Controls.Add(Me.RadioButton24)
        Me.GroupBox1.Controls.Add(Me.RadioButton21)
        Me.GroupBox1.Controls.Add(Me.RadioButton16)
        Me.GroupBox1.Controls.Add(Me.RadioButton15)
        Me.GroupBox1.Controls.Add(Me.RadioButton14)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 479)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 197)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selection"
        '
        'RadioButton26
        '
        Me.RadioButton26.AutoSize = True
        Me.RadioButton26.Location = New System.Drawing.Point(30, 155)
        Me.RadioButton26.Name = "RadioButton26"
        Me.RadioButton26.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton26.TabIndex = 6
        Me.RadioButton26.Text = "By Layers"
        Me.RadioButton26.UseVisualStyleBackColor = True
        '
        'RadioButton25
        '
        Me.RadioButton25.AutoSize = True
        Me.RadioButton25.Location = New System.Drawing.Point(28, 132)
        Me.RadioButton25.Name = "RadioButton25"
        Me.RadioButton25.Size = New System.Drawing.Size(184, 17)
        Me.RadioButton25.TabIndex = 5
        Me.RadioButton25.Text = "By Outward Type , Material Name"
        Me.RadioButton25.UseVisualStyleBackColor = True
        '
        'RadioButton24
        '
        Me.RadioButton24.AutoSize = True
        Me.RadioButton24.Location = New System.Drawing.Point(28, 109)
        Me.RadioButton24.Name = "RadioButton24"
        Me.RadioButton24.Size = New System.Drawing.Size(108, 17)
        Me.RadioButton24.TabIndex = 4
        Me.RadioButton24.Text = "By Material Name"
        Me.RadioButton24.UseVisualStyleBackColor = True
        '
        'RadioButton21
        '
        Me.RadioButton21.AutoSize = True
        Me.RadioButton21.Location = New System.Drawing.Point(28, 86)
        Me.RadioButton21.Name = "RadioButton21"
        Me.RadioButton21.Size = New System.Drawing.Size(93, 17)
        Me.RadioButton21.TabIndex = 3
        Me.RadioButton21.Text = "By IDMS Dept"
        Me.RadioButton21.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(28, 63)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(106, 17)
        Me.RadioButton16.TabIndex = 2
        Me.RadioButton16.Text = "By Factory Code:"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(28, 40)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(95, 17)
        Me.RadioButton15.TabIndex = 1
        Me.RadioButton15.Text = "By Department"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Checked = True
        Me.RadioButton14.Location = New System.Drawing.Point(28, 17)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton14.TabIndex = 0
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "All"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'Tbl_PIR_DeptTableAdapter
        '
        Me.Tbl_PIR_DeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L1TableAdapter
        '
        Me.Tbl_Inv_L1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L2TableAdapter
        '
        Me.Tbl_Inv_L2TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L3TableAdapter
        '
        Me.Tbl_Inv_L3TableAdapter.ClearBeforeFill = True
        '
        'frmRptFilterTran
        '
        Me.AcceptButton = Me.btnNewRpt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 719)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptFilterTran"
        Me.Text = "Daily Inventory Transaction Reports Filter"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRptL4Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSNewTranIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PIR_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MakersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents Tbl_Inv_Tran_MonthTableAdapter As FS_ERP_MM.DSRptDateTableAdapters.tbl_Inv_Tran_MonthTableAdapter
    'Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSRptDateTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNewRpt As System.Windows.Forms.Button
    Friend WithEvents RBOutward As System.Windows.Forms.RadioButton
    Friend WithEvents RBInward As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents MakerComboBox As ComboBox
    Friend WithEvents DSNewTranIn As DSNewTranIn
    Friend WithEvents Tbl_MakersBindingSource As BindingSource
    Friend WithEvents Tbl_MakersTableAdapter As DSNewTranInTableAdapters.tbl_MakersTableAdapter
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents Tbl_Inv_LocalCustBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_LocalCustTableAdapter As DSNewTranInTableAdapters.tbl_Inv_LocalCustTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton19 As RadioButton
    Friend WithEvents RadioButton20 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents RadioButton21 As RadioButton
    Friend WithEvents Tbl_PIR_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_PIR_DeptTableAdapter As DSNewTranInTableAdapters.tbl_PIR_DeptTableAdapter
    Friend WithEvents RadioButton22 As RadioButton
    Friend WithEvents RadioButton23 As RadioButton
    Friend WithEvents RadioButton24 As RadioButton
    Friend WithEvents Tbl_Inv_L4BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As DSNewTranInTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents L4NameComboBox As ComboBox
    Friend WithEvents RadioButton25 As RadioButton
    Friend WithEvents DSRptL4Code As DSRptL4Code
    Friend WithEvents Tbl_Inv_L1BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L1TableAdapter As DSRptL4CodeTableAdapters.tbl_Inv_L1TableAdapter
    Friend WithEvents Tbl_Inv_L2BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L2TableAdapter As DSRptL4CodeTableAdapters.tbl_Inv_L2TableAdapter
    Friend WithEvents Tbl_Inv_L3BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L3TableAdapter As DSRptL4CodeTableAdapters.tbl_Inv_L3TableAdapter
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents RadioButton26 As RadioButton
    Friend WithEvents RadioButton27 As RadioButton
End Class
