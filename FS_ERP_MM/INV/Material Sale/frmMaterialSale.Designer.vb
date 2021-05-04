<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialSale
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
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim TranInIDLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim SDNoLabel As System.Windows.Forms.Label
        Dim SIDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialSale))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsSaleIssuence = New FS_ERP_MM.DsSaleIssuence()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DsSaleIssuenceTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DsSaleIssuenceTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_Tran_OutTableAdapter = New FS_ERP_MM.DsSaleIssuenceTableAdapters.tbl_Inv_Tran_OutTableAdapter()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RackNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Tran_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Rack_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranDocNoLabel1 = New System.Windows.Forms.Label()
        Me.CustIDLabel1 = New System.Windows.Forms.Label()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.View_MM_SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CPPULabel1 = New System.Windows.Forms.Label()
        Me.CurrencyLabel1 = New System.Windows.Forms.Label()
        Me.SDNoLabel2 = New System.Windows.Forms.Label()
        Me.SIDLabel2 = New System.Windows.Forms.Label()
        Me.UOMLabel = New System.Windows.Forms.Label()
        Me.UOMLabel1 = New System.Windows.Forms.Label()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddSale = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteSale = New System.Windows.Forms.ToolStripButton()
        Me.SaveSale = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoSale = New System.Windows.Forms.ToolStripButton()
        Me.TranOutIDLabel1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.View_MM_SaleTableAdapter = New FS_ERP_MM.DsSaleIssuenceTableAdapters.View_MM_SaleTableAdapter()
        Me.View_Customer_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Customer_DTableAdapter = New FS_ERP_MM.DsSaleIssuenceTableAdapters.View_Customer_DTableAdapter()
        Me.View_Customer_DDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleQty1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_Inv_Mat_AvailableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Inv_Mat_AvailableTableAdapter = New FS_ERP_MM.DsSaleIssuenceTableAdapters.View_Inv_Mat_AvailableTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Inv_Rack_InfoTableAdapter = New FS_ERP_MM.DsSaleIssuenceTableAdapters.tbl_Inv_Rack_InfoTableAdapter()
        DateNameLabel = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        TranInIDLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        SDNoLabel = New System.Windows.Forms.Label()
        SIDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DsSaleIssuence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MM_SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_Customer_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Customer_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Inv_Mat_AvailableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(12, 33)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(69, 20)
        DateNameLabel.TabIndex = 8
        DateNameLabel.Text = "Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameLabel
        '
        L4NameLabel.Location = New System.Drawing.Point(4, 58)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(77, 20)
        L4NameLabel.TabIndex = 2
        L4NameLabel.Text = "Material:"
        L4NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranInIDLabel
        '
        TranInIDLabel.Location = New System.Drawing.Point(4, 33)
        TranInIDLabel.Name = "TranInIDLabel"
        TranInIDLabel.Size = New System.Drawing.Size(77, 20)
        TranInIDLabel.TabIndex = 0
        TranInIDLabel.Text = "S. No.:"
        TranInIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QtyLabel
        '
        QtyLabel.Location = New System.Drawing.Point(4, 160)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(77, 20)
        QtyLabel.TabIndex = 31
        QtyLabel.Text = "Qty:"
        QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SDNoLabel
        '
        SDNoLabel.Location = New System.Drawing.Point(4, 134)
        SDNoLabel.Name = "SDNoLabel"
        SDNoLabel.Size = New System.Drawing.Size(77, 20)
        SDNoLabel.TabIndex = 30
        SDNoLabel.Text = "Sale D No.:"
        SDNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SIDLabel
        '
        SIDLabel.Location = New System.Drawing.Point(4, 108)
        SIDLabel.Name = "SIDLabel"
        SIDLabel.Size = New System.Drawing.Size(77, 20)
        SIDLabel.TabIndex = 29
        SIDLabel.Text = "Sale No.:"
        SIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(4, 83)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(77, 20)
        Label2.TabIndex = 44
        Label2.Text = "Rack No.:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DsSaleIssuence
        '
        Me.DsSaleIssuence.DataSetName = "DsSaleIssuence"
        Me.DsSaleIssuence.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1188, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sales Material Issuance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DsSaleIssuence
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_CodeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Rack_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Me.Tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_OutTableAdapter = Me.Tbl_Inv_Tran_OutTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DsSaleIssuenceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_Tran_OutTableAdapter
        '
        Me.Tbl_Inv_Tran_OutTableAdapter.ClearBeforeFill = True
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.Location = New System.Drawing.Point(269, 81)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(37, 20)
        Me.DayNoLabel1.TabIndex = 6
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(87, 33)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DateNameLabel1.TabIndex = 7
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.RackNoComboBox)
        Me.Panel1.Controls.Add(Me.TranDocNoLabel1)
        Me.Panel1.Controls.Add(Me.CustIDLabel1)
        Me.Panel1.Controls.Add(Me.L4NameComboBox)
        Me.Panel1.Controls.Add(Me.CPPULabel1)
        Me.Panel1.Controls.Add(Me.CurrencyLabel1)
        Me.Panel1.Controls.Add(Me.SDNoLabel2)
        Me.Panel1.Controls.Add(Me.SIDLabel2)
        Me.Panel1.Controls.Add(Me.UOMLabel)
        Me.Panel1.Controls.Add(Me.UOMLabel1)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Controls.Add(SDNoLabel)
        Me.Panel1.Controls.Add(SIDLabel)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.TranOutIDLabel1)
        Me.Panel1.Controls.Add(L4NameLabel)
        Me.Panel1.Controls.Add(TranInIDLabel)
        Me.Panel1.Location = New System.Drawing.Point(7, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 316)
        Me.Panel1.TabIndex = 9
        '
        'RackNoComboBox
        '
        Me.RackNoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "RackId", True))
        Me.RackNoComboBox.DataSource = Me.Tbl_Inv_Rack_InfoBindingSource
        Me.RackNoComboBox.DisplayMember = "RackNo"
        Me.RackNoComboBox.FormattingEnabled = True
        Me.RackNoComboBox.Location = New System.Drawing.Point(87, 82)
        Me.RackNoComboBox.Name = "RackNoComboBox"
        Me.RackNoComboBox.Size = New System.Drawing.Size(227, 21)
        Me.RackNoComboBox.TabIndex = 43
        Me.RackNoComboBox.ValueMember = "RackId"
        '
        'Tbl_Inv_Tran_OutBindingSource
        '
        Me.Tbl_Inv_Tran_OutBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Inv_Tran_Out"
        Me.Tbl_Inv_Tran_OutBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'Tbl_Inv_Rack_InfoBindingSource
        '
        Me.Tbl_Inv_Rack_InfoBindingSource.DataMember = "tbl_Inv_Rack_Info"
        Me.Tbl_Inv_Rack_InfoBindingSource.DataSource = Me.DsSaleIssuence
        '
        'TranDocNoLabel1
        '
        Me.TranDocNoLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TranDocNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranDocNo", True))
        Me.TranDocNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TranDocNoLabel1.Location = New System.Drawing.Point(198, 164)
        Me.TranDocNoLabel1.Name = "TranDocNoLabel1"
        Me.TranDocNoLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TranDocNoLabel1.TabIndex = 42
        Me.TranDocNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustIDLabel1
        '
        Me.CustIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "CustID", True))
        Me.CustIDLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CustIDLabel1.Location = New System.Drawing.Point(239, 115)
        Me.CustIDLabel1.Name = "CustIDLabel1"
        Me.CustIDLabel1.Size = New System.Drawing.Size(10, 17)
        Me.CustIDLabel1.TabIndex = 41
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "Code", True))
        Me.L4NameComboBox.DataSource = Me.View_MM_SaleBindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(87, 57)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(227, 21)
        Me.L4NameComboBox.TabIndex = 40
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'View_MM_SaleBindingSource
        '
        Me.View_MM_SaleBindingSource.DataMember = "View_MM_Sale"
        Me.View_MM_SaleBindingSource.DataSource = Me.DsSaleIssuence
        '
        'CPPULabel1
        '
        Me.CPPULabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "PPU", True))
        Me.CPPULabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.Location = New System.Drawing.Point(198, 138)
        Me.CPPULabel1.Name = "CPPULabel1"
        Me.CPPULabel1.Size = New System.Drawing.Size(100, 20)
        Me.CPPULabel1.TabIndex = 39
        Me.CPPULabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CurrencyLabel1
        '
        Me.CurrencyLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Currency", True))
        Me.CurrencyLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.Location = New System.Drawing.Point(198, 164)
        Me.CurrencyLabel1.Name = "CurrencyLabel1"
        Me.CurrencyLabel1.Size = New System.Drawing.Size(100, 20)
        Me.CurrencyLabel1.TabIndex = 38
        Me.CurrencyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SDNoLabel2
        '
        Me.SDNoLabel2.BackColor = System.Drawing.Color.White
        Me.SDNoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SDNoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "SDNo", True))
        Me.SDNoLabel2.Location = New System.Drawing.Point(87, 134)
        Me.SDNoLabel2.Name = "SDNoLabel2"
        Me.SDNoLabel2.Size = New System.Drawing.Size(100, 20)
        Me.SDNoLabel2.TabIndex = 36
        Me.SDNoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SIDLabel2
        '
        Me.SIDLabel2.BackColor = System.Drawing.Color.White
        Me.SIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "SID", True))
        Me.SIDLabel2.Location = New System.Drawing.Point(87, 108)
        Me.SIDLabel2.Name = "SIDLabel2"
        Me.SIDLabel2.Size = New System.Drawing.Size(100, 20)
        Me.SIDLabel2.TabIndex = 35
        Me.SIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UOMLabel
        '
        Me.UOMLabel.Location = New System.Drawing.Point(4, 186)
        Me.UOMLabel.Name = "UOMLabel"
        Me.UOMLabel.Size = New System.Drawing.Size(77, 20)
        Me.UOMLabel.TabIndex = 32
        Me.UOMLabel.Text = "UOM:"
        Me.UOMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UOMLabel1
        '
        Me.UOMLabel1.BackColor = System.Drawing.Color.White
        Me.UOMLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UOMLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "UOM", True))
        Me.UOMLabel1.Location = New System.Drawing.Point(87, 186)
        Me.UOMLabel1.Name = "UOMLabel1"
        Me.UOMLabel1.Size = New System.Drawing.Size(100, 20)
        Me.UOMLabel1.TabIndex = 33
        Me.UOMLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(87, 160)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTextBox.TabIndex = 28
        Me.QtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_Tran_OutBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AddSale, Me.toolStripSeparator, Me.DeleteSale, Me.SaveSale, Me.toolStripSeparator3, Me.UndoSale})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(338, 25)
        Me.BindingNavigator1.TabIndex = 27
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'AddSale
        '
        Me.AddSale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddSale.Image = CType(resources.GetObject("AddSale.Image"), System.Drawing.Image)
        Me.AddSale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddSale.Name = "AddSale"
        Me.AddSale.Size = New System.Drawing.Size(23, 22)
        Me.AddSale.Text = "Add new"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteSale
        '
        Me.DeleteSale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteSale.Image = CType(resources.GetObject("DeleteSale.Image"), System.Drawing.Image)
        Me.DeleteSale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteSale.Name = "DeleteSale"
        Me.DeleteSale.Size = New System.Drawing.Size(23, 22)
        Me.DeleteSale.Text = "Delete"
        '
        'SaveSale
        '
        Me.SaveSale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveSale.Image = CType(resources.GetObject("SaveSale.Image"), System.Drawing.Image)
        Me.SaveSale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveSale.Name = "SaveSale"
        Me.SaveSale.Size = New System.Drawing.Size(23, 22)
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'UndoSale
        '
        Me.UndoSale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoSale.Image = CType(resources.GetObject("UndoSale.Image"), System.Drawing.Image)
        Me.UndoSale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoSale.Name = "UndoSale"
        Me.UndoSale.Size = New System.Drawing.Size(23, 22)
        Me.UndoSale.Text = "Undo"
        '
        'TranOutIDLabel1
        '
        Me.TranOutIDLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TranOutIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TranOutIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranOutID", True))
        Me.TranOutIDLabel1.Location = New System.Drawing.Point(87, 33)
        Me.TranOutIDLabel1.Name = "TranOutIDLabel1"
        Me.TranOutIDLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TranOutIDLabel1.TabIndex = 26
        Me.TranOutIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Gate Pass"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'View_MM_SaleTableAdapter
        '
        Me.View_MM_SaleTableAdapter.ClearBeforeFill = True
        '
        'View_Customer_DBindingSource
        '
        Me.View_Customer_DBindingSource.DataMember = "View_Customer_D"
        Me.View_Customer_DBindingSource.DataSource = Me.DsSaleIssuence
        '
        'View_Customer_DTableAdapter
        '
        Me.View_Customer_DTableAdapter.ClearBeforeFill = True
        '
        'View_Customer_DDataGridView
        '
        Me.View_Customer_DDataGridView.AllowUserToAddRows = False
        Me.View_Customer_DDataGridView.AllowUserToDeleteRows = False
        Me.View_Customer_DDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_Customer_DDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_Customer_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Customer_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.SaleQty1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn10, Me.CustID, Me.Balance})
        Me.View_Customer_DDataGridView.DataSource = Me.View_Customer_DBindingSource
        Me.View_Customer_DDataGridView.Location = New System.Drawing.Point(349, 109)
        Me.View_Customer_DDataGridView.Name = "View_Customer_DDataGridView"
        Me.View_Customer_DDataGridView.ReadOnly = True
        Me.View_Customer_DDataGridView.Size = New System.Drawing.Size(630, 316)
        Me.View_Customer_DDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CompanyName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Company Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sale No."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SDNo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SDNo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Curency"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Curency"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'SaleQty1
        '
        Me.SaleQty1.DataPropertyName = "SaleQty1"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SaleQty1.DefaultCellStyle = DataGridViewCellStyle5
        Me.SaleQty1.HeaderText = "Sale Qty"
        Me.SaleQty1.Name = "SaleQty1"
        Me.SaleQty1.ReadOnly = True
        Me.SaleQty1.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UOM"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EntryDate"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "dd/MM/yy"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sale Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IssuedQty"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn10.HeaderText = "Issued Qty"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'CustID
        '
        Me.CustID.DataPropertyName = "CustID"
        Me.CustID.HeaderText = "CustID"
        Me.CustID.Name = "CustID"
        Me.CustID.ReadOnly = True
        Me.CustID.Visible = False
        '
        'Balance
        '
        Me.Balance.DataPropertyName = "Balance"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Balance.DefaultCellStyle = DataGridViewCellStyle9
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        Me.Balance.Width = 70
        '
        'View_Inv_Mat_AvailableBindingSource
        '
        Me.View_Inv_Mat_AvailableBindingSource.DataMember = "View_Inv_Mat_Available"
        Me.View_Inv_Mat_AvailableBindingSource.DataSource = Me.DsSaleIssuence
        '
        'View_Inv_Mat_AvailableTableAdapter
        '
        Me.View_Inv_Mat_AvailableTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator2)
        Me.Panel2.Controls.Add(DateNameLabel)
        Me.Panel2.Controls.Add(Me.DateNameLabel1)
        Me.Panel2.Location = New System.Drawing.Point(7, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 61)
        Me.Panel2.TabIndex = 11
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator2.Size = New System.Drawing.Size(248, 25)
        Me.BindingNavigator2.TabIndex = 9
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
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
        'Tbl_Inv_Rack_InfoTableAdapter
        '
        Me.Tbl_Inv_Rack_InfoTableAdapter.ClearBeforeFill = True
        '
        'frmMaterialSale
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 656)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.View_Customer_DDataGridView)
        Me.Controls.Add(Me.DayNoLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMaterialSale"
        Me.Text = "Sales Material Issuence"
        CType(Me.DsSaleIssuence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_MM_SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_Customer_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Customer_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Inv_Mat_AvailableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DsSaleIssuence As FS_ERP_MM.DsSaleIssuence
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DsSaleIssuenceTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DsSaleIssuenceTableAdapters.TableAdapterManager
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TranOutIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_Tran_OutTableAdapter As FS_ERP_MM.DsSaleIssuenceTableAdapters.tbl_Inv_Tran_OutTableAdapter
    Friend WithEvents Tbl_Inv_Tran_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddSale As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteSale As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveSale As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoSale As System.Windows.Forms.ToolStripButton
    Friend WithEvents CPPULabel1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents SDNoLabel2 As System.Windows.Forms.Label
    Friend WithEvents SIDLabel2 As System.Windows.Forms.Label
    Friend WithEvents UOMLabel As System.Windows.Forms.Label
    Friend WithEvents UOMLabel1 As System.Windows.Forms.Label
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents View_MM_SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_MM_SaleTableAdapter As FS_ERP_MM.DsSaleIssuenceTableAdapters.View_MM_SaleTableAdapter
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents View_Customer_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Customer_DTableAdapter As FS_ERP_MM.DsSaleIssuenceTableAdapters.View_Customer_DTableAdapter
    Friend WithEvents View_Customer_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CustIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Inv_Mat_AvailableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Inv_Mat_AvailableTableAdapter As FS_ERP_MM.DsSaleIssuenceTableAdapters.View_Inv_Mat_AvailableTableAdapter
    Friend WithEvents TranDocNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaleQty1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_Inv_Rack_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Rack_InfoTableAdapter As FS_ERP_MM.DsSaleIssuenceTableAdapters.tbl_Inv_Rack_InfoTableAdapter
    Friend WithEvents RackNoComboBox As System.Windows.Forms.ComboBox
End Class
