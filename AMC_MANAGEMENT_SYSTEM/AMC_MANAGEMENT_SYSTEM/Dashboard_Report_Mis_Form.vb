Public Class Dashboard_Report_Mis_Form

    Public Sub New()

        'This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        apply_theme(Me)

    End Sub

    Private Sub btnCustomerMstrShow_Click(sender As Object, e As EventArgs) Handles btnCustomerMstrShow.Click
        Report_Emp_On_Date_Service_Resolve_Form.ShowDialog()
    End Sub

    Private Sub btnCustomerSearchShow_Click(sender As Object, e As EventArgs) Handles btnCustomerSearchShow.Click
        Report_City_Wise_Amc_Details_Form.ShowDialog()
    End Sub

    Private Sub Dashboard_Report_Mis_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCustomerWiseDetailsShow_Click(sender As Object, e As EventArgs) Handles btnCustomerWiseDetailsShow.Click
        Complain_On_Day_Resolve_Form_Form.ShowDialog()
    End Sub
End Class