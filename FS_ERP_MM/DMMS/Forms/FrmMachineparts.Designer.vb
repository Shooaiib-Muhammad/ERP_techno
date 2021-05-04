<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMachineparts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMachineparts))
        Me.DMMS = New FS_ERP_MM.DMMS()
        Me.Tbl_DMMS_Parts1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_DMMS_Parts1TableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_DMMS_Parts1TableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DMMSTableAdapters.TableAdapterManager()
        Me.Tbl_DMMS_Parts1DataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_DMMS_Parts1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_DMMS_Parts1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DMMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_DMMS_Parts1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_DMMS_Parts1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_DMMS_Parts1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_DMMS_Parts1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DMMS
        '
        Me.DMMS.DataSetName = "DMMS"
        Me.DMMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_DMMS_Parts1BindingSource
        '
        Me.Tbl_DMMS_Parts1BindingSource.DataMember = "tbl_DMMS_Parts1"
        Me.Tbl_DMMS_Parts1BindingSource.DataSource = Me.DMMS
        '
        'Tbl_DMMS_Parts1TableAdapter
        '
        Me.Tbl_DMMS_Parts1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_DMMS_CatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_HoldersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_MachinesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_Parts1TableAdapter = Me.Tbl_DMMS_Parts1TableAdapter
        Me.TableAdapterManager.tbl_DMMS_PartsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_Scheduling_ParmetersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PIR_DeptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PIR_SectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PIR_UsersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DMMSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_DMMS_MachinesTableAdapter = Nothing
        '
        'Tbl_DMMS_Parts1DataGridView
        '
        Me.Tbl_DMMS_Parts1DataGridView.AutoGenerateColumns = False
        Me.Tbl_DMMS_Parts1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_DMMS_Parts1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.Tbl_DMMS_Parts1DataGridView.DataSource = Me.Tbl_DMMS_Parts1BindingSource
        Me.Tbl_DMMS_Parts1DataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_DMMS_Parts1DataGridView.Name = "Tbl_DMMS_Parts1DataGridView"
        Me.Tbl_DMMS_Parts1DataGridView.RowHeadersWidth = 23
        Me.Tbl_DMMS_Parts1DataGridView.Size = New System.Drawing.Size(410, 393)
        Me.Tbl_DMMS_Parts1DataGridView.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_DMMS_Parts1BindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_DMMS_Parts1DataGridView)
        Me.Panel1.Location = New System.Drawing.Point(6, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 426)
        Me.Panel1.TabIndex = 2
        '
        'Tbl_DMMS_Parts1BindingNavigator
        '
        Me.Tbl_DMMS_Parts1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_DMMS_Parts1BindingNavigator.BindingSource = Me.Tbl_DMMS_Parts1BindingSource
        Me.Tbl_DMMS_Parts1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_DMMS_Parts1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_DMMS_Parts1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_DMMS_Parts1BindingNavigatorSaveItem})
        Me.Tbl_DMMS_Parts1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_DMMS_Parts1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_DMMS_Parts1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_DMMS_Parts1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_DMMS_Parts1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_DMMS_Parts1BindingNavigator.Name = "Tbl_DMMS_Parts1BindingNavigator"
        Me.Tbl_DMMS_Parts1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_DMMS_Parts1BindingNavigator.Size = New System.Drawing.Size(419, 25)
        Me.Tbl_DMMS_Parts1BindingNavigator.TabIndex = 2
        Me.Tbl_DMMS_Parts1BindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_DMMS_Parts1BindingNavigatorSaveItem
        '
        Me.Tbl_DMMS_Parts1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_DMMS_Parts1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_DMMS_Parts1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_DMMS_Parts1BindingNavigatorSaveItem.Name = "Tbl_DMMS_Parts1BindingNavigatorSaveItem"
        Me.Tbl_DMMS_Parts1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_DMMS_Parts1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(819, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Machine Parts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Parts Name"
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
        'FrmMachineparts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 583)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMachineparts"
        Me.Text = "FrmMachineparts"
        CType(Me.DMMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_DMMS_Parts1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_DMMS_Parts1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_DMMS_Parts1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_DMMS_Parts1BindingNavigator.ResumeLayout(False)
        Me.Tbl_DMMS_Parts1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DMMS As DMMS
    Friend WithEvents Tbl_DMMS_Parts1BindingSource As BindingSource
    Friend WithEvents Tbl_DMMS_Parts1TableAdapter As DMMSTableAdapters.tbl_DMMS_Parts1TableAdapter
    Friend WithEvents TableAdapterManager As DMMSTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_DMMS_Parts1DataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbl_DMMS_Parts1BindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_DMMS_Parts1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
