<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_AMC_Module_Form
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
        Me.btnContractDetails = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAmcMaster = New System.Windows.Forms.Button()
        Me.btnServiceContractResolve = New System.Windows.Forms.Button()
        Me.btnServiceContractAllocate = New System.Windows.Forms.Button()
        Me.btnServiceContractUpdation = New System.Windows.Forms.Button()
        Me.btnContractShow = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlOperation = New System.Windows.Forms.Panel()
        Me.btnServiceReminder = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnContractDetails
        '
        Me.btnContractDetails.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnContractDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnContractDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContractDetails.ForeColor = System.Drawing.Color.Transparent
        Me.btnContractDetails.Location = New System.Drawing.Point(44, 180)
        Me.btnContractDetails.Name = "btnContractDetails"
        Me.btnContractDetails.Size = New System.Drawing.Size(323, 38)
        Me.btnContractDetails.TabIndex = 2
        Me.btnContractDetails.Text = "Contract Details"
        Me.btnContractDetails.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(108, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AMC Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnServiceReminder)
        Me.Panel3.Controls.Add(Me.btnAmcMaster)
        Me.Panel3.Controls.Add(Me.btnServiceContractResolve)
        Me.Panel3.Controls.Add(Me.btnServiceContractAllocate)
        Me.Panel3.Controls.Add(Me.btnServiceContractUpdation)
        Me.Panel3.Controls.Add(Me.btnContractDetails)
        Me.Panel3.Controls.Add(Me.btnContractShow)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(409, 582)
        Me.Panel3.TabIndex = 3
        '
        'btnAmcMaster
        '
        Me.btnAmcMaster.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAmcMaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAmcMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmcMaster.ForeColor = System.Drawing.Color.Transparent
        Me.btnAmcMaster.Location = New System.Drawing.Point(42, 91)
        Me.btnAmcMaster.Name = "btnAmcMaster"
        Me.btnAmcMaster.Size = New System.Drawing.Size(323, 38)
        Me.btnAmcMaster.TabIndex = 6
        Me.btnAmcMaster.Text = "AMC Scheme Master"
        Me.btnAmcMaster.UseVisualStyleBackColor = False
        '
        'btnServiceContractResolve
        '
        Me.btnServiceContractResolve.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnServiceContractResolve.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnServiceContractResolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceContractResolve.ForeColor = System.Drawing.Color.Transparent
        Me.btnServiceContractResolve.Location = New System.Drawing.Point(44, 357)
        Me.btnServiceContractResolve.Name = "btnServiceContractResolve"
        Me.btnServiceContractResolve.Size = New System.Drawing.Size(323, 38)
        Me.btnServiceContractResolve.TabIndex = 5
        Me.btnServiceContractResolve.Text = "Service Resolve"
        Me.btnServiceContractResolve.UseVisualStyleBackColor = False
        '
        'btnServiceContractAllocate
        '
        Me.btnServiceContractAllocate.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnServiceContractAllocate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnServiceContractAllocate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceContractAllocate.ForeColor = System.Drawing.Color.Transparent
        Me.btnServiceContractAllocate.Location = New System.Drawing.Point(44, 313)
        Me.btnServiceContractAllocate.Name = "btnServiceContractAllocate"
        Me.btnServiceContractAllocate.Size = New System.Drawing.Size(323, 38)
        Me.btnServiceContractAllocate.TabIndex = 4
        Me.btnServiceContractAllocate.Text = "Service Allocate"
        Me.btnServiceContractAllocate.UseVisualStyleBackColor = False
        '
        'btnServiceContractUpdation
        '
        Me.btnServiceContractUpdation.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnServiceContractUpdation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnServiceContractUpdation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceContractUpdation.ForeColor = System.Drawing.Color.Transparent
        Me.btnServiceContractUpdation.Location = New System.Drawing.Point(44, 269)
        Me.btnServiceContractUpdation.Name = "btnServiceContractUpdation"
        Me.btnServiceContractUpdation.Size = New System.Drawing.Size(323, 38)
        Me.btnServiceContractUpdation.TabIndex = 3
        Me.btnServiceContractUpdation.Text = "Service Updation"
        Me.btnServiceContractUpdation.UseVisualStyleBackColor = False
        '
        'btnContractShow
        '
        Me.btnContractShow.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnContractShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnContractShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContractShow.ForeColor = System.Drawing.Color.Transparent
        Me.btnContractShow.Location = New System.Drawing.Point(44, 136)
        Me.btnContractShow.Name = "btnContractShow"
        Me.btnContractShow.Size = New System.Drawing.Size(323, 38)
        Me.btnContractShow.TabIndex = 1
        Me.btnContractShow.Text = "Service Contract"
        Me.btnContractShow.UseVisualStyleBackColor = False
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
        Me.pnlMain.Size = New System.Drawing.Size(951, 602)
        Me.pnlMain.TabIndex = 3
        '
        'pnlOperation
        '
        Me.pnlOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOperation.Location = New System.Drawing.Point(419, 10)
        Me.pnlOperation.Name = "pnlOperation"
        Me.pnlOperation.Size = New System.Drawing.Size(522, 582)
        Me.pnlOperation.TabIndex = 4
        '
        'btnServiceReminder
        '
        Me.btnServiceReminder.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnServiceReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnServiceReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceReminder.ForeColor = System.Drawing.Color.Transparent
        Me.btnServiceReminder.Location = New System.Drawing.Point(44, 224)
        Me.btnServiceReminder.Name = "btnServiceReminder"
        Me.btnServiceReminder.Size = New System.Drawing.Size(323, 38)
        Me.btnServiceReminder.TabIndex = 7
        Me.btnServiceReminder.Text = "Service Reminder"
        Me.btnServiceReminder.UseVisualStyleBackColor = False
        '
        'Dashboard_AMC_Module_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 602)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Dashboard_AMC_Module_Form"
        Me.Text = "Dashboard_AMC_Module_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnContractDetails As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnServiceContractResolve As Button
    Friend WithEvents btnServiceContractAllocate As Button
    Friend WithEvents btnServiceContractUpdation As Button
    Friend WithEvents btnContractShow As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlOperation As Panel
    Friend WithEvents btnAmcMaster As Button
    Friend WithEvents btnServiceReminder As Button
End Class
