<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticleWiseWestage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticleWiseWestage))
        Me.VIew_MLP_Westage_ArticleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarcusType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintingQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatchQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuttinQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintingMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuttingMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LamProb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompositQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InkQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIew_MLP_Westage_ArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSWestage = New FS_ERP_MM.DSWestage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VIew_MLP_Westage_ArticleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VIew_MLP_Westage_ArticleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.VIew_MLP_Westage_ArticleTableAdapter = New FS_ERP_MM.DSWestageTableAdapters.VIew_MLP_Westage_ArticleTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSWestageTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.VIew_MLP_Westage_ArticleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIew_MLP_Westage_ArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSWestage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.VIew_MLP_Westage_ArticleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VIew_MLP_Westage_ArticleBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'VIew_MLP_Westage_ArticleDataGridView
        '
        Me.VIew_MLP_Westage_ArticleDataGridView.AutoGenerateColumns = False
        Me.VIew_MLP_Westage_ArticleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VIew_MLP_Westage_ArticleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FactoryCode, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.CarcusType, Me.matQty, Me.PrintingQty, Me.MatchQty, Me.CuttinQty, Me.PrintingMat, Me.CuttingMat, Me.LamProb, Me.CompositQty, Me.InkQty, Me.Trail, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn11})
        Me.VIew_MLP_Westage_ArticleDataGridView.DataSource = Me.VIew_MLP_Westage_ArticleBindingSource
        Me.VIew_MLP_Westage_ArticleDataGridView.Location = New System.Drawing.Point(3, 27)
        Me.VIew_MLP_Westage_ArticleDataGridView.Name = "VIew_MLP_Westage_ArticleDataGridView"
        Me.VIew_MLP_Westage_ArticleDataGridView.RowHeadersWidth = 23
        Me.VIew_MLP_Westage_ArticleDataGridView.Size = New System.Drawing.Size(1440, 597)
        Me.VIew_MLP_Westage_ArticleDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DateName"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'FactoryCode
        '
        Me.FactoryCode.DataPropertyName = "FactoryCode"
        Me.FactoryCode.HeaderText = "Factory Code"
        Me.FactoryCode.Name = "FactoryCode"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ArtCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Article Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ArtSize"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'CarcusType
        '
        Me.CarcusType.DataPropertyName = "CarcusType"
        Me.CarcusType.HeaderText = "Prd Type"
        Me.CarcusType.Name = "CarcusType"
        '
        'matQty
        '
        Me.matQty.DataPropertyName = "matQty"
        Me.matQty.HeaderText = "Prd Qty"
        Me.matQty.Name = "matQty"
        Me.matQty.ReadOnly = True
        Me.matQty.Width = 70
        '
        'PrintingQty
        '
        Me.PrintingQty.DataPropertyName = "PrintingQty"
        Me.PrintingQty.HeaderText = "Printing Qty"
        Me.PrintingQty.Name = "PrintingQty"
        Me.PrintingQty.Width = 70
        '
        'MatchQty
        '
        Me.MatchQty.DataPropertyName = "MatchQty"
        Me.MatchQty.HeaderText = "Match Qty"
        Me.MatchQty.Name = "MatchQty"
        Me.MatchQty.ReadOnly = True
        Me.MatchQty.Width = 70
        '
        'CuttinQty
        '
        Me.CuttinQty.DataPropertyName = "CuttinQty"
        Me.CuttinQty.HeaderText = "Cutting Qty"
        Me.CuttinQty.Name = "CuttinQty"
        Me.CuttinQty.Width = 70
        '
        'PrintingMat
        '
        Me.PrintingMat.DataPropertyName = "PrintingMat"
        Me.PrintingMat.HeaderText = "P. Mat Qty"
        Me.PrintingMat.Name = "PrintingMat"
        Me.PrintingMat.ReadOnly = True
        Me.PrintingMat.Width = 70
        '
        'CuttingMat
        '
        Me.CuttingMat.DataPropertyName = "CuttingMat"
        Me.CuttingMat.HeaderText = "C.Mat Qty"
        Me.CuttingMat.Name = "CuttingMat"
        Me.CuttingMat.ReadOnly = True
        Me.CuttingMat.Width = 70
        '
        'LamProb
        '
        Me.LamProb.DataPropertyName = "LamProb"
        Me.LamProb.HeaderText = "Lam. Qty"
        Me.LamProb.Name = "LamProb"
        Me.LamProb.ReadOnly = True
        Me.LamProb.Width = 70
        '
        'CompositQty
        '
        Me.CompositQty.DataPropertyName = "CompositQty"
        Me.CompositQty.HeaderText = "Ink Qty"
        Me.CompositQty.Name = "CompositQty"
        Me.CompositQty.ReadOnly = True
        Me.CompositQty.Width = 70
        '
        'InkQty
        '
        Me.InkQty.DataPropertyName = "InkQty"
        Me.InkQty.HeaderText = "Op Qty"
        Me.InkQty.Name = "InkQty"
        Me.InkQty.ReadOnly = True
        Me.InkQty.Width = 70
        '
        'Trail
        '
        Me.Trail.DataPropertyName = "Trail"
        Me.Trail.HeaderText = "Trail Qty"
        Me.Trail.Name = "Trail"
        Me.Trail.ReadOnly = True
        Me.Trail.Width = 70
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CrushStatus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Crush Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CrushDate"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'VIew_MLP_Westage_ArticleBindingSource
        '
        Me.VIew_MLP_Westage_ArticleBindingSource.DataMember = "VIew_MLP_Westage_Article"
        Me.VIew_MLP_Westage_ArticleBindingSource.DataSource = Me.DSWestage
        '
        'DSWestage
        '
        Me.DSWestage.DataSetName = "DSWestage"
        Me.DSWestage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.VIew_MLP_Westage_ArticleBindingNavigator)
        Me.Panel1.Controls.Add(Me.VIew_MLP_Westage_ArticleDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1448, 630)
        Me.Panel1.TabIndex = 3
        '
        'VIew_MLP_Westage_ArticleBindingNavigator
        '
        Me.VIew_MLP_Westage_ArticleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VIew_MLP_Westage_ArticleBindingNavigator.BindingSource = Me.VIew_MLP_Westage_ArticleBindingSource
        Me.VIew_MLP_Westage_ArticleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VIew_MLP_Westage_ArticleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VIew_MLP_Westage_ArticleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VIew_MLP_Westage_ArticleBindingNavigatorSaveItem})
        Me.VIew_MLP_Westage_ArticleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VIew_MLP_Westage_ArticleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VIew_MLP_Westage_ArticleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VIew_MLP_Westage_ArticleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VIew_MLP_Westage_ArticleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VIew_MLP_Westage_ArticleBindingNavigator.Name = "VIew_MLP_Westage_ArticleBindingNavigator"
        Me.VIew_MLP_Westage_ArticleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VIew_MLP_Westage_ArticleBindingNavigator.Size = New System.Drawing.Size(1446, 25)
        Me.VIew_MLP_Westage_ArticleBindingNavigator.TabIndex = 3
        Me.VIew_MLP_Westage_ArticleBindingNavigator.Text = "BindingNavigator1"
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
        'VIew_MLP_Westage_ArticleBindingNavigatorSaveItem
        '
        Me.VIew_MLP_Westage_ArticleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VIew_MLP_Westage_ArticleBindingNavigatorSaveItem.Image = CType(resources.GetObject("VIew_MLP_Westage_ArticleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VIew_MLP_Westage_ArticleBindingNavigatorSaveItem.Name = "VIew_MLP_Westage_ArticleBindingNavigatorSaveItem"
        Me.VIew_MLP_Westage_ArticleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VIew_MLP_Westage_ArticleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1472, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "B Grade Articel Wise Wastage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 60)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date and Factory Code  Selection"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(463, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Factory Code :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"B34001", "B34002", "B34003", "B34004", "B34005"})
        Me.ComboBox1.Location = New System.Drawing.Point(570, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 53
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(315, 25)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(142, 23)
        Me.DateTimePicker2.TabIndex = 50
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(142, 23)
        Me.DateTimePicker1.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(243, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "To Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "From Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(720, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 50)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Crush Status"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(100, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Disabled"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Enabled"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'VIew_MLP_Westage_ArticleTableAdapter
        '
        Me.VIew_MLP_Westage_ArticleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSWestageTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        'Me.TableAdapterManager.VIew_MLP_Westage_ArticleTableAdapter = Nothing
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(928, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 43)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Show Gate Pass"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmArticleWiseWestage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 759)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmArticleWiseWestage"
        Me.Text = "FrmArticleWiseWestage"
        CType(Me.VIew_MLP_Westage_ArticleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIew_MLP_Westage_ArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSWestage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.VIew_MLP_Westage_ArticleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VIew_MLP_Westage_ArticleBindingNavigator.ResumeLayout(False)
        Me.VIew_MLP_Westage_ArticleBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSWestage As DSWestage
    Friend WithEvents VIew_MLP_Westage_ArticleBindingSource As BindingSource
    Friend WithEvents VIew_MLP_Westage_ArticleTableAdapter As DSWestageTableAdapters.VIew_MLP_Westage_ArticleTableAdapter
    Friend WithEvents TableAdapterManager As DSWestageTableAdapters.TableAdapterManager
    Friend WithEvents VIew_MLP_Westage_ArticleDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents VIew_MLP_Westage_ArticleBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents VIew_MLP_Westage_ArticleBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FactoryCode As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CarcusType As DataGridViewTextBoxColumn
    Friend WithEvents matQty As DataGridViewTextBoxColumn
    Friend WithEvents PrintingQty As DataGridViewTextBoxColumn
    Friend WithEvents MatchQty As DataGridViewTextBoxColumn
    Friend WithEvents CuttinQty As DataGridViewTextBoxColumn
    Friend WithEvents PrintingMat As DataGridViewTextBoxColumn
    Friend WithEvents CuttingMat As DataGridViewTextBoxColumn
    Friend WithEvents LamProb As DataGridViewTextBoxColumn
    Friend WithEvents CompositQty As DataGridViewTextBoxColumn
    Friend WithEvents InkQty As DataGridViewTextBoxColumn
    Friend WithEvents Trail As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
