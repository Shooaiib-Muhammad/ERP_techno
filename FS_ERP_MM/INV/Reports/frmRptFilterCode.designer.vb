<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptFilterCode
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
        Dim Layer1IDLabel As System.Windows.Forms.Label
        Dim L2NameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.DSRptCode = New FS_ERP_MM.DSRptCode()
        Me.Tbl_Inv_L11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L11TableAdapter = New FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L11TableAdapter()
        Me.Tbl_Inv_L12BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L12TableAdapter = New FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L12TableAdapter()
        Me.btnRptShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Layer1IDComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Layer1IDComboBox = New System.Windows.Forms.ComboBox()
        Me.L4NameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L42BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L41BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L3NameComboBox = New System.Windows.Forms.ComboBox()
        Me.L2NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L2TableAdapter = New FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L2TableAdapter()
        Me.Tbl_Inv_L3TableAdapter = New FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L3TableAdapter()
        Me.Tbl_Inv_L41TableAdapter = New FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L41TableAdapter()
        Me.Tbl_Inv_L42TableAdapter = New FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L42TableAdapter()
        Layer1IDLabel = New System.Windows.Forms.Label()
        L2NameLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.DSRptCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L12BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Inv_L42BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L41BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Layer1IDLabel
        '
        Layer1IDLabel.Location = New System.Drawing.Point(34, 36)
        Layer1IDLabel.Name = "Layer1IDLabel"
        Layer1IDLabel.Size = New System.Drawing.Size(98, 21)
        Layer1IDLabel.TabIndex = 1
        Layer1IDLabel.Text = "Select Layer 1:"
        Layer1IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L2NameLabel
        '
        L2NameLabel.Location = New System.Drawing.Point(34, 98)
        L2NameLabel.Name = "L2NameLabel"
        L2NameLabel.Size = New System.Drawing.Size(98, 20)
        L2NameLabel.TabIndex = 6
        L2NameLabel.Text = "Tier2 Name:"
        L2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(34, 132)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(98, 20)
        Label2.TabIndex = 13
        Label2.Text = "Tier3 Name:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(34, 169)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(98, 20)
        Label3.TabIndex = 14
        Label3.Text = "Tier4 Name:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(34, 196)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(98, 20)
        Label4.TabIndex = 15
        Label4.Text = "Tier 4 Name:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(34, 62)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(98, 21)
        Label5.TabIndex = 17
        Label5.Text = "Select Layer 1:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DSRptCode
        '
        Me.DSRptCode.DataSetName = "DSRptCode"
        Me.DSRptCode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Inv_L11BindingSource
        '
        Me.Tbl_Inv_L11BindingSource.DataMember = "tbl_Inv_L11"
        Me.Tbl_Inv_L11BindingSource.DataSource = Me.DSRptCode
        '
        'Tbl_Inv_L11TableAdapter
        '
        Me.Tbl_Inv_L11TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L12BindingSource
        '
        Me.Tbl_Inv_L12BindingSource.DataMember = "tbl_Inv_L12"
        Me.Tbl_Inv_L12BindingSource.DataSource = Me.DSRptCode
        '
        'Tbl_Inv_L12TableAdapter
        '
        Me.Tbl_Inv_L12TableAdapter.ClearBeforeFill = True
        '
        'btnRptShow
        '
        Me.btnRptShow.Location = New System.Drawing.Point(250, 229)
        Me.btnRptShow.Name = "btnRptShow"
        Me.btnRptShow.Size = New System.Drawing.Size(99, 37)
        Me.btnRptShow.TabIndex = 6
        Me.btnRptShow.Text = "Show Report"
        Me.btnRptShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(952, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Chart of Materials Accounts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 281)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(27, 121)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(152, 17)
        Me.RadioButton5.TabIndex = 12
        Me.RadioButton5.Text = "Complete Chart of Account"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(27, 98)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(150, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Tier Four Chart of Account"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(27, 75)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(157, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Tier Three Chart of Account"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(27, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(150, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Tier Two Chart of Account"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(27, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(149, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Tier One Chart of Account"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Layer1IDComboBox1)
        Me.GroupBox2.Controls.Add(Me.Layer1IDComboBox)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.L4NameComboBox1)
        Me.GroupBox2.Controls.Add(Me.L4NameComboBox)
        Me.GroupBox2.Controls.Add(Me.L3NameComboBox)
        Me.GroupBox2.Controls.Add(L2NameLabel)
        Me.GroupBox2.Controls.Add(Me.L2NameComboBox)
        Me.GroupBox2.Controls.Add(Me.btnRptShow)
        Me.GroupBox2.Controls.Add(Layer1IDLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(404, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 281)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selector"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(138, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(174, 17)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "Check to get Enabled Materials"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Layer1IDComboBox1
        '
        Me.Layer1IDComboBox1.DataSource = Me.Tbl_Inv_L12BindingSource
        Me.Layer1IDComboBox1.DisplayMember = "L1Name"
        Me.Layer1IDComboBox1.FormattingEnabled = True
        Me.Layer1IDComboBox1.Location = New System.Drawing.Point(138, 62)
        Me.Layer1IDComboBox1.Name = "Layer1IDComboBox1"
        Me.Layer1IDComboBox1.Size = New System.Drawing.Size(211, 21)
        Me.Layer1IDComboBox1.TabIndex = 21
        Me.Layer1IDComboBox1.ValueMember = "Layer1ID"
        '
        'Layer1IDComboBox
        '
        Me.Layer1IDComboBox.DataSource = Me.Tbl_Inv_L11BindingSource
        Me.Layer1IDComboBox.DisplayMember = "L1Name"
        Me.Layer1IDComboBox.FormattingEnabled = True
        Me.Layer1IDComboBox.Location = New System.Drawing.Point(138, 36)
        Me.Layer1IDComboBox.Name = "Layer1IDComboBox"
        Me.Layer1IDComboBox.Size = New System.Drawing.Size(211, 21)
        Me.Layer1IDComboBox.TabIndex = 20
        Me.Layer1IDComboBox.ValueMember = "Layer1ID"
        '
        'L4NameComboBox1
        '
        Me.L4NameComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox1.DataSource = Me.Tbl_Inv_L42BindingSource
        Me.L4NameComboBox1.DisplayMember = "L4Name"
        Me.L4NameComboBox1.Enabled = False
        Me.L4NameComboBox1.FormattingEnabled = True
        Me.L4NameComboBox1.Location = New System.Drawing.Point(138, 195)
        Me.L4NameComboBox1.Name = "L4NameComboBox1"
        Me.L4NameComboBox1.Size = New System.Drawing.Size(211, 21)
        Me.L4NameComboBox1.TabIndex = 12
        Me.L4NameComboBox1.ValueMember = "Layer4ID"
        '
        'Tbl_Inv_L42BindingSource
        '
        Me.Tbl_Inv_L42BindingSource.DataMember = "tbl_Inv_L3_tbl_Inv_L42"
        Me.Tbl_Inv_L42BindingSource.DataSource = Me.Tbl_Inv_L3BindingSource
        '
        'Tbl_Inv_L3BindingSource
        '
        Me.Tbl_Inv_L3BindingSource.DataMember = "tbl_Inv_L2_tbl_Inv_L3"
        Me.Tbl_Inv_L3BindingSource.DataSource = Me.Tbl_Inv_L2BindingSource
        '
        'Tbl_Inv_L2BindingSource
        '
        Me.Tbl_Inv_L2BindingSource.DataMember = "tbl_Inv_L11_tbl_Inv_L2"
        Me.Tbl_Inv_L2BindingSource.DataSource = Me.Tbl_Inv_L11BindingSource
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L41BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.Enabled = False
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(138, 168)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(211, 21)
        Me.L4NameComboBox.TabIndex = 10
        Me.L4NameComboBox.ValueMember = "Layer4ID"
        '
        'Tbl_Inv_L41BindingSource
        '
        Me.Tbl_Inv_L41BindingSource.DataMember = "tbl_Inv_L3_tbl_Inv_L41"
        Me.Tbl_Inv_L41BindingSource.DataSource = Me.Tbl_Inv_L3BindingSource
        '
        'L3NameComboBox
        '
        Me.L3NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L3NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L3NameComboBox.DataSource = Me.Tbl_Inv_L3BindingSource
        Me.L3NameComboBox.DisplayMember = "L3Name"
        Me.L3NameComboBox.Enabled = False
        Me.L3NameComboBox.FormattingEnabled = True
        Me.L3NameComboBox.Location = New System.Drawing.Point(138, 131)
        Me.L3NameComboBox.Name = "L3NameComboBox"
        Me.L3NameComboBox.Size = New System.Drawing.Size(211, 21)
        Me.L3NameComboBox.TabIndex = 8
        Me.L3NameComboBox.ValueMember = "Layer3ID"
        '
        'L2NameComboBox
        '
        Me.L2NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L2NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L2NameComboBox.DataSource = Me.Tbl_Inv_L2BindingSource
        Me.L2NameComboBox.DisplayMember = "L2Name"
        Me.L2NameComboBox.Enabled = False
        Me.L2NameComboBox.FormattingEnabled = True
        Me.L2NameComboBox.Location = New System.Drawing.Point(138, 97)
        Me.L2NameComboBox.Name = "L2NameComboBox"
        Me.L2NameComboBox.Size = New System.Drawing.Size(211, 21)
        Me.L2NameComboBox.TabIndex = 7
        Me.L2NameComboBox.ValueMember = "Layer2ID"
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
        'frmRptFilterCode
        '
        Me.AcceptButton = Me.btnRptShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 483)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmRptFilterCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRptFilterCode"
        CType(Me.DSRptCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L12BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_Inv_L42BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L41BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSRptCode As FS_ERP_MM.DSRptCode
    Friend WithEvents Tbl_Inv_L11BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L11TableAdapter As FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L11TableAdapter
    Friend WithEvents Tbl_Inv_L12BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L12TableAdapter As FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L12TableAdapter
    Friend WithEvents btnRptShow As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_Inv_L2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L2TableAdapter As FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L2TableAdapter
    Friend WithEvents L2NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L3TableAdapter As FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L3TableAdapter
    Friend WithEvents L3NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L41BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L41TableAdapter As FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L41TableAdapter
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L42BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L42TableAdapter As FS_ERP_MM.DSRptCodeTableAdapters.tbl_Inv_L42TableAdapter
    Friend WithEvents L4NameComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Layer1IDComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Layer1IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
