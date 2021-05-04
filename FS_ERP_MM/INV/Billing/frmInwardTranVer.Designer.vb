<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInwardTranVer
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
        Dim MiddleSerialLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim DriverIDLabel As System.Windows.Forms.Label
        Dim MakerLabel As System.Windows.Forms.Label
        Dim TranOutIDLabel As System.Windows.Forms.Label
        Dim BilltyNoLabel As System.Windows.Forms.Label
        Dim INOUTLabel As System.Windows.Forms.Label
        Dim BILLLabel As System.Windows.Forms.Label
        Dim VehicleNOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInwardTranVer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tbl_Sec_MiddleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Sec_Vehicle_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMisSec = New FS_ERP_MM.DSMisSec()
        Me.Tbl_Sec_EnteriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BilltyNoTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleSerialLabel1 = New System.Windows.Forms.Label()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Sec_EnteriesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerifyStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VerifyDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_Sec_Vehicle_HeadTableAdapter = New FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_Vehicle_HeadTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSMisSecTableAdapters.TableAdapterManager()
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.DSMisSecTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.Tbl_Sec_DeptTableAdapter = New FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_DeptTableAdapter()
        Me.Tbl_Sec_DriverTableAdapter = New FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_DriverTableAdapter()
        Me.Tbl_Sec_EnteriesTableAdapter = New FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_EnteriesTableAdapter()
        Me.Tbl_Sec_MakerTableAdapter = New FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_MakerTableAdapter()
        Me.Tbl_Sec_OutRegNoTableAdapter = New FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_OutRegNoTableAdapter()
        Me.Tbl_Sec_VehicleTableAdapter = New FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_VehicleTableAdapter()
        Me.Tbl_Sec_MiddleTableAdapter = New FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_MiddleTableAdapter()
        Me.Tbl_Sec_DriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Sec_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Sec_MakerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Sec_VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Sec_OutRegNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        DateNameLabel = New System.Windows.Forms.Label()
        MiddleSerialLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        DriverIDLabel = New System.Windows.Forms.Label()
        MakerLabel = New System.Windows.Forms.Label()
        TranOutIDLabel = New System.Windows.Forms.Label()
        BilltyNoLabel = New System.Windows.Forms.Label()
        INOUTLabel = New System.Windows.Forms.Label()
        BILLLabel = New System.Windows.Forms.Label()
        VehicleNOLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_Sec_MiddleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_Vehicle_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMisSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_EnteriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.Tbl_Sec_EnteriesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_DriverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_MakerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Sec_OutRegNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateNameLabel
        '
        DateNameLabel.Location = New System.Drawing.Point(4, 32)
        DateNameLabel.Name = "DateNameLabel"
        DateNameLabel.Size = New System.Drawing.Size(100, 20)
        DateNameLabel.TabIndex = 0
        DateNameLabel.Text = "Transaction Date:"
        DateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MiddleSerialLabel
        '
        MiddleSerialLabel.AutoSize = True
        MiddleSerialLabel.Location = New System.Drawing.Point(4, 32)
        MiddleSerialLabel.Name = "MiddleSerialLabel"
        MiddleSerialLabel.Size = New System.Drawing.Size(47, 13)
        MiddleSerialLabel.TabIndex = 26
        MiddleSerialLabel.Text = "Reg No:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.Location = New System.Drawing.Point(462, 32)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 25
        DepartmentLabel.Text = "Department:"
        DepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DriverIDLabel
        '
        DriverIDLabel.Location = New System.Drawing.Point(4, 81)
        DriverIDLabel.Name = "DriverIDLabel"
        DriverIDLabel.Size = New System.Drawing.Size(69, 13)
        DriverIDLabel.TabIndex = 24
        DriverIDLabel.Text = "Driver Name:"
        DriverIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MakerLabel
        '
        MakerLabel.Location = New System.Drawing.Point(206, 32)
        MakerLabel.Name = "MakerLabel"
        MakerLabel.Size = New System.Drawing.Size(75, 13)
        MakerLabel.TabIndex = 22
        MakerLabel.Text = "Maker/ Party:"
        MakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranOutIDLabel
        '
        TranOutIDLabel.Location = New System.Drawing.Point(658, 57)
        TranOutIDLabel.Name = "TranOutIDLabel"
        TranOutIDLabel.Size = New System.Drawing.Size(60, 13)
        TranOutIDLabel.TabIndex = 80
        TranOutIDLabel.Text = "Reg Out #:"
        TranOutIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BilltyNoLabel
        '
        BilltyNoLabel.Location = New System.Drawing.Point(479, 57)
        BilltyNoLabel.Name = "BilltyNoLabel"
        BilltyNoLabel.Size = New System.Drawing.Size(48, 13)
        BilltyNoLabel.TabIndex = 79
        BilltyNoLabel.Text = "Bility No:"
        BilltyNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'INOUTLabel
        '
        INOUTLabel.Location = New System.Drawing.Point(823, 32)
        INOUTLabel.Name = "INOUTLabel"
        INOUTLabel.Size = New System.Drawing.Size(93, 13)
        INOUTLabel.TabIndex = 78
        INOUTLabel.Text = "Transaction Type:"
        INOUTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BILLLabel
        '
        BILLLabel.Location = New System.Drawing.Point(221, 57)
        BILLLabel.Name = "BILLLabel"
        BILLLabel.Size = New System.Drawing.Size(60, 13)
        BILLLabel.TabIndex = 77
        BILLLabel.Text = "Doc. No.:"
        BILLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VehicleNOLabel
        '
        VehicleNOLabel.AutoSize = True
        VehicleNOLabel.Location = New System.Drawing.Point(4, 57)
        VehicleNOLabel.Name = "VehicleNOLabel"
        VehicleNOLabel.Size = New System.Drawing.Size(55, 13)
        VehicleNOLabel.TabIndex = 75
        VehicleNOLabel.Text = "Vehicle #:"
        '
        'Tbl_Sec_MiddleBindingSource
        '
        Me.Tbl_Sec_MiddleBindingSource.DataMember = "tbl_Sec_Vehicle_Head_tbl_Sec_Middle"
        Me.Tbl_Sec_MiddleBindingSource.DataSource = Me.Tbl_Sec_Vehicle_HeadBindingSource
        '
        'Tbl_Sec_Vehicle_HeadBindingSource
        '
        Me.Tbl_Sec_Vehicle_HeadBindingSource.DataMember = "tbl_Sec_Vehicle_Head"
        Me.Tbl_Sec_Vehicle_HeadBindingSource.DataSource = Me.DSMisSec
        '
        'DSMisSec
        '
        Me.DSMisSec.DataSetName = "DSMisSec"
        Me.DSMisSec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Sec_EnteriesBindingSource
        '
        Me.Tbl_Sec_EnteriesBindingSource.DataMember = "tbl_Sec_Middle_tbl_Sec_Enteries"
        Me.Tbl_Sec_EnteriesBindingSource.DataSource = Me.Tbl_Sec_MiddleBindingSource
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DayNoLabel1)
        Me.Panel3.Controls.Add(Me.BindingNavigator1)
        Me.Panel3.Controls.Add(DateNameLabel)
        Me.Panel3.Controls.Add(Me.DateNameLabel1)
        Me.Panel3.Location = New System.Drawing.Point(3, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(282, 64)
        Me.Panel3.TabIndex = 14
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_Vehicle_HeadBindingSource, "VehicleHead", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DayNoLabel1.Location = New System.Drawing.Point(225, 36)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(36, 10)
        Me.DayNoLabel1.TabIndex = 6
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Sec_Vehicle_HeadBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripSeparator6})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton8
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton11
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton10
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton9
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator1.Size = New System.Drawing.Size(280, 25)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Move first"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Move next"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_Vehicle_HeadBindingSource, "VehicleDate", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(110, 32)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DateNameLabel1.TabIndex = 1
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1347, 40)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Items Inward Verification"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(TranOutIDLabel)
        Me.Panel1.Controls.Add(BilltyNoLabel)
        Me.Panel1.Controls.Add(Me.BilltyNoTextBox)
        Me.Panel1.Controls.Add(INOUTLabel)
        Me.Panel1.Controls.Add(BILLLabel)
        Me.Panel1.Controls.Add(VehicleNOLabel)
        Me.Panel1.Controls.Add(MiddleSerialLabel)
        Me.Panel1.Controls.Add(Me.MiddleSerialLabel1)
        Me.Panel1.Controls.Add(DepartmentLabel)
        Me.Panel1.Controls.Add(DriverIDLabel)
        Me.Panel1.Controls.Add(MakerLabel)
        Me.Panel1.Controls.Add(Me.BindingNavigator2)
        Me.Panel1.Location = New System.Drawing.Point(3, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1053, 107)
        Me.Panel1.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_MiddleBindingSource, "BILL", True))
        Me.Label8.Location = New System.Drawing.Point(287, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 20)
        Me.Label8.TabIndex = 87
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_MiddleBindingSource, "Vehicle", True))
        Me.Label7.Location = New System.Drawing.Point(72, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 20)
        Me.Label7.TabIndex = 86
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_MiddleBindingSource, "Maker", True))
        Me.Label6.Location = New System.Drawing.Point(287, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 20)
        Me.Label6.TabIndex = 85
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_MiddleBindingSource, "DriverName", True))
        Me.Label5.Location = New System.Drawing.Point(72, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(382, 20)
        Me.Label5.TabIndex = 84
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_MiddleBindingSource, "Department", True))
        Me.Label4.Location = New System.Drawing.Point(528, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_MiddleBindingSource, "INOUT", True))
        Me.Label3.Location = New System.Drawing.Point(917, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 82
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_MiddleBindingSource, "TranOutID", True))
        Me.Label2.Location = New System.Drawing.Point(724, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 81
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BilltyNoTextBox
        '
        Me.BilltyNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_MiddleBindingSource, "BilltyNo", True))
        Me.BilltyNoTextBox.Location = New System.Drawing.Point(528, 54)
        Me.BilltyNoTextBox.Name = "BilltyNoTextBox"
        Me.BilltyNoTextBox.Size = New System.Drawing.Size(115, 20)
        Me.BilltyNoTextBox.TabIndex = 76
        Me.BilltyNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiddleSerialLabel1
        '
        Me.MiddleSerialLabel1.BackColor = System.Drawing.Color.White
        Me.MiddleSerialLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiddleSerialLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Sec_MiddleBindingSource, "MiddleSerial", True))
        Me.MiddleSerialLabel1.Location = New System.Drawing.Point(72, 29)
        Me.MiddleSerialLabel1.Name = "MiddleSerialLabel1"
        Me.MiddleSerialLabel1.Size = New System.Drawing.Size(130, 20)
        Me.MiddleSerialLabel1.TabIndex = 27
        Me.MiddleSerialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.Tbl_Sec_MiddleBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton12, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator2.Size = New System.Drawing.Size(1051, 25)
        Me.BindingNavigator2.TabIndex = 19
        Me.BindingNavigator2.Text = "BindingNavigator2"
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
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Add new"
        Me.ToolStripButton12.Visible = False
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator3)
        Me.Panel2.Controls.Add(Me.Tbl_Sec_EnteriesDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(3, 219)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1054, 373)
        Me.Panel2.TabIndex = 17
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator3.BindingSource = Me.Tbl_Sec_EnteriesBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator3.DeleteItem = Me.ToolStripButton2
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton7})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator3.Size = New System.Drawing.Size(1052, 25)
        Me.BindingNavigator3.TabIndex = 20
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        Me.ToolStripButton1.Visible = False
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
        Me.ToolStripButton2.Text = "Delete"
        Me.ToolStripButton2.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
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
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "&Save"
        '
        'Tbl_Sec_EnteriesDataGridView
        '
        Me.Tbl_Sec_EnteriesDataGridView.AllowUserToAddRows = False
        Me.Tbl_Sec_EnteriesDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_Sec_EnteriesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Sec_EnteriesDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Sec_EnteriesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_Sec_EnteriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Sec_EnteriesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.VerifyStatus, Me.VerifyDate})
        Me.Tbl_Sec_EnteriesDataGridView.DataSource = Me.Tbl_Sec_EnteriesBindingSource
        Me.Tbl_Sec_EnteriesDataGridView.Location = New System.Drawing.Point(1, 27)
        Me.Tbl_Sec_EnteriesDataGridView.Name = "Tbl_Sec_EnteriesDataGridView"
        Me.Tbl_Sec_EnteriesDataGridView.Size = New System.Drawing.Size(1050, 342)
        Me.Tbl_Sec_EnteriesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VehicleHead"
        Me.DataGridViewTextBoxColumn1.HeaderText = "VehicleHead"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MiddleSerial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MiddleSerial"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EnterySerial"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sr. No."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Item"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quantity"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Units"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "Units"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TransTime"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "Trans Time"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Remarks"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn7.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 250
        '
        'VerifyStatus
        '
        Me.VerifyStatus.DataPropertyName = "VerifyStatus"
        Me.VerifyStatus.HeaderText = "Verify Status"
        Me.VerifyStatus.Name = "VerifyStatus"
        Me.VerifyStatus.Width = 60
        '
        'VerifyDate
        '
        Me.VerifyDate.DataPropertyName = "VerifyDate"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "d"
        Me.VerifyDate.DefaultCellStyle = DataGridViewCellStyle9
        Me.VerifyDate.HeaderText = "Verify Date"
        Me.VerifyDate.Name = "VerifyDate"
        Me.VerifyDate.Width = 80
        '
        'Tbl_Sec_Vehicle_HeadTableAdapter
        '
        Me.Tbl_Sec_Vehicle_HeadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Me.Tbl_Pur_UnitOfMeasurementTableAdapter
        Me.TableAdapterManager.tbl_Sec_DeptTableAdapter = Me.Tbl_Sec_DeptTableAdapter
        Me.TableAdapterManager.tbl_Sec_DriverTableAdapter = Me.Tbl_Sec_DriverTableAdapter
        Me.TableAdapterManager.tbl_Sec_Enteries_outTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Sec_EnteriesTableAdapter = Me.Tbl_Sec_EnteriesTableAdapter
        Me.TableAdapterManager.tbl_Sec_MakerTableAdapter = Me.Tbl_Sec_MakerTableAdapter
        Me.TableAdapterManager.tbl_Sec_Middle_outTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Sec_OutRegNoTableAdapter = Me.Tbl_Sec_OutRegNoTableAdapter
        Me.TableAdapterManager.tbl_Sec_Vehicle_EnteriesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Sec_Vehicle_HeadTableAdapter = Me.Tbl_Sec_Vehicle_HeadTableAdapter
        Me.TableAdapterManager.tbl_Sec_VehicleTableAdapter = Me.Tbl_Sec_VehicleTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSMisSecTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_DeptTableAdapter
        '
        Me.Tbl_Sec_DeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_DriverTableAdapter
        '
        Me.Tbl_Sec_DriverTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_EnteriesTableAdapter
        '
        Me.Tbl_Sec_EnteriesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_MakerTableAdapter
        '
        Me.Tbl_Sec_MakerTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_OutRegNoTableAdapter
        '
        Me.Tbl_Sec_OutRegNoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_VehicleTableAdapter
        '
        Me.Tbl_Sec_VehicleTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_MiddleTableAdapter
        '
        Me.Tbl_Sec_MiddleTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Sec_DriverBindingSource
        '
        Me.Tbl_Sec_DriverBindingSource.DataMember = "tbl_Sec_Driver"
        Me.Tbl_Sec_DriverBindingSource.DataSource = Me.DSMisSec
        '
        'Tbl_Sec_DeptBindingSource
        '
        Me.Tbl_Sec_DeptBindingSource.DataMember = "tbl_Sec_Dept"
        Me.Tbl_Sec_DeptBindingSource.DataSource = Me.DSMisSec
        '
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataMember = "tbl_Pur_UnitOfMeasurement"
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DSMisSec
        '
        'Tbl_Sec_MakerBindingSource
        '
        Me.Tbl_Sec_MakerBindingSource.DataMember = "tbl_Sec_Maker"
        Me.Tbl_Sec_MakerBindingSource.DataSource = Me.DSMisSec
        '
        'Tbl_Sec_VehicleBindingSource
        '
        Me.Tbl_Sec_VehicleBindingSource.DataMember = "tbl_Sec_Vehicle"
        Me.Tbl_Sec_VehicleBindingSource.DataSource = Me.DSMisSec
        '
        'Tbl_Sec_OutRegNoBindingSource
        '
        Me.Tbl_Sec_OutRegNoBindingSource.DataMember = "tbl_Sec_OutRegNo"
        Me.Tbl_Sec_OutRegNoBindingSource.DataSource = Me.DSMisSec
        '
        'frmInwardTranVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 672)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frmInwardTranVer"
        Me.Text = "Items Inward Verification"
        CType(Me.Tbl_Sec_MiddleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_Vehicle_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMisSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_EnteriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.Tbl_Sec_EnteriesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_DriverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_MakerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Sec_OutRegNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSMisSec As FS_ERP_MM.DSMisSec
    Friend WithEvents Tbl_Sec_Vehicle_HeadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Sec_Vehicle_HeadTableAdapter As FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_Vehicle_HeadTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSMisSecTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Sec_MiddleTableAdapter As FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_MiddleTableAdapter
    Friend WithEvents Tbl_Sec_MiddleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Sec_EnteriesTableAdapter As FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_EnteriesTableAdapter
    Friend WithEvents Tbl_Sec_EnteriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Sec_DriverTableAdapter As FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_DriverTableAdapter
    Friend WithEvents Tbl_Sec_DriverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Sec_DeptTableAdapter As FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_DeptTableAdapter
    Friend WithEvents Tbl_Sec_DeptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As FS_ERP_MM.DSMisSecTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Sec_MakerTableAdapter As FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_MakerTableAdapter
    Friend WithEvents Tbl_Sec_MakerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Sec_VehicleTableAdapter As FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_VehicleTableAdapter
    Friend WithEvents Tbl_Sec_VehicleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Sec_OutRegNoTableAdapter As FS_ERP_MM.DSMisSecTableAdapters.tbl_Sec_OutRegNoTableAdapter
    Friend WithEvents Tbl_Sec_OutRegNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DayNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BilltyNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleSerialLabel1 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Tbl_Sec_EnteriesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator3 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerifyStatus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VerifyDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
