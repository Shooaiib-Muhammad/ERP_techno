<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptScrapeSale
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Datelabel1 As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim NarationLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.InvoiceNoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Mat_SaleHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSSGP = New FS_ERP_MM.DSSSGP()
        Me.NarationComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_PUR_Vendor_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSVendorInfo = New FS_ERP_MM.DSVendorInfo()
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.DTPicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Tbl_Vendor_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Vendor_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Vendor_InfoTableAdapter = New FS_ERP_MM.DSSSGPTableAdapters.tbl_Vendor_InfoTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSSSGPTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSSSGPTableAdapters.tbl_Inv_L4TableAdapter()
        Me.View_Vendor_InfoTableAdapter = New FS_ERP_MM.DSSSGPTableAdapters.View_Vendor_InfoTableAdapter()
        Me.Tbl_Mat_SaleHTableAdapter = New FS_ERP_MM.DSSSGPTableAdapters.tbl_Mat_SaleHTableAdapter()
        Me.Tbl_PUR_Vendor_InfoTableAdapter = New FS_ERP_MM.DSVendorInfoTableAdapters.tbl_PUR_Vendor_InfoTableAdapter()
        Me.TableAdapterManager1 = New FS_ERP_MM.DSVendorInfoTableAdapters.TableAdapterManager()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Label2 = New System.Windows.Forms.Label()
        Datelabel1 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        NarationLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Mat_SaleHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSSGP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PUR_Vendor_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSVendorInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Vendor_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Vendor_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(6, 75)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(105, 21)
        Label2.TabIndex = 31
        Label2.Text = "Item Name:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Datelabel1
        '
        Datelabel1.Location = New System.Drawing.Point(6, 48)
        Datelabel1.Name = "Datelabel1"
        Datelabel1.Size = New System.Drawing.Size(105, 21)
        Datelabel1.TabIndex = 9
        Datelabel1.Text = "Select Date"
        Datelabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.Location = New System.Drawing.Point(6, 22)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(105, 21)
        DateLabel.TabIndex = 8
        DateLabel.Text = "Select Date"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NarationLabel
        '
        NarationLabel.AutoSize = True
        NarationLabel.Location = New System.Drawing.Point(36, 106)
        NarationLabel.Name = "NarationLabel"
        NarationLabel.Size = New System.Drawing.Size(75, 13)
        NarationLabel.TabIndex = 31
        NarationLabel.Text = "Vendor Name:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(21, 133)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(89, 13)
        Label3.TabIndex = 33
        Label3.Text = "Sale Invoice No.:"
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
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Scrape Sale Transactions Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.InvoiceNoComboBox1)
        Me.GroupBox2.Controls.Add(NarationLabel)
        Me.GroupBox2.Controls.Add(Me.NarationComboBox)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.CompanyNameComboBox)
        Me.GroupBox2.Controls.Add(Me.btnShowReport)
        Me.GroupBox2.Controls.Add(Datelabel1)
        Me.GroupBox2.Controls.Add(DateLabel)
        Me.GroupBox2.Controls.Add(Me.DTPicker2)
        Me.GroupBox2.Controls.Add(Me.DTPicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(426, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 283)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selector"
        '
        'InvoiceNoComboBox1
        '
        Me.InvoiceNoComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.InvoiceNoComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.InvoiceNoComboBox1.DataSource = Me.Tbl_Mat_SaleHBindingSource
        Me.InvoiceNoComboBox1.DisplayMember = "SaleID"
        Me.InvoiceNoComboBox1.FormattingEnabled = True
        Me.InvoiceNoComboBox1.Location = New System.Drawing.Point(117, 130)
        Me.InvoiceNoComboBox1.Name = "InvoiceNoComboBox1"
        Me.InvoiceNoComboBox1.Size = New System.Drawing.Size(174, 21)
        Me.InvoiceNoComboBox1.TabIndex = 34
        Me.InvoiceNoComboBox1.ValueMember = "SaleID"
        '
        'Tbl_Mat_SaleHBindingSource
        '
        Me.Tbl_Mat_SaleHBindingSource.DataMember = "tbl_Mat_SaleH"
        Me.Tbl_Mat_SaleHBindingSource.DataSource = Me.DSSSGP
        '
        'DSSSGP
        '
        Me.DSSSGP.DataSetName = "DSSSGP"
        Me.DSSSGP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NarationComboBox
        '
        Me.NarationComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NarationComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NarationComboBox.DataSource = Me.Tbl_PUR_Vendor_InfoBindingSource
        Me.NarationComboBox.DisplayMember = "VendorName"
        Me.NarationComboBox.FormattingEnabled = True
        Me.NarationComboBox.Location = New System.Drawing.Point(117, 103)
        Me.NarationComboBox.Name = "NarationComboBox"
        Me.NarationComboBox.Size = New System.Drawing.Size(174, 21)
        Me.NarationComboBox.TabIndex = 32
        Me.NarationComboBox.ValueMember = "VendorName"
        '
        'Tbl_PUR_Vendor_InfoBindingSource
        '
        Me.Tbl_PUR_Vendor_InfoBindingSource.DataMember = "tbl_PUR_Vendor_Info"
        Me.Tbl_PUR_Vendor_InfoBindingSource.DataSource = Me.DSVendorInfo
        '
        'DSVendorInfo
        '
        Me.DSVendorInfo.DataSetName = "DSVendorInfo"
        Me.DSVendorInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.CompanyNameComboBox.DisplayMember = "L4Name"
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(117, 75)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(174, 21)
        Me.CompanyNameComboBox.TabIndex = 30
        Me.CompanyNameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSSSGP
        '
        'btnShowReport
        '
        Me.btnShowReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnShowReport.Location = New System.Drawing.Point(204, 195)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(87, 52)
        Me.btnShowReport.TabIndex = 2
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.UseVisualStyleBackColor = False
        '
        'DTPicker2
        '
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(117, 49)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(117, 20)
        Me.DTPicker2.TabIndex = 1
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(117, 23)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(117, 20)
        Me.DTPicker1.TabIndex = 0
        '
        'Tbl_Vendor_InfoBindingSource
        '
        Me.Tbl_Vendor_InfoBindingSource.DataMember = "tbl_Vendor_Info"
        Me.Tbl_Vendor_InfoBindingSource.DataSource = Me.DSSSGP
        '
        'View_Vendor_InfoBindingSource
        '
        Me.View_Vendor_InfoBindingSource.DataMember = "View_Vendor_Info"
        Me.View_Vendor_InfoBindingSource.DataSource = Me.DSSSGP
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 204)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 96)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(181, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "Daily Scrape Sale by Invoice No."
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 142)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Daily Jala Entry"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 73)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(256, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Daily Scrape Sale Report Date And Vendor Wise"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 119)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(183, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Monthly Scrape Summary Report "
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 50)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(242, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Daily Scrape Sale Report Date And Item Wise"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 27)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(194, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Daily Scrape Sale Report Date wise" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Tbl_Vendor_InfoTableAdapter
        '
        Me.Tbl_Vendor_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_OutTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_SaleHTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Vendor_InfoTableAdapter = Me.Tbl_Vendor_InfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSSSGPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'View_Vendor_InfoTableAdapter
        '
        Me.View_Vendor_InfoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Mat_SaleHTableAdapter
        '
        Me.Tbl_Mat_SaleHTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PUR_Vendor_InfoTableAdapter
        '
        Me.Tbl_PUR_Vendor_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_PUR_Vendor_InfoTableAdapter = Me.Tbl_PUR_Vendor_InfoTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DSVendorInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton8)
        Me.GroupBox3.Controls.Add(Me.RadioButton7)
        Me.GroupBox3.Controls.Add(Me.RadioButton12)
        Me.GroupBox3.Location = New System.Drawing.Point(120, 268)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(300, 112)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Selector"
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(6, 61)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton8.TabIndex = 2
        Me.RadioButton8.Text = "Un Paid"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(6, 44)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton7.TabIndex = 1
        Me.RadioButton7.Text = "Paid"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Checked = True
        Me.RadioButton12.Location = New System.Drawing.Point(6, 27)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton12.TabIndex = 0
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "All"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(6, 165)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(190, 17)
        Me.RadioButton9.TabIndex = 6
        Me.RadioButton9.Text = "GATE PASS FOR FINAL WEIGHT"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'frmRptScrapeSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 680)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptScrapeSale"
        Me.Text = "Scrape Sale Transactions Report"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_Mat_SaleHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSSGP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PUR_Vendor_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSVendorInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Vendor_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Vendor_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnShowReport As System.Windows.Forms.Button
    Friend WithEvents DTPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DSSSGP As FS_ERP_MM.DSSSGP
    Friend WithEvents Tbl_Vendor_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Vendor_InfoTableAdapter As FS_ERP_MM.DSSSGPTableAdapters.tbl_Vendor_InfoTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSSSGPTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSSSGPTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents View_Vendor_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Vendor_InfoTableAdapter As FS_ERP_MM.DSSSGPTableAdapters.View_Vendor_InfoTableAdapter
    Friend WithEvents NarationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents InvoiceNoComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Mat_SaleHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Mat_SaleHTableAdapter As FS_ERP_MM.DSSSGPTableAdapters.tbl_Mat_SaleHTableAdapter
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents DSVendorInfo As DSVendorInfo
    Friend WithEvents Tbl_PUR_Vendor_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_PUR_Vendor_InfoTableAdapter As DSVendorInfoTableAdapters.tbl_PUR_Vendor_InfoTableAdapter
    Friend WithEvents TableAdapterManager1 As DSVendorInfoTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
End Class
