Public Class FrmEDM
    Private Sub Tbl_Inv_SupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Inv_SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSEDM)

    End Sub

    Private Sub FrmEDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tbl_Pur_Supplier_CodeTableAdapter.Fill(Me.DSEDM.tbl_Pur_Supplier_Code)
        'TODO: This line of code loads data into the 'DSEDM.tbl_Pur_Supplier_Code_New' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSEDM.View_MAX_PODNo' table. You can move, or remove it, as needed.
        'Me.View_MAX_PODNoTableAdapter.Fill(Me.DSEDM.View_MAX_PODNo)
        'TODO: This line of code loads data into the 'DSEDM.View_Pur_PO_D' table. You can move, or remove it, as needed.
        Try
            Me.View_Pur_PO_DTableAdapter.Fill(Me.DSEDM.View_Pur_PO_D)
        Catch ex As Exception

        End Try

        Me.Tbl_Pur_POTableAdapter.Fill(Me.DSEDM.tbl_Pur_PO)
        'TODO: This line of code loads data into the 'DSEDM.tbl_Pur_Supplier_Code' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSEDM.tbl_Inv_Supplier' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSEDM.tbl_Inv_Supplier)

    End Sub

    Private Sub ReqDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles ReqDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub ReqDateMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReqDateMaskedTextBox.TextChanged
        Try
            Try
                Me.NewReqDateMaskedTextBox.Text = Me.ReqDateMaskedTextBox.Text
            Catch ex As Exception
            End Try
        Catch ex As Exception

        End Try
    End Sub
    Dim flag As Boolean = False
    Dim Addflag As Boolean = False
    Private Sub AddSale_Click(sender As Object, e As EventArgs) Handles AddSale.Click
        flag = True
        Me.ReqDateMaskedTextBox.ReadOnly = False
        Addflag = True
        Me.Tbl_Pur_POBindingSource.AddNew()
        Me.Tbl_Inv_SupplierTableAdapter.Fill(Me.DSEDM.tbl_Inv_Supplier)
        Me.POIDLabel2.Text = Me.Tbl_Pur_POTableAdapter.MAx
    End Sub

    Private Sub Tbl_Pur_PO_DDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Tbl_Pur_PO_DDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub Tbl_Pur_POBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Pur_POBindingNavigatorSaveItem.Click
        Dim POPosition As Integer = Me.Tbl_Pur_POBindingSource.Position
        If flag = True Then
            Try
                Me.POIDLabel2.Text = Me.Tbl_Pur_POTableAdapter.MAx
                flag = False
                Me.Tbl_Pur_POTableAdapter.Insert(POIDLabel2.Text, Me.SupplierIDComboBox.SelectedValue, PODateMaskedTextBox.Text, ReqDateMaskedTextBox.Text, NewReqDateMaskedTextBox.Text, Nothing, SpecialNoteTextBox.Text, Nothing, Nothing, 0, 0, ImportStatusCheckBox.CheckState)
                Me.Tbl_Pur_POTableAdapter.Fill(Me.DSEDM.tbl_Pur_PO)
                Me.Tbl_Pur_POBindingSource.Position = POPosition
                MsgBox("Record Saved.")
                Me.ReqDateMaskedTextBox.ReadOnly = True
                Addflag = False
                'DGVAttribute(True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PODNo As Int64

        PODNo = Me.Tbl_Pur_POTableAdapter.ScalarQuery(Me.POIDLabel2.Text)
        Try
            Me.View_Pur_PO_DTableAdapter.InsertQuery(POIDLabel2.Text, PODNo, Me.DSEDM.View_inv_Code.Rows(0).Item("SupplierID"), TextBox2.Text, UOMLabel2.Text, Me.DSEDM.View_inv_Code.Rows(0).Item("Code"), Me.DSEDM.View_inv_Code.Rows(0).Item("SupplierCodeID"), TextBox3.Text, Label8.Text)
            Me.View_Pur_PO_DTableAdapter.Fill(Me.DSEDM.View_Pur_PO_D)
            MsgBox("Data Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub L4NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L4NameComboBox.SelectedIndexChanged

    End Sub
    Sub BindAutoComplete(ByVal comboControl As ComboBox, ByVal dataSource As DataTable, ByVal valueColumn As String, ByVal textColumn As String)
        comboControl.ValueMember = "id"
        comboControl.DisplayMember = "Text"
        comboControl.Items.Clear()
        Dim RowFilter = "" & textColumn & " like '%" & comboControl.Text & "%'"
        Dim listNew = dataSource.Select(RowFilter).Select(Function(fu) New With {.Id = fu(valueColumn), .Text = fu(textColumn)}).ToList
        comboControl.Items.AddRange(listNew.ToArray())
        comboControl.SelectionStart = comboControl.Text.Length
        Cursor = Cursors.[Default]
        'comboControl.DroppedDown = True

    End Sub
    Private Sub L4NameComboBox_TextUpdate(sender As Object, e As EventArgs) Handles L4NameComboBox.TextUpdate
        'BindAutoComplete(L4NameComboBox, Me.DSEDM.tbl_Pur_Supplier_Code_New, "Code", "L4Name")
        'L4NameComboBox.DroppedDown = True
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        Try
            Me.View_inv_CodeTableAdapter.Fill(Me.DSEDM.View_inv_Code, L4NameComboBox.Text, SupplierIDComboBox.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim j As Int16 = Me.View_Pur_PO_DBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.View_Pur_PO_DBindingSource.EndEdit()
            Me.View_Pur_PO_DTableAdapter.Update(Me.DSEDM.View_Pur_PO_D)
            Me.View_Pur_PO_DTableAdapter.Fill(Me.DSEDM.View_Pur_PO_D)
            Me.View_Pur_PO_DBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception


        End Try
    End Sub

    Private Sub View_Pur_PO_DDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Pur_PO_DDataGridView.CellContentClick
        If e.ColumnIndex = 6 Then
            If Me.View_Pur_PO_DDataGridView.Item(6, e.RowIndex).Value Is DBNull.Value Then
                Me.View_Pur_PO_DDataGridView.Item(6, e.RowIndex).Value = True
                Me.View_Pur_PO_DDataGridView.Item(7, e.RowIndex).Value = Now
            Else
                If Me.View_Pur_PO_DDataGridView.Item(6, e.RowIndex).Value = False Then
                    Me.View_Pur_PO_DDataGridView.Item(6, e.RowIndex).Value = True
                    Me.View_Pur_PO_DDataGridView.Item(7, e.RowIndex).Value = Now
                Else
                    Me.View_Pur_PO_DDataGridView.Item(6, e.RowIndex).Value = False
                    Me.View_Pur_PO_DDataGridView.Item(7, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub View_Pur_PO_DDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_Pur_PO_DDataGridView.DataError

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        If RadioButton1.Checked Then

            Path = "" & frmLoginVer.Reportpath & "\RptPONew.rpt"

            Filter = "{tbl_Pur_PO_D.POID} = " & Me.POIDLabel2.Text & ""

        ElseIf RadioButton2.Checked Then

            Path = "" & frmLoginVer.Reportpath & "\RptPORecReports.rpt"

            Filter = "{tbl_Pur_PO_D.POID} = " & Me.POIDLabel2.Text & ""

        End If

        Dim obj As New Class_Utility
        obj.LoadReports(Path, Filter, "")
    End Sub
End Class