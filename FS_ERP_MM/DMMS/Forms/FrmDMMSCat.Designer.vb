<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDMMSCat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDMMSCat))
        Me.Tbl_DMMS_CatagoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_DMMS_CatagoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_DMMS_CatagoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_DMMS_CatagoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMMS = New FS_ERP_MM.DMMS()
        Me.Tbl_DMMS_CatagoryTableAdapter = New FS_ERP_MM.DMMSTableAdapters.tbl_DMMS_CatagoryTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DMMSTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.Tbl_DMMS_CatagoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_DMMS_CatagoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_DMMS_CatagoryBindingNavigator.SuspendLayout()
        CType(Me.Tbl_DMMS_CatagoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tbl_DMMS_CatagoryDataGridView
        '
        Me.Tbl_DMMS_CatagoryDataGridView.AllowUserToAddRows = False
        Me.Tbl_DMMS_CatagoryDataGridView.AutoGenerateColumns = False
        Me.Tbl_DMMS_CatagoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_DMMS_CatagoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Status1})
        Me.Tbl_DMMS_CatagoryDataGridView.DataSource = Me.Tbl_DMMS_CatagoryBindingSource
        Me.Tbl_DMMS_CatagoryDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_DMMS_CatagoryDataGridView.Name = "Tbl_DMMS_CatagoryDataGridView"
        Me.Tbl_DMMS_CatagoryDataGridView.RowHeadersWidth = 23
        Me.Tbl_DMMS_CatagoryDataGridView.Size = New System.Drawing.Size(458, 528)
        Me.Tbl_DMMS_CatagoryDataGridView.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_DMMS_CatagoryBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_DMMS_CatagoryDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 559)
        Me.Panel1.TabIndex = 2
        '
        'Tbl_DMMS_CatagoryBindingNavigator
        '
        Me.Tbl_DMMS_CatagoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_DMMS_CatagoryBindingNavigator.BindingSource = Me.Tbl_DMMS_CatagoryBindingSource
        Me.Tbl_DMMS_CatagoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_DMMS_CatagoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_DMMS_CatagoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_DMMS_CatagoryBindingNavigatorSaveItem})
        Me.Tbl_DMMS_CatagoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_DMMS_CatagoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_DMMS_CatagoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_DMMS_CatagoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_DMMS_CatagoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_DMMS_CatagoryBindingNavigator.Name = "Tbl_DMMS_CatagoryBindingNavigator"
        Me.Tbl_DMMS_CatagoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_DMMS_CatagoryBindingNavigator.Size = New System.Drawing.Size(465, 25)
        Me.Tbl_DMMS_CatagoryBindingNavigator.TabIndex = 2
        Me.Tbl_DMMS_CatagoryBindingNavigator.Text = "BindingNavigator1"
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(561, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DMMS Catagories"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Tbl_DMMS_CatagoryBindingNavigatorSaveItem
        '
        Me.Tbl_DMMS_CatagoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_DMMS_CatagoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_DMMS_CatagoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_DMMS_CatagoryBindingNavigatorSaveItem.Name = "Tbl_DMMS_CatagoryBindingNavigatorSaveItem"
        Me.Tbl_DMMS_CatagoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_DMMS_CatagoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_DMMS_CatagoryBindingSource
        '
        Me.Tbl_DMMS_CatagoryBindingSource.DataMember = "tbl_DMMS_Catagory"
        Me.Tbl_DMMS_CatagoryBindingSource.DataSource = Me.DMMS
        '
        'DMMS
        '
        Me.DMMS.DataSetName = "DMMS"
        Me.DMMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_DMMS_CatagoryTableAdapter
        '
        Me.Tbl_DMMS_CatagoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_DMMS_CatagoryTableAdapter = Me.Tbl_DMMS_CatagoryTableAdapter
        Me.TableAdapterManager.tbl_DMMS_HoldersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_MachinesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_DMMS_Scheduling_ParmetersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PIR_DeptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PIR_SectionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DMMSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_DMMS_MachinesTableAdapter = Nothing
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CatID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serial No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CatgoryName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Catagory Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Status1
        '
        Me.Status1.DataPropertyName = "Status1"
        Me.Status1.HeaderText = "Status"
        Me.Status1.Name = "Status1"
        '
        'FrmDMMSCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 742)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDMMSCat"
        Me.Text = "FrmDMMSCat"
        CType(Me.Tbl_DMMS_CatagoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_DMMS_CatagoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_DMMS_CatagoryBindingNavigator.ResumeLayout(False)
        Me.Tbl_DMMS_CatagoryBindingNavigator.PerformLayout()
        CType(Me.Tbl_DMMS_CatagoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DMMS As DMMS
    Friend WithEvents Tbl_DMMS_CatagoryBindingSource As BindingSource
    Friend WithEvents Tbl_DMMS_CatagoryTableAdapter As DMMSTableAdapters.tbl_DMMS_CatagoryTableAdapter
    Friend WithEvents TableAdapterManager As DMMSTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_DMMS_CatagoryDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbl_DMMS_CatagoryBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_DMMS_CatagoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Status1 As DataGridViewCheckBoxColumn
End Class
