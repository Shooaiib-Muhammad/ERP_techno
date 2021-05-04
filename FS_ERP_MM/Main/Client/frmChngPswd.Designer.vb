<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChngPswd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOldPswd = New System.Windows.Forms.TextBox()
        Me.txtNewPswd = New System.Windows.Forms.TextBox()
        Me.txtConfirmdPswd = New System.Windows.Forms.TextBox()
        Me.TranTypeLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FullNameLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_User_LoginsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUM = New FS_ERP_MM.DSUM()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoginNameLabel1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnChngPswd = New System.Windows.Forms.Button()
        Me.Tbl_User_LoginsTableAdapter = New FS_ERP_MM.DSUMTableAdapters.tbl_User_LoginsTableAdapter()
        Me.TableAdapterManager1 = New FS_ERP_MM.DSUMTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_User_LoginsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUM, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(643, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User Change Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOldPswd
        '
        Me.txtOldPswd.Location = New System.Drawing.Point(140, 73)
        Me.txtOldPswd.Name = "txtOldPswd"
        Me.txtOldPswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPswd.Size = New System.Drawing.Size(175, 20)
        Me.txtOldPswd.TabIndex = 6
        '
        'txtNewPswd
        '
        Me.txtNewPswd.Location = New System.Drawing.Point(140, 99)
        Me.txtNewPswd.Name = "txtNewPswd"
        Me.txtNewPswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPswd.Size = New System.Drawing.Size(175, 20)
        Me.txtNewPswd.TabIndex = 7
        '
        'txtConfirmdPswd
        '
        Me.txtConfirmdPswd.Location = New System.Drawing.Point(140, 125)
        Me.txtConfirmdPswd.Name = "txtConfirmdPswd"
        Me.txtConfirmdPswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmdPswd.Size = New System.Drawing.Size(175, 20)
        Me.txtConfirmdPswd.TabIndex = 8
        '
        'TranTypeLabel
        '
        Me.TranTypeLabel.Location = New System.Drawing.Point(34, 73)
        Me.TranTypeLabel.Name = "TranTypeLabel"
        Me.TranTypeLabel.Size = New System.Drawing.Size(100, 20)
        Me.TranTypeLabel.TabIndex = 9
        Me.TranTypeLabel.Text = "Old Password:"
        Me.TranTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(34, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "New Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(34, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Confirm Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FullNameLabel1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LoginNameLabel1)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnChngPswd)
        Me.Panel1.Controls.Add(Me.TranTypeLabel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtOldPswd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNewPswd)
        Me.Panel1.Controls.Add(Me.txtConfirmdPswd)
        Me.Panel1.Location = New System.Drawing.Point(153, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 196)
        Me.Panel1.TabIndex = 12
        '
        'FullNameLabel1
        '
        Me.FullNameLabel1.BackColor = System.Drawing.Color.AliceBlue
        Me.FullNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FullNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_User_LoginsBindingSource, "FullName", True))
        Me.FullNameLabel1.Location = New System.Drawing.Point(140, 10)
        Me.FullNameLabel1.Name = "FullNameLabel1"
        Me.FullNameLabel1.Size = New System.Drawing.Size(175, 20)
        Me.FullNameLabel1.TabIndex = 22
        Me.FullNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_User_LoginsBindingSource
        '
        Me.Tbl_User_LoginsBindingSource.DataMember = "tbl_User_Logins"
        Me.Tbl_User_LoginsBindingSource.DataSource = Me.DSUM
        '
        'DSUM
        '
        Me.DSUM.DataSetName = "DSUM"
        Me.DSUM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(34, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "User Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(34, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Login Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LoginNameLabel1
        '
        Me.LoginNameLabel1.BackColor = System.Drawing.Color.AliceBlue
        Me.LoginNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_User_LoginsBindingSource, "LoginName", True))
        Me.LoginNameLabel1.Location = New System.Drawing.Point(140, 35)
        Me.LoginNameLabel1.Name = "LoginNameLabel1"
        Me.LoginNameLabel1.Size = New System.Drawing.Size(175, 20)
        Me.LoginNameLabel1.TabIndex = 19
        Me.LoginNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkRed
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(219, 151)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnChngPswd
        '
        Me.btnChngPswd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChngPswd.Location = New System.Drawing.Point(95, 151)
        Me.btnChngPswd.Name = "btnChngPswd"
        Me.btnChngPswd.Size = New System.Drawing.Size(118, 23)
        Me.btnChngPswd.TabIndex = 15
        Me.btnChngPswd.Text = "&Change Password"
        Me.btnChngPswd.UseVisualStyleBackColor = True
        '
        'Tbl_User_LoginsTableAdapter
        '
        Me.Tbl_User_LoginsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_User_AccountsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_User_DomainTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_User_ERP_ModTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_User_LoginsTableAdapter = Me.Tbl_User_LoginsTableAdapter
        Me.TableAdapterManager1.tbl_User_LogTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = FS_ERP_MM.DSUMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmChngPswd
        '
        Me.AcceptButton = Me.btnChngPswd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(643, 343)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChngPswd"
        Me.Text = "Users Password Change"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_User_LoginsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOldPswd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPswd As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmdPswd As System.Windows.Forms.TextBox
    Friend WithEvents TranTypeLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnChngPswd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LoginNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DSUM As FS_ERP_MM.DSUM
    Friend WithEvents Tbl_User_LoginsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_User_LoginsTableAdapter As FS_ERP_MM.DSUMTableAdapters.tbl_User_LoginsTableAdapter
    Friend WithEvents TableAdapterManager1 As FS_ERP_MM.DSUMTableAdapters.TableAdapterManager
    Friend WithEvents FullNameLabel1 As System.Windows.Forms.Label
End Class
