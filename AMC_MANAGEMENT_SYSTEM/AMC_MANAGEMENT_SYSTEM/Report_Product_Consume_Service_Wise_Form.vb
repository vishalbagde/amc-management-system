Imports System.Data.SqlClient
Public Class Report_Product_Consume_Service_Wise_Form
    Private Sub Report_Product_Consume_Service_Wise_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)

        cbProductConsumeType.DataSource = New BindingSource(fill_report_service_Type_in_cb, Nothing)
        cbProductConsumeType.ValueMember = "key"
        cbProductConsumeType.DisplayMember = "value"

        cbReportDate.DataSource = New BindingSource(fill_report_date_list_in_cb(), Nothing)
        cbReportDate.ValueMember = "key"
        cbReportDate.DisplayMember = "value"

        mtxtFrom.Text = Date.Now
        mtxtTo.Text = Date.Now

        Dim rptDoc As New CrystalReportReportProductConsumeServiceWiseForm
        Dim query As String = "select * from product_cunsume_service_wise_view"
        rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
        crvProductConSevWise.ReportSource = rptDoc
        crvProductConSevWise.Refresh()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim product_type As Integer = cbProductConsumeType.SelectedItem.key
        Dim parameter As Integer = cbReportDate.SelectedItem.key
        Dim query As String = ""
        Dim temp_date As Date = Date.Now

        If product_type = 0 Then 'All

            If parameter = 1 Then
                query = "select * from product_cunsume_ServiceAndcomplain_wise_view
                      where date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                query = "select * from product_cunsume_ServiceAndcomplain_wise_view
                      where date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)

                query = "select * from product_cunsume_ServiceAndcomplain_wise_view
                      where date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                query = "select * from product_cunsume_ServiceAndcomplain_wise_view
                      where date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                query = "select * from product_cunsume_ServiceAndcomplain_wise_view
                      where date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from product_cunsume_ServiceAndcomplain_wise_view"
            End If

            Dim rptDoc As New CrystalReportProductConsumeServiceAndComplainWise
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables("report_table1"))
            crvProductConSevWise.ReportSource = rptDoc
            crvProductConSevWise.Refresh()

        ElseIf product_type = 1 Then 'Service
            If parameter = 1 Then
                query = "select * from product_cunsume_service_wise_view
                      where date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                query = "select * from product_cunsume_service_wise_view
                      where date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then
                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)

                query = "select * from product_cunsume_service_wise_view
                      where date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                query = "select * from product_cunsume_service_wise_view
                      where date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                query = "select * from product_cunsume_service_wise_view
                      where date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from product_cunsume_service_wise_view"
            End If

            Dim rptDoc As New CrystalReportReportProductConsumeServiceWiseForm
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables("report_table1"))
            crvProductConSevWise.ReportSource = rptDoc
            crvProductConSevWise.Refresh()

        ElseIf product_type = 2 Then 'complain
            If parameter = 1 Then
                query = "select * from product_cunsume_complain_wise_view
                      where date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                query = "select * from product_cunsume_complain_wise_view
                      where date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then
                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)

                query = "select * from product_cunsume_complain_wise_view
                      where date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                query = "select * from product_cunsume_complain_wise_view
                      where date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                query = "select * from product_cunsume_complain_wise_view
                      where date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from product_cunsume_complain_wise_view"
            End If
            Dim rptDoc As New CrystalReportProductConsumeComplainWise
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables("report_table1"))
            crvProductConSevWise.ReportSource = rptDoc
            crvProductConSevWise.Refresh()
        Else
        End If
    End Sub
    Private Function get_Report_Product_Consume_Service_Wise_Form() As DataSet
        Dim ds As New DataSet
        Try
            Dim con As SqlConnection = MyConnection()

            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "select * from product_cunsume_service_wise_view"
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd

            da.Fill(ds, "report_table1")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cbReportDate_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbReportDate.SelectionChangeCommitted
        If cbReportDate.SelectedItem.key = 5 Then
            mtxtTo.Enabled = True
            mtxtFrom.Enabled = True
        Else
            mtxtTo.Enabled = False
            mtxtFrom.Enabled = False
        End If
    End Sub
End Class