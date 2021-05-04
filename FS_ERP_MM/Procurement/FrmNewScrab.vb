Public Class FrmNewScrab

    Dim Filter As String = ""
    Dim Path As String = ""
    Dim parameter As String = ""
    Dim objRptViewer As New Class_Utility
    Private Sub FrmNewScrab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSScrab.Max_GPNO' table. You can move, or remove it, as needed.
        Me.Max_GPNOTableAdapter.Fill(Me.DSScrab.Max_GPNO)
        'TODO: This line of code loads data into the 'DSScrab.tbl_Main_Scrab_Entries' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Main_Scrab_EntriesTableAdapter.Fill(Me.DSScrab.tbl_Main_Scrab_Entries)
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'DSScrab.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Try
            If Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSScrab.tbl_Inv_Tran_Date, Now.Date) > 0 Then
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSScrab.tbl_Inv_Tran_Date, Now.Date.AddDays(-30))
            Else
                Me.Tbl_Inv_Tran_DateTableAdapter.Insert(Now.Date)
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSScrab.tbl_Inv_Tran_Date, Now.Date.AddDays(-30))
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Me.Tbl_Scrap_HeadTableAdapter.Fill(Me.DSScrab.tbl_Scrap_Head, DayID.Text)
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Me.Tbl_Scrap_HeadBindingSource.MoveLast()

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Scrap_HeadBindingSource.EndEdit()
            Me.Tbl_Scrap_HeadTableAdapter.Insert(DayID.Text, Label3.Text, ItemNameTextBox.Text, TextBox1.Text)
            Me.Tbl_Scrap_HeadTableAdapter.Fill(Me.DSScrab.tbl_Scrap_Head, DayID.Text)
            Me.Tbl_Scrap_HeadBindingSource.MoveLast()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click

        Try
            Me.ValidateChildren()
            Me.Tbl_Main_Scrab_EntriesBindingSource.EndEdit()
            Me.Tbl_Main_Scrab_EntriesTableAdapter.Update(Me.DSScrab.tbl_Main_Scrab_Entries)
            Me.Tbl_Main_Scrab_EntriesTableAdapter.Fill(Me.DSScrab.tbl_Main_Scrab_Entries)

            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Main_Scrab_EntriesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Main_Scrab_EntriesDataGridView.CellContentClick
        If e.ColumnIndex = 6 Then 'Save And  Print
            Path = "\\Server\MyReports$\ERPProcurement\ScrapRpt.rpt"
            parameter = "UserName=" & frmLoginVer.LoginName & ""
            Filter = "{view_Scrab_material.TransID} =" & Tbl_Main_Scrab_EntriesDataGridView(0, e.RowIndex).Value & ""
            objRptViewer.LoadReports(Path, Filter, parameter)



        End If
    End Sub

    Private Sub Tbl_Main_Scrab_EntriesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Main_Scrab_EntriesDataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
             Me.Tbl_Scrap_HeadTableAdapter.Fill(Me.DSScrab.tbl_Scrap_Head, DayID.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Path = "\\Server\MyReports$\ERPProcurement\ScrapRpt.rpt"
        Filter = "{view_Scrab_material.GPNo} = " & GPNoTextBox.Text & ""
        objRptViewer.LoadReports(Path, Filter, "")
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        Me.Tbl_Scrap_HeadBindingSource.AddNew()
        Dim GPNO As Int64 = Me.Tbl_Scrap_HeadTableAdapter.MaxGP + 1
        'Me.Max_GPNOTableAdapter.Fill(Me.DSScrab.Max_GPNO)

        'GPNO = GPNoLabel2.Text + 1
        Label3.Text = GPNO

    End Sub
End Class