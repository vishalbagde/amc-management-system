Imports System.Data.SqlClient
Module Report_Module
    Public Function get_dataset_for_crystal_report(ByVal query As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As SqlConnection = MyConnection()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = query
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(ds, "report_table1")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function

    Public Function getFirstDayOfWeek() As Date
        Dim dayOfWeek = CInt(DateTime.Today.DayOfWeek)
        Dim startOfWeek = DateTime.Today.AddDays(-1 * dayOfWeek)
        Return startOfWeek
    End Function
End Module
