<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesBill
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
        Dim SpecialNoteLabel As System.Windows.Forms.Label
        Dim CompanyAdressLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim CustidLabel As System.Windows.Forms.Label
        Dim BillDateLabel As System.Windows.Forms.Label
        Dim BillIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesBill))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DSSaleBill = New FS_ERP_MM.DSSaleBill()
        Me.Tbl_MM_Sale_Bill_HBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MM_Sale_Bill_HTableAdapter = New FS_ERP_MM.DSSaleBillTableAdapters.tbl_MM_Sale_Bill_HTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSSaleBillTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_L4TableAdapter = New FS_ERP_MM.DSSaleBillTableAdapters.tbl_Inv_L4TableAdapter()
        Me.Tbl_MM_Sale_Bill_DTableAdapter = New FS_ERP_MM.DSSaleBillTableAdapters.tbl_MM_Sale_Bill_DTableAdapter()
        Me.Tbl_MM_CustomerTableAdapter = New FS_ERP_MM.DSSaleBillTableAdapters.tbl_MM_CustomerTableAdapter()
        Me.Tbl_MM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SaveToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BillDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SpecialNoteTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyAdressTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustidComboBox = New System.Windows.Forms.ComboBox()
        Me.BillIDLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tbl_MM_Sale_Bill_DDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Tbl_MM_Sale_Bill_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.View_Sale_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Sale_DTableAdapter = New FS_ERP_MM.DSSaleBillTableAdapters.View_Sale_DTableAdapter()
        Me.View_Sale_DDataGridView = New System.Windows.Forms.DataGridView()
        Me.SaleInvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMMatReq = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMtxtGPNo = New System.Windows.Forms.ToolStripTextBox()
        Me.CMtxtGPDate = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Cancel = New System.Windows.Forms.DataGridViewButtonColumn()
        SpecialNoteLabel = New System.Windows.Forms.Label()
        CompanyAdressLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        CustidLabel = New System.Windows.Forms.Label()
        BillDateLabel = New System.Windows.Forms.Label()
        BillIDLabel = New System.Windows.Forms.Label()
        CType(Me.DSSaleBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_Sale_Bill_HBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_MM_Sale_Bill_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MM_Sale_Bill_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_Sale_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Sale_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMMatReq.SuspendLayout()
        Me.SuspendLayout()
        '
        'SpecialNoteLabel
        '
        SpecialNoteLabel.Location = New System.Drawing.Point(3, 135)
        SpecialNoteLabel.Name = "SpecialNoteLabel"
        SpecialNoteLabel.Size = New System.Drawing.Size(90, 20)
        SpecialNoteLabel.TabIndex = 11
        SpecialNoteLabel.Text = "Special Note:"
        SpecialNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyAdressLabel
        '
        CompanyAdressLabel.Location = New System.Drawing.Point(3, 108)
        CompanyAdressLabel.Name = "CompanyAdressLabel"
        CompanyAdressLabel.Size = New System.Drawing.Size(90, 20)
        CompanyAdressLabel.TabIndex = 10
        CompanyAdressLabel.Text = "Company Adress:"
        CompanyAdressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.Location = New System.Drawing.Point(3, 82)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(90, 20)
        CompanyNameLabel.TabIndex = 9
        CompanyNameLabel.Text = "Company Name:"
        CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustidLabel
        '
        CustidLabel.Location = New System.Drawing.Point(3, 56)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(90, 20)
        CustidLabel.TabIndex = 8
        CustidLabel.Text = "Customer Name:"
        CustidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BillDateLabel
        '
        BillDateLabel.Location = New System.Drawing.Point(228, 30)
        BillDateLabel.Name = "BillDateLabel"
        BillDateLabel.Size = New System.Drawing.Size(90, 20)
        BillDateLabel.TabIndex = 7
        BillDateLabel.Text = "Bill Date:"
        BillDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BillIDLabel
        '
        BillIDLabel.Location = New System.Drawing.Point(3, 30)
        BillIDLabel.Name = "BillIDLabel"
        BillIDLabel.Size = New System.Drawing.Size(90, 20)
        BillIDLabel.TabIndex = 6
        BillIDLabel.Text = "Bill Number:"
        BillIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1143, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Accounts Sales Bill"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DSSaleBill
        '
        Me.DSSaleBill.DataSetName = "DSSaleBill"
        Me.DSSaleBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_MM_Sale_Bill_HBindingSource
        '
        Me.Tbl_MM_Sale_Bill_HBindingSource.DataMember = "tbl_MM_Sale_Bill_H"
        Me.Tbl_MM_Sale_Bill_HBindingSource.DataSource = Me.DSSaleBill
        '
        'Tbl_MM_Sale_Bill_HTableAdapter
        '
        Me.Tbl_MM_Sale_Bill_HTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_CodeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Me.Tbl_Inv_L4TableAdapter
        Me.TableAdapterManager.tbl_MM_Sale_Bill_DTableAdapter = Me.Tbl_MM_Sale_Bill_DTableAdapter
        Me.TableAdapterManager.tbl_MM_Sale_Bill_HTableAdapter = Me.Tbl_MM_Sale_Bill_HTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSSaleBillTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_L4TableAdapter
        '
        Me.Tbl_Inv_L4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_Sale_Bill_DTableAdapter
        '
        Me.Tbl_MM_Sale_Bill_DTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_CustomerTableAdapter
        '
        Me.Tbl_MM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MM_CustomerBindingSource
        '
        Me.Tbl_MM_CustomerBindingSource.DataMember = "tbl_MM_Customer"
        Me.Tbl_MM_CustomerBindingSource.DataSource = Me.DSSaleBill
        '
        'Tbl_Inv_L4BindingSource
        '
        Me.Tbl_Inv_L4BindingSource.DataMember = "tbl_Inv_L4"
        Me.Tbl_Inv_L4BindingSource.DataSource = Me.DSSaleBill
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.BindingNavigator2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BillDateMaskedTextBox)
        Me.Panel1.Controls.Add(SpecialNoteLabel)
        Me.Panel1.Controls.Add(Me.SpecialNoteTextBox)
        Me.Panel1.Controls.Add(CompanyAdressLabel)
        Me.Panel1.Controls.Add(Me.CompanyAdressTextBox)
        Me.Panel1.Controls.Add(CompanyNameLabel)
        Me.Panel1.Controls.Add(Me.CompanyNameTextBox)
        Me.Panel1.Controls.Add(CustidLabel)
        Me.Panel1.Controls.Add(Me.CustidComboBox)
        Me.Panel1.Controls.Add(BillDateLabel)
        Me.Panel1.Controls.Add(BillIDLabel)
        Me.Panel1.Controls.Add(Me.BillIDLabel1)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(898, 162)
        Me.Panel1.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(565, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 24)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator2.BindingSource = Me.Tbl_MM_Sale_Bill_HBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton1})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator2.Size = New System.Drawing.Size(896, 25)
        Me.BindingNavigator2.TabIndex = 14
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
        'SaveToolStripButton1
        '
        Me.SaveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton1.Image = CType(resources.GetObject("SaveToolStripButton1.Image"), System.Drawing.Image)
        Me.SaveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton1.Name = "SaveToolStripButton1"
        Me.SaveToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton1.Text = "&Save"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(693, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 24)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Show Bill Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BillDateMaskedTextBox
        '
        Me.BillDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_Sale_Bill_HBindingSource, "BillDate", True))
        Me.BillDateMaskedTextBox.Location = New System.Drawing.Point(324, 30)
        Me.BillDateMaskedTextBox.Mask = "00/00/0000"
        Me.BillDateMaskedTextBox.Name = "BillDateMaskedTextBox"
        Me.BillDateMaskedTextBox.Size = New System.Drawing.Size(114, 20)
        Me.BillDateMaskedTextBox.TabIndex = 8
        Me.BillDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BillDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'SpecialNoteTextBox
        '
        Me.SpecialNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_Sale_Bill_HBindingSource, "SpecialNote", True))
        Me.SpecialNoteTextBox.Location = New System.Drawing.Point(99, 135)
        Me.SpecialNoteTextBox.Name = "SpecialNoteTextBox"
        Me.SpecialNoteTextBox.Size = New System.Drawing.Size(716, 20)
        Me.SpecialNoteTextBox.TabIndex = 12
        '
        'CompanyAdressTextBox
        '
        Me.CompanyAdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_Sale_Bill_HBindingSource, "CompanyAdress", True))
        Me.CompanyAdressTextBox.Location = New System.Drawing.Point(99, 108)
        Me.CompanyAdressTextBox.Name = "CompanyAdressTextBox"
        Me.CompanyAdressTextBox.Size = New System.Drawing.Size(716, 20)
        Me.CompanyAdressTextBox.TabIndex = 11
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_Sale_Bill_HBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(99, 82)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(716, 20)
        Me.CompanyNameTextBox.TabIndex = 10
        '
        'CustidComboBox
        '
        Me.CustidComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustidComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustidComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_MM_Sale_Bill_HBindingSource, "Custid", True))
        Me.CustidComboBox.DataSource = Me.Tbl_MM_CustomerBindingSource
        Me.CustidComboBox.DisplayMember = "CompanyName"
        Me.CustidComboBox.FormattingEnabled = True
        Me.CustidComboBox.Location = New System.Drawing.Point(99, 55)
        Me.CustidComboBox.Name = "CustidComboBox"
        Me.CustidComboBox.Size = New System.Drawing.Size(219, 21)
        Me.CustidComboBox.TabIndex = 9
        Me.CustidComboBox.ValueMember = "CustID"
        '
        'BillIDLabel1
        '
        Me.BillIDLabel1.BackColor = System.Drawing.Color.White
        Me.BillIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BillIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_MM_Sale_Bill_HBindingSource, "BillID", True))
        Me.BillIDLabel1.Location = New System.Drawing.Point(99, 30)
        Me.BillIDLabel1.Name = "BillIDLabel1"
        Me.BillIDLabel1.Size = New System.Drawing.Size(100, 20)
        Me.BillIDLabel1.TabIndex = 7
        Me.BillIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(899, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Customer's  Sale  Materials"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Tbl_MM_Sale_Bill_DDataGridView)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Location = New System.Drawing.Point(12, 456)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 258)
        Me.Panel2.TabIndex = 13
        '
        'Tbl_MM_Sale_Bill_DDataGridView
        '
        Me.Tbl_MM_Sale_Bill_DDataGridView.AllowUserToAddRows = False
        Me.Tbl_MM_Sale_Bill_DDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_MM_Sale_Bill_DDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_MM_Sale_Bill_DDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_MM_Sale_Bill_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_MM_Sale_Bill_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.Column2})
        Me.Tbl_MM_Sale_Bill_DDataGridView.DataSource = Me.Tbl_MM_Sale_Bill_DBindingSource
        Me.Tbl_MM_Sale_Bill_DDataGridView.Location = New System.Drawing.Point(3, 27)
        Me.Tbl_MM_Sale_Bill_DDataGridView.Name = "Tbl_MM_Sale_Bill_DDataGridView"
        Me.Tbl_MM_Sale_Bill_DDataGridView.Size = New System.Drawing.Size(891, 227)
        Me.Tbl_MM_Sale_Bill_DDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "BillID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "BillID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "BillDID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn11.HeaderText = "Sr.No."
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 80
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "SaleInvoiceNo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn14.HeaderText = "Sale Invoice No."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TranOutID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "TranOutID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn16.DataSource = Me.Tbl_Inv_L4BindingSource
        Me.DataGridViewTextBoxColumn16.DisplayMember = "L4Name"
        Me.DataGridViewTextBoxColumn16.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn16.HeaderText = "Material Name"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn16.ValueMember = "Code"
        Me.DataGridViewTextBoxColumn16.Width = 200
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Qty"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn17.HeaderText = "Sale Qty"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 80
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn19.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 150
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "BillID"
        Me.Column2.HeaderText = "Undo Record"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.Text = "Undo Record"
        Me.Column2.ToolTipText = "Undo Record"
        Me.Column2.UseColumnTextForButtonValue = True
        '
        'Tbl_MM_Sale_Bill_DBindingSource
        '
        Me.Tbl_MM_Sale_Bill_DBindingSource.DataMember = "tbl_MM_Sale_Bill_H_tbl_MM_Sale_Bill_D"
        Me.Tbl_MM_Sale_Bill_DBindingSource.DataSource = Me.Tbl_MM_Sale_Bill_HBindingSource
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Tbl_MM_Sale_Bill_DBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.SaveToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(897, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
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
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(917, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 34)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Undo All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Materials"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(917, 241)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 34)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Send All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Materials" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = True
        '
        'View_Sale_DBindingSource
        '
        Me.View_Sale_DBindingSource.DataMember = "View_Sale_D"
        Me.View_Sale_DBindingSource.DataSource = Me.DSSaleBill
        '
        'View_Sale_DTableAdapter
        '
        Me.View_Sale_DTableAdapter.ClearBeforeFill = True
        '
        'View_Sale_DDataGridView
        '
        Me.View_Sale_DDataGridView.AllowUserToAddRows = False
        Me.View_Sale_DDataGridView.AllowUserToDeleteRows = False
        Me.View_Sale_DDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_Sale_DDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.View_Sale_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Sale_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaleInvoiceNo, Me.DataGridViewTextBoxColumn1, Me.DateName, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn2, Me.Column1, Me.Cancel})
        Me.View_Sale_DDataGridView.DataSource = Me.View_Sale_DBindingSource
        Me.View_Sale_DDataGridView.Location = New System.Drawing.Point(12, 231)
        Me.View_Sale_DDataGridView.Name = "View_Sale_DDataGridView"
        Me.View_Sale_DDataGridView.ReadOnly = True
        Me.View_Sale_DDataGridView.Size = New System.Drawing.Size(899, 223)
        Me.View_Sale_DDataGridView.TabIndex = 18
        '
        'SaleInvoiceNo
        '
        Me.SaleInvoiceNo.DataPropertyName = "SaleInvoiceNo"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SaleInvoiceNo.DefaultCellStyle = DataGridViewCellStyle7
        Me.SaleInvoiceNo.HeaderText = "Sale Invoice No."
        Me.SaleInvoiceNo.Name = "SaleInvoiceNo"
        Me.SaleInvoiceNo.ReadOnly = True
        Me.SaleInvoiceNo.Width = 90
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.ContextMenuStrip = Me.CMMatReq
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TranOutID"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Gate Pass No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'CMMatReq
        '
        Me.CMMatReq.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMtxtGPNo, Me.CMtxtGPDate, Me.ToolStripMenuItem2})
        Me.CMMatReq.Name = "SupplierContextMenuStrip"
        Me.CMMatReq.Size = New System.Drawing.Size(171, 76)
        '
        'CMtxtGPNo
        '
        Me.CMtxtGPNo.ForeColor = System.Drawing.Color.Silver
        Me.CMtxtGPNo.Name = "CMtxtGPNo"
        Me.CMtxtGPNo.Size = New System.Drawing.Size(110, 23)
        Me.CMtxtGPNo.Text = "Enter Gate Pass No."
        '
        'CMtxtGPDate
        '
        Me.CMtxtGPDate.ForeColor = System.Drawing.Color.Silver
        Me.CMtxtGPDate.Name = "CMtxtGPDate"
        Me.CMtxtGPDate.Size = New System.Drawing.Size(110, 23)
        Me.CMtxtGPDate.Text = "Enter Gate Pass Date"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem2.Text = "Remove &Filter"
        '
        'DateName
        '
        Me.DateName.ContextMenuStrip = Me.CMMatReq
        Me.DateName.DataPropertyName = "DateName"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "d"
        Me.DateName.DefaultCellStyle = DataGridViewCellStyle9
        Me.DateName.HeaderText = "Gate Pass Date"
        Me.DateName.Name = "DateName"
        Me.DateName.ReadOnly = True
        Me.DateName.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "L4Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Material Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SaleQty"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn8.HeaderText = "Sale Qty"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UOM"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn7.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn9.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Curency"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Curency"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "TranOutID"
        Me.Column1.HeaderText = "Save"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Text = "Save"
        Me.Column1.ToolTipText = "Save"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 80
        '
        'Cancel
        '
        Me.Cancel.DataPropertyName = "TranOutID"
        Me.Cancel.HeaderText = "Cancel"
        Me.Cancel.Name = "Cancel"
        Me.Cancel.ReadOnly = True
        Me.Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Cancel.Text = "Cancel"
        Me.Cancel.ToolTipText = "Cancel"
        Me.Cancel.UseColumnTextForButtonValue = True
        Me.Cancel.Width = 80
        '
        'frmSalesBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1143, 746)
        Me.Controls.Add(Me.View_Sale_DDataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSalesBill"
        Me.Text = "Accounts Sales Bill"
        CType(Me.DSSaleBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_Sale_Bill_HBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_MM_Sale_Bill_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MM_Sale_Bill_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_Sale_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Sale_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMMatReq.ResumeLayout(False)
        Me.CMMatReq.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSSaleBill As FS_ERP_MM.DSSaleBill
    Friend WithEvents Tbl_MM_Sale_Bill_HBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MM_Sale_Bill_HTableAdapter As FS_ERP_MM.DSSaleBillTableAdapters.tbl_MM_Sale_Bill_HTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSSaleBillTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_MM_CustomerTableAdapter As FS_ERP_MM.DSSaleBillTableAdapters.tbl_MM_CustomerTableAdapter
    Friend WithEvents Tbl_MM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Inv_L4TableAdapter As FS_ERP_MM.DSSaleBillTableAdapters.tbl_Inv_L4TableAdapter
    Friend WithEvents Tbl_Inv_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BillDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents SpecialNoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyAdressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustidComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BillIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SaveToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tbl_MM_Sale_Bill_DTableAdapter As FS_ERP_MM.DSSaleBillTableAdapters.tbl_MM_Sale_Bill_DTableAdapter
    Friend WithEvents Tbl_MM_Sale_Bill_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Sale_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Sale_DTableAdapter As FS_ERP_MM.DSSaleBillTableAdapters.View_Sale_DTableAdapter
    Friend WithEvents View_Sale_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Tbl_MM_Sale_Bill_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents CMMatReq As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMtxtGPNo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CMtxtGPDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleInvoiceNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Cancel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
