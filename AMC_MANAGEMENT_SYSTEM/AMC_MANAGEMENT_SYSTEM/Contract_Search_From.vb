Public Class Contract_Search_From
    Dim contract_id As String
    Dim DT_Contract As New DataTable
    Private Sub Contract_Search_From_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        DT_Contract = fill_Contract_In_gridview()
        dgvContractSelect.DataSource = DT_Contract
        dgvContractSelect.AutoGenerateColumns = True
        dgvContractSelect.AllowUserToAddRows = False
        dgvContractSelect.Refresh()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dgvContractSelect_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContractSelect.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If index >= 0 Then
            selectedRow = dgvContractSelect.Rows(index)
            Dim contract_id As String = selectedRow.Cells(1).Value.ToString
            Me.contract_id = contract_id

        End If
    End Sub
    Private Sub txtCustNameOrId_TextChanged(sender As Object, e As EventArgs) Handles txtCustNameOrId.TextChanged
        Dim dv_contract As New DataView(DT_Contract)
        If (rdoCustomerName.Checked) Then
            dv_contract.RowFilter = String.Format("customer_name like '%{0}%'", txtCustNameOrId.Text)
        End If
        dgvContractSelect.DataSource = dv_contract
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If Me.contract_id >= 0 Then
            Contract_Form.shared_contract_id = Me.contract_id
            Contract_Form.shared_contract_select = True
            Me.Close()
        End If
    End Sub
End Class