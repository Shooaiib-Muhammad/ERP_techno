<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompany
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
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ReportsPathLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompany))
        Me.DSUL = New FS_ERP_MM.DSUL()
        Me.Tbl_Comp_ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Comp_ProfileTableAdapter = New FS_ERP_MM.DSULTableAdapters.tbl_Comp_ProfileTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSULTableAdapters.TableAdapterManager()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ReportsPathTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Comp_ProfileBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Comp_ProfileBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ReportsPathLabel = New System.Windows.Forms.Label()
        CType(Me.DSUL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Comp_ProfileBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Comp_ProfileBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSUL
        '
        Me.DSUL.DataSetName = "DSUL"
        Me.DSUL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Comp_ProfileBindingSource
        '
        Me.Tbl_Comp_ProfileBindingSource.DataMember = "tbl_Comp_Profile"
        Me.Tbl_Comp_ProfileBindingSource.DataSource = Me.DSUL
        '
        'Tbl_Comp_ProfileTableAdapter
        '
        Me.Tbl_Comp_ProfileTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Comp_ProfileTableAdapter = Me.Tbl_Comp_ProfileTableAdapter
        Me.TableAdapterManager.tbl_IDMS_Sub_deptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_idms_user_deptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_LocalCustTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PIR_UsersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_User_LoginsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSULTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(13, 51)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(85, 13)
        CompanyNameLabel.TabIndex = 1
        CompanyNameLabel.Text = "Company Name:"
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_ProfileBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(104, 48)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(239, 20)
        Me.CompanyNameTextBox.TabIndex = 2
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(50, 77)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 3
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_ProfileBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(104, 74)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(239, 20)
        Me.AddressTextBox.TabIndex = 4
        '
        'ReportsPathLabel
        '
        ReportsPathLabel.AutoSize = True
        ReportsPathLabel.Location = New System.Drawing.Point(26, 103)
        ReportsPathLabel.Name = "ReportsPathLabel"
        ReportsPathLabel.Size = New System.Drawing.Size(72, 13)
        ReportsPathLabel.TabIndex = 5
        ReportsPathLabel.Text = "Reports Path:"
        '
        'ReportsPathTextBox
        '
        Me.ReportsPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_ProfileBindingSource, "ReportsPath", True))
        Me.ReportsPathTextBox.Location = New System.Drawing.Point(104, 100)
        Me.ReportsPathTextBox.Name = "ReportsPathTextBox"
        Me.ReportsPathTextBox.Size = New System.Drawing.Size(362, 20)
        Me.ReportsPathTextBox.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Comp_ProfileBindingNavigator)
        Me.Panel1.Controls.Add(ReportsPathLabel)
        Me.Panel1.Controls.Add(Me.ReportsPathTextBox)
        Me.Panel1.Controls.Add(Me.CompanyNameTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(CompanyNameLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Location = New System.Drawing.Point(6, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 143)
        Me.Panel1.TabIndex = 24
        '
        'Tbl_Comp_ProfileBindingNavigator
        '
        Me.Tbl_Comp_ProfileBindingNavigator.AddNewItem = Nothing
        Me.Tbl_Comp_ProfileBindingNavigator.BindingSource = Me.Tbl_Comp_ProfileBindingSource
        Me.Tbl_Comp_ProfileBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Comp_ProfileBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Comp_ProfileBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Tbl_Comp_ProfileBindingNavigatorSaveItem})
        Me.Tbl_Comp_ProfileBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Comp_ProfileBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Comp_ProfileBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Comp_ProfileBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Comp_ProfileBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Comp_ProfileBindingNavigator.Name = "Tbl_Comp_ProfileBindingNavigator"
        Me.Tbl_Comp_ProfileBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Comp_ProfileBindingNavigator.Size = New System.Drawing.Size(523, 25)
        Me.Tbl_Comp_ProfileBindingNavigator.TabIndex = 24
        Me.Tbl_Comp_ProfileBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Comp_ProfileBindingNavigatorSaveItem
        '
        Me.Tbl_Comp_ProfileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Comp_ProfileBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Comp_ProfileBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Comp_ProfileBindingNavigatorSaveItem.Name = "Tbl_Comp_ProfileBindingNavigatorSaveItem"
        Me.Tbl_Comp_ProfileBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Comp_ProfileBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(590, 40)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Company Profile"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 296)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCompany"
        Me.Text = "FrmCompany"
        CType(Me.DSUL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Comp_ProfileBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Comp_ProfileBindingNavigator.ResumeLayout(False)
        Me.Tbl_Comp_ProfileBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSUL As DSUL
    Friend WithEvents Tbl_Comp_ProfileBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_ProfileTableAdapter As DSULTableAdapters.tbl_Comp_ProfileTableAdapter
    Friend WithEvents TableAdapterManager As DSULTableAdapters.TableAdapterManager
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents ReportsPathTextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbl_Comp_ProfileBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_Comp_ProfileBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
End Class
