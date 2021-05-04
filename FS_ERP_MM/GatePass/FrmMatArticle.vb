Public Class FrmMatArticle
    Private Sub Tbl_Pro_ArticleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmMatArticle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMat.tbl_Pro_Article_D' table. You can move, or remove it, as needed.
        Me.Tbl_Pro_Article_DTableAdapter.Fill(Me.DSMat.tbl_Pro_Article_D)
        'TODO: This line of code loads data into the 'DSMat.tbl_Pro_Article' table. You can move, or remove it, as needed.
        Me.Tbl_Pro_ArticleTableAdapter.Fill(Me.DSMat.tbl_Pro_Article)

    End Sub

    Private Sub Tbl_Pro_Article_DDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Pro_Article_DDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Pro_Article_DDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Pro_Article_DDataGridView.DataError

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.Tbl_Pro_ArticleBindingSource.EndEdit()
            Me.Tbl_Pro_Article_DTableAdapter.Update(Me.DSMat.tbl_Pro_Article_D)
            Me.Tbl_Pro_Article_DTableAdapter.Fill(Me.DSMat.tbl_Pro_Article_D)
            MsgBox("Data Saved")
        Catch ex As Exception

        End Try
    End Sub
End Class