<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRRN
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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim SIDLabel As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim TranInIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRRN))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DSPRGP = New FS_ERP_MM.DSPRGP()
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New FS_ERP_MM.DSPRGPTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSPRGPTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_Tran_InTableAdapter = New FS_ERP_MM.DSPRGPTableAdapters.tbl_Inv_Tran_InTableAdapter()
        Me.Tbl_Inv_Tran_InBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Lended_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Lended_DTableAdapter = New FS_ERP_MM.DSPRGPTableAdapters.View_Lended_DTableAdapter()
        Me.View_Lended_MBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Lended_MTableAdapter = New FS_ERP_MM.DSPRGPTableAdapters.View_Lended_MTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DayNoLabel2 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_Tran_DateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateNameLabel1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelTranOutID = New System.Windows.Forms.Label()
        Me.RackNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TrandocNoLabel1 = New System.Windows.Forms.Label()
        Me.ExCustIdLabel1 = New System.Windows.Forms.Label()
        Me.CPPULabel1 = New System.Windows.Forms.Label()
        Me.CurrencyLabel1 = New System.Windows.Forms.Label()
        Me.TranOutIDLabel2 = New System.Windows.Forms.Label()
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
        Me.AddIn = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveIn = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoIn = New System.Windows.Forms.ToolStripButton()
        Me.TranInIDLabel1 = New System.Windows.Forms.Label()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.View_Lended_DDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtCustID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DSMat_Brow = New FS_ERP_MM.DSMat_Brow()
        Me.Tbl_Inv_Rack_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Rack_InfoTableAdapter = New FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Rack_InfoTableAdapter()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        SIDLabel = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        TranInIDLabel = New System.Windows.Forms.Label()
        CType(Me.DSPRGP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Lended_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Lended_MBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_Lended_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMat_Brow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(19, 32)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(100, 20)
        Label5.TabIndex = 0
        Label5.Text = "Transaction Date:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(4, 82)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(77, 20)
        Label3.TabIndex = 45
        Label3.Text = "Rack No.:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QtyLabel
        '
        QtyLabel.Location = New System.Drawing.Point(4, 130)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(77, 20)
        QtyLabel.TabIndex = 31
        QtyLabel.Text = "Qty:"
        QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SIDLabel
        '
        SIDLabel.Location = New System.Drawing.Point(4, 106)
        SIDLabel.Name = "SIDLabel"
        SIDLabel.Size = New System.Drawing.Size(77, 20)
        SIDLabel.TabIndex = 29
        SIDLabel.Text = "Tran Out No.:"
        SIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameLabel
        '
        L4NameLabel.Location = New System.Drawing.Point(4, 58)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(77, 20)
        L4NameLabel.TabIndex = 2
        L4NameLabel.Text = "Material:"
        L4NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TranInIDLabel
        '
        TranInIDLabel.Location = New System.Drawing.Point(4, 33)
        TranInIDLabel.Name = "TranInIDLabel"
        TranInIDLabel.Size = New System.Drawing.Size(77, 20)
        TranInIDLabel.TabIndex = 0
        TranInIDLabel.Text = "S. No.:"
        TranInIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DSPRGP
        '
        Me.DSPRGP.DataSetName = "DSPRGP"
        Me.DSPRGP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSPRGP
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Me.Tbl_Inv_Tran_DateTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_InTableAdapter = Me.Tbl_Inv_Tran_InTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSPRGPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_Tran_InTableAdapter
        '
        Me.Tbl_Inv_Tran_InTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_InBindingSource
        '
        Me.Tbl_Inv_Tran_InBindingSource.DataMember = "tbl_Inv_Tran_Date_tbl_Inv_Tran_In"
        Me.Tbl_Inv_Tran_InBindingSource.DataSource = Me.Tbl_Inv_Tran_DateBindingSource
        '
        'View_Lended_DBindingSource
        '
        Me.View_Lended_DBindingSource.DataMember = "View_Lended_D"
        Me.View_Lended_DBindingSource.DataSource = Me.DSPRGP
        '
        'View_Lended_DTableAdapter
        '
        Me.View_Lended_DTableAdapter.ClearBeforeFill = True
        '
        'View_Lended_MBindingSource
        '
        Me.View_Lended_MBindingSource.DataMember = "View_Lended_M"
        Me.View_Lended_MBindingSource.DataSource = Me.DSPRGP
        '
        'View_Lended_MTableAdapter
        '
        Me.View_Lended_MTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DayNoLabel2)
        Me.Panel2.Controls.Add(Me.Tbl_Inv_Tran_DateBindingNavigator)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Me.DateNameLabel1)
        Me.Panel2.Location = New System.Drawing.Point(6, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(287, 64)
        Me.Panel2.TabIndex = 16
        '
        'DayNoLabel2
        '
        Me.DayNoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.DayNoLabel2.Location = New System.Drawing.Point(231, 34)
        Me.DayNoLabel2.Name = "DayNoLabel2"
        Me.DayNoLabel2.Size = New System.Drawing.Size(20, 15)
        Me.DayNoLabel2.TabIndex = 16
        Me.DayNoLabel2.Text = "Label6"
        '
        'Tbl_Inv_Tran_DateBindingNavigator
        '
        Me.Tbl_Inv_Tran_DateBindingNavigator.AddNewItem = Nothing
        Me.Tbl_Inv_Tran_DateBindingNavigator.BindingSource = Me.Tbl_Inv_Tran_DateBindingSource
        Me.Tbl_Inv_Tran_DateBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.Tbl_Inv_Tran_DateBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Inv_Tran_DateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator4, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator5})
        Me.Tbl_Inv_Tran_DateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.Tbl_Inv_Tran_DateBindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.Tbl_Inv_Tran_DateBindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.Tbl_Inv_Tran_DateBindingNavigator.Name = "Tbl_Inv_Tran_DateBindingNavigator"
        Me.Tbl_Inv_Tran_DateBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.Tbl_Inv_Tran_DateBindingNavigator.Size = New System.Drawing.Size(285, 25)
        Me.Tbl_Inv_Tran_DateBindingNavigator.TabIndex = 5
        Me.Tbl_Inv_Tran_DateBindingNavigator.Text = "BindingNavigator1"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'DateNameLabel1
        '
        Me.DateNameLabel1.BackColor = System.Drawing.Color.White
        Me.DateNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.DateNameLabel1.Location = New System.Drawing.Point(125, 32)
        Me.DateNameLabel1.Name = "DateNameLabel1"
        Me.DateNameLabel1.Size = New System.Drawing.Size(100, 20)
        Me.DateNameLabel1.TabIndex = 1
        Me.DateNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelTranOutID)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.RackNoComboBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TrandocNoLabel1)
        Me.Panel1.Controls.Add(Me.ExCustIdLabel1)
        Me.Panel1.Controls.Add(Me.CPPULabel1)
        Me.Panel1.Controls.Add(Me.CurrencyLabel1)
        Me.Panel1.Controls.Add(Me.TranOutIDLabel2)
        Me.Panel1.Controls.Add(Me.UOMLabel)
        Me.Panel1.Controls.Add(Me.UOMLabel1)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Controls.Add(SIDLabel)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.TranInIDLabel1)
        Me.Panel1.Controls.Add(Me.L4NameComboBox)
        Me.Panel1.Controls.Add(L4NameLabel)
        Me.Panel1.Controls.Add(TranInIDLabel)
        Me.Panel1.Location = New System.Drawing.Point(6, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 290)
        Me.Panel1.TabIndex = 15
        '
        'LabelTranOutID
        '
        Me.LabelTranOutID.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelTranOutID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "TranOutID", True))
        Me.LabelTranOutID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelTranOutID.Location = New System.Drawing.Point(177, 211)
        Me.LabelTranOutID.Name = "LabelTranOutID"
        Me.LabelTranOutID.Size = New System.Drawing.Size(10, 10)
        Me.LabelTranOutID.TabIndex = 46
        '
        'RackNoComboBox
        '
        Me.RackNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RackNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.RackNoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_InBindingSource, "RackId", True))
        Me.RackNoComboBox.DisplayMember = "RackNo"
        Me.RackNoComboBox.FormattingEnabled = True
        Me.RackNoComboBox.Location = New System.Drawing.Point(87, 81)
        Me.RackNoComboBox.Name = "RackNoComboBox"
        Me.RackNoComboBox.Size = New System.Drawing.Size(265, 21)
        Me.RackNoComboBox.TabIndex = 44
        Me.RackNoComboBox.ValueMember = "RackId"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Special Note:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Narration", True))
        Me.TextBox1.Location = New System.Drawing.Point(87, 179)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(265, 20)
        Me.TextBox1.TabIndex = 42
        '
        'TrandocNoLabel1
        '
        Me.TrandocNoLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TrandocNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "MRIN", True))
        Me.TrandocNoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TrandocNoLabel1.Location = New System.Drawing.Point(253, 38)
        Me.TrandocNoLabel1.Name = "TrandocNoLabel1"
        Me.TrandocNoLabel1.Size = New System.Drawing.Size(10, 10)
        Me.TrandocNoLabel1.TabIndex = 41
        Me.TrandocNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExCustIdLabel1
        '
        Me.ExCustIdLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExCustIdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "SupplierID", True))
        Me.ExCustIdLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ExCustIdLabel1.Location = New System.Drawing.Point(253, 116)
        Me.ExCustIdLabel1.Name = "ExCustIdLabel1"
        Me.ExCustIdLabel1.Size = New System.Drawing.Size(10, 10)
        Me.ExCustIdLabel1.TabIndex = 40
        '
        'CPPULabel1
        '
        Me.CPPULabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "PPU", True))
        Me.CPPULabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CPPULabel1.Location = New System.Drawing.Point(308, 117)
        Me.CPPULabel1.Name = "CPPULabel1"
        Me.CPPULabel1.Size = New System.Drawing.Size(10, 10)
        Me.CPPULabel1.TabIndex = 39
        Me.CPPULabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CurrencyLabel1
        '
        Me.CurrencyLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Currency", True))
        Me.CurrencyLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrencyLabel1.Location = New System.Drawing.Point(330, 92)
        Me.CurrencyLabel1.Name = "CurrencyLabel1"
        Me.CurrencyLabel1.Size = New System.Drawing.Size(10, 10)
        Me.CurrencyLabel1.TabIndex = 38
        Me.CurrencyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TranOutIDLabel2
        '
        Me.TranOutIDLabel2.BackColor = System.Drawing.Color.White
        Me.TranOutIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TranOutIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "TranOutID", True))
        Me.TranOutIDLabel2.Location = New System.Drawing.Point(87, 106)
        Me.TranOutIDLabel2.Name = "TranOutIDLabel2"
        Me.TranOutIDLabel2.Size = New System.Drawing.Size(100, 20)
        Me.TranOutIDLabel2.TabIndex = 35
        Me.TranOutIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UOMLabel
        '
        Me.UOMLabel.Location = New System.Drawing.Point(4, 154)
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
        Me.UOMLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "UOM", True))
        Me.UOMLabel1.Location = New System.Drawing.Point(87, 154)
        Me.UOMLabel1.Name = "UOMLabel1"
        Me.UOMLabel1.Size = New System.Drawing.Size(100, 20)
        Me.UOMLabel1.TabIndex = 33
        Me.UOMLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(87, 130)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTextBox.TabIndex = 28
        Me.QtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_Inv_Tran_InBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.AddIn, Me.toolStripSeparator, Me.DeleteIn, Me.ToolStripSeparator1, Me.SaveIn, Me.toolStripSeparator3, Me.UndoIn})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(359, 25)
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
        'AddIn
        '
        Me.AddIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddIn.Image = CType(resources.GetObject("AddIn.Image"), System.Drawing.Image)
        Me.AddIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddIn.Name = "AddIn"
        Me.AddIn.Size = New System.Drawing.Size(23, 22)
        Me.AddIn.Text = "Add new"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteIn
        '
        Me.DeleteIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteIn.Image = CType(resources.GetObject("DeleteIn.Image"), System.Drawing.Image)
        Me.DeleteIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteIn.Name = "DeleteIn"
        Me.DeleteIn.Size = New System.Drawing.Size(23, 22)
        Me.DeleteIn.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SaveIn
        '
        Me.SaveIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveIn.Image = CType(resources.GetObject("SaveIn.Image"), System.Drawing.Image)
        Me.SaveIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveIn.Name = "SaveIn"
        Me.SaveIn.Size = New System.Drawing.Size(23, 22)
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'UndoIn
        '
        Me.UndoIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoIn.Image = CType(resources.GetObject("UndoIn.Image"), System.Drawing.Image)
        Me.UndoIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoIn.Name = "UndoIn"
        Me.UndoIn.Size = New System.Drawing.Size(23, 22)
        Me.UndoIn.Text = "Undo"
        '
        'TranInIDLabel1
        '
        Me.TranInIDLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TranInIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TranInIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_InBindingSource, "TranInID", True))
        Me.TranInIDLabel1.Location = New System.Drawing.Point(87, 33)
        Me.TranInIDLabel1.Name = "TranInIDLabel1"
        Me.TranInIDLabel1.Size = New System.Drawing.Size(100, 20)
        Me.TranInIDLabel1.TabIndex = 26
        Me.TranInIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Inv_Tran_InBindingSource, "Code", True))
        Me.L4NameComboBox.DataSource = Me.View_Lended_MBindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(87, 57)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(265, 21)
        Me.L4NameComboBox.TabIndex = 24
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'View_Lended_DDataGridView
        '
        Me.View_Lended_DDataGridView.AllowUserToAddRows = False
        Me.View_Lended_DDataGridView.AllowUserToDeleteRows = False
        Me.View_Lended_DDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_Lended_DDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.View_Lended_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Lended_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DateName, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.ExtCustID})
        Me.View_Lended_DDataGridView.DataSource = Me.View_Lended_DBindingSource
        Me.View_Lended_DDataGridView.Location = New System.Drawing.Point(371, 115)
        Me.View_Lended_DDataGridView.Name = "View_Lended_DDataGridView"
        Me.View_Lended_DDataGridView.ReadOnly = True
        Me.View_Lended_DDataGridView.Size = New System.Drawing.Size(631, 290)
        Me.View_Lended_DDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ExtCustName"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn10.HeaderText = "Supplier Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 200
        '
        'DateName
        '
        Me.DateName.DataPropertyName = "DateName"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.Format = "d"
        Me.DateName.DefaultCellStyle = DataGridViewCellStyle10
        Me.DateName.HeaderText = "Entry Date"
        Me.DateName.Name = "DateName"
        Me.DateName.ReadOnly = True
        Me.DateName.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TranOutID"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tran Out No."
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PPU"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PPU"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IssuedQty"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "n1"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn6.HeaderText = "Issued Qty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UOM"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn5.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "QtyReceived"
        Me.DataGridViewTextBoxColumn8.HeaderText = "QtyReceived"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Currency"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Balance"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N1"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn7.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TranType"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TranType"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'ExtCustID
        '
        Me.ExtCustID.DataPropertyName = "ExtCustID"
        Me.ExtCustID.HeaderText = "ExtCustID"
        Me.ExtCustID.Name = "ExtCustID"
        Me.ExtCustID.ReadOnly = True
        Me.ExtCustID.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1131, 40)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Purchase Return Material Received"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DSMat_Brow
        '
        Me.DSMat_Brow.DataSetName = "DSMat_Brow"
        Me.DSMat_Brow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Inv_Rack_InfoBindingSource
        '
        Me.Tbl_Inv_Rack_InfoBindingSource.DataMember = "tbl_Inv_Rack_Info"
        Me.Tbl_Inv_Rack_InfoBindingSource.DataSource = Me.DSMat_Brow
        '
        'Tbl_Inv_Rack_InfoTableAdapter
        '
        Me.Tbl_Inv_Rack_InfoTableAdapter.ClearBeforeFill = True
        '
        'frmPRRN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1131, 750)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.View_Lended_DDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPRRN"
        Me.Text = "Purchase Return Material Received"
        CType(Me.DSPRGP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_InBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Lended_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Lended_MBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Inv_Tran_DateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Inv_Tran_DateBindingNavigator.ResumeLayout(False)
        Me.Tbl_Inv_Tran_DateBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_Lended_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMat_Brow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Rack_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSPRGP As FS_ERP_MM.DSPRGP
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As FS_ERP_MM.DSPRGPTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSPRGPTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Inv_Tran_InTableAdapter As FS_ERP_MM.DSPRGPTableAdapters.tbl_Inv_Tran_InTableAdapter
    Friend WithEvents Tbl_Inv_Tran_InBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Lended_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Lended_DTableAdapter As FS_ERP_MM.DSPRGPTableAdapters.View_Lended_DTableAdapter
    Friend WithEvents View_Lended_MBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Lended_MTableAdapter As FS_ERP_MM.DSPRGPTableAdapters.View_Lended_MTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Tbl_Inv_Tran_DateBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RackNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TrandocNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents ExCustIdLabel1 As System.Windows.Forms.Label
    Friend WithEvents CPPULabel1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyLabel1 As System.Windows.Forms.Label
    Friend WithEvents TranOutIDLabel2 As System.Windows.Forms.Label
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
    Friend WithEvents AddIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents TranInIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents View_Lended_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DayNoLabel2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExtCustID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DSMat_Brow As FS_ERP_MM.DSMat_Brow
    Friend WithEvents Tbl_Inv_Rack_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_Rack_InfoTableAdapter As FS_ERP_MM.DSMat_BrowTableAdapters.tbl_Inv_Rack_InfoTableAdapter
    Friend WithEvents LabelTranOutID As System.Windows.Forms.Label
End Class
