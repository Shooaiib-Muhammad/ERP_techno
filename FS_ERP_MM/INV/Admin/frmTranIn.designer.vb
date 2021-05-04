<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTranIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TranInIDLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim ManfDateLabel As System.Windows.Forms.Label
        Dim ExpiryDateLabel As System.Windows.Forms.Label
        Dim NarrationLabel As System.Windows.Forms.Label
        Dim L1NameLabel As System.Windows.Forms.Label
        Dim L2NameLabel As System.Windows.Forms.Label
        Dim L3NameLabel As System.Windows.Forms.Label
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim DayNoLabel As System.Windows.Forms.Label
        Dim PPULabel As System.Windows.Forms.Label
        Dim TotalInLabel As System.Windows.Forms.Label
        Dim TotalOutLabel As System.Windows.Forms.Label
        Dim ActQtyLabel As System.Windows.Forms.Label
        Dim CPPULabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim TranTypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTranIn))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSTranIn = New FS_ERP_MM.DSTranIn()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.CMSDate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMtxtDate = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TranTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_Tran_InBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrencyTextBox = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.NarrationTextBox = New System.Windows.Forms.TextBox()
        Me.PPUTextBox = New System.Windows.Forms.TextBox()
        Me.ExpiryDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ManfDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.TranInIDLabel2 = New System.Windows.Forms.Label()
        Me.CompanyNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSTranInCodeLayer = New FS_ERP_MM.DSTranInCodeLayer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.L3NameComboBox = New System.Windows.Forms.ComboBox()
        Me.L2NameComboBox = New System.Windows.Forms.ComboBox()
        Me.L1NameComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SaveIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L1TableAdapter = New FS_ERP_MM.DSTranInCodeLayerTableAdapters.tbl_Inv_L1TableAdapter()
        Me.Tbl_Inv_L2TableAdapter = New FS_ERP_MM.DSTranInCodeLayerTableAdapters.tbl_Inv_L2TableAdapter()
        Me.Tbl_Inv_L3TableAdapter = New FS_ERP_MM.DSTranInCodeLayerTableAdapters.tbl_Inv_L3TableAdapter()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSTranInCodeLayerTableAdapters.tbl_Inv_L4TableAdapter()
        Me.TotalInLabel1 = New System.Windows.Forms.Label()
        Me.View_Inv_TotalInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalOutLabel1 = New System.Windows.Forms.Label()
        Me.View_Inv_TotalOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBal = New System.Windows.Forms.Label()
        Me.ActQtyLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_L4BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSTranInTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSTranInTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.Tbl_Inv_Tran_InTableAdapter = New FS_ERP_MM.DSTranInTableAdapters.tbl_Inv_Tran_InTableAdapter()
        Me.View_Inv_TotalInTableAdapter = New FS_ERP_MM.DSTranInTableAdapters.View_Inv_TotalInTableAdapter()
        Me.View_Inv_TotalOutTableAdapter = New FS_ERP_MM.DSTranInTableAdapters.View_Inv_TotalOutTableAdapter()
        Me.Tbl_Inv_L4TableAdapter1 = New FS_ERP_MM.DSTranInTableAdapters.tbl_Inv_L4TableAdapter()
        Me.CPPULabel1 = New System.Windows.Forms.Label()
        Me.CPPULabel3 = New System.Windows.Forms.Label()
        Me.CurrencyLabel1 = New System.Windows.Forms.Label()
        TranInIDLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        ManfDateLabel = New System.Windows.Forms.Label()
        ExpiryDateLabel = New System.Windows.Forms.Label()
        NarrationLabel = New System.Windows.Forms.Label()
        L1NameLabel = New System.Windows.Forms.Label()
        L2NameLabel = New System.Windows.Forms.Label()
        L3NameLabel = New System.Windows.Forms.Label()
        DateNameLabel = New System.Windows.Forms.Label()
        DayNoLabel = New System.Windows.Forms.Label()
        PPULabel = New System.Windows.Forms.Label()
        TotalInLabel = New System.Windows.Forms.Label()
        TotalOutLabel = New System.Windows.Forms.Label()
        ActQtyLabel = New System.Windows.Forms.Label()
        CPPULabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        TranTypeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTranIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSDate.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTranInCodeLayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_Inv_TotalInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Inv_TotalOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TranInIDLabel
        '
        TranInIDLabel.Location = New System.Drawing.Point(43, 36)
        TranInIDLabel.Name = "TranInIDLabel"
        TranInIDLabel.Size = New System.Drawing.Size(95, 20)
        TranInIDLabel.TabIndex = 6
        TranInIDLabel.Text = "Serial No:"
        TranInIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Location = New System.Drawing.Point(353, 167)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(100, 21)
        SupplierIDLabel.TabIndex = 16
        SupplierIDLabel.Text = "Supplier:"
        SupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodeLabel
        '
        CodeLabel.Location = New System.Drawing.Point(18, 112)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(100, 21)
        CodeLabel.TabIndex = 18
        CodeLabel.Text = "Material:"
        CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QtyLabel
        '
        QtyLabel.Location = New System.Drawing.Point(353, 141)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(100, 20)
        QtyLabel.TabIndex = 20
        QtyLabel.Text = "Quantity:"
        QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ManfDateLabel
        '
        ManfDateLabel.Location = New System.Drawing.Point(353, 195)
        ManfDateLabel.Name = "ManfDateLabel"
        ManfDateLabel.Size = New System.Drawing.Size(100, 20)
        ManfDateLabel.TabIndex = 22
        ManfDateLabel.Text = "Manf Date:"
        ManfDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExpiryDateLabel
        '
        ExpiryDateLabel.Location = New System.Drawing.Point(353, 221)
        ExpiryDateLabel.Name = "ExpiryDateLabel"
        ExpiryDateLabel.Size = New System.Drawing.Size(100, 20)
        ExpiryDateLabel.TabIndex = 24
        ExpiryDateLabel.Text = "Expiry Date:"
        ExpiryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NarrationLabel
        '
        NarrationLabel.Location = New System.Drawing.Point(43, 254)
        NarrationLabel.Name = "NarrationLabel"
        NarrationLabel.Size = New System.Drawing.Size(100, 20)
        NarrationLabel.TabIndex = 26
        NarrationLabel.Text = "Narration:"
        NarrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L1NameLabel
        '
        L1NameLabel.Location = New System.Drawing.Point(18, 33)
        L1NameLabel.Name = "L1NameLabel"
        L1NameLabel.Size = New System.Drawing.Size(100, 21)
        L1NameLabel.TabIndex = 28
        L1NameLabel.Text = "L1 Name:"
        L1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L2NameLabel
        '
        L2NameLabel.Location = New System.Drawing.Point(18, 58)
        L2NameLabel.Name = "L2NameLabel"
        L2NameLabel.Size = New System.Drawing.Size(100, 21)
        L2NameLabel.TabIndex = 29
        L2NameLabel.Text = "L2 Name:"
        L2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L3NameLabel
        '
        L3NameLabel.Location = New System.Drawing.Point(18, 84)
        L3NameLabel.Name = "L3NameLabel"
        L3NameLabel.Size = New System.Drawing.Size(100, 21)
        L3NameLabel.TabIndex = 30
        L3NameLabel.Text = "L3 Name:"
        L3NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(361, 39)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(88, 20)
        DateNameLabel.TabIndex = 2
        DateNameLabel.Text = "Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DayNoLabel
        '
        DayNoLabel.Location = New System.Drawing.Point(69, 39)
        DayNoLabel.Name = "DayNoLabel"
        DayNoLabel.Size = New System.Drawing.Size(69, 20)
        DayNoLabel.TabIndex = 3
        DayNoLabel.Text = "Date No:"
        DayNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PPULabel
        '
        PPULabel.Location = New System.Drawing.Point(353, 116)
        PPULabel.Name = "PPULabel"
        PPULabel.Size = New System.Drawing.Size(100, 20)
        PPULabel.TabIndex = 9
        PPULabel.Text = "Price Per Unit:"
        PPULabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalInLabel
        '
        TotalInLabel.Location = New System.Drawing.Point(705, 129)
        TotalInLabel.Name = "TotalInLabel"
        TotalInLabel.Size = New System.Drawing.Size(60, 20)
        TotalInLabel.TabIndex = 10
        TotalInLabel.Text = "Total In:"
        TotalInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalOutLabel
        '
        TotalOutLabel.Location = New System.Drawing.Point(705, 153)
        TotalOutLabel.Name = "TotalOutLabel"
        TotalOutLabel.Size = New System.Drawing.Size(60, 20)
        TotalOutLabel.TabIndex = 12
        TotalOutLabel.Text = "Total Out:"
        TotalOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ActQtyLabel
        '
        ActQtyLabel.Location = New System.Drawing.Point(705, 219)
        ActQtyLabel.Name = "ActQtyLabel"
        ActQtyLabel.Size = New System.Drawing.Size(60, 20)
        ActQtyLabel.TabIndex = 15
        ActQtyLabel.Text = "Act Qty:"
        ActQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        ActQtyLabel.Visible = False
        '
        'CPPULabel
        '
        CPPULabel.Location = New System.Drawing.Point(705, 243)
        CPPULabel.Name = "CPPULabel"
        CPPULabel.Size = New System.Drawing.Size(60, 20)
        CPPULabel.TabIndex = 16
        CPPULabel.Text = "Unit Price:"
        CPPULabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        CPPULabel.Visible = False
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(353, 91)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 20)
        Label4.TabIndex = 34
        Label4.Text = "Currency:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranTypeLabel
        '
        TranTypeLabel.Location = New System.Drawing.Point(43, 61)
        TranTypeLabel.Name = "TranTypeLabel"
        TranTypeLabel.Size = New System.Drawing.Size(95, 21)
        TranTypeLabel.TabIndex = 35
        TranTypeLabel.Text = "Transaction Type:"
        TranTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BindingNavigator2)
        Me.Panel1.Controls.Add(DayNoLabel)
        Me.Panel1.Controls.Add(Me.DayNoLabel1)
        Me.Panel1.Controls.Add(DateNameLabel)
        Me.Panel1.Controls.Add(Me.DateNameLabel1)
        Me.Panel1.Location = New System.Drawing.Point(31, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 73)
        Me.Panel1.TabIndex = 0
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
        Me.BindingNavigator2.Size = New System.Drawing.Size(594, 25)
        Me.BindingNavigator2.TabIndex = 5
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSTranIn
        '
        'DSTranIn
        '
        Me.DSTranIn.DataSetName = "DSTranIn"
        Me.DSTranIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DayNoLabel1
        '
        Me.DayNoLabel1.BackColor = System.Drawing.Color.White
        Me.DayNoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.Location = New System.Drawing.Point(149, 39)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DayNoLabel1.TabIndex = 4
        Me.DayNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.ContextMenuStrip = Me.CMSDate
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(455, 39)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DateNameLabel1.TabIndex = 3
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMSDate
        '
        Me.CMSDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMtxtDate, Me.ToolStripMenuItem2})
        Me.CMSDate.Name = "SupplierContextMenuStrip"
        Me.CMSDate.Size = New System.Drawing.Size(161, 51)
        '
        'CMtxtDate
        '
        Me.CMtxtDate.ForeColor = System.Drawing.Color.Silver
        Me.CMtxtDate.Name = "CMtxtDate"
        Me.CMtxtDate.Size = New System.Drawing.Size(100, 23)
        Me.CMtxtDate.Text = "Enter First Date"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem2.Text = "Remove &Filter"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TranTypeComboBox)
        Me.Panel2.Controls.Add(TranTypeLabel)
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(Me.CurrencyTextBox)
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(PPULabel)
        Me.Panel2.Controls.Add(Me.NarrationTextBox)
        Me.Panel2.Controls.Add(Me.PPUTextBox)
        Me.Panel2.Controls.Add(Me.ExpiryDateMaskedTextBox)
        Me.Panel2.Controls.Add(Me.ManfDateMaskedTextBox)
        Me.Panel2.Controls.Add(Me.QtyTextBox)
        Me.Panel2.Controls.Add(Me.CodeTextBox)
        Me.Panel2.Controls.Add(Me.TranInIDLabel2)
        Me.Panel2.Controls.Add(Me.CompanyNameComboBox)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(TranInIDLabel)
        Me.Panel2.Controls.Add(SupplierIDLabel)
        Me.Panel2.Controls.Add(QtyLabel)
        Me.Panel2.Controls.Add(ManfDateLabel)
        Me.Panel2.Controls.Add(ExpiryDateLabel)
        Me.Panel2.Controls.Add(NarrationLabel)
        Me.Panel2.Location = New System.Drawing.Point(31, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(668, 296)
        Me.Panel2.TabIndex = 1
        '
        'TranTypeComboBox
        '
        Me.TranTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "TranType", True))
        Me.TranTypeComboBox.Items.AddRange(New Object() {"MRI", "MTP"})
        Me.TranTypeComboBox.Location = New System.Drawing.Point(149, 61)
        Me.TranTypeComboBox.Name = "TranTypeComboBox"
        Me.TranTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TranTypeComboBox.TabIndex = 36
        '
        'Tbl_Inv_Tran_InBindingSource
        '
        Me.Tbl_Inv_Tran_InBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Inv_Tran_In"
        Me.Tbl_Inv_Tran_InBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'CurrencyTextBox
        '
        Me.CurrencyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Currency", True))
        Me.CurrencyTextBox.Location = New System.Drawing.Point(459, 91)
        Me.CurrencyTextBox.Name = "CurrencyTextBox"
        Me.CurrencyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CurrencyTextBox.TabIndex = 33
        Me.CurrencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(416, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton2.TabIndex = 32
        Me.RadioButton2.Text = "Auto Save"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(320, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 31
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Manuall Save"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'NarrationTextBox
        '
        Me.NarrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Narration", True))
        Me.NarrationTextBox.Location = New System.Drawing.Point(149, 254)
        Me.NarrationTextBox.Name = "NarrationTextBox"
        Me.NarrationTextBox.Size = New System.Drawing.Size(491, 20)
        Me.NarrationTextBox.TabIndex = 6
        '
        'PPUTextBox
        '
        Me.PPUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "PPU", True))
        Me.PPUTextBox.Location = New System.Drawing.Point(459, 116)
        Me.PPUTextBox.Name = "PPUTextBox"
        Me.PPUTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PPUTextBox.TabIndex = 1
        Me.PPUTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExpiryDateMaskedTextBox
        '
        Me.ExpiryDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "ExpiryDate", True))
        Me.ExpiryDateMaskedTextBox.Location = New System.Drawing.Point(459, 221)
        Me.ExpiryDateMaskedTextBox.Mask = "00/00/0000"
        Me.ExpiryDateMaskedTextBox.Name = "ExpiryDateMaskedTextBox"
        Me.ExpiryDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExpiryDateMaskedTextBox.TabIndex = 5
        Me.ExpiryDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ExpiryDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ManfDateMaskedTextBox
        '
        Me.ManfDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "ManfDate", True))
        Me.ManfDateMaskedTextBox.Location = New System.Drawing.Point(459, 195)
        Me.ManfDateMaskedTextBox.Mask = "00/00/0000"
        Me.ManfDateMaskedTextBox.Name = "ManfDateMaskedTextBox"
        Me.ManfDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ManfDateMaskedTextBox.TabIndex = 4
        Me.ManfDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ManfDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(459, 141)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTextBox.TabIndex = 2
        Me.QtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CodeTextBox
        '
        Me.CodeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Code", True))
        Me.CodeTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CodeTextBox.Location = New System.Drawing.Point(523, 43)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(100, 13)
        Me.CodeTextBox.TabIndex = 30
        Me.CodeTextBox.TabStop = False
        '
        'TranInIDLabel2
        '
        Me.TranInIDLabel2.BackColor = System.Drawing.Color.White
        Me.TranInIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TranInIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "TranInID", True))
        Me.TranInIDLabel2.Location = New System.Drawing.Point(149, 35)
        Me.TranInIDLabel2.Name = "TranInIDLabel2"
        Me.TranInIDLabel2.Size = New System.Drawing.Size(121, 21)
        Me.TranInIDLabel2.TabIndex = 29
        Me.TranInIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompanyNameComboBox
        '
        Me.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CompanyNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_InBindingSource, "SupplierID", True))
        Me.CompanyNameComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.CompanyNameComboBox.DisplayMember = "CompanyName"
        Me.CompanyNameComboBox.FormattingEnabled = True
        Me.CompanyNameComboBox.Location = New System.Drawing.Point(459, 167)
        Me.CompanyNameComboBox.Name = "CompanyNameComboBox"
        Me.CompanyNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.CompanyNameComboBox.TabIndex = 3
        Me.CompanyNameComboBox.ValueMember = "SupplierID"
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSTranIn
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.L4NameComboBox)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.L3NameComboBox)
        Me.Panel4.Controls.Add(L1NameLabel)
        Me.Panel4.Controls.Add(L3NameLabel)
        Me.Panel4.Controls.Add(Me.L2NameComboBox)
        Me.Panel4.Controls.Add(L2NameLabel)
        Me.Panel4.Controls.Add(CodeLabel)
        Me.Panel4.Controls.Add(Me.L1NameComboBox)
        Me.Panel4.Location = New System.Drawing.Point(24, 89)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(322, 152)
        Me.Panel4.TabIndex = 0
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_InBindingSource, "Code", True))
        Me.L4NameComboBox.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(124, 112)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.L4NameComboBox.TabIndex = 3
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L3_tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.Tbl_Inv_L3BindingSource
        '
        'Tbl_Inv_L3BindingSource
        '
        Me.Tbl_Inv_L3BindingSource.DataMember = "tbl_Inv_L2_tbl_Inv_L3"
        Me.Tbl_Inv_L3BindingSource.DataSource = Me.Tbl_Inv_L2BindingSource
        '
        'Tbl_Inv_L2BindingSource
        '
        Me.Tbl_Inv_L2BindingSource.DataMember = "tbl_Inv_L1_tbl_Inv_L2"
        Me.Tbl_Inv_L2BindingSource.DataSource = Me.Tbl_Inv_L1BindingSource
        '
        'Tbl_Inv_L1BindingSource
        '
        Me.Tbl_Inv_L1BindingSource.DataMember = "tbl_Inv_L1"
        Me.Tbl_Inv_L1BindingSource.DataSource = Me.DSTranInCodeLayer
        '
        'DSTranInCodeLayer
        '
        Me.DSTranInCodeLayer.DataSetName = "DSTranInCodeLayer"
        Me.DSTranInCodeLayer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Select the Material"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L3NameComboBox
        '
        Me.L3NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L3NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L3NameComboBox.DataSource = Me.Tbl_Inv_L3BindingSource
        Me.L3NameComboBox.DisplayMember = "L3Name"
        Me.L3NameComboBox.FormattingEnabled = True
        Me.L3NameComboBox.Location = New System.Drawing.Point(124, 85)
        Me.L3NameComboBox.Name = "L3NameComboBox"
        Me.L3NameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.L3NameComboBox.TabIndex = 2
        Me.L3NameComboBox.ValueMember = "Layer3ID"
        '
        'L2NameComboBox
        '
        Me.L2NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L2NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L2NameComboBox.DataSource = Me.Tbl_Inv_L2BindingSource
        Me.L2NameComboBox.DisplayMember = "L2Name"
        Me.L2NameComboBox.FormattingEnabled = True
        Me.L2NameComboBox.Location = New System.Drawing.Point(124, 58)
        Me.L2NameComboBox.Name = "L2NameComboBox"
        Me.L2NameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.L2NameComboBox.TabIndex = 1
        Me.L2NameComboBox.ValueMember = "Layer2ID"
        '
        'L1NameComboBox
        '
        Me.L1NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L1NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L1NameComboBox.DataSource = Me.Tbl_Inv_L1BindingSource
        Me.L1NameComboBox.DisplayMember = "L1Name"
        Me.L1NameComboBox.FormattingEnabled = True
        Me.L1NameComboBox.Location = New System.Drawing.Point(124, 33)
        Me.L1NameComboBox.Name = "L1NameComboBox"
        Me.L1NameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.L1NameComboBox.TabIndex = 0
        Me.L1NameComboBox.ValueMember = "Layer1ID"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_Tran_InBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveIn, Me.ToolStripButton3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(666, 25)
        Me.BindingNavigator1.TabIndex = 28
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'SaveIn
        '
        Me.SaveIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveIn.Image = CType(resources.GetObject("SaveIn.Image"), System.Drawing.Image)
        Me.SaveIn.Name = "SaveIn"
        Me.SaveIn.Size = New System.Drawing.Size(23, 22)
        Me.SaveIn.Text = "Save Data"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Undo"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(898, 44)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Material Transactions Received"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_L1TableAdapter
        '
        Me.Tbl_Inv_L1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L2TableAdapter
        '
        Me.Tbl_Inv_L2TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L3TableAdapter
        '
        Me.Tbl_Inv_L3TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'TotalInLabel1
        '
        Me.TotalInLabel1.BackColor = System.Drawing.Color.White
        Me.TotalInLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalInLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Inv_TotalInBindingSource, "TotalIn", True))
        Me.TotalInLabel1.Location = New System.Drawing.Point(771, 129)
        Me.TotalInLabel1.Name = "TotalInLabel1"
        Me.TotalInLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TotalInLabel1.TabIndex = 11
        Me.TotalInLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Inv_TotalInBindingSource
        '
        Me.View_Inv_TotalInBindingSource.DataMember = "View_Inv_TotalIn"
        Me.View_Inv_TotalInBindingSource.DataSource = Me.DSTranIn
        '
        'TotalOutLabel1
        '
        Me.TotalOutLabel1.BackColor = System.Drawing.Color.White
        Me.TotalOutLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalOutLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Inv_TotalOutBindingSource, "TotalOut", True))
        Me.TotalOutLabel1.Location = New System.Drawing.Point(771, 153)
        Me.TotalOutLabel1.Name = "TotalOutLabel1"
        Me.TotalOutLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TotalOutLabel1.TabIndex = 13
        Me.TotalOutLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Inv_TotalOutBindingSource
        '
        Me.View_Inv_TotalOutBindingSource.DataMember = "View_Inv_TotalOut"
        Me.View_Inv_TotalOutBindingSource.DataSource = Me.DSTranIn
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(705, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Balance:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBal
        '
        Me.lblBal.BackColor = System.Drawing.Color.White
        Me.lblBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBal.Location = New System.Drawing.Point(771, 177)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(100, 20)
        Me.lblBal.TabIndex = 15
        Me.lblBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActQtyLabel1
        '
        Me.ActQtyLabel1.BackColor = System.Drawing.Color.White
        Me.ActQtyLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ActQtyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource1, "ActQty", True))
        Me.ActQtyLabel1.Location = New System.Drawing.Point(771, 219)
        Me.ActQtyLabel1.Name = "ActQtyLabel1"
        Me.ActQtyLabel1.Size = New System.Drawing.Size(100, 20)
        Me.ActQtyLabel1.TabIndex = 16
        Me.ActQtyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ActQtyLabel1.Visible = False
        '
        'Tbl_Inv_L4BindingSource1
        '
        Me.Tbl_Inv_L4BindingSource1.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource1.DataSource = Me.DSTranIn
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_InTableAdapter
        '
        Me.Tbl_Inv_Tran_InTableAdapter.ClearBeforeFill = True
        '
        'View_Inv_TotalInTableAdapter
        '
        Me.View_Inv_TotalInTableAdapter.ClearBeforeFill = True
        '
        'View_Inv_TotalOutTableAdapter
        '
        Me.View_Inv_TotalOutTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_L4TableAdapter1
        '
        Me.Tbl_Inv_L4TableAdapter1.ClearBeforeFill = True
        '
        'CPPULabel1
        '
        Me.CPPULabel1.BackColor = System.Drawing.Color.White
        Me.CPPULabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CPPULabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource1, "CPPU", True))
        Me.CPPULabel1.Location = New System.Drawing.Point(771, 243)
        Me.CPPULabel1.Name = "CPPULabel1"
        Me.CPPULabel1.Size = New System.Drawing.Size(100, 20)
        Me.CPPULabel1.TabIndex = 17
        Me.CPPULabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CPPULabel1.Visible = False
        '
        'CPPULabel3
        '
        Me.CPPULabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource1, "CPPU", True))
        Me.CPPULabel3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel3.Location = New System.Drawing.Point(771, 280)
        Me.CPPULabel3.Name = "CPPULabel3"
        Me.CPPULabel3.Size = New System.Drawing.Size(100, 11)
        Me.CPPULabel3.TabIndex = 18
        '
        'CurrencyLabel1
        '
        Me.CurrencyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_L4BindingSource1, "Currency", True))
        Me.CurrencyLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.Location = New System.Drawing.Point(771, 300)
        Me.CurrencyLabel1.Name = "CurrencyLabel1"
        Me.CurrencyLabel1.Size = New System.Drawing.Size(100, 16)
        Me.CurrencyLabel1.TabIndex = 19
        '
        'frmTranIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(898, 460)
        Me.Controls.Add(Me.CurrencyLabel1)
        Me.Controls.Add(Me.CPPULabel3)
        Me.Controls.Add(CPPULabel)
        Me.Controls.Add(Me.CPPULabel1)
        Me.Controls.Add(ActQtyLabel)
        Me.Controls.Add(Me.ActQtyLabel1)
        Me.Controls.Add(Me.lblBal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(TotalOutLabel)
        Me.Controls.Add(Me.TotalOutLabel1)
        Me.Controls.Add(TotalInLabel)
        Me.Controls.Add(Me.TotalInLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTranIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Inward"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTranIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSDate.ResumeLayout(False)
        Me.CMSDate.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTranInCodeLayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_Inv_TotalInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Inv_TotalOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SaveIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DSTranIn As FS_ERP_MM.DSTranIn
    Friend WithEvents DSTranInCodeLayer As FS_ERP_MM.DSTranInCodeLayer
    Friend WithEvents Tbl_Inv_L1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L1TableAdapter As FS_ERP_MM.DSTranInCodeLayerTableAdapters.tbl_Inv_L1TableAdapter
    Friend WithEvents L1NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L2TableAdapter As FS_ERP_MM.DSTranInCodeLayerTableAdapters.tbl_Inv_L2TableAdapter
    Friend WithEvents L2NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L3TableAdapter As FS_ERP_MM.DSTranInCodeLayerTableAdapters.tbl_Inv_L3TableAdapter
    Friend WithEvents L3NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSTranInCodeLayerTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As FS_ERP_MM.DSTranInTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents CompanyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSTranInTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
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
    Friend WithEvents Tbl_Inv_Tran_InBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_InTableAdapter As FS_ERP_MM.DSTranInTableAdapters.tbl_Inv_Tran_InTableAdapter
    Friend WithEvents NarrationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpiryDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ManfDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TranInIDLabel2 As System.Windows.Forms.Label
    Friend WithEvents PPUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents View_Inv_TotalInBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Inv_TotalInTableAdapter As FS_ERP_MM.DSTranInTableAdapters.View_Inv_TotalInTableAdapter
    Friend WithEvents TotalInLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Inv_TotalOutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Inv_TotalOutTableAdapter As FS_ERP_MM.DSTranInTableAdapters.View_Inv_TotalOutTableAdapter
    Friend WithEvents TotalOutLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBal As System.Windows.Forms.Label
    Friend WithEvents Tbl_Inv_L4BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter1 As FS_ERP_MM.DSTranInTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents ActQtyLabel1 As System.Windows.Forms.Label
    Friend WithEvents CPPULabel1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CPPULabel3 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TranTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CMSDate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMtxtDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem


End Class
