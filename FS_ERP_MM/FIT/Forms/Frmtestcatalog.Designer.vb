<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmtestcatalog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmtestcatalog))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DSFIT = New FS_ERP_MM.DSFIT()
        Me.Tbl_Fit_Test_CatalogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fit_Test_CatalogsTableAdapter = New FS_ERP_MM.DSFITTableAdapters.Tbl_Fit_Test_CatalogsTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSFITTableAdapters.TableAdapterManager()
        Me.Tbl_Fit_Test_CatalogsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Fit_Test_CatalogsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.DSFIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fit_Test_CatalogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fit_Test_CatalogsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Fit_Test_CatalogsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(888, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FIT Test Catalogs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DSFIT
        '
        Me.DSFIT.DataSetName = "DSFIT"
        Me.DSFIT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Fit_Test_CatalogsBindingSource
        '
        Me.Tbl_Fit_Test_CatalogsBindingSource.DataMember = "Tbl_Fit_Test_Catalogs"
        Me.Tbl_Fit_Test_CatalogsBindingSource.DataSource = Me.DSFIT
        '
        'Tbl_Fit_Test_CatalogsTableAdapter
        '
        Me.Tbl_Fit_Test_CatalogsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tbl_Fit_Mat_TypeTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Fit_Material_ReceivedTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Fit_MaterialTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Fit_Test_CatalogsTableAdapter = Me.Tbl_Fit_Test_CatalogsTableAdapter
        Me.TableAdapterManager.Tbl_Fit_Test_TransactionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSFITTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Fit_Test_CatalogsDataGridView
        '
        Me.Tbl_Fit_Test_CatalogsDataGridView.AutoGenerateColumns = False
        Me.Tbl_Fit_Test_CatalogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Fit_Test_CatalogsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.Tbl_Fit_Test_CatalogsDataGridView.DataSource = Me.Tbl_Fit_Test_CatalogsBindingSource
        Me.Tbl_Fit_Test_CatalogsDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_Fit_Test_CatalogsDataGridView.Name = "Tbl_Fit_Test_CatalogsDataGridView"
        Me.Tbl_Fit_Test_CatalogsDataGridView.RowHeadersWidth = 23
        Me.Tbl_Fit_Test_CatalogsDataGridView.Size = New System.Drawing.Size(437, 531)
        Me.Tbl_Fit_Test_CatalogsDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TestName"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Test Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Fit_Test_CatalogsBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_Fit_Test_CatalogsDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(6, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 564)
        Me.Panel1.TabIndex = 8
        '
        'Tbl_Fit_Test_CatalogsBindingNavigator
        '
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.BindingSource = Me.Tbl_Fit_Test_CatalogsBindingSource
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem})
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.Name = "Tbl_Fit_Test_CatalogsBindingNavigator"
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.Size = New System.Drawing.Size(443, 25)
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.TabIndex = 8
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem
        '
        Me.Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem.Name = "Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem"
        Me.Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Frmtestcatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 619)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmtestcatalog"
        Me.Text = "Test Catalog"
        CType(Me.DSFIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fit_Test_CatalogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fit_Test_CatalogsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Fit_Test_CatalogsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.ResumeLayout(False)
        Me.Tbl_Fit_Test_CatalogsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DSFIT As DSFIT
    Friend WithEvents Tbl_Fit_Test_CatalogsBindingSource As BindingSource
    Friend WithEvents Tbl_Fit_Test_CatalogsTableAdapter As DSFITTableAdapters.Tbl_Fit_Test_CatalogsTableAdapter
    Friend WithEvents TableAdapterManager As DSFITTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Fit_Test_CatalogsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbl_Fit_Test_CatalogsBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_Fit_Test_CatalogsBindingNavigatorSaveItem As ToolStripButton
End Class
