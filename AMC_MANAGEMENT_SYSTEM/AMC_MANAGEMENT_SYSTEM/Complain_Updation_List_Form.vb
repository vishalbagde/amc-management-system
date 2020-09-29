Imports System.Data.SqlClient
Public Class Complain_Updation_List_Form
    Dim contract_id As String
    Dim DT_service_allocated As New DataTable
    Dim con As SqlConnection = MyConnection()
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Dim service_id As Integer

    Dim complain_id As Integer = 0
    Private Sub Complain_Updation_List_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        DT_service_allocated = fill_Contract_In_gridview()
        dgvComplainList.DataSource = fill_ComplainList_In_gridview()
        dgvComplainList.AutoGenerateColumns = True
        dgvComplainList.AllowUserToAddRows = False
        dgvComplainList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvComplainList.Refresh()

    End Sub

    Public Function fill_ComplainList_In_gridview() As DataTable
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
            Dim query As String = "select  com.complain_id,com.comp_date,cu.customer_name,com.comp_info,com.allocate_to,com.comp_status from complain_tbl com,customer_tbl cu
                                where
                                com.customer_id=cu.customer_id"
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

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim comp_updation As New Complain_Register_Form
        comp_updation.complain_id = complain_id
        comp_updation.complain_flag = True
        comp_updation.ShowDialog()

    End Sub

    Private Sub dgvComplainList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComplainList.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If index >= 0 Then
            selectedRow = dgvComplainList.Rows(index)
            complain_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Complain_Updation_List_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgvComplainList.DataSource = fill_ComplainList_In_gridview()
    End Sub
End Class