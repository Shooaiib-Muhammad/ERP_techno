Public Class frmSaleAccounts
    Private Sub frmSaleAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSSaleAcounts.tbl_MM_Customer)
        Me.Tbl_MM_Cust_ItemsTableAdapter.Fill(Me.DSSaleAcounts.tbl_MM_Cust_Items)
        Me.Tbl_MM_SaleDetailTableAdapter.Fill(Me.DSSaleAcounts.tbl_MM_SaleDetail)
        Me.Tbl_MM_SaleTableAdapter.Fill(Me.DSSaleAcounts.tbl_MM_Sale)
        Me.Tbl_MM_SaleBindingSource.MoveLast()

    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Try
            Me.Validate()
            Me.Tbl_MM_SaleBindingSource.EndEdit()
            Me.Tbl_MM_SaleTableAdapter.Update(Me.DSSaleAcounts.tbl_MM_Sale)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CompanyTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompanyTextBox.GotFocus
        If Me.CompanyTextBox.Text = "Enter Company Name" Then
            Me.CompanyTextBox.Text = ""
            Me.CompanyTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CompanyTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CompanyTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_MM_SaleBindingSource.Filter = "CompName like'%" & Me.CompanyTextBox.Text & "%'"
            Me.CompanyTextBox.Clear()
            Me.CompanyContextMenuStrip.Hide()
        End If
    End Sub
    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_MM_SaleBindingSource.RemoveFilter()
    End Sub

    Private Sub CompanyTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CompanyTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub CompanyTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompanyTextBox.LostFocus
        If CompanyTextBox.TextLength = 0 Then
            Me.CompanyTextBox.Text = "Enter Company Name"
            Me.CompanyTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub InvoiceNoTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoiceNoTextBox.GotFocus
        If InvoiceNoTextBox.Text = "Enter Invoice No." Then
            Me.InvoiceNoTextBox.Text = ""
            Me.InvoiceNoTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub InvoiceNoTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InvoiceNoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_MM_SaleBindingSource.Filter = "SID =" & Me.InvoiceNoTextBox.Text & ""
            Me.InvoiceNoTextBox.Clear()
            Me.ContextMenuInvoiceNo.Hide()
        End If
    End Sub

    Private Sub InvoiceNoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InvoiceNoTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub InvoiceNoTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoiceNoTextBox.LostFocus
        If InvoiceNoTextBox.TextLength = 0 Then
            Me.InvoiceNoTextBox.Text = "Enter Invoice No."
            Me.InvoiceNoTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Tbl_MM_SaleBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Tbl_MM_SaleBindingSource.Sort = "SID DESC"
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_MM_SaleBindingSource.Sort = "SID ASC"
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Tbl_MM_SaleBindingSource.RemoveSort()
    End Sub

    Private Sub Tbl_MM_SaleDetailDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_MM_SaleDetailDataGridView.DataError

    End Sub

    Private Sub SDateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustomerTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerTextBox.GotFocus
        If Me.CustomerTextBox.Text = "Enter Customer ID" Then
            Me.CustomerTextBox.Text = ""
            Me.CustomerTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CustomerTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustomerTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_MM_SaleBindingSource.Filter = "Custid =" & Me.CustomerTextBox.Text & ""
            'Me.Tbl_MM_CustomerTableAdapter.Fill(Me.DSSaleAcounts.tbl_MM_Customer)
            Me.Tbl_MM_SaleTableAdapter.Fill(Me.DSSaleAcounts.tbl_MM_Sale)
            Me.CustomerTextBox.Clear()
            Me.CustomerMenuStrip.Hide()
        End If
    End Sub

    Private Sub CustomerTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerTextBox.LostFocus
        If CustomerTextBox.TextLength = 0 Then
            Me.CustomerTextBox.Text = "Enter Customer ID"
            Me.CustomerTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub BillingNoTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BillingNoTextBox.GotFocus
        If BillingNoTextBox.Text = "Enter Billing No." Then
            Me.BillingNoTextBox.Text = ""
            Me.BillingNoTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BillingNoTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BillingNoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_MM_SaleBindingSource.Filter = "BillingNumber ='" & Me.BillingNoTextBox.Text & "'"
            Me.BillingNumberTextBox.Clear()
            Me.BillingNoMenuStrip.Hide()
        End If
    End Sub

    Private Sub BillingNoTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BillingNoTextBox.LostFocus
        If BillingNoTextBox.TextLength = 0 Then
            Me.BillingNoTextBox.Text = "Enter Billing No."
            Me.BillingNoTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Me.Tbl_MM_SaleBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Me.Tbl_MM_SaleBindingSource.Sort = "BillingNumber ASC"
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Me.Tbl_MM_SaleBindingSource.Sort = "BillingNumber DESC "
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Me.Tbl_MM_SaleBindingSource.RemoveSort()
    End Sub

    Private Sub CMtxtDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMtxtDate.Click

    End Sub

    Private Sub CMtxtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtDate.GotFocus
        If CMtxtDate.Text = "Enter Billing Date" Then
            CMtxtDate.Text = ""
            CMtxtDate.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CMtxtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtDate.KeyDown
        If e.KeyCode = Keys.Enter And Me.CMtxtDate.Text.Length > 0 Then
            Dim mydate As System.DateTime
            Try
                mydate = CDate("#" & Me.CMtxtDate.Text & "#")
            Catch ex As Exception
                MsgBox("Enter the Correct Date Format.")
            End Try
            Me.Tbl_MM_SaleBindingSource.Filter = "BillingDate = '" & mydate & "'"
            Try
                Me.Tbl_MM_SaleTableAdapter.Fill(Me.DSSaleAcounts.tbl_MM_Sale)
                Me.Tbl_MM_SaleBindingSource.MoveLast()
            Catch ex As Exception
                'MsgBox("This Date Not Exist")
            End Try
            Me.CMtxtDate.Text = "Enter Billing Date"
            Me.CMtxtDate.ForeColor = Color.Silver
            Me.CMSDate.Hide()
        End If
    End Sub

    Private Sub CMtxtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtDate.LostFocus
        If CMtxtDate.Text = "" Then
            CMtxtDate.Text = "Enter Billing Date"
            CMtxtDate.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Me.Tbl_MM_SaleBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Me.Tbl_MM_SaleBindingSource.RemoveFilter()
    End Sub
End Class