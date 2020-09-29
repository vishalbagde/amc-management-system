Imports System.Data.SqlClient
Public Class Contract_Service_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim DT_Service As New DataTable
    Private Sub mtxtFromDate_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxtTimeIn.MaskInputRejected, mtxtTimeOut.MaskInputRejected

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Contract_Service_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        Try
            cbCustId.DataSource = New BindingSource(fill_cust_in_AMC_in_cb(), Nothing)
            cbCustId.DisplayMember = "value"
            cbCustId.ValueMember = "key"
            cbCustId.AutoCompleteSource = AutoCompleteSource.ListItems
            cbCustId.AutoCompleteMode = AutoCompleteMode.Append

            cbServiceStatus.DataSource = fill_Service_status()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbCustId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCustId.SelectionChangeCommitted
        Try
            If Not String.IsNullOrEmpty(cbCustId.SelectedValue.ToString) Then
                DT_Service = fill_Service_In_gridview(cbCustId.SelectedValue.ToString, "ALL")
                dgvServiceList.DataSource = DT_Service
                dgvServiceList.AutoGenerateColumns = True
                dgvServiceList.AllowUserToAddRows = False
                dgvServiceList.Refresh()
            End If
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

    Private Sub dgvServiceList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceList.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectRow As DataGridViewRow
        selectRow = dgvServiceList.Rows(index)
        Dim service_id As Integer = selectRow.Cells(0).Value.ToString
        get_servicedata_in_control(service_id)
    End Sub

    Private Sub dgvServiceList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceList.CellDoubleClick

    End Sub


    Public Sub get_servicedata_in_control(ByVal service_id As Integer)

        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT service_id,contract_id,service_date,solve_date,time_in,time_out,work_details,remark
                                    FROM service_tbl where service_id=" + service_id.ToString
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            Dim city_id As String = ""
            Dim pincode_id As String = ""
            If dr.Read Then

                lblServiceId.Text = dr("service_id")
                txtCustId.Text = dr("contract_id")
                mtxtServiceDate.Text = dr("service_date")

                If IsDBNull(dr("time_in")) Or IsDBNull(dr("time_out")) Then
                    mtxtTimeIn.Text = "1000"
                    mtxtTimeOut.Text = "0100"
                Else
                    mtxtTimeIn.Text = dr("time_in")
                    mtxtTimeOut.Text = dr("time_out")
                End If
                If Not IsDBNull(dr("work_details")) Then
                    txtWorkDetails.Text = dr("work_details")
                End If
                If Not IsDBNull(dr("remark")) Then
                    txtRemark.Text = dr("remark")
                End If


            Else
                    MsgBox("service not found")
            End If

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
                    service_status=@service_status
                    where service_id=@service_id"
            cmd.CommandText = updateQuery


            Dim service_date As Date = mtxtServiceDate.Text
            cmd.Parameters.Add(New SqlParameter("service_date", Format(service_date, "MM-dd-yyyy")))
            cmd.Parameters.Add(New SqlParameter("time_in", mtxtTimeIn.Text))
            cmd.Parameters.Add(New SqlParameter("time_out", mtxtTimeOut.Text))
            cmd.Parameters.Add(New SqlParameter("work_details", txtWorkDetails.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("service_status", cbServiceStatus.SelectedItem.ToString))
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

            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If

            DT_Service = fill_Service_In_gridview(cbCustId.SelectedValue.ToString, "ALL")
            dgvServiceList.DataSource = DT_Service
            dgvServiceList.AutoGenerateColumns = True
            dgvServiceList.AllowUserToAddRows = False
            dgvServiceList.Refresh()

        End Try
    End Sub


End Class