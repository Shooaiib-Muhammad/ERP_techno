<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptRepairedBladders
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
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim TranIdLabel As System.Windows.Forms.Label
        Dim TranIdLabel1 As System.Windows.Forms.Label
        Dim TranOutIdLabel As System.Windows.Forms.Label
        Dim TranOutIdLabel1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.DSRptRepairBladers = New FS_ERP_MM.DSRptRepairBladers
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager = New FS_ERP_MM.DSRptRepairBladersTableAdapters.TableAdapterManager
        Me.Tbl_Bladder_Repair_Out1TableAdapter = New FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Bladder_Repair_Out1TableAdapter
        Me.Tbl_Bladder_Repair_OutTableAdapter = New FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Bladder_Repair_OutTableAdapter
        Me.Tbl_Bladder_Winded_Process1TableAdapter = New FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Bladder_Winded_Process1TableAdapter
        Me.Tbl_Bladder_Winded_ProcessTableAdapter = New FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Bladder_Winded_ProcessTableAdapter
        Me.DateNameComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_Bladder_Winded_ProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranIdComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_Bladder_Winded_Process1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranIdComboBox1 = New System.Windows.Forms.ComboBox
        Me.Tbl_Bladder_Repair_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranOutIdComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_Bladder_Repair_Out1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranOutIdComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ExecuterNameComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_Winded_ExectNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSWindedBladderIssuance = New FS_ERP_MM.DSWindedBladderIssuance
        Me.DriverNameTextBox2 = New System.Windows.Forms.TextBox
        Me.VehicleTextBox1 = New System.Windows.Forms.TextBox
        Me.btnShowRpt = New System.Windows.Forms.Button
        Me.Tbl_Winded_ExectNameTableAdapter = New FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.tbl_Winded_ExectNameTableAdapter
        Me.TableAdapterManager1 = New FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.TableAdapterManager
        DateNameLabel = New System.Windows.Forms.Label
        TranIdLabel = New System.Windows.Forms.Label
        TranIdLabel1 = New System.Windows.Forms.Label
        TranOutIdLabel = New System.Windows.Forms.Label
        TranOutIdLabel1 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.DSRptRepairBladers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bladder_Winded_ProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bladder_Winded_Process1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bladder_Repair_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bladder_Repair_Out1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Winded_ExectNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSWindedBladderIssuance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(-3, 25)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(104, 21)
        DateNameLabel.TabIndex = 2
        DateNameLabel.Text = "Date Name:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranIdLabel
        '
        TranIdLabel.Location = New System.Drawing.Point(-3, 54)
        TranIdLabel.Name = "TranIdLabel"
        TranIdLabel.Size = New System.Drawing.Size(104, 21)
        TranIdLabel.TabIndex = 3
        TranIdLabel.Text = "UnWinding Id:"
        TranIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranIdLabel1
        '
        TranIdLabel1.Location = New System.Drawing.Point(-3, 81)
        TranIdLabel1.Name = "TranIdLabel1"
        TranIdLabel1.Size = New System.Drawing.Size(104, 21)
        TranIdLabel1.TabIndex = 4
        TranIdLabel1.Text = "UnWinding Id:"
        TranIdLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranOutIdLabel
        '
        TranOutIdLabel.Location = New System.Drawing.Point(-3, 122)
        TranOutIdLabel.Name = "TranOutIdLabel"
        TranOutIdLabel.Size = New System.Drawing.Size(104, 21)
        TranOutIdLabel.TabIndex = 6
        TranOutIdLabel.Text = "Puncture Bladder Id:"
        TranOutIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranOutIdLabel1
        '
        TranOutIdLabel1.Location = New System.Drawing.Point(-3, 149)
        TranOutIdLabel1.Name = "TranOutIdLabel1"
        TranOutIdLabel1.Size = New System.Drawing.Size(104, 21)
        TranOutIdLabel1.TabIndex = 8
        TranOutIdLabel1.Text = "Puncture Bladder Id:"
        TranOutIdLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(-3, 208)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(104, 21)
        Label3.TabIndex = 35
        Label3.Text = "Driver Name:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(-3, 182)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(104, 21)
        Label2.TabIndex = 34
        Label2.Text = "Vehicle No.:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DSRptRepairBladers
        '
        Me.DSRptRepairBladers.DataSetName = "DSRptRepairBladers"
        Me.DSRptRepairBladers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSRptRepairBladers
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Bladder_Repair_Out1TableAdapter = Me.Tbl_Bladder_Repair_Out1TableAdapter
        Me.TableAdapterManager.tbl_Bladder_Repair_OutTableAdapter = Me.Tbl_Bladder_Repair_OutTableAdapter
        Me.TableAdapterManager.tbl_Bladder_Winded_Process1TableAdapter = Me.Tbl_Bladder_Winded_Process1TableAdapter
        Me.TableAdapterManager.tbl_Bladder_Winded_ProcessTableAdapter = Me.Tbl_Bladder_Winded_ProcessTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Me.Tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSRptRepairBladersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Bladder_Repair_Out1TableAdapter
        '
        Me.Tbl_Bladder_Repair_Out1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Bladder_Repair_OutTableAdapter
        '
        Me.Tbl_Bladder_Repair_OutTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Bladder_Winded_Process1TableAdapter
        '
        Me.Tbl_Bladder_Winded_Process1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Bladder_Winded_ProcessTableAdapter
        '
        Me.Tbl_Bladder_Winded_ProcessTableAdapter.ClearBeforeFill = True
        '
        'DateNameComboBox
        '
        Me.DateNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DateNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DateNameComboBox.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.DateNameComboBox.DisplayMember = "DateName"
        Me.DateNameComboBox.FormattingEnabled = True
        Me.DateNameComboBox.Location = New System.Drawing.Point(104, 24)
        Me.DateNameComboBox.Name = "DateNameComboBox"
        Me.DateNameComboBox.Size = New System.Drawing.Size(140, 21)
        Me.DateNameComboBox.TabIndex = 3
        Me.DateNameComboBox.ValueMember = "DayNo"
        '
        'Tbl_Bladder_Winded_ProcessBindingSource
        '
        Me.Tbl_Bladder_Winded_ProcessBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Bladder_Winded_Process"
        Me.Tbl_Bladder_Winded_ProcessBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'TranIdComboBox
        '
        Me.TranIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TranIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TranIdComboBox.DataSource = Me.Tbl_Bladder_Winded_ProcessBindingSource
        Me.TranIdComboBox.DisplayMember = "TranId"
        Me.TranIdComboBox.FormattingEnabled = True
        Me.TranIdComboBox.Location = New System.Drawing.Point(104, 53)
        Me.TranIdComboBox.Name = "TranIdComboBox"
        Me.TranIdComboBox.Size = New System.Drawing.Size(140, 21)
        Me.TranIdComboBox.TabIndex = 4
        Me.TranIdComboBox.ValueMember = "TranId"
        '
        'Tbl_Bladder_Winded_Process1BindingSource
        '
        Me.Tbl_Bladder_Winded_Process1BindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Bladder_Winded_Process1"
        Me.Tbl_Bladder_Winded_Process1BindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'TranIdComboBox1
        '
        Me.TranIdComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TranIdComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TranIdComboBox1.DataSource = Me.Tbl_Bladder_Winded_Process1BindingSource
        Me.TranIdComboBox1.DisplayMember = "TranId"
        Me.TranIdComboBox1.FormattingEnabled = True
        Me.TranIdComboBox1.Location = New System.Drawing.Point(104, 80)
        Me.TranIdComboBox1.Name = "TranIdComboBox1"
        Me.TranIdComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.TranIdComboBox1.TabIndex = 5
        Me.TranIdComboBox1.ValueMember = "TranId"
        '
        'Tbl_Bladder_Repair_OutBindingSource
        '
        Me.Tbl_Bladder_Repair_OutBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Bladder_Repair_Out"
        Me.Tbl_Bladder_Repair_OutBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'TranOutIdComboBox
        '
        Me.TranOutIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TranOutIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TranOutIdComboBox.DataSource = Me.Tbl_Bladder_Repair_OutBindingSource
        Me.TranOutIdComboBox.DisplayMember = "TranOutId"
        Me.TranOutIdComboBox.FormattingEnabled = True
        Me.TranOutIdComboBox.Location = New System.Drawing.Point(104, 121)
        Me.TranOutIdComboBox.Name = "TranOutIdComboBox"
        Me.TranOutIdComboBox.Size = New System.Drawing.Size(140, 21)
        Me.TranOutIdComboBox.TabIndex = 7
        Me.TranOutIdComboBox.ValueMember = "TranOutId"
        '
        'Tbl_Bladder_Repair_Out1BindingSource
        '
        Me.Tbl_Bladder_Repair_Out1BindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Bladder_Repair_Out1"
        Me.Tbl_Bladder_Repair_Out1BindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'TranOutIdComboBox1
        '
        Me.TranOutIdComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TranOutIdComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TranOutIdComboBox1.DataSource = Me.Tbl_Bladder_Repair_Out1BindingSource
        Me.TranOutIdComboBox1.DisplayMember = "TranOutId"
        Me.TranOutIdComboBox1.FormattingEnabled = True
        Me.TranOutIdComboBox1.Location = New System.Drawing.Point(104, 148)
        Me.TranOutIdComboBox1.Name = "TranOutIdComboBox1"
        Me.TranOutIdComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.TranOutIdComboBox1.TabIndex = 9
        Me.TranOutIdComboBox1.ValueMember = "TranOutId"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1028, 40)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Repairable Bladders Gate Pass Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(153, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 359)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Report"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 74)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(178, 17)
        Me.RadioButton4.TabIndex = 36
        Me.RadioButton4.Text = "Daily Bladders Receiving Report"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 51)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton2.TabIndex = 34
        Me.RadioButton2.Text = "Punctured Bladders Bill"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(136, 17)
        Me.RadioButton1.TabIndex = 33
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Un-Winding Bladder Bill"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ExecuterNameComboBox)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.DriverNameTextBox2)
        Me.GroupBox2.Controls.Add(Me.VehicleTextBox1)
        Me.GroupBox2.Controls.Add(Me.btnShowRpt)
        Me.GroupBox2.Controls.Add(DateNameLabel)
        Me.GroupBox2.Controls.Add(Me.DateNameComboBox)
        Me.GroupBox2.Controls.Add(Me.TranIdComboBox)
        Me.GroupBox2.Controls.Add(TranOutIdLabel1)
        Me.GroupBox2.Controls.Add(TranIdLabel)
        Me.GroupBox2.Controls.Add(Me.TranOutIdComboBox1)
        Me.GroupBox2.Controls.Add(Me.TranIdComboBox1)
        Me.GroupBox2.Controls.Add(TranOutIdLabel)
        Me.GroupBox2.Controls.Add(TranIdLabel1)
        Me.GroupBox2.Controls.Add(Me.TranOutIdComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(471, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 359)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection Criteria"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-3, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Executer Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExecuterNameComboBox
        '
        Me.ExecuterNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ExecuterNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ExecuterNameComboBox.DataSource = Me.Tbl_Winded_ExectNameBindingSource
        Me.ExecuterNameComboBox.DisplayMember = "ExectName"
        Me.ExecuterNameComboBox.FormattingEnabled = True
        Me.ExecuterNameComboBox.Location = New System.Drawing.Point(104, 242)
        Me.ExecuterNameComboBox.Name = "ExecuterNameComboBox"
        Me.ExecuterNameComboBox.Size = New System.Drawing.Size(235, 21)
        Me.ExecuterNameComboBox.TabIndex = 36
        Me.ExecuterNameComboBox.ValueMember = "ExectID"
        '
        'Tbl_Winded_ExectNameBindingSource
        '
        Me.Tbl_Winded_ExectNameBindingSource.DataMember = "tbl_Winded_ExectName"
        Me.Tbl_Winded_ExectNameBindingSource.DataSource = Me.DSWindedBladderIssuance
        '
        'DSWindedBladderIssuance
        '
        Me.DSWindedBladderIssuance.DataSetName = "DSWindedBladderIssuance"
        Me.DSWindedBladderIssuance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DriverNameTextBox2
        '
        Me.DriverNameTextBox2.Location = New System.Drawing.Point(104, 208)
        Me.DriverNameTextBox2.Name = "DriverNameTextBox2"
        Me.DriverNameTextBox2.Size = New System.Drawing.Size(140, 20)
        Me.DriverNameTextBox2.TabIndex = 33
        '
        'VehicleTextBox1
        '
        Me.VehicleTextBox1.Location = New System.Drawing.Point(104, 182)
        Me.VehicleTextBox1.Name = "VehicleTextBox1"
        Me.VehicleTextBox1.Size = New System.Drawing.Size(140, 20)
        Me.VehicleTextBox1.TabIndex = 32
        Me.VehicleTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnShowRpt
        '
        Me.btnShowRpt.BackColor = System.Drawing.Color.Maroon
        Me.btnShowRpt.ForeColor = System.Drawing.Color.Transparent
        Me.btnShowRpt.Location = New System.Drawing.Point(203, 299)
        Me.btnShowRpt.Name = "btnShowRpt"
        Me.btnShowRpt.Size = New System.Drawing.Size(99, 44)
        Me.btnShowRpt.TabIndex = 10
        Me.btnShowRpt.Text = "Show Report"
        Me.btnShowRpt.UseVisualStyleBackColor = False
        '
        'Tbl_Winded_ExectNameTableAdapter
        '
        Me.Tbl_Winded_ExectNameTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Bladder_Repair_OutTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Bladder_Winded_ProcessTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_SupplierTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Winded_ExectNameTableAdapter = Me.Tbl_Winded_ExectNameTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmRptRepairedBladders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 750)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptRepairedBladders"
        Me.Text = "Repairable Bladders Gate Pass Reports"
        CType(Me.DSRptRepairBladers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bladder_Winded_ProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bladder_Winded_Process1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bladder_Repair_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bladder_Repair_Out1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_Winded_ExectNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSWindedBladderIssuance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSRptRepairBladers As FS_ERP_MM.DSRptRepairBladers
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSRptRepairBladersTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Bladder_Winded_ProcessTableAdapter As FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Bladder_Winded_ProcessTableAdapter
    Friend WithEvents DateNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Bladder_Winded_ProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bladder_Winded_Process1TableAdapter As FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Bladder_Winded_Process1TableAdapter
    Friend WithEvents TranIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Bladder_Winded_Process1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bladder_Repair_OutTableAdapter As FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Bladder_Repair_OutTableAdapter
    Friend WithEvents TranIdComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Bladder_Repair_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bladder_Repair_Out1TableAdapter As FS_ERP_MM.DSRptRepairBladersTableAdapters.tbl_Bladder_Repair_Out1TableAdapter
    Friend WithEvents TranOutIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Bladder_Repair_Out1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TranOutIdComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnShowRpt As System.Windows.Forms.Button
    Friend WithEvents DriverNameTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents VehicleTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DSWindedBladderIssuance As FS_ERP_MM.DSWindedBladderIssuance
    Friend WithEvents Tbl_Winded_ExectNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Winded_ExectNameTableAdapter As FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.tbl_Winded_ExectNameTableAdapter
    Friend WithEvents TableAdapterManager1 As FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.TableAdapterManager
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ExecuterNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
End Class
