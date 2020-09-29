Public Class Customer_Search_Form
    Dim customer_id As String
    Dim DT_Customer As New DataTable
    Private Sub Customer_Search_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)
        DT_Customer = fill_Customer_In_gridview()
        dgvCustomerSelect.DataSource = DT_Customer
        dgvCustomerSelect.AutoGenerateColumns = True
        dgvCustomerSelect.AllowUserToAddRows = False
        dgvCustomerSelect.Refresh()

        Dim status_list As New List(Of String)
        status_list.Add("ALL")
        status_list.AddRange(fill_status)
        cbStatus.DataSource = status_list
        cbStatus.SelectedIndex = cbStatus.FindString("All")


        Try
            Dim city_dictionary As New Dictionary(Of String, String)
            city_dictionary.Add("-1", "ALL")
            cbCityName.DisplayMember = "value"
            cbCityName.ValueMember = "key"
            For Each city_name_dictionary In fill_city()
                city_dictionary.Add(city_name_dictionary.Key, city_name_dictionary.Value)
            Next
            cbCityName.DataSource = New BindingSource(city_dictionary, Nothing)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub rdoById_CheckedChanged(sender As Object, e As EventArgs) Handles rdoById.CheckedChanged

        If (rdoByName.Checked) Then
            lblCustNameOrId.Text = "Customer Name :"
        End If

        If rdoById.Checked Then
            lblCustNameOrId.Text = "Customer Id :"
        End If
    End Sub

    Private Sub dgvCustomerSelect_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerSelect.CellContentClick

    End Sub

    Private Sub dgvCustomerSelect_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerSelect.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If index >= 0 Then
            selectedRow = dgvCustomerSelect.Rows(index)
            Dim customer_id As String = selectedRow.Cells(0).Value.ToString
            Me.customer_id = customer_id
        End If


    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Customer_mstr_Form.customer_id = customer_id
        Customer_mstr_Form.customer_select = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtCustNameOrId_TextChanged(sender As Object, e As EventArgs) Handles txtCustNameOrId.TextChanged
        Dim dv_customer As New DataView(DT_Customer)
        If (rdoByName.Checked) Then
            If Not (cbCityName.SelectedValue.Equals("-1")) Then
                dv_customer.RowFilter = String.Format("customer_name like '%{0}%'", txtCustNameOrId.Text) + " AND convert(city_id,System.String) like '%" + cbCityName.SelectedValue.ToString + "%'"
            Else
                dv_customer.RowFilter = String.Format("customer_name like '%{0}%'", txtCustNameOrId.Text)
            End If
        End If
        If (rdoById.Checked) Then
            dv_customer.RowFilter = "convert(customer_id,System.String) like '%" + txtCustNameOrId.Text + "%'" + " AND convert(city_id,System.String) like '%" + cbCityName.SelectedValue.ToString + "%'"
        End If

        dgvCustomerSelect.DataSource = dv_customer

    End Sub
    Private Sub cbCityName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCityName.SelectedIndexChanged
        Dim dv_customer As New DataView(DT_Customer)

        If (cbCityName.SelectedValue.Equals("-1")) Then
            'dv_customer.RowFilter = "convert(city_id,System.String) like '%.*%'"
        Else
            dv_customer.RowFilter = String.Format("customer_name like '%{0}%'", txtCustNameOrId.Text) + "AND convert(city_id,System.String) like '%" + cbCityName.SelectedValue.ToString + "%'"
        End If
        dgvCustomerSelect.DataSource = dv_customer
    End Sub
End Class