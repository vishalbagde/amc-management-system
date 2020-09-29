Imports System.Data.SqlClient
Public Class Customer_payment_Status_Form
    Dim con As SqlConnection = MyConnection()
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim cust_payment_id As Integer = 0
    Dim dt_customer_payment As New DataTable

    Private Sub Customer_payment_Status_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)

        outstanding_payment_refresh()
        dt_customer_payment = fill_customer_payment_in_gridview()
        dgvCustPaymentDetails.DataSource = dt_customer_payment
        dgvCustPaymentDetails.AutoGenerateColumns = True
        dgvCustPaymentDetails.AllowUserToAddRows = False
        dgvCustPaymentDetails.EnableHeadersVisualStyles = False
        dgvCustPaymentDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustPaymentDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvCustPaymentDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray

        dgvCustPaymentDetails.Columns(0).HeaderCell.Style.Font = New Font("SansSerif", 10, FontStyle.Bold)
        dgvCustPaymentDetails.Columns(1).HeaderCell.Style.Font = New Font("SansSerif", 10, FontStyle.Bold)
        dgvCustPaymentDetails.Columns(2).HeaderCell.Style.Font = New Font("SansSerif", 10, FontStyle.Bold)
        dgvCustPaymentDetails.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvCustPaymentDetails.Refresh()
        display_total()

    End Sub


    Public Function fill_customer_payment_in_gridview() As DataTable
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
            'Dim query As String = "select cust_id,customer_name, sum(sales_amt) Total_Amount
            '                    from contract_tbl co,customer_tbl cu
            '                    where co.cust_id=cu.customer_id 
            '                    and co.status = 'active'
            '                    group by cust_id,customer_name"
            Dim query As String = "select op.customer_id,cust.customer_name,op.payable_amt,
                                op.receive_amt,op.outstanding_amt
                                from outstanding_payment_tbl op,customer_tbl cust
                                where cust.customer_id=op.customer_id"
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
    Private Sub txtCustName_TextChanged(sender As Object, e As EventArgs) Handles txtCustName.TextChanged
        Dim dv_customer_payment As New DataView(dt_customer_payment)
        dv_customer_payment.RowFilter = String.Format("customer_name like '%{0}%'", txtCustName.Text)
        dgvCustPaymentDetails.DataSource = dv_customer_payment
        display_total()
    End Sub
    Public Sub display_total()
        Dim sum As Double = dt_customer_payment.Compute("SUM(payable_amt)", String.Empty)
        Dim sumReceived As Double = dt_customer_payment.Compute("sum(receive_amt)", String.Empty)
        Dim sumOutstanding As Double = dt_customer_payment.Compute("sum(outstanding_amt)", String.Empty)
        lblTotalAmount.Text = sum.ToString("0.00")
        lblTotalRemaining.Text = sumReceived.ToString("0.00")
        lblTotalPending.Text = sumOutstanding.ToString("0.00")
    End Sub
    Private Sub dgvCustPaymentDetails_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustPaymentDetails.CellDoubleClick


    End Sub

    Private Sub dgvCustPaymentDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustPaymentDetails.CellContentClick

    End Sub
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If cust_payment_id > 0 Then
            Customer_Payment_Form.cust_check_id = cust_payment_id
            Customer_Payment_Form.cust_check_flag = True
            Customer_Payment_Form.ShowDialog()
        Else
            MsgBox("plase select Customer First")
        End If
    End Sub
    Private Sub dgvCustPaymentDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustPaymentDetails.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectRow As DataGridViewRow
        selectRow = dgvCustPaymentDetails.Rows(index)
        cust_payment_id = Integer.Parse(selectRow.Cells(0).Value.ToString())
    End Sub
End Class