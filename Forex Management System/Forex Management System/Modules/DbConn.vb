Imports System.Data.Odbc
Module DbConn
    Public sql As String
    Public dml As OdbcCommand
    Public dr As OdbcDataReader
    Public conn As OdbcConnection
    Public dt As New DataTable
    Public bs As New BindingSource
    Public da As New OdbcDataAdapter

    Public Sub conn1()
        conn = New OdbcConnection("DSN=Forex")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            conn.Close()
        End If
    End Sub
End Module
