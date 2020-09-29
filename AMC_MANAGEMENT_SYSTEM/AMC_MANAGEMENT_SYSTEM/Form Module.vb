Imports System.Data.SqlClient
Module Form_Module
    Public service_resolve_id As Integer
    Public service_resolve_flag As Integer

    Public service_updation_id As Integer
    Public service_updation_flag As Integer

    Dim panel As New Panel

    Public Sub outstanding_payment_refresh()
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim deleteQuery As String = "delete from outstanding_payment_tbl"
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
            Dim selectQuery As String = "select cust_id,sum(sales_amt) payable_amt from contract_tbl
                                        group by cust_id"
            cmd.CommandText = selectQuery
            dr = cmd.ExecuteReader

            dt.Load(dr)
            Dim insertQuery = "INSERT INTO outstanding_payment_tbl(customer_id,payable_amt,receive_amt,outstanding_amt) values "
            For index = 0 To dt.Rows.Count - 1
                insertQuery += "( "
                insertQuery += dt.Rows(index).Item(0).ToString + ","
                insertQuery += dt.Rows(index).Item(1).ToString + ", "
                insertQuery += "0 ,"
                insertQuery += dt.Rows(index).Item(1).ToString + " "
                insertQuery += ") , "
            Next
            insertQuery = insertQuery.Substring(0, insertQuery.Length - 2)

            cmd.Dispose()
            con.Close()
            con.Dispose()

            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = insertQuery
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            con.Dispose()


            Dim dt1 As New DataTable
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            Dim dr1 As SqlDataReader
            con.Open()
            Dim selectQuery1 As String = "select customer_id,sum(pay_amt) receive_amt from payment_tbl
                                            group by customer_id"
            cmd.CommandText = selectQuery1

            dr1 = cmd.ExecuteReader
            dt1.Load(dr1)
            'Dim updateList As New List(Of String)
            Dim updateQuery = ""
            For index = 0 To dt1.Rows.Count - 1
                updateQuery += "update outstanding_payment_tbl"
                updateQuery += " set "
                updateQuery += "receive_amt=" + dt1.Rows(index).Item(1).ToString + " , "
                updateQuery += "outstanding_amt = outstanding_amt - " + dt1.Rows(index).Item(1).ToString + " "
                updateQuery += "where customer_id =" + dt1.Rows(index).Item(0).ToString + " ; "
                'updateList.Add(updateQuery)
            Next
            cmd.Dispose()
            con.Close()
            con.Dispose()


            'update query fire
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = updateQuery
            If cmd.ExecuteNonQuery Then

            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub

    Public Function fill_Service_In_gridview(ByVal contract_id As Integer, ByVal service_status As String) As DataTable
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim query As String = ""
            If (service_status = "pending") Then
                query = "select service_id,convert(varchar,service_Date,105),service_status,solve_date,work_details 
                                    from service_tbl where service_status like 'pending' and contract_id=" + contract_id.ToString
            Else
                query = "select service_id,convert(varchar,service_Date,105),service_status,solve_date,work_details 
                                    from service_tbl where contract_id=" + contract_id.ToString
            End If

            cmd.CommandText = query
            dr = cmd.ExecuteReader
            dt.Load(dr)
            If con.State = ConnectionState.Open Then
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function
    Public Function fill_customer_in_cb() As Dictionary(Of String, String)
        Dim customer As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT customer_id,customer_name from customer_tbl where status = '" + get_status(1) + "'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            While dr.Read
                customer(dr("customer_id").ToString) = dr("customer_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return customer
    End Function

    Public Function fill_emp_in_cb() As Dictionary(Of String, String)
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

    Public Function fill_Customer_In_gridview() As DataTable
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim dt As New DataTable

        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim query As String = "SELECT * from customer_tbl"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            dt.Load(dr)
            If con.State = ConnectionState.Open Then
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt


    End Function

    Public Function fill_Contract_In_gridview() As DataTable
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim dt As New DataTable

        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim query As String = "select  co.contract_date,co.contract_id,co.cust_id,c.customer_name,co.machine_name,
                                   co.contract_period_from,co.contract_period_to,
                                   a.amc_name,a.amc_type,a.price,co.status
                                   from contract_tbl co,customer_tbl c,amc_mstr a
                                   where co.cust_id=c.customer_id and co.amc_id=a.amc_id;"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            dt.Load(dr)
            If con.State = ConnectionState.Open Then
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt

    End Function

    Public Function get_emp_name(ByVal emp_id As String) As String
        Dim emp_name As String = ""
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()
            Dim query As String = "SELECT emp_name from emp_mstr where emp_id = " + emp_id
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            If dr.Read Then
                emp_name = dr("emp_name")
            End If

            If con.State = ConnectionState.Open Then
                dr.Close()
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return emp_name
    End Function

    Public Function get_cust_name(ByVal cust_id As String) As String
        Dim cust_name As String = ""
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()
            Dim query As String = "SELECT customer_name from customer_tbl where customer_id = " + cust_id
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            If dr.Read Then
                cust_name = dr("customer_name")
            End If

            If con.State = ConnectionState.Open Then
                dr.Close()
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return cust_name
    End Function
    Public Function get_amc_name(ByVal amc_id As String) As String
        Dim amc_name As String = ""
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()
            Dim query As String = "SELECT amc_name from amc_mstr where amc_id = " + amc_id
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            If dr.Read Then
                amc_name = dr("amc_name")
            End If

            If con.State = ConnectionState.Open Then
                dr.Close()
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return amc_name
    End Function

    Public Function get_pincodename(ByVal pincode_id As String) As String
        Dim pincode_name As String = ""
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()
            Dim query As String = "SELECT pincode_name from pincode_mstr where pincode_id = " + pincode_id
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            If dr.Read Then
                pincode_name = dr("pincode_name")
            End If

            If con.State = ConnectionState.Open Then
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return pincode_name
    End Function
    Public Function get_cityname(ByVal city_id As String) As String
        Dim city_name As String = ""
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()
            Dim query As String = "SELECT city_name from city_mstr where city_id = " + city_id
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            If dr.Read Then
                city_name = dr("city_name")
            End If

            If con.State = ConnectionState.Open Then
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return city_name
    End Function
    Public Function get_maxId(ByVal table_name As String, ByVal col_name As String) As String
        Dim max_id As Object = 1
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT MAX(" + col_name + ") FROM " + table_name
            cmd.CommandText = query
            max_id = cmd.ExecuteScalar()

            If IsDBNull(max_id) Then
                max_id = 1
            End If
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return max_id.ToString
    End Function
    Public Function get_status(ByVal value As Integer) As String
        Dim status As String = ""
        If value = 1 Then
            status = "active"
        ElseIf value = 0 Then
            status = "deactive"
        End If
        Return status
    End Function

    Public Function fill_active_city() As Dictionary(Of String, String)
        Dim city As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT city_id,city_name from city_mstr where status = '" + get_status(1) + "' and city_id in (select city_Id from pincode_mstr)"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            While dr.Read
                city(dr("city_id").ToString) = dr("city_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return city
    End Function

    Public Function fill_category() As Dictionary(Of String, String)
        Dim city As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT category_id,category_name from category_mstr where status = '" + get_status(1) + "'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            While dr.Read
                city(dr("category_id").ToString) = dr("category_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return city
    End Function
    Public Function fill_city() As Dictionary(Of String, String)
        Dim city As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT city_id,city_name from city_mstr where status = '" + get_status(1) + "'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            While dr.Read
                city(dr("city_id").ToString) = dr("city_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return city
    End Function
    Public Function fill_pincode(ByVal city_id As Integer) As Dictionary(Of String, String)
        Dim pincode As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT pincode_id,pincode_name from pincode_mstr where city_id = '" + city_id.ToString + "'and status = '" + get_status(1) + "'"

            cmd.CommandText = query
            dr = cmd.ExecuteReader
            While dr.Read
                pincode(dr("pincode_id").ToString) = dr("pincode_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return pincode
    End Function


    Public Function fill_status() As List(Of String)
        Dim status As New List(Of String)
        status.Add("active")
        status.Add("deactive")
        Return status

    End Function

    Public Function fill_report_service_Type_in_cb() As Dictionary(Of String, String)
        Dim data As New Dictionary(Of String, String)
        Dim today_Date As Date = Date.Now
        data.Add("0", "ALL")
        data.Add("1", "Service")
        data.Add("2", "Complain")
        Return data
    End Function

    Public Function fill_report_date_list_in_cb() As Dictionary(Of String, String)
        Dim data As New Dictionary(Of String, String)
        Dim today_Date As Date = Date.Now
        data.Add("1", "Today - " + Format(today_Date, "dd-MM-yyyy"))
        data.Add("2", "Week - " + Format(today_Date, "dd-MM-yyyy"))
        data.Add("3", "Month - " + Format(today_Date, "dd-MM-yyyy"))
        data.Add("4", "Year - " + Format(today_Date, "dd-MM-yyyy"))
        data.Add("5", "Custom")

        Return data
    End Function


    Public Function fill_Service_status() As List(Of String)
        Dim status As New List(Of String)
        status.Add("pending")
        status.Add("deactive")
        Return status

    End Function

    Public Function fill_AMC_type() As List(Of String)
        Dim status As New List(Of String)
        status.Add("PAID")
        status.Add("FREE")
        Return status
    End Function


    Public Sub apply_theme(ByRef form As System.Windows.Forms.Form)
        With form
            .BackColor = Color.DarkSlateGray
            .FormBorderStyle = FormBorderStyle.None
            .Padding = New Padding(10, 10, 10, 10)

        End With
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 1150
        y = Screen.PrimaryScreen.WorkingArea.Height - 700
        form.Location = New Point(x, y)
        form.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Public Function fill_customer_in_cb_for_report() As Dictionary(Of String, String)
        Dim customer As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT customer_id,customer_name from customer_tbl where status = '" + get_status(1) + "'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            customer.Add("0", "ALL")
            While dr.Read
                customer(dr("customer_id").ToString) = dr("customer_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return customer
    End Function

End Module
