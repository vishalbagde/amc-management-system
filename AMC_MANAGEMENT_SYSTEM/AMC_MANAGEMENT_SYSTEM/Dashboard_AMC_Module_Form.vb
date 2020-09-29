Public Class Dashboard_AMC_Module_Form
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        apply_theme(Me)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Dashboard_AMC_Module_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnContractShow_Click(sender As Object, e As EventArgs) Handles btnContractShow.Click
        pnlOperation.Controls.Clear()
        Contract_Form.ShowDialog()
    End Sub

    Private Sub btnContractDetails_Click(sender As Object, e As EventArgs) Handles btnContractDetails.Click
        pnlOperation.Controls.Clear()
        Contract_Search_From.ShowDialog()
    End Sub

    Private Sub btnServiceContractUpdation_Click(sender As Object, e As EventArgs) Handles btnServiceContractUpdation.Click
        pnlOperation.Controls.Clear()
        Contract_Service_Form.ShowDialog()
    End Sub

    Private Sub btnServiceContractAllocate_Click(sender As Object, e As EventArgs) Handles btnServiceContractAllocate.Click
        pnlOperation.Controls.Clear()
        Contract_Service_Allocation_Form.ShowDialog()
    End Sub

    Private Sub btnServiceContractResolve_Click(sender As Object, e As EventArgs) Handles btnServiceContractResolve.Click
        pnlOperation.Controls.Clear()
        Contract_Service_Allocated_List_Form.ShowDialog()
    End Sub

    Private Sub btnAmcMaster_Click(sender As Object, e As EventArgs) Handles btnAmcMaster.Click
        pnlOperation.Controls.Clear()
        Amc_Mstr_Form.ShowDialog()
    End Sub

    Private Sub btnServiceReminder_Click(sender As Object, e As EventArgs) Handles btnServiceReminder.Click
        pnlOperation.Controls.Clear()
        Contract_Service_reminder_Form.ShowDialog()
    End Sub
End Class