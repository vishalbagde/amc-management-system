Imports System.Data.SqlClient
Imports System.IO
Public Class Company_Details_Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim company_id As String

    Private Sub Company_Details_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        apply_theme(Me)
        btnUpdate.Enabled = False
        btnAdd.Enabled = False

        fill_company_in_control()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            With OpenFileDialog1
                .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            End With
            With pbCompanyLogo
                .BackgroundImage = Image.FromFile(Me.OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.AutoSize
            End With

            lbLogoName.Text = OpenFileDialog1.FileName.ToString
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "INSERT INTO company_mstr(company_name,address,phone_r,phone_p,gst_no,pan_no,company_logo,email,website)
                        VALUES(@company_name,@address,@phone_r,@phone_p,@gst_no,@pan_no,@company_logo,@email,@website)"
            cmd.Parameters.AddWithValue("@company_name", txtCompanyName.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@phone_r", txtPhoneR.Text)
            cmd.Parameters.AddWithValue("@phone_p", txtPhoneM.Text)
            cmd.Parameters.AddWithValue("@gst_no", txtGstNo.Text)
            cmd.Parameters.AddWithValue("@pan_no", txtPanNo.Text)
            Dim ms As New MemoryStream()
            pbCompanyLogo.BackgroundImage.Save(ms, pbCompanyLogo.BackgroundImage.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            cmd.Parameters.AddWithValue("@company_logo", data)

            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@website", txtWebsite.Text)


            If cmd.ExecuteNonQuery Then
                MsgBox("Company Details Insert Successful")

            End If
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
                con.Dispose()
            End If
            fill_company_in_control()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If ConnectionState.Open = con.State Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub

    Public Sub fill_company_in_control()
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            Dim query As String = "select * from company_mstr"
            cmd.CommandText = query
            dr = cmd.ExecuteReader
            If dr.Read Then
                btnUpdate.Enabled = True
                company_id = dr("company_id")
                txtCompanyName.Text = dr("company_name")
                txtAddress.Text = dr("address")
                txtPicode.Text = ""
                txtPhoneR.Text = dr("phone_r")
                txtPhoneM.Text = dr("phone_p")
                txtEmail.Text = dr("email")
                txtGstNo.Text = dr("gst_no")
                txtPanNo.Text = dr("pan_no")
                txtWebsite.Text = dr("website")

                'Dim imageData As Byte() = DirectCast(dr("company_logo"), Byte())
                'If Not imageData Is Nothing Then
                'Using ms As New MemoryStream(imageData, 0, imageData.Length)
                'MS.Write(imageData, 0, imageData.Length)
                'pbCompanyLogo.BackgroundImage = Image.FromStream(ms, True)
                'End Using
                'End If
                pbCompanyLogo.BackgroundImage = Image.FromStream(New IO.MemoryStream(CType(dr("company_logo"), Byte())))

                If con.State = ConnectionState.Open Then
                    cmd.Dispose()
                    con.Close()
                    con.Dispose()
                End If
            Else
                btnAdd.Enabled = True
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = MyConnection()
            cmd = New SqlCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "UPDATE company_mstr set
                        company_name=@company_name, address=@address,phone_r=@phone_r,phone_p=@phone_p,gst_no=@gst_no,pan_no=@pan_no,company_logo=@company_logo,email=@email,website=@website"
            cmd.Parameters.AddWithValue("@company_name", txtCompanyName.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@phone_r", txtPhoneR.Text)
            cmd.Parameters.AddWithValue("@phone_p", txtPhoneM.Text)
            cmd.Parameters.AddWithValue("@gst_no", txtGstNo.Text)
            cmd.Parameters.AddWithValue("@pan_no", txtPanNo.Text)
            Dim ms As New MemoryStream()
            pbCompanyLogo.BackgroundImage.Save(ms, pbCompanyLogo.BackgroundImage.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            cmd.Parameters.AddWithValue("@company_logo", data)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@website", txtWebsite.Text)

            If cmd.ExecuteNonQuery Then
                MsgBox("Update Successful Successful")

            End If
            If con.State = ConnectionState.Open Then
                cmd.Dispose()
                con.Close()
                con.Dispose()
            End If
            fill_company_in_control()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If ConnectionState.Open = con.State Then
                cmd.Dispose()
                con.Close()
            End If
        End Try
    End Sub
End Class