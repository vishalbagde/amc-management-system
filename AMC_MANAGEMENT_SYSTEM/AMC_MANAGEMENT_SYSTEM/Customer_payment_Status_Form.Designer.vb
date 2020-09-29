<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_payment_Status_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvCustPaymentDetails = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblCustNameOrId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalPending = New System.Windows.Forms.Label()
        Me.lblTotalRemaining = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvCustPaymentDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlMain.Controls.Add(Me.lblTotalRemaining)
        Me.pnlMain.Controls.Add(Me.lblTotalPending)
        Me.pnlMain.Controls.Add(Me.lblTotalAmount)
        Me.pnlMain.Controls.Add(Me.lblTotal)
        Me.pnlMain.Controls.Add(Me.dgvCustPaymentDetails)
        Me.pnlMain.Controls.Add(Me.Panel1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Size = New System.Drawing.Size(865, 545)
        Me.pnlMain.TabIndex = 6
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalAmount.Location = New System.Drawing.Point(375, 468)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(144, 23)
        Me.lblTotalAmount.TabIndex = 12
        Me.lblTotalAmount.Text = "Total"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.Location = New System.Drawing.Point(19, 469)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(133, 23)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvCustPaymentDetails
        '
        Me.dgvCustPaymentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustPaymentDetails.Location = New System.Drawing.Point(19, 165)
        Me.dgvCustPaymentDetails.Margin = New System.Windows.Forms.Padding(10)
        Me.dgvCustPaymentDetails.Name = "dgvCustPaymentDetails"
        Me.dgvCustPaymentDetails.Size = New System.Drawing.Size(818, 327)
        Me.dgvCustPaymentDetails.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.txtCustName)
        Me.Panel1.Controls.Add(Me.lblCustNameOrId)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(20, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(820, 151)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(769, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Green
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSelect.Location = New System.Drawing.Point(497, 98)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 6
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(249, 99)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(204, 20)
        Me.txtCustName.TabIndex = 3
        '
        'lblCustNameOrId
        '
        Me.lblCustNameOrId.AutoSize = True
        Me.lblCustNameOrId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustNameOrId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCustNameOrId.Location = New System.Drawing.Point(117, 100)
        Me.lblCustNameOrId.Name = "lblCustNameOrId"
        Me.lblCustNameOrId.Size = New System.Drawing.Size(126, 16)
        Me.lblCustNameOrId.TabIndex = 2
        Me.lblCustNameOrId.Text = "Customer Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(26, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Payment Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPending
        '
        Me.lblTotalPending.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTotalPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPending.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalPending.Location = New System.Drawing.Point(693, 468)
        Me.lblTotalPending.Name = "lblTotalPending"
        Me.lblTotalPending.Size = New System.Drawing.Size(144, 23)
        Me.lblTotalPending.TabIndex = 13
        Me.lblTotalPending.Text = "Total"
        Me.lblTotalPending.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalRemaining
        '
        Me.lblTotalRemaining.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTotalRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRemaining.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalRemaining.Location = New System.Drawing.Point(535, 468)
        Me.lblTotalRemaining.Name = "lblTotalRemaining"
        Me.lblTotalRemaining.Size = New System.Drawing.Size(144, 23)
        Me.lblTotalRemaining.TabIndex = 14
        Me.lblTotalRemaining.Text = "Total"
        Me.lblTotalRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Customer_payment_Status_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 545)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Customer_payment_Status_Form"
        Me.Text = "Customer_payment_Status_Form"
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvCustPaymentDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblCustNameOrId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCustPaymentDetails As DataGridView
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalRemaining As Label
    Friend WithEvents lblTotalPending As Label
End Class
