Public Class FrmMPNOWiseMaterial
    Private Sub FrmMPNOWiseMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Matreq.tbl_MPNO_Wise_Material' table. You can move, or remove it, as needed.
        Me.Tbl_MPNO_Wise_MaterialTableAdapter.Fill(Me.Matreq.tbl_MPNO_Wise_Material)
        'TODO: This line of code loads data into the 'Matreq.tbl_plan' table. You can move, or remove it, as needed.
        Me.Tbl_planTableAdapter.Fill(Me.Matreq.tbl_plan)

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_MPNO_Wise_MaterialBindingSource.EndEdit()
            Me.Tbl_MPNO_Wise_MaterialTableAdapter.Update(Matreq.tbl_MPNO_Wise_Material)
            Me.Tbl_MPNO_Wise_MaterialTableAdapter.Fill(Me.Matreq.tbl_MPNO_Wise_Material)
            MsgBox("Material Saved")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_MPNO_Wise_MaterialDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_MPNO_Wise_MaterialDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_MPNO_Wise_MaterialDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_MPNO_Wise_MaterialDataGridView.DataError

    End Sub


End Class