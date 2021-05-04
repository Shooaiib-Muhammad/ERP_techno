<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptBillingTransactions
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ExecuterNameComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_Winded_ExectNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSWindedBladderIssuance = New FS_ERP_MM.DSWindedBladderIssuance
        Me.lblDate1 = New System.Windows.Forms.Label
        Me.btnShowRpt = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Tbl_Winded_ExectNameTableAdapter = New FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.tbl_Winded_ExectNameTableAdapter
        Me.TableAdapterManager = New FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.TableAdapterManager
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Winded_ExectNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSWindedBladderIssuance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Punctured Bladders Billing Transactions Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ExecuterNameComboBox)
        Me.GroupBox2.Controls.Add(Me.lblDate1)
        Me.GroupBox2.Controls.Add(Me.btnShowRpt)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(482, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 214)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection Criteria"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Executer Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExecuterNameComboBox
        '
        Me.ExecuterNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ExecuterNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ExecuterNameComboBox.DataSource = Me.Tbl_Winded_ExectNameBindingSource
        Me.ExecuterNameComboBox.DisplayMember = "ExectName"
        Me.ExecuterNameComboBox.FormattingEnabled = True
        Me.ExecuterNameComboBox.Location = New System.Drawing.Point(113, 56)
        Me.ExecuterNameComboBox.Name = "ExecuterNameComboBox"
        Me.ExecuterNameComboBox.Size = New System.Drawing.Size(164, 21)
        Me.ExecuterNameComboBox.TabIndex = 27
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
        'lblDate1
        '
        Me.lblDate1.Location = New System.Drawing.Point(6, 25)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(104, 21)
        Me.lblDate1.TabIndex = 25
        Me.lblDate1.Text = "Select Date:"
        Me.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnShowRpt
        '
        Me.btnShowRpt.BackColor = System.Drawing.Color.Green
        Me.btnShowRpt.ForeColor = System.Drawing.Color.Transparent
        Me.btnShowRpt.Location = New System.Drawing.Point(178, 142)
        Me.btnShowRpt.Name = "btnShowRpt"
        Me.btnShowRpt.Size = New System.Drawing.Size(99, 44)
        Me.btnShowRpt.TabIndex = 6
        Me.btnShowRpt.Text = "Show Report"
        Me.btnShowRpt.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(113, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(164, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 214)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Report"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 71)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(197, 17)
        Me.RadioButton3.TabIndex = 34
        Me.RadioButton3.Text = "Repairable Bladders Balance Report"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(149, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = "Check For Maker Copy"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton2.TabIndex = 32
        Me.RadioButton2.Text = "Punctured Bladders Bill"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 25)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(136, 17)
        Me.RadioButton1.TabIndex = 29
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Un-Winding Bladder Bill"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Tbl_Winded_ExectNameTableAdapter
        '
        Me.Tbl_Winded_ExectNameTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Bladder_Repair_OutTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Bladder_Winded_ProcessTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Winded_ExectNameTableAdapter = Me.Tbl_Winded_ExectNameTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 94)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(178, 17)
        Me.RadioButton4.TabIndex = 35
        Me.RadioButton4.Text = "Daily Bladders Receiving Report"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'frmRptBillingTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 750)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptBillingTransactions"
        Me.Text = "Punctured Bladders Billing Transactions Reports"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Tbl_Winded_ExectNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSWindedBladderIssuance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ExecuterNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents btnShowRpt As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DSWindedBladderIssuance As FS_ERP_MM.DSWindedBladderIssuance
    Friend WithEvents Tbl_Winded_ExectNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Winded_ExectNameTableAdapter As FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.tbl_Winded_ExectNameTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSWindedBladderIssuanceTableAdapters.TableAdapterManager
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
End Class
