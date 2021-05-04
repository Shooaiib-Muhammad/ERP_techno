<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IDMS_User_Dept
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
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IDMS_User_Dept))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DSUL = New FS_ERP_MM.DSUL()
        Me.Tbl_PIR_UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PIR_UsersTableAdapter = New FS_ERP_MM.DSULTableAdapters.tbl_PIR_UsersTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSULTableAdapters.TableAdapterManager()
        Me.Tbl_idms_user_deptTableAdapter = New FS_ERP_MM.DSULTableAdapters.tbl_idms_user_deptTableAdapter()
        Me.Tbl_idms_user_deptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_IDMS_Sub_deptDataGridView = New System.Windows.Forms.DataGridView()
        Me.UserNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Inv_LocalCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_LocalCustTableAdapter = New FS_ERP_MM.DSULTableAdapters.tbl_Inv_LocalCustTableAdapter()
        Me.DeptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.StausDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        UserNameLabel = New System.Windows.Forms.Label()
        CType(Me.DSUL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PIR_UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_idms_user_deptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_IDMS_Sub_deptDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(26, 58)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(99, 13)
        UserNameLabel.TabIndex = 9
        UserNameLabel.Text = "Select User Name :"
        '
        'DSUL
        '
        Me.DSUL.DataSetName = "DSUL"
        Me.DSUL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_PIR_UsersBindingSource
        '
        Me.Tbl_PIR_UsersBindingSource.DataMember = "tbl_PIR_Users"
        Me.Tbl_PIR_UsersBindingSource.DataSource = Me.DSUL
        '
        'Tbl_PIR_UsersTableAdapter
        '
        Me.Tbl_PIR_UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_IDMS_Sub_deptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_idms_user_deptTableAdapter = Me.Tbl_idms_user_deptTableAdapter
        Me.TableAdapterManager.tbl_Inv_LocalCustTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PIR_UsersTableAdapter = Me.Tbl_PIR_UsersTableAdapter
        Me.TableAdapterManager.tbl_User_LoginsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSULTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_idms_user_deptTableAdapter
        '
        Me.Tbl_idms_user_deptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_idms_user_deptBindingSource
        '
        Me.Tbl_idms_user_deptBindingSource.DataMember = "tbl_PIR_Users_tbl_idms_user_dept"
        Me.Tbl_idms_user_deptBindingSource.DataSource = Me.Tbl_PIR_UsersBindingSource
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.Tbl_IDMS_Sub_deptDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(21, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 287)
        Me.Panel1.TabIndex = 11
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_idms_user_deptBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(385, 25)
        Me.BindingNavigator1.TabIndex = 3
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.FS_ERP_MM.My.Resources.Resources.images1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Tbl_IDMS_Sub_deptDataGridView
        '
        Me.Tbl_IDMS_Sub_deptDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_IDMS_Sub_deptDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_IDMS_Sub_deptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_IDMS_Sub_deptDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeptIDDataGridViewTextBoxColumn, Me.StausDataGridViewCheckBoxColumn})
        Me.Tbl_IDMS_Sub_deptDataGridView.DataSource = Me.Tbl_idms_user_deptBindingSource
        Me.Tbl_IDMS_Sub_deptDataGridView.Location = New System.Drawing.Point(3, 27)
        Me.Tbl_IDMS_Sub_deptDataGridView.Name = "Tbl_IDMS_Sub_deptDataGridView"
        Me.Tbl_IDMS_Sub_deptDataGridView.RowHeadersWidth = 23
        Me.Tbl_IDMS_Sub_deptDataGridView.Size = New System.Drawing.Size(379, 256)
        Me.Tbl_IDMS_Sub_deptDataGridView.TabIndex = 2
        '
        'UserNameComboBox
        '
        Me.UserNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.UserNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UserNameComboBox.DataSource = Me.Tbl_PIR_UsersBindingSource
        Me.UserNameComboBox.DisplayMember = "UserName"
        Me.UserNameComboBox.FormattingEnabled = True
        Me.UserNameComboBox.Location = New System.Drawing.Point(133, 55)
        Me.UserNameComboBox.Name = "UserNameComboBox"
        Me.UserNameComboBox.Size = New System.Drawing.Size(165, 21)
        Me.UserNameComboBox.TabIndex = 10
        Me.UserNameComboBox.ValueMember = "UserID"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(940, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "IDMS Sub Dept "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Inv_LocalCustBindingSource
        '
        Me.Tbl_Inv_LocalCustBindingSource.DataMember = "tbl_Inv_LocalCust"
        Me.Tbl_Inv_LocalCustBindingSource.DataSource = Me.DSUL
        '
        'Tbl_Inv_LocalCustTableAdapter
        '
        Me.Tbl_Inv_LocalCustTableAdapter.ClearBeforeFill = True
        '
        'DeptIDDataGridViewTextBoxColumn
        '
        Me.DeptIDDataGridViewTextBoxColumn.DataPropertyName = "DeptID"
        Me.DeptIDDataGridViewTextBoxColumn.DataSource = Me.Tbl_Inv_LocalCustBindingSource
        Me.DeptIDDataGridViewTextBoxColumn.DisplayMember = "CustName"
        Me.DeptIDDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = True
        Me.DeptIDDataGridViewTextBoxColumn.HeaderText = "User Sub Dept."
        Me.DeptIDDataGridViewTextBoxColumn.Name = "DeptIDDataGridViewTextBoxColumn"
        Me.DeptIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeptIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DeptIDDataGridViewTextBoxColumn.ValueMember = "LocalCustID"
        Me.DeptIDDataGridViewTextBoxColumn.Width = 200
        '
        'StausDataGridViewCheckBoxColumn
        '
        Me.StausDataGridViewCheckBoxColumn.DataPropertyName = "Staus"
        Me.StausDataGridViewCheckBoxColumn.HeaderText = "Staus"
        Me.StausDataGridViewCheckBoxColumn.Name = "StausDataGridViewCheckBoxColumn"
        Me.StausDataGridViewCheckBoxColumn.Width = 80
        '
        'IDMS_User_Dept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameComboBox)
        Me.Name = "IDMS_User_Dept"
        Me.Text = "IDMS_User_Dept"
        CType(Me.DSUL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PIR_UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_idms_user_deptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_IDMS_Sub_deptDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSUL As DSUL
    Friend WithEvents Tbl_PIR_UsersBindingSource As BindingSource
    Friend WithEvents Tbl_PIR_UsersTableAdapter As DSULTableAdapters.tbl_PIR_UsersTableAdapter
    Friend WithEvents TableAdapterManager As DSULTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_idms_user_deptTableAdapter As DSULTableAdapters.tbl_idms_user_deptTableAdapter
    Friend WithEvents Tbl_idms_user_deptBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Tbl_IDMS_Sub_deptDataGridView As DataGridView
    Friend WithEvents UserNameComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tbl_Inv_LocalCustBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_LocalCustTableAdapter As DSULTableAdapters.tbl_Inv_LocalCustTableAdapter
    Friend WithEvents DeptIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents StausDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
