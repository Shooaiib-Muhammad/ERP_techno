﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUL))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_User_LoginsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_User_LoginsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUL = New FS_ERP_MM.DSUL()
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
        Me.Tbl_User_LoginsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_User_LoginsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tbl_Inv_LocalCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbl_User_LoginsTableAdapter = New FS_ERP_MM.DSULTableAdapters.tbl_User_LoginsTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSULTableAdapters.TableAdapterManager()
        Me.Tbl_Inv_LocalCustTableAdapter = New FS_ERP_MM.DSULTableAdapters.tbl_Inv_LocalCustTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PSWDChngDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISHOD = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GMStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GPVerifyStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeptID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_User_LoginsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_User_LoginsBindingNavigator.SuspendLayout()
        CType(Me.Tbl_User_LoginsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_User_LoginsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1624, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Logins"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_User_LoginsBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_User_LoginsDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1331, 608)
        Me.Panel1.TabIndex = 2
        '
        'Tbl_User_LoginsBindingNavigator
        '
        Me.Tbl_User_LoginsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_User_LoginsBindingNavigator.BindingSource = Me.Tbl_User_LoginsBindingSource
        Me.Tbl_User_LoginsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_User_LoginsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_User_LoginsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_User_LoginsBindingNavigatorSaveItem})
        Me.Tbl_User_LoginsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_User_LoginsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_User_LoginsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_User_LoginsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_User_LoginsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_User_LoginsBindingNavigator.Name = "Tbl_User_LoginsBindingNavigator"
        Me.Tbl_User_LoginsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_User_LoginsBindingNavigator.Size = New System.Drawing.Size(1329, 25)
        Me.Tbl_User_LoginsBindingNavigator.TabIndex = 4
        Me.Tbl_User_LoginsBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_User_LoginsBindingSource
        '
        Me.Tbl_User_LoginsBindingSource.DataMember = "tbl_User_Logins"
        Me.Tbl_User_LoginsBindingSource.DataSource = Me.DSUL
        '
        'DSUL
        '
        Me.DSUL.DataSetName = "DSUL"
        Me.DSUL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'Tbl_User_LoginsBindingNavigatorSaveItem
        '
        Me.Tbl_User_LoginsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_User_LoginsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_User_LoginsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_User_LoginsBindingNavigatorSaveItem.Name = "Tbl_User_LoginsBindingNavigatorSaveItem"
        Me.Tbl_User_LoginsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_User_LoginsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_User_LoginsDataGridView
        '
        Me.Tbl_User_LoginsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_User_LoginsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_User_LoginsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_User_LoginsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.PSWDChngDate, Me.ISHOD, Me.GMStatus, Me.GPVerifyStatus, Me.DeptID})
        Me.Tbl_User_LoginsDataGridView.ContextMenuStrip = Me.SupplierContextMenuStrip
        Me.Tbl_User_LoginsDataGridView.DataSource = Me.Tbl_User_LoginsBindingSource
        Me.Tbl_User_LoginsDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_User_LoginsDataGridView.Name = "Tbl_User_LoginsDataGridView"
        Me.Tbl_User_LoginsDataGridView.Size = New System.Drawing.Size(1289, 575)
        Me.Tbl_User_LoginsDataGridView.TabIndex = 0
        '
        'Tbl_Inv_LocalCustBindingSource
        '
        Me.Tbl_Inv_LocalCustBindingSource.DataMember = "tbl_Inv_LocalCust"
        Me.Tbl_Inv_LocalCustBindingSource.DataSource = Me.DSUL
        '
        'SupplierContextMenuStrip
        '
        Me.SupplierContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.RemoveFilterToolStripMenuItem})
        Me.SupplierContextMenuStrip.Name = "SupplierContextMenuStrip"
        Me.SupplierContextMenuStrip.Size = New System.Drawing.Size(161, 51)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove &Filter"
        '
        'Tbl_User_LoginsTableAdapter
        '
        Me.Tbl_User_LoginsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_LocalCustTableAdapter = Nothing
        Me.TableAdapterManager.tbl_User_LoginsTableAdapter = Me.Tbl_User_LoginsTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSULTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Inv_LocalCustTableAdapter
        '
        Me.Tbl_Inv_LocalCustTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "User No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LoginName"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Login Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Password"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EntryDate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.HeaderText = "Entry Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IP"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "IP Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "SPStatus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Super Power"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 80
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 80
        '
        'PSWDChngDate
        '
        Me.PSWDChngDate.DataPropertyName = "PSWDChngDate"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "d"
        Me.PSWDChngDate.DefaultCellStyle = DataGridViewCellStyle7
        Me.PSWDChngDate.HeaderText = "PSWD Chng Date"
        Me.PSWDChngDate.Name = "PSWDChngDate"
        '
        'ISHOD
        '
        Me.ISHOD.DataPropertyName = "ISHOD"
        Me.ISHOD.HeaderText = "HOD Status"
        Me.ISHOD.Name = "ISHOD"
        '
        'GMStatus
        '
        Me.GMStatus.DataPropertyName = "GMStatus"
        Me.GMStatus.HeaderText = "GM Status"
        Me.GMStatus.Name = "GMStatus"
        '
        'GPVerifyStatus
        '
        Me.GPVerifyStatus.DataPropertyName = "GPVerifyStatus"
        Me.GPVerifyStatus.HeaderText = "GP Verify Status"
        Me.GPVerifyStatus.Name = "GPVerifyStatus"
        '
        'DeptID
        '
        Me.DeptID.DataPropertyName = "DeptID"
        Me.DeptID.DataSource = Me.Tbl_Inv_LocalCustBindingSource
        Me.DeptID.DisplayMember = "CustName"
        Me.DeptID.DisplayStyleForCurrentCellOnly = True
        Me.DeptID.HeaderText = "Department"
        Me.DeptID.Name = "DeptID"
        Me.DeptID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeptID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DeptID.ValueMember = "LocalCustID"
        '
        'frmUL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1624, 677)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUL"
        Me.Text = "User Logins"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_User_LoginsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_User_LoginsBindingNavigator.ResumeLayout(False)
        Me.Tbl_User_LoginsBindingNavigator.PerformLayout()
        CType(Me.Tbl_User_LoginsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_User_LoginsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_LocalCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierContextMenuStrip.ResumeLayout(False)
        Me.SupplierContextMenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DSUL As FS_ERP_MM.DSUL
    Friend WithEvents Tbl_User_LoginsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_User_LoginsTableAdapter As FS_ERP_MM.DSULTableAdapters.tbl_User_LoginsTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSULTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_User_LoginsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_User_LoginsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_User_LoginsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SupplierContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tbl_Inv_LocalCustBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_LocalCustTableAdapter As DSULTableAdapters.tbl_Inv_LocalCustTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents PSWDChngDate As DataGridViewTextBoxColumn
    Friend WithEvents ISHOD As DataGridViewCheckBoxColumn
    Friend WithEvents GMStatus As DataGridViewCheckBoxColumn
    Friend WithEvents GPVerifyStatus As DataGridViewCheckBoxColumn
    Friend WithEvents DeptID As DataGridViewComboBoxColumn
End Class
