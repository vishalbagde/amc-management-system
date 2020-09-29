<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_Report_Mis_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlOperation = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCustomerWiseDetailsShow = New System.Windows.Forms.Button()
        Me.btnCustomerSearchShow = New System.Windows.Forms.Button()
        Me.btnCustomerMstrShow = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOperation
        '
        Me.pnlOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOperation.Location = New System.Drawing.Point(345, 10)
        Me.pnlOperation.Name = "pnlOperation"
        Me.pnlOperation.Size = New System.Drawing.Size(601, 531)
        Me.pnlOperation.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(62, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MIS Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnCustomerWiseDetailsShow)
        Me.Panel3.Controls.Add(Me.btnCustomerSearchShow)
        Me.Panel3.Controls.Add(Me.btnCustomerMstrShow)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 531)
        Me.Panel3.TabIndex = 3
        '
        'btnCustomerWiseDetailsShow
        '
        Me.btnCustomerWiseDetailsShow.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCustomerWiseDetailsShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerWiseDetailsShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerWiseDetailsShow.ForeColor = System.Drawing.Color.Transparent
        Me.btnCustomerWiseDetailsShow.Location = New System.Drawing.Point(16, 216)
        Me.btnCustomerWiseDetailsShow.Name = "btnCustomerWiseDetailsShow"
        Me.btnCustomerWiseDetailsShow.Size = New System.Drawing.Size(293, 63)
        Me.btnCustomerWiseDetailsShow.TabIndex = 3
        Me.btnCustomerWiseDetailsShow.Text = "Complain Resolve Same Day and Other Day"
        Me.btnCustomerWiseDetailsShow.UseVisualStyleBackColor = False
        '
        'btnCustomerSearchShow
        '
        Me.btnCustomerSearchShow.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCustomerSearchShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerSearchShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerSearchShow.ForeColor = System.Drawing.Color.Transparent
        Me.btnCustomerSearchShow.Location = New System.Drawing.Point(16, 144)
        Me.btnCustomerSearchShow.Name = "btnCustomerSearchShow"
        Me.btnCustomerSearchShow.Size = New System.Drawing.Size(293, 66)
        Me.btnCustomerSearchShow.TabIndex = 2
        Me.btnCustomerSearchShow.Text = "City Wise AMC Sold with Percentage"
        Me.btnCustomerSearchShow.UseVisualStyleBackColor = False
        '
        'btnCustomerMstrShow
        '
        Me.btnCustomerMstrShow.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCustomerMstrShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerMstrShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerMstrShow.ForeColor = System.Drawing.Color.Transparent
        Me.btnCustomerMstrShow.Location = New System.Drawing.Point(16, 74)
        Me.btnCustomerMstrShow.Name = "btnCustomerMstrShow"
        Me.btnCustomerMstrShow.Size = New System.Drawing.Size(293, 65)
        Me.btnCustomerMstrShow.TabIndex = 1
        Me.btnCustomerMstrShow.Text = "Employee Same Day Resolve Service"
        Me.btnCustomerMstrShow.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 59)
        Me.Panel1.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlMain.Controls.Add(Me.Panel1)
        Me.pnlMain.Controls.Add(Me.pnlOperation)
        Me.pnlMain.Controls.Add(Me.Panel3)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Size = New System.Drawing.Size(956, 551)
        Me.pnlMain.TabIndex = 5
        '
        'Dashboard_Report_Mis_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 551)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Dashboard_Report_Mis_Form"
        Me.Text = "Dashboard_Report_Mis_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOperation As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCustomerWiseDetailsShow As Button
    Friend WithEvents btnCustomerSearchShow As Button
    Friend WithEvents btnCustomerMstrShow As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMain As Panel
End Class
