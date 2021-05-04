<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMS
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim GMNoLabel As System.Windows.Forms.Label
        Me.txtMSG = New System.Windows.Forms.TextBox()
        Me.txtPhonNo = New System.Windows.Forms.TextBox()
        Me.txtSender = New System.Windows.Forms.TextBox()
        Me.txtAPI = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        GMNoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(183, 162)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(85, 20)
        Label4.TabIndex = 21
        Label4.Text = "Msg Text :"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(183, 133)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(85, 20)
        Label3.TabIndex = 20
        Label3.Text = "Phone No.:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(183, 104)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(85, 20)
        Label1.TabIndex = 19
        Label1.Text = "Sender Name:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GMNoLabel
        '
        GMNoLabel.Location = New System.Drawing.Point(183, 77)
        GMNoLabel.Name = "GMNoLabel"
        GMNoLabel.Size = New System.Drawing.Size(85, 20)
        GMNoLabel.TabIndex = 18
        GMNoLabel.Text = "API Key:"
        GMNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMSG
        '
        Me.txtMSG.Location = New System.Drawing.Point(274, 162)
        Me.txtMSG.Multiline = True
        Me.txtMSG.Name = "txtMSG"
        Me.txtMSG.Size = New System.Drawing.Size(364, 56)
        Me.txtMSG.TabIndex = 17
        '
        'txtPhonNo
        '
        Me.txtPhonNo.Location = New System.Drawing.Point(274, 133)
        Me.txtPhonNo.Name = "txtPhonNo"
        Me.txtPhonNo.Size = New System.Drawing.Size(155, 20)
        Me.txtPhonNo.TabIndex = 16
        '
        'txtSender
        '
        Me.txtSender.Location = New System.Drawing.Point(274, 104)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Size = New System.Drawing.Size(155, 20)
        Me.txtSender.TabIndex = 15
        '
        'txtAPI
        '
        Me.txtAPI.Location = New System.Drawing.Point(274, 77)
        Me.txtAPI.Name = "txtAPI"
        Me.txtAPI.Size = New System.Drawing.Size(273, 20)
        Me.txtAPI.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(563, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 627)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label1)
        Me.Controls.Add(GMNoLabel)
        Me.Controls.Add(Me.txtMSG)
        Me.Controls.Add(Me.txtPhonNo)
        Me.Controls.Add(Me.txtSender)
        Me.Controls.Add(Me.txtAPI)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSMS"
        Me.Text = "frmSMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMSG As TextBox
    Friend WithEvents txtPhonNo As TextBox
    Friend WithEvents txtSender As TextBox
    Friend WithEvents txtAPI As TextBox
    Friend WithEvents Button1 As Button
End Class
