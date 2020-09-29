Public Class Customer_Payment_Details_Form
    Dim FromToDate As String = ""

    Private Sub Customer_Payment_Details_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)

        Dim detailsTypeDic As New Dictionary(Of String, String)
        detailsTypeDic.Add("1", "PAYABLE")
        detailsTypeDic.Add("2", "PAID")
        detailsTypeDic.Add("3", "OUTSTANDING")

        cbPaymentType.DataSource = New BindingSource(detailsTypeDic, Nothing)
        cbPaymentType.ValueMember = "key"
        cbPaymentType.DisplayMember = "value"


        cbReportDate.DataSource = New BindingSource(fill_report_date_list_in_cb(), Nothing)
        cbReportDate.ValueMember = "key"
        cbReportDate.DisplayMember = "value"

        mtxtFrom.Text = Date.Now
        mtxtTo.Text = Date.Now


        cbCustId.DataSource = New BindingSource(fill_customer_in_cb_for_report(), Nothing)
        cbCustId.DisplayMember = "value"
        cbCustId.ValueMember = "key"
        cbCustId.AutoCompleteSource = AutoCompleteSource.ListItems
        cbCustId.AutoCompleteMode = AutoCompleteMode.Append
        cbCustId.Enabled = False

        Dim rptDoc As New CrystalReportCustomerPaymentDetails
        FromToDate = "Till Date " + Format(Date.Now, "dd-mm-yyyy")
        Dim query As String = "select * from customer_Details_with_amc_view"
        rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
        rptDoc.SetParameterValue("FromToDate", FromToDate)
        crvCustomerDetailsView.ReportSource = rptDoc
        crvCustomerDetailsView.Refresh()


    End Sub
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim service_type As Integer = cbPaymentType.SelectedItem.key
        Dim parameter As Integer = cbReportDate.SelectedItem.key
        Dim query As String = ""
        Dim temp_date As Date = Date.Now

        If service_type = 1 Then 'payable

            If parameter = 1 Then
                FromToDate = "Till Date " + Format(Date.Now, "dd-mm-yyyy")
                query = "select * from customer_Details_with_amc_view
                      where contract_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"

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

            Dim rptDoc As New CrystalReportCustomerPaymentDetails
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
            rptDoc.SetParameterValue("FromToDate", FromToDate)
            crvCustomerDetailsView.ReportSource = rptDoc
            crvCustomerDetailsView.Refresh()

        ElseIf service_type = 2 Then 'paid
            If parameter = 1 Then
                FromToDate = "FOR DATE" + Format(Date.Now, "dd-mm-yyyy")
                query = "select * from customer_details_payment_view
                      where payment_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
                MsgBox(Format(temp_date, "MM-dd-yyyy"))
            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                FromToDate = "FOR From " + Format(firstDayOfWeek, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from customer_details_payment_view
                      where payment_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and payment_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                FromToDate = "FOR From " + Format(startDateofMonth, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from customer_details_payment_view
                      where payment_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and payment_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                FromToDate = "Report Date From " + Format(startDateofyear, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from customer_details_payment_view
                      where payment_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and payment_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                FromToDate = "Report Date From " + Format(fromDate, "dd-MM-yyyy") + " To " + Format(toDate, "dd-MM-yyyy")
                query = "select * from customer_details_payment_view
                      where payment_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and payment_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from customer_details_payment_view"
            End If

            Dim rptDoc As New CrystalReportCustomerPaymentPayable
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
            rptDoc.SetParameterValue("FromToDate", FromToDate)
            crvCustomerDetailsView.ReportSource = rptDoc
            crvCustomerDetailsView.Refresh()

        ElseIf service_type = 3 Then 'outstainding
            If cbCustId.SelectedItem.key = 0 Then
                query = "select * from customer_payment_outstanding_view"
            Else
                query = "select * from customer_payment_outstanding_view where customer_id=" + cbCustId.SelectedItem.key.ToString
            End If
            Dim rptDoc As New CrystalReportCustomerPaymentOutstanding
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
                crvCustomerDetailsView.ReportSource = rptDoc
                crvCustomerDetailsView.Refresh()
            Else


            End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cbPaymentType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbPaymentType.SelectionChangeCommitted
        If cbPaymentType.SelectedItem.key = 3 Then
            cbCustId.Enabled = True
            cbReportDate.Enabled = False
            mtxtFrom.Enabled = False
            mtxtTo.Enabled = False
        Else
            cbCustId.Enabled = False
            cbReportDate.Enabled = True
            mtxtFrom.Enabled = True
            mtxtTo.Enabled = True
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
End Class