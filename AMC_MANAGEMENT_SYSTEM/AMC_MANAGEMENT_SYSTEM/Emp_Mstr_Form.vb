Imports System.Data.SqlClient
Public Class Emp_Mstr_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Public emp_id As Integer
    Private Sub Emp_Mstr_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        cbStatus.DataSource = fill_status()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        Try
            dgvEmpMstr.AutoGenerateColumns = True
            dgvEmpMstr.AllowUserToAddRows = False
            dgvEmpMstr.DataSource = fill_grideView()
            dgvEmpMstr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgvEmpMstr.Refresh()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

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
            Dim selQuery As String = "select emp_id,emp_name,address,phone,email,status from emp_mstr"
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
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "INSERT INTO emp_mstr(emp_name,address,phone,email,status) VALUES(@emp_name,@address,@phone,@email,@status)"
            cmd.Parameters.Add(New SqlParameter("emp_name", txtEmpName.Text))
            cmd.Parameters.Add(New SqlParameter("address", txtAddress.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("phone", txtPhone.Text))
            cmd.Parameters.Add(New SqlParameter("email", txtEmail.Text))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
            If cmd.ExecuteNonQuery Then
                MsgBox("City Insert Successful")
                refresh_control()
            End If

            cmd.Dispose()
            con.Close()
            con.Dispose()
            dgvEmpMstr.DataSource = fill_grideView()
            dgvEmpMstr.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_control()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim updateQuery As String = "UPDATE emp_mstr set emp_name = @emp_name,address=@address,phone=@phone,email=@email,status = @status where emp_id = @emp_id"
            cmd.CommandText = updateQuery
            cmd.Parameters.Add(New SqlParameter("emp_name", txtEmpName.Text))
            cmd.Parameters.Add(New SqlParameter("address", txtAddress.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("phone", txtPhone.Text))
            cmd.Parameters.Add(New SqlParameter("email", txtEmail.Text))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("emp_id", emp_id))
            If cmd.ExecuteNonQuery Then
                MsgBox("update sucessful")
                refresh_control()
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()
            dgvEmpMstr.DataSource = fill_grideView()
            dgvEmpMstr.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            btnUpdate.Enabled = False
            btnDelete.Enabled = False

            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvEmpMstr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpMstr.CellClick
        btnAdd.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = dgvEmpMstr.Rows(index)
            emp_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)
            txtEmpName.Text = selectedRow.Cells(1).Value.ToString
            txtAddress.Text = selectedRow.Cells(2).Value.ToString
            txtPhone.Text = selectedRow.Cells(3).Value.ToString
            txtEmail.Text = selectedRow.Cells(4).Value.ToString
            cbStatus.SelectedIndex = cbStatus.FindString(selectedRow.Cells(5).Value.ToString)
        End If


    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are You sure to delete", "Employee Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                Dim deleteQuery As String = "DELETE FROM emp_mstr where emp_id = @emp_id"
                cmd.CommandText = deleteQuery
                cmd.Parameters.Add(New SqlParameter("emp_id", emp_id))
                If cmd.ExecuteNonQuery Then
                    MsgBox("Delete sucessful")
                    refresh_control()
                End If
                cmd.Dispose()
                con.Close()
                con.Dispose()
                dgvEmpMstr.DataSource = fill_grideView()
                dgvEmpMstr.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
                txtEmpName.Text = ""
                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                End If
            End Try
        End If

    End Sub


    Public Sub refresh_control()
        txtEmpName.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub
End Class