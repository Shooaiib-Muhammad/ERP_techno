<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDemandApproval
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
        Dim GMNoLabel As System.Windows.Forms.Label
        Dim DateNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDemandApproval))
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GMNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Demand_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSdemands = New FS_ERP_MM.DSdemands()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.DeptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GMNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L4NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequiredQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuedQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NarrationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovedStatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SpecialNoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotificaionStatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HODNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_Demand_HeadBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.View_New_Demands_BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.View_New_Demands_BalanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CPPU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DemandBal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_New_Demands_BalanceTableAdapter = New FS_ERP_MM.DSdemandsTableAdapters.view_New_Demands_BalanceTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSdemandsTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSdemandsTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.Tbl_Demand_HeadTableAdapter = New FS_ERP_MM.DSdemandsTableAdapters.tbl_Demand_HeadTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.View_Issued_demandsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.View_Issued_demandsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TranOutID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_Demand_IssuanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Demand_IssuanceTableAdapter = New FS_ERP_MM.DSdemandsTableAdapters.View_Demand_IssuanceTableAdapter()
        Me.View_Issued_demandsTableAdapter = New FS_ERP_MM.DSdemandsTableAdapters.View_Issued_demandsTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.DSdemandsTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.View_New_Demands_Balance_NEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_New_Demands_Balance_NEWTableAdapter = New FS_ERP_MM.DSdemandsTableAdapters.view_New_Demands_Balance_NEWTableAdapter()
        GMNoLabel = New System.Windows.Forms.Label()
        DateNameLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Demand_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSdemands, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Demand_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Demand_HeadBindingNavigator.SuspendLayout()
        CType(Me.View_New_Demands_BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_New_Demands_BalanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_Issued_demandsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Issued_demandsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Demand_IssuanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.View_New_Demands_Balance_NEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GMNoLabel
        '
        GMNoLabel.AutoSize = True
        GMNoLabel.Location = New System.Drawing.Point(11, 11)
        GMNoLabel.Name = "GMNoLabel"
        GMNoLabel.Size = New System.Drawing.Size(103, 13)
        GMNoLabel.TabIndex = 9
        GMNoLabel.Text = "Select Demand No.:"
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(247, 8)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(100, 20)
        DateNameLabel.TabIndex = 0
        DateNameLabel.Text = "Transaction Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1584, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Daily Demand Issuance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GMNoComboBox)
        Me.Panel2.Controls.Add(GMNoLabel)
        Me.Panel2.Controls.Add(DateNameLabel)
        Me.Panel2.Controls.Add(Me.DateNameLabel1)
        Me.Panel2.Location = New System.Drawing.Point(282, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(471, 36)
        Me.Panel2.TabIndex = 6
        '
        'GMNoComboBox
        '
        Me.GMNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GMNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GMNoComboBox.DataSource = Me.Tbl_Demand_HeadBindingSource
        Me.GMNoComboBox.DisplayMember = "GMNo"
        Me.GMNoComboBox.FormattingEnabled = True
        Me.GMNoComboBox.Location = New System.Drawing.Point(120, 7)
        Me.GMNoComboBox.Name = "GMNoComboBox"
        Me.GMNoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GMNoComboBox.TabIndex = 10
        Me.GMNoComboBox.ValueMember = "GMNo"
        '
        'Tbl_Demand_HeadBindingSource
        '
        Me.Tbl_Demand_HeadBindingSource.DataMember = "tbl_Demand_Head"
        Me.Tbl_Demand_HeadBindingSource.DataSource = Me.DSdemands
        '
        'DSdemands
        '
        Me.DSdemands.DataSetName = "DSdemands"
        Me.DSdemands.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(353, 8)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DateNameLabel1.TabIndex = 1
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSdemands
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.Color.White
        Me.DayNoLabel1.Location = New System.Drawing.Point(1102, 55)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(38, 23)
        Me.DayNoLabel1.TabIndex = 8
        Me.DayNoLabel1.Text = "Label3"
        '
        'DeptIDDataGridViewTextBoxColumn
        '
        Me.DeptIDDataGridViewTextBoxColumn.DataPropertyName = "DeptID"
        Me.DeptIDDataGridViewTextBoxColumn.HeaderText = "DeptID"
        Me.DeptIDDataGridViewTextBoxColumn.Name = "DeptIDDataGridViewTextBoxColumn"
        '
        'GMNoDataGridViewTextBoxColumn
        '
        Me.GMNoDataGridViewTextBoxColumn.DataPropertyName = "GMNo"
        Me.GMNoDataGridViewTextBoxColumn.HeaderText = "GMNo"
        Me.GMNoDataGridViewTextBoxColumn.Name = "GMNoDataGridViewTextBoxColumn"
        '
        'L4NameDataGridViewTextBoxColumn
        '
        Me.L4NameDataGridViewTextBoxColumn.DataPropertyName = "L4Name"
        Me.L4NameDataGridViewTextBoxColumn.HeaderText = "L4Name"
        Me.L4NameDataGridViewTextBoxColumn.Name = "L4NameDataGridViewTextBoxColumn"
        '
        'RequiredQtyDataGridViewTextBoxColumn
        '
        Me.RequiredQtyDataGridViewTextBoxColumn.DataPropertyName = "RequiredQty"
        Me.RequiredQtyDataGridViewTextBoxColumn.HeaderText = "RequiredQty"
        Me.RequiredQtyDataGridViewTextBoxColumn.Name = "RequiredQtyDataGridViewTextBoxColumn"
        '
        'UOMDataGridViewTextBoxColumn
        '
        Me.UOMDataGridViewTextBoxColumn.DataPropertyName = "UOM"
        Me.UOMDataGridViewTextBoxColumn.HeaderText = "UOM"
        Me.UOMDataGridViewTextBoxColumn.Name = "UOMDataGridViewTextBoxColumn"
        '
        'IssuedQtyDataGridViewTextBoxColumn
        '
        Me.IssuedQtyDataGridViewTextBoxColumn.DataPropertyName = "IssuedQty"
        Me.IssuedQtyDataGridViewTextBoxColumn.HeaderText = "IssuedQty"
        Me.IssuedQtyDataGridViewTextBoxColumn.Name = "IssuedQtyDataGridViewTextBoxColumn"
        '
        'NarrationDataGridViewTextBoxColumn
        '
        Me.NarrationDataGridViewTextBoxColumn.DataPropertyName = "Narration"
        Me.NarrationDataGridViewTextBoxColumn.HeaderText = "Narration"
        Me.NarrationDataGridViewTextBoxColumn.Name = "NarrationDataGridViewTextBoxColumn"
        '
        'PDIDDataGridViewTextBoxColumn
        '
        Me.PDIDDataGridViewTextBoxColumn.DataPropertyName = "PDID"
        Me.PDIDDataGridViewTextBoxColumn.HeaderText = "PDID"
        Me.PDIDDataGridViewTextBoxColumn.Name = "PDIDDataGridViewTextBoxColumn"
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        '
        'PDDateDataGridViewTextBoxColumn
        '
        Me.PDDateDataGridViewTextBoxColumn.DataPropertyName = "PDDate"
        Me.PDDateDataGridViewTextBoxColumn.HeaderText = "PDDate"
        Me.PDDateDataGridViewTextBoxColumn.Name = "PDDateDataGridViewTextBoxColumn"
        '
        'ApprovedStatusDataGridViewCheckBoxColumn
        '
        Me.ApprovedStatusDataGridViewCheckBoxColumn.DataPropertyName = "ApprovedStatus"
        Me.ApprovedStatusDataGridViewCheckBoxColumn.HeaderText = "ApprovedStatus"
        Me.ApprovedStatusDataGridViewCheckBoxColumn.Name = "ApprovedStatusDataGridViewCheckBoxColumn"
        '
        'SpecialNoteDataGridViewTextBoxColumn
        '
        Me.SpecialNoteDataGridViewTextBoxColumn.DataPropertyName = "SpecialNote"
        Me.SpecialNoteDataGridViewTextBoxColumn.HeaderText = "SpecialNote"
        Me.SpecialNoteDataGridViewTextBoxColumn.Name = "SpecialNoteDataGridViewTextBoxColumn"
        '
        'CreationDateDataGridViewTextBoxColumn
        '
        Me.CreationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate"
        Me.CreationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate"
        Me.CreationDateDataGridViewTextBoxColumn.Name = "CreationDateDataGridViewTextBoxColumn"
        '
        'NotificaionStatusDataGridViewCheckBoxColumn
        '
        Me.NotificaionStatusDataGridViewCheckBoxColumn.DataPropertyName = "NotificaionStatus"
        Me.NotificaionStatusDataGridViewCheckBoxColumn.HeaderText = "NotificaionStatus"
        Me.NotificaionStatusDataGridViewCheckBoxColumn.Name = "NotificaionStatusDataGridViewCheckBoxColumn"
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeptNameDataGridViewTextBoxColumn
        '
        Me.DeptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName"
        Me.DeptNameDataGridViewTextBoxColumn.HeaderText = "DeptName"
        Me.DeptNameDataGridViewTextBoxColumn.Name = "DeptNameDataGridViewTextBoxColumn"
        '
        'HODNameDataGridViewTextBoxColumn
        '
        Me.HODNameDataGridViewTextBoxColumn.DataPropertyName = "HODName"
        Me.HODNameDataGridViewTextBoxColumn.HeaderText = "HODName"
        Me.HODNameDataGridViewTextBoxColumn.Name = "HODNameDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Tbl_Demand_HeadBindingNavigator)
        Me.Panel1.Controls.Add(Me.View_New_Demands_BalanceDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(6, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 282)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1058, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ISSUE ALL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Demand_HeadBindingNavigator
        '
        Me.Tbl_Demand_HeadBindingNavigator.AddNewItem = Nothing
        Me.Tbl_Demand_HeadBindingNavigator.BindingSource = Me.View_New_Demands_BalanceBindingSource
        Me.Tbl_Demand_HeadBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Demand_HeadBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Demand_HeadBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Tbl_Demand_HeadBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Demand_HeadBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Demand_HeadBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Demand_HeadBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Demand_HeadBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Demand_HeadBindingNavigator.Name = "Tbl_Demand_HeadBindingNavigator"
        Me.Tbl_Demand_HeadBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Demand_HeadBindingNavigator.Size = New System.Drawing.Size(1198, 25)
        Me.Tbl_Demand_HeadBindingNavigator.TabIndex = 5
        Me.Tbl_Demand_HeadBindingNavigator.Text = "BindingNavigator1"
        '
        'View_New_Demands_BalanceBindingSource
        '
        Me.View_New_Demands_BalanceBindingSource.DataMember = "view_New_Demands_Balance"
        Me.View_New_Demands_BalanceBindingSource.DataSource = Me.DSdemands
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
        'View_New_Demands_BalanceDataGridView
        '
        Me.View_New_Demands_BalanceDataGridView.AllowUserToAddRows = False
        Me.View_New_Demands_BalanceDataGridView.AllowUserToDeleteRows = False
        Me.View_New_Demands_BalanceDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_New_Demands_BalanceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_New_Demands_BalanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_New_Demands_BalanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn3, Me.Action, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn1, Me.Column1, Me.DataGridViewTextBoxColumn5, Me.CPPU, Me.DemandBal, Me.Narration})
        Me.View_New_Demands_BalanceDataGridView.DataSource = Me.View_New_Demands_BalanceBindingSource
        Me.View_New_Demands_BalanceDataGridView.Location = New System.Drawing.Point(1, 28)
        Me.View_New_Demands_BalanceDataGridView.Name = "View_New_Demands_BalanceDataGridView"
        Me.View_New_Demands_BalanceDataGridView.RowHeadersWidth = 11
        Me.View_New_Demands_BalanceDataGridView.Size = New System.Drawing.Size(1196, 251)
        Me.View_New_Demands_BalanceDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PDID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "Serial No."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PDDate"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn10.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DeptName"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Deptartment"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "HODName"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Approved By"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "L4Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'Action
        '
        Me.Action.DataPropertyName = "UOM"
        Me.Action.DataSource = Me.Tbl_Pur_UnitOfMeasurementBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Action.DefaultCellStyle = DataGridViewCellStyle4
        Me.Action.DisplayMember = "UOM"
        Me.Action.DisplayStyleForCurrentCellOnly = True
        Me.Action.HeaderText = "UOM"
        Me.Action.Name = "Action"
        Me.Action.ValueMember = "UOM"
        Me.Action.Width = 65
        '
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataMember = "tbl_Pur_UnitOfMeasurement"
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DSdemands
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RequiredQty"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Request Qty"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Balance"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn14.HeaderText = "Available Balance"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "Issued Qty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DeptID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DeptID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Issued"
        Me.Column1.Name = "Column1"
        Me.Column1.Text = "Issued"
        Me.Column1.ToolTipText = "Issued"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UOM"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.Tbl_Pur_UnitOfMeasurementBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.DisplayMember = "UOM"
        Me.DataGridViewTextBoxColumn5.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "UOM"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'CPPU
        '
        Me.CPPU.DataPropertyName = "CPPU"
        Me.CPPU.HeaderText = "CPPU"
        Me.CPPU.Name = "CPPU"
        Me.CPPU.Visible = False
        '
        'DemandBal
        '
        Me.DemandBal.DataPropertyName = "DemandBal"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DemandBal.DefaultCellStyle = DataGridViewCellStyle9
        Me.DemandBal.HeaderText = "Demand Balance"
        Me.DemandBal.Name = "DemandBal"
        Me.DemandBal.ReadOnly = True
        Me.DemandBal.Width = 65
        '
        'Narration
        '
        Me.Narration.DataPropertyName = "Narration"
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.Visible = False
        '
        'View_New_Demands_BalanceTableAdapter
        '
        Me.View_New_Demands_BalanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSdemandsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Demand_HeadTableAdapter
        '
        Me.Tbl_Demand_HeadTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BindingNavigator1)
        Me.Panel3.Controls.Add(Me.View_Issued_demandsDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(7, 378)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 332)
        Me.Panel3.TabIndex = 10
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.View_Issued_demandsBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton1
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton4
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton3
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton2
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1198, 25)
        Me.BindingNavigator1.TabIndex = 6
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'View_Issued_demandsBindingSource
        '
        Me.View_Issued_demandsBindingSource.DataMember = "View_Issued_demands"
        Me.View_Issued_demandsBindingSource.DataSource = Me.DSdemands
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
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
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'View_Issued_demandsDataGridView
        '
        Me.View_Issued_demandsDataGridView.AllowUserToAddRows = False
        Me.View_Issued_demandsDataGridView.AllowUserToDeleteRows = False
        Me.View_Issued_demandsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_Issued_demandsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.View_Issued_demandsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Issued_demandsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.Column2, Me.TranOutID})
        Me.View_Issued_demandsDataGridView.DataSource = Me.View_Issued_demandsBindingSource
        Me.View_Issued_demandsDataGridView.Location = New System.Drawing.Point(-2, 28)
        Me.View_Issued_demandsDataGridView.Name = "View_Issued_demandsDataGridView"
        Me.View_Issued_demandsDataGridView.RowHeadersWidth = 23
        Me.View_Issued_demandsDataGridView.Size = New System.Drawing.Size(1197, 300)
        Me.View_Issued_demandsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PDDate"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "d"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn7.HeaderText = "Request Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DeptName"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 150
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "HODName"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Approved By"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "L4Name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 250
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "UOM"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn21.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "RequiredQty"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn11.HeaderText = "Required Qty"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 70
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DateName"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Format = "d"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn12.HeaderText = "Issued Date"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "IssuedQty"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn17.HeaderText = "Issued Qty"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Balance"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn18.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Action"
        Me.Column2.Name = "Column2"
        Me.Column2.Text = "Undo"
        Me.Column2.ToolTipText = "Undo"
        Me.Column2.UseColumnTextForButtonValue = True
        '
        'TranOutID
        '
        Me.TranOutID.DataPropertyName = "TranOutID"
        Me.TranOutID.HeaderText = "TranOutID"
        Me.TranOutID.Name = "TranOutID"
        Me.TranOutID.ReadOnly = True
        Me.TranOutID.Visible = False
        '
        'View_Demand_IssuanceBindingSource
        '
        Me.View_Demand_IssuanceBindingSource.DataSource = Me.DSdemands
        Me.View_Demand_IssuanceBindingSource.Position = 0
        '
        'View_Demand_IssuanceTableAdapter
        '
        Me.View_Demand_IssuanceTableAdapter.ClearBeforeFill = True
        '
        'View_Issued_demandsTableAdapter
        '
        Me.View_Issued_demandsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 45)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Demand Type"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(126, 22)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Raw Material"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(30, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "General"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(877, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 10)
        Me.Label3.TabIndex = 6
        '
        'View_New_Demands_Balance_NEWBindingSource
        '
        Me.View_New_Demands_Balance_NEWBindingSource.DataMember = "view_New_Demands_Balance_NEW"
        Me.View_New_Demands_Balance_NEWBindingSource.DataSource = Me.DSdemands
        '
        'View_New_Demands_Balance_NEWTableAdapter
        '
        Me.View_New_Demands_Balance_NEWTableAdapter.ClearBeforeFill = True
        '
        'frmDemandApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1584, 749)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DayNoLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDemandApproval"
        Me.Text = "Daily Demand Approval"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Demand_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSdemands, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Demand_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Demand_HeadBindingNavigator.ResumeLayout(False)
        Me.Tbl_Demand_HeadBindingNavigator.PerformLayout()
        CType(Me.View_New_Demands_BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_New_Demands_BalanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_Issued_demandsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Issued_demandsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Demand_IssuanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.View_New_Demands_Balance_NEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DSdemands As DSdemands
    Friend WithEvents View_New_Demands_BalanceBindingSource As BindingSource
    Friend WithEvents View_New_Demands_BalanceTableAdapter As DSdemandsTableAdapters.view_New_Demands_BalanceTableAdapter
    Friend WithEvents TableAdapterManager As DSdemandsTableAdapters.TableAdapterManager
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As DSdemandsTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents DayNoLabel1 As Label
    Friend WithEvents DeptIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GMNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents L4NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RequiredQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UOMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssuedQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NarrationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApprovedStatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SpecialNoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotificaionStatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeptNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HODNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbl_Demand_HeadBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents View_New_Demands_BalanceDataGridView As DataGridView
    Friend WithEvents Tbl_Demand_HeadBindingSource As BindingSource
    Friend WithEvents Tbl_Demand_HeadTableAdapter As DSdemandsTableAdapters.tbl_Demand_HeadTableAdapter
    Friend WithEvents GMNoComboBox As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents View_Demand_IssuanceBindingSource As BindingSource
    Friend WithEvents View_Demand_IssuanceTableAdapter As DSdemandsTableAdapters.View_Demand_IssuanceTableAdapter
    Friend WithEvents View_Issued_demandsBindingSource As BindingSource
    Friend WithEvents View_Issued_demandsTableAdapter As DSdemandsTableAdapters.View_Issued_demandsTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents View_Issued_demandsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents TranOutID As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As DSdemandsTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents DateNameLabel1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents CPPU As DataGridViewTextBoxColumn
    Friend WithEvents DemandBal As DataGridViewTextBoxColumn
    Friend WithEvents Narration As DataGridViewTextBoxColumn
    Friend WithEvents View_New_Demands_Balance_NEWBindingSource As BindingSource
    Friend WithEvents View_New_Demands_Balance_NEWTableAdapter As DSdemandsTableAdapters.view_New_Demands_Balance_NEWTableAdapter
End Class
