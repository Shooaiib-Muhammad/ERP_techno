<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptBillingTranNew
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
        Dim ArtCodeLabel1 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDailyTran = New FS_ERP_MM.DsDailyTran()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnNewRpt = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBilling = New FS_ERP_MM.DSBilling()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.INOUTComboBox = New System.Windows.Forms.ComboBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Billing_PartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Billing_PartyTableAdapter = New FS_ERP_MM.DSBillingTableAdapters.tbl_Billing_PartyTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager()
        Me.Tbl_SupplierTableAdapter = New FS_ERP_MM.DSBillingTableAdapters.tbl_SupplierTableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DsDailyTranTableAdapters.tbl_Inv_L4TableAdapter()
        Me.TableAdapterManager1 = New FS_ERP_MM.DsDailyTranTableAdapters.TableAdapterManager()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        DayNoLabel = New System.Windows.Forms.Label()
        DayNoLabel1 = New System.Windows.Forms.Label()
        ArtCodeLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDailyTran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Billing_PartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DayNoLabel
        '
        DayNoLabel.Location = New System.Drawing.Point(3, 11)
        DayNoLabel.Name = "DayNoLabel"
        DayNoLabel.Size = New System.Drawing.Size(67, 20)
        DayNoLabel.TabIndex = 15
        DayNoLabel.Text = "From Date:"
        DayNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DayNoLabel1
        '
        DayNoLabel1.Location = New System.Drawing.Point(3, 38)
        DayNoLabel1.Name = "DayNoLabel1"
        DayNoLabel1.Size = New System.Drawing.Size(67, 20)
        DayNoLabel1.TabIndex = 16
        DayNoLabel1.Text = "To Date:"
        DayNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ArtCodeLabel1
        '
        ArtCodeLabel1.Location = New System.Drawing.Point(258, 274)
        ArtCodeLabel1.Name = "ArtCodeLabel1"
        ArtCodeLabel1.Size = New System.Drawing.Size(67, 20)
        ArtCodeLabel1.TabIndex = 31
        ArtCodeLabel1.Text = "Trans. Type:"
        ArtCodeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ArtCodeLabel1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1128, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Billing Transactions Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton12)
        Me.Panel1.Controls.Add(Me.RadioButton11)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.RadioButton10)
        Me.Panel1.Controls.Add(Me.RadioButton9)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.btnNewRpt)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DTPicker2)
        Me.Panel1.Controls.Add(DayNoLabel)
        Me.Panel1.Controls.Add(DayNoLabel1)
        Me.Panel1.Controls.Add(Me.DTPicker1)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(930, 192)
        Me.Panel1.TabIndex = 17
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(631, 145)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(215, 17)
        Me.RadioButton11.TabIndex = 34
        Me.RadioButton11.Text = "Raw Material Invoice Report By Material"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.ComboBox2.DisplayMember = "L4Name"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(76, 96)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox2.TabIndex = 32
        Me.ComboBox2.ValueMember = "Code"
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
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Item Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(631, 122)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(160, 17)
        Me.RadioButton10.TabIndex = 31
        Me.RadioButton10.Text = "Raw Material Invoice Report"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(631, 99)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(175, 17)
        Me.RadioButton9.TabIndex = 30
        Me.RadioButton9.Text = "Billing Summary Report By Party"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(334, 68)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox2.TabIndex = 28
        Me.CheckBox2.Text = "Check For New Report"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(631, 53)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(265, 17)
        Me.RadioButton3.TabIndex = 26
        Me.RadioButton3.Text = "Daily Billing Transactions By Verification Date Wise"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(334, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(278, 31)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Check State On for Pending Checked State Off for Done " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In Intermediate State for" &
    " All  Records"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(334, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Check For Filter Records"
        Me.CheckBox1.ThreeState = True
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnNewRpt
        '
        Me.btnNewRpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewRpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRpt.Location = New System.Drawing.Point(334, 109)
        Me.btnNewRpt.Name = "btnNewRpt"
        Me.btnNewRpt.Size = New System.Drawing.Size(102, 40)
        Me.btnNewRpt.TabIndex = 18
        Me.btnNewRpt.Text = "Show Report"
        Me.btnNewRpt.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(631, 30)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(211, 17)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.Text = "Daily Billing Transactions By Party Wise"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(631, 9)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(142, 17)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Daily Billing Transactions"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(631, 76)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(133, 17)
        Me.RadioButton5.TabIndex = 29
        Me.RadioButton5.Text = "Billing Summary Report"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_SupplierBindingSource
        Me.ComboBox1.DisplayMember = "CompanyName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(76, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.ValueMember = "SupplierID"
        '
        'Tbl_SupplierBindingSource
        '
        Me.Tbl_SupplierBindingSource.DataMember = "tbl_Supplier"
        Me.Tbl_SupplierBindingSource.DataSource = Me.DSBilling
        '
        'DSBilling
        '
        Me.DSBilling.DataSetName = "DSBilling"
        Me.DSBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Party Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPicker2
        '
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(76, 38)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(133, 20)
        Me.DTPicker2.TabIndex = 17
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(76, 11)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(133, 20)
        Me.DTPicker1.TabIndex = 16
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(505, 241)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(133, 17)
        Me.RadioButton4.TabIndex = 27
        Me.RadioButton4.Text = "Billing Summary Report"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(850, 264)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(126, 17)
        Me.RadioButton8.TabIndex = 34
        Me.RadioButton8.Text = "Gate Outward Report"
        Me.RadioButton8.UseVisualStyleBackColor = True
        Me.RadioButton8.Visible = False
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(850, 241)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(118, 17)
        Me.RadioButton7.TabIndex = 33
        Me.RadioButton7.Text = "Gate Inward Report"
        Me.RadioButton7.UseVisualStyleBackColor = True
        Me.RadioButton7.Visible = False
        '
        'INOUTComboBox
        '
        Me.INOUTComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.INOUTComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.INOUTComboBox.FormattingEnabled = True
        Me.INOUTComboBox.Items.AddRange(New Object() {"Normal", "Returnable"})
        Me.INOUTComboBox.Location = New System.Drawing.Point(331, 273)
        Me.INOUTComboBox.Name = "INOUTComboBox"
        Me.INOUTComboBox.Size = New System.Drawing.Size(133, 21)
        Me.INOUTComboBox.TabIndex = 32
        Me.INOUTComboBox.Text = "Normal"
        Me.INOUTComboBox.Visible = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(644, 241)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(200, 17)
        Me.RadioButton6.TabIndex = 30
        Me.RadioButton6.Text = "New Billing Summary Report By Party"
        Me.RadioButton6.UseVisualStyleBackColor = True
        Me.RadioButton6.Visible = False
        '
        'Tbl_Billing_PartyBindingSource
        '
        Me.Tbl_Billing_PartyBindingSource.DataMember = "tbl_Billing_Party"
        Me.Tbl_Billing_PartyBindingSource.DataSource = Me.DSBilling
        '
        'Tbl_Billing_PartyTableAdapter
        '
        Me.Tbl_Billing_PartyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Billing_PartyTableAdapter = Me.Tbl_Billing_PartyTableAdapter
        Me.TableAdapterManager.tbl_Billing_Transactions_DetailTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Billing_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_Billing_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.View_Tran_INTableAdapter = Nothing
        '
        'Tbl_SupplierTableAdapter
        '
        Me.Tbl_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Inv_CodeTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager1.tbl_Inv_SupplierTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DsDailyTranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(631, 168)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(277, 17)
        Me.RadioButton12.TabIndex = 35
        Me.RadioButton12.Text = "Raw Material Invoice Report By Material and Supplier"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'frmRptBillingTranNew
        '
        Me.AcceptButton = Me.btnNewRpt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 400)
        Me.Controls.Add(Me.INOUTComboBox)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton8)
        Me.Controls.Add(ArtCodeLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadioButton7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton6)
        Me.Name = "frmRptBillingTranNew"
        Me.Text = "Billing Transactions Reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDailyTran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Billing_PartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNewRpt As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tbl_Billing_PartyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSBilling As FS_ERP_MM.DSBilling
    Friend WithEvents Tbl_Billing_PartyTableAdapter As FS_ERP_MM.DSBillingTableAdapters.tbl_Billing_PartyTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents INOUTComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_SupplierTableAdapter As FS_ERP_MM.DSBillingTableAdapters.tbl_SupplierTableAdapter
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DsDailyTran As DsDailyTran
    Friend WithEvents Tbl_Inv_L4BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As DsDailyTranTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents TableAdapterManager1 As DsDailyTranTableAdapters.TableAdapterManager
    Friend WithEvents RadioButton12 As RadioButton
End Class
