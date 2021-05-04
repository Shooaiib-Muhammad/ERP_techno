<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptArticle
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
        Dim ArtCodeLabel1 As System.Windows.Forms.Label
        Dim ArtCodeLabel As System.Windows.Forms.Label
        Dim L4NameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.DSArticle = New FS_ERP_MM.DSArticle()
        Me.Tbl_Pro_ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_ClientTableAdapter = New FS_ERP_MM.DSArticleTableAdapters.tbl_Pro_ClientTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSArticleTableAdapters.TableAdapterManager()
        Me.Tbl_Pro_ArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_ArticleTableAdapter = New FS_ERP_MM.DSArticleTableAdapters.tbl_Pro_ArticleTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.L4NameComboBox = New System.Windows.Forms.ComboBox()
        Me.View_L4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ArtCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.View_L4TableAdapter = New FS_ERP_MM.DSArticleTableAdapters.View_L4TableAdapter()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        ArtCodeLabel1 = New System.Windows.Forms.Label()
        ArtCodeLabel = New System.Windows.Forms.Label()
        L4NameLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DSArticle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_ArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.View_L4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArtCodeLabel1
        '
        ArtCodeLabel1.Location = New System.Drawing.Point(10, 52)
        ArtCodeLabel1.Name = "ArtCodeLabel1"
        ArtCodeLabel1.Size = New System.Drawing.Size(78, 20)
        ArtCodeLabel1.TabIndex = 15
        ArtCodeLabel1.Text = "Article No.:"
        ArtCodeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ArtCodeLabel
        '
        ArtCodeLabel.Location = New System.Drawing.Point(10, 23)
        ArtCodeLabel.Name = "ArtCodeLabel"
        ArtCodeLabel.Size = New System.Drawing.Size(78, 20)
        ArtCodeLabel.TabIndex = 12
        ArtCodeLabel.Text = "Client Name:"
        ArtCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L4NameLabel
        '
        L4NameLabel.AutoSize = True
        L4NameLabel.Location = New System.Drawing.Point(10, 81)
        L4NameLabel.Name = "L4NameLabel"
        L4NameLabel.Size = New System.Drawing.Size(78, 13)
        L4NameLabel.TabIndex = 32
        L4NameLabel.Text = "Material Name:"
        '
        'DSArticle
        '
        Me.DSArticle.DataSetName = "DSArticle"
        Me.DSArticle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Pro_ClientBindingSource
        '
        Me.Tbl_Pro_ClientBindingSource.DataMember = "tbl_Pro_Client"
        Me.Tbl_Pro_ClientBindingSource.DataSource = Me.DSArticle
        '
        'Tbl_Pro_ClientTableAdapter
        '
        Me.Tbl_Pro_ClientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Pro_ClientTableAdapter = Me.Tbl_Pro_ClientTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSArticleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Pro_ArticleBindingSource
        '
        Me.Tbl_Pro_ArticleBindingSource.DataMember = "tbl_Pro_Client_tbl_Pro_Article"
        Me.Tbl_Pro_ArticleBindingSource.DataSource = Me.Tbl_Pro_ClientBindingSource
        '
        'Tbl_Pro_ArticleTableAdapter
        '
        Me.Tbl_Pro_ArticleTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(L4NameLabel)
        Me.GroupBox3.Controls.Add(Me.L4NameComboBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(ArtCodeLabel1)
        Me.GroupBox3.Controls.Add(Me.ArtCodeComboBox)
        Me.GroupBox3.Controls.Add(ArtCodeLabel)
        Me.GroupBox3.Controls.Add(Me.ClientNameComboBox)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(599, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 287)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selector"
        '
        'L4NameComboBox
        '
        Me.L4NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L4NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L4NameComboBox.DataSource = Me.View_L4BindingSource
        Me.L4NameComboBox.DisplayMember = "L4Name"
        Me.L4NameComboBox.FormattingEnabled = True
        Me.L4NameComboBox.Location = New System.Drawing.Point(93, 78)
        Me.L4NameComboBox.Name = "L4NameComboBox"
        Me.L4NameComboBox.Size = New System.Drawing.Size(290, 21)
        Me.L4NameComboBox.TabIndex = 33
        Me.L4NameComboBox.ValueMember = "Code"
        '
        'View_L4BindingSource
        '
        Me.View_L4BindingSource.DataMember = "View_L4"
        Me.View_L4BindingSource.DataSource = Me.DSArticle
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "To Date:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(93, 161)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePicker2.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "From Date:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 135)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePicker1.TabIndex = 29
        '
        'ArtCodeComboBox
        '
        Me.ArtCodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ArtCodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ArtCodeComboBox.DataSource = Me.Tbl_Pro_ArticleBindingSource
        Me.ArtCodeComboBox.DisplayMember = "ArtCode"
        Me.ArtCodeComboBox.FormattingEnabled = True
        Me.ArtCodeComboBox.Location = New System.Drawing.Point(93, 51)
        Me.ArtCodeComboBox.Name = "ArtCodeComboBox"
        Me.ArtCodeComboBox.Size = New System.Drawing.Size(144, 21)
        Me.ArtCodeComboBox.TabIndex = 16
        Me.ArtCodeComboBox.ValueMember = "ArtCode"
        '
        'ClientNameComboBox
        '
        Me.ClientNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ClientNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ClientNameComboBox.DataSource = Me.Tbl_Pro_ClientBindingSource
        Me.ClientNameComboBox.DisplayMember = "ClientName"
        Me.ClientNameComboBox.FormattingEnabled = True
        Me.ClientNameComboBox.Location = New System.Drawing.Point(93, 23)
        Me.ClientNameComboBox.Name = "ClientNameComboBox"
        Me.ClientNameComboBox.Size = New System.Drawing.Size(144, 21)
        Me.ClientNameComboBox.TabIndex = 2
        Me.ClientNameComboBox.ValueMember = "ClientID"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(145, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1373, 41)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Daily Material Issuance Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 287)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Report Type"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(202, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Daily Issuance Report by Article Wise"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'View_L4TableAdapter
        '
        Me.View_L4TableAdapter.ClearBeforeFill = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 55)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(218, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Material Issuance Against Articles Report"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(10, 106)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(78, 20)
        Label2.TabIndex = 34
        Label2.Text = "Factory Code:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"B34001", "B34002", "B34003", "B34004", "B34005", "B34006"})
        Me.ComboBox1.Location = New System.Drawing.Point(93, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 35
        Me.ComboBox1.Text = "B34001"
        '
        'frmRptArticle
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 617)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmRptArticle"
        Me.Text = "Daily Material Issuance Report"
        CType(Me.DSArticle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_ArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.View_L4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSArticle As FS_ERP_MM.DSArticle
    Friend WithEvents Tbl_Pro_ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pro_ClientTableAdapter As FS_ERP_MM.DSArticleTableAdapters.tbl_Pro_ClientTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSArticleTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Pro_ArticleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Pro_ArticleTableAdapter As FS_ERP_MM.DSArticleTableAdapters.tbl_Pro_ArticleTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ArtCodeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClientNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents View_L4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_L4TableAdapter As FS_ERP_MM.DSArticleTableAdapters.View_L4TableAdapter
    Friend WithEvents L4NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
End Class
