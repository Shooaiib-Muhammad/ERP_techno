<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim ArtCodeLabel As System.Windows.Forms.Label
        Dim ArtCodeLabel1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim ArtCodeLabel2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.Tbl_Sec_MakerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSec = New FS_ERP_MM.DSSec()
        Me.Tbl_Sec_MakerTableAdapter = New FS_ERP_MM.DSSecTableAdapters.tbl_Sec_MakerTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSSecTableAdapters.TableAdapterManager()
        Me.Tbl_Sec_DriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Sec_DriverTableAdapter = New FS_ERP_MM.DSSecTableAdapters.tbl_Sec_DriverTableAdapter()
        Me.Tbl_Sec_VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Sec_VehicleTableAdapter = New FS_ERP_MM.DSSecTableAdapters.tbl_Sec_VehicleTableAdapter()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.FactoryCodeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.INOUTComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DriverNameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VehicleComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MakerComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FactoryCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.SesonalRangeComboBox = New System.Windows.Forms.ComboBox()
        Me.ArtCodeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        ArtCodeLabel = New System.Windows.Forms.Label()
        ArtCodeLabel1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        ArtCodeLabel2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.Tbl_Sec_MakerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_DriverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tbl_Sec_MakerBindingSource
        '
        Me.Tbl_Sec_MakerBindingSource.DataMember = "tbl_Sec_Maker"
        Me.Tbl_Sec_MakerBindingSource.DataSource = Me.DSSec
        '
        'DSSec
        '
        Me.DSSec.DataSetName = "DSSec"
        Me.DSSec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Sec_MakerTableAdapter
        '
        Me.Tbl_Sec_MakerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Sec_DriverTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Sec_MakerTableAdapter = Me.Tbl_Sec_MakerTableAdapter
        Me.TableAdapterManager.tbl_Sec_VehicleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSSecTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Sec_DriverBindingSource
        '
        Me.Tbl_Sec_DriverBindingSource.DataMember = "tbl_Sec_Driver"
        Me.Tbl_Sec_DriverBindingSource.DataSource = Me.DSSec
        '
        'Tbl_Sec_DriverTableAdapter
        '
        Me.Tbl_Sec_DriverTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_VehicleBindingSource
        '
        Me.Tbl_Sec_VehicleBindingSource.DataMember = "tbl_Sec_Vehicle"
        Me.Tbl_Sec_VehicleBindingSource.DataSource = Me.DSSec
        '
        'Tbl_Sec_VehicleTableAdapter
        '
        Me.Tbl_Sec_VehicleTableAdapter.ClearBeforeFill = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(558, 437)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(208, 17)
        Me.RadioButton10.TabIndex = 28
        Me.RadioButton10.Text = "Client, Factory Code And Season Wise"
        Me.RadioButton10.UseVisualStyleBackColor = True
        Me.RadioButton10.Visible = False
        '
        'FactoryCodeComboBox1
        '
        Me.FactoryCodeComboBox1.FormattingEnabled = True
        Me.FactoryCodeComboBox1.Items.AddRange(New Object() {"B34001", "B34002", "B34003", "B34004", "B34005", "B34501", "B34502"})
        Me.FactoryCodeComboBox1.Location = New System.Drawing.Point(758, 285)
        Me.FactoryCodeComboBox1.Name = "FactoryCodeComboBox1"
        Me.FactoryCodeComboBox1.Size = New System.Drawing.Size(147, 21)
        Me.FactoryCodeComboBox1.TabIndex = 37
        Me.FactoryCodeComboBox1.Visible = False
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(558, 414)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(208, 17)
        Me.RadioButton8.TabIndex = 27
        Me.RadioButton8.Text = "Client,Season And  Factory Code Wise"
        Me.RadioButton8.UseVisualStyleBackColor = True
        Me.RadioButton8.Visible = False
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(665, 286)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(92, 20)
        Label6.TabIndex = 36
        Label6.Text = "Factory Code:"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label6.Visible = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(558, 395)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(163, 17)
        Me.RadioButton6.TabIndex = 26
        Me.RadioButton6.Text = "Client  And Article Code Wise"
        Me.RadioButton6.UseVisualStyleBackColor = True
        Me.RadioButton6.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.INOUTComboBox)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(ArtCodeLabel)
        Me.GroupBox3.Controls.Add(Me.DriverNameComboBox1)
        Me.GroupBox3.Controls.Add(Me.VehicleComboBox)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(ArtCodeLabel1)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Me.MakerComboBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(277, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 272)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selector"
        '
        'INOUTComboBox
        '
        Me.INOUTComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.INOUTComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.INOUTComboBox.FormattingEnabled = True
        Me.INOUTComboBox.Items.AddRange(New Object() {"Normal", "Returnable"})
        Me.INOUTComboBox.Location = New System.Drawing.Point(104, 125)
        Me.INOUTComboBox.Name = "INOUTComboBox"
        Me.INOUTComboBox.Size = New System.Drawing.Size(151, 21)
        Me.INOUTComboBox.TabIndex = 18
        Me.INOUTComboBox.Text = "Normal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 74)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "To Date:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(5, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "From Date:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(104, 100)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePicker2.TabIndex = 15
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(5, 50)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(93, 21)
        Label2.TabIndex = 13
        Label2.Text = "Driver Name:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ArtCodeLabel
        '
        ArtCodeLabel.Location = New System.Drawing.Point(5, 24)
        ArtCodeLabel.Name = "ArtCodeLabel"
        ArtCodeLabel.Size = New System.Drawing.Size(93, 21)
        ArtCodeLabel.TabIndex = 12
        ArtCodeLabel.Text = "Vehicle No.:"
        ArtCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DriverNameComboBox1
        '
        Me.DriverNameComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DriverNameComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DriverNameComboBox1.DataSource = Me.Tbl_Sec_DriverBindingSource
        Me.DriverNameComboBox1.DisplayMember = "DriverName"
        Me.DriverNameComboBox1.FormattingEnabled = True
        Me.DriverNameComboBox1.Location = New System.Drawing.Point(104, 49)
        Me.DriverNameComboBox1.Name = "DriverNameComboBox1"
        Me.DriverNameComboBox1.Size = New System.Drawing.Size(150, 21)
        Me.DriverNameComboBox1.TabIndex = 4
        Me.DriverNameComboBox1.ValueMember = "DriverID"
        '
        'VehicleComboBox
        '
        Me.VehicleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.VehicleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.VehicleComboBox.DataSource = Me.Tbl_Sec_VehicleBindingSource
        Me.VehicleComboBox.DisplayMember = "Vehicle"
        Me.VehicleComboBox.FormattingEnabled = True
        Me.VehicleComboBox.Location = New System.Drawing.Point(104, 23)
        Me.VehicleComboBox.Name = "VehicleComboBox"
        Me.VehicleComboBox.Size = New System.Drawing.Size(150, 21)
        Me.VehicleComboBox.TabIndex = 2
        Me.VehicleComboBox.ValueMember = "Vehicle"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ArtCodeLabel1
        '
        ArtCodeLabel1.Location = New System.Drawing.Point(5, 125)
        ArtCodeLabel1.Name = "ArtCodeLabel1"
        ArtCodeLabel1.Size = New System.Drawing.Size(93, 21)
        ArtCodeLabel1.TabIndex = 15
        ArtCodeLabel1.Text = "Transaction Type:"
        ArtCodeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(5, 152)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(93, 21)
        Label4.TabIndex = 15
        Label4.Text = "Maker/ Party::"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MakerComboBox1
        '
        Me.MakerComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MakerComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MakerComboBox1.DataSource = Me.Tbl_Sec_MakerBindingSource
        Me.MakerComboBox1.DisplayMember = "Maker"
        Me.MakerComboBox1.FormattingEnabled = True
        Me.MakerComboBox1.Location = New System.Drawing.Point(104, 151)
        Me.MakerComboBox1.Name = "MakerComboBox1"
        Me.MakerComboBox1.Size = New System.Drawing.Size(240, 21)
        Me.MakerComboBox1.TabIndex = 8
        Me.MakerComboBox1.ValueMember = "MakerID"
        '
        'FactoryCodeComboBox
        '
        Me.FactoryCodeComboBox.FormattingEnabled = True
        Me.FactoryCodeComboBox.Items.AddRange(New Object() {"B34001", "B34002", "B34003", "B34004", "B34501", "B34502"})
        Me.FactoryCodeComboBox.Location = New System.Drawing.Point(758, 258)
        Me.FactoryCodeComboBox.Name = "FactoryCodeComboBox"
        Me.FactoryCodeComboBox.Size = New System.Drawing.Size(147, 21)
        Me.FactoryCodeComboBox.TabIndex = 35
        Me.FactoryCodeComboBox.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton12)
        Me.GroupBox2.Controls.Add(Me.RadioButton11)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 272)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Selector"
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(10, 128)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(165, 17)
        Me.RadioButton12.TabIndex = 12
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "Inward Report By Party Name"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(10, 172)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(100, 17)
        Me.RadioButton11.TabIndex = 11
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "Outward Report"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(10, 216)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(158, 17)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Issuance Verification Report"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(10, 191)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(190, 17)
        Me.RadioButton9.TabIndex = 9
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Article Issuance Verification Report"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(10, 151)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(173, 17)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Outward Report By Party Name"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(10, 105)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Inward Report"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Location = New System.Drawing.Point(10, 30)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Daily Detail"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(10, 55)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.Text = "Vehicle Detail"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(10, 80)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(83, 17)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.Text = "Driver Detail"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(665, 259)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(92, 20)
        Label5.TabIndex = 34
        Label5.Text = "Factory Code:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label5.Visible = False
        '
        'ArtCodeLabel2
        '
        ArtCodeLabel2.Location = New System.Drawing.Point(665, 233)
        ArtCodeLabel2.Name = "ArtCodeLabel2"
        ArtCodeLabel2.Size = New System.Drawing.Size(92, 20)
        ArtCodeLabel2.TabIndex = 32
        ArtCodeLabel2.Text = "Art Code:"
        ArtCodeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ArtCodeLabel2.Visible = False
        '
        'SesonalRangeComboBox
        '
        Me.SesonalRangeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SesonalRangeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SesonalRangeComboBox.DisplayMember = "SesonalRange"
        Me.SesonalRangeComboBox.FormattingEnabled = True
        Me.SesonalRangeComboBox.Location = New System.Drawing.Point(758, 314)
        Me.SesonalRangeComboBox.Name = "SesonalRangeComboBox"
        Me.SesonalRangeComboBox.Size = New System.Drawing.Size(147, 21)
        Me.SesonalRangeComboBox.TabIndex = 25
        Me.SesonalRangeComboBox.ValueMember = "SesonalRange"
        Me.SesonalRangeComboBox.Visible = False
        '
        'ArtCodeComboBox1
        '
        Me.ArtCodeComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ArtCodeComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ArtCodeComboBox1.DisplayMember = "ArtCode"
        Me.ArtCodeComboBox1.FormattingEnabled = True
        Me.ArtCodeComboBox1.Location = New System.Drawing.Point(758, 232)
        Me.ArtCodeComboBox1.Name = "ArtCodeComboBox1"
        Me.ArtCodeComboBox1.Size = New System.Drawing.Size(147, 21)
        Me.ArtCodeComboBox1.TabIndex = 33
        Me.ArtCodeComboBox1.ValueMember = "ArtCode"
        Me.ArtCodeComboBox1.Visible = False
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(665, 315)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(92, 20)
        Label3.TabIndex = 31
        Label3.Text = "Season Range:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1118, 41)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Gate Inward Outward Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 734)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton10)
        Me.Controls.Add(Me.FactoryCodeComboBox1)
        Me.Controls.Add(Me.RadioButton8)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.FactoryCodeComboBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Label5)
        Me.Controls.Add(ArtCodeLabel2)
        Me.Controls.Add(Me.SesonalRangeComboBox)
        Me.Controls.Add(Me.ArtCodeComboBox1)
        Me.Controls.Add(Label3)
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.Tbl_Sec_MakerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_DriverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSSec As DSSec
    Friend WithEvents Tbl_Sec_MakerBindingSource As BindingSource
    Friend WithEvents Tbl_Sec_MakerTableAdapter As DSSecTableAdapters.tbl_Sec_MakerTableAdapter
    Friend WithEvents TableAdapterManager As DSSecTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Sec_DriverBindingSource As BindingSource
    Friend WithEvents Tbl_Sec_DriverTableAdapter As DSSecTableAdapters.tbl_Sec_DriverTableAdapter
    Friend WithEvents Tbl_Sec_VehicleBindingSource As BindingSource
    Friend WithEvents Tbl_Sec_VehicleTableAdapter As DSSecTableAdapters.tbl_Sec_VehicleTableAdapter
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents FactoryCodeComboBox1 As ComboBox
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents INOUTComboBox As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DriverNameComboBox1 As ComboBox
    Friend WithEvents VehicleComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MakerComboBox1 As ComboBox
    Friend WithEvents FactoryCodeComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents SesonalRangeComboBox As ComboBox
    Friend WithEvents ArtCodeComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
