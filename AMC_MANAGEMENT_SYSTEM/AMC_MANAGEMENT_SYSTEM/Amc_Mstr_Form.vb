Imports System.Data.SqlClient
Public Class Amc_Mstr_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Public amc_id As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Amc_Mstr_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        cbStatus.DataSource = fill_status()
        cbAmcType.DataSource = fill_AMC_type()


        cbNofService.Items.Clear()

        For i = 1 To 12
            cbNofService.Items.Add(i.ToString)
        Next
        Try
            cbServiceYear.DataSource = New BindingSource(fill_service_year(), Nothing)
            cbServiceYear.DisplayMember = "value"
            cbServiceYear.ValueMember = "key"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dgvAmcMstr.AutoGenerateColumns = True
            dgvAmcMstr.DataSource = fill_grideView()
            dgvAmcMstr.AllowUserToAddRows = False
            dgvAmcMstr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvAmcMstr.Refresh()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try


    End Sub

    Public Function fill_grideView() As DataTable
        Dim dt As New DataTable
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim selQuery As String = "select amc_id,amc_name,amc_type,price,n_of_service,service_year,remark,status from amc_mstr"
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
            cmd.CommandText = "INSERT INTO amc_mstr(amc_name,amc_type,price,n_of_service,service_year,remark,status) VALUES(@amc_name,@amc_type,@price,@n_of_service,@service_year,@remark,@status)"
            cmd.Parameters.Add(New SqlParameter("amc_name", txtAmcName.Text))
            cmd.Parameters.Add(New SqlParameter("amc_type", cbAmcType.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("price", txtPrice.Text))
            cmd.Parameters.Add(New SqlParameter("n_of_service", cbNofService.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("service_year", cbServiceYear.SelectedValue.ToString))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
            If cmd.ExecuteNonQuery Then
                MsgBox("AMC Details Insert Successful")
            End If
            txtAmcName.Text = ""
            cmd.Dispose()
            con.Close()
            con.Dispose()
            dgvAmcMstr.DataSource = fill_grideView()
            dgvAmcMstr.Refresh()
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim updateQuery As String = "UPDATE amc_mstr set amc_name = @amc_name,amc_type= @amc_type,price= @price,n_of_service= @n_of_service,service_year= @service_year,remark= @remark,status = @status where amc_id = @amc_id"
            cmd.CommandText = updateQuery
            cmd.Parameters.Add(New SqlParameter("amc_name", txtAmcName.Text))
            cmd.Parameters.Add(New SqlParameter("amc_type", cbAmcType.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("price", txtPrice.Text))
            cmd.Parameters.Add(New SqlParameter("n_of_service", cbNofService.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("service_year", cbServiceYear.SelectedValue.ToString))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("status", cbStatus.SelectedItem.ToString))
            cmd.Parameters.Add(New SqlParameter("amc_id", amc_id))
            If cmd.ExecuteNonQuery Then
                MsgBox("update sucessful")
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()
            dgvAmcMstr.DataSource = fill_grideView()
            dgvAmcMstr.Refresh()
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

    Private Sub dgvAmcMstr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAmcMstr.CellClick
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = False
        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = dgvAmcMstr.Rows(index)
            amc_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)
            txtAmcName.Text = selectedRow.Cells(1).Value.ToString
            cbAmcType.SelectedIndex = cbAmcType.FindString(selectedRow.Cells(2).Value.ToString)
            txtPrice.Text = selectedRow.Cells(3).Value.ToString
            cbNofService.SelectedIndex = cbNofService.FindString(selectedRow.Cells(4).Value.ToString)
            cbServiceYear.SelectedIndex = cbServiceYear.FindString(selectedRow.Cells(5).Value.ToString + " year")
            txtRemark.Text = selectedRow.Cells(6).Value.ToString
            cbStatus.SelectedIndex = cbStatus.FindString(selectedRow.Cells(7).Value.ToString)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are You sure to delete", "AMC Record Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()
                Dim deleteQuery As String = "DELETE FROM amc_mstr where amc_id = @amc_id"
                cmd.CommandText = deleteQuery
                cmd.Parameters.Add(New SqlParameter("amc_id", amc_id))
                If cmd.ExecuteNonQuery Then
                    MsgBox("Delete sucessful")
                End If
                cmd.Dispose()
                con.Close()
                con.Dispose()
                dgvAmcMstr.DataSource = fill_grideView()
                dgvAmcMstr.Refresh()
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_control()
    End Sub
    Public Sub refresh_control()
        txtAmcName.Text = ""
        txtPrice.Text = ""
        txtRemark.Text = ""
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Public Function fill_service_year() As Dictionary(Of Integer, String)
        Dim service_year As New Dictionary(Of Integer, String)

        For i = 1 To 10
            service_year.Add(i, i.ToString + " year")
        Next
        Return service_year
    End Function

End Class