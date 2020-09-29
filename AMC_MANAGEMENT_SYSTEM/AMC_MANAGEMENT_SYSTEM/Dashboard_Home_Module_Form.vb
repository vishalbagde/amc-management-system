Imports System.Data.SqlClient
Public Class Dashboard_Home_Module_Form
    Dim today_date As Date = Date.Now
    Dim firstDayOfWeek As Date = getFirstDayOfWeek()
    Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
    Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)

    Dim DT_serviceList As New DataTable
    Dim DT_complainPendingList As New DataTable
    Dim DT_complainAllocateList As New DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        apply_theme(Me)
    End Sub

    Public Function fill_serviceList_in_dgv(ByVal query As String) As DataTable
        Dim dt As New DataTable
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()

            cmd.CommandText = query
            dr = cmd.ExecuteReader
            dt.Load(dr)
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function
    Private Sub Dashboard_Home_Module_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DT_serviceList.Columns.Add("SERVICE_DATE")
        DT_serviceList.Columns.Add("CUSTOMER_NAME")
        DT_serviceList.Columns.Add("AREA_NAME")
        DT_serviceList.Columns.Add("SERVICE_STATUS")
        DT_serviceList.Columns.Add("SERVICE_ID")


        Dim query As String = "select ser.service_date,cust.customer_name,cust.area_name,
                                    ser.service_status,
                                    ser.service_id
                                    from service_tbl ser,contract_tbl con,customer_tbl cust
                                    where
                                    ser.contract_id=con.contract_id
                                    and con.cust_id=cust.customer_id
                                    and service_status='pending'
                                    or service_status = 'allocated'
                                    order by service_date"


        DT_serviceList = fill_serviceList_in_dgv(query)
        dgvServiceDetails.DataSource = DT_serviceList
        dgvServiceDetails.AutoGenerateColumns = True
        dgvServiceDetails.AllowUserToAddRows = False
        'dgvServiceDetails.EnableHeadersVisualStyles = False
        dgvServiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvServiceDetails.RowHeadersVisible = False
        dgvServiceDetails.Columns("SERVICE_ID").Visible = False

        'For i = 0 To dgvServiceDetails.Rows.Count - 1
        '    If dgvServiceDetails.Rows(i).Cells(0).Value = Date.Now Then
        '        dgvServiceDetails.Rows(i).DefaultCellStyle.ForeColor = Color.Green
        '    ElseIf dgvServiceDetails.Rows(i).Cells(0).Value > Date.Now Then
        '        dgvServiceDetails.Rows(i).DefaultCellStyle.ForeColor = Color.Orange
        '    ElseIf dgvServiceDetails.Rows(i).Cells(0).Value < Date.Now Then
        '        dgvServiceDetails.Rows(i).DefaultCellStyle.ForeColor = Color.Red
        '    End If
        'Next

        Dim serviceTypeList As New Dictionary(Of String, String)
        serviceTypeList.Add("0", "ALL")
        serviceTypeList.Add("1", "pending")
        serviceTypeList.Add("2", "allocated")
        cbServiceListType.DataSource = New BindingSource(serviceTypeList, Nothing)
        cbServiceListType.ValueMember = "key"
        cbServiceListType.DisplayMember = "value"

        Dim serviceDateList As New Dictionary(Of String, String)
        serviceDateList.Add("1", "TODAY " + Format(Date.Now, "dd-MM-yyyy"))
        serviceDateList.Add("2", "NEXT WEEK " + Format(Date.Now, "dd-MM-yyyy"))
        serviceDateList.Add("3", "NEXT MONTH " + Format(Date.Now, "dd-MM-yyyy"))
        cbServiceListDate.DataSource = New BindingSource(serviceDateList, Nothing)
        cbServiceListDate.ValueMember = "key"
        cbServiceListDate.DisplayMember = "value"




        'complain list operation
        Dim complainTypeList As New Dictionary(Of String, String)
        complainTypeList.Add("0", "ALL")
        complainTypeList.Add("1", "pending")
        complainTypeList.Add("2", "allocated")
        cbComplainType.DataSource = New BindingSource(complainTypeList, Nothing)
        cbComplainType.ValueMember = "key"
        cbComplainType.DisplayMember = "value"


        cbEmpId.DataSource = New BindingSource(fill_emp_in_cb, Nothing)
        cbEmpId.ValueMember = "key"
        cbEmpId.DisplayMember = "value"
        cbEmpId.Enabled = False


        DT_complainAllocateList.Columns.Add("COMPLAIN_DATE")
        DT_complainAllocateList.Columns.Add("CUSTOMER_NAME")
        DT_complainAllocateList.Columns.Add("COMPLAIN_INFO")
        DT_complainAllocateList.Columns.Add("COMPLAIN_STATUS")
        DT_complainAllocateList.Columns.Add("ALLOCATED_TO")
        DT_complainAllocateList.Columns.Add("COMPLAIN_ID")

        DT_complainPendingList.Columns.Add("COMPLAIN_DATE")
        DT_complainPendingList.Columns.Add("CUSTOMER_NAME")
        DT_complainPendingList.Columns.Add("COMPLAIN_INFO")
        DT_complainPendingList.Columns.Add("COMPLAIN_STATUS")
        DT_complainPendingList.Columns.Add("COMPLAIN_ID")

        query = "select comp.comp_date,
            cust.customer_name,comp.comp_info,
            comp.comp_status,
            comp.complain_id
            from complain_tbl comp,customer_tbl cust
            where
            (comp_status = 'pending' or comp_status = 'allocated')    
            and comp.customer_id=cust.customer_id"


        DT_complainPendingList = fill_serviceList_in_dgv(query)
        dgvComplainDetails.DataSource = DT_complainPendingList
        dgvComplainDetails.AutoGenerateColumns = True
        dgvComplainDetails.AllowUserToAddRows = False
        'dgvComplainDetails.EnableHeadersVisualStyles = False
        dgvComplainDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvComplainDetails.RowHeadersVisible = False
        dgvComplainDetails.Columns("COMPLAIN_ID").Visible = False




        'summary and today details
        Dim compStatus As New Dictionary(Of String, String)
        compStatus.Add("0", "All")
        compStatus.Add("1", "pending")
        compStatus.Add("2", "allocated")
        compStatus.Add("3", "resolved")

        cbCompType.DataSource = New BindingSource(compStatus, Nothing)
        cbCompType.ValueMember = "key"
        cbCompType.DisplayMember = "value"


        Dim selectToday As String = "select coalesce(count(service_id),0) from service_tbl
                    where solve_date = '" + Format(today_date, "MM-dd-yyyy") + "'"

        lblTotSer.Text = getTotalValue(selectToday)

        selectToday = "select coalesce(count(contract_id),0) from contract_tbl
                      where contract_date = '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblTotAmcSale.Text = getTotalValue(selectToday)

        selectToday = "select coalesce(count(complain_id),0) from complain_tbl
                      where solve_date = '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblTotComplain.Text = getTotalValue(selectToday)

        Dim queryToday As String
        Dim queryWeek As String
        Dim queryMonth As String
        Dim queryYear As String

        'summary total sale
        'today
        lblserST.Text = "TODAY   ₹ "
        queryToday = "select coalesce(sum(amount_charge),0.0) from service_tbl
                        where solve_date = '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblserST.Text += getTotalValue(queryToday) + "            " + lblTotSer.Text

        'week
        lblSerSW.Text = "WEEK     ₹ "
        queryWeek = "select coalesce(sum(amount_charge),0.0) from service_tbl
                        where solve_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                        and solve_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblSerSW.Text += getTotalValue(queryWeek) + "            "

        queryWeek = "select coalesce(count(service_id),0) from service_tbl
                        where solve_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                        and solve_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblSerSW.Text += getTotalValue(queryWeek)

        'month
        lblSerSM.Text = "MONTH   ₹ "
        queryMonth = "select coalesce(sum(amount_charge),0.0) from service_tbl
                        where solve_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and solve_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblSerSM.Text += getTotalValue(queryMonth) + "          "

        queryMonth = "select coalesce(count(service_id),0) from service_tbl
                        where solve_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and solve_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblSerSM.Text += getTotalValue(queryMonth)


        'year
        lblSerSY.Text = "YEAR     ₹ "
        queryYear = "select coalesce(sum(amount_charge),0.0) from service_tbl
                        where solve_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                        and solve_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblSerSY.Text += getTotalValue(queryYear) + "          "

        queryYear = "select coalesce(count(service_id),0) from service_tbl
                        where solve_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                        and solve_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblSerSY.Text += getTotalValue(queryYear)


        'summary total AMC
        'today
        lblAmcST.Text = "TODAY   ₹ "
        queryToday = "select coalesce(sum(sales_amt),0.0) from contract_tbl
                        where contract_date = '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblAmcST.Text += getTotalValue(queryToday) + "            " + lblTotAmcSale.Text

        'week
        lblAmcSW.Text = "WEEK     ₹ "
        queryWeek = "select coalesce(sum(sales_amt),0.0) from contract_tbl
                        where contract_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                        and contract_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblAmcSW.Text += getTotalValue(queryWeek) + "   "

        queryWeek = "select coalesce(count(contract_id),0) from contract_tbl
                        where contract_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                        and contract_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblAmcSW.Text += getTotalValue(queryWeek)

        'month
        lblAmcSM.Text = "MONTH   ₹ "
        queryMonth = "select coalesce(sum(sales_amt),0.0) from contract_tbl
                        where contract_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and contract_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblAmcSM.Text += getTotalValue(queryMonth) + "   "

        queryMonth = "select coalesce(count(contract_id),0) from contract_tbl
                        where contract_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and contract_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblAmcSM.Text += getTotalValue(queryMonth)

        'year
        lblAmcSY.Text = "YEAR   ₹ "
        queryYear = "select coalesce(sum(sales_amt),0.0) from contract_tbl
                        where contract_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and contract_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblAmcSY.Text += getTotalValue(queryYear) + "     "

        queryYear = "select coalesce(count(contract_id),0) from contract_tbl
                        where contract_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and contract_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblAmcSY.Text += getTotalValue(queryYear)


        'summary total complain
        'today
        lblComST.Text = "TODAY  = "

        lblComST.Text += lblTotComplain.Text

        'week
        lblComSW.Text = "WEEK   = "

        queryWeek = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblComSW.Text += getTotalValue(queryWeek)

        'month
        lblComSM.Text = "MONTH   = "

        queryMonth = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblComSM.Text += getTotalValue(queryMonth)

        'year
        lblComSY.Text = "YEAR   = "
        queryYear = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
        lblComSY.Text += getTotalValue(queryYear)

    End Sub


    Public Function getTotalValue(ByVal query As String) As String
        Dim total As Object = 1
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = con
            con.Open()
            'Dim query As String = "select coalesce(count(service_id),0) from service_tbl"
            cmd.CommandText = query
            total = cmd.ExecuteScalar()
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return total.ToString
    End Function

    Private Sub cbCompType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCompType.SelectionChangeCommitted
        Dim queryToday As String
        Dim queryWeek As String
        Dim queryMonth As String
        Dim queryYear As String

        If cbCompType.SelectedItem.key = 0 Then

            'summary total complain
            'today
            lblComST.Text = "TODAY    "

            lblComST.Text += lblTotComplain.Text

            'week
            lblComSW.Text = "WEEK      "

            queryWeek = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
            lblComSW.Text += getTotalValue(queryWeek)

            'month
            lblComSM.Text = "MONTH    "

            queryMonth = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
            lblComSM.Text += getTotalValue(queryMonth)

            'year
            lblComSY.Text = "YEAR    "
            queryYear = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(today_date, "MM-dd-yyyy") + "'"
            lblComSY.Text += getTotalValue(queryYear)


        Else

            'summary total complain
            'today
            lblComST.Text = "TODAY  = "

            queryToday = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(today_date, "MM-dd-yyyy") + "'
                        and comp_status = '" + cbCompType.SelectedItem.value + "'"
            lblComST.Text += getTotalValue(queryToday)

            'week
            lblComSW.Text = "WEEK     = "

            queryWeek = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(today_date, "MM-dd-yyyy") + "'
                        and comp_status = '" + cbCompType.SelectedItem.value + "'"
            lblComSW.Text += getTotalValue(queryWeek)

            'month
            lblComSM.Text = "MONTH  = "

            queryMonth = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(today_date, "MM-dd-yyyy") + "'
                        and comp_status = '" + cbCompType.SelectedItem.value + "'"
            lblComSM.Text += getTotalValue(queryMonth)

            'year
            lblComSY.Text = "YEAR   = "
            queryYear = "select coalesce(count(complain_id),0) from complain_tbl
                        where comp_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and comp_date <= '" + Format(today_date, "MM-dd-yyyy") + "'
                        and comp_status = '" + cbCompType.SelectedItem.value + "'"
            lblComSY.Text += getTotalValue(queryYear)

        End If


    End Sub

    Private Sub cbServiceListType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbServiceListType.SelectionChangeCommitted
        Dim query As String = ""
        If cbServiceListType.SelectedItem.key = 0 Then
            query = "select ser.service_date,cust.customer_name,cust.area_name,
                                    ser.service_status,
                                    ser.service_id
                                    from service_tbl ser,contract_tbl con,customer_tbl cust
                                    where
                                    ser.contract_id=con.contract_id
                                    and con.cust_id=cust.customer_id
                                    and (service_status = 'pending' or service_Status = 'allocated')
                                    order by service_date"
        Else
            query = "select ser.service_date,cust.customer_name,cust.area_name,
                                    ser.service_status,
                                    ser.service_id
                                    from service_tbl ser,contract_tbl con,customer_tbl cust
                                    where
                                    ser.contract_id=con.contract_id
                                    and con.cust_id=cust.customer_id
                                    and service_status='" + cbServiceListType.SelectedItem.value + "'
                                    order by service_date"
        End If

        DT_serviceList = fill_serviceList_in_dgv(query)
        dgvServiceDetails.DataSource = DT_serviceList
        dgvServiceDetails.Refresh()
    End Sub

    Private Sub cbServiceListDate_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbServiceListDate.SelectionChangeCommitted
        Dim parameter As Integer = cbServiceListDate.SelectedItem.key
        Dim todayDate As Date = Date.Now
        Dim query As String = ""

        If cbServiceListType.SelectedItem.key = 0 Then
            If parameter = 1 Then 'today
                query = "select ser.service_date,cust.customer_name,cust.area_name,
                                    ser.service_status,
                                    ser.service_id
                                    from service_tbl ser,contract_tbl con,customer_tbl cust
                                    where
                                    ser.contract_id=con.contract_id
                                    and con.cust_id=cust.customer_id
                                    and (service_status = 'pending' or service_status = 'allocated')
                                    and service_date = '" + Format(todayDate, "MM-dd-yyyy") + "'
                                    order by service_date"

            ElseIf parameter = 2 Then 'next week
                Dim nextWeek As Date = todayDate.AddDays(7)
                query = "select ser.service_date,cust.customer_name,cust.area_name,
                                    ser.service_status,
                                    ser.service_id
                                    from service_tbl ser,contract_tbl con,customer_tbl cust
                                    where
                                    ser.contract_id=con.contract_id
                                    and con.cust_id=cust.customer_id
                                    and (service_status = 'pending' or service_status = 'allocated')
                                    and service_date >= '" + Format(todayDate, "MM-dd-yyyy") + "'
                                    and service_date <= '" + Format(nextWeek, "MM-dd-yyyy") + "'
                                    order by service_date"


            ElseIf parameter = 3 Then 'next month
                Dim nextMonth As Date = todayDate.AddMonths(1)
                query = "select ser.service_date,cust.customer_name,cust.area_name,
                                    ser.service_status,
                                    ser.service_id
                                    from service_tbl ser,contract_tbl con,customer_tbl cust
                                    where
                                    ser.contract_id=con.contract_id
                                    and con.cust_id=cust.customer_id
                                    and (service_status = 'pending' or service_status = 'allocated')
                                    and service_date >= '" + Format(todayDate, "MM-dd-yyyy") + "'
                                    and service_date <= '" + Format(nextMonth, "MM-dd-yyyy") + "'
                                    order by service_date"
            End If

        Else
            If parameter = 1 Then 'today
                query = "select ser.service_date,cust.customer_name,cust.area_name,
                                    ser.service_status,
                                    ser.service_id
                                    from service_tbl ser,contract_tbl con,customer_tbl cust
                                    where
                                    ser.contract_id=con.contract_id
                                    and con.cust_id=cust.customer_id
                                    and service_status='" + cbServiceListType.SelectedItem.value + "'
                                    and service_date = '" + Format(todayDate, "MM-dd-yyyy") + "'
                                    order by service_date"



            ElseIf parameter = 2 Then 'next week
                Dim nextWeek As Date = todayDate.AddDays(7)
                query = "select ser.service_date,cust.customer_name,cust.area_name,
                                    ser.service_status,
                                    ser.service_id
                                    from service_tbl ser,contract_tbl con,customer_tbl cust
                                    where
                                    ser.contract_id=con.contract_id
                                    and con.cust_id=cust.customer_id
                                    and service_status='" + cbServiceListType.SelectedItem.value + "'
                                    and service_date >= '" + Format(todayDate, "MM-dd-yyyy") + "'
                                    and service_date <= '" + Format(nextWeek, "MM-dd-yyyy") + "'
                                    order by service_date"
            ElseIf parameter = 3 Then 'next month
                Dim nextMonth As Date = todayDate.AddMonths(1)
                query = "select ser.service_date,cust.customer_name,cust.area_name,
                                    ser.service_status,
                                    ser.service_id
                                    from service_tbl ser,contract_tbl con,customer_tbl cust
                                    where
                                    ser.contract_id=con.contract_id
                                    and con.cust_id=cust.customer_id
                                    and service_status='" + cbServiceListType.SelectedItem.value + "'
                                    and service_date >= '" + Format(todayDate, "MM-dd-yyyy") + "'
                                    and service_date <= '" + Format(nextMonth, "MM-dd-yyyy") + "'
                                    order by service_date"
            End If
        End If

        DT_serviceList = fill_serviceList_in_dgv(query)
        dgvServiceDetails.DataSource = DT_serviceList
        dgvServiceDetails.Refresh()

    End Sub

    Private Sub dgvServiceDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceDetails.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectRow As DataGridViewRow
        If e.RowIndex >= 0 Then
            selectRow = dgvServiceDetails.Rows(index)

            Dim service_id As Integer = selectRow.Cells(4).Value.ToString
            If selectRow.Cells(3).Value = "pending" Then
                Form_Module.service_updation_id = service_id
                service_updation_flag = True
                Contract_Service_Allocation_Form.ShowDialog()
            ElseIf selectRow.Cells(3).Value = "allocated" Then
                Form_Module.service_resolve_id = service_id
                service_resolve_flag = True
                Contract_Service_Resolve_Form.ShowDialog()
            End If
        End If




    End Sub



    Private Sub cbComplainType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbComplainType.SelectionChangeCommitted
        If cbComplainType.SelectedItem.value = "allocated" Then
            cbEmpId.Enabled = True
        Else
            cbEmpId.Enabled = False
        End If

        Dim query As String = ""
        If cbComplainType.SelectedItem.key = 0 Then 'all
            query = "select comp.comp_date,
                cust.customer_name,comp.comp_info,
                comp.comp_status,
                comp.complain_id
                from complain_tbl comp,customer_tbl cust
                where
                (comp_status = 'pending' or comp_status = 'allocated')    
                and comp.customer_id=cust.customer_id"

        ElseIf cbComplainType.SelectedItem.key = 1 Then 'pending
            query = "select comp.comp_date,
                cust.customer_name,comp.comp_info,
                comp.comp_status,
                comp.complain_id
                from complain_tbl comp,customer_tbl cust
                where
                comp_status = 'pending'
                and comp.customer_id=cust.customer_id"

        ElseIf cbComplainType.SelectedItem.key = 2 Then 'allocated
            query = "select comp.comp_date,
                    cust.customer_name,comp.comp_info,
                    comp.comp_status,
                    emp.emp_name,comp.complain_id
                    from complain_tbl comp,customer_tbl cust,emp_mstr emp
                    where comp_status = 'allocated' 
                    and comp.customer_id=cust.customer_id
                    and emp.emp_id=comp.allocate_to"
        End If

        If cbComplainType.SelectedItem.key = 2 Then
            DT_complainAllocateList = fill_serviceList_in_dgv(query)
            dgvComplainDetails.DataSource = DT_complainAllocateList
            dgvComplainDetails.Refresh()
        Else
            DT_complainPendingList = fill_serviceList_in_dgv(query)
            dgvComplainDetails.DataSource = DT_complainPendingList
            dgvComplainDetails.Refresh()

        End If



    End Sub

    Private Sub dgvComplainDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComplainDetails.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectRow As DataGridViewRow
        selectRow = dgvComplainDetails.Rows(index)
        Dim complain_id As Integer = 0
        If cbComplainType.SelectedItem.key = 2 Then 'allocated
            complain_id = selectRow.Cells(5).Value.ToString
            Dim complain_resolve_form As New Complain_Resolve_Form
            Complain_Resolve_Form.complain_id = complain_id
            Complain_Resolve_Form.complain_resolve_flag = True
            complain_resolve_form.ShowDialog()


        Else 'pending or all
            complain_id = selectRow.Cells(4).Value.ToString
            If selectRow.Cells(3).Value = "pending" Then
                Dim comp_updation As New Complain_Register_Form
                comp_updation.complain_id = complain_id
                comp_updation.complain_flag = True
                comp_updation.ShowDialog()
            Else
                Dim complain_resolve_form As New Complain_Resolve_Form
                Complain_Resolve_Form.complain_id = complain_id
                Complain_Resolve_Form.complain_resolve_flag = True
                complain_resolve_form.ShowDialog()
            End If




        End If

    End Sub
End Class