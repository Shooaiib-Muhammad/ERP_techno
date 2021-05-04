Public Class FrmAsserts
    Private Sub Tbl_Asserts_TypeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Asserts_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSAsserts)

    End Sub

    Private Sub FrmAsserts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAsserts.view_Asserts' table. You can move, or remove it, as needed.
        Me.View_AssertsTableAdapter.Fill(Me.DSAsserts.view_Asserts)
        'TODO: This line of code loads data into the 'DSAsserts.tbl_Assert' table. You can move, or remove it, as needed.
        Me.Tbl_AssertTableAdapter.Fill(Me.DSAsserts.tbl_Assert)
        'TODO: This line of code loads data into the 'DSAsserts.tbl_Assert_OR_Life' table. You can move, or remove it, as needed.
        Me.Tbl_Assert_OR_LifeTableAdapter.Fill(Me.DSAsserts.tbl_Assert_OR_Life)
        'TODO: This line of code loads data into the 'DSAsserts.tbl_Asserts_Type' table. You can move, or remove it, as needed.
        Me.Tbl_Asserts_TypeTableAdapter.Fill(Me.DSAsserts.tbl_Asserts_Type)
        Clear()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        'If RadioButton2.Checked = True Then
        '    MaskedTextBox2.Visible = True
        '    DateTimePicker2.Visible = True

        'Else
        '    MaskedTextBox2.Visible = False
        '    DateTimePicker2.Visible = False
        'End If
    End Sub

    Private Sub DateTimePicker14_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker14.ValueChanged

    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.TextChanged
        MaskedTextBox1.Text = Me.DateTimePicker1.Text
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub DateTimePicker2_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.TextChanged
        MaskedTextBox2.Text = Me.DateTimePicker2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If AssertTypeComboBox.Text = "" Then
                MsgBox("Select Assert Type")
            ElseIf NameTextBox.Text = "" Then
                MsgBox("Enter Name")
            ElseIf NameTextBox.Text = "" Then
                MsgBox("Enter Name")
            ElseIf SectEffectiveDateMaskedTextBox.Text = "" Then
                MsgBox("Enter Original Purchase Date")
            ElseIf OriginalLifeComboBox.Text = "" Then
                MsgBox("Select Original Life Select")
            ElseIf MaskedTextBox1.Text = "" Then
                MsgBox("Over Hall Date")
            ElseIf CostTextBox.Text = "" Then
                MsgBox("Cost Must be entered")
            ElseIf OverHallCostTextBox.Text = "" Then
                MsgBox("OverHall Cost is Enter")
            Else





                If RadioButton1.Checked = True Then
                    Me.Tbl_AssertTableAdapter.Insert(AssertTypeComboBox.SelectedValue, SectEffectiveDateMaskedTextBox.Text, MaskedTextBox1.Text,
                                           OriginalLifeComboBox.SelectedValue, Nothing, CostTextBox.Text,
                                           OverHallCostTextBox.Text, DepreciationComboBox.Text, Nothing, AllocationTextBox.Text, Nothing, Nothing, Nothing, Now, NameTextBox.Text)
                ElseIf RadioButton2.Checked = True Then
                    Me.Tbl_AssertTableAdapter.Insert(AssertTypeComboBox.SelectedValue, SectEffectiveDateMaskedTextBox.Text, MaskedTextBox1.Text,
                                           OriginalLifeComboBox.SelectedValue, MaskedTextBox2.Text, CostTextBox.Text,
                                           OverHallCostTextBox.Text, DepreciationComboBox.Text, Nothing, AllocationTextBox.Text, Nothing, Nothing, Nothing, Now, NameTextBox.Text)
                End If


                MsgBox("Asssert Successfully Add ")
                Me.View_AssertsTableAdapter.Fill(Me.DSAsserts.view_Asserts)
                Clear()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Clear()
        AssertTypeComboBox.Text = ""
        SectEffectiveDateMaskedTextBox.Text = ""
        OriginalLifeComboBox.Text = ""
        MaskedTextBox1.Text = ""
        CostTextBox.Text = ""
        OverHallCostTextBox.Text = ""
        DepreciationComboBox.Text = ""
        AllocationTextBox.Text = ""
        MaskedTextBox2.Text = ""
    End Sub
    Private Sub DateTimePicker14_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker14.TextChanged
        SectEffectiveDateMaskedTextBox.Text = Me.DateTimePicker1.Text
    End Sub

    Private Sub SectEffectiveDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles SectEffectiveDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub SectEffectiveDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles SectEffectiveDateMaskedTextBox.GotFocus
        SectEffectiveDateMaskedTextBox.Text = Now.Date
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.View_AssertsBindingSource.EndEdit()
            Me.View_AssertsTableAdapter.Update(Me.DSAsserts.view_Asserts)
            Me.View_AssertsTableAdapter.Fill(Me.DSAsserts.view_Asserts)
            MsgBox("Data Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Me.View_AssertsBindingSource.RemoveCurrent()
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            MaskedTextBox2.Visible = True
            DateTimePicker2.Visible = True
        Else
            MaskedTextBox2.Visible = False
            DateTimePicker2.Visible = False
        End If
    End Sub
End Class