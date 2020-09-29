Imports System.Data.SqlClient

Public Class Report_City_Wise_Amc_Details_Form
    Dim FromToDate As String = ""

    Private Sub Report_City_Wise_Amc_Details_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbReportDate.DataSource = New BindingSource(fill_report_date_list_in_cb(), Nothing)
        cbReportDate.ValueMember = "key"
        cbReportDate.DisplayMember = "value"

        mtxtFrom.Text = Date.Now
        mtxtTo.Text = Date.Now

    End Sub

    Public Sub amc_city_per_refresh(ByVal parameter As Integer)
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim deleteQuery As String = "delete from amc_city_per_tbl"
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

                selectQuery = "select count(amc_id) amc_tot,city_id,
                                count(amc_id)*100. / (select count(amc_id) from contract_tbl
                                where contract_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                ) per
                                from contract_tbl con,customer_tbl cust
                                where cust.customer_id=con.cust_id
                                and contract_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                group by city_id
                                order by amc_tot desc"

            ElseIf parameter = 2 Then 'week
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()

                selectQuery = "select count(amc_id) amc_tot,city_id,
                                count(amc_id)*100. / (select count(amc_id) from contract_tbl
                                where contract_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                                    and contract_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                ) per
                                from contract_tbl con,customer_tbl cust
                                where cust.customer_id=con.cust_id
                                and contract_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                                and contract_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                group by city_id
                                order by amc_tot desc"



            ElseIf parameter = 3 Then 'month

                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)

                selectQuery = "select count(amc_id) amc_tot,city_id,
                                count(amc_id)*100. / (select count(amc_id) from contract_tbl
                                where contract_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                                    and contract_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                ) per
                                from contract_tbl con,customer_tbl cust
                                where cust.customer_id=con.cust_id
                                and contract_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                                and contract_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                group by city_id
                                order by amc_tot desc"
            ElseIf parameter = 4 Then ' year
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)

                selectQuery = "select count(amc_id) amc_tot,city_id,
                                count(amc_id)*100. / (select count(amc_id) from contract_tbl
                                where contract_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                                    and contract_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                ) per
                                from contract_tbl con,customer_tbl cust
                                where cust.customer_id=con.cust_id
                                and contract_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                                and contract_date <= '" + Format(nowDate, "MM-dd-yyyy") + "'
                                group by city_id
                                order by amc_tot desc"



            ElseIf parameter = 5 Then 'custom
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text

                selectQuery = "select count(amc_id) amc_tot,city_id,
                                count(amc_id)*100. / (select count(amc_id) from contract_tbl
                                where contract_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                                    and contract_date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                                ) per
                                from contract_tbl con,customer_tbl cust
                                where cust.customer_id=con.cust_id
                                and contract_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                                and contract_date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                                group by city_id
                                order by amc_tot desc"

            Else

                selectQuery = "select count(amc_id) amc_tot,city_id,
                                count(amc_id)*100. / (select count(amc_id) from contract_tbl
                                ) per
                                from contract_tbl con,customer_tbl cust
                                where cust.customer_id=con.cust_id
                                group by city_id
                                order by amc_tot desc"
            End If
            cmd.CommandText = selectQuery
            dr = cmd.ExecuteReader
            dt.Load(dr)

            Dim insertQuery = "INSERT INTO amc_city_per_tbl(amc_tot,city_id,per) values "

            For index = 0 To dt.Rows.Count - 1
                insertQuery += "( "
                insertQuery += dt.Rows(index).Item(0).ToString + ","
                insertQuery += dt.Rows(index).Item(1).ToString + ", "
                insertQuery += dt.Rows(index).Item(2).ToString + "  "
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim parameter As Integer = cbReportDate.SelectedItem.key
        Dim query As String = ""
        Dim temp_date As Date = Date.Now
        amc_city_per_refresh(parameter)

        If parameter = 1 Then
            FromToDate = "For Date " + Format(Date.Now, "dd-mm-yyyy")
            query = "select * from amc_city_per_details_view
                      where contract_date = '" + Format(temp_date, "MM-dd-yyyy") + "'"
        ElseIf parameter = 2 Then
            Dim firstDayOfWeek As Date = getFirstDayOfWeek()
            FromToDate = "Report Date From " + Format(firstDayOfWeek, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
            query = "select * from amc_city_per_details_view
                      where contract_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
        ElseIf parameter = 3 Then

            Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
            FromToDate = "Report Date From " + Format(startDateofMonth, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
            query = "select * from amc_city_per_details_view
                      where contract_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"

        ElseIf parameter = 4 Then
            Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
            FromToDate = "Report Date From " + Format(startDateofyear, "dd-MM-yyyy") + " To " + Format(temp_date, "dd-MM-yyyy")
            query = "select * from amc_city_per_details_view
                      where contract_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(temp_date, "MM-dd-yyyy") + "'"
        ElseIf parameter = 5 Then
            Dim fromDate As Date = mtxtFrom.Text
            Dim toDate As Date = mtxtTo.Text
            FromToDate = "Report Date From " + Format(fromDate, "dd-MM-yyyy") + " To " + Format(toDate, "dd-MM-yyyy")
            query = "select * from amc_city_per_details_view
                      where contract_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                      and contract_date <= '" + Format(toDate, "MM-dd-yyyy") + "'"
        Else
            query = "select * from amc_city_per_details_view"
        End If
        Dim rptDoc As New CrystalReportCityWiseAMCSoldDetails
        rptDoc.SetDataSource(Report_Module.get_dataset_for_crystal_report(query).Tables(0))
        rptDoc.SetParameterValue("FromToDate", FromToDate)
        crvCustomerDetailsView.ReportSource = rptDoc
        crvCustomerDetailsView.Refresh()
    End Sub
End Class