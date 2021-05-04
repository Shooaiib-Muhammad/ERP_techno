<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDemandreports
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
        Dim Label25 As System.Windows.Forms.Label
        Dim OrderGivenDescLabel As System.Windows.Forms.Label
        Dim VendorNameLabel As System.Windows.Forms.Label
        Me.Tbl_Pur_Demand1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPO = New FS_ERP_MM.DSPO()
        Me.Tbl_Pur_Demand_Head1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_Demand_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_LocalCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_Demand2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Inv_LocalCustTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Inv_LocalCustTableAdapter()
        Me.Tbl_Pur_Demand_HeadTableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_Demand_HeadTableAdapter()
        Me.Tbl_Pur_Demand_Head1TableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_Demand_Head1TableAdapter()
        Me.Tbl_Pur_Demand1TableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_Demand1TableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSPOTableAdapters.TableAdapterManager()
        Me.Tbl_Pur_Demand2TableAdapter = New FS_ERP_MM.DSPOTableAdapters.tbl_Pur_Demand2TableAdapter()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.OrderGivenDescComboBox = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.RadioButton24 = New System.Windows.Forms.RadioButton()
        Me.RadioButton20 = New System.Windows.Forms.RadioButton()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VendorNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GMNoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GMNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CustNameComboBox = New System.Windows.Forms.ComboBox()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton26 = New System.Windows.Forms.RadioButton()
        Me.RadioButton25 = New System.Windows.Forms.RadioButton()
        Me.RadioButton23 = New System.Windows.Forms.RadioButton()
        Me.RadioButton21 = New System.Windows.Forms.RadioButton()
        Me.RadioButton22 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        OrderGivenDescLabel = New System.Windows.Forms.Label()
        VendorNameLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_Pur_Demand1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_Demand_Head1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_Demand_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_Demand2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label25
        '
        Label25.Location = New System.Drawing.Point(4, 193)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(96, 20)
        Label25.TabIndex = 32
        Label25.Text = "Cash Option:"
        Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OrderGivenDescLabel
        '
        OrderGivenDescLabel.Location = New System.Drawing.Point(3, 166)
        OrderGivenDescLabel.Name = "OrderGivenDescLabel"
        OrderGivenDescLabel.Size = New System.Drawing.Size(96, 20)
        OrderGivenDescLabel.TabIndex = 20
        OrderGivenDescLabel.Text = "Bill No.:"
        OrderGivenDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VendorNameLabel
        '
        VendorNameLabel.Location = New System.Drawing.Point(3, 141)
        VendorNameLabel.Name = "VendorNameLabel"
        VendorNameLabel.Size = New System.Drawing.Size(96, 20)
        VendorNameLabel.TabIndex = 20
        VendorNameLabel.Text = "Vendor Name:"
        VendorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_Pur_Demand1BindingSource
        '
        Me.Tbl_Pur_Demand1BindingSource.DataMember = "tbl_Pur_Demand1"
        Me.Tbl_Pur_Demand1BindingSource.DataSource = Me.DSPO
        '
        'DSPO
        '
        Me.DSPO.DataSetName = "DSPO"
        Me.DSPO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Pur_Demand_Head1BindingSource
        '
        Me.Tbl_Pur_Demand_Head1BindingSource.DataMember = "tbl_Pur_Demand_Head1"
        Me.Tbl_Pur_Demand_Head1BindingSource.DataSource = Me.DSPO
        '
        'Tbl_Pur_Demand_HeadBindingSource
        '
        Me.Tbl_Pur_Demand_HeadBindingSource.DataMember = "tbl_Pur_Demand_Head"
        Me.Tbl_Pur_Demand_HeadBindingSource.DataSource = Me.DSPO
        '
        'Tbl_Inv_LocalCustBindingSource
        '
        Me.Tbl_Inv_LocalCustBindingSource.DataMember = "tbl_Inv_LocalCust"
        Me.Tbl_Inv_LocalCustBindingSource.DataSource = Me.DSPO
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSPO
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSPO
        '
        'Tbl_Pur_Demand2BindingSource
        '
        Me.Tbl_Pur_Demand2BindingSource.DataMember = "tbl_Pur_Demand2"
        Me.Tbl_Pur_Demand2BindingSource.DataSource = Me.DSPO
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_LocalCustTableAdapter
        '
        Me.Tbl_Inv_LocalCustTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_Demand_HeadTableAdapter
        '
        Me.Tbl_Pur_Demand_HeadTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_Demand_Head1TableAdapter
        '
        Me.Tbl_Pur_Demand_Head1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_Demand1TableAdapter
        '
        Me.Tbl_Pur_Demand1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_CodeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_LocalCust1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_LocalCustTableAdapter = Me.Tbl_Inv_LocalCustTableAdapter
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Me.Tbl_Inv_SupplierTableAdapter
        Me.TableAdapterManager.tbl_Pur_Demand_Head1TableAdapter = Me.Tbl_Pur_Demand_Head1TableAdapter
        Me.TableAdapterManager.tbl_Pur_Demand_HeadTableAdapter = Me.Tbl_Pur_Demand_HeadTableAdapter
        Me.TableAdapterManager.tbl_Pur_Demand_PeriorityTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_DemandTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_PartialReceivingTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_PO_DTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_PO1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_POTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSPOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Pur_Demand2TableAdapter
        '
        Me.Tbl_Pur_Demand2TableAdapter.ClearBeforeFill = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(583, 407)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(118, 13)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Filter By Amt Entry Date"
        '
        'OrderGivenDescComboBox
        '
        Me.OrderGivenDescComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.OrderGivenDescComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.OrderGivenDescComboBox.DataSource = Me.Tbl_Pur_Demand2BindingSource
        Me.OrderGivenDescComboBox.DisplayMember = "OrderGivenDesc"
        Me.OrderGivenDescComboBox.FormattingEnabled = True
        Me.OrderGivenDescComboBox.Location = New System.Drawing.Point(713, 568)
        Me.OrderGivenDescComboBox.Name = "OrderGivenDescComboBox"
        Me.OrderGivenDescComboBox.Size = New System.Drawing.Size(169, 21)
        Me.OrderGivenDescComboBox.TabIndex = 46
        Me.OrderGivenDescComboBox.ValueMember = "OrderGivenDesc"
        Me.OrderGivenDescComboBox.Visible = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Crimson
        Me.Label24.Location = New System.Drawing.Point(564, 407)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 13)
        Me.Label24.TabIndex = 44
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(583, 422)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(145, 13)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Filter By Partial Receive Date"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.DarkCyan
        Me.Label22.Location = New System.Drawing.Point(564, 422)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 13)
        Me.Label22.TabIndex = 42
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Crimson
        Me.RadioButton2.Location = New System.Drawing.Point(754, 174)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(227, 17)
        Me.RadioButton2.TabIndex = 49
        Me.RadioButton2.Text = "Purchase Summary For Both (PO+Non PO)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(583, 377)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Filter By Receive Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(583, 392)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Filter By Purchase Date"
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.ForeColor = System.Drawing.Color.ForestGreen
        Me.RadioButton14.Location = New System.Drawing.Point(754, 128)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(219, 17)
        Me.RadioButton14.TabIndex = 48
        Me.RadioButton14.Text = "Partial Received Demands (By Inventory)"
        Me.RadioButton14.UseVisualStyleBackColor = True
        Me.RadioButton14.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(583, 362)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(135, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Filter By Booking Due Date"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(583, 347)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Filter By Inprocess Date"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.ForestGreen
        Me.Label15.Location = New System.Drawing.Point(564, 377)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label13.Location = New System.Drawing.Point(564, 392)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 36
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.RadioButton9.Location = New System.Drawing.Point(754, 151)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(193, 17)
        Me.RadioButton9.TabIndex = 47
        Me.RadioButton9.Text = "Demands With Purchase Status On"
        Me.RadioButton9.UseVisualStyleBackColor = True
        Me.RadioButton9.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label12.Location = New System.Drawing.Point(564, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 35
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.ForestGreen
        Me.RadioButton4.Location = New System.Drawing.Point(754, 105)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(206, 17)
        Me.RadioButton4.TabIndex = 29
        Me.RadioButton4.Text = "Full Received Demands (By Inventory)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(564, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 34
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.RadioButton24)
        Me.Panel6.Controls.Add(Me.RadioButton20)
        Me.Panel6.Controls.Add(Me.RadioButton19)
        Me.Panel6.Controls.Add(Me.RadioButton18)
        Me.Panel6.Controls.Add(Me.RadioButton15)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.RadioButton12)
        Me.Panel6.Controls.Add(Me.RadioButton6)
        Me.Panel6.Controls.Add(Me.RadioButton5)
        Me.Panel6.Controls.Add(Me.RadioButton8)
        Me.Panel6.Controls.Add(Me.RadioButton7)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Location = New System.Drawing.Point(426, 46)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(302, 295)
        Me.Panel6.TabIndex = 33
        '
        'RadioButton24
        '
        Me.RadioButton24.AutoSize = True
        Me.RadioButton24.Location = New System.Drawing.Point(10, 167)
        Me.RadioButton24.Name = "RadioButton24"
        Me.RadioButton24.Size = New System.Drawing.Size(271, 17)
        Me.RadioButton24.TabIndex = 25
        Me.RadioButton24.Text = "Filter By Date Range And Supplier And Bill No. Wise"
        Me.RadioButton24.UseVisualStyleBackColor = True
        '
        'RadioButton20
        '
        Me.RadioButton20.AutoSize = True
        Me.RadioButton20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadioButton20.Location = New System.Drawing.Point(10, 233)
        Me.RadioButton20.Name = "RadioButton20"
        Me.RadioButton20.Size = New System.Drawing.Size(178, 17)
        Me.RadioButton20.TabIndex = 24
        Me.RadioButton20.Text = "Pending Demand Vendor Name "
        Me.RadioButton20.UseVisualStyleBackColor = True
        '
        'RadioButton19
        '
        Me.RadioButton19.AutoSize = True
        Me.RadioButton19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadioButton19.Location = New System.Drawing.Point(10, 211)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(153, 17)
        Me.RadioButton19.TabIndex = 23
        Me.RadioButton19.Text = "Order Given Vendor Name "
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadioButton18.Location = New System.Drawing.Point(10, 189)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(133, 17)
        Me.RadioButton18.TabIndex = 22
        Me.RadioButton18.Text = "Filter By Vendor Name "
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(10, 57)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(104, 17)
        Me.RadioButton15.TabIndex = 2
        Me.RadioButton15.Text = "Filter By G.D. No"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(188, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "View Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(10, 79)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(187, 17)
        Me.RadioButton12.TabIndex = 21
        Me.RadioButton12.Text = "Filter By Date Range And G.D. No"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(10, 101)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(168, 17)
        Me.RadioButton6.TabIndex = 3
        Me.RadioButton6.Text = "Filter By Date Range And Item"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(10, 35)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(123, 17)
        Me.RadioButton5.TabIndex = 2
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Filter By Date Range"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(10, 145)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(186, 17)
        Me.RadioButton8.TabIndex = 20
        Me.RadioButton8.Text = "Filter By Date Range And Supplier"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(10, 123)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(203, 17)
        Me.RadioButton7.TabIndex = 4
        Me.RadioButton7.Text = "Filter By Date Range And Department"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(300, 25)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Filter Level 2  >>>"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Label25)
        Me.Panel5.Controls.Add(Me.ComboBox1)
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Controls.Add(OrderGivenDescLabel)
        Me.Panel5.Controls.Add(Me.VendorNameComboBox)
        Me.Panel5.Controls.Add(VendorNameLabel)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.GMNoComboBox1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.GMNoComboBox)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.CustNameComboBox)
        Me.Panel5.Controls.Add(Me.L4NameComboBox)
        Me.Panel5.Controls.Add(Me.CompanyNameComboBox)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(122, 452)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(436, 247)
        Me.Panel5.TabIndex = 32
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cash", "Cash1", "Cash2", "Cash3", "Cash4", "Cash5", "Cash6", "Cash7", "Cash8", "Cash9", "Cash10", "Shaban"})
        Me.ComboBox1.Location = New System.Drawing.Point(106, 193)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(173, 21)
        Me.ComboBox1.TabIndex = 31
        Me.ComboBox1.Text = "Cash"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 20)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VendorNameComboBox
        '
        Me.VendorNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.VendorNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.VendorNameComboBox.DataSource = Me.Tbl_Pur_Demand1BindingSource
        Me.VendorNameComboBox.DisplayMember = "VendorName"
        Me.VendorNameComboBox.FormattingEnabled = True
        Me.VendorNameComboBox.Location = New System.Drawing.Point(105, 140)
        Me.VendorNameComboBox.Name = "VendorNameComboBox"
        Me.VendorNameComboBox.Size = New System.Drawing.Size(284, 21)
        Me.VendorNameComboBox.TabIndex = 21
        Me.VendorNameComboBox.ValueMember = "VendorName"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(207, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "To GD No:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GMNoComboBox1
        '
        Me.GMNoComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GMNoComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GMNoComboBox1.DataSource = Me.Tbl_Pur_Demand_Head1BindingSource
        Me.GMNoComboBox1.DisplayMember = "GMNo"
        Me.GMNoComboBox1.FormattingEnabled = True
        Me.GMNoComboBox1.Location = New System.Drawing.Point(285, 34)
        Me.GMNoComboBox1.Name = "GMNoComboBox1"
        Me.GMNoComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.GMNoComboBox1.TabIndex = 28
        Me.GMNoComboBox1.ValueMember = "GMNo"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "From GD No:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GMNoComboBox
        '
        Me.GMNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GMNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GMNoComboBox.DataSource = Me.Tbl_Pur_Demand_HeadBindingSource
        Me.GMNoComboBox.DisplayMember = "GMNo"
        Me.GMNoComboBox.FormattingEnabled = True
        Me.GMNoComboBox.Location = New System.Drawing.Point(105, 34)
        Me.GMNoComboBox.Name = "GMNoComboBox"
        Me.GMNoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.GMNoComboBox.TabIndex = 8
        Me.GMNoComboBox.ValueMember = "GMNo"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(3, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Department:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustNameComboBox
        '
        Me.CustNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustNameComboBox.DataSource = Me.Tbl_Inv_LocalCustBindingSource
        Me.CustNameComboBox.DisplayMember = "CustName"
        Me.CustNameComboBox.FormattingEnabled = True
        Me.CustNameComboBox.Location = New System.Drawing.Point(105, 88)
        Me.CustNameComboBox.Name = "CustNameComboBox"
        Me.CustNameComboBox.Size = New System.Drawing.Size(284, 21)
        Me.CustNameComboBox.TabIndex = 6
        Me.CustNameComboBox.ValueMember = "LocalCustID"
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(105, 61)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(284, 21)
        Me.L4NameComboBox.TabIndex = 5
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.CompanyNameComboBox.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(105, 115)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(284, 21)
        Me.CompanyNameComboBox.TabIndex = 7
        Me.CompanyNameComboBox.ValueMember = "SupplierID"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(3, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Supplier:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(3, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Item Name:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(434, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Available Filters"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.DateTimePicker2)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(122, 377)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(436, 69)
        Me.Panel4.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(220, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "To Date:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "From Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(298, 36)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(90, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(434, 25)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Available Filters"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton26)
        Me.Panel1.Controls.Add(Me.RadioButton25)
        Me.Panel1.Controls.Add(Me.RadioButton23)
        Me.Panel1.Controls.Add(Me.RadioButton21)
        Me.Panel1.Controls.Add(Me.RadioButton22)
        Me.Panel1.Controls.Add(Me.RadioButton17)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton16)
        Me.Panel1.Controls.Add(Me.RadioButton13)
        Me.Panel1.Controls.Add(Me.RadioButton11)
        Me.Panel1.Controls.Add(Me.RadioButton10)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(122, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 314)
        Me.Panel1.TabIndex = 30
        '
        'RadioButton26
        '
        Me.RadioButton26.AutoSize = True
        Me.RadioButton26.Checked = True
        Me.RadioButton26.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton26.Location = New System.Drawing.Point(39, 34)
        Me.RadioButton26.Name = "RadioButton26"
        Me.RadioButton26.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton26.TabIndex = 35
        Me.RadioButton26.TabStop = True
        Me.RadioButton26.Text = "Daily Demand Recived"
        Me.RadioButton26.UseVisualStyleBackColor = True
        '
        'RadioButton25
        '
        Me.RadioButton25.AutoSize = True
        Me.RadioButton25.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton25.Location = New System.Drawing.Point(38, 78)
        Me.RadioButton25.Name = "RadioButton25"
        Me.RadioButton25.Size = New System.Drawing.Size(148, 17)
        Me.RadioButton25.TabIndex = 34
        Me.RadioButton25.Text = "Active Balance Demands "
        Me.RadioButton25.UseVisualStyleBackColor = True
        '
        'RadioButton23
        '
        Me.RadioButton23.AutoSize = True
        Me.RadioButton23.ForeColor = System.Drawing.Color.Crimson
        Me.RadioButton23.Location = New System.Drawing.Point(38, 289)
        Me.RadioButton23.Name = "RadioButton23"
        Me.RadioButton23.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton23.TabIndex = 33
        Me.RadioButton23.Text = "Vendor List"
        Me.RadioButton23.UseVisualStyleBackColor = True
        '
        'RadioButton21
        '
        Me.RadioButton21.AutoSize = True
        Me.RadioButton21.ForeColor = System.Drawing.Color.Crimson
        Me.RadioButton21.Location = New System.Drawing.Point(38, 266)
        Me.RadioButton21.Name = "RadioButton21"
        Me.RadioButton21.Size = New System.Drawing.Size(132, 17)
        Me.RadioButton21.TabIndex = 32
        Me.RadioButton21.Text = "Price List Vendor Wise"
        Me.RadioButton21.UseVisualStyleBackColor = True
        '
        'RadioButton22
        '
        Me.RadioButton22.AutoSize = True
        Me.RadioButton22.ForeColor = System.Drawing.Color.Crimson
        Me.RadioButton22.Location = New System.Drawing.Point(38, 245)
        Me.RadioButton22.Name = "RadioButton22"
        Me.RadioButton22.Size = New System.Drawing.Size(118, 17)
        Me.RadioButton22.TabIndex = 31
        Me.RadioButton22.Text = "Price List Item Wise"
        Me.RadioButton22.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.ForeColor = System.Drawing.Color.Indigo
        Me.RadioButton17.Location = New System.Drawing.Point(38, 127)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(163, 17)
        Me.RadioButton17.TabIndex = 30
        Me.RadioButton17.Text = "Order Given  Demands Detail"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Indigo
        Me.RadioButton3.Location = New System.Drawing.Point(38, 104)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(156, 17)
        Me.RadioButton3.TabIndex = 29
        Me.RadioButton3.Text = "Non-Active Demands Detail"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.ForeColor = System.Drawing.Color.Crimson
        Me.RadioButton16.Location = New System.Drawing.Point(38, 176)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(164, 17)
        Me.RadioButton16.TabIndex = 27
        Me.RadioButton16.Text = "Purchase Summary For Cash "
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.ForeColor = System.Drawing.Color.DarkCyan
        Me.RadioButton13.Location = New System.Drawing.Point(38, 222)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton13.TabIndex = 25
        Me.RadioButton13.Text = "Partial Demand's Detail"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.ForeColor = System.Drawing.Color.Crimson
        Me.RadioButton11.Location = New System.Drawing.Point(38, 199)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(167, 17)
        Me.RadioButton11.TabIndex = 24
        Me.RadioButton11.Text = "Purchase Summary For Credit "
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RadioButton10.Location = New System.Drawing.Point(38, 150)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(181, 17)
        Me.RadioButton10.TabIndex = 23
        Me.RadioButton10.Text = "Full or Partial Purchase Demands"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton1.Location = New System.Drawing.Point(38, 57)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(117, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "Active Demand List"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(278, 25)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Filter Level 1  >>>"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1102, 40)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "New Demand Processing Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewDemandreports
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 772)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.OrderGivenDescComboBox)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.RadioButton14)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.RadioButton9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NewDemandreports"
        Me.Text = "NewDemandreports"
        CType(Me.Tbl_Pur_Demand1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_Demand_Head1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_Demand_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_Demand2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tbl_Pur_Demand1BindingSource As BindingSource
    Friend WithEvents DSPO As DSPO
    Friend WithEvents Tbl_Pur_Demand_Head1BindingSource As BindingSource
    Friend WithEvents Tbl_Pur_Demand_HeadBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_LocalCustBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_L4BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_SupplierBindingSource As BindingSource
    Friend WithEvents Tbl_Pur_Demand2BindingSource As BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As DSPOTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents Tbl_Inv_L4TableAdapter As DSPOTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Inv_LocalCustTableAdapter As DSPOTableAdapters.tbl_Inv_LocalCustTableAdapter
    Friend WithEvents Tbl_Pur_Demand_HeadTableAdapter As DSPOTableAdapters.tbl_Pur_Demand_HeadTableAdapter
    Friend WithEvents Tbl_Pur_Demand_Head1TableAdapter As DSPOTableAdapters.tbl_Pur_Demand_Head1TableAdapter
    Friend WithEvents Tbl_Pur_Demand1TableAdapter As DSPOTableAdapters.tbl_Pur_Demand1TableAdapter
    Friend WithEvents TableAdapterManager As DSPOTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Pur_Demand2TableAdapter As DSPOTableAdapters.tbl_Pur_Demand2TableAdapter
    Friend WithEvents Label23 As Label
    Friend WithEvents OrderGivenDescComboBox As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents RadioButton24 As RadioButton
    Friend WithEvents RadioButton20 As RadioButton
    Friend WithEvents RadioButton19 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents VendorNameComboBox As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GMNoComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GMNoComboBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CustNameComboBox As ComboBox
    Friend WithEvents L4NameComboBox As ComboBox
    Friend WithEvents CompanyNameComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton25 As RadioButton
    Friend WithEvents RadioButton23 As RadioButton
    Friend WithEvents RadioButton21 As RadioButton
    Friend WithEvents RadioButton22 As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton26 As RadioButton
End Class
