<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptDailyTran
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
        Dim BENumberLabel As System.Windows.Forms.Label
        Dim BENumberLabel1 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BENumberComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_BE_Head1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRptBE = New FS_ERP_MM.DSRptBE()
        Me.BENumberComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_BE_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tbl_BE_HeadTableAdapter = New FS_ERP_MM.DSRptBETableAdapters.tbl_BE_HeadTableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSRptBETableAdapters.TableAdapterManager()
        Me.Tbl_BE_Head1TableAdapter = New FS_ERP_MM.DSRptBETableAdapters.tbl_BE_Head1TableAdapter()
        BENumberLabel = New System.Windows.Forms.Label()
        BENumberLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_BE_Head1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRptBE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_BE_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BENumberLabel
        '
        BENumberLabel.Location = New System.Drawing.Point(6, 87)
        BENumberLabel.Name = "BENumberLabel"
        BENumberLabel.Size = New System.Drawing.Size(81, 20)
        BENumberLabel.TabIndex = 5
        BENumberLabel.Text = "BENumber:"
        BENumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BENumberLabel1
        '
        BENumberLabel1.Location = New System.Drawing.Point(6, 115)
        BENumberLabel1.Name = "BENumberLabel1"
        BENumberLabel1.Size = New System.Drawing.Size(81, 20)
        BENumberLabel1.TabIndex = 7
        BENumberLabel1.Text = "BENumber:"
        BENumberLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(947, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bill Of Entry Material Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(140, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 380)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 33)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(109, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "B/E Detail Report"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton5.Location = New System.Drawing.Point(6, 150)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(155, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "B/E Material Ledger Report"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 125)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(188, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Material Wise B/E Balance Report"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 102)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(188, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "B/E Wise Material Balance Report"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 79)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(156, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Daily B/E Material Issuance"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(161, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Daily B/E Material Receiving"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(BENumberLabel1)
        Me.GroupBox2.Controls.Add(Me.BENumberComboBox1)
        Me.GroupBox2.Controls.Add(BENumberLabel)
        Me.GroupBox2.Controls.Add(Me.BENumberComboBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(444, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 380)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selector"
        '
        'BENumberComboBox1
        '
        Me.BENumberComboBox1.AccessibleDescription = ""
        Me.BENumberComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BENumberComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BENumberComboBox1.DataSource = Me.Tbl_BE_Head1BindingSource
        Me.BENumberComboBox1.DisplayMember = "BENumber"
        Me.BENumberComboBox1.FormattingEnabled = True
        Me.BENumberComboBox1.Location = New System.Drawing.Point(92, 114)
        Me.BENumberComboBox1.Name = "BENumberComboBox1"
        Me.BENumberComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.BENumberComboBox1.TabIndex = 8
        Me.BENumberComboBox1.ValueMember = "BEId"
        '
        'Tbl_BE_Head1BindingSource
        '
        Me.Tbl_BE_Head1BindingSource.DataMember = "tbl_BE_Head1"
        Me.Tbl_BE_Head1BindingSource.DataSource = Me.DSRptBE
        '
        'DSRptBE
        '
        Me.DSRptBE.DataSetName = "DSRptBE"
        Me.DSRptBE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BENumberComboBox
        '
        Me.BENumberComboBox.AccessibleDescription = ""
        Me.BENumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BENumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BENumberComboBox.DataSource = Me.Tbl_BE_HeadBindingSource
        Me.BENumberComboBox.DisplayMember = "BENumber"
        Me.BENumberComboBox.FormattingEnabled = True
        Me.BENumberComboBox.Location = New System.Drawing.Point(92, 86)
        Me.BENumberComboBox.Name = "BENumberComboBox"
        Me.BENumberComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BENumberComboBox.TabIndex = 6
        Me.BENumberComboBox.ValueMember = "BEId"
        '
        'Tbl_BE_HeadBindingSource
        '
        Me.Tbl_BE_HeadBindingSource.DataMember = "tbl_BE_Head"
        Me.Tbl_BE_HeadBindingSource.DataSource = Me.DSRptBE
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "End Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Start Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(92, 59)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(92, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(207, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Show Reports"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tbl_BE_HeadTableAdapter
        '
        Me.Tbl_BE_HeadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_BE_Head1TableAdapter = Me.Tbl_BE_Head1TableAdapter
        Me.TableAdapterManager.tbl_BE_HeadTableAdapter = Me.Tbl_BE_HeadTableAdapter
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSRptBETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_BE_Head1TableAdapter
        '
        Me.Tbl_BE_Head1TableAdapter.ClearBeforeFill = True
        '
        'frmRptDailyTran
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 479)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptDailyTran"
        Me.Text = "Bill Of Entry Material Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Tbl_BE_Head1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRptBE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_BE_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents DSRptBE As FS_ERP_MM.DSRptBE
    Friend WithEvents Tbl_BE_HeadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BE_HeadTableAdapter As FS_ERP_MM.DSRptBETableAdapters.tbl_BE_HeadTableAdapter
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSRptBETableAdapters.TableAdapterManager
    Friend WithEvents BENumberComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_BE_Head1TableAdapter As FS_ERP_MM.DSRptBETableAdapters.tbl_BE_Head1TableAdapter
    Friend WithEvents Tbl_BE_Head1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BENumberComboBox1 As System.Windows.Forms.ComboBox
End Class
