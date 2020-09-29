Imports System.Data.SqlClient

Public Class Contract_Service_Allocation_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim DT_Service As New DataTable

    Private Sub Contract_Service_Allocation_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)


        If service_updation_flag Then
            get_servicedata_in_control(service_updation_id)
            service_updation_flag = False
        End If


        Try
            cbCustId.DataSource = New BindingSource(fill_cust_in_AMC_in_cb(), Nothing)
            cbCustId.DisplayMember = "value"
            cbCustId.ValueMember = "key"
            cbCustId.AutoCompleteSource = AutoCompleteSource.ListItems
            cbCustId.AutoCompleteMode = AutoCompleteMode.Append

            cbEmpId.DataSource = New BindingSource(fill_emp_in_cb(), Nothing)
            cbEmpId.DisplayMember = "value"
            cbEmpId.ValueMember = "key"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function fill_cust_in_AMC_in_cb() As Dictionary(Of String, String)
        Dim customer As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "select co.contract_id,co.cust_id,cu.customer_name,a.amc_name from contract_tbl co,customer_tbl cu,amc_mstr a
                                    where co.cust_id=cu.customer_id and
                                    a.amc_id=co.amc_id"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            While dr.Read
                customer(dr("contract_id").ToString) = dr("customer_name") + " - " + dr("amc_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return customer
    End Function

    Private Sub cbCustId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCustId.SelectionChangeCommitted
        Try
            If Not String.IsNullOrEmpty(cbCustId.SelectedValue.ToString) Then
                DT_Service = fill_Service_In_gridview(cbCustId.SelectedValue.ToString, "pending")
                dgvServiceList.DataSource = DT_Service
                dgvServiceList.AutoGenerateColumns = True
                dgvServiceList.AllowUserToAddRows = False
                dgvServiceList.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgvServiceList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceList.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectRow As DataGridViewRow
        selectRow = dgvServiceList.Rows(index)
        Dim service_id As Integer = selectRow.Cells(0).Value.ToString
        get_servicedata_in_control(service_id)
    End Sub



    Public Sub get_servicedata_in_control(ByVal service_id As Integer)

        Try
            Dim empId As Integer = 0
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT service_id,contract_id,service_date,solve_date,time_in,time_out,work_details,remark,allocate_to
                                    FROM service_tbl where service_id=" + service_id.ToString
            cmd.CommandText = query
            dr = cmd.ExecuteReader

            If dr.Read Then


                If IsDBNull(dr("time_in")) Or IsDBNull(dr("time_out")) Then
                    mtxtTimeIn.Text = "1000"
                    mtxtTimeOut.Text = "0100"
                Else
                    mtxtTimeIn.Text = dr("time_in")
                    mtxtTimeOut.Text = dr("time_out")
                End If

                lblServiceId.Text = dr("service_id")
                txtContractId.Text = dr("contract_id")
                mtxtServiceDate.Text = dr("service_date")
                '   mtxtTimeIn.Text = dr("time_in")
                '   mtxtTimeOut.Text = dr("time_out")
                'txtWorkDetails.Text = dr("work_details")
                'txtRemark.Text = dr("remark")
                'empId = dr("allocate_to")

            Else
                MsgBox("service not found")
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If ConnectionState.Open = con.State Then
                cmd.Dispose()
                con.Close()
            End If
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim updateQuery As String = "UPDATE service_tbl set 
                    service_date=@service_date,
                    time_in =@time_in,
                    time_out=@time_out,
                    work_details=@work_details,
                    remark=@remark, 
                    service_status=@service_status,
                    allocate_to=@allocate_to
                    where service_id=@service_id"
            cmd.CommandText = updateQuery

            Dim service_date As Date = mtxtServiceDate.Text

            cmd.Parameters.Add(New SqlParameter("service_date", Format(service_date, "MM-dd-yyyy")))
            cmd.Parameters.Add(New SqlParameter("time_in", mtxtTimeIn.Text))
            cmd.Parameters.Add(New SqlParameter("time_out", mtxtTimeOut.Text))
            cmd.Parameters.Add(New SqlParameter("work_details", txtWorkDetails.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("service_status", "allocated"))
            cmd.Parameters.Add(New SqlParameter("allocate_to", Integer.Parse(cbEmpId.SelectedValue.ToString)))
            cmd.Parameters.Add(New SqlParameter("service_id", Integer.Parse(lblServiceId.Text.ToString)))

            If cmd.ExecuteNonQuery Then
                MsgBox("update sucessful")
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            refresh_control()
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If

            DT_Service = fill_Service_In_gridview(cbCustId.SelectedValue.ToString, "pending")
            dgvServiceList.DataSource = DT_Service
            dgvServiceList.AutoGenerateColumns = True
            dgvServiceList.AllowUserToAddRows = False
            dgvServiceList.Refresh()

        End Try
    End Sub


    Public Sub refresh_control()
        txtContractId.Text = ""
        mtxtServiceDate.Text = ""
        mtxtTimeIn.Text = ""
        mtxtTimeOut.Text = ""
        txtRemark.Text = ""
        txtWorkDetails.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

