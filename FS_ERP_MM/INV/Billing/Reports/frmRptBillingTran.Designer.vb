<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRptBillingTran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DayNoLabel As System.Windows.Forms.Label
        Dim DayNoLabel1 As System.Windows.Forms.Label
        Dim ArtCodeLabel1 As System.Windows.Forms.Label
        Dim MakerLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Sec_Enteries_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBilling = New FS_ERP_MM.DSBilling()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MakerComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Sec_Maker_NEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New FS_ERP_MM.DataSet1()
        Me.INOUTComboBox = New System.Windows.Forms.ComboBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnNewRpt = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Billing_PartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDailyTran = New FS_ERP_MM.DsDailyTran()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Billing_PartyTableAdapter = New FS_ERP_MM.DSBillingTableAdapters.tbl_Billing_PartyTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager()
        Me.Tbl_Sec_MakerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Sec_Maker_NEWTableAdapter = New FS_ERP_MM.DataSet1TableAdapters.tbl_Sec_Maker_NEWTableAdapter()
        Me.TableAdapterManager1 = New FS_ERP_MM.DataSet1TableAdapters.TableAdapterManager()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DsDailyTranTableAdapters.tbl_Inv_L4TableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Sec_EnteriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Sec_EnteriesTableAdapter = New FS_ERP_MM.DSBillingTableAdapters.tbl_Sec_EnteriesTableAdapter()
        Me.Tbl_Sec_Enteries_ItemsTableAdapter = New FS_ERP_MM.DSBillingTableAdapters.tbl_Sec_Enteries_ItemsTableAdapter()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        DayNoLabel = New System.Windows.Forms.Label()
        DayNoLabel1 = New System.Windows.Forms.Label()
        ArtCodeLabel1 = New System.Windows.Forms.Label()
        MakerLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Sec_Enteries_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_Maker_NEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Billing_PartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDailyTran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_MakerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Sec_EnteriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DayNoLabel
        '
        DayNoLabel.Location = New System.Drawing.Point(8, 11)
        DayNoLabel.Name = "DayNoLabel"
        DayNoLabel.Size = New System.Drawing.Size(67, 20)
        DayNoLabel.TabIndex = 15
        DayNoLabel.Text = "From Date:"
        DayNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DayNoLabel1
        '
        DayNoLabel1.Location = New System.Drawing.Point(8, 39)
        DayNoLabel1.Name = "DayNoLabel1"
        DayNoLabel1.Size = New System.Drawing.Size(67, 20)
        DayNoLabel1.TabIndex = 16
        DayNoLabel1.Text = "To Date:"
        DayNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ArtCodeLabel1
        '
        ArtCodeLabel1.Location = New System.Drawing.Point(8, 64)
        ArtCodeLabel1.Name = "ArtCodeLabel1"
        ArtCodeLabel1.Size = New System.Drawing.Size(67, 20)
        ArtCodeLabel1.TabIndex = 31
        ArtCodeLabel1.Text = "Trans. Type:"
        ArtCodeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MakerLabel
        '
        MakerLabel.AutoSize = True
        MakerLabel.Location = New System.Drawing.Point(35, 123)
        MakerLabel.Name = "MakerLabel"
        MakerLabel.Size = New System.Drawing.Size(40, 13)
        MakerLabel.TabIndex = 36
        MakerLabel.Text = "Maker:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(22, 172)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 13)
        Label4.TabIndex = 44
        Label4.Text = "Summary:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1046, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Billing Transactions Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(MakerLabel)
        Me.Panel1.Controls.Add(Me.MakerComboBox)
        Me.Panel1.Controls.Add(Me.INOUTComboBox)
        Me.Panel1.Controls.Add(ArtCodeLabel1)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.btnNewRpt)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DTPicker2)
        Me.Panel1.Controls.Add(DayNoLabel)
        Me.Panel1.Controls.Add(DayNoLabel1)
        Me.Panel1.Controls.Add(Me.DTPicker1)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 319)
        Me.Panel1.TabIndex = 17
        '
        'ComboBox4
        '
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Cash Summary by Subhan", "Cash Summary by Zahid", "Cash Summary by Waqas "})
        Me.ComboBox4.Location = New System.Drawing.Point(76, 171)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox4.TabIndex = 57
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(334, 89)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(131, 17)
        Me.CheckBox3.TabIndex = 42
        Me.CheckBox3.Text = "Check For Audit Verify"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataSource = Me.Tbl_Sec_Enteries_ItemsBindingSource
        Me.ComboBox2.DisplayMember = "Item"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(76, 144)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox2.TabIndex = 38
        Me.ComboBox2.ValueMember = "Item"
        '
        'Tbl_Sec_Enteries_ItemsBindingSource
        '
        Me.Tbl_Sec_Enteries_ItemsBindingSource.DataMember = "tbl_Sec_Enteries_Items"
        Me.Tbl_Sec_Enteries_ItemsBindingSource.DataSource = Me.DSBilling
        '
        'DSBilling
        '
        Me.DSBilling.DataSetName = "DSBilling"
        Me.DSBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Item Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MakerComboBox
        '
        Me.MakerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MakerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MakerComboBox.DataSource = Me.Tbl_Sec_Maker_NEWBindingSource
        Me.MakerComboBox.DisplayMember = "Maker"
        Me.MakerComboBox.FormattingEnabled = True
        Me.MakerComboBox.Location = New System.Drawing.Point(76, 117)
        Me.MakerComboBox.Name = "MakerComboBox"
        Me.MakerComboBox.Size = New System.Drawing.Size(236, 21)
        Me.MakerComboBox.TabIndex = 37
        Me.MakerComboBox.ValueMember = "MakerID"
        '
        'Tbl_Sec_Maker_NEWBindingSource
        '
        Me.Tbl_Sec_Maker_NEWBindingSource.DataMember = "tbl_Sec_Maker_NEW"
        Me.Tbl_Sec_Maker_NEWBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INOUTComboBox
        '
        Me.INOUTComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.INOUTComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.INOUTComboBox.FormattingEnabled = True
        Me.INOUTComboBox.Items.AddRange(New Object() {"ALL", "Normal", "Returnable"})
        Me.INOUTComboBox.Location = New System.Drawing.Point(76, 63)
        Me.INOUTComboBox.Name = "INOUTComboBox"
        Me.INOUTComboBox.Size = New System.Drawing.Size(133, 21)
        Me.INOUTComboBox.TabIndex = 32
        Me.INOUTComboBox.Text = "ALL"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(334, 68)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox2.TabIndex = 28
        Me.CheckBox2.Text = "Check For New Report"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(334, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(278, 31)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Check State On for Pending Checked State Off for Done " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In Intermediate State for" &
    " All  Records"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(334, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Check For Filter Records"
        Me.CheckBox1.ThreeState = True
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnNewRpt
        '
        Me.btnNewRpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewRpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRpt.Location = New System.Drawing.Point(497, 231)
        Me.btnNewRpt.Name = "btnNewRpt"
        Me.btnNewRpt.Size = New System.Drawing.Size(102, 40)
        Me.btnNewRpt.TabIndex = 18
        Me.btnNewRpt.Text = "Show Report"
        Me.btnNewRpt.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_Billing_PartyBindingSource
        Me.ComboBox1.DisplayMember = "PartyName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(76, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.ValueMember = "PartyID"
        '
        'Tbl_Billing_PartyBindingSource
        '
        Me.Tbl_Billing_PartyBindingSource.DataMember = "tbl_Billing_Party"
        Me.Tbl_Billing_PartyBindingSource.DataSource = Me.DSBilling
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Party Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPicker2
        '
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(76, 37)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(133, 20)
        Me.DTPicker2.TabIndex = 17
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(76, 11)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(133, 20)
        Me.DTPicker1.TabIndex = 16
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DsDailyTran
        '
        'DsDailyTran
        '
        Me.DsDailyTran.DataSetName = "DsDailyTran"
        Me.DsDailyTran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(6, 291)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(135, 17)
        Me.RadioButton13.TabIndex = 43
        Me.RadioButton13.Text = "Inward Entries  Summry"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(6, 268)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(121, 17)
        Me.RadioButton12.TabIndex = 41
        Me.RadioButton12.Text = "Daily Inward Entries "
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(6, 245)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(207, 17)
        Me.RadioButton11.TabIndex = 40
        Me.RadioButton11.Text = "Daily Billing Transactions By Item Wise"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(6, 222)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(168, 17)
        Me.RadioButton10.TabIndex = 36
        Me.RadioButton10.Text = "Gate Outward Report By Party"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(6, 199)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(160, 17)
        Me.RadioButton9.TabIndex = 35
        Me.RadioButton9.Text = "Gate Inward Report By Party"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(6, 176)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(126, 17)
        Me.RadioButton8.TabIndex = 34
        Me.RadioButton8.Text = "Gate Outward Report"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(6, 155)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(118, 17)
        Me.RadioButton7.TabIndex = 33
        Me.RadioButton7.Text = "Gate Inward Report"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 132)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(200, 17)
        Me.RadioButton6.TabIndex = 30
        Me.RadioButton6.Text = "New Billing Summary Report By Party"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 109)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(158, 17)
        Me.RadioButton5.TabIndex = 29
        Me.RadioButton5.Text = "New Billing Summary Report"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 86)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(133, 17)
        Me.RadioButton4.TabIndex = 27
        Me.RadioButton4.Text = "Billing Summary Report"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 63)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(265, 17)
        Me.RadioButton3.TabIndex = 26
        Me.RadioButton3.Text = "Daily Billing Transactions By Verification Date Wise"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(211, 17)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.Text = "Daily Billing Transactions By Party Wise"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(142, 17)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Daily Billing Transactions"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Tbl_Billing_PartyTableAdapter
        '
        Me.Tbl_Billing_PartyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Billing_PartyTableAdapter = Me.Tbl_Billing_PartyTableAdapter
        Me.TableAdapterManager.tbl_Billing_Transactions_DetailTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Billing_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_Billing_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.View_Tran_INTableAdapter = Nothing
        '
        'Tbl_Sec_MakerBindingSource
        '
        Me.Tbl_Sec_MakerBindingSource.DataSource = Me.DSBilling
        Me.Tbl_Sec_MakerBindingSource.Position = 0
        '
        'Tbl_Sec_Maker_NEWTableAdapter
        '
        Me.Tbl_Sec_Maker_NEWTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton17)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton13)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton12)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton11)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton10)
        Me.GroupBox1.Location = New System.Drawing.Point(639, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 344)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selection"
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Location = New System.Drawing.Point(6, 314)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton17.TabIndex = 44
        Me.RadioButton17.Text = "Inward Entries"
        Me.RadioButton17.UseVisualStyleBackColor = True
        Me.RadioButton17.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton19)
        Me.GroupBox2.Controls.Add(Me.RadioButton18)
        Me.GroupBox2.Controls.Add(Me.RadioButton16)
        Me.GroupBox2.Controls.Add(Me.RadioButton14)
        Me.GroupBox2.Controls.Add(Me.RadioButton15)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 146)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selection"
        Me.GroupBox2.Visible = False
        '
        'RadioButton19
        '
        Me.RadioButton19.AutoSize = True
        Me.RadioButton19.Location = New System.Drawing.Point(12, 111)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(119, 17)
        Me.RadioButton19.TabIndex = 48
        Me.RadioButton19.Text = "By Items and Maker"
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Location = New System.Drawing.Point(12, 88)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton18.TabIndex = 47
        Me.RadioButton18.Text = "By Items"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(12, 65)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(83, 17)
        Me.RadioButton16.TabIndex = 46
        Me.RadioButton16.Text = "By Summary"
        Me.RadioButton16.UseVisualStyleBackColor = True
        Me.RadioButton16.Visible = False
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Location = New System.Drawing.Point(12, 42)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton14.TabIndex = 45
        Me.RadioButton14.Text = "By Maker"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Checked = True
        Me.RadioButton15.Location = New System.Drawing.Point(12, 19)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton15.TabIndex = 44
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.Text = "All"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'Tbl_Sec_EnteriesBindingSource
        '
        Me.Tbl_Sec_EnteriesBindingSource.DataSource = Me.DSBilling
        Me.Tbl_Sec_EnteriesBindingSource.Position = 0
        '
        'Tbl_Sec_EnteriesTableAdapter
        '
        Me.Tbl_Sec_EnteriesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_Enteries_ItemsTableAdapter
        '
        Me.Tbl_Sec_Enteries_ItemsTableAdapter.ClearBeforeFill = True
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.ComboBox3.DisplayMember = "L4Name"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(76, 144)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox3.TabIndex = 58
        Me.ComboBox3.ValueMember = "Code"
        '
        'frmRptBillingTran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 709)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptBillingTran"
        Me.Text = "Billing Transactions Reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Sec_Enteries_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_Maker_NEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Billing_PartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDailyTran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_MakerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_Sec_EnteriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNewRpt As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tbl_Billing_PartyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSBilling As FS_ERP_MM.DSBilling
    Friend WithEvents Tbl_Billing_PartyTableAdapter As FS_ERP_MM.DSBillingTableAdapters.tbl_Billing_PartyTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents INOUTComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents MakerComboBox As ComboBox
    Friend WithEvents Tbl_Sec_MakerBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Tbl_Sec_Maker_NEWBindingSource As BindingSource
    Friend WithEvents Tbl_Sec_Maker_NEWTableAdapter As DataSet1TableAdapters.tbl_Sec_Maker_NEWTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Inv_L4BindingSource As BindingSource
    Friend WithEvents DsDailyTran As DsDailyTran
    Friend WithEvents Tbl_Inv_L4TableAdapter As DsDailyTranTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton19 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents Tbl_Sec_EnteriesBindingSource As BindingSource
    Friend WithEvents Tbl_Sec_EnteriesTableAdapter As DSBillingTableAdapters.tbl_Sec_EnteriesTableAdapter
    Friend WithEvents Tbl_Sec_Enteries_ItemsBindingSource As BindingSource
    Friend WithEvents Tbl_Sec_Enteries_ItemsTableAdapter As DSBillingTableAdapters.tbl_Sec_Enteries_ItemsTableAdapter
    Friend WithEvents ComboBox3 As ComboBox
End Class
