Public Class Report_Product_Consume_ServiceAndComplain_WiseGroupBy_Form
    Private Sub Report_Product_Consume_ServiceAndComplain_WiseGroupBy_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)

        cbProductConsumeType.DataSource = New BindingSource(fill_report_service_Type_in_cb, Nothing)
        cbProductConsumeType.ValueMember = "key"
        cbProductConsumeType.DisplayMember = "value"

        cbReportDate.DataSource = New BindingSource(fill_report_date_list_in_cb(), Nothing)
        cbReportDate.ValueMember = "key"
        cbReportDate.DisplayMember = "value"

        mtxtFrom.Text = Date.Now
        mtxtTo.Text = Date.Now

        Dim query As String = "select * from product_consume_complain_wise_groupby_view"
        Dim rptDoc As New CrystalReportProductComplainWiseGroupBy
        rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables("report_table1"))
        crvProductConSevWise.ReportSource = rptDoc
        crvProductConSevWise.Refresh()

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim product_type As Integer = cbProductConsumeType.SelectedItem.key
        Dim parameter As Integer = cbReportDate.SelectedItem.key
        Dim query As String = ""
        Dim temp_date As Date = Date.Now
        If product_type = 0 Then 'ALL

        ElseIf product_type = 1 Then 'Service
            If parameter = 1 Then
                query = "select * from product_consume_service_wise_groupby_view
                    where entry_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                query = "select * from product_consume_service_wise_groupby_view
                    where entry_date >= '" + Format(temp_date, "MM-dd-yyyy") + "'
                    and entry_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then
                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                query = "select * from product_consume_service_wise_groupby_view
                      where entry_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                query = "select * from product_consume_service_wise_groupby_view
                      where entry_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                query = "select * from product_consume_service_wise_groupby_view
                      where entry_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from product_consume_service_wise_groupby_view"
            End If
            Dim rptDoc As New CrystalReportProductServiceWiseGroupBy
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables("report_table1"))
            crvProductConSevWise.ReportSource = rptDoc
            crvProductConSevWise.Refresh()



        ElseIf product_type = 2 Then 'Complain
            If parameter = 1 Then
                query = "select * from product_consume_complain_wise_groupby_view
                    where entry_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                query = "select * from product_consume_complain_wise_groupby_view
                    where entry_date >= '" + Format(temp_date, "MM-dd-yyyy") + "'
                    and entry_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then
                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                query = "select * from product_consume_complain_wise_groupby_view
                      where entry_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                query = "select * from product_consume_complain_wise_groupby_view
                      where entry_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                query = "select * from product_consume_complain_wise_groupby_view
                      where entry_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from product_consume_complain_wise_groupby_view"
            End If
            Dim rptDoc As New CrystalReportProductComplainWiseGroupBy
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables("report_table1"))
            crvProductConSevWise.ReportSource = rptDoc
            crvProductConSevWise.Refresh()
        End If

    End Sub

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