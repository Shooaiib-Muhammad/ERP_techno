<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMaterialReceiving
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
        Dim DayNoLabel As System.Windows.Forms.Label
        Dim DayNoLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CompanyNameComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Tbl_MM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRpt = New FS_ERP_MM.DSRpt()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTPicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CompanyNameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Supplier1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L4NameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L41BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSRptTableAdapters.tbl_Inv_L4TableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSRptTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_L41TableAdapter = New FS_ERP_MM.DSRptTableAdapters.tbl_Inv_L41TableAdapter()
        Me.Tbl_Inv_Supplier1TableAdapter = New FS_ERP_MM.DSRptTableAdapters.tbl_Inv_Supplier1TableAdapter()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSRptTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_MM_CustomerTableAdapter = New FS_ERP_MM.DSRptTableAdapters.tbl_MM_CustomerTableAdapter()
        DayNoLabel = New System.Windows.Forms.Label()
        DayNoLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Supplier1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L41BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DayNoLabel
        '
        DayNoLabel.Location = New System.Drawing.Point(14, 180)
        DayNoLabel.Name = "DayNoLabel"
        DayNoLabel.Size = New System.Drawing.Size(108, 22)
        DayNoLabel.TabIndex = 18
        DayNoLabel.Text = "Select First Date:"
        DayNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DayNoLabel1
        '
        DayNoLabel1.Location = New System.Drawing.Point(14, 206)
        DayNoLabel1.Name = "DayNoLabel1"
        DayNoLabel1.Size = New System.Drawing.Size(108, 22)
        DayNoLabel1.TabIndex = 19
        DayNoLabel1.Text = "Select Second  Date:"
        DayNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(14, 28)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(108, 22)
        Label2.TabIndex = 22
        Label2.Text = "Company Name:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(14, 55)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(108, 22)
        Label3.TabIndex = 23
        Label3.Text = "Company Name:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(14, 92)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(108, 22)
        Label4.TabIndex = 24
        Label4.Text = "Material Name:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(14, 118)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(108, 22)
        Label5.TabIndex = 25
        Label5.Text = "Material Name:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(37, 232)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(85, 13)
        CompanyNameLabel.TabIndex = 28
        CompanyNameLabel.Text = "Company Name:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(886, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Supplier And Material Wise Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton11)
        Me.GroupBox1.Controls.Add(Me.RadioButton10)
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 363)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(8, 291)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(309, 17)
        Me.RadioButton11.TabIndex = 10
        Me.RadioButton11.Text = "Material Range,Suplier Range And Transaction Date Range"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(8, 85)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(309, 17)
        Me.RadioButton10.TabIndex = 9
        Me.RadioButton10.Text = "Suplier Range,Material Range And Transaction Date Range"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(8, 152)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(309, 17)
        Me.RadioButton9.TabIndex = 8
        Me.RadioButton9.Text = "Material Range,Suplier Range And Transaction Date Range"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(8, 268)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(194, 17)
        Me.RadioButton7.TabIndex = 7
        Me.RadioButton7.Text = "Bladder Receiving By Material Wise"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(8, 249)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(173, 17)
        Me.RadioButton8.TabIndex = 6
        Me.RadioButton8.Text = "Rubber Issuance Material Wise"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(8, 209)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(189, 17)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.Text = "Bladder Receiving By Suplier Wise"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(8, 190)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(168, 17)
        Me.RadioButton6.TabIndex = 4
        Me.RadioButton6.Text = "Rubber Issuance Suplier Wise"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(8, 130)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(239, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Material Range And Transaction Date Range"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(8, 111)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Material Range"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 62)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(240, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Supplier Range And Transaction Date Range"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 39)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Supplier Range"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(CompanyNameLabel)
        Me.GroupBox2.Controls.Add(Me.CompanyNameComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.DTPicker2)
        Me.GroupBox2.Controls.Add(DayNoLabel)
        Me.GroupBox2.Controls.Add(DayNoLabel1)
        Me.GroupBox2.Controls.Add(Me.DTPicker1)
        Me.GroupBox2.Controls.Add(Me.CompanyNameComboBox1)
        Me.GroupBox2.Controls.Add(Me.CompanyNameComboBox)
        Me.GroupBox2.Controls.Add(Me.L4NameComboBox1)
        Me.GroupBox2.Controls.Add(Me.L4NameComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 377)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selector"
        '
        'CompanyNameComboBox2
        '
        Me.CompanyNameComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox2.DataSource = Me.Tbl_MM_CustomerBindingSource
        Me.CompanyNameComboBox2.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox2.FormattingEnabled = True
        Me.CompanyNameComboBox2.Location = New System.Drawing.Point(125, 229)
        Me.CompanyNameComboBox2.Name = "CompanyNameComboBox2"
        Me.CompanyNameComboBox2.Size = New System.Drawing.Size(214, 21)
        Me.CompanyNameComboBox2.TabIndex = 29
        Me.CompanyNameComboBox2.ValueMember = "CustID"
        '
        'Tbl_MM_CustomerBindingSource
        '
        Me.Tbl_MM_CustomerBindingSource.DataMember = "tbl_MM_Customer"
        Me.Tbl_MM_CustomerBindingSource.DataSource = Me.DSRpt
        '
        'DSRpt
        '
        Me.DSRpt.DataSetName = "DSRpt"
        Me.DSRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL", "MRI", "MLRN", "MBRN"})
        Me.ComboBox1.Location = New System.Drawing.Point(125, 143)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(14, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 22)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Inward Type:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 31)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DTPicker2
        '
        Me.DTPicker2.Enabled = False
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(125, 206)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(150, 20)
        Me.DTPicker2.TabIndex = 21
        '
        'DTPicker1
        '
        Me.DTPicker1.Enabled = False
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(125, 180)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(150, 20)
        Me.DTPicker1.TabIndex = 20
        '
        'CompanyNameComboBox1
        '
        Me.CompanyNameComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox1.DataSource = Me.Tbl_Inv_Supplier1BindingSource
        Me.CompanyNameComboBox1.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox1.Enabled = False
        Me.CompanyNameComboBox1.FormattingEnabled = True
        Me.CompanyNameComboBox1.Location = New System.Drawing.Point(125, 54)
        Me.CompanyNameComboBox1.Name = "CompanyNameComboBox1"
        Me.CompanyNameComboBox1.Size = New System.Drawing.Size(214, 21)
        Me.CompanyNameComboBox1.TabIndex = 7
        Me.CompanyNameComboBox1.ValueMember = "SupplierID"
        '
        'Tbl_Inv_Supplier1BindingSource
        '
        Me.Tbl_Inv_Supplier1BindingSource.DataMember = "tbl_Inv_Supplier1"
        Me.Tbl_Inv_Supplier1BindingSource.DataSource = Me.DSRpt
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.CompanyNameComboBox.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox.Enabled = False
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(125, 27)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(214, 21)
        Me.CompanyNameComboBox.TabIndex = 5
        Me.CompanyNameComboBox.ValueMember = "SupplierID"
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSRpt
        '
        'L4NameComboBox1
        '
        Me.L4NameComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox1.DataSource = Me.Tbl_Inv_L41BindingSource
        Me.L4NameComboBox1.DisplayMember = "L4Name"
        Me.L4NameComboBox1.Enabled = False
        Me.L4NameComboBox1.FormattingEnabled = True
        Me.L4NameComboBox1.Location = New System.Drawing.Point(125, 117)
        Me.L4NameComboBox1.Name = "L4NameComboBox1"
        Me.L4NameComboBox1.Size = New System.Drawing.Size(214, 21)
        Me.L4NameComboBox1.TabIndex = 3
        Me.L4NameComboBox1.ValueMember = "Code"
        '
        'Tbl_Inv_L41BindingSource
        '
        Me.Tbl_Inv_L41BindingSource.DataMember = "tbl_Inv_L41"
        Me.Tbl_Inv_L41BindingSource.DataSource = Me.DSRpt
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.Enabled = False
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(125, 91)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(214, 21)
        Me.L4NameComboBox.TabIndex = 1
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSRpt
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L41TableAdapter = Me.Tbl_Inv_L41TableAdapter
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager.tbl_Inv_Supplier1TableAdapter = Me.Tbl_Inv_Supplier1TableAdapter
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Me.Tbl_Inv_SupplierTableAdapter
        Me.TableAdapterManager.tbl_MM_CustomerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Prd_LinesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_Plan1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_Plan2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSRptTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_L41TableAdapter
        '
        Me.Tbl_Inv_L41TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Supplier1TableAdapter
        '
        Me.Tbl_Inv_Supplier1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_CustomerTableAdapter
        '
        Me.Tbl_MM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'frmRptMaterialReceiving
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptMaterialReceiving"
        Me.Text = "Supplier And Material Wise Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Supplier1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L41BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DSRpt As FS_ERP_MM.DSRpt
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSRptTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSRptTableAdapters.TableAdapterManager
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L41TableAdapter As FS_ERP_MM.DSRptTableAdapters.tbl_Inv_L41TableAdapter
    Friend WithEvents Tbl_Inv_L41BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents L4NameComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSRptTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_Supplier1TableAdapter As FS_ERP_MM.DSRptTableAdapters.tbl_Inv_Supplier1TableAdapter
    Friend WithEvents Tbl_Inv_Supplier1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyNameComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DTPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_MM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_CustomerTableAdapter As FS_ERP_MM.DSRptTableAdapters.tbl_MM_CustomerTableAdapter
    Friend WithEvents CompanyNameComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
End Class
