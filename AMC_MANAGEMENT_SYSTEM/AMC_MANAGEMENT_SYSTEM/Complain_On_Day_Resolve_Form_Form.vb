Imports System.Data.SqlClient
Public Class Complain_On_Day_Resolve_Form_Form
    Dim FromToDate As String = ""
    Private Sub Complain_On_Day_Resolve_Form_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)

        Dim detailsTypeDic As New Dictionary(Of String, String)
        detailsTypeDic.Add("1", "Same Day Service Resolve")
        detailsTypeDic.Add("2", "One Or more then One day")

        cbReportType.DataSource = New BindingSource(detailsTypeDic, Nothing)
        cbReportType.ValueMember = "key"
        cbReportType.DisplayMember = "value"

        cbReportDate.DataSource = New BindingSource(fill_report_date_list_in_cb(), Nothing)
        cbReportDate.ValueMember = "key"
        cbReportDate.DisplayMember = "value"

        mtxtFrom.Text = Date.Now
        mtxtTo.Text = Date.Now


    End Sub

    Public Sub complain_per_refresh(ByVal day As Integer, ByVal parameter As Integer)
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim deleteQuery As String = "delete from complain_per_tbl"
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

            If day = 1 Then 'same day
                If parameter = 1 Then 'day

                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl
                                    where comp_date = '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date = comp_date
                                    and comp_date = '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by comp_date"

                ElseIf parameter = 2 Then 'week
                    Dim firstDayOfWeek As Date = getFirstDayOfWeek()


                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl 
                                    where comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date = comp_date
                                    and comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by comp_date"


                ElseIf parameter = 3 Then 'month

                    Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)


                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl 
                                    where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date = comp_date
                                    and comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by comp_date"


                ElseIf parameter = 4 Then ' year
                    Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)

                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.0 /
                                    (select count(comp_date) from complain_tbl 
                                    where comp_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date = comp_date
                                    and comp_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by comp_date"
                    MsgBox(selectQuery)
                ElseIf parameter = 5 Then 'custom
                    Dim fromDate As Date = mtxtFrom.Text
                    Dim toDate As Date = mtxtTo.Text

                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl 
                                    where comp_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date = comp_date
                                    and comp_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                                    group by comp_date"

                Else

                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl) as per
                                    from complain_tbl
                                    where solve_date = comp_date
                                    group by comp_date"
                End If



            ElseIf day = 2 Then 'one or more then one

                If parameter = 1 Then 'day

                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl
                                    where comp_date = '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date > comp_date
                                    and comp_date = '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by comp_date"

                ElseIf parameter = 2 Then 'week
                    Dim firstDayOfWeek As Date = getFirstDayOfWeek()


                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl 
                                    where comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date > comp_date
                                    and comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by comp_date"


                ElseIf parameter = 3 Then 'month

                    Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)


                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl 
                                    where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date > comp_date
                                    and comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by comp_date"


                ElseIf parameter = 4 Then ' year
                    Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)

                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.0 /
                                    (select count(comp_date) from complain_tbl 
                                    where comp_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date > comp_date
                                    and comp_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                    group by comp_date"
                    MsgBox(selectQuery)
                ElseIf parameter = 5 Then 'custom
                    Dim fromDate As Date = mtxtFrom.Text
                    Dim toDate As Date = mtxtTo.Text

                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl 
                                    where comp_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                                    ) as per
                                    from complain_tbl
                                    where solve_date > comp_date
                                    and comp_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                                    and comp_date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                                    group by comp_date"

                Else

                    selectQuery = "select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
                                    (select count(comp_date) from complain_tbl) as per
                                    from complain_tbl
                                    where solve_date > comp_date
                                    group by comp_date"
                End If



            End If

            cmd.CommandText = selectQuery
            dr = cmd.ExecuteReader
            dt.Load(dr)

            Dim insertQuery = "INSERT INTO complain_per_tbl(comp_date,comp_count,per) values "

            For index = 0 To dt.Rows.Count - 1
                Dim comp_Date As Date = dt.Rows(index).Item(0).ToString

                insertQuery += "( '"
                insertQuery += Format(comp_Date, "MM-dd-yyyy") + "' , "
                insertQuery += dt.Rows(index).Item(1).ToString + ", "
                insertQuery += dt.Rows(index).Item(2).ToString + "  "
                insertQuery += ") , "
            Next
            insertQuery = insertQuery.Substring(0, insertQuery.Length - 2)

            MsgBox(insertQuery)
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

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim parameter As Integer = cbReportDate.SelectedItem.key
        Dim dayParameter As Integer = cbReportType.SelectedItem.key
        Dim query As String = ""
        Dim temp_date As Date = Date.Now

        complain_per_refresh(dayParameter, parameter)


        If dayParameter = 1 Then 'same day

            If parameter = 1 Then
                FromToDate = "FOR Date :" + Format(Date.Now, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where comp_date=solve_date 
                       and comp_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                FromToDate = "Report Date From " + Format(firstDayOfWeek, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where comp_date=solve_date 
                      and comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                FromToDate = "Report Date From " + Format(startDateofMonth, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where comp_date=solve_date 
                      and comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 4 Then 'year
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                FromToDate = "Report Date From " + Format(startDateofyear, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where comp_date=solve_date 
                      and comp_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                FromToDate = "Report Date From " + Format(fromDate, "dd-MM-yyyy") + " To " + Format(toDate, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where comp_date=solve_date 
                      and comp_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from complain_per_details_view where comp_date=solve_date "
            End If

            Dim rptDoc As New CrystalReportComplainOnDayResolve
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
            rptDoc.SetParameterValue("FromToDate", FromToDate)
            crvCustomerDetailsView.ReportSource = rptDoc
            crvCustomerDetailsView.Refresh()



        ElseIf dayParameter = 2 Then 'one or more then one day

            If parameter = 1 Then
                FromToDate = "FOR Date :" + Format(Date.Now, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where solve_date > comp_date
                       and comp_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                FromToDate = "Report Date From " + Format(firstDayOfWeek, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where solve_date > comp_date
                      and comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 3 Then

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                FromToDate = "Report Date From " + Format(startDateofMonth, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where solve_date > comp_date
                      and comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

            ElseIf parameter = 4 Then 'year
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                FromToDate = "Report Date From " + Format(startDateofyear, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where solve_date > comp_date
                      and comp_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                FromToDate = "Report Date From " + Format(fromDate, "dd-MM-yyyy") + " To " + Format(toDate, "dd-MM-yyyy")
                query = "select * from complain_per_details_view
                      where solve_date > comp_date
                      and comp_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and comp_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
            Else
                query = "select * from complain_per_details_view 
                        where solve_date > comp_date "
            End If

            Dim rptDoc As New CrystalReportComplainOnDayResolve
            rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
            rptDoc.SetParameterValue("FromToDate", FromToDate)
            crvCustomerDetailsView.ReportSource = rptDoc
            crvCustomerDetailsView.Refresh()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class