Imports System.Data.SqlClient
Public Class Login_Form
    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)
        lblError.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtUserName.Text <> "" Or txtPassword.Text <> "" Then
            If check_userDetails(txtUserName.Text, txtPassword.Text) > 0 Then
                Dashboard2.ShowDialog()
                Me.Close()
            Else
                lblError.Text = "invalid Username and Password"
                lblError.Show()
            End If
        Else
            lblError.Text = "Please enter Username and Password"
            lblError.Show()
        End If
    End Sub

    Public Function check_userDetails(ByVal username As String, ByVal password As String) As Integer
        Dim check As Integer
        Dim con As SqlConnection = MyConnection()
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = con
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim query As String = "select count(company_id) from company_mstr where username= '" + txtUserName.Text + "'
            and password = '" + txtPassword.Text + "'"

            cmd.CommandText = query
            check = cmd.ExecuteScalar

            If con.State = ConnectionState.Open Then
                con.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
            con.Close()
            cmd.Dispose()
        End If
        End Try
        Return check
    End Function
End Class