Imports System.Data.SqlClient
Public Class Contract_Service_reminder_Form

    Dim DT_service_list As New DataTable
    Dim con As SqlConnection = MyConnection()
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Dim service_id As Integer
    Dim complain_id As Integer

    Private Sub Contract_Service_reminder_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        DT_service_list = fill_service_List_In_gridview()
        dgvServiceSelect.DataSource = fill_service_List_In_gridview()
        dgvServiceSelect.AutoGenerateColumns = True
        dgvServiceSelect.AllowUserToAddRows = False
        dgvServiceSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvServiceSelect.Refresh()
    End Sub
    Public Function fill_service_List_In_gridview() As DataTable
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim dt As New DataTable

        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim query As String = "select ser.service_id,cust.customer_name,ser.service_date,
                                ser.service_status
                                from service_tbl ser,contract_tbl con,customer_tbl cust
                                where con.contract_id=ser.contract_id
                                and cust.customer_id=con.cust_id
                                and service_status='pending'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            dt.Load(dr)
            If con.State = ConnectionState.Open Then
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dgvServiceSelect_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceSelect.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If index >= 0 Then
            selectedRow = dgvServiceSelect.Rows(index)
            service_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Module.service_updation_id = service_id
        service_updation_flag = True
        Contract_Service_Allocation_Form.ShowDialog()
    End Sub

    Private Sub txtCustNameOrId_TextChanged(sender As Object, e As EventArgs) Handles txtCustNameOrId.TextChanged
        Dim DV_service_list As New DataView(DT_service_list)

        DV_service_list.RowFilter = String.Format("customer_name like '%{0}%'", txtCustNameOrId.Text)

        dgvServiceSelect.DataSource = DV_service_list
    End Sub
End Class