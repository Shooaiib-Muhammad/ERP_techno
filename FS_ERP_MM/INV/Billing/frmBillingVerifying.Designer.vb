<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillingVerifying
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillingVerifying))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Tbl_Billing_TransactionsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.Tbl_Billing_TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBillingVerify = New FS_ERP_MM.DSBillingVerify
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Tbl_Billing_TransactionsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Tbl_Billing_TransactionsDataGridView = New System.Windows.Forms.DataGridView
        Me.Tbl_Billing_PartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBilling = New FS_ERP_MM.DSBilling
        Me.Tbl_Pur_POBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMBillingTran = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BillingNoTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Tbl_Billing_PartyTableAdapter = New FS_ERP_MM.DSBillingTableAdapters.tbl_Billing_PartyTableAdapter
        Me.TableAdapterManager1 = New FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager
        Me.Tbl_Billing_TransactionsTableAdapter = New FS_ERP_MM.DSBillingVerifyTableAdapters.tbl_Billing_TransactionsTableAdapter
        Me.TableAdapterManager = New FS_ERP_MM.DSBillingVerifyTableAdapters.TableAdapterManager
        Me.Tbl_Pur_POTableAdapter = New FS_ERP_MM.DSBillingVerifyTableAdapters.tbl_Pur_POTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.VerifyDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PO = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.MRINDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Tbl_Billing_TransactionsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Billing_TransactionsBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Billing_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBillingVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Billing_TransactionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Billing_PartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMBillingTran.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1028, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Billing Transactions Verification"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Billing_TransactionsBindingNavigator
        '
        Me.Tbl_Billing_TransactionsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Billing_TransactionsBindingNavigator.BindingSource = Me.Tbl_Billing_TransactionsBindingSource
        Me.Tbl_Billing_TransactionsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Billing_TransactionsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Billing_TransactionsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Billing_TransactionsBindingNavigatorSaveItem})
        Me.Tbl_Billing_TransactionsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Billing_TransactionsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Billing_TransactionsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Billing_TransactionsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Billing_TransactionsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Billing_TransactionsBindingNavigator.Name = "Tbl_Billing_TransactionsBindingNavigator"
        Me.Tbl_Billing_TransactionsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Billing_TransactionsBindingNavigator.Size = New System.Drawing.Size(990, 25)
        Me.Tbl_Billing_TransactionsBindingNavigator.TabIndex = 6
        Me.Tbl_Billing_TransactionsBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Billing_TransactionsBindingSource
        '
        Me.Tbl_Billing_TransactionsBindingSource.DataMember = "tbl_Billing_Transactions"
        Me.Tbl_Billing_TransactionsBindingSource.DataSource = Me.DSBillingVerify
        '
        'DSBillingVerify
        '
        Me.DSBillingVerify.DataSetName = "DSBillingVerify"
        Me.DSBillingVerify.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.Visible = False
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
        'Tbl_Billing_TransactionsBindingNavigatorSaveItem
        '
        Me.Tbl_Billing_TransactionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Billing_TransactionsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Billing_TransactionsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Billing_TransactionsBindingNavigatorSaveItem.Name = "Tbl_Billing_TransactionsBindingNavigatorSaveItem"
        Me.Tbl_Billing_TransactionsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Billing_TransactionsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_Billing_TransactionsDataGridView
        '
        Me.Tbl_Billing_TransactionsDataGridView.AllowUserToAddRows = False
        Me.Tbl_Billing_TransactionsDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_Billing_TransactionsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Billing_TransactionsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Billing_TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Billing_TransactionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewCheckBoxColumn2, Me.VerifyDate, Me.PO, Me.MRINDate})
        Me.Tbl_Billing_TransactionsDataGridView.ContextMenuStrip = Me.CMBillingTran
        Me.Tbl_Billing_TransactionsDataGridView.DataSource = Me.Tbl_Billing_TransactionsBindingSource
        Me.Tbl_Billing_TransactionsDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_Billing_TransactionsDataGridView.Name = "Tbl_Billing_TransactionsDataGridView"
        Me.Tbl_Billing_TransactionsDataGridView.Size = New System.Drawing.Size(985, 569)
        Me.Tbl_Billing_TransactionsDataGridView.TabIndex = 6
        '
        'Tbl_Billing_PartyBindingSource
        '
        Me.Tbl_Billing_PartyBindingSource.DataMember = "tbl_Billing_Party"
        Me.Tbl_Billing_PartyBindingSource.DataSource = Me.DSBilling
        '
        'DSBilling
        '
        Me.DSBilling.DataSetName = "DSBilling"
        Me.DSBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Pur_POBindingSource
        '
        Me.Tbl_Pur_POBindingSource.DataMember = "tbl_Pur_PO"
        Me.Tbl_Pur_POBindingSource.DataSource = Me.DSBillingVerify
        '
        'CMBillingTran
        '
        Me.CMBillingTran.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingNoTextBox, Me.ToolStripMenuItem11})
        Me.CMBillingTran.Name = "SupplierContextMenuStrip"
        Me.CMBillingTran.Size = New System.Drawing.Size(171, 51)
        '
        'BillingNoTextBox
        '
        Me.BillingNoTextBox.ForeColor = System.Drawing.Color.Silver
        Me.BillingNoTextBox.Name = "BillingNoTextBox"
        Me.BillingNoTextBox.Size = New System.Drawing.Size(110, 23)
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem11.Text = "Remove &Filter"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Billing_TransactionsBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_Billing_TransactionsDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(6, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 601)
        Me.Panel1.TabIndex = 7
        '
        'Tbl_Billing_PartyTableAdapter
        '
        Me.Tbl_Billing_PartyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Billing_PartyTableAdapter = Me.Tbl_Billing_PartyTableAdapter
        Me.TableAdapterManager1.tbl_Billing_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Billing_TransactionsTableAdapter
        '
        Me.Tbl_Billing_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Billing_Transactions11TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Billing_TransactionsTableAdapter = Me.Tbl_Billing_TransactionsTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSBillingVerifyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Pur_POTableAdapter
        '
        Me.Tbl_Pur_POTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TranId"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sr.No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PartyID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.Tbl_Billing_PartyBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "PartyName"
        Me.DataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Party Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "PartyID"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "InvoiceNo"
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Invoice No."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "InvoiceDate"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn9.Frozen = True
        Me.DataGridViewTextBoxColumn9.HeaderText = "Invoice Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Qty"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.Frozen = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Amount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.Frozen = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MatDes"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn8.Frozen = True
        Me.DataGridViewTextBoxColumn8.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 190
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "RefNo"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ref.No."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "VerifyStatus"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Verify Status"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 60
        '
        'VerifyDate
        '
        Me.VerifyDate.DataPropertyName = "VerifyDate"
        Me.VerifyDate.HeaderText = "VerifyDate"
        Me.VerifyDate.Name = "VerifyDate"
        Me.VerifyDate.Visible = False
        '
        'PO
        '
        Me.PO.DataPropertyName = "PO"
        Me.PO.DataSource = Me.Tbl_Pur_POBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.PO.DefaultCellStyle = DataGridViewCellStyle8
        Me.PO.DisplayMember = "POID"
        Me.PO.DisplayStyleForCurrentCellOnly = True
        Me.PO.HeaderText = "PO No."
        Me.PO.Name = "PO"
        Me.PO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PO.ValueMember = "POID"
        Me.PO.Width = 70
        '
        'MRINDate
        '
        Me.MRINDate.DataPropertyName = "MRINDate"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "d"
        Me.MRINDate.DefaultCellStyle = DataGridViewCellStyle9
        Me.MRINDate.HeaderText = "MRIN Date"
        Me.MRINDate.Name = "MRINDate"
        Me.MRINDate.Width = 70
        '
        'frmBillingVerifying
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBillingVerifying"
        Me.Text = "Billing Transactions Verification"
        CType(Me.Tbl_Billing_TransactionsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Billing_TransactionsBindingNavigator.ResumeLayout(False)
        Me.Tbl_Billing_TransactionsBindingNavigator.PerformLayout()
        CType(Me.Tbl_Billing_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBillingVerify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Billing_TransactionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Billing_PartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_POBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMBillingTran.ResumeLayout(False)
        Me.CMBillingTran.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSBillingVerify As FS_ERP_MM.DSBillingVerify
    Friend WithEvents Tbl_Billing_TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Billing_TransactionsTableAdapter As FS_ERP_MM.DSBillingVerifyTableAdapters.tbl_Billing_TransactionsTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSBillingVerifyTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Billing_TransactionsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Billing_TransactionsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Billing_TransactionsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DSBilling As FS_ERP_MM.DSBilling
    Friend WithEvents Tbl_Billing_PartyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Billing_PartyTableAdapter As FS_ERP_MM.DSBillingTableAdapters.tbl_Billing_PartyTableAdapter
    Friend WithEvents TableAdapterManager1 As FS_ERP_MM.DSBillingTableAdapters.TableAdapterManager
    Friend WithEvents CMBillingTran As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BillingNoTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tbl_Pur_POBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_POTableAdapter As FS_ERP_MM.DSBillingVerifyTableAdapters.tbl_Pur_POTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VerifyDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PO As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents MRINDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
