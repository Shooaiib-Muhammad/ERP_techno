Public Class frmPOImpShipmentTrans

    Private Sub frmPOImpShipmentTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPOImportEntry.View_Inv_Mat_Trans' table. You can move, or remove it, as needed.
        Me.View_Inv_Mat_TransTableAdapter.Fill(Me.DSPOImportEntry.View_Inv_Mat_Trans)
        Me.View_Inv_Mat_TransBindingSource.Sort = "POID ASC"
    End Sub

    Private Sub View_Inv_Mat_TransDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub View_Inv_Mat_TransDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView2.DataError

    End Sub

    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If Me.TabControl1.SelectedTab.Text = "Pending Shipments" Then
            Me.View_Inv_Mat_TransTableAdapter.Fill(Me.DSPOImportEntry.View_Inv_Mat_Trans)
            Me.View_Inv_Mat_TransBindingSource.Sort = "POID ASC"
        ElseIf Me.TabControl1.SelectedTab.Text = "Received Shipment" Then
            Me.View_Inv_Mat_TransTableAdapter.FillBy(Me.DSPOImportEntry.View_Inv_Mat_Trans)
            Me.View_Inv_Mat_TransBindingSource.Sort = "POID ASC"
        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.View_Inv_Mat_TransBindingSource.EndEdit()
            Me.View_Inv_Mat_TransTableAdapter.Update(Me.DSPOImportEntry.View_Inv_Mat_Trans)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DataError1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub CMtxtEF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMtxtEF.Click

    End Sub

    Private Sub CMtxtEF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtEF.KeyDown
        If e.KeyCode = Keys.Enter And Me.CMtxtEF.Text.Length > 0 Then
            Dim mydate As System.DateTime
            Try
                mydate = CDate("#" & Me.CMtxtEF.Text & "#")
            Catch ex As Exception
                MsgBox("Enter The Correct Date Format.")
            End Try
            Me.View_Inv_Mat_TransBindingSource.Filter = "DeliveryDate = '" & mydate & "'"
            Me.CMtxtEF.Text = ""
            'Me.CMtxtEF.ForeColor = Color.Silver
            Me.CMSEF.Hide()
        End If
    End Sub
    Private Sub CMtxtEF1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtEF1.KeyDown
        If e.KeyCode = Keys.Enter And CMtxtEF.Text.Length > 0 And CMtxtEF1.Text.Length > 0 And CMtxtEF.Text <> "Enter First Date" And CMtxtEF1.Text <> "Enter Second Date" Then
            Dim mydate1 As System.DateTime
            Dim mydate2 As System.DateTime
            Try
                mydate1 = CDate("#" & Me.CMtxtEF.Text & "#")
                mydate2 = CDate("#" & Me.CMtxtEF1.Text & "#")
            Catch ex As Exception
                MsgBox("Enter The Correct Date Format.")
            End Try
            Me.View_Inv_Mat_TransBindingSource.Filter = "DeliveryDate >= '" & mydate1 & "' AND DeliveryDate <= '" & mydate2 & "'"
            CMtxtEF.Text = ""
            'CMtxtEF.ForeColor = Color.Silver
            CMtxtEF1.Text = ""
            'CMtxtEF1.ForeColor = Color.Silver
            CMSEF.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Me.View_Inv_Mat_TransBindingSource.RemoveFilter()
    End Sub

   

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter And Me.ToolStripTextBox1.Text.Length > 0 Then
            'Dim mydate As System.DateTime
            'Try
            '    mydate = CDate("#" & Me.CMtxtEF.Text & "#")
            'Catch ex As Exception
            '    MsgBox("Enter The Correct Date Format.")
            'End Try
            Me.View_Inv_Mat_TransBindingSource.Filter = "CompanyName like'%" & Me.ToolStripTextBox1.Text & "%'"
            Me.ToolStripTextBox1.Text = ""
            'Me.CMtxtEF.ForeColor = Color.Silver
            CMComp.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.View_Inv_Mat_TransBindingSource.RemoveFilter()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.View_Inv_Mat_TransBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.View_Inv_Mat_TransBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.Click

    End Sub

    Private Sub ToolStripTextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter And Me.ToolStripTextBox2.Text.Length > 0 Then
            'Dim mydate As System.DateTime
            'Try
            '    mydate = CDate("#" & Me.CMtxtEF.Text & "#")
            'Catch ex As Exception
            '    MsgBox("Enter The Correct Date Format.")
            'End Try
            Me.View_Inv_Mat_TransBindingSource.Filter = "L4Name like'%" & Me.ToolStripTextBox2.Text & "%'"
            Me.ToolStripTextBox2.Text = ""
            'Me.CMtxtEF.ForeColor = Color.Silver
            CMItemName.Hide()
        End If
    End Sub

    Private Sub ToolStripTextBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.Click
       
    End Sub

    Private Sub ToolStripTextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
        If e.KeyCode = Keys.Enter And Me.ToolStripTextBox3.Text.Length > 0 Then
            'Dim mydate As System.DateTime
            'Try
            '    mydate = CDate("#" & Me.CMtxtEF.Text & "#")
            'Catch ex As Exception
            '    MsgBox("Enter The Correct Date Format.")
            'End Try
            Me.View_Inv_Mat_TransBindingSource.Filter = "ARWayBillNo like'%" & Me.ToolStripTextBox3.Text & "%'"
            Me.ToolStripTextBox3.Text = ""
            'Me.CMtxtEF.ForeColor = Color.Silver
            CMBill.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.View_Inv_Mat_TransBindingSource.RemoveFilter()
    End Sub
End Class