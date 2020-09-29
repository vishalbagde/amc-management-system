Imports System.Data.SqlClient
Public Class Report_Complain_Details_Form
    Dim FromToDate As String = ""
    Private Sub Report_Complain_Details_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)

        Dim detailsTypeDic As New Dictionary(Of String, String)
        detailsTypeDic.Add("1", "Complain Details")
        detailsTypeDic.Add("2", "EMP Wise Allocate Details")

        cbReportType.DataSource = New BindingSource(detailsTypeDic, Nothing)
        cbReportType.ValueMember = "key"
        cbReportType.DisplayMember = "value"

        cbReportDate.DataSource = New BindingSource(fill_report_date_list_in_cb(), Nothing)
        cbReportDate.ValueMember = "key"
        cbReportDate.DisplayMember = "value"

        mtxtFrom.Text = Date.Now
        mtxtTo.Text = Date.Now

        cbEmpId.DataSource = New BindingSource(fill_emp_in_cb_for_report, Nothing)
        cbEmpId.ValueMember = "key"
        cbEmpId.DisplayMember = "value"
        cbEmpId.Enabled = False

    End Sub

    Public Function fill_emp_in_cb_for_report() As Dictionary(Of String, String)
        Dim emp As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT emp_id,emp_name from emp_mstr where status = '" + get_status(1) + "'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            emp("0") = "ALL"
            While dr.Read
                emp(dr("emp_id").ToString) = dr("emp_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return emp
    End Function

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim service_type As Integer = cbReportType.SelectedItem.key
        Dim parameter As Integer = cbReportDate.SelectedItem.key
        Dim query As String = ""
        Dim temp_date As Date = Date.Now

        If service_type = 1 Then 'complain Details

            If parameter = 1 Then
                FromToDate = "FOR Date :" + Format(Date.Now, "dd-MM-yyyy")
                query = "select * from complain_Details_view
                      where comp_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                FromToDate = "Report Date From " + Format(firstDayOfWeek, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from complain_Details_view
                      where comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                FromToDate = "Report Date From " + Format(startDateofMonth, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from complain_Details_view
                      where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                FromToDate = "Report Date From " + Format(startDateofyear, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from complain_Details_view
                      where comp_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                FromToDate = "Report Date From " + Format(fromDate, "dd-MM-yyyy") + " To " + Format(toDate, "dd-MM-yyyy")
                query = "select * from complain_Details_view
                      where comp_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from complain_Details_view"
            End If

            Dim rptDoc As New CrystalReportComplainDetails
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
            rptDoc.SetParameterValue("FromToDate", FromToDate)
            crvCustomerDetailsView.ReportSource = rptDoc
            crvCustomerDetailsView.Refresh()

        ElseIf service_type = 2 Then 'emp wise

            If parameter = 1 Then
                FromToDate = "Till Date " + Format(Date.Now, "dd-mm-yyyy")
                If cbEmpId.SelectedItem.key = 0 Then
                    query = "select * from complain_Details_emp_wise_view
                      where comp_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"

                Else
                    query = "Select * from complain_Details_emp_wise_view
                      where comp_date = '" + Format(temp_date, "MM-dd-yyyy") + "'
                       and allocate_to = " + cbEmpId.SelectedItem.key.ToString
                End If


            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                FromToDate = "Report Date From " + Format(firstDayOfWeek, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                If cbEmpId.SelectedItem.key = 0 Then
                    query = "select * from complain_Details_emp_wise_view
                      where comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

                Else
                    query = "Select * from complain_Details_emp_wise_view
                      where comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'
                       and allocate_to= " + cbEmpId.SelectedItem.key.ToString + ""
                End If

            ElseIf parameter = 3 Then

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                FromToDate = "Report Date From " + Format(startDateofMonth, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")

                If cbEmpId.SelectedItem.key = 0 Then
                    query = "select * from complain_Details_emp_wise_view
                      where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

                Else
                    query = "Select * from complain_Details_emp_wise_view
                      where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'
                       and allocate_to = " + cbEmpId.SelectedItem.key.ToString + ""
                End If



            ElseIf parameter = 4 Then 'year
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                FromToDate = "Report Date From " + Format(startDateofyear, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")

                If cbEmpId.SelectedItem.key = 0 Then
                    query = "select * from complain_Details_emp_wise_view
                      where comp_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
                Else
                    query = "Select * from complain_Details_emp_wise_view
                      where comp_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'
                       and allocate_to = " + cbEmpId.SelectedItem.key.ToString + ""
                End If


            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                FromToDate = "Report Date From " + Format(fromDate, "dd-MM-yyyy") + " To " + Format(toDate, "dd-MM-yyyy")

                If cbEmpId.SelectedItem.key = 0 Then
                    query = "select * from complain_Details_emp_wise_view
                      where comp_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"

                Else
                    query = "Select * from complain_Details_emp_wise_view
                      where comp_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                       and allocate_to = " + cbEmpId.SelectedItem.key.ToString + ""
                End If


            Else
                query = "select * from complain_Details_emp_wise_view"
            End If

            Dim rptDoc As New CrystalReportComplainDetailsEmpWise
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
            rptDoc.SetParameterValue("FromToDate", FromToDate)
            crvCustomerDetailsView.ReportSource = rptDoc
            crvCustomerDetailsView.Refresh()
        End If
    End Sub
    Private Sub cbReportType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbReportType.SelectionChangeCommitted
        If cbReportType.SelectedItem.key = 2 Then
            cbEmpId.Enabled = True
        Else
            cbEmpId.Enabled = False
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