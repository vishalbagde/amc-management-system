<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_Product_Module_Form
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
        Me.btnComplainUpdation = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnComplainEntry = New System.Windows.Forms.Button()
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
        Me.pnlOperation.Location = New System.Drawing.Point(419, 10)
        Me.pnlOperation.Name = "pnlOperation"
        Me.pnlOperation.Size = New System.Drawing.Size(390, 503)
        Me.pnlOperation.TabIndex = 4
        '
        'btnComplainUpdation
        '
        Me.btnComplainUpdation.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnComplainUpdation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComplainUpdation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplainUpdation.ForeColor = System.Drawing.Color.Transparent
        Me.btnComplainUpdation.Location = New System.Drawing.Point(44, 128)
        Me.btnComplainUpdation.Name = "btnComplainUpdation"
        Me.btnComplainUpdation.Size = New System.Drawing.Size(323, 38)
        Me.btnComplainUpdation.TabIndex = 2
        Me.btnComplainUpdation.Text = "Product Master"
        Me.btnComplainUpdation.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(108, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnComplainUpdation)
        Me.Panel3.Controls.Add(Me.btnComplainEntry)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(409, 503)
        Me.Panel3.TabIndex = 3
        '
        'btnComplainEntry
        '
        Me.btnComplainEntry.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnComplainEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComplainEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplainEntry.ForeColor = System.Drawing.Color.Transparent
        Me.btnComplainEntry.Location = New System.Drawing.Point(44, 84)
        Me.btnComplainEntry.Name = "btnComplainEntry"
        Me.btnComplainEntry.Size = New System.Drawing.Size(323, 38)
        Me.btnComplainEntry.TabIndex = 1
        Me.btnComplainEntry.Text = "Product Category Master"
        Me.btnComplainEntry.UseVisualStyleBackColor = False
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
        Me.pnlMain.Size = New System.Drawing.Size(819, 523)
        Me.pnlMain.TabIndex = 5
        '
        'Dashboard_Product_Module_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 523)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Dashboard_Product_Module_Form"
        Me.Text = "Dashboard_Product_Module_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOperation As Panel
    Friend WithEvents btnComplainUpdation As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnComplainEntry As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMain As Panel
End Class
