Imports AMC_MANAGEMENT_SYSTEM.Dashboard2
Public Class Dashboard_Customer_Module_Form
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        apply_theme(Me)

    End Sub

    Private Sub Dashboard_Customer_Module_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCustomerMstrShow.Click
        pnlOperation.Controls.Clear()
        Customer_mstr_Form.ShowDialog()


        'pnlOperation.Controls.Clear()
        'Dim frmCustomerMaster As New Customer_mstr_Form()
        ''frmCustomerMaster.WindowState = FormWindowState.Maximized
        'frmCustomerMaster.TopLevel = False
        'pnlOperation.Controls.Add(frmCustomerMaster)
        'frmCustomerMaster.Show()
        ''Customer_mstr_Form.ShowDialog()

    End Sub

    Private Sub btnCustomerSearchShow_Click(sender As Object, e As EventArgs) Handles btnCustomerSearchShow.Click
        Customer_Search_Form.ShowDialog()
    End Sub

    Private Sub btnCustomerMstrShow_CursorChanged(sender As Object, e As EventArgs) Handles btnCustomerMstrShow.CursorChanged
        btnCustomerMstrShow.ForeColor = Color.Blue
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnCustomerPaymentShow_Click(sender As Object, e As EventArgs) Handles btnCustomerPaymentShow.Click
        Customer_Payment_Form.ShowDialog()
    End Sub

    Private Sub CustomerPaymentStatus_Click(sender As Object, e As EventArgs) Handles CustomerPaymentStatus.Click
        Customer_payment_Status_Form.ShowDialog()

    End Sub
End Class