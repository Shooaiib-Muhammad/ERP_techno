<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatBorrowedIssued
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
        Dim TranInIDLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim SIDLabel As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatBorrowedIssued))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DSMat_Brow = New FS_ERP_MM.DSMat_Brow()
        Me.TableAdapterManager = New FS_ERP_MM.DSMat_BrowTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.Tbl_Inv_Tran_OutTableAdapter = New FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Tran_OutTableAdapter()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RackNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Tran_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Rack_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranDocNoLabel1 = New System.Windows.Forms.Label()
        Me.SupplierIDLabel1 = New System.Windows.Forms.Label()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.View_Browed_MatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CPPULabel1 = New System.Windows.Forms.Label()
        Me.CurrencyLabel1 = New System.Windows.Forms.Label()
        Me.TranInIDLabel2 = New System.Windows.Forms.Label()
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
        Me.AddOut = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteOut = New System.Windows.Forms.ToolStripButton()
        Me.SaveOut = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoOut = New System.Windows.Forms.ToolStripButton()
        Me.TranOutIDLabel1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranInID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PPU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_BrowedMat_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_BrowedMat_DTableAdapter = New FS_ERP_MM.DSMat_BrowTableAdapters.View_BrowedMat_DTableAdapter()
        Me.View_BrowedMat_DDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_Browed_MatTableAdapter = New FS_ERP_MM.DSMat_BrowTableAdapters.View_Browed_MatTableAdapter()
        Me.btnGatePass = New System.Windows.Forms.Button()
        Me.View_Inv_Mat_AvailableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Inv_Mat_AvailableTableAdapter = New FS_ERP_MM.DSMat_BrowTableAdapters.View_Inv_Mat_AvailableTableAdapter()
        Me.Tbl_Inv_Rack_InfoTableAdapter = New FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Rack_InfoTableAdapter()
        DateNameLabel = New System.Windows.Forms.Label()
        TranInIDLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        SIDLabel = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DSMat_Brow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Browed_MatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_BrowedMat_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_BrowedMat_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Inv_Mat_AvailableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(15, 51)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(72, 20)
        DateNameLabel.TabIndex = 17
        DateNameLabel.Text = "Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranInIDLabel
        '
        TranInIDLabel.Location = New System.Drawing.Point(5, 33)
        TranInIDLabel.Name = "TranInIDLabel"
        TranInIDLabel.Size = New System.Drawing.Size(77, 20)
        TranInIDLabel.TabIndex = 0
        TranInIDLabel.Text = "S. No.:"
        TranInIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QtyLabel
        '
        QtyLabel.Location = New System.Drawing.Point(5, 132)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(77, 20)
        QtyLabel.TabIndex = 31
        QtyLabel.Text = "Qty:"
        QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SIDLabel
        '
        SIDLabel.Location = New System.Drawing.Point(5, 107)
        SIDLabel.Name = "SIDLabel"
        SIDLabel.Size = New System.Drawing.Size(77, 20)
        SIDLabel.TabIndex = 29
        SIDLabel.Text = "Tran In No.:"
        SIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameLabel
        '
        L4NameLabel.Location = New System.Drawing.Point(5, 58)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(77, 20)
        L4NameLabel.TabIndex = 2
        L4NameLabel.Text = "Material:"
        L4NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(5, 83)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(77, 20)
        Label2.TabIndex = 44
        Label2.Text = "Rack No.:"
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
        Me.Label1.Size = New System.Drawing.Size(1523, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Borrowed Material Issuence"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DSMat_Brow
        '
        Me.DSMat_Brow.DataSetName = "DSMat_Brow"
        Me.DSMat_Brow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_Rack_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Me.Tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_OutTableAdapter = Me.Tbl_Inv_Tran_OutTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSMat_BrowTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_OutTableAdapter
        '
        Me.Tbl_Inv_Tran_OutTableAdapter.ClearBeforeFill = True
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(94, 51)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DateNameLabel1.TabIndex = 16
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSMat_Brow
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.Location = New System.Drawing.Point(200, 55)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(45, 13)
        Me.DayNoLabel1.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.RackNoComboBox)
        Me.Panel1.Controls.Add(Me.TranDocNoLabel1)
        Me.Panel1.Controls.Add(Me.SupplierIDLabel1)
        Me.Panel1.Controls.Add(Me.L4NameComboBox)
        Me.Panel1.Controls.Add(Me.CPPULabel1)
        Me.Panel1.Controls.Add(Me.CurrencyLabel1)
        Me.Panel1.Controls.Add(Me.TranInIDLabel2)
        Me.Panel1.Controls.Add(Me.UOMLabel)
        Me.Panel1.Controls.Add(Me.UOMLabel1)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Controls.Add(SIDLabel)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.TranOutIDLabel1)
        Me.Panel1.Controls.Add(L4NameLabel)
        Me.Panel1.Controls.Add(TranInIDLabel)
        Me.Panel1.Location = New System.Drawing.Point(11, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 272)
        Me.Panel1.TabIndex = 14
        '
        'RackNoComboBox
        '
        Me.RackNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RackNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.RackNoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "RackId", True))
        Me.RackNoComboBox.DataSource = Me.Tbl_Inv_Rack_InfoBindingSource
        Me.RackNoComboBox.DisplayMember = "RackNo"
        Me.RackNoComboBox.FormattingEnabled = True
        Me.RackNoComboBox.Location = New System.Drawing.Point(88, 82)
        Me.RackNoComboBox.Name = "RackNoComboBox"
        Me.RackNoComboBox.Size = New System.Drawing.Size(258, 21)
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
        Me.Tbl_Inv_Rack_InfoBindingSource.DataSource = Me.DSMat_Brow
        '
        'TranDocNoLabel1
        '
        Me.TranDocNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranDocNo", True))
        Me.TranDocNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TranDocNoLabel1.Location = New System.Drawing.Point(194, 136)
        Me.TranDocNoLabel1.Name = "TranDocNoLabel1"
        Me.TranDocNoLabel1.Size = New System.Drawing.Size(68, 16)
        Me.TranDocNoLabel1.TabIndex = 42
        '
        'SupplierIDLabel1
        '
        Me.SupplierIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "SupplierID", True))
        Me.SupplierIDLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SupplierIDLabel1.Location = New System.Drawing.Point(207, 96)
        Me.SupplierIDLabel1.Name = "SupplierIDLabel1"
        Me.SupplierIDLabel1.Size = New System.Drawing.Size(100, 10)
        Me.SupplierIDLabel1.TabIndex = 41
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_OutBindingSource, "Code", True))
        Me.L4NameComboBox.DataSource = Me.View_Browed_MatBindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(88, 57)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(258, 21)
        Me.L4NameComboBox.TabIndex = 40
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'View_Browed_MatBindingSource
        '
        Me.View_Browed_MatBindingSource.DataMember = "View_Browed_Mat"
        Me.View_Browed_MatBindingSource.DataSource = Me.DSMat_Brow
        '
        'CPPULabel1
        '
        Me.CPPULabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "PPU", True))
        Me.CPPULabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.Location = New System.Drawing.Point(198, 111)
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
        Me.CurrencyLabel1.Location = New System.Drawing.Point(198, 137)
        Me.CurrencyLabel1.Name = "CurrencyLabel1"
        Me.CurrencyLabel1.Size = New System.Drawing.Size(100, 20)
        Me.CurrencyLabel1.TabIndex = 38
        Me.CurrencyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TranInIDLabel2
        '
        Me.TranInIDLabel2.BackColor = System.Drawing.Color.White
        Me.TranInIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TranInIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranInID", True))
        Me.TranInIDLabel2.Location = New System.Drawing.Point(88, 107)
        Me.TranInIDLabel2.Name = "TranInIDLabel2"
        Me.TranInIDLabel2.Size = New System.Drawing.Size(100, 20)
        Me.TranInIDLabel2.TabIndex = 35
        Me.TranInIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UOMLabel
        '
        Me.UOMLabel.Location = New System.Drawing.Point(5, 156)
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
        Me.UOMLabel1.Location = New System.Drawing.Point(88, 156)
        Me.UOMLabel1.Name = "UOMLabel1"
        Me.UOMLabel1.Size = New System.Drawing.Size(100, 20)
        Me.UOMLabel1.TabIndex = 33
        Me.UOMLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(88, 132)
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
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AddOut, Me.toolStripSeparator, Me.DeleteOut, Me.SaveOut, Me.toolStripSeparator3, Me.UndoOut})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(367, 25)
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
        'AddOut
        '
        Me.AddOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddOut.Image = CType(resources.GetObject("AddOut.Image"), System.Drawing.Image)
        Me.AddOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddOut.Name = "AddOut"
        Me.AddOut.Size = New System.Drawing.Size(23, 22)
        Me.AddOut.Text = "Add new"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteOut
        '
        Me.DeleteOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteOut.Image = CType(resources.GetObject("DeleteOut.Image"), System.Drawing.Image)
        Me.DeleteOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteOut.Name = "DeleteOut"
        Me.DeleteOut.Size = New System.Drawing.Size(23, 22)
        Me.DeleteOut.Text = "Delete"
        '
        'SaveOut
        '
        Me.SaveOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveOut.Image = CType(resources.GetObject("SaveOut.Image"), System.Drawing.Image)
        Me.SaveOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveOut.Name = "SaveOut"
        Me.SaveOut.Size = New System.Drawing.Size(23, 22)
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'UndoOut
        '
        Me.UndoOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoOut.Image = CType(resources.GetObject("UndoOut.Image"), System.Drawing.Image)
        Me.UndoOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoOut.Name = "UndoOut"
        Me.UndoOut.Size = New System.Drawing.Size(23, 22)
        Me.UndoOut.Text = "Undo"
        '
        'TranOutIDLabel1
        '
        Me.TranOutIDLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TranOutIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TranOutIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_OutBindingSource, "TranOutID", True))
        Me.TranOutIDLabel1.Location = New System.Drawing.Point(88, 33)
        Me.TranOutIDLabel1.Name = "TranOutIDLabel1"
        Me.TranOutIDLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TranOutIDLabel1.TabIndex = 26
        Me.TranOutIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CompanyName"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TranInID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tran No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Currency"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PPU"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PPU"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'ReceivedQty
        '
        Me.ReceivedQty.DataPropertyName = "ReceivedQty"
        Me.ReceivedQty.HeaderText = "Received Qty"
        Me.ReceivedQty.Name = "ReceivedQty"
        Me.ReceivedQty.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UOM"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'CompanyName
        '
        Me.CompanyName.DataPropertyName = "CompanyName"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CompanyName.DefaultCellStyle = DataGridViewCellStyle4
        Me.CompanyName.HeaderText = "Customer Name"
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.Width = 200
        '
        'TranInID
        '
        Me.TranInID.DataPropertyName = "TranInID"
        Me.TranInID.HeaderText = "Tran No"
        Me.TranInID.Name = "TranInID"
        Me.TranInID.Width = 80
        '
        'Currency
        '
        Me.Currency.DataPropertyName = "Currency"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Currency.DefaultCellStyle = DataGridViewCellStyle5
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Name = "Currency"
        Me.Currency.Width = 60
        '
        'PPU
        '
        Me.PPU.DataPropertyName = "PPU"
        Me.PPU.HeaderText = "PPU"
        Me.PPU.Name = "PPU"
        '
        'UOM
        '
        Me.UOM.DataPropertyName = "UOM"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UOM.DefaultCellStyle = DataGridViewCellStyle6
        Me.UOM.HeaderText = "UOM"
        Me.UOM.Name = "UOM"
        Me.UOM.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ReceivedQty"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.HeaderText = "Received Qty"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'View_BrowedMat_DBindingSource
        '
        Me.View_BrowedMat_DBindingSource.DataMember = "View_BrowedMat_D"
        Me.View_BrowedMat_DBindingSource.DataSource = Me.DSMat_Brow
        '
        'View_BrowedMat_DTableAdapter
        '
        Me.View_BrowedMat_DTableAdapter.ClearBeforeFill = True
        '
        'View_BrowedMat_DDataGridView
        '
        Me.View_BrowedMat_DDataGridView.AllowUserToAddRows = False
        Me.View_BrowedMat_DDataGridView.AllowUserToDeleteRows = False
        Me.View_BrowedMat_DDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_BrowedMat_DDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.View_BrowedMat_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_BrowedMat_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn18, Me.Balance, Me.SupplierID})
        Me.View_BrowedMat_DDataGridView.DataSource = Me.View_BrowedMat_DBindingSource
        Me.View_BrowedMat_DDataGridView.Location = New System.Drawing.Point(383, 76)
        Me.View_BrowedMat_DDataGridView.Name = "View_BrowedMat_DDataGridView"
        Me.View_BrowedMat_DDataGridView.Size = New System.Drawing.Size(625, 272)
        Me.View_BrowedMat_DDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CompanyName"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn7.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TranInID"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tran In No."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 65
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Currency"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn12.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 65
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ReceivedQty"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn17.HeaderText = "Received Qty"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 65
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PPU"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn13.HeaderText = "PPU"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 65
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "UOM"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn14.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 65
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "IssuedQty"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn18.HeaderText = "Issued Qty"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 65
        '
        'Balance
        '
        Me.Balance.DataPropertyName = "Balance"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Balance.DefaultCellStyle = DataGridViewCellStyle16
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        Me.Balance.Width = 85
        '
        'SupplierID
        '
        Me.SupplierID.DataPropertyName = "SupplierID"
        Me.SupplierID.HeaderText = "SupplierID"
        Me.SupplierID.Name = "SupplierID"
        Me.SupplierID.Visible = False
        '
        'View_Browed_MatTableAdapter
        '
        Me.View_Browed_MatTableAdapter.ClearBeforeFill = True
        '
        'btnGatePass
        '
        Me.btnGatePass.Location = New System.Drawing.Point(387, 48)
        Me.btnGatePass.Name = "btnGatePass"
        Me.btnGatePass.Size = New System.Drawing.Size(105, 23)
        Me.btnGatePass.TabIndex = 26
        Me.btnGatePass.Text = "Gate Pass"
        Me.btnGatePass.UseVisualStyleBackColor = True
        '
        'View_Inv_Mat_AvailableBindingSource
        '
        Me.View_Inv_Mat_AvailableBindingSource.DataMember = "View_Inv_Mat_Available"
        Me.View_Inv_Mat_AvailableBindingSource.DataSource = Me.DSMat_Brow
        '
        'View_Inv_Mat_AvailableTableAdapter
        '
        Me.View_Inv_Mat_AvailableTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Rack_InfoTableAdapter
        '
        Me.Tbl_Inv_Rack_InfoTableAdapter.ClearBeforeFill = True
        '
        'frmMatBorrowedIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1523, 423)
        Me.Controls.Add(Me.btnGatePass)
        Me.Controls.Add(Me.View_BrowedMat_DDataGridView)
        Me.Controls.Add(DateNameLabel)
        Me.Controls.Add(Me.DateNameLabel1)
        Me.Controls.Add(Me.DayNoLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMatBorrowedIssued"
        Me.Text = "Borrowed Material Issuence"
        CType(Me.DSMat_Brow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_Tran_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Browed_MatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_BrowedMat_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_BrowedMat_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Inv_Mat_AvailableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSMat_Brow As FS_ERP_MM.DSMat_Brow
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSMat_BrowTableAdapters.TableAdapterManager
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CPPULabel1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents TranInIDLabel2 As System.Windows.Forms.Label
    Friend WithEvents UOMLabel As System.Windows.Forms.Label
    Friend WithEvents UOMLabel1 As System.Windows.Forms.Label
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents AddOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents TranOutIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_OutTableAdapter As FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Tran_OutTableAdapter
    Friend WithEvents Tbl_Inv_Tran_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceivedQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TranInID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Currency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PPU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents View_BrowedMat_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_BrowedMat_DTableAdapter As FS_ERP_MM.DSMat_BrowTableAdapters.View_BrowedMat_DTableAdapter
    Friend WithEvents View_BrowedMat_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents View_Browed_MatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Browed_MatTableAdapter As FS_ERP_MM.DSMat_BrowTableAdapters.View_Browed_MatTableAdapter
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents btnGatePass As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TranDocNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Inv_Mat_AvailableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Inv_Mat_AvailableTableAdapter As FS_ERP_MM.DSMat_BrowTableAdapters.View_Inv_Mat_AvailableTableAdapter
    Friend WithEvents Tbl_Inv_Rack_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Rack_InfoTableAdapter As FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Rack_InfoTableAdapter
    Friend WithEvents RackNoComboBox As System.Windows.Forms.ComboBox
End Class
