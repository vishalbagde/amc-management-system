Imports System.Data.SqlClient
Public Class Customer_mstr_Form

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Public Shared customer_id As String
    Public Shared customer_select As Boolean = False

    Private Sub Customer_mstr_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)
        cbPincodeId.Enabled = False
        cbStatus.DataSource = fill_status()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        Try
            txtCustId.Text = CInt(get_maxId("customer_tbl", "customer_id") + 1).ToString
            cbCityName.DataSource = New BindingSource(fill_active_city(), Nothing)
            cbCityName.DisplayMember = "value"
            cbCityName.ValueMember = "key"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cbCityName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCityName.SelectionChangeCommitted
        cbPincodeId.Enabled = True

        Dim city_id As Integer = Integer.Parse(cbCityName.SelectedValue.ToString)
        Dim pincode_list As Dictionary(Of String, String) = fill_pincode(city_id)
        If Not IsNothing(pincode_list) Then
            Try
                cbPincodeId.DataSource = New BindingSource(pincode_list, Nothing)
                cbPincodeId.DisplayMember = "value"
                cbPincodeId.ValueMember = "key"
                cbPincodeId.AutoCompleteSource = AutoCompleteSource.ListItems
                cbPincodeId.AutoCompleteMode = AutoCompleteMode.Suggest
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            If (control_validation()) Then
                cmd.Connection = con
                con.Open()
                cmd.CommandText = "INSERT INTO customer_tbl(customer_name,address,area_name,city_id,pincode_id,phone_r,phone_m,email,remark,status) VALUES(@customer_name,@address,@area_name,@city_id,@pincode_id,@phone_r,@phone_m,@email,@remark,@status);SELECT SCOPE_IDENTITY()"
                cmd.Parameters.AddWithValue("@customer_name", txtCustName.Text)
                cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@area_name", txtArea.Text)
                cmd.Parameters.AddWithValue("@city_id", CInt(cbCityName.SelectedValue.ToString))
                cmd.Parameters.AddWithValue("@pincode_id", CInt(cbPincodeId.SelectedValue.ToString))
                cmd.Parameters.AddWithValue("@phone_r", txtPhoneR.Text)
                cmd.Parameters.AddWithValue("@phone_m", txtPhoneM.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@remark", txtRemark.Text)
                cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString)

                Dim newProdID As Integer = CInt(cmd.ExecuteScalar())
                If newProdID > 0 Then
                    MsgBox("New Customer ID IS " + newProdID.ToString)
                    refresh_control()
                End If
                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                    con.Dispose()
                End If

            Else
                MsgBox("please enter proper value")
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

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        fill_cust_in_control(txtCustId.Text)
    End Sub

    Private Sub cbCityName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCityName.SelectedIndexChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim updateQuery As String = "UPDATE customer_tbl set customer_name = @customer_name,address = @address,area_name=@area_name,city_id=@city_id,pincode_id=@pincode_id,phone_r=@phone_r,phone_m=@phone_m,email=@email,remark=@remark,status=@status where customer_id=@customer_id"
            cmd.CommandText = updateQuery
            cmd.Parameters.Add(New SqlParameter("customer_name", txtCustName.Text))
            cmd.Parameters.Add(New SqlParameter("address", txtAddress.Text))
            cmd.Parameters.Add(New SqlParameter("area_name", txtArea.Text))
            cmd.Parameters.Add(New SqlParameter("city_id", Integer.Parse(cbCityName.SelectedValue.ToString)))
            cmd.Parameters.Add(New SqlParameter("pincode_id", Integer.Parse(cbPincodeId.SelectedValue.ToString)))
            cmd.Parameters.Add(New SqlParameter("phone_r", txtPhoneR.Text))
            cmd.Parameters.Add(New SqlParameter("phone_m", txtPhoneM.Text))
            cmd.Parameters.Add(New SqlParameter("email", txtEmail.Text))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("customer_id", Integer.Parse(txtCustId.Text)))

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
        End Try
    End Sub

    Public Sub fill_cust_in_control(ByVal customer_id As String)
        Try

            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT * FROM customer_tbl where customer_id = " + customer_id
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            Dim city_id As String = ""
            Dim pincode_id As String = ""
            If dr.Read Then
                btnAdd.Enabled = False
                btnUpdate.Enabled = True
                btnDelete.Enabled = True
                txtCustId.Enabled = False
                txtCustId.Text = dr("customer_id")
                txtCustName.Text = dr("customer_name")
                txtAddress.Text = dr("address")
                txtArea.Text = dr("area_name")
                txtPhoneR.Text = dr("phone_r")
                txtPhoneM.Text = dr("phone_m")
                txtEmail.Text = dr("email")
                txtRemark.Text = dr("remark")
                Dim status As String = dr("status")
                cbStatus.SelectedIndex = cbStatus.FindString(dr("status"))

                city_id = dr("city_id")
                pincode_id = dr("pincode_id")


                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                    con.Dispose()
                End If
                cbCityName.SelectedIndex = cbCityName.FindString(get_cityname(city_id))

                cbPincodeId.Enabled = True
                Dim pincode_list As Dictionary(Of String, String) = fill_pincode(city_id)
                cbPincodeId.DataSource = New BindingSource(pincode_list, Nothing)
                cbPincodeId.DisplayMember = "value"
                cbPincodeId.ValueMember = "key"

                cbPincodeId.SelectedIndex = cbPincodeId.FindString(get_pincodename(pincode_id))
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
        txtCustId.Text = get_maxId("customer_tbl", "customer_id")
        txtCustName.Text = ""
        txtArea.Text = ""
        txtAddress.Text = ""
        txtPhoneM.Text = ""
        txtPhoneR.Text = ""
        txtEmail.Text = ""
        txtRemark.Text = ""
        txtCustId.Enabled = True
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_control()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are You sure to delete", "Customer Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                Dim deleteQuery As String = "DELETE FROM customer_tbl where customer_id = @customer_id"
                cmd.CommandText = deleteQuery
                cmd.Parameters.Add(New SqlParameter("customer_id", Integer.Parse(txtCustId.Text)))
                If cmd.ExecuteNonQuery Then
                    MsgBox("Delete sucessful")
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
            End Try

        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Customer_Search_Form.ShowDialog()
    End Sub

    Private Sub Customer_mstr_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If (customer_select) Then
            fill_cust_in_control(customer_id)
            customer_select = False
        End If
    End Sub


    Public Function control_validation() As Boolean
        If (txtCustName.Text = "" Or txtAddress.Text = "" Or txtArea.Text = "" _
            Or txtPhoneR.Text = "") Then
            Return False
        Else
            Return True
        End If
    End Function





End Class