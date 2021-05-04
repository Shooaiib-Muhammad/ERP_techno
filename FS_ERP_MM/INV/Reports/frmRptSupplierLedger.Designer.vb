<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptSupplierLedger
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
        Dim Label3 As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaterialNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDailyTran = New FS_ERP_MM.DsDailyTran()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SupplierNameComboBox = New System.Windows.Forms.ComboBox()
        Me.View_Inv_CompNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.View_Inv_CompNameTableAdapter = New FS_ERP_MM.DsDailyTranTableAdapters.View_Inv_CompNameTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DsDailyTranTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DsDailyTranTableAdapters.tbl_Inv_L4TableAdapter()
        TranOutIDLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDailyTran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Inv_CompNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TranOutIDLabel
        '
        TranOutIDLabel.Location = New System.Drawing.Point(8, 75)
        TranOutIDLabel.Name = "TranOutIDLabel"
        TranOutIDLabel.Size = New System.Drawing.Size(81, 20)
        TranOutIDLabel.TabIndex = 0
        TranOutIDLabel.Text = "Supplier Name:"
        TranOutIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(8, 127)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(81, 20)
        Label3.TabIndex = 30
        Label3.Text = "Material Name:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.MaterialNameComboBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lblDate1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(TranOutIDLabel)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.SupplierNameComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(463, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 257)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selection"
        '
        'MaterialNameComboBox
        '
        Me.MaterialNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MaterialNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MaterialNameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.MaterialNameComboBox.DisplayMember = "L4Name"
        Me.MaterialNameComboBox.FormattingEnabled = True
        Me.MaterialNameComboBox.Location = New System.Drawing.Point(91, 126)
        Me.MaterialNameComboBox.Name = "MaterialNameComboBox"
        Me.MaterialNameComboBox.Size = New System.Drawing.Size(243, 21)
        Me.MaterialNameComboBox.TabIndex = 31
        Me.MaterialNameComboBox.ValueMember = "Code"
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
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Select Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDate1
        '
        Me.lblDate1.Location = New System.Drawing.Point(8, 21)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(81, 20)
        Me.lblDate1.TabIndex = 27
        Me.lblDate1.Text = "Select Date:"
        Me.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(91, 47)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(130, 20)
        Me.DateTimePicker2.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(91, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 20)
        Me.DateTimePicker1.TabIndex = 26
        '
        'SupplierNameComboBox
        '
        Me.SupplierNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierNameComboBox.DataSource = Me.View_Inv_CompNameBindingSource
        Me.SupplierNameComboBox.DisplayMember = "CompanyName"
        Me.SupplierNameComboBox.FormattingEnabled = True
        Me.SupplierNameComboBox.Location = New System.Drawing.Point(91, 74)
        Me.SupplierNameComboBox.Name = "SupplierNameComboBox"
        Me.SupplierNameComboBox.Size = New System.Drawing.Size(243, 21)
        Me.SupplierNameComboBox.TabIndex = 1
        Me.SupplierNameComboBox.ValueMember = "CompanyName"
        '
        'View_Inv_CompNameBindingSource
        '
        Me.View_Inv_CompNameBindingSource.DataMember = "View_Inv_CompName"
        Me.View_Inv_CompNameBindingSource.DataSource = Me.DsDailyTran
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 257)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(5, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(341, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Supplier Ledger Report By Transaction Date And Selected Material"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(5, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(234, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Supplier Ledger Report By Transaction Date"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1028, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Supplier Ledger Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Inv_CompNameTableAdapter
        '
        Me.View_Inv_CompNameTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_CodeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DsDailyTranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'frmRptSupplierLedger
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 750)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptSupplierLedger"
        Me.Text = "Supplier Ledger Reports"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDailyTran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Inv_CompNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SupplierNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MaterialNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DsDailyTran As FS_ERP_MM.DsDailyTran
    Friend WithEvents View_Inv_CompNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Inv_CompNameTableAdapter As FS_ERP_MM.DsDailyTranTableAdapters.View_Inv_CompNameTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DsDailyTranTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DsDailyTranTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
End Class
