Public Class FrmArticleWiseWestage


    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)

        'load()

    End Sub
    Private Sub load()
        Try
            If RadioButton1.Checked = True Then
                Try
                    Me.VIew_MLP_Westage_ArticleTableAdapter.FillBy(DSWestage.VIew_MLP_Westage_Article, DateTimePicker1.Value, DateTimePicker2.Value, ComboBox1.Text)
                Catch ex As Exception

                End Try
            ElseIf RadioButton2.Checked = True Then
                Try
                    Me.VIew_MLP_Westage_ArticleTableAdapter.FillBy1(DSWestage.VIew_MLP_Westage_Article, DateTimePicker1.Value, DateTimePicker2.Value, ComboBox1.Text)
                Catch ex As Exception

                End Try
            End If
        Catch ex As System.Exception
        End Try

    End Sub
    Private Sub FrmArticleWiseWestage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        load()

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        load()

    End Sub

    Private Sub VIew_MLP_Westage_ArticleDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VIew_MLP_Westage_ArticleDataGridView.CellContentClick
        If e.ColumnIndex = 15 Then
            If Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value Is DBNull.Value Then
                Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value = True
                Me.VIew_MLP_Westage_ArticleDataGridView.Item(16, e.RowIndex).Value = Now.Date
            Else
                If Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value = False Then
                    Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value = True
                    Me.VIew_MLP_Westage_ArticleDataGridView.Item(16, e.RowIndex).Value = Now.Date
                Else
                    Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value = False
                    Me.VIew_MLP_Westage_ArticleDataGridView.Item(16, e.RowIndex).Value = DBNull.Value
                End If
            End If


        End If

    End Sub

    Private Sub VIew_MLP_Westage_ArticleDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles VIew_MLP_Westage_ArticleDataGridView.CellEnter
        If e.ColumnIndex = 15 Then
            If Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value Is DBNull.Value Then
                Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value = True
                Me.VIew_MLP_Westage_ArticleDataGridView.Item(16, e.RowIndex).Value = Now.Date
            Else
                If Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value = False Then
                    Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value = True
                    Me.VIew_MLP_Westage_ArticleDataGridView.Item(16, e.RowIndex).Value = Now.Date
                Else
                    Me.VIew_MLP_Westage_ArticleDataGridView.Item(15, e.RowIndex).Value = False
                    Me.VIew_MLP_Westage_ArticleDataGridView.Item(16, e.RowIndex).Value = DBNull.Value
                End If
            End If


        End If
    End Sub

    Private Sub VIew_MLP_Westage_ArticleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VIew_MLP_Westage_ArticleBindingNavigatorSaveItem.Click
        Try
            ValidateChildren()
            Me.VIew_MLP_Westage_ArticleBindingSource.EndEdit()
            Me.VIew_MLP_Westage_ArticleTableAdapter.Update(DSWestage.VIew_MLP_Westage_Article)
            load()
            MsgBox("Data Saved")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        load()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        load()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path, Filter As String
        Dim obj As New Class_Utility
        If RadioButton1.Checked = True Then ''Active GP
            Filter = "{View_PC_Westage_Article_Wise_BGrade.FactoryCode} = '" & ComboBox1.Text & "' and {View_PC_Westage_Article_Wise_BGrade.CrushDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

            If ComboBox1.Text = "B34001" Or ComboBox1.Text = "B34005" Then
                path = "\\server\MyReports$\FSERPMM\GatePass\RptGradeGatePass.rpt"
            Else
                path = "\\server\MyReports$\FSERPMM\GatePass\RptGGradeGatePass.rpt"
            End If
        ElseIf RadioButton2.Checked = True Then '' Non Active GP
            path = "\\server\MyReports$\FSERPMM\GatePass\Rptdisablegatepass.rpt"
            Filter = "{View_PC_Westage_Article_Wise_BGrade.FactoryCode} = '" & ComboBox1.Text & "' and {View_PC_Westage_Article_Wise_BGrade.DateName} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

        End If



        'Filter = "{View_PC_Westage_Article_Wise_BGrade.EntryID}  =" & Me.VIew_MLP_Westage_ArticleDataGridView.Item(0, e.RowIndex).Value & ""
        obj.LoadReports(path, Filter, "")
    End Sub
End Class