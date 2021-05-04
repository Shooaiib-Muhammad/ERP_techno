Public Class Class_Utility
    'Public Shared UserId As Integer = frmLoginVer.DeptID
    Function ChildWindowOpen(ByVal childWindow As String)
        'Opens child forms in parent form
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.WindowState = FormWindowState.Maximized
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub LoadReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        'This function is used to open reports
        Dim Obj_frmRptViewer As New frmRptViewer
        If ChildWindowOpen("frmRptViewer") = False Then
            Try
                Obj_frmRptViewer.ViewReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Obj_frmRptViewer.MdiParent = frmMain
            Obj_frmRptViewer.Show()
        End If
    End Sub
    Dim UserId As Integer
    Function USerIDValue()
        UserId = frmLoginVer.UserID
        Return UserId
    End Function
End Class
