Public Class frmChngPswd
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChngPswd.Click
        Dim UsrPSWd As String = Me.Tbl_User_LoginsTableAdapter.GetUserPswd(frmLoginVer.UserID)
        If txtNewPswd.TextLength > 0 Then
            If Me.txtOldPswd.Text = Me.txtNewPswd.Text Then
                MsgBox("Old Password And New Password Should be different", MsgBoxStyle.Critical)
                Me.txtOldPswd.Clear()
                Me.txtNewPswd.Clear()
                Me.txtConfirmdPswd.Clear()
                Me.txtOldPswd.Focus()
            Else
                If UsrPSWd = Me.txtOldPswd.Text And Me.txtNewPswd.Text = Me.txtConfirmdPswd.Text Then
                    Me.Tbl_User_LoginsTableAdapter.UpdateUserPswd(Me.txtNewPswd.Text, Now.Date, frmLoginVer.UserID)
                    MsgBox("Password has been Changed")
                    Me.txtOldPswd.Clear()
                    Me.txtNewPswd.Clear()
                    Me.txtConfirmdPswd.Clear()
                    Me.txtOldPswd.Focus()
                Else
                    MsgBox("Enter Match Password")
                    Me.txtOldPswd.Clear()
                    Me.txtNewPswd.Clear()
                    Me.txtConfirmdPswd.Clear()
                    Me.txtOldPswd.Focus()
                End If
            End If
        Else
            MsgBox("Enter Password To Continue", MsgBoxStyle.Information)
            Me.txtOldPswd.Focus()
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub frmChngPswd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_User_LoginsTableAdapter.FillBy1(Me.DSUM.tbl_User_Logins, frmLoginVer.UserID)
    End Sub
End Class