<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contract_Service_Allocation_Form
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCustInfo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvServiceList = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbEmpId = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblServiceId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtContractId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWorkDetails = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mtxtTimeOut = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtTimeIn = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxtServiceDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbCustId = New System.Windows.Forms.ComboBox()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProductDetails = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvServiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlMain.Controls.Add(Me.Panel3)
        Me.pnlMain.Controls.Add(Me.Panel1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Size = New System.Drawing.Size(957, 594)
        Me.pnlMain.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblCustInfo)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(7, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(925, 448)
        Me.Panel3.TabIndex = 3
        '
        'lblCustInfo
        '
        Me.lblCustInfo.AutoSize = True
        Me.lblCustInfo.Location = New System.Drawing.Point(446, 37)
        Me.lblCustInfo.Name = "lblCustInfo"
        Me.lblCustInfo.Size = New System.Drawing.Size(54, 13)
        Me.lblCustInfo.TabIndex = 0
        Me.lblCustInfo.Text = "Payment :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvServiceList)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(436, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 328)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Service List"
        '
        'dgvServiceList
        '
        Me.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiceList.Location = New System.Drawing.Point(13, 32)
        Me.dgvServiceList.Margin = New System.Windows.Forms.Padding(10)
        Me.dgvServiceList.Name = "dgvServiceList"
        Me.dgvServiceList.Size = New System.Drawing.Size(424, 283)
        Me.dgvServiceList.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbEmpId)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblServiceId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnGo)
        Me.GroupBox1.Controls.Add(Me.txtContractId)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtRemark)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtWorkDetails)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.mtxtTimeOut)
        Me.GroupBox1.Controls.Add(Me.mtxtTimeIn)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.mtxtServiceDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbCustId)
        Me.GroupBox1.Controls.Add(Me.lblCustName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 403)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Service Details"
        '
        'cbEmpId
        '
        Me.cbEmpId.FormattingEnabled = True
        Me.cbEmpId.Location = New System.Drawing.Point(123, 193)
        Me.cbEmpId.Name = "cbEmpId"
        Me.cbEmpId.Size = New System.Drawing.Size(272, 24)
        Me.cbEmpId.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Allocated To"
        '
        'lblServiceId
        '
        Me.lblServiceId.AutoSize = True
        Me.lblServiceId.Location = New System.Drawing.Point(309, 25)
        Me.lblServiceId.Name = "lblServiceId"
        Me.lblServiceId.Size = New System.Drawing.Size(74, 16)
        Me.lblServiceId.TabIndex = 43
        Me.lblServiceId.Text = "ServiceId"
        Me.lblServiceId.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Or"
        '
        'btnGo
        '
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Location = New System.Drawing.Point(199, 18)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(41, 23)
        Me.btnGo.TabIndex = 42
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtContractId
        '
        Me.txtContractId.Location = New System.Drawing.Point(125, 18)
        Me.txtContractId.Name = "txtContractId"
        Me.txtContractId.Size = New System.Drawing.Size(57, 22)
        Me.txtContractId.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Contract No:"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(124, 294)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(197, 48)
        Me.txtRemark.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(208, 359)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 31)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Remark :"
        '
        'txtWorkDetails
        '
        Me.txtWorkDetails.Location = New System.Drawing.Point(125, 235)
        Me.txtWorkDetails.Multiline = True
        Me.txtWorkDetails.Name = "txtWorkDetails"
        Me.txtWorkDetails.Size = New System.Drawing.Size(197, 48)
        Me.txtWorkDetails.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(124, 359)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 31)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Work Detail :"
        '
        'mtxtTimeOut
        '
        Me.mtxtTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTimeOut.Location = New System.Drawing.Point(263, 153)
        Me.mtxtTimeOut.Mask = "90:00"
        Me.mtxtTimeOut.Name = "mtxtTimeOut"
        Me.mtxtTimeOut.Size = New System.Drawing.Size(58, 22)
        Me.mtxtTimeOut.TabIndex = 6
        '
        'mtxtTimeIn
        '
        Me.mtxtTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTimeIn.Location = New System.Drawing.Point(124, 153)
        Me.mtxtTimeIn.Mask = "00:00"
        Me.mtxtTimeIn.Name = "mtxtTimeIn"
        Me.mtxtTimeIn.Size = New System.Drawing.Size(58, 22)
        Me.mtxtTimeIn.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(196, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Time Out :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Time In :"
        '
        'mtxtServiceDate
        '
        Me.mtxtServiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtServiceDate.Location = New System.Drawing.Point(125, 109)
        Me.mtxtServiceDate.Mask = "00/00/0000"
        Me.mtxtServiceDate.Name = "mtxtServiceDate"
        Me.mtxtServiceDate.Size = New System.Drawing.Size(88, 22)
        Me.mtxtServiceDate.TabIndex = 4
        Me.mtxtServiceDate.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Service Date :"
        '
        'cbCustId
        '
        Me.cbCustId.FormattingEnabled = True
        Me.cbCustId.Location = New System.Drawing.Point(126, 71)
        Me.cbCustId.Name = "cbCustId"
        Me.cbCustId.Size = New System.Drawing.Size(272, 24)
        Me.cbCustId.TabIndex = 3
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(20, 76)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(103, 13)
        Me.lblCustName.TabIndex = 6
        Me.lblCustName.Text = "Customer Name :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.lblProductDetails)
        Me.Panel1.Location = New System.Drawing.Point(7, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 100)
        Me.Panel1.TabIndex = 0
        '
        'lblProductDetails
        '
        Me.lblProductDetails.AutoSize = True
        Me.lblProductDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblProductDetails.Location = New System.Drawing.Point(338, 33)
        Me.lblProductDetails.Name = "lblProductDetails"
        Me.lblProductDetails.Size = New System.Drawing.Size(270, 37)
        Me.lblProductDetails.TabIndex = 0
        Me.lblProductDetails.Text = "Service Allocation"
        Me.lblProductDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Contract_Service_Allocation_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 594)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Contract_Service_Allocation_Form"
        Me.Text = "Contract_Service_Allocation_Form"
        Me.pnlMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvServiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCustInfo As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvServiceList As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblServiceId As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents txtContractId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtWorkDetails As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents mtxtTimeOut As MaskedTextBox
    Friend WithEvents mtxtTimeIn As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtxtServiceDate As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbCustId As ComboBox
    Friend WithEvents lblCustName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblProductDetails As Label
    Friend WithEvents cbEmpId As ComboBox
    Friend WithEvents Label3 As Label
End Class
