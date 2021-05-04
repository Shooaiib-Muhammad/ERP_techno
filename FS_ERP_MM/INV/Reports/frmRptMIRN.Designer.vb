<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMIRN
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Datelabel1 As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NarrationComboBox = New System.Windows.Forms.ComboBox()
        Me.View_Purchase_Order_MRINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBilling = New FS_ERP_MM.DSBilling()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_MM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRpt = New FS_ERP_MM.DSRpt()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SupplierNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSRptTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSRptTableAdapters.TableAdapterManager()
        Me.Tbl_MM_CustomerTableAdapter = New FS_ERP_MM.DSRptTableAdapters.tbl_MM_CustomerTableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSBillingTableAdapters.tbl_Inv_L4TableAdapter()
        Me.TableAdapterManager1 = New FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager()
        Me.View_Purchase_Order_MRINTableAdapter = New FS_ERP_MM.DSBillingTableAdapters.View_Purchase_Order_MRINTableAdapter()
        Label3 = New System.Windows.Forms.Label()
        Datelabel1 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.View_Purchase_Order_MRINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(6, 95)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(105, 21)
        Label3.TabIndex = 26
        Label3.Text = "Supplier Name"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Datelabel1
        '
        Datelabel1.Location = New System.Drawing.Point(6, 66)
        Datelabel1.Name = "Datelabel1"
        Datelabel1.Size = New System.Drawing.Size(105, 21)
        Datelabel1.TabIndex = 9
        Datelabel1.Text = "Select Date"
        Datelabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.Location = New System.Drawing.Point(6, 40)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(105, 21)
        DateLabel.TabIndex = 8
        DateLabel.Text = "Select Date"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(6, 122)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(105, 21)
        Label2.TabIndex = 31
        Label2.Text = "Customer Name:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameLabel
        '
        L4NameLabel.AutoSize = True
        L4NameLabel.Location = New System.Drawing.Point(51, 152)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(60, 13)
        L4NameLabel.TabIndex = 31
        L4NameLabel.Text = "item Name:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(40, 179)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(71, 13)
        Label4.TabIndex = 34
        Label4.Text = "Special Note:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton15)
        Me.GroupBox1.Controls.Add(Me.RadioButton14)
        Me.GroupBox1.Controls.Add(Me.RadioButton13)
        Me.GroupBox1.Controls.Add(Me.RadioButton12)
        Me.GroupBox1.Controls.Add(Me.RadioButton11)
        Me.GroupBox1.Controls.Add(Me.RadioButton10)
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(117, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 380)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(6, 343)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(150, 17)
        Me.RadioButton15.TabIndex = 14
        Me.RadioButton15.Text = "Receive Pos Special Note"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton14.Location = New System.Drawing.Point(6, 320)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(143, 17)
        Me.RadioButton14.TabIndex = 13
        Me.RadioButton14.Text = "MRGP Material Summary"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(6, 297)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(156, 17)
        Me.RadioButton13.TabIndex = 12
        Me.RadioButton13.Text = "Receive Special Note Wise"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(6, 67)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(196, 17)
        Me.RadioButton12.TabIndex = 11
        Me.RadioButton12.Text = "Suppliers and Receive Pos By Items"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(6, 159)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(220, 17)
        Me.RadioButton11.TabIndex = 10
        Me.RadioButton11.Text = "Returned Material Receive Supplier Wise"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(6, 113)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(215, 17)
        Me.RadioButton10.TabIndex = 9
        Me.RadioButton10.Text = "Lended Material Receive  Suplpier Wise"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(6, 136)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(205, 17)
        Me.RadioButton9.TabIndex = 8
        Me.RadioButton9.Text = "Returned Material Receive  Date wise"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(6, 274)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(239, 17)
        Me.RadioButton8.TabIndex = 7
        Me.RadioButton8.Text = "Lended Material Receive Balance  Date wise"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton7.Location = New System.Drawing.Point(6, 251)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(147, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "Lended Material Summary"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 228)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(265, 17)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.Text = "Supplier and Borrowed Material Receive Date wise"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 205)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(206, 17)
        Me.RadioButton6.TabIndex = 4
        Me.RadioButton6.Text = "Borrowed Material Receive  Date wise"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 182)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(262, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Customer and Lended Material Receive Date wise"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 90)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(197, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Lended Material Receive  Date wise"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(203, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Suppliers and Receive Pos Date wise"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(136, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Receive Pos Date wise" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NarrationComboBox)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(L4NameLabel)
        Me.GroupBox2.Controls.Add(Me.L4NameComboBox)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.CompanyNameComboBox)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.SupplierNameComboBox)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.btnShowReport)
        Me.GroupBox2.Controls.Add(Datelabel1)
        Me.GroupBox2.Controls.Add(DateLabel)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 268)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selector"
        '
        'NarrationComboBox
        '
        Me.NarrationComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NarrationComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NarrationComboBox.DataSource = Me.View_Purchase_Order_MRINBindingSource
        Me.NarrationComboBox.DisplayMember = "Narration"
        Me.NarrationComboBox.Enabled = False
        Me.NarrationComboBox.FormattingEnabled = True
        Me.NarrationComboBox.Location = New System.Drawing.Point(117, 176)
        Me.NarrationComboBox.Name = "NarrationComboBox"
        Me.NarrationComboBox.Size = New System.Drawing.Size(159, 21)
        Me.NarrationComboBox.TabIndex = 12
        Me.NarrationComboBox.ValueMember = "Narration"
        '
        'View_Purchase_Order_MRINBindingSource
        '
        Me.View_Purchase_Order_MRINBindingSource.DataMember = "View_Purchase_Order_MRIN"
        Me.View_Purchase_Order_MRINBindingSource.DataSource = Me.DSBilling
        '
        'DSBilling
        '
        Me.DSBilling.DataSetName = "DSBilling"
        Me.DSBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.Enabled = False
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(117, 149)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(159, 21)
        Me.L4NameComboBox.TabIndex = 32
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSBilling
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataSource = Me.Tbl_MM_CustomerBindingSource
        Me.CompanyNameComboBox.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(117, 122)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(159, 21)
        Me.CompanyNameComboBox.TabIndex = 30
        Me.CompanyNameComboBox.ValueMember = "CustID"
        '
        'Tbl_MM_CustomerBindingSource
        '
        Me.Tbl_MM_CustomerBindingSource.DataMember = "tbl_MM_Customer"
        Me.Tbl_MM_CustomerBindingSource.DataSource = Me.DSRpt
        '
        'DSRpt
        '
        Me.DSRpt.DataSetName = "DSRpt"
        Me.DSRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(117, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(117, 17)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Lended Check Box"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'SupplierNameComboBox
        '
        Me.SupplierNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierNameComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.SupplierNameComboBox.DisplayMember = "CompanyName"
        Me.SupplierNameComboBox.Enabled = False
        Me.SupplierNameComboBox.FormattingEnabled = True
        Me.SupplierNameComboBox.Location = New System.Drawing.Point(117, 95)
        Me.SupplierNameComboBox.Name = "SupplierNameComboBox"
        Me.SupplierNameComboBox.Size = New System.Drawing.Size(159, 21)
        Me.SupplierNameComboBox.TabIndex = 28
        Me.SupplierNameComboBox.ValueMember = "SupplierID"
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSRpt
        '
        'btnShowReport
        '
        Me.btnShowReport.Location = New System.Drawing.Point(161, 203)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(115, 52)
        Me.btnShowReport.TabIndex = 2
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(117, 67)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(117, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(117, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(117, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(901, 40)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "MRIN Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L41TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Supplier1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Me.Tbl_Inv_SupplierTableAdapter
        Me.TableAdapterManager.tbl_MM_CustomerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Prd_LinesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_Plan1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_Plan2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSRptTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_MM_CustomerTableAdapter
        '
        Me.Tbl_MM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Billing_PartyTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Billing_Transactions_DetailTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Billing_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager1.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.View_Billing_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.View_Tran_INTableAdapter = Nothing
        '
        'View_Purchase_Order_MRINTableAdapter
        '
        Me.View_Purchase_Order_MRINTableAdapter.ClearBeforeFill = True
        '
        'frmRptMIRN
        '
        Me.AcceptButton = Me.btnShowReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 486)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptMIRN"
        Me.Text = "MRIN Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.View_Purchase_Order_MRINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SupplierNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnShowReport As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSRpt As FS_ERP_MM.DSRpt
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSRptTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSRptTableAdapters.TableAdapterManager
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_MM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_CustomerTableAdapter As FS_ERP_MM.DSRptTableAdapters.tbl_MM_CustomerTableAdapter
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents DSBilling As DSBilling
    Friend WithEvents Tbl_Inv_L4BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As DSBillingTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents TableAdapterManager1 As DSBillingTableAdapters.TableAdapterManager
    Friend WithEvents L4NameComboBox As ComboBox
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents View_Purchase_Order_MRINBindingSource As BindingSource
    Friend WithEvents View_Purchase_Order_MRINTableAdapter As DSBillingTableAdapters.View_Purchase_Order_MRINTableAdapter
    Friend WithEvents NarrationComboBox As ComboBox
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
End Class
