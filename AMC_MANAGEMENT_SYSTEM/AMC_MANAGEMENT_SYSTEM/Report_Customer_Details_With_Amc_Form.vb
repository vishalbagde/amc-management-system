Public Class Report_Customer_Details_With_Amc_Form
    Dim FromToDate As String = ""
    Private Sub Report_Customer_Details_With_Amc_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)

        Dim detailsTypeDic As New Dictionary(Of String, String)
        detailsTypeDic.Add("1", "AMC")
        detailsTypeDic.Add("2", "With Service")
        cbServiceOption.DataSource = New BindingSource(detailsTypeDic, Nothing)
        cbServiceOption.ValueMember = "key"
        cbServiceOption.DisplayMember = "value"

        cbReportDate.DataSource = New BindingSource(fill_report_date_list_in_cb(), Nothing)
        cbReportDate.ValueMember = "key"
        cbReportDate.DisplayMember = "value"

        mtxtFrom.Text = Date.Now
        mtxtTo.Text = Date.Now

        Dim rptDoc As New CrystalReportCustomerDetailsWithAMCAndSer
        FromToDate = "Till Date " + Format(Date.Now, "dd-mm-yyyy")
        Dim query As String = "select * from customer_details_with_amc_and_ser_view"
        rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
        rptDoc.SetParameterValue("FromToDate", FromToDate)
        crvCustomerDetailsWithAMC.ReportSource = rptDoc
        crvCustomerDetailsWithAMC.Refresh()
    End Sub



    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim service_type As Integer = cbServiceOption.SelectedItem.key
        Dim parameter As Integer = cbReportDate.SelectedItem.key
        Dim query As String = ""
        Dim temp_date As Date = Date.Now

        If service_type = 1 Then 'with AMC

            If parameter = 1 Then
                FromToDate = "Till Date " + Format(Date.Now, "dd-mm-yyyy")
                query = "select * from customer_details_with_amc_view
                      where contract_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
                MsgBox(Format(temp_date, "MM-dd-yyyy"))
            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                FromToDate = "Report Date From " + Format(firstDayOfWeek, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from customer_details_with_amc_view
                      where contract_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                FromToDate = "Report Date From " + Format(startDateofMonth, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from customer_details_with_amc_view
                      where contract_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                FromToDate = "Report Date From " + Format(startDateofyear, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from customer_details_with_amc_view
                      where contract_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                FromToDate = "Report Date From " + Format(fromDate, "dd-MM-yyyy") + " To " + Format(toDate, "dd-MM-yyyy")
                query = "select * from customer_details_with_amc_view
                      where contract_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from customer_details_with_amc_view"
            End If

            Dim rptDoc As New CrystalReportCustomerDetailsWithAMC

            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
            rptDoc.SetParameterValue("FromToDate", FromToDate)
            crvCustomerDetailsWithAMC.ReportSource = rptDoc
            crvCustomerDetailsWithAMC.Refresh()

        ElseIf service_type = 2 Then 'with Service
            If parameter = 1 Then
                FromToDate = "Till Date " + Format(Date.Now, "dd-mm-yyyy")
                query = "select * from customer_details_with_amc_and_ser_view
                      where contract_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
                MsgBox(Format(temp_date, "MM-dd-yyyy"))
            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                FromToDate = "Report Date From " + Format(firstDayOfWeek, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from customer_details_with_amc_and_ser_view
                      where contract_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                FromToDate = "Report Date From " + Format(startDateofMonth, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from customer_details_with_amc_and_ser_view
                      where contract_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                FromToDate = "Report Date From " + Format(startDateofyear, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from customer_details_with_amc_and_ser_view
                      where contract_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                FromToDate = "Report Date From " + Format(fromDate, "dd-MM-yyyy") + " To " + Format(toDate, "dd-MM-yyyy")
                query = "select * from customer_details_with_amc_and_ser_view
                      where contract_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from customer_details_with_amc_and_ser_view"
            End If

            Dim rptDoc As New CrystalReportCustomerDetailsWithAMCAndSer
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
            rptDoc.SetParameterValue("FromToDate", FromToDate)
            crvCustomerDetailsWithAMC.ReportSource = rptDoc
            crvCustomerDetailsWithAMC.Refresh()

        Else


        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class