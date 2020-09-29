Public Class Dashboard2

    Private Sub Dashboard2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        apply_theme(Me)

        pnlModuleItemList.Controls.Clear()
        pnlModuleItemList.Refresh()
        Dim frmCustModule As New Dashboard_Home_Module_Form()
        frmCustModule.TopLevel = False
        pnlModuleItemList.Controls.Add(frmCustModule)
        pnlModuleItemList.Refresh()
        frmCustModule.Show()


    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Public Sub showPanel(ByVal btnName As String)
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'pnlModuleItemList.Controls.Clear()
        'Contract_Form.ShowDialog()

        pnlModuleItemList.Controls.Clear()
        pnlModuleItemList.Refresh()
        Dim frmCustModule As New Dashboard_AMC_Module_Form()
        frmCustModule.TopLevel = False
        pnlModuleItemList.Controls.Add(frmCustModule)
        pnlModuleItemList.Refresh()
        frmCustModule.Show()
    End Sub
    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncustomer.Click
        pnlModuleItemList.Controls.Clear()
        pnlModuleItemList.Refresh()
        Dim fromOpenInPanel As New Dashboard_Customer_Module_Form
        fromOpenInPanel.TopLevel = False
        pnlModuleItemList.Controls.Add(fromOpenInPanel)
        pnlModuleItemList.Refresh()
        fromOpenInPanel.Show()

        'pnlModuleItemList.Controls.Clear()
        'Customer_mstr_Form.ShowDialog()
    End Sub

    Public Sub clearControlFromPanel()
        'Dim ctrl As Control = Nothing
        'For i As Integer = pnlModuleItemList.Controls.Count - 1 To 0
        '    ctrl = Me.pnlModuleItemList.Controls(i)
        '    Me.pnlModuleItemList.Controls.Remove(ctrl)
        '    ctrl.Dispose()
        'Next
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlModuleItemList.Controls.Clear()
        Dim frmOpenInPanel As New Dashboard_Home_Module_Form
        frmOpenInPanel.TopLevel = False
        pnlModuleItemList.Controls.Add(frmOpenInPanel)
        frmOpenInPanel.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btncomplain_Click(sender As Object, e As EventArgs) Handles btncomplain.Click
        pnlModuleItemList.Controls.Clear()
        Dim frmOpenInPanel As New Dashboard_Complain_Module_Form
        frmOpenInPanel.TopLevel = False
        pnlModuleItemList.Controls.Add(frmOpenInPanel)
        frmOpenInPanel.Show()
    End Sub

    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click
        pnlModuleItemList.Controls.Clear()
        Dim frmOpenInPanel As New Dashboard_Product_Module_Form
        frmOpenInPanel.TopLevel = False
        pnlModuleItemList.Controls.Add(frmOpenInPanel)
        frmOpenInPanel.Show()
    End Sub

    Private Sub btnemployee_Click(sender As Object, e As EventArgs) Handles btnemployee.Click
        pnlModuleItemList.Controls.Clear()
        Emp_Mstr_Form.ShowDialog()
    End Sub

    Private Sub btnmaster_Click(sender As Object, e As EventArgs) Handles btnmaster.Click
        pnlModuleItemList.Controls.Clear()
        Dim frmOpenInPanel As New Dashboard_Master_Module_Form
        frmOpenInPanel.TopLevel = False
        pnlModuleItemList.Controls.Add(frmOpenInPanel)
        frmOpenInPanel.Show()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        pnlModuleItemList.Controls.Clear()
        Dim frmOpenInPanel As New Dashboard_Report_Tps_Form
        frmOpenInPanel.TopLevel = False
        pnlModuleItemList.Controls.Add(frmOpenInPanel)
        frmOpenInPanel.Show()
    End Sub

    Private Sub btnmis_Click(sender As Object, e As EventArgs) Handles btnmis.Click
        pnlModuleItemList.Controls.Clear()
        Dim frmOpenInPanel As New Dashboard_Report_Mis_Form
        frmOpenInPanel.TopLevel = False
        pnlModuleItemList.Controls.Add(frmOpenInPanel)
        frmOpenInPanel.Show()
    End Sub

    'Public Function getModulePanel() As Panel
    '    Return pnlModuleForm
    'End Function
End Class