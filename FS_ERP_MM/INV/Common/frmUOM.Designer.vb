<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUOM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUOM))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Pur_UnitOfMeasurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsUOM = New FS_ERP_MM.dsUOM()
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
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Pur_UnitOfMeasurementDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter = New FS_ERP_MM.dsUOMTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.dsUOMTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Pur_UnitOfMeasurementBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_Pur_UnitOfMeasurementDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(37, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 385)
        Me.Panel1.TabIndex = 2
        '
        'Tbl_Pur_UnitOfMeasurementBindingNavigator
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.BindingSource = Me.Tbl_Pur_UnitOfMeasurementBindingSource
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem})
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.Name = "Tbl_Pur_UnitOfMeasurementBindingNavigator"
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.Size = New System.Drawing.Size(386, 25)
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.TabIndex = 6
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Pur_UnitOfMeasurementBindingSource
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataMember = "tbl_Pur_UnitOfMeasurement"
        Me.Tbl_Pur_UnitOfMeasurementBindingSource.DataSource = Me.DsUOM
        '
        'DsUOM
        '
        Me.DsUOM.DataSetName = "dsUOM"
        Me.DsUOM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem
        '
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem.Name = "Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem"
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_Pur_UnitOfMeasurementDataGridView
        '
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.AllowUserToAddRows = False
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.ColumnHeadersHeight = 40
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.DataSource = Me.Tbl_Pur_UnitOfMeasurementBindingSource
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.Name = "Tbl_Pur_UnitOfMeasurementDataGridView"
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.Size = New System.Drawing.Size(380, 352)
        Me.Tbl_Pur_UnitOfMeasurementDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UOM"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Description"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unit Of Measurement"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Pur_UnitOfMeasurementTableAdapter
        '
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_MM_CurrancyTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pur_UnitOfMeasurementTableAdapter = Me.Tbl_Pur_UnitOfMeasurementTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.dsUOMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmUOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 485)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmUOM"
        Me.Text = "Unit Of Measurement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.ResumeLayout(False)
        Me.Tbl_Pur_UnitOfMeasurementBindingNavigator.PerformLayout()
        CType(Me.Tbl_Pur_UnitOfMeasurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pur_UnitOfMeasurementDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DsUOM As FS_ERP_MM.dsUOM
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pur_UnitOfMeasurementTableAdapter As FS_ERP_MM.dsUOMTableAdapters.tbl_Pur_UnitOfMeasurementTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.dsUOMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Pur_UnitOfMeasurementBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Pur_UnitOfMeasurementDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
