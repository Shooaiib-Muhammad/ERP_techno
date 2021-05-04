<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptSaleBill
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
        Dim BillIDLabel As System.Windows.Forms.Label
        Dim BillIDLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_MM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRptSaleBill = New FS_ERP_MM.DSRptSaleBill()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.BillIDComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_MM_Sale_Bill_H1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_MM_Sale_Bill_HBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MM_Sale_Bill_HTableAdapter = New FS_ERP_MM.DSRptSaleBillTableAdapters.tbl_MM_Sale_Bill_HTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSRptSaleBillTableAdapters.TableAdapterManager()
        Me.Tbl_MM_Sale_Bill_H1TableAdapter = New FS_ERP_MM.DSRptSaleBillTableAdapters.tbl_MM_Sale_Bill_H1TableAdapter()
        Me.Tbl_MM_CustomerTableAdapter = New FS_ERP_MM.DSRptSaleBillTableAdapters.tbl_MM_CustomerTableAdapter()
        BillIDLabel = New System.Windows.Forms.Label()
        BillIDLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRptSaleBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_Sale_Bill_H1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_Sale_Bill_HBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BillIDLabel
        '
        BillIDLabel.Location = New System.Drawing.Point(6, 23)
        BillIDLabel.Name = "BillIDLabel"
        BillIDLabel.Size = New System.Drawing.Size(100, 20)
        BillIDLabel.TabIndex = 0
        BillIDLabel.Text = "Bill Number:"
        BillIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BillIDLabel1
        '
        BillIDLabel1.Location = New System.Drawing.Point(6, 50)
        BillIDLabel1.Name = "BillIDLabel1"
        BillIDLabel1.Size = New System.Drawing.Size(100, 20)
        BillIDLabel1.TabIndex = 2
        BillIDLabel1.Text = "Bill Number:"
        BillIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(6, 143)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 20)
        Label2.TabIndex = 7
        Label2.Text = "Customer Name:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(919, 40)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sales Bill  Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(150, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 234)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selector"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 72)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(112, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Customer  Reports"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(131, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Bill Date Wise Reports"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(145, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Bill Number Wise Reports"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDate2)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.lblDate1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.CompanyNameComboBox)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.btnShowReport)
        Me.GroupBox2.Controls.Add(BillIDLabel1)
        Me.GroupBox2.Controls.Add(Me.BillIDComboBox1)
        Me.GroupBox2.Controls.Add(BillIDLabel)
        Me.GroupBox2.Controls.Add(Me.BillIDComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(440, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 234)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Selector"
        '
        'lblDate2
        '
        Me.lblDate2.Location = New System.Drawing.Point(6, 108)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(100, 20)
        Me.lblDate2.TabIndex = 30
        Me.lblDate2.Text = "Select Date:"
        Me.lblDate2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDate1
        '
        Me.lblDate1.Location = New System.Drawing.Point(6, 81)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(100, 20)
        Me.lblDate1.TabIndex = 29
        Me.lblDate1.Text = "Select Date:"
        Me.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(109, 108)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker2.TabIndex = 28
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataSource = Me.Tbl_MM_CustomerBindingSource
        Me.CompanyNameComboBox.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(109, 142)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CompanyNameComboBox.TabIndex = 6
        Me.CompanyNameComboBox.ValueMember = "CustID"
        '
        'Tbl_MM_CustomerBindingSource
        '
        Me.Tbl_MM_CustomerBindingSource.DataMember = "tbl_MM_Customer"
        Me.Tbl_MM_CustomerBindingSource.DataSource = Me.DSRptSaleBill
        '
        'DSRptSaleBill
        '
        Me.DSRptSaleBill.DataSetName = "DSRptSaleBill"
        Me.DSRptSaleBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(109, 81)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'btnShowReport
        '
        Me.btnShowReport.Location = New System.Drawing.Point(214, 180)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(95, 39)
        Me.btnShowReport.TabIndex = 4
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'BillIDComboBox1
        '
        Me.BillIDComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BillIDComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BillIDComboBox1.DataSource = Me.Tbl_MM_Sale_Bill_H1BindingSource
        Me.BillIDComboBox1.DisplayMember = "BillID"
        Me.BillIDComboBox1.FormattingEnabled = True
        Me.BillIDComboBox1.Location = New System.Drawing.Point(109, 49)
        Me.BillIDComboBox1.Name = "BillIDComboBox1"
        Me.BillIDComboBox1.Size = New System.Drawing.Size(129, 21)
        Me.BillIDComboBox1.TabIndex = 3
        Me.BillIDComboBox1.ValueMember = "BillID"
        '
        'Tbl_MM_Sale_Bill_H1BindingSource
        '
        Me.Tbl_MM_Sale_Bill_H1BindingSource.DataMember = "tbl_MM_Sale_Bill_H1"
        Me.Tbl_MM_Sale_Bill_H1BindingSource.DataSource = Me.DSRptSaleBill
        '
        'BillIDComboBox
        '
        Me.BillIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BillIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BillIDComboBox.DataSource = Me.Tbl_MM_Sale_Bill_HBindingSource
        Me.BillIDComboBox.DisplayMember = "BillID"
        Me.BillIDComboBox.FormattingEnabled = True
        Me.BillIDComboBox.Location = New System.Drawing.Point(109, 22)
        Me.BillIDComboBox.Name = "BillIDComboBox"
        Me.BillIDComboBox.Size = New System.Drawing.Size(129, 21)
        Me.BillIDComboBox.TabIndex = 1
        Me.BillIDComboBox.ValueMember = "BillID"
        '
        'Tbl_MM_Sale_Bill_HBindingSource
        '
        Me.Tbl_MM_Sale_Bill_HBindingSource.DataMember = "tbl_MM_Sale_Bill_H"
        Me.Tbl_MM_Sale_Bill_HBindingSource.DataSource = Me.DSRptSaleBill
        '
        'Tbl_MM_Sale_Bill_HTableAdapter
        '
        Me.Tbl_MM_Sale_Bill_HTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_MM_Sale_Bill_H1TableAdapter = Me.Tbl_MM_Sale_Bill_H1TableAdapter
        Me.TableAdapterManager.tbl_MM_Sale_Bill_HTableAdapter = Me.Tbl_MM_Sale_Bill_HTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSRptSaleBillTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_MM_Sale_Bill_H1TableAdapter
        '
        Me.Tbl_MM_Sale_Bill_H1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_CustomerTableAdapter
        '
        Me.Tbl_MM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'frmRptSaleBill
        '
        Me.AcceptButton = Me.btnShowReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 410)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptSaleBill"
        Me.Text = "frmRptSaleBill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRptSaleBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_Sale_Bill_H1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_Sale_Bill_HBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DSRptSaleBill As FS_ERP_MM.DSRptSaleBill
    Friend WithEvents Tbl_MM_Sale_Bill_HBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_Sale_Bill_HTableAdapter As FS_ERP_MM.DSRptSaleBillTableAdapters.tbl_MM_Sale_Bill_HTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSRptSaleBillTableAdapters.TableAdapterManager
    Friend WithEvents BillIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_MM_Sale_Bill_H1TableAdapter As FS_ERP_MM.DSRptSaleBillTableAdapters.tbl_MM_Sale_Bill_H1TableAdapter
    Friend WithEvents Tbl_MM_Sale_Bill_H1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnShowReport As System.Windows.Forms.Button
    Friend WithEvents BillIDComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_MM_CustomerTableAdapter As FS_ERP_MM.DSRptSaleBillTableAdapters.tbl_MM_CustomerTableAdapter
    Friend WithEvents Tbl_MM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate2 As System.Windows.Forms.Label
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
