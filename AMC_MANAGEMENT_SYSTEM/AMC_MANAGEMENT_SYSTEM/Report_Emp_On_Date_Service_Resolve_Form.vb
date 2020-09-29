Imports System.Data.SqlClient
Public Class Report_Emp_On_Date_Service_Resolve_Form
    Dim FromToDate As String = ""

    Private Sub Report_Emp_On_Date_Service_Resolve_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbReportDate.DataSource = New BindingSource(fill_report_date_list_in_cb(), Nothing)
        cbReportDate.ValueMember = "key"
        cbReportDate.DisplayMember = "value"

        mtxtFrom.Text = Date.Now
        mtxtTo.Text = Date.Now

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        Dim parameter As Integer = cbReportDate.SelectedItem.key
        Dim query As String = ""
        Dim temp_date As Date = Date.Now
        employee_service_per_refresh(parameter)


        If parameter = 1 Then

            FromToDate = "For Date " + Format(Date.Now, "dd-mm-yyyy")
            query = "select * from service_emp_per_view
                      where entry_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
        ElseIf parameter = 2 Then
            Dim firstDayOfWeek As Date = getFirstDayOfWeek()
            FromToDate = "Report Date From " + Format(firstDayOfWeek, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
            query = "select * from service_emp_per_view
                      where entry_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
        ElseIf parameter = 3 Then

            Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
            FromToDate = "Report Date From " + Format(startDateofMonth, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
            query = "select * from service_emp_per_view
                      where entry_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

        ElseIf parameter = 4 Then
            Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
            FromToDate = "Report Date From " + Format(startDateofyear, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
            query = "select * from service_emp_per_view
                      where entry_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
        ElseIf parameter = 5 Then
            Dim fromDate As Date = mtxtFrom.Text
            Dim toDate As Date = mtxtTo.Text
            FromToDate = "Report Date From " + Format(fromDate, "dd-MM-yyyy") + " To " + Format(toDate, "dd-MM-yyyy")
            query = "select * from service_emp_per_view
                      where entry_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and entry_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
        Else
            query = "select * from service_emp_per_view"
        End If

        Dim rptDoc As New CrystalReportEmployeeServiceOnDayResolve
        rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
        rptDoc.SetParameterValue("FromToDate", FromToDate)
        crvCustomerDetailsView.ReportSource = rptDoc
        crvCustomerDetailsView.Refresh()

    End Sub

    Public Sub employee_service_per_refresh(ByVal parameter As Integer)
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim deleteQuery As String = "delete from service_emp_per_tbl"
            cmd.CommandText = deleteQuery
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            con.Dispose()

            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            Dim dr As SqlDataReader
            con.Open()

            Dim selectQuery As String = ""
            Dim nowDate As Date = Date.Now
            If parameter = 1 Then 'day

                selectQuery = "select allocate_to,count(service_id),count(service_id) *100.00 /
                                 (select count(service_id) from service_tbl where
                                    DATEADD(day,1,solve_date) <= service_date
                                    and entry_date = '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    )
                                    from service_tbl
                                    where
                                    solve_date <= service_date
                                    and entry_date = '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by allocate_to"

            ElseIf parameter = 2 Then 'week
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                selectQuery = "select allocate_to,count(service_id),count(service_id) *100.00 /
                                 (select count(service_id) from service_tbl where
                                    DATEADD(day,1,solve_date) <= service_date
                                    and entry_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                                    and entry_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    )
                                    from service_tbl
                                    where
                                    solve_date <= service_date
                                            and entry_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                                            and entry_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by allocate_to"


            ElseIf parameter = 3 Then 'month

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                selectQuery = "select allocate_to,count(service_id),count(service_id) *100.00 /
                                 (select count(service_id) from service_tbl where
                                    DATEADD(day,1,solve_date) <= service_date
                                    and entry_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                                    and entry_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
)
                                    from service_tbl
                                    where
                                    solve_date <= service_date
                                            and entry_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                                            and entry_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by allocate_to"

            ElseIf parameter = 4 Then ' year

                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                selectQuery = "select allocate_to,count(service_id),count(service_id) *100.00 /
                                 (select count(service_id) from service_tbl where
                                    DATEADD(day,1,solve_date) <= service_date
                                    and entry_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                                    and entry_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    )
                                    from service_tbl
                                    where
                                    solve_date <= service_date
                                            and entry_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                                            and entry_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by allocate_to"
            ElseIf parameter = 5 Then 'custom
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                selectQuery = "select allocate_to,count(service_id),count(service_id) *100.00 /
                                 (select count(service_id) from service_tbl where
                                    DATEADD(day,1,solve_date) <= service_date
                                    and entry_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                                    and entry_date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                                    )
                                    from service_tbl
                                    where
                                    solve_date <= service_date
                                            and entry_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                                            and entry_date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                                    group by allocate_to"
            Else
                selectQuery = "select allocate_to,count(service_id),count(service_id) *100.00 /
                                 (select count(service_id) from service_tbl where
                                    DATEADD(day,1,solve_date) <= service_date)
                                    from service_tbl
                                    where
                                    solve_date <= service_date
                                    group by allocate_to"
            End If


            cmd.CommandText = selectQuery
            dr = cmd.ExecuteReader
            dt.Load(dr)

            Dim insertQuery = "INSERT INTO service_emp_per_tbl(emp_id,total_service,per) values "

            For index = 0 To dt.Rows.Count - 1
                insertQuery += "( "
                insertQuery += dt.Rows(index).Item(0).ToString + ","
                insertQuery += dt.Rows(index).Item(1).ToString + ", "
                insertQuery += dt.Rows(index).Item(2).ToString + " "
                insertQuery += ") , "
            Next
            insertQuery = insertQuery.Substring(0, insertQuery.Length - 2)
            cmd.Dispose()
            con.Close()
            con.Dispose()

            If dt.Rows.Count - 1 >= 0 Then
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                cmd.CommandText = insertQuery
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                con.Dispose()
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
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