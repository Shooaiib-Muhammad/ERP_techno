﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDailyIN
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDailyIN))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DSIT = New FS_ERP_MM.DSIT()
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSITTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSITTableAdapters.TableAdapterManager()
        Me.Tbl_Fit_Material_ReceivedTableAdapter = New FS_ERP_MM.DSITTableAdapters.Tbl_Fit_Material_ReceivedTableAdapter()
        Me.Tbl_Fit_Material_ReceivedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fit_Material_ReceivedDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tbl_Fit_MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSFIT = New FS_ERP_MM.DSFIT()
        Me.Tbl_VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fit_MaterialTableAdapter = New FS_ERP_MM.DSFITTableAdapters.Tbl_Fit_MaterialTableAdapter()
        Me.TableAdapterManager1 = New FS_ERP_MM.DSFITTableAdapters.TableAdapterManager()
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.DSFITTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_VendorsTableAdapter = New FS_ERP_MM.DSITTableAdapters.tbl_VendorsTableAdapter()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.DSIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fit_Material_ReceivedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fit_Material_ReceivedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fit_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSFIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(4, 30)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(100, 20)
        Label3.TabIndex = 0
        Label3.Text = "Transaction Date:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DSIT
        '
        Me.DSIT.DataSetName = "DSIT"
        Me.DSIT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSIT
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBl_Daily_IssuanceTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Fit_Material_ReceivedTableAdapter = Me.Tbl_Fit_Material_ReceivedTableAdapter
        Me.TableAdapterManager.tbl_Inv_LocalCustTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Me.Tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager.tbl_VendorsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSITTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Fit_Material_ReceivedTableAdapter
        '
        Me.Tbl_Fit_Material_ReceivedTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Fit_Material_ReceivedBindingSource
        '
        Me.Tbl_Fit_Material_ReceivedBindingSource.DataMember = "tbl_Inv_Tran_Date_Tbl_Fit_Material_Received"
        Me.Tbl_Fit_Material_ReceivedBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'Tbl_Fit_Material_ReceivedDataGridView
        '
        Me.Tbl_Fit_Material_ReceivedDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_Fit_Material_ReceivedDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Fit_Material_ReceivedDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Fit_Material_ReceivedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Fit_Material_ReceivedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.ReceivedNo, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn7})
        Me.Tbl_Fit_Material_ReceivedDataGridView.DataSource = Me.Tbl_Fit_Material_ReceivedBindingSource
        Me.Tbl_Fit_Material_ReceivedDataGridView.Location = New System.Drawing.Point(-1, 28)
        Me.Tbl_Fit_Material_ReceivedDataGridView.Name = "Tbl_Fit_Material_ReceivedDataGridView"
        Me.Tbl_Fit_Material_ReceivedDataGridView.RowHeadersWidth = 23
        Me.Tbl_Fit_Material_ReceivedDataGridView.Size = New System.Drawing.Size(1079, 439)
        Me.Tbl_Fit_Material_ReceivedDataGridView.TabIndex = 0
        '
        'Tbl_Fit_MaterialBindingSource
        '
        Me.Tbl_Fit_MaterialBindingSource.DataMember = "Tbl_Fit_Material"
        Me.Tbl_Fit_MaterialBindingSource.DataSource = Me.DSFIT
        '
        'DSFIT
        '
        Me.DSFIT.DataSetName = "DSFIT"
        Me.DSFIT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_VendorsBindingSource
        '
        Me.Tbl_VendorsBindingSource.DataMember = "tbl_Vendors"
        Me.Tbl_VendorsBindingSource.DataSource = Me.DSIT
        '
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataMember = "tbl_Pur_UnitOfMeasurement"
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DSFIT
        '
        'Tbl_Fit_MaterialTableAdapter
        '
        Me.Tbl_Fit_MaterialTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Tbl_Fit_Mat_TypeTableAdapter = Nothing
        Me.TableAdapterManager1.Tbl_Fit_Material_ReceivedTableAdapter = Nothing
        Me.TableAdapterManager1.Tbl_Fit_MaterialTableAdapter = Me.Tbl_Fit_MaterialTableAdapter
        Me.TableAdapterManager1.Tbl_Fit_Test_CatalogsTableAdapter = Nothing
        Me.TableAdapterManager1.Tbl_Fit_Test_TransactionTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_SupplierTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Inv_Tran_InTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Pur_UnitOfMeasurementTableAdapter = Me.Tbl_Pur_UnitOfMeasurementTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DSFITTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
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
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Daily Material Received"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.BindingNavigator3)
        Me.Panel3.Controls.Add(Label3)
        Me.Panel3.Location = New System.Drawing.Point(12, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 57)
        Me.Panel3.TabIndex = 98
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.ComboBox1.DisplayMember = "DateName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 101
        Me.ComboBox1.ValueMember = "DayNo"
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Nothing
        Me.BindingNavigator3.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator3.DeleteItem = Nothing
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator3})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton2
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton5
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton4
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton3
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator3.Size = New System.Drawing.Size(291, 25)
        Me.BindingNavigator3.TabIndex = 84
        Me.BindingNavigator3.Text = "BindingNavigator3"
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
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.Tbl_Fit_Material_ReceivedDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1083, 472)
        Me.Panel1.TabIndex = 99
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_Fit_Material_ReceivedBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton6, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1081, 25)
        Me.BindingNavigator1.TabIndex = 1
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
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.FS_ERP_MM.My.Resources.Resources.images1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Tbl_VendorsTableAdapter
        '
        Me.Tbl_VendorsTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "BillNo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "Bill No"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'ReceivedNo
        '
        Me.ReceivedNo.DataPropertyName = "ReceivedNo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ReceivedNo.DefaultCellStyle = DataGridViewCellStyle3
        Me.ReceivedNo.HeaderText = "Receiving No"
        Me.ReceivedNo.Name = "ReceivedNo"
        Me.ReceivedNo.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MatID"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.Tbl_Fit_MaterialBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.DisplayMember = "MatName"
        Me.DataGridViewTextBoxColumn2.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "MatID"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SuplierID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.Tbl_VendorsBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "VendorName"
        Me.DataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "VendorID"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Qty"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UOM"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.Tbl_Pur_UnitOfMeasurementBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "UOM"
        Me.DataGridViewTextBoxColumn6.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "UOM"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Price"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn9.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 250
        '
        'FrmDailyIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 810)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDailyIN"
        Me.Text = "Daily Material Received"
        CType(Me.DSIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fit_Material_ReceivedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fit_Material_ReceivedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fit_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSFIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSIT As DSIT
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As DSITTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents TableAdapterManager As DSITTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Fit_Material_ReceivedTableAdapter As DSITTableAdapters.Tbl_Fit_Material_ReceivedTableAdapter
    Friend WithEvents Tbl_Fit_Material_ReceivedBindingSource As BindingSource
    Friend WithEvents Tbl_Fit_Material_ReceivedDataGridView As DataGridView
    Friend WithEvents DSFIT As DSFIT
    Friend WithEvents Tbl_Fit_MaterialBindingSource As BindingSource
    Friend WithEvents Tbl_Fit_MaterialTableAdapter As DSFITTableAdapters.Tbl_Fit_MaterialTableAdapter
    Friend WithEvents TableAdapterManager1 As DSFITTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As DSFITTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Tbl_VendorsBindingSource As BindingSource
    Friend WithEvents Tbl_VendorsTableAdapter As DSITTableAdapters.tbl_VendorsTableAdapter
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
