Imports System.Data.SqlClient
Public Class Product_Mstr_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Public product_id As Integer
    Private Sub Product_Mstr_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        dgvProductMstr.AutoGenerateColumns = True
        dgvProductMstr.AllowUserToAddRows = False
        dgvProductMstr.DataSource = fill_grideView()

        dgvProductMstr.Refresh()

        cbStatus.DataSource = fill_status()
        Try
            cbCategoryName.DataSource = New BindingSource(fill_category(), Nothing)
            cbCategoryName.DisplayMember = "value"
            cbCategoryName.ValueMember = "key"
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
            Dim selQuery As String = "select p.product_id,p.product_name,c.category_name,p.status from category_mstr c,product_mstr p where c.category_id=p.category_id"
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

    Private Sub dgvProductMstr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductMstr.CellClick
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = False
        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = dgvProductMstr.Rows(index)
            product_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)
            txtProductName.Text = selectedRow.Cells(1).Value.ToString
            cbCategoryName.SelectedIndex = cbCategoryName.FindString(selectedRow.Cells(2).Value.ToString)
            cbStatus.SelectedIndex = cbStatus.FindString(selectedRow.Cells(3).Value.ToString)
        End If


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "INSERT INTO product_mstr(product_name,category_id,status) values (@product_name,@category_id,@status)"
            cmd.Parameters.Add(New SqlParameter("category_id", Integer.Parse(cbCategoryName.SelectedValue.ToString)))
            cmd.Parameters.Add(New SqlParameter("product_name", txtProductName.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))

            If cmd.ExecuteNonQuery Then
                MsgBox("Product Insert Successful")
                refresh_control()
            End If
            txtProductName.Text = ""
            cmd.Dispose()
            con.Close()
            con.Dispose()
            dgvProductMstr.DataSource = fill_grideView()
            dgvProductMstr.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim updateQuery As String = "UPDATE product_mstr set product_name = @product_name,category_id= @category_id, status = @status where product_id = @product_id"
            cmd.CommandText = updateQuery
            cmd.Parameters.Add(New SqlParameter("product_name", txtProductName.Text))
            cmd.Parameters.Add(New SqlParameter("category_id", Integer.Parse(cbCategoryName.SelectedValue.ToString)))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("product_id", product_id))
            If cmd.ExecuteNonQuery Then
                MsgBox("update sucessful")
                refresh_control()
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()
            dgvProductMstr.DataSource = fill_grideView()
            dgvProductMstr.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            txtProductName.Text = ""
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are You sure to delete", "product Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                Dim deleteQuery As String = "DELETE FROM product_mstr where product_id = @product_id"
                cmd.CommandText = deleteQuery
                cmd.Parameters.Add(New SqlParameter("product_id", product_id))
                If cmd.ExecuteNonQuery Then
                    MsgBox("Delete sucessful")
                    refresh_control()
                End If
                cmd.Dispose()
                con.Close()
                con.Dispose()
                dgvProductMstr.DataSource = fill_grideView()
                dgvProductMstr.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
                txtProductName.Text = ""
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
        txtProductName.Text = ""

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_control()
    End Sub
End Class