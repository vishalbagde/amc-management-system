Public Class Dashboard_Report_Tps_Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        apply_theme(Me)
    End Sub

    Private Sub Dashboard_Report_Tps_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCustomerMstrShow_Click(sender As Object, e As EventArgs) Handles btnCustomerMstrShow.Click
        Report_Product_Consume_Form.ShowDialog()

    End Sub

    Private Sub btnCustomerSearchShow_Click(sender As Object, e As EventArgs) Handles btnCustomerSearchShow.Click
        Report_Product_Consume_Service_Wise_Form.ShowDialog()
    End Sub

    Private Sub btnCustomerWiseDetailsShow_Click(sender As Object, e As EventArgs) Handles btnCustomerWiseDetailsShow.Click
        Report_Product_Consume_ServiceAndComplain_WiseGroupBy_Form.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Report_Amc_Details_Form.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Report_City_Wise_Amc_Details_Form.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Customer_Payment_Details_Form.ShowDialog()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Report_Complain_Details_Form.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Report_Complain_Details_Form.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Customer_Payment_Details_Form.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Report_Customer_Details_Form.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Report_Customer_Details_With_Amc_Form.ShowDialog()
    End Sub
End Class