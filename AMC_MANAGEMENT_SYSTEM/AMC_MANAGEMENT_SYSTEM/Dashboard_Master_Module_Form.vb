Public Class Dashboard_Master_Module_Form
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        apply_theme(Me)
    End Sub
    Private Sub btnPincodeMaster_Click(sender As Object, e As EventArgs) Handles btnPincodeMaster.Click
        pnlOperation.Controls.Clear()
        Pincode_Mstr_Form.ShowDialog()
    End Sub

    Private Sub btnCityMaster_Click(sender As Object, e As EventArgs) Handles btnCityMaster.Click
        pnlOperation.Controls.Clear()
        City_Mstr_Form.ShowDialog()
    End Sub

    Private Sub btnCategoryMaster_Click(sender As Object, e As EventArgs) Handles btnCategoryMaster.Click
        pnlOperation.Controls.Clear()
        Category_Mstr_Form.ShowDialog()
    End Sub

    Private Sub btnProductMaster_Click(sender As Object, e As EventArgs) Handles btnProductMaster.Click
        pnlOperation.Controls.Clear()
        Product_Mstr_Form.ShowDialog()
    End Sub

    Private Sub btnEmpMaster_Click(sender As Object, e As EventArgs) Handles btnEmpMaster.Click
        pnlOperation.Controls.Clear()
        Emp_Mstr_Form.ShowDialog()
    End Sub

    Private Sub btnAmcDetails_Click(sender As Object, e As EventArgs) Handles btnAmcDetails.Click
        pnlOperation.Controls.Clear()
        Amc_Mstr_Form.ShowDialog()
    End Sub

End Class