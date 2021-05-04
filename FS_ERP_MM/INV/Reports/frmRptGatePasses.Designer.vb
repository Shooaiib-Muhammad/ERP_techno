<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptGatePasses
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
        Dim TranOutIDLabel As System.Windows.Forms.Label
        Dim TranOutIDLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DriverNameTextBox2 = New System.Windows.Forms.TextBox()
        Me.VehicleTextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TranOutIDComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Tran_Out1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRptGatePasses = New FS_ERP_MM.DSRptGatePasses()
        Me.TranOutIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Tran_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_OutTableAdapter = New FS_ERP_MM.DSRptGatePassesTableAdapters.tbl_Inv_Tran_OutTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSRptGatePassesTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_Tran_Out1TableAdapter = New FS_ERP_MM.DSRptGatePassesTableAdapters.tbl_Inv_Tran_Out1TableAdapter()
        TranOutIDLabel = New System.Windows.Forms.Label()
        TranOutIDLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_Out1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRptGatePasses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TranOutIDLabel
        '
        TranOutIDLabel.Location = New System.Drawing.Point(12, 60)
        TranOutIDLabel.Name = "TranOutIDLabel"
        TranOutIDLabel.Size = New System.Drawing.Size(100, 20)
        TranOutIDLabel.TabIndex = 0
        TranOutIDLabel.Text = "Tran Out Number:"
        TranOutIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranOutIDLabel1
        '
        TranOutIDLabel1.Location = New System.Drawing.Point(12, 89)
        TranOutIDLabel1.Name = "TranOutIDLabel1"
        TranOutIDLabel1.Size = New System.Drawing.Size(100, 20)
        TranOutIDLabel1.TabIndex = 2
        TranOutIDLabel1.Text = "Tran Out Number:"
        TranOutIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(12, 116)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 20)
        Label2.TabIndex = 30
        Label2.Text = "Vehicle No.:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(12, 142)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(100, 20)
        Label3.TabIndex = 31
        Label3.Text = "Driver Name:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(906, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gate Passes Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 221)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(5, 168)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(242, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "Material Borrowed Gate Pass Reports (MBGP)"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(5, 145)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(218, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "Material Sale Gate Pass Reports (MSGP)"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(5, 99)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(230, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Material Return Gate Pass Reports (MRGP)"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(5, 122)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(232, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Material Lended Gate Pass Reports (MLGP)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(5, 52)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(241, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Material OutWard Gate Pass Reports (MOGP)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(5, 76)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(236, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Purchase Return Gate Pass Reports (PRGP)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(5, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(202, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Material Transfer Pass Reports (MTP)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.DriverNameTextBox2)
        Me.GroupBox2.Controls.Add(Me.VehicleTextBox1)
        Me.GroupBox2.Controls.Add(Me.lblDate1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(TranOutIDLabel1)
        Me.GroupBox2.Controls.Add(Me.TranOutIDComboBox1)
        Me.GroupBox2.Controls.Add(TranOutIDLabel)
        Me.GroupBox2.Controls.Add(Me.TranOutIDComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(451, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 221)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selection"
        '
        'DriverNameTextBox2
        '
        Me.DriverNameTextBox2.Location = New System.Drawing.Point(118, 142)
        Me.DriverNameTextBox2.Name = "DriverNameTextBox2"
        Me.DriverNameTextBox2.Size = New System.Drawing.Size(140, 20)
        Me.DriverNameTextBox2.TabIndex = 29
        '
        'VehicleTextBox1
        '
        Me.VehicleTextBox1.Location = New System.Drawing.Point(118, 116)
        Me.VehicleTextBox1.Name = "VehicleTextBox1"
        Me.VehicleTextBox1.Size = New System.Drawing.Size(140, 20)
        Me.VehicleTextBox1.TabIndex = 28
        Me.VehicleTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDate1
        '
        Me.lblDate1.Location = New System.Drawing.Point(12, 26)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(100, 20)
        Me.lblDate1.TabIndex = 27
        Me.lblDate1.Text = "Select Date:"
        Me.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(118, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TranOutIDComboBox1
        '
        Me.TranOutIDComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TranOutIDComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TranOutIDComboBox1.DataSource = Me.Tbl_Inv_Tran_Out1BindingSource
        Me.TranOutIDComboBox1.DisplayMember = "TranOutID"
        Me.TranOutIDComboBox1.FormattingEnabled = True
        Me.TranOutIDComboBox1.Location = New System.Drawing.Point(118, 88)
        Me.TranOutIDComboBox1.Name = "TranOutIDComboBox1"
        Me.TranOutIDComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.TranOutIDComboBox1.TabIndex = 3
        Me.TranOutIDComboBox1.ValueMember = "TranOutID"
        '
        'Tbl_Inv_Tran_Out1BindingSource
        '
        Me.Tbl_Inv_Tran_Out1BindingSource.DataMember = "tbl_Inv_Tran_Out1"
        Me.Tbl_Inv_Tran_Out1BindingSource.DataSource = Me.DSRptGatePasses
        '
        'DSRptGatePasses
        '
        Me.DSRptGatePasses.DataSetName = "DSRptGatePasses"
        Me.DSRptGatePasses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TranOutIDComboBox
        '
        Me.TranOutIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TranOutIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TranOutIDComboBox.DataSource = Me.Tbl_Inv_Tran_OutBindingSource
        Me.TranOutIDComboBox.DisplayMember = "TranOutID"
        Me.TranOutIDComboBox.FormattingEnabled = True
        Me.TranOutIDComboBox.Location = New System.Drawing.Point(118, 59)
        Me.TranOutIDComboBox.Name = "TranOutIDComboBox"
        Me.TranOutIDComboBox.Size = New System.Drawing.Size(140, 21)
        Me.TranOutIDComboBox.TabIndex = 1
        Me.TranOutIDComboBox.ValueMember = "TranOutID"
        '
        'Tbl_Inv_Tran_OutBindingSource
        '
        Me.Tbl_Inv_Tran_OutBindingSource.DataMember = "tbl_Inv_Tran_Out"
        Me.Tbl_Inv_Tran_OutBindingSource.DataSource = Me.DSRptGatePasses
        '
        'Tbl_Inv_Tran_OutTableAdapter
        '
        Me.Tbl_Inv_Tran_OutTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSRptGatePassesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_Tran_Out1TableAdapter
        '
        Me.Tbl_Inv_Tran_Out1TableAdapter.ClearBeforeFill = True
        '
        'frmRptGatePasses
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 411)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptGatePasses"
        Me.Text = "Gate Passes Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_Inv_Tran_Out1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRptGatePasses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DSRptGatePasses As FS_ERP_MM.DSRptGatePasses
    Friend WithEvents Tbl_Inv_Tran_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_OutTableAdapter As FS_ERP_MM.DSRptGatePassesTableAdapters.tbl_Inv_Tran_OutTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSRptGatePassesTableAdapters.TableAdapterManager
    Friend WithEvents TranOutIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_Tran_Out1TableAdapter As FS_ERP_MM.DSRptGatePassesTableAdapters.tbl_Inv_Tran_Out1TableAdapter
    Friend WithEvents Tbl_Inv_Tran_Out1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TranOutIDComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents DriverNameTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents VehicleTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
End Class
