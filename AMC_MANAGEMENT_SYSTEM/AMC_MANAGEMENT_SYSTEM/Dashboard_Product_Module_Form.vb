Public Class Dashboard_Product_Module_Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        apply_theme(Me)

    End Sub
    Private Sub btnComplainEntry_Click(sender As Object, e As EventArgs) Handles btnComplainEntry.Click
        pnlOperation.Controls.Clear()
        Category_Mstr_Form.ShowDialog()
    End Sub

    Private Sub btnComplainUpdation_Click(sender As Object, e As EventArgs) Handles btnComplainUpdation.Click
        pnlOperation.Controls.Clear()
        Product_Mstr_Form.ShowDialog()
    End Sub

    Private Sub Dashboard_Product_Module_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class