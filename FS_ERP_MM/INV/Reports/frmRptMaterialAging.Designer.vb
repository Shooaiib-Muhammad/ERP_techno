<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMaterialAging
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Layer1IDLabel = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.btnShowRpt = New System.Windows.Forms.Button()
        Me.Layer3IDLabel = New System.Windows.Forms.Label()
        Me.Layer2IDLabel = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L41BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRptL4Code = New FS_ERP_MM.DSRptL4Code()
        Me.Layer3IDComboBox = New System.Windows.Forms.ComboBox()
        Me.Layer2IDComboBox = New System.Windows.Forms.ComboBox()
        Me.CodeLabel3 = New System.Windows.Forms.Label()
        Me.CodeLabel2 = New System.Windows.Forms.Label()
        Me.Layer1IDComboBox = New System.Windows.Forms.ComboBox()
        Me.CodeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L42BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Inv_L1TableAdapter = New FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L1TableAdapter()
        Me.Tbl_Inv_L2TableAdapter = New FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L2TableAdapter()
        Me.Tbl_Inv_L3TableAdapter = New FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L3TableAdapter()
        Me.Tbl_Inv_L41TableAdapter = New FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L41TableAdapter()
        Me.Tbl_Inv_L42TableAdapter = New FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L42TableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Inv_L41BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRptL4Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L42BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(870, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Material Aging Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Layer1IDLabel)
        Me.GroupBox2.Controls.Add(Me.lblDate1)
        Me.GroupBox2.Controls.Add(Me.btnShowRpt)
        Me.GroupBox2.Controls.Add(Me.Layer3IDLabel)
        Me.GroupBox2.Controls.Add(Me.Layer2IDLabel)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.CodeComboBox)
        Me.GroupBox2.Controls.Add(Me.Layer3IDComboBox)
        Me.GroupBox2.Controls.Add(Me.Layer2IDComboBox)
        Me.GroupBox2.Controls.Add(Me.CodeLabel3)
        Me.GroupBox2.Controls.Add(Me.CodeLabel2)
        Me.GroupBox2.Controls.Add(Me.Layer1IDComboBox)
        Me.GroupBox2.Controls.Add(Me.CodeComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(376, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 274)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection Criteria"
        '
        'Layer1IDLabel
        '
        Me.Layer1IDLabel.Location = New System.Drawing.Point(21, 26)
        Me.Layer1IDLabel.Name = "Layer1IDLabel"
        Me.Layer1IDLabel.Size = New System.Drawing.Size(104, 20)
        Me.Layer1IDLabel.TabIndex = 9
        Me.Layer1IDLabel.Text = "Layer 1:"
        Me.Layer1IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDate1
        '
        Me.lblDate1.Location = New System.Drawing.Point(21, 181)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(104, 20)
        Me.lblDate1.TabIndex = 25
        Me.lblDate1.Text = "Select Date:"
        Me.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnShowRpt
        '
        Me.btnShowRpt.Location = New System.Drawing.Point(197, 227)
        Me.btnShowRpt.Name = "btnShowRpt"
        Me.btnShowRpt.Size = New System.Drawing.Size(99, 37)
        Me.btnShowRpt.TabIndex = 6
        Me.btnShowRpt.Text = "Show Report"
        Me.btnShowRpt.UseVisualStyleBackColor = True
        '
        'Layer3IDLabel
        '
        Me.Layer3IDLabel.Location = New System.Drawing.Point(21, 80)
        Me.Layer3IDLabel.Name = "Layer3IDLabel"
        Me.Layer3IDLabel.Size = New System.Drawing.Size(104, 20)
        Me.Layer3IDLabel.TabIndex = 11
        Me.Layer3IDLabel.Text = "Layer 3:"
        Me.Layer3IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Layer2IDLabel
        '
        Me.Layer2IDLabel.Location = New System.Drawing.Point(21, 53)
        Me.Layer2IDLabel.Name = "Layer2IDLabel"
        Me.Layer2IDLabel.Size = New System.Drawing.Size(104, 20)
        Me.Layer2IDLabel.TabIndex = 10
        Me.Layer2IDLabel.Text = "Layer 2:"
        Me.Layer2IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(131, 181)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(165, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'CodeComboBox
        '
        Me.CodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CodeComboBox.DataSource = Me.Tbl_Inv_L41BindingSource
        Me.CodeComboBox.DisplayMember = "L4Name"
        Me.CodeComboBox.FormattingEnabled = True
        Me.CodeComboBox.Location = New System.Drawing.Point(130, 120)
        Me.CodeComboBox.Name = "CodeComboBox"
        Me.CodeComboBox.Size = New System.Drawing.Size(165, 21)
        Me.CodeComboBox.TabIndex = 13
        Me.CodeComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L41BindingSource
        '
        Me.Tbl_Inv_L41BindingSource.DataMember = "tbl_Inv_L3_tbl_Inv_L41"
        Me.Tbl_Inv_L41BindingSource.DataSource = Me.Tbl_Inv_L3BindingSource
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
        'Layer3IDComboBox
        '
        Me.Layer3IDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Layer3IDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Layer3IDComboBox.DataSource = Me.Tbl_Inv_L3BindingSource
        Me.Layer3IDComboBox.DisplayMember = "L3Name"
        Me.Layer3IDComboBox.FormattingEnabled = True
        Me.Layer3IDComboBox.Location = New System.Drawing.Point(130, 79)
        Me.Layer3IDComboBox.Name = "Layer3IDComboBox"
        Me.Layer3IDComboBox.Size = New System.Drawing.Size(165, 21)
        Me.Layer3IDComboBox.TabIndex = 12
        Me.Layer3IDComboBox.ValueMember = "Layer3ID"
        '
        'Layer2IDComboBox
        '
        Me.Layer2IDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Layer2IDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Layer2IDComboBox.DataSource = Me.Tbl_Inv_L2BindingSource
        Me.Layer2IDComboBox.DisplayMember = "L2Name"
        Me.Layer2IDComboBox.FormattingEnabled = True
        Me.Layer2IDComboBox.Location = New System.Drawing.Point(130, 52)
        Me.Layer2IDComboBox.Name = "Layer2IDComboBox"
        Me.Layer2IDComboBox.Size = New System.Drawing.Size(165, 21)
        Me.Layer2IDComboBox.TabIndex = 11
        Me.Layer2IDComboBox.ValueMember = "Layer2ID"
        '
        'CodeLabel3
        '
        Me.CodeLabel3.Location = New System.Drawing.Point(21, 146)
        Me.CodeLabel3.Name = "CodeLabel3"
        Me.CodeLabel3.Size = New System.Drawing.Size(104, 20)
        Me.CodeLabel3.TabIndex = 13
        Me.CodeLabel3.Text = "Select 2nd Material:"
        Me.CodeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodeLabel2
        '
        Me.CodeLabel2.Location = New System.Drawing.Point(21, 121)
        Me.CodeLabel2.Name = "CodeLabel2"
        Me.CodeLabel2.Size = New System.Drawing.Size(104, 20)
        Me.CodeLabel2.TabIndex = 12
        Me.CodeLabel2.Text = "Select 1st Material:"
        Me.CodeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Layer1IDComboBox
        '
        Me.Layer1IDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Layer1IDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Layer1IDComboBox.DataSource = Me.Tbl_Inv_L1BindingSource
        Me.Layer1IDComboBox.DisplayMember = "L1Name"
        Me.Layer1IDComboBox.FormattingEnabled = True
        Me.Layer1IDComboBox.Location = New System.Drawing.Point(130, 25)
        Me.Layer1IDComboBox.Name = "Layer1IDComboBox"
        Me.Layer1IDComboBox.Size = New System.Drawing.Size(165, 21)
        Me.Layer1IDComboBox.TabIndex = 10
        Me.Layer1IDComboBox.ValueMember = "Layer1ID"
        '
        'CodeComboBox1
        '
        Me.CodeComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CodeComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CodeComboBox1.DataSource = Me.Tbl_Inv_L42BindingSource
        Me.CodeComboBox1.DisplayMember = "L4Name"
        Me.CodeComboBox1.FormattingEnabled = True
        Me.CodeComboBox1.Location = New System.Drawing.Point(130, 145)
        Me.CodeComboBox1.Name = "CodeComboBox1"
        Me.CodeComboBox1.Size = New System.Drawing.Size(165, 21)
        Me.CodeComboBox1.TabIndex = 14
        Me.CodeComboBox1.ValueMember = "Code"
        '
        'Tbl_Inv_L42BindingSource
        '
        Me.Tbl_Inv_L42BindingSource.DataMember = "tbl_Inv_L3_tbl_Inv_L42"
        Me.Tbl_Inv_L42BindingSource.DataSource = Me.Tbl_Inv_L3BindingSource
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton10)
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(105, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 274)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(109, 30)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(154, 17)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "Material With Active Status"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 30)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton2.TabIndex = 34
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "All"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(6, 95)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(142, 17)
        Me.RadioButton10.TabIndex = 33
        Me.RadioButton10.Text = "Layer 3 Material Balance"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(6, 74)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(142, 17)
        Me.RadioButton9.TabIndex = 32
        Me.RadioButton9.Text = "Layer 2 Material Balance"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 52)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(142, 17)
        Me.RadioButton6.TabIndex = 29
        Me.RadioButton6.Text = "Layer 1 Material Balance"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 116)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(142, 17)
        Me.RadioButton1.TabIndex = 21
        Me.RadioButton1.Text = "Layer 4 Material Balance"
        Me.RadioButton1.UseVisualStyleBackColor = True
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
        'Tbl_Inv_L41TableAdapter
        '
        Me.Tbl_Inv_L41TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L42TableAdapter
        '
        Me.Tbl_Inv_L42TableAdapter.ClearBeforeFill = True
        '
        'frmRptMaterialAging
        '
        Me.AcceptButton = Me.btnShowRpt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 444)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptMaterialAging"
        Me.Text = "Material Aging"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Tbl_Inv_L41BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRptL4Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L42BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Layer1IDLabel As System.Windows.Forms.Label
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents btnShowRpt As System.Windows.Forms.Button
    Friend WithEvents Layer3IDLabel As System.Windows.Forms.Label
    Friend WithEvents Layer2IDLabel As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CodeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Layer3IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Layer2IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CodeLabel3 As System.Windows.Forms.Label
    Friend WithEvents CodeLabel2 As System.Windows.Forms.Label
    Friend WithEvents Layer1IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CodeComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents DSRptL4Code As FS_ERP_MM.DSRptL4Code
    Friend WithEvents Tbl_Inv_L1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L1TableAdapter As FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L1TableAdapter
    Friend WithEvents Tbl_Inv_L2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L2TableAdapter As FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L2TableAdapter
    Friend WithEvents Tbl_Inv_L3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L3TableAdapter As FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L3TableAdapter
    Friend WithEvents Tbl_Inv_L41BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L41TableAdapter As FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L41TableAdapter
    Friend WithEvents Tbl_Inv_L42BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L42TableAdapter As FS_ERP_MM.DSRptL4CodeTableAdapters.tbl_Inv_L42TableAdapter
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
