Imports System.Data.SqlClient
Public Class Pincode_Mstr_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private pincode_id As Integer
    Private Sub Pincode_Mstr_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        dgvPincode.AutoGenerateColumns = True
        dgvPincode.AllowUserToAddRows = False
        dgvPincode.DataSource = fill_grideView()
        dgvPincode.Refresh()

        cbStatus.DataSource = fill_status()
        Try
            cbCityName.DataSource = New BindingSource(fill_city(), Nothing)
            cbCityName.DisplayMember = "value"
            cbCityName.ValueMember = "key"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Public Function fill_grideView() As DataTable
        Dim dt As New DataTable
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim selQuery As String = "select p.pincode_id,c.city_name,p.pincode_name,p.status from city_mstr c,pincode_mstr p where c.city_id=p.city_id"
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If control_validation() Then
            Try
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                cmd.CommandText = "INSERT INTO pincode_mstr(city_id,pincode_name,status) values (@city_id,@pincode_name,@status)"
                cmd.Parameters.Add(New SqlParameter("city_id", Integer.Parse(cbCityName.SelectedValue.ToString)))
                cmd.Parameters.Add(New SqlParameter("pincode_name", txtPincodeName.Text.ToString))
                cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))

                If cmd.ExecuteNonQuery Then
                    MsgBox("Pincode Insert Successful")
                    refresh_Control()
                End If
                txtPincodeName.Text = ""
                cmd.Dispose()
                con.Close()
                con.Dispose()
                dgvPincode.DataSource = fill_grideView()
                dgvPincode.Refresh()
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

    Private Sub dgPincode_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPincode.CellClick
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = False

        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = dgvPincode.Rows(index)
            pincode_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)
            cbCityName.SelectedIndex = cbCityName.FindString(selectedRow.Cells(1).Value.ToString)
            txtPincodeName.Text = selectedRow.Cells(2).Value.ToString
            cbStatus.SelectedIndex = cbStatus.FindString(selectedRow.Cells(3).Value.ToString)
        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If control_validation() Then

            Try
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                Dim updateQuery As String = "UPDATE pincode_mstr set pincode_name = @pincode_name,city_id= @city_id, status = @status where pincode_id = @pincode_id"
                cmd.CommandText = updateQuery
                cmd.Parameters.Add(New SqlParameter("pincode_name", txtPincodeName.Text))
                cmd.Parameters.Add(New SqlParameter("city_id", Integer.Parse(cbCityName.SelectedValue.ToString)))
                cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
                cmd.Parameters.Add(New SqlParameter("pincode_id", pincode_id))
                If cmd.ExecuteNonQuery Then
                    MsgBox("update sucessful")
                    refresh_Control()
                End If
                cmd.Dispose()
                con.Close()
                con.Dispose()
                dgvPincode.DataSource = fill_grideView()
                dgvPincode.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                btnAdd.Enabled = True
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
                txtPincodeName.Text = ""
                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are You sure to delete", "pincode Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                Dim deleteQuery As String = "DELETE FROM pincode_mstr where pincode_id = @pincode_id"
                cmd.CommandText = deleteQuery
                cmd.Parameters.Add(New SqlParameter("pincode_id", pincode_id))
                If cmd.ExecuteNonQuery Then
                    MsgBox("Delete sucessful")
                    refresh_Control()

                End If
                cmd.Dispose()
                con.Close()
                con.Dispose()
                dgvPincode.DataSource = fill_grideView()
                dgvPincode.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
                btnAdd.Enabled = True
                txtPincodeName.Text = ""
                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                End If
            End Try

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub cbCityName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCityName.SelectedIndexChanged

    End Sub

    Public Function control_validation() As Boolean
        lblVali.Text = ""
        If txtPincodeName.Text = "" Then
            lblVali.Text = "* Please Enter Pincode" + Environment.NewLine
            Return False
        ElseIf cbCityName.SelectedItem.ToString = "" Then
            lblVali.Text = "* Please select City Name " + Environment.NewLine
            Return False
        ElseIf cbStatus.SelectedItem.ToString = "" Then
            lblVali.Text = "* Please select Status " + Environment.NewLine
            Return False
        Else
            lblVali.Text = ""
            Return True
        End If

    End Function
    Public Sub refresh_Control()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtPincodeName.Text = ""
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_Control()
    End Sub
End Class
