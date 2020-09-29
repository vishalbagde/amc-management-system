Imports System.Data.SqlClient
Public Class Dashboard
    Dim con As SqlConnection
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_theme(Me)
        'Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        con = MyConnection()
        If con.State = ConnectionState.Closed Then
            MsgBox("connection state is close")
        End If
    End Sub

    Private Sub CityDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CityDetailsToolStripMenuItem.Click
        City_Mstr_Form.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PincodeDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PincodeDetailsToolStripMenuItem.Click
        Pincode_Mstr_Form.ShowDialog()
    End Sub

    Private Sub CustomerWiseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerWiseAllToolStripMenuItem.Click

    End Sub

    Private Sub CustomerMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerMasterToolStripMenuItem.Click
        Customer_mstr_Form.ShowDialog()
    End Sub

    Private Sub CategoryDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryDetailsToolStripMenuItem.Click
        Category_Mstr_Form.ShowDialog()
    End Sub

    Private Sub ProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductDetailsToolStripMenuItem.Click
        Product_Mstr_Form.ShowDialog()
    End Sub

    Private Sub AMCDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMCDetailsToolStripMenuItem.Click
        Amc_Mstr_Form.ShowDialog()
    End Sub

    Private Sub EmployeeDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        Emp_Mstr_Form.ShowDialog()
    End Sub

    Private Sub InstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallToolStripMenuItem.Click

    End Sub

    Private Sub CustomerPaymentStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerPaymentStatusToolStripMenuItem.Click
        Customer_payment_Status_Form.ShowDialog()
    End Sub

    Private Sub CustomerPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerPaymentToolStripMenuItem.Click
        Customer_Payment_Form.ShowDialog()
    End Sub

    Private Sub ServiceContractToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceContractToolStripMenuItem.Click
        Contract_Form.ShowDialog()
    End Sub

    Private Sub ServiceDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceDetailsToolStripMenuItem.Click
        Contract_Search_From.ShowDialog()
    End Sub

    Private Sub ServiceAllocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceAllocationToolStripMenuItem.Click
        Contract_Service_Form.ShowDialog()
    End Sub

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        Contract_Service_Allocation_Form.ShowDialog()
    End Sub

    Private Sub ServiceResolvedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceResolvedToolStripMenuItem.Click
        Contract_Service_Allocated_List_Form.ShowDialog()
    End Sub

    Private Sub ComplainEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplainEntryToolStripMenuItem.Click
        Complain_Register_Form.ShowDialog()
    End Sub

    Private Sub ComplainUpdationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplainUpdationToolStripMenuItem.Click
        Complain_Updation_List_Form.ShowDialog()
    End Sub

    Private Sub ComplainResolveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplainResolveToolStripMenuItem.Click
        Complain_Resolve_List_Form.ShowDialog()
    End Sub

    Private Sub ProductConsumeReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductConsumeReportToolStripMenuItem.Click
        Report_Product_Consume_Form.ShowDialog()
    End Sub

    Private Sub CompanyDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyDetailsToolStripMenuItem.Click
        Company_Details_Form.ShowDialog()
    End Sub

    Private Sub ComplainStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplainStatusToolStripMenuItem.Click

    End Sub
End Class
