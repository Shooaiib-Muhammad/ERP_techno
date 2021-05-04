Imports System.ComponentModel

Public Class NewScrabMaterial




    Private Sub NewScrabMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSScrab.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSScrab.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSScrab.tbl_Main_Scrab_Entries' table. You can move, or remove it, as needed.
        Me.Tbl_Main_Scrab_EntriesTableAdapter.Fill(Me.DSScrab.tbl_Main_Scrab_Entries)
        'TODO: This line of code loads data into the 'DSScrab.tbl_Scrap_Head' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Scrap_HeadTableAdapter.Fill(Me.DSScrab.tbl_Scrap_Head, DayID.Text)
        Catch ex As Exception
        End Try
        'Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSScrab.tbl_Inv_Tran_Date)
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        Me.Tbl_Scrap_HeadBindingSource.MoveLast()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

        Try
            Me.ValidateChildren()
            Me.Tbl_Scrap_HeadBindingSource.EndEdit()
            'Me.Tbl_Scrap_HeadTableAdapter.Insert(DayID.Text, GPNoTextBox.Text, TextBox1.Text)
            Me.Tbl_Scrap_HeadTableAdapter.Fill(Me.DSScrab.tbl_Scrap_Head, DayID.Text)
            Me.Tbl_Scrap_HeadBindingSource.MoveLast()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        Dim j As Int16 = Me.Tbl_Main_Scrab_EntriesBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Main_Scrab_EntriesBindingSource.EndEdit()
            Me.Tbl_Main_Scrab_EntriesTableAdapter.Update(Me.DSScrab.tbl_Main_Scrab_Entries)
            Me.Tbl_Main_Scrab_EntriesTableAdapter.Fill(Me.DSScrab.tbl_Main_Scrab_Entries)
            Me.Tbl_Main_Scrab_EntriesBindingSource.Position = j
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Main_Scrab_EntriesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Main_Scrab_EntriesDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Main_Scrab_EntriesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Main_Scrab_EntriesDataGridView.DataError

    End Sub



    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        Try
            Me.Tbl_Scrap_HeadTableAdapter.Fill(Me.DSScrab.tbl_Scrap_Head, DayID.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class