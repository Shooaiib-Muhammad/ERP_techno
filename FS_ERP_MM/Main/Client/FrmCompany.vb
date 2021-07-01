Public Class FrmCompany


    Private Sub FrmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUL.tbl_Comp_Profile' table. You can move, or remove it, as needed.
        Me.Tbl_Comp_ProfileTableAdapter.Fill(Me.DSUL.tbl_Comp_Profile)

    End Sub



    Private Sub Tbl_Comp_ProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Comp_ProfileBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Comp_ProfileBindingSource.EndEdit()
            Me.Tbl_Comp_ProfileTableAdapter.Update(Me.DSUL.tbl_Comp_Profile)
            Me.Tbl_Comp_ProfileTableAdapter.Fill(Me.DSUL.tbl_Comp_Profile)
            MsgBox("Data Saved")

        Catch ex As Exception

        End Try
    End Sub
End Class