<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Asserts_type
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Asserts_type))
        Me.DSAsserts = New FS_ERP_MM.DSAsserts()
        Me.Tbl_Asserts_TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Asserts_TypeTableAdapter = New FS_ERP_MM.DSAssertsTableAdapters.tbl_Asserts_TypeTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSAssertsTableAdapters.TableAdapterManager()
        Me.Tbl_Asserts_TypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Asserts_TypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Asserts_TypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DSAsserts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Asserts_TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Asserts_TypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Asserts_TypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Asserts_TypeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSAsserts
        '
        Me.DSAsserts.DataSetName = "DSAsserts"
        Me.DSAsserts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Asserts_TypeBindingSource
        '
        Me.Tbl_Asserts_TypeBindingSource.DataMember = "tbl_Asserts_Type"
        Me.Tbl_Asserts_TypeBindingSource.DataSource = Me.DSAsserts
        '
        'Tbl_Asserts_TypeTableAdapter
        '
        Me.Tbl_Asserts_TypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Assert_OR_LifeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Asserts_TypeTableAdapter = Me.Tbl_Asserts_TypeTableAdapter
        Me.TableAdapterManager.tbl_AssertTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSAssertsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.view_AssertsTableAdapter = Nothing
        '
        'Tbl_Asserts_TypeDataGridView
        '
        Me.Tbl_Asserts_TypeDataGridView.AllowUserToAddRows = False
        Me.Tbl_Asserts_TypeDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_Asserts_TypeDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Asserts_TypeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Asserts_TypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Asserts_TypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.Tbl_Asserts_TypeDataGridView.DataSource = Me.Tbl_Asserts_TypeBindingSource
        Me.Tbl_Asserts_TypeDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.Tbl_Asserts_TypeDataGridView.Name = "Tbl_Asserts_TypeDataGridView"
        Me.Tbl_Asserts_TypeDataGridView.RowHeadersWidth = 23
        Me.Tbl_Asserts_TypeDataGridView.Size = New System.Drawing.Size(529, 534)
        Me.Tbl_Asserts_TypeDataGridView.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Asserts_TypeBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_Asserts_TypeDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(6, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 568)
        Me.Panel1.TabIndex = 2
        '
        'Tbl_Asserts_TypeBindingNavigator
        '
        Me.Tbl_Asserts_TypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Asserts_TypeBindingNavigator.BindingSource = Me.Tbl_Asserts_TypeBindingSource
        Me.Tbl_Asserts_TypeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Asserts_TypeBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Asserts_TypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_Asserts_TypeBindingNavigatorSaveItem})
        Me.Tbl_Asserts_TypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Asserts_TypeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Asserts_TypeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Asserts_TypeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Asserts_TypeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Asserts_TypeBindingNavigator.Name = "Tbl_Asserts_TypeBindingNavigator"
        Me.Tbl_Asserts_TypeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Asserts_TypeBindingNavigator.Size = New System.Drawing.Size(532, 25)
        Me.Tbl_Asserts_TypeBindingNavigator.TabIndex = 2
        Me.Tbl_Asserts_TypeBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Asserts_TypeBindingNavigatorSaveItem
        '
        Me.Tbl_Asserts_TypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Asserts_TypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Asserts_TypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Asserts_TypeBindingNavigatorSaveItem.Name = "Tbl_Asserts_TypeBindingNavigatorSaveItem"
        Me.Tbl_Asserts_TypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Asserts_TypeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Firebrick
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(696, 40)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Assets Type "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AssertType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Assets Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 400
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 80
        '
        'Frm_Asserts_type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 750)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Asserts_type"
        Me.Text = "Asserts Type"
        CType(Me.DSAsserts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Asserts_TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Asserts_TypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Asserts_TypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Asserts_TypeBindingNavigator.ResumeLayout(False)
        Me.Tbl_Asserts_TypeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSAsserts As DSAsserts
    Friend WithEvents Tbl_Asserts_TypeBindingSource As BindingSource
    Friend WithEvents Tbl_Asserts_TypeTableAdapter As DSAssertsTableAdapters.tbl_Asserts_TypeTableAdapter
    Friend WithEvents TableAdapterManager As DSAssertsTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Asserts_TypeDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbl_Asserts_TypeBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_Asserts_TypeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
