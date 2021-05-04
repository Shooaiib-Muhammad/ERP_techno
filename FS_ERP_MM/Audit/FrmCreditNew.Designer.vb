<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCreditNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NTNLabel As System.Windows.Forms.Label
        Dim RegNoLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim EnteryDateLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreditNew))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DSCredit = New FS_ERP_MM.DSCredit()
        Me.Tbl_Audit_Credit_DebitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Audit_Credit_DebitTableAdapter = New FS_ERP_MM.DSCreditTableAdapters.tbl_Audit_Credit_DebitTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSCreditTableAdapters.TableAdapterManager()
        Me.Tbl_Audit_Credit_debit_invoiceTableAdapter = New FS_ERP_MM.DSCreditTableAdapters.tbl_Audit_Credit_debit_invoiceTableAdapter()
        Me.Tbl_Inv_SupplierTableAdapter = New FS_ERP_MM.DSCreditTableAdapters.tbl_Inv_SupplierTableAdapter()
        Me.Tbl_Audit_Credit_debit_invoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Mat_MeasurementUnitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Mat_MeasurementUnitsTableAdapter = New FS_ERP_MM.DSCreditTableAdapters.tbl_Mat_MeasurementUnitsTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDiff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpDate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NTNTextBox = New System.Windows.Forms.TextBox()
        Me.RegNoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Audit_Credit_DebitBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Audit_Credit_DebitBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        NTNLabel = New System.Windows.Forms.Label()
        RegNoLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        EnteryDateLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        CType(Me.DSCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Audit_Credit_DebitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Audit_Credit_debit_invoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Mat_MeasurementUnitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Audit_Credit_debit_invoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Audit_Credit_DebitBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Audit_Credit_DebitBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NTNLabel
        '
        NTNLabel.AutoSize = True
        NTNLabel.Location = New System.Drawing.Point(715, 70)
        NTNLabel.Name = "NTNLabel"
        NTNLabel.Size = New System.Drawing.Size(33, 13)
        NTNLabel.TabIndex = 13
        NTNLabel.Text = "NTN:"
        '
        'RegNoLabel
        '
        RegNoLabel.AutoSize = True
        RegNoLabel.Location = New System.Drawing.Point(21, 70)
        RegNoLabel.Name = "RegNoLabel"
        RegNoLabel.Size = New System.Drawing.Size(47, 13)
        RegNoLabel.TabIndex = 11
        RegNoLabel.Text = "Reg No:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(200, 70)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'EnteryDateLabel
        '
        EnteryDateLabel.Location = New System.Drawing.Point(160, 39)
        EnteryDateLabel.Name = "EnteryDateLabel"
        EnteryDateLabel.Size = New System.Drawing.Size(68, 20)
        EnteryDateLabel.TabIndex = 8
        EnteryDateLabel.Text = "Entry Date:"
        EnteryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(714, 43)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(34, 13)
        Label2.TabIndex = 4
        Label2.Text = "Type:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(336, 43)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(79, 13)
        SupplierIDLabel.TabIndex = 1
        SupplierIDLabel.Text = "Supplier Name:"
        '
        'DSCredit
        '
        Me.DSCredit.DataSetName = "DSCredit"
        Me.DSCredit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Audit_Credit_DebitBindingSource
        '
        Me.Tbl_Audit_Credit_DebitBindingSource.DataMember = "tbl_Audit_Credit_Debit"
        Me.Tbl_Audit_Credit_DebitBindingSource.DataSource = Me.DSCredit
        '
        'Tbl_Audit_Credit_DebitTableAdapter
        '
        Me.Tbl_Audit_Credit_DebitTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Audit_Credit_debit_invoiceTableAdapter = Me.Tbl_Audit_Credit_debit_invoiceTableAdapter
        Me.TableAdapterManager.tbl_Audit_Credit_DebitTableAdapter = Me.Tbl_Audit_Credit_DebitTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSCreditTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Audit_Credit_debit_invoiceTableAdapter
        '
        Me.Tbl_Audit_Credit_debit_invoiceTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_SupplierTableAdapter
        '
        Me.Tbl_Inv_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Audit_Credit_debit_invoiceBindingSource
        '
        Me.Tbl_Audit_Credit_debit_invoiceBindingSource.DataMember = "tbl_Audit_Credit_Debit_tbl_Audit_Credit_debit_invoice"
        Me.Tbl_Audit_Credit_debit_invoiceBindingSource.DataSource = Me.Tbl_Audit_Credit_DebitBindingSource
        '
        'Tbl_Inv_SupplierBindingSource
        '
        Me.Tbl_Inv_SupplierBindingSource.DataMember = "tbl_Inv_Supplier"
        Me.Tbl_Inv_SupplierBindingSource.DataSource = Me.DSCredit
        '
        'Tbl_Mat_MeasurementUnitsBindingSource
        '
        Me.Tbl_Mat_MeasurementUnitsBindingSource.DataMember = "tbl_Mat_MeasurementUnits"
        Me.Tbl_Mat_MeasurementUnitsBindingSource.DataSource = Me.DSCredit
        '
        'Tbl_Mat_MeasurementUnitsTableAdapter
        '
        Me.Tbl_Mat_MeasurementUnitsTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.Tbl_Audit_Credit_debit_invoiceDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(13, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1138, 418)
        Me.Panel2.TabIndex = 8
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator1.BindingSource = Me.Tbl_Audit_Credit_debit_invoiceBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton6})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton2
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton5
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton4
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton3
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1136, 25)
        Me.BindingNavigator1.TabIndex = 6
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move first"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move next"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Save Data"
        '
        'Tbl_Audit_Credit_debit_invoiceDataGridView
        '
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn3, Me.Qty, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Reason, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.TotalDiff, Me.UpDate})
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.DataSource = Me.Tbl_Audit_Credit_debit_invoiceBindingSource
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.Location = New System.Drawing.Point(3, 27)
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.Name = "Tbl_Audit_Credit_debit_invoiceDataGridView"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.RowHeadersWidth = 23
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.Size = New System.Drawing.Size(1122, 386)
        Me.Tbl_Audit_Credit_debit_invoiceDataGridView.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "TID"
        Me.Column1.HeaderText = "Serial No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "InvoiceNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Invoice No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.Qty.HeaderText = "Qty PCS"
        Me.Qty.Name = "Qty"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UOM"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.Tbl_Mat_MeasurementUnitsBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "UOM"
        Me.DataGridViewTextBoxColumn4.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Reason
        '
        Me.Reason.DataPropertyName = "Reason"
        Me.Reason.HeaderText = "Reason"
        Me.Reason.Name = "Reason"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ActualQty"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "Actual Qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Diff"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn8.HeaderText = "Diff"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ExTexDiff"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ex. Tax Diff"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 80
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TaxDiff"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tax Diff"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'TotalDiff
        '
        Me.TotalDiff.DataPropertyName = "TotalDiff"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        Me.TotalDiff.DefaultCellStyle = DataGridViewCellStyle7
        Me.TotalDiff.HeaderText = "Total Diff"
        Me.TotalDiff.Name = "TotalDiff"
        '
        'UpDate
        '
        Me.UpDate.HeaderText = "Action"
        Me.UpDate.Name = "UpDate"
        Me.UpDate.Text = "UpDate"
        Me.UpDate.ToolTipText = "UpDate"
        Me.UpDate.UseColumnTextForButtonValue = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(NTNLabel)
        Me.Panel1.Controls.Add(Me.NTNTextBox)
        Me.Panel1.Controls.Add(RegNoLabel)
        Me.Panel1.Controls.Add(Me.RegNoTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(EnteryDateLabel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Tbl_Audit_Credit_DebitBindingNavigator)
        Me.Panel1.Controls.Add(SupplierIDLabel)
        Me.Panel1.Controls.Add(Me.SupplierIDComboBox)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 109)
        Me.Panel1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(795, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 26)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Show Reports"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NTNTextBox
        '
        Me.NTNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Audit_Credit_DebitBindingSource, "NTN", True))
        Me.NTNTextBox.Location = New System.Drawing.Point(754, 66)
        Me.NTNTextBox.Name = "NTNTextBox"
        Me.NTNTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NTNTextBox.TabIndex = 14
        '
        'RegNoTextBox
        '
        Me.RegNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Audit_Credit_DebitBindingSource, "RegNo", True))
        Me.RegNoTextBox.Location = New System.Drawing.Point(74, 66)
        Me.RegNoTextBox.Name = "RegNoTextBox"
        Me.RegNoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.RegNoTextBox.TabIndex = 12
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Audit_Credit_DebitBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(254, 66)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(455, 20)
        Me.AddressTextBox.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Audit_Credit_DebitBindingSource, "TID", True))
        Me.Label4.Location = New System.Drawing.Point(74, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Serial No."
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Audit_Credit_DebitBindingSource, "Type", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Credit", "Debit"})
        Me.ComboBox1.Location = New System.Drawing.Point(754, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Tbl_Audit_Credit_DebitBindingNavigator
        '
        Me.Tbl_Audit_Credit_DebitBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Audit_Credit_DebitBindingNavigator.BindingSource = Me.Tbl_Audit_Credit_DebitBindingSource
        Me.Tbl_Audit_Credit_DebitBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Audit_Credit_DebitBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Audit_Credit_DebitBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_Audit_Credit_DebitBindingNavigatorSaveItem})
        Me.Tbl_Audit_Credit_DebitBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Audit_Credit_DebitBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Audit_Credit_DebitBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Audit_Credit_DebitBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Audit_Credit_DebitBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Audit_Credit_DebitBindingNavigator.Name = "Tbl_Audit_Credit_DebitBindingNavigator"
        Me.Tbl_Audit_Credit_DebitBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Audit_Credit_DebitBindingNavigator.Size = New System.Drawing.Size(915, 25)
        Me.Tbl_Audit_Credit_DebitBindingNavigator.TabIndex = 1
        Me.Tbl_Audit_Credit_DebitBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Audit_Credit_DebitBindingNavigatorSaveItem
        '
        Me.Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Name = "Tbl_Audit_Credit_DebitBindingNavigatorSaveItem"
        Me.Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Audit_Credit_DebitBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Audit_Credit_DebitBindingSource, "SupplierName", True))
        Me.SupplierIDComboBox.DataSource = Me.Tbl_Inv_SupplierBindingSource
        Me.SupplierIDComboBox.DisplayMember = "CompanyName"
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(421, 39)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(288, 21)
        Me.SupplierIDComboBox.TabIndex = 2
        Me.SupplierIDComboBox.ValueMember = "CompanyName"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Audit_Credit_DebitBindingSource, "Date", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(230, 39)
        Me.MaskedTextBox1.Mask = "00-00-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 27
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1151, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Credit and debit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCreditNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 714)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCreditNew"
        Me.Text = "FrmCreditNew"
        CType(Me.DSCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Audit_Credit_DebitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Audit_Credit_debit_invoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Mat_MeasurementUnitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Audit_Credit_debit_invoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Audit_Credit_DebitBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Audit_Credit_DebitBindingNavigator.ResumeLayout(False)
        Me.Tbl_Audit_Credit_DebitBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSCredit As DSCredit
    Friend WithEvents Tbl_Audit_Credit_DebitBindingSource As BindingSource
    Friend WithEvents Tbl_Audit_Credit_DebitTableAdapter As DSCreditTableAdapters.tbl_Audit_Credit_DebitTableAdapter
    Friend WithEvents TableAdapterManager As DSCreditTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Audit_Credit_debit_invoiceTableAdapter As DSCreditTableAdapters.tbl_Audit_Credit_debit_invoiceTableAdapter
    Friend WithEvents Tbl_Audit_Credit_debit_invoiceBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_SupplierTableAdapter As DSCreditTableAdapters.tbl_Inv_SupplierTableAdapter
    Friend WithEvents Tbl_Inv_SupplierBindingSource As BindingSource
    Friend WithEvents Tbl_Mat_MeasurementUnitsBindingSource As BindingSource
    Friend WithEvents Tbl_Mat_MeasurementUnitsTableAdapter As DSCreditTableAdapters.tbl_Mat_MeasurementUnitsTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents Tbl_Audit_Credit_debit_invoiceDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents NTNTextBox As TextBox
    Friend WithEvents RegNoTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Tbl_Audit_Credit_DebitBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_Audit_Credit_DebitBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SupplierIDComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Reason As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents TotalDiff As DataGridViewTextBoxColumn
    Friend WithEvents UpDate As DataGridViewButtonColumn
End Class
