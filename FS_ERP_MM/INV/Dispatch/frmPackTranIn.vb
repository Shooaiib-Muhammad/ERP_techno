Public Class frmPackTranIn

    Private Sub frmPackTranIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSPackTranIn.tbl_Inv_Tran_Date, CType(Now.Date, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Tbl_CompaniesTableAdapter.Fill(Me.DSPackTranIn.tbl_Companies)
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSPackTranIn.tbl_Inv_Supplier)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSPackTranIn.tbl_Inv_L4)
        Me.Tbl_Inv_L4BindingSource.Sort = "L4Name ASC"
        Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSPackTranIn.tbl_Inv_Tran_In)

        Me.Tbl_Inv_Tran_InBindingSource.Position = Me.Tbl_Inv_Tran_InBindingSource.Count

    End Sub
    Sub SaveRecord()
        If Not Me.TranTypeComboBox.Text = "" Then
            If Not Me.MRINTextBox.Text = "" Then
                If Not Me.CodeComboBox.Text = "" Then
                    If Not Me.QtyTextBox.Text = "" Then
                        Try
                            Me.Validate()
                            Me.Tbl_Inv_Tran_InBindingSource.EndEdit()
                            Me.Tbl_Inv_Tran_InTableAdapter.Update(Me.DSPackTranIn.tbl_Inv_Tran_In)
                            'Me.Tbl_Inv_Tran_InTableAdapter.Insert( )
                            MsgBox("Record Saved.")
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        Me.Tbl_Inv_Tran_InBindingSource.AddNew()
                    Else
                        MsgBox("Quantity is missing")
                    End If
                Else
                    MsgBox("Select Material")
                End If
            Else
                MsgBox("MRIN is Missing")
            End If
        Else
            MsgBox("Transaction Type is Missing")
        End If
    End Sub

    Private Sub NarrationTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NarrationTextBox.Leave
        SaveRecord()
    End Sub
    Private Sub Tbl_Inv_Tran_InBindingSource_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingManagerDataErrorEventArgs) Handles Tbl_Inv_Tran_InBindingSource.DataError

    End Sub
    Private Sub TranTypeComboBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TranTypeComboBox.GotFocus
        If Me.TranTypeComboBox.Text = "" Then
            Me.SupplierIDLabel.Visible = True
            Me.SupplierIDComboBox.Visible = True

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False
        ElseIf Me.TranTypeComboBox.Text = "MRI" Then
            Me.SupplierIDLabel.Visible = True
            Me.SupplierIDComboBox.Visible = True

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False
        ElseIf Me.TranTypeComboBox.Text = "MTP" Then
            Me.SupplierIDLabel.Visible = False
            Me.SupplierIDComboBox.Visible = False

            Me.CompanyIDLabel.Visible = True
            Me.CompanyIDComboBox.Visible = True
        End If
    End Sub

    Private Sub TranTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranTypeComboBox.SelectedIndexChanged
        If Me.TranTypeComboBox.Text = "" Then
            Me.SupplierIDLabel.Visible = True
            Me.SupplierIDComboBox.Visible = True

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False
        ElseIf Me.TranTypeComboBox.Text = "MRI" Then
            Me.SupplierIDLabel.Visible = True
            Me.SupplierIDComboBox.Visible = True

            Me.CompanyIDLabel.Visible = False
            Me.CompanyIDComboBox.Visible = False
        ElseIf Me.TranTypeComboBox.Text = "MTP" Then
            Me.SupplierIDLabel.Visible = False
            Me.SupplierIDComboBox.Visible = False

            Me.CompanyIDLabel.Visible = True
            Me.CompanyIDComboBox.Visible = True
        End If
    End Sub
    Private Sub NarrationTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NarrationTextBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
    End Sub
    Private Sub TranTypeComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TranTypeComboBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
    End Sub
    Private Sub MRINTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MRINTextBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
    End Sub
    Private Sub CodeComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodeComboBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
    End Sub
    Private Sub QtyTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QtyTextBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
    End Sub
    Private Sub SupplierIDComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SupplierIDComboBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
    End Sub
    Private Sub CompanyIDComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CompanyIDComboBox.KeyDown
        If (e.KeyCode = Keys.A And e.Control) Then
            Me.Tbl_Inv_Tran_InBindingSource.AddNew()
        End If
        If (e.KeyCode = Keys.S And e.Control) Or (e.KeyCode = Keys.Enter) Then
            SaveRecord()
        End If
    End Sub

    Private Sub QtyTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtyTextBox.TextChanged
        If QtyTextBox.TextLength > 0 Then
            Me.CodeComboBox.DropDownStyle = ComboBoxStyle.Simple
        Else
            Me.CodeComboBox.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub

    
End Class