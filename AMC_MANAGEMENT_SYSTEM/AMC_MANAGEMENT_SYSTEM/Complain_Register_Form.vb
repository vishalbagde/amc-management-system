Imports System.Data.SqlClient


Public Class Complain_Register_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Public complain_id As Integer
    Public complain_flag As Boolean = False
    Private Sub Complain_Register_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        Try
            cbCustId.DataSource = New BindingSource(fill_customer_in_cb(), Nothing)
            cbCustId.DisplayMember = "value"
            cbCustId.ValueMember = "key"

            Dim empIdDictionary As New Dictionary(Of String, String)
            empIdDictionary.Add("0", "Select")
            For Each emp_name_dictionary In fill_emp_in_cb()
                empIdDictionary.Add(emp_name_dictionary.Key, emp_name_dictionary.Value)
            Next
            cbEmpId.DataSource = New BindingSource(empIdDictionary, Nothing)
            cbEmpId.DisplayMember = "value"
            cbEmpId.ValueMember = "key"

            mtxtComplainDate.Text = Date.Now
            mtxtComplainTime.Text = DateTime.Now.ToString("HH:ss")

            If complain_flag = True Then

                btnAdd.Enabled = False
                btnUpdate.Enabled = True
                btnDelete.Enabled = True
                fill_complain_in_control(complain_id)
                cbCustId.Enabled = False
                mtxtComplainDate.Enabled = False
                mtxtComplainTime.Enabled = False

                complain_flag = False
            Else
                lblCompStatus.Text = "New"
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()

            If cbEmpId.SelectedIndex = 0 Then
                cmd.CommandText = "INSERT INTO complain_tbl(customer_id,comp_date,comp_time,comp_info,comp_status,remark,status)
            VALUES(@customer_id,@comp_date,@comp_time,@comp_info,@comp_status,@remark,@status);SELECT SCOPE_IDENTITY()"
                cmd.Parameters.Add(New SqlParameter("comp_status", "pending"))

            Else
                cmd.CommandText = "INSERT INTO complain_tbl(customer_id,comp_date,comp_time,comp_info,comp_status,remark,status,allocate_to)
            VALUES(@customer_id,@comp_date,@comp_time,@comp_info,@comp_status,@remark,@status,@allocate_to); SELECT SCOPE_IDENTITY()"
                cmd.Parameters.Add(New SqlParameter("allocate_to", cbEmpId.SelectedValue.ToString))
                cmd.Parameters.Add(New SqlParameter("comp_status", "allocated"))
            End If

            Dim complain_date As Date = mtxtComplainDate.Text
            cmd.Parameters.Add(New SqlParameter("customer_id", cbCustId.SelectedItem.key))
            cmd.Parameters.Add(New SqlParameter("comp_date", Format(complain_date, "MM-dd-yyyy")))
            cmd.Parameters.Add(New SqlParameter("comp_time", mtxtComplainTime.Text))
            cmd.Parameters.Add(New SqlParameter("comp_info", txtComplainInfo.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("status", get_status(1)))
            Dim newCompID As Integer = CInt(cmd.ExecuteScalar())

            If newCompID > 0 Then
                MsgBox("Your Complain ID IS " + newCompID.ToString)
                refresh_control()
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

    Private Sub Complain_Register_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Public Sub fill_complain_in_control(ByVal complain_id As String)
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT * FROM complain_tbl where complain_id = " + complain_id
            cmd.CommandText = query
            dr = cmd.ExecuteReader

            Dim customer_id As Integer
            Dim emp_id As Integer

            If dr.Read Then

                customer_id = dr("customer_id")
                If dr("comp_Status").Equals("allocated") Then
                    emp_id = dr("allocate_to")
                    lblCompStatus.Text = dr("comp_status")
                    lblCompStatus.BackColor = Color.Green
                Else
                    emp_id = 0
                    lblCompStatus.Text = dr("comp_status")
                    lblCompStatus.BackColor = Color.Red
                End If

                mtxtComplainDate.Text = dr("comp_date")
                mtxtComplainTime.Text = dr("comp_time")
                txtComplainInfo.Text = dr("comp_info")
                txtRemark.Text = dr("remark")


                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                    con.Dispose()
                End If

                cbCustId.SelectedIndex = cbCustId.FindString(get_cust_name(customer_id))
                If emp_id > 0 Then
                    cbEmpId.SelectedIndex = cbEmpId.FindString(get_emp_name(emp_id))
                End If

            Else
                MsgBox("Complain not found")
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()

            If cbEmpId.SelectedIndex = 0 Then
                cmd.CommandText = "Update complain_tbl set 
            comp_info=@comp_info,comp_status=@comp_status,remark=@remark,status=@status
            WHERE Complain_id =" + complain_id.ToString
                cmd.Parameters.Add(New SqlParameter("comp_status", "pending"))

            Else
                cmd.CommandText = "Update complain_tbl set 
                comp_info=@comp_info,comp_status=@comp_status,remark=@remark,status=@status,allocate_to=@allocate_to
                WHERE Complain_id =" + complain_id.ToString
                cmd.Parameters.Add(New SqlParameter("allocate_to", cbEmpId.SelectedValue.ToString))
                cmd.Parameters.Add(New SqlParameter("comp_status", "allocated"))

            End If

            Dim complain_date As Date = mtxtComplainDate.Text

            cmd.Parameters.Add(New SqlParameter("comp_info", txtComplainInfo.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("status", get_status(1)))

            If cmd.ExecuteNonQuery() Then
                MsgBox("Complain Update Successful")
                refresh_control()

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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_control()
    End Sub

    Public Sub refresh_control()
        cbCustId.Enabled = True
        mtxtComplainDate.Enabled = True
        mtxtComplainTime.Enabled = True
        mtxtComplainDate.Text = Date.Now
        mtxtComplainTime.Text = DateTime.Now.ToString("HH:ss")

        txtComplainBy.Text = ""
        txtComplainInfo.Text = ""
        txtRemark.Text = ""

        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False


    End Sub

End Class