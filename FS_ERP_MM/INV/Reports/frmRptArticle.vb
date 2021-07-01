Public Class frmRptArticle

    Private Sub Tbl_Pro_ClientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Pro_ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSArticle)

    End Sub

    Private Sub frmRptArticle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.View_L4TableAdapter.Fill(Me.DSArticle.View_L4)
        Me.Tbl_Pro_ArticleTableAdapter.Fill(Me.DSArticle.tbl_Pro_Article)
        Me.Tbl_Pro_ClientTableAdapter.Fill(Me.DSArticle.tbl_Pro_Client)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New Class_Utility
        Dim Path As String = "\\server\myreports$\FSERPMM\Inventory\New\RptInvOutArt.rpt"
        If RadioButton1.Checked Then

            obj.LoadReports(Path, "{tbl_Inv_L4.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And {tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & " # and {tbl_Inv_Tran_Out.ArtCode}='" & Me.ArtCodeComboBox.Text & "'", "")
        ElseIf RadioButton2.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\New\RptInvOutArtNew.rpt"
            'RptInvOutArtNew.rpt
            '"FirstDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&MyDate1=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&MyDate2=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & ""
            obj.LoadReports(Path, "{Proc_Inv_Art_Out;1.ClientID}=" & Me.ClientNameComboBox.SelectedValue & " And {Proc_Inv_Art_Out;1.FactoryCode} = '" & Me.ComboBox1.Text & "'", "@FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class