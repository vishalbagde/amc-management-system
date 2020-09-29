Imports System.Data.SqlClient
Public Class Report_Product_Consume_Form
    Dim con As SqlConnection = MyConnection()
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Dim DT_Product_Consume As New DataTable
    Private Sub Report_Product_Consume_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        apply_theme(Me)
        cbReportDate.DataSource = New BindingSource(fill_report_date_list_in_cb(), Nothing)
        cbReportDate.ValueMember = "key"
        cbReportDate.DisplayMember = "value"

        mtxtFrom.Text = Date.Now
        mtxtTo.Text = Date.Now
        mtxtFrom.Enabled = False
        mtxtTo.Enabled = False
        Try
            DT_Product_Consume = fill_product_consume_In_gridview()
            dgvProductConsume.DataSource = DT_Product_Consume
            dgvProductConsume.AutoGenerateColumns = True
            dgvProductConsume.AllowUserToAddRows = False
            dgvProductConsume.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgvProductConsume.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Function fill_product_consume_In_gridview() As DataTable
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
            Dim query As String = "select pc.product_id,p.product_name,sum(pc.qty) as Total_Qty from product_consume_tbl pc,product_mstr p
                                   where
                                    pc.product_id=p.product_id
                                    group by pc.product_id,p.product_name"

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


    Public Function fill_product_consume_In_gridview1(ByVal parameter As Integer) As DataTable
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
            Dim query As String = ""
            Dim temp_date As Date = Date.Now
            If parameter = 1 Then


                query = "select pc.product_id,p.product_name,sum(pc.qty) as Total_Qty from product_consume_tbl pc,product_mstr p
                        where
                        pc.product_id=p.product_id
		                and pc.entry_date = '" + Format(temp_date, "MM-dd-yyyy") + "'
                        group by pc.product_id,p.product_name"
            ElseIf parameter = 2 Then
                Dim firstDayOfWeek As Date = getFirstDayOfWeek()
                query = "select pc.product_id,p.product_name,sum(pc.qty) as Total_Qty from product_consume_tbl pc,product_mstr p
                        where
                        pc.product_id=p.product_id
		                and pc.entry_date >= '" + Format(firstDayOfWeek, "MM-dd-yyyy") + "'
                        and pc.entry_Date <= '" + Format(temp_date, "MM-dd-yyyy") + "'
                        group by pc.product_id,p.product_name"
            ElseIf parameter = 3 Then
                Dim startDateofMonth = New DateTime(Now.Year, Now.Month, 1)
                query = "select pc.product_id,p.product_name,sum(pc.qty) as Total_Qty from product_consume_tbl pc,product_mstr p
                        where
                        pc.product_id=p.product_id
		                and pc.entry_date >= '" + Format(startDateofMonth, "MM-dd-yyyy") + "'
                        and pc.entry_Date <= '" + Format(temp_date, "MM-dd-yyyy") + "'
                        group by pc.product_id,p.product_name"
            ElseIf parameter = 4 Then
                Dim startDateofyear As New DateTime(DateTime.Now.Year, 1, 1)
                query = "select pc.product_id,p.product_name,sum(pc.qty) as Total_Qty from product_consume_tbl pc,product_mstr p
                        where
                        pc.product_id=p.product_id
		                and pc.entry_date >= '" + Format(startDateofyear, "MM-dd-yyyy") + "'
                        and pc.entry_Date <= '" + Format(temp_date, "MM-dd-yyyy") + "'
                        group by pc.product_id,p.product_name"
            ElseIf parameter = 5 Then
                Dim fromDate As Date = mtxtFrom.Text
                Dim toDate As Date = mtxtTo.Text
                query = "select pc.product_id,p.product_name,sum(pc.qty) as Total_Qty from product_consume_tbl pc,product_mstr p
                        where
                        pc.product_id=p.product_id
		                and pc.entry_date >= '" + Format(fromDate, "MM-dd-yyyy") + "'
                        and pc.entry_Date <= '" + Format(toDate, "MM-dd-yyyy") + "'
                        group by pc.product_id,p.product_name"
            Else
                query = "select pc.product_id,p.product_name,sum(pc.qty) as Total_Qty from product_consume_tbl pc,product_mstr p
                                   where
                                    pc.product_id=p.product_id
                                    group by pc.product_id,p.product_name"
            End If

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

    Private Sub cbServiceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReportDate.SelectedIndexChanged

    End Sub

    Private Sub cbReportDate_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbReportDate.SelectionChangeCommitted
        If cbReportDate.SelectedItem.key = 5 Then
            mtxtTo.Enabled = True
            mtxtFrom.Enabled = True
        End If

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        mtxtFrom.Enabled = False
        mtxtTo.Enabled = False

        dgvProductConsume.DataSource = fill_product_consume_In_gridview1(cbReportDate.SelectedItem.key)
        dgvProductConsume.Refresh()




    End Sub

    Public Function getFirstDayOfWeek() As Date
        Dim dayOfWeek = CInt(DateTime.Today.DayOfWeek)
        Dim startOfWeek = DateTime.Today.AddDays(-1 * dayOfWeek)
        Return startOfWeek
    End Function

End Class