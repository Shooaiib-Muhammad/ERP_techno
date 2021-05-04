<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptSaleInvoice
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
        Dim POIDLabel1 As System.Windows.Forms.Label
        Dim POIDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.POGroup = New System.Windows.Forms.GroupBox()
        Me.CustomerNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_MM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsRptSale = New FS_ERP_MM.DsRptSale()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SIDComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_MM_Sale1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_MM_SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MM_CustomerTableAdapter = New FS_ERP_MM.DsRptSaleTableAdapters.tbl_MM_CustomerTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DsRptSaleTableAdapters.TableAdapterManager()
        Me.Tbl_MM_Sale1TableAdapter = New FS_ERP_MM.DsRptSaleTableAdapters.tbl_MM_Sale1TableAdapter()
        Me.Tbl_MM_SaleTableAdapter = New FS_ERP_MM.DsRptSaleTableAdapters.tbl_MM_SaleTableAdapter()
        POIDLabel1 = New System.Windows.Forms.Label()
        POIDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.POGroup.SuspendLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRptSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_Sale1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'POIDLabel1
        '
        POIDLabel1.Location = New System.Drawing.Point(6, 51)
        POIDLabel1.Name = "POIDLabel1"
        POIDLabel1.Size = New System.Drawing.Size(103, 20)
        POIDLabel1.TabIndex = 2
        POIDLabel1.Text = "Sale Invoice No:"
        POIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POIDLabel
        '
        POIDLabel.Location = New System.Drawing.Point(6, 25)
        POIDLabel.Name = "POIDLabel"
        POIDLabel.Size = New System.Drawing.Size(103, 20)
        POIDLabel.TabIndex = 0
        POIDLabel.Text = "Sale Invoice No:"
        POIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(6, 115)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(103, 20)
        Label2.TabIndex = 9
        Label2.Text = "2nd Date:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(6, 90)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(103, 20)
        Label3.TabIndex = 7
        Label3.Text = "1st Date:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.Location = New System.Drawing.Point(6, 161)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(103, 20)
        CompanyNameLabel.TabIndex = 11
        CompanyNameLabel.Text = "Company Name:"
        CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(854, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sale Invoice Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(104, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 257)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selection"
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(7, 184)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(181, 17)
        Me.RadioButton8.TabIndex = 7
        Me.RadioButton8.Text = "Customer Ledger By Date Range"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(7, 207)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(208, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "Customer Sale Invoice Balance Report"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(7, 165)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(181, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "Customer Ledger By Date Range"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(7, 144)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(105, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Customer Ledger"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(7, 114)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(241, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Sale Invoice by Customer Date Range Report"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 90)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(180, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Sale Invoice by Customer Report"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(154, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Sale Invoice Range Report"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 47)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(180, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Sale Invoice Date Range Report"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'btnShowReport
        '
        Me.btnShowReport.Location = New System.Drawing.Point(203, 207)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(90, 44)
        Me.btnShowReport.TabIndex = 8
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'POGroup
        '
        Me.POGroup.Controls.Add(Me.btnShowReport)
        Me.POGroup.Controls.Add(CompanyNameLabel)
        Me.POGroup.Controls.Add(Me.CustomerNameComboBox)
        Me.POGroup.Controls.Add(Label2)
        Me.POGroup.Controls.Add(Me.DateTimePicker2)
        Me.POGroup.Controls.Add(Label3)
        Me.POGroup.Controls.Add(Me.DateTimePicker1)
        Me.POGroup.Controls.Add(POIDLabel1)
        Me.POGroup.Controls.Add(Me.SIDComboBox1)
        Me.POGroup.Controls.Add(POIDLabel)
        Me.POGroup.Controls.Add(Me.SIDComboBox)
        Me.POGroup.Location = New System.Drawing.Point(428, 57)
        Me.POGroup.Name = "POGroup"
        Me.POGroup.Size = New System.Drawing.Size(320, 257)
        Me.POGroup.TabIndex = 7
        Me.POGroup.TabStop = False
        Me.POGroup.Text = "Sale Range Selection"
        '
        'CustomerNameComboBox
        '
        Me.CustomerNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustomerNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustomerNameComboBox.DataSource = Me.Tbl_MM_CustomerBindingSource
        Me.CustomerNameComboBox.DisplayMember = "CompanyName"
        Me.CustomerNameComboBox.FormattingEnabled = True
        Me.CustomerNameComboBox.Location = New System.Drawing.Point(114, 160)
        Me.CustomerNameComboBox.Name = "CustomerNameComboBox"
        Me.CustomerNameComboBox.Size = New System.Drawing.Size(179, 21)
        Me.CustomerNameComboBox.TabIndex = 12
        Me.CustomerNameComboBox.ValueMember = "CustID"
        '
        'Tbl_MM_CustomerBindingSource
        '
        Me.Tbl_MM_CustomerBindingSource.DataMember = "tbl_MM_Customer"
        Me.Tbl_MM_CustomerBindingSource.DataSource = Me.DsRptSale
        '
        'DsRptSale
        '
        Me.DsRptSale.DataSetName = "DsRptSale"
        Me.DsRptSale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(114, 115)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(116, 20)
        Me.DateTimePicker2.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(114, 90)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'SIDComboBox1
        '
        Me.SIDComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SIDComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SIDComboBox1.DataSource = Me.Tbl_MM_Sale1BindingSource
        Me.SIDComboBox1.DisplayMember = "SID"
        Me.SIDComboBox1.FormattingEnabled = True
        Me.SIDComboBox1.Location = New System.Drawing.Point(114, 50)
        Me.SIDComboBox1.Name = "SIDComboBox1"
        Me.SIDComboBox1.Size = New System.Drawing.Size(116, 21)
        Me.SIDComboBox1.TabIndex = 4
        Me.SIDComboBox1.ValueMember = "SID"
        '
        'Tbl_MM_Sale1BindingSource
        '
        Me.Tbl_MM_Sale1BindingSource.DataMember = "tbl_MM_Sale1"
        Me.Tbl_MM_Sale1BindingSource.DataSource = Me.DsRptSale
        '
        'SIDComboBox
        '
        Me.SIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SIDComboBox.DataSource = Me.Tbl_MM_SaleBindingSource
        Me.SIDComboBox.DisplayMember = "SID"
        Me.SIDComboBox.FormattingEnabled = True
        Me.SIDComboBox.Location = New System.Drawing.Point(114, 24)
        Me.SIDComboBox.Name = "SIDComboBox"
        Me.SIDComboBox.Size = New System.Drawing.Size(116, 21)
        Me.SIDComboBox.TabIndex = 3
        Me.SIDComboBox.ValueMember = "SID"
        '
        'Tbl_MM_SaleBindingSource
        '
        Me.Tbl_MM_SaleBindingSource.DataMember = "tbl_MM_Sale"
        Me.Tbl_MM_SaleBindingSource.DataSource = Me.DsRptSale
        '
        'Tbl_MM_CustomerTableAdapter
        '
        Me.Tbl_MM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_MM_CustomerTableAdapter = Me.Tbl_MM_CustomerTableAdapter
        Me.TableAdapterManager.tbl_MM_Sale1TableAdapter = Me.Tbl_MM_Sale1TableAdapter
        Me.TableAdapterManager.tbl_MM_SaleTableAdapter = Me.Tbl_MM_SaleTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DsRptSaleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_MM_Sale1TableAdapter
        '
        Me.Tbl_MM_Sale1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_SaleTableAdapter
        '
        Me.Tbl_MM_SaleTableAdapter.ClearBeforeFill = True
        '
        'frmRptSaleInvoice
        '
        Me.AcceptButton = Me.btnShowReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 390)
        Me.Controls.Add(Me.POGroup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptSaleInvoice"
        Me.Text = "frmRptSaleInvoice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.POGroup.ResumeLayout(False)
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRptSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_Sale1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowReport As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents POGroup As System.Windows.Forms.GroupBox
    Friend WithEvents SIDComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustomerNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DsRptSale As FS_ERP_MM.DsRptSale
    Friend WithEvents Tbl_MM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_CustomerTableAdapter As FS_ERP_MM.DsRptSaleTableAdapters.tbl_MM_CustomerTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DsRptSaleTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_MM_SaleTableAdapter As FS_ERP_MM.DsRptSaleTableAdapters.tbl_MM_SaleTableAdapter
    Friend WithEvents Tbl_MM_SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_Sale1TableAdapter As FS_ERP_MM.DsRptSaleTableAdapters.tbl_MM_Sale1TableAdapter
    Friend WithEvents Tbl_MM_Sale1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
End Class
