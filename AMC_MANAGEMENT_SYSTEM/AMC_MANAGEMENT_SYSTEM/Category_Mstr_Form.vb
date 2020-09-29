Imports System.Data.SqlClient
Public Class Category_Mstr_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Public category_id As Integer
    Private Sub Category_Mstr_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        Me.CenterToScreen()
        apply_theme(Me)
        cbStatus.DataSource = fill_status()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        Try
            dgvCategoryMstr.AutoGenerateColumns = True
            dgvCategoryMstr.AllowUserToAddRows = False
            dgvCategoryMstr.DataSource = fill_grideView()
            dgvCategoryMstr.Refresh()
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
            Dim selQuery As String = "select category_id,category_name,status from category_mstr"
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
            cmd.CommandText = "INSERT INTO category_mstr(category_name,status) values (@category_name,@status)"
            cmd.Parameters.Add(New SqlParameter("category_name", txtCategoryName.Text))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
            If cmd.ExecuteNonQuery Then
                MsgBox("Category Insert Successful")
                refresh_control()
            End If
            txtCategoryName.Text = ""
            cmd.Dispose()
            con.Close()
            con.Dispose()
            dgvCategoryMstr.DataSource = fill_grideView()
            dgvCategoryMstr.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
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
            Dim updateQuery As String = "UPDATE category_mstr set category_name = @category_name,status = @status where category_id = @category_id"
            cmd.CommandText = updateQuery
            cmd.Parameters.Add(New SqlParameter("category_name", txtCategoryName.Text))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("category_id", category_id))

            If cmd.ExecuteNonQuery Then
                MsgBox("update sucessful")
                refresh_control()
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()
            dgvCategoryMstr.DataSource = fill_grideView()
            dgvCategoryMstr.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            txtCategoryName.Text = ""
            btnUpdate.Enabled = False
            btnDelete.Enabled = False

            If con.State = ConnectionState.Open Then
            cmd.Dispose()
            con.Close()
        End If
        End Try
    End Sub

    Private Sub dgvCategoryMstr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategoryMstr.CellClick
        btnAdd.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = dgvCategoryMstr.Rows(index)
            category_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)
            txtCategoryName.Text = selectedRow.Cells(1).Value.ToString
            cbStatus.SelectedIndex = cbStatus.FindString(selectedRow.Cells(2).Value.ToString)
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are You sure to delete", "City Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                Dim deleteQuery As String = "DELETE FROM category_mstr where category_id = @category_id"
                cmd.CommandText = deleteQuery
                cmd.Parameters.Add(New SqlParameter("category_id", category_id))
                If cmd.ExecuteNonQuery Then
                    MsgBox("Delete sucessful")
                    refresh_control()
                End If
                cmd.Dispose()
                con.Close()
                con.Dispose()
                dgvCategoryMstr.DataSource = fill_grideView()
                dgvCategoryMstr.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
                txtCategoryName.Text = ""
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
        txtCategoryName.Text = ""
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_control()
    End Sub
End Class