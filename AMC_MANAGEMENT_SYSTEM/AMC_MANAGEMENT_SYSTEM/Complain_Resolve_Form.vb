Imports System.Data.SqlClient

Public Class Complain_Resolve_Form

    Dim con As SqlConnection = MyConnection()
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As New DataTable

    Dim DT_ProductList As New DataTable
    Dim sr_no As Integer = 1
    Dim Update_index As Integer

    Public Shared complain_id As Integer
    Public Shared complain_resolve_flag As Boolean = False
    Private Sub Complain_Resolve_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            apply_theme(Me)

            cbProductId.DataSource = New BindingSource(fill_product_in_cb(), Nothing)
            cbProductId.DisplayMember = "value"
            cbProductId.ValueMember = "key"


            cbEmpId.DataSource = New BindingSource(fill_emp_in_cb(), Nothing)
            cbEmpId.DisplayMember = "value"
            cbEmpId.ValueMember = "key"

            cbEmpId.Enabled = False
            mtxtServiceDate.Text = Date.Now

            txtSrNo.Text = 1
            txtSrNo.Enabled = False


            If btnProductAdd.Text = "Add" Then
                btnProductDelete.Enabled = False
            End If

            DT_ProductList.Columns.Add("SR_NO")
            DT_ProductList.Columns.Add("Product_Name")
            DT_ProductList.Columns.Add("QTY")
            DT_ProductList.Columns.Add("product_id")

            dgvProductList.DataSource = DT_ProductList

            dgvProductList.AutoGenerateColumns = True
            dgvProductList.AllowUserToAddRows = False
            dgvProductList.EnableHeadersVisualStyles = False
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvProductList.RowHeadersVisible = False

            dgvProductList.Columns("product_id").Visible = False

            Dim dgvc As New DataGridViewColumn
            dgvc = dgvProductList.Columns(0)
            dgvc.Width = 20
            dgvc = dgvProductList.Columns(1)
            dgvc.Width = 100
            dgvc = dgvProductList.Columns(2)
            dgvc.Width = 100

            If complain_resolve_flag Then
                complain_resolve_flag = False
                fill_complain_details_in_control(complain_id)

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function fill_product_in_cb() As Dictionary(Of String, String)
        Dim emp As New Dictionary(Of String, String)
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cmd.Connection = con
            con.Open()
            Dim query As String = "SELECT product_id,product_name from product_mstr where status = '" + get_status(1) + "'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            While dr.Read
                emp(dr("product_id").ToString) = dr("product_name")
            End While
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return emp
    End Function

    Private Sub btnProductAdd_Click(sender As Object, e As EventArgs) Handles btnProductAdd.Click
        Dim selectRow As DataGridViewRow
        If (btnProductAdd.Text = "Update") Then
            selectRow = dgvProductList.Rows(Update_index)
            selectRow.Cells(0).Value = txtSrNo.Text
            selectRow.Cells(1).Value = cbProductId.SelectedItem.value
            selectRow.Cells(2).Value = txtQty.Text
            selectRow.Cells(3).Value = cbProductId.SelectedValue.ToString

            btnProductAdd.Text = "Add"

            txtSrNo.Text = sr_no.ToString
            txtQty.Text = 1

        ElseIf btnProductAdd.Text = "Add" Then
            DT_ProductList.Rows.Add(txtSrNo.Text, cbProductId.SelectedItem.value, txtQty.Text, cbProductId.SelectedValue.ToString)
            sr_no = sr_no + 1
            txtSrNo.Text = sr_no.ToString
        End If
    End Sub

    Private Sub btnProductDelete_Click(sender As Object, e As EventArgs) Handles btnProductDelete.Click
        dgvProductList.Rows.Remove(dgvProductList.Rows(Update_index))
        btnProductDelete.Enabled = False

        For rowIndex As Integer = Update_index To dgvProductList.Rows.Count - 1
            dgvProductList.Rows(rowIndex).Cells(0).Value = Integer.Parse(dgvProductList.Rows(rowIndex).Cells(0).Value) - 1
        Next

        sr_no = sr_no - 1
        txtSrNo.Text = sr_no.ToString
        btnProductAdd.Text = "Add"
    End Sub

    Private Sub dgvProductList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductList.CellClick
        Dim index As Integer = e.RowIndex
        Update_index = index
        Dim selectRow As DataGridViewRow
        If index >= 0 Then
            selectRow = dgvProductList.Rows(index)
            txtSrNo.Text = selectRow.Cells(0).Value.ToString
            cbProductId.SelectedIndex = cbProductId.FindString(selectRow.Cells(1).Value.ToString)
            txtQty.Text = selectRow.Cells(2).Value.ToString
            btnProductAdd.Text = "Update"
            btnProductDelete.Enabled = True
        End If
    End Sub
    Public Sub fill_complain_details_in_control(ByVal complain_id As String)
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()

            Dim query As String = "select  com.complain_id,com.comp_date,com.comp_time,com.remark,cu.customer_name,cu.address,com.comp_info,emp_name,com.comp_status from complain_tbl com,customer_tbl cu,emp_mstr e
                                where
                                com.customer_id=cu.customer_id
                                and com.allocate_to=e.emp_id
                                and comp_status ='allocated'
                                and complain_id=" + complain_id.ToString

            cmd.CommandText = query
            dr = cmd.ExecuteReader

            If dr.Read Then
                lblDSerDateTime.Text = dr("comp_date") + " " + dr("comp_time")
                lblDCustName.Text = dr("customer_name")
                lblDCustAddress.Text = dr("address")
                lblDWorkDetails.Text = dr("comp_info")
                lblDOtherDetails.Text = dr("remark")
                cbEmpId.SelectedIndex = cbEmpId.FindString(dr("emp_name"))
                lblCompStatus.Text = dr("comp_status")
                lblCompStatus.BackColor = Color.Green
                lblCompStatus.ForeColor = Color.White




            Else
                MsgBox("complain not found")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If ConnectionState.Open = con.State Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvProductList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductList.CellContentClick

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim updateQuery As String = "UPDATE complain_tbl set 
                    allocate_to=@allocate_to,
                    solve_date=@solve_date,            
                    work_info=@work_info,
                    resolve_remark=@resolve_remark,
                    comp_status=@comp_status,
                    amount_charge=@amount_charge
                    where complain_id=@complain_id"
            cmd.CommandText = updateQuery

            Dim complain_solve_date As Date = mtxtServiceDate.Text
            Dim complain_status As String = "resolved"
            cmd.Parameters.Add(New SqlParameter("solve_date", Format(complain_solve_date, "MM-dd-yyyy")))
            cmd.Parameters.Add(New SqlParameter("allocate_to", Integer.Parse(cbEmpId.SelectedValue.ToString)))
            cmd.Parameters.Add(New SqlParameter("work_info", txtWorkDetails.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("resolve_remark", txtRemark.Text.Replace(vbNewLine, "~")))
            cmd.Parameters.Add(New SqlParameter("comp_status", complain_status))
            cmd.Parameters.Add(New SqlParameter("amount_charge", txtAmtCharge.Text))

            cmd.Parameters.Add(New SqlParameter("complain_id", complain_id))

            If cmd.ExecuteNonQuery Then
                MsgBox("complain Resolved sucessful Updated")
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()

            If dgvProductList.RowCount > 0 Then
                Dim str As String = "INSERT INTO product_consume_tbl(complain_id,sr_no,product_id,qty,status) values "
                For i = 0 To dgvProductList.RowCount - 1
                    str = str + "( "
                    str = str + complain_id.ToString + ", "
                    str = str + dgvProductList.Rows(i).Cells(0).Value + " , "
                    str = str + dgvProductList.Rows(i).Cells(3).Value + " , "
                    str = str + dgvProductList.Rows(i).Cells(2).Value + " , "
                    str = str + "'" + get_status(1) + "') ,"

                Next
                str = str.Substring(0, str.Length - 1)

                con = MyConnection()
                cmd = New SqlCommand
                cmd.Connection = con
                con.Open()

                cmd.CommandText = str
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Product Consume insert successful")
                End If
                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                    con.Dispose()
                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If

        End Try
    End Sub
End Class