Public Class FrmPartialQty
    Dim flag As Boolean = False
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmMatReq.partialQty = Val(Me.PartialQtyTextBox.Text)
        frmMatReq.flag = True
        flag = True
        Me.Close()
    End Sub
    Private Sub FrmPartialQty_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If flag = True Then
            frmMatReq.InsertQty()
        End If
    End Sub
End Class