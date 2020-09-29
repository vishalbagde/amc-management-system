Public Class Dashboard_Complain_Module_Form

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        apply_theme(Me)

    End Sub
    Private Sub btnComplainEntry_Click(sender As Object, e As EventArgs) Handles btnComplainEntry.Click
        pnlOperation.Controls.Clear()
        Complain_Register_Form.ShowDialog()
    End Sub

    Private Sub btnComplainUpdation_Click(sender As Object, e As EventArgs) Handles btnComplainUpdation.Click
        pnlOperation.Controls.Clear()
        Complain_Updation_List_Form.ShowDialog()
    End Sub

    Private Sub btnComplainResolve_Click(sender As Object, e As EventArgs) Handles btnComplainResolve.Click
        Complain_Resolve_List_Form.ShowDialog()
    End Sub

    Private Sub btnComplainStatus_Click(sender As Object, e As EventArgs) Handles btnComplainStatus.Click
        pnlOperation.Controls.Clear()
        Complain_Updation_List_Form.ShowDialog()
    End Sub

    Private Sub Dashboard_Complain_Module_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class