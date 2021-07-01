<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginVer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DepartmentIDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.View_User_AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_User_DomainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUM = New FS_ERP_MM.DSUM()
        Me.Tbl_User_LoginsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager1 = New FS_ERP_MM.DSUMTableAdapters.TableAdapterManager()
        Me.Tbl_User_DomainTableAdapter = New FS_ERP_MM.DSUMTableAdapters.tbl_User_DomainTableAdapter()
        Me.Tbl_User_LoginsTableAdapter = New FS_ERP_MM.DSUMTableAdapters.tbl_User_LoginsTableAdapter()
        Me.Tbl_User_LogTableAdapter = New FS_ERP_MM.DSUMTableAdapters.tbl_User_LogTableAdapter()
        Me.Tbl_User_LogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_User_AccountsTableAdapter = New FS_ERP_MM.DSUMTableAdapters.View_User_AccountsTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPswd = New System.Windows.Forms.TextBox()
        Me.DepartmentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.UserIDComboBox = New System.Windows.Forms.ComboBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EntryDateLabel1 = New System.Windows.Forms.Label()
        Me.DSUL = New FS_ERP_MM.DSUL()
        Me.Tbl_Comp_ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Comp_ProfileTableAdapter = New FS_ERP_MM.DSULTableAdapters.tbl_Comp_ProfileTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSULTableAdapters.TableAdapterManager()
        Me.ReportsPathLabel1 = New System.Windows.Forms.Label()
        DepartmentIDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.View_User_AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_User_DomainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_User_LoginsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_User_LogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DSUL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentIDLabel
        '
        DepartmentIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DepartmentIDLabel.Location = New System.Drawing.Point(17, 17)
        DepartmentIDLabel.Name = "DepartmentIDLabel"
        DepartmentIDLabel.Size = New System.Drawing.Size(96, 20)
        DepartmentIDLabel.TabIndex = 6
        DepartmentIDLabel.Text = "Domain:"
        DepartmentIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label1.Location = New System.Drawing.Point(17, 44)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(96, 20)
        Label1.TabIndex = 13
        Label1.Text = "Login Name:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label2.Location = New System.Drawing.Point(17, 69)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(96, 22)
        Label2.TabIndex = 10
        Label2.Text = "Password:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'View_User_AccountsBindingSource
        '
        Me.View_User_AccountsBindingSource.DataMember = "tbl_User_Domain_View_User_Accounts"
        Me.View_User_AccountsBindingSource.DataSource = Me.Tbl_User_DomainBindingSource
        '
        'Tbl_User_DomainBindingSource
        '
        Me.Tbl_User_DomainBindingSource.DataMember = "tbl_User_Domain"
        Me.Tbl_User_DomainBindingSource.DataSource = Me.DSUM
        '
        'DSUM
        '
        Me.DSUM.DataSetName = "DSUM"
        Me.DSUM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_User_LoginsBindingSource
        '
        Me.Tbl_User_LoginsBindingSource.DataMember = "tbl_User_Logins"
        Me.Tbl_User_LoginsBindingSource.DataSource = Me.DSUM
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Inv_LocalCustTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_User_AccountsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_User_DomainTableAdapter = Me.Tbl_User_DomainTableAdapter
        Me.TableAdapterManager1.tbl_User_ERP_ModTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_User_LoginsTableAdapter = Me.Tbl_User_LoginsTableAdapter
        Me.TableAdapterManager1.tbl_User_LogTableAdapter = Me.Tbl_User_LogTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DSUMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_User_DomainTableAdapter
        '
        Me.Tbl_User_DomainTableAdapter.ClearBeforeFill = True
        '
        'Tbl_User_LoginsTableAdapter
        '
        Me.Tbl_User_LoginsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_User_LogTableAdapter
        '
        Me.Tbl_User_LogTableAdapter.ClearBeforeFill = True
        '
        'Tbl_User_LogBindingSource
        '
        Me.Tbl_User_LogBindingSource.DataMember = "tbl_User_Log"
        Me.Tbl_User_LogBindingSource.DataSource = Me.DSUM
        '
        'View_User_AccountsTableAdapter
        '
        Me.View_User_AccountsTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.FS_ERP_MM.My.Resources.Resources._68_512
        Me.PictureBox1.Location = New System.Drawing.Point(21, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(DepartmentIDLabel)
        Me.Panel1.Controls.Add(Me.txtPswd)
        Me.Panel1.Controls.Add(Me.DepartmentIDComboBox)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.UserIDComboBox)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(286, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 157)
        Me.Panel1.TabIndex = 18
        '
        'txtPswd
        '
        Me.txtPswd.BackColor = System.Drawing.Color.White
        Me.txtPswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPswd.Location = New System.Drawing.Point(119, 71)
        Me.txtPswd.Name = "txtPswd"
        Me.txtPswd.Size = New System.Drawing.Size(177, 20)
        Me.txtPswd.TabIndex = 11
        Me.txtPswd.UseSystemPasswordChar = True
        '
        'DepartmentIDComboBox
        '
        Me.DepartmentIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DepartmentIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DepartmentIDComboBox.BackColor = System.Drawing.Color.White
        Me.DepartmentIDComboBox.DataSource = Me.Tbl_User_DomainBindingSource
        Me.DepartmentIDComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentIDComboBox.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentIDComboBox.FormattingEnabled = True
        Me.DepartmentIDComboBox.Location = New System.Drawing.Point(119, 16)
        Me.DepartmentIDComboBox.Name = "DepartmentIDComboBox"
        Me.DepartmentIDComboBox.Size = New System.Drawing.Size(177, 24)
        Me.DepartmentIDComboBox.TabIndex = 8
        Me.DepartmentIDComboBox.ValueMember = "DepartmentID"
        '
        'UserIDComboBox
        '
        Me.UserIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.UserIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UserIDComboBox.BackColor = System.Drawing.Color.White
        Me.UserIDComboBox.DataSource = Me.View_User_AccountsBindingSource
        Me.UserIDComboBox.DisplayMember = "LoginName"
        Me.UserIDComboBox.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDComboBox.FormattingEnabled = True
        Me.UserIDComboBox.Location = New System.Drawing.Point(119, 43)
        Me.UserIDComboBox.Name = "UserIDComboBox"
        Me.UserIDComboBox.Size = New System.Drawing.Size(177, 24)
        Me.UserIDComboBox.TabIndex = 8
        Me.UserIDComboBox.ValueMember = "UserID"
        '
        'btnLogin
        '
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogin.Location = New System.Drawing.Point(93, 99)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 27)
        Me.btnLogin.TabIndex = 14
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkRed
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(195, 99)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 27)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(280, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(323, 74)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Welcome To Forward Sports ERP-MM System"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EntryDateLabel1
        '
        Me.EntryDateLabel1.ForeColor = System.Drawing.SystemColors.Info
        Me.EntryDateLabel1.Location = New System.Drawing.Point(476, 309)
        Me.EntryDateLabel1.Name = "EntryDateLabel1"
        Me.EntryDateLabel1.Size = New System.Drawing.Size(100, 13)
        Me.EntryDateLabel1.TabIndex = 20
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
        'ReportsPathLabel1
        '
        Me.ReportsPathLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_ProfileBindingSource, "ReportsPath", True))
        Me.ReportsPathLabel1.ForeColor = System.Drawing.Color.White
        Me.ReportsPathLabel1.Location = New System.Drawing.Point(151, 293)
        Me.ReportsPathLabel1.Name = "ReportsPathLabel1"
        Me.ReportsPathLabel1.Size = New System.Drawing.Size(195, 23)
        Me.ReportsPathLabel1.TabIndex = 16
        Me.ReportsPathLabel1.Text = "Label4"
        '
        'frmLoginVer
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(665, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReportsPathLabel1)
        Me.Controls.Add(Me.EntryDateLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoginVer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.View_User_AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_User_DomainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_User_LoginsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_User_LogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DSUL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents Tbl_MIS_User_DeptBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents Tbl_MIS_User_DeptTableAdapter As fs_ERP_MM.DataSet1TableAdapters.tbl_MIS_User_DeptTableAdapter
    Friend WithEvents DSUM As FS_ERP_MM.DSUM
    Friend WithEvents TableAdapterManager1 As FS_ERP_MM.DSUMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_User_LogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_User_LogTableAdapter As FS_ERP_MM.DSUMTableAdapters.tbl_User_LogTableAdapter
    Friend WithEvents Tbl_User_DomainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_User_DomainTableAdapter As FS_ERP_MM.DSUMTableAdapters.tbl_User_DomainTableAdapter
    Friend WithEvents Tbl_User_LoginsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_User_LoginsTableAdapter As FS_ERP_MM.DSUMTableAdapters.tbl_User_LoginsTableAdapter
    Friend WithEvents View_User_AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_User_AccountsTableAdapter As FS_ERP_MM.DSUMTableAdapters.View_User_AccountsTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPswd As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UserIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents Tbl_Comp_InfoTableAdapter As fs_ERP_MM.DSUMTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents EntryDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents DSUL As DSUL
    Friend WithEvents Tbl_Comp_ProfileBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_ProfileTableAdapter As DSULTableAdapters.tbl_Comp_ProfileTableAdapter
    Friend WithEvents TableAdapterManager As DSULTableAdapters.TableAdapterManager
    Friend WithEvents ReportsPathLabel1 As Label
End Class
