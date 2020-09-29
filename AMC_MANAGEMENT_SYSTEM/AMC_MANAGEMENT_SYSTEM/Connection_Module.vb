Imports System.Data.SqlClient
Module Connection_Module
    Public con As New SqlConnection
    Dim result As Boolean
    Dim conString As String
    Public Function MyConnection() As SqlConnection
        Try
            conString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AMC_SYS\AMC_MANAGEMENT_SYSTEM\AMC_MANAGEMENT_SYSTEM\AMC_DB.mdf;Integrated Security=True"
            con.ConnectionString = conString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return con
    End Function
End Module
