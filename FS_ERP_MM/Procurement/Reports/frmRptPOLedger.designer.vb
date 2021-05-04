<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptPOLedger
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
        Me.components = New System.ComponentModel.Container
        Me.CompanyNameLabel = New System.Windows.Forms.Label
        Me.L4NameLabel = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.btnShow = New System.Windows.Forms.Button
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSupItems = New FS_ERP_MM.DSSupItems
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox
        Me.View_Pur_Supplier_CodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_SupplierTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.View_Pur_Supplier_CodeTableAdapter = New FS_ERP_MM.DSSupItemsTableAdapters.View_Pur_Supplier_CodeTableAdapter
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSupItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.View_Pur_Supplier_CodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyNameLabel
        '
        Me.CompanyNameLabel.Location = New System.Drawing.Point(7, 29)
        Me.CompanyNameLabel.Name = "CompanyNameLabel"
        Me.CompanyNameLabel.Size = New System.Drawing.Size(78, 20)
        Me.CompanyNameLabel.TabIndex = 0
        Me.CompanyNameLabel.Text = "Supplier:"
        Me.CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameLabel
        '
        Me.L4NameLabel.Location = New System.Drawing.Point(7, 56)
        Me.L4NameLabel.Name = "L4NameLabel"
        Me.L4NameLabel.Size = New System.Drawing.Size(78, 20)
        Me.L4NameLabel.TabIndex = 0
        Me.L4NameLabel.Text = "Material:"
        Me.L4NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Report"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(163, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Material Ledger Supplier wise"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(205, 140)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(88, 32)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Show Report"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.CompanyNameComboBox.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(91, 28)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(202, 21)
        Me.CompanyNameComboBox.TabIndex = 2
        Me.CompanyNameComboBox.ValueMember = "SupplierID"
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSSupItems
        '
        'DSSupItems
        '
        Me.DSSupItems.DataSetName = "DSSupItems"
        Me.DSSupItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnShow)
        Me.GroupBox2.Controls.Add(Me.CompanyNameLabel)
        Me.GroupBox2.Controls.Add(Me.L4NameLabel)
        Me.GroupBox2.Controls.Add(Me.CompanyNameComboBox)
        Me.GroupBox2.Controls.Add(Me.L4NameComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(382, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 202)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Option"
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.View_Pur_Supplier_CodeBindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(91, 55)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(202, 21)
        Me.L4NameComboBox.TabIndex = 3
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'View_Pur_Supplier_CodeBindingSource
        '
        Me.View_Pur_Supplier_CodeBindingSource.DataMember = "tbl_Inv_Supplier_View_Pur_Supplier_Code"
        Me.View_Pur_Supplier_CodeBindingSource.DataSource = Me.Tbl_Inv_SupplierBindingSource
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(760, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Purchase Order Ledgers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Pur_Supplier_CodeTableAdapter
        '
        Me.View_Pur_Supplier_CodeTableAdapter.ClearBeforeFill = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 59)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(116, 17)
        Me.RadioButton2.TabIndex = 20
        Me.RadioButton2.Text = "Customer Items List"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'frmRptPOLedger
        '
        Me.AcceptButton = Me.btnShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(760, 362)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptPOLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PO Ledger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSupItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.View_Pur_Supplier_CodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DSSupItems As FS_ERP_MM.DSSupItems
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSSupItemsTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents View_Pur_Supplier_CodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Pur_Supplier_CodeTableAdapter As FS_ERP_MM.DSSupItemsTableAdapters.View_Pur_Supplier_CodeTableAdapter
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents CompanyNameLabel As System.Windows.Forms.Label
    Friend WithEvents L4NameLabel As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
