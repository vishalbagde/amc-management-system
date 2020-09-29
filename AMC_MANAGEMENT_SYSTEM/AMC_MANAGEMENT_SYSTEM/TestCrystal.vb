Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class TestCrystal
    Private Sub TestCrystal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try

        '    Dim con As SqlConnection = MyConnection()

        '    Dim cmd As New SqlCommand
        '    cmd.Connection = con
        '    cmd.CommandText = "select * from product_consume_service_wise_groupby_view"
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd

        '    Dim ds As New DataSet
        '    da.Fill(ds, "table1")

        '    Dim rptDoc As New CrystalReportProductServiceWiseGroupBy
        '    rptDoc.SetDataSource(ds.Tables("table1"))
        '    CrystalReportViewer1.ReportSource = rptDoc

        '    CrystalReportViewer1.Refresh()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try



        Try
            Dim con As SqlConnection = MyConnection()

            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "select * from category_mstr"
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet
            da.Fill(ds, "table1")

            Dim rptDoc As New CrystalReport1

            rptDoc.Database.Tables(0).SetDataSource(get_CompanyDetailsInDataTable())
            rptDoc.Database.Tables(1).SetDataSource(ds.Tables("table1"))
            CrystalReportViewer1.ReportSource = rptDoc

            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function get_CompanyDetailsInDataTable() As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Dim con As SqlConnection = MyConnection()

            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "select * from company_mstr"
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd

            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function

End Class