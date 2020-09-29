<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_Customer_Module_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CustomerPaymentStatus = New System.Windows.Forms.Button()
        Me.btnCustomerPaymentShow = New System.Windows.Forms.Button()
        Me.btnCustomerSearchShow = New System.Windows.Forms.Button()
        Me.btnCustomerMstrShow = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlOperation = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(80, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CustomerPaymentStatus)
        Me.Panel3.Controls.Add(Me.btnCustomerPaymentShow)
        Me.Panel3.Controls.Add(Me.btnCustomerSearchShow)
        Me.Panel3.Controls.Add(Me.btnCustomerMstrShow)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(409, 644)
        Me.Panel3.TabIndex = 3
        '
        'CustomerPaymentStatus
        '
        Me.CustomerPaymentStatus.BackColor = System.Drawing.Color.DarkSlateGray
        Me.CustomerPaymentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CustomerPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerPaymentStatus.ForeColor = System.Drawing.Color.Transparent
        Me.CustomerPaymentStatus.Location = New System.Drawing.Point(44, 216)
        Me.CustomerPaymentStatus.Name = "CustomerPaymentStatus"
        Me.CustomerPaymentStatus.Size = New System.Drawing.Size(323, 38)
        Me.CustomerPaymentStatus.TabIndex = 5
        Me.CustomerPaymentStatus.Text = "Customer Payment Status"
        Me.CustomerPaymentStatus.UseVisualStyleBackColor = False
        '
        'btnCustomerPaymentShow
        '
        Me.btnCustomerPaymentShow.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCustomerPaymentShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerPaymentShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerPaymentShow.ForeColor = System.Drawing.Color.Transparent
        Me.btnCustomerPaymentShow.Location = New System.Drawing.Point(44, 172)
        Me.btnCustomerPaymentShow.Name = "btnCustomerPaymentShow"
        Me.btnCustomerPaymentShow.Size = New System.Drawing.Size(323, 38)
        Me.btnCustomerPaymentShow.TabIndex = 4
        Me.btnCustomerPaymentShow.Text = "Customer Payment"
        Me.btnCustomerPaymentShow.UseVisualStyleBackColor = False
        '
        'btnCustomerSearchShow
        '
        Me.btnCustomerSearchShow.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCustomerSearchShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerSearchShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerSearchShow.ForeColor = System.Drawing.Color.Transparent
        Me.btnCustomerSearchShow.Location = New System.Drawing.Point(44, 128)
        Me.btnCustomerSearchShow.Name = "btnCustomerSearchShow"
        Me.btnCustomerSearchShow.Size = New System.Drawing.Size(323, 38)
        Me.btnCustomerSearchShow.TabIndex = 2
        Me.btnCustomerSearchShow.Text = "Customer Search"
        Me.btnCustomerSearchShow.UseVisualStyleBackColor = False
        '
        'btnCustomerMstrShow
        '
        Me.btnCustomerMstrShow.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCustomerMstrShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerMstrShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerMstrShow.ForeColor = System.Drawing.Color.Transparent
        Me.btnCustomerMstrShow.Location = New System.Drawing.Point(44, 84)
        Me.btnCustomerMstrShow.Name = "btnCustomerMstrShow"
        Me.btnCustomerMstrShow.Size = New System.Drawing.Size(323, 38)
        Me.btnCustomerMstrShow.TabIndex = 1
        Me.btnCustomerMstrShow.Text = "Customer Master"
        Me.btnCustomerMstrShow.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(14, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 59)
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
        Me.pnlMain.Size = New System.Drawing.Size(977, 664)
        Me.pnlMain.TabIndex = 2
        '
        'pnlOperation
        '
        Me.pnlOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOperation.Location = New System.Drawing.Point(419, 10)
        Me.pnlOperation.Name = "pnlOperation"
        Me.pnlOperation.Size = New System.Drawing.Size(548, 644)
        Me.pnlOperation.TabIndex = 4
        '
        'Dashboard_Customer_Module_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 664)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Dashboard_Customer_Module_Form"
        Me.Text = "Dashboard_Customer_Module_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnCustomerMstrShow As Button
    Friend WithEvents btnCustomerSearchShow As Button
    Friend WithEvents btnCustomerPaymentShow As Button
    Friend WithEvents CustomerPaymentStatus As Button
    Friend WithEvents pnlOperation As Panel
End Class
