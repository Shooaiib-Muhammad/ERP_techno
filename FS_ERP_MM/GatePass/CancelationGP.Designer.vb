<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelationGP
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
        Dim Label10 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim PurposeLabel As System.Windows.Forms.Label
        Dim CarryingPersonLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim EnteryDateLabel As System.Windows.Forms.Label
        Dim GMNoLabel As System.Windows.Forms.Label
        Dim LocalCustIDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CancelationGP))
        Me.DSLocalPur = New FS_ERP_MM.DSLocalPur()
        Me.Tbl_Mat_GatePass2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Mat_GatePass2TableAdapter = New FS_ERP_MM.DSLocalPurTableAdapters.tbl_Mat_GatePass2TableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSLocalPurTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PurposeTextBox = New System.Windows.Forms.TextBox()
        Me.CarryingPersonTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.GMNoLabel4 = New System.Windows.Forms.Label()
        Me.EnteryDateLabel1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchByGPNOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Label10 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        PurposeLabel = New System.Windows.Forms.Label()
        CarryingPersonLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        EnteryDateLabel = New System.Windows.Forms.Label()
        GMNoLabel = New System.Windows.Forms.Label()
        LocalCustIDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DSLocalPur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Mat_GatePass2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Label10.Location = New System.Drawing.Point(352, 87)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(86, 20)
        Label10.TabIndex = 25
        Label10.Text = "Receiver Name:"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Label9.Location = New System.Drawing.Point(7, 87)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(85, 20)
        Label9.TabIndex = 23
        Label9.Text = "Sender Name:"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(352, 62)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 20)
        Label5.TabIndex = 21
        Label5.Text = "Vehicle No.:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PurposeLabel
        '
        PurposeLabel.Location = New System.Drawing.Point(587, 62)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(66, 20)
        PurposeLabel.TabIndex = 19
        PurposeLabel.Text = "Purpose:"
        PurposeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CarryingPersonLabel
        '
        CarryingPersonLabel.Location = New System.Drawing.Point(7, 62)
        CarryingPersonLabel.Name = "CarryingPersonLabel"
        CarryingPersonLabel.Size = New System.Drawing.Size(85, 20)
        CarryingPersonLabel.TabIndex = 18
        CarryingPersonLabel.Text = "Carrying Person:"
        CarryingPersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomerLabel
        '
        CustomerLabel.Location = New System.Drawing.Point(587, 35)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(66, 20)
        CustomerLabel.TabIndex = 17
        CustomerLabel.Text = "Party Name:"
        CustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EnteryDateLabel
        '
        EnteryDateLabel.Location = New System.Drawing.Point(179, 35)
        EnteryDateLabel.Name = "EnteryDateLabel"
        EnteryDateLabel.Size = New System.Drawing.Size(68, 20)
        EnteryDateLabel.TabIndex = 3
        EnteryDateLabel.Text = "Entery Date:"
        EnteryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GMNoLabel
        '
        GMNoLabel.Location = New System.Drawing.Point(7, 35)
        GMNoLabel.Name = "GMNoLabel"
        GMNoLabel.Size = New System.Drawing.Size(85, 20)
        GMNoLabel.TabIndex = 0
        GMNoLabel.Text = "Gate Pass No.:"
        GMNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LocalCustIDLabel
        '
        LocalCustIDLabel.Location = New System.Drawing.Point(352, 35)
        LocalCustIDLabel.Name = "LocalCustIDLabel"
        LocalCustIDLabel.Size = New System.Drawing.Size(86, 20)
        LocalCustIDLabel.TabIndex = 14
        LocalCustIDLabel.Text = "Gate Pass Type:"
        LocalCustIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(7, 114)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(85, 20)
        Label1.TabIndex = 29
        Label1.Text = "Status :"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(361, 15)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(86, 20)
        Label2.TabIndex = 34
        Label2.Text = "Gate Pass Type:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DSLocalPur
        '
        Me.DSLocalPur.DataSetName = "DSLocalPur"
        Me.DSLocalPur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Mat_GatePass2BindingSource
        '
        Me.Tbl_Mat_GatePass2BindingSource.DataMember = "tbl_Mat_GatePass2"
        Me.Tbl_Mat_GatePass2BindingSource.DataSource = Me.DSLocalPur
        '
        'Tbl_Mat_GatePass2TableAdapter
        '
        Me.Tbl_Mat_GatePass2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Mat_GatePass_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_GatePass2TableAdapter = Me.Tbl_Mat_GatePass2TableAdapter
        Me.TableAdapterManager.tbl_Mat_GatePassTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSLocalPurTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        'Me.TableAdapterManager.View_GatePass_NewTableAdapter = Nothing
        Me.TableAdapterManager.View_Mat_GatePassTableAdapter = Nothing
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Label10)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Label9)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(PurposeLabel)
        Me.Panel2.Controls.Add(Me.PurposeTextBox)
        Me.Panel2.Controls.Add(CarryingPersonLabel)
        Me.Panel2.Controls.Add(Me.CarryingPersonTextBox)
        Me.Panel2.Controls.Add(CustomerLabel)
        Me.Panel2.Controls.Add(Me.CustomerTextBox)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.GMNoLabel4)
        Me.Panel2.Controls.Add(EnteryDateLabel)
        Me.Panel2.Controls.Add(Me.EnteryDateLabel1)
        Me.Panel2.Controls.Add(GMNoLabel)
        Me.Panel2.Controls.Add(LocalCustIDLabel)
        Me.Panel2.Location = New System.Drawing.Point(12, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 176)
        Me.Panel2.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(800, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 36)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "Status", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Active", "Cancel"})
        Me.ComboBox1.Location = New System.Drawing.Point(92, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "Type", True))
        Me.TextBox4.Location = New System.Drawing.Point(439, 36)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(142, 20)
        Me.TextBox4.TabIndex = 27
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "ReceiverName", True))
        Me.TextBox3.Location = New System.Drawing.Point(440, 87)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(516, 20)
        Me.TextBox3.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "SenderName", True))
        Me.TextBox2.Location = New System.Drawing.Point(92, 87)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 20)
        Me.TextBox2.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "VehicleNo", True))
        Me.TextBox1.Location = New System.Drawing.Point(440, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "Purpose", True))
        Me.PurposeTextBox.Location = New System.Drawing.Point(653, 62)
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(303, 20)
        Me.PurposeTextBox.TabIndex = 20
        '
        'CarryingPersonTextBox
        '
        Me.CarryingPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "CarryingPerson", True))
        Me.CarryingPersonTextBox.Location = New System.Drawing.Point(92, 62)
        Me.CarryingPersonTextBox.Name = "CarryingPersonTextBox"
        Me.CarryingPersonTextBox.Size = New System.Drawing.Size(256, 20)
        Me.CarryingPersonTextBox.TabIndex = 19
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(653, 35)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(303, 20)
        Me.CustomerTextBox.TabIndex = 18
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Mat_GatePass2BindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.toolStripSeparator})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(972, 25)
        Me.BindingNavigator1.TabIndex = 15
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'GMNoLabel4
        '
        Me.GMNoLabel4.BackColor = System.Drawing.Color.Bisque
        Me.GMNoLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GMNoLabel4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "GPNo", True))
        Me.GMNoLabel4.Location = New System.Drawing.Point(92, 35)
        Me.GMNoLabel4.Name = "GMNoLabel4"
        Me.GMNoLabel4.Size = New System.Drawing.Size(74, 20)
        Me.GMNoLabel4.TabIndex = 0
        Me.GMNoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnteryDateLabel1
        '
        Me.EnteryDateLabel1.BackColor = System.Drawing.Color.White
        Me.EnteryDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EnteryDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Mat_GatePass2BindingSource, "EnteryDate", True))
        Me.EnteryDateLabel1.Location = New System.Drawing.Point(248, 35)
        Me.EnteryDateLabel1.Name = "EnteryDateLabel1"
        Me.EnteryDateLabel1.Size = New System.Drawing.Size(100, 20)
        Me.EnteryDateLabel1.TabIndex = 1
        Me.EnteryDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Location = New System.Drawing.Point(12, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 44)
        Me.Panel1.TabIndex = 36
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"OUTWARD", "RETURNABLE"})
        Me.ComboBox2.Location = New System.Drawing.Point(453, 14)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 36
        Me.ComboBox2.Text = "OUTWARD"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Select Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(188, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Select Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(260, 15)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker2.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1039, 40)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Gate Pass Cancellation"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchByGPNOToolStripMenuItem, Me.RemoveFilterToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 48)
        '
        'SearchByGPNOToolStripMenuItem
        '
        Me.SearchByGPNOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.SearchByGPNOToolStripMenuItem.Name = "SearchByGPNOToolStripMenuItem"
        Me.SearchByGPNOToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SearchByGPNOToolStripMenuItem.Text = "Search By GP NO."
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove Filter"
        '
        'CancelationGP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 567)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "CancelationGP"
        Me.Text = "Gate Pass Cancellation"
        CType(Me.DSLocalPur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Mat_GatePass2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSLocalPur As DSLocalPur
    Friend WithEvents Tbl_Mat_GatePass2BindingSource As BindingSource
    Friend WithEvents Tbl_Mat_GatePass2TableAdapter As DSLocalPurTableAdapters.tbl_Mat_GatePass2TableAdapter
    Friend WithEvents TableAdapterManager As DSLocalPurTableAdapters.TableAdapterManager
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PurposeTextBox As TextBox
    Friend WithEvents CarryingPersonTextBox As TextBox
    Friend WithEvents CustomerTextBox As TextBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents GMNoLabel4 As Label
    Friend WithEvents EnteryDateLabel1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SearchByGPNOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As ToolStripMenuItem
End Class
