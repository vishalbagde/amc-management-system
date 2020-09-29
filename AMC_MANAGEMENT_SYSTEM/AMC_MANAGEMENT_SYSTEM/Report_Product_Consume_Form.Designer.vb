<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Product_Consume_Form
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
        Me.dgvProductConsume = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.cbReportDate = New System.Windows.Forms.ComboBox()
        Me.lblCustNameOrId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.mtxtTo = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtFrom = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgvProductConsume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProductConsume
        '
        Me.dgvProductConsume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductConsume.Location = New System.Drawing.Point(15, 170)
        Me.dgvProductConsume.Margin = New System.Windows.Forms.Padding(10)
        Me.dgvProductConsume.Name = "dgvProductConsume"
        Me.dgvProductConsume.Size = New System.Drawing.Size(886, 378)
        Me.dgvProductConsume.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.mtxtFrom)
        Me.Panel1.Controls.Add(Me.mtxtTo)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.cbReportDate)
        Me.Panel1.Controls.Add(Me.lblCustNameOrId)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(886, 151)
        Me.Panel1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(836, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(533, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(422, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "From"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Green
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSelect.Location = New System.Drawing.Point(656, 92)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(83, 28)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'cbReportDate
        '
        Me.cbReportDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReportDate.FormattingEnabled = True
        Me.cbReportDate.Location = New System.Drawing.Point(211, 93)
        Me.cbReportDate.Margin = New System.Windows.Forms.Padding(10)
        Me.cbReportDate.Name = "cbReportDate"
        Me.cbReportDate.Size = New System.Drawing.Size(198, 28)
        Me.cbReportDate.TabIndex = 1
        '
        'lblCustNameOrId
        '
        Me.lblCustNameOrId.AutoSize = True
        Me.lblCustNameOrId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustNameOrId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCustNameOrId.Location = New System.Drawing.Point(207, 72)
        Me.lblCustNameOrId.Name = "lblCustNameOrId"
        Me.lblCustNameOrId.Size = New System.Drawing.Size(48, 20)
        Me.lblCustNameOrId.TabIndex = 2
        Me.lblCustNameOrId.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Consume Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Size = New System.Drawing.Size(919, 580)
        Me.pnlMain.TabIndex = 8
        '
        'mtxtTo
        '
        Me.mtxtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTo.Location = New System.Drawing.Point(536, 94)
        Me.mtxtTo.Mask = "00/00/0000"
        Me.mtxtTo.Name = "mtxtTo"
        Me.mtxtTo.Size = New System.Drawing.Size(101, 26)
        Me.mtxtTo.TabIndex = 3
        Me.mtxtTo.ValidatingType = GetType(Date)
        '
        'mtxtFrom
        '
        Me.mtxtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtFrom.Location = New System.Drawing.Point(422, 95)
        Me.mtxtFrom.Mask = "00/00/0000"
        Me.mtxtFrom.Name = "mtxtFrom"
        Me.mtxtFrom.Size = New System.Drawing.Size(101, 26)
        Me.mtxtFrom.TabIndex = 2
        Me.mtxtFrom.ValidatingType = GetType(Date)
        '
        'Report_Product_Consume_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 580)
        Me.Controls.Add(Me.dgvProductConsume)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Report_Product_Consume_Form"
        Me.Text = "Report_Product_Consume_Form"
        CType(Me.dgvProductConsume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvProductConsume As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents cbReportDate As ComboBox
    Friend WithEvents lblCustNameOrId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents mtxtFrom As MaskedTextBox
    Friend WithEvents mtxtTo As MaskedTextBox
End Class
