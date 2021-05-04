<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMaker
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
        Me.Tbl_MakersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSNewTranIn = New FS_ERP_MM.DSNewTranIn()
        Me.Tbl_MakersTableAdapter = New FS_ERP_MM.DSNewTranInTableAdapters.tbl_MakersTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MakerComboBox = New System.Windows.Forms.ComboBox()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.btnNewRpt = New System.Windows.Forms.Button()
        Me.DTPicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        DayNoLabel = New System.Windows.Forms.Label()
        DayNoLabel1 = New System.Windows.Forms.Label()
        CType(Me.Tbl_MakersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSNewTranIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DayNoLabel
        '
        DayNoLabel.Location = New System.Drawing.Point(6, 23)
        DayNoLabel.Name = "DayNoLabel"
        DayNoLabel.Size = New System.Drawing.Size(71, 21)
        DayNoLabel.TabIndex = 15
        DayNoLabel.Text = "From Date:"
        DayNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DayNoLabel1
        '
        DayNoLabel1.Location = New System.Drawing.Point(6, 48)
        DayNoLabel1.Name = "DayNoLabel1"
        DayNoLabel1.Size = New System.Drawing.Size(71, 21)
        DayNoLabel1.TabIndex = 16
        DayNoLabel1.Text = "To Date:"
        DayNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_MakersBindingSource
        '
        Me.Tbl_MakersBindingSource.DataMember = "tbl_Makers"
        Me.Tbl_MakersBindingSource.DataSource = Me.DSNewTranIn
        '
        'DSNewTranIn
        '
        Me.DSNewTranIn.DataSetName = "DSNewTranIn"
        Me.DSNewTranIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_MakersTableAdapter
        '
        Me.Tbl_MakersTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Maker Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MakerComboBox
        '
        Me.MakerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MakerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MakerComboBox.DataSource = Me.Tbl_MakersBindingSource
        Me.MakerComboBox.DisplayMember = "MakerName"
        Me.MakerComboBox.FormattingEnabled = True
        Me.MakerComboBox.Location = New System.Drawing.Point(83, 81)
        Me.MakerComboBox.Name = "MakerComboBox"
        Me.MakerComboBox.Size = New System.Drawing.Size(173, 21)
        Me.MakerComboBox.TabIndex = 36
        Me.MakerComboBox.ValueMember = "MakerID"
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Checked = True
        Me.RadioButton10.Location = New System.Drawing.Point(6, 27)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton10.TabIndex = 33
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Weekly Bill Report "
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'btnNewRpt
        '
        Me.btnNewRpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewRpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRpt.Location = New System.Drawing.Point(543, 187)
        Me.btnNewRpt.Name = "btnNewRpt"
        Me.btnNewRpt.Size = New System.Drawing.Size(102, 41)
        Me.btnNewRpt.TabIndex = 18
        Me.btnNewRpt.Text = "Show Report"
        Me.btnNewRpt.UseVisualStyleBackColor = False
        '
        'DTPicker2
        '
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(83, 49)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(173, 20)
        Me.DTPicker2.TabIndex = 17
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(83, 24)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(173, 20)
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
        Me.Label1.Size = New System.Drawing.Size(985, 40)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Weekly Maker Bill Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(DayNoLabel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTPicker1)
        Me.GroupBox1.Controls.Add(DayNoLabel1)
        Me.GroupBox1.Controls.Add(Me.MakerComboBox)
        Me.GroupBox1.Controls.Add(Me.DTPicker2)
        Me.GroupBox1.Location = New System.Drawing.Point(128, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 138)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.Location = New System.Drawing.Point(445, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 138)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Criteria"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton11)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Location = New System.Drawing.Point(128, 187)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 69)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selector"
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(9, 39)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton11.TabIndex = 35
        Me.RadioButton11.Text = "Accounts Copy"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(9, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton1.TabIndex = 34
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Maker Copy"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 53)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(146, 17)
        Me.RadioButton2.TabIndex = 36
        Me.RadioButton2.Text = "AMB Printed Ball Balance"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'frmRptMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 394)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewRpt)
        Me.Name = "frmRptMaker"
        Me.Text = "Weekly Maker Bill Report"
        CType(Me.Tbl_MakersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSNewTranIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tbl_MakersBindingSource As BindingSource
    Friend WithEvents DSNewTranIn As DSNewTranIn
    Friend WithEvents Tbl_MakersTableAdapter As DSNewTranInTableAdapters.tbl_MakersTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents MakerComboBox As ComboBox
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents btnNewRpt As Button
    Friend WithEvents DTPicker2 As DateTimePicker
    Friend WithEvents DTPicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
