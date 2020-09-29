Imports System.Data.SqlClient
Imports System.Net

Public Class test
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim dt_product As New DataTable
    Dim update_index As Integer
    Dim flag_update As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        dt_product.Rows.Add(txt1.Text, txt2.Text, txt3.Text)

    End Sub
    Public Sub outstanding_payment_refresh()
        Dim dt As New DataTable
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim deleteQuery As String = "delete from outstanding_payment_tbl"
            cmd.CommandText = deleteQuery
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            con.Dispose()

            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            Dim dr As SqlDataReader
            con.Open()
            Dim selectQuery As String = "select cust_id,sum(sales_amt) payable_amt from contract_tbl
                                        group by cust_id"
            cmd.CommandText = selectQuery
            dr = cmd.ExecuteReader

            dt.Load(dr)
            Dim insertQuery = "INSERT INTO outstanding_payment_tbl(customer_id,payable_amt,receive_amt,outstanding_amt) values "
            For index = 0 To dt.Rows.Count - 1
                insertQuery += "( "
                insertQuery += dt.Rows(index).Item(0).ToString + ","
                insertQuery += dt.Rows(index).Item(1).ToString + ", "
                insertQuery += "0 ,"
                insertQuery += dt.Rows(index).Item(1).ToString + " "
                insertQuery += ") , "
            Next
            insertQuery = insertQuery.Substring(0, insertQuery.Length - 2)

            cmd.Dispose()
            con.Close()
            con.Dispose()

            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = insertQuery
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            con.Dispose()


            Dim dt1 As New DataTable
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            Dim dr1 As SqlDataReader
            con.Open()
            Dim selectQuery1 As String = "select customer_id,sum(pay_amt) receive_amt from payment_tbl
                                            group by customer_id"
            cmd.CommandText = selectQuery1

            dr1 = cmd.ExecuteReader
            dt1.Load(dr1)
            'Dim updateList As New List(Of String)
            Dim updateQuery = ""
            For index = 0 To dt1.Rows.Count - 1
                updateQuery += "update outstanding_payment_tbl"
                updateQuery += " set "
                updateQuery += "receive_amt=" + dt1.Rows(index).Item(1).ToString + " , "
                updateQuery += "outstanding_amt = outstanding_amt - " + dt1.Rows(index).Item(1).ToString + " "
                updateQuery += "where customer_id =" + dt1.Rows(index).Item(0).ToString + " ; "
                'updateList.Add(updateQuery)
            Next
            cmd.Dispose()
            con.Close()
            con.Dispose()


            'update query fire
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = updateQuery
            If cmd.ExecuteNonQuery Then

            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()










        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        outstanding_payment_refresh()


        dt_product.Columns.Add("sr_no")
        dt_product.Columns.Add("product_name")
        dt_product.Columns.Add("product_qty")

        DataGridView1.DataSource = dt_product

        'Try
        '    Dim mydate As Date
        '    mydate = System.DateTime.Now

        '    con = MyConnection()
        '    cmd = New SqlCommand
        '    cmd.Connection = con
        '    con.Open()
        '    Dim sql As String
        '    sql = "INSERT INTO service_tbl(contract_id,service_date,service_status,status) VALUES "

        '    Dim service_year As Integer = 2
        '    Dim total_Service As Integer = 12
        '    Dim contract_id As Integer = 1

        '    Dim add_month As Integer
        '    add_month = (service_year * 12) / total_Service

        '    For i = 1 To total_Service

        '        sql = sql + "('" + contract_id.ToString + "','" + mydate.ToString("MM-dd-yyyy") + "','pending','active'), "
        '        mydate = mydate.AddMonths(2)
        '    Next
        '    sql = sql.Substring(0, sql.Length - 2)
        '    cmd.CommandText = sql
        '    If cmd.ExecuteNonQuery Then
        '        MsgBox("insert successful")
        '    End If

        '    txtyear.Text = sql

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        update_index = index
        Dim selectRow As DataGridViewRow
        If index > 0 Then
            selectRow = DataGridView1.Rows(index)
            txt1.Text = selectRow.Cells(0).Value.ToString
            txt2.Text = selectRow.Cells(1).Value.ToString
            txt3.Text = selectRow.Cells(2).Value.ToString
        End If

    End Sub

    Private Sub rm_Click(sender As Object, e As EventArgs) Handles rm.Click
        Dim selectRow As DataGridViewRow

        selectRow = DataGridView1.Rows(update_index)
        selectRow.Cells(0).Value = txt1.Text
        selectRow.Cells(1).Value = txt2.Text
        selectRow.Cells(2).Value = txt3.Text


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.Remove(DataGridView1.Rows(update_index))

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox(MaskedTextBox1.Text)
        Dim mydate As Date
        mydate = MaskedTextBox1.Text

        MsgBox(Format(mydate, "MM-dd-yyyy"))

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try

            send("7567221144", "9328227731", "hi i am vishal", "7567221144")
            MsgBox("message send successfully......")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub send(uid As String, password As String, message As String, no As String)
        Dim myReq As HttpWebRequest = DirectCast(WebRequest.Create("http://ubaid.tk/sms/sms.aspx?uid=" & uid & "&pwd=" & password & "&msg=" & message & "&phone=" & no & "&provider=way2sms"), HttpWebRequest)
        Dim myResp As HttpWebResponse = DirectCast(myReq.GetResponse(), HttpWebResponse)
        Dim respStreamReader As New System.IO.StreamReader(myResp.GetResponseStream())
        Dim responseString As String = respStreamReader.ReadToEnd()
        respStreamReader.Close()
        myResp.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim mobile As String = "7567221144"
            Dim Password As String = "9328227731"
            Dim strGet As String
            Dim text As String = "this is test sms"
            Dim number As String = "7567221144"
            Dim key As String = "KGID1TFN4Z65NDV0Q96489UCTBOEGK0S"
            Dim url As String = "https://smsapi.engineeringtgr.com/send/?Mobile=" + mobile + "&Password=" + Password + "&Key=" + key + "&Message=" + text + "&To=" + number + ""


            strGet = url + "apikey=" + key _
            + "&numbers=" + number _
            + "&message=" + WebUtility.UrlEncode(text)

            TextBox1.Text = strGet

            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(strGet)
            MessageBox.Show(result, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class