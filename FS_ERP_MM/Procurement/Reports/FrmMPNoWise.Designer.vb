<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMPNoWise
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Layer1IDLabel As System.Windows.Forms.Label
        Dim Datelabel1 As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MPIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DSRpt = New FS_ERP_MM.DSRpt()
        Me.Tbl_Pro_Plan1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_Plan1TableAdapter = New FS_ERP_MM.DSRptTableAdapters.tbl_Pro_Plan1TableAdapter()
        Me.TableAdapterManager = New FS_ERP_MM.DSRptTableAdapters.TableAdapterManager()
        Layer1IDLabel = New System.Windows.Forms.Label()
        Datelabel1 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DSRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_Plan1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1059, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Daily Material Issuance Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.MPIDComboBox)
        Me.GroupBox2.Controls.Add(Layer1IDLabel)
        Me.GroupBox2.Controls.Add(Datelabel1)
        Me.GroupBox2.Controls.Add(DateLabel)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(186, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 139)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selector"
        '
        'MPIDComboBox
        '
        Me.MPIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MPIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MPIDComboBox.DataSource = Me.Tbl_Pro_Plan1BindingSource
        Me.MPIDComboBox.DisplayMember = "MPID"
        Me.MPIDComboBox.Enabled = False
        Me.MPIDComboBox.FormattingEnabled = True
        Me.MPIDComboBox.Location = New System.Drawing.Point(117, 68)
        Me.MPIDComboBox.Name = "MPIDComboBox"
        Me.MPIDComboBox.Size = New System.Drawing.Size(118, 21)
        Me.MPIDComboBox.TabIndex = 24
        Me.MPIDComboBox.ValueMember = "MPID"
        '
        'Layer1IDLabel
        '
        Layer1IDLabel.Location = New System.Drawing.Point(9, 69)
        Layer1IDLabel.Name = "Layer1IDLabel"
        Layer1IDLabel.Size = New System.Drawing.Size(107, 20)
        Layer1IDLabel.TabIndex = 22
        Layer1IDLabel.Text = "Master Plan Number:"
        Layer1IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Datelabel1
        '
        Datelabel1.Location = New System.Drawing.Point(9, 45)
        Datelabel1.Name = "Datelabel1"
        Datelabel1.Size = New System.Drawing.Size(107, 20)
        Datelabel1.TabIndex = 9
        Datelabel1.Text = "Select Date:"
        Datelabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.Location = New System.Drawing.Point(9, 19)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(107, 20)
        DateLabel.TabIndex = 8
        DateLabel.Text = "Select Date:"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(117, 45)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(117, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 48)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(143, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Material Issuance Report"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(174, 78)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selector"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.Text = "By Date Wise"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.Text = "By MPNO Wise"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(117, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 30)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DSRpt
        '
        Me.DSRpt.DataSetName = "DSRpt"
        Me.DSRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Pro_Plan1BindingSource
        '
        Me.Tbl_Pro_Plan1BindingSource.DataMember = "tbl_Pro_Plan1"
        Me.Tbl_Pro_Plan1BindingSource.DataSource = Me.DSRpt
        '
        'Tbl_Pro_Plan1TableAdapter
        '
        Me.Tbl_Pro_Plan1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L41TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_Supplier1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inv_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MM_CustomerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Prd_LinesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_Plan1TableAdapter = Me.Tbl_Pro_Plan1TableAdapter
        Me.TableAdapterManager.tbl_Pro_Plan2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSRptTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmMPNoWise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 785)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMPNoWise"
        Me.Text = "FrmMPNoWise"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DSRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_Plan1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MPIDComboBox As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents DSRpt As DSRpt
    Friend WithEvents Tbl_Pro_Plan1BindingSource As BindingSource
    Friend WithEvents Tbl_Pro_Plan1TableAdapter As DSRptTableAdapters.tbl_Pro_Plan1TableAdapter
    Friend WithEvents TableAdapterManager As DSRptTableAdapters.TableAdapterManager
End Class
