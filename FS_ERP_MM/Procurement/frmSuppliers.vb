Public Class frmSuppliers
    Private Sub frmSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Pro_CountryTableAdapter.Fill(Me.DSSupp.tbl_Pro_Country)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSSupp.tbl_Inv_Supplier)
        Me.Tbl_inv_SupplierTypeTableAdapter.Fill(Me.DSSupp.tbl_inv_SupplierType)
        Me.Tbl_Inv_SupplierBindingSource.Sort = "CompanyName ASC"
    End Sub
    Private Sub ToolStripTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.GotFocus
        If ToolStripTextBox1.Text = "Enter Company Name" Then
            ToolStripTextBox1.Text = ""
            ToolStripTextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_Inv_SupplierBindingSource.Filter = "CompanyName like'%" & Me.ToolStripTextBox1.Text & "%'"
            Me.ToolStripTextBox1.Clear()
            Me.SupplierContextMenuStrip.Hide()
        End If
    End Sub
    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_Inv_SupplierBindingSource.RemoveFilter()
        Me.ToolStripTextBox1.Text = "Enter Company Name"
        Me.ToolStripTextBox1.ForeColor = Color.Silver
    End Sub
    Private Sub ToolStripTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.LostFocus
        If ToolStripTextBox1.TextLength = 0 Then
            ToolStripTextBox1.Text = "Enter Company Name"
            ToolStripTextBox1.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub AscendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AscendingOrderToolStripMenuItem.Click
        Me.Tbl_Inv_SupplierBindingSource.Sort = "CompanyName ASC"
    End Sub
    Private Sub DescendingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescendingOrderToolStripMenuItem.Click
        Me.Tbl_Inv_SupplierBindingSource.Sort = "CompanyName DESC"
    End Sub
    Private Sub RemoveOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveOrderToolStripMenuItem.Click
        Me.Tbl_Inv_SupplierBindingSource.RemoveSort()
    End Sub
    Dim Email As String = Nothing
    Dim Phone As String = Nothing
    Dim FaxNo As String = Nothing
    Dim CompName As String = Nothing
    Dim RegDate As String = Nothing
    Dim Country As String = Nothing
    Dim SuplierNo As Integer = Nothing
    Dim City As String = Nothing
    Dim ContPerson As String = Nothing
    Private Sub SaveSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSupplier.Click
        If ContactPersonTextBox.Text = ContPerson Then
        Else
            Me.UpdateStatusMaskedTextBox.Text = Now
        End If
        If EmailAddTextBox.Text = Email Then
        Else
            Me.UpdateStatusMaskedTextBox.Text = Now
        End If

        If Me.PhoneNoTextBox.Text = Phone Then
        Else
            Me.UpdateStatusMaskedTextBox.Text = Now
        End If
        If Me.FaxNoTextBox.Text = FaxNo Then
        Else
            Me.UpdateStatusMaskedTextBox.Text = Now
        End If
        If Me.CityTextBox.Text = City Then
        Else
            Me.UpdateStatusMaskedTextBox.Text = Now
        End If
        If Me.SupplierIDTextBox.Text = SuplierNo Then
        Else
            Me.UpdateStatusMaskedTextBox.Text = Now
        End If
        If Me.CompanyNameTextBox.Text = CompName Then
        Else
            Me.UpdateStatusMaskedTextBox.Text = Now
        End If
        If Me.RegDateMaskedTextBox.Text = RegDate Then
        Else
            Me.UpdateStatusMaskedTextBox.Text = Now
        End If
        If CountryNameComboBox.SelectedValue = Country Then
        Else
            Me.UpdateStatusMaskedTextBox.Text = Now
        End If
        Try
            Me.Validate()
            Me.Tbl_Inv_SupplierBindingSource.EndEdit()
            Me.Tbl_Inv_SupplierTableAdapter.Update(Me.DSSupp.tbl_Inv_Supplier)
            MsgBox("Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Tbl_Inv_SupplierBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_SupplierBindingSource.PositionChanged
        Email = Me.EmailAddTextBox.Text
        Phone = Me.PhoneNoTextBox.Text
        FaxNo = Me.FaxNoTextBox.Text
        ContPerson = Me.ContactPersonTextBox.Text
        City = Me.CityTextBox.Text
        SuplierNo = Val(Me.SupplierIDTextBox.Text)
        CompName = Me.CompanyNameTextBox.Text
        RegDate = Me.RegDateMaskedTextBox.Text
        Country = Me.CountryNameComboBox.SelectedValue
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Tbl_Inv_SupplierBindingSource.Filter = "Status=1"
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_Inv_SupplierBindingSource.Filter = "Status IS NULL OR Status=0 "
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Tbl_Inv_SupplierBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub
End Class