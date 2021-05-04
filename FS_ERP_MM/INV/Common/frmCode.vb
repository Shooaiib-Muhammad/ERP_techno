Public Class frmCode
    Dim db As New db
    Dim l4 As String
    Dim Code As String
    Dim UpdateFlag As Boolean = False
    Private Sub frmCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSCodeProc.tbl_Pur_UnitOfMeasurement)
        Me.Tbl_Pro_CountryTableAdapter.Fill(Me.DSCodeProc.tbl_Pro_Country)
        Me.Tbl_MM_CurrancyTableAdapter.Fill(Me.DSCodeProc.tbl_MM_Currancy)
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSCodeProc.tbl_Inv_L4)
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSCodeProc.tbl_Inv_L3)
        Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSCodeProc.tbl_Inv_L2)
        Me.Tbl_Inv_L1TableAdapter.Fill(Me.DSCodeProc.tbl_Inv_L1)
        Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSCodeProc.tbl_Pur_UnitOfMeasurement)
        Try
            Me.Tbl_Inv_L1TableAdapter.Fill(Me.DSCodeProc.tbl_Inv_L1)

            Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSCodeProc.tbl_Inv_L2)

            Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSCodeProc.tbl_Inv_L3)

            Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSCodeProc.tbl_Inv_L4)

            Me.Tbl_Pro_CountryTableAdapter.Fill(Me.DSCodeProc.tbl_Pro_Country)
            Me.Tbl_MM_CurrancyTableAdapter.Fill(Me.DSCodeProc.tbl_MM_Currancy)
            UpdateFlag = True
        Catch ex As Exception
            MsgBox("Connection Error.")
        End Try
        Me.Tbl_Inv_L4BindingSource.MoveLast()
    End Sub
    Sub CheckCode()
        Try

            db.open()
            db.com.CommandText = "Select * from tbl_Inv_Code Where Code='" & Code & "' "
            db.com.CommandType = Data.CommandType.Text
            db.Rd = db.com.ExecuteReader
            If db.Rd.Read Then
                MsgBox("Code Already Exist.")
                SaveLayer4()
                db.close()
                db.Rd.Close()
                db.DA.Dispose()
                db.com.Dispose()

            Else
                db.close()
                db.Rd.Close()
                db.DA.Dispose()
                db.com.Dispose()

                db.open()
                db.com.CommandText = "Insert into tbl_Inv_Code Values('" & Code & "')"
                db.com.CommandType = Data.CommandType.Text
                db.com.ExecuteNonQuery()
                db.con.Close()

                SaveLayer4()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub SaveLayer4()
        Try
            Me.Validate()
            Me.Tbl_Inv_L4BindingSource.EndEdit()
            Me.Tbl_Inv_L4TableAdapter.Update(Me.DSCodeProc.tbl_Inv_L4)
            MsgBox("Layer 4 Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteL4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Code = Me.Tbl_Inv_L4DataGridView(6, Me.Tbl_Inv_L4DataGridView.CurrentRow.Index).Value
            Me.DSCodeProc.tbl_Inv_L4.Rows(Me.Tbl_Inv_L4DataGridView.CurrentRow.Index).Delete()
        Catch ex As Exception
        End Try
        Try
            Me.Validate()
            Me.Tbl_Inv_L4BindingSource.EndEdit()
            Me.Tbl_Inv_L4TableAdapter.Update(Me.DSCodeProc.tbl_Inv_L4)
        Catch ex As Exception
        End Try
        Try
            db.open()
            db.com.CommandText = "Select * from tbl_Inv_Code Where Code='" & Code & "' "
            db.com.CommandType = Data.CommandType.Text
            db.Rd = db.com.ExecuteReader
            If db.Rd.Read Then
                db.close()
                db.Rd.Close()
                db.DA.Dispose()
                db.com.Dispose()
                DeleteCode()
            Else
                db.close()
                db.Rd.Close()
                db.DA.Dispose()
                db.com.Dispose()
                MsgBox("Code Number :" & Code & " is not Exist.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub DeleteCode()
        Try
            db.open()
            db.com.CommandText = "Delete From tbl_Inv_Code where Code='" & Code & "'"
            db.com.CommandType = Data.CommandType.Text
            db.com.ExecuteNonQuery()
            MsgBox("Code Number :" & Code & " is deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            db.con.Close()
        End Try
    End Sub
    Private Sub Tbl_Inv_L4DataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If UpdateFlag = True Then
            Tbl_Inv_L4DataGridView(14, e.RowIndex).Value = Now.Date
        End If
    End Sub
    Private Sub Tbl_Inv_L4DataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
    End Sub
    Private Sub Tbl_Inv_L1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Inv_L1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSCodeProc)
    End Sub
    Private Sub Tbl_Inv_L4DataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_L4DataGridView.CellEnter
        If e.ColumnIndex = 3 Then
            If e.RowIndex = 0 And Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value = "0001"
            ElseIf e.RowIndex > 0 And Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value Is DBNull.Value Then
                Dim L4ID As String = Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex - 1).Value + 1
                If L4ID.Length = 1 Then
                    Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value = "000" & L4ID
                ElseIf L4ID.Length = 2 Then
                    Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value = "00" & L4ID
                ElseIf L4ID.Length = 3 Then
                    Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value = "0" & L4ID
                ElseIf L4ID.Length = 4 Then
                    Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value = L4ID
                End If
            End If
        End If
        If e.ColumnIndex = 6 And Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value Is DBNull.Value Then

            Dim l4Name As String = Me.Tbl_Inv_L4DataGridView(4, e.RowIndex).Value.ToString
            If l4Name.Length > 0 Then
                l4 = Me.Tbl_Inv_L4DataGridView(3, e.RowIndex).Value.ToString
                Code = Me.Layer1IDMaskedTextBox.Text & "-" & Me.Layer2IDMaskedTextBox.Text & "-" & Me.Layer3IDMaskedTextBox.Text & "-" & l4
                Me.Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value = Code
                Me.Tbl_Inv_L4DataGridView(18, e.RowIndex).Value = Now.Date
                Me.Tbl_Inv_L4DataGridView(14, e.RowIndex).Value = 0.0
                CheckCode()
            Else
                MsgBox("Insert Layer 4 Code Name.")
            End If

        End If
        If e.ColumnIndex = 7 And Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value Is DBNull.Value Then
            Tbl_Inv_L4DataGridView(e.ColumnIndex, e.RowIndex).Value = True
        End If
    End Sub

    Private Sub Tbl_Inv_L4DataGridView_DataError1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_L4DataGridView.DataError

    End Sub
    Private Sub Tbl_Inv_L1BindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_L1BindingSource.PositionChanged
        Me.Tbl_Inv_L4BindingSource.MoveLast()
        Me.Tbl_Inv_L4BindingSource.RemoveFilter()
        'Me.Tbl_Inv_L4BindingSource.RemoveSort()
    End Sub

    Private Sub Tbl_Inv_L2BindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_L2BindingSource.PositionChanged
        Me.Tbl_Inv_L4BindingSource.MoveLast()
        Me.Tbl_Inv_L4BindingSource.RemoveFilter()
        'Me.Tbl_Inv_L4BindingSource.RemoveSort()
    End Sub

    Private Sub Tbl_Inv_L3BindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_L3BindingSource.PositionChanged
        Me.Tbl_Inv_L4BindingSource.MoveLast()
        Me.Tbl_Inv_L4BindingSource.RemoveFilter()
        'Me.Tbl_Inv_L4BindingSource.RemoveSort()
    End Sub
    Private Sub SaveL1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveL1.Click
        Try
            Me.Validate()
            Me.Tbl_Inv_L1BindingSource.EndEdit()
            Me.Tbl_Inv_L1TableAdapter.Update(Me.DSCodeProc.tbl_Inv_L1)
            MsgBox("Layer 1 Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SaveL2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveL2.Click
        Try
            Me.Validate()
            Me.Tbl_Inv_L2BindingSource.EndEdit()
            Me.Tbl_Inv_L2TableAdapter.Update(Me.DSCodeProc.tbl_Inv_L2)
            MsgBox("Layer 2 Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SaveL3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveL3.Click
        Try
            Me.Validate()
            Me.Tbl_Inv_L3BindingSource.EndEdit()
            Me.Tbl_Inv_L3TableAdapter.Update(Me.DSCodeProc.tbl_Inv_L3)
            MsgBox("Layer 3 Record Saved.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SaveL4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveL4.Click
        SaveLayer4()
    End Sub
    Private Sub CMtxtMatName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtMatName.GotFocus
        If CMtxtMatName.Text = "Enter Material Name" Then
            CMtxtMatName.Text = ""
            CMtxtMatName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CMtxtMatName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMtxtMatName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.CMtxtMatName.Text.Length = 0 Then
                'Me.Tbl_Inv_L4BindingSource.RemoveFilter()
            Else
                Me.Tbl_Inv_L4BindingSource.Filter = "L4Name LIKE '%" & Me.CMtxtMatName.Text & "%'"
            End If
            Me.CMtxtMatName.Clear()
            Me.CMMatName.Hide()
        End If
    End Sub

    Private Sub CMtxtMatName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMtxtMatName.LostFocus
        If CMtxtMatName.Text = "" Then
            CMtxtMatName.Text = "Enter Material Name"
            CMtxtMatName.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Me.Tbl_Inv_L4BindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Me.Tbl_Inv_L4BindingSource.Sort = "L4name ASC"
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Me.Tbl_Inv_L4BindingSource.Sort = "L4name DESC"
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Me.Tbl_Inv_L4BindingSource.RemoveSort()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Tbl_Inv_L4BindingSource.Filter = "TMStatus=True"
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        Me.Tbl_Inv_L4BindingSource.Filter = "Status=True"
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_Inv_L4BindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_Inv_L4BindingSource.RemoveFilter()
    End Sub
    Private Sub Tbl_Inv_L4DataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_L4DataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub Tbl_Inv_L4DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_L4DataGridView.CellContentClick

    End Sub
End Class