<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptViewer
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
        Me.RptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'RptViewer
        '
        Me.RptViewer.ActiveViewIndex = -1
        Me.RptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RptViewer.DisplayGroupTree = False
        Me.RptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptViewer.Location = New System.Drawing.Point(0, 0)
        Me.RptViewer.Name = "RptViewer"
        Me.RptViewer.SelectionFormula = ""
        Me.RptViewer.Size = New System.Drawing.Size(1284, 1006)
        Me.RptViewer.TabIndex = 0
        Me.RptViewer.ViewTimeSelectionFormula = ""
        '
        'frmRptViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 1006)
        Me.Controls.Add(Me.RptViewer)
        Me.Name = "frmRptViewer"
        Me.Text = "Reports Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
