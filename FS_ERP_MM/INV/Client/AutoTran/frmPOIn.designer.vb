<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOIn
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
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim POIDLabel As System.Windows.Forms.Label
        Dim PODNoLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim MRINLabel As System.Windows.Forms.Label
        Dim RackNoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOIn))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Formula1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Tran_InBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPOR = New FS_ERP_MM.DSPOR()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TranInIDTextBox = New System.Windows.Forms.TextBox()
        Me.RackNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Rack_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LWACLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.View_PO_PandingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CPPULabel1 = New System.Windows.Forms.Label()
        Me.MRINTextBox = New System.Windows.Forms.TextBox()
        Me.CurrencyLabel1 = New System.Windows.Forms.Label()
        Me.SupplierIDLabel1 = New System.Windows.Forms.Label()
        Me.PODNoLabel2 = New System.Windows.Forms.Label()
        Me.POIDLabel2 = New System.Windows.Forms.Label()
        Me.PPULabel2 = New System.Windows.Forms.Label()
        Me.UOMLabel = New System.Windows.Forms.Label()
        Me.UOMLabel1 = New System.Windows.Forms.Label()
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
        Me.AddPOs = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DeletePOs = New System.Windows.Forms.ToolStripButton()
        Me.SavePOs = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoPOs = New System.Windows.Forms.ToolStripButton()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.Proc_MM_Inv_BalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSPORTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSPORTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSPORTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_Inv_Tran_InTableAdapter = New FS_ERP_MM.DSPORTableAdapters.tbl_Inv_Tran_InTableAdapter()
        Me.Tbl_Pur_PO_DTableAdapter = New FS_ERP_MM.DSPORTableAdapters.tbl_Pur_PO_DTableAdapter()
        Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter = New FS_ERP_MM.DSPORTableAdapters.tbl_Pur_UnitofMeasurementDtlTableAdapter()
        Me.Tbl_Pur_PO_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnMRIN = New System.Windows.Forms.Button()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.View_PO_PandingTableAdapter = New FS_ERP_MM.DSPORTableAdapters.View_PO_PandingTableAdapter()
        Me.View_PO_DTableAdapter = New FS_ERP_MM.DSPORTableAdapters.View_PO_DTableAdapter()
        Me.View_PO_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_PO_DDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tbl_Pur_UnitofMeasurementDtlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Proc_MM_Inv_BalTableAdapter = New FS_ERP_MM.DSPORTableAdapters.Proc_MM_Inv_BalTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DateNameMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CMSTranDate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMtxtTranDate = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Rack_InfoTableAdapter = New FS_ERP_MM.DSPORTableAdapters.tbl_Inv_Rack_InfoTableAdapter()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherCharges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Formula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DateNameLabel = New System.Windows.Forms.Label()
        TranInIDLabel = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        POIDLabel = New System.Windows.Forms.Label()
        PODNoLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        MRINLabel = New System.Windows.Forms.Label()
        RackNoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_PO_PandingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Proc_MM_Inv_BalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_PO_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_PO_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_PO_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitofMeasurementDtlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.CMSTranDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(3, 35)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(79, 20)
        DateNameLabel.TabIndex = 5
        DateNameLabel.Text = "Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranInIDLabel
        '
        TranInIDLabel.Location = New System.Drawing.Point(8, 31)
        TranInIDLabel.Name = "TranInIDLabel"
        TranInIDLabel.Size = New System.Drawing.Size(78, 20)
        TranInIDLabel.TabIndex = 0
        TranInIDLabel.Text = "S. No.:"
        TranInIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameLabel
        '
        L4NameLabel.Location = New System.Drawing.Point(8, 57)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(78, 20)
        L4NameLabel.TabIndex = 2
        L4NameLabel.Text = "Material:"
        L4NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POIDLabel
        '
        POIDLabel.Location = New System.Drawing.Point(8, 105)
        POIDLabel.Name = "POIDLabel"
        POIDLabel.Size = New System.Drawing.Size(78, 20)
        POIDLabel.TabIndex = 4
        POIDLabel.Text = "PO No.:"
        POIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PODNoLabel
        '
        PODNoLabel.Location = New System.Drawing.Point(8, 128)
        PODNoLabel.Name = "PODNoLabel"
        PODNoLabel.Size = New System.Drawing.Size(78, 20)
        PODNoLabel.TabIndex = 6
        PODNoLabel.Text = "PO Item No.:"
        PODNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QtyLabel
        '
        QtyLabel.Location = New System.Drawing.Point(8, 152)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(78, 20)
        QtyLabel.TabIndex = 10
        QtyLabel.Text = "Qty:"
        QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MRINLabel
        '
        MRINLabel.Location = New System.Drawing.Point(194, 31)
        MRINLabel.Name = "MRINLabel"
        MRINLabel.Size = New System.Drawing.Size(54, 20)
        MRINLabel.TabIndex = 21
        MRINLabel.Text = "MRIN:"
        MRINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RackNoLabel
        '
        RackNoLabel.Location = New System.Drawing.Point(8, 82)
        RackNoLabel.Name = "RackNoLabel"
        RackNoLabel.Size = New System.Drawing.Size(78, 20)
        RackNoLabel.TabIndex = 27
        RackNoLabel.Text = "Rack No:"
        RackNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(8, 175)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(78, 20)
        Label3.TabIndex = 30
        Label3.Text = "Description:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1205, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Order Receiving"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Formula1)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(RackNoLabel)
        Me.Panel1.Controls.Add(Me.TranInIDTextBox)
        Me.Panel1.Controls.Add(Me.RackNoComboBox)
        Me.Panel1.Controls.Add(Me.LWACLabel1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.L4NameComboBox)
        Me.Panel1.Controls.Add(Me.CPPULabel1)
        Me.Panel1.Controls.Add(MRINLabel)
        Me.Panel1.Controls.Add(Me.MRINTextBox)
        Me.Panel1.Controls.Add(Me.CurrencyLabel1)
        Me.Panel1.Controls.Add(Me.SupplierIDLabel1)
        Me.Panel1.Controls.Add(Me.PODNoLabel2)
        Me.Panel1.Controls.Add(Me.POIDLabel2)
        Me.Panel1.Controls.Add(Me.PPULabel2)
        Me.Panel1.Controls.Add(Me.UOMLabel)
        Me.Panel1.Controls.Add(Me.UOMLabel1)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Controls.Add(PODNoLabel)
        Me.Panel1.Controls.Add(POIDLabel)
        Me.Panel1.Controls.Add(L4NameLabel)
        Me.Panel1.Controls.Add(TranInIDLabel)
        Me.Panel1.Location = New System.Drawing.Point(7, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 276)
        Me.Panel1.TabIndex = 1
        '
        'Formula1
        '
        Me.Formula1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Formula", True))
        Me.Formula1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Formula1.Location = New System.Drawing.Point(219, 221)
        Me.Formula1.Name = "Formula1"
        Me.Formula1.Size = New System.Drawing.Size(100, 20)
        Me.Formula1.TabIndex = 31
        '
        'Tbl_Inv_Tran_InBindingSource
        '
        Me.Tbl_Inv_Tran_InBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Inv_Tran_In"
        Me.Tbl_Inv_Tran_InBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSPOR
        '
        'DSPOR
        '
        Me.DSPOR.DataSetName = "DSPOR"
        Me.DSPOR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Narration", True))
        Me.TextBox1.Location = New System.Drawing.Point(87, 175)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(262, 20)
        Me.TextBox1.TabIndex = 29
        '
        'TranInIDTextBox
        '
        Me.TranInIDTextBox.BackColor = System.Drawing.Color.White
        Me.TranInIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "TranInID", True))
        Me.TranInIDTextBox.Location = New System.Drawing.Point(87, 31)
        Me.TranInIDTextBox.Name = "TranInIDTextBox"
        Me.TranInIDTextBox.ReadOnly = True
        Me.TranInIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TranInIDTextBox.TabIndex = 11
        Me.TranInIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RackNoComboBox
        '
        Me.RackNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RackNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.RackNoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_InBindingSource, "RackId", True))
        Me.RackNoComboBox.DataSource = Me.Tbl_Inv_Rack_InfoBindingSource
        Me.RackNoComboBox.DisplayMember = "RackNo"
        Me.RackNoComboBox.FormattingEnabled = True
        Me.RackNoComboBox.Location = New System.Drawing.Point(87, 81)
        Me.RackNoComboBox.Name = "RackNoComboBox"
        Me.RackNoComboBox.Size = New System.Drawing.Size(262, 21)
        Me.RackNoComboBox.TabIndex = 28
        Me.RackNoComboBox.ValueMember = "RackId"
        '
        'Tbl_Inv_Rack_InfoBindingSource
        '
        Me.Tbl_Inv_Rack_InfoBindingSource.DataMember = "tbl_Inv_Rack_Info"
        Me.Tbl_Inv_Rack_InfoBindingSource.DataSource = Me.DSPOR
        '
        'LWACLabel1
        '
        Me.LWACLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "LWAC", True))
        Me.LWACLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LWACLabel1.Location = New System.Drawing.Point(36, 245)
        Me.LWACLabel1.Name = "LWACLabel1"
        Me.LWACLabel1.Size = New System.Drawing.Size(14, 20)
        Me.LWACLabel1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(194, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Currency:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_InBindingSource, "Code", True))
        Me.L4NameComboBox.DataSource = Me.View_PO_PandingBindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(87, 56)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(265, 21)
        Me.L4NameComboBox.TabIndex = 24
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'View_PO_PandingBindingSource
        '
        Me.View_PO_PandingBindingSource.DataMember = "View_PO_Panding"
        Me.View_PO_PandingBindingSource.DataSource = Me.DSPOR
        '
        'CPPULabel1
        '
        Me.CPPULabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_PO_PandingBindingSource, "CPPU", True))
        Me.CPPULabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.Location = New System.Drawing.Point(173, 235)
        Me.CPPULabel1.Name = "CPPULabel1"
        Me.CPPULabel1.Size = New System.Drawing.Size(14, 20)
        Me.CPPULabel1.TabIndex = 23
        Me.CPPULabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MRINTextBox
        '
        Me.MRINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "MRIN", True))
        Me.MRINTextBox.Location = New System.Drawing.Point(252, 31)
        Me.MRINTextBox.Name = "MRINTextBox"
        Me.MRINTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRINTextBox.TabIndex = 0
        Me.MRINTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CurrencyLabel1
        '
        Me.CurrencyLabel1.BackColor = System.Drawing.Color.White
        Me.CurrencyLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrencyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Currency", True))
        Me.CurrencyLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurrencyLabel1.Location = New System.Drawing.Point(254, 128)
        Me.CurrencyLabel1.Name = "CurrencyLabel1"
        Me.CurrencyLabel1.Size = New System.Drawing.Size(95, 20)
        Me.CurrencyLabel1.TabIndex = 21
        Me.CurrencyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SupplierIDLabel1
        '
        Me.SupplierIDLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SupplierIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "SupplierID", True))
        Me.SupplierIDLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SupplierIDLabel1.Location = New System.Drawing.Point(232, 241)
        Me.SupplierIDLabel1.Name = "SupplierIDLabel1"
        Me.SupplierIDLabel1.Size = New System.Drawing.Size(16, 20)
        Me.SupplierIDLabel1.TabIndex = 20
        Me.SupplierIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PODNoLabel2
        '
        Me.PODNoLabel2.BackColor = System.Drawing.Color.White
        Me.PODNoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PODNoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "PODNo", True))
        Me.PODNoLabel2.Location = New System.Drawing.Point(87, 128)
        Me.PODNoLabel2.Name = "PODNoLabel2"
        Me.PODNoLabel2.Size = New System.Drawing.Size(100, 20)
        Me.PODNoLabel2.TabIndex = 17
        Me.PODNoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'POIDLabel2
        '
        Me.POIDLabel2.BackColor = System.Drawing.Color.White
        Me.POIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "POID", True))
        Me.POIDLabel2.Location = New System.Drawing.Point(87, 105)
        Me.POIDLabel2.Name = "POIDLabel2"
        Me.POIDLabel2.Size = New System.Drawing.Size(100, 20)
        Me.POIDLabel2.TabIndex = 16
        Me.POIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PPULabel2
        '
        Me.PPULabel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PPULabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "PPU", True))
        Me.PPULabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PPULabel2.Location = New System.Drawing.Point(89, 245)
        Me.PPULabel2.Name = "PPULabel2"
        Me.PPULabel2.Size = New System.Drawing.Size(10, 10)
        Me.PPULabel2.TabIndex = 15
        Me.PPULabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UOMLabel
        '
        Me.UOMLabel.Location = New System.Drawing.Point(193, 105)
        Me.UOMLabel.Name = "UOMLabel"
        Me.UOMLabel.Size = New System.Drawing.Size(54, 20)
        Me.UOMLabel.TabIndex = 13
        Me.UOMLabel.Text = "UOM:"
        Me.UOMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UOMLabel1
        '
        Me.UOMLabel1.BackColor = System.Drawing.Color.White
        Me.UOMLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UOMLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "UOM", True))
        Me.UOMLabel1.Location = New System.Drawing.Point(254, 105)
        Me.UOMLabel1.Name = "UOMLabel1"
        Me.UOMLabel1.Size = New System.Drawing.Size(95, 20)
        Me.UOMLabel1.TabIndex = 14
        Me.UOMLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_Tran_InBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AddPOs, Me.toolStripSeparator, Me.DeletePOs, Me.SavePOs, Me.toolStripSeparator3, Me.UndoPOs})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(376, 25)
        Me.BindingNavigator1.TabIndex = 12
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'AddPOs
        '
        Me.AddPOs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddPOs.Image = CType(resources.GetObject("AddPOs.Image"), System.Drawing.Image)
        Me.AddPOs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddPOs.Name = "AddPOs"
        Me.AddPOs.Size = New System.Drawing.Size(23, 22)
        Me.AddPOs.Text = "Add new"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'DeletePOs
        '
        Me.DeletePOs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeletePOs.Image = CType(resources.GetObject("DeletePOs.Image"), System.Drawing.Image)
        Me.DeletePOs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeletePOs.Name = "DeletePOs"
        Me.DeletePOs.Size = New System.Drawing.Size(23, 22)
        Me.DeletePOs.Text = "Delete"
        '
        'SavePOs
        '
        Me.SavePOs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SavePOs.Image = CType(resources.GetObject("SavePOs.Image"), System.Drawing.Image)
        Me.SavePOs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePOs.Name = "SavePOs"
        Me.SavePOs.Size = New System.Drawing.Size(23, 22)
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'UndoPOs
        '
        Me.UndoPOs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoPOs.Image = CType(resources.GetObject("UndoPOs.Image"), System.Drawing.Image)
        Me.UndoPOs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoPOs.Name = "UndoPOs"
        Me.UndoPOs.Size = New System.Drawing.Size(23, 22)
        Me.UndoPOs.Text = "Undo"
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(87, 152)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTextBox.TabIndex = 2
        Me.QtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Proc_MM_Inv_BalBindingSource
        '
        Me.Proc_MM_Inv_BalBindingSource.DataMember = "View_PO_Panding_Proc_MM_Inv_Bal"
        Me.Proc_MM_Inv_BalBindingSource.DataSource = Me.View_PO_PandingBindingSource
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSPOR
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager.tbl_Inv_Rack_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Me.Tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_InTableAdapter = Me.Tbl_Inv_Tran_InTableAdapter
        Me.TableAdapterManager.tbl_Pur_PO_DTableAdapter = Me.Tbl_Pur_PO_DTableAdapter
        Me.TableAdapterManager.tbl_Pur_UnitofMeasurementDtlTableAdapter = Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSPORTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_InTableAdapter
        '
        Me.Tbl_Inv_Tran_InTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_PO_DTableAdapter
        '
        Me.Tbl_Pur_PO_DTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Pur_UnitofMeasurementDtlTableAdapter
        '
        Me.Tbl_Pur_UnitofMeasurementDtlTableAdapter.ClearBeforeFill = True
        '
        'btnMRIN
        '
        Me.btnMRIN.Location = New System.Drawing.Point(387, 66)
        Me.btnMRIN.Name = "btnMRIN"
        Me.btnMRIN.Size = New System.Drawing.Size(94, 33)
        Me.btnMRIN.TabIndex = 7
        Me.btnMRIN.Text = "Show MRIN"
        Me.btnMRIN.UseVisualStyleBackColor = True
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.Location = New System.Drawing.Point(194, 35)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(30, 20)
        Me.DayNoLabel1.TabIndex = 8
        Me.DayNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_PO_PandingTableAdapter
        '
        Me.View_PO_PandingTableAdapter.ClearBeforeFill = True
        '
        'View_PO_DTableAdapter
        '
        Me.View_PO_DTableAdapter.ClearBeforeFill = True
        '
        'View_PO_DBindingSource
        '
        Me.View_PO_DBindingSource.DataMember = "View_PO_D"
        Me.View_PO_DBindingSource.DataSource = Me.DSPOR
        '
        'View_PO_DDataGridView
        '
        Me.View_PO_DDataGridView.AllowUserToAddRows = False
        Me.View_PO_DDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.View_PO_DDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.View_PO_DDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_PO_DDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.View_PO_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_PO_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn21, Me.OtherCharges, Me.Formula})
        Me.View_PO_DDataGridView.DataSource = Me.View_PO_DBindingSource
        Me.View_PO_DDataGridView.Location = New System.Drawing.Point(387, 115)
        Me.View_PO_DDataGridView.Name = "View_PO_DDataGridView"
        Me.View_PO_DDataGridView.ReadOnly = True
        Me.View_PO_DDataGridView.Size = New System.Drawing.Size(625, 276)
        Me.View_PO_DDataGridView.TabIndex = 8
        '
        'Tbl_Pur_UnitofMeasurementDtlBindingSource
        '
        Me.Tbl_Pur_UnitofMeasurementDtlBindingSource.DataMember = "tbl_Pur_UnitofMeasurementDtl"
        Me.Tbl_Pur_UnitofMeasurementDtlBindingSource.DataSource = Me.DSPOR
        '
        'Proc_MM_Inv_BalTableAdapter
        '
        Me.Proc_MM_Inv_BalTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator2)
        Me.Panel2.Controls.Add(Me.DateNameMaskedTextBox)
        Me.Panel2.Controls.Add(DateNameLabel)
        Me.Panel2.Controls.Add(Me.DayNoLabel1)
        Me.Panel2.Location = New System.Drawing.Point(7, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(316, 68)
        Me.Panel2.TabIndex = 9
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator2.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator2.Size = New System.Drawing.Size(314, 25)
        Me.BindingNavigator2.TabIndex = 9
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
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
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.SaveToolStripButton.Visible = False
        '
        'DateNameMaskedTextBox
        '
        Me.DateNameMaskedTextBox.ContextMenuStrip = Me.CMSTranDate
        Me.DateNameMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameMaskedTextBox.Location = New System.Drawing.Point(88, 35)
        Me.DateNameMaskedTextBox.Mask = "00/00/0000"
        Me.DateNameMaskedTextBox.Name = "DateNameMaskedTextBox"
        Me.DateNameMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DateNameMaskedTextBox.TabIndex = 10
        Me.DateNameMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMSTranDate
        '
        Me.CMSTranDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMtxtTranDate, Me.ToolStripMenuItem2})
        Me.CMSTranDate.Name = "SupplierContextMenuStrip"
        Me.CMSTranDate.Size = New System.Drawing.Size(161, 51)
        '
        'CMtxtTranDate
        '
        Me.CMtxtTranDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CMtxtTranDate.ForeColor = System.Drawing.Color.Silver
        Me.CMtxtTranDate.Name = "CMtxtTranDate"
        Me.CMtxtTranDate.Size = New System.Drawing.Size(100, 23)
        Me.CMtxtTranDate.Text = "Enter First Date"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem2.Text = "Remove &Filter"
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DateNameLabel1.Location = New System.Drawing.Point(574, 66)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(62, 10)
        Me.DateNameLabel1.TabIndex = 10
        '
        'Tbl_Inv_Rack_InfoTableAdapter
        '
        Me.Tbl_Inv_Rack_InfoTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "CompanyName"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn16.HeaderText = "Suppliers"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 200
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "POID"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn12.HeaderText = "PO No."
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PODNo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PODNo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "SupplierID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "SupplierID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SupplierCodeID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "SupplierCodeID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PODate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "dd/MM/yy"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn22.HeaderText = "Order Date"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 60
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ReqDate"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "dd/MM/yy"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn23.HeaderText = "Req Date"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 60
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "POQty"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn17.HeaderText = "PO Qty"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Curency"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Curency"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn19.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "UOM"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn20.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 60
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Balance"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn28.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn28.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 60
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "CompStat"
        Me.DataGridViewTextBoxColumn24.HeaderText = "CompStat"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Received"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Received"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'OtherCharges
        '
        Me.OtherCharges.DataPropertyName = "OtherCharges"
        Me.OtherCharges.HeaderText = "OtherCharge"
        Me.OtherCharges.Name = "OtherCharges"
        Me.OtherCharges.ReadOnly = True
        Me.OtherCharges.Visible = False
        '
        'Formula
        '
        Me.Formula.DataPropertyName = "Formula"
        Me.Formula.HeaderText = "Formula"
        Me.Formula.Name = "Formula"
        Me.Formula.ReadOnly = True
        Me.Formula.Visible = False
        '
        'frmPOIn
        '
        Me.AcceptButton = Me.btnMRIN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1205, 560)
        Me.Controls.Add(Me.DateNameLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.View_PO_DDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMRIN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPOIn"
        Me.Text = "Purchase Order Receiving"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_PO_PandingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Proc_MM_Inv_BalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_PO_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_PO_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_PO_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitofMeasurementDtlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.CMSTranDate.ResumeLayout(False)
        Me.CMSTranDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DSPOR As FS_ERP_MM.DSPOR
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSPORTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSPORTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Inv_Tran_InTableAdapter As FS_ERP_MM.DSPORTableAdapters.tbl_Inv_Tran_InTableAdapter
    Friend WithEvents Tbl_Inv_Tran_InBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UOMLabel As System.Windows.Forms.Label
    Friend WithEvents UOMLabel1 As System.Windows.Forms.Label
    Friend WithEvents PPULabel2 As System.Windows.Forms.Label
    Friend WithEvents PODNoLabel2 As System.Windows.Forms.Label
    Friend WithEvents POIDLabel2 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Pur_PO_DTableAdapter As FS_ERP_MM.DSPORTableAdapters.tbl_Pur_PO_DTableAdapter
    Friend WithEvents Tbl_Pur_PO_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnMRIN As System.Windows.Forms.Button
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents SupplierIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents MRINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents View_PO_PandingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_PO_PandingTableAdapter As FS_ERP_MM.DSPORTableAdapters.View_PO_PandingTableAdapter
    Friend WithEvents SavePOs As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddPOs As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeletePOs As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoPOs As System.Windows.Forms.ToolStripButton
    Friend WithEvents View_PO_DTableAdapter As FS_ERP_MM.DSPORTableAdapters.View_PO_DTableAdapter
    Friend WithEvents CPPULabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSPORTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents View_PO_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_PO_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Pur_UnitofMeasurementDtlTableAdapter As FS_ERP_MM.DSPORTableAdapters.tbl_Pur_UnitofMeasurementDtlTableAdapter
    Friend WithEvents Tbl_Pur_UnitofMeasurementDtlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Proc_MM_Inv_BalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Proc_MM_Inv_BalTableAdapter As FS_ERP_MM.DSPORTableAdapters.Proc_MM_Inv_BalTableAdapter
    Friend WithEvents LWACLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DateNameMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_Rack_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Rack_InfoTableAdapter As FS_ERP_MM.DSPORTableAdapters.tbl_Inv_Rack_InfoTableAdapter
    Friend WithEvents RackNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TranInIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CMSTranDate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMtxtTranDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Formula1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents OtherCharges As DataGridViewTextBoxColumn
    Friend WithEvents Formula As DataGridViewTextBoxColumn
End Class
