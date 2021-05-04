Imports System.data
Imports System.IO
Imports SDO = System.Data.Odbc

Public Class db

    Public con As New SDO.OdbcConnection
    Public com As New SDO.OdbcCommand

    Public qry As String
    Public Rd As SDO.OdbcDataReader
    Public DA As New SDO.OdbcDataAdapter
    Public DA1 As New SDO.OdbcDataAdapter
    Public DA2 As New SDO.OdbcDataAdapter
    Public DS1 As New DataSet
    Public DS2 As New DataSet

    Public UID As Integer
    Public UN As String
    Public Shared MyCode As String
    Public Shared MyRow As Integer

    Public ComCH As New SDO.OdbcCommand
    Public RdCH As SDO.OdbcDataReader

    Public Sub open()
        Dim conString As String = My.Settings.Con
        Try
            If con.State = Data.ConnectionState.Closed Then
                con.ConnectionString = conString
                con.Open()
                com.Connection = con
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub close()
        Try
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
