<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBERec
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
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim ImpRefNoLabel As System.Windows.Forms.Label
        Dim AddTaxLabel As System.Windows.Forms.Label
        Dim FederalExciseLabel As System.Windows.Forms.Label
        Dim IncomeTaxLabel As System.Windows.Forms.Label
        Dim SaleTaxLabel As System.Windows.Forms.Label
        Dim CustomDutyLabel As System.Windows.Forms.Label
        Dim BEAccessdValueLabel As System.Windows.Forms.Label
        Dim TotalValueLabel As System.Windows.Forms.Label
        Dim TotalMaterialLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim ChequeAmountLabel As System.Windows.Forms.Label
        Dim ChequeDateLabel As System.Windows.Forms.Label
        Dim ChequeNoLabel As System.Windows.Forms.Label
        Dim BETypeLabel As System.Windows.Forms.Label
        Dim BECountryLabel As System.Windows.Forms.Label
        Dim BENumberLabel As System.Windows.Forms.Label
        Dim BEIdLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBERec))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tbl_BE_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBERec = New FS_ERP_MM.DSBERec()
        Me.Tbl_BE_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSBERecTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSBERecTableAdapters.TableAdapterManager()
        Me.Tbl_BE_DetailTableAdapter = New FS_ERP_MM.DSBERecTableAdapters.tbl_BE_DetailTableAdapter()
        Me.Tbl_BE_HeadTableAdapter = New FS_ERP_MM.DSBERecTableAdapters.tbl_BE_HeadTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSBERecTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Pro_CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_CountryTableAdapter = New FS_ERP_MM.DSBERecTableAdapters.tbl_Pro_CountryTableAdapter()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSBERecTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ImpRefNoTextBox = New System.Windows.Forms.TextBox()
        Me.AddTaxTextBox = New System.Windows.Forms.TextBox()
        Me.FederalExciseTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeTaxTextBox = New System.Windows.Forms.TextBox()
        Me.SaleTaxTextBox = New System.Windows.Forms.TextBox()
        Me.CustomDutyTextBox = New System.Windows.Forms.TextBox()
        Me.BEAccessdValueTextBox = New System.Windows.Forms.TextBox()
        Me.TotalValueTextBox = New System.Windows.Forms.TextBox()
        Me.TotalMaterialTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ChequeAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ChequeDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ChequeNoTextBox = New System.Windows.Forms.TextBox()
        Me.BECountryComboBox = New System.Windows.Forms.ComboBox()
        Me.BENumberTextBox = New System.Windows.Forms.TextBox()
        Me.CMBESearch = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BETextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_BE_HeadBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_BE_HeadBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BEIdLabel1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_BE_DetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_BE_Head1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_BE_Head1TableAdapter = New FS_ERP_MM.DSBERecTableAdapters.tbl_BE_Head1TableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BEIdLabel3 = New System.Windows.Forms.Label()
        Me.DayIdLabel1 = New System.Windows.Forms.Label()
        DateNameLabel = New System.Windows.Forms.Label()
        ImpRefNoLabel = New System.Windows.Forms.Label()
        AddTaxLabel = New System.Windows.Forms.Label()
        FederalExciseLabel = New System.Windows.Forms.Label()
        IncomeTaxLabel = New System.Windows.Forms.Label()
        SaleTaxLabel = New System.Windows.Forms.Label()
        CustomDutyLabel = New System.Windows.Forms.Label()
        BEAccessdValueLabel = New System.Windows.Forms.Label()
        TotalValueLabel = New System.Windows.Forms.Label()
        TotalMaterialLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        ChequeAmountLabel = New System.Windows.Forms.Label()
        ChequeDateLabel = New System.Windows.Forms.Label()
        ChequeNoLabel = New System.Windows.Forms.Label()
        BETypeLabel = New System.Windows.Forms.Label()
        BECountryLabel = New System.Windows.Forms.Label()
        BENumberLabel = New System.Windows.Forms.Label()
        BEIdLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.Tbl_BE_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBERec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_BE_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CMBESearch.SuspendLayout()
        CType(Me.Tbl_BE_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_BE_HeadBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_BE_DetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_BE_Head1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(5, 32)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(100, 20)
        DateNameLabel.TabIndex = 9
        DateNameLabel.Text = "Transaction Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImpRefNoLabel
        '
        ImpRefNoLabel.Location = New System.Drawing.Point(404, 107)
        ImpRefNoLabel.Name = "ImpRefNoLabel"
        ImpRefNoLabel.Size = New System.Drawing.Size(78, 20)
        ImpRefNoLabel.TabIndex = 33
        ImpRefNoLabel.Text = "Imp Ref No:"
        ImpRefNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddTaxLabel
        '
        AddTaxLabel.Location = New System.Drawing.Point(210, 107)
        AddTaxLabel.Name = "AddTaxLabel"
        AddTaxLabel.Size = New System.Drawing.Size(82, 20)
        AddTaxLabel.TabIndex = 31
        AddTaxLabel.Text = "Add Tax:"
        AddTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FederalExciseLabel
        '
        FederalExciseLabel.Location = New System.Drawing.Point(7, 107)
        FederalExciseLabel.Name = "FederalExciseLabel"
        FederalExciseLabel.Size = New System.Drawing.Size(79, 20)
        FederalExciseLabel.TabIndex = 29
        FederalExciseLabel.Text = "Federal Excise:"
        FederalExciseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IncomeTaxLabel
        '
        IncomeTaxLabel.Location = New System.Drawing.Point(783, 107)
        IncomeTaxLabel.Name = "IncomeTaxLabel"
        IncomeTaxLabel.Size = New System.Drawing.Size(82, 20)
        IncomeTaxLabel.TabIndex = 27
        IncomeTaxLabel.Text = "Income Tax:"
        IncomeTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SaleTaxLabel
        '
        SaleTaxLabel.Location = New System.Drawing.Point(606, 107)
        SaleTaxLabel.Name = "SaleTaxLabel"
        SaleTaxLabel.Size = New System.Drawing.Size(74, 20)
        SaleTaxLabel.TabIndex = 25
        SaleTaxLabel.Text = "Sale Tax:"
        SaleTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomDutyLabel
        '
        CustomDutyLabel.Location = New System.Drawing.Point(404, 82)
        CustomDutyLabel.Name = "CustomDutyLabel"
        CustomDutyLabel.Size = New System.Drawing.Size(78, 20)
        CustomDutyLabel.TabIndex = 23
        CustomDutyLabel.Text = "Custom Duty:"
        CustomDutyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BEAccessdValueLabel
        '
        BEAccessdValueLabel.Location = New System.Drawing.Point(210, 82)
        BEAccessdValueLabel.Name = "BEAccessdValueLabel"
        BEAccessdValueLabel.Size = New System.Drawing.Size(82, 20)
        BEAccessdValueLabel.TabIndex = 21
        BEAccessdValueLabel.Text = "Accessd Value:"
        BEAccessdValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalValueLabel
        '
        TotalValueLabel.Location = New System.Drawing.Point(7, 82)
        TotalValueLabel.Name = "TotalValueLabel"
        TotalValueLabel.Size = New System.Drawing.Size(79, 20)
        TotalValueLabel.TabIndex = 19
        TotalValueLabel.Text = "Total Value $:"
        TotalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalMaterialLabel
        '
        TotalMaterialLabel.Location = New System.Drawing.Point(783, 82)
        TotalMaterialLabel.Name = "TotalMaterialLabel"
        TotalMaterialLabel.Size = New System.Drawing.Size(82, 20)
        TotalMaterialLabel.TabIndex = 17
        TotalMaterialLabel.Text = "Total Material:"
        TotalMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Location = New System.Drawing.Point(210, 57)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(82, 20)
        SupplierIDLabel.TabIndex = 15
        SupplierIDLabel.Text = "Supplier Name:"
        SupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChequeAmountLabel
        '
        ChequeAmountLabel.Location = New System.Drawing.Point(606, 82)
        ChequeAmountLabel.Name = "ChequeAmountLabel"
        ChequeAmountLabel.Size = New System.Drawing.Size(74, 20)
        ChequeAmountLabel.TabIndex = 14
        ChequeAmountLabel.Text = "Cheque Amnt:"
        ChequeAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChequeDateLabel
        '
        ChequeDateLabel.Location = New System.Drawing.Point(783, 57)
        ChequeDateLabel.Name = "ChequeDateLabel"
        ChequeDateLabel.Size = New System.Drawing.Size(82, 20)
        ChequeDateLabel.TabIndex = 13
        ChequeDateLabel.Text = "Cheque Date:"
        ChequeDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChequeNoLabel
        '
        ChequeNoLabel.Location = New System.Drawing.Point(606, 57)
        ChequeNoLabel.Name = "ChequeNoLabel"
        ChequeNoLabel.Size = New System.Drawing.Size(74, 20)
        ChequeNoLabel.TabIndex = 12
        ChequeNoLabel.Text = "Cheque No:"
        ChequeNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BETypeLabel
        '
        BETypeLabel.Location = New System.Drawing.Point(7, 57)
        BETypeLabel.Name = "BETypeLabel"
        BETypeLabel.Size = New System.Drawing.Size(79, 20)
        BETypeLabel.TabIndex = 11
        BETypeLabel.Text = "B/E Type:"
        BETypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BECountryLabel
        '
        BECountryLabel.Location = New System.Drawing.Point(404, 31)
        BECountryLabel.Name = "BECountryLabel"
        BECountryLabel.Size = New System.Drawing.Size(78, 20)
        BECountryLabel.TabIndex = 10
        BECountryLabel.Text = "B/E Country:"
        BECountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BENumberLabel
        '
        BENumberLabel.Location = New System.Drawing.Point(210, 31)
        BENumberLabel.Name = "BENumberLabel"
        BENumberLabel.Size = New System.Drawing.Size(82, 20)
        BENumberLabel.TabIndex = 9
        BENumberLabel.Text = "B/E Number:"
        BENumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BEIdLabel
        '
        BEIdLabel.Location = New System.Drawing.Point(7, 31)
        BEIdLabel.Name = "BEIdLabel"
        BEIdLabel.Size = New System.Drawing.Size(79, 20)
        BEIdLabel.TabIndex = 8
        BEIdLabel.Text = "Sr.No.:"
        BEIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(606, 31)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(74, 20)
        Label2.TabIndex = 35
        Label2.Text = "B/E Date:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(783, 31)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(82, 20)
        Label3.TabIndex = 37
        Label3.Text = "B/E Entry Date:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_BE_HeadBindingSource
        '
        Me.Tbl_BE_HeadBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_BE_Head"
        Me.Tbl_BE_HeadBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSBERec
        '
        'DSBERec
        '
        Me.DSBERec.DataSetName = "DSBERec"
        Me.DSBERec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_BE_DetailBindingSource
        '
        Me.Tbl_BE_DetailBindingSource.DataMember = "tbl_BE_Head_tbl_BE_Detail"
        Me.Tbl_BE_DetailBindingSource.DataSource = Me.Tbl_BE_HeadBindingSource
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_BE_DetailTableAdapter = Me.Tbl_BE_DetailTableAdapter
        Me.TableAdapterManager.tbl_BE_Head1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_BE_HeadTableAdapter = Me.Tbl_BE_HeadTableAdapter
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Me.Tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager.tbl_Pro_CountryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSBERecTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_BE_DetailTableAdapter
        '
        Me.Tbl_BE_DetailTableAdapter.ClearBeforeFill = True
        '
        'Tbl_BE_HeadTableAdapter
        '
        Me.Tbl_BE_HeadTableAdapter.ClearBeforeFill = True
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
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bill Of Entry Material Receiving Transactions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateNameLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.DateNameLabel1.Location = New System.Drawing.Point(111, 32)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(125, 20)
        Me.DateNameLabel1.TabIndex = 10
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.Location = New System.Drawing.Point(680, 51)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(16, 14)
        Me.DayNoLabel1.TabIndex = 13
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSBERec
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pro_CountryBindingSource
        '
        Me.Tbl_Pro_CountryBindingSource.DataMember = "tbl_Pro_Country"
        Me.Tbl_Pro_CountryBindingSource.DataSource = Me.DSBERec
        '
        'Tbl_Pro_CountryTableAdapter
        '
        Me.Tbl_Pro_CountryTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSBERec
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.MaskedTextBox2)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(ImpRefNoLabel)
        Me.Panel1.Controls.Add(Me.ImpRefNoTextBox)
        Me.Panel1.Controls.Add(AddTaxLabel)
        Me.Panel1.Controls.Add(Me.AddTaxTextBox)
        Me.Panel1.Controls.Add(FederalExciseLabel)
        Me.Panel1.Controls.Add(Me.FederalExciseTextBox)
        Me.Panel1.Controls.Add(IncomeTaxLabel)
        Me.Panel1.Controls.Add(Me.IncomeTaxTextBox)
        Me.Panel1.Controls.Add(SaleTaxLabel)
        Me.Panel1.Controls.Add(Me.SaleTaxTextBox)
        Me.Panel1.Controls.Add(CustomDutyLabel)
        Me.Panel1.Controls.Add(Me.CustomDutyTextBox)
        Me.Panel1.Controls.Add(BEAccessdValueLabel)
        Me.Panel1.Controls.Add(Me.BEAccessdValueTextBox)
        Me.Panel1.Controls.Add(TotalValueLabel)
        Me.Panel1.Controls.Add(Me.TotalValueTextBox)
        Me.Panel1.Controls.Add(TotalMaterialLabel)
        Me.Panel1.Controls.Add(Me.TotalMaterialTextBox)
        Me.Panel1.Controls.Add(SupplierIDLabel)
        Me.Panel1.Controls.Add(Me.SupplierIDComboBox)
        Me.Panel1.Controls.Add(ChequeAmountLabel)
        Me.Panel1.Controls.Add(Me.ChequeAmountTextBox)
        Me.Panel1.Controls.Add(ChequeDateLabel)
        Me.Panel1.Controls.Add(Me.ChequeDateMaskedTextBox)
        Me.Panel1.Controls.Add(ChequeNoLabel)
        Me.Panel1.Controls.Add(Me.ChequeNoTextBox)
        Me.Panel1.Controls.Add(BETypeLabel)
        Me.Panel1.Controls.Add(BECountryLabel)
        Me.Panel1.Controls.Add(Me.BECountryComboBox)
        Me.Panel1.Controls.Add(BENumberLabel)
        Me.Panel1.Controls.Add(Me.BENumberTextBox)
        Me.Panel1.Controls.Add(BEIdLabel)
        Me.Panel1.Controls.Add(Me.Tbl_BE_HeadBindingNavigator)
        Me.Panel1.Controls.Add(Me.BEIdLabel1)
        Me.Panel1.Location = New System.Drawing.Point(7, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 137)
        Me.Panel1.TabIndex = 14
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "BEEntryDate", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(869, 31)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(99, 20)
        Me.MaskedTextBox2.TabIndex = 13
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "BEDate", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(682, 31)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(97, 20)
        Me.MaskedTextBox1.TabIndex = 12
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "BEType", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"IB", "EOU"})
        Me.ComboBox1.Location = New System.Drawing.Point(87, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'ImpRefNoTextBox
        '
        Me.ImpRefNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "ImpRefNo", True))
        Me.ImpRefNoTextBox.Location = New System.Drawing.Point(485, 107)
        Me.ImpRefNoTextBox.Name = "ImpRefNoTextBox"
        Me.ImpRefNoTextBox.Size = New System.Drawing.Size(114, 20)
        Me.ImpRefNoTextBox.TabIndex = 25
        Me.ImpRefNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddTaxTextBox
        '
        Me.AddTaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "AddTax", True))
        Me.AddTaxTextBox.Location = New System.Drawing.Point(294, 107)
        Me.AddTaxTextBox.Name = "AddTaxTextBox"
        Me.AddTaxTextBox.Size = New System.Drawing.Size(106, 20)
        Me.AddTaxTextBox.TabIndex = 24
        Me.AddTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FederalExciseTextBox
        '
        Me.FederalExciseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "FederalExcise", True))
        Me.FederalExciseTextBox.Location = New System.Drawing.Point(87, 107)
        Me.FederalExciseTextBox.Name = "FederalExciseTextBox"
        Me.FederalExciseTextBox.Size = New System.Drawing.Size(112, 20)
        Me.FederalExciseTextBox.TabIndex = 23
        Me.FederalExciseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IncomeTaxTextBox
        '
        Me.IncomeTaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "IncomeTax", True))
        Me.IncomeTaxTextBox.Location = New System.Drawing.Point(869, 107)
        Me.IncomeTaxTextBox.Name = "IncomeTaxTextBox"
        Me.IncomeTaxTextBox.Size = New System.Drawing.Size(99, 20)
        Me.IncomeTaxTextBox.TabIndex = 27
        Me.IncomeTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SaleTaxTextBox
        '
        Me.SaleTaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "SaleTax", True))
        Me.SaleTaxTextBox.Location = New System.Drawing.Point(682, 107)
        Me.SaleTaxTextBox.Name = "SaleTaxTextBox"
        Me.SaleTaxTextBox.Size = New System.Drawing.Size(97, 20)
        Me.SaleTaxTextBox.TabIndex = 26
        Me.SaleTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustomDutyTextBox
        '
        Me.CustomDutyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "CustomDuty", True))
        Me.CustomDutyTextBox.Location = New System.Drawing.Point(485, 82)
        Me.CustomDutyTextBox.Name = "CustomDutyTextBox"
        Me.CustomDutyTextBox.Size = New System.Drawing.Size(114, 20)
        Me.CustomDutyTextBox.TabIndex = 20
        Me.CustomDutyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BEAccessdValueTextBox
        '
        Me.BEAccessdValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "BEAccessdValue", True))
        Me.BEAccessdValueTextBox.Location = New System.Drawing.Point(294, 82)
        Me.BEAccessdValueTextBox.Name = "BEAccessdValueTextBox"
        Me.BEAccessdValueTextBox.Size = New System.Drawing.Size(106, 20)
        Me.BEAccessdValueTextBox.TabIndex = 19
        Me.BEAccessdValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalValueTextBox
        '
        Me.TotalValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "TotalValue", True))
        Me.TotalValueTextBox.Location = New System.Drawing.Point(87, 82)
        Me.TotalValueTextBox.Name = "TotalValueTextBox"
        Me.TotalValueTextBox.Size = New System.Drawing.Size(112, 20)
        Me.TotalValueTextBox.TabIndex = 18
        Me.TotalValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalMaterialTextBox
        '
        Me.TotalMaterialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "TotalMaterial", True))
        Me.TotalMaterialTextBox.Location = New System.Drawing.Point(869, 82)
        Me.TotalMaterialTextBox.Name = "TotalMaterialTextBox"
        Me.TotalMaterialTextBox.Size = New System.Drawing.Size(99, 20)
        Me.TotalMaterialTextBox.TabIndex = 22
        Me.TotalMaterialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_BE_HeadBindingSource, "SupplierID", True))
        Me.SupplierIDComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.SupplierIDComboBox.DisplayMember = "CompanyName"
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(295, 56)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(305, 21)
        Me.SupplierIDComboBox.TabIndex = 15
        Me.SupplierIDComboBox.ValueMember = "SupplierID"
        '
        'ChequeAmountTextBox
        '
        Me.ChequeAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "ChequeAmount", True))
        Me.ChequeAmountTextBox.Location = New System.Drawing.Point(682, 82)
        Me.ChequeAmountTextBox.Name = "ChequeAmountTextBox"
        Me.ChequeAmountTextBox.Size = New System.Drawing.Size(97, 20)
        Me.ChequeAmountTextBox.TabIndex = 21
        Me.ChequeAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChequeDateMaskedTextBox
        '
        Me.ChequeDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "ChequeDate", True))
        Me.ChequeDateMaskedTextBox.Location = New System.Drawing.Point(869, 57)
        Me.ChequeDateMaskedTextBox.Mask = "00/00/0000"
        Me.ChequeDateMaskedTextBox.Name = "ChequeDateMaskedTextBox"
        Me.ChequeDateMaskedTextBox.Size = New System.Drawing.Size(99, 20)
        Me.ChequeDateMaskedTextBox.TabIndex = 17
        Me.ChequeDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ChequeDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ChequeNoTextBox
        '
        Me.ChequeNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "ChequeNo", True))
        Me.ChequeNoTextBox.Location = New System.Drawing.Point(682, 57)
        Me.ChequeNoTextBox.Name = "ChequeNoTextBox"
        Me.ChequeNoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.ChequeNoTextBox.TabIndex = 16
        Me.ChequeNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BECountryComboBox
        '
        Me.BECountryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BECountryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BECountryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_BE_HeadBindingSource, "CountryId", True))
        Me.BECountryComboBox.DataSource = Me.Tbl_Pro_CountryBindingSource
        Me.BECountryComboBox.DisplayMember = "CountryName"
        Me.BECountryComboBox.FormattingEnabled = True
        Me.BECountryComboBox.Location = New System.Drawing.Point(486, 30)
        Me.BECountryComboBox.Name = "BECountryComboBox"
        Me.BECountryComboBox.Size = New System.Drawing.Size(114, 21)
        Me.BECountryComboBox.TabIndex = 11
        Me.BECountryComboBox.ValueMember = "CountryID"
        '
        'BENumberTextBox
        '
        Me.BENumberTextBox.ContextMenuStrip = Me.CMBESearch
        Me.BENumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "BENumber", True))
        Me.BENumberTextBox.Location = New System.Drawing.Point(294, 31)
        Me.BENumberTextBox.Name = "BENumberTextBox"
        Me.BENumberTextBox.Size = New System.Drawing.Size(106, 20)
        Me.BENumberTextBox.TabIndex = 10
        '
        'CMBESearch
        '
        Me.CMBESearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BETextBox, Me.RemoveFilterToolStripMenuItem})
        Me.CMBESearch.Name = "CMBESearch"
        Me.CMBESearch.Size = New System.Drawing.Size(161, 51)
        '
        'BETextBox
        '
        Me.BETextBox.Name = "BETextBox"
        Me.BETextBox.Size = New System.Drawing.Size(100, 23)
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove Filter"
        '
        'Tbl_BE_HeadBindingNavigator
        '
        Me.Tbl_BE_HeadBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_BE_HeadBindingNavigator.BindingSource = Me.Tbl_BE_HeadBindingSource
        Me.Tbl_BE_HeadBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_BE_HeadBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_BE_HeadBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_BE_HeadBindingNavigatorSaveItem})
        Me.Tbl_BE_HeadBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_BE_HeadBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_BE_HeadBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_BE_HeadBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_BE_HeadBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_BE_HeadBindingNavigator.Name = "Tbl_BE_HeadBindingNavigator"
        Me.Tbl_BE_HeadBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_BE_HeadBindingNavigator.Size = New System.Drawing.Size(976, 25)
        Me.Tbl_BE_HeadBindingNavigator.TabIndex = 8
        Me.Tbl_BE_HeadBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_BE_HeadBindingNavigatorSaveItem
        '
        Me.Tbl_BE_HeadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_BE_HeadBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_BE_HeadBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_BE_HeadBindingNavigatorSaveItem.Name = "Tbl_BE_HeadBindingNavigatorSaveItem"
        Me.Tbl_BE_HeadBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_BE_HeadBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BEIdLabel1
        '
        Me.BEIdLabel1.BackColor = System.Drawing.Color.White
        Me.BEIdLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BEIdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_HeadBindingSource, "BEId", True))
        Me.BEIdLabel1.Location = New System.Drawing.Point(87, 30)
        Me.BEIdLabel1.Name = "BEIdLabel1"
        Me.BEIdLabel1.Size = New System.Drawing.Size(112, 21)
        Me.BEIdLabel1.TabIndex = 9
        Me.BEIdLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.Tbl_BE_DetailDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(7, 247)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(631, 402)
        Me.Panel2.TabIndex = 15
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.Tbl_BE_DetailBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(629, 25)
        Me.BindingNavigator1.TabIndex = 11
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'Tbl_BE_DetailDataGridView
        '
        Me.Tbl_BE_DetailDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_BE_DetailDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_BE_DetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_BE_DetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Tbl_BE_DetailDataGridView.DataSource = Me.Tbl_BE_DetailBindingSource
        Me.Tbl_BE_DetailDataGridView.Location = New System.Drawing.Point(2, 27)
        Me.Tbl_BE_DetailDataGridView.Name = "Tbl_BE_DetailDataGridView"
        Me.Tbl_BE_DetailDataGridView.Size = New System.Drawing.Size(624, 370)
        Me.Tbl_BE_DetailDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TranId"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sr.No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DayId"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DayId"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BEId"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BEId"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.Tbl_Inv_L4BindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn4.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Material Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "Code"
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ReceiveQty"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Receive Qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PreUsed"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pre Used Qty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Tbl_BE_Head1BindingSource
        '
        Me.Tbl_BE_Head1BindingSource.DataMember = "tbl_BE_Head1"
        Me.Tbl_BE_Head1BindingSource.DataSource = Me.DSBERec
        '
        'Tbl_BE_Head1TableAdapter
        '
        Me.Tbl_BE_Head1TableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BindingNavigator2)
        Me.Panel3.Controls.Add(DateNameLabel)
        Me.Panel3.Controls.Add(Me.DateNameLabel1)
        Me.Panel3.Location = New System.Drawing.Point(7, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(263, 60)
        Me.Panel3.TabIndex = 16
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator2.Size = New System.Drawing.Size(261, 25)
        Me.BindingNavigator2.TabIndex = 0
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'BEIdLabel3
        '
        Me.BEIdLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_Head1BindingSource, "BEId", True))
        Me.BEIdLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.BEIdLabel3.Location = New System.Drawing.Point(708, 292)
        Me.BEIdLabel3.Name = "BEIdLabel3"
        Me.BEIdLabel3.Size = New System.Drawing.Size(10, 10)
        Me.BEIdLabel3.TabIndex = 17
        '
        'DayIdLabel1
        '
        Me.DayIdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_BE_Head1BindingSource, "DayId", True))
        Me.DayIdLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.DayIdLabel1.Location = New System.Drawing.Point(708, 329)
        Me.DayIdLabel1.Name = "DayIdLabel1"
        Me.DayIdLabel1.Size = New System.Drawing.Size(10, 10)
        Me.DayIdLabel1.TabIndex = 18
        '
        'frmBERec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.DayIdLabel1)
        Me.Controls.Add(Me.BEIdLabel3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DayNoLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBERec"
        Me.Text = "Bill Of Entry Material Receiving Transactions"
        CType(Me.Tbl_BE_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBERec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_BE_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CMBESearch.ResumeLayout(False)
        Me.CMBESearch.PerformLayout()
        CType(Me.Tbl_BE_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_BE_HeadBindingNavigator.ResumeLayout(False)
        Me.Tbl_BE_HeadBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_BE_DetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_BE_Head1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSBERec As FS_ERP_MM.DSBERec
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSBERecTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSBERecTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_BE_HeadTableAdapter As FS_ERP_MM.DSBERecTableAdapters.tbl_BE_HeadTableAdapter
    Friend WithEvents Tbl_BE_HeadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BE_DetailTableAdapter As FS_ERP_MM.DSBERecTableAdapters.tbl_BE_DetailTableAdapter
    Friend WithEvents Tbl_BE_DetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSBERecTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Pro_CountryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pro_CountryTableAdapter As FS_ERP_MM.DSBERecTableAdapters.tbl_Pro_CountryTableAdapter
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSBERecTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ImpRefNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddTaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FederalExciseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IncomeTaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaleTaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomDutyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BEAccessdValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalMaterialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ChequeAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChequeDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ChequeNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BECountryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BENumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tbl_BE_HeadBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_BE_HeadBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BEIdLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_BE_DetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Tbl_BE_Head1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BE_Head1TableAdapter As FS_ERP_MM.DSBERecTableAdapters.tbl_BE_Head1TableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BEIdLabel3 As System.Windows.Forms.Label
    Friend WithEvents DayIdLabel1 As System.Windows.Forms.Label
    Friend WithEvents CMBESearch As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BETextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
