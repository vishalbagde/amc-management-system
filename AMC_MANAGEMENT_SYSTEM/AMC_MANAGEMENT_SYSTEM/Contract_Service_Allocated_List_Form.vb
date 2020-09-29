Imports System.Data.SqlClient
Public Class Contract_Service_Allocated_List_Form
    Dim contract_id As String
    Dim DT_service_allocated As New DataTable
    Dim con As SqlConnection = MyConnection()
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Dim service_id As Integer



    Private Sub Contract_Service_Allocated_List_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        DT_service_allocated = fill_Contract_In_gridview()
        dgvContractSelect.DataSource = fill_service_AllocatedList_In_gridview()
        dgvContractSelect.AutoGenerateColumns = True
        dgvContractSelect.AllowUserToAddRows = False
        dgvContractSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvContractSelect.Refresh()
    End Sub

    Private Sub Contract_Service_Allocated_List_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgvContractSelect.DataSource = fill_service_AllocatedList_In_gridview()
        dgvContractSelect.Refresh()
    End Sub


    Public Function fill_service_AllocatedList_In_gridview() As DataTable
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
            Dim query As String = "select s.service_id,s.service_date,s.service_status,cu.customer_name,cu.address,cu.phone_m,e.emp_name,e.phone as Emp_Phone
                            from service_tbl s,contract_tbl co,customer_tbl cu,emp_mstr e
                            where
                            s.contract_id=co.contract_id and
                            co.cust_id=cu.customer_id and
                            e.emp_id=s.allocate_to
                            and service_status='allocated'"
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

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Form_Module.service_resolve_id = service_id
        service_resolve_flag = True
        Contract_Service_Resolve_Form.ShowDialog()
    End Sub

    Private Sub dgvContractSelect_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContractSelect.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If index >= 0 Then
            selectedRow = dgvContractSelect.Rows(index)
            service_id = Integer.Parse(selectedRow.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged

    End Sub

    Private Sub txtCustNameOrId_TextChanged(sender As Object, e As EventArgs) Handles txtCustNameOrId.TextChanged

    End Sub

    Private Sub lblCustNameOrId_Click(sender As Object, e As EventArgs) Handles lblCustNameOrId.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub rdoByContractID_CheckedChanged(sender As Object, e As EventArgs) Handles rdoByContractID.CheckedChanged

    End Sub

    Private Sub rdoCustomerName_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCustomerName.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvContractSelect_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContractSelect.CellContentClick

    End Sub
End Class