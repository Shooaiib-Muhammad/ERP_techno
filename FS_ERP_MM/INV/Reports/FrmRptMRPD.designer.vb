<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptMRPD
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim POLabel1 As System.Windows.Forms.Label
        Dim POLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PrdLineNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Prd_LinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSClient = New FS_ERP_MM.DSClient()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker2 = New System.Windows.Forms.DateTimePicker()
        Me.POComboBox1 = New System.Windows.Forms.ComboBox()
        Me.View_Rpt_Filter_PO1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POComboBox = New System.Windows.Forms.ComboBox()
        Me.View_Rpt_Filter_POBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New FS_ERP_MM.DSClientTableAdapters.TableAdapterManager()
        Me.Tbl_Prd_LinesTableAdapter = New FS_ERP_MM.DSClientTableAdapters.tbl_Prd_LinesTableAdapter()
        Me.View_Rpt_Filter_POTableAdapter = New FS_ERP_MM.DSClientTableAdapters.View_Rpt_Filter_POTableAdapter()
        Me.View_Rpt_Filter_PO1TableAdapter = New FS_ERP_MM.DSClientTableAdapters.View_Rpt_Filter_PO1TableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        POLabel1 = New System.Windows.Forms.Label()
        POLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Prd_LinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Filter_PO1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Filter_POBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(13, 145)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(103, 20)
        Label2.TabIndex = 8
        Label2.Text = "Enter End Date:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(13, 119)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(103, 20)
        Label3.TabIndex = 9
        Label3.Text = "Enter Start Date:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POLabel1
        '
        POLabel1.Location = New System.Drawing.Point(13, 87)
        POLabel1.Name = "POLabel1"
        POLabel1.Size = New System.Drawing.Size(103, 20)
        POLabel1.TabIndex = 3
        POLabel1.Text = "PO Number:"
        POLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'POLabel
        '
        POLabel.Location = New System.Drawing.Point(13, 61)
        POLabel.Name = "POLabel"
        POLabel.Size = New System.Drawing.Size(103, 20)
        POLabel.TabIndex = 1
        POLabel.Text = "PO Number:"
        POLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(13, 34)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(103, 20)
        Label4.TabIndex = 11
        Label4.Text = "Prd Line:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.PrdLineNameComboBox)
        Me.GroupBox2.Controls.Add(Me.DTPicker1)
        Me.GroupBox2.Controls.Add(Me.DTPicker2)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(POLabel1)
        Me.GroupBox2.Controls.Add(Me.POComboBox1)
        Me.GroupBox2.Controls.Add(POLabel)
        Me.GroupBox2.Controls.Add(Me.POComboBox)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(450, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 239)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selection"
        '
        'PrdLineNameComboBox
        '
        Me.PrdLineNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.PrdLineNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PrdLineNameComboBox.DataSource = Me.Tbl_Prd_LinesBindingSource
        Me.PrdLineNameComboBox.DisplayMember = "PrdLineName"
        Me.PrdLineNameComboBox.FormattingEnabled = True
        Me.PrdLineNameComboBox.Location = New System.Drawing.Point(116, 33)
        Me.PrdLineNameComboBox.Name = "PrdLineNameComboBox"
        Me.PrdLineNameComboBox.Size = New System.Drawing.Size(130, 21)
        Me.PrdLineNameComboBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.PrdLineNameComboBox, "Select Production Line ")
        Me.PrdLineNameComboBox.ValueMember = "PrdLine"
        '
        'Tbl_Prd_LinesBindingSource
        '
        Me.Tbl_Prd_LinesBindingSource.DataMember = "tbl_Prd_Lines"
        Me.Tbl_Prd_LinesBindingSource.DataSource = Me.DSClient
        '
        'DSClient
        '
        Me.DSClient.DataSetName = "DSClient"
        Me.DSClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTPicker1
        '
        Me.DTPicker1.CustomFormat = ""
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(116, 119)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(130, 20)
        Me.DTPicker1.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.DTPicker1, "First Select Production Line To Filter Correct Records")
        '
        'DTPicker2
        '
        Me.DTPicker2.CustomFormat = ""
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(116, 145)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(130, 20)
        Me.DTPicker2.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.DTPicker2, "First Select Production Line To Filter Correct Records")
        '
        'POComboBox1
        '
        Me.POComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.POComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POComboBox1.DataSource = Me.View_Rpt_Filter_PO1BindingSource
        Me.POComboBox1.DisplayMember = "PO"
        Me.POComboBox1.FormattingEnabled = True
        Me.POComboBox1.Location = New System.Drawing.Point(116, 86)
        Me.POComboBox1.Name = "POComboBox1"
        Me.POComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.POComboBox1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.POComboBox1, "First Select Production Line To Filter Correct Records")
        Me.POComboBox1.ValueMember = "PO"
        '
        'View_Rpt_Filter_PO1BindingSource
        '
        Me.View_Rpt_Filter_PO1BindingSource.DataMember = "tbl_Prd_Lines_View_Rpt_Filter_PO1"
        Me.View_Rpt_Filter_PO1BindingSource.DataSource = Me.Tbl_Prd_LinesBindingSource
        '
        'POComboBox
        '
        Me.POComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.POComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POComboBox.DataSource = Me.View_Rpt_Filter_POBindingSource
        Me.POComboBox.DisplayMember = "PO"
        Me.POComboBox.FormattingEnabled = True
        Me.POComboBox.Location = New System.Drawing.Point(116, 60)
        Me.POComboBox.Name = "POComboBox"
        Me.POComboBox.Size = New System.Drawing.Size(130, 21)
        Me.POComboBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.POComboBox, "First Select Production Line To Filter Correct Records")
        Me.POComboBox.ValueMember = "PO"
        '
        'View_Rpt_Filter_POBindingSource
        '
        Me.View_Rpt_Filter_POBindingSource.DataMember = "tbl_Prd_Lines_View_Rpt_Filter_PO"
        Me.View_Rpt_Filter_POBindingSource.DataSource = Me.Tbl_Prd_LinesBindingSource
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(120, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 239)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(195, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Check State"
        Me.CheckBox1.ThreeState = True
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 41)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Check State On for Not Issued Materials" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Checked State Off for Issued Materials" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "In Intermediate State for All Materials" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 94)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(229, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Prd Line And Requisition Date Wise Report"
        Me.ToolTip1.SetToolTip(Me.RadioButton2, "First Select Production Line To Filter Correct Records")
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 70)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(142, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "PO Number Wise Report"
        Me.ToolTip1.SetToolTip(Me.RadioButton1, "First Select Production Line To Filter Correct Records")
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(901, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "MRP Dispatch Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inv_L4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Mat_ItemsLayer4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Prd_LinesTableAdapter = Me.Tbl_Prd_LinesTableAdapter
        Me.TableAdapterManager.tbl_Pro_Client1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_ClientTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_PO_H1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_PO_HTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FS_ERP_MM.DSClientTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Prd_LinesTableAdapter
        '
        Me.Tbl_Prd_LinesTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Filter_POTableAdapter
        '
        Me.View_Rpt_Filter_POTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Filter_PO1TableAdapter
        '
        Me.View_Rpt_Filter_PO1TableAdapter.ClearBeforeFill = True
        '
        'FrmRptMRPD
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 572)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRptMRPD"
        Me.Text = "MRP Dispatch Reports"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Tbl_Prd_LinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Filter_PO1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Filter_POBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents POComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents POComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSClient As FS_ERP_MM.DSClient
    Friend WithEvents TableAdapterManager As FS_ERP_MM.DSClientTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Prd_LinesTableAdapter As FS_ERP_MM.DSClientTableAdapters.tbl_Prd_LinesTableAdapter
    Friend WithEvents Tbl_Prd_LinesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrdLineNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents View_Rpt_Filter_POBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Filter_POTableAdapter As FS_ERP_MM.DSClientTableAdapters.View_Rpt_Filter_POTableAdapter
    Friend WithEvents View_Rpt_Filter_PO1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Filter_PO1TableAdapter As FS_ERP_MM.DSClientTableAdapters.View_Rpt_Filter_PO1TableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
