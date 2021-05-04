Public Class frmIssuance
    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSDemandsNew)

    End Sub
    Private Sub loadData()
        If RadioButton8.Checked = True Then '' By Date
            Me.View_Tran_INTableAdapter.FillBy(Me.DSDemandsNew.View_Tran_IN, DateTimePicker1.Text, DateTimePicker2.Text)

        ElseIf RadioButton6.Checked = True Then '' By Item
            Me.View_Tran_INTableAdapter.FillBy2(Me.DSDemandsNew.View_Tran_IN, DateTimePicker1.Text, DateTimePicker2.Text, L4NameComboBox.SelectedValue)
        ElseIf RadioButton7.Checked = True Then '' By Code
            'Me.View_Tran_INTableAdapter.FillBy3(Me.DSDemandsNew.View_Tran_IN, CustNameComboBox.SelectedValue, DateTimePicker1.Text, DateTimePicker2.Text,)
        ElseIf RadioButton3.Checked = True Then '' By GD No.
            Me.View_Tran_INTableAdapter.FillBy4(Me.DSDemandsNew.View_Tran_IN, txtGMNO.Text)

        End If
    End Sub
    Private Sub frmIssuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDemandsNew.View_Tran_IN' table. You can move, or remove it, as needed.
        Me.View_Tran_INTableAdapter.Fill(Me.DSDemandsNew.View_Tran_IN)
        'TODO: This line of code loads data into the 'DSDemandsNew.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSDemandsNew.tbl_Inv_Tran_Date)

    End Sub
End Class