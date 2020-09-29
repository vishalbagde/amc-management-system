Imports System.Data.SqlClient
Public Class City_Mstr_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private city_id As Integer
    Private Sub City_Mstr_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)
        cbStatus.DataSource = fill_status()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        Try
            DataGridViewCityMstr.AutoGenerateColumns = True
            DataGridViewCityMstr.AllowUserToAddRows = False
            DataGridViewCityMstr.DataSource = fill_grideView()
            DataGridViewCityMstr.Refresh()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If control_validation() Then
            Try
                txtCityName.BackColor = Color.White
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                cmd.CommandText = "INSERT INTO city_mstr(city_name,status) values (@city_name,@status)"
                cmd.Parameters.Add(New SqlParameter("city_name", txtCityName.Text))
                cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
                If cmd.ExecuteNonQuery Then
                    MsgBox("City Insert Successful")
                End If
                txtCityName.Text = ""
                cmd.Dispose()
                con.Close()
                con.Dispose()
                DataGridViewCityMstr.DataSource = fill_grideView()
                DataGridViewCityMstr.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                End If
            End Try
        End If

    End Sub

    Private Sub DataGridViewCityMstr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCityMstr.CellClick
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = False
        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            txtCityName.BackColor = Color.White
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewCityMstr.Rows(index)
            city_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)
            txtCityName.Text = selectedRow.Cells(1).Value.ToString
            If (selectedRow.Cells(2).Value.Equals("active")) Then
                cbStatus.SelectedIndex = 0
            Else
                cbStatus.SelectedIndex = 1
                'If cbStatus.Items.Contains("active") Then
                '    MsgBox(cbStatus.Items.IndexOf("active").ToString)
                'End If
            End If

        End If



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim updateQuery As String = "UPDATE city_mstr set city_name = @city_name,status = @status where city_id = @city_id"
            cmd.CommandText = updateQuery
            cmd.Parameters.Add(New SqlParameter("city_name", txtCityName.Text))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("city_id", CInt(city_id)))

            If cmd.ExecuteNonQuery Then
                MsgBox("update sucessful")
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()
            DataGridViewCityMstr.DataSource = fill_grideView()
            DataGridViewCityMstr.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            btnAdd.Enabled = True
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            btnAdd.Enabled = True
            txtCityName.Text = ""
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try


    End Sub
    Public Function fill_grideView() As DataTable
        Dim dt As New DataTable
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim selQuery As String = "select city_id,city_name,status from city_mstr"
            cmd.CommandText = selQuery
            dr = cmd.ExecuteReader
            dt.Load(dr)
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
        Return dt

    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are You sure to delete", "City Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                Dim deleteQuery As String = "DELETE FROM city_mstr where city_id = @city_id"
                cmd.CommandText = deleteQuery
                cmd.Parameters.Add(New SqlParameter("city_id", city_id))
                If cmd.ExecuteNonQuery Then
                    MsgBox("Delete sucessful")
                End If
                cmd.Dispose()
                con.Close()
                con.Dispose()
                DataGridViewCityMstr.DataSource = fill_grideView()
                DataGridViewCityMstr.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
                btnAdd.Enabled = True
                txtCityName.Text = ""
                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                End If
            End Try
        End If


    End Sub


    Public Sub refresh_control()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtCityName.Text = ""
    End Sub

    Public Function control_validation() As Boolean
        lblVali.Text = ""
        If txtCityName.Text = "" Then
            lblVali.Text = "* Please Enter City Name" + Environment.NewLine
            Return False
        ElseIf cbStatus.SelectedItem.ToString = "" Then
            lblVali.Text = "* Please select Status " + Environment.NewLine
            Return False
        Else
            lblVali.Text = ""
            Return True
        End If

    End Function
    Private Sub DataGridViewCityMstr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCityMstr.CellContentClick

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_control()
    End Sub
End Class