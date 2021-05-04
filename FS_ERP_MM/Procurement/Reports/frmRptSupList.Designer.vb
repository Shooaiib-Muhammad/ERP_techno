<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptSupList
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
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.POGroup = New System.Windows.Forms.GroupBox()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSupItems = New FS_ERP_MM.DSSupItems()
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_L4TableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSSupItemsTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_Supplier1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Supplier1TableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_Supplier1TableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CompanyNameLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.POGroup.SuspendLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSupItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_Inv_Supplier1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.Location = New System.Drawing.Point(8, 26)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(100, 20)
        CompanyNameLabel.TabIndex = 0
        CompanyNameLabel.Text = "Company Name:"
        CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(8, 80)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 20)
        Label4.TabIndex = 17
        Label4.Text = "Material Name:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POGroup
        '
        Me.POGroup.Controls.Add(Label2)
        Me.POGroup.Controls.Add(Me.ComboBox1)
        Me.POGroup.Controls.Add(Label4)
        Me.POGroup.Controls.Add(Me.L4NameComboBox)
        Me.POGroup.Controls.Add(CompanyNameLabel)
        Me.POGroup.Controls.Add(Me.CompanyNameComboBox)
        Me.POGroup.Controls.Add(Me.btnShowReport)
        Me.POGroup.Location = New System.Drawing.Point(500, 53)
        Me.POGroup.Name = "POGroup"
        Me.POGroup.Size = New System.Drawing.Size(320, 205)
        Me.POGroup.TabIndex = 9
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
        Me.L4NameComboBox.Location = New System.Drawing.Point(110, 80)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.L4NameComboBox.TabIndex = 16
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSSupItems
        '
        'DSSupItems
        '
        Me.DSSupItems.DataSetName = "DSSupItems"
        Me.DSSupItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.CompanyNameComboBox.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(110, 26)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.CompanyNameComboBox.TabIndex = 7
        Me.CompanyNameComboBox.ValueMember = "SupplierID"
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSSupItems
        '
        'btnShowReport
        '
        Me.btnShowReport.Location = New System.Drawing.Point(202, 110)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(90, 47)
        Me.btnShowReport.TabIndex = 8
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 157)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selection"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(7, 110)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton4.TabIndex = 21
        Me.RadioButton4.Text = "Supplier Range"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 87)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(129, 17)
        Me.RadioButton3.TabIndex = 20
        Me.RadioButton3.Text = "Material Prices Report"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 64)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(110, 17)
        Me.RadioButton2.TabIndex = 19
        Me.RadioButton2.Text = "Supplier Items List"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 41)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Supplier List"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1217, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Supplier Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager.tbl_Inv_Supplier1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Me.Tbl_Inv_SupplierTableAdapter
        Me.TableAdapterManager.tbl_inv_SupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_Supplier_CodeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_UnitofMeasurementDtlTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSSupItemsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_Supplier1BindingSource
        '
        Me.Tbl_Inv_Supplier1BindingSource.DataMember = "tbl_Inv_Supplier1"
        Me.Tbl_Inv_Supplier1BindingSource.DataSource = Me.DSSupItems
        '
        'Tbl_Inv_Supplier1TableAdapter
        '
        Me.Tbl_Inv_Supplier1TableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(8, 53)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 20)
        Label2.TabIndex = 18
        Label2.Text = "Company Name:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_Inv_Supplier1BindingSource
        Me.ComboBox1.DisplayMember = "CompanyName"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.ValueMember = "SupplierID"
        '
        'frmRptSupList
        '
        Me.AcceptButton = Me.btnShowReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 738)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.POGroup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptSupList"
        Me.Text = "frmSupList"
        Me.POGroup.ResumeLayout(False)
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSupItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_Inv_Supplier1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents POGroup As System.Windows.Forms.GroupBox
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnShowReport As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSSupItems As FS_ERP_MM.DSSupItems
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSSupItemsTableAdapters.TableAdapterManager
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Tbl_Inv_Supplier1BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_Supplier1TableAdapter As DSSupItemsTableAdapters.tbl_Inv_Supplier1TableAdapter
    Friend WithEvents ComboBox1 As ComboBox
End Class
