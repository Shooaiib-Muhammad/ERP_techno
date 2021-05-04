<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptPO
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim POIDLabel1 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim POIDLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.Tbl_Pur_PO1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPO = New FS_ERP_MM.DSPO()
        Me.Tbl_Pur_POBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSupp = New FS_ERP_MM.DSSupp()
        Me.Tbl_Pur_POTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_POTableAdapter()
        Me.Tbl_Pur_PO1TableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_PO1TableAdapter()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.POGroup = New System.Windows.Forms.GroupBox()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.POIDComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.POIDComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_L4TableAdapter()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        POIDLabel1 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        POIDLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_Pur_PO1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.POGroup.SuspendLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(10, 179)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 20)
        Label4.TabIndex = 15
        Label4.Text = "Material Name:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(10, 211)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(100, 20)
        Label5.TabIndex = 0
        Label5.Text = "Company Name:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(10, 134)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(100, 20)
        Label6.TabIndex = 5
        Label6.Text = "2nd Date:"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POIDLabel1
        '
        POIDLabel1.Location = New System.Drawing.Point(10, 68)
        POIDLabel1.Name = "POIDLabel1"
        POIDLabel1.Size = New System.Drawing.Size(100, 20)
        POIDLabel1.TabIndex = 2
        POIDLabel1.Text = "PO No:"
        POIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(10, 107)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(100, 20)
        Label7.TabIndex = 4
        Label7.Text = "1st Date:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POIDLabel
        '
        POIDLabel.Location = New System.Drawing.Point(10, 41)
        POIDLabel.Name = "POIDLabel"
        POIDLabel.Size = New System.Drawing.Size(100, 20)
        POIDLabel.TabIndex = 0
        POIDLabel.Text = "PO No:"
        POIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1076, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Purchase Order Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(9, 44)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "PO  Report by PO wise"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(9, 67)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(142, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "PO  Report by Date wise"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(9, 113)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(154, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "PO Report by Supplier wise"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'btnShowReport
        '
        Me.btnShowReport.Location = New System.Drawing.Point(204, 249)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(90, 34)
        Me.btnShowReport.TabIndex = 8
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'Tbl_Pur_PO1BindingSource
        '
        Me.Tbl_Pur_PO1BindingSource.DataMember = "tbl_Pur_PO1"
        Me.Tbl_Pur_PO1BindingSource.DataSource = Me.DSPO
        '
        'DSPO
        '
        Me.DSPO.DataSetName = "DSPO"
        Me.DSPO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Pur_POBindingSource
        '
        Me.Tbl_Pur_POBindingSource.DataMember = "tbl_Pur_PO"
        Me.Tbl_Pur_POBindingSource.DataSource = Me.DSPO
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSSupp
        '
        'DSSupp
        '
        Me.DSSupp.DataSetName = "DSSupp"
        Me.DSSupp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Pur_POTableAdapter
        '
        Me.Tbl_Pur_POTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_PO1TableAdapter
        '
        Me.Tbl_Pur_PO1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 301)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selection"
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton9.Location = New System.Drawing.Point(9, 182)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(183, 17)
        Me.RadioButton9.TabIndex = 6
        Me.RadioButton9.Text = "Purchase Order Summary Report "
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(9, 160)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(169, 17)
        Me.RadioButton8.TabIndex = 5
        Me.RadioButton8.Text = "PO Detail Report by Date wise"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(9, 137)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(161, 17)
        Me.RadioButton7.TabIndex = 4
        Me.RadioButton7.Text = "PO Detail Report by PO wise"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(9, 90)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(153, 17)
        Me.RadioButton6.TabIndex = 3
        Me.RadioButton6.Text = "PO Report by Material wise"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Location = New System.Drawing.Point(237, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 301)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 44)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Single Page"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 67)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton5.TabIndex = 3
        Me.RadioButton5.Text = "Double Page"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'POGroup
        '
        Me.POGroup.Controls.Add(Me.btnShowReport)
        Me.POGroup.Controls.Add(Label4)
        Me.POGroup.Controls.Add(Me.L4NameComboBox)
        Me.POGroup.Controls.Add(Label5)
        Me.POGroup.Controls.Add(Me.CompanyNameComboBox)
        Me.POGroup.Controls.Add(Label6)
        Me.POGroup.Controls.Add(POIDLabel1)
        Me.POGroup.Controls.Add(Me.DateTimePicker2)
        Me.POGroup.Controls.Add(Me.POIDComboBox2)
        Me.POGroup.Controls.Add(Label7)
        Me.POGroup.Controls.Add(Me.DateTimePicker1)
        Me.POGroup.Controls.Add(Me.POIDComboBox1)
        Me.POGroup.Controls.Add(POIDLabel)
        Me.POGroup.Location = New System.Drawing.Point(474, 53)
        Me.POGroup.Name = "POGroup"
        Me.POGroup.Size = New System.Drawing.Size(486, 301)
        Me.POGroup.TabIndex = 8
        Me.POGroup.TabStop = False
        Me.POGroup.Text = "PO Range Selection"
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(112, 178)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(346, 21)
        Me.L4NameComboBox.TabIndex = 14
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSSupp
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.CompanyNameComboBox.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox.Enabled = False
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(112, 210)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(346, 21)
        Me.CompanyNameComboBox.TabIndex = 7
        Me.CompanyNameComboBox.ValueMember = "SupplierID"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(112, 134)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker2.TabIndex = 6
        '
        'POIDComboBox2
        '
        Me.POIDComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.POIDComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POIDComboBox2.DataSource = Me.Tbl_Pur_POBindingSource
        Me.POIDComboBox2.DisplayMember = "POID"
        Me.POIDComboBox2.Enabled = False
        Me.POIDComboBox2.FormattingEnabled = True
        Me.POIDComboBox2.Location = New System.Drawing.Point(112, 40)
        Me.POIDComboBox2.Name = "POIDComboBox2"
        Me.POIDComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.POIDComboBox2.TabIndex = 11
        Me.POIDComboBox2.ValueMember = "POID"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 107)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'POIDComboBox1
        '
        Me.POIDComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.POIDComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POIDComboBox1.DataSource = Me.Tbl_Pur_PO1BindingSource
        Me.POIDComboBox1.DisplayMember = "POID"
        Me.POIDComboBox1.Enabled = False
        Me.POIDComboBox1.FormattingEnabled = True
        Me.POIDComboBox1.Location = New System.Drawing.Point(112, 67)
        Me.POIDComboBox1.Name = "POIDComboBox1"
        Me.POIDComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.POIDComboBox1.TabIndex = 4
        Me.POIDComboBox1.ValueMember = "POID"
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'frmRptPO
        '
        Me.AcceptButton = Me.btnShowReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1076, 552)
        Me.Controls.Add(Me.POGroup)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter PO"
        CType(Me.Tbl_Pur_PO1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.POGroup.ResumeLayout(False)
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowReport As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSPO As FS_ERP_MM.DSPO
    Friend WithEvents Tbl_Pur_POBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_POTableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_POTableAdapter
    Friend WithEvents Tbl_Pur_PO1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_PO1TableAdapter As FS_ERP_MM.DSPOTableAdapters.tbl_Pur_PO1TableAdapter
    Friend WithEvents DSSupp As FS_ERP_MM.DSSupp
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents POGroup As System.Windows.Forms.GroupBox
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents POIDComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents POIDComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSSuppTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
End Class
