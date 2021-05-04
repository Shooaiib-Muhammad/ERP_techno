Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()

        TotalAmount()
    End Sub
    Private Sub LoadData()
        Try
            Me.Tbl_Sec_Middle_NEWTableAdapter.Fill(Me.DSInwardVeri.tbl_Sec_Middle_NEW, DateTimePicker1.Text, DateTimePicker2.Text)

        Catch ex As Exception

        End Try
        Try
            Me.Tbl_Sec_EnteriesTableAdapter.FillBy(Me.DSInwardVeri.tbl_Sec_Enteries, Label18.Text)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click

        Try
            Me.Validate()
            Me.Tbl_Sec_EnteriesBindingSource.EndEdit()
            Me.Tbl_Sec_EnteriesTableAdapter.Update(Me.DSInwardVeri.tbl_Sec_Enteries)
            Try
                Me.Tbl_Sec_EnteriesTableAdapter.FillBy(Me.DSInwardVeri.tbl_Sec_Enteries, Label18.Text)
            Catch ex As Exception

            End Try
            TotalAmount()
            MsgBox("Data Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub TotalAmount()
        Dim k As Integer = 0
        Try
            For j As Int32 = 0 To Me.Tbl_Sec_Enteries_NEWDataGridView.RowCount - 1
                k = k + Me.Tbl_Sec_Enteries_NEWDataGridView(5, j).Value
            Next
        Catch ex As Exception

        End Try

        Label9.Text = FormatNumber(k, 1, TriState.UseDefault, TriState.UseDefault, TriState.True)

        Dim i As Integer = 0
        Try
            For s As Int32 = 0 To Me.Tbl_Sec_Enteries_NEWDataGridView.RowCount - 1
                i = i + Me.Tbl_Sec_Enteries_NEWDataGridView(10, s).Value
            Next
        Catch ex As Exception

        End Try

        Label16.Text = FormatNumber(i, 1, TriState.UseDefault, TriState.UseDefault, TriState.True)
    End Sub


    Private Sub Tbl_Sec_Enteries_NEWDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Sec_Enteries_NEWDataGridView.CellContentClick
        If e.ColumnIndex = 5 Then
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(5, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Sec_Enteries_NEWDataGridView.Item(5, e.RowIndex).Value = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(1, e.RowIndex).Value) * (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(4, e.RowIndex).Value)
            Else
                Me.Tbl_Sec_Enteries_NEWDataGridView.Item(5, e.RowIndex).Value = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(1, e.RowIndex).Value) * (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(4, e.RowIndex).Value)
            End If
        End If
        If e.ColumnIndex = 10 Then

            Dim FarePrice As Int64
            Dim OtherChages As Int64
            Dim Discount As Int64
            Dim Salestxt As Int64
            Dim Final As Int64
            Dim Amount As Int64
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(6, e.RowIndex).Value Is DBNull.Value Then
                FarePrice = 0
            Else
                FarePrice = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(6, e.RowIndex).Value)
            End If
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(9, e.RowIndex).Value Is DBNull.Value Then
                OtherChages = 0
            Else
                OtherChages = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(9, e.RowIndex).Value)
            End If
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(7, e.RowIndex).Value Is DBNull.Value Then
                Discount = 0
            Else
                Discount = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(7, e.RowIndex).Value)
            End If
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(8, e.RowIndex).Value Is DBNull.Value Then
                Salestxt = 0
            Else
                Salestxt = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(8, e.RowIndex).Value)
            End If

            Amount = Me.Tbl_Sec_Enteries_NEWDataGridView.Item(5, e.RowIndex).Value

            Final = Amount + FarePrice + OtherChages + Salestxt - Discount
            Me.Tbl_Sec_Enteries_NEWDataGridView.Item(10, e.RowIndex).Value = Final
            TotalAmount()
            'End If
        End If
    End Sub

    Private Sub Tbl_Sec_Enteries_NEWDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Sec_Enteries_NEWDataGridView.DataError

    End Sub





    Private Sub DateTimePicker14_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Tbl_Sec_Middle_NEWBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Sec_Middle_NEWBindingNavigatorSaveItem.Click

        Dim VerifyStatus As Boolean
        Dim EffectiveDate As String

        If AuditVefiyCheckBox.Checked = True Then
            VerifyStatus = True
            EffectiveDate = CType(SectEffectiveDateMaskedTextBox.Text, Date)
        Else
            EffectiveDate = Nothing
            VerifyStatus = False
        End If

        Try
            Dim j As Int16 = Me.Tbl_Sec_Middle_NEWBindingSource.Position
            Me.Validate()
            Me.Tbl_Sec_Middle_NEWBindingSource.EndEdit()

            If Me.MaskedTextBox1.Text.ToString = "  -  -" Then
                If AuditVefiyCheckBox.Checked = True Then
                    Me.Tbl_Sec_Middle_NEWTableAdapter.UpdateQuery(VerifyStatus, EffectiveDate, Nothing, ComboBox1.Text, TextBox2.Text, Now.Date, TextBox1.Text, Label18.Text)
                Else
                    Me.Tbl_Sec_Middle_NEWTableAdapter.UpdateQuery(VerifyStatus, Nothing, Nothing, ComboBox1.Text, TextBox2.Text, Now.Date, TextBox1.Text, Label18.Text)
                End If
            Else
                If AuditVefiyCheckBox.Checked = True Then
                    Me.Tbl_Sec_Middle_NEWTableAdapter.UpdateQuery(VerifyStatus, EffectiveDate, MaskedTextBox1.Text, ComboBox1.Text, TextBox2.Text, Now.Date, TextBox1.Text, Label18.Text)
                Else
                    Me.Tbl_Sec_Middle_NEWTableAdapter.UpdateQuery(VerifyStatus, Nothing, MaskedTextBox1.Text, ComboBox1.Text, TextBox2.Text, Now.Date, TextBox1.Text, Label18.Text)
                End If
            End If
            Me.Tbl_Sec_Middle_NEWBindingSource.Position = j

            MsgBox("Data Saved")

            Try
                Me.Tbl_Sec_EnteriesTableAdapter.FillBy(Me.DSInwardVeri.tbl_Sec_Enteries, Label18.Text)
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SectEffectiveDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles SectEffectiveDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub SectEffectiveDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles SectEffectiveDateMaskedTextBox.GotFocus
        If SectEffectiveDateMaskedTextBox.Text = "  -  -" Then
            SectEffectiveDateMaskedTextBox.Text = Now.Date
        End If
    End Sub

    Private Sub AuditVefiyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AuditVefiyCheckBox.CheckedChanged
        If AuditVefiyCheckBox.Checked = True Then
            SectEffectiveDateMaskedTextBox.Text = Now.Date
        Else
            SectEffectiveDateMaskedTextBox.Text = ""
            AuditVefiyCheckBox.Checked = False
        End If
    End Sub

    Private Sub Tbl_Sec_Enteries_NEWDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Sec_Enteries_NEWDataGridView.CellEnter
        If e.ColumnIndex = 5 Then
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(5, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Sec_Enteries_NEWDataGridView.Item(5, e.RowIndex).Value = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(1, e.RowIndex).Value) * (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(4, e.RowIndex).Value)
            Else
                Me.Tbl_Sec_Enteries_NEWDataGridView.Item(5, e.RowIndex).Value = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(1, e.RowIndex).Value) * (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(4, e.RowIndex).Value)
            End If
        End If
        If e.ColumnIndex = 10 Then
            'If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(10, e.RowIndex).Value Is DBNull.Value Then
            Dim FarePrice As Int64
            Dim OtherChages As Int64
            Dim Discount As Int64
            Dim Salestxt As Int64
            Dim Final As Int64
            Dim Amount As Int64
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(6, e.RowIndex).Value Is DBNull.Value Then
                FarePrice = 0
            Else
                FarePrice = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(6, e.RowIndex).Value)
            End If
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(9, e.RowIndex).Value Is DBNull.Value Then
                OtherChages = 0
            Else
                OtherChages = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(9, e.RowIndex).Value)
            End If
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(7, e.RowIndex).Value Is DBNull.Value Then
                Discount = 0
            Else
                Discount = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(7, e.RowIndex).Value)
            End If
            If Me.Tbl_Sec_Enteries_NEWDataGridView.Item(8, e.RowIndex).Value Is DBNull.Value Then
                Salestxt = 0
            Else
                Salestxt = (Me.Tbl_Sec_Enteries_NEWDataGridView.Item(8, e.RowIndex).Value)
            End If


            Amount = Me.Tbl_Sec_Enteries_NEWDataGridView.Item(5, e.RowIndex).Value

            Final = Amount + FarePrice + OtherChages + Salestxt - Discount
            Me.Tbl_Sec_Enteries_NEWDataGridView.Item(10, e.RowIndex).Value = Final
            TotalAmount()

        End If

    End Sub



    Private Sub DateTimePicker2_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadData()
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadData()
    End Sub

    Private Sub Tbl_Sec_Middle_NEWBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Sec_Middle_NEWBindingSource.PositionChanged
        Try
            Me.Tbl_Sec_EnteriesTableAdapter.FillBy(Me.DSInwardVeri.tbl_Sec_Enteries, Label18.Text)
        Catch ex As Exception

        End Try
    End Sub


End Class