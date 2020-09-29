Imports System.Data.SqlClient
Public Class Customer_Payment_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim total_payment As Double
    Dim payment_pay As Double
    Dim pending_payment As Double
    Public Shared cust_check_id As Integer
    Public Shared cust_check_flag As Boolean = False
    Private Sub Customer_Payment_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)
        Try
            cbCustId.DataSource = New BindingSource(fill_customer_in_cb(), Nothing)
            cbCustId.DisplayMember = "value"
            cbCustId.ValueMember = "key"
            mtxtPaymentDate.Text = Date.Now

            cbReceviedBy.DataSource = New BindingSource(fill_emp_in_cb(), Nothing)
            cbReceviedBy.DisplayMember = "value"
            cbReceviedBy.ValueMember = "key"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If rdoCash.Checked Then
            txtChequeNumber.Enabled = False
        End If

    End Sub

    Private Sub cbCustId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCustId.SelectionChangeCommitted
        cbCustId.Enabled = False
        fill_amount_in_lable()

    End Sub

    Public Sub refresh_control()
        cbCustId.Enabled = True
        txtPaymentAmount.Text = ""
        txtChequeNumber.Text = ""
        txtRemark.Text = ""
        mtxtPaymentDate.Text = Date.Now
        lblPayment.Text = ""
        lblTotal.Text = ""
        lblPending.Text = ""

    End Sub

    Public Function get_total_amount(ByVal cust_id As String) As String
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim total_amount As Integer = 0
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "select sum(sales_amt) from contract_tbl 
                                    where cust_id = " + cust_id + "
                                    group by cust_id"
            cmd.CommandText = query
            total_amount = CInt(cmd.ExecuteScalar)
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return total_amount
    End Function

    Public Function get_total_pay_amount(ByVal cust_id As String) As String
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim total_amount As Integer = 0
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "select sum(pay_amt) from payment_tbl
                                    where customer_id = " + cust_id + "
                                    group by customer_id"
            cmd.CommandText = query
            total_amount = CInt(cmd.ExecuteScalar)
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return total_amount
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_control()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub rdoCheque_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCheque.CheckedChanged
        If rdoCheque.Checked Then
            txtChequeNumber.Enabled = True
        End If

    End Sub

    Private Sub rdoCash_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCash.CheckedChanged
        If rdoCash.Checked Then
            txtChequeNumber.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim payment_mode As String = ""
            If rdoCash.Checked Then
                payment_mode = "cash"
            ElseIf rdoCheque.Checked Then
                payment_mode = "cheque"
            End If

            Dim payment_date As Date = mtxtPaymentDate.Text
            cmd.CommandText = "INSERT INTO payment_tbl(customer_id,payment_mode,cheque_no,pay_amt,received_by,payment_date,remark,status) values (@customer_id,@payment_mode,@cheque_no,@pay_amt,@received_by,@payment_date,@remark,@status); SELECT SCOPE_IDENTITY()"
            cmd.Parameters.Add(New SqlParameter("customer_id", Integer.Parse(cbCustId.SelectedValue.ToString)))
            cmd.Parameters.Add(New SqlParameter("payment_mode", payment_mode))
            cmd.Parameters.Add(New SqlParameter("cheque_no", txtChequeNumber.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("pay_amt", txtPaymentAmount.Text.ToString))
            cmd.Parameters.Add(New SqlParameter("received_by", cbReceviedBy.SelectedValue().ToString))
            cmd.Parameters.Add(New SqlParameter("payment_date", Format(payment_date, "MM-dd-yyyy")))
            cmd.Parameters.Add(New SqlParameter("remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("status", get_status(1).ToString))


            Dim insert_payment_id As Integer = CInt(cmd.ExecuteScalar())
            If insert_payment_id > 0 Then
                MsgBox("Payment make Success Payment id is " + insert_payment_id.ToString)
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()
            refresh_control()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub
    Public Sub fill_amount_in_lable()
        total_payment = Double.Parse(get_total_amount(cbCustId.SelectedValue().ToString))
        payment_pay = Double.Parse(get_total_pay_amount(cbCustId.SelectedValue().ToString))

        lblTotal.Text = "[ " + total_payment.ToString + " ]"
        If (total_payment - payment_pay) > 0 Then
            lblPending.BackColor = Color.Red
        Else
            lblPending.BackColor = Color.White
        End If
        lblPending.Text = "[" + (total_payment - payment_pay).ToString + " ]"
        lblPayment.Text = "[ " + payment_pay.ToString + " ]"
    End Sub
    Private Sub Customer_Payment_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If cust_check_flag Then
            cbCustId.SelectedIndex = cbCustId.FindString(get_cust_name(cust_check_id).ToString)
            cust_check_flag = False
            fill_amount_in_lable()
            cbCustId.Enabled = False
        End If
    End Sub
End Class