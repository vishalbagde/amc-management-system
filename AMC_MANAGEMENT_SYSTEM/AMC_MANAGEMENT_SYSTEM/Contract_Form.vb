Imports System.Data.SqlClient
Public Class Contract_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Public contract_id As Integer
    Public Shared shared_contract_id As String
    Public Shared shared_contract_select As Boolean = False
    Dim service_year As Integer
    Dim total_service As Integer
    Dim service_start_date As Date

    Private Sub Contract_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)


        btnUpdate.Enabled = False


        txtContractId.Text = "New"

        dtContractDate.Value = DateTime.Now

        CbServiceType.DataSource = fill_AMC_type()
        cbCustId.Enabled = True

        Try
            cbCustId.DataSource = New BindingSource(fill_customer_in_cb(), Nothing)
            cbCustId.DisplayMember = "value"
            cbCustId.ValueMember = "key"


            cbSalesBy.DataSource = New BindingSource(fill_emp_in_cb(), Nothing)
            cbSalesBy.DisplayMember = "value"
            cbSalesBy.ValueMember = "key"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbCustId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustId.SelectedIndexChanged

    End Sub




    Public Function fill_AMC_scheme_in_cb(ByVal amc_type As String) As Dictionary(Of String, String)
        Dim amc As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT amc_id,amc_name from amc_mstr where amc_type = '" + amc_type + "' and status = '" + get_status(1) + "'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            While dr.Read
                amc(dr("amc_id").ToString) = dr("amc_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return amc
    End Function

    Public Function get_amc_amount(ByVal amc_id As String) As Integer
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim amc_amount As Integer = 0
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT price from amc_mstr where amc_id = " + amc_id
            cmd.CommandText = query
            amc_amount = CInt(cmd.ExecuteScalar)
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return amc_amount
    End Function

    Public Function get_amc_total_service(ByVal amc_id As String) As Integer
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim total_service As Integer = 1
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT n_of_service from amc_mstr where amc_id = " + amc_id
            cmd.CommandText = query
            total_service = CInt(cmd.ExecuteScalar)
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return total_service
    End Function
    Public Function get_amc_year(ByVal amc_id As String) As Integer
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim service_year As Integer = 1
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT service_year from amc_mstr where amc_id = " + amc_id
            cmd.CommandText = query
            service_year = CInt(cmd.ExecuteScalar)
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return service_year
    End Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCustRefresh_Click(sender As Object, e As EventArgs) Handles btnCustRefresh.Click
        cbCustId.Enabled = True
        lblCustInfoName.Text = ""

    End Sub

    Private Sub CbServiceType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbServiceType.SelectionChangeCommitted
        CbServiceType.Enabled = False
        cbAMCScheme.Enabled = True
        If (CbServiceType.SelectedItem.Equals("FREE")) Then
            txtSalesAmount.Text = "0"
            txtSalesAmount.Enabled = False
        Else
        End If
        Try
            cbAMCScheme.DataSource = New BindingSource(fill_AMC_scheme_in_cb(CbServiceType.SelectedItem.ToString), Nothing)
            cbAMCScheme.DisplayMember = "value"
            cbAMCScheme.ValueMember = "key"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnServiceTypeRefresh_Click(sender As Object, e As EventArgs) Handles btnServiceTypeRefresh.Click
        CbServiceType.Enabled = True
        txtSalesAmount.Enabled = True
    End Sub
    Private Sub cbAMCScheme_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbAMCScheme.SelectionChangeCommitted
        cbAMCScheme.Enabled = False
        txtSalesAmount.Text = get_amc_amount(cbAMCScheme.SelectedValue().ToString).ToString

        mtxtFromDate.Text = Format(dtContractDate.Value, "dd-MM-yyyy")

        Dim toDate As DateTime
        toDate = Date.Parse(mtxtFromDate.Text)
        service_start_date = toDate

        Dim add_year As Integer = get_amc_year(cbAMCScheme.SelectedValue().ToString)
        service_year = add_year
        total_service = get_amc_total_service(cbAMCScheme.SelectedValue().ToString)
        mtxtToDate.Text = Format(toDate.AddYears(add_year), "dd-MM-yyyy")

    End Sub

    Private Sub cbCustId_MouseDown(sender As Object, e As MouseEventArgs) Handles cbCustId.MouseDown

    End Sub

    Private Sub cbCustId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCustId.SelectionChangeCommitted
        cbCustId.Enabled = False
        lblCustInfoName.Text = cbCustId.SelectedItem.ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "INSERT INTO contract_tbl(cust_id,machine_name,brand,model_no,serial_no,contract_date,contract_type,contract_period_from,contract_period_to,sales_by,sales_amt,remark,status,amc_id) values (@cust_id,@machine_name,@brand,@model_no,@serial_no,@contract_date,@contract_type,@contract_period_from,@contract_period_to,@sales_by,@sales_amt,@remark,@status,@amc_id); SELECT SCOPE_IDENTITY()"
            cmd.Parameters.Add(New SqlParameter("cust_id", Integer.Parse(cbCustId.SelectedValue.ToString)))
            cmd.Parameters.Add(New SqlParameter("machine_name", txtMachineName.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("brand", txtBrand.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("model_no", txtModelNo.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("serial_no", txtSerialNo.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("contract_date", Format(dtContractDate.Value, "MM-dd-yyyy").ToString))
            cmd.Parameters.Add(New SqlParameter("contract_type", CbServiceType.SelectedItem.ToString))
            Dim from_date As Date = mtxtFromDate.Text
            cmd.Parameters.Add(New SqlParameter("contract_period_from", Format(from_date, "MM-dd-yyyy").ToString))
            Dim to_date As Date = mtxtToDate.Text
            cmd.Parameters.Add(New SqlParameter("contract_period_to", Format(to_date, "MM-dd-yyyy").ToString))
            cmd.Parameters.Add(New SqlParameter("sales_by", cbSalesBy.SelectedValue().ToString))
            cmd.Parameters.Add(New SqlParameter("sales_amt", txtSalesAmount.Text))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("status", get_status(1).ToString))
            cmd.Parameters.Add(New SqlParameter("amc_id", cbAMCScheme.SelectedValue().ToString))

            Dim insert_contract_id As Integer = CInt(cmd.ExecuteScalar())
            If insert_contract_id > 0 Then
                MsgBox("AMC Create Successful AMC Id is " + insert_contract_id.ToString)
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()

            Dim add_month As Integer = (service_year * 12) / total_service

            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()

            Dim sql As String
            sql = "INSERT INTO service_tbl(contract_id,service_date,service_status,time_in,time_out,status) VALUES "
            For i = 1 To total_service
                service_start_date = service_start_date.AddMonths(add_month)
                sql = sql + "('" + insert_contract_id.ToString + "','" + service_start_date.ToString("MM-dd-yyyy") + "','pending','1000','0100','active'), "

            Next

            sql = sql.Substring(0, sql.Length - 2)
            cmd.CommandText = sql
            If cmd.ExecuteNonQuery Then
                MsgBox("Service Created successful")
            End If

            con.Close()
            cmd.Dispose()

            refresh_control()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Contract_Search_From.ShowDialog()
    End Sub

    Private Sub Contract_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If (shared_contract_select) Then
            btnAdd.Enabled = False
            btnUpdate.Enabled = True

            fill_contract_in_control(shared_contract_id)
            contract_id = shared_contract_id
            shared_contract_select = False
        End If
    End Sub

    Public Sub fill_contract_in_control(ByVal contract_id As String)
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()

            Dim query As String = "SELECT * FROM contract_tbl where contract_id = " + contract_id

            cmd.CommandText = query
            dr = cmd.ExecuteReader
            Dim amc_scheme_id As String = ""
            Dim customer_id As String = ""
            Dim emp_id As String = ""

            If dr.Read Then
                txtContractId.Text = dr("contract_id")
                dtContractDate.Value = dr("contract_date")
                txtMachineName.Text = dr("machine_name")
                txtBrand.Text = dr("brand")
                txtModelNo.Text = dr("model_no")
                txtSerialNo.Text = dr("serial_no")

                CbServiceType.SelectedIndex = CbServiceType.FindString(dr("contract_type"))
                txtSalesAmount.Text = dr("sales_amt")
                txtRemark.Text = dr("remark")
                mtxtFromDate.Text = dr("contract_period_from")
                mtxtToDate.Text = dr("contract_period_to")

                amc_scheme_id = dr("amc_id")
                customer_id = dr("cust_id")
                emp_id = dr("sales_by")

                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                    con.Dispose()
                End If

                Try
                    cbAMCScheme.DataSource = New BindingSource(fill_AMC_scheme_in_cb(CbServiceType.SelectedItem.ToString), Nothing)
                    cbAMCScheme.DisplayMember = "value"
                    cbAMCScheme.ValueMember = "key"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                cbAMCScheme.SelectedIndex = cbAMCScheme.FindString(get_amc_name(amc_scheme_id))
                cbCustId.SelectedIndex = cbCustId.FindString(get_cust_name(customer_id))
                lblCustInfoName.Text = cbCustId.SelectedItem.ToString
                cbSalesBy.SelectedIndex = cbSalesBy.FindString(get_emp_name(emp_id))


                txtContractId.Enabled = False
                cbCustId.Enabled = False
                txtSalesAmount.Enabled = False
                mtxtFromDate.Enabled = False
                mtxtToDate.Enabled = False

            Else
                MsgBox("Customer not found")
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

    Public Sub refresh_control()
        btnUpdate.Enabled = False

        btnAdd.Enabled = True

        dtContractDate.Value = Date.Now
        dtContractDate.Enabled = True
        txtContractId.Text = "New"
        txtContractId.Enabled = True
        cbCustId.Refresh()
        cbCustId.Enabled = True
        CbServiceType.Enabled = True
        CbServiceType.Refresh()
        cbAMCScheme.Refresh()
        mtxtFromDate.Enabled = True
        mtxtToDate.Enabled = True
        txtSalesAmount.Enabled = True

        lblCustInfoName.Text = ""
        mtxtFromDate.Text = ""
        mtxtToDate.Text = ""
        txtMachineName.Text = ""
        txtBrand.Text = ""
        txtModelNo.Text = ""
        txtSerialNo.Text = ""
        txtSalesAmount.Text = ""
        txtRemark.Text = ""
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_control()
    End Sub

    Private Sub cbAMCScheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAMCScheme.SelectedIndexChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE contract_tbl set 
                            cust_id=@cust_id,
                            machine_name=@machine_name,
                            brand=@brand,
                            model_no=@model_no,
                            serial_no=@serial_no,
                            contract_date=@contract_date,
                            contract_type=@contract_type,
                            contract_period_from=@contract_period_from,
                            contract_period_to=@contract_period_to,
                            sales_by=@sales_by,
                            sales_amt=@sales_amt,
                            remark=@remark,
                            status=@status,
                            amc_id=@amc_id
                            where 
                            contract_id=@contract_id"
            cmd.Parameters.Add(New SqlParameter("cust_id", Integer.Parse(cbCustId.SelectedValue.ToString)))
            cmd.Parameters.Add(New SqlParameter("machine_name", txtMachineName.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("brand", txtBrand.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("model_no", txtModelNo.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("serial_no", txtSerialNo.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("contract_date", Format(dtContractDate.Value, "MM-dd-yyyy").ToString))
            cmd.Parameters.Add(New SqlParameter("contract_type", CbServiceType.SelectedItem.ToString))
            Dim from_date As Date = mtxtFromDate.Text
            cmd.Parameters.Add(New SqlParameter("contract_period_from", Format(from_date, "MM-dd-yyyy").ToString))
            Dim to_date As Date = mtxtToDate.Text
            cmd.Parameters.Add(New SqlParameter("contract_period_to", Format(to_date, "MM-dd-yyyy").ToString))
            cmd.Parameters.Add(New SqlParameter("sales_by", cbSalesBy.SelectedValue().ToString))
            cmd.Parameters.Add(New SqlParameter("sales_amt", txtSalesAmount.Text))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("status", get_status(1).ToString))
            cmd.Parameters.Add(New SqlParameter("amc_id", cbAMCScheme.SelectedValue().ToString))
            cmd.Parameters.Add(New SqlParameter("contract_id", txtContractId.Text))


            If cmd.ExecuteNonQuery Then
                MsgBox("AMC Update succrssful AMC Id is " + contract_id.ToString)
            Else
                MsgBox("some problem in updatation")
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

    End Sub
End Class

