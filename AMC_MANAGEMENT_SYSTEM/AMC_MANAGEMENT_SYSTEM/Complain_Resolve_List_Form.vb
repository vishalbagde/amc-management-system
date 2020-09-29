Imports System.Data.SqlClient
Public Class Complain_Resolve_List_Form

    Dim DT_complain_allocated As New DataTable
    Dim con As SqlConnection = MyConnection()
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Dim complain_id As Integer
    Private Sub Complain_Resolve_List_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)
        DT_complain_allocated = fill_Complain_AllocatedList_In_gridview()
        dgvComplainSelect.DataSource = DT_complain_allocated
        dgvComplainSelect.AutoGenerateColumns = True
        dgvComplainSelect.AllowUserToAddRows = False
        dgvComplainSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvComplainSelect.Refresh()
    End Sub

    Private Sub Complain_Resolve_List_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DT_complain_allocated = fill_Complain_AllocatedList_In_gridview()
        dgvComplainSelect.DataSource = DT_complain_allocated
        dgvComplainSelect.Refresh()
    End Sub

    Public Function fill_Complain_AllocatedList_In_gridview() As DataTable
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
            Dim query As String = "select  com.complain_id,com.comp_date,cu.customer_name,com.comp_info,e.emp_name,com.comp_status from complain_tbl com,customer_tbl cu,emp_mstr e
                                    where
                                    com.customer_id=cu.customer_id
                                    and com.allocate_to=e.emp_id
                                    and comp_status ='allocated'"
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
        Dim complain_resolve_form As New Complain_Resolve_Form
        Complain_Resolve_Form.complain_id = complain_id
        Complain_Resolve_Form.complain_resolve_flag = True
        complain_resolve_form.ShowDialog()
    End Sub

    Private Sub dgvComplainSelect_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComplainSelect.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If index >= 0 Then
            selectedRow = dgvComplainSelect.Rows(index)
            complain_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class